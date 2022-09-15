using System;

namespace DevComponents.AdvTree;

public class SelectedNodesCollection : NodeCollection
{
	internal AdvTree advTree_1;

	internal bool bool_1;

	public SelectedNodesCollection()
	{
		base.Boolean_0 = true;
	}

	public override int Add(Node node, eTreeAction action)
	{
		if (base.List.Contains(node))
		{
			return -1;
		}
		if (advTree_1.MultiSelect)
		{
			if (advTree_1.MultiSelectRule == eMultiSelectRule.SameParent && base.Count > 0 && base[0].Parent != node.Parent)
			{
				throw new InvalidOperationException("Node being added does not belong to the same parent as currently selected nodes. See AdvTree.MultiSelectRule property");
			}
			if (!bool_1)
			{
				AdvTreeNodeCancelEventArgs advTreeNodeCancelEventArgs = new AdvTreeNodeCancelEventArgs(action, node);
				advTree_1.method_61(advTreeNodeCancelEventArgs);
				if (advTreeNodeCancelEventArgs.Cancel)
				{
					return -1;
				}
			}
		}
		return base.Add(node, action);
	}

	protected override void OnInsertComplete(int index, object value)
	{
		if (advTree_1.MultiSelect)
		{
			Node node = value as Node;
			advTree_1.method_7(node);
			if (node.SelectedCell == null)
			{
				node.Cells[0].SetSelected(selected: true);
			}
			AdvTreeNodeEventArgs advTreeNodeEventArgs_ = new AdvTreeNodeEventArgs(base.ETreeAction_0, node);
			advTree_1.method_60(advTreeNodeEventArgs_);
		}
		base.OnInsertComplete(index, value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		if (advTree_1.MultiSelect)
		{
			Node node = value as Node;
			advTree_1.method_7(node);
			if (node.SelectedCell != null)
			{
				node.SelectedCell.SetSelected(selected: false);
			}
			advTree_1.method_59(new AdvTreeNodeEventArgs(base.ETreeAction_0, node));
		}
		base.OnRemoveComplete(index, value);
	}

	protected override void OnClear()
	{
		if (advTree_1.MultiSelect)
		{
			foreach (Node item in base.List)
			{
				advTree_1.method_7(item);
				if (item.SelectedCell == null)
				{
					item.Cells[0].SetSelected(selected: false);
				}
				advTree_1.method_59(new AdvTreeNodeEventArgs(base.ETreeAction_0, item));
			}
		}
		base.OnClear();
	}
}
