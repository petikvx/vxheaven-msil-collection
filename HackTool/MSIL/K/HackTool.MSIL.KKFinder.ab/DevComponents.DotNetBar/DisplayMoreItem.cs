using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
public class DisplayMoreItem : PopupItem
{
	private const int int_5 = 14;

	private bool bool_25;

	private bool bool_26;

	private eOrientation eOrientation_0;

	private bool bool_27;

	public static int FixedSize => 14;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override bool NeedRecalcSize
	{
		get
		{
			return base.NeedRecalcSize;
		}
		set
		{
			m_NeedRecalcSize = value;
		}
	}

	[Browsable(false)]
	public bool IsMouseOver => bool_25;

	public DisplayMoreItem()
	{
		GlobalItem = false;
		bool_25 = false;
		bool_26 = false;
		m_Tooltip = "More Buttons";
		m_SystemItem = true;
		CanCustomize = false;
		m_ShouldSerialize = false;
		using Class264 @class = new Class264(null);
		m_Tooltip = @class.method_1(LocalizationKeys.OverlfowDisplayMoreTooltip);
	}

	public override BaseItem Copy()
	{
		DisplayMoreItem displayMoreItem = new DisplayMoreItem();
		CopyToItem(displayMoreItem);
		return displayMoreItem;
	}

	protected internal override void OnContainerChanged(object objOldContainer)
	{
		base.OnContainerChanged(objOldContainer);
		if (!bool_27)
		{
			bool_27 = true;
			using Class264 @class = new Class264(GetOwner() as IOwnerLocalize);
			m_Tooltip = @class.method_1(LocalizationKeys.OverlfowDisplayMoreTooltip);
		}
	}

	public override void Paint(ItemPaintArgs pa)
	{
		if (SuspendLayout)
		{
			return;
		}
		if (m_Style == eDotNetBarStyle.Office2000)
		{
			method_20(pa);
		}
		else
		{
			if (base.Boolean_2)
			{
				method_19(pa);
				return;
			}
			if (Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style))
			{
				method_21(pa);
				return;
			}
			method_18(pa);
		}
		Graphics graphics = pa.Graphics;
		if (m_Orientation == eOrientation.Vertical)
		{
			Point[] array = new Point[3];
			array[0].X = m_Rect.Right - 8;
			array[0].Y = m_Rect.Top + 4;
			array[1].X = array[0].X + 2;
			array[1].Y = array[0].Y + 2;
			array[2].X = array[0].X + 4;
			array[2].Y = array[0].Y;
			graphics.DrawLines(SystemPens.get_ControlText(), array);
			array[0].Y++;
			array[1].Y++;
			array[2].Y++;
			graphics.DrawLines(SystemPens.get_ControlText(), array);
			array[0].Y += 3;
			array[1].Y += 3;
			array[2].Y += 3;
			graphics.DrawLines(SystemPens.get_ControlText(), array);
			array[0].Y++;
			array[1].Y++;
			array[2].Y++;
			graphics.DrawLines(SystemPens.get_ControlText(), array);
			array[0].X = m_Rect.Left + 7;
			array[0].Y = m_Rect.Top + 4;
			array[1].X = array[0].X - 3;
			array[1].Y = array[0].Y + 3;
			array[2].X = array[0].X;
			array[2].Y = array[0].Y + 6;
			graphics.FillPolygon(SystemBrushes.get_ControlText(), array);
		}
		else
		{
			Point[] array2 = new Point[3];
			array2[0].X = m_Rect.Left + (m_Rect.Width - 7) / 2 - 1;
			array2[0].Y = m_Rect.Top + 4;
			array2[1].X = array2[0].X + 2;
			array2[1].Y = array2[0].Y + 2;
			array2[2].X = array2[0].X;
			array2[2].Y = array2[0].Y + 4;
			graphics.DrawLines(SystemPens.get_ControlText(), array2);
			array2[0].X++;
			array2[1].X++;
			array2[2].X++;
			graphics.DrawLines(SystemPens.get_ControlText(), array2);
			array2[0].X += 3;
			array2[1].X += 3;
			array2[2].X += 3;
			graphics.DrawLines(SystemPens.get_ControlText(), array2);
			array2[0].X++;
			array2[1].X++;
			array2[2].X++;
			graphics.DrawLines(SystemPens.get_ControlText(), array2);
			array2[0].X = m_Rect.Left + m_Rect.Width / 2 - 1;
			array2[0].Y = m_Rect.Bottom - 4;
			array2[1].X = array2[0].X - 2;
			array2[1].Y = array2[0].Y - 3;
			array2[2].X = array2[1].X + 5;
			array2[2].Y = array2[1].Y;
			graphics.FillPolygon(SystemBrushes.get_ControlText(), array2);
		}
	}

	private void method_18(ItemPaintArgs itemPaintArgs_0)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		Graphics graphics = itemPaintArgs_0.Graphics;
		if (m_Expanded)
		{
			Rectangle rectangle = new Rectangle(m_Rect.Left + 2, m_Rect.Top + 2, m_Rect.Width - 2, m_Rect.Height - 2);
			if (!itemPaintArgs_0.Colors.ItemExpandedShadow.IsEmpty)
			{
				SolidBrush val = new SolidBrush(itemPaintArgs_0.Colors.ItemExpandedShadow);
				try
				{
					graphics.FillRectangle((Brush)(object)val, rectangle);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			rectangle.Offset(-2, -2);
			rectangle.Height += 2;
			if (itemPaintArgs_0.Colors.ItemExpandedBackground2.IsEmpty)
			{
				graphics.FillRectangle((Brush)new SolidBrush(itemPaintArgs_0.Colors.ItemExpandedBackground), rectangle);
			}
			else
			{
				LinearGradientBrush val2 = Class109.smethod_40(rectangle, itemPaintArgs_0.Colors.ItemExpandedBackground, itemPaintArgs_0.Colors.ItemExpandedBackground2, itemPaintArgs_0.Colors.ItemExpandedBackgroundGradientAngle);
				graphics.FillRectangle((Brush)(object)val2, rectangle);
				((Brush)val2).Dispose();
			}
			Class92.smethod_4(graphics, new Pen(itemPaintArgs_0.Colors.MenuBorder, 1f), rectangle);
		}
		else if (bool_25)
		{
			Rectangle rectangle = new Rectangle(m_Rect.Left, m_Rect.Top, m_Rect.Width - 2, m_Rect.Height);
			if (!itemPaintArgs_0.Colors.ItemHotBackground2.IsEmpty)
			{
				LinearGradientBrush val3 = Class109.smethod_40(rectangle, itemPaintArgs_0.Colors.ItemHotBackground, itemPaintArgs_0.Colors.ItemHotBackground2, itemPaintArgs_0.Colors.ItemHotBackgroundGradientAngle);
				graphics.FillRectangle((Brush)(object)val3, rectangle);
				((Brush)val3).Dispose();
			}
			else
			{
				graphics.FillRectangle((Brush)new SolidBrush(itemPaintArgs_0.Colors.ItemHotBackground), rectangle);
			}
			Class92.smethod_4(graphics, new Pen(itemPaintArgs_0.Colors.ItemHotBorder), rectangle);
		}
	}

	private void method_19(ItemPaintArgs itemPaintArgs_0)
	{
		Class78 class78_ = itemPaintArgs_0.Class78_0;
		Class139 class139_ = Class139.class139_4;
		Class164 class164_ = Class164.class164_1;
		if (m_Expanded)
		{
			class164_ = Class164.class164_3;
		}
		else if (bool_25)
		{
			class164_ = Class164.class164_2;
		}
		class78_.method_0(itemPaintArgs_0.Graphics, class139_, class164_, m_Rect);
	}

	private void method_20(ItemPaintArgs itemPaintArgs_0)
	{
		Graphics graphics = itemPaintArgs_0.Graphics;
		if (m_Expanded)
		{
			ControlPaint.DrawBorder3D(graphics, m_Rect, (Border3DStyle)2);
		}
		else if (bool_25)
		{
			ControlPaint.DrawBorder3D(graphics, m_Rect, (Border3DStyle)4);
		}
	}

	private void method_21(ItemPaintArgs itemPaintArgs_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected O, but got Unknown
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected O, but got Unknown
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af9: Expected O, but got Unknown
		Graphics graphics = itemPaintArgs_0.Graphics;
		Rectangle rect = m_Rect;
		GraphicsPath val = new GraphicsPath();
		if (Orientation == eOrientation.Vertical)
		{
			rect.Y += 2;
			rect.Height--;
			rect.X -= 2;
			rect.Width += 2;
			val.AddLine(rect.X, rect.Y, rect.X + 2, rect.Y + 2);
			val.AddLine(rect.Right - 2, rect.Y + 2, rect.Right, rect.Y);
			val.AddLine(rect.Right, rect.Bottom - 2, rect.Right - 2, rect.Bottom);
			val.AddLine(rect.X + 2, rect.Bottom, rect.X, rect.Bottom - 2);
			val.CloseAllFigures();
		}
		else
		{
			rect.X += 2;
			rect.Width--;
			rect.Y -= 2;
			rect.Height += 3;
			val.AddLine(rect.X, rect.Y, rect.X + 2, rect.Y + 2);
			val.AddLine(rect.X + 2, rect.Bottom - 2, rect.X, rect.Bottom);
			val.AddLine(rect.Right - 2, rect.Bottom, rect.Right, rect.Bottom - 2);
			val.AddLine(rect.Right, rect.Y + 2, rect.Right - 2, rect.Y);
			val.CloseAllFigures();
		}
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		graphics.set_SmoothingMode((SmoothingMode)4);
		if (Expanded)
		{
			LinearGradientBrush val2 = Class109.smethod_40(rect, itemPaintArgs_0.Colors.ItemPressedBackground, itemPaintArgs_0.Colors.ItemPressedBackground2, itemPaintArgs_0.Colors.ItemPressedBackgroundGradientAngle);
			graphics.FillPath((Brush)(object)val2, val);
			((Brush)val2).Dispose();
		}
		else if (bool_25)
		{
			LinearGradientBrush val3 = Class109.smethod_40(rect, itemPaintArgs_0.Colors.ItemHotBackground, itemPaintArgs_0.Colors.ItemHotBackground2, itemPaintArgs_0.Colors.ItemHotBackgroundGradientAngle);
			graphics.FillPath((Brush)(object)val3, val);
			((Brush)val3).Dispose();
		}
		else
		{
			LinearGradientBrush val4 = Class109.smethod_40(rect, itemPaintArgs_0.Colors.CustomizeBackground, itemPaintArgs_0.Colors.CustomizeBackground2, itemPaintArgs_0.Colors.CustomizeBackgroundGradientAngle);
			graphics.FillPath((Brush)(object)val4, val);
			((Brush)val4).Dispose();
		}
		graphics.set_SmoothingMode(smoothingMode);
		if (Orientation == eOrientation.Vertical)
		{
			graphics.DrawLine(SystemPens.get_HighlightText(), rect.Left + (m_Rect.Width - 4) / 2, rect.Bottom - 10 + 1, rect.Left + (m_Rect.Width - 4) / 2 + 4, rect.Bottom - 10 + 1);
			graphics.DrawLine(SystemPens.get_HighlightText(), rect.Left + (m_Rect.Width - 4) / 2 - 1 + 1, rect.Top + 6 + 1, rect.Left + (m_Rect.Width - 4) / 2 - 1 + 1, rect.Top + 8 + 1);
			graphics.DrawLine(SystemPens.get_HighlightText(), rect.Left + (m_Rect.Width - 4) / 2 + 3 + 1, rect.Top + 6 + 1, rect.Left + (m_Rect.Width - 4) / 2 + 3 + 1, rect.Top + 8 + 1);
			graphics.DrawLine(SystemPens.get_HighlightText(), rect.Left + (m_Rect.Width - 4) / 2 - 1 + 1, rect.Top + 7 + 1, rect.Left + (m_Rect.Width - 4) / 2 + 1, rect.Top + 7 + 1);
			graphics.DrawLine(SystemPens.get_HighlightText(), rect.Left + (m_Rect.Width - 4) / 2 + 3 + 1, rect.Top + 7 + 1, rect.Left + (m_Rect.Width - 4) / 2 + 4 + 1, rect.Top + 7 + 1);
			Pen val5 = new Pen(itemPaintArgs_0.Colors.CustomizeText, 1f);
			try
			{
				graphics.DrawLine(val5, rect.Left + (m_Rect.Width - 4) / 2, rect.Bottom - 10, rect.Left + (m_Rect.Width - 4) / 2 + 4, rect.Bottom - 10);
				graphics.DrawLine(val5, rect.Left + (m_Rect.Width - 4) / 2 - 1, rect.Top + 6, rect.Left + (m_Rect.Width - 4) / 2 - 1, rect.Top + 8);
				graphics.DrawLine(val5, rect.Left + (m_Rect.Width - 4) / 2 + 3, rect.Top + 6, rect.Left + (m_Rect.Width - 4) / 2 + 3, rect.Top + 8);
				graphics.DrawLine(val5, rect.Left + (m_Rect.Width - 4) / 2 - 1, rect.Top + 7, rect.Left + (m_Rect.Width - 4) / 2, rect.Top + 7);
				graphics.DrawLine(val5, rect.Left + (m_Rect.Width - 4) / 2 + 3, rect.Top + 7, rect.Left + (m_Rect.Width - 4) / 2 + 4, rect.Top + 7);
				return;
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
		}
		graphics.DrawLine(SystemPens.get_HighlightText(), rect.Left + (m_Rect.Width - 4) / 2 + 1, rect.Bottom - 11 + 1, rect.Left + (m_Rect.Width - 4) / 2 + 4 + 1, rect.Bottom - 11 + 1);
		graphics.DrawLine(SystemPens.get_HighlightText(), rect.Left + (m_Rect.Width - 4) / 2 - 1 + 1, rect.Top + 6 + 1, rect.Left + (m_Rect.Width - 4) / 2 - 1 + 1, rect.Top + 8 + 1);
		graphics.DrawLine(SystemPens.get_HighlightText(), rect.Left + (m_Rect.Width - 4) / 2 + 3 + 1, rect.Top + 6 + 1, rect.Left + (m_Rect.Width - 4) / 2 + 3 + 1, rect.Top + 8 + 1);
		graphics.DrawLine(SystemPens.get_HighlightText(), rect.Left + (m_Rect.Width - 4) / 2 - 1 + 1, rect.Top + 7 + 1, rect.Left + (m_Rect.Width - 4) / 2 + 1, rect.Top + 7 + 1);
		graphics.DrawLine(SystemPens.get_HighlightText(), rect.Left + (m_Rect.Width - 4) / 2 + 3 + 1, rect.Top + 7 + 1, rect.Left + (m_Rect.Width - 4) / 2 + 4 + 1, rect.Top + 7 + 1);
		Point[] array = new Point[3];
		array[0].X = rect.Left + (m_Rect.Width - 4) / 2 + 2 + 1;
		array[0].Y = rect.Bottom - 5 + 1;
		array[1].X = array[0].X - 2;
		array[1].Y = array[0].Y - 3;
		array[2].X = array[1].X + 5;
		array[2].Y = array[1].Y;
		SolidBrush val6 = new SolidBrush(SystemColors.HighlightText);
		try
		{
			graphics.FillPolygon((Brush)(object)val6, array);
		}
		finally
		{
			((IDisposable)val6)?.Dispose();
		}
		Pen val7 = new Pen(itemPaintArgs_0.Colors.CustomizeText, 1f);
		try
		{
			graphics.DrawLine(val7, rect.Left + (m_Rect.Width - 4) / 2, rect.Bottom - 11, rect.Left + (m_Rect.Width - 4) / 2 + 4, rect.Bottom - 11);
			graphics.DrawLine(val7, rect.Left + (m_Rect.Width - 4) / 2 - 1, rect.Top + 6, rect.Left + (m_Rect.Width - 4) / 2 - 1, rect.Top + 8);
			graphics.DrawLine(val7, rect.Left + (m_Rect.Width - 4) / 2 + 3, rect.Top + 6, rect.Left + (m_Rect.Width - 4) / 2 + 3, rect.Top + 8);
			graphics.DrawLine(val7, rect.Left + (m_Rect.Width - 4) / 2 - 1, rect.Top + 7, rect.Left + (m_Rect.Width - 4) / 2, rect.Top + 7);
			graphics.DrawLine(val7, rect.Left + (m_Rect.Width - 4) / 2 + 3, rect.Top + 7, rect.Left + (m_Rect.Width - 4) / 2 + 4, rect.Top + 7);
		}
		finally
		{
			((IDisposable)val7)?.Dispose();
		}
		array = new Point[3];
		array[0].X = rect.Left + (m_Rect.Width - 4) / 2 + 2;
		array[0].Y = rect.Bottom - 5;
		array[1].X = array[0].X - 2;
		array[1].Y = array[0].Y - 3;
		array[2].X = array[1].X + 5;
		array[2].Y = array[1].Y;
		SolidBrush val8 = new SolidBrush(itemPaintArgs_0.Colors.CustomizeText);
		try
		{
			graphics.FillPolygon((Brush)(object)val8, array);
		}
		finally
		{
			((IDisposable)val8)?.Dispose();
		}
	}

	public override void RecalcSize()
	{
		if (!SuspendLayout)
		{
			if (m_Orientation == eOrientation.Vertical)
			{
				m_Rect.Height = 14;
			}
			else
			{
				m_Rect.Width = 14;
			}
			base.RecalcSize();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override void InternalMouseEnter()
	{
		base.InternalMouseEnter();
		bool_25 = true;
		Refresh();
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseLeave()
	{
		base.InternalMouseLeave();
		bool_25 = false;
		Refresh();
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		base.InternalMouseDown(objArg);
		if ((int)objArg.get_Button() == 1048576)
		{
			Expanded = !m_Expanded;
		}
	}

	public override void Popup(Point p)
	{
		Popup(p.X, p.Y);
	}

	public override void Popup(int x, int y)
	{
		if (bool_26)
		{
			PopupMenu(x, y);
		}
		else
		{
			PopupBar(x, y);
		}
	}

	public override void PopupBar(int x, int y)
	{
		AddItems();
		m_NeedRecalcSize = false;
		base.PopupBar(x, y);
		m_NeedRecalcSize = false;
	}

	public override void PopupMenu(int x, int y)
	{
		AddItems();
		m_NeedRecalcSize = false;
		base.PopupMenu(x, y);
		m_NeedRecalcSize = false;
	}

	public override void ClosePopup()
	{
		base.ClosePopup();
		SubItems.Clear();
	}

	protected virtual void AddItems()
	{
		if (m_SubItems == null)
		{
			m_SubItems = new SubItemsCollection(this);
		}
		eOrientation_0 = Orientation;
		foreach (BaseItem subItem in m_Parent.SubItems)
		{
			if (subItem.Displayed || !subItem.Visible)
			{
				continue;
			}
			m_SubItems.method_0(subItem);
			if (subItem is ImageItem imageItem)
			{
				if (imageItem.ImageSize.Width > SubItemsImageSize.Width)
				{
					SubItemsImageSize = new Size(imageItem.ImageSize.Width, SubItemsImageSize.Height);
				}
				if (imageItem.ImageSize.Height > SubItemsImageSize.Height)
				{
					SubItemsImageSize = new Size(SubItemsImageSize.Width, imageItem.ImageSize.Height);
				}
			}
		}
		foreach (BaseItem subItem2 in m_SubItems)
		{
			object containerControl = subItem2.ContainerControl;
			m_Parent.SubItems.method_3(subItem2);
			subItem2.method_7(eOrientation.Horizontal);
			subItem2.SetParent(this);
			subItem2.ContainerControl = null;
			subItem2.OnContainerChanged(containerControl);
		}
		NeedRecalcSize = true;
	}

	protected virtual int GetReInsertIndex()
	{
		int num = m_Parent.SubItems.Count;
		int num2 = num - 1;
		while (num2 >= 0)
		{
			if (!(m_Parent.SubItems[num2] is CustomizeItem))
			{
				num2--;
				continue;
			}
			num = num2;
			break;
		}
		return num;
	}

	protected virtual void RemoveItems()
	{
		if (base.PopupControl is Bar)
		{
			((Bar)(object)base.PopupControl).ParentItem = null;
		}
		m_HotSubItem = null;
		int num = GetReInsertIndex();
		foreach (BaseItem subItem in m_SubItems)
		{
			_ = subItem.ContainerControl;
			subItem.Orientation = eOrientation_0;
			m_Parent.SubItems.method_1(subItem, num);
			num++;
			subItem.SetParent(m_Parent);
			subItem.ContainerControl = null;
		}
		ArrayList arrayList = new ArrayList(m_SubItems.Count);
		m_SubItems.method_4(arrayList);
		while (m_SubItems.Count > 0)
		{
			m_SubItems.method_3(m_SubItems[0]);
		}
		foreach (BaseItem item in arrayList)
		{
			item.Displayed = false;
		}
		base.OnExpandChange();
		BaseItem parent = m_Parent;
		Control val = null;
		if (parent != null)
		{
			object containerControl = parent.ContainerControl;
			val = (Control)((containerControl is Control) ? containerControl : null);
		}
		bool flag = true;
		if (val != null)
		{
			flag = !Class109.smethod_2(val, bool_3: false);
		}
		if (flag && parent != null)
		{
			parent.RecalcSize();
			parent.Refresh();
		}
	}

	protected internal override void OnExpandChange()
	{
		if (!Expanded && m_SubItems != null && m_Parent != null)
		{
			RemoveItems();
		}
		else
		{
			base.OnExpandChange();
		}
	}

	public override void Refresh()
	{
		if (SuspendLayout)
		{
			return;
		}
		if ((Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style)) && !BaseItem.IsOnPopup(this))
		{
			if ((!m_Visible && !base.IsOnCustomizeMenu) || !m_Displayed)
			{
				return;
			}
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val == null || !BaseItem.IsHandleValid(val) || val is Class83)
			{
				return;
			}
			if (m_NeedRecalcSize)
			{
				RecalcSize();
				if (m_Parent != null)
				{
					m_Parent.SubItemSizeChanged(this);
				}
			}
			Rectangle rect = m_Rect;
			rect.Inflate(2, 2);
			val.Invalidate(rect, true);
		}
		else
		{
			base.Refresh();
		}
	}
}
