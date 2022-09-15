using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.AdvTree.Display;

public class NodeTreeDisplay : NodeDisplay
{
	private class Class10
	{
		public Graphics graphics_0;

		public Font font_0;

		public Rectangle rectangle_0 = Rectangle.Empty;

		public Point point_0 = Point.Empty;

		public ElementStyle elementStyle_0;

		public ElementStyle elementStyle_1;

		public ElementStyle elementStyle_2;

		public ElementStyle elementStyle_3;

		public ElementStyle elementStyle_4;

		public ElementStyle elementStyle_5;

		public ElementStyle elementStyle_6;

		public ElementStyle elementStyle_7;

		public ElementStyle elementStyle_8;

		public ElementStyleCollection elementStyleCollection_0;

		public ConnectorRendererEventArgs connectorRendererEventArgs_0;

		public NodeExpandPartRendererEventArgs nodeExpandPartRendererEventArgs_0;

		public SelectionRendererEventArgs selectionRendererEventArgs_0;

		public bool bool_0;

		public TreeRenderer treeRenderer_0;

		public NodeRendererEventArgs nodeRendererEventArgs_0;

		public bool bool_1;

		public Rectangle rectangle_1 = Rectangle.Empty;

		public ColorScheme colorScheme_0;

		public bool bool_2;

		public Color color_0 = Color.Empty;

		public bool bool_3;
	}

	private ElementStyleDisplayInfo elementStyleDisplayInfo_0 = new ElementStyleDisplayInfo();

	private NodeCellRendererEventArgs nodeCellRendererEventArgs_0 = new NodeCellRendererEventArgs();

	private NodeSystemRenderer nodeSystemRenderer_0 = new NodeSystemRenderer();

	public NodeSystemRenderer SystemRenderer
	{
		get
		{
			return nodeSystemRenderer_0;
		}
		set
		{
			nodeSystemRenderer_0 = value;
		}
	}

	public bool IsBackgroundSelection => Tree.SelectionBoxStyle != eSelectionStyle.NodeMarker;

	public NodeTreeDisplay(AdvTree tree)
		: base(tree)
	{
		nodeSystemRenderer_0.ColorTable = new TreeColorTable();
		Class5.smethod_0(nodeSystemRenderer_0.ColorTable, new ColorFactory());
	}

	public TreeRenderer GetTreeRenderer()
	{
		TreeRenderer treeRenderer_ = nodeSystemRenderer_0;
		if (Tree.TreeRenderer_0 != null && Tree.ENodeRenderMode_0 == eNodeRenderMode.Custom)
		{
			treeRenderer_ = Tree.TreeRenderer_0;
		}
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			treeRenderer_.Office2007ColorTable_0 = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
			treeRenderer_.ColorTable = treeRenderer_.Office2007ColorTable_0.AdvTree;
		}
		return treeRenderer_;
	}

	private Class10 method_0(Graphics graphics_0, Rectangle rectangle_0)
	{
		Class10 @class = new Class10();
		@class.graphics_0 = graphics_0;
		@class.font_0 = ((Control)Tree).get_Font();
		@class.rectangle_0 = rectangle_0;
		@class.point_0 = Offset;
		@class.elementStyleCollection_0 = Tree.Styles;
		@class.bool_1 = IsBackgroundSelection;
		@class.rectangle_1 = Class52.smethod_12(Tree.BackgroundStyle, ((Control)Tree).get_ClientRectangle());
		@class.colorScheme_0 = Tree.ColorScheme_0;
		@class.bool_2 = Tree.GridRowLines;
		@class.color_0 = Tree.GridLinesColor;
		@class.bool_3 = Tree.SelectionPerCell;
		@class.treeRenderer_0 = nodeSystemRenderer_0;
		if (Tree.TreeRenderer_0 != null && Tree.ENodeRenderMode_0 == eNodeRenderMode.Custom)
		{
			@class.treeRenderer_0 = Tree.TreeRenderer_0;
		}
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			@class.treeRenderer_0.Office2007ColorTable_0 = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
			@class.treeRenderer_0.ColorTable = @class.treeRenderer_0.Office2007ColorTable_0.AdvTree;
		}
		@class.nodeRendererEventArgs_0 = new NodeRendererEventArgs();
		if (Tree.NodeStyle != null)
		{
			@class.elementStyle_0 = Tree.NodeStyle;
		}
		else
		{
			@class.elementStyle_0 = GetDefaultNodeStyle();
		}
		if (Tree.NodeStyleExpanded != null)
		{
			@class.elementStyle_1 = Tree.NodeStyleExpanded;
		}
		if (Tree.NodeStyleSelected != null)
		{
			@class.elementStyle_2 = Tree.NodeStyleSelected;
		}
		if (Tree.NodeStyleMouseOver != null)
		{
			@class.elementStyle_3 = Tree.NodeStyleMouseOver;
		}
		if (Tree.CellStyleDefault != null)
		{
			@class.elementStyle_4 = Tree.CellStyleDefault;
		}
		if (Tree.CellStyleDisabled != null)
		{
			@class.elementStyle_8 = Tree.CellStyleDisabled;
		}
		else
		{
			@class.elementStyle_8 = ElementStyle.GetDefaultDisabledCellStyle();
		}
		if (Tree.CellStyleMouseDown != null)
		{
			@class.elementStyle_5 = Tree.CellStyleMouseDown;
		}
		if (Tree.CellStyleMouseOver != null)
		{
			@class.elementStyle_6 = Tree.CellStyleMouseOver;
		}
		if (Tree.CellStyleSelected != null)
		{
			@class.elementStyle_7 = Tree.CellStyleSelected;
		}
		else
		{
			@class.elementStyle_7 = ElementStyle.GetDefaultSelectedCellStyle();
		}
		@class.connectorRendererEventArgs_0 = new ConnectorRendererEventArgs();
		@class.connectorRendererEventArgs_0.Graphics = @class.graphics_0;
		@class.nodeExpandPartRendererEventArgs_0 = new NodeExpandPartRendererEventArgs(@class.graphics_0);
		@class.nodeExpandPartRendererEventArgs_0.BackColor = Tree.method_10(Tree.ExpandBackColor, Tree.ExpandBackColorSchemePart);
		@class.nodeExpandPartRendererEventArgs_0.BackColor2 = Tree.method_10(Tree.ExpandBackColor2, Tree.ExpandBackColor2SchemePart);
		@class.nodeExpandPartRendererEventArgs_0.BackColorGradientAngle = Tree.ExpandBackColorGradientAngle;
		@class.nodeExpandPartRendererEventArgs_0.BorderColor = Tree.method_10(Tree.ExpandBorderColor, Tree.ExpandBorderColorSchemePart);
		@class.nodeExpandPartRendererEventArgs_0.ExpandLineColor = Tree.method_10(Tree.ExpandLineColor, Tree.ExpandLineColorSchemePart);
		@class.nodeExpandPartRendererEventArgs_0.Graphics = @class.graphics_0;
		@class.nodeExpandPartRendererEventArgs_0.eExpandButtonType_0 = Tree.ExpandButtonType;
		@class.nodeExpandPartRendererEventArgs_0.ExpandImage = Tree.ExpandImage;
		@class.nodeExpandPartRendererEventArgs_0.ExpandImageCollapse = Tree.ExpandImageCollapse;
		@class.selectionRendererEventArgs_0 = new SelectionRendererEventArgs();
		@class.selectionRendererEventArgs_0.Graphics = @class.graphics_0;
		@class.selectionRendererEventArgs_0.SelectionBoxStyle = Tree.SelectionBoxStyle;
		@class.selectionRendererEventArgs_0.TreeActive = ((Control)Tree).get_Focused() || !Tree.SelectionFocusAware;
		return @class;
	}

	public override void Paint(Graphics g, Rectangle clipRectangle)
	{
		base.Paint(g, clipRectangle);
		nodeCellRendererEventArgs_0.image_0 = Tree.CheckBoxImageChecked;
		nodeCellRendererEventArgs_0.image_1 = Tree.CheckBoxImageUnChecked;
		nodeCellRendererEventArgs_0.image_2 = Tree.CheckBoxImageIndeterminate;
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			nodeSystemRenderer_0.Office2007ColorTable_0 = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
		}
		Class10 @class = method_0(g, clipRectangle);
		if (Tree.NodeConnector_0 != null && Tree.SelectedNode != null)
		{
			for (Node node = Tree.SelectedNode; node != null; node = node.Parent)
			{
				node.SelectedConnectorMarker = true;
			}
		}
		if (Tree.GridColumnLines && Tree.Columns.Count > 0)
		{
			method_1(@class);
		}
		if (Tree.ArrayList_0 != null && Tree.ArrayList_0.Count > 0)
		{
			method_3(@class, Tree.ArrayList_0);
		}
		if (@class.bool_1)
		{
			method_5(@class);
		}
		if (Tree.HotTracking)
		{
			method_7(@class);
		}
		Rectangle clientRectangle = ((Control)Tree).get_ClientRectangle();
		if (clientRectangle == clipRectangle)
		{
			arrayList_0.Clear();
		}
		if (Tree.DisplayRootNode != null)
		{
			method_9(Tree.DisplayRootNode, @class);
		}
		else
		{
			method_8(Tree.Nodes, @class);
		}
		Node node2 = Tree.method_79();
		if (node2 != null && node2.Parent == null)
		{
			Point point = @class.point_0;
			@class.point_0 = Point.Empty;
			method_9(node2, @class);
			@class.point_0 = point;
		}
		if (Tree.IsDragDropInProgress)
		{
			method_4(@class, Tree.method_71(Tree.method_80()));
		}
		if (!@class.bool_1)
		{
			method_5(@class);
		}
	}

	public void ExternalPaintNode(Node node, Graphics g, Rectangle bounds)
	{
		nodeCellRendererEventArgs_0.image_0 = Tree.CheckBoxImageChecked;
		nodeCellRendererEventArgs_0.image_1 = Tree.CheckBoxImageUnChecked;
		nodeCellRendererEventArgs_0.image_2 = Tree.CheckBoxImageIndeterminate;
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			nodeSystemRenderer_0.Office2007ColorTable_0 = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
		}
		Class10 @class = method_0(g, bounds);
		@class.nodeExpandPartRendererEventArgs_0 = null;
		@class.connectorRendererEventArgs_0 = null;
		@class.point_0 = new Point(bounds.X - node.BoundsRelative.X, bounds.Y - node.BoundsRelative.Y);
		method_11(node, @class);
	}

	private void method_1(Class10 class10_0)
	{
		method_2(class10_0, Tree.Columns, class10_0.rectangle_1);
	}

	private void method_2(Class10 class10_0, ColumnHeaderCollection columnHeaderCollection_0, Rectangle rectangle_0)
	{
		Color color_ = (Tree.GridLinesColor.IsEmpty ? class10_0.treeRenderer_0.ColorTable.GridLines : Tree.GridLinesColor);
		Graphics graphics_ = class10_0.graphics_0;
		foreach (ColumnHeader item in columnHeaderCollection_0)
		{
			if (item.Visible && item.Bounds.Width > 0)
			{
				Rectangle bounds = item.Bounds;
				bounds.Offset(class10_0.point_0);
				if (columnHeaderCollection_0.ParentNode == null)
				{
					bounds.Offset(rectangle_0.Location);
				}
				Class50.smethod_32(graphics_, bounds.Right - ((!item.bool_6) ? 1 : 0), rectangle_0.Y, bounds.Right - ((!item.bool_6) ? 1 : 0), rectangle_0.Bottom, color_, 1);
			}
		}
	}

	private void method_3(Class10 class10_0, ArrayList arrayList_1)
	{
		foreach (Node item in arrayList_1)
		{
			Rectangle nodeBounds = NodeDisplay.smethod_0(Enum4.const_0, item, class10_0.point_0);
			if (!nodeBounds.IsEmpty)
			{
				nodeBounds.X = class10_0.rectangle_1.X;
				nodeBounds.Width = class10_0.rectangle_1.Width;
			}
			if (nodeBounds.IsEmpty || (!nodeBounds.IntersectsWith(class10_0.rectangle_0) && !class10_0.rectangle_0.IsEmpty))
			{
				continue;
			}
			ElementStyle elementStyle = method_10(item, class10_0);
			if (elementStyle != null)
			{
				TreeRenderer treeRenderer = class10_0.treeRenderer_0;
				if (item.NodeRenderer != null && item.RenderMode == eNodeRenderMode.Custom)
				{
					treeRenderer = item.NodeRenderer;
				}
				if (elementStyle != null)
				{
					class10_0.nodeRendererEventArgs_0.Graphics = class10_0.graphics_0;
					class10_0.nodeRendererEventArgs_0.Node = item;
					class10_0.nodeRendererEventArgs_0.NodeBounds = nodeBounds;
					class10_0.nodeRendererEventArgs_0.Style = elementStyle;
					treeRenderer.DrawNodeBackground(class10_0.nodeRendererEventArgs_0);
				}
			}
		}
	}

	private void method_4(Class10 class10_0, Rectangle rectangle_0)
	{
		if (!rectangle_0.IsEmpty)
		{
			class10_0.treeRenderer_0.DrawDragDropMarker(new DragDropMarkerRendererEventArgs(class10_0.graphics_0, rectangle_0));
		}
	}

	private void method_5(Class10 class10_0)
	{
		if (!Tree.MultiSelect && Tree.SelectedNode != null && Tree.SelectedNode.Visible && Tree.SelectionBox && (!Tree.HideSelection || ((Control)Tree).get_Focused()))
		{
			method_6(Tree.SelectedNode, class10_0);
		}
		else
		{
			if (!Tree.MultiSelect || Tree.SelectedNodes.Count <= 0 || !Tree.SelectionBox || (Tree.HideSelection && !((Control)Tree).get_Focused()))
			{
				return;
			}
			foreach (Node selectedNode in Tree.SelectedNodes)
			{
				if (selectedNode.IsVisible)
				{
					method_6(selectedNode, class10_0);
				}
			}
		}
	}

	private void method_6(Node node_0, Class10 class10_0)
	{
		class10_0.selectionRendererEventArgs_0.Node = node_0;
		Rectangle bounds;
		if (Tree.SelectionBoxStyle == eSelectionStyle.FullRowSelect)
		{
			if (class10_0.bool_3)
			{
				Cell cell_ = ((class10_0.selectionRendererEventArgs_0.Node.SelectedCell != null) ? class10_0.selectionRendererEventArgs_0.Node.SelectedCell : class10_0.selectionRendererEventArgs_0.Node.Cells[0]);
				bounds = NodeDisplay.smethod_2(Enum5.const_3, cell_, class10_0.point_0);
			}
			else
			{
				bounds = NodeDisplay.smethod_0(Enum4.const_0, class10_0.selectionRendererEventArgs_0.Node, class10_0.point_0);
				bounds.X = class10_0.rectangle_1.X;
				bounds.Width = class10_0.rectangle_1.Width;
			}
			bounds.Inflate(0, (int)Math.Ceiling((float)Tree.NodeSpacing / 2f));
		}
		else if (Tree.SelectionBoxStyle == eSelectionStyle.HighlightCells)
		{
			if (class10_0.bool_3)
			{
				Cell cell_2 = ((class10_0.selectionRendererEventArgs_0.Node.SelectedCell != null) ? class10_0.selectionRendererEventArgs_0.Node.SelectedCell : class10_0.selectionRendererEventArgs_0.Node.Cells[0]);
				bounds = NodeDisplay.smethod_2(Enum5.const_3, cell_2, class10_0.point_0);
			}
			else
			{
				bounds = NodeDisplay.smethod_0(Enum4.const_4, class10_0.selectionRendererEventArgs_0.Node, class10_0.point_0);
			}
			bounds.Inflate(2, 2);
			if (bounds.Right > class10_0.rectangle_1.Right)
			{
				bounds.Width -= bounds.Right - class10_0.rectangle_1.Right;
			}
		}
		else if (class10_0.bool_3)
		{
			Cell cell_3 = ((class10_0.selectionRendererEventArgs_0.Node.SelectedCell != null) ? class10_0.selectionRendererEventArgs_0.Node.SelectedCell : class10_0.selectionRendererEventArgs_0.Node.Cells[0]);
			bounds = NodeDisplay.smethod_2(Enum5.const_3, cell_3, class10_0.point_0);
		}
		else
		{
			bounds = NodeDisplay.smethod_0(Enum4.const_0, class10_0.selectionRendererEventArgs_0.Node, class10_0.point_0);
		}
		class10_0.selectionRendererEventArgs_0.Bounds = bounds;
		class10_0.treeRenderer_0.DrawSelection(class10_0.selectionRendererEventArgs_0);
	}

	private void method_7(Class10 class10_0)
	{
		Node mouseOverNode = Tree.MouseOverNode;
		if (mouseOverNode != null && !mouseOverNode.IsSelected && mouseOverNode.Selectable)
		{
			Rectangle bounds = NodeDisplay.smethod_0(Enum4.const_4, mouseOverNode, class10_0.point_0);
			bounds.Inflate(2, 2);
			class10_0.selectionRendererEventArgs_0.Node = mouseOverNode;
			class10_0.selectionRendererEventArgs_0.Bounds = bounds;
			class10_0.treeRenderer_0.DrawHotTracking(class10_0.selectionRendererEventArgs_0);
		}
	}

	private Node method_8(NodeCollection nodeCollection_0, Class10 class10_0)
	{
		Node result = null;
		foreach (Node item in nodeCollection_0)
		{
			if (method_9(item, class10_0))
			{
				result = item;
				if (NodeDisplay.smethod_0(Enum4.const_0, item, class10_0.point_0).Y > class10_0.rectangle_0.Bottom && !class10_0.rectangle_1.IsEmpty)
				{
					return result;
				}
			}
		}
		return result;
	}

	private bool method_9(Node node_0, Class10 class10_0)
	{
		if (!node_0.Visible)
		{
			node_0.SelectedConnectorMarker = false;
			return false;
		}
		Rectangle rectangle = NodeDisplay.smethod_0(Enum4.const_0, node_0, class10_0.point_0);
		if (rectangle.IsEmpty)
		{
			node_0.SelectedConnectorMarker = false;
			return false;
		}
		if (class10_0.bool_2 && !node_0.IsDragNode)
		{
			Class50.smethod_32(class10_0.graphics_0, class10_0.rectangle_1.X, rectangle.Bottom + 1, class10_0.rectangle_1.Right, rectangle.Bottom + 1, class10_0.color_0, 1);
		}
		bool flag = node_0.Expanded && node_0.Nodes.Count > 0;
		if (!node_0.IsDragNode && (node_0.Parent != null || node_0.ExpandVisibility != eNodeExpandVisibility.Hidden))
		{
			method_12(null, node_0, class10_0, bool_0: false);
		}
		if (flag)
		{
			Node node = Class15.smethod_29(node_0);
			if (node != null)
			{
				method_12(node_0, node, class10_0, bool_0: false);
			}
		}
		node_0.SelectedConnectorMarker = false;
		if (NodeDisplay.smethod_1(node_0))
		{
			rectangle.Height += node_0.ColumnHeaderHeight;
			rectangle.Width = Math.Max(rectangle.Width, node_0.NodesColumns.Bounds.Width);
		}
		if (rectangle.IntersectsWith(class10_0.rectangle_0) || class10_0.rectangle_0.IsEmpty)
		{
			method_11(node_0, class10_0);
		}
		if (flag)
		{
			method_8(node_0.Nodes, class10_0);
		}
		return true;
	}

	private ElementStyle method_10(Node node_0, Class10 class10_0)
	{
		ElementStyle elementStyle = class10_0.elementStyle_0.Copy();
		bool flag = true;
		if (node_0.IsSelected && class10_0.elementStyle_2 == null && node_0.StyleSelected == null && !node_0.FullRowBackground)
		{
			flag = false;
		}
		if (node_0.Style != null)
		{
			if (flag)
			{
				elementStyle.ApplyStyle(node_0.Style);
			}
			else
			{
				elementStyle.ApplyFontStyle(node_0.Style);
			}
		}
		if (flag && node_0.MouseOverNodePart == Enum1.const_1 && elementStyle != null)
		{
			ElementStyle elementStyle2 = class10_0.elementStyle_3;
			if (node_0.StyleMouseOver != null)
			{
				elementStyle2 = node_0.StyleMouseOver;
				flag = false;
			}
			if (elementStyle2 != null)
			{
				elementStyle.ApplyStyle(elementStyle2);
				flag = false;
			}
		}
		if (flag && node_0.Expanded && elementStyle != null)
		{
			ElementStyle elementStyle3 = class10_0.elementStyle_1;
			if (node_0.StyleExpanded != null)
			{
				elementStyle3 = node_0.StyleExpanded;
			}
			if (elementStyle3 != null)
			{
				elementStyle.ApplyStyle(elementStyle3);
			}
		}
		if (flag && node_0.IsSelected && elementStyle != null)
		{
			ElementStyle elementStyle4 = class10_0.elementStyle_2;
			if (node_0.StyleSelected != null)
			{
				elementStyle4 = node_0.StyleSelected;
			}
			if (elementStyle4 != null)
			{
				elementStyle.ApplyStyle(elementStyle4);
			}
		}
		if (elementStyle != null && elementStyle.Font == null)
		{
			elementStyle.Font = class10_0.font_0;
		}
		return elementStyle;
	}

	private void method_11(Node node_0, Class10 class10_0)
	{
		arrayList_0.Add(node_0);
		Rectangle rectangle = NodeDisplay.smethod_0(Enum4.const_0, node_0, class10_0.point_0);
		TreeRenderer treeRenderer = class10_0.treeRenderer_0;
		if (node_0.NodeRenderer != null && node_0.RenderMode == eNodeRenderMode.Custom)
		{
			treeRenderer = node_0.NodeRenderer;
		}
		ElementStyle elementStyle = method_10(node_0, class10_0);
		Region val = null;
		if (elementStyle != null)
		{
			class10_0.nodeRendererEventArgs_0.Graphics = class10_0.graphics_0;
			class10_0.nodeRendererEventArgs_0.Node = node_0;
			class10_0.nodeRendererEventArgs_0.NodeBounds = rectangle;
			class10_0.nodeRendererEventArgs_0.Style = elementStyle;
			if (!node_0.FullRowBackground)
			{
				treeRenderer.DrawNodeBackground(class10_0.nodeRendererEventArgs_0);
			}
			ElementStyleDisplayInfo elementStyleDisplayInfo = new ElementStyleDisplayInfo(elementStyle, class10_0.graphics_0, class10_0.nodeRendererEventArgs_0.NodeBounds);
			elementStyleDisplayInfo.Bounds.Inflate(1, 1);
			val = ElementStyleDisplay.GetStyleRegion(elementStyleDisplayInfo);
			elementStyleDisplayInfo.Bounds = rectangle;
		}
		if (NodeDisplay.smethod_3(node_0) && class10_0.nodeExpandPartRendererEventArgs_0 != null)
		{
			rectangle = NodeDisplay.smethod_0(Enum4.const_1, node_0, class10_0.point_0);
			class10_0.nodeExpandPartRendererEventArgs_0.Node = node_0;
			class10_0.nodeExpandPartRendererEventArgs_0.ExpandPartBounds = rectangle;
			class10_0.nodeExpandPartRendererEventArgs_0.IsMouseOver = node_0.MouseOverNodePart == Enum1.const_2;
			treeRenderer.DrawNodeExpandPart(class10_0.nodeExpandPartRendererEventArgs_0);
		}
		if (NodeDisplay.smethod_1(node_0))
		{
			vmethod_0(node_0.NodesColumns, class10_0.graphics_0, bool_0: false);
		}
		Region val2 = null;
		if (val != null)
		{
			val2 = class10_0.graphics_0.get_Clip();
			class10_0.graphics_0.SetClip(val, (CombineMode)1);
		}
		ElementStyle elementStyle2 = null;
		if (class10_0.elementStyle_4 == null)
		{
			elementStyle2 = new ElementStyle();
			elementStyle2.TextColor = elementStyle.TextColor;
			elementStyle2.TextShadowColor = elementStyle.TextShadowColor;
			elementStyle2.TextShadowOffset = elementStyle.TextShadowOffset;
			elementStyle2.TextAlignment = elementStyle.TextAlignment;
			elementStyle2.TextLineAlignment = elementStyle.TextLineAlignment;
			elementStyle2.WordWrap = elementStyle.WordWrap;
			elementStyle2.Font = elementStyle.Font;
		}
		foreach (Cell cell in node_0.Cells)
		{
			if (!cell.IsVisible)
			{
				continue;
			}
			if (cell.StyleNormal == null)
			{
				elementStyle = ((class10_0.elementStyle_4 != null) ? class10_0.elementStyle_4.Copy() : ((!cell.Enabled || (cell.IsMouseDown && (cell.StyleMouseDown != null || class10_0.elementStyle_5 != null)) || (cell.IsSelected && (cell.StyleSelected != null || class10_0.elementStyle_7 != null)) || (cell.IsMouseOver && (cell.StyleMouseOver != null || class10_0.elementStyle_6 != null))) ? elementStyle2.Copy() : elementStyle2));
			}
			else
			{
				elementStyle = ((class10_0.elementStyle_4 == null) ? elementStyle2.Copy() : class10_0.elementStyle_4.Copy());
				elementStyle.ApplyStyle(cell.StyleNormal);
			}
			if (!cell.Enabled && cell.StyleDisabled != null)
			{
				elementStyle.ApplyStyle(cell.StyleDisabled);
			}
			else if (!cell.Enabled && class10_0.elementStyle_8 != null)
			{
				elementStyle.ApplyStyle(class10_0.elementStyle_8);
			}
			else if (cell.IsMouseDown && cell.StyleMouseDown != null)
			{
				elementStyle.ApplyStyle(cell.StyleMouseDown);
			}
			else if (cell.IsMouseDown && class10_0.elementStyle_5 != null)
			{
				elementStyle.ApplyStyle(class10_0.elementStyle_5);
			}
			else
			{
				if (cell.IsSelected && cell.StyleSelected != null)
				{
					elementStyle.ApplyStyle(cell.StyleSelected);
				}
				else if (cell.IsSelected && class10_0.elementStyle_7 != null && class10_0.elementStyle_7.Custom)
				{
					elementStyle.ApplyStyle(class10_0.elementStyle_7);
				}
				if (cell.IsMouseOver && cell.StyleMouseOver != null)
				{
					elementStyle.ApplyStyle(cell.StyleMouseOver);
				}
				else if (cell.IsMouseOver && class10_0.elementStyle_6 != null)
				{
					elementStyle.ApplyStyle(class10_0.elementStyle_6);
				}
			}
			rectangle = NodeDisplay.smethod_0(Enum4.const_5, node_0, class10_0.point_0);
			if (elementStyle != null)
			{
				if (elementStyle.Font == null)
				{
					elementStyle.Font = class10_0.font_0;
				}
				Rectangle boundsRelative = cell.BoundsRelative;
				Rectangle textContentBounds = cell.TextContentBounds;
				boundsRelative.Offset(rectangle.Location);
				textContentBounds.Offset(rectangle.Location);
				ElementStyleDisplayInfo e = method_15(elementStyle, class10_0.graphics_0, boundsRelative);
				ElementStyleDisplay.Paint(e);
				NodeCellRendererEventArgs nodeCellRendererEventArgs = method_16(elementStyle, class10_0.graphics_0, cell, rectangle.Location, class10_0.colorScheme_0);
				if (nodeCellRendererEventArgs.Cell.CheckBoxVisible)
				{
					treeRenderer.DrawCellCheckBox(nodeCellRendererEventArgs);
				}
				if (!nodeCellRendererEventArgs.Cell.Images.Size_0.IsEmpty)
				{
					treeRenderer.DrawCellImage(nodeCellRendererEventArgs);
				}
				treeRenderer.DrawCellText(nodeCellRendererEventArgs);
			}
		}
		if (val != null)
		{
			class10_0.graphics_0.SetClip(val2, (CombineMode)0);
		}
	}

	private void method_12(Node node_0, Node node_1, Class10 class10_0, bool bool_0)
	{
		method_13(node_0, node_1, class10_0, bool_0, null);
	}

	private void method_13(Node node_0, Node node_1, Class10 class10_0, bool bool_0, ConnectorPointsCollection connectorPointsCollection_0)
	{
		bool isRootNode;
		if ((!(isRootNode = ((node_0 != null) ? IsRootNode(node_0) : IsRootNode(node_1))) || node_0 != null || node_1.Nodes.Count != 0 || node_1.ExpandVisibility == eNodeExpandVisibility.Visible) && class10_0.connectorRendererEventArgs_0 != null)
		{
			class10_0.connectorRendererEventArgs_0.FromNode = node_0;
			class10_0.connectorRendererEventArgs_0.ToNode = node_1;
			class10_0.connectorRendererEventArgs_0.IsRootNode = isRootNode;
			class10_0.connectorRendererEventArgs_0.LinkConnector = bool_0;
			if (node_0 != null && node_0.Style != null)
			{
				class10_0.connectorRendererEventArgs_0.StyleFromNode = node_0.Style;
			}
			else
			{
				class10_0.connectorRendererEventArgs_0.StyleFromNode = class10_0.elementStyle_0;
			}
			if (node_1.Style != null)
			{
				class10_0.connectorRendererEventArgs_0.StyleToNode = node_1.Style;
			}
			else
			{
				class10_0.connectorRendererEventArgs_0.StyleToNode = class10_0.elementStyle_0;
			}
			class10_0.connectorRendererEventArgs_0.Offset = class10_0.point_0;
			if (node_1.SelectedConnectorMarker)
			{
				class10_0.connectorRendererEventArgs_0.NodeConnector = Tree.NodeConnector_0;
			}
			else if (node_1.ParentConnector != null)
			{
				class10_0.connectorRendererEventArgs_0.NodeConnector = node_1.ParentConnector;
			}
			else
			{
				class10_0.connectorRendererEventArgs_0.NodeConnector = Tree.NodesConnector;
			}
			if (bool_0)
			{
				class10_0.connectorRendererEventArgs_0.ConnectorPoints = connectorPointsCollection_0;
			}
			else if (connectorPointsCollection_0 != null)
			{
				class10_0.connectorRendererEventArgs_0.ConnectorPoints = connectorPointsCollection_0;
			}
			else
			{
				class10_0.connectorRendererEventArgs_0.ConnectorPoints = null;
			}
			class10_0.treeRenderer_0.DrawConnector(class10_0.connectorRendererEventArgs_0);
		}
	}

	private void method_14(Node node_0, Class10 class10_0)
	{
		method_12(node_0.Parent, node_0, class10_0, bool_0: false);
	}

	private ElementStyleDisplayInfo method_15(ElementStyle elementStyle_0, Graphics graphics_0, Rectangle rectangle_0)
	{
		elementStyleDisplayInfo_0.Style = elementStyle_0;
		elementStyleDisplayInfo_0.Graphics = graphics_0;
		elementStyleDisplayInfo_0.Bounds = rectangle_0;
		return elementStyleDisplayInfo_0;
	}

	private NodeCellRendererEventArgs method_16(ElementStyle elementStyle_0, Graphics graphics_0, Cell cell_0, Point point_2, ColorScheme colorScheme_0)
	{
		nodeCellRendererEventArgs_0.Cell = cell_0;
		nodeCellRendererEventArgs_0.Graphics = graphics_0;
		nodeCellRendererEventArgs_0.Style = elementStyle_0;
		nodeCellRendererEventArgs_0.point_0 = point_2;
		nodeCellRendererEventArgs_0.colorScheme_0 = colorScheme_0;
		return nodeCellRendererEventArgs_0;
	}

	internal override void vmethod_0(ColumnHeaderCollection columnHeaderCollection_0, Graphics graphics_0, bool bool_0)
	{
		TreeRenderer treeRenderer_ = nodeSystemRenderer_0;
		if (Tree.TreeRenderer_0 != null && Tree.ENodeRenderMode_0 == eNodeRenderMode.Custom)
		{
			treeRenderer_ = Tree.TreeRenderer_0;
		}
		method_17(treeRenderer_, columnHeaderCollection_0, graphics_0, bool_0);
	}

	internal void method_17(TreeRenderer treeRenderer_0, ColumnHeaderCollection columnHeaderCollection_0, Graphics graphics_0, bool bool_0)
	{
		ColumnHeaderRendererEventArgs columnHeaderRendererEventArgs = new ColumnHeaderRendererEventArgs();
		columnHeaderRendererEventArgs.Graphics = graphics_0;
		columnHeaderRendererEventArgs.Tree = Tree;
		ElementStyle elementStyle = method_20(treeRenderer_0);
		ElementStyle elementStyle2 = null;
		elementStyle2 = ((!bool_0) ? ((Tree.NodesColumnsBackgroundStyle == null) ? method_19(treeRenderer_0) : Tree.NodesColumnsBackgroundStyle) : ((Tree.ColumnsBackgroundStyle == null) ? method_18(treeRenderer_0) : Tree.ColumnsBackgroundStyle));
		if (Tree.ColumnStyleNormal != null && Tree.ColumnStyleNormal.Custom)
		{
			elementStyle = Tree.ColumnStyleNormal;
		}
		Point pos = Point.Empty;
		if (Tree.AutoScroll)
		{
			pos = Tree.method_18();
			if (bool_0)
			{
				pos.Y = 0;
			}
		}
		Rectangle bounds = columnHeaderCollection_0.Bounds;
		if (!bool_0)
		{
			bounds.Offset(pos);
		}
		ElementStyleDisplayInfo e = new ElementStyleDisplayInfo(elementStyle2, graphics_0, bounds);
		ElementStyleDisplay.Paint(e);
		Color color_ = ((elementStyle2 == null || elementStyle2.BorderColor.IsEmpty) ? Color.Empty : elementStyle2.BorderColor);
		foreach (ColumnHeader item in columnHeaderCollection_0)
		{
			if (!item.Visible)
			{
				continue;
			}
			ElementStyle elementStyle3 = null;
			elementStyle3 = ((!(item.StyleNormal != "")) ? elementStyle.Copy() : Tree.Styles[item.StyleNormal].Copy());
			if (item.IsMouseDown)
			{
				if (item.StyleMouseDown != "")
				{
					elementStyle3.ApplyStyle(Tree.Styles[item.StyleMouseDown]);
				}
				else if (Tree.ColumnStyleMouseDown != null)
				{
					elementStyle3.ApplyStyle(Tree.ColumnStyleMouseDown);
				}
			}
			else if (item.IsMouseOver)
			{
				if (item.StyleMouseOver != "")
				{
					elementStyle3.ApplyStyle(Tree.Styles[item.StyleMouseOver]);
				}
				else if (Tree.ColumnStyleMouseOver != null)
				{
					elementStyle3.ApplyStyle(Tree.ColumnStyleMouseOver);
				}
			}
			columnHeaderRendererEventArgs.ColumnHeader = item;
			Rectangle bounds2 = item.Bounds;
			bounds2.Offset(pos);
			columnHeaderRendererEventArgs.Bounds = bounds2;
			columnHeaderRendererEventArgs.Style = elementStyle3;
			treeRenderer_0.DrawColumnHeader(columnHeaderRendererEventArgs);
			if (!color_.IsEmpty)
			{
				Class50.smethod_32(graphics_0, bounds2.Right - ((!item.bool_6) ? 1 : 0), bounds2.Y, bounds2.Right - ((!item.bool_6) ? 1 : 0), bounds2.Bottom - 1, color_, 1);
			}
		}
	}

	private ElementStyle method_18(TreeRenderer treeRenderer_0)
	{
		if (treeRenderer_0 != null && treeRenderer_0.Office2007ColorTable_0 != null)
		{
			return treeRenderer_0.Office2007ColorTable_0.StyleClasses[ElementStyleClassKeys.TreeColumnsHeaderKey] as ElementStyle;
		}
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.BackColor = ColorScheme.GetColor(16383229);
		elementStyle.BackColor2 = ColorScheme.GetColor(13884393);
		elementStyle.BackColorGradientAngle = 90;
		elementStyle.TextColor = ColorScheme.GetColor(0);
		elementStyle.BorderColor = ColorScheme.GetColor(10401486);
		elementStyle.BorderBottom = eStyleBorderType.Solid;
		elementStyle.BorderBottomWidth = 1;
		return elementStyle;
	}

	private ElementStyle method_19(TreeRenderer treeRenderer_0)
	{
		if (treeRenderer_0 != null && treeRenderer_0.Office2007ColorTable_0 != null)
		{
			return treeRenderer_0.Office2007ColorTable_0.StyleClasses[ElementStyleClassKeys.TreeNodesColumnsHeaderKey] as ElementStyle;
		}
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.BackColor = ColorScheme.GetColor(16383229);
		elementStyle.BackColor2 = ColorScheme.GetColor(13884393);
		elementStyle.BackColorGradientAngle = 90;
		elementStyle.TextColor = ColorScheme.GetColor(0);
		elementStyle.BorderColor = ColorScheme.GetColor(10401486);
		elementStyle.BorderBottom = eStyleBorderType.Solid;
		elementStyle.BorderBottomWidth = 1;
		elementStyle.BorderLeft = eStyleBorderType.Solid;
		elementStyle.BorderLeftWidth = 1;
		elementStyle.BorderTop = eStyleBorderType.Solid;
		elementStyle.BorderTopWidth = 1;
		return elementStyle;
	}

	private ElementStyle method_20(TreeRenderer treeRenderer_0)
	{
		if (treeRenderer_0 != null && treeRenderer_0.Office2007ColorTable_0 != null)
		{
			return treeRenderer_0.Office2007ColorTable_0.StyleClasses[ElementStyleClassKeys.TreeColumnKey] as ElementStyle;
		}
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.TextColor = ColorScheme.GetColor(0);
		return elementStyle;
	}
}
