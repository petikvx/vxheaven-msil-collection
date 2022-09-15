using System;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class QatCustomizeDialogEventArgs : EventArgs
{
	public bool Cancel;

	public Form Dialog;

	public QatCustomizeDialogEventArgs(Form dialog)
	{
		Dialog = dialog;
	}
}
