using System;
using System.Collections;
using System.Text.RegularExpressions;

internal class Class29
{
	public const string string_0 = ":";

	public const string string_1 = "{:}";

	public const string string_2 = "(?-m)^(?:(?<var>(?:::|:)[a-zA-Z_][a-zA-Z0-9_\\-:{}\\(\\)]*)|{(?<var>(?:::|:)[a-zA-Z_][a-zA-Z0-9_\\-:{}\\(\\)]*)})$";

	public const string string_3 = "{(?<var>(?:::|:)[a-zA-Z_][a-zA-Z0-9_\\-:{}\\(\\)]*)}";

	public static readonly string string_4 = new string('ÿ', 1);

	public Class28 class28_0 = new Class28();

	public Class26 class26_0;

	public Regex regex_0;

	public Regex regex_1;

	public Class29 class29_0 = null;

	public string string_5 = null;

	public Class29 class29_1 = null;

	public string string_6;

	public Random random_0;

	public Class29(Class26 class26_1, Class29 class29_2, Class29 class29_3, string string_7, string string_8, Random random_1)
	{
		class26_0 = class26_1;
		class29_0 = class29_3;
		string_5 = string_8;
		class29_1 = class29_2;
		string_6 = string_7;
		regex_0 = new Regex("(?-m)^(?:(?<var>(?:::|:)[a-zA-Z_][a-zA-Z0-9_\\-:{}\\(\\)]*)|{(?<var>(?:::|:)[a-zA-Z_][a-zA-Z0-9_\\-:{}\\(\\)]*)})$", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.ExplicitCapture | RegexOptions.Singleline);
		regex_1 = new Regex("{(?<var>(?:::|:)[a-zA-Z_][a-zA-Z0-9_\\-:{}\\(\\)]*)}", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.ExplicitCapture | RegexOptions.Singleline);
		random_0 = random_1;
	}

	protected Class28 method_0(string string_7)
	{
		return string_7 switch
		{
			"__ID" => new Class28(class26_0.class11_0.guid_0), 
			"__RAND" => new Class28(random_0.NextDouble()), 
			"__GUID" => new Class28(Guid.NewGuid()), 
			_ => class28_0.method_27(string_7), 
		};
	}

	protected Class28 method_1(string string_7, string[] string_8)
	{
		if (string_8.Length == 0)
		{
			return method_0(string_7);
		}
		return class28_0.method_27(string_7).method_29(string_8);
	}

	protected string method_2(string[] string_7)
	{
		if (string_7 != null && string_7.Length != 0)
		{
			return "(" + string.Join(")(", string_7) + ")";
		}
		return "";
	}

	protected Class29 method_3(string string_7)
	{
		if (string_7.StartsWith("{"))
		{
			string_7 = string_7.Substring(1, string_7.Length - 2);
		}
		Class29 @class = class29_1;
		if (@class == null)
		{
			@class = this;
		}
		while (true)
		{
			if (@class != null)
			{
				if (@class.method_4(string_7))
				{
					break;
				}
				@class = @class.class29_0;
				continue;
			}
			return this;
		}
		return @class;
	}

	protected bool method_4(string string_7)
	{
		return string_7?.StartsWith(string_6) ?? true;
	}

	public string method_5(string string_7)
	{
		return method_6(string_7, 1);
	}

	public string method_6(string string_7, int int_0)
	{
		string string_8;
		string[] string_9 = method_3(string_7).method_19(string_7, int_0, out string_8);
		return string_8 + method_2(string_9);
	}

	public bool method_7(ref string string_7, out string[] string_8)
	{
		return method_8(ref string_7, out string_8, 1, bool_0: false);
	}

	public bool method_8(ref string string_7, out string[] string_8, int int_0, bool bool_0)
	{
		string_8 = null;
		if (!bool_0 && method_4(string_7))
		{
			string_8 = method_19(string_7, int_0, out string_7);
			string_7 = method_21(string_7, bool_0);
			return true;
		}
		if (bool_0)
		{
			string_8 = method_3(string_7).method_19(string_7, int_0, out string_7);
			string_7 = method_21(string_7, bool_0);
			return true;
		}
		return false;
	}

	public Class28 method_9(string string_7)
	{
		Class29 @class = method_3(string_7);
		if (@class.method_7(ref string_7, out var string_8))
		{
			if (string_8.Length == 0)
			{
				return @class.class28_0.method_16(string_7);
			}
			if (!@class.class28_0.method_36(string_7))
			{
				return null;
			}
			return @class.class28_0.method_27(string_7).method_17(string_8);
		}
		return null;
	}

	public bool method_10(string string_7)
	{
		Class29 @class = method_3(string_7);
		if (@class.method_7(ref string_7, out var string_8))
		{
			if (string_8.Length == 0)
			{
				return @class.class28_0.method_36(string_7);
			}
			if (@class.class28_0.method_36(string_7))
			{
				return @class.class28_0.method_27(string_7).method_38(string_8);
			}
			return false;
		}
		return false;
	}

	public Class28 method_11(Class28 class28_1, int int_0)
	{
		return method_17(class28_1, int_0);
	}

	public Class28 method_12(Class28 class28_1)
	{
		return method_11(class28_1, 1);
	}

	public Class28 method_13(string string_7)
	{
		return method_18(string_7, 1);
	}

	public Class28 method_14(string string_7, Class28 class28_1)
	{
		if (string_7 == null)
		{
			return null;
		}
		Class29 @class = method_3(string_7);
		if (@class.method_7(ref string_7, out var string_8))
		{
			Class28 result;
			if (string_8.Length == 0)
			{
				@class.class28_0.method_28(string_7, result = class28_1);
				return result;
			}
			@class.class28_0.method_27(string_7).method_30(string_8, result = class28_1);
			return result;
		}
		return null;
	}

	public void method_15(Class28 class28_1)
	{
		class28_0 = class28_1;
	}

	public bool method_16(ref string string_7)
	{
		if (string_7 == null)
		{
			return false;
		}
		Match match = regex_0.Match(string_7);
		if (match.Success && match.Value == string_7)
		{
			if (string_7.StartsWith("{"))
			{
				string_7 = string_7.Substring(1, string_7.Length - 2);
			}
			return true;
		}
		return false;
	}

	protected Class28 method_17(Class28 class28_1, int int_0)
	{
		if (class28_1 == null)
		{
			return Class28.smethod_1();
		}
		int num = 0;
		string string_;
		while (true)
		{
			if (num < class28_1.method_5())
			{
				Class28 @class = class28_1.method_25(num);
				if (@class.method_3())
				{
					string_ = Class28.smethod_2(@class);
					string_ = ((!method_16(ref string_)) ? Class28.smethod_2(method_18(string_, int_0)) : Class28.smethod_2(method_3(string_).method_18(string_, int_0)));
					if (class28_1.method_5() == 1)
					{
						break;
					}
					class28_1.method_26(num, Class28.smethod_3(string_));
				}
				else if (!@class.method_2())
				{
					class28_1.method_26(num, method_17(@class, int_0));
				}
				num++;
				continue;
			}
			return class28_1;
		}
		return Class28.smethod_3(string_);
	}

	protected Class28 method_18(string string_7, int int_0)
	{
		if (string_7 == null)
		{
			return null;
		}
		if (int_0 < 0)
		{
			int_0 = int.MaxValue;
		}
		if (int_0 == 0)
		{
			return Class28.smethod_3(string_7);
		}
		if (method_16(ref string_7))
		{
			return method_3(string_7).method_22(string_7, int_0);
		}
		MatchCollection matchCollection = regex_1.Matches(string_7);
		if (matchCollection.Count == 0)
		{
			return Class28.smethod_3(string_7);
		}
		for (int num = matchCollection.Count - 1; num >= 0; num--)
		{
			string text = Class28.smethod_2(method_3(matchCollection[num].Groups["var"].Value).method_22(matchCollection[num].Groups["var"].Value, int_0));
			string_7 = string_7.Substring(0, matchCollection[num].Index) + text + string_7.Substring(matchCollection[num].Index + matchCollection[num].Length, string_7.Length - matchCollection[num].Index - matchCollection[num].Length);
		}
		if (int_0 > 1)
		{
			return method_18(string_7, int_0 - 1);
		}
		return Class28.smethod_3(string_7);
	}

	protected string[] method_19(string string_7, int int_0, out string string_8)
	{
		string_8 = string_7;
		if (string_7 == null)
		{
			return null;
		}
		ArrayList arrayList = new ArrayList();
		int num = string_7.IndexOf('(');
		if (num != -1)
		{
			string_8 = string_8.Substring(0, num);
		}
		char[] anyOf = new char[2] { ')', '(' };
		int num2 = 1;
		int num3 = num + 1;
		while (num != -1)
		{
			int num4 = ((num3 < string_7.Length) ? string_7.IndexOfAny(anyOf, num3) : (-1));
			if (num4 == -1)
			{
				break;
			}
			if (string_7[num4] == '(')
			{
				num2++;
				num3 = num4 + 1;
			}
			else if (--num2 == 0)
			{
				string string_9 = string_7.Substring(num + 1, num4 - num - 1);
				Class29 @class = ((class29_1 == null) ? this : class29_1);
				arrayList.Add(@class.method_18(string_9, int_0).System_002EObject_002EToString());
				num2 = 1;
				num = string_7.IndexOf('(', num4);
				num3 = num + 1;
			}
		}
		return arrayList.ToArray(typeof(string)) as string[];
	}

	protected string method_20(string string_7)
	{
		return method_21(string_7, bool_0: false);
	}

	protected string method_21(string string_7, bool bool_0)
	{
		if (method_4(string_7))
		{
			return string_7.Substring(string_6.Length, string_7.Length - string_6.Length);
		}
		if (bool_0)
		{
			return method_3(string_7).method_21(string_7, bool_0);
		}
		return string_7;
	}

	protected Class28 method_22(string string_7, int int_0)
	{
		if (int_0 == 0)
		{
			return Class28.smethod_3(string_7);
		}
		if (string_7 == null)
		{
			return null;
		}
		string string_8;
		string[] string_9 = method_19(string_7, int_0, out string_8);
		string_8 = method_21(string_8, bool_0: true);
		return method_1(string_8, string_9);
	}
}
