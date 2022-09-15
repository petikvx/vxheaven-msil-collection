using System.Collections;
using System.ComponentModel;

namespace DevComponents.AdvTree;

public class NodeCollection : CollectionBase
{
	private Node node_0;

	private AdvTree advTree_0;

	private eTreeAction eTreeAction_0 = eTreeAction.Code;

	private bool bool_0;

	internal eTreeAction ETreeAction_0
	{
		get
		{
			return eTreeAction_0;
		}
		set
		{
			eTreeAction_0 = value;
		}
	}

	internal bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Node ParentNode => node_0;

	internal AdvTree AdvTree_0
	{
		get
		{
			return advTree_0;
		}
		set
		{
			advTree_0 = value;
		}
	}

	public Node this[int index]
	{
		get
		{
			return (Node)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	internal void method_0(Node node_1)
	{
		node_0 = node_1;
	}

	public virtual int Add(Node node)
	{
		return Add(node, eTreeAction.Code);
	}

	public virtual int Add(Node node, eTreeAction action)
	{
		eTreeAction_0 = action;
		return base.List.Add(node);
	}

	public void AddRange(Node[] nodes)
	{
		foreach (Node node in nodes)
		{
			Add(node);
		}
	}

	public virtual void Insert(int index, Node value)
	{
		base.List.Insert(index, value);
	}

	public virtual void Insert(int index, Node value, eTreeAction action)
	{
		eTreeAction_0 = action;
		base.List.Insert(index, value);
	}

	public int IndexOf(Node value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(Node value)
	{
		return base.List.Contains(value);
	}

	public virtual void Remove(Node value)
	{
		base.List.Remove(value);
	}

	public virtual void Remove(Node node, eTreeAction action)
	{
		eTreeAction_0 = action;
		base.List.Remove(node);
	}

	protected override void OnRemove(int index, object value)
	{
		if (!bool_0)
		{
			method_2()?.InvokeBeforeNodeRemove(eTreeAction_0, value as Node, node_0);
		}
		base.OnRemove(index, value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		base.OnRemoveComplete(index, value);
		if (!bool_0)
		{
			Node node = value as Node;
			node.SetParent(null);
			node.advTree_0 = null;
			if (node_0 != null)
			{
				node_0.OnChildNodeRemoved(node);
			}
			method_2()?.NodeRemoved(eTreeAction_0, value as Node, node_0, index);
		}
	}

	protected override void OnInsert(int index, object value)
	{
		if (!bool_0)
		{
			method_2()?.InvokeBeforeNodeInsert(eTreeAction_0, value as Node, node_0);
		}
		base.OnInsert(index, value);
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
		if (!bool_0)
		{
			Node node = value as Node;
			if (node_0 != null)
			{
				if (node.Parent != null && node.Parent != node_0)
				{
					node.Remove();
				}
				node.SetParent(node_0);
			}
			node.advTree_0 = advTree_0;
			if (node_0 != null)
			{
				node_0.OnChildNodeInserted(node);
			}
			else
			{
				node.SizeChanged = true;
			}
			method_2()?.InvokeAfterNodeInsert(eTreeAction_0, value as Node, node_0);
		}
		eTreeAction_0 = eTreeAction.Code;
	}

	public void CopyTo(Node[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_1(Node[] node_1)
	{
		base.List.CopyTo(node_1, 0);
	}

	protected override void OnClear()
	{
		if (!bool_0)
		{
			foreach (Node item in base.List)
			{
				item.SetParent(null);
				item.advTree_0 = null;
			}
		}
		base.OnClear();
	}

	protected override void OnClearComplete()
	{
		if (advTree_0 != null && !Boolean_0)
		{
			advTree_0.method_81();
		}
		else if (node_0 != null && !Boolean_0)
		{
			node_0.OnNodesCleared();
		}
		base.OnClearComplete();
	}

	private AdvTree method_2()
	{
		if (advTree_0 != null)
		{
			return advTree_0;
		}
		if (node_0 != null)
		{
			return node_0.TreeControl;
		}
		return null;
	}

	public virtual void Sort()
	{
		Sort(0, base.Count, Comparer.Default);
	}

	public virtual void Sort(IComparer comparer)
	{
		Sort(0, base.Count, comparer);
	}

	public virtual void Sort(int index, int count, IComparer comparer)
	{
		AdvTree advTree = method_2();
		if (!bool_0)
		{
			advTree?.BeginUpdate();
		}
		base.InnerList.Sort(index, count, comparer);
		if (!bool_0)
		{
			advTree?.EndUpdate();
		}
	}

	public Node[] Find(string name, bool searchAllChildren)
	{
		ArrayList arrayList = new ArrayList();
		Class15.smethod_34(this, name, searchAllChildren, arrayList);
		Node[] array = new Node[arrayList.Count];
		if (arrayList.Count > 0)
		{
			arrayList.CopyTo(array);
		}
		return array;
	}
}
