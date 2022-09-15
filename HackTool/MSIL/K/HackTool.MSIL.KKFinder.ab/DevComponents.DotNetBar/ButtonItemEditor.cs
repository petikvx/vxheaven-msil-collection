using System;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar;

public class ButtonItemEditor : CollectionEditor
{
	public ButtonItemEditor(Type type)
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
			ButtonItem buttonItem = obj as ButtonItem;
			buttonItem.Text = "New Item";
			buttonItem.ImagePosition = eImagePosition.Left;
		}
		else if (obj is LabelItem)
		{
			LabelItem labelItem = obj as LabelItem;
			labelItem.Text = "New Label";
		}
		return obj;
	}

	protected override Type[] CreateNewItemTypes()
	{
		return new Type[2]
		{
			typeof(ButtonItem),
			typeof(LabelItem)
		};
	}
}
