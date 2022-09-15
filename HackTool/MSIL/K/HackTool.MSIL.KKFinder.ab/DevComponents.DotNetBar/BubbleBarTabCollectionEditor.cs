using System;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar;

public class BubbleBarTabCollectionEditor : CollectionEditor
{
	public BubbleBarTabCollectionEditor(Type type)
		: base(type)
	{
	}

	protected override Type CreateCollectionItemType()
	{
		return typeof(BubbleBarTab);
	}

	protected override Type[] CreateNewItemTypes()
	{
		return new Type[1] { typeof(BubbleBarTab) };
	}

	protected override object CreateInstance(Type itemType)
	{
		object obj = ((CollectionEditor)this).CreateInstance(itemType);
		if (obj is BubbleBarTab)
		{
			BubbleBarTab bubbleBarTab = obj as BubbleBarTab;
			bubbleBarTab.Text = "My Tab";
			bubbleBarTab.PredefinedColor = eTabItemColor.Blue;
		}
		return obj;
	}
}
