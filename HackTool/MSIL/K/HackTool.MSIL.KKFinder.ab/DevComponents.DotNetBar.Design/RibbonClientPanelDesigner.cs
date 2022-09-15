using System.Drawing;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.Design;

public class RibbonClientPanelDesigner : PanelControlDesigner
{
	protected override void SetDesignTimeDefaults()
	{
		if (((ControlDesigner)this).get_Control() is PanelControl panelControl)
		{
			panelControl.CanvasColor = SystemColors.Control;
			panelControl.Style.Class = ElementStyleClassKeys.RibbonClientPanelKey;
		}
	}
}
