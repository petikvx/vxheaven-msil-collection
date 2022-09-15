using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar.Design;

public class SimpleItemDesigner : ComponentDesigner
{
	[Browsable(true)]
	[DefaultValue(true)]
	[Category("Layout")]
	[Description("Gets or sets whether item is visible.")]
	[DevCoBrowsable(true)]
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

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ComponentDesigner)this).PreFilterProperties(properties);
		properties["Visible"] = TypeDescriptor.CreateProperty(typeof(SimpleItemDesigner), (PropertyDescriptor)properties["Visible"], new DefaultValueAttribute(value: true), new BrowsableAttribute(browsable: true), new CategoryAttribute("Layout"));
	}
}
