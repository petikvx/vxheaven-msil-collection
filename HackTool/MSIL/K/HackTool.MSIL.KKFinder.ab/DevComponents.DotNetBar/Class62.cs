using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class62 : Class58
{
	protected override string ThemeClass => "TASKBAND";

	public Class62(Control parent)
		: base(parent)
	{
	}

	public void method_0(Graphics graphics_0, Class122 class122_0, Class146 class146_0, Rectangle rectangle_0)
	{
		InternalDrawBackground(graphics_0, class122_0, class146_0, rectangle_0);
	}
}
