using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class61 : Class58
{
	protected override string ThemeClass => "TOOLTIP";

	public Class61(Control parent)
		: base(parent)
	{
	}

	public void method_0(Graphics graphics_0, Class120 class120_0, Class151 class151_0, Rectangle rectangle_0)
	{
		InternalDrawBackground(graphics_0, class120_0, class151_0, rectangle_0);
	}
}
