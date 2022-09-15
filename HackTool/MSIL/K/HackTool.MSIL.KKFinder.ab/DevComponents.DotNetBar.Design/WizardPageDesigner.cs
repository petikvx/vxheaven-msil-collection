using System;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class WizardPageDesigner : ScrollableControlDesigner
{
	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] array = null;
			array = new DesignerVerb[7]
			{
				new DesignerVerb("Create Inner Page", method_2),
				new DesignerVerb("Create Welcome Page", method_3),
				new DesignerVerb("Create Outer Page", method_4),
				new DesignerVerb("Delete Page", method_5),
				new DesignerVerb("Next Page", method_6),
				new DesignerVerb("Previous Page", method_7),
				new DesignerVerb("Goto Page/Change Order", method_1)
			};
			return new DesignerVerbCollection(array);
		}
	}

	public override SelectionRules SelectionRules => (SelectionRules)int.MinValue;

	private Wizard method_0()
	{
		WizardPage wizardPage = ((ControlDesigner)this).get_Control() as WizardPage;
		return ((Control)wizardPage).get_Parent() as Wizard;
	}

	private void method_1(object sender, EventArgs e)
	{
		IComponentChangeService icomponentChangeService_ = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		ISelectionService iselectionService_ = ((ComponentDesigner)this).GetService(typeof(ISelectionService)) as ISelectionService;
		WizardDesigner.smethod_0(method_0(), icomponentChangeService_, iselectionService_);
	}

	private void method_2(object sender, EventArgs e)
	{
		IDesignerHost idesignerHost_ = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		IComponentChangeService icomponentChangeService_ = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		ISelectionService iselectionService_ = ((ComponentDesigner)this).GetService(typeof(ISelectionService)) as ISelectionService;
		Wizard wizard = method_0();
		WizardDesigner.smethod_10(wizard, bool_0: true, idesignerHost_, icomponentChangeService_, iselectionService_, wizard.ButtonStyle);
	}

	private void method_3(object sender, EventArgs e)
	{
		IDesignerHost idesignerHost_ = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		IComponentChangeService icomponentChangeService_ = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		ISelectionService iselectionService_ = ((ComponentDesigner)this).GetService(typeof(ISelectionService)) as ISelectionService;
		Wizard wizard = method_0();
		WizardDesigner.smethod_9(wizard, idesignerHost_, icomponentChangeService_, iselectionService_, wizard.ButtonStyle);
	}

	private void method_4(object sender, EventArgs e)
	{
		IDesignerHost idesignerHost_ = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		IComponentChangeService icomponentChangeService_ = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		ISelectionService iselectionService_ = ((ComponentDesigner)this).GetService(typeof(ISelectionService)) as ISelectionService;
		Wizard wizard = method_0();
		WizardDesigner.smethod_10(wizard, bool_0: false, idesignerHost_, icomponentChangeService_, iselectionService_, wizard.ButtonStyle);
	}

	private void method_5(object sender, EventArgs e)
	{
		WizardPage wizardPage_ = ((ControlDesigner)this).get_Control() as WizardPage;
		IDesignerHost idesignerHost_ = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		IComponentChangeService icomponentChangeService_ = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		WizardDesigner.smethod_1(wizardPage_, idesignerHost_, icomponentChangeService_);
	}

	private void method_6(object sender, EventArgs e)
	{
		WizardDesigner.smethod_2(method_0());
	}

	private void method_7(object sender, EventArgs e)
	{
		WizardDesigner.smethod_3(method_0());
	}
}
