using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class MDISystemItem : PopupItem
{
	private bool bool_25;

	private Icon icon_0;

	private bool bool_26;

	private bool bool_27;

	private bool bool_28;

	private Enum13 enum13_0;

	private Enum13 enum13_1;

	private Enum13 enum13_2;

	public bool IsSystemIcon
	{
		get
		{
			return bool_25;
		}
		set
		{
			if (bool_25 != value)
			{
				bool_25 = value;
				NeedRecalcSize = true;
				if (bool_25)
				{
					method_21();
					ShowSubItems = true;
				}
				else
				{
					SubItems.Clear();
					ShowSubItems = false;
				}
				ShowSubItems = bool_25;
				Refresh();
			}
		}
	}

	public Icon Icon
	{
		get
		{
			return icon_0;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			if (value != null)
			{
				icon_0 = new Icon(value, 16, 16);
			}
			else
			{
				icon_0 = null;
			}
			Refresh();
		}
	}

	internal Enum13 Enum13_0 => enum13_2;

	public bool MinimizeEnabled
	{
		get
		{
			return bool_26;
		}
		set
		{
			if (value != bool_26)
			{
				bool_26 = value;
				Refresh();
			}
		}
	}

	public bool RestoreEnabled
	{
		get
		{
			return bool_27;
		}
		set
		{
			if (value != bool_27)
			{
				bool_27 = value;
				Refresh();
			}
		}
	}

	public bool CloseEnabled
	{
		get
		{
			return bool_28;
		}
		set
		{
			if (value != bool_28)
			{
				bool_28 = value;
				Refresh();
			}
		}
	}

	internal Enum13 Enum13_1 => enum13_0;

	internal Enum13 Enum13_2 => enum13_1;

	public MDISystemItem()
		: this("")
	{
	}

	public MDISystemItem(string sName)
		: base(sName)
	{
		GlobalItem = false;
		method_11(bool_22: true);
		bool_25 = false;
		icon_0 = null;
		bool_26 = true;
		bool_27 = true;
		bool_28 = true;
		enum13_0 = Enum13.const_0;
		enum13_1 = Enum13.const_0;
		enum13_2 = Enum13.const_0;
		CanCustomize = false;
		Tooltip = "";
		ShowSubItems = false;
		m_ShouldSerialize = false;
		IsAccessible = false;
	}

	public override BaseItem Copy()
	{
		MDISystemItem mDISystemItem = new MDISystemItem();
		CopyToItem(mDISystemItem);
		mDISystemItem.MinimizeEnabled = bool_26;
		mDISystemItem.RestoreEnabled = bool_27;
		mDISystemItem.CloseEnabled = bool_28;
		return mDISystemItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		MDISystemItem mDISystemItem = copy as MDISystemItem;
		base.CopyToItem((BaseItem)mDISystemItem);
		mDISystemItem.IsSystemIcon = bool_25;
	}

	public override void Paint(ItemPaintArgs pa)
	{
		if (SuspendLayout)
		{
			return;
		}
		if (Style == eDotNetBarStyle.Office2007 && pa.BaseRenderer_0 != null)
		{
			pa.BaseRenderer_0.DrawMdiSystemItem(new MdiSystemItemRendererEventArgs(pa.Graphics, this));
			return;
		}
		Graphics graphics = pa.Graphics;
		Rectangle displayRectangle;
		if (bool_25)
		{
			displayRectangle = DisplayRectangle;
			displayRectangle.Offset((displayRectangle.Width - 16) / 2, (displayRectangle.Height - 16) / 2);
			if (icon_0 != null)
			{
				graphics.DrawIconUnstretched(icon_0, displayRectangle);
			}
		}
		else if (Style == eDotNetBarStyle.Office2000)
		{
			displayRectangle = new Rectangle(DisplayRectangle.Location, vmethod_1());
			displayRectangle.Inflate(-1, -2);
			displayRectangle.Location = DisplayRectangle.Location;
			if (Orientation == eOrientation.Horizontal)
			{
				displayRectangle.Offset(0, (DisplayRectangle.Height - displayRectangle.Height) / 2);
			}
			else
			{
				displayRectangle.Offset((WidthInternal - displayRectangle.Width) / 2, 0);
			}
			if (!bool_26)
			{
				ControlPaint.DrawCaptionButton(graphics, displayRectangle, (CaptionButton)1, (ButtonState)256);
			}
			else if (enum13_1 == Enum13.const_1)
			{
				ControlPaint.DrawCaptionButton(graphics, displayRectangle, (CaptionButton)1, (ButtonState)512);
			}
			else
			{
				ControlPaint.DrawCaptionButton(graphics, displayRectangle, (CaptionButton)1, (ButtonState)0);
			}
			if (Orientation == eOrientation.Horizontal)
			{
				displayRectangle.Offset(displayRectangle.Width + 1, 0);
			}
			else
			{
				displayRectangle.Offset(0, displayRectangle.Height + 1);
			}
			if (!bool_27)
			{
				ControlPaint.DrawCaptionButton(graphics, displayRectangle, (CaptionButton)3, (ButtonState)256);
			}
			else if (enum13_1 == Enum13.const_2)
			{
				ControlPaint.DrawCaptionButton(graphics, displayRectangle, (CaptionButton)3, (ButtonState)512);
			}
			else
			{
				ControlPaint.DrawCaptionButton(graphics, displayRectangle, (CaptionButton)3, (ButtonState)0);
			}
			if (Orientation == eOrientation.Horizontal)
			{
				displayRectangle.Offset(displayRectangle.Width + 3, 0);
			}
			else
			{
				displayRectangle.Offset(0, displayRectangle.Height + 3);
			}
			if (!bool_28)
			{
				ControlPaint.DrawCaptionButton(graphics, displayRectangle, (CaptionButton)0, (ButtonState)256);
			}
			else if (enum13_1 == Enum13.const_3)
			{
				ControlPaint.DrawCaptionButton(graphics, displayRectangle, (CaptionButton)0, (ButtonState)512);
			}
			else
			{
				ControlPaint.DrawCaptionButton(graphics, displayRectangle, (CaptionButton)0, (ButtonState)0);
			}
		}
		else
		{
			displayRectangle = new Rectangle(DisplayRectangle.Location, vmethod_1());
			displayRectangle.Inflate(-1, -1);
			if (Orientation == eOrientation.Horizontal)
			{
				displayRectangle.Offset(0, (DisplayRectangle.Height - displayRectangle.Height) / 2);
			}
			else
			{
				displayRectangle.Offset((WidthInternal - displayRectangle.Width) / 2, 0);
			}
			method_18(pa, Enum13.const_1, displayRectangle);
			if (Orientation == eOrientation.Horizontal)
			{
				displayRectangle.Offset(displayRectangle.Width, 0);
			}
			else
			{
				displayRectangle.Offset(0, displayRectangle.Height);
			}
			method_18(pa, Enum13.const_2, displayRectangle);
			if (Orientation == eOrientation.Horizontal)
			{
				displayRectangle.Offset(displayRectangle.Width + 2, 0);
			}
			else
			{
				displayRectangle.Offset(0, displayRectangle.Height + 2);
			}
			method_18(pa, Enum13.const_3, displayRectangle);
		}
	}

	private void method_18(ItemPaintArgs itemPaintArgs_0, Enum13 enum13_3, Rectangle rectangle_0)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		Graphics graphics = itemPaintArgs_0.Graphics;
		if (base.Boolean_2)
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				Class77 class77_ = itemPaintArgs_0.Class77_0;
				Class124 class124_ = Class124.class124_15;
				Class149 class149_ = Class149.class149_6;
				switch (enum13_3)
				{
				case Enum13.const_3:
					class124_ = Class124.class124_19;
					break;
				case Enum13.const_2:
					class124_ = Class124.class124_21;
					break;
				case Enum13.const_4:
					class124_ = Class124.class124_23;
					break;
				}
				if (enum13_3 == enum13_1)
				{
					class149_ = Class149.class149_8;
				}
				else if (enum13_3 == enum13_0)
				{
					class149_ = Class149.class149_7;
				}
				class77_.method_0(graphics, class124_, class149_, rectangle_0);
				return;
			}
		}
		if (enum13_3 == enum13_1)
		{
			if (itemPaintArgs_0.Colors.ItemPressedBackground2.IsEmpty)
			{
				graphics.FillRectangle((Brush)new SolidBrush(itemPaintArgs_0.Colors.ItemPressedBackground), rectangle_0);
			}
			else
			{
				LinearGradientBrush val2 = Class109.smethod_40(rectangle_0, itemPaintArgs_0.Colors.ItemPressedBackground, itemPaintArgs_0.Colors.ItemPressedBackground2, itemPaintArgs_0.Colors.ItemPressedBackgroundGradientAngle);
				graphics.FillRectangle((Brush)(object)val2, rectangle_0);
				((Brush)val2).Dispose();
			}
			Class92.smethod_4(graphics, SystemPens.get_Highlight(), rectangle_0);
		}
		else if (enum13_3 == enum13_0)
		{
			if (!itemPaintArgs_0.Colors.ItemHotBackground2.IsEmpty)
			{
				LinearGradientBrush val3 = Class109.smethod_40(rectangle_0, itemPaintArgs_0.Colors.ItemHotBackground, itemPaintArgs_0.Colors.ItemHotBackground2, itemPaintArgs_0.Colors.ItemHotBackgroundGradientAngle);
				graphics.FillRectangle((Brush)(object)val3, rectangle_0);
				((Brush)val3).Dispose();
			}
			else
			{
				graphics.FillRectangle((Brush)new SolidBrush(itemPaintArgs_0.Colors.ItemHotBackground), rectangle_0);
			}
			Class92.smethod_4(graphics, new Pen(itemPaintArgs_0.Colors.ItemHotBorder), rectangle_0);
		}
		Bitmap val4 = method_19(graphics, enum13_3, rectangle_0, itemPaintArgs_0.Colors);
		try
		{
			if ((enum13_3 == Enum13.const_1 && !bool_26) || (enum13_3 == Enum13.const_2 && !bool_27) || (enum13_3 == Enum13.const_3 && !bool_28))
			{
				float[][] array = new float[5][];
				float[] array2 = (array[0] = new float[5]);
				float[] array3 = (array[1] = new float[5]);
				float[] array4 = (array[2] = new float[5]);
				array[3] = new float[5] { 0.5f, 0.5f, 0.5f, 0.5f, 0f };
				float[] array5 = (array[4] = new float[5]);
				ColorMatrix colorMatrix = new ColorMatrix(array);
				ImageAttributes val5 = new ImageAttributes();
				val5.ClearColorKey();
				val5.SetColorMatrix(colorMatrix);
				graphics.DrawImage((Image)(object)val4, rectangle_0, 0, 0, ((Image)val4).get_Width(), ((Image)val4).get_Height(), (GraphicsUnit)2, val5);
			}
			else
			{
				if (enum13_3 == enum13_1)
				{
					rectangle_0.Offset(1, 1);
				}
				graphics.DrawImageUnscaled((Image)(object)val4, rectangle_0);
			}
		}
		finally
		{
			((IDisposable)val4)?.Dispose();
		}
	}

	internal Bitmap method_19(Graphics graphics_0, Enum13 enum13_3, Rectangle rectangle_0, ColorScheme colorScheme_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		Bitmap val = new Bitmap(rectangle_0.Width, rectangle_0.Height, graphics_0);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Rectangle rectangle = new Rectangle(0, 0, rectangle_0.Width, rectangle_0.Height);
		rectangle.Inflate(0, -1);
		Rectangle clip = rectangle;
		clip.Inflate(-1, -1);
		SolidBrush val3 = new SolidBrush(SystemColors.Control);
		try
		{
			val2.FillRectangle((Brush)(object)val3, 0, 0, rectangle_0.Width, rectangle_0.Height);
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
		val2.SetClip(clip);
		ControlPaint.DrawCaptionButton(val2, rectangle, (CaptionButton)enum13_3, (ButtonState)16384);
		val2.ResetClip();
		val2.Dispose();
		if (!colorScheme_0.MdiSystemItemForeground.IsEmpty)
		{
			Bitmap val4 = new Bitmap((Image)(object)val, ((Image)val).get_Width(), ((Image)val).get_Height());
			Graphics val5 = Graphics.FromImage((Image)(object)val4);
			try
			{
				val5.Clear(Color.Transparent);
				ImageAttributes val6 = new ImageAttributes();
				ColorMap val7 = new ColorMap();
				val7.set_OldColor(Color.Black);
				val7.set_NewColor(colorScheme_0.MdiSystemItemForeground);
				val6.SetRemapTable((ColorMap[])(object)new ColorMap[1] { val7 }, (ColorAdjustType)1);
				val5.DrawImage((Image)(object)val, new Rectangle(0, 0, ((Image)val).get_Width(), ((Image)val).get_Height()), 0, 0, ((Image)val).get_Width(), ((Image)val).get_Height(), (GraphicsUnit)2, val6, (DrawImageAbort)null, IntPtr.Zero);
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
			((Image)val).Dispose();
			val = val4;
		}
		val.MakeTransparent(SystemColors.Control);
		return val;
	}

	protected override void OnTooltip(bool bShow)
	{
		base.OnTooltip(bShow);
		if (!bShow || IsSystemIcon)
		{
			return;
		}
		Point point = Control.get_MousePosition();
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null)
		{
			point = val.PointToClient(point);
		}
		Enum13 @enum = vmethod_2(point.X, point.Y);
		using Class264 @class = new Class264(GetOwner() as IOwnerLocalize);
		switch (@enum)
		{
		case Enum13.const_1:
			Tooltip = @class.method_1(LocalizationKeys.MdiSystemItemMinimizeTooltip);
			break;
		case Enum13.const_2:
			Tooltip = @class.method_1(LocalizationKeys.MdiSystemItemRestoreTooltip);
			break;
		case Enum13.const_5:
			Tooltip = @class.method_1(LocalizationKeys.MdiSystemItemMenuMaximize);
			break;
		case Enum13.const_3:
			Tooltip = @class.method_1(LocalizationKeys.MdiSystemItemCloseTooltip);
			break;
		default:
			Tooltip = "";
			break;
		}
	}

	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		base.InternalMouseDown(objArg);
		if ((int)objArg.get_Button() != 1048576 || DesignMode || !method_2())
		{
			return;
		}
		if (IsSystemIcon)
		{
			if (m_Parent != null)
			{
				if (Expanded)
				{
					m_Parent.AutoExpand = false;
				}
				else
				{
					m_Parent.AutoExpand = true;
				}
			}
			Expanded = !Expanded;
			return;
		}
		Enum13 @enum = vmethod_2(objArg.get_X(), objArg.get_Y());
		if (@enum == Enum13.const_4)
		{
			enum13_1 = Enum13.const_4;
			Refresh();
		}
		else if (bool_26 && @enum == Enum13.const_1)
		{
			enum13_1 = Enum13.const_1;
			Refresh();
		}
		else if (bool_27 && @enum == Enum13.const_2)
		{
			enum13_1 = Enum13.const_2;
			Refresh();
		}
		else if (!bool_27 && @enum == Enum13.const_5)
		{
			enum13_1 = Enum13.const_5;
			Refresh();
		}
		else if (bool_28 && @enum == Enum13.const_3)
		{
			enum13_1 = Enum13.const_3;
			Refresh();
		}
		else
		{
			enum13_1 = Enum13.const_0;
			Refresh();
		}
	}

	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		base.InternalMouseUp(objArg);
		if (enum13_1 != Enum13.const_0)
		{
			enum13_1 = Enum13.const_0;
			Refresh();
		}
	}

	public override void InternalClick(MouseButtons mb, Point mpos)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (IsSystemIcon)
		{
			enum13_2 = Enum13.const_0;
			base.InternalClick(mb, mpos);
			return;
		}
		Point point = mpos;
		enum13_2 = vmethod_2(point.X, point.Y);
		if ((enum13_2 == Enum13.const_3 && !bool_28) || (enum13_2 == Enum13.const_1 && !bool_26) || (enum13_2 == Enum13.const_2 && !bool_27) || (enum13_2 == Enum13.const_5 && bool_27))
		{
			enum13_2 = Enum13.const_0;
		}
		if (enum13_2 != Enum13.const_0)
		{
			base.InternalClick(mb, mpos);
		}
	}

	public override void InternalMouseLeave()
	{
		base.InternalMouseLeave();
		enum13_1 = Enum13.const_0;
		enum13_0 = Enum13.const_0;
		Refresh();
	}

	public override void InternalMouseMove(MouseEventArgs objArg)
	{
		base.InternalMouseMove(objArg);
		switch (vmethod_2(objArg.get_X(), objArg.get_Y()))
		{
		case Enum13.const_4:
			if (enum13_0 != Enum13.const_4)
			{
				enum13_0 = Enum13.const_4;
				if (base.ToolTipVisible)
				{
					HideToolTip();
					ResetHover();
				}
				Refresh();
			}
			return;
		case Enum13.const_1:
			if (enum13_0 != Enum13.const_1)
			{
				enum13_0 = Enum13.const_1;
				if (base.ToolTipVisible)
				{
					HideToolTip();
					ResetHover();
				}
				Refresh();
			}
			return;
		case Enum13.const_2:
			if (enum13_0 != Enum13.const_2)
			{
				enum13_0 = Enum13.const_2;
				if (base.ToolTipVisible)
				{
					HideToolTip();
					ResetHover();
				}
				Refresh();
			}
			return;
		case Enum13.const_5:
			if (enum13_0 != Enum13.const_5)
			{
				enum13_0 = Enum13.const_5;
				if (base.ToolTipVisible)
				{
					HideToolTip();
					ResetHover();
				}
				Refresh();
			}
			return;
		case Enum13.const_3:
			if (enum13_0 != 0)
			{
				enum13_0 = Enum13.const_3;
				if (base.ToolTipVisible)
				{
					HideToolTip();
					ResetHover();
				}
				Refresh();
			}
			return;
		}
		if (enum13_0 != Enum13.const_0)
		{
			enum13_0 = Enum13.const_0;
			if (base.ToolTipVisible)
			{
				HideToolTip();
				ResetHover();
			}
			Refresh();
		}
	}

	public override void RecalcSize()
	{
		if (!SuspendLayout)
		{
			if (bool_25)
			{
				m_Rect.Size = new Size(16, 16);
			}
			else if (Orientation == eOrientation.Horizontal)
			{
				m_Rect.Size = new Size(vmethod_1().Width * 3 + 2, vmethod_1().Height);
			}
			else
			{
				m_Rect.Size = new Size(vmethod_1().Width, vmethod_1().Height * 3 + 2);
			}
			base.RecalcSize();
		}
	}

	internal virtual Size vmethod_1()
	{
		return SystemInformation.get_MenuButtonSize();
	}

	internal virtual Enum13 vmethod_2(int int_5, int int_6)
	{
		Rectangle rectangle = new Rectangle(DisplayRectangle.Location, vmethod_1());
		rectangle.Inflate(-1, -2);
		rectangle.Location = DisplayRectangle.Location;
		if (Orientation == eOrientation.Horizontal)
		{
			rectangle.Offset(0, (DisplayRectangle.Height - rectangle.Height) / 2);
		}
		else
		{
			rectangle.Offset((WidthInternal - rectangle.Width) / 2, 0);
		}
		if (rectangle.Contains(int_5, int_6))
		{
			return Enum13.const_1;
		}
		if (Orientation == eOrientation.Horizontal)
		{
			rectangle.Offset(rectangle.Width + 1, 0);
		}
		else
		{
			rectangle.Offset(0, rectangle.Height + 1);
		}
		if (rectangle.Contains(int_5, int_6))
		{
			if (bool_27)
			{
				return Enum13.const_2;
			}
			return Enum13.const_5;
		}
		if (Orientation == eOrientation.Horizontal)
		{
			rectangle.Offset(rectangle.Width + 3, 0);
		}
		else
		{
			rectangle.Offset(0, rectangle.Height + 3);
		}
		if (rectangle.Contains(int_5, int_6))
		{
			return Enum13.const_3;
		}
		return Enum13.const_0;
	}

	private Bitmap method_20(Enum13 enum13_3)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		if (enum13_3 == Enum13.const_0)
		{
			return null;
		}
		Rectangle rectangle = new Rectangle(0, 0, vmethod_1().Width - 2, vmethod_1().Height - 2);
		Bitmap val = new Bitmap(rectangle.Width, rectangle.Height, (PixelFormat)137224);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		rectangle.Inflate(0, -1);
		Rectangle clip = rectangle;
		clip.Inflate(-1, -1);
		SolidBrush val3 = new SolidBrush(SystemColors.Control);
		try
		{
			val2.FillRectangle((Brush)(object)val3, 0, 0, ((Image)val).get_Width(), ((Image)val).get_Height());
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
		val2.SetClip(clip);
		ControlPaint.DrawCaptionButton(val2, rectangle, (CaptionButton)enum13_3, (ButtonState)16384);
		val2.ResetClip();
		val2.Dispose();
		val.MakeTransparent(SystemColors.Control);
		return val;
	}

	private void method_21()
	{
		using Class264 @class = new Class264(GetOwner() as IOwnerLocalize);
		SubItems.Clear();
		PopupType = ePopupType.Menu;
		ButtonItem buttonItem = new ButtonItem("dotnetbarsysmenurestore");
		buttonItem.Text = @class.method_1(LocalizationKeys.MdiSystemItemMenuRestore);
		buttonItem.Image = (Image)(object)method_20(Enum13.const_2);
		buttonItem.Click += method_22;
		buttonItem.Enabled = bool_27;
		SubItems.Add(buttonItem);
		buttonItem = new ButtonItem();
		buttonItem.Text = @class.method_1(LocalizationKeys.MdiSystemItemMenuMove);
		buttonItem.Enabled = false;
		SubItems.Add(buttonItem);
		buttonItem = new ButtonItem();
		buttonItem.Text = @class.method_1(LocalizationKeys.MdiSystemItemMenuSize);
		buttonItem.Enabled = false;
		SubItems.Add(buttonItem);
		buttonItem = new ButtonItem("dotnetbarsysmenuminimize");
		buttonItem.Text = @class.method_1(LocalizationKeys.MdiSystemItemMenuMinimize);
		buttonItem.Image = (Image)(object)method_20(Enum13.const_1);
		buttonItem.Click += method_22;
		buttonItem.Enabled = bool_26;
		SubItems.Add(buttonItem);
		buttonItem = new ButtonItem();
		buttonItem.Text = @class.method_1(LocalizationKeys.MdiSystemItemMenuMaximize);
		buttonItem.Image = (Image)(object)method_20(Enum13.const_5);
		buttonItem.Enabled = false;
		SubItems.Add(buttonItem);
		buttonItem = new ButtonItem("dotnetbarsysmenuclose");
		buttonItem.Text = @class.method_1(LocalizationKeys.MdiSystemItemMenuClose);
		buttonItem.Image = (Image)(object)method_20(Enum13.const_3);
		buttonItem.BeginGroup = true;
		buttonItem.Click += method_22;
		buttonItem.Shortcuts.Add(eShortcut.CtrlF4);
		buttonItem.Enabled = bool_28;
		SubItems.Add(buttonItem);
		buttonItem = new ButtonItem("dotnetbarsysmenunext");
		buttonItem.Text = @class.method_1(LocalizationKeys.MdiSystemItemMenuNext);
		buttonItem.BeginGroup = true;
		buttonItem.Shortcuts.Add(eShortcut.CtrlF6);
		buttonItem.Click += method_22;
		SubItems.Add(buttonItem);
	}

	private void method_22(object sender, EventArgs e)
	{
		BaseItem.CollapseAll(this);
		if (sender is BaseItem baseItem)
		{
			enum13_2 = Enum13.const_0;
			if (baseItem.Name == "dotnetbarsysmenurestore")
			{
				enum13_2 = Enum13.const_2;
			}
			else if (baseItem.Name == "dotnetbarsysmenuminimize")
			{
				enum13_2 = Enum13.const_1;
			}
			else if (baseItem.Name == "dotnetbarsysmenuclose")
			{
				enum13_2 = Enum13.const_3;
			}
			else if (baseItem.Name == "dotnetbarsysmenunext")
			{
				enum13_2 = Enum13.const_6;
			}
			if (enum13_2 != Enum13.const_0)
			{
				RaiseClick();
			}
		}
	}
}
