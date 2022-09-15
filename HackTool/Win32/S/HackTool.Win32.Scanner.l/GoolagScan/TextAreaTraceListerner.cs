using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GoolagScan;

internal class TextAreaTraceListerner : TraceListener
{
	private TextBox consoletb;

	public TextAreaTraceListerner(TextBox ctextbox)
	{
		consoletb = ctextbox;
	}

	public override void Write(string tracemsg)
	{
		if (!((Control)consoletb).get_IsDisposed())
		{
			((TextBoxBase)consoletb).AppendText(tracemsg);
		}
	}

	public override void WriteLine(string tracemsg)
	{
		if (!((Control)consoletb).get_IsDisposed())
		{
			((TextBoxBase)consoletb).AppendText(tracemsg + Environment.NewLine);
		}
	}
}
