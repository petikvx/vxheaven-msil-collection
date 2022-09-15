using System;
using System.Collections;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

public class BubbleButtonCollection : CollectionBase
{
	private BubbleBarTab bubbleBarTab_0;

	private bool bool_0;

	internal BubbleBarTab BubbleBarTab_0 => bubbleBarTab_0;

	public virtual BubbleButton this[int index]
	{
		get
		{
			return (BubbleButton)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public virtual BubbleButton this[string name]
	{
		get
		{
			return (BubbleButton)base.List[IndexOf(name)];
		}
		set
		{
			base.List[IndexOf(name)] = value;
		}
	}

	internal BubbleButtonCollection(BubbleBarTab parent)
	{
		bubbleBarTab_0 = parent;
	}

	internal void method_0(IBlock[] iblock_0)
	{
		base.List.CopyTo(iblock_0, 0);
	}

	internal int method_1(BubbleButton bubbleButton_0)
	{
		bool_0 = true;
		int num = 0;
		try
		{
			return base.List.Add(bubbleButton_0);
		}
		finally
		{
			bool_0 = false;
		}
	}

	internal void method_2(BubbleButton bubbleButton_0, int int_0)
	{
		bool_0 = true;
		try
		{
			base.List.Insert(int_0, bubbleButton_0);
		}
		finally
		{
			bool_0 = false;
		}
	}

	internal void method_3()
	{
		bool_0 = true;
		try
		{
			base.List.Clear();
		}
		finally
		{
			bool_0 = false;
		}
	}

	protected override void OnSet(int index, object oldValue, object newValue)
	{
		if (newValue == null)
		{
			throw new InvalidOperationException("Setting of null values to BubbleButtonCollection is not allowed.");
		}
		BubbleButton bubbleButton = newValue as BubbleButton;
		if (bubbleButton.Parent != null)
		{
			bubbleButton.Parent.Buttons.Remove(bubbleButton);
		}
		base.OnSet(index, oldValue, newValue);
	}

	protected override void OnSetComplete(int index, object oldValue, object newValue)
	{
		if (!bool_0)
		{
			BubbleButton bubbleButton = newValue as BubbleButton;
			bubbleButton.SetParentCollection(this);
			bubbleBarTab_0.OnButtonInserted(bubbleButton);
		}
		base.OnSetComplete(index, oldValue, newValue);
	}

	protected override void OnInsert(int index, object value)
	{
		BubbleButton bubbleButton = value as BubbleButton;
		if (bubbleButton.Parent != null && bubbleButton.Parent != BubbleBarTab_0)
		{
			bubbleButton.Parent.Buttons.Remove(bubbleButton);
		}
		base.OnInsert(index, value);
	}

	protected override void OnInsertComplete(int index, object value)
	{
		if (!bool_0)
		{
			BubbleButton bubbleButton = value as BubbleButton;
			bubbleButton.SetParentCollection(this);
			bubbleBarTab_0.OnButtonInserted(bubbleButton);
		}
		base.OnInsertComplete(index, value);
	}

	protected override void OnRemove(int index, object value)
	{
		base.OnRemove(index, value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		if (!bool_0)
		{
			BubbleButton bubbleButton = value as BubbleButton;
			bubbleButton.SetParentCollection(null);
			bubbleBarTab_0.OnButtonRemoved(bubbleButton);
		}
		base.OnRemoveComplete(index, value);
	}

	internal void method_4(BubbleButton bubbleButton_0)
	{
		bool_0 = true;
		try
		{
			base.List.Remove(bubbleButton_0);
		}
		finally
		{
			bool_0 = false;
		}
	}

	protected override void OnClear()
	{
		if (!bool_0 && bubbleBarTab_0 != null)
		{
			bubbleBarTab_0.OnButtonsCollectionClear();
		}
		base.OnClear();
	}

	internal void method_5(ArrayList arrayList_0)
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
				BubbleButton value = (BubbleButton)enumerator.Current;
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

	public virtual int Add(BubbleButton item)
	{
		return Add(item, -1);
	}

	public virtual int Add(BubbleButton item, int Position)
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

	public virtual void Insert(int index, BubbleButton item)
	{
		Add(item, index);
	}

	public virtual int IndexOf(BubbleButton value)
	{
		return base.List.IndexOf(value);
	}

	public virtual int IndexOf(string name)
	{
		int num = -1;
		foreach (BubbleButton item in base.List)
		{
			num++;
			if (item.Name == name)
			{
				return num;
			}
		}
		return -1;
	}

	public virtual bool Contains(BubbleButton value)
	{
		return base.List.Contains(value);
	}

	public virtual bool Contains(string name)
	{
		foreach (BubbleButton item in base.List)
		{
			if (item.Name == name)
			{
				return true;
			}
		}
		return false;
	}

	public virtual void Remove(BubbleButton item)
	{
		base.List.Remove(item);
	}

	public void Remove(int index)
	{
		Remove((BubbleButton)base.List[index]);
	}

	public virtual void Remove(string name)
	{
		Remove(this[name]);
	}

	public virtual void AddRange(BubbleButton[] items)
	{
		foreach (BubbleButton item in items)
		{
			Add(item);
		}
	}

	public virtual void CopyTo(BubbleButton[] array, int index)
	{
		base.List.CopyTo(array, index);
	}
}
