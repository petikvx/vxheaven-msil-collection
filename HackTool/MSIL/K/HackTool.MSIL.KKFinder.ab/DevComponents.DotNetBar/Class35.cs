using System.Drawing;

namespace DevComponents.DotNetBar;

internal class Class35
{
	public Color color_0 = Color.Empty;

	public Color color_1 = Color.Empty;

	public Color color_2 = Color.Empty;

	public Color color_3 = Color.Empty;

	public Color color_4 = Color.Empty;

	public Color color_5 = Color.Empty;

	public Color color_6 = Color.Empty;

	public Color color_7 = Color.Empty;

	public Color color_8 = Color.Empty;

	public Color color_9 = Color.Empty;

	public Color color_10 = Color.Empty;

	public Color color_11 = Color.Empty;

	public Color color_12 = Color.Empty;

	public Color color_13 = Color.Empty;

	public Color color_14 = Color.Empty;

	public Color color_15 = Color.Empty;

	public int int_0 = 90;

	public Color color_16 = Color.Empty;

	public Color color_17 = Color.Empty;

	public Color color_18 = Color.Empty;

	public Color color_19 = Color.Empty;

	public Color color_20 = Color.Empty;

	public Color color_21 = Color.Empty;

	public int int_1 = 90;

	public Color color_22 = Color.Empty;

	public Color color_23 = Color.Empty;

	public Color color_24 = Color.Empty;

	public Color color_25 = Color.Empty;

	public int int_2;

	public Color color_26 = Color.Empty;

	public Color color_27 = Color.Empty;

	public Color color_28 = Color.Empty;

	public int int_3;

	public Color color_29 = Color.Empty;

	public Color color_30 = Color.Empty;

	public int int_4 = 90;

	public Color color_31 = Color.Empty;

	public Color color_32 = Color.Empty;

	public void method_0(SideBarPanelItem sideBarPanelItem_0)
	{
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		sideBarPanelItem_0.method_25(new ItemStyle());
		sideBarPanelItem_0.BackgroundStyle.BackColor1.Color = color_1;
		sideBarPanelItem_0.BackgroundStyle.BackColor2.Color = color_2;
		sideBarPanelItem_0.BackgroundStyle.BorderColor.Color = color_0;
		sideBarPanelItem_0.BackgroundStyle.Border = eBorderType.SingleLine;
		sideBarPanelItem_0.BackgroundStyle.BorderSide = eBorderSide.All;
		sideBarPanelItem_0.BackgroundStyle.ForeColor.Color = color_3;
		sideBarPanelItem_0.method_26(new ItemStyle());
		sideBarPanelItem_0.HeaderStyle.BackColor1.Color = color_4;
		sideBarPanelItem_0.HeaderStyle.BackColor2.Color = color_5;
		sideBarPanelItem_0.HeaderStyle.GradientAngle = 90;
		sideBarPanelItem_0.HeaderStyle.BorderSide = eBorderSide.Right | eBorderSide.Top | eBorderSide.Bottom;
		sideBarPanelItem_0.HeaderStyle.Border = eBorderType.SingleLine;
		sideBarPanelItem_0.HeaderStyle.BorderColor.Color = color_0;
		sideBarPanelItem_0.HeaderStyle.ForeColor.Color = color_13;
		sideBarPanelItem_0.HeaderStyle.Font = new Font("Arial", 9f, (FontStyle)1);
		if (!color_8.IsEmpty)
		{
			sideBarPanelItem_0.method_27(new ItemStyle());
			sideBarPanelItem_0.HeaderHotStyle.BackColor1.Color = color_8;
			sideBarPanelItem_0.HeaderHotStyle.BackColor2.Color = color_9;
			sideBarPanelItem_0.HeaderHotStyle.GradientAngle = 90;
			if (!color_10.IsEmpty)
			{
				sideBarPanelItem_0.HeaderHotStyle.ForeColor.Color = color_10;
			}
		}
		else
		{
			sideBarPanelItem_0.method_27(null);
		}
		sideBarPanelItem_0.method_28(null);
		sideBarPanelItem_0.method_29(new ItemStyle());
		sideBarPanelItem_0.HeaderSideStyle.Border = eBorderType.SingleLine;
		sideBarPanelItem_0.HeaderSideStyle.BorderColor.Color = color_0;
		sideBarPanelItem_0.HeaderSideStyle.BorderSide = eBorderSide.Left | eBorderSide.Top | eBorderSide.Bottom;
		sideBarPanelItem_0.HeaderSideStyle.BackColor1.Color = color_6;
		sideBarPanelItem_0.HeaderSideStyle.BackColor2.Color = color_7;
		sideBarPanelItem_0.HeaderSideStyle.GradientAngle = 90;
		if (!color_11.IsEmpty)
		{
			sideBarPanelItem_0.method_30(new ItemStyle());
			sideBarPanelItem_0.HeaderSideHotStyle.BackColor1.Color = color_11;
			sideBarPanelItem_0.HeaderSideHotStyle.BackColor2.Color = color_12;
			sideBarPanelItem_0.HeaderSideHotStyle.GradientAngle = 90;
		}
		else
		{
			sideBarPanelItem_0.method_30(null);
		}
		sideBarPanelItem_0.method_31(null);
	}

	public void method_1(ColorScheme colorScheme_0)
	{
		colorScheme_0.ItemBackground = color_18;
		colorScheme_0.ItemCheckedBackground = color_29;
		colorScheme_0.ItemCheckedBackground2 = color_30;
		colorScheme_0.ItemCheckedBackgroundGradientAngle = int_4;
		colorScheme_0.ItemCheckedBorder = color_31;
		colorScheme_0.ItemCheckedText = color_32;
		colorScheme_0.ItemHotBackground = color_14;
		colorScheme_0.ItemHotBackground2 = color_15;
		colorScheme_0.ItemHotBackgroundGradientAngle = int_0;
		colorScheme_0.ItemHotBorder = color_16;
		colorScheme_0.ItemHotText = color_17;
		colorScheme_0.ItemPressedBackground = color_20;
		colorScheme_0.ItemPressedBackground2 = color_21;
		colorScheme_0.ItemPressedBackgroundGradientAngle = int_1;
		colorScheme_0.ItemPressedBorder = color_22;
		colorScheme_0.ItemPressedText = color_23;
		colorScheme_0.ItemText = color_19;
		colorScheme_0.ItemExpandedBackground = color_20;
		colorScheme_0.ItemExpandedBackground2 = color_21;
		colorScheme_0.ItemExpandedBackgroundGradientAngle = int_1;
		colorScheme_0.ItemExpandedShadow = Color.Empty;
		colorScheme_0.ItemExpandedText = color_23;
		colorScheme_0.MenuBackground = color_24;
		colorScheme_0.MenuBackground2 = color_25;
		colorScheme_0.MenuBackgroundGradientAngle = int_2;
		colorScheme_0.MenuBorder = color_26;
		colorScheme_0.MenuSide = color_27;
		colorScheme_0.MenuSide2 = color_28;
		colorScheme_0.MenuSideGradientAngle = int_3;
	}
}
