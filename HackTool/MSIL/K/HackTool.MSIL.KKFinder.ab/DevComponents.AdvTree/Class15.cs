using System;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree.Display;

namespace DevComponents.AdvTree;

internal class Class15
{
	private static Color color_0 = Color.Empty;

	internal static int int_0 = 0;

	public static string smethod_0(Node node_0, string string_0)
	{
		if (node_0 == null)
		{
			throw new ArgumentNullException("node");
		}
		StringBuilder stringBuilder = new StringBuilder(node_0.Text);
		for (node_0 = node_0.Parent; node_0 != null; node_0 = node_0.Parent)
		{
			stringBuilder.Insert(0, node_0.Text + string_0);
		}
		return stringBuilder.ToString();
	}

	public static Node smethod_1(Node node_0)
	{
		if (node_0.Nodes.Count > 0)
		{
			return node_0.Nodes[node_0.Nodes.Count - 1];
		}
		return null;
	}

	public static Node smethod_2(AdvTree advTree_0)
	{
		Rectangle clientRectangle = ((Control)advTree_0).get_ClientRectangle();
		Node node = advTree_0.SelectedNode;
		if (node == null)
		{
			node = smethod_4(advTree_0);
		}
		Point point_ = Point.Empty;
		if (advTree_0.AutoScroll)
		{
			point_ = advTree_0.method_18();
		}
		Node result = null;
		if (clientRectangle.Contains(node.Bounds))
		{
			result = node;
		}
		while (node != null)
		{
			node = smethod_9(node);
			if (node != null && node.Selectable)
			{
				Rectangle rect = NodeDisplay.smethod_0(Enum4.const_0, node, point_);
				if (clientRectangle.Contains(rect))
				{
					result = node;
				}
				else if (rect.Y > clientRectangle.Bottom)
				{
					break;
				}
			}
		}
		return result;
	}

	public static Node smethod_3(AdvTree advTree_0)
	{
		Rectangle rectangle = advTree_0.method_17();
		Node node = advTree_0.SelectedNode;
		if (node == null)
		{
			node = smethod_4(advTree_0);
		}
		Point point_ = Point.Empty;
		if (advTree_0.AutoScroll)
		{
			point_ = advTree_0.method_18();
		}
		Node result = null;
		if (rectangle.Contains(node.Bounds))
		{
			result = node;
		}
		while (node != null)
		{
			node = smethod_15(node);
			if (node != null && node.Selectable)
			{
				Rectangle rect = NodeDisplay.smethod_0(Enum4.const_0, node, point_);
				if (rectangle.Contains(rect))
				{
					result = node;
				}
				else if (rect.Y < rectangle.Y)
				{
					break;
				}
			}
		}
		return result;
	}

	public static Node smethod_4(AdvTree advTree_0)
	{
		if (advTree_0.Nodes.Count == 0)
		{
			return null;
		}
		Node node = ((advTree_0.DisplayRootNode == null) ? advTree_0.Nodes[0] : advTree_0.DisplayRootNode);
		if (node.Visible)
		{
			return node;
		}
		return smethod_9(node);
	}

	public static Node smethod_5(AdvTree advTree_0)
	{
		if (advTree_0.Nodes.Count == 0)
		{
			return null;
		}
		Node node = ((advTree_0.DisplayRootNode == null) ? advTree_0.Nodes[advTree_0.Nodes.Count - 1] : advTree_0.DisplayRootNode);
		if (node.Visible)
		{
			if (node.Nodes.Count > 0 && node.Expanded)
			{
				Node node2 = smethod_29(node);
				if (node2 != null)
				{
					while (node2.Nodes.Count > 0 && node2.Expanded)
					{
						Node node3 = smethod_29(node2);
						if (node3 != null)
						{
							node2 = node3;
							continue;
						}
						return node2;
					}
					return node2;
				}
			}
			return node;
		}
		return smethod_15(node);
	}

	public static Node smethod_6(AdvTree advTree_0)
	{
		if (advTree_0.Nodes.Count == 0)
		{
			return null;
		}
		NodeCollection nodes = advTree_0.Nodes;
		if (advTree_0.DisplayRootNode != null)
		{
			nodes = advTree_0.DisplayRootNode.Nodes;
		}
		int num = nodes.Count - 1;
		while (true)
		{
			if (num >= 0)
			{
				if (nodes[num].Visible)
				{
					break;
				}
				num--;
				continue;
			}
			return null;
		}
		return nodes[num];
	}

	public static Node smethod_7(Node node_0)
	{
		if (node_0 == null)
		{
			return null;
		}
		NodeCollection nodeCollection = null;
		if (node_0.Parent != null)
		{
			nodeCollection = node_0.Parent.Nodes;
		}
		else if (node_0.advTree_0 != null)
		{
			nodeCollection = node_0.advTree_0.Nodes;
		}
		if (nodeCollection != null)
		{
			int num = nodeCollection.IndexOf(node_0);
			if (num < nodeCollection.Count - 1)
			{
				return nodeCollection[num + 1];
			}
		}
		return null;
	}

	public static Node smethod_8(Node node_0)
	{
		if (node_0 == null)
		{
			return null;
		}
		Node node = smethod_7(node_0);
		while (node != null && !node.Visible)
		{
			node = smethod_7(node);
		}
		return node;
	}

	public static Node smethod_9(Node node_0)
	{
		Node node = null;
		Node parent = node_0.Parent;
		Node node2 = null;
		while (parent != null)
		{
			if (!parent.Expanded)
			{
				node2 = parent;
			}
			parent = parent.Parent;
		}
		if (node2 != null)
		{
			if (node2.Parent != null)
			{
				node2 = node2.Parent;
			}
			while (node2 != null)
			{
				node2 = smethod_7(node2);
				if (node2 != null && node2.Visible)
				{
					return node2;
				}
			}
		}
		if (node_0.Expanded && node_0.Nodes.Count > 0)
		{
			foreach (Node node3 in node_0.Nodes)
			{
				if (node3.Visible)
				{
					return node3;
				}
			}
			return null;
		}
		node = smethod_10(node_0);
		while (true)
		{
			if (node != null)
			{
				if (node.Visible && node.IsVisible)
				{
					break;
				}
				node = smethod_10(node);
				continue;
			}
			return node;
		}
		return node;
	}

	public static Node smethod_10(Node node_0)
	{
		Node node = null;
		if (node_0.Nodes.Count > 0)
		{
			return node_0.Nodes[0];
		}
		node = smethod_7(node_0);
		if (node == null)
		{
			while (node == null && node_0 != null)
			{
				node_0 = node_0.Parent;
				node = smethod_7(node_0);
			}
		}
		return node;
	}

	public static bool smethod_11(Node node_0)
	{
		if (!node_0.Visible)
		{
			return false;
		}
		Node node = node_0;
		do
		{
			if (node.Parent != null)
			{
				node = node.Parent;
				continue;
			}
			return true;
		}
		while (node.Expanded && node.Visible);
		return false;
	}

	public static bool smethod_12(Node node_0)
	{
		if (node_0.Visible && smethod_11(node_0))
		{
			AdvTree treeControl = node_0.TreeControl;
			if (treeControl != null)
			{
				Rectangle rect = NodeDisplay.smethod_0(Enum4.const_5, node_0, treeControl.NodeDisplay_0.Offset);
				return ((Control)treeControl).get_ClientRectangle().IntersectsWith(rect);
			}
			return false;
		}
		return false;
	}

	public static int smethod_13(Node node_0)
	{
		if (node_0.Parent == null)
		{
			return node_0.TreeControl?.Nodes.IndexOf(node_0) ?? (-1);
		}
		return node_0.Parent.Nodes.IndexOf(node_0);
	}

	public static Node smethod_14(Node node_0)
	{
		if (node_0 == null)
		{
			return null;
		}
		NodeCollection nodeCollection = null;
		if (node_0.Parent != null)
		{
			nodeCollection = node_0.Parent.Nodes;
		}
		else if (node_0.advTree_0 != null)
		{
			nodeCollection = node_0.advTree_0.Nodes;
		}
		if (nodeCollection != null)
		{
			int num = nodeCollection.IndexOf(node_0);
			if (num > 0)
			{
				return nodeCollection[num - 1];
			}
		}
		return null;
	}

	public static Node smethod_15(Node node_0)
	{
		Node node = null;
		Node parent = node_0.Parent;
		Node node2 = null;
		while (parent != null)
		{
			if (!parent.Expanded)
			{
				node2 = parent;
			}
			parent = parent.Parent;
		}
		parent = ((node2 == null) ? node_0 : node2);
		if (parent.Parent != null)
		{
			if (parent.Parent.Nodes.IndexOf(parent) > 0)
			{
				node = smethod_16(parent);
				while (node != null && !node.Visible)
				{
					node = smethod_16(node);
				}
				if (node != null)
				{
					return node;
				}
			}
			else
			{
				while (parent.Parent != null)
				{
					if (!parent.Parent.Visible)
					{
						parent = parent.Parent;
						continue;
					}
					return parent.Parent;
				}
				if (parent.TreeControl != null)
				{
					node = smethod_16(parent);
				}
			}
		}
		else
		{
			if (parent.TreeControl == null)
			{
				return null;
			}
			node = smethod_14(parent);
		}
		if (node == null)
		{
			return null;
		}
		while (node.Expanded && node.Nodes.Count > 0)
		{
			node = node.Nodes[node.Nodes.Count - 1];
		}
		return node;
	}

	public static Node smethod_16(Node node_0)
	{
		Node node = null;
		if (node_0.Parent != null)
		{
			if (node_0.Parent.Nodes.IndexOf(node_0) <= 0)
			{
				return node_0.Parent;
			}
			node = smethod_14(node_0);
		}
		else
		{
			if (node_0.TreeControl == null)
			{
				return null;
			}
			node = smethod_14(node_0);
		}
		if (node == null)
		{
			return null;
		}
		while (node.Nodes.Count > 0)
		{
			node = node.Nodes[node.Nodes.Count - 1];
		}
		return node;
	}

	public static bool smethod_17(AdvTree advTree_0, Node node_0)
	{
		if (node_0.Parent != null && node_0 != advTree_0.DisplayRootNode)
		{
			return false;
		}
		return true;
	}

	public static void smethod_18(Node node_0, bool bool_0)
	{
		AdvTree treeControl = node_0.TreeControl;
		if (treeControl == null)
		{
			return;
		}
		treeControl.SuspendPaint = true;
		try
		{
			Node node = node_0;
			bool flag = false;
			while (node.Parent != null)
			{
				if (!node.Parent.Expanded)
				{
					node.Parent.Expand();
					flag = true;
				}
				node = node.Parent;
			}
			if (flag)
			{
				treeControl.method_46();
			}
			Rectangle rectangle = NodeDisplay.smethod_0(Enum4.const_5, node_0, treeControl.NodeDisplay_0.Offset);
			if (treeControl == null || !treeControl.AutoScroll)
			{
				return;
			}
			if (treeControl.Zoom != 1f)
			{
				rectangle = treeControl.GetScreenRectangle(rectangle);
			}
			Rectangle rectangle2 = treeControl.method_17();
			if (treeControl.VScrollBar != null)
			{
				rectangle2.Width -= ((Control)treeControl.VScrollBar).get_Width();
			}
			if (treeControl.HScrollBar != null)
			{
				rectangle2.Height -= ((Control)treeControl.HScrollBar).get_Height();
			}
			if (!rectangle2.Contains(rectangle))
			{
				Point offset = treeControl.NodeDisplay_0.Offset;
				if (bool_0 && rectangle.X < rectangle2.X)
				{
					offset.X -= rectangle.X;
				}
				if ((double)rectangle.Height > (double)rectangle2.Height * 0.8)
				{
					offset.Y = -Math.Max(0, rectangle.Y - 4);
				}
				else if (rectangle.Bottom > rectangle2.Bottom)
				{
					offset.Y -= rectangle.Bottom - rectangle2.Bottom + rectangle.Height;
				}
				else if (rectangle.Y < rectangle2.Y)
				{
					offset.Y -= rectangle.Y - rectangle.Height;
				}
				if (offset.Y > -10 && offset.Y < 0)
				{
					offset.Y = 0;
				}
				if (!treeControl.IsLayoutPending)
				{
					treeControl.AutoScrollPosition = offset;
				}
			}
		}
		finally
		{
			if (treeControl != null)
			{
				treeControl.SuspendPaint = false;
			}
		}
	}

	public static int smethod_19(Node node_0)
	{
		if (node_0.Nodes.Count == 0)
		{
			return 0;
		}
		int num = 0;
		foreach (Node node in node_0.Nodes)
		{
			if (node.Visible)
			{
				num++;
			}
		}
		return num;
	}

	public static bool smethod_20(Node node_0)
	{
		if (!node_0.HasChildNodes)
		{
			return false;
		}
		foreach (Node node in node_0.Nodes)
		{
			if (node.Visible)
			{
				return true;
			}
		}
		return false;
	}

	public static Class23 smethod_21(AdvTree advTree_0, Point point_0)
	{
		return smethod_22(advTree_0, point_0.X, point_0.Y);
	}

	public static Class23 smethod_22(AdvTree advTree_0, int int_1, int int_2)
	{
		return smethod_23(advTree_0, int_1, int_2, bool_0: false);
	}

	public static Class23 smethod_23(AdvTree advTree_0, int int_1, int int_2, bool bool_0)
	{
		Class23 @class = new Class23();
		if (advTree_0.Nodes.Count != 0 && (((Control)advTree_0).get_DisplayRectangle().Contains(int_1, int_2) || advTree_0.Zoom != 1f))
		{
			Node node = advTree_0.Nodes[0];
			Node node_ = null;
			if (advTree_0.DisplayRootNode != null)
			{
				node = advTree_0.DisplayRootNode;
			}
			Point offset = advTree_0.NodeDisplay_0.Offset;
			if (((Control)advTree_0).get_DisplayRectangle().Contains(int_1, int_2))
			{
				ArrayList paintedNodes = advTree_0.NodeDisplay_0.PaintedNodes;
				foreach (Node item in paintedNodes)
				{
					if (node.IsDisplayed)
					{
						if (NodeDisplay.smethod_0(Enum4.const_5, item, offset).Contains(int_1, int_2))
						{
							@class.node_0 = item;
							return @class;
						}
						if (NodeDisplay.smethod_1(item) && NodeDisplay.smethod_0(Enum4.const_7, item, offset).Contains(int_1, int_2))
						{
							@class.columnHeaderCollection_0 = item.NodesColumns;
							return @class;
						}
					}
				}
			}
			if (bool_0)
			{
				return @class;
			}
			while (node != null)
			{
				Rectangle rectangle = NodeDisplay.smethod_0(Enum4.const_5, node, offset);
				if (!rectangle.Contains(int_1, int_2))
				{
					if (!NodeDisplay.smethod_1(node) || !NodeDisplay.smethod_0(Enum4.const_7, node, offset).Contains(int_1, int_2))
					{
						if (rectangle.Y > int_2)
						{
							break;
						}
						node = (NodeDisplay.smethod_0(Enum4.const_3, node, offset).Contains(int_1, int_2) ? node.NextVisibleNode : smethod_8(node));
						continue;
					}
					@class.columnHeaderCollection_0 = node.NodesColumns;
					return @class;
				}
				node_ = node;
				break;
			}
			@class.node_0 = node_;
			return @class;
		}
		return @class;
	}

	public static Class23 smethod_24(AdvTree advTree_0, int int_1)
	{
		return smethod_25(advTree_0, int_1, bool_0: false);
	}

	public static Class23 smethod_25(AdvTree advTree_0, int int_1, bool bool_0)
	{
		Class23 @class = new Class23();
		if (advTree_0.Nodes.Count != 0 && (((Control)advTree_0).get_DisplayRectangle().Contains(1, int_1) || advTree_0.Zoom != 1f))
		{
			Point offset = advTree_0.NodeDisplay_0.Offset;
			if (((Control)advTree_0).get_DisplayRectangle().Contains(1, int_1))
			{
				ArrayList paintedNodes = advTree_0.NodeDisplay_0.PaintedNodes;
				foreach (Node item in paintedNodes)
				{
					if (!item.IsDisplayed)
					{
						continue;
					}
					Rectangle rectangle = NodeDisplay.smethod_0(Enum4.const_5, item, offset);
					if (int_1 < rectangle.Y || int_1 > rectangle.Bottom)
					{
						if (NodeDisplay.smethod_1(item))
						{
							Rectangle rectangle2 = NodeDisplay.smethod_0(Enum4.const_7, item, offset);
							if (int_1 >= rectangle2.Y && int_1 <= rectangle2.Bottom)
							{
								@class.columnHeaderCollection_0 = item.NodesColumns;
								return @class;
							}
						}
						continue;
					}
					@class.node_0 = item;
					return @class;
				}
			}
			if (bool_0)
			{
				return @class;
			}
			Node node2 = advTree_0.Nodes[0];
			Node node_ = null;
			if (advTree_0.DisplayRootNode != null)
			{
				node2 = advTree_0.DisplayRootNode;
			}
			while (true)
			{
				if (node2 != null)
				{
					Rectangle rectangle3 = NodeDisplay.smethod_0(Enum4.const_5, node2, offset);
					if (int_1 < rectangle3.Y || int_1 > rectangle3.Bottom)
					{
						if (NodeDisplay.smethod_1(node2))
						{
							Rectangle rectangle4 = NodeDisplay.smethod_0(Enum4.const_7, node2, offset);
							if (int_1 >= rectangle4.Y && int_1 <= rectangle4.Bottom)
							{
								break;
							}
						}
						rectangle3 = NodeDisplay.smethod_0(Enum4.const_3, node2, offset);
						node2 = ((int_1 < rectangle3.Y || int_1 > rectangle3.Bottom) ? smethod_8(node2) : node2.NextVisibleNode);
						continue;
					}
					node_ = node2;
				}
				@class.node_0 = node_;
				return @class;
			}
			@class.columnHeaderCollection_0 = node2.NodesColumns;
			return @class;
		}
		return @class;
	}

	public static Class24 smethod_26(AdvTree advTree_0, int int_1, int int_2)
	{
		Class24 @class = new Class24();
		if (advTree_0.Nodes.Count != 0 && (((Control)advTree_0).get_DisplayRectangle().Contains(int_1, int_2) || advTree_0.Zoom != 1f))
		{
			Node node = advTree_0.Nodes[0];
			if (advTree_0.DisplayRootNode != null)
			{
				node = advTree_0.DisplayRootNode;
			}
			if (advTree_0.DisplayRootNode != null)
			{
				node = advTree_0.DisplayRootNode;
			}
			Node node2 = null;
			Rectangle rectangle = Rectangle.Empty;
			while (node != null)
			{
				if (!node.IsDisplayed)
				{
					node = node.NextVisibleNode;
					continue;
				}
				Rectangle rectangle2 = NodeDisplay.smethod_0(Enum4.const_5, node, advTree_0.NodeDisplay_0.Offset);
				if (int_2 < rectangle2.Y || int_2 > rectangle2.Bottom)
				{
					if (node2 == null || int_2 <= rectangle.Bottom || int_2 >= rectangle2.Y)
					{
						node2 = node;
						rectangle = rectangle2;
						node = node.NextVisibleNode;
						continue;
					}
					@class.node_1 = node2;
					break;
				}
				@class.node_1 = node;
				break;
			}
			return @class;
		}
		return null;
	}

	public static int smethod_27(Node node_0)
	{
		int num = 0;
		foreach (Node node in node_0.Nodes)
		{
			if (node.Visible)
			{
				num++;
			}
		}
		return num;
	}

	public static Node smethod_28(Node node_0)
	{
		foreach (Node node in node_0.Nodes)
		{
			if (node.Visible)
			{
				return node;
			}
		}
		return null;
	}

	public static Node smethod_29(Node node_0)
	{
		NodeCollection nodes = node_0.Nodes;
		int num = nodes.Count - 1;
		int num2 = num;
		Node node;
		while (true)
		{
			if (num2 >= 0)
			{
				node = nodes[num2];
				if (node.Visible)
				{
					break;
				}
				num2--;
				continue;
			}
			return null;
		}
		return node;
	}

	public static bool smethod_30(Node node_0, Node node_1)
	{
		while (true)
		{
			if (node_1.Parent != null)
			{
				if (node_1.Parent == node_0)
				{
					break;
				}
				node_1 = node_1.Parent;
				continue;
			}
			return false;
		}
		return true;
	}

	internal static bool smethod_31()
	{
		Color control = SystemColors.Control;
		control.ToArgb();
		control.ToArgb();
		int_0 = control.A;
		color_0 = Color.Black;
		return false;
	}

	public static Node smethod_32(AdvTree advTree_0, string string_0)
	{
		return smethod_33(advTree_0.Nodes, string_0);
	}

	public static Node smethod_33(NodeCollection nodeCollection_0, string string_0)
	{
		foreach (Node item in nodeCollection_0)
		{
			if (!(item.Name == string_0))
			{
				if (item.HasChildNodes)
				{
					Node node2 = smethod_33(item.Nodes, string_0);
					if (node2 != null)
					{
						return node2;
					}
				}
				continue;
			}
			return item;
		}
		return null;
	}

	public static void smethod_34(NodeCollection nodeCollection_0, string string_0, bool bool_0, ArrayList arrayList_0)
	{
		foreach (Node item in nodeCollection_0)
		{
			if (item.Name == string_0)
			{
				arrayList_0.Add(item);
			}
			if (bool_0 && item.HasChildNodes)
			{
				smethod_34(item.Nodes, string_0, bool_0: true, arrayList_0);
			}
		}
	}

	public static Node smethod_35(AdvTree advTree_0, object object_0)
	{
		return smethod_36(advTree_0.Nodes, object_0);
	}

	public static Node smethod_36(NodeCollection nodeCollection_0, object object_0)
	{
		foreach (Node item in nodeCollection_0)
		{
			if (item.DataKey != object_0)
			{
				if (item.HasChildNodes)
				{
					Node node2 = smethod_36(item.Nodes, object_0);
					if (node2 != null)
					{
						return node2;
					}
				}
				continue;
			}
			return item;
		}
		return null;
	}

	public static Node smethod_37(AdvTree advTree_0, int int_1)
	{
		return smethod_38(advTree_0.Nodes, int_1);
	}

	public static Node smethod_38(NodeCollection nodeCollection_0, int int_1)
	{
		foreach (Node item in nodeCollection_0)
		{
			if (item.BindingIndex != int_1)
			{
				if (item.HasChildNodes)
				{
					Node node2 = smethod_38(item.Nodes, int_1);
					if (node2 != null)
					{
						return node2;
					}
				}
				continue;
			}
			return item;
		}
		return null;
	}

	public static Cell smethod_39(Node node_0, int int_1)
	{
		return smethod_41(node_0, int_1, 1);
	}

	public static Cell smethod_40(Node node_0, int int_1)
	{
		return smethod_41(node_0, int_1, -1);
	}

	public static Cell smethod_41(Node node_0, int int_1, int int_2)
	{
		int_1 += int_2;
		if (int_2 > 0)
		{
			_ = node_0.Cells.Count;
		}
		int num = int_1;
		int num2 = 0;
		while (true)
		{
			if (num2 < 2)
			{
				if (num < 0)
				{
					num = node_0.Cells.Count - 1;
					num2++;
				}
				else if (num >= node_0.Cells.Count)
				{
					num = 0;
					num2++;
				}
				if (node_0.Cells[num].IsVisible)
				{
					break;
				}
				num += int_2;
				continue;
			}
			return null;
		}
		return node_0.Cells[num];
	}

	internal static int smethod_42(AdvTree advTree_0, Node node_0)
	{
		if (node_0 == null)
		{
			throw new NullReferenceException("Parameter node cannot be null");
		}
		int num = 0;
		Node node = smethod_16(node_0);
		while (node != null)
		{
			num++;
			node = smethod_16(node);
			if (node != null && node.Parent == null)
			{
				num += advTree_0.Nodes.IndexOf(node) + 1;
				break;
			}
		}
		return num;
	}

	internal static Node smethod_43(AdvTree advTree_0, int int_1)
	{
		if (int_1 != -1 && advTree_0.Nodes.Count != 0)
		{
			Node node = advTree_0.Nodes[0];
			int num = 0;
			while (true)
			{
				if (node != null)
				{
					if (int_1 == num)
					{
						break;
					}
					node = smethod_10(node);
					num++;
					continue;
				}
				return null;
			}
			return node;
		}
		return null;
	}

	internal static Node smethod_44(AdvTree advTree_0, string string_0, Node node_0, bool bool_0)
	{
		node_0 = ((node_0 != null) ? smethod_10(node_0) : smethod_4(advTree_0));
		if (node_0 == null)
		{
			return null;
		}
		Node node = node_0;
		StringComparison comparisonType = (bool_0 ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);
		while (true)
		{
			if (node != null)
			{
				if (node.Text.StartsWith(string_0, comparisonType))
				{
					break;
				}
				node = smethod_10(node);
				continue;
			}
			return null;
		}
		return node;
	}

	internal static ColumnHeader smethod_45(AdvTree advTree_0, Cell cell_0)
	{
		int num = -1;
		if (cell_0.Parent != null)
		{
			num = cell_0.Parent.Cells.IndexOf(cell_0);
		}
		if (cell_0.Parent != null && cell_0.Parent.Parent != null && cell_0.Parent.Parent.NodesColumns.Count > 0 && num < cell_0.Parent.Parent.NodesColumns.Count)
		{
			return cell_0.Parent.Parent.NodesColumns[num];
		}
		if (advTree_0 != null && advTree_0.Columns.Count > 0 && num < advTree_0.Columns.Count)
		{
			return advTree_0.Columns[num];
		}
		return null;
	}
}
