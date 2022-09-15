using System;
using System.Windows.Forms;

namespace SoftwareUpgrade;

internal static class Class0
{
	public static Form1 form1_0;

	[STAThread]
	private static int Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Form1 form = (form1_0 = new Form1(args[0], args[1]));
		Application.Run((Form)(object)form);
		return form.int_0;
	}
}
