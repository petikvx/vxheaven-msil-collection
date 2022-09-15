using System;
using System.Collections;
using System.ComponentModel;

namespace DevComponents.DotNetBar;

public class CrumbBarItemsCollection : CollectionBase
{
	private CrumbBar crumbBar_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public CrumbBar Parent => crumbBar_0;

	public CrumbBarItem this[int index]
	{
		get
		{
			return (CrumbBarItem)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public CrumbBarItem this[string name]
	{
		get
		{
			return method_2(name);
		}
		set
		{
			int num = method_3(name);
			if (num == -1)
			{
				throw new ArgumentException("name cannot be found in this collection");
			}
			base.List[num] = value;
		}
	}

	public CrumbBarItemsCollection(CrumbBar parent)
	{
		crumbBar_0 = parent;
	}

	internal void method_0(CrumbBar crumbBar_1)
	{
		crumbBar_0 = crumbBar_1;
	}

	public int Add(CrumbBarItem ch)
	{
		return base.List.Add(ch);
	}

	public void Insert(int index, CrumbBarItem value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(CrumbBarItem value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(CrumbBarItem value)
	{
		return base.List.Contains(value);
	}

	public void Remove(CrumbBarItem value)
	{
		base.List.Remove(value);
	}

	protected override void OnSet(int index, object oldValue, object newValue)
	{
		CrumbBarItem crumbBarItem = (CrumbBarItem)oldValue;
		crumbBarItem.method_6(null);
		crumbBarItem = (CrumbBarItem)newValue;
		crumbBarItem.method_6(crumbBar_0);
		base.OnSet(index, oldValue, newValue);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		CrumbBarItem crumbBarItem = (CrumbBarItem)value;
		crumbBarItem.method_6(null);
		base.OnRemoveComplete(index, value);
	}

	protected override void OnInsertComplete(int index, object value)
	{
		CrumbBarItem crumbBarItem = (CrumbBarItem)value;
		crumbBarItem.method_6(crumbBar_0);
		crumbBarItem.ContainerControl = crumbBar_0;
		crumbBarItem.Style = eDotNetBarStyle.Office2007;
		base.OnInsertComplete(index, value);
	}

	public void CopyTo(CrumbBarItem[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_1(CrumbBarItem[] crumbBarItem_0)
	{
		base.List.CopyTo(crumbBarItem_0, 0);
	}

	protected override void OnClear()
	{
		foreach (CrumbBarItem item in base.List)
		{
			item.method_6(null);
		}
		base.OnClear();
	}

	private CrumbBarItem method_2(string string_0)
	{
		foreach (CrumbBarItem item in base.List)
		{
			if (item.Name == string_0)
			{
				return item;
			}
		}
		return null;
	}

	private int method_3(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < base.List.Count)
			{
				CrumbBarItem crumbBarItem = this[num];
				if (crumbBarItem.Name == string_0)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}
}
