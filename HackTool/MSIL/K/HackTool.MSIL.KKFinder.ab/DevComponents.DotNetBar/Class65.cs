using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class65 : Class58
{
	protected override string ThemeClass => "HEADER";

	public Class65(Control parent)
		: base(parent)
	{
	}

	public void method_0(Graphics graphics_0, Class125 class125_0, Class148 class148_0, Rectangle rectangle_0)
	{
		InternalDrawBackground(graphics_0, class125_0, class148_0, rectangle_0);
	}

	public void method_1(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Class125 class125_0, Class148 class148_0, Enum10 enum10_0, bool bool_1)
	{
		InternalDrawText(graphics_0, string_0, font_0, rectangle_0, class125_0, class148_0, enum10_0, bool_1);
	}

	public void method_2(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Class125 class125_0, Class148 class148_0, Enum10 enum10_0)
	{
		InternalDrawText(graphics_0, string_0, font_0, rectangle_0, class125_0, class148_0, enum10_0, drawdisabled: false);
	}

	public void method_3(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Class125 class125_0, Class148 class148_0)
	{
		InternalDrawText(graphics_0, string_0, font_0, rectangle_0, class125_0, class148_0, Enum10.const_0, drawdisabled: false);
	}
}
