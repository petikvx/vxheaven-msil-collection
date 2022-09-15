using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar;

public class ExpandableSplitterDesigner : ControlDesigner
{
	[Description("Indicates visual style of the control.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(eSplitterStyle.Office2003)]
	public eSplitterStyle Style
	{
		get
		{
			return ((ExpandableSplitter)(object)((ControlDesigner)this).get_Control()).Style;
		}
		set
		{
			((ExpandableSplitter)(object)((ControlDesigner)this).get_Control()).Style = value;
			if (!(((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost) || !designerHost.Loading)
			{
				((ExpandableSplitter)(object)((ControlDesigner)this).get_Control()).ApplyStyle(value);
				method_0();
			}
		}
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ControlDesigner)this).PreFilterProperties(properties);
		properties["Style"] = TypeDescriptor.CreateProperty(typeof(ExpandableSplitterDesigner), (PropertyDescriptor)properties["Style"]);
	}

	private void method_0()
	{
		ExpandableSplitter component = ((ControlDesigner)this).get_Control() as ExpandableSplitter;
		if (((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) is IComponentChangeService componentChangeService)
		{
			componentChangeService.OnComponentChanging(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["Style"]);
			componentChangeService.OnComponentChanged(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["Style"], null, null);
			componentChangeService.OnComponentChanging(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["BackColor"]);
			componentChangeService.OnComponentChanged(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["BackColor"], null, null);
			componentChangeService.OnComponentChanging(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["BackColor2"]);
			componentChangeService.OnComponentChanged(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["BackColor2"], null, null);
			componentChangeService.OnComponentChanging(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["GripLightColor"]);
			componentChangeService.OnComponentChanged(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["GripLightColor"], null, null);
			componentChangeService.OnComponentChanging(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["GripDarkColor"]);
			componentChangeService.OnComponentChanged(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["GripDarkColor"], null, null);
			componentChangeService.OnComponentChanging(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["EpxandFillColor"]);
			componentChangeService.OnComponentChanged(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["ExpandFillColor"], null, null);
			componentChangeService.OnComponentChanging(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["EpxandLineColor"]);
			componentChangeService.OnComponentChanged(component, TypeDescriptor.GetProperties(typeof(ExpandableSplitter))["ExpandLineColor"], null, null);
		}
	}

	private IDesignerHost method_1()
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
}
