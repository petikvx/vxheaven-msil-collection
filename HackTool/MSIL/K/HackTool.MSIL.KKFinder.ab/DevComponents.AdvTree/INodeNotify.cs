namespace DevComponents.AdvTree;

public interface INodeNotify
{
	void ExpandedChanged(Node node);

	void OnBeforeCollapse(AdvTreeNodeCancelEventArgs e);

	void OnBeforeExpand(AdvTreeNodeCancelEventArgs e);

	void OnAfterCollapse(AdvTreeNodeEventArgs e);

	void OnAfterExpand(AdvTreeNodeEventArgs e);
}
