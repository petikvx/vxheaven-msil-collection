using System;
using System.Collections;
using System.Threading;

namespace DevComponents.DotNetBar;

internal class Class27
{
	private class Class28
	{
		private object object_0;

		private EventHandler eventHandler_0;

		public EventHandler EventHandler_0
		{
			get
			{
				return eventHandler_0;
			}
			set
			{
				eventHandler_0 = value;
			}
		}

		internal object Object_0 => object_0;

		public Class28(object caller)
		{
			object_0 = caller;
		}

		protected void method_0(EventArgs eventArgs_0)
		{
			if (eventHandler_0 != null)
			{
				eventHandler_0(object_0, eventArgs_0);
			}
		}

		public void method_1()
		{
			method_0(EventArgs.Empty);
		}
	}

	private static Thread thread_0;

	private static ArrayList arrayList_0;

	private static ReaderWriterLock readerWriterLock_0;

	[ThreadStatic]
	private static int int_0;

	static Class27()
	{
		readerWriterLock_0 = new ReaderWriterLock();
	}

	private Class27()
	{
	}

	public static void smethod_0(object object_0, EventHandler eventHandler_0)
	{
		if (object_0 == null)
		{
			return;
		}
		Class28 @class = null;
		lock (object_0)
		{
			@class = new Class28(object_0);
		}
		smethod_2(object_0, eventHandler_0);
		bool isReaderLockHeld = readerWriterLock_0.IsReaderLockHeld;
		LockCookie lockCookie = default(LockCookie);
		int_0++;
		try
		{
			if (isReaderLockHeld)
			{
				lockCookie = readerWriterLock_0.UpgradeToWriterLock(-1);
			}
			else
			{
				readerWriterLock_0.AcquireWriterLock(-1);
			}
		}
		finally
		{
			int_0--;
		}
		try
		{
			if (arrayList_0 == null)
			{
				arrayList_0 = new ArrayList();
			}
			@class.EventHandler_0 = eventHandler_0;
			arrayList_0.Add(@class);
			if (thread_0 == null)
			{
				thread_0 = new Thread(smethod_1);
				thread_0.Name = typeof(Class27).Name;
				thread_0.IsBackground = true;
				thread_0.Start();
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

	private static void smethod_1()
	{
		while (true)
		{
			readerWriterLock_0.AcquireReaderLock(-1);
			try
			{
				for (int i = 0; i < arrayList_0.Count; i++)
				{
					Class28 @class = arrayList_0[i] as Class28;
					@class.method_1();
				}
			}
			finally
			{
				readerWriterLock_0.ReleaseReaderLock();
			}
			Thread.Sleep(40);
		}
	}

	public static void smethod_2(object object_0, EventHandler eventHandler_0)
	{
		if (object_0 == null || arrayList_0 == null)
		{
			return;
		}
		bool isReaderLockHeld = readerWriterLock_0.IsReaderLockHeld;
		LockCookie lockCookie = default(LockCookie);
		int_0++;
		try
		{
			if (isReaderLockHeld)
			{
				lockCookie = readerWriterLock_0.UpgradeToWriterLock(-1);
			}
			else
			{
				readerWriterLock_0.AcquireWriterLock(-1);
			}
		}
		finally
		{
			int_0--;
		}
		try
		{
			int num = 0;
			Class28 @class;
			while (true)
			{
				if (num < arrayList_0.Count)
				{
					@class = arrayList_0[num] as Class28;
					if (object_0 == @class.Object_0)
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			if (eventHandler_0 == @class.EventHandler_0 || (eventHandler_0 != null && eventHandler_0.Equals(@class.EventHandler_0)))
			{
				arrayList_0.Remove(@class);
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
}
