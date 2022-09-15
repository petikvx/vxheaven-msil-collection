using System.ComponentModel;
using System.Drawing;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[Localizable(true)]
[DesignTimeVisible(false)]
[TypeConverter(typeof(SuperTooltipInfoConverter))]
public class SuperTooltipInfo
{
	private bool bool_0 = true;

	private bool bool_1 = true;

	private string string_0 = "";

	private string string_1 = "";

	private Image image_0;

	private string string_2 = "";

	private Image image_1;

	private Size size_0 = Size.Empty;

	private eTooltipColor eTooltipColor_0 = eTooltipColor.Gray;

	[Description("Indicates whether header text is visible.")]
	[DefaultValue(true)]
	[Browsable(true)]
	[Localizable(true)]
	public bool HeaderVisible
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	[Browsable(true)]
	[Description("Indicates whether footer text is visible.")]
	[Localizable(true)]
	[DefaultValue(true)]
	public bool FooterVisible
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

	[Browsable(true)]
	[Description("Indicates header text.")]
	[DefaultValue("")]
	[Localizable(true)]
	public string HeaderText
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

	[DefaultValue("")]
	[Localizable(true)]
	[Browsable(true)]
	[Description("Indicates footer text.")]
	public string FooterText
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

	[Description("Indicates body text.")]
	[DefaultValue("")]
	[Browsable(true)]
	[Localizable(true)]
	public string BodyText
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

	[Browsable(true)]
	[DefaultValue(null)]
	[Description("Indicates body image displayed to the left of body text.")]
	[Localizable(true)]
	public Image BodyImage
	{
		get
		{
			return image_1;
		}
		set
		{
			image_1 = value;
		}
	}

	[Localizable(true)]
	[Browsable(true)]
	[DefaultValue(null)]
	[Description("Indicates footer image displayed to the left of footer text.")]
	public Image FooterImage
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
		}
	}

	[Localizable(true)]
	[Browsable(true)]
	[Description("Indicates custom size for tooltip.")]
	public Size CustomSize
	{
		get
		{
			return size_0;
		}
		set
		{
			size_0 = value;
		}
	}

	[Description("Indicates predefined tooltip color.")]
	[Localizable(true)]
	[Browsable(true)]
	[DefaultValue(eTooltipColor.Gray)]
	public eTooltipColor Color
	{
		get
		{
			return eTooltipColor_0;
		}
		set
		{
			eTooltipColor_0 = value;
		}
	}

	public SuperTooltipInfo()
	{
	}

	public SuperTooltipInfo(string headerText, string footerText, string bodyText, Image bodyImage, Image footerImage, eTooltipColor color, bool headerVisible, bool footerVisible, Size customSize)
	{
		string_0 = headerText;
		string_1 = footerText;
		string_2 = bodyText;
		image_1 = bodyImage;
		image_0 = footerImage;
		bool_0 = headerVisible;
		bool_1 = footerVisible;
		size_0 = customSize;
		eTooltipColor_0 = color;
	}

	public SuperTooltipInfo(string headerText, string footerText, string bodyText, Image bodyImage, Image footerImage, eTooltipColor color)
	{
		string_0 = headerText;
		string_1 = footerText;
		string_2 = bodyText;
		image_1 = bodyImage;
		image_0 = footerImage;
		eTooltipColor_0 = color;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeCustomSize()
	{
		return !size_0.IsEmpty;
	}
}
