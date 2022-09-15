using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.ColorPickerItem;

[ToolboxItem(false)]
internal class ColorContrastControl : UserControl
{
	private EventHandler eventHandler_0;

	private Container container_0;

	private Color color_0 = Color.White;

	private Bitmap bitmap_0;

	private double double_0 = -1.0;

	public Color Color_0
	{
		get
		{
			if (double_0 >= 0.0)
			{
				double double_ = 0.0;
				double double_2 = 0.0;
				double double_3 = 0.0;
				method_3(color_0, ref double_, ref double_2, ref double_3);
				return method_2(double_, double_2, double_0);
			}
			return color_0;
		}
		set
		{
			color_0 = value;
			double double_ = 0.0;
			double double_2 = 0.0;
			double double_3 = 0.0;
			method_3(color_0, ref double_, ref double_2, ref double_3);
			if (double_0 < 0.0)
			{
				double_0 = double_3;
			}
			method_0();
			((Control)this).Invalidate();
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

	public ColorContrastControl()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && container_0 != null)
		{
			container_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		if (((Control)this).get_BackColor() == Color.Transparent)
		{
			((ScrollableControl)this).OnPaintBackground(e);
		}
		else
		{
			SolidBrush val = new SolidBrush(((Control)this).get_BackColor());
			try
			{
				graphics.FillRectangle((Brush)(object)val, ((Control)this).get_ClientRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		if (bitmap_0 != null)
		{
			graphics.DrawImageUnscaled((Image)(object)bitmap_0, 0, 0);
		}
		if (double_0 >= 0.0)
		{
			int num = (int)((double)((Control)this).get_ClientRectangle().Height * (1.0 - double_0));
			int num2 = ((Image)bitmap_0).get_Width() + 4;
			GraphicsPath val2 = new GraphicsPath();
			val2.AddLine(num2, num, num2 + 7, num - 4);
			val2.AddLine(num2 + 7, num - 4, num2 + 7, num + 4);
			val2.CloseAllFigures();
			SolidBrush val3 = new SolidBrush(Color.Black);
			try
			{
				graphics.FillPath((Brush)(object)val3, val2);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			val2.Dispose();
		}
	}

	protected override void OnResize(EventArgs e)
	{
		method_0();
		((UserControl)this).OnResize(e);
	}

	private void method_0()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		Bitmap val = new Bitmap(12, clientRectangle.Height, (PixelFormat)137224);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.FillRectangle(SystemBrushes.get_Control(), clientRectangle);
			Color color = color_0;
			_ = color.R;
			_ = color.G;
			_ = color.B;
			int num = 4;
			int width = 12;
			int x = clientRectangle.X;
			int num2 = clientRectangle.Y;
			double double_ = 0.0;
			double double_2 = 0.0;
			double double_3 = 0.0;
			method_3(color_0, ref double_, ref double_2, ref double_3);
			for (int i = clientRectangle.Y; i < clientRectangle.Height; i += num)
			{
				double double_4 = 1.0 - (double)i / (double)clientRectangle.Height;
				Color color2 = method_2(double_, double_2, double_4);
				SolidBrush val3 = new SolidBrush(color2);
				try
				{
					val2.FillRectangle((Brush)(object)val3, new Rectangle(x, num2, width, num));
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
				num2 += num;
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

	private int method_1(float float_0, float float_1, float float_2)
	{
		if (float_2 > 360f)
		{
			float_2 -= 360f;
		}
		else if (float_2 < 0f)
		{
			float_2 += 360f;
		}
		if (float_2 < 60f)
		{
			float_0 += (float_1 - float_0) * float_2 / 60f;
		}
		else if (float_2 < 180f)
		{
			float_0 = float_1;
		}
		else if (float_2 < 240f)
		{
			float_0 += (float_1 - float_0) * (240f - float_2) / 60f;
		}
		return (int)(float_0 * 255f);
	}

	private Color method_2(double double_1, double double_2, double double_3)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		if (double_3 == 0.0)
		{
			num3 = 0.0;
			num2 = 0.0;
			num = 0.0;
		}
		else if (double_2 == 0.0)
		{
			num = (num2 = (num3 = double_3));
		}
		else
		{
			double num4 = ((double_3 <= 0.5) ? (double_3 * (1.0 + double_2)) : (double_3 + double_2 - double_3 * double_2));
			double num5 = 2.0 * double_3 - num4;
			double[] array = new double[3]
			{
				double_1 + 1.0 / 3.0,
				double_1,
				double_1 - 1.0 / 3.0
			};
			double[] array2 = new double[3];
			double[] array3 = array2;
			for (int i = 0; i < 3; i++)
			{
				if (array[i] < 0.0)
				{
					array[i] += 1.0;
				}
				if (array[i] > 1.0)
				{
					array[i] -= 1.0;
				}
				if (6.0 * array[i] < 1.0)
				{
					array3[i] = num5 + (num4 - num5) * array[i] * 6.0;
				}
				else if (2.0 * array[i] < 1.0)
				{
					array3[i] = num4;
				}
				else if (3.0 * array[i] < 2.0)
				{
					array3[i] = num5 + (num4 - num5) * (2.0 / 3.0 - array[i]) * 6.0;
				}
				else
				{
					array3[i] = num5;
				}
			}
			num = array3[0];
			num2 = array3[1];
			num3 = array3[2];
		}
		return Color.FromArgb((int)(255.0 * num), (int)(255.0 * num2), (int)(255.0 * num3));
	}

	private void method_3(Color color_1, ref double double_1, ref double double_2, ref double double_3)
	{
		double_1 = (double)color_1.GetHue() / 360.0;
		double_3 = color_1.GetBrightness();
		double_2 = color_1.GetSaturation();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		double double_ = 1.0 - (double)e.get_Y() / (double)((Control)this).get_ClientRectangle().Height;
		method_4(double_);
		((UserControl)this).OnMouseDown(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576 && e.get_Y() >= 0 && e.get_Y() < ((Control)this).get_ClientRectangle().Bottom)
		{
			double double_ = 1.0 - (double)e.get_Y() / (double)((Control)this).get_ClientRectangle().Height;
			method_4(double_);
		}
		((Control)this).OnMouseMove(e);
	}

	private void method_4(double double_1)
	{
		double_0 = double_1;
		((Control)this).Invalidate();
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
	}

	private void InitializeComponent()
	{
		((Control)this).set_Name("ColorContrastControl");
		((Control)this).set_Size(new Size(24, 248));
	}
}
