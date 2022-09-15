using System;
using System.Drawing;
using Microsoft.Win32;

namespace DevComponents.DotNetBar;

public class ColorFunctions
{
	public struct HLSColor
	{
		public double Hue;

		public double Lightness;

		public double Saturation;
	}

	private static Color color_0;

	private static Color color_1;

	private static Color color_2;

	private static Color color_3;

	private static Color color_4;

	private static Color color_5;

	private static Color color_6;

	private static Color color_7;

	private static Color color_8;

	private static Color color_9;

	private static Bitmap bitmap_0;

	internal static bool bool_0;

	public static void LoadColors()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		smethod_1();
		if (!bool_0)
		{
			SystemEvents.add_UserPreferenceChanged(new UserPreferenceChangedEventHandler(smethod_0));
		}
		bool_0 = true;
	}

	private static void smethod_0(object sender, UserPreferenceChangedEventArgs e)
	{
		smethod_1();
		Class92.smethod_5();
		Class109.smethod_54();
	}

	private static void smethod_1()
	{
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		if (Class92.int_74 >= 16)
		{
			int red = (int)((double)(SystemColors.Highlight.R - SystemColors.Window.R) * 0.3 + (double)(int)SystemColors.Window.R);
			int green = (int)((double)(SystemColors.Highlight.G - SystemColors.Window.G) * 0.3 + (double)(int)SystemColors.Window.G);
			int blue = (int)((double)(SystemColors.Highlight.B - SystemColors.Window.B) * 0.3 + (double)(int)SystemColors.Window.B);
			color_0 = Color.FromArgb(red, green, blue);
			red = (int)((double)(SystemColors.Highlight.R - SystemColors.Window.R) * 0.45 + (double)(int)SystemColors.Window.R);
			green = (int)((double)(SystemColors.Highlight.G - SystemColors.Window.G) * 0.45 + (double)(int)SystemColors.Window.G);
			blue = (int)((double)(SystemColors.Highlight.B - SystemColors.Window.B) * 0.45 + (double)(int)SystemColors.Window.B);
			color_1 = Color.FromArgb(red, green, blue);
			red = (int)((double)(SystemColors.Highlight.R - SystemColors.Window.R) * 0.1 + (double)(int)SystemColors.Window.R);
			green = (int)((double)(SystemColors.Highlight.G - SystemColors.Window.G) * 0.1 + (double)(int)SystemColors.Window.G);
			blue = (int)((double)(SystemColors.Highlight.B - SystemColors.Window.B) * 0.1 + (double)(int)SystemColors.Window.B);
			color_2 = Color.FromArgb(red, green, blue);
			red = (int)((double)(SystemColors.Highlight.R - SystemColors.Window.R) * 0.25 + (double)(int)SystemColors.Window.R);
			green = (int)((double)(SystemColors.Highlight.G - SystemColors.Window.G) * 0.25 + (double)(int)SystemColors.Window.G);
			blue = (int)((double)(SystemColors.Highlight.B - SystemColors.Window.B) * 0.25 + (double)(int)SystemColors.Window.B);
			color_3 = Color.FromArgb(red, green, blue);
			if (Class92.int_74 <= 16)
			{
				color_4 = SystemColors.ControlLightLight;
			}
			else
			{
				red = (int)((double)(SystemColors.Control.R - Color.White.R) * 0.2 + (double)(int)Color.White.R);
				green = (int)((double)(SystemColors.Control.G - Color.White.G) * 0.2 + (double)(int)Color.White.G);
				blue = (int)((double)(SystemColors.Control.B - Color.White.B) * 0.2 + (double)(int)Color.White.B);
				color_4 = Color.FromArgb(red, green, blue);
			}
			red = (int)((double)(int)SystemColors.ControlDark.R * 0.8);
			green = (int)((double)(int)SystemColors.ControlDark.G * 0.8);
			blue = (int)((double)(int)SystemColors.ControlDark.B * 0.8);
			color_5 = Color.FromArgb(red, green, blue);
			red = (int)((double)(SystemColors.Highlight.R - SystemColors.Window.R) * 0.25 + (double)(int)SystemColors.Window.R);
			green = (int)((double)(SystemColors.Highlight.G - SystemColors.Window.G) * 0.25 + (double)(int)SystemColors.Window.G);
			blue = (int)((double)(SystemColors.Highlight.B - SystemColors.Window.B) * 0.25 + (double)(int)SystemColors.Window.B);
			color_6 = Color.FromArgb(red, green, blue);
			red = (int)((double)(SystemColors.Control.R - Color.White.R) * 0.8 + (double)(int)Color.White.R);
			green = (int)((double)(SystemColors.Control.G - Color.White.G) * 0.8 + (double)(int)Color.White.G);
			blue = (int)((double)(SystemColors.Control.B - Color.White.B) * 0.8 + (double)(int)Color.White.B);
			color_7 = Color.FromArgb(red, green, blue);
			red = (int)((double)(SystemColors.Control.R - Color.White.R) * 0.5 + (double)(int)Color.White.R);
			green = (int)((double)(SystemColors.Control.G - Color.White.G) * 0.5 + (double)(int)Color.White.G);
			blue = (int)((double)(SystemColors.Control.B - Color.White.B) * 0.5 + (double)(int)Color.White.B);
			color_9 = Color.FromArgb(red, green, blue);
			color_8 = SystemColors.Control;
		}
		else
		{
			color_0 = SystemColors.ControlLightLight;
			color_1 = color_0;
			color_2 = color_0;
			color_3 = SystemColors.ControlLight;
			color_4 = SystemColors.ControlLightLight;
			color_5 = SystemColors.ControlDark;
			color_6 = SystemColors.ControlLight;
			color_7 = SystemColors.ControlLight;
			color_9 = SystemColors.ControlLight;
			color_8 = SystemColors.Control;
		}
		if (bitmap_0 != null)
		{
			((Image)bitmap_0).Dispose();
			bitmap_0 = new Bitmap(2, 2);
			bitmap_0.SetPixel(0, 0, SystemColors.Control);
			bitmap_0.SetPixel(1, 0, SystemColors.ControlLightLight);
			bitmap_0.SetPixel(0, 1, SystemColors.ControlLightLight);
			bitmap_0.SetPixel(1, 1, SystemColors.Control);
		}
	}

	public static HLSColor RGBToHSL(int Red, int Green, int Blue)
	{
		HLSColor result = default(HLSColor);
		double num = (double)Red / 255.0;
		double num2 = (double)Green / 255.0;
		double num3 = (double)Blue / 255.0;
		double num4 = smethod_2(num, num2, num3);
		double num5 = smethod_3(num, num2, num3);
		result.Lightness = (num4 + num5) / 2.0;
		if (num4 == num5)
		{
			result.Saturation = 0.0;
			result.Hue = 0.0;
		}
		else
		{
			if (result.Lightness <= 0.5)
			{
				result.Saturation = (num4 - num5) / (num4 + num5);
			}
			else
			{
				result.Saturation = (num4 - num5) / (2.0 - num4 - num5);
			}
			double num6 = num4 - num5;
			if (num == num4)
			{
				result.Hue = (num2 - num3) / num6;
			}
			else if (num2 == num4)
			{
				result.Hue = 2.0 + (num3 - num) / num6;
			}
			else if (num3 == num4)
			{
				result.Hue = 4.0 + (num - num2) / num6;
			}
		}
		return result;
	}

	public static HLSColor RGBToHSL(Color color)
	{
		return RGBToHSL(color.R, color.G, color.B);
	}

	private static double smethod_2(double double_0, double double_1, double double_2)
	{
		double num = 0.0;
		if (double_0 > double_1)
		{
			if (double_0 > double_2)
			{
				return double_0;
			}
			return double_2;
		}
		if (double_2 > double_1)
		{
			return double_2;
		}
		return double_1;
	}

	private static double smethod_3(double double_0, double double_1, double double_2)
	{
		double num = 0.0;
		if (double_0 < double_1)
		{
			if (double_0 < double_2)
			{
				return double_0;
			}
			return double_2;
		}
		if (double_2 < double_1)
		{
			return double_2;
		}
		return double_1;
	}

	public static Color HLSToRGB(double Hue, double Lightness, double Saturation)
	{
		Color empty = Color.Empty;
		double num;
		double num2;
		double num3;
		if (Saturation == 0.0)
		{
			num = Lightness;
			num2 = Lightness;
			num3 = Lightness;
		}
		else
		{
			double num4 = ((!(Lightness <= 0.5)) ? (Lightness - Saturation * (1.0 - Lightness)) : (Lightness * (1.0 - Saturation)));
			double num5 = 2.0 * Lightness - num4;
			if (Hue < 1.0)
			{
				num = num5;
				if (Hue < 0.0)
				{
					num2 = num4;
					num3 = num2 - Hue * (num5 - num4);
				}
				else
				{
					num3 = num4;
					num2 = Hue * (num5 - num4) + num3;
				}
			}
			else if (Hue < 3.0)
			{
				num2 = num5;
				if (Hue < 2.0)
				{
					num3 = num4;
					num = num3 - (Hue - 2.0) * (num5 - num4);
				}
				else
				{
					num = num4;
					num3 = (Hue - 2.0) * (num5 - num4) + num;
				}
			}
			else
			{
				num3 = num5;
				if (Hue < 4.0)
				{
					num = num4;
					num2 = num - (Hue - 4.0) * (num5 - num4);
				}
				else
				{
					num2 = num4;
					num = (Hue - 4.0) * (num5 - num4) + num2;
				}
			}
		}
		return Color.FromArgb((int)Math.Min(num * 255.0, 255.0), (int)Math.Min(num2 * 255.0, 255.0), (int)Math.Min(num3 * 255.0, 255.0));
	}

	public static Color HLSToRGB(HLSColor clr)
	{
		return HLSToRGB(clr.Hue, clr.Lightness, clr.Saturation);
	}

	public static Color HoverBackColor()
	{
		return color_0;
	}

	public static Color HoverBackColor2()
	{
		return color_1;
	}

	public static Color HoverBackColor3()
	{
		return color_2;
	}

	public static Color HoverBackColor(Graphics g)
	{
		return g.GetNearestColor(HoverBackColor());
	}

	public static Color PressedBackColor()
	{
		return color_6;
	}

	public static Color PressedBackColor(Graphics g)
	{
		return g.GetNearestColor(PressedBackColor());
	}

	public static Color CheckBoxBackColor()
	{
		return color_3;
	}

	public static Color CheckBoxBackColor(Graphics g)
	{
		return g.GetNearestColor(CheckBoxBackColor());
	}

	public static Color ToolMenuFocusBackColor()
	{
		return color_7;
	}

	public static Color RecentlyUsedOfficeBackColor()
	{
		return color_9;
	}

	public static Color RecentlyUsedOfficeBackColor(Graphics g)
	{
		return g.GetNearestColor(RecentlyUsedOfficeBackColor());
	}

	public static Color SideRecentlyBackColor(Graphics g)
	{
		return g.GetNearestColor(SideRecentlyBackColor());
	}

	public static Color SideRecentlyBackColor()
	{
		return color_8;
	}

	public static Color ToolMenuFocusBackColor(Graphics g)
	{
		return g.GetNearestColor(ToolMenuFocusBackColor());
	}

	public static Color MenuFocusBorderColor()
	{
		return color_5;
	}

	public static Color MenuFocusBorderColor(Graphics g)
	{
		return g.GetNearestColor(MenuFocusBorderColor());
	}

	public static Color MenuBackColor()
	{
		return color_4;
	}

	public static Color MenuBackColor(Graphics g)
	{
		return g.GetNearestColor(MenuBackColor());
	}

	public static Brush GetPushedBrush(BaseItem item)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		if (item.Parent is GenericItemContainer)
		{
			if (!((GenericItemContainer)item.Parent).m_BackgroundColor.IsEmpty)
			{
				return (Brush)new SolidBrush(((GenericItemContainer)item.Parent).m_BackgroundColor);
			}
		}
		else if (item.Parent is SideBarPanelItem)
		{
			if (((SideBarPanelItem)item.Parent).BackgroundStyle.ShouldSerializeBackColor1())
			{
				return (Brush)new SolidBrush(((SideBarPanelItem)item.Parent).BackgroundStyle.BackColor1.Color);
			}
			if (((SideBarPanelItem)item.Parent).BackgroundStyle.ShouldSerializeBackColor1())
			{
				return (Brush)new SolidBrush(((SideBarPanelItem)item.Parent).BackgroundStyle.BackColor1.Color);
			}
		}
		return (Brush)(object)GetPushedBrush();
	}

	public static TextureBrush GetPushedBrush()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		if (bitmap_0 == null)
		{
			bitmap_0 = new Bitmap(2, 2);
			bitmap_0.SetPixel(0, 0, SystemColors.Control);
			bitmap_0.SetPixel(1, 0, SystemColors.ControlLightLight);
			bitmap_0.SetPixel(0, 1, SystemColors.ControlLightLight);
			bitmap_0.SetPixel(1, 1, SystemColors.Control);
		}
		return new TextureBrush((Image)(object)bitmap_0);
	}
}
