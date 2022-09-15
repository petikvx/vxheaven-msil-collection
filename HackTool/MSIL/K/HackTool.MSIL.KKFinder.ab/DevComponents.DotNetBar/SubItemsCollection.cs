using System;
using System.Collections;

namespace DevComponents.DotNetBar;

public class SubItemsCollection : CollectionBase
{
	private BaseItem baseItem_0;

	protected bool m_IgnoreEvents;

	private bool bool_0 = true;

	internal bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public virtual BaseItem this[int index]
	{
		get
		{
			return (BaseItem)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public virtual BaseItem this[string name]
	{
		get
		{
			return (BaseItem)base.List[IndexOf(name)];
		}
		set
		{
			base.List[IndexOf(name)] = value;
		}
	}

	internal bool Boolean_1
	{
		get
		{
			return m_IgnoreEvents;
		}
		set
		{
			m_IgnoreEvents = value;
		}
	}

	internal SubItemsCollection(BaseItem parent)
	{
		baseItem_0 = parent;
	}

	internal int method_0(BaseItem baseItem_1)
	{
		m_IgnoreEvents = true;
		bool_0 = false;
		int num = 0;
		try
		{
			return base.List.Add(baseItem_1);
		}
		finally
		{
			m_IgnoreEvents = false;
			bool_0 = true;
		}
	}

	internal void method_1(BaseItem baseItem_1, int int_0)
	{
		m_IgnoreEvents = true;
		bool_0 = false;
		try
		{
			if (int_0 >= 0)
			{
				base.List.Insert(int_0, baseItem_1);
			}
			else
			{
				base.List.Add(baseItem_1);
			}
		}
		finally
		{
			m_IgnoreEvents = false;
			bool_0 = true;
		}
	}

	internal void method_2()
	{
		m_IgnoreEvents = true;
		try
		{
			base.List.Clear();
		}
		finally
		{
			m_IgnoreEvents = false;
		}
	}

	public virtual int Add(BaseItem item)
	{
		return Add(item, -1);
	}

	public virtual int Add(BaseItem item, int Position)
	{
		int result = Position;
		if (Position >= 0)
		{
			base.List.Insert(Position, item);
		}
		else
		{
			result = base.List.Add(item);
		}
		return result;
	}

	protected override void OnInsert(int index, object value)
	{
		if (value is BaseItem)
		{
			BaseItem baseItem = value as BaseItem;
			if (bool_0 && baseItem.Parent != null && baseItem.Parent != baseItem_0 && baseItem.Parent.SubItems.Contains(baseItem))
			{
				baseItem.Parent.SubItems.Remove(baseItem);
			}
		}
		base.OnInsert(index, value);
	}

	protected override void OnInsertComplete(int index, object value)
	{
		if (!m_IgnoreEvents)
		{
			BaseItem baseItem = value as BaseItem;
			object containerControl = baseItem.ContainerControl;
			baseItem.Style = baseItem_0.Style;
			baseItem.Orientation = baseItem_0.Orientation;
			baseItem.ThemeAware = baseItem_0.ThemeAware;
			baseItem.SetParent(baseItem_0);
			if (baseItem_0.GetOwner() is IOwner owner)
			{
				owner.AddShortcutsFromItem(baseItem);
			}
			if (baseItem_0 != null && baseItem_0 is PopupItem && baseItem_0.Expanded && ((PopupItem)baseItem_0).PopupType != ePopupType.Container)
			{
				baseItem.ContainerControl = ((PopupItem)baseItem_0).PopupControl;
				baseItem.OnContainerChanged(containerControl);
			}
			else
			{
				baseItem.ContainerControl = null;
				baseItem.OnContainerChanged(containerControl);
			}
			containerControl = null;
			baseItem.SetDesignMode(baseItem_0.DesignMode);
			baseItem_0.NeedRecalcSize = true;
			baseItem_0.OnItemAdded(baseItem);
		}
		base.OnInsertComplete(index, value);
	}

	public virtual void Insert(int index, BaseItem item)
	{
		Add(item, index);
	}

	public virtual int IndexOf(BaseItem value)
	{
		return base.List.IndexOf(value);
	}

	public virtual int IndexOf(string name)
	{
		int num = -1;
		foreach (BaseItem item in base.List)
		{
			num++;
			if (item.Name == name)
			{
				return num;
			}
		}
		return -1;
	}

	public virtual bool Contains(BaseItem value)
	{
		return base.List.Contains(value);
	}

	public virtual bool Contains(string name)
	{
		foreach (BaseItem item in base.List)
		{
			if (item.Name == name)
			{
				return true;
			}
		}
		return false;
	}

	public virtual void Remove(BaseItem item)
	{
		base.List.Remove(item);
	}

	public virtual void RemoveRange(BaseItem[] items)
	{
		foreach (BaseItem item in items)
		{
			Remove(item);
		}
	}

	protected override void OnRemove(int index, object value)
	{
		RemoveInternal(index, value);
		base.OnRemove(index, value);
	}

	protected virtual void RemoveInternal(int index, object value)
	{
		if (!m_IgnoreEvents)
		{
			BaseItem baseItem = value as BaseItem;
			baseItem.OnBeforeItemRemoved(null);
			baseItem_0.OnBeforeItemRemoved(baseItem);
			if (baseItem_0.GetOwner() is IOwner owner)
			{
				owner.RemoveShortcutsFromItem(baseItem);
			}
		}
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		RemoveCompleteInternal(index, value);
		base.OnRemoveComplete(index, value);
	}

	protected virtual void RemoveCompleteInternal(int index, object value)
	{
		if (!m_IgnoreEvents)
		{
			BaseItem baseItem = value as BaseItem;
			baseItem.SetParent(null);
			baseItem.OnAfterItemRemoved(null);
			baseItem.ContainerControl = null;
			baseItem_0.OnAfterItemRemoved(baseItem);
			baseItem_0.NeedRecalcSize = true;
			baseItem_0.Refresh();
		}
	}

	internal void method_3(BaseItem baseItem_1)
	{
		m_IgnoreEvents = true;
		try
		{
			base.List.Remove(baseItem_1);
		}
		finally
		{
			m_IgnoreEvents = false;
		}
	}

	public void Remove(int index)
	{
		Remove((BaseItem)base.List[index]);
	}

	public virtual void Remove(string name)
	{
		Remove(this[name]);
	}

	protected override void OnClear()
	{
		if (m_IgnoreEvents)
		{
			return;
		}
		baseItem_0.GetOwner();
		if (baseItem_0 != null)
		{
			baseItem_0.SuspendLayout = true;
		}
		try
		{
			if (base.List.Count > 0)
			{
				for (int i = 0; i < base.Count; i++)
				{
					BaseItem value = this[i];
					RemoveInternal(i, value);
					RemoveCompleteInternal(i, value);
				}
			}
		}
		finally
		{
			if (baseItem_0 != null)
			{
				baseItem_0.SuspendLayout = false;
			}
		}
		if (baseItem_0 != null)
		{
			baseItem_0.OnSubItemsClear();
		}
	}

	public virtual void AddRange(BaseItem[] items)
	{
		foreach (BaseItem item in items)
		{
			Add(item);
		}
	}

	internal void method_4(ArrayList arrayList_0)
	{
		if (arrayList_0 == null)
		{
			return;
		}
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				BaseItem value = (BaseItem)enumerator.Current;
				arrayList_0.Add(value);
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
	}

	public virtual void CopyTo(BaseItem[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_5(BaseItem[] baseItem_1, int int_0)
	{
		for (int i = int_0; i < base.List.Count; i++)
		{
			baseItem_1[i - int_0] = this[i];
		}
	}
}
