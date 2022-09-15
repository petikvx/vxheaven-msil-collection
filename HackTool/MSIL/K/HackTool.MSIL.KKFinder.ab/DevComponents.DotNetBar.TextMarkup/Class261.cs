using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class261 : Class256
{
	private Class244 class244_1;

	private Interface4 interface4_0;

	internal bool bool_2;

	internal string string_0 = "";

	private EventHandler eventHandler_0;

	public Class244 Class244_0 => class244_1;

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

	public Class261()
	{
		class244_1 = new Class244(null);
	}

	public void method_4(Control control_0)
	{
		if (interface4_0 != null)
		{
			interface4_0.imethod_2(control_0);
		}
		interface4_0 = null;
	}

	public void method_5(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		if (interface4_0 != null && interface4_0.imethod_0(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
		{
			return;
		}
		if (interface4_0 != null)
		{
			interface4_0.imethod_2(control_0);
		}
		interface4_0 = null;
		foreach (Interface4 item in class244_1)
		{
			if (item.imethod_0(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
			{
				interface4_0 = item;
				interface4_0.imethod_1(control_0);
			}
		}
	}

	public void method_6(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		if (interface4_0 != null)
		{
			interface4_0.imethod_3(control_0, mouseEventArgs_0);
		}
	}

	public void method_7(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		if (interface4_0 != null)
		{
			interface4_0.imethod_4(control_0, mouseEventArgs_0);
		}
	}

	public void method_8(Control control_0)
	{
		if (interface4_0 != null)
		{
			interface4_0.imethod_5(control_0);
			if (interface4_0 is Class262 && eventHandler_0 != null)
			{
				eventHandler_0(interface4_0, new EventArgs());
			}
		}
	}
}
