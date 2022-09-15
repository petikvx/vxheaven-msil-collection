using System;
using System.Threading;

namespace DevComponents.DotNetBar;

internal class Class29
{
	private bool bool_0;

	private ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	public bool Boolean_0 => bool_0;

	public Class29(EventHandler recordStartState, EventHandler updateUIHandler, EventHandler cleanup)
	{
		eventHandler_1 = recordStartState;
		eventHandler_0 = updateUIHandler;
		eventHandler_2 = cleanup;
	}

	public void method_0()
	{
		readerWriterLock_0.AcquireReaderLock(-1);
		try
		{
			if (bool_0)
			{
				return;
			}
		}
		finally
		{
			readerWriterLock_0.ReleaseReaderLock();
		}
		bool isReaderLockHeld = readerWriterLock_0.IsReaderLockHeld;
		LockCookie lockCookie = default(LockCookie);
		if (isReaderLockHeld)
		{
			lockCookie = readerWriterLock_0.UpgradeToWriterLock(-1);
		}
		else
		{
			readerWriterLock_0.AcquireWriterLock(-1);
		}
		try
		{
			bool_0 = true;
			eventHandler_1(this, new EventArgs());
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
		Class27.smethod_0(this, method_2);
		bool_0 = true;
	}

	public void method_1()
	{
		readerWriterLock_0.AcquireReaderLock(-1);
		try
		{
			if (!bool_0)
			{
				return;
			}
		}
		finally
		{
			readerWriterLock_0.ReleaseReaderLock();
		}
		Class27.smethod_2(this, method_2);
		bool isReaderLockHeld = readerWriterLock_0.IsReaderLockHeld;
		LockCookie lockCookie = default(LockCookie);
		if (isReaderLockHeld)
		{
			lockCookie = readerWriterLock_0.UpgradeToWriterLock(-1);
		}
		else
		{
			readerWriterLock_0.AcquireWriterLock(-1);
		}
		try
		{
			bool_0 = false;
			eventHandler_2(this, new EventArgs());
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

	private void method_2(object sender, EventArgs e)
	{
		eventHandler_0(this, new EventArgs());
	}

	public void method_3()
	{
		readerWriterLock_0.AcquireReaderLock(-1);
	}

	public void method_4()
	{
		readerWriterLock_0.ReleaseReaderLock();
	}
}
