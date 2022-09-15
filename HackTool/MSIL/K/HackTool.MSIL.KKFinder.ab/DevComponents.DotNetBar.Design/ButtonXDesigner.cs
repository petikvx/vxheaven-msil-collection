using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class ButtonXDesigner : BarBaseControlDesigner
{
	public override DesignerVerbCollection Verbs
	{
		get
		{
			((ControlDesigner)this).get_Control();
			DesignerVerb[] array = null;
			array = new DesignerVerb[13]
			{
				new DesignerVerb("Add Button", CreateButton),
				new DesignerVerb("Add Horizontal Container", method_15),
				new DesignerVerb("Add Vertical Container", method_14),
				new DesignerVerb("Add Gallery Container", CreateGalleryContainer),
				new DesignerVerb("Add Scrollable Container", method_13),
				new DesignerVerb("Add Text Box", CreateTextBox),
				new DesignerVerb("Add Combo Box", CreateComboBox),
				new DesignerVerb("Add Label", CreateLabel),
				new DesignerVerb("Add Check Box", CreateCheckBox),
				new DesignerVerb("Add Slider", CreateSliderItem),
				new DesignerVerb("Add Rating Item", CreateRatingItem),
				new DesignerVerb("Add Control Container", CreateControlContainer),
				new DesignerVerb("Add Color Picker", CreateColorPicker)
			};
			return new DesignerVerbCollection(array);
		}
	}

	public ButtonXDesigner()
	{
		EnableItemDragDrop = false;
		PassiveContainer = true;
	}

	public override void Initialize(IComponent component)
	{
		base.Initialize(component);
		if (component.Site!.DesignMode)
		{
			((ButtonX)component).method_1(bool_5: true);
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ParentControlDesigner)this).InitializeNewComponent(defaultValues);
		method_12();
	}

	private void method_12()
	{
		if (((ControlDesigner)this).get_Control() is ButtonX buttonX)
		{
			buttonX.ColorTable = eButtonColor.OrangeWithBackground;
		}
	}

	protected override void OnitemCreated(BaseItem item)
	{
		TypeDescriptor.GetProperties(item)["GlobalItem"]!.SetValue(item, false);
	}

	private void method_13(object sender, EventArgs e)
	{
		GalleryContainer galleryContainer = CreateComponent(typeof(GalleryContainer)) as GalleryContainer;
		TypeDescriptor.GetProperties(galleryContainer)["MinimumSize"]!.SetValue(galleryContainer, new Size(150, 200));
		TypeDescriptor.GetProperties(galleryContainer.BackgroundStyle)["Class"]!.SetValue(galleryContainer.BackgroundStyle, "");
		TypeDescriptor.GetProperties(galleryContainer)["EnableGalleryPopup"]!.SetValue(galleryContainer, false);
		TypeDescriptor.GetProperties(galleryContainer)["LayoutOrientation"]!.SetValue(galleryContainer, eOrientation.Vertical);
		TypeDescriptor.GetProperties(galleryContainer)["MultiLine"]!.SetValue(galleryContainer, false);
		TypeDescriptor.GetProperties(galleryContainer)["PopupUsesStandardScrollbars"]!.SetValue(galleryContainer, false);
		galleryContainer.NeedRecalcSize = true;
		RecalcLayout();
	}

	private void method_14(object sender, EventArgs e)
	{
		method_16(GetItemContainer(), eOrientation.Vertical);
	}

	private void method_15(object sender, EventArgs e)
	{
		method_16(GetItemContainer(), eOrientation.Horizontal);
	}

	private void method_16(BaseItem baseItem_1, eOrientation eOrientation_0)
	{
		try
		{
			m_CreatingItem = true;
			Class108.smethod_0(this, baseItem_1, eOrientation_0);
		}
		finally
		{
			m_CreatingItem = false;
		}
		RecalcLayout();
	}

	protected override BaseItem GetItemContainer()
	{
		if (((ControlDesigner)this).get_Control() is ButtonX buttonX)
		{
			return buttonX.BaseItem_0;
		}
		return base.GetItemContainer();
	}

	public override bool CanParent(Control control)
	{
		return false;
	}

	protected override void OnMouseDragBegin(int x, int y)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (GetItemContainerControl() is ButtonX buttonX)
		{
			ISelectionService selectionService = ((ComponentDesigner)this).GetService(typeof(ISelectionService)) as ISelectionService;
			bool flag = false;
			if (selectionService != null)
			{
				flag = selectionService.PrimarySelection == ((ComponentDesigner)this).get_Component();
			}
			ButtonItem buttonItem = GetItemContainer() as ButtonItem;
			Point pt = ((Control)buttonX).PointToClient(new Point(x, y));
			new MouseEventArgs((MouseButtons)1048576, 0, pt.X, pt.Y, 0);
			if (buttonItem != null && ((!buttonItem.Rectangle_1.IsEmpty && buttonItem.Rectangle_1.Contains(pt)) || ((!buttonItem.ShowSubItems || buttonItem.SubItemsExpandWidth <= 1) && flag)) && buttonItem.SubItems.Count > 0)
			{
				buttonItem.Expanded = !buttonItem.Expanded;
				return;
			}
		}
		base.OnMouseDragBegin(x, y);
	}

	protected override bool OnMouseDown(ref Message m, MouseButtons button)
	{
		return false;
	}

	protected override bool OnMouseUp(ref Message m)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		ButtonX buttonX = GetItemContainerControl() as ButtonX;
		if (buttonX != null && buttonX.Expanded && !DragInProgress)
		{
			return true;
		}
		bool result = false;
		BaseItem itemContainer = GetItemContainer();
		IOwner iOwner = GetIOwner();
		if (buttonX != null && iOwner != null && itemContainer != null)
		{
			Point point = ((Control)buttonX).PointToClient(Control.get_MousePosition());
			MouseEventArgs objArg = new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0);
			itemContainer.InternalMouseUp(objArg);
			if (base.BaseItem_0 != null)
			{
				method_10(point.X, point.Y);
				return true;
			}
			return result;
		}
		return false;
	}

	protected override void OtherComponentRemoving(object sender, ComponentEventArgs e)
	{
		bool flag = true;
		if (e.Component is BaseItem)
		{
			BaseItem baseItem = e.Component as BaseItem;
			BaseItem itemContainer = GetItemContainer();
			if (baseItem != null && itemContainer != null && itemContainer.SubItems.Contains(baseItem))
			{
				itemContainer.SubItems.Remove(baseItem);
				RecalcLayout();
				flag = false;
			}
		}
		if (flag)
		{
			base.OtherComponentRemoving(sender, e);
		}
	}
}
