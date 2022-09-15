using System.Drawing;

namespace DevComponents.DotNetBar.Rendering;

public class ColorBlendFactory : ColorFactory
{
	private Color color_0 = Color.Empty;

	public ColorBlendFactory(Color blendColor)
	{
		color_0 = blendColor;
	}

	public override Color GetColor(int rgb)
	{
		if (rgb == -1)
		{
			return Color.Empty;
		}
		return Color.FromArgb(smethod_0((rgb & 0xFF0000) >> 16, color_0.R), smethod_0((rgb & 0xFF00) >> 8, color_0.G), smethod_0(rgb & 0xFF, color_0.B));
	}

	public override Color GetColor(int alpha, int rgb)
	{
		if (rgb == -1)
		{
			return Color.Empty;
		}
		return Color.FromArgb(alpha, smethod_0((rgb & 0xFF0000) >> 16, color_0.R), smethod_0((rgb & 0xFF00) >> 8, color_0.G), smethod_0(rgb & 0xFF, color_0.B));
	}

	public override Color GetColor(Color c)
	{
		if (c.IsEmpty)
		{
			return Color.Empty;
		}
		return Color.FromArgb(smethod_0(c.R, color_0.R), smethod_0(c.G, color_0.G), smethod_0(c.B, color_0.B));
	}

	public override Color GetColor(string argb)
	{
		return GetColor(ColorScheme.GetColor(argb));
	}

	internal static int smethod_0(int int_0, int int_1)
	{
		int num = 0;
		num = int_0 * int_1 / 255;
		return num + int_0 * (255 - (255 - int_0) * (255 - int_1) / 255 - num) / 255;
	}

	internal static Color smethod_1(Color color_1, Color color_2)
	{
		return Color.FromArgb(smethod_0(color_1.R, color_2.R), smethod_0(color_1.G, color_2.G), smethod_0(color_1.B, color_2.B));
	}
}
