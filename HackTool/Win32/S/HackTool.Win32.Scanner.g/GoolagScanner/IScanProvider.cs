namespace GoolagScanner;

internal interface IScanProvider
{
	string HostUrl { get; }

	string QueryCommand { get; }

	string TargetSite { get; }

	string OmitSite { get; }

	string ResultPageModifier { get; }
}
