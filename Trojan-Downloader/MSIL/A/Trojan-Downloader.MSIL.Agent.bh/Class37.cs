using System.Xml;

internal class Class37
{
	public string string_0;

	public double double_0;

	public Class37()
	{
	}

	public Class37(string string_1, double double_1)
	{
		string_0 = string_1;
		double_0 = double_1;
	}

	public Class37(XmlNode xmlNode_0)
	{
		string_0 = xmlNode_0.InnerText;
		double_0 = Class51.smethod_10(xmlNode_0.Attributes!["weight"]!.Value, 1.0);
	}

	public void method_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("UserAgent");
		xmlWriter_0.WriteAttributeString("weight", Class51.smethod_2(double_0));
		xmlWriter_0.WriteString(string_0);
		xmlWriter_0.WriteEndElement();
	}
}
