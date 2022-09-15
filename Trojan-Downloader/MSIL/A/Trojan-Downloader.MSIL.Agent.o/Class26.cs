using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

internal class Class26
{
	protected WebRequest webRequest_0;

	protected string string_0 = null;

	public DateTime dateTime_0;

	public Class26(WebRequest webRequest_1)
	{
		webRequest_0 = webRequest_1;
	}

	[SpecialName]
	public HttpWebRequest method_0()
	{
		return webRequest_0 as HttpWebRequest;
	}

	[SpecialName]
	public WebRequest method_1()
	{
		return webRequest_0;
	}

	[SpecialName]
	public FileWebRequest method_2()
	{
		return webRequest_0 as FileWebRequest;
	}

	[SpecialName]
	public string method_3()
	{
		return string_0;
	}

	[SpecialName]
	public void method_4(string string_1)
	{
		if (string_0 != null)
		{
			throw new Exception("Body already set.");
		}
		if (string_1 == null)
		{
			string_1 = "";
		}
		byte[] bytes = Class24.encoding_0.GetBytes(string_1);
		webRequest_0.ContentLength = bytes.Length;
		Stream requestStream = webRequest_0.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		string_0 = string_1;
	}

	[SpecialName]
	public Uri method_5()
	{
		return webRequest_0.RequestUri;
	}
}
