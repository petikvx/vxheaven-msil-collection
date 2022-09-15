using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32;

internal class Class41
{
	private class Class42
	{
		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr OpenSCManagerW(string string_0, string string_1, GClass0.GEnum0 genum0_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr OpenServiceW(IntPtr intptr_0, string string_0, GClass0.GEnum1 genum1_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr CreateServiceW(IntPtr intptr_0, string string_0, string string_1, GClass0.GEnum1 genum1_0, GClass0.GEnum2 genum2_0, GClass0.GEnum4 genum4_0, GClass0.GEnum5 genum5_0, string string_2, string string_3, int int_0, string string_4, string string_5, string string_6);

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteService(IntPtr intptr_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr RegisterServiceCtrlHandlerW(string string_0, [MarshalAs(UnmanagedType.FunctionPtr)] GClass0.GDelegate0 gdelegate0_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool StartServiceCtrlDispatcherW(GClass0.Struct1[] struct1_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool StartServiceW(IntPtr intptr_0, int int_0, string[] string_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetServiceStatus(IntPtr intptr_0, ref GClass0.Struct0 struct0_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool QueryServiceStatus(IntPtr intptr_0, [MarshalAs(UnmanagedType.Struct)] ref GClass0.Struct0 struct0_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ChangeServiceConfigW(IntPtr intptr_0, GClass0.GEnum2 genum2_0, GClass0.GEnum4 genum4_0, GClass0.GEnum5 genum5_0, string string_0, string string_1, IntPtr intptr_1, string string_2, string string_3, string string_4, string string_5);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ChangeServiceConfig2W(IntPtr intptr_0, GClass0.GEnum9 genum9_0, [MarshalAs(UnmanagedType.Struct)] ref GClass0.Struct2 struct2_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "ChangeServiceConfig2W", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ChangeServiceConfig2W_1(IntPtr intptr_0, GClass0.GEnum9 genum9_0, [MarshalAs(UnmanagedType.Struct)] ref GClass0.Struct3 struct3_0);

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseServiceHandle(IntPtr intptr_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ControlService(IntPtr intptr_0, GClass0.GEnum7 genum7_0, [MarshalAs(UnmanagedType.Struct)] ref GClass0.Struct0 struct0_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool QueryServiceConfig(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, out uint uint_1);

		[DllImport("advapi32.dll", SetLastError = true)]
		public static extern IntPtr LockServiceDatabase(IntPtr intptr_0);

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UnlockServiceDatabase(IntPtr intptr_0);
	}

	protected static Win32Exception smethod_0()
	{
		Win32Exception ex = Class52.smethod_1();
		if (ex != null)
		{
			Class47.smethod_8(ex);
			if (ex.NativeErrorCode == 5)
			{
				throw new SecurityException("Access Denied.", ex);
			}
			return ex;
		}
		return null;
	}

	protected static bool smethod_1(bool bool_0)
	{
		if (!bool_0)
		{
			smethod_0();
		}
		return bool_0;
	}

	protected static IntPtr smethod_2(IntPtr intptr_0)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			smethod_0();
		}
		return intptr_0;
	}

	protected static IntPtr smethod_3(string string_0, string string_1, GClass0.GEnum0 genum0_0)
	{
		try
		{
			return smethod_2(Class42.OpenSCManagerW(string_0, string_1, genum0_0));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return IntPtr.Zero;
		}
	}

	protected static IntPtr smethod_4(IntPtr intptr_0, string string_0, GClass0.GEnum1 genum1_0)
	{
		return smethod_5(intptr_0, string_0, genum1_0, bool_0: false);
	}

	protected static IntPtr smethod_5(IntPtr intptr_0, string string_0, GClass0.GEnum1 genum1_0, bool bool_0)
	{
		try
		{
			if (!bool_0)
			{
				return smethod_2(Class42.OpenServiceW(intptr_0, string_0, genum1_0));
			}
			return Class42.OpenServiceW(intptr_0, string_0, genum1_0);
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			if (!bool_0)
			{
				smethod_0();
			}
			return IntPtr.Zero;
		}
	}

	public static IntPtr smethod_6(IntPtr intptr_0, string string_0, string string_1, GClass0.GEnum1 genum1_0, GClass0.GEnum2 genum2_0, GClass0.GEnum4 genum4_0, GClass0.GEnum5 genum5_0, string string_2, string string_3, int int_0, string string_4, string string_5, string string_6)
	{
		try
		{
			return smethod_2(Class42.CreateServiceW(intptr_0, string_0, string_1, genum1_0, genum2_0, genum4_0, genum5_0, string_2, string_3, int_0, string_4, string_5, string_6));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return IntPtr.Zero;
		}
	}

	public static bool smethod_7(IntPtr intptr_0)
	{
		try
		{
			return smethod_1(Class42.DeleteService(intptr_0));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return false;
		}
	}

	public static IntPtr smethod_8(string string_0, GClass0.GDelegate0 gdelegate0_0)
	{
		try
		{
			return smethod_2(Class42.RegisterServiceCtrlHandlerW(string_0, gdelegate0_0));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return IntPtr.Zero;
		}
	}

	public static bool smethod_9(GClass0.Struct1[] struct1_0)
	{
		try
		{
			return smethod_1(Class42.StartServiceCtrlDispatcherW(struct1_0));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return false;
		}
	}

	protected static bool smethod_10(IntPtr intptr_0, int int_0, string[] string_0)
	{
		try
		{
			return smethod_1(Class42.StartServiceW(intptr_0, int_0, string_0));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return false;
		}
	}

	public static bool smethod_11(IntPtr intptr_0, ref GClass0.Struct0 struct0_0)
	{
		try
		{
			return smethod_1(Class42.SetServiceStatus(intptr_0, ref struct0_0));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return false;
		}
	}

	protected static bool smethod_12(IntPtr intptr_0, ref GClass0.Struct0 struct0_0)
	{
		try
		{
			return smethod_1(Class42.QueryServiceStatus(intptr_0, ref struct0_0));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return false;
		}
	}

	public static bool smethod_13(IntPtr intptr_0, GClass0.GEnum2 genum2_0, GClass0.GEnum4 genum4_0, GClass0.GEnum5 genum5_0, string string_0, string string_1, IntPtr intptr_1, string string_2, string string_3, string string_4, string string_5)
	{
		try
		{
			return smethod_1(Class42.ChangeServiceConfigW(intptr_0, genum2_0, genum4_0, genum5_0, string_0, string_1, intptr_1, string_2, string_3, string_4, string_5));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return false;
		}
	}

	protected static bool smethod_14(IntPtr intptr_0, GClass0.GEnum9 genum9_0, ref GClass0.Struct2 struct2_0)
	{
		try
		{
			return smethod_1(Class42.ChangeServiceConfig2W(intptr_0, genum9_0, ref struct2_0));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return false;
		}
	}

	protected static bool smethod_15(IntPtr intptr_0, GClass0.GEnum9 genum9_0, ref GClass0.Struct3 struct3_0)
	{
		try
		{
			return smethod_1(Class42.ChangeServiceConfig2W_1(intptr_0, genum9_0, ref struct3_0));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return false;
		}
	}

	public static bool smethod_16(IntPtr intptr_0)
	{
		try
		{
			return smethod_1(Class42.CloseServiceHandle(intptr_0));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return false;
		}
	}

	protected static bool smethod_17(IntPtr intptr_0, GClass0.GEnum7 genum7_0, ref GClass0.Struct0 struct0_0)
	{
		try
		{
			return smethod_1(Class42.ControlService(intptr_0, genum7_0, ref struct0_0));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return false;
		}
	}

	protected static bool smethod_18(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, out uint uint_1)
	{
		uint_1 = 0u;
		try
		{
			return smethod_1(Class42.QueryServiceConfig(intptr_0, intptr_1, uint_0, out uint_1));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return false;
		}
	}

	protected static IntPtr smethod_19(IntPtr intptr_0)
	{
		try
		{
			return smethod_2(Class42.LockServiceDatabase(intptr_0));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return IntPtr.Zero;
		}
	}

	protected static bool smethod_20(IntPtr intptr_0)
	{
		try
		{
			return smethod_1(Class42.UnlockServiceDatabase(intptr_0));
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
			smethod_0();
			return false;
		}
	}

	public static bool smethod_21(string string_0)
	{
		IntPtr intptr_;
		bool result = smethod_22(string_0, out intptr_);
		if (intptr_ != IntPtr.Zero)
		{
			smethod_16(intptr_);
		}
		return result;
	}

	public static bool smethod_22(string string_0, out IntPtr intptr_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		intptr_0 = IntPtr.Zero;
		try
		{
			intPtr = smethod_23(GClass0.GEnum0.flag_3);
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			intptr_0 = smethod_25(intPtr, string_0, GClass0.GEnum1.flag_8, bool_0: true);
			return intptr_0 != IntPtr.Zero;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				smethod_16(intPtr);
			}
		}
	}

	public static IntPtr smethod_23(GClass0.GEnum0 genum0_0)
	{
		return smethod_3(null, null, genum0_0);
	}

	public static IntPtr smethod_24(GClass0.GEnum1 genum1_0)
	{
		GClass0.GEnum0 gEnum = GClass0.GEnum0.flag_0;
		if ((genum1_0 & GClass0.GEnum1.flag_11) != 0)
		{
			gEnum |= GClass0.GEnum0.flag_8;
		}
		if ((genum1_0 & GClass0.GEnum1.flag_12) != 0)
		{
			gEnum |= GClass0.GEnum0.flag_9;
		}
		if ((genum1_0 & GClass0.GEnum1.flag_13) != 0)
		{
			gEnum |= GClass0.GEnum0.flag_10;
		}
		if ((genum1_0 & GClass0.GEnum1.flag_10) != 0)
		{
			gEnum |= GClass0.GEnum0.flag_7;
		}
		return smethod_3(null, null, gEnum);
	}

	public static IntPtr smethod_25(IntPtr intptr_0, string string_0, GClass0.GEnum1 genum1_0, bool bool_0)
	{
		return smethod_5(intptr_0, string_0, genum1_0, bool_0);
	}

	public static IntPtr smethod_26(IntPtr intptr_0, string string_0, GClass0.GEnum1 genum1_0)
	{
		return smethod_4(intptr_0, string_0, genum1_0);
	}

	public static IntPtr smethod_27(string string_0, GClass0.GEnum1 genum1_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = smethod_24(genum1_0);
			if (intPtr != IntPtr.Zero)
			{
				return smethod_4(intPtr, string_0, genum1_0);
			}
			return IntPtr.Zero;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				smethod_16(intPtr);
			}
		}
	}

	public static string smethod_28(string string_0, string[] string_1)
	{
		if (string_0.IndexOf(" ") != -1)
		{
			string_0 = "\"" + string_0 + "\"";
		}
		if (string_1 != null && string_1.Length > 0)
		{
			string_0 = string_0 + " \"" + Class49.smethod_1(string_1, "\", \"") + "\"";
		}
		return string_0;
	}

	public static string smethod_29(string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		string_0 = string_0.Trim();
		string result = string_0;
		if (string_0.StartsWith("\""))
		{
			int num = string_0.IndexOf("\"", 1);
			result = ((num != -1) ? string_0.Substring(1, num - 1) : null);
		}
		else
		{
			int num2 = string_0.IndexOf(" ", 0);
			if (num2 > -1)
			{
				result = string_0.Substring(0, num2);
			}
		}
		return result;
	}

	public static bool smethod_30(IntPtr intptr_0, ref GClass0.GClass1 gclass1_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			uint uint_ = 0u;
			intPtr = Marshal.AllocHGlobal(4096);
			if (!smethod_18(intptr_0, intPtr, 4096u, out uint_))
			{
				return false;
			}
			Marshal.PtrToStructure(intPtr, (object)gclass1_0);
			return true;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	public static string smethod_31(IntPtr intptr_0)
	{
		GClass0.GClass1 gclass1_ = new GClass0.GClass1();
		if (!smethod_30(intptr_0, ref gclass1_))
		{
			return null;
		}
		return smethod_29(gclass1_.string_0);
	}

	public static Version smethod_32(IntPtr intptr_0)
	{
		string text = smethod_31(intptr_0);
		if (text != null)
		{
			return Class52.smethod_0(text);
		}
		return new Version(0, 0, 0, 0);
	}

	public static bool smethod_33(IntPtr intptr_0)
	{
		GClass0.Struct0 struct0_ = default(GClass0.Struct0);
		return smethod_17(intptr_0, GClass0.GEnum7.const_0, ref struct0_);
	}

	public static bool smethod_34(string string_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = smethod_27(string_0, GClass0.GEnum1.flag_6);
			if (intPtr != IntPtr.Zero)
			{
				return smethod_33(intPtr);
			}
			return false;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				smethod_16(intPtr);
			}
		}
	}

	public static bool smethod_35(IntPtr intptr_0, string[] string_0)
	{
		return smethod_10(intptr_0, (string_0 != null) ? string_0.Length : 0, string_0);
	}

	public static bool smethod_36(string string_0, string[] string_1)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = smethod_27(string_0, GClass0.GEnum1.flag_5);
			if (intPtr != IntPtr.Zero)
			{
				return smethod_10(intPtr, (string_1 != null) ? string_1.Length : 0, string_1);
			}
			return false;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				smethod_16(intPtr);
			}
		}
	}

	public static bool smethod_37(string string_0, string string_1)
	{
		try
		{
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Services\\" + string_0, writable: true))
			{
				registryKey.SetValue("Description", string_1);
			}
			return true;
		}
		catch (SecurityException)
		{
			throw;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public static GClass0.GEnum6 smethod_38(IntPtr intptr_0)
	{
		GClass0.Struct0 struct0_ = default(GClass0.Struct0);
		if (smethod_12(intptr_0, ref struct0_))
		{
			return struct0_.genum6_0;
		}
		return GClass0.GEnum6.const_0;
	}

	public static bool smethod_39(string string_0, GClass0.GEnum4 genum4_0)
	{
		bool flag = false;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		try
		{
			intPtr = smethod_23(GClass0.GEnum0.flag_9);
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			intPtr2 = smethod_26(intPtr, string_0, GClass0.GEnum1.flag_12);
			if (flag = intPtr2 != IntPtr.Zero)
			{
				return smethod_13(intPtr2, GClass0.GEnum2.flag_6, genum4_0, GClass0.GEnum5.const_5, null, null, IntPtr.Zero, null, null, null, null);
			}
			return flag;
		}
		finally
		{
			if (intPtr2 != IntPtr.Zero)
			{
				smethod_16(intPtr2);
			}
			if (intPtr != IntPtr.Zero)
			{
				smethod_16(intPtr);
			}
		}
	}
}
