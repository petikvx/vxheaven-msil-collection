using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal abstract class Class58 : IDisposable
{
	public struct COLORREF
	{
		public uint ColorDWORD;

		public COLORREF(Color color)
		{
			ColorDWORD = (uint)(color.R + (color.G << 8) + (color.B << 16));
		}

		public Color GetColor()
		{
			return Color.FromArgb((int)(0xFF & ColorDWORD), (int)(0xFF00 & ColorDWORD) >> 8, (int)(0xFF0000 & ColorDWORD) >> 16);
		}

		public void SetColor(Color color)
		{
			ColorDWORD = (uint)(color.R + (color.G << 8) + (color.B << 16));
		}
	}

	public enum DTT_VALIDBITS
	{
		DTT_TEXTCOLOR = 1,
		DTT_BORDERCOLOR = 2,
		DTT_SHADOWCOLOR = 4,
		DTT_SHADOWTYPE = 8,
		DTT_SHADOWOFFSET = 0x10,
		DTT_BORDERSIZE = 0x20,
		DTT_FONTPROP = 0x40,
		DTT_COLORPROP = 0x80,
		DTT_STATEID = 0x100,
		DTT_CALCRECT = 0x200,
		DTT_APPLYOVERLAY = 0x400,
		DTT_GLOWSIZE = 0x800,
		DTT_CALLBACK = 0x1000,
		DTT_COMPOSITED = 0x2000
	}

	public struct DTTOPTS
	{
		public int dwSize;

		public int dwFlags;

		public COLORREF crText;

		public COLORREF crBorder;

		public COLORREF crShadow;

		public int iTextShadowType;

		public Class51.POINT ptShadowOffset;

		public int iBorderSize;

		public int iFontPropId;

		public int iColorPropId;

		public int iStateId;

		public bool fApplyOverlay;

		public int iGlowSize;

		public int pfnDrawTextCallback;

		public int lParam;
	}

	public struct MARGINS
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;
	}

	public struct RECT
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		public RECT(Rectangle r)
		{
			int_0 = r.Left;
			int_1 = r.Top;
			int_2 = r.Right;
			int_3 = r.Bottom;
		}
	}

	public struct SIZE
	{
		public int Width;

		public int Height;
	}

	protected Control control_0;

	protected IntPtr intptr_0 = IntPtr.Zero;

	public static bool bool_0 = smethod_0();

	protected abstract string ThemeClass { get; }

	public Class58(Control parent)
	{
		control_0 = parent;
		intptr_0 = OpenThemeData(parent.get_Handle(), ThemeClass);
	}

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern IntPtr OpenThemeData(IntPtr hWnd, string pszClassList);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern IntPtr OpenThemeDataEx(IntPtr hWnd, string pszClassList, int flags);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int CloseThemeData(IntPtr hTheme);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int DrawThemeBackground(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref RECT pRect, ref RECT pClipRect);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int DrawThemeBackground(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref RECT pRect, IntPtr pCliprect);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int EnableTheming(bool fEnable);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int DrawThemeEdge(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref RECT pDestRect, uint uEdge, uint uFlags, ref RECT pContentRect);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int DrawThemeIcon(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref RECT pRect, IntPtr himl, int iImageIndex);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int DrawThemeParentBackground(IntPtr hwnd, IntPtr hdc, ref RECT prc);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int DrawThemeText(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, string pszText, int iCharCount, int dwTextFlags, int dwTextFlags2, ref RECT pRect);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	public static extern int DrawThemeTextEx(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, string pszText, int iCharCount, int dwTextFlags, ref RECT pRect, ref DTTOPTS options);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int EnableThemeDialogTexture(IntPtr hwnd, long dwFlags);

	[DllImport("uxtheme", CharSet = CharSet.Unicode, ExactSpelling = true)]
	public static extern int GetCurrentThemeName(string stringThemeName, int lengthThemeName, string stringColorName, int lengthColorName, string stringSizeName, int lengthSizeName);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern long GetThemeAppProperties();

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int GetThemeBackgroundContentRect(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref RECT pBoundingRect, ref RECT pContentRect);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int GetThemeBackgroundExtent(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref RECT pContentRect, ref RECT pExtentRect);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int GetThemeBackgroundRegion(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref RECT pRect, ref IntPtr pRegion);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int GetThemeBool(IntPtr hTheme, int iPartId, int iStateId, int iPropId, ref bool pfVal);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int GetThemeColor(IntPtr hTheme, int iPartId, int iStateId, int iPropId, ref long pColor);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int GetThemeDocumentationProperty(string pszThemeName, string pszPropertyName, string pszValueBuff, int cchMaxValChars);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int GetThemeEnumValue(IntPtr hTheme, int iPartId, int iStateId, int iPropId, ref int piVal);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int GetThemeFilename(IntPtr hTheme, int iPartId, int iStateId, int iPropId, ref string pszThemeFilename, int cchMaxBuffChars);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int GetThemeInt(IntPtr hTheme, int iPartId, int iStateId, int iPropId, ref int piVal);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	private static extern int GetThemeMargins(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, int iPropId, ref RECT prc, ref MARGINS pMargins);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern bool IsThemeActive();

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	internal static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int SetWindowTheme(IntPtr hwnd, IntPtr pszSubAppName, string pszSubIdList);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int SetWindowTheme(IntPtr hwnd, IntPtr pszSubAppName, IntPtr pszSubIdList);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern bool IsThemePartDefined(IntPtr hTheme, int iPartId, int iStateId);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int GetThemePartSize(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref RECT prc, int eSize, ref SIZE psz);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto)]
	protected static extern int GetThemePartSize(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, IntPtr prc, int eSize, ref SIZE psz);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	protected static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

	~Class58()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			Dispose();
		}
	}

	private static bool smethod_0()
	{
		if (!Class109.Boolean_0)
		{
			return false;
		}
		return IsThemeActive();
	}

	public static void smethod_1()
	{
		bool_0 = smethod_0();
	}

	public static int smethod_2(Control control_1, string string_0)
	{
		return SetWindowTheme(control_1.get_Handle(), IntPtr.Zero, string_0);
	}

	protected virtual void InternalDrawBackground(Graphics g, Class118 part, Class143 state, Rectangle r)
	{
		RECT pRect = new RECT(r);
		IntPtr hdc = g.GetHdc();
		try
		{
			DrawThemeBackground(intptr_0, hdc, part.int_0, state.int_0, ref pRect, IntPtr.Zero);
		}
		finally
		{
			g.ReleaseHdc(hdc);
		}
	}

	protected virtual void InternalDrawBackground(Graphics g, Class118 part, Class143 state, Rectangle r, Rectangle clip)
	{
		RECT pRect = new RECT(r);
		RECT pClipRect = new RECT(clip);
		IntPtr hdc = g.GetHdc();
		try
		{
			DrawThemeBackground(intptr_0, hdc, part.int_0, state.int_0, ref pRect, ref pClipRect);
		}
		finally
		{
			g.ReleaseHdc(hdc);
		}
	}

	protected virtual IntPtr InternalGetThemeBackgroundRegion(Graphics g, Class118 part, Class143 state, Rectangle r)
	{
		RECT pRect = new RECT(r);
		IntPtr hdc = g.GetHdc();
		IntPtr pRegion = IntPtr.Zero;
		try
		{
			GetThemeBackgroundRegion(intptr_0, hdc, part.int_0, state.int_0, ref pRect, ref pRegion);
			return pRegion;
		}
		finally
		{
			g.ReleaseHdc(hdc);
		}
	}

	protected virtual void InternalDrawText(Graphics g, string text, Font font, Rectangle layoutRect, Class118 part, Class143 state, Enum10 format, bool drawdisabled)
	{
		RECT pRect = new RECT(layoutRect);
		IntPtr hdc = g.GetHdc();
		IntPtr intPtr = font.ToHfont();
		IntPtr hgdiobj = SelectObject(hdc, intPtr);
		DrawThemeText(intptr_0, hdc, part.int_0, state.int_0, text, text.Length, (int)format, drawdisabled ? 1 : 0, ref pRect);
		SelectObject(hdc, hgdiobj);
		Class51.DeleteObject(intPtr);
		g.ReleaseHdc(hdc);
	}

	protected virtual void InternalDrawTextEx(Graphics g, string text, Font font, Rectangle layoutRect, Class118 part, Class143 state, Enum10 format, DTTOPTS options)
	{
		RECT pRect = new RECT(layoutRect);
		IntPtr hdc = g.GetHdc();
		IntPtr intPtr = font.ToHfont();
		IntPtr hgdiobj = SelectObject(hdc, intPtr);
		options.dwSize = Marshal.SizeOf((object)options);
		DrawThemeTextEx(intptr_0, hdc, part.int_0, state.int_0, text, text.Length, (int)format, ref pRect, ref options);
		SelectObject(hdc, hgdiobj);
		Class51.DeleteObject(intPtr);
		g.ReleaseHdc(hdc);
	}

	public virtual bool IsPartDefined(Class118 part, Class143 state)
	{
		return IsThemePartDefined(intptr_0, part.int_0, state.int_0);
	}

	public void Dispose()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			CloseThemeData(intptr_0);
			intptr_0 = IntPtr.Zero;
		}
	}

	public virtual Size ThemeMinSize(Graphics g, Class118 part, Class143 state)
	{
		SIZE psz = default(SIZE);
		IntPtr hdc = g.GetHdc();
		try
		{
			GetThemePartSize(intptr_0, hdc, part.int_0, state.int_0, IntPtr.Zero, 0, ref psz);
		}
		finally
		{
			g.ReleaseHdc(hdc);
		}
		return new Size(psz.Width, psz.Height);
	}

	public virtual Size ThemeTrueSize(Graphics g, Class118 part, Class143 state)
	{
		SIZE psz = default(SIZE);
		IntPtr hdc = g.GetHdc();
		try
		{
			GetThemePartSize(intptr_0, hdc, part.int_0, state.int_0, IntPtr.Zero, 1, ref psz);
		}
		finally
		{
			g.ReleaseHdc(hdc);
		}
		return new Size(psz.Width, psz.Height);
	}

	public virtual Size ThemeDrawSize(Graphics g, Class118 part, Class143 state)
	{
		SIZE psz = default(SIZE);
		IntPtr hdc = g.GetHdc();
		try
		{
			GetThemePartSize(intptr_0, hdc, part.int_0, state.int_0, IntPtr.Zero, 2, ref psz);
		}
		finally
		{
			g.ReleaseHdc(hdc);
		}
		return new Size(psz.Width, psz.Height);
	}
}
