namespace DevComponents.AdvTree;

public class TreeDragDropEventArgs : AdvTreeNodeCancelEventArgs
{
	public readonly Node OldParentNode;

	public readonly Node NewParentNode;

	public TreeDragDropEventArgs(eTreeAction action, Node node, Node oldParentNode, Node newParentNode)
		: base(action, node)
	{
		NewParentNode = newParentNode;
		OldParentNode = oldParentNode;
	}
}
