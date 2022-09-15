using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class SuperTooltipEventArgs : EventArgs
{
	public bool Cancel;

	public readonly object Source;

	public readonly SuperTooltipInfo TooltipInfo;

	public Point Location;

	public SuperTooltipEventArgs(object source, SuperTooltipInfo info, Point location)
	{
		Source = source;
		TooltipInfo = info;
		Location = location;
	}
}
