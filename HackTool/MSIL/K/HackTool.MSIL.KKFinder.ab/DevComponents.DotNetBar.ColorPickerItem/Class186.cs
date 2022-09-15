using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar.ColorPickerItem;

internal class Class186
{
	private const float float_0 = 0.57735026f;

	private Color color_0 = Color.Empty;

	private Point[] point_0 = new Point[6];

	private bool bool_0;

	private bool bool_1;

	private Rectangle rectangle_0 = Rectangle.Empty;

	public Color Color_0
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
		}
	}

	public Rectangle Rectangle_0 => rectangle_0;

	public bool Boolean_0
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

	public bool Boolean_1
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public void method_0(float float_1, float float_2, int int_0)
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		float num = (float)int_0 * 0.57735026f;
		ref Point reference = ref point_0[0];
		reference = new Point((int)Math.Floor(float_1 - (float)(int_0 / 2)), (int)Math.Floor(float_2 - num / 2f) - 1);
		ref Point reference2 = ref point_0[1];
		reference2 = new Point((int)Math.Floor(float_1), (int)Math.Floor(float_2 - (float)(int_0 / 2)) - 1);
		ref Point reference3 = ref point_0[2];
		reference3 = new Point((int)Math.Floor(float_1 + (float)(int_0 / 2)), (int)Math.Floor(float_2 - num / 2f) - 1);
		ref Point reference4 = ref point_0[3];
		reference4 = new Point((int)Math.Floor(float_1 + (float)(int_0 / 2)), (int)Math.Floor(float_2 + num / 2f) + 1);
		ref Point reference5 = ref point_0[4];
		reference5 = new Point((int)Math.Floor(float_1), (int)Math.Floor(float_2 + (float)(int_0 / 2)) + 1);
		ref Point reference6 = ref point_0[5];
		reference6 = new Point((int)Math.Floor(float_1 - (float)(int_0 / 2)), (int)Math.Floor(float_2 + num / 2f) + 1);
		GraphicsPath val = new GraphicsPath();
		val.AddPolygon(point_0);
		rectangle_0 = Rectangle.Round(val.GetBounds());
		rectangle_0.Inflate(2, 2);
	}

	public void method_1(Graphics graphics_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		GraphicsPath val = new GraphicsPath();
		val.AddPolygon(point_0);
		val.CloseAllFigures();
		SolidBrush val2 = new SolidBrush(color_0);
		try
		{
			graphics_0.FillPath((Brush)(object)val2, val);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		if (bool_0 || bool_1)
		{
			SmoothingMode smoothingMode = graphics_0.get_SmoothingMode();
			graphics_0.set_SmoothingMode((SmoothingMode)4);
			Pen val3 = new Pen(Color.FromArgb(41, 92, 150), 2f);
			try
			{
				graphics_0.DrawPath(val3, val);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			Pen val4 = new Pen(Color.FromArgb(149, 178, 239), 1f);
			try
			{
				graphics_0.DrawPath(val4, val);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
			graphics_0.set_SmoothingMode(smoothingMode);
		}
		val.Dispose();
	}

	public void method_2(Graphics graphics_0, Color color_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		val.AddPolygon(point_0);
		SolidBrush val2 = new SolidBrush(color_1);
		try
		{
			graphics_0.FillPath((Brush)(object)val2, val);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		val.Dispose();
	}
}
