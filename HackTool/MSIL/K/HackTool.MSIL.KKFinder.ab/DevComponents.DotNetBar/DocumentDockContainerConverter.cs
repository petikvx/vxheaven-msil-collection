using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace DevComponents.DotNetBar;

public class DocumentDockContainerConverter : TypeConverter
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
		if ((object)destinationType == typeof(InstanceDescriptor) && value is DocumentDockContainer)
		{
			DocumentDockContainer documentDockContainer = (DocumentDockContainer)value;
			Type[] array = null;
			MemberInfo memberInfo = null;
			object[] array2 = null;
			if (documentDockContainer.Documents.Count == 0)
			{
				array = new Type[0];
				memberInfo = typeof(DocumentDockContainer).GetConstructor(array);
				array2 = new object[0];
			}
			else
			{
				array = new Type[2]
				{
					typeof(DocumentBaseContainer[]),
					typeof(eOrientation)
				};
				memberInfo = typeof(DocumentDockContainer).GetConstructor(array);
				DocumentBaseContainer[] array3 = new DocumentBaseContainer[documentDockContainer.Documents.Count];
				documentDockContainer.Documents.method_0(array3);
				array2 = new object[2] { array3, documentDockContainer.Orientation };
			}
			if ((object)memberInfo != null)
			{
				return new InstanceDescriptor(memberInfo, array2);
			}
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
