using System.ComponentModel;
using System.Drawing;

namespace DevComponents.DotNetBar;

[ToolboxBitmap(typeof(VScrollBarAdv), "ScrollBar.VScrollBarAdv.ico")]
[ToolboxItem(true)]
public class VScrollBarAdv : ScrollBarAdv
{
	protected override bool IsVertical()
	{
		return true;
	}
}
