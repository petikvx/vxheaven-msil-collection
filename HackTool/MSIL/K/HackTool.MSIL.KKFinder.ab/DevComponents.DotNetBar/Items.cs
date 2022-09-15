using System;
using System.Collections;

namespace DevComponents.DotNetBar;

public class Items : IEnumerable, IDisposable
{
	private SortedList sortedList_0;

	private DotNetBarManager dotNetBarManager_0;

	public BaseItem this[string sItemName]
	{
		get
		{
			if (sortedList_0.ContainsKey(sItemName))
			{
				return sortedList_0[sItemName] as BaseItem;
			}
			foreach (DictionaryEntry item in sortedList_0)
			{
				BaseItem baseItem = item.Value as BaseItem;
				if (!(baseItem.Name == sItemName))
				{
					if (baseItem.SubItems.Count > 0)
					{
						baseItem = method_0(sItemName, baseItem);
						if (baseItem != null)
						{
							return baseItem;
						}
					}
					continue;
				}
				return baseItem;
			}
			throw new InvalidOperationException("Item not found in collection");
		}
	}

	public BaseItem this[int iIndex] => sortedList_0.GetByIndex(iIndex) as BaseItem;

	public int Count => sortedList_0.Count;

	internal Items(DotNetBarManager objOwner)
	{
		sortedList_0 = new SortedList();
		dotNetBarManager_0 = objOwner;
	}

	public void Dispose()
	{
		Clear();
		sortedList_0 = null;
		dotNetBarManager_0 = null;
	}

	public void Clear()
	{
		if (dotNetBarManager_0 != null)
		{
			foreach (BaseItem value in sortedList_0.Values)
			{
				((IOwner)dotNetBarManager_0).RemoveShortcutsFromItem(value);
			}
		}
		sortedList_0.Clear();
	}

	public void Add(BaseItem objItem)
	{
		if (objItem == null)
		{
			throw new ArgumentNullException("Item must be valid value");
		}
		if (objItem.Name == null || objItem.Name == "")
		{
			objItem.Name = "item_" + objItem.Id;
		}
		if (sortedList_0.ContainsKey(objItem.Name))
		{
			throw new InvalidOperationException("Item with this name already exists");
		}
		if (objItem.Parent != null)
		{
			throw new InvalidOperationException("Item already has a Parent. Remove item from Parent first.");
		}
		objItem.method_6(dotNetBarManager_0);
		objItem.GlobalItem = true;
		sortedList_0.Add(objItem.Name, objItem);
	}

	public void AddCopy(BaseItem objItem)
	{
		if (objItem == null)
		{
			throw new ArgumentNullException("Item must be valid value");
		}
		if (objItem.Name == null || objItem.Name == "")
		{
			objItem.Name = "item_" + objItem.Id;
		}
		if (sortedList_0.ContainsKey(objItem.Name))
		{
			throw new InvalidOperationException("Item with this name already exists");
		}
		BaseItem baseItem = objItem.Copy();
		baseItem.method_6(dotNetBarManager_0);
		baseItem.GlobalItem = true;
		sortedList_0.Add(baseItem.Name, baseItem);
	}

	public void Remove(BaseItem objItemToRemove)
	{
		if (sortedList_0.ContainsKey(objItemToRemove.Name))
		{
			sortedList_0.Remove(objItemToRemove.Name);
			objItemToRemove.method_6(null);
			((IOwner)dotNetBarManager_0).RemoveShortcutsFromItem(objItemToRemove);
			return;
		}
		string name = objItemToRemove.Name;
		foreach (DictionaryEntry item in sortedList_0)
		{
			BaseItem baseItem = item.Value as BaseItem;
			if (baseItem != objItemToRemove)
			{
				if (baseItem.SubItems.Count > 0 && method_1(name, baseItem))
				{
					return;
				}
				continue;
			}
			sortedList_0.RemoveAt(sortedList_0.IndexOfValue(baseItem));
			objItemToRemove.method_6(null);
			((IOwner)dotNetBarManager_0).RemoveShortcutsFromItem(objItemToRemove);
			return;
		}
		sortedList_0.Remove(objItemToRemove.Name);
		objItemToRemove.method_6(null);
	}

	public void Remove(string sItemName)
	{
		Remove(sortedList_0[sItemName] as BaseItem);
	}

	private BaseItem method_0(string string_0, BaseItem baseItem_0)
	{
		BaseItem baseItem = null;
		foreach (BaseItem subItem in baseItem_0.SubItems)
		{
			if (!(subItem.Name == string_0))
			{
				if (subItem.SubItems.Count > 0)
				{
					baseItem = method_0(string_0, subItem);
					if (baseItem != null)
					{
						return baseItem;
					}
				}
				continue;
			}
			return subItem;
		}
		return null;
	}

	private bool method_1(string string_0, BaseItem baseItem_0)
	{
		foreach (BaseItem subItem in baseItem_0.SubItems)
		{
			if (!(subItem.Name == string_0))
			{
				if (subItem.SubItems.Count > 0 && method_1(string_0, subItem))
				{
					return true;
				}
				continue;
			}
			baseItem_0.SubItems.Remove(subItem);
			subItem.method_6(null);
			((IOwner)dotNetBarManager_0).RemoveShortcutsFromItem(subItem);
			return true;
		}
		return false;
	}

	public IEnumerator GetEnumerator()
	{
		return sortedList_0.GetEnumerator();
	}

	public bool Contains(BaseItem objItem)
	{
		return sortedList_0.ContainsValue(objItem);
	}

	public bool Contains(string sName)
	{
		return sortedList_0.ContainsKey(sName);
	}
}
