using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace DevComponents.DotNetBar;

internal class Class51
{
	[StructLayout(LayoutKind.Sequential)]
	public class BITMAPINFO
	{
		public int biSize;

		public int biWidth;

		public int biHeight;

		public short biPlanes;

		public short biBitCount;

		public int biCompression;

		public int biSizeImage;

		public int biXPelsPerMeter;

		public int biYPelsPerMeter;

		public int biClrUsed;

		public int biClrImportant;

		public byte bmiColors_rgbBlue;

		public byte bmiColors_rgbGreen;

		public byte bmiColors_rgbRed;

		public byte bmiColors_rgbReserved;
	}

	public enum ComboNotificationCodes
	{
		CBN_DROPDOWN = 7,
		CBN_CLOSEUP
	}

	public enum DWMNCRENDERINGPOLICY
	{
		DWMNCRP_USEWINDOWSTYLE,
		DWMNCRP_DISABLED,
		DWMNCRP_ENABLED,
		DWMNCRP_LAST
	}

	public enum DWMWINDOWATTRIBUTE
	{
		DWMWA_NCRENDERING_ENABLED = 1,
		DWMWA_NCRENDERING_POLICY,
		DWMWA_TRANSITIONS_FORCEDISABLED,
		DWMWA_ALLOW_NCPAINT,
		DWMWA_LAST
	}

	public enum eObjectId : uint
	{
		OBJID_CLIENT = 4294967292u,
		OBJID_VSCROLL = 4294967291u,
		OBJID_HSCROLL = 4294967290u
	}

	public enum eScrollBarDirection
	{
		SB_HORZ,
		SB_VERT
	}

	public enum eScrollInfoMask
	{
		SIF_RANGE = 1,
		SIF_PAGE = 2,
		SIF_POS = 4,
		SIF_DISABLENOSCROLL = 8,
		SIF_TRACKPOS = 16,
		SIF_ALL = 23
	}

	public enum eStateFlags
	{
		STATE_SYSTEM_INVISIBLE = 32768,
		STATE_SYSTEM_OFFSCREEN = 65536,
		STATE_SYSTEM_PRESSED = 8,
		STATE_SYSTEM_UNAVAILABLE = 1
	}

	public enum GWL
	{
		GWL_WNDPROC = -4,
		GWL_HINSTANCE = -6,
		GWL_HWNDPARENT = -8,
		GWL_STYLE = -16,
		GWL_EXSTYLE = -20,
		GWL_USERDATA = -21,
		GWL_ID = -12
	}

	public struct MARGINS
	{
		public int cxLeftWidth;

		public int cxRightWidth;

		public int cyTopHeight;

		public int cyBottomHeight;
	}

	public enum MouseKeyState
	{
		MK_LBUTTON = 1,
		MK_RBUTTON = 2,
		MK_SHIFT = 4,
		MK_CONTROL = 8,
		MK_MBUTTON = 0x10,
		MK_XBUTTON1 = 0x20,
		MK_XBUTTON2 = 0x40
	}

	public struct NCCALCSIZE_PARAMS
	{
		public RECT rgrc0;

		public RECT rgrc1;

		public RECT rgrc2;

		public IntPtr lppos;
	}

	public struct PAINTSTRUCT
	{
		public IntPtr hdc;

		public int fErase;

		public RECT rcPaint;

		public int fRestore;

		public int fIncUpdate;

		public int Reserved1;

		public int Reserved2;

		public int Reserved3;

		public int Reserved4;

		public int Reserved5;

		public int Reserved6;

		public int Reserved7;

		public int Reserved8;
	}

	public struct POINT
	{
		public int x;

		public int y;

		public POINT(Point p)
		{
			x = p.X;
			y = p.Y;
		}

		public POINT(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}

	[Serializable]
	public struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;

		public int Height => Bottom - Top;

		public int Width => Right - Left;

		public Size Size => new Size(Width, Height);

		public Point Location => new Point(Left, Top);

		public RECT(int left_, int top_, int right_, int bottom_)
		{
			Left = left_;
			Top = top_;
			Right = right_;
			Bottom = bottom_;
		}

		public RECT(Rectangle r)
		{
			Left = r.Left;
			Top = r.Top;
			Right = r.Right;
			Bottom = r.Bottom;
		}

		public Rectangle ToRectangle()
		{
			return Rectangle.FromLTRB(Left, Top, Right, Bottom);
		}

		public static RECT FromRectangle(Rectangle rectangle)
		{
			return new RECT(rectangle.Left, rectangle.Top, rectangle.Right, rectangle.Bottom);
		}

		public override int GetHashCode()
		{
			return Left ^ ((Top << 13) | (Top >> 19)) ^ ((Width << 26) | (Width >> 6)) ^ ((Height << 7) | (Height >> 25));
		}

		public static implicit operator Rectangle(RECT rect)
		{
			return Rectangle.FromLTRB(rect.Left, rect.Top, rect.Right, rect.Bottom);
		}

		public static implicit operator RECT(Rectangle rect)
		{
			return new RECT(rect.Left, rect.Top, rect.Right, rect.Bottom);
		}

		public override string ToString()
		{
			return "Left=" + Left + ", Top=" + Top + ", Right=" + Right + ", Bottom=" + Bottom;
		}
	}

	public enum RedrawWindowFlags : uint
	{
		RDW_INVALIDATE = 1u,
		RDW_INTERNALPAINT = 2u,
		RDW_ERASE = 4u,
		RDW_VALIDATE = 8u,
		RDW_NOINTERNALPAINT = 0x10u,
		RDW_NOERASE = 0x20u,
		RDW_NOCHILDREN = 0x40u,
		RDW_ALLCHILDREN = 0x80u,
		RDW_UPDATENOW = 0x100u,
		RDW_ERASENOW = 0x200u,
		RDW_FRAME = 0x400u,
		RDW_NOFRAME = 0x800u
	}

	public struct SCROLLBARINFO
	{
		public int cbSize;

		public RECT rcScrollBar;

		public int dxyLineButton;

		public int xyThumbTop;

		public int xyThumbBottom;

		public int reserved;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
		public int[] rgstate;
	}

	public struct SCROLLINFO
	{
		public int cbSize;

		public int fMask;

		public int nMin;

		public int nMax;

		public int nPage;

		public int nPos;

		public int nTrackPos;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class TEXTMETRIC
	{
		public int tmHeight;

		public int tmAscent;

		public int tmDescent;

		public int tmInternalLeading;

		public int tmExternalLeading;

		public int tmAveCharWidth;

		public int tmMaxCharWidth;

		public int tmWeight;

		public int tmOverhang;

		public int tmDigitizedAspectX;

		public int tmDigitizedAspectY;

		public char tmFirstChar;

		public char tmLastChar;

		public char tmDefaultChar;

		public char tmBreakChar;

		public byte tmItalic;

		public byte tmUnderlined;

		public byte tmStruckOut;

		public byte tmPitchAndFamily;

		public byte tmCharSet;
	}

	public delegate void TimerDelegate(IntPtr hWnd, IntPtr uMsg, IntPtr idEvent, int dwTime);

	public enum WindowHitTestRegions
	{
		Error = -2,
		TransparentOrCovered = -1,
		NoWhere = 0,
		ClientArea = 1,
		TitleBar = 2,
		SystemMenu = 3,
		GrowBox = 4,
		Menu = 5,
		HorizontalScrollBar = 6,
		VerticalScrollBar = 7,
		MinimizeButton = 8,
		MaximizeButton = 9,
		LeftSizeableBorder = 10,
		RightSizeableBorder = 11,
		TopSizeableBorder = 12,
		TopLeftSizeableCorner = 13,
		TopRightSizeableCorner = 14,
		BottomSizeableBorder = 15,
		BottomLeftSizeableCorner = 16,
		BottomRightSizeableCorner = 17,
		NonSizableBorder = 18,
		Object = 19,
		CloseButton = 20,
		HelpButton = 21,
		SizeBox = 4,
		ReduceButton = 9,
		ZoomButton = 9
	}

	public struct WINDOWPOS
	{
		public IntPtr hwnd;

		public IntPtr hwndInsertAfter;

		public int x;

		public int y;

		public int cx;

		public int cy;

		public int flags;
	}

	public enum WindowsMessages
	{
		WM_NCPAINT = 133,
		WM_NCCALCSIZE = 131,
		WM_NCACTIVATE = 134,
		WM_SETTEXT = 12,
		WM_INITMENUPOPUP = 279,
		WM_WINDOWPOSCHANGED = 71,
		WM_NCHITTEST = 132,
		WM_ERASEBKGND = 20,
		WM_NCMOUSEMOVE = 160,
		WM_NCLBUTTONDOWN = 161,
		WM_NCMOUSELEAVE = 674,
		WM_NCLBUTTONUP = 162,
		WM_NCMOUSEHOVER = 672,
		WM_SETCURSOR = 32,
		WM_SETICON = 128,
		WM_HSCROLL = 276,
		WM_VSCROLL = 277,
		WM_MOUSEWHEEL = 522,
		WM_STYLECHANGED = 125,
		WM_NCLBUTTONDBLCLK = 163,
		WM_MOUSEACTIVATE = 33,
		WM_MOUSEMOVE = 512,
		WM_MDISETMENU = 560,
		WM_MDIREFRESHMENU = 564,
		WM_KEYDOWN = 256,
		WM_SIZE = 5,
		WM_DWMCOMPOSITIONCHANGED = 798,
		WM_DRAWITEM = 43,
		SBM_SETPOS = 224,
		SBM_SETSCROLLINFO = 233,
		EM_GETMODIFY = 184,
		EM_SETMODIFY = 185,
		WM_LBUTTONUP = 514,
		WM_LBUTTONDOWN = 513,
		WM_LBUTTONDBLCLK = 515,
		WM_SYSTIMER = 280,
		WM_SETFOCUS = 7,
		WM_KILLFOCUS = 8,
		WM_PAINT = 15,
		WM_COMMAND = 273,
		WM_CTLCOLORBTN = 309,
		WM_CTLCOLORSCROLLBAR = 311,
		WM_MDIACTIVATE = 546,
		WM_CAPTURECHANGED = 533,
		CB_GETDROPPEDSTATE = 343,
		WVR_VALIDRECTS = 1024
	}

	[Flags]
	public enum WindowStyles
	{
		WS_VISIBLE = 0x10000000,
		WS_CAPTION = 0xC00000
	}

	public static bool Boolean_0
	{
		get
		{
			if (Environment.OSVersion.Version.Major < 6)
			{
				return false;
			}
			return DwmIsCompositionEnabled();
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern short GetKeyState(int keyCode);

	[DllImport("user32.dll")]
	public static extern bool IsZoomed(IntPtr hWnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr BeginPaint(IntPtr hWnd, ref PAINTSTRUCT ps);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT ps);

	[DllImport("gdi32.dll")]
	public static extern int ExcludeClipRect(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

	[DllImport("user32")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern bool GetTextMetrics(HandleRef hdc, TEXTMETRIC tm);

	[DllImport("user32.dll")]
	public static extern bool SetMenu(IntPtr hWnd, IntPtr hMenu);

	[DllImport("user32.dll")]
	public static extern IntPtr GetMenu(IntPtr hWnd);

	[DllImport("user32")]
	public static extern bool RedrawWindow(IntPtr hWnd, [In] ref RECT lprcUpdate, IntPtr hrgnUpdate, RedrawWindowFlags flags);

	[DllImport("user32")]
	public static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, RedrawWindowFlags flags);

	[DllImport("user32")]
	public static extern bool GetWindowRect(IntPtr hWnd, ref RECT r);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern int GetScrollBarInfo(IntPtr hWnd, uint idObject, ref SCROLLBARINFO psbi);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetScrollInfo(IntPtr hwnd, int fnBar, ref SCROLLINFO lpsi);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern int SetScrollInfo(HandleRef hWnd, int fnBar, ref SCROLLINFO si, bool redraw);

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowDC(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern bool AdjustWindowRectEx(ref RECT lpRect, int dwStyle, bool bMenu, int dwExStyle);

	public static IntPtr smethod_0(IntPtr intptr_0, int int_0)
	{
		if (IntPtr.Size == 8)
		{
			return GetWindowLongPtr(intptr_0, int_0);
		}
		return new IntPtr(GetWindowLong(intptr_0, int_0));
	}

	[DllImport("user32.dll")]
	public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

	[DllImport("user32.dll")]
	public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern int MapWindowPoints(IntPtr hwndFrom, IntPtr hwndTo, ref POINT lpPoints, [MarshalAs(UnmanagedType.U4)] int cPoints);

	[DllImport("user32")]
	public static extern bool PostMessage(int hWnd, int Msg, int wParam, int lParam);

	[DllImport("user32")]
	public static extern bool PostMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern bool DeleteDC(IntPtr hDC);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr CreateDIBSection(IntPtr hdc, BITMAPINFO pbmi, uint iUsage, int ppvBits, IntPtr hSection, uint dwOffset);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern bool BitBlt(IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, uint dwRop);

	[DllImport("gdi32")]
	public static extern bool DeleteObject(IntPtr hObject);

	[DllImport("gdi32")]
	public static extern bool DeleteObject(int hObject);

	[DllImport("user32.dll")]
	public static extern UIntPtr SetTimer(IntPtr hWnd, UIntPtr nIDEvent, uint uElapse, TimerDelegate lpTimerFunc);

	[DllImport("user32.dll")]
	public static extern bool KillTimer(IntPtr hWnd, UIntPtr uIDEvent);

	internal static bool smethod_1(IntPtr intptr_0, int int_0, int int_1)
	{
		int num = smethod_0(intptr_0, -16).ToInt32();
		int num2 = (num & ~int_0) | int_1;
		if (num == num2)
		{
			return false;
		}
		SetWindowLong(intptr_0, -16, num2);
		return true;
	}

	public static int smethod_2(int int_0)
	{
		return (short)(int_0 & 0xFFFF);
	}

	public static int smethod_3(int int_0)
	{
		return (short)((int_0 >> 16) & 0xFFFF);
	}

	public static int smethod_4(IntPtr intptr_0)
	{
		return smethod_2((int)(long)intptr_0);
	}

	public static int smethod_5(IntPtr intptr_0)
	{
		return smethod_3((int)(long)intptr_0);
	}

	public static IntPtr smethod_6(int int_0, int int_1)
	{
		byte[] bytes = BitConverter.GetBytes(int_0);
		byte[] bytes2 = BitConverter.GetBytes(int_1);
		byte[] value = new byte[4]
		{
			bytes[0],
			bytes[1],
			bytes2[0],
			bytes2[1]
		};
		return new IntPtr(BitConverter.ToInt32(value, 0));
	}

	[DllImport("dwmapi.dll")]
	public static extern int DwmSetWindowAttribute(IntPtr hWnd, int dwAttribute, ref int attributeValue, int sizeOfValueRetrived);

	[DllImport("dwmapi.dll")]
	public static extern int DwmGetWindowAttribute(IntPtr hwnd, int dwAttribute, ref int pvAttribute, int sizeOfValueRetrived);

	[DllImport("dwmapi.dll", PreserveSig = false)]
	private static extern bool DwmIsCompositionEnabled();

	[DllImport("dwmapi.dll")]
	public static extern int DwmDefWindowProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, out IntPtr plResult);

	[DllImport("dwmapi.dll")]
	private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMargins);

	public static void smethod_7(IntPtr intptr_0, int int_0)
	{
		MARGINS pMargins = default(MARGINS);
		pMargins.cxLeftWidth = 0;
		pMargins.cxRightWidth = 0;
		pMargins.cyTopHeight = int_0;
		pMargins.cyBottomHeight = 0;
		DwmExtendFrameIntoClientArea(intptr_0, ref pMargins);
	}
}
