using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class RibbonBarMergeContainerDesigner : ParentControlDesigner
{
	public override DesignerVerbCollection Verbs => new DesignerVerbCollection(new DesignerVerb[1]
	{
		new DesignerVerb("Layout Ribbons", method_1)
	});

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ParentControlDesigner)this).InitializeNewComponent(defaultValues);
		method_0();
	}

	private void method_0()
	{
		if (((ControlDesigner)this).get_Control() is RibbonBarMergeContainer component)
		{
			TypeDescriptor.GetProperties(component)["Visible"]!.SetValue(component, false);
			TypeDescriptor.GetProperties(component)["ColorSchemeStyle"]!.SetValue(component, eDotNetBarStyle.Office2007);
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		if (!(((ControlDesigner)this).get_Control() is RibbonPanel ribbonPanel))
		{
			return;
		}
		IDesignerHost designerHost = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		DesignerTransaction designerTransaction = null;
		if (designerHost != null)
		{
			designerTransaction = designerHost.CreateTransaction("Rendering Layout");
		}
		try
		{
			ribbonPanel.method_8();
		}
		finally
		{
			designerTransaction?.Commit();
		}
	}
}
