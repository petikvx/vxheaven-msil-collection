using System;

namespace DevComponents.DotNetBar;

public class TabStripTabChangedEventArgs : EventArgs
{
	public readonly TabItem OldTab;

	public readonly TabItem NewTab;

	public readonly eEventSource EventSource = eEventSource.Code;

	public TabStripTabChangedEventArgs(TabItem oldtab, TabItem newtab, eEventSource source)
	{
		OldTab = oldtab;
		NewTab = newtab;
		EventSource = source;
	}
}
