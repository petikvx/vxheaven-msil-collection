using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
public sealed class GAttribute0 : Attribute
{
	private string string_0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	[SpecialName]
	public bool method_0()
	{
		return bool_0;
	}

	[SpecialName]
	public void method_1(bool bool_3)
	{
		bool_0 = bool_3;
	}

	[SpecialName]
	public bool method_2()
	{
		return bool_1;
	}

	[SpecialName]
	public void method_3(bool bool_3)
	{
		bool_1 = bool_3;
	}

	[SpecialName]
	public string method_4()
	{
		return string_0;
	}

	[SpecialName]
	public void method_5(string string_1)
	{
		string_0 = string_1;
	}

	[SpecialName]
	public bool method_6()
	{
		return bool_2;
	}

	[SpecialName]
	public void method_7(bool bool_3)
	{
		bool_2 = bool_3;
	}
}
