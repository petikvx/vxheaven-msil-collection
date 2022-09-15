using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost;

public class clsClient
{
	private TcpClient Connection;

	public clsClient(TcpClient Connection)
	{
		this.Connection = Connection;
	}

	public void ProcessThread()
	{
		NetworkStream stream = Connection.GetStream();
		try
		{
			string request = ReadRequest(stream);
			clsResponse clsResponse2 = ParseRequest(request);
			clsResponse2.Send(stream);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Connection.Close();
	}

	private string ReadRequest(NetworkStream Stream)
	{
		byte[] array = new byte[8193];
		StringBuilder stringBuilder = new StringBuilder();
		while (Stream.DataAvailable)
		{
			int count = Stream.Read(array, 0, 8192);
			stringBuilder.Append(Encoding.ASCII.GetString(array, 0, count));
		}
		return stringBuilder.ToString();
	}

	private clsResponse ParseRequest(string Request)
	{
		StringReader stringReader = new StringReader(Request);
		string text = stringReader.ReadLine();
		clsResponse clsResponse2 = new clsResponse();
		if (Operators.CompareString(text, (string)null, false) != 0)
		{
			clsResponse2.Match(text);
			text = stringReader.ReadLine();
		}
		while (Operators.CompareString(text, (string)null, false) != 0)
		{
			clsResponse2.WebHeader.Add(text);
			text = stringReader.ReadLine();
		}
		return clsResponse2;
	}
}
