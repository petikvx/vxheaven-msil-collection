using System;

namespace DevComponents.AdvTree;

public class AdvTreeNodeEventArgs : EventArgs
{
	public eTreeAction Action = eTreeAction.Code;

	public Node Node;

	public AdvTreeNodeEventArgs(eTreeAction action, Node node)
	{
		Action = action;
		Node = node;
	}
}
