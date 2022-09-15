using System.Drawing;

namespace DevComponents.AdvTree.Display;

public class TreeBackgroundRendererEventArgs
{
	public Graphics Graphics;

	public AdvTree AdvTree;

	public TreeBackgroundRendererEventArgs(Graphics g, AdvTree tree)
	{
		Graphics = g;
		AdvTree = tree;
	}
}
