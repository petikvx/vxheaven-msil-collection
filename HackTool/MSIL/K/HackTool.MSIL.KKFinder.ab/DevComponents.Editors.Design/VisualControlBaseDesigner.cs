using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.Editors.Design;

public class VisualControlBaseDesigner : ControlDesigner
{
	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		if (((ControlDesigner)this).get_Control() is VisualControlBase visualControlBase)
		{
			((Control)visualControlBase).set_Height(visualControlBase.PreferredHeight);
		}
		((ControlDesigner)this).InitializeNewComponent(defaultValues);
	}
}
