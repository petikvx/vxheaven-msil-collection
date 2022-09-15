using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace DevComponents.DotNetBar;

public class BarUtilities
{
	private const int int_0 = -20;

	private const int int_1 = 512;

	private const int int_2 = 32;

	private const int int_3 = 1;

	private const int int_4 = 2;

	private const int int_5 = 4;

	private static bool bool_0;

	private static bool bool_1;

	public static bool UseGenericDefaultStringFormat
	{
		get
		{
			return Class55.bool_2;
		}
		set
		{
			Class55.bool_2 = value;
		}
	}

	public static TextRenderingHint AntiAliasTextRenderingHint
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return Class50.TextRenderingHint_0;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			Class50.TextRenderingHint_0 = value;
		}
	}

	public static bool UseTextRenderer
	{
		get
		{
			return Class55.bool_1;
		}
		set
		{
			Class55.bool_1 = value;
		}
	}

	public static bool AlwaysGenerateAccessibilityFocusEvent
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	internal static bool Boolean_0
	{
		get
		{
			int num = 0;
			while (true)
			{
				if (num < ((ReadOnlyCollectionBase)(object)Application.get_OpenForms()).Count)
				{
					Form val = Application.get_OpenForms().get_Item(num);
					if (val.get_Modal())
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

	public static bool AutoRemoveMessageFilter
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public static void SetDockContainerVisible(DockContainerItem item, bool visible)
	{
		if (item == null || item.Visible == visible)
		{
			return;
		}
		if (!(item.ContainerControl is Bar bar))
		{
			item.Visible = visible;
			return;
		}
		DotNetBarManager dotNetBarManager = bar.Owner as DotNetBarManager;
		if (dotNetBarManager != null)
		{
			dotNetBarManager.SuspendLayout = true;
		}
		try
		{
			int visibleItemCount = bar.VisibleItemCount;
			if (visible)
			{
				item.Visible = true;
				if (!bar.AutoHide && !bar.Visible && visibleItemCount <= 1)
				{
					bar.Visible = true;
					if (bar.hashtable_0.ContainsKey(Class57.string_0))
					{
						bar.hashtable_0.Remove(Class57.string_0);
						bar.AutoHide = true;
					}
				}
				return;
			}
			if (visibleItemCount <= 1)
			{
				if (bar.hashtable_0.ContainsKey(Class57.string_0))
				{
					bar.hashtable_0.Remove(Class57.string_0);
				}
				if (bar.AutoHide)
				{
					bar.hashtable_0.Add(Class57.string_0, true);
				}
				bar.method_59();
			}
			item.Visible = false;
		}
		finally
		{
			if (dotNetBarManager != null)
			{
				dotNetBarManager.SuspendLayout = false;
			}
			bar.RecalcLayout();
		}
	}

	public static Bar CreateDocumentBar()
	{
		Bar bar = new Bar();
		InitializeDocumentBar(bar);
		return bar;
	}

	public static void InitializeDocumentBar(Bar bar)
	{
		TypeDescriptor.GetProperties(bar)["LayoutType"]!.SetValue(bar, eLayoutType.DockContainer);
		TypeDescriptor.GetProperties(bar)["DockTabAlignment"]!.SetValue(bar, eTabStripAlignment.Top);
		TypeDescriptor.GetProperties(bar)["AlwaysDisplayDockTab"]!.SetValue(bar, true);
		TypeDescriptor.GetProperties(bar)["Stretch"]!.SetValue(bar, true);
		TypeDescriptor.GetProperties(bar)["GrabHandleStyle"]!.SetValue(bar, eGrabHandleStyle.None);
		TypeDescriptor.GetProperties(bar)["CanDockBottom"]!.SetValue(bar, false);
		TypeDescriptor.GetProperties(bar)["CanDockTop"]!.SetValue(bar, false);
		TypeDescriptor.GetProperties(bar)["CanDockLeft"]!.SetValue(bar, false);
		TypeDescriptor.GetProperties(bar)["CanDockRight"]!.SetValue(bar, false);
		TypeDescriptor.GetProperties(bar)["CanDockDocument"]!.SetValue(bar, true);
		TypeDescriptor.GetProperties(bar)["CanUndock"]!.SetValue(bar, false);
		TypeDescriptor.GetProperties(bar)["CanHide"]!.SetValue(bar, true);
		TypeDescriptor.GetProperties(bar)["CanCustomize"]!.SetValue(bar, false);
		TypeDescriptor.GetProperties(bar)["TabNavigation"]!.SetValue(bar, true);
	}

	[DllImport("user32")]
	private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

	[DllImport("user32")]
	private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

	[DllImport("user32")]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

	public static void ChangeMDIClientBorder(MdiClient c, bool removeBorder)
	{
		if (c != null)
		{
			int windowLong = GetWindowLong(((Control)c).get_Handle(), -20);
			windowLong = ((!removeBorder) ? (windowLong | 0x200) : (windowLong ^ 0x200));
			SetWindowLong(((Control)c).get_Handle(), -20, windowLong);
			SetWindowPos(((Control)c).get_Handle(), IntPtr.Zero, 0, 0, 0, 0, 39);
		}
	}

	public static void ChangeMDIClientBorder(Form c, bool removeBorder)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		if (!c.get_IsMdiContainer() || !((Control)c).get_IsHandleCreated())
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)c).get_Controls())
		{
			Control val = item;
			if (val is MdiClient)
			{
				ChangeMDIClientBorder((MdiClient)(object)((val is MdiClient) ? val : null), removeBorder);
				break;
			}
		}
	}

	internal static void smethod_0(SubItemsCollection subItemsCollection_0)
	{
		foreach (BaseItem item in subItemsCollection_0)
		{
			smethod_1(item);
		}
	}

	internal static void smethod_1(BaseItem baseItem_0)
	{
		if (baseItem_0.Class261_0 != null)
		{
			baseItem_0.Class261_0.method_0();
		}
		if (baseItem_0.SubItems.Count > 0)
		{
			smethod_0(baseItem_0.SubItems);
		}
	}

	internal static void smethod_2(Control control_0)
	{
		if (control_0 is Bar)
		{
			((Bar)(object)control_0).RecalcLayout();
		}
		else if (control_0 is ItemControl)
		{
			((ItemControl)(object)control_0).RecalcLayout();
		}
		else if (control_0 is BaseItemControl)
		{
			((BaseItemControl)(object)control_0).RecalcLayout();
		}
		else if (control_0 is ExplorerBar)
		{
			((ExplorerBar)(object)control_0).RecalcLayout();
		}
		else if (control_0 is SideBar)
		{
			((SideBar)(object)control_0).RecalcLayout();
		}
	}
}
