using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.ColorPickerItem;

[ToolboxItem(false)]
internal class Control5 : UserControl
{
	private EventHandler eventHandler_0;

	private Bitmap bitmap_0;

	private Point point_0 = new Point(-1, -1);

	public Color Color_0
	{
		get
		{
			if (point_0.X >= 0 && point_0.Y >= 0 && bitmap_0 != null)
			{
				return bitmap_0.GetPixel(point_0.X, point_0.Y);
			}
			return Color.Empty;
		}
	}

	public event EventHandler Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public Control5()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)16, true);
	}

	private void method_0()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		int num = 6;
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		int num2 = clientRectangle.Width / 6;
		int num3 = 127;
		int num4 = clientRectangle.X;
		Bitmap val = new Bitmap(clientRectangle.Width, clientRectangle.Height, (PixelFormat)137224);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.FillRectangle(SystemBrushes.get_Control(), clientRectangle);
			for (int i = 0; i < num; i++)
			{
				int num5 = 4;
				int num6 = 255 / (num2 / 4);
				if (num6 < 1)
				{
					num5 = num2 / 255;
					num6 = 1;
				}
				int num7 = 4;
				int num8 = num3 / (clientRectangle.Height / 4);
				if (num8 < 1)
				{
					num7 = clientRectangle.Height / num3;
					num8 = 1;
				}
				int num9 = num4;
				int num10 = clientRectangle.Y;
				int num11 = 0;
				int num12 = 0;
				int num13 = 0;
				int num14 = 0;
				int num15 = 0;
				int num16 = 0;
				int num17 = 0;
				int num18 = 0;
				int num19 = 0;
				switch (i)
				{
				case 0:
					num11 = 255;
					num12 = 0;
					num13 = 0;
					num15 = num6;
					break;
				case 1:
					num11 = 255;
					num12 = 255;
					num13 = 0;
					num14 = -num6;
					break;
				case 2:
					num11 = 0;
					num12 = 255;
					num13 = 0;
					num16 = num6;
					break;
				case 3:
					num11 = 0;
					num12 = 255;
					num13 = 255;
					num15 = -num6;
					break;
				case 4:
					num11 = 0;
					num12 = 0;
					num13 = 255;
					num14 = num6;
					break;
				case 5:
					num11 = 255;
					num12 = 0;
					num13 = 255;
					num16 = -num6;
					break;
				}
				for (int j = 0; j < num2; j += num5)
				{
					int red = num11;
					int green = num12;
					int blue = num13;
					num17 = 127 - num11;
					num18 = 127 - num12;
					num19 = 127 - num13;
					for (int k = clientRectangle.Y; k < clientRectangle.Height; k += num7)
					{
						SolidBrush val3 = new SolidBrush(Color.FromArgb(red, green, blue));
						try
						{
							val2.FillRectangle((Brush)(object)val3, new Rectangle(num9, num10, num5, num7));
						}
						finally
						{
							((IDisposable)val3)?.Dispose();
						}
						num10 += num7;
						red = num11 + (int)((float)num17 * ((float)k / (float)clientRectangle.Height));
						green = num12 + (int)((float)num18 * ((float)k / (float)clientRectangle.Height));
						blue = num13 + (int)((float)num19 * ((float)k / (float)clientRectangle.Height));
					}
					num9 += num5;
					num10 = clientRectangle.Y;
					num11 += num14;
					num12 += num15;
					num13 += num16;
				}
				num4 = num9;
				if (i == 5)
				{
					break;
				}
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		if (bitmap_0 != null)
		{
			((Image)bitmap_0).Dispose();
		}
		bitmap_0 = val;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		graphics.DrawImageUnscaled((Image)(object)bitmap_0, 0, 0);
		if (point_0.X >= 0 && point_0.Y >= 0)
		{
			Color white = Color.White;
			SolidBrush val = new SolidBrush(white);
			try
			{
				Rectangle rectangle = new Rectangle(point_0.X - 2, point_0.Y - 9, 3, 5);
				graphics.FillRectangle((Brush)(object)val, rectangle);
				rectangle.Offset(0, 10);
				graphics.FillRectangle((Brush)(object)val, rectangle);
				rectangle = new Rectangle(point_0.X - 8, point_0.Y - 3, 5, 3);
				graphics.FillRectangle((Brush)(object)val, rectangle);
				rectangle.Offset(10, 0);
				graphics.FillRectangle((Brush)(object)val, rectangle);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		((Control)this).OnPaint(e);
	}

	private void method_1(Point point_1)
	{
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		if (bitmap_0 != null)
		{
			clientRectangle.Width = ((Image)bitmap_0).get_Width();
			clientRectangle.Height = ((Image)bitmap_0).get_Height();
		}
		if (point_1.X < 0)
		{
			point_1.X = 0;
		}
		if (point_1.Y < 0)
		{
			point_1.Y = 0;
		}
		if (point_1.X > clientRectangle.Right)
		{
			point_1.X = clientRectangle.Right - 1;
		}
		if (point_1.Y > clientRectangle.Bottom)
		{
			point_1.Y = clientRectangle.Bottom - 1;
		}
		if (point_1 != point_0)
		{
			if (point_0.X >= 0 && point_0.Y >= 0)
			{
				Rectangle rectangle = new Rectangle(point_0, Size.Empty);
				rectangle.Inflate(10, 10);
				((Control)this).Invalidate(rectangle);
			}
			point_0 = point_1;
			if (point_0.X >= 0 && point_0.Y >= 0)
			{
				Rectangle rectangle2 = new Rectangle(point_0, Size.Empty);
				rectangle2.Inflate(10, 10);
				((Control)this).Invalidate(rectangle2);
			}
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs());
			}
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((UserControl)this).OnMouseDown(e);
		method_1(new Point(e.get_X(), e.get_Y()));
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseMove(e);
		if ((int)e.get_Button() == 1048576)
		{
			int num = e.get_X();
			int num2 = e.get_Y();
			if (num < 0)
			{
				num = 0;
			}
			if (num >= ((Control)this).get_ClientRectangle().Width)
			{
				num = ((Control)this).get_ClientRectangle().Width - 1;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num2 >= ((Control)this).get_ClientRectangle().Height)
			{
				num2 = ((Control)this).get_ClientRectangle().Height - 1;
			}
			method_1(new Point(num, num2));
		}
	}

	protected override void OnResize(EventArgs e)
	{
		method_0();
		((UserControl)this).OnResize(e);
	}
}
