using System.Drawing;

namespace DevComponents.DotNetBar;

internal class Class272
{
	public static Color smethod_0(ButtonItem buttonItem_0, ItemPaintArgs itemPaintArgs_0)
	{
		Color controlText = SystemColors.ControlText;
		if (!Class265.smethod_1(buttonItem_0, itemPaintArgs_0))
		{
			if (!itemPaintArgs_0.Colors.ItemDisabledText.IsEmpty)
			{
				return itemPaintArgs_0.Colors.ItemDisabledText;
			}
			return SystemColors.ControlDark;
		}
		if (buttonItem_0.IsMouseDown && !itemPaintArgs_0.Colors.ItemPressedText.IsEmpty)
		{
			return itemPaintArgs_0.Colors.ItemPressedText;
		}
		if (buttonItem_0.IsMouseOver)
		{
			if (!buttonItem_0.HotForeColor.IsEmpty)
			{
				return buttonItem_0.HotForeColor;
			}
			return itemPaintArgs_0.Colors.ItemHotText;
		}
		if (buttonItem_0.Expanded && !itemPaintArgs_0.Colors.ItemExpandedText.IsEmpty)
		{
			return itemPaintArgs_0.Colors.ItemExpandedText;
		}
		if (buttonItem_0.Checked && !itemPaintArgs_0.Colors.ItemCheckedText.IsEmpty)
		{
			return itemPaintArgs_0.Colors.ItemCheckedText;
		}
		if (!buttonItem_0.ForeColor.IsEmpty)
		{
			return buttonItem_0.ForeColor;
		}
		if (buttonItem_0.Boolean_2 && buttonItem_0.IsOnMenuBar && itemPaintArgs_0.Colors.ItemText == SystemColors.ControlText)
		{
			return SystemColors.MenuText;
		}
		return itemPaintArgs_0.Colors.ItemText;
	}
}
