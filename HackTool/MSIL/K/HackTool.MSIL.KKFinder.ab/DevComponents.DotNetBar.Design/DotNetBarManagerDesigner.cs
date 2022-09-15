using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace DevComponents.DotNetBar.Design;

public class DotNetBarManagerDesigner : ComponentDesigner, IDesignerServices
{
	private bool bool_0;

	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] value = new DesignerVerb[7]
			{
				new DesignerVerb("Create Dock Bar Left", CreateDockBarLeft),
				new DesignerVerb("Create Dock Bar Right", CreateDockBarRight),
				new DesignerVerb("Create Dock Bar Bottom", CreateDockBarBottom),
				new DesignerVerb("Create Dock Bar Top", CreateDockBarTop),
				new DesignerVerb("Create Menu Bar", CreateMenuBar),
				new DesignerVerb("Create Toolbar", CreateToolbar),
				new DesignerVerb("Enable Document Docking", OnEnableDocumentDocking)
			};
			return new DesignerVerbCollection(value);
		}
	}

	public override ICollection AssociatedComponents
	{
		get
		{
			if (!(((ComponentDesigner)this).get_Component() is DotNetBarManager dotNetBarManager))
			{
				return ((ComponentDesigner)this).get_AssociatedComponents();
			}
			ArrayList arrayList = new ArrayList(4);
			if (dotNetBarManager.TopDockSite != null)
			{
				arrayList.Add(dotNetBarManager.TopDockSite);
			}
			if (dotNetBarManager.BottomDockSite != null)
			{
				arrayList.Add(dotNetBarManager.BottomDockSite);
			}
			if (dotNetBarManager.LeftDockSite != null)
			{
				arrayList.Add(dotNetBarManager.LeftDockSite);
			}
			if (dotNetBarManager.RightDockSite != null)
			{
				arrayList.Add(dotNetBarManager.RightDockSite);
			}
			if (dotNetBarManager.DefinitionName == "")
			{
				arrayList.AddRange(dotNetBarManager.Bars);
				foreach (Bar bar in dotNetBarManager.Bars)
				{
					AddItems(bar.ItemsContainer, arrayList);
				}
				foreach (BaseItem item in dotNetBarManager.Items)
				{
					arrayList.Add(item);
					AddItems(item, arrayList);
				}
				{
					foreach (BaseItem contextMenu in dotNetBarManager.ContextMenus)
					{
						arrayList.Add(contextMenu);
						AddItems(contextMenu, arrayList);
					}
					return arrayList;
				}
			}
			return arrayList;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
			if (componentChangeService != null)
			{
				componentChangeService.ComponentRemoving -= OnComponentRemoving;
			}
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null)
			{
				selectionService.SelectionChanged -= OnSelectionChanged;
			}
		}
		((ComponentDesigner)this).Dispose(disposing);
	}

	public override void Initialize(IComponent component)
	{
		((ComponentDesigner)this).Initialize(component);
		if (component.Site!.DesignMode)
		{
			IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
			if (componentChangeService != null)
			{
				componentChangeService.ComponentRemoving += OnComponentRemoving;
			}
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null)
			{
				selectionService.SelectionChanged += OnSelectionChanged;
			}
			IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
			if (designerHost != null && designerHost.Loading)
			{
				designerHost.LoadComplete += LoadComplete;
			}
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ComponentDesigner)this).InitializeNewComponent(defaultValues);
		SetDesignTimeDefaults();
	}

	private void SetDesignTimeDefaults()
	{
		SetupDockSites();
		SetupToolbarDockSites();
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		dotNetBarManager.AutoDispatchShortcuts.Add(eShortcut.F1);
		dotNetBarManager.AutoDispatchShortcuts.Add(eShortcut.CtrlC);
		dotNetBarManager.AutoDispatchShortcuts.Add(eShortcut.CtrlA);
		dotNetBarManager.AutoDispatchShortcuts.Add(eShortcut.CtrlV);
		dotNetBarManager.AutoDispatchShortcuts.Add(eShortcut.CtrlX);
		dotNetBarManager.AutoDispatchShortcuts.Add(eShortcut.CtrlZ);
		dotNetBarManager.AutoDispatchShortcuts.Add(eShortcut.CtrlY);
		dotNetBarManager.AutoDispatchShortcuts.Add(eShortcut.Del);
		dotNetBarManager.AutoDispatchShortcuts.Add(eShortcut.Ins);
		dotNetBarManager.Style = eDotNetBarStyle.Office2003;
		dotNetBarManager.EnableFullSizeDock = false;
	}

	private void LoadComplete(object sender, EventArgs e)
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost != null && e != null)
		{
			designerHost.LoadComplete -= LoadComplete;
		}
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		LoadDefinition();
		if (dotNetBarManager.ToolbarTopDockSite == null && dotNetBarManager.ToolbarBottomDockSite == null && dotNetBarManager.ToolbarLeftDockSite == null && dotNetBarManager.ToolbarRightDockSite == null)
		{
			SetupToolbarDockSites();
		}
	}

	private void LoadDefinition()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		if (dotNetBarManager.DefinitionName.Length > 0)
		{
			DialogResult val = MessageBox.Show("DotNetBarManager needs to be upgraded to code based serialization. Please make sure that you have BACKUP of this form prior to proceeding.\r\n\r\nDo you want to proceed with the upgrade?", "DotNetBarManager Upgrade", (MessageBoxButtons)4, (MessageBoxIcon)16, (MessageBoxDefaultButton)256);
			if ((int)val == 6)
			{
				ImportDefinition(dotNetBarManager);
				dotNetBarManager.DefinitionName = "";
				MessageBox.Show("DotNetBarManager upgraded. DO NOT save this form unless you have backup.", "DotNetBarManager Upgrade", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
		}
		if (dotNetBarManager != null && !dotNetBarManager.IsDisposed && dotNetBarManager.LeftDockSite == null && dotNetBarManager.RightDockSite == null && dotNetBarManager.TopDockSite == null && dotNetBarManager.BottomDockSite == null)
		{
			dotNetBarManager.BarStreamLoad(bForceLoad: true);
		}
	}

	private void OnEditDotNetBar(object sender, EventArgs e)
	{
		if (((ComponentDesigner)this).get_Component() is DotNetBarManager dotNetBarManager)
		{
			dotNetBarManager.Customize(this);
		}
	}

	private void OnEnableDocumentDocking(object sender, EventArgs e)
	{
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		if (dotNetBarManager.FillDockSite != null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		IComponent rootComponent = designerHost.RootComponent;
		Control val = (Control)((rootComponent is Control) ? rootComponent : null);
		if (val != null)
		{
			IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
			if (componentChangeService != null)
			{
				DesignerTransaction designerTransaction = designerHost.CreateTransaction("Document Docking Enabled");
				DockSite dockSite = designerHost.CreateComponent(typeof(DockSite)) as DockSite;
				((Control)dockSite).set_Dock((DockStyle)5);
				componentChangeService.OnComponentChanging(val, TypeDescriptor.GetProperties(typeof(Control))["Controls"]);
				val.get_Controls().Add((Control)(object)dockSite);
				((Control)dockSite).BringToFront();
				componentChangeService.OnComponentChanged(val, TypeDescriptor.GetProperties(typeof(Control))["Controls"], null, null);
				componentChangeService.OnComponentChanging(dotNetBarManager, TypeDescriptor.GetProperties(typeof(DotNetBarManager))["FillDockSite"]);
				dotNetBarManager.FillDockSite = dockSite;
				componentChangeService.OnComponentChanged(dotNetBarManager, TypeDescriptor.GetProperties(typeof(DotNetBarManager))["FillDockSite"], null, dockSite);
				DocumentDockContainer documentDockContainer = new DocumentDockContainer();
				componentChangeService.OnComponentChanging(dockSite, TypeDescriptor.GetProperties(typeof(DockSite))["DocumentDockContainer"]);
				dockSite.DocumentDockContainer = documentDockContainer;
				componentChangeService.OnComponentChanged(dockSite, TypeDescriptor.GetProperties(typeof(DockSite))["DocumentDockContainer"], null, documentDockContainer);
				Bar bar = designerHost.CreateComponent(typeof(Bar)) as Bar;
				BarUtilities.InitializeDocumentBar(bar);
				TypeDescriptor.GetProperties(bar)["Style"]!.SetValue(bar, dotNetBarManager.Style);
				DockContainerItem dockContainerItem = designerHost.CreateComponent(typeof(DockContainerItem)) as DockContainerItem;
				dockContainerItem.Text = dockContainerItem.Name;
				componentChangeService.OnComponentChanging(bar, TypeDescriptor.GetProperties(typeof(Bar))["Items"]);
				bar.Items.Add(dockContainerItem);
				PanelDockContainer panelDockContainer = designerHost.CreateComponent(typeof(PanelDockContainer)) as PanelDockContainer;
				componentChangeService.OnComponentChanging(bar, TypeDescriptor.GetProperties(typeof(Bar))["Controls"]);
				dockContainerItem.Control = (Control)(object)panelDockContainer;
				componentChangeService.OnComponentChanged(bar, TypeDescriptor.GetProperties(typeof(Bar))["Controls"], null, null);
				panelDockContainer.ColorSchemeStyle = dotNetBarManager.Style;
				panelDockContainer.ApplyLabelStyle();
				componentChangeService.OnComponentChanged(bar, TypeDescriptor.GetProperties(typeof(Bar))["Items"], null, null);
				DocumentBarContainer tab = new DocumentBarContainer(bar);
				documentDockContainer.Documents.Add(tab);
				componentChangeService.OnComponentChanging(dockSite, TypeDescriptor.GetProperties(typeof(DockSite))["Controls"]);
				((Control)dockSite).get_Controls().Add((Control)(object)bar);
				componentChangeService.OnComponentChanged(dockSite, TypeDescriptor.GetProperties(typeof(DockSite))["Controls"], null, null);
				dockSite.RecalcLayout();
				designerTransaction.Commit();
			}
		}
	}

	public object CreateComponent(Type componentClass)
	{
		return ((IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost)))?.CreateComponent(componentClass);
	}

	public object CreateComponent(Type componentClass, string name)
	{
		return ((IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost)))?.CreateComponent(componentClass, name);
	}

	public void DestroyComponent(IComponent c)
	{
		((IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost)))?.DestroyComponent(c);
	}

	object IDesignerServices.GetService(Type serviceType)
	{
		return ((ComponentDesigner)this).GetService(serviceType);
	}

	private void OnComponentRemoving(object sender, ComponentEventArgs e)
	{
		if (e.Component != ((ComponentDesigner)this).get_Component())
		{
			return;
		}
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		if (componentChangeService != null)
		{
			componentChangeService.ComponentRemoving -= OnComponentRemoving;
		}
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null || dotNetBarManager == null)
		{
			return;
		}
		Bar[] array = new Bar[dotNetBarManager.Bars.Count];
		dotNetBarManager.Bars.CopyTo(array);
		Bar[] array2 = array;
		foreach (Bar component in array2)
		{
			designerHost.DestroyComponent((IComponent)component);
		}
		if (dotNetBarManager.TopDockSite != null)
		{
			if (designerHost.GetDesigner((IComponent)dotNetBarManager.TopDockSite) is DockSiteDesigner dockSiteDesigner)
			{
				dockSiteDesigner.bool_1 = true;
			}
			designerHost.DestroyComponent((IComponent)dotNetBarManager.TopDockSite);
		}
		if (dotNetBarManager.BottomDockSite != null)
		{
			if (designerHost.GetDesigner((IComponent)dotNetBarManager.BottomDockSite) is DockSiteDesigner dockSiteDesigner2)
			{
				dockSiteDesigner2.bool_1 = true;
			}
			designerHost.DestroyComponent((IComponent)dotNetBarManager.BottomDockSite);
		}
		if (dotNetBarManager.LeftDockSite != null)
		{
			if (designerHost.GetDesigner((IComponent)dotNetBarManager.LeftDockSite) is DockSiteDesigner dockSiteDesigner3)
			{
				dockSiteDesigner3.bool_1 = true;
			}
			designerHost.DestroyComponent((IComponent)dotNetBarManager.LeftDockSite);
		}
		if (dotNetBarManager.RightDockSite != null)
		{
			if (designerHost.GetDesigner((IComponent)dotNetBarManager.RightDockSite) is DockSiteDesigner dockSiteDesigner4)
			{
				dockSiteDesigner4.bool_1 = true;
			}
			designerHost.DestroyComponent((IComponent)dotNetBarManager.RightDockSite);
		}
		if (dotNetBarManager.FillDockSite != null)
		{
			if (designerHost.GetDesigner((IComponent)dotNetBarManager.FillDockSite) is DockSiteDesigner dockSiteDesigner5)
			{
				dockSiteDesigner5.bool_1 = true;
			}
			designerHost.DestroyComponent((IComponent)dotNetBarManager.FillDockSite);
		}
		if (dotNetBarManager.ToolbarTopDockSite != null)
		{
			if (designerHost.GetDesigner((IComponent)dotNetBarManager.ToolbarTopDockSite) is DockSiteDesigner dockSiteDesigner6)
			{
				dockSiteDesigner6.bool_1 = true;
			}
			designerHost.DestroyComponent((IComponent)dotNetBarManager.ToolbarTopDockSite);
		}
		if (dotNetBarManager.ToolbarBottomDockSite != null)
		{
			if (designerHost.GetDesigner((IComponent)dotNetBarManager.ToolbarBottomDockSite) is DockSiteDesigner dockSiteDesigner7)
			{
				dockSiteDesigner7.bool_1 = true;
			}
			designerHost.DestroyComponent((IComponent)dotNetBarManager.ToolbarBottomDockSite);
		}
		if (dotNetBarManager.ToolbarLeftDockSite != null)
		{
			if (designerHost.GetDesigner((IComponent)dotNetBarManager.ToolbarLeftDockSite) is DockSiteDesigner dockSiteDesigner8)
			{
				dockSiteDesigner8.bool_1 = true;
			}
			designerHost.DestroyComponent((IComponent)dotNetBarManager.ToolbarLeftDockSite);
		}
		if (dotNetBarManager.ToolbarRightDockSite != null)
		{
			if (designerHost.GetDesigner((IComponent)dotNetBarManager.ToolbarRightDockSite) is DockSiteDesigner dockSiteDesigner9)
			{
				dockSiteDesigner9.bool_1 = true;
			}
			designerHost.DestroyComponent((IComponent)dotNetBarManager.ToolbarRightDockSite);
		}
		if (dotNetBarManager.DefinitionName != null)
		{
			dotNetBarManager.DefinitionName = "";
		}
	}

	private void AddItems(BaseItem parent, ArrayList list)
	{
		if (parent == null)
		{
			return;
		}
		foreach (BaseItem subItem in parent.SubItems)
		{
			if (!subItem.SystemItem)
			{
				list.Add(subItem);
				if (subItem.SubItems.Count > 0)
				{
					AddItems(subItem, list);
				}
			}
		}
	}

	private void RemoveDockSites()
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		if (dotNetBarManager.TopDockSite != null)
		{
			if (designerHost.GetDesigner((IComponent)dotNetBarManager.TopDockSite) is DockSiteDesigner dockSiteDesigner)
			{
				dockSiteDesigner.bool_1 = true;
			}
			designerHost.DestroyComponent((IComponent)dotNetBarManager.TopDockSite);
		}
		if (dotNetBarManager.BottomDockSite != null)
		{
			if (designerHost.GetDesigner((IComponent)dotNetBarManager.BottomDockSite) is DockSiteDesigner dockSiteDesigner2)
			{
				dockSiteDesigner2.bool_1 = true;
			}
			designerHost.DestroyComponent((IComponent)dotNetBarManager.BottomDockSite);
		}
		if (dotNetBarManager.LeftDockSite != null)
		{
			if (designerHost.GetDesigner((IComponent)dotNetBarManager.LeftDockSite) is DockSiteDesigner dockSiteDesigner3)
			{
				dockSiteDesigner3.bool_1 = true;
			}
			designerHost.DestroyComponent((IComponent)dotNetBarManager.LeftDockSite);
		}
		if (dotNetBarManager.RightDockSite != null)
		{
			if (designerHost.GetDesigner((IComponent)dotNetBarManager.RightDockSite) is DockSiteDesigner dockSiteDesigner4)
			{
				dockSiteDesigner4.bool_1 = true;
			}
			designerHost.DestroyComponent((IComponent)dotNetBarManager.RightDockSite);
		}
		dotNetBarManager.LeftDockSite = null;
		dotNetBarManager.TopDockSite = null;
		dotNetBarManager.BottomDockSite = null;
		dotNetBarManager.RightDockSite = null;
	}

	private void SetupToolbarDockSites()
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		IComponent rootComponent = designerHost.RootComponent;
		Control val = (Control)((rootComponent is Control) ? rootComponent : null);
		if (dotNetBarManager != null && val != null)
		{
			DockSite dockSite = null;
			if (dotNetBarManager.ToolbarLeftDockSite == null)
			{
				dockSite = (DockSite)designerHost.CreateComponent(typeof(DockSite));
				val.get_Controls().Add((Control)(object)dockSite);
				TypeDescriptor.GetProperties(dotNetBarManager)["ToolbarLeftDockSite"]!.SetValue(dotNetBarManager, dockSite);
				((Control)dockSite).set_Dock((DockStyle)3);
			}
			if (dotNetBarManager.ToolbarRightDockSite == null)
			{
				dockSite = (DockSite)designerHost.CreateComponent(typeof(DockSite));
				val.get_Controls().Add((Control)(object)dockSite);
				TypeDescriptor.GetProperties(dotNetBarManager)["ToolbarRightDockSite"]!.SetValue(dotNetBarManager, dockSite);
				((Control)dockSite).set_Dock((DockStyle)4);
			}
			if (dotNetBarManager.ToolbarTopDockSite == null)
			{
				dockSite = (DockSite)designerHost.CreateComponent(typeof(DockSite));
				val.get_Controls().Add((Control)(object)dockSite);
				TypeDescriptor.GetProperties(dotNetBarManager)["ToolbarTopDockSite"]!.SetValue(dotNetBarManager, dockSite);
				((Control)dockSite).set_Dock((DockStyle)1);
			}
			if (dotNetBarManager.ToolbarBottomDockSite == null)
			{
				dockSite = (DockSite)designerHost.CreateComponent(typeof(DockSite));
				val.get_Controls().Add((Control)(object)dockSite);
				TypeDescriptor.GetProperties(dotNetBarManager)["ToolbarBottomDockSite"]!.SetValue(dotNetBarManager, dockSite);
				((Control)dockSite).set_Dock((DockStyle)2);
			}
		}
	}

	private void SetupDockSites()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		if (designerHost.Loading)
		{
			designerHost.LoadComplete += LoadComplete;
			return;
		}
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		IComponent rootComponent = designerHost.RootComponent;
		Control val = (Control)((rootComponent is Control) ? rootComponent : null);
		if (dotNetBarManager != null && val != null)
		{
			if (val is Form)
			{
				dotNetBarManager.ParentForm = (Form)val;
			}
			else if (val is UserControl)
			{
				dotNetBarManager.ParentUserControl = val;
			}
			DockSite dockSite = (DockSite)designerHost.CreateComponent(typeof(DockSite));
			val.get_Controls().Add((Control)(object)dockSite);
			dotNetBarManager.LeftDockSite = dockSite;
			((Control)dockSite).set_Dock((DockStyle)3);
			dockSite.DocumentDockContainer = new DocumentDockContainer();
			((Control)dockSite).BringToFront();
			dockSite = (DockSite)designerHost.CreateComponent(typeof(DockSite));
			val.get_Controls().Add((Control)(object)dockSite);
			dotNetBarManager.RightDockSite = dockSite;
			((Control)dockSite).set_Dock((DockStyle)4);
			dockSite.DocumentDockContainer = new DocumentDockContainer();
			((Control)dockSite).BringToFront();
			dockSite = (DockSite)designerHost.CreateComponent(typeof(DockSite));
			val.get_Controls().Add((Control)(object)dockSite);
			dotNetBarManager.TopDockSite = dockSite;
			((Control)dockSite).set_Dock((DockStyle)1);
			dockSite.DocumentDockContainer = new DocumentDockContainer();
			dockSite = (DockSite)designerHost.CreateComponent(typeof(DockSite));
			val.get_Controls().Add((Control)(object)dockSite);
			dotNetBarManager.BottomDockSite = dockSite;
			((Control)dockSite).set_Dock((DockStyle)2);
			dockSite.DocumentDockContainer = new DocumentDockContainer();
			if (componentChangeService != null)
			{
				componentChangeService.OnComponentChanging(val, TypeDescriptor.GetProperties(val).Find("Controls", ignoreCase: true));
				componentChangeService.OnComponentChanged(val, TypeDescriptor.GetProperties(val).Find("Controls", ignoreCase: true), null, null);
			}
		}
	}

	private void OnSelectionChanged(object sender, EventArgs e)
	{
		ISelectionService selectionService = (ISelectionService)sender;
		if (selectionService != null && selectionService.PrimarySelection == ((ComponentDesigner)this).get_Component())
		{
			IOwner owner = ((ComponentDesigner)this).get_Component() as IOwner;
			owner.OnApplicationActivate();
			bool_0 = true;
		}
		else if (bool_0)
		{
			IOwner owner2 = ((ComponentDesigner)this).get_Component() as IOwner;
			owner2.OnApplicationDeactivate();
			bool_0 = false;
		}
	}

	private void CreateDockBarLeft(object sender, EventArgs e)
	{
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		CreateDockBar(dotNetBarManager.LeftDockSite);
	}

	private void CreateDockBarRight(object sender, EventArgs e)
	{
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		CreateDockBar(dotNetBarManager.RightDockSite);
	}

	private void CreateDockBarTop(object sender, EventArgs e)
	{
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		CreateDockBar(dotNetBarManager.TopDockSite);
	}

	private void CreateDockBarBottom(object sender, EventArgs e)
	{
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		CreateDockBar(dotNetBarManager.BottomDockSite);
	}

	private void CreateDockBar(DockSite parentSite)
	{
		if (!(((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost))
		{
			return;
		}
		IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Creating Dock Bar");
		try
		{
			if (parentSite.DocumentDockContainer == null)
			{
				TypeDescriptor.GetProperties(parentSite)["DocumentDockContainer"]!.SetValue(parentSite, new DocumentDockContainer());
			}
			Bar bar = designerHost.CreateComponent(typeof(Bar)) as Bar;
			bar.AutoSyncBarCaption = true;
			bar.CloseSingleTab = true;
			bar.CanDockDocument = false;
			bar.Style = dotNetBarManager.Style;
			bar.LayoutType = eLayoutType.DockContainer;
			bar.GrabHandleStyle = eGrabHandleStyle.Caption;
			bar.Stretch = true;
			DockContainerItem dockContainerItem = designerHost.CreateComponent(typeof(DockContainerItem)) as DockContainerItem;
			dockContainerItem.Text = dockContainerItem.Name;
			bar.Items.Add(dockContainerItem);
			PanelDockContainer panelDockContainer = designerHost.CreateComponent(typeof(PanelDockContainer)) as PanelDockContainer;
			((Control)bar).get_Controls().Add((Control)(object)panelDockContainer);
			panelDockContainer.ColorSchemeStyle = bar.Style;
			panelDockContainer.ApplyLabelStyle();
			dockContainerItem.Control = (Control)(object)panelDockContainer;
			bar.SelectedDockTab = 0;
			componentChangeService.OnComponentChanging(parentSite, null);
			parentSite.GetDocumentUIManager().Dock(bar);
			parentSite.RecalcLayout();
			componentChangeService.OnComponentChanged(parentSite, null, null, null);
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

	private void CreateMenuBar(object sender, EventArgs e)
	{
		CreateToolbar(menuBar: true);
	}

	private void CreateToolbar(object sender, EventArgs e)
	{
		CreateToolbar(menuBar: false);
	}

	private void CreateToolbar(bool menuBar)
	{
		DotNetBarManager dotNetBarManager = ((ComponentDesigner)this).get_Component() as DotNetBarManager;
		IDesignerHost designerHost = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		if (designerHost == null || dotNetBarManager == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Creating Bar Control");
		try
		{
			if (dotNetBarManager.ToolbarTopDockSite == null)
			{
				SetupToolbarDockSites();
			}
			Bar bar = designerHost.CreateComponent(typeof(Bar)) as Bar;
			bar.LayoutType = eLayoutType.Toolbar;
			((Control)bar).set_Text(bar.Name);
			ButtonItem buttonItem = designerHost.CreateComponent(typeof(ButtonItem)) as ButtonItem;
			buttonItem.Text = buttonItem.Name;
			bar.Items.Add(buttonItem);
			if (menuBar)
			{
				bar.Stretch = true;
				bar.MenuBar = true;
			}
			else
			{
				bar.GrabHandleStyle = eGrabHandleStyle.Office2003;
			}
			componentChangeService.OnComponentChanging(dotNetBarManager.ToolbarTopDockSite, null);
			dotNetBarManager.Bars.Add(bar);
			if (menuBar)
			{
				bar.DockLine = -1;
			}
			bar.DockSide = eDockSide.Top;
			bar.RecalcLayout();
			componentChangeService.OnComponentChanged(dotNetBarManager.ToolbarTopDockSite, null, null, null);
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

	private void ImportDefinition(DotNetBarManager manager)
	{
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		IDesignerHost designerHost = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		if (manager.DefinitionName == "" || designerHost == null)
		{
			return;
		}
		XmlDocument xmlDocument = LoadDefinition(manager);
		if (xmlDocument == null)
		{
			return;
		}
		IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		if (manager.ToolbarTopDockSite == null)
		{
			SetupToolbarDockSites();
		}
		manager.SuspendLayout = true;
		try
		{
			if (manager.TopDockSite != null && manager.TopDockSite.DocumentDockContainer == null)
			{
				manager.TopDockSite.DocumentDockContainer = new DocumentDockContainer();
			}
			if (manager.BottomDockSite != null && manager.BottomDockSite.DocumentDockContainer == null)
			{
				manager.BottomDockSite.DocumentDockContainer = new DocumentDockContainer();
			}
			if (manager.LeftDockSite != null && manager.LeftDockSite.DocumentDockContainer == null)
			{
				manager.LeftDockSite.DocumentDockContainer = new DocumentDockContainer();
			}
			if (manager.RightDockSite != null && manager.RightDockSite.DocumentDockContainer == null)
			{
				manager.RightDockSite.DocumentDockContainer = new DocumentDockContainer();
			}
			XmlElement xmlElement = xmlDocument.FirstChild as XmlElement;
			ItemSerializationContext itemSerializationContext = new ItemSerializationContext();
			itemSerializationContext.Serializer = manager;
			itemSerializationContext.HasDeserializeItemHandlers = false;
			itemSerializationContext.HasSerializeItemHandlers = false;
			itemSerializationContext.idesignerHost_0 = designerHost;
			foreach (XmlElement childNode in xmlElement.ChildNodes)
			{
				if (!(childNode.Name == "bars"))
				{
					continue;
				}
				foreach (XmlElement childNode2 in childNode.ChildNodes)
				{
					Bar bar = null;
					string attribute = childNode2.GetAttribute("name");
					try
					{
						bar = designerHost.CreateComponent(typeof(Bar), attribute) as Bar;
					}
					catch
					{
					}
					if (bar == null)
					{
						bar = designerHost.CreateComponent(typeof(Bar)) as Bar;
					}
					manager.Bars.Add(bar);
					bar.method_81(childNode2, itemSerializationContext);
					if (bar.LayoutType != eLayoutType.DockContainer)
					{
						continue;
					}
					foreach (BaseItem item in bar.Items)
					{
						if (item is DockContainerItem)
						{
							DockContainerItem dockContainerItem = item as DockContainerItem;
							PanelDockContainer panelDockContainer = designerHost.CreateComponent(typeof(PanelDockContainer)) as PanelDockContainer;
							((Control)bar).get_Controls().Add((Control)(object)panelDockContainer);
							panelDockContainer.ColorSchemeStyle = bar.Style;
							panelDockContainer.ApplyLabelStyle();
							dockContainerItem.Control = (Control)(object)panelDockContainer;
						}
					}
				}
			}
			foreach (XmlElement childNode3 in xmlElement.ChildNodes)
			{
				if (!(childNode3.Name == "popups"))
				{
					continue;
				}
				ContextMenuBar contextMenuBar = null;
				Control val = (Control)(object)manager.ParentForm;
				if (val == null)
				{
					val = manager.ParentUserControl;
				}
				if (val == null)
				{
					IComponent rootComponent = designerHost.RootComponent;
					val = (Control)((rootComponent is Control) ? rootComponent : null);
				}
				if (val == null)
				{
					continue;
				}
				if (childNode3.ChildNodes.Count > 0)
				{
					contextMenuBar = designerHost.CreateComponent(typeof(ContextMenuBar)) as ContextMenuBar;
					val.get_Controls().Add((Control)(object)contextMenuBar);
					((Control)contextMenuBar).BringToFront();
					contextMenuBar.Style = manager.Style;
					contextMenuBar.Size = new Size(150, 26);
				}
				foreach (XmlElement childNode4 in childNode3.ChildNodes)
				{
					BaseItem baseItem2 = itemSerializationContext.method_0(childNode4);
					if (baseItem2 == null)
					{
						MessageBox.Show("Invalid Item in file found (" + Class109.smethod_20(childNode4) + ").");
					}
					itemSerializationContext.ItemXmlElement = childNode4;
					baseItem2.Deserialize(itemSerializationContext);
					if (!baseItem2.Visible)
					{
						baseItem2.Visible = true;
					}
					if (baseItem2.Text == "" || baseItem2.Text == null)
					{
						baseItem2.Text = baseItem2.Name;
					}
					if (baseItem2 is ButtonItem)
					{
						((ButtonItem)baseItem2).AutoExpandOnClick = true;
					}
					contextMenuBar.Items.Add(baseItem2);
				}
				contextMenuBar?.RecalcLayout();
				if (componentChangeService != null && contextMenuBar != null)
				{
					componentChangeService.OnComponentChanged(contextMenuBar, TypeDescriptor.GetProperties(contextMenuBar)["Items"], null, null);
					componentChangeService.OnComponentChanged(contextMenuBar, null, null, null);
				}
			}
			if (componentChangeService != null)
			{
				componentChangeService.OnComponentChanged(manager, null, null, null);
				if (manager.TopDockSite != null)
				{
					componentChangeService.OnComponentChanged(manager.TopDockSite, null, null, null);
				}
				if (manager.BottomDockSite != null)
				{
					componentChangeService.OnComponentChanged(manager.BottomDockSite, null, null, null);
				}
				if (manager.LeftDockSite != null)
				{
					componentChangeService.OnComponentChanged(manager.LeftDockSite, null, null, null);
				}
				if (manager.RightDockSite != null)
				{
					componentChangeService.OnComponentChanged(manager.RightDockSite, null, null, null);
				}
				if (manager.ToolbarTopDockSite != null)
				{
					componentChangeService.OnComponentChanged(manager.ToolbarTopDockSite, null, null, null);
				}
				if (manager.BottomDockSite != null)
				{
					componentChangeService.OnComponentChanged(manager.ToolbarBottomDockSite, null, null, null);
				}
				if (manager.ToolbarLeftDockSite != null)
				{
					componentChangeService.OnComponentChanged(manager.ToolbarLeftDockSite, null, null, null);
				}
				if (manager.ToolbarRightDockSite != null)
				{
					componentChangeService.OnComponentChanged(manager.ToolbarRightDockSite, null, null, null);
				}
			}
		}
		finally
		{
			manager.SuspendLayout = false;
		}
		foreach (Bar bar2 in manager.Bars)
		{
			if (bar2.LayoutType == eLayoutType.DockContainer)
			{
				DockContainerItem selectedDockContainerItem = bar2.SelectedDockContainerItem;
				if (selectedDockContainerItem != null && selectedDockContainerItem.Control != null && ((Control)bar2).get_Controls().IndexOf(selectedDockContainerItem.Control) > 0)
				{
					componentChangeService?.OnComponentChanging(bar2, TypeDescriptor.GetProperties(bar2)["Controls"]);
					((Control)bar2).get_Controls().SetChildIndex(selectedDockContainerItem.Control, 0);
					componentChangeService?.OnComponentChanged(bar2, TypeDescriptor.GetProperties(bar2)["Controls"], null, null);
				}
			}
		}
	}

	private XmlDocument LoadDefinition(DotNetBarManager manager)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		string text = DesignTimeDte.GetDefinitionPath(manager.DefinitionName, manager.Site);
		if (text != null && text != "")
		{
			if (!text.EndsWith("\\"))
			{
				text += "\\";
			}
			if (File.Exists(text + manager.DefinitionName))
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(text + manager.DefinitionName);
				return xmlDocument;
			}
			MessageBox.Show("Could not import. DotNetBar definition file not found: " + text + manager.DefinitionName, "Import Routine", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		else
		{
			MessageBox.Show("Could not find DotNetBarManager path. Import aborted.", "Import Routine", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		return null;
	}
}
