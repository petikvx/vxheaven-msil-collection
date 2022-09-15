using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar;

public class ShadowPainter
{
	private static GraphicsPath smethod_0(Rectangle rectangle_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		val.AddLine(rectangle_0.Left + 1, rectangle_0.Y, rectangle_0.Right - 1, rectangle_0.Y);
		val.AddLine(rectangle_0.Right - 1, rectangle_0.Y, rectangle_0.Right - 1, rectangle_0.Y + 1);
		val.AddLine(rectangle_0.Right - 1, rectangle_0.Y + 1, rectangle_0.Right, rectangle_0.Y + 1);
		val.AddLine(rectangle_0.Right, rectangle_0.Y + 1, rectangle_0.Right, rectangle_0.Bottom - 1);
		val.AddLine(rectangle_0.Right, rectangle_0.Bottom - 1, rectangle_0.Right - 1, rectangle_0.Bottom - 1);
		val.AddLine(rectangle_0.Right - 1, rectangle_0.Bottom - 1, rectangle_0.Right - 1, rectangle_0.Bottom);
		val.AddLine(rectangle_0.Right - 1, rectangle_0.Bottom, rectangle_0.Left + 1, rectangle_0.Bottom);
		val.AddLine(rectangle_0.Left + 1, rectangle_0.Bottom, rectangle_0.Left + 1, rectangle_0.Bottom - 1);
		val.AddLine(rectangle_0.Left + 1, rectangle_0.Bottom - 1, rectangle_0.Left, rectangle_0.Bottom - 1);
		val.AddLine(rectangle_0.Left, rectangle_0.Bottom - 1, rectangle_0.Left, rectangle_0.Top + 1);
		return val;
	}

	public static void Paint(ShadowPaintInfo info)
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		Graphics graphics = info.Graphics;
		Region clip = graphics.get_Clip();
		if (info.ClipRectangle.IsEmpty)
		{
			graphics.SetClip(info.Rectangle, (CombineMode)4);
		}
		else
		{
			graphics.SetClip(info.ClipRectangle, (CombineMode)4);
		}
		Color[] array = new Color[5]
		{
			Color.FromArgb(14, Color.Black),
			Color.FromArgb(43, Color.Black),
			Color.FromArgb(84, Color.Black),
			Color.FromArgb(113, Color.Black),
			Color.FromArgb(128, Color.Black)
		};
		Rectangle rectangle = info.Rectangle;
		rectangle.Width--;
		rectangle.Height--;
		int num = info.Size / 2;
		rectangle.Offset(num, num);
		rectangle.Width += info.Size - num;
		rectangle.Height += info.Size - num;
		for (int i = 0; i < info.Size; i++)
		{
			Pen val = new Pen(array[i], 1f);
			try
			{
				GraphicsPath val2 = smethod_0(rectangle);
				try
				{
					graphics.DrawPath(val, val2);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				rectangle.Inflate(-1, -1);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		graphics.set_Clip(clip);
	}

	public static void Paint2(ShadowPaintInfo info)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		if (info.Size <= 2)
		{
			return;
		}
		Graphics graphics = info.Graphics;
		Color color = Color.FromArgb(128, Color.Black);
		Rectangle rectangle = info.Rectangle;
		rectangle.Offset(info.Size - 1, info.Size - 1);
		Bitmap val = new Bitmap(info.Size, info.Size);
		try
		{
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				GraphicsPath val3 = new GraphicsPath();
				try
				{
					val3.AddEllipse(0, 0, info.Size * 2, info.Size * 2);
					PathGradientBrush val4 = new PathGradientBrush(val3);
					try
					{
						val4.set_CenterColor(color);
						val4.set_SurroundColors(new Color[1] { Color.Transparent });
						val2.FillRectangle((Brush)(object)val4, new Rectangle(0, 0, info.Size, info.Size));
					}
					finally
					{
						((IDisposable)val4)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			graphics.DrawImage((Image)(object)val, rectangle.X, rectangle.Y);
			((Image)val).RotateFlip((RotateFlipType)1);
			graphics.DrawImage((Image)(object)val, rectangle.Right - info.Size, rectangle.Y);
			((Image)val).RotateFlip((RotateFlipType)1);
			graphics.DrawImage((Image)(object)val, rectangle.Right - info.Size, rectangle.Bottom - info.Size);
			((Image)val).RotateFlip((RotateFlipType)1);
			graphics.DrawImage((Image)(object)val, rectangle.X, rectangle.Bottom - info.Size);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		graphics.set_SmoothingMode((SmoothingMode)3);
		Rectangle rectangle2 = new Rectangle(rectangle.X + info.Size, rectangle.Y + 1, rectangle.Width - info.Size * 2, info.Size - 1);
		LinearGradientBrush val5 = Class50.smethod_0(rectangle2, Color.Transparent, color, 90f);
		try
		{
			graphics.FillRectangle((Brush)(object)val5, rectangle2);
		}
		finally
		{
			((IDisposable)val5)?.Dispose();
		}
		rectangle2.Offset(0, rectangle.Height - info.Size - 1);
		LinearGradientBrush val6 = Class50.smethod_0(rectangle2, color, Color.Transparent, 90f);
		try
		{
			graphics.FillRectangle((Brush)(object)val6, rectangle2);
		}
		finally
		{
			((IDisposable)val6)?.Dispose();
		}
		rectangle2 = new Rectangle(rectangle.X, rectangle.Y + info.Size, info.Size, rectangle.Height - info.Size * 2);
		LinearGradientBrush val7 = Class50.smethod_0(rectangle2, Color.Transparent, color, 0f);
		try
		{
			graphics.FillRectangle((Brush)(object)val7, rectangle2);
		}
		finally
		{
			((IDisposable)val7)?.Dispose();
		}
		rectangle2.Offset(rectangle.Width - info.Size - 1, 0);
		LinearGradientBrush val8 = Class50.smethod_0(rectangle2, color, Color.Transparent, 0f);
		try
		{
			graphics.FillRectangle((Brush)(object)val8, rectangle2);
		}
		finally
		{
			((IDisposable)val8)?.Dispose();
		}
		graphics.set_SmoothingMode(smoothingMode);
	}
}
