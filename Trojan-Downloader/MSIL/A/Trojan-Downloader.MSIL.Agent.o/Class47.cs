using System;
using W3CS;

internal class Class47
{
	public Type type_0;

	public Class47(Type type_1)
	{
		type_0 = type_1;
	}

	public static string smethod_0(string string_0, string[] string_1)
	{
		return Class45.smethod_26(string_0, string_1);
	}

	public static string smethod_1(string string_0)
	{
		return Class45.smethod_27(string_0);
	}

	protected bool method_0(string string_0, string[] string_1, string string_2, string string_3, string string_4, GClass2.GEnum2 genum2_0, GClass2.GEnum1 genum1_0, GClass2.GEnum4 genum4_0, GClass2.GEnum5 genum5_0)
	{
		if (string_2.Length > 256)
		{
			throw new Exception("The maximum length for a service name is 256 characters.");
		}
		if (string_2.IndexOf("\\") < 0 && string_2.IndexOf("/") < 0)
		{
			if (string_3.Length > 256)
			{
				throw new Exception("The maximum length for a display name is 256 characters.");
			}
			string_0 = smethod_0(string_0, string_1);
			IntPtr intPtr = IntPtr.Zero;
			IntPtr intPtr2 = IntPtr.Zero;
			try
			{
				intPtr = Class45.smethod_22(GClass2.GEnum0.flag_2);
				if (intPtr == IntPtr.Zero)
				{
					return false;
				}
				intPtr2 = Class45.smethod_5(intPtr, string_2, string_3, genum1_0, genum2_0, genum4_0, genum5_0, string_0, "", 0, null, null, null);
				if (intPtr2 == IntPtr.Zero)
				{
					return false;
				}
				if (string_4 != null && string_4 != "")
				{
					Class45.smethod_35(string_2, string_4);
				}
				return true;
			}
			catch (Exception exception_)
			{
				Class37.smethod_8(exception_);
				return false;
			}
			finally
			{
				if (intPtr2 != IntPtr.Zero)
				{
					Class45.smethod_15(intPtr2);
				}
				if (intPtr != IntPtr.Zero)
				{
					Class45.smethod_15(intPtr);
				}
			}
		}
		throw new Exception("Service names cannot contain \\ or / characters.");
	}

	protected bool method_1(IntPtr intptr_0, string string_0, string string_1, string[] string_2, string string_3, string string_4, GClass2.GEnum2 genum2_0, GClass2.GEnum1 genum1_0, GClass2.GEnum4 genum4_0, GClass2.GEnum5 genum5_0)
	{
		if (string_3.Length > 256)
		{
			throw new Exception("The maximum length for a display name is 256 characters.");
		}
		string_1 = smethod_0(string_1, string_2);
		try
		{
			if (!Class45.smethod_12(intptr_0, genum2_0, genum4_0, genum5_0, string_1, "", IntPtr.Zero, null, null, null, string_3))
			{
				return false;
			}
			if (string_4 == null)
			{
				string_4 = "";
			}
			Class45.smethod_35(string_0, string_4);
			return true;
		}
		catch (Exception exception_)
		{
			Class37.smethod_8(exception_);
			return false;
		}
	}

	public bool method_2(string string_0)
	{
		Type type = type_0;
		if (type.IsClass && (object)type.BaseType != null && type.BaseType!.Equals(typeof(Class42)))
		{
			object[] customAttributes = type.GetCustomAttributes(typeof(ServiceAttribute), inherit: true);
			if (customAttributes.Length != 1)
			{
				throw new Exception("One, and only one, ServiceAttribute must be applied to the service class to be able to use it with this feature.");
			}
			ServiceAttribute serviceAttribute = customAttributes[0] as ServiceAttribute;
			Class42 @class = (Class42)Activator.CreateInstance(type);
			if (@class.method_2() != null && !(@class.method_2().Trim() == ""))
			{
				string[] array = new string[1] { "-s" };
				if (!Class45.smethod_20(serviceAttribute.Name))
				{
					if (!method_0(string_0, array, serviceAttribute.Name, serviceAttribute.DisplayName, serviceAttribute.Description, serviceAttribute.ServiceType, serviceAttribute.ServiceAccessType, serviceAttribute.ServiceStartType, serviceAttribute.ServiceErrorControl))
					{
						return false;
					}
				}
				else
				{
					IntPtr intPtr = IntPtr.Zero;
					try
					{
						intPtr = Class45.smethod_25(serviceAttribute.Name, GClass2.GEnum1.flag_2 | GClass2.GEnum1.flag_3 | GClass2.GEnum1.flag_6);
						if (intPtr == IntPtr.Zero)
						{
							return false;
						}
						Class45.smethod_31(intPtr);
						if (!method_1(intPtr, serviceAttribute.Name, string_0, array, serviceAttribute.DisplayName, serviceAttribute.Description, serviceAttribute.ServiceType, serviceAttribute.ServiceAccessType, serviceAttribute.ServiceStartType, serviceAttribute.ServiceErrorControl))
						{
							return false;
						}
					}
					finally
					{
						if (intPtr != IntPtr.Zero)
						{
							Class45.smethod_15(intPtr);
						}
					}
				}
				if (!@class.method_13())
				{
					return false;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public static bool smethod_2()
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Class45.smethod_25("nsssvc", GClass2.GEnum1.flag_10);
			if (intPtr != IntPtr.Zero)
			{
				return Class45.smethod_6(intPtr);
			}
			return false;
		}
		catch (Exception exception_)
		{
			Class37.smethod_8(exception_);
			return false;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Class45.smethod_15(intPtr);
			}
		}
	}
}
