using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class64 : Class58
{
	protected override string ThemeClass => "PROGRESS";

	public Class64(Control parent)
		: base(parent)
	{
	}

	public void method_0(Graphics graphics_0, Class141 class141_0, Class166 class166_0, Rectangle rectangle_0)
	{
		InternalDrawBackground(graphics_0, class141_0, class166_0, rectangle_0);
	}
}
