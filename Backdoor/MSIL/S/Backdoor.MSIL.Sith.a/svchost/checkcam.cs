using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost;

public class checkcam
{
	public delegate void CallBack(string CheckedName, string CheckedResult, string CheckedServer);

	public string CamName;

	public string CamServer;

	public int CamPort;

	private CallBack CallBackMethod;

	public checkcam(CallBack cb)
	{
		CallBackMethod = cb;
	}

	public void docam()
	{
		string checkedResult = "Timeout";
		TcpClient tcpClient = new TcpClient();
		int num = 50000;
		try
		{
			tcpClient.NoDelay = true;
			tcpClient.ReceiveTimeout = num;
			tcpClient.SendTimeout = num;
			tcpClient.ReceiveBufferSize = 2;
			tcpClient.Connect(CamServer, CamPort);
			NetworkStream stream = tcpClient.GetStream();
			string s = "<RVWCFG>" + YPacket("g=" + CamName + "\r" + "\n");
			byte[] bytes = Encoding.Default.GetBytes(s);
			stream.Write(bytes, 0, bytes.Length);
			byte[] array = new byte[checked(tcpClient.ReceiveBufferSize + 1)];
			string text = "";
			DateTime t = DateAndTime.get_Now().AddMilliseconds(num);
			do
			{
				if (!stream.DataAvailable)
				{
					Thread.Sleep(5);
					continue;
				}
				int num2 = stream.Read(array, 0, tcpClient.ReceiveBufferSize);
				string @string = Encoding.Default.GetString(array);
				text += Strings.Left(@string, num2);
				if (text.Length > 2)
				{
					checkedResult = StringType.FromInteger(Strings.Asc(Strings.Left(Strings.Mid(text, 2), 1)));
					checkedResult = ((DoubleType.FromString(checkedResult) == 6.0) ? "Offline" : "Online");
					break;
				}
			}
			while (DateTime.Compare(DateAndTime.get_Now(), t) <= 0);
			CallBackMethod(CamName, checkedResult, CamServer);
			tcpClient.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			CallBackMethod(CamName, "Error", CamServer);
			try
			{
				tcpClient.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	private string YPacket(string Packet)
	{
		string result = default(string);
		try
		{
			result = "\b\0\u0001\0\0\0" + CalcSize(Strings.Len(Packet)) + Packet;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private string CalcSize(long PacketLen)
	{
		checked
		{
			string result = default(string);
			try
			{
				result = StringType.FromChar(Strings.Chr((int)Math.Round(Conversion.Int((double)PacketLen / 256.0)))) + StringType.FromChar(Strings.Chr((int)Conversion.Int(unchecked(PacketLen % 256L))));
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
