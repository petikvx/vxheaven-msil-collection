using System;
using System.ComponentModel.Design;

namespace DevComponents.AdvTree;

public class ColumnHeaderCollectionEditor : CollectionEditor
{
	public ColumnHeaderCollectionEditor(Type type)
		: base(type)
	{
	}

	protected override Type CreateCollectionItemType()
	{
		return typeof(ColumnHeader);
	}

	protected override Type[] CreateNewItemTypes()
	{
		return new Type[1] { typeof(ColumnHeader) };
	}

	protected override object CreateInstance(Type itemType)
	{
		object obj = ((CollectionEditor)this).CreateInstance(itemType);
		if (obj is ColumnHeader)
		{
			ColumnHeader columnHeader = obj as ColumnHeader;
			columnHeader.Text = columnHeader.Name;
		}
		return obj;
	}
}
