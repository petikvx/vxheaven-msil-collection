using System;

namespace DevComponents.DotNetBar;

public class CheckBoxChangeEventArgs : EventArgs
{
	public bool Cancel;

	public readonly CheckBoxItem NewChecked;

	public readonly CheckBoxItem OldChecked;

	public readonly eEventSource EventSource = eEventSource.Code;

	public CheckBoxChangeEventArgs(CheckBoxItem oldchecked, CheckBoxItem newchecked, eEventSource eventSource)
	{
		NewChecked = newchecked;
		OldChecked = oldchecked;
		EventSource = eventSource;
	}
}
