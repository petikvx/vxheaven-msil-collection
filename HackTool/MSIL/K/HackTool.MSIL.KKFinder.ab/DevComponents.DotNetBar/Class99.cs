using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class99 : Class98, Interface3
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

	public override void PaintBackground(ItemContainerRendererEventArgs e)
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		if (e.ItemContainer.Style != eDotNetBarStyle.Office2007)
		{
			return;
		}
		ItemContainer itemContainer = e.ItemContainer;
		Office2007ItemGroupColorTable itemGroup = office2007ColorTable_0.ItemGroup;
		if (itemContainer.SubItems.Count == 0 || itemGroup == null)
		{
			return;
		}
		Rectangle displayRectangle = itemContainer.DisplayRectangle;
		if (itemContainer.BeginGroup && (!itemContainer.IsOnMenu || itemContainer.Parent is ItemContainer))
		{
			displayRectangle.Width -= itemContainer.BackgroundStyle.MarginHorizontal;
			displayRectangle.Height -= itemContainer.BackgroundStyle.MarginVertical;
			displayRectangle.X += itemContainer.BackgroundStyle.MarginLeft;
			displayRectangle.Y += itemContainer.BackgroundStyle.MarginTop;
			Graphics graphics = e.Graphics;
			int int_ = 2;
			if (itemGroup.OuterBorder != null && !itemGroup.OuterBorder.IsEmpty)
			{
				Class50.smethod_37(graphics, displayRectangle, itemGroup.OuterBorder, 1, int_);
			}
			if (itemGroup.InnerBorder != null && !itemGroup.InnerBorder.IsEmpty)
			{
				displayRectangle.Inflate(-1, -1);
				Class50.smethod_37(graphics, displayRectangle, itemGroup.InnerBorder, 1, int_);
			}
			float num = 0.4f;
			Rectangle rectangle_ = displayRectangle;
			rectangle_.Inflate(-1, -1);
			SmoothingMode smoothingMode = graphics.get_SmoothingMode();
			graphics.set_SmoothingMode((SmoothingMode)0);
			if (itemGroup.TopBackground != null && !itemGroup.TopBackground.IsEmpty)
			{
				Class50.smethod_25(graphics, rectangle_, itemGroup.TopBackground);
			}
			int num2 = (int)((float)rectangle_.Height * num);
			rectangle_.Height -= num2;
			rectangle_.Y += num2;
			if (itemGroup.BottomBackground != null && !itemGroup.BottomBackground.IsEmpty)
			{
				Class50.smethod_25(graphics, rectangle_, itemGroup.BottomBackground);
			}
			graphics.set_SmoothingMode(smoothingMode);
			bool flag = itemContainer.LayoutOrientation == eOrientation.Vertical;
			Pen val = new Pen(itemGroup.ItemGroupDividerLight, 1f);
			try
			{
				Pen val2 = new Pen(itemGroup.ItemGroupDividerDark);
				try
				{
					int num3 = itemContainer.SubItems.Count - 1;
					for (int i = 0; i <= num3; i++)
					{
						BaseItem baseItem = itemContainer.SubItems[i];
						if (baseItem.Visible && baseItem.DisplayRectangle.Right != itemContainer.DisplayRectangle.Right && i != num3)
						{
							if (flag)
							{
								graphics.DrawLine(val2, itemContainer.DisplayRectangle.X + 1, baseItem.DisplayRectangle.Bottom - 1, itemContainer.DisplayRectangle.Right - 1, baseItem.DisplayRectangle.Bottom - 1);
								graphics.DrawLine(val, itemContainer.DisplayRectangle.X + 1, baseItem.DisplayRectangle.Bottom, itemContainer.DisplayRectangle.Right, baseItem.DisplayRectangle.Bottom);
							}
							else
							{
								graphics.DrawLine(val2, baseItem.DisplayRectangle.Right - 1, baseItem.DisplayRectangle.Y + 1, baseItem.DisplayRectangle.Right - 1, baseItem.DisplayRectangle.Bottom - 2);
								graphics.DrawLine(val, baseItem.DisplayRectangle.Right, baseItem.DisplayRectangle.Y + 1, baseItem.DisplayRectangle.Right, baseItem.DisplayRectangle.Bottom - 2);
							}
						}
					}
					return;
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		if (itemContainer.BackgroundStyle.Class == ElementStyleClassKeys.Office2007StatusBarBackground2Key && e.itemPaintArgs_0 != null && e.itemPaintArgs_0.ContainerControl is Bar && ((Bar)(object)e.itemPaintArgs_0.ContainerControl).BarType == eBarType.StatusBar)
		{
			displayRectangle.Y = 1;
			displayRectangle.Height = e.itemPaintArgs_0.ContainerControl.get_Height() - 1;
			if (itemContainer.Parent.SubItems.IndexOf(itemContainer) == itemContainer.Parent.SubItems.Count - 1)
			{
				if (e.itemPaintArgs_0.RightToLeft)
				{
					displayRectangle.Width += displayRectangle.X;
					displayRectangle.X = 0;
				}
				else
				{
					displayRectangle.Width += e.itemPaintArgs_0.ContainerControl.get_Width() - displayRectangle.Right;
				}
			}
		}
		Region clip = e.Graphics.get_Clip();
		e.Graphics.SetClip(displayRectangle);
		ElementStyleDisplay.Paint(new ElementStyleDisplayInfo(itemContainer.BackgroundStyle, e.Graphics, displayRectangle));
		e.Graphics.set_Clip(clip);
	}

	public override void PaintItemSeparator(ItemContainerSeparatorRendererEventArgs e)
	{
		if (!(e.Item is ItemContainer))
		{
			Graphics graphics = e.Graphics;
			BaseItem item = e.Item;
			Size size = Size.Empty;
			if (item is ImageItem)
			{
				size = ((ImageItem)item).ImageSize;
			}
			ItemContainer itemContainer = e.ItemContainer;
			Color itemSeparator = office2007ColorTable_0.LegacyColors.ItemSeparator;
			Color itemSeparatorShade = office2007ColorTable_0.LegacyColors.ItemSeparatorShade;
			Point point_ = Point.Empty;
			Point point_2 = Point.Empty;
			Point empty = Point.Empty;
			Point empty2 = Point.Empty;
			if (itemContainer.LayoutOrientation == eOrientation.Horizontal)
			{
				point_ = new Point(item.DisplayRectangle.X - 2, item.DisplayRectangle.Y + 3);
				point_2 = new Point(point_.X, item.DisplayRectangle.Bottom - 4);
				empty = new Point(point_.X + 1, point_.Y);
				empty2 = new Point(point_2.X + 1, point_2.Y);
			}
			else if (item.IsOnMenu)
			{
				point_ = new Point(item.DisplayRectangle.X + size.Width, item.DisplayRectangle.Y - 2);
				point_2 = new Point(item.DisplayRectangle.Right - 1, point_.Y);
				empty = new Point(point_.X, point_.Y + 1);
				empty2 = new Point(point_2.X, point_2.Y + 1);
			}
			else
			{
				point_ = new Point(item.DisplayRectangle.X + 3, item.DisplayRectangle.Y - 2);
				point_2 = new Point(item.DisplayRectangle.Right - 4, point_.Y);
				empty = new Point(point_.X, point_.Y + 1);
				empty2 = new Point(point_2.X, point_2.Y + 1);
			}
			Class50.smethod_31(graphics, point_, point_2, itemSeparator, 1);
			Class50.smethod_31(graphics, empty, empty2, itemSeparatorShade, 1);
		}
	}
}
