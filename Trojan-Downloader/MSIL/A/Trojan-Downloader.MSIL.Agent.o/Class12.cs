using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml;

internal class Class12
{
	public Class11 class11_0;

	protected Hashtable hashtable_0 = new Hashtable();

	protected Hashtable hashtable_1 = new Hashtable();

	protected Class13 class13_0 = null;

	public Class23 class23_0;

	public Class12(Class23 class23_1)
	{
		Class14 @class = new Class14();
		IDictionary environmentVariables = Environment.GetEnvironmentVariables();
		foreach (object item in environmentVariables)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			@class.method_11((dictionaryEntry.Key as string).ToUpper(), Class14.smethod_3(dictionaryEntry.Value as string));
		}
		class23_0 = class23_1;
		hashtable_1.Add("__ENVIRONMENT", @class);
		hashtable_1.Add("__VERSION", new Class14(class23_0.string_2));
		hashtable_1.Add("__COMPUTERNAME", new Class14(Environment.MachineName));
		hashtable_1.Add("__OSVERSION", new Class14(Environment.OSVersion.Platform.ToString() + " " + Environment.OSVersion.Version.ToString()));
		hashtable_1.Add("__DEBUG", new Class14(false));
	}

	public void method_0()
	{
		class11_0 = null;
		hashtable_0.Clear();
		hashtable_1.Clear();
	}

	[SpecialName]
	public Class13 method_1()
	{
		if (class13_0 != null)
		{
			return class13_0;
		}
		return class13_0 = new Class13(this, class11_0);
	}

	protected void method_2(Class11 class11_1)
	{
		foreach (object item in hashtable_1)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			class11_1.method_2(dictionaryEntry.Key as string, dictionaryEntry.Value as Class14);
		}
	}

	public Class11 method_3(XmlNode xmlNode_0)
	{
		Class11 @class = new Class11(this, xmlNode_0);
		if (@class.string_1 == "Global")
		{
			class11_0 = @class;
			method_2(class11_0);
			class13_0 = null;
		}
		hashtable_0[@class.string_1] = @class;
		return @class;
	}

	public Class11 method_4(string string_0)
	{
		Class11 @class = hashtable_0[string_0] as Class11;
		if (class11_0 == null)
		{
			method_2(@class);
		}
		return @class;
	}

	public static Class0 smethod_0(Class0 class0_0, XmlNode xmlNode_0)
	{
		if (Class50.hashtable_2 == null)
		{
			Class50.hashtable_2 = new Hashtable(74, 0.5f)
			{
				{ "Include", 0 },
				{ "Sub", 1 },
				{ "Declare", 2 },
				{ "Debug", 3 },
				{ "DebugBreak", 4 },
				{ "ClrNew", 5 },
				{ "ClrNewArray", 6 },
				{ "ClrCastTo", 7 },
				{ "ClrToArray", 8 },
				{ "ClrType", 9 },
				{ "ClrTypeOf", 10 },
				{ "ClrInvokeMethod", 11 },
				{ "ClrGetProperty", 12 },
				{ "ClrSetProperty", 13 },
				{ "ClrNull", 14 },
				{ "ClrArrayItem", 15 },
				{ "ClrToString", 16 },
				{ "ClrToInt", 17 },
				{ "ClrToBool", 18 },
				{ "ClrToDouble", 19 },
				{ "ClrToDateTime", 20 },
				{ "ClrToTimeSpan", 21 },
				{ "HttpGet", 22 },
				{ "HttpPost", 23 },
				{ "While", 24 },
				{ "Foreach", 25 },
				{ "IsMatch", 26 },
				{ "GetMatch", 27 },
				{ "CaptureByMatch", 28 },
				{ "CaptureByGroups", 29 },
				{ "Substitute", 30 },
				{ "Block", 31 },
				{ "OnTrue", 32 },
				{ "OnFalse", 33 },
				{ "If", 34 },
				{ "GoSub", 35 }
			};
		}
		try
		{
			if (xmlNode_0.NodeType != XmlNodeType.Text && xmlNode_0.NodeType != XmlNodeType.CDATA)
			{
				if (class0_0 is Class11 && xmlNode_0.Name != "Sub" && xmlNode_0.Name != "Declare" && xmlNode_0.Name != "Include")
				{
					return null;
				}
				object name;
				if ((name = xmlNode_0.Name) != null && (name = Class50.hashtable_2[name]) != null)
				{
					switch ((int)name)
					{
					case 0:
						if (class0_0 is Class11)
						{
							string innerText = xmlNode_0.InnerText;
							Class22 @class = new Class22((class0_0 as Class11).class12_0.class23_0);
							XmlNode xmlNode = @class.method_15(innerText);
							if (xmlNode != null)
							{
								foreach (XmlNode item in xmlNode)
								{
									if (!GClass1.smethod_2(item))
									{
										smethod_0(class0_0, item);
									}
								}
							}
							return null;
						}
						return null;
					case 1:
						if (class0_0 is Class11)
						{
							Class4 class2 = new Class4(class0_0, xmlNode_0);
							(class0_0 as Class11).method_0(class2);
							return class2;
						}
						return null;
					case 2:
						if (class0_0 is Class11)
						{
							Class1 class1_ = new Class1(null, xmlNode_0);
							string text = xmlNode_0.Attributes!["var"]!.Value;
							if (text == null)
							{
								return null;
							}
							if (!text.StartsWith(":"))
							{
								text = ":" + text;
							}
							(class0_0 as Class11).method_3(text, (class0_0 as Class11).class12_0.method_1().method_5(class1_, null), xmlNode_0);
							return null;
						}
						return new Class1(class0_0, xmlNode_0);
					case 3:
					case 4:
						return null;
					case 5:
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
						return new Class8(class0_0, xmlNode_0);
					case 22:
					case 23:
						return new Class10(class0_0, xmlNode_0);
					case 24:
					case 25:
						return new Class3(class0_0, xmlNode_0);
					case 26:
					case 27:
					case 28:
					case 29:
					case 30:
						return new Class9(class0_0, xmlNode_0);
					case 31:
					case 32:
					case 33:
						return new Class2(class0_0, xmlNode_0);
					case 34:
						return new Class7(class0_0, xmlNode_0);
					case 35:
						return new Class6(class0_0, xmlNode_0);
					}
				}
				if (xmlNode_0.Name.StartsWith("_"))
				{
					return new Class6(class0_0, xmlNode_0);
				}
				return new Class1(class0_0, xmlNode_0);
			}
			return new Class1(class0_0, xmlNode_0);
		}
		catch (Exception exception_)
		{
			try
			{
				if (class0_0 != null && class0_0 is Class11)
				{
					(class0_0 as Class11).class12_0.class23_0.method_13(exception_);
				}
				else if (class0_0 != null)
				{
					class0_0.class11_0.class12_0.class23_0.method_13(exception_);
				}
				else
				{
					Class37.smethod_8(exception_);
				}
			}
			catch (Exception exception_2)
			{
				Class37.smethod_8(exception_);
				Class37.smethod_8(exception_2);
			}
			return null;
		}
	}
}
