using System;
using System.Xml;

internal class Class33
{
	public string string_0;

	public string string_1;

	public string string_2;

	public TimeSpan timeSpan_0;

	public DateTime dateTime_0;

	public Class33()
	{
	}

	public Class33(string string_3, string string_4, TimeSpan timeSpan_1)
	{
		string_1 = string_4;
		string_2 = string_3;
		timeSpan_0 = timeSpan_1;
		dateTime_0 = DateTime.MinValue;
		string_0 = smethod_0(string_1, string_2);
	}

	public static string smethod_0(string string_3, string string_4)
	{
		return string_3 + "," + string_4;
	}

	public void method_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement("OwnerAccount");
		xmlWriter_0.WriteAttributeString("lastVisitDate", Class51.smethod_14(dateTime_0));
		xmlWriter_0.WriteString(string_0);
		xmlWriter_0.WriteEndElement();
	}
}
