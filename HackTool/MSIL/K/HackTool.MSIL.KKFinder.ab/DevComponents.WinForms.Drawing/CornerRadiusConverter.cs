using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Text;

namespace DevComponents.WinForms.Drawing;

public class CornerRadiusConverter : TypeConverter
{
	public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType)
	{
		switch (Type.GetTypeCode(sourceType))
		{
		default:
			return false;
		case TypeCode.Int16:
		case TypeCode.UInt16:
		case TypeCode.Int32:
		case TypeCode.UInt32:
		case TypeCode.Int64:
		case TypeCode.UInt64:
		case TypeCode.Single:
		case TypeCode.Double:
		case TypeCode.Decimal:
		case TypeCode.String:
			return true;
		}
	}

	public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType)
	{
		if ((object)destinationType != typeof(InstanceDescriptor) && (object)destinationType != typeof(string))
		{
			return false;
		}
		return true;
	}

	public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source)
	{
		if (source == null)
		{
			throw GetConvertFromException(source);
		}
		if (source is string)
		{
			return FromString((string)source, cultureInfo);
		}
		return new CornerRadius(Convert.ToInt32(source, cultureInfo));
	}

	public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if ((object)destinationType == null)
		{
			throw new ArgumentNullException("destinationType");
		}
		if (!(value is CornerRadius cornerRadius))
		{
			throw new ArgumentException("Unexpected parameter type", "value");
		}
		if ((object)destinationType == typeof(string))
		{
			return ToString(cornerRadius, cultureInfo);
		}
		if ((object)destinationType != typeof(InstanceDescriptor))
		{
			throw new ArgumentException("Cannot convert to type " + destinationType.FullName);
		}
		return new InstanceDescriptor(typeof(CornerRadius).GetConstructor(new Type[4]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}), new object[4] { cornerRadius.TopLeft, cornerRadius.TopRight, cornerRadius.BottomRight, cornerRadius.BottomLeft });
	}

	internal static CornerRadius FromString(string s, CultureInfo cultureInfo)
	{
		string[] array = s.Split(new char[1] { GetNumericListSeparator(cultureInfo) });
		int[] array2 = new int[4];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = int.Parse(array[i], cultureInfo);
		}
		return Math.Min(5, array.Length) switch
		{
			4 => new CornerRadius(array2[0], array2[1], array2[2], array2[3]), 
			1 => new CornerRadius(array2[0]), 
			_ => throw new FormatException("Invalid string corner radius"), 
		};
	}

	internal static string ToString(CornerRadius cr, CultureInfo cultureInfo)
	{
		char numericListSeparator = GetNumericListSeparator(cultureInfo);
		StringBuilder stringBuilder = new StringBuilder(64);
		stringBuilder.Append(cr.TopLeft.ToString(cultureInfo));
		stringBuilder.Append(numericListSeparator);
		stringBuilder.Append(cr.TopRight.ToString(cultureInfo));
		stringBuilder.Append(numericListSeparator);
		stringBuilder.Append(cr.BottomRight.ToString(cultureInfo));
		stringBuilder.Append(numericListSeparator);
		stringBuilder.Append(cr.BottomLeft.ToString(cultureInfo));
		return stringBuilder.ToString();
	}

	internal static char GetNumericListSeparator(IFormatProvider provider)
	{
		char c = ',';
		NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
		if (instance.NumberDecimalSeparator.Length > 0 && c == instance.NumberDecimalSeparator[0])
		{
			c = ';';
		}
		return c;
	}
}
