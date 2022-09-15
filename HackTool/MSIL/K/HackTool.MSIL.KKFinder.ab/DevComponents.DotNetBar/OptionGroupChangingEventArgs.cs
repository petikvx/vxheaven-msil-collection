using System;

namespace DevComponents.DotNetBar;

public class OptionGroupChangingEventArgs : EventArgs
{
	public bool Cancel;

	public readonly ButtonItem NewChecked;

	public readonly ButtonItem OldChecked;

	public OptionGroupChangingEventArgs(ButtonItem oldchecked, ButtonItem newchecked)
	{
		NewChecked = newchecked;
		OldChecked = oldchecked;
	}
}
