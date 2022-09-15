using System.ComponentModel;

namespace DevComponents.DotNetBar;

[TypeConverter(typeof(ExpandableObjectConverter))]
[ToolboxItem(false)]
public class RibbonLocalization
{
	private string string_0 = "&Remove from Quick Access Toolbar";

	private string string_1 = "&Add to Quick Access Toolbar";

	private string string_2 = "&Customize Quick Access Toolbar...";

	private string string_3 = "&Place Quick Access Toolbar below the Ribbon";

	private string string_4 = "&Place Quick Access Toolbar above the Ribbon";

	private string string_5 = "OK";

	private string string_6 = "Cancel";

	private string string_7 = "&Add >>";

	private string string_8 = "&Remove";

	private string string_9 = "&Choose commands from:";

	private string string_10 = "&Place Quick Access Toolbar below the Ribbon";

	private string string_11 = "Customize Quick Access Toolbar";

	private string string_12 = "Mi&nimize the Ribbon";

	private string string_13 = "&Maximize the Ribbon";

	private string string_14 = "<b>Customize Quick Access Toolbar</b>";

	[Localizable(true)]
	[Description("Indicates the the title text of the Quick Access Toolbar Customize dialog form.")]
	[Category("QAT Customize Dialog")]
	[DefaultValue("Customize Quick Access Toolbar")]
	public string QatDialogCaption
	{
		get
		{
			return string_11;
		}
		set
		{
			string_11 = value;
		}
	}

	[Category("QAT Customize Dialog")]
	[Description("Indicates the text of the 'Place Quick Access Toolbar below the Ribbon' check-box on the Quick Access Toolbar Customize dialog form.")]
	[Localizable(true)]
	[DefaultValue("&Place Quick Access Toolbar below the Ribbon")]
	public string QatDialogPlacementCheckbox
	{
		get
		{
			return string_10;
		}
		set
		{
			string_10 = value;
		}
	}

	[Description("Indicates the text of the Choose commands from label on the Quick Access Toolbar Customize dialog form.")]
	[DefaultValue("&Choose commands from:")]
	[Localizable(true)]
	[Category("QAT Customize Dialog")]
	public string QatDialogCategoriesLabel
	{
		get
		{
			return string_9;
		}
		set
		{
			string_9 = value;
		}
	}

	[Localizable(true)]
	[Description("Indicates the text of the Remove button on the Quick Access Toolbar Customize dialog form.")]
	[Category("QAT Customize Dialog")]
	[DefaultValue("&Remove")]
	public string QatDialogRemoveButton
	{
		get
		{
			return string_8;
		}
		set
		{
			string_8 = value;
		}
	}

	[Category("QAT Customize Dialog")]
	[DefaultValue("&Add >>")]
	[Description("Indicates the text of the Add button on the Quick Access Toolbar Customize dialog form.")]
	[Localizable(true)]
	public string QatDialogAddButton
	{
		get
		{
			return string_7;
		}
		set
		{
			string_7 = value;
		}
	}

	[Localizable(true)]
	[DefaultValue("OK")]
	[Category("QAT Customize Dialog")]
	[Description("Indicates the text of the OK button on the Quick Access Toolbar Customize dialog form.")]
	public string QatDialogOkButton
	{
		get
		{
			return string_5;
		}
		set
		{
			string_5 = value;
		}
	}

	[Category("QAT Customize Dialog")]
	[Localizable(true)]
	[Description("Indicates the text of the OK button on the Quick Access Toolbar Customize dialog form.")]
	[DefaultValue("Cancel")]
	public string QatDialogCancelButton
	{
		get
		{
			return string_6;
		}
		set
		{
			string_6 = value;
		}
	}

	[Description("Indicates the text that is used on context menu used to customize Quick Access Toolbar.")]
	[DefaultValue("&Remove from Quick Access Toolbar")]
	[Category("Quick Access Toolbar")]
	[Localizable(true)]
	public string QatRemoveItemText
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	[Description("Indicates the text that is used on context menu used to customize Quick Access Toolbar.")]
	[Localizable(true)]
	[Category("Quick Access Toolbar")]
	[DefaultValue("&Add to Quick Access Toolbar")]
	public string QatAddItemText
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	[DefaultValue("&Customize Quick Access Toolbar...")]
	[Localizable(true)]
	[Description("Indicates the text that is used on context menu used to customize Quick Access Toolbar.")]
	[Category("Quick Access Toolbar")]
	public string QatCustomizeText
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
		}
	}

	[Description("Indicates text that is used on Quick Access Toolbar customize menu label.")]
	[DefaultValue("<b>Customize Quick Access Toolbar</b>")]
	[Localizable(true)]
	[Category("Quick Access Toolbar")]
	public string QatCustomizeMenuLabel
	{
		get
		{
			return string_14;
		}
		set
		{
			string_14 = value;
		}
	}

	[DefaultValue("&Place Quick Access Toolbar below the Ribbon")]
	[Category("Quick Access Toolbar")]
	[Description("Indicates the text that is used on context menu used to change placement of the Quick Access Toolbar.")]
	[Localizable(true)]
	public string QatPlaceBelowRibbonText
	{
		get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
		}
	}

	[Category("Quick Access Toolbar")]
	[Localizable(true)]
	[DefaultValue("&Place Quick Access Toolbar above the Ribbon")]
	[Description("Indicates the text that is used on context menu used to change placement of the Quick Access Toolbar.")]
	public string QatPlaceAboveRibbonText
	{
		get
		{
			return string_4;
		}
		set
		{
			string_4 = value;
		}
	}

	[Localizable(true)]
	[Description("Indicates text that is used on context menu item used to minimize the Ribbon.")]
	[DefaultValue("Mi&nimize the Ribbon")]
	[Category("Quick Access Toolbar")]
	public string MinimizeRibbonText
	{
		get
		{
			return string_12;
		}
		set
		{
			string_12 = value;
		}
	}

	[Description("Indicates text that is used on context menu item used to maximize the Ribbon.")]
	[DefaultValue("&Maximize the Ribbon")]
	[Localizable(true)]
	[Category("Quick Access Toolbar")]
	public string MaximizeRibbonText
	{
		get
		{
			return string_13;
		}
		set
		{
			string_13 = value;
		}
	}
}
