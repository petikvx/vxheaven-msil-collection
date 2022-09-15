using System;
using System.ComponentModel.Design;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class BubbleButtonCollectionEditor : CollectionEditor
{
	public BubbleButtonCollectionEditor(Type type)
		: base(type)
	{
	}

	protected override Type CreateCollectionItemType()
	{
		return typeof(BubbleButton);
	}

	protected override Type[] CreateNewItemTypes()
	{
		return new Type[1] { typeof(BubbleButton) };
	}

	protected override object CreateInstance(Type itemType)
	{
		object obj = ((CollectionEditor)this).CreateInstance(itemType);
		if (obj is BubbleButton)
		{
			BubbleButton bubbleButton = obj as BubbleButton;
			bubbleButton.Image = (Image)(object)Class109.smethod_67("SystemImages.Note24.png");
			bubbleButton.ImageLarge = (Image)(object)Class109.smethod_67("SystemImages.Note64.png");
		}
		return obj;
	}
}
