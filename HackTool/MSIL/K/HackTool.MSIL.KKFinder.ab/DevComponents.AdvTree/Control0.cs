using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree;

internal class Control0 : Control
{
	private ColumnHeaderCollection columnHeaderCollection_0;

	private Cursor cursor_0;

	private ColumnHeader columnHeader_0;

	public ColumnHeaderCollection ColumnHeaderCollection_0
	{
		get
		{
			return columnHeaderCollection_0;
		}
		set
		{
			columnHeaderCollection_0 = value;
		}
	}

	public Control0()
	{
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)65536, true);
		((Control)this).SetStyle((ControlStyles)512, false);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = e.get_Graphics();
		Class50.smethod_23(graphics, ((Control)this).get_ClientRectangle(), ((Control)this).get_BackColor());
		if (columnHeaderCollection_0 == null)
		{
			return;
		}
		AdvTree advTree = method_2();
		if (advTree != null)
		{
			SmoothingMode smoothingMode = graphics.get_SmoothingMode();
			TextRenderingHint textRenderingHint = graphics.get_TextRenderingHint();
			if (advTree.AntiAlias)
			{
				graphics.set_SmoothingMode((SmoothingMode)4);
				graphics.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
			if (advTree.Zoom != 1f)
			{
				Matrix transform = method_1(advTree.Zoom);
				graphics.set_Transform(transform);
			}
			advTree.NodeDisplay_0.vmethod_0(columnHeaderCollection_0, graphics, bool_0: true);
			if (advTree.AntiAlias)
			{
				graphics.set_SmoothingMode(smoothingMode);
				graphics.set_TextRenderingHint(textRenderingHint);
			}
		}
		((Control)this).OnPaint(e);
	}

	private Point method_0(float float_0, int int_0, int int_1)
	{
		if (float_0 == 1f)
		{
			return new Point(int_0, int_1);
		}
		Point[] array = new Point[1]
		{
			new Point(int_0, int_1)
		};
		Matrix val = method_1(float_0);
		try
		{
			val.Invert();
			val.TransformPoints(array);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return array[0];
	}

	private Matrix method_1(float float_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		return new Matrix(float_0, 0f, 0f, float_0, 0f, 0f);
	}

	private AdvTree method_2()
	{
		return ((Control)this).get_Parent() as AdvTree;
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		AdvTree advTree = method_2();
		if (advTree == null || (int)e.get_Button() != 0 || !advTree.AllowUserToResizeColumns)
		{
			return;
		}
		Point point = method_0(advTree.Zoom, e.get_X(), e.get_Y());
		if (advTree.method_2(point.X, point.Y))
		{
			if (cursor_0 == (Cursor)null)
			{
				cursor_0 = ((Control)this).get_Cursor();
				((Control)this).set_Cursor(Cursors.get_VSplit());
			}
		}
		else
		{
			method_3();
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		AdvTree advTree = method_2();
		Point point = Point.Empty;
		if (advTree != null)
		{
			point = method_0(advTree.Zoom, e.get_X(), e.get_Y());
			ColumnHeader columnHeader = advTree.method_3(point.X, point.Y, columnHeaderCollection_0);
			if (columnHeader != null)
			{
				columnHeader_0 = columnHeader;
				columnHeader.OnMouseDown(e);
			}
		}
		if (advTree != null && (int)e.get_Button() == 1048576 && advTree.AllowUserToResizeColumns)
		{
			if (advTree.method_2(point.X, point.Y))
			{
				advTree.method_5(point.X, point.Y);
			}
			((Control)this).OnMouseDown(e);
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		method_3();
		if (columnHeader_0 != null)
		{
			columnHeader_0.OnMouseUp(e);
			columnHeader_0 = null;
		}
		((Control)this).OnMouseUp(e);
	}

	private void method_3()
	{
		if (cursor_0 != (Cursor)null)
		{
			((Control)this).set_Cursor(cursor_0);
			cursor_0 = null;
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		if ((int)Control.get_MouseButtons() != 1048576)
		{
			method_3();
		}
		((Control)this).OnMouseLeave(e);
	}
}
