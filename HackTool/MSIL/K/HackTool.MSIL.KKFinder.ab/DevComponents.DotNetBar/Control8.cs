using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Control8 : Control
{
	private bool bool_0 = true;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Control)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 8 | (bool_0 ? 524288 : 0) | 0x80);
			createParams.set_Style(-2046820352);
			createParams.set_Caption("");
			return createParams;
		}
	}

	public Control8(bool bAlphaShadow)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		bool_0 = bAlphaShadow;
		((Control)this).set_Visible(false);
		((Control)this).SuspendLayout();
		if (!bool_0)
		{
			((Control)this).set_BackColor(SystemColors.ControlDark);
		}
		((Control)this).set_Size(new Size(12, 12));
		((Control)this).SetStyle((ControlStyles)1, false);
		((Control)this).SetStyle((ControlStyles)512, false);
		if (bool_0)
		{
			((Control)this).SetStyle((ControlStyles)8192, true);
			((Control)this).SetStyle(Class50.ControlStyles_0, false);
		}
		((Control)this).ResumeLayout();
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
	}

	private void method_0()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		if (((Control)this).get_Width() <= 0 || ((Control)this).get_Height() <= 0)
		{
			return;
		}
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height(), (PixelFormat)2498570);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			Region val3 = new Region();
			GraphicsPath val4 = new GraphicsPath();
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			val4.StartFigure();
			val4.AddLine(clientRectangle.Right - 5, clientRectangle.Top, clientRectangle.Right, clientRectangle.Top);
			val4.AddLine(clientRectangle.Right, clientRectangle.Top, clientRectangle.Right, clientRectangle.Top + 5);
			val4.AddLine(clientRectangle.Right, clientRectangle.Top + 5, clientRectangle.Right - 5, clientRectangle.Top);
			val4.CloseFigure();
			val4.StartFigure();
			val4.AddLine(clientRectangle.Left, clientRectangle.Bottom - 5 - 1, clientRectangle.Left, clientRectangle.Bottom);
			val4.AddLine(clientRectangle.Left, clientRectangle.Bottom, clientRectangle.Left + 5, clientRectangle.Bottom);
			val4.AddLine(clientRectangle.Left + 5, clientRectangle.Bottom, clientRectangle.Left, clientRectangle.Bottom - 5);
			val4.CloseFigure();
			val4.StartFigure();
			val4.AddRectangle(new Rectangle(0, 0, clientRectangle.Width - 5, clientRectangle.Height - 5));
			val4.CloseFigure();
			val3.Xor(val4);
			val2.SetClip(val3, (CombineMode)0);
			val2.Clear(Color.Transparent);
			val2.set_CompositingMode((CompositingMode)1);
			val2.set_SmoothingMode((SmoothingMode)4);
			val2.Clear(Color.Black);
			clientRectangle.Width--;
			clientRectangle.Height--;
			Color[] array = new Color[5]
			{
				Color.FromArgb(14, Color.Black),
				Color.FromArgb(43, Color.Black),
				Color.FromArgb(84, Color.Black),
				Color.FromArgb(113, Color.Black),
				Color.FromArgb(128, Color.Black)
			};
			for (int i = 0; i < 4; i++)
			{
				Pen val5 = new Pen(array[i], 1f);
				try
				{
					val2.DrawPath(val5, method_2(clientRectangle, 4 - i));
					clientRectangle.Inflate(-1, -1);
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
			}
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

	public void method_1()
	{
		if (bool_0)
		{
			method_0();
		}
	}

	private GraphicsPath method_2(Rectangle rectangle_0, int int_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		val.AddArc(rectangle_0.Right - int_0, rectangle_0.Y, int_0, int_0, 270f, 90f);
		val.AddLine(rectangle_0.Right, rectangle_0.Y + int_0, rectangle_0.Right, rectangle_0.Bottom - int_0);
		val.AddArc(rectangle_0.Right - int_0, rectangle_0.Bottom - int_0, int_0, int_0, 0f, 90f);
		val.AddLine(rectangle_0.Right - int_0, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Bottom);
		val.AddLine(rectangle_0.X, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Top);
		return val;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (!bool_0)
		{
			e.get_Graphics().Clear(((Control)this).get_BackColor());
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
}
