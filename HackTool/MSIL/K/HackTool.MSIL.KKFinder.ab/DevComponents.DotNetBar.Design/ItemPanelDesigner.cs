using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class ItemPanelDesigner : BarBaseControlDesigner
{
	public override DesignerVerbCollection Verbs
	{
		get
		{
			((ControlDesigner)this).get_Control();
			DesignerVerb[] array = null;
			array = new DesignerVerb[12]
			{
				new DesignerVerb("Add Button", CreateButton),
				new DesignerVerb("Add Horizontal Container", method_16),
				new DesignerVerb("Add Vertical Container", method_15),
				new DesignerVerb("Add Text Box", CreateTextBox),
				new DesignerVerb("Add Combo Box", CreateComboBox),
				new DesignerVerb("Add Label", CreateLabel),
				new DesignerVerb("Add Color Picker", CreateColorPicker),
				new DesignerVerb("Add Progress bar", CreateProgressBar),
				new DesignerVerb("Add Check box", CreateCheckBox),
				new DesignerVerb("Add WinForms Control Container", CreateControlContainer),
				new DesignerVerb("Apply Panel Style", method_13),
				new DesignerVerb("Apply Default Style", method_14)
			};
			return new DesignerVerbCollection(array);
		}
	}

	public ItemPanelDesigner()
	{
		EnableItemDragDrop = true;
	}

	public override void Initialize(IComponent component)
	{
		base.Initialize(component);
		if (component != null && component.Site != null && !component.Site!.DesignMode)
		{
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ParentControlDesigner)this).InitializeNewComponent(defaultValues);
		method_12();
	}

	private void method_12()
	{
		ItemPanel itemPanel = ((ControlDesigner)this).get_Control() as ItemPanel;
		itemPanel.LayoutOrientation = eOrientation.Vertical;
		itemPanel.BackgroundStyle.Border = eStyleBorderType.Solid;
		itemPanel.BackgroundStyle.BorderColor = ColorScheme.GetColor("7F9DB9");
		itemPanel.BackgroundStyle.BorderWidth = 1;
		itemPanel.BackgroundStyle.PaddingLeft = 1;
		itemPanel.BackgroundStyle.PaddingRight = 1;
		itemPanel.BackgroundStyle.PaddingTop = 1;
		itemPanel.BackgroundStyle.PaddingBottom = 1;
		itemPanel.BackgroundStyle.BackColor = Color.White;
	}

	private void method_13(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is ItemPanel itemPanel)
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), null);
			ElementStyle backgroundStyle = itemPanel.BackgroundStyle;
			backgroundStyle.Reset();
			backgroundStyle.Border = eStyleBorderType.Solid;
			backgroundStyle.BorderWidth = 1;
			backgroundStyle.BorderColorSchemePart = eColorSchemePart.PanelBorder;
			backgroundStyle.BackColorSchemePart = eColorSchemePart.PanelBackground;
			backgroundStyle.BackColor2SchemePart = eColorSchemePart.PanelBackground2;
			backgroundStyle.BackColorGradientAngle = 90;
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), null, null, null);
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is ItemPanel itemPanel)
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), null);
			ElementStyle backgroundStyle = itemPanel.BackgroundStyle;
			backgroundStyle.Reset();
			backgroundStyle.Border = eStyleBorderType.Solid;
			backgroundStyle.BorderWidth = 1;
			backgroundStyle.BorderColorSchemePart = eColorSchemePart.PanelBorder;
			backgroundStyle.BackColor = Color.White;
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), null, null, null);
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		method_17(GetItemContainer(), eOrientation.Vertical);
	}

	private void method_16(object sender, EventArgs e)
	{
		method_17(GetItemContainer(), eOrientation.Horizontal);
	}

	private void method_17(BaseItem baseItem_1, eOrientation eOrientation_0)
	{
		m_CreatingItem = true;
		try
		{
			Class108.smethod_0(this, baseItem_1, eOrientation_0);
		}
		finally
		{
			m_CreatingItem = false;
		}
		RecalcLayout();
	}
}
