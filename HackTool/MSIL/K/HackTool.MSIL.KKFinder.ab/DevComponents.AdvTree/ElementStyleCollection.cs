using System.Collections;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree;

public class ElementStyleCollection : CollectionBase
{
	private AdvTree advTree_0;

	internal AdvTree AdvTree_0
	{
		get
		{
			return advTree_0;
		}
		set
		{
			advTree_0 = value;
		}
	}

	public ElementStyle this[int index]
	{
		get
		{
			return (ElementStyle)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public ElementStyle this[string name]
	{
		get
		{
			foreach (ElementStyle item in base.List)
			{
				if (item.Name == name)
				{
					return item;
				}
			}
			return null;
		}
	}

	public int Add(ElementStyle style)
	{
		return base.List.Add(style);
	}

	public void Insert(int index, ElementStyle value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(ElementStyle value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(ElementStyle value)
	{
		return base.List.Contains(value);
	}

	public void Remove(ElementStyle value)
	{
		base.List.Remove(value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		base.OnRemoveComplete(index, value);
		ElementStyle elementStyle = value as ElementStyle;
		elementStyle.ElementStyleCollection_0 = null;
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
		ElementStyle elementStyle = value as ElementStyle;
		if (elementStyle.ElementStyleCollection_0 != null && elementStyle.ElementStyleCollection_0 != this)
		{
			elementStyle.ElementStyleCollection_0.Remove(elementStyle);
		}
		elementStyle.ElementStyleCollection_0 = this;
	}

	public void CopyTo(ElementStyle[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_0(ElementStyle[] elementStyle_0)
	{
		base.List.CopyTo(elementStyle_0, 0);
	}

	protected override void OnClear()
	{
		base.OnClear();
	}
}
