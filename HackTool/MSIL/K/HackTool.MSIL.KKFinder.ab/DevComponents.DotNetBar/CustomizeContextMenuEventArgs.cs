using System;

namespace DevComponents.DotNetBar;

public class CustomizeContextMenuEventArgs : EventArgs
{
	private readonly BaseItem baseItem_0;

	public BaseItem Parent => baseItem_0;

	public CustomizeContextMenuEventArgs(BaseItem parentItem)
	{
		baseItem_0 = parentItem;
	}
}
