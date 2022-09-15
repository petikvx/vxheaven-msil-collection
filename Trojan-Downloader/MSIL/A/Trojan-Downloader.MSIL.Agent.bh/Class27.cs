using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

internal class Class27
{
	public RegexOptions regexOptions_0 = RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.ExplicitCapture | RegexOptions.Singleline;

	protected Class29 class29_0;

	protected Class29 class29_1;

	protected IDictionary idictionary_0 = new Hashtable();

	public ArrayList arrayList_0 = new ArrayList();

	public Stack stack_0 = new Stack();

	public Class14 class14_0 = null;

	protected Stack stack_1 = new Stack();

	public Class26 class26_0;

	public Class25 class25_0;

	public Random random_0 = new Random();

	public bool bool_0 = false;

	public Class8 class8_0 = null;

	protected Class5 class5_0;

	public ArrayList arrayList_1 = new ArrayList();

	public Enum3 enum3_0 = Enum3.Error;

	public TimeSpan timeSpan_0;

	public Class27(Class26 class26_1, Class25 class25_1)
	{
		class26_0 = class26_1;
		class29_0 = new Class29(class26_0, null, null, ":", null, random_0);
		class29_1 = new Class29(class26_0, null, class29_0, "::", ":", random_0);
		class29_0.class29_1 = class29_1;
		if (class26_0.class25_0 != null)
		{
			class26_0.class25_0.method_10(ref class29_0.class28_0);
		}
		class25_0 = class25_1;
		if (class25_0 != null)
		{
			class25_0.method_10(ref class29_0.class28_0);
		}
		if (class25_0 != null)
		{
			method_20(":BROWSER", bool_1: false);
			class8_0 = method_21(":BROWSER");
		}
		method_18(":__SERVER", Class28.smethod_3(class26_0.class11_0.class40_1.method_9(" ")));
		method_18(":__LASTCONFIG", new Class28(class26_0.class11_0.dateTime_5));
		method_18(":__COUNTRY", new Class28(class26_0.class11_0.string_1));
	}

	public Class19 method_0()
	{
		return method_1(0);
	}

	public Class19 method_1(int int_0)
	{
		object[] array = stack_0.ToArray();
		object obj = ((int_0 < array.Length) ? array[int_0] : null);
		if (obj != null)
		{
			return (Class19)obj;
		}
		return null;
	}

	public void method_2(string string_0, string string_1, string string_2, string string_3)
	{
		Class13 @class = new Class13();
		@class.string_0 = ((class5_0 != null) ? class5_0.string_0 : null);
		@class.string_1 = ((class5_0 != null) ? class5_0.method_0().string_0 : null);
		@class.string_2 = ((class8_0 != null) ? null : class8_0.string_1);
		@class.string_3 = ((string_0 != null) ? string_0 : ((class8_0 == null || class8_0.method_6() == null) ? null : Class51.smethod_8(class8_0.method_6().method_11())));
		@class.int_0 = 0;
		@class.dateTime_0 = DateTime.Now;
		@class.string_4 = string_1;
		@class.string_5 = string_2;
		if (string_3 != null)
		{
			@class.string_5 = @class.string_5 + "\r\n\r\nLingo Callstack:\r\n----------------\r\n" + string_3;
		}
		arrayList_1.Add(@class);
	}

	public void method_3(string string_0, string string_1, string string_2)
	{
		method_2(string_0, null, string_1, string_2);
	}

	public void method_4(string string_0, Exception exception_0, string string_1)
	{
		method_2(string_0, Class51.smethod_8(((object)exception_0).GetType()), Class51.smethod_8(exception_0), string_1);
	}

	public Class17 method_5(string string_0)
	{
		if (string_0.IndexOf(".") == -1)
		{
			Class17 @class = null;
			if (class25_0 != null)
			{
				@class = class25_0.method_6(string_0);
			}
			if (@class == null && class26_0.class25_0 != null)
			{
				@class = class26_0.class25_0.method_6(string_0);
			}
			return @class;
		}
		string[] array = string_0.Split(new char[1] { '.' });
		return class26_0.method_4(array[0]).method_6(array[1]);
	}

	protected void method_6(Class28 class28_0, IDictionary idictionary_1)
	{
		foreach (object item in idictionary_1)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			if (dictionaryEntry.Value is string)
			{
				class28_0.method_11(dictionaryEntry.Key as string, Class28.smethod_3(dictionaryEntry.Value as string));
				continue;
			}
			Class28 class28_ = new Class28();
			class28_0.method_11(dictionaryEntry.Key as string, class28_);
			method_6(class28_, dictionaryEntry.Value as IDictionary);
		}
	}

	public Class28 method_7(Class15 class15_0, Class28 class28_0)
	{
		Class14 @class = null;
		return class15_0.vmethod_8(this, class28_0, ref @class);
	}

	public Enum3 method_8(Class28 class28_0, Class5 class5_1)
	{
		string text = null;
		if (bool_0)
		{
			return Enum3.Error;
		}
		try
		{
			bool_0 = true;
			Class47.smethod_12();
			class5_0 = class5_1;
			if (class28_0 == null)
			{
				class28_0 = new Class28();
			}
			Class28 @class = new Class28();
			@class.method_11("NAME", Class28.smethod_3(class5_0.string_0));
			@class.method_11("OWNER", Class28.smethod_3(class5_0.string_1));
			@class.method_11("CLICKTHROUGHCOUNT", new Class28(class5_0.int_2));
			@class.method_11("LASTVISITDATE", new Class28(class5_0.dateTime_0));
			@class.method_11("SUCCESSCOUNT", new Class28(class5_0.int_0));
			@class.method_11("FAILURECOUNT", new Class28(class5_0.int_1));
			@class.method_11("CLICKTHROUGHRATE", new Class28(class5_0.method_1()));
			@class.method_11("KEYWORDS", Class28.smethod_0(class5_0.string_2));
			foreach (object item in class5_0.idictionary_0)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
				@class.method_11(dictionaryEntry.Key as string, Class28.smethod_3(dictionaryEntry.Value as string));
			}
			class28_0.method_11("DOMAIN", @class);
			Class33 class2 = class5_0.method_5();
			@class = new Class28();
			@class.method_11("ID", Class28.smethod_3(class2.string_0));
			@class.method_11("LASTVISITDATE", new Class28(class2.dateTime_0));
			class28_0.method_11("ACCOUNT", @class);
			Class34 class3 = class5_0.method_0();
			Class28 class4 = new Class28();
			class4.method_11("LASTVISITDATE", new Class28(class3.dateTime_0));
			class4.method_11("SUCCESSCOUNT", new Class28(class3.int_0));
			class4.method_11("FAILURECOUNT", new Class28(class3.int_1));
			class4.method_11("CLICKTHROUGHCOUNT", new Class28(class3.int_2));
			class4.method_11("TYPEINRATIO", new Class28(class3.double_0));
			class4.method_11("NAME", Class28.smethod_3(class3.string_0));
			Class28 class5 = new Class28();
			Class6[] class6_ = class3.class6_0;
			foreach (Class6 class6 in class6_)
			{
				Class28 class7 = new Class28();
				class7.method_11("DwellTime", new Class28(class3.timeSpan_3));
				class7.method_11("ID", Class28.smethod_3(class6.string_0));
				method_6(class7, class6.idictionary_0);
				if (class6.class7_0 != null && class6.class7_0.Length > 0)
				{
					Class28 class8 = new Class28();
					class7.method_11("RESOURCES", class8);
					Class7[] class7_ = class6.class7_0;
					foreach (Class7 class9 in class7_)
					{
						Class28 class10 = new Class28();
						class8.method_13(class10);
						class10.method_11("ACTION", new Class28(class9.enum1_0));
						class10.method_11("TAG", Class28.smethod_3(class9.string_0));
						class10.method_11("ATTRIBUTE", Class28.smethod_3(class9.string_1));
						class10.method_11("MAX", new Class28(class9.int_0));
						class10.method_11("PATTERN", Class28.smethod_3(class9.string_2));
					}
				}
				class5.method_13(class7);
			}
			class4.method_11("PROCESSINGINFO", class5);
			class28_0.method_11("HOSTS", class4);
			class28_0.method_11("PARKINGS", class4);
			Class17 class11 = class25_0.method_11();
			method_18(":__CATEGORYDWELLTIME", new Class28(TimeSpan.Zero));
			method_18(":__ADDWELLTIME", new Class28(TimeSpan.Zero));
			if (class11 != null)
			{
				text = Class28.smethod_2(class11.vmethod_8(this, class28_0, ref class14_0));
			}
			if (text != null)
			{
				try
				{
					enum3_0 = (Enum3)Enum.Parse(typeof(Enum3), text, ignoreCase: true);
				}
				catch
				{
					method_3(null, $"Unknown visit outcome '{text}'.", class11.method_0(this));
				}
			}
		}
		catch (GException0 gException)
		{
			text = Class51.smethod_8(gException.object_0);
		}
		finally
		{
			bool_0 = false;
			timeSpan_0 = Class47.smethod_14();
		}
		return enum3_0;
	}

	[SpecialName]
	public TimeSpan method_9()
	{
		string string_ = Class28.smethod_2(method_17(":__CATEGORYDWELLTIME"));
		string string_2 = Class28.smethod_2(method_17(":__ADDWELLTIME"));
		return Class51.smethod_12(string_, TimeSpan.Zero).Add(Class51.smethod_12(string_2, TimeSpan.Zero));
	}

	[SpecialName]
	public void method_10(TimeSpan timeSpan_1)
	{
		method_18(":__ADDWELLTIME", Class28.smethod_3(Class51.smethod_5(timeSpan_1)));
	}

	public void method_11(Class28 class28_0)
	{
		class29_1.class28_0.vmethod_4(class28_0);
	}

	public void method_12(Class28 class28_0)
	{
		stack_1.Push(class29_1);
		class29_1 = new Class29(class26_0, null, class29_0, "::", ":", random_0);
		class29_0.class29_1 = class29_1;
		if (class28_0 != null)
		{
			class29_1.method_15(class28_0);
		}
		method_18("::__LASTRETURN", Class28.smethod_1());
	}

	public Class28 method_13()
	{
		Class28 class28_ = class29_1.class28_0;
		class29_1 = stack_1.Pop() as Class29;
		class29_0.class29_1 = class29_1;
		return class28_;
	}

	public Class28 method_14(string string_0)
	{
		return class29_1.method_9(string_0);
	}

	public bool method_15(string string_0)
	{
		return class29_1.method_10(string_0);
	}

	public Class28 method_16(Class28 class28_0, int int_0)
	{
		return class29_1.method_11(class28_0, int_0);
	}

	public Class28 method_17(string string_0)
	{
		return class29_1.method_13(string_0);
	}

	public Class28 method_18(string string_0, Class28 class28_0)
	{
		return class29_1.method_14(string_0, class28_0);
	}

	protected string method_19(string string_0, out string string_1)
	{
		string_1 = null;
		if (string_0 == null)
		{
			return null;
		}
		string_0 = class29_1.method_5(string_0);
		if (string_0.StartsWith("{"))
		{
			string_0 = string_0.Substring(1, string_0.Length - 2);
		}
		if (string_0.StartsWith("::"))
		{
			string_0 = string_0.Substring(1, string_0.Length - 1);
		}
		else if (!string_0.StartsWith(":"))
		{
			string_0 = ":" + string_0;
		}
		string_1 = string_0.Substring(1, string_0.Length - 1);
		return string_0;
	}

	public Class28 method_20(string string_0, bool bool_1)
	{
		string_0 = method_19(string_0, out var _);
		if (idictionary_0.Contains(string_0))
		{
			return method_17(string_0);
		}
		Class8 @class = class26_0.class11_0.method_30(bool_1);
		idictionary_0.Add(string_0, @class);
		Class28 class2 = method_18(string_0, Class28.smethod_1());
		class2.method_11("PROXYNAME", Class28.smethod_3(@class.string_1));
		class2.method_11("USERAGENT", Class28.smethod_3(@class.string_0));
		return class2;
	}

	public Class8 method_21(string string_0)
	{
		string_0 = method_19(string_0, out var _);
		if (!idictionary_0.Contains(string_0))
		{
			if (method_20(string_0, bool_1: false) != null)
			{
				return method_21(string_0);
			}
			return null;
		}
		return idictionary_0[string_0] as Class8;
	}

	public void method_22(string string_0, string string_1, params object[] object_0)
	{
		string text = Class28.smethod_2(method_17(":__ERROR_URL"));
		method_2((text == "") ? null : text, "LingoError", string.Format(string_1, object_0), string_0);
	}

	[SpecialName]
	public string method_23()
	{
		return Class28.smethod_2(method_15(":__PAGEPROCESSOR") ? method_17(":__PAGEPROCESSOR") : null);
	}

	public Class28 method_24(string string_0, bool bool_1)
	{
		string_0 = method_19(string_0, out var _);
		Class8 @class = method_21(string_0);
		Class28 class28_ = method_17(string_0);
		return method_25(class28_, @class.method_6(), bool_1);
	}

	public Class28 method_25(Class28 class28_0, Class32 class32_0, bool bool_1)
	{
		if (class32_0 != null)
		{
			class28_0.method_28("URL", new Class28(class32_0.method_11()));
			class28_0.method_28("REFERRER", Class28.smethod_3(class32_0.method_0().method_0().Referer));
			class28_0.method_28("STATUS", new Class28(class32_0.method_10()));
			class28_0.method_28("SUCCESS", new Class28((class32_0.method_10() >= 200 && class32_0.method_10() <= 303) || class32_0.method_10() == 307));
			class28_0.method_28("REQUEST_TIMESTAMP", new Class28(class32_0.method_0().dateTime_0));
			class28_0.method_28("RESPONSE_TIMESTAMP", new Class28(class32_0.dateTime_0));
			if (bool_1)
			{
				class28_0.method_28("PAYLOAD", Class28.smethod_3(class32_0.method_4()));
			}
			return class28_0;
		}
		return null;
	}
}
