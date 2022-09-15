using System;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar;

public class SideBarPanelsEditor : CollectionEditor
{
	public SideBarPanelsEditor(Type type)
		: base(type)
	{
	}

	protected override Type CreateCollectionItemType()
	{
		return typeof(SideBarPanelItem);
	}

	protected override Type[] CreateNewItemTypes()
	{
		return new Type[1] { typeof(SideBarPanelItem) };
	}

	protected override object CreateInstance(Type itemType)
	{
		object obj = ((CollectionEditor)this).CreateInstance(itemType);
		if (obj is SideBarPanelItem)
		{
			SideBarPanelItem sideBarPanelItem = obj as SideBarPanelItem;
			sideBarPanelItem.Text = "New Panel";
		}
		return obj;
	}
}
