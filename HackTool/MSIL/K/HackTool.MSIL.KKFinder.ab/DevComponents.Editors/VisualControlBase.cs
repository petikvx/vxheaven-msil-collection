using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.Editors;

[ToolboxItem(false)]
public class VisualControlBase : PopupItemControl, ISupportInitialize, IInputButtonControl
{
	private VisualItem visualItem_0;

	private bool bool_5;

	private Color color_0 = Color.Empty;

	private static Color color_1 = Color.FromArgb(255, 255, 136);

	private Color color_2 = color_1;

	private bool bool_6;

	private EventHandler eventHandler_5;

	private EventHandler eventHandler_6;

	private eHorizontalAlignment eHorizontalAlignment_0;

	private Font font_0;

	private Color color_3 = SystemColors.GrayText;

	private bool bool_7 = true;

	private string string_0 = "";

	private eTextAlignment eTextAlignment_0;

	private InputButtonSettings inputButtonSettings_0;

	private InputButtonSettings inputButtonSettings_1;

	private ElementStyle elementStyle_0 = new ElementStyle();

	private int int_0 = -1;

	private eInputFieldNavigation eInputFieldNavigation_0 = eInputFieldNavigation.All;

	private Color color_4 = Color.Empty;

	private Color color_5 = Color.Empty;

	private InputControlColors inputControlColors_0;

	private bool bool_8;

	protected virtual bool IsWatermarkRendered => false;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual VisualItem RootVisualItem => visualItem_0;

	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(eHorizontalAlignment.Left)]
	[Description("Indicates alignment of input fields inside of the control.")]
	public virtual eHorizontalAlignment InputHorizontalAlignment
	{
		get
		{
			return eHorizontalAlignment_0;
		}
		set
		{
			if (eHorizontalAlignment_0 != value)
			{
				eHorizontalAlignment_0 = value;
				((Control)this).Invalidate();
			}
		}
	}

	[Description("Indicates watermark font.")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Category("Appearance")]
	public virtual Font WatermarkFont
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates watermark text color.")]
	[Browsable(true)]
	[Category("Appearance")]
	public virtual Color WatermarkColor
	{
		get
		{
			return color_3;
		}
		set
		{
			color_3 = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates whether watermark text is displayed if set for the input items.")]
	[DefaultValue(true)]
	public virtual bool WatermarkEnabled
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
			((Control)this).Invalidate();
		}
	}

	[DefaultValue("")]
	[Description("Indicates watermark text displayed on the input control when control is empty.")]
	[Category("Watermark")]
	public string WatermarkText
	{
		get
		{
			return string_0;
		}
		set
		{
			if (value != null)
			{
				string_0 = value;
				((Control)this).Invalidate();
			}
		}
	}

	[Description("Indicates watermark text alignment.")]
	[Category("Watermark")]
	[DefaultValue(eTextAlignment.Left)]
	[Browsable(true)]
	public eTextAlignment WatermarkAlignment
	{
		get
		{
			return eTextAlignment_0;
		}
		set
		{
			if (eTextAlignment_0 != value)
			{
				eTextAlignment_0 = value;
				((Control)this).Invalidate();
			}
		}
	}

	[Description("Indicates whether FocusHighlightColor is used as background color to highlight text box when it has input focus.")]
	[DefaultValue(false)]
	[Browsable(true)]
	[Category("Appearance")]
	public virtual bool FocusHighlightEnabled
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
				if (((Control)this).get_Focused())
				{
					((Control)this).Invalidate();
				}
			}
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates color used as background color to highlight text box when it has input focus and focus highlight is enabled.")]
	public virtual Color FocusHighlightColor
	{
		get
		{
			return color_2;
		}
		set
		{
			if (color_2 != value)
			{
				color_2 = value;
				if (((Control)this).get_Focused())
				{
					((Control)this).Invalidate();
				}
			}
		}
	}

	[Category("Buttons")]
	[Description("Describes the settings for the custom button that can execute an custom action of your choosing when clicked.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public InputButtonSettings ButtonCustom => inputButtonSettings_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Buttons")]
	[Description("Describes the settings for the custom button that can execute an custom action of your choosing when clicked.")]
	public InputButtonSettings ButtonCustom2 => inputButtonSettings_1;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets or sets control background style.")]
	[Category("Style")]
	public ElementStyle BackgroundStyle => elementStyle_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int PreferredHeight => GetPreferredHeight();

	protected override Size DefaultSize => new Size(80, GetPreferredHeight());

	[DefaultValue(eInputFieldNavigation.All)]
	[Description("Indicates keys used to navigate between the input fields provided by this control")]
	public eInputFieldNavigation FieldNavigation
	{
		get
		{
			return eInputFieldNavigation_0;
		}
		set
		{
			if (eInputFieldNavigation_0 != value)
			{
				eInputFieldNavigation_0 = value;
				ApplyFieldNavigation();
			}
		}
	}

	[Description("Indicates control background color when control is disabled")]
	[Category("Appearance")]
	public Color DisabledBackColor
	{
		get
		{
			return color_4;
		}
		set
		{
			if (color_4 != value)
			{
				color_4 = value;
				if (!((Control)this).get_Enabled())
				{
					((Control)this).Invalidate();
				}
			}
		}
	}

	[Description("Indicates control background color when control is disabled")]
	[Category("Appearance")]
	public Color DisabledForeColor
	{
		get
		{
			return color_5;
		}
		set
		{
			if (color_5 != value)
			{
				color_5 = value;
				if (!((Control)this).get_Enabled())
				{
					((Control)this).Invalidate();
				}
			}
		}
	}

	[Description("System colors used by the control.")]
	[Category("Colors")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public InputControlColors Colors => inputControlColors_0;

	[Browsable(false)]
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
	public override ImageLayout BackgroundImageLayout
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_BackgroundImageLayout();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_BackgroundImageLayout(value);
		}
	}

	[Browsable(false)]
	public override bool DisabledImagesGrayScale
	{
		get
		{
			return base.DisabledImagesGrayScale;
		}
		set
		{
			base.DisabledImagesGrayScale = value;
		}
	}

	[Browsable(false)]
	public Padding Padding
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Padding();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_Padding(value);
		}
	}

	[Browsable(false)]
	public override eDotNetBarStyle Style
	{
		get
		{
			return base.Style;
		}
		set
		{
			base.Style = value;
		}
	}

	[Browsable(false)]
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

	protected virtual bool IsInitializing => bool_8;

	public event EventHandler ButtonCustomClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_5 = (EventHandler)Delegate.Combine(eventHandler_5, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_5 = (EventHandler)Delegate.Remove(eventHandler_5, value);
		}
	}

	public event EventHandler ButtonCustom2Click
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_6 = (EventHandler)Delegate.Combine(eventHandler_6, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_6 = (EventHandler)Delegate.Remove(eventHandler_6, value);
		}
	}

	public VisualControlBase()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(SystemOptions.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).SetStyle((ControlStyles)512, true);
		((Control)this).set_IsAccessible(true);
		inputControlColors_0 = new InputControlColors();
		inputControlColors_0.ColorChanged += inputControlColors_0_ColorChanged;
		inputButtonSettings_0 = new InputButtonSettings(this);
		inputButtonSettings_1 = new InputButtonSettings(this);
		visualItem_0 = CreateRootVisual();
		visualItem_0.ArrangeInvalid += visualItem_0_ArrangeInvalid;
		visualItem_0.RenderInvalid += visualItem_0_RenderInvalid;
		elementStyle_0.Class = ElementStyleClassKeys.DateTimeInputBackgroundKey;
		elementStyle_0.method_4(base.ColorScheme);
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		ApplyFieldNavigation();
	}

	private void inputControlColors_0_ColorChanged(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}

	protected virtual PaintInfo CreatePaintInfo(PaintEventArgs e)
	{
		PaintInfo paintInfo = new PaintInfo();
		paintInfo.Graphics = e.get_Graphics();
		paintInfo.DefaultFont = ((Control)this).get_Font();
		paintInfo.ForeColor = ((Control)this).get_ForeColor();
		paintInfo.RenderOffset = default(Point);
		paintInfo.WatermarkColor = color_3;
		paintInfo.WatermarkEnabled = bool_7;
		paintInfo.WatermarkFont = font_0;
		paintInfo.AvailableSize = ((Control)this).get_ClientRectangle().Size;
		paintInfo.ParentEnabled = ((Control)this).get_Enabled();
		paintInfo.MouseOver = bool_6 || ((Control)this).get_Focused();
		paintInfo.Colors = inputControlColors_0;
		if (!color_5.IsEmpty)
		{
			paintInfo.DisabledForeColor = color_5;
		}
		return paintInfo;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		PaintInfo paintInfo = CreatePaintInfo(e);
		bool enabled;
		if (!(enabled = ((Control)this).get_Enabled()))
		{
			Color control = color_4;
			if (control.IsEmpty)
			{
				control = SystemColors.Control;
			}
			SolidBrush val = new SolidBrush(control);
			try
			{
				e.get_Graphics().FillRectangle((Brush)(object)val, clientRectangle);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		else
		{
			e.get_Graphics().FillRectangle(SystemBrushes.get_Window(), clientRectangle);
		}
		ElementStyle elementStyle = method_11();
		if (elementStyle.Custom)
		{
			ElementStyleDisplayInfo e2 = new ElementStyleDisplayInfo(elementStyle, e.get_Graphics(), clientRectangle);
			if (!enabled)
			{
				ElementStyleDisplay.PaintBorder(e2);
			}
			else
			{
				ElementStyleDisplay.Paint(e2);
			}
			clientRectangle.X += Class52.smethod_3(elementStyle);
			clientRectangle.Y += Class52.smethod_7(elementStyle);
			clientRectangle.Width -= Class52.smethod_1(elementStyle);
			clientRectangle.Height -= Class52.smethod_2(elementStyle);
			paintInfo.RenderOffset = clientRectangle.Location;
			paintInfo.AvailableSize = clientRectangle.Size;
		}
		if (bool_5 && ((Control)this).get_Focused() && !color_2.IsEmpty)
		{
			SolidBrush val2 = new SolidBrush(color_2);
			try
			{
				e.get_Graphics().FillRectangle((Brush)(object)val2, clientRectangle);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		if (!visualItem_0.IsLayoutValid)
		{
			if (visualItem_0 is VisualGroup)
			{
				((VisualGroup)visualItem_0).HorizontalItemAlignment = eHorizontalAlignment_0;
			}
			visualItem_0.PerformLayout(paintInfo);
		}
		if (eHorizontalAlignment_0 != 0)
		{
			if (eHorizontalAlignment_0 == eHorizontalAlignment.Right)
			{
				paintInfo.RenderOffset = new Point(clientRectangle.Width - visualItem_0.Size.Width, (clientRectangle.Height - visualItem_0.Size.Height) / 2);
			}
			else
			{
				paintInfo.RenderOffset = new Point((clientRectangle.Width - visualItem_0.Size.Width) / 2, (clientRectangle.Height - visualItem_0.Size.Height) / 2);
			}
		}
		else
		{
			paintInfo.RenderOffset = new Point(0, (clientRectangle.Height - visualItem_0.Size.Height) / 2);
		}
		if (WatermarkEnabled && WatermarkText.Length > 0 && IsWatermarkRendered)
		{
			Rectangle r = clientRectangle;
			r.Inflate(-1, -1);
			DrawWatermark(paintInfo, r);
		}
		else
		{
			visualItem_0.vmethod_14(paintInfo);
		}
		((Control)this).OnPaint(e);
	}

	private ElementStyle method_11()
	{
		elementStyle_0.method_4(base.ColorScheme);
		return ElementStyleDisplay.smethod_5(elementStyle_0);
	}

	protected virtual void DrawWatermark(PaintInfo p, Rectangle r)
	{
		if (WatermarkText.Length != 0)
		{
			Font val = p.DefaultFont;
			if (WatermarkFont != null)
			{
				val = WatermarkFont;
			}
			eTextFormat eTextFormat = eTextFormat.Default;
			if (eTextAlignment_0 == eTextAlignment.Center)
			{
				eTextFormat |= eTextFormat.HorizontalCenter;
			}
			else if (eTextAlignment_0 == eTextAlignment.Right)
			{
				eTextFormat |= eTextFormat.Right;
			}
			Class55.smethod_1(p.Graphics, WatermarkText, val, WatermarkColor, r, eTextFormat);
		}
	}

	protected override bool IsInputChar(char charCode)
	{
		return true;
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		visualItem_0.vmethod_8(e);
		((Control)this).OnKeyDown(e);
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		visualItem_0.vmethod_10(e);
		((Control)this).OnKeyPress(e);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		visualItem_0.vmethod_9(e);
		((Control)this).OnKeyUp(e);
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (visualItem_0.vmethod_11(ref msg, keyData))
		{
			return true;
		}
		return ((Control)this).ProcessCmdKey(ref msg, keyData);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (!((Control)this).get_Focused())
		{
			((Control)this).Select();
		}
		visualItem_0.vmethod_4(e);
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		visualItem_0.vmethod_3(e);
		((Control)this).OnMouseWheel(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		visualItem_0.vmethod_2(e);
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		visualItem_0.vmethod_5(e);
		((Control)this).OnMouseUp(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		bool_6 = true;
		((Control)this).Invalidate();
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		bool_6 = false;
		visualItem_0.vmethod_1();
		((Control)this).Invalidate();
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnClick(EventArgs e)
	{
		visualItem_0.vmethod_6();
		((Control)this).OnClick(e);
	}

	protected override void OnMouseClick(MouseEventArgs e)
	{
		visualItem_0.vmethod_7(e);
		((Control)this).OnMouseClick(e);
	}

	protected override void OnGotFocus(EventArgs e)
	{
		visualItem_0.vmethod_12();
		((Control)this).OnGotFocus(e);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		visualItem_0.vmethod_13();
		((Control)this).OnLostFocus(e);
	}

	protected virtual VisualItem CreateRootVisual()
	{
		return null;
	}

	private void visualItem_0_ArrangeInvalid(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}

	private void visualItem_0_RenderInvalid(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeWatermarkColor()
	{
		return color_3 != SystemColors.GrayText;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetWatermarkColor()
	{
		WatermarkColor = SystemColors.GrayText;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeFocusHighlightColor()
	{
		return !color_2.Equals((object?)color_1);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetFocusHighlightColor()
	{
		FocusHighlightColor = color_1;
	}

	void IInputButtonControl.InputButtonSettingsChanged(InputButtonSettings button)
	{
		OnInputButtonSettingsChanged(button);
	}

	protected virtual void OnInputButtonSettingsChanged(InputButtonSettings inputButtonSettings)
	{
		RecreateButtons();
	}

	protected virtual void RecreateButtons()
	{
		VisualItem[] items = method_14();
		if (!(visualItem_0 is VisualGroup))
		{
			return;
		}
		VisualGroup visualGroup = visualItem_0 as VisualGroup;
		VisualItem[] array = new VisualItem[visualGroup.Items.Count];
		visualGroup.Items.method_0(array);
		VisualItem[] array2 = array;
		foreach (VisualItem visualItem in array2)
		{
			if (visualItem.Enum31_0 == Enum31.const_1)
			{
				visualGroup.Items.Remove(visualItem);
				if (visualItem == inputButtonSettings_0.ItemReference)
				{
					visualItem.Click -= method_12;
				}
				else if (visualItem == inputButtonSettings_1.ItemReference)
				{
					visualItem.Click -= method_13;
				}
			}
		}
		visualGroup.Items.AddRange(items);
	}

	private void method_12(object sender, EventArgs e)
	{
		OnButtonCustomClick(e);
	}

	protected virtual void OnButtonCustomClick(EventArgs e)
	{
		if (eventHandler_5 != null)
		{
			eventHandler_5(this, e);
		}
	}

	private void method_13(object sender, EventArgs e)
	{
		OnButtonCustom2Click(e);
	}

	protected virtual void OnButtonCustom2Click(EventArgs e)
	{
		if (eventHandler_6 != null)
		{
			eventHandler_6(this, e);
		}
	}

	private VisualItem[] method_14()
	{
		SortedList sortedList = CreateSortedButtonList();
		VisualItem[] array = new VisualItem[sortedList.Count];
		sortedList.Values.CopyTo(array, 0);
		return array;
	}

	protected virtual SortedList CreateSortedButtonList()
	{
		SortedList sortedList = new SortedList(4);
		if (inputButtonSettings_0.Visible)
		{
			VisualItem visualItem = CreateButton(inputButtonSettings_0);
			if (inputButtonSettings_0.ItemReference != null)
			{
				inputButtonSettings_0.ItemReference.Click -= method_12;
			}
			inputButtonSettings_0.ItemReference = visualItem;
			visualItem.Click += method_12;
			visualItem.Enabled = inputButtonSettings_0.Enabled;
			sortedList.Add(inputButtonSettings_0, visualItem);
		}
		if (inputButtonSettings_1.Visible)
		{
			VisualItem visualItem2 = CreateButton(inputButtonSettings_1);
			if (inputButtonSettings_0.ItemReference != null)
			{
				inputButtonSettings_0.ItemReference.Click -= method_13;
			}
			inputButtonSettings_1.ItemReference = visualItem2;
			visualItem2.Click += method_13;
			visualItem2.Enabled = inputButtonSettings_1.Enabled;
			sortedList.Add(inputButtonSettings_1, visualItem2);
		}
		return sortedList;
	}

	protected virtual VisualItem CreateButton(InputButtonSettings buttonSettings)
	{
		VisualCustomButton visualCustomButton = new VisualCustomButton();
		ApplyButtonSettings(buttonSettings, visualCustomButton);
		return visualCustomButton;
	}

	protected virtual void ApplyButtonSettings(InputButtonSettings buttonSettings, VisualButton button)
	{
		button.Text = buttonSettings.Text;
		button.Image = buttonSettings.Image;
		button.Alignment = eItemAlignment.Right;
		button.Enum31_0 = Enum31.const_1;
		button.Enabled = buttonSettings.Enabled;
	}

	protected override void OnResize(EventArgs e)
	{
		method_15();
		visualItem_0.InvalidateArrange();
		((Control)this).OnResize(e);
	}

	protected override PopupItem CreatePopupItem()
	{
		return new ButtonItem();
	}

	protected override void RecalcSize()
	{
	}

	public override void PerformClick()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackgroundStyle()
	{
		elementStyle_0.StyleChanged -= elementStyle_0_StyleChanged;
		elementStyle_0 = new ElementStyle();
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		((Control)this).Invalidate();
	}

	private void elementStyle_0_StyleChanged(object sender, EventArgs e)
	{
		OnVisualPropertyChanged();
	}

	protected virtual void OnVisualPropertyChanged()
	{
		visualItem_0.InvalidateArrange();
		((Control)this).Invalidate();
	}

	protected override void Dispose(bool disposing)
	{
		if (elementStyle_0 != null)
		{
			elementStyle_0.StyleChanged -= elementStyle_0_StyleChanged;
		}
		((Control)this).Dispose(disposing);
	}

	protected virtual int GetPreferredHeight()
	{
		if (int_0 > -1)
		{
			return int_0;
		}
		return int_0 = ((Control)this).get_Font().get_Height() + (SystemInformation.get_BorderSize().Height * 4 + 3);
	}

	protected override void OnFontChanged(EventArgs e)
	{
		int_0 = -1;
		((Control)this).set_Height(PreferredHeight);
		base.OnFontChanged(e);
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		Size defaultSize = ((Control)this).get_DefaultSize();
		if (proposedSize.Width > 0 && proposedSize.Width < defaultSize.Width)
		{
			defaultSize.Width = proposedSize.Width;
		}
		return ((Control)this).get_DefaultSize();
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		method_15();
		base.OnHandleCreated(e);
	}

	private void method_15()
	{
		if (((Control)this).get_Height() != PreferredHeight)
		{
			((Control)this).set_Height(PreferredHeight);
		}
	}

	protected virtual void ApplyFieldNavigation()
	{
		if (visualItem_0 is VisualInputGroup)
		{
			VisualInputGroup visualInputGroup = visualItem_0 as VisualInputGroup;
			visualInputGroup.ArrowNavigationEnabled = (eInputFieldNavigation_0 & eInputFieldNavigation.Arrows) == eInputFieldNavigation.Arrows;
			visualInputGroup.TabNavigationEnabled = (eInputFieldNavigation_0 & eInputFieldNavigation.Tab) == eInputFieldNavigation.Tab;
			visualInputGroup.EnterNavigationEnabled = (eInputFieldNavigation_0 & eInputFieldNavigation.Enter) == eInputFieldNavigation.Enter;
		}
	}

	protected virtual bool IsNull(object value)
	{
		if (value != null && !(value is DBNull))
		{
			return false;
		}
		return true;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDisabledBackColor()
	{
		return !color_4.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDisabledBackColor()
	{
		DisabledBackColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDisabledForeColor()
	{
		return !color_5.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDisabledForeColor()
	{
		DisabledForeColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void BeginInit()
	{
		bool_8 = true;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void EndInit()
	{
		bool_8 = false;
	}
}
