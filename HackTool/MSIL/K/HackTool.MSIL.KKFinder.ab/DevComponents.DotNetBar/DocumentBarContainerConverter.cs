using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace DevComponents.DotNetBar;

public class DocumentBarContainerConverter : TypeConverter
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
		if ((object)destinationType == typeof(InstanceDescriptor) && value is DocumentBarContainer)
		{
			DocumentBarContainer documentBarContainer = (DocumentBarContainer)value;
			Type[] array = null;
			MemberInfo memberInfo = null;
			object[] array2 = null;
			array = new Type[3]
			{
				typeof(Bar),
				typeof(int),
				typeof(int)
			};
			memberInfo = typeof(DocumentBarContainer).GetConstructor(array);
			array2 = new object[3]
			{
				documentBarContainer.Bar,
				documentBarContainer.LayoutBounds.Width,
				documentBarContainer.LayoutBounds.Height
			};
			if ((object)memberInfo != null)
			{
				return new InstanceDescriptor(memberInfo, array2);
			}
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
