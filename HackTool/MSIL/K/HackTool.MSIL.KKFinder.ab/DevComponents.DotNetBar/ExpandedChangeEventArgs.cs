using System;

namespace DevComponents.DotNetBar;

public class ExpandedChangeEventArgs : EventArgs
{
	public readonly eEventSource EventSource = eEventSource.Code;

	public bool Cancel;

	public readonly bool NewExpandedValue;

	public ExpandedChangeEventArgs(eEventSource action, bool newExpandedValue)
	{
		EventSource = action;
		NewExpandedValue = newExpandedValue;
	}
}
