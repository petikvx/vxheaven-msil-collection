using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[Designer(typeof(PanelControlDesigner))]
[DefaultEvent("Click")]
public class PanelControl : Panel, IButtonControl
{
	private ElementStyle elementStyle_0;

	private ElementStyle elementStyle_1;

	private ElementStyle elementStyle_2;

	private ColorScheme colorScheme_0;

	private eDotNetBarStyle eDotNetBarStyle_0 = eDotNetBarStyle.Office2003;

	private bool bool_0;

	private bool bool_1;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private bool bool_2 = true;

	private bool bool_3;

	private string string_0 = "";

	private Class59 class59_0;

	private DialogResult dialogResult_0;

	private bool bool_4;

	private bool bool_5 = true;

	private Color color_0 = Color.White;

	protected Bitmap m_ThemeCachedBitmap;

	private bool bool_6;

	private Class261 class261_0;

	private MarkupLinkClickEventHandler markupLinkClickEventHandler_0;

	private eCornerType eCornerType_0 = eCornerType.Square;

	private int int_0 = 8;

	private bool bool_7;

	internal bool bool_8;

	internal Class261 Class261_0 => class261_0;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public BorderStyle BorderStyle
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Panel)this).get_BorderStyle();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Panel)this).set_BorderStyle(value);
		}
	}

	[Description("Gets or sets Bar Color Scheme.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[Category("Appearance")]
	[DevCoBrowsable(false)]
	public ColorScheme ColorScheme
	{
		get
		{
			return colorScheme_0;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentException("NULL is not a valid value for this property.");
			}
			colorScheme_0 = value;
			OnColorSchemeChanged();
			if (((Control)this).get_Visible())
			{
				((Control)this).Invalidate();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Category("Appearance")]
	[Description("Gets or sets the text displayed on panel.")]
	public override string Text
	{
		get
		{
			return string_0;
		}
		set
		{
			if (value.Length >= 0)
			{
				((Panel)this).set_Text(value);
				string_0 = value;
				((Control)this).OnTextChanged(new EventArgs());
				((Control)this).Invalidate();
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Indicates whether focus rectangle is displayed when control has focus.")]
	[Category("Appearance")]
	public bool ShowFocusRectangle
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			if (((Component)this).DesignMode)
			{
				((Control)this).Invalidate();
			}
		}
	}

	[Category("Background")]
	[Description("Gets or sets the canvas color.")]
	[Browsable(true)]
	public Color CanvasColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			if (((Component)this).DesignMode)
			{
				((Control)this).Invalidate();
			}
		}
	}

	[Category("Style")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Indicates panel style.")]
	[DevCoBrowsable(true)]
	public virtual ElementStyle Style => elementStyle_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(true)]
	[Description("Gets or sets the panel style when mouse hovers over the panel.")]
	[Category("Style")]
	[NotifyParentProperty(true)]
	[Browsable(true)]
	public ElementStyle StyleMouseOver => elementStyle_1;

	[Category("Style")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets or sets the panel style when mouse button is pressed on the panel.")]
	[NotifyParentProperty(true)]
	[DevCoBrowsable(true)]
	public ElementStyle StyleMouseDown => elementStyle_2;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override Color BackColor
	{
		get
		{
			return ((Control)this).get_BackColor();
		}
		set
		{
			((Control)this).set_BackColor(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override Image BackgroundImage
	{
		get
		{
			return ((Control)this).get_BackgroundImage();
		}
		set
		{
			((Control)this).set_BackgroundImage(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override Color ForeColor
	{
		get
		{
			return ((Control)this).get_ForeColor();
		}
		set
		{
			((Control)this).set_ForeColor(value);
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(true)]
	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	public bool AntiAlias
	{
		get
		{
			return bool_5;
		}
		set
		{
			if (bool_5 != value)
			{
				bool_5 = value;
				((Control)this).Invalidate();
			}
		}
	}

	[Category("Style")]
	[Browsable(true)]
	[Description("Gets or sets color scheme style.")]
	[DefaultValue(eDotNetBarStyle.Office2003)]
	[DevCoBrowsable(true)]
	public eDotNetBarStyle ColorSchemeStyle
	{
		get
		{
			return eDotNetBarStyle_0;
		}
		set
		{
			eDotNetBarStyle_0 = value;
			colorScheme_0 = new ColorScheme(eDotNetBarStyle_0);
			OnColorSchemeChanged();
			if (((Component)this).DesignMode)
			{
				((Control)this).Invalidate();
			}
		}
	}

	[DefaultValue(true)]
	[Category("Appearance")]
	[Description("Indicates whether text rectangle painted on panel is considering docked controls inside the panel.")]
	public virtual bool TextDockConstrained
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			if (((Component)this).DesignMode)
			{
				((Control)this).Invalidate();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Rectangle ClientTextRectangle
	{
		get
		{
			return rectangle_0;
		}
		set
		{
			rectangle_0 = value;
		}
	}

	protected virtual bool SuspendPaint
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Description("Gets or sets the value returned to the parent form when the button is clicked.")]
	[Category("Behavior")]
	[Browsable(true)]
	public DialogResult DialogResult
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return dialogResult_0;
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			if (Enum.IsDefined(typeof(DialogResult), value))
			{
				dialogResult_0 = value;
			}
		}
	}

	[Category("Appearance")]
	[Description("Specifies whether item is drawn using Themes when running on OS that supports themes like Windows XP.")]
	[Browsable(true)]
	[DefaultValue(false)]
	[DevCoBrowsable(true)]
	public virtual bool ThemeAware
	{
		get
		{
			return bool_8;
		}
		set
		{
			DisposeThemeCachedBitmap();
			bool_8 = value;
			((Control)this).Invalidate();
		}
	}

	internal Class59 Class59_0
	{
		get
		{
			if (class59_0 == null)
			{
				class59_0 = new Class59((Control)(object)this);
			}
			return class59_0;
		}
	}

	public event MarkupLinkClickEventHandler MarkupLinkClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Combine(markupLinkClickEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Remove(markupLinkClickEventHandler_0, value);
		}
	}

	public PanelControl()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
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
		((Control)this).SetStyle((ControlStyles)1, true);
		((Control)this).SetStyle((ControlStyles)512, true);
		((Control)this).SetStyle((ControlStyles)4096, false);
		colorScheme_0 = new ColorScheme(eDotNetBarStyle_0);
		ResetStyle();
		ResetStyleMouseOver();
		ResetStyleMouseDown();
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeColorScheme()
	{
		return colorScheme_0.SchemeChanged;
	}

	internal ColorScheme GetColorScheme()
	{
		if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007 && GlobalManager.Renderer is Office2007Renderer office2007Renderer && office2007Renderer.ColorTable.LegacyColors != null)
		{
			return office2007Renderer.ColorTable.LegacyColors;
		}
		return colorScheme_0;
	}

	private void elementStyle_2_StyleChanged(object sender, EventArgs e)
	{
		RefreshStyleSystemColors();
		SetRegion();
		((Control)this).Invalidate();
	}

	protected override void OnRightToLeftChanged(EventArgs e)
	{
		((Control)this).Invalidate();
		((ScrollableControl)this).OnRightToLeftChanged(e);
	}

	protected virtual void SetRegion()
	{
		method_0(bool_9: false);
	}

	private void method_0(bool bool_9)
	{
		ElementStyle style = GetStyle();
		if (bool_9 || eCornerType_0 != style.CornerType || int_0 != style.CornerDiameter)
		{
			eCornerType_0 = style.CornerType;
			int_0 = style.CornerDiameter;
			if (style != null && (!bool_8 || !Class109.Boolean_0) && style.CornerType != eCornerType.Square)
			{
				((Control)this).set_Region(ElementStyleDisplay.GetStyleRegion(new ElementStyleDisplayInfo(style, null, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()))));
			}
			else
			{
				((Control)this).set_Region((Region)null);
			}
		}
	}

	public void RefreshStyleSystemColors()
	{
		ColorScheme colorScheme = GetColorScheme();
		if (elementStyle_0 != null)
		{
			elementStyle_0.method_4(colorScheme);
		}
		if (elementStyle_1 != null)
		{
			elementStyle_1.method_4(colorScheme);
		}
		if (elementStyle_2 != null)
		{
			elementStyle_2.method_4(colorScheme);
		}
	}

	protected override void WndProc(ref Message m)
	{
		switch (((Message)(ref m)).get_Msg())
		{
		case 276:
		case 277:
		case 522:
			if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() == 0)
			{
				((Control)this).Invalidate();
			}
			break;
		}
		((ScrollableControl)this).WndProc(ref m);
	}

	protected virtual void BaseWndProc(ref Message m)
	{
		((ScrollableControl)this).WndProc(ref m);
	}

	protected virtual ElementStyle GetStyle()
	{
		return elementStyle_0;
	}

	protected virtual ElementStyle GetStyleMouseDown()
	{
		return elementStyle_2;
	}

	protected virtual ElementStyle GetStyleMouseOver()
	{
		return elementStyle_1;
	}

	protected virtual void PaintThemed(PaintEventArgs e)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		if (m_ThemeCachedBitmap != null && !(((Image)m_ThemeCachedBitmap).get_Size() != ((Control)this).get_ClientRectangle().Size))
		{
			e.get_Graphics().DrawImage((Image)(object)m_ThemeCachedBitmap, 0, 0, ((Image)m_ThemeCachedBitmap).get_Width(), ((Image)m_ThemeCachedBitmap).get_Height());
			return;
		}
		DisposeThemeCachedBitmap();
		Bitmap val = new Bitmap(((Control)this).get_ClientRectangle().Width, ((Control)this).get_ClientRectangle().Height, e.get_Graphics());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			Class59_0.method_0(val2, Class119.class119_8, Class144.class144_2, new Rectangle(0, 0, ((Image)val).get_Width(), ((Image)val).get_Height()));
		}
		finally
		{
			val2.Dispose();
		}
		e.get_Graphics().DrawImage((Image)(object)val, 0, 0, ((Image)val).get_Width(), ((Image)val).get_Height());
		ElementStyle style = GetStyle();
		if (style.BackgroundImage != null)
		{
			Class109.smethod_62(e.get_Graphics(), ((Control)this).get_ClientRectangle(), style.BackgroundImage, style.BackgroundImagePosition, style.BackgroundImageAlpha);
		}
		m_ThemeCachedBitmap = val;
	}

	protected virtual void PaintPrepare(PaintEventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		SolidBrush val = new SolidBrush(color_0);
		try
		{
			e.get_Graphics().FillRectangle((Brush)(object)val, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		ElementStyle style = GetStyle();
		if ((style.BackColor.IsEmpty || style.BackColor.A < byte.MaxValue) && (style.BackColor2.IsEmpty || style.BackColor2.A < byte.MaxValue))
		{
			((ScrollableControl)this).OnPaintBackground(e);
		}
		if (bool_5)
		{
			e.get_Graphics().set_SmoothingMode((SmoothingMode)4);
			e.get_Graphics().set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
	}

	protected virtual void PaintStyled(PaintEventArgs e)
	{
		Graphics graphics = e.get_Graphics();
		ElementStyle elementStyle = GetStyle().Copy();
		if (bool_1 && ((Control)this).get_Enabled())
		{
			elementStyle.ApplyStyle(GetStyleMouseDown());
		}
		else if (bool_0 && ((Control)this).get_Enabled())
		{
			elementStyle.ApplyStyle(GetStyleMouseOver());
		}
		PaintInnerContent(e, elementStyle, paintText: true);
		if (((Control)this).get_Focused() && bool_3)
		{
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			clientRectangle.Inflate(-2, -2);
			if (clientRectangle.Width > 0 && clientRectangle.Height > 0)
			{
				ControlPaint.DrawFocusRectangle(graphics, clientRectangle);
			}
		}
	}

	protected virtual void PaintInnerContent(PaintEventArgs e, ElementStyle style, bool paintText)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		Graphics graphics = e.get_Graphics();
		if (class261_0 == null)
		{
			RefreshTextClientRectangle();
		}
		Rectangle bounds = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		Rectangle bounds2 = rectangle_0;
		bounds2.Inflate(-1, -1);
		if (!((Control)this).get_Enabled())
		{
			style.TextColor = GetColorScheme().ItemDisabledText;
		}
		ElementStyleDisplayInfo elementStyleDisplayInfo = new ElementStyleDisplayInfo(style, graphics, bounds);
		elementStyleDisplayInfo.RightToLeft = (int)((Control)this).get_RightToLeft() == 1;
		ElementStyleDisplay.Paint(elementStyleDisplayInfo);
		if (paintText)
		{
			if (class261_0 == null)
			{
				elementStyleDisplayInfo.Bounds = bounds2;
				ElementStyleDisplay.PaintText(elementStyleDisplayInfo, ((Control)this).get_Text(), ((Control)this).get_Font());
			}
			else
			{
				Class263 d = new Class263(graphics, ((Control)this).get_Font(), style.TextColor, (int)((Control)this).get_RightToLeft() == 1, e.get_ClipRectangle(), hotKeyPrefixVisible: true);
				class261_0.Render(d);
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (bool_6 || bool_7)
		{
			return;
		}
		bool_7 = true;
		try
		{
			SmoothingMode smoothingMode = e.get_Graphics().get_SmoothingMode();
			TextRenderingHint textRenderingHint = e.get_Graphics().get_TextRenderingHint();
			PaintPrepare(e);
			if (bool_8 && Class109.Boolean_0)
			{
				PaintThemed(e);
			}
			else
			{
				PaintStyled(e);
			}
			e.get_Graphics().set_SmoothingMode(smoothingMode);
			e.get_Graphics().set_TextRenderingHint(textRenderingHint);
			((Control)this).OnPaint(e);
		}
		finally
		{
			bool_7 = false;
		}
	}

	protected override void OnResize(EventArgs e)
	{
		((Panel)this).OnResize(e);
		RefreshTextClientRectangle();
		method_0(bool_9: true);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		method_0(bool_9: true);
	}

	protected override void NotifyInvalidate(Rectangle invalidatedArea)
	{
		((Control)this).NotifyInvalidate(invalidatedArea);
		method_0(bool_9: true);
	}

	protected override void OnChangeUICues(UICuesEventArgs e)
	{
		if (bool_3 && e.get_ChangeFocus())
		{
			((Control)this).Invalidate();
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (class261_0 != null)
		{
			class261_0.method_5((Control)(object)this, e);
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		if (class261_0 != null)
		{
			class261_0.method_6((Control)(object)this, e);
		}
		if ((int)e.get_Button() == 1048576 && !bool_1)
		{
			bool_1 = true;
			if (GetStyleMouseDown().Custom)
			{
				((Control)this).Invalidate(false);
			}
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (class261_0 != null)
		{
			class261_0.method_7((Control)(object)this, e);
		}
		((Control)this).OnMouseUp(e);
		if (bool_1)
		{
			bool_1 = false;
			if (GetStyleMouseDown().Custom)
			{
				((Control)this).Invalidate(false);
			}
		}
	}

	protected override void OnClick(EventArgs e)
	{
		if (class261_0 != null)
		{
			class261_0.method_8((Control)(object)this);
		}
		((Control)this).OnClick(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		if (!bool_0)
		{
			bool_0 = true;
			if (GetStyleMouseOver().Custom)
			{
				((Control)this).Invalidate(false);
			}
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		if (class261_0 != null)
		{
			class261_0.method_4((Control)(object)this);
		}
		((Control)this).OnMouseLeave(e);
		if (bool_0)
		{
			bool_0 = false;
			if (GetStyleMouseOver().Custom)
			{
				((Control)this).Invalidate(false);
			}
		}
	}

	protected override void OnFontChanged(EventArgs e)
	{
		((Control)this).OnFontChanged(e);
		if (class261_0 != null)
		{
			class261_0.method_0();
		}
		RefreshTextClientRectangle();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		string string_ = ((Control)this).get_Text();
		if (class261_0 != null)
		{
			class261_0.method_4((Control)(object)this);
			class261_0.Event_0 -= method_1;
			class261_0 = null;
		}
		if (Class243.smethod_2(ref string_))
		{
			class261_0 = Class243.smethod_0(string_);
		}
		if (class261_0 != null)
		{
			class261_0.Event_0 += method_1;
			RefreshTextClientRectangle();
		}
		((Control)this).OnTextChanged(e);
	}

	private void method_1(object sender, EventArgs e)
	{
		if (sender is Class262 @class)
		{
			OnMarkupLinkClick(new MarkupLinkClickEventArgs(@class.String_1, @class.String_0));
		}
	}

	protected virtual void OnMarkupLinkClick(MarkupLinkClickEventArgs e)
	{
		if (markupLinkClickEventHandler_0 != null)
		{
			markupLinkClickEventHandler_0(this, e);
		}
	}

	protected virtual void ResizeMarkup()
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Invalid comparison between Unknown and I4
		if (class261_0 == null)
		{
			return;
		}
		Rectangle clientTextRectangle = ClientTextRectangle;
		clientTextRectangle.Inflate(-2, 0);
		clientTextRectangle.X += Class52.smethod_3(Style);
		clientTextRectangle.Width -= Class52.smethod_1(Style);
		clientTextRectangle.Y += Class52.smethod_7(Style);
		clientTextRectangle.Height -= Class52.smethod_2(Style);
		if (clientTextRectangle.Width <= 0 || clientTextRectangle.Height <= 0)
		{
			return;
		}
		Graphics val = ((Control)this).CreateGraphics();
		try
		{
			if (bool_5)
			{
				val.set_SmoothingMode((SmoothingMode)4);
				val.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
			Class263 @class = new Class263(val, ((Control)this).get_Font(), SystemColors.Control, (int)((Control)this).get_RightToLeft() == 1);
			class261_0.Measure(clientTextRectangle.Size, @class);
			class261_0.method_2(clientTextRectangle, @class);
			if (((ScrollableControl)this).get_AutoScroll())
			{
				Size empty = Size.Empty;
				if (class261_0.Bounds.Height > clientTextRectangle.Height)
				{
					empty.Height = class261_0.Bounds.Height + elementStyle_0.MarginTop + elementStyle_0.MarginBottom + 2;
				}
				if (class261_0.Bounds.Width > clientTextRectangle.Width)
				{
					empty.Width = class261_0.Bounds.Width + elementStyle_0.MarginLeft + elementStyle_0.MarginRight + 2;
				}
				if (((ScrollableControl)this).get_AutoScrollMinSize() != empty)
				{
					((ScrollableControl)this).set_AutoScrollMinSize(empty);
				}
			}
			else if (!((ScrollableControl)this).get_AutoScrollMinSize().IsEmpty)
			{
				((ScrollableControl)this).set_AutoScrollMinSize(Size.Empty);
			}
		}
		finally
		{
			val.Dispose();
		}
	}

	protected override void OnSystemColorsChanged(EventArgs e)
	{
		((Control)this).OnSystemColorsChanged(e);
		Application.DoEvents();
		colorScheme_0.Refresh(null, bSystemColorEvent: true);
		RefreshStyleSystemColors();
		if (class59_0 != null)
		{
			method_2();
		}
		((Control)this).Invalidate(true);
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_3();
	}

	protected override bool ProcessMnemonic(char charCode)
	{
		if (Control.IsMnemonic(charCode, ((Control)this).get_Text()))
		{
			((Control)this).OnClick(new EventArgs());
			return true;
		}
		return ((Control)this).ProcessMnemonic(charCode);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeCanvasColor()
	{
		return color_0 != Color.White;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetCanvasColor()
	{
		color_0 = Color.White;
	}

	public void ResetStyle()
	{
		if (elementStyle_0 == null)
		{
			elementStyle_0 = new ElementStyle();
			elementStyle_0.method_4(GetColorScheme());
			elementStyle_0.StyleChanged += elementStyle_2_StyleChanged;
		}
		else
		{
			elementStyle_0.Reset();
		}
		RefreshStyleSystemColors();
		((Control)this).Invalidate();
	}

	public void ResetMouseTracking()
	{
		bool_0 = false;
		bool_1 = false;
		((Control)this).Invalidate();
	}

	public void ResetStyleMouseOver()
	{
		if (elementStyle_1 == null)
		{
			elementStyle_1 = new ElementStyle();
			elementStyle_1.method_4(GetColorScheme());
			elementStyle_1.StyleChanged += elementStyle_2_StyleChanged;
		}
		else
		{
			elementStyle_1.Reset();
		}
		((Control)this).Invalidate();
	}

	public void ResetStyleMouseDown()
	{
		if (elementStyle_2 == null)
		{
			elementStyle_2 = new ElementStyle();
			elementStyle_2.method_4(GetColorScheme());
			elementStyle_2.StyleChanged += elementStyle_2_StyleChanged;
		}
		else
		{
			elementStyle_2.Reset();
		}
		((Control)this).Invalidate();
	}

	protected virtual void OnColorSchemeChanged()
	{
		RefreshStyleSystemColors();
	}

	protected virtual void RefreshTextClientRectangle()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected I4, but got Unknown
		Rectangle rectangle = ((Control)this).get_DisplayRectangle();
		if (!bool_2)
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			if ((int)val.get_Dock() != 0)
			{
				if ((int)val.get_Dock() == 5)
				{
					rectangle = Rectangle.Empty;
					break;
				}
				DockStyle dock = val.get_Dock();
				switch (dock - 1)
				{
				case 0:
					rectangle.Y += val.get_Height();
					rectangle.Height -= val.get_Height();
					break;
				case 1:
					rectangle.Height -= val.get_Height();
					break;
				case 2:
					rectangle.X += val.get_Width();
					rectangle.Width -= val.get_Width();
					break;
				case 3:
					rectangle.Width -= val.get_Width();
					break;
				}
			}
		}
		if (rectangle.Width <= 0 || rectangle.Height <= 0)
		{
			rectangle = Rectangle.Empty;
		}
		rectangle_0 = rectangle;
		ResizeMarkup();
	}

	protected override void OnControlAdded(ControlEventArgs e)
	{
		((Control)this).OnControlAdded(e);
		if (((Component)this).DesignMode)
		{
			((Control)this).Invalidate();
		}
	}

	protected override void OnControlRemoved(ControlEventArgs e)
	{
		((Control)this).OnControlRemoved(e);
		if (bool_2 && ((Component)this).DesignMode)
		{
			((Control)this).Invalidate();
		}
	}

	public void ApplyPanelStyle()
	{
		ColorSchemeStyle = eDotNetBarStyle.Office2003;
		ResetStyle();
		ResetStyleMouseDown();
		ResetStyleMouseOver();
		elementStyle_0.Border = eStyleBorderType.Solid;
		elementStyle_0.BorderWidth = 1;
		elementStyle_0.BorderColorSchemePart = eColorSchemePart.PanelBorder;
		elementStyle_0.BackColorSchemePart = eColorSchemePart.PanelBackground;
		elementStyle_0.BackColor2SchemePart = eColorSchemePart.PanelBackground2;
		elementStyle_0.BackColorGradientAngle = GetColorScheme().PanelBackgroundGradientAngle;
		elementStyle_0.TextColorSchemePart = eColorSchemePart.PanelText;
		elementStyle_0.TextAlignment = eStyleTextAlignment.Center;
		elementStyle_0.TextLineAlignment = eStyleTextAlignment.Center;
		((Control)this).Invalidate();
	}

	public void ApplyButtonStyle()
	{
		ColorSchemeStyle = eDotNetBarStyle.Office2003;
		ResetStyle();
		ResetStyleMouseDown();
		ResetStyleMouseOver();
		Style.TextAlignment = eStyleTextAlignment.Center;
		Style.TextLineAlignment = eStyleTextAlignment.Center;
		Style.BackColorSchemePart = eColorSchemePart.BarBackground;
		Style.BackColor2SchemePart = eColorSchemePart.BarBackground2;
		Style.BackgroundImagePosition = eStyleBackgroundImage.Tile;
		Style.Border = eStyleBorderType.Solid;
		Style.BorderWidth = 1;
		Style.BorderColorSchemePart = eColorSchemePart.BarDockedBorder;
		Style.TextColorSchemePart = eColorSchemePart.ItemText;
		Style.BackColorGradientAngle = 90;
		StyleMouseDown.BackColorSchemePart = eColorSchemePart.ItemPressedBackground;
		StyleMouseDown.BackColor2SchemePart = eColorSchemePart.ItemPressedBackground2;
		StyleMouseDown.BorderColorSchemePart = eColorSchemePart.ItemPressedBorder;
		StyleMouseDown.TextColorSchemePart = eColorSchemePart.ItemPressedText;
		StyleMouseOver.BackColorSchemePart = eColorSchemePart.ItemHotBackground;
		StyleMouseOver.BackColor2SchemePart = eColorSchemePart.ItemHotBackground2;
		StyleMouseOver.BorderColorSchemePart = eColorSchemePart.ItemHotBorder;
		StyleMouseOver.TextColorSchemePart = eColorSchemePart.ItemHotText;
		((Control)this).Invalidate();
	}

	public void ApplyLabelStyle()
	{
		ResetStyleMouseDown();
		ResetStyleMouseOver();
		ApplyLabelStyle(Style);
		((Control)this).Invalidate();
	}

	protected virtual void ApplyLabelStyle(ElementStyle style)
	{
		style.Reset();
		style.TextAlignment = eStyleTextAlignment.Center;
		style.BackColorSchemePart = eColorSchemePart.BarBackground;
		style.BackColor2SchemePart = eColorSchemePart.BarBackground2;
		style.BackgroundImagePosition = eStyleBackgroundImage.Tile;
		style.BorderColorSchemePart = eColorSchemePart.BarDockedBorder;
		style.BorderWidth = 1;
		style.TextColorSchemePart = eColorSchemePart.ItemText;
		style.BackColorGradientAngle = 90;
	}

	public void NotifyDefault(bool value)
	{
		if (bool_4 != value)
		{
			bool_4 = value;
		}
	}

	public void PerformClick()
	{
		if (((Control)this).get_CanSelect())
		{
			((Control)this).OnClick(EventArgs.Empty);
		}
	}

	private void method_2()
	{
		DisposeThemeCachedBitmap();
		if (class59_0 != null)
		{
			class59_0.Dispose();
			class59_0 = new Class59((Control)(object)this);
		}
	}

	private void method_3()
	{
		if (class59_0 != null)
		{
			class59_0.Dispose();
			class59_0 = null;
		}
		DisposeThemeCachedBitmap();
	}

	protected void DisposeThemeCachedBitmap()
	{
		if (m_ThemeCachedBitmap != null)
		{
			((Image)m_ThemeCachedBitmap).Dispose();
			m_ThemeCachedBitmap = null;
		}
	}
}
