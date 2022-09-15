using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar;

internal class Class103
{
	public void method_0(ItemContainer itemContainer_0, ItemPaintArgs itemPaintArgs_0)
	{
		foreach (BaseItem subItem in itemContainer_0.SubItems)
		{
			if (subItem.Visible && subItem.Displayed)
			{
				if (subItem.BeginGroup && itemPaintArgs_0.BaseRenderer_0 != null)
				{
					itemPaintArgs_0.BaseRenderer_0.DrawItemContainerSeparator(new ItemContainerSeparatorRendererEventArgs(itemPaintArgs_0.Graphics, itemContainer_0, subItem));
				}
				if (itemPaintArgs_0.ClipRectangle.IsEmpty || itemPaintArgs_0.ClipRectangle.IntersectsWith(subItem.DisplayRectangle))
				{
					Region clip = itemPaintArgs_0.Graphics.get_Clip().Clone();
					itemPaintArgs_0.Graphics.SetClip(subItem.DisplayRectangle, (CombineMode)1);
					subItem.Paint(itemPaintArgs_0);
					itemPaintArgs_0.Graphics.set_Clip(clip);
				}
			}
		}
	}

	public void method_1(BaseItem baseItem_0, ItemPaintArgs itemPaintArgs_0)
	{
		foreach (BaseItem subItem in baseItem_0.SubItems)
		{
			if (subItem.Visible && subItem.Displayed && (itemPaintArgs_0.ClipRectangle.IsEmpty || itemPaintArgs_0.ClipRectangle.IntersectsWith(subItem.DisplayRectangle)))
			{
				Region clip = itemPaintArgs_0.Graphics.get_Clip().Clone();
				itemPaintArgs_0.Graphics.SetClip(subItem.DisplayRectangle, (CombineMode)1);
				subItem.Paint(itemPaintArgs_0);
				itemPaintArgs_0.Graphics.set_Clip(clip);
			}
		}
	}
}
