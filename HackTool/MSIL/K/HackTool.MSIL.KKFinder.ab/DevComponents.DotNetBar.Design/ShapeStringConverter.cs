using System;
using System.ComponentModel;
using System.Globalization;

namespace DevComponents.DotNetBar.Design;

public class ShapeStringConverter : TypeConverter
{
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		if ((object)destinationType == typeof(string))
		{
			return true;
		}
		return base.CanConvertTo(context, destinationType);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if ((object)destinationType == typeof(string))
		{
			if (value is RoundRectangleShapeDescriptor)
			{
				RoundRectangleShapeDescriptor roundRectangleShapeDescriptor = (RoundRectangleShapeDescriptor)value;
				if (roundRectangleShapeDescriptor.IsEmpty)
				{
					return "Rectangle";
				}
				return "Round Rectangle";
			}
			if (value is EllipticalShapeDescriptor)
			{
				return "Ellipse";
			}
			if (value == null)
			{
				return "System Default";
			}
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
