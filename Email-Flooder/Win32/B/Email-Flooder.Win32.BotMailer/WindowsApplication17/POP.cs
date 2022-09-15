using System;
using System.Net.Sockets;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication17;

public class POP
{
	private string _proxy;

	private string _proxyport;

	private string _server;

	private int _port;

	private string _Username;

	private string _Password;

	private NetworkStream ns;

	private TcpClient client;

	public int Port
	{
		get
		{
			return _port;
		}
		set
		{
			_port = value;
		}
	}

	public string proxyport
	{
		get
		{
			return _proxyport;
		}
		set
		{
			_proxyport = value;
		}
	}

	public string password
	{
		get
		{
			return _Password;
		}
		set
		{
			_Password = value;
		}
	}

	public string POPServer
	{
		get
		{
			return _server;
		}
		set
		{
			_server = value;
		}
	}

	public string proxy
	{
		get
		{
			return _proxy;
		}
		set
		{
			_proxy = value;
		}
	}

	public string username
	{
		get
		{
			return _Username;
		}
		set
		{
			_Username = value;
		}
	}

	public POP(string server, int port)
	{
		_port = 110;
		client = new TcpClient();
		_server = server;
		_port = port;
	}

	public POP(string server, int port, string username, string password, string PROXY, string Proxyport)
	{
		_port = 110;
		client = new TcpClient();
		_proxy = PROXY;
		_proxyport = Proxyport;
		_Username = username;
		_Password = password;
		_server = server;
		_port = port;
	}

	public object Open()
	{
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		string[] array = _proxy.ToString().Split(new char[1] { ':' });
		_ = array[0] + ", " + array[1];
		TcpClient tcpClient = new TcpClient();
		tcpClient.Connect(array[0], IntegerType.FromString(array[1]));
		NetworkStream stream = tcpClient.GetStream();
		string s = "CONNECT " + _server + ":" + StringType.FromInteger(_port) + " HTTP/1.1" + "\r\n" + "Host: " + _server + ":" + StringType.FromInteger(_port) + "\r\n" + "\r\n";
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		stream.Write(bytes, 0, bytes.Length);
		byte[] array2 = new byte[checked(tcpClient.ReceiveBufferSize + 1)];
		stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
		string @string = Encoding.ASCII.GetString(array2);
		Console.WriteLine("POP Return 1:" + @string);
		byte[] bytes2 = Encoding.ASCII.GetBytes("USER " + _Username + "\r\n");
		stream.Write(bytes2, 0, bytes2.Length);
		stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
		string string2 = Encoding.ASCII.GetString(array2);
		if (StringType.StrCmp(string2.Substring(0, 3), "+OK", false) == 0)
		{
			Console.WriteLine("Pop Return 2:" + string2);
			byte[] bytes3 = Encoding.ASCII.GetBytes("PASS " + _Password + "\r\n");
			stream.Write(bytes3, 0, bytes3.Length);
			stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
			string string3 = Encoding.ASCII.GetString(array2);
			Console.WriteLine("Pop3 Returndata 3:" + string3);
			if (StringType.StrCmp(string3.Substring(0, 3), "+OK", false) == 0)
			{
				byte[] bytes4 = Encoding.ASCII.GetBytes("STAT\r\n");
				stream.Write(bytes4, 0, bytes4.Length);
				stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
				string string4 = Encoding.ASCII.GetString(array2);
				Console.WriteLine("Pop3 Returndata 4:" + string4);
				byte[] bytes5 = Encoding.ASCII.GetBytes("RETR 1\r\n");
				stream.Write(bytes5, 0, bytes5.Length);
				stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
				string string5 = Encoding.ASCII.GetString(array2);
				Console.WriteLine("Pop3 Returndata 5:" + string5);
				byte[] bytes6 = Encoding.ASCII.GetBytes("QUIT\r\n");
				stream.Write(bytes6, 0, bytes6.Length);
				stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
				string string6 = Encoding.ASCII.GetString(array2);
				Console.WriteLine("Pop3 Returndata 6:" + string6);
			}
			else
			{
				Interaction.MsgBox((object)"Username/Password Error", (MsgBoxStyle)0, (object)null);
			}
		}
		else
		{
			Interaction.MsgBox((object)"Error connecting to POP", (MsgBoxStyle)0, (object)null);
		}
		object result = default(object);
		return result;
	}
}
