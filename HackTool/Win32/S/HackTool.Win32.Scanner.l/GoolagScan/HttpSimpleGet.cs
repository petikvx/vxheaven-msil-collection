#define TRACE
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using GoolagScan.Debug;
using GoolagScan.Properties;

namespace GoolagScan;

internal class HttpSimpleGet
{
	private string rawResults = "";

	private string errMessage = "";

	private int TimeOut = 10000;

	private HttpWebRequest webRequest;

	private static WebProxy proxy;

	private string _responseUri;

	public static WebProxy Proxy
	{
		set
		{
			proxy = value;
		}
	}

	public string ResponseUri => _responseUri;

	public HttpSimpleGet(int timeout)
	{
		TimeOut = timeout;
	}

	public bool Do(string request)
	{
		webRequest = (HttpWebRequest)WebRequest.Create(request);
		webRequest.UserAgent = Settings.Default.UserAgent;
		webRequest.Accept = "text/xml,application/xml,application/xhtml+xml,text/html,text/plain,image/png,*/*";
		webRequest.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8");
		webRequest.Method = "GET";
		webRequest.ProtocolVersion = HttpVersion.Version11;
		webRequest.Timeout = TimeOut;
		webRequest.AllowAutoRedirect = true;
		webRequest.MaximumAutomaticRedirections = 5;
		if (proxy != null)
		{
			try
			{
				webRequest.Proxy = proxy;
			}
			catch (NotSupportedException ex)
			{
				webRequest.Proxy = null;
				System.Diagnostics.Trace.WriteLineIf(GoolagScan.Debug.Trace.TraceGoolag.TraceError, ex.Message, "HttpSimpleGet proxy error");
			}
		}
		HttpWebResponse httpWebResponse;
		try
		{
			httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
		}
		catch (Exception ex2)
		{
			errMessage = ex2.Message;
			return false;
		}
		_responseUri = httpWebResponse.ResponseUri.ToString();
		try
		{
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
			rawResults = streamReader.ReadToEnd();
			streamReader.Close();
		}
		catch (WebException ex3)
		{
			System.Diagnostics.Trace.WriteLineIf(GoolagScan.Debug.Trace.TraceGoolag.TraceError, "WebResponse empty or not readable.");
			errMessage = ex3.Message;
			return false;
		}
		catch (IOException ex4)
		{
			System.Diagnostics.Trace.WriteLineIf(GoolagScan.Debug.Trace.TraceGoolag.TraceError, "IO-Error on network-device.");
			errMessage = ex4.Message;
			return false;
		}
		return true;
	}

	public void Abort()
	{
		if (webRequest != null)
		{
			webRequest.Abort();
		}
	}

	public string getResults()
	{
		return rawResults;
	}

	public string getErrorMessage()
	{
		return errMessage;
	}
}
