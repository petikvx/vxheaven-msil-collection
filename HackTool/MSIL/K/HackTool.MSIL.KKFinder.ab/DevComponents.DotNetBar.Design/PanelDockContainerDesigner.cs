using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class PanelDockContainerDesigner : PanelExDesigner
{
	public override SelectionRules SelectionRules => (SelectionRules)(-1073741824);

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		base.InitializeNewComponent(defaultValues);
		method_5();
	}

	private void method_5()
	{
		if (((ControlDesigner)this).get_Control() is PanelDockContainer panelDockContainer)
		{
			panelDockContainer.ApplyLabelStyle();
			((Control)panelDockContainer).set_Text("");
		}
	}
}
