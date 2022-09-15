using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[SuppressUnmanagedCodeSecurity]
internal class Class92
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct BLENDFUNCTION
	{
		public byte BlendOp;

		public byte BlendFlags;

		public byte SourceConstantAlpha;

		public byte AlphaFormat;
	}

	public struct OSVERSIONINFO
	{
		public int dwOSVersionInfoSize;

		public int dwMajorVersion;

		public int dwMinorVersion;

		public int dwBuildNumber;

		public int dwPlatformId;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string szCSDVersion;
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

	public struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;

		public RECT(int left, int top, int right, int bottom)
		{
			Left = left;
			Top = top;
			Right = right;
			Bottom = bottom;
		}

		public static RECT FromRectangle(Rectangle rectangle)
		{
			return new RECT(rectangle.Left, rectangle.Top, rectangle.Right, rectangle.Bottom);
		}
	}

	public struct SIZE
	{
		public int cx;

		public int cy;
	}

	public struct TRACKMOUSEEVENT
	{
		public int cbSize;

		public uint dwFlags;

		public int dwHoverTime;

		public IntPtr hwndTrack;
	}

	public enum Win23AlphaFlags : byte
	{
		AC_SRC_OVER,
		AC_SRC_ALPHA
	}

	public enum Win32UpdateLayeredWindowsFlags
	{
		ULW_COLORKEY = 1,
		ULW_ALPHA = 2,
		ULW_OPAQUE = 4
	}

	public struct WINDOWPOS
	{
		public int hwnd;

		public int hwndInsertAfter;

		public int x;

		public int y;

		public int cx;

		public int cy;

		public int flags;
	}

	public const uint uint_0 = 4098u;

	public const uint uint_1 = 4114u;

	public const uint uint_2 = 4106u;

	public const uint uint_3 = 4132u;

	public const uint uint_4 = 4122u;

	public const uint uint_5 = 27u;

	public const uint uint_6 = 5u;

	public const int int_0 = 1;

	public const int int_1 = 2;

	private const int int_2 = 10;

	public const int int_3 = 1;

	public const int int_4 = 2;

	public const uint uint_7 = 1u;

	public const uint uint_8 = 2u;

	public const uint uint_9 = 4u;

	public const uint uint_10 = 8u;

	public const uint uint_11 = 3u;

	public const uint uint_12 = 12u;

	public const uint uint_13 = 5u;

	public const uint uint_14 = 10u;

	public const uint uint_15 = 5u;

	public const uint uint_16 = 10u;

	public const uint uint_17 = 6u;

	public const uint uint_18 = 9u;

	public const uint uint_19 = 1u;

	public const uint uint_20 = 2u;

	public const uint uint_21 = 4u;

	public const uint uint_22 = 8u;

	public const uint uint_23 = 3u;

	public const uint uint_24 = 6u;

	public const uint uint_25 = 9u;

	public const uint uint_26 = 12u;

	public const uint uint_27 = 15u;

	public const uint uint_28 = 16u;

	public const uint uint_29 = 22u;

	public const uint uint_30 = 19u;

	public const uint uint_31 = 25u;

	public const uint uint_32 = 28u;

	public const uint uint_33 = 2048u;

	public const uint uint_34 = 4096u;

	public const uint uint_35 = 8192u;

	public const uint uint_36 = 16384u;

	public const uint uint_37 = 32768u;

	public const uint uint_38 = 1u;

	public const uint uint_39 = 2u;

	public const uint uint_40 = 16u;

	public const uint uint_41 = 1073741824u;

	public const uint uint_42 = 2147483648u;

	public const uint uint_43 = uint.MaxValue;

	public const long long_0 = 28L;

	public const int int_5 = 513;

	public const int int_6 = 514;

	public const int int_7 = 515;

	public const int int_8 = 161;

	public const int int_9 = 169;

	public const int int_10 = 134;

	public const int int_11 = 516;

	public const int int_12 = 517;

	public const int int_13 = 519;

	public const int int_14 = 164;

	public const int int_15 = 167;

	public const int int_16 = 123;

	public const int int_17 = 1024;

	public const int int_18 = 512;

	public const int int_19 = 675;

	public const int int_20 = 0;

	public const int int_21 = 1;

	public const int int_22 = -1;

	public const int int_23 = -2;

	public const int int_24 = 2;

	public const int int_25 = 1;

	public const int int_26 = 16;

	public const int int_27 = 4;

	public const int int_28 = 64;

	public const int int_29 = 128;

	public const int int_30 = 32;

	public const int int_31 = 512;

	public const int int_32 = 1024;

	public const int int_33 = 7;

	public const int int_34 = 8;

	public const int int_35 = 24;

	public const int int_36 = 11;

	public const int int_37 = 15;

	public const int int_38 = 522;

	public const int int_39 = 276;

	public const int int_40 = 277;

	public const int int_41 = 260;

	public const int int_42 = 261;

	public const int int_43 = 6;

	public const int int_44 = 0;

	public const int int_45 = 1;

	public const int int_46 = 2;

	public const int int_47 = 1;

	public const int int_48 = 2;

	public const int int_49 = 4;

	public const int int_50 = 8;

	public const int int_51 = 16;

	public const int int_52 = 65536;

	public const int int_53 = 131072;

	public const int int_54 = 262144;

	public const int int_55 = 524288;

	public const int int_56 = 274;

	public const int int_57 = 61536;

	public const int int_58 = 61824;

	public const int int_59 = 61504;

	public const int int_60 = 61520;

	public const int int_61 = 61696;

	public const int int_62 = 61728;

	public const int int_63 = 61472;

	public const int int_64 = 61488;

	public const int int_65 = 61456;

	public const int int_66 = 33;

	public const int int_67 = 3;

	public const int int_68 = 4;

	public const uint uint_44 = 2147483648u;

	public const uint uint_45 = 67108864u;

	public const uint uint_46 = 33554432u;

	public const uint uint_47 = 8u;

	public const uint uint_48 = 128u;

	public const int int_69 = 794;

	public const int int_70 = 792;

	public const int int_71 = 126;

	public const int int_72 = 12;

	public const int int_73 = 4096;

	private static Color color_0 = Color.Empty;

	internal static bool bool_0 = true;

	private static bool bool_1 = true;

	private static bool bool_2 = true;

	public static int int_74 = 0;

	private static bool bool_3 = true;

	private static bool bool_4 = false;

	public static int Int32_0
	{
		get
		{
			int pvParam = 0;
			SystemParametersInfo(5u, 0u, ref pvParam, 0u);
			return pvParam;
		}
	}

	public static ePopupAnimation EPopupAnimation_0
	{
		get
		{
			bool pvParam = false;
			SystemParametersInfo(4098u, 0u, ref pvParam, 0u);
			if (pvParam)
			{
				pvParam = false;
				SystemParametersInfo(4114u, 0u, ref pvParam, 0u);
				if (pvParam)
				{
					return ePopupAnimation.Fade;
				}
				return ePopupAnimation.Slide;
			}
			return ePopupAnimation.None;
		}
	}

	public static bool Boolean_0 => bool_1;

	public static bool Boolean_1 => bool_2;

	public static bool Boolean_2
	{
		get
		{
			if (Environment.OSVersion.Version.Major >= 5)
			{
				return true;
			}
			return false;
		}
	}

	public static bool Boolean_3 => bool_3;

	public static bool Boolean_4 => bool_4;

	internal static bool smethod_0()
	{
		bool_0 = true;
		color_0 = Color.Black;
		return false;
	}

	[DllImport("user32.dll")]
	public static extern int MapWindowPoints(IntPtr hWndFrom, IntPtr hWndTo, ref POINT lpPoints, int cPoints);

	[DllImport("user32.dll")]
	private static extern int GetClassName(IntPtr hWnd, [Out] StringBuilder lpClassName, int nMaxCount);

	[DllImport("user32.dll")]
	public static extern IntPtr GetFocus();

	[DllImport("user32.dll")]
	public static extern IntPtr SetFocus(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32")]
	public static extern IntPtr WindowFromPoint(POINT p);

	[DllImport("user32")]
	public static extern IntPtr ChildWindowFromPoint(IntPtr parent, POINT p);

	[DllImport("user32")]
	public static extern bool DrawIconEx(IntPtr hDC, int X, int Y, IntPtr hIcon, int width, int height, int frameIndex, IntPtr flickerFreeBrush, int flags);

	[DllImport("user32")]
	public static extern uint MapVirtualKey(uint uCode, uint uMapType);

	[DllImport("user32")]
	public static extern bool GetKeyboardState(byte[] state);

	[DllImport("user32.dll")]
	public static extern bool DrawCaption(IntPtr hwnd, IntPtr hdc, ref RECT lprc, Enum6 uFlags);

	[DllImport("user32")]
	public static extern int ToAscii(uint uVirtKey, uint uScanCode, byte[] lpKeyState, byte[] lpChar, uint uFlags);

	[DllImport("user32")]
	public static extern int SetFocus(int hWnd);

	[DllImport("user32")]
	public static extern bool IsWindow(int hWnd);

	[DllImport("user32")]
	public static extern bool TrackMouseEvent(ref TRACKMOUSEEVENT tme);

	[DllImport("user32")]
	public static extern bool DrawEdge(int hdc, ref RECT pRect, uint edge, uint grfFlags);

	[DllImport("user32")]
	public static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

	[DllImport("user32")]
	public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

	[DllImport("user32")]
	public static extern bool RedrawWindow(IntPtr hWnd, [In] ref RECT lprcUpdate, IntPtr hrgnUpdate, uint flags);

	[DllImport("user32")]
	public static extern bool SystemParametersInfo(uint uiAction, uint uiParam, ref bool pvParam, uint fWinIni);

	[DllImport("user32")]
	public static extern bool SystemParametersInfo(uint uiAction, uint uiParam, ref int pvParam, uint fWinIni);

	[DllImport("gdi32")]
	public static extern int SetROP2(int hDC, int DrawMode);

	[DllImport("gdi32")]
	public static extern int SelectClipRgn(IntPtr hDC, int hRgn);

	[DllImport("gdi32")]
	public static extern int CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

	[DllImport("gdi32")]
	public static extern int CreateDC(string lpszDriver, int lpszDevice, int lpszOutput, int lpInitData);

	[DllImport("gdi32")]
	public static extern bool DeleteDC(int hDC);

	[DllImport("user32")]
	public static extern bool DrawFocusRect(int hDC, ref RECT r);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetDC(IntPtr hWnd);

	[DllImport("user32")]
	public static extern bool PostMessage(int hWnd, int Msg, int wParam, int lParam);

	[DllImport("user32")]
	public static extern bool PostMessage(int hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern int TrackPopupMenu(IntPtr hMenu, uint uFlags, int x, int y, int nReserved, IntPtr hWnd, IntPtr prcRect);

	[DllImport("user32.dll")]
	public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

	[DllImport("user32")]
	public static extern IntPtr GetDesktopWindow();

	[DllImport("user32")]
	public static extern IntPtr GetActiveWindow();

	[DllImport("user32")]
	public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, int crKey, byte bAlpha, int dwFlags);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref POINT pptDst, ref SIZE psize, IntPtr hdcSrc, ref POINT pprSrc, int crKey, ref BLENDFUNCTION pblend, int dwFlags);

	[DllImport("winmm")]
	public static extern int sndPlaySound(string lpszSoundName, int uFlags);

	[DllImport("user32")]
	public static extern bool ValidateRect(IntPtr hWnd, ref RECT pRect);

	[DllImport("user32")]
	public static extern bool LockWindowUpdate(IntPtr hWndLock);

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int AnimateWindow(int hWnd, int dwTime, int dwFlags);

	[DllImport("gdi32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int GetDeviceCaps(int hdc, int nIndex);

	[DllImport("kernel32.dll")]
	public static extern short GetVersionEx(ref OSVERSIONINFO o);

	public static void smethod_1(Rectangle rectangle_0, int int_75)
	{
		RECT r = default(RECT);
		r.Left = rectangle_0.Left;
		r.Top = rectangle_0.Top;
		r.Right = rectangle_0.Right;
		r.Bottom = rectangle_0.Bottom;
		int hDC = CreateDC("DISPLAY", 0, 0, 0);
		int drawMode = SetROP2(hDC, 10);
		for (int i = 0; i < int_75; i++)
		{
			DrawFocusRect(hDC, ref r);
			r.Left++;
			r.Top++;
			r.Right--;
			r.Bottom--;
		}
		SetROP2(hDC, drawMode);
		DeleteDC(hDC);
	}

	public static char smethod_2(string string_0)
	{
		int num = string_0.IndexOf('&', 0);
		while (num >= 0 && num < string_0.Length - 1)
		{
			num++;
			if (string_0[num] == '&')
			{
				num = string_0.IndexOf('&', num);
				continue;
			}
			return string_0.Substring(num, 1).ToLower()[0];
		}
		return '\0';
	}

	public static void smethod_3(Graphics graphics_0, Pen pen_0, int int_75, int int_76, int int_77, int int_78)
	{
		int_77--;
		int_78--;
		graphics_0.DrawRectangle(pen_0, int_75, int_76, int_77, int_78);
	}

	public static void smethod_4(Graphics graphics_0, Pen pen_0, Rectangle rectangle_0)
	{
		smethod_3(graphics_0, pen_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height);
	}

	internal static void smethod_5()
	{
		bool_1 = SystemInformation.get_MenuAccessKeysUnderlined();
		bool_2 = SystemInformation.get_IsDropShadowEnabled();
		bool_3 = bool_2;
		bool_4 = SystemInformation.get_RightAlignedMenus();
	}

	internal static void smethod_6()
	{
		int num = CreateDC("DISPLAY", 0, 0, 0);
		int_74 = GetDeviceCaps(num, 12);
		DeleteDC(num);
	}

	[DllImport("user32.dll")]
	public static extern int GetSystemMetrics(int nIndex);

	public static bool smethod_7()
	{
		return 0 != GetSystemMetrics(4096);
	}

	public static string smethod_8(IntPtr intptr_0)
	{
		StringBuilder stringBuilder = new StringBuilder(150);
		if (GetClassName(intptr_0, stringBuilder, stringBuilder.Capacity) != 0)
		{
			return stringBuilder.ToString();
		}
		return "";
	}

	public static int smethod_9(int int_75, int int_76)
	{
		return (int_76 << 16) | (int_75 & 0xFFFF);
	}
}
