using System.Drawing;

namespace DevComponents.DotNetBar;

public class ToolbarRendererEventArgs
{
	public Bar Bar;

	public Graphics Graphics;

	public Rectangle Bounds = Rectangle.Empty;

	internal ItemPaintArgs itemPaintArgs_0;

	public ToolbarRendererEventArgs(Bar bar, Graphics g, Rectangle bounds)
	{
		Bar = bar;
		Graphics = g;
		Bounds = bounds;
	}
}
