using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.ScrollBar;

namespace DevComponents.DotNetBar.Controls;

internal class Class188 : Interface1
{
	public delegate void InvokeMouseMethodDelegate(IntPtr handle, Point mousePos);

	private const int int_0 = 0;

	private INonClientControl inonClientControl_0;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private ScrollBarCore scrollBarCore_0;

	private ScrollBarCore scrollBarCore_1;

	private eScrollBarSkin eScrollBarSkin_0 = eScrollBarSkin.Optimized;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private Delegate6 delegate6_0;

	private Delegate6 delegate6_1;

	private bool bool_4;

	public bool Boolean_0
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}

	private bool Boolean_1
	{
		get
		{
			if (eScrollBarSkin_0 != 0)
			{
				return !bool_1;
			}
			return false;
		}
	}

	public bool Boolean_2
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public eScrollBarSkin EScrollBarSkin_0
	{
		get
		{
			return eScrollBarSkin_0;
		}
		set
		{
			if (eScrollBarSkin_0 == value)
			{
				return;
			}
			if (eScrollBarSkin_0 != 0)
			{
				if (scrollBarCore_0 != null)
				{
					scrollBarCore_0.Dispose();
					scrollBarCore_0 = null;
				}
				if (scrollBarCore_1 != null)
				{
					scrollBarCore_1.Dispose();
					scrollBarCore_1 = null;
				}
				method_5();
			}
			eScrollBarSkin_0 = value;
			if (Boolean_1)
			{
				method_1();
				if (inonClientControl_0.IsHandleCreated)
				{
					method_4();
				}
			}
		}
	}

	public Rectangle Rectangle_0 => rectangle_0;

	public event Delegate6 Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate6_0 = (Delegate6)Delegate.Combine(delegate6_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate6_0 = (Delegate6)Delegate.Remove(delegate6_0, value);
		}
	}

	public event Delegate6 Event_1
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate6_1 = (Delegate6)Delegate.Combine(delegate6_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate6_1 = (Delegate6)Delegate.Remove(delegate6_1, value);
		}
	}

	public Class188(INonClientControl c, eScrollBarSkin skinScrollbars)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		bool_1 = Environment.OSVersion.Version.Major >= 6;
		eScrollBarSkin_0 = skinScrollbars;
		inonClientControl_0 = c;
		if (inonClientControl_0 is Control)
		{
			((Control)inonClientControl_0).add_HandleCreated((EventHandler)method_3);
			((Control)inonClientControl_0).add_HandleDestroyed((EventHandler)method_2);
		}
		bool_2 = inonClientControl_0 is ListView;
		if (Boolean_1)
		{
			method_1();
		}
		if (inonClientControl_0.IsHandleCreated && Boolean_1)
		{
			method_4();
		}
	}

	public void method_0()
	{
		method_5();
	}

	private void method_1()
	{
		ref ScrollBarCore reference = ref scrollBarCore_0;
		INonClientControl nonClientControl = inonClientControl_0;
		reference = new ScrollBarCore((Control)((nonClientControl is Control) ? nonClientControl : null), isPassive: true);
		scrollBarCore_0.IsAppScrollBarStyle = bool_3;
		ref ScrollBarCore reference2 = ref scrollBarCore_1;
		INonClientControl nonClientControl2 = inonClientControl_0;
		reference2 = new ScrollBarCore((Control)((nonClientControl2 is Control) ? nonClientControl2 : null), isPassive: true);
		scrollBarCore_1.IsAppScrollBarStyle = bool_3;
		scrollBarCore_1.Orientation = eOrientation.Horizontal;
		scrollBarCore_1.Enabled = false;
	}

	private void method_2(object sender, EventArgs e)
	{
		method_5();
	}

	private void method_3(object sender, EventArgs e)
	{
		if (Boolean_1)
		{
			method_4();
		}
	}

	private void method_4()
	{
		method_30();
		Class56.smethod_0(this);
	}

	private void method_5()
	{
		if (Boolean_1)
		{
			Class56.smethod_1(this);
		}
	}

	public virtual bool WndProc(ref Message m)
	{
		bool result = true;
		switch (((Message)(ref m)).get_Msg())
		{
		case 20:
			result = method_14(ref m);
			break;
		case 5:
			result = method_6(ref m);
			break;
		case 184:
			result = method_13(ref m);
			break;
		case 160:
			result = method_10(ref m);
			break;
		case 161:
			result = method_12(ref m);
			break;
		case 162:
			result = method_11(ref m);
			break;
		case 131:
			result = WindowsMessageNCCalcSize(ref m);
			break;
		case 133:
			result = WindowsMessageNCPaint(ref m);
			break;
		case 288:
			method_7(ref m);
			result = false;
			break;
		case 273:
			if (Class51.smethod_5(((Message)(ref m)).get_WParam()) == 256)
			{
				method_20(ref m);
				result = false;
			}
			break;
		case 276:
			result = method_19(ref m);
			break;
		case 277:
			result = method_18(ref m);
			break;
		case 224:
			result = method_16(ref m);
			break;
		case 674:
			result = method_9(ref m);
			break;
		case 522:
			result = method_8(ref m);
			break;
		case 309:
			method_20(ref m);
			result = false;
			break;
		case 311:
			method_26();
			result = false;
			break;
		}
		return result;
	}

	private bool method_6(ref Message message_0)
	{
		if (bool_2)
		{
			method_20(ref message_0);
			return false;
		}
		return true;
	}

	private void method_7(ref Message message_0)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		if (((Message)(ref message_0)).get_WParam().ToInt32() == 0)
		{
			method_26();
		}
		else
		{
			if (((Message)(ref message_0)).get_WParam().ToInt32() != 1)
			{
				return;
			}
			Point pt = method_35(Control.get_MousePosition());
			if (scrollBarCore_0.Visible)
			{
				if (scrollBarCore_0.IsMouseDown)
				{
					scrollBarCore_0.MouseUp(new MouseEventArgs((MouseButtons)1048576, 0, pt.X, pt.Y, 0));
				}
				else if (!scrollBarCore_0.DisplayRectangle.Contains(pt))
				{
					scrollBarCore_0.MouseLeave();
				}
			}
			if (scrollBarCore_1.Visible)
			{
				if (scrollBarCore_1.IsMouseDown)
				{
					scrollBarCore_1.MouseUp(new MouseEventArgs((MouseButtons)1048576, 0, pt.X, pt.Y, 0));
				}
				else if (!scrollBarCore_1.DisplayRectangle.Contains(pt))
				{
					scrollBarCore_1.MouseLeave();
				}
			}
			method_26();
		}
	}

	private bool method_8(ref Message message_0)
	{
		method_20(ref message_0);
		return false;
	}

	private bool method_9(ref Message message_0)
	{
		if (!Boolean_1)
		{
			return true;
		}
		if (scrollBarCore_0.Visible)
		{
			scrollBarCore_0.MouseLeave();
		}
		if (scrollBarCore_1.Visible)
		{
			scrollBarCore_1.MouseLeave();
		}
		method_20(ref message_0);
		return false;
	}

	private bool method_10(ref Message message_0)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		if (!Boolean_1)
		{
			return true;
		}
		Point point = method_35(new Point(Class51.smethod_4(((Message)(ref message_0)).get_LParam()), Class51.smethod_5(((Message)(ref message_0)).get_LParam())));
		if (scrollBarCore_0.Visible)
		{
			scrollBarCore_0.MouseMove(new MouseEventArgs(Control.get_MouseButtons(), 0, point.X, point.Y, 0));
		}
		if (scrollBarCore_1.Visible)
		{
			scrollBarCore_1.MouseMove(new MouseEventArgs(Control.get_MouseButtons(), 0, point.X, point.Y, 0));
		}
		method_20(ref message_0);
		return false;
	}

	private bool method_11(ref Message message_0)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		if (!Boolean_1)
		{
			return true;
		}
		Point point = method_35(new Point(Class51.smethod_4(((Message)(ref message_0)).get_LParam()), Class51.smethod_5(((Message)(ref message_0)).get_LParam())));
		if (scrollBarCore_0.Visible)
		{
			scrollBarCore_0.MouseUp(new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0));
		}
		if (scrollBarCore_1.Visible)
		{
			scrollBarCore_1.MouseUp(new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0));
		}
		method_20(ref message_0);
		return false;
	}

	private bool method_12(ref Message message_0)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		if (!Boolean_1)
		{
			return true;
		}
		Point point = method_35(new Point(Class51.smethod_4(((Message)(ref message_0)).get_LParam()), Class51.smethod_5(((Message)(ref message_0)).get_LParam())));
		if (scrollBarCore_0.Visible)
		{
			scrollBarCore_0.MouseDown(new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0));
		}
		if (scrollBarCore_1.Visible)
		{
			scrollBarCore_1.MouseDown(new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0));
		}
		method_20(ref message_0);
		return false;
	}

	private bool method_13(ref Message message_0)
	{
		if (!Boolean_1)
		{
			return true;
		}
		method_20(ref message_0);
		return false;
	}

	private bool method_14(ref Message message_0)
	{
		if (bool_2 && Boolean_1)
		{
			method_20(ref message_0);
			return false;
		}
		return true;
	}

	private void method_15(IntPtr intptr_0, Point point_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		if ((int)Control.get_MouseButtons() == 1048576 && intptr_0 == inonClientControl_0.Handle && Boolean_1)
		{
			Class51.PostMessage(intptr_0.ToInt32(), 288, 0, 0);
		}
	}

	private bool method_16(ref Message message_0)
	{
		if (!Boolean_1)
		{
			return true;
		}
		method_20(ref message_0);
		return false;
	}

	private void method_17(ref Message message_0)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		IntPtr intPtr = Class51.smethod_0(inonClientControl_0.Handle, -16);
		int num = intPtr.ToInt32();
		num &= ~(num & 0x10000000);
		Class51.SetWindowLong(inonClientControl_0.Handle, -16, num);
		using (BufferedBitmap bufferedBitmap_ = method_27())
		{
			inonClientControl_0.BaseWndProc(ref message_0);
			Class51.SetWindowLong(inonClientControl_0.Handle, -16, intPtr.ToInt32());
			method_28(bufferedBitmap_);
		}
		if (inonClientControl_0 is Control)
		{
			((Control)inonClientControl_0).Invalidate(true);
		}
	}

	private bool method_18(ref Message message_0)
	{
		if (!Boolean_1)
		{
			return true;
		}
		if (eScrollBarSkin_0 == eScrollBarSkin.Optimized)
		{
			method_17(ref message_0);
		}
		else
		{
			method_20(ref message_0);
		}
		return false;
	}

	private bool method_19(ref Message message_0)
	{
		if (!Boolean_1)
		{
			return true;
		}
		if (eScrollBarSkin_0 == eScrollBarSkin.Optimized)
		{
			method_17(ref message_0);
		}
		else
		{
			method_20(ref message_0);
		}
		return false;
	}

	private void method_20(ref Message message_0)
	{
		using BufferedBitmap bufferedBitmap_ = method_27();
		inonClientControl_0.BaseWndProc(ref message_0);
		method_28(bufferedBitmap_);
	}

	protected virtual bool WindowsMessageNCCalcSize(ref Message m)
	{
		ElementStyle borderStyle = inonClientControl_0.BorderStyle;
		if (borderStyle != null && borderStyle.Boolean_5)
		{
			inonClientControl_0.BaseWndProc(ref m);
			if (((Message)(ref m)).get_WParam() == IntPtr.Zero)
			{
				Class51.RECT rECT = (Class51.RECT)Marshal.PtrToStructure(((Message)(ref m)).get_LParam(), typeof(Class51.RECT));
				Rectangle rectangle = method_25(rECT.ToRectangle(), borderStyle);
				Class51.RECT rECT2 = Class51.RECT.FromRectangle(rectangle);
				Marshal.StructureToPtr((object)rECT2, ((Message)(ref m)).get_LParam(), fDeleteOld: false);
				rectangle_0 = rectangle;
				rectangle_0.X -= rECT.Left;
				rectangle_0.Y -= rECT.Top;
			}
			else
			{
				Class51.NCCALCSIZE_PARAMS nCCALCSIZE_PARAMS = (Class51.NCCALCSIZE_PARAMS)Marshal.PtrToStructure(((Message)(ref m)).get_LParam(), typeof(Class51.NCCALCSIZE_PARAMS));
				Class51.WINDOWPOS wINDOWPOS = (Class51.WINDOWPOS)Marshal.PtrToStructure(nCCALCSIZE_PARAMS.lppos, typeof(Class51.WINDOWPOS));
				Class51.RECT rgrc = nCCALCSIZE_PARAMS.rgrc0;
				nCCALCSIZE_PARAMS.rgrc1 = (nCCALCSIZE_PARAMS.rgrc0 = Class51.RECT.FromRectangle(method_25(new Rectangle(rgrc.Left, rgrc.Top, rgrc.Width, rgrc.Height), borderStyle)));
				Marshal.StructureToPtr((object)nCCALCSIZE_PARAMS, ((Message)(ref m)).get_LParam(), fDeleteOld: false);
				rectangle_0 = nCCALCSIZE_PARAMS.rgrc0.ToRectangle();
				rectangle_0.X -= wINDOWPOS.x;
				rectangle_0.Y -= wINDOWPOS.y;
			}
		}
		else if (((Message)(ref m)).get_WParam() == IntPtr.Zero)
		{
			Class51.RECT rECT3 = (Class51.RECT)Marshal.PtrToStructure(((Message)(ref m)).get_LParam(), typeof(Class51.RECT));
			inonClientControl_0.BaseWndProc(ref m);
			Class51.RECT rECT4 = (Class51.RECT)Marshal.PtrToStructure(((Message)(ref m)).get_LParam(), typeof(Class51.RECT));
			Class51.RECT rECT5 = Class51.RECT.FromRectangle(method_25(new Rectangle(rECT4.Left, rECT4.Top, rECT4.Width, rECT4.Height), borderStyle));
			Marshal.StructureToPtr((object)rECT5, ((Message)(ref m)).get_LParam(), fDeleteOld: false);
			rectangle_0 = rECT5.ToRectangle();
			rectangle_0.X -= rECT3.Left;
			rectangle_0.Y -= rECT3.Top;
		}
		else
		{
			inonClientControl_0.BaseWndProc(ref m);
			Class51.NCCALCSIZE_PARAMS nCCALCSIZE_PARAMS2 = (Class51.NCCALCSIZE_PARAMS)Marshal.PtrToStructure(((Message)(ref m)).get_LParam(), typeof(Class51.NCCALCSIZE_PARAMS));
			Class51.WINDOWPOS wINDOWPOS2 = (Class51.WINDOWPOS)Marshal.PtrToStructure(nCCALCSIZE_PARAMS2.lppos, typeof(Class51.WINDOWPOS));
			Class51.RECT rgrc2 = nCCALCSIZE_PARAMS2.rgrc0;
			Class51.RECT rECT6 = (nCCALCSIZE_PARAMS2.rgrc0 = Class51.RECT.FromRectangle(method_25(new Rectangle(rgrc2.Left, rgrc2.Top, rgrc2.Width, rgrc2.Height), borderStyle)));
			Marshal.StructureToPtr((object)nCCALCSIZE_PARAMS2, ((Message)(ref m)).get_LParam(), fDeleteOld: false);
			rectangle_0 = nCCALCSIZE_PARAMS2.rgrc0.ToRectangle();
			rectangle_0.X -= wINDOWPOS2.x;
			rectangle_0.Y -= wINDOWPOS2.y;
		}
		return false;
	}

	internal int method_21(ElementStyle elementStyle_0)
	{
		if (elementStyle_0.Boolean_1)
		{
			int num = elementStyle_0.BorderLeftWidth;
			if (elementStyle_0.CornerTypeTopLeft == eCornerType.Rounded || elementStyle_0.CornerTypeTopLeft == eCornerType.Diagonal || elementStyle_0.CornerTypeBottomLeft == eCornerType.Rounded || elementStyle_0.CornerTypeBottomLeft == eCornerType.Diagonal || ((elementStyle_0.CornerType == eCornerType.Rounded || elementStyle_0.CornerType == eCornerType.Diagonal) && (elementStyle_0.CornerTypeTopLeft == eCornerType.Inherit || elementStyle_0.CornerTypeBottomLeft == eCornerType.Inherit)))
			{
				num = Math.Max(num, elementStyle_0.CornerDiameter / 2 + 1);
			}
			return num;
		}
		return 0;
	}

	internal int method_22(ElementStyle elementStyle_0)
	{
		if (elementStyle_0.Boolean_3)
		{
			int num = elementStyle_0.BorderTopWidth;
			if (elementStyle_0.CornerTypeTopLeft == eCornerType.Rounded || elementStyle_0.CornerTypeTopLeft == eCornerType.Diagonal || elementStyle_0.CornerTypeTopRight == eCornerType.Rounded || elementStyle_0.CornerTypeTopRight == eCornerType.Diagonal || ((elementStyle_0.CornerType == eCornerType.Rounded || elementStyle_0.CornerType == eCornerType.Diagonal) && (elementStyle_0.CornerTypeTopLeft == eCornerType.Inherit || elementStyle_0.CornerTypeTopRight == eCornerType.Inherit)))
			{
				num = Math.Max(num, elementStyle_0.CornerDiameter / 2 + 1);
			}
			return num;
		}
		return 0;
	}

	internal int method_23(ElementStyle elementStyle_0)
	{
		if (elementStyle_0.Boolean_2)
		{
			int num = elementStyle_0.BorderRightWidth;
			if (elementStyle_0.CornerTypeTopRight == eCornerType.Rounded || elementStyle_0.CornerTypeBottomRight == eCornerType.Rounded || elementStyle_0.CornerTypeTopRight == eCornerType.Diagonal || elementStyle_0.CornerTypeBottomRight == eCornerType.Diagonal || ((elementStyle_0.CornerType == eCornerType.Rounded || elementStyle_0.CornerType == eCornerType.Diagonal) && (elementStyle_0.CornerTypeTopRight == eCornerType.Inherit || elementStyle_0.CornerTypeBottomRight == eCornerType.Inherit)))
			{
				num = Math.Max(num, elementStyle_0.CornerDiameter / 2 + 1);
			}
			return num;
		}
		return 0;
	}

	internal int method_24(ElementStyle elementStyle_0)
	{
		if (elementStyle_0.Boolean_4)
		{
			int num = elementStyle_0.BorderBottomWidth;
			if (elementStyle_0.CornerTypeBottomLeft == eCornerType.Rounded || elementStyle_0.CornerTypeBottomRight == eCornerType.Rounded || elementStyle_0.CornerTypeBottomLeft == eCornerType.Diagonal || elementStyle_0.CornerTypeBottomRight == eCornerType.Diagonal || ((elementStyle_0.CornerType == eCornerType.Rounded || elementStyle_0.CornerType == eCornerType.Diagonal) && (elementStyle_0.CornerTypeBottomLeft == eCornerType.Inherit || elementStyle_0.CornerTypeBottomRight == eCornerType.Inherit)))
			{
				num = Math.Max(num, elementStyle_0.CornerDiameter / 2 + 1);
			}
			return num;
		}
		return 0;
	}

	private Rectangle method_25(Rectangle rectangle_1, ElementStyle elementStyle_0)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between Unknown and I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		if (elementStyle_0 == null)
		{
			return rectangle_1;
		}
		if (elementStyle_0.Boolean_1)
		{
			int num = method_21(elementStyle_0);
			rectangle_1.X += num;
			rectangle_1.Width -= num;
		}
		if (elementStyle_0.Boolean_3)
		{
			int num2 = method_22(elementStyle_0);
			rectangle_1.Y += num2;
			rectangle_1.Height -= num2;
		}
		if (elementStyle_0.Boolean_2)
		{
			int num3 = method_23(elementStyle_0);
			rectangle_1.Width -= num3;
		}
		if (elementStyle_0.Boolean_4)
		{
			int num4 = method_24(elementStyle_0);
			rectangle_1.Height -= num4;
		}
		INonClientControl nonClientControl = inonClientControl_0;
		TextBox val = (TextBox)((nonClientControl is TextBox) ? nonClientControl : null);
		if (val != null && ((TextBoxBase)val).get_Multiline() && (int)val.get_ScrollBars() != 0)
		{
			if ((int)val.get_ScrollBars() == 2 || (int)val.get_ScrollBars() == 3)
			{
				if ((int)((Control)val).get_RightToLeft() == 1)
				{
					rectangle_1.Width -= elementStyle_0.PaddingRight;
				}
				else
				{
					rectangle_1.X += elementStyle_0.PaddingLeft;
					rectangle_1.Width -= elementStyle_0.PaddingLeft;
				}
			}
			return rectangle_1;
		}
		rectangle_1.X += elementStyle_0.PaddingLeft;
		rectangle_1.Width -= elementStyle_0.PaddingLeft + elementStyle_0.PaddingRight;
		rectangle_1.Y += elementStyle_0.PaddingTop;
		rectangle_1.Height -= elementStyle_0.PaddingTop + elementStyle_0.PaddingBottom;
		inonClientControl_0.AdjustClientRectangle(ref rectangle_1);
		return rectangle_1;
	}

	protected virtual bool WindowsMessageNCPaint(ref Message m)
	{
		if (!Boolean_1)
		{
			inonClientControl_0.BaseWndProc(ref m);
			if (inonClientControl_0.IsHandleCreated && inonClientControl_0.Handle != IntPtr.Zero)
			{
				method_26();
			}
			return false;
		}
		using (BufferedBitmap bufferedBitmap_ = method_27())
		{
			inonClientControl_0.BaseWndProc(ref m);
			method_28(bufferedBitmap_);
		}
		((Message)(ref m)).set_Result(IntPtr.Zero);
		return false;
	}

	public void method_26()
	{
		if (inonClientControl_0.Width > 0 && inonClientControl_0.Height > 0 && !bool_0)
		{
			using (BufferedBitmap bufferedBitmap_ = method_27())
			{
				method_28(bufferedBitmap_);
			}
		}
	}

	private BufferedBitmap method_27()
	{
		if (inonClientControl_0.Width > 0 && inonClientControl_0.Height > 0 && !bool_0 && inonClientControl_0.IsHandleCreated)
		{
			BufferedBitmap bufferedBitmap = null;
			IntPtr windowDC = Class51.GetWindowDC(inonClientControl_0.Handle);
			Rectangle rectangle = method_31();
			try
			{
				bufferedBitmap = new BufferedBitmap(windowDC, new Rectangle(0, 0, rectangle.Width, rectangle.Height));
				PaintNonClientArea(bufferedBitmap.Graphics);
				return bufferedBitmap;
			}
			finally
			{
				Class51.ReleaseDC(inonClientControl_0.Handle, windowDC);
			}
		}
		return null;
	}

	private void method_28(BufferedBitmap bufferedBitmap_0)
	{
		if (bufferedBitmap_0 == null)
		{
			return;
		}
		IntPtr windowDC = Class51.GetWindowDC(inonClientControl_0.Handle);
		try
		{
			Graphics val = Graphics.FromHdc(windowDC);
			try
			{
				Rectangle[] array = new Rectangle[3]
				{
					method_29(),
					default(Rectangle),
					default(Rectangle)
				};
				if (!Boolean_1)
				{
					Class51.SCROLLBARINFO psbi = default(Class51.SCROLLBARINFO);
					psbi.cbSize = Marshal.SizeOf((object)psbi);
					Class51.GetScrollBarInfo(inonClientControl_0.Handle, 4294967291u, ref psbi);
					if (psbi.rgstate[0] != 32768)
					{
						Rectangle rectangle = method_36(psbi.rcScrollBar.ToRectangle());
						array[1] = rectangle;
					}
					psbi = default(Class51.SCROLLBARINFO);
					psbi.cbSize = Marshal.SizeOf((object)psbi);
					Class51.GetScrollBarInfo(inonClientControl_0.Handle, 4294967290u, ref psbi);
					if (psbi.rgstate[0] != 32768)
					{
						Rectangle rectangle2 = method_36(psbi.rcScrollBar.ToRectangle());
						array[2] = rectangle2;
					}
				}
				bufferedBitmap_0.Render(val, array);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		finally
		{
			Class51.ReleaseDC(inonClientControl_0.Handle, windowDC);
		}
	}

	private Rectangle method_29()
	{
		return rectangle_0;
	}

	public void method_30()
	{
		if (!Boolean_1)
		{
			return;
		}
		Class51.SCROLLBARINFO psbi = default(Class51.SCROLLBARINFO);
		psbi.cbSize = Marshal.SizeOf((object)psbi);
		Class51.GetScrollBarInfo(inonClientControl_0.Handle, 4294967291u, ref psbi);
		if (psbi.rgstate[0] != 32768)
		{
			Rectangle rectangle = method_36(psbi.rcScrollBar.ToRectangle());
			if (scrollBarCore_0.DisplayRectangle != rectangle)
			{
				scrollBarCore_0.DisplayRectangle = rectangle;
			}
			Rectangle rectangle2 = new Rectangle(rectangle.X, rectangle.Y, rectangle.Width, psbi.dxyLineButton);
			if (scrollBarCore_0.ThumbDecreaseRectangle != rectangle2)
			{
				scrollBarCore_0.ThumbDecreaseRectangle = rectangle2;
			}
			rectangle2 = new Rectangle(rectangle.X, rectangle.Bottom - psbi.dxyLineButton, rectangle.Width, psbi.dxyLineButton);
			if (scrollBarCore_0.ThumbIncreaseRectangle != rectangle2)
			{
				scrollBarCore_0.ThumbIncreaseRectangle = rectangle2;
			}
			rectangle2 = new Rectangle(rectangle.X, rectangle.Y + psbi.xyThumbTop, rectangle.Width, psbi.xyThumbBottom - psbi.xyThumbTop);
			if (scrollBarCore_0.TrackRectangle != rectangle2)
			{
				scrollBarCore_0.TrackRectangle = rectangle2;
			}
			if (psbi.rgstate[0] == 1)
			{
				if (scrollBarCore_0.Enabled)
				{
					scrollBarCore_0.Enabled = false;
				}
			}
			else if (!scrollBarCore_0.Enabled)
			{
				scrollBarCore_0.Enabled = true;
			}
			scrollBarCore_0.Visible = true;
		}
		else
		{
			scrollBarCore_0.Visible = false;
		}
		psbi = default(Class51.SCROLLBARINFO);
		psbi.cbSize = Marshal.SizeOf((object)psbi);
		Class51.GetScrollBarInfo(inonClientControl_0.Handle, 4294967290u, ref psbi);
		if (psbi.rgstate[0] != 32768)
		{
			Rectangle rectangle3 = method_36(psbi.rcScrollBar.ToRectangle());
			if (scrollBarCore_1.DisplayRectangle != rectangle3)
			{
				scrollBarCore_1.DisplayRectangle = rectangle3;
			}
			Rectangle rectangle4 = new Rectangle(rectangle3.X, rectangle3.Y, psbi.dxyLineButton, rectangle3.Height);
			if (scrollBarCore_1.ThumbDecreaseRectangle != rectangle4)
			{
				scrollBarCore_1.ThumbDecreaseRectangle = rectangle4;
			}
			rectangle4 = new Rectangle(rectangle3.Right - psbi.dxyLineButton, rectangle3.Y, psbi.dxyLineButton, rectangle3.Height);
			if (scrollBarCore_1.ThumbIncreaseRectangle != rectangle4)
			{
				scrollBarCore_1.ThumbIncreaseRectangle = rectangle4;
			}
			rectangle4 = new Rectangle(rectangle3.X + psbi.xyThumbTop, rectangle3.Y, psbi.xyThumbBottom - psbi.xyThumbTop, rectangle3.Height);
			if (scrollBarCore_1.TrackRectangle != rectangle4)
			{
				scrollBarCore_1.TrackRectangle = rectangle4;
			}
			if (psbi.rgstate[0] == 1)
			{
				if (scrollBarCore_1.Enabled)
				{
					scrollBarCore_0.Enabled = false;
				}
			}
			else if (!scrollBarCore_1.Enabled)
			{
				scrollBarCore_1.Enabled = true;
			}
			scrollBarCore_1.Visible = true;
		}
		else
		{
			scrollBarCore_1.Visible = false;
		}
	}

	protected virtual void PaintNonClientArea(Graphics g)
	{
		if (bool_4)
		{
			return;
		}
		bool_4 = true;
		try
		{
			method_32(g);
			if (Boolean_1)
			{
				method_30();
				if (scrollBarCore_0.Visible)
				{
					scrollBarCore_0.Paint(inonClientControl_0.GetItemPaintArgs(g));
				}
				if (scrollBarCore_1.Visible)
				{
					scrollBarCore_1.Paint(inonClientControl_0.GetItemPaintArgs(g));
				}
			}
		}
		finally
		{
			bool_4 = false;
		}
	}

	private Rectangle method_31()
	{
		if (inonClientControl_0.IsHandleCreated)
		{
			Class51.RECT r = default(Class51.RECT);
			Class51.GetWindowRect(inonClientControl_0.Handle, ref r);
			return new Rectangle(0, 0, r.Width, r.Height);
		}
		return new Rectangle(0, 0, inonClientControl_0.Width, inonClientControl_0.Height);
	}

	private void method_32(Graphics graphics_0)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		ElementStyle borderStyle = inonClientControl_0.BorderStyle;
		Rectangle r = method_31();
		if (borderStyle == null || r.Width <= 0 || r.Height <= 0)
		{
			return;
		}
		ElementStyleDisplayInfo elementStyleDisplayInfo = new ElementStyleDisplayInfo(borderStyle, graphics_0, r);
		if (borderStyle.BackColor == Color.Transparent && (borderStyle.BackColor2.IsEmpty || borderStyle.BackColor2 == Color.Transparent))
		{
			inonClientControl_0.PaintBackground(new PaintEventArgs(graphics_0, r));
		}
		else
		{
			if (borderStyle.BackColor.IsEmpty && inonClientControl_0.BackColor != Color.Transparent)
			{
				SolidBrush val = new SolidBrush(inonClientControl_0.Enabled ? inonClientControl_0.BackColor : SystemColors.Control);
				try
				{
					graphics_0.FillRectangle((Brush)(object)val, r);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			else if (!(inonClientControl_0.BackColor == Color.Transparent) && (!borderStyle.Boolean_5 || (borderStyle.CornerType != eCornerType.Rounded && borderStyle.CornerType != eCornerType.Diagonal && borderStyle.CornerTypeBottomLeft != eCornerType.Rounded && borderStyle.CornerTypeBottomLeft != eCornerType.Diagonal && borderStyle.CornerTypeBottomRight != eCornerType.Rounded && borderStyle.CornerTypeBottomRight != eCornerType.Diagonal && borderStyle.CornerTypeTopLeft != eCornerType.Rounded && borderStyle.CornerTypeTopLeft != eCornerType.Diagonal && borderStyle.CornerTypeTopRight != eCornerType.Rounded && borderStyle.CornerTypeTopRight != eCornerType.Diagonal)))
			{
				SolidBrush val2 = new SolidBrush(inonClientControl_0.BackColor);
				try
				{
					graphics_0.FillRectangle((Brush)(object)val2, r);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			else if (!(inonClientControl_0 is TextBox) && !(inonClientControl_0.BackColor == Color.Transparent))
			{
				SolidBrush val3 = new SolidBrush(inonClientControl_0.BackColor);
				try
				{
					graphics_0.FillRectangle((Brush)(object)val3, r);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			else
			{
				inonClientControl_0.PaintBackground(new PaintEventArgs(graphics_0, r));
			}
			Rectangle r2 = r;
			if (borderStyle.Boolean_5)
			{
				if (borderStyle.Boolean_2 && borderStyle.BorderRightWidth > 1)
				{
					r2.Width--;
				}
				if (borderStyle.Boolean_4 && borderStyle.BorderBottomWidth > 1)
				{
					r2.Height--;
				}
			}
			inonClientControl_0.AdjustBorderRectangle(ref r2);
			elementStyleDisplayInfo.Bounds = r2;
			ElementStyleDisplay.PaintBackground(elementStyleDisplayInfo);
			inonClientControl_0.RenderNonClient(graphics_0);
		}
		SmoothingMode smoothingMode = graphics_0.get_SmoothingMode();
		if (borderStyle.Boolean_5 && (borderStyle.CornerType == eCornerType.Rounded || borderStyle.CornerType == eCornerType.Diagonal))
		{
			graphics_0.set_SmoothingMode((SmoothingMode)2);
		}
		inonClientControl_0.AdjustBorderRectangle(ref r);
		elementStyleDisplayInfo.Bounds = r;
		method_34(graphics_0, r);
		ElementStyleDisplay.PaintBorder(elementStyleDisplayInfo);
		graphics_0.set_SmoothingMode(smoothingMode);
		method_33(graphics_0, r);
	}

	private void method_33(Graphics graphics_0, Rectangle rectangle_1)
	{
		if (delegate6_1 != null)
		{
			delegate6_1(this, new EventArgs3(graphics_0, rectangle_1));
		}
	}

	private void method_34(Graphics graphics_0, Rectangle rectangle_1)
	{
		if (delegate6_0 != null)
		{
			delegate6_0(this, new EventArgs3(graphics_0, rectangle_1));
		}
	}

	private Point method_35(Point point_0)
	{
		Point point = inonClientControl_0.PointToScreen(new Point(-rectangle_0.X, -rectangle_0.Y));
		point_0.X -= point.X;
		point_0.Y -= point.Y;
		return point_0;
	}

	private Rectangle method_36(Rectangle rectangle_1)
	{
		Point point = inonClientControl_0.PointToScreen(new Point(-rectangle_0.X, -rectangle_0.Y));
		rectangle_1.X -= point.X;
		rectangle_1.Y -= point.Y;
		return rectangle_1;
	}

	public void imethod_0(IntPtr intptr_0, Point point_0)
	{
		if (inonClientControl_0 is Control)
		{
			INonClientControl nonClientControl = inonClientControl_0;
			Control val = (Control)((nonClientControl is Control) ? nonClientControl : null);
			if (val != null && !val.get_IsDisposed() && val.get_IsHandleCreated())
			{
				if (val.get_InvokeRequired())
				{
					val.BeginInvoke((Delegate)new InvokeMouseMethodDelegate(method_37), new object[2] { intptr_0, point_0 });
				}
				else
				{
					method_37(intptr_0, point_0);
				}
			}
		}
		else
		{
			method_37(intptr_0, point_0);
		}
	}

	private void method_37(IntPtr intptr_0, Point point_0)
	{
		if (intptr_0 == inonClientControl_0.Handle)
		{
			method_15(intptr_0, point_0);
		}
	}

	public void imethod_1(IntPtr intptr_0, Point point_0)
	{
		if (inonClientControl_0 is Control)
		{
			INonClientControl nonClientControl = inonClientControl_0;
			Control val = (Control)((nonClientControl is Control) ? nonClientControl : null);
			if (val != null && !val.get_IsDisposed() && val.get_IsHandleCreated())
			{
				if (val.get_InvokeRequired())
				{
					val.BeginInvoke((Delegate)new InvokeMouseMethodDelegate(method_38), new object[2] { intptr_0, point_0 });
				}
				else
				{
					method_38(intptr_0, point_0);
				}
			}
		}
		else
		{
			method_38(intptr_0, point_0);
		}
	}

	public void method_38(IntPtr intptr_0, Point point_0)
	{
		if (intptr_0 == inonClientControl_0.Handle && Boolean_1)
		{
			if (scrollBarCore_0.IsMouseDown)
			{
				Class51.PostMessage(inonClientControl_0.Handle, 288, (IntPtr)1, (IntPtr)0);
			}
			else if (scrollBarCore_1.IsMouseDown)
			{
				Class51.PostMessage(inonClientControl_0.Handle, 288, (IntPtr)1, (IntPtr)0);
			}
		}
	}
}
