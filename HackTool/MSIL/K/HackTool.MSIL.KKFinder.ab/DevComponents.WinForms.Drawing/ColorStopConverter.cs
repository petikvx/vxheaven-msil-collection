using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Globalization;
using System.Reflection;

namespace DevComponents.WinForms.Drawing;

public class ColorStopConverter : TypeConverter
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
		if ((object)destinationType == typeof(InstanceDescriptor) && value is ColorStop)
		{
			ColorStop colorStop = (ColorStop)value;
			Type[] array = null;
			MemberInfo memberInfo = null;
			object[] array2 = null;
			array = new Type[2]
			{
				typeof(Color),
				typeof(float)
			};
			memberInfo = typeof(ColorStop).GetConstructor(array);
			array2 = new object[2] { colorStop.Color, colorStop.Position };
			if ((object)memberInfo != null)
			{
				return new InstanceDescriptor(memberInfo, array2);
			}
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
