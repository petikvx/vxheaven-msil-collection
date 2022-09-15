using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.Presentation;

internal class Class210 : Class209
{
	public Color color_0 = Color.Empty;

	public Color color_1 = Color.Empty;

	public int int_0 = 90;

	public BackgroundColorBlendCollection backgroundColorBlendCollection_0;

	public eGradientType eGradientType_0;

	public Class210()
	{
	}

	public Class210(Color color1, Color color2)
	{
		color_0 = color1;
		color_1 = color2;
	}

	public Class210(LinearGradientColorTable table)
	{
		color_0 = table.Start;
		color_1 = table.End;
	}

	public Class210(Color color1)
	{
		color_0 = color1;
		color_1 = Color.Empty;
	}

	public void method_0(LinearGradientColorTable linearGradientColorTable_0)
	{
		if (linearGradientColorTable_0 == null)
		{
			color_0 = Color.Empty;
			color_1 = Color.Empty;
			int_0 = 90;
		}
		else
		{
			color_0 = linearGradientColorTable_0.Start;
			color_1 = linearGradientColorTable_0.End;
			int_0 = linearGradientColorTable_0.GradientAngle;
		}
	}

	public Brush method_1(Rectangle rectangle_0)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		if (rectangle_0.Width > 0 && rectangle_0.Height > 0)
		{
			if (backgroundColorBlendCollection_0 != null && backgroundColorBlendCollection_0.Count > 0)
			{
				return Class50.smethod_46(rectangle_0, backgroundColorBlendCollection_0, int_0, eGradientType_0);
			}
			if (color_1.IsEmpty && !color_0.IsEmpty)
			{
				return (Brush)new SolidBrush(color_0);
			}
			if (!color_1.IsEmpty && !color_0.IsEmpty)
			{
				if (eGradientType_0 == eGradientType.Linear)
				{
					return (Brush)new LinearGradientBrush(rectangle_0, color_0, color_1, (float)int_0);
				}
				int num = (int)Math.Sqrt(rectangle_0.Width * rectangle_0.Width + rectangle_0.Height * rectangle_0.Height) + 4;
				GraphicsPath val = new GraphicsPath();
				val.AddEllipse(rectangle_0.X - (num - rectangle_0.Width) / 2, rectangle_0.Y - (num - rectangle_0.Height) / 2, num, num);
				PathGradientBrush val2 = new PathGradientBrush(val);
				val2.set_CenterColor(color_0);
				val2.set_SurroundColors(new Color[1] { color_1 });
				return (Brush)(object)val2;
			}
			return null;
		}
		return null;
	}
}
