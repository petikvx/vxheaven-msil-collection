using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar;

public sealed class ColorSchemeVSEditor : UITypeEditor
{
	private IWindowsFormsEditorService iwindowsFormsEditorService_0;

	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (context != null && context.Instance != null)
		{
			return (UITypeEditorEditStyle)2;
		}
		return ((UITypeEditor)this).GetEditStyle(context);
	}

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (context != null && context.Instance != null && provider != null)
		{
			iwindowsFormsEditorService_0 = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
			if (iwindowsFormsEditorService_0 != null)
			{
				if (context.Instance is Bar)
				{
					Bar bar = context.Instance as Bar;
					if (bar.Owner is DotNetBarManager && ((DotNetBarManager)bar.Owner).UseGlobalColorScheme)
					{
						MessageBox.Show("Please note that your DotNetBarManager has its UseGlobalColorScheme set to true and any changes you make to ColorScheme object on the bar will not be used.");
					}
				}
				else if (context.Instance is DotNetBarManager && !((DotNetBarManager)context.Instance).UseGlobalColorScheme)
				{
					MessageBox.Show("Please note that you need to set UseGlobalColorScheme=true in order for all bars to use ColorScheme you change on this dialog.");
				}
				if (value == null)
				{
					value = new ColorScheme();
				}
				ColorSchemeEditor colorSchemeEditor = new ColorSchemeEditor();
				((Control)colorSchemeEditor).CreateControl();
				colorSchemeEditor.ColorScheme = (ColorScheme)value;
				iwindowsFormsEditorService_0.ShowDialog((Form)(object)colorSchemeEditor);
				if (colorSchemeEditor.ColorSchemeChanged)
				{
					value = colorSchemeEditor.ColorScheme;
					context.OnComponentChanged();
					((ColorScheme)value).bool_57 = true;
					if (context.Instance is Bar)
					{
						((Control)(Bar)context.Instance).Refresh();
					}
				}
				((Form)colorSchemeEditor).Close();
			}
		}
		return value;
	}
}
