using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.AdvTree;

internal class Class1
{
	public static void smethod_0(AdvTree advTree_0, KeyEventArgs keyEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		Keys keyCode = keyEventArgs_0.get_KeyCode();
		if ((int)keyCode != 32)
		{
			if ((int)keyCode == 113)
			{
				smethod_1(advTree_0, keyEventArgs_0);
			}
		}
		else
		{
			smethod_2(advTree_0, keyEventArgs_0);
			keyEventArgs_0.set_Handled(true);
		}
	}

	private static void smethod_1(AdvTree advTree_0, KeyEventArgs keyEventArgs_0)
	{
		if (advTree_0.method_30(eTreeAction.Keyboard))
		{
			keyEventArgs_0.set_Handled(true);
		}
	}

	public static void smethod_2(AdvTree advTree_0, KeyEventArgs keyEventArgs_0)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		Node selectedNode = advTree_0.SelectedNode;
		if (selectedNode == null || !selectedNode.CheckBoxVisible || !selectedNode.Enabled)
		{
			return;
		}
		if (selectedNode.CheckBoxThreeState)
		{
			if ((int)selectedNode.CheckState == 1)
			{
				selectedNode.SetChecked((CheckState)2, eTreeAction.Keyboard);
			}
			else if ((int)selectedNode.CheckState == 0)
			{
				selectedNode.SetChecked((CheckState)1, eTreeAction.Keyboard);
			}
			else if ((int)selectedNode.CheckState == 2)
			{
				selectedNode.SetChecked((CheckState)0, eTreeAction.Keyboard);
			}
		}
		else
		{
			selectedNode.SetChecked(!selectedNode.Checked, eTreeAction.Keyboard);
		}
		keyEventArgs_0.set_Handled(true);
	}

	public static void smethod_3(AdvTree advTree_0, KeyEventArgs keyEventArgs_0)
	{
		if (advTree_0.SelectedNode != null && advTree_0.SelectedNode.Nodes.Count > 0)
		{
			advTree_0.SelectedNode.Toggle(eTreeAction.Keyboard);
		}
	}

	public static void smethod_4(AdvTree advTree_0, KeyEventArgs keyEventArgs_0)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Invalid comparison between Unknown and I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Invalid comparison between Unknown and I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Invalid comparison between Unknown and I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Invalid comparison between Unknown and I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Invalid comparison between Unknown and I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Invalid comparison between Unknown and I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Invalid comparison between Unknown and I4
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Invalid comparison between Unknown and I4
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Invalid comparison between Unknown and I4
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Invalid comparison between Unknown and I4
		if (advTree_0.SelectedNode == null)
		{
			if (advTree_0.DisplayRootNode != null)
			{
				advTree_0.SelectNode(advTree_0.DisplayRootNode, eTreeAction.Keyboard);
			}
			else if (advTree_0.Nodes.Count > 0)
			{
				advTree_0.SelectNode(advTree_0.Nodes[0], eTreeAction.Keyboard);
			}
			return;
		}
		Node selectedNode = advTree_0.SelectedNode;
		if ((int)keyEventArgs_0.get_KeyCode() == 39)
		{
			if (selectedNode != null && selectedNode.Cells.Count > 1 && advTree_0.SelectionPerCell)
			{
				if (selectedNode.SelectedCell == null)
				{
					selectedNode.SelectedCell = Class15.smethod_39(selectedNode, -1);
				}
				else
				{
					selectedNode.SelectedCell = Class15.smethod_39(selectedNode, selectedNode.Cells.IndexOf(selectedNode.SelectedCell));
				}
				return;
			}
			Node node = Class15.smethod_28(selectedNode);
			if (node != null)
			{
				if (selectedNode.Expanded)
				{
					advTree_0.SelectNode(node, eTreeAction.Keyboard);
				}
				else
				{
					selectedNode.Expanded = true;
				}
			}
			else if (selectedNode != null && selectedNode.ExpandVisibility == eNodeExpandVisibility.Visible && !selectedNode.Expanded)
			{
				selectedNode.Expanded = true;
			}
			return;
		}
		if ((int)keyEventArgs_0.get_KeyCode() == 37)
		{
			if (selectedNode != null && selectedNode.Cells.Count > 1 && advTree_0.SelectionPerCell)
			{
				if (selectedNode.SelectedCell == null)
				{
					selectedNode.SelectedCell = Class15.smethod_40(selectedNode, selectedNode.Cells.Count - 1);
				}
				else
				{
					selectedNode.SelectedCell = Class15.smethod_40(selectedNode, selectedNode.Cells.IndexOf(selectedNode.SelectedCell));
				}
			}
			else if (selectedNode.Expanded && selectedNode.IsSelected && Class15.smethod_28(selectedNode) != null)
			{
				selectedNode.Expanded = false;
			}
			else if (selectedNode.Parent != null)
			{
				advTree_0.SelectNode(selectedNode.Parent, eTreeAction.Keyboard);
			}
			return;
		}
		if ((int)keyEventArgs_0.get_KeyCode() == 35)
		{
			Node node2 = Class15.smethod_5(advTree_0);
			if (node2 == null)
			{
				return;
			}
			if (!node2.Selectable)
			{
				while (node2 != null)
				{
					node2 = Class15.smethod_15(node2);
					if (node2 != null && node2.Selectable)
					{
						break;
					}
				}
			}
			if (node2 != null)
			{
				advTree_0.SelectNode(node2, eTreeAction.Keyboard);
			}
			return;
		}
		if ((int)keyEventArgs_0.get_KeyCode() != 36 && ((int)keyEventArgs_0.get_KeyCode() != 34 || selectedNode != null))
		{
			if ((int)keyEventArgs_0.get_KeyCode() == 34)
			{
				Node node3 = Class15.smethod_2(advTree_0);
				if (node3 != null && advTree_0.SelectedNode == node3 && advTree_0.VScrollBar != null && advTree_0.AutoScroll)
				{
					advTree_0.AutoScrollPosition = new Point(advTree_0.AutoScrollPosition.X, Math.Max(advTree_0.AutoScrollPosition.Y - advTree_0.VScrollBar.LargeChange, -(advTree_0.VScrollBar.Maximum - advTree_0.VScrollBar.LargeChange)));
					node3 = Class15.smethod_2(advTree_0);
				}
				if (node3 != null)
				{
					advTree_0.SelectNode(node3, eTreeAction.Keyboard);
				}
			}
			else if ((int)keyEventArgs_0.get_KeyCode() == 33)
			{
				Node node4 = Class15.smethod_3(advTree_0);
				if (node4 != null && advTree_0.SelectedNode == node4 && advTree_0.VScrollBar != null && advTree_0.AutoScroll && advTree_0.AutoScrollPosition.Y < 0)
				{
					advTree_0.AutoScrollPosition = new Point(advTree_0.AutoScrollPosition.X, Math.Min(0, advTree_0.AutoScrollPosition.Y + advTree_0.VScrollBar.LargeChange));
					node4 = Class15.smethod_3(advTree_0);
				}
				if (node4 != null)
				{
					advTree_0.SelectNode(node4, eTreeAction.Keyboard);
				}
			}
			else if ((keyEventArgs_0.get_KeyCode() & 0x28) == 40)
			{
				int num = 0;
				if (selectedNode != null && selectedNode.SelectedCell != null)
				{
					num = selectedNode.Cells.IndexOf(selectedNode.SelectedCell);
				}
				Node node5 = Class15.smethod_9(selectedNode);
				if (node5 == null)
				{
					return;
				}
				if ((keyEventArgs_0.get_KeyData() & 0x10000) == 65536 && advTree_0.MultiSelect && advTree_0.SelectedNodes.Count > 0)
				{
					if (advTree_0.MultiSelectRule != 0 || advTree_0.SelectedNodes[0].Parent == node5.Parent)
					{
						if (node5.IsSelected)
						{
							advTree_0.SelectedNodes.Remove(node5, eTreeAction.Keyboard);
						}
						else
						{
							advTree_0.SelectedNodes.Add(node5, eTreeAction.Keyboard);
						}
					}
				}
				else
				{
					advTree_0.SelectNode(node5, eTreeAction.Keyboard);
					if (advTree_0.SelectionPerCell && num < node5.Cells.Count && num > 0)
					{
						node5.SelectedCell = node5.Cells[num];
					}
				}
			}
			else
			{
				if ((keyEventArgs_0.get_KeyCode() & 0x26) != 38)
				{
					return;
				}
				int num2 = 0;
				if (selectedNode != null && selectedNode.SelectedCell != null)
				{
					num2 = selectedNode.Cells.IndexOf(selectedNode.SelectedCell);
				}
				Node node6 = Class15.smethod_15(selectedNode);
				if (node6 == null)
				{
					return;
				}
				if ((keyEventArgs_0.get_KeyData() & 0x10000) == 65536 && advTree_0.MultiSelect && advTree_0.SelectedNodes.Count > 0)
				{
					if (advTree_0.MultiSelectRule != 0 || advTree_0.SelectedNodes[0].Parent == node6.Parent)
					{
						if (node6.IsSelected)
						{
							advTree_0.SelectedNodes.Remove(advTree_0.SelectedNodes[advTree_0.SelectedNodes.Count - 1], eTreeAction.Keyboard);
						}
						else
						{
							advTree_0.SelectedNodes.Add(node6, eTreeAction.Keyboard);
						}
					}
				}
				else
				{
					advTree_0.SelectNode(node6, eTreeAction.Keyboard);
					if (advTree_0.SelectionPerCell && num2 < node6.Cells.Count && num2 > 0)
					{
						node6.SelectedCell = node6.Cells[num2];
					}
				}
			}
			return;
		}
		Node node7 = Class15.smethod_4(advTree_0);
		if (node7 == null)
		{
			return;
		}
		if (!node7.Selectable)
		{
			while (node7 != null)
			{
				node7 = Class15.smethod_9(node7);
				if (node7 != null && node7.Selectable)
				{
					break;
				}
			}
		}
		if (node7 != null)
		{
			advTree_0.SelectNode(node7, eTreeAction.Keyboard);
		}
	}
}
