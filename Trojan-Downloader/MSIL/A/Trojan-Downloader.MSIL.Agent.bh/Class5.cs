using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml;

internal class Class5
{
	public const double double_0 = 0.1;

	public string string_0;

	public double double_1 = 1.0;

	public string string_1;

	public string[] string_2;

	public double double_2 = 0.02;

	public string string_3;

	protected bool bool_0 = true;

	public int int_0 = 0;

	public int int_1 = 0;

	public int int_2 = 0;

	public DateTime dateTime_0 = DateTime.MinValue;

	public DateTime dateTime_1 = DateTime.MinValue;

	public IDictionary idictionary_0 = new Hashtable();

	public Class11 class11_0;

	protected double double_3 = 1.0;

	public bool bool_1 = false;

	[SpecialName]
	public Class34 method_0()
	{
		if (class11_0 != null && string_3 != null)
		{
			return class11_0.idictionary_0[string_3] as Class34;
		}
		return null;
	}

	public Class5(Class11 class11_1)
	{
		class11_0 = class11_1;
	}

	public Class5(Class11 class11_1, XmlNode xmlNode_0)
	{
		class11_0 = class11_1;
		method_7(xmlNode_0);
	}

	[SpecialName]
	public double method_1()
	{
		return Class51.smethod_20(method_0().method_1() * double_2, 0.0, 0.1);
	}

	[SpecialName]
	public double method_2()
	{
		if (method_0() == null)
		{
			return double_3 * class11_0.double_4;
		}
		return method_0().method_0() * double_3;
	}

	[SpecialName]
	public double method_3()
	{
		if (method_0() == null)
		{
			return class11_0.double_6;
		}
		return method_0().method_2();
	}

	[SpecialName]
	public string method_4()
	{
		return Class33.smethod_0(string_1, string_3);
	}

	[SpecialName]
	public Class33 method_5()
	{
		return class11_0.idictionary_2[method_4()] as Class33;
	}

	[SpecialName]
	public bool method_6()
	{
		if (bool_0 && method_0() != null)
		{
			return method_0().bool_0;
		}
		return false;
	}

	public void method_7(XmlNode xmlNode_0)
	{
		if (Class53.hashtable_0 == null)
		{
			Class53.hashtable_0 = new Hashtable(54, 0.5f)
			{
				{ "name", 0 },
				{ "owner", 1 },
				{ "own", 2 },
				{ "weight", 3 },
				{ "wt", 4 },
				{ "keywords", 5 },
				{ "kw", 6 },
				{ "clickthroughRate", 7 },
				{ "ctr", 8 },
				{ "throttle", 9 },
				{ "thr", 10 },
				{ "host", 11 },
				{ "pg", 12 },
				{ "failureCount", 13 },
				{ "fc", 14 },
				{ "successCount", 15 },
				{ "sc", 16 },
				{ "clickthroughCount", 17 },
				{ "ctc", 18 },
				{ "lastVisitDate", 19 },
				{ "lv", 20 },
				{ "nextEligibilityCheck", 21 },
				{ "nextec", 22 },
				{ "enabled", 23 },
				{ "on", 24 },
				{ "dirty", 25 }
			};
		}
		string_0 = xmlNode_0.InnerText;
		double_1 = Class51.smethod_10(Class51.smethod_0(xmlNode_0, Class51.smethod_2(double_1), "weight", "wt"), double_1);
		string_1 = Class51.smethod_0(xmlNode_0, string_1, "owner", "own");
		string text = Class51.smethod_0(xmlNode_0, null, "keywords", "kw");
		if (text == null && string_2 == null)
		{
			text = string_0.Substring(0, string_0.Length - 4) + ",";
		}
		if (text != null)
		{
			string_2 = Class49.smethod_0(text, ",");
		}
		double_2 = Class51.smethod_10(Class51.smethod_0(xmlNode_0, Class51.smethod_2(double_2), "clickthroughRate", "ctr"), double_2);
		double_3 = Class51.smethod_10(Class51.smethod_0(xmlNode_0, Class51.smethod_2(double_3), "throttle", "thr"), double_3);
		string_3 = Class51.smethod_0(xmlNode_0, string_3, "host", "pg");
		int_0 = Class51.smethod_9(Class51.smethod_0(xmlNode_0, Class51.smethod_3(int_0), "successCount", "sc"), int_0);
		int_1 = Class51.smethod_9(Class51.smethod_0(xmlNode_0, Class51.smethod_3(int_1), "failureCount", "fc"), int_1);
		int_2 = Class51.smethod_9(Class51.smethod_0(xmlNode_0, Class51.smethod_3(int_2), "clickthroughCount", "ctc"), int_2);
		dateTime_0 = Class51.smethod_13(Class51.smethod_0(xmlNode_0, Class51.smethod_6(dateTime_0), "lastVisitDate", "lv"), dateTime_0);
		dateTime_1 = Class51.smethod_13(Class51.smethod_0(xmlNode_0, Class51.smethod_6(dateTime_1), "nextEligibilityCheck", "nextec"), dateTime_1);
		bool_1 = Class51.smethod_11(Class51.smethod_0(xmlNode_0, Class51.smethod_4(bool_1), "dirty", "dirty"), bool_1);
		bool_0 = Class51.smethod_11(Class51.smethod_0(xmlNode_0, Class51.smethod_4(bool_0), "enabled", "on"), bool_0);
		foreach (XmlAttribute item in xmlNode_0.Attributes!)
		{
			object name;
			if ((name = item.Name) != null && (name = Class53.hashtable_0[name]) != null)
			{
				switch ((int)name)
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
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
				case 22:
				case 23:
				case 24:
				case 25:
					continue;
				}
			}
			idictionary_0[item.Name] = item.Value;
		}
	}

	public void method_8(XmlWriter xmlWriter_0, bool bool_2)
	{
		xmlWriter_0.WriteStartElement("D");
		xmlWriter_0.WriteAttributeString("pg", string_3);
		if (bool_2)
		{
			xmlWriter_0.WriteAttributeString("on", Class51.smethod_4(bool_0));
			xmlWriter_0.WriteAttributeString("wt", Class51.smethod_2(double_1));
			xmlWriter_0.WriteAttributeString("own", string_1);
			xmlWriter_0.WriteAttributeString("ctr", Class51.smethod_2(double_2));
			xmlWriter_0.WriteAttributeString("thr", Class51.smethod_2(double_3));
			xmlWriter_0.WriteAttributeString("nextec", Class51.smethod_14(dateTime_1));
			xmlWriter_0.WriteAttributeString("kw", string.Join(",", string_2));
			xmlWriter_0.WriteAttributeString("dirty", Class51.smethod_4(bool_1));
			foreach (object item in idictionary_0)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
				xmlWriter_0.WriteAttributeString(dictionaryEntry.Key as string, dictionaryEntry.Value as string);
			}
		}
		xmlWriter_0.WriteAttributeString("lv", Class51.smethod_14(dateTime_0));
		xmlWriter_0.WriteAttributeString("sc", Class51.smethod_3(int_0));
		xmlWriter_0.WriteAttributeString("ctc", Class51.smethod_3(int_2));
		xmlWriter_0.WriteAttributeString("fc", Class51.smethod_3(int_1));
		xmlWriter_0.WriteString(string_0);
		xmlWriter_0.WriteEndElement();
	}
}
