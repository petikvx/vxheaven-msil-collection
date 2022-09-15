using System.Collections;
using System.Text;
using System.Xml;

internal class Class14
{
	public string string_0;

	public string string_1;

	public string string_2;

	public Class25 class25_0;

	public int int_0;

	protected IDictionary idictionary_0 = new Hashtable();

	public Class14()
	{
	}

	public Class14(Class14 class14_0)
	{
		if (class14_0 != null)
		{
			class25_0 = ((class14_0 is Class25) ? (class14_0 as Class25) : class14_0.class25_0);
		}
	}

	public Class14(Class14 class14_0, XmlNode xmlNode_0)
	{
		if (class14_0 != null)
		{
			class25_0 = ((class14_0 is Class25) ? (class14_0 as Class25) : class14_0.class25_0);
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
					idictionary_0.Add(item.Name, item.Value);
				}
				return;
			}
		}
		string_0 = "E";
	}

	public virtual void vmethod_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement(string_0);
		foreach (object item in idictionary_0)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			xmlWriter_0.WriteAttributeString(dictionaryEntry.Key as string, dictionaryEntry.Value as string);
		}
		xmlWriter_0.WriteEndElement();
	}

	public virtual void vmethod_1(Class27 class27_0, StringBuilder stringBuilder_0, int int_1)
	{
	}

	public string method_0(Class27 class27_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		vmethod_1(class27_0, stringBuilder, 0);
		return stringBuilder.ToString();
	}
}
