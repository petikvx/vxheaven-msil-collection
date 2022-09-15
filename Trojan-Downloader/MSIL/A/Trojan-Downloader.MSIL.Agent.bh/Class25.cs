using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

internal class Class25 : Class14
{
	protected IDictionary idictionary_1 = new Hashtable();

	protected IDictionary idictionary_2 = new Hashtable();

	protected string string_3 = null;

	protected Class29 class29_0;

	public Class26 class26_0;

	public Class25(Class26 class26_1)
		: base(null)
	{
		class26_0 = class26_1;
		class29_0 = new Class29(class26_1, null, null, ":", null, new Random());
	}

	public Class25(Class26 class26_1, XmlNode xmlNode_0)
		: base(null, xmlNode_0)
	{
		class26_0 = class26_1;
		class29_0 = new Class29(class26_1, null, null, ":", null, new Random());
		string_3 = (idictionary_0.Contains("src") ? (idictionary_0["src"] as string) : null);
		if (xmlNode_0 != null)
		{
			method_3(xmlNode_0.ChildNodes);
		}
	}

	[SpecialName]
	public bool method_1()
	{
		if (string_3 != null)
		{
			return string_3 == "";
		}
		return true;
	}

	protected bool method_2()
	{
		if (!method_1())
		{
			Class9 @class = new Class9(class26_0.class11_0);
			XmlNode xmlNode = @class.method_25(string_3);
			if (xmlNode != null)
			{
				string_3 = null;
				method_3(xmlNode.ChildNodes);
				return true;
			}
			return false;
		}
		return true;
	}

	protected void method_3(XmlNodeList xmlNodeList_0)
	{
		if (xmlNodeList_0 == null)
		{
			return;
		}
		foreach (XmlNode item in xmlNodeList_0)
		{
			if (!Class51.smethod_1(item))
			{
				Class26.smethod_0(this, item);
			}
		}
	}

	protected bool method_4(bool bool_0)
	{
		if (!method_1() && !method_2())
		{
			if (bool_0)
			{
				throw new Exception("78D2062B-83CD-482d-81C2-586C447FD89A");
			}
			return false;
		}
		return true;
	}

	public void method_5(Class17 class17_0)
	{
		idictionary_1[class17_0.string_1] = class17_0;
	}

	public Class17 method_6(string string_4)
	{
		method_4(bool_0: false);
		return idictionary_1[string_4] as Class17;
	}

	public void method_7(string string_4, Class28 class28_0)
	{
		while (string_4.StartsWith(":"))
		{
			string_4 = string_4.Substring(1, string_4.Length - 1);
		}
		class29_0.class28_0.method_28(string_4, class29_0.method_12(class28_0));
	}

	public void method_8(string string_4, Class28 class28_0, XmlNode xmlNode_0)
	{
		method_7(string_4, class28_0);
		idictionary_2.Add(string_4, xmlNode_0.InnerXml);
	}

	public Class28 method_9(string string_4)
	{
		method_4(bool_0: false);
		if (!string_4.StartsWith(":"))
		{
			string_4 = ":" + string_4;
		}
		else if (string_4.StartsWith("::"))
		{
			string_4 = string_4.Substring(1, string_4.Length - 1);
		}
		return class29_0.method_13(string_4);
	}

	public void method_10(ref Class28 class28_0)
	{
		method_4(bool_0: false);
		for (int i = 0; i < class29_0.class28_0.method_5(); i++)
		{
			class28_0.method_28(class29_0.class28_0.method_44(i), class29_0.class28_0.method_25(i).vmethod_4(new Class28()));
		}
	}

	[SpecialName]
	public Class17 method_11()
	{
		return method_6("Main");
	}

	public Class27 method_12()
	{
		if (class26_0.class25_0 != null && class26_0.class25_0.method_1() && method_4(bool_0: false))
		{
			return new Class27(class26_0, this);
		}
		return null;
	}

	public override void vmethod_0(XmlWriter xmlWriter_0)
	{
		xmlWriter_0.WriteStartElement(string_0);
		foreach (object item in idictionary_0)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			if (dictionaryEntry.Key as string!= "src")
			{
				xmlWriter_0.WriteAttributeString(dictionaryEntry.Key as string, dictionaryEntry.Value as string);
			}
		}
		if (string_3 != null && string_3 != "")
		{
			xmlWriter_0.WriteAttributeString("src", string_3);
		}
		foreach (object item2 in idictionary_2)
		{
			DictionaryEntry dictionaryEntry2 = (DictionaryEntry)item2;
			xmlWriter_0.WriteStartElement("Declare");
			xmlWriter_0.WriteAttributeString("var", dictionaryEntry2.Key as string);
			xmlWriter_0.WriteRaw(dictionaryEntry2.Value as string);
			xmlWriter_0.WriteEndElement();
		}
		foreach (Class17 value in idictionary_1.Values)
		{
			value.vmethod_0(xmlWriter_0);
		}
		xmlWriter_0.WriteEndElement();
	}

	public override void vmethod_1(Class27 class27_0, StringBuilder stringBuilder_0, int int_1)
	{
		method_4(bool_0: false);
		stringBuilder_0.AppendFormat("Node <{0}>,\t Sub {1}+{2}\r\n", class27_0.class14_0.string_0, method_11().string_1, class27_0.class14_0.int_0);
		stringBuilder_0.AppendFormat("In program {0}\r\n", string_1);
	}
}
