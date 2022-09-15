using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.ColorPickerItem;

[ToolboxItem(false)]
internal class Control6 : UserControl
{
	private Color color_0 = Color.Black;

	private Color color_1 = Color.Empty;

	public Color Color_0
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			((Control)this).Invalidate();
		}
	}

	public Color Color_1
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			((Control)this).Invalidate();
		}
	}

	public Control6()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)16, true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		if (((Control)this).get_BackColor() == Color.Transparent)
		{
			((ScrollableControl)this).OnPaintBackground(e);
		}
		Graphics graphics = e.get_Graphics();
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		graphics.FillRectangle(SystemBrushes.get_Control(), clientRectangle);
		if (!color_1.IsEmpty)
		{
			SolidBrush val = new SolidBrush(color_1);
			try
			{
				graphics.FillRectangle((Brush)(object)val, clientRectangle.X, clientRectangle.Y, clientRectangle.Width, clientRectangle.Height / 2);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		if (!color_0.IsEmpty)
		{
			SolidBrush val2 = new SolidBrush(color_0);
			try
			{
				graphics.FillRectangle((Brush)(object)val2, clientRectangle.X, clientRectangle.Y + clientRectangle.Height / 2, clientRectangle.Width, clientRectangle.Height / 2);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		Pen val3 = new Pen(Color.Black);
		try
		{
			clientRectangle.Width--;
			clientRectangle.Height--;
			graphics.DrawRectangle(val3, clientRectangle);
			graphics.DrawLine(val3, clientRectangle.X, clientRectangle.Y + clientRectangle.Height / 2, clientRectangle.Right, clientRectangle.Y + clientRectangle.Height / 2);
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
	}
}
