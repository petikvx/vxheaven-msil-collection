using System.Drawing;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Display;

public abstract class NodeExpandDisplay
{
	private TreeColorTable treeColorTable_0;

	public TreeColorTable ColorTable
	{
		get
		{
			return treeColorTable_0;
		}
		set
		{
			treeColorTable_0 = value;
		}
	}

	public NodeExpandDisplay()
	{
	}

	public abstract void DrawExpandButton(NodeExpandPartRendererEventArgs e);

	protected Pen GetBorderPen(NodeExpandPartRendererEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		if (!e.BorderColor.IsEmpty)
		{
			return new Pen(e.BorderColor, 1f);
		}
		if (treeColorTable_0 != null)
		{
			bool expanded = e.Node.Expanded;
			TreeExpandColorTable treeExpandColorTable = method_0(e);
			if (treeExpandColorTable == null)
			{
				return null;
			}
			if (expanded)
			{
				if (!e.IsMouseOver && treeExpandColorTable.CollapseBorder != null)
				{
					return treeExpandColorTable.CollapseBorder.CreatePen();
				}
				if (e.IsMouseOver && treeExpandColorTable.CollapseMouseOverBorder != null)
				{
					return treeExpandColorTable.CollapseMouseOverBorder.CreatePen();
				}
			}
			else
			{
				if (!e.IsMouseOver && treeExpandColorTable.ExpandBorder != null)
				{
					return treeExpandColorTable.ExpandBorder.CreatePen();
				}
				if (e.IsMouseOver && treeExpandColorTable.ExpandMouseOverBorder != null)
				{
					return treeExpandColorTable.ExpandMouseOverBorder.CreatePen();
				}
			}
		}
		return null;
	}

	private TreeExpandColorTable method_0(NodeExpandPartRendererEventArgs nodeExpandPartRendererEventArgs_0)
	{
		TreeExpandColorTable result = null;
		if (nodeExpandPartRendererEventArgs_0.eExpandButtonType_0 == eExpandButtonType.Rectangle)
		{
			result = treeColorTable_0.ExpandRectangle;
		}
		else if (nodeExpandPartRendererEventArgs_0.eExpandButtonType_0 == eExpandButtonType.Triangle)
		{
			result = treeColorTable_0.ExpandTriangle;
		}
		else if (nodeExpandPartRendererEventArgs_0.eExpandButtonType_0 == eExpandButtonType.Ellipse)
		{
			result = treeColorTable_0.ExpandEllipse;
		}
		return result;
	}

	protected Pen GetExpandPen(NodeExpandPartRendererEventArgs e)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		if (e.ExpandLineColor.IsEmpty)
		{
			TreeExpandColorTable treeExpandColorTable = method_0(e);
			if (treeExpandColorTable != null)
			{
				if (e.Node.Expanded)
				{
					if (!e.IsMouseOver && treeExpandColorTable.CollapseForeground != null)
					{
						return treeExpandColorTable.CollapseForeground.CreatePen(1);
					}
					if (e.IsMouseOver && treeExpandColorTable.CollapseMouseOverForeground != null)
					{
						return treeExpandColorTable.CollapseMouseOverForeground.CreatePen(1);
					}
				}
				else
				{
					if (!e.IsMouseOver && treeExpandColorTable.ExpandForeground != null)
					{
						return treeExpandColorTable.ExpandForeground.CreatePen(1);
					}
					if (e.IsMouseOver && treeExpandColorTable.ExpandMouseOverForeground != null)
					{
						return treeExpandColorTable.ExpandMouseOverForeground.CreatePen(1);
					}
				}
			}
			return GetBorderPen(e);
		}
		return new Pen(e.ExpandLineColor, 1f);
	}

	protected Brush GetBackgroundBrush(NodeExpandPartRendererEventArgs e)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		if (e.BackColor.IsEmpty && e.BackColor2.IsEmpty)
		{
			bool expanded = e.Node.Expanded;
			TreeExpandColorTable treeExpandColorTable = method_0(e);
			if (treeExpandColorTable == null)
			{
				return null;
			}
			if (expanded)
			{
				if (!e.IsMouseOver && treeExpandColorTable.CollapseFill != null)
				{
					return treeExpandColorTable.CollapseFill.CreateBrush(e.ExpandPartBounds);
				}
				if (e.IsMouseOver && treeExpandColorTable.CollapseMouseOverFill != null)
				{
					return treeExpandColorTable.CollapseMouseOverFill.CreateBrush(e.ExpandPartBounds);
				}
			}
			else
			{
				if (!e.IsMouseOver && treeExpandColorTable.ExpandFill != null)
				{
					return treeExpandColorTable.ExpandFill.CreateBrush(e.ExpandPartBounds);
				}
				if (e.IsMouseOver && treeExpandColorTable.ExpandMouseOverFill != null)
				{
					return treeExpandColorTable.ExpandMouseOverFill.CreateBrush(e.ExpandPartBounds);
				}
			}
			return null;
		}
		if (e.BackColor2.IsEmpty)
		{
			return (Brush)new SolidBrush(e.BackColor);
		}
		return (Brush)(object)Class50.smethod_0(e.ExpandPartBounds, e.BackColor, e.BackColor2, e.BackColorGradientAngle);
	}
}
