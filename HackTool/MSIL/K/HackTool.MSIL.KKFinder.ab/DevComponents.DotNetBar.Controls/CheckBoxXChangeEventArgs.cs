using System;

namespace DevComponents.DotNetBar.Controls;

public class CheckBoxXChangeEventArgs : EventArgs
{
	public bool Cancel;

	public readonly CheckBoxX NewChecked;

	public readonly CheckBoxX OldChecked;

	public readonly eEventSource EventSource = eEventSource.Code;

	public CheckBoxXChangeEventArgs(CheckBoxX oldchecked, CheckBoxX newchecked, eEventSource eventSource)
	{
		NewChecked = newchecked;
		OldChecked = oldchecked;
		EventSource = eventSource;
	}
}
