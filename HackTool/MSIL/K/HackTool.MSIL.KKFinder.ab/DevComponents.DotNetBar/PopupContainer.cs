using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ComVisible(false)]
[ToolboxItem(false)]
public class PopupContainer : Control
{
	private const int int_0 = 33;

	private const int int_1 = 3;

	private const int int_2 = 4;

	private const uint uint_0 = 2147483648u;

	private const uint uint_1 = 67108864u;

	private const uint uint_2 = 33554432u;

	private const uint uint_3 = 8u;

	private const uint uint_4 = 128u;

	private const int int_3 = 5;

	private Control8 control8_0;

	private bool bool_0;

	private MenuPanel MenuPanel_0
	{
		get
		{
			if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() > 0 && ((Control)this).get_Controls().get_Item(0) is MenuPanel)
			{
				return ((Control)this).get_Controls().get_Item(0) as MenuPanel;
			}
			return null;
		}
	}

	private Bar Bar_0
	{
		get
		{
			if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() > 0 && ((Control)this).get_Controls().get_Item(0) is Bar)
			{
				return ((Control)this).get_Controls().get_Item(0) as Bar;
			}
			return null;
		}
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Control)this).get_CreateParams();
			createParams.set_Style(-2046820352);
			createParams.set_ExStyle(136);
			createParams.set_Caption("");
			return createParams;
		}
	}

	public bool ShowDropShadow
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

	public PopupContainer()
	{
		((Control)this).set_IsAccessible(false);
		((Control)this).SetStyle((ControlStyles)512, false);
	}

	protected override void Dispose(bool disposing)
	{
		if (control8_0 != null)
		{
			((Control)control8_0).Hide();
			((Component)(object)control8_0).Dispose();
			control8_0 = null;
		}
		((Control)this).Dispose(disposing);
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		((Control)this).OnVisibleChanged(e);
		if (!((Control)this).get_Visible() && control8_0 != null)
		{
			((Control)control8_0).Hide();
			((Component)(object)control8_0).Dispose();
			control8_0 = null;
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 33)
		{
			((Message)(ref m)).set_Result(new IntPtr(3));
		}
		else
		{
			((Control)this).WndProc(ref m);
		}
	}

	public void ShowShadow()
	{
		if (bool_0)
		{
			if (control8_0 != null)
			{
				((Control)control8_0).Hide();
				((Component)(object)control8_0).Dispose();
				control8_0 = null;
			}
			if (((Control)this).get_Width() > 5 && ((Control)this).get_Height() > 5)
			{
				control8_0 = new Control8(bAlphaShadow: true);
				((Control)control8_0).CreateControl();
				Class92.SetWindowPos(((Control)control8_0).get_Handle(), -2, ((Control)this).get_Left() + 5, ((Control)this).get_Top() + 5, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2, 80);
				control8_0.method_1();
			}
		}
	}

	protected override void OnResize(EventArgs e)
	{
		if (control8_0 != null)
		{
			Class92.SetWindowPos(((Control)control8_0).get_Handle(), -2, ((Control)this).get_Left() + 5, ((Control)this).get_Top() + 5, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2, 80);
			control8_0.method_1();
		}
		((Control)this).OnResize(e);
	}
}
