using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class RibbonBarDesigner : BarBaseControlDesigner
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
				new DesignerVerb("Add Horizontal Container", method_14),
				new DesignerVerb("Add Vertical Container", method_13),
				new DesignerVerb("Add Text Box", CreateTextBox),
				new DesignerVerb("Add Combo Box", CreateComboBox),
				new DesignerVerb("Add Label", CreateLabel),
				new DesignerVerb("Add Color Picker", CreateColorPicker),
				new DesignerVerb("Add Check Box", CreateCheckBox),
				new DesignerVerb("Add Slider", CreateSliderItem),
				new DesignerVerb("Add Rating Item", CreateRatingItem),
				new DesignerVerb("Add Gallery Container", CreateGalleryContainer),
				new DesignerVerb("Add Control Container", CreateControlContainer)
			};
			return new DesignerVerbCollection(array);
		}
	}

	[DefaultValue(eDotNetBarStyle.Office2003)]
	[DevCoBrowsable(true)]
	[Description("Specifies the visual style of the control.")]
	[Category("Appearance")]
	[Browsable(true)]
	public eDotNetBarStyle Style
	{
		get
		{
			RibbonBar ribbonBar = ((ControlDesigner)this).get_Control() as RibbonBar;
			return ribbonBar.Style;
		}
		set
		{
			RibbonBar ribbonBar = ((ControlDesigner)this).get_Control() as RibbonBar;
			ribbonBar.Style = value;
			if (((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost && !designerHost.Loading)
			{
				RibbonPredefinedColorSchemes.SetRibbonBarStyle(ribbonBar, value);
			}
		}
	}

	public RibbonBarDesigner()
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
		((ControlDesigner)this).get_Control();
		Style = eDotNetBarStyle.Office2007;
	}

	private void method_13(object sender, EventArgs e)
	{
		method_15(GetItemContainer(), eOrientation.Vertical);
	}

	private void method_14(object sender, EventArgs e)
	{
		method_15(GetItemContainer(), eOrientation.Horizontal);
	}

	private void method_15(BaseItem baseItem_1, eOrientation eOrientation_0)
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

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ParentControlDesigner)this).PreFilterProperties(properties);
		properties["Style"] = TypeDescriptor.CreateProperty(typeof(RibbonBarDesigner), (PropertyDescriptor)properties["Style"]);
	}

	protected override void OnitemCreated(BaseItem item)
	{
		if (item is ButtonItem)
		{
			ButtonItem component = item as ButtonItem;
			TypeDescriptor.GetProperties(component)["SubItemsExpandWidth"]!.SetValue(component, 14);
		}
		base.OnitemCreated(item);
	}
}
