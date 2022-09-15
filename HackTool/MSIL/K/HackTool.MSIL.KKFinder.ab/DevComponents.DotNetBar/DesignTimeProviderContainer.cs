using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class DesignTimeProviderContainer
{
	public static InsertPosition GetInsertPosition(BaseItem containerItem, Point pScreen, BaseItem DragItem)
	{
		InsertPosition insertPosition = null;
		Control val = null;
		val = (Control)((!(containerItem is PopupItem) || !containerItem.Expanded) ? ((object)/*isinst with value type is only supported in some contexts*/) : ((object)((PopupItem)containerItem).PopupControl));
		if (val == null)
		{
			return null;
		}
		Point pt = val.PointToClient(pScreen);
		Rectangle displayRectangle = containerItem.DisplayRectangle;
		if (containerItem is PopupItem && containerItem.Expanded)
		{
			displayRectangle = val.get_DisplayRectangle();
		}
		if (!displayRectangle.Contains(pt) && (containerItem.SubItems.Count != 0 || !val.get_ClientRectangle().Contains(pt)) && (!(containerItem is ItemContainer) || !((ItemContainer)containerItem).SystemContainer || !val.get_ClientRectangle().Contains(pt)))
		{
			foreach (BaseItem subItem in containerItem.SubItems)
			{
				if (subItem != DragItem && subItem is IDesignTimeProvider designTimeProvider)
				{
					insertPosition = designTimeProvider.GetInsertPosition(pScreen, DragItem);
					if (insertPosition != null)
					{
						return insertPosition;
					}
				}
			}
			return insertPosition;
		}
		BaseItem baseItem2 = containerItem.ExpandedItem();
		if (baseItem2 != null && baseItem2 is IDesignTimeProvider designTimeProvider2)
		{
			insertPosition = designTimeProvider2.GetInsertPosition(pScreen, DragItem);
			if (insertPosition != null)
			{
				return insertPosition;
			}
		}
		for (int i = 0; i < containerItem.SubItems.Count; i++)
		{
			baseItem2 = containerItem.SubItems[i];
			Rectangle displayRectangle2 = baseItem2.DisplayRectangle;
			displayRectangle2.Inflate(2, 2);
			if (!baseItem2.Visible || !displayRectangle2.Contains(pt))
			{
				continue;
			}
			if (baseItem2.SystemItem && containerItem.SubItems.Count != 1)
			{
				return null;
			}
			if (baseItem2 == DragItem)
			{
				return new InsertPosition();
			}
			if (baseItem2.IsContainer && baseItem2 is IDesignTimeProvider)
			{
				Rectangle rectangle = displayRectangle2;
				rectangle.Inflate(-8, -8);
				if (rectangle.Contains(pt))
				{
					return ((IDesignTimeProvider)baseItem2).GetInsertPosition(pScreen, DragItem);
				}
			}
			insertPosition = new InsertPosition();
			insertPosition.TargetProvider = (IDesignTimeProvider)containerItem;
			insertPosition.Position = i;
			if (baseItem2.Orientation == eOrientation.Horizontal && !baseItem2.IsOnMenu)
			{
				if (pt.X <= baseItem2.LeftInternal + baseItem2.WidthInternal / 2 || baseItem2.SystemItem)
				{
					insertPosition.Before = true;
				}
			}
			else if (pt.Y <= baseItem2.TopInternal + baseItem2.HeightInternal / 2 || baseItem2.SystemItem)
			{
				insertPosition.Before = true;
			}
			if (containerItem.GetOwner() is IOwner owner)
			{
				BaseItem baseItem3 = owner.GetExpandedItem();
				if (baseItem3 != null)
				{
					while (baseItem3.Parent != null)
					{
						baseItem3 = baseItem3.Parent;
					}
					BaseItem baseItem4 = baseItem2;
					while (baseItem4.Parent != null)
					{
						baseItem4 = baseItem4.Parent;
					}
					if (baseItem3 != baseItem4)
					{
						owner.SetExpandedItem(null);
					}
				}
			}
			if (baseItem2 is PopupItem && (baseItem2.SubItems.Count > 0 || baseItem2.IsOnMenuBar))
			{
				if (!baseItem2.Expanded && baseItem2.CanCustomize)
				{
					baseItem2.Expanded = true;
				}
			}
			else
			{
				BaseItem.CollapseSubItems(containerItem);
			}
			break;
		}
		if (insertPosition == null)
		{
			insertPosition = ((containerItem.SubItems.Count <= 1 || !containerItem.SubItems[containerItem.SubItems.Count - 1].SystemItem) ? new InsertPosition(containerItem.SubItems.Count - 1, bBefore: false, (IDesignTimeProvider)containerItem) : new InsertPosition(containerItem.SubItems.Count - 2, bBefore: true, (IDesignTimeProvider)containerItem));
		}
		return insertPosition;
	}

	public static void DrawReversibleMarker(BaseItem containerItem, int iPos, bool Before)
	{
		object containerControl = containerItem.ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val == null)
		{
			return;
		}
		BaseItem baseItem = null;
		if (iPos >= 0)
		{
			baseItem = containerItem.SubItems[iPos];
		}
		if (baseItem != null)
		{
			if (baseItem.Enum9_0 != 0)
			{
				baseItem.Enum9_0 = Enum9.const_0;
			}
			else if (Before)
			{
				baseItem.Enum9_0 = Enum9.const_1;
			}
			else
			{
				baseItem.Enum9_0 = Enum9.const_2;
			}
		}
		else
		{
			Rectangle displayRectangle = containerItem.DisplayRectangle;
			displayRectangle.Inflate(-1, -1);
			new Rectangle(displayRectangle.Left + 2, displayRectangle.Top + 2, 1, displayRectangle.Height - 4);
			new Rectangle(displayRectangle.Left, displayRectangle.Top + 1, 5, 1);
			new Rectangle(displayRectangle.Left, displayRectangle.Bottom - 2, 5, 1);
		}
	}

	public static void InsertItemAt(BaseItem containerItem, BaseItem objItem, int iPos, bool Before)
	{
		if (containerItem.ExpandedItem() != null)
		{
			containerItem.ExpandedItem().Expanded = false;
		}
		if (!Before)
		{
			if (iPos + 1 >= containerItem.SubItems.Count)
			{
				containerItem.SubItems.Add(objItem, GetAppendPosition(containerItem));
			}
			else
			{
				containerItem.SubItems.Add(objItem, iPos + 1);
			}
		}
		else if (iPos >= containerItem.SubItems.Count)
		{
			containerItem.SubItems.Add(objItem, GetAppendPosition(containerItem));
		}
		else
		{
			containerItem.SubItems.Add(objItem, iPos);
		}
		if (containerItem.ContainerControl is Bar)
		{
			((Bar)containerItem.ContainerControl).RecalcLayout();
			return;
		}
		if (containerItem.ContainerControl is MenuPanel)
		{
			((MenuPanel)containerItem.ContainerControl).RecalcSize();
			return;
		}
		if (containerItem.ContainerControl is BarBaseControl)
		{
			((BarBaseControl)containerItem.ContainerControl).RecalcLayout();
			return;
		}
		if (containerItem.ContainerControl is ItemControl)
		{
			((ItemControl)containerItem.ContainerControl).RecalcLayout();
			return;
		}
		containerItem.RecalcSize();
		containerItem.Refresh();
	}

	public static int GetAppendPosition(BaseItem objParent)
	{
		int result = -1;
		int num = objParent.SubItems.Count - 1;
		while (num >= 0 && objParent.SubItems[num].SystemItem)
		{
			result = num;
			num--;
		}
		return result;
	}
}
