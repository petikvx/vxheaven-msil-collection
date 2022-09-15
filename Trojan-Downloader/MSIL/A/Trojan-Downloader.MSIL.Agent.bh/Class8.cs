using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

internal class Class8
{
	protected Class32 class32_0;

	public string string_0 = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322)";

	public IWebProxy iwebProxy_0;

	public string string_1;

	public Class11 class11_0;

	public CookieContainer cookieContainer_0 = new CookieContainer();

	public string[] string_2;

	public ArrayList arrayList_0 = new ArrayList();

	public bool bool_0 = false;

	static Class8()
	{
		ServicePointManager.Expect100Continue = false;
	}

	public Class8(Class11 class11_1)
	{
		class11_0 = class11_1;
		iwebProxy_0 = class11_0.method_29(out string_1);
		string text = class11_0.method_17();
		if (text == null)
		{
			string_0 = text;
		}
	}

	protected string method_0(string string_3, WebRequest webRequest_0)
	{
		int num = string_3.IndexOf(":");
		string string_4 = string_3.Substring(0, num).Trim();
		string string_5 = string_3.Substring(num + 1, string_3.Length - (num + 1)).Trim();
		return method_1(string_4, string_5, webRequest_0);
	}

	protected string method_1(string string_3, string string_4, WebRequest webRequest_0)
	{
		if (Class53.hashtable_1 == null)
		{
			Class53.hashtable_1 = new Hashtable(20, 0.5f)
			{
				{ "accept", 0 },
				{ "connection", 1 },
				{ "content-length", 2 },
				{ "content-type", 3 },
				{ "expect", 4 },
				{ "if-modified-since", 5 },
				{ "referer", 6 },
				{ "transfer-encoding", 7 },
				{ "range", 8 }
			};
		}
		bool flag;
		HttpWebRequest httpWebRequest;
		if (webRequest_0 != null && string_3 != null)
		{
			flag = false;
			if (webRequest_0 is HttpWebRequest)
			{
				httpWebRequest = webRequest_0 as HttpWebRequest;
				object key;
				if ((key = string_3.ToLower()) == null || (key = Class53.hashtable_1[key]) == null)
				{
					goto IL_0193;
				}
				switch ((int)key)
				{
				case 0:
					break;
				case 1:
					goto IL_0137;
				case 2:
					goto IL_0143;
				case 3:
					goto IL_0156;
				case 4:
					goto IL_015f;
				case 5:
					goto IL_0168;
				case 6:
					goto IL_017b;
				case 7:
					goto IL_0184;
				case 8:
					throw new NotSupportedException();
				default:
					goto IL_0193;
				}
				httpWebRequest.Accept = string_4;
			}
			else
			{
				switch (string_3.ToLower())
				{
				case "content-type":
					webRequest_0.ContentType = string_4;
					break;
				case "content-length":
					webRequest_0.ContentLength = Class51.smethod_9(string_4, 0);
					break;
				default:
					flag = true;
					break;
				}
			}
			goto IL_01d7;
		}
		return null;
		IL_0168:
		httpWebRequest.IfModifiedSince = Class51.smethod_13(string_4, DateTime.MinValue);
		goto IL_01d7;
		IL_017b:
		httpWebRequest.Referer = string_4;
		goto IL_01d7;
		IL_0156:
		httpWebRequest.ContentType = string_4;
		goto IL_01d7;
		IL_0143:
		httpWebRequest.ContentLength = Class51.smethod_9(string_4, 0);
		goto IL_01d7;
		IL_0137:
		httpWebRequest.Connection = string_4;
		goto IL_01d7;
		IL_0193:
		flag = true;
		goto IL_01d7;
		IL_015f:
		httpWebRequest.Expect = string_4;
		goto IL_01d7;
		IL_01d7:
		if (flag)
		{
			if (string_4 != null && !(string_4 == ""))
			{
				webRequest_0.Headers[string_3] = string_4;
			}
			else if (webRequest_0.Headers.Get(string_3) != null)
			{
				webRequest_0.Headers.Remove(string_3);
			}
		}
		return string_4;
		IL_0184:
		httpWebRequest.TransferEncoding = string_4;
		goto IL_01d7;
	}

	public Class31 method_2(string string_3, string string_4, string string_5, string string_6, string[] string_7, bool bool_1, IWebProxy iwebProxy_1)
	{
		Uri uri = vmethod_0(string_4);
		if (string_5 != null && string_5 != "")
		{
			string_4 = ((uri.Query == null || uri.Query == "") ? (string_4 + "?" + string_5) : (string_4 + "&" + string_5));
			uri = vmethod_0(string_4);
		}
		if (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps)
		{
			throw new Exception("Only HTTP requests are allowed");
		}
		WebRequest webRequest = WebRequest.Create(uri);
		webRequest.Method = ((string_3 == null) ? "GET" : string_3);
		webRequest.ContentType = string_6;
		webRequest.Proxy = ((iwebProxy_1 == null) ? iwebProxy_0 : iwebProxy_1);
		if (string_2 != null && string_2.Length > 0)
		{
			string[] array = string_2;
			foreach (string string_8 in array)
			{
				method_0(string_8, webRequest);
			}
		}
		if (string_7 != null && string_7.Length >= 0)
		{
			string[] array = string_7;
			foreach (string string_9 in array)
			{
				method_0(string_9, webRequest);
			}
		}
		if (bool_1)
		{
			method_1("Accept-Encoding", "gzip, deflate", webRequest);
		}
		return new Class31(webRequest);
	}

	public Class31 method_3(string string_3, string string_4, string string_5, string string_6, string[] string_7, string string_8, string string_9, string string_10, bool bool_1, bool bool_2, IWebProxy iwebProxy_1)
	{
		Class31 @class = method_2(string_3, string_4, string_5, string_8, null, bool_2, iwebProxy_1);
		if (@class.method_5().Scheme != Uri.UriSchemeHttp && @class.method_5().Scheme != Uri.UriSchemeHttps)
		{
			throw new Exception("Only HTTP requests are allowed");
		}
		@class.method_0().Referer = ((string_9 != null) ? string_9 : ((class32_0 != null) ? Class51.smethod_8(class32_0.method_11()) : null));
		@class.method_0().UserAgent = ((string_10 == null) ? string_0 : string_10);
		@class.method_0().KeepAlive = true;
		@class.method_0().Accept = "*/*";
		@class.method_0().CookieContainer = cookieContainer_0;
		@class.method_0().AllowAutoRedirect = bool_1;
		if (string_8 == null && string_3 == "POST")
		{
			@class.method_0().ContentType = "application/x-www-form-urlencoded";
		}
		if (class11_0.string_4 != null && class11_0.string_4 != "")
		{
			method_1("Accept-Language", class11_0.string_4, @class.method_0());
		}
		if (string_7 != null && string_7.Length >= 0)
		{
			foreach (string string_11 in string_7)
			{
				method_0(string_11, @class.method_1());
			}
		}
		string cookieHeader = cookieContainer_0.GetCookieHeader(@class.method_5());
		if (cookieHeader != "" && cookieHeader != null)
		{
			method_1("Cookie", cookieHeader, @class.method_0());
		}
		if (string_6 != null && string_6 != "")
		{
			@class.method_4(string_6);
		}
		else if (@class.method_0().Method == "POST")
		{
			@class.method_0().ContentLength = 0L;
		}
		return @class;
	}

	protected WebResponse method_4(Class31 class31_0, bool bool_1)
	{
		try
		{
			if (bool_1)
			{
				method_7();
			}
			class31_0.dateTime_0 = DateTime.Now;
			WebResponse response = class31_0.method_1().GetResponse();
			bool_0 = false;
			return response;
		}
		catch (WebException ex)
		{
			if (ex.Status == WebExceptionStatus.ConnectFailure)
			{
				bool_0 = true;
			}
			else
			{
				bool_0 = false;
			}
			if (ex.Response == null)
			{
				throw;
			}
			return ex.Response;
		}
	}

	public Class32 method_5(Class31 class31_0, bool bool_1)
	{
		WebResponse webResponse_ = method_4(class31_0, bool_1);
		Class32 @class = new Class32(webResponse_, class31_0);
		@class.dateTime_0 = DateTime.Now;
		if (@class.method_8() != null)
		{
			cookieContainer_0.Add(@class.method_8().Cookies);
		}
		if (bool_1)
		{
			if (bool_1 && class32_0 != null)
			{
				arrayList_0.Add(class32_0.method_11());
			}
			class32_0 = @class;
		}
		return @class;
	}

	[SpecialName]
	public Class32 method_6()
	{
		return class32_0;
	}

	public void method_7()
	{
		if (class32_0 != null)
		{
			try
			{
				class32_0.method_7().Close();
			}
			catch (Exception exception_)
			{
				class11_0.method_20("ERR00002", exception_);
			}
			class32_0 = null;
		}
	}

	protected virtual Uri vmethod_0(string string_3)
	{
		if (class32_0 != null)
		{
			return new Uri(class32_0.method_11(), string_3);
		}
		return new Uri(string_3);
	}

	protected Class32 method_8(string string_3)
	{
		return method_9(string_3, 0);
	}

	protected Class32 method_9(string string_3, int int_0)
	{
		return method_10(string_3, int_0, bool_1: false);
	}

	protected Class32 method_10(string string_3, int int_0, bool bool_1)
	{
		try
		{
			Uri uri = vmethod_0(string_3);
			Class31 @class = null;
			@class = ((uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps) ? method_3("GET", string_3, null, null, null, null, null, null, bool_1: true, bool_2: false, null) : method_2("GET", string_3, null, null, null, bool_1: false, null));
			if (int_0 != 0)
			{
				@class.method_0().Timeout = int_0;
			}
			return method_5(@class, bool_1: false);
		}
		catch (Exception exception_)
		{
			if (!bool_1)
			{
				class11_0.method_20("421FD59E-BD1E-428c-A1F8-A0D5AF646E4F", exception_);
			}
			return null;
		}
	}

	public string method_11(string string_3)
	{
		Class32 @class = method_8(string_3);
		if (@class == null)
		{
			return null;
		}
		string result = @class.method_4();
		@class.method_7().Close();
		return result;
	}

	public byte[] method_12(string string_3)
	{
		Class32 @class = method_8(string_3);
		if (@class == null)
		{
			return null;
		}
		byte[] result = @class.method_5();
		@class.method_7().Close();
		return result;
	}

	public string method_13(string string_3, string string_4, bool bool_1)
	{
		return method_14(string_3, string_4, 0, bool_1);
	}

	public string method_14(string string_3, string string_4, int int_0, bool bool_1)
	{
		FileStream fileStream = null;
		try
		{
			Class32 @class = method_9(string_3, int_0);
			if (@class == null)
			{
				return null;
			}
			if (@class.method_10() != 200)
			{
				return null;
			}
			fileStream = new FileStream(string_4, (!bool_1) ? FileMode.CreateNew : FileMode.Create, FileAccess.ReadWrite);
			@class.method_1(fileStream);
			@class.method_7().Close();
			fileStream.Close();
			return string_4;
		}
		catch (Exception exception_)
		{
			if (fileStream != null)
			{
				try
				{
					fileStream.Close();
				}
				catch
				{
				}
			}
			class11_0.method_20("7C97C871-5E4D-4348-B40F-3407608F9194: " + string_3 + "|" + string_4, exception_);
			return null;
		}
	}
}
