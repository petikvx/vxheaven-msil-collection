using System;

namespace DevComponents.DotNetBar;

public class OverflowButtonEventArgs : EventArgs
{
	private readonly ButtonItem buttonItem_0;

	public ButtonItem OverflowButton => buttonItem_0;

	public OverflowButtonEventArgs(ButtonItem ob)
	{
		buttonItem_0 = ob;
	}
}
