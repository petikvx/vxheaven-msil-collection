using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class SideBarDesigner : BarBaseControlDesigner
{
	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] value = new DesignerVerb[3]
			{
				new DesignerVerb("Create Panel", method_13),
				new DesignerVerb("Create Button", method_15),
				new DesignerVerb("Choose Color Scheme", method_16)
			};
			return new DesignerVerbCollection(value);
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(eSideBarAppearance.Traditional)]
	[Description("Indicates visual appearance for the control.")]
	public eSideBarAppearance Appearance
	{
		get
		{
			return ((SideBar)(object)((ControlDesigner)this).get_Control()).Appearance;
		}
		set
		{
			SideBar sideBar = (SideBar)(object)((ControlDesigner)this).get_Control();
			if (sideBar.Appearance == value)
			{
				return;
			}
			sideBar.Appearance = value;
			IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
			if (designerHost != null && !designerHost.Loading)
			{
				switch (value)
				{
				case eSideBarAppearance.Flat:
					method_17(sideBar.PredefinedColorScheme);
					break;
				case eSideBarAppearance.Traditional:
					sideBar.method_4();
					method_18();
					break;
				}
				if (designerHost != null && !designerHost.Loading && value == eSideBarAppearance.Flat && sideBar.Style == eDotNetBarStyle.Office2007)
				{
					sideBar.Style = eDotNetBarStyle.Office2003;
				}
			}
		}
	}

	[Description("Specifies the visual style of the side bar.")]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[DefaultValue(eDotNetBarStyle.OfficeXP)]
	[Browsable(true)]
	public eDotNetBarStyle Style
	{
		get
		{
			return ((SideBar)(object)((ControlDesigner)this).get_Control()).Style;
		}
		set
		{
			SideBar sideBar = (SideBar)(object)((ControlDesigner)this).get_Control();
			if (sideBar.Style == value)
			{
				return;
			}
			sideBar.Style = value;
			IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
			if (designerHost == null || designerHost.Loading)
			{
				return;
			}
			bool fontBold = false;
			if (value == eDotNetBarStyle.Office2007)
			{
				sideBar.BorderStyle = eBorderType.None;
				fontBold = true;
			}
			else
			{
				sideBar.BorderStyle = eBorderType.Sunken;
			}
			foreach (SideBarPanelItem panel in sideBar.Panels)
			{
				panel.FontBold = fontBold;
			}
		}
	}

	public SideBarDesigner()
	{
		EnableItemDragDrop = true;
	}

	public override void Initialize(IComponent component)
	{
		base.Initialize(component);
		if (component.Site!.DesignMode && ((ControlDesigner)this).get_Control() is SideBar sideBar)
		{
			sideBar.method_7();
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ParentControlDesigner)this).InitializeNewComponent(defaultValues);
		method_12();
	}

	private void method_12()
	{
		if (((ControlDesigner)this).get_Control() is SideBar)
		{
			Style = eDotNetBarStyle.Office2007;
		}
	}

	protected override BaseItem GetItemContainer()
	{
		if (((ControlDesigner)this).get_Control() is SideBar sideBar)
		{
			return sideBar.ItemsContainer;
		}
		return null;
	}

	protected override void RecalcLayout()
	{
		if (GetItemContainerControl() is SideBar sideBar)
		{
			sideBar.RecalcLayout();
		}
	}

	protected override void OnSubItemsChanging()
	{
		base.OnSubItemsChanging();
		if (((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) is IComponentChangeService componentChangeService)
		{
			SideBar component = GetItemContainerControl() as SideBar;
			componentChangeService.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(component).Find("Panels", ignoreCase: true));
		}
	}

	protected override void OnSubItemsChanged()
	{
		base.OnSubItemsChanged();
		if (((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) is IComponentChangeService componentChangeService)
		{
			SideBar component = GetItemContainerControl() as SideBar;
			componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(component).Find("Panels", ignoreCase: true), null, null);
		}
	}

	private void method_13(object sender, EventArgs e)
	{
		IDesignerHost designerHost = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		DesignerTransaction designerTransaction = null;
		if (designerHost != null)
		{
			designerTransaction = designerHost.CreateTransaction("New SideBarPanelItem");
		}
		try
		{
			method_14();
		}
		finally
		{
			if (designerTransaction != null && !designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
		RecalcLayout();
	}

	private SideBarPanelItem method_14()
	{
		SideBarPanelItem result = null;
		SideBar sideBar = ((ComponentDesigner)this).get_Component() as SideBar;
		IDesignerHost designerHost = method_19();
		if (sideBar != null && designerHost != null)
		{
			try
			{
				m_CreatingItem = true;
				OnSubItemsChanging();
				if (!(designerHost.CreateComponent(typeof(SideBarPanelItem)) is SideBarPanelItem sideBarPanelItem))
				{
					return null;
				}
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				componentChangeService?.OnComponentChanging(sideBarPanelItem, null);
				sideBarPanelItem.Text = sideBarPanelItem.Name;
				sideBar.Panels.Add(sideBarPanelItem);
				sideBarPanelItem.ESideBarAppearance_0 = sideBar.Appearance;
				if (sideBarPanelItem.ESideBarAppearance_0 == eSideBarAppearance.Flat)
				{
					SideBar.ApplyColorScheme(sideBarPanelItem, sideBar.PredefinedColorScheme);
				}
				if (sideBar.Style == eDotNetBarStyle.Office2007)
				{
					sideBarPanelItem.FontBold = true;
				}
				componentChangeService?.OnComponentChanged(sideBarPanelItem, null, null, null);
				OnSubItemsChanged();
				return sideBarPanelItem;
			}
			finally
			{
				m_CreatingItem = false;
			}
		}
		return result;
	}

	private void method_15(object sender, EventArgs e)
	{
		SideBar sideBar = ((ComponentDesigner)this).get_Component() as SideBar;
		IDesignerHost designerHost = method_19();
		if (sideBar == null || designerHost == null)
		{
			return;
		}
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService == null)
		{
			return;
		}
		SideBarPanelItem sideBarPanelItem = null;
		sideBarPanelItem = ((selectionService.PrimarySelection is SideBarPanelItem) ? (selectionService.PrimarySelection as SideBarPanelItem) : ((sideBar.ExpandedPanel != null) ? sideBar.ExpandedPanel : method_14()));
		if (sideBarPanelItem == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction();
		try
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(sideBarPanelItem).Find("SubItems", ignoreCase: true));
			try
			{
				m_CreatingItem = true;
				if (!(designerHost.CreateComponent(typeof(ButtonItem)) is ButtonItem buttonItem))
				{
					return;
				}
				buttonItem.Text = "New Button";
				if (sideBar.Appearance == eSideBarAppearance.Flat)
				{
					buttonItem.ImagePosition = eImagePosition.Left;
				}
				else
				{
					buttonItem.ImagePosition = eImagePosition.Top;
				}
				buttonItem.ButtonStyle = eButtonStyle.ImageAndText;
				sideBarPanelItem.SubItems.Add(buttonItem);
				componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(sideBarPanelItem).Find("SubItems", ignoreCase: true), null, null);
			}
			finally
			{
				m_CreatingItem = false;
			}
			RecalcLayout();
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

	private void method_16(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		SideBarColorSchemePicker sideBarColorSchemePicker = new SideBarColorSchemePicker();
		try
		{
			((Form)sideBarColorSchemePicker).ShowDialog();
			if ((int)((Form)sideBarColorSchemePicker).get_DialogResult() == 1)
			{
				method_17(sideBarColorSchemePicker.SelectedColorScheme);
			}
		}
		finally
		{
			((IDisposable)sideBarColorSchemePicker)?.Dispose();
		}
	}

	private void method_17(eSideBarColorScheme eSideBarColorScheme_0)
	{
		if (((ControlDesigner)this).get_Control() is SideBar sideBar)
		{
			if (sideBar.Appearance != eSideBarAppearance.Flat)
			{
				TypeDescriptor.GetProperties(sideBar)["Appearance"]!.SetValue(sideBar, eSideBarAppearance.Flat);
			}
			TypeDescriptor.GetProperties(sideBar)["PredefinedColorScheme"]!.SetValue(sideBar, eSideBarColorScheme_0);
			sideBar.method_3(eSideBarColorScheme_0);
			method_18();
		}
	}

	private void method_18()
	{
		IDesignerHost designerHost = method_19();
		DesignerTransaction designerTransaction = null;
		if (designerHost != null)
		{
			designerTransaction = designerHost.CreateTransaction();
		}
		SideBar sideBar = ((ControlDesigner)this).get_Control() as SideBar;
		if (((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) is IComponentChangeService componentChangeService)
		{
			componentChangeService.OnComponentChanging(((ControlDesigner)this).get_Control(), null);
			componentChangeService.OnComponentChanged(((ControlDesigner)this).get_Control(), null, null, null);
			componentChangeService.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(sideBar).Find("ColorScheme", ignoreCase: true));
			componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(sideBar).Find("ColorScheme", ignoreCase: true), null, null);
			componentChangeService.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(sideBar).Find("Panels", ignoreCase: true));
			componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(sideBar).Find("Panels", ignoreCase: true), null, null);
			foreach (SideBarPanelItem panel in sideBar.Panels)
			{
				componentChangeService.OnComponentChanging(panel, TypeDescriptor.GetProperties(typeof(SideBarPanelItem))["HeaderStyle"]);
				componentChangeService.OnComponentChanged(panel, TypeDescriptor.GetProperties(typeof(SideBarPanelItem))["HeaderStyle"], null, null);
				componentChangeService.OnComponentChanging(panel, TypeDescriptor.GetProperties(typeof(SideBarPanelItem))["HeaderHotStyle"]);
				componentChangeService.OnComponentChanged(panel, TypeDescriptor.GetProperties(typeof(SideBarPanelItem))["HeaderHotStyle"], null, null);
				componentChangeService.OnComponentChanging(panel, TypeDescriptor.GetProperties(typeof(SideBarPanelItem))["HeaderMouseDownStyle"]);
				componentChangeService.OnComponentChanged(panel, TypeDescriptor.GetProperties(typeof(SideBarPanelItem))["HeaderMouseDownStyle"], null, null);
				componentChangeService.OnComponentChanging(panel, TypeDescriptor.GetProperties(typeof(SideBarPanelItem))["HeaderSideHotStyle"]);
				componentChangeService.OnComponentChanged(panel, TypeDescriptor.GetProperties(typeof(SideBarPanelItem))["HeaderSideHotStyle"], null, null);
				componentChangeService.OnComponentChanging(panel, TypeDescriptor.GetProperties(typeof(SideBarPanelItem))["HeaderSideMouseDownStyle"]);
				componentChangeService.OnComponentChanged(panel, TypeDescriptor.GetProperties(typeof(SideBarPanelItem))["HeaderSideMouseDownStyle"], null, null);
				componentChangeService.OnComponentChanging(panel, TypeDescriptor.GetProperties(typeof(SideBarPanelItem))["HeaderSideStyle"]);
				componentChangeService.OnComponentChanged(panel, TypeDescriptor.GetProperties(typeof(SideBarPanelItem))["HeaderSideStyle"], null, null);
			}
		}
		designerTransaction?.Commit();
	}

	private IDesignerHost method_19()
	{
		try
		{
			return (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		}
		catch
		{
		}
		return null;
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ParentControlDesigner)this).PreFilterProperties(properties);
		properties["Appearance"] = TypeDescriptor.CreateProperty(typeof(SideBarDesigner), (PropertyDescriptor)properties["Appearance"]);
		properties["Style"] = TypeDescriptor.CreateProperty(typeof(SideBarDesigner), (PropertyDescriptor)properties["Style"]);
	}

	protected override bool CanDragItem(BaseItem item)
	{
		if (item is SideBarPanelItem)
		{
			return false;
		}
		return base.CanDragItem(item);
	}
}
