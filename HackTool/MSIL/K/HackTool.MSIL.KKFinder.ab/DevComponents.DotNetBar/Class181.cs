using System.Drawing;
using DevComponents.DotNetBar.Ribbon;

namespace DevComponents.DotNetBar;

internal class Class181 : GenericItemContainer
{
	private int int_9 = 40;

	private int int_10;

	private CustomizeItem customizeItem_0;

	private int int_11;

	internal int Int32_4 => int_11;

	public Class181()
	{
		FirstItemSpacing = 3;
		base.EContainerVerticalAlignment_0 = eContainerVerticalAlignment.Top;
	}

	public override void RecalcSize()
	{
		if (m_MoreItems != null && m_MoreItems.Expanded)
		{
			m_MoreItems.Expanded = false;
		}
		m_RecalculatingSize = true;
		int num = int_9;
		if (ContainerControl is Control7)
		{
			num = 0;
		}
		int count = SubItems.Count;
		int num2 = -1;
		int num3 = 0;
		int num4 = 0;
		int heightInternal = 22;
		bool flag = false;
		for (int i = 0; i < count; i++)
		{
			BaseItem baseItem = SubItems[i];
			if (baseItem.Visible)
			{
				baseItem.RecalcSize();
				baseItem.Displayed = true;
				num += baseItem.WidthInternal + ((i == 0) ? FirstItemSpacing : m_ItemSpacing);
				if (baseItem.ItemAlignment == eItemAlignment.Far && num2 == -1)
				{
					num2 = i;
				}
				if (num2 == -1)
				{
					heightInternal = baseItem.HeightInternal;
				}
				if (baseItem.HeightInternal > num3)
				{
					num3 = baseItem.HeightInternal;
				}
				if (baseItem.HeightInternal > num4 && !(baseItem is Office2007StartButton) && !(baseItem is SystemCaptionItem))
				{
					num4 = baseItem.HeightInternal;
				}
				if (baseItem is QatCustomizeItem || baseItem is QatOverflowItem)
				{
					flag = true;
				}
			}
		}
		if (flag)
		{
			num += num3 / 2;
		}
		if (num < WidthInternal)
		{
			int_11 = num4;
			m_RecalculatingSize = false;
			base.RecalcSize();
			return;
		}
		if (num2 == -1)
		{
			num2 = SubItems.Count;
		}
		for (int num5 = num2 - 1; num5 >= 0; num5--)
		{
			BaseItem baseItem2 = SubItems[num5];
			if (baseItem2.Visible)
			{
				num -= baseItem2.WidthInternal;
				baseItem2.Displayed = false;
				if (num + DisplayMoreItem.FixedSize + num3 / 2 < WidthInternal)
				{
					break;
				}
			}
		}
		int num6 = LeftInternal + m_PaddingLeft;
		int y = TopInternal + m_PaddingTop;
		int num7 = count;
		if (num2 >= 0)
		{
			num7 = num2 - 1;
		}
		bool flag2 = false;
		for (int j = 0; j < num7; j++)
		{
			BaseItem baseItem3 = SubItems[j];
			if (baseItem3.Visible && baseItem3.Displayed)
			{
				flag2 = true;
				Rectangle bounds = new Rectangle(num6, y, baseItem3.WidthInternal, baseItem3.HeightInternal);
				if (!(baseItem3 is Office2007StartButton) && !(baseItem3 is SystemCaptionItem))
				{
					bounds.Y += (num4 - baseItem3.HeightInternal) / 2;
				}
				baseItem3.Bounds = bounds;
				num6 += baseItem3.WidthInternal + ((j == 0) ? FirstItemSpacing : m_ItemSpacing);
			}
		}
		int_10 = num6 + num3 / 2;
		if (num2 >= 0)
		{
			num6 = DisplayRectangle.Right - m_PaddingRight;
			for (int num8 = count - 1; num8 >= num2; num8--)
			{
				BaseItem baseItem4 = SubItems[num8];
				if (baseItem4.Visible && baseItem4.Displayed)
				{
					num6 -= baseItem4.WidthInternal;
					baseItem4.Bounds = new Rectangle(num6, y, baseItem4.WidthInternal, baseItem4.HeightInternal);
					num6 -= m_ItemSpacing;
				}
			}
		}
		m_Rect.Height = num3 + m_PaddingTop + m_PaddingBottom;
		if (flag2)
		{
			CreateMoreItemsButton(IsRightToLeft);
			m_MoreItems.HeightInternal = heightInternal;
			m_MoreItems.RecalcSize();
		}
		else if (m_MoreItems != null)
		{
			m_MoreItems.Dispose();
			m_MoreItems = null;
		}
		m_NeedRecalcSize = false;
		m_RecalculatingSize = false;
	}

	protected override int GetItemLayoutWidth(BaseItem objItem)
	{
		if (!(objItem is QatCustomizeItem) && !(objItem is QatOverflowItem))
		{
			return base.GetItemLayoutWidth(objItem);
		}
		return objItem.WidthInternal + HeightInternal / 2;
	}

	protected override int GetItemLayoutX(BaseItem objItem, int iX)
	{
		if (!(objItem is QatCustomizeItem) && !(objItem is QatOverflowItem))
		{
			return base.GetItemLayoutX(objItem, iX);
		}
		return iX + HeightInternal / 2;
	}

	protected override int GetItemLayoutY(BaseItem objItem, int iY)
	{
		if (!(objItem is Office2007StartButton) && !(objItem is SystemCaptionItem))
		{
			return iY + (int_11 - objItem.HeightInternal) / 2;
		}
		return base.GetItemLayoutY(objItem, iY);
	}

	protected override Point GetMoreItemsLocation(bool isRightToLeft)
	{
		if (m_MoreItems == null)
		{
			return Point.Empty;
		}
		Point empty = Point.Empty;
		if (m_Orientation == eOrientation.Vertical)
		{
			empty.X = m_Rect.Left + m_PaddingLeft;
			empty.Y = int_10;
		}
		else
		{
			if (isRightToLeft)
			{
				empty.X = m_Rect.X + m_PaddingLeft;
			}
			else
			{
				empty.X = int_10;
			}
			empty.Y = m_Rect.Top + m_PaddingTop;
		}
		return empty;
	}

	protected override void CreateMoreItemsButton(bool isRightToLeft)
	{
		if (m_MoreItems == null)
		{
			m_MoreItems = new QatOverflowItem();
			m_MoreItems.Style = m_Style;
			m_MoreItems.SetParent(this);
			m_MoreItems.ThemeAware = ThemeAware;
		}
		if (base.MoreItemsOnMenu)
		{
			m_MoreItems.PopupType = ePopupType.Menu;
		}
		else
		{
			m_MoreItems.PopupType = ePopupType.ToolBar;
		}
		m_MoreItems.Orientation = m_Orientation;
		m_MoreItems.Displayed = true;
		if (m_Orientation == eOrientation.Vertical)
		{
			m_MoreItems.WidthInternal = m_Rect.Width - (m_PaddingLeft + m_PaddingRight);
			m_MoreItems.RecalcSize();
		}
		else
		{
			m_MoreItems.HeightInternal = m_Rect.Height - (m_PaddingTop + m_PaddingBottom);
			m_MoreItems.RecalcSize();
		}
		Point moreItemsLocation = GetMoreItemsLocation(isRightToLeft);
		m_MoreItems.LeftInternal = moreItemsLocation.X;
		m_MoreItems.TopInternal = moreItemsLocation.Y;
	}

	protected internal override void OnItemAdded(BaseItem objItem)
	{
		base.OnItemAdded(objItem);
		if (objItem is CustomizeItem)
		{
			customizeItem_0 = (CustomizeItem)objItem;
		}
		else
		{
			if (customizeItem_0 == null)
			{
				return;
			}
			bool flag = false;
			if (SubItems.Contains(customizeItem_0))
			{
				SubItems.method_3(customizeItem_0);
			}
			int num = SubItems.Count - 1;
			while (num > 0)
			{
				if (SubItems[num].ItemAlignment != 0 || SubItems[num] is SystemCaptionItem)
				{
					num--;
					continue;
				}
				SubItems.method_1(customizeItem_0, num + 1);
				flag = true;
				break;
			}
			if (!flag)
			{
				SubItems.method_0(customizeItem_0);
			}
		}
	}

	protected internal override void OnAfterItemRemoved(BaseItem objItem)
	{
		if (objItem == customizeItem_0)
		{
			customizeItem_0 = null;
		}
		base.OnAfterItemRemoved(objItem);
	}
}
