namespace DevComponents.AdvTree;

public class AdvTreeNodeCancelEventArgs : AdvTreeNodeEventArgs
{
	public bool Cancel;

	public AdvTreeNodeCancelEventArgs(eTreeAction action, Node node)
		: base(action, node)
	{
	}
}
