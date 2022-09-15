using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
internal class Form0 : Form
{
	private const int int_0 = 33;

	private const int int_1 = 3;

	private Bar bar_0;

	private Size size_0 = Size.Empty;

	private bool bool_0;

	public Form0(Bar objBar)
	{
		bar_0 = objBar;
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_ControlBox(false);
		((Form)this).set_ShowInTaskbar(false);
		if (objBar.Owner is IOwner owner)
		{
			((Form)this).set_Owner(owner.ParentForm);
		}
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
	}

	public void method_0()
	{
		bool_0 = true;
		((Form)this).Close();
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		if (((Control)this).get_Visible() && !bool_0)
		{
			e.Cancel = true;
			if (bar_0 != null)
			{
				bar_0.method_59();
			}
		}
		((Form)this).OnClosing(e);
	}

	public void method_1(Size size_1)
	{
		if (bar_0 == null || size_0 == size_1 || !bar_0.IsThemed)
		{
			return;
		}
		size_0 = size_1;
		Class77 class77_ = bar_0.Class77_0;
		Graphics val = ((Control)this).CreateGraphics();
		try
		{
			IntPtr intPtr = class77_.method_5(val, Class124.class124_2, Class149.class149_1, new Rectangle(0, 0, size_1.Width, size_1.Height));
			if (intPtr != IntPtr.Zero)
			{
				Class92.SetWindowRgn(((Control)this).get_Handle(), intPtr, bRedraw: true);
			}
		}
		finally
		{
			val.Dispose();
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 33 && bar_0.LayoutType != eLayoutType.DockContainer)
		{
			((Message)(ref m)).set_Result(new IntPtr(3));
		}
		else
		{
			((Form)this).WndProc(ref m);
		}
	}

	protected override void OnActivated(EventArgs e)
	{
		((Form)this).OnActivated(e);
		if (bar_0 != null && bar_0.LayoutType == eLayoutType.DockContainer)
		{
			bar_0.method_2(bool_67: true);
		}
	}

	protected override void OnDeactivate(EventArgs e)
	{
		((Form)this).OnDeactivate(e);
		if (bar_0 != null && bar_0.LayoutType == eLayoutType.DockContainer)
		{
			bar_0.method_2(bool_67: false);
		}
	}
}
