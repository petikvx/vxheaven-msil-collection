using System;
using System.Drawing;

namespace DevComponents.DotNetBar.Controls;

internal class EventArgs3 : EventArgs
{
	public Graphics graphics_0;

	public Rectangle rectangle_0 = Rectangle.Empty;

	public EventArgs3(Graphics g, Rectangle r)
	{
		graphics_0 = g;
		rectangle_0 = r;
	}
}
