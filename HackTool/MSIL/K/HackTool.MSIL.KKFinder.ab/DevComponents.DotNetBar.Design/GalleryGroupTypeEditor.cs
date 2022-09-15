using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class GalleryGroupTypeEditor : UITypeEditor
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
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		if (context != null && context.Instance != null && provider != null)
		{
			iwindowsFormsEditorService_0 = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
			if (iwindowsFormsEditorService_0 != null)
			{
				GalleryGroupCollection galleryGroupCollection = null;
				BaseItem baseItem = null;
				GalleryContainer galleryContainer = null;
				if (context.Instance is BaseItem)
				{
					baseItem = (BaseItem)context.Instance;
					galleryContainer = baseItem.Parent as GalleryContainer;
					if (galleryContainer == null)
					{
						MessageBox.Show("Item does not belong to the Gallery. Cannot edit groups.");
						return value;
					}
					galleryGroupCollection = galleryContainer.GalleryGroups;
				}
				if (galleryGroupCollection == null && context.Instance != null)
				{
					MessageBox.Show("Unknow control using GalleryGroupTypeEditor. Cannot edit groups. [" + context.Instance.ToString() + "]");
				}
				else if (galleryGroupCollection == null)
				{
					MessageBox.Show("Unknow control using GalleryGroupTypeEditor. Cannot edit groups. [context instance null]");
				}
				GalleryGroup galleryGroup = galleryContainer.GetGalleryGroup(baseItem);
				ListBox val = new ListBox();
				foreach (GalleryGroup item in galleryGroupCollection)
				{
					val.get_Items().Add((object)item);
					if (item == galleryGroup)
					{
						val.set_SelectedItem((object)item);
					}
				}
				val.get_Items().Add((object)"<Create new group>");
				val.add_SelectedIndexChanged((EventHandler)method_0);
				iwindowsFormsEditorService_0.DropDownControl((Control)(object)val);
				value = ((!(val.get_SelectedItem() is string) || !(val.get_SelectedItem().ToString() == "<Create new group>")) ? val.get_SelectedItem() : Class108.smethod_2(galleryContainer, provider));
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
