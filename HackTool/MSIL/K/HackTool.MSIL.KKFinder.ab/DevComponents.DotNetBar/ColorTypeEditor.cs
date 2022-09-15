using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.UI;

namespace DevComponents.DotNetBar;

public class ColorTypeEditor : UITypeEditor
{
	private IWindowsFormsEditorService iwindowsFormsEditorService_0;

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		if (context != null && context.Instance != null && provider != null)
		{
			ref IWindowsFormsEditorService reference = ref iwindowsFormsEditorService_0;
			object? service = provider.GetService(typeof(IWindowsFormsEditorService));
			reference = (IWindowsFormsEditorService)((service is IWindowsFormsEditorService) ? service : null);
			ColorScheme object_ = null;
			if (context.Instance != null)
			{
				MethodInfo method = context.Instance.GetType().GetMethod("GetColorScheme", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if ((object)method != null)
				{
					object_ = method.Invoke(context.Instance, null) as ColorScheme;
				}
			}
			Color color_ = (Color)value;
			if (iwindowsFormsEditorService_0 != null)
			{
				ColorPicker colorPicker = new ColorPicker();
				colorPicker.IWindowsFormsEditorService_0 = iwindowsFormsEditorService_0;
				((Control)colorPicker).set_BackColor(SystemColors.Control);
				colorPicker.Object_0 = object_;
				colorPicker.Color_0 = color_;
				string name = context.PropertyDescriptor.Name;
				PropertyInfo property = context.Instance.GetType().GetProperty(name + "SchemePart", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if ((object)property != null)
				{
					colorPicker.String_0 = property.GetValue(context.Instance, null)!.ToString();
				}
				colorPicker.method_4();
				iwindowsFormsEditorService_0.DropDownControl((Control)(object)colorPicker);
				if (!colorPicker.Boolean_0)
				{
					Color color_2 = colorPicker.Color_0;
					eColorSchemePart eColorSchemePart2 = eColorSchemePart.None;
					if (colorPicker.String_0 != "")
					{
						eColorSchemePart2 = (eColorSchemePart)Enum.Parse(typeof(eColorSchemePart), colorPicker.String_0);
					}
					property?.SetValue(context.Instance, eColorSchemePart2, null);
					return color_2;
				}
			}
		}
		return value;
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
