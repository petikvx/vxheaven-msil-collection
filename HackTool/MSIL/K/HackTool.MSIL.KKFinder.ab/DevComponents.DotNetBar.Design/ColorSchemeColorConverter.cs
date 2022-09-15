using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;

namespace DevComponents.DotNetBar.Design;

public class ColorSchemeColorConverter : ColorConverter
{
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		Color color = Color.Empty;
		if (value is string && value.ToString()!.StartsWith("CS."))
		{
			string name = context.PropertyDescriptor.Name;
			PropertyInfo property = context.Instance.GetType().GetProperty(name + "SchemePart", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if ((object)property != null)
			{
				property.SetValue(context.Instance, Enum.Parse(typeof(eColorSchemePart), value.ToString()!.Substring(4)), new object[0]);
				color = (Color)context.PropertyDescriptor.GetValue(context.Instance);
			}
			return color;
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (context != null && (object)destinationType == typeof(string) && value is Color)
		{
			string name = context.PropertyDescriptor.Name;
			PropertyInfo property = context.Instance.GetType().GetProperty(name + "SchemePart", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if ((object)property != null)
			{
				eColorSchemePart eColorSchemePart = (eColorSchemePart)property.GetValue(context.Instance, new object[0]);
				if (eColorSchemePart != eColorSchemePart.None)
				{
					return "CS." + eColorSchemePart;
				}
			}
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
