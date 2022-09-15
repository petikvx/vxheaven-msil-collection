using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class SuperTooltipInfoEditor : UITypeEditor
{
	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		if (context != null && context.Instance != null && provider != null)
		{
			object? service = provider.GetService(typeof(IWindowsFormsEditorService));
			IWindowsFormsEditorService val = (IWindowsFormsEditorService)((service is IWindowsFormsEditorService) ? service : null);
			SuperTooltipInfo superTooltipInfo = value as SuperTooltipInfo;
			SuperTooltip superTooltip = null;
			if (context.PropertyDescriptor != null)
			{
				string displayName = context.PropertyDescriptor.DisplayName;
				if (provider.GetService(typeof(IDesignerHost)) is IDesignerHost designerHost && designerHost.Container != null)
				{
					foreach (IComponent component in designerHost.Container.Components)
					{
						if (component is SuperTooltip superTooltip2 && superTooltip2.Site != null && displayName.EndsWith(superTooltip2.Site!.Name))
						{
							superTooltip = superTooltip2;
							break;
						}
					}
				}
			}
			if (superTooltipInfo == null)
			{
				superTooltipInfo = new SuperTooltipInfo();
				if (!(context.Instance is SuperTooltip))
				{
					if (superTooltip != null && superTooltip.DefaultTooltipSettings != null)
					{
						superTooltipInfo.BodyImage = superTooltip.DefaultTooltipSettings.BodyImage;
						superTooltipInfo.BodyText = superTooltip.DefaultTooltipSettings.BodyText;
						superTooltipInfo.Color = superTooltip.DefaultTooltipSettings.Color;
						superTooltipInfo.CustomSize = superTooltip.DefaultTooltipSettings.CustomSize;
						superTooltipInfo.FooterImage = superTooltip.DefaultTooltipSettings.FooterImage;
						superTooltipInfo.FooterText = superTooltip.DefaultTooltipSettings.FooterText;
						superTooltipInfo.FooterVisible = superTooltip.DefaultTooltipSettings.FooterVisible;
						superTooltipInfo.HeaderText = superTooltip.DefaultTooltipSettings.HeaderText;
						superTooltipInfo.HeaderVisible = superTooltip.DefaultTooltipSettings.HeaderVisible;
					}
					else
					{
						superTooltipInfo.Color = eTooltipColor.System;
					}
				}
			}
			if (val != null)
			{
				SuperTooltipVisualEditor superTooltipVisualEditor = new SuperTooltipVisualEditor();
				superTooltipVisualEditor.EditorProvider = new CustomTypeEditorProvider(context.Container, provider);
				superTooltipVisualEditor.EditorService = val;
				superTooltipVisualEditor.SuperTooltipInfo = superTooltipInfo;
				superTooltipVisualEditor.ParentSuperTooltip = superTooltip;
				Form val2 = new Form();
				((Control)val2).get_Controls().Add((Control)(object)superTooltipVisualEditor);
				val2.set_AcceptButton((IButtonControl)(object)superTooltipVisualEditor.buttonOK);
				val2.set_CancelButton((IButtonControl)(object)superTooltipVisualEditor.buttonCancel);
				val2.set_Size(new Size(((Control)superTooltipVisualEditor).get_Size().Width + SystemInformation.get_Border3DSize().Width * 4, ((Control)superTooltipVisualEditor).get_Size().Height + SystemInformation.get_Border3DSize().Height * 4 + SystemInformation.get_CaptionHeight()));
				((Control)superTooltipVisualEditor).set_Dock((DockStyle)5);
				val2.set_StartPosition((FormStartPosition)1);
				val2.set_MinimizeBox(false);
				val2.set_MaximizeBox(false);
				((Control)val2).set_Text("SuperTooltip Editor");
				val.ShowDialog(val2);
				if (!superTooltipVisualEditor.Canceled)
				{
					SuperTooltipInfo superTooltipInfo2 = superTooltipVisualEditor.SuperTooltipInfo;
					((Component)(object)val2).Dispose();
					return superTooltipInfo2;
				}
				((Component)(object)val2).Dispose();
			}
		}
		return value;
	}

	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (context != null && context.Instance != null)
		{
			return (UITypeEditorEditStyle)2;
		}
		return ((UITypeEditor)this).GetEditStyle(context);
	}
}
