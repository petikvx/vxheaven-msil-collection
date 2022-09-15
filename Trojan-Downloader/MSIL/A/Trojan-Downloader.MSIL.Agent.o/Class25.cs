using System;
using System.Xml;

internal class Class25
{
	public string string_0;

	public string string_1;

	public string string_2;

	public string string_3;

	public int int_0;

	public Enum1 enum1_0 = Enum1.Unknown;

	public string string_4;

	public string string_5;

	public DateTime dateTime_0 = DateTime.MinValue;

	public Class25()
	{
	}

	public Class25(XmlNode xmlNode_0)
	{
		dateTime_0 = GClass1.smethod_7(xmlNode_0.Attributes!["timestamp"]!.Value, DateTime.MinValue);
		string_0 = GClass1.smethod_0(xmlNode_0, "domain", null);
		string_1 = GClass1.smethod_0(xmlNode_0, "host", null);
		string_3 = GClass1.smethod_0(xmlNode_0, "url", null);
		string_2 = GClass1.smethod_0(xmlNode_0, "proxy", null);
		int_0 = GClass1.smethod_3(GClass1.smethod_0(xmlNode_0, "errorCode", "-1"), -1);
		enum1_0 = (Enum1)GClass1.smethod_3(GClass1.smethod_0(xmlNode_0, "visitutcome", "99"), 99);
		string_4 = GClass1.smethod_0(xmlNode_0, "type", null);
		string_5 = xmlNode_0.InnerText;
	}

	public void method_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("Error");
		xmlWriter_0.WriteAttributeString("timestamp", GClass1.smethod_8(dateTime_0));
		if (string_0 != null)
		{
			xmlWriter_0.WriteAttributeString("domain", string_0);
		}
		if (string_1 != null)
		{
			xmlWriter_0.WriteAttributeString("host", string_1);
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
			xmlWriter_0.WriteAttributeString("errorCode", int_0.ToString());
		}
		if (string_4 != null)
		{
			xmlWriter_0.WriteAttributeString("type", string_4);
		}
		if (enum1_0 != Enum1.Unknown)
		{
			int num = (int)enum1_0;
			xmlWriter_0.WriteAttributeString("visitOutcome", num.ToString());
		}
		xmlWriter_0.WriteString(string_5);
		xmlWriter_0.WriteEndElement();
	}
}
