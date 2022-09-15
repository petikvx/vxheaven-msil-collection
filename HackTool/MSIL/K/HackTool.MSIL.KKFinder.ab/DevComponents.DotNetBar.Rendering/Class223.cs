using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar.Rendering;

internal class Class223 : Class222, Interface3
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

	public override void Paint(ProgressBarItemRenderEventArgs e)
	{
		Rectangle displayRectangle = e.ProgressBarItem.DisplayRectangle;
		if (displayRectangle.Width <= 0 || displayRectangle.Height <= 0)
		{
			return;
		}
		ProgressBarItem progressBarItem = e.ProgressBarItem;
		Office2007ProgressBarColorTable office2007ProgressBarColorTable = office2007ColorTable_0.ProgressBarItem;
		if (progressBarItem.ColorTable == eProgressBarItemColor.Paused)
		{
			office2007ProgressBarColorTable = office2007ColorTable_0.ProgressBarItemPaused;
		}
		else if (progressBarItem.ColorTable == eProgressBarItemColor.Error)
		{
			office2007ProgressBarColorTable = office2007ColorTable_0.ProgressBarItemError;
		}
		Graphics graphics = e.Graphics;
		Class50.smethod_9(graphics, office2007ProgressBarColorTable.OuterBorder, displayRectangle, 2);
		displayRectangle.Inflate(-1, -1);
		Brush val = Class50.smethod_45(displayRectangle, office2007ProgressBarColorTable.BackgroundColors);
		if (val != null)
		{
			graphics.FillRectangle(val, displayRectangle);
			val.Dispose();
		}
		Class50.smethod_9(graphics, office2007ProgressBarColorTable.InnerBorder, displayRectangle, 2);
		displayRectangle.Inflate(-1, -1);
		Region clip = graphics.get_Clip();
		try
		{
			graphics.SetClip(displayRectangle, (CombineMode)1);
			Rectangle rectangle = displayRectangle;
			if (progressBarItem.ProgressType == eProgressItemType.Marquee)
			{
				if (progressBarItem.Orientation == eOrientation.Horizontal)
				{
					rectangle.Width = (int)((double)rectangle.Width * 0.3);
					rectangle.X += displayRectangle.Width * progressBarItem.Int32_1 / 100 - rectangle.Width / 2;
				}
				else if (progressBarItem.Orientation == eOrientation.Vertical)
				{
					rectangle.Height = (int)((double)rectangle.Height * 0.3);
					rectangle.Y += displayRectangle.Height * progressBarItem.Int32_1 / 100 - rectangle.Height / 2;
				}
			}
			else if (progressBarItem.Orientation == eOrientation.Horizontal)
			{
				rectangle.Width = (int)((float)rectangle.Width * ((float)(progressBarItem.Value - progressBarItem.Minimum) / (float)(progressBarItem.Maximum - progressBarItem.Minimum)));
			}
			else if (progressBarItem.Orientation == eOrientation.Vertical)
			{
				int num = (int)((float)rectangle.Height * ((float)(progressBarItem.Value - progressBarItem.Minimum) / (float)(progressBarItem.Maximum - progressBarItem.Minimum)));
				rectangle.Y = rectangle.Bottom - num;
				rectangle.Height = num;
			}
			if (rectangle.Width <= 0 || rectangle.Height <= 0)
			{
				return;
			}
			val = Class50.smethod_45(rectangle, office2007ProgressBarColorTable.Chunk);
			if (val != null)
			{
				graphics.FillRectangle(val, rectangle);
				val.Dispose();
			}
			GradientColorTable chunkOverlay = office2007ProgressBarColorTable.ChunkOverlay;
			if (progressBarItem.Orientation == eOrientation.Horizontal)
			{
				chunkOverlay.LinearGradientAngle = 90;
			}
			else
			{
				chunkOverlay.LinearGradientAngle = 0;
			}
			val = Class50.smethod_45(rectangle, chunkOverlay);
			if (val != null)
			{
				graphics.FillRectangle(val, rectangle);
				if (progressBarItem.ProgressType == eProgressItemType.Marquee)
				{
					if (progressBarItem.Orientation == eOrientation.Horizontal && rectangle.Right > displayRectangle.Right + 4)
					{
						rectangle = new Rectangle(displayRectangle.X, displayRectangle.Y, rectangle.Right - displayRectangle.Right - 4, displayRectangle.Height);
					}
					else if (progressBarItem.Orientation == eOrientation.Vertical && rectangle.Bottom > displayRectangle.Bottom + 4)
					{
						rectangle = new Rectangle(displayRectangle.X, displayRectangle.Y, displayRectangle.Height, rectangle.Bottom - displayRectangle.Bottom - 4);
					}
					graphics.FillRectangle(val, rectangle);
				}
				val.Dispose();
			}
			if (progressBarItem.Orientation == eOrientation.Horizontal && rectangle.Right + 4 <= displayRectangle.Right)
			{
				rectangle.X = rectangle.Right;
				rectangle.Width = 4;
				val = Class50.smethod_45(rectangle, office2007ProgressBarColorTable.ChunkShadow);
				if (val != null)
				{
					graphics.FillRectangle(val, rectangle);
					val.Dispose();
				}
			}
			else if (progressBarItem.Orientation == eOrientation.Vertical && rectangle.Y - 3 >= displayRectangle.Y)
			{
				rectangle.Y -= 3;
				rectangle.Height = 3;
				val = Class50.smethod_46(rectangle, office2007ProgressBarColorTable.ChunkShadow.Colors, office2007ProgressBarColorTable.ChunkShadow.LinearGradientAngle - 90, office2007ProgressBarColorTable.ChunkShadow.GradientType);
				if (val != null)
				{
					graphics.FillRectangle(val, rectangle);
					val.Dispose();
				}
			}
		}
		finally
		{
			graphics.set_Clip(clip);
		}
	}
}
