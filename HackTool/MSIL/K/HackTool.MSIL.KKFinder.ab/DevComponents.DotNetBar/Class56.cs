using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace DevComponents.DotNetBar;

internal class Class56
{
	private struct Struct5
	{
		public Struct6 struct6_0;

		public IntPtr intptr_0;

		public ushort ushort_0;

		public IntPtr intptr_1;

		public Struct5(Struct6 pt, IntPtr hwnd, ushort wHitTestCode, IntPtr dwExtraInfo)
		{
			struct6_0 = pt;
			intptr_0 = hwnd;
			ushort_0 = wHitTestCode;
			intptr_1 = dwExtraInfo;
		}
	}

	private struct Struct6
	{
		public int int_0;

		public int int_1;

		public Struct6(int x, int y)
		{
			int_0 = x;
			int_1 = y;
		}

		public Point method_0()
		{
			return new Point(int_0, int_1);
		}
	}

	private delegate IntPtr Delegate1(int nCode, IntPtr wParam, IntPtr lParam);

	private const int int_0 = 7;

	private const int int_1 = 0;

	private const int int_2 = 12;

	private const int int_3 = 4;

	private static ArrayList arrayList_0;

	private static Hashtable hashtable_0;

	private static ReaderWriterLock readerWriterLock_0;

	private static Delegate1 delegate1_0;

	static Class56()
	{
		arrayList_0 = new ArrayList();
		hashtable_0 = new Hashtable();
		delegate1_0 = null;
		readerWriterLock_0 = new ReaderWriterLock();
		delegate1_0 = smethod_5;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int hookid, Delegate1 pfnhook, IntPtr hinst, int threadid);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhook);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhook, int code, IntPtr wparam, IntPtr lparam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	private static extern int GetCurrentThreadId();

	public static void smethod_0(Interface1 interface1_0)
	{
		if (arrayList_0.Contains(interface1_0))
		{
			return;
		}
		if (!hashtable_0.ContainsKey(Thread.CurrentThread.GetHashCode()))
		{
			smethod_2();
		}
		LockCookie lockCookie = default(LockCookie);
		bool isReaderLockHeld;
		if (isReaderLockHeld = readerWriterLock_0.IsReaderLockHeld)
		{
			lockCookie = readerWriterLock_0.UpgradeToWriterLock(-1);
		}
		else
		{
			readerWriterLock_0.AcquireWriterLock(-1);
		}
		try
		{
			arrayList_0.Add(interface1_0);
		}
		finally
		{
			if (isReaderLockHeld)
			{
				readerWriterLock_0.DowngradeFromWriterLock(ref lockCookie);
			}
			else
			{
				readerWriterLock_0.ReleaseWriterLock();
			}
		}
	}

	public static void smethod_1(Interface1 interface1_0)
	{
		if (!arrayList_0.Contains(interface1_0))
		{
			return;
		}
		LockCookie lockCookie = default(LockCookie);
		bool isReaderLockHeld;
		if (isReaderLockHeld = readerWriterLock_0.IsReaderLockHeld)
		{
			lockCookie = readerWriterLock_0.UpgradeToWriterLock(-1);
		}
		else
		{
			readerWriterLock_0.AcquireWriterLock(-1);
		}
		try
		{
			arrayList_0.Remove(interface1_0);
			if (arrayList_0.Count == 0)
			{
				smethod_3();
			}
		}
		finally
		{
			if (isReaderLockHeld)
			{
				readerWriterLock_0.DowngradeFromWriterLock(ref lockCookie);
			}
			else
			{
				readerWriterLock_0.ReleaseWriterLock();
			}
		}
	}

	private static void smethod_2()
	{
		if (!hashtable_0.ContainsKey(Thread.CurrentThread.GetHashCode()))
		{
			int currentThreadId = GetCurrentThreadId();
			IntPtr intPtr = SetWindowsHookEx(7, delegate1_0, IntPtr.Zero, currentThreadId);
			hashtable_0.Add(Thread.CurrentThread.GetHashCode(), intPtr);
		}
	}

	private static void smethod_3()
	{
		if (hashtable_0.ContainsKey(Thread.CurrentThread.GetHashCode()))
		{
			IntPtr hhook = (IntPtr)hashtable_0[Thread.CurrentThread.GetHashCode()];
			UnhookWindowsHookEx(hhook);
			hashtable_0.Remove(Thread.CurrentThread.GetHashCode());
		}
	}

	private static Interface1[] smethod_4()
	{
		readerWriterLock_0.AcquireReaderLock(-1);
		try
		{
			return (Interface1[])arrayList_0.ToArray(typeof(Interface1));
		}
		finally
		{
			readerWriterLock_0.ReleaseReaderLock();
		}
	}

	private unsafe static IntPtr smethod_5(int int_4, IntPtr intptr_0, IntPtr intptr_1)
	{
		try
		{
			if (int_4 == 0)
			{
				if (intptr_0.ToInt32() == 512)
				{
					Struct5* ptr = (Struct5*)(void*)intptr_1;
					smethod_6(ptr->intptr_0, ptr->struct6_0.method_0());
				}
				if (intptr_0.ToInt32() == 514)
				{
					Struct5* ptr2 = (Struct5*)(void*)intptr_1;
					smethod_7(ptr2->intptr_0, ptr2->struct6_0.method_0());
				}
			}
			IntPtr hhook = (IntPtr)hashtable_0[Thread.CurrentThread.GetHashCode()];
			return CallNextHookEx(hhook, int_4, intptr_0, intptr_1);
		}
		catch
		{
		}
		return IntPtr.Zero;
	}

	public static bool smethod_6(IntPtr intptr_0, Point point_0)
	{
		Interface1[] array = smethod_4();
		Interface1[] array2 = array;
		foreach (Interface1 @interface in array2)
		{
			@interface.imethod_0(intptr_0, point_0);
		}
		return false;
	}

	public static bool smethod_7(IntPtr intptr_0, Point point_0)
	{
		Interface1[] array = smethod_4();
		Interface1[] array2 = array;
		foreach (Interface1 @interface in array2)
		{
			@interface.imethod_1(intptr_0, point_0);
		}
		return false;
	}
}
