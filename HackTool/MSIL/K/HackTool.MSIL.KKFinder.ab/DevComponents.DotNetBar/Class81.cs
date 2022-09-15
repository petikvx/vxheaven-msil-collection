using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class81 : Class58
{
	protected override string ThemeClass => "EXPLORERBAR";

	public Class81(Control parent)
		: base(parent)
	{
	}

	public void method_0(Graphics graphics_0, Class123 class123_0, Class165 class165_0, Rectangle rectangle_0)
	{
		InternalDrawBackground(graphics_0, class123_0, class165_0, rectangle_0);
	}

	public void method_1(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Class123 class123_0, Class165 class165_0, Enum10 enum10_0, bool bool_1)
	{
		InternalDrawText(graphics_0, string_0, font_0, rectangle_0, class123_0, class165_0, enum10_0, bool_1);
	}

	public void method_2(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Class123 class123_0, Class165 class165_0, Enum10 enum10_0)
	{
		InternalDrawText(graphics_0, string_0, font_0, rectangle_0, class123_0, class165_0, enum10_0, drawdisabled: false);
	}

	public void method_3(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Class123 class123_0, Class165 class165_0)
	{
		InternalDrawText(graphics_0, string_0, font_0, rectangle_0, class123_0, class165_0, Enum10.const_0, drawdisabled: false);
	}
}
