using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.AdvTree.Display;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Layout;

internal class Class18 : Class17
{
	protected override bool ReserveExpandPartSpace => true;

	public Class18(AdvTree treeControl, Rectangle clientArea)
		: base(treeControl, clientArea)
	{
	}

	public override void UpdateTopLevelColumnsWidth()
	{
		if (base.AdvTree_0.Columns.Count > 0)
		{
			Rectangle rectangle_ = Class52.smethod_12(base.AdvTree_0.BackgroundStyle, ((Control)base.AdvTree_0).get_ClientRectangle());
			if (base.AdvTree_0.VScrollBar != null)
			{
				rectangle_.Width -= ((Control)base.AdvTree_0.VScrollBar).get_Width();
			}
			rectangle_.Height = base.AdvTree_0.Columns.Bounds.Height;
			if (base.AdvTree_0.Columns.Bounds.Width < rectangle_.Width)
			{
				base.AdvTree_0.Columns.method_8(rectangle_);
			}
		}
	}

	public override void PerformLayout()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		PrepareStyles();
		Rectangle a = Rectangle.Empty;
		Graphics graphics = GetGraphics();
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		graphics.get_TextRenderingHint();
		if (advTree_0.AntiAlias)
		{
			graphics.set_SmoothingMode((SmoothingMode)4);
		}
		Class20 defaultNodeLayoutContextInfo = GetDefaultNodeLayoutContextInfo(graphics);
		defaultNodeLayoutContextInfo.bool_3 = true;
		defaultNodeLayoutContextInfo.int_0 = base.Rectangle_0.X;
		defaultNodeLayoutContextInfo.int_1 = base.Rectangle_0.Y;
		Class19 cellLayout = GetCellLayout();
		cellLayout.ResetCheckBoxSize();
		if (base.AdvTree_0.CheckBoxImageChecked != null)
		{
			cellLayout.Size_0 = base.AdvTree_0.CheckBoxImageChecked.get_Size();
		}
		if (base.AdvTree_0.Columns.Count > 0)
		{
			Rectangle rectangle = Class52.smethod_12(base.AdvTree_0.BackgroundStyle, ((Control)base.AdvTree_0).get_ClientRectangle());
			if (base.AdvTree_0.VScrollBar != null)
			{
				rectangle.Width -= ((Control)base.AdvTree_0.VScrollBar).get_Width();
			}
			defaultNodeLayoutContextInfo.columnHeaderCollection_0 = base.AdvTree_0.Columns;
			int num = Class21.smethod_0(defaultNodeLayoutContextInfo, 0, 0, rectangle.Width, GetCellLayout().Int32_2);
			num += NodeVerticalSpacing;
			if (base.AdvTree_0.ColumnsVisible)
			{
				Rectangle bounds = defaultNodeLayoutContextInfo.columnHeaderCollection_0.Bounds;
				if (bounds.Width > 0 && bounds.Width < rectangle.Width)
				{
					bounds.Width = rectangle.Width;
					defaultNodeLayoutContextInfo.columnHeaderCollection_0.method_8(bounds);
				}
				defaultNodeLayoutContextInfo.int_1 += num;
				base.AdvTree_0.method_1(bool_25: true);
			}
			else
			{
				base.AdvTree_0.method_1(bool_25: false);
			}
			defaultNodeLayoutContextInfo.columnHeaderCollection_0 = null;
		}
		else
		{
			base.AdvTree_0.method_1(bool_25: false);
		}
		ArrayList arrayList = (defaultNodeLayoutContextInfo.arrayList_0 = GetDefaultColumnInfo());
		try
		{
			Node[] array = method_0();
			Node[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				Node node = (defaultNodeLayoutContextInfo.node_0 = array2[i]);
				method_3(defaultNodeLayoutContextInfo);
				if (node.Visible)
				{
					a = Rectangle.Union(a, node.BoundsRelative);
					if (node.Expanded)
					{
						a = Rectangle.Union(a, node.ChildNodesBounds);
					}
				}
			}
		}
		finally
		{
			if (advTree_0.AntiAlias)
			{
				graphics.set_SmoothingMode(smoothingMode);
			}
			if (base.Boolean_0)
			{
				graphics.Dispose();
			}
		}
		if (defaultNodeLayoutContextInfo.arrayList_2.Count > 0)
		{
			base.AdvTree_0.ArrayList_0 = defaultNodeLayoutContextInfo.arrayList_2;
		}
		else
		{
			base.AdvTree_0.ArrayList_0 = null;
		}
		int_1 = a.Width;
		int_0 = a.Height;
	}

	private void method_3(Class20 class20_0)
	{
		Node node_ = class20_0.node_0;
		if (!node_.Visible)
		{
			return;
		}
		if (node_.SizeChanged || node_.HasColumns)
		{
			LayoutNode(class20_0);
		}
		if (node_.FullRowBackground)
		{
			class20_0.arrayList_2.Add(node_);
		}
		if (node_.BoundsRelative.X != class20_0.int_0 || node_.BoundsRelative.Y != class20_0.int_1)
		{
			node_.SetBounds(new Rectangle(class20_0.int_0, class20_0.int_1, node_.BoundsRelative.Width, node_.BoundsRelative.Height));
		}
		int nodeVerticalSpacing = NodeVerticalSpacing;
		class20_0.int_1 += node_.BoundsRelative.Height + nodeVerticalSpacing;
		if (NodeDisplay.smethod_1(node_))
		{
			class20_0.int_1 += node_.ColumnHeaderHeight;
		}
		if (!node_.Expanded)
		{
			return;
		}
		int num = class20_0.int_0;
		class20_0.int_0 += base.Int32_2;
		ArrayList arrayList_ = class20_0.arrayList_1;
		ArrayList nodeColumnInfo = GetNodeColumnInfo(node_);
		Rectangle childNodesBounds = new Rectangle(class20_0.int_0, class20_0.int_1, 0, 0);
		foreach (Node node in node_.Nodes)
		{
			if (node.Visible)
			{
				class20_0.node_0 = node;
				class20_0.arrayList_1 = nodeColumnInfo;
				method_3(class20_0);
				childNodesBounds.Width = Math.Max(childNodesBounds.Width, Math.Max(node.BoundsRelative.Width, (node.Expanded && node.ChildNodesBounds.Width > 0) ? (node.ChildNodesBounds.Right - childNodesBounds.X) : 0));
				childNodesBounds.Height += node.BoundsRelative.Height + (node.Expanded ? (node.ChildNodesBounds.Height + node.ColumnHeaderHeight) : 0) + nodeVerticalSpacing;
			}
		}
		node_.ChildNodesBounds = childNodesBounds;
		class20_0.arrayList_1 = arrayList_;
		class20_0.node_0 = node_;
		class20_0.int_0 = num;
	}

	private bool method_4(Node node_0)
	{
		return true;
	}
}
