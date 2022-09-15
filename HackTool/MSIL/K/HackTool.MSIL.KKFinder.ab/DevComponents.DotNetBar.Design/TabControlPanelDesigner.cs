using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class TabControlPanelDesigner : PanelExDesigner
{
	public override SelectionRules SelectionRules => (SelectionRules)(-1073741824);

	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] value = new DesignerVerb[3]
			{
				new DesignerVerb("Next Tab", method_6),
				new DesignerVerb("Previous Tab", method_7),
				new DesignerVerb("Create New Tab", CreateNewTab)
			};
			return new DesignerVerbCollection(value);
		}
	}

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

	protected virtual void CreateNewTab(object sender, EventArgs e)
	{
		if (!(((ControlDesigner)this).get_Control() is TabControlPanel tabControlPanel) || !(((Control)tabControlPanel).get_Parent() is TabControl))
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (!(((Control)tabControlPanel).get_Parent() is TabControl tabControl) || designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction();
		try
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), null);
			TabItem tabItem = designerHost.CreateComponent(typeof(TabItem)) as TabItem;
			tabItem.Text = tabItem.Name;
			TabControlPanel tabControlPanel2 = designerHost.CreateComponent(typeof(TabControlPanel)) as TabControlPanel;
			tabControl.ApplyDefaultPanelStyle(tabControlPanel2);
			tabItem.AttachedControl = (Control)(object)tabControlPanel2;
			tabControlPanel2.TabItem = tabItem;
			tabControl.Tabs.Add(tabItem);
			((Control)tabControl).get_Controls().Add((Control)(object)tabControlPanel2);
			((Control)tabControlPanel2).set_Dock((DockStyle)5);
			((Control)tabControlPanel2).SendToBack();
			tabControl.RecalcLayout();
			tabControl.SelectedTab = tabItem;
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), null, null, null);
			if (componentChangeService != null)
			{
				componentChangeService.OnComponentChanging(tabControlPanel2, null);
				componentChangeService.OnComponentChanged(tabControlPanel2, null, null, null);
			}
		}
		catch
		{
			designerTransaction.Cancel();
		}
		finally
		{
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is TabControlPanel tabControlPanel && ((Control)tabControlPanel).get_Parent() is TabControl)
		{
			TabControl tabControl = ((Control)tabControlPanel).get_Parent() as TabControl;
			tabControl.SelectNextTab();
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is TabControlPanel tabControlPanel && ((Control)tabControlPanel).get_Parent() is TabControl)
		{
			TabControl tabControl = ((Control)tabControlPanel).get_Parent() as TabControl;
			tabControl.SelectPreviousTab();
		}
	}
}
