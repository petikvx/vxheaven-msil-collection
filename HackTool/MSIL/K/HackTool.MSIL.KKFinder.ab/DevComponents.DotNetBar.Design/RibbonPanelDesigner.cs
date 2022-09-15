using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class RibbonPanelDesigner : PanelControlDesigner
{
	public override SelectionRules SelectionRules => (SelectionRules)(-1073741824);

	public override DesignerVerbCollection Verbs => new DesignerVerbCollection(new DesignerVerb[2]
	{
		new DesignerVerb("Create RibbonBar", method_4),
		new DesignerVerb("Layout Ribbons", method_3)
	});

	protected override void SetDesignTimeDefaults()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		RibbonPanel ribbonPanel = ((ControlDesigner)this).get_Control() as RibbonPanel;
		((Control)ribbonPanel).set_Padding(new Padding(3, 0, 3, 3));
	}

	private void method_3(object sender, EventArgs e)
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

	private void method_4(object sender, EventArgs e)
	{
		if (!(((ControlDesigner)this).get_Control() is RibbonPanel ribbonPanel))
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Create Default Ribbon Bar");
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		try
		{
			RibbonBar ribbonBar = designerHost.CreateComponent(typeof(RibbonBar)) as RibbonBar;
			TypeDescriptor.GetProperties(ribbonBar)["Width"]!.SetValue(ribbonBar, 100);
			TypeDescriptor.GetProperties(ribbonBar)["Text"]!.SetValue(ribbonBar, ((Control)ribbonBar).get_Name());
			componentChangeService.OnComponentChanging(ribbonPanel, TypeDescriptor.GetProperties(typeof(Control))["Controls"]);
			((Control)ribbonPanel).get_Controls().Add((Control)(object)ribbonBar);
			((Control)ribbonBar).set_Dock((DockStyle)3);
			((Control)ribbonBar).BringToFront();
			componentChangeService.OnComponentChanged(ribbonPanel, TypeDescriptor.GetProperties(typeof(Control))["Controls"], null, null);
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected override void DrawBorder(Graphics g)
	{
	}
}
