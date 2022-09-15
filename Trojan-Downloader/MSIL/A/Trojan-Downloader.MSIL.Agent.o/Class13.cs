using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

internal class Class13
{
	public RegexOptions regexOptions_0 = RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.ExplicitCapture | RegexOptions.Singleline;

	protected Class15 class15_0;

	protected Class15 class15_1;

	protected Hashtable hashtable_0 = new Hashtable();

	public ArrayList arrayList_0 = new ArrayList();

	protected Stack stack_0 = new Stack();

	public Class12 class12_0;

	public Class11 class11_0;

	public Random random_0 = new Random();

	public bool bool_0 = false;

	public Class21 class21_0 = null;

	protected Class17 class17_0;

	public ArrayList arrayList_1 = new ArrayList();

	public Enum1 enum1_0 = Enum1.Error;

	public TimeSpan timeSpan_0;

	public Class13(Class12 class12_1, Class11 class11_1)
	{
		class12_0 = class12_1;
		class15_0 = new Class15(class12_0, null, ":", random_0);
		class15_1 = new Class15(class12_0, class15_0, "::", random_0);
		if (class12_0.class11_0 != null)
		{
			class12_0.class11_0.method_5(ref class15_0.class14_0);
		}
		class11_0 = class11_1;
		if (class11_0 != null)
		{
			class11_0.method_5(ref class15_0.class14_0);
		}
		if (class11_0 != null)
		{
			method_16(":BROWSER", bool_1: false);
			class21_0 = method_17(":BROWSER");
		}
		method_14(":__SERVER", Class14.smethod_3(class12_0.class23_0.string_1));
	}

	public void method_0(string string_0, string string_1, string string_2)
	{
		Class25 @class = new Class25();
		@class.string_0 = ((class17_0 != null) ? class17_0.string_0 : null);
		@class.string_1 = ((class17_0 != null) ? class17_0.class18_0.string_0 : null);
		@class.string_2 = ((class21_0 != null) ? null : class21_0.string_1);
		@class.string_3 = ((string_0 != null) ? string_0 : ((class21_0 == null || class21_0.method_4() == null) ? null : class21_0.method_4().method_11().ToString()));
		@class.int_0 = 0;
		@class.dateTime_0 = DateTime.Now;
		@class.string_4 = string_1;
		@class.string_5 = string_2;
		arrayList_1.Add(@class);
	}

	public void method_1(string string_0, string string_1)
	{
		method_0(string_0, null, string_1);
	}

	public void method_2(string string_0, Exception exception_0)
	{
		method_0(string_0, ((object)exception_0).GetType().ToString(), exception_0.ToString());
	}

	public Class4 method_3(string string_0)
	{
		if (string_0.IndexOf(".") == -1)
		{
			Class4 @class = null;
			if (class11_0 != null)
			{
				@class = class11_0.method_1(string_0);
			}
			if (@class == null && class12_0.class11_0 != null)
			{
				@class = class12_0.class11_0.method_1(string_0);
			}
			return @class;
		}
		string[] array = string_0.Split(new char[1] { '.' });
		return class12_0.method_4(array[0]).method_1(array[1]);
	}

	protected void method_4(Class14 class14_0, Hashtable hashtable_1)
	{
		foreach (object item in hashtable_1)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			if (dictionaryEntry.Value is string)
			{
				class14_0.method_11(dictionaryEntry.Key as string, Class14.smethod_3(dictionaryEntry.Value as string));
				continue;
			}
			Class14 class14_ = new Class14();
			class14_0.method_11(dictionaryEntry.Key as string, class14_);
			method_4(class14_, dictionaryEntry.Value as Hashtable);
		}
	}

	public Class14 method_5(Class1 class1_0, Class14 class14_0)
	{
		return class1_0.vmethod_7(this, class14_0);
	}

	public Enum1 method_6(Class14 class14_0, Class17 class17_1)
	{
		string text = null;
		if (bool_0)
		{
			return Enum1.Error;
		}
		try
		{
			bool_0 = true;
			Class37.smethod_12();
			class17_0 = class17_1;
			if (class14_0 == null)
			{
				class14_0 = new Class14();
			}
			Class14 @class = new Class14();
			@class.method_11("NAME", Class14.smethod_3(class17_0.string_0));
			@class.method_11("OWNER", Class14.smethod_3(class17_0.string_1));
			@class.method_11("CLICKTHROUGHRATE", new Class14(class17_0.double_1));
			@class.method_11("LASTVISITDATE", new Class14(class17_0.dateTime_0));
			@class.method_11("SUCCESSCOUNT", new Class14(class17_0.int_0));
			@class.method_11("FAILURECOUNT", new Class14(class17_0.int_1));
			@class.method_11("CLICKTHROUGHCOUNT", new Class14(class17_0.int_2));
			@class.method_11("KEYWORDS", Class14.smethod_0(class17_0.string_2));
			foreach (object item in class17_0.hashtable_0)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
				@class.method_11(dictionaryEntry.Key as string, Class14.smethod_3(dictionaryEntry.Value as string));
			}
			class14_0.method_11("DOMAIN", @class);
			Class28 class2 = class17_0.method_1();
			@class = new Class14();
			@class.method_11("ID", Class14.smethod_3(class2.string_0));
			@class.method_11("LASTVISITDATE", new Class14(class2.dateTime_0));
			class14_0.method_11("ACCOUNT", @class);
			Class18 class18_ = class17_0.class18_0;
			Class14 class3 = new Class14();
			class3.method_11("LASTVISITDATE", new Class14(class18_.dateTime_0));
			class3.method_11("SUCCESSCOUNT", new Class14(class18_.int_0));
			class3.method_11("FAILURECOUNT", new Class14(class18_.int_1));
			class3.method_11("CLICKTHROUGHCOUNT", new Class14(class18_.int_2));
			class3.method_11("TYPEINRATIO", new Class14(class18_.double_0));
			class3.method_11("NAME", Class14.smethod_3(class18_.string_0));
			Class14 class4 = new Class14();
			Class19[] class19_ = class18_.class19_0;
			foreach (Class19 class5 in class19_)
			{
				Class14 class6 = new Class14();
				class6.method_11("DwellTime", new Class14(class18_.timeSpan_0));
				class6.method_11("ID", Class14.smethod_3(class5.string_0));
				method_4(class6, class5.hashtable_0);
				if (class5.class20_0 != null && class5.class20_0.Length > 0)
				{
					Class14 class7 = new Class14();
					class6.method_11("RESOURCES", class7);
					Class20[] class20_ = class5.class20_0;
					foreach (Class20 class8 in class20_)
					{
						Class14 class9 = new Class14();
						class7.method_13(class9);
						class9.method_11("ACTION", new Class14(class8.enum0_0));
						class9.method_11("TAG", Class14.smethod_3(class8.string_0));
						class9.method_11("ATTRIBUTE", Class14.smethod_3(class8.string_1));
						class9.method_11("MAX", new Class14(class8.int_0));
						class9.method_11("PATTERN", Class14.smethod_3(class8.string_2));
					}
				}
				class4.method_13(class6);
			}
			class3.method_11("PROCESSINGINFO", class4);
			class14_0.method_11("HOSTS", class3);
			Class4 class10 = class11_0.method_6();
			method_14(":__CATEGORYDWELLTIME", new Class14(TimeSpan.Zero));
			method_14(":__ADDWELLTIME", new Class14(TimeSpan.Zero));
			if (class10 != null)
			{
				text = Class14.smethod_2(class10.vmethod_7(this, class14_0));
			}
			if (text != null)
			{
				try
				{
					enum1_0 = (Enum1)Enum.Parse(typeof(Enum1), text, ignoreCase: true);
				}
				catch
				{
					method_1(null, $"Unknown visit outcome '{text}'.");
				}
			}
		}
		catch (GException0 gException)
		{
			text = gException.object_0.ToString();
		}
		finally
		{
			bool_0 = false;
			timeSpan_0 = Class37.smethod_14();
		}
		return enum1_0;
	}

	[SpecialName]
	public TimeSpan method_7()
	{
		string string_ = Class14.smethod_2(method_13(":__CATEGORYDWELLTIME"));
		string string_2 = Class14.smethod_2(method_13(":__ADDWELLTIME"));
		return GClass1.smethod_6(string_, TimeSpan.Zero).Add(GClass1.smethod_6(string_2, TimeSpan.Zero));
	}

	public void method_8(Class14 class14_0)
	{
		class15_1.class14_0.vmethod_4(class14_0);
	}

	public void method_9(Class14 class14_0)
	{
		stack_0.Push(class15_1);
		class15_1 = new Class15(class12_0, class15_0, "::", random_0);
		if (class14_0 != null)
		{
			class15_1.method_14(class14_0);
		}
		method_14("::__LASTRETURN", Class14.smethod_1());
	}

	public Class14 method_10()
	{
		Class14 class14_ = class15_1.class14_0;
		class15_1 = stack_0.Pop() as Class15;
		return class14_;
	}

	public Class14 method_11(string string_0)
	{
		return class15_1.method_9(string_0);
	}

	public bool method_12(string string_0)
	{
		return class15_1.method_10(string_0);
	}

	public Class14 method_13(string string_0)
	{
		return class15_1.method_12(string_0);
	}

	public Class14 method_14(string string_0, Class14 class14_0)
	{
		return class15_1.method_13(string_0, class14_0);
	}

	protected string method_15(string string_0, out string string_1)
	{
		string_1 = null;
		if (string_0 == null)
		{
			return null;
		}
		string_0 = class15_1.method_8(string_0);
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

	public Class14 method_16(string string_0, bool bool_1)
	{
		string_0 = method_15(string_0, out var _);
		if (hashtable_0.Contains(string_0))
		{
			return method_13(string_0);
		}
		Class21 @class = class12_0.class23_0.method_22(bool_1);
		hashtable_0.Add(string_0, @class);
		Class14 class2 = method_14(string_0, Class14.smethod_1());
		class2.method_11("PROXYNAME", Class14.smethod_3(@class.string_1));
		class2.method_11("USERAGENT", Class14.smethod_3(@class.string_0));
		return class2;
	}

	public Class21 method_17(string string_0)
	{
		string_0 = method_15(string_0, out var _);
		if (!hashtable_0.Contains(string_0))
		{
			if (method_16(string_0, bool_1: false) != null)
			{
				return method_17(string_0);
			}
			return null;
		}
		return hashtable_0[string_0] as Class21;
	}

	public void method_18(string string_0, params object[] object_0)
	{
		string text = Class14.smethod_2(method_13(":__ERROR_URL"));
		method_0((text == "") ? null : text, "LingoError", string.Format(string_0, object_0));
	}

	[SpecialName]
	public string method_19()
	{
		return Class14.smethod_2(method_12(":__PAGEPROCESSOR") ? method_13(":__PAGEPROCESSOR") : null);
	}

	public Class14 method_20(string string_0, bool bool_1)
	{
		string_0 = method_15(string_0, out var _);
		Class21 @class = method_17(string_0);
		Class14 class14_ = method_13(string_0);
		return method_21(class14_, @class.method_4(), bool_1);
	}

	public Class14 method_21(Class14 class14_0, Class27 class27_0, bool bool_1)
	{
		if (class27_0 != null)
		{
			class14_0.method_28("URL", Class14.smethod_3(class27_0.method_11().ToString()));
			class14_0.method_28("REFERRER", Class14.smethod_3(class27_0.method_0().method_0().Referer));
			class14_0.method_28("STATUS", Class14.smethod_3(class27_0.method_10().ToString()));
			class14_0.method_28("SUCCESS", Class14.smethod_3(((class27_0.method_10() >= 200 && class27_0.method_10() <= 303) || class27_0.method_10() == 307).ToString()));
			class14_0.method_28("REQUEST_TIMESTAMP", new Class14(class27_0.method_0().dateTime_0));
			class14_0.method_28("RESPONSE_TIMESTAMP", new Class14(class27_0.dateTime_0));
			if (bool_1)
			{
				class14_0.method_28("PAYLOAD", Class14.smethod_3(class27_0.method_4()));
			}
			return class14_0;
		}
		return null;
	}
}
