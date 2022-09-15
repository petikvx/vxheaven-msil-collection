using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class77 : Class58
{
	protected override string ThemeClass => "WINDOW";

	public Class77(Control parent)
		: base(parent)
	{
	}

	public void method_0(Graphics graphics_0, Class124 class124_0, Class149 class149_0, Rectangle rectangle_0)
	{
		InternalDrawBackground(graphics_0, class124_0, class149_0, rectangle_0);
	}

	public void method_1(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Class124 class124_0, Class149 class149_0, Enum10 enum10_0, bool bool_1)
	{
		InternalDrawText(graphics_0, string_0, font_0, rectangle_0, class124_0, class149_0, enum10_0, bool_1);
	}

	public void method_2(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Class124 class124_0, Class149 class149_0, Enum10 enum10_0)
	{
		InternalDrawText(graphics_0, string_0, font_0, rectangle_0, class124_0, class149_0, enum10_0, drawdisabled: false);
	}

	public void method_3(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Class124 class124_0, Class149 class149_0)
	{
		InternalDrawText(graphics_0, string_0, font_0, rectangle_0, class124_0, class149_0, Enum10.const_0, drawdisabled: false);
	}

	public void method_4(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Class118 class118_0, Class143 class143_0, Enum10 enum10_0, DTTOPTS dttopts_0)
	{
		InternalDrawTextEx(graphics_0, string_0, font_0, rectangle_0, class118_0, class143_0, enum10_0, dttopts_0);
	}

	public IntPtr method_5(Graphics graphics_0, Class124 class124_0, Class149 class149_0, Rectangle rectangle_0)
	{
		return InternalGetThemeBackgroundRegion(graphics_0, class124_0, class149_0, rectangle_0);
	}
}
