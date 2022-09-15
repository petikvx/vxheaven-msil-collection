using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class NavigationPanePanelDesigner : PanelExDesigner
{
	public override SelectionRules SelectionRules => (SelectionRules)(-1073741824);

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		base.InitializeNewComponent(defaultValues);
		method_5();
	}

	private void method_5()
	{
		if (((ControlDesigner)this).get_Control() is PanelEx panelEx)
		{
			panelEx.ApplyLabelStyle();
			((Control)panelEx).set_Text("");
		}
	}
}
