using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class78 : Class58
{
	protected override string ThemeClass => "REBAR";

	public Class78(Control parent)
		: base(parent)
	{
	}

	public void method_0(Graphics graphics_0, Class139 class139_0, Class164 class164_0, Rectangle rectangle_0)
	{
		InternalDrawBackground(graphics_0, class139_0, class164_0, rectangle_0);
	}
}
