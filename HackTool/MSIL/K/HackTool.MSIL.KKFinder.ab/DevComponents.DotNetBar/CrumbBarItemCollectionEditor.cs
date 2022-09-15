using System;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar;

public class CrumbBarItemCollectionEditor : CollectionEditor
{
	public CrumbBarItemCollectionEditor(Type type)
		: base(type)
	{
	}

	protected override Type CreateCollectionItemType()
	{
		return typeof(CrumbBarItem);
	}

	protected override Type[] CreateNewItemTypes()
	{
		return new Type[1] { typeof(CrumbBarItem) };
	}

	protected override object CreateInstance(Type itemType)
	{
		object obj = ((CollectionEditor)this).CreateInstance(itemType);
		if (obj is CrumbBarItem)
		{
			CrumbBarItem crumbBarItem = obj as CrumbBarItem;
			crumbBarItem.Text = crumbBarItem.Name;
		}
		return obj;
	}
}
