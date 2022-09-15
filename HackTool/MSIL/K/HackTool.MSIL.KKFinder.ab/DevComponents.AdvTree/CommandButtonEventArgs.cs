using System;

namespace DevComponents.AdvTree;

public class CommandButtonEventArgs : EventArgs
{
	public eTreeAction Action = eTreeAction.Code;

	public Node Node;

	public CommandButtonEventArgs(eTreeAction action, Node node)
	{
		Action = action;
		Node = node;
	}
}
