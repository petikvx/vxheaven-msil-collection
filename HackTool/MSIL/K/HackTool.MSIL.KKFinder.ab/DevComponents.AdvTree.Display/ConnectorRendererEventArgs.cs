using System;
using System.Drawing;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Display;

public class ConnectorRendererEventArgs : EventArgs
{
	public Node FromNode;

	public ElementStyle StyleFromNode;

	public Node ToNode;

	public ElementStyle StyleToNode;

	public Graphics Graphics;

	public Point Offset = Point.Empty;

	public bool IsRootNode;

	public NodeConnector NodeConnector;

	public bool LinkConnector;

	public ConnectorPointsCollection ConnectorPoints;
}
