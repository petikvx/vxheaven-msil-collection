using System.Collections;
using System.Xml;

internal class Class0
{
	public string string_0;

	public string string_1;

	public string string_2;

	public Class11 class11_0;

	protected Hashtable hashtable_0 = new Hashtable();

	public Class0()
	{
	}

	public Class0(Class0 class0_0)
	{
		if (class0_0 != null)
		{
			class11_0 = ((class0_0 is Class11) ? (class0_0 as Class11) : class0_0.class11_0);
		}
	}

	public Class0(Class0 class0_0, XmlNode xmlNode_0)
	{
		if (class0_0 != null)
		{
			class11_0 = ((class0_0 is Class11) ? (class0_0 as Class11) : class0_0.class11_0);
		}
		if (xmlNode_0.NodeType != XmlNodeType.Text && xmlNode_0.NodeType != XmlNodeType.CDATA)
		{
			string_0 = xmlNode_0.Name;
			{
				foreach (XmlAttribute item in xmlNode_0.Attributes!)
				{
					if (item.Name == "id")
					{
						string_2 = item.Value;
					}
					else if (item.Name == "name")
					{
						string_1 = item.Value;
					}
					hashtable_0.Add(item.Name, item.Value);
				}
				return;
			}
		}
		string_0 = "E";
	}

	public virtual void vmethod_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement(string_0);
		foreach (object item in hashtable_0)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			xmlWriter_0.WriteAttributeString(dictionaryEntry.Key as string, dictionaryEntry.Value as string);
		}
		xmlWriter_0.WriteEndElement();
	}
}
