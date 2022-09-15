using System;

namespace GoolagScanner;

internal class RequestBuilder
{
	private IScanProvider scanprovider;

	public RequestBuilder(IScanProvider myScanProvider)
	{
		scanprovider = myScanProvider;
	}

	public string getRequest(string mdork, string site, int resPage)
	{
		string stringToEscape = StripSite(mdork);
		string text = scanprovider.HostUrl + scanprovider.QueryCommand + Uri.EscapeUriString(stringToEscape);
		if (!string.IsNullOrEmpty(site))
		{
			text = text + " " + scanprovider.TargetSite + site;
		}
		if (resPage > 0)
		{
			text = text + scanprovider.ResultPageModifier + resPage;
		}
		return text;
	}

	protected string StripSite(string dorkquery)
	{
		int num = 0;
		while ((num = dorkquery.IndexOf(scanprovider.OmitSite)) != -1)
		{
			int num2 = dorkquery.IndexOf(' ', num);
			if (num2 == -1)
			{
				num2 = dorkquery.Length;
			}
			dorkquery = dorkquery.Remove(num, num2 - num);
		}
		return dorkquery;
	}
}
