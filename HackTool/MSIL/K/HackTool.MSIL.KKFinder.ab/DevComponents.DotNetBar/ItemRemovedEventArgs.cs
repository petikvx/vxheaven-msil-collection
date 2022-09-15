using System;

namespace DevComponents.DotNetBar;

public class ItemRemovedEventArgs : EventArgs
{
	private readonly BaseItem baseItem_0;

	public BaseItem Parent => baseItem_0;

	public ItemRemovedEventArgs(BaseItem parentItem)
	{
		baseItem_0 = parentItem;
	}
}
