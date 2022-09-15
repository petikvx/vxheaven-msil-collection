using System;
using System.Collections;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Xml;

internal class Class1 : Class0
{
	public Class1 class1_0;

	private Class1[] class1_1;

	protected string string_3;

	public Class1 class1_2;

	public Class1()
	{
	}

	public Class1(Class0 class0_0)
		: base(class0_0)
	{
		class1_2 = class0_0 as Class1;
	}

	public Class1(Class0 class0_0, XmlNode xmlNode_0)
		: base(class0_0, xmlNode_0)
	{
		class1_2 = class0_0 as Class1;
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
			Class1 @class = null;
			Class1 class2 = null;
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				if (GClass1.smethod_2(childNode))
				{
					continue;
				}
				if (class2 != null)
				{
					if (@class != null)
					{
						@class.class1_0 = class2;
					}
					@class = class2;
				}
				class2 = Class12.smethod_0(this, childNode) as Class1;
				if (class2 != null)
				{
					arrayList.Add(class2);
				}
			}
			if (@class != null)
			{
				@class.class1_0 = class2;
			}
			class1_1 = arrayList.ToArray(typeof(Class1)) as Class1[];
		}
		else
		{
			string_3 = xmlNode_0.Value;
		}
	}

	protected Class14[] method_0(Class13 class13_0, Class14 class14_0, params Class1[] class1_3)
	{
		return method_2(class13_0, class14_0, class1_3.Length, class1_3.Length, class1_3);
	}

	protected Class14[] method_1(Class13 class13_0, Class14 class14_0, int int_0, int int_1)
	{
		return method_2(class13_0, class14_0, int_0, int_1, class1_1);
	}

	protected Class14[] method_2(Class13 class13_0, Class14 class14_0, int int_0, int int_1, params Class1[] class1_3)
	{
		int num = 0;
		ArrayList arrayList = new ArrayList(int_1);
		foreach (Class1 @class in class1_3)
		{
			if (arrayList.Count == int_1)
			{
				break;
			}
			if (@class == null)
			{
				arrayList.Add(Class14.smethod_1());
				continue;
			}
			Class14 class2 = @class.vmethod_7(class13_0, class14_0);
			arrayList.Add((class2 != null) ? class2 : Class14.smethod_1());
			num++;
		}
		while (arrayList.Count < int_0)
		{
			arrayList.Add(Class14.smethod_1());
		}
		return arrayList.ToArray(typeof(Class14)) as Class14[];
	}

	public virtual Class14 vmethod_1(Class13 class13_0, string string_4)
	{
		return vmethod_2(class13_0, string_4, Class14.smethod_1());
	}

	public virtual Class14 vmethod_2(Class13 class13_0, string string_4, Class14 class14_0)
	{
		if (hashtable_0.ContainsKey(string_4))
		{
			return class13_0.method_13(hashtable_0[string_4] as string);
		}
		return class14_0;
	}

	public virtual string vmethod_3(string string_4)
	{
		return vmethod_4(string_4, null);
	}

	public virtual string vmethod_4(string string_4, string string_5)
	{
		if (hashtable_0.ContainsKey(string_4))
		{
			return hashtable_0[string_4] as string;
		}
		return string_5;
	}

	protected virtual Class1 vmethod_5(int int_0)
	{
		if (int_0 >= method_10())
		{
			return null;
		}
		return class1_1[int_0];
	}

	protected virtual Class1[] vmethod_6(int int_0, int int_1)
	{
		if (int_1 == 0)
		{
			return null;
		}
		Class1[] array = new Class1[int_1];
		Array.Copy(class1_1, 0, array, 0, Math.Min(Math.Min(method_10(), int_1), Math.Max(int_0, method_10())));
		return array;
	}

	protected void method_3(Class14 class14_0, bool bool_0)
	{
		if (class14_0 == null)
		{
			return;
		}
		for (int i = 0; i < class14_0.method_5(); i++)
		{
			if (!class14_0.method_25(i).method_1())
			{
				if (class14_0.method_25(i).method_2())
				{
					class14_0.method_26(i, Class14.smethod_3((!bool_0) ? Regex.Escape(class14_0.method_25(i).System_002EObject_002EToString()) : Regex.Escape(class14_0.method_25(i).System_002EObject_002EToString())));
				}
				else
				{
					method_3(class14_0.method_25(i), bool_0);
				}
			}
		}
	}

	protected void method_4(Class14 class14_0, bool bool_0)
	{
		if (class14_0 == null)
		{
			return;
		}
		for (int i = 0; i < class14_0.method_5(); i++)
		{
			if (!class14_0.method_25(i).method_1())
			{
				if (class14_0.method_25(i).method_2())
				{
					class14_0.method_26(i, Class14.smethod_3((!bool_0) ? HttpUtility.HtmlEncode(class14_0.method_25(i).System_002EObject_002EToString()) : HttpUtility.HtmlDecode(class14_0.method_25(i).System_002EObject_002EToString())));
				}
				else
				{
					method_4(class14_0.method_25(i), bool_0);
				}
			}
		}
	}

	protected void method_5(Class14 class14_0, bool bool_0)
	{
		if (class14_0 == null)
		{
			return;
		}
		for (int i = 0; i < class14_0.method_5(); i++)
		{
			if (!class14_0.method_25(i).method_1())
			{
				if (class14_0.method_25(i).method_2())
				{
					class14_0.method_26(i, Class14.smethod_3((!bool_0) ? HttpUtility.UrlEncode(class14_0.method_25(i).System_002EObject_002EToString()) : HttpUtility.UrlDecode(class14_0.method_25(i).System_002EObject_002EToString())));
				}
				else
				{
					method_5(class14_0.method_25(i), bool_0);
				}
			}
		}
	}

	protected void method_6(Class14 class14_0, bool bool_0)
	{
		if (class14_0 == null)
		{
			return;
		}
		for (int i = 0; i < class14_0.method_5(); i++)
		{
			if (!class14_0.method_25(i).method_1())
			{
				if (class14_0.method_25(i).method_2())
				{
					class14_0.method_26(i, Class14.smethod_3(bool_0 ? class14_0.method_25(i).System_002EObject_002EToString().ToLower() : class14_0.method_25(i).System_002EObject_002EToString().ToUpper()));
				}
				else
				{
					method_6(class14_0.method_25(i), bool_0);
				}
			}
		}
	}

	protected void method_7(Class14 class14_0, bool bool_0)
	{
		if (class14_0 == null)
		{
			return;
		}
		for (int i = 0; i < class14_0.method_5(); i++)
		{
			if (!class14_0.method_25(i).method_1())
			{
				if (class14_0.method_25(i).method_2())
				{
					class14_0.method_26(i, Class14.smethod_3(bool_0 ? Class24.encoding_0.GetString(Convert.FromBase64String(class14_0.method_25(i).System_002EObject_002EToString())) : Convert.ToBase64String(Class24.encoding_0.GetBytes(class14_0.method_25(i).System_002EObject_002EToString()))));
				}
				else
				{
					method_7(class14_0.method_25(i), bool_0);
				}
			}
		}
	}

	protected void method_8(Class14 class14_0, bool bool_0)
	{
		if (class14_0 == null)
		{
			return;
		}
		for (int i = 0; i < class14_0.method_5(); i++)
		{
			if (!class14_0.method_25(i).method_1())
			{
				if (class14_0.method_25(i).method_2())
				{
					class14_0.method_26(i, Class14.smethod_3(bool_0 ? GClass1.smethod_12(class14_0.method_25(i).System_002EObject_002EToString()) : GClass1.smethod_11(class14_0.method_25(i).System_002EObject_002EToString())));
				}
				else
				{
					method_8(class14_0.method_25(i), bool_0);
				}
			}
		}
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected virtual Class14 evaluate(Class13 session, Class14 args)
	{
		if (Class50.hashtable_0 == null)
		{
			Class50.hashtable_0 = new Hashtable(22, 0.5f)
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
			if (Class50.hashtable_1 == null)
			{
				Class50.hashtable_1 = new Hashtable(134, 0.5f)
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
					{ "StringLength", 58 },
					{ "GetHttpHeader", 59 },
					{ "GetCookies", 60 },
					{ "SetCookie", 61 },
					{ "Now", 62 },
					{ "DateTimeDiff", 63 },
					{ "DateTimePart", 64 },
					{ "DateTimeAdd", 65 },
					{ "ToTimeSpan", 66 }
				};
			}
		}
		switch (string_0)
		{
		case "Literal":
		case "L":
			return Class14.smethod_3(string_3);
		case "Expression":
		case "E":
			return session.method_13(string_3);
		default:
		{
			Class14 @class = null;
			object key;
			if ((key = string_0) != null && (key = Class50.hashtable_1[key]) != null)
			{
				DateTime dateTime2;
				switch ((int)key)
				{
				case 0:
				{
					TimeSpan timeSpan2 = GClass1.smethod_6(Class14.smethod_2(vmethod_1(session, "duration")), TimeSpan.Zero);
					if (timeSpan2 != TimeSpan.Zero)
					{
						if (GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "random", Class14.smethod_3("false"))), bool_0: false))
						{
							int num2 = (int)timeSpan2.TotalMilliseconds;
							num2 = session.random_0.Next((int)((double)num2 * 0.65), (int)((double)num2 * 1.35));
							timeSpan2 = TimeSpan.FromMilliseconds(num2);
						}
						if (timeSpan2 != TimeSpan.Zero)
						{
							Thread.Sleep(timeSpan2);
						}
					}
					@class = new Class14(timeSpan2);
					break;
				}
				case 1:
				{
					bool flag3 = false;
					string text15 = Class14.smethod_2(vmethod_2(session, "yesProbability", null));
					if (text15 == null)
					{
						text15 = Class14.smethod_2(vmethod_2(session, "noProbability", null));
						flag3 = true;
					}
					double num3 = ((text15 != null) ? GClass1.smethod_4(text15, 0.5) : 0.5);
					if (num3 < 0.0 || num3 > 1.0)
					{
						num3 = 0.5;
					}
					if (flag3)
					{
						num3 = 1.0 - num3;
					}
					@class = new Class14(session.random_0.NextDouble() < num3);
					break;
				}
				case 2:
				{
					Class14[] array = method_1(session, args, 1, method_10());
					if (array.Length == 1)
					{
						int num10 = array[0].method_5();
						if (num10 > 0)
						{
							@class = array[0].method_25(session.random_0.Next(0, num10 - 1));
						}
					}
					else
					{
						int num11 = array.Length;
						if (num11 > 0)
						{
							@class = array[session.random_0.Next(0, num11 - 1)];
						}
					}
					break;
				}
				case 3:
					if (string_1 != null)
					{
						bool bool_ = GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "isServerApi", Class14.smethod_3("false"))), bool_0: false);
						@class = session.method_16(string_1, bool_);
					}
					break;
				case 4:
				case 5:
				{
					string text20 = vmethod_3("var");
					Class14 class14 = ((string_0 == "Set") ? vmethod_2(session, "overwriteIfExists", null) : null);
					if (text20 != null)
					{
						Class14[] array = method_1(session, args, 1, 1);
						if (!text20.StartsWith(":"))
						{
							text20 = ":" + text20;
						}
						if (class14 == null)
						{
							@class = session.method_14(text20, array[0]);
						}
						else if (GClass1.smethod_5(Class14.smethod_2(class14), bool_0: true) || !session.method_12(text20))
						{
							@class = session.method_14(text20, array[0]);
						}
					}
					break;
				}
				case 6:
				{
					@class = new Class14();
					Class14[] array = method_1(session, args, 1, 1);
					array[0].vmethod_4(@class);
					break;
				}
				case 7:
				{
					@class = new Class14();
					for (Class1 class11 = vmethod_5(0); class11 != null; class11 = class11.class1_0)
					{
						if (class11.string_0 == "AddItem")
						{
							string text12 = Class14.smethod_2(class11.vmethod_2(session, "key", null));
							Class14 class14_2 = class11.method_1(session, args, 1, 1)[0];
							if (text12 != null)
							{
								@class.method_11(text12, class14_2);
							}
							else
							{
								@class.method_13(class14_2);
							}
						}
						else if (class11.string_0 == "MergeItem")
						{
							Class14 class14_3 = class11.method_1(session, args, 1, 1)[0];
							@class.method_14(class14_3);
						}
						else
						{
							@class.method_13(method_0(session, args, class11)[0]);
						}
					}
					break;
				}
				case 8:
				{
					Class14[] array = method_1(session, args, 1, 1);
					@class = new Class14(array[0].method_5());
					break;
				}
				case 9:
				{
					Class14 class28 = vmethod_1(session, "array");
					int int_ = GClass1.smethod_3(Class14.smethod_2(vmethod_1(session, "index")), 0);
					@class = Class14.smethod_3(class28.method_44(int_));
					break;
				}
				case 10:
				{
					Class14 class22 = vmethod_1(session, "keys");
					Class14 class23 = vmethod_1(session, "values");
					@class = new Class14();
					for (int k = 0; k < class22.method_5(); k++)
					{
						@class.method_11(Class14.smethod_2(class22.method_25(k)), class23.method_25(k));
					}
					break;
				}
				case 11:
				{
					@class = new Class14();
					int num6 = GClass1.smethod_3(Class14.smethod_2(vmethod_1(session, "start")), 0);
					int num7 = GClass1.smethod_3(Class14.smethod_2(vmethod_1(session, "step")), 1);
					int num8 = GClass1.smethod_3(Class14.smethod_2(vmethod_1(session, "count")), 1);
					int num9 = num6;
					for (int j = 0; j < num8; j++)
					{
						@class.method_10(num9);
						num9 += num7;
					}
					break;
				}
				case 12:
				{
					Class14 class10 = vmethod_1(session, "array");
					string text11 = Class14.smethod_2(vmethod_1(session, "key"));
					@class = ((text11 == null) ? class10 : class10.method_27(text11));
					break;
				}
				case 13:
				{
					Class14 class4 = vmethod_1(session, "array");
					string text4 = Class14.smethod_2(vmethod_1(session, "keys"));
					if (text4 != null)
					{
						string text5 = Class14.smethod_2(vmethod_2(session, "keySeparator", Class14.smethod_3(";")));
						bool flag = GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "discardKeys", Class14.smethod_3("false"))), bool_0: false);
						string[] array3 = text4.Split(text5.ToCharArray());
						@class = new Class14();
						string[] array4 = array3;
						foreach (string text6 in array4)
						{
							if (!flag)
							{
								@class.method_13(class4.method_27(text6));
							}
							else
							{
								@class.method_11(text6, class4.method_27(text6));
							}
						}
					}
					else
					{
						@class = new Class14();
					}
					break;
				}
				case 14:
				{
					@class = vmethod_1(session, "array");
					string text26 = Class14.smethod_2(vmethod_2(session, "key", null));
					Class14[] array = method_1(session, args, 1, 1);
					if (text26 != null)
					{
						@class.method_11(text26, array[0]);
					}
					else
					{
						@class.method_13(array[0]);
					}
					break;
				}
				case 15:
				{
					@class = vmethod_1(session, "array");
					Class14[] array = method_1(session, args, 0, method_10());
					Class14[] array2 = array;
					foreach (Class14 class14_ in array2)
					{
						@class.method_14(class14_);
					}
					break;
				}
				case 16:
				{
					@class = vmethod_1(session, "array");
					string text24 = Class14.smethod_2(vmethod_1(session, "key"));
					@class.method_16(text24);
					break;
				}
				case 17:
				{
					RegexOptions regexOptions = RegexOptions.None;
					if (hashtable_0.Count > 0)
					{
						if (GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "caseInsensitive", null)), (session.regexOptions_0 & RegexOptions.IgnoreCase) != 0))
						{
							regexOptions |= RegexOptions.IgnoreCase;
						}
						if (GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "explicitCapture", null)), (session.regexOptions_0 & RegexOptions.ExplicitCapture) != 0))
						{
							regexOptions |= RegexOptions.ExplicitCapture;
						}
						if (GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "ignorePatternWhitespace", null)), (session.regexOptions_0 & RegexOptions.IgnorePatternWhitespace) != 0))
						{
							regexOptions |= RegexOptions.IgnorePatternWhitespace;
						}
						if (GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "multiline", null)), (session.regexOptions_0 & RegexOptions.Multiline) != 0))
						{
							regexOptions |= RegexOptions.Multiline;
						}
						if (GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "singleLine", null)), (session.regexOptions_0 & RegexOptions.Singleline) != 0))
						{
							regexOptions |= RegexOptions.Singleline;
						}
						if (GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "rightToLeft", null)), (session.regexOptions_0 & RegexOptions.RightToLeft) != 0))
						{
							regexOptions |= RegexOptions.RightToLeft;
						}
					}
					else
					{
						Class14[] array = method_1(session, args, 0, 1);
						regexOptions = ((array.Length <= 0) ? session.regexOptions_0 : ((RegexOptions)GClass1.smethod_3(Class14.smethod_2(array[0]), (int)session.regexOptions_0)));
					}
					@class = new Class14(session.regexOptions_0 = regexOptions);
					break;
				}
				case 18:
				{
					Class14[] array = method_1(session, args, 0, method_10());
					Class14[] array2 = array;
					foreach (Class14 class26 in array2)
					{
						method_3(@class = class26, bool_0: false);
					}
					break;
				}
				case 19:
				{
					Class14[] array = method_1(session, args, 0, method_10());
					Class14[] array2 = array;
					foreach (Class14 class21 in array2)
					{
						method_3(@class = class21, bool_0: true);
					}
					break;
				}
				case 20:
				{
					Class14[] array = method_1(session, args, 0, method_10());
					Class14[] array2 = array;
					foreach (Class14 class27 in array2)
					{
						method_7(@class = class27, bool_0: false);
					}
					break;
				}
				case 21:
				{
					Class14[] array = method_1(session, args, 0, method_10());
					Class14[] array2 = array;
					foreach (Class14 class20 in array2)
					{
						method_7(@class = class20, bool_0: true);
					}
					break;
				}
				case 22:
				{
					Class14[] array = method_1(session, args, 0, method_10());
					Class14[] array2 = array;
					foreach (Class14 class17 in array2)
					{
						method_8(@class = class17, bool_0: false);
					}
					break;
				}
				case 23:
				{
					Class14[] array = method_1(session, args, 0, method_10());
					Class14[] array2 = array;
					foreach (Class14 class13 in array2)
					{
						method_8(@class = class13, bool_0: true);
					}
					break;
				}
				case 24:
				{
					string text13 = Class14.smethod_2(vmethod_1(session, "search"));
					if (text13 != null)
					{
						Class14[] array = method_1(session, args, 1, 1);
						string text14 = Class14.smethod_2(array[0]);
						if (text14 != null)
						{
							@class = new Class14(text14.IndexOf(text13));
						}
					}
					break;
				}
				case 25:
				{
					Class14[] array = method_1(session, args, 0, 1);
					@class = new Class14(array[0].method_1() || array[0].System_002EObject_002EToString() == "");
					break;
				}
				case 26:
				{
					Class1 class29 = vmethod_5(0);
					Class1 class30 = vmethod_5(1);
					method_0(session, args, class29);
					@class = new Class14((class29 != null && method_0(session, args, class29)[0].method_41()) || (class30 != null && method_0(session, args, class30)[0].method_41()));
					break;
				}
				case 27:
				{
					Class1 class24 = vmethod_5(0);
					Class1 class25 = vmethod_5(1);
					method_0(session, args, class24);
					@class = new Class14(class24 != null && method_0(session, args, class24)[0].method_41() && class25 != null && method_0(session, args, class25)[0].method_41());
					break;
				}
				case 28:
				{
					Class14[] array = method_1(session, args, 1, 1);
					@class = new Class14(!array[0].method_41());
					break;
				}
				case 29:
				{
					Class14[] array = method_1(session, args, 2, 2);
					@class = ((!GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "number", Class14.smethod_3("false"))), bool_0: false)) ? new Class14(Class14.smethod_2(array[0]) == Class14.smethod_2(array[1])) : new Class14(array[0].method_43() == array[1].method_43()));
					break;
				}
				case 30:
				{
					Class14[] array = method_1(session, args, 2, 2);
					@class = new Class14(array[0].method_43() < array[1].method_43());
					break;
				}
				case 31:
				{
					Class14[] array = method_1(session, args, 2, 2);
					@class = new Class14(array[0].method_43() > array[1].method_43());
					break;
				}
				case 32:
				{
					Class14[] array = method_1(session, args, 2, 2);
					@class = new Class14(array[0].method_43() + array[1].method_43());
					break;
				}
				case 33:
				{
					Class14[] array = method_1(session, args, 2, 2);
					@class = new Class14(array[0].method_43() * array[1].method_43());
					break;
				}
				case 34:
				{
					Class14[] array = method_1(session, args, 2, 2);
					@class = new Class14(array[0].method_43() / array[1].method_43());
					break;
				}
				case 35:
				{
					Class14[] array = method_1(session, args, 1, 1);
					@class = new Class14(0.0 - array[0].method_43());
					break;
				}
				case 36:
				{
					bool flag4 = GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "integer", Class14.smethod_3("false"))), bool_0: false);
					double num4 = GClass1.smethod_4(Class14.smethod_2(vmethod_2(session, "min", Class14.smethod_3("0"))), 0.0);
					double num5 = GClass1.smethod_4(Class14.smethod_2(vmethod_2(session, "max", Class14.smethod_3("1"))), 1.0);
					@class = ((!flag4) ? new Class14(num4 + (num5 - num4) * session.random_0.NextDouble()) : new Class14(session.random_0.Next((int)num4, (int)num5)));
					break;
				}
				case 37:
					@class = new Class14((long)Math.Round(method_1(session, args, 1, 1)[0].method_43()));
					break;
				case 38:
					@class = new Class14((long)Math.Floor(method_1(session, args, 1, 1)[0].method_43()));
					break;
				case 39:
				{
					string text19 = Class14.smethod_2(vmethod_1(session, "var"));
					if (text19 != "")
					{
						@class = session.method_11(text19);
					}
					break;
				}
				case 40:
				{
					string text18 = Class14.smethod_2(vmethod_1(session, "var"));
					if (text18 != "")
					{
						@class = new Class14(session.method_12(text18));
					}
					break;
				}
				case 41:
				{
					Class14[] array = method_1(session, args, 1, 1);
					string text9 = Class14.smethod_2(vmethod_2(session, "separator", Class14.smethod_3(";")));
					bool flag2 = GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "strict", Class14.smethod_3("false"))), bool_0: false);
					string text10 = array[0].System_002EObject_002EToString();
					@class = ((text10 == null) ? Class14.smethod_1() : Class14.smethod_0(flag2 ? ((IEnumerable)Class39.smethod_0(text10, text9)) : ((IEnumerable)text10.Split(text9.ToCharArray()))));
					break;
				}
				case 42:
				{
					Class14[] array = method_1(session, args, 1, method_10());
					Class14[] array2 = array;
					foreach (Class14 class9 in array2)
					{
						method_4(@class = class9, bool_0: false);
					}
					break;
				}
				case 43:
				{
					Class14[] array = method_1(session, args, 1, method_10());
					Class14[] array2 = array;
					foreach (Class14 class8 in array2)
					{
						method_4(@class = class8, bool_0: true);
					}
					break;
				}
				case 44:
				{
					Class14[] array = method_1(session, args, 1, method_10());
					Class14[] array2 = array;
					foreach (Class14 class7 in array2)
					{
						method_5(@class = class7, bool_0: false);
					}
					break;
				}
				case 45:
				{
					Class14[] array = method_1(session, args, 1, method_10());
					Class14[] array2 = array;
					foreach (Class14 class5 in array2)
					{
						method_4(@class = class5, bool_0: true);
					}
					break;
				}
				case 46:
				{
					Class14[] array = method_1(session, args, 1, method_10());
					Class14[] array2 = array;
					foreach (Class14 class6 in array2)
					{
						method_6(@class = class6, bool_0: true);
					}
					break;
				}
				case 47:
				{
					Class14[] array = method_1(session, args, 1, method_10());
					Class14[] array2 = array;
					foreach (Class14 class3 in array2)
					{
						method_6(@class = class3, bool_0: false);
					}
					break;
				}
				case 48:
				{
					Class14[] array = method_1(session, args, 0, method_10());
					string text3 = Class14.smethod_2(vmethod_2(session, "glue", Class14.smethod_3("")));
					@class = Class14.smethod_3(Class39.smethod_1(array, text3));
					break;
				}
				case 49:
				{
					Class14[] array = method_1(session, args, 1, 1);
					string text27 = Class14.smethod_2(vmethod_2(session, "glue", Class14.smethod_3("")));
					string[] ienumerable_ = array[0].method_35(typeof(string)) as string[];
					@class = Class14.smethod_3(Class39.smethod_1(ienumerable_, text27));
					break;
				}
				case 50:
				{
					string text25 = Class14.smethod_2(method_1(session, args, 1, 1)[0]);
					int num12 = vmethod_2(session, "start", Class14.smethod_3("0")).method_42();
					int num13 = vmethod_1(session, "length").method_42();
					if (num12 < 0 && num13 < 0)
					{
						num12 = text25.Length + num13;
						@class = Class14.smethod_3(text25.Substring(num12, -num13));
					}
					else
					{
						num13 = Math.Abs(num13);
						@class = Class14.smethod_3(text25.Substring(num12, num13));
					}
					break;
				}
				case 51:
				{
					Class14[] array = method_1(session, args, 1, 1);
					if (!array[0].method_1())
					{
						session.method_18(Class14.smethod_2(array[0]));
					}
					break;
				}
				case 52:
				{
					Class14[] array = method_1(session, args, 0, 1);
					throw new GException0((array.Length == 0) ? null : array[0]);
				}
				case 53:
				{
					Class14[] array = method_1(session, args, 0, 1);
					vmethod_10((array.Length == 0) ? null : array[0]);
					break;
				}
				case 54:
					if (class1_2 != null)
					{
						Class14[] array = method_1(session, args, 0, 1);
						Class14 class19 = ((array.Length > 0) ? array[0] : new Class14("1"));
						class1_2.vmethod_8(Math.Max(class19.method_42(), 1));
					}
					break;
				case 55:
					if (class1_2 != null)
					{
						class1_2.vmethod_9();
					}
					break;
				case 56:
					try
					{
						Class14[] array = method_1(session, args, 1, 1);
						Uri uri3 = new Uri(Class14.smethod_2(array[0]));
						return new Class14((object)uri3 != null);
					}
					catch
					{
						return new Class14(false);
					}
				case 57:
					try
					{
						Class14[] array = method_1(session, args, 1, 1);
						Uri uri2 = new Uri(Class14.smethod_2(array[0]));
						@class = new Class14();
						@class.method_11("scheme", Class14.smethod_3(uri2.Scheme));
						@class.method_11("host", Class14.smethod_3(uri2.Host));
						@class.method_11("port", Class14.smethod_3(uri2.Port.ToString()));
						@class.method_11("authority", Class14.smethod_3(uri2.Authority));
						@class.method_11("pathandquery", Class14.smethod_3(uri2.PathAndQuery));
						@class.method_11("query", Class14.smethod_3(uri2.Query));
						@class.method_11("userinfo", Class14.smethod_3(uri2.UserInfo));
						@class.method_11("isloopback", Class14.smethod_3(uri2.IsLoopback.ToString()));
						@class.method_11("isfile", Class14.smethod_3(uri2.IsFile.ToString()));
						@class.method_11("fragment", Class14.smethod_3(uri2.Fragment));
						return @class;
					}
					catch
					{
						return @class;
					}
				case 58:
					try
					{
						Class14[] array = method_1(session, args, 1, 1);
						@class = new Class14(array[0].System_002EObject_002EToString().Length);
						return @class;
					}
					catch
					{
						return @class;
					}
				case 59:
				{
					string text22 = vmethod_4("browser", ":BROWSER");
					Class21 class18 = session.method_17(text22);
					string text23 = Class14.smethod_2(vmethod_1(session, "header"));
					if (class18.method_4() != null && text23 != null && text23 != "")
					{
						@class = Class14.smethod_3(class18.method_4().method_7().Headers[text23]);
					}
					break;
				}
				case 60:
				{
					string text21 = vmethod_4("browser", ":BROWSER");
					Class21 class15 = session.method_17(text21);
					string uriString = Class14.smethod_2(vmethod_2(session, "url", Class14.smethod_3((class15.method_4() == null) ? null : class15.method_4().method_11().ToString())));
					if (class15.method_4() == null)
					{
						break;
					}
					CookieCollection cookies = class15.cookieContainer_0.GetCookies(new Uri(uriString));
					@class = new Class14();
					{
						foreach (Cookie item in cookies)
						{
							if (item.Expires > DateTime.Now)
							{
								Class14 class16 = new Class14();
								class16.method_13(Class14.smethod_3(item.Value));
								class16.method_11("DOMAIN", Class14.smethod_3(item.Domain));
								class16.method_11("EXPIRES", new Class14(item.Expires));
								@class.method_11(item.Name, class16);
							}
						}
						return @class;
					}
				}
				case 61:
				{
					string text16 = vmethod_4("browser", ":BROWSER");
					Class21 class12 = session.method_17(text16);
					string text17 = Class14.smethod_2(vmethod_2(session, "url", Class14.smethod_3((class12.method_4() == null) ? null : class12.method_4().method_11().GetLeftPart(UriPartial.Authority))));
					DateTime maxValue = DateTime.MaxValue;
					DateTime expires = GClass1.smethod_7(Class14.smethod_2(vmethod_2(session, "expires", Class14.smethod_3(maxValue.ToString()))), DateTime.MaxValue);
					if (string_1 != null && text17 != null)
					{
						Uri uri = null;
						uri = ((class12.method_4() == null) ? new Uri(text17) : new Uri(class12.method_4().method_11(), text17));
						Cookie cookie = new Cookie(string_1, Class14.smethod_2(method_1(session, args, 1, 1)[0]));
						cookie.Expires = expires;
						class12.cookieContainer_0.Add(uri, cookie);
					}
					break;
				}
				case 62:
					@class = new Class14(DateTime.Now);
					break;
				case 63:
				{
					object obj3 = vmethod_2(session, "to", Class14.smethod_3(DateTime.Now.ToString())).method_39(typeof(DateTime));
					DateTime dateTime3 = ((obj3 == null) ? DateTime.Now : ((DateTime)obj3));
					obj3 = vmethod_1(session, "from").method_39(typeof(DateTime));
					DateTime dateTime4 = ((obj3 == null) ? DateTime.Now : ((DateTime)obj3));
					string text8 = Class14.smethod_2(vmethod_2(session, "unit", Class14.smethod_3("timespan")));
					text8 = text8.ToLower();
					TimeSpan timeSpan = dateTime3 - dateTime4;
					@class = text8 switch
					{
						"timespan" => new Class14(timeSpan), 
						"day" => new Class14(timeSpan.TotalDays), 
						"hour" => new Class14(timeSpan.TotalHours), 
						"minute" => new Class14(timeSpan.TotalMinutes), 
						"second" => new Class14(timeSpan.TotalSeconds), 
						"millisecond" => new Class14(timeSpan.TotalMilliseconds), 
						_ => new Class14(new DateTime(timeSpan.Ticks)), 
					};
					break;
				}
				case 64:
				{
					object obj2 = vmethod_1(session, "date").method_39(typeof(DateTime));
					dateTime2 = ((obj2 == null) ? DateTime.Now : ((DateTime)obj2));
					string text7 = Class14.smethod_2(vmethod_2(session, "part", Class14.smethod_3("millisecond")));
					text7 = text7.ToLower();
					if ((key = text7) != null && (key = Class50.hashtable_0[key]) != null)
					{
						switch ((int)key)
						{
						case 0:
							break;
						case 1:
							goto IL_2074;
						case 2:
							goto IL_208b;
						case 3:
							goto IL_20a2;
						case 4:
							goto IL_20b9;
						case 5:
							goto IL_20d0;
						case 6:
							goto IL_20e7;
						case 7:
							goto IL_20fe;
						case 8:
							goto IL_2115;
						case 9:
							goto IL_212c;
						default:
							goto IL_2143;
						}
						@class = new Class14(dateTime2.Millisecond);
						break;
					}
					goto IL_2143;
				}
				case 65:
				{
					object obj = vmethod_1(session, "date").method_39(typeof(DateTime));
					DateTime dateTime = ((obj == null) ? DateTime.Now : ((DateTime)obj));
					string text2 = Class14.smethod_2(vmethod_2(session, "unit", Class14.smethod_3("millisecond")));
					text2 = text2.ToLower();
					Class14 class2 = method_1(session, args, 1, 1)[0];
					obj = class2.method_39(typeof(TimeSpan));
					TimeSpan value2 = ((obj == null) ? DateTime.Now.TimeOfDay : ((TimeSpan)obj));
					double num = class2.method_43();
					@class = text2 switch
					{
						"timespan" => new Class14(dateTime.Add(value2)), 
						"year" => new Class14(dateTime.AddYears((int)num)), 
						"month" => new Class14(dateTime.AddMonths((int)num)), 
						"day" => new Class14(dateTime.AddDays(num)), 
						"hour" => new Class14(dateTime.AddHours(num)), 
						"minute" => new Class14(dateTime.AddMinutes(num)), 
						"second" => new Class14(dateTime.AddSeconds(num)), 
						"millisecond" => new Class14(dateTime.AddMilliseconds(num)), 
						_ => new Class14(dateTime), 
					};
					break;
				}
				case 66:
					{
						string text = Class14.smethod_2(vmethod_2(session, "unit", Class14.smethod_3("date")));
						text = text.ToLower();
						double value = method_1(session, args, 1, 1)[0].method_43();
						@class = text switch
						{
							"day" => new Class14(TimeSpan.FromDays(value)), 
							"hour" => new Class14(TimeSpan.FromHours(value)), 
							"minute" => new Class14(TimeSpan.FromMinutes(value)), 
							"second" => new Class14(TimeSpan.FromSeconds(value)), 
							"millisecond" => new Class14(TimeSpan.FromMilliseconds(value)), 
							_ => new Class14(TimeSpan.FromMilliseconds(value)), 
						};
						break;
					}
					IL_212c:
					@class = new Class14(dateTime2.Date);
					break;
					IL_2115:
					@class = new Class14(dateTime2.TimeOfDay);
					break;
					IL_20fe:
					@class = new Class14(dateTime2.Year);
					break;
					IL_20e7:
					@class = new Class14(dateTime2.Month);
					break;
					IL_20d0:
					@class = new Class14(dateTime2.DayOfWeek);
					break;
					IL_20b9:
					@class = new Class14(dateTime2.Day);
					break;
					IL_20a2:
					@class = new Class14(dateTime2.Hour);
					break;
					IL_208b:
					@class = new Class14(dateTime2.Minute);
					break;
					IL_2074:
					@class = new Class14(dateTime2.Second);
					break;
					IL_2143:
					@class = new Class14(dateTime2);
					break;
				}
			}
			return @class;
		}
		}
	}

	public virtual Class14 vmethod_7(Class13 class13_0, Class14 class14_0)
	{
		try
		{
			return evaluate(class13_0, class14_0);
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
		catch (Exception innerException)
		{
			class13_0.method_2(null, new Exception($"Exception in node {System_002EObject_002EToString()}.", innerException));
			return null;
		}
	}

	public virtual void vmethod_8(int int_0)
	{
		if (class1_2 != null)
		{
			class1_2.vmethod_8(int_0);
		}
	}

	public virtual void vmethod_9()
	{
		if (class1_2 != null)
		{
			class1_2.vmethod_9();
		}
	}

	public virtual void vmethod_10(Class14 class14_0)
	{
		if (class1_2 != null)
		{
			class1_2.vmethod_10(class14_0);
		}
	}

	string object.ToString()
	{
		return string.Format("{0}{2}", string_0, string_1, (string_2 != null) ? (":(" + string_2 + ")") : "");
	}

	public Class14 method_9(Class13 class13_0, string string_4)
	{
		return vmethod_2(class13_0, string_4, null);
	}

	[SpecialName]
	public int method_10()
	{
		if (class1_1 == null)
		{
			return 0;
		}
		return class1_1.Length;
	}

	protected void method_11(Class13 class13_0, Class14 class14_0, Class14 class14_1, bool bool_0)
	{
		if (bool_0)
		{
			foreach (object item in hashtable_0)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
				if (!(dictionaryEntry.Key as string).StartsWith("__"))
				{
					class14_1.method_28(dictionaryEntry.Key as string, vmethod_1(class13_0, dictionaryEntry.Key as string));
				}
			}
		}
		Class1[] array = class1_1;
		foreach (Class1 @class in array)
		{
			Class14 class14_2 = @class.method_1(class13_0, class14_0, 1, 1)[0];
			class14_1.method_28(@class.string_0, class14_2);
		}
	}

	public override void vmethod_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement(string_0);
		foreach (object item in hashtable_0)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			xmlWriter_0.WriteAttributeString(dictionaryEntry.Key as string, dictionaryEntry.Value as string);
		}
		if (class1_1 != null)
		{
			Class1[] array = class1_1;
			foreach (Class1 @class in array)
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
}
