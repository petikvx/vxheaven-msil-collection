using System;
using System.Collections;
using System.Xml;

internal class Class38
{
	public IDictionary idictionary_0 = new Hashtable();

	public Class11 class11_0;

	public Class38()
	{
	}

	public Class38(Class11 class11_1, XmlNode xmlNode_0)
	{
		class11_0 = class11_1;
		foreach (XmlNode childNode in xmlNode_0.ChildNodes)
		{
			if (!Class51.smethod_1(childNode))
			{
				try
				{
					method_0(childNode);
				}
				catch (Exception exception_)
				{
					class11_0.method_20("ERR00036", exception_);
				}
			}
		}
	}

	public void method_0(XmlNode xmlNode_0)
	{
		string[] array = Class49.smethod_0(xmlNode_0.InnerText, "|");
		string[] array2 = array;
		foreach (string string_ in array2)
		{
			try
			{
				method_1(xmlNode_0.Attributes!["d"]!.Value, new Class39(string_));
			}
			catch (Exception exception_)
			{
				class11_0.method_20("30F82370-064E-4f64-BBF5-9FBC55116C9B", exception_);
			}
		}
	}

	public void method_1(string string_0, Class39 class39_0)
	{
		if (!idictionary_0.Contains(string_0))
		{
			idictionary_0.Add(string_0, new ArrayList());
		}
		(idictionary_0[string_0] as ArrayList).Add(class39_0);
	}

	public void method_2(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("VisitRecords");
		foreach (object item in idictionary_0)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			ArrayList ienumerable_ = dictionaryEntry.Value as ArrayList;
			xmlWriter_0.WriteStartElement("VR");
			xmlWriter_0.WriteAttributeString("d", dictionaryEntry.Key as string);
			xmlWriter_0.WriteString(Class49.smethod_1(ienumerable_, "|"));
			xmlWriter_0.WriteEndElement();
		}
		xmlWriter_0.WriteEndElement();
	}

	public void method_3()
	{
		foreach (ArrayList value in idictionary_0.Values)
		{
			value.Clear();
		}
		idictionary_0.Clear();
	}
}
