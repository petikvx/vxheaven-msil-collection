using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.AdvTree;

public class ColumnHeaderCollection : CollectionBase
{
	private Node node_0;

	private AdvTree advTree_0;

	private Rectangle rectangle_0 = Rectangle.Empty;

	internal bool bool_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Node ParentNode => node_0;

	internal AdvTree AdvTree_0
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

	public ColumnHeader this[int index]
	{
		get
		{
			return (ColumnHeader)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	[Browsable(false)]
	public Rectangle Bounds => rectangle_0;

	internal void method_0(Node node_1)
	{
		node_0 = node_1;
	}

	public int Add(ColumnHeader ch)
	{
		return base.List.Add(ch);
	}

	public void Insert(int index, ColumnHeader value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(ColumnHeader value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(ColumnHeader value)
	{
		return base.List.Contains(value);
	}

	public void Remove(ColumnHeader value)
	{
		base.List.Remove(value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		if (value is ColumnHeader)
		{
			((ColumnHeader)value).HeaderSizeChanged -= method_6;
			((ColumnHeader)value).SortCells -= method_4;
			((ColumnHeader)value).MouseDown -= new MouseEventHandler(method_2);
			((ColumnHeader)value).MouseUp -= new MouseEventHandler(method_1);
		}
		method_5();
		base.OnRemoveComplete(index, value);
	}

	protected override void OnInsertComplete(int index, object value)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		if (value is ColumnHeader)
		{
			((ColumnHeader)value).HeaderSizeChanged += method_6;
			((ColumnHeader)value).SortCells += method_4;
			((ColumnHeader)value).MouseDown += new MouseEventHandler(method_2);
			((ColumnHeader)value).MouseUp += new MouseEventHandler(method_1);
		}
		method_5();
		base.OnInsertComplete(index, value);
	}

	private void method_1(object sender, MouseEventArgs e)
	{
		method_3()?.method_54(sender, e);
	}

	private void method_2(object sender, MouseEventArgs e)
	{
		method_3()?.method_55(sender, e);
	}

	private AdvTree method_3()
	{
		AdvTree treeControl = advTree_0;
		if (treeControl == null && node_0 != null)
		{
			treeControl = node_0.TreeControl;
		}
		return treeControl;
	}

	private void method_4(object sender, EventArgs0 e)
	{
		ColumnHeader value = (ColumnHeader)sender;
		int columnIndex = IndexOf(value);
		IComparer comparer = null;
		comparer = ((!e.bool_0) ? new NodeComparer(columnIndex) : new NodeComparerReverse(columnIndex));
		if (advTree_0 != null)
		{
			advTree_0.Nodes.Sort(comparer);
		}
		else if (node_0 != null)
		{
			node_0.Nodes.Sort(comparer);
		}
	}

	private void method_5()
	{
		if (advTree_0 != null)
		{
			advTree_0.InvalidateNodesSize();
			((Control)advTree_0).Invalidate();
		}
		else if (node_0 != null)
		{
			AdvTree treeControl = node_0.TreeControl;
			if (treeControl != null)
			{
				treeControl.InvalidateNodeSize(node_0);
				((Control)treeControl).Invalidate();
			}
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		method_5();
	}

	public void CopyTo(ColumnHeader[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_7(ColumnHeader[] columnHeader_0)
	{
		base.List.CopyTo(columnHeader_0, 0);
	}

	protected override void OnClear()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ColumnHeader columnHeader = (ColumnHeader)enumerator.Current;
				columnHeader.HeaderSizeChanged -= method_6;
				columnHeader.SortCells -= method_4;
				columnHeader.MouseDown -= new MouseEventHandler(method_2);
				columnHeader.MouseUp -= new MouseEventHandler(method_1);
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		base.OnClear();
	}

	internal void method_8(Rectangle rectangle_1)
	{
		rectangle_0 = rectangle_1;
	}
}
