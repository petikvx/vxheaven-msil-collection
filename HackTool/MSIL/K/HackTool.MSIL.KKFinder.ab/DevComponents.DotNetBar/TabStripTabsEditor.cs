using System;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar;

public class TabStripTabsEditor : CollectionEditor
{
	public TabStripTabsEditor(Type type)
		: base(type)
	{
	}

	protected override Type CreateCollectionItemType()
	{
		return typeof(TabItem);
	}

	protected override Type[] CreateNewItemTypes()
	{
		return new Type[1] { typeof(TabItem) };
	}

	protected override object CreateInstance(Type itemType)
	{
		object obj = ((CollectionEditor)this).CreateInstance(itemType);
		if (obj is TabItem)
		{
			TabItem tabItem = obj as TabItem;
			tabItem.Text = "My Tab";
		}
		return obj;
	}
}
