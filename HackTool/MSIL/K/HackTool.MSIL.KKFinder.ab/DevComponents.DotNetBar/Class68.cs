using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class68 : Class58
{
	protected override string ThemeClass => "LISTVIEW";

	public Class68(Control parent)
		: base(parent)
	{
	}

	public void method_0(Graphics graphics_0, Class132 class132_0, Class156 class156_0, Rectangle rectangle_0)
	{
		InternalDrawBackground(graphics_0, class132_0, class156_0, rectangle_0);
	}
}
