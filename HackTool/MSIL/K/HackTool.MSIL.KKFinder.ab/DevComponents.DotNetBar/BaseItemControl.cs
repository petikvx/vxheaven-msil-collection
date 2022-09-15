using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
public abstract class BaseItemControl : Control
{
	private BaseItem baseItem_0;

	private ElementStyle elementStyle_0;

	private ColorScheme colorScheme_0;

	private bool bool_0;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private BaseRenderer baseRenderer_0;

	private BaseRenderer baseRenderer_1;

	private eRenderMode eRenderMode_0 = eRenderMode.Global;

	private bool bool_3;

	private int int_0;

	protected virtual BaseItem HostItem
	{
		get
		{
			return baseItem_0;
		}
		set
		{
			baseItem_0 = value;
			if (baseItem_0 != null)
			{
				baseItem_0.Displayed = true;
				baseItem_0.ContainerControl = this;
			}
		}
	}

	[Description("Indicates whether control displays focus cues when focused.")]
	[DefaultValue(true)]
	[Category("Behavior")]
	public virtual bool FocusCuesEnabled
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			if (((Control)this).get_Focused())
			{
				((Control)this).Invalidate();
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(eRenderMode.Global)]
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

	[DefaultValue(null)]
	[Browsable(false)]
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

	[Category("Style")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(true)]
	[Description("Gets or sets bar background style.")]
	[Browsable(true)]
	public ElementStyle BackgroundStyle => elementStyle_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets or sets Bar Color Scheme.")]
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
			if (((Control)this).get_Visible())
			{
				((Control)this).Refresh();
			}
		}
	}

	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[DefaultValue(true)]
	[Category("Appearance")]
	[Browsable(true)]
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
				((Control)this).Invalidate();
			}
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Specifies the visual style of the control.")]
	[DefaultValue(eDotNetBarStyle.Office2007)]
	public eDotNetBarStyle Style
	{
		get
		{
			return baseItem_0.Style;
		}
		set
		{
			baseItem_0.Style = value;
			if (value != eDotNetBarStyle.Office2007)
			{
				GetColorScheme().EDotNetBarStyle_0 = value;
			}
			RecalcLayout();
		}
	}

	[Browsable(false)]
	public bool IsUpdateSuspended => int_0 > 0;

	public BaseItemControl()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
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
		((Control)this).SetStyle((ControlStyles)4096, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		colorScheme_0 = new ColorScheme(eDotNetBarStyle.Office2007);
		elementStyle_0 = new ElementStyle();
		elementStyle_0.method_4(colorScheme_0);
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
	}

	protected override void OnBindingContextChanged(EventArgs e)
	{
		((Control)this).OnBindingContextChanged(e);
		if (baseItem_0 != null)
		{
			baseItem_0.method_16();
		}
	}

	protected bool GetDesignMode()
	{
		if (!bool_0)
		{
			return ((Component)this).DesignMode;
		}
		return bool_0;
	}

	protected virtual ElementStyle GetBackgroundStyle()
	{
		return elementStyle_0;
	}

	internal void method_0(bool bool_4)
	{
		bool_0 = bool_4;
		if (baseItem_0 != null)
		{
			baseItem_0.SetDesignMode(bool_4);
		}
	}

	protected virtual ColorScheme GetColorScheme()
	{
		if (baseItem_0 != null && baseItem_0.Style == eDotNetBarStyle.Office2007)
		{
			BaseRenderer renderer = GetRenderer();
			if (renderer is Office2007Renderer)
			{
				return ((Office2007Renderer)renderer).ColorTable.LegacyColors;
			}
		}
		return colorScheme_0;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (((Control)this).get_BackColor().IsEmpty || ((Control)this).get_BackColor() == Color.Transparent)
		{
			((Control)this).OnPaintBackground(e);
		}
		if (elementStyle_0 != null)
		{
			elementStyle_0.method_4(GetColorScheme());
		}
		PaintBackground(e);
		PaintControl(e);
		if (((Control)this).get_Focused() && FocusCuesEnabled)
		{
			PaintFocusCues(e);
		}
		((Control)this).OnPaint(e);
	}

	protected virtual void PaintFocusCues(PaintEventArgs e)
	{
		ControlPaint.DrawFocusRectangle(e.get_Graphics(), ((Control)this).get_ClientRectangle());
	}

	protected virtual void PaintBackground(PaintEventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = e.get_Graphics();
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		ElementStyle backgroundStyle = GetBackgroundStyle();
		if (!((Control)this).get_BackColor().IsEmpty)
		{
			Class50.smethod_23(graphics, clientRectangle, ((Control)this).get_BackColor());
		}
		if (backgroundStyle.Custom)
		{
			SmoothingMode smoothingMode = graphics.get_SmoothingMode();
			if (bool_1)
			{
				graphics.set_SmoothingMode((SmoothingMode)2);
			}
			ElementStyleDisplayInfo e2 = new ElementStyleDisplayInfo(backgroundStyle, e.get_Graphics(), clientRectangle);
			ElementStyleDisplay.Paint(e2);
			if (bool_1)
			{
				graphics.set_SmoothingMode(smoothingMode);
			}
		}
	}

	protected virtual void PaintControl(PaintEventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		SmoothingMode smoothingMode = e.get_Graphics().get_SmoothingMode();
		TextRenderingHint textRenderingHint = e.get_Graphics().get_TextRenderingHint();
		Graphics graphics = e.get_Graphics();
		if (bool_1)
		{
			graphics.set_SmoothingMode((SmoothingMode)4);
			graphics.set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
		ItemPaintArgs itemPaintArgs = GetItemPaintArgs(graphics);
		itemPaintArgs.ClipRectangle = e.get_ClipRectangle();
		if (baseItem_0 != null)
		{
			baseItem_0.Paint(itemPaintArgs);
		}
		graphics.set_SmoothingMode(smoothingMode);
		graphics.set_TextRenderingHint(textRenderingHint);
	}

	public Graphics CreateGraphics()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		Graphics val = ((Control)this).CreateGraphics();
		if (bool_1)
		{
			val.set_SmoothingMode((SmoothingMode)4);
			if (!SystemInformation.get_IsFontSmoothingEnabled())
			{
				val.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
		}
		return val;
	}

	protected virtual ItemPaintArgs GetItemPaintArgs(Graphics g)
	{
		ItemPaintArgs itemPaintArgs = new ItemPaintArgs(this as IOwner, (Control)(object)this, g, GetColorScheme());
		itemPaintArgs.BaseRenderer_0 = GetRenderer();
		itemPaintArgs.DesignerSelection = false;
		itemPaintArgs.GlassEnabled = !((Component)this).DesignMode && Class51.Boolean_0;
		return itemPaintArgs;
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackgroundStyle()
	{
		elementStyle_0.StyleChanged -= elementStyle_0_StyleChanged;
		elementStyle_0 = new ElementStyle();
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		OnBackgroundStyleChanged();
		((Control)this).Invalidate();
	}

	protected virtual void OnBackgroundStyleChanged()
	{
	}

	private void elementStyle_0_StyleChanged(object sender, EventArgs e)
	{
		OnVisualPropertyChanged();
	}

	protected virtual void OnVisualPropertyChanged()
	{
		if (GetDesignMode() || (((Control)this).get_Parent() != null && ((Component)(object)((Control)this).get_Parent()).Site != null && ((Component)(object)((Control)this).get_Parent()).Site!.DesignMode))
		{
			RecalcLayout();
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeColorScheme()
	{
		return colorScheme_0.SchemeChanged;
	}

	protected override void OnParentChanged(EventArgs e)
	{
		((Control)this).OnParentChanged(e);
		if (((Component)this).DesignMode && baseItem_0 != null)
		{
			baseItem_0.SetDesignMode(((Component)this).DesignMode);
		}
	}

	public virtual void RecalcLayout()
	{
		if (baseItem_0 != null)
		{
			Rectangle itemBounds = GetItemBounds();
			baseItem_0.Bounds = itemBounds;
			RecalcSize();
			baseItem_0.Bounds = itemBounds;
			((Control)this).Invalidate();
		}
	}

	protected virtual void RecalcSize()
	{
		baseItem_0.RecalcSize();
	}

	protected virtual Rectangle GetItemBounds()
	{
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		clientRectangle.X += Class52.smethod_3(BackgroundStyle);
		clientRectangle.Width -= Class52.smethod_1(BackgroundStyle);
		clientRectangle.Y += Class52.smethod_7(BackgroundStyle);
		clientRectangle.Height -= Class52.smethod_2(BackgroundStyle);
		return clientRectangle;
	}

	protected override void OnResize(EventArgs e)
	{
		RecalcLayout();
		((Control)this).OnResize(e);
	}

	protected override void OnTextChanged(EventArgs e)
	{
		baseItem_0.Text = ((Control)this).get_Text();
		RecalcLayout();
		((Control)this).OnTextChanged(e);
	}

	protected override void OnFontChanged(EventArgs e)
	{
		((Control)this).OnFontChanged(e);
		BarUtilities.smethod_1(baseItem_0);
		RecalcLayout();
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		baseItem_0.Enabled = ((Control)this).get_Enabled();
		((Control)this).OnEnabledChanged(e);
	}

	protected override void OnGotFocus(EventArgs e)
	{
		if (!bool_3)
		{
			baseItem_0.OnGotFocus();
		}
		bool_3 = false;
		((Control)this).OnGotFocus(e);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		baseItem_0.OnLostFocus();
		((Control)this).OnLostFocus(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		baseItem_0.InternalMouseEnter();
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		baseItem_0.InternalMouseMove(e);
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		baseItem_0.InternalMouseLeave();
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseHover(EventArgs e)
	{
		baseItem_0.InternalMouseHover();
		((Control)this).OnMouseHover(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576 && !((Control)this).get_Focused() && ((Control)this).GetStyle((ControlStyles)512))
		{
			bool_3 = true;
			((Control)this).Focus();
		}
		baseItem_0.InternalMouseDown(e);
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		baseItem_0.InternalMouseUp(e);
		((Control)this).OnMouseUp(e);
	}

	protected override void OnClick(EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		baseItem_0.InternalClick(Control.get_MouseButtons(), ((Control)this).PointToClient(Control.get_MousePosition()));
		((Control)this).OnClick(e);
	}

	protected override void OnDoubleClick(EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		baseItem_0.InternalDoubleClick(Control.get_MouseButtons(), ((Control)this).PointToClient(Control.get_MousePosition()));
		((Control)this).OnDoubleClick(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		baseItem_0.InternalKeyDown(e);
		((Control)this).OnKeyDown(e);
	}

	protected override bool ProcessMnemonic(char charCode)
	{
		if (Control.IsMnemonic(charCode, baseItem_0.Text) && ProcessAccelerator())
		{
			return true;
		}
		return ((Control)this).ProcessMnemonic(charCode);
	}

	protected virtual bool ProcessAccelerator()
	{
		baseItem_0.RaiseClick(eEventSource.Keyboard);
		return true;
	}

	public void BeginUpdate()
	{
		int_0++;
	}

	public void EndUpdate()
	{
		EndUpdate(callRecalcLayout: true);
	}

	public void EndUpdate(bool callRecalcLayout)
	{
		if (int_0 > 0)
		{
			int_0--;
			if (int_0 == 0 && callRecalcLayout)
			{
				RecalcLayout();
			}
		}
	}
}
