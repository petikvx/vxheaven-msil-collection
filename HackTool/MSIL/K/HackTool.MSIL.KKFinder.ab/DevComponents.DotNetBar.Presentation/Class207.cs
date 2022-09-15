using System.Collections;

namespace DevComponents.DotNetBar.Presentation;

internal class Class207 : CollectionBase
{
	public Class209 this[int int_0]
	{
		get
		{
			return (Class209)base.List[int_0];
		}
		set
		{
			base.List[int_0] = value;
		}
	}

	public int method_0(Class209 class209_0)
	{
		return base.List.Add(class209_0);
	}

	public void method_1(int int_0, Class209 class209_0)
	{
		base.List.Insert(int_0, class209_0);
	}

	public int method_2(Class209 class209_0)
	{
		return base.List.IndexOf(class209_0);
	}

	public bool method_3(Class209 class209_0)
	{
		return base.List.Contains(class209_0);
	}

	public void method_4(Class209 class209_0)
	{
		base.List.Remove(class209_0);
	}

	public void method_5(Class209[] class209_0, int int_0)
	{
		base.List.CopyTo(class209_0, int_0);
	}

	internal void method_6(Class209[] class209_0)
	{
		base.List.CopyTo(class209_0, 0);
	}
}
