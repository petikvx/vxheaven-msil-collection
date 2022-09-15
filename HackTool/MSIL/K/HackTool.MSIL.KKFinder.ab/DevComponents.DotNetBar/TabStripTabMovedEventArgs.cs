using System;

namespace DevComponents.DotNetBar;

public class TabStripTabMovedEventArgs : EventArgs
{
	public readonly TabItem Tab;

	public readonly int OldIndex;

	public readonly int NewIndex;

	public bool Cancel;

	public TabStripTabMovedEventArgs(TabItem tab, int oldindex, int newindex)
	{
		Tab = tab;
		OldIndex = oldindex;
		NewIndex = newindex;
	}
}
