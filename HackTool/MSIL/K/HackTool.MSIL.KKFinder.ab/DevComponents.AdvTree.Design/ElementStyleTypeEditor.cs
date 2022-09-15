using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Design;

public class ElementStyleTypeEditor : UITypeEditor
{
	private const string string_0 = "Create style";

	private const string string_1 = "Delete selected style";

	private const string string_2 = "Styles.";

	private IWindowsFormsEditorService iwindowsFormsEditorService_0;

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		if (context != null && context.Instance != null && provider != null)
		{
			ElementStyle elementStyle = value as ElementStyle;
			ref IWindowsFormsEditorService reference = ref iwindowsFormsEditorService_0;
			object? service = provider.GetService(typeof(IWindowsFormsEditorService));
			reference = (IWindowsFormsEditorService)((service is IWindowsFormsEditorService) ? service : null);
			if (iwindowsFormsEditorService_0 != null)
			{
				AdvTree advTree = null;
				if (context.Instance is AdvTree)
				{
					advTree = context.Instance as AdvTree;
				}
				else if (context.Instance is Node)
				{
					advTree = ((Node)context.Instance).TreeControl;
				}
				else if (context.Instance is Cell)
				{
					advTree = ((Cell)context.Instance).TreeControl;
				}
				ListBox val = new ListBox();
				if (elementStyle == null)
				{
					val.get_Items().Add((object)"Create style");
				}
				else
				{
					val.get_Items().Add((object)"Delete selected style");
				}
				if (advTree != null)
				{
					foreach (ElementStyle style2 in advTree.Styles)
					{
						val.get_Items().Add((object)style2);
					}
				}
				string[] names = Enum.GetNames(typeof(ePredefinedElementStyle));
				string[] array = names;
				foreach (string text in array)
				{
					val.get_Items().Add((object)("Styles." + text));
				}
				val.add_SelectedIndexChanged((EventHandler)method_0);
				iwindowsFormsEditorService_0.DropDownControl((Control)(object)val);
				IDesignerHost designerHost = (IDesignerHost)provider.GetService(typeof(IDesignerHost));
				if (val.get_SelectedItem() != null && designerHost != null)
				{
					if (val.get_SelectedItem() is ElementStyle)
					{
						value = val.get_SelectedItem() as ElementStyle;
					}
					else if (val.get_SelectedItem() != null && val.get_SelectedItem().ToString()!.StartsWith("Styles."))
					{
						string text2 = val.get_SelectedItem().ToString()!.Substring("Styles.".Length);
						Type typeFromHandle = typeof(NodeStyles);
						ElementStyle style = typeFromHandle.GetProperty(text2)!.GetValue(null, null) as ElementStyle;
						ElementStyle elementStyle3 = designerHost.CreateComponent(typeof(ElementStyle)) as ElementStyle;
						elementStyle3.ApplyStyle(style);
						elementStyle3.Description = text2;
						value = elementStyle3;
						if (advTree != null)
						{
							IComponentChangeService componentChangeService = provider.GetService(typeof(IComponentChangeService)) as IComponentChangeService;
							componentChangeService?.OnComponentChanging(advTree, TypeDescriptor.GetProperties(advTree)["Style"]);
							advTree.Styles.Add(value as ElementStyle);
							componentChangeService?.OnComponentChanged(advTree, TypeDescriptor.GetProperties(advTree)["Style"], null, null);
						}
					}
					else if (val.get_SelectedItem() != null && val.get_SelectedItem().ToString() == "Create style")
					{
						value = designerHost.CreateComponent(typeof(ElementStyle)) as ElementStyle;
						if (advTree != null)
						{
							IComponentChangeService componentChangeService2 = provider.GetService(typeof(IComponentChangeService)) as IComponentChangeService;
							componentChangeService2?.OnComponentChanging(advTree, TypeDescriptor.GetProperties(advTree)["Style"]);
							advTree.Styles.Add(value as ElementStyle);
							componentChangeService2?.OnComponentChanged(advTree, TypeDescriptor.GetProperties(advTree)["Style"], null, null);
						}
					}
					else if (val.get_SelectedItem() != null && val.get_SelectedItem().ToString() == "Delete selected style")
					{
						if (advTree != null)
						{
							IComponentChangeService componentChangeService3 = provider.GetService(typeof(IComponentChangeService)) as IComponentChangeService;
							componentChangeService3?.OnComponentChanging(advTree, TypeDescriptor.GetProperties(advTree)["Style"]);
							advTree?.Styles.Remove(value as ElementStyle);
							componentChangeService3?.OnComponentChanged(advTree, TypeDescriptor.GetProperties(advTree)["Style"], null, null);
							value = ((advTree.Styles.Count <= 0) ? null : advTree.Styles[0]);
						}
						else
						{
							value = null;
						}
						designerHost.DestroyComponent(elementStyle);
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
