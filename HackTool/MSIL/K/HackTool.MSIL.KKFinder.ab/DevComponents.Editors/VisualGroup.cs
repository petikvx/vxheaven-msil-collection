using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevComponents.Editors;

public class VisualGroup : VisualItem
{
	private VisualItem visualItem_0;

	private VisualItem visualItem_1;

	private VisualItemCollection visualItemCollection_0;

	private VisualItem visualItem_2;

	private int int_0;

	private bool bool_6;

	private eVerticalAlignment eVerticalAlignment_0 = eVerticalAlignment.Middle;

	private eHorizontalAlignment eHorizontalAlignment_0;

	public virtual VisualItemCollection Items => visualItemCollection_0;

	public VisualItem FocusedItem
	{
		get
		{
			return visualItem_2;
		}
		internal set
		{
			if (visualItem_2 != value)
			{
				if (visualItem_2 != null)
				{
					visualItem_2.vmethod_13();
				}
				VisualItem previousFocus = visualItem_2;
				visualItem_2 = value;
				if (visualItem_2 != null)
				{
					visualItem_2.vmethod_12();
				}
				OnFocusedItemChanged(previousFocus);
				InvalidateArrange();
			}
		}
	}

	[DefaultValue(0)]
	public int HorizontalItemSpacing
	{
		get
		{
			return int_0;
		}
		set
		{
			if (int_0 != value)
			{
				int_0 = value;
				InvalidateArrange();
			}
		}
	}

	[DefaultValue(false)]
	public bool IsRootVisual
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
		}
	}

	[DefaultValue(eVerticalAlignment.Middle)]
	public eVerticalAlignment VerticalItemAlignment
	{
		get
		{
			return eVerticalAlignment_0;
		}
		set
		{
			if (eVerticalAlignment_0 != value)
			{
				eVerticalAlignment_0 = value;
				OnArrangeInvalid();
			}
		}
	}

	[DefaultValue(eHorizontalAlignment.Left)]
	public eHorizontalAlignment HorizontalItemAlignment
	{
		get
		{
			return eHorizontalAlignment_0;
		}
		set
		{
			if (eHorizontalAlignment_0 != value)
			{
				eHorizontalAlignment_0 = value;
				OnArrangeInvalid();
			}
		}
	}

	public VisualGroup()
	{
		visualItemCollection_0 = new VisualItemCollection(this);
	}

	internal virtual void vmethod_15(CollectionChangedInfo collectionChangedInfo_0)
	{
		OnItemsCollectionChanged(collectionChangedInfo_0);
	}

	protected virtual void OnItemsCollectionChanged(CollectionChangedInfo collectionChangedInfo)
	{
		if (collectionChangedInfo.ChangeType == eCollectionChangeType.Adding || collectionChangedInfo.ChangeType == eCollectionChangeType.Removing || collectionChangedInfo.ChangeType == eCollectionChangeType.Clearing)
		{
			if (collectionChangedInfo.Removed != null)
			{
				VisualItem[] removed = collectionChangedInfo.Removed;
				foreach (VisualItem visualItem in removed)
				{
					visualItem.Parent = null;
				}
			}
			if (collectionChangedInfo.ChangeType == eCollectionChangeType.Clearing)
			{
				foreach (VisualItem item in Items)
				{
					item.Parent = null;
				}
			}
			if (collectionChangedInfo.Added != null)
			{
				VisualItem[] added = collectionChangedInfo.Added;
				foreach (VisualItem visualItem3 in added)
				{
					if (visualItem3.Parent != null && visualItem3.Parent != this)
					{
						visualItem3.Parent.Items.Remove(visualItem3);
					}
					visualItem3.Parent = this;
				}
			}
		}
		InvalidateArrange();
	}

	internal void method_0(VisualItem visualItem_3)
	{
		InvalidateArrange();
	}

	protected virtual void OnFocusedItemChanged(VisualItem previousFocus)
	{
	}

	protected override void OnPaint(PaintInfo p)
	{
		if (!IsLayoutValid)
		{
			PerformLayout(p);
		}
		Point renderOffset = p.RenderOffset;
		Point renderOffset2 = p.RenderOffset;
		renderOffset2.Offset(base.RenderBounds.Location);
		p.RenderOffset = renderOffset2;
		Graphics graphics = p.Graphics;
		Region val = null;
		bool flag = false;
		val = graphics.get_Clip();
		Rectangle renderBounds = base.RenderBounds;
		renderBounds.Offset(renderOffset);
		graphics.SetClip(renderBounds, (CombineMode)1);
		flag = true;
		bool parentEnabled = p.ParentEnabled;
		p.ParentEnabled = p.ParentEnabled && base.Enabled;
		foreach (VisualItem item in visualItemCollection_0)
		{
			if (eVerticalAlignment_0 == eVerticalAlignment.Middle)
			{
				item.RenderBounds = new Rectangle(p.RenderOffset.X + item.Location.X, p.RenderOffset.Y + item.Location.Y + (base.Size.Height - item.Size.Height) / 2, item.Size.Width, item.Size.Height);
			}
			else if (eVerticalAlignment_0 == eVerticalAlignment.Bottom)
			{
				item.RenderBounds = new Rectangle(p.RenderOffset.X + item.Location.X, p.RenderOffset.Y + item.Location.Y + (base.Size.Height - item.Size.Height), item.Size.Width, item.Size.Height);
			}
			else
			{
				item.RenderBounds = new Rectangle(p.RenderOffset.X + item.Location.X, p.RenderOffset.Y + item.Location.Y, item.Size.Width, item.Size.Height);
			}
			if (item.RenderBounds.IntersectsWith(renderBounds))
			{
				p.RenderOffset = Point.Empty;
				item.vmethod_14(p);
				p.RenderOffset = renderOffset2;
			}
		}
		p.ParentEnabled = parentEnabled;
		if (flag)
		{
			if (val != null)
			{
				graphics.set_Clip(val);
			}
			else
			{
				graphics.ResetClip();
			}
		}
		p.RenderOffset = renderOffset;
		base.OnPaint(p);
	}

	protected override void OnIsRightToLeftChanged()
	{
		foreach (VisualItem item in visualItemCollection_0)
		{
			item.IsRightToLeft = base.IsRightToLeft;
		}
		base.OnIsRightToLeftChanged();
	}

	public override void PerformLayout(PaintInfo pi)
	{
		Point empty = Point.Empty;
		Size empty2 = Size.Empty;
		Size availableSize = pi.AvailableSize;
		Size size = availableSize;
		bool flag = false;
		foreach (VisualItem item in new Class276(visualItemCollection_0, base.IsRightToLeft))
		{
			if (item.Visible)
			{
				item.Location = empty;
				pi.AvailableSize = new Size(availableSize.Width - empty.X, availableSize.Height);
				item.PerformLayout(pi);
				if (item.Alignment == eItemAlignment.Right)
				{
					item.Location = new Point(size.Width - item.Size.Width, empty.Y);
					size.Width -= item.Size.Width + int_0;
					flag = true;
				}
				else
				{
					empty.X += item.Size.Width + int_0;
					empty2.Width += item.Size.Width + int_0;
				}
				if (item.Size.Height > empty2.Height)
				{
					empty2.Height = item.Size.Height;
				}
			}
		}
		if (empty2.Width > 0)
		{
			empty2.Width -= int_0;
		}
		if (flag && eHorizontalAlignment_0 != 0)
		{
			if (eHorizontalAlignment_0 == eHorizontalAlignment.Right)
			{
				if (size.Width < availableSize.Width)
				{
					size.Width--;
				}
				foreach (VisualItem item2 in new Class276(visualItemCollection_0, !base.IsRightToLeft))
				{
					if (item2.Visible && item2.Alignment != eItemAlignment.Right && !(item2 is LockUpdateCheckBox))
					{
						item2.Location = new Point(size.Width - item2.Size.Width, empty.Y);
						size.Width -= item2.Size.Width + int_0;
					}
				}
			}
			else
			{
				int num = (size.Width - empty2.Width) / 2;
				foreach (VisualItem item3 in new Class276(visualItemCollection_0, base.IsRightToLeft))
				{
					if (item3.Visible && item3.Alignment != eItemAlignment.Right && !(item3 is LockUpdateCheckBox))
					{
						item3.Location = new Point(item3.Location.X + num, item3.Location.Y);
					}
				}
			}
		}
		if (flag)
		{
			empty2.Width = availableSize.Width;
		}
		pi.AvailableSize = availableSize;
		base.Size = empty2;
		base.RenderBounds = new Rectangle(pi.RenderOffset, empty2);
		base.PerformLayout(pi);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		VisualItem itemAt = GetItemAt(e.get_X(), e.get_Y());
		if (itemAt != null)
		{
			itemAt.vmethod_4(e);
			visualItem_0 = itemAt;
			visualItem_1 = itemAt;
			if (CanFocus(itemAt))
			{
				FocusedItem = itemAt;
			}
		}
		else if (itemAt == null && base.IsFocused)
		{
			foreach (VisualItem item in visualItemCollection_0)
			{
				if (item is VisualInputBase && CanFocus(item))
				{
					FocusedItem = item;
					break;
				}
			}
		}
		base.OnMouseDown(e);
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		if (FocusedItem != null)
		{
			FocusedItem.vmethod_3(e);
		}
		base.OnMouseWheel(e);
	}

	protected virtual bool CanFocus(VisualItem v)
	{
		if (v != null && v.Visible && (v.Focusable || v is VisualInputGroup))
		{
			return v.Enabled;
		}
		return false;
	}

	protected override void OnClick()
	{
		if (visualItem_0 != null)
		{
			visualItem_0.vmethod_6();
		}
		base.OnClick();
	}

	protected override void OnMouseClick(MouseEventArgs e)
	{
		if (visualItem_0 != null)
		{
			visualItem_0.vmethod_7(e);
		}
		base.OnMouseClick(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (visualItem_0 != null)
		{
			visualItem_0.vmethod_5(e);
			visualItem_0 = null;
		}
		base.OnMouseUp(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (visualItem_0 != null)
		{
			visualItem_0.vmethod_2(e);
		}
		else
		{
			VisualItem itemAt = GetItemAt(e.get_X(), e.get_Y());
			if (itemAt != visualItem_1 && visualItem_1 != null)
			{
				visualItem_1.vmethod_1();
				visualItem_1 = null;
			}
			if (itemAt != null && visualItem_1 == null)
			{
				visualItem_1 = itemAt;
				visualItem_1.vmethod_0();
			}
			if (visualItem_1 != null)
			{
				visualItem_1.vmethod_2(e);
			}
		}
		base.OnMouseMove(e);
	}

	protected override void OnMouseLeave()
	{
		if (visualItem_0 != null)
		{
			visualItem_0.vmethod_1();
		}
		else if (visualItem_1 != null)
		{
			visualItem_1.vmethod_1();
			visualItem_1 = null;
		}
		base.OnMouseLeave();
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (visualItem_2 != null)
		{
			visualItem_2.vmethod_8(e);
		}
		base.OnKeyDown(e);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		if (visualItem_2 != null)
		{
			visualItem_2.vmethod_9(e);
		}
		base.OnKeyUp(e);
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		if (visualItem_2 != null)
		{
			visualItem_2.vmethod_10(e);
		}
		base.OnKeyPress(e);
	}

	protected override bool OnCmdKey(ref Message msg, Keys keyData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (visualItem_2 != null)
		{
			return visualItem_2.vmethod_11(ref msg, keyData);
		}
		return base.OnCmdKey(ref msg, keyData);
	}

	public VisualItem GetItemAt(int x, int y)
	{
		int num = visualItemCollection_0.Count - 1;
		VisualItem visualItem;
		while (true)
		{
			if (num >= 0)
			{
				visualItem = visualItemCollection_0[num];
				if (visualItem.Visible && visualItem.RenderBounds.Contains(x, y))
				{
					break;
				}
				num--;
				continue;
			}
			return null;
		}
		return visualItem;
	}

	private VisualItem method_1()
	{
		foreach (VisualItem item in new Class276(visualItemCollection_0, base.IsRightToLeft))
		{
			if (item.Visible)
			{
				return item;
			}
		}
		return null;
	}

	protected override void OnGotFocus()
	{
		OnGroupFocused();
		base.OnGotFocus();
	}

	protected virtual void OnGroupFocused()
	{
		if (FocusedItem == null)
		{
			VisualItem visualItem = method_1();
			if (visualItem != null)
			{
				FocusedItem = visualItem;
			}
		}
	}

	protected override void OnLostFocus()
	{
		FocusedItem = null;
		base.OnLostFocus();
	}

	internal virtual void vmethod_16()
	{
		OnInputComplete();
	}

	protected virtual void OnInputComplete()
	{
	}

	internal void method_2(VisualInputBase visualInputBase_0)
	{
		OnInputChanged(visualInputBase_0);
	}

	protected virtual void OnInputChanged(VisualInputBase input)
	{
	}
}
