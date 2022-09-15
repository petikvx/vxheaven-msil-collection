using System;
using System.Collections;
using System.Windows.Forms;

public class GClass0 : Panel
{
	private static ArrayList arrayList_0 = new ArrayList();

	public GClass0()
	{
		lock (arrayList_0)
		{
			arrayList_0.Add(new WeakReference(this));
		}
		((Control)this).SetStyle((ControlStyles)73746, true);
	}
}
