using System;
using System.Collections;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Xml;

internal class Class15 : Class14
{
	public Class15 class15_0;

	private Class15[] class15_1;

	protected string string_3;

	public Class15 class15_2;

	public Class15()
	{
	}

	public Class15(Class14 class14_0)
		: base(class14_0)
	{
		class15_2 = class14_0 as Class15;
	}

	public Class15(Class14 class14_0, XmlNode xmlNode_0)
		: base(class14_0, xmlNode_0)
	{
		class15_2 = class14_0 as Class15;
		if (xmlNode_0.NodeType != XmlNodeType.Text && xmlNode_0.NodeType != XmlNodeType.CDATA)
		{
			string str;
			if ((str = string_0) != null)
			{
				str = string.IsInterned(str);
				if ((object)str == "Literal" || (object)str == "L" || (object)str == "Expression" || (object)str == "E")
				{
					string_3 = xmlNode_0.InnerText;
					return;
				}
			}
			ArrayList arrayList = new ArrayList();
			Class15 @class = null;
			Class15 class2 = null;
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				if (Class51.smethod_1(childNode))
				{
					continue;
				}
				if (class2 != null)
				{
					if (@class != null)
					{
						@class.class15_0 = class2;
					}
					@class = class2;
				}
				class2 = Class26.smethod_0(this, childNode) as Class15;
				if (class2 != null)
				{
					arrayList.Add(class2);
				}
			}
			if (@class != null)
			{
				@class.class15_0 = class2;
			}
			class15_1 = arrayList.ToArray(typeof(Class15)) as Class15[];
		}
		else
		{
			string_3 = xmlNode_0.Value;
		}
	}

	protected static void smethod_0(Class15 class15_3, ref int int_1)
	{
		string str;
		if ((str = class15_3.string_0) != null)
		{
			str = string.IsInterned(str);
			if ((object)str == "Expression" || (object)str == "E" || (object)str == "Literal" || (object)str == "L")
			{
				return;
			}
		}
		class15_3.int_0 = int_1++;
		if (class15_3.method_4() != null && class15_3.method_13() > 0)
		{
			Class15[] array = class15_3.method_4();
			foreach (Class15 class15_4 in array)
			{
				smethod_0(class15_4, ref int_1);
			}
		}
	}

	protected Class28[] method_1(Class27 class27_0, Class28 class28_0, ref Class14 class14_0, params Class15[] class15_3)
	{
		return method_3(class27_0, class28_0, ref class14_0, class15_3.Length, class15_3.Length, class15_3);
	}

	protected Class28[] method_2(Class27 class27_0, Class28 class28_0, ref Class14 class14_0, int int_1, int int_2)
	{
		return method_3(class27_0, class28_0, ref class14_0, int_1, int_2, class15_1);
	}

	protected Class28[] method_3(Class27 class27_0, Class28 class28_0, ref Class14 class14_0, int int_1, int int_2, params Class15[] class15_3)
	{
		int num = 0;
		ArrayList arrayList = new ArrayList(int_2);
		foreach (Class15 @class in class15_3)
		{
			if (arrayList.Count == int_2)
			{
				break;
			}
			if (@class == null)
			{
				arrayList.Add(Class28.smethod_1());
				continue;
			}
			Class28 class2 = @class.vmethod_8(class27_0, class28_0, ref class14_0);
			arrayList.Add((class2 != null) ? class2 : Class28.smethod_1());
			num++;
		}
		while (arrayList.Count < int_1)
		{
			arrayList.Add(Class28.smethod_1());
		}
		return arrayList.ToArray(typeof(Class28)) as Class28[];
	}

	public virtual Class28 vmethod_2(Class27 class27_0, string string_4)
	{
		return vmethod_3(class27_0, string_4, Class28.smethod_1());
	}

	public virtual Class28 vmethod_3(Class27 class27_0, string string_4, Class28 class28_0)
	{
		if (idictionary_0.Contains(string_4))
		{
			return class27_0.method_17(idictionary_0[string_4] as string);
		}
		return class28_0;
	}

	public virtual string vmethod_4(string string_4)
	{
		return vmethod_5(string_4, null);
	}

	public virtual string vmethod_5(string string_4, string string_5)
	{
		if (idictionary_0.Contains(string_4))
		{
			return idictionary_0[string_4] as string;
		}
		return string_5;
	}

	protected virtual Class15 vmethod_6(int int_1)
	{
		if (int_1 >= method_13())
		{
			return null;
		}
		return class15_1[int_1];
	}

	[SpecialName]
	public Class15[] method_4()
	{
		return class15_1;
	}

	protected virtual Class15[] vmethod_7(int int_1, int int_2)
	{
		if (int_2 == 0)
		{
			return null;
		}
		Class15[] array = new Class15[int_2];
		Array.Copy(class15_1, 0, array, 0, Math.Min(Math.Min(method_13(), int_2), Math.Max(int_1, method_13())));
		return array;
	}

	protected void method_5(Class27 class27_0, Class28 class28_0, int int_1)
	{
		if (class28_0 == null)
		{
			return;
		}
		for (int i = 0; i < class28_0.method_5(); i++)
		{
			if (!class28_0.method_25(i).method_1())
			{
				if (class28_0.method_25(i).method_2())
				{
					class28_0.method_26(i, class27_0.method_16(class28_0.method_25(i), int_1));
				}
				else
				{
					method_5(class27_0, class28_0.method_25(i), int_1);
				}
			}
		}
	}

	protected void method_6(Class28 class28_0, bool bool_0)
	{
		if (class28_0 == null)
		{
			return;
		}
		for (int i = 0; i < class28_0.method_5(); i++)
		{
			if (!class28_0.method_25(i).method_1())
			{
				if (class28_0.method_25(i).method_2())
				{
					class28_0.method_26(i, Class28.smethod_3((!bool_0) ? Regex.Escape(Class51.smethod_7(class28_0.method_25(i))) : Regex.Escape(Class51.smethod_7(class28_0.method_25(i)))));
				}
				else
				{
					method_6(class28_0.method_25(i), bool_0);
				}
			}
		}
	}

	protected void method_7(Class28 class28_0, bool bool_0)
	{
		if (class28_0 == null)
		{
			return;
		}
		for (int i = 0; i < class28_0.method_5(); i++)
		{
			if (!class28_0.method_25(i).method_1())
			{
				if (class28_0.method_25(i).method_2())
				{
					class28_0.method_26(i, Class28.smethod_3((!bool_0) ? HttpUtility.HtmlEncode(Class51.smethod_7(class28_0.method_25(i))) : HttpUtility.HtmlDecode(Class51.smethod_7(class28_0.method_25(i)))));
				}
				else
				{
					method_7(class28_0.method_25(i), bool_0);
				}
			}
		}
	}

	protected void method_8(Class28 class28_0, bool bool_0)
	{
		if (class28_0 == null)
		{
			return;
		}
		for (int i = 0; i < class28_0.method_5(); i++)
		{
			if (!class28_0.method_25(i).method_1())
			{
				if (class28_0.method_25(i).method_2())
				{
					class28_0.method_26(i, Class28.smethod_3((!bool_0) ? HttpUtility.UrlEncode(Class51.smethod_7(class28_0.method_25(i)), Class12.encoding_0) : HttpUtility.UrlDecode(Class51.smethod_7(class28_0.method_25(i)), Class12.encoding_0)));
				}
				else
				{
					method_8(class28_0.method_25(i), bool_0);
				}
			}
		}
	}

	protected void method_9(Class28 class28_0, bool bool_0)
	{
		if (class28_0 == null)
		{
			return;
		}
		for (int i = 0; i < class28_0.method_5(); i++)
		{
			if (!class28_0.method_25(i).method_1())
			{
				if (class28_0.method_25(i).method_2())
				{
					class28_0.method_26(i, Class28.smethod_3(bool_0 ? Class51.smethod_7(class28_0.method_25(i)).ToLower() : Class51.smethod_7(class28_0.method_25(i)).ToUpper()));
				}
				else
				{
					method_9(class28_0.method_25(i), bool_0);
				}
			}
		}
	}

	protected void method_10(Class28 class28_0, bool bool_0)
	{
		if (class28_0 == null)
		{
			return;
		}
		for (int i = 0; i < class28_0.method_5(); i++)
		{
			if (!class28_0.method_25(i).method_1())
			{
				if (class28_0.method_25(i).method_2())
				{
					class28_0.method_26(i, Class28.smethod_3(bool_0 ? Class12.encoding_0.GetString(Convert.FromBase64String(Class51.smethod_7(class28_0.method_25(i)))) : Convert.ToBase64String(Class12.encoding_0.GetBytes(Class51.smethod_7(class28_0.method_25(i))))));
				}
				else
				{
					method_10(class28_0.method_25(i), bool_0);
				}
			}
		}
	}

	protected void method_11(Class28 class28_0, bool bool_0)
	{
		if (class28_0 == null)
		{
			return;
		}
		for (int i = 0; i < class28_0.method_5(); i++)
		{
			if (!class28_0.method_25(i).method_1())
			{
				if (class28_0.method_25(i).method_2())
				{
					class28_0.method_26(i, Class28.smethod_3(bool_0 ? Class51.smethod_26(Class51.smethod_7(class28_0.method_25(i)), class25_0.class26_0.class11_0) : Class51.smethod_24(Class51.smethod_7(class28_0.method_25(i)), class25_0.class26_0.class11_0)));
				}
				else
				{
					method_11(class28_0.method_25(i), bool_0);
				}
			}
		}
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected virtual Class28 evaluate(Class27 session, Class28 args, ref Class14 runningNode)
	{
		if (Class53.hashtable_3 == null)
		{
			Class53.hashtable_3 = new Hashtable(22, 0.5f)
			{
				{ "millisecond", 0 },
				{ "second", 1 },
				{ "minute", 2 },
				{ "hour", 3 },
				{ "dayofmonth", 4 },
				{ "dayofweek", 5 },
				{ "month", 6 },
				{ "year", 7 },
				{ "time", 8 },
				{ "date", 9 }
			};
			if (Class53.hashtable_4 == null)
			{
				Class53.hashtable_4 = new Hashtable(142, 0.5f)
				{
					{ "Wait", 0 },
					{ "Decide", 1 },
					{ "RandomSelect", 2 },
					{ "CreateBrowser", 3 },
					{ "Set", 4 },
					{ "Declare", 5 },
					{ "Clone", 6 },
					{ "Array", 7 },
					{ "ArrayLength", 8 },
					{ "Key", 9 },
					{ "MakeMap", 10 },
					{ "IntSeries", 11 },
					{ "ArrayItem", 12 },
					{ "ArraySubset", 13 },
					{ "AppendItem", 14 },
					{ "AppendMerge", 15 },
					{ "Remove", 16 },
					{ "RegexOptions", 17 },
					{ "RegexEscape", 18 },
					{ "RegexUnescape", 19 },
					{ "ToBase64", 20 },
					{ "FromBase64", 21 },
					{ "Scramble", 22 },
					{ "Unscramble", 23 },
					{ "IndexOf", 24 },
					{ "IsEmpty", 25 },
					{ "Or", 26 },
					{ "And", 27 },
					{ "Not", 28 },
					{ "Equals", 29 },
					{ "LessThan", 30 },
					{ "GreaterThan", 31 },
					{ "Add", 32 },
					{ "Multiply", 33 },
					{ "Divide", 34 },
					{ "Negate", 35 },
					{ "Rand", 36 },
					{ "Round", 37 },
					{ "Truncate", 38 },
					{ "Forget", 39 },
					{ "Defined", 40 },
					{ "StringToArray", 41 },
					{ "HtmlEncode", 42 },
					{ "HtmlDecode", 43 },
					{ "UrlEncode", 44 },
					{ "UrlDecode", 45 },
					{ "ToLower", 46 },
					{ "ToUpper", 47 },
					{ "Concat", 48 },
					{ "ConcatArray", 49 },
					{ "SubString", 50 },
					{ "LogError", 51 },
					{ "Exit", 52 },
					{ "Return", 53 },
					{ "Break", 54 },
					{ "Continue", 55 },
					{ "IsValidURI", 56 },
					{ "SplitURI", 57 },
					{ "BlowOut", 58 },
					{ "StringLength", 59 },
					{ "GetHttpHeader", 60 },
					{ "SetDefaultHttpHeader", 61 },
					{ "GetCookies", 62 },
					{ "SetCookie", 63 },
					{ "GetBrowserHistory", 64 },
					{ "Now", 65 },
					{ "DateTimeDiff", 66 },
					{ "DateTimePart", 67 },
					{ "DateTimeAdd", 68 },
					{ "ToTimeSpan", 69 },
					{ "CallStack", 70 }
				};
			}
		}
		switch (string_0)
		{
		case "Literal":
		case "L":
			return Class28.smethod_3(string_3);
		case "Expression":
		case "E":
			return session.method_17(string_3);
		default:
		{
			Class28 @class = null;
			object key;
			if ((key = string_0) != null && (key = Class53.hashtable_4[key]) != null)
			{
				DateTime dateTime2;
				switch ((int)key)
				{
				case 0:
				{
					TimeSpan timeSpan2 = Class51.smethod_12(Class28.smethod_2(vmethod_2(session, "duration")), TimeSpan.Zero);
					if (timeSpan2 != TimeSpan.Zero)
					{
						if (Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "random", Class28.smethod_3("false"))), bool_0: false))
						{
							int num5 = (int)timeSpan2.TotalMilliseconds;
							num5 = session.random_0.Next((int)((double)num5 * 0.65), (int)((double)num5 * 1.35));
							timeSpan2 = TimeSpan.FromMilliseconds(num5);
						}
						if (timeSpan2 != TimeSpan.Zero)
						{
							Thread.Sleep(timeSpan2);
						}
					}
					@class = new Class28(timeSpan2);
					break;
				}
				case 1:
				{
					bool flag3 = false;
					Class28 class20 = vmethod_3(session, "yesProbability", null);
					if (class20 == null)
					{
						class20 = vmethod_3(session, "noProbability", new Class28(0.5));
						flag3 = true;
					}
					double num6 = class20.method_43();
					if (num6 < 0.0 || num6 > 1.0)
					{
						num6 = 0.5;
					}
					if (flag3)
					{
						num6 = 1.0 - num6;
					}
					@class = new Class28(session.random_0.NextDouble() < num6);
					break;
				}
				case 2:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, method_13());
					if (array.Length == 1)
					{
						int num13 = array[0].method_5();
						if (num13 > 0)
						{
							@class = array[0].method_25(session.random_0.Next(0, num13 - 1));
						}
					}
					else
					{
						int num14 = array.Length;
						if (num14 > 0)
						{
							@class = array[session.random_0.Next(0, num14 - 1)];
						}
					}
					break;
				}
				case 3:
					if (string_1 != null)
					{
						bool bool_ = Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "isServerApi", Class28.smethod_3("false"))), bool_0: false);
						@class = session.method_20(string_1, bool_);
					}
					break;
				case 4:
				case 5:
				{
					string text27 = vmethod_4("var");
					Class28 class23 = ((string_0 == "Set") ? vmethod_3(session, "overwriteIfExists", null) : null);
					if (text27 != null)
					{
						Class28[] array = method_2(session, args, ref runningNode, 1, 1);
						if (!text27.StartsWith(":"))
						{
							text27 = ":" + text27;
						}
						if (class23 == null)
						{
							@class = session.method_18(text27, array[0]);
						}
						else if (Class51.smethod_11(Class28.smethod_2(class23), bool_0: true) || !session.method_15(text27))
						{
							@class = session.method_18(text27, array[0]);
						}
					}
					break;
				}
				case 6:
				{
					@class = new Class28();
					Class28[] array = method_2(session, args, ref runningNode, 1, 1);
					array[0].vmethod_4(@class);
					break;
				}
				case 7:
				{
					@class = new Class28();
					for (Class15 class16 = vmethod_6(0); class16 != null; class16 = class16.class15_0)
					{
						if (class16.string_0 == "AddItem")
						{
							string text20 = Class28.smethod_2(class16.vmethod_3(session, "key", null));
							Class28 class28_2 = class16.method_2(session, args, ref runningNode, 1, 1)[0];
							if (text20 != null)
							{
								@class.method_11(text20, class28_2);
							}
							else
							{
								@class.method_13(class28_2);
							}
						}
						else if (class16.string_0 == "MergeItem")
						{
							Class28 class28_3 = class16.method_2(session, args, ref runningNode, 1, 1)[0];
							@class.method_14(class28_3);
						}
						else
						{
							@class.method_13(method_1(session, args, ref runningNode, class16)[0]);
						}
					}
					break;
				}
				case 8:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, 1);
					@class = new Class28(array[0].method_5());
					break;
				}
				case 9:
				{
					Class28 class7 = vmethod_2(session, "array");
					int num4 = Class51.smethod_9(Class28.smethod_2(vmethod_2(session, "index")), 0);
					@class = Class28.smethod_3(class7.method_44(num4));
					break;
				}
				case 10:
				{
					Class28 class30 = vmethod_2(session, "keys");
					Class28 class31 = vmethod_2(session, "values");
					@class = new Class28();
					for (int k = 0; k < class30.method_5(); k++)
					{
						@class.method_11(Class28.smethod_2(class30.method_25(k)), class31.method_25(k));
					}
					break;
				}
				case 11:
				{
					@class = new Class28();
					int num7 = Class51.smethod_9(Class28.smethod_2(vmethod_2(session, "start")), 0);
					int num8 = Class51.smethod_9(Class28.smethod_2(vmethod_2(session, "step")), 1);
					int num9 = Class51.smethod_9(Class28.smethod_2(vmethod_2(session, "count")), 1);
					int num10 = num7;
					for (int j = 0; j < num9; j++)
					{
						@class.method_10(num10);
						num10 += num8;
					}
					break;
				}
				case 12:
				{
					Class28 class17 = vmethod_2(session, "array");
					string text22 = Class28.smethod_2(vmethod_2(session, "key"));
					@class = ((text22 == null) ? class17 : class17.method_27(text22));
					break;
				}
				case 13:
				{
					Class28 class11 = vmethod_2(session, "array");
					string text10 = Class28.smethod_2(vmethod_2(session, "keys"));
					if (text10 != null)
					{
						string text11 = Class28.smethod_2(vmethod_3(session, "keySeparator", Class28.smethod_3(";")));
						bool flag = Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "discardKeys", Class28.smethod_3("false"))), bool_0: false);
						string[] array3 = text10.Split(text11.ToCharArray());
						@class = new Class28();
						string[] array4 = array3;
						foreach (string text12 in array4)
						{
							if (!flag)
							{
								@class.method_13(class11.method_27(text12));
							}
							else
							{
								@class.method_11(text12, class11.method_27(text12));
							}
						}
					}
					else
					{
						@class = new Class28();
					}
					break;
				}
				case 14:
				{
					@class = vmethod_2(session, "array");
					string text8 = Class28.smethod_2(vmethod_3(session, "key", null));
					Class28[] array = method_2(session, args, ref runningNode, 1, 1);
					if (text8 != null)
					{
						@class.method_11(text8, array[0]);
					}
					else
					{
						@class.method_13(array[0]);
					}
					break;
				}
				case 15:
				{
					@class = vmethod_2(session, "array");
					Class28[] array = method_2(session, args, ref runningNode, 0, method_13());
					Class28[] array2 = array;
					foreach (Class28 class28_ in array2)
					{
						@class.method_14(class28_);
					}
					break;
				}
				case 16:
				{
					@class = vmethod_2(session, "array");
					string text4 = Class28.smethod_2(vmethod_2(session, "key"));
					@class.method_16(text4);
					break;
				}
				case 17:
				{
					RegexOptions regexOptions = RegexOptions.None;
					if (idictionary_0.Count > 0)
					{
						if (Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "caseInsensitive", null)), (session.regexOptions_0 & RegexOptions.IgnoreCase) != 0))
						{
							regexOptions |= RegexOptions.IgnoreCase;
						}
						if (Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "explicitCapture", null)), (session.regexOptions_0 & RegexOptions.ExplicitCapture) != 0))
						{
							regexOptions |= RegexOptions.ExplicitCapture;
						}
						if (Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "ignorePatternWhitespace", null)), (session.regexOptions_0 & RegexOptions.IgnorePatternWhitespace) != 0))
						{
							regexOptions |= RegexOptions.IgnorePatternWhitespace;
						}
						if (Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "multiline", null)), (session.regexOptions_0 & RegexOptions.Multiline) != 0))
						{
							regexOptions |= RegexOptions.Multiline;
						}
						if (Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "singleLine", null)), (session.regexOptions_0 & RegexOptions.Singleline) != 0))
						{
							regexOptions |= RegexOptions.Singleline;
						}
						if (Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "rightToLeft", null)), (session.regexOptions_0 & RegexOptions.RightToLeft) != 0))
						{
							regexOptions |= RegexOptions.RightToLeft;
						}
					}
					else
					{
						Class28[] array = method_2(session, args, ref runningNode, 0, 1);
						regexOptions = ((array.Length <= 0) ? session.regexOptions_0 : ((RegexOptions)Class51.smethod_9(Class28.smethod_2(array[0]), (int)session.regexOptions_0)));
					}
					@class = new Class28(session.regexOptions_0 = regexOptions);
					break;
				}
				case 18:
				{
					Class28[] array = method_2(session, args, ref runningNode, 0, method_13());
					Class28[] array2 = array;
					foreach (Class28 class32 in array2)
					{
						method_6(@class = class32, bool_0: false);
					}
					break;
				}
				case 19:
				{
					Class28[] array = method_2(session, args, ref runningNode, 0, method_13());
					Class28[] array2 = array;
					foreach (Class28 class33 in array2)
					{
						method_6(@class = class33, bool_0: true);
					}
					break;
				}
				case 20:
				{
					Class28[] array = method_2(session, args, ref runningNode, 0, method_13());
					Class28[] array2 = array;
					foreach (Class28 class3 in array2)
					{
						method_10(@class = class3, bool_0: false);
					}
					break;
				}
				case 21:
				{
					Class28[] array = method_2(session, args, ref runningNode, 0, method_13());
					Class28[] array2 = array;
					foreach (Class28 class27 in array2)
					{
						method_10(@class = class27, bool_0: true);
					}
					break;
				}
				case 22:
				{
					Class28[] array = method_2(session, args, ref runningNode, 0, method_13());
					Class28[] array2 = array;
					foreach (Class28 class24 in array2)
					{
						method_11(@class = class24, bool_0: false);
					}
					break;
				}
				case 23:
				{
					Class28[] array = method_2(session, args, ref runningNode, 0, method_13());
					Class28[] array2 = array;
					foreach (Class28 class21 in array2)
					{
						method_11(@class = class21, bool_0: true);
					}
					break;
				}
				case 24:
				{
					string text18 = Class28.smethod_2(vmethod_2(session, "search"));
					if (text18 != null)
					{
						Class28[] array = method_2(session, args, ref runningNode, 1, 1);
						string text19 = Class28.smethod_2(array[0]);
						if (text19 != null)
						{
							@class = new Class28(text19.IndexOf(text18));
						}
					}
					break;
				}
				case 25:
				{
					Class28[] array = method_2(session, args, ref runningNode, 0, 1);
					@class = new Class28(array[0].method_1() || Class51.smethod_7(array[0]) == "");
					break;
				}
				case 26:
				{
					Class15 class4 = vmethod_6(0);
					Class15 class5 = vmethod_6(1);
					method_1(session, args, ref runningNode, class4);
					@class = new Class28((class4 != null && method_1(session, args, ref runningNode, class4)[0].method_41()) || (class5 != null && method_1(session, args, ref runningNode, class5)[0].method_41()));
					break;
				}
				case 27:
				{
					Class15 class28 = vmethod_6(0);
					Class15 class29 = vmethod_6(1);
					method_1(session, args, ref runningNode, class28);
					@class = new Class28(class28 != null && method_1(session, args, ref runningNode, class28)[0].method_41() && class29 != null && method_1(session, args, ref runningNode, class29)[0].method_41());
					break;
				}
				case 28:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, 1);
					@class = new Class28(!array[0].method_41());
					break;
				}
				case 29:
				{
					Class28[] array = method_2(session, args, ref runningNode, 2, 2);
					@class = ((!Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "number", Class28.smethod_3("false"))), bool_0: false)) ? new Class28(Class28.smethod_2(array[0]) == Class28.smethod_2(array[1])) : new Class28(array[0].method_43() == array[1].method_43()));
					break;
				}
				case 30:
				{
					Class28[] array = method_2(session, args, ref runningNode, 2, 2);
					@class = new Class28(array[0].method_43() < array[1].method_43());
					break;
				}
				case 31:
				{
					Class28[] array = method_2(session, args, ref runningNode, 2, 2);
					@class = new Class28(array[0].method_43() > array[1].method_43());
					break;
				}
				case 32:
				{
					Class28[] array = method_2(session, args, ref runningNode, 2, 2);
					@class = new Class28(array[0].method_43() + array[1].method_43());
					break;
				}
				case 33:
				{
					Class28[] array = method_2(session, args, ref runningNode, 2, 2);
					@class = new Class28(array[0].method_43() * array[1].method_43());
					break;
				}
				case 34:
				{
					Class28[] array = method_2(session, args, ref runningNode, 2, 2);
					@class = new Class28(array[0].method_43() / array[1].method_43());
					break;
				}
				case 35:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, 1);
					@class = new Class28(0.0 - array[0].method_43());
					break;
				}
				case 36:
				{
					bool flag4 = Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "integer", Class28.smethod_3("false"))), bool_0: false);
					double num11 = Class51.smethod_10(Class28.smethod_2(vmethod_3(session, "min", Class28.smethod_3("0"))), 0.0);
					double num12 = Class51.smethod_10(Class28.smethod_2(vmethod_3(session, "max", Class28.smethod_3("1"))), 1.0);
					@class = ((!flag4) ? new Class28(num11 + (num12 - num11) * session.random_0.NextDouble()) : new Class28(session.random_0.Next((int)num11, (int)num12)));
					break;
				}
				case 37:
					@class = new Class28((long)Math.Round(method_2(session, args, ref runningNode, 1, 1)[0].method_43()));
					break;
				case 38:
					@class = new Class28((long)Math.Floor(method_2(session, args, ref runningNode, 1, 1)[0].method_43()));
					break;
				case 39:
				{
					string text24 = vmethod_4("var");
					if (text24 != null && text24 != "")
					{
						@class = session.method_14(text24);
					}
					break;
				}
				case 40:
				{
					string text21 = vmethod_4("var");
					if (text21 != null && text21 != "")
					{
						@class = new Class28(session.method_15(text21));
					}
					break;
				}
				case 41:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, 1);
					string text16 = Class28.smethod_2(vmethod_3(session, "separator", Class28.smethod_3(";")));
					bool flag2 = Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "strict", Class28.smethod_3("false"))), bool_0: false);
					string text17 = Class51.smethod_7(array[0]);
					@class = ((text17 == null) ? Class28.smethod_1() : Class28.smethod_0(flag2 ? ((IEnumerable)Class49.smethod_0(text17, text16)) : ((IEnumerable)text17.Split(text16.ToCharArray()))));
					break;
				}
				case 42:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, method_13());
					Class28[] array2 = array;
					foreach (Class28 class12 in array2)
					{
						method_7(@class = class12, bool_0: false);
					}
					break;
				}
				case 43:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, method_13());
					Class28[] array2 = array;
					foreach (Class28 class13 in array2)
					{
						method_7(@class = class13, bool_0: true);
					}
					break;
				}
				case 44:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, method_13());
					Class28[] array2 = array;
					foreach (Class28 class10 in array2)
					{
						method_8(@class = class10, bool_0: false);
					}
					break;
				}
				case 45:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, method_13());
					Class28[] array2 = array;
					foreach (Class28 class9 in array2)
					{
						method_7(@class = class9, bool_0: true);
					}
					break;
				}
				case 46:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, method_13());
					Class28[] array2 = array;
					foreach (Class28 class8 in array2)
					{
						method_9(@class = class8, bool_0: true);
					}
					break;
				}
				case 47:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, method_13());
					Class28[] array2 = array;
					foreach (Class28 class6 in array2)
					{
						method_9(@class = class6, bool_0: false);
					}
					break;
				}
				case 48:
				{
					Class28[] array = method_2(session, args, ref runningNode, 0, method_13());
					string text7 = Class28.smethod_2(vmethod_3(session, "glue", Class28.smethod_3("")));
					@class = Class28.smethod_3(Class49.smethod_1(array, text7));
					break;
				}
				case 49:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, 1);
					string text5 = Class28.smethod_2(vmethod_3(session, "glue", Class28.smethod_3("")));
					string[] ienumerable_ = array[0].method_35(typeof(string)) as string[];
					@class = Class28.smethod_3(Class49.smethod_1(ienumerable_, text5));
					break;
				}
				case 50:
				{
					string text3 = Class28.smethod_2(method_2(session, args, ref runningNode, 1, 1)[0]);
					int num2 = vmethod_3(session, "start", Class28.smethod_3("0")).method_42();
					int num3 = vmethod_2(session, "length").method_42();
					if (num2 < 0 && num3 < 0)
					{
						num2 = text3.Length + num3;
						@class = Class28.smethod_3(text3.Substring(num2, -num3));
					}
					else
					{
						num3 = Math.Abs(num3);
						@class = Class28.smethod_3(text3.Substring(num2, num3));
					}
					break;
				}
				case 51:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, 1);
					if (!array[0].method_1())
					{
						session.method_22(method_0(session), Class28.smethod_2(array[0]));
					}
					break;
				}
				case 52:
				{
					Class28[] array = method_2(session, args, ref runningNode, 0, 1);
					throw new GException0((array.Length == 0) ? null : array[0]);
				}
				case 53:
				{
					Class28[] array = method_2(session, args, ref runningNode, 0, 1);
					vmethod_11((array.Length == 0) ? null : array[0]);
					break;
				}
				case 54:
					if (class15_2 != null)
					{
						Class28[] array = method_2(session, args, ref runningNode, 0, 1);
						Class28 class26 = ((array.Length > 0) ? array[0] : new Class28("1"));
						class15_2.vmethod_9(Math.Max(class26.method_42(), 1));
					}
					break;
				case 55:
					if (class15_2 != null)
					{
						class15_2.vmethod_10();
					}
					break;
				case 56:
					try
					{
						Class28[] array = method_2(session, args, ref runningNode, 1, 1);
						Uri uri3 = new Uri(Class28.smethod_2(array[0]));
						return new Class28((object)uri3 != null);
					}
					catch
					{
						return new Class28(false);
					}
				case 57:
					try
					{
						Class28[] array = method_2(session, args, ref runningNode, 1, 1);
						Uri uri2 = new Uri(Class28.smethod_2(array[0]));
						@class = new Class28();
						@class.method_11("scheme", Class28.smethod_3(uri2.Scheme));
						@class.method_11("host", Class28.smethod_3(uri2.Host));
						@class.method_11("port", Class28.smethod_3(Class51.smethod_3(uri2.Port)));
						@class.method_11("authority", Class28.smethod_3(uri2.Authority));
						@class.method_11("pathandquery", Class28.smethod_3(uri2.PathAndQuery));
						@class.method_11("query", Class28.smethod_3(uri2.Query));
						@class.method_11("userinfo", Class28.smethod_3(uri2.UserInfo));
						@class.method_11("isloopback", Class28.smethod_3(Class51.smethod_4(uri2.IsLoopback)));
						@class.method_11("isfile", Class28.smethod_3(Class51.smethod_4(uri2.IsFile)));
						@class.method_11("fragment", Class28.smethod_3(uri2.Fragment));
						return @class;
					}
					catch
					{
						return @class;
					}
				case 58:
				{
					Class28[] array = method_2(session, args, ref runningNode, 1, 1);
					try
					{
						int int_ = Class51.smethod_9(Class28.smethod_2(vmethod_3(session, "maxPasses", Class28.smethod_3("-1"))), -1);
						@class = array[0];
						method_5(session, @class, int_);
						return @class;
					}
					catch
					{
						return array[0];
					}
				}
				case 59:
					try
					{
						Class28[] array = method_2(session, args, ref runningNode, 1, 1);
						@class = new Class28(Class51.smethod_7(array[0]).Length);
						return @class;
					}
					catch
					{
						return @class;
					}
				case 60:
				{
					string text28 = vmethod_5("browser", ":BROWSER");
					Class8 class25 = session.method_21(text28);
					string text29 = Class28.smethod_2(vmethod_2(session, "header"));
					if (class25.method_6() != null && text29 != null && text29 != "")
					{
						@class = Class28.smethod_3(class25.method_6().method_7().Headers[text29]);
					}
					break;
				}
				case 61:
				{
					string text25 = vmethod_5("browser", ":BROWSER");
					Class8 class22 = session.method_21(text25);
					string text26 = Class28.smethod_2(vmethod_2(session, "header"));
					if (class22 != null && text26 != null && text26 != "")
					{
						Class28[] array = method_2(session, args, ref runningNode, 0, 1);
						@class = ((array.Length != 0) ? array[0] : Class28.smethod_3(""));
						string value4 = $"{text26}: {array[0]}";
						ArrayList arrayList = new ArrayList();
						arrayList.AddRange(class22.string_2);
						arrayList.Add(value4);
						class22.string_2 = arrayList.ToArray(typeof(string)) as string[];
					}
					break;
				}
				case 62:
				{
					string text23 = vmethod_5("browser", ":BROWSER");
					Class8 class18 = session.method_21(text23);
					string uriString = Class28.smethod_2(vmethod_3(session, "url", Class28.smethod_3((class18.method_6() == null) ? null : Class51.smethod_8(class18.method_6().method_11()))));
					if (class18.method_6() == null)
					{
						break;
					}
					CookieCollection cookies = class18.cookieContainer_0.GetCookies(new Uri(uriString));
					@class = new Class28();
					{
						foreach (Cookie item in cookies)
						{
							if (item.Expires > DateTime.Now)
							{
								Class28 class19 = new Class28();
								class19.method_13(Class28.smethod_3(item.Value));
								class19.method_11("DOMAIN", Class28.smethod_3(item.Domain));
								class19.method_11("EXPIRES", new Class28(item.Expires));
								@class.method_11(item.Name, class19);
							}
						}
						return @class;
					}
				}
				case 63:
				{
					string text14 = vmethod_5("browser", ":BROWSER");
					Class8 class15 = session.method_21(text14);
					string text15 = Class28.smethod_2(vmethod_3(session, "url", Class28.smethod_3((class15.method_6() == null) ? null : class15.method_6().method_11().GetLeftPart(UriPartial.Authority))));
					DateTime expires = Class51.smethod_13(Class28.smethod_2(vmethod_3(session, "expires", Class28.smethod_3(Class51.smethod_6(DateTime.MaxValue)))), DateTime.MaxValue);
					if (string_1 != null && text15 != null)
					{
						Uri uri = null;
						uri = ((class15.method_6() == null) ? new Uri(text15) : new Uri(class15.method_6().method_11(), text15));
						string value3 = Class28.smethod_2(method_2(session, args, ref runningNode, 1, 1)[0]);
						Cookie cookie = new Cookie(string_1, value3);
						cookie.Expires = expires;
						class15.cookieContainer_0.Add(uri, cookie);
					}
					break;
				}
				case 64:
				{
					string text13 = vmethod_5("browser", ":BROWSER");
					Class8 class14 = session.method_21(text13);
					@class = Class28.smethod_0(class14.arrayList_0);
					break;
				}
				case 65:
					@class = new Class28(DateTime.Now);
					break;
				case 66:
				{
					object obj3 = vmethod_3(session, "to", Class28.smethod_3(Class51.smethod_6(DateTime.Now))).method_39(typeof(DateTime));
					DateTime dateTime3 = ((obj3 == null) ? DateTime.Now : ((DateTime)obj3));
					obj3 = vmethod_2(session, "from").method_39(typeof(DateTime));
					DateTime dateTime4 = ((obj3 == null) ? DateTime.Now : ((DateTime)obj3));
					string text9 = Class28.smethod_2(vmethod_3(session, "unit", Class28.smethod_3("timespan")));
					text9 = text9.ToLower();
					TimeSpan timeSpan = dateTime3 - dateTime4;
					@class = text9 switch
					{
						"timespan" => new Class28(timeSpan), 
						"day" => new Class28(timeSpan.TotalDays), 
						"hour" => new Class28(timeSpan.TotalHours), 
						"minute" => new Class28(timeSpan.TotalMinutes), 
						"second" => new Class28(timeSpan.TotalSeconds), 
						"millisecond" => new Class28(timeSpan.TotalMilliseconds), 
						_ => new Class28(new DateTime(timeSpan.Ticks)), 
					};
					break;
				}
				case 67:
				{
					object obj2 = vmethod_2(session, "date").method_39(typeof(DateTime));
					dateTime2 = ((obj2 == null) ? DateTime.Now : ((DateTime)obj2));
					string text6 = Class28.smethod_2(vmethod_3(session, "part", Class28.smethod_3("millisecond")));
					text6 = text6.ToLower();
					if ((key = text6) != null && (key = Class53.hashtable_3[key]) != null)
					{
						switch ((int)key)
						{
						case 0:
							break;
						case 1:
							goto IL_222c;
						case 2:
							goto IL_2243;
						case 3:
							goto IL_225a;
						case 4:
							goto IL_2271;
						case 5:
							goto IL_2288;
						case 6:
							goto IL_229f;
						case 7:
							goto IL_22b6;
						case 8:
							goto IL_22cd;
						case 9:
							goto IL_22e4;
						default:
							goto IL_22fb;
						}
						@class = new Class28(dateTime2.Millisecond);
						break;
					}
					goto IL_22fb;
				}
				case 68:
				{
					object obj = vmethod_2(session, "date").method_39(typeof(DateTime));
					DateTime dateTime = ((obj == null) ? DateTime.Now : ((DateTime)obj));
					string text2 = Class28.smethod_2(vmethod_3(session, "unit", Class28.smethod_3("millisecond")));
					text2 = text2.ToLower();
					Class28 class2 = method_2(session, args, ref runningNode, 1, 1)[0];
					obj = class2.method_39(typeof(TimeSpan));
					TimeSpan value2 = ((obj == null) ? DateTime.Now.TimeOfDay : ((TimeSpan)obj));
					double num = class2.method_43();
					@class = text2 switch
					{
						"timespan" => new Class28(dateTime.Add(value2)), 
						"year" => new Class28(dateTime.AddYears((int)num)), 
						"month" => new Class28(dateTime.AddMonths((int)num)), 
						"day" => new Class28(dateTime.AddDays(num)), 
						"hour" => new Class28(dateTime.AddHours(num)), 
						"minute" => new Class28(dateTime.AddMinutes(num)), 
						"second" => new Class28(dateTime.AddSeconds(num)), 
						"millisecond" => new Class28(dateTime.AddMilliseconds(num)), 
						_ => new Class28(dateTime), 
					};
					break;
				}
				case 69:
				{
					string text = Class28.smethod_2(vmethod_3(session, "unit", Class28.smethod_3("date")));
					text = text.ToLower();
					double value = method_2(session, args, ref runningNode, 1, 1)[0].method_43();
					@class = text switch
					{
						"day" => new Class28(TimeSpan.FromDays(value)), 
						"hour" => new Class28(TimeSpan.FromHours(value)), 
						"minute" => new Class28(TimeSpan.FromMinutes(value)), 
						"second" => new Class28(TimeSpan.FromSeconds(value)), 
						"millisecond" => new Class28(TimeSpan.FromMilliseconds(value)), 
						_ => new Class28(TimeSpan.FromMilliseconds(value)), 
					};
					break;
				}
				case 70:
					{
						@class = Class28.smethod_3(method_0(session));
						break;
					}
					IL_22e4:
					@class = new Class28(dateTime2.Date);
					break;
					IL_22cd:
					@class = new Class28(dateTime2.TimeOfDay);
					break;
					IL_22b6:
					@class = new Class28(dateTime2.Year);
					break;
					IL_229f:
					@class = new Class28(dateTime2.Month);
					break;
					IL_2288:
					@class = new Class28(dateTime2.DayOfWeek);
					break;
					IL_2271:
					@class = new Class28(dateTime2.Day);
					break;
					IL_225a:
					@class = new Class28(dateTime2.Hour);
					break;
					IL_2243:
					@class = new Class28(dateTime2.Minute);
					break;
					IL_222c:
					@class = new Class28(dateTime2.Second);
					break;
					IL_22fb:
					@class = new Class28(dateTime2);
					break;
				}
			}
			return @class;
		}
		}
	}

	public virtual Class28 vmethod_8(Class27 class27_0, Class28 class28_0, ref Class14 class14_0)
	{
		Class14 @class = class14_0;
		try
		{
			switch (string_0)
			{
			default:
				class14_0 = this;
				break;
			case "Expression":
			case "E":
			case "Literal":
			case "L":
				break;
			}
			return evaluate(class27_0, class28_0, ref class14_0);
		}
		catch (GException0)
		{
			throw;
		}
		catch (Exception2)
		{
			throw;
		}
		catch (Exception0)
		{
			throw;
		}
		catch (Exception exception_)
		{
			class27_0.method_4(null, exception_, method_0(class27_0));
			return null;
		}
		finally
		{
			class14_0 = @class;
		}
	}

	public virtual void vmethod_9(int int_1)
	{
		if (class15_2 != null)
		{
			class15_2.vmethod_9(int_1);
		}
	}

	public virtual void vmethod_10()
	{
		if (class15_2 != null)
		{
			class15_2.vmethod_10();
		}
	}

	public virtual void vmethod_11(Class28 class28_0)
	{
		if (class15_2 != null)
		{
			class15_2.vmethod_11(class28_0);
		}
	}

	string object.ToString()
	{
		return string.Format("{0} {1}{2}", string_0, string_1, (string_2 != null) ? (":(" + string_2 + ")") : "");
	}

	public Class28 method_12(Class27 class27_0, string string_4)
	{
		return vmethod_3(class27_0, string_4, null);
	}

	[SpecialName]
	public int method_13()
	{
		if (class15_1 == null)
		{
			return 0;
		}
		return class15_1.Length;
	}

	protected void method_14(Class27 class27_0, Class28 class28_0, ref Class14 class14_0, Class28 class28_1, bool bool_0)
	{
		if (bool_0)
		{
			foreach (object item in idictionary_0)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
				if (!(dictionaryEntry.Key as string).StartsWith("__"))
				{
					class28_1.method_28(dictionaryEntry.Key as string, vmethod_2(class27_0, dictionaryEntry.Key as string));
				}
			}
		}
		Class15[] array = class15_1;
		foreach (Class15 @class in array)
		{
			Class28 class28_2 = @class.method_2(class27_0, class28_0, ref class14_0, 1, 1)[0];
			class28_1.method_28(@class.string_0, class28_2);
		}
	}

	public override void vmethod_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement(string_0);
		foreach (object item in idictionary_0)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			xmlWriter_0.WriteAttributeString(dictionaryEntry.Key as string, dictionaryEntry.Value as string);
		}
		if (class15_1 != null)
		{
			Class15[] array = class15_1;
			foreach (Class15 @class in array)
			{
				@class.vmethod_0(xmlWriter_0);
			}
		}
		else if (string_3 != null)
		{
			xmlWriter_0.WriteString(string_3);
		}
		xmlWriter_0.WriteEndElement();
	}

	public override void vmethod_1(Class27 class27_0, StringBuilder stringBuilder_0, int int_1)
	{
		if (class15_2 != null)
		{
			class15_2.vmethod_1(class27_0, stringBuilder_0, int_1);
		}
	}
}
