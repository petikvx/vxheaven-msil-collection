using System.Configuration;

namespace Absinthe;

internal class Absinthe
{
	public const string AppName = "Absinthe";

	public const string AppVersion = "1.1";

	public static void Main(string[] args)
	{
		InitApp();
		new MainWin();
	}

	private static void InitApp()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new AppSettingsReader();
	}
}
