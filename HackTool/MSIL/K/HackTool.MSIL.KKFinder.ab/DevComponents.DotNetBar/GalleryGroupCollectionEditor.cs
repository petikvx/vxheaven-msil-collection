using System;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar;

public class GalleryGroupCollectionEditor : CollectionEditor
{
	public GalleryGroupCollectionEditor(Type type)
		: base(type)
	{
	}

	protected override Type CreateCollectionItemType()
	{
		return typeof(GalleryGroup);
	}

	protected override object CreateInstance(Type itemType)
	{
		object obj = ((CollectionEditor)this).CreateInstance(itemType);
		if (obj is GalleryGroup)
		{
			GalleryGroup galleryGroup = obj as GalleryGroup;
			galleryGroup.Text = galleryGroup.Name;
		}
		return obj;
	}
}
