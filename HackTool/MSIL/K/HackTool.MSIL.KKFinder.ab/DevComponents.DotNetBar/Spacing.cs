using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DevComponents.DotNetBar;

[TypeConverter(typeof(ExpandableObjectConverter))]
[ToolboxItem(false)]
public class Spacing
{
	private EventHandler eventHandler_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	[DefaultValue(0)]
	[DevCoSerialize]
	[Description("Indicates the amount of the space on the left side.")]
	[Browsable(true)]
	public int Left
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			method_0();
		}
	}

	[DefaultValue(0)]
	[Description("Indicates the amount of the space on the right side.")]
	[Browsable(true)]
	[DevCoSerialize]
	public int Right
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			method_0();
		}
	}

	[DefaultValue(0)]
	[DevCoSerialize]
	[Browsable(true)]
	[Description("Indicates the amount of the space on the top.")]
	public int Top
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
			method_0();
		}
	}

	[Description("Indicates the amount of the space on the bottom.")]
	[DevCoSerialize]
	[DefaultValue(0)]
	[Browsable(true)]
	public int Bottom
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
			method_0();
		}
	}

	[Browsable(false)]
	public int Horizontal => Left + Right;

	[Browsable(false)]
	public int Vertical => Top + Bottom;

	[Browsable(false)]
	public bool IsEmpty
	{
		get
		{
			if (int_0 == 0 && int_1 == 0 && int_2 == 0)
			{
				return int_3 == 0;
			}
			return false;
		}
	}

	public event EventHandler SpacingChanged
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

	private void method_0()
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
	}
}
