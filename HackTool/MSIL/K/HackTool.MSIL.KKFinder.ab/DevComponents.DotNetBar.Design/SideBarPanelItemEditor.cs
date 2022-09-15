using System;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar.Design;

public class SideBarPanelItemEditor : CollectionEditor
{
	public SideBarPanelItemEditor(Type type)
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
			buttonItem.ButtonStyle = eButtonStyle.ImageAndText;
			buttonItem.ImagePosition = eImagePosition.Top;
		}
		return obj;
	}
}
