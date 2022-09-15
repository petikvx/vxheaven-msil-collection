using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
public class ExplorerBarContainerItem : ImageItem, IDesignTimeProvider
{
	internal int int_4 = 15;

	internal bool bool_22;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DefaultValue(false)]
	public override bool Expanded
	{
		get
		{
			return base.Expanded;
		}
		set
		{
			if (!value)
			{
				foreach (BaseItem subItem in m_SubItems)
				{
					if (!(subItem is ExplorerBarGroupItem))
					{
						continue;
					}
					foreach (BaseItem subItem2 in subItem.SubItems)
					{
						if (subItem2 is PopupItem && subItem.Expanded)
						{
							subItem2.Expanded = false;
						}
					}
				}
			}
			base.Expanded = value;
		}
	}

	[Browsable(false)]
	public override eOrientation Orientation
	{
		get
		{
			return eOrientation.Horizontal;
		}
		set
		{
		}
	}

	public ExplorerBarContainerItem()
	{
		m_IsContainer = true;
		m_SystemItem = true;
		m_SupportedOrientation = eSupportedOrientation.Horizontal;
		m_AllowOnlyOneSubItemExpanded = false;
	}

	public override BaseItem Copy()
	{
		ExplorerBarContainerItem explorerBarContainerItem = new ExplorerBarContainerItem();
		CopyToItem(explorerBarContainerItem);
		return explorerBarContainerItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		ExplorerBarContainerItem objCopy = copy as ExplorerBarContainerItem;
		base.CopyToItem(objCopy);
	}

	public override void RecalcSize()
	{
		int num = m_Rect.Top;
		if (m_SubItems != null)
		{
			foreach (BaseItem subItem in m_SubItems)
			{
				if (subItem.Visible)
				{
					subItem.WidthInternal = WidthInternal;
					subItem.HeightInternal = 0;
					subItem.LeftInternal = m_Rect.Left;
					subItem.TopInternal = num;
					subItem.RecalcSize();
					if (subItem.WidthInternal != WidthInternal)
					{
						subItem.WidthInternal = WidthInternal;
					}
					num += subItem.HeightInternal + int_4;
					subItem.Displayed = true;
				}
			}
		}
		num = (HeightInternal = num - int_4);
		base.RecalcSize();
	}

	protected override void OnTopLocationChanged(int oldValue)
	{
		int num = m_Rect.Top - oldValue;
		if (m_SubItems == null)
		{
			return;
		}
		foreach (BaseItem subItem in m_SubItems)
		{
			if (subItem.Visible)
			{
				subItem.TopInternal += num;
			}
		}
	}

	public override void Paint(ItemPaintArgs pa)
	{
		if (SuspendLayout)
		{
			return;
		}
		if (m_NeedRecalcSize)
		{
			RecalcSize();
		}
		if (m_SubItems == null)
		{
			return;
		}
		foreach (BaseItem subItem in m_SubItems)
		{
			if (!subItem.Visible || !subItem.Displayed)
			{
				continue;
			}
			if (subItem is ExplorerBarGroupItem)
			{
				if (((ExplorerBarGroupItem)subItem).WordWrapSubItems)
				{
					pa.ButtonStringFormat &= ~(pa.ButtonStringFormat & eTextFormat.SingleLine);
					pa.ButtonStringFormat |= eTextFormat.WordBreak;
				}
				else
				{
					pa.ButtonStringFormat |= eTextFormat.SingleLine;
					pa.ButtonStringFormat &= ~(pa.ButtonStringFormat & eTextFormat.WordBreak);
				}
			}
			else
			{
				pa.ButtonStringFormat &= ~(pa.ButtonStringFormat & eTextFormat.SingleLine);
				pa.ButtonStringFormat |= eTextFormat.WordBreak;
			}
			subItem.Paint(pa);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		base.InternalMouseDown(objArg);
		if (DesignMode && ItemAtLocation(objArg.get_X(), objArg.get_Y()) == null && GetOwner() is IOwner owner)
		{
			owner.SetFocusItem(null);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalMouseUp(objArg);
		}
		else
		{
			base.InternalMouseUp(objArg);
		}
	}

	public bool FocusNextItem()
	{
		bool result = true;
		BaseItem focusItem = ((IOwner)GetOwner()).GetFocusItem();
		bool flag = false;
		if (focusItem == null)
		{
			flag = true;
		}
		for (int i = 0; i < 2; i++)
		{
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem == focusItem)
				{
					flag = true;
				}
				else if (subItem.Visible && flag)
				{
					((IOwner)GetOwner()).SetFocusItem(subItem);
					i = 2;
					result = false;
					break;
				}
				if (!subItem.Expanded || !subItem.Visible)
				{
					continue;
				}
				foreach (BaseItem subItem2 in subItem.SubItems)
				{
					if (subItem2 == focusItem)
					{
						flag = true;
					}
					else if (subItem.Visible && flag)
					{
						((IOwner)GetOwner()).SetFocusItem(subItem2);
						i = 2;
						result = false;
						break;
					}
				}
				if (i == 2)
				{
					break;
				}
			}
		}
		return result;
	}

	public bool FocusPreviousItem()
	{
		bool result = true;
		BaseItem focusItem = ((IOwner)GetOwner()).GetFocusItem();
		bool flag = false;
		if (focusItem == null)
		{
			flag = true;
		}
		for (int i = 0; i < 2; i++)
		{
			for (int num = SubItems.Count - 1; num >= 0; num--)
			{
				BaseItem baseItem = SubItems[num];
				if (baseItem.Expanded && baseItem.Visible)
				{
					for (int num2 = baseItem.SubItems.Count - 1; num2 >= 0; num2--)
					{
						BaseItem baseItem2 = baseItem.SubItems[num2];
						if (baseItem2 == focusItem)
						{
							flag = true;
						}
						else if (baseItem.Visible && flag)
						{
							((IOwner)GetOwner()).SetFocusItem(baseItem2);
							i = 2;
							result = false;
							break;
						}
					}
					if (i == 2)
					{
						break;
					}
				}
				if (baseItem == focusItem)
				{
					flag = true;
				}
				else if (baseItem.Visible && flag)
				{
					((IOwner)GetOwner()).SetFocusItem(baseItem);
					i = 2;
					result = false;
					break;
				}
			}
		}
		return result;
	}

	protected internal override void OnItemAdded(BaseItem item)
	{
		base.OnItemAdded(item);
		NeedRecalcSize = true;
		if (item is ExplorerBarGroupItem)
		{
			((ExplorerBarGroupItem)item).method_17();
		}
		if (DesignMode && ContainerControl is ExplorerBar explorerBar)
		{
			explorerBar.RecalcLayout();
		}
	}

	protected internal override void OnAfterItemRemoved(BaseItem item)
	{
		base.OnAfterItemRemoved(item);
		NeedRecalcSize = true;
		if (DesignMode && ContainerControl is ExplorerBar explorerBar)
		{
			explorerBar.RecalcLayout();
		}
	}

	protected internal override void OnSubItemsClear()
	{
		base.OnSubItemsClear();
		NeedRecalcSize = true;
		if (DesignMode && ContainerControl is ExplorerBar explorerBar)
		{
			explorerBar.RecalcLayout();
		}
	}

	protected internal override void OnSubItemExpandChange(BaseItem objChildItem)
	{
		base.OnSubItemExpandChange(objChildItem);
		ExplorerBar explorerBar = ContainerControl as ExplorerBar;
		try
		{
			if (explorerBar != null && explorerBar.AnimationEnabled)
			{
				TimeSpan timeSpan = new TimeSpan(0, 0, 0, 0, explorerBar.AnimationTime);
				bool_22 = true;
				int num = 1;
				DateTime now = DateTime.Now;
				if (objChildItem.Expanded)
				{
					int heightInternal = objChildItem.HeightInternal;
					objChildItem.RecalcSize();
					int heightInternal2 = objChildItem.HeightInternal;
					for (int i = heightInternal; i < heightInternal2; i += num)
					{
						DateTime now2 = DateTime.Now;
						objChildItem.HeightInternal = i;
						foreach (BaseItem subItem in objChildItem.SubItems)
						{
							if (!objChildItem.DisplayRectangle.Contains(subItem.DisplayRectangle))
							{
								subItem.Displayed = false;
							}
							else
							{
								subItem.Displayed = true;
							}
						}
						for (int j = SubItems.IndexOf(objChildItem) + 1; j < SubItems.Count; j++)
						{
							SubItems[j].TopInternal += num;
						}
						((Control)explorerBar).Refresh();
						TimeSpan timeSpan2 = DateTime.Now - now2;
						TimeSpan timeSpan3 = DateTime.Now - now;
						int num2 = (int)(timeSpan - timeSpan3).TotalMilliseconds;
						if (num2 <= 0)
						{
							num = heightInternal2 - i;
						}
						else if (num2 == 0)
						{
							num = 1;
						}
						else
						{
							num = (heightInternal2 - i) * (int)timeSpan2.TotalMilliseconds / num2;
							if (num <= 0)
							{
								num = 1;
							}
						}
						if (num <= 0)
						{
							num = heightInternal2 - i;
						}
					}
				}
				else
				{
					int heightInternal3 = objChildItem.HeightInternal;
					objChildItem.RecalcSize();
					int heightInternal4 = objChildItem.HeightInternal;
					for (int num3 = heightInternal3; num3 > heightInternal4; num3 -= num)
					{
						DateTime now3 = DateTime.Now;
						objChildItem.HeightInternal = num3;
						foreach (BaseItem subItem2 in objChildItem.SubItems)
						{
							if (!objChildItem.DisplayRectangle.Contains(subItem2.DisplayRectangle))
							{
								subItem2.Displayed = false;
							}
							else
							{
								subItem2.Displayed = true;
							}
						}
						for (int k = SubItems.IndexOf(objChildItem) + 1; k < SubItems.Count; k++)
						{
							SubItems[k].TopInternal -= num;
						}
						((Control)explorerBar).Refresh();
						TimeSpan timeSpan4 = DateTime.Now - now3;
						TimeSpan timeSpan5 = DateTime.Now - now;
						if ((timeSpan - timeSpan5).TotalMilliseconds <= 0.0)
						{
							num = num3 - heightInternal4;
						}
						else if ((timeSpan - timeSpan5).TotalMilliseconds == 0.0)
						{
							num = 1;
						}
						else
						{
							num = (num3 - heightInternal4) * (int)timeSpan4.TotalMilliseconds / Math.Max(1, (int)(timeSpan - timeSpan5).TotalMilliseconds);
							if (num <= 0)
							{
								num = 1;
							}
						}
						if (num <= 0)
						{
							num = num3 - heightInternal4;
						}
					}
				}
			}
		}
		finally
		{
			bool_22 = false;
		}
		explorerBar?.RecalcLayout();
	}

	InsertPosition IDesignTimeProvider.GetInsertPosition(Point pScreen, BaseItem DragItem)
	{
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem.Visible && subItem is IDesignTimeProvider)
			{
				InsertPosition insertPosition = ((IDesignTimeProvider)subItem).GetInsertPosition(pScreen, DragItem);
				if (insertPosition != null)
				{
					return insertPosition;
				}
			}
		}
		return null;
	}

	void IDesignTimeProvider.DrawReversibleMarker(int iPos, bool Before)
	{
	}

	void IDesignTimeProvider.InsertItemAt(BaseItem objItem, int iPos, bool Before)
	{
	}
}
