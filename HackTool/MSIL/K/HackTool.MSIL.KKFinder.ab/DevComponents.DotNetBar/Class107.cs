using System;
using System.Collections;
using System.Threading;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class107
{
	private static ArrayList arrayList_0;

	private static Hashtable hashtable_0;

	private static ReaderWriterLock readerWriterLock_0;

	static Class107()
	{
		arrayList_0 = new ArrayList();
		hashtable_0 = new Hashtable();
		readerWriterLock_0 = new ReaderWriterLock();
	}

	public static void smethod_0(Interface5 interface5_0)
	{
		if (arrayList_0.Contains(interface5_0))
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
			arrayList_0.Add(interface5_0);
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

	public static void smethod_1(Interface5 interface5_0)
	{
		if (!arrayList_0.Contains(interface5_0))
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
		bool flag = false;
		try
		{
			arrayList_0.Remove(interface5_0);
			flag = arrayList_0.Count == 0;
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
		if (BarUtilities.AutoRemoveMessageFilter && flag && hashtable_0.ContainsKey(Thread.CurrentThread.GetHashCode()))
		{
			smethod_3();
		}
	}

	private static void smethod_2()
	{
		if (!hashtable_0.ContainsKey(Thread.CurrentThread.GetHashCode()))
		{
			Class106 @class = new Class106();
			Application.AddMessageFilter((IMessageFilter)(object)@class);
			hashtable_0.Add(Thread.CurrentThread.GetHashCode(), @class);
		}
	}

	private static void smethod_3()
	{
		if (hashtable_0.ContainsKey(Thread.CurrentThread.GetHashCode()))
		{
			Class106 @class = hashtable_0[Thread.CurrentThread.GetHashCode()] as Class106;
			Application.RemoveMessageFilter((IMessageFilter)(object)@class);
			hashtable_0.Remove(Thread.CurrentThread.GetHashCode());
		}
	}

	private static Interface5 smethod_4()
	{
		readerWriterLock_0.AcquireReaderLock(-1);
		try
		{
			foreach (Interface5 item in arrayList_0)
			{
				if (item.Boolean_0)
				{
					return item;
				}
			}
		}
		finally
		{
			readerWriterLock_0.ReleaseReaderLock();
		}
		return null;
	}

	private static Interface5[] smethod_5()
	{
		readerWriterLock_0.AcquireReaderLock(-1);
		try
		{
			return (Interface5[])arrayList_0.ToArray(typeof(Interface5));
		}
		finally
		{
			readerWriterLock_0.ReleaseReaderLock();
		}
	}

	public static bool smethod_6(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		Interface5 @interface = smethod_4();
		if (@interface != null)
		{
			if (@interface.imethod_0(intptr_0, intptr_1, intptr_2))
			{
				return true;
			}
			return false;
		}
		Interface5[] array = smethod_5();
		Interface5[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				Interface5 interface2 = array2[num];
				if (interface2.imethod_0(intptr_0, intptr_1, intptr_2))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool smethod_7(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		Interface5 @interface = smethod_4();
		if (@interface != null)
		{
			if (@interface.imethod_1(intptr_0, intptr_1, intptr_2))
			{
				return true;
			}
			return false;
		}
		Interface5[] array = smethod_5();
		Interface5[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				Interface5 interface2 = array2[num];
				if (interface2.imethod_1(intptr_0, intptr_1, intptr_2))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool smethod_8(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		Interface5[] array = smethod_5();
		Interface5[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				Interface5 @interface = array2[num];
				if (@interface.imethod_2(intptr_0, intptr_1, intptr_2))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool smethod_9(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		Interface5[] array = smethod_5();
		Interface5[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				Interface5 @interface = array2[num];
				if (@interface.imethod_3(intptr_0, intptr_1, intptr_2))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool smethod_10(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		Interface5[] array = smethod_5();
		Interface5[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				Interface5 @interface = array2[num];
				if (@interface.imethod_4(intptr_0, intptr_1, intptr_2))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool smethod_11(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		Interface5 @interface = smethod_4();
		if (@interface != null)
		{
			if (@interface.imethod_5(intptr_0, intptr_1, intptr_2))
			{
				return true;
			}
			return false;
		}
		Interface5[] array = smethod_5();
		Interface5[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				Interface5 interface2 = array2[num];
				if ((!(interface2 is Control) || !((Control)interface2).get_InvokeRequired()) && interface2.imethod_5(intptr_0, intptr_1, intptr_2))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}
}
