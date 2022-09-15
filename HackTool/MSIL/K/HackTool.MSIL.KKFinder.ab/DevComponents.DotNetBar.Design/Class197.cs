using System;
using System.Collections;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.Design;

internal class Class197
{
	private Timer timer_0;

	private ArrayList arrayList_0 = new ArrayList();

	private ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

	public Class197()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		timer_0 = new Timer();
		timer_0.set_Enabled(false);
		timer_0.set_Interval(800);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		method_1();
	}

	public void method_0()
	{
		if (timer_0 != null)
		{
			timer_0.Stop();
			method_1();
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
	}

	private void method_1()
	{
		if (arrayList_0.Count <= 0)
		{
			return;
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
			foreach (PopupItem item in arrayList_0)
			{
				item.ClosePopup();
			}
			arrayList_0.Clear();
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

	public void method_2(PopupItem popupItem_0)
	{
		if (timer_0 == null)
		{
			return;
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
			arrayList_0.Add(popupItem_0);
			timer_0.Start();
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

	public void method_3()
	{
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
			arrayList_0.Clear();
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
