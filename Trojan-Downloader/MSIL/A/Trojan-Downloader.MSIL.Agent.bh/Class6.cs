using System.Collections;
using System.Xml;

internal class Class6
{
	public Class34 class34_0;

	public IDictionary idictionary_0 = new Hashtable();

	public Class7[] class7_0;

	public string string_0 = null;

	public Class6()
	{
		class7_0 = new Class7[0];
	}

	protected IDictionary method_0(IDictionary idictionary_1, XmlNode xmlNode_0)
	{
		new Hashtable();
		if (xmlNode_0.ChildNodes.Count == 0)
		{
			idictionary_1[xmlNode_0.Name] = "";
			return idictionary_1;
		}
		foreach (XmlNode childNode in xmlNode_0.ChildNodes)
		{
			if (!Class51.smethod_1(childNode))
			{
				if (childNode.NodeType != XmlNodeType.Text && childNode.NodeType != XmlNodeType.CDATA)
				{
					IDictionary dictionary = new Hashtable();
					idictionary_1[childNode.Name] = dictionary;
					method_0(dictionary, childNode);
				}
				else
				{
					idictionary_1[xmlNode_0.Name] = xmlNode_0.InnerText;
				}
			}
		}
		return idictionary_1;
	}

	public Class6(Class34 class34_1, XmlNode xmlNode_0)
	{
		class34_0 = class34_1;
		method_1(xmlNode_0);
	}

	public void method_1(XmlNode xmlNode_0)
	{
		string_0 = Class51.smethod_0(xmlNode_0, string_0, "id");
		foreach (XmlNode childNode in xmlNode_0.ChildNodes)
		{
			if (Class51.smethod_1(childNode))
			{
				continue;
			}
			if (childNode.Name == "Resources")
			{
				ArrayList arrayList = new ArrayList();
				foreach (XmlNode childNode2 in childNode.ChildNodes)
				{
					if (!Class51.smethod_1(childNode2))
					{
						arrayList.Add(new Class7(class34_0, childNode2));
					}
				}
				class7_0 = arrayList.ToArray(typeof(Class7)) as Class7[];
			}
			else
			{
				method_0(idictionary_0, childNode);
			}
		}
		if (class7_0 == null)
		{
			class7_0 = new Class7[0];
		}
	}

	public void method_2(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("PageProcessingInfo");
		foreach (object item in idictionary_0)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			xmlWriter_0.WriteElementString(dictionaryEntry.Key as string, dictionaryEntry.Value as string);
		}
		if (class7_0.Length > 0)
		{
			xmlWriter_0.WriteStartElement("Resources");
			Class7[] array = class7_0;
			foreach (Class7 @class in array)
			{
				@class.method_0(xmlWriter_0);
			}
			xmlWriter_0.WriteEndElement();
		}
		xmlWriter_0.WriteEndElement();
	}
}
