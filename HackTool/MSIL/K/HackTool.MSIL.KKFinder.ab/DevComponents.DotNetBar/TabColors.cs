using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[TypeConverter(typeof(ExpandableObjectConverter))]
public class TabColors
{
	private EventHandler eventHandler_0;

	private Color color_0 = Color.Empty;

	private Color color_1 = Color.Empty;

	private int int_0 = 90;

	private Color color_2 = Color.Empty;

	private Color color_3 = Color.Empty;

	private Color color_4 = Color.Empty;

	private Color color_5 = Color.Empty;

	private BackgroundColorBlendCollection backgroundColorBlendCollection_0 = new BackgroundColorBlendCollection();

	[Browsable(true)]
	[Category("Style")]
	[Description("Indicates the inactive tab background color.")]
	public Color BackColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			method_0();
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[Description("Indicates the inactive tab target gradient background color.")]
	public Color BackColor2
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			method_0();
		}
	}

	[Browsable(true)]
	[DefaultValue(90)]
	[Category("Style")]
	[Description("Indicates the gradient angle.")]
	public int BackColorGradientAngle
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

	[Description("Collection that defines the multicolor gradient background.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	public BackgroundColorBlendCollection BackgroundColorBlend => backgroundColorBlendCollection_0;

	[Category("Style")]
	[Description("Indicates the inactive tab light border color.")]
	[Browsable(true)]
	public Color LightBorderColor
	{
		get
		{
			return color_2;
		}
		set
		{
			color_2 = value;
			method_0();
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[Description("Indicates the inactive tab dark border color.")]
	public Color DarkBorderColor
	{
		get
		{
			return color_3;
		}
		set
		{
			color_3 = value;
			method_0();
		}
	}

	[Category("Style")]
	[Description("Indicates the inactive tab border color.")]
	[Browsable(true)]
	public Color BorderColor
	{
		get
		{
			return color_4;
		}
		set
		{
			color_4 = value;
			method_0();
		}
	}

	[Category("Style")]
	[Browsable(true)]
	[Description("Indicates the inactive tab text color.")]
	public Color TextColor
	{
		get
		{
			return color_5;
		}
		set
		{
			color_5 = value;
			method_0();
		}
	}

	public event EventHandler ColorChanged
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

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackColor()
	{
		return !color_0.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void ResetBackColor()
	{
		BackColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeBackColor2()
	{
		return !color_1.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void ResetBackColor2()
	{
		BackColor2 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeLightBorderColor()
	{
		return !color_2.IsEmpty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetLightBorderColor()
	{
		LightBorderColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeDarkBorderColor()
	{
		return !color_3.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void ResetDarkBorderColor()
	{
		DarkBorderColor = Color.Empty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBorderColor()
	{
		return !color_4.IsEmpty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBorderColor()
	{
		BorderColor = Color.Empty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTextColor()
	{
		return !color_5.IsEmpty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTextColor()
	{
		TextColor = Color.Empty;
	}

	private void method_0()
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
	}
}
