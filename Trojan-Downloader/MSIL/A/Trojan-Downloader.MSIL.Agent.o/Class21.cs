using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

internal class Class21
{
	protected Class27 class27_0;

	public string string_0 = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322)";

	public IWebProxy iwebProxy_0;

	public string string_1;

	public Class23 class23_0;

	public CookieContainer cookieContainer_0 = new CookieContainer();

	public string[] string_2;

	static Class21()
	{
		ServicePointManager.Expect100Continue = false;
	}

	public Class21(Class23 class23_1)
	{
		class23_0 = class23_1;
		iwebProxy_0 = class23_0.method_21(out string_1);
		string_0 = class23_0.method_10();
	}

	public Class26 method_0(string string_3, string string_4, string string_5, string string_6, string[] string_7, bool bool_0, IWebProxy iwebProxy_1)
	{
		Uri uri = method_6(string_4);
		if (string_5 != null && string_5 != "")
		{
			string_4 = ((uri.Query == null || uri.Query == "") ? (string_4 + "?" + string_5) : (string_4 + "&" + string_5));
			uri = method_6(string_4);
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
			foreach (string header in array)
			{
				webRequest.Headers.Add(header);
			}
		}
		if (string_7 != null && string_7.Length >= 0)
		{
			string[] array = string_7;
			foreach (string header2 in array)
			{
				webRequest.Headers.Add(header2);
			}
		}
		if (bool_0)
		{
			webRequest.Headers["Accept-Encoding"] = "gzip, deflate";
		}
		return new Class26(webRequest);
	}

	public Class26 method_1(string string_3, string string_4, string string_5, string string_6, string[] string_7, string string_8, string string_9, string string_10, bool bool_0, bool bool_1, IWebProxy iwebProxy_1)
	{
		Class26 @class = method_0(string_3, string_4, string_5, string_8, string_7, bool_1, iwebProxy_1);
		if (@class.method_5().Scheme != Uri.UriSchemeHttp && @class.method_5().Scheme != Uri.UriSchemeHttps)
		{
			throw new Exception("Only HTTP requests are allowed");
		}
		@class.method_0().Referer = ((string_9 != null) ? string_9 : ((class27_0 != null) ? class27_0.method_11().ToString() : null));
		@class.method_0().UserAgent = ((string_10 == null) ? string_0 : string_10);
		@class.method_0().KeepAlive = true;
		@class.method_0().Accept = "*/*";
		@class.method_0().CookieContainer = cookieContainer_0;
		@class.method_0().AllowAutoRedirect = bool_0;
		string cookieHeader = cookieContainer_0.GetCookieHeader(@class.method_5());
		if (cookieHeader != "" && cookieHeader != null)
		{
			@class.method_0().Headers.Add("Cookie", cookieHeader);
		}
		if (string_6 != null)
		{
			@class.method_4(string_6);
		}
		return @class;
	}

	protected WebResponse method_2(Class26 class26_0, bool bool_0)
	{
		try
		{
			if (bool_0)
			{
				method_5();
			}
			class26_0.dateTime_0 = DateTime.Now;
			return class26_0.method_1().GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Response == null)
			{
				throw;
			}
			return ex.Response;
		}
	}

	public Class27 method_3(Class26 class26_0, bool bool_0)
	{
		WebResponse webResponse_ = method_2(class26_0, bool_0);
		Class27 @class = new Class27(webResponse_, class26_0);
		@class.dateTime_0 = DateTime.Now;
		if (@class.method_8() != null)
		{
			cookieContainer_0.Add(@class.method_8().Cookies);
		}
		if (bool_0)
		{
			class27_0 = @class;
		}
		return @class;
	}

	[SpecialName]
	public Class27 method_4()
	{
		return class27_0;
	}

	public void method_5()
	{
		if (class27_0 != null)
		{
			try
			{
				class27_0.method_7().Close();
			}
			catch (Exception exception_)
			{
				class23_0.method_13(exception_);
			}
			class27_0 = null;
		}
	}

	protected Uri method_6(string string_3)
	{
		if (class27_0 != null)
		{
			return new Uri(class27_0.method_11(), string_3);
		}
		return new Uri(string_3);
	}

	protected Class27 method_7(string string_3)
	{
		try
		{
			Uri uri = method_6(string_3);
			Class26 @class = null;
			@class = ((uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps) ? method_1("GET", string_3, null, null, null, null, null, null, bool_0: true, bool_1: false, null) : method_0("GET", string_3, null, null, null, bool_0: false, null));
			return method_3(@class, bool_0: false);
		}
		catch (Exception exception_)
		{
			class23_0.method_13(exception_);
			return null;
		}
	}

	public string method_8(string string_3)
	{
		Class27 @class = method_7(string_3);
		if (@class == null)
		{
			return null;
		}
		string result = @class.method_4();
		@class.method_7().Close();
		return result;
	}

	public byte[] method_9(string string_3)
	{
		Class27 @class = method_7(string_3);
		if (@class == null)
		{
			return null;
		}
		byte[] result = @class.method_5();
		@class.method_7().Close();
		return result;
	}

	public string method_10(string string_3, string string_4, bool bool_0)
	{
		FileStream fileStream = null;
		try
		{
			Class27 @class = method_7(string_3);
			if (@class == null)
			{
				return null;
			}
			fileStream = new FileStream(string_4, (!bool_0) ? FileMode.CreateNew : FileMode.Create, FileAccess.ReadWrite);
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
			class23_0.method_13(exception_);
			return null;
		}
	}
}
