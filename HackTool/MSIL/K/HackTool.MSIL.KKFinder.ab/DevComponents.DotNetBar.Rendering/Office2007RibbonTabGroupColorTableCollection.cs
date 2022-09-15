using System.Collections;

namespace DevComponents.DotNetBar.Rendering;

public class Office2007RibbonTabGroupColorTableCollection : CollectionBase
{
	public Office2007RibbonTabGroupColorTable this[int index]
	{
		get
		{
			return (Office2007RibbonTabGroupColorTable)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public Office2007RibbonTabGroupColorTable this[string name]
	{
		get
		{
			foreach (Office2007RibbonTabGroupColorTable item in base.List)
			{
				if (item.Name == name)
				{
					return item;
				}
			}
			return null;
		}
	}

	public int Add(Office2007RibbonTabGroupColorTable colorTable)
	{
		return base.List.Add(colorTable);
	}

	public void Insert(int index, Office2007RibbonTabGroupColorTable value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(Office2007RibbonTabGroupColorTable value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(Office2007RibbonTabGroupColorTable value)
	{
		return base.List.Contains(value);
	}

	public bool Contains(string name)
	{
		foreach (Office2007RibbonTabGroupColorTable item in base.List)
		{
			if (item.Name == name)
			{
				return true;
			}
		}
		return false;
	}

	public void Remove(Office2007RibbonTabGroupColorTable value)
	{
		base.List.Remove(value);
	}

	public void CopyTo(Office2007RibbonTabGroupColorTable[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_0(Office2007RibbonTabGroupColorTable[] office2007RibbonTabGroupColorTable_0)
	{
		base.List.CopyTo(office2007RibbonTabGroupColorTable_0, 0);
	}

	protected override void OnClear()
	{
		base.OnClear();
	}
}
