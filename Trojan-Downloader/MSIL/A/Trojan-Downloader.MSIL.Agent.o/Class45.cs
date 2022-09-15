using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32;

internal class Class45
{
	private class Class46
	{
		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr OpenSCManagerW(string string_0, string string_1, GClass2.GEnum0 genum0_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr OpenServiceW(IntPtr intptr_0, string string_0, GClass2.GEnum1 genum1_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr CreateServiceW(IntPtr intptr_0, string string_0, string string_1, GClass2.GEnum1 genum1_0, GClass2.GEnum2 genum2_0, GClass2.GEnum4 genum4_0, GClass2.GEnum5 genum5_0, string string_2, string string_3, int int_0, string string_4, string string_5, string string_6);

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteService(IntPtr intptr_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr RegisterServiceCtrlHandlerW(string string_0, [MarshalAs(UnmanagedType.FunctionPtr)] GClass2.GDelegate0 gdelegate0_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool StartServiceCtrlDispatcherW(GClass2.Struct1[] struct1_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool StartServiceW(IntPtr intptr_0, int int_0, string[] string_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetServiceStatus(IntPtr intptr_0, ref GClass2.Struct0 struct0_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool QueryServiceStatus(IntPtr intptr_0, [MarshalAs(UnmanagedType.Struct)] ref GClass2.Struct0 struct0_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ChangeServiceConfigW(IntPtr intptr_0, GClass2.GEnum2 genum2_0, GClass2.GEnum4 genum4_0, GClass2.GEnum5 genum5_0, string string_0, string string_1, IntPtr intptr_1, string string_2, string string_3, string string_4, string string_5);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ChangeServiceConfig2W(IntPtr intptr_0, GClass2.GEnum9 genum9_0, [MarshalAs(UnmanagedType.Struct)] ref GClass2.Struct2 struct2_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "ChangeServiceConfig2W", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ChangeServiceConfig2W_1(IntPtr intptr_0, GClass2.GEnum9 genum9_0, [MarshalAs(UnmanagedType.Struct)] ref GClass2.Struct3 struct3_0);

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseServiceHandle(IntPtr intptr_0);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ControlService(IntPtr intptr_0, GClass2.GEnum7 genum7_0, [MarshalAs(UnmanagedType.Struct)] ref GClass2.Struct0 struct0_0);

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
		Win32Exception ex = Class49.smethod_1();
		Class37.smethod_8(ex);
		if (ex.NativeErrorCode == 5)
		{
			throw new SecurityException("Access Denied.", ex);
		}
		return ex;
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

	protected static IntPtr smethod_3(string string_0, string string_1, GClass2.GEnum0 genum0_0)
	{
		return smethod_2(Class46.OpenSCManagerW(string_0, string_1, genum0_0));
	}

	protected static IntPtr smethod_4(IntPtr intptr_0, string string_0, GClass2.GEnum1 genum1_0)
	{
		return smethod_2(Class46.OpenServiceW(intptr_0, string_0, genum1_0));
	}

	public static IntPtr smethod_5(IntPtr intptr_0, string string_0, string string_1, GClass2.GEnum1 genum1_0, GClass2.GEnum2 genum2_0, GClass2.GEnum4 genum4_0, GClass2.GEnum5 genum5_0, string string_2, string string_3, int int_0, string string_4, string string_5, string string_6)
	{
		return smethod_2(Class46.CreateServiceW(intptr_0, string_0, string_1, genum1_0, genum2_0, genum4_0, genum5_0, string_2, string_3, int_0, string_4, string_5, string_6));
	}

	public static bool smethod_6(IntPtr intptr_0)
	{
		return smethod_1(Class46.DeleteService(intptr_0));
	}

	public static IntPtr smethod_7(string string_0, GClass2.GDelegate0 gdelegate0_0)
	{
		return smethod_2(Class46.RegisterServiceCtrlHandlerW(string_0, gdelegate0_0));
	}

	public static bool smethod_8(GClass2.Struct1[] struct1_0)
	{
		return smethod_1(Class46.StartServiceCtrlDispatcherW(struct1_0));
	}

	protected static bool smethod_9(IntPtr intptr_0, int int_0, string[] string_0)
	{
		return smethod_1(Class46.StartServiceW(intptr_0, int_0, string_0));
	}

	public static bool smethod_10(IntPtr intptr_0, ref GClass2.Struct0 struct0_0)
	{
		return smethod_1(Class46.SetServiceStatus(intptr_0, ref struct0_0));
	}

	protected static bool smethod_11(IntPtr intptr_0, ref GClass2.Struct0 struct0_0)
	{
		return smethod_1(Class46.QueryServiceStatus(intptr_0, ref struct0_0));
	}

	public static bool smethod_12(IntPtr intptr_0, GClass2.GEnum2 genum2_0, GClass2.GEnum4 genum4_0, GClass2.GEnum5 genum5_0, string string_0, string string_1, IntPtr intptr_1, string string_2, string string_3, string string_4, string string_5)
	{
		return smethod_1(Class46.ChangeServiceConfigW(intptr_0, genum2_0, genum4_0, genum5_0, string_0, string_1, intptr_1, string_2, string_3, string_4, string_5));
	}

	protected static bool smethod_13(IntPtr intptr_0, GClass2.GEnum9 genum9_0, ref GClass2.Struct2 struct2_0)
	{
		return smethod_1(Class46.ChangeServiceConfig2W(intptr_0, genum9_0, ref struct2_0));
	}

	protected static bool smethod_14(IntPtr intptr_0, GClass2.GEnum9 genum9_0, ref GClass2.Struct3 struct3_0)
	{
		return smethod_1(Class46.ChangeServiceConfig2W_1(intptr_0, genum9_0, ref struct3_0));
	}

	public static bool smethod_15(IntPtr intptr_0)
	{
		return smethod_1(Class46.CloseServiceHandle(intptr_0));
	}

	protected static bool smethod_16(IntPtr intptr_0, GClass2.GEnum7 genum7_0, ref GClass2.Struct0 struct0_0)
	{
		return smethod_1(Class46.ControlService(intptr_0, genum7_0, ref struct0_0));
	}

	protected static bool smethod_17(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, out uint uint_1)
	{
		return smethod_1(Class46.QueryServiceConfig(intptr_0, intptr_1, uint_0, out uint_1));
	}

	protected static IntPtr smethod_18(IntPtr intptr_0)
	{
		return smethod_2(Class46.LockServiceDatabase(intptr_0));
	}

	protected static bool smethod_19(IntPtr intptr_0)
	{
		return smethod_1(Class46.UnlockServiceDatabase(intptr_0));
	}

	public static bool smethod_20(string string_0)
	{
		IntPtr intptr_;
		bool result = smethod_21(string_0, out intptr_);
		if (intptr_ != IntPtr.Zero)
		{
			smethod_15(intptr_);
		}
		return result;
	}

	public static bool smethod_21(string string_0, out IntPtr intptr_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		intptr_0 = IntPtr.Zero;
		try
		{
			intPtr = smethod_22(GClass2.GEnum0.flag_3);
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			intptr_0 = smethod_24(intPtr, string_0, GClass2.GEnum1.flag_8);
			return intptr_0 != IntPtr.Zero;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				smethod_15(intPtr);
			}
		}
	}

	public static IntPtr smethod_22(GClass2.GEnum0 genum0_0)
	{
		return smethod_3(null, null, genum0_0);
	}

	public static IntPtr smethod_23(GClass2.GEnum1 genum1_0)
	{
		GClass2.GEnum0 gEnum = GClass2.GEnum0.flag_0;
		if ((genum1_0 & GClass2.GEnum1.flag_11) != 0)
		{
			gEnum |= GClass2.GEnum0.flag_8;
		}
		if ((genum1_0 & GClass2.GEnum1.flag_12) != 0)
		{
			gEnum |= GClass2.GEnum0.flag_9;
		}
		if ((genum1_0 & GClass2.GEnum1.flag_13) != 0)
		{
			gEnum |= GClass2.GEnum0.flag_10;
		}
		if ((genum1_0 & GClass2.GEnum1.flag_10) != 0)
		{
			gEnum |= GClass2.GEnum0.flag_7;
		}
		return smethod_3(null, null, gEnum);
	}

	public static IntPtr smethod_24(IntPtr intptr_0, string string_0, GClass2.GEnum1 genum1_0)
	{
		return smethod_4(intptr_0, string_0, genum1_0);
	}

	public static IntPtr smethod_25(string string_0, GClass2.GEnum1 genum1_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = smethod_23(genum1_0);
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
				smethod_15(intPtr);
			}
		}
	}

	public static string smethod_26(string string_0, string[] string_1)
	{
		if (string_0.IndexOf(" ") != -1)
		{
			string_0 = "\"" + string_0 + "\"";
		}
		if (string_1 != null && string_1.Length > 0)
		{
			string_0 = string_0 + " \"" + Class39.smethod_1(string_1, "\", \"") + "\"";
		}
		return string_0;
	}

	public static string smethod_27(string string_0)
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

	public static bool smethod_28(IntPtr intptr_0, ref GClass2.GClass3 gclass3_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			uint uint_ = 0u;
			intPtr = Marshal.AllocHGlobal(4096);
			if (!smethod_17(intptr_0, intPtr, 4096u, out uint_))
			{
				return false;
			}
			Marshal.PtrToStructure(intPtr, (object)gclass3_0);
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

	public static string smethod_29(IntPtr intptr_0)
	{
		GClass2.GClass3 gclass3_ = new GClass2.GClass3();
		if (!smethod_28(intptr_0, ref gclass3_))
		{
			return null;
		}
		return smethod_27(gclass3_.string_0);
	}

	public static Version smethod_30(IntPtr intptr_0)
	{
		string text = smethod_29(intptr_0);
		if (text != null)
		{
			return Class49.smethod_0(text);
		}
		return new Version(0, 0, 0, 0);
	}

	public static bool smethod_31(IntPtr intptr_0)
	{
		GClass2.Struct0 struct0_ = default(GClass2.Struct0);
		return smethod_16(intptr_0, GClass2.GEnum7.const_0, ref struct0_);
	}

	public static bool smethod_32(string string_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = smethod_25(string_0, GClass2.GEnum1.flag_6);
			if (intPtr != IntPtr.Zero)
			{
				return smethod_31(intPtr);
			}
			return false;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				smethod_15(intPtr);
			}
		}
	}

	public static bool smethod_33(IntPtr intptr_0, string[] string_0)
	{
		return smethod_9(intptr_0, (string_0 != null) ? string_0.Length : 0, string_0);
	}

	public static bool smethod_34(string string_0, string[] string_1)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = smethod_25(string_0, GClass2.GEnum1.flag_5);
			if (intPtr != IntPtr.Zero)
			{
				return smethod_9(intPtr, (string_1 != null) ? string_1.Length : 0, string_1);
			}
			return false;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				smethod_15(intPtr);
			}
		}
	}

	public static bool smethod_35(string string_0, string string_1)
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
			Class37.smethod_8(exception_);
			return false;
		}
	}

	public static GClass2.GEnum6 smethod_36(IntPtr intptr_0)
	{
		GClass2.Struct0 struct0_ = default(GClass2.Struct0);
		if (smethod_11(intptr_0, ref struct0_))
		{
			return struct0_.genum6_0;
		}
		return GClass2.GEnum6.const_0;
	}

	public static bool smethod_37(string string_0, GClass2.GEnum4 genum4_0)
	{
		bool flag = false;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		try
		{
			intPtr = smethod_22(GClass2.GEnum0.flag_9);
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			intPtr2 = smethod_24(intPtr, string_0, GClass2.GEnum1.flag_12);
			if (flag = intPtr2 != IntPtr.Zero)
			{
				return smethod_12(intPtr2, GClass2.GEnum2.flag_6, genum4_0, GClass2.GEnum5.const_5, null, null, IntPtr.Zero, null, null, null, null);
			}
			return flag;
		}
		finally
		{
			if (intPtr2 != IntPtr.Zero)
			{
				smethod_15(intPtr2);
			}
			if (intPtr != IntPtr.Zero)
			{
				smethod_15(intPtr);
			}
		}
	}
}
