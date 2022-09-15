using System.Xml;

internal class Class35
{
	public string string_0;

	public string string_1;

	public string string_2;

	public Class35()
	{
	}

	public Class35(XmlNode xmlNode_0)
	{
		string_0 = xmlNode_0.InnerText;
		string_1 = Class51.smethod_0(xmlNode_0, null, "user");
		string_2 = Class51.smethod_0(xmlNode_0, null, "pwd");
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
