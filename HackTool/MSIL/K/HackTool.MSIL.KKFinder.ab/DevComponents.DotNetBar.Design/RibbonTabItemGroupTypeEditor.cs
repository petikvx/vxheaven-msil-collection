using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class RibbonTabItemGroupTypeEditor : UITypeEditor
{
	private const string string_0 = "<Create new group>";

	private IWindowsFormsEditorService iwindowsFormsEditorService_0;

	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (context != null && context.Instance != null)
		{
			return (UITypeEditorEditStyle)3;
		}
		return ((UITypeEditor)this).GetEditStyle(context);
	}

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		if (context != null && context.Instance != null && provider != null)
		{
			iwindowsFormsEditorService_0 = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
			if (iwindowsFormsEditorService_0 != null)
			{
				RibbonTabItemGroupCollection ribbonTabItemGroupCollection = null;
				RibbonTabItem ribbonTabItem = null;
				RibbonStrip ribbonStrip = null;
				if (context.Instance is RibbonTabItem)
				{
					ribbonTabItem = (RibbonTabItem)context.Instance;
					ribbonStrip = ribbonTabItem.ContainerControl as RibbonStrip;
					if (ribbonStrip != null)
					{
						ribbonTabItemGroupCollection = ribbonStrip.TabGroups;
					}
				}
				if (ribbonTabItemGroupCollection == null && context.Instance != null)
				{
					MessageBox.Show("Unknow control using RibbonTabGroupEditor. Cannot edit groups. [" + context.Instance.ToString() + "]");
				}
				else if (ribbonTabItemGroupCollection == null)
				{
					MessageBox.Show("Unknow control using RibbonTabGroupEditor. Cannot edit groups. [context instance null]");
				}
				ListBox val = new ListBox();
				foreach (RibbonTabItemGroup item in ribbonTabItemGroupCollection)
				{
					val.get_Items().Add((object)item);
					if (item == ribbonTabItem.Group)
					{
						val.set_SelectedItem((object)item);
					}
				}
				val.get_Items().Add((object)"<Create new group>");
				val.add_SelectedIndexChanged((EventHandler)method_0);
				iwindowsFormsEditorService_0.DropDownControl((Control)(object)val);
				value = ((!(val.get_SelectedItem() is string) || !(val.get_SelectedItem().ToString() == "<Create new group>")) ? val.get_SelectedItem() : Class108.smethod_1(ribbonStrip, provider));
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
}
