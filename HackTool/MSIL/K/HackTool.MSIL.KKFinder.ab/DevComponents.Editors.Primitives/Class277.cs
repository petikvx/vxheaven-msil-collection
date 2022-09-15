using System;

namespace DevComponents.Editors.Primitives;

internal class Class277
{
	private string string_0;

	private int int_0;

	private int int_1;

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public int Int32_0
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	public Predicate<string> Predicate_0 => method_1;

	public Predicate<string> Predicate_1 => method_2;

	public Class277(string prefix)
	{
		string_0 = prefix;
	}

	public Class277(string prefix, int maxMatches)
	{
		string_0 = prefix;
		int_0 = maxMatches;
	}

	public void method_0()
	{
		int_1 = 0;
	}

	private bool method_1(string string_1)
	{
		return string_1.ToLower().StartsWith(string_0);
	}

	private bool method_2(string string_1)
	{
		if (int_1 > int_0)
		{
			return false;
		}
		bool result;
		if ((result = string_1.ToLower().StartsWith(string_0)) && int_0 > 0)
		{
			int_1++;
		}
		return result;
	}
}
