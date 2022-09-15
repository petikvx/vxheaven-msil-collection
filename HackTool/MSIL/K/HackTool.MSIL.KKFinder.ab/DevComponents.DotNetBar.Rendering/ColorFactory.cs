using System.Drawing;

namespace DevComponents.DotNetBar.Rendering;

public class ColorFactory
{
	public virtual Color GetColor(int color)
	{
		return ColorScheme.GetColor(color);
	}

	public virtual Color GetColor(int alpha, int color)
	{
		return ColorScheme.GetColor(alpha, color);
	}

	public virtual Color GetColor(Color color)
	{
		return color;
	}

	public virtual Color GetColor(string argb)
	{
		return ColorScheme.GetColor(argb);
	}
}
