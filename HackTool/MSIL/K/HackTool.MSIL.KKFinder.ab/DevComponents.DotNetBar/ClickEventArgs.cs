using System;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class ClickEventArgs : EventArgs
{
	public readonly eEventSource EventSource = eEventSource.Code;

	public readonly MouseButtons Button;

	public ClickEventArgs(eEventSource action, MouseButtons button)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EventSource = action;
		Button = button;
	}
}
