using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

public class Office2007Form : Office2007RibbonForm
{
	private class Class203
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;
	}

	private int int_5 = 2;

	private int int_6 = 5;

	private GenericItemContainer genericItemContainer_0;

	private ColorScheme colorScheme_0;

	private LabelItem labelItem_0;

	private SystemCaptionItem systemCaptionItem_0;

	private SystemCaptionItem systemCaptionItem_1;

	private Timer timer_0;

	private Font font_0;

	private string string_0 = "";

	private BufferedBitmap bufferedBitmap_1;

	private Point point_2 = Point.Empty;

	private Timer timer_1;

	private bool bool_9 = true;

	private BaseRenderer baseRenderer_0;

	private BaseRenderer baseRenderer_1;

	private eRenderMode eRenderMode_0 = eRenderMode.Global;

	[DefaultValue("")]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[Category("Appearance")]
	[Description("Indicates text displayed in form caption instead of the Form.Text property.")]
	public string TitleText
	{
		get
		{
			return string_0;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			string_0 = value;
			if (value == "")
			{
				labelItem_0.Text = ((Control)this).get_Text();
			}
			else
			{
				labelItem_0.Text = value;
			}
			if (((Control)this).get_IsHandleCreated())
			{
				method_22();
			}
			InvalidateNonClient(invalidateForm: false);
		}
	}

	[Description("Indicates font for the form caption text when CaptionVisible=true.")]
	[Browsable(true)]
	[Category("Caption")]
	[DefaultValue(null)]
	public Font CaptionFont
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
			method_13();
		}
	}

	protected override bool EnableGlassExtend => false;

	[Browsable(true)]
	public Icon Icon
	{
		get
		{
			return ((Form)this).get_Icon();
		}
		set
		{
			((Form)this).set_Icon(value);
			systemCaptionItem_0.Icon = value;
			method_26();
		}
	}

	[Browsable(false)]
	[DefaultValue(false)]
	public override bool AutoScroll
	{
		get
		{
			return ((Form)this).get_AutoScroll();
		}
		set
		{
			((Form)this).set_AutoScroll(value);
		}
	}

	protected bool CloseEnabled
	{
		get
		{
			return systemCaptionItem_1.CloseEnabled;
		}
		set
		{
			systemCaptionItem_1.CloseEnabled = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[Description("Indicates the Office 2007 Renderer global Color Table.")]
	[Category("Appearance")]
	public eOffice2007ColorScheme Office2007ColorTable
	{
		get
		{
			if (GetRenderer() is Office2007Renderer office2007Renderer)
			{
				return office2007Renderer.ColorTable.InitialColorScheme;
			}
			return eOffice2007ColorScheme.Blue;
		}
		set
		{
			RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(value);
		}
	}

	protected override bool PaintClientBorder => false;

	protected override bool PaintRibbonCaption => false;

	[Category("Appearance")]
	[Description("Gets or sets whether anti-aliasing is used while painting form caption.")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool CaptionAntiAlias
	{
		get
		{
			return bool_9;
		}
		set
		{
			if (bool_9 != value)
			{
				bool_9 = value;
			}
		}
	}

	[DefaultValue(eRenderMode.Global)]
	[Browsable(false)]
	public eRenderMode RenderMode
	{
		get
		{
			return eRenderMode_0;
		}
		set
		{
			if (eRenderMode_0 != value)
			{
				eRenderMode_0 = value;
				((Control)this).Invalidate(true);
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(null)]
	public BaseRenderer Renderer
	{
		get
		{
			return baseRenderer_1;
		}
		set
		{
			baseRenderer_1 = value;
		}
	}

	[Description("Indicates tooltip for the form system icon.")]
	[DefaultValue("")]
	[Localizable(true)]
	[Browsable(true)]
	public string IconTooltip
	{
		get
		{
			return systemCaptionItem_0.Tooltip;
		}
		set
		{
			systemCaptionItem_0.Tooltip = value;
		}
	}

	public Office2007Form()
	{
		int_5 = SystemInformation.get_Border3DSize().Width + Class92.Int32_0;
		((ScrollableControl)this).get_DockPadding().set_All(0);
		genericItemContainer_0 = new GenericItemContainer();
		genericItemContainer_0.GlobalItem = false;
		genericItemContainer_0.ContainerControl = this;
		genericItemContainer_0.WrapItems = false;
		genericItemContainer_0.Boolean_3 = false;
		genericItemContainer_0.Boolean_4 = false;
		genericItemContainer_0.Stretch = true;
		genericItemContainer_0.Displayed = true;
		genericItemContainer_0.SystemContainer = true;
		genericItemContainer_0.PaddingTop = 0;
		genericItemContainer_0.PaddingBottom = 0;
		genericItemContainer_0.PaddingLeft = 2;
		genericItemContainer_0.ItemSpacing = 1;
		genericItemContainer_0.method_6(this);
		genericItemContainer_0.Style = eDotNetBarStyle.Office2007;
		genericItemContainer_0.EContainerVerticalAlignment_0 = eContainerVerticalAlignment.Top;
		systemCaptionItem_0 = new SystemCaptionItem();
		systemCaptionItem_0.Enabled = false;
		genericItemContainer_0.SubItems.Add(systemCaptionItem_0);
		systemCaptionItem_0.IsSystemIcon = true;
		systemCaptionItem_0.Icon = Icon;
		labelItem_0 = new LabelItem();
		labelItem_0.Font = SystemInformation.get_MenuFont();
		labelItem_0.Stretch = true;
		labelItem_0.TextLineAlignment = (StringAlignment)1;
		labelItem_0.Text = ((Control)this).get_Text();
		labelItem_0.PaddingLeft = 3;
		labelItem_0.PaddingRight = 3;
		genericItemContainer_0.SubItems.Add(labelItem_0);
		systemCaptionItem_1 = new SystemCaptionItem();
		systemCaptionItem_1.Click += systemCaptionItem_1_Click;
		systemCaptionItem_1.MouseEnter += systemCaptionItem_1_MouseEnter;
		genericItemContainer_0.SubItems.Add(systemCaptionItem_1);
	}

	protected override bool IsCustomFormStyleEnabled()
	{
		if (base.IsCustomFormStyleEnabled())
		{
			if (Class51.Boolean_0 && base.EnableGlass && !((Component)(object)this).DesignMode)
			{
				return ((Form)this).get_IsMdiChild();
			}
			return true;
		}
		return false;
	}

	private void method_13()
	{
		if (labelItem_0 != null)
		{
			if (font_0 != null)
			{
				labelItem_0.Font = font_0;
			}
			else
			{
				labelItem_0.Font = SystemFonts.get_CaptionFont();
			}
			((Control)this).Invalidate(genericItemContainer_0.DisplayRectangle);
		}
		InvalidateNonClient(invalidateForm: false);
	}

	protected override void OnFontChanged(EventArgs e)
	{
		((Form)this).OnFontChanged(e);
		InvalidateNonClient(invalidateForm: false);
	}

	protected override bool WindowsMessageSetIcon(ref Message m)
	{
		method_26();
		return base.WindowsMessageSetIcon(ref m);
	}

	public void InvalidateNonClient(bool invalidateForm)
	{
		if (Class109.smethod_11((Control)(object)this))
		{
			Class92.RECT lprcUpdate = new Class92.RECT(0, 0, ((Control)this).get_Width(), genericItemContainer_0.HeightInternal);
			if (invalidateForm)
			{
				lprcUpdate = new Class92.RECT(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			}
			Class92.RedrawWindow(((Control)this).get_Handle(), ref lprcUpdate, IntPtr.Zero, 1025u);
		}
	}

	protected override Rectangle ReduceDisplayRectangle(Rectangle r)
	{
		return r;
	}

	protected override void AdjustBounds(ref int width, ref int height, BoundsSpecified specified)
	{
	}

	protected override bool WindowsMessageNCCalcSize(ref Message m)
	{
		if (((Message)(ref m)).get_WParam() == IntPtr.Zero)
		{
			Class51.RECT rECT = Class51.RECT.FromRectangle(GetClientRectangle(((Class51.RECT)Marshal.PtrToStructure(((Message)(ref m)).get_LParam(), typeof(Class51.RECT))).ToRectangle()));
			Marshal.StructureToPtr((object)rECT, ((Message)(ref m)).get_LParam(), fDeleteOld: false);
			((Message)(ref m)).set_Result(IntPtr.Zero);
		}
		else
		{
			Class51.NCCALCSIZE_PARAMS nCCALCSIZE_PARAMS = (Class51.NCCALCSIZE_PARAMS)Marshal.PtrToStructure(((Message)(ref m)).get_LParam(), typeof(Class51.NCCALCSIZE_PARAMS));
			Class51.WINDOWPOS wINDOWPOS = (Class51.WINDOWPOS)Marshal.PtrToStructure(nCCALCSIZE_PARAMS.lppos, typeof(Class51.WINDOWPOS));
			nCCALCSIZE_PARAMS.rgrc1 = (nCCALCSIZE_PARAMS.rgrc0 = Class51.RECT.FromRectangle(GetClientRectangle(new Rectangle(wINDOWPOS.x, wINDOWPOS.y, wINDOWPOS.cx, wINDOWPOS.cy))));
			Marshal.StructureToPtr((object)nCCALCSIZE_PARAMS, ((Message)(ref m)).get_LParam(), fDeleteOld: false);
			((Message)(ref m)).set_Result(new IntPtr(1024));
		}
		return false;
	}

	protected override bool WindowsMessageNCActivate(ref Message m)
	{
		if (((Message)(ref m)).get_WParam() != IntPtr.Zero)
		{
			base.Boolean_0 = true;
		}
		else
		{
			base.Boolean_0 = false;
		}
		method_14();
		BaseWndProc(ref m);
		method_15();
		PaintNonClientAreaBuffered();
		Redraw();
		return false;
	}

	private void method_14()
	{
		if (bufferedBitmap_1 != null)
		{
			bufferedBitmap_1.Dispose();
			bufferedBitmap_1 = null;
		}
		if (genericItemContainer_0.DisplayRectangle.Width > 0 && genericItemContainer_0.DisplayRectangle.Height > 0 && ((Control)this).get_IsHandleCreated() && !((Control)this).get_IsDisposed())
		{
			IntPtr windowDC = Class51.GetWindowDC(((Control)this).get_Handle());
			try
			{
				bufferedBitmap_1 = new BufferedBitmap(windowDC, new Rectangle(point_2.X, point_2.Y, genericItemContainer_0.DisplayRectangle.Width, genericItemContainer_0.DisplayRectangle.Height));
			}
			finally
			{
				Class51.ReleaseDC(((Control)this).get_Handle(), windowDC);
			}
			method_27(bufferedBitmap_1.Graphics);
		}
	}

	private void method_15()
	{
		if (bufferedBitmap_1 != null)
		{
			IntPtr windowDC = Class51.GetWindowDC(((Control)this).get_Handle());
			Graphics val = Graphics.FromHdc(windowDC);
			try
			{
				bufferedBitmap_1.Render(val);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			Class51.ReleaseDC(((Control)this).get_Handle(), windowDC);
			bufferedBitmap_1.Dispose();
			bufferedBitmap_1 = null;
		}
	}

	protected override Rectangle GetClientRectangle(Rectangle rect)
	{
		Class203 @class = method_21();
		return new Rectangle(rect.X + @class.int_2, rect.Y + @class.int_0, rect.Width - (@class.int_2 + @class.int_3), rect.Height - (@class.int_0 + @class.int_1));
	}

	protected override GraphicsPath GetFormPath(Rectangle bounds)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		Rectangle rectangle = bounds;
		Struct10 @struct = ElementStyleDisplay.smethod_10(rectangle, int_6, Enum14.const_0);
		val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
		@struct = ElementStyleDisplay.smethod_10(rectangle, int_6, Enum14.const_1);
		val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
		val.AddLine(rectangle.Right, rectangle.Bottom - 3, rectangle.Right, rectangle.Bottom);
		val.AddLine(rectangle.Right, rectangle.Bottom, rectangle.Right - 3, rectangle.Bottom);
		val.AddLine(rectangle.X + 3, rectangle.Bottom, rectangle.X, rectangle.Bottom);
		val.AddLine(rectangle.X, rectangle.Bottom, rectangle.X, rectangle.Bottom - 3);
		val.CloseAllFigures();
		return val;
	}

	private Point method_16()
	{
		if (((Control)this).get_IsDisposed())
		{
			return Point.Empty;
		}
		Point result = ((Control)this).PointToClient(Control.get_MousePosition());
		result.X += int_5;
		result.Y += genericItemContainer_0.HeightInternal;
		return result;
	}

	protected override bool WindowsMessageNCMouseMove(ref Message m)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		Point point = method_16();
		genericItemContainer_0.InternalMouseMove(new MouseEventArgs(Control.get_MouseButtons(), 0, point.X, point.Y, 0));
		if (systemCaptionItem_0.Tooltip != "" && genericItemContainer_0.BaseItem_1 == systemCaptionItem_0)
		{
			method_17();
		}
		if ((int)Control.get_MouseButtons() == 1048576)
		{
			BaseItem baseItem = genericItemContainer_0.ItemAtLocation(point.X, point.Y);
			if (baseItem == labelItem_0 && (int)base.WindowState == 0)
			{
				byte[] bytes = BitConverter.GetBytes(point.X);
				byte[] bytes2 = BitConverter.GetBytes(point.Y);
				byte[] value = new byte[4]
				{
					bytes[0],
					bytes[1],
					bytes2[0],
					bytes2[1]
				};
				int lParam = BitConverter.ToInt32(value, 0);
				((Control)this).set_Capture(false);
				Class92.SendMessage(((Control)this).get_Handle(), 274, 61458, lParam);
				return false;
			}
		}
		return true;
	}

	protected override bool WindowsMessageNCMouseLeave(ref Message m)
	{
		method_18();
		genericItemContainer_0.InternalMouseLeave();
		return true;
	}

	private void method_17()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		if (timer_1 != null)
		{
			timer_1.Stop();
			timer_1.Start();
			return;
		}
		timer_1 = new Timer();
		timer_1.set_Interval(Math.Max(500, SystemInformation.get_MouseHoverTime()));
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		timer_1.Start();
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		timer_1.Stop();
		if (systemCaptionItem_0 != null && systemCaptionItem_0.Tooltip != "" && genericItemContainer_0 != null && genericItemContainer_0.BaseItem_1 == systemCaptionItem_0)
		{
			genericItemContainer_0.InternalMouseHover();
		}
		method_18();
	}

	private void method_18()
	{
		Timer val = timer_1;
		if (timer_1 != null)
		{
			timer_1 = null;
			val.Stop();
			val.remove_Tick((EventHandler)timer_1_Tick);
		}
	}

	protected override bool WindowsMessageNCHitTest(ref Message m)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		int x = Class51.smethod_4(((Message)(ref m)).get_LParam());
		int y = Class51.smethod_5(((Message)(ref m)).get_LParam());
		Point pt = ((Control)this).PointToClient(new Point(x, y));
		pt.X += int_5;
		pt.Y += int_5 + SystemInformation.get_CaptionHeight();
		int num = int_5;
		int num2 = 2;
		if (IsSizable)
		{
			if (((Form)this).get_RightToLeftLayout() && (int)((Control)this).get_RightToLeft() == 1)
			{
				if (new Rectangle(((Control)this).get_Width() - (int_6 + num2), 0, int_6 + num2, int_6 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(13));
					return false;
				}
				if (new Rectangle(0, 0, int_6 + num2, int_6 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(14));
					return false;
				}
				if (new Rectangle(((Control)this).get_Width() - (int_6 + num2), ((Control)this).get_Height() - (int_6 + num2), int_6 + num2, int_6 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(16));
					return false;
				}
				if (new Rectangle(0, ((Control)this).get_Height() - (int_6 + num2), int_6 + num2, int_6 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(17));
					return false;
				}
				if (new Rectangle(((Control)this).get_Width() - num, 0, num, ((Control)this).get_Height()).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(10));
					return false;
				}
				if (new Rectangle(0, 0, num, ((Control)this).get_Height()).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(11));
					return false;
				}
			}
			else
			{
				if (new Rectangle(0, 0, int_6 + num2, int_6 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(13));
					return false;
				}
				if (new Rectangle(((Control)this).get_Width() - (int_6 + num2), 0, int_6 + num2, int_6 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(14));
					return false;
				}
				if (new Rectangle(0, ((Control)this).get_Height() - int_6, int_6 + num2, int_6 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(16));
					return false;
				}
				if (new Rectangle(((Control)this).get_Width() - int_6, ((Control)this).get_Height() - int_6, int_6 + num2, int_6 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(17));
					return false;
				}
				if (new Rectangle(0, 0, ((Control)this).get_Width(), num).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(12));
					return false;
				}
				if (new Rectangle(0, ((Control)this).get_Height() - num, ((Control)this).get_Width(), num).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(15));
					return false;
				}
				if (new Rectangle(0, 0, num, ((Control)this).get_Height()).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(10));
					return false;
				}
				if (new Rectangle(((Control)this).get_Width() - num, 0, num, ((Control)this).get_Height()).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(11));
					return false;
				}
			}
		}
		BaseItem baseItem = genericItemContainer_0.ItemAtLocation(pt.X, pt.Y);
		if (baseItem == labelItem_0)
		{
			((Message)(ref m)).set_Result(new IntPtr(2));
			return false;
		}
		if (baseItem == systemCaptionItem_0)
		{
			((Message)(ref m)).set_Result(new IntPtr(5));
			return false;
		}
		if (baseItem == systemCaptionItem_1)
		{
			switch (systemCaptionItem_1.vmethod_2(pt.X, pt.Y))
			{
			case Enum13.const_1:
				((Message)(ref m)).set_Result(new IntPtr(8));
				break;
			case Enum13.const_5:
				((Message)(ref m)).set_Result(new IntPtr(9));
				break;
			case Enum13.const_3:
				((Message)(ref m)).set_Result(new IntPtr(20));
				break;
			case Enum13.const_2:
				((Message)(ref m)).set_Result(new IntPtr(9));
				break;
			case Enum13.const_4:
				((Message)(ref m)).set_Result(new IntPtr(21));
				break;
			}
			return false;
		}
		return true;
	}

	protected override bool WindowsMessageNCLButtonDown(ref Message m)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		if (((Message)(ref m)).get_WParam().ToInt32() != 12 && ((Message)(ref m)).get_WParam().ToInt32() != 14)
		{
			Point point = method_16();
			genericItemContainer_0.InternalMouseDown(new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0));
			BaseItem baseItem = genericItemContainer_0.ItemAtLocation(point.X, point.Y);
			if (baseItem != null && (baseItem == systemCaptionItem_1 || baseItem == labelItem_0 || (point.X >= systemCaptionItem_1.DisplayRectangle.X && point.X <= systemCaptionItem_1.DisplayRectangle.Right)))
			{
				if (!base.Boolean_0)
				{
					((Form)this).Activate();
				}
				return false;
			}
			return true;
		}
		return true;
	}

	protected override bool WindowsMessageNCLButtonUp(ref Message m)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		Point point = method_16();
		BaseItem baseItem = genericItemContainer_0.ItemAtLocation(point.X, point.Y);
		genericItemContainer_0.InternalMouseUp(new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0));
		if (baseItem == systemCaptionItem_1)
		{
			return false;
		}
		return true;
	}

	private void systemCaptionItem_1_Click(object sender, EventArgs e)
	{
		SystemCaptionItem systemCaptionItem = sender as SystemCaptionItem;
		if (systemCaptionItem.Enum13_2 == Enum13.const_1)
		{
			Class92.PostMessage(((Control)this).get_Handle().ToInt32(), 274, 61472, 0);
			genericItemContainer_0.InternalMouseLeave();
		}
		else if (systemCaptionItem.Enum13_2 == Enum13.const_5)
		{
			Class92.PostMessage(((Control)this).get_Handle().ToInt32(), 274, 61488, 0);
			genericItemContainer_0.InternalMouseLeave();
		}
		else if (systemCaptionItem.Enum13_2 == Enum13.const_2)
		{
			Class92.PostMessage(((Control)this).get_Handle().ToInt32(), 274, 61728, 0);
			genericItemContainer_0.InternalMouseLeave();
		}
		else if (systemCaptionItem.Enum13_2 == Enum13.const_3)
		{
			Class92.PostMessage(((Control)this).get_Handle().ToInt32(), 274, 61536, 0);
			genericItemContainer_0.InternalMouseLeave();
		}
		else if (systemCaptionItem.Enum13_2 == Enum13.const_4)
		{
			Class92.PostMessage(((Control)this).get_Handle().ToInt32(), 274, 61824, 0);
			genericItemContainer_0.InternalMouseLeave();
		}
	}

	private void systemCaptionItem_1_MouseEnter(object sender, EventArgs e)
	{
		if (timer_0 == null)
		{
			method_19();
		}
	}

	private void method_19()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		timer_0 = new Timer();
		timer_0.set_Interval(200);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		Point pt = method_16();
		if (systemCaptionItem_1 != null && !systemCaptionItem_1.DisplayRectangle.Contains(pt))
		{
			timer_0.set_Enabled(false);
			method_20();
			systemCaptionItem_1.InternalMouseLeave();
		}
	}

	private void method_20()
	{
		if (timer_0 != null)
		{
			timer_0.set_Enabled(false);
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		if (!((Control)this).get_Visible())
		{
			method_20();
		}
		((Form)this).OnVisibleChanged(e);
	}

	protected override void OnClosed(EventArgs e)
	{
		method_20();
		((Form)this).OnClosed(e);
	}

	protected override void OnResize(EventArgs e)
	{
		method_22();
		base.OnResize(e);
	}

	private Class203 method_21()
	{
		Class51.RECT lpRect = new Class51.RECT(0, 0, 200, 200);
		CreateParams createParams = ((Control)this).get_CreateParams();
		Class51.AdjustWindowRectEx(ref lpRect, createParams.get_Style(), bMenu: false, createParams.get_ExStyle());
		Class203 @class = new Class203();
		@class.int_0 = Math.Abs(lpRect.Top);
		@class.int_1 = lpRect.Height - 200 - @class.int_0;
		@class.int_2 = Math.Abs(lpRect.Left);
		@class.int_3 = lpRect.Width - 200 - @class.int_2;
		return @class;
	}

	private void method_22()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Invalid comparison between Unknown and I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Invalid comparison between Unknown and I4
		if (genericItemContainer_0 != null)
		{
			Class203 @class = method_21();
			genericItemContainer_0.LeftInternal = 1;
			genericItemContainer_0.TopInternal = 0;
			genericItemContainer_0.PaddingLeft = @class.int_2;
			genericItemContainer_0.PaddingRight = @class.int_3;
			genericItemContainer_0.PaddingTop = @class.int_1;
			genericItemContainer_0.WidthInternal = ((Control)this).get_Width() - 1;
			genericItemContainer_0.HeightInternal = @class.int_0;
			genericItemContainer_0.IsRightToLeft = (int)((Control)this).get_RightToLeft() == 1;
			if (labelItem_0 != null)
			{
				labelItem_0.Height = genericItemContainer_0.HeightInternal - @class.int_1 - 2;
				if (string_0 != "")
				{
					labelItem_0.Width = 0;
				}
				else
				{
					labelItem_0.Width = 16;
				}
				labelItem_0.TextLineAlignment = (StringAlignment)1;
			}
			genericItemContainer_0.RecalcSize();
			genericItemContainer_0.HeightInternal = @class.int_0;
			if (systemCaptionItem_0 != null)
			{
				systemCaptionItem_0.TopInternal += (genericItemContainer_0.HeightInternal - systemCaptionItem_0.HeightInternal - @class.int_1 - 2) / 2;
			}
		}
		if ((int)base.WindowState != 2 && (int)base.WindowState != 1)
		{
			systemCaptionItem_1.RestoreEnabled = false;
		}
		else
		{
			systemCaptionItem_1.RestoreEnabled = true;
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		genericItemContainer_0.InternalMouseLeave();
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnDeactivate(EventArgs e)
	{
		base.OnDeactivate(e);
		method_20();
		genericItemContainer_0.InternalMouseLeave();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		base.OnTextChanged(e);
		UpdateFormText();
	}

	public void UpdateFormText()
	{
		bool flag = false;
		if (labelItem_0 != null && string_0 == "")
		{
			flag = labelItem_0.Text != ((Control)this).get_Text();
			labelItem_0.Text = ((Control)this).get_Text();
		}
		if (flag)
		{
			if (((Form)this).get_IsMdiChild() && ((Form)this).get_MdiParent() is Office2007RibbonForm)
			{
				((Office2007RibbonForm)(object)((Form)this).get_MdiParent()).method_3();
			}
			InvalidateNonClient(invalidateForm: false);
		}
	}

	protected override void OnControlAdded(ControlEventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		if (e.get_Control() is MdiClient)
		{
			e.get_Control().add_ControlRemoved(new ControlEventHandler(method_23));
			e.get_Control().add_ControlAdded(new ControlEventHandler(method_24));
		}
		base.OnControlAdded(e);
	}

	private void method_23(object sender, ControlEventArgs e)
	{
		e.get_Control().remove_Resize((EventHandler)method_25);
	}

	private void method_24(object sender, ControlEventArgs e)
	{
		e.get_Control().add_Resize((EventHandler)method_25);
	}

	protected override void OnMdiChildActivate(EventArgs e)
	{
		UpdateFormText();
		base.OnMdiChildActivate(e);
	}

	private void method_25(object sender, EventArgs e)
	{
		UpdateFormText();
	}

	protected override void OnStyleChanged(EventArgs e)
	{
		method_26();
		InvalidateNonClient(invalidateForm: false);
		base.OnStyleChanged(e);
	}

	protected override void OnSystemColorsChanged(EventArgs e)
	{
		method_13();
		((Control)this).OnSystemColorsChanged(e);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		method_26();
		base.OnHandleCreated(e);
	}

	private void method_26()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		if (systemCaptionItem_1 != null)
		{
			systemCaptionItem_1.MinimizeVisible = ((Form)this).get_MinimizeBox();
			systemCaptionItem_1.RestoreMaximizeVisible = ((Form)this).get_MaximizeBox();
			systemCaptionItem_1.Visible = ((Form)this).get_ControlBox();
			systemCaptionItem_0.Visible = ((Form)this).get_ControlBox();
			systemCaptionItem_1.HelpVisible = ((Form)this).get_HelpButton();
		}
		if (systemCaptionItem_0 != null)
		{
			systemCaptionItem_0.Visible = ((Form)this).get_ShowIcon();
		}
		if ((int)((Form)this).get_FormBorderStyle() == 3)
		{
			systemCaptionItem_0.Visible = false;
		}
		if (((Control)this).get_IsHandleCreated())
		{
			method_22();
		}
	}

	protected override bool WindowsMessageNCPaint(ref Message m)
	{
		((Message)(ref m)).set_Result(IntPtr.Zero);
		if (((Control)this).get_IsHandleCreated() && !((Control)this).get_IsDisposed() && ((Control)this).get_Handle() != IntPtr.Zero && base.EnableCustomStyle)
		{
			PaintNonClientAreaBuffered();
		}
		return false;
	}

	protected virtual void PaintNonClientAreaBuffered()
	{
		IntPtr windowDC = Class51.GetWindowDC(((Control)this).get_Handle());
		try
		{
			Graphics val = Graphics.FromHdc(windowDC);
			try
			{
				PaintNonClientAreaBuffered(val);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		finally
		{
			Class51.ReleaseDC(((Control)this).get_Handle(), windowDC);
		}
	}

	protected virtual void PaintNonClientAreaBuffered(Graphics targetGraphics)
	{
		BufferedBitmap bufferedBitmap = new BufferedBitmap(targetGraphics, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
		try
		{
			bufferedBitmap.Graphics.SetClip(GetClientRectangle(new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height())), (CombineMode)4);
			PaintNonClientArea(bufferedBitmap.Graphics);
			bufferedBitmap.Render(targetGraphics, GetClientRectangle(new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height())));
		}
		finally
		{
			bufferedBitmap.Dispose();
		}
	}

	protected virtual void PaintNonClientArea(Graphics g)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		Class203 @class = method_21();
		PaintFormBorder(g, @class.int_2);
		Rectangle bounds = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 1);
		if (((Form)this).get_RightToLeftLayout())
		{
			bounds = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 1);
		}
		GraphicsPath formPath = GetFormPath(bounds);
		Region val = new Region();
		val.MakeEmpty();
		val.Union(formPath);
		formPath.Widen(SystemPens.get_Control());
		new Region(formPath);
		val.Union(formPath);
		g.SetClip(val, (CombineMode)0);
		method_27(g);
		g.ResetClip();
	}

	private void method_27(Graphics graphics_0)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		ItemPaintArgs itemPaintArgs = method_28(graphics_0);
		if (itemPaintArgs.BaseRenderer_0 != null)
		{
			if (itemPaintArgs.BaseRenderer_0 is Office2007Renderer)
			{
				if (base.Boolean_0)
				{
					labelItem_0.ForeColor = ((Office2007Renderer)itemPaintArgs.BaseRenderer_0).ColorTable.Form.Active.CaptionText;
				}
				else
				{
					labelItem_0.ForeColor = ((Office2007Renderer)itemPaintArgs.BaseRenderer_0).ColorTable.Form.Inactive.CaptionText;
				}
			}
			itemPaintArgs.BaseRenderer_0.DrawFormCaptionBackground(new FormCaptionRendererEventArgs(graphics_0, genericItemContainer_0.DisplayRectangle, (Form)(object)this));
		}
		SmoothingMode smoothingMode = graphics_0.get_SmoothingMode();
		TextRenderingHint textRenderingHint = graphics_0.get_TextRenderingHint();
		if (bool_9)
		{
			graphics_0.set_SmoothingMode((SmoothingMode)4);
			graphics_0.set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
		genericItemContainer_0.Paint(itemPaintArgs);
		if (bool_9)
		{
			graphics_0.set_SmoothingMode(smoothingMode);
			graphics_0.set_TextRenderingHint(textRenderingHint);
		}
	}

	private ItemPaintArgs method_28(Graphics graphics_0)
	{
		ItemPaintArgs itemPaintArgs = new ItemPaintArgs(null, (Control)(object)this, graphics_0, GetColorScheme());
		itemPaintArgs.BaseRenderer_0 = GetRenderer();
		return itemPaintArgs;
	}

	protected virtual ColorScheme GetColorScheme()
	{
		if (colorScheme_0 == null)
		{
			if (GlobalManager.Renderer is Office2007Renderer)
			{
				return ((Office2007Renderer)GlobalManager.Renderer).ColorTable.LegacyColors;
			}
			return new ColorScheme(eDotNetBarStyle.Office2007);
		}
		return colorScheme_0;
	}

	public virtual BaseRenderer GetRenderer()
	{
		if (eRenderMode_0 == eRenderMode.Global && GlobalManager.Renderer != null)
		{
			return GlobalManager.Renderer;
		}
		if (eRenderMode_0 == eRenderMode.Custom && baseRenderer_1 != null)
		{
			return baseRenderer_1;
		}
		if (baseRenderer_0 == null)
		{
			baseRenderer_0 = new Office2007Renderer();
		}
		return baseRenderer_1;
	}
}
