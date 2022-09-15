using System;
using System.Runtime.CompilerServices;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.AdvTree.Display;

public abstract class TreeRenderer
{
	private NodeRendererEventHandler nodeRendererEventHandler_0;

	private NodeExpandPartRendererEventHandler nodeExpandPartRendererEventHandler_0;

	private NodeCellRendererEventHandler nodeCellRendererEventHandler_0;

	private NodeCellRendererEventHandler nodeCellRendererEventHandler_1;

	private NodeCellRendererEventHandler nodeCellRendererEventHandler_2;

	private NodeCellRendererEventHandler nodeCellRendererEventHandler_3;

	private SelectionRendererEventHandler selectionRendererEventHandler_0;

	private SelectionRendererEventHandler selectionRendererEventHandler_1;

	private ConnectorRendererEventHandler connectorRendererEventHandler_0;

	private TreeBackgroundRendererEventHandler treeBackgroundRendererEventHandler_0;

	private DragDropMarkerRendererEventHandler dragDropMarkerRendererEventHandler_0;

	private ColumnHeaderRendererEventHandler columnHeaderRendererEventHandler_0;

	private TreeColorTable treeColorTable_0;

	private Office2007ColorTable office2007ColorTable_0;

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

	internal Office2007ColorTable Office2007ColorTable_0
	{
		get
		{
			return office2007ColorTable_0;
		}
		set
		{
			office2007ColorTable_0 = value;
		}
	}

	public event NodeRendererEventHandler RenderNodeBackground
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			nodeRendererEventHandler_0 = (NodeRendererEventHandler)Delegate.Combine(nodeRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			nodeRendererEventHandler_0 = (NodeRendererEventHandler)Delegate.Remove(nodeRendererEventHandler_0, value);
		}
	}

	public event NodeExpandPartRendererEventHandler RenderNodeExpandPart
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			nodeExpandPartRendererEventHandler_0 = (NodeExpandPartRendererEventHandler)Delegate.Combine(nodeExpandPartRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			nodeExpandPartRendererEventHandler_0 = (NodeExpandPartRendererEventHandler)Delegate.Remove(nodeExpandPartRendererEventHandler_0, value);
		}
	}

	public event NodeCellRendererEventHandler RenderCellBackground
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			nodeCellRendererEventHandler_0 = (NodeCellRendererEventHandler)Delegate.Combine(nodeCellRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			nodeCellRendererEventHandler_0 = (NodeCellRendererEventHandler)Delegate.Remove(nodeCellRendererEventHandler_0, value);
		}
	}

	public event NodeCellRendererEventHandler RenderCellCheckBox
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			nodeCellRendererEventHandler_1 = (NodeCellRendererEventHandler)Delegate.Combine(nodeCellRendererEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			nodeCellRendererEventHandler_1 = (NodeCellRendererEventHandler)Delegate.Remove(nodeCellRendererEventHandler_1, value);
		}
	}

	public event NodeCellRendererEventHandler RenderCellImage
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			nodeCellRendererEventHandler_2 = (NodeCellRendererEventHandler)Delegate.Combine(nodeCellRendererEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			nodeCellRendererEventHandler_2 = (NodeCellRendererEventHandler)Delegate.Remove(nodeCellRendererEventHandler_2, value);
		}
	}

	public event NodeCellRendererEventHandler RenderCellText
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			nodeCellRendererEventHandler_3 = (NodeCellRendererEventHandler)Delegate.Combine(nodeCellRendererEventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			nodeCellRendererEventHandler_3 = (NodeCellRendererEventHandler)Delegate.Remove(nodeCellRendererEventHandler_3, value);
		}
	}

	public event SelectionRendererEventHandler RenderSelection
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			selectionRendererEventHandler_0 = (SelectionRendererEventHandler)Delegate.Combine(selectionRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			selectionRendererEventHandler_0 = (SelectionRendererEventHandler)Delegate.Remove(selectionRendererEventHandler_0, value);
		}
	}

	public event SelectionRendererEventHandler RenderHotTracking
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			selectionRendererEventHandler_1 = (SelectionRendererEventHandler)Delegate.Combine(selectionRendererEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			selectionRendererEventHandler_1 = (SelectionRendererEventHandler)Delegate.Remove(selectionRendererEventHandler_1, value);
		}
	}

	public event ConnectorRendererEventHandler RenderConnector
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			connectorRendererEventHandler_0 = (ConnectorRendererEventHandler)Delegate.Combine(connectorRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			connectorRendererEventHandler_0 = (ConnectorRendererEventHandler)Delegate.Remove(connectorRendererEventHandler_0, value);
		}
	}

	public event TreeBackgroundRendererEventHandler RenderTreeBackground
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeBackgroundRendererEventHandler_0 = (TreeBackgroundRendererEventHandler)Delegate.Combine(treeBackgroundRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeBackgroundRendererEventHandler_0 = (TreeBackgroundRendererEventHandler)Delegate.Remove(treeBackgroundRendererEventHandler_0, value);
		}
	}

	public event DragDropMarkerRendererEventHandler RenderDragDropMarker
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			dragDropMarkerRendererEventHandler_0 = (DragDropMarkerRendererEventHandler)Delegate.Combine(dragDropMarkerRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			dragDropMarkerRendererEventHandler_0 = (DragDropMarkerRendererEventHandler)Delegate.Remove(dragDropMarkerRendererEventHandler_0, value);
		}
	}

	public event ColumnHeaderRendererEventHandler RenderColumnHeader
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			columnHeaderRendererEventHandler_0 = (ColumnHeaderRendererEventHandler)Delegate.Combine(columnHeaderRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			columnHeaderRendererEventHandler_0 = (ColumnHeaderRendererEventHandler)Delegate.Remove(columnHeaderRendererEventHandler_0, value);
		}
	}

	public TreeRenderer()
	{
	}

	public virtual void DrawNodeBackground(NodeRendererEventArgs e)
	{
		OnRenderNodeBackground(e);
	}

	protected virtual void OnRenderNodeBackground(NodeRendererEventArgs e)
	{
		if (nodeRendererEventHandler_0 != null)
		{
			nodeRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawNodeExpandPart(NodeExpandPartRendererEventArgs e)
	{
		OnRenderNodeExpandPart(e);
	}

	protected virtual void OnRenderNodeExpandPart(NodeExpandPartRendererEventArgs e)
	{
		if (nodeExpandPartRendererEventHandler_0 != null)
		{
			nodeExpandPartRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawCellBackground(NodeCellRendererEventArgs e)
	{
		OnRenderCellBackground(e);
	}

	protected virtual void OnRenderCellBackground(NodeCellRendererEventArgs e)
	{
		if (nodeCellRendererEventHandler_0 != null)
		{
			nodeCellRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawCellCheckBox(NodeCellRendererEventArgs e)
	{
		OnRenderCellCheckBox(e);
	}

	protected virtual void OnRenderCellCheckBox(NodeCellRendererEventArgs e)
	{
		if (nodeCellRendererEventHandler_1 != null)
		{
			nodeCellRendererEventHandler_1(this, e);
		}
	}

	public virtual void DrawCellImage(NodeCellRendererEventArgs e)
	{
		OnRenderCellImage(e);
	}

	protected virtual void OnRenderCellImage(NodeCellRendererEventArgs e)
	{
		if (nodeCellRendererEventHandler_2 != null)
		{
			nodeCellRendererEventHandler_2(this, e);
		}
	}

	public virtual void DrawCellText(NodeCellRendererEventArgs e)
	{
		OnRenderCellText(e);
	}

	protected virtual void OnRenderCellText(NodeCellRendererEventArgs e)
	{
		if (nodeCellRendererEventHandler_3 != null)
		{
			nodeCellRendererEventHandler_3(this, e);
		}
	}

	public virtual void DrawSelection(SelectionRendererEventArgs e)
	{
		OnRenderSelection(e);
	}

	protected virtual void OnRenderSelection(SelectionRendererEventArgs e)
	{
		if (selectionRendererEventHandler_0 != null)
		{
			selectionRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawHotTracking(SelectionRendererEventArgs e)
	{
		OnRenderHotTracking(e);
	}

	protected virtual void OnRenderHotTracking(SelectionRendererEventArgs e)
	{
		if (selectionRendererEventHandler_1 != null)
		{
			selectionRendererEventHandler_1(this, e);
		}
	}

	public virtual void DrawConnector(ConnectorRendererEventArgs e)
	{
		OnRenderConnector(e);
	}

	protected virtual void OnRenderConnector(ConnectorRendererEventArgs e)
	{
		if (connectorRendererEventHandler_0 != null)
		{
			connectorRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawTreeBackground(TreeBackgroundRendererEventArgs e)
	{
		OnRenderTreeBackground(e);
	}

	protected virtual void OnRenderTreeBackground(TreeBackgroundRendererEventArgs e)
	{
		if (treeBackgroundRendererEventHandler_0 != null)
		{
			treeBackgroundRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawDragDropMarker(DragDropMarkerRendererEventArgs e)
	{
		OnRenderDragDropMarker(e);
	}

	protected virtual void OnRenderDragDropMarker(DragDropMarkerRendererEventArgs e)
	{
		if (dragDropMarkerRendererEventHandler_0 != null)
		{
			dragDropMarkerRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawColumnHeader(ColumnHeaderRendererEventArgs e)
	{
		OnRenderColumnHeader(e);
	}

	protected virtual void OnRenderColumnHeader(ColumnHeaderRendererEventArgs e)
	{
		if (columnHeaderRendererEventHandler_0 != null)
		{
			columnHeaderRendererEventHandler_0(this, e);
		}
	}
}
