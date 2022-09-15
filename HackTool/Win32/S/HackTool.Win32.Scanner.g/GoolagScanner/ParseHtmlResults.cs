#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using GoolagScanner.Debug;

namespace GoolagScanner;

internal class ParseHtmlResults
{
	private const string hitFound = "<div class=g>";

	private const string hitUrlFound = "<a href=\"";

	private IScanProvider scanProvider;

	private string _NextPage = "0";

	private int currentResultPage;

	private bool _blocked;

	public int NextPage
	{
		get
		{
			try
			{
				return Convert.ToInt32(_NextPage);
			}
			catch (Exception ex)
			{
				System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceError, ex.Message, "ParseError on NextPage: ");
				return 0;
			}
		}
	}

	public bool Blocked => _blocked;

	public ParseHtmlResults(IScanProvider scanprovider, int resultpage)
	{
		scanProvider = scanprovider;
		currentResultPage = resultpage;
		_blocked = false;
	}

	private static string getNextDigits(string sline, ref int sidx)
	{
		string text = "";
		while (true)
		{
			char c = sline[sidx++];
			if (!char.IsDigit(c))
			{
				break;
			}
			text += c;
		}
		return text;
	}

	public List<string> Parse(string toParse)
	{
		List<string> list = new List<string>();
		int startIndex = 0;
		int num = 0;
		while ((num = toParse.IndexOf("<div class=g>", startIndex)) != -1)
		{
			num = toParse.IndexOf("<a href=\"", num);
			if (num == -1)
			{
				continue;
			}
			int num2 = num + "<a href=\"".Length;
			int num3 = toParse.IndexOf('"', num2);
			if (num3 != -1)
			{
				string text = toParse.Substring(num2, num3 - num2);
				int num4 = text.LastIndexOf('"');
				if (num4 != -1)
				{
					text.Remove(num4, 1);
				}
				list.Add(text);
				startIndex = num3;
			}
		}
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceInfo, list.Count, "Count of results ");
		if (num == -1 && list.Count == 0 && toParse.IndexOf("<title>403 Forbidden</title>") != -1)
		{
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceInfo, "We may got blocked.");
			_blocked = true;
			return list;
		}
		startIndex = toParse.Length - 1;
		startIndex = toParse.LastIndexOf(scanProvider.ResultPageModifier);
		if (startIndex != -1)
		{
			startIndex += scanProvider.ResultPageModifier.Length;
			_NextPage = getNextDigits(toParse, ref startIndex);
		}
		else
		{
			_NextPage = "0";
		}
		int num5 = Convert.ToInt32(_NextPage);
		if (num5 <= currentResultPage)
		{
			_NextPage = "0";
		}
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceInfo, _NextPage, "Next page to request ");
		return list;
	}
}
