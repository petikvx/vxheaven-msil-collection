using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar.Controls;

[Designer(typeof(GroupPanelDesigner))]
[ToolboxItem(true)]
[ToolboxBitmap(typeof(GroupPanel), "Controls.GroupPanel.ico")]
public class GroupPanel : PanelControl, INonClientControl
{
	private Class188 class188_0;

	private Image image_0;

	private eTitleImagePosition eTitleImagePosition_0;

	private bool bool_9 = true;

	private bool bool_10;

	private Rectangle rectangle_1 = Rectangle.Empty;

	[Browsable(true)]
	[Description("Indicates image that appears in title with text.")]
	[DefaultValue(null)]
	[Category("Visual")]
	public Image TitleImage
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			RefreshTextClientRectangle();
			((Control)this).Invalidate();
		}
	}

	[DefaultValue(eTitleImagePosition.Left)]
	[Description("Indicates position of the title image.")]
	[Browsable(true)]
	[Category("Visual")]
	public eTitleImagePosition TitleImagePosition
	{
		get
		{
			return eTitleImagePosition_0;
		}
		set
		{
			eTitleImagePosition_0 = value;
			RefreshTextClientRectangle();
			((Control)this).Invalidate();
		}
	}

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public override Color BackColor
	{
		get
		{
			return base.BackColor;
		}
		set
		{
			base.BackColor = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public eScrollBarSkin ScrollbarSkin
	{
		get
		{
			return class188_0.EScrollBarSkin_0;
		}
		set
		{
			class188_0.EScrollBarSkin_0 = value;
		}
	}

	[Description("Specifies whether item is drawn using Themes when running on OS that supports themes like Windows XP.")]
	[Browsable(false)]
	[DefaultValue(false)]
	[Category("Appearance")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool ThemeAware
	{
		get
		{
			return base.ThemeAware;
		}
		set
		{
			base.ThemeAware = value;
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(true)]
	[Description("")]
	public bool DrawTitleBox
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
				InvalidateNonClient();
			}
		}
	}

	[Category("Appearance")]
	[Browsable(false)]
	[DefaultValue(true)]
	[Description("Indicates whether text rectangle painted on panel is considering docked controls inside the panel.")]
	public override bool TextDockConstrained
	{
		get
		{
			return base.TextDockConstrained;
		}
		set
		{
			base.TextDockConstrained = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether panel automatically provides shadows for child controls.")]
	[Category("Appearance")]
	public bool IsShadowEnabled
	{
		get
		{
			return bool_10;
		}
		set
		{
			if (bool_10 != value)
			{
				bool_10 = value;
				((Control)this).Invalidate();
			}
		}
	}

	ElementStyle INonClientControl.BorderStyle => Style;

	IntPtr INonClientControl.Handle => ((Control)this).get_Handle();

	int INonClientControl.Width => ((Control)this).get_Width();

	int INonClientControl.Height => ((Control)this).get_Height();

	bool INonClientControl.IsHandleCreated => ((Control)this).get_IsHandleCreated();

	Color INonClientControl.BackColor => ((Control)this).get_BackColor();

	virtual bool INonClientControl.Enabled
	{
		get
		{
			return ((Control)this).get_Enabled();
		}
		set
		{
			((Control)this).set_Enabled(value);
		}
	}

	public GroupPanel()
	{
		class188_0 = new Class188(this, eScrollBarSkin.Optimized);
		class188_0.Event_0 += method_5;
		class188_0.Event_1 += method_4;
	}

	protected override void Dispose(bool disposing)
	{
		if (class188_0 != null)
		{
			class188_0.method_0();
			class188_0 = null;
		}
		((Control)this).Dispose(disposing);
	}

	public void InvalidateNonClient()
	{
		if (Class109.smethod_11((Control)(object)this))
		{
			Class92.RECT lprcUpdate = new Class92.RECT(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			Class92.RedrawWindow(((Control)this).get_Handle(), ref lprcUpdate, IntPtr.Zero, 1025u);
		}
	}

	protected override void PaintInnerContent(PaintEventArgs e, ElementStyle style, bool paintText)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		if (base.Class261_0 == null)
		{
			RefreshTextClientRectangle();
		}
		Rectangle displayRectangle = ((Control)this).get_DisplayRectangle();
		int x = displayRectangle.X;
		Padding padding = ((Control)this).get_Padding();
		displayRectangle.X = x - ((Padding)(ref padding)).get_Left();
		int y = displayRectangle.Y;
		Padding padding2 = ((Control)this).get_Padding();
		displayRectangle.Y = y - ((Padding)(ref padding2)).get_Top();
		int width = displayRectangle.Width;
		Padding padding3 = ((Control)this).get_Padding();
		displayRectangle.Width = width + ((Padding)(ref padding3)).get_Horizontal();
		int height = displayRectangle.Height;
		Padding padding4 = ((Control)this).get_Padding();
		displayRectangle.Height = height + ((Padding)(ref padding4)).get_Vertical();
		displayRectangle.Inflate(2, 2);
		ElementStyleDisplayInfo elementStyleDisplayInfo = new ElementStyleDisplayInfo(style, graphics, displayRectangle);
		elementStyleDisplayInfo.RightToLeft = (int)((Control)this).get_RightToLeft() == 1;
		ElementStyleDisplay.PaintBackground(elementStyleDisplayInfo, shapeBackground: false);
		if (style.BackgroundImage != null)
		{
			ElementStyleDisplay.PaintBackgroundImage(elementStyleDisplayInfo);
		}
		if (!bool_10)
		{
			return;
		}
		ShadowPaintInfo shadowPaintInfo = new ShadowPaintInfo();
		shadowPaintInfo.Graphics = graphics;
		shadowPaintInfo.Size = 6;
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			if (val.get_Visible() && (!(val.get_BackColor() == Color.Transparent) || val is GroupPanel))
			{
				if (val is GroupPanel)
				{
					GroupPanel groupPanel = val as GroupPanel;
					shadowPaintInfo.Rectangle = new Rectangle(val.get_Bounds().X, val.get_Bounds().Y + groupPanel.method_9().Y / 2, val.get_Bounds().Width, val.get_Bounds().Height - groupPanel.method_9().Y / 2);
				}
				else
				{
					shadowPaintInfo.Rectangle = val.get_Bounds();
				}
				ShadowPainter.Paint2(shadowPaintInfo);
			}
		}
	}

	private void method_4(object sender, EventArgs3 e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Invalid comparison between Unknown and I4
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Invalid comparison between Unknown and I4
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Invalid comparison between Unknown and I4
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Invalid comparison between Unknown and I4
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics_ = e.graphics_0;
		TextRenderingHint textRenderingHint = graphics_.get_TextRenderingHint();
		SmoothingMode smoothingMode = graphics_.get_SmoothingMode();
		if (base.AntiAlias)
		{
			graphics_.set_TextRenderingHint(Class50.TextRenderingHint_0);
			graphics_.set_SmoothingMode((SmoothingMode)4);
		}
		graphics_.ResetClip();
		ElementStyle elementStyle = Style;
		if (!((Control)this).get_Enabled())
		{
			elementStyle = elementStyle.Copy();
			elementStyle.TextColor = GetColorScheme().ItemDisabledText;
		}
		if (bool_9 && !rectangle_1.IsEmpty)
		{
			Class50.smethod_19(graphics_, rectangle_1, 2, elementStyle.BackColor, elementStyle.BackColor2, -90);
			Class50.smethod_9(graphics_, Style.BorderColor, rectangle_1, 2);
		}
		Rectangle bounds = new Rectangle(class188_0.Rectangle_0.X + 4, 1, ((Control)this).get_ClientRectangle().Width - 8, class188_0.Rectangle_0.Y - 1);
		if (image_0 != null)
		{
			Size size = method_6(bounds.Width);
			if ((eTitleImagePosition_0 == eTitleImagePosition.Left && (int)((Control)this).get_RightToLeft() == 0) || (eTitleImagePosition_0 == eTitleImagePosition.Right && (int)((Control)this).get_RightToLeft() == 1))
			{
				graphics_.DrawImage(image_0, bounds.X - 1, bounds.Y, image_0.get_Width(), image_0.get_Height());
				bounds.X += image_0.get_Width();
				bounds.Width -= image_0.get_Width();
			}
			else if ((eTitleImagePosition_0 == eTitleImagePosition.Right && (int)((Control)this).get_RightToLeft() == 0) || (eTitleImagePosition_0 == eTitleImagePosition.Left && (int)((Control)this).get_RightToLeft() == 1))
			{
				graphics_.DrawImage(image_0, bounds.Right - image_0.get_Width(), bounds.Y, image_0.get_Width(), image_0.get_Height());
				bounds.Width -= image_0.get_Width();
			}
			else if (eTitleImagePosition_0 == eTitleImagePosition.Center)
			{
				graphics_.DrawImage(image_0, bounds.X + (bounds.Width - image_0.get_Width()) / 2, bounds.Y, image_0.get_Width(), image_0.get_Height());
			}
			bounds.Y = bounds.Bottom - size.Height - 2;
		}
		if (base.Class261_0 == null)
		{
			ElementStyleDisplayInfo elementStyleDisplayInfo = new ElementStyleDisplayInfo(elementStyle, graphics_, bounds);
			elementStyleDisplayInfo.RightToLeft = (int)((Control)this).get_RightToLeft() == 1;
			ElementStyleDisplay.PaintText(elementStyleDisplayInfo, ((Control)this).get_Text(), ((Control)this).get_Font());
		}
		else
		{
			TextRenderingHint textRenderingHint2 = graphics_.get_TextRenderingHint();
			if (base.AntiAlias)
			{
				graphics_.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
			Class263 d = new Class263(graphics_, ((Control)this).get_Font(), elementStyle.TextColor, (int)((Control)this).get_RightToLeft() == 1, Rectangle.Empty, hotKeyPrefixVisible: true);
			Rectangle bounds2 = base.Class261_0.Bounds;
			if (elementStyle.TextAlignment == eStyleTextAlignment.Center)
			{
				base.Class261_0.Bounds = new Rectangle(base.Class261_0.Bounds.X + (bounds.Width - base.Class261_0.Bounds.Width) / 2, base.Class261_0.Bounds.Y, base.Class261_0.Bounds.Width, base.Class261_0.Bounds.Height);
			}
			else if ((elementStyle.TextAlignment == eStyleTextAlignment.Far && (int)((Control)this).get_RightToLeft() == 0) || ((int)((Control)this).get_RightToLeft() == 1 && elementStyle.TextAlignment == eStyleTextAlignment.Near))
			{
				base.Class261_0.Bounds = new Rectangle(bounds.Right - base.Class261_0.Bounds.Width, base.Class261_0.Bounds.Y, base.Class261_0.Bounds.Width, base.Class261_0.Bounds.Height);
			}
			base.Class261_0.Render(d);
			graphics_.set_TextRenderingHint(textRenderingHint2);
			base.Class261_0.Bounds = bounds2;
		}
		graphics_.set_TextRenderingHint(textRenderingHint);
		graphics_.set_SmoothingMode(smoothingMode);
	}

	private void method_5(object sender, EventArgs3 e)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Invalid comparison between Unknown and I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Invalid comparison between Unknown and I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Invalid comparison between Unknown and I4
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		rectangle_1 = Rectangle.Empty;
		if (((Control)this).get_Text() != null && ((Control)this).get_Text().Length > 0)
		{
			Rectangle rectangle = new Rectangle(width: method_6(((Control)this).get_ClientRectangle().Width - 8).Width, x: class188_0.Rectangle_0.X + 3, y: 0, height: class188_0.Rectangle_0.Y);
			Size size = new Size(class188_0.Rectangle_0.Width - 8, class188_0.Rectangle_0.Y);
			if (image_0 != null && ((eTitleImagePosition_0 == eTitleImagePosition.Left && (int)((Control)this).get_RightToLeft() == 1) || (eTitleImagePosition_0 == eTitleImagePosition.Right && (int)((Control)this).get_RightToLeft() == 0)))
			{
				size.Width -= image_0.get_Width();
			}
			else if (image_0 != null && ((eTitleImagePosition_0 == eTitleImagePosition.Right && (int)((Control)this).get_RightToLeft() == 1) || (eTitleImagePosition_0 == eTitleImagePosition.Left && (int)((Control)this).get_RightToLeft() == 0)))
			{
				rectangle.X += image_0.get_Width();
				size.Width -= image_0.get_Width();
			}
			if (Style.TextAlignment == eStyleTextAlignment.Center)
			{
				rectangle.X += (size.Width - rectangle.Width) / 2;
			}
			else if (Style.TextAlignment == eStyleTextAlignment.Far || ((int)((Control)this).get_RightToLeft() == 1 && Style.TextAlignment == eStyleTextAlignment.Near))
			{
				rectangle.X += size.Width - rectangle.Width;
			}
			e.graphics_0.SetClip(rectangle, (CombineMode)4);
			rectangle_1 = rectangle;
		}
		if (image_0 != null)
		{
			Rectangle rectangle2 = new Rectangle(class188_0.Rectangle_0.X + 3, 0, image_0.get_Width(), image_0.get_Height());
			if ((eTitleImagePosition_0 == eTitleImagePosition.Left && (int)((Control)this).get_RightToLeft() == 1) || (eTitleImagePosition_0 == eTitleImagePosition.Right && (int)((Control)this).get_RightToLeft() == 0))
			{
				rectangle2.X = class188_0.Rectangle_0.Right - rectangle2.Width - 4;
			}
			else if (eTitleImagePosition_0 == eTitleImagePosition.Center)
			{
				rectangle2.X = class188_0.Rectangle_0.X;
				rectangle2.X += (class188_0.Rectangle_0.Width - rectangle2.Width) / 2;
			}
			e.graphics_0.SetClip(rectangle2, (CombineMode)4);
			if (rectangle_1.IsEmpty)
			{
				rectangle_1 = rectangle2;
			}
			else
			{
				rectangle_1 = Rectangle.Union(rectangle2, rectangle_1);
			}
		}
		if (!rectangle_1.IsEmpty)
		{
			rectangle_1.Inflate(2, 0);
			rectangle_1.Width += 3;
		}
	}

	private Size method_6(int int_1)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		Size result = Size.Empty;
		if (base.Class261_0 != null)
		{
			result = ((int_1 != 0) ? method_7(int_1) : base.Class261_0.Bounds.Size);
			result.Width += 4;
			result.Height += 6;
		}
		else if (((Control)this).get_Text().Length > 0)
		{
			Font font = ((Control)this).get_Font();
			if (Style.Font != null)
			{
				font = Style.Font;
			}
			eTextFormat eTextFormat_ = eTextFormat.SingleLine;
			Graphics val = Class109.smethod_68((Control)(object)this);
			try
			{
				if (base.AntiAlias)
				{
					val.set_TextRenderingHint(Class50.TextRenderingHint_0);
					val.set_SmoothingMode((SmoothingMode)4);
				}
				result = ((int_1 > 0) ? Class55.smethod_4(val, ((Control)this).get_Text(), font, int_1, eTextFormat_) : Class55.smethod_4(val, ((Control)this).get_Text(), font, 0, eTextFormat_));
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			result.Width += 2;
			result.Height += 2;
		}
		if (result.IsEmpty)
		{
			return result;
		}
		result.Width += Style.MarginLeft + Style.MarginRight;
		result.Height += Style.MarginTop + Style.MarginBottom;
		return result;
	}

	private Size method_7(int int_1)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		Size empty = Size.Empty;
		if (base.Class261_0 != null)
		{
			Rectangle rectangle = new Rectangle(0, 0, int_1, 500);
			rectangle.Inflate(-2, -2);
			Graphics val = ((Control)this).CreateGraphics();
			Class261 @class = Class243.smethod_0(((Control)this).get_Text());
			try
			{
				if (base.AntiAlias)
				{
					val.set_SmoothingMode((SmoothingMode)4);
					val.set_TextRenderingHint(Class50.TextRenderingHint_0);
				}
				Class263 d = new Class263(val, ((Control)this).get_Font(), SystemColors.Control, (int)((Control)this).get_RightToLeft() == 1);
				@class.Measure(rectangle.Size, d);
				return @class.Bounds.Size;
			}
			finally
			{
				val.Dispose();
			}
		}
		return empty;
	}

	protected override void RefreshTextClientRectangle()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		if (class188_0 != null)
		{
			Rectangle clientTextRectangle = new Rectangle(class188_0.Rectangle_0.X, 0, class188_0.Rectangle_0.Width, ((Control)this).get_Height() / 2);
			clientTextRectangle.Inflate(-2, 0);
			if (image_0 != null)
			{
				if ((eTitleImagePosition_0 == eTitleImagePosition.Left && (int)((Control)this).get_RightToLeft() == 0) || (eTitleImagePosition_0 == eTitleImagePosition.Right && (int)((Control)this).get_RightToLeft() == 1))
				{
					clientTextRectangle.X += image_0.get_Width();
					clientTextRectangle.Width -= image_0.get_Width();
				}
				else if ((eTitleImagePosition_0 == eTitleImagePosition.Left && (int)((Control)this).get_RightToLeft() == 1) || (eTitleImagePosition_0 == eTitleImagePosition.Right && (int)((Control)this).get_RightToLeft() == 0))
				{
					clientTextRectangle.Width -= image_0.get_Width();
				}
				Size size = method_7(clientTextRectangle.Width);
				clientTextRectangle.Y = Math.Max(0, class188_0.Rectangle_0.Y - size.Height - 4);
			}
			base.ClientTextRectangle = clientTextRectangle;
		}
		else
		{
			base.ClientTextRectangle = ((Control)this).get_ClientRectangle();
		}
		ResizeMarkup();
	}

	protected override void WndProc(ref Message m)
	{
		if (class188_0 == null)
		{
			base.WndProc(ref m);
			return;
		}
		if (((Message)(ref m)).get_Msg() != 276 && ((Message)(ref m)).get_Msg() != 277 && ((Message)(ref m)).get_Msg() != 522)
		{
			if (class188_0.WndProc(ref m))
			{
				BaseWndProc(ref m);
			}
			return;
		}
		if (class188_0.WndProc(ref m))
		{
			BaseWndProc(ref m);
		}
		RefreshTextClientRectangle();
	}

	void INonClientControl.BaseWndProc(ref Message m)
	{
		BaseWndProc(ref m);
	}

	public virtual BaseRenderer GetRenderer()
	{
		if (GlobalManager.Renderer != null)
		{
			return GlobalManager.Renderer;
		}
		return null;
	}

	ItemPaintArgs INonClientControl.GetItemPaintArgs(Graphics g)
	{
		ItemPaintArgs itemPaintArgs = new ItemPaintArgs(this as IOwner, (Control)(object)this, g, GetColorScheme());
		itemPaintArgs.BaseRenderer_0 = GetRenderer();
		itemPaintArgs.DesignerSelection = false;
		itemPaintArgs.GlassEnabled = !((Component)(object)this).DesignMode && Class51.Boolean_0;
		return itemPaintArgs;
	}

	void INonClientControl.PaintBackground(PaintEventArgs e)
	{
		((ScrollableControl)this).OnPaintBackground(e);
	}

	Point INonClientControl.PointToScreen(Point client)
	{
		return ((Control)this).PointToScreen(client);
	}

	void INonClientControl.RenderNonClient(Graphics g)
	{
	}

	void INonClientControl.AdjustClientRectangle(ref Rectangle r)
	{
		Size size = method_6(r.Width);
		if (image_0 != null)
		{
			size.Height = Math.Max(image_0.get_Height(), size.Height);
		}
		if (size.Height > r.Height)
		{
			size.Height = r.Height - 8;
		}
		r.Y += size.Height;
		r.Height -= size.Height;
	}

	void INonClientControl.AdjustBorderRectangle(ref Rectangle r)
	{
		if (((Control)this).get_Text() != "")
		{
			int num = method_8();
			r.Y += num;
			r.Height -= num;
		}
	}

	private int method_8()
	{
		Font font = ((Control)this).get_Font();
		if (Style.Font != null)
		{
			font = Style.Font;
		}
		int num = (int)((float)font.get_Height() * 0.7f);
		if (image_0 != null)
		{
			num = Math.Max(image_0.get_Height() - (font.get_Height() - num - 1), num);
		}
		return num;
	}

	internal Rectangle method_9()
	{
		return class188_0.Rectangle_0;
	}

	public void SetDefaultPanelStyle()
	{
		CanvasColor = SystemColors.Control;
		ResetStyle();
		ColorSchemeStyle = eDotNetBarStyle.Office2007;
		Style.BackColor2SchemePart = eColorSchemePart.PanelBackground2;
		Style.BackColorGradientAngle = 90;
		Style.BackColorSchemePart = eColorSchemePart.PanelBackground;
		Style.Border = eStyleBorderType.Solid;
		Style.BorderWidth = 1;
		Style.BorderColorSchemePart = eColorSchemePart.PanelBorder;
		Style.CornerDiameter = 4;
		Style.CornerType = eCornerType.Rounded;
		Style.TextAlignment = eStyleTextAlignment.Center;
		Style.TextColorSchemePart = eColorSchemePart.PanelText;
		Style.TextLineAlignment = eStyleTextAlignment.Near;
	}
}
