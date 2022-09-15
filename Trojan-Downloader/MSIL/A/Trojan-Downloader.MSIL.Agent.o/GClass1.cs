using System;
using System.IO;
using System.Reflection;
using System.Xml;

public class GClass1
{
	public static string smethod_0(XmlNode xmlNode_0, string string_0, string string_1)
	{
		if (xmlNode_0.Attributes![string_0] == null)
		{
			return string_1;
		}
		return xmlNode_0.Attributes![string_0]!.Value;
	}

	public static string smethod_1(XmlNode xmlNode_0, string string_0)
	{
		return smethod_0(xmlNode_0, string_0, null);
	}

	public static bool smethod_2(XmlNode xmlNode_0)
	{
		if (xmlNode_0.NodeType != XmlNodeType.Comment)
		{
			return xmlNode_0.NodeType == XmlNodeType.Whitespace;
		}
		return true;
	}

	public static int smethod_3(string string_0, int int_0)
	{
		try
		{
			return Convert.ToInt32(string_0);
		}
		catch
		{
			return int_0;
		}
	}

	public static double smethod_4(string string_0, double double_0)
	{
		try
		{
			return Convert.ToDouble(string_0);
		}
		catch
		{
			return double_0;
		}
	}

	public static bool smethod_5(string string_0, bool bool_0)
	{
		try
		{
			return Convert.ToBoolean(string_0);
		}
		catch
		{
			if (string_0 != null)
			{
				string_0 = string_0.ToLower();
				switch (string_0)
				{
				case "0":
				case "no":
				case "n":
				case "f":
					return false;
				case "1":
				case "yes":
				case "y":
				case "t":
					return true;
				}
			}
			return bool_0;
		}
	}

	public static TimeSpan smethod_6(string string_0, TimeSpan timeSpan_0)
	{
		try
		{
			return TimeSpan.Parse(string_0);
		}
		catch
		{
			bool flag = true;
			if (string_0 == null)
			{
				return timeSpan_0;
			}
			if (string_0.EndsWith("ms"))
			{
				string_0 = string_0.Substring(0, string_0.Length - 2);
			}
			else if (string_0.EndsWith("s"))
			{
				string_0 = string_0.Substring(0, string_0.Length - 1);
				flag = false;
			}
			return flag ? TimeSpan.FromMilliseconds(smethod_3(string_0, 0)) : TimeSpan.FromSeconds(smethod_3(string_0, 0));
		}
	}

	public static DateTime smethod_7(string string_0, DateTime dateTime_0)
	{
		try
		{
			return Convert.ToDateTime(string_0);
		}
		catch
		{
			return dateTime_0;
		}
	}

	public static string smethod_8(DateTime dateTime_0)
	{
		return smethod_9(dateTime_0, "");
	}

	public static string smethod_9(DateTime dateTime_0, string string_0)
	{
		if (!(dateTime_0 != DateTime.MinValue))
		{
			return string_0;
		}
		return dateTime_0.ToString("MM/dd/yy HH:mm:ss");
	}

	public static bool smethod_10(Stream stream_0, Stream stream_1)
	{
		try
		{
			byte[] buffer = new byte[1024];
			for (int num = stream_0.Read(buffer, 0, 1024); num > 0; num = stream_0.Read(buffer, 0, 1024))
			{
				stream_1.Write(buffer, 0, num);
			}
			return true;
		}
		catch (Exception exception_)
		{
			Class37.smethod_8(exception_);
			return false;
		}
	}

	public static string smethod_11(string string_0)
	{
		if (string_0 != null && !(string_0 == ""))
		{
			char[] array = Convert.ToBase64String(Class24.encoding_0.GetBytes(string_0)).ToCharArray();
			int num = 2 * (array.Length / 2) - 2;
			for (int i = 0; i < num; i += 2)
			{
				char c = array[i];
				array[i] = array[i + 1];
				array[i + 1] = c;
			}
			for (int j = 1; j < num; j += 2)
			{
				char c2 = array[j];
				array[j] = array[j + 1];
				array[j + 1] = c2;
			}
			return new string(array);
		}
		return string_0;
	}

	public static string smethod_12(string string_0)
	{
		if (string_0 != null && !(string_0 == ""))
		{
			char[] array = string_0.ToCharArray();
			int num = 2 * (array.Length / 2) - 2;
			for (int i = 1; i < num; i += 2)
			{
				char c = array[i];
				array[i] = array[i + 1];
				array[i + 1] = c;
			}
			for (int j = 0; j < num; j += 2)
			{
				char c2 = array[j];
				array[j] = array[j + 1];
				array[j + 1] = c2;
			}
			return Class24.encoding_0.GetString(Convert.FromBase64String(new string(array)));
		}
		return string_0;
	}

	public static bool smethod_13(string string_0, string string_1, string string_2, string string_3)
	{
		try
		{
			string codeBase = Assembly.GetEntryAssembly()!.GetName().CodeBase;
			if (string_0 == "open" && Path.GetFileName(codeBase)!.ToLower() == Path.GetFileName(string_1)!.ToLower())
			{
				return false;
			}
			if (string_0 == "open")
			{
				string extension = Path.GetExtension(string_1);
				if (!(extension == ""))
				{
					_ = extension == ".";
				}
			}
			return 32 < (int)GClass4.ShellExecute(IntPtr.Zero, string_0, string_1, string_2, string_3, GClass4.GEnum11.const_1);
		}
		catch (Exception exception_)
		{
			Class37.smethod_8(exception_);
			return false;
		}
	}
}
