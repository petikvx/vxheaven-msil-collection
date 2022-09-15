using System;
using System.Xml;

internal class Class13
{
	public string string_0;

	public string string_1;

	public string string_2;

	public string string_3;

	public int int_0;

	public Enum3 enum3_0 = Enum3.Unknown;

	public string string_4;

	public string string_5;

	public DateTime dateTime_0 = DateTime.MinValue;

	public Class13()
	{
	}

	public Class13(XmlNode xmlNode_0)
	{
		dateTime_0 = Class51.smethod_13(xmlNode_0.Attributes!["timestamp"]!.Value, DateTime.MinValue);
		string_0 = Class51.smethod_0(xmlNode_0, null, "domain");
		string_1 = Class51.smethod_0(xmlNode_0, null, "parking");
		string_3 = Class51.smethod_0(xmlNode_0, null, "url");
		string_2 = Class51.smethod_0(xmlNode_0, null, "proxy");
		int_0 = Class51.smethod_9(Class51.smethod_0(xmlNode_0, "-1", "errorCode"), -1);
		enum3_0 = (Enum3)Class51.smethod_9(Class51.smethod_0(xmlNode_0, 0.ToString(), "visitOutcome"), 0);
		string_4 = Class51.smethod_0(xmlNode_0, null, "type");
		string_5 = xmlNode_0.InnerText;
	}

	public void method_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("Error");
		xmlWriter_0.WriteAttributeString("timestamp", Class51.smethod_14(dateTime_0));
		if (string_0 != null)
		{
			xmlWriter_0.WriteAttributeString("domain", string_0);
		}
		if (string_1 != null)
		{
			xmlWriter_0.WriteAttributeString("parking", string_1);
		}
		if (string_3 != null)
		{
			xmlWriter_0.WriteAttributeString("url", string_3);
		}
		if (string_2 != null)
		{
			xmlWriter_0.WriteAttributeString("proxy", string_2);
		}
		if (int_0 != -1)
		{
			xmlWriter_0.WriteAttributeString("errorCode", Class51.smethod_3(int_0));
		}
		if (string_4 != null)
		{
			xmlWriter_0.WriteAttributeString("type", string_4);
		}
		if (enum3_0 != 0)
		{
			xmlWriter_0.WriteAttributeString("visitOutcome", Class51.smethod_3((int)enum3_0));
		}
		xmlWriter_0.WriteString(string_5);
		xmlWriter_0.WriteEndElement();
	}
}
