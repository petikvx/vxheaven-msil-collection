using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class NavPaneRenderEventArgs : EventArgs
{
	public Graphics Graphics;

	public Rectangle Bounds = Rectangle.Empty;

	public NavPaneRenderEventArgs(Graphics g, Rectangle bounds)
	{
		Graphics = g;
		Bounds = bounds;
	}
}
