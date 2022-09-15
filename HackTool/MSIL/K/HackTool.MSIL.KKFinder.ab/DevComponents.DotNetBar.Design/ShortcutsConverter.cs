using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace DevComponents.DotNetBar.Design;

public class ShortcutsConverter : TypeConverter
{
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		if ((object)sourceType == typeof(string))
		{
			return true;
		}
		return base.CanConvertFrom(context, sourceType);
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string)
		{
			return FromString((string)value);
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if ((object)destinationType == typeof(string))
		{
			ShortcutsCollection shortcutsCollection = (ShortcutsCollection)value;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < shortcutsCollection.Count; i++)
			{
				stringBuilder.Append(Enum.GetName(typeof(eShortcut), shortcutsCollection[i]));
				if (i < shortcutsCollection.Count - 1)
				{
					stringBuilder.Append(",");
				}
			}
			return stringBuilder.ToString();
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	private ShortcutsCollection FromString(string str)
	{
		ShortcutsCollection shortcutsCollection = new ShortcutsCollection(null);
		if (!(str == "") && str != null)
		{
			string[] array = str.Split(new char[1] { ',' });
			for (int i = 0; i < array.Length; i++)
			{
				shortcutsCollection.Add((eShortcut)Enum.Parse(typeof(eShortcut), array[i], ignoreCase: true));
			}
			return shortcutsCollection;
		}
		return shortcutsCollection;
	}
}
