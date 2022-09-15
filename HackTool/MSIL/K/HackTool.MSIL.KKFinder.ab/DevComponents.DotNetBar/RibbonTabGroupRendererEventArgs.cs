using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class RibbonTabGroupRendererEventArgs : EventArgs
{
	public Graphics Graphics;

	public RibbonTabItemGroup RibbonTabItemGroup;

	public Rectangle Bounds = Rectangle.Empty;

	public Font GroupFont;

	public Rectangle GroupBounds = Rectangle.Empty;

	public ItemPaintArgs ItemPaintArgs;

	public RibbonTabGroupRendererEventArgs(Graphics g, RibbonTabItemGroup group, Rectangle bounds, Rectangle groupBounds, Font font, ItemPaintArgs pa)
	{
		Graphics = g;
		RibbonTabItemGroup = group;
		Bounds = bounds;
		GroupBounds = groupBounds;
		GroupFont = font;
		ItemPaintArgs = pa;
	}
}
