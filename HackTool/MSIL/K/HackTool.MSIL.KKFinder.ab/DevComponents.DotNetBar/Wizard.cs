using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[ToolboxItem(true)]
[ToolboxBitmap(typeof(Wizard), "Wizard.Wizard.ico")]
[Designer(typeof(WizardDesigner))]
public class Wizard : UserControl
{
	private PanelControl panelHeader;

	private int int_0 = 8;

	private int int_1 = 1;

	private int int_2 = 22;

	private FlatStyle flatStyle_0 = (FlatStyle)3;

	internal PanelControl panelFooter;

	private ButtonX buttonHelp;

	private ButtonX buttonCancel;

	private ButtonX buttonFinish;

	private ButtonX buttonNext;

	private ButtonX buttonBack;

	private bool bool_0;

	private Label labelDescription;

	private Label labelCaption;

	private WizardPageCollection wizardPageCollection_0 = new WizardPageCollection();

	private Stack stack_0 = new Stack();

	private int int_3;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private eWizardFormAcceptButton eWizardFormAcceptButton_0;

	private eWizardFormCancelButton eWizardFormCancelButton_0;

	private PictureBox pictureHeader;

	private Image image_0;

	private bool bool_3;

	private bool bool_4 = true;

	private bool bool_5 = true;

	private Container container_0;

	private CancelEventHandler cancelEventHandler_0;

	private CancelEventHandler cancelEventHandler_1;

	private CancelEventHandler cancelEventHandler_2;

	private CancelEventHandler cancelEventHandler_3;

	private CancelEventHandler cancelEventHandler_4;

	private WizardCancelPageChangeEventHandler wizardCancelPageChangeEventHandler_0;

	private WizardPageChangeEventHandler wizardPageChangeEventHandler_0;

	private WizardButtonsLayoutEventHandler wizardButtonsLayoutEventHandler_0;

	private eWizardTitleImageAlignment eWizardTitleImageAlignment_0 = eWizardTitleImageAlignment.Right;

	private bool bool_6 = true;

	private bool bool_7 = true;

	private eWizardStyle eWizardStyle_0;

	[DefaultValue(null)]
	[Browsable(true)]
	[Description("Indicates the header image.")]
	[Category("Header and Footer")]
	public Image HeaderImage
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			bool_3 = true;
			method_9();
		}
	}

	[DefaultValue(true)]
	[Browsable(true)]
	[Description("Indicates whether header image is visible.")]
	[Category("Header and Footer")]
	public bool HeaderImageVisible
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool_4 = value;
			if (((Control)pictureHeader).get_Visible() != bool_4)
			{
				((Control)pictureHeader).set_Visible(bool_4);
				method_1();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ControlCollection Controls => ((Control)this).get_Controls();

	[Category("Wizard Behavior")]
	[Description("Indicates wizard button that is clicked when ENTER key is pressed.")]
	[DefaultValue(eWizardFormAcceptButton.FinishAndNext)]
	[Browsable(true)]
	public eWizardFormAcceptButton FormAcceptButton
	{
		get
		{
			return eWizardFormAcceptButton_0;
		}
		set
		{
			eWizardFormAcceptButton_0 = value;
			method_11();
		}
	}

	[Category("Wizard Behavior")]
	[DefaultValue(eWizardFormCancelButton.Cancel)]
	[Description("Indicates wizard button that is clicked when ESCAPE key is pressed.")]
	[Browsable(true)]
	public eWizardFormCancelButton FormCancelButton
	{
		get
		{
			return eWizardFormCancelButton_0;
		}
		set
		{
			eWizardFormCancelButton_0 = value;
			method_12();
		}
	}

	[Category("Wizard Behavior")]
	[Description("Indicates whether all buttons are disabled while wizard page is changed.")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool PageChangeDisableButtons
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	[DefaultValue(true)]
	[Category("Wizard Behavior")]
	[Description("Indicates whether wait cursor is displayed while page is changed.")]
	[Browsable(true)]
	public bool PageChangeWaitCursor
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	[Description("Indicates selected page index.")]
	[Category("Wizard Pages")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int SelectedPageIndex
	{
		get
		{
			return int_3;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			if (value < wizardPageCollection_0.Count)
			{
				method_8(wizardPageCollection_0[value], eWizardPageChangeSource.Code);
			}
			else
			{
				int_3 = value;
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public WizardPage SelectedPage
	{
		get
		{
			if (int_3 < wizardPageCollection_0.Count)
			{
				return wizardPageCollection_0[int_3];
			}
			return null;
		}
		set
		{
			if (!wizardPageCollection_0.Contains(value))
			{
				throw new InvalidOperationException("WizardPage is not member of WizardPages collection. Add page to the WizardPages collection before setting this property");
			}
			method_8(value, eWizardPageChangeSource.Code);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Wizard Pages")]
	[Browsable(true)]
	public WizardPageCollection WizardPages => wizardPageCollection_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Category("Wizard Pages")]
	public Stack PagesHistory => stack_0;

	[Obsolete("Property is obsolete and no longer applies")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Category("Wizard Buttons")]
	[Description("Indicates flat style for buttons")]
	public FlatStyle ButtonFlatStyle
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return flatStyle_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			flatStyle_0 = value;
		}
	}

	[Category("Wizard Buttons")]
	[Browsable(true)]
	[DefaultValue(22)]
	[Description("Indicates the height of the wizard command buttons")]
	public int ButtonHeight
	{
		get
		{
			return int_2;
		}
		set
		{
			if (int_2 != value)
			{
				int_2 = value;
				method_2();
			}
		}
	}

	[Description("Indicates whether back button causes validation to be performed on any controls that require validation when it receives focus.")]
	[Category("Wizard Buttons")]
	[Browsable(true)]
	[DefaultValue(false)]
	public bool BackButtonCausesValidation
	{
		get
		{
			return ((Control)buttonBack).get_CausesValidation();
		}
		set
		{
			((Control)buttonBack).set_CausesValidation(value);
		}
	}

	[Description("Indicates tab index of back button.")]
	[Category("Wizard Buttons")]
	[Browsable(true)]
	[DefaultValue(1)]
	public int BackButtonTabIndex
	{
		get
		{
			return ((Control)buttonBack).get_TabIndex();
		}
		set
		{
			((Control)buttonBack).set_TabIndex(value);
		}
	}

	[Category("Wizard Buttons")]
	[Browsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether the user can give the focus to this back button using the TAB key.")]
	public bool BackButtonTabStop
	{
		get
		{
			return ((Control)buttonBack).get_TabStop();
		}
		set
		{
			((Control)buttonBack).set_TabStop(value);
		}
	}

	[Category("Wizard Buttons")]
	[Localizable(true)]
	[Browsable(true)]
	[Description("Indicates caption of the button")]
	[DefaultValue("< Back")]
	public string BackButtonText
	{
		get
		{
			return ((Control)buttonBack).get_Text();
		}
		set
		{
			((Control)buttonBack).set_Text(value);
		}
	}

	[Category("Wizard Buttons")]
	[Description("Indicates width of button")]
	[Browsable(true)]
	[DefaultValue(74)]
	public int BackButtonWidth
	{
		get
		{
			return ((Control)buttonBack).get_Width();
		}
		set
		{
			if (((Control)buttonBack).get_Width() != value)
			{
				((Control)buttonBack).set_Width(value);
				method_2();
			}
		}
	}

	[Description("Indicates whether button is auto sized")]
	[Category("Wizard Buttons")]
	[Browsable(true)]
	[DefaultValue(false)]
	public bool BackButtonAutoSize
	{
		get
		{
			return ((Control)buttonBack).get_AutoSize();
		}
		set
		{
			if (((Control)buttonBack).get_AutoSize() != value)
			{
				((Control)buttonBack).set_AutoSize(value);
				method_2();
			}
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(true)]
	[Category("Wizard Buttons")]
	[Description("Indicates button auto-size mode")]
	public AutoSizeMode BackButtonAutoSizeMode
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return buttonBack.AutoSizeMode;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (buttonBack.AutoSizeMode != value)
			{
				buttonBack.AutoSizeMode = value;
				method_2();
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates whether button causes validation to be performed on any controls that require validation when it receives focus.")]
	[DefaultValue(true)]
	[Category("Wizard Buttons")]
	public bool NextButtonCausesValidation
	{
		get
		{
			return ((Control)buttonNext).get_CausesValidation();
		}
		set
		{
			((Control)buttonNext).set_CausesValidation(value);
		}
	}

	[Description("Indicates tab index of next button.")]
	[DefaultValue(2)]
	[Category("Wizard Buttons")]
	[Browsable(true)]
	public int NextButtonTabIndex
	{
		get
		{
			return ((Control)buttonNext).get_TabIndex();
		}
		set
		{
			((Control)buttonNext).set_TabIndex(value);
		}
	}

	[Category("Wizard Buttons")]
	[Browsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether the user can give the focus to button using the TAB key.")]
	public bool NextButtonTabStop
	{
		get
		{
			return ((Control)buttonNext).get_TabStop();
		}
		set
		{
			((Control)buttonNext).set_TabStop(value);
		}
	}

	[Localizable(true)]
	[Category("Wizard Buttons")]
	[DefaultValue("Next >")]
	[Description("Indicates caption of the button")]
	[Browsable(true)]
	public string NextButtonText
	{
		get
		{
			return ((Control)buttonNext).get_Text();
		}
		set
		{
			((Control)buttonNext).set_Text(value);
		}
	}

	[Browsable(true)]
	[DefaultValue(74)]
	[Description("Indicates width of button")]
	[Category("Wizard Buttons")]
	public int NextButtonWidth
	{
		get
		{
			return ((Control)buttonNext).get_Width();
		}
		set
		{
			if (((Control)buttonNext).get_Width() != value)
			{
				((Control)buttonNext).set_Width(value);
				method_2();
			}
		}
	}

	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Indicates whether button is auto sized")]
	[Category("Wizard Buttons")]
	public bool NextButtonAutoSize
	{
		get
		{
			return ((Control)buttonNext).get_AutoSize();
		}
		set
		{
			if (((Control)buttonNext).get_AutoSize() != value)
			{
				((Control)buttonNext).set_AutoSize(value);
				method_2();
			}
		}
	}

	[Category("Wizard Buttons")]
	[Description("Indicates button auto-size mode")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(true)]
	public AutoSizeMode NextButtonAutoSizeMode
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return buttonNext.AutoSizeMode;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (buttonNext.AutoSizeMode != value)
			{
				buttonNext.AutoSizeMode = value;
				method_2();
			}
		}
	}

	[Description("Indicates whether button causes validation to be performed on any controls that require validation when it receives focus.")]
	[Browsable(true)]
	[Category("Wizard Buttons")]
	[DefaultValue(false)]
	public bool CancelButtonCausesValidation
	{
		get
		{
			return ((Control)buttonCancel).get_CausesValidation();
		}
		set
		{
			((Control)buttonCancel).set_CausesValidation(value);
		}
	}

	[Category("Wizard Buttons")]
	[DefaultValue(4)]
	[Browsable(true)]
	[Description("Indicates tab index of the button.")]
	public int CancelButtonTabIndex
	{
		get
		{
			return ((Control)buttonCancel).get_TabIndex();
		}
		set
		{
			((Control)buttonCancel).set_TabIndex(value);
		}
	}

	[Category("Wizard Buttons")]
	[Description("Indicates whether the user can give the focus to button using the TAB key.")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool CancelButtonTabStop
	{
		get
		{
			return ((Control)buttonCancel).get_TabStop();
		}
		set
		{
			((Control)buttonCancel).set_TabStop(value);
		}
	}

	[Category("Wizard Buttons")]
	[Localizable(true)]
	[DefaultValue("Cancel")]
	[Description("Indicates caption of the button")]
	[Browsable(true)]
	public string CancelButtonText
	{
		get
		{
			return ((Control)buttonCancel).get_Text();
		}
		set
		{
			((Control)buttonCancel).set_Text(value);
		}
	}

	[Browsable(true)]
	[Description("Indicates width of button")]
	[DefaultValue(74)]
	[Category("Wizard Buttons")]
	public int CancelButtonWidth
	{
		get
		{
			return ((Control)buttonCancel).get_Width();
		}
		set
		{
			if (((Control)buttonCancel).get_Width() != value)
			{
				((Control)buttonCancel).set_Width(value);
				method_2();
			}
		}
	}

	[Browsable(true)]
	[Category("Wizard Buttons")]
	[DefaultValue(false)]
	[Description("Indicates whether button is auto sized")]
	public bool CancelButtonAutoSize
	{
		get
		{
			return ((Control)buttonCancel).get_AutoSize();
		}
		set
		{
			if (((Control)buttonCancel).get_AutoSize() != value)
			{
				((Control)buttonCancel).set_AutoSize(value);
				method_2();
			}
		}
	}

	[Category("Wizard Buttons")]
	[Browsable(true)]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Description("Indicates button auto-size mode")]
	public AutoSizeMode CancelButtonAutoSizeMode
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return buttonCancel.AutoSizeMode;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (buttonCancel.AutoSizeMode != value)
			{
				buttonCancel.AutoSizeMode = value;
				method_2();
			}
		}
	}

	[Category("Wizard Buttons")]
	[Description("Indicates whether button causes validation to be performed on any controls that require validation when it receives focus.")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool FinishButtonCausesValidation
	{
		get
		{
			return ((Control)buttonFinish).get_CausesValidation();
		}
		set
		{
			((Control)buttonFinish).set_CausesValidation(value);
		}
	}

	[Browsable(true)]
	[Category("Wizard Buttons")]
	[Description("Indicates tab index of the button.")]
	[DefaultValue(4)]
	public int FinishButtonTabIndex
	{
		get
		{
			return ((Control)buttonFinish).get_TabIndex();
		}
		set
		{
			((Control)buttonFinish).set_TabIndex(value);
		}
	}

	[Category("Wizard Buttons")]
	[Browsable(true)]
	[Description("Indicates whether the user can give the focus to button using the TAB key.")]
	[DefaultValue(true)]
	public bool FinishButtonTabStop
	{
		get
		{
			return ((Control)buttonFinish).get_TabStop();
		}
		set
		{
			((Control)buttonFinish).set_TabStop(value);
		}
	}

	[Localizable(true)]
	[Category("Wizard Buttons")]
	[DefaultValue("Finish")]
	[Browsable(true)]
	[Description("Indicates caption of the button")]
	public string FinishButtonText
	{
		get
		{
			return ((Control)buttonFinish).get_Text();
		}
		set
		{
			((Control)buttonFinish).set_Text(value);
		}
	}

	[DefaultValue(74)]
	[Browsable(true)]
	[Description("Indicates width of button")]
	[Category("Wizard Buttons")]
	public int FinishButtonWidth
	{
		get
		{
			return ((Control)buttonFinish).get_Width();
		}
		set
		{
			if (((Control)buttonFinish).get_Width() != value)
			{
				((Control)buttonFinish).set_Width(value);
				method_2();
			}
		}
	}

	[Description("Indicates whether Finish button is always visible or only when needed.")]
	[DefaultValue(false)]
	[Category("Wizard Buttons")]
	[Browsable(true)]
	public bool FinishButtonAlwaysVisible
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (bool_0 != value)
			{
				bool_0 = value;
				method_3();
				method_2();
			}
		}
	}

	[Browsable(true)]
	[Category("Wizard Buttons")]
	[DefaultValue(false)]
	[Description("Indicates whether button is auto sized")]
	public bool FinishButtonAutoSize
	{
		get
		{
			return ((Control)buttonFinish).get_AutoSize();
		}
		set
		{
			if (((Control)buttonFinish).get_AutoSize() != value)
			{
				((Control)buttonFinish).set_AutoSize(value);
				method_2();
			}
		}
	}

	[Description("Indicates button auto-size mode")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(true)]
	[Category("Wizard Buttons")]
	public AutoSizeMode FinishButtonAutoSizeMode
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return buttonFinish.AutoSizeMode;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (buttonFinish.AutoSizeMode != value)
			{
				buttonFinish.AutoSizeMode = value;
				method_2();
			}
		}
	}

	[Category("Wizard Buttons")]
	[Description("Indicates whether button causes validation to be performed on any controls that require validation when it receives focus.")]
	[DefaultValue(false)]
	[Browsable(true)]
	public bool HelpButtonCausesValidation
	{
		get
		{
			return ((Control)buttonHelp).get_CausesValidation();
		}
		set
		{
			((Control)buttonHelp).set_CausesValidation(value);
		}
	}

	[DefaultValue(true)]
	[Browsable(true)]
	[Category("Wizard Buttons")]
	[Description("Indicates whether button is visible")]
	public bool HelpButtonVisible
	{
		get
		{
			return bool_5;
		}
		set
		{
			bool_5 = value;
			((Control)buttonHelp).set_Visible(bool_5);
			method_2();
		}
	}

	[Browsable(true)]
	[Category("Wizard Buttons")]
	[DefaultValue(5)]
	[Description("Indicates tab index of the button.")]
	public int HelpButtonTabIndex
	{
		get
		{
			return ((Control)buttonHelp).get_TabIndex();
		}
		set
		{
			((Control)buttonHelp).set_TabIndex(value);
		}
	}

	[DefaultValue(true)]
	[Browsable(true)]
	[Category("Wizard Buttons")]
	[Description("Indicates whether the user can give the focus to button using the TAB key.")]
	public bool HelpButtonTabStop
	{
		get
		{
			return ((Control)buttonHelp).get_TabStop();
		}
		set
		{
			((Control)buttonHelp).set_TabStop(value);
		}
	}

	[DefaultValue("Help")]
	[Browsable(true)]
	[Category("Wizard Buttons")]
	[Description("Indicates caption of the button")]
	[Localizable(true)]
	public string HelpButtonText
	{
		get
		{
			return ((Control)buttonHelp).get_Text();
		}
		set
		{
			((Control)buttonHelp).set_Text(value);
		}
	}

	[DefaultValue(74)]
	[Category("Wizard Buttons")]
	[Description("Indicates width of button")]
	[Browsable(true)]
	public int HelpButtonWidth
	{
		get
		{
			return ((Control)buttonHelp).get_Width();
		}
		set
		{
			if (((Control)buttonHelp).get_Width() != value)
			{
				((Control)buttonHelp).set_Width(value);
				method_2();
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether button is auto sized")]
	[Category("Wizard Buttons")]
	public bool HelpButtonAutoSize
	{
		get
		{
			return ((Control)buttonHelp).get_AutoSize();
		}
		set
		{
			if (((Control)buttonHelp).get_AutoSize() != value)
			{
				((Control)buttonHelp).set_AutoSize(value);
				method_2();
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates button auto-size mode")]
	[Category("Wizard Buttons")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public AutoSizeMode HelpButtonAutoSizeMode
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return buttonHelp.AutoSizeMode;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (buttonHelp.AutoSizeMode != value)
			{
				buttonHelp.AutoSizeMode = value;
				method_2();
			}
		}
	}

	[DefaultValue(46)]
	[Browsable(true)]
	[Description("Indicates height of the wizard footer.")]
	[Category("Header and Footer")]
	public int FooterHeight
	{
		get
		{
			return ((Control)panelFooter).get_Height();
		}
		set
		{
			if (((Control)panelFooter).get_Height() != value)
			{
				((Control)panelFooter).set_Height(value);
				method_2();
				method_13(SelectedPage);
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates height of the wizard header.")]
	[Category("Header and Footer")]
	[DefaultValue(60)]
	public int HeaderHeight
	{
		get
		{
			return ((Control)panelHeader).get_Height();
		}
		set
		{
			if (((Control)panelHeader).get_Height() != value)
			{
				((Control)panelHeader).set_Height(value);
				method_13(SelectedPage);
			}
		}
	}

	[Category("Header and Footer")]
	[Description("Indicates header image alignment.")]
	[DefaultValue(eWizardTitleImageAlignment.Right)]
	public eWizardTitleImageAlignment HeaderImageAlignment
	{
		get
		{
			return eWizardTitleImageAlignment_0;
		}
		set
		{
			eWizardTitleImageAlignment_0 = value;
			method_1();
		}
	}

	[Category("Header and Footer")]
	[Browsable(true)]
	[Description("Indicates header image size for interior wizard pages.")]
	public Size HeaderImageSize
	{
		get
		{
			return ((Control)pictureHeader).get_Size();
		}
		set
		{
			if (((Control)pictureHeader).get_Size() != value)
			{
				((Control)pictureHeader).set_Size(value);
				method_1();
			}
		}
	}

	[DefaultValue(16)]
	[Category("Header and Footer")]
	[Browsable(true)]
	[Description("Indicates indentation of header title label.")]
	public int HeaderTitleIndent
	{
		get
		{
			return ((Control)labelCaption).get_Left();
		}
		set
		{
			if (((Control)labelCaption).get_Left() != value)
			{
				((Control)labelCaption).set_Left(value);
				method_1();
			}
		}
	}

	[Description("Indicates indentation of header description label.")]
	[Category("Header and Footer")]
	[DefaultValue(44)]
	[Browsable(true)]
	public int HeaderDescriptionIndent
	{
		get
		{
			return ((Control)labelDescription).get_Left();
		}
		set
		{
			if (((Control)labelDescription).get_Left() != value)
			{
				((Control)labelDescription).set_Left(value);
				method_1();
			}
		}
	}

	[Category("Header and Footer")]
	[Description("Indicates the font used to render caption header text.")]
	public Font HeaderCaptionFont
	{
		get
		{
			return ((Control)labelCaption).get_Font();
		}
		set
		{
			((Control)labelCaption).set_Font(value);
			method_1();
		}
	}

	[Category("Header and Footer")]
	[Description("Indicates whether description text displayed in wizard header is visible.")]
	[DefaultValue(true)]
	public bool HeaderDescriptionVisible
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
			((Control)labelDescription).set_Visible(value);
			method_1();
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Style")]
	[NotifyParentProperty(true)]
	[Description("Gets or sets header background style.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ElementStyle HeaderStyle => panelHeader.Style;

	[DevCoBrowsable(true)]
	[Description("Gets or sets footer background style.")]
	[Category("Style")]
	[NotifyParentProperty(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	public ElementStyle FooterStyle => panelFooter.Style;

	internal ButtonX ButtonX_0 => buttonNext;

	internal ButtonX ButtonX_1 => buttonBack;

	private bool Boolean_0 => (int)((Control)this).get_RightToLeft() == 1;

	[Category("Behavior")]
	[Description("Indicates whether Focus cues on wizard navigation buttons are enabled.")]
	[DefaultValue(true)]
	public bool ButtonFocusCuesEnabled
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
				buttonHelp.FocusCuesEnabled = value;
				buttonCancel.FocusCuesEnabled = value;
				buttonFinish.FocusCuesEnabled = value;
				buttonNext.FocusCuesEnabled = value;
				buttonBack.FocusCuesEnabled = value;
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(eWizardStyle.Default)]
	public eWizardStyle ButtonStyle
	{
		get
		{
			return eWizardStyle_0;
		}
		set
		{
			if (eWizardStyle_0 != value)
			{
				eWizardStyle_0 = value;
				method_14();
			}
		}
	}

	[Description("Occurs when Back button is clicked.")]
	public event CancelEventHandler BackButtonClick
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

	[Description("Occurs when Next button is clicked.")]
	public event CancelEventHandler NextButtonClick
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

	[Description("Occurs when Finish button is clicked.")]
	public event CancelEventHandler FinishButtonClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_2 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_2 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_2, value);
		}
	}

	[Description("Occurs when Cancel button is clicked.")]
	public event CancelEventHandler CancelButtonClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_3 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_3 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_3, value);
		}
	}

	[Description("Occurs when Help button is clicked.")]
	public event CancelEventHandler HelpButtonClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_4 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_4, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_4 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_4, value);
		}
	}

	[Description("Occurs before wizard page has changed and gives you opportunity to cancel the change.")]
	public event WizardCancelPageChangeEventHandler WizardPageChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			wizardCancelPageChangeEventHandler_0 = (WizardCancelPageChangeEventHandler)Delegate.Combine(wizardCancelPageChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			wizardCancelPageChangeEventHandler_0 = (WizardCancelPageChangeEventHandler)Delegate.Remove(wizardCancelPageChangeEventHandler_0, value);
		}
	}

	[Description("Occurs after wizard page has changed.")]
	public event WizardPageChangeEventHandler WizardPageChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			wizardPageChangeEventHandler_0 = (WizardPageChangeEventHandler)Delegate.Combine(wizardPageChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			wizardPageChangeEventHandler_0 = (WizardPageChangeEventHandler)Delegate.Remove(wizardPageChangeEventHandler_0, value);
		}
	}

	[Description("Occurs when wizard buttons (Back, Next, Finish etc) are positioned and resized.")]
	public event WizardButtonsLayoutEventHandler LayoutWizardButtons
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			wizardButtonsLayoutEventHandler_0 = (WizardButtonsLayoutEventHandler)Delegate.Combine(wizardButtonsLayoutEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			wizardButtonsLayoutEventHandler_0 = (WizardButtonsLayoutEventHandler)Delegate.Remove(wizardButtonsLayoutEventHandler_0, value);
		}
	}

	public Wizard()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		wizardPageCollection_0.Wizard_0 = this;
		((Control)pictureHeader).set_BackgroundImage((Image)(object)Class109.smethod_67("SystemImages.WizardHeaderImage.png"));
		panelFooter.Style.StyleChanged += method_0;
	}

	private void method_0(object sender, EventArgs e)
	{
		if (panelFooter.Style.BackColor == Color.Transparent && panelFooter.Style.BackColor2.IsEmpty && panelFooter.Style.BackColorBlend.Count == 0)
		{
			((Control)panelFooter).set_BackColor(Color.Transparent);
		}
		else if (((Control)panelFooter).get_BackColor() != SystemColors.Control)
		{
			((Control)panelFooter).set_BackColor(SystemColors.Control);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && container_0 != null)
		{
			container_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		panelHeader = new PanelControl();
		pictureHeader = new PictureBox();
		labelDescription = new Label();
		labelCaption = new Label();
		panelFooter = new PanelControl();
		buttonHelp = new ButtonX();
		buttonCancel = new ButtonX();
		buttonFinish = new ButtonX();
		buttonNext = new ButtonX();
		buttonBack = new ButtonX();
		((Control)panelHeader).SuspendLayout();
		((Control)panelFooter).SuspendLayout();
		((Control)this).SuspendLayout();
		panelHeader.AntiAlias = false;
		((Control)panelHeader).set_BackColor(Color.Transparent);
		panelHeader.CanvasColor = SystemColors.Control;
		((Control)panelHeader).get_Controls().Add((Control)(object)pictureHeader);
		((Control)panelHeader).get_Controls().Add((Control)(object)labelDescription);
		((Control)panelHeader).get_Controls().Add((Control)(object)labelCaption);
		((Control)panelHeader).set_Dock((DockStyle)1);
		((Control)panelHeader).set_Location(new Point(0, 0));
		((Control)panelHeader).set_Name("panelHeader");
		((Control)panelHeader).set_Size(new Size(548, 60));
		panelHeader.Style.BackColor = Color.FromArgb(255, 255, 255);
		panelHeader.Style.BackColorGradientAngle = 90;
		panelHeader.Style.BorderBottom = eStyleBorderType.Etched;
		panelHeader.Style.BorderBottomWidth = 1;
		panelHeader.Style.BorderColor = SystemColors.Control;
		panelHeader.Style.BorderLeftWidth = 1;
		panelHeader.Style.BorderRightWidth = 1;
		panelHeader.Style.BorderTopWidth = 1;
		panelHeader.Style.TextAlignment = eStyleTextAlignment.Center;
		panelHeader.Style.TextColorSchemePart = eColorSchemePart.PanelText;
		((Control)panelHeader).set_TabIndex(5);
		((Control)pictureHeader).set_Anchor((AnchorStyles)9);
		((Control)pictureHeader).set_Location(new Point(496, 6));
		((Control)pictureHeader).set_Name("pictureHeader");
		((Control)pictureHeader).set_Size(new Size(48, 48));
		pictureHeader.set_TabIndex(7);
		pictureHeader.set_TabStop(false);
		((Control)labelDescription).set_Anchor((AnchorStyles)15);
		((Control)labelDescription).set_Location(new Point(44, 22));
		((Control)labelDescription).set_Name("labelDescription");
		((Control)labelDescription).set_Size(new Size(446, 32));
		((Control)labelDescription).set_TabIndex(1);
		((Control)labelCaption).set_Anchor((AnchorStyles)13);
		((Control)labelCaption).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelCaption).set_Location(new Point(16, 5));
		((Control)labelCaption).set_Name("labelCaption");
		((Control)labelCaption).set_Size(new Size(474, 17));
		((Control)labelCaption).set_TabIndex(0);
		((Control)panelFooter).set_BackColor(SystemColors.Control);
		panelFooter.CanvasColor = SystemColors.Control;
		((Control)panelFooter).get_Controls().Add((Control)(object)buttonHelp);
		((Control)panelFooter).get_Controls().Add((Control)(object)buttonCancel);
		((Control)panelFooter).get_Controls().Add((Control)(object)buttonFinish);
		((Control)panelFooter).get_Controls().Add((Control)(object)buttonNext);
		((Control)panelFooter).get_Controls().Add((Control)(object)buttonBack);
		((Control)panelFooter).set_Dock((DockStyle)2);
		((Control)panelFooter).set_Location(new Point(0, 329));
		((Control)panelFooter).set_Name("panelFooter");
		((Control)panelFooter).set_Size(new Size(548, 46));
		panelFooter.AntiAlias = false;
		((Control)panelFooter).set_TabIndex(6);
		((Control)panelFooter).add_Resize((EventHandler)panelFooter_Resize);
		((Control)buttonHelp).set_CausesValidation(false);
		((Control)buttonHelp).set_Location(new Point(462, 13));
		((Control)buttonHelp).set_Name("buttonHelp");
		((Control)buttonHelp).set_Size(new Size(74, 22));
		((Control)buttonHelp).set_TabIndex(5);
		((Control)buttonHelp).set_Text("Help");
		((Control)buttonHelp).add_VisibleChanged((EventHandler)buttonBack_VisibleChanged);
		((Control)buttonHelp).add_Click((EventHandler)buttonHelp_Click);
		buttonHelp.ThemeAware = true;
		buttonHelp.Style = eDotNetBarStyle.Office2000;
		buttonHelp.ColorTable = eButtonColor.Office2007WithBackground;
		((Control)buttonCancel).set_CausesValidation(false);
		((Control)buttonCancel).set_Location(new Point(382, 13));
		((Control)buttonCancel).set_Name("buttonCancel");
		((Control)buttonCancel).set_Size(new Size(74, 22));
		((Control)buttonCancel).set_TabIndex(4);
		((Control)buttonCancel).set_Text("Cancel");
		((Control)buttonCancel).add_VisibleChanged((EventHandler)buttonBack_VisibleChanged);
		((Control)buttonCancel).add_Click((EventHandler)buttonCancel_Click);
		buttonCancel.ThemeAware = true;
		buttonCancel.Style = eDotNetBarStyle.Office2000;
		buttonCancel.ColorTable = eButtonColor.Office2007WithBackground;
		((Control)buttonFinish).set_Location(new Point(148, 13));
		((Control)buttonFinish).set_Name("buttonFinish");
		((Control)buttonFinish).set_Size(new Size(74, 22));
		((Control)buttonFinish).set_TabIndex(3);
		((Control)buttonFinish).set_Text("Finish");
		((Control)buttonFinish).add_VisibleChanged((EventHandler)buttonBack_VisibleChanged);
		((Control)buttonFinish).add_Click((EventHandler)buttonFinish_Click);
		buttonFinish.ThemeAware = true;
		buttonFinish.Style = eDotNetBarStyle.Office2000;
		buttonFinish.ColorTable = eButtonColor.Office2007WithBackground;
		((Control)buttonNext).set_Location(new Point(302, 13));
		((Control)buttonNext).set_Name("buttonNext");
		((Control)buttonNext).set_Size(new Size(74, 22));
		((Control)buttonNext).set_TabIndex(2);
		((Control)buttonNext).set_Text("Next >");
		((Control)buttonNext).add_VisibleChanged((EventHandler)buttonBack_VisibleChanged);
		((Control)buttonNext).add_Click((EventHandler)buttonNext_Click);
		buttonNext.ThemeAware = true;
		buttonNext.Style = eDotNetBarStyle.Office2000;
		buttonNext.ColorTable = eButtonColor.Office2007WithBackground;
		((Control)buttonBack).set_CausesValidation(false);
		((Control)buttonBack).set_Location(new Point(228, 13));
		((Control)buttonBack).set_Name("buttonBack");
		((Control)buttonBack).set_Size(new Size(74, 22));
		((Control)buttonBack).set_TabIndex(1);
		((Control)buttonBack).set_Text("< Back");
		((Control)buttonBack).add_VisibleChanged((EventHandler)buttonBack_VisibleChanged);
		((Control)buttonBack).add_Click((EventHandler)buttonBack_Click);
		buttonBack.ThemeAware = true;
		buttonBack.Style = eDotNetBarStyle.Office2000;
		buttonBack.ColorTable = eButtonColor.Office2007WithBackground;
		Controls.Add((Control)(object)panelHeader);
		Controls.Add((Control)(object)panelFooter);
		((Control)this).set_Name("Wizard");
		((Control)this).set_Size(new Size(548, 375));
		((Control)panelHeader).ResumeLayout(false);
		((Control)panelFooter).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private bool ShouldSerializeHeaderImageSize()
	{
		if (((Control)pictureHeader).get_Size().Width == 48)
		{
			return ((Control)pictureHeader).get_Size().Height != 48;
		}
		return true;
	}

	private void ResetHeaderImageSize()
	{
		TypeDescriptor.GetProperties(this)["HeaderImageSize"]!.SetValue(this, new Size(48, 48));
	}

	private void ResetHeaderStyle()
	{
		panelHeader.ResetStyle();
	}

	private void ResetFooterStyle()
	{
		panelFooter.ResetStyle();
	}

	public void NavigateBack()
	{
		CancelEventArgs cancelEventArgs = new CancelEventArgs();
		OnBackButtonClick(cancelEventArgs);
		if (cancelEventArgs.Cancel)
		{
			return;
		}
		WizardPage selectedPage = SelectedPage;
		if (selectedPage != null)
		{
			selectedPage.method_9(cancelEventArgs);
			if (cancelEventArgs.Cancel)
			{
				return;
			}
		}
		selectedPage = method_4();
		if (selectedPage != null)
		{
			method_8(selectedPage, eWizardPageChangeSource.BackButton);
		}
	}

	public void NavigateNext()
	{
		CancelEventArgs cancelEventArgs = new CancelEventArgs();
		OnNextButtonClick(cancelEventArgs);
		if (cancelEventArgs.Cancel)
		{
			return;
		}
		WizardPage selectedPage = SelectedPage;
		if (selectedPage != null)
		{
			selectedPage.method_10(cancelEventArgs);
			if (cancelEventArgs.Cancel)
			{
				return;
			}
		}
		selectedPage = method_5();
		if (selectedPage != null)
		{
			WizardPage selectedPage2 = SelectedPage;
			if (method_8(selectedPage, eWizardPageChangeSource.NextButton) && !((Component)this).DesignMode)
			{
				stack_0.Push(selectedPage2);
			}
		}
	}

	public void NavigateCancel()
	{
		CancelEventArgs cancelEventArgs = new CancelEventArgs();
		OnCancelButtonClick(cancelEventArgs);
		if (cancelEventArgs.Cancel)
		{
			return;
		}
		WizardPage selectedPage = SelectedPage;
		if (selectedPage != null)
		{
			selectedPage.method_12(cancelEventArgs);
			if (cancelEventArgs.Cancel)
			{
			}
		}
	}

	public void NavigateFinish()
	{
		CancelEventArgs cancelEventArgs = new CancelEventArgs();
		OnFinishButtonClick(cancelEventArgs);
		if (cancelEventArgs.Cancel)
		{
			return;
		}
		WizardPage selectedPage = SelectedPage;
		if (selectedPage != null)
		{
			selectedPage.method_11(cancelEventArgs);
			if (cancelEventArgs.Cancel)
			{
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (((Component)this).DesignMode && WizardPages.Count == 0)
		{
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			Graphics graphics = e.get_Graphics();
			clientRectangle.Inflate(6, 6);
			Class55.smethod_1(graphics, "Right-click control and use context menu commands to create, delete, navigate and re-order wizard pages. You can use Next and Back button to navigate wizard just like in run-time.", ((Control)this).get_Font(), SystemColors.ControlDarkDark, clientRectangle, eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter | eTextFormat.WordBreak);
		}
		((Control)this).OnPaint(e);
	}

	protected override void OnResize(EventArgs e)
	{
		((UserControl)this).OnResize(e);
		if (((Component)this).DesignMode)
		{
			((Control)this).Invalidate();
		}
	}

	private void method_1()
	{
		int num = 4;
		int num2 = ((Control)this).get_Width() - ((Control)labelCaption).get_Left() - 4;
		int num3 = ((Control)this).get_Width() - ((Control)labelDescription).get_Left() - 4;
		if (((Control)pictureHeader).get_Visible() || ((Component)this).DesignMode)
		{
			if (eWizardTitleImageAlignment_0 == eWizardTitleImageAlignment.Right)
			{
				((Control)pictureHeader).set_Anchor((AnchorStyles)9);
				((Control)pictureHeader).set_Location(new Point(((Control)this).get_Width() - ((Control)pictureHeader).get_Width() - num, (((Control)panelHeader).get_Height() - ((Control)pictureHeader).get_Height()) / 2));
			}
			else
			{
				((Control)pictureHeader).set_Anchor((AnchorStyles)5);
				((Control)pictureHeader).set_Location(new Point(num, (((Control)panelHeader).get_Height() - ((Control)pictureHeader).get_Height()) / 2));
			}
			num2 -= ((Control)pictureHeader).get_Width() + num;
			num3 -= ((Control)pictureHeader).get_Width() + num;
		}
		((Control)labelCaption).set_Width(num2);
		((Control)labelDescription).set_Width(num3);
		((Control)labelCaption).set_Top(5);
		((Control)labelCaption).set_Height(((Control)labelCaption).get_Font().get_Height() + 4);
		if (eWizardTitleImageAlignment_0 == eWizardTitleImageAlignment.Right)
		{
			((Control)labelCaption).set_Left(16);
		}
		else
		{
			((Control)labelCaption).set_Left(((Control)pictureHeader).get_Bounds().Right + 10);
			if (!bool_6)
			{
				((Control)labelCaption).set_Top((((Control)panelHeader).get_Height() - ((Control)labelCaption).get_Height()) / 2);
			}
		}
		if (Boolean_0)
		{
			((Control)pictureHeader).set_Left(((Control)this).get_Width() - ((Control)pictureHeader).get_Bounds().Right);
			((Control)labelCaption).set_Left(((Control)this).get_Width() - ((Control)labelCaption).get_Bounds().Right);
			((Control)labelDescription).set_Left(((Control)this).get_Width() - ((Control)labelDescription).get_Bounds().Right);
		}
	}

	protected override void OnRightToLeftChanged(EventArgs e)
	{
		method_2();
		method_1();
		((ScrollableControl)this).OnRightToLeftChanged(e);
	}

	private void method_2()
	{
		int num = ((Control)panelFooter).get_Width() - int_0;
		int y = (((Control)panelFooter).get_Height() - int_2) / 2;
		WizardButtonsLayoutEventArgs wizardButtonsLayoutEventArgs = new WizardButtonsLayoutEventArgs();
		if (((Control)buttonHelp).get_Visible())
		{
			num -= ((Control)buttonHelp).get_Width();
			wizardButtonsLayoutEventArgs.HelpButtonBounds = new Rectangle(num, y, ((Control)buttonHelp).get_Width(), int_2);
			num -= int_0;
		}
		if (((Control)buttonCancel).get_Visible())
		{
			num -= ((Control)buttonCancel).get_Width();
			wizardButtonsLayoutEventArgs.CancelButtonBounds = new Rectangle(num, y, ((Control)buttonCancel).get_Width(), int_2);
			num -= int_0;
		}
		if (((Control)buttonFinish).get_Visible())
		{
			num -= ((Control)buttonFinish).get_Width();
			wizardButtonsLayoutEventArgs.FinishButtonBounds = new Rectangle(num, y, ((Control)buttonFinish).get_Width(), int_2);
			num = ((!bool_0) ? (num - int_1) : (num - int_0));
		}
		if (((Control)buttonNext).get_Visible())
		{
			num -= ((Control)buttonNext).get_Width();
			wizardButtonsLayoutEventArgs.NextButtonBounds = new Rectangle(num, y, ((Control)buttonNext).get_Width(), int_2);
			num -= int_1;
		}
		if (((Control)buttonBack).get_Visible())
		{
			num -= ((Control)buttonBack).get_Width();
			wizardButtonsLayoutEventArgs.BackButtonBounds = new Rectangle(num, y, ((Control)buttonBack).get_Width(), int_2);
			num -= int_1;
		}
		if (Boolean_0)
		{
			((Control)panelFooter).get_Width();
			if (!wizardButtonsLayoutEventArgs.HelpButtonBounds.IsEmpty)
			{
				Rectangle helpButtonBounds = wizardButtonsLayoutEventArgs.HelpButtonBounds;
				wizardButtonsLayoutEventArgs.HelpButtonBounds = new Rectangle(((Control)panelFooter).get_Width() - helpButtonBounds.Right, helpButtonBounds.Y, helpButtonBounds.Width, helpButtonBounds.Height);
			}
			if (!wizardButtonsLayoutEventArgs.CancelButtonBounds.IsEmpty)
			{
				Rectangle cancelButtonBounds = wizardButtonsLayoutEventArgs.CancelButtonBounds;
				wizardButtonsLayoutEventArgs.CancelButtonBounds = new Rectangle(((Control)panelFooter).get_Width() - cancelButtonBounds.Right, cancelButtonBounds.Y, cancelButtonBounds.Width, cancelButtonBounds.Height);
			}
			if (!wizardButtonsLayoutEventArgs.FinishButtonBounds.IsEmpty)
			{
				Rectangle finishButtonBounds = wizardButtonsLayoutEventArgs.FinishButtonBounds;
				wizardButtonsLayoutEventArgs.FinishButtonBounds = new Rectangle(((Control)panelFooter).get_Width() - finishButtonBounds.Right, finishButtonBounds.Y, finishButtonBounds.Width, finishButtonBounds.Height);
			}
			if (!wizardButtonsLayoutEventArgs.NextButtonBounds.IsEmpty)
			{
				Rectangle nextButtonBounds = wizardButtonsLayoutEventArgs.NextButtonBounds;
				wizardButtonsLayoutEventArgs.NextButtonBounds = new Rectangle(((Control)panelFooter).get_Width() - nextButtonBounds.Right, nextButtonBounds.Y, nextButtonBounds.Width, nextButtonBounds.Height);
			}
			if (!wizardButtonsLayoutEventArgs.BackButtonBounds.IsEmpty)
			{
				Rectangle backButtonBounds = wizardButtonsLayoutEventArgs.BackButtonBounds;
				wizardButtonsLayoutEventArgs.BackButtonBounds = new Rectangle(((Control)panelFooter).get_Width() - backButtonBounds.Right, backButtonBounds.Y, backButtonBounds.Width, backButtonBounds.Height);
			}
		}
		OnLayoutWizardButtons(wizardButtonsLayoutEventArgs);
		if (((Control)buttonHelp).get_Visible())
		{
			((Control)buttonHelp).set_Bounds(wizardButtonsLayoutEventArgs.HelpButtonBounds);
		}
		if (((Control)buttonCancel).get_Visible())
		{
			((Control)buttonCancel).set_Bounds(wizardButtonsLayoutEventArgs.CancelButtonBounds);
		}
		if (((Control)buttonNext).get_Visible())
		{
			((Control)buttonNext).set_Bounds(wizardButtonsLayoutEventArgs.NextButtonBounds);
		}
		if (((Control)buttonFinish).get_Visible())
		{
			((Control)buttonFinish).set_Bounds(wizardButtonsLayoutEventArgs.FinishButtonBounds);
		}
		if (((Control)buttonBack).get_Visible())
		{
			((Control)buttonBack).set_Bounds(wizardButtonsLayoutEventArgs.BackButtonBounds);
		}
	}

	private void method_3()
	{
	}

	private void panelFooter_Resize(object sender, EventArgs e)
	{
		method_2();
	}

	private void buttonBack_VisibleChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void buttonBack_Click(object sender, EventArgs e)
	{
		NavigateBack();
	}

	internal WizardPage method_4()
	{
		WizardPage result = null;
		if (stack_0.Count > 0)
		{
			result = stack_0.Pop() as WizardPage;
		}
		else if (SelectedPageIndex > 0)
		{
			result = wizardPageCollection_0[SelectedPageIndex - 1];
		}
		return result;
	}

	private void buttonNext_Click(object sender, EventArgs e)
	{
		NavigateNext();
	}

	internal WizardPage method_5()
	{
		if (SelectedPageIndex + 1 < wizardPageCollection_0.Count)
		{
			return wizardPageCollection_0[SelectedPageIndex + 1];
		}
		return null;
	}

	private void buttonFinish_Click(object sender, EventArgs e)
	{
		NavigateFinish();
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		NavigateCancel();
	}

	private void buttonHelp_Click(object sender, EventArgs e)
	{
		CancelEventArgs cancelEventArgs = new CancelEventArgs();
		OnHelpButtonClick(cancelEventArgs);
		if (cancelEventArgs.Cancel)
		{
			return;
		}
		WizardPage selectedPage = SelectedPage;
		if (selectedPage != null)
		{
			selectedPage.method_13(cancelEventArgs);
			if (cancelEventArgs.Cancel)
			{
			}
		}
	}

	internal void method_6(WizardPage wizardPage_0)
	{
		method_13(wizardPage_0);
		if (wizardPageCollection_0.IndexOf(wizardPage_0) == int_3)
		{
			method_8(wizardPage_0, eWizardPageChangeSource.Code);
		}
		else
		{
			wizardPage_0.Visible = false;
		}
		Controls.Add((Control)(object)wizardPage_0);
		method_10(bool_8: true);
	}

	internal void method_7(WizardPage wizardPage_0)
	{
		Controls.Remove((Control)(object)wizardPage_0);
		if (wizardPage_0.Visible && SelectedPage != null && !SelectedPage.Visible)
		{
			method_8(SelectedPage, eWizardPageChangeSource.Code);
		}
	}

	private bool method_8(WizardPage wizardPage_0, eWizardPageChangeSource eWizardPageChangeSource_0)
	{
		WizardPage selectedPage = SelectedPage;
		WizardCancelPageChangeEventArgs wizardCancelPageChangeEventArgs = new WizardCancelPageChangeEventArgs(wizardPage_0, selectedPage, eWizardPageChangeSource_0);
		OnWizardPageChanging(wizardCancelPageChangeEventArgs);
		if (!wizardCancelPageChangeEventArgs.Cancel && wizardCancelPageChangeEventArgs.NewPage != null)
		{
			wizardPage_0 = wizardCancelPageChangeEventArgs.NewPage;
			if (wizardPage_0 != null)
			{
				wizardPage_0.method_6(wizardCancelPageChangeEventArgs);
				if (wizardCancelPageChangeEventArgs.Cancel || wizardCancelPageChangeEventArgs.NewPage == null)
				{
					return false;
				}
				wizardPage_0 = wizardCancelPageChangeEventArgs.NewPage;
			}
			if (bool_1)
			{
				((Control)buttonBack).set_Enabled(false);
				((Control)buttonNext).set_Enabled(false);
				((Control)buttonFinish).set_Enabled(false);
				((Control)buttonCancel).set_Enabled(false);
			}
			if (bool_2)
			{
				((Control)this).set_Cursor(Cursors.get_WaitCursor());
			}
			if (selectedPage != null)
			{
				if (selectedPage != wizardPage_0)
				{
					if (((Component)this).DesignMode)
					{
						TypeDescriptor.GetProperties(selectedPage)["Visible"]!.SetValue(selectedPage, false);
					}
					selectedPage.Visible = false;
					selectedPage.method_8(new WizardPageChangeEventArgs(wizardPage_0, selectedPage, eWizardPageChangeSource_0));
				}
				else
				{
					foreach (WizardPage wizardPage in WizardPages)
					{
						if (wizardPage != wizardPage_0)
						{
							if (((Component)this).DesignMode)
							{
								TypeDescriptor.GetProperties(wizardPage)["Visible"]!.SetValue(wizardPage, false);
							}
							wizardPage.Visible = false;
						}
					}
				}
			}
			if (wizardPage_0 != null)
			{
				if (((Component)this).DesignMode)
				{
					TypeDescriptor.GetProperties(wizardPage_0)["Visible"]!.SetValue(wizardPage_0, true);
				}
				wizardPage_0.Visible = true;
			}
			int_3 = wizardPageCollection_0.IndexOf(wizardPage_0);
			method_10(bool_8: true);
			wizardCancelPageChangeEventArgs.Cancel = false;
			OnWizardPageChanged(wizardCancelPageChangeEventArgs);
			wizardPage_0?.method_7(new WizardPageChangeEventArgs(wizardPage_0, selectedPage, eWizardPageChangeSource_0));
			method_9();
			if (bool_2)
			{
				((Control)this).set_Cursor(Cursors.get_Default());
			}
			return true;
		}
		return false;
	}

	internal void method_9()
	{
		WizardPage selectedPage = SelectedPage;
		if (selectedPage == null)
		{
			return;
		}
		if (selectedPage.InteriorPage)
		{
			if (!((Control)panelHeader).get_Visible())
			{
				((Control)panelHeader).set_Visible(true);
			}
			if (((Control)pictureHeader).get_Visible() != bool_4)
			{
				((Control)pictureHeader).set_Visible(bool_4);
				method_1();
			}
		}
		else if (((Control)panelHeader).get_Visible())
		{
			((Control)panelHeader).set_Visible(false);
		}
		((Control)labelCaption).set_Text(selectedPage.PageTitle);
		((Control)labelDescription).set_Text(selectedPage.PageDescription);
		if (selectedPage.PageHeaderImage != null)
		{
			((Control)pictureHeader).set_BackgroundImage(selectedPage.PageHeaderImage);
			bool_3 = true;
		}
		else if (bool_3)
		{
			if (image_0 != null)
			{
				((Control)pictureHeader).set_BackgroundImage(image_0);
			}
			else
			{
				((Control)pictureHeader).set_BackgroundImage((Image)(object)Class109.smethod_67("SystemImages.WizardHeaderImage.png"));
			}
			bool_3 = false;
		}
		if (selectedPage.FormCaption != "")
		{
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				((Control)val).set_Text(selectedPage.FormCaption);
			}
		}
	}

	internal void method_10(bool bool_8)
	{
		eWizardButtonState eWizardButtonState2 = eWizardButtonState.Auto;
		eWizardButtonState eWizardButtonState3 = eWizardButtonState.Auto;
		eWizardButtonState eWizardButtonState4 = eWizardButtonState.Auto;
		eWizardButtonState eWizardButtonState5 = eWizardButtonState.Auto;
		eWizardButtonState eWizardButtonState6 = eWizardButtonState.Auto;
		eWizardButtonState eWizardButtonState7 = eWizardButtonState.Auto;
		eWizardButtonState eWizardButtonState8 = eWizardButtonState.Auto;
		eWizardButtonState eWizardButtonState9 = eWizardButtonState.Auto;
		eWizardButtonState eWizardButtonState10 = eWizardButtonState.Auto;
		WizardPage selectedPage = SelectedPage;
		if (selectedPage != null)
		{
			eWizardButtonState2 = selectedPage.BackButtonEnabled;
			eWizardButtonState3 = selectedPage.BackButtonVisible;
			eWizardButtonState4 = selectedPage.NextButtonEnabled;
			eWizardButtonState5 = selectedPage.NextButtonVisible;
			eWizardButtonState6 = selectedPage.FinishButtonEnabled;
			eWizardButtonState7 = selectedPage.CancelButtonEnabled;
			eWizardButtonState8 = selectedPage.CancelButtonVisible;
			eWizardButtonState9 = selectedPage.HelpButtonEnabled;
			eWizardButtonState10 = selectedPage.HelpButtonVisible;
		}
		if (!bool_5)
		{
			eWizardButtonState10 = eWizardButtonState.False;
		}
		if (WizardPages.Count == 0 && ((Component)this).DesignMode)
		{
			eWizardButtonState2 = eWizardButtonState.False;
			eWizardButtonState4 = eWizardButtonState.False;
			eWizardButtonState6 = eWizardButtonState.False;
			eWizardButtonState7 = eWizardButtonState.False;
		}
		if (eWizardButtonState10 == eWizardButtonState.False)
		{
			((Control)buttonHelp).set_Visible(false);
		}
		else if (!((Control)buttonHelp).get_Visible())
		{
			((Control)buttonHelp).set_Visible(true);
		}
		if (eWizardButtonState9 == eWizardButtonState.False)
		{
			((Control)buttonHelp).set_Enabled(false);
		}
		else if (!((Control)buttonHelp).get_Enabled())
		{
			((Control)buttonHelp).set_Enabled(true);
		}
		if (eWizardButtonState8 == eWizardButtonState.False)
		{
			((Control)buttonCancel).set_Visible(false);
		}
		else if (!((Control)buttonCancel).get_Visible())
		{
			((Control)buttonCancel).set_Visible(true);
		}
		if (eWizardButtonState7 == eWizardButtonState.False)
		{
			((Control)buttonCancel).set_Enabled(false);
		}
		else if (!((Control)buttonCancel).get_Enabled())
		{
			((Control)buttonCancel).set_Enabled(true);
		}
		if (!bool_0 && SelectedPageIndex != wizardPageCollection_0.Count - 1 && eWizardButtonState6 != 0)
		{
			((Control)buttonFinish).set_Visible(false);
		}
		else if (!((Control)buttonFinish).get_Visible())
		{
			((Control)buttonFinish).set_Visible(true);
		}
		if (eWizardButtonState6 != eWizardButtonState.False && (eWizardButtonState6 != eWizardButtonState.Auto || SelectedPageIndex >= wizardPageCollection_0.Count - 1))
		{
			if (!((Control)buttonFinish).get_Enabled())
			{
				((Control)buttonFinish).set_Enabled(true);
			}
		}
		else
		{
			((Control)buttonFinish).set_Enabled(false);
		}
		switch (eWizardButtonState5)
		{
		case eWizardButtonState.True:
			if (!((Control)buttonNext).get_Visible())
			{
				((Control)buttonNext).set_Visible(true);
			}
			break;
		case eWizardButtonState.Auto:
			if (((Control)buttonFinish).get_Visible() && ((Control)buttonFinish).get_Enabled() && !bool_0)
			{
				((Control)buttonNext).set_Visible(false);
			}
			else if (!((Control)buttonNext).get_Visible())
			{
				((Control)buttonNext).set_Visible(true);
			}
			break;
		default:
			if (((Control)buttonNext).get_Visible())
			{
				((Control)buttonNext).set_Visible(false);
			}
			break;
		}
		switch (eWizardButtonState4)
		{
		case eWizardButtonState.True:
			if (!((Control)buttonNext).get_Enabled())
			{
				((Control)buttonNext).set_Enabled(true);
			}
			break;
		case eWizardButtonState.Auto:
			if ((((Control)buttonFinish).get_Visible() && ((Control)buttonFinish).get_Enabled()) || SelectedPageIndex == wizardPageCollection_0.Count - 1)
			{
				((Control)buttonNext).set_Enabled(false);
			}
			else if (!((Control)buttonNext).get_Enabled())
			{
				((Control)buttonNext).set_Enabled(true);
			}
			break;
		default:
			if (((Control)buttonNext).get_Enabled())
			{
				((Control)buttonNext).set_Enabled(false);
			}
			break;
		}
		if (bool_8)
		{
			if (((Control)buttonNext).get_Enabled() && ((Control)buttonNext).get_Visible())
			{
				((Control)buttonNext).Select();
			}
			else if (((Control)buttonFinish).get_Enabled() && ((Control)buttonFinish).get_Visible())
			{
				((Control)buttonFinish).Select();
			}
		}
		if (eWizardButtonState3 != 0 && eWizardButtonState3 != eWizardButtonState.Auto)
		{
			if (((Control)buttonBack).get_Visible())
			{
				((Control)buttonBack).set_Visible(false);
			}
		}
		else if (!((Control)buttonBack).get_Visible())
		{
			((Control)buttonBack).set_Visible(true);
		}
		switch (eWizardButtonState2)
		{
		case eWizardButtonState.True:
			if (!((Control)buttonBack).get_Enabled())
			{
				((Control)buttonBack).set_Enabled(true);
			}
			break;
		case eWizardButtonState.Auto:
			if (stack_0.Count <= 0 && SelectedPageIndex <= 0)
			{
				if (((Control)buttonBack).get_Enabled())
				{
					((Control)buttonBack).set_Enabled(false);
				}
			}
			else if (!((Control)buttonBack).get_Enabled())
			{
				((Control)buttonBack).set_Enabled(true);
			}
			break;
		case eWizardButtonState.False:
			if (((Control)buttonBack).get_Enabled())
			{
				((Control)buttonBack).set_Enabled(false);
			}
			break;
		}
		method_11();
		method_12();
		method_2();
	}

	private void method_11()
	{
		Form val = ((Control)this).FindForm();
		if (val == null)
		{
			return;
		}
		if (eWizardFormAcceptButton_0 == eWizardFormAcceptButton.FinishAndNext)
		{
			if (((Control)buttonFinish).get_Visible() && ((Control)buttonFinish).get_Enabled())
			{
				if (val.get_AcceptButton() != buttonFinish)
				{
					val.set_AcceptButton((IButtonControl)(object)buttonFinish);
				}
			}
			else if (val.get_AcceptButton() != buttonNext)
			{
				val.set_AcceptButton((IButtonControl)(object)buttonNext);
			}
		}
		else if (eWizardFormAcceptButton_0 == eWizardFormAcceptButton.Next)
		{
			if (val.get_AcceptButton() != buttonNext)
			{
				val.set_AcceptButton((IButtonControl)(object)buttonNext);
			}
		}
		else if (eWizardFormAcceptButton_0 == eWizardFormAcceptButton.Finish)
		{
			if (val.get_AcceptButton() != buttonFinish)
			{
				val.set_AcceptButton((IButtonControl)(object)buttonFinish);
			}
		}
		else if (eWizardFormAcceptButton_0 == eWizardFormAcceptButton.None && (val.get_AcceptButton() == buttonFinish || val.get_AcceptButton() == buttonNext))
		{
			val.set_AcceptButton((IButtonControl)null);
		}
	}

	private void method_12()
	{
		Form val = ((Control)this).FindForm();
		if (val == null)
		{
			return;
		}
		if (eWizardFormCancelButton_0 == eWizardFormCancelButton.Cancel)
		{
			if (val.get_CancelButton() != buttonCancel)
			{
				val.set_CancelButton((IButtonControl)(object)buttonCancel);
			}
		}
		else if (val.get_CancelButton() == buttonCancel)
		{
			val.set_CancelButton((IButtonControl)null);
		}
	}

	protected override void OnParentChanged(EventArgs e)
	{
		((ContainerControl)this).OnParentChanged(e);
		method_12();
		method_11();
	}

	internal void method_13(WizardPage wizardPage_0)
	{
		if (wizardPage_0 == null)
		{
			return;
		}
		Size size = new Size(7, 12);
		((Control)this).SuspendLayout();
		try
		{
			Rectangle rectangle = Rectangle.Empty;
			rectangle = ((!wizardPage_0.InteriorPage) ? new Rectangle(((Control)this).get_ClientRectangle().X, ((Control)this).get_ClientRectangle().Y, ((Control)this).get_ClientRectangle().Width, ((Control)this).get_ClientRectangle().Height - ((Control)panelFooter).get_Height()) : new Rectangle(((Control)this).get_ClientRectangle().X + size.Width, ((Control)this).get_ClientRectangle().Y + ((Control)panelHeader).get_Height() + size.Height, ((Control)this).get_ClientRectangle().Width - size.Width * 2, ((Control)this).get_ClientRectangle().Height - (((Control)panelHeader).get_Height() + ((Control)panelFooter).get_Height() + size.Height * 2)));
			TypeDescriptor.GetProperties(wizardPage_0)["Bounds"]!.SetValue(wizardPage_0, rectangle);
			TypeDescriptor.GetProperties(wizardPage_0)["Anchor"]!.SetValue(wizardPage_0, (object)(AnchorStyles)15);
		}
		finally
		{
			((Control)this).ResumeLayout();
		}
	}

	private void method_14()
	{
		if (eWizardStyle_0 == eWizardStyle.Default)
		{
			buttonBack.Style = eDotNetBarStyle.Office2000;
			buttonCancel.Style = eDotNetBarStyle.Office2000;
			buttonFinish.Style = eDotNetBarStyle.Office2000;
			buttonHelp.Style = eDotNetBarStyle.Office2000;
			buttonNext.Style = eDotNetBarStyle.Office2000;
			buttonBack.ThemeAware = true;
			buttonCancel.ThemeAware = true;
			buttonFinish.ThemeAware = true;
			buttonHelp.ThemeAware = true;
			buttonNext.ThemeAware = true;
		}
		else
		{
			buttonBack.Style = eDotNetBarStyle.Office2007;
			buttonCancel.Style = eDotNetBarStyle.Office2007;
			buttonFinish.Style = eDotNetBarStyle.Office2007;
			buttonHelp.Style = eDotNetBarStyle.Office2007;
			buttonNext.Style = eDotNetBarStyle.Office2007;
			buttonBack.ThemeAware = false;
			buttonCancel.ThemeAware = false;
			buttonFinish.ThemeAware = false;
			buttonHelp.ThemeAware = false;
			buttonNext.ThemeAware = false;
		}
	}

	protected virtual void OnBackButtonClick(CancelEventArgs e)
	{
		if (cancelEventHandler_0 != null)
		{
			cancelEventHandler_0(this, e);
		}
	}

	protected virtual void OnNextButtonClick(CancelEventArgs e)
	{
		if (cancelEventHandler_1 != null)
		{
			cancelEventHandler_1(this, e);
		}
	}

	protected virtual void OnFinishButtonClick(CancelEventArgs e)
	{
		if (cancelEventHandler_2 != null)
		{
			cancelEventHandler_2(this, e);
		}
	}

	protected virtual void OnCancelButtonClick(CancelEventArgs e)
	{
		if (cancelEventHandler_3 != null)
		{
			cancelEventHandler_3(this, e);
		}
	}

	protected virtual void OnHelpButtonClick(CancelEventArgs e)
	{
		if (cancelEventHandler_4 != null)
		{
			cancelEventHandler_4(this, e);
		}
	}

	protected virtual void OnWizardPageChanging(WizardCancelPageChangeEventArgs e)
	{
		if (wizardCancelPageChangeEventHandler_0 != null)
		{
			wizardCancelPageChangeEventHandler_0(this, e);
		}
	}

	protected virtual void OnWizardPageChanged(WizardCancelPageChangeEventArgs e)
	{
		if (wizardPageChangeEventHandler_0 != null)
		{
			wizardPageChangeEventHandler_0(this, e);
		}
	}

	protected virtual void OnLayoutWizardButtons(WizardButtonsLayoutEventArgs e)
	{
		if (wizardButtonsLayoutEventHandler_0 != null)
		{
			wizardButtonsLayoutEventHandler_0(this, e);
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		RemindForm remindForm = new RemindForm();
		remindForm.method_0();
		((Component)(object)remindForm).Dispose();
	}
}
