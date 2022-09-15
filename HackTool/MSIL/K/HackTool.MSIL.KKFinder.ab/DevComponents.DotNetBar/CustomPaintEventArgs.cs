using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class CustomPaintEventArgs : EventArgs
{
	private Graphics graphics_0;

	private Rectangle rectangle_0 = Rectangle.Empty;

	public Graphics Graphics => graphics_0;

	public Rectangle PaintRectangle => rectangle_0;

	public CustomPaintEventArgs(Graphics g, Rectangle r)
	{
		graphics_0 = g;
		rectangle_0 = r;
	}
}
