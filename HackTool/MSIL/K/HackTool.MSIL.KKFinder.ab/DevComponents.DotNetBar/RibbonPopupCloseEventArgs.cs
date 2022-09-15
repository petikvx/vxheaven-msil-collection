using System;

namespace DevComponents.DotNetBar;

public class RibbonPopupCloseEventArgs : EventArgs
{
	public bool Cancel;

	public object Source;

	public eEventSource EventSource = eEventSource.Code;

	public RibbonPopupCloseEventArgs(object source, eEventSource eventSource)
	{
		Source = source;
		EventSource = eventSource;
	}
}
