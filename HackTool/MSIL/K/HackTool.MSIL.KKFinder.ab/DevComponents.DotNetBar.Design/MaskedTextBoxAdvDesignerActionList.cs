using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar.Controls;

namespace DevComponents.DotNetBar.Design;

public class MaskedTextBoxAdvDesignerActionList : DesignerActionList
{
	private ITypeDiscoveryService itypeDiscoveryService_0;

	private IHelpService ihelpService_0;

	private MaskedTextBoxAdv maskedTextBoxAdv_0;

	private IUIService iuiservice_0;

	public MaskedTextBoxAdvDesignerActionList(MaskedTextBoxAdvDesigner designer)
		: base(((ComponentDesigner)designer).get_Component())
	{
		maskedTextBoxAdv_0 = (MaskedTextBoxAdv)((ComponentDesigner)designer).get_Component();
		itypeDiscoveryService_0 = ((DesignerActionList)this).GetService(typeof(ITypeDiscoveryService)) as ITypeDiscoveryService;
		ref IUIService reference = ref iuiservice_0;
		object service = ((DesignerActionList)this).GetService(typeof(IUIService));
		reference = (IUIService)((service is IUIService) ? service : null);
		ihelpService_0 = ((DesignerActionList)this).GetService(typeof(IHelpService)) as IHelpService;
	}

	public override DesignerActionItemCollection GetSortedActionItems()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		DesignerActionItemCollection val = new DesignerActionItemCollection();
		val.Add((DesignerActionItem)new DesignerActionMethodItem((DesignerActionList)(object)this, "SetMask", "Set Mask..."));
		return val;
	}

	public void SetMask()
	{
		string text = MaskAdvPropertyEditor.smethod_0(itypeDiscoveryService_0, iuiservice_0, maskedTextBoxAdv_0, ihelpService_0);
		if (text != null)
		{
			TypeDescriptor.GetProperties(maskedTextBoxAdv_0)["Mask"]?.SetValue(maskedTextBoxAdv_0, text);
		}
	}
}
