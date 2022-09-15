using System.ComponentModel;
using System.Drawing;

namespace DevComponents.WinForms.Drawing;

public class SolidBorder : Border
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

	public SolidBorder(Color color, int width)
	{
		color_0 = color;
		int_0 = width;
	}

	public SolidBorder(Color color)
	{
		color_0 = color;
	}

	public SolidBorder()
	{
	}

	public override Pen CreatePen()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		if (!method_0())
		{
			return null;
		}
		return new Pen(color_0, (float)int_0);
	}

	private bool method_0()
	{
		if (!color_0.IsEmpty)
		{
			return int_0 > 0;
		}
		return false;
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
}
