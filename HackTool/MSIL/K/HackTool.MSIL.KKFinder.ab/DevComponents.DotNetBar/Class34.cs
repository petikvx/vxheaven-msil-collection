using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace DevComponents.DotNetBar;

internal class Class34
{
	private Class34()
	{
	}

	public static GraphicsPath smethod_0(Point point_0, int int_0, Enum8 enum8_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		switch (enum8_0)
		{
		case Enum8.const_0:
			point_0.X--;
			val.AddLine(point_0.X + int_0 / 2, point_0.Y, point_0.X + int_0 / 2, point_0.Y + int_0);
			val.AddLine(point_0.X, point_0.Y + int_0 / 2, point_0.X + int_0 / 2, point_0.Y);
			val.CloseAllFigures();
			break;
		case Enum8.const_1:
			val.AddLine(point_0.X, point_0.Y, point_0.X, point_0.Y + int_0);
			val.AddLine(point_0.X + int_0 / 2, point_0.Y + int_0 / 2, point_0.X, point_0.Y);
			val.CloseAllFigures();
			break;
		case Enum8.const_2:
			val.AddLine(point_0.X, point_0.Y + int_0 / 2, point_0.X + int_0, point_0.Y + int_0 / 2);
			val.AddLine(point_0.X + int_0 / 2, point_0.Y, point_0.X, point_0.Y + int_0 / 2);
			val.CloseAllFigures();
			break;
		case Enum8.const_3:
			val.AddLine(point_0.X, point_0.Y, point_0.X + int_0, point_0.Y);
			val.AddLine(point_0.X + int_0 / 2, point_0.Y + int_0 / 2, point_0.X, point_0.Y);
			val.CloseAllFigures();
			break;
		}
		return val;
	}

	public static Image smethod_1(bool bool_0, Color color_0, bool bool_1)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		Bitmap val = new Bitmap(16, 16, (PixelFormat)137224);
		val.MakeTransparent();
		Image val2 = (Image)(object)val;
		Graphics val3 = Graphics.FromImage(val2);
		val3.set_SmoothingMode((SmoothingMode)4);
		if (bool_0)
		{
			if (bool_1)
			{
				Pen val4 = new Pen(color_0, 1f);
				try
				{
					val3.DrawLine(val4, 4, 7, 7, 4);
					val3.DrawLine(val4, 7, 4, 10, 7);
					val3.DrawLine(val4, 5, 7, 7, 5);
					val3.DrawLine(val4, 7, 5, 9, 7);
					val3.DrawLine(val4, 4, 10, 7, 7);
					val3.DrawLine(val4, 7, 7, 10, 10);
					val3.DrawLine(val4, 5, 10, 7, 8);
					val3.DrawLine(val4, 7, 8, 9, 10);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
			else
			{
				Pen val5 = new Pen(color_0, 1f);
				try
				{
					val3.DrawLine(val5, 7, 4, 4, 7);
					val3.DrawLine(val5, 4, 7, 7, 10);
					val3.DrawLine(val5, 7, 5, 5, 7);
					val3.DrawLine(val5, 5, 7, 7, 9);
					val3.DrawLine(val5, 10, 4, 7, 7);
					val3.DrawLine(val5, 7, 7, 10, 10);
					val3.DrawLine(val5, 10, 5, 8, 7);
					val3.DrawLine(val5, 8, 7, 10, 9);
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
			}
		}
		else if (bool_1)
		{
			Pen val6 = new Pen(color_0, 1f);
			try
			{
				val3.DrawLine(val6, 4, 4, 7, 7);
				val3.DrawLine(val6, 7, 7, 10, 4);
				val3.DrawLine(val6, 5, 4, 7, 6);
				val3.DrawLine(val6, 7, 6, 9, 4);
				val3.DrawLine(val6, 4, 7, 7, 10);
				val3.DrawLine(val6, 7, 10, 10, 7);
				val3.DrawLine(val6, 5, 7, 7, 9);
				val3.DrawLine(val6, 7, 9, 9, 7);
			}
			finally
			{
				((IDisposable)val6)?.Dispose();
			}
		}
		else
		{
			Pen val7 = new Pen(color_0, 1f);
			try
			{
				val3.DrawLine(val7, 4, 4, 7, 7);
				val3.DrawLine(val7, 7, 7, 4, 10);
				val3.DrawLine(val7, 4, 5, 6, 7);
				val3.DrawLine(val7, 6, 7, 4, 9);
				val3.DrawLine(val7, 7, 4, 10, 7);
				val3.DrawLine(val7, 10, 7, 7, 10);
				val3.DrawLine(val7, 7, 5, 9, 7);
				val3.DrawLine(val7, 9, 7, 7, 9);
			}
			finally
			{
				((IDisposable)val7)?.Dispose();
			}
		}
		val3.Dispose();
		return val2;
	}
}
