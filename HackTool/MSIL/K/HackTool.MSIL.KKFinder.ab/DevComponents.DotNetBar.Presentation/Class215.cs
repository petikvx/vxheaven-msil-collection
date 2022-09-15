using System.Drawing;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.Presentation;

internal class Class215
{
	public int int_0;

	public Color color_0 = Color.Empty;

	public Color color_1 = Color.Empty;

	public int int_1 = 90;

	public Class215()
	{
	}

	public Class215(int borderWidth)
	{
		int_0 = borderWidth;
	}

	public Class215(LinearGradientColorTable table)
	{
		color_0 = table.Start;
		color_1 = table.End;
		int_0 = 1;
	}

	public Class215(LinearGradientColorTable table, int width)
	{
		color_0 = table.Start;
		color_1 = table.End;
		int_0 = width;
	}

	public Class215(Color color1, Color color2, int width)
	{
		color_0 = color1;
		color_1 = color2;
		int_0 = width;
	}

	public Class215(Color color1, int width)
	{
		color_0 = color1;
		color_1 = Color.Empty;
		int_0 = width;
	}

	public void method_0(LinearGradientColorTable linearGradientColorTable_0)
	{
		if (linearGradientColorTable_0 == null)
		{
			color_0 = Color.Empty;
			color_1 = Color.Empty;
		}
		else
		{
			color_0 = linearGradientColorTable_0.Start;
			color_1 = linearGradientColorTable_0.End;
		}
	}
}
