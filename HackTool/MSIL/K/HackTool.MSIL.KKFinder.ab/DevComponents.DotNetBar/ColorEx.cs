using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace DevComponents.DotNetBar;

[TypeConverter(typeof(ExpandableObjectConverter))]
[ToolboxItem(false)]
[EditorBrowsable(EditorBrowsableState.Never)]
public class ColorEx
{
	private Color color_0 = Color.Empty;

	private byte byte_0 = byte.MaxValue;

	private eColorSchemePart eColorSchemePart_0 = eColorSchemePart.Custom;

	internal bool bool_0;

	private EventHandler eventHandler_0;

	[NotifyParentProperty(true)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color Color
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			if (color_0 != Color.Empty)
			{
				eColorSchemePart_0 = eColorSchemePart.Custom;
				bool_0 = true;
			}
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs());
			}
		}
	}

	[NotifyParentProperty(true)]
	[DefaultValue(byte.MaxValue)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public byte Alpha
	{
		get
		{
			return byte_0;
		}
		set
		{
			if (byte_0 != value)
			{
				byte_0 = value;
				bool_0 = true;
			}
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs());
			}
		}
	}

	[NotifyParentProperty(true)]
	[DefaultValue(eColorSchemePart.Custom)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public eColorSchemePart ColorSchemePart
	{
		get
		{
			return eColorSchemePart_0;
		}
		set
		{
			eColorSchemePart_0 = value;
			if (eColorSchemePart_0 != eColorSchemePart.Custom)
			{
				color_0 = Color.Empty;
				bool_0 = true;
			}
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs());
			}
		}
	}

	public static ColorEx Empty => new ColorEx(Color.Empty);

	[Browsable(false)]
	[DevCoBrowsable(false)]
	public bool IsEmpty => color_0 == Color.Empty;

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

	public ColorEx()
	{
	}

	private ColorEx(Color color)
	{
		Color = color;
		Alpha = byte.MaxValue;
	}

	private ColorEx(Color color, byte opacity)
	{
		Color = color;
		Alpha = opacity;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeColor()
	{
		if (color_0 != Color.Empty)
		{
			return eColorSchemePart_0 == eColorSchemePart.Custom;
		}
		return false;
	}

	internal void method_0(Color color_1)
	{
		color_0 = color_1;
	}

	internal void method_1(eColorSchemePart eColorSchemePart_1)
	{
		eColorSchemePart_0 = eColorSchemePart_1;
	}

	public Color GetCompositeColor()
	{
		if (color_0.IsEmpty)
		{
			return Color.Empty;
		}
		return Color.FromArgb(byte_0, color_0);
	}
}
