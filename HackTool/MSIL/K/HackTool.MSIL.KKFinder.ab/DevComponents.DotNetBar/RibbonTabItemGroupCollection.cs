using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace DevComponents.DotNetBar;

public class RibbonTabItemGroupCollection : CollectionBase
{
	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private RibbonStrip ribbonStrip_0;

	public RibbonTabItemGroup this[int index]
	{
		get
		{
			return (RibbonTabItemGroup)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public RibbonTabItemGroup this[string name]
	{
		get
		{
			foreach (RibbonTabItemGroup item in base.List)
			{
				if (item.Name == name)
				{
					return item;
				}
			}
			return null;
		}
	}

	internal RibbonStrip RibbonStrip_0
	{
		get
		{
			return ribbonStrip_0;
		}
		set
		{
			ribbonStrip_0 = value;
		}
	}

	public event EventHandler GroupRemoved
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public event EventHandler GroupAdded
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_1 = (EventHandler)Delegate.Combine(eventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_1 = (EventHandler)Delegate.Remove(eventHandler_1, value);
		}
	}

	public int Add(RibbonTabItemGroup tab)
	{
		return base.List.Add(tab);
	}

	public void AddRange(RibbonTabItemGroup[] groups)
	{
		foreach (RibbonTabItemGroup value in groups)
		{
			base.List.Add(value);
		}
	}

	public void Insert(int index, RibbonTabItemGroup value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(RibbonTabItemGroup value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(RibbonTabItemGroup value)
	{
		return base.List.Contains(value);
	}

	public void Remove(RibbonTabItemGroup value)
	{
		base.List.Remove(value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		base.OnRemoveComplete(index, value);
		RibbonTabItemGroup ribbonTabItemGroup = value as RibbonTabItemGroup;
		ribbonTabItemGroup.ParentRibbonStrip = null;
		if (eventHandler_0 != null)
		{
			eventHandler_0(ribbonTabItemGroup, new EventArgs());
		}
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
		RibbonTabItemGroup ribbonTabItemGroup = value as RibbonTabItemGroup;
		if (ribbonStrip_0 != null)
		{
			ribbonTabItemGroup.ParentRibbonStrip = ribbonStrip_0;
		}
		if (eventHandler_1 != null)
		{
			eventHandler_1(ribbonTabItemGroup, new EventArgs());
		}
	}

	public void CopyTo(RibbonTabItemGroup[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_0(RibbonTabItemGroup[] ribbonTabItemGroup_0)
	{
		base.List.CopyTo(ribbonTabItemGroup_0, 0);
	}

	protected override void OnClear()
	{
		base.OnClear();
	}
}
