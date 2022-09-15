using System.Collections;
using System.ComponentModel;

namespace DevComponents.AdvTree;

public class CellCollection : CollectionBase
{
	private Node node_0;

	private Cell cell_0;

	public Cell this[int index]
	{
		get
		{
			return (Cell)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Node ParentNode => node_0;

	public int Add(Cell cell)
	{
		return base.List.Add(cell);
	}

	public void Insert(int index, Cell value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(Cell value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(Cell value)
	{
		return base.List.Contains(value);
	}

	public void Remove(Cell value)
	{
		base.List.Remove(value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		base.OnRemoveComplete(index, value);
		Cell cell = value as Cell;
		cell.SetParent(null);
		if (node_0 != null)
		{
			node_0.OnCellRemoved(cell);
		}
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
		Cell cell = value as Cell;
		if (cell.Parent != null && cell.Parent != node_0)
		{
			cell.Parent.Cells.Remove(cell);
		}
		cell.SetParent(node_0);
		if (node_0 != null)
		{
			node_0.OnCellInserted(cell);
		}
	}

	protected override void OnInsert(int index, object value)
	{
		if (node_0 != null && node_0.Site != null && node_0.Site!.DesignMode && base.List.Count > 0)
		{
			Cell cell = value as Cell;
			if (cell.Site == null && base.List.Contains(cell))
			{
				base.List.Remove(cell);
			}
		}
		base.OnInsert(index, value);
	}

	public void CopyTo(Cell[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_0(Cell[] cell_1)
	{
		base.List.CopyTo(cell_1, 0);
	}

	protected override void OnClear()
	{
		if (node_0 != null && node_0.Site != null && node_0.Site!.DesignMode && base.List.Count > 0 && this[0].Site == null)
		{
			cell_0 = this[0];
		}
		base.OnClear();
	}

	protected override void OnClearComplete()
	{
		base.OnClearComplete();
		if (cell_0 != null)
		{
			Add(cell_0);
			cell_0 = null;
		}
	}

	protected override void OnSet(int index, object oldValue, object newValue)
	{
		base.OnSet(index, oldValue, newValue);
	}

	internal void method_1(Node node_1)
	{
		node_0 = node_1;
	}
}
