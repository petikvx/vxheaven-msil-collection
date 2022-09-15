using System;
using System.ComponentModel;
using System.Globalization;

namespace DevComponents.DotNetBar.Design;

public class RibbonTabItemGroupConverter : ExpandableObjectConverter
{
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		if ((object)destinationType == typeof(RibbonTabItemGroup))
		{
			return true;
		}
		return base.CanConvertTo(context, destinationType);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if ((object)destinationType == typeof(string) && value is RibbonTabItemGroup)
		{
			RibbonTabItemGroup ribbonTabItemGroup = (RibbonTabItemGroup)value;
			return ribbonTabItemGroup.GroupTitle;
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
