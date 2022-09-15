using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.AdvTree.Design;

public class NodeConnectorTypeEditor : UITypeEditor
{
	private const string string_0 = "Create new connector";

	private const string string_1 = "Remove connector";

	private IWindowsFormsEditorService iwindowsFormsEditorService_0;

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		if (context != null && context.Instance != null && provider != null)
		{
			NodeConnector nodeConnector = value as NodeConnector;
			ref IWindowsFormsEditorService reference = ref iwindowsFormsEditorService_0;
			object? service = provider.GetService(typeof(IWindowsFormsEditorService));
			reference = (IWindowsFormsEditorService)((service is IWindowsFormsEditorService) ? service : null);
			if (iwindowsFormsEditorService_0 != null)
			{
				ListBox val = new ListBox();
				val.add_SelectedIndexChanged((EventHandler)method_0);
				if (nodeConnector == null)
				{
					val.get_Items().Add((object)"Create new connector");
				}
				else
				{
					val.get_Items().Add((object)"Remove connector");
				}
				iwindowsFormsEditorService_0.DropDownControl((Control)(object)val);
				IDesignerHost designerHost = (IDesignerHost)provider.GetService(typeof(IDesignerHost));
				if (val.get_SelectedItem() != null && designerHost != null)
				{
					if (val.get_SelectedItem().ToString() == "Create new connector")
					{
						NodeConnector nodeConnector2 = designerHost.CreateComponent(typeof(NodeConnector)) as NodeConnector;
						nodeConnector2.LineWidth = 1;
						value = nodeConnector2;
					}
					else if (val.get_SelectedItem().ToString() == "Remove connector")
					{
						value = null;
						designerHost.DestroyComponent(nodeConnector);
					}
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
