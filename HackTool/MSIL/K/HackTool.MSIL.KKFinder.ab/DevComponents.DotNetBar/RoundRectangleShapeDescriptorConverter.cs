using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace DevComponents.DotNetBar;

public class RoundRectangleShapeDescriptorConverter : TypeConverter
{
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		if ((object)destinationType == typeof(InstanceDescriptor))
		{
			return true;
		}
		return base.CanConvertTo(context, destinationType);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if ((object)destinationType == null)
		{
			throw new ArgumentNullException("destinationType");
		}
		if ((object)destinationType == typeof(InstanceDescriptor) && value is RoundRectangleShapeDescriptor)
		{
			RoundRectangleShapeDescriptor roundRectangleShapeDescriptor = (RoundRectangleShapeDescriptor)value;
			Type[] array = null;
			MemberInfo memberInfo = null;
			object[] array2 = null;
			if (roundRectangleShapeDescriptor.IsEmpty)
			{
				array = new Type[0];
				memberInfo = typeof(RoundRectangleShapeDescriptor).GetConstructor(array);
				array2 = new object[0];
			}
			else if (roundRectangleShapeDescriptor.IsUniform)
			{
				array = new Type[1] { typeof(int) };
				memberInfo = typeof(RoundRectangleShapeDescriptor).GetConstructor(array);
				array2 = new object[1] { roundRectangleShapeDescriptor.TopLeft };
			}
			else
			{
				array = new Type[4]
				{
					typeof(int),
					typeof(int),
					typeof(int),
					typeof(int)
				};
				memberInfo = typeof(RoundRectangleShapeDescriptor).GetConstructor(array);
				array2 = new object[4] { roundRectangleShapeDescriptor.TopLeft, roundRectangleShapeDescriptor.TopRight, roundRectangleShapeDescriptor.BottomLeft, roundRectangleShapeDescriptor.BottomRight };
			}
			if ((object)memberInfo != null)
			{
				return new InstanceDescriptor(memberInfo, array2);
			}
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
