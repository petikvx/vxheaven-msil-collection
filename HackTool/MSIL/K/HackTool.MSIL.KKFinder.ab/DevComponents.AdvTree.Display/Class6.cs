using System.Drawing;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Display;

internal class Class6
{
	public ElementStyle elementStyle_0;

	public Graphics graphics_0;

	public Cell cell_0;

	public Point point_0 = Point.Empty;

	public Class6()
	{
	}

	public Class6(ElementStyle style, Graphics g, Cell cell, Point cellOffset)
	{
		elementStyle_0 = style;
		graphics_0 = g;
		cell_0 = cell;
		point_0 = cellOffset;
	}
}
