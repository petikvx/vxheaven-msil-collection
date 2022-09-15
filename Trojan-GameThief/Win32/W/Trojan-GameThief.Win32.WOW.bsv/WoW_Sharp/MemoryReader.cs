using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace WoW_Sharp;

public class MemoryReader
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct1
	{
		public int int_0;

		public long long_0;

		public int int_1;
	}

	private struct Struct2
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public IntPtr intptr_0;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public uint uint_7;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;
	}

	private const uint uint_0 = 1u;

	private const uint uint_1 = 2u;

	private const uint uint_2 = 4u;

	private const uint uint_3 = 8u;

	private const uint uint_4 = 16u;

	private const uint uint_5 = 32u;

	private const uint uint_6 = 64u;

	private const uint uint_7 = 128u;

	private const uint uint_8 = 256u;

	private const uint uint_9 = 512u;

	private const uint uint_10 = 1024u;

	private const uint uint_11 = 1u;

	private const uint uint_12 = 2u;

	private const uint uint_13 = 4u;

	private const uint uint_14 = 8u;

	private const uint uint_15 = 16u;

	private const uint uint_16 = 15u;

	private const uint uint_17 = 2147483648u;

	private const int int_0 = 2;

	private const int int_1 = 32;

	private const int int_2 = 8;

	private bool bool_0 = false;

	private IntPtr intptr_0 = IntPtr.Zero;

	internal IntPtr intptr_1 = IntPtr.Zero;

	private Process process_0 = null;

	public Process ReadProcess => process_0;

	public bool IsOpen => bool_0;

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint uint_18, int int_3, uint uint_19);

	[DllImport("kernel32.dll")]
	private static extern int CloseHandle(IntPtr intptr_2);

	[DllImport("kernel32.dll")]
	private static extern int ReadProcessMemory(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, int int_3, ref IntPtr intptr_5);

	[DllImport("kernel32.dll")]
	private static extern int WriteProcessMemory(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, int int_3, ref IntPtr intptr_5);

	[DllImport("kernel32.dll")]
	private static extern IntPtr CreateToolhelp32Snapshot(uint uint_18, uint uint_19);

	[DllImport("kernel32.dll")]
	private static extern int Process32First(IntPtr intptr_2, ref Struct2 struct2_0);

	[DllImport("kernel32.dll")]
	private static extern int Process32Next(IntPtr intptr_2, ref Struct2 struct2_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int OpenProcessToken(int int_3, int int_4, ref int int_5);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern int GetCurrentProcess();

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int LookupPrivilegeValue(string string_0, string string_1, ref long long_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int AdjustTokenPrivileges(int int_3, int int_4, ref Struct1 struct1_0, int int_5, int int_6, int int_7);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetSecurityInfo(int int_3, int int_4, int int_5, int int_6, int int_7, out IntPtr intptr_2, IntPtr intptr_3, out IntPtr intptr_4);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SetSecurityInfo(int int_3, int int_4, int int_5, int int_6, int int_7, IntPtr intptr_2, IntPtr intptr_3);

	internal Process[] method_0(string string_0)
	{
		ArrayList arrayList = new ArrayList();
		IntPtr intPtr = CreateToolhelp32Snapshot(2u, 0u);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		Struct2 struct2_ = default(Struct2);
		struct2_.uint_0 = 296u;
		for (int num = Process32First(intPtr, ref struct2_); num != 0; num = Process32Next(intPtr, ref struct2_))
		{
			if (struct2_.string_0.ToLower() == string_0.ToLower())
			{
				try
				{
					Process processById = Process.GetProcessById((int)struct2_.uint_2);
					arrayList.Add(processById);
				}
				catch
				{
				}
			}
		}
		CloseHandle(intPtr);
		return (Process[])arrayList.ToArray(typeof(Process));
	}

	internal void method_1()
	{
		int int_ = 0;
		Struct1 struct1_ = default(Struct1);
		struct1_.int_0 = 1;
		struct1_.long_0 = 0L;
		struct1_.int_1 = 2;
		if (OpenProcessToken(GetCurrentProcess(), 40, ref int_) == 0)
		{
			throw new Exception("OpenProcessToken failed");
		}
		if (LookupPrivilegeValue(null, "SeDebugPrivilege", ref struct1_.long_0) == 0)
		{
			throw new Exception("LookupPrivilegeValue failed");
		}
		if (AdjustTokenPrivileges(int_, 0, ref struct1_, Marshal.SizeOf((object)struct1_), 0, 0) == 0)
		{
			throw new Exception("AdjustTokenPrivileges failed");
		}
	}

	internal void method_2(Process process_1)
	{
		if (bool_0)
		{
			throw new Exception("Process already opened");
		}
		process_0 = process_1;
		intptr_1 = OpenProcess(1082u, 0, (uint)process_0.Id);
		if (intptr_1 == IntPtr.Zero)
		{
			GetSecurityInfo((int)Process.GetCurrentProcess().Handle, 6, 4, 0, 0, out var intptr_, IntPtr.Zero, out var _);
			intptr_1 = OpenProcess(262144u, 0, (uint)process_1.Id);
			SetSecurityInfo((int)intptr_1, 6, 536870916, 0, 0, intptr_, IntPtr.Zero);
			CloseHandle(intptr_1);
			intptr_1 = OpenProcess(1082u, 0, (uint)process_0.Id);
		}
		bool_0 = true;
	}

	internal void method_3()
	{
		if (!bool_0)
		{
			throw new Exception("Process already closed");
		}
		if (CloseHandle(intptr_1) == 0)
		{
			throw new Exception("CloseHandle failed");
		}
		bool_0 = false;
	}

	internal MemoryReader()
	{
		intptr_0 = Marshal.AllocHGlobal(8);
	}

	~MemoryReader()
	{
		if (bool_0)
		{
			method_3();
		}
		Marshal.FreeHGlobal(intptr_0);
	}

	public int ReadInteger(int int_3)
	{
		IntPtr intptr_ = IntPtr.Zero;
		ReadProcessMemory(intptr_1, new IntPtr(int_3), intptr_0, 4, ref intptr_);
		return Marshal.ReadInt32(intptr_0);
	}

	public long ReadLong(int int_3)
	{
		IntPtr intptr_ = IntPtr.Zero;
		ReadProcessMemory(intptr_1, new IntPtr(int_3), intptr_0, 8, ref intptr_);
		return Marshal.ReadInt64(intptr_0);
	}

	public float ReadFloat(int int_3)
	{
		IntPtr intptr_ = IntPtr.Zero;
		ReadProcessMemory(intptr_1, new IntPtr(int_3), intptr_0, 4, ref intptr_);
		byte[] array = new byte[4];
		Marshal.Copy(intptr_0, array, 0, 4);
		return BitConverter.ToSingle(array, 0);
	}

	public byte[] ReadBuffer(int int_3, int int_4)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(int_4);
		IntPtr intptr_ = IntPtr.Zero;
		ReadProcessMemory(intptr_1, new IntPtr(int_3), intPtr, int_4, ref intptr_);
		byte[] array = new byte[int_4];
		Marshal.Copy(intPtr, array, 0, int_4);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	public string ReadString(int int_3, int int_4)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(int_4);
		IntPtr intptr_ = IntPtr.Zero;
		ReadProcessMemory(intptr_1, new IntPtr(int_3), intPtr, int_4, ref intptr_);
		byte[] array = new byte[int_4];
		Marshal.Copy(intPtr, array, 0, int_4);
		Marshal.FreeHGlobal(intPtr);
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		string text = uTF8Encoding.GetString(array);
		int num = text.IndexOf("\0");
		if (num != -1)
		{
			text = text.Remove(num, text.Length - num);
		}
		return text;
	}

	public void WriteFloat(int int_3, float float_0)
	{
		byte[] bytes = BitConverter.GetBytes(float_0);
		IntPtr intptr_ = IntPtr.Zero;
		Marshal.Copy(bytes, 0, intptr_0, 4);
		WriteProcessMemory(intptr_1, new IntPtr(int_3), intptr_0, 4, ref intptr_);
	}

	public void WriteInteger(int int_3, int int_4)
	{
		byte[] bytes = BitConverter.GetBytes(int_4);
		IntPtr intptr_ = IntPtr.Zero;
		Marshal.Copy(bytes, 0, intptr_0, 4);
		WriteProcessMemory(intptr_1, new IntPtr(int_3), intptr_0, 4, ref intptr_);
	}

	public void WriteLong(int int_3, long long_0)
	{
		byte[] bytes = BitConverter.GetBytes(long_0);
		IntPtr intptr_ = IntPtr.Zero;
		Marshal.Copy(bytes, 0, intptr_0, 8);
		WriteProcessMemory(intptr_1, new IntPtr(int_3), intptr_0, 8, ref intptr_);
	}

	public void WriteString(int int_3, string string_0)
	{
		byte[] bytes = Encoding.Default.GetBytes(string_0 + '\0');
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr intPtr = Marshal.AllocHGlobal(bytes.Length);
		Marshal.Copy(bytes, 0, intPtr, bytes.Length);
		WriteProcessMemory(intptr_1, new IntPtr(int_3), intPtr, bytes.Length, ref intptr_);
		Marshal.FreeHGlobal(intPtr);
	}
}
