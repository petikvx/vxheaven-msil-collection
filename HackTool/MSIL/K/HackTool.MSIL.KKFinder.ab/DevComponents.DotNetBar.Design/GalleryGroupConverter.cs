using System;
using System.ComponentModel;
using System.Globalization;

namespace DevComponents.DotNetBar.Design;

public class GalleryGroupConverter : ExpandableObjectConverter
{
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		if ((object)destinationType == typeof(GalleryGroup))
		{
			return true;
		}
		return base.CanConvertTo(context, destinationType);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if ((object)destinationType == typeof(string) && value is GalleryGroup)
		{
			GalleryGroup galleryGroup = (GalleryGroup)value;
			return galleryGroup.Text;
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
