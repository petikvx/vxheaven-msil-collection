using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml;

internal class Class26
{
	public Class25 class25_0;

	protected IDictionary idictionary_0 = new Hashtable();

	protected IDictionary idictionary_1 = new Hashtable();

	protected Class27 class27_0 = null;

	public Class11 class11_0;

	public Class26(Class11 class11_1)
	{
		Class28 @class = new Class28();
		IDictionary environmentVariables = Environment.GetEnvironmentVariables();
		foreach (object item in environmentVariables)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			@class.method_11((dictionaryEntry.Key as string).ToUpper(), Class28.smethod_3(dictionaryEntry.Value as string));
		}
		class11_0 = class11_1;
		idictionary_1.Add("__ENVIRONMENT", @class);
		idictionary_1.Add("__VERSION", new Class28(class11_0.string_2));
		idictionary_1.Add("__COMPUTERNAME", new Class28(Environment.MachineName));
		idictionary_1.Add("__OSVERSION", new Class28(Class51.smethod_8(Environment.OSVersion.Platform) + " " + Class51.smethod_8(Environment.OSVersion.Version)));
		idictionary_1.Add("__DEBUG", new Class28(false));
	}

	public void method_0()
	{
		class25_0 = null;
		idictionary_0.Clear();
		idictionary_1.Clear();
	}

	[SpecialName]
	public Class27 method_1()
	{
		if (class27_0 != null)
		{
			return class27_0;
		}
		return class27_0 = new Class27(this, class25_0);
	}

	protected void method_2(Class25 class25_1)
	{
		foreach (object item in idictionary_1)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			class25_1.method_7(dictionaryEntry.Key as string, dictionaryEntry.Value as Class28);
		}
	}

	public Class25 method_3(XmlNode xmlNode_0)
	{
		Class25 @class = new Class25(this, xmlNode_0);
		if (@class.string_1 == "Global")
		{
			class25_0 = @class;
			method_2(class25_0);
			class27_0 = null;
		}
		idictionary_0[@class.string_1] = @class;
		return @class;
	}

	public Class25 method_4(string string_0)
	{
		Class25 @class = idictionary_0[string_0] as Class25;
		if (class25_0 == null)
		{
			method_2(@class);
		}
		return @class;
	}

	public static Class14 smethod_0(Class14 class14_0, XmlNode xmlNode_0)
	{
		if (Class53.hashtable_5 == null)
		{
			Class53.hashtable_5 = new Hashtable(76, 0.5f)
			{
				{ "Include", 0 },
				{ "Sub", 1 },
				{ "Declare", 2 },
				{ "Debug", 3 },
				{ "DebugBreak", 4 },
				{ "CallStack", 5 },
				{ "ClrNew", 6 },
				{ "ClrNewArray", 7 },
				{ "ClrCastTo", 8 },
				{ "ClrToArray", 9 },
				{ "ClrType", 10 },
				{ "ClrTypeOf", 11 },
				{ "ClrInvokeMethod", 12 },
				{ "ClrGetProperty", 13 },
				{ "ClrSetProperty", 14 },
				{ "ClrNull", 15 },
				{ "ClrArrayItem", 16 },
				{ "ClrToString", 17 },
				{ "ClrToInt", 18 },
				{ "ClrToBool", 19 },
				{ "ClrToDouble", 20 },
				{ "ClrToDateTime", 21 },
				{ "ClrToTimeSpan", 22 },
				{ "HttpGet", 23 },
				{ "HttpPost", 24 },
				{ "While", 25 },
				{ "Foreach", 26 },
				{ "IsMatch", 27 },
				{ "GetMatch", 28 },
				{ "CaptureByMatch", 29 },
				{ "CaptureByGroups", 30 },
				{ "Substitute", 31 },
				{ "Block", 32 },
				{ "OnTrue", 33 },
				{ "OnFalse", 34 },
				{ "If", 35 },
				{ "GoSub", 36 }
			};
		}
		try
		{
			if (xmlNode_0.NodeType != XmlNodeType.Text && xmlNode_0.NodeType != XmlNodeType.CDATA)
			{
				if (class14_0 is Class25 && xmlNode_0.Name != "Sub" && xmlNode_0.Name != "Declare" && xmlNode_0.Name != "Include")
				{
					return null;
				}
				object name;
				if ((name = xmlNode_0.Name) != null && (name = Class53.hashtable_5[name]) != null)
				{
					switch ((int)name)
					{
					case 0:
						if (class14_0 is Class25)
						{
							string innerText = xmlNode_0.InnerText;
							Class9 @class = new Class9((class14_0 as Class25).class26_0.class11_0);
							XmlNode xmlNode = @class.method_25(innerText);
							if (xmlNode != null)
							{
								foreach (XmlNode item in xmlNode)
								{
									if (!Class51.smethod_1(item))
									{
										smethod_0(class14_0, item);
									}
								}
							}
							return null;
						}
						return null;
					case 1:
						if (class14_0 is Class25)
						{
							Class17 class2 = new Class17(class14_0, xmlNode_0);
							(class14_0 as Class25).method_5(class2);
							return class2;
						}
						return null;
					case 2:
						if (class14_0 is Class25)
						{
							Class15 class15_ = new Class15(null, xmlNode_0);
							string text = xmlNode_0.Attributes!["var"]!.Value;
							if (text == null)
							{
								return null;
							}
							if (!text.StartsWith(":"))
							{
								text = ":" + text;
							}
							(class14_0 as Class25).method_8(text, (class14_0 as Class25).class26_0.method_1().method_7(class15_, null), xmlNode_0);
							return null;
						}
						return new Class15(class14_0, xmlNode_0);
					case 3:
					case 4:
					case 5:
						return null;
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
					case 11:
					case 12:
					case 13:
					case 14:
					case 15:
					case 16:
					case 17:
					case 18:
					case 19:
					case 20:
					case 21:
					case 22:
						return new Class22(class14_0, xmlNode_0);
					case 23:
					case 24:
						return new Class24(class14_0, xmlNode_0);
					case 25:
					case 26:
						return new Class21(class14_0, xmlNode_0);
					case 27:
					case 28:
					case 29:
					case 30:
					case 31:
						return new Class23(class14_0, xmlNode_0);
					case 32:
					case 33:
					case 34:
						return new Class16(class14_0, xmlNode_0);
					case 35:
						return new Class20(class14_0, xmlNode_0);
					case 36:
						return new Class19(class14_0, xmlNode_0);
					}
				}
				if (xmlNode_0.Name.StartsWith("_"))
				{
					return new Class19(class14_0, xmlNode_0);
				}
				return new Class15(class14_0, xmlNode_0);
			}
			return new Class15(class14_0, xmlNode_0);
		}
		catch (Exception exception_)
		{
			try
			{
				if (class14_0 != null && class14_0 is Class25)
				{
					(class14_0 as Class25).class26_0.class11_0.method_20("ERR00026", exception_);
				}
				else if (class14_0 != null)
				{
					class14_0.class25_0.class26_0.class11_0.method_20("ERR00027", exception_);
				}
				else
				{
					Class47.smethod_8(exception_);
				}
			}
			catch (Exception exception_2)
			{
				Class47.smethod_8(exception_);
				Class47.smethod_8(exception_2);
			}
			return null;
		}
	}
}
