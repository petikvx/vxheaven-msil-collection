using System;
using System.Text.RegularExpressions;

internal class Class15
{
	public const string string_0 = "({X(?![^}]*?X)(?<name>[a-zA-Z_][a-zA-Z0-9_\\-]*)(?<index>\\(\\S*?\\))*})|(X(?!\\S*?X)(?<name>[a-zA-Z_][a-zA-Z0-9_\\-]*)(?<index>\\(\\S*?\\))*)";

	public const string string_1 = "X";

	public const string string_2 = ":";

	public const string string_3 = "\\:";

	public static readonly string string_4 = new string('ÿ', 1);

	public Class14 class14_0 = new Class14();

	public Class12 class12_0;

	public string string_5;

	public Regex regex_0;

	public Class15 class15_0 = null;

	public string string_6;

	public Random random_0;

	public Class15(Class12 class12_1, Class15 class15_1, string string_7, Random random_1)
	{
		class12_0 = class12_1;
		class15_0 = class15_1;
		string_6 = string_7;
		string_5 = "({X(?![^}]*?X)(?<name>[a-zA-Z_][a-zA-Z0-9_\\-]*)(?<index>\\(\\S*?\\))*})|(X(?!\\S*?X)(?<name>[a-zA-Z_][a-zA-Z0-9_\\-]*)(?<index>\\(\\S*?\\))*)".Replace("X", string_7);
		regex_0 = new Regex(string_5, RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.ExplicitCapture | RegexOptions.Singleline);
		random_0 = random_1;
	}

	protected bool method_0(ref string string_7, out string[] string_8)
	{
		return method_1(ref string_7, out string_8, bool_0: false);
	}

	protected bool method_1(ref string string_7, out string[] string_8, bool bool_0)
	{
		string_8 = null;
		Match match = regex_0.Match(string_7);
		if (!match.Success)
		{
			if (bool_0 && class15_0 != null)
			{
				return class15_0.method_0(ref string_7, out string_8);
			}
			string_8 = new string[0];
			return false;
		}
		Group group = match.Groups["index"];
		string_8 = new string[group.Captures.Count];
		for (int i = 0; i < string_8.Length; i++)
		{
			string_8[i] = group.Captures[i].Value;
			string_8[i] = string_8[i].Substring(1, string_8[i].Length - 2);
		}
		string_7 = match.Groups["name"].Value;
		return true;
	}

	protected Class14 method_2(string string_7)
	{
		return string_7 switch
		{
			"__ID" => new Class14(class12_0.class23_0.guid_0), 
			"__RAND" => new Class14(random_0.NextDouble()), 
			"__GUID" => new Class14(Guid.NewGuid()), 
			_ => class14_0.method_27(string_7), 
		};
	}

	protected Class14 method_3(string string_7, string[] string_8)
	{
		if (string_8.Length == 0)
		{
			return method_2(string_7);
		}
		return class14_0.method_27(string_7).method_29(string_8);
	}

	protected string method_4(string[] string_7)
	{
		if (string_7 != null && string_7.Length != 0)
		{
			return "(" + string.Join(")(", string_7) + ")";
		}
		return "";
	}

	protected Class14 method_5(Class14 class14_1, ref int int_0)
	{
		Match match;
		do
		{
			match = regex_0.Match(Class14.smethod_2(class14_1));
			while (match != null && match.Success)
			{
				string string_ = match.Value;
				if (string_ == Class14.smethod_2(class14_1))
				{
					if (method_1(ref string_, out var string_2, bool_0: false))
					{
						for (int i = 0; i < string_2.Length; i++)
						{
							string_2[i] = Class14.smethod_2(method_5(Class14.smethod_3(string_2[i]), ref int_0));
						}
					}
					string text = string_6 + string_ + method_4(string_2);
					if (text == Class14.smethod_2(class14_1))
					{
						return method_3(string_, string_2);
					}
				}
				else
				{
					if (method_1(ref string_, out var string_3, bool_0: false))
					{
						for (int j = 0; j < string_3.Length; j++)
						{
							string_3[j] = Class14.smethod_2(method_5(Class14.smethod_3(string_3[j]), ref int_0));
						}
					}
					class14_1 = Class14.smethod_3(class14_1.System_002EObject_002EToString().Replace(match.Value, Class14.smethod_2(method_3(string_, string_3))));
					int_0--;
				}
				if (int_0 == 0)
				{
					break;
				}
				match = ((class14_1.method_1() || !(Class14.smethod_2(class14_1) != "")) ? null : regex_0.Match(Class14.smethod_2(class14_1)));
			}
			if (int_0 > 0 && class15_0 != null)
			{
				int int_ = 1;
				class14_1 = class15_0.method_5(class14_1, ref int_);
				int_0 -= 1 - int_;
				match = ((class14_1 == null || class14_1.method_1() || !(Class14.smethod_2(class14_1) != "")) ? null : regex_0.Match(Class14.smethod_2(class14_1)));
			}
		}
		while (int_0 != 0 && match != null && match.Success);
		return class14_1;
	}

	protected Class14 method_6(Class14 class14_1)
	{
		if (class14_1 == null)
		{
			return Class14.smethod_1();
		}
		int num = 0;
		string string_;
		int int_;
		while (true)
		{
			if (num < class14_1.method_5())
			{
				Class14 @class = class14_1.method_25(num);
				if (@class.method_3())
				{
					string_ = Class14.smethod_2(@class);
					int_ = int.MaxValue;
					if (class14_1.method_5() == 1)
					{
						break;
					}
					class14_1.method_26(num, method_5(Class14.smethod_3(string_), ref int_));
				}
				else if (!@class.method_2())
				{
					class14_1.method_26(num, method_6(@class));
				}
				num++;
				continue;
			}
			return class14_1;
		}
		if (method_7(string_))
		{
			string_ = method_8(string_);
		}
		return method_5(Class14.smethod_3(string_), ref int_);
	}

	public bool method_7(string string_7)
	{
		if (!string_7.StartsWith(string_6) && !string_7.StartsWith("{" + string_6))
		{
			if (class15_0 == null)
			{
				return false;
			}
			return class15_0.method_7(string_7);
		}
		Match match = regex_0.Match(string_7);
		if (match.Success)
		{
			if (!(match.Value == string_7))
			{
				return method_7(string_7.Replace(match.Value, ""));
			}
			return true;
		}
		return false;
	}

	public string method_8(string string_7)
	{
		Match match = regex_0.Match(string_7);
		while (true)
		{
			if (!match.Success || !(match.Value != string_7))
			{
				if (match.Success && match.Value == string_7)
				{
					method_0(ref string_7, out var string_8);
					string_7 = string_6 + string_7 + method_4(string_8);
					return string_7;
				}
				if (class15_0 != null)
				{
					string_7 = class15_0.method_8(string_7);
					match = regex_0.Match(string_7);
				}
				if (!match.Success || match.Value == string_7)
				{
					break;
				}
			}
			else
			{
				string_7 = string_7.Replace(match.Value, Class14.smethod_2(method_6(Class14.smethod_3(match.Value))));
				match = regex_0.Match(string_7);
			}
		}
		return string_7;
	}

	public Class14 method_9(string string_7)
	{
		string_7 = method_8(string_7);
		if (method_0(ref string_7, out var string_8))
		{
			if (string_8.Length == 0)
			{
				return class14_0.method_16(string_7);
			}
			if (!class14_0.method_36(string_7))
			{
				return null;
			}
			return class14_0.method_27(string_7).method_17(string_8);
		}
		if (class15_0 != null)
		{
			return class15_0.method_9(string_7);
		}
		return null;
	}

	public bool method_10(string string_7)
	{
		string_7 = method_8(string_7);
		if (method_0(ref string_7, out var string_8))
		{
			if (string_8.Length == 0)
			{
				return class14_0.method_36(string_7);
			}
			if (class14_0.method_36(string_7))
			{
				return class14_0.method_27(string_7).method_38(string_8);
			}
			return false;
		}
		if (class15_0 != null)
		{
			return class15_0.method_10(string_7);
		}
		return false;
	}

	public Class14 method_11(Class14 class14_1)
	{
		return method_6(class14_1);
	}

	public Class14 method_12(string string_7)
	{
		return method_6(Class14.smethod_3(string_7));
	}

	public Class14 method_13(string string_7, Class14 class14_1)
	{
		if (string_7 == null)
		{
			return null;
		}
		string_7 = method_8(string_7);
		if (method_0(ref string_7, out var string_8))
		{
			Class14 result;
			if (string_8.Length == 0)
			{
				class14_0.method_28(string_7, result = class14_1);
				return result;
			}
			class14_0.method_27(string_7).method_30(string_8, result = class14_1);
			return result;
		}
		if (class15_0 != null)
		{
			return class15_0.method_13(string_7, class14_1);
		}
		return null;
	}

	public void method_14(Class14 class14_1)
	{
		class14_0 = class14_1;
	}
}
