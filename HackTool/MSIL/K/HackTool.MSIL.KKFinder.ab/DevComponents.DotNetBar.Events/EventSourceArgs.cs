using System;

namespace DevComponents.DotNetBar.Events;

public class EventSourceArgs : EventArgs
{
	public readonly eEventSource Source = eEventSource.Code;

	public EventSourceArgs(eEventSource source)
	{
		Source = source;
	}
}
