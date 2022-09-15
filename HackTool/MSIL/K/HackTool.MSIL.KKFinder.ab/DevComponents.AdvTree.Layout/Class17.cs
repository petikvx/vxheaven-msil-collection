using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Layout;

internal abstract class Class17
{
	protected int int_0;

	protected int int_1;

	protected AdvTree advTree_0;

	protected Rectangle rectangle_0;

	protected Size size_0 = new Size(8, 8);

	private int int_2 = 10;

	private int int_3 = 16;

	private LeftRightAlignment leftRightAlignment_0;

	private int int_4 = 3;

	private int int_5;

	private Class19 class19_0;

	private Graphics graphics_0;

	private int int_6 = 24;

	private int int_7 = 16;

	public int Int32_0 => int_1;

	public int Int32_1 => int_0;

	public Rectangle Rectangle_0
	{
		get
		{
			return rectangle_0;
		}
		set
		{
			rectangle_0 = value;
		}
	}

	public Graphics Graphics_0
	{
		get
		{
			return graphics_0;
		}
		set
		{
			graphics_0 = value;
		}
	}

	internal bool Boolean_0 => graphics_0 == null;

	public virtual int NodeVerticalSpacing
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
		}
	}

	public virtual int NodeHorizontalSpacing
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
		}
	}

	public virtual int TreeLayoutChildNodeIndent
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
		}
	}

	public virtual int ExpandAreaWidth
	{
		get
		{
			return int_6;
		}
		set
		{
			int_6 = value;
		}
	}

	public virtual int CommandAreaWidth
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	public Size Size_0
	{
		get
		{
			return size_0;
		}
		set
		{
			size_0 = value;
		}
	}

	protected virtual bool RootHasExpandedPart => true;

	protected virtual bool ReserveExpandPartSpace => false;

	public AdvTree AdvTree_0 => advTree_0;

	internal int Int32_2
	{
		get
		{
			return int_7;
		}
		set
		{
			int_7 = value;
		}
	}

	public virtual LeftRightAlignment LeftRight
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return leftRightAlignment_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			leftRightAlignment_0 = value;
		}
	}

	public Class17(AdvTree treeControl, Rectangle clientArea)
	{
		advTree_0 = treeControl;
		rectangle_0 = clientArea;
	}

	public virtual void PerformLayout()
	{
	}

	public virtual void UpdateTopLevelColumnsWidth()
	{
	}

	public virtual void PerformSingleNodeLayout(Node node)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		if (node == null)
		{
			return;
		}
		PrepareStyles();
		Graphics graphics = GetGraphics();
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		graphics.get_TextRenderingHint();
		if (advTree_0.AntiAlias)
		{
			graphics.set_SmoothingMode((SmoothingMode)4);
		}
		try
		{
			Class20 defaultNodeLayoutContextInfo = GetDefaultNodeLayoutContextInfo(graphics);
			defaultNodeLayoutContextInfo.node_0 = node;
			LayoutNode(defaultNodeLayoutContextInfo);
		}
		finally
		{
			if (advTree_0.AntiAlias)
			{
				graphics.set_SmoothingMode(smoothingMode);
			}
			graphics.Dispose();
		}
	}

	protected virtual Graphics GetGraphics()
	{
		if (graphics_0 != null)
		{
			return graphics_0;
		}
		return advTree_0.CreateGraphics();
	}

	protected virtual void PrepareStyles()
	{
		foreach (ElementStyle style in advTree_0.Styles)
		{
			if (style.Boolean_0)
			{
				Class52.smethod_0(style, ((Control)advTree_0).get_Font());
			}
		}
	}

	protected virtual ArrayList GetDefaultColumnInfo()
	{
		ArrayList arrayList = new ArrayList();
		ColumnHeaderCollection columns = advTree_0.Columns;
		if (columns != null)
		{
			foreach (ColumnHeader item in columns)
			{
				arrayList.Add(new Class14(item.Bounds.Width, item.Visible, item));
			}
			return arrayList;
		}
		return arrayList;
	}

	protected virtual ArrayList GetNodeColumnInfo(Node node)
	{
		if (!node.HasColumns)
		{
			return null;
		}
		ArrayList arrayList = new ArrayList();
		ColumnHeaderCollection nodesColumns = node.NodesColumns;
		foreach (ColumnHeader item in nodesColumns)
		{
			arrayList.Add(new Class14(item.Bounds.Width, item.Visible, item));
		}
		return arrayList;
	}

	public virtual ColumnHeaderCollection GetColumnHeader(string name)
	{
		if (!(name == "") && name != null)
		{
			return advTree_0.HeadersCollection_0.GetByName(name).Columns;
		}
		return null;
	}

	protected virtual void LayoutCommandPart(Class20 layoutInfo, ElementStyle nodeStyle)
	{
		Rectangle commandBoundsRelative = new Rectangle(layoutInfo.node_0.ContentBounds.Right - CommandAreaWidth - Class52.smethod_11(nodeStyle, eSpacePart.Border, eStyleSide.Right), layoutInfo.node_0.ContentBounds.Y + Class52.smethod_11(nodeStyle, eSpacePart.Border, eStyleSide.Top), CommandAreaWidth, layoutInfo.node_0.ContentBounds.Height - Class52.smethod_11(nodeStyle, eSpacePart.Border, eStyleSide.Top) - Class52.smethod_11(nodeStyle, eSpacePart.Border, eStyleSide.Bottom));
		layoutInfo.node_0.CommandBoundsRelative = commandBoundsRelative;
	}

	protected virtual void LayoutExpandPart(Class20 layoutInfo, bool bLeftNode, int x)
	{
		Node node_ = layoutInfo.node_0;
		Size expandPartSize = GetExpandPartSize();
		Rectangle expandPartRectangle = new Rectangle(x, 0, expandPartSize.Width, expandPartSize.Height);
		expandPartRectangle.Y = (node_.BoundsRelative.Height - expandPartRectangle.Height) / 2;
		if (!bLeftNode && (!layoutInfo.bool_3 || !layoutInfo.bool_0))
		{
			expandPartRectangle.X = node_.BoundsRelative.Right - ExpandAreaWidth + (ExpandAreaWidth - expandPartSize.Width) / 2;
		}
		else
		{
			expandPartRectangle.X += (ExpandAreaWidth - expandPartRectangle.Width) / 2;
		}
		node_.SetExpandPartRectangle(expandPartRectangle);
	}

	protected virtual Size GetExpandPartSize()
	{
		return size_0;
	}

	protected virtual void LayoutNode(Class20 layoutInfo)
	{
		bool flag = HasExpandPart(layoutInfo);
		bool flag2 = HasCommandPart(layoutInfo);
		Node node_ = layoutInfo.node_0;
		Rectangle bounds = new Rectangle(layoutInfo.int_0, layoutInfo.int_1, 0, 0);
		Rectangle empty = Rectangle.Empty;
		int num = 0;
		int num2 = 0;
		bool flag3;
		if (((flag3 = layoutInfo.bool_2 && layoutInfo.bool_0) && flag) || ReserveExpandPartSpace)
		{
			num2 += ExpandAreaWidth + GetCellLayout().Int32_4;
		}
		int num3 = num2;
		int num4 = 0;
		ElementStyle elementStyle = null;
		elementStyle = ((node_.Expanded && node_.StyleExpanded != null) ? node_.StyleExpanded : ((node_.Style == null) ? layoutInfo.elementStyle_1 : node_.Style));
		empty.X = num3;
		if (elementStyle != null)
		{
			num3 += Class52.smethod_3(elementStyle);
			num4 += Class52.smethod_7(elementStyle);
			empty.X += elementStyle.MarginLeft;
			empty.Y += elementStyle.MarginTop;
		}
		Size size = GetCellLayout().method_6(layoutInfo, num3, num4);
		node_.SetCellsBounds(new Rectangle(num3, num4, size.Width, size.Height));
		num = size.Height;
		num2 += size.Width;
		empty.Width = size.Width;
		empty.Height = size.Height;
		if (elementStyle != null)
		{
			empty.Width += Class52.smethod_11(elementStyle, eSpacePart.Padding | eSpacePart.Border, eStyleSide.Left) + Class52.smethod_11(elementStyle, eSpacePart.Padding | eSpacePart.Border, eStyleSide.Right);
			empty.Height += Class52.smethod_11(elementStyle, eSpacePart.Padding | eSpacePart.Border, eStyleSide.Top) + Class52.smethod_11(elementStyle, eSpacePart.Padding | eSpacePart.Border, eStyleSide.Bottom);
			num2 += Class52.smethod_1(elementStyle);
			num += Class52.smethod_2(elementStyle);
		}
		if (!flag3 && flag && !ReserveExpandPartSpace)
		{
			num2 += ExpandAreaWidth;
		}
		if (flag2)
		{
			num2 += CommandAreaWidth;
			empty.Width += CommandAreaWidth;
		}
		bounds.Height = num;
		bounds.Width = num2;
		node_.SetBounds(bounds);
		node_.SetContentBounds(empty);
		if (flag2)
		{
			LayoutCommandPart(layoutInfo, elementStyle);
		}
		else
		{
			node_.CommandBoundsRelative = Rectangle.Empty;
		}
		if (!flag && !ReserveExpandPartSpace)
		{
			node_.SetExpandPartRectangle(Rectangle.Empty);
		}
		else
		{
			LayoutExpandPart(layoutInfo, flag3, 0);
		}
		node_.SizeChanged = false;
		method_2(layoutInfo);
	}

	protected virtual bool HasExpandPart(Class20 layoutInfo)
	{
		Node node_ = layoutInfo.node_0;
		if (node_.ExpandVisibility == eNodeExpandVisibility.Auto)
		{
			if ((method_1(node_) && !RootHasExpandedPart) || !Class15.smethod_20(node_))
			{
				return false;
			}
			return true;
		}
		return node_.ExpandVisibility == eNodeExpandVisibility.Visible;
	}

	protected virtual bool HasCommandPart(Class20 layoutInfo)
	{
		return layoutInfo.node_0.CommandButton;
	}

	protected virtual Class19 GetCellLayout()
	{
		if (class19_0 == null)
		{
			class19_0 = new Class19();
		}
		return class19_0;
	}

	protected virtual void OffsetNodeLocation(Node node, int x, int y)
	{
		node.SetBounds(new Rectangle(node.BoundsRelative.X + x, node.BoundsRelative.Y + y, node.BoundsRelative.Width, node.BoundsRelative.Height));
		if (node.Expanded)
		{
			node.ChildNodesBounds = new Rectangle(node.ChildNodesBounds.X + x, node.ChildNodesBounds.Y + y, node.ChildNodesBounds.Width, node.ChildNodesBounds.Height);
		}
	}

	protected virtual Class20 GetDefaultNodeLayoutContextInfo(Graphics graphics)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		Class20 @class = new Class20();
		@class.rectangle_0 = rectangle_0;
		@class.arrayList_0 = GetDefaultColumnInfo();
		@class.arrayList_1 = null;
		@class.int_0 = 0;
		@class.int_1 = 0;
		@class.font_0 = ((Control)advTree_0).get_Font();
		@class.bool_0 = (int)LeftRight == 0;
		@class.graphics_0 = graphics;
		@class.elementStyleCollection_0 = advTree_0.Styles;
		@class.arrayList_2 = new ArrayList();
		if (advTree_0.CellLayout != 0)
		{
			@class.eCellLayout_0 = advTree_0.CellLayout;
		}
		if (advTree_0.CellPartLayout != 0)
		{
			@class.eCellPartLayout_0 = advTree_0.CellPartLayout;
		}
		if (advTree_0.NodeStyle != null)
		{
			@class.elementStyle_1 = advTree_0.NodeStyle;
		}
		if (advTree_0.CellStyleDefault != null)
		{
			@class.elementStyle_0 = advTree_0.CellStyleDefault;
		}
		else
		{
			@class.elementStyle_0 = ElementStyle.GetDefaultCellStyle(@class.elementStyle_1);
		}
		if (advTree_0.ColumnStyleNormal != null)
		{
			Class52.smethod_0(advTree_0.ColumnStyleNormal, @class.font_0);
			@class.size_0 = advTree_0.ColumnStyleNormal.Size;
		}
		if (@class.size_0.IsEmpty)
		{
			@class.size_0.Height = @class.font_0.get_Height() + 4;
		}
		return @class;
	}

	protected Node[] method_0()
	{
		if (advTree_0.DisplayRootNode != null)
		{
			return new Node[1] { advTree_0.DisplayRootNode };
		}
		Node[] array = new Node[advTree_0.Nodes.Count];
		advTree_0.Nodes.method_1(array);
		return array;
	}

	protected bool method_1(Node node_0)
	{
		return Class15.smethod_17(advTree_0, node_0);
	}

	protected virtual void EmptyBoundsUnusedNodes(Node[] topLevelNodes)
	{
		if (advTree_0.DisplayRootNode != null)
		{
			Node prevVisibleNode;
			for (prevVisibleNode = advTree_0.DisplayRootNode.PrevVisibleNode; prevVisibleNode != null; prevVisibleNode = prevVisibleNode.PrevVisibleNode)
			{
				prevVisibleNode.SetBounds(Rectangle.Empty);
			}
			prevVisibleNode = advTree_0.DisplayRootNode.NextNode;
			if (prevVisibleNode == null)
			{
				prevVisibleNode = advTree_0.DisplayRootNode.Parent;
				while (prevVisibleNode != null)
				{
					if (prevVisibleNode.NextNode == null)
					{
						prevVisibleNode = prevVisibleNode.Parent;
						continue;
					}
					prevVisibleNode = prevVisibleNode.NextNode;
					break;
				}
			}
			while (prevVisibleNode != null)
			{
				prevVisibleNode.SetBounds(Rectangle.Empty);
				prevVisibleNode = prevVisibleNode.NextVisibleNode;
			}
		}
		else
		{
			for (int i = 1; i < topLevelNodes.Length; i++)
			{
				topLevelNodes[i].SetBounds(Rectangle.Empty);
			}
		}
	}

	public void method_2(Class20 class20_0)
	{
		Node node_ = class20_0.node_0;
		if (node_.HasColumns && node_.Expanded)
		{
			int num = 2;
			int num2 = class20_0.int_0 + Int32_2;
			int num3 = class20_0.node_0.BoundsRelative.Bottom + 2;
			bool flag = class20_0.bool_2 && class20_0.bool_0;
			int expandAreaWidth = ExpandAreaWidth;
			int int32_ = GetCellLayout().Int32_4;
			if (!flag)
			{
				num2 += expandAreaWidth + int32_;
			}
			int num4 = class20_0.rectangle_0.Width - (class20_0.int_0 + expandAreaWidth);
			if (num4 <= 0)
			{
				num4 = class20_0.rectangle_0.Width;
			}
			node_.ColumnHeaderHeight = Class21.smethod_0(class20_0, num2, num3, num4, GetCellLayout().Int32_2) + num;
			if (!node_.NodesColumnsHeaderVisible)
			{
				node_.ColumnHeaderHeight = 0;
			}
		}
		else
		{
			node_.ColumnHeaderHeight = 0;
		}
	}
}
