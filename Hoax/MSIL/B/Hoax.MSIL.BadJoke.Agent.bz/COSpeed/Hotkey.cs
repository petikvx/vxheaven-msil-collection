using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace COSpeed;

public class Hotkey : IMessageFilter
{
	private const uint WM_HOTKEY = 786u;

	private const uint MOD_ALT = 1u;

	private const uint MOD_CONTROL = 2u;

	private const uint MOD_SHIFT = 4u;

	private const uint MOD_WIN = 8u;

	private const uint ERROR_HOTKEY_ALREADY_REGISTERED = 1409u;

	private const int maximumID = 49151;

	private static int currentID;

	private Keys keyCode;

	private bool shift;

	private bool control;

	private bool alt;

	private bool windows;

	[XmlIgnore]
	private int id;

	[XmlIgnore]
	private bool registered;

	[XmlIgnore]
	private Control windowControl;

	public bool Empty => (int)keyCode == 0;

	public bool Registered => registered;

	public Keys KeyCode
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return keyCode;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			keyCode = value;
			Reregister();
		}
	}

	public bool Shift
	{
		get
		{
			return shift;
		}
		set
		{
			shift = value;
			Reregister();
		}
	}

	public bool Control
	{
		get
		{
			return control;
		}
		set
		{
			control = value;
			Reregister();
		}
	}

	public bool Alt
	{
		get
		{
			return alt;
		}
		set
		{
			alt = value;
			Reregister();
		}
	}

	public bool Windows
	{
		get
		{
			return windows;
		}
		set
		{
			windows = value;
			Reregister();
		}
	}

	public event HandledEventHandler Pressed;

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int UnregisterHotKey(IntPtr hWnd, int id);

	public Hotkey()
		: this((Keys)0, shift: false, control: false, alt: false, windows: false)
	{
	}

	public Hotkey(Keys keyCode, bool shift, bool control, bool alt, bool windows)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		KeyCode = keyCode;
		Shift = shift;
		Control = control;
		Alt = alt;
		Windows = windows;
		Application.AddMessageFilter((IMessageFilter)(object)this);
	}

	~Hotkey()
	{
		if (Registered)
		{
			Unregister();
		}
	}

	public Hotkey Clone()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new Hotkey(keyCode, shift, control, alt, windows);
	}

	public bool GetCanRegister(Control windowControl)
	{
		try
		{
			if (!Register(windowControl))
			{
				return false;
			}
			Unregister();
			return true;
		}
		catch (Win32Exception)
		{
			return false;
		}
		catch (NotSupportedException)
		{
			return false;
		}
	}

	public bool Register(Control windowControl)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (registered)
		{
			throw new NotSupportedException("You cannot register a hotkey that is already registered");
		}
		if (Empty)
		{
			throw new NotSupportedException("You cannot register an empty hotkey");
		}
		id = currentID;
		currentID++;
		uint fsModifiers = (Alt ? 1u : 0u) | (Control ? 2u : 0u) | (Shift ? 4u : 0u) | (Windows ? 8u : 0u);
		if (RegisterHotKey(windowControl.get_Handle(), id, fsModifiers, keyCode) == 0)
		{
			if (Marshal.GetLastWin32Error() == 1409L)
			{
				return false;
			}
			throw new Win32Exception();
		}
		registered = true;
		this.windowControl = windowControl;
		return true;
	}

	public void Unregister()
	{
		if (!registered)
		{
			throw new NotSupportedException("You cannot unregister a hotkey that is not registered");
		}
		if (!windowControl.get_IsDisposed() && UnregisterHotKey(windowControl.get_Handle(), id) == 0)
		{
			throw new Win32Exception();
		}
		registered = false;
		windowControl = null;
	}

	private void Reregister()
	{
		if (registered)
		{
			Control val = windowControl;
			Unregister();
			Register(val);
		}
	}

	public bool PreFilterMessage(ref Message message)
	{
		if (((Message)(ref message)).get_Msg() != 786L)
		{
			return false;
		}
		if (registered && ((Message)(ref message)).get_WParam().ToInt32() == id)
		{
			return OnPressed();
		}
		return false;
	}

	private bool OnPressed()
	{
		HandledEventArgs handledEventArgs = new HandledEventArgs(defaultHandledValue: false);
		if (this.Pressed != null)
		{
			this.Pressed(this, handledEventArgs);
		}
		return handledEventArgs.Handled;
	}

	public override string ToString()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected I4, but got Unknown
		if (Empty)
		{
			return "(none)";
		}
		string text = Enum.GetName(typeof(Keys), keyCode);
		Keys val = keyCode;
		switch (val - 48)
		{
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
			text = text.Substring(1);
			break;
		}
		string text2 = "";
		if (shift)
		{
			text2 += "Shift+";
		}
		if (control)
		{
			text2 += "Control+";
		}
		if (alt)
		{
			text2 += "Alt+";
		}
		if (windows)
		{
			text2 += "Windows+";
		}
		return text2 + text;
	}
}
