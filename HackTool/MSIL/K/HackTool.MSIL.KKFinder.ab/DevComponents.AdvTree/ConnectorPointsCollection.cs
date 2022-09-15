using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DevComponents.AdvTree;

public class ConnectorPointsCollection : CollectionBase
{
	private Node node_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Node ParentNode => node_0;

	public Point this[int index]
	{
		get
		{
			return (Point)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	internal void method_0(Node node_1)
	{
		node_0 = node_1;
	}

	public int Add(Point p)
	{
		return base.List.Add(p);
	}

	public void AddRange(Point[] ap)
	{
		foreach (Point p in ap)
		{
			Add(p);
		}
	}

	public Point[] ToArray()
	{
		Point[] array = new Point[base.Count];
		method_1(array);
		return array;
	}

	public void Insert(int index, Point value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(Point value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(Point value)
	{
		return base.List.Contains(value);
	}

	public void Remove(Point value)
	{
		base.List.Remove(value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		base.OnRemoveComplete(index, value);
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
	}

	public void CopyTo(Point[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_1(Point[] point_0)
	{
		base.List.CopyTo(point_0, 0);
	}

	protected override void OnClear()
	{
		base.OnClear();
	}
}
