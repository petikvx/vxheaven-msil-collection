using System;

namespace DevComponents.DotNetBar;

public class RibbonCustomizeEventArgs : EventArgs
{
	public bool Cancel;

	public object ContextObject;

	public BaseItem PopupMenu;

	public RibbonCustomizeEventArgs(object contextObject, BaseItem popupMenuItem)
	{
		ContextObject = contextObject;
		PopupMenu = popupMenuItem;
	}
}
