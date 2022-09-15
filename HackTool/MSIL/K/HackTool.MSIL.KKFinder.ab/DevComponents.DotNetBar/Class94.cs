using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace DevComponents.DotNetBar;

internal class Class94 : IDisposable
{
	private struct Struct8
	{
		public int int_0;

		public int int_1;

		public Struct8(int x, int y)
		{
			int_0 = x;
			int_1 = y;
		}
	}

	private delegate IntPtr Delegate2(int nCode, IntPtr wParam, IntPtr lParam);

	private struct Struct9
	{
		public Struct8 struct8_0;

		public IntPtr intptr_0;

		public ushort ushort_0;

		public IntPtr intptr_1;

		public Struct9(Struct8 pt, IntPtr hwnd, ushort wHitTestCode, IntPtr dwExtraInfo)
		{
			struct8_0 = pt;
			intptr_0 = hwnd;
			ushort_0 = wHitTestCode;
			intptr_1 = dwExtraInfo;
		}
	}

	private delegate IntPtr Delegate3(int nCode, IntPtr wParam, IntPtr lParam);

	private const int int_0 = 7;

	private const int int_1 = 0;

	private const int int_2 = 512;

	private const int int_3 = 2;

	private const int int_4 = 256;

	private const int int_5 = 2048;

	private const int int_6 = 4096;

	private const int int_7 = 8192;

	private const int int_8 = 16384;

	private const int int_9 = 32768;

	private IntPtr intptr_0 = IntPtr.Zero;

	private IntPtr intptr_1 = IntPtr.Zero;

	private Delegate3 delegate3_0;

	private Delegate2 delegate2_0;

	private Interface5 interface5_0;

	public Class94(Interface5 client)
	{
		interface5_0 = client;
		delegate3_0 = method_0;
		delegate2_0 = method_1;
		intptr_0 = SetWindowsHookEx(7, delegate3_0, IntPtr.Zero, GetCurrentThreadId());
		intptr_1 = SetWindowsHookEx_1(2, delegate2_0, IntPtr.Zero, GetCurrentThreadId());
		if (intptr_0 == IntPtr.Zero || intptr_1 == IntPtr.Zero)
		{
			throw new Win32Exception();
		}
	}

	public void Dispose()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			IntPtr hhook = intptr_0;
			intptr_0 = IntPtr.Zero;
			UnhookWindowsHookEx(hhook);
		}
		if (intptr_1 != IntPtr.Zero)
		{
			IntPtr hhook2 = intptr_1;
			intptr_1 = IntPtr.Zero;
			UnhookWindowsHookEx(hhook2);
		}
	}

	private IntPtr method_0(int int_10, IntPtr intptr_2, IntPtr intptr_3)
	{
		if (int_10 == 0)
		{
			int num = intptr_2.ToInt32();
			if (num == 513 || num == 161 || num == 516 || num == 519 || num == 167 || num == 164)
			{
				Struct9 @struct = (Struct9)Marshal.PtrToStructure(intptr_3, typeof(Struct9));
				interface5_0.imethod_3(@struct.intptr_0, IntPtr.Zero, intptr_3);
			}
		}
		return CallNextHookEx(intptr_0, int_10, intptr_2, intptr_3);
	}

	private IntPtr method_1(int int_10, IntPtr intptr_2, IntPtr intptr_3)
	{
		if (int_10 == 0)
		{
			int num = intptr_3.ToInt32();
			int num2 = intptr_2.ToInt32();
			int num3 = num >> 16;
			if (((uint)num3 & 0x2000u) != 0)
			{
				if (((uint)num3 & 0x8000u) != 0)
				{
					if (interface5_0.imethod_1(IntPtr.Zero, intptr_2, intptr_3))
					{
						return (IntPtr)1;
					}
				}
				else if (interface5_0.imethod_0(IntPtr.Zero, intptr_2, intptr_3))
				{
					return (IntPtr)1;
				}
			}
			else if ((num3 & 0x8000) == 0)
			{
				if (interface5_0.imethod_2(IntPtr.Zero, intptr_2, intptr_3))
				{
					return (IntPtr)1;
				}
			}
			else if ((num2 == 18 || num2 == 121) && interface5_0.imethod_1(IntPtr.Zero, intptr_2, intptr_3))
			{
				return (IntPtr)1;
			}
		}
		return CallNextHookEx(intptr_1, int_10, intptr_2, intptr_3);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int hookid, Delegate3 pfnhook, IntPtr hinst, int threadid);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowsHookEx", SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx_1(int hookid, Delegate2 pfnhook, IntPtr hinst, int threadid);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhook);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhook, int code, IntPtr wparam, IntPtr lparam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	private static extern int GetCurrentThreadId();
}
