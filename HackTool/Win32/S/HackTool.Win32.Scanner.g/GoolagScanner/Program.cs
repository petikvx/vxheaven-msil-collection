using System;
using System.Windows.Forms;
using GoolagScanner.Properties;

namespace GoolagScanner;

internal static class Program
{
	internal static Splash Splash_cDc;

	internal static Splash Splash_Goolag;

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		if (Settings.Default.ShowSplash)
		{
			Splash_cDc = new Splash(320, 428, Resources.Cdc009, 0.025, 0.03, 3);
			((Control)Splash_cDc).Show();
			Application.DoEvents();
		}
		Application.Run((Form)(object)new GScanForm());
	}
}
