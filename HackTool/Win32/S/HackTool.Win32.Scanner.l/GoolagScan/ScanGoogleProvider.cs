namespace GoolagScan;

internal class ScanGoogleProvider : IScanProvider
{
	string IScanProvider.HostUrl => "http://www.google.com";

	string IScanProvider.QueryCommand => "/search?q=";

	string IScanProvider.TargetSite => "+site:";

	string IScanProvider.OmitSite => "-site:";

	string IScanProvider.ResultPageModifier => "&start=";
}
