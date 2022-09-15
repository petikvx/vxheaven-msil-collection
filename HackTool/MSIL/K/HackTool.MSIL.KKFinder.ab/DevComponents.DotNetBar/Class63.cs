using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class63 : Class58
{
	protected override string ThemeClass => "SCROLLBAR";

	public Class63(Control parent)
		: base(parent)
	{
	}

	public void method_0(Graphics graphics_0, Class138 class138_0, Class163 class163_0, Rectangle rectangle_0)
	{
		InternalDrawBackground(graphics_0, class138_0, class163_0, rectangle_0);
	}
}
