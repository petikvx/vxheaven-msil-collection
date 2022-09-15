using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar.Controls;

namespace DevComponents.DotNetBar.Design;

public class MaskAdvPropertyEditor : UITypeEditor
{
	internal static string smethod_0(ITypeDiscoveryService itypeDiscoveryService_0, IUIService iuiservice_0, MaskedTextBoxAdv maskedTextBoxAdv_0, IHelpService ihelpService_0)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		string result = null;
		Type type = Type.GetType("System.Windows.Forms.Design.MaskDesignerDialog");
		ConstructorInfo constructor = type.GetConstructor(new Type[2]
		{
			typeof(MaskedTextBox),
			typeof(IHelpService)
		});
		object obj = constructor.Invoke(new object[2] { maskedTextBoxAdv_0.MaskedTextBox, ihelpService_0 });
		Form val = (Form)((obj is Form) ? obj : null);
		try
		{
			MethodInfo method = type.GetMethod("DiscoverMaskDescriptors");
			method.Invoke(val, new object[1] { itypeDiscoveryService_0 });
			DialogResult val2 = ((iuiservice_0 != null) ? iuiservice_0.ShowDialog(val) : val.ShowDialog());
			if ((int)val2 == 1)
			{
				PropertyInfo property = type.GetProperty("Mask");
				result = (string)property.GetValue(val, null);
				property = type.GetProperty("ValidatingType");
				Type type2 = property.GetValue(val, null) as Type;
				if ((object)type2 == maskedTextBoxAdv_0.ValidatingType)
				{
					return result;
				}
				maskedTextBoxAdv_0.ValidatingType = type2;
				return result;
			}
			return result;
		}
		finally
		{
			((Component)(object)val).Dispose();
		}
	}

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		if (context != null && provider != null)
		{
			ITypeDiscoveryService itypeDiscoveryService_ = (ITypeDiscoveryService)provider.GetService(typeof(ITypeDiscoveryService));
			IUIService iuiservice_ = (IUIService)provider.GetService(typeof(IUIService));
			IHelpService ihelpService_ = (IHelpService)provider.GetService(typeof(IHelpService));
			string text = smethod_0(itypeDiscoveryService_, iuiservice_, context.Instance as MaskedTextBoxAdv, ihelpService_);
			if (text != null)
			{
				return text;
			}
		}
		return value;
	}

	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		return (UITypeEditorEditStyle)2;
	}

	public override bool GetPaintValueSupported(ITypeDescriptorContext context)
	{
		return false;
	}
}
