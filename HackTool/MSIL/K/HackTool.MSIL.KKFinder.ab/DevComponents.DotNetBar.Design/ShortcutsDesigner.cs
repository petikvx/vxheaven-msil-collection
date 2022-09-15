using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class ShortcutsDesigner : UITypeEditor
{
	private class Class200 : CheckedListBox
	{
		private struct Struct16
		{
			public string string_0;

			public eShortcut eShortcut_0;

			public Struct16(string name, eShortcut k)
			{
				string_0 = name;
				eShortcut_0 = k;
			}

			public override string ToString()
			{
				return string_0;
			}
		}

		public Class200(ShortcutsCollection editingInstance)
		{
			Array values = Enum.GetValues(typeof(eShortcut));
			for (int i = 1; i < values.Length; i++)
			{
				Struct16 @struct = new Struct16(Enum.GetName(typeof(eShortcut), values.GetValue(i)), (eShortcut)values.GetValue(i));
				if (editingInstance.Contains((eShortcut)values.GetValue(i)))
				{
					((CheckedListBox)this).get_Items().Add((object)@struct, (CheckState)1);
				}
				else
				{
					((CheckedListBox)this).get_Items().Add((object)@struct, (CheckState)0);
				}
			}
		}

		public ShortcutsCollection method_0()
		{
			ShortcutsCollection shortcutsCollection = new ShortcutsCollection(null);
			foreach (Struct16 checkedItem in ((CheckedListBox)this).get_CheckedItems())
			{
				shortcutsCollection.Add(checkedItem.eShortcut_0);
			}
			return shortcutsCollection;
		}
	}

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
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		if (context != null && context.Instance != null && provider != null)
		{
			iwindowsFormsEditorService_0 = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
			if (iwindowsFormsEditorService_0 != null)
			{
				Class200 @class = null;
				if (context.Instance is BaseItem)
				{
					@class = new Class200(((BaseItem)context.Instance).Shortcuts);
				}
				else if (context.Instance is ButtonX)
				{
					@class = new Class200(((ButtonX)context.Instance).Shortcuts);
				}
				else if (context.Instance is DotNetBarManager)
				{
					@class = new Class200(((DotNetBarManager)context.Instance).AutoDispatchShortcuts);
				}
				else if (context.Instance != null)
				{
					MessageBox.Show("Unknow control using shortcuts. Cannot edit shortcuts. [" + context.Instance.ToString() + "]");
				}
				else
				{
					MessageBox.Show("Unknow control using shortcuts. Cannot edit shortcuts. [context instance null]");
				}
				if (@class != null)
				{
					iwindowsFormsEditorService_0.DropDownControl((Control)(object)@class);
					value = @class.method_0();
					((ShortcutsCollection)value).BaseItem_0 = context.Instance as BaseItem;
				}
			}
		}
		return value;
	}
}
