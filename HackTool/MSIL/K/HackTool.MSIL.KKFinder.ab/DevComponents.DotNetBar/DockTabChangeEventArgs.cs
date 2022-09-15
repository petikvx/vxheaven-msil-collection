using System;

namespace DevComponents.DotNetBar;

public class DockTabChangeEventArgs : EventArgs
{
	public readonly BaseItem OldTab;

	public readonly BaseItem NewTab;

	public bool Cancel;

	public DockTabChangeEventArgs(BaseItem oldtab, BaseItem newtab)
	{
		OldTab = oldtab;
		NewTab = newtab;
	}
}
