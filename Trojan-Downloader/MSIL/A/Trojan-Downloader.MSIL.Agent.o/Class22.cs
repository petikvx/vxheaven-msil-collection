using System.Web;
using System.Xml;

internal class Class22 : Class21
{
	protected string string_3;

	public Class22(Class23 class23_1)
		: base(class23_1)
	{
		string_3 = class23_0.string_1;
		if (!string_3.EndsWith("/"))
		{
			string_3 += "/";
		}
		string_2 = new string[2]
		{
			"W3CS-Version: " + class23_0.string_2,
			"W3CS-Tag: " + class23_0.guid_0
		};
	}

	protected string method_11(string string_4, string string_5)
	{
		Class26 class26_ = method_1("POST", string_4, null, string_5, null, "application/x-www-form-urlencoded", null, null, bool_0: true, bool_1: false, null);
		Class27 @class = method_3(class26_, bool_0: false);
		return method_14(@class.method_4());
	}

	public string method_12(string string_4)
	{
		string string_5 = string_3 + "duper.php";
		string_4 = "report=" + HttpUtility.UrlEncode(string_4, Class24.encoding_0);
		return method_11(string_5, string_4);
	}

	public string method_13(string string_4)
	{
		string string_5 = string_3 + "proxies.php";
		string_4 = "report=" + HttpUtility.UrlEncode(string_4, Class24.encoding_0);
		return method_11(string_5, string_4);
	}

	protected string method_14(string string_4)
	{
		int num = string_4.IndexOf("W3CS-Result=");
		if (num >= 0)
		{
			num += "W3CS-Result=".Length;
			return string_4.Substring(num, string_4.Length - num);
		}
		return string_4;
	}

	public XmlNode method_15(string string_4)
	{
		string text = string_3 + "getpro.php?name=" + HttpUtility.UrlEncode(string_4);
		string text2 = method_8(text);
		if (text2 != null)
		{
			text2 = GClass1.smethod_12(text2);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(text2);
			return xmlDocument.DocumentElement;
		}
		return null;
	}
}
