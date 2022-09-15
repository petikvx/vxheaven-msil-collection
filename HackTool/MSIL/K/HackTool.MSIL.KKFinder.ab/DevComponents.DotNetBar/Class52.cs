using System.Drawing;

namespace DevComponents.DotNetBar;

internal class Class52
{
	public static void smethod_0(ElementStyle elementStyle_0, Font font_0)
	{
		int num = font_0.get_Height();
		ElementStyle elementStyle = ElementStyleDisplay.smethod_5(elementStyle_0);
		if (elementStyle.Font != null)
		{
			num = elementStyle.Font.get_Height();
		}
		if (elementStyle.Boolean_3)
		{
			num += elementStyle.BorderTopWidth;
		}
		if (elementStyle.Boolean_4)
		{
			num += elementStyle.BorderBottomWidth;
		}
		num += elementStyle.MarginTop + elementStyle_0.MarginBottom;
		num += elementStyle.PaddingTop + elementStyle.PaddingBottom;
		elementStyle_0.method_0(new Size(0, num));
	}

	public static int smethod_1(ElementStyle elementStyle_0)
	{
		return smethod_3(elementStyle_0) + smethod_5(elementStyle_0);
	}

	public static int smethod_2(ElementStyle elementStyle_0)
	{
		return smethod_7(elementStyle_0) + smethod_9(elementStyle_0);
	}

	public static int smethod_3(ElementStyle elementStyle_0)
	{
		return smethod_11(elementStyle_0, eSpacePart.Padding | eSpacePart.Border | eSpacePart.Margin, eStyleSide.Left);
	}

	public static int smethod_4(ElementStyle elementStyle_0, eSpacePart eSpacePart_0)
	{
		return smethod_11(elementStyle_0, eSpacePart_0, eStyleSide.Left);
	}

	public static int smethod_5(ElementStyle elementStyle_0)
	{
		return smethod_11(elementStyle_0, eSpacePart.Padding | eSpacePart.Border | eSpacePart.Margin, eStyleSide.Right);
	}

	public static int smethod_6(ElementStyle elementStyle_0, eSpacePart eSpacePart_0)
	{
		return smethod_11(elementStyle_0, eSpacePart_0, eStyleSide.Right);
	}

	public static int smethod_7(ElementStyle elementStyle_0)
	{
		return smethod_11(elementStyle_0, eSpacePart.Padding | eSpacePart.Border | eSpacePart.Margin, eStyleSide.Top);
	}

	public static int smethod_8(ElementStyle elementStyle_0, eSpacePart eSpacePart_0)
	{
		return smethod_11(elementStyle_0, eSpacePart_0, eStyleSide.Top);
	}

	public static int smethod_9(ElementStyle elementStyle_0)
	{
		return smethod_11(elementStyle_0, eSpacePart.Padding | eSpacePart.Border | eSpacePart.Margin, eStyleSide.Bottom);
	}

	public static int smethod_10(ElementStyle elementStyle_0, eSpacePart eSpacePart_0)
	{
		return smethod_11(elementStyle_0, eSpacePart_0, eStyleSide.Bottom);
	}

	public static int smethod_11(ElementStyle elementStyle_0, eSpacePart eSpacePart_0, eStyleSide eStyleSide_0)
	{
		ElementStyle elementStyle = ElementStyleDisplay.smethod_5(elementStyle_0);
		int num = 0;
		if ((eSpacePart_0 & eSpacePart.Margin) == eSpacePart.Margin)
		{
			switch (eStyleSide_0)
			{
			case eStyleSide.Left:
				num += elementStyle.MarginLeft;
				break;
			case eStyleSide.Right:
				num += elementStyle.MarginRight;
				break;
			case eStyleSide.Top:
				num += elementStyle.MarginTop;
				break;
			case eStyleSide.Bottom:
				num += elementStyle.MarginBottom;
				break;
			}
		}
		if ((eSpacePart_0 & eSpacePart.Padding) == eSpacePart.Padding)
		{
			switch (eStyleSide_0)
			{
			case eStyleSide.Left:
				num += elementStyle.PaddingLeft;
				break;
			case eStyleSide.Right:
				num += elementStyle.PaddingRight;
				break;
			case eStyleSide.Top:
				num += elementStyle.PaddingTop;
				break;
			case eStyleSide.Bottom:
				num += elementStyle.PaddingBottom;
				break;
			}
		}
		if ((eSpacePart_0 & eSpacePart.Border) == eSpacePart.Border)
		{
			switch (eStyleSide_0)
			{
			case eStyleSide.Left:
				if (elementStyle.Boolean_1)
				{
					num += elementStyle.BorderLeftWidth;
				}
				if (elementStyle.BorderLeft == eStyleBorderType.Etched || elementStyle.BorderLeft == eStyleBorderType.Double)
				{
					num += elementStyle.BorderLeftWidth;
				}
				break;
			case eStyleSide.Right:
				if (elementStyle.Boolean_2)
				{
					num += elementStyle.BorderRightWidth;
				}
				if (elementStyle.BorderRight == eStyleBorderType.Etched || elementStyle.BorderRight == eStyleBorderType.Double)
				{
					num += elementStyle.BorderRightWidth;
				}
				break;
			case eStyleSide.Top:
				if (elementStyle.Boolean_3)
				{
					num += elementStyle.BorderTopWidth;
				}
				if (elementStyle.BorderTop == eStyleBorderType.Etched || elementStyle.BorderTop == eStyleBorderType.Double)
				{
					num += elementStyle.BorderTopWidth;
				}
				break;
			case eStyleSide.Bottom:
				if (elementStyle.Boolean_4)
				{
					num += elementStyle.BorderBottomWidth;
				}
				if (elementStyle.BorderBottom == eStyleBorderType.Etched || elementStyle.BorderBottom == eStyleBorderType.Double)
				{
					num += elementStyle.BorderBottomWidth;
				}
				break;
			}
		}
		return num;
	}

	public static Rectangle smethod_12(ElementStyle elementStyle_0, Rectangle rectangle_0)
	{
		rectangle_0.X += smethod_3(elementStyle_0);
		rectangle_0.Width -= smethod_1(elementStyle_0);
		rectangle_0.Y += smethod_7(elementStyle_0);
		rectangle_0.Height -= smethod_2(elementStyle_0);
		return rectangle_0;
	}
}
