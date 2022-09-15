using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.TextMarkup;
using DevComponents.Editors;

namespace DevComponents.DotNetBar.Controls;

[Designer(typeof(TextBoxXDesigner))]
[ToolboxBitmap(typeof(TextBoxX), "Controls.TextBoxX.ico")]
[ToolboxItem(true)]
public class TextBoxX : TextBox, INonClientControl, IInputButtonControl
{
	private Class188 class188_0;

	private string string_0 = "";

	private bool bool_0;

	private Font font_0;

	private Color color_0 = SystemColors.GrayText;

	private ElementStyle elementStyle_0;

	private int int_0;

	private string string_1;

	private bool bool_1;

	private Color color_1 = ColorScheme.GetColor(16777096);

	private bool bool_2;

	private Color color_2 = Color.Empty;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private bool bool_3;

	private bool bool_4;

	private Class261 class261_0;

	private BaseRenderer baseRenderer_0;

	private BaseRenderer baseRenderer_1;

	private eRenderMode eRenderMode_0 = eRenderMode.Global;

	private bool bool_5 = true;

	private eWatermarkBehavior eWatermarkBehavior_0;

	private InputButtonSettings inputButtonSettings_0;

	private InputButtonSettings inputButtonSettings_1;

	private VisualGroup visualGroup_0;

	private bool bool_6;

	private Cursor cursor_0;

	private bool bool_7;

	private ColorScheme colorScheme_0;

	private bool Boolean_0
	{
		get
		{
			if (!bool_5)
			{
				return false;
			}
			if (eWatermarkBehavior_0 == eWatermarkBehavior.HideOnFocus)
			{
				if (!bool_0 && ((Control)this).get_Enabled() && ((Control)this).get_Text() != null && ((Control)this).get_Text().Length == 0)
				{
					return string_0.Length > 0;
				}
				return false;
			}
			if (((Control)this).get_Enabled() && ((Control)this).get_Text() != null && ((Control)this).get_Text().Length == 0)
			{
				return string_0.Length > 0;
			}
			return false;
		}
	}

	[Description("Indicates whether FocusHighlightColor is used as background color to highlight text box when it has input focus.")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Appearance")]
	public bool FocusHighlightEnabled
	{
		get
		{
			return bool_2;
		}
		set
		{
			if (bool_2 != value)
			{
				bool_2 = value;
				if (((Control)this).get_Focused())
				{
					((Control)this).Invalidate();
				}
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates color used as background color to highlight text box when it has input focus and focus highlight is enabled.")]
	[Category("Appearance")]
	public Color FocusHighlightColor
	{
		get
		{
			return color_1;
		}
		set
		{
			if (color_1 != value)
			{
				color_1 = value;
				if (((Control)this).get_Focused())
				{
					((Control)this).Invalidate();
				}
			}
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

	[Category("Style")]
	[Browsable(true)]
	[Description("Specifies the control border style. Default value has Class property set so the system style for the control is used.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ElementStyle Border => elementStyle_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public BorderStyle BorderStyle
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((TextBoxBase)this).get_BorderStyle();
		}
		set
		{
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

	[DefaultValue(true)]
	[Description("Indicates whether watermark text is displayed when control is empty.")]
	public virtual bool WatermarkEnabled
	{
		get
		{
			return bool_5;
		}
		set
		{
			bool_5 = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates watermark text displayed inside of the control when Text is not set and control does not have input focus.")]
	[DefaultValue("")]
	[Browsable(true)]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Localizable(true)]
	[Category("Appearance")]
	public string WatermarkText
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
			method_1();
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates watermark font.")]
	[Browsable(true)]
	[DefaultValue(null)]
	[Category("Appearance")]
	public Font WatermarkFont
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

	[Browsable(true)]
	[Category("Appearance")]
	[Description("Indicates watermark text color.")]
	public Color WatermarkColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates watermark hiding behaviour.")]
	[DefaultValue(eWatermarkBehavior.HideOnFocus)]
	[Category("Behavior")]
	public eWatermarkBehavior WatermarkBehavior
	{
		get
		{
			return eWatermarkBehavior_0;
		}
		set
		{
			eWatermarkBehavior_0 = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Describes the settings for the custom button that can execute an custom action of your choosing when clicked.")]
	[Category("Buttons")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public InputButtonSettings ButtonCustom => inputButtonSettings_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Describes the settings for the custom button that can execute an custom action of your choosing when clicked.")]
	[Category("Buttons")]
	public InputButtonSettings ButtonCustom2 => inputButtonSettings_1;

	private bool Boolean_1
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((TextBox)this).get_ScrollBars() == 0)
			{
				if (inputButtonSettings_0 != null && inputButtonSettings_0.Visible)
				{
					return true;
				}
				if (inputButtonSettings_1 != null)
				{
					return inputButtonSettings_1.Visible;
				}
				return false;
			}
			return false;
		}
	}

	ElementStyle INonClientControl.BorderStyle => method_7();

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

	public event EventHandler ButtonCustomClick
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

	public event EventHandler ButtonCustom2Click
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

	public TextBoxX()
	{
		inputButtonSettings_0 = new InputButtonSettings(this);
		inputButtonSettings_1 = new InputButtonSettings(this);
		method_12();
		elementStyle_0 = new ElementStyle();
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		class188_0 = new Class188(this, eScrollBarSkin.Optimized);
		((TextBoxBase)this).set_BorderStyle((BorderStyle)0);
		((Control)this).set_AutoSize(false);
	}

	internal TextBoxX(bool isTextBoxItem)
		: this()
	{
		bool_1 = isTextBoxItem;
	}

	protected override void Dispose(bool disposing)
	{
		if (class188_0 != null)
		{
			class188_0.method_0();
			class188_0 = null;
		}
		if (elementStyle_0 != null)
		{
			elementStyle_0.StyleChanged -= elementStyle_0_StyleChanged;
		}
		((TextBox)this).Dispose(disposing);
	}

	protected override void WndProc(ref Message m)
	{
		if (class188_0 != null)
		{
			if (class188_0.WndProc(ref m))
			{
				((TextBox)this).WndProc(ref m);
			}
		}
		else
		{
			((TextBox)this).WndProc(ref m);
		}
		if (Boolean_1)
		{
			int msg = ((Message)(ref m)).get_Msg();
			if (msg == 132 || msg == 160)
			{
				Point pt = ((Control)this).PointToClient(new Point(Class51.smethod_4(((Message)(ref m)).get_LParam()), Class51.smethod_5(((Message)(ref m)).get_LParam())));
				if (visualGroup_0.RenderBounds.Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(1));
					return;
				}
			}
		}
		switch (((Message)(ref m)).get_Msg())
		{
		case 15:
			if (Boolean_0)
			{
				method_4();
			}
			if (((Control)this).get_Parent() is ItemControl)
			{
				((ItemControl)(object)((Control)this).get_Parent()).method_22();
			}
			break;
		case 7:
			if (bool_3)
			{
				bool_3 = false;
				break;
			}
			bool_0 = true;
			int_0 = ((Message)(ref m)).get_WParam().ToInt32();
			string_1 = ((Control)this).get_Text();
			if (FocusHighlightEnabled && ((Control)this).get_Enabled())
			{
				color_2 = ((Control)this).get_BackColor();
				((Control)this).set_BackColor(FocusHighlightColor);
				InvalidateNonClient();
			}
			break;
		case 8:
			if (!bool_0)
			{
				bool_3 = true;
				break;
			}
			bool_0 = false;
			if (((Control)this).get_Text().Length == 0)
			{
				((Control)this).Invalidate();
			}
			if (FocusHighlightEnabled && !color_2.IsEmpty)
			{
				((Control)this).set_BackColor(color_2);
				InvalidateNonClient();
			}
			break;
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFocusHighlightColor()
	{
		return !color_1.Equals((object?)ColorScheme.GetColor(16777096));
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetFocusHighlightColor()
	{
		FocusHighlightColor = ColorScheme.GetColor(16777096);
	}

	internal void method_0()
	{
		if (!((Control)this).get_Focused() || int_0 == 0)
		{
			return;
		}
		int num = int_0;
		int_0 = 0;
		Control val = Control.FromChildHandle(new IntPtr(num));
		if (val == this)
		{
			return;
		}
		Control parent = ((Control)this).get_Parent();
		while (true)
		{
			if (parent != null)
			{
				if (parent == val)
				{
					break;
				}
				parent = parent.get_Parent();
				continue;
			}
			if (val != null)
			{
				val.Focus();
			}
			else
			{
				Class92.SetFocus(num);
			}
			return;
		}
		if (val is MenuPanel)
		{
			val.Focus();
		}
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		((Control)this).OnKeyDown(e);
		if (bool_1)
		{
			if ((int)e.get_KeyCode() == 13)
			{
				method_0();
			}
			else if ((int)e.get_KeyCode() == 27)
			{
				((Control)this).set_Text(string_1);
				((TextBoxBase)this).set_SelectionStart(0);
				method_0();
			}
		}
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((TextBox)this).OnGotFocus(e);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		int_0 = 0;
		((Control)this).OnLostFocus(e);
	}

	private void elementStyle_0_StyleChanged(object sender, EventArgs e)
	{
		InvalidateNonClient();
	}

	protected override void OnReadOnlyChanged(EventArgs e)
	{
		InvalidateNonClient();
		((TextBoxBase)this).OnReadOnlyChanged(e);
	}

	public void InvalidateNonClient()
	{
		if (Class109.smethod_11((Control)(object)this))
		{
			Class92.SetWindowPos(((Control)this).get_Handle(), 0, 0, 0, 0, 0, 55);
			method_5();
			Class92.RECT lprcUpdate = new Class92.RECT(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			Class92.RedrawWindow(((Control)this).get_Handle(), ref lprcUpdate, IntPtr.Zero, 1025u);
		}
	}

	private void method_1()
	{
		class261_0 = null;
		if (Class243.smethod_2(ref string_0))
		{
			class261_0 = Class243.smethod_0(string_0);
			method_2();
		}
	}

	private void method_2()
	{
		if (class261_0 != null)
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				Class263 @class = method_6(val);
				class261_0.Measure(method_3().Size, @class);
				Size size = class261_0.Bounds.Size;
				class261_0.method_2(new Rectangle(method_3().Location, size), @class);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	private Rectangle method_3()
	{
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		clientRectangle.Inflate(-1, 0);
		return clientRectangle;
	}

	private void method_4()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		Graphics val = ((Control)this).CreateGraphics();
		try
		{
			if (class261_0 != null)
			{
				Class263 d = method_6(val);
				class261_0.Render(d);
				return;
			}
			eTextFormat eTextFormat = eTextFormat.Default;
			if (((TextBoxBase)this).get_Multiline())
			{
				if ((int)((TextBox)this).get_TextAlign() == 2)
				{
					eTextFormat |= eTextFormat.VerticalCenter;
				}
				else if ((int)((TextBox)this).get_TextAlign() == 1)
				{
					eTextFormat |= eTextFormat.Bottom;
				}
			}
			if ((int)((Control)this).get_RightToLeft() == 1)
			{
				eTextFormat |= eTextFormat.RightToLeft;
			}
			if ((int)((TextBox)this).get_TextAlign() == 0)
			{
				eTextFormat = eTextFormat;
			}
			else if ((int)((TextBox)this).get_TextAlign() == 1)
			{
				eTextFormat |= eTextFormat.Right;
			}
			else if ((int)((TextBox)this).get_TextAlign() == 2)
			{
				eTextFormat |= eTextFormat.HorizontalCenter;
			}
			eTextFormat |= eTextFormat.EndEllipsis;
			eTextFormat |= eTextFormat.WordBreak;
			Class55.smethod_1(val, string_0, (font_0 == null) ? ((Control)this).get_Font() : font_0, color_0, method_3(), eTextFormat);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected override void OnFontChanged(EventArgs e)
	{
		method_5();
		((TextBox)this).OnFontChanged(e);
	}

	internal void method_5()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_AutoSize() || ((TextBoxBase)this).get_Multiline() || (int)BorderStyle != 0 || ((Control)this).get_IsDisposed() || ((Control)this).get_Parent() == null || bool_1)
		{
			return;
		}
		int num = ((Control)this).get_FontHeight();
		if (((Control)this).get_Font() != null)
		{
			num = Math.Max(num, ((Control)this).get_Font().get_Height());
		}
		ElementStyle elementStyle = method_7();
		if (elementStyle != null)
		{
			if (elementStyle.Boolean_3)
			{
				num = ((elementStyle.CornerType == eCornerType.Rounded || elementStyle.CornerType == eCornerType.Diagonal) ? (num + Math.Max(elementStyle.BorderTopWidth, elementStyle.CornerDiameter / 2 + 1)) : (num + elementStyle.BorderTopWidth));
			}
			if (elementStyle.Boolean_4)
			{
				num = ((elementStyle.CornerType == eCornerType.Rounded || elementStyle.CornerType == eCornerType.Diagonal) ? (num + Math.Max(elementStyle.BorderBottomWidth, elementStyle.CornerDiameter / 2 + 1)) : (num + elementStyle.BorderBottomWidth));
			}
			num += elementStyle.PaddingTop + elementStyle.PaddingBottom;
		}
		if (inputButtonSettings_0 != null && inputButtonSettings_0.Visible && inputButtonSettings_0.Image != null)
		{
			num = Math.Max(num, inputButtonSettings_0.Image.get_Height() + 6);
		}
		if (inputButtonSettings_1 != null && inputButtonSettings_1.Visible && inputButtonSettings_1.Image != null)
		{
			num = Math.Max(num, inputButtonSettings_1.Image.get_Height() + 6);
		}
		((Control)this).set_Height(num);
	}

	protected override void OnResize(EventArgs e)
	{
		method_2();
		visualGroup_0.InvalidateArrange();
		((Control)this).OnResize(e);
	}

	private Class263 method_6(Graphics graphics_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		return new Class263(graphics_0, (font_0 == null) ? ((Control)this).get_Font() : font_0, color_0, (int)((Control)this).get_RightToLeft() == 1);
	}

	protected override void OnTextAlignChanged(EventArgs e)
	{
		if (string_0.Length > 0)
		{
			((Control)this).Invalidate();
		}
		((TextBox)this).OnTextAlignChanged(e);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((TextBox)this).OnHandleCreated(e);
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		if (string_0.Length > 0)
		{
			((Control)this).Invalidate();
		}
		((Control)this).OnEnabledChanged(e);
	}

	protected override void OnTextChanged(EventArgs e)
	{
		if (string_0.Length > 0)
		{
			((Control)this).Invalidate();
		}
		((TextBoxBase)this).OnTextChanged(e);
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
		return baseRenderer_0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeWatermarkColor()
	{
		return color_0 != SystemColors.GrayText;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetWatermarkColor()
	{
		WatermarkColor = SystemColors.GrayText;
	}

	private ElementStyle method_7()
	{
		elementStyle_0.method_4(GetColorScheme());
		return ElementStyleDisplay.smethod_5(elementStyle_0);
	}

	void IInputButtonControl.InputButtonSettingsChanged(InputButtonSettings button)
	{
		OnInputButtonSettingsChanged(button);
	}

	protected virtual void OnInputButtonSettingsChanged(InputButtonSettings inputButtonSettings)
	{
		method_8();
	}

	private void method_8()
	{
		RecreateButtons();
		visualGroup_0.InvalidateArrange();
		InvalidateNonClient();
	}

	protected virtual void RecreateButtons()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		VisualItem[] items = method_11();
		VisualGroup visualGroup = visualGroup_0;
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
					visualItem.MouseUp -= new MouseEventHandler(method_9);
				}
				else if (visualItem == inputButtonSettings_1.ItemReference)
				{
					visualItem.MouseUp -= new MouseEventHandler(method_10);
				}
			}
		}
		visualGroup.Items.AddRange(items);
	}

	private void method_9(object sender, MouseEventArgs e)
	{
		if (inputButtonSettings_0.ItemReference.RenderBounds.Contains(e.get_X(), e.get_Y()))
		{
			OnButtonCustomClick((EventArgs)(object)e);
		}
	}

	protected virtual void OnButtonCustomClick(EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, e);
		}
	}

	private void method_10(object sender, MouseEventArgs e)
	{
		if (inputButtonSettings_1.ItemReference.RenderBounds.Contains(e.get_X(), e.get_Y()))
		{
			OnButtonCustom2Click((EventArgs)(object)e);
		}
	}

	protected virtual void OnButtonCustom2Click(EventArgs e)
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, e);
		}
	}

	private VisualItem[] method_11()
	{
		SortedList sortedList = CreateSortedButtonList();
		VisualItem[] array = new VisualItem[sortedList.Count];
		sortedList.Values.CopyTo(array, 0);
		return array;
	}

	protected virtual SortedList CreateSortedButtonList()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		SortedList sortedList = new SortedList(4);
		if (inputButtonSettings_0.Visible)
		{
			VisualItem visualItem = CreateButton(inputButtonSettings_0);
			if (inputButtonSettings_0.ItemReference != null)
			{
				inputButtonSettings_0.ItemReference.MouseUp -= new MouseEventHandler(method_9);
			}
			inputButtonSettings_0.ItemReference = visualItem;
			visualItem.MouseUp += new MouseEventHandler(method_9);
			visualItem.Enabled = inputButtonSettings_0.Enabled;
			sortedList.Add(inputButtonSettings_0, visualItem);
		}
		if (inputButtonSettings_1.Visible)
		{
			VisualItem visualItem2 = CreateButton(inputButtonSettings_1);
			if (inputButtonSettings_0.ItemReference != null)
			{
				inputButtonSettings_0.ItemReference.MouseUp -= new MouseEventHandler(method_10);
			}
			inputButtonSettings_1.ItemReference = visualItem2;
			visualItem2.MouseUp += new MouseEventHandler(method_10);
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
		button.Enum31_0 = Enum31.const_1;
		button.Enabled = buttonSettings.Enabled;
	}

	private void method_12()
	{
		VisualGroup visualGroup = new VisualGroup();
		visualGroup.HorizontalItemSpacing = 1;
		visualGroup.ArrangeInvalid += method_14;
		visualGroup.RenderInvalid += method_13;
		visualGroup_0 = visualGroup;
	}

	private void method_13(object sender, EventArgs e)
	{
		InvalidateNonClient();
	}

	private void method_14(object sender, EventArgs e)
	{
		InvalidateNonClient();
	}

	private PaintInfo method_15(Graphics graphics_0)
	{
		PaintInfo paintInfo = new PaintInfo();
		paintInfo.Graphics = graphics_0;
		paintInfo.DefaultFont = ((Control)this).get_Font();
		paintInfo.ForeColor = ((Control)this).get_ForeColor();
		paintInfo.RenderOffset = default(Point);
		Size size = ((Control)this).get_Size();
		ElementStyle elementStyle = method_7();
		size.Height -= Class52.smethod_8(elementStyle, eSpacePart.Border) + Class52.smethod_10(elementStyle, eSpacePart.Border) + 2;
		size.Width -= Class52.smethod_4(elementStyle, eSpacePart.Border) + Class52.smethod_6(elementStyle, eSpacePart.Border) + 2;
		paintInfo.AvailableSize = size;
		paintInfo.ParentEnabled = ((Control)this).get_Enabled();
		paintInfo.MouseOver = bool_6 || ((Control)this).get_Focused();
		return paintInfo;
	}

	private void method_16(Graphics graphics_0)
	{
		PaintInfo paintInfo = method_15(graphics_0);
		if (!visualGroup_0.IsLayoutValid)
		{
			visualGroup_0.PerformLayout(paintInfo);
		}
		ElementStyle elementStyle = method_7();
		visualGroup_0.RenderBounds = new Rectangle(((Control)this).get_Width() - (Class52.smethod_6(elementStyle, eSpacePart.Border) + 1) - visualGroup_0.Size.Width, Class52.smethod_8(elementStyle, eSpacePart.Border) + 1, visualGroup_0.Size.Width, visualGroup_0.Size.Height);
		visualGroup_0.vmethod_14(paintInfo);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (Boolean_1)
		{
			visualGroup_0.vmethod_2(e);
			if (visualGroup_0.RenderBounds.Contains(e.get_X(), e.get_Y()))
			{
				if (cursor_0 == (Cursor)null)
				{
					bool_7 = true;
					cursor_0 = ((Control)this).get_Cursor();
					((Control)this).set_Cursor(Cursors.get_Arrow());
					bool_7 = false;
				}
			}
			else if (cursor_0 != (Cursor)null)
			{
				bool_7 = true;
				((Control)this).set_Cursor(cursor_0);
				cursor_0 = null;
				bool_7 = false;
			}
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		bool_6 = true;
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		bool_6 = false;
		if (Boolean_1)
		{
			visualGroup_0.vmethod_1();
			if (cursor_0 != (Cursor)null)
			{
				bool_7 = true;
				((Control)this).set_Cursor(cursor_0);
				cursor_0 = null;
				bool_7 = false;
			}
		}
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnCursorChanged(EventArgs e)
	{
		if (cursor_0 != (Cursor)null && !bool_7)
		{
			cursor_0 = ((Control)this).get_Cursor();
		}
		((Control)this).OnCursorChanged(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (Boolean_1)
		{
			visualGroup_0.vmethod_4(e);
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (Boolean_1)
		{
			visualGroup_0.vmethod_5(e);
		}
		((TextBoxBase)this).OnMouseUp(e);
	}

	void INonClientControl.BaseWndProc(ref Message m)
	{
		((TextBox)this).WndProc(ref m);
	}

	ItemPaintArgs INonClientControl.GetItemPaintArgs(Graphics g)
	{
		ItemPaintArgs itemPaintArgs = new ItemPaintArgs(this as IOwner, (Control)(object)this, g, GetColorScheme());
		itemPaintArgs.BaseRenderer_0 = GetRenderer();
		itemPaintArgs.DesignerSelection = false;
		itemPaintArgs.GlassEnabled = !((Component)this).DesignMode && Class51.Boolean_0;
		return itemPaintArgs;
	}

	void INonClientControl.PaintBackground(PaintEventArgs e)
	{
		if (((Control)this).get_Parent() != null)
		{
			Type typeFromHandle = typeof(Control);
			typeFromHandle.GetMethod("PaintTransparentBackground", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, new Type[2]
			{
				typeof(PaintEventArgs),
				typeof(Rectangle)
			}, null)?.Invoke(this, new object[2]
			{
				e,
				new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height())
			});
		}
	}

	protected virtual ColorScheme GetColorScheme()
	{
		BaseRenderer renderer = GetRenderer();
		if (renderer is Office2007Renderer)
		{
			return ((Office2007Renderer)renderer).ColorTable.LegacyColors;
		}
		if (colorScheme_0 == null)
		{
			colorScheme_0 = new ColorScheme(eDotNetBarStyle.Office2007);
		}
		return colorScheme_0;
	}

	Point INonClientControl.PointToScreen(Point client)
	{
		return ((Control)this).PointToScreen(client);
	}

	void INonClientControl.AdjustClientRectangle(ref Rectangle r)
	{
		if (!Boolean_1)
		{
			return;
		}
		if (!visualGroup_0.IsLayoutValid)
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				PaintInfo pi = method_15(val);
				visualGroup_0.PerformLayout(pi);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		r.Width -= visualGroup_0.Size.Width + 1;
	}

	void INonClientControl.AdjustBorderRectangle(ref Rectangle r)
	{
	}

	void INonClientControl.RenderNonClient(Graphics g)
	{
		if (Boolean_1)
		{
			method_16(g);
		}
	}
}
