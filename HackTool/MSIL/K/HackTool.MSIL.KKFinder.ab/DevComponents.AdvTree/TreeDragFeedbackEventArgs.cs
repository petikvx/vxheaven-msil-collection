using System;

namespace DevComponents.AdvTree;

public class TreeDragFeedbackEventArgs : EventArgs
{
	public bool AllowDrop = true;

	public Node ParentNode;

	public int InsertPosition;

	private Node node_0;

	public Node DragNode
	{
		get
		{
			return node_0;
		}
		set
		{
			node_0 = value;
		}
	}

	public TreeDragFeedbackEventArgs(Node parentNode, int insertPosition, Node dragNode)
	{
		ParentNode = parentNode;
		InsertPosition = insertPosition;
		node_0 = dragNode;
	}

	public TreeDragFeedbackEventArgs()
	{
	}
}
