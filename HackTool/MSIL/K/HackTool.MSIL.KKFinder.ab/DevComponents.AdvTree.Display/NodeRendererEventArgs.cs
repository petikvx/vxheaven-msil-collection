using System;
using System.Drawing;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Display;

public class NodeRendererEventArgs : EventArgs
{
	public Graphics Graphics;

	public Node Node;

	public Rectangle NodeBounds = Rectangle.Empty;

	public ElementStyle Style;

	public NodeRendererEventArgs()
	{
	}

	public NodeRendererEventArgs(Graphics g, Node node, Rectangle bounds, ElementStyle style)
	{
		Graphics = g;
		Node = node;
		NodeBounds = bounds;
		Style = style;
	}
}
