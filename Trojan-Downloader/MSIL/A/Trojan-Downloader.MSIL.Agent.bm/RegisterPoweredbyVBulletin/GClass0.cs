using System;
using System.Runtime.InteropServices;

namespace RegisterPoweredbyVBulletin;

public class GClass0
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private struct Struct0
	{
		public short short_0;

		public short short_1;

		public short short_2;

		public short short_3;

		public short short_4;

		public short short_5;

		public short short_6;

		public short short_7;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private struct Struct1
	{
		public int int_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public FILETIME filetime_0;

		public FILETIME filetime_1;

		public FILETIME filetime_2;

		public FILETIME filetime_3;

		public IntPtr intptr_2;

		public int int_6;

		public IntPtr intptr_3;

		public int int_7;
	}

	private const int int_0 = 259;

	private const int int_1 = 1;

	private const int int_2 = 2;

	private const uint uint_0 = uint.MaxValue;

	private const int int_3 = 16;

	private const int int_4 = 8;

	private const int int_5 = 32;

	private const int int_6 = 4;

	private const int int_7 = 2;

	private const int int_8 = 4;

	private const int int_9 = 1;

	private const int int_10 = 60;

	private const int int_11 = 0;

	private const int int_12 = 1;

	private const int int_13 = 1;

	private const int int_14 = 4;

	private const int int_15 = 120;

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int FileTimeToSystemTime(IntPtr lpFileTime, IntPtr lpSystemTime);

	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindFirstUrlCacheGr_0020oup(int dwFlags, int dwFilter, IntPtr lpSearchCondition, int dwSearchCondition, ref long lpGroupId, IntPtr lpReserved);

	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool FindNextUrlCacheGroup(IntPtr hFind, ref long lpGroupId, IntPtr lpReserved);

	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool De_0020leteUrlCacheGroup(long GroupId, int dwFlags, IntPtr lpReserved);

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindFirstUrlCacheEntry([MarshalAs(UnmanagedType.LPTStr)] string UrlSearchPattern, IntPtr lpFirstCacheEntryInfo, ref int lpdwFirstCacheEntryInfoBufferSize);

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool FindNextUrlCacheEntry(IntPtr hEnumHandle, IntPtr lpNextCacheEntryInfo, ref int lpdwNextCacheEntryInfoBufferSize);

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool GetUrlCacheEntryInfo([MarshalAs(UnmanagedType.LPTStr)] string lpszUrlName, IntPtr lpCacheEntryInfo, ref int lpdwCacheEntryInfoBufferSize);

	[DllImport("wininet.dll")]
	private static extern bool FindCloseUrlCache(IntPtr hEnumHandle);

	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool DeleteUrlCacheEntryA(IntPtr lpszUrlName);

	private string method_0(FILETIME filetime_0)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(FILETIME)));
		IntPtr intPtr2 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Struct0)));
		Marshal.StructureToPtr(filetime_0, intPtr, fDeleteOld: true);
		FileTimeToSystemTime(intPtr, intPtr2);
		Struct0 @struct = (Struct0)Marshal.PtrToStructure(intPtr2, typeof(Struct0));
		return @struct.short_0 + "." + @struct.short_1 + "." + @struct.short_3 + "." + @struct.short_4 + "." + @struct.short_5 + "." + @struct.short_6;
	}

	public string method_1(string string_0)
	{
		string text = "";
		int lpdwFirstCacheEntryInfoBufferSize = 0;
		FindFirstUrlCacheEntry(null, IntPtr.Zero, ref lpdwFirstCacheEntryInfoBufferSize);
		if (Marshal.GetLastWin32Error() != 259)
		{
			int cb = lpdwFirstCacheEntryInfoBufferSize;
			IntPtr intPtr = Marshal.AllocHGlobal(cb);
			GetUrlCacheEntryInfo(string_0, intPtr, ref lpdwFirstCacheEntryInfoBufferSize);
			try
			{
				Struct1 @struct = (Struct1)Marshal.PtrToStructure(intPtr, typeof(Struct1));
				text = Marshal.PtrToStringAuto(@struct.intptr_1);
				if (text.IndexOf("Temporary Internet Files") == -1)
				{
					text = Marshal.PtrToStringAnsi(@struct.intptr_1);
				}
				if (text.IndexOf("Temporary Internet Files") == -1)
				{
					text = Marshal.PtrToStringBSTR(@struct.intptr_1);
				}
				if (text.IndexOf("Temporary Internet Files") == -1)
				{
					text = Marshal.PtrToStringUni(@struct.intptr_1);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + ex.StackTrace);
			}
			Marshal.FreeHGlobal(intPtr);
			return text;
		}
		return text;
	}

	public void method_2()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		int lpdwFirstCacheEntryInfoBufferSize = 0;
		FindFirstUrlCacheEntry(null, IntPtr.Zero, ref lpdwFirstCacheEntryInfoBufferSize);
		if (Marshal.GetLastWin32Error() == 259)
		{
			return;
		}
		int num = lpdwFirstCacheEntryInfoBufferSize;
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		IntPtr hEnumHandle = FindFirstUrlCacheEntry(null, intPtr, ref lpdwFirstCacheEntryInfoBufferSize);
		while (true)
		{
			Struct1 @struct = (Struct1)Marshal.PtrToStructure(intPtr, typeof(Struct1));
			method_0(@struct.filetime_0);
			method_0(@struct.filetime_1);
			method_0(@struct.filetime_2);
			method_0(@struct.filetime_3);
			try
			{
				string value = Marshal.PtrToStringAuto(@struct.intptr_0) + Environment.NewLine + "  ===> " + Marshal.PtrToStringAuto(@struct.intptr_1) + Environment.NewLine + "  ==> " + Marshal.PtrToStringAuto(@struct.intptr_2) + Environment.NewLine + Marshal.PtrToStringAuto(@struct.intptr_3);
				Console.WriteLine(value);
			}
			catch
			{
			}
			lpdwFirstCacheEntryInfoBufferSize = num;
			bool flag;
			if (!(flag = FindNextUrlCacheEntry(hEnumHandle, intPtr, ref lpdwFirstCacheEntryInfoBufferSize)) && Marshal.GetLastWin32Error() == 259)
			{
				break;
			}
			if (!flag && lpdwFirstCacheEntryInfoBufferSize > num)
			{
				num = lpdwFirstCacheEntryInfoBufferSize;
				intPtr = Marshal.ReAllocHGlobal(intPtr, (IntPtr)num);
				FindNextUrlCacheEntry(hEnumHandle, intPtr, ref lpdwFirstCacheEntryInfoBufferSize);
			}
		}
		Marshal.FreeHGlobal(intPtr);
	}
}
