namespace DevComponents.AdvTree;

public class TreeNodeCollectionEventArgs : AdvTreeNodeEventArgs
{
	public Node ParentNode;

	public TreeNodeCollectionEventArgs(eTreeAction action, Node node, Node parentNode)
		: base(action, node)
	{
		ParentNode = parentNode;
	}
}
