using System;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar.Design;

public class ExplorerBarGroupItemEditor : CollectionEditor
{
	public ExplorerBarGroupItemEditor(Type type)
		: base(type)
	{
	}

	protected override Type CreateCollectionItemType()
	{
		return typeof(ButtonItem);
	}

	protected override object CreateInstance(Type itemType)
	{
		object obj = ((CollectionEditor)this).CreateInstance(itemType);
		if (obj is ButtonItem)
		{
			ButtonItem buttonItem_ = obj as ButtonItem;
			ExplorerBarGroupItem.smethod_0(buttonItem_, eExplorerBarStockStyle.Custom);
		}
		return obj;
	}
}
