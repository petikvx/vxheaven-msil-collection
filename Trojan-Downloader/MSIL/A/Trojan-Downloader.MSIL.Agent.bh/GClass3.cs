using System;
using System.Runtime.InteropServices;

public class GClass3
{
	[Flags]
	internal enum Enum4
	{
		flag_0 = 0x10000,
		flag_1 = 0x20000,
		flag_2 = 0x40000,
		flag_3 = 0x80000,
		flag_4 = 0x100000,
		flag_5 = 0x20000,
		flag_6 = 0x20000,
		flag_7 = 0x20000,
		flag_8 = 0xF0000,
		flag_9 = 0x1F0000
	}

	[Flags]
	internal enum Enum5 : uint
	{
		flag_0 = int.MinValue,
		flag_1 = 0x40000000,
		flag_2 = 0x20000000,
		flag_3 = 0x10000000
	}

	public enum GEnum10
	{
		const_0 = 5
	}

	public enum GEnum11
	{
		const_0 = 0,
		const_1 = 1,
		const_2 = 1,
		const_3 = 2,
		const_4 = 3,
		const_5 = 3,
		const_6 = 4,
		const_7 = 5,
		const_8 = 6,
		const_9 = 7,
		const_10 = 8,
		const_11 = 9,
		const_12 = 10,
		const_13 = 11,
		const_14 = 11
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct4
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public int int_0;

		public int int_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct5
	{
		public int int_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public short short_0;

		public short short_1;

		public byte[] byte_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CreateProcess(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1, IntPtr intptr_2, IntPtr intptr_3, [MarshalAs(UnmanagedType.Struct)] ref Struct5 struct5_0, [MarshalAs(UnmanagedType.Struct)] ref Struct4 struct4_0);

	internal static int smethod_0()
	{
		return Marshal.GetLastWin32Error();
	}

	[DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern IntPtr ShellExecute(IntPtr intptr_0, string string_0, string string_1, string string_2, string string_3, GEnum11 genum11_0);
}
