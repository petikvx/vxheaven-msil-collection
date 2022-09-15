namespace DevComponents.AdvTree;

public class NodeComparerReverse : NodeComparer
{
	public NodeComparerReverse(int columnIndex)
		: base(columnIndex)
	{
	}

	public override int Compare(object x, object y)
	{
		return base.Compare(y, x);
	}
}
