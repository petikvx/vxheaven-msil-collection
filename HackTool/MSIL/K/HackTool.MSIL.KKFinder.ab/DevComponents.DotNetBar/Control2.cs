using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
internal class Control2 : Control
{
	private BubbleBar bubbleBar_0;

	private Timer timer_0;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Control)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80000 | 0x80);
			createParams.set_Style(-2046820352);
			createParams.set_Caption("");
			return createParams;
		}
	}

	public Control2(BubbleBar parent)
	{
		if (parent == null)
		{
			throw new InvalidOperationException("Parent BubbleBar object for BubbleBarOverlay cannot be null.");
		}
		bubbleBar_0 = parent;
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).SetStyle((ControlStyles)1, false);
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).set_BackColor(Color.Transparent);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
	}

	internal void method_0()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height(), (PixelFormat)2498570);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.Clear(Color.Transparent);
			val2.set_CompositingMode((CompositingMode)1);
			val2.set_TextRenderingHint(Class50.TextRenderingHint_0);
			val2.set_SmoothingMode((SmoothingMode)4);
			PaintEventArgs paintEventArgs_ = new PaintEventArgs(val2, ((Control)this).get_DisplayRectangle());
			bubbleBar_0.method_2(paintEventArgs_);
			IntPtr dC = Class92.GetDC(IntPtr.Zero);
			IntPtr intPtr = Class51.CreateCompatibleDC(dC);
			IntPtr hbitmap = val.GetHbitmap(Color.FromArgb(0));
			IntPtr hObject = Class51.SelectObject(intPtr, hbitmap);
			Class92.SIZE psize = default(Class92.SIZE);
			psize.cx = ((Control)this).get_Width();
			psize.cy = ((Control)this).get_Height();
			Class92.POINT pptDst = default(Class92.POINT);
			pptDst.x = ((Control)this).get_Left();
			pptDst.y = ((Control)this).get_Top();
			Class92.POINT pprSrc = default(Class92.POINT);
			pprSrc.x = 0;
			pprSrc.y = 0;
			Class92.BLENDFUNCTION pblend = default(Class92.BLENDFUNCTION);
			pblend.BlendOp = 0;
			pblend.BlendFlags = 0;
			pblend.SourceConstantAlpha = byte.MaxValue;
			pblend.AlphaFormat = 1;
			Class92.UpdateLayeredWindow(((Control)this).get_Handle(), dC, ref pptDst, ref psize, intPtr, ref pprSrc, 0, ref pblend, 2);
			Class51.SelectObject(intPtr, hObject);
			Class51.ReleaseDC(IntPtr.Zero, dC);
			Class51.DeleteObject(hbitmap);
			Class51.DeleteDC(intPtr);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).set_Capture(true);
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (!((Control)this).get_DisplayRectangle().Contains(e.get_X(), e.get_Y()))
		{
			((Control)this).set_Capture(false);
		}
		bubbleBar_0.method_9(e);
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		bubbleBar_0.method_12(e);
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		bubbleBar_0.method_15(e);
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		bubbleBar_0.method_17(e);
		((Control)this).OnMouseUp(e);
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

	private void method_1()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		if (timer_0 == null)
		{
			timer_0 = new Timer();
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			timer_0.set_Interval(500);
			timer_0.set_Enabled(true);
			timer_0.Start();
		}
	}

	private void method_2()
	{
		if (timer_0 != null)
		{
			timer_0.Stop();
			timer_0.set_Enabled(false);
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		try
		{
			BubbleBar bubbleBar = bubbleBar_0;
			if (bubbleBar != null && !((Control)bubbleBar).get_IsDisposed())
			{
				Form val = ((Control)bubbleBar).FindForm();
				IntPtr foregroundWindow = Class92.GetForegroundWindow();
				Control val2 = null;
				if (foregroundWindow != IntPtr.Zero)
				{
					val2 = Control.FromHandle(foregroundWindow);
				}
				if (val2 == null)
				{
					method_3();
					return;
				}
				if (val != null)
				{
					if (Form.get_ActiveForm() == val)
					{
						return;
					}
					Form val3 = val;
					while (((ContainerControl)val3).get_ParentForm() != null)
					{
						if (((ContainerControl)val3).get_ParentForm() == Form.get_ActiveForm())
						{
							return;
						}
						val3 = ((ContainerControl)val3).get_ParentForm();
					}
					if (val.get_IsMdiChild() && val.get_MdiParent() != null && val.get_MdiParent().get_ActiveMdiChild() == val)
					{
						return;
					}
				}
				Class92.POINT p = default(Class92.POINT);
				Point mousePosition = Control.get_MousePosition();
				p.x = mousePosition.X;
				p.x = mousePosition.Y;
				IntPtr intPtr = IntPtr.Zero;
				if (((Control)bubbleBar).get_Parent() != null)
				{
					Class92.ChildWindowFromPoint(((Control)bubbleBar).get_Parent().get_Handle(), p);
				}
				if (intPtr == IntPtr.Zero)
				{
					intPtr = Class92.WindowFromPoint(p);
				}
				if (intPtr != IntPtr.Zero && intPtr != ((Control)this).get_Handle() && intPtr != ((Control)bubbleBar).get_Handle() && ((Control)bubbleBar).get_Parent() != null && ((Control)bubbleBar).get_Parent().get_Handle() != intPtr)
				{
					method_3();
					return;
				}
				Point pt = ((Control)this).PointToClient(mousePosition);
				if (!((Control)this).get_DisplayRectangle().Contains(pt))
				{
					bubbleBar.method_12(e);
				}
			}
			else
			{
				method_2();
			}
		}
		catch (NullReferenceException)
		{
			method_2();
		}
	}

	private void method_3()
	{
		((Control)this).set_Capture(false);
		method_2();
		bubbleBar_0.method_6();
	}

	internal void method_4()
	{
		method_1();
	}

	internal void method_5()
	{
		method_2();
	}
}
