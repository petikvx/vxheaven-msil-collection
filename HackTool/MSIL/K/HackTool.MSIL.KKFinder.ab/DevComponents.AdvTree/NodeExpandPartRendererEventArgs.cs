using System;
using System.Drawing;

namespace DevComponents.AdvTree;

public class NodeExpandPartRendererEventArgs : EventArgs
{
	public Graphics Graphics;

	public Node Node;

	public Rectangle ExpandPartBounds = Rectangle.Empty;

	public Color BorderColor = Color.Empty;

	public Color ExpandLineColor = Color.Empty;

	public Color BackColor = Color.Empty;

	public Color BackColor2 = Color.Empty;

	public int BackColorGradientAngle = 90;

	public Image ExpandImage;

	public Image ExpandImageCollapse;

	internal eExpandButtonType eExpandButtonType_0;

	public bool IsMouseOver;

	public NodeExpandPartRendererEventArgs(Graphics g)
	{
		Graphics = g;
	}
}
