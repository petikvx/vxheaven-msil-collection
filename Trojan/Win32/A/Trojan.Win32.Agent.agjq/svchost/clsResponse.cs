using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost;

public class clsResponse
{
	public WebHeaderCollection WebHeader;

	private string Result;

	private FileInfo Document;

	public clsResponse()
	{
		WebHeader = new WebHeaderCollection();
	}

	public void Match(string Line)
	{
		Regex regex = new Regex("GET\\b(.+)\\bHTTP(.+)");
		Match match = regex.Match(Line);
		string text = match.Groups[1].ToString().Trim();
		if (!(text.StartsWith("/../") | text.StartsWith("/./") | text.StartsWith("*") | text.StartsWith("?") | (Operators.CompareString(text, "", false) == 0)))
		{
			if (Operators.CompareString(text, "/", false) == 0)
			{
				text = "/index.htm";
			}
			if (text.StartsWith("/"))
			{
				text = text.Substring(1);
			}
			text = modMain.WebRoot + text;
			Document = new FileInfo(text);
		}
	}

	public void Send(NetworkStream Stream)
	{
		if (Document.get_Exists())
		{
			string text;
			switch (Document.Extension)
			{
			case ".gif":
				text = "Content-Type: image/gif";
				break;
			case ".zip":
				text = "Content-Type: application/zip";
				break;
			case ".mp3":
				text = "Content-Type: audio/mpeg";
				break;
			default:
				text = "Content-Type: */*";
				break;
			case ".m3u":
			case ".pls":
			case ".xpl":
				text = "Content-Type: audio/x-mpegurl";
				break;
			case ".htm":
			case ".html":
				text = "Content-Type: text/html";
				break;
			case ".jpg":
			case ".jpeg":
				text = "Content-Type: image/jpeg";
				break;
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("HTTP/1.0 200 OK\r\n");
			stringBuilder.Append("Server: " + Dns.GetHostName() + "\r\n");
			stringBuilder.Append(text + "\r\n");
			stringBuilder.Append("Content-Length: " + Conversions.ToString(Document.Length) + "\r\n");
			stringBuilder.Append("\r\n");
			RealSend(Stream, stringBuilder.ToString());
			SendFile(Stream);
			Stream.Flush();
		}
		else
		{
			Result = "HTTP/1.0 404 Not Found\r\nServer: " + Dns.GetHostName() + "\r\n\r\n";
			RealSend(Stream, Result);
			Stream.Flush();
		}
	}

	private void RealSend(NetworkStream Stream, string responseString)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(responseString);
		Stream.Write(bytes, 0, bytes.Length);
	}

	private void SendFile(NetworkStream Stream)
	{
		FileStream fileStream = Document.OpenRead();
		byte[] buffer = new byte[8193];
		int num;
		do
		{
			num = fileStream.Read(buffer, 0, 8192);
			Stream.Write(buffer, 0, num);
		}
		while (num > 0);
	}
}
