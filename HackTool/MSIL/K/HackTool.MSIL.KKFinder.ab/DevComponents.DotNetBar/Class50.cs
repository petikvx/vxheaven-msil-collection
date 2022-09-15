using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class50
{
	private static TextRenderingHint textRenderingHint_0 = (TextRenderingHint)5;

	public static ControlStyles ControlStyles_0 => (ControlStyles)131072;

	public static TextRenderingHint TextRenderingHint_0
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return textRenderingHint_0;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			textRenderingHint_0 = value;
		}
	}

	private Class50()
	{
	}

	public static LinearGradientBrush smethod_0(Rectangle rectangle_0, Color color_0, Color color_1, float float_0)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		if (rectangle_0.Width <= 0)
		{
			rectangle_0.Width = 1;
		}
		if (rectangle_0.Height <= 0)
		{
			rectangle_0.Height = 1;
		}
		return new LinearGradientBrush(new Rectangle(rectangle_0.X, rectangle_0.Y - 1, rectangle_0.Width, rectangle_0.Height + 1), color_0, color_1, float_0);
	}

	public static LinearGradientBrush smethod_1(RectangleF rectangleF_0, Color color_0, Color color_1, float float_0)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		if (rectangleF_0.Width <= 0f)
		{
			rectangleF_0.Width = 1f;
		}
		if (rectangleF_0.Height <= 0f)
		{
			rectangleF_0.Height = 1f;
		}
		return new LinearGradientBrush(new RectangleF(rectangleF_0.X, rectangleF_0.Y - 1f, rectangleF_0.Width, rectangleF_0.Height + 1f), color_0, color_1, float_0);
	}

	public static LinearGradientBrush smethod_2(Rectangle rectangle_0, Color color_0, Color color_1, float float_0, bool bool_0)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		if (rectangle_0.Width <= 0)
		{
			rectangle_0.Width = 1;
		}
		if (rectangle_0.Height <= 0)
		{
			rectangle_0.Height = 1;
		}
		return new LinearGradientBrush(new Rectangle(rectangle_0.X, rectangle_0.Y - 1, rectangle_0.Width, rectangle_0.Height + 1), color_0, color_1, float_0, bool_0);
	}

	public static Rectangle smethod_3(Rectangle rectangle_0)
	{
		rectangle_0.Width--;
		rectangle_0.Height--;
		return rectangle_0;
	}

	public static Rectangle smethod_4(Rectangle rectangle_0)
	{
		return rectangle_0;
	}

	public static void smethod_5(Graphics graphics_0, Color color_0, int int_0, int int_1, int int_2, int int_3)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		Pen val = new Pen(color_0, 1f);
		try
		{
			smethod_7(graphics_0, val, int_0, int_1, int_2, int_3);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static void smethod_6(Graphics graphics_0, Color color_0, Rectangle rectangle_0)
	{
		smethod_5(graphics_0, color_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height);
	}

	public static void smethod_7(Graphics graphics_0, Pen pen_0, int int_0, int int_1, int int_2, int int_3)
	{
		int_2--;
		int_3--;
		graphics_0.DrawRectangle(pen_0, int_0, int_1, int_2, int_3);
	}

	public static void smethod_8(Graphics graphics_0, Pen pen_0, Rectangle rectangle_0)
	{
		smethod_7(graphics_0, pen_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height);
	}

	public static void smethod_9(Graphics graphics_0, Color color_0, Rectangle rectangle_0, int int_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		if (!color_0.IsEmpty)
		{
			Pen val = new Pen(color_0);
			try
			{
				smethod_12(graphics_0, val, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height, int_0);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	public static void smethod_10(Graphics graphics_0, Color color_0, int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		if (!color_0.IsEmpty)
		{
			Pen val = new Pen(color_0);
			try
			{
				smethod_12(graphics_0, val, int_0, int_1, int_2, int_3, int_4);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	public static void smethod_11(Graphics graphics_0, Pen pen_0, Rectangle rectangle_0, int int_0)
	{
		smethod_12(graphics_0, pen_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height, int_0);
	}

	public static void smethod_12(Graphics graphics_0, Pen pen_0, int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		int_2--;
		int_3--;
		Rectangle rectangle_ = new Rectangle(int_0, int_1, int_2, int_3);
		GraphicsPath val = smethod_13(rectangle_, int_4);
		try
		{
			graphics_0.DrawPath(pen_0, val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static GraphicsPath smethod_13(Rectangle rectangle_0, int int_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		if (int_0 == 0)
		{
			val.AddRectangle(rectangle_0);
		}
		else
		{
			ElementStyleDisplay.smethod_9(val, rectangle_0, int_0, Enum14.const_0);
			ElementStyleDisplay.smethod_9(val, rectangle_0, int_0, Enum14.const_1);
			ElementStyleDisplay.smethod_9(val, rectangle_0, int_0, Enum14.const_3);
			ElementStyleDisplay.smethod_9(val, rectangle_0, int_0, Enum14.const_2);
			val.CloseAllFigures();
		}
		return val;
	}

	public static GraphicsPath smethod_14(Rectangle rectangle_0, int int_0, int int_1, int int_2, int int_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		ElementStyleDisplay.smethod_9(val, rectangle_0, int_0, Enum14.const_0);
		ElementStyleDisplay.smethod_9(val, rectangle_0, int_1, Enum14.const_1);
		ElementStyleDisplay.smethod_9(val, rectangle_0, int_2, Enum14.const_3);
		ElementStyleDisplay.smethod_9(val, rectangle_0, int_3, Enum14.const_2);
		val.CloseAllFigures();
		return val;
	}

	public static GraphicsPath smethod_15(Rectangle rectangle_0, int int_0, eStyleBackgroundPathPart eStyleBackgroundPathPart_0, eCornerType eCornerType_0, eCornerType eCornerType_1, eCornerType eCornerType_2, eCornerType eCornerType_3)
	{
		return smethod_16(rectangle_0, int_0, eStyleBackgroundPathPart_0, eCornerType_0, eCornerType_1, eCornerType_2, eCornerType_3, 0f);
	}

	public static GraphicsPath smethod_16(Rectangle rectangle_0, int int_0, eStyleBackgroundPathPart eStyleBackgroundPathPart_0, eCornerType eCornerType_0, eCornerType eCornerType_1, eCornerType eCornerType_2, eCornerType eCornerType_3, float float_0)
	{
		return smethod_17(rectangle_0, int_0, int_0, int_0, int_0, eStyleBackgroundPathPart_0, eCornerType_0, eCornerType_1, eCornerType_2, eCornerType_3, float_0);
	}

	public static GraphicsPath smethod_17(Rectangle rectangle_0, int int_0, int int_1, int int_2, int int_3, eStyleBackgroundPathPart eStyleBackgroundPathPart_0, eCornerType eCornerType_0, eCornerType eCornerType_1, eCornerType eCornerType_2, eCornerType eCornerType_3, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		switch (eStyleBackgroundPathPart_0)
		{
		case eStyleBackgroundPathPart.TopHalf:
			if (float_0 == 0f)
			{
				rectangle_0.Height /= 2;
			}
			else
			{
				rectangle_0.Height = (int)((float)rectangle_0.Height * float_0);
			}
			break;
		case eStyleBackgroundPathPart.BottomHalf:
		{
			int height = rectangle_0.Height;
			if (float_0 == 0f)
			{
				rectangle_0.Height /= 2;
			}
			else
			{
				rectangle_0.Height = (int)((float)rectangle_0.Height * float_0);
			}
			rectangle_0.Y += height - rectangle_0.Height - 1;
			break;
		}
		}
		eCornerType eCornerType2 = eCornerType_0;
		if (eCornerType2 == eCornerType.Inherit)
		{
			eCornerType2 = eCornerType.Square;
		}
		if (eStyleBackgroundPathPart_0 == eStyleBackgroundPathPart.BottomHalf)
		{
			eCornerType2 = eCornerType.Square;
		}
		switch (eCornerType2)
		{
		case eCornerType.Rounded:
		{
			Struct10 @struct = ElementStyleDisplay.smethod_10(rectangle_0, int_0, Enum14.const_0);
			val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
			break;
		}
		case eCornerType.Diagonal:
			val.AddLine(rectangle_0.X, rectangle_0.Y + int_0, rectangle_0.X + int_0, rectangle_0.Y);
			break;
		default:
			val.AddLine(rectangle_0.X, rectangle_0.Y + 2, rectangle_0.X, rectangle_0.Y);
			val.AddLine(rectangle_0.X, rectangle_0.Y, rectangle_0.X + 2, rectangle_0.Y);
			break;
		}
		eCornerType2 = eCornerType_1;
		if (eCornerType2 == eCornerType.Inherit)
		{
			eCornerType2 = eCornerType.Square;
		}
		if (eStyleBackgroundPathPart_0 == eStyleBackgroundPathPart.BottomHalf)
		{
			eCornerType2 = eCornerType.Square;
		}
		switch (eCornerType2)
		{
		case eCornerType.Rounded:
		{
			Struct10 struct2 = ElementStyleDisplay.smethod_10(rectangle_0, int_1, Enum14.const_1);
			val.AddArc(struct2.int_0, struct2.int_1, struct2.int_2, struct2.int_3, struct2.float_0, struct2.float_1);
			break;
		}
		case eCornerType.Diagonal:
			val.AddLine(rectangle_0.Right - int_1 - 1, rectangle_0.Y, rectangle_0.Right, rectangle_0.Y + int_1);
			break;
		default:
			val.AddLine(rectangle_0.Right - 2, rectangle_0.Y, rectangle_0.Right, rectangle_0.Y);
			val.AddLine(rectangle_0.Right, rectangle_0.Y, rectangle_0.Right, rectangle_0.Y + 2);
			break;
		}
		eCornerType2 = eCornerType_3;
		if (eCornerType2 == eCornerType.Inherit)
		{
			eCornerType2 = eCornerType.Square;
		}
		if (eStyleBackgroundPathPart_0 == eStyleBackgroundPathPart.TopHalf)
		{
			eCornerType2 = eCornerType.Square;
		}
		switch (eCornerType2)
		{
		case eCornerType.Rounded:
		{
			Struct10 struct3 = ElementStyleDisplay.smethod_10(rectangle_0, int_3, Enum14.const_3);
			val.AddArc(struct3.int_0, struct3.int_1, struct3.int_2, struct3.int_3, struct3.float_0, struct3.float_1);
			break;
		}
		case eCornerType.Diagonal:
			val.AddLine(rectangle_0.Right, rectangle_0.Bottom - int_3 - 1, rectangle_0.Right - int_3 - 1, rectangle_0.Bottom);
			break;
		default:
			val.AddLine(rectangle_0.Right, rectangle_0.Bottom - 2, rectangle_0.Right, rectangle_0.Bottom);
			val.AddLine(rectangle_0.Right, rectangle_0.Bottom, rectangle_0.Right - 2, rectangle_0.Bottom);
			break;
		}
		eCornerType2 = eCornerType_2;
		if (eCornerType2 == eCornerType.Inherit)
		{
			eCornerType2 = eCornerType.Square;
		}
		if (eStyleBackgroundPathPart_0 == eStyleBackgroundPathPart.TopHalf)
		{
			eCornerType2 = eCornerType.Square;
		}
		switch (eCornerType2)
		{
		case eCornerType.Rounded:
		{
			Struct10 struct4 = ElementStyleDisplay.smethod_10(rectangle_0, int_2, Enum14.const_2);
			val.AddArc(struct4.int_0, struct4.int_1, struct4.int_2, struct4.int_3, struct4.float_0, struct4.float_1);
			break;
		}
		case eCornerType.Diagonal:
			val.AddLine(rectangle_0.X + 2, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Bottom - int_2 - 1);
			break;
		default:
			val.AddLine(rectangle_0.X + 2, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Bottom);
			val.AddLine(rectangle_0.X, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Bottom - 2);
			break;
		}
		val.CloseAllFigures();
		return val;
	}

	public static GraphicsPath smethod_18(Rectangle rectangle_0, int int_0, eStyleBackgroundPathPart eStyleBackgroundPathPart_0, eCornerType eCornerType_0, eCornerType eCornerType_1, eCornerType eCornerType_2, eCornerType eCornerType_3, bool bool_0, bool bool_1, bool bool_2, bool bool_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		switch (eStyleBackgroundPathPart_0)
		{
		case eStyleBackgroundPathPart.TopHalf:
			rectangle_0.Height /= 2;
			break;
		case eStyleBackgroundPathPart.BottomHalf:
		{
			int height = rectangle_0.Height;
			rectangle_0.Height /= 2;
			rectangle_0.Y += height - rectangle_0.Height - 1;
			break;
		}
		}
		eCornerType eCornerType2 = eCornerType_0;
		if (eCornerType2 == eCornerType.Inherit)
		{
			eCornerType2 = eCornerType.Square;
		}
		if (eStyleBackgroundPathPart_0 == eStyleBackgroundPathPart.BottomHalf)
		{
			eCornerType2 = eCornerType.Square;
		}
		if (bool_0)
		{
			val.AddLine(rectangle_0.X, rectangle_0.Bottom - ((bool_3 && (eCornerType_2 == eCornerType.Diagonal || eCornerType_2 == eCornerType.Rounded)) ? int_0 : 0), rectangle_0.X, rectangle_0.Y + ((bool_2 && (eCornerType_0 == eCornerType.Diagonal || eCornerType_0 == eCornerType.Rounded)) ? int_0 : 0));
		}
		if (bool_0 && bool_2)
		{
			switch (eCornerType2)
			{
			case eCornerType.Rounded:
			{
				Struct10 @struct = ElementStyleDisplay.smethod_10(rectangle_0, int_0, Enum14.const_0);
				val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
				break;
			}
			case eCornerType.Diagonal:
				val.AddLine(rectangle_0.X, rectangle_0.Y + int_0, rectangle_0.X + int_0, rectangle_0.Y);
				break;
			}
		}
		if (bool_2)
		{
			val.AddLine(rectangle_0.X + ((eCornerType_0 == eCornerType.Diagonal || eCornerType_0 == eCornerType.Rounded) ? int_0 : 0), rectangle_0.Y, rectangle_0.Right - ((bool_1 && (eCornerType_1 == eCornerType.Diagonal || eCornerType_1 == eCornerType.Rounded)) ? int_0 : 0), rectangle_0.Y);
		}
		eCornerType2 = eCornerType_1;
		if (eCornerType2 == eCornerType.Inherit)
		{
			eCornerType2 = eCornerType.Square;
		}
		if (eStyleBackgroundPathPart_0 == eStyleBackgroundPathPart.BottomHalf)
		{
			eCornerType2 = eCornerType.Square;
		}
		if (bool_2 && bool_1)
		{
			switch (eCornerType2)
			{
			case eCornerType.Rounded:
			{
				Struct10 struct2 = ElementStyleDisplay.smethod_10(rectangle_0, int_0, Enum14.const_1);
				val.AddArc(struct2.int_0, struct2.int_1, struct2.int_2, struct2.int_3, struct2.float_0, struct2.float_1);
				break;
			}
			case eCornerType.Diagonal:
				val.AddLine(rectangle_0.Right - int_0 - 1, rectangle_0.Y, rectangle_0.Right, rectangle_0.Y + int_0);
				break;
			}
		}
		if (bool_1)
		{
			val.AddLine(rectangle_0.Right, rectangle_0.Y + ((eCornerType_1 == eCornerType.Diagonal || eCornerType_1 == eCornerType.Rounded) ? int_0 : 0), rectangle_0.Right, rectangle_0.Bottom - ((bool_3 && (eCornerType_3 == eCornerType.Diagonal || eCornerType_3 == eCornerType.Rounded)) ? int_0 : 0));
		}
		eCornerType2 = eCornerType_3;
		if (eCornerType2 == eCornerType.Inherit)
		{
			eCornerType2 = eCornerType.Square;
		}
		if (eStyleBackgroundPathPart_0 == eStyleBackgroundPathPart.TopHalf)
		{
			eCornerType2 = eCornerType.Square;
		}
		switch (eCornerType2)
		{
		case eCornerType.Rounded:
		{
			Struct10 struct3 = ElementStyleDisplay.smethod_10(rectangle_0, int_0, Enum14.const_3);
			val.AddArc(struct3.int_0, struct3.int_1, struct3.int_2, struct3.int_3, struct3.float_0, struct3.float_1);
			break;
		}
		case eCornerType.Diagonal:
			val.AddLine(rectangle_0.Right, rectangle_0.Bottom - int_0 - 1, rectangle_0.Right - int_0 - 1, rectangle_0.Bottom);
			break;
		}
		if (bool_3)
		{
			val.AddLine(rectangle_0.Right - ((eCornerType_3 == eCornerType.Diagonal || eCornerType_3 == eCornerType.Rounded) ? int_0 : 0), rectangle_0.Bottom, rectangle_0.X + ((eCornerType_2 == eCornerType.Diagonal || eCornerType_2 == eCornerType.Rounded) ? int_0 : 0), rectangle_0.Bottom);
		}
		eCornerType2 = eCornerType_2;
		if (eCornerType2 == eCornerType.Inherit)
		{
			eCornerType2 = eCornerType.Square;
		}
		if (eStyleBackgroundPathPart_0 == eStyleBackgroundPathPart.TopHalf)
		{
			eCornerType2 = eCornerType.Square;
		}
		switch (eCornerType2)
		{
		case eCornerType.Rounded:
		{
			Struct10 struct4 = ElementStyleDisplay.smethod_10(rectangle_0, int_0, Enum14.const_2);
			val.AddArc(struct4.int_0, struct4.int_1, struct4.int_2, struct4.int_3, struct4.float_0, struct4.float_1);
			break;
		}
		case eCornerType.Diagonal:
			val.AddLine(rectangle_0.X + 2, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Bottom - int_0 - 1);
			break;
		}
		return val;
	}

	public static void smethod_19(Graphics graphics_0, Rectangle rectangle_0, int int_0, Color color_0, Color color_1, int int_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (color_1.IsEmpty)
		{
			if (!color_0.IsEmpty)
			{
				SolidBrush val = new SolidBrush(color_0);
				try
				{
					smethod_22(graphics_0, (Brush)(object)val, rectangle_0, int_0);
					return;
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			return;
		}
		LinearGradientBrush val2 = smethod_0(rectangle_0, color_0, color_1, int_1);
		try
		{
			smethod_22(graphics_0, (Brush)(object)val2, rectangle_0, int_0);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public static void smethod_20(Graphics graphics_0, Rectangle rectangle_0, int int_0, Color color_0, Color color_1)
	{
		smethod_19(graphics_0, rectangle_0, int_0, color_0, color_1, 90);
	}

	public static void smethod_21(Graphics graphics_0, Rectangle rectangle_0, int int_0, Color color_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SolidBrush val = new SolidBrush(color_0);
		try
		{
			smethod_22(graphics_0, (Brush)(object)val, rectangle_0, int_0);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static void smethod_22(Graphics graphics_0, Brush brush_0, Rectangle rectangle_0, int int_0)
	{
		rectangle_0.Width--;
		rectangle_0.Height--;
		GraphicsPath val = smethod_13(rectangle_0, int_0);
		try
		{
			graphics_0.FillPath(brush_0, val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static void smethod_23(Graphics graphics_0, Rectangle rectangle_0, Color color_0)
	{
		smethod_26(graphics_0, rectangle_0, color_0, Color.Empty, 90);
	}

	public static void smethod_24(Graphics graphics_0, Rectangle rectangle_0, Color color_0, Color color_1)
	{
		smethod_26(graphics_0, rectangle_0, color_0, color_1, 90);
	}

	public static void smethod_25(Graphics graphics_0, Rectangle rectangle_0, LinearGradientColorTable linearGradientColorTable_0)
	{
		smethod_26(graphics_0, rectangle_0, linearGradientColorTable_0.Start, linearGradientColorTable_0.End, linearGradientColorTable_0.GradientAngle);
	}

	public static void smethod_26(Graphics graphics_0, Rectangle rectangle_0, Color color_0, Color color_1, int int_0)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		if (rectangle_0.Width == 0 || rectangle_0.Height == 0)
		{
			return;
		}
		if (color_1.IsEmpty)
		{
			if (!color_0.IsEmpty)
			{
				SolidBrush val = new SolidBrush(color_0);
				try
				{
					graphics_0.FillRectangle((Brush)(object)val, rectangle_0);
					return;
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			return;
		}
		LinearGradientBrush val2 = smethod_0(rectangle_0, color_0, color_1, int_0);
		try
		{
			graphics_0.FillRectangle((Brush)(object)val2, rectangle_0);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public static void smethod_27(Graphics graphics_0, Rectangle rectangle_0, Color color_0, Color color_1, int int_0, float[] float_0, float[] float_1)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		if (rectangle_0.Width == 0 || rectangle_0.Height == 0)
		{
			return;
		}
		if (color_1.IsEmpty)
		{
			if (!color_0.IsEmpty)
			{
				SolidBrush val = new SolidBrush(color_0);
				try
				{
					graphics_0.FillRectangle((Brush)(object)val, rectangle_0);
					return;
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			return;
		}
		LinearGradientBrush val2 = smethod_0(rectangle_0, color_0, color_1, int_0);
		try
		{
			Blend val3 = new Blend(float_0.Length);
			val3.set_Factors(float_0);
			val3.set_Positions(float_1);
			val2.set_Blend(val3);
			graphics_0.FillRectangle((Brush)(object)val2, rectangle_0);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public static void smethod_28(Graphics graphics_0, GraphicsPath graphicsPath_0, Color color_0, Color color_1)
	{
		smethod_30(graphics_0, graphicsPath_0, color_0, color_1, 90);
	}

	public static void smethod_29(Graphics graphics_0, GraphicsPath graphicsPath_0, LinearGradientColorTable linearGradientColorTable_0)
	{
		smethod_30(graphics_0, graphicsPath_0, linearGradientColorTable_0.Start, linearGradientColorTable_0.End, linearGradientColorTable_0.GradientAngle);
	}

	public static void smethod_30(Graphics graphics_0, GraphicsPath graphicsPath_0, Color color_0, Color color_1, int int_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (color_1.IsEmpty)
		{
			if (!color_0.IsEmpty)
			{
				SolidBrush val = new SolidBrush(color_0);
				try
				{
					graphics_0.FillPath((Brush)(object)val, graphicsPath_0);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
		}
		else if (!color_0.IsEmpty)
		{
			LinearGradientBrush val2 = smethod_1(graphicsPath_0.GetBounds(), color_0, color_1, int_0);
			try
			{
				graphics_0.FillPath((Brush)(object)val2, graphicsPath_0);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
	}

	public static void smethod_31(Graphics graphics_0, Point point_0, Point point_1, Color color_0, int int_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (!color_0.IsEmpty)
		{
			Pen val = new Pen(color_0, (float)int_0);
			try
			{
				graphics_0.DrawLine(val, point_0, point_1);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	public static void smethod_32(Graphics graphics_0, int int_0, int int_1, int int_2, int int_3, Color color_0, int int_4)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		if (!color_0.IsEmpty)
		{
			Pen val = new Pen(color_0, (float)int_4);
			try
			{
				graphics_0.DrawLine(val, int_0, int_1, int_2, int_3);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	public static void smethod_33(Graphics graphics_0, Rectangle rectangle_0, LinearGradientColorTable linearGradientColorTable_0, int int_0)
	{
		smethod_34(graphics_0, rectangle_0, linearGradientColorTable_0.Start, linearGradientColorTable_0.End, linearGradientColorTable_0.GradientAngle, int_0);
	}

	public static void smethod_34(Graphics graphics_0, Rectangle rectangle_0, Color color_0, Color color_1, int int_0, int int_1)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (!color_0.IsEmpty && rectangle_0.Width > 0 && rectangle_0.Height > 0 && int_1 > 0)
		{
			Rectangle rectangle = rectangle_0;
			rectangle.Width--;
			rectangle.Height--;
			GraphicsPath val = new GraphicsPath();
			try
			{
				val.AddRectangle(rectangle);
				smethod_36(graphics_0, val, rectangle, color_0, color_1, int_0, int_1);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	public static void smethod_35(Graphics graphics_0, GraphicsPath graphicsPath_0, Rectangle rectangle_0, LinearGradientColorTable linearGradientColorTable_0, int int_0)
	{
		smethod_36(graphics_0, graphicsPath_0, rectangle_0, linearGradientColorTable_0.Start, linearGradientColorTable_0.End, linearGradientColorTable_0.GradientAngle, int_0);
	}

	public static void smethod_36(Graphics graphics_0, GraphicsPath graphicsPath_0, Rectangle rectangle_0, Color color_0, Color color_1, int int_0, int int_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		Pen val = new Pen(color_0, (float)int_1);
		try
		{
			graphicsPath_0.Widen(val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		if (color_1.IsEmpty)
		{
			if (!color_0.IsEmpty)
			{
				SolidBrush val2 = new SolidBrush(color_0);
				try
				{
					graphics_0.FillPath((Brush)(object)val2, graphicsPath_0);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
		}
		else if (!color_0.IsEmpty)
		{
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle_0, color_0, color_1, (float)int_0);
			try
			{
				graphics_0.FillPath((Brush)(object)val3, graphicsPath_0);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
	}

	public static void smethod_37(Graphics graphics_0, Rectangle rectangle_0, LinearGradientColorTable linearGradientColorTable_0, int int_0, int int_1)
	{
		smethod_38(graphics_0, rectangle_0, linearGradientColorTable_0.Start, linearGradientColorTable_0.End, linearGradientColorTable_0.GradientAngle, int_0, int_1);
	}

	public static void smethod_38(Graphics graphics_0, Rectangle rectangle_0, Color color_0, Color color_1, int int_0, int int_1, int int_2)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		if ((color_0.IsEmpty && color_1.IsEmpty) || rectangle_0.Width <= 0 || rectangle_0.Height <= 0 || int_2 <= 0 || int_1 <= 0)
		{
			return;
		}
		if (color_1.IsEmpty)
		{
			Pen val = new Pen(color_0, (float)int_1);
			try
			{
				smethod_11(graphics_0, val, rectangle_0, int_2);
				return;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		Rectangle rectangle_ = rectangle_0;
		rectangle_.Width--;
		rectangle_.Height--;
		GraphicsPath val2 = smethod_13(rectangle_, int_2);
		try
		{
			Pen val3 = new Pen(color_0, (float)int_1);
			try
			{
				val2.Widen(val3);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			LinearGradientBrush val4 = new LinearGradientBrush(rectangle_0, color_0, color_1, (float)int_0);
			try
			{
				graphics_0.FillPath((Brush)(object)val4, val2);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public static void smethod_39(Graphics graphics_0, GraphicsPath graphicsPath_0, LinearGradientColorTable linearGradientColorTable_0, int int_0)
	{
		smethod_40(graphics_0, graphicsPath_0, linearGradientColorTable_0.Start, linearGradientColorTable_0.End, linearGradientColorTable_0.GradientAngle, int_0);
	}

	public static void smethod_40(Graphics graphics_0, GraphicsPath graphicsPath_0, Color color_0, Color color_1, int int_0, int int_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		Pen val = new Pen(color_0, (float)int_1);
		try
		{
			graphicsPath_0.Widen(val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		Rectangle rectangle = Rectangle.Ceiling(graphicsPath_0.GetBounds());
		rectangle.Inflate(1, 1);
		if (color_1.IsEmpty)
		{
			if (!color_0.IsEmpty)
			{
				SolidBrush val2 = new SolidBrush(color_0);
				try
				{
					graphics_0.FillPath((Brush)(object)val2, graphicsPath_0);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
		}
		else if (!color_0.IsEmpty)
		{
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle, color_0, color_1, (float)int_0);
			try
			{
				graphics_0.FillPath((Brush)(object)val3, graphicsPath_0);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
	}

	public static void smethod_41(Graphics graphics_0, Point point_0, Point point_1, LinearGradientColorTable linearGradientColorTable_0, int int_0)
	{
		smethod_43(graphics_0, point_0, point_1, linearGradientColorTable_0.Start, linearGradientColorTable_0.End, linearGradientColorTable_0.GradientAngle, int_0);
	}

	public static void smethod_42(Graphics graphics_0, int int_0, int int_1, int int_2, int int_3, LinearGradientColorTable linearGradientColorTable_0, int int_4)
	{
		smethod_43(graphics_0, new Point(int_0, int_1), new Point(int_2, int_3), linearGradientColorTable_0.Start, linearGradientColorTable_0.End, linearGradientColorTable_0.GradientAngle, int_4);
	}

	public static void smethod_43(Graphics graphics_0, Point point_0, Point point_1, Color color_0, Color color_1, int int_0, int int_1)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		if (color_1.IsEmpty)
		{
			if (!color_0.IsEmpty)
			{
				Pen val = new Pen(color_0, (float)int_1);
				try
				{
					graphics_0.DrawLine(val, point_0, point_1);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
		}
		else
		{
			if (color_0.IsEmpty)
			{
				return;
			}
			GraphicsPath val2 = new GraphicsPath();
			try
			{
				point_0.Offset(-1, -1);
				point_1.Offset(-1, -1);
				val2.AddLine(point_0, point_1);
				Pen val3 = new Pen(color_0, (float)int_1);
				try
				{
					val2.Widen(val3);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
				Rectangle rectangle_ = Rectangle.Ceiling(val2.GetBounds());
				rectangle_.Inflate(1, 1);
				LinearGradientBrush val4 = smethod_0(rectangle_, color_0, color_1, int_0);
				try
				{
					graphics_0.FillPath((Brush)(object)val4, val2);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
	}

	public static void smethod_44(Graphics graphics_0, Point point_0, Point point_1, Color color_0, Color color_1, int int_0, int int_1, float[] float_0, float[] float_1)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		if (color_1.IsEmpty)
		{
			if (!color_0.IsEmpty)
			{
				Pen val = new Pen(color_0, (float)int_1);
				try
				{
					graphics_0.DrawLine(val, point_0, point_1);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
		}
		else
		{
			if (color_0.IsEmpty)
			{
				return;
			}
			GraphicsPath val2 = new GraphicsPath();
			try
			{
				point_0.Offset(-1, -1);
				point_1.Offset(-1, -1);
				val2.AddLine(point_0, point_1);
				Pen val3 = new Pen(color_0, (float)int_1);
				try
				{
					val2.Widen(val3);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
				Rectangle rectangle_ = Rectangle.Ceiling(val2.GetBounds());
				rectangle_.Inflate(1, 1);
				LinearGradientBrush val4 = smethod_0(rectangle_, color_0, color_1, int_0);
				try
				{
					Blend val5 = new Blend(float_0.Length);
					val5.set_Factors(float_0);
					val5.set_Positions(float_1);
					val4.set_Blend(val5);
					graphics_0.FillPath((Brush)(object)val4, val2);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
	}

	public static Brush smethod_45(Rectangle rectangle_0, GradientColorTable gradientColorTable_0)
	{
		return smethod_46(rectangle_0, gradientColorTable_0.Colors, gradientColorTable_0.LinearGradientAngle, gradientColorTable_0.GradientType);
	}

	public static Brush smethod_46(Rectangle rectangle_0, BackgroundColorBlendCollection backgroundColorBlendCollection_0, int int_0, eGradientType eGradientType_0)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		switch (backgroundColorBlendCollection_0.method_1())
		{
		case Enum11.const_0:
			return null;
		case Enum11.const_1:
			try
			{
				switch (eGradientType_0)
				{
				case eGradientType.Linear:
				{
					rectangle_0.Inflate(1, 1);
					LinearGradientBrush val3 = smethod_0(rectangle_0, backgroundColorBlendCollection_0[0].Color, backgroundColorBlendCollection_0[backgroundColorBlendCollection_0.Count - 1].Color, int_0);
					val3.set_InterpolationColors(backgroundColorBlendCollection_0.GetColorBlend());
					return (Brush)(object)val3;
				}
				case eGradientType.Radial:
				{
					int num = (int)Math.Sqrt(rectangle_0.Width * rectangle_0.Width + rectangle_0.Height * rectangle_0.Height) + 4;
					GraphicsPath val = new GraphicsPath();
					val.AddEllipse(rectangle_0.X - (num - rectangle_0.Width) / 2, rectangle_0.Y - (num - rectangle_0.Height) / 2, num, num);
					PathGradientBrush val2 = new PathGradientBrush(val);
					val2.set_CenterColor(backgroundColorBlendCollection_0[0].Color);
					val2.set_SurroundColors(new Color[1] { backgroundColorBlendCollection_0[backgroundColorBlendCollection_0.Count - 1].Color });
					val2.set_InterpolationColors(backgroundColorBlendCollection_0.GetColorBlend());
					return (Brush)(object)val2;
				}
				}
			}
			catch
			{
				return null;
			}
			break;
		default:
		{
			for (int i = 0; i < backgroundColorBlendCollection_0.Count; i += 2)
			{
				BackgroundColorBlend backgroundColorBlend = backgroundColorBlendCollection_0[i];
				BackgroundColorBlend backgroundColorBlend2 = null;
				if (i < backgroundColorBlendCollection_0.Count)
				{
					backgroundColorBlend2 = backgroundColorBlendCollection_0[i + 1];
				}
				if (backgroundColorBlend != null && backgroundColorBlend2 != null)
				{
					Rectangle rectangle_ = new Rectangle(rectangle_0.X, rectangle_0.Y + (int)backgroundColorBlend.Position, rectangle_0.Width, ((backgroundColorBlend2.Position == 1f) ? rectangle_0.Height : ((int)backgroundColorBlend2.Position)) - (int)backgroundColorBlend.Position);
					return (Brush)(object)smethod_0(rectangle_, backgroundColorBlend.Color, backgroundColorBlend2.Color, int_0);
				}
			}
			break;
		}
		}
		return null;
	}

	public static Rectangle[] smethod_47(Rectangle rectangle_0, Rectangle rectangle_1)
	{
		if (rectangle_0.X >= rectangle_1.X && rectangle_1.Right < rectangle_0.X)
		{
			return new Rectangle[1]
			{
				new Rectangle(rectangle_1.Right, rectangle_0.Y, rectangle_0.Width - (rectangle_1.Right - rectangle_0.X), rectangle_0.Height)
			};
		}
		if (rectangle_0.Right <= rectangle_1.Right && rectangle_1.X > rectangle_0.X)
		{
			return new Rectangle[1]
			{
				new Rectangle(rectangle_0.X, rectangle_0.Y, rectangle_0.Width - (rectangle_0.Right - rectangle_1.X), rectangle_0.Height)
			};
		}
		if (rectangle_1.X > rectangle_0.X && rectangle_1.Right < rectangle_0.Right)
		{
			return new Rectangle[2]
			{
				new Rectangle(rectangle_0.X, rectangle_0.Y, rectangle_1.X - rectangle_0.X, rectangle_0.Height),
				new Rectangle(rectangle_1.Right, rectangle_0.Y, rectangle_0.Right - rectangle_1.Right, rectangle_0.Height)
			};
		}
		return new Rectangle[0];
	}

	internal static Size smethod_48(Size size_0, Size size_1)
	{
		if (size_1.Width > size_0.Width)
		{
			size_0.Width = size_1.Width;
		}
		if (size_1.Height > size_0.Height)
		{
			size_0.Height = size_1.Height;
		}
		return size_0;
	}
}
