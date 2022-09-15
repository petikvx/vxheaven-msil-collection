using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;

internal class Class51
{
	public static Random random_0 = new Random();

	public static string smethod_0(XmlNode xmlNode_0, string string_0, params string[] string_1)
	{
		int num = 0;
		string name;
		while (true)
		{
			if (num < string_1.Length)
			{
				name = string_1[num];
				if (xmlNode_0.Attributes![name] != null)
				{
					break;
				}
				num++;
				continue;
			}
			return string_0;
		}
		return xmlNode_0.Attributes![name]!.Value;
	}

	public static bool smethod_1(XmlNode xmlNode_0)
	{
		if (xmlNode_0.NodeType != XmlNodeType.Comment)
		{
			return xmlNode_0.NodeType == XmlNodeType.Whitespace;
		}
		return true;
	}

	public static string smethod_2(double double_0)
	{
		return double_0.ToString(Class12.cultureInfo_0);
	}

	public static string smethod_3(int int_0)
	{
		return int_0.ToString(Class12.cultureInfo_0);
	}

	public static string smethod_4(bool bool_0)
	{
		return bool_0.ToString(Class12.cultureInfo_0);
	}

	public static string smethod_5(TimeSpan timeSpan_0)
	{
		return timeSpan_0.ToString();
	}

	public static string smethod_6(DateTime dateTime_0)
	{
		return smethod_14(dateTime_0);
	}

	public static string smethod_7(Class28 class28_0)
	{
		return class28_0.System_002EObject_002EToString();
	}

	public static string smethod_8(object object_0)
	{
		if (object_0 == null)
		{
			return null;
		}
		if (object_0 is double)
		{
			return smethod_2((double)object_0);
		}
		if (object_0 is bool)
		{
			return smethod_4((bool)object_0);
		}
		if (object_0 is int)
		{
			return smethod_3((int)object_0);
		}
		if (object_0 is DateTime)
		{
			return smethod_6((DateTime)object_0);
		}
		if (object_0 is TimeSpan)
		{
			return smethod_5((TimeSpan)object_0);
		}
		if (object_0 is Class28)
		{
			return smethod_7(object_0 as Class28);
		}
		return Convert.ToString(object_0, Class12.cultureInfo_0);
	}

	public static int smethod_9(string string_0, int int_0)
	{
		try
		{
			return Convert.ToInt32(string_0, Class12.cultureInfo_0);
		}
		catch
		{
			return int_0;
		}
	}

	public static double smethod_10(string string_0, double double_0)
	{
		try
		{
			return Convert.ToDouble(string_0, Class12.cultureInfo_0);
		}
		catch
		{
			return double_0;
		}
	}

	public static bool smethod_11(string string_0, bool bool_0)
	{
		try
		{
			return Convert.ToBoolean(string_0, Class12.cultureInfo_0);
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

	public static TimeSpan smethod_12(string string_0, TimeSpan timeSpan_0)
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
			return flag ? TimeSpan.FromMilliseconds(smethod_9(string_0, 0)) : TimeSpan.FromSeconds(smethod_9(string_0, 0));
		}
	}

	public static DateTime smethod_13(string string_0, DateTime dateTime_0)
	{
		try
		{
			return Convert.ToDateTime(string_0, Class12.cultureInfo_0);
		}
		catch
		{
			return dateTime_0;
		}
	}

	public static string smethod_14(DateTime dateTime_0)
	{
		return smethod_15(dateTime_0, "");
	}

	public static string smethod_15(DateTime dateTime_0, string string_0)
	{
		if (!(dateTime_0 != DateTime.MinValue))
		{
			return string_0;
		}
		return dateTime_0.ToString("yyyy-MM-dd HH:mm:ss", Class12.cultureInfo_0);
	}

	public static bool smethod_16(double double_0)
	{
		return random_0.NextDouble() <= double_0;
	}

	public static double smethod_17(double double_0, double double_1)
	{
		double_1 = smethod_20(double_1, 0.0, 2.0);
		double num = double_0 * double_1;
		return double_0 - num / 2.0 + random_0.NextDouble() * num;
	}

	public static int smethod_18(int int_0, double double_0)
	{
		double_0 = smethod_20(double_0, 0.0, 2.0);
		double num = (double)int_0 * double_0;
		return (int)Math.Round((double)int_0 - num / 2.0 + random_0.NextDouble() * num);
	}

	public static TimeSpan smethod_19(TimeSpan timeSpan_0, double double_0)
	{
		return TimeSpan.FromMilliseconds(smethod_17(timeSpan_0.TotalMilliseconds, double_0));
	}

	public static double smethod_20(double double_0, double double_1, double double_2)
	{
		if (double_0 < double_1)
		{
			double_0 = double_1;
		}
		else if (double_0 > double_2)
		{
			double_0 = double_2;
		}
		return double_0;
	}

	public static int smethod_21(int int_0, double double_0, double double_1)
	{
		if ((double)int_0 < double_0)
		{
			int_0 = (int)Math.Ceiling(double_0);
		}
		else if ((double)int_0 > double_1)
		{
			int_0 = (int)Math.Floor(double_1);
		}
		return int_0;
	}

	public static bool smethod_22(Stream stream_0, Stream stream_1)
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
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public static string smethod_23(string string_0)
	{
		try
		{
			if (string_0 != null && !(string_0 == ""))
			{
				char[] array = Convert.ToBase64String(Class12.encoding_0.GetBytes(string_0)).ToCharArray();
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
		catch (Exception innerException)
		{
			throw new Exception("Failed to scramble the string:\r\n" + string_0, innerException);
		}
	}

	public static string smethod_24(string string_0, Class11 class11_0)
	{
		try
		{
			return smethod_23(string_0);
		}
		catch (Exception exception_)
		{
			if (class11_0 != null)
			{
				class11_0.method_20("65476902-D6A5-4e85-A54F-6312FC5D86B4", exception_);
			}
			else
			{
				Class47.smethod_8(exception_);
			}
			return string_0;
		}
	}

	public static string smethod_25(string string_0)
	{
		try
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
				return Class12.encoding_0.GetString(Convert.FromBase64String(new string(array)));
			}
			return string_0;
		}
		catch (Exception innerException)
		{
			throw new Exception("Failed to unscramble the string:\r\n" + string_0, innerException);
		}
	}

	public static string smethod_26(string string_0, Class11 class11_0)
	{
		try
		{
			return smethod_25(string_0);
		}
		catch (Exception exception_)
		{
			if (class11_0 != null)
			{
				class11_0.method_20("F50DDA8E-163A-4343-85E0-640CBDFD3B40", exception_);
			}
			else
			{
				Class47.smethod_8(exception_);
			}
			return string_0;
		}
	}

	public static bool smethod_27(string string_0, string string_1, string string_2, string string_3, string string_4)
	{
		try
		{
			if (string_4 != null && string_0 == "open" && Path.GetFileName(string_4)!.ToLower() == Path.GetFileName(string_1)!.ToLower())
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
			return 32 < (int)GClass3.ShellExecute(IntPtr.Zero, string_0, string_1, string_2, string_3, GClass3.GEnum11.const_1);
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public static int smethod_28(Version version_0, Version version_1)
	{
		int num = version_0.Major - version_1.Major;
		if (num != 0)
		{
			return num;
		}
		num = string.Compare(version_0.Minor.ToString(), version_1.Minor.ToString());
		if (num != 0)
		{
			return num;
		}
		return version_0.Build - version_1.Build;
	}

	[SpecialName]
	public static string smethod_29()
	{
		try
		{
			return Process.GetCurrentProcess().MainModule!.FileName;
		}
		catch (Exception)
		{
			return Environment.GetCommandLineArgs()[0];
		}
	}
}
