using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Control1 : Control
{
	private Control control_0;

	private Interface0 interface0_0;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Control)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x20);
			return createParams;
		}
	}

	public Control1(Interface0 renderer)
	{
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).SetStyle((ControlStyles)1, false);
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).set_BackColor(Color.Transparent);
		interface0_0 = renderer;
	}

	protected override void Dispose(bool disposing)
	{
		if (control_0 != null)
		{
			control_0.remove_Resize((EventHandler)control_0_Resize);
			control_0 = null;
		}
		((Control)this).Dispose(disposing);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (interface0_0 != null)
		{
			interface0_0.imethod_0(e.get_Graphics());
		}
		((Control)this).OnPaint(e);
	}

	protected override void OnParentChanged(EventArgs e)
	{
		if (control_0 != null)
		{
			control_0.remove_Resize((EventHandler)control_0_Resize);
		}
		control_0 = ((Control)this).get_Parent();
		if (control_0 != null)
		{
			control_0.add_Resize((EventHandler)control_0_Resize);
		}
		((Control)this).OnParentChanged(e);
	}

	protected override void OnPaintBackground(PaintEventArgs e)
	{
	}

	private void control_0_Resize(object sender, EventArgs e)
	{
		if (control_0 != null)
		{
			((Control)this).set_Bounds(new Rectangle(0, 0, control_0.get_Width(), control_0.get_Height()));
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 132)
		{
			((Message)(ref m)).set_Result(new IntPtr(-1));
		}
		else
		{
			((Control)this).WndProc(ref m);
		}
	}
}
