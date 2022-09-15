using System.Collections;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class244 : CollectionBase
{
	private Class245 class245_0;

	public Class245 Class245_0
	{
		get
		{
			return class245_0;
		}
		set
		{
			class245_0 = value;
		}
	}

	public Class245 this[int int_0]
	{
		get
		{
			return (Class245)base.List[int_0];
		}
		set
		{
			base.List[int_0] = value;
		}
	}

	public Class244(Class245 parent)
	{
		class245_0 = parent;
	}

	public int method_0(Class245 class245_1)
	{
		return base.List.Add(class245_1);
	}

	public void method_1(int int_0, Class245 class245_1)
	{
		base.List.Insert(int_0, class245_1);
	}

	public int method_2(Class245 class245_1)
	{
		return base.List.IndexOf(class245_1);
	}

	public bool method_3(Class245 class245_1)
	{
		return base.List.Contains(class245_1);
	}

	public void method_4(Class245 class245_1)
	{
		base.List.Remove(class245_1);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		base.OnRemoveComplete(index, value);
		Class245 @class = value as Class245;
		if (class245_0 != null)
		{
			@class.method_1(null);
			class245_0.IsSizeValid = false;
		}
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
		Class245 @class = value as Class245;
		if (class245_0 != null)
		{
			@class.method_1(class245_0);
			class245_0.IsSizeValid = false;
		}
	}

	public void method_5(Class245[] class245_1, int int_0)
	{
		base.List.CopyTo(class245_1, int_0);
	}

	internal void method_6(Class245[] class245_1)
	{
		base.List.CopyTo(class245_1, 0);
	}

	protected override void OnClear()
	{
		base.OnClear();
	}
}
