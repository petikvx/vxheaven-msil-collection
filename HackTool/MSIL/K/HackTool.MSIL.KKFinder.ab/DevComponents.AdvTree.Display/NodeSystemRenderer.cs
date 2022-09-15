using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.AdvTree.Display;

public class NodeSystemRenderer : TreeRenderer
{
	private NodeExpandEllipseDisplay nodeExpandEllipseDisplay_0 = new NodeExpandEllipseDisplay();

	private NodeExpandRectDisplay nodeExpandRectDisplay_0 = new NodeExpandRectDisplay();

	private Class9 class9_0 = new Class9();

	private NodeExpandImageDisplay nodeExpandImageDisplay_0 = new NodeExpandImageDisplay();

	private ElementStyleDisplayInfo elementStyleDisplayInfo_0 = new ElementStyleDisplayInfo();

	private Class8 class8_0 = new Class8();

	private LineConnectorDisplay lineConnectorDisplay_0;

	private Class11 class11_0 = new Class11();

	private Class12 class12_0 = new Class12();

	private Class229 class229_0 = new Class229();

	protected ElementStyleDisplayInfo GetElementStyleDisplayInfo(ElementStyle style, Graphics g, Rectangle bounds)
	{
		elementStyleDisplayInfo_0.Style = style;
		elementStyleDisplayInfo_0.Graphics = g;
		elementStyleDisplayInfo_0.Bounds = bounds;
		return elementStyleDisplayInfo_0;
	}

	private NodeConnectorDisplay method_0(NodeConnector nodeConnector_0)
	{
		NodeConnectorDisplay result = null;
		if (nodeConnector_0 == null)
		{
			return null;
		}
		if (nodeConnector_0.ConnectorType == eNodeConnectorType.Line)
		{
			if (lineConnectorDisplay_0 == null)
			{
				lineConnectorDisplay_0 = new LineConnectorDisplay();
			}
			result = lineConnectorDisplay_0;
		}
		return result;
	}

	public override void DrawNodeBackground(NodeRendererEventArgs e)
	{
		ElementStyleDisplayInfo elementStyleDisplayInfo = GetElementStyleDisplayInfo(e.Style, e.Graphics, e.NodeBounds);
		ElementStyleDisplay.Paint(elementStyleDisplayInfo);
		base.DrawNodeBackground(e);
	}

	public override void DrawNodeExpandPart(NodeExpandPartRendererEventArgs e)
	{
		NodeExpandDisplay nodeExpandDisplay = method_1(e.eExpandButtonType_0);
		nodeExpandDisplay.ColorTable = base.ColorTable;
		nodeExpandDisplay.DrawExpandButton(e);
		nodeExpandDisplay.ColorTable = null;
		base.DrawNodeExpandPart(e);
	}

	private NodeExpandDisplay method_1(eExpandButtonType eExpandButtonType_0)
	{
		NodeExpandDisplay result = null;
		switch (eExpandButtonType_0)
		{
		case eExpandButtonType.Ellipse:
			result = nodeExpandEllipseDisplay_0;
			break;
		case eExpandButtonType.Rectangle:
			result = nodeExpandRectDisplay_0;
			break;
		case eExpandButtonType.Image:
			result = nodeExpandImageDisplay_0;
			break;
		case eExpandButtonType.Triangle:
			result = class9_0;
			break;
		}
		return result;
	}

	public override void DrawCellBackground(NodeCellRendererEventArgs e)
	{
		ElementStyleDisplayInfo elementStyleDisplayInfo = GetElementStyleDisplayInfo(e.Style, e.Graphics, Class50.smethod_3(e.CellBounds));
		ElementStyleDisplay.Paint(elementStyleDisplayInfo);
		base.DrawCellBackground(e);
	}

	public override void DrawCellCheckBox(NodeCellRendererEventArgs e)
	{
		Class13.Class229_0 = class229_0;
		if (base.Office2007ColorTable_0 != null)
		{
			Class13.office2007CheckBoxColorTable_0 = base.Office2007ColorTable_0.CheckBoxItem;
		}
		Class13.smethod_1(e);
		base.DrawCellCheckBox(e);
		Class13.Class229_0 = null;
	}

	public override void DrawCellImage(NodeCellRendererEventArgs e)
	{
		Class13.smethod_3(e);
		base.DrawCellImage(e);
	}

	public override void DrawCellText(NodeCellRendererEventArgs e)
	{
		Class13.smethod_4(e);
		base.DrawCellText(e);
	}

	public override void DrawSelection(SelectionRendererEventArgs e)
	{
		class8_0.TreeSelectionColors_0 = base.ColorTable.Selection;
		class8_0.method_0(e);
		base.DrawSelection(e);
	}

	public override void DrawHotTracking(SelectionRendererEventArgs e)
	{
		class8_0.TreeSelectionColors_0 = base.ColorTable.Selection;
		class8_0.method_1(e);
		base.DrawHotTracking(e);
	}

	public override void DrawConnector(ConnectorRendererEventArgs e)
	{
		method_0(e.NodeConnector)?.DrawConnector(e);
		base.DrawConnector(e);
	}

	public override void DrawTreeBackground(TreeBackgroundRendererEventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		AdvTree advTree = e.AdvTree;
		Graphics graphics = e.Graphics;
		if (!((Control)advTree).get_BackColor().IsEmpty)
		{
			SolidBrush val = new SolidBrush(((Control)advTree).get_BackColor());
			try
			{
				graphics.FillRectangle((Brush)(object)val, ((Control)advTree).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		ElementStyleDisplayInfo elementStyleDisplayInfo = new ElementStyleDisplayInfo();
		elementStyleDisplayInfo.Bounds = ((Control)advTree).get_DisplayRectangle();
		elementStyleDisplayInfo.Graphics = graphics;
		elementStyleDisplayInfo.Style = advTree.BackgroundStyle;
		ElementStyleDisplay.Paint(elementStyleDisplayInfo);
		base.DrawTreeBackground(e);
	}

	public override void DrawDragDropMarker(DragDropMarkerRendererEventArgs e)
	{
		class11_0.Color_0 = base.ColorTable.DragDropMarker;
		class11_0.method_0(e);
		base.DrawDragDropMarker(e);
	}

	public override void DrawColumnHeader(ColumnHeaderRendererEventArgs e)
	{
		ElementStyleDisplayInfo elementStyleDisplayInfo = GetElementStyleDisplayInfo(e.Style, e.Graphics, e.Bounds);
		class12_0.method_0(e, elementStyleDisplayInfo);
		base.DrawColumnHeader(e);
	}
}
