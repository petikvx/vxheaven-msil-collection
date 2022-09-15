using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class267 : Class266
{
	public override void PaintButtonMouseOver(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle r)
	{
		PaintButtonCheck(button, pa, image, r);
	}

	public override void PaintButtonBackground(ButtonItem button, ItemPaintArgs pa, Class271 image)
	{
		if (IsOnMenu(button, pa))
		{
			base.PaintButtonBackground(button, pa, image);
		}
		else
		{
			PaintButtonCheck(button, pa, image, button.DisplayRectangle);
		}
	}

	public override void PaintButtonCheck(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle r)
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		if (IsOnMenu(button, pa))
		{
			base.PaintButtonCheck(button, pa, image, r);
		}
		else
		{
			if (!button.IsMouseOver && !button.Checked)
			{
				return;
			}
			Color color = pa.Colors.BarBackground2;
			Color color2 = pa.Colors.BarBackground;
			Color barFloatingBorder = pa.Colors.BarFloatingBorder;
			int num = pa.Colors.BarBackgroundGradientAngle;
			if (button.IsMouseOver && !button.Checked)
			{
				color = pa.Colors.ItemHotBackground2;
				color2 = pa.Colors.ItemHotBackground;
				num = pa.Colors.ItemHotBackgroundGradientAngle;
			}
			else if (button.Checked)
			{
				color = Color.White;
				color2 = pa.Colors.BarBackground;
				num = pa.Colors.ItemPressedBackgroundGradientAngle;
			}
			ControlPaint.LightLight(color2);
			Color color3 = Color.FromArgb(100, ControlPaint.Dark(color));
			int num2 = 4;
			Graphics graphics = pa.Graphics;
			GraphicsPath val = method_2(r, 4);
			val.CloseAllFigures();
			LinearGradientBrush val2 = Class50.smethod_0(r, color, color2, num);
			try
			{
				val2.set_GammaCorrection(true);
				graphics.FillPath((Brush)(object)val2, val);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			val.Dispose();
			GraphicsPath val3 = (val = method_0(r, num2 - 1));
			try
			{
				Pen val4 = new Pen(color3, 1f);
				try
				{
					graphics.DrawPath(val4, val);
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
			GraphicsPath val5 = (val = method_1(r, num2 - 1));
			try
			{
				Pen val6 = new Pen(color3, 1f);
				try
				{
					graphics.DrawPath(val6, val);
				}
				finally
				{
					((IDisposable)val6)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
			GraphicsPath val7 = (val = method_2(r, num2));
			try
			{
				Pen val8 = new Pen(barFloatingBorder, 1f);
				try
				{
					graphics.DrawPath(val8, val);
				}
				finally
				{
					((IDisposable)val8)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val7)?.Dispose();
			}
		}
	}

	private GraphicsPath method_0(Rectangle rectangle_0, int int_0)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		rectangle_0.X++;
		rectangle_0.Y++;
		rectangle_0.Width -= 2;
		rectangle_0.Height--;
		GraphicsPath val = new GraphicsPath();
		val.AddLine(rectangle_0.X, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Y + int_0);
		Struct10 @struct = ElementStyleDisplay.smethod_10(rectangle_0, int_0, Enum14.const_0);
		val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
		val.AddLine(rectangle_0.X + int_0, rectangle_0.Y, rectangle_0.Right - int_0, rectangle_0.Y);
		return val;
	}

	private GraphicsPath method_1(Rectangle rectangle_0, int int_0)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		rectangle_0.X++;
		rectangle_0.Y++;
		rectangle_0.Width -= 3;
		rectangle_0.Height--;
		GraphicsPath val = new GraphicsPath();
		Struct10 @struct = ElementStyleDisplay.smethod_10(rectangle_0, int_0, Enum14.const_1);
		val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
		val.AddLine(rectangle_0.Right, rectangle_0.Y + int_0, rectangle_0.Right, rectangle_0.Bottom);
		return val;
	}

	private GraphicsPath method_2(Rectangle rectangle_0, int int_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		rectangle_0.Width--;
		GraphicsPath val = new GraphicsPath();
		val.AddLine(rectangle_0.X, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Y + int_0);
		Struct10 @struct = ElementStyleDisplay.smethod_10(rectangle_0, int_0, Enum14.const_0);
		val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
		val.AddLine(rectangle_0.X + int_0, rectangle_0.Y, rectangle_0.Right - int_0, rectangle_0.Y);
		@struct = ElementStyleDisplay.smethod_10(rectangle_0, int_0, Enum14.const_1);
		val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
		val.AddLine(rectangle_0.Right, rectangle_0.Y + int_0, rectangle_0.Right, rectangle_0.Bottom);
		return val;
	}

	public override void PaintButtonText(ButtonItem button, ItemPaintArgs pa, Color textColor, Class271 image)
	{
		base.PaintButtonText(button, pa, textColor, image);
	}
}
