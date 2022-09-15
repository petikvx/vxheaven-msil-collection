using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class33 : NativeWindow
{
	private const int int_0 = 560;

	private const int int_1 = 564;

	private EventHandler eventHandler_0;

	public bool bool_0;

	public event EventHandler Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 560 || ((Message)(ref m)).get_Msg() == 564)
		{
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs());
			}
			if (bool_0)
			{
				bool_0 = false;
				return;
			}
		}
		((NativeWindow)this).WndProc(ref m);
	}
}
