using System.Xml;

internal class Class31
{
	public string string_0;

	public double double_0;

	public Class31()
	{
	}

	public Class31(string string_1, double double_1)
	{
		string_0 = string_1;
		double_0 = double_1;
	}

	public Class31(XmlNode xmlNode_0)
	{
		string_0 = xmlNode_0.InnerText;
		double_0 = GClass1.smethod_4(xmlNode_0.Attributes!["weight"]!.Value, 1.0);
	}

	public void method_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("UserAgent");
		xmlWriter_0.WriteAttributeString("weight", double_0.ToString());
		xmlWriter_0.WriteString(string_0);
		xmlWriter_0.WriteEndElement();
	}
}
