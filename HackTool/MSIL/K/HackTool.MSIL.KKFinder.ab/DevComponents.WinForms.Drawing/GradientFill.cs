using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.WinForms.Drawing;

public class GradientFill : Fill
{
	private Color color_0 = Color.Empty;

	private Color color_1 = Color.Empty;

	private ColorBlendCollection colorBlendCollection_0 = new ColorBlendCollection();

	private float float_0 = 90f;

	[Description("Indicates the fill color.")]
	public Color Color1
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
		}
	}

	[Description("Indicates the fill color.")]
	public Color Color2
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
		}
	}

	[Description("Collection that defines the multicolor gradient background.")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ColorBlendCollection InterpolationColors => colorBlendCollection_0;

	[Description("Indicates gradient fill angle.")]
	[DefaultValue(90)]
	public float Angle
	{
		get
		{
			return float_0;
		}
		set
		{
			float_0 = value;
		}
	}

	public GradientFill()
	{
	}

	public GradientFill(Color color1, Color color2)
	{
		color_0 = color1;
		color_1 = color2;
	}

	public GradientFill(Color color1, Color color2, float angle)
	{
		color_0 = color1;
		color_1 = color2;
		float_0 = angle;
	}

	public GradientFill(ColorStop[] interpolationColors)
	{
		colorBlendCollection_0.AddRange(interpolationColors);
	}

	public GradientFill(ColorStop[] interpolationColors, int angle)
	{
		colorBlendCollection_0.AddRange(interpolationColors);
		float_0 = angle;
	}

	public override Brush CreateBrush(Rectangle bounds)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		if ((!color_0.IsEmpty || !color_1.IsEmpty || colorBlendCollection_0.Count != 0) && bounds.Width >= 1 && bounds.Height >= 1)
		{
			LinearGradientBrush val = new LinearGradientBrush(bounds, color_0, color_1, float_0);
			if (colorBlendCollection_0.Count == 0)
			{
				return (Brush)(object)val;
			}
			val.set_InterpolationColors(colorBlendCollection_0.GetColorBlend());
			return (Brush)(object)val;
		}
		return null;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeColor1()
	{
		return !color_0.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetColor1()
	{
		Color1 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeColor2()
	{
		return !color_1.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetColor2()
	{
		Color2 = Color.Empty;
	}

	public override Pen CreatePen(int width)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if (!color_0.IsEmpty)
		{
			return new Pen(color_0, (float)width);
		}
		if (!color_1.IsEmpty)
		{
			return new Pen(color_1, (float)width);
		}
		return null;
	}
}
