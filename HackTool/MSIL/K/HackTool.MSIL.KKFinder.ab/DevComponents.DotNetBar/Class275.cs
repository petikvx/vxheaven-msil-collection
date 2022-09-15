using System;
using System.Collections;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class275 : NativeWindow
{
	private const int int_0 = 70;

	private ArrayList arrayList_0 = new ArrayList();

	private ArrayList arrayList_1 = new ArrayList();

	private bool bool_0;

	public int Int32_0 => arrayList_0.Count;

	public int Int32_1 => arrayList_1.Count;

	public Class275(bool designmode)
	{
		bool_0 = designmode;
	}

	public void method_0(IOwner iowner_0)
	{
		arrayList_0.Add(iowner_0);
	}

	public void method_1(IOwner iowner_0)
	{
		arrayList_0.Remove(iowner_0);
	}

	public bool method_2(IOwner iowner_0)
	{
		return arrayList_0.Contains(iowner_0);
	}

	public void method_3(IOwner iowner_0)
	{
		arrayList_1.Add(iowner_0);
	}

	public void method_4(IOwner iowner_0)
	{
		arrayList_1.Remove(iowner_0);
	}

	public bool method_5(IOwner iowner_0)
	{
		return arrayList_1.Contains(iowner_0);
	}

	public void method_6()
	{
		if (arrayList_0.Count > 0)
		{
			IOwner[] array;
			lock (this)
			{
				array = (IOwner[])arrayList_0.ToArray(typeof(IOwner));
			}
			IOwner[] array2 = array;
			foreach (IOwner owner in array2)
			{
				owner.OnApplicationActivate();
			}
		}
	}

	public void method_7()
	{
		if (arrayList_0.Count > 0)
		{
			IOwner[] array;
			lock (this)
			{
				array = (IOwner[])arrayList_0.ToArray(typeof(IOwner));
			}
			IOwner[] array2 = array;
			foreach (IOwner owner in array2)
			{
				owner.OnApplicationDeactivate();
			}
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 70)
		{
			if (((Class92.WINDOWPOS)((Message)(ref m)).GetLParam(default(Class92.WINDOWPOS).GetType())).hwndInsertAfter != 0 && arrayList_0.Count > 0)
			{
				IOwner[] array;
				lock (this)
				{
					array = (IOwner[])arrayList_0.ToArray(typeof(IOwner));
				}
				IOwner[] array2 = array;
				foreach (IOwner owner in array2)
				{
					owner.OnParentPositionChanging();
				}
			}
		}
		else if (((Message)(ref m)).get_Msg() == 28L)
		{
			if (((Message)(ref m)).get_WParam().ToInt32() != 0)
			{
				DotNetBarManager.RelayApplicationActivate(bActivate: true);
			}
			else
			{
				DotNetBarManager.RelayApplicationActivate(bActivate: false);
			}
		}
		else if (((Message)(ref m)).get_Msg() == 6)
		{
			if ((((Message)(ref m)).get_WParam().ToInt32() & 0xFF) == 0)
			{
				Control val = Control.FromChildHandle(((Message)(ref m)).get_LParam());
				bool flag = false;
				foreach (IOwner item in arrayList_0)
				{
					if (item is DotNetBarManager && ((DotNetBarManager)item).IsCustomizing)
					{
						flag = true;
						break;
					}
				}
				if (val != null && !flag)
				{
					while (val.get_Parent() != null)
					{
						val = val.get_Parent();
					}
					if (!(val is Bar) && !(val is MenuPanel) && !(val is PopupContainerControl) && !(val is PopupContainer) && arrayList_0.Count > 0)
					{
						IOwner[] array3;
						lock (this)
						{
							array3 = (IOwner[])arrayList_0.ToArray(typeof(IOwner));
						}
						IOwner[] array4 = array3;
						foreach (IOwner owner3 in array4)
						{
							owner3.SetExpandedItem(null);
						}
					}
				}
			}
		}
		else if (((Message)(ref m)).get_Msg() == 126)
		{
			Class92.smethod_6();
		}
		else if (((Message)(ref m)).get_Msg() == 134 && bool_0 && ((Message)(ref m)).get_WParam() == IntPtr.Zero && arrayList_0.Count > 0)
		{
			IOwner[] array5;
			lock (this)
			{
				array5 = (IOwner[])arrayList_0.ToArray(typeof(IOwner));
			}
			IOwner[] array6 = array5;
			foreach (IOwner owner4 in array6)
			{
				owner4.SetExpandedItem(null);
			}
			IOwner[] array7;
			lock (this)
			{
				array7 = (IOwner[])arrayList_1.ToArray(typeof(IOwner));
			}
			IOwner[] array8 = array7;
			foreach (IOwner owner5 in array8)
			{
				owner5.SetExpandedItem(null);
			}
		}
		((NativeWindow)this).WndProc(ref m);
	}
}
