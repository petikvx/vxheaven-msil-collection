using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.Design;

public class ElementStyleClassTypeEditor : UITypeEditor
{
	private IWindowsFormsEditorService iwindowsFormsEditorService_0;

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		if (context != null && context.Instance != null && provider != null)
		{
			ref IWindowsFormsEditorService reference = ref iwindowsFormsEditorService_0;
			object? service = provider.GetService(typeof(IWindowsFormsEditorService));
			reference = (IWindowsFormsEditorService)((service is IWindowsFormsEditorService) ? service : null);
			if (iwindowsFormsEditorService_0 != null)
			{
				ListBox val = new ListBox();
				val.add_SelectedIndexChanged((EventHandler)method_0);
				Type typeFromHandle = typeof(ElementStyleClassKeys);
				FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public);
				FieldInfo[] array = fields;
				foreach (FieldInfo fieldInfo in array)
				{
					string text = fieldInfo.GetValue(null)!.ToString();
					val.get_Items().Add((object)text);
					if (text == value.ToString())
					{
						val.set_SelectedItem((object)text);
					}
				}
				iwindowsFormsEditorService_0.DropDownControl((Control)(object)val);
				if (val.get_SelectedItem() != null)
				{
					return val.get_SelectedItem().ToString();
				}
			}
		}
		return value;
	}

	private void method_0(object sender, EventArgs e)
	{
		if (iwindowsFormsEditorService_0 != null)
		{
			iwindowsFormsEditorService_0.CloseDropDown();
		}
	}

	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (context != null && context.Instance != null)
		{
			return (UITypeEditorEditStyle)3;
		}
		return ((UITypeEditor)this).GetEditStyle(context);
	}
}
