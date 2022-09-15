using System.Drawing;

namespace DevComponents.DotNetBar;

internal class Class46 : Class44
{
	public override void Paint(Class47 info)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		int num = 42;
		int num2 = 8;
		Rectangle rectangle_ = info.rectangle_0;
		Graphics graphics_ = info.graphics_0;
		PaintBackground(info);
		if ((int)info.dockStyle_0 != 1 && (int)info.dockStyle_0 != 2)
		{
			if (info.rectangle_0.Height - base.Int32_0 * 2 < num)
			{
				num = info.rectangle_0.Height - base.Int32_0 * 2;
				if (num < 0)
				{
					num = info.rectangle_0.Height;
				}
			}
			Point point = new Point(rectangle_.X + (rectangle_.Width - 5) / 2, rectangle_.Y + (rectangle_.Height - num) / 2);
			SolidBrush val = new SolidBrush(info.class48_0.color_3);
			SolidBrush val2 = new SolidBrush(info.class48_0.color_2);
			for (int i = point.Y; i < point.Y + num; i += 3)
			{
				graphics_.FillRectangle((Brush)(object)val, point.X + 3, i, 1, 1);
				graphics_.FillRectangle((Brush)(object)val2, point.X + 4, i + 1, 1, 1);
				graphics_.FillRectangle((Brush)(object)val, point.X, i + 1, 1, 1);
				graphics_.FillRectangle((Brush)(object)val2, point.X + 1, i + 2, 1, 1);
			}
			((Brush)val).Dispose();
			((Brush)val2).Dispose();
			if (info.bool_0)
			{
				Point p = new Point(rectangle_.X + (rectangle_.Width - base.Int32_0 / 2) / 2, rectangle_.Y + (rectangle_.Height - num) / 2 - base.Int32_0 - num2);
				PaintArrow(p, info);
				p.Offset(0, num + num2 * 2 + base.Int32_0);
				PaintArrow(p, info);
			}
			return;
		}
		if (info.rectangle_0.Width - base.Int32_0 * 2 < num)
		{
			num = info.rectangle_0.Width - base.Int32_0 * 2;
			if (num < 0)
			{
				num = info.rectangle_0.Width;
			}
		}
		Point point2 = new Point(rectangle_.X + (rectangle_.Width - num) / 2, rectangle_.Y + (rectangle_.Height - 5) / 2);
		SolidBrush val3 = new SolidBrush(info.class48_0.color_3);
		SolidBrush val4 = new SolidBrush(info.class48_0.color_2);
		for (int j = point2.X; j < point2.X + num; j += 3)
		{
			graphics_.FillRectangle((Brush)(object)val3, j, point2.Y + 3, 1, 1);
			graphics_.FillRectangle((Brush)(object)val4, j + 1, point2.Y + 4, 1, 1);
			graphics_.FillRectangle((Brush)(object)val3, j + 1, point2.Y, 1, 1);
			graphics_.FillRectangle((Brush)(object)val4, j + 2, point2.Y + 1, 1, 1);
		}
		((Brush)val3).Dispose();
		((Brush)val4).Dispose();
		if (info.bool_0)
		{
			Point p2 = new Point(rectangle_.X + (rectangle_.Width - num) / 2 - base.Int32_0 - num2, rectangle_.Y + (rectangle_.Height - base.Int32_0 / 2) / 2);
			PaintArrow(p2, info);
			p2.Offset(num + num2 * 2 + base.Int32_0, 0);
			PaintArrow(p2, info);
		}
	}
}
