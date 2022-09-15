using System.Collections;

namespace DevComponents.Editors;

public class VisualItemCollection : CollectionBase
{
	private VisualGroup visualGroup_0;

	internal VisualGroup VisualGroup_0
	{
		get
		{
			return visualGroup_0;
		}
		set
		{
			visualGroup_0 = value;
		}
	}

	public VisualItem this[int index]
	{
		get
		{
			return (VisualItem)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public VisualItemCollection()
	{
	}

	public VisualItemCollection(VisualGroup parent)
	{
		visualGroup_0 = parent;
	}

	public int Add(VisualItem item)
	{
		return base.List.Add(item);
	}

	public void AddRange(VisualItem[] items)
	{
		foreach (VisualItem item in items)
		{
			Add(item);
		}
	}

	public void AddRange(IList items)
	{
		for (int i = 0; i < items.Count; i++)
		{
			Add((VisualItem)items[i]);
		}
	}

	public void Insert(int index, VisualItem value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(VisualItem value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(VisualItem value)
	{
		return base.List.Contains(value);
	}

	public void Remove(VisualItem value)
	{
		base.List.Remove(value);
	}

	protected override void OnRemove(int index, object value)
	{
		if (visualGroup_0 != null)
		{
			visualGroup_0.vmethod_15(new CollectionChangedInfo(null, new VisualItem[1] { (VisualItem)value }, eCollectionChangeType.Removing));
		}
		base.OnRemove(index, value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		if (visualGroup_0 != null)
		{
			visualGroup_0.vmethod_15(new CollectionChangedInfo(null, new VisualItem[1] { (VisualItem)value }, eCollectionChangeType.Removed));
		}
		base.OnRemoveComplete(index, value);
	}

	protected override void OnInsert(int index, object value)
	{
		if (visualGroup_0 != null)
		{
			visualGroup_0.vmethod_15(new CollectionChangedInfo(new VisualItem[1] { (VisualItem)value }, null, eCollectionChangeType.Adding));
		}
		base.OnInsert(index, value);
	}

	protected override void OnInsertComplete(int index, object value)
	{
		if (visualGroup_0 != null)
		{
			visualGroup_0.vmethod_15(new CollectionChangedInfo(new VisualItem[1] { (VisualItem)value }, null, eCollectionChangeType.Added));
		}
		base.OnInsertComplete(index, value);
	}

	protected override void OnClear()
	{
		if (visualGroup_0 != null)
		{
			visualGroup_0.vmethod_15(new CollectionChangedInfo(null, null, eCollectionChangeType.Clearing));
		}
		base.OnClear();
	}

	protected override void OnClearComplete()
	{
		if (visualGroup_0 != null)
		{
			visualGroup_0.vmethod_15(new CollectionChangedInfo(null, null, eCollectionChangeType.Cleared));
		}
		base.OnClearComplete();
	}

	protected override void OnSet(int index, object oldValue, object newValue)
	{
		if (visualGroup_0 != null)
		{
			visualGroup_0.vmethod_15(new CollectionChangedInfo(new VisualItem[1] { (VisualItem)oldValue }, new VisualItem[1] { (VisualItem)newValue }, eCollectionChangeType.Removing));
		}
		base.OnSet(index, oldValue, newValue);
	}

	protected override void OnSetComplete(int index, object oldValue, object newValue)
	{
		if (visualGroup_0 != null)
		{
			visualGroup_0.vmethod_15(new CollectionChangedInfo(new VisualItem[1] { (VisualItem)oldValue }, new VisualItem[1] { (VisualItem)newValue }, eCollectionChangeType.Removed));
		}
		base.OnSetComplete(index, oldValue, newValue);
	}

	public void CopyTo(VisualItem[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_0(VisualItem[] visualItem_0)
	{
		base.List.CopyTo(visualItem_0, 0);
	}
}
