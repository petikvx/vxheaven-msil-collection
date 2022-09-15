#define TRACE
using System;
using System.Diagnostics;
using System.Net;
using GoolagScanner.Debug;
using GoolagScanner.Properties;

namespace GoolagScanner;

internal class Proxify
{
	public WebProxy GetProxy()
	{
		WebProxy webProxy = new WebProxy();
		if (Settings.Default.UseSystemProxy)
		{
			WebRequest webRequest = WebRequest.Create("http://cultdeadcow.com");
			webProxy = webRequest.Proxy as WebProxy;
		}
		else if (!string.IsNullOrEmpty(Settings.Default.ProxyAddress))
		{
			try
			{
				Uri uri2 = (webProxy.Address = new Uri(Settings.Default.ProxyAddress));
			}
			catch (UriFormatException ex)
			{
				webProxy = null;
				System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceError, ex.Message);
			}
		}
		else
		{
			webProxy = WebRequest.DefaultWebProxy as WebProxy;
		}
		System.Diagnostics.Trace.WriteLineIf(message: (webProxy == null) ? "(no proxy set)" : webProxy.Address!.ToString(), condition: GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, category: "Proxy is ");
		return webProxy;
	}
}
