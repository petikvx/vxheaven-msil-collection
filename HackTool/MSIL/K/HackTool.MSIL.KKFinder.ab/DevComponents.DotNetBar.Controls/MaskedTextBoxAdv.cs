using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.TextMarkup;
using DevComponents.Editors;

namespace DevComponents.DotNetBar.Controls;

[ToolboxItem(true)]
[Designer(typeof(MaskedTextBoxAdvDesigner))]
[DefaultEvent("MaskInputRejected")]
[DefaultProperty("Mask")]
[ToolboxBitmap(typeof(MaskedTextBoxAdv), "Controls.MaskedTextBoxAdv.ico")]
[DefaultBindingProperty("Text")]
public class MaskedTextBoxAdv : PopupItemControl, ICommandSource, IInputButtonControl
{
	private class Class196 : MaskedTextBox
	{
		private bool bool_0;

		private bool bool_1;

		private Color color_0 = Color.Empty;

		private bool Boolean_0
		{
			get
			{
				MaskedTextBoxAdv maskedTextBoxAdv_ = MaskedTextBoxAdv_0;
				if (maskedTextBoxAdv_ == null)
				{
					return false;
				}
				if (!maskedTextBoxAdv_.WatermarkEnabled)
				{
					return false;
				}
				if (maskedTextBoxAdv_.WatermarkBehavior == eWatermarkBehavior.HideOnFocus)
				{
					if (!bool_1 && ((Control)this).get_Enabled() && ((Control)this).get_Text() != null && ((Control)this).get_Text().Length == 0)
					{
						return maskedTextBoxAdv_.WatermarkText.Length > 0;
					}
					return false;
				}
				if (((Control)this).get_Enabled() && ((Control)this).get_Text() != null && ((Control)this).get_Text().Length == 0)
				{
					return maskedTextBoxAdv_.WatermarkText.Length > 0;
				}
				return false;
			}
		}

		private MaskedTextBoxAdv MaskedTextBoxAdv_0 => ((Control)this).get_Parent() as MaskedTextBoxAdv;

		private void method_0()
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Invalid comparison between Unknown and I4
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Invalid comparison between Unknown and I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Invalid comparison between Unknown and I4
			MaskedTextBoxAdv maskedTextBoxAdv_ = MaskedTextBoxAdv_0;
			if (maskedTextBoxAdv_ == null)
			{
				return;
			}
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				if (maskedTextBoxAdv_.class261_0 != null)
				{
					Class263 d = maskedTextBoxAdv_.method_31(val);
					maskedTextBoxAdv_.class261_0.Render(d);
					return;
				}
				eTextFormat eTextFormat = eTextFormat.Default;
				if ((int)((Control)this).get_RightToLeft() == 1)
				{
					eTextFormat |= eTextFormat.RightToLeft;
				}
				if ((int)((MaskedTextBox)this).get_TextAlign() == 0)
				{
					eTextFormat = eTextFormat;
				}
				else if ((int)((MaskedTextBox)this).get_TextAlign() == 1)
				{
					eTextFormat |= eTextFormat.Right;
				}
				else if ((int)((MaskedTextBox)this).get_TextAlign() == 2)
				{
					eTextFormat |= eTextFormat.HorizontalCenter;
				}
				eTextFormat |= eTextFormat.EndEllipsis;
				eTextFormat |= eTextFormat.WordBreak;
				Class55.smethod_1(val, maskedTextBoxAdv_.WatermarkText, (maskedTextBoxAdv_.WatermarkFont == null) ? ((Control)this).get_Font() : maskedTextBoxAdv_.WatermarkFont, maskedTextBoxAdv_.WatermarkColor, maskedTextBoxAdv_.method_30(), eTextFormat);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}

		protected override void OnTextChanged(EventArgs e)
		{
			((MaskedTextBox)this).OnTextChanged(e);
			MaskedTextBoxAdv maskedTextBoxAdv_ = MaskedTextBoxAdv_0;
			if (maskedTextBoxAdv_ != null && maskedTextBoxAdv_.WatermarkText.Length > 0)
			{
				((Control)this).Invalidate();
			}
		}

		protected override void WndProc(ref Message m)
		{
			((MaskedTextBox)this).WndProc(ref m);
			MaskedTextBoxAdv maskedTextBoxAdv_ = MaskedTextBoxAdv_0;
			if (maskedTextBoxAdv_ == null)
			{
				return;
			}
			switch (((Message)(ref m)).get_Msg())
			{
			case 15:
				if (Boolean_0)
				{
					method_0();
				}
				break;
			case 7:
				if (bool_0)
				{
					bool_0 = false;
					break;
				}
				bool_1 = true;
				if (maskedTextBoxAdv_.FocusHighlightEnabled && ((Control)this).get_Enabled())
				{
					color_0 = ((Control)this).get_BackColor();
					((Control)this).set_BackColor(maskedTextBoxAdv_.FocusHighlightColor);
					((Control)maskedTextBoxAdv_).set_BackColor(maskedTextBoxAdv_.FocusHighlightColor);
					((Control)maskedTextBoxAdv_).Invalidate(true);
				}
				break;
			case 8:
				if (!bool_1)
				{
					bool_0 = true;
					break;
				}
				bool_1 = false;
				if (((Control)this).get_Text() == null || ((Control)this).get_Text().Length == 0)
				{
					((Control)maskedTextBoxAdv_).Invalidate(true);
				}
				if (maskedTextBoxAdv_.FocusHighlightEnabled && !color_0.IsEmpty)
				{
					((Control)this).set_BackColor(color_0);
					((Control)maskedTextBoxAdv_).set_BackColor(color_0);
					((Control)maskedTextBoxAdv_).Invalidate(true);
				}
				break;
			}
		}
	}

	private MaskedTextBox maskedTextBox_0;

	private ButtonItem buttonItem_0;

	private static string string_0 = "sysPopupItemContainer";

	private static string string_1 = "sysPopupControlContainer";

	private Color color_0 = ColorScheme.GetColor(16777096);

	private bool bool_5;

	private string string_2 = "";

	private Font font_0;

	private Color color_1 = SystemColors.GrayText;

	private CancelEventHandler cancelEventHandler_0;

	private CancelEventHandler cancelEventHandler_1;

	private EventHandler eventHandler_5;

	private EventHandler eventHandler_6;

	private EventHandler eventHandler_7;

	private EventHandler eventHandler_8;

	private MaskInputRejectedEventHandler maskInputRejectedEventHandler_0;

	private EventHandler eventHandler_9;

	private TypeValidationEventHandler typeValidationEventHandler_0;

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

	private bool bool_9 = true;

	private eWatermarkBehavior eWatermarkBehavior_0;

	private Class261 class261_0;

	private ICommand icommand_0;

	private object object_0;

	[Category("Appearance")]
	[Description("Indicates whether FocusHighlightColor is used as background color to highlight text box when it has input focus.")]
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
				if (((Control)this).get_Focused())
				{
					((Control)this).Invalidate(true);
				}
			}
		}
	}

	[Category("Appearance")]
	[Description("Indicates color used as background color to highlight text box when it has input focus and focus highlight is enabled.")]
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
				if (((Control)this).get_Focused())
				{
					((Control)this).Invalidate(true);
				}
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	[Description("Gets or sets control background style.")]
	public ElementStyle BackgroundStyle => elementStyle_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Buttons")]
	[Description("Describes the settings for the button that shows drop-down when clicked.")]
	public InputButtonSettings ButtonDropDown => inputButtonSettings_0;

	[Description("Describes the settings for the button that clears the content of the control when clicked.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Buttons")]
	public InputButtonSettings ButtonClear => inputButtonSettings_1;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Buttons")]
	[Description("Describes the settings for the custom button that can execute an custom action of your choosing when clicked.")]
	public InputButtonSettings ButtonCustom => inputButtonSettings_2;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Describes the settings for the custom button that can execute an custom action of your choosing when clicked.")]
	[Category("Buttons")]
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public MaskedTextBox MaskedTextBox => maskedTextBox_0;

	[Description("Indicates whether watermark text is displayed when control is empty.")]
	[DefaultValue(true)]
	public virtual bool WatermarkEnabled
	{
		get
		{
			return bool_9;
		}
		set
		{
			bool_9 = value;
			((Control)this).Invalidate(true);
		}
	}

	[Description("Indicates watermark text displayed inside of the control when Text is not set and control does not have input focus.")]
	[Browsable(true)]
	[Category("Appearance")]
	[Localizable(true)]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[DefaultValue("")]
	public string WatermarkText
	{
		get
		{
			return string_2;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			string_2 = value;
			method_28();
			((Control)this).Invalidate(true);
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[Description("Indicates watermark font.")]
	[DefaultValue(null)]
	public Font WatermarkFont
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
			((Control)this).Invalidate(true);
		}
	}

	[Description("Indicates watermark text color.")]
	[Browsable(true)]
	[Category("Appearance")]
	public Color WatermarkColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates watermark hiding behaviour.")]
	[Category("Behavior")]
	[DefaultValue(eWatermarkBehavior.HideOnFocus)]
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

	[Category("Behavior")]
	[DefaultValue(true)]
	[Description("Indicates whether PromptChar can be entered as valid data by the user")]
	public bool AllowPromptAsInput
	{
		get
		{
			return maskedTextBox_0.get_AllowPromptAsInput();
		}
		set
		{
			maskedTextBox_0.set_AllowPromptAsInput(value);
		}
	}

	[RefreshProperties(RefreshProperties.Repaint)]
	[Description("Indicates whether the MaskedTextBox control accepts characters outside of the ASCII character set")]
	[DefaultValue(false)]
	[Category("Behavior")]
	public bool AsciiOnly
	{
		get
		{
			return maskedTextBox_0.get_AsciiOnly();
		}
		set
		{
			maskedTextBox_0.set_AsciiOnly(value);
		}
	}

	[Description("Indicates whether the masked text box control raises the system beep for each user key stroke that it rejects")]
	[DefaultValue(false)]
	[Category("Behavior")]
	public bool BeepOnError
	{
		get
		{
			return maskedTextBox_0.get_BeepOnError();
		}
		set
		{
			maskedTextBox_0.set_BeepOnError(value);
		}
	}

	[RefreshProperties(RefreshProperties.Repaint)]
	[Category("Behavior")]
	[Description("Indicates culture information associated with the masked text box.")]
	public CultureInfo Culture
	{
		get
		{
			return maskedTextBox_0.get_Culture();
		}
		set
		{
			maskedTextBox_0.set_Culture(value);
		}
	}

	[DefaultValue(2)]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Category("Behavior")]
	[Description("Indicates a value that determines whether literals and prompt characters are copied to the clipboard")]
	public MaskFormat CutCopyMaskFormat
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return maskedTextBox_0.get_CutCopyMaskFormat();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			maskedTextBox_0.set_CutCopyMaskFormat(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public IFormatProvider FormatProvider
	{
		get
		{
			return maskedTextBox_0.get_FormatProvider();
		}
		set
		{
			maskedTextBox_0.set_FormatProvider(value);
		}
	}

	[Description("Indicates whether the prompt characters in the input mask are hidden when the masked text box loses focus.")]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Category("Behavior")]
	[DefaultValue(false)]
	public bool HidePromptOnLeave
	{
		get
		{
			return maskedTextBox_0.get_HidePromptOnLeave();
		}
		set
		{
			maskedTextBox_0.set_HidePromptOnLeave(value);
		}
	}

	[Category("Behavior")]
	[Description("Indicates text insertion mode of the masked text box control.")]
	[DefaultValue(0)]
	public InsertKeyMode InsertKeyMode
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return maskedTextBox_0.get_InsertKeyMode();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			maskedTextBox_0.set_InsertKeyMode(value);
		}
	}

	[Localizable(true)]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Description("Indicates input mask to use at run time.")]
	[MergableProperty(false)]
	[Category("Behavior")]
	[DefaultValue("")]
	[Editor(typeof(MaskAdvPropertyEditor), typeof(UITypeEditor))]
	public string Mask
	{
		get
		{
			return maskedTextBox_0.get_Mask();
		}
		set
		{
			maskedTextBox_0.set_Mask(value);
		}
	}

	[Browsable(false)]
	public bool MaskCompleted => maskedTextBox_0.get_MaskCompleted();

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public MaskedTextProvider MaskedTextProvider => maskedTextBox_0.get_MaskedTextProvider();

	[Browsable(false)]
	public bool MaskFull => maskedTextBox_0.get_MaskFull();

	[DefaultValue('\0')]
	[Description("Indicates character to be displayed in substitute for user input.")]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Category("Behavior")]
	public char PasswordChar
	{
		get
		{
			return maskedTextBox_0.get_PasswordChar();
		}
		set
		{
			maskedTextBox_0.set_PasswordChar(value);
		}
	}

	[Localizable(true)]
	[Description("Indicates character used to represent the absence of user input in MaskedTextBox.")]
	[Category("Appearance")]
	[DefaultValue('_')]
	[RefreshProperties(RefreshProperties.Repaint)]
	public char PromptChar
	{
		get
		{
			return maskedTextBox_0.get_PromptChar();
		}
		set
		{
			maskedTextBox_0.set_PromptChar(value);
		}
	}

	[DefaultValue(false)]
	[Description("Indicates whether text in control is read only.")]
	[Category("Behavior")]
	public bool ReadOnly
	{
		get
		{
			return maskedTextBox_0.get_ReadOnly();
		}
		set
		{
			maskedTextBox_0.set_ReadOnly(value);
		}
	}

	[Category("Behavior")]
	[DefaultValue(false)]
	[Description("Indicates whether the parsing of user input should stop after the first invalid character is reached.")]
	public bool RejectInputOnFirstFailure
	{
		get
		{
			return maskedTextBox_0.get_RejectInputOnFirstFailure();
		}
		set
		{
			maskedTextBox_0.set_RejectInputOnFirstFailure(value);
		}
	}

	[Description("Indicates value that determines how an input character that matches the prompt character should be handled.")]
	[DefaultValue(true)]
	[Category("Behavior")]
	public bool ResetOnPrompt
	{
		get
		{
			return maskedTextBox_0.get_ResetOnPrompt();
		}
		set
		{
			maskedTextBox_0.set_ResetOnPrompt(value);
		}
	}

	[DefaultValue(true)]
	[Category("Behavior")]
	[Description("Indicates value that determines how a space input character should be handled.")]
	public bool ResetOnSpace
	{
		get
		{
			return maskedTextBox_0.get_ResetOnSpace();
		}
		set
		{
			maskedTextBox_0.set_ResetOnSpace(value);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string SelectedText
	{
		get
		{
			return ((TextBoxBase)maskedTextBox_0).get_SelectedText();
		}
		set
		{
			((TextBoxBase)maskedTextBox_0).set_SelectedText(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual int SelectionLength
	{
		get
		{
			return ((TextBoxBase)maskedTextBox_0).get_SelectionLength();
		}
		set
		{
			((TextBoxBase)maskedTextBox_0).set_SelectionLength(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public int SelectionStart
	{
		get
		{
			return ((TextBoxBase)maskedTextBox_0).get_SelectionStart();
		}
		set
		{
			((TextBoxBase)maskedTextBox_0).set_SelectionStart(value);
		}
	}

	[DefaultValue(true)]
	[Category("Behavior")]
	[Description("Indicates whether the defined shortcuts are enabled.")]
	public virtual bool ShortcutsEnabled
	{
		get
		{
			return ((TextBoxBase)maskedTextBox_0).get_ShortcutsEnabled();
		}
		set
		{
			((TextBoxBase)maskedTextBox_0).set_ShortcutsEnabled(value);
		}
	}

	[Description("MaskedTextBoxSkipLiterals")]
	[Category("CatBehavior")]
	[DefaultValue(true)]
	public bool SkipLiterals
	{
		get
		{
			return maskedTextBox_0.get_SkipLiterals();
		}
		set
		{
			maskedTextBox_0.set_SkipLiterals(value);
		}
	}

	[Localizable(true)]
	[Category("Appearance")]
	[DefaultValue("Indicates text as it is currently displayed to the user")]
	[Bindable(true)]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Editor("System.Windows.Forms.Design.MaskedTextBoxTextEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)maskedTextBox_0).set_Text(value);
		}
	}

	[Description("Indicates how text is aligned in a masked text box control.")]
	[Localizable(true)]
	[DefaultValue(0)]
	[Category("Appearance")]
	public HorizontalAlignment TextAlign
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return maskedTextBox_0.get_TextAlign();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			maskedTextBox_0.set_TextAlign(value);
		}
	}

	[Browsable(false)]
	public virtual int TextLength => ((TextBoxBase)maskedTextBox_0).get_TextLength();

	[Category("Behavior")]
	[RefreshProperties(RefreshProperties.Repaint)]
	[DefaultValue(2)]
	[Description("Indicates a value that determines whether literals and prompt characters are included in the formatted string.")]
	public MaskFormat TextMaskFormat
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return maskedTextBox_0.get_TextMaskFormat();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			maskedTextBox_0.set_TextMaskFormat(value);
		}
	}

	[DefaultValue(false)]
	[Category("Behavior")]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Description("Indicates whether the operating system-supplied password character should be used")]
	public bool UseSystemPasswordChar
	{
		get
		{
			return maskedTextBox_0.get_UseSystemPasswordChar();
		}
		set
		{
			maskedTextBox_0.set_UseSystemPasswordChar(value);
		}
	}

	[DefaultValue(null)]
	[Browsable(false)]
	public Type ValidatingType
	{
		get
		{
			return maskedTextBox_0.get_ValidatingType();
		}
		set
		{
			maskedTextBox_0.set_ValidatingType(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public int PreferredHeight
	{
		get
		{
			int preferredHeight = ((TextBoxBase)maskedTextBox_0).get_PreferredHeight();
			ElementStyle elementStyle = method_20();
			return preferredHeight + Class52.smethod_2(elementStyle);
		}
	}

	[Category("Commands")]
	[DefaultValue(null)]
	[Description("Indicates the command assigned to the item.")]
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
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

	[Browsable(true)]
	[Category("Commands")]
	[Description("Indicates user defined data value that can be passed to the command when it is executed.")]
	[TypeConverter(typeof(StringConverter))]
	[DefaultValue(null)]
	[Localizable(true)]
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

	[Description("Occurs after the insert mode has changed")]
	public event EventHandler IsOverwriteModeChanged
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

	[Description("Occurs after the input mask is changed.")]
	public event EventHandler MaskChanged
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

	[Category("Behavior")]
	[Description("Occurs when the user's input or assigned character does not match the corresponding format element of the input mask.")]
	public event MaskInputRejectedEventHandler MaskInputRejected
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			maskInputRejectedEventHandler_0 = (MaskInputRejectedEventHandler)Delegate.Combine((Delegate?)(object)maskInputRejectedEventHandler_0, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			maskInputRejectedEventHandler_0 = (MaskInputRejectedEventHandler)Delegate.Remove((Delegate?)(object)maskInputRejectedEventHandler_0, (Delegate?)(object)value);
		}
	}

	[Description("Occurs when the text alignment is changed.")]
	public event EventHandler TextAlignChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_9 = (EventHandler)Delegate.Combine(eventHandler_9, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_9 = (EventHandler)Delegate.Remove(eventHandler_9, value);
		}
	}

	[Description("Occurs when MaskedTextBox has finished parsing the current value using the ValidatingType property.")]
	[Category("Focus")]
	public event TypeValidationEventHandler TypeValidationCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			typeValidationEventHandler_0 = (TypeValidationEventHandler)Delegate.Combine((Delegate?)(object)typeValidationEventHandler_0, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			typeValidationEventHandler_0 = (TypeValidationEventHandler)Delegate.Remove((Delegate?)(object)typeValidationEventHandler_0, (Delegate?)(object)value);
		}
	}

	public MaskedTextBoxAdv()
	{
		((Control)this).SetStyle((ControlStyles)512, false);
		maskedTextBox_0 = (MaskedTextBox)(object)new Class196();
		((Control)this).set_BackColor(SystemColors.Window);
		method_11();
	}

	public MaskedTextBoxAdv(MaskedTextProvider maskedTextProvider)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		maskedTextBox_0 = new MaskedTextBox(maskedTextProvider);
		method_11();
	}

	public MaskedTextBoxAdv(string mask)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		maskedTextBox_0 = new MaskedTextBox(mask);
		method_11();
	}

	private void method_11()
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		elementStyle_0.method_4(base.ColorScheme);
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		inputButtonSettings_2 = new InputButtonSettings(this);
		inputButtonSettings_3 = new InputButtonSettings(this);
		inputButtonSettings_1 = new InputButtonSettings(this);
		inputButtonSettings_0 = new InputButtonSettings(this);
		method_16();
		((TextBoxBase)maskedTextBox_0).set_BorderStyle((BorderStyle)0);
		((Control)maskedTextBox_0).add_TextChanged((EventHandler)maskedTextBox_0_TextChanged);
		maskedTextBox_0.add_IsOverwriteModeChanged((EventHandler)maskedTextBox_0_IsOverwriteModeChanged);
		maskedTextBox_0.add_MaskChanged((EventHandler)maskedTextBox_0_MaskChanged);
		maskedTextBox_0.add_MaskInputRejected(new MaskInputRejectedEventHandler(maskedTextBox_0_MaskInputRejected));
		maskedTextBox_0.add_TextAlignChanged((EventHandler)maskedTextBox_0_TextAlignChanged);
		maskedTextBox_0.add_TypeValidationCompleted(new TypeValidationEventHandler(maskedTextBox_0_TypeValidationCompleted));
		((Control)maskedTextBox_0).add_SizeChanged((EventHandler)maskedTextBox_0_SizeChanged);
		((Control)this).get_Controls().Add((Control)(object)maskedTextBox_0);
	}

	private void maskedTextBox_0_SizeChanged(object sender, EventArgs e)
	{
		if (!bool_7)
		{
			method_23();
		}
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

	private void maskedTextBox_0_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
	{
		OnTypeValidationCompleted(e);
	}

	protected virtual void OnTypeValidationCompleted(TypeValidationEventArgs e)
	{
		TypeValidationEventHandler val = typeValidationEventHandler_0;
		if (val != null)
		{
			val.Invoke((object)this, e);
		}
	}

	private void maskedTextBox_0_TextAlignChanged(object sender, EventArgs e)
	{
		OnTextAlignChanged(e);
	}

	protected virtual void OnTextAlignChanged(EventArgs e)
	{
		eventHandler_9?.Invoke(this, e);
	}

	private void maskedTextBox_0_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
	{
		OnMaskInputRejected(e);
	}

	protected virtual void OnMaskInputRejected(MaskInputRejectedEventArgs e)
	{
		MaskInputRejectedEventHandler val = maskInputRejectedEventHandler_0;
		if (val != null)
		{
			val.Invoke((object)this, e);
		}
	}

	private void maskedTextBox_0_MaskChanged(object sender, EventArgs e)
	{
		OnMaskChanged(e);
	}

	protected virtual void OnMaskChanged(EventArgs e)
	{
		eventHandler_8?.Invoke(this, e);
	}

	private void maskedTextBox_0_IsOverwriteModeChanged(object sender, EventArgs e)
	{
		OnIsOverwriteModeChanged(e);
	}

	protected virtual void OnIsOverwriteModeChanged(EventArgs e)
	{
		eventHandler_7?.Invoke(this, e);
	}

	private void maskedTextBox_0_TextChanged(object sender, EventArgs e)
	{
		((Control)this).set_Text(((Control)maskedTextBox_0).get_Text());
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
		((Control)maskedTextBox_0).set_BackColor(((Control)this).get_BackColor());
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
		((Control)maskedTextBox_0).Focus();
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
			if (((TextBoxBase)maskedTextBox_0).get_PreferredHeight() < bounds.Height)
			{
				bounds.Y += (bounds.Height - ((TextBoxBase)maskedTextBox_0).get_PreferredHeight()) / 2;
			}
			((Control)maskedTextBox_0).set_Bounds(bounds);
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
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
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
				control_0 = control_1.get_Parent();
				controlContainerItem.Control = control_1;
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
		if (!(buttonItem_0.SubItems[string_0] is ItemContainer itemContainer))
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
			((Control)maskedTextBox_0).set_Text("");
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
		return color_1 != SystemColors.GrayText;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetWatermarkColor()
	{
		WatermarkColor = SystemColors.GrayText;
	}

	private void method_28()
	{
		class261_0 = null;
		if (Class243.smethod_2(ref string_2))
		{
			class261_0 = Class243.smethod_0(string_2);
			method_29();
		}
	}

	private void method_29()
	{
		if (class261_0 != null)
		{
			Graphics val = CreateGraphics();
			try
			{
				Class263 @class = method_31(val);
				class261_0.Measure(method_30().Size, @class);
				Size size = class261_0.Bounds.Size;
				class261_0.method_2(new Rectangle(method_30().Location, size), @class);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	private Rectangle method_30()
	{
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		clientRectangle.Inflate(-1, 0);
		return clientRectangle;
	}

	private Class263 method_31(Graphics graphics_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		return new Class263(graphics_0, (font_0 == null) ? ((Control)this).get_Font() : font_0, color_1, (int)((Control)this).get_RightToLeft() == 1);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeCulture()
	{
		return !CultureInfo.CurrentCulture.Equals(Culture);
	}

	public object ValidateText()
	{
		return maskedTextBox_0.ValidateText();
	}

	public override string ToString()
	{
		return ((object)maskedTextBox_0).ToString();
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		Size preferredSize = ((Control)maskedTextBox_0).GetPreferredSize(proposedSize);
		preferredSize.Height = PreferredHeight;
		return preferredSize;
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
}
