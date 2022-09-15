using System;
using System.Drawing;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree;

public class NodeStyles
{
	private static ElementStyle elementStyle_0;

	private static ElementStyle elementStyle_1;

	private static ElementStyle elementStyle_2;

	private static ElementStyle elementStyle_3;

	private static ElementStyle elementStyle_4;

	private static ElementStyle elementStyle_5;

	private static ElementStyle elementStyle_6;

	private static ElementStyle elementStyle_7;

	private static ElementStyle elementStyle_8;

	private static ElementStyle elementStyle_9;

	private static ElementStyle elementStyle_10;

	private static ElementStyle elementStyle_11;

	private static ElementStyle elementStyle_12;

	private static ElementStyle elementStyle_13;

	private static ElementStyle elementStyle_14;

	private static ElementStyle elementStyle_15;

	private static ElementStyle elementStyle_16;

	private static ElementStyle elementStyle_17;

	private static ElementStyle elementStyle_18;

	private static ElementStyle elementStyle_19;

	public static ElementStyle Apple
	{
		get
		{
			if (elementStyle_0 == null)
			{
				elementStyle_0 = smethod_0(ePredefinedElementStyle.Apple);
			}
			return elementStyle_0;
		}
	}

	public static ElementStyle Blue
	{
		get
		{
			if (elementStyle_1 == null)
			{
				elementStyle_1 = smethod_0(ePredefinedElementStyle.Blue);
			}
			return elementStyle_1;
		}
	}

	public static ElementStyle BlueLight
	{
		get
		{
			if (elementStyle_2 == null)
			{
				elementStyle_2 = smethod_0(ePredefinedElementStyle.BlueLight);
			}
			return elementStyle_2;
		}
	}

	public static ElementStyle BlueNight
	{
		get
		{
			if (elementStyle_3 == null)
			{
				elementStyle_3 = smethod_0(ePredefinedElementStyle.BlueNight);
			}
			return elementStyle_3;
		}
	}

	public static ElementStyle BlueMist
	{
		get
		{
			if (elementStyle_4 == null)
			{
				elementStyle_4 = smethod_0(ePredefinedElementStyle.BlueMist);
			}
			return elementStyle_4;
		}
	}

	public static ElementStyle Cyan
	{
		get
		{
			if (elementStyle_5 == null)
			{
				elementStyle_5 = smethod_0(ePredefinedElementStyle.Cyan);
			}
			return elementStyle_5;
		}
	}

	public static ElementStyle Green
	{
		get
		{
			if (elementStyle_6 == null)
			{
				elementStyle_6 = smethod_0(ePredefinedElementStyle.Green);
			}
			return elementStyle_6;
		}
	}

	public static ElementStyle Lemon
	{
		get
		{
			if (elementStyle_7 == null)
			{
				elementStyle_7 = smethod_0(ePredefinedElementStyle.Lemon);
			}
			return elementStyle_7;
		}
	}

	public static ElementStyle Magenta
	{
		get
		{
			if (elementStyle_8 == null)
			{
				elementStyle_8 = smethod_0(ePredefinedElementStyle.Magenta);
			}
			return elementStyle_8;
		}
	}

	public static ElementStyle Orange
	{
		get
		{
			if (elementStyle_9 == null)
			{
				elementStyle_9 = smethod_0(ePredefinedElementStyle.Orange);
			}
			return elementStyle_9;
		}
	}

	public static ElementStyle OrangeLight
	{
		get
		{
			if (elementStyle_10 == null)
			{
				elementStyle_10 = smethod_0(ePredefinedElementStyle.OrangeLight);
			}
			return elementStyle_10;
		}
	}

	public static ElementStyle Purple
	{
		get
		{
			if (elementStyle_11 == null)
			{
				elementStyle_11 = smethod_0(ePredefinedElementStyle.Purple);
			}
			return elementStyle_11;
		}
	}

	public static ElementStyle PurpleMist
	{
		get
		{
			if (elementStyle_12 == null)
			{
				elementStyle_12 = smethod_0(ePredefinedElementStyle.PurpleMist);
			}
			return elementStyle_12;
		}
	}

	public static ElementStyle Red
	{
		get
		{
			if (elementStyle_13 == null)
			{
				elementStyle_13 = smethod_0(ePredefinedElementStyle.Red);
			}
			return elementStyle_13;
		}
	}

	public static ElementStyle Silver
	{
		get
		{
			if (elementStyle_14 == null)
			{
				elementStyle_14 = smethod_0(ePredefinedElementStyle.Silver);
			}
			return elementStyle_14;
		}
	}

	public static ElementStyle SilverMist
	{
		get
		{
			if (elementStyle_15 == null)
			{
				elementStyle_15 = smethod_0(ePredefinedElementStyle.SilverMist);
			}
			return elementStyle_15;
		}
	}

	public static ElementStyle Tan
	{
		get
		{
			if (elementStyle_16 == null)
			{
				elementStyle_16 = smethod_0(ePredefinedElementStyle.Tan);
			}
			return elementStyle_16;
		}
	}

	public static ElementStyle Teal
	{
		get
		{
			if (elementStyle_17 == null)
			{
				elementStyle_17 = smethod_0(ePredefinedElementStyle.Teal);
			}
			return elementStyle_17;
		}
	}

	public static ElementStyle Yellow
	{
		get
		{
			if (elementStyle_18 == null)
			{
				elementStyle_18 = smethod_0(ePredefinedElementStyle.Yellow);
			}
			return elementStyle_18;
		}
	}

	public static ElementStyle Gray
	{
		get
		{
			if (elementStyle_19 == null)
			{
				elementStyle_19 = smethod_0(ePredefinedElementStyle.Gray);
			}
			return elementStyle_19;
		}
	}

	private static ElementStyle smethod_0(ePredefinedElementStyle ePredefinedElementStyle_0)
	{
		Color color_ = Color.Empty;
		Color color_2 = Color.Empty;
		int int_ = 90;
		Color color_3 = Color.Black;
		Color color_4 = Color.DarkGray;
		switch (ePredefinedElementStyle_0)
		{
		case ePredefinedElementStyle.Blue:
			color_ = Color.FromArgb(221, 230, 247);
			color_2 = Color.FromArgb(138, 168, 228);
			break;
		case ePredefinedElementStyle.BlueLight:
			color_ = Color.FromArgb(255, 255, 255);
			color_2 = Color.FromArgb(210, 224, 252);
			color_3 = Color.FromArgb(69, 84, 115);
			break;
		case ePredefinedElementStyle.BlueNight:
			color_ = Color.FromArgb(77, 108, 152);
			color_2 = Color.Navy;
			color_3 = Color.White;
			color_4 = Color.Navy;
			break;
		case ePredefinedElementStyle.Yellow:
			color_ = Color.FromArgb(255, 244, 213);
			color_2 = Color.FromArgb(255, 216, 105);
			break;
		case ePredefinedElementStyle.Green:
			color_ = Color.FromArgb(234, 240, 226);
			color_2 = Color.FromArgb(183, 201, 151);
			break;
		case ePredefinedElementStyle.Red:
			color_ = Color.FromArgb(249, 225, 226);
			color_2 = Color.FromArgb(238, 149, 151);
			break;
		case ePredefinedElementStyle.Purple:
			color_ = Color.FromArgb(234, 227, 245);
			color_2 = Color.FromArgb(180, 158, 222);
			break;
		case ePredefinedElementStyle.Cyan:
			color_ = Color.FromArgb(227, 236, 243);
			color_2 = Color.FromArgb(155, 187, 210);
			break;
		case ePredefinedElementStyle.Orange:
			color_ = Color.FromArgb(252, 233, 217);
			color_2 = Color.FromArgb(246, 176, 120);
			break;
		case ePredefinedElementStyle.OrangeLight:
			color_ = Color.FromArgb(255, 239, 201);
			color_2 = Color.FromArgb(242, 210, 132);
			color_3 = Color.FromArgb(117, 83, 2);
			break;
		case ePredefinedElementStyle.Magenta:
			color_ = Color.FromArgb(243, 229, 236);
			color_2 = Color.FromArgb(213, 164, 187);
			break;
		case ePredefinedElementStyle.BlueMist:
			color_ = Color.FromArgb(227, 236, 243);
			color_2 = Color.FromArgb(155, 187, 210);
			break;
		case ePredefinedElementStyle.PurpleMist:
			color_ = Color.FromArgb(232, 227, 234);
			color_2 = Color.FromArgb(171, 156, 183);
			break;
		case ePredefinedElementStyle.Tan:
			color_ = Color.FromArgb(248, 242, 226);
			color_2 = Color.FromArgb(232, 209, 153);
			break;
		case ePredefinedElementStyle.Lemon:
			color_ = Color.FromArgb(252, 253, 215);
			color_2 = Color.FromArgb(245, 249, 111);
			break;
		case ePredefinedElementStyle.Apple:
			color_ = Color.FromArgb(232, 248, 224);
			color_2 = Color.FromArgb(173, 231, 146);
			break;
		case ePredefinedElementStyle.Teal:
			color_ = Color.FromArgb(205, 236, 240);
			color_2 = Color.FromArgb(78, 188, 202);
			break;
		case ePredefinedElementStyle.Silver:
			color_ = Color.FromArgb(225, 225, 232);
			color_2 = Color.FromArgb(149, 149, 170);
			break;
		case ePredefinedElementStyle.SilverMist:
			color_ = Color.FromArgb(243, 244, 250);
			color_2 = Color.FromArgb(155, 153, 183);
			color_3 = Color.FromArgb(87, 86, 113);
			break;
		case ePredefinedElementStyle.Gray:
			color_ = Color.White;
			color_2 = ColorScheme.GetColor("E4E4F0");
			break;
		}
		return Utilities.smethod_1(new Class25(), Enum.GetName(typeof(ePredefinedElementStyle), ePredefinedElementStyle_0), color_4, color_, color_2, int_, color_3);
	}
}
