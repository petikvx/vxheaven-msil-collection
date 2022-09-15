using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.ColorPickerItem;

[ToolboxItem(false)]
internal class Control4 : UserControl
{
	private const float float_0 = 0.824f;

	private EventHandler eventHandler_0;

	private Class186[] class186_0 = new Class186[144];

	private float[] float_1 = new float[6] { -0.5f, -1f, -0.5f, 0.5f, 1f, 0.5f };

	private float[] float_2 = new float[6] { 0.824f, 0f, -0.824f, -0.824f, 0f, 0.824f };

	private int int_0 = 7;

	private int int_1 = -1;

	private int int_2 = -1;

	private Container container_0;

	public Color Color_0
	{
		get
		{
			if (int_2 < 0)
			{
				return Color.Empty;
			}
			return class186_0[int_2].Color_0;
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

	public Control4()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < class186_0.Length; i++)
		{
			class186_0[i] = new Class186();
		}
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		method_0();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && container_0 != null)
		{
			container_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void method_0()
	{
		container_0 = new Container();
	}

	private int method_1(int int_3)
	{
		int num = int_3 / (2 * int_0 - 1) + 1;
		if ((int)Math.Floor((double)num / 2.0) * 2 < num)
		{
			num--;
		}
		return num;
	}

	private void method_2()
	{
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		clientRectangle.Inflate(-8, -8);
		clientRectangle.Height -= method_1(Math.Min(clientRectangle.Height, clientRectangle.Width)) * 3;
		if (clientRectangle.Height < clientRectangle.Width)
		{
			clientRectangle.Inflate(-(clientRectangle.Width - clientRectangle.Height) / 2, 0);
		}
		else
		{
			clientRectangle.Inflate(0, -(clientRectangle.Height - clientRectangle.Width) / 2);
		}
		int num = method_1(clientRectangle.Height);
		int num2 = (clientRectangle.Left + clientRectangle.Right) / 2;
		int num3 = (clientRectangle.Top + clientRectangle.Bottom) / 2;
		class186_0[0].Color_0 = Color.White;
		class186_0[0].method_0(num2, num3, num);
		int num4 = 1;
		for (int i = 1; i < int_0; i++)
		{
			float num5 = num2 + num * i;
			float num6 = num3;
			for (int j = 0; j < int_0 - 1; j++)
			{
				int num7 = (int)((float)num * float_1[j]);
				int num8 = (int)((float)num * float_2[j]);
				for (int k = 0; k < i; k++)
				{
					float num9 = method_4(num5 - (float)num2, num6 - (float)num3);
					double double_ = 0.936 * (double)(int_0 - i) / (double)int_0 + 0.12;
					class186_0[num4].Color_0 = method_3(num9, double_, 1.0);
					class186_0[num4].method_0(num5, num6, num);
					num4++;
					num5 += (float)num7;
					num6 += (float)num8;
				}
			}
		}
		class186_0[num4].Color_0 = Color.Black;
		num4++;
		class186_0[num4].Color_0 = Color.White;
		int num10 = 15;
		int num11 = 240;
		num2 = clientRectangle.X + num * 3;
		num3 = clientRectangle.Bottom;
		for (int l = 0; l < 15; l++)
		{
			Color color_ = Color.FromArgb(num11, num11, num11);
			class186_0[num4].Color_0 = color_;
			class186_0[num4].method_0(num2, num3, num);
			num2 += num;
			num4++;
			if (l == 7)
			{
				num2 = clientRectangle.X + (int)((double)num * 3.5);
				num3 += (int)((float)num * 0.824f);
			}
			num11 -= num10;
		}
		class186_0[num4].Color_0 = Color.Black;
	}

	private Color method_3(double double_0, double double_1, double double_2)
	{
		int red;
		int green;
		int blue;
		if (double_2 == 0.0)
		{
			red = (green = (blue = (int)(double_1 * 255.0)));
		}
		else
		{
			float num = ((!(double_1 <= 0.5)) ? ((float)(double_1 + double_2 - double_1 * double_2)) : ((float)(double_1 + double_1 * double_2)));
			float float_ = (float)(2.0 * double_1 - (double)num);
			red = method_5(float_, num, (float)(double_0 + 120.0));
			green = method_5(float_, num, (float)double_0);
			blue = method_5(float_, num, (float)(double_0 - 120.0));
		}
		return Color.FromArgb(red, green, blue);
	}

	private float method_4(float float_3, float float_4)
	{
		double num = Math.Atan2(float_4, float_3);
		return (float)(num * 180.0 / Math.PI);
	}

	private int method_5(float float_3, float float_4, float float_5)
	{
		if (float_5 > 360f)
		{
			float_5 -= 360f;
		}
		else if (float_5 < 0f)
		{
			float_5 += 360f;
		}
		if (float_5 < 60f)
		{
			float_3 += (float_4 - float_3) * float_5 / 60f;
		}
		else if (float_5 < 180f)
		{
			float_3 = float_4;
		}
		else if (float_5 < 240f)
		{
			float_3 += (float_4 - float_3) * (240f - float_5) / 60f;
		}
		return (int)(float_3 * 255f);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		if (((Control)this).get_BackColor() == Color.Transparent)
		{
			((ScrollableControl)this).OnPaintBackground(e);
		}
		Graphics graphics = e.get_Graphics();
		SolidBrush val = new SolidBrush(((Control)this).get_BackColor());
		try
		{
			graphics.FillRectangle((Brush)(object)val, ((Control)this).get_ClientRectangle());
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		Class186[] array = class186_0;
		foreach (Class186 @class in array)
		{
			@class.method_1(graphics);
		}
		if (int_1 >= 0)
		{
			class186_0[int_1].method_1(graphics);
		}
		if (int_2 >= 0)
		{
			class186_0[int_2].method_1(graphics);
		}
		((Control)this).OnPaint(e);
	}

	protected override void OnResize(EventArgs e)
	{
		method_2();
		((UserControl)this).OnResize(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		int int_ = method_7(e.get_X(), e.get_Y());
		method_6(int_);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			if (int_2 >= 0)
			{
				class186_0[int_2].Boolean_1 = false;
				((Control)this).Invalidate(class186_0[int_2].Rectangle_0);
			}
			int_2 = -1;
			if (int_1 >= 0)
			{
				int_2 = int_1;
				class186_0[int_2].Boolean_1 = true;
				if (eventHandler_0 != null)
				{
					eventHandler_0(this, new EventArgs());
				}
				((Control)this).Invalidate(class186_0[int_2].Rectangle_0);
			}
		}
		((UserControl)this).OnMouseDown(e);
	}

	private void method_6(int int_3)
	{
		if (int_3 != int_1)
		{
			if (int_1 >= 0)
			{
				class186_0[int_1].Boolean_0 = false;
				((Control)this).Invalidate(class186_0[int_1].Rectangle_0);
			}
			int_1 = int_3;
			if (int_1 >= 0)
			{
				class186_0[int_1].Boolean_0 = true;
				((Control)this).Invalidate(class186_0[int_1].Rectangle_0);
			}
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		method_6(-1);
	}

	private int method_7(int int_3, int int_4)
	{
		int num = 0;
		while (true)
		{
			if (num < class186_0.Length)
			{
				if (class186_0[num].Rectangle_0.Contains(int_3, int_4))
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}
}
