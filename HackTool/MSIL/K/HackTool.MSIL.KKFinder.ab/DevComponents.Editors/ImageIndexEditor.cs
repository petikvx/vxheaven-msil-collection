using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace DevComponents.Editors;

public class ImageIndexEditor : UITypeEditor
{
	private ImageList imageList_0;

	public override bool GetPaintValueSupported(ITypeDescriptorContext context)
	{
		return true;
	}

	public override void PaintValue(PaintValueEventArgs e)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (e == null || e.get_Value() == null)
			{
				return;
			}
			int int_ = (int)e.get_Value();
			Image val = method_0(e.get_Context(), int_);
			if (val != null)
			{
				new PaintValueEventArgs(e.get_Context(), (object)val, e.get_Graphics(), e.get_Bounds());
				if (val != null)
				{
					Rectangle bounds = e.get_Bounds();
					bounds.Width--;
					bounds.Height--;
					e.get_Graphics().DrawRectangle(SystemPens.get_WindowFrame(), bounds);
					e.get_Graphics().DrawImage(val, e.get_Bounds());
				}
			}
		}
		catch
		{
		}
	}

	private Image method_0(ITypeDescriptorContext itypeDescriptorContext_0, int int_0)
	{
		if (imageList_0 != null && int_0 >= 0 && int_0 <= imageList_0.get_Images().get_Count())
		{
			return imageList_0.get_Images().get_Item(int_0);
		}
		if (itypeDescriptorContext_0 == null)
		{
			return null;
		}
		object instance = itypeDescriptorContext_0.Instance;
		if (instance == null)
		{
			return null;
		}
		PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(instance);
		if (properties == null)
		{
			return null;
		}
		foreach (PropertyDescriptor item in properties)
		{
			if ((object)item.PropertyType == typeof(ImageList))
			{
				ref ImageList reference = ref imageList_0;
				object? value = item.GetValue(instance);
				reference = (ImageList)((value is ImageList) ? value : null);
				if (imageList_0 != null && int_0 >= 0 && int_0 <= imageList_0.get_Images().get_Count())
				{
					return imageList_0.get_Images().get_Item(int_0);
				}
				break;
			}
		}
		return null;
	}
}
