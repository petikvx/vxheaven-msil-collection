using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class274
{
	private static Class266 class266_0 = new Class266();

	private static Class268 class268_0 = new Class268();

	private static Class267 class267_0 = new Class267();

	private static Class99 class99_0 = new Class99();

	private static Class85 class85_0 = new Class85();

	private static Class54 class54_0 = new Class54();

	private static Class87 class87_0 = new Class87();

	private static Class169 class169_0 = new Class169();

	private static Class269 class269_0 = new Class269();

	private static Class117 class117_0 = new Class117();

	private static Class221 class221_0 = new Class221();

	private static Class115 class115_0 = new Class115();

	private static Class96 class96_0 = new Class96();

	private static Class90 class90_0 = new Class90();

	private static Class270 class270_0 = new Class270();

	private static Class231 class231_0 = new Class231();

	private static Class237 class237_0 = new Class237();

	private static Class229 class229_0 = new Class229();

	private static Class223 class223_0 = new Class223();

	private static Class235 class235_0 = new Class235();

	private static Class232 class232_0 = new Class233();

	private static Class226 class226_0 = new Class227();

	private static Class102 class102_0 = null;

	public static Class265 smethod_0(ButtonItem buttonItem_0)
	{
		if (buttonItem_0 is RibbonTabItem)
		{
			return smethod_3((RibbonTabItem)buttonItem_0);
		}
		if (buttonItem_0 is Class184)
		{
			Class265 @class = smethod_2((Class184)buttonItem_0);
			if (@class != null)
			{
				return @class;
			}
		}
		if (buttonItem_0.Style != eDotNetBarStyle.Office2003 && buttonItem_0.Style != eDotNetBarStyle.VS2005 && buttonItem_0.Style != 0 && buttonItem_0.Style != eDotNetBarStyle.Office2000)
		{
			if (buttonItem_0.Style == eDotNetBarStyle.Office2007)
			{
				if (buttonItem_0.ContainerControl is RibbonBar)
				{
					return class268_0;
				}
				return class268_0;
			}
			return null;
		}
		return class266_0;
	}

	public static Class102 smethod_1(ButtonItem buttonItem_0)
	{
		if (class102_0 == null)
		{
			class102_0 = new Class102();
		}
		return class102_0;
	}

	public static Class265 smethod_2(Class184 class184_0)
	{
		if (class184_0.Style == eDotNetBarStyle.Office2007)
		{
			return class270_0;
		}
		return null;
	}

	public static Class265 smethod_3(RibbonTabItem ribbonTabItem_0)
	{
		if (ribbonTabItem_0.Style == eDotNetBarStyle.Office2007 && !ribbonTabItem_0.IsOnMenu)
		{
			return class269_0;
		}
		if ((ribbonTabItem_0.Style == eDotNetBarStyle.Office2003 || ribbonTabItem_0.Style == eDotNetBarStyle.VS2005) && !ribbonTabItem_0.IsOnMenu)
		{
			return class267_0;
		}
		return class266_0;
	}

	public static Class98 smethod_4(ItemContainer itemContainer_0)
	{
		if (itemContainer_0.Style == eDotNetBarStyle.Office2007)
		{
			return class99_0;
		}
		return null;
	}

	public static Class84 smethod_5(Bar bar_0)
	{
		return class85_0;
	}

	public static Class53 smethod_6()
	{
		return class54_0;
	}

	public static Class86 smethod_7(RibbonBar ribbonBar_0)
	{
		if (ribbonBar_0.Style == eDotNetBarStyle.Office2007)
		{
			return class87_0;
		}
		return null;
	}

	public static Class116 smethod_8(RibbonTabItemGroup ribbonTabItemGroup_0)
	{
		return class117_0;
	}

	public static Class220 smethod_9(ColorItem colorItem_0)
	{
		return class221_0;
	}

	public static Class168 smethod_10(RibbonControl ribbonControl_0)
	{
		if (ribbonControl_0.Style == eDotNetBarStyle.Office2007)
		{
			return class169_0;
		}
		return null;
	}

	public static Class114 smethod_11(SystemCaptionItem systemCaptionItem_0)
	{
		if (systemCaptionItem_0.Style == eDotNetBarStyle.Office2007)
		{
			return class115_0;
		}
		return null;
	}

	public static Class95 smethod_12(MDISystemItem mdisystemItem_0)
	{
		if (mdisystemItem_0.Style == eDotNetBarStyle.Office2007)
		{
			return class96_0;
		}
		return null;
	}

	public static Class89 smethod_13(Form form_0)
	{
		return class90_0;
	}

	public static Class230 smethod_14(QatOverflowItem qatOverflowItem_0)
	{
		return class231_0;
	}

	public static Class236 smethod_15(QatCustomizeItem qatCustomizeItem_0)
	{
		return class237_0;
	}

	public static Class229 smethod_16(CheckBoxItem checkBoxItem_0)
	{
		return class229_0;
	}

	public static void smethod_17()
	{
	}

	public static Class222 smethod_18(ProgressBarItem progressBarItem_0)
	{
		return class223_0;
	}

	internal static Class234 smethod_19()
	{
		return class235_0;
	}

	internal static Class232 smethod_20()
	{
		return class232_0;
	}

	internal static Class226 smethod_21()
	{
		return class226_0;
	}
}
