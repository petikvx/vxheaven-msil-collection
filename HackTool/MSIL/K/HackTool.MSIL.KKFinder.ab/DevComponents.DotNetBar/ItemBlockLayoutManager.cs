using System.Drawing;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

public class ItemBlockLayoutManager : BlockLayoutManager
{
	public override void Layout(IBlock block, Size availableSize)
	{
		if (block is BaseItem)
		{
			BaseItem baseItem = block as BaseItem;
			if (baseItem is ItemContainer || baseItem.IsContainer)
			{
				baseItem.SuspendLayout = true;
				baseItem.WidthInternal = availableSize.Width;
				baseItem.HeightInternal = availableSize.Height;
				baseItem.SuspendLayout = false;
			}
			baseItem.RecalcSize();
			baseItem.Displayed = baseItem.Visible;
		}
	}
}
