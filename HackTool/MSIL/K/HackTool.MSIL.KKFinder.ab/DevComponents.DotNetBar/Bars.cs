using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class Bars : CollectionBase, IDisposable
{
	private DotNetBarManager dotNetBarManager_0;

	internal DotNetBarManager DotNetBarManager_0 => dotNetBarManager_0;

	public Bar this[int Index] => base.List[Index] as Bar;

	public Bar this[string Name]
	{
		get
		{
			foreach (Bar item in base.List)
			{
				if (item.Name == Name)
				{
					return item;
				}
			}
			return null;
		}
	}

	internal Bars(DotNetBarManager Owner)
	{
		dotNetBarManager_0 = Owner;
	}

	public void Dispose()
	{
		dotNetBarManager_0 = null;
		base.List.Clear();
	}

	public void Add(Bar bar)
	{
		if (base.List.IndexOf(bar) >= 0)
		{
			throw new InvalidOperationException("Bar is already in collection.");
		}
		base.List.Add(bar);
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
		Bar bar = (Bar)value;
		bar.Owner = dotNetBarManager_0;
		bar.ThemeAware = dotNetBarManager_0.ThemeAware;
		bar.Style = dotNetBarManager_0.Style;
		((IOwnerBarSupport)dotNetBarManager_0)?.AddShortcutsFromBar(bar);
		bar.method_35();
	}

	public virtual void Remove(Bar bar)
	{
		base.List.Remove(bar);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		Bar bar = (Bar)value;
		((IOwnerBarSupport)dotNetBarManager_0)?.RemoveShortcutsFromBar(bar);
		if (bar.Visible)
		{
			bar.method_95();
		}
		if (((Control)bar).get_Parent() != null)
		{
			if (((Control)bar).get_Parent() is DockSite && ((DockSite)(object)((Control)bar).get_Parent()).Boolean_2)
			{
				((DockSite)(object)((Control)bar).get_Parent()).GetDocumentUIManager().UnDock(bar);
			}
			if (((Control)bar).get_Parent() != null)
			{
				((Control)bar).get_Parent().get_Controls().Remove((Control)(object)bar);
			}
		}
		base.OnRemoveComplete(index, value);
	}

	protected override void OnClear()
	{
		if (dotNetBarManager_0 != null && dotNetBarManager_0.GetDesignMode())
		{
			return;
		}
		foreach (Bar item in base.List)
		{
			if (!item.method_75())
			{
				if (item.AutoHide)
				{
					item.AutoHide = false;
				}
				if (item.Visible)
				{
					item.method_95();
				}
				if (item.DockSide == eDockSide.Document && ((Control)item).get_Parent() is DockSite && ((DockSite)(object)((Control)item).get_Parent()).GetDocumentUIManager() != null)
				{
					((DockSite)(object)((Control)item).get_Parent()).GetDocumentUIManager().UnDock(item);
				}
				if (item != null && !((Control)item).get_IsDisposed())
				{
					((IOwnerBarSupport)dotNetBarManager_0).RemoveShortcutsFromBar(item);
				}
				if (((Control)item).get_Parent() != null)
				{
					((Control)item).get_Parent().get_Controls().Remove((Control)(object)item);
				}
				if (!item.method_75())
				{
					((Component)(object)item).Dispose();
				}
			}
		}
	}

	public bool Contains(Bar bar)
	{
		return base.List.Contains(bar);
	}

	public bool Contains(string name)
	{
		foreach (Bar item in base.List)
		{
			if (item.Name == name)
			{
				return true;
			}
		}
		return false;
	}

	public int IndexOf(Bar bar)
	{
		return base.List.IndexOf(bar);
	}

	public void CopyTo(Array array)
	{
		base.List.CopyTo(array, 0);
	}

	internal void method_0()
	{
		ArrayList arrayList = new ArrayList(base.Count);
		foreach (Bar item in base.List)
		{
			if (item.DockSide != eDockSide.Document)
			{
				arrayList.Add(item);
			}
		}
		foreach (Bar item2 in arrayList)
		{
			Remove(item2);
		}
	}
}
