using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar;

public class ContextExMenuTypeEditor : UITypeEditor
{
	private IWindowsFormsEditorService iwindowsFormsEditorService_0;

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		if (context != null && context.Instance != null && provider != null)
		{
			ref IWindowsFormsEditorService reference = ref iwindowsFormsEditorService_0;
			object? service = provider.GetService(typeof(IWindowsFormsEditorService));
			reference = (IWindowsFormsEditorService)((service is IWindowsFormsEditorService) ? service : null);
			ContextMenuBar contextMenuBar = null;
			GridItem val = (GridItem)((provider is GridItem) ? provider : null);
			string text = "";
			if (val != null)
			{
				text = val.get_Label();
			}
			foreach (IComponent component in context.Container.Components)
			{
				if (component is ContextMenuBar && (text.EndsWith(((ContextMenuBar)component).Name) || text == ""))
				{
					contextMenuBar = component as ContextMenuBar;
					break;
				}
			}
			BaseItem baseItem = null;
			if (value != null && value is BaseItem)
			{
				baseItem = (BaseItem)value;
			}
			if (contextMenuBar != null && iwindowsFormsEditorService_0 != null)
			{
				ListBox val2 = new ListBox();
				val2.add_SelectedIndexChanged((EventHandler)method_0);
				foreach (BaseItem item in contextMenuBar.Items)
				{
					if (item.Name != "")
					{
						int selectedIndex = val2.get_Items().Add((object)item.Name);
						if (item == baseItem)
						{
							((ListControl)val2).set_SelectedIndex(selectedIndex);
						}
					}
				}
				iwindowsFormsEditorService_0.DropDownControl((Control)(object)val2);
				if (val2.get_SelectedItem() != null)
				{
					return contextMenuBar.Items[val2.get_SelectedItem().ToString()];
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
