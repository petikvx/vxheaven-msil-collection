using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml;

internal class Class17
{
	public string string_0;

	public double double_0;

	public string string_1;

	public string[] string_2;

	public Class18 class18_0;

	public double double_1;

	protected bool bool_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public DateTime dateTime_0;

	public DateTime dateTime_1;

	public Hashtable hashtable_0;

	public Class23 class23_0;

	public Class17(Class23 class23_1)
	{
		hashtable_0 = new Hashtable();
		base._002Ector();
		class23_0 = class23_1;
	}

	public Class17(Class23 class23_1, XmlNode xmlNode_0)
	{
		if (Class50.hashtable_4 == null)
		{
			Class50.hashtable_4 = new Hashtable(26, 0.5f)
			{
				{ "name", 0 },
				{ "owner", 1 },
				{ "weight", 2 },
				{ "keywords", 3 },
				{ "clickthroughRate", 4 },
				{ "host", 5 },
				{ "failureCount", 6 },
				{ "successCount", 7 },
				{ "clickthroughCount", 8 },
				{ "lastVisitDate", 9 },
				{ "nextEligibilityCheck", 10 },
				{ "enabled", 11 }
			};
		}
		hashtable_0 = new Hashtable();
		base._002Ector();
		class23_0 = class23_1;
		string_0 = xmlNode_0.InnerText;
		double_0 = GClass1.smethod_4(GClass1.smethod_1(xmlNode_0, "weight"), 1.0);
		string_1 = xmlNode_0.Attributes!["owner"]!.Value;
		string text = GClass1.smethod_0(xmlNode_0, "keywords", string_0.Substring(0, string_0.Length - 4) + ",");
		string_2 = Class39.smethod_0(text, ",");
		double_1 = GClass1.smethod_4(GClass1.smethod_1(xmlNode_0, "clickthroughRate"), 0.1);
		class18_0 = class23_0.hashtable_0[xmlNode_0.Attributes!["host"]!.Value] as Class18;
		int_0 = GClass1.smethod_3(GClass1.smethod_1(xmlNode_0, "successCount"), 0);
		int_1 = GClass1.smethod_3(GClass1.smethod_1(xmlNode_0, "failureCount"), 0);
		int_2 = GClass1.smethod_3(GClass1.smethod_1(xmlNode_0, "clickthroughCount"), 0);
		dateTime_0 = GClass1.smethod_7(GClass1.smethod_1(xmlNode_0, "lastVisitDate"), DateTime.MinValue);
		dateTime_1 = GClass1.smethod_7(GClass1.smethod_1(xmlNode_0, "nextEligibilityCheck"), DateTime.MinValue);
		bool_0 = GClass1.smethod_5(GClass1.smethod_0(xmlNode_0, "enabled", "true"), bool_0: true);
		foreach (XmlAttribute item in xmlNode_0.Attributes!)
		{
			object name;
			if ((name = item.Name) != null && (name = Class50.hashtable_4[name]) != null)
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
					continue;
				}
			}
			hashtable_0.Add(item.Name, item.Value);
		}
	}

	[SpecialName]
	public string method_0()
	{
		return Class28.smethod_0(string_1, class18_0.string_0);
	}

	[SpecialName]
	public Class28 method_1()
	{
		return class23_0.hashtable_2[method_0()] as Class28;
	}

	[SpecialName]
	public bool method_2()
	{
		if (bool_0)
		{
			if (class18_0 != null)
			{
				return class18_0.bool_0;
			}
			return false;
		}
		return false;
	}

	public void method_3(XmlWriter xmlWriter_0, bool bool_1)
	{
		xmlWriter_0.WriteStartElement("Domain");
		if (bool_1)
		{
			xmlWriter_0.WriteAttributeString("enabled", bool_0.ToString());
			xmlWriter_0.WriteAttributeString("weight", double_0.ToString());
			xmlWriter_0.WriteAttributeString("owner", string_1);
			xmlWriter_0.WriteAttributeString("host", class18_0.string_0);
			xmlWriter_0.WriteAttributeString("clickthroughRate", double_1.ToString());
			xmlWriter_0.WriteAttributeString("nextEligibilityCheck", GClass1.smethod_8(dateTime_1));
			xmlWriter_0.WriteAttributeString("keywords", string.Join(",", string_2, 1, string_2.Length - 1));
			foreach (object item in hashtable_0)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
				xmlWriter_0.WriteAttributeString(dictionaryEntry.Key as string, dictionaryEntry.Value as string);
			}
		}
		xmlWriter_0.WriteAttributeString("lastVisitDate", GClass1.smethod_8(dateTime_0));
		xmlWriter_0.WriteAttributeString("successCount", int_0.ToString());
		xmlWriter_0.WriteAttributeString("clickthroughCount", int_2.ToString());
		xmlWriter_0.WriteAttributeString("failureCount", int_1.ToString());
		xmlWriter_0.WriteString(string_0);
		xmlWriter_0.WriteEndElement();
	}
}
