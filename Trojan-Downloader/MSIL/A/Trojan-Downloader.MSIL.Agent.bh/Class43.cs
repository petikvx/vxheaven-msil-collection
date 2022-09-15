using System;
using ITWX;

internal class Class43
{
	public Type type_0;

	public Class43(Type type_1)
	{
		type_0 = type_1;
	}

	public static string smethod_0(string string_0, string[] string_1)
	{
		return Class41.smethod_28(string_0, string_1);
	}

	public static string smethod_1(string string_0)
	{
		return Class41.smethod_29(string_0);
	}

	protected bool method_0(string string_0, string[] string_1, string string_2, string string_3, string string_4, GClass0.GEnum2 genum2_0, GClass0.GEnum1 genum1_0, GClass0.GEnum4 genum4_0, GClass0.GEnum5 genum5_0)
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
				intPtr = Class41.smethod_23(GClass0.GEnum0.flag_2);
				if (intPtr == IntPtr.Zero)
				{
					return false;
				}
				intPtr2 = Class41.smethod_6(intPtr, string_2, string_3, genum1_0, genum2_0, genum4_0, genum5_0, string_0, "", 0, null, null, null);
				if (intPtr2 == IntPtr.Zero)
				{
					return false;
				}
				if (string_4 != null && string_4 != "")
				{
					Class41.smethod_37(string_2, string_4);
				}
				return true;
			}
			catch (Exception exception_)
			{
				Class47.smethod_8(exception_);
				return false;
			}
			finally
			{
				if (intPtr2 != IntPtr.Zero)
				{
					Class41.smethod_16(intPtr2);
				}
				if (intPtr != IntPtr.Zero)
				{
					Class41.smethod_16(intPtr);
				}
			}
		}
		throw new Exception("Service names cannot contain \\ or / characters.");
	}

	protected bool method_1(IntPtr intptr_0, string string_0, string string_1, string[] string_2, string string_3, string string_4, GClass0.GEnum2 genum2_0, GClass0.GEnum1 genum1_0, GClass0.GEnum4 genum4_0, GClass0.GEnum5 genum5_0)
	{
		if (string_3.Length > 256)
		{
			throw new Exception("The maximum length for a display name is 256 characters.");
		}
		string_1 = smethod_0(string_1, string_2);
		try
		{
			if (!Class41.smethod_13(intptr_0, genum2_0, genum4_0, genum5_0, string_1, "", IntPtr.Zero, null, null, null, string_3))
			{
				return false;
			}
			if (string_4 == null)
			{
				string_4 = "";
			}
			Class41.smethod_37(string_0, string_4);
			return true;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public bool method_2(string string_0)
	{
		Type type = type_0;
		if (type.IsClass && (object)type.BaseType != null && type.BaseType!.Equals(typeof(Class2)))
		{
			object[] customAttributes = type.GetCustomAttributes(typeof(ServiceAttribute), inherit: true);
			if (customAttributes.Length != 1)
			{
				throw new Exception("One, and only one, ServiceAttribute must be applied to the service class to be able to use it with this feature.");
			}
			ServiceAttribute serviceAttribute = customAttributes[0] as ServiceAttribute;
			Class2 @class = (Class2)Activator.CreateInstance(type);
			if (@class.method_2() != null && !(@class.method_2().Trim() == ""))
			{
				string[] array = new string[1] { "-s" };
				if (!Class41.smethod_21(serviceAttribute.Name))
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
						intPtr = Class41.smethod_27(serviceAttribute.Name, GClass0.GEnum1.flag_2 | GClass0.GEnum1.flag_3 | GClass0.GEnum1.flag_6);
						if (intPtr == IntPtr.Zero)
						{
							return false;
						}
						Class41.smethod_33(intPtr);
						if (!method_1(intPtr, serviceAttribute.Name, string_0, array, serviceAttribute.DisplayName, serviceAttribute.Description, serviceAttribute.ServiceType, serviceAttribute.ServiceAccessType, serviceAttribute.ServiceStartType, serviceAttribute.ServiceErrorControl))
						{
							return false;
						}
					}
					finally
					{
						if (intPtr != IntPtr.Zero)
						{
							Class41.smethod_16(intPtr);
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
			intPtr = Class41.smethod_27("usb2e", GClass0.GEnum1.flag_10);
			if (intPtr != IntPtr.Zero)
			{
				return Class41.smethod_7(intPtr);
			}
			return false;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Class41.smethod_16(intPtr);
			}
		}
	}
}
