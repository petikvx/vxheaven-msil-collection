using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class93
{
	private static Type type_0;

	private static Type type_1;

	private static Type type_2;

	static Class93()
	{
		type_0 = typeof(string);
		type_2 = typeof(bool);
		type_1 = typeof(CheckState);
	}

	internal static object smethod_0(object object_0, Type type_3, TypeConverter typeConverter_0, TypeConverter typeConverter_1, string string_0, IFormatProvider iformatProvider_0, object object_1, object object_2)
	{
		if (smethod_7(object_0, object_2))
		{
			object_0 = DBNull.Value;
		}
		Type type = type_3;
		type_3 = smethod_5(type_3);
		typeConverter_0 = smethod_6(typeConverter_0);
		typeConverter_1 = smethod_6(typeConverter_1);
		bool flag = (object)type_3 != type;
		object obj = smethod_2(object_0, type_3, typeConverter_0, typeConverter_1, string_0, iformatProvider_0, object_1);
		if (type.IsValueType && obj == null && !flag)
		{
			throw new FormatException(smethod_1(object_0, type_3));
		}
		return obj;
	}

	private static string smethod_1(object object_0, Type type_3)
	{
		string format = ((object_0 == null) ? "Can't convert null value" : "Specified format cannot be converted");
		return string.Format(CultureInfo.CurrentCulture, format, new object[2] { object_0, type_3.Name });
	}

	private static object smethod_2(object object_0, Type type_3, TypeConverter typeConverter_0, TypeConverter typeConverter_1, string string_0, IFormatProvider iformatProvider_0, object object_1)
	{
		if (object_0 != DBNull.Value && object_0 != null)
		{
			if ((object)type_3 == type_0 && object_0 is IFormattable && !string.IsNullOrEmpty(string_0))
			{
				return (object_0 as IFormattable).ToString(string_0, iformatProvider_0);
			}
			Type type = object_0.GetType();
			TypeConverter converter = TypeDescriptor.GetConverter(type);
			if (typeConverter_0 != null && typeConverter_0 != converter && typeConverter_0.CanConvertTo(type_3))
			{
				return typeConverter_0.ConvertTo(null, smethod_3(iformatProvider_0), object_0, type_3);
			}
			TypeConverter converter2 = TypeDescriptor.GetConverter(type_3);
			if (typeConverter_1 != null && typeConverter_1 != converter2 && typeConverter_1.CanConvertFrom(type))
			{
				return typeConverter_1.ConvertFrom(null, smethod_3(iformatProvider_0), object_0);
			}
			if ((object)type_3 == type_1)
			{
				if ((object)type == type_2)
				{
					return (object)(CheckState)(((bool)object_0) ? 1 : 0);
				}
				if (typeConverter_0 == null)
				{
					typeConverter_0 = converter;
				}
				if (typeConverter_0 != null && typeConverter_0.CanConvertTo(type_2))
				{
					return (object)(CheckState)(((bool)typeConverter_0.ConvertTo(null, smethod_3(iformatProvider_0), object_0, type_2)) ? 1 : 0);
				}
			}
			if (type_3.IsAssignableFrom(type))
			{
				return object_0;
			}
			if (typeConverter_0 == null)
			{
				typeConverter_0 = converter;
			}
			if (typeConverter_1 == null)
			{
				typeConverter_1 = converter2;
			}
			if (typeConverter_0 != null && typeConverter_0.CanConvertTo(type_3))
			{
				return typeConverter_0.ConvertTo(null, smethod_3(iformatProvider_0), object_0, type_3);
			}
			if (typeConverter_1 != null && typeConverter_1.CanConvertFrom(type))
			{
				return typeConverter_1.ConvertFrom(null, smethod_3(iformatProvider_0), object_0);
			}
			if (!(object_0 is IConvertible))
			{
				throw new FormatException(smethod_1(object_0, type_3));
			}
			return smethod_4(object_0, type_3, iformatProvider_0);
		}
		if (object_1 != null)
		{
			return object_1;
		}
		if ((object)type_3 == type_0)
		{
			return string.Empty;
		}
		if ((object)type_3 == type_1)
		{
			return (object)(CheckState)2;
		}
		return null;
	}

	private static CultureInfo smethod_3(IFormatProvider iformatProvider_0)
	{
		if (iformatProvider_0 is CultureInfo)
		{
			return iformatProvider_0 as CultureInfo;
		}
		return CultureInfo.CurrentCulture;
	}

	private static object smethod_4(object object_0, Type type_3, IFormatProvider iformatProvider_0)
	{
		try
		{
			if (iformatProvider_0 == null)
			{
				iformatProvider_0 = CultureInfo.CurrentCulture;
			}
			return Convert.ChangeType(object_0, type_3, iformatProvider_0);
		}
		catch (InvalidCastException ex)
		{
			throw new FormatException(ex.Message, ex);
		}
	}

	private static Type smethod_5(Type type_3)
	{
		if ((object)type_3 == type_0)
		{
			return type_0;
		}
		return Nullable.GetUnderlyingType(type_3) ?? type_3;
	}

	private static TypeConverter smethod_6(TypeConverter typeConverter_0)
	{
		if (!(typeConverter_0 is NullableConverter nullableConverter))
		{
			return typeConverter_0;
		}
		return nullableConverter.UnderlyingTypeConverter;
	}

	internal static bool smethod_7(object object_0, object object_1)
	{
		if (object_0 != null && object_0 != DBNull.Value)
		{
			return object.Equals(object_0, smethod_8(object_0.GetType(), object_1));
		}
		return true;
	}

	internal static object smethod_8(Type type_3, object object_0)
	{
		if (type_3.IsGenericType && (object)type_3.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			if (object_0 != null && object_0 != DBNull.Value)
			{
				return object_0;
			}
			return null;
		}
		return object_0;
	}
}
