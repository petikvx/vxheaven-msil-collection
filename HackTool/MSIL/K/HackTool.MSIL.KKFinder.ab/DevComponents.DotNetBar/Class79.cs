using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class79 : Class58
{
	protected override string ThemeClass => "Toolbar";

	public Class79(Control parent)
		: base(parent)
	{
	}

	public void method_0(Graphics graphics_0, Class140 class140_0, Class162 class162_0, Rectangle rectangle_0)
	{
		InternalDrawBackground(graphics_0, class140_0, class162_0, rectangle_0);
	}

	public void method_1(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Class140 class140_0, Class162 class162_0, Enum10 enum10_0, bool bool_1)
	{
		InternalDrawText(graphics_0, string_0, font_0, rectangle_0, class140_0, class162_0, enum10_0, bool_1);
	}

	public void method_2(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Class140 class140_0, Class162 class162_0, Enum10 enum10_0)
	{
		InternalDrawText(graphics_0, string_0, font_0, rectangle_0, class140_0, class162_0, enum10_0, drawdisabled: false);
	}

	public void method_3(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Class140 class140_0, Class162 class162_0)
	{
		InternalDrawText(graphics_0, string_0, font_0, rectangle_0, class140_0, class162_0, Enum10.const_0, drawdisabled: false);
	}
}
