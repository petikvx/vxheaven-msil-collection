using System.ComponentModel;
using System.Drawing;

namespace DevComponents.AdvTree.Display;

[ToolboxItem(false)]
public class TreeColorTable : Component
{
	public TreeSelectionColors Selection = new TreeSelectionColors();

	public Color DragDropMarker = Color.Black;

	public TreeExpandColorTable ExpandRectangle = new TreeExpandColorTable();

	public TreeExpandColorTable ExpandEllipse = new TreeExpandColorTable();

	public TreeExpandColorTable ExpandTriangle = new TreeExpandColorTable();

	public Color GridLines = Color.Empty;
}
