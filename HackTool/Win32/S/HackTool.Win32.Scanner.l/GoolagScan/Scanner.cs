#define TRACE
using System.Collections.Generic;
using System.Diagnostics;
using GoolagScan.Debug;
using GoolagScan.Properties;

namespace GoolagScan;

internal class Scanner
{
	private IScanProvider scanProvider;

	private List<string> parsedResults;

	private HttpSimpleGet httpGet;

	private DorkDone firstResultDork;

	private DorkDone _DorkToScan;

	private volatile int _ScanStatus;

	public DorkDone ResultDork => firstResultDork;

	public int Count => parsedResults.Count;

	public int ScanStatus
	{
		get
		{
			return _ScanStatus;
		}
		set
		{
			_ScanStatus = value;
		}
	}

	public Scanner(IScanProvider ScanProvider)
	{
		scanProvider = ScanProvider;
		_ScanStatus = 0;
		httpGet = null;
	}

	public Scanner(IScanProvider ScanProvider, DorkDone dorkToScan)
	{
		scanProvider = ScanProvider;
		_ScanStatus = 0;
		_DorkToScan = dorkToScan;
		httpGet = null;
	}

	public void Do()
	{
		DoDork(_DorkToScan);
	}

	public bool DoDork(DorkDone DorkToScan)
	{
		_ScanStatus = 1;
		RequestBuilder requestBuilder = new RequestBuilder(scanProvider);
		httpGet = new HttpSimpleGet(Settings.Default.ScanTimeOut);
		string request = requestBuilder.getRequest(DorkToScan.Query, DorkToScan.Host, DorkToScan.NextPage);
		System.Diagnostics.Trace.WriteLineIf(GoolagScan.Debug.Trace.TraceGoolag.TraceInfo, request, "ScanURL:");
		if (!httpGet.Do(request))
		{
			DorkToScan.ErrorMessage = httpGet.getErrorMessage();
			DorkToScan.ScanResult = 3;
			_ScanStatus = 2;
			firstResultDork = DorkToScan;
			return false;
		}
		ParseHtmlResults parseHtmlResults = new ParseHtmlResults(scanProvider, DorkToScan.NextPage);
		parsedResults = parseHtmlResults.Parse(httpGet.getResults());
		if (parsedResults.Count > 0)
		{
			DorkToScan.ScanResult = 2;
			DorkToScan.NextPage = parseHtmlResults.NextPage;
			DorkDone next = null;
			foreach (string parsedResult in parsedResults)
			{
				DorkDone dorkDone = new DorkDone();
				dorkDone = (DorkDone)DorkToScan.Clone();
				dorkDone.ResultURL = parsedResult;
				dorkDone.Next = next;
				next = dorkDone;
			}
			firstResultDork = next;
		}
		else
		{
			DorkToScan.Next = null;
			firstResultDork = DorkToScan;
			if (parseHtmlResults.Blocked)
			{
				DorkToScan.ScanResult = 4;
				DorkToScan.ResultURL = httpGet.ResponseUri;
			}
			else
			{
				DorkToScan.ScanResult = 0;
			}
		}
		_ScanStatus = 2;
		return true;
	}

	public void Abort()
	{
		if (httpGet != null)
		{
			httpGet.Abort();
		}
	}
}
