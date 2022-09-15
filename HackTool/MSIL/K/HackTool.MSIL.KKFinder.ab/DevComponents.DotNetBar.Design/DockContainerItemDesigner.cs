using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar.Design;

public class DockContainerItemDesigner : ComponentDesigner
{
	[Description("Gets or sets whether item is visible.")]
	[DevCoBrowsable(true)]
	[Category("Layout")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool Visible
	{
		get
		{
			return (bool)((ComponentDesigner)this).get_ShadowProperties().get_Item("Visible");
		}
		set
		{
			((ComponentDesigner)this).get_ShadowProperties().set_Item("Visible", (object)value);
		}
	}

	public override void Initialize(IComponent component)
	{
		((ComponentDesigner)this).Initialize(component);
		if (component.Site!.DesignMode && component is DockContainerItem dockContainerItem)
		{
			Visible = dockContainerItem.Visible;
		}
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ComponentDesigner)this).PreFilterProperties(properties);
		properties["Visible"] = TypeDescriptor.CreateProperty(typeof(DockContainerItemDesigner), (PropertyDescriptor)properties["Visible"], new DefaultValueAttribute(value: true), new BrowsableAttribute(browsable: true), new CategoryAttribute("Layout"));
	}
}
