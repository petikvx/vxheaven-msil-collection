using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml;

internal class Class11 : Class0
{
	protected Hashtable hashtable_1 = new Hashtable();

	protected Hashtable hashtable_2 = new Hashtable();

	protected Class15 class15_0;

	public Class12 class12_0;

	public Class11(Class12 class12_1)
		: base(null)
	{
		class12_0 = class12_1;
		class15_0 = new Class15(class12_1, null, ":", new Random());
	}

	public Class11(Class12 class12_1, XmlNode xmlNode_0)
		: base(null, xmlNode_0)
	{
		class12_0 = class12_1;
		class15_0 = new Class15(class12_1, null, ":", new Random());
		string text = (hashtable_0.Contains("src") ? (hashtable_0["src"] as string) : null);
		XmlNodeList childNodes = xmlNode_0.ChildNodes;
		if (text != null && text != "")
		{
			Class22 @class = new Class22(class12_0.class23_0);
			XmlNode xmlNode = @class.method_15(text);
			if (xmlNode != null)
			{
				childNodes = xmlNode.ChildNodes;
			}
		}
		foreach (XmlNode item in childNodes)
		{
			if (!GClass1.smethod_2(item))
			{
				Class12.smethod_0(this, item);
			}
		}
	}

	public void method_0(Class4 class4_0)
	{
		hashtable_1[class4_0.string_1] = class4_0;
	}

	public Class4 method_1(string string_3)
	{
		return hashtable_1[string_3] as Class4;
	}

	public void method_2(string string_3, Class14 class14_0)
	{
		while (string_3.StartsWith(":"))
		{
			string_3 = string_3.Substring(1, string_3.Length - 1);
		}
		class15_0.class14_0.method_28(string_3, class15_0.method_11(class14_0));
	}

	public void method_3(string string_3, Class14 class14_0, XmlNode xmlNode_0)
	{
		method_2(string_3, class14_0);
		hashtable_2.Add(string_3, xmlNode_0.InnerXml);
	}

	public Class14 method_4(string string_3)
	{
		if (!string_3.StartsWith(":"))
		{
			string_3 = ":" + string_3;
		}
		else if (string_3.StartsWith("::"))
		{
			string_3 = string_3.Substring(1, string_3.Length - 1);
		}
		return class15_0.method_12(string_3);
	}

	public void method_5(ref Class14 class14_0)
	{
		for (int i = 0; i < class15_0.class14_0.method_5(); i++)
		{
			class14_0.method_28(class15_0.class14_0.method_44(i), class15_0.class14_0.method_25(i).vmethod_4(new Class14()));
		}
	}

	[SpecialName]
	public Class4 method_6()
	{
		return method_1("Main");
	}

	public Class13 method_7()
	{
		return new Class13(class12_0, this);
	}

	public override void vmethod_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement(string_0);
		foreach (object item in hashtable_0)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			if (dictionaryEntry.Key as string!= "src")
			{
				xmlWriter_0.WriteAttributeString(dictionaryEntry.Key as string, dictionaryEntry.Value as string);
			}
		}
		foreach (object item2 in hashtable_2)
		{
			DictionaryEntry dictionaryEntry2 = (DictionaryEntry)item2;
			xmlWriter_0.WriteStartElement("Declare");
			xmlWriter_0.WriteAttributeString("var", dictionaryEntry2.Key as string);
			xmlWriter_0.WriteString(dictionaryEntry2.Value as string);
			xmlWriter_0.WriteEndElement();
		}
		foreach (Class4 value in hashtable_1.Values)
		{
			value.vmethod_0(xmlWriter_0);
		}
		xmlWriter_0.WriteEndElement();
	}
}
