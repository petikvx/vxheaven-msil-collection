using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class105
{
	private static int int_0 = 3;

	public static void smethod_0(BubbleButtonDisplayInfo bubbleButtonDisplayInfo_0)
	{
		if (!bubbleButtonDisplayInfo_0.Button.Visible)
		{
			return;
		}
		Class271 @class = null;
		Rectangle empty = Rectangle.Empty;
		if (bubbleButtonDisplayInfo_0.Magnified)
		{
			empty = bubbleButtonDisplayInfo_0.Button.MagnifiedDisplayRectangle;
			@class = smethod_1(bubbleButtonDisplayInfo_0.Button, empty.Size);
		}
		else
		{
			empty = bubbleButtonDisplayInfo_0.Button.DisplayRectangle;
			@class = smethod_1(bubbleButtonDisplayInfo_0.Button, empty.Size);
		}
		if (empty.Width < 2 || empty.Height < 2)
		{
			return;
		}
		if (@class != null)
		{
			if (!bubbleButtonDisplayInfo_0.Button.Enabled)
			{
				@class.method_2(bubbleButtonDisplayInfo_0.Graphics, empty, 0, 0, @class.Int32_3, @class.Int32_2, (GraphicsUnit)2, smethod_4());
			}
			else if (bubbleButtonDisplayInfo_0.Button.MouseDown)
			{
				@class.method_2(bubbleButtonDisplayInfo_0.Graphics, empty, 0, 0, @class.Int32_3, @class.Int32_2, (GraphicsUnit)2, smethod_3());
			}
			else
			{
				@class.method_0(bubbleButtonDisplayInfo_0.Graphics, empty);
			}
		}
		else
		{
			bubbleButtonDisplayInfo_0.Graphics.DrawRectangle(SystemPens.get_Highlight(), empty);
		}
		if (bubbleButtonDisplayInfo_0.Button.Focus)
		{
			empty.Inflate(1, 1);
			Class32.smethod_0(bubbleButtonDisplayInfo_0.Graphics, empty, Color.Navy);
		}
		smethod_2(bubbleButtonDisplayInfo_0);
	}

	public static Class271 smethod_1(BubbleButton bubbleButton_0, Size size_0)
	{
		Class271 result = null;
		if (bubbleButton_0.Image != null)
		{
			result = ((bubbleButton_0.Image.get_Size() == size_0 || bubbleButton_0.ImageLarge == null) ? new Class271(bubbleButton_0.Image, dispose: false, size_0) : ((bubbleButton_0.ImageLarge == null || (!(bubbleButton_0.ImageLarge.get_Size() == size_0) && bubbleButton_0.ImageLarge.get_Size().Height / size_0.Height >= 2)) ? new Class271(bubbleButton_0.Image, dispose: false, size_0) : new Class271(bubbleButton_0.ImageLarge, dispose: false, size_0)));
		}
		else if (bubbleButton_0.ImageCached != null)
		{
			result = ((bubbleButton_0.ImageCached.get_Size() == size_0 || bubbleButton_0.ImageLargeCached == null) ? new Class271(bubbleButton_0.ImageCached, dispose: false, size_0) : ((bubbleButton_0.ImageLargeCached == null || bubbleButton_0.ImageLargeCached.get_Size().Height / size_0.Height > 2) ? new Class271(bubbleButton_0.ImageCached, dispose: false, size_0) : new Class271(bubbleButton_0.ImageLargeCached, dispose: false, size_0)));
		}
		return result;
	}

	private static void smethod_2(BubbleButtonDisplayInfo bubbleButtonDisplayInfo_0)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected I4, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected I4, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		if (bubbleButtonDisplayInfo_0.Button.MouseOver && bubbleButtonDisplayInfo_0.BubbleBar.ShowTooltips && bubbleButtonDisplayInfo_0.Button.TooltipText != "")
		{
			Color tooltipTextColor = bubbleButtonDisplayInfo_0.BubbleBar.TooltipTextColor;
			Color tooltipOutlineColor = bubbleButtonDisplayInfo_0.BubbleBar.TooltipOutlineColor;
			StringFormat val = Class55.smethod_11(eTextFormat.Default);
			bubbleButtonDisplayInfo_0.Graphics.set_CompositingMode((CompositingMode)0);
			CompositingMode compositingMode = (CompositingMode)0;
			Font val2 = bubbleButtonDisplayInfo_0.BubbleBar.TooltipFont;
			if (val2 == null)
			{
				val2 = ((Control)bubbleButtonDisplayInfo_0.BubbleBar).get_Font();
			}
			Rectangle rectangle = bubbleButtonDisplayInfo_0.Button.DisplayRectangle;
			Size size = Class55.smethod_3(bubbleButtonDisplayInfo_0.Graphics, bubbleButtonDisplayInfo_0.Button.TooltipText, val2);
			if (bubbleButtonDisplayInfo_0.Magnified)
			{
				rectangle = bubbleButtonDisplayInfo_0.Button.MagnifiedDisplayRectangle;
			}
			if (bubbleButtonDisplayInfo_0.Alignment == eBubbleButtonAlignment.Bottom)
			{
				rectangle.Y -= Math.Max(val2.get_Height(), size.Height) + int_0;
			}
			else
			{
				rectangle.Y = rectangle.Bottom + int_0;
			}
			rectangle.Offset(-(size.Width - rectangle.Width) / 2, 0);
			Point location = rectangle.Location;
			location.Offset(-1, 0);
			GraphicsPath val3 = new GraphicsPath();
			val3.AddString(bubbleButtonDisplayInfo_0.Button.TooltipText, val2.get_FontFamily(), (int)val2.get_Style(), val2.get_SizeInPoints(), new PointF((float)((location.X + 1) * 72) / bubbleButtonDisplayInfo_0.Graphics.get_DpiX(), (float)((location.Y - 1) * 72) / bubbleButtonDisplayInfo_0.Graphics.get_DpiY()), val);
			Pen val4 = new Pen(tooltipOutlineColor, (float)((val2.get_SizeInPoints() >= 10f) ? 1 : 1));
			try
			{
				val3.Widen(val4);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
			SolidBrush val5 = new SolidBrush(Color.FromArgb(200, tooltipOutlineColor));
			try
			{
				GraphicsUnit pageUnit = bubbleButtonDisplayInfo_0.Graphics.get_PageUnit();
				bubbleButtonDisplayInfo_0.Graphics.set_PageUnit((GraphicsUnit)3);
				bubbleButtonDisplayInfo_0.Graphics.FillPath((Brush)(object)val5, val3);
				bubbleButtonDisplayInfo_0.Graphics.set_PageUnit(pageUnit);
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
			val3.Dispose();
			val3 = new GraphicsPath();
			val3.AddString(bubbleButtonDisplayInfo_0.Button.TooltipText, val2.get_FontFamily(), (int)val2.get_Style(), val2.get_SizeInPoints(), new PointF((float)(location.X * 72) / bubbleButtonDisplayInfo_0.Graphics.get_DpiX(), (float)(location.Y * 72) / bubbleButtonDisplayInfo_0.Graphics.get_DpiY()), val);
			val3.Widen(SystemPens.get_ControlText());
			SolidBrush val6 = new SolidBrush(Color.FromArgb(200, tooltipOutlineColor));
			try
			{
				GraphicsUnit pageUnit2 = bubbleButtonDisplayInfo_0.Graphics.get_PageUnit();
				bubbleButtonDisplayInfo_0.Graphics.set_PageUnit((GraphicsUnit)3);
				bubbleButtonDisplayInfo_0.Graphics.FillPath((Brush)(object)val6, val3);
				bubbleButtonDisplayInfo_0.Graphics.set_PageUnit(pageUnit2);
			}
			finally
			{
				((IDisposable)val6)?.Dispose();
			}
			val3.Dispose();
			Class55.smethod_0(bubbleButtonDisplayInfo_0.Graphics, bubbleButtonDisplayInfo_0.Button.TooltipText, val2, tooltipTextColor, rectangle.X, rectangle.Y, eTextFormat.Default);
			bubbleButtonDisplayInfo_0.Graphics.set_CompositingMode(compositingMode);
			val.Dispose();
		}
	}

	private static ImageAttributes smethod_3()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		ColorMatrix colorMatrix = new ColorMatrix(new float[5][]
		{
			new float[5] { 0.65f, 0f, 0f, 0f, 0f },
			new float[5] { 0f, 0.65f, 0f, 0f, 0f },
			new float[5] { 0f, 0f, 0.65f, 0f, 0f },
			new float[5] { 0f, 0f, 0f, 1f, 0f },
			new float[5] { 0f, 0f, 0f, 0f, 0.65f }
		});
		ImageAttributes val = new ImageAttributes();
		val.ClearColorKey();
		val.SetColorMatrix(colorMatrix);
		return val;
	}

	private static ImageAttributes smethod_4()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		float[][] array = new float[5][]
		{
			new float[5] { 0.5f, 0.5f, 0.5f, 0f, 0f },
			new float[5] { 0.5f, 0.5f, 0.5f, 0f, 0f },
			new float[5] { 0.5f, 0.5f, 0.5f, 0f, 0f },
			new float[5] { 0f, 0f, 0f, 1f, 0f },
			new float[5] { 0f, 0f, 0f, 0f, 1f }
		};
		ColorMatrix val = new ColorMatrix();
		val.set_Matrix00(1f / 3f);
		val.set_Matrix01(1f / 3f);
		val.set_Matrix02(1f / 3f);
		val.set_Matrix10(1f / 3f);
		val.set_Matrix11(1f / 3f);
		val.set_Matrix12(1f / 3f);
		val.set_Matrix20(1f / 3f);
		val.set_Matrix21(1f / 3f);
		val.set_Matrix22(1f / 3f);
		val.set_Matrix33(0.5f);
		ImageAttributes val2 = new ImageAttributes();
		val2.ClearColorKey();
		val2.SetColorMatrix(val);
		return val2;
	}
}
