using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace InstallService;

public class GClass2
{
	private string string_0;

	private string string_1;

	private string string_2;

	public static int int_0 = 256;

	public static int int_1 = 2;

	public static int int_2 = 16;

	public static int int_3 = 1;

	public static int int_4 = 983040;

	public static int int_5 = 1;

	public static int int_6 = 2;

	public static int int_7 = 4;

	public static int int_8 = 8;

	public static int int_9 = 16;

	public static int int_10 = 32;

	public static int int_11 = 64;

	public static int int_12 = 128;

	public static int int_13 = 256;

	public static int int_14 = int_4 | int_5 | int_6 | int_7 | int_8 | int_9 | int_10 | int_11 | int_12 | int_13;

	private int int_15 = 2;

	[DllImport("advapi32.dll")]
	public static extern int ChangeServiceConfig(int hService, int dwServiceType, int dwStartType, int dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup, ref int lpdwTagId, string lpDependencies, string lpServiceStartName, string lpPassword, string lpDisplayName);

	[DllImport("advapi32.dll")]
	public static extern IntPtr OpenSCManager(string lpMachineName, string lpSCDB, int scParameter);

	[DllImport("Advapi32.dll")]
	public static extern IntPtr CreateService(IntPtr SC_HANDLE, string lpSvcName, string lpDisplayName, int dwDesiredAccess, int dwServiceType, int dwStartType, int dwErrorControl, string lpPathName, string lpLoadOrderGroup, int lpdwTagId, string lpDependencies, string lpServiceStartName, string lpPassword);

	[DllImport("advapi32.dll")]
	public static extern void CloseServiceHandle(IntPtr SCHANDLE);

	[DllImport("advapi32.dll")]
	public static extern int StartService(IntPtr SVHANDLE, int dwNumServiceArgs, string lpServiceArgVectors);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern IntPtr OpenService(IntPtr SCHANDLE, string lpSvcName, int dwNumServiceArgs);

	[DllImport("advapi32.dll")]
	public static extern int DeleteService(IntPtr SVHANDLE);

	[DllImport("kernel32.dll")]
	public static extern int GetLastError();

	public bool method_0(string string_3, string string_4, string string_5)
	{
		try
		{
			IntPtr intPtr = OpenSCManager(null, null, int_1);
			if (intPtr.ToInt32() == 0)
			{
				return false;
			}
			IntPtr sVHANDLE = CreateService(intPtr, string_4, string_5, int_14, int_2 | int_0, int_15, int_3, string_3, null, 0, null, null, null);
			if (sVHANDLE.ToInt32() == 0)
			{
				CloseServiceHandle(intPtr);
				return false;
			}
			if (StartService(sVHANDLE, 0, null) != 0)
			{
				CloseServiceHandle(intPtr);
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public bool method_1(string string_3)
	{
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i++)
		{
			if (processes[i].ProcessName.ToLower().Trim() == GClass0.string_1)
			{
				processes[i].Kill();
			}
		}
		IntPtr sCHANDLE = OpenSCManager(null, null, 1073741824);
		if (sCHANDLE.ToInt32() == 0)
		{
			return false;
		}
		IntPtr sVHANDLE = OpenService(sCHANDLE, string_3, 65536);
		if (sVHANDLE.ToInt32() == 0)
		{
			return false;
		}
		if (DeleteService(sVHANDLE) == 0)
		{
			CloseServiceHandle(sCHANDLE);
			return false;
		}
		CloseServiceHandle(sCHANDLE);
		return true;
	}
}
