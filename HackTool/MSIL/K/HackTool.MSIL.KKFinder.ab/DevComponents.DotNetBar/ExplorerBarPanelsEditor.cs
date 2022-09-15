using System;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar;

public class ExplorerBarPanelsEditor : CollectionEditor
{
	public ExplorerBarPanelsEditor(Type type)
		: base(type)
	{
	}

	protected override Type CreateCollectionItemType()
	{
		return typeof(ExplorerBarGroupItem);
	}

	protected override Type[] CreateNewItemTypes()
	{
		return new Type[1] { typeof(ExplorerBarGroupItem) };
	}

	protected override object CreateInstance(Type itemType)
	{
		object obj = ((CollectionEditor)this).CreateInstance(itemType);
		if (obj is ExplorerBarGroupItem)
		{
			ExplorerBarGroupItem explorerBarGroupItem = obj as ExplorerBarGroupItem;
			explorerBarGroupItem.Text = "New Group";
		}
		return obj;
	}
}
