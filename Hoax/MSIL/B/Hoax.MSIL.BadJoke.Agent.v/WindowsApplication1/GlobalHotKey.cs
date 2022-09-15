using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

public class GlobalHotKey : IDisposable
{
	public delegate void HotKeyPressedEventHandler(object sender, EventArgs e);

	private class HiddenForm : Form
	{
		private GlobalHotKey ParentGHK;

		public HiddenForm(GlobalHotKey parent)
		{
			ParentGHK = parent;
		}

		protected override void WndProc(ref Message m)
		{
			((Form)this).WndProc(ref m);
			if (((Message)(ref m)).get_Msg() == 786)
			{
				ParentGHK.NotifyHotKey(((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
			}
		}
	}

	private HotKeyPressedEventHandler HotKeyPressedEvent;

	private static long instances;

	private short hotkeyID;

	private HiddenForm form;

	private IntPtr formHandle;

	private Keys m_HotKey;

	private Keys m_ModifierKeys;

	private const int MOD_ALT = 1;

	private const int MOD_CONTROL = 2;

	private const int MOD_SHIFT = 4;

	private const int MOD_WIN = 8;

	public Keys HotKey => m_HotKey;

	public Keys ModifierKeys => m_ModifierKeys;

	public event HotKeyPressedEventHandler HotKeyPressed
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			HotKeyPressedEvent = (HotKeyPressedEventHandler)Delegate.Combine(HotKeyPressedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			HotKeyPressedEvent = (HotKeyPressedEventHandler)Delegate.Remove(HotKeyPressedEvent, value);
		}
	}

	public GlobalHotKey(Keys hotkey, Keys modifierKeys)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Invalid comparison between Unknown and I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected I4, but got Unknown
		m_HotKey = hotkey;
		m_ModifierKeys = modifierKeys;
		try
		{
			checked
			{
				instances++;
				string lpString = Thread.CurrentThread.ManagedThreadId.ToString("X8") + instances.ToString("X8");
				hotkeyID = GlobalAddAtomA(ref lpString);
				if (hotkeyID == 0)
				{
					throw new Exception("Unable to generate unique hotkey ID. Error code: " + Marshal.GetLastWin32Error());
				}
				form = new HiddenForm(this);
				formHandle = ((Control)form).get_Handle();
			}
			int num = default(int);
			if ((int)modifierKeys == 91)
			{
				num = 8;
			}
			else
			{
				if ((modifierKeys & 0x40000) != 0)
				{
					num = 1;
				}
				if ((modifierKeys & 0x20000) != 0)
				{
					num |= 2;
				}
				if ((modifierKeys & 0x40000) != 0)
				{
					num |= 1;
				}
			}
			if (RegisterHotKey(formHandle, hotkeyID, num, (int)hotkey) == 0)
			{
				throw new Exception("Unable to register hotkey. Error code: " + Marshal.GetLastWin32Error());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Dispose();
			ProjectData.ClearProjectError();
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected override void Finalize()
	{
		Dispose(disposing: false);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!formHandle.Equals((object?)(nint)IntPtr.Zero))
		{
			UnregisterHotKey(formHandle, hotkeyID);
			form = null;
			formHandle = IntPtr.Zero;
		}
		if (hotkeyID != 0)
		{
			GlobalDeleteAtom(hotkeyID);
			hotkeyID = 0;
		}
	}

	private void NotifyHotKey(IntPtr virtKey, IntPtr modifiers)
	{
		HotKeyPressedEvent?.Invoke(this, EventArgs.Empty);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int UnregisterHotKey(IntPtr hwnd, int id);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GlobalAddAtomA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GlobalDeleteAtom(short nAtom);
}
