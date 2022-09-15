using System;

namespace DevComponents.DotNetBar;

public class TabStripTabChangingEventArgs : EventArgs
{
	public readonly TabItem OldTab;

	public readonly TabItem NewTab;

	public bool Cancel;

	public readonly eEventSource EventSource = eEventSource.Code;

	public TabStripTabChangingEventArgs(TabItem oldtab, TabItem newtab, eEventSource source)
	{
		OldTab = oldtab;
		NewTab = newtab;
		EventSource = source;
	}
}
