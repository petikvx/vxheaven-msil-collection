using System;
using System.Drawing;

namespace DevComponents.AdvTree.Display;

public class DragDropMarkerRendererEventArgs : EventArgs
{
	public Graphics Graphics;

	public Rectangle Bounds = Rectangle.Empty;

	public DragDropMarkerRendererEventArgs()
	{
	}

	public DragDropMarkerRendererEventArgs(Graphics graphics, Rectangle bounds)
	{
		Graphics = graphics;
		Bounds = bounds;
	}
}
