using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class MeasureTabItemEventArgs : EventArgs
{
	public readonly TabItem TabItem;

	public Size Size = Size.Empty;

	public MeasureTabItemEventArgs(TabItem tab, Size size)
	{
		TabItem = tab;
		Size = size;
	}
}
