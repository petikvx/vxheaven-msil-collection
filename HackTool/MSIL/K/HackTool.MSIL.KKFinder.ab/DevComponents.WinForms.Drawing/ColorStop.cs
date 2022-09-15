using System.ComponentModel;
using System.Drawing;

namespace DevComponents.WinForms.Drawing;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
[TypeConverter(typeof(ColorStopConverter))]
public class ColorStop
{
	private Color color_0 = Color.Empty;

	private float float_0;

	[Browsable(true)]
	[Description("Indicates the Color to use in multicolor gradient blend at specified position.")]
	public Color Color
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

	[DefaultValue(0f)]
	[Description("")]
	[Browsable(true)]
	public float Position
	{
		get
		{
			return float_0;
		}
		set
		{
			float_0 = value;
			method_0();
		}
	}

	public ColorStop()
	{
	}

	public ColorStop(Color color, float position)
	{
		color_0 = color;
		float_0 = position;
	}

	private bool ShouldSerializeColor()
	{
		return !color_0.IsEmpty;
	}

	private void method_0()
	{
	}
}
