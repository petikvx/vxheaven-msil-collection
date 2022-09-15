using System.Collections;

namespace DevComponents.AdvTree;

public class NodeComparer : IComparer
{
	private int int_0;

	public int ColumnIndex
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	public NodeComparer()
	{
	}

	public NodeComparer(int columnIndex)
	{
		int_0 = columnIndex;
	}

	public virtual int Compare(object x, object y)
	{
		Node node = (Node)x;
		Node node2 = (Node)y;
		if (int_0 < node.Cells.Count && int_0 < node2.Cells.Count)
		{
			return Utilities.smethod_3(node.Cells[int_0].Text, node2.Cells[int_0].Text);
		}
		return 0;
	}
}
