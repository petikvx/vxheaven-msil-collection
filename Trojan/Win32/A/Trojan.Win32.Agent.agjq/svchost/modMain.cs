using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost;

[StandardModule]
internal sealed class modMain
{
	public static string WebRoot = "C:\\Windows\\";

	[STAThread]
	public static void Main()
	{
		frmMain frmMain2 = new frmMain();
		Application.Run((Form)(object)frmMain2);
	}
}
