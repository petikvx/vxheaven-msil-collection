using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

[ToolboxItem(true)]
[DefaultEvent("ButtonClick")]
[ComVisible(false)]
[Designer(typeof(BubbleBarDesigner))]
public class BubbleBar : Control, ISupportInitialize, Interface5
{
	private class Class185
	{
		public int int_0;

		public int int_1;

		public float float_0;

		public float float_1;

		public float float_2;

		public float float_3;
	}

	private const float float_0 = 0.3f;

	private ImageList imageList_0;

	private ImageList imageList_1;

	private bool bool_0 = true;

	private eOrientation eOrientation_0;

	private Size size_0 = new Size(48, 48);

	private Size size_1 = new Size(24, 24);

	private BubbleContentManager bubbleContentManager_0 = new BubbleContentManager();

	private BubbleButtonLayoutManager bubbleButtonLayoutManager_0 = new BubbleButtonLayoutManager();

	private BubbleButton bubbleButton_0;

	private BubbleButton bubbleButton_1;

	private int int_0 = 100;

	private BubbleButtonDisplayInfo bubbleButtonDisplayInfo_0 = new BubbleButtonDisplayInfo();

	private bool bool_1 = true;

	private Control2 control2_0;

	private bool bool_2;

	private bool bool_3 = true;

	private bool bool_4;

	private bool bool_5 = true;

	private eBubbleButtonAlignment eBubbleButtonAlignment_0 = eBubbleButtonAlignment.Bottom;

	private int int_1 = 6;

	private Font font_0;

	private int int_2;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private BubbleBarTab bubbleBarTab_0;

	private BubbleBarTab bubbleBarTab_1;

	private TabColors tabColors_0 = new TabColors();

	private TabColors tabColors_1 = new TabColors();

	private BubbleBarTabCollection bubbleBarTabCollection_0;

	private bool bool_6 = true;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private SimpleTabLayoutManager simpleTabLayoutManager_0;

	private SimpleTabDisplay simpleTabDisplay_0;

	private SerialContentLayoutManager serialContentLayoutManager_0;

	private Point point_0 = Point.Empty;

	private BubbleButton bubbleButton_2;

	private ElementStyle elementStyle_0 = new ElementStyle();

	private ElementStyle elementStyle_1 = new ElementStyle();

	private bool bool_7 = true;

	private bool bool_8;

	private bool bool_9;

	private Color color_0 = Color.White;

	private Color color_1 = Color.Black;

	private BubbleBarTabChangingEventHadler bubbleBarTabChangingEventHadler_0;

	private ClickEventHandler clickEventHandler_0;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private Timer timer_0;

	private BubbleBarTab bubbleBarTab_2;

	private int int_3 = -1;

	private int int_4 = -1;

	private BubbleButton bubbleButton_3;

	private bool bool_10;

	[Description("Indicates bubble button tooltip text color.")]
	[Browsable(true)]
	[Category("Appearance")]
	public Color TooltipTextColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
		}
	}

	[Description("Indicates bubble button tooltip text outline color.")]
	[Browsable(true)]
	[Category("Appearance")]
	public Color TooltipOutlineColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
		}
	}

	[Category("Appearance")]
	[Description("Indicates spacing in pixels between buttons.")]
	[Browsable(true)]
	[DefaultValue(0)]
	public int ButtonSpacing
	{
		get
		{
			return bubbleContentManager_0.BlockSpacing;
		}
		set
		{
			bubbleContentManager_0.BlockSpacing = value;
			RecalcLayout();
			((Control)this).Refresh();
		}
	}

	[Description("Indicates whether background for the buttons is stretched to consume complete width of the control.")]
	[Category("Button Background")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool ButtonBackgroundStretch
	{
		get
		{
			return bool_7;
		}
		set
		{
			if (bool_7 != value)
			{
				bool_7 = value;
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Appearance")]
	[Description("Gets the style for the background of the control.")]
	public ElementStyle BackgroundStyle => elementStyle_1;

	[Category("Button Background")]
	[Description("Gets the style for the background of the buttons.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	public ElementStyle ButtonBackAreaStyle => elementStyle_0;

	[Browsable(false)]
	public Rectangle ButtonBackAreaBounds => rectangle_0;

	[Browsable(false)]
	public Rectangle TabAreaBounds => rectangle_1;

	[DefaultValue(100)]
	[Browsable(true)]
	[Description("Indicates duration of animatio.")]
	[Category("Appearance")]
	public int AnimationTime
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[Description("Indicates whether animation is enabled.")]
	[DefaultValue(true)]
	public bool AnimationEnabled
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			if (!bool_3)
			{
				method_6();
			}
		}
	}

	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(false)]
	public bool AntiAlias
	{
		get
		{
			return bool_1;
		}
		set
		{
			if (bool_1 != value)
			{
				bool_1 = value;
				((Control)this).Refresh();
			}
		}
	}

	[Browsable(true)]
	[Category("Button Images")]
	[Description("ImageList for images used on buttons.")]
	[DefaultValue(null)]
	public ImageList Images
	{
		get
		{
			return imageList_0;
		}
		set
		{
			if (imageList_0 != null)
			{
				((Component)(object)imageList_0).Disposed -= imageList_1_Disposed;
			}
			imageList_0 = value;
			if (imageList_0 != null)
			{
				((Component)(object)imageList_0).Disposed += imageList_1_Disposed;
			}
		}
	}

	[Category("Button Images")]
	[Browsable(true)]
	[DefaultValue(null)]
	[Description("ImageList for large-sized images used on buttons when button is magnified.")]
	public ImageList ImagesLarge
	{
		get
		{
			return imageList_1;
		}
		set
		{
			if (imageList_1 != null)
			{
				((Component)(object)imageList_1).Disposed -= imageList_1_Disposed;
			}
			imageList_1 = value;
			if (imageList_1 != null)
			{
				((Component)(object)imageList_1).Disposed += imageList_1_Disposed;
			}
		}
	}

	[Category("Appearance")]
	[Description("Indicates whether tooltips are displayed for the buttons.")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool ShowTooltips
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

	[Description("Indicates size of the images when button is enlarged.")]
	[Category("Button Images")]
	[Browsable(true)]
	public Size ImageSizeLarge
	{
		get
		{
			return size_0;
		}
		set
		{
			if (size_0 != value)
			{
				size_0 = value;
				RecalcLayout();
				((Control)this).Refresh();
			}
		}
	}

	[Description("Indicates size of the images when button is enlarged.")]
	[Category("Button Images")]
	[Browsable(true)]
	public Size ImageSizeNormal
	{
		get
		{
			return size_1;
		}
		set
		{
			if (size_1 != value)
			{
				size_1 = value;
				RecalcLayout();
				((Control)this).Refresh();
			}
		}
	}

	[Category("Appearance")]
	[DefaultValue(null)]
	[Browsable(true)]
	public Font TooltipFont
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
		}
	}

	[DefaultValue(null)]
	[Browsable(false)]
	public BubbleBarTab SelectedTab
	{
		get
		{
			return bubbleBarTab_0;
		}
		set
		{
			if (bubbleBarTab_0 != value)
			{
				bubbleBarTab_0 = value;
				method_39();
			}
		}
	}

	[Browsable(true)]
	[Description("Gets the reference to the colors that are used when tab is selected.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Tabs")]
	public TabColors SelectedTabColors => tabColors_0;

	[Description("Gets the reference to the colors that are used when mouse is over the tab.")]
	[Category("Tabs")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public TabColors MouseOverTabColors => tabColors_1;

	[Description("Returns the collection of Tabs.")]
	[Category("Tabs")]
	[Editor(typeof(BubbleBarTabCollectionEditor), typeof(UITypeEditor))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public BubbleBarTabCollection Tabs => bubbleBarTabCollection_0;

	[Description("Indicates button alignment.")]
	[Category("Appearance")]
	[Browsable(true)]
	public eBubbleButtonAlignment Alignment
	{
		get
		{
			return eBubbleButtonAlignment_0;
		}
		set
		{
			if (eBubbleButtonAlignment_0 != value)
			{
				eBubbleButtonAlignment_0 = value;
				method_33();
				RecalcLayout();
				((Control)this).Refresh();
			}
		}
	}

	[Description("Indicates whether tabs are visible.")]
	[DefaultValue(true)]
	[Browsable(true)]
	[Category("Tabs")]
	public bool TabsVisible
	{
		get
		{
			return bool_6;
		}
		set
		{
			if (bool_6 != value)
			{
				bool_6 = value;
				method_24();
				method_1();
			}
		}
	}

	internal bool Boolean_0 => bool_10;

	bool Interface5.Boolean_0
	{
		get
		{
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				return val.get_Modal();
			}
			return false;
		}
	}

	public event BubbleBarTabChangingEventHadler TabChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			bubbleBarTabChangingEventHadler_0 = (BubbleBarTabChangingEventHadler)Delegate.Combine(bubbleBarTabChangingEventHadler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			bubbleBarTabChangingEventHadler_0 = (BubbleBarTabChangingEventHadler)Delegate.Remove(bubbleBarTabChangingEventHadler_0, value);
		}
	}

	public event ClickEventHandler ButtonClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			clickEventHandler_0 = (ClickEventHandler)Delegate.Combine(clickEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			clickEventHandler_0 = (ClickEventHandler)Delegate.Remove(clickEventHandler_0, value);
		}
	}

	public event EventHandler BubbleStart
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public event EventHandler BubbleEnd
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_1 = (EventHandler)Delegate.Combine(eventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_1 = (EventHandler)Delegate.Remove(eventHandler_1, value);
		}
	}

	public BubbleBar()
	{
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		if (!ColorFunctions.bool_0)
		{
			Class92.smethod_5();
			Class92.smethod_6();
			ColorFunctions.LoadColors();
		}
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).SetStyle((ControlStyles)1, false);
		((Control)this).SetStyle((ControlStyles)512, false);
		bubbleBarTabCollection_0 = new BubbleBarTabCollection(this);
		elementStyle_0.StyleChanged += elementStyle_1_StyleChanged;
		elementStyle_1.StyleChanged += elementStyle_1_StyleChanged;
		bubbleContentManager_0.BlockSpacing = 0;
		bubbleContentManager_0.ContentVerticalAlignment = eContentVerticalAlignment.Bottom;
		bubbleContentManager_0.BlockLineAlignment = eContentVerticalAlignment.Bottom;
		bubbleContentManager_0.ContentOrientation = eContentOrientation.Horizontal;
		simpleTabLayoutManager_0 = new SimpleTabLayoutManager();
		simpleTabDisplay_0 = new SimpleTabDisplay();
		serialContentLayoutManager_0 = new SerialContentLayoutManager();
		bubbleButtonDisplayInfo_0.BubbleBar = this;
		control2_0 = new Control2(this);
		control2_0 = null;
		if (!((FeatureSupport)OSFeature.get_Feature()).IsPresent(OSFeature.LayeredWindows))
		{
			bool_5 = false;
		}
		method_33();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTooltipTextColor()
	{
		return color_0 != Color.White;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTooltipTextColor()
	{
		TypeDescriptor.GetProperties(this)["TooltipTextColor"]!.SetValue(this, Color.White);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTooltipOutlineColor()
	{
		return color_1 != Color.Black;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTooltipOutlineColor()
	{
		TypeDescriptor.GetProperties(this)["TooltipOutlineColor"]!.SetValue(this, Color.Black);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeImageSizeLarge()
	{
		if (size_0.Width == 48 && size_0.Height == 48)
		{
			return false;
		}
		return true;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeImageSizeNormal()
	{
		if (size_0.Width == 24 && size_0.Height == 24)
		{
			return false;
		}
		return true;
	}

	public void RecalcLayout()
	{
		StopBubbleEffect();
		method_24();
		((Control)this).Invalidate();
	}

	public BubbleButton GetButtonAt(int x, int y)
	{
		if (bubbleBarTab_0 == null)
		{
			return null;
		}
		BubbleButton result = null;
		foreach (BubbleButton button in bubbleBarTab_0.Buttons)
		{
			if (!button.Visible)
			{
				continue;
			}
			if (bubbleButton_0 != null)
			{
				if (button.MagnifiedDisplayRectangle.Contains(x, y))
				{
					return button;
				}
			}
			else if (button.DisplayRectangle.Contains(x, y))
			{
				return button;
			}
		}
		return result;
	}

	public BubbleButton GetButtonAt(Point p)
	{
		return GetButtonAt(p.X, p.Y);
	}

	public BubbleBarTab GetTabAt(Point p)
	{
		return GetTabAt(p.X, p.Y);
	}

	public BubbleBarTab GetTabAt(int x, int y)
	{
		foreach (BubbleBarTab item in bubbleBarTabCollection_0)
		{
			if (item.DisplayRectangle.Contains(x, y))
			{
				return item;
			}
		}
		return null;
	}

	protected override void OnCursorChanged(EventArgs e)
	{
		if (control2_0 != null)
		{
			((Control)control2_0).set_Cursor(((Control)this).get_Cursor());
		}
		((Control)this).OnCursorChanged(e);
	}

	protected virtual void OnBubbleStart(EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, e);
		}
	}

	protected virtual void OnBubbleEnd(EventArgs e)
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, e);
		}
	}

	internal void method_0(BubbleButton bubbleButton_4, ClickEventArgs clickEventArgs_0)
	{
		if (clickEventHandler_0 != null)
		{
			clickEventHandler_0(bubbleButton_4, clickEventArgs_0);
		}
	}

	protected override bool ProcessMnemonic(char charCode)
	{
		string text = "&" + charCode;
		text = text.ToLower();
		foreach (BubbleBarTab tab in Tabs)
		{
			string text2 = tab.Text.ToLower();
			if (text2.IndexOf(text) >= 0)
			{
				SelectedTab = tab;
				return true;
			}
		}
		return ((Control)this).ProcessMnemonic(charCode);
	}

	protected override void OnSystemColorsChanged(EventArgs e)
	{
		((Control)this).OnSystemColorsChanged(e);
		Application.DoEvents();
		if (elementStyle_0.GetColorScheme() != null)
		{
			elementStyle_0.GetColorScheme().Refresh();
		}
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		if (((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0)
		{
			RecalcLayout();
			((Control)this).Refresh();
		}
	}

	private void method_1()
	{
		if (control2_0 != null)
		{
			control2_0.method_0();
			((Control)this).Refresh();
		}
		else
		{
			((Control)this).Refresh();
		}
	}

	private void elementStyle_1_StyleChanged(object sender, EventArgs e)
	{
		if (((Component)this).DesignMode)
		{
			method_24();
			((Control)this).Refresh();
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_BackColor().A < byte.MaxValue)
		{
			((Control)this).OnPaintBackground(e);
		}
		if (!((Control)this).get_BackColor().IsEmpty)
		{
			SolidBrush val = new SolidBrush(((Control)this).get_BackColor());
			try
			{
				e.get_Graphics().FillRectangle((Brush)(object)val, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		ElementStyleDisplayInfo elementStyleDisplayInfo = new ElementStyleDisplayInfo();
		elementStyleDisplayInfo.Bounds = ((Control)this).get_DisplayRectangle();
		elementStyleDisplayInfo.Graphics = e.get_Graphics();
		elementStyleDisplayInfo.Style = elementStyle_1;
		ElementStyleDisplay.Paint(elementStyleDisplayInfo);
		if (!rectangle_0.IsEmpty && Tabs.Count > 0)
		{
			Rectangle rectangle = (elementStyleDisplayInfo.Bounds = method_27());
			elementStyleDisplayInfo.Graphics = e.get_Graphics();
			elementStyleDisplayInfo.Style = elementStyle_0;
			ElementStyleDisplay.Paint(elementStyleDisplayInfo);
		}
		SmoothingMode smoothingMode = e.get_Graphics().get_SmoothingMode();
		TextRenderingHint textRenderingHint = e.get_Graphics().get_TextRenderingHint();
		if (bool_1)
		{
			e.get_Graphics().set_SmoothingMode((SmoothingMode)4);
			e.get_Graphics().set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
		if (!rectangle_1.IsEmpty)
		{
			Rectangle clip = method_29();
			e.get_Graphics().SetClip(clip);
			ISimpleTab[] array = new ISimpleTab[bubbleBarTabCollection_0.Count];
			bubbleBarTabCollection_0.method_1(array);
			simpleTabDisplay_0.Paint(e.get_Graphics(), array);
			e.get_Graphics().ResetClip();
		}
		if (control2_0 == null)
		{
			BubbleButtonDisplayInfo bubbleButtonDisplayInfo = method_8();
			bubbleButtonDisplayInfo.Graphics = e.get_Graphics();
			if (bubbleBarTab_0 != null)
			{
				foreach (BubbleButton button in bubbleBarTab_0.Buttons)
				{
					BubbleButton bubbleButton = (bubbleButtonDisplayInfo.Button = button);
					Class105.smethod_0(bubbleButtonDisplayInfo);
				}
			}
		}
		if (((Component)this).DesignMode && Tabs.Count == 0)
		{
			Rectangle displayRectangle = ((Control)this).get_DisplayRectangle();
			string string_ = "Right-click and choose Create Tab or Button to add new items.";
			Class55.smethod_1(e.get_Graphics(), string_, ((Control)this).get_Font(), SystemColors.ControlDarkDark, displayRectangle, eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter | eTextFormat.WordBreak);
		}
		e.get_Graphics().set_TextRenderingHint(textRenderingHint);
		e.get_Graphics().set_SmoothingMode(smoothingMode);
	}

	internal void method_2(PaintEventArgs paintEventArgs_0)
	{
		BubbleButtonDisplayInfo bubbleButtonDisplayInfo = method_8();
		bubbleButtonDisplayInfo.Graphics = paintEventArgs_0.get_Graphics();
		if (bubbleBarTab_0 == null)
		{
			return;
		}
		foreach (BubbleButton button in bubbleBarTab_0.Buttons)
		{
			BubbleButton bubbleButton = (bubbleButtonDisplayInfo.Button = button);
			Class105.smethod_0(bubbleButtonDisplayInfo);
		}
	}

	private bool method_3()
	{
		bool result = false;
		IntPtr foregroundWindow = Class92.GetForegroundWindow();
		try
		{
			Control val = Control.FromHandle(foregroundWindow);
			if (val != null)
			{
				return true;
			}
			return result;
		}
		catch
		{
			return false;
		}
	}

	private void method_4()
	{
		if (control2_0 == null)
		{
			OnBubbleStart(new EventArgs());
		}
		if (control2_0 == null && ((Control)this).get_Parent() != null && bool_5 && !((Component)this).DesignMode && bool_3)
		{
			Rectangle bounds = method_5();
			control2_0 = new Control2(this);
			((Control)control2_0).set_Bounds(bounds);
			((Control)control2_0).set_Visible(false);
			bubbleContentManager_0.MouseOverIndex = -1;
			method_24();
			if (bubbleButton_0 != null)
			{
				bubbleContentManager_0.MouseOverIndex = bubbleButton_0.Parent.Buttons.IndexOf(bubbleButton_0);
			}
			((Control)control2_0).CreateControl();
			Point point = ((Control)this).get_Parent().PointToScreen(((Control)control2_0).get_Location());
			control2_0.method_4();
			int hWndInsertAfter = -2;
			if (((Control)this).FindForm() != null && ((Control)this).FindForm().get_TopMost())
			{
				hWndInsertAfter = -1;
			}
			Class92.SetWindowPos(((Control)control2_0).get_Handle(), hWndInsertAfter, point.X, point.Y, ((Control)control2_0).get_Width(), ((Control)control2_0).get_Height(), 80);
			((Control)control2_0).set_Visible(true);
			control2_0.method_0();
			((Control)this).Refresh();
		}
	}

	private Rectangle method_5()
	{
		Rectangle result = new Rectangle(((Control)this).get_Location(), ((Control)this).get_Size());
		if (eBubbleButtonAlignment_0 == eBubbleButtonAlignment.Top || eBubbleButtonAlignment_0 == eBubbleButtonAlignment.Bottom)
		{
			int num = size_0.Height - size_1.Height;
			if (ShowTooltips)
			{
				if (TooltipFont != null)
				{
					int_2 = TooltipFont.get_Height() + 6;
				}
				else
				{
					int_2 = ((Control)this).get_Font().get_Height() + 6;
				}
				num += int_2;
			}
			result.Height += num;
			if (eBubbleButtonAlignment_0 == eBubbleButtonAlignment.Bottom)
			{
				result.Y -= num;
			}
		}
		return result;
	}

	internal void method_6()
	{
		method_11(null);
		method_10(null);
		method_1();
	}

	public void StopBubbleEffect()
	{
		method_11(null);
		method_10(null);
	}

	private void method_7()
	{
		if (control2_0 != null)
		{
			OnBubbleEnd(new EventArgs());
			((Control)control2_0).Hide();
			control2_0.method_5();
			((Component)(object)control2_0).Dispose();
			control2_0 = null;
			bubbleContentManager_0.MouseOverIndex = -1;
			method_24();
			if (bubbleButton_0 != null)
			{
				bubbleContentManager_0.MouseOverIndex = bubbleButton_0.Parent.Buttons.IndexOf(bubbleButton_0);
			}
		}
	}

	private BubbleButtonDisplayInfo method_8()
	{
		bubbleButtonDisplayInfo_0.Magnified = bubbleButton_0 != null && bool_3;
		bubbleButtonDisplayInfo_0.Alignment = eBubbleButtonAlignment_0;
		return bubbleButtonDisplayInfo_0;
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		if (method_3())
		{
			if (control2_0 != null && int_2 > 0)
			{
				Point point = ((Control)this).PointToScreen(new Point(e.get_X(), e.get_Y()));
				point = ((Control)control2_0).PointToClient(point);
				MouseEventArgs mouseEventArgs_ = new MouseEventArgs(e.get_Button(), e.get_Clicks(), point.X, point.Y, e.get_Delta());
				method_9(mouseEventArgs_);
			}
			else
			{
				method_9(e);
			}
		}
	}

	internal void method_9(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Invalid comparison between Unknown and I4
		((Control)this).OnMouseMove(mouseEventArgs_0);
		if (bool_4)
		{
			bool_4 = false;
			return;
		}
		bool flag = false;
		Point point = new Point(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
		BubbleButton buttonAt = GetButtonAt(point.X, point.Y);
		if (buttonAt != null && buttonAt == bubbleButton_2)
		{
			return;
		}
		if (buttonAt == null)
		{
			bubbleButton_2 = null;
		}
		if (buttonAt != null)
		{
			if (bubbleButton_0 == null)
			{
				method_4();
				bubbleButton_0 = buttonAt;
				method_30(buttonAt, point, bool_11: true);
				bubbleButton_0 = null;
			}
			if (bool_3)
			{
				Class185 @class = method_31(buttonAt.DisplayRectangle, point);
				bubbleContentManager_0.Factor1 = @class.float_0;
				bubbleContentManager_0.Factor2 = @class.float_1;
				bubbleContentManager_0.Factor3 = @class.float_2;
				bubbleContentManager_0.Factor4 = @class.float_3;
				bubbleContentManager_0.BubbleSize = size_0;
				bubbleContentManager_0.MouseOverPosition = @class.int_0;
				bubbleContentManager_0.MouseOverIndex = buttonAt.Parent.Buttons.IndexOf(buttonAt);
				method_24();
				flag = true;
				point_0 = point;
			}
		}
		if (bubbleBarTab_1 != null || rectangle_1.Contains(point))
		{
			BubbleBarTab tabAt = GetTabAt(point);
			method_43(tabAt);
		}
		if (bubbleButton_0 != buttonAt)
		{
			method_10(buttonAt);
			flag = true;
		}
		if (bubbleButton_0 != buttonAt && (int)mouseEventArgs_0.get_Button() == 1048576)
		{
			method_11(buttonAt);
			flag = true;
		}
		if (bubbleButton_0 != null)
		{
			Point mousePosition = Control.get_MousePosition();
			mousePosition = ((control2_0 == null) ? ((Control)this).PointToClient(mousePosition) : ((Control)control2_0).PointToClient(mousePosition));
			buttonAt = GetButtonAt(mousePosition.X, mousePosition.Y);
			if (buttonAt != bubbleButton_0)
			{
				method_10(buttonAt);
				flag = true;
			}
		}
		if (flag)
		{
			method_1();
		}
	}

	private void method_10(BubbleButton bubbleButton_4)
	{
		if (bubbleButton_0 != null)
		{
			bubbleButton_0.SetMouseOver(value: false);
			if (bubbleButton_4 == null && !point_0.IsEmpty)
			{
				method_30(bubbleButton_0, point_0, bool_11: false);
				point_0 = Point.Empty;
			}
		}
		bubbleButton_0 = bubbleButton_4;
		if (bubbleButton_0 != null)
		{
			bubbleButton_0.SetMouseOver(value: true);
			method_4();
		}
		else
		{
			method_11(null);
			method_7();
		}
		if (bubbleButton_0 != null)
		{
			bubbleContentManager_0.MouseOverIndex = bubbleButton_0.Parent.Buttons.IndexOf(bubbleButton_0);
		}
		else
		{
			bubbleContentManager_0.MouseOverIndex = -1;
		}
	}

	private void method_11(BubbleButton bubbleButton_4)
	{
		if (bubbleButton_1 != null)
		{
			bubbleButton_1.SetMouseDown(value: false);
		}
		if (bubbleButton_4 != null && !bubbleButton_4.Enabled)
		{
			bubbleButton_1 = null;
			return;
		}
		bubbleButton_1 = bubbleButton_4;
		if (bubbleButton_1 != null)
		{
			bubbleButton_1.SetMouseDown(value: true);
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		method_14();
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		method_12(e);
		((Control)this).OnMouseLeave(e);
	}

	internal void method_12(EventArgs eventArgs_0)
	{
		Point empty = Point.Empty;
		empty = ((bubbleButton_0 == null || control2_0 == null) ? ((Control)this).PointToClient(Control.get_MousePosition()) : ((Control)control2_0).PointToClient(Control.get_MousePosition()));
		bool flag = false;
		BubbleButton buttonAt = GetButtonAt(empty.X, empty.Y);
		if (bubbleButton_1 != null && buttonAt == null)
		{
			method_11(null);
			flag = true;
		}
		method_43(null);
		if (flag)
		{
			method_1();
		}
		method_13();
		bubbleButton_2 = null;
	}

	private void method_13()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		if (control2_0 != null && bubbleButton_0 != null && timer_0 == null)
		{
			timer_0 = new Timer();
			timer_0.set_Interval(500);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			timer_0.Start();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		Point empty = Point.Empty;
		empty = ((bubbleButton_0 == null || control2_0 == null) ? ((Control)this).PointToClient(Control.get_MousePosition()) : ((Control)control2_0).PointToClient(Control.get_MousePosition()));
		BubbleButton buttonAt = GetButtonAt(empty.X, empty.Y);
		if (buttonAt == null)
		{
			StopBubbleEffect();
			method_14();
		}
	}

	private void method_14()
	{
		Timer val = timer_0;
		timer_0 = null;
		if (val != null)
		{
			val.Stop();
			((Component)(object)val).Dispose();
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		method_16(e);
		((Control)this).OnMouseDown(e);
	}

	internal void method_15(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseDown(mouseEventArgs_0);
	}

	private void method_16(MouseEventArgs mouseEventArgs_0)
	{
		BubbleButton buttonAt = GetButtonAt(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
		if (buttonAt != null)
		{
			method_11(buttonAt);
			method_1();
		}
		else if (rectangle_1.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
		{
			BubbleBarTab tabAt = GetTabAt(new Point(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()));
			if (tabAt != null && tabAt != bubbleBarTab_0)
			{
				method_42(tabAt, eEventSource.Mouse, bool_11: true);
			}
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		method_18(e);
		((Control)this).OnMouseUp(e);
	}

	internal void method_17(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
	}

	private void method_18(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (bubbleButton_1 != null)
		{
			BubbleButton bubbleButton = bubbleButton_1;
			Rectangle displayRectangle = bubbleButton.DisplayRectangle;
			Rectangle magnifiedDisplayRectangle = bubbleButton.MagnifiedDisplayRectangle;
			method_11(null);
			method_10(null);
			bool_4 = true;
			method_1();
			if (displayRectangle.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()) || magnifiedDisplayRectangle.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
			{
				bubbleButton.InvokeClick(eEventSource.Mouse, mouseEventArgs_0.get_Button());
			}
			bubbleButton_2 = bubbleButton;
		}
	}

	private void imageList_1_Disposed(object sender, EventArgs e)
	{
		if (sender == imageList_0)
		{
			Images = null;
		}
		else if (sender == imageList_1)
		{
			ImagesLarge = null;
		}
	}

	internal void method_19(BubbleBarTab bubbleBarTab_3)
	{
		StopBubbleEffect();
		if (((Component)this).DesignMode)
		{
			RecalcLayout();
			((Control)this).Refresh();
		}
	}

	internal void method_20(BubbleBarTab bubbleBarTab_3, BubbleButton bubbleButton_4)
	{
		StopBubbleEffect();
		if (bool_9 && !((Control)this).get_IsDisposed())
		{
			method_21();
		}
		if (((Component)this).DesignMode)
		{
			RecalcLayout();
			((Control)this).Refresh();
		}
	}

	internal void method_21()
	{
		bool_9 = false;
		foreach (BubbleBarTab tab in Tabs)
		{
			foreach (BubbleButton button in tab.Buttons)
			{
				if (button.Shortcut != 0)
				{
					bool_9 = true;
					break;
				}
			}
			if (bool_9)
			{
				break;
			}
		}
	}

	internal void method_22(BubbleBarTab bubbleBarTab_3, BubbleButton bubbleButton_4)
	{
		StopBubbleEffect();
		method_24();
		if (bubbleButton_4.Shortcut != 0)
		{
			bool_9 = true;
		}
		if (((Component)this).DesignMode)
		{
			RecalcLayout();
			((Control)this).Refresh();
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		RecalcLayout();
		method_50();
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		((Control)this).OnHandleDestroyed(e);
		method_51();
		method_14();
	}

	internal void method_23(BubbleButton bubbleButton_4)
	{
		method_24();
	}

	private void method_24()
	{
		if (bubbleBarTab_0 != null)
		{
			if (bubbleBarTab_0.Buttons.Count > 0)
			{
				IBlock[] array = new IBlock[bubbleBarTab_0.Buttons.Count];
				bubbleBarTab_0.Buttons.method_0(array);
				Rectangle rectangle = bubbleContentManager_0.Layout(method_26(), array, bubbleButtonLayoutManager_0);
				if (control2_0 != null)
				{
					rectangle_0.X = rectangle.X;
					rectangle_0.Width = rectangle.Width;
				}
				else
				{
					rectangle_0 = rectangle;
				}
			}
			else
			{
				rectangle_0 = method_26();
				rectangle_0.Inflate(-rectangle_0.Width / 2, 0);
				int bottom = rectangle_0.Bottom;
				rectangle_0.Height = size_1.Height;
				if (eBubbleButtonAlignment_0 == eBubbleButtonAlignment.Bottom)
				{
					rectangle_0.Y = bottom - rectangle_0.Height;
				}
			}
		}
		method_25();
	}

	private void method_25()
	{
		if (!Class109.smethod_11((Control)(object)this))
		{
			return;
		}
		if (bool_6 && bubbleBarTabCollection_0.Count > 0)
		{
			IBlock[] array = new IBlock[bubbleBarTabCollection_0.Count];
			bubbleBarTabCollection_0.method_0(array);
			Graphics val = null;
			try
			{
				val = ((Control)this).CreateGraphics();
				simpleTabLayoutManager_0.Graphics = val;
				rectangle_1 = serialContentLayoutManager_0.Layout(method_28(), array, simpleTabLayoutManager_0);
				return;
			}
			finally
			{
				simpleTabLayoutManager_0.Graphics = null;
				if (val != null)
				{
					val.Dispose();
				}
			}
		}
		rectangle_1 = Rectangle.Empty;
	}

	private Rectangle method_26()
	{
		Rectangle displayRectangle = ((Control)this).get_DisplayRectangle();
		if (control2_0 != null)
		{
			displayRectangle = ((Control)control2_0).get_DisplayRectangle();
		}
		if (eBubbleButtonAlignment_0 == eBubbleButtonAlignment.Bottom)
		{
			displayRectangle.Height -= int_1;
		}
		else if (eBubbleButtonAlignment_0 == eBubbleButtonAlignment.Top)
		{
			displayRectangle.Height -= int_1;
			displayRectangle.Y += int_1;
		}
		return displayRectangle;
	}

	private Rectangle method_27()
	{
		Rectangle result = rectangle_0;
		if (bool_7)
		{
			result.Width = ((Control)this).get_Width();
			result.X = 0;
		}
		else if (rectangle_1.Width + 16 > result.Width)
		{
			int num = rectangle_1.Width + 16 - result.Width;
			result.Width += num;
			result.X -= num / 2;
		}
		result.Height += elementStyle_0.PaddingTop + elementStyle_0.PaddingBottom;
		result.Y -= elementStyle_0.PaddingTop;
		if (!bool_7)
		{
			result.Width += elementStyle_0.PaddingLeft + elementStyle_0.PaddingRight;
			result.X -= elementStyle_0.PaddingLeft;
		}
		return result;
	}

	private Rectangle method_28()
	{
		Rectangle rectangle = method_27();
		Rectangle result = ((eBubbleButtonAlignment_0 != eBubbleButtonAlignment.Bottom) ? new Rectangle(rectangle.X, rectangle.Bottom, rectangle.Width, ((Control)this).get_Height() - rectangle.Bottom) : new Rectangle(rectangle.X, 0, rectangle.Width, rectangle.Y));
		if (result.Height < 0)
		{
			result.Height = 0;
		}
		result.Width -= 16;
		result.X += 8;
		return result;
	}

	private Rectangle method_29()
	{
		Rectangle result = rectangle_1;
		if (!result.IsEmpty)
		{
			result.Width += 16;
			result.X -= 8;
		}
		return result;
	}

	private void method_30(BubbleButton bubbleButton_4, Point point_1, bool bool_11)
	{
		if (int_0 <= 0 || bool_2 || bubbleBarTab_0 == null || !bool_3)
		{
			return;
		}
		bool_2 = true;
		try
		{
			bubbleContentManager_0.MouseOverIndex = bubbleBarTab_0.Buttons.IndexOf(bubbleButton_4);
			bool flag = true;
			int num = size_0.Width - size_1.Width;
			int num2 = 1;
			int num3 = size_1.Width + 1;
			if (!bool_11)
			{
				num3 = size_0.Width - num2;
			}
			Rectangle containerBounds = method_26();
			IBlock[] array = new IBlock[bubbleBarTab_0.Buttons.Count];
			bubbleBarTab_0.Buttons.method_0(array);
			DateTime now = DateTime.Now;
			TimeSpan minValue = TimeSpan.MinValue;
			while (flag)
			{
				DateTime now2 = DateTime.Now;
				float num4 = (float)num3 / (float)size_1.Width;
				Size size = new Size((int)((float)size_1.Width * num4), (int)((float)size_1.Height * num4));
				Class185 @class = method_32(bubbleButton_4.DisplayRectangle, point_1, size);
				bubbleContentManager_0.Factor1 = @class.float_0;
				bubbleContentManager_0.Factor2 = @class.float_1;
				bubbleContentManager_0.Factor3 = @class.float_2;
				bubbleContentManager_0.Factor4 = @class.float_3;
				bubbleContentManager_0.BubbleSize = size;
				bubbleContentManager_0.MouseOverPosition = @class.int_0;
				bubbleContentManager_0.Layout(containerBounds, array, bubbleButtonLayoutManager_0);
				method_1();
				minValue = DateTime.Now.Subtract(now2);
				num2 = (int)((float)num * ((float)minValue.TotalMilliseconds / (float)int_0));
				if (num2 <= 0)
				{
					int num5 = (int)((float)int_0 / Math.Max((float)minValue.TotalMilliseconds, 1f) / (float)num);
					if (num5 <= 0)
					{
						num5 = (int)minValue.TotalMilliseconds;
					}
					Thread.Sleep(num5);
					num2 = 1;
				}
				num3 = ((!bool_11) ? (num3 - num2) : (num3 + num2));
				num -= num2;
				if (num <= 0 || DateTime.Now.Subtract(now).TotalMilliseconds >= (double)int_0)
				{
					break;
				}
			}
		}
		finally
		{
			bool_2 = false;
		}
	}

	private Class185 method_31(Rectangle rectangle_2, Point point_1)
	{
		return method_32(rectangle_2, point_1, size_0);
	}

	private Class185 method_32(Rectangle rectangle_2, Point point_1, Size size_2)
	{
		Class185 @class = new Class185();
		float num = 0f;
		int num2 = 0;
		int num3 = 0;
		int val = Math.Max(point_1.X - rectangle_2.X, 0);
		val = Math.Min(val, rectangle_2.Width);
		int val2 = Math.Max(point_1.Y - rectangle_2.Y, 0);
		val2 = Math.Min(val2, rectangle_2.Height);
		if (eOrientation_0 == eOrientation.Horizontal)
		{
			num = (float)val / (float)rectangle_2.Width;
			num2 = point_1.X - (int)(num * (float)size_2.Width);
		}
		else
		{
			num = (float)val2 / (float)rectangle_2.Height;
			num3 = point_1.Y - (int)(num * (float)size_2.Height);
		}
		@class.int_0 = num2;
		@class.int_1 = num3;
		@class.float_0 = (1f - num) * 0.3f;
		@class.float_1 = Math.Max(1f - num, 0.3f);
		@class.float_2 = Math.Max(num, 0.3f);
		@class.float_3 = num * 0.3f;
		return @class;
	}

	private void method_33()
	{
		serialContentLayoutManager_0.BlockSpacing = 8;
		if (eBubbleButtonAlignment_0 == eBubbleButtonAlignment.Bottom)
		{
			bubbleContentManager_0.ContentAlignment = eContentAlignment.Center;
			bubbleContentManager_0.ContentVerticalAlignment = eContentVerticalAlignment.Bottom;
			bubbleContentManager_0.BlockLineAlignment = eContentVerticalAlignment.Bottom;
			bubbleContentManager_0.ContentOrientation = eContentOrientation.Horizontal;
			serialContentLayoutManager_0.ContentAlignment = eContentAlignment.Center;
			serialContentLayoutManager_0.ContentVerticalAlignment = eContentVerticalAlignment.Bottom;
			serialContentLayoutManager_0.BlockLineAlignment = eContentVerticalAlignment.Bottom;
			serialContentLayoutManager_0.ContentOrientation = eContentOrientation.Horizontal;
		}
		else if (eBubbleButtonAlignment_0 == eBubbleButtonAlignment.Top)
		{
			bubbleContentManager_0.ContentAlignment = eContentAlignment.Center;
			bubbleContentManager_0.ContentVerticalAlignment = eContentVerticalAlignment.Top;
			bubbleContentManager_0.BlockLineAlignment = eContentVerticalAlignment.Top;
			bubbleContentManager_0.ContentOrientation = eContentOrientation.Horizontal;
			serialContentLayoutManager_0.ContentAlignment = eContentAlignment.Center;
			serialContentLayoutManager_0.ContentVerticalAlignment = eContentVerticalAlignment.Top;
			serialContentLayoutManager_0.BlockLineAlignment = eContentVerticalAlignment.Top;
			serialContentLayoutManager_0.ContentOrientation = eContentOrientation.Horizontal;
		}
	}

	internal void method_34(BubbleBarTab bubbleBarTab_3)
	{
		if (bubbleBarTab_0 == bubbleBarTab_3)
		{
			method_41(bubbleBarTab_3, eEventSource.Code, bool_11: false);
		}
		if (((Component)this).DesignMode)
		{
			RecalcLayout();
			((Control)this).Refresh();
		}
	}

	internal void method_35(BubbleBarTab bubbleBarTab_3)
	{
		if (bubbleBarTab_0 == null)
		{
			bubbleBarTab_0 = bubbleBarTab_3;
		}
		method_24();
		if (((Component)this).DesignMode)
		{
			RecalcLayout();
			((Control)this).Refresh();
		}
	}

	internal void method_36()
	{
		bubbleBarTab_0 = null;
		method_24();
		if (((Component)this).DesignMode)
		{
			RecalcLayout();
			((Control)this).Refresh();
		}
	}

	internal void method_37(BubbleBarTab bubbleBarTab_3)
	{
		RecalcLayout();
		((Control)this).Refresh();
	}

	internal void method_38(BubbleBarTab bubbleBarTab_3)
	{
		if (bubbleBarTab_0 == bubbleBarTab_3)
		{
			method_41(bubbleBarTab_3, eEventSource.Code, bool_11: false);
		}
		method_24();
		((Control)this).Refresh();
	}

	private void method_39()
	{
		StopBubbleEffect();
		bubbleButton_2 = null;
		method_24();
		((Control)this).Refresh();
	}

	internal BubbleBarTab method_40()
	{
		return bubbleBarTab_1;
	}

	private void method_41(BubbleBarTab bubbleBarTab_3, eEventSource eEventSource_0, bool bool_11)
	{
		BubbleBarTab bubbleBarTab = bubbleBarTabCollection_0.method_2(bubbleBarTab_3);
		if (bubbleBarTab == null)
		{
			bubbleBarTab = bubbleBarTabCollection_0.method_3(bubbleBarTab_3);
		}
		method_42(bubbleBarTab, eEventSource_0, bool_11);
	}

	private void method_42(BubbleBarTab bubbleBarTab_3, eEventSource eEventSource_0, bool bool_11)
	{
		if (bubbleBarTabChangingEventHadler_0 != null)
		{
			BubbleBarTabChangingEventArgs bubbleBarTabChangingEventArgs = new BubbleBarTabChangingEventArgs();
			bubbleBarTabChangingEventArgs.CurrentTab = bubbleBarTab_0;
			bubbleBarTabChangingEventArgs.NewTab = bubbleBarTab_3;
			bubbleBarTabChangingEventArgs.Source = eEventSource_0;
			bubbleBarTabChangingEventHadler_0(this, bubbleBarTabChangingEventArgs);
			if (bubbleBarTabChangingEventArgs.Cancel && bool_11)
			{
				return;
			}
		}
		bubbleBarTab_0 = bubbleBarTab_3;
		bubbleButton_2 = null;
		method_24();
		method_1();
	}

	internal void method_43(BubbleBarTab bubbleBarTab_3)
	{
		if (bubbleBarTab_1 != bubbleBarTab_3)
		{
			bubbleBarTab_1 = bubbleBarTab_3;
			((Control)this).Invalidate(method_29());
			((Control)this).Update();
		}
	}

	internal void method_44(BubbleBarTab bubbleBarTab_3)
	{
		if (!bool_10)
		{
			bool_10 = true;
			bubbleBarTab_2 = bubbleBarTab_3;
			Cursor.set_Current(Cursors.get_Hand());
		}
	}

	internal void method_45(BubbleButton bubbleButton_4)
	{
		if (!bool_10)
		{
			bool_10 = true;
			bubbleButton_3 = bubbleButton_4;
			Cursor.set_Current(Cursors.get_Hand());
		}
	}

	internal void method_46(Point point_1)
	{
		if (bubbleBarTab_2 != null)
		{
			BubbleBarTab tabAt = GetTabAt(point_1);
			if (tabAt != null && tabAt != bubbleBarTab_2)
			{
				if (int_3 == -1)
				{
					int_3 = Tabs.IndexOf(bubbleBarTab_2);
				}
				int index = Tabs.IndexOf(tabAt);
				Tabs.Remove(bubbleBarTab_2);
				Tabs.Insert(index, bubbleBarTab_2);
				SelectedTab = bubbleBarTab_2;
			}
		}
		else
		{
			if (bubbleButton_3 == null)
			{
				return;
			}
			BubbleBarTab tabAt2 = GetTabAt(point_1);
			if (tabAt2 != null && tabAt2 != bubbleButton_3.Parent)
			{
				if (int_3 == -1)
				{
					int_3 = Tabs.IndexOf(bubbleButton_3.Parent);
				}
				if (int_4 == -1)
				{
					int_4 = bubbleButton_3.Parent.Buttons.IndexOf(bubbleButton_3);
				}
				SelectedTab = tabAt2;
				BubbleButton buttonAt = GetButtonAt(point_1);
				if (bubbleButton_3.Parent != null)
				{
					bubbleButton_3.Parent.Buttons.Remove(bubbleButton_3);
				}
				if (buttonAt != null)
				{
					tabAt2.Buttons.Insert(tabAt2.Buttons.IndexOf(buttonAt), bubbleButton_3);
				}
				else
				{
					tabAt2.Buttons.Add(bubbleButton_3);
				}
				RecalcLayout();
				((Control)this).Refresh();
				return;
			}
			BubbleButton buttonAt2 = GetButtonAt(point_1);
			if (buttonAt2 != null && buttonAt2 != bubbleButton_3)
			{
				if (int_3 == -1)
				{
					int_3 = Tabs.IndexOf(bubbleButton_3.Parent);
				}
				if (int_4 == -1)
				{
					int_4 = bubbleButton_3.Parent.Buttons.IndexOf(bubbleButton_3);
				}
				BubbleBarTab parent = bubbleButton_3.Parent;
				int index2 = parent.Buttons.IndexOf(buttonAt2);
				parent.Buttons.Remove(bubbleButton_3);
				parent.Buttons.Insert(index2, bubbleButton_3);
				RecalcLayout();
				((Control)this).Refresh();
			}
		}
	}

	internal void method_47(Point point_1)
	{
		if (bubbleBarTab_2 != null)
		{
			BubbleBarTab tabAt = GetTabAt(point_1);
			if (tabAt != bubbleBarTab_2)
			{
				method_48();
			}
			else
			{
				bubbleBarTab_2 = null;
				int_3 = -1;
			}
		}
		else if (bubbleButton_3 != null)
		{
			BubbleButton buttonAt = GetButtonAt(point_1);
			if (buttonAt != bubbleButton_3)
			{
				method_48();
			}
			else
			{
				bubbleButton_3 = null;
				int_3 = -1;
				int_4 = -1;
			}
		}
		bool_10 = false;
	}

	internal void method_48()
	{
		if (!bool_10)
		{
			return;
		}
		if (bubbleBarTab_2 != null)
		{
			if (int_3 >= 0)
			{
				Tabs.Remove(bubbleBarTab_2);
				Tabs.Insert(int_3, bubbleBarTab_2);
				RecalcLayout();
				((Control)this).Refresh();
			}
			bubbleBarTab_2 = null;
			int_3 = -1;
		}
		else if (bubbleButton_3 != null && int_4 >= 0)
		{
			if (bubbleButton_3.Parent != null)
			{
				bubbleButton_3.Parent.Buttons.Remove(bubbleButton_3);
			}
			if (int_3 >= 0 && int_3 != Tabs.IndexOf(bubbleButton_3.Parent))
			{
				Tabs[int_3].Buttons.Insert(int_4, bubbleButton_3);
			}
			else
			{
				Tabs[int_3].Buttons.Insert(int_4, bubbleButton_3);
			}
			int_4 = -1;
			int_3 = -1;
			bubbleButton_3 = null;
			RecalcLayout();
			((Control)this).Refresh();
		}
		bool_10 = false;
	}

	void ISupportInitialize.BeginInit()
	{
	}

	void ISupportInitialize.EndInit()
	{
	}

	bool Interface5.imethod_5(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		return false;
	}

	bool Interface5.imethod_2(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		if ((int)Control.get_ModifierKeys() != 0 || (intptr_1.ToInt32() >= 112 && intptr_1.ToInt32() <= 123))
		{
			int eShortcut_ = Control.get_ModifierKeys() | intptr_1.ToInt32();
			if (method_49((eShortcut)eShortcut_))
			{
				return true;
			}
		}
		return false;
	}

	private bool method_49(eShortcut eShortcut_0)
	{
		Form val = ((Control)this).FindForm();
		if (val != null && (((val == Form.get_ActiveForm() || val.get_MdiParent() != null) && (val.get_MdiParent() == null || val.get_MdiParent().get_ActiveMdiChild() == val)) || val.get_IsMdiContainer()) && (Form.get_ActiveForm() == null || !Form.get_ActiveForm().get_Modal() || Form.get_ActiveForm() == val))
		{
			if (bool_9)
			{
				foreach (BubbleBarTab tab in Tabs)
				{
					foreach (BubbleButton button in tab.Buttons)
					{
						if (button.Shortcut == eShortcut_0 && button.Enabled)
						{
							button.InvokeClick(eEventSource.Keyboard, (MouseButtons)0);
							return true;
						}
					}
				}
			}
			return false;
		}
		return false;
	}

	bool Interface5.imethod_3(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		return false;
	}

	bool Interface5.imethod_4(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		return false;
	}

	bool Interface5.imethod_0(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
		if (!((Component)this).DesignMode && ((int)Control.get_ModifierKeys() != 0 || (intptr_1.ToInt32() >= 112 && intptr_1.ToInt32() <= 123)))
		{
			int eShortcut_ = Control.get_ModifierKeys() | intptr_1.ToInt32();
			if (method_49((eShortcut)eShortcut_))
			{
				return true;
			}
		}
		return false;
	}

	bool Interface5.imethod_1(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		return false;
	}

	private void method_50()
	{
		if (!bool_8 && !((Component)this).DesignMode)
		{
			Class107.smethod_0(this);
			bool_8 = true;
		}
	}

	private void method_51()
	{
		if (bool_8)
		{
			Class107.smethod_1(this);
			bool_8 = false;
		}
	}
}
