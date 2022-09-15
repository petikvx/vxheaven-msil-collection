using System;
using System.Collections;
using System.Threading;

internal class Class50
{
	public static bool smethod_0(WaitHandle[] waitHandle_0, int int_0)
	{
		if (Thread.CurrentThread.ApartmentState == ApartmentState.STA)
		{
			TimeSpan timeSpan = ((int_0 == -1) ? TimeSpan.MaxValue : TimeSpan.FromMilliseconds(int_0));
			DateTime now = DateTime.Now;
			while (waitHandle_0.Length > 0 && DateTime.Now - now < timeSpan)
			{
				if (int_0 != -1)
				{
					int_0 = (int)(timeSpan - (DateTime.Now - now)).TotalMilliseconds;
				}
				int num = WaitHandle.WaitAny(waitHandle_0, int_0, exitContext: true);
				if (num < 0)
				{
					continue;
				}
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < waitHandle_0.Length; i++)
				{
					if (i != num)
					{
						arrayList.Add(waitHandle_0[i]);
					}
				}
				waitHandle_0 = arrayList.ToArray(typeof(WaitHandle)) as WaitHandle[];
			}
			return waitHandle_0.Length == 0;
		}
		return WaitHandle.WaitAll(waitHandle_0, int_0, exitContext: true);
	}

	public static bool smethod_1(WaitHandle[] waitHandle_0)
	{
		return smethod_0(waitHandle_0, -1);
	}
}
