using System;
using System.Xml;

internal class Class7
{
	public Class34 class34_0;

	public Enum1 enum1_0 = Enum1.Get;

	public string string_0;

	public string string_1;

	public string string_2;

	public int int_0 = int.MaxValue;

	public Class7()
	{
	}

	public Class7(Class34 class34_1, XmlNode xmlNode_0)
	{
		class34_0 = class34_1;
		enum1_0 = (Enum1)Enum.Parse(typeof(Enum1), Class51.smethod_0(xmlNode_0, "Get", "action"), ignoreCase: false);
		string_0 = xmlNode_0.Attributes!["tag"]!.Value;
		string_1 = xmlNode_0.Attributes!["attribute"]!.Value;
		int_0 = Class51.smethod_9(Class51.smethod_0(xmlNode_0, Class51.smethod_3(int.MaxValue), "max"), int.MaxValue);
		string_2 = xmlNode_0.InnerText;
	}

	public void method_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("Resource");
		xmlWriter_0.WriteAttributeString("action", Class51.smethod_8(enum1_0));
		xmlWriter_0.WriteAttributeString("tag", string_0);
		xmlWriter_0.WriteAttributeString("attribute", string_1);
		if (int_0 != int.MaxValue)
		{
			xmlWriter_0.WriteAttributeString("max", Class51.smethod_3(int_0));
		}
		xmlWriter_0.WriteString(string_2);
		xmlWriter_0.WriteEndElement();
	}
}
