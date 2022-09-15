using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class GClass0
{
	[Flags]
	public enum GEnum0
	{
		flag_0 = 0,
		flag_1 = 1,
		flag_2 = 2,
		flag_3 = 4,
		flag_4 = 8,
		flag_5 = 0x10,
		flag_6 = 0x20,
		flag_7 = 0xF003F,
		flag_8 = 0x20014,
		flag_9 = 0x20022,
		flag_10 = 0x20009,
		flag_11 = 0xF003F
	}

	[Flags]
	public enum GEnum1
	{
		flag_0 = 0,
		flag_1 = 1,
		flag_2 = 2,
		flag_3 = 4,
		flag_4 = 8,
		flag_5 = 0x10,
		flag_6 = 0x20,
		flag_7 = 0x40,
		flag_8 = 0x80,
		flag_9 = 0x100,
		flag_10 = 0xF01FF,
		flag_11 = 0x2008D,
		flag_12 = 0x20002,
		flag_13 = 0x20170,
		flag_14 = 0xF01FF
	}

	[Flags]
	public enum GEnum2
	{
		flag_0 = 0x20,
		flag_1 = 1,
		flag_2 = 2,
		flag_3 = 0x10,
		flag_4 = 0x20,
		flag_5 = 0x100,
		flag_6 = -1
	}

	[Flags]
	public enum GEnum3
	{
		flag_0 = 7,
		flag_1 = 1,
		flag_2 = 2,
		flag_3 = 4,
		flag_4 = 8,
		flag_5 = 0x10,
		flag_6 = 0x20,
		flag_7 = 0x40,
		flag_8 = 0x80
	}

	public enum GEnum4
	{
		const_0 = 0,
		const_1 = 1,
		const_2 = 2,
		const_3 = 3,
		const_4 = 4,
		const_5 = -1
	}

	public enum GEnum5
	{
		const_0 = 0,
		const_1 = 1,
		const_2 = 2,
		const_3 = 3,
		const_4 = 32768,
		const_5 = -1
	}

	public enum GEnum6
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7
	}

	public enum GEnum7
	{
		const_0 = 1,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10,
		const_11,
		const_12,
		const_13
	}

	[Flags]
	public enum GEnum8
	{
		flag_0 = 1,
		flag_1 = 2,
		flag_2 = 4,
		flag_3 = 8,
		flag_4 = 0x10,
		flag_5 = 0x20,
		flag_6 = 0x40,
		flag_7 = 0x80
	}

	public enum GEnum9
	{
		const_0 = 1,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6
	}

	public delegate void GDelegate0(int int_0);

	public delegate void GDelegate1(int int_0, [MarshalAs(UnmanagedType.LPArray)] string[] string_0);

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct0
	{
		public static readonly int int_0 = Marshal.SizeOf(typeof(Struct0));

		public GEnum2 genum2_0;

		public GEnum6 genum6_0;

		public GEnum3 genum3_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct1
	{
		public string string_0;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		public GDelegate1 gdelegate1_0;

		[SpecialName]
		public static Struct1 smethod_0()
		{
			return default(Struct1);
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class GClass1
	{
		[MarshalAs(UnmanagedType.U4)]
		public GEnum2 genum2_0;

		[MarshalAs(UnmanagedType.U4)]
		public GEnum4 genum4_0;

		[MarshalAs(UnmanagedType.U4)]
		public GEnum5 genum5_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;

		[MarshalAs(UnmanagedType.U4)]
		public uint uint_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_2;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_3;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_4;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct2
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct3
	{
		public int int_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;

		public int int_1;

		public int int_2;
	}

	public const int int_0 = -1;
}
