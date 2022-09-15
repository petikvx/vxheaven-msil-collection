using System.ComponentModel;
using System.Drawing;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[TypeConverter(typeof(BackgroundColorBlendConverter))]
[DesignTimeVisible(false)]
public class BackgroundColorBlend
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

	[Description("")]
	[DefaultValue(0f)]
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

	public BackgroundColorBlend()
	{
	}

	public BackgroundColorBlend(Color color, float position)
	{
		color_0 = color;
		float_0 = position;
	}

	public BackgroundColorBlend(int color, float position)
	{
		color_0 = ColorScheme.GetColor(color);
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
