using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class80 : Class58
{
	protected override string ThemeClass => "TREEVIEW";

	public Class80(Control parent)
		: base(parent)
	{
	}

	public void method_0(Graphics graphics_0, Class128 class128_0, Class153 class153_0, Rectangle rectangle_0)
	{
		InternalDrawBackground(graphics_0, class128_0, class153_0, rectangle_0);
	}
}
