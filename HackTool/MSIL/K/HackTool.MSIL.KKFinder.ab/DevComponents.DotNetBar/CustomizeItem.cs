using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class CustomizeItem : PopupItem
{
	private const int int_5 = 14;

	private bool bool_25;

	private string string_7 = "";

	private string string_8 = "";

	private string string_9;

	private bool bool_26;

	private bool bool_27 = true;

	private bool bool_28 = true;

	private Size size_4 = Size.Empty;

	[Browsable(false)]
	public bool IsMouseOver => bool_25;

	[Browsable(true)]
	[Category("Behavior")]
	[DevCoBrowsable(true)]
	[Description("Determines whether the item is visible or hidden.")]
	[DefaultValue(true)]
	public override bool Visible
	{
		get
		{
			if (ContainerControl is Bar bar)
			{
				if (bar.BarState != eBarState.Docked && bar.BarState != 0)
				{
					return false;
				}
				return base.Visible;
			}
			return base.Visible;
		}
		set
		{
			base.Visible = value;
		}
	}

	[Category("Behavior")]
	[DevCoBrowsable(true)]
	[Description("Indicates whether Customize menu item is visible.")]
	[Browsable(true)]
	[DefaultValue(true)]
	public virtual bool CustomizeItemVisible
	{
		get
		{
			return bool_27;
		}
		set
		{
			bool_27 = value;
		}
	}

	[Description("Indicates whether the item will auto-collapse (fold) when clicked.")]
	[Browsable(false)]
	[DefaultValue(false)]
	[Category("Behavior")]
	[DevCoBrowsable(false)]
	public override bool AutoCollapseOnClick
	{
		get
		{
			return base.AutoCollapseOnClick;
		}
		set
		{
			base.AutoCollapseOnClick = value;
		}
	}

	[DevCoBrowsable(false)]
	[Description("Indicates whether item can be customized by user.")]
	[DefaultValue(false)]
	[Browsable(false)]
	[Category("Behavior")]
	public override bool CanCustomize
	{
		get
		{
			return base.CanCustomize;
		}
		set
		{
			base.CanCustomize = value;
		}
	}

	[DevCoBrowsable(false)]
	[Category("Behavior")]
	[Browsable(false)]
	[Description("Indicates whether certain global properties are propagated to all items with the same name when changed.")]
	[DefaultValue(false)]
	public override bool GlobalItem
	{
		get
		{
			return base.GlobalItem;
		}
		set
		{
			base.GlobalItem = value;
		}
	}

	public CustomizeItem()
	{
		GlobalItem = false;
		bool_25 = false;
		m_SystemItem = true;
		CanCustomize = false;
		LoadResources();
		AutoCollapseOnClick = false;
		size_4 = new Size(16, 16);
	}

	public override BaseItem Copy()
	{
		CustomizeItem customizeItem = new CustomizeItem();
		CopyToItem(customizeItem);
		customizeItem.CustomizeItemVisible = bool_27;
		return customizeItem;
	}

	protected internal override void OnContainerChanged(object objOldContainer)
	{
		base.OnContainerChanged(objOldContainer);
		LoadResources();
	}

	protected override void OnTooltip(bool bShow)
	{
		LoadResources();
		base.OnTooltip(bShow);
	}

	protected virtual void LoadResources()
	{
		if (!bool_26)
		{
			if (GetOwner() != null)
			{
				bool_26 = true;
			}
			using Class264 @class = new Class264(GetOwner() as IOwnerLocalize);
			string_9 = @class.method_1(LocalizationKeys.CustomizeItemTooltip);
			Text = @class.method_1(LocalizationKeys.CustomizeItemAddRemove);
			string_7 = @class.method_1(LocalizationKeys.CustomizeItemCustomize);
			string_8 = @class.method_1(LocalizationKeys.CustomizeItemReset);
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
			method_21(pa);
		}
		else if (base.Boolean_2 && !base.IsOnMenu)
		{
			method_18(pa);
		}
		else
		{
			if (m_Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style))
			{
				method_20(pa);
				return;
			}
			method_19(pa);
		}
		if (!BaseItem.IsOnPopup(this))
		{
			Point[] array = new Point[3];
			if (m_Orientation == eOrientation.Vertical)
			{
				array[0].X = m_Rect.Left + 7;
				array[0].Y = m_Rect.Top + 4;
				array[1].X = array[0].X - 3;
				array[1].Y = array[0].Y + 3;
				array[2].X = array[0].X;
				array[2].Y = array[0].Y + 6;
				pa.Graphics.FillPolygon(SystemBrushes.get_ControlText(), array);
			}
			else
			{
				array[0].X = m_Rect.Left + m_Rect.Width / 2 - 1;
				array[0].Y = m_Rect.Bottom - 4;
				array[1].X = array[0].X - 2;
				array[1].Y = array[0].Y - 3;
				array[2].X = array[1].X + 5;
				array[2].Y = array[1].Y;
				pa.Graphics.FillPolygon(SystemBrushes.get_ControlText(), array);
			}
			if (DesignMode && Focused)
			{
				Rectangle rect = m_Rect;
				Class32.smethod_0(pa.Graphics, rect, pa.Colors.ItemDesignTimeBorder);
			}
		}
	}

	private void method_18(ItemPaintArgs itemPaintArgs_0)
	{
		Class79 class79_ = itemPaintArgs_0.Class79_0;
		Class140 class140_ = Class140.class140_0;
		Class162 class162_ = Class162.class162_0;
		if (m_Expanded)
		{
			class162_ = Class162.class162_2;
		}
		else if (bool_25)
		{
			class162_ = Class162.class162_1;
		}
		class79_.method_0(itemPaintArgs_0.Graphics, class140_, class162_, m_Rect);
		class79_ = null;
		if (BaseItem.IsOnPopup(this))
		{
			Font val = null;
			eTextFormat eTextFormat_ = method_27();
			val = GetFont();
			Rectangle rect = m_Rect;
			rect.Inflate(-1, -1);
			rect.Width -= 6;
			Class55.smethod_1(itemPaintArgs_0.Graphics, m_Text, val, SystemColors.ControlText, rect, eTextFormat_);
			Point[] array = new Point[3];
			array[0].X = m_Rect.Right - 8;
			array[0].Y = m_Rect.Top + m_Rect.Height / 2 + 3;
			array[1].X = array[0].X - 2;
			array[1].Y = array[0].Y - 3;
			array[2].X = array[1].X + 5;
			array[2].Y = array[1].Y;
			itemPaintArgs_0.Graphics.FillPolygon(SystemBrushes.get_ControlText(), array);
		}
	}

	private void method_19(ItemPaintArgs itemPaintArgs_0)
	{
		Graphics graphics = itemPaintArgs_0.Graphics;
		if (Expanded)
		{
			Rectangle rectangle = new Rectangle(m_Rect.Left + 2, m_Rect.Top + 2, m_Rect.Width - 2, m_Rect.Height - 2);
			graphics.FillRectangle(SystemBrushes.get_ControlDark(), rectangle);
			rectangle.Offset(-2, -2);
			rectangle.Height += 2;
			Class50.smethod_26(graphics, rectangle, itemPaintArgs_0.Colors.ItemExpandedBackground, itemPaintArgs_0.Colors.ItemExpandedBackground2, itemPaintArgs_0.Colors.ItemExpandedBackgroundGradientAngle);
			Class50.smethod_6(graphics, itemPaintArgs_0.Colors.MenuBorder, rectangle);
		}
		else if (bool_25)
		{
			Rectangle rectangle = new Rectangle(m_Rect.Left, m_Rect.Top, m_Rect.Width - 2, m_Rect.Height);
			Class50.smethod_26(graphics, rectangle, itemPaintArgs_0.Colors.ItemHotBackground, itemPaintArgs_0.Colors.ItemHotBackground2, itemPaintArgs_0.Colors.ItemHotBackgroundGradientAngle);
			Class50.smethod_6(graphics, itemPaintArgs_0.Colors.ItemHotBorder, rectangle);
		}
		if (BaseItem.IsOnPopup(this))
		{
			Font val = null;
			eTextFormat eTextFormat_ = method_27();
			if (Expanded)
			{
				Class50.smethod_26(graphics, m_Rect, itemPaintArgs_0.Colors.ItemExpandedBackground, itemPaintArgs_0.Colors.ItemExpandedBackground2, itemPaintArgs_0.Colors.ItemExpandedBackgroundGradientAngle);
				Class50.smethod_6(graphics, itemPaintArgs_0.Colors.MenuBorder, m_Rect);
			}
			val = GetFont();
			Rectangle rect = m_Rect;
			rect.Inflate(-1, -1);
			rect.Width -= 6;
			rect.X += 4;
			Class55.smethod_1(graphics, m_Text, val, SystemColors.ControlText, rect, eTextFormat_);
			Point[] array = new Point[3];
			array[0].X = m_Rect.Right - 6;
			array[0].Y = m_Rect.Top + m_Rect.Height / 2 + 3;
			array[1].X = array[0].X - 2;
			array[1].Y = array[0].Y - 3;
			array[2].X = array[1].X + 5;
			array[2].Y = array[1].Y;
			graphics.FillPolygon(SystemBrushes.get_ControlText(), array);
		}
	}

	private void method_20(ItemPaintArgs itemPaintArgs_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected O, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected O, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected O, but got Unknown
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected O, but got Unknown
		if (BaseItem.IsOnPopup(this))
		{
			method_19(itemPaintArgs_0);
			return;
		}
		Graphics graphics = itemPaintArgs_0.Graphics;
		Rectangle rect = m_Rect;
		GraphicsPath val = new GraphicsPath();
		if (Orientation == eOrientation.Vertical)
		{
			rect.Y += 2;
			rect.Height--;
			rect.X -= 2;
			rect.Width += 2;
			if (itemPaintArgs_0.RightToLeft)
			{
				val.AddLine(rect.Right, rect.Y, rect.Right - 2, rect.Y + 2);
				val.AddLine(rect.X + 2, rect.Y + 2, rect.X, rect.Y);
				val.AddLine(rect.X, rect.Bottom - 2, rect.X + 2, rect.Bottom);
				val.AddLine(rect.Right - 2, rect.Bottom, rect.Right, rect.Bottom - 2);
			}
			else
			{
				val.AddLine(rect.X, rect.Y, rect.X + 2, rect.Y + 2);
				val.AddLine(rect.Right - 2, rect.Y + 2, rect.Right, rect.Y);
				val.AddLine(rect.Right, rect.Bottom - 2, rect.Right - 2, rect.Bottom);
				val.AddLine(rect.X + 2, rect.Bottom, rect.X, rect.Bottom - 2);
			}
			val.CloseAllFigures();
		}
		else
		{
			rect.X += 2;
			rect.Width--;
			rect.Y -= 2;
			rect.Height += 3;
			if (itemPaintArgs_0.RightToLeft)
			{
				rect.X -= 2;
				val.AddLine(rect.Right, rect.Y, rect.Right - 2, rect.Y + 2);
				val.AddLine(rect.Right - 2, rect.Bottom - 2, rect.Right, rect.Bottom);
				val.AddLine(rect.X + 2, rect.Bottom, rect.X, rect.Bottom - 2);
				val.AddLine(rect.X, rect.Y + 2, rect.X + 2, rect.Y);
			}
			else
			{
				val.AddLine(rect.X, rect.Y, rect.X + 2, rect.Y + 2);
				val.AddLine(rect.X + 2, rect.Bottom - 2, rect.X, rect.Bottom);
				val.AddLine(rect.Right - 2, rect.Bottom, rect.Right, rect.Bottom - 2);
				val.AddLine(rect.Right, rect.Y + 2, rect.Right - 2, rect.Y);
			}
			val.CloseAllFigures();
		}
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		graphics.set_SmoothingMode((SmoothingMode)4);
		if (Expanded)
		{
			Class50.smethod_30(graphics, val, itemPaintArgs_0.Colors.ItemPressedBackground, itemPaintArgs_0.Colors.ItemPressedBackground2, itemPaintArgs_0.Colors.ItemPressedBackgroundGradientAngle);
		}
		else if (bool_25)
		{
			Class50.smethod_30(graphics, val, itemPaintArgs_0.Colors.ItemHotBackground, itemPaintArgs_0.Colors.ItemHotBackground2, itemPaintArgs_0.Colors.ItemHotBackgroundGradientAngle);
		}
		else
		{
			Class50.smethod_30(graphics, val, itemPaintArgs_0.Colors.CustomizeBackground, itemPaintArgs_0.Colors.CustomizeBackground2, itemPaintArgs_0.Colors.CustomizeBackgroundGradientAngle);
		}
		graphics.set_SmoothingMode(smoothingMode);
		if (Orientation == eOrientation.Vertical)
		{
			Point[] array = new Point[3];
			array[0].X = rect.Left + (m_Rect.Width - 4) / 2 + 2 + 1;
			array[0].Y = rect.Bottom - 3 + 1;
			array[1].X = array[0].X - 2;
			array[1].Y = array[0].Y - 3;
			array[2].X = array[1].X + 5;
			array[2].Y = array[1].Y;
			SolidBrush val2 = new SolidBrush(SystemColors.Window);
			try
			{
				graphics.FillPolygon((Brush)(object)val2, array);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			Pen val3 = new Pen(itemPaintArgs_0.Colors.CustomizeText, 1f);
			try
			{
				graphics.DrawLine(val3, rect.Left + (m_Rect.Width - 4) / 2, rect.Bottom - 9, rect.Left + (m_Rect.Width - 4) / 2 + 4, rect.Bottom - 9);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			array = new Point[3];
			array[0].X = rect.Left + (m_Rect.Width - 4) / 2 + 2;
			array[0].Y = rect.Bottom - 3;
			array[1].X = array[0].X - 2;
			array[1].Y = array[0].Y - 3;
			array[2].X = array[1].X + 5;
			array[2].Y = array[1].Y;
			SolidBrush val4 = new SolidBrush(itemPaintArgs_0.Colors.CustomizeText);
			try
			{
				graphics.FillPolygon((Brush)(object)val4, array);
				return;
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
		}
		Point[] array2 = new Point[3];
		array2[0].X = rect.Left + (m_Rect.Width - 4) / 2 + 2 + 1;
		array2[0].Y = rect.Bottom - 5 + 1;
		array2[1].X = array2[0].X - 2;
		array2[1].Y = array2[0].Y - 3;
		array2[2].X = array2[1].X + 5;
		array2[2].Y = array2[1].Y;
		SolidBrush val5 = new SolidBrush(SystemColors.Window);
		try
		{
			graphics.FillPolygon((Brush)(object)val5, array2);
		}
		finally
		{
			((IDisposable)val5)?.Dispose();
		}
		Pen val6 = new Pen(itemPaintArgs_0.Colors.CustomizeText, 1f);
		try
		{
			graphics.DrawLine(val6, rect.Left + (m_Rect.Width - 4) / 2, rect.Bottom - 11, rect.Left + (m_Rect.Width - 4) / 2 + 4, rect.Bottom - 11);
		}
		finally
		{
			((IDisposable)val6)?.Dispose();
		}
		array2 = new Point[3];
		array2[0].X = rect.Left + (m_Rect.Width - 4) / 2 + 2;
		array2[0].Y = rect.Bottom - 5;
		array2[1].X = array2[0].X - 2;
		array2[1].Y = array2[0].Y - 3;
		array2[2].X = array2[1].X + 5;
		array2[2].Y = array2[1].Y;
		SolidBrush val7 = new SolidBrush(itemPaintArgs_0.Colors.CustomizeText);
		try
		{
			graphics.FillPolygon((Brush)(object)val7, array2);
		}
		finally
		{
			((IDisposable)val7)?.Dispose();
		}
	}

	private void method_21(ItemPaintArgs itemPaintArgs_0)
	{
		Graphics graphics = itemPaintArgs_0.Graphics;
		if (Expanded)
		{
			ControlPaint.DrawBorder3D(graphics, m_Rect, (Border3DStyle)2);
		}
		else if (bool_25)
		{
			ControlPaint.DrawBorder3D(graphics, m_Rect, (Border3DStyle)4);
		}
		if (BaseItem.IsOnPopup(this))
		{
			Font val = null;
			eTextFormat eTextFormat_ = method_27();
			val = GetFont();
			Rectangle rect = m_Rect;
			rect.Inflate(-1, -1);
			rect.Width -= 6;
			if (Expanded)
			{
				rect.Offset(1, 1);
				rect.Width--;
				rect.Height--;
			}
			Class55.smethod_1(graphics, m_Text, val, SystemColors.ControlText, rect, eTextFormat_);
			Point[] array = new Point[3];
			array[0].X = m_Rect.Right - 8;
			array[0].Y = m_Rect.Top + m_Rect.Height / 2 + 3;
			array[1].X = array[0].X - 2;
			array[1].Y = array[0].Y - 3;
			array[2].X = array[1].X + 5;
			array[2].Y = array[1].Y;
			graphics.FillPolygon(SystemBrushes.get_ControlText(), array);
		}
	}

	protected virtual void SetCustomTooltip(string text)
	{
		Tooltip = text;
	}

	public override void RecalcSize()
	{
		if (SuspendLayout)
		{
			return;
		}
		if (!BaseItem.IsOnPopup(this))
		{
			if (m_Orientation == eOrientation.Vertical)
			{
				m_Rect.Height = 14;
				m_Rect.Width = 22;
			}
			else
			{
				m_Rect.Width = 14;
				m_Rect.Height = 22;
			}
			m_BeginGroup = false;
			SetCustomTooltip(GetTooltipText());
		}
		else
		{
			SetCustomTooltip("");
			m_BeginGroup = true;
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (!BaseItem.IsHandleValid(val))
			{
				return;
			}
			Graphics graphics_ = Graphics.FromHwnd(val.get_Handle());
			Size size = Size.Empty;
			size = ((m_Parent == null) ? ImageSize : ((!(m_Parent is ImageItem imageItem)) ? ImageSize : new Size(imageItem.SubItemsImageSize.Width, imageItem.SubItemsImageSize.Height)));
			Font val2 = null;
			val2 = GetFont();
			Size size2 = Size.Empty;
			eTextFormat eTextFormat_ = method_27();
			if (m_Text != "")
			{
				size2 = Class55.smethod_4(graphics_, m_Text, val2, 512, eTextFormat_);
				size2.Width += 2;
			}
			if (size2.Height > size.Height)
			{
				m_Rect.Height = size2.Height + 4;
			}
			else
			{
				m_Rect.Height = size.Height + 4;
			}
			m_Rect.Width = size2.Width + 10;
		}
		base.RecalcSize();
	}

	protected virtual string GetTooltipText()
	{
		return string_9;
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
	public override void InternalMouseHover()
	{
		base.InternalMouseHover();
		MouseHoverCustomize();
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
		if ((int)objArg.get_Button() == 1048576 && !DesignMode)
		{
			MouseDownAction();
		}
	}

	protected virtual void MouseDownAction()
	{
		Expanded = !m_Expanded;
	}

	protected virtual void MouseHoverCustomize()
	{
		if (!Expanded && BaseItem.IsOnPopup(this))
		{
			Expanded = true;
		}
	}

	protected internal override void OnExpandChange()
	{
		if (Expanded)
		{
			SetupCustomizeItem();
		}
		base.OnExpandChange();
		if (!Expanded)
		{
			ClearCustomizeItem();
		}
	}

	protected virtual void SetupCustomizeItem()
	{
		if (BaseItem.IsOnPopup(this))
		{
			method_26();
			PopupType = ePopupType.Menu;
			return;
		}
		SubItems.Clear();
		CustomizeItem customizeItem = new CustomizeItem();
		customizeItem.CustomizeItemVisible = CustomizeItemVisible;
		customizeItem.IsRightToLeft = IsRightToLeft;
		SubItems.Add(customizeItem);
		PopupType = ePopupType.ToolBar;
	}

	protected virtual void ClearCustomizeItem()
	{
		SubItems.Clear();
	}

	private void method_22(object object_2)
	{
		((ButtonItem)object_2).Expanded = !((ButtonItem)object_2).Expanded;
	}

	private void method_23(object sender, EventArgs e)
	{
		BaseItem baseItem = ((BaseItem)sender).Tag as BaseItem;
		bool globalItem = baseItem.GlobalItem;
		baseItem.GlobalItem = false;
		baseItem.method_3(!baseItem.Visible);
		baseItem.UserCustomized = true;
		baseItem.GlobalItem = globalItem;
		((BaseItem)sender).Visible = !((BaseItem)sender).Visible;
		if (baseItem.ContainerControl is Bar)
		{
			((Bar)baseItem.ContainerControl).RecalcLayout();
		}
		else if (baseItem.ContainerControl is MenuPanel)
		{
			((MenuPanel)baseItem.ContainerControl).RecalcSize();
		}
		else if (baseItem.ContainerControl is BarBaseControl)
		{
			((BarBaseControl)baseItem.ContainerControl).RecalcLayout();
		}
		((BaseItem)sender).Refresh();
		if (GetOwner() is IOwner owner)
		{
			owner.InvokeUserCustomize(baseItem, new EventArgs());
			owner.InvokeEndUserCustomize(baseItem, new EndUserCustomizeEventArgs(eEndUserCustomizeAction.ItemVisibilityChanged));
		}
	}

	private void method_24(object sender, EventArgs e)
	{
		if (GetOwner() is IOwner owner)
		{
			BaseItem.CollapseAll(this);
			owner.Customize();
		}
	}

	private void method_25(object sender, EventArgs e)
	{
		if (GetOwner() is IOwner owner)
		{
			BaseItem item = this;
			if (BaseItem.IsOnPopup(this) && Parent != null)
			{
				item = Parent;
			}
			BaseItem.CollapseAll(this);
			owner.InvokeResetDefinition(item, new EventArgs());
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

	private void method_26()
	{
		SubItems.Clear();
		BaseItem parent = Parent;
		while (parent != null && parent.SystemItem && (!parent.SystemItem || !(parent is GenericItemContainer)))
		{
			parent = parent.Parent;
		}
		if (parent == null)
		{
			return;
		}
		BaseItem baseItem2;
		foreach (BaseItem subItem in parent.SubItems)
		{
			if (subItem.SystemItem || !subItem.CanCustomize)
			{
				continue;
			}
			baseItem2 = subItem.Copy();
			baseItem2.GlobalItem = false;
			baseItem2.method_5();
			baseItem2.BeginGroup = false;
			baseItem2.Enabled = true;
			baseItem2.SubItems.Clear();
			baseItem2.Tooltip = "";
			baseItem2.method_9(bool_22: true);
			if (subItem is ButtonItem)
			{
				((ButtonItem)baseItem2).HotTrackingStyle = eHotTrackingStyle.Default;
				if (bool_28 && !size_4.IsEmpty && ((ButtonItem)baseItem2).ImageSize != size_4)
				{
					((ButtonItem)baseItem2).ImageFixedSize = size_4;
					((ButtonItem)baseItem2).UseSmallImage = true;
				}
			}
			baseItem2.Click += method_23;
			baseItem2.Tag = subItem;
			SubItems.Add(baseItem2);
		}
		if (parent is GenericItemContainer && ((GenericItemContainer)parent).DisplayMoreItem_0 != null)
		{
			BaseItem displayMoreItem_ = ((GenericItemContainer)parent).DisplayMoreItem_0;
			foreach (BaseItem subItem2 in displayMoreItem_.SubItems)
			{
				if (!subItem2.SystemItem)
				{
					baseItem2 = subItem2.Copy();
					baseItem2.GlobalItem = false;
					baseItem2.method_5();
					baseItem2.BeginGroup = false;
					baseItem2.Enabled = true;
					baseItem2.SubItems.Clear();
					baseItem2.Tooltip = "";
					baseItem2.method_9(bool_22: true);
					baseItem2.Click += method_23;
					baseItem2.Tag = subItem2;
					SubItems.Add(baseItem2);
				}
			}
		}
		baseItem2 = null;
		ButtonItem buttonItem = null;
		IOwner owner = GetOwner() as IOwner;
		if (owner != null && owner.ShowResetButton)
		{
			buttonItem = new ButtonItem();
			buttonItem.GlobalItem = false;
			buttonItem.BeginGroup = true;
			buttonItem.Text = string_8;
			buttonItem.method_9(bool_22: true);
			buttonItem.method_11(bool_22: true);
			buttonItem.Orientation = eOrientation.Horizontal;
			buttonItem.Click += method_25;
			SubItems.Add(buttonItem);
		}
		if (bool_27)
		{
			buttonItem = new ButtonItem();
			buttonItem.GlobalItem = false;
			if (owner == null || (owner != null && !owner.ShowResetButton))
			{
				buttonItem.BeginGroup = true;
			}
			buttonItem.Text = string_7;
			buttonItem.method_9(bool_22: true);
			buttonItem.method_11(bool_22: true);
			buttonItem.Click += method_24;
			SubItems.Add(buttonItem);
		}
		m_NeedRecalcSize = false;
	}

	private eTextFormat method_27()
	{
		return eTextFormat.SingleLine | eTextFormat.VerticalCenter;
	}

	protected virtual Font GetFont()
	{
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null)
		{
			return val.get_Font();
		}
		return SystemInformation.get_MenuFont();
	}

	protected internal override void Serialize(ItemSerializationContext context)
	{
		base.Serialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		if (!bool_27)
		{
			itemXmlElement.SetAttribute("customizeitemvisible", XmlConvert.ToString(bool_27));
		}
	}

	protected internal override void Deserialize(ItemSerializationContext context)
	{
		base.Deserialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		if (itemXmlElement.HasAttribute("customizeitemvisible"))
		{
			bool_27 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("customizeitemvisible"));
		}
	}
}
