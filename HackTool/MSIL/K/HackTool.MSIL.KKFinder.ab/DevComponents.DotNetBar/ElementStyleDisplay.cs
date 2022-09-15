using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

public class ElementStyleDisplay
{
	private enum Enum22
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7
	}

	public static void PaintText(ElementStyleDisplayInfo e, string text, Font defaultFont)
	{
		PaintText(e, text, defaultFont, useDefaultFont: false);
	}

	public static void PaintText(ElementStyleDisplayInfo e, string text, Font defaultFont, bool useDefaultFont)
	{
		PaintText(e, text, defaultFont, useDefaultFont, e.Style.ETextFormat_0);
	}

	public static void PaintText(ElementStyleDisplayInfo e, string text, Font defaultFont, bool useDefaultFont, eTextFormat textFormat)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		Rectangle bounds = e.Bounds;
		ElementStyle elementStyle = smethod_5(e.Style);
		if (text == "" || bounds.IsEmpty || elementStyle.TextColor.IsEmpty)
		{
			return;
		}
		Font val = elementStyle.Font;
		if (val == null || useDefaultFont)
		{
			val = defaultFont;
		}
		bounds.X += elementStyle.MarginLeft;
		bounds.Width -= elementStyle.MarginLeft + elementStyle.MarginRight;
		bounds.Y += elementStyle.MarginTop;
		bounds.Height -= elementStyle.MarginTop + elementStyle.MarginBottom;
		if (!elementStyle.TextShadowColor.IsEmpty && (double)Math.Abs(elementStyle.TextShadowColor.GetBrightness() - elementStyle.TextColor.GetBrightness()) > 0.2)
		{
			SolidBrush val2 = new SolidBrush(elementStyle.TextShadowColor);
			try
			{
				Rectangle rectangle_ = bounds;
				rectangle_.Offset(elementStyle.TextShadowOffset);
				Class55.smethod_1(e.Graphics, text, val, elementStyle.TextShadowColor, rectangle_, textFormat);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		if (!elementStyle.TextColor.IsEmpty)
		{
			Class55.smethod_1(e.Graphics, text, val, elementStyle.TextColor, bounds, textFormat);
		}
	}

	public static Region GetStyleRegion(ElementStyleDisplayInfo e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		Rectangle bounds = e.Bounds;
		if (e.Style.Boolean_5 && e.Style.CornerType != eCornerType.Square)
		{
			bounds.Width--;
			bounds.Height--;
		}
		GraphicsPath backgroundPath = GetBackgroundPath(e.Style, bounds);
		Region val = new Region();
		val.MakeEmpty();
		val.Union(backgroundPath);
		if (e.Style.Boolean_5 && (e.Style.CornerType == eCornerType.Rounded || e.Style.CornerType == eCornerType.Diagonal || e.Style.CornerTypeTopLeft == eCornerType.Rounded || e.Style.CornerTypeTopLeft == eCornerType.Diagonal || e.Style.CornerTypeTopRight == eCornerType.Rounded || e.Style.CornerTypeTopRight == eCornerType.Diagonal || e.Style.CornerTypeBottomLeft == eCornerType.Rounded || e.Style.CornerTypeBottomLeft == eCornerType.Diagonal || e.Style.CornerTypeBottomRight == eCornerType.Rounded || e.Style.CornerTypeBottomRight == eCornerType.Diagonal))
		{
			Pen val2 = new Pen(Color.Black, (float)((e.Style.BorderTopWidth <= 0) ? 1 : e.Style.BorderTopWidth));
			try
			{
				backgroundPath.Widen(val2);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			val.Union(backgroundPath);
		}
		return val;
	}

	public static GraphicsPath GetInsideClip(ElementStyleDisplayInfo e)
	{
		Rectangle bounds = e.Bounds;
		if (e.Style.Boolean_5)
		{
			if (e.Style.Boolean_3)
			{
				bounds.Y += e.Style.BorderTopWidth;
				bounds.Height -= e.Style.BorderTopWidth;
				if (e.Style.BorderTop == eStyleBorderType.Etched || e.Style.BorderTop == eStyleBorderType.Double)
				{
					bounds.Y += e.Style.BorderTopWidth;
					bounds.Height -= e.Style.BorderTopWidth;
				}
			}
			if (e.Style.Boolean_4)
			{
				bounds.Height -= e.Style.BorderBottomWidth;
				if (e.Style.BorderBottom == eStyleBorderType.Etched || e.Style.BorderBottom == eStyleBorderType.Double)
				{
					bounds.Height -= e.Style.BorderBottomWidth;
				}
			}
			if (e.Style.Boolean_1)
			{
				bounds.X += e.Style.BorderLeftWidth;
				bounds.Width -= e.Style.BorderLeftWidth;
				if (e.Style.BorderLeft == eStyleBorderType.Etched || e.Style.BorderLeft == eStyleBorderType.Double)
				{
					bounds.X += e.Style.BorderLeftWidth;
					bounds.Width -= e.Style.BorderLeftWidth;
				}
			}
			if (e.Style.Boolean_2)
			{
				bounds.Width -= e.Style.BorderRightWidth;
				if (e.Style.BorderRight == eStyleBorderType.Etched || e.Style.BorderRight == eStyleBorderType.Double)
				{
					bounds.Width -= e.Style.BorderRightWidth;
				}
			}
		}
		return GetBackgroundPath(e.Style, bounds);
	}

	public static void Paint(ElementStyleDisplayInfo e)
	{
		PaintBackground(e);
		PaintBackgroundImage(e);
		PaintBorder(e);
	}

	private static eCornerType smethod_0(eCornerType eCornerType_0, eCornerType eCornerType_1)
	{
		if (eCornerType_1 != 0)
		{
			return eCornerType_1;
		}
		return eCornerType_0;
	}

	public static void PaintBorder(ElementStyleDisplayInfo e)
	{
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		ElementStyle elementStyle = smethod_5(e.Style);
		Rectangle rectangle = smethod_7(elementStyle, e.Bounds);
		if (rectangle.Width < 2 || rectangle.Height < 2)
		{
			return;
		}
		eCornerType eCornerType2 = smethod_0(elementStyle.CornerType, elementStyle.CornerTypeTopLeft);
		eCornerType eCornerType3 = smethod_0(elementStyle.CornerType, elementStyle.CornerTypeTopRight);
		eCornerType eCornerType4 = smethod_0(elementStyle.CornerType, elementStyle.CornerTypeBottomLeft);
		eCornerType eCornerType5 = smethod_0(elementStyle.CornerType, elementStyle.CornerTypeBottomRight);
		if (elementStyle.Boolean_5 && elementStyle.Border == eStyleBorderType.Solid && eCornerType2 == eCornerType.Rounded && eCornerType3 == eCornerType.Rounded && eCornerType4 == eCornerType.Rounded && eCornerType5 == eCornerType.Rounded && elementStyle.BorderLeftWidth == elementStyle.BorderWidth && elementStyle.BorderRightWidth == elementStyle.BorderWidth && elementStyle.BorderTopWidth == elementStyle.BorderWidth && elementStyle.BorderBottomWidth == elementStyle.BorderWidth)
		{
			if (elementStyle.BorderWidth == 1)
			{
				rectangle.Width++;
				rectangle.Height++;
			}
			Class50.smethod_38(e.Graphics, rectangle, elementStyle.BorderColor, elementStyle.BorderColor2, elementStyle.BorderGradientAngle, elementStyle.BorderWidth, elementStyle.CornerDiameter);
			return;
		}
		if (elementStyle.Boolean_6 && elementStyle.Border == eStyleBorderType.Solid && eCornerType2 == eCornerType.Square && eCornerType3 == eCornerType.Square && eCornerType4 == eCornerType.Square && eCornerType5 == eCornerType.Square && elementStyle.BorderLeftWidth == elementStyle.BorderWidth && elementStyle.BorderRightWidth == elementStyle.BorderWidth && elementStyle.BorderTopWidth == elementStyle.BorderWidth && elementStyle.BorderBottomWidth == elementStyle.BorderWidth)
		{
			if (elementStyle.BorderWidth == 1)
			{
				rectangle.Width++;
				rectangle.Height++;
			}
			Class50.smethod_34(e.Graphics, rectangle, elementStyle.BorderColor, elementStyle.BorderColor2, elementStyle.BorderGradientAngle, elementStyle.BorderWidth);
			return;
		}
		if (!elementStyle.BorderColor2.IsEmpty || !elementStyle.BorderColorLight.IsEmpty)
		{
			if (elementStyle.Border == eStyleBorderType.Solid)
			{
				GraphicsPath val = Class50.smethod_15(rectangle, elementStyle.CornerDiameter, eStyleBackgroundPathPart.Complete, eCornerType2, eCornerType3, eCornerType4, eCornerType5);
				try
				{
					Class50.smethod_40(e.Graphics, val, elementStyle.BorderColor, elementStyle.BorderColor2, elementStyle.BorderGradientAngle, elementStyle.BorderWidth);
					return;
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			if (elementStyle.Border == eStyleBorderType.Etched)
			{
				Rectangle rectangle_ = rectangle;
				rectangle_.Width -= elementStyle.BorderWidth;
				rectangle_.Height -= elementStyle.BorderWidth;
				rectangle_.Offset(elementStyle.BorderWidth, elementStyle.BorderWidth);
				if (rectangle_.Width > 2 && rectangle_.Height > 2)
				{
					GraphicsPath val2 = Class50.smethod_15(rectangle_, elementStyle.CornerDiameter, eStyleBackgroundPathPart.Complete, eCornerType2, eCornerType3, eCornerType4, eCornerType5);
					try
					{
						Class50.smethod_40(e.Graphics, val2, elementStyle.BorderColorLight, elementStyle.BorderColorLight2, elementStyle.BorderLightGradientAngle, elementStyle.BorderWidth);
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
					rectangle_.Offset(-elementStyle.BorderWidth, -elementStyle.BorderWidth);
					GraphicsPath val3 = Class50.smethod_15(rectangle_, elementStyle.CornerDiameter, eStyleBackgroundPathPart.Complete, eCornerType2, eCornerType3, eCornerType4, eCornerType5);
					try
					{
						Class50.smethod_40(e.Graphics, val3, elementStyle.BorderColor, elementStyle.BorderColor2, elementStyle.BorderGradientAngle, elementStyle.BorderWidth);
						return;
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
				}
				return;
			}
			if ((elementStyle.BorderTop == eStyleBorderType.Double && elementStyle.BorderLeft == eStyleBorderType.Double && elementStyle.BorderRight == eStyleBorderType.Double && elementStyle.BorderBottom == eStyleBorderType.Double) || (elementStyle.BorderTop == eStyleBorderType.None && elementStyle.BorderLeft == eStyleBorderType.Double && elementStyle.BorderRight == eStyleBorderType.Double && elementStyle.BorderBottom == eStyleBorderType.Double))
			{
				Rectangle rectangle2 = rectangle;
				Region clip = null;
				bool flag = false;
				if (elementStyle.BorderTop == eStyleBorderType.None)
				{
					Rectangle clip2 = rectangle2;
					clip2.Width++;
					clip2.Height++;
					e.Graphics.SetClip(clip2);
					rectangle2.Y -= 3;
					rectangle2.Height += 3;
				}
				GraphicsPath val4 = Class50.smethod_18(rectangle2, elementStyle.CornerDiameter, eStyleBackgroundPathPart.Complete, eCornerType2, eCornerType3, eCornerType4, eCornerType5, elementStyle.Boolean_1, elementStyle.Boolean_2, elementStyle.Boolean_3, elementStyle.Boolean_4);
				try
				{
					Pen val5 = new Pen(elementStyle.BorderColor, (float)elementStyle.BorderWidth);
					try
					{
						val4.Widen(val5);
					}
					finally
					{
						((IDisposable)val5)?.Dispose();
					}
					Class50.smethod_28(e.Graphics, val4, elementStyle.BorderColor, elementStyle.BorderColor2);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
				rectangle2.Inflate(-elementStyle.BorderWidth, -elementStyle.BorderWidth);
				GraphicsPath val6 = Class50.smethod_18(rectangle2, elementStyle.CornerDiameter, eStyleBackgroundPathPart.Complete, eCornerType2, eCornerType3, eCornerType4, eCornerType5, elementStyle.Boolean_1, elementStyle.Boolean_2, elementStyle.Boolean_3, elementStyle.Boolean_4);
				try
				{
					Pen val7 = new Pen(elementStyle.BorderColor, (float)elementStyle.BorderWidth);
					try
					{
						val6.Widen(val7);
					}
					finally
					{
						((IDisposable)val7)?.Dispose();
					}
					Class50.smethod_28(e.Graphics, val6, elementStyle.BorderColorLight, elementStyle.BorderColorLight2);
				}
				finally
				{
					((IDisposable)val6)?.Dispose();
				}
				if (flag)
				{
					e.Graphics.set_Clip(clip);
				}
				return;
			}
		}
		_ = elementStyle.BorderColor;
		Color borderColor = elementStyle.BorderColor2;
		Color borderColorLight = elementStyle.BorderColorLight;
		Color borderColorLight2 = elementStyle.BorderColorLight2;
		if (elementStyle.Boolean_1)
		{
			Color color_ = elementStyle.BorderColor;
			if (!elementStyle.BorderLeftColor.IsEmpty)
			{
				color_ = elementStyle.BorderLeftColor;
			}
			Point[] array = new Point[2]
			{
				rectangle.Location,
				default(Point)
			};
			array[1].X = rectangle.X;
			array[1].Y = rectangle.Bottom;
			if (eCornerType2 != eCornerType.Square)
			{
				array[0].Y += elementStyle.CornerDiameter;
			}
			if (eCornerType4 != eCornerType.Square)
			{
				array[1].Y -= elementStyle.CornerDiameter;
			}
			smethod_2(e.Graphics, array, elementStyle.BorderLeft, elementStyle.BorderLeftWidth, color_, borderColor, borderColorLight, borderColorLight2, Enum22.const_2);
			if (elementStyle.Boolean_3)
			{
				switch (eCornerType2)
				{
				case eCornerType.Diagonal:
					array[0].X = rectangle.X;
					array[0].Y = rectangle.Y + elementStyle.CornerDiameter;
					array[1].X = rectangle.X + elementStyle.CornerDiameter;
					array[1].Y = rectangle.Y;
					smethod_2(e.Graphics, array, elementStyle.BorderLeft, elementStyle.BorderLeftWidth, color_, borderColor, borderColorLight, borderColorLight2, Enum22.const_4);
					break;
				case eCornerType.Rounded:
				{
					Struct10 struct10_ = smethod_10(rectangle, elementStyle.CornerDiameter, Enum14.const_0);
					smethod_3(e.Graphics, struct10_, elementStyle.BorderLeft, elementStyle.BorderLeftWidth, color_);
					break;
				}
				}
			}
			if (elementStyle.Boolean_4)
			{
				switch (eCornerType4)
				{
				case eCornerType.Diagonal:
					array[0].X = rectangle.X;
					array[0].Y = rectangle.Bottom - elementStyle.CornerDiameter;
					array[1].X = rectangle.X + elementStyle.CornerDiameter;
					array[1].Y = rectangle.Bottom;
					smethod_2(e.Graphics, array, elementStyle.BorderLeft, elementStyle.BorderLeftWidth, color_, borderColor, borderColorLight, borderColorLight2, Enum22.const_6);
					break;
				case eCornerType.Rounded:
				{
					Struct10 struct10_2 = smethod_10(rectangle, elementStyle.CornerDiameter, Enum14.const_2);
					smethod_3(e.Graphics, struct10_2, elementStyle.BorderLeft, elementStyle.BorderLeftWidth, color_);
					break;
				}
				}
			}
		}
		if (elementStyle.Boolean_3)
		{
			Color color_2 = elementStyle.BorderColor;
			if (!elementStyle.BorderTopColor.IsEmpty)
			{
				color_2 = elementStyle.BorderTopColor;
			}
			Point[] array2 = new Point[2]
			{
				rectangle.Location,
				default(Point)
			};
			array2[1].X = rectangle.Right;
			array2[1].Y = rectangle.Y;
			if (eCornerType2 != eCornerType.Square)
			{
				array2[0].X += elementStyle.CornerDiameter;
			}
			if (eCornerType3 != eCornerType.Square)
			{
				array2[1].X -= elementStyle.CornerDiameter;
			}
			smethod_2(e.Graphics, array2, elementStyle.BorderTop, elementStyle.BorderTopWidth, color_2, borderColor, borderColorLight, borderColorLight2, Enum22.const_0);
		}
		if (elementStyle.Boolean_4)
		{
			Color color_3 = elementStyle.BorderColor;
			if (!elementStyle.BorderBottomColor.IsEmpty)
			{
				color_3 = elementStyle.BorderBottomColor;
			}
			Point[] array3 = new Point[2];
			array3[0].X = rectangle.X;
			array3[0].Y = rectangle.Bottom;
			array3[1].X = rectangle.Right;
			array3[1].Y = rectangle.Bottom;
			if (eCornerType4 != eCornerType.Square)
			{
				array3[0].X += elementStyle.CornerDiameter;
			}
			if (eCornerType5 != eCornerType.Square)
			{
				array3[1].X -= elementStyle.CornerDiameter;
			}
			smethod_2(e.Graphics, array3, elementStyle.BorderBottom, elementStyle.BorderBottomWidth, color_3, borderColor, borderColorLight, borderColorLight2, Enum22.const_1);
		}
		if (!elementStyle.Boolean_2)
		{
			return;
		}
		Color color_4 = elementStyle.BorderColor;
		if (!elementStyle.BorderRightColor.IsEmpty)
		{
			color_4 = elementStyle.BorderRightColor;
		}
		Point[] array4 = new Point[2];
		array4[0].X = rectangle.Right;
		array4[0].Y = rectangle.Y;
		array4[1].X = rectangle.Right;
		array4[1].Y = rectangle.Bottom;
		if (eCornerType3 != eCornerType.Square)
		{
			array4[0].Y += elementStyle.CornerDiameter;
		}
		if (eCornerType5 != eCornerType.Square)
		{
			array4[1].Y -= elementStyle.CornerDiameter;
		}
		smethod_2(e.Graphics, array4, elementStyle.BorderRight, elementStyle.BorderRightWidth, color_4, borderColor, borderColorLight, borderColorLight2, Enum22.const_3);
		if (elementStyle.Boolean_3)
		{
			switch (eCornerType3)
			{
			case eCornerType.Diagonal:
				array4[0].X = rectangle.Right - elementStyle.CornerDiameter;
				array4[0].Y = rectangle.Y;
				array4[1].X = rectangle.Right;
				array4[1].Y = rectangle.Y + elementStyle.CornerDiameter;
				smethod_2(e.Graphics, array4, elementStyle.BorderLeft, elementStyle.BorderRightWidth, color_4, borderColor, borderColorLight, borderColorLight2, Enum22.const_5);
				break;
			case eCornerType.Rounded:
			{
				Struct10 struct10_3 = smethod_10(rectangle, elementStyle.CornerDiameter, Enum14.const_1);
				smethod_3(e.Graphics, struct10_3, elementStyle.BorderLeft, elementStyle.BorderLeftWidth, color_4);
				break;
			}
			}
		}
		if (elementStyle.Boolean_4)
		{
			switch (eCornerType5)
			{
			case eCornerType.Diagonal:
				array4[0].X = rectangle.Right;
				array4[0].Y = rectangle.Bottom - elementStyle.CornerDiameter;
				array4[1].X = rectangle.Right - elementStyle.CornerDiameter;
				array4[1].Y = rectangle.Bottom;
				smethod_2(e.Graphics, array4, elementStyle.BorderLeft, elementStyle.BorderRightWidth, color_4, borderColor, borderColorLight, borderColorLight2, Enum22.const_7);
				break;
			case eCornerType.Rounded:
			{
				Struct10 struct10_4 = smethod_10(rectangle, elementStyle.CornerDiameter, Enum14.const_3);
				smethod_3(e.Graphics, struct10_4, elementStyle.BorderLeft, elementStyle.BorderLeftWidth, color_4);
				break;
			}
			}
		}
	}

	private static Pen smethod_1(eStyleBorderType eStyleBorderType_0, int int_0, Color color_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Pen val = new Pen(color_0, (float)int_0);
		val.set_Alignment((PenAlignment)1);
		val.set_DashStyle(smethod_4(eStyleBorderType_0));
		return val;
	}

	private static void smethod_2(Graphics graphics_0, Point[] point_0, eStyleBorderType eStyleBorderType_0, int int_0, Color color_0, Color color_1, Color color_2, Color color_3, Enum22 enum22_0)
	{
		if (eStyleBorderType_0 != eStyleBorderType.Etched && eStyleBorderType_0 != eStyleBorderType.Double)
		{
			Class50.smethod_43(graphics_0, point_0[0], point_0[1], color_0, color_1, 90, int_0);
			return;
		}
		if (color_2.IsEmpty)
		{
			color_2 = ControlPaint.Light(color_0);
			color_0 = ControlPaint.Dark(color_0);
		}
		if (enum22_0 == Enum22.const_1 || enum22_0 == Enum22.const_3)
		{
			Color color = color_0;
			Color color2 = color_1;
			color_0 = color_2;
			color_1 = color_3;
			color_2 = color;
			color_3 = color2;
		}
		Class50.smethod_43(graphics_0, point_0[0], point_0[1], color_0, color_1, 90, int_0);
		switch (enum22_0)
		{
		case Enum22.const_0:
			point_0[0].Y += int_0;
			point_0[1].Y += int_0;
			break;
		case Enum22.const_1:
			point_0[0].Y -= int_0;
			point_0[1].Y -= int_0;
			break;
		case Enum22.const_3:
		case Enum22.const_5:
		case Enum22.const_7:
			point_0[0].X -= int_0;
			point_0[1].X -= int_0;
			break;
		case Enum22.const_2:
		case Enum22.const_4:
		case Enum22.const_6:
			point_0[0].X += int_0;
			point_0[1].X += int_0;
			break;
		}
		Class50.smethod_43(graphics_0, point_0[0], point_0[1], color_2, color_3, 90, int_0);
	}

	private static void smethod_3(Graphics graphics_0, Struct10 struct10_0, eStyleBorderType eStyleBorderType_0, int int_0, Color color_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		SmoothingMode smoothingMode = graphics_0.get_SmoothingMode();
		if ((int)smoothingMode == 3)
		{
			graphics_0.set_SmoothingMode((SmoothingMode)2);
		}
		Pen val = smethod_1(eStyleBorderType_0, int_0, color_0);
		try
		{
			graphics_0.DrawArc(val, (float)struct10_0.int_0, (float)struct10_0.int_1, (float)struct10_0.int_2, (float)struct10_0.int_3, struct10_0.float_0, struct10_0.float_1);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		if ((int)smoothingMode == 3)
		{
			graphics_0.set_SmoothingMode(smoothingMode);
		}
	}

	private static DashStyle smethod_4(eStyleBorderType eStyleBorderType_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		DashStyle result = (DashStyle)0;
		switch (eStyleBorderType_0)
		{
		case eStyleBorderType.Dash:
			result = (DashStyle)1;
			break;
		case eStyleBorderType.DashDot:
			result = (DashStyle)3;
			break;
		case eStyleBorderType.DashDotDot:
			result = (DashStyle)4;
			break;
		case eStyleBorderType.Dot:
			result = (DashStyle)2;
			break;
		}
		return result;
	}

	internal static ElementStyle smethod_5(ElementStyle elementStyle_0)
	{
		if (elementStyle_0.Class == "")
		{
			return elementStyle_0;
		}
		IElementStyleClassProvider elementStyleClassProvider = smethod_6();
		if (elementStyleClassProvider != null)
		{
			ElementStyle @class = elementStyleClassProvider.GetClass(elementStyle_0.Class);
			if (@class != null)
			{
				if (elementStyle_0.Custom)
				{
					ElementStyle elementStyle = @class.Copy();
					elementStyle.ApplyStyle(elementStyle_0);
					return elementStyle;
				}
				return @class;
			}
		}
		return elementStyle_0;
	}

	private static IElementStyleClassProvider smethod_6()
	{
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			return ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
		}
		return null;
	}

	public static void PaintBackground(ElementStyleDisplayInfo e)
	{
		PaintBackground(e, shapeBackground: true);
	}

	public static void PaintBackground(ElementStyleDisplayInfo e, bool shapeBackground)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		Region clip = e.Graphics.get_Clip();
		if (clip != null)
		{
			e.Graphics.SetClip(e.Bounds, (CombineMode)1);
		}
		else
		{
			e.Graphics.SetClip(e.Bounds, (CombineMode)0);
		}
		ElementStyle elementStyle = smethod_5(e.Style);
		SmoothingMode smoothingMode = e.Graphics.get_SmoothingMode();
		e.Graphics.set_SmoothingMode((SmoothingMode)0);
		Rectangle rectangle = Class50.smethod_3(GetBackgroundRectangle(elementStyle, e.Bounds));
		GraphicsPath val;
		if (shapeBackground)
		{
			val = GetBackgroundPath(elementStyle, smethod_7(e.Style, e.Bounds));
		}
		else
		{
			val = new GraphicsPath();
			val.AddRectangle(rectangle);
		}
		Enum11 @enum = elementStyle.BackColorBlend.method_1();
		switch (@enum)
		{
		case Enum11.const_1:
			try
			{
				if (elementStyle.BackColorGradientType == eGradientType.Linear)
				{
					Rectangle rectangle_ = rectangle;
					rectangle_.Inflate(1, 1);
					LinearGradientBrush val3 = Class50.smethod_0(rectangle_, elementStyle.BackColor, elementStyle.BackColor2, elementStyle.BackColorGradientAngle);
					try
					{
						val3.set_InterpolationColors(elementStyle.BackColorBlend.GetColorBlend());
						e.Graphics.FillPath((Brush)(object)val3, val);
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
				}
				else if (elementStyle.BackColorGradientType == eGradientType.Radial)
				{
					int num = (int)Math.Sqrt(rectangle.Width * rectangle.Width + rectangle.Height * rectangle.Height) + 4;
					GraphicsPath val4 = new GraphicsPath();
					val4.AddEllipse(rectangle.X - (num - rectangle.Width) / 2, rectangle.Y - (num - rectangle.Height) / 2, num, num);
					PathGradientBrush val5 = new PathGradientBrush(val4);
					try
					{
						val5.set_CenterColor(elementStyle.BackColor);
						val5.set_SurroundColors(new Color[1] { elementStyle.BackColor2 });
						val5.set_InterpolationColors(elementStyle.BackColorBlend.GetColorBlend());
						e.Graphics.FillPath((Brush)(object)val5, val);
					}
					finally
					{
						((IDisposable)val5)?.Dispose();
					}
					val4.Dispose();
				}
			}
			catch
			{
				@enum = Enum11.const_0;
			}
			break;
		default:
		{
			Graphics graphics = e.Graphics;
			rectangle = e.Bounds;
			if (clip != null)
			{
				e.Graphics.SetClip(clip, (CombineMode)0);
				e.Graphics.SetClip(val, (CombineMode)1);
			}
			else
			{
				e.Graphics.SetClip(val, (CombineMode)0);
			}
			BackgroundColorBlendCollection backColorBlend = elementStyle.BackColorBlend;
			for (int i = 0; i < backColorBlend.Count; i += 2)
			{
				BackgroundColorBlend backgroundColorBlend = backColorBlend[i];
				BackgroundColorBlend backgroundColorBlend2 = null;
				if (i < backColorBlend.Count)
				{
					backgroundColorBlend2 = backColorBlend[i + 1];
				}
				if (backgroundColorBlend != null && backgroundColorBlend2 != null)
				{
					Rectangle rectangle2 = new Rectangle(rectangle.X, rectangle.Y + (int)backgroundColorBlend.Position, rectangle.Width, ((backgroundColorBlend2.Position == 1f) ? rectangle.Height : ((int)backgroundColorBlend2.Position)) - (int)backgroundColorBlend.Position);
					LinearGradientBrush val2 = Class50.smethod_0(rectangle2, backgroundColorBlend.Color, backgroundColorBlend2.Color, elementStyle.BackColorGradientAngle);
					try
					{
						graphics.FillRectangle((Brush)(object)val2, rectangle2);
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
				}
			}
			break;
		}
		case Enum11.const_0:
			break;
		}
		if (@enum == Enum11.const_0)
		{
			if (elementStyle.BackColor2.IsEmpty)
			{
				if (!elementStyle.BackColor.IsEmpty)
				{
					SolidBrush val6 = new SolidBrush(elementStyle.BackColor);
					try
					{
						e.Graphics.FillPath((Brush)(object)val6, val);
					}
					finally
					{
						((IDisposable)val6)?.Dispose();
					}
				}
			}
			else if (!elementStyle.BackColor.IsEmpty)
			{
				if (elementStyle.BackColorGradientType == eGradientType.Linear)
				{
					Rectangle rectangle_2 = rectangle;
					rectangle_2.X--;
					rectangle_2.Height++;
					rectangle_2.Width += 2;
					LinearGradientBrush val7 = Class50.smethod_0(rectangle_2, elementStyle.BackColor, elementStyle.BackColor2, elementStyle.BackColorGradientAngle);
					try
					{
						e.Graphics.FillPath((Brush)(object)val7, val);
					}
					finally
					{
						((IDisposable)val7)?.Dispose();
					}
				}
				else if (elementStyle.BackColorGradientType == eGradientType.Radial)
				{
					int num2 = (int)Math.Sqrt(rectangle.Width * rectangle.Width + rectangle.Height * rectangle.Height) + 4;
					GraphicsPath val8 = new GraphicsPath();
					val8.AddEllipse(rectangle.X - (num2 - rectangle.Width) / 2, rectangle.Y - (num2 - rectangle.Height) / 2, num2, num2);
					PathGradientBrush val9 = new PathGradientBrush(val8);
					try
					{
						val9.set_CenterColor(elementStyle.BackColor);
						val9.set_SurroundColors(new Color[1] { elementStyle.BackColor2 });
						e.Graphics.FillPath((Brush)(object)val9, val);
					}
					finally
					{
						((IDisposable)val9)?.Dispose();
					}
					val8.Dispose();
				}
			}
		}
		e.Graphics.set_SmoothingMode(smoothingMode);
		if (clip != null)
		{
			e.Graphics.set_Clip(clip);
		}
		else
		{
			e.Graphics.ResetClip();
		}
	}

	public static void PaintBackgroundImage(ElementStyleDisplayInfo e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		ElementStyle elementStyle = smethod_5(e.Style);
		if (elementStyle.BackgroundImage == null)
		{
			return;
		}
		Rectangle rectangle = Class50.smethod_3(GetBackgroundRectangle(elementStyle, e.Bounds));
		GraphicsPath backgroundPath;
		if ((int)e.Graphics.get_SmoothingMode() == 4)
		{
			Rectangle bounds = e.Bounds;
			bounds.Width--;
			backgroundPath = GetBackgroundPath(elementStyle, bounds);
		}
		else
		{
			backgroundPath = GetBackgroundPath(elementStyle, e.Bounds);
		}
		ImageAttributes val = null;
		if (elementStyle.BackgroundImageAlpha != byte.MaxValue)
		{
			ColorMatrix val2 = new ColorMatrix();
			val2.set_Matrix33((float)(255 - elementStyle.BackgroundImageAlpha));
			val = new ImageAttributes();
			val.SetColorMatrix(val2, (ColorMatrixFlag)0, (ColorAdjustType)1);
		}
		Region clip = e.Graphics.get_Clip();
		e.Graphics.SetClip(backgroundPath);
		eStyleBackgroundImage eStyleBackgroundImage2 = elementStyle.BackgroundImagePosition;
		bool flag = false;
		Image val3 = elementStyle.BackgroundImage;
		if (e.RightToLeft)
		{
			switch (eStyleBackgroundImage2)
			{
			case eStyleBackgroundImage.TopLeft:
				eStyleBackgroundImage2 = eStyleBackgroundImage.TopRight;
				flag = true;
				break;
			case eStyleBackgroundImage.TopRight:
				eStyleBackgroundImage2 = eStyleBackgroundImage.TopLeft;
				break;
			case eStyleBackgroundImage.BottomLeft:
				eStyleBackgroundImage2 = eStyleBackgroundImage.BottomRight;
				break;
			case eStyleBackgroundImage.BottomRight:
				eStyleBackgroundImage2 = eStyleBackgroundImage.BottomLeft;
				break;
			}
		}
		if (flag)
		{
			object obj = val3.Clone();
			val3 = (Image)((obj is Image) ? obj : null);
			val3.RotateFlip((RotateFlipType)4);
		}
		switch (eStyleBackgroundImage2)
		{
		case eStyleBackgroundImage.Stretch:
			if (val != null)
			{
				e.Graphics.DrawImage(val3, rectangle, 0, 0, val3.get_Width(), val3.get_Height(), (GraphicsUnit)2, val);
			}
			else
			{
				e.Graphics.DrawImage(val3, rectangle, 0, 0, val3.get_Width(), val3.get_Height(), (GraphicsUnit)2);
			}
			break;
		case eStyleBackgroundImage.Center:
		{
			Rectangle rectangle4 = new Rectangle(rectangle.X, rectangle.Y, val3.get_Width(), val3.get_Height());
			if (rectangle.Width > val3.get_Width())
			{
				rectangle4.X += (rectangle.Width - val3.get_Width()) / 2;
			}
			if (rectangle.Height > val3.get_Height())
			{
				rectangle4.Y += (rectangle.Height - val3.get_Height()) / 2;
			}
			if (val != null)
			{
				e.Graphics.DrawImage(val3, rectangle4, 0, 0, val3.get_Width(), val3.get_Height(), (GraphicsUnit)2, val);
			}
			else
			{
				e.Graphics.DrawImage(val3, rectangle4, 0, 0, val3.get_Width(), val3.get_Height(), (GraphicsUnit)2);
			}
			break;
		}
		case eStyleBackgroundImage.Tile:
			if (val != null)
			{
				if (rectangle.Width <= val3.get_Width() && rectangle.Height <= val3.get_Height())
				{
					e.Graphics.DrawImage(val3, new Rectangle(0, 0, val3.get_Width(), val3.get_Height()), 0, 0, val3.get_Width(), val3.get_Height(), (GraphicsUnit)2, val);
					break;
				}
				int i = rectangle.X;
				for (int j = rectangle.Y; j < rectangle.Bottom; j += val3.get_Height())
				{
					for (; i < rectangle.Right; i += val3.get_Width())
					{
						Rectangle rectangle3 = new Rectangle(i, j, val3.get_Width(), val3.get_Height());
						if (rectangle3.Right > rectangle.Right)
						{
							rectangle3.Width -= rectangle3.Right - rectangle.Right;
						}
						if (rectangle3.Bottom > rectangle.Bottom)
						{
							rectangle3.Height -= rectangle3.Bottom - rectangle.Bottom;
						}
						e.Graphics.DrawImage(val3, rectangle3, 0, 0, rectangle3.Width, rectangle3.Height, (GraphicsUnit)2, val);
					}
					i = rectangle.X;
				}
			}
			else
			{
				TextureBrush val4 = new TextureBrush(val3);
				val4.set_WrapMode((WrapMode)0);
				e.Graphics.FillPath((Brush)(object)val4, backgroundPath);
				((Brush)val4).Dispose();
			}
			break;
		case eStyleBackgroundImage.TopLeft:
		case eStyleBackgroundImage.TopRight:
		case eStyleBackgroundImage.BottomLeft:
		case eStyleBackgroundImage.BottomRight:
		{
			Rectangle rectangle2 = new Rectangle(rectangle.X, rectangle.Y, val3.get_Width(), val3.get_Height());
			switch (eStyleBackgroundImage2)
			{
			case eStyleBackgroundImage.TopRight:
				rectangle2.X = rectangle.Right - val3.get_Width();
				break;
			case eStyleBackgroundImage.BottomLeft:
				rectangle2.Y = rectangle.Bottom - val3.get_Height();
				break;
			case eStyleBackgroundImage.BottomRight:
				rectangle2.Y = rectangle.Bottom - val3.get_Height();
				rectangle2.X = rectangle.Right - val3.get_Width();
				break;
			}
			if (val != null)
			{
				e.Graphics.DrawImage(val3, rectangle2, 0, 0, val3.get_Width(), val3.get_Height(), (GraphicsUnit)2, val);
			}
			else
			{
				e.Graphics.DrawImage(val3, rectangle2, 0, 0, val3.get_Width(), val3.get_Height(), (GraphicsUnit)2);
			}
			break;
		}
		}
		if (flag)
		{
			val3.Dispose();
		}
		if (clip != null)
		{
			e.Graphics.set_Clip(clip);
		}
		else
		{
			e.Graphics.ResetClip();
		}
	}

	public static Rectangle GetBackgroundRectangle(ElementStyle style, Rectangle bounds)
	{
		bounds.X += style.MarginLeft;
		bounds.Width -= style.MarginLeft + style.MarginRight;
		bounds.Y += style.MarginTop;
		bounds.Height -= style.MarginTop + style.MarginBottom;
		return bounds;
	}

	private static Rectangle smethod_7(ElementStyle elementStyle_0, Rectangle rectangle_0)
	{
		rectangle_0 = GetBackgroundRectangle(elementStyle_0, rectangle_0);
		if (elementStyle_0.Boolean_2)
		{
			if (elementStyle_0.BorderRightWidth <= 1)
			{
				rectangle_0.Width -= elementStyle_0.BorderRightWidth;
			}
			else
			{
				rectangle_0.Width -= elementStyle_0.BorderRightWidth / 2;
			}
		}
		if (elementStyle_0.Boolean_4)
		{
			if (elementStyle_0.BorderBottomWidth <= 1)
			{
				rectangle_0.Height -= elementStyle_0.BorderBottomWidth;
			}
			else
			{
				rectangle_0.Height -= elementStyle_0.BorderBottomWidth / 2;
			}
		}
		if (elementStyle_0.Boolean_1 && elementStyle_0.BorderLeftWidth > 1)
		{
			rectangle_0.X += elementStyle_0.BorderLeftWidth / 2;
			rectangle_0.Width -= elementStyle_0.BorderLeftWidth / 2;
		}
		if (elementStyle_0.Boolean_3 && elementStyle_0.BorderTopWidth > 1)
		{
			rectangle_0.Y += elementStyle_0.BorderTopWidth / 2;
			rectangle_0.Height -= elementStyle_0.BorderTopWidth / 2;
		}
		return rectangle_0;
	}

	private static Rectangle smethod_8(ElementStyle elementStyle_0, Rectangle rectangle_0)
	{
		rectangle_0 = GetBackgroundRectangle(elementStyle_0, rectangle_0);
		rectangle_0.X += elementStyle_0.PaddingLeft;
		rectangle_0.Width -= elementStyle_0.PaddingLeft + elementStyle_0.PaddingRight;
		rectangle_0.Y += elementStyle_0.PaddingTop;
		rectangle_0.Height -= elementStyle_0.PaddingTop + elementStyle_0.PaddingBottom;
		return rectangle_0;
	}

	public static GraphicsPath GetBackgroundPath(ElementStyle style, Rectangle bounds)
	{
		return GetBackgroundPath(style, bounds, eStyleBackgroundPathPart.Complete);
	}

	public static GraphicsPath GetBackgroundPath(ElementStyle style, Rectangle bounds, eStyleBackgroundPathPart pathPart)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		Rectangle backgroundRectangle = GetBackgroundRectangle(style, bounds);
		if (pathPart == eStyleBackgroundPathPart.Complete && style.CornerTypeBottomLeft == eCornerType.Inherit && style.CornerTypeBottomRight == eCornerType.Inherit && style.CornerTypeTopLeft == eCornerType.Inherit && style.CornerTypeTopRight == eCornerType.Inherit)
		{
			switch (style.CornerType)
			{
			case eCornerType.Square:
				val.AddRectangle(backgroundRectangle);
				break;
			case eCornerType.Rounded:
			{
				Struct10 @struct = smethod_10(backgroundRectangle, style.CornerDiameter, Enum14.const_0);
				val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
				@struct = smethod_10(backgroundRectangle, style.CornerDiameter, Enum14.const_1);
				val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
				@struct = smethod_10(backgroundRectangle, style.CornerDiameter, Enum14.const_3);
				val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
				@struct = smethod_10(backgroundRectangle, style.CornerDiameter, Enum14.const_2);
				val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
				val.CloseAllFigures();
				break;
			}
			case eCornerType.Diagonal:
				val.AddLine(backgroundRectangle.X, backgroundRectangle.Bottom - style.CornerDiameter - 1, backgroundRectangle.X, backgroundRectangle.Y + style.CornerDiameter);
				val.AddLine(backgroundRectangle.X + style.CornerDiameter, backgroundRectangle.Y, backgroundRectangle.Right - style.CornerDiameter, backgroundRectangle.Y);
				val.AddLine(backgroundRectangle.Right, backgroundRectangle.Y + style.CornerDiameter, backgroundRectangle.Right, backgroundRectangle.Bottom - style.CornerDiameter - 1);
				val.AddLine(backgroundRectangle.Right - style.CornerDiameter - 1, backgroundRectangle.Bottom, backgroundRectangle.X + style.CornerDiameter, backgroundRectangle.Bottom);
				val.CloseAllFigures();
				break;
			}
		}
		else
		{
			switch (pathPart)
			{
			case eStyleBackgroundPathPart.TopHalf:
				backgroundRectangle.Height /= 2;
				break;
			case eStyleBackgroundPathPart.BottomHalf:
			{
				int height = backgroundRectangle.Height;
				backgroundRectangle.Height /= 2;
				backgroundRectangle.Y += height - backgroundRectangle.Height - 1;
				break;
			}
			}
			eCornerType eCornerType2 = style.CornerTypeTopLeft;
			if (eCornerType2 == eCornerType.Inherit)
			{
				eCornerType2 = style.CornerType;
			}
			if (pathPart == eStyleBackgroundPathPart.BottomHalf)
			{
				eCornerType2 = eCornerType.Square;
			}
			switch (eCornerType2)
			{
			case eCornerType.Rounded:
			{
				Struct10 struct2 = smethod_10(backgroundRectangle, style.CornerDiameter, Enum14.const_0);
				val.AddArc(struct2.int_0, struct2.int_1, struct2.int_2, struct2.int_3, struct2.float_0, struct2.float_1);
				break;
			}
			case eCornerType.Diagonal:
				val.AddLine(backgroundRectangle.X, backgroundRectangle.Y + style.CornerDiameter, backgroundRectangle.X + style.CornerDiameter, backgroundRectangle.Y);
				break;
			default:
				val.AddLine(backgroundRectangle.X, backgroundRectangle.Y + 2, backgroundRectangle.X, backgroundRectangle.Y);
				val.AddLine(backgroundRectangle.X, backgroundRectangle.Y, backgroundRectangle.X + 2, backgroundRectangle.Y);
				break;
			}
			eCornerType2 = style.CornerTypeTopRight;
			if (eCornerType2 == eCornerType.Inherit)
			{
				eCornerType2 = style.CornerType;
			}
			if (pathPart == eStyleBackgroundPathPart.BottomHalf)
			{
				eCornerType2 = eCornerType.Square;
			}
			switch (eCornerType2)
			{
			case eCornerType.Rounded:
			{
				Struct10 struct3 = smethod_10(backgroundRectangle, style.CornerDiameter, Enum14.const_1);
				val.AddArc(struct3.int_0, struct3.int_1, struct3.int_2, struct3.int_3, struct3.float_0, struct3.float_1);
				break;
			}
			case eCornerType.Diagonal:
				val.AddLine(backgroundRectangle.Right - style.CornerDiameter - 1, backgroundRectangle.Y, backgroundRectangle.Right, backgroundRectangle.Y + style.CornerDiameter);
				break;
			default:
				val.AddLine(backgroundRectangle.Right - 2, backgroundRectangle.Y, backgroundRectangle.Right, backgroundRectangle.Y);
				val.AddLine(backgroundRectangle.Right, backgroundRectangle.Y, backgroundRectangle.Right, backgroundRectangle.Y + 2);
				break;
			}
			eCornerType2 = style.CornerTypeBottomRight;
			if (eCornerType2 == eCornerType.Inherit)
			{
				eCornerType2 = style.CornerType;
			}
			if (pathPart == eStyleBackgroundPathPart.TopHalf)
			{
				eCornerType2 = eCornerType.Square;
			}
			switch (eCornerType2)
			{
			case eCornerType.Rounded:
			{
				Struct10 struct4 = smethod_10(backgroundRectangle, style.CornerDiameter, Enum14.const_3);
				val.AddArc(struct4.int_0, struct4.int_1, struct4.int_2, struct4.int_3, struct4.float_0, struct4.float_1);
				break;
			}
			case eCornerType.Diagonal:
				val.AddLine(backgroundRectangle.Right, backgroundRectangle.Bottom - style.CornerDiameter - 1, backgroundRectangle.Right - style.CornerDiameter - 1, backgroundRectangle.Bottom);
				break;
			default:
				val.AddLine(backgroundRectangle.Right, backgroundRectangle.Bottom - 2, backgroundRectangle.Right, backgroundRectangle.Bottom);
				val.AddLine(backgroundRectangle.Right, backgroundRectangle.Bottom, backgroundRectangle.Right - 2, backgroundRectangle.Bottom);
				break;
			}
			eCornerType2 = style.CornerTypeBottomLeft;
			if (eCornerType2 == eCornerType.Inherit)
			{
				eCornerType2 = style.CornerType;
			}
			if (pathPart == eStyleBackgroundPathPart.TopHalf)
			{
				eCornerType2 = eCornerType.Square;
			}
			switch (eCornerType2)
			{
			case eCornerType.Rounded:
			{
				Struct10 struct5 = smethod_10(backgroundRectangle, style.CornerDiameter, Enum14.const_2);
				val.AddArc(struct5.int_0, struct5.int_1, struct5.int_2, struct5.int_3, struct5.float_0, struct5.float_1);
				break;
			}
			case eCornerType.Diagonal:
				val.AddLine(backgroundRectangle.X + 2, backgroundRectangle.Bottom, backgroundRectangle.X, backgroundRectangle.Bottom - style.CornerDiameter - 1);
				break;
			default:
				val.AddLine(backgroundRectangle.X + 2, backgroundRectangle.Bottom, backgroundRectangle.X, backgroundRectangle.Bottom);
				val.AddLine(backgroundRectangle.X, backgroundRectangle.Bottom, backgroundRectangle.X, backgroundRectangle.Bottom - 2);
				break;
			}
		}
		return val;
	}

	internal static void smethod_9(GraphicsPath graphicsPath_0, Rectangle rectangle_0, int int_0, Enum14 enum14_0)
	{
		Struct10 @struct = smethod_10(rectangle_0, int_0, enum14_0);
		graphicsPath_0.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
	}

	internal static Struct10 smethod_10(Rectangle rectangle_0, int int_0, Enum14 enum14_0)
	{
		if (int_0 == 0)
		{
			int_0 = 1;
		}
		int num = int_0 * 2;
		return enum14_0 switch
		{
			Enum14.const_0 => new Struct10(rectangle_0.X, rectangle_0.Y, num, num, 180f, 90f), 
			Enum14.const_1 => new Struct10(rectangle_0.Right - num, rectangle_0.Y, num, num, 270f, 90f), 
			Enum14.const_2 => new Struct10(rectangle_0.X, rectangle_0.Bottom - num, num, num, 90f, 90f), 
			_ => new Struct10(rectangle_0.Right - num, rectangle_0.Bottom - num, num, num, 0f, 90f), 
		};
	}
}
