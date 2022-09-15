using System;
using System.ComponentModel.Design;

namespace DevComponents.AdvTree;

public class NodeCollectionEditor : CollectionEditor
{
	public NodeCollectionEditor(Type type)
		: base(type)
	{
	}

	protected override Type CreateCollectionItemType()
	{
		return typeof(Node);
	}

	protected override Type[] CreateNewItemTypes()
	{
		return new Type[1] { typeof(Node) };
	}

	protected override object CreateInstance(Type itemType)
	{
		object obj = ((CollectionEditor)this).CreateInstance(itemType);
		if (obj is Node)
		{
			Node node = obj as Node;
			node.Text = node.Name;
		}
		return obj;
	}
}
