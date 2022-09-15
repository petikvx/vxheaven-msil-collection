using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Display;

public class NodeDisplay
{
	private Point point_0 = Point.Empty;

	private Point point_1 = Point.Empty;

	private AdvTree advTree_0;

	internal ArrayList arrayList_0 = new ArrayList(100);

	public virtual Point Offset
	{
		get
		{
			if (!point_1.IsEmpty)
			{
				return point_1;
			}
			Node node = advTree_0.method_78();
			if (node == null)
			{
				return Point.Empty;
			}
			advTree_0.GetScreenSize(new Size(advTree_0.Class17_0.Int32_0, advTree_0.Class17_0.Int32_1));
			return advTree_0.GetLayoutPosition(point_0);
		}
		set
		{
			point_0 = value;
		}
	}

	public bool LockOffset
	{
		get
		{
			return !point_1.IsEmpty;
		}
		set
		{
			if (value)
			{
				point_1 = Offset;
			}
			else
			{
				point_1 = Point.Empty;
			}
		}
	}

	public virtual Point DefaultOffset
	{
		get
		{
			Node node = advTree_0.method_78();
			if (node == null)
			{
				return Point.Empty;
			}
			return ((Control)advTree_0).get_ClientRectangle().Location;
		}
	}

	protected virtual AdvTree Tree
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

	public ArrayList PaintedNodes => arrayList_0;

	public NodeDisplay(AdvTree tree)
	{
		advTree_0 = tree;
	}

	public virtual void Paint(Graphics g, Rectangle clipRectangle)
	{
	}

	public void SetLockedOffset(Point p)
	{
		point_1 = p;
	}

	public Point GetLockedOffset()
	{
		return point_1;
	}

	internal static Rectangle smethod_0(Enum4 enum4_0, Node node_0, Point point_2)
	{
		Rectangle result = Rectangle.Empty;
		switch (enum4_0)
		{
		case Enum4.const_4:
			result = node_0.CellsBoundsRelative;
			if (!result.IsEmpty)
			{
				result.Offset(point_2);
				result.Offset(node_0.BoundsRelative.Location);
			}
			break;
		case Enum4.const_2:
		{
			Rectangle rectangle = smethod_0(Enum4.const_5, node_0, point_2);
			result = node_0.ExpandPartRectangleRelative;
			if (!result.IsEmpty)
			{
				result.Offset(point_2);
				result.Offset(node_0.BoundsRelative.Location);
			}
			result.Y = rectangle.Y;
			result.Height = rectangle.Height;
			result.Inflate(1, 0);
			break;
		}
		case Enum4.const_1:
			result = node_0.ExpandPartRectangleRelative;
			if (!result.IsEmpty)
			{
				result.Offset(point_2);
				result.Offset(node_0.BoundsRelative.Location);
			}
			break;
		case Enum4.const_6:
			result = node_0.CommandBoundsRelative;
			if (!result.IsEmpty)
			{
				result.Offset(point_2);
				result.Offset(node_0.BoundsRelative.Location);
			}
			break;
		case Enum4.const_0:
			result = node_0.ContentBounds;
			if (!result.IsEmpty)
			{
				result.Offset(point_2);
				result.Offset(node_0.BoundsRelative.Location);
			}
			break;
		case Enum4.const_5:
			result = node_0.BoundsRelative;
			if (!result.IsEmpty)
			{
				result.Offset(point_2);
			}
			break;
		case Enum4.const_3:
			result = node_0.ChildNodesBounds;
			if (!result.IsEmpty)
			{
				result.Offset(point_2);
			}
			break;
		case Enum4.const_7:
			if (smethod_1(node_0))
			{
				result = node_0.NodesColumns.Bounds;
				if (!result.IsEmpty)
				{
					result.Offset(point_2);
				}
			}
			break;
		}
		return result;
	}

	internal static bool smethod_1(Node node_0)
	{
		if (node_0.Expanded && node_0.HasColumns)
		{
			return node_0.NodesColumnsHeaderVisible;
		}
		return false;
	}

	internal static Rectangle smethod_2(Enum5 enum5_0, Cell cell_0, Point point_2)
	{
		Rectangle result = Rectangle.Empty;
		if (cell_0.Parent == null)
		{
			return result;
		}
		switch (enum5_0)
		{
		case Enum5.const_0:
			result = cell_0.CheckBoxBoundsRelative;
			if (!result.IsEmpty)
			{
				result.Offset(point_2);
				result.Offset(cell_0.Parent.BoundsRelative.Location);
			}
			break;
		case Enum5.const_1:
			result = cell_0.ImageBoundsRelative;
			if (!result.IsEmpty)
			{
				result.Offset(point_2);
				result.Offset(cell_0.Parent.BoundsRelative.Location);
			}
			break;
		case Enum5.const_2:
			result = cell_0.TextContentBounds;
			if (!result.IsEmpty)
			{
				result.Offset(point_2);
				result.Offset(cell_0.Parent.BoundsRelative.Location);
			}
			break;
		case Enum5.const_3:
			result = cell_0.BoundsRelative;
			if (!result.IsEmpty)
			{
				result.Offset(point_2);
				result.Offset(cell_0.Parent.BoundsRelative.Location);
			}
			break;
		}
		return result;
	}

	internal static bool smethod_3(Node node_0)
	{
		if ((node_0.Nodes.Count > 0 && node_0.ExpandVisibility != eNodeExpandVisibility.Hidden) || node_0.ExpandVisibility == eNodeExpandVisibility.Visible)
		{
			return true;
		}
		return false;
	}

	protected NodeExpandDisplay GetExpandDisplay(eExpandButtonType e)
	{
		NodeExpandDisplay result = null;
		switch (e)
		{
		case eExpandButtonType.Ellipse:
			result = new NodeExpandEllipseDisplay();
			break;
		case eExpandButtonType.Rectangle:
			result = new NodeExpandRectDisplay();
			break;
		case eExpandButtonType.Image:
			result = new NodeExpandImageDisplay();
			break;
		case eExpandButtonType.Triangle:
			result = new Class9();
			break;
		}
		return result;
	}

	protected bool IsRootNode(Node node)
	{
		return Class15.smethod_17(advTree_0, node);
	}

	protected ElementStyle GetDefaultNodeStyle()
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.TextColorSchemePart = eColorSchemePart.ItemText;
		return elementStyle;
	}

	public void MoveHostedControls()
	{
		Point offset = Offset;
		float zoom = Tree.Zoom;
		foreach (Cell item in Tree.ArrayList_1)
		{
			Rectangle r = smethod_2(Enum5.const_2, item, offset);
			Rectangle screenRectangle = Tree.GetScreenRectangle(r);
			if (!r.IsEmpty && item.HostedControl.get_Bounds() != screenRectangle)
			{
				if (zoom != 1f)
				{
					item.HostedControlSize = r.Size;
					item.IgnoreHostedControlSizeChange = true;
				}
				else
				{
					item.HostedControlSize = Size.Empty;
				}
				item.HostedControl.set_Bounds(screenRectangle);
				if (zoom != 1f)
				{
					item.IgnoreHostedControlSizeChange = false;
				}
				bool visible;
				if (item.Parent != null && (visible = Class15.smethod_11(item.Parent)) != item.HostedControl.get_Visible())
				{
					item.HostedControl.set_Visible(visible);
				}
			}
		}
	}

	internal virtual void vmethod_0(ColumnHeaderCollection columnHeaderCollection_0, Graphics graphics_0, bool bool_0)
	{
	}
}
