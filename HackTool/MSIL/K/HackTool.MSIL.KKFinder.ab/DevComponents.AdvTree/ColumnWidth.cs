using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DevComponents.AdvTree;

[TypeConverter(typeof(ExpandableObjectConverter))]
[ToolboxItem(false)]
[DesignTimeVisible(false)]
public class ColumnWidth
{
	private int int_0;

	private int int_1;

	private EventHandler eventHandler_0;

	[Browsable(true)]
	[Description("Gets or sets relative width in percent. Valid values are between 1-100 with 0 indicating that absolute width will be used.")]
	[DefaultValue(0)]
	public int Relative
	{
		get
		{
			return int_0;
		}
		set
		{
			if (int_0 != value)
			{
				int_0 = value;
				method_1();
			}
		}
	}

	[DefaultValue(0)]
	[Description("Gets or sets the absolute width of the column in pixels.")]
	[Browsable(true)]
	public int Absolute
	{
		get
		{
			return int_1;
		}
		set
		{
			if (int_1 >= 0 && int_1 != value)
			{
				int_1 = value;
				if (int_1 != 0)
				{
					int_0 = 0;
				}
				method_1();
			}
		}
	}

	internal event EventHandler Event_0
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

	internal int method_0(int int_2)
	{
		if (int_1 > 0)
		{
			return int_1;
		}
		if (int_0 > 0)
		{
			return 100 / int_0 * int_2;
		}
		return 0;
	}

	private void method_1()
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
	}
}
