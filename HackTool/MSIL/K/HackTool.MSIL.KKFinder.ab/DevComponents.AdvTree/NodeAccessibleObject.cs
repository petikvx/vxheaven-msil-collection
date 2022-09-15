using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.AdvTree;

public class NodeAccessibleObject : AccessibleObject
{
	private Node node_0;

	internal Node Node_0 => node_0;

	public override string Name
	{
		get
		{
			if (node_0 == null)
			{
				return "";
			}
			if (node_0.AccessibleName != "")
			{
				return node_0.AccessibleName;
			}
			return node_0.Text.Replace("&", "");
		}
		set
		{
			node_0.AccessibleName = value;
		}
	}

	public override string Description
	{
		get
		{
			if (node_0 == null)
			{
				return "";
			}
			if (node_0.AccessibleDescription != "")
			{
				return node_0.AccessibleDescription;
			}
			return ((AccessibleObject)this).get_Name() + " Tree Node";
		}
	}

	public override AccessibleRole Role
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Invalid comparison between Unknown and I4
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			if (node_0 == null || !node_0.IsAccessible)
			{
				return (AccessibleRole)0;
			}
			if ((int)node_0.AccessibleRole != -1)
			{
				return node_0.AccessibleRole;
			}
			return (AccessibleRole)36;
		}
	}

	public override AccessibleStates State
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			if (node_0 == null)
			{
				return (AccessibleStates)1;
			}
			AccessibleStates val = (AccessibleStates)0;
			if (!node_0.IsAccessible)
			{
				return (AccessibleStates)1;
			}
			if (!node_0.Visible)
			{
				return (AccessibleStates)(val | 0x8000);
			}
			if (node_0.IsSelected)
			{
				val = (AccessibleStates)2;
			}
			if (node_0.Expanded)
			{
				return (AccessibleStates)(val | 0x200);
			}
			return (AccessibleStates)(val | 0x400);
		}
	}

	public override AccessibleObject Parent
	{
		get
		{
			if (node_0 == null)
			{
				return null;
			}
			if (node_0.Parent != null)
			{
				return node_0.Parent.AccessibleObject;
			}
			Control treeControl = (Control)(object)node_0.TreeControl;
			if (treeControl != null)
			{
				return treeControl.get_AccessibilityObject();
			}
			return null;
		}
	}

	public override Rectangle Bounds
	{
		get
		{
			if (node_0 == null)
			{
				return Rectangle.Empty;
			}
			Control treeControl = (Control)(object)node_0.TreeControl;
			if (treeControl != null)
			{
				return treeControl.RectangleToScreen(node_0.Bounds);
			}
			return node_0.Bounds;
		}
	}

	public override string DefaultAction
	{
		get
		{
			if (node_0.AccessibleDefaultActionDescription != "")
			{
				return node_0.AccessibleDefaultActionDescription;
			}
			if (node_0.Expanded)
			{
				return "Collapse";
			}
			if (node_0.Nodes.Count <= 0 && node_0.ExpandVisibility != eNodeExpandVisibility.Visible)
			{
				return "Press";
			}
			return "Expand";
		}
	}

	public override string KeyboardShortcut => "";

	public NodeAccessibleObject(Node owner)
	{
		node_0 = owner;
	}

	public override int GetChildCount()
	{
		if (node_0 != null && node_0.HasChildNodes)
		{
			return node_0.Nodes.Count;
		}
		return 0;
	}

	public override AccessibleObject GetChild(int iIndex)
	{
		if (node_0 == null)
		{
			return null;
		}
		return node_0.Nodes[iIndex].AccessibleObject;
	}

	public override void DoDefaultAction()
	{
		if (node_0 != null)
		{
			node_0.Toggle();
			((AccessibleObject)this).DoDefaultAction();
		}
	}

	public override AccessibleObject GetSelected()
	{
		if (node_0 == null)
		{
			return ((AccessibleObject)this).GetSelected();
		}
		if (node_0.IsSelected)
		{
			return node_0.AccessibleObject;
		}
		return ((AccessibleObject)this).GetSelected();
	}

	public override AccessibleObject HitTest(int x, int y)
	{
		if (node_0 == null)
		{
			return ((AccessibleObject)this).HitTest(x, y);
		}
		Point point = new Point(x, y);
		AdvTree treeControl = node_0.TreeControl;
		if (treeControl == null)
		{
			return ((AccessibleObject)this).HitTest(x, y);
		}
		Point p = ((Control)treeControl).PointToClient(point);
		Node nodeAt = treeControl.GetNodeAt(p);
		if (nodeAt != null)
		{
			return nodeAt.AccessibleObject;
		}
		return ((AccessibleObject)this).HitTest(x, y);
	}

	public override AccessibleObject Navigate(AccessibleNavigation navDir)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (node_0 == null)
		{
			return ((AccessibleObject)this).Navigate(navDir);
		}
		Node node = null;
		if ((int)navDir != 2 && (int)navDir != 4 && (int)navDir != 5)
		{
			if ((int)navDir == 7)
			{
				node = method_0(node_0.Nodes, 0);
			}
			else if ((int)navDir == 8)
			{
				node = method_1(node_0.Nodes, node_0.Nodes.Count - 1);
			}
			else if ((int)navDir == 1 || (int)navDir == 3 || (int)navDir == 6)
			{
				node = Class15.smethod_15(node_0);
			}
		}
		else
		{
			node = Class15.smethod_9(node_0);
		}
		if (node != null)
		{
			return node.AccessibleObject;
		}
		return ((AccessibleObject)this).Navigate(navDir);
	}

	private Node method_0(NodeCollection nodeCollection_0, int int_0)
	{
		int count = nodeCollection_0.Count;
		int num = int_0;
		while (true)
		{
			if (num < count)
			{
				if (nodeCollection_0[num].Visible)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return nodeCollection_0[num];
	}

	private Node method_1(NodeCollection nodeCollection_0, int int_0)
	{
		int num = int_0;
		while (true)
		{
			if (num >= 0)
			{
				if (nodeCollection_0[num].Visible)
				{
					break;
				}
				num--;
				continue;
			}
			return null;
		}
		return nodeCollection_0[num];
	}
}
