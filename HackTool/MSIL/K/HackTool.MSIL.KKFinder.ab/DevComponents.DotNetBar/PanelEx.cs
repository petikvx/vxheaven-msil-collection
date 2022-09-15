using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar;

[DefaultEvent("Click")]
[ToolboxItem(true)]
[Designer(typeof(PanelExDesigner))]
public class PanelEx : Panel, IButtonControl, INonClientControl
{
	private ItemStyle itemStyle_0;

	private ItemStyle itemStyle_1;

	private ItemStyle itemStyle_2;

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

	private bool bool_7 = true;

	private bool bool_8;

	private bool bool_9;

	private Class188 class188_0;

	private MarkupLinkClickEventHandler markupLinkClickEventHandler_0;

	private eCornerType eCornerType_0 = eCornerType.Square;

	private int int_0 = 8;

	internal bool bool_10;

	private BaseRenderer baseRenderer_0;

	[Browsable(true)]
	[Description("Indicates whether right-to-left mirror placement is turned on. ")]
	[DefaultValue(false)]
	[Category("Layout")]
	public bool RightToLeftLayout
	{
		get
		{
			return bool_8;
		}
		set
		{
			if (bool_8 != value)
			{
				bool_8 = value;
				if (((Control)this).get_IsHandleCreated())
				{
					((Control)this).RecreateHandle();
				}
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
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

	[Category("Appearance")]
	[Browsable(false)]
	[Description("Gets or sets Bar Color Scheme.")]
	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
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
				((Control)this).Refresh();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool SuspendPaint
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
				if (!bool_6)
				{
					method_2();
					((Control)this).Invalidate();
				}
			}
		}
	}

	private bool Boolean_0
	{
		get
		{
			if (bool_10)
			{
				return Class109.Boolean_0;
			}
			return false;
		}
	}

	internal bool Boolean_1
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
		}
	}

	[Category("Appearance")]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Description("Gets or sets the text displayed on panel.")]
	[DevCoBrowsable(true)]
	public override string Text
	{
		get
		{
			return string_0;
		}
		set
		{
			if (string_0 != value)
			{
				((Panel)this).set_Text(value);
				string_0 = value;
				((Control)this).OnTextChanged(new EventArgs());
				((Control)this).Refresh();
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether focus rectangle is displayed when control has focus.")]
	[Browsable(true)]
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
				((Control)this).Refresh();
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
				((Control)this).Refresh();
			}
		}
	}

	[Browsable(true)]
	[Description("Gets or sets panel style.")]
	[DevCoBrowsable(true)]
	[NotifyParentProperty(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	public ItemStyle Style => itemStyle_0;

	[Description("Gets or sets the panel style when mouse hovers over the panel.")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	[DevCoBrowsable(true)]
	[NotifyParentProperty(true)]
	public ItemStyle StyleMouseOver => itemStyle_1;

	[Category("Style")]
	[Description("Gets or sets the panel style when mouse button is pressed on the panel.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[NotifyParentProperty(true)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public ItemStyle StyleMouseDown => itemStyle_2;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
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

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
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
	[DefaultValue(true)]
	[Browsable(true)]
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
				OnAntiAliasChanged();
				((Control)this).Refresh();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Style")]
	[DefaultValue(eDotNetBarStyle.Office2003)]
	[Description("Gets or sets color scheme style.")]
	[Browsable(true)]
	public eDotNetBarStyle ColorSchemeStyle
	{
		get
		{
			return eDotNetBarStyle_0;
		}
		set
		{
			eDotNetBarStyle_0 = value;
			if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007 && GlobalManager.Renderer is Office2007Renderer)
			{
				colorScheme_0 = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.LegacyColors;
			}
			else
			{
				colorScheme_0 = new ColorScheme(eDotNetBarStyle_0);
			}
			if (class188_0 != null)
			{
				if (value == eDotNetBarStyle.Office2007)
				{
					class188_0.EScrollBarSkin_0 = eScrollBarSkin.Optimized;
				}
				else
				{
					class188_0.EScrollBarSkin_0 = eScrollBarSkin.None;
				}
			}
			OnColorSchemeChanged();
			((Control)this).Invalidate();
		}
	}

	[DefaultValue(false)]
	[Browsable(true)]
	public override bool AutoScroll
	{
		get
		{
			return ((ScrollableControl)this).get_AutoScroll();
		}
		set
		{
			if (!value)
			{
				((ScrollableControl)this).set_AutoScrollMinSize(Size.Empty);
			}
			((ScrollableControl)this).set_AutoScroll(value);
			RefreshTextClientRectangle();
		}
	}

	[Category("Appearance")]
	[DefaultValue(true)]
	[Description("Indicates whether text rectangle painted on panel is considering docked controls inside the panel.")]
	public bool TextDockConstrained
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
				((Control)this).Refresh();
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

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Panel)this).get_CreateParams();
			if (bool_8)
			{
				createParams.set_ExStyle(createParams.get_ExStyle() | 0x500000);
			}
			return createParams;
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(false)]
	[Description("Indicates whether text markup if it occupies less space than control provides uses the Style Alignment and LineAlignment properties to align the markup inside of the control.")]
	public virtual bool MarkupUsesStyleAlignment
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
				if (Class109.smethod_11((Control)(object)this) && class261_0 != null)
				{
					ResizeMarkup();
					((Control)this).Invalidate();
				}
			}
		}
	}

	[Browsable(true)]
	[Description("Gets or sets the value returned to the parent form when the button is clicked.")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Category("Behavior")]
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

	[DefaultValue(false)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Description("Specifies whether item is drawn using Themes when running on OS that supports themes like Windows XP.")]
	public virtual bool ThemeAware
	{
		get
		{
			return bool_10;
		}
		set
		{
			DisposeThemeCachedBitmap();
			bool_10 = value;
			((Control)this).Refresh();
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

	ElementStyle INonClientControl.BorderStyle => null;

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

	public PanelEx()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
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
		colorScheme_0 = new ColorScheme(eDotNetBarStyle_0);
		ResetStyle();
		ResetStyleMouseOver();
		ResetStyleMouseDown();
		class188_0 = new Class188(this, eScrollBarSkin.Optimized);
		((Control)this).set_BackColor(Color.Transparent);
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

	internal void method_0()
	{
		((Control)this).SetStyle((ControlStyles)512, false);
		((Panel)this).set_TabStop(false);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeColorScheme()
	{
		if (colorScheme_0.SchemeChanged)
		{
			return eDotNetBarStyle_0 != eDotNetBarStyle.Office2007;
		}
		return false;
	}

	private void method_1(object sender, EventArgs e)
	{
		if (bool_9)
		{
			ResizeMarkup();
		}
		if (!bool_6)
		{
			RefreshStyleSystemColors();
			method_2();
			((Control)this).Invalidate();
		}
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007)
		{
			RefreshStyleSystemColors();
		}
		((ScrollableControl)this).OnVisibleChanged(e);
	}

	private void method_2()
	{
		method_3(bool_11: false);
	}

	private void method_3(bool bool_11)
	{
		if (bool_11 || eCornerType_0 != itemStyle_0.CornerType || int_0 != itemStyle_0.CornerDiameter)
		{
			eCornerType_0 = itemStyle_0.CornerType;
			int_0 = itemStyle_0.CornerDiameter;
			if (itemStyle_0 != null && (!bool_10 || !Class109.Boolean_0) && itemStyle_0.CornerType != eCornerType.Square)
			{
				((Control)this).set_Region(itemStyle_0.method_6(((Control)this).get_ClientRectangle()));
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
		if (itemStyle_0 != null)
		{
			itemStyle_0.method_1(colorScheme);
		}
		if (itemStyle_1 != null)
		{
			itemStyle_1.method_1(colorScheme);
		}
		if (itemStyle_2 != null)
		{
			itemStyle_2.method_1(colorScheme);
		}
	}

	protected override void WndProc(ref Message m)
	{
		bool flag = true;
		switch (((Message)(ref m)).get_Msg())
		{
		default:
			if (class188_0 != null)
			{
				flag = class188_0.WndProc(ref m);
			}
			if (flag)
			{
				((ScrollableControl)this).WndProc(ref m);
			}
			break;
		case 276:
		case 277:
		case 522:
			if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() == 0)
			{
				bool_6 = true;
			}
			if (class188_0 != null)
			{
				class188_0.Boolean_2 = true;
			}
			try
			{
				if (class188_0 != null)
				{
					flag = class188_0.WndProc(ref m);
				}
				if (flag)
				{
					((ScrollableControl)this).WndProc(ref m);
				}
			}
			finally
			{
				if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() == 0)
				{
					bool_6 = false;
				}
				if (class188_0 != null)
				{
					class188_0.Boolean_2 = false;
				}
			}
			if (class188_0 != null)
			{
				class188_0.method_26();
			}
			if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() == 0)
			{
				RefreshTextClientRectangle();
				((Control)this).Invalidate();
			}
			break;
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Invalid comparison between Unknown and I4
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Invalid comparison between Unknown and I4
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_ClientRectangle().Width == 0 || ((Control)this).get_ClientRectangle().Height == 0 || bool_6)
		{
			return;
		}
		SolidBrush val = new SolidBrush(color_0);
		try
		{
			e.get_Graphics().FillRectangle((Brush)(object)val, ((Control)this).get_ClientRectangle());
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		if ((itemStyle_0.BackColor1.Color.IsEmpty || itemStyle_0.BackColor1.Color.A < byte.MaxValue) && (itemStyle_0.BackColor2.Color.IsEmpty || itemStyle_0.BackColor2.Color.A < byte.MaxValue))
		{
			((ScrollableControl)this).OnPaintBackground(e);
		}
		SmoothingMode smoothingMode = e.get_Graphics().get_SmoothingMode();
		TextRenderingHint textRenderingHint = e.get_Graphics().get_TextRenderingHint();
		if (bool_5)
		{
			e.get_Graphics().set_SmoothingMode((SmoothingMode)4);
			e.get_Graphics().set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
		ItemStyle itemStyle = itemStyle_0.Clone() as ItemStyle;
		if (bool_1 && ((Control)this).get_Enabled() && itemStyle_2.Boolean_0)
		{
			itemStyle.method_0(itemStyle_2);
		}
		else if (bool_0 && ((Control)this).get_Enabled() && itemStyle_1.Boolean_0)
		{
			itemStyle.method_0(itemStyle_1);
		}
		if (class261_0 == null)
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
		Rectangle textRect = rectangle_0;
		textRect.Inflate(-1, -1);
		if (!((Control)this).get_Enabled())
		{
			itemStyle.ForeColor.Color = colorScheme_0.ItemDisabledText;
		}
		Graphics graphics = e.get_Graphics();
		if (Boolean_0)
		{
			if (m_ThemeCachedBitmap != null && !(((Image)m_ThemeCachedBitmap).get_Size() != ((Control)this).get_ClientRectangle().Size))
			{
				e.get_Graphics().DrawImage((Image)(object)m_ThemeCachedBitmap, 0, 0, ((Image)m_ThemeCachedBitmap).get_Width(), ((Image)m_ThemeCachedBitmap).get_Height());
			}
			else
			{
				DisposeThemeCachedBitmap();
				Bitmap val2 = new Bitmap(((Control)this).get_ClientRectangle().Width, ((Control)this).get_ClientRectangle().Height, e.get_Graphics());
				Graphics val3 = Graphics.FromImage((Image)(object)val2);
				try
				{
					Class59_0.method_0(val3, Class119.class119_8, Class144.class144_2, new Rectangle(0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height()));
				}
				finally
				{
					val3.Dispose();
				}
				e.get_Graphics().DrawImage((Image)(object)val2, 0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height());
				if (itemStyle_0.BackgroundImage != null)
				{
					Class109.smethod_63(e.get_Graphics(), ((Control)this).get_ClientRectangle(), itemStyle_0.BackgroundImage, itemStyle_0.BackgroundImagePosition, itemStyle_0.BackgroundImageAlpha);
				}
				m_ThemeCachedBitmap = val2;
			}
			if (Boolean_1)
			{
				Region clip = graphics.get_Clip();
				Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
				clientRectangle.Inflate(-2, -2);
				clientRectangle.Height -= 3;
				graphics.SetClip(clientRectangle);
				if (class261_0 == null)
				{
					itemStyle.PaintText(graphics, ((Control)this).get_Text(), textRect, ((Control)this).get_Font());
				}
				else
				{
					Rectangle clipRectangle = e.get_ClipRectangle();
					if (clipRectangle.Height == ((Control)this).get_ClientRectangle().Height && clipRectangle.Width < ((Control)this).get_ClientRectangle().Width)
					{
						clipRectangle.Width = ((Control)this).get_ClientRectangle().Width;
					}
					Class263 d = new Class263(graphics, ((Control)this).get_Font(), itemStyle.ForeColor.Color, (int)((Control)this).get_RightToLeft() == 1, clipRectangle, hotKeyPrefixVisible: true);
					class261_0.Render(d);
				}
				graphics.set_Clip(clip);
			}
		}
		else if (class261_0 == null)
		{
			if (bool_7)
			{
				itemStyle.Paint(graphics, displayRectangle, ((Control)this).get_Text(), textRect, ((Control)this).get_Font());
			}
			else
			{
				itemStyle.Paint(graphics, displayRectangle);
			}
		}
		else
		{
			itemStyle.Paint(graphics, displayRectangle);
			if (bool_7)
			{
				Rectangle clipRectangle2 = e.get_ClipRectangle();
				if (clipRectangle2.Height == ((Control)this).get_ClientRectangle().Height && clipRectangle2.Width < ((Control)this).get_ClientRectangle().Width)
				{
					clipRectangle2.Width = ((Control)this).get_ClientRectangle().Width;
				}
				Class263 d2 = new Class263(graphics, ((Control)this).get_Font(), itemStyle.ForeColor.Color, (int)((Control)this).get_RightToLeft() == 1, clipRectangle2, hotKeyPrefixVisible: true);
				class261_0.Render(d2);
			}
		}
		if (((Control)this).get_Focused() && bool_3)
		{
			displayRectangle = ((Control)this).get_ClientRectangle();
			displayRectangle.Inflate(-2, -2);
			if (displayRectangle.Width > 0 && displayRectangle.Height > 0)
			{
				ControlPaint.DrawFocusRectangle(graphics, displayRectangle);
			}
		}
		e.get_Graphics().set_SmoothingMode(smoothingMode);
		e.get_Graphics().set_TextRenderingHint(textRenderingHint);
		((Control)this).OnPaint(e);
	}

	protected override void OnResize(EventArgs e)
	{
		if (class188_0 != null)
		{
			class188_0.method_26();
		}
		((Panel)this).OnResize(e);
		RefreshTextClientRectangle();
		method_3(bool_11: true);
	}

	protected override void OnChangeUICues(UICuesEventArgs e)
	{
		((Control)this).OnChangeUICues(e);
		if (bool_3)
		{
			((Control)this).Refresh();
		}
	}

	protected override void OnLostFocus(EventArgs e)
	{
		((Control)this).OnLostFocus(e);
		if (bool_3)
		{
			((Control)this).Refresh();
		}
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((Control)this).OnGotFocus(e);
		if (bool_3)
		{
			((Control)this).Refresh();
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
		if ((int)e.get_Button() == 1048576)
		{
			SetMouseDown(mouseDown: true);
		}
		((Control)this).OnMouseDown(e);
	}

	public void SetMouseDown(bool mouseDown)
	{
		if (bool_1 != mouseDown)
		{
			bool_1 = mouseDown;
			if (itemStyle_2.Boolean_0)
			{
				((Control)this).Invalidate(false);
			}
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		if (class261_0 != null)
		{
			class261_0.method_7((Control)(object)this, e);
		}
		SetMouseDown(mouseDown: false);
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
		SetMouseOver(mouseOver: true);
	}

	public void SetMouseOver(bool mouseOver)
	{
		if (bool_0 != mouseOver)
		{
			bool_0 = mouseOver;
			if (itemStyle_1.Boolean_0)
			{
				((Control)this).Invalidate(false);
			}
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		if (class261_0 != null)
		{
			class261_0.method_4((Control)(object)this);
		}
		SetMouseOver(mouseOver: false);
	}

	protected override void OnSystemColorsChanged(EventArgs e)
	{
		((Control)this).OnSystemColorsChanged(e);
		Application.DoEvents();
		colorScheme_0.Refresh(null, bSystemColorEvent: true);
		RefreshStyleSystemColors();
		if (class59_0 != null)
		{
			method_6();
		}
		((Control)this).Invalidate(true);
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_7();
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
			class261_0.Event_0 -= method_4;
			class261_0 = null;
		}
		if (Class243.smethod_2(ref string_))
		{
			class261_0 = Class243.smethod_0(string_);
		}
		if (class261_0 != null)
		{
			class261_0.Event_0 += method_4;
			RefreshTextClientRectangle();
		}
		((Control)this).OnTextChanged(e);
	}

	private void method_4(object sender, EventArgs e)
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
		itemStyle_0 = new ItemStyle();
		itemStyle_0.Event_0 += method_1;
		RefreshStyleSystemColors();
	}

	public void ResetMouseTracking()
	{
		bool_0 = false;
		bool_1 = false;
		((Control)this).Refresh();
	}

	public void ResetStyleMouseOver()
	{
		itemStyle_1 = new ItemStyle();
		itemStyle_1.Event_0 += method_1;
	}

	public void ResetStyleMouseDown()
	{
		itemStyle_2 = new ItemStyle();
		itemStyle_2.Event_0 += method_1;
	}

	protected virtual void OnAntiAliasChanged()
	{
	}

	private ColorScheme GetColorScheme()
	{
		if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007 && GlobalManager.Renderer is Office2007Renderer office2007Renderer && office2007Renderer.ColorTable.LegacyColors != null)
		{
			return office2007Renderer.ColorTable.LegacyColors;
		}
		return colorScheme_0;
	}

	protected virtual void OnColorSchemeChanged()
	{
		RefreshStyleSystemColors();
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() == 0)
		{
			if (!Class109.smethod_11((Control)(object)this))
			{
				return proposedSize;
			}
			Size autoSize = GetAutoSize();
			if (autoSize.IsEmpty)
			{
				return proposedSize;
			}
			return autoSize;
		}
		return ((Control)this).GetPreferredSize(proposedSize);
	}

	public Size GetAutoSize()
	{
		return GetAutoSize(0);
	}

	public Size GetAutoSize(int preferedWidth)
	{
		if (class261_0 == null && ((Control)this).get_Text().Length == 0)
		{
			return new Size(16, 16);
		}
		Size result = Size.Empty;
		if (class261_0 != null)
		{
			result = ((preferedWidth != 0) ? method_5(preferedWidth) : class261_0.Bounds.Size);
			result.Width += 4;
			result.Height += 6;
		}
		else if (((Control)this).get_Text().Length > 0)
		{
			Font font = ((Control)this).get_Font();
			if (itemStyle_0.Font != null)
			{
				font = itemStyle_0.Font;
			}
			Graphics val = Class109.smethod_68((Control)(object)this);
			try
			{
				result = ((preferedWidth > 0) ? Class55.smethod_5(val, ((Control)this).get_Text(), font, preferedWidth) : Class55.smethod_3(val, ((Control)this).get_Text(), font));
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
		result.Width += itemStyle_0.MarginLeft + itemStyle_0.MarginRight;
		result.Height += itemStyle_0.MarginTop + itemStyle_0.MarginBottom;
		return result;
	}

	protected virtual void RefreshTextClientRectangle()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected I4, but got Unknown
		Rectangle rectangle = ((Control)this).get_DisplayRectangle();
		if (bool_2)
		{
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
		}
		rectangle_0 = rectangle;
		ResizeMarkup();
	}

	private Size method_5(int int_1)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		Size empty = Size.Empty;
		if (class261_0 != null)
		{
			Rectangle rectangle = new Rectangle(0, 0, int_1, 500);
			rectangle.Inflate(-2, -2);
			rectangle.Inflate(-(itemStyle_0.MarginLeft + itemStyle_0.MarginRight), -(itemStyle_0.MarginTop + itemStyle_0.MarginBottom));
			if (Boolean_0)
			{
				rectangle.Height -= 4;
			}
			Graphics val = ((Control)this).CreateGraphics();
			Class261 @class = Class243.smethod_0(((Control)this).get_Text());
			try
			{
				if (bool_5)
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

	public void UpdateMarkupSize()
	{
		RefreshTextClientRectangle();
		((Control)this).Invalidate();
	}

	protected virtual void ResizeMarkup()
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Invalid comparison between Unknown and I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Invalid comparison between Unknown and I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Invalid comparison between Unknown and I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Invalid comparison between Unknown and I4
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Invalid comparison between Unknown and I4
		if (class261_0 == null)
		{
			return;
		}
		Rectangle clientTextRectangle = ClientTextRectangle;
		clientTextRectangle.Inflate(-2, -2);
		clientTextRectangle.Inflate(-(itemStyle_0.MarginLeft + itemStyle_0.MarginRight), -(itemStyle_0.MarginTop + itemStyle_0.MarginBottom));
		if (Boolean_0)
		{
			clientTextRectangle.Height -= 4;
		}
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
			if (bool_9)
			{
				if (class261_0.Bounds.Height < clientTextRectangle.Height)
				{
					if ((int)Style.LineAlignment == 1)
					{
						clientTextRectangle.Y += (clientTextRectangle.Height - class261_0.Bounds.Height) / 2;
						clientTextRectangle.Height = class261_0.Bounds.Height;
					}
					else if ((int)Style.LineAlignment == 2)
					{
						clientTextRectangle.Y = clientTextRectangle.Bottom - class261_0.Bounds.Height;
						clientTextRectangle.Height = class261_0.Bounds.Height;
					}
				}
				if (class261_0.Bounds.Width < clientTextRectangle.Width)
				{
					if ((int)Style.Alignment == 1)
					{
						clientTextRectangle.X += (clientTextRectangle.Width - class261_0.Bounds.Width) / 2;
						clientTextRectangle.Width = class261_0.Bounds.Width;
					}
					else if (((int)Style.Alignment == 2 && (int)((Control)this).get_RightToLeft() == 0) || ((int)Style.Alignment == 0 && (int)((Control)this).get_RightToLeft() == 1))
					{
						clientTextRectangle.X = clientTextRectangle.Right - class261_0.Bounds.Width;
						clientTextRectangle.Width = class261_0.Bounds.Width;
					}
				}
			}
			class261_0.method_2(clientTextRectangle, @class);
			if (((ScrollableControl)this).get_AutoScroll())
			{
				Size empty = Size.Empty;
				if (class261_0.Bounds.Height > clientTextRectangle.Height)
				{
					empty.Height = class261_0.Bounds.Height + itemStyle_0.MarginTop + itemStyle_0.MarginBottom + 2;
				}
				if (class261_0.Bounds.Width > clientTextRectangle.Width)
				{
					empty.Width = class261_0.Bounds.Width + itemStyle_0.MarginLeft + itemStyle_0.MarginRight + 2;
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

	protected override void OnControlAdded(ControlEventArgs e)
	{
		((Control)this).OnControlAdded(e);
		RefreshTextClientRectangle();
		if (((Component)this).DesignMode)
		{
			((Control)this).Refresh();
		}
	}

	protected override void OnControlRemoved(ControlEventArgs e)
	{
		((Control)this).OnControlRemoved(e);
		RefreshTextClientRectangle();
		if (bool_2 && ((Component)this).DesignMode)
		{
			((Control)this).Refresh();
		}
	}

	public void ApplyPanelStyle()
	{
		ResetStyle();
		ResetStyleMouseDown();
		ResetStyleMouseOver();
		itemStyle_0.Border = eBorderType.SingleLine;
		itemStyle_0.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
		itemStyle_0.BackColor1.ColorSchemePart = eColorSchemePart.PanelBackground;
		itemStyle_0.BackColor2.ColorSchemePart = eColorSchemePart.PanelBackground2;
		itemStyle_0.GradientAngle = colorScheme_0.PanelBackgroundGradientAngle;
		itemStyle_0.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
		itemStyle_0.Alignment = (StringAlignment)1;
		itemStyle_0.LineAlignment = (StringAlignment)1;
		((Control)this).Refresh();
	}

	public void ApplyButtonStyle()
	{
		ResetStyle();
		ResetStyleMouseDown();
		ResetStyleMouseOver();
		Style.Alignment = (StringAlignment)1;
		Style.BackColor1.ColorSchemePart = eColorSchemePart.BarBackground;
		Style.BackColor2.ColorSchemePart = eColorSchemePart.BarBackground2;
		Style.Border = eBorderType.SingleLine;
		Style.BorderColor.ColorSchemePart = eColorSchemePart.BarDockedBorder;
		Style.ForeColor.ColorSchemePart = eColorSchemePart.ItemText;
		Style.GradientAngle = 90;
		StyleMouseDown.Alignment = (StringAlignment)1;
		StyleMouseDown.BackColor1.ColorSchemePart = eColorSchemePart.ItemPressedBackground;
		StyleMouseDown.BackColor2.ColorSchemePart = eColorSchemePart.ItemPressedBackground2;
		StyleMouseDown.BorderColor.ColorSchemePart = eColorSchemePart.ItemPressedBorder;
		StyleMouseDown.ForeColor.ColorSchemePart = eColorSchemePart.ItemPressedText;
		StyleMouseOver.Alignment = (StringAlignment)1;
		StyleMouseOver.BackColor1.ColorSchemePart = eColorSchemePart.ItemHotBackground;
		StyleMouseOver.BackColor2.ColorSchemePart = eColorSchemePart.ItemHotBackground2;
		StyleMouseOver.BorderColor.ColorSchemePart = eColorSchemePart.ItemHotBorder;
		StyleMouseOver.ForeColor.ColorSchemePart = eColorSchemePart.ItemHotText;
		((Control)this).Refresh();
	}

	public void ApplyLabelStyle()
	{
		ResetStyle();
		ResetStyleMouseDown();
		ResetStyleMouseOver();
		TypeDescriptor.GetProperties(Style)["Alignment"]!.SetValue(Style, (object)(StringAlignment)1);
		TypeDescriptor.GetProperties(Style.BackColor1)["ColorSchemePart"]!.SetValue(Style.BackColor1, eColorSchemePart.BarBackground);
		TypeDescriptor.GetProperties(Style.BackColor2)["ColorSchemePart"]!.SetValue(Style.BackColor2, eColorSchemePart.BarBackground2);
		TypeDescriptor.GetProperties(Style.BorderColor)["ColorSchemePart"]!.SetValue(Style.BorderColor, eColorSchemePart.BarDockedBorder);
		TypeDescriptor.GetProperties(Style.ForeColor)["ColorSchemePart"]!.SetValue(Style.ForeColor, eColorSchemePart.ItemText);
		TypeDescriptor.GetProperties(Style)["GradientAngle"]!.SetValue(Style, 90);
		((Control)this).Refresh();
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

	private void method_6()
	{
		DisposeThemeCachedBitmap();
		if (class59_0 != null)
		{
			class59_0.Dispose();
			class59_0 = new Class59((Control)(object)this);
		}
	}

	private void method_7()
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

	private BaseRenderer method_8()
	{
		if (GlobalManager.Renderer != null)
		{
			return GlobalManager.Renderer;
		}
		if (baseRenderer_0 == null)
		{
			baseRenderer_0 = new Office2007Renderer();
		}
		return baseRenderer_0;
	}

	void INonClientControl.BaseWndProc(ref Message m)
	{
		((ScrollableControl)this).WndProc(ref m);
	}

	ItemPaintArgs INonClientControl.GetItemPaintArgs(Graphics g)
	{
		ItemPaintArgs itemPaintArgs = new ItemPaintArgs(this as IOwner, (Control)(object)this, g, GetColorScheme());
		itemPaintArgs.BaseRenderer_0 = method_8();
		itemPaintArgs.DesignerSelection = false;
		itemPaintArgs.GlassEnabled = !((Component)this).DesignMode && Class51.Boolean_0;
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

	void INonClientControl.AdjustClientRectangle(ref Rectangle r)
	{
	}

	void INonClientControl.AdjustBorderRectangle(ref Rectangle r)
	{
	}

	void INonClientControl.RenderNonClient(Graphics g)
	{
	}
}
