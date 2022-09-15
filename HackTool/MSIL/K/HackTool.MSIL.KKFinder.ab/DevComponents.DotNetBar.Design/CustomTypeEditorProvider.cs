using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class CustomTypeEditorProvider : IWindowsFormsEditorService, ITypeDescriptorContext, IServiceProvider
{
	private IContainer icontainer_0;

	private object object_0;

	private IServiceProvider iserviceProvider_0;

	private PropertyDescriptor propertyDescriptor_0;

	public IContainer Container => icontainer_0;

	public object Instance => object_0;

	public PropertyDescriptor PropertyDescriptor => propertyDescriptor_0;

	public CustomTypeEditorProvider(IContainer container, IServiceProvider provider)
	{
		icontainer_0 = container;
		iserviceProvider_0 = provider;
	}

	public void SetInstance(object instance, PropertyDescriptor desc)
	{
		object_0 = instance;
		propertyDescriptor_0 = desc;
	}

	public void OnComponentChanged()
	{
		if (iserviceProvider_0.GetService(typeof(IComponentChangeService)) is IComponentChangeService componentChangeService)
		{
			componentChangeService.OnComponentChanged(object_0, propertyDescriptor_0, null, null);
		}
	}

	public bool OnComponentChanging()
	{
		return true;
	}

	public object GetService(Type serviceType)
	{
		return iserviceProvider_0.GetService(serviceType);
	}

	public void CloseDropDown()
	{
		throw new Exception("The method or operation is not implemented.");
	}

	public void DropDownControl(Control control)
	{
		throw new Exception("The method or operation is not implemented.");
	}

	public DialogResult ShowDialog(Form dialog)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		IntPtr focus = Class92.GetFocus();
		IUIService val = (IUIService)GetService(typeof(IUIService));
		DialogResult result = ((val == null) ? dialog.ShowDialog() : val.ShowDialog(dialog));
		if (focus != IntPtr.Zero)
		{
			Class92.SetFocus(focus);
		}
		return result;
	}
}
