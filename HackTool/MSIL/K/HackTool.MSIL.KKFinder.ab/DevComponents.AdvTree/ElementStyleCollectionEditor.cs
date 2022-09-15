using System;
using System.ComponentModel.Design;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree;

public class ElementStyleCollectionEditor : CollectionEditor
{
	public ElementStyleCollectionEditor(Type type)
		: base(type)
	{
	}

	protected override Type CreateCollectionItemType()
	{
		return typeof(ElementStyle);
	}

	protected override Type[] CreateNewItemTypes()
	{
		return new Type[1] { typeof(ElementStyle) };
	}

	protected override object CreateInstance(Type itemType)
	{
		return ((CollectionEditor)this).CreateInstance(itemType);
	}
}
