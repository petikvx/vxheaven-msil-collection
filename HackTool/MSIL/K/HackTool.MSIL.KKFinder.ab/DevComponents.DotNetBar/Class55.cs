using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class55
{
	public static bool bool_0;

	public static bool bool_1;

	internal static bool bool_2;

	static Class55()
	{
		bool_0 = true;
		bool_1 = false;
		bool_2 = false;
		switch (Application.get_CurrentCulture().TwoLetterISOLanguageName)
		{
		case "ja":
		case "ko":
		case "zh":
		case "ar":
			bool_2 = true;
			break;
		}
	}

	public static void smethod_0(Graphics graphics_0, string string_0, Font font_0, Color color_0, int int_0, int int_1, eTextFormat eTextFormat_0)
	{
		smethod_1(graphics_0, string_0, font_0, color_0, new Rectangle(int_0, int_1, 0, 0), eTextFormat_0);
	}

	public static void smethod_1(Graphics graphics_0, string string_0, Font font_0, Color color_0, Rectangle rectangle_0, eTextFormat eTextFormat_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (bool_1 && (eTextFormat_0 & eTextFormat.Vertical) == 0)
		{
			TextRenderer.DrawText((IDeviceContext)(object)graphics_0, string_0, font_0, rectangle_0, color_0, smethod_10(eTextFormat_0));
		}
		else
		{
			smethod_2(graphics_0, string_0, font_0, color_0, rectangle_0, eTextFormat_0);
		}
	}

	public static void smethod_2(Graphics graphics_0, string string_0, Font font_0, Color color_0, Rectangle rectangle_0, eTextFormat eTextFormat_0)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		if (!color_0.IsEmpty && bool_0)
		{
			SolidBrush val = new SolidBrush(color_0);
			try
			{
				graphics_0.DrawString(string_0, font_0, (Brush)(object)val, (RectangleF)rectangle_0, smethod_11(eTextFormat_0));
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	public static Size smethod_3(Graphics graphics_0, string string_0, Font font_0)
	{
		return smethod_6(graphics_0, string_0, font_0, Size.Empty, eTextFormat.Default);
	}

	public static Size smethod_4(Graphics graphics_0, string string_0, Font font_0, int int_0, eTextFormat eTextFormat_0)
	{
		return smethod_6(graphics_0, string_0, font_0, new Size(int_0, 0), eTextFormat_0);
	}

	public static Size smethod_5(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		return smethod_6(graphics_0, string_0, font_0, new Size(int_0, 0), eTextFormat.Default);
	}

	public static Size smethod_6(Graphics graphics_0, string string_0, Font font_0, Size size_0, eTextFormat eTextFormat_0)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (bool_1 && (eTextFormat_0 & eTextFormat.Vertical) == 0)
		{
			eTextFormat_0 &= ~(eTextFormat_0 & eTextFormat.VerticalCenter);
			eTextFormat_0 &= ~(eTextFormat_0 & eTextFormat.Bottom);
			eTextFormat_0 &= ~(eTextFormat_0 & eTextFormat.HorizontalCenter);
			eTextFormat_0 &= ~(eTextFormat_0 & eTextFormat.Right);
			eTextFormat_0 &= ~(eTextFormat_0 & eTextFormat.EndEllipsis);
			return TextRenderer.MeasureText((IDeviceContext)(object)graphics_0, string_0, font_0, size_0, smethod_10(eTextFormat_0));
		}
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, (SizeF)size_0, smethod_11(eTextFormat_0)));
	}

	public static Size smethod_7(Graphics graphics_0, string string_0, Font font_0, Size size_0, eTextFormat eTextFormat_0)
	{
		return graphics_0.MeasureString(string_0, font_0, (SizeF)size_0, smethod_11(eTextFormat_0)).ToSize();
	}

	public static eTextFormat smethod_8(StringAlignment stringAlignment_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)stringAlignment_0 == 1)
		{
			return eTextFormat.HorizontalCenter;
		}
		if ((int)stringAlignment_0 == 2)
		{
			return eTextFormat.Right;
		}
		return eTextFormat.Default;
	}

	public static eTextFormat smethod_9(StringAlignment stringAlignment_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)stringAlignment_0 == 1)
		{
			return eTextFormat.VerticalCenter;
		}
		if ((int)stringAlignment_0 == 2)
		{
			return eTextFormat.Bottom;
		}
		return eTextFormat.Default;
	}

	private static TextFormatFlags smethod_10(eTextFormat eTextFormat_0)
	{
		eTextFormat_0 |= eTextFormat.PreserveGraphicsClipping | eTextFormat.PreserveGraphicsTranslateTransform;
		if ((eTextFormat_0 & eTextFormat.SingleLine) == eTextFormat.SingleLine && (eTextFormat_0 & eTextFormat.WordBreak) == eTextFormat.WordBreak)
		{
			eTextFormat_0 &= ~(eTextFormat_0 & eTextFormat.SingleLine);
		}
		return (TextFormatFlags)eTextFormat_0;
	}

	public static StringFormat smethod_11(eTextFormat eTextFormat_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		StringFormat val = new StringFormat(bool_2 ? StringFormat.get_GenericDefault() : StringFormat.get_GenericTypographic());
		if (eTextFormat_0 == eTextFormat.Default)
		{
			return val;
		}
		if ((eTextFormat_0 & eTextFormat.HorizontalCenter) == eTextFormat.HorizontalCenter)
		{
			val.set_Alignment((StringAlignment)1);
		}
		else if ((eTextFormat_0 & eTextFormat.Right) == eTextFormat.Right)
		{
			val.set_Alignment((StringAlignment)2);
		}
		if ((eTextFormat_0 & eTextFormat.VerticalCenter) == eTextFormat.VerticalCenter)
		{
			val.set_LineAlignment((StringAlignment)1);
		}
		else if ((eTextFormat_0 & eTextFormat.Bottom) == eTextFormat.Bottom)
		{
			val.set_LineAlignment((StringAlignment)2);
		}
		if ((eTextFormat_0 & eTextFormat.EndEllipsis) == eTextFormat.EndEllipsis)
		{
			val.set_Trimming((StringTrimming)3);
		}
		else
		{
			val.set_Trimming((StringTrimming)1);
		}
		if ((eTextFormat_0 & eTextFormat.HidePrefix) == eTextFormat.HidePrefix)
		{
			val.set_HotkeyPrefix((HotkeyPrefix)2);
		}
		else if ((eTextFormat_0 & eTextFormat.NoPrefix) == eTextFormat.NoPrefix)
		{
			val.set_HotkeyPrefix((HotkeyPrefix)0);
		}
		else
		{
			val.set_HotkeyPrefix((HotkeyPrefix)1);
		}
		if ((eTextFormat_0 & eTextFormat.WordBreak) == eTextFormat.WordBreak)
		{
			val.set_FormatFlags((StringFormatFlags)(val.get_FormatFlags() & ~(val.get_FormatFlags() & 0x1000)));
		}
		else
		{
			val.set_FormatFlags((StringFormatFlags)(val.get_FormatFlags() | 0x1000));
		}
		if ((eTextFormat_0 & eTextFormat.LeftAndRightPadding) == eTextFormat.LeftAndRightPadding)
		{
			val.set_FormatFlags((StringFormatFlags)(val.get_FormatFlags() | 0x800));
		}
		if ((eTextFormat_0 & eTextFormat.RightToLeft) == eTextFormat.RightToLeft)
		{
			val.set_FormatFlags((StringFormatFlags)(val.get_FormatFlags() | 1));
		}
		if ((eTextFormat_0 & eTextFormat.Vertical) == eTextFormat.Vertical)
		{
			val.set_FormatFlags((StringFormatFlags)(val.get_FormatFlags() | 2));
		}
		return val;
	}

	public static Enum10 smethod_12(eTextFormat eTextFormat_0)
	{
		Enum10 @enum = Enum10.const_0;
		if (eTextFormat_0 == eTextFormat.Default)
		{
			return @enum;
		}
		if ((eTextFormat_0 & eTextFormat.HorizontalCenter) == eTextFormat.HorizontalCenter)
		{
			@enum |= Enum10.const_2;
		}
		else if ((eTextFormat_0 & eTextFormat.Right) == eTextFormat.Right)
		{
			@enum |= Enum10.const_3;
		}
		if ((eTextFormat_0 & eTextFormat.VerticalCenter) == eTextFormat.VerticalCenter)
		{
			@enum |= Enum10.const_4;
		}
		else if ((eTextFormat_0 & eTextFormat.Bottom) == eTextFormat.Bottom)
		{
			@enum |= Enum10.const_5;
		}
		if ((eTextFormat_0 & eTextFormat.EndEllipsis) == eTextFormat.EndEllipsis)
		{
			@enum |= Enum10.const_17;
		}
		if ((eTextFormat_0 & eTextFormat.HidePrefix) == eTextFormat.HidePrefix)
		{
			@enum |= Enum10.const_22;
		}
		else if ((eTextFormat_0 & eTextFormat.NoPrefix) == eTextFormat.NoPrefix)
		{
			@enum |= Enum10.const_13;
		}
		@enum = (((eTextFormat_0 & eTextFormat.WordBreak) != eTextFormat.WordBreak) ? (@enum | Enum10.const_7) : (@enum | Enum10.const_6));
		if ((eTextFormat_0 & eTextFormat.RightToLeft) == eTextFormat.RightToLeft)
		{
			@enum |= Enum10.const_19;
		}
		return @enum;
	}
}
