using System;
using System.Windows.Forms;

namespace DevComponents.AdvTree;

public class TreeNodeMouseEventArgs : EventArgs
{
	public readonly Node Node;

	public readonly MouseButtons Button;

	public readonly int Clicks;

	public readonly int Delta;

	public readonly int X;

	public readonly int Y;

	public TreeNodeMouseEventArgs(Node node, MouseButtons button, int clicks, int delta, int x, int y)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Node = node;
		Button = button;
		Clicks = clicks;
		Delta = delta;
		X = x;
		Y = y;
	}
}
