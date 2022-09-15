using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class60 : Class58
{
	protected override string ThemeClass => "TASKBAR";

	public Class60(Control parent)
		: base(parent)
	{
	}

	public void method_0(Graphics graphics_0, Class121 class121_0, Class147 class147_0, Rectangle rectangle_0)
	{
		InternalDrawBackground(graphics_0, class121_0, class147_0, rectangle_0);
	}
}
