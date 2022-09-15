using System;
using System.Security;
using Microsoft.Win32;

internal class Class44
{
	public const string string_0 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

	public const string string_1 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce";

	public static string smethod_0(string string_2, string[] string_3)
	{
		if (string_2.IndexOf(" ") != -1)
		{
			string_2 = "\"" + string_2 + "\"";
		}
		if (string_3 != null && string_3.Length > 0)
		{
			string_2 = string_2 + " \"" + Class49.smethod_1(string_3, "\", \"") + "\"";
		}
		return string_2;
	}

	public static string smethod_1(string string_2)
	{
		if (string_2 == null)
		{
			return null;
		}
		string_2 = string_2.Trim();
		string result = string_2;
		if (string_2.StartsWith("\""))
		{
			int num = string_2.IndexOf("\"", 1);
			result = ((num != -1) ? string_2.Substring(1, num - 1) : null);
		}
		else
		{
			int num2 = string_2.IndexOf(" ", 0);
			if (num2 > -1)
			{
				result = string_2.Substring(0, num2);
			}
		}
		return result;
	}

	public static bool smethod_2(RegistryKey registryKey_0)
	{
		try
		{
			using RegistryKey registryKey = registryKey_0.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			return registryKey.GetValue("usb2e") != null;
		}
		catch (SecurityException)
		{
			throw;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public static string smethod_3(RegistryKey registryKey_0)
	{
		try
		{
			using RegistryKey registryKey = registryKey_0.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			return smethod_1(registryKey.GetValue("usb2e") as string);
		}
		catch (SecurityException)
		{
			throw;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return null;
		}
	}

	public bool method_0(string string_2, RegistryKey registryKey_0)
	{
		try
		{
			string[] string_3 = new string[1] { (registryKey_0 == Registry.LocalMachine) ? "-msu" : "-usu" };
			string value = smethod_0(string_2, string_3);
			using RegistryKey registryKey = registryKey_0.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("usb2e", value);
			return true;
		}
		catch (SecurityException)
		{
			throw;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public static bool smethod_4(RegistryKey registryKey_0)
	{
		try
		{
			using RegistryKey registryKey = registryKey_0.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.DeleteValue("usb2e");
			return true;
		}
		catch (SecurityException)
		{
			throw;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}
}
