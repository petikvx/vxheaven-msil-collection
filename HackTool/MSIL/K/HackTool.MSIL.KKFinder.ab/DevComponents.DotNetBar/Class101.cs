using System.Drawing;

namespace DevComponents.DotNetBar;

internal class Class101
{
	private enum Enum17
	{
		const_0,
		const_1,
		const_2
	}

	private enum Enum18
	{
		const_0,
		const_1,
		const_2
	}

	internal static void smethod_0(Class100 class100_0)
	{
		Size size = Size.Empty;
		Font val = class100_0.font_0;
		int num = 0;
		if (class100_0.elementStyle_0.Font != null)
		{
			val = class100_0.elementStyle_0.Font;
		}
		if (class100_0.isimpleElement_0.FixedWidth == 0)
		{
			if (class100_0.isimpleElement_0.TextVisible)
			{
				string text = class100_0.isimpleElement_0.Text;
				if (text != "")
				{
					size = Class55.smethod_3(class100_0.graphics_0, text, val);
					if (class100_0.elementStyle_0 != null && !class100_0.elementStyle_0.TextShadowColor.IsEmpty && !class100_0.elementStyle_0.TextShadowOffset.IsEmpty)
					{
						size.Height += class100_0.elementStyle_0.TextShadowOffset.Y;
					}
				}
			}
		}
		else
		{
			int num2 = class100_0.isimpleElement_0.FixedWidth - Class52.smethod_1(class100_0.elementStyle_0);
			if (class100_0.isimpleElement_0.ImageVisible)
			{
				num2 -= class100_0.isimpleElement_0.ImageLayoutSize.Width;
			}
			if (class100_0.isimpleElement_0.TextVisible)
			{
				int num3 = val.get_Height();
				if (class100_0.elementStyle_0 != null && !class100_0.elementStyle_0.TextShadowColor.IsEmpty && !class100_0.elementStyle_0.TextShadowOffset.IsEmpty)
				{
					num3 += class100_0.elementStyle_0.TextShadowOffset.Y;
				}
				if (class100_0.elementStyle_0.WordWrap)
				{
					num3 = class100_0.elementStyle_0.MaximumHeight - class100_0.elementStyle_0.MarginTop - class100_0.elementStyle_0.MarginBottom - class100_0.elementStyle_0.PaddingTop - class100_0.elementStyle_0.PaddingBottom;
					if (num2 > 0)
					{
						size = ((num3 <= 0) ? Class55.smethod_4(class100_0.graphics_0, class100_0.isimpleElement_0.Text, val, num2, class100_0.elementStyle_0.ETextFormat_0) : Class55.smethod_6(class100_0.graphics_0, class100_0.isimpleElement_0.Text, val, new Size(num2, num3), class100_0.elementStyle_0.ETextFormat_0));
					}
				}
				else
				{
					size = new Size(num2, num3);
				}
			}
		}
		if (class100_0.isimpleElement_0.TextVisible && !class100_0.elementStyle_0.TextShadowColor.IsEmpty)
		{
			size.Height += class100_0.elementStyle_0.TextShadowOffset.Y;
		}
		num = size.Height;
		if (class100_0.bool_1)
		{
			if (class100_0.isimpleElement_0.ImageVisible && class100_0.isimpleElement_0.ImageLayoutSize.Height > 0)
			{
				num += class100_0.isimpleElement_0.ImageLayoutSize.Height;
			}
		}
		else if (class100_0.isimpleElement_0.ImageVisible && class100_0.isimpleElement_0.ImageLayoutSize.Height > num)
		{
			num = class100_0.isimpleElement_0.ImageLayoutSize.Height;
		}
		Rectangle rectangle_ = new Rectangle(class100_0.int_0 + Class52.smethod_3(class100_0.elementStyle_0), class100_0.int_1 + Class52.smethod_7(class100_0.elementStyle_0), class100_0.isimpleElement_0.FixedWidth - Class52.smethod_1(class100_0.elementStyle_0), num);
		if (rectangle_.Width == 0)
		{
			if (class100_0.bool_1)
			{
				if (class100_0.isimpleElement_0.TextVisible)
				{
					rectangle_.Width = size.Width;
				}
				if (class100_0.isimpleElement_0.ImageVisible && class100_0.isimpleElement_0.ImageLayoutSize.Width > rectangle_.Width)
				{
					rectangle_.Width = class100_0.isimpleElement_0.ImageLayoutSize.Width + class100_0.isimpleElement_0.ImageTextSpacing;
				}
			}
			else
			{
				if (class100_0.isimpleElement_0.TextVisible)
				{
					rectangle_.Width = size.Width;
				}
				if (class100_0.isimpleElement_0.ImageVisible && class100_0.isimpleElement_0.ImageLayoutSize.Width > 0)
				{
					rectangle_.Width += class100_0.isimpleElement_0.ImageLayoutSize.Width + class100_0.isimpleElement_0.ImageTextSpacing;
				}
			}
		}
		Rectangle bounds = new Rectangle(class100_0.int_0, class100_0.int_1, class100_0.isimpleElement_0.FixedWidth, rectangle_.Height + class100_0.elementStyle_0.MarginTop + class100_0.elementStyle_0.MarginBottom + class100_0.elementStyle_0.PaddingTop + class100_0.elementStyle_0.PaddingBottom);
		if (bounds.Width == 0)
		{
			bounds.Width = rectangle_.Width + Class52.smethod_1(class100_0.elementStyle_0);
		}
		class100_0.isimpleElement_0.Bounds = bounds;
		if (class100_0.isimpleElement_0.ImageVisible && !class100_0.isimpleElement_0.ImageLayoutSize.IsEmpty)
		{
			Enum17 enum17_ = smethod_4(class100_0.isimpleElement_0.ImageAlignment);
			Enum18 enum18_ = smethod_3(class100_0.isimpleElement_0.ImageAlignment, class100_0.bool_0);
			if (class100_0.bool_1)
			{
				class100_0.isimpleElement_0.ImageBounds = smethod_2(class100_0.isimpleElement_0.ImageLayoutSize, ref rectangle_, enum18_, enum17_, class100_0.isimpleElement_0.ImageTextSpacing);
			}
			else
			{
				class100_0.isimpleElement_0.ImageBounds = smethod_1(class100_0.isimpleElement_0.ImageLayoutSize, ref rectangle_, enum18_, enum17_, class100_0.isimpleElement_0.ImageTextSpacing);
			}
		}
		else
		{
			class100_0.isimpleElement_0.ImageBounds = Rectangle.Empty;
		}
		if (!size.IsEmpty)
		{
			class100_0.isimpleElement_0.TextBounds = rectangle_;
		}
		else
		{
			class100_0.isimpleElement_0.TextBounds = Rectangle.Empty;
		}
	}

	private static Rectangle smethod_1(Size size_0, ref Rectangle rectangle_0, Enum18 enum18_0, Enum17 enum17_0, int int_0)
	{
		Rectangle result = new Rectangle(Point.Empty, size_0);
		if (enum18_0 == Enum18.const_2)
		{
			result.X = rectangle_0.Right - result.Width;
			rectangle_0.Width -= result.Width + int_0;
		}
		else
		{
			result.X = rectangle_0.X;
			rectangle_0.X = result.Right + int_0;
			rectangle_0.Width -= result.Width + int_0;
		}
		switch (enum17_0)
		{
		case Enum17.const_0:
			result.Y = rectangle_0.Y;
			break;
		case Enum17.const_1:
			result.Y = rectangle_0.Y + (rectangle_0.Height - result.Height) / 2;
			break;
		case Enum17.const_2:
			result.Y = rectangle_0.Bottom - result.Height;
			break;
		}
		return result;
	}

	private static Rectangle smethod_2(Size size_0, ref Rectangle rectangle_0, Enum18 enum18_0, Enum17 enum17_0, int int_0)
	{
		Rectangle result = new Rectangle(Point.Empty, size_0);
		switch (enum18_0)
		{
		case Enum18.const_0:
			result.X = rectangle_0.X;
			break;
		case Enum18.const_1:
			result.X = rectangle_0.X + (rectangle_0.Width - result.Width) / 2;
			break;
		case Enum18.const_2:
			result.X = rectangle_0.Right - result.Width;
			break;
		}
		if (enum17_0 == Enum17.const_2)
		{
			result.Y = rectangle_0.Bottom - result.Height;
			rectangle_0.Height -= result.Height + int_0;
		}
		else
		{
			result.Y = rectangle_0.Y;
			rectangle_0.Y = result.Bottom + int_0;
			rectangle_0.Height -= result.Height + int_0;
		}
		return result;
	}

	private static Enum18 smethod_3(eSimplePartAlignment eSimplePartAlignment_0, bool bool_0)
	{
		if (((eSimplePartAlignment_0 != eSimplePartAlignment.NearBottom && eSimplePartAlignment_0 != 0 && eSimplePartAlignment_0 != eSimplePartAlignment.NearTop) || !bool_0) && ((eSimplePartAlignment_0 != eSimplePartAlignment.FarBottom && eSimplePartAlignment_0 != eSimplePartAlignment.FarCenter && eSimplePartAlignment_0 != eSimplePartAlignment.FarTop) || bool_0))
		{
			if (eSimplePartAlignment_0 != eSimplePartAlignment.CenterBottom && eSimplePartAlignment_0 != eSimplePartAlignment.CenterTop)
			{
				return Enum18.const_2;
			}
			return Enum18.const_1;
		}
		return Enum18.const_0;
	}

	private static Enum17 smethod_4(eSimplePartAlignment eSimplePartAlignment_0)
	{
		Enum17 result = Enum17.const_1;
		switch (eSimplePartAlignment_0)
		{
		case eSimplePartAlignment.NearTop:
		case eSimplePartAlignment.CenterTop:
		case eSimplePartAlignment.FarTop:
			result = Enum17.const_0;
			break;
		case eSimplePartAlignment.NearBottom:
		case eSimplePartAlignment.CenterBottom:
		case eSimplePartAlignment.FarBottom:
			result = Enum17.const_2;
			break;
		}
		return result;
	}
}
