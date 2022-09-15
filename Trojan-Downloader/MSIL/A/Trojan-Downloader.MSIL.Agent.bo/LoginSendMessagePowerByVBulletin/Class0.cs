using System;
using System.Windows.Forms;

namespace LoginSendMessagePowerByVBulletin;

internal static class Class0
{
	public static Form1 form1_0;

	[STAThread]
	private static int Main(string[] args)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		form1_0 = new Form1(args[0], args[1], args[2], args[3], args[4], args[5]);
		((Form)form1_0).ShowDialog();
		return form1_0.int_0;
	}
}
