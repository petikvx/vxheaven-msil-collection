using System.Collections;

namespace DevComponents.DotNetBar;

internal class Class182 : GenericItemContainer
{
	protected override bool OnBeforeLayout()
	{
		if (Orientation != 0)
		{
			return true;
		}
		ArrayList arrayList = new ArrayList();
		int num = 0;
		int num2 = 0;
		int num3 = 24;
		int num4 = WidthInternal - (base.PaddingLeft + base.PaddingRight);
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem.Visible)
			{
				subItem.RecalcSize();
				num += subItem.WidthInternal + base.ItemSpacing;
				if (subItem is RibbonTabItem)
				{
					((RibbonTabItem)subItem).Boolean_8 = false;
					arrayList.Add(subItem);
					num2 += subItem.WidthInternal + base.ItemSpacing;
				}
			}
		}
		int num5 = num - num4;
		if (num > num4 && num2 > 0)
		{
			if (num5 >= num2 - (num3 * arrayList.Count + arrayList.Count - 1))
			{
				foreach (RibbonTabItem item in arrayList)
				{
					item.WidthInternal = num3;
					item.Boolean_8 = true;
				}
			}
			else
			{
				float num6 = 1f - (float)num5 / (float)num2;
				bool boolean_ = false;
				if ((double)num6 <= 0.75)
				{
					boolean_ = true;
				}
				for (int i = 0; i < arrayList.Count; i++)
				{
					RibbonTabItem ribbonTabItem2 = arrayList[i] as RibbonTabItem;
					ribbonTabItem2.Boolean_8 = boolean_;
					if (i == arrayList.Count - 1)
					{
						ribbonTabItem2.WidthInternal -= num5;
						continue;
					}
					int num7 = (int)((float)ribbonTabItem2.WidthInternal * num6);
					if (num7 < num3)
					{
						num7 = num3;
					}
					num5 -= ribbonTabItem2.WidthInternal - num7;
					ribbonTabItem2.WidthInternal = num7;
				}
			}
		}
		return false;
	}
}
