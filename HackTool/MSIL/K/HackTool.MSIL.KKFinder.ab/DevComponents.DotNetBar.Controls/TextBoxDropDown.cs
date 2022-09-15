using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.Editors;

namespace DevComponents.DotNetBar.Controls;

[Designer(typeof(TextBoxDropDownDesigner))]
[ToolboxBitmap(typeof(TextBoxDropDown), "Controls.TextBoxDropDown.ico")]
[ToolboxItem(true)]
[DefaultProperty("Text")]
[DefaultBindingProperty("Text")]
[DefaultEvent("TextChanged")]
public class TextBoxDropDown : PopupItemControl, ICommandSource, IInputButtonControl
{
	private TextBoxX textBoxX_0;

	private ButtonItem buttonItem_0;

	private static string string_0 = "sysPopupItemContainer";

	private static string string_1 = "sysPopupControlContainer";

	private Color color_0 = ColorScheme.GetColor(16777096);

	private bool bool_5;

	private CancelEventHandler cancelEventHandler_0;

	private CancelEventHandler cancelEventHandler_1;

	private EventHandler eventHandler_5;

	private EventHandler eventHandler_6;

	private EventHandler eventHandler_7;

	private EventHandler eventHandler_8;

	private ElementStyle elementStyle_0 = new ElementStyle();

	private InputButtonSettings inputButtonSettings_0;

	private InputButtonSettings inputButtonSettings_1;

	private InputButtonSettings inputButtonSettings_2;

	private InputButtonSettings inputButtonSettings_3;

	private VisualGroup visualGroup_0;

	private bool bool_6;

	private bool bool_7;

	private Control control_0;

	private bool bool_8;

	private DateTime dateTime_0 = DateTime.MinValue;

	private Control control_1;

	private ICommand icommand_0;

	private object object_0;

	[Description("Indicates whether FocusHighlightColor is used as background color to highlight text box when it has input focus.")]
	[Category("Appearance")]
	[DefaultValue(false)]
	[Browsable(true)]
	public bool FocusHighlightEnabled
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
				textBoxX_0.FocusHighlightEnabled = value;
				if (((Control)this).get_Focused())
				{
					((Control)this).Invalidate(true);
				}
			}
		}
	}

	[Description("Indicates color used as background color to highlight text box when it has input focus and focus highlight is enabled.")]
	[Category("Appearance")]
	[Browsable(true)]
	public Color FocusHighlightColor
	{
		get
		{
			return color_0;
		}
		set
		{
			if (color_0 != value)
			{
				color_0 = value;
				textBoxX_0.FocusHighlightColor = value;
				if (((Control)this).get_Focused())
				{
					((Control)this).Invalidate(true);
				}
			}
		}
	}

	[Category("Style")]
	[Description("Gets or sets control background style.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ElementStyle BackgroundStyle => elementStyle_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Buttons")]
	[Description("Describes the settings for the button that shows drop-down when clicked.")]
	public InputButtonSettings ButtonDropDown => inputButtonSettings_0;

	[Description("Describes the settings for the button that clears the content of the control when clicked.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Buttons")]
	public InputButtonSettings ButtonClear => inputButtonSettings_1;

	[Category("Buttons")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Describes the settings for the custom button that can execute an custom action of your choosing when clicked.")]
	public InputButtonSettings ButtonCustom => inputButtonSettings_2;

	[Category("Buttons")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Describes the settings for the custom button that can execute an custom action of your choosing when clicked.")]
	public InputButtonSettings ButtonCustom2 => inputButtonSettings_3;

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

	[DefaultValue(null)]
	[Description("Indicates reference of the control that will be displayed on popup that is shown when drop-down button is clicked.")]
	public Control DropDownControl
	{
		get
		{
			return control_1;
		}
		set
		{
			control_1 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public SubItemsCollection DropDownItems => buttonItem_0.SubItems;

	private bool Boolean_1
	{
		get
		{
			if ((inputButtonSettings_2 != null && inputButtonSettings_2.Visible) || (inputButtonSettings_3 != null && inputButtonSettings_3.Visible) || (inputButtonSettings_0 != null && inputButtonSettings_0.Visible))
			{
				return true;
			}
			if (inputButtonSettings_1 != null)
			{
				return inputButtonSettings_1.Visible;
			}
			return false;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public TextBox TextBox => (TextBox)(object)textBoxX_0;

	[DefaultValue(true)]
	[Description("Indicates whether watermark text is displayed when control is empty.")]
	public virtual bool WatermarkEnabled
	{
		get
		{
			return textBoxX_0.WatermarkEnabled;
		}
		set
		{
			textBoxX_0.WatermarkEnabled = value;
			((Control)this).Invalidate(true);
		}
	}

	[Category("Appearance")]
	[DefaultValue("")]
	[Browsable(true)]
	[Description("Indicates watermark text displayed inside of the control when Text is not set and control does not have input focus.")]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Localizable(true)]
	public string WatermarkText
	{
		get
		{
			return textBoxX_0.WatermarkText;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			textBoxX_0.WatermarkText = value;
			((Control)this).Invalidate(true);
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(null)]
	[Description("Indicates watermark font.")]
	public Font WatermarkFont
	{
		get
		{
			return textBoxX_0.WatermarkFont;
		}
		set
		{
			textBoxX_0.WatermarkFont = value;
			((Control)this).Invalidate(true);
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates watermark text color.")]
	public Color WatermarkColor
	{
		get
		{
			return textBoxX_0.WatermarkColor;
		}
		set
		{
			textBoxX_0.WatermarkColor = value;
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
			return textBoxX_0.WatermarkBehavior;
		}
		set
		{
			textBoxX_0.WatermarkBehavior = value;
			((Control)this).Invalidate(true);
		}
	}

	[DefaultValue(null)]
	[Description("Indicates the command assigned to the item.")]
	[Category("Commands")]
	public Command Command
	{
		get
		{
			return (Command)((ICommandSource)this).Command;
		}
		set
		{
			((ICommandSource)this).Command = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	ICommand ICommandSource.Command
	{
		get
		{
			return icommand_0;
		}
		set
		{
			bool flag = false;
			if (icommand_0 != value)
			{
				flag = true;
			}
			if (icommand_0 != null)
			{
				CommandManager.UnRegisterCommandSource(this, icommand_0);
			}
			icommand_0 = value;
			if (value != null)
			{
				CommandManager.RegisterCommand(this, value);
			}
			if (flag)
			{
				OnCommandChanged();
			}
		}
	}

	[Category("Commands")]
	[Description("Indicates user defined data value that can be passed to the command when it is executed.")]
	[DefaultValue(null)]
	[Localizable(true)]
	[Browsable(true)]
	[TypeConverter(typeof(StringConverter))]
	public object CommandParameter
	{
		get
		{
			return object_0;
		}
		set
		{
			object_0 = value;
		}
	}

	[DefaultValue("Indicates text as it is currently displayed to the user")]
	[Bindable(true)]
	[Localizable(true)]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Category("Appearance")]
	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)textBoxX_0).set_Text(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public int PreferredHeight
	{
		get
		{
			int preferredHeight = ((TextBoxBase)textBoxX_0).get_PreferredHeight();
			ElementStyle elementStyle = method_20();
			return preferredHeight + Class52.smethod_2(elementStyle);
		}
	}

	[Browsable(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Indicates custom StringCollection to use when the AutoCompleteSource property is set to CustomSource.")]
	[Localizable(true)]
	public AutoCompleteStringCollection AutoCompleteCustomSource
	{
		get
		{
			return ((TextBox)textBoxX_0).get_AutoCompleteCustomSource();
		}
		set
		{
			((TextBox)textBoxX_0).set_AutoCompleteCustomSource(value);
		}
	}

	[DefaultValue(0)]
	[Description("Gets or sets an option that controls how automatic completion works for the TextBox.")]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	public AutoCompleteMode AutoCompleteMode
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return ((TextBox)textBoxX_0).get_AutoCompleteMode();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			((TextBox)textBoxX_0).set_AutoCompleteMode(value);
		}
	}

	[Description("Gets or sets a value specifying the source of complete strings used for automatic completion.")]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	[DefaultValue(128)]
	[TypeConverter(typeof(Class189))]
	public AutoCompleteSource AutoCompleteSource
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return ((TextBox)textBoxX_0).get_AutoCompleteSource();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			((TextBox)textBoxX_0).set_AutoCompleteSource(value);
		}
	}

	[DefaultValue(0)]
	[Category("Behavior")]
	[Description("Indicates whether the TextBox control modifies the case of characters as they are typed.")]
	public CharacterCasing CharacterCasing
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return ((TextBox)textBoxX_0).get_CharacterCasing();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			((TextBox)textBoxX_0).set_CharacterCasing(value);
		}
	}

	[DefaultValue('\0')]
	[Description("Gets or sets the character used to mask characters of a password in a single-line TextBox control.")]
	[Category("Behavior")]
	[Localizable(true)]
	[RefreshProperties(RefreshProperties.Repaint)]
	public char PasswordChar
	{
		get
		{
			return ((TextBox)textBoxX_0).get_PasswordChar();
		}
		set
		{
			((TextBox)textBoxX_0).set_PasswordChar(value);
		}
	}

	[Localizable(true)]
	[Description("Indicates how text is aligned in a TextBox control.")]
	[Category("Appearance")]
	[DefaultValue(0)]
	public HorizontalAlignment TextAlign
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return ((TextBox)textBoxX_0).get_TextAlign();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			((TextBox)textBoxX_0).set_TextAlign(value);
		}
	}

	[Description("Gets or sets a value indicating whether the text in the TextBox control should appear as the default password character.")]
	[Category("Behavior")]
	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.Repaint)]
	public bool UseSystemPasswordChar
	{
		get
		{
			return ((TextBox)textBoxX_0).get_UseSystemPasswordChar();
		}
		set
		{
			((TextBox)textBoxX_0).set_UseSystemPasswordChar(value);
		}
	}

	[Description("Gets or sets a value indicating whether the selected text in the text box control remains highlighted when the control loses focus.")]
	[DefaultValue(true)]
	[Category("Behavior")]
	public bool HideSelection
	{
		get
		{
			return ((TextBoxBase)textBoxX_0).get_HideSelection();
		}
		set
		{
			((TextBoxBase)textBoxX_0).set_HideSelection(value);
		}
	}

	[Description("Gets or sets the maximum number of characters the user can type or paste into the text box control.")]
	[DefaultValue(32767)]
	[Category("Behavior")]
	[Localizable(true)]
	public virtual int MaxLength
	{
		get
		{
			return ((TextBoxBase)textBoxX_0).get_MaxLength();
		}
		set
		{
			((TextBoxBase)textBoxX_0).set_MaxLength(value);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool Modified
	{
		get
		{
			return ((TextBoxBase)textBoxX_0).get_Modified();
		}
		set
		{
			((TextBoxBase)textBoxX_0).set_Modified(value);
		}
	}

	[RefreshProperties(RefreshProperties.Repaint)]
	[Category("Behavior")]
	[DefaultValue(false)]
	[Description("Gets or sets a value indicating whether text in the text box is read-only.")]
	public bool ReadOnly
	{
		get
		{
			return ((TextBoxBase)textBoxX_0).get_ReadOnly();
		}
		set
		{
			((TextBoxBase)textBoxX_0).set_ReadOnly(value);
		}
	}

	[Browsable(false)]
	[Category("Appearance")]
	[Description("Gets or sets a value indicating the currently selected text in the control.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string SelectedText
	{
		get
		{
			return ((TextBoxBase)textBoxX_0).get_SelectedText();
		}
		set
		{
			((TextBoxBase)textBoxX_0).set_SelectedText(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Category("Appearance")]
	[Browsable(false)]
	[Description("Gets or sets the number of characters selected in the text box.")]
	public virtual int SelectionLength
	{
		get
		{
			return ((TextBoxBase)textBoxX_0).get_SelectionLength();
		}
		set
		{
			((TextBoxBase)textBoxX_0).set_SelectionLength(value);
		}
	}

	[Category("Appearance")]
	[Description("Gets or sets the starting point of text selected in the text box.")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int SelectionStart
	{
		get
		{
			return ((TextBoxBase)textBoxX_0).get_SelectionStart();
		}
		set
		{
			((TextBoxBase)textBoxX_0).set_SelectionStart(value);
		}
	}

	[Browsable(false)]
	public virtual int TextLength => ((TextBoxBase)textBoxX_0).get_TextLength();

	public event CancelEventHandler ButtonClearClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_0, value);
		}
	}

	public event CancelEventHandler ButtonDropDownClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_1 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_1 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_1, value);
		}
	}

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

	[Description("Occurs when the text alignment is changed.")]
	public event EventHandler TextAlignChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_7 = (EventHandler)Delegate.Combine(eventHandler_7, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_7 = (EventHandler)Delegate.Remove(eventHandler_7, value);
		}
	}

	public event EventHandler ModifiedChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_8 = (EventHandler)Delegate.Combine(eventHandler_8, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_8 = (EventHandler)Delegate.Remove(eventHandler_8, value);
		}
	}

	public TextBoxDropDown()
	{
		((Control)this).SetStyle((ControlStyles)512, false);
		textBoxX_0 = new TextBoxX();
		((Control)this).set_BackColor(SystemColors.Window);
		method_11();
	}

	private void method_11()
	{
		elementStyle_0.method_4(base.ColorScheme);
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		inputButtonSettings_2 = new InputButtonSettings(this);
		inputButtonSettings_3 = new InputButtonSettings(this);
		inputButtonSettings_1 = new InputButtonSettings(this);
		inputButtonSettings_0 = new InputButtonSettings(this);
		method_16();
		textBoxX_0.BorderStyle = (BorderStyle)0;
		((Control)textBoxX_0).add_TextChanged((EventHandler)textBoxX_0_TextChanged);
		((TextBox)textBoxX_0).add_TextAlignChanged((EventHandler)textBoxX_0_TextAlignChanged);
		((Control)textBoxX_0).add_SizeChanged((EventHandler)textBoxX_0_SizeChanged);
		((TextBoxBase)textBoxX_0).add_ModifiedChanged((EventHandler)textBoxX_0_ModifiedChanged);
		((Control)this).get_Controls().Add((Control)(object)textBoxX_0);
	}

	private void textBoxX_0_ModifiedChanged(object sender, EventArgs e)
	{
		OnModifiedChanged(e);
	}

	protected virtual void OnModifiedChanged(EventArgs e)
	{
		eventHandler_8?.Invoke(this, e);
	}

	private void textBoxX_0_SizeChanged(object sender, EventArgs e)
	{
		if (!bool_7)
		{
			method_23();
		}
	}

	private void textBoxX_0_TextChanged(object sender, EventArgs e)
	{
		((Control)this).set_Text(((Control)textBoxX_0).get_Text());
		ExecuteCommand();
	}

	private void textBoxX_0_TextAlignChanged(object sender, EventArgs e)
	{
		OnTextAlignChanged(e);
	}

	protected virtual void OnTextAlignChanged(EventArgs e)
	{
		eventHandler_7?.Invoke(this, e);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFocusHighlightColor()
	{
		return !color_0.Equals((object?)ColorScheme.GetColor(16777096));
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void ResetFocusHighlightColor()
	{
		FocusHighlightColor = ColorScheme.GetColor(16777096);
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
		visualGroup_0.InvalidateArrange();
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

	void IInputButtonControl.InputButtonSettingsChanged(InputButtonSettings button)
	{
		OnInputButtonSettingsChanged(button);
	}

	protected virtual void OnInputButtonSettingsChanged(InputButtonSettings inputButtonSettings)
	{
		method_12();
	}

	private void method_12()
	{
		RecreateButtons();
		visualGroup_0.InvalidateArrange();
		((Control)this).Invalidate();
	}

	protected virtual void RecreateButtons()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		VisualItem[] items = method_15();
		VisualGroup visualGroup = visualGroup_0;
		VisualItem[] array = new VisualItem[visualGroup.Items.Count];
		visualGroup.Items.method_0(array);
		VisualItem[] array2 = array;
		foreach (VisualItem visualItem in array2)
		{
			if (visualItem.Enum31_0 == Enum31.const_1)
			{
				visualGroup.Items.Remove(visualItem);
				if (visualItem == inputButtonSettings_2.ItemReference)
				{
					visualItem.MouseUp -= new MouseEventHandler(method_13);
				}
				else if (visualItem == inputButtonSettings_3.ItemReference)
				{
					visualItem.MouseUp -= new MouseEventHandler(method_14);
				}
			}
		}
		visualGroup.Items.AddRange(items);
	}

	private void method_13(object sender, MouseEventArgs e)
	{
		if (inputButtonSettings_2.ItemReference.RenderBounds.Contains(e.get_X(), e.get_Y()))
		{
			OnButtonCustomClick((EventArgs)(object)e);
		}
	}

	protected virtual void OnButtonCustomClick(EventArgs e)
	{
		if (eventHandler_5 != null)
		{
			eventHandler_5(this, e);
		}
	}

	private void method_14(object sender, MouseEventArgs e)
	{
		if (inputButtonSettings_3.ItemReference.RenderBounds.Contains(e.get_X(), e.get_Y()))
		{
			OnButtonCustom2Click((EventArgs)(object)e);
		}
	}

	protected virtual void OnButtonCustom2Click(EventArgs e)
	{
		if (eventHandler_6 != null)
		{
			eventHandler_6(this, e);
		}
	}

	private VisualItem[] method_15()
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
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		SortedList sortedList = new SortedList(4);
		if (inputButtonSettings_2.Visible)
		{
			VisualItem visualItem = CreateButton(inputButtonSettings_2);
			if (inputButtonSettings_2.ItemReference != null)
			{
				inputButtonSettings_2.ItemReference.MouseUp -= new MouseEventHandler(method_13);
			}
			inputButtonSettings_2.ItemReference = visualItem;
			visualItem.MouseUp += new MouseEventHandler(method_13);
			visualItem.Enabled = inputButtonSettings_2.Enabled;
			sortedList.Add(inputButtonSettings_2, visualItem);
		}
		if (inputButtonSettings_3.Visible)
		{
			VisualItem visualItem2 = CreateButton(inputButtonSettings_3);
			if (inputButtonSettings_2.ItemReference != null)
			{
				inputButtonSettings_2.ItemReference.MouseUp -= new MouseEventHandler(method_14);
			}
			inputButtonSettings_3.ItemReference = visualItem2;
			visualItem2.MouseUp += new MouseEventHandler(method_14);
			visualItem2.Enabled = inputButtonSettings_3.Enabled;
			sortedList.Add(inputButtonSettings_3, visualItem2);
		}
		if (inputButtonSettings_1.Visible)
		{
			VisualItem visualItem3 = CreateButton(inputButtonSettings_1);
			if (inputButtonSettings_1.ItemReference != null)
			{
				inputButtonSettings_1.ItemReference.Click -= method_27;
			}
			inputButtonSettings_1.ItemReference = visualItem3;
			visualItem3.MouseUp += new MouseEventHandler(method_27);
			sortedList.Add(inputButtonSettings_1, visualItem3);
		}
		if (inputButtonSettings_0.Visible)
		{
			VisualItem visualItem4 = CreateButton(inputButtonSettings_0);
			if (inputButtonSettings_0.ItemReference != null)
			{
				inputButtonSettings_0.ItemReference.MouseDown -= new MouseEventHandler(method_25);
			}
			inputButtonSettings_0.ItemReference = visualItem4;
			visualItem4.MouseDown += new MouseEventHandler(method_25);
			sortedList.Add(inputButtonSettings_0, visualItem4);
		}
		return sortedList;
	}

	protected virtual VisualItem CreateButton(InputButtonSettings buttonSettings)
	{
		VisualItem visualItem = null;
		if (buttonSettings == inputButtonSettings_0)
		{
			visualItem = new VisualDropDownButton();
			ApplyButtonSettings(buttonSettings, visualItem as VisualButton);
		}
		else
		{
			visualItem = new VisualCustomButton();
			ApplyButtonSettings(buttonSettings, visualItem as VisualButton);
		}
		VisualButton visualButton = visualItem as VisualButton;
		visualButton.ClickAutoRepeat = false;
		if (buttonSettings == inputButtonSettings_1 && buttonSettings.Image == null)
		{
			visualButton.Image = (Image)(object)Class109.smethod_67("SystemImages.DateReset.png");
		}
		return visualItem;
	}

	protected virtual void ApplyButtonSettings(InputButtonSettings buttonSettings, VisualButton button)
	{
		button.Text = buttonSettings.Text;
		button.Image = buttonSettings.Image;
		button.Enum31_0 = Enum31.const_1;
		button.Enabled = buttonSettings.Enabled;
	}

	private void method_16()
	{
		VisualGroup visualGroup = new VisualGroup();
		visualGroup.HorizontalItemSpacing = 1;
		visualGroup.ArrangeInvalid += method_18;
		visualGroup.RenderInvalid += method_17;
		visualGroup_0 = visualGroup;
	}

	private void method_17(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}

	private void method_18(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}

	private PaintInfo method_19(Graphics graphics_0)
	{
		PaintInfo paintInfo = new PaintInfo();
		paintInfo.Graphics = graphics_0;
		paintInfo.DefaultFont = ((Control)this).get_Font();
		paintInfo.ForeColor = ((Control)this).get_ForeColor();
		paintInfo.RenderOffset = default(Point);
		Size size = ((Control)this).get_Size();
		ElementStyle elementStyle = method_20();
		size.Height -= Class52.smethod_8(elementStyle, eSpacePart.Border) + Class52.smethod_10(elementStyle, eSpacePart.Border) + 2;
		size.Width -= Class52.smethod_4(elementStyle, eSpacePart.Border) + Class52.smethod_6(elementStyle, eSpacePart.Border) + 2;
		paintInfo.AvailableSize = size;
		paintInfo.ParentEnabled = ((Control)this).get_Enabled();
		paintInfo.MouseOver = bool_6 || ((Control)this).get_Focused();
		return paintInfo;
	}

	private ElementStyle method_20()
	{
		elementStyle_0.method_4(GetColorScheme());
		return ElementStyleDisplay.smethod_5(elementStyle_0);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnPaint(e);
		Graphics graphics = e.get_Graphics();
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		bool enabled = ((Control)this).get_Enabled();
		if (!((Control)this).get_Enabled())
		{
			e.get_Graphics().FillRectangle(SystemBrushes.get_Control(), clientRectangle);
		}
		else
		{
			SolidBrush val = new SolidBrush(((Control)this).get_BackColor());
			try
			{
				e.get_Graphics().FillRectangle((Brush)(object)val, clientRectangle);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		ElementStyle elementStyle = method_20();
		if (elementStyle.Custom)
		{
			SmoothingMode smoothingMode = graphics.get_SmoothingMode();
			if (base.AntiAlias)
			{
				graphics.set_SmoothingMode((SmoothingMode)4);
			}
			ElementStyleDisplayInfo e2 = new ElementStyleDisplayInfo(elementStyle, graphics, clientRectangle);
			if (!enabled)
			{
				ElementStyleDisplay.PaintBorder(e2);
			}
			else
			{
				ElementStyleDisplay.Paint(e2);
			}
			if (base.AntiAlias)
			{
				graphics.set_SmoothingMode(smoothingMode);
			}
		}
		method_21(graphics);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackColor()
	{
		return ((Control)this).get_BackColor() != SystemColors.Window;
	}

	protected override void OnBackColorChanged(EventArgs e)
	{
		((Control)this).OnBackColorChanged(e);
		((Control)textBoxX_0).set_BackColor(((Control)this).get_BackColor());
	}

	private void method_21(Graphics graphics_0)
	{
		PaintInfo paintInfo_ = method_19(graphics_0);
		if (!visualGroup_0.IsLayoutValid)
		{
			method_24(paintInfo_);
		}
		ElementStyle elementStyle_ = method_20();
		visualGroup_0.RenderBounds = method_22(elementStyle_);
		visualGroup_0.vmethod_14(paintInfo_);
	}

	private Rectangle method_22(ElementStyle elementStyle_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Control)this).get_RightToLeft() == 1)
		{
			return new Rectangle(Class52.smethod_4(elementStyle_1, eSpacePart.Border) + 1, Class52.smethod_8(elementStyle_1, eSpacePart.Border) + 1, visualGroup_0.Size.Width, visualGroup_0.Size.Height);
		}
		return new Rectangle(((Control)this).get_Width() - (Class52.smethod_6(elementStyle_1, eSpacePart.Border) + 1) - visualGroup_0.Size.Width, Class52.smethod_8(elementStyle_1, eSpacePart.Border) + 1, visualGroup_0.Size.Width, visualGroup_0.Size.Height);
	}

	protected override void OnResize(EventArgs e)
	{
		visualGroup_0.InvalidateArrange();
		method_23();
		((Control)this).Invalidate();
		((Control)this).OnResize(e);
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((Control)textBoxX_0).Focus();
		((Control)this).OnGotFocus(e);
	}

	protected override void OnRightToLeftChanged(EventArgs e)
	{
		visualGroup_0.InvalidateArrange();
		method_23();
		((Control)this).Invalidate();
		((Control)this).OnRightToLeftChanged(e);
	}

	protected override void OnFontChanged(EventArgs e)
	{
		visualGroup_0.InvalidateArrange();
		method_23();
		((Control)this).Invalidate();
		base.OnFontChanged(e);
	}

	private void method_23()
	{
		Graphics val = Class109.smethod_68((Control)(object)this);
		try
		{
			method_24(method_19(val));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void method_24(PaintInfo paintInfo_0)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		if (bool_7)
		{
			return;
		}
		bool_7 = true;
		try
		{
			if (!visualGroup_0.IsLayoutValid)
			{
				visualGroup_0.PerformLayout(paintInfo_0);
			}
			ElementStyle elementStyle_ = method_20();
			Rectangle bounds = Class52.smethod_12(elementStyle_, ((Control)this).get_ClientRectangle());
			if (Boolean_1)
			{
				Rectangle rectangle = method_22(elementStyle_);
				if ((int)((Control)this).get_RightToLeft() == 1)
				{
					bounds.X += rectangle.Right;
					bounds.Width -= rectangle.Right;
				}
				else
				{
					bounds.Width -= bounds.Right - rectangle.X;
				}
			}
			if (((TextBoxBase)textBoxX_0).get_PreferredHeight() < bounds.Height)
			{
				bounds.Y += (bounds.Height - ((TextBoxBase)textBoxX_0).get_PreferredHeight()) / 2;
			}
			((Control)textBoxX_0).set_Bounds(bounds);
		}
		finally
		{
			bool_7 = false;
		}
	}

	private void method_25(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576 && (!(dateTime_0 != DateTime.MinValue) || DateTime.Now.Subtract(dateTime_0).TotalMilliseconds >= 250.0))
		{
			ShowDropDown();
		}
		else
		{
			dateTime_0 = DateTime.MinValue;
		}
	}

	public void ShowDropDown()
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		if ((control_1 == null && buttonItem_0.SubItems.Count == 0) || bool_8 || buttonItem_0.Expanded)
		{
			return;
		}
		bool_8 = true;
		try
		{
			ControlContainerItem controlContainerItem = null;
			ItemContainer itemContainer = null;
			if (control_1 != null)
			{
				itemContainer = new ItemContainer();
				itemContainer.Name = string_0;
				controlContainerItem = new ControlContainerItem(string_1);
				itemContainer.SubItems.Add(controlContainerItem);
				buttonItem_0.SubItems.Insert(0, itemContainer);
			}
			CancelEventArgs cancelEventArgs = new CancelEventArgs();
			OnButtonDropDownClick(cancelEventArgs);
			if (!cancelEventArgs.Cancel && buttonItem_0.SubItems.Count != 0)
			{
				if (control_1 != null)
				{
					control_0 = control_1.get_Parent();
					controlContainerItem.Control = control_1;
				}
				buttonItem_0.method_4(((Control)this).get_ClientRectangle());
				if ((int)((Control)this).get_RightToLeft() == 0)
				{
					Point point = new Point(((Control)this).get_Width() - buttonItem_0.PopupSize.Width, ((Control)this).get_Height());
					Class273 @class = Class109.smethod_53((Control)(object)this);
					Point point2 = ((Control)this).PointToScreen(point);
					if (@class != null && @class.rectangle_1.X > point2.X)
					{
						point.X = 0;
					}
					buttonItem_0.PopupLocation = point;
				}
				buttonItem_0.Expanded = !buttonItem_0.Expanded;
			}
			else if (itemContainer != null)
			{
				buttonItem_0.SubItems.Remove(itemContainer);
			}
		}
		finally
		{
			bool_8 = false;
		}
	}

	public void CloseDropDown()
	{
		if (buttonItem_0.Expanded)
		{
			buttonItem_0.Expanded = false;
		}
	}

	private void method_26(object sender, EventArgs e)
	{
		dateTime_0 = DateTime.Now;
		ItemContainer itemContainer = null;
		if (buttonItem_0.SubItems.Contains(string_0))
		{
			itemContainer = buttonItem_0.SubItems[string_0] as ItemContainer;
		}
		if (itemContainer == null)
		{
			return;
		}
		if (itemContainer.SubItems[string_1] is ControlContainerItem controlContainerItem)
		{
			controlContainerItem.Control = null;
			itemContainer.SubItems.Remove(controlContainerItem);
			if (control_1 != null)
			{
				control_1.set_Parent(control_0);
				control_0 = null;
			}
		}
		buttonItem_0.SubItems.Remove(itemContainer);
	}

	private void method_27(object sender, EventArgs e)
	{
		CancelEventArgs cancelEventArgs = new CancelEventArgs();
		OnButtonClearClick(cancelEventArgs);
		if (!cancelEventArgs.Cancel)
		{
			((Control)textBoxX_0).set_Text("");
		}
	}

	protected virtual void OnButtonClearClick(CancelEventArgs e)
	{
		if (cancelEventHandler_0 != null)
		{
			cancelEventHandler_0(this, e);
		}
	}

	protected virtual void OnButtonDropDownClick(CancelEventArgs e)
	{
		if (cancelEventHandler_1 != null)
		{
			cancelEventHandler_1(this, e);
		}
	}

	protected override PopupItem CreatePopupItem()
	{
		ButtonItem buttonItem = new ButtonItem("sysPopupProvider");
		buttonItem.PopupFinalized += method_26;
		buttonItem_0 = buttonItem;
		return buttonItem;
	}

	protected override void RecalcSize()
	{
	}

	public override void PerformClick()
	{
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (Boolean_1)
		{
			visualGroup_0.vmethod_2(e);
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		if (Boolean_1)
		{
			visualGroup_0.vmethod_1();
		}
		((Control)this).OnMouseLeave(e);
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
		((Control)this).OnMouseUp(e);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeWatermarkColor()
	{
		return textBoxX_0.WatermarkColor != SystemColors.GrayText;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetWatermarkColor()
	{
		WatermarkColor = SystemColors.GrayText;
	}

	protected virtual void ExecuteCommand()
	{
		if (icommand_0 != null)
		{
			CommandManager.smethod_0(this);
		}
	}

	protected virtual void OnCommandChanged()
	{
	}

	public override string ToString()
	{
		return ((object)textBoxX_0).ToString();
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		Size preferredSize = ((Control)textBoxX_0).GetPreferredSize(proposedSize);
		preferredSize.Height = PreferredHeight;
		return preferredSize;
	}

	public void AppendText(string text)
	{
		((TextBoxBase)textBoxX_0).AppendText(text);
	}

	public void Clear()
	{
		((TextBoxBase)textBoxX_0).Clear();
	}

	public void ClearUndo()
	{
		((TextBoxBase)textBoxX_0).ClearUndo();
	}

	public void Copy()
	{
		((TextBoxBase)textBoxX_0).Copy();
	}

	public void Cut()
	{
		((TextBoxBase)textBoxX_0).Cut();
	}

	public void DeselectAll()
	{
		((TextBoxBase)textBoxX_0).DeselectAll();
	}

	public virtual char GetCharFromPosition(Point pt)
	{
		return ((TextBoxBase)textBoxX_0).GetCharFromPosition(pt);
	}

	public virtual int GetCharIndexFromPosition(Point pt)
	{
		return ((TextBoxBase)textBoxX_0).GetCharIndexFromPosition(pt);
	}

	public int GetFirstCharIndexFromLine(int lineNumber)
	{
		return ((TextBoxBase)textBoxX_0).GetFirstCharIndexFromLine(lineNumber);
	}

	public int GetFirstCharIndexOfCurrentLine()
	{
		return ((TextBoxBase)textBoxX_0).GetFirstCharIndexOfCurrentLine();
	}

	public virtual int GetLineFromCharIndex(int index)
	{
		return ((TextBoxBase)textBoxX_0).GetLineFromCharIndex(index);
	}

	public virtual Point GetPositionFromCharIndex(int index)
	{
		return ((TextBoxBase)textBoxX_0).GetPositionFromCharIndex(index);
	}

	public void Paste()
	{
		((TextBoxBase)textBoxX_0).Paste();
	}

	public void Select(int start, int length)
	{
		((TextBoxBase)textBoxX_0).Select(start, length);
	}

	public void SelectAll()
	{
		((TextBoxBase)textBoxX_0).SelectAll();
	}

	public void Undo()
	{
		((TextBoxBase)textBoxX_0).Undo();
	}

	public void Paste(string text)
	{
		((TextBox)textBoxX_0).Paste(text);
	}
}
