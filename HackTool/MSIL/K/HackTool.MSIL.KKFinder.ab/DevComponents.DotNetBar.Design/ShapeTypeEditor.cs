using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class ShapeTypeEditor : UITypeEditor
{
	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		return (UITypeEditorEditStyle)2;
	}

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		if (context != null && provider != null)
		{
			IUIService iuiservice_ = (IUIService)provider.GetService(typeof(IUIService));
			IHelpService ihelpService_ = (IHelpService)provider.GetService(typeof(IHelpService));
			return smethod_0(iuiservice_, context.Instance, ihelpService_, value);
		}
		return value;
	}

	internal static IShapeDescriptor smethod_0(IUIService iuiservice_0, object object_0, IHelpService ihelpService_0, object object_1)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		ShapeEditorForm shapeEditorForm = new ShapeEditorForm();
		shapeEditorForm.Value = object_1 as IShapeDescriptor;
		if (iuiservice_0 != null)
		{
			iuiservice_0.ShowDialog((Form)(object)shapeEditorForm);
		}
		else
		{
			((Form)shapeEditorForm).ShowDialog();
		}
		if ((int)((Form)shapeEditorForm).get_DialogResult() == 1)
		{
			object_1 = shapeEditorForm.Value;
		}
		((Component)(object)shapeEditorForm).Dispose();
		return object_1 as IShapeDescriptor;
	}
}
