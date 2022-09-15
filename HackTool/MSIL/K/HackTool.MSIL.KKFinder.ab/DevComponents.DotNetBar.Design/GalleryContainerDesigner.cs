using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.Design;

public class GalleryContainerDesigner : ItemContainerDesigner
{
	public override ICollection AssociatedComponents
	{
		get
		{
			ArrayList arrayList = new ArrayList();
			arrayList.AddRange(base.AssociatedComponents);
			if (!(((ComponentDesigner)this).get_Component() is GalleryContainer galleryContainer))
			{
				return arrayList;
			}
			galleryContainer.PopupGalleryItems.method_4(arrayList);
			return arrayList;
		}
	}

	public override void Initialize(IComponent component)
	{
		base.Initialize(component);
		if (component is GalleryContainer)
		{
			((GalleryContainer)component).ButtonItem_0.SetDesignMode(b: true);
		}
	}

	protected override void SetDesignTimeDefaults()
	{
		GalleryContainer galleryContainer = ((ComponentDesigner)this).get_Component() as GalleryContainer;
		galleryContainer.StretchGallery = true;
		galleryContainer.BackgroundStyle.Class = ElementStyleClassKeys.RibbonGalleryContainerKey;
		base.SetDesignTimeDefaults();
	}

	protected override void AddNewItem(BaseItem newItem)
	{
		if (((ComponentDesigner)this).get_Component() is GalleryContainer galleryContainer && !galleryContainer.point_1.IsEmpty && galleryContainer.Rectangle_0.Contains(galleryContainer.point_1))
		{
			galleryContainer.point_1 = Point.Empty;
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(((ComponentDesigner)this).get_Component()).Find("PopupGalleryItems", ignoreCase: true));
			galleryContainer.PopupGalleryItems.Add(newItem);
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(((ComponentDesigner)this).get_Component()).Find("PopupGalleryItems", ignoreCase: true), null, null);
		}
		else
		{
			base.AddNewItem(newItem);
		}
	}

	protected override void NewItemAdded(BaseItem itemAdded)
	{
		base.NewItemAdded(itemAdded);
		if (((ComponentDesigner)this).get_Component() is GalleryContainer galleryContainer && galleryContainer.SubItems.Contains(itemAdded) && !(galleryContainer.Parent is ButtonItem))
		{
			galleryContainer.EnsureVisible(itemAdded);
		}
	}

	protected override void RecalcLayout()
	{
		base.RecalcLayout();
		GalleryContainer galleryContainer = ((ComponentDesigner)this).get_Component() as GalleryContainer;
		if (galleryContainer.ButtonItem_0.Expanded && galleryContainer.ButtonItem_0.PopupControl != null)
		{
			Control popupControl = galleryContainer.ButtonItem_0.PopupControl;
			if (popupControl is MenuPanel)
			{
				((MenuPanel)(object)popupControl).RecalcSize();
			}
			else if (popupControl is Bar)
			{
				((Bar)(object)popupControl).RecalcLayout();
			}
		}
	}

	protected override void ComponentRemoved(ComponentEventArgs e)
	{
		if (e.Component is GalleryGroup)
		{
			GalleryGroup value = e.Component as GalleryGroup;
			if (((ComponentDesigner)this).get_Component() is GalleryContainer galleryContainer && galleryContainer.GalleryGroups.Contains(value))
			{
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				componentChangeService?.OnComponentChanging(galleryContainer, TypeDescriptor.GetProperties(galleryContainer)["GalleryGroups"]);
				galleryContainer.GalleryGroups.Remove(value);
				componentChangeService?.OnComponentChanged(galleryContainer, TypeDescriptor.GetProperties(galleryContainer)["GalleryGroups"], null, null);
			}
		}
		base.ComponentRemoved(e);
	}
}
