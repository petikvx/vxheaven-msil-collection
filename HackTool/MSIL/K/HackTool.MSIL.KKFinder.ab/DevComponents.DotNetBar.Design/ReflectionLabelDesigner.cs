using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar.Controls;

namespace DevComponents.DotNetBar.Design;

public class ReflectionLabelDesigner : ControlDesigner
{
	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ControlDesigner)this).InitializeNewComponent(defaultValues);
		SetDesignTimeDefaults();
	}

	protected virtual void SetDesignTimeDefaults()
	{
		ReflectionLabel reflectionLabel = ((ControlDesigner)this).get_Control() as ReflectionLabel;
		((Control)reflectionLabel).set_Text("<b><font size=\"+6\"><i>Dev</i><font color=\"#B02B2C\">Components</font></font></b>");
	}
}
