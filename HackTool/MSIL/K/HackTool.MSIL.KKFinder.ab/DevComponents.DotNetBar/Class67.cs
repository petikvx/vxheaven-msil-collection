using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class67 : Class58
{
	protected override string ThemeClass => "TRAYNOTIFY";

	public Class67(Control parent)
		: base(parent)
	{
	}

	public void method_0(Graphics graphics_0, Class127 class127_0, Class152 class152_0, Rectangle rectangle_0)
	{
		InternalDrawBackground(graphics_0, class127_0, class152_0, rectangle_0);
	}
}
