using System;
using System.Windows.Forms;

namespace RegisterPoweredbyVBulletin;

internal static class Class0
{
	public static Form1 form1_0;

	[STAThread]
	private static int Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		form1_0 = new Form1(args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8], args[9], args[10], args[11], args[12], args[13]);
		Application.Run((Form)(object)form1_0);
		return form1_0.int_0;
	}
}
