using System;
using System.Drawing;
using System.Drawing.Imaging;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class96 : Class95, Interface3
{
	private Office2007ColorTable office2007ColorTable_0;

	public Office2007ColorTable Office2007ColorTable_0
	{
		get
		{
			return office2007ColorTable_0;
		}
		set
		{
			office2007ColorTable_0 = value;
		}
	}

	public override void Paint(MdiSystemItemRendererEventArgs e)
	{
		MDISystemItem mdiSystemItem = e.MdiSystemItem;
		Graphics graphics = e.Graphics;
		Rectangle rectangle = mdiSystemItem.DisplayRectangle;
		if (mdiSystemItem.IsSystemIcon)
		{
			rectangle.Offset((rectangle.Width - 16) / 2, (rectangle.Height - 16) / 2);
			if (mdiSystemItem.Icon != null)
			{
				graphics.DrawIconUnstretched(mdiSystemItem.Icon, rectangle);
			}
			return;
		}
		rectangle = new Rectangle(mdiSystemItem.DisplayRectangle.Location, mdiSystemItem.vmethod_1());
		if (mdiSystemItem.Orientation == eOrientation.Horizontal)
		{
			rectangle.Offset(0, (mdiSystemItem.DisplayRectangle.Height - rectangle.Height) / 2);
		}
		else
		{
			rectangle.Offset((mdiSystemItem.WidthInternal - rectangle.Width) / 2, 0);
		}
		method_1(graphics, mdiSystemItem, Enum13.const_1, rectangle, method_0(mdiSystemItem, Enum13.const_1), office2007ColorTable_0.LegacyColors);
		if (mdiSystemItem.Orientation == eOrientation.Horizontal)
		{
			rectangle.Offset(rectangle.Width, 0);
		}
		else
		{
			rectangle.Offset(0, rectangle.Height);
		}
		method_1(graphics, mdiSystemItem, Enum13.const_2, rectangle, method_0(mdiSystemItem, Enum13.const_2), office2007ColorTable_0.LegacyColors);
		if (mdiSystemItem.Orientation == eOrientation.Horizontal)
		{
			rectangle.Offset(rectangle.Width + 2, 0);
		}
		else
		{
			rectangle.Offset(0, rectangle.Height + 2);
		}
		method_1(graphics, mdiSystemItem, Enum13.const_3, rectangle, method_0(mdiSystemItem, Enum13.const_3), office2007ColorTable_0.LegacyColors);
	}

	private Office2007ButtonItemStateColorTable method_0(MDISystemItem mdisystemItem_0, Enum13 enum13_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = office2007ColorTable_0.ButtonItemColors[eButtonColor.Orange.ToString()];
		Office2007ButtonItemStateColorTable result = office2007ButtonItemColorTable.Default;
		if (mdisystemItem_0.Enum13_2 == enum13_0)
		{
			result = office2007ButtonItemColorTable.Pressed;
		}
		else if (mdisystemItem_0.Enum13_1 == enum13_0)
		{
			result = office2007ButtonItemColorTable.MouseOver;
		}
		return result;
	}

	private void method_1(Graphics graphics_0, MDISystemItem mdisystemItem_0, Enum13 enum13_0, Rectangle rectangle_0, Office2007ButtonItemStateColorTable office2007ButtonItemStateColorTable_0, ColorScheme colorScheme_0)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		Region clip = graphics_0.get_Clip();
		graphics_0.SetClip(rectangle_0);
		Class268.smethod_4(graphics_0, office2007ButtonItemStateColorTable_0, rectangle_0, RoundRectangleShapeDescriptor.RoundCorner2);
		rectangle_0.Inflate(-1, -1);
		rectangle_0.Offset(1, 0);
		Bitmap val = mdisystemItem_0.method_19(graphics_0, enum13_0, rectangle_0, colorScheme_0);
		try
		{
			if ((enum13_0 == Enum13.const_1 && !mdisystemItem_0.MinimizeEnabled) || (enum13_0 == Enum13.const_2 && !mdisystemItem_0.RestoreEnabled) || (enum13_0 == Enum13.const_3 && !mdisystemItem_0.CloseEnabled))
			{
				float[][] array = new float[5][];
				float[] array2 = (array[0] = new float[5]);
				float[] array3 = (array[1] = new float[5]);
				float[] array4 = (array[2] = new float[5]);
				array[3] = new float[5] { 0.5f, 0.5f, 0.5f, 0.5f, 0f };
				float[] array5 = (array[4] = new float[5]);
				ColorMatrix colorMatrix = new ColorMatrix(array);
				ImageAttributes val2 = new ImageAttributes();
				val2.ClearColorKey();
				val2.SetColorMatrix(colorMatrix);
				graphics_0.DrawImage((Image)(object)val, rectangle_0, 0, 0, ((Image)val).get_Width(), ((Image)val).get_Height(), (GraphicsUnit)2, val2);
			}
			else
			{
				if (enum13_0 == mdisystemItem_0.Enum13_2)
				{
					rectangle_0.Offset(1, 1);
				}
				graphics_0.DrawImageUnscaled((Image)(object)val, rectangle_0);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		graphics_0.set_Clip(clip);
	}
}
