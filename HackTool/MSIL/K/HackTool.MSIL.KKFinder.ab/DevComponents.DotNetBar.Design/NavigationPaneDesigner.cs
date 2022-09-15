using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class NavigationPaneDesigner : NavigationBarDesigner
{
	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] value = new DesignerVerb[1]
			{
				new DesignerVerb("Create New Pane", method_14)
			};
			return new DesignerVerbCollection(value);
		}
	}

	[Category("Title")]
	[DefaultValue(true)]
	[Description("Indicates whether navigation pane can be collapsed.")]
	[Browsable(true)]
	public bool Expanded
	{
		get
		{
			return (bool)((ComponentDesigner)this).get_ShadowProperties().get_Item("Expanded");
		}
		set
		{
			((ComponentDesigner)this).get_ShadowProperties().set_Item("Expanded", (object)value);
		}
	}

	public override void Initialize(IComponent component)
	{
		base.Initialize(component);
		if (component.Site!.DesignMode && ((ControlDesigner)this).get_Control() is NavigationPane navigationPane)
		{
			navigationPane.method_0();
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ParentControlDesigner)this).InitializeNewComponent(defaultValues);
		method_13();
	}

	private void method_13()
	{
		method_15();
	}

	private void method_14(object sender, EventArgs e)
	{
		method_15();
	}

	private void method_15()
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (!(((ControlDesigner)this).get_Control() is NavigationPane navigationPane) || designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction();
		try
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), null);
			ButtonItem buttonItem = null;
			try
			{
				m_CreatingItem = true;
				buttonItem = designerHost.CreateComponent(typeof(ButtonItem)) as ButtonItem;
				buttonItem.Text = buttonItem.Name;
				buttonItem.OptionGroup = "navBar";
				buttonItem.Image = (Image)(object)Class109.smethod_67("SystemImages.DefaultNavBarImage.png");
			}
			finally
			{
				m_CreatingItem = false;
			}
			NavigationPanePanel navigationPanePanel = designerHost.CreateComponent(typeof(NavigationPanePanel)) as NavigationPanePanel;
			navigationPanePanel.ParentItem = buttonItem;
			navigationPane.Items.Add(buttonItem);
			((Control)navigationPane).get_Controls().Add((Control)(object)navigationPanePanel);
			((Control)navigationPanePanel).set_Dock((DockStyle)5);
			((Control)navigationPanePanel).SendToBack();
			navigationPanePanel.ApplyLabelStyle();
			navigationPanePanel.ColorSchemeStyle = navigationPane.Style;
			if (navigationPane.Style == eDotNetBarStyle.Office2007)
			{
				navigationPanePanel.ColorScheme = navigationPane.NavigationBar.GetColorScheme();
			}
			navigationPanePanel.Style.Border = eBorderType.None;
			navigationPanePanel.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
			if (navigationPane.Items.Count == 1)
			{
				buttonItem.Checked = true;
			}
			navigationPane.RecalcLayout();
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), null, null, null);
			if (componentChangeService != null)
			{
				componentChangeService.OnComponentChanging(navigationPanePanel, null);
				componentChangeService.OnComponentChanged(navigationPanePanel, null, null, null);
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

	public override bool CanParent(Control c)
	{
		if (c is NavigationPanePanel)
		{
			return true;
		}
		return false;
	}

	protected override BaseItem GetItemContainer()
	{
		if (((ControlDesigner)this).get_Control() is NavigationPane navigationPane)
		{
			return navigationPane.NavigationBar.method_10();
		}
		return null;
	}

	protected override Control GetItemContainerControl()
	{
		if (((ControlDesigner)this).get_Control() is NavigationPane navigationPane)
		{
			return (Control)(object)navigationPane.NavigationBar;
		}
		return null;
	}

	protected override void OtherComponentRemoving(object sender, ComponentEventArgs e)
	{
		base.OtherComponentRemoving(sender, e);
		if (!(((ComponentDesigner)this).get_Component() is NavigationPane navigationPane) || ((Control)navigationPane).get_IsDisposed())
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		if (!m_InternalRemoving && e.Component is BaseItem)
		{
			if (e.Component is ButtonItem item)
			{
				NavigationPanePanel panel = navigationPane.GetPanel(item);
				if (panel != null && designerHost != null)
				{
					panel.ParentItem = null;
					componentChangeService?.OnComponentChanging(navigationPane, TypeDescriptor.GetProperties(navigationPane)["Controls"]);
					((Control)navigationPane).get_Controls().Remove((Control)(object)panel);
					componentChangeService?.OnComponentChanged(navigationPane, TypeDescriptor.GetProperties(navigationPane)["Controls"], null, null);
					designerHost.DestroyComponent((IComponent)panel);
				}
				navigationPane.RecalcLayout();
			}
		}
		else if (!m_InternalRemoving && e.Component is NavigationPanePanel && ((Control)navigationPane).get_Controls().Contains((Control)(object)(e.Component as NavigationPanePanel)))
		{
			NavigationPanePanel navigationPanePanel = e.Component as NavigationPanePanel;
			if (navigationPanePanel.ParentItem != null)
			{
				BaseItem parentItem = navigationPanePanel.ParentItem;
				navigationPanePanel.ParentItem = null;
				componentChangeService?.OnComponentChanging(navigationPane, TypeDescriptor.GetProperties(navigationPane)["Items"]);
				navigationPane.Items.Remove(parentItem);
				componentChangeService?.OnComponentChanged(navigationPane, TypeDescriptor.GetProperties(navigationPane)["Items"], null, null);
				designerHost.DestroyComponent(parentItem);
			}
			navigationPane.RecalcLayout();
		}
		if (navigationPane.CheckedButton == null && navigationPane.Items.Count > 0 && navigationPane.Items[0] is ButtonItem)
		{
			ButtonItem buttonItem = (ButtonItem)navigationPane.Items[0];
			buttonItem.Checked = true;
		}
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ParentControlDesigner)this).PreFilterProperties(properties);
		properties["Expanded"] = TypeDescriptor.CreateProperty(typeof(NavigationPaneDesigner), (PropertyDescriptor)properties["Expanded"], new DefaultValueAttribute(value: true), new BrowsableAttribute(browsable: true), new CategoryAttribute("Title"), new DescriptionAttribute("Indicates whether navigation pane can be collapsed."));
	}
}
