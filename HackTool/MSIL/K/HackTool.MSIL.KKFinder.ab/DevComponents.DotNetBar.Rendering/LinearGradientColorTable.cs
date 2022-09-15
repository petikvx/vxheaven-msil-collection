using System.Drawing;

namespace DevComponents.DotNetBar.Rendering;

public class LinearGradientColorTable
{
	public Color Start = Color.Empty;

	public Color End = Color.Empty;

	public int GradientAngle = 90;

	public bool IsEmpty
	{
		get
		{
			if (Start.IsEmpty)
			{
				return End.IsEmpty;
			}
			return false;
		}
	}

	public LinearGradientColorTable()
	{
	}

	public LinearGradientColorTable(Color start)
	{
		Start = start;
	}

	public LinearGradientColorTable(Color start, Color end)
	{
		Start = start;
		End = end;
	}

	public LinearGradientColorTable(string start, string end)
	{
		Start = ColorScheme.GetColor(start);
		End = ColorScheme.GetColor(end);
	}

	public LinearGradientColorTable(int start, int end)
	{
		Start = ColorScheme.GetColor(start);
		End = ColorScheme.GetColor(end);
	}

	public LinearGradientColorTable(int start, int end, int gradientAngle)
	{
		Start = ColorScheme.GetColor(start);
		End = ColorScheme.GetColor(end);
		GradientAngle = gradientAngle;
	}

	public LinearGradientColorTable(Color start, Color end, int gradientAngle)
	{
		Start = start;
		End = end;
		GradientAngle = gradientAngle;
	}
}
