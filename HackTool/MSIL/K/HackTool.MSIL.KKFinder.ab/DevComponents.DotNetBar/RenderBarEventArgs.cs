using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class RenderBarEventArgs : EventArgs
{
	public readonly Bar Bar;

	public Rectangle Bounds = Rectangle.Empty;

	public readonly eBarRenderPart Part;

	public bool Cancel;

	public readonly Graphics Graphics;

	public RenderBarEventArgs(Bar bar, Graphics g, eBarRenderPart part, Rectangle bounds)
	{
		Bar = bar;
		Part = part;
		Bounds = bounds;
		Graphics = g;
	}
}
