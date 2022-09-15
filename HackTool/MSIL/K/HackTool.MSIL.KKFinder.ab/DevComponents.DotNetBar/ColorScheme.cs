using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using DevComponents.AdvTree;

namespace DevComponents.DotNetBar;

public class ColorScheme
{
	private Color color_0;

	private bool bool_0;

	private Color color_1 = Color.Empty;

	private bool bool_1;

	private int int_0 = 90;

	private Color color_2;

	private bool bool_2;

	private Color color_3 = Color.Empty;

	private bool bool_3;

	private int int_1 = 90;

	private Color color_4;

	private bool bool_4;

	private Color color_5 = Color.Empty;

	private bool bool_5;

	private int int_2 = 90;

	private Color color_6;

	private bool bool_6;

	private Color color_7;

	private bool bool_7;

	private Color color_8 = Color.Empty;

	private bool bool_8;

	private int int_3 = 90;

	private Color color_9;

	private bool bool_9;

	private Color color_10;

	private bool bool_10;

	private Color color_11;

	private bool bool_11;

	private Color color_12;

	private bool bool_12;

	private Color color_13;

	private bool bool_13;

	private Color color_14;

	private bool bool_14;

	private Color color_15;

	private bool bool_15;

	private Color color_16;

	private bool bool_16;

	private int int_4 = 90;

	private Color color_17;

	private bool bool_17;

	private Color color_18;

	private bool bool_18;

	private Color color_19;

	private bool bool_19;

	private Color color_20;

	private bool bool_20;

	private Color color_21 = Color.Empty;

	private bool bool_21;

	private int int_5 = 90;

	private Color color_22;

	private bool bool_22;

	private Color color_23;

	private bool bool_23;

	private Color color_24;

	private bool bool_24;

	private Color color_25 = Color.Empty;

	private bool bool_25;

	private int int_6 = 90;

	private Color color_26;

	private bool bool_26;

	private Color color_27;

	private bool bool_27;

	private Color color_28;

	private bool bool_28;

	private Color color_29 = Color.Empty;

	private bool bool_29;

	private Color color_30;

	private bool bool_30;

	private Color color_31 = Color.Empty;

	private bool bool_31;

	private int int_7 = 90;

	private Color color_32;

	private bool bool_32;

	private Color color_33;

	private bool bool_33;

	private Color color_34;

	private bool bool_34;

	private Color color_35;

	private bool bool_35;

	private int int_8 = 90;

	private Color color_36 = Color.Empty;

	private bool bool_36;

	private Color color_37;

	private bool bool_37;

	private Color color_38;

	private bool bool_38;

	private Color color_39;

	private bool bool_39;

	private Color color_40;

	private bool bool_40;

	private Color color_41 = Color.Empty;

	private bool bool_41;

	private int int_9;

	private Color color_42;

	private bool bool_42;

	private Color color_43 = Color.Empty;

	private bool bool_43;

	private int int_10;

	private Color color_44;

	private bool bool_44;

	private Color color_45;

	private bool bool_45;

	private Color color_46 = Color.Empty;

	private bool bool_46;

	private int int_11;

	private Color color_47;

	private bool bool_47;

	private Color color_48 = Color.Empty;

	private bool bool_48;

	private Color color_49 = Color.Empty;

	private bool bool_49;

	private int int_12 = 90;

	private Color color_50 = Color.Empty;

	private bool bool_50;

	private Color color_51 = Color.Empty;

	private bool bool_51;

	private Color color_52 = Color.Empty;

	private bool bool_52;

	private int int_13 = 90;

	private Color color_53 = Color.Empty;

	private bool bool_53;

	private Color color_54 = Color.Empty;

	private bool bool_54;

	private Color color_55 = Color.Empty;

	private bool bool_55;

	private Color color_56 = Color.Empty;

	private bool bool_56;

	private int int_14 = 90;

	internal bool bool_57;

	private eDotNetBarStyle eDotNetBarStyle_0;

	private Color color_57 = Color.Empty;

	private bool bool_58;

	private Color color_58 = Color.Empty;

	private bool bool_59;

	private int int_15;

	private ePredefinedColorScheme ePredefinedColorScheme_0;

	private Color color_59 = Color.Empty;

	internal eDotNetBarStyle EDotNetBarStyle_0
	{
		get
		{
			return eDotNetBarStyle_0;
		}
		set
		{
			if (eDotNetBarStyle_0 != value)
			{
				eDotNetBarStyle_0 = value;
				Refresh();
			}
		}
	}

	[Description("Specifies starting color of dock site.")]
	[Browsable(true)]
	[Category("Panel Colors")]
	[DevCoBrowsable(true)]
	public Color DockSiteBackColor
	{
		get
		{
			return color_57;
		}
		set
		{
			if (color_57 != value)
			{
				color_57 = value;
				bool_58 = true;
			}
		}
	}

	[Browsable(true)]
	[Category("Panel Colors")]
	[Description("Specifies ending gradient color of dock site.")]
	[DevCoBrowsable(true)]
	public Color DockSiteBackColor2
	{
		get
		{
			return color_58;
		}
		set
		{
			if (color_58 != value)
			{
				color_58 = value;
				bool_59 = true;
			}
		}
	}

	[Description("Specifies the gradient angle.")]
	[DevCoBrowsable(true)]
	[DefaultValue(0)]
	[Category("Panel Colors")]
	[Browsable(true)]
	public int DockSiteBackColorGradientAngle
	{
		get
		{
			return int_15;
		}
		set
		{
			int_15 = value;
		}
	}

	[DevCoBrowsable(true)]
	[Description("Specifies the menu bar background color.")]
	[Browsable(true)]
	[Category("Bar Colors")]
	public Color MenuBarBackground
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
				bool_0 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Specifies the target menu bar gradient background color.")]
	[Category("Bar Colors")]
	[Browsable(true)]
	public Color MenuBarBackground2
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
				bool_1 = true;
			}
		}
	}

	[Description("Specifies the gradient angle.")]
	[DefaultValue(90)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Bar Colors")]
	public int MenuBarBackgroundGradientAngle
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	[DevCoBrowsable(true)]
	[Category("Bar Colors")]
	[Description("Specifies the background color for the bar when floating or when docked.")]
	[Browsable(true)]
	public Color BarBackground
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
				bool_2 = true;
			}
		}
	}

	[Category("Bar Colors")]
	[Description("Specifies the target gradient background color for the bar when floating or when docked.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color BarBackground2
	{
		get
		{
			return color_3;
		}
		set
		{
			if (color_3 != value)
			{
				color_3 = value;
				bool_3 = true;
			}
		}
	}

	[Category("Bar Colors")]
	[Browsable(true)]
	[Description("Specifies the gradient angle.")]
	[DevCoBrowsable(true)]
	[DefaultValue(90)]
	public int BarBackgroundGradientAngle
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
		}
	}

	[Category("Bar Colors")]
	[Description("Specifies the background color for the bar Caption.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public Color BarCaptionBackground
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
				bool_4 = true;
			}
		}
	}

	[Category("Bar Colors")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Specifies the target bar gradient background color for the bar Caption.")]
	public Color BarCaptionBackground2
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
				bool_5 = true;
			}
		}
	}

	[Category("Bar Colors")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Specifies the gradient angle.")]
	[DefaultValue(90)]
	public int BarCaptionBackgroundGradientAngle
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Bar Colors")]
	[Description("Specifies the color for text of the Caption.")]
	public Color BarCaptionText
	{
		get
		{
			return color_6;
		}
		set
		{
			if (color_6 != value)
			{
				color_6 = value;
				bool_6 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Specifies the Bar Caption inactive (lost focus) background color.")]
	[Browsable(true)]
	[Category("Bar Colors")]
	public Color BarCaptionInactiveBackground
	{
		get
		{
			return color_7;
		}
		set
		{
			if (color_7 != value)
			{
				color_7 = value;
				bool_7 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Bar Colors")]
	[Description("Specifies the target background gradient Bar Caption inactive (lost focus) color.")]
	[Browsable(true)]
	public Color BarCaptionInactiveBackground2
	{
		get
		{
			return color_8;
		}
		set
		{
			if (color_8 != value)
			{
				color_8 = value;
				bool_8 = true;
			}
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Bar Colors")]
	[DefaultValue(90)]
	[Description("Specifies the gradient angle.")]
	internal int Int32_0
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
		}
	}

	[Browsable(true)]
	[Category("Bar Colors")]
	[Description("Specifies the Bar inactive (lost focus) text color.")]
	[DevCoBrowsable(true)]
	public Color BarCaptionInactiveText
	{
		get
		{
			return color_9;
		}
		set
		{
			if (color_9 != value)
			{
				color_9 = value;
				bool_9 = true;
			}
		}
	}

	[Browsable(true)]
	[Category("Bar Colors")]
	[Description("Specifies the background color for popup bars.")]
	[DevCoBrowsable(true)]
	public Color BarPopupBackground
	{
		get
		{
			return color_10;
		}
		set
		{
			if (color_10 != value)
			{
				color_10 = value;
				bool_10 = true;
			}
		}
	}

	[Category("Bar Colors")]
	[DevCoBrowsable(true)]
	[Description("Specifies the border color for popup bars.")]
	[Browsable(true)]
	public Color BarPopupBorder
	{
		get
		{
			return color_11;
		}
		set
		{
			if (color_11 != value)
			{
				color_11 = value;
				bool_11 = true;
			}
		}
	}

	[Browsable(true)]
	[Description("Specifies the border color for docked bars.")]
	[DevCoBrowsable(true)]
	[Category("Bar Colors")]
	public Color BarDockedBorder
	{
		get
		{
			return color_12;
		}
		set
		{
			if (color_12 != value)
			{
				color_12 = value;
				bool_12 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Specifies the color of the grab handle stripes.")]
	[Category("Bar Colors")]
	[Browsable(true)]
	public Color BarStripeColor
	{
		get
		{
			return color_13;
		}
		set
		{
			if (color_13 != value)
			{
				color_13 = value;
				bool_13 = true;
			}
		}
	}

	[Description("Specifies the border color for floating bars.")]
	[Browsable(true)]
	[Category("Bar Colors")]
	[DevCoBrowsable(true)]
	public Color BarFloatingBorder
	{
		get
		{
			return color_14;
		}
		set
		{
			if (color_14 != value)
			{
				color_14 = value;
				bool_14 = true;
			}
		}
	}

	[Category("Item Colors")]
	[Browsable(true)]
	[Description("Specifies the item background color.")]
	[DevCoBrowsable(true)]
	public Color ItemBackground
	{
		get
		{
			return color_15;
		}
		set
		{
			if (color_15 != value)
			{
				color_15 = value;
				bool_15 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Specifies the target item background gradient color.")]
	[Browsable(true)]
	[Category("Item Colors")]
	public Color ItemBackground2
	{
		get
		{
			return color_16;
		}
		set
		{
			if (color_16 != value)
			{
				color_16 = value;
				bool_16 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Item Colors")]
	[Description("Specifies the gradient angle.")]
	[Browsable(true)]
	[DefaultValue(90)]
	public int ItemBackgroundGradientAngle
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
		}
	}

	[DevCoBrowsable(true)]
	[Category("Item Colors")]
	[Browsable(true)]
	[Description("Specifies the item text color.")]
	public Color ItemText
	{
		get
		{
			return color_17;
		}
		set
		{
			if (color_17 != value)
			{
				color_17 = value;
				bool_17 = true;
			}
		}
	}

	[Description("Specifies the background color for the item that is disabled.")]
	[Browsable(true)]
	[Category("Item Colors")]
	[DevCoBrowsable(true)]
	public Color ItemDisabledBackground
	{
		get
		{
			return color_18;
		}
		set
		{
			if (color_18 != value)
			{
				color_18 = value;
				bool_18 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Item Colors")]
	[Browsable(true)]
	[Description("Specifies the text color for the item that is disabled.")]
	public Color ItemDisabledText
	{
		get
		{
			return color_19;
		}
		set
		{
			if (color_19 != value)
			{
				color_19 = value;
				bool_19 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Specifies the background color when mouse is over the item.")]
	[Category("Item Colors")]
	[Browsable(true)]
	public Color ItemHotBackground
	{
		get
		{
			return color_20;
		}
		set
		{
			if (color_20 != value)
			{
				color_20 = value;
				bool_20 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Item Colors")]
	[Description("Specifies the target gradient background color when mouse is over the item.")]
	public Color ItemHotBackground2
	{
		get
		{
			return color_21;
		}
		set
		{
			if (color_21 != value)
			{
				color_21 = value;
				bool_21 = true;
			}
		}
	}

	[DefaultValue(90)]
	[Browsable(true)]
	[Description("Specifies the gradient angle.")]
	[DevCoBrowsable(true)]
	[Category("Item Colors")]
	public int ItemHotBackgroundGradientAngle
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
		}
	}

	[DevCoBrowsable(true)]
	[Category("Item Colors")]
	[Browsable(true)]
	[Description("Specifies the text color when mouse is over the item.")]
	public Color ItemHotText
	{
		get
		{
			return color_22;
		}
		set
		{
			if (color_22 != value)
			{
				color_22 = value;
				bool_22 = true;
			}
		}
	}

	[Description("Specifies the border color when mouse is over the item.")]
	[Browsable(true)]
	[Category("Item Colors")]
	[DevCoBrowsable(true)]
	public Color ItemHotBorder
	{
		get
		{
			return color_23;
		}
		set
		{
			if (color_23 != value)
			{
				color_23 = value;
				bool_23 = true;
			}
		}
	}

	[Description("Specifies the background color when item is pressed.")]
	[Category("Item Colors")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color ItemPressedBackground
	{
		get
		{
			return color_24;
		}
		set
		{
			if (color_24 != value)
			{
				color_24 = value;
				bool_24 = true;
			}
		}
	}

	[Description("Specifies the target gradient background color when item is pressed.")]
	[DevCoBrowsable(true)]
	[Category("Item Colors")]
	[Browsable(true)]
	public Color ItemPressedBackground2
	{
		get
		{
			return color_25;
		}
		set
		{
			if (color_25 != value)
			{
				color_25 = value;
				bool_25 = true;
			}
		}
	}

	[DefaultValue(90)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Item Colors")]
	[Description("Specifies the gradient angle.")]
	public int ItemPressedBackgroundGradientAngle
	{
		get
		{
			return int_6;
		}
		set
		{
			int_6 = value;
		}
	}

	[Description("Specifies the text color when item is pressed.")]
	[Browsable(true)]
	[Category("Item Colors")]
	[DevCoBrowsable(true)]
	public Color ItemPressedText
	{
		get
		{
			return color_26;
		}
		set
		{
			if (color_26 != value)
			{
				color_26 = value;
				bool_26 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Specifies the border color when item is pressed.")]
	[Category("Item Colors")]
	public Color ItemPressedBorder
	{
		get
		{
			return color_27;
		}
		set
		{
			if (color_27 != value)
			{
				color_27 = value;
				bool_27 = true;
			}
		}
	}

	[Description("Specifies the color for the item group separator.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Item Colors")]
	public Color ItemSeparator
	{
		get
		{
			return color_28;
		}
		set
		{
			if (color_28 != value)
			{
				color_28 = value;
				bool_28 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Item Colors")]
	[Description("Specifies the color for the item group separator shade.")]
	public Color ItemSeparatorShade
	{
		get
		{
			return color_29;
		}
		set
		{
			if (color_29 != value)
			{
				color_29 = value;
				bool_29 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Specifies the background color for the shadow of expanded item.")]
	[Browsable(true)]
	[Category("Item Colors")]
	public Color ItemExpandedShadow
	{
		get
		{
			return color_33;
		}
		set
		{
			if (color_33 != value)
			{
				color_33 = value;
				bool_33 = true;
			}
		}
	}

	[Category("Item Colors")]
	[Description("Specifies the background color for the expanded item.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public Color ItemExpandedBackground
	{
		get
		{
			return color_30;
		}
		set
		{
			if (color_30 != value)
			{
				color_30 = value;
				bool_30 = true;
			}
		}
	}

	[Category("Item Colors")]
	[Description("Specifies the target gradient background color for the expanded item.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color ItemExpandedBackground2
	{
		get
		{
			return color_31;
		}
		set
		{
			if (color_31 != value)
			{
				color_31 = value;
				bool_31 = true;
			}
		}
	}

	[Category("Item Colors")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(90)]
	[Description("Specifies the gradient angle.")]
	public int ItemExpandedBackgroundGradientAngle
	{
		get
		{
			return int_7;
		}
		set
		{
			int_7 = value;
		}
	}

	[Description("Specifies the text color for the expanded item.")]
	[DevCoBrowsable(true)]
	[Category("Item Colors")]
	[Browsable(true)]
	public Color ItemExpandedText
	{
		get
		{
			return color_32;
		}
		set
		{
			if (color_32 != value)
			{
				color_32 = value;
				bool_32 = true;
			}
		}
	}

	[Category("Item Colors")]
	[Browsable(true)]
	[Description("Specifies the border color for the expanded item.")]
	[DevCoBrowsable(true)]
	public Color ItemExpandedBorder
	{
		get
		{
			return color_34;
		}
		set
		{
			if (color_34 != value)
			{
				color_34 = value;
				bool_34 = true;
			}
		}
	}

	[Category("Item Colors")]
	[Description("Specifies the background color for the checked item.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public Color ItemCheckedBackground
	{
		get
		{
			return color_35;
		}
		set
		{
			if (color_35 != value)
			{
				color_35 = value;
				bool_35 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Specifies the target gradient background color for the checked item.")]
	[Category("Item Colors")]
	public Color ItemCheckedBackground2
	{
		get
		{
			return color_36;
		}
		set
		{
			if (color_36 != value)
			{
				color_36 = value;
				bool_36 = true;
			}
		}
	}

	[DefaultValue(90)]
	[Browsable(true)]
	[Category("Item Colors")]
	[Description("Specifies the gradient angle.")]
	[DevCoBrowsable(true)]
	public int ItemCheckedBackgroundGradientAngle
	{
		get
		{
			return int_8;
		}
		set
		{
			int_8 = value;
		}
	}

	[Description("Specifies the border color for the checked item.")]
	[Category("Item Colors")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color ItemCheckedBorder
	{
		get
		{
			return color_37;
		}
		set
		{
			if (color_37 != value)
			{
				color_37 = value;
				bool_37 = true;
			}
		}
	}

	[Browsable(true)]
	[Description("Specifies the text color for the checked item.")]
	[DevCoBrowsable(true)]
	[Category("Item Colors")]
	public Color ItemCheckedText
	{
		get
		{
			return color_38;
		}
		set
		{
			if (color_38 != value)
			{
				color_38 = value;
				bool_38 = true;
			}
		}
	}

	[Category("Special Item Colors")]
	[Description("Specifies the customize item background color.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public Color CustomizeBackground
	{
		get
		{
			return color_48;
		}
		set
		{
			if (color_48 != value)
			{
				color_48 = value;
				bool_48 = true;
			}
		}
	}

	[Description("Specifies the customize item target gradient background color.")]
	[DevCoBrowsable(true)]
	[Category("Special Item Colors")]
	[Browsable(true)]
	public Color CustomizeBackground2
	{
		get
		{
			return color_49;
		}
		set
		{
			if (color_49 != value)
			{
				color_49 = value;
				bool_49 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Special Item Colors")]
	[DefaultValue(90)]
	[Browsable(true)]
	[Description("Specifies the customize item background color gradient angle.")]
	public int CustomizeBackgroundGradientAngle
	{
		get
		{
			return int_12;
		}
		set
		{
			int_12 = value;
		}
	}

	[Category("Special Item Colors")]
	[Description("Specifies the customize item text color.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color CustomizeText
	{
		get
		{
			return color_50;
		}
		set
		{
			if (color_50 != value)
			{
				color_50 = value;
				bool_50 = true;
			}
		}
	}

	[Category("Menu Colors")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Specifies the color of the menu border.")]
	public Color MenuBorder
	{
		get
		{
			return color_39;
		}
		set
		{
			if (color_39 != value)
			{
				color_39 = value;
				bool_39 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Menu Colors")]
	[Description("Specifies the background color of the menu.")]
	public Color MenuBackground
	{
		get
		{
			return color_40;
		}
		set
		{
			if (color_40 != value)
			{
				color_40 = value;
				bool_40 = true;
			}
		}
	}

	[Description("Specifies the target gradient background color of the menu.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Menu Colors")]
	public Color MenuBackground2
	{
		get
		{
			return color_41;
		}
		set
		{
			if (color_41 != value)
			{
				color_41 = value;
				bool_41 = true;
			}
		}
	}

	[DefaultValue(0)]
	[Category("Menu Colors")]
	[Description("Specifies the angle of the gradient fill for the menu background.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public int MenuBackgroundGradientAngle
	{
		get
		{
			return int_9;
		}
		set
		{
			if (int_9 != value)
			{
				int_9 = value;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Menu Colors")]
	[Description("Specifies the background color of the menu part (left side)  that is showing the images.")]
	[Browsable(true)]
	public Color MenuSide
	{
		get
		{
			return color_42;
		}
		set
		{
			if (color_42 != value)
			{
				color_42 = value;
				bool_42 = true;
			}
		}
	}

	[Description("Specifies the target gradient background color of the menu part (left side)  that is showing the images.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Menu Colors")]
	public Color MenuSide2
	{
		get
		{
			return color_43;
		}
		set
		{
			if (color_43 != value)
			{
				color_43 = value;
				bool_43 = true;
			}
		}
	}

	[DefaultValue(0)]
	[Category("Menu Colors")]
	[Browsable(true)]
	[Description("Specifies the angle of the gradient fill for the menu part (left side) that is showing the images.")]
	[DevCoBrowsable(true)]
	public int MenuSideGradientAngle
	{
		get
		{
			return int_10;
		}
		set
		{
			if (int_10 != value)
			{
				int_10 = value;
			}
		}
	}

	[Browsable(true)]
	[Description("Specifies the background color for the items that were not recently used.")]
	[DevCoBrowsable(true)]
	[Category("Menu Colors")]
	public Color MenuUnusedBackground
	{
		get
		{
			return color_44;
		}
		set
		{
			if (color_44 != value)
			{
				color_44 = value;
				bool_44 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Menu Colors")]
	[Description("Specifies the side bar color for the items that were not recently used.")]
	[Browsable(true)]
	public Color MenuUnusedSide
	{
		get
		{
			return color_45;
		}
		set
		{
			if (color_45 != value)
			{
				color_45 = value;
				bool_45 = true;
			}
		}
	}

	[Category("Menu Colors")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Specifies the target gradient side bar color for the items that were not recently used.")]
	public Color MenuUnusedSide2
	{
		get
		{
			return color_46;
		}
		set
		{
			if (color_46 != value)
			{
				color_46 = value;
				bool_46 = true;
			}
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Menu Colors")]
	[DefaultValue(0)]
	[Description("Specifies the angle of the gradient fill for the menu part (left side) that is showing the images.")]
	public int MenuUnusedSideGradientAngle
	{
		get
		{
			return int_11;
		}
		set
		{
			if (int_11 != value)
			{
				int_11 = value;
			}
		}
	}

	[Category("Design Colors")]
	[DevCoBrowsable(true)]
	[Description("Specifies the border color for focused design-time item.")]
	[Browsable(true)]
	public Color ItemDesignTimeBorder
	{
		get
		{
			return color_47;
		}
		set
		{
			if (color_47 != value)
			{
				color_47 = value;
				bool_47 = true;
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(ePredefinedColorScheme.AutoGenerated)]
	[Description("Indicates predefined color scheme. By default DotNetBar will automatically change and generate color scheme depending on system colors.")]
	[Browsable(true)]
	[Category("Color Scheme")]
	public ePredefinedColorScheme PredefinedColorScheme
	{
		get
		{
			return ePredefinedColorScheme_0;
		}
		set
		{
			if (ePredefinedColorScheme_0 != value)
			{
				ePredefinedColorScheme_0 = value;
				Refresh();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Panel Colors")]
	[Browsable(true)]
	[Description("Specifies the background color of the panel.")]
	public Color PanelBackground
	{
		get
		{
			return color_51;
		}
		set
		{
			if (color_51 != value)
			{
				color_51 = value;
				bool_51 = true;
			}
		}
	}

	[Description("Specifies the target background gradient color of the panel.")]
	[Browsable(true)]
	[Category("Panel Colors")]
	[DevCoBrowsable(true)]
	public Color PanelBackground2
	{
		get
		{
			return color_52;
		}
		set
		{
			if (color_52 != value)
			{
				color_52 = value;
				bool_52 = true;
			}
		}
	}

	[Category("Panel Colors")]
	[DefaultValue(90)]
	[DevCoBrowsable(true)]
	[Description("Specifies the angle of the gradient fill for the panel background.")]
	[Browsable(true)]
	public int PanelBackgroundGradientAngle
	{
		get
		{
			return int_13;
		}
		set
		{
			if (int_13 != value)
			{
				int_13 = value;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Specifies border color of the panel.")]
	[Category("Panel Colors")]
	public Color PanelBorder
	{
		get
		{
			return color_54;
		}
		set
		{
			if (color_54 != value)
			{
				color_54 = value;
				bool_54 = true;
			}
		}
	}

	[Browsable(true)]
	[Category("Panel Colors")]
	[Description("Specifies color of the text on the panel.")]
	[DevCoBrowsable(true)]
	public Color PanelText
	{
		get
		{
			return color_53;
		}
		set
		{
			if (color_53 != value)
			{
				color_53 = value;
				bool_53 = true;
			}
		}
	}

	[Category("Explorer Bar Colors")]
	[Description("Specifies the background color of the explorer bar.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color ExplorerBarBackground
	{
		get
		{
			return color_55;
		}
		set
		{
			if (color_55 != value)
			{
				color_55 = value;
				bool_55 = true;
			}
		}
	}

	[Description("Specifies target gradient background color of the explorer bar.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Explorer Bar Colors")]
	public Color ExplorerBarBackground2
	{
		get
		{
			return color_56;
		}
		set
		{
			if (color_56 != value)
			{
				color_56 = value;
				bool_56 = true;
			}
		}
	}

	[Description("Specifies the angle of the gradient fill for the explorer bar background.")]
	[DefaultValue(90)]
	[DevCoBrowsable(true)]
	[Category("Explorer Bar Colors")]
	[Browsable(true)]
	public int ExplorerBarBackgroundGradientAngle
	{
		get
		{
			return int_14;
		}
		set
		{
			if (int_14 != value)
			{
				int_14 = value;
			}
		}
	}

	[Description("Specifies the foreground color of MDI System Item buttons.")]
	[Category("Item Colors")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color MdiSystemItemForeground
	{
		get
		{
			return color_59;
		}
		set
		{
			color_59 = value;
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	public bool SchemeChanged
	{
		get
		{
			if (!bool_4 && !bool_5 && !bool_13 && !bool_7 && !bool_8 && !bool_9 && !bool_6 && !bool_14 && !bool_10 && !bool_12 && !bool_11 && !bool_2 && !bool_3 && !bool_15 && !bool_35 && !bool_36 && !bool_37 && !bool_38 && !bool_18 && !bool_19 && !bool_33 && !bool_30 && !bool_31 && !bool_32 && !bool_34 && !bool_20 && !bool_21 && !bool_23 && !bool_22 && !bool_24 && !bool_25 && !bool_27 && !bool_26 && !bool_28 && !bool_17 && !bool_40 && !bool_41 && !bool_0 && !bool_1 && !bool_39 && !bool_42 && !bool_43 && !bool_44 && !bool_45 && !bool_46 && !bool_47 && !bool_48 && !bool_49 && !bool_58 && !bool_59 && color_59.IsEmpty)
			{
				return ePredefinedColorScheme_0 != ePredefinedColorScheme.AutoGenerated;
			}
			return true;
		}
	}

	public ColorScheme()
	{
		Refresh(null, bSystemColorEvent: false);
	}

	public ColorScheme(Graphics graphics)
	{
		Refresh(graphics, bSystemColorEvent: false);
	}

	public ColorScheme(eDotNetBarStyle style)
	{
		eDotNetBarStyle_0 = style;
		Refresh(null, bSystemColorEvent: true);
	}

	public ColorScheme(eColorSchemeStyle cs)
	{
		eDotNetBarStyle eDotNetBarStyle2 = eDotNetBarStyle.Office2003;
		switch (cs)
		{
		case eColorSchemeStyle.VS2005:
			eDotNetBarStyle2 = eDotNetBarStyle.VS2005;
			break;
		case eColorSchemeStyle.Office2007:
			eDotNetBarStyle2 = eDotNetBarStyle.Office2007;
			break;
		}
		eDotNetBarStyle_0 = eDotNetBarStyle2;
		Refresh(null, bSystemColorEvent: true);
	}

	internal void method_0(eDotNetBarStyle eDotNetBarStyle_1)
	{
		if (eDotNetBarStyle_0 != eDotNetBarStyle_1)
		{
			eDotNetBarStyle_0 = eDotNetBarStyle_1;
			Refresh(null, bSystemColorEvent: true);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDockSiteBackColor()
	{
		return bool_58;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDockSiteBackColor2()
	{
		return bool_59;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMenuBarBackground()
	{
		return bool_0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMenuBarBackground2()
	{
		return bool_1;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBarBackground()
	{
		return bool_2;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBarBackground2()
	{
		return bool_3;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBarCaptionBackground()
	{
		return bool_4;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBarCaptionBackground2()
	{
		return bool_5;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBarCaptionText()
	{
		return bool_6;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBarCaptionInactiveBackground()
	{
		return bool_7;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBarCaptionInactiveBackground2()
	{
		return bool_8;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBarCaptionInactiveText()
	{
		return bool_9;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBarPopupBackground()
	{
		return bool_10;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBarPopupBorder()
	{
		return bool_11;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBarDockedBorder()
	{
		return bool_12;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBarStripeColor()
	{
		return bool_13;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBarFloatingBorder()
	{
		return bool_14;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemBackground()
	{
		return bool_15;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemBackground2()
	{
		return bool_16;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemText()
	{
		return bool_17;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemDisabledBackground()
	{
		return bool_18;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemDisabledText()
	{
		return bool_19;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemHotBackground()
	{
		return bool_20;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemHotBackground2()
	{
		return bool_21;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemHotText()
	{
		return bool_22;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemHotBorder()
	{
		return bool_23;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemPressedBackground()
	{
		return bool_24;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemPressedBackground2()
	{
		return bool_25;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemPressedText()
	{
		return bool_26;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemPressedBorder()
	{
		return bool_27;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemSeparator()
	{
		return bool_28;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemSeparatorShade()
	{
		return bool_29;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemExpandedShadow()
	{
		return bool_33;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemExpandedBackground()
	{
		return bool_30;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemExpandedBackground2()
	{
		return bool_31;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemExpandedText()
	{
		return bool_32;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemExpandedBorder()
	{
		return bool_34;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemCheckedBackground()
	{
		return bool_35;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemCheckedBackground2()
	{
		return bool_36;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemCheckedBorder()
	{
		return bool_37;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemCheckedText()
	{
		return bool_38;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeCustomizeBackground()
	{
		return bool_48;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeCustomizeBackground2()
	{
		return bool_49;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeCustomizeText()
	{
		return bool_50;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMenuBorder()
	{
		return bool_39;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMenuBackground()
	{
		return bool_40;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMenuBackground2()
	{
		return bool_41;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMenuSide()
	{
		return bool_42;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMenuSide2()
	{
		return bool_43;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMenuUnusedBackground()
	{
		return bool_44;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMenuUnusedSide()
	{
		return bool_45;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMenuUnusedSide2()
	{
		return bool_46;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItemDesignTimeBorder()
	{
		return bool_47;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializePanelBackground()
	{
		return bool_51;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializePanelBackground2()
	{
		return bool_52;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializePanelBorder()
	{
		return bool_54;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializePanelText()
	{
		return bool_53;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeExplorerBarBackground()
	{
		return bool_55;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeExplorerBarBackground2()
	{
		return bool_56;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMdiSystemItemForeground()
	{
		return !color_59.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetMdiSystemItemForeground()
	{
		MdiSystemItemForeground = Color.Empty;
	}

	public void Refresh()
	{
		Refresh(null, bSystemColorEvent: false);
	}

	public void ResetChangedFlag()
	{
		bool_4 = false;
		bool_5 = false;
		bool_13 = false;
		bool_7 = false;
		bool_8 = false;
		bool_9 = false;
		bool_6 = false;
		bool_14 = false;
		bool_10 = false;
		bool_11 = false;
		bool_12 = false;
		bool_2 = false;
		bool_3 = false;
		bool_15 = false;
		bool_16 = false;
		bool_35 = false;
		bool_36 = false;
		bool_37 = false;
		bool_38 = false;
		bool_18 = false;
		bool_19 = false;
		bool_33 = false;
		bool_30 = false;
		bool_31 = false;
		bool_32 = false;
		bool_34 = false;
		bool_20 = false;
		bool_21 = false;
		bool_23 = false;
		bool_22 = false;
		bool_24 = false;
		bool_25 = false;
		bool_27 = false;
		bool_26 = false;
		bool_28 = false;
		bool_29 = false;
		bool_17 = false;
		bool_40 = false;
		bool_41 = false;
		bool_0 = false;
		bool_1 = false;
		bool_39 = false;
		bool_42 = false;
		bool_43 = false;
		bool_44 = false;
		bool_45 = false;
		bool_46 = false;
		bool_47 = false;
		bool_48 = false;
		bool_49 = false;
		bool_50 = false;
		bool_51 = false;
		bool_52 = false;
		bool_54 = false;
		bool_53 = false;
		bool_55 = false;
		bool_56 = false;
		color_59 = Color.Empty;
	}

	public void Refresh(Graphics graphics, bool bSystemColorEvent)
	{
		if (!bSystemColorEvent)
		{
			ResetChangedFlag();
		}
		if (ePredefinedColorScheme_0 == ePredefinedColorScheme.Blue2003)
		{
			method_7();
		}
		else if (ePredefinedColorScheme_0 == ePredefinedColorScheme.OliveGreen2003)
		{
			method_8();
		}
		else if (ePredefinedColorScheme_0 == ePredefinedColorScheme.Silver2003)
		{
			method_9();
		}
		else if (ePredefinedColorScheme_0 == ePredefinedColorScheme.SystemColors)
		{
			method_1();
		}
		else if (EDotNetBarStyle_0 == eDotNetBarStyle.Office2007)
		{
			method_13();
		}
		else
		{
			switch (Class109.Enum19_0)
			{
			case Enum19.const_1:
				if (EDotNetBarStyle_0 == eDotNetBarStyle.Office2003)
				{
					method_7();
				}
				else if (EDotNetBarStyle_0 == eDotNetBarStyle.VS2005)
				{
					method_10();
				}
				else
				{
					method_4();
				}
				break;
			case Enum19.const_3:
				if (EDotNetBarStyle_0 == eDotNetBarStyle.Office2003)
				{
					method_9();
				}
				else if (EDotNetBarStyle_0 == eDotNetBarStyle.VS2005)
				{
					method_12();
				}
				else
				{
					method_6();
				}
				break;
			case Enum19.const_2:
				if (EDotNetBarStyle_0 == eDotNetBarStyle.Office2003)
				{
					method_8();
				}
				else if (EDotNetBarStyle_0 == eDotNetBarStyle.VS2005)
				{
					method_11();
				}
				else
				{
					method_5();
				}
				break;
			default:
				method_1();
				break;
			case Enum19.const_0:
				method_1();
				break;
			}
		}
		bool flag = false;
		if (graphics == null)
		{
			IntPtr desktopWindow = Class92.GetDesktopWindow();
			if (desktopWindow != IntPtr.Zero)
			{
				graphics = Graphics.FromHwnd(desktopWindow);
				flag = true;
			}
		}
		try
		{
			if (graphics != null)
			{
				if (!color_4.IsSystemColor && !color_4.IsEmpty)
				{
					color_4 = graphics.GetNearestColor(color_4);
				}
				if (!color_5.IsSystemColor && !color_5.IsEmpty)
				{
					color_5 = graphics.GetNearestColor(color_5);
				}
				if (!color_13.IsSystemColor && !color_13.IsEmpty)
				{
					color_13 = graphics.GetNearestColor(color_13);
				}
				if (!color_7.IsSystemColor && !color_7.IsEmpty)
				{
					color_7 = graphics.GetNearestColor(color_7);
				}
				if (!color_8.IsSystemColor && !color_8.IsEmpty)
				{
					color_8 = graphics.GetNearestColor(color_8);
				}
				if (!color_9.IsSystemColor && !color_9.IsEmpty)
				{
					color_9 = graphics.GetNearestColor(color_9);
				}
				if (!color_6.IsSystemColor && !color_6.IsEmpty)
				{
					color_6 = graphics.GetNearestColor(color_6);
				}
				if (!color_14.IsSystemColor && !color_14.IsEmpty)
				{
					color_14 = graphics.GetNearestColor(color_14);
				}
				if (!color_10.IsSystemColor && !color_10.IsEmpty)
				{
					color_10 = graphics.GetNearestColor(color_10);
				}
				if (!color_11.IsSystemColor && !color_11.IsEmpty)
				{
					color_11 = graphics.GetNearestColor(color_11);
				}
				if (!color_12.IsSystemColor && !color_12.IsEmpty)
				{
					color_12 = graphics.GetNearestColor(color_12);
				}
				if (!color_2.IsSystemColor && !color_2.IsEmpty)
				{
					color_2 = graphics.GetNearestColor(color_2);
				}
				if (!color_3.IsEmpty && !color_3.IsSystemColor)
				{
					color_3 = graphics.GetNearestColor(color_3);
				}
				if (!color_15.IsEmpty)
				{
					color_15 = graphics.GetNearestColor(color_15);
				}
				if (!color_16.IsEmpty)
				{
					color_16 = graphics.GetNearestColor(color_16);
				}
				if (!color_35.IsSystemColor)
				{
					color_35 = graphics.GetNearestColor(color_35);
				}
				if (!color_36.IsEmpty && !color_36.IsSystemColor)
				{
					color_36 = graphics.GetNearestColor(color_36);
				}
				if (!color_37.IsSystemColor)
				{
					color_37 = graphics.GetNearestColor(color_37);
				}
				if (!color_38.IsSystemColor)
				{
					color_38 = graphics.GetNearestColor(color_38);
				}
				if (!color_18.IsEmpty && !color_18.IsSystemColor)
				{
					color_18 = graphics.GetNearestColor(color_18);
				}
				if (!color_19.IsSystemColor)
				{
					color_19 = graphics.GetNearestColor(color_19);
				}
				if (!color_33.IsSystemColor && !color_33.IsEmpty)
				{
					color_33 = graphics.GetNearestColor(color_33);
				}
				if (!color_30.IsSystemColor)
				{
					color_30 = graphics.GetNearestColor(color_30);
				}
				if (!color_32.IsSystemColor)
				{
					color_32 = graphics.GetNearestColor(color_32);
				}
				if (!color_34.IsSystemColor)
				{
					color_34 = graphics.GetNearestColor(color_34);
				}
				if (!color_20.IsSystemColor)
				{
					color_20 = graphics.GetNearestColor(color_20);
				}
				if (!color_21.IsEmpty && !color_21.IsSystemColor)
				{
					color_21 = graphics.GetNearestColor(color_21);
				}
				if (!color_23.IsSystemColor)
				{
					color_23 = graphics.GetNearestColor(color_23);
				}
				if (!color_22.IsSystemColor)
				{
					color_22 = graphics.GetNearestColor(color_22);
				}
				if (!color_24.IsSystemColor)
				{
					color_24 = graphics.GetNearestColor(color_24);
				}
				if (!color_25.IsEmpty && !color_25.IsSystemColor)
				{
					color_25 = graphics.GetNearestColor(color_25);
				}
				if (!color_27.IsSystemColor)
				{
					color_27 = graphics.GetNearestColor(color_27);
				}
				if (!color_26.IsSystemColor)
				{
					color_26 = graphics.GetNearestColor(color_26);
				}
				if (!color_28.IsSystemColor)
				{
					color_28 = graphics.GetNearestColor(color_28);
				}
				if (!color_29.IsSystemColor && !color_29.IsEmpty)
				{
					color_29 = graphics.GetNearestColor(color_29);
				}
				if (!color_17.IsSystemColor)
				{
					color_17 = graphics.GetNearestColor(color_17);
				}
				if (!color_40.IsSystemColor)
				{
					color_40 = graphics.GetNearestColor(color_40);
				}
				if (!color_0.IsSystemColor)
				{
					color_0 = graphics.GetNearestColor(color_0);
				}
				if (!color_1.IsEmpty && !color_1.IsSystemColor)
				{
					color_1 = graphics.GetNearestColor(color_1);
				}
				if (!color_39.IsSystemColor)
				{
					color_39 = graphics.GetNearestColor(color_39);
				}
				if (!color_42.IsSystemColor)
				{
					color_42 = graphics.GetNearestColor(color_42);
				}
				if (!color_44.IsSystemColor)
				{
					color_44 = graphics.GetNearestColor(color_44);
				}
				if (!color_45.IsSystemColor)
				{
					color_45 = graphics.GetNearestColor(color_45);
				}
				if (!color_47.IsSystemColor)
				{
					color_47 = graphics.GetNearestColor(color_47);
				}
				if (!color_48.IsEmpty && !color_48.IsSystemColor)
				{
					color_48 = graphics.GetNearestColor(color_48);
				}
				if (!color_49.IsEmpty && !color_49.IsSystemColor)
				{
					color_49 = graphics.GetNearestColor(color_49);
				}
				if (!color_50.IsEmpty && !color_50.IsSystemColor)
				{
					color_50 = graphics.GetNearestColor(color_50);
				}
			}
		}
		finally
		{
			if (flag)
			{
				graphics.Dispose();
			}
		}
	}

	private void method_1()
	{
		if (eDotNetBarStyle_0 != eDotNetBarStyle.Office2003 && eDotNetBarStyle_0 != eDotNetBarStyle.VS2005)
		{
			method_2();
		}
		else
		{
			method_3();
		}
	}

	private void method_2()
	{
		if (!bool_4)
		{
			color_4 = ColorFunctions.MenuFocusBorderColor();
		}
		color_5 = Color.Empty;
		if (!bool_13)
		{
			color_13 = SystemColors.ControlDark;
		}
		if (!bool_7)
		{
			color_7 = SystemColors.Control;
		}
		color_8 = Color.Empty;
		if (!bool_9)
		{
			color_9 = SystemColors.ControlText;
		}
		if (!bool_6)
		{
			color_6 = SystemColors.ActiveCaptionText;
		}
		if (!bool_14)
		{
			color_14 = ColorFunctions.MenuFocusBorderColor();
		}
		if (!bool_10)
		{
			color_10 = SystemColors.Control;
		}
		if (!bool_11)
		{
			color_11 = ColorFunctions.MenuFocusBorderColor();
		}
		if (!bool_2)
		{
			color_2 = ColorFunctions.ToolMenuFocusBackColor();
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_35)
		{
			color_35 = ColorFunctions.CheckBoxBackColor();
		}
		if (!bool_37)
		{
			color_37 = SystemColors.Highlight;
		}
		if (!bool_38)
		{
			color_38 = SystemColors.ControlText;
		}
		if (!bool_18)
		{
			color_18 = Color.Empty;
		}
		if (!bool_19)
		{
			color_19 = SystemColors.ControlDark;
		}
		if (!bool_33)
		{
			color_33 = SystemColors.ControlDark;
		}
		if (!bool_30)
		{
			color_30 = ColorFunctions.ToolMenuFocusBackColor();
		}
		if (!bool_32)
		{
			color_32 = SystemColors.ControlText;
		}
		if (!bool_20)
		{
			color_20 = ColorFunctions.HoverBackColor();
		}
		if (!bool_23)
		{
			color_23 = SystemColors.Highlight;
		}
		if (!bool_22)
		{
			color_22 = SystemColors.ControlText;
		}
		if (!bool_24)
		{
			color_24 = ColorFunctions.PressedBackColor();
		}
		if (!bool_27)
		{
			color_27 = SystemColors.Highlight;
		}
		if (!bool_26)
		{
			color_26 = SystemColors.ControlDarkDark;
		}
		if (!bool_28)
		{
			color_28 = SystemColors.ControlDark;
		}
		if (!bool_17)
		{
			color_17 = SystemColors.ControlText;
		}
		if (!bool_40)
		{
			color_40 = ColorFunctions.MenuBackColor();
		}
		if (!bool_0)
		{
			color_0 = SystemColors.Control;
		}
		if (!bool_39)
		{
			color_39 = SystemColors.ControlDark;
		}
		if (!bool_34)
		{
			color_34 = color_39;
		}
		if (!bool_42)
		{
			color_42 = ColorFunctions.ToolMenuFocusBackColor();
		}
		if (!bool_44)
		{
			color_44 = color_40;
		}
		if (!bool_45)
		{
			color_45 = ColorFunctions.SideRecentlyBackColor();
		}
		if (!bool_47)
		{
			color_47 = SystemColors.Highlight;
		}
		if (!bool_3)
		{
			color_3 = Color.Empty;
		}
		if (!bool_1)
		{
			color_1 = Color.Empty;
		}
		if (!bool_21)
		{
			color_21 = Color.Empty;
		}
		if (!bool_25)
		{
			color_25 = Color.Empty;
		}
		if (!bool_31)
		{
			color_31 = Color.Empty;
		}
		if (!bool_36)
		{
			color_36 = Color.Empty;
		}
		if (!bool_41)
		{
			color_41 = Color.Empty;
		}
		if (!bool_43)
		{
			color_43 = Color.Empty;
		}
		if (!bool_46)
		{
			color_46 = Color.Empty;
		}
		if (!bool_12)
		{
			color_12 = Color.Empty;
		}
		if (!bool_29)
		{
			color_29 = Color.Empty;
		}
		if (!bool_58)
		{
			color_57 = Color.Empty;
		}
		if (!bool_59)
		{
			color_58 = Color.Empty;
		}
		if (!bool_48)
		{
			color_48 = Color.Empty;
		}
		if (!bool_49)
		{
			color_49 = Color.Empty;
		}
		if (!bool_50)
		{
			color_50 = Color.Empty;
		}
		if (!bool_51)
		{
			color_51 = ControlPaint.Dark(color_2);
		}
		if (!bool_52)
		{
			color_52 = ControlPaint.DarkDark(color_2);
		}
		if (!bool_53)
		{
			color_53 = ControlPaint.LightLight(color_2);
		}
		if (!bool_54)
		{
			color_54 = ControlPaint.DarkDark(color_2);
		}
		if (!bool_55)
		{
			color_55 = color_0;
		}
		if (!bool_56)
		{
			color_56 = color_28;
		}
	}

	private void method_3()
	{
		if (!bool_4)
		{
			color_4 = ColorFunctions.MenuFocusBorderColor();
		}
		if (!bool_5)
		{
			color_5 = ControlPaint.Light(color_4);
		}
		if (!bool_13)
		{
			color_13 = SystemColors.ControlDark;
		}
		if (!bool_7)
		{
			color_7 = SystemColors.Control;
		}
		color_8 = Color.Empty;
		if (!bool_9)
		{
			color_9 = SystemColors.ControlText;
		}
		if (!bool_6)
		{
			color_6 = SystemColors.ActiveCaptionText;
		}
		if (!bool_14)
		{
			color_14 = ColorFunctions.MenuFocusBorderColor();
		}
		if (!bool_10)
		{
			color_10 = SystemColors.Control;
		}
		if (!bool_11)
		{
			color_11 = ColorFunctions.MenuFocusBorderColor();
		}
		if (!bool_2)
		{
			color_2 = ColorFunctions.MenuBackColor();
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_35)
		{
			color_35 = ColorFunctions.CheckBoxBackColor();
		}
		if (!bool_36)
		{
			color_36 = Color.Empty;
		}
		if (!bool_37)
		{
			color_37 = SystemColors.Highlight;
		}
		if (!bool_38)
		{
			color_38 = SystemColors.ControlText;
		}
		if (!bool_18)
		{
			color_18 = Color.Empty;
		}
		if (!bool_19)
		{
			color_19 = SystemColors.ControlDark;
		}
		if (!bool_33)
		{
			color_33 = Color.Empty;
		}
		if (!bool_30)
		{
			color_30 = ColorFunctions.ToolMenuFocusBackColor();
		}
		if (!bool_32)
		{
			color_32 = SystemColors.ControlText;
		}
		if (!bool_20)
		{
			color_20 = ColorFunctions.HoverBackColor3();
		}
		if (!bool_23)
		{
			color_23 = SystemColors.Highlight;
		}
		if (!bool_22)
		{
			color_22 = SystemColors.ControlText;
		}
		if (!bool_24)
		{
			color_24 = ColorFunctions.HoverBackColor2();
		}
		if (!bool_27)
		{
			color_27 = SystemColors.Highlight;
		}
		if (!bool_26)
		{
			color_26 = SystemColors.ControlDarkDark;
		}
		if (!bool_28)
		{
			color_28 = SystemColors.ControlDark;
		}
		if (!bool_17)
		{
			color_17 = SystemColors.ControlText;
		}
		if (!bool_40)
		{
			color_40 = ColorFunctions.MenuBackColor();
		}
		if (!bool_0)
		{
			color_0 = SystemColors.Control;
		}
		if (!bool_39)
		{
			color_39 = SystemColors.ControlDark;
		}
		if (!bool_34)
		{
			color_34 = color_39;
		}
		if (!bool_42)
		{
			color_42 = ColorFunctions.MenuBackColor();
		}
		if (!bool_44)
		{
			color_44 = color_40;
		}
		if (!bool_45)
		{
			color_45 = ColorFunctions.SideRecentlyBackColor();
		}
		if (!bool_47)
		{
			color_47 = SystemColors.Highlight;
		}
		if (!bool_3)
		{
			color_3 = SystemColors.Control;
		}
		if (!bool_1)
		{
			color_1 = Color.Empty;
		}
		if (!bool_21)
		{
			color_21 = ColorFunctions.HoverBackColor2();
		}
		if (!bool_25)
		{
			color_25 = ColorFunctions.HoverBackColor3();
		}
		if (!bool_31)
		{
			color_31 = Color.Empty;
		}
		if (!bool_36)
		{
			color_36 = Color.Empty;
		}
		if (!bool_41)
		{
			color_41 = Color.Empty;
		}
		if (!bool_43)
		{
			color_43 = ColorFunctions.ToolMenuFocusBackColor();
		}
		if (!bool_46)
		{
			color_46 = Color.Empty;
		}
		if (!bool_12)
		{
			color_12 = SystemColors.Control;
		}
		if (!bool_29)
		{
			color_29 = SystemColors.ControlLightLight;
		}
		if (!bool_58)
		{
			color_57 = SystemColors.Control;
		}
		if (!bool_59)
		{
			color_58 = ColorFunctions.MenuBackColor();
		}
		if (!bool_48)
		{
			color_48 = SystemColors.ControlDark;
		}
		if (!bool_49)
		{
			color_49 = ColorFunctions.MenuFocusBorderColor();
		}
		if (!bool_50)
		{
			color_50 = SystemColors.ControlText;
		}
		if (!bool_51)
		{
			color_51 = color_3;
		}
		if (!bool_52)
		{
			color_52 = ControlPaint.Dark(color_3);
		}
		if (!bool_53)
		{
			color_53 = ControlPaint.LightLight(color_2);
		}
		if (!bool_54)
		{
			color_54 = ControlPaint.DarkDark(color_3);
		}
		if (!bool_55)
		{
			color_55 = color_0;
		}
		if (!bool_56)
		{
			color_56 = color_28;
		}
	}

	private void method_4()
	{
		if (!bool_2)
		{
			color_2 = Color.FromArgb(239, 237, 222);
		}
		if (!bool_13)
		{
			color_13 = Color.FromArgb(191, 188, 177);
		}
		if (!bool_4)
		{
			color_4 = Color.FromArgb(172, 168, 153);
		}
		color_5 = Color.Empty;
		if (!bool_7)
		{
			color_7 = SystemColors.Control;
		}
		color_8 = Color.Empty;
		if (!bool_9)
		{
			color_9 = SystemColors.ControlText;
		}
		if (!bool_6)
		{
			color_6 = Color.FromArgb(64, 64, 64);
		}
		if (!bool_14)
		{
			color_14 = Color.FromArgb(172, 168, 153);
		}
		if (!bool_10)
		{
			color_10 = Color.FromArgb(252, 252, 249);
		}
		if (!bool_11)
		{
			color_11 = Color.FromArgb(138, 134, 122);
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_35)
		{
			color_35 = Color.FromArgb(225, 230, 232);
		}
		if (!bool_37)
		{
			color_37 = SystemColors.Highlight;
		}
		if (!bool_38)
		{
			color_38 = SystemColors.ControlText;
		}
		if (!bool_18)
		{
			color_18 = Color.Empty;
		}
		if (!bool_19)
		{
			color_19 = SystemColors.ControlDark;
		}
		if (!bool_33)
		{
			color_33 = SystemColors.ControlDark;
		}
		if (!bool_30)
		{
			color_30 = Color.FromArgb(239, 237, 222);
		}
		if (!bool_32)
		{
			color_32 = SystemColors.ControlText;
		}
		if (!bool_20)
		{
			color_20 = Color.FromArgb(193, 210, 238);
		}
		if (!bool_23)
		{
			color_23 = SystemColors.Highlight;
		}
		if (!bool_22)
		{
			color_22 = SystemColors.ControlText;
		}
		if (!bool_24)
		{
			color_24 = Color.FromArgb(152, 181, 226);
		}
		if (!bool_27)
		{
			color_27 = SystemColors.Highlight;
		}
		if (!bool_26)
		{
			color_26 = Color.FromArgb(73, 73, 73);
		}
		if (!bool_28)
		{
			color_28 = Color.FromArgb(197, 194, 184);
		}
		if (!bool_17)
		{
			color_17 = SystemColors.ControlText;
		}
		if (!bool_40)
		{
			color_40 = Color.FromArgb(252, 252, 249);
		}
		if (!bool_0)
		{
			color_0 = SystemColors.Control;
		}
		if (!bool_39)
		{
			color_39 = SystemColors.ControlDark;
		}
		if (!bool_34)
		{
			color_34 = color_39;
		}
		if (!bool_42)
		{
			color_42 = Color.FromArgb(239, 237, 222);
		}
		if (!bool_44)
		{
			color_44 = color_40;
		}
		if (!bool_45)
		{
			color_45 = Color.FromArgb(230, 227, 210);
		}
		if (!bool_47)
		{
			color_47 = SystemColors.Highlight;
		}
		if (!bool_3)
		{
			color_3 = Color.Empty;
		}
		if (!bool_1)
		{
			color_1 = Color.Empty;
		}
		if (!bool_21)
		{
			color_21 = Color.Empty;
		}
		if (!bool_25)
		{
			color_25 = Color.Empty;
		}
		if (!bool_31)
		{
			color_31 = Color.Empty;
		}
		if (!bool_36)
		{
			color_36 = Color.Empty;
		}
		if (!bool_41)
		{
			color_41 = Color.Empty;
		}
		if (!bool_43)
		{
			color_43 = Color.Empty;
		}
		if (!bool_46)
		{
			color_46 = Color.Empty;
		}
		if (!bool_12)
		{
			color_12 = Color.Empty;
		}
		if (!bool_29)
		{
			color_29 = Color.Empty;
		}
		if (!bool_58)
		{
			color_57 = Color.Empty;
		}
		if (!bool_59)
		{
			color_58 = Color.Empty;
		}
		if (!bool_48)
		{
			color_48 = Color.Empty;
		}
		if (!bool_49)
		{
			color_49 = Color.Empty;
		}
		if (!bool_50)
		{
			color_50 = Color.Empty;
		}
		if (!bool_51)
		{
			color_51 = Color.FromArgb(89, 135, 214);
		}
		if (!bool_52)
		{
			color_52 = Color.FromArgb(3, 56, 148);
		}
		if (!bool_53)
		{
			color_53 = Color.White;
		}
		if (!bool_54)
		{
			color_54 = Color.FromArgb(0, 45, 150);
		}
		if (!bool_55)
		{
			color_55 = Color.FromArgb(123, 162, 231);
		}
		if (!bool_56)
		{
			color_56 = Color.FromArgb(99, 117, 214);
		}
	}

	private void method_5()
	{
		if (!bool_2)
		{
			color_2 = Color.FromArgb(239, 237, 222);
		}
		if (!bool_13)
		{
			color_13 = Color.FromArgb(191, 188, 177);
		}
		if (!bool_4)
		{
			color_4 = Color.FromArgb(153, 153, 153);
		}
		color_5 = Color.Empty;
		if (!bool_7)
		{
			color_7 = SystemColors.Control;
		}
		color_8 = Color.Empty;
		if (!bool_9)
		{
			color_9 = SystemColors.ControlText;
		}
		if (!bool_6)
		{
			color_6 = Color.FromArgb(64, 64, 64);
		}
		if (!bool_14)
		{
			color_14 = Color.FromArgb(153, 153, 153);
		}
		if (!bool_10)
		{
			color_10 = Color.FromArgb(252, 252, 249);
		}
		if (!bool_11)
		{
			color_11 = Color.FromArgb(138, 134, 122);
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_35)
		{
			color_35 = Color.FromArgb(234, 235, 223);
		}
		if (!bool_37)
		{
			color_37 = SystemColors.Highlight;
		}
		if (!bool_38)
		{
			color_38 = SystemColors.ControlText;
		}
		if (!bool_18)
		{
			color_18 = Color.Empty;
		}
		if (!bool_19)
		{
			color_19 = SystemColors.ControlDark;
		}
		if (!bool_33)
		{
			color_33 = SystemColors.ControlDark;
		}
		if (!bool_30)
		{
			color_30 = Color.FromArgb(239, 237, 222);
		}
		if (!bool_32)
		{
			color_32 = SystemColors.ControlText;
		}
		if (!bool_20)
		{
			color_20 = Color.FromArgb(206, 209, 195);
		}
		if (!bool_23)
		{
			color_23 = SystemColors.Highlight;
		}
		if (!bool_22)
		{
			color_22 = SystemColors.ControlText;
		}
		if (!bool_24)
		{
			color_24 = Color.FromArgb(201, 208, 184);
		}
		if (!bool_27)
		{
			color_27 = SystemColors.Highlight;
		}
		if (!bool_26)
		{
			color_26 = Color.FromArgb(102, 102, 102);
		}
		if (!bool_28)
		{
			color_28 = Color.FromArgb(197, 194, 184);
		}
		if (!bool_17)
		{
			color_17 = SystemColors.ControlText;
		}
		if (!bool_40)
		{
			color_40 = Color.FromArgb(252, 252, 249);
		}
		if (!bool_0)
		{
			color_0 = SystemColors.Control;
		}
		if (!bool_39)
		{
			color_39 = SystemColors.ControlDark;
		}
		if (!bool_34)
		{
			color_34 = color_39;
		}
		if (!bool_42)
		{
			color_42 = Color.FromArgb(239, 237, 222);
		}
		if (!bool_44)
		{
			color_44 = color_40;
		}
		if (!bool_45)
		{
			color_45 = Color.FromArgb(230, 227, 210);
		}
		if (!bool_47)
		{
			color_47 = SystemColors.Highlight;
		}
		if (!bool_3)
		{
			color_3 = Color.Empty;
		}
		if (!bool_1)
		{
			color_1 = Color.Empty;
		}
		if (!bool_21)
		{
			color_21 = Color.Empty;
		}
		if (!bool_25)
		{
			color_25 = Color.Empty;
		}
		if (!bool_31)
		{
			color_31 = Color.Empty;
		}
		if (!bool_36)
		{
			color_36 = Color.Empty;
		}
		if (!bool_41)
		{
			color_41 = Color.Empty;
		}
		if (!bool_43)
		{
			color_43 = Color.Empty;
		}
		if (!bool_46)
		{
			color_46 = Color.Empty;
		}
		if (!bool_12)
		{
			color_12 = Color.Empty;
		}
		if (!bool_29)
		{
			color_29 = Color.Empty;
		}
		if (!bool_58)
		{
			color_57 = Color.Empty;
		}
		if (!bool_59)
		{
			color_58 = Color.Empty;
		}
		if (!bool_48)
		{
			color_48 = Color.Empty;
		}
		if (!bool_49)
		{
			color_49 = Color.Empty;
		}
		if (!bool_50)
		{
			color_50 = Color.Empty;
		}
		if (!bool_51)
		{
			color_51 = Color.FromArgb(175, 192, 130);
		}
		if (!bool_52)
		{
			color_52 = Color.FromArgb(99, 122, 68);
		}
		if (!bool_53)
		{
			color_53 = Color.White;
		}
		if (!bool_54)
		{
			color_54 = Color.FromArgb(96, 128, 88);
		}
		if (!bool_55)
		{
			color_55 = Color.FromArgb(204, 217, 173);
		}
		if (!bool_56)
		{
			color_56 = Color.FromArgb(165, 189, 132);
		}
	}

	private void method_6()
	{
		if (!bool_2)
		{
			color_2 = Color.FromArgb(229, 228, 232);
		}
		if (!bool_13)
		{
			color_13 = Color.FromArgb(179, 179, 182);
		}
		if (!bool_4)
		{
			color_4 = Color.FromArgb(157, 157, 161);
		}
		color_5 = Color.Empty;
		if (!bool_7)
		{
			color_7 = SystemColors.Control;
		}
		color_8 = Color.Empty;
		if (!bool_9)
		{
			color_9 = SystemColors.ControlText;
		}
		if (!bool_6)
		{
			color_6 = Color.FromArgb(53, 53, 53);
		}
		if (!bool_14)
		{
			color_14 = Color.FromArgb(157, 157, 161);
		}
		if (!bool_10)
		{
			color_10 = Color.FromArgb(251, 250, 251);
		}
		if (!bool_11)
		{
			color_11 = Color.FromArgb(126, 126, 129);
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_35)
		{
			color_35 = Color.FromArgb(233, 234, 237);
		}
		if (!bool_37)
		{
			color_37 = SystemColors.Highlight;
		}
		if (!bool_38)
		{
			color_38 = SystemColors.ControlText;
		}
		if (!bool_18)
		{
			color_18 = Color.Empty;
		}
		if (!bool_19)
		{
			color_19 = SystemColors.ControlDark;
		}
		if (!bool_33)
		{
			color_33 = SystemColors.ControlDark;
		}
		if (!bool_30)
		{
			color_30 = Color.FromArgb(229, 228, 232);
		}
		if (!bool_32)
		{
			color_32 = SystemColors.ControlText;
		}
		if (!bool_20)
		{
			color_20 = Color.FromArgb(199, 199, 202);
		}
		if (!bool_23)
		{
			color_23 = Color.FromArgb(169, 171, 181);
		}
		if (!bool_22)
		{
			color_22 = SystemColors.ControlText;
		}
		if (!bool_24)
		{
			color_24 = Color.FromArgb(210, 211, 216);
		}
		if (!bool_27)
		{
			color_27 = SystemColors.Highlight;
		}
		if (!bool_26)
		{
			color_26 = SystemColors.ControlText;
		}
		if (!bool_28)
		{
			color_28 = Color.FromArgb(186, 186, 189);
		}
		if (!bool_17)
		{
			color_17 = SystemColors.ControlText;
		}
		if (!bool_40)
		{
			color_40 = Color.FromArgb(251, 250, 251);
		}
		if (!bool_0)
		{
			color_0 = SystemColors.Control;
		}
		if (!bool_39)
		{
			color_39 = SystemColors.ControlDark;
		}
		if (!bool_34)
		{
			color_34 = color_39;
		}
		if (!bool_42)
		{
			color_42 = Color.FromArgb(229, 228, 232);
		}
		if (!bool_44)
		{
			color_44 = color_40;
		}
		if (!bool_45)
		{
			color_45 = Color.FromArgb(217, 216, 220);
		}
		if (!bool_47)
		{
			color_47 = SystemColors.Highlight;
		}
		if (!bool_3)
		{
			color_3 = Color.Empty;
		}
		if (!bool_1)
		{
			color_1 = Color.Empty;
		}
		if (!bool_21)
		{
			color_21 = Color.Empty;
		}
		if (!bool_25)
		{
			color_25 = Color.Empty;
		}
		if (!bool_31)
		{
			color_31 = Color.Empty;
		}
		if (!bool_36)
		{
			color_36 = Color.Empty;
		}
		if (!bool_41)
		{
			color_41 = Color.Empty;
		}
		if (!bool_43)
		{
			color_43 = Color.Empty;
		}
		if (!bool_46)
		{
			color_46 = Color.Empty;
		}
		if (!bool_12)
		{
			color_12 = Color.Empty;
		}
		if (!bool_29)
		{
			color_29 = Color.Empty;
		}
		if (!bool_58)
		{
			color_57 = Color.Empty;
		}
		if (!bool_59)
		{
			color_58 = Color.Empty;
		}
		if (!bool_48)
		{
			color_48 = Color.Empty;
		}
		if (!bool_49)
		{
			color_49 = Color.Empty;
		}
		if (!bool_50)
		{
			color_50 = Color.Empty;
		}
		if (!bool_51)
		{
			color_51 = Color.FromArgb(168, 167, 191);
		}
		if (!bool_52)
		{
			color_52 = Color.FromArgb(112, 111, 145);
		}
		if (!bool_53)
		{
			color_53 = Color.White;
		}
		if (!bool_54)
		{
			color_54 = Color.FromArgb(124, 124, 148);
		}
		if (!bool_55)
		{
			color_55 = Color.FromArgb(196, 200, 212);
		}
		if (!bool_56)
		{
			color_56 = Color.FromArgb(177, 179, 200);
		}
	}

	private void method_7()
	{
		if (!bool_2)
		{
			color_2 = Color.FromArgb(223, 237, 254);
		}
		if (!bool_3)
		{
			color_3 = Color.FromArgb(142, 179, 231);
		}
		if (!bool_13)
		{
			color_13 = Color.FromArgb(39, 65, 118);
		}
		if (!bool_4)
		{
			color_4 = GetColor(6721760);
		}
		if (!bool_5)
		{
			color_5 = Color.FromArgb(42, 102, 201);
		}
		if (!bool_7)
		{
			color_7 = GetColor(6724095);
		}
		if (!bool_8)
		{
			color_8 = GetColor(5602242);
		}
		if (!bool_9)
		{
			color_9 = Color.White;
		}
		if (!bool_6)
		{
			color_6 = Color.White;
		}
		if (!bool_14)
		{
			color_14 = Color.FromArgb(42, 102, 201);
		}
		if (!bool_10)
		{
			color_10 = Color.FromArgb(246, 246, 246);
		}
		if (!bool_11)
		{
			color_11 = Color.FromArgb(0, 45, 150);
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_35)
		{
			color_35 = Color.FromArgb(255, 213, 140);
		}
		if (!bool_36)
		{
			color_36 = Color.FromArgb(255, 173, 85);
		}
		if (!bool_37)
		{
			color_37 = Color.FromArgb(0, 0, 128);
		}
		if (!bool_38)
		{
			color_38 = SystemColors.ControlText;
		}
		if (!bool_18)
		{
			color_18 = Color.Empty;
		}
		if (!bool_19)
		{
			color_19 = Color.FromArgb(141, 141, 141);
		}
		if (!bool_33)
		{
			color_33 = Color.Empty;
		}
		if (!bool_30)
		{
			color_30 = Color.FromArgb(227, 239, 255);
		}
		if (!bool_31)
		{
			color_31 = Color.FromArgb(147, 181, 231);
		}
		if (!bool_32)
		{
			color_32 = SystemColors.ControlText;
		}
		if (!bool_20)
		{
			color_20 = Color.FromArgb(255, 244, 204);
		}
		if (!bool_21)
		{
			color_21 = Color.FromArgb(255, 208, 145);
		}
		if (!bool_23)
		{
			color_23 = Color.FromArgb(0, 0, 128);
		}
		if (!bool_22)
		{
			color_22 = SystemColors.ControlText;
		}
		if (!bool_24)
		{
			color_24 = Color.FromArgb(254, 142, 75);
		}
		if (!bool_25)
		{
			color_25 = Color.FromArgb(255, 207, 139);
		}
		if (!bool_27)
		{
			color_27 = Color.FromArgb(0, 0, 128);
		}
		if (!bool_26)
		{
			color_26 = SystemColors.ControlText;
		}
		if (!bool_28)
		{
			color_28 = Color.FromArgb(106, 140, 203);
		}
		if (!bool_29)
		{
			color_29 = Color.FromArgb(241, 249, 255);
		}
		if (!bool_17)
		{
			color_17 = SystemColors.ControlText;
		}
		if (!bool_40)
		{
			color_40 = Color.FromArgb(246, 246, 246);
		}
		if (!bool_41)
		{
			color_41 = Color.Empty;
		}
		if (!bool_0)
		{
			color_0 = Color.FromArgb(158, 190, 245);
		}
		if (!bool_39)
		{
			color_39 = Color.FromArgb(0, 45, 150);
		}
		if (!bool_34)
		{
			color_34 = color_39;
		}
		if (!bool_42)
		{
			color_42 = Color.FromArgb(227, 239, 255);
		}
		if (!bool_43)
		{
			color_43 = Color.FromArgb(135, 173, 228);
		}
		if (!bool_44)
		{
			color_44 = color_40;
		}
		if (!bool_45)
		{
			color_45 = Color.FromArgb(203, 221, 246);
		}
		if (!bool_46)
		{
			color_46 = Color.FromArgb(121, 161, 220);
		}
		if (!bool_47)
		{
			color_47 = Color.FromArgb(0, 0, 128);
		}
		if (!bool_12)
		{
			color_12 = Color.FromArgb(59, 97, 156);
		}
		if (!bool_58)
		{
			color_57 = Color.FromArgb(158, 190, 245);
		}
		if (!bool_59)
		{
			color_58 = Color.FromArgb(195, 218, 249);
		}
		if (!bool_48)
		{
			color_48 = Color.FromArgb(117, 166, 241);
		}
		if (!bool_49)
		{
			color_49 = Color.FromArgb(0, 53, 145);
		}
		if (!bool_50)
		{
			color_50 = SystemColors.ControlText;
		}
		if (!bool_51)
		{
			color_51 = Color.FromArgb(89, 135, 214);
		}
		if (!bool_52)
		{
			color_52 = Color.FromArgb(3, 56, 148);
		}
		if (!bool_53)
		{
			color_53 = Color.White;
		}
		if (!bool_54)
		{
			color_54 = Color.FromArgb(0, 45, 150);
		}
		if (!bool_55)
		{
			color_55 = Color.FromArgb(123, 162, 231);
		}
		if (!bool_56)
		{
			color_56 = Color.FromArgb(99, 117, 214);
		}
	}

	private void method_8()
	{
		if (!bool_2)
		{
			color_2 = Color.FromArgb(244, 247, 222);
		}
		if (!bool_3)
		{
			color_3 = Color.FromArgb(183, 198, 145);
		}
		if (!bool_13)
		{
			color_13 = Color.FromArgb(81, 94, 51);
		}
		if (!bool_4)
		{
			color_4 = Color.FromArgb(183, 198, 145);
		}
		if (!bool_5)
		{
			color_5 = Color.FromArgb(116, 134, 94);
		}
		if (!bool_7)
		{
			color_7 = GetColor(13753270);
		}
		if (!bool_8)
		{
			color_8 = Color.FromArgb(116, 134, 94);
		}
		if (!bool_9)
		{
			color_9 = Color.White;
		}
		if (!bool_6)
		{
			color_6 = Color.White;
		}
		if (!bool_14)
		{
			color_14 = Color.FromArgb(116, 134, 94);
		}
		if (!bool_10)
		{
			color_10 = Color.FromArgb(244, 244, 238);
		}
		if (!bool_11)
		{
			color_11 = Color.FromArgb(117, 141, 94);
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_35)
		{
			color_35 = Color.FromArgb(255, 213, 140);
		}
		if (!bool_36)
		{
			color_36 = Color.FromArgb(255, 173, 85);
		}
		if (!bool_37)
		{
			color_37 = Color.FromArgb(63, 93, 56);
		}
		if (!bool_38)
		{
			color_38 = SystemColors.ControlText;
		}
		if (!bool_18)
		{
			color_18 = Color.Empty;
		}
		if (!bool_19)
		{
			color_19 = Color.FromArgb(141, 141, 141);
		}
		if (!bool_33)
		{
			color_33 = Color.Empty;
		}
		if (!bool_30)
		{
			color_30 = Color.FromArgb(236, 240, 213);
		}
		if (!bool_31)
		{
			color_31 = Color.FromArgb(194, 206, 159);
		}
		if (!bool_32)
		{
			color_32 = SystemColors.ControlText;
		}
		if (!bool_20)
		{
			color_20 = Color.FromArgb(255, 244, 204);
		}
		if (!bool_21)
		{
			color_21 = Color.FromArgb(255, 208, 145);
		}
		if (!bool_23)
		{
			color_23 = Color.FromArgb(63, 93, 56);
		}
		if (!bool_22)
		{
			color_22 = SystemColors.ControlText;
		}
		if (!bool_24)
		{
			color_24 = Color.FromArgb(254, 142, 75);
		}
		if (!bool_25)
		{
			color_25 = Color.FromArgb(255, 207, 139);
		}
		if (!bool_27)
		{
			color_27 = Color.FromArgb(63, 93, 56);
		}
		if (!bool_26)
		{
			color_26 = SystemColors.ControlText;
		}
		if (!bool_28)
		{
			color_28 = Color.FromArgb(96, 128, 88);
		}
		if (!bool_29)
		{
			color_29 = Color.FromArgb(244, 247, 222);
		}
		if (!bool_17)
		{
			color_17 = SystemColors.ControlText;
		}
		if (!bool_40)
		{
			color_40 = Color.FromArgb(244, 244, 238);
		}
		if (!bool_41)
		{
			color_41 = Color.Empty;
		}
		if (!bool_0)
		{
			color_0 = Color.FromArgb(217, 217, 168);
		}
		if (!bool_39)
		{
			color_39 = Color.FromArgb(117, 141, 94);
		}
		if (!bool_34)
		{
			color_34 = color_39;
		}
		if (!bool_42)
		{
			color_42 = Color.FromArgb(255, 255, 237);
		}
		if (!bool_43)
		{
			color_43 = Color.FromArgb(184, 199, 146);
		}
		if (!bool_44)
		{
			color_44 = color_40;
		}
		if (!bool_45)
		{
			color_45 = Color.FromArgb(230, 230, 239);
		}
		if (!bool_46)
		{
			color_46 = Color.FromArgb(164, 180, 120);
		}
		if (!bool_47)
		{
			color_47 = Color.FromArgb(63, 93, 56);
		}
		if (!bool_12)
		{
			color_12 = Color.FromArgb(96, 128, 88);
		}
		if (!bool_58)
		{
			color_57 = Color.FromArgb(217, 217, 167);
		}
		if (!bool_59)
		{
			color_58 = Color.FromArgb(242, 240, 228);
		}
		if (!bool_48)
		{
			color_48 = Color.FromArgb(176, 194, 140);
		}
		if (!bool_49)
		{
			color_49 = Color.FromArgb(96, 119, 107);
		}
		if (!bool_50)
		{
			color_50 = SystemColors.ControlText;
		}
		if (!bool_51)
		{
			color_51 = Color.FromArgb(175, 192, 130);
		}
		if (!bool_52)
		{
			color_52 = Color.FromArgb(99, 122, 68);
		}
		if (!bool_53)
		{
			color_53 = Color.White;
		}
		if (!bool_54)
		{
			color_54 = Color.FromArgb(96, 128, 88);
		}
		if (!bool_55)
		{
			color_55 = Color.FromArgb(204, 217, 173);
		}
		if (!bool_56)
		{
			color_56 = Color.FromArgb(165, 189, 132);
		}
	}

	private void method_9()
	{
		if (!bool_2)
		{
			color_2 = Color.FromArgb(243, 244, 250);
		}
		if (!bool_3)
		{
			color_3 = Color.FromArgb(153, 151, 181);
		}
		if (!bool_13)
		{
			color_13 = Color.FromArgb(84, 84, 117);
		}
		if (!bool_4)
		{
			color_4 = Color.FromArgb(153, 151, 181);
		}
		if (!bool_5)
		{
			color_5 = Color.FromArgb(122, 121, 153);
		}
		if (!bool_7)
		{
			color_7 = GetColor(10921655);
		}
		if (!bool_8)
		{
			color_8 = Color.FromArgb(122, 121, 153);
		}
		if (!bool_9)
		{
			color_9 = Color.White;
		}
		if (!bool_6)
		{
			color_6 = Color.White;
		}
		if (!bool_14)
		{
			color_14 = Color.FromArgb(122, 121, 153);
		}
		if (!bool_10)
		{
			color_10 = Color.FromArgb(253, 250, 255);
		}
		if (!bool_11)
		{
			color_11 = Color.FromArgb(124, 124, 148);
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_35)
		{
			color_35 = Color.FromArgb(255, 213, 140);
		}
		if (!bool_36)
		{
			color_36 = Color.FromArgb(255, 173, 85);
		}
		if (!bool_37)
		{
			color_37 = Color.FromArgb(75, 75, 111);
		}
		if (!bool_38)
		{
			color_38 = SystemColors.ControlText;
		}
		if (!bool_18)
		{
			color_18 = Color.Empty;
		}
		if (!bool_19)
		{
			color_19 = Color.FromArgb(141, 141, 141);
		}
		if (!bool_33)
		{
			color_33 = Color.Empty;
		}
		if (!bool_30)
		{
			color_30 = Color.FromArgb(232, 233, 241);
		}
		if (!bool_31)
		{
			color_31 = Color.FromArgb(177, 176, 198);
		}
		if (!bool_32)
		{
			color_32 = SystemColors.ControlText;
		}
		if (!bool_20)
		{
			color_20 = Color.FromArgb(255, 244, 204);
		}
		if (!bool_21)
		{
			color_21 = Color.FromArgb(255, 208, 145);
		}
		if (!bool_23)
		{
			color_23 = Color.FromArgb(75, 75, 111);
		}
		if (!bool_22)
		{
			color_22 = SystemColors.ControlText;
		}
		if (!bool_24)
		{
			color_24 = Color.FromArgb(254, 142, 75);
		}
		if (!bool_25)
		{
			color_25 = Color.FromArgb(255, 207, 139);
		}
		if (!bool_27)
		{
			color_27 = Color.FromArgb(75, 75, 111);
		}
		if (!bool_26)
		{
			color_26 = SystemColors.ControlText;
		}
		if (!bool_28)
		{
			color_28 = Color.FromArgb(110, 109, 143);
		}
		if (!bool_29)
		{
			color_29 = Color.White;
		}
		if (!bool_17)
		{
			color_17 = SystemColors.ControlText;
		}
		if (!bool_40)
		{
			color_40 = Color.FromArgb(253, 250, 255);
		}
		if (!bool_41)
		{
			color_41 = Color.Empty;
		}
		if (!bool_0)
		{
			color_0 = Color.FromArgb(215, 215, 229);
		}
		if (!bool_39)
		{
			color_39 = Color.FromArgb(124, 124, 148);
		}
		if (!bool_34)
		{
			color_34 = color_39;
		}
		if (!bool_42)
		{
			color_42 = Color.FromArgb(249, 249, 255);
		}
		if (!bool_43)
		{
			color_43 = Color.FromArgb(159, 157, 185);
		}
		if (!bool_44)
		{
			color_44 = color_40;
		}
		if (!bool_45)
		{
			color_45 = Color.FromArgb(215, 215, 226);
		}
		if (!bool_46)
		{
			color_46 = Color.FromArgb(128, 126, 158);
		}
		if (!bool_47)
		{
			color_47 = Color.FromArgb(84, 84, 117);
		}
		if (!bool_12)
		{
			color_12 = Color.FromArgb(124, 124, 148);
		}
		if (!bool_58)
		{
			color_57 = Color.FromArgb(215, 215, 229);
		}
		if (!bool_59)
		{
			color_58 = Color.FromArgb(243, 243, 247);
		}
		if (!bool_48)
		{
			color_48 = Color.FromArgb(179, 178, 200);
		}
		if (!bool_49)
		{
			color_49 = Color.FromArgb(118, 116, 146);
		}
		if (!bool_50)
		{
			color_50 = SystemColors.ControlText;
		}
		if (!bool_51)
		{
			color_51 = Color.FromArgb(168, 167, 191);
		}
		if (!bool_52)
		{
			color_52 = Color.FromArgb(112, 111, 145);
		}
		if (!bool_53)
		{
			color_53 = Color.White;
		}
		if (!bool_54)
		{
			color_54 = Color.FromArgb(124, 124, 148);
		}
		if (!bool_55)
		{
			color_55 = Color.FromArgb(196, 200, 212);
		}
		if (!bool_56)
		{
			color_56 = Color.FromArgb(177, 179, 200);
		}
	}

	private void method_10()
	{
		if (!bool_2)
		{
			color_2 = Color.FromArgb(251, 250, 247);
		}
		if (!bool_3)
		{
			color_3 = Color.FromArgb(181, 181, 154);
		}
		if (!bool_13)
		{
			color_13 = Color.FromArgb(193, 190, 179);
		}
		if (!bool_4)
		{
			color_4 = Color.FromArgb(0, 84, 227);
		}
		if (!bool_5)
		{
			color_5 = Color.FromArgb(60, 148, 254);
		}
		if (!bool_7)
		{
			color_7 = GetColor(13420474);
		}
		if (!bool_8)
		{
			color_8 = Color.Empty;
		}
		if (!bool_9)
		{
			color_9 = Color.Black;
		}
		if (!bool_6)
		{
			color_6 = Color.White;
		}
		if (!bool_14)
		{
			color_14 = Color.FromArgb(146, 143, 130);
		}
		if (!bool_10)
		{
			color_10 = Color.FromArgb(252, 252, 249);
		}
		if (!bool_11)
		{
			color_11 = Color.FromArgb(138, 134, 122);
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_35)
		{
			color_35 = Color.FromArgb(225, 230, 232);
		}
		if (!bool_36)
		{
			color_36 = Color.Empty;
		}
		if (!bool_37)
		{
			color_37 = Color.FromArgb(49, 106, 197);
		}
		if (!bool_38)
		{
			color_38 = SystemColors.ControlText;
		}
		if (!bool_18)
		{
			color_18 = Color.Empty;
		}
		if (!bool_19)
		{
			color_19 = Color.FromArgb(180, 177, 163);
		}
		if (!bool_33)
		{
			color_33 = Color.Empty;
		}
		if (!bool_30)
		{
			color_30 = Color.FromArgb(251, 250, 247);
		}
		if (!bool_31)
		{
			color_31 = Color.Empty;
		}
		if (!bool_32)
		{
			color_32 = SystemColors.ControlText;
		}
		if (!bool_20)
		{
			color_20 = Color.FromArgb(193, 210, 238);
		}
		if (!bool_21)
		{
			color_21 = Color.Empty;
		}
		if (!bool_23)
		{
			color_23 = Color.FromArgb(49, 106, 197);
		}
		if (!bool_22)
		{
			color_22 = SystemColors.ControlText;
		}
		if (!bool_24)
		{
			color_24 = Color.FromArgb(152, 181, 226);
		}
		if (!bool_25)
		{
			color_25 = Color.Empty;
		}
		if (!bool_27)
		{
			color_27 = Color.FromArgb(75, 75, 111);
		}
		if (!bool_26)
		{
			color_26 = SystemColors.ControlText;
		}
		if (!bool_28)
		{
			color_28 = Color.FromArgb(197, 194, 184);
		}
		if (!bool_29)
		{
			color_29 = Color.Empty;
		}
		if (!bool_17)
		{
			color_17 = SystemColors.ControlText;
		}
		if (!bool_40)
		{
			color_40 = Color.FromArgb(252, 252, 249);
		}
		if (!bool_41)
		{
			color_41 = Color.Empty;
		}
		if (!bool_0)
		{
			color_0 = Color.FromArgb(229, 229, 215);
		}
		if (!bool_39)
		{
			color_39 = Color.FromArgb(138, 134, 122);
		}
		if (!bool_34)
		{
			color_34 = color_39;
		}
		if (!bool_42)
		{
			color_42 = color_40;
		}
		if (!bool_43)
		{
			color_43 = Color.FromArgb(186, 186, 160);
		}
		if (!bool_44)
		{
			color_44 = color_40;
		}
		if (!bool_45)
		{
			color_45 = color_40;
		}
		if (!bool_46)
		{
			color_46 = ControlPaint.Light(Color.FromArgb(186, 186, 160));
		}
		if (!bool_47)
		{
			color_47 = Color.Black;
		}
		if (!bool_12)
		{
			color_12 = Color.FromArgb(146, 146, 118);
		}
		if (!bool_58)
		{
			color_57 = Color.FromArgb(229, 229, 215);
		}
		if (!bool_59)
		{
			color_58 = Color.FromArgb(250, 250, 247);
		}
		if (!bool_48)
		{
			color_48 = Color.FromArgb(239, 238, 235);
		}
		if (!bool_49)
		{
			color_49 = Color.FromArgb(152, 152, 126);
		}
		if (!bool_50)
		{
			color_50 = SystemColors.ControlText;
		}
		if (!bool_51)
		{
			color_51 = GetColor(12566434);
		}
		if (!bool_52)
		{
			color_52 = Color.FromArgb(152, 152, 126);
		}
		if (!bool_53)
		{
			color_53 = Color.Black;
		}
		if (!bool_54)
		{
			color_54 = Color.FromArgb(82, 82, 79);
		}
		if (!bool_55)
		{
			color_55 = Color.FromArgb(123, 162, 231);
		}
		if (!bool_56)
		{
			color_56 = Color.FromArgb(99, 117, 214);
		}
	}

	private void method_11()
	{
		if (!bool_2)
		{
			color_2 = GetColor(16448246);
		}
		if (!bool_3)
		{
			color_3 = GetColor(15592155);
		}
		if (!bool_13)
		{
			color_13 = GetColor(12697267);
		}
		if (!bool_4)
		{
			color_4 = GetColor(9150825);
		}
		if (!bool_5)
		{
			color_5 = GetColor(12964257);
		}
		if (!bool_7)
		{
			color_7 = GetColor(13420474);
		}
		if (!bool_8)
		{
			color_8 = Color.Empty;
		}
		if (!bool_9)
		{
			color_9 = Color.Black;
		}
		if (!bool_6)
		{
			color_6 = Color.White;
		}
		if (!bool_14)
		{
			color_14 = GetColor(9604994);
		}
		if (!bool_10)
		{
			color_10 = GetColor(16579833);
		}
		if (!bool_11)
		{
			color_11 = GetColor(9078394);
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_35)
		{
			color_35 = GetColor(11978381);
		}
		if (!bool_36)
		{
			color_36 = Color.Empty;
		}
		if (!bool_37)
		{
			color_37 = GetColor(9674864);
		}
		if (!bool_38)
		{
			color_38 = SystemColors.ControlText;
		}
		if (!bool_18)
		{
			color_18 = Color.Empty;
		}
		if (!bool_19)
		{
			color_19 = GetColor(11841955);
		}
		if (!bool_33)
		{
			color_33 = Color.Empty;
		}
		if (!bool_30)
		{
			color_30 = GetColor(16382452);
		}
		if (!bool_31)
		{
			color_31 = Color.Empty;
		}
		if (!bool_32)
		{
			color_32 = SystemColors.ControlText;
		}
		if (!bool_20)
		{
			color_20 = GetColor(11978381);
		}
		if (!bool_21)
		{
			color_21 = Color.Empty;
		}
		if (!bool_23)
		{
			color_23 = GetColor(9674864);
		}
		if (!bool_22)
		{
			color_22 = SystemColors.ControlText;
		}
		if (!bool_24)
		{
			color_24 = GetColor(9674864);
		}
		if (!bool_25)
		{
			color_25 = Color.Empty;
		}
		if (!bool_27)
		{
			color_27 = GetColor(9674864);
		}
		if (!bool_26)
		{
			color_26 = Color.White;
		}
		if (!bool_28)
		{
			color_28 = GetColor(12960440);
		}
		if (!bool_29)
		{
			color_29 = Color.Empty;
		}
		if (!bool_17)
		{
			color_17 = SystemColors.ControlText;
		}
		if (!bool_40)
		{
			color_40 = GetColor(16579833);
		}
		if (!bool_41)
		{
			color_41 = Color.Empty;
		}
		if (!bool_0)
		{
			color_0 = GetColor(15526360);
		}
		if (!bool_39)
		{
			color_39 = GetColor(9078394);
		}
		if (!bool_34)
		{
			color_34 = color_39;
		}
		if (!bool_42)
		{
			color_42 = GetColor(16579833);
		}
		if (!bool_43)
		{
			color_43 = GetColor(15592155);
		}
		if (!bool_44)
		{
			color_44 = color_40;
		}
		if (!bool_45)
		{
			color_45 = color_42;
		}
		if (!bool_46)
		{
			color_46 = ControlPaint.Light(color_43);
		}
		if (!bool_47)
		{
			color_47 = Color.Black;
		}
		if (!bool_12)
		{
			color_12 = GetColor(15723998);
		}
		if (!bool_58)
		{
			color_57 = GetColor(15526360);
		}
		if (!bool_59)
		{
			color_58 = GetColor(16447990);
		}
		if (!bool_48)
		{
			color_48 = GetColor(15724267);
		}
		if (!bool_49)
		{
			color_49 = GetColor(11315353);
		}
		if (!bool_50)
		{
			color_50 = SystemColors.ControlText;
		}
		if (!bool_51)
		{
			color_51 = GetColor(15987434);
		}
		if (!bool_52)
		{
			color_52 = GetColor(15000277);
		}
		if (!bool_53)
		{
			color_53 = Color.Black;
		}
		if (!bool_54)
		{
			color_54 = GetColor(11315353);
		}
		if (!bool_55)
		{
			color_55 = Color.FromArgb(204, 217, 173);
		}
		if (!bool_56)
		{
			color_56 = Color.FromArgb(165, 189, 132);
		}
	}

	private void method_12()
	{
		if (!bool_2)
		{
			color_2 = GetColor(15987962);
		}
		if (!bool_3)
		{
			color_3 = GetColor(10065845);
		}
		if (!bool_13)
		{
			color_13 = GetColor(5526645);
		}
		if (!bool_4)
		{
			color_4 = GetColor(10526394);
		}
		if (!bool_5)
		{
			color_5 = GetColor(14803692);
		}
		if (!bool_7)
		{
			color_7 = GetColor(13553358);
		}
		if (!bool_8)
		{
			color_8 = GetColor(15921910);
		}
		if (!bool_9)
		{
			color_9 = Color.Black;
		}
		if (!bool_6)
		{
			color_6 = Color.Black;
		}
		if (!bool_14)
		{
			color_14 = GetColor(8026521);
		}
		if (!bool_10)
		{
			color_10 = GetColor(16644863);
		}
		if (!bool_11)
		{
			color_11 = GetColor(8158356);
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_35)
		{
			color_35 = GetColor(16766348);
		}
		if (!bool_36)
		{
			color_36 = GetColor(16756053);
		}
		if (!bool_37)
		{
			color_37 = GetColor(4934511);
		}
		if (!bool_38)
		{
			color_38 = SystemColors.ControlText;
		}
		if (!bool_18)
		{
			color_18 = Color.Empty;
		}
		if (!bool_19)
		{
			color_19 = GetColor(9276813);
		}
		if (!bool_33)
		{
			color_33 = Color.Empty;
		}
		if (!bool_30)
		{
			color_30 = GetColor(15264241);
		}
		if (!bool_31)
		{
			color_31 = GetColor(12237261);
		}
		if (!bool_32)
		{
			color_32 = SystemColors.ControlText;
		}
		if (!bool_20)
		{
			color_20 = GetColor(16774348);
		}
		if (!bool_21)
		{
			color_21 = GetColor(16765073);
		}
		if (!bool_23)
		{
			color_23 = GetColor(4934511);
		}
		if (!bool_22)
		{
			color_22 = SystemColors.ControlText;
		}
		if (!bool_24)
		{
			color_24 = GetColor(16683342);
		}
		if (!bool_25)
		{
			color_25 = GetColor(16765838);
		}
		if (!bool_27)
		{
			color_27 = GetColor(4934511);
		}
		if (!bool_26)
		{
			color_26 = Color.Black;
		}
		if (!bool_28)
		{
			color_28 = GetColor(7237007);
		}
		if (!bool_29)
		{
			color_29 = Color.Empty;
		}
		if (!bool_17)
		{
			color_17 = SystemColors.ControlText;
		}
		if (!bool_40)
		{
			color_40 = GetColor(16644863);
		}
		if (!bool_41)
		{
			color_41 = Color.Empty;
		}
		if (!bool_0)
		{
			color_0 = GetColor(14145509);
		}
		if (!bool_39)
		{
			color_39 = GetColor(8158356);
		}
		if (!bool_34)
		{
			color_34 = color_39;
		}
		if (!bool_42)
		{
			color_42 = GetColor(16382463);
		}
		if (!bool_43)
		{
			color_43 = GetColor(10460601);
		}
		if (!bool_44)
		{
			color_44 = color_40;
		}
		if (!bool_45)
		{
			color_45 = color_42;
		}
		if (!bool_46)
		{
			color_46 = ControlPaint.Light(color_43);
		}
		if (!bool_47)
		{
			color_47 = Color.Black;
		}
		if (!bool_12)
		{
			color_12 = GetColor(8158356);
		}
		if (!bool_58)
		{
			color_57 = GetColor(14145509);
		}
		if (!bool_59)
		{
			color_58 = GetColor(15987703);
		}
		if (!bool_48)
		{
			color_48 = GetColor(11776712);
		}
		if (!bool_49)
		{
			color_49 = GetColor(7960468);
		}
		if (!bool_50)
		{
			color_50 = SystemColors.ControlText;
		}
		if (!bool_51)
		{
			color_51 = GetColor(15658734);
		}
		if (!bool_52)
		{
			color_52 = GetColor(16777215);
		}
		if (!bool_53)
		{
			color_53 = Color.Black;
		}
		if (!bool_54)
		{
			color_54 = GetColor(10329505);
		}
		if (!bool_55)
		{
			color_55 = Color.FromArgb(196, 200, 212);
		}
		if (!bool_56)
		{
			color_56 = Color.FromArgb(177, 179, 200);
		}
	}

	private void method_13()
	{
		if (!bool_2)
		{
			color_2 = GetColor(14938111);
		}
		if (!bool_3)
		{
			color_3 = GetColor(11128574);
		}
		if (!bool_13)
		{
			color_13 = GetColor(7314905);
		}
		if (!bool_4)
		{
			color_4 = GetColor(6656975);
		}
		if (!bool_5)
		{
			color_5 = GetColor(3630240);
		}
		if (!bool_7)
		{
			color_7 = GetColor(14938111);
		}
		if (!bool_8)
		{
			color_8 = GetColor(11522815);
		}
		if (!bool_9)
		{
			color_9 = GetColor(538482);
		}
		if (!bool_6)
		{
			color_6 = GetColor(16777215);
		}
		if (!bool_14)
		{
			color_14 = GetColor(3630240);
		}
		if (!bool_10)
		{
			color_10 = GetColor(16185078);
		}
		if (!bool_11)
		{
			color_11 = GetColor(6656975);
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_35)
		{
			color_35 = GetColor(16569720);
		}
		if (!bool_36)
		{
			color_36 = GetColor(16500815);
		}
		if (!bool_37)
		{
			color_37 = GetColor(12276995);
		}
		if (!bool_38)
		{
			color_38 = GetColor(0);
		}
		if (!bool_18)
		{
			color_18 = Color.Empty;
		}
		if (!bool_19)
		{
			color_19 = GetColor(9276813);
		}
		if (!bool_33)
		{
			color_33 = Color.Empty;
		}
		if (!bool_30)
		{
			color_30 = GetColor(14938110);
		}
		if (!bool_31)
		{
			color_31 = GetColor(10076144);
		}
		if (!bool_32)
		{
			color_32 = GetColor(0);
		}
		if (!bool_20)
		{
			color_20 = GetColor(16774604);
		}
		if (!bool_21)
		{
			color_21 = GetColor(16767861);
		}
		if (!bool_23)
		{
			color_23 = GetColor(16760169);
		}
		if (!bool_22)
		{
			color_22 = GetColor(0);
		}
		if (!bool_24)
		{
			color_24 = GetColor(16553789);
		}
		if (!bool_25)
		{
			color_25 = GetColor(16758878);
		}
		if (!bool_27)
		{
			color_27 = GetColor(16485436);
		}
		if (!bool_26)
		{
			color_26 = GetColor(0);
		}
		if (!bool_28)
		{
			color_28 = Color.FromArgb(80, GetColor(10143487));
		}
		if (!bool_29)
		{
			color_29 = Color.FromArgb(250, GetColor(16777215));
		}
		if (!bool_17)
		{
			color_17 = GetColor(0);
		}
		if (!bool_40)
		{
			color_40 = GetColor(16185078);
		}
		if (!bool_41)
		{
			color_41 = Color.Empty;
		}
		if (!bool_0)
		{
			color_0 = GetColor(12573695);
		}
		if (!bool_39)
		{
			color_39 = GetColor(6656975);
		}
		if (!bool_34)
		{
			color_34 = color_39;
		}
		if (!bool_42)
		{
			color_42 = GetColor(15331054);
		}
		if (!bool_43)
		{
			color_43 = Color.Empty;
		}
		if (!bool_44)
		{
			color_44 = color_40;
		}
		if (!bool_45)
		{
			color_45 = GetColor(14342874);
		}
		if (!bool_46)
		{
			color_46 = Color.Empty;
		}
		if (!bool_47)
		{
			color_47 = Color.Black;
		}
		if (!bool_12)
		{
			color_12 = GetColor(7314905);
		}
		if (!bool_58)
		{
			color_57 = GetColor(12573695);
		}
		if (!bool_59)
		{
			color_58 = Color.Empty;
		}
		if (!bool_48)
		{
			color_48 = GetColor(14149887);
		}
		if (!bool_49)
		{
			color_49 = GetColor(7314905);
		}
		if (!bool_50)
		{
			color_50 = GetColor(0);
		}
		if (!bool_51)
		{
			color_51 = GetColor(14938111);
		}
		if (!bool_52)
		{
			color_52 = GetColor(11522815);
		}
		if (!bool_53)
		{
			color_53 = GetColor(538482);
		}
		if (!bool_54)
		{
			color_54 = GetColor(6656975);
		}
		if (!bool_55)
		{
			color_55 = Color.FromArgb(196, 200, 212);
		}
		if (!bool_56)
		{
			color_56 = Color.FromArgb(177, 179, 200);
		}
	}

	public static Color GetColor(string rgbHex)
	{
		if (!(rgbHex == "") && rgbHex != null)
		{
			if (rgbHex.Length == 8)
			{
				return Color.FromArgb(Convert.ToInt32(rgbHex.Substring(0, 2), 16), Convert.ToInt32(rgbHex.Substring(2, 2), 16), Convert.ToInt32(rgbHex.Substring(4, 2), 16), Convert.ToInt32(rgbHex.Substring(6, 2), 16));
			}
			return Color.FromArgb(Convert.ToInt32(rgbHex.Substring(0, 2), 16), Convert.ToInt32(rgbHex.Substring(2, 2), 16), Convert.ToInt32(rgbHex.Substring(4, 2), 16));
		}
		return Color.Empty;
	}

	public static Color GetColor(int rgb)
	{
		if (rgb == -1)
		{
			return Color.Empty;
		}
		return Color.FromArgb((rgb & 0xFF0000) >> 16, (rgb & 0xFF00) >> 8, rgb & 0xFF);
	}

	public static Color GetColor(int alpha, int rgb)
	{
		if (rgb == -1)
		{
			return Color.Empty;
		}
		return Color.FromArgb(alpha, (rgb & 0xFF0000) >> 16, (rgb & 0xFF00) >> 8, rgb & 0xFF);
	}

	public void Serialize(XmlElement xmlElem)
	{
		if (bool_2)
		{
			xmlElem.SetAttribute("barback", Class109.smethod_50(color_2));
		}
		if (bool_3)
		{
			xmlElem.SetAttribute("barback2", Class109.smethod_50(color_3));
		}
		if (int_1 != 90)
		{
			xmlElem.SetAttribute("barbackga", int_1.ToString());
		}
		if (bool_13)
		{
			xmlElem.SetAttribute("barstripeclr", Class109.smethod_50(color_13));
		}
		if (bool_4)
		{
			xmlElem.SetAttribute("barcapback", Class109.smethod_50(color_4));
		}
		if (bool_5)
		{
			xmlElem.SetAttribute("barcapback2", Class109.smethod_50(color_5));
		}
		if (int_2 != 90)
		{
			xmlElem.SetAttribute("barcapbackga", int_2.ToString());
		}
		if (bool_7)
		{
			xmlElem.SetAttribute("barcapiback", Class109.smethod_50(color_7));
		}
		if (bool_8)
		{
			xmlElem.SetAttribute("barcapiback2", Class109.smethod_50(color_8));
		}
		if (int_3 != 90)
		{
			xmlElem.SetAttribute("barcapibackga", int_3.ToString());
		}
		if (bool_12)
		{
			xmlElem.SetAttribute("bardockborder", Class109.smethod_50(color_12));
		}
		if (bool_9)
		{
			xmlElem.SetAttribute("barcapitext", Class109.smethod_50(color_9));
		}
		if (bool_6)
		{
			xmlElem.SetAttribute("barcaptext", Class109.smethod_50(color_6));
		}
		if (bool_14)
		{
			xmlElem.SetAttribute("barfloatb", Class109.smethod_50(color_14));
		}
		if (bool_10)
		{
			xmlElem.SetAttribute("barpopupback", Class109.smethod_50(color_10));
		}
		if (bool_11)
		{
			xmlElem.SetAttribute("barpopupb", Class109.smethod_50(color_11));
		}
		if (bool_15)
		{
			xmlElem.SetAttribute("itemback", Class109.smethod_50(color_15));
		}
		if (bool_16)
		{
			xmlElem.SetAttribute("itemback2", Class109.smethod_50(color_16));
		}
		if (int_4 != 90)
		{
			xmlElem.SetAttribute("itembackga", int_4.ToString());
		}
		if (bool_35)
		{
			xmlElem.SetAttribute("itemchkback", Class109.smethod_50(color_35));
		}
		if (bool_36)
		{
			xmlElem.SetAttribute("itemchkback2", Class109.smethod_50(color_36));
		}
		if (int_8 != 90)
		{
			xmlElem.SetAttribute("itemchkbackga", int_8.ToString());
		}
		if (bool_37)
		{
			xmlElem.SetAttribute("itemchkb", Class109.smethod_50(color_37));
		}
		if (bool_38)
		{
			xmlElem.SetAttribute("itemchktext", Class109.smethod_50(color_38));
		}
		if (bool_18 && !color_18.IsEmpty)
		{
			xmlElem.SetAttribute("itemdisback", Class109.smethod_50(color_18));
		}
		if (bool_19)
		{
			xmlElem.SetAttribute("itemdistext", Class109.smethod_50(color_19));
		}
		if (bool_33)
		{
			xmlElem.SetAttribute("itemexpshadow", Class109.smethod_50(color_33));
		}
		if (bool_30)
		{
			xmlElem.SetAttribute("itemexpback", Class109.smethod_50(color_30));
		}
		if (bool_31)
		{
			xmlElem.SetAttribute("itemexpback2", Class109.smethod_50(color_31));
		}
		if (int_7 != 90)
		{
			xmlElem.SetAttribute("itemexpbackga", int_7.ToString());
		}
		if (bool_32)
		{
			xmlElem.SetAttribute("itemexptext", Class109.smethod_50(color_32));
		}
		if (bool_34)
		{
			xmlElem.SetAttribute("itemexpborder", Class109.smethod_50(color_34));
		}
		if (bool_20)
		{
			xmlElem.SetAttribute("itemhotback", Class109.smethod_50(color_20));
		}
		if (bool_21)
		{
			xmlElem.SetAttribute("itemhotback2", Class109.smethod_50(color_21));
		}
		if (int_5 != 90)
		{
			xmlElem.SetAttribute("itemhotbackga", int_5.ToString());
		}
		if (bool_23)
		{
			xmlElem.SetAttribute("itemhotb", Class109.smethod_50(color_23));
		}
		if (bool_22)
		{
			xmlElem.SetAttribute("itemhottext", Class109.smethod_50(color_22));
		}
		if (bool_24)
		{
			xmlElem.SetAttribute("itempressback", Class109.smethod_50(color_24));
		}
		if (bool_25)
		{
			xmlElem.SetAttribute("itempressback2", Class109.smethod_50(color_25));
		}
		if (int_6 != 90)
		{
			xmlElem.SetAttribute("itempressbackga", int_6.ToString());
		}
		if (bool_27)
		{
			xmlElem.SetAttribute("itempressb", Class109.smethod_50(color_27));
		}
		if (bool_26)
		{
			xmlElem.SetAttribute("itempresstext", Class109.smethod_50(color_26));
		}
		if (bool_28)
		{
			xmlElem.SetAttribute("itemsep", Class109.smethod_50(color_28));
		}
		if (bool_17)
		{
			xmlElem.SetAttribute("itemtext", Class109.smethod_50(color_17));
		}
		if (bool_40)
		{
			xmlElem.SetAttribute("menuback", Class109.smethod_50(color_40));
		}
		if (bool_41)
		{
			xmlElem.SetAttribute("menuback2", Class109.smethod_50(color_41));
		}
		if (int_9 != 0)
		{
			xmlElem.SetAttribute("menubackga", int_9.ToString());
		}
		if (bool_0)
		{
			xmlElem.SetAttribute("menubarback", Class109.smethod_50(color_0));
		}
		if (bool_1)
		{
			xmlElem.SetAttribute("menubarback2", Class109.smethod_50(color_1));
		}
		if (int_0 != 90)
		{
			xmlElem.SetAttribute("menubarbackga", int_0.ToString());
		}
		if (bool_39)
		{
			xmlElem.SetAttribute("menub", Class109.smethod_50(color_39));
		}
		if (bool_42)
		{
			xmlElem.SetAttribute("menuside", Class109.smethod_50(color_42));
		}
		if (bool_43)
		{
			xmlElem.SetAttribute("menuside2", Class109.smethod_50(color_43));
		}
		if (int_10 != 0)
		{
			xmlElem.SetAttribute("menusidega", int_10.ToString());
		}
		if (bool_44)
		{
			xmlElem.SetAttribute("menuuback", Class109.smethod_50(color_44));
		}
		if (bool_45)
		{
			xmlElem.SetAttribute("menuuside", Class109.smethod_50(color_45));
		}
		if (bool_46)
		{
			xmlElem.SetAttribute("menuuside2", Class109.smethod_50(color_46));
		}
		if (int_10 != 0)
		{
			xmlElem.SetAttribute("menuusidega", int_10.ToString());
		}
		if (bool_47)
		{
			xmlElem.SetAttribute("menudtb", Class109.smethod_50(color_47));
		}
		if (bool_48)
		{
			xmlElem.SetAttribute("customback", Class109.smethod_50(color_48));
		}
		if (bool_49)
		{
			xmlElem.SetAttribute("customback2", Class109.smethod_50(color_49));
		}
		if (bool_50)
		{
			xmlElem.SetAttribute("customtext", Class109.smethod_50(color_50));
		}
		if (int_12 != 90)
		{
			xmlElem.SetAttribute("custombackga", int_12.ToString());
		}
		if (bool_51)
		{
			xmlElem.SetAttribute("panelback", Class109.smethod_50(color_51));
		}
		if (bool_52)
		{
			xmlElem.SetAttribute("panelback2", Class109.smethod_50(color_52));
		}
		if (bool_54)
		{
			xmlElem.SetAttribute("panelborder", Class109.smethod_50(color_54));
		}
		if (bool_53)
		{
			xmlElem.SetAttribute("paneltext", Class109.smethod_50(color_53));
		}
		if (int_13 != 90)
		{
			xmlElem.SetAttribute("panelbackga", int_13.ToString());
		}
		if (bool_55)
		{
			xmlElem.SetAttribute("exbarback", Class109.smethod_50(color_55));
		}
		if (bool_56)
		{
			xmlElem.SetAttribute("exbarback2", Class109.smethod_50(color_56));
		}
		if (int_14 != 90)
		{
			xmlElem.SetAttribute("exbarbackga", int_14.ToString());
		}
		if (bool_58)
		{
			xmlElem.SetAttribute("dsback", Class109.smethod_50(color_57));
		}
		if (bool_59)
		{
			xmlElem.SetAttribute("dsback2", Class109.smethod_50(color_58));
		}
		if (int_15 != 0)
		{
			xmlElem.SetAttribute("dsbackga", int_15.ToString());
		}
		if (!color_59.IsEmpty)
		{
			xmlElem.SetAttribute("mdisystemitemforeground", Class109.smethod_50(color_59));
		}
		if (ePredefinedColorScheme_0 != 0)
		{
			xmlElem.SetAttribute("predefcolorscheme", XmlConvert.ToString((int)ePredefinedColorScheme_0));
		}
	}

	public void Deserialize(XmlElement xmlElem)
	{
		if (xmlElem.HasAttribute("predefcolorscheme"))
		{
			ePredefinedColorScheme_0 = (ePredefinedColorScheme)XmlConvert.ToInt32(xmlElem.GetAttribute("predefcolorscheme"));
		}
		Refresh();
		if (xmlElem.HasAttribute("barback"))
		{
			color_2 = Class109.smethod_51(xmlElem.GetAttribute("barback"));
			bool_2 = true;
		}
		if (xmlElem.HasAttribute("barback2"))
		{
			color_3 = Class109.smethod_51(xmlElem.GetAttribute("barback2"));
			bool_3 = true;
		}
		if (xmlElem.HasAttribute("barbackga"))
		{
			int_1 = XmlConvert.ToInt32(xmlElem.GetAttribute("barbackga"));
		}
		if (xmlElem.HasAttribute("barstripeclr"))
		{
			color_13 = Class109.smethod_51(xmlElem.GetAttribute("barstripeclr"));
			bool_13 = true;
		}
		if (xmlElem.HasAttribute("barcapback"))
		{
			color_4 = Class109.smethod_51(xmlElem.GetAttribute("barcapback"));
			bool_4 = true;
		}
		if (xmlElem.HasAttribute("barcapback2"))
		{
			color_5 = Class109.smethod_51(xmlElem.GetAttribute("barcapback2"));
			bool_5 = true;
		}
		if (xmlElem.HasAttribute("barcapbackga"))
		{
			int_2 = XmlConvert.ToInt32(xmlElem.GetAttribute("barcapbackga"));
		}
		if (xmlElem.HasAttribute("barcapiback"))
		{
			color_7 = Class109.smethod_51(xmlElem.GetAttribute("barcapiback"));
			bool_7 = true;
		}
		if (xmlElem.HasAttribute("barcapiback2"))
		{
			color_8 = Class109.smethod_51(xmlElem.GetAttribute("barcapiback2"));
			bool_8 = true;
		}
		if (xmlElem.HasAttribute("barcapibackga"))
		{
			int_3 = XmlConvert.ToInt32(xmlElem.GetAttribute("barcapibackga"));
		}
		if (xmlElem.HasAttribute("barcapitext"))
		{
			color_9 = Class109.smethod_51(xmlElem.GetAttribute("barcapitext"));
			bool_9 = true;
		}
		if (xmlElem.HasAttribute("barcaptext"))
		{
			color_6 = Class109.smethod_51(xmlElem.GetAttribute("barcaptext"));
			bool_6 = true;
		}
		if (xmlElem.HasAttribute("barfloatb"))
		{
			color_14 = Class109.smethod_51(xmlElem.GetAttribute("barfloatb"));
			bool_14 = true;
		}
		if (xmlElem.HasAttribute("bardockborder"))
		{
			color_12 = Class109.smethod_51(xmlElem.GetAttribute("bardockborder"));
			bool_12 = true;
		}
		if (xmlElem.HasAttribute("barpopupback"))
		{
			color_10 = Class109.smethod_51(xmlElem.GetAttribute("barpopupback"));
			bool_10 = true;
		}
		if (xmlElem.HasAttribute("barpopupb"))
		{
			color_11 = Class109.smethod_51(xmlElem.GetAttribute("barpopupb"));
			bool_11 = true;
		}
		if (xmlElem.HasAttribute("itemback"))
		{
			color_15 = Class109.smethod_51(xmlElem.GetAttribute("itemback"));
			bool_15 = true;
		}
		if (xmlElem.HasAttribute("itemback2"))
		{
			color_16 = Class109.smethod_51(xmlElem.GetAttribute("itemback2"));
			bool_16 = true;
		}
		if (xmlElem.HasAttribute("itembackga"))
		{
			int_4 = XmlConvert.ToInt32(xmlElem.GetAttribute("itembackga"));
		}
		if (xmlElem.HasAttribute("itemchkback"))
		{
			color_35 = Class109.smethod_51(xmlElem.GetAttribute("itemchkback"));
			bool_35 = true;
		}
		if (xmlElem.HasAttribute("itemchkback2"))
		{
			color_36 = Class109.smethod_51(xmlElem.GetAttribute("itemchkback2"));
			bool_36 = true;
		}
		if (xmlElem.HasAttribute("itemchkbackga"))
		{
			int_8 = XmlConvert.ToInt32(xmlElem.GetAttribute("itemchkbackga"));
		}
		if (xmlElem.HasAttribute("itemchkb"))
		{
			color_37 = Class109.smethod_51(xmlElem.GetAttribute("itemchkb"));
			bool_37 = true;
		}
		if (xmlElem.HasAttribute("itemchktext"))
		{
			color_38 = Class109.smethod_51(xmlElem.GetAttribute("itemchktext"));
			bool_38 = true;
		}
		if (xmlElem.HasAttribute("itemdisback"))
		{
			color_18 = Class109.smethod_51(xmlElem.GetAttribute("itemdisback"));
			bool_18 = true;
		}
		if (xmlElem.HasAttribute("itemdistext"))
		{
			color_19 = Class109.smethod_51(xmlElem.GetAttribute("itemdistext"));
			bool_19 = true;
		}
		if (xmlElem.HasAttribute("itemexpshadow"))
		{
			color_33 = Class109.smethod_51(xmlElem.GetAttribute("itemexpshadow"));
			bool_33 = true;
		}
		if (xmlElem.HasAttribute("itemexpback"))
		{
			color_30 = Class109.smethod_51(xmlElem.GetAttribute("itemexpback"));
			bool_30 = true;
		}
		if (xmlElem.HasAttribute("itemexpback2"))
		{
			color_31 = Class109.smethod_51(xmlElem.GetAttribute("itemexpback2"));
			bool_31 = true;
		}
		if (xmlElem.HasAttribute("itemexpbackga"))
		{
			int_7 = XmlConvert.ToInt32(xmlElem.GetAttribute("itemexpbackga"));
		}
		if (xmlElem.HasAttribute("itemexptext"))
		{
			color_32 = Class109.smethod_51(xmlElem.GetAttribute("itemexptext"));
			bool_32 = true;
		}
		if (xmlElem.HasAttribute("itemexpborder"))
		{
			color_34 = Class109.smethod_51(xmlElem.GetAttribute("itemexpborder"));
			bool_34 = true;
		}
		if (xmlElem.HasAttribute("itemhotback"))
		{
			color_20 = Class109.smethod_51(xmlElem.GetAttribute("itemhotback"));
			bool_20 = true;
		}
		if (xmlElem.HasAttribute("itemhotback2"))
		{
			color_21 = Class109.smethod_51(xmlElem.GetAttribute("itemhotback2"));
			bool_21 = true;
		}
		if (xmlElem.HasAttribute("itemhotbackga"))
		{
			int_5 = XmlConvert.ToInt32(xmlElem.GetAttribute("itemhotbackga"));
		}
		if (xmlElem.HasAttribute("itemhotb"))
		{
			color_23 = Class109.smethod_51(xmlElem.GetAttribute("itemhotb"));
			bool_23 = true;
		}
		if (xmlElem.HasAttribute("itemhottext"))
		{
			color_22 = Class109.smethod_51(xmlElem.GetAttribute("itemhottext"));
			bool_22 = true;
		}
		if (xmlElem.HasAttribute("itempressback"))
		{
			color_24 = Class109.smethod_51(xmlElem.GetAttribute("itempressback"));
			bool_24 = true;
		}
		if (xmlElem.HasAttribute("itempressback2"))
		{
			color_25 = Class109.smethod_51(xmlElem.GetAttribute("itempressback2"));
			bool_25 = true;
		}
		if (xmlElem.HasAttribute("itempressbackga"))
		{
			int_6 = XmlConvert.ToInt32(xmlElem.GetAttribute("itempressbackga"));
		}
		if (xmlElem.HasAttribute("itempressb"))
		{
			color_27 = Class109.smethod_51(xmlElem.GetAttribute("itempressb"));
			bool_27 = true;
		}
		if (xmlElem.HasAttribute("itempresstext"))
		{
			color_26 = Class109.smethod_51(xmlElem.GetAttribute("itempresstext"));
			bool_26 = true;
		}
		if (xmlElem.HasAttribute("itemsep"))
		{
			color_28 = Class109.smethod_51(xmlElem.GetAttribute("itemsep"));
			bool_28 = true;
		}
		if (xmlElem.HasAttribute("itemtext"))
		{
			color_17 = Class109.smethod_51(xmlElem.GetAttribute("itemtext"));
			bool_17 = true;
		}
		if (xmlElem.HasAttribute("menuback"))
		{
			color_40 = Class109.smethod_51(xmlElem.GetAttribute("menuback"));
			bool_40 = true;
		}
		if (xmlElem.HasAttribute("menuback2"))
		{
			color_41 = Class109.smethod_51(xmlElem.GetAttribute("menuback2"));
			bool_41 = true;
		}
		if (xmlElem.HasAttribute("menubackga"))
		{
			int_9 = XmlConvert.ToInt32(xmlElem.GetAttribute("menubackga"));
		}
		if (xmlElem.HasAttribute("menubarback"))
		{
			color_0 = Class109.smethod_51(xmlElem.GetAttribute("menubarback"));
			bool_0 = true;
		}
		if (xmlElem.HasAttribute("menubarback2"))
		{
			color_1 = Class109.smethod_51(xmlElem.GetAttribute("menubarback2"));
			bool_1 = true;
		}
		if (xmlElem.HasAttribute("menubarbackga"))
		{
			int_0 = XmlConvert.ToInt32(xmlElem.GetAttribute("menubarbackga"));
		}
		else
		{
			int_0 = 90;
		}
		if (xmlElem.HasAttribute("menub"))
		{
			color_39 = Class109.smethod_51(xmlElem.GetAttribute("menub"));
			bool_39 = true;
		}
		if (xmlElem.HasAttribute("menuside"))
		{
			color_42 = Class109.smethod_51(xmlElem.GetAttribute("menuside"));
			bool_42 = true;
		}
		if (xmlElem.HasAttribute("menuside2"))
		{
			color_43 = Class109.smethod_51(xmlElem.GetAttribute("menuside2"));
			bool_43 = true;
		}
		if (xmlElem.HasAttribute("menusidega"))
		{
			int_10 = XmlConvert.ToInt32(xmlElem.GetAttribute("menusidega"));
		}
		if (xmlElem.HasAttribute("menuuback"))
		{
			color_44 = Class109.smethod_51(xmlElem.GetAttribute("menuuback"));
			bool_44 = true;
		}
		if (xmlElem.HasAttribute("menuuside"))
		{
			color_45 = Class109.smethod_51(xmlElem.GetAttribute("menuuside"));
			bool_45 = true;
		}
		if (xmlElem.HasAttribute("menuuside2"))
		{
			color_46 = Class109.smethod_51(xmlElem.GetAttribute("menuuside2"));
			bool_46 = true;
		}
		if (xmlElem.HasAttribute("menuusidega"))
		{
			int_11 = XmlConvert.ToInt32(xmlElem.GetAttribute("menuusidega"));
		}
		if (xmlElem.HasAttribute("menudtb"))
		{
			color_47 = Class109.smethod_51(xmlElem.GetAttribute("menudtb"));
			bool_47 = true;
		}
		if (xmlElem.HasAttribute("customback"))
		{
			color_48 = Class109.smethod_51(xmlElem.GetAttribute("customback"));
			bool_48 = true;
		}
		if (xmlElem.HasAttribute("customback2"))
		{
			color_49 = Class109.smethod_51(xmlElem.GetAttribute("customback2"));
			bool_49 = true;
		}
		if (xmlElem.HasAttribute("customtext"))
		{
			color_50 = Class109.smethod_51(xmlElem.GetAttribute("customtext"));
			bool_50 = true;
		}
		if (xmlElem.HasAttribute("custombackga"))
		{
			int_12 = XmlConvert.ToInt32(xmlElem.GetAttribute("custombackga"));
		}
		if (xmlElem.HasAttribute("panelback"))
		{
			bool_51 = true;
			color_51 = Class109.smethod_51(xmlElem.GetAttribute("panelback"));
		}
		if (xmlElem.HasAttribute("panelback2"))
		{
			bool_52 = true;
			color_52 = Class109.smethod_51(xmlElem.GetAttribute("panelback2"));
		}
		if (xmlElem.HasAttribute("panelborder"))
		{
			bool_54 = true;
			color_54 = Class109.smethod_51(xmlElem.GetAttribute("panelborder"));
		}
		if (xmlElem.HasAttribute("paneltext"))
		{
			bool_53 = true;
			color_53 = Class109.smethod_51(xmlElem.GetAttribute("paneltext"));
		}
		if (xmlElem.HasAttribute("panelbackga"))
		{
			int_13 = XmlConvert.ToInt32(xmlElem.GetAttribute("panelbackga"));
		}
		if (xmlElem.HasAttribute("exbarback"))
		{
			bool_55 = true;
			color_55 = Class109.smethod_51(xmlElem.GetAttribute("exbarback"));
		}
		if (xmlElem.HasAttribute("exbarback2"))
		{
			bool_56 = true;
			color_56 = Class109.smethod_51(xmlElem.GetAttribute("exbarback2"));
		}
		if (xmlElem.HasAttribute("exbarbackga"))
		{
			int_14 = XmlConvert.ToInt32(xmlElem.GetAttribute("exbarbackga"));
		}
		if (xmlElem.HasAttribute("dsback"))
		{
			bool_58 = true;
			color_57 = Class109.smethod_51(xmlElem.GetAttribute("dsback"));
		}
		if (xmlElem.HasAttribute("dsback2"))
		{
			bool_59 = true;
			color_58 = Class109.smethod_51(xmlElem.GetAttribute("dsback2"));
		}
		if (xmlElem.HasAttribute("dsbackga"))
		{
			int_15 = XmlConvert.ToInt32(xmlElem.GetAttribute("dsbackga"));
		}
		if (xmlElem.HasAttribute("mdisystemitemforeground"))
		{
			color_59 = Class109.smethod_51(xmlElem.GetAttribute("mdisystemitemforeground"));
		}
		else
		{
			color_59 = Color.Empty;
		}
	}
}
