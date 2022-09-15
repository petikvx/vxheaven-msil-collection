using System;
using System.Windows.Forms;

namespace VistalServiceAssistant;

internal static class Class0
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Form1 form = new Form1();
		Application.Run((Form)(object)form);
	}
}
