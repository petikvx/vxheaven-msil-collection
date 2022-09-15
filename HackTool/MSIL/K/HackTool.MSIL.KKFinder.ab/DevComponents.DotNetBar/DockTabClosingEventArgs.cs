using System;

namespace DevComponents.DotNetBar;

public class DockTabClosingEventArgs : EventArgs
{
	public readonly DockContainerItem DockContainerItem;

	public bool Cancel;

	public bool RemoveDockTab;

	public readonly eEventSource Source;

	public DockTabClosingEventArgs(DockContainerItem item, eEventSource source)
	{
		DockContainerItem = item;
		Source = source;
	}
}
