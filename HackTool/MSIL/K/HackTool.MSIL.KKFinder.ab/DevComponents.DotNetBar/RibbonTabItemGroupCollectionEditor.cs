using System;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar;

public class RibbonTabItemGroupCollectionEditor : CollectionEditor
{
	public RibbonTabItemGroupCollectionEditor(Type type)
		: base(type)
	{
	}

	protected override Type CreateCollectionItemType()
	{
		return typeof(RibbonTabItemGroup);
	}

	protected override object CreateInstance(Type itemType)
	{
		object obj = ((CollectionEditor)this).CreateInstance(itemType);
		if (obj is RibbonTabItemGroup)
		{
			RibbonTabItemGroup ribbonTabItemGroup_ = obj as RibbonTabItemGroup;
			Class108.smethod_3(ribbonTabItemGroup_);
		}
		return obj;
	}
}
