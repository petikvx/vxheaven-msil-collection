using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Security;
using System.Text;
using System.Xml;
using Microsoft.Win32;

internal class Class24
{
	public const string string_0 = "nsssvc.dat";

	public static readonly Class31[] class31_0;

	public static Encoding encoding_0;

	protected static int int_0;

	protected static string string_1;

	protected static string string_2;

	protected Hashtable hashtable_0;

	protected Hashtable hashtable_1;

	protected Hashtable hashtable_2;

	protected Class23 class23_0;

	static Class24()
	{
		class31_0 = new Class31[9]
		{
			new Class31("Mozilla/4.0 (compatible; MSIE 4.01; AOL 4.0; Windows 98)", 10.0),
			new Class31("Mozilla/4.0 (compatible; MSIE 4.01; Windows 95)", 10.0),
			new Class31("Mozilla/4.0 (compatible; MSIE 4.01; Windows CE; MSN Companion 2.0; 800x600; Compaq)", 3.0),
			new Class31("Mozilla/4.0 (compatible; MSIE 4.01; Windows NT Windows CE)", 10.0),
			new Class31("Mozilla/4.0 (compatible; MSIE 4.01; Windows NT)", 10.0),
			new Class31("Mozilla/4.0 (compatible; MSIE 5.5; Windows NT 5.0; .NET CLR 1.0.3705)", 25.0),
			new Class31("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0; .NET CLR 1.1.4322; Lunascape 2.1.3)", 5.0),
			new Class31("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; Hotbar 3.0)", 5.0),
			new Class31("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322)", 40.0)
		};
		encoding_0 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
		int_0 = 0;
		try
		{
			string_1 = Path.GetDirectoryName(Assembly.GetAssembly(typeof(Class24))!.Location);
			string_2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			if (string_2 == null)
			{
				string_2 = string_1;
			}
			string_2 = Path.Combine(string_2, "W3C Corporation");
			if (!Directory.Exists(string_2))
			{
				Directory.CreateDirectory(string_2);
			}
		}
		catch
		{
		}
	}

	public Class24(Class23 class23_1)
	{
		class23_0 = class23_1;
	}

	protected void method_0(Exception exception_0)
	{
		class23_0.method_13(exception_0);
	}

	protected bool method_1(string string_3)
	{
		if (string_3 != null && !(string_3 == ""))
		{
			if (method_2(string_3) && !method_3(string_3))
			{
				if (method_2(string_3))
				{
					method_4(string_3);
					return false;
				}
				return true;
			}
			class23_0.dateTime_2 = DateTime.Now;
			class23_0.method_7();
			return true;
		}
		return false;
	}

	protected bool method_2(string string_3)
	{
		return string_3.StartsWith("<?xml version=\"1.0\" encoding=\"utf-8\"?><Error");
	}

	protected bool method_3(string string_3)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(string_3);
		if (xmlDocument.DocumentElement != null && !(xmlDocument.DocumentElement!.Name != "Error"))
		{
			string attribute = xmlDocument.DocumentElement!.GetAttribute("hints");
			if (attribute != null)
			{
				return attribute.IndexOf("|Report Processed|") != -1;
			}
			return false;
		}
		return true;
	}

	protected bool method_4(string string_3)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(string_3);
		if (xmlDocument.DocumentElement != null && !(xmlDocument.DocumentElement!.Name != "Error"))
		{
			XmlNodeList elementsByTagName = xmlDocument.DocumentElement!.GetElementsByTagName("Maintenance");
			if (elementsByTagName.Count > 0)
			{
				XmlElement xmlElement = elementsByTagName[0] as XmlElement;
				TimeSpan timeSpan = GClass1.smethod_6(xmlElement.Attributes["duration"]!.Value, TimeSpan.FromMinutes(30.0));
				class23_0.timeSpan_2 = DateTime.Now + timeSpan - class23_0.dateTime_3;
				return true;
			}
			return false;
		}
		return false;
	}

	public bool method_5()
	{
		Class22 @class = null;
		try
		{
			class23_0.dateTime_5 = DateTime.Now;
			if (class23_0.string_1 == null)
			{
				return false;
			}
			@class = new Class22(class23_0);
			string string_ = GClass1.smethod_11(class23_0.method_2());
			string text = GClass1.smethod_12(@class.method_13(string_));
			if (!method_1(text))
			{
				return false;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(text);
			bool result;
			if (result = class23_0.method_4(this, text, bool_5: true, bool_6: false))
			{
				method_11();
			}
			return result;
		}
		catch (Exception exception_)
		{
			method_0(exception_);
			return false;
		}
		finally
		{
			@class?.method_5();
		}
	}

	protected bool method_6()
	{
		string text = method_15();
		if (!method_1(text))
		{
			return false;
		}
		return class23_0.method_4(this, text, bool_5: true, bool_6: false);
	}

	public bool method_7()
	{
		try
		{
			class23_0.dateTime_5 = (class23_0.dateTime_3 = DateTime.Now);
			bool flag = false;
			if (int_0 > 0)
			{
				flag = method_6();
			}
			else
			{
				method_14();
				class23_0.method_4(this, null, bool_5: true, bool_6: false);
				method_13();
				if (class23_0.guid_0 == Guid.Empty)
				{
					class23_0.guid_0 = method_8(Registry.LocalMachine);
				}
				if (class23_0.guid_0 == Guid.Empty)
				{
					class23_0.guid_0 = Guid.NewGuid();
				}
				method_9(Registry.LocalMachine, class23_0.guid_0);
				flag = method_6();
			}
			if (class23_0.bool_4)
			{
				return flag;
			}
			method_13();
			method_11();
			int_0++;
			return flag;
		}
		catch (Exception exception_)
		{
			method_0(exception_);
			return false;
		}
	}

	protected Guid method_8(RegistryKey registryKey_0)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = registryKey_0.OpenSubKey("Software\\W3C Corporation\\nsssvc");
			if (registryKey == null)
			{
				registryKey = registryKey_0.CreateSubKey("Software\\W3C Corporation\\nsssvc");
			}
			if (registryKey == null)
			{
				return Guid.Empty;
			}
			object value = registryKey.GetValue(null);
			if (value != null)
			{
				return new Guid(value as string);
			}
			return Guid.Empty;
		}
		catch (SecurityException exception_)
		{
			if (registryKey_0 == Registry.LocalMachine)
			{
				return method_8(Registry.CurrentUser);
			}
			class23_0.method_13(exception_);
			return Guid.Empty;
		}
		catch (Exception exception_2)
		{
			class23_0.method_13(exception_2);
			return Guid.Empty;
		}
		finally
		{
			registryKey?.Close();
		}
	}

	protected void method_9(RegistryKey registryKey_0, Guid guid_0)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = registryKey_0.OpenSubKey("Software\\W3C Corporation\\nsssvc", writable: true);
			if (registryKey == null)
			{
				registryKey = registryKey_0.CreateSubKey("Software\\W3C Corporation\\nsssvc");
			}
			registryKey?.SetValue(null, guid_0.ToString());
		}
		catch (SecurityException exception_)
		{
			if (registryKey_0 == Registry.LocalMachine)
			{
				method_9(Registry.CurrentUser, guid_0);
			}
			else
			{
				class23_0.method_13(exception_);
			}
		}
		catch (Exception exception_2)
		{
			class23_0.method_13(exception_2);
		}
		finally
		{
			registryKey?.Close();
		}
	}

	public void method_10()
	{
		try
		{
			if (class23_0.class17_0 != null)
			{
				hashtable_0 = new Hashtable();
				Class17[] class17_ = class23_0.class17_0;
				foreach (Class17 @class in class17_)
				{
					hashtable_0.Add(@class.string_0, new object[5] { @class.int_0, @class.int_1, @class.int_2, @class.dateTime_0, @class.dateTime_1 });
				}
			}
			if (class23_0.class18_0 != null)
			{
				hashtable_1 = new Hashtable();
				Class18[] class18_ = class23_0.class18_0;
				foreach (Class18 class2 in class18_)
				{
					hashtable_1.Add(class2.string_0, new object[4] { class2.int_0, class2.int_1, class2.int_2, class2.dateTime_0 });
				}
			}
			if (class23_0.class28_0 != null)
			{
				hashtable_2 = new Hashtable();
				Class28[] class28_ = class23_0.class28_0;
				foreach (Class28 class3 in class28_)
				{
					hashtable_2.Add(class3.string_0, new object[1] { class3.dateTime_0 });
				}
			}
		}
		catch (Exception exception_)
		{
			method_0(exception_);
		}
	}

	public bool method_11()
	{
		try
		{
			if (string_2 == null)
			{
				return false;
			}
			string value = GClass1.smethod_11(class23_0.method_3(bool_5: true));
			StreamWriter streamWriter = new StreamWriter(Path.Combine(string_2, "nsssvc.dat"), append: false, encoding_0);
			streamWriter.Write(value);
			streamWriter.Close();
			return true;
		}
		catch (Exception exception_)
		{
			method_0(exception_);
			return false;
		}
		finally
		{
			class23_0.dateTime_4 = DateTime.Now;
		}
	}

	public void method_12()
	{
		try
		{
			if (hashtable_0 != null && class23_0.class17_0 != null)
			{
				Class17[] class17_ = class23_0.class17_0;
				foreach (Class17 @class in class17_)
				{
					if (hashtable_0[@class.string_0] is object[] array)
					{
						@class.int_0 = (int)array[0];
						@class.int_1 = (int)array[1];
						@class.int_2 = (int)array[2];
						@class.dateTime_0 = (DateTime)array[3];
						@class.dateTime_1 = (DateTime)array[4];
					}
				}
				hashtable_0 = null;
			}
			if (hashtable_1 != null && class23_0.class18_0 != null)
			{
				Class18[] class18_ = class23_0.class18_0;
				foreach (Class18 class2 in class18_)
				{
					if (hashtable_1[class2.string_0] is object[] array2)
					{
						class2.int_0 = (int)array2[0];
						class2.int_1 = (int)array2[1];
						class2.int_2 = (int)array2[2];
						class2.dateTime_0 = (DateTime)array2[3];
					}
				}
				hashtable_1 = null;
			}
			if (hashtable_2 == null || class23_0.class28_0 == null)
			{
				return;
			}
			Class28[] class28_ = class23_0.class28_0;
			foreach (Class28 class3 in class28_)
			{
				if (hashtable_2[class3.string_0] is object[] array3)
				{
					class3.dateTime_0 = (DateTime)array3[0];
				}
			}
			hashtable_2 = null;
		}
		catch (Exception exception_)
		{
			method_0(exception_);
		}
	}

	public bool method_13()
	{
		try
		{
			if (string_1 == null)
			{
				return false;
			}
			string path = Path.Combine(string_1, "nsssvc.xml");
			if (File.Exists(path))
			{
				StreamReader streamReader = new StreamReader(path);
				string string_ = streamReader.ReadToEnd();
				streamReader.Close();
				return class23_0.method_4(this, string_, bool_5: true, bool_6: false);
			}
			return false;
		}
		catch (Exception exception_)
		{
			method_0(exception_);
			return false;
		}
	}

	public bool method_14()
	{
		try
		{
			if (string_2 == null)
			{
				return false;
			}
			string path = Path.Combine(string_2, "nsssvc.dat");
			if (File.Exists(path))
			{
				StreamReader streamReader = new StreamReader(path, encoding_0);
				string text = streamReader.ReadToEnd();
				streamReader.Close();
				string string_ = GClass1.smethod_12(text);
				return class23_0.method_4(this, string_, bool_5: true, bool_6: true);
			}
			return false;
		}
		catch (Exception exception_)
		{
			method_0(exception_);
			return false;
		}
	}

	public string method_15()
	{
		Class22 @class = null;
		try
		{
			if (class23_0.string_1 == null)
			{
				return null;
			}
			@class = new Class22(class23_0);
			string string_ = GClass1.smethod_11(class23_0.method_2());
			return GClass1.smethod_12(@class.method_12(string_));
		}
		catch (Exception exception_)
		{
			method_0(exception_);
			return null;
		}
		finally
		{
			@class?.method_5();
		}
	}

	public bool method_16(XmlNode xmlNode_0, ref Class17[] class17_0)
	{
		try
		{
			ArrayList arrayList = new ArrayList();
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				if (!GClass1.smethod_2(childNode))
				{
					try
					{
						arrayList.Add(new Class17(class23_0, childNode));
					}
					catch (Exception exception_)
					{
						method_0(exception_);
					}
				}
			}
			class17_0 = arrayList.ToArray(typeof(Class17)) as Class17[];
			return true;
		}
		catch (Exception exception_2)
		{
			method_0(exception_2);
			return false;
		}
	}

	public bool method_17(XmlNode xmlNode_0, ref Class19 class19_0)
	{
		try
		{
			class19_0 = new Class19(null, xmlNode_0);
			return true;
		}
		catch (Exception exception_)
		{
			method_0(exception_);
			return false;
		}
	}

	public bool method_18(XmlNode xmlNode_0, ref Class18[] class18_0)
	{
		try
		{
			ArrayList arrayList = new ArrayList();
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				if (!GClass1.smethod_2(childNode))
				{
					try
					{
						arrayList.Add(new Class18(class23_0, childNode));
					}
					catch (Exception exception_)
					{
						method_0(exception_);
					}
				}
			}
			class18_0 = arrayList.ToArray(typeof(Class18)) as Class18[];
			return true;
		}
		catch (Exception exception_2)
		{
			method_0(exception_2);
			return false;
		}
	}

	public bool method_19(XmlNode xmlNode_0, ref Class32 class32_0)
	{
		try
		{
			class32_0 = new Class32(class23_0, xmlNode_0);
			return true;
		}
		catch (Exception exception_)
		{
			method_0(exception_);
			return false;
		}
	}

	public bool method_20(XmlNode xmlNode_0, ref Class25[] class25_0)
	{
		try
		{
			ArrayList arrayList = new ArrayList();
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				if (!GClass1.smethod_2(childNode))
				{
					try
					{
						arrayList.Add(new Class25(childNode));
					}
					catch (Exception exception_)
					{
						method_0(exception_);
					}
				}
			}
			class25_0 = arrayList.ToArray(typeof(Class25)) as Class25[];
			return true;
		}
		catch (Exception exception_2)
		{
			method_0(exception_2);
			return false;
		}
	}

	public bool method_21(XmlNode xmlNode_0, ref Class31[] class31_1)
	{
		try
		{
			ArrayList arrayList = new ArrayList();
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				if (!GClass1.smethod_2(childNode))
				{
					try
					{
						arrayList.Add(new Class31(childNode));
					}
					catch (Exception exception_)
					{
						method_0(exception_);
					}
				}
			}
			class31_1 = arrayList.ToArray(typeof(Class31)) as Class31[];
			return true;
		}
		catch (Exception exception_2)
		{
			method_0(exception_2);
			return false;
		}
	}

	public bool method_22(XmlNode xmlNode_0, ref Class29[] class29_0, ref Class29 class29_1)
	{
		try
		{
			ArrayList arrayList = new ArrayList();
			bool flag = false;
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				if (GClass1.smethod_2(childNode))
				{
					continue;
				}
				try
				{
					Class29 @class = null;
					arrayList.Add(@class = new Class29(childNode));
					if (@class.string_0 == "")
					{
						flag = true;
						class29_1 = @class;
					}
				}
				catch (Exception exception_)
				{
					method_0(exception_);
				}
			}
			if (!flag)
			{
				arrayList.Add(class29_1 = new Class29());
			}
			class29_0 = arrayList.ToArray(typeof(Class29)) as Class29[];
			return true;
		}
		catch (Exception exception_2)
		{
			method_0(exception_2);
			return false;
		}
	}

	public bool method_23(XmlNode xmlNode_0)
	{
		try
		{
			Hashtable hashtable = new Hashtable();
			foreach (XmlNode childNode in xmlNode_0.ChildNodes)
			{
				hashtable.Add(childNode.InnerText, new object[1] { GClass1.smethod_7(childNode.Attributes!["lastVisitDate"]!.Value, DateTime.MinValue) });
			}
			hashtable_2 = hashtable;
			return true;
		}
		catch (Exception exception_)
		{
			method_0(exception_);
			return false;
		}
	}

	public bool method_24(XmlNode xmlNode_0, ref double[] double_0)
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
				if (!GClass1.smethod_2(childNode))
				{
					int num = GClass1.smethod_3(childNode.Attributes!["hour"]!.Value, -1);
					if (num >= 0 && num < 24)
					{
						array[num] = GClass1.smethod_4(childNode.InnerText, 1.0);
					}
				}
			}
			double_0 = array;
			return true;
		}
		catch (Exception exception_)
		{
			method_0(exception_);
			return false;
		}
	}

	public bool method_25(XmlNode xmlNode_0, ref double[] double_0)
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
				if (!GClass1.smethod_2(childNode))
				{
					try
					{
						DayOfWeek dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), childNode.Attributes!["day"]!.Value, ignoreCase: true);
						array[(int)dayOfWeek % 7] = GClass1.smethod_4(childNode.InnerText, 1.0);
					}
					catch (Exception exception_)
					{
						method_0(exception_);
					}
				}
			}
			double_0 = array;
			return true;
		}
		catch (Exception exception_2)
		{
			method_0(exception_2);
			return false;
		}
	}
}
