using System.ComponentModel;
using System.Drawing;

namespace DevComponents.WinForms.Drawing;

public class SolidFill : Fill
{
	private Color color_0 = Color.Empty;

	[Description("Indicates the fill color.")]
	public Color Color
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

	public SolidFill(Color color)
	{
		color_0 = color;
	}

	public SolidFill()
	{
	}

	public override Brush CreateBrush(Rectangle bounds)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		if (color_0.IsEmpty)
		{
			return null;
		}
		return (Brush)new SolidBrush(color_0);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeColor()
	{
		return !color_0.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetColor()
	{
		Color = Color.Empty;
	}

	public override Pen CreatePen(int width)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		if (!color_0.IsEmpty)
		{
			return new Pen(color_0, (float)width);
		}
		return null;
	}
}
