using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Design;

public class NodeContextMenuTypeEditor : UITypeEditor
{
	private IWindowsFormsEditorService iwindowsFormsEditorService_0;

	public static string DotNetBarPrefix = "DotNetBar.";

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
				ContextMenuBar contextMenuBar = null;
				val.add_SelectedIndexChanged((EventHandler)method_0);
				IDesignerHost designerHost = (IDesignerHost)provider.GetService(typeof(IDesignerHost));
				foreach (IComponent component in designerHost.Container.Components)
				{
					if (component is ContextMenu || component.GetType().FullName == "System.Windows.Forms.ContextMenuStrip")
					{
						val.get_Items().Add((object)component);
					}
					if (!(component is ContextMenuBar))
					{
						continue;
					}
					contextMenuBar = component as ContextMenuBar;
					foreach (BaseItem item in contextMenuBar.Items)
					{
						val.get_Items().Add((object)(DotNetBarPrefix + item.Name));
					}
				}
				iwindowsFormsEditorService_0.DropDownControl((Control)(object)val);
				if (val.get_SelectedItem() != null)
				{
					if (val.get_SelectedItem().ToString()!.StartsWith(DotNetBarPrefix))
					{
						if (context.Instance is Node node && node.TreeControl != null)
						{
							TypeDescriptor.GetProperties(node.TreeControl)["ContextMenuBar"]!.SetValue(node.TreeControl, contextMenuBar);
						}
						return contextMenuBar.Items[val.get_SelectedItem().ToString()!.Substring(DotNetBarPrefix.Length)];
					}
					return val.get_SelectedItem();
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
