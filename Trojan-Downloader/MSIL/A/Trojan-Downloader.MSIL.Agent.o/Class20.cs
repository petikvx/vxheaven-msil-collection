using System;
using System.Xml;

internal class Class20
{
	public Class18 class18_0;

	public Enum0 enum0_0 = Enum0.Get;

	public string string_0;

	public string string_1;

	public string string_2;

	public int int_0 = int.MaxValue;

	public Class20()
	{
	}

	public Class20(Class18 class18_1, XmlNode xmlNode_0)
	{
		class18_0 = class18_1;
		enum0_0 = (Enum0)Enum.Parse(typeof(Enum0), GClass1.smethod_0(xmlNode_0, "action", "Get"), ignoreCase: false);
		string_0 = xmlNode_0.Attributes!["tag"]!.Value;
		string_1 = xmlNode_0.Attributes!["attribute"]!.Value;
		int_0 = GClass1.smethod_3(GClass1.smethod_0(xmlNode_0, "max", int.MaxValue.ToString()), int.MaxValue);
		string_2 = xmlNode_0.InnerText;
	}

	public void method_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("Resource");
		xmlWriter_0.WriteAttributeString("action", enum0_0.ToString());
		xmlWriter_0.WriteAttributeString("tag", string_0);
		xmlWriter_0.WriteAttributeString("attribute", string_1);
		if (int_0 != int.MaxValue)
		{
			xmlWriter_0.WriteAttributeString("max", int_0.ToString());
		}
		xmlWriter_0.WriteString(string_2);
		xmlWriter_0.WriteEndElement();
	}
}
