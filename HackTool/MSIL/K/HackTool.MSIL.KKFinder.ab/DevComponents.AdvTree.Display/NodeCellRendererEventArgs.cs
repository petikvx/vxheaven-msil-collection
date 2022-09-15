using System.Drawing;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Display;

public class NodeCellRendererEventArgs : NodeRendererEventArgs
{
	public Cell Cell;

	public Rectangle CellBounds = Rectangle.Empty;

	internal Point point_0 = Point.Empty;

	internal ColorScheme colorScheme_0;

	internal Image image_0;

	internal Image image_1;

	internal Image image_2;

	public NodeCellRendererEventArgs()
		: base(null, null, Rectangle.Empty, null)
	{
	}

	public NodeCellRendererEventArgs(Graphics g, Node node, Rectangle bounds, ElementStyle style, Cell cell, Rectangle cellBounds)
		: base(g, node, bounds, style)
	{
		Cell = cell;
		CellBounds = cellBounds;
	}
}
