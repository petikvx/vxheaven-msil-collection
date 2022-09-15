using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Globalization;
using System.Reflection;

namespace DevComponents.DotNetBar;

public class SuperTooltipInfoConverter : TypeConverter
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
		if ((object)destinationType == typeof(InstanceDescriptor) && value is SuperTooltipInfo)
		{
			SuperTooltipInfo superTooltipInfo = (SuperTooltipInfo)value;
			Type[] array = null;
			MemberInfo memberInfo = null;
			object[] array2 = null;
			if (superTooltipInfo.HeaderVisible && superTooltipInfo.FooterVisible && superTooltipInfo.CustomSize.IsEmpty)
			{
				array = new Type[6]
				{
					typeof(string),
					typeof(string),
					typeof(string),
					typeof(Image),
					typeof(Image),
					typeof(eTooltipColor)
				};
				memberInfo = typeof(SuperTooltipInfo).GetConstructor(array);
				array2 = new object[6] { superTooltipInfo.HeaderText, superTooltipInfo.FooterText, superTooltipInfo.BodyText, superTooltipInfo.BodyImage, superTooltipInfo.FooterImage, superTooltipInfo.Color };
			}
			else
			{
				array = new Type[9]
				{
					typeof(string),
					typeof(string),
					typeof(string),
					typeof(Image),
					typeof(Image),
					typeof(eTooltipColor),
					typeof(bool),
					typeof(bool),
					typeof(Size)
				};
				memberInfo = typeof(SuperTooltipInfo).GetConstructor(array);
				array2 = new object[9] { superTooltipInfo.HeaderText, superTooltipInfo.FooterText, superTooltipInfo.BodyText, superTooltipInfo.BodyImage, superTooltipInfo.FooterImage, superTooltipInfo.Color, superTooltipInfo.HeaderVisible, superTooltipInfo.FooterVisible, superTooltipInfo.CustomSize };
			}
			if ((object)memberInfo != null)
			{
				return new InstanceDescriptor(memberInfo, array2);
			}
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
