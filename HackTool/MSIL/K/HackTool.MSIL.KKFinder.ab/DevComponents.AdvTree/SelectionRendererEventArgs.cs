using System;
using System.Drawing;

namespace DevComponents.AdvTree;

public class SelectionRendererEventArgs : EventArgs
{
	public Graphics Graphics;

	public Node Node;

	public Rectangle Bounds = Rectangle.Empty;

	public eSelectionStyle SelectionBoxStyle = eSelectionStyle.HighlightCells;

	public bool TreeActive;
}
