using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

internal class Class45 : Class44
{
	public override void Paint(Class47 info)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		int num = 8;
		Rectangle rectangle_ = info.rectangle_0;
		Graphics graphics_ = info.graphics_0;
		Class48 class48_ = info.class48_0;
		PaintBackground(info);
		if ((int)info.dockStyle_0 != 1 && (int)info.dockStyle_0 != 2)
		{
			Point point = new Point(rectangle_.X + (rectangle_.Width - 4) / 2, rectangle_.Y + (rectangle_.Height - 34) / 2);
			SolidBrush val = new SolidBrush(class48_.color_3);
			try
			{
				int num2 = point.Y;
				int num3 = point.X + 1;
				for (int i = 0; i < 9; i++)
				{
					graphics_.FillRectangle((Brush)(object)val, num3, num2, 2, 2);
					num2 += 4;
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			SolidBrush val2 = new SolidBrush(class48_.color_2);
			try
			{
				int num4 = point.Y - 1;
				int x = point.X;
				for (int j = 0; j < 9; j++)
				{
					graphics_.FillRectangle((Brush)(object)val2, x, num4, 2, 2);
					num4 += 4;
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			if (info.bool_0)
			{
				Point p = new Point(rectangle_.X + (rectangle_.Width - base.Int32_0 / 2) / 2, rectangle_.Y + (rectangle_.Height - 36) / 2 - base.Int32_0 - num);
				PaintArrow(p, info);
				p.Offset(0, 36 + num * 2 + base.Int32_0);
				PaintArrow(p, info);
			}
			return;
		}
		Point point2 = new Point(rectangle_.X + (rectangle_.Width - 34) / 2 - 1, rectangle_.Y + (rectangle_.Height - 4) / 2);
		SolidBrush val3 = new SolidBrush(class48_.color_3);
		try
		{
			int num5 = point2.X + 1;
			int num6 = point2.Y + 1;
			for (int k = 0; k < 9; k++)
			{
				graphics_.FillRectangle((Brush)(object)val3, num5, num6, 2, 2);
				num5 += 4;
			}
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
		SolidBrush val4 = new SolidBrush(class48_.color_2);
		try
		{
			int num7 = point2.X;
			int y = point2.Y;
			for (int l = 0; l < 9; l++)
			{
				graphics_.FillRectangle((Brush)(object)val4, num7, y, 2, 2);
				num7 += 4;
			}
		}
		finally
		{
			((IDisposable)val4)?.Dispose();
		}
		if (info.bool_0)
		{
			Point p2 = new Point(rectangle_.X + (rectangle_.Width - 36) / 2 - base.Int32_0 - num, rectangle_.Y + (rectangle_.Height - base.Int32_0 / 2) / 2);
			PaintArrow(p2, info);
			p2.Offset(36 + num * 2 + base.Int32_0, 0);
			PaintArrow(p2, info);
		}
	}
}
