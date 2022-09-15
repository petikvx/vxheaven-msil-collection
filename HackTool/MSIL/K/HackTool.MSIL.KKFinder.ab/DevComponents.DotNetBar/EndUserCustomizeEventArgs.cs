using System;

namespace DevComponents.DotNetBar;

public class EndUserCustomizeEventArgs : EventArgs
{
	public readonly eEndUserCustomizeAction Action;

	public EndUserCustomizeEventArgs(eEndUserCustomizeAction action)
	{
		Action = action;
	}
}
