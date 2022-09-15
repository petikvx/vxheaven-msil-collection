using System;

namespace DevComponents.DotNetBar;

public class BubbleBarTabChangingEventArgs : EventArgs
{
	public bool Cancel;

	public eEventSource Source = eEventSource.Code;

	public BubbleBarTab NewTab;

	public BubbleBarTab CurrentTab;
}
