using System.Xml;

internal class Class29
{
	public string string_0;

	public string string_1;

	public string string_2;

	public Class29()
	{
	}

	public Class29(XmlNode xmlNode_0)
	{
		string_0 = xmlNode_0.InnerText;
		string_1 = GClass1.smethod_1(xmlNode_0, "user");
		string_2 = GClass1.smethod_1(xmlNode_0, "pwd");
	}

	public void method_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("Proxy");
		xmlWriter_0.WriteAttributeString("user", string_1);
		xmlWriter_0.WriteAttributeString("pwd", string_2);
		xmlWriter_0.WriteString(string_0);
		xmlWriter_0.WriteEndElement();
	}
}
