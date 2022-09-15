using System;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar.Design;

public class ItemContainerDesigner : BaseItemDesigner
{
	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] value = new DesignerVerb[14]
			{
				new DesignerVerb("Add Button", CreateButton),
				new DesignerVerb("Add Horizontal Container", method_1),
				new DesignerVerb("Add Vertical Container", method_0),
				new DesignerVerb("Add Scrollable Container", CreateGallery),
				new DesignerVerb("Add Text Box", CreateTextBox),
				new DesignerVerb("Add Combo Box", CreateComboBox),
				new DesignerVerb("Add Label", CreateLabel),
				new DesignerVerb("Add Check Box", CreateCheckBox),
				new DesignerVerb("Add Control Container", CreateControlContainer),
				new DesignerVerb("Add Color Picker", CreateColorPicker),
				new DesignerVerb("Add Progress bar", CreateProgressBar),
				new DesignerVerb("Add Rating Item", CreateRatingItem),
				new DesignerVerb("Add Slider", CreateSlider),
				new DesignerVerb("Add Month Calendar", CreateMonthCalendar)
			};
			return new DesignerVerbCollection(value);
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		method_2(eOrientation.Vertical);
	}

	private void method_1(object sender, EventArgs e)
	{
		method_2(eOrientation.Horizontal);
	}

	private void method_2(eOrientation eOrientation_0)
	{
		try
		{
			m_CreatingItem = true;
			Class108.smethod_0(this, (BaseItem)((ComponentDesigner)this).get_Component(), eOrientation_0);
			RecalcLayout();
		}
		finally
		{
			m_CreatingItem = false;
		}
	}
}
