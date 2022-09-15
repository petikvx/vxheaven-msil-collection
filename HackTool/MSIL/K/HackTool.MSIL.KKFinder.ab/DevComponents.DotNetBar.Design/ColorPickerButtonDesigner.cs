using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class ColorPickerButtonDesigner : ButtonXDesigner
{
	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		base.InitializeNewComponent(defaultValues);
		method_17();
	}

	private void method_17()
	{
		ColorPickerButton component = ((ControlDesigner)this).get_Control() as ColorPickerButton;
		TypeDescriptor.GetProperties(component)["Image"]!.SetValue(component, Class109.smethod_67("SystemImages.ColorPickerButtonImage.png"));
		TypeDescriptor.GetProperties(component)["SelectedColorImageRectangle"]!.SetValue(component, new Rectangle(2, 2, 12, 12));
		TypeDescriptor.GetProperties(component)["Text"]!.SetValue(component, "");
		TypeDescriptor.GetProperties(component)["Size"]!.SetValue(component, new Size(37, 23));
	}
}
