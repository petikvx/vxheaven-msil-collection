using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class TextMarkupUIEditor : UITypeEditor
{
	private IWindowsFormsEditorService iwindowsFormsEditorService_0;

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		if (context != null && context.Instance != null && provider != null)
		{
			ref IWindowsFormsEditorService reference = ref iwindowsFormsEditorService_0;
			object? service = provider.GetService(typeof(IWindowsFormsEditorService));
			reference = (IWindowsFormsEditorService)((service is IWindowsFormsEditorService) ? service : null);
			if (iwindowsFormsEditorService_0 != null)
			{
				TextMarkupEditor textMarkupEditor = new TextMarkupEditor();
				((Control)textMarkupEditor.buttonOK).add_Click((EventHandler)method_0);
				((Control)textMarkupEditor.buttonCancel).add_Click((EventHandler)method_0);
				if (value != null)
				{
					((Control)textMarkupEditor.inputText).set_Text(value.ToString());
				}
				iwindowsFormsEditorService_0.DropDownControl((Control)(object)textMarkupEditor);
				if ((int)textMarkupEditor.DialogResult == 1)
				{
					string text = ((Control)textMarkupEditor.inputText).get_Text();
					((Component)(object)textMarkupEditor).Dispose();
					return text;
				}
				((Component)(object)textMarkupEditor).Dispose();
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
