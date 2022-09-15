using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar;

internal class Class32
{
	public static void smethod_0(Graphics graphics_0, Rectangle rectangle_0, Color color_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		bool flag = false;
		if ((int)graphics_0.get_SmoothingMode() == 4)
		{
			flag = true;
			graphics_0.set_SmoothingMode((SmoothingMode)0);
		}
		Pen val = new Pen(color_0, 1f);
		try
		{
			graphics_0.DrawRectangle(val, rectangle_0);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		if (flag)
		{
			graphics_0.set_SmoothingMode((SmoothingMode)4);
		}
	}
}
