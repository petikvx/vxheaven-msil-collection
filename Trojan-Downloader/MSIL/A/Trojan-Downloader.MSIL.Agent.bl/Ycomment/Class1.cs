using System;
using System.Windows.Forms;

namespace Ycomment;

internal static class Class1
{
	public static Form1 form1_0;

	[STAThread]
	private static int Main(string[] args)
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		form1_0 = new Form1(args[0].Replace("###", " "), args[1].Replace("###", " "), args[2].Replace("###", " "), args[3].Replace("###", " "), args[4].Replace("###", " "), args[5].Replace("###", " "), args[6].Replace("###", " "), args[7].Replace("###", " "), args[8].Replace("###", " "), args[9].Replace("###", " "), args[10].Replace("###", " "));
		((Form)form1_0).ShowDialog();
		return form1_0.int_0;
	}
}
