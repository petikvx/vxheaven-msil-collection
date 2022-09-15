using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ServiceManager;

[StandardModule]
internal sealed class SubMain
{
	public static string Arg = "";

	[STAThread]
	public static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		if (args.Length == 1 && Operators.CompareString(args[0], "", false) != 0)
		{
			Arg = args[0].Remove(0, 1);
		}
		frmMain frmMain2 = new frmMain();
		((Control)frmMain2).Show();
		Application.Run();
	}
}
