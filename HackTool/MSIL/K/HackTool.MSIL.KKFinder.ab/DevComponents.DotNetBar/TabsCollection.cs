using System.Collections;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class TabsCollection : CollectionBase
{
	private TabStrip tabStrip_0;

	private bool bool_0;

	public TabItem this[int index]
	{
		get
		{
			return (TabItem)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public TabItem this[string name]
	{
		get
		{
			if (name == null)
			{
				return null;
			}
			int num = method_0(name);
			if (num >= 0)
			{
				return this[num];
			}
			return null;
		}
		set
		{
			int num = method_0(name);
			if (num >= 0)
			{
				base.List[num] = value;
			}
		}
	}

	public TabsCollection(TabStrip owner)
	{
		tabStrip_0 = owner;
	}

	public int Add(TabItem item)
	{
		tabStrip_0.Boolean_12 = true;
		return base.List.Add(item);
	}

	private int method_0(string string_0)
	{
		string_0 = string_0.ToLower();
		int num = 0;
		while (true)
		{
			if (num < base.Count)
			{
				if (this[num].Name.ToLower() == string_0)
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

	public void Insert(int index, TabItem value)
	{
		value.Visible = true;
		tabStrip_0.Boolean_12 = true;
		base.List.Insert(index, value);
	}

	internal void method_1(int int_0, TabItem tabItem_0)
	{
		bool_0 = true;
		try
		{
			tabItem_0.Visible = true;
			tabStrip_0.Boolean_12 = true;
			base.List.Insert(int_0, tabItem_0);
		}
		finally
		{
			bool_0 = false;
		}
	}

	public int IndexOf(TabItem value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(TabItem value)
	{
		return base.List.Contains(value);
	}

	public void Remove(TabItem value)
	{
		base.List.Remove(value);
	}

	internal void method_2(TabItem tabItem_0)
	{
		bool_0 = true;
		try
		{
			base.List.Remove(tabItem_0);
		}
		finally
		{
			bool_0 = false;
		}
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		base.OnRemoveComplete(index, value);
		if (!bool_0)
		{
			TabItem tabItem = value as TabItem;
			tabStrip_0.method_27(tabItem);
			tabItem.SetParent(null);
			tabItem.Visible = true;
			if (tabStrip_0.SelectedTab == tabItem)
			{
				tabStrip_0.method_26(index, tabItem);
			}
			tabStrip_0.Boolean_12 = true;
			if (tabStrip_0.Boolean_6)
			{
				((Control)tabStrip_0).Refresh();
			}
		}
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
		if (!bool_0)
		{
			TabItem tabItem = value as TabItem;
			tabItem.SetParent(tabStrip_0);
			tabStrip_0.method_53(tabItem);
			tabStrip_0.Boolean_12 = true;
			if (tabStrip_0.Boolean_6)
			{
				((Control)tabStrip_0).Refresh();
			}
		}
	}

	public void CopyTo(TabItem[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	protected override void OnClear()
	{
		tabStrip_0.method_40();
		base.OnClear();
	}
}
