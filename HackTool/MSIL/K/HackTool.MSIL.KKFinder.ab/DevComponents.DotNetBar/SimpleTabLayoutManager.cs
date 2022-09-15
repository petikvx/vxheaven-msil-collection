using System;
using System.Drawing;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

public class SimpleTabLayoutManager : BlockLayoutManager
{
	public override void Layout(IBlock block, Size availableSize)
	{
		if (base.Graphics == null)
		{
			throw new InvalidOperationException("Graphics property must be set to valid instance of Graphics object.");
		}
		ISimpleTab simpleTab = block as ISimpleTab;
		if (!simpleTab.Visible)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		int num4 = 0;
		int num5 = 1;
		int num6 = 1;
		int num7 = 2;
		eTextFormat eTextFormat_ = eTextFormat.Default;
		Font tabFont = simpleTab.GetTabFont();
		if (simpleTab.Text != "")
		{
			Size size = Class55.smethod_4(base.Graphics, simpleTab.Text, tabFont, 0, eTextFormat_);
			num += size.Width;
			if (size.Height > num2)
			{
				num2 = size.Height;
			}
		}
		else
		{
			num2 += tabFont.get_Height();
		}
		num2 += num3 + num4;
		if (simpleTab.IsSelected)
		{
			num2 += num7;
		}
		num += num5 + num6;
		if (simpleTab.TabAlignment != 0 && simpleTab.TabAlignment != eTabStripAlignment.Right)
		{
			block.Bounds = new Rectangle(0, 0, num, num2);
		}
		else
		{
			block.Bounds = new Rectangle(0, 0, num2, num);
		}
	}
}
