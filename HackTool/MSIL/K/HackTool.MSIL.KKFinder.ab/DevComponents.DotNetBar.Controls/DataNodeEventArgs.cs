using System;
using DevComponents.AdvTree;

namespace DevComponents.DotNetBar.Controls;

public class DataNodeEventArgs : EventArgs
{
	public Node Node;

	public readonly object DataItem;

	public DataNodeEventArgs(Node node, object dataItem)
	{
		Node = node;
		DataItem = dataItem;
	}
}
