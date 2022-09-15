using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class TabStripDesigner : ParentControlDesigner
{
	protected bool m_InternalRemove;

	private TabItem tabItem_0;

	private bool bool_0;

	private bool bool_1;

	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] value = new DesignerVerb[3]
			{
				new DesignerVerb("Next Tab", method_0),
				new DesignerVerb("Previous Tab", method_1),
				new DesignerVerb("Create New Tab", CreateNewTab)
			};
			return new DesignerVerbCollection(value);
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether Tab-Strip control provides Tabbed MDI Child form support.")]
	[Category("Mdi Support")]
	public bool MdiTabbedDocuments
	{
		get
		{
			return (bool)((ComponentDesigner)this).get_ShadowProperties().get_Item("MdiTabbedDocuments");
		}
		set
		{
			IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
			DesignerTransaction designerTransaction = null;
			if (designerHost != null)
			{
				designerTransaction = designerHost.CreateTransaction();
			}
			try
			{
				((ComponentDesigner)this).get_ShadowProperties().set_Item("MdiTabbedDocuments", (object)value);
				if (((ControlDesigner)this).get_Control() is TabStrip component && designerHost != null && !designerHost.Loading)
				{
					if (value)
					{
						TypeDescriptor.GetProperties(component)["MdiForm"]!.SetValue(component, null);
						IComponent rootComponent = designerHost.RootComponent;
						Form value2 = (Form)((rootComponent is Form) ? rootComponent : null);
						TypeDescriptor.GetProperties(component)["MdiForm"]!.SetValue(component, value2);
					}
					else
					{
						TypeDescriptor.GetProperties(component)["MdiForm"]!.SetValue(component, null);
					}
				}
			}
			catch
			{
				designerTransaction?.Cancel();
				throw;
			}
			finally
			{
				if (designerTransaction != null && !designerTransaction.Canceled)
				{
					designerTransaction.Commit();
				}
			}
		}
	}

	public override ICollection AssociatedComponents
	{
		get
		{
			ArrayList arrayList = new ArrayList(((ControlDesigner)this).get_AssociatedComponents());
			TabStrip tabStrip = GetTabStrip();
			if (tabStrip != null)
			{
				foreach (TabItem tab in tabStrip.Tabs)
				{
					arrayList.Add(tab);
				}
				return arrayList;
			}
			return arrayList;
		}
	}

	public override void Initialize(IComponent component)
	{
		((ParentControlDesigner)this).Initialize(component);
		if (component.Site!.DesignMode)
		{
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null)
			{
				selectionService.SelectionChanged += method_3;
			}
			IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
			if (componentChangeService != null)
			{
				componentChangeService.ComponentRemoving += method_4;
			}
			TabStrip tabStrip = GetTabStrip();
			if (tabStrip != null)
			{
				tabStrip.TabMoved += method_2;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null)
		{
			selectionService.SelectionChanged -= method_3;
		}
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		if (componentChangeService != null)
		{
			componentChangeService.ComponentRemoving -= method_4;
		}
		((ParentControlDesigner)this).Dispose(disposing);
	}

	protected virtual void CreateNewTab(object sender, EventArgs e)
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (!(((ControlDesigner)this).get_Control() is TabStrip tabStrip) || designerHost == null)
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
			tabStrip.Tabs.Add(tabItem);
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), null, null, null);
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

	private void method_0(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is TabStrip tabStrip && tabStrip.SelectedTabIndex < tabStrip.Tabs.Count - 1)
		{
			TypeDescriptor.GetProperties(tabStrip)["SelectedTabIndex"]!.SetValue(tabStrip, tabStrip.SelectedTabIndex + 1);
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is TabStrip tabStrip && tabStrip.SelectedTabIndex > 0)
		{
			TypeDescriptor.GetProperties(tabStrip)["SelectedTabIndex"]!.SetValue(tabStrip, tabStrip.SelectedTabIndex - 1);
		}
	}

	private void method_2(object sender, TabStripTabMovedEventArgs e)
	{
		if (((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) is IComponentChangeService componentChangeService)
		{
			componentChangeService.OnComponentChanging(((ControlDesigner)this).get_Control(), null);
			componentChangeService.OnComponentChanged(((ControlDesigner)this).get_Control(), null, null, null);
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		TabStrip tabStrip = GetTabStrip();
		if (tabStrip != null && !((Control)tabStrip).get_IsDisposed())
		{
			ISelectionService selectionService = (ISelectionService)sender;
			if (selectionService != null && selectionService.PrimarySelection != ((ControlDesigner)this).get_Control() && selectionService.PrimarySelection is TabItem && tabStrip.Tabs.Contains(selectionService.PrimarySelection as TabItem))
			{
				tabStrip.TabItem_0 = selectionService.PrimarySelection as TabItem;
			}
			else
			{
				tabStrip.TabItem_0 = null;
			}
		}
	}

	private void method_4(object sender, ComponentEventArgs e)
	{
		InternalComponentRemoving(e);
	}

	protected virtual void InternalComponentRemoving(ComponentEventArgs e)
	{
		if (m_InternalRemove)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		TabStrip tabStrip = GetTabStrip();
		if (tabStrip == null || ((Control)tabStrip).get_IsDisposed())
		{
			return;
		}
		if (e.Component is TabItem && ((ControlDesigner)this).get_Control() != null && tabStrip.Tabs.Contains(e.Component as TabItem))
		{
			try
			{
				TabItem tabItem = e.Component as TabItem;
				if (tabItem.AttachedControl != null && ((ControlDesigner)this).get_Control().get_Controls().Contains(tabItem.AttachedControl))
				{
					((ControlDesigner)this).get_Control().get_Controls().Remove(tabItem.AttachedControl);
					designerHost.DestroyComponent((IComponent)tabItem.AttachedControl);
				}
				tabStrip.Tabs.Remove(tabItem);
				tabStrip.RecalcSize();
				((Control)tabStrip).Refresh();
				return;
			}
			finally
			{
				m_InternalRemove = false;
			}
		}
		if (e.Component != ((ControlDesigner)this).get_Control())
		{
			return;
		}
		m_InternalRemove = true;
		try
		{
			TabStrip tabStrip2 = ((ControlDesigner)this).get_Control() as TabStrip;
			TabItem[] array = new TabItem[tabStrip2.Tabs.Count];
			tabStrip2.Tabs.CopyTo(array, 0);
			TabItem[] array2 = array;
			foreach (TabItem component in array2)
			{
				designerHost.DestroyComponent(component);
			}
		}
		finally
		{
			m_InternalRemove = false;
		}
	}

	protected virtual TabStrip GetTabStrip()
	{
		return ((ControlDesigner)this).get_Control() as TabStrip;
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ParentControlDesigner)this).PreFilterProperties(properties);
		if (((ControlDesigner)this).get_Control() is TabStrip)
		{
			properties["MdiTabbedDocuments"] = TypeDescriptor.CreateProperty(typeof(TabStripDesigner), (PropertyDescriptor)properties["MdiTabbedDocuments"], new DefaultValueAttribute(value: false));
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ParentControlDesigner)this).InitializeNewComponent(defaultValues);
		method_5();
	}

	private void method_5()
	{
		if (((ComponentDesigner)this).get_Component() != null && ((ComponentDesigner)this).get_Component().Site != null && ((ComponentDesigner)this).get_Component().Site!.DesignMode)
		{
			if (((ControlDesigner)this).get_Control() is TabStrip tabStrip)
			{
				tabStrip.Style = eTabStripStyle.VS2005;
			}
			CreateNewTab(null, null);
		}
	}

	protected override void WndProc(ref Message m)
	{
		Control control = ((ControlDesigner)this).get_Control();
		if (control != null && !control.get_IsDisposed())
		{
			switch (((Message)(ref m)).get_Msg())
			{
			case 1125:
				if (OnProcessPendingSelection(ref m))
				{
					return;
				}
				break;
			case 675:
				if (OnMouseLeave(ref m))
				{
					return;
				}
				break;
			case 512:
				if (OnMouseMove(ref m))
				{
					return;
				}
				break;
			case 513:
			case 516:
				if (OnMouseDown(ref m))
				{
					return;
				}
				break;
			case 514:
			case 517:
				if (OnMouseUp(ref m))
				{
					return;
				}
				break;
			}
			((ControlDesigner)this).WndProc(ref m);
		}
		else
		{
			((ControlDesigner)this).WndProc(ref m);
		}
	}

	protected virtual bool OnMouseDown(ref Message m)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		TabStrip tabStrip = GetTabStrip();
		if (tabStrip != null && !((Control)tabStrip).get_IsDisposed() && !((ControlDesigner)this).get_Control().get_IsDisposed())
		{
			Point point = ((Control)tabStrip).PointToClient(Control.get_MousePosition());
			MouseEventArgs val = new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0);
			TabItem selectedTab = tabStrip.SelectedTab;
			tabStrip.method_31(val);
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			TabItem tabItem = null;
			if (selectionService != null && selectionService.PrimarySelection is TabItem)
			{
				tabItem = selectionService.PrimarySelection as TabItem;
			}
			if (tabStrip.SelectedTab != null && tabItem != tabStrip.SelectedTab && tabStrip.HitTest(val.get_X(), val.get_Y()) != null)
			{
				ArrayList arrayList = new ArrayList(1);
				arrayList.Add(tabStrip.SelectedTab);
				selectionService.SetSelectedComponents(arrayList, SelectionTypes.Click);
				bool_0 = true;
				if (((Message)(ref m)).get_Msg() == 516)
				{
					((ControlDesigner)this).OnContextMenu(Control.get_MousePosition().X, Control.get_MousePosition().Y);
				}
				return true;
			}
			if (tabStrip.SelectedTab == selectedTab && tabStrip.HitTest(val.get_X(), val.get_Y()) != null)
			{
				if (((Message)(ref m)).get_Msg() == 516)
				{
					((ControlDesigner)this).OnContextMenu(Control.get_MousePosition().X, Control.get_MousePosition().Y);
				}
				return true;
			}
			return false;
		}
		return false;
	}

	protected virtual bool OnMouseUp(ref Message m)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		TabStrip tabStrip = GetTabStrip();
		if (tabStrip != null && !((Control)tabStrip).get_IsDisposed() && !((ControlDesigner)this).get_Control().get_IsDisposed())
		{
			Point point = ((Control)tabStrip).PointToClient(Control.get_MousePosition());
			MouseEventArgs mouseEventArgs_ = new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0);
			tabStrip.method_38(mouseEventArgs_);
			if (bool_0)
			{
				bool_0 = false;
				return true;
			}
			if (bool_1)
			{
				bool_1 = false;
				ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
				if (selectionService != null && selectionService.PrimarySelection != ((ControlDesigner)this).get_Control() && (object)selectionService.PrimarySelection.GetType() != ((object)((ControlDesigner)this).get_Control()).GetType())
				{
					ArrayList arrayList = new ArrayList(1);
					arrayList.Add(((ControlDesigner)this).get_Control());
					selectionService.SetSelectedComponents(arrayList, SelectionTypes.Click);
				}
			}
			return false;
		}
		return false;
	}

	protected virtual bool OnMouseMove(ref Message m)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		TabStrip tabStrip = GetTabStrip();
		if (tabStrip != null && !((Control)tabStrip).get_IsDisposed() && !((ControlDesigner)this).get_Control().get_IsDisposed())
		{
			Point pt = ((Control)tabStrip).PointToClient(Control.get_MousePosition());
			MouseEventArgs mouseEventArgs_ = new MouseEventArgs((MouseButtons)((((Message)(ref m)).get_WParam().ToInt32() == 1) ? 1048576 : 0), 0, pt.X, pt.Y, 0);
			tabStrip.method_34(mouseEventArgs_);
			if (((Control)tabStrip).get_DisplayRectangle().Contains(pt))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	protected virtual bool OnMouseLeave(ref Message m)
	{
		TabStrip tabStrip = GetTabStrip();
		if (tabStrip != null && !((Control)tabStrip).get_IsDisposed() && !((ControlDesigner)this).get_Control().get_IsDisposed())
		{
			tabStrip.method_39(new EventArgs());
			return false;
		}
		return false;
	}

	protected virtual bool OnProcessPendingSelection(ref Message m)
	{
		return ProcessPendingSelection();
	}

	protected virtual bool ProcessPendingSelection()
	{
		TabStrip tabStrip = GetTabStrip();
		if (tabStrip != null && !((Control)tabStrip).get_IsDisposed() && !((ControlDesigner)this).get_Control().get_IsDisposed())
		{
			if (tabItem_0 != null)
			{
				tabStrip.TabItem_0 = tabItem_0;
				ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
				if (selectionService == null)
				{
					return false;
				}
				ArrayList arrayList = new ArrayList(1);
				arrayList.Add(tabItem_0);
				selectionService.SetSelectedComponents(arrayList, SelectionTypes.Click);
				tabItem_0 = null;
				if (((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) is IComponentChangeService componentChangeService)
				{
					componentChangeService.OnComponentChanging(((ControlDesigner)this).get_Control(), null);
					componentChangeService.OnComponentChanged(((ControlDesigner)this).get_Control(), null, null, null);
				}
				return true;
			}
			return false;
		}
		return false;
	}
}
