using System.ComponentModel;
using System.Drawing;

namespace DevComponents.DotNetBar.ScrollBar;

[ToolboxBitmap(typeof(HScrollBarAdv), "ScrollBar.HScrollBarAdv.ico")]
[ToolboxItem(true)]
public class HScrollBarAdv : ScrollBarAdv
{
	protected override bool IsVertical()
	{
		return false;
	}
}
