using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace LoginSendMessagePowerByVBulletin;

public class GClass0
{
	private string string_0;

	private string string_1;

	private HttpWebRequest httpWebRequest_0;

	private HttpWebResponse httpWebResponse_0;

	public GClass0()
	{
		string_1 = Class0.form1_0.string_1;
	}

	public bool method_0()
	{
		try
		{
			string requestUriString = string_1 + "profile.php";
			HttpWebRequest httpWebRequest = WebRequest.Create(requestUriString) as HttpWebRequest;
			httpWebRequest.Method = "GET";
			httpWebRequest.KeepAlive = true;
			httpWebRequest.AllowAutoRedirect = true;
			httpWebRequest.Timeout = int.Parse(Class0.form1_0.string_4) * 1000;
			HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
			string text = streamReader.ReadToEnd();
			if (text.IndexOf("navbar_username") < 0 && text.IndexOf("vb_login_username") < 0)
			{
				return false;
			}
			return true;
		}
		catch (WebException ex)
		{
			_ = ex.Message;
			return false;
		}
	}

	public bool method_1()
	{
		try
		{
			string requestUriString = string_1 + "login.php";
			string text = "";
			if (string_1.Replace("http://", "").IndexOf("/") == string_1.Replace("http://", "").LastIndexOf("/"))
			{
				text = "/profile.php";
			}
			else
			{
				text = string_1.Substring(string_1.LastIndexOf("."));
				text = text.Substring(text.IndexOf("/"));
				text = (Class0.string_0 = text.Substring(0, text.LastIndexOf("/"))) + "/profile.php";
			}
			MD5 mD = MD5.Create();
			byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(Class0.form1_0.string_3));
			string text2 = "";
			for (int i = 0; i < array.Length; i++)
			{
				text2 += array[i].ToString("x2");
			}
			string s = "do=login&url=" + text + "&vb_login_md5password=" + text2 + "&vb_login_md5password_utf=" + text2 + "&s=&vb_login_username=" + Class0.form1_0.string_2 + "&vb_login_password=";
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			httpWebRequest_0 = WebRequest.Create(requestUriString) as HttpWebRequest;
			httpWebRequest_0.Method = "POST";
			httpWebRequest_0.KeepAlive = true;
			httpWebRequest_0.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest_0.CookieContainer = Class0.cookieContainer_0;
			httpWebRequest_0.ContentLength = bytes.Length;
			httpWebRequest_0.Timeout = int.Parse(Class0.form1_0.string_4) * 1000;
			Stream requestStream = httpWebRequest_0.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			httpWebResponse_0 = httpWebRequest_0.GetResponse() as HttpWebResponse;
			Stream responseStream = httpWebResponse_0.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream, Encoding.GetEncoding("GB2312"));
			string text3 = streamReader.ReadToEnd();
			if (text3.IndexOf("Thank you for logging in") < 0 && text3.IndexOf("You last visited") < 0 && text3.IndexOf("Welcome") < 0)
			{
				return false;
			}
			return true;
		}
		catch (WebException ex)
		{
			_ = ex.Message;
			return false;
		}
	}
}
