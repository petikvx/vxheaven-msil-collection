using System;
using System.Drawing;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Display;

public class ColumnHeaderRendererEventArgs : EventArgs
{
	public ColumnHeader ColumnHeader;

	public Graphics Graphics;

	public Rectangle Bounds;

	public ElementStyle Style;

	public AdvTree Tree;

	public ColumnHeaderRendererEventArgs()
	{
	}

	public ColumnHeaderRendererEventArgs(AdvTree tree, ColumnHeader columnHeader, Graphics graphics, Rectangle bounds, ElementStyle style)
	{
		Tree = tree;
		ColumnHeader = columnHeader;
		Graphics = graphics;
		Bounds = bounds;
		Style = style;
	}
}
