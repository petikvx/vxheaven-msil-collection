using System;
using System.Collections;
using System.Xml;

internal class Class32
{
	public Hashtable hashtable_0 = new Hashtable();

	public Class23 class23_0;

	public Class32()
	{
	}

	public Class32(Class23 class23_1, XmlNode xmlNode_0)
	{
		class23_0 = class23_1;
		foreach (XmlNode childNode in xmlNode_0.ChildNodes)
		{
			if (!GClass1.smethod_2(childNode))
			{
				try
				{
					method_0(childNode);
				}
				catch (Exception exception_)
				{
					class23_0.method_13(exception_);
				}
			}
		}
	}

	public void method_0(XmlNode xmlNode_0)
	{
		string value = xmlNode_0.Attributes!["domain"]!.Value;
		string[] array = Class39.smethod_0(xmlNode_0.InnerText, "|");
		string[] array2 = array;
		foreach (string string_ in array2)
		{
			try
			{
				method_1(new Class33(value, string_));
			}
			catch (Exception exception_)
			{
				class23_0.method_13(exception_);
			}
		}
	}

	public void method_1(Class33 class33_0)
	{
		if (!hashtable_0.ContainsKey(class33_0.string_0))
		{
			hashtable_0.Add(class33_0.string_0, new ArrayList());
		}
		(hashtable_0[class33_0.string_0] as ArrayList).Add(class33_0);
	}

	public void method_2(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("VisitRecords");
		foreach (object item in hashtable_0)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			ArrayList ienumerable_ = dictionaryEntry.Value as ArrayList;
			xmlWriter_0.WriteStartElement("VisitRecord");
			xmlWriter_0.WriteAttributeString("domain", dictionaryEntry.Key as string);
			xmlWriter_0.WriteString(Class39.smethod_1(ienumerable_, "|"));
			xmlWriter_0.WriteEndElement();
		}
		xmlWriter_0.WriteEndElement();
	}

	public void method_3()
	{
		foreach (ArrayList value in hashtable_0.Values)
		{
			value.Clear();
		}
		hashtable_0.Clear();
	}
}
