using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

internal class Class12
{
	public static readonly Class37[] class37_0;

	public static readonly string string_0;

	public static CultureInfo cultureInfo_0;

	public static Encoding encoding_0;

	protected string string_1;

	protected string string_2;

	public Enum2 enum2_0 = Enum2.const_0;

	protected IDictionary idictionary_0;

	protected IDictionary idictionary_1;

	protected IDictionary idictionary_2;

	protected Class11 class11_0;

	static Class12()
	{
		class37_0 = new Class37[9]
		{
			new Class37("Mozilla/4.0 (compatible; MSIE 4.01; AOL 4.0; Windows 98)", 10.0),
			new Class37("Mozilla/4.0 (compatible; MSIE 4.01; Windows 95)", 10.0),
			new Class37("Mozilla/4.0 (compatible; MSIE 4.01; Windows CE; MSN Companion 2.0; 800x600; Compaq)", 3.0),
			new Class37("Mozilla/4.0 (compatible; MSIE 4.01; Windows NT Windows CE)", 10.0),
			new Class37("Mozilla/4.0 (compatible; MSIE 4.01; Windows NT)", 10.0),
			new Class37("Mozilla/4.0 (compatible; MSIE 5.5; Windows NT 5.0; .NET CLR 1.0.3705)", 25.0),
			new Class37("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0; .NET CLR 1.1.4322; Lunascape 2.1.3)", 5.0),
			new Class37("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; Hotbar 3.0)", 5.0),
			new Class37("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322)", 40.0)
		};
		string_0 = "usb2e.dat";
		cultureInfo_0 = new CultureInfo("en-US");
		encoding_0 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
	}

	public Class12(Class11 class11_1)
	{
		class11_0 = class11_1;
		try
		{
			string_1 = Path.GetDirectoryName(class11_0.assembly_0.Location);
			string_2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			if (string_2 == null)
			{
				string_2 = string_1;
			}
			string_2 = Path.Combine(string_2, "IT Worx Inc");
			if (!Directory.Exists(string_2))
			{
				Directory.CreateDirectory(string_2);
			}
		}
		catch (Exception exception_)
		{
			method_0("31E87ABA-69D9-4685-8E85-B0E5FBFDF2FD", exception_);
		}
	}

	protected void method_0(string string_3, Exception exception_0)
	{
		class11_0.method_20(string_3, exception_0);
	}

	public bool method_1()
	{
		if (class11_0.guid_0 == Guid.Empty)
		{
			class11_0.method_45();
		}
		if (class11_0.guid_0 == Guid.Empty)
		{
			class11_0.guid_0 = Guid.NewGuid();
		}
		class11_0.method_46();
		return class11_0.guid_0 != Guid.Empty;
	}

	public void method_2()
	{
		try
		{
			if (class11_0.class5_0 != null)
			{
				idictionary_0 = new Hashtable();
				Class5[] class5_ = class11_0.class5_0;
				foreach (Class5 @class in class5_)
				{
					idictionary_0[@class.string_0] = new object[5] { @class.int_0, @class.int_1, @class.int_2, @class.dateTime_0, @class.dateTime_1 };
				}
			}
			if (class11_0.class34_0 != null)
			{
				idictionary_1 = new Hashtable();
				Class34[] class34_ = class11_0.class34_0;
				foreach (Class34 class2 in class34_)
				{
					idictionary_1[class2.string_0] = new object[4] { class2.int_0, class2.int_1, class2.int_2, class2.dateTime_0 };
				}
			}
			if (class11_0.class33_0 != null)
			{
				idictionary_2 = new Hashtable();
				Class33[] class33_ = class11_0.class33_0;
				foreach (Class33 class3 in class33_)
				{
					idictionary_2[class3.string_0] = new object[1] { class3.dateTime_0 };
				}
			}
		}
		catch (Exception exception_)
		{
			method_0("B2380342-60EF-45ce-A8AA-23D156746833", exception_);
		}
	}

	public bool method_3()
	{
		try
		{
			if (string_2 == null)
			{
				return false;
			}
			string path = Path.Combine(string_2, string_0);
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			return true;
		}
		catch (Exception exception_)
		{
			method_0("895FC4C3-DC64-4c9c-919B-557A0E47FD2D", exception_);
			return false;
		}
	}

	public bool method_4()
	{
		try
		{
			method_1();
			if (string_2 == null)
			{
				return false;
			}
			string value = Class51.smethod_24(class11_0.method_4(bool_7: true), class11_0);
			StreamWriter streamWriter = new StreamWriter(Path.Combine(string_2, string_0), append: false, encoding_0);
			streamWriter.Write(value);
			streamWriter.Close();
			return true;
		}
		catch (Exception exception_)
		{
			method_0("3B578E59-0835-4116-98D1-5454AE199A0D", exception_);
			return false;
		}
		finally
		{
			class11_0.dateTime_8 = DateTime.Now;
		}
	}

	public void method_5()
	{
		try
		{
			if (idictionary_0 != null && class11_0.class5_0 != null)
			{
				Class5[] class5_ = class11_0.class5_0;
				foreach (Class5 @class in class5_)
				{
					if (idictionary_0[@class.string_0] is object[] array)
					{
						@class.int_0 = (int)array[0];
						@class.int_1 = (int)array[1];
						@class.int_2 = (int)array[2];
						@class.dateTime_0 = (DateTime)array[3];
						@class.dateTime_1 = (DateTime)array[4];
					}
				}
				idictionary_0 = null;
			}
			if (idictionary_1 != null && class11_0.class34_0 != null)
			{
				Class34[] class34_ = class11_0.class34_0;
				foreach (Class34 class2 in class34_)
				{
					if (idictionary_1[class2.string_0] is object[] array2)
					{
						class2.int_0 = (int)array2[0];
						class2.int_1 = (int)array2[1];
						class2.int_2 = (int)array2[2];
						class2.dateTime_0 = (DateTime)array2[3];
					}
				}
				idictionary_1 = null;
			}
			if (idictionary_2 == null || class11_0.class33_0 == null)
			{
				return;
			}
			Class33[] class33_ = class11_0.class33_0;
			foreach (Class33 class3 in class33_)
			{
				if (idictionary_2[class3.string_0] is object[] array3)
				{
					class3.dateTime_0 = (DateTime)array3[0];
				}
			}
			idictionary_2 = null;
		}
		catch (Exception exception_)
		{
			method_0("6A03D108-8B9B-46dd-BC98-FBCEEAF42024", exception_);
		}
	}

	protected bool method_6(string string_3, bool bool_0)
	{
		try
		{
			if (string_3 != null && File.Exists(string_3))
			{
				using (StreamReader streamReader = new StreamReader(string_3))
				{
					string string_4 = streamReader.ReadToEnd();
					if (bool_0)
					{
						string_4 = Class51.smethod_25(string_4);
					}
					return class11_0.method_5(string_4, this);
				}
			}
			return false;
		}
		catch (Exception exception_)
		{
			method_0("BBCFB54C-1484-41d0-930C-723116CB4567", exception_);
			return false;
		}
	}

	public bool method_7()
	{
		if (string_1 == null)
		{
			return false;
		}
		string text = Path.Combine(string_1, "usb2e.xml");
		if (File.Exists(text))
		{
			return method_6(text, bool_0: false);
		}
		return true;
	}

	public bool method_8()
	{
		if (string_2 == null)
		{
			return false;
		}
		string string_ = Path.Combine(string_2, string_0);
		return method_6(string_, bool_0: true);
	}

	public bool method_9(XmlNode xmlNode_0, ref Class5[] class5_0)
	{
		try
		{
			if (xmlNode_0.Attributes!["subset"] != null && Class51.smethod_11(xmlNode_0.Attributes!["subset"]!.Value, bool_0: false))
			{
				if (class11_0.idictionary_1 != null)
				{
					foreach (XmlNode childNode in xmlNode_0.ChildNodes)
					{
						try
						{
							if (class11_0.idictionary_1[childNode.InnerText] is Class5 @class)
							{
								@class.method_7(childNode);
							}
						}
						catch (Exception exception_)
						{
							method_0("22F87B2C-4003-4660-BD81-8F56F7DA1078: " + childNode.OuterXml, exception_);
						}
					}
					return true;
				}
				return false;
			}
			ArrayList arrayList = new ArrayList();
			foreach (XmlNode childNode2 in xmlNode_0.ChildNodes)
			{
				if (!Class51.smethod_1(childNode2))
				{
					try
					{
						arrayList.Add(new Class5(class11_0, childNode2));
					}
					catch (Exception exception_2)
					{
						method_0("52D75A2F-3DB1-4867-A870-F8C8AB082792: " + childNode2.OuterXml, exception_2);
					}
				}
			}
			class5_0 = arrayList.ToArray(typeof(Class5)) as Class5[];
			return true;
		}
		catch (Exception exception_3)
		{
			method_0("D0272D9A-2198-41b6-B6F8-A06615C2C831", exception_3);
			return false;
		}
	}

	public bool method_10(XmlNode xmlNode_0, ref Class6 class6_0)
	{
		try
		{
			class6_0 = new Class6(null, xmlNode_0);
			return true;
		}
		catch (Exception exception_)
		{
			method_0("85B45ABC-4D6F-4ff5-92B5-AE8B9E538C05: " + xmlNode_0, exception_);
			return false;
		}
	}

	public bool method_11(XmlNode xmlNode_0, ref Class34[] class34_0)
	{
		try
		{
			if (xmlNode_0.Attributes!["subset"] != null && Class51.smethod_11(xmlNode_0.Attributes!["subset"]!.Value, bool_0: false))
			{
				foreach (XmlNode childNode in xmlNode_0.ChildNodes)
				{
					if (Class51.smethod_1(childNode))
					{
						continue;
					}
					string text = ((xmlNode_0.Attributes!["name"] != null) ? xmlNode_0.Attributes!["name"]!.Value : null);
					if (text == null)
					{
						XmlNode xmlNode2 = childNode.FirstChild;
						while (xmlNode2 != null && xmlNode2.Name != "Name")
						{
							xmlNode2 = xmlNode2.NextSibling;
						}
						if (xmlNode2 != null && xmlNode2.Name != "Name")
						{
							text = xmlNode2.InnerText;
						}
					}
					if (text == null)
					{
						continue;
					}
					try
					{
						if (class11_0.idictionary_0 != null && class11_0.idictionary_0[text] is Class34 @class)
						{
							@class.method_7(childNode);
						}
					}
					catch (Exception exception_)
					{
						method_0("41B37E0D-4307-4e8e-8B8D-0E9DB99B9142: " + childNode.OuterXml, exception_);
					}
				}
			}
			else
			{
				ArrayList arrayList = new ArrayList();
				foreach (XmlNode childNode2 in xmlNode_0.ChildNodes)
				{
					if (!Class51.smethod_1(childNode2))
					{
						try
						{
							arrayList.Add(new Class34(class11_0, childNode2));
						}
						catch (Exception exception_2)
						{
							method_0("11AD6D47-C396-491f-BCD2-D948A9CDB74B", exception_2);
						}
					}
				}
				class34_0 = arrayList.ToArray(typeof(Class34)) as Class34[];
			}
			return true;
		}
		catch (Exception exception_3)
		{
			method_0("C08C03CE-9843-47db-9E7E-399B64F23D40", exception_3);
			return false;
		}
	}

	public bool method_12(XmlNode xmlNode_0, ref Class38 class38_0)
	{
		try
		{
			class38_0 = new Class38(class11_0, xmlNode_0);
			return true;
		}
		catch (Exception exception_)
		{
			method_0("CC0FA734-882E-4f1a-9B98-CEFA41AEE227: " + xmlNode_0.OuterXml, exception_);
			return false;
		}
	}

	public bool method_13(XmlNode xmlNode_0, ref Class13[] class13_0)
	{
		try
		{
			ArrayList arrayList = new ArrayList();
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				if (!Class51.smethod_1(childNode))
				{
					try
					{
						arrayList.Add(new Class13(childNode));
					}
					catch (Exception exception_)
					{
						method_0("5E51AD48-25D9-46df-B38B-7B0411248E41: " + childNode.OuterXml, exception_);
					}
				}
			}
			class13_0 = arrayList.ToArray(typeof(Class13)) as Class13[];
			return true;
		}
		catch (Exception exception_2)
		{
			method_0("5D76F27C-CD78-4ddc-B928-2E5E044EA3F6", exception_2);
			return false;
		}
	}

	public bool method_14(XmlNode xmlNode_0, ref Class37[] class37_1)
	{
		try
		{
			ArrayList arrayList = new ArrayList();
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				if (!Class51.smethod_1(childNode))
				{
					try
					{
						arrayList.Add(new Class37(childNode));
					}
					catch (Exception exception_)
					{
						method_0("27BC555B-1606-4488-B0E6-0D4C07D98687: " + childNode.OuterXml, exception_);
					}
				}
			}
			class37_1 = arrayList.ToArray(typeof(Class37)) as Class37[];
			return true;
		}
		catch (Exception exception_2)
		{
			method_0("413AC07D-C760-4b55-8EB6-9E55E047D8B3", exception_2);
			return false;
		}
	}

	public bool method_15(XmlNode xmlNode_0, ref Class35[] class35_0, ref Class35 class35_1)
	{
		try
		{
			ArrayList arrayList = new ArrayList();
			bool flag = false;
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				if (Class51.smethod_1(childNode))
				{
					continue;
				}
				try
				{
					Class35 @class = null;
					arrayList.Add(@class = new Class35(childNode));
					if (@class.string_0 == "")
					{
						flag = true;
						class35_1 = @class;
					}
				}
				catch (Exception exception_)
				{
					method_0("94EA2776-5312-4aa6-A621-4DD4AC0CB592: " + childNode.OuterXml, exception_);
				}
			}
			if (!flag)
			{
				arrayList.Add(class35_1 = new Class35());
			}
			class35_0 = arrayList.ToArray(typeof(Class35)) as Class35[];
			return true;
		}
		catch (Exception exception_2)
		{
			method_0("3FF52CF8-D34F-4651-8396-5DCF6E11D519", exception_2);
			return false;
		}
	}

	public bool method_16(XmlNode xmlNode_0)
	{
		try
		{
			IDictionary dictionary = new Hashtable();
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				try
				{
					dictionary.Add(childNode.InnerText, new object[1] { Class51.smethod_13(childNode.Attributes!["lastVisitDate"]!.Value, DateTime.MinValue) });
				}
				catch (Exception exception_)
				{
					method_0("A8B76806-DB56-4824-8E8B-250A2BFC523F: " + childNode.OuterXml, exception_);
				}
			}
			idictionary_2 = dictionary;
			return true;
		}
		catch (Exception exception_2)
		{
			method_0("A8B76806-DB56-4824-8E8B-250A2BFC523F: " + xmlNode_0.OuterXml, exception_2);
			return false;
		}
	}

	public bool method_17(XmlNode xmlNode_0, ref double[] double_0)
	{
		try
		{
			double[] array = new double[24];
			for (int i = 0; i < 24; i++)
			{
				array[i] = 1.0;
			}
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				if (!Class51.smethod_1(childNode))
				{
					int num = Class51.smethod_9(childNode.Attributes!["hour"]!.Value, -1);
					if (num >= 0 && num < 24)
					{
						array[num] = Class51.smethod_10(childNode.InnerText, 1.0);
					}
				}
			}
			double_0 = array;
			return true;
		}
		catch (Exception exception_)
		{
			method_0("A8B76806-DB56-4824-8E8B-250A2BFC523F: " + xmlNode_0.OuterXml, exception_);
			return false;
		}
	}

	public bool method_18(XmlNode xmlNode_0, ref double[] double_0)
	{
		try
		{
			double[] array = new double[7];
			for (int i = 0; i < 7; i++)
			{
				array[i] = 1.0;
			}
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				if (!Class51.smethod_1(childNode))
				{
					try
					{
						DayOfWeek dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), childNode.Attributes!["day"]!.Value, ignoreCase: true);
						array[(int)dayOfWeek % 7] = Class51.smethod_10(childNode.InnerText, 1.0);
					}
					catch (Exception exception_)
					{
						method_0("39898289-9007-463b-85CB-E3D7CEA87689: " + childNode.OuterXml, exception_);
					}
				}
			}
			double_0 = array;
			return true;
		}
		catch (Exception exception_2)
		{
			method_0("1D495365-F0CF-49b1-832E-B25452FD3F9E", exception_2);
			return false;
		}
	}
}
