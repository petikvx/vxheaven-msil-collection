using System.Collections;
using System.Xml;

internal class Class19
{
	public Class18 class18_0;

	public Hashtable hashtable_0 = new Hashtable();

	public Class20[] class20_0;

	public string string_0;

	public Class19()
	{
		class20_0 = new Class20[0];
	}

	protected Hashtable method_0(Hashtable hashtable_1, XmlNode xmlNode_0)
	{
		new Hashtable();
		if (xmlNode_0.ChildNodes.Count == 0)
		{
			hashtable_1.Add(xmlNode_0.Name, "");
			return hashtable_1;
		}
		foreach (XmlNode childNode in xmlNode_0.ChildNodes)
		{
			if (!GClass1.smethod_2(childNode))
			{
				if (childNode.NodeType != XmlNodeType.Text && childNode.NodeType != XmlNodeType.CDATA)
				{
					Hashtable hashtable = new Hashtable();
					hashtable_1.Add(childNode.Name, hashtable);
					method_0(hashtable, childNode);
				}
				else
				{
					hashtable_1.Add(xmlNode_0.Name, xmlNode_0.InnerText);
				}
			}
		}
		return hashtable_1;
	}

	public Class19(Class18 class18_1, XmlNode xmlNode_0)
	{
		class18_0 = class18_1;
		string_0 = GClass1.smethod_0(xmlNode_0, "id", null);
		foreach (XmlNode childNode in xmlNode_0.ChildNodes)
		{
			if (GClass1.smethod_2(childNode))
			{
				continue;
			}
			if (childNode.Name == "Resources")
			{
				ArrayList arrayList = new ArrayList();
				foreach (XmlNode childNode2 in childNode.ChildNodes)
				{
					if (!GClass1.smethod_2(childNode2))
					{
						arrayList.Add(new Class20(class18_0, childNode2));
					}
				}
				class20_0 = arrayList.ToArray(typeof(Class20)) as Class20[];
			}
			else
			{
				method_0(hashtable_0, childNode);
			}
		}
		if (class20_0 == null)
		{
			class20_0 = new Class20[0];
		}
	}

	public void method_1(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("PageProcessingInfo");
		foreach (object item in hashtable_0)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			xmlWriter_0.WriteElementString(dictionaryEntry.Key as string, dictionaryEntry.Value as string);
		}
		if (class20_0.Length > 0)
		{
			xmlWriter_0.WriteStartElement("Resources");
			Class20[] array = class20_0;
			foreach (Class20 @class in array)
			{
				@class.method_0(xmlWriter_0);
			}
			xmlWriter_0.WriteEndElement();
		}
		xmlWriter_0.WriteEndElement();
	}
}
