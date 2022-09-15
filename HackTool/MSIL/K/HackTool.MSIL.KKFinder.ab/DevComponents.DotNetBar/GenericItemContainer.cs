using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class GenericItemContainer : ImageItem, IDesignTimeProvider
{
	protected int m_PaddingLeft;

	protected int m_PaddingTop;

	protected int m_PaddingBottom;

	protected int m_PaddingRight;

	protected int m_ItemSpacing;

	private int int_4;

	protected eBorderType m_BorderType;

	protected internal Color m_BackgroundColor;

	protected bool m_WrapItems;

	protected DisplayMoreItem m_MoreItems;

	private bool bool_22;

	private bool bool_23;

	private int int_5;

	private bool bool_24;

	private bool bool_25;

	private eLayoutType eLayoutType_0;

	private bool bool_26;

	private int int_6;

	private bool bool_27;

	private bool bool_28;

	private Control3 control3_0;

	private Control3 control3_1;

	private bool bool_29;

	private MouseEventArgs mouseEventArgs_0;

	private int int_7;

	private int int_8;

	private bool bool_30;

	private bool bool_31 = true;

	private bool bool_32 = true;

	private eContainerVerticalAlignment eContainerVerticalAlignment_0 = eContainerVerticalAlignment.Bottom;

	private bool bool_33 = true;

	internal EventHandler eventHandler_14;

	internal int Int32_1
	{
		get
		{
			return int_8;
		}
		set
		{
			int_8 = value;
		}
	}

	internal int Int32_2
	{
		get
		{
			return int_7;
		}
		set
		{
			int_7 = value;
		}
	}

	public eBorderType BorderType
	{
		get
		{
			return m_BorderType;
		}
		set
		{
			m_BorderType = value;
		}
	}

	public bool WrapItems
	{
		get
		{
			return m_WrapItems;
		}
		set
		{
			m_WrapItems = value;
		}
	}

	public int ItemSpacing
	{
		get
		{
			return m_ItemSpacing;
		}
		set
		{
			if (m_ItemSpacing != value)
			{
				m_ItemSpacing = value;
				NeedRecalcSize = true;
			}
		}
	}

	protected virtual int FirstItemSpacing
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
		}
	}

	public bool MoreItemsOnMenu
	{
		get
		{
			return bool_22;
		}
		set
		{
			bool_22 = value;
		}
	}

	internal DisplayMoreItem DisplayMoreItem_0 => m_MoreItems;

	private int Int32_3
	{
		get
		{
			if (m_Style == eDotNetBarStyle.Office2000)
			{
				return 6;
			}
			return 3;
		}
	}

	public bool EqualButtonSize
	{
		get
		{
			return bool_23;
		}
		set
		{
			if (bool_23 != value)
			{
				bool_23 = value;
				NeedRecalcSize = true;
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DefaultValue(false)]
	public override bool Expanded
	{
		get
		{
			return m_Expanded;
		}
		set
		{
			base.Expanded = value;
			if (!value && ContainerControl is ItemControl)
			{
				BaseItem.CollapseSubItems(this);
			}
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool SystemContainer
	{
		get
		{
			return bool_24;
		}
		set
		{
			bool_24 = value;
		}
	}

	public bool HaveCustomizeItem => bool_25;

	public override bool AutoExpand
	{
		get
		{
			return base.AutoExpand;
		}
		set
		{
			base.AutoExpand = value;
			if (SystemContainer && ContainerControl is Bar bar)
			{
				if (AutoExpand && !bar.Boolean_11)
				{
					bar.Boolean_11 = true;
				}
				else if (!AutoExpand && bar.Boolean_11)
				{
					bar.Boolean_11 = false;
				}
			}
		}
	}

	internal bool Boolean_3
	{
		get
		{
			return bool_31;
		}
		set
		{
			bool_31 = value;
		}
	}

	internal bool Boolean_4
	{
		get
		{
			return bool_32;
		}
		set
		{
			bool_32 = value;
		}
	}

	internal eContainerVerticalAlignment EContainerVerticalAlignment_0
	{
		get
		{
			return eContainerVerticalAlignment_0;
		}
		set
		{
			eContainerVerticalAlignment_0 = value;
		}
	}

	public virtual eLayoutType LayoutType
	{
		get
		{
			return eLayoutType_0;
		}
		set
		{
			if (eLayoutType_0 == value)
			{
				return;
			}
			eLayoutType_0 = value;
			NeedRecalcSize = true;
			if (eLayoutType_0 == eLayoutType.TaskList)
			{
				base.Orientation = eOrientation.Horizontal;
			}
			else if (ContainerControl != null && ContainerControl is Bar)
			{
				Bar bar = ContainerControl as Bar;
				if (bar.DockedSite != null && bar.DockedSite is DockSite)
				{
					base.Orientation = ((DockSite)(object)bar.DockedSite).EOrientation_0;
				}
			}
		}
	}

	[Browsable(false)]
	public override eOrientation Orientation
	{
		get
		{
			if (eLayoutType_0 == eLayoutType.TaskList)
			{
				return eOrientation.Vertical;
			}
			return base.Orientation;
		}
		set
		{
			if (eLayoutType_0 != eLayoutType.TaskList)
			{
				base.Orientation = value;
			}
		}
	}

	public Color BackColor
	{
		get
		{
			if (!m_BackgroundColor.IsEmpty)
			{
				return m_BackgroundColor;
			}
			if (m_Style != eDotNetBarStyle.Office2000 && !IsOnMenuBar)
			{
				return ColorFunctions.ToolMenuFocusBackColor();
			}
			return SystemColors.Control;
		}
		set
		{
			if (m_BackgroundColor != value)
			{
				m_BackgroundColor = value;
				Refresh();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override Size SubItemsImageSize
	{
		get
		{
			return base.SubItemsImageSize;
		}
		set
		{
			if (bool_33)
			{
				base.SubItemsImageSize = value;
			}
		}
	}

	internal bool Boolean_5
	{
		get
		{
			return bool_33;
		}
		set
		{
			bool_33 = value;
			if (!bool_33)
			{
				base.SubItemsImageSize = new Size(16, 16);
			}
		}
	}

	public int PaddingLeft
	{
		get
		{
			return m_PaddingLeft;
		}
		set
		{
			m_PaddingLeft = value;
		}
	}

	public int PaddingRight
	{
		get
		{
			return m_PaddingRight;
		}
		set
		{
			m_PaddingRight = value;
		}
	}

	public int PaddingTop
	{
		get
		{
			return m_PaddingTop;
		}
		set
		{
			m_PaddingTop = value;
		}
	}

	public int PaddingBottom
	{
		get
		{
			return m_PaddingBottom;
		}
		set
		{
			m_PaddingBottom = value;
		}
	}

	public GenericItemContainer()
	{
		m_IsContainer = true;
		m_PaddingLeft = 1;
		m_PaddingTop = 1;
		m_PaddingBottom = 1;
		m_PaddingRight = 1;
		m_ItemSpacing = 0;
		m_BackgroundColor = Color.Empty;
		m_BorderType = eBorderType.None;
		m_WrapItems = false;
		m_MoreItems = null;
		bool_23 = false;
		bool_22 = false;
		bool_24 = false;
		AccessibleRole = (AccessibleRole)20;
	}

	public override void Dispose()
	{
		if (control3_0 != null)
		{
			if (((Control)control3_0).get_Parent() != null)
			{
				((Control)control3_0).get_Parent().get_Controls().Remove((Control)(object)control3_0);
			}
			((Component)(object)control3_0).Dispose();
			control3_0 = null;
		}
		if (control3_1 != null)
		{
			if (((Control)control3_1).get_Parent() != null)
			{
				((Control)control3_1).get_Parent().get_Controls().Remove((Control)(object)control3_1);
			}
			((Component)(object)control3_1).Dispose();
			control3_1 = null;
		}
		base.Dispose();
	}

	public override BaseItem Copy()
	{
		GenericItemContainer genericItemContainer = new GenericItemContainer();
		CopyToItem(genericItemContainer);
		return genericItemContainer;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		GenericItemContainer genericItemContainer = copy as GenericItemContainer;
		base.CopyToItem(genericItemContainer);
		genericItemContainer.WrapItems = m_WrapItems;
		genericItemContainer.EqualButtonSize = bool_23;
	}

	public override void Paint(ItemPaintArgs pa)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected O, but got Unknown
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected O, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected O, but got Unknown
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected O, but got Unknown
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Expected O, but got Unknown
		if (SuspendLayout || bool_30)
		{
			return;
		}
		bool_30 = true;
		try
		{
			Graphics graphics = pa.Graphics;
			if (m_NeedRecalcSize)
			{
				RecalcSize();
			}
			_ = m_Rect.Left;
			_ = m_Rect.Top;
			Rectangle rectangle = new Rectangle(m_Rect.Left, m_Rect.Top, m_Rect.Width, m_Rect.Height);
			switch (m_BorderType)
			{
			case eBorderType.SingleLine:
			{
				Pen val = new Pen(SystemBrushes.get_ControlDark(), 1f);
				Class92.smethod_4(graphics, val, m_Rect);
				val.Dispose();
				rectangle.Inflate(-1, -1);
				break;
			}
			case eBorderType.Sunken:
				ControlPaint.DrawBorder3D(graphics, m_Rect, (Border3DStyle)2, (Border3DSide)2063);
				rectangle.Inflate(-2, -2);
				break;
			case eBorderType.Raised:
				ControlPaint.DrawBorder3D(graphics, m_Rect, (Border3DStyle)4, (Border3DSide)2063);
				rectangle.Inflate(-2, -2);
				break;
			case eBorderType.Etched:
				ControlPaint.DrawBorder3D(graphics, m_Rect, (Border3DStyle)6, (Border3DSide)2063);
				rectangle.Inflate(-2, -2);
				break;
			case eBorderType.Bump:
				ControlPaint.DrawBorder3D(graphics, m_Rect, (Border3DStyle)9, (Border3DSide)2063);
				rectangle.Inflate(-2, -2);
				break;
			}
			if (!m_BackgroundColor.IsEmpty)
			{
				SolidBrush val2 = new SolidBrush(m_BackgroundColor);
				graphics.FillRectangle((Brush)(object)val2, rectangle);
				((Brush)val2).Dispose();
			}
			graphics.SetClip(rectangle);
			if (m_SubItems != null)
			{
				BaseItem baseItem = null;
				int num = 0;
				Class79 @class = null;
				Class140 class140_ = Class140.class140_4;
				Class162 class162_ = Class162.class162_0;
				if (base.Boolean_2)
				{
					@class = pa.Class79_0;
				}
				for (int i = 0; i < m_SubItems.Count; i++)
				{
					baseItem = m_SubItems[i];
					if (baseItem.Visible && baseItem.Displayed)
					{
						if (baseItem.BeginGroup && num > 0 && eLayoutType_0 != eLayoutType.DockContainer && (!(baseItem is ItemContainer) || !Class109.smethod_69(baseItem.Style)))
						{
							if (m_Orientation != eOrientation.Vertical && eLayoutType_0 != eLayoutType.TaskList)
							{
								if (baseItem.TopInternal != m_PaddingTop + m_Rect.Top && baseItem.LeftInternal <= m_PaddingLeft + m_Rect.Left)
								{
									if (m_Style == eDotNetBarStyle.Office2000)
									{
										ControlPaint.DrawBorder3D(graphics, m_Rect.Left + m_PaddingLeft + 2, baseItem.TopInternal - 4, m_Rect.Width - m_PaddingLeft - m_PaddingRight - 4, 2, (Border3DStyle)6, (Border3DSide)2);
									}
									else if (@class != null)
									{
										class140_ = Class140.class140_5;
										@class.method_0(graphics, class140_, class162_, new Rectangle(m_Rect.Left + m_PaddingLeft + 2, baseItem.TopInternal - 4, m_Rect.Width - m_PaddingRight - 2, 6));
									}
									else
									{
										Pen val3 = new Pen(pa.Colors.ItemSeparator);
										try
										{
											if (m_Style == eDotNetBarStyle.OfficeXP)
											{
												graphics.DrawLine(val3, m_Rect.Left + m_PaddingLeft + 2, baseItem.TopInternal - 2, m_Rect.Right - m_PaddingRight - 2, baseItem.TopInternal - 2);
											}
											else
											{
												graphics.DrawLine(val3, m_Rect.Left + m_PaddingLeft + 2, baseItem.TopInternal - 2, m_Rect.Right - m_PaddingRight - 2, baseItem.TopInternal - 2);
												Pen val4 = new Pen(pa.Colors.ItemSeparatorShade, 1f);
												graphics.DrawLine(val4, m_Rect.Left + m_PaddingLeft + 6, baseItem.TopInternal - 1, m_Rect.Right - m_PaddingRight - 4, baseItem.TopInternal - 1);
												val4.Dispose();
											}
										}
										finally
										{
											((IDisposable)val3)?.Dispose();
										}
									}
								}
								else if (m_Style == eDotNetBarStyle.Office2000)
								{
									ControlPaint.DrawBorder3D(graphics, baseItem.LeftInternal - 4, baseItem.TopInternal + 1, 2, baseItem.HeightInternal - 2, (Border3DStyle)6, (Border3DSide)1);
								}
								else if (@class != null)
								{
									class140_ = Class140.class140_4;
									@class.method_0(graphics, class140_, class162_, new Rectangle(baseItem.LeftInternal - 4, baseItem.TopInternal + 1, 6, baseItem.HeightInternal - 3));
								}
								else
								{
									Pen val5 = new Pen(pa.Colors.ItemSeparator);
									try
									{
										if (m_Style == eDotNetBarStyle.OfficeXP)
										{
											graphics.DrawLine(val5, baseItem.LeftInternal - 2, baseItem.TopInternal + 1, baseItem.LeftInternal - 2, baseItem.TopInternal + 1 + baseItem.HeightInternal - 3);
										}
										else
										{
											graphics.DrawLine(val5, baseItem.LeftInternal - 2, baseItem.TopInternal + 4, baseItem.LeftInternal - 2, baseItem.TopInternal + 4 + baseItem.HeightInternal - 8);
											Pen val6 = new Pen(pa.Colors.ItemSeparatorShade, 1f);
											graphics.DrawLine(val6, baseItem.LeftInternal - 1, baseItem.TopInternal + 5, baseItem.LeftInternal - 1, baseItem.TopInternal + 5 + baseItem.HeightInternal - 8);
											val6.Dispose();
										}
									}
									finally
									{
										((IDisposable)val5)?.Dispose();
									}
								}
							}
							else if (baseItem.TopInternal != m_PaddingTop + m_Rect.Top && baseItem.LeftInternal <= m_PaddingLeft + m_Rect.Left)
							{
								Point point = new Point(baseItem.LeftInternal + m_PaddingLeft, baseItem.TopInternal - 2);
								Point point2 = new Point(baseItem.DisplayRectangle.Right - m_PaddingRight, baseItem.TopInternal - 2);
								if (LayoutType == eLayoutType.TaskList)
								{
									point.X = LeftInternal + 1;
									point2.X = DisplayRectangle.Right - 2;
								}
								if (m_Style == eDotNetBarStyle.Office2000)
								{
									ControlPaint.DrawBorder3D(graphics, m_Rect.Left + m_PaddingLeft + 2, baseItem.TopInternal - 4, baseItem.WidthInternal - 2, 2, (Border3DStyle)6, (Border3DSide)2);
								}
								else if (@class != null)
								{
									class140_ = Class140.class140_5;
									@class.method_0(graphics, class140_, class162_, new Rectangle(point.X, point.Y, point2.X - point.X, 6));
								}
								else
								{
									Pen val7 = new Pen(pa.Colors.ItemSeparator);
									try
									{
										if (m_Style == eDotNetBarStyle.OfficeXP)
										{
											graphics.DrawLine(val7, point, point2);
										}
										else
										{
											graphics.DrawLine(val7, point, point2);
											point.Offset(0, 1);
											point2.Offset(0, 1);
											Pen val8 = new Pen(pa.Colors.ItemSeparatorShade, 1f);
											try
											{
												graphics.DrawLine(val8, point, point2);
											}
											finally
											{
												((IDisposable)val8)?.Dispose();
											}
										}
									}
									finally
									{
										((IDisposable)val7)?.Dispose();
									}
								}
							}
							else if (m_Style == eDotNetBarStyle.Office2000)
							{
								ControlPaint.DrawBorder3D(graphics, baseItem.LeftInternal - 4, baseItem.TopInternal + 1, 2, m_Rect.Height - m_PaddingTop - m_PaddingBottom - 4, (Border3DStyle)6, (Border3DSide)1);
							}
							else if (@class != null)
							{
								class140_ = Class140.class140_4;
								@class.method_0(graphics, class140_, class162_, new Rectangle(baseItem.LeftInternal - 4, baseItem.TopInternal + 1, 6, m_Rect.Height - m_PaddingBottom - 2));
							}
							else
							{
								Pen val9 = new Pen(pa.Colors.ItemSeparator);
								try
								{
									if (m_Style == eDotNetBarStyle.OfficeXP)
									{
										graphics.DrawLine(val9, baseItem.LeftInternal - 2, baseItem.TopInternal + 1, baseItem.LeftInternal - 2, m_Rect.Bottom - m_PaddingBottom - 2);
									}
									else
									{
										graphics.DrawLine(val9, baseItem.LeftInternal - 2, baseItem.TopInternal + 2, baseItem.LeftInternal - 2, m_Rect.Bottom - m_PaddingBottom - 4);
										Pen val10 = new Pen(pa.Colors.ItemSeparatorShade, 1f);
										graphics.DrawLine(val10, baseItem.LeftInternal - 1, baseItem.TopInternal + 3, baseItem.LeftInternal - 1, m_Rect.Bottom - m_PaddingBottom - 5);
										val10.Dispose();
									}
								}
								finally
								{
									((IDisposable)val9)?.Dispose();
								}
							}
						}
						if (graphics.get_ClipBounds().IntersectsWith(baseItem.DisplayRectangle))
						{
							baseItem.Paint(pa);
						}
						num++;
					}
					if (m_MoreItems != null)
					{
						m_MoreItems.Paint(pa);
					}
				}
			}
			graphics.ResetClip();
		}
		finally
		{
			bool_30 = false;
		}
	}

	public override void RecalcSize()
	{
		if (!SuspendLayout)
		{
			m_RecalculatingSize = true;
			switch (eLayoutType_0)
			{
			case eLayoutType.Toolbar:
				method_18();
				break;
			case eLayoutType.TaskList:
				method_19();
				break;
			case eLayoutType.DockContainer:
				method_17(bool_34: false);
				break;
			}
			base.RecalcSize();
			m_RecalculatingSize = false;
		}
	}

	private void method_17(bool bool_34)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		bool flag = false;
		if (SuspendLayout)
		{
			return;
		}
		int_5 = 0;
		num = m_PaddingLeft + m_Rect.Left;
		num2 = m_PaddingTop + m_Rect.Top;
		if (m_SubItems != null)
		{
			for (int i = 0; i < SubItems.Count; i++)
			{
				BaseItem baseItem = SubItems[i];
				baseItem.RecalcSize();
				if (baseItem.WidthInternal > num3)
				{
					num3 = baseItem.WidthInternal;
				}
				if (baseItem.HeightInternal > num4)
				{
					num4 = baseItem.HeightInternal;
				}
				baseItem.LeftInternal = num;
				baseItem.TopInternal = num2;
				if (!baseItem.Visible)
				{
					baseItem.Displayed = false;
					continue;
				}
				int_5++;
				if (!flag && (baseItem.Displayed || i == SubItems.Count - 1))
				{
					baseItem.Displayed = true;
					flag = true;
				}
				else
				{
					baseItem.Displayed = false;
				}
			}
			if (!flag)
			{
				foreach (BaseItem subItem in m_SubItems)
				{
					if (subItem.Visible)
					{
						subItem.Displayed = true;
						break;
					}
				}
			}
		}
		if (bool_34 || Stretch)
		{
			if (num3 + m_PaddingLeft + m_PaddingRight < m_Rect.Width || num4 + m_PaddingTop + m_PaddingBottom < m_Rect.Height)
			{
				if (num3 + m_PaddingLeft + m_PaddingRight < m_Rect.Width)
				{
					num3 = m_Rect.Width - m_PaddingLeft - m_PaddingRight;
				}
				if (num4 + m_PaddingTop + m_PaddingBottom < m_Rect.Height)
				{
					num4 = m_Rect.Height - m_PaddingTop - m_PaddingBottom;
				}
			}
			if (ContainerControl is Bar bar && (bar.BarState == eBarState.Docked || bar.BarState == eBarState.AutoHide))
			{
				if (Int32_2 > 0 && num3 + m_PaddingLeft + m_PaddingRight < Int32_2 && Orientation == eOrientation.Vertical)
				{
					num3 = Int32_2 - (m_PaddingLeft + m_PaddingRight);
				}
				else if (Int32_1 > 0 && num4 + m_PaddingTop + m_PaddingBottom < Int32_1 && Orientation == eOrientation.Horizontal)
				{
					num4 = Int32_1 - (m_PaddingTop + m_PaddingBottom);
				}
			}
		}
		Size size = new Size(num3, num4);
		foreach (BaseItem subItem2 in m_SubItems)
		{
			subItem2.Size = size;
		}
		if (Stretch)
		{
			if (m_Orientation == eOrientation.Horizontal)
			{
				m_Rect.Height = m_PaddingTop + num4 + m_PaddingBottom;
				if (m_Rect.Width < num3 + m_PaddingLeft + m_PaddingRight)
				{
					m_Rect.Width = m_PaddingLeft + num3 + m_PaddingRight;
				}
			}
			else if (m_Orientation == eOrientation.Vertical)
			{
				m_Rect.Width = m_PaddingLeft + num3 + m_PaddingRight;
				if (m_Rect.Height < num4 + m_PaddingBottom + m_PaddingTop)
				{
					m_Rect.Height = m_PaddingTop + num4 + m_PaddingBottom;
				}
			}
		}
		else
		{
			m_Rect.Width = m_PaddingLeft + num3 + m_PaddingRight;
			m_Rect.Height = m_PaddingTop + num4 + m_PaddingBottom;
		}
	}

	private void method_18()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		if (SuspendLayout)
		{
			return;
		}
		bool flag = false;
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null)
		{
			flag = (int)val.get_RightToLeft() == 1;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 3;
		int num9 = 0;
		bool flag2 = true;
		bool flag3 = false;
		bool flag4 = false;
		int num10 = 0;
		BaseItem baseItem = null;
		ArrayList arrayList = null;
		Stack stack = null;
		ArrayList arrayList2 = null;
		ArrayList arrayList3 = null;
		ArrayList arrayList4 = null;
		if (m_MoreItems != null && m_MoreItems.Expanded)
		{
			m_MoreItems.Expanded = false;
		}
		if (m_Style == eDotNetBarStyle.Office2000)
		{
			num8 = 6;
		}
		num = m_PaddingLeft + m_Rect.Left;
		num2 = m_PaddingTop + m_Rect.Top;
		int visibleSubItems = base.VisibleSubItems;
		int num11 = 0;
		if (m_SubItems != null)
		{
			bool flag5 = false;
			int num12 = 0;
			if (m_WrapItems || Stretch)
			{
				arrayList = new ArrayList(3);
			}
			if (Stretch)
			{
				arrayList2 = new ArrayList(3);
				arrayList3 = new ArrayList(3);
			}
			bool flag6 = OnBeforeLayout();
			do
			{
				num10 = 0;
				for (int i = 0; i < m_SubItems.Count; i++)
				{
					baseItem = m_SubItems[i];
					if (baseItem != null && baseItem.Visible)
					{
						num11++;
						if ((baseItem.SupportedOrientation == eSupportedOrientation.Horizontal && m_Orientation == eOrientation.Vertical) || (baseItem.SupportedOrientation == eSupportedOrientation.Vertical && m_Orientation == eOrientation.Horizontal))
						{
							baseItem.Displayed = false;
							continue;
						}
						int num13 = ((num10 > 1 || int_4 == 0) ? m_ItemSpacing : int_4);
						if (flag6)
						{
							baseItem.RecalcSize();
						}
						if (flag4)
						{
							if (m_Orientation == eOrientation.Vertical)
							{
								baseItem.WidthInternal = num4;
							}
							else
							{
								baseItem.HeightInternal = num5;
							}
						}
						switch (m_Orientation)
						{
						case eOrientation.Horizontal:
							if (m_WrapItems)
							{
								if (baseItem.BeginGroup && num10 > 0)
								{
									num += num8;
								}
								if (num + baseItem.WidthInternal + num13 > m_Rect.Right && num > m_PaddingLeft + m_Rect.Left)
								{
									num2 += num3 + num13;
									if (baseItem.BeginGroup)
									{
										num2 += num8;
									}
									num = m_PaddingLeft + m_Rect.Left;
									num3 = 0;
									num9++;
									if (stack != null)
									{
										stack = null;
									}
									if (arrayList4 != null)
									{
										arrayList4 = null;
									}
								}
							}
							else if (flag2)
							{
								if (baseItem.BeginGroup && num10 > 0)
								{
									num += num8;
								}
								if ((num + baseItem.WidthInternal + num13 > m_Rect.Right - m_PaddingRight && num > m_PaddingLeft + m_Rect.Left) || (num + baseItem.WidthInternal + num13 + DisplayMoreItem.FixedSize > m_Rect.Right && i + 1 < m_SubItems.Count && num11 < visibleSubItems))
								{
									if (i == 0)
									{
										num3 = baseItem.HeightInternal;
									}
									num += num13 + DisplayMoreItem.FixedSize;
									flag2 = false;
								}
							}
							if (flag2)
							{
								if (num10 > 0)
								{
									num += num13;
								}
								baseItem.LeftInternal = GetItemLayoutX(baseItem, num);
								baseItem.TopInternal = GetItemLayoutY(baseItem, num2);
								num += GetItemLayoutWidth(baseItem);
								if (baseItem.HeightInternal > num3)
								{
									num3 = baseItem.HeightInternal;
								}
							}
							break;
						case eOrientation.Vertical:
							if (m_WrapItems)
							{
								if (baseItem.BeginGroup && num10 > 0)
								{
									num2 += num8;
								}
								if (num2 + baseItem.HeightInternal + num13 > m_Rect.Bottom && num2 > m_PaddingTop + m_Rect.Top)
								{
									num += num3 + num13;
									if (baseItem.BeginGroup)
									{
										num += num8;
									}
									num2 = m_PaddingTop + m_Rect.Top;
									num3 = 0;
									num9++;
									if (stack != null)
									{
										stack = null;
									}
									if (arrayList4 != null)
									{
										arrayList4 = null;
									}
								}
							}
							else if (flag2)
							{
								if (baseItem.BeginGroup && num10 > 0)
								{
									num2 += num8;
								}
								if ((num2 + baseItem.HeightInternal + num13 > m_Rect.Bottom && num2 > m_PaddingTop + m_Rect.Top) || (num2 + baseItem.HeightInternal + num13 + DisplayMoreItem.FixedSize > m_Rect.Bottom && i + 1 < m_SubItems.Count && num11 < visibleSubItems))
								{
									if (i == 0)
									{
										num3 = baseItem.WidthInternal;
									}
									num2 += num13 + DisplayMoreItem.FixedSize;
									flag2 = false;
								}
							}
							if (flag2)
							{
								if (num10 > 0)
								{
									num2 += num13;
								}
								baseItem.LeftInternal = num;
								baseItem.TopInternal = num2;
								num2 += GetItemLayoutHeight(baseItem);
								if (baseItem.WidthInternal > num3)
								{
									num3 = baseItem.WidthInternal;
								}
							}
							break;
						}
						if (flag2)
						{
							if (baseItem.WidthInternal != num4)
							{
								if (m_Orientation == eOrientation.Vertical && num4 != 0 && !flag4)
								{
									flag3 = true;
								}
								if (baseItem.WidthInternal > num4)
								{
									num4 = baseItem.WidthInternal;
								}
							}
							if (baseItem.HeightInternal != num5)
							{
								if (m_Orientation == eOrientation.Horizontal && num5 != 0 && !flag4)
								{
									flag3 = true;
								}
								if (baseItem.HeightInternal > num5)
								{
									num5 = baseItem.HeightInternal;
								}
							}
							num10++;
						}
						baseItem.Displayed = flag2;
						if ((flag2 && arrayList != null && baseItem.ItemAlignment == eItemAlignment.Far) || stack != null)
						{
							if (stack == null)
							{
								stack = new Stack();
								arrayList.Add(stack);
							}
							stack.Push(baseItem);
							arrayList2 = null;
						}
						if ((flag2 && baseItem.Stretch && arrayList2 != null) || arrayList4 != null)
						{
							if (arrayList4 == null)
							{
								arrayList4 = new ArrayList(5);
								arrayList2.Add(arrayList4);
								arrayList3.Add(0);
							}
							arrayList4.Add(baseItem);
							if (baseItem.Stretch)
							{
								arrayList3[arrayList3.Count - 1] = (int)arrayList3[arrayList3.Count - 1] + 1;
							}
						}
						if (num > num6)
						{
							num6 = num;
						}
						if (num2 > num7)
						{
							num7 = num2;
						}
					}
					else if (baseItem != null)
					{
						baseItem.Displayed = false;
					}
				}
				if (m_WrapItems && num9 > 0 && num12 < 1)
				{
					if (m_Orientation == eOrientation.Horizontal && (num6 > m_Rect.Width || flag3))
					{
						flag5 = true;
						m_Rect.Width = num6 + m_PaddingLeft + m_PaddingRight;
						num = m_PaddingLeft + m_Rect.Left;
						num2 = m_PaddingTop + m_Rect.Top;
						num6 = 0;
						num7 = 0;
					}
					else if (m_Orientation == eOrientation.Vertical && (num7 > m_Rect.Height || flag3))
					{
						flag5 = true;
						m_Rect.Height = num7 + m_PaddingTop + m_PaddingBottom;
						num = m_PaddingLeft + m_Rect.Left;
						num2 = m_PaddingTop + m_Rect.Top;
						num6 = 0;
						num7 = 0;
					}
					if (flag3)
					{
						if (bool_31)
						{
							flag4 = true;
						}
						flag3 = false;
					}
					if (flag5 && num12 + 1 < 2)
					{
						if (arrayList != null && arrayList.Count > 0)
						{
							arrayList = new ArrayList(3);
						}
						if (arrayList2 != null && arrayList2.Count > 0)
						{
							arrayList2 = new ArrayList(3);
							arrayList3 = new ArrayList(3);
						}
					}
				}
				num12++;
			}
			while (flag5 && num12 < 2);
		}
		if (bool_23)
		{
			num = m_PaddingLeft + m_Rect.Left;
			num2 = m_PaddingTop + m_Rect.Top;
			num6 = 0;
			num7 = 0;
			flag2 = true;
			num9 = 0;
			flag3 = false;
			num10 = 0;
			if (arrayList != null && arrayList.Count > 0)
			{
				arrayList = new ArrayList(3);
			}
			if (arrayList2 != null && arrayList2.Count > 0)
			{
				arrayList2 = new ArrayList(3);
				arrayList3 = new ArrayList(3);
			}
			for (int j = 0; j < m_SubItems.Count; j++)
			{
				baseItem = m_SubItems[j];
				if (baseItem == null || !baseItem.Visible)
				{
					continue;
				}
				if ((baseItem.SupportedOrientation == eSupportedOrientation.Horizontal && m_Orientation == eOrientation.Vertical) || (baseItem.SupportedOrientation == eSupportedOrientation.Vertical && m_Orientation == eOrientation.Horizontal))
				{
					baseItem.Displayed = false;
					continue;
				}
				int num14 = ((num10 > 1 || int_4 == 0) ? m_ItemSpacing : int_4);
				if (baseItem.SystemItem)
				{
					if (m_Orientation == eOrientation.Vertical)
					{
						baseItem.WidthInternal = num4;
					}
					else
					{
						baseItem.HeightInternal = num5;
					}
				}
				else
				{
					baseItem.WidthInternal = num4;
					baseItem.HeightInternal = num5;
				}
				switch (m_Orientation)
				{
				case eOrientation.Horizontal:
					if (m_WrapItems)
					{
						if (baseItem.BeginGroup)
						{
							num += num8;
						}
						if (num + baseItem.WidthInternal + num14 > m_Rect.Right && num > m_PaddingLeft + m_PaddingRight)
						{
							num2 += num3 + num14;
							if (baseItem.BeginGroup)
							{
								num2 += num8;
							}
							num = m_PaddingLeft + m_Rect.Left;
							num3 = 0;
							num9++;
							if (stack != null)
							{
								stack = null;
							}
							if (arrayList4 != null)
							{
								arrayList4 = null;
							}
						}
					}
					else if (flag2)
					{
						if (baseItem.BeginGroup)
						{
							num += num8;
						}
						if ((num + baseItem.WidthInternal + num14 > m_Rect.Right && num > m_PaddingLeft + m_Rect.Left) || (num + baseItem.WidthInternal + num14 + DisplayMoreItem.FixedSize > m_Rect.Right && j + 1 < m_SubItems.Count && num11 < visibleSubItems))
						{
							num += num14 + DisplayMoreItem.FixedSize;
							flag2 = false;
						}
					}
					if (flag2)
					{
						baseItem.LeftInternal = num;
						baseItem.TopInternal = num2;
						num += baseItem.WidthInternal + num14;
						if (baseItem.HeightInternal > num3)
						{
							num3 = baseItem.HeightInternal;
						}
					}
					break;
				case eOrientation.Vertical:
					if (m_WrapItems)
					{
						if (num2 + baseItem.HeightInternal + num14 > m_Rect.Bottom && num2 > m_PaddingTop + m_PaddingBottom)
						{
							num += num3 + num14;
							num2 = m_PaddingTop + m_Rect.Top;
							num3 = 0;
							num9++;
							if (stack != null)
							{
								stack = null;
							}
							if (arrayList4 != null)
							{
								arrayList4 = null;
							}
						}
					}
					else if (flag2 && ((num2 + baseItem.HeightInternal + num14 > m_Rect.Bottom && num2 > m_PaddingTop + m_Rect.Top) || (num2 + baseItem.HeightInternal + num14 + DisplayMoreItem.FixedSize > m_Rect.Bottom && j + 1 < m_SubItems.Count && num11 < visibleSubItems)))
					{
						num2 += num14 + DisplayMoreItem.FixedSize;
						flag2 = false;
					}
					if (flag2)
					{
						baseItem.LeftInternal = num;
						baseItem.TopInternal = num2;
						num2 += baseItem.HeightInternal + num14;
						if (baseItem.WidthInternal > num3)
						{
							num3 = baseItem.WidthInternal;
						}
					}
					break;
				}
				baseItem.Displayed = flag2;
				if (flag2)
				{
					num10++;
				}
				if ((flag2 && arrayList != null && baseItem.ItemAlignment == eItemAlignment.Far) || stack != null)
				{
					if (stack == null)
					{
						stack = new Stack();
						arrayList.Add(stack);
					}
					stack.Push(baseItem);
					arrayList2 = null;
				}
				if ((flag2 && baseItem.Stretch && arrayList2 != null) || arrayList4 != null)
				{
					if (arrayList4 == null)
					{
						arrayList4 = new ArrayList(5);
						arrayList2.Add(arrayList4);
						arrayList3.Add(0);
					}
					arrayList4.Add(baseItem);
					if (baseItem.Stretch)
					{
						arrayList3[arrayList3.Count - 1] = (int)arrayList3[arrayList3.Count - 1] + 1;
					}
				}
				if (num > num6)
				{
					num6 = num;
				}
				if (num2 > num7)
				{
					num7 = num2;
				}
			}
		}
		int_5 = num10;
		if (flag3)
		{
			if (m_Orientation == eOrientation.Vertical)
			{
				foreach (BaseItem subItem in SubItems)
				{
					if (bool_31)
					{
						subItem.WidthInternal = num4;
					}
					else if (eContainerVerticalAlignment_0 == eContainerVerticalAlignment.Bottom)
					{
						subItem.LeftInternal += num4 - subItem.WidthInternal;
					}
					else if (eContainerVerticalAlignment_0 == eContainerVerticalAlignment.Middle)
					{
						subItem.LeftInternal += (num4 - subItem.WidthInternal) / 2;
					}
				}
			}
			else
			{
				foreach (BaseItem subItem2 in SubItems)
				{
					if (bool_31)
					{
						subItem2.HeightInternal = num5;
					}
					else if (eContainerVerticalAlignment_0 == eContainerVerticalAlignment.Bottom)
					{
						subItem2.TopInternal += num5 - subItem2.HeightInternal;
					}
					else if (eContainerVerticalAlignment_0 == eContainerVerticalAlignment.Middle && num5 != subItem2.HeightInternal)
					{
						subItem2.TopInternal += (int)Math.Ceiling((float)(num5 - subItem2.HeightInternal) / 2f) + 1;
					}
				}
			}
		}
		switch (m_Orientation)
		{
		case eOrientation.Horizontal:
			num7 += num3;
			break;
		case eOrientation.Vertical:
			num6 += num3;
			break;
		}
		if (Stretch)
		{
			if (m_Orientation == eOrientation.Horizontal)
			{
				m_Rect.Height = num7 + m_PaddingBottom - m_Rect.Top;
				if (arrayList2 != null && arrayList2.Count > 0)
				{
					method_25(arrayList2, arrayList3, num6 + m_PaddingRight - m_Rect.Left);
				}
				if (m_Rect.Width < num6 + m_PaddingRight - m_Rect.Left)
				{
					m_Rect.Width = num6 + m_PaddingRight - m_Rect.Left;
				}
			}
			else if (m_Orientation == eOrientation.Vertical)
			{
				m_Rect.Width = num6 + m_PaddingRight - m_Rect.Left;
				if (arrayList2 != null && arrayList2.Count > 0)
				{
					method_25(arrayList2, arrayList3, num7 + m_PaddingBottom - m_Rect.Top);
				}
				if (m_Rect.Height < num7 + m_PaddingBottom - m_Rect.Top)
				{
					m_Rect.Height = num7 + m_PaddingBottom - m_Rect.Top;
				}
			}
			else
			{
				m_Rect.Width = num6 + m_PaddingRight - m_Rect.Left;
				m_Rect.Height = num7 + m_PaddingBottom - m_Rect.Top;
			}
		}
		else if (!m_WrapItems && !flag2)
		{
			if (m_Orientation == eOrientation.Horizontal)
			{
				m_Rect.Height = num7 + m_PaddingBottom - m_Rect.Top;
			}
			else if (m_Orientation == eOrientation.Vertical)
			{
				m_Rect.Width = num6 + m_PaddingRight - m_Rect.Left;
			}
		}
		else if (int_5 > 0)
		{
			m_Rect.Width = num6 + m_PaddingRight - m_Rect.Left;
			m_Rect.Height = num7 + m_PaddingBottom - m_Rect.Top;
		}
		if (!m_WrapItems && !flag2 && bool_32)
		{
			CreateMoreItemsButton(flag);
		}
		else if (m_MoreItems != null)
		{
			m_MoreItems.Dispose();
			m_MoreItems = null;
		}
		if (arrayList != null && arrayList.Count > 0)
		{
			method_24(arrayList);
		}
		if (flag && m_Orientation == eOrientation.Horizontal)
		{
			MirrorPositionItems();
		}
		m_NeedRecalcSize = false;
		if (m_Parent != null)
		{
			m_Parent.SubItemSizeChanged(this);
		}
	}

	protected virtual int GetItemLayoutX(BaseItem objItem, int iX)
	{
		return iX;
	}

	protected virtual int GetItemLayoutY(BaseItem objItem, int iY)
	{
		return iY;
	}

	protected virtual int GetItemLayoutHeight(BaseItem objItem)
	{
		return objItem.HeightInternal;
	}

	protected virtual int GetItemLayoutWidth(BaseItem objItem)
	{
		return objItem.WidthInternal;
	}

	protected virtual bool OnBeforeLayout()
	{
		return true;
	}

	protected void MirrorPositionItems()
	{
		Rectangle displayRectangle = DisplayRectangle;
		foreach (BaseItem subItem in SubItems)
		{
			subItem.LeftInternal = displayRectangle.Right - (subItem.DisplayRectangle.X - displayRectangle.X + subItem.DisplayRectangle.Width);
		}
	}

	private void method_19()
	{
		int leftInternal = m_Rect.Left + m_PaddingLeft;
		int num = m_Rect.Top + m_PaddingTop;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 3;
		bool flag = true;
		int num7 = 0;
		Stack stack = null;
		if (m_Style == eDotNetBarStyle.Office2000)
		{
			num6 = 6;
		}
		if (bool_23)
		{
			foreach (BaseItem subItem in m_SubItems)
			{
				subItem.Orientation = eOrientation.Horizontal;
				subItem.RecalcSize();
				if (subItem.WidthInternal > num2)
				{
					num2 = subItem.WidthInternal;
				}
				if (subItem.HeightInternal > num3)
				{
					num3 = subItem.HeightInternal;
				}
			}
		}
		for (int i = 0; i < m_SubItems.Count; i++)
		{
			BaseItem baseItem2 = m_SubItems[i];
			baseItem2.Orientation = eOrientation.Horizontal;
			if (baseItem2 == null || !baseItem2.Visible)
			{
				continue;
			}
			if (!bool_23)
			{
				baseItem2.RecalcSize();
			}
			if (baseItem2.BeginGroup && num7 > 0)
			{
				num += num6;
			}
			if (!bool_23)
			{
				if (baseItem2.WidthInternal > num2)
				{
					num2 = baseItem2.WidthInternal;
				}
				if (baseItem2.HeightInternal > num3)
				{
					num3 = baseItem2.HeightInternal;
				}
			}
			else
			{
				baseItem2.WidthInternal = num2;
				baseItem2.HeightInternal = num3;
			}
			baseItem2.TopInternal = num;
			baseItem2.LeftInternal = leftInternal;
			num += baseItem2.HeightInternal;
			baseItem2.Displayed = flag;
			if (!flag)
			{
				continue;
			}
			if (num > m_Rect.Bottom)
			{
				flag = false;
				stack = null;
				baseItem2.Displayed = false;
				continue;
			}
			if (stack != null && stack.Count > 0)
			{
				stack.Push(baseItem2);
			}
			num7++;
			if (baseItem2.ItemAlignment == eItemAlignment.Far)
			{
				if (stack == null)
				{
					stack = new Stack(10);
				}
				stack.Push(baseItem2);
			}
		}
		num4 = num2 + m_PaddingLeft + m_PaddingRight;
		num5 = num + m_PaddingBottom - m_Rect.Top;
		int_5 = num7;
		if (Stretch)
		{
			if (flag && stack != null && stack.Count > 0)
			{
				method_22(stack, eOrientation.Vertical);
			}
			if (!(ContainerControl is Bar bar) || (bar != null && bar.DockSide != eDockSide.Top && bar.DockSide != eDockSide.Bottom))
			{
				m_Rect.Width = num4;
			}
			if (m_Rect.Height < num5)
			{
				if (m_Rect.Height < 36)
				{
					m_Rect.Height = 36;
				}
				bool_26 = true;
				method_20();
			}
			else
			{
				bool_26 = false;
				int_6 = 0;
			}
		}
		else
		{
			m_Rect.Width = num4;
			if (m_Rect.Height > num5 && flag)
			{
				m_Rect.Height = num5;
			}
			if (!flag)
			{
				if (m_Rect.Height < 36)
				{
					m_Rect.Height = 36;
				}
				bool_26 = true;
				method_20();
			}
			else
			{
				bool_26 = false;
				int_6 = 0;
			}
		}
		if (m_MoreItems != null)
		{
			m_MoreItems.Dispose();
			m_MoreItems = null;
		}
		method_21();
	}

	private void method_20()
	{
		int num = 0;
		int num2 = 0;
		int int32_ = Int32_3;
		bool flag = true;
		bool_27 = false;
		bool_28 = false;
		for (int num3 = int_6 - 1; num3 >= 0; num3--)
		{
			BaseItem baseItem = m_SubItems[num3];
			if (baseItem.Visible)
			{
				num = (baseItem.TopInternal = num - baseItem.HeightInternal);
				baseItem.Displayed = false;
				if (baseItem.BeginGroup && num3 > 0)
				{
					num -= int32_;
				}
			}
		}
		num = m_Rect.Top;
		for (int i = int_6; i < m_SubItems.Count; i++)
		{
			BaseItem baseItem2 = m_SubItems[i];
			if (!baseItem2.Visible)
			{
				continue;
			}
			baseItem2.Displayed = flag;
			if (flag)
			{
				if (baseItem2.BeginGroup && num2 > 0)
				{
					num += int32_;
				}
				baseItem2.TopInternal = num;
				num += baseItem2.HeightInternal;
				if (num > m_Rect.Bottom)
				{
					baseItem2.Displayed = false;
					flag = false;
				}
				else
				{
					num2++;
				}
			}
		}
		int_5 = num2;
		if (!flag)
		{
			bool_28 = true;
		}
		if (int_6 > 0)
		{
			bool_27 = true;
		}
	}

	private void method_21()
	{
		bool flag = false;
		bool flag2 = false;
		if (!bool_26)
		{
			flag = true;
			flag2 = true;
		}
		else
		{
			if (!bool_27)
			{
				flag = true;
			}
			if (!bool_28)
			{
				flag2 = true;
			}
		}
		if (flag)
		{
			if (control3_0 != null)
			{
				if (((Control)control3_0).get_Parent() != null)
				{
					((Control)control3_0).get_Parent().get_Controls().Remove((Control)(object)control3_0);
				}
				((Component)(object)control3_0).Dispose();
				control3_0 = null;
			}
		}
		else
		{
			if (control3_0 == null)
			{
				object containerControl = ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val != null)
				{
					control3_0 = new Control3();
					control3_0.EOrientation_0 = eOrientation.Vertical;
					control3_0.EItemAlignment_0 = eItemAlignment.Near;
					val.get_Controls().Add((Control)(object)control3_0);
					((Control)control3_0).add_Click((EventHandler)control3_1_Click);
				}
			}
			if (control3_0 != null)
			{
				((Control)control3_0).set_Location(m_Rect.Location);
				((Control)control3_0).set_Size(new Size(m_Rect.Width, 10));
				((Control)control3_0).BringToFront();
			}
		}
		if (flag2)
		{
			if (control3_1 != null)
			{
				if (((Control)control3_1).get_Parent() != null)
				{
					((Control)control3_1).get_Parent().get_Controls().Remove((Control)(object)control3_1);
				}
				((Component)(object)control3_1).Dispose();
				control3_1 = null;
			}
			return;
		}
		if (control3_1 == null)
		{
			object containerControl2 = ContainerControl;
			Control val2 = (Control)((containerControl2 is Control) ? containerControl2 : null);
			if (val2 != null)
			{
				control3_1 = new Control3();
				control3_1.EOrientation_0 = eOrientation.Vertical;
				control3_1.EItemAlignment_0 = eItemAlignment.Far;
				val2.get_Controls().Add((Control)(object)control3_1);
				((Control)control3_1).add_Click((EventHandler)control3_1_Click);
			}
		}
		if (control3_1 != null)
		{
			((Control)control3_1).set_Location(new Point(m_Rect.X, m_Rect.Bottom - 10));
			((Control)control3_1).set_Size(new Size(m_Rect.Width, 10));
			((Control)control3_1).BringToFront();
		}
	}

	private void control3_1_Click(object sender, EventArgs e)
	{
		if (sender == control3_0)
		{
			int_6--;
		}
		else
		{
			int_6++;
		}
		method_20();
		method_21();
		Refresh();
	}

	private void method_22(Stack stack_0, eOrientation eOrientation_0)
	{
		int num = 0;
		int int32_ = Int32_3;
		if (eOrientation_0 == eOrientation.Horizontal)
		{
			num = m_Rect.Right - m_PaddingRight;
			if (m_MoreItems != null)
			{
				num -= m_MoreItems.WidthInternal;
			}
			while (stack_0.Count > 0)
			{
				BaseItem baseItem = stack_0.Pop() as BaseItem;
				if (baseItem.Displayed && baseItem.Visible)
				{
					baseItem.LeftInternal = num - GetItemLayoutWidth(baseItem);
					num = baseItem.LeftInternal - m_ItemSpacing;
					if (baseItem.BeginGroup)
					{
						num -= int32_;
					}
				}
			}
			return;
		}
		num = m_Rect.Bottom - m_PaddingBottom;
		if (m_MoreItems != null)
		{
			num -= m_MoreItems.HeightInternal;
		}
		while (stack_0.Count > 0)
		{
			BaseItem baseItem2 = stack_0.Pop() as BaseItem;
			if (baseItem2.Displayed && baseItem2.Visible)
			{
				baseItem2.TopInternal = num - GetItemLayoutHeight(baseItem2);
				num = baseItem2.TopInternal - m_ItemSpacing;
				if (baseItem2.BeginGroup)
				{
					num -= int32_;
				}
			}
		}
	}

	private void method_23(ArrayList arrayList_0, eOrientation eOrientation_0)
	{
		if (eOrientation_0 == eOrientation.Horizontal)
		{
			foreach (Stack item in arrayList_0)
			{
				method_22(item, eOrientation_0);
			}
			return;
		}
		foreach (Stack item2 in arrayList_0)
		{
			method_22(item2, eOrientation_0);
		}
	}

	private void method_24(ArrayList arrayList_0)
	{
		method_23(arrayList_0, Orientation);
	}

	private void method_25(ArrayList arrayList_0, ArrayList arrayList_1, int int_9)
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < arrayList_0.Count; i++)
		{
			ArrayList arrayList = arrayList_0[i] as ArrayList;
			num2 = ((m_Orientation != 0) ? ((HeightInternal - int_9) / (int)arrayList_1[i]) : ((WidthInternal - int_9) / (int)arrayList_1[i]));
			foreach (BaseItem item in arrayList)
			{
				if (item.Stretch)
				{
					if (m_Orientation == eOrientation.Horizontal)
					{
						item.LeftInternal += num;
						item.WidthInternal += num2;
					}
					else
					{
						item.TopInternal += num;
						item.HeightInternal += num2;
					}
					num += num2;
				}
				else if (m_Orientation == eOrientation.Horizontal)
				{
					item.LeftInternal += num;
				}
				else
				{
					item.TopInternal += num;
				}
			}
		}
	}

	protected virtual void CreateMoreItemsButton(bool isRightToLeft)
	{
		if (m_MoreItems == null)
		{
			m_MoreItems = new DisplayMoreItem();
			m_MoreItems.Style = m_Style;
			m_MoreItems.SetParent(this);
			m_MoreItems.ThemeAware = ThemeAware;
		}
		if (bool_22)
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

	protected virtual Point GetMoreItemsLocation(bool isRightToLeft)
	{
		if (m_MoreItems == null)
		{
			return Point.Empty;
		}
		Point empty = Point.Empty;
		if (m_Orientation == eOrientation.Vertical)
		{
			empty.X = m_Rect.Left + m_PaddingLeft;
			empty.Y = m_Rect.Bottom - m_MoreItems.HeightInternal - m_PaddingBottom;
		}
		else
		{
			if (isRightToLeft)
			{
				empty.X = m_Rect.X + m_PaddingLeft;
			}
			else
			{
				empty.X = m_Rect.Right - m_MoreItems.WidthInternal - m_PaddingRight;
			}
			empty.Y = m_Rect.Top + m_PaddingTop;
		}
		return empty;
	}

	public override void SubItemSizeChanged(BaseItem objChildItem)
	{
		NeedRecalcSize = true;
		if (Displayed)
		{
			if (m_Parent == null)
			{
				if (ContainerControl is Bar)
				{
					((Bar)ContainerControl).RecalcLayout();
				}
				else if (ContainerControl is MenuPanel)
				{
					((MenuPanel)ContainerControl).RecalcSize();
				}
			}
			else
			{
				m_Parent.SubItemSizeChanged(this);
			}
		}
		else if (m_Parent == null)
		{
			RecalcSize();
		}
		else
		{
			m_Parent.SubItemSizeChanged(this);
		}
	}

	public override void InternalMouseHover()
	{
		if (m_MoreItems != null && m_MoreItems.Expanded && m_HotSubItem != m_MoreItems && DesignMode)
		{
			m_MoreItems.Expanded = false;
		}
		base.InternalMouseHover();
	}

	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		if (m_MoreItems != null && m_MoreItems.Expanded && m_HotSubItem != m_MoreItems && !DesignMode)
		{
			m_MoreItems.Expanded = false;
		}
		base.InternalMouseDown(objArg);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		base.InternalMouseUp(objArg);
		if (m_HotSubItem == null && (IsOnMenuBar || LayoutType == eLayoutType.Toolbar))
		{
			BaseItem baseItem = ExpandedItem();
			if (baseItem != null && baseItem is PopupItem)
			{
				baseItem.InternalMouseUp(objArg);
			}
		}
	}

	public override void InternalMouseMove(MouseEventArgs objArg)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		if (bool_29)
		{
			if (mouseEventArgs_0 == null)
			{
				mouseEventArgs_0 = new MouseEventArgs(objArg.get_Button(), objArg.get_Clicks(), objArg.get_X(), objArg.get_Y(), objArg.get_Delta());
				return;
			}
			if (mouseEventArgs_0.get_X() == objArg.get_X() && mouseEventArgs_0.get_Y() == objArg.get_Y() && mouseEventArgs_0.get_Button() == objArg.get_Button())
			{
				return;
			}
			bool_29 = false;
			mouseEventArgs_0 = null;
		}
		if (m_MoreItems != null && m_MoreItems.DisplayRectangle.Contains(objArg.get_X(), objArg.get_Y()) && !DesignMode)
		{
			BaseItem moreItems = m_MoreItems;
			if (moreItems != m_HotSubItem)
			{
				if (m_HotSubItem != null)
				{
					m_HotSubItem.InternalMouseLeave();
					if (moreItems != null && m_HotSubItem.Expanded)
					{
						m_HotSubItem.Expanded = false;
					}
				}
				if (moreItems != null)
				{
					if (m_AutoExpand)
					{
						BaseItem baseItem = ExpandedItem();
						if (baseItem != null && baseItem != moreItems)
						{
							baseItem.Expanded = false;
						}
					}
					moreItems.InternalMouseEnter();
					moreItems.InternalMouseMove(objArg);
					if (m_AutoExpand && moreItems.method_2() && moreItems.ShowSubItems)
					{
						if (moreItems is PopupItem)
						{
							PopupItem popupItem = moreItems as PopupItem;
							ePopupAnimation popupAnimation = popupItem.PopupAnimation;
							popupItem.PopupAnimation = ePopupAnimation.None;
							moreItems.Expanded = true;
							popupItem.PopupAnimation = popupAnimation;
						}
						else
						{
							moreItems.Expanded = true;
						}
					}
					m_HotSubItem = moreItems;
				}
				else
				{
					m_HotSubItem = null;
				}
			}
			else if (m_HotSubItem != null)
			{
				m_HotSubItem.InternalMouseMove(objArg);
			}
		}
		else
		{
			bool isOnMenuBar;
			if (!(isOnMenuBar = IsOnMenuBar) && LayoutType != 0)
			{
				m_CheckMouseMovePressed = false;
			}
			else
			{
				ExpandedItem()?.InternalMouseMove(objArg);
				m_CheckMouseMovePressed = true;
			}
			if ((int)objArg.get_Button() == 0 || DesignMode || isOnMenuBar || LayoutType == eLayoutType.Toolbar)
			{
				base.InternalMouseMove(objArg);
			}
		}
	}

	public override void InternalKeyDown(KeyEventArgs objArg)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Invalid comparison between Unknown and I4
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		base.InternalKeyDown(objArg);
		if (SubItems.Count == 0 || objArg.get_Handled())
		{
			return;
		}
		BaseItem baseItem = ExpandedItem();
		if (baseItem != null)
		{
			baseItem.InternalKeyDown(objArg);
			if (objArg.get_Handled())
			{
				return;
			}
		}
		if ((int)objArg.get_KeyCode() != 39 && (int)objArg.get_KeyCode() != 9 && (int)objArg.get_KeyCode() != 37)
		{
			if ((int)objArg.get_KeyCode() == 27)
			{
				if (baseItem != null)
				{
					baseItem.Expanded = false;
					objArg.set_Handled(true);
					return;
				}
				object containerControl = ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val is Bar)
				{
					Bar bar = val as Bar;
					if (bar.BarState == eBarState.Popup)
					{
						bar.ParentItem.Expanded = false;
					}
					else if (AutoExpand)
					{
						AutoExpand = false;
					}
					else if (((Control)bar).get_Focused() || bar.Boolean_11)
					{
						bar.Boolean_11 = false;
						bar.ReleaseFocus();
					}
					objArg.set_Handled(true);
				}
				else if (val is ItemControl)
				{
					ItemControl itemControl = val as ItemControl;
					if (AutoExpand)
					{
						AutoExpand = false;
					}
					else if (((Control)itemControl).get_Focused() || itemControl.Boolean_3)
					{
						itemControl.Boolean_3 = false;
						itemControl.ReleaseFocus();
					}
				}
				return;
			}
			BaseItem baseItem2 = ExpandedItem();
			if (baseItem2 != null)
			{
				baseItem2.InternalKeyDown(objArg);
				return;
			}
			int num = 0;
			if (objArg.get_Shift())
			{
				try
				{
					byte[] array = new byte[256];
					if (Class92.GetKeyboardState(array))
					{
						byte[] array2 = new byte[2];
						if (Class92.ToAscii((uint)objArg.get_KeyValue(), 0u, array, array2, 0u) != 0)
						{
							num = array2[0];
						}
					}
				}
				catch (Exception)
				{
					num = 0;
				}
			}
			if (num == 0)
			{
				num = (int)Class92.MapVirtualKey((uint)objArg.get_KeyValue(), 2u);
			}
			bool flag = false;
			if (num > 0)
			{
				flag = method_26(num);
			}
			if (flag)
			{
				objArg.set_Handled(true);
			}
			if (!flag && m_HotSubItem != null)
			{
				m_HotSubItem.InternalKeyDown(objArg);
			}
			return;
		}
		bool_29 = true;
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalMouseLeave();
			if (m_AutoExpand && m_HotSubItem.Expanded)
			{
				m_HotSubItem.Expanded = false;
			}
		}
		if ((int)objArg.get_KeyCode() == 37)
		{
			int num2 = 0;
			if (m_HotSubItem != null)
			{
				num2 = SubItems.IndexOf(m_HotSubItem) - 1;
			}
			if (num2 < 0)
			{
				num2 = SubItems.Count - 1;
			}
			BaseItem baseItem3 = null;
			bool flag2 = false;
			do
			{
				int num3 = num2;
				while (num3 >= 0)
				{
					baseItem3 = SubItems[num3];
					if (!baseItem3.Visible || !baseItem3.method_2())
					{
						num3--;
						continue;
					}
					num2 = num3;
					break;
				}
				if (SubItems[num2].Visible && SubItems[num2].method_2())
				{
					flag2 = false;
				}
				else if (!flag2)
				{
					num2 = SubItems.Count - 1;
					flag2 = true;
				}
				else
				{
					flag2 = false;
				}
			}
			while (flag2);
			m_HotSubItem = SubItems[num2];
		}
		else
		{
			int i = 0;
			if (m_HotSubItem != null)
			{
				i = SubItems.IndexOf(m_HotSubItem) + 1;
			}
			for (; i < SubItems.Count && (!SubItems[i].Visible || !SubItems[i].method_2()); i++)
			{
			}
			if (i >= SubItems.Count)
			{
				i = 0;
			}
			BaseItem baseItem4 = null;
			for (int j = i; j < SubItems.Count; j++)
			{
				baseItem4 = SubItems[j];
				if (baseItem4.Visible && baseItem4.method_2())
				{
					i = j;
					break;
				}
			}
			m_HotSubItem = SubItems[i];
		}
		m_HotSubItem.InternalMouseEnter();
		m_HotSubItem.InternalMouseMove(new MouseEventArgs((MouseButtons)0, 0, m_HotSubItem.LeftInternal + 2, m_HotSubItem.TopInternal + 2, 0));
		BaseItem baseItem5 = ExpandedItem();
		if (baseItem5 != null && baseItem5 != m_HotSubItem)
		{
			baseItem5.Expanded = false;
		}
		if (m_AutoExpand && m_HotSubItem.ShowSubItems && (IsOnMenuBar || (base.IsOnMenu && m_HotSubItem.SubItems.Count > 0)))
		{
			m_HotSubItem.Expanded = true;
			if (m_HotSubItem is PopupItem && ((PopupItem)m_HotSubItem).PopupControl is MenuPanel)
			{
				((MenuPanel)(object)((PopupItem)m_HotSubItem).PopupControl).method_21();
			}
		}
		objArg.set_Handled(true);
	}

	private bool method_26(int int_9)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		char[] array = new char[1];
		byte[] array2 = new byte[1];
		try
		{
			array2[0] = Convert.ToByte(int_9);
			Encoding.Default.GetDecoder().GetChars(array2, 0, 1, array, 0);
		}
		catch (Exception)
		{
			return false;
		}
		string text = array[0].ToString();
		if (text == "")
		{
			return false;
		}
		array[0] = text.ToLower()[0];
		BaseItem baseItem = ExpandedItem();
		if (baseItem != null && baseItem is PopupItem && ((PopupItem)baseItem).PopupType == ePopupType.Menu)
		{
			KeyEventArgs val = new KeyEventArgs((Keys)int_9);
			baseItem.InternalKeyDown(val);
			if (val.get_Handled())
			{
				bool_29 = true;
				return true;
			}
		}
		foreach (BaseItem subItem in SubItems)
		{
			if (!subItem.Visible || !subItem.method_2() || !subItem.Displayed || subItem.AccessKey != array[0] || (subItem is ButtonItem && ((ButtonItem)subItem).ButtonStyle == eButtonStyle.Default && !IsOnMenuBar && !base.IsOnMenu))
			{
				continue;
			}
			if (subItem.SubItems.Count > 0 && subItem.ShowSubItems && subItem.method_2())
			{
				if (subItem.Expanded)
				{
					subItem.InternalKeyDown(new KeyEventArgs((Keys)int_9));
				}
				else
				{
					method_28(subItem);
				}
			}
			else
			{
				subItem.RaiseClick();
			}
			bool_29 = true;
			return true;
		}
		return false;
	}

	internal bool method_27(int int_9)
	{
		return method_26(int_9);
	}

	private void method_28(BaseItem baseItem_0)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val is Bar && !val.get_Focused())
		{
			((Bar)(object)val).Boolean_11 = true;
		}
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalMouseLeave();
		}
		m_HotSubItem = baseItem_0;
		baseItem_0.InternalMouseEnter();
		baseItem_0.InternalMouseMove(new MouseEventArgs((MouseButtons)0, 0, baseItem_0.LeftInternal + 2, baseItem_0.TopInternal + 2, 0));
		baseItem_0.Expanded = true;
		if (baseItem_0 is PopupItem)
		{
			AutoExpand = true;
			PopupItem popupItem = baseItem_0 as PopupItem;
			if (popupItem.PopupType == ePopupType.Menu && popupItem.PopupControl is MenuPanel)
			{
				((MenuPanel)(object)popupItem.PopupControl).method_21();
			}
		}
	}

	public override void ContainerLostFocus(bool appLostFocus)
	{
		base.ContainerLostFocus(appLostFocus);
		if (m_MoreItems != null)
		{
			m_MoreItems.ContainerLostFocus(appLostFocus);
		}
		IOwnerMenuSupport ownerMenuSupport = GetOwner() as IOwnerMenuSupport;
		if (IsOnMenuBar && ownerMenuSupport != null)
		{
			ownerMenuSupport.PersonalizedAllVisible = false;
		}
	}

	protected override void OnOwnerChanged()
	{
		base.OnOwnerChanged();
		if (GetOwner() is Bar)
		{
			RefreshImageSize();
		}
	}

	protected internal override void OnSubItemExpandChange(BaseItem objItem)
	{
		base.OnSubItemExpandChange(objItem);
		if (!objItem.Expanded)
		{
			return;
		}
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem != objItem && subItem is PopupItem && subItem.Expanded)
			{
				subItem.Expanded = false;
			}
		}
	}

	internal void method_29()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		if (m_HotSubItem != null || SubItems.Count == 0)
		{
			return;
		}
		BaseItem baseItem = ExpandedItem();
		if (baseItem != null)
		{
			m_HotSubItem = baseItem;
			m_HotSubItem.InternalMouseEnter();
			m_HotSubItem.InternalMouseMove(new MouseEventArgs((MouseButtons)0, 0, m_HotSubItem.LeftInternal + 2, m_HotSubItem.TopInternal + 2, 0));
			return;
		}
		foreach (BaseItem subItem in SubItems)
		{
			if (!subItem.SystemItem && subItem.Displayed && subItem.Visible)
			{
				m_HotSubItem = subItem;
				m_HotSubItem.InternalMouseEnter();
				m_HotSubItem.InternalMouseMove(new MouseEventArgs((MouseButtons)0, 0, m_HotSubItem.LeftInternal + 2, m_HotSubItem.TopInternal + 2, 0));
				break;
			}
		}
	}

	internal void method_30()
	{
		BaseItem.CollapseSubItems(this);
		if (m_HotSubItem == null)
		{
			return;
		}
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null)
		{
			Point pt = val.PointToClient(Control.get_MousePosition());
			if (m_HotSubItem.DisplayRectangle.Contains(pt))
			{
				return;
			}
		}
		m_HotSubItem.InternalMouseLeave();
		m_HotSubItem = null;
	}

	protected internal override void OnItemAdded(BaseItem objItem)
	{
		base.OnItemAdded(objItem);
		if (eventHandler_14 != null)
		{
			eventHandler_14(objItem, new EventArgs());
		}
		if (objItem is CustomizeItem)
		{
			bool_25 = true;
		}
		else if (SystemContainer && objItem is DockContainerItem && ContainerControl is Bar bar && bar.LayoutType == eLayoutType.DockContainer)
		{
			if (base.VisibleSubItems > 1)
			{
				objItem.Displayed = false;
			}
			bar.method_120(bool_67: true);
		}
	}

	protected internal override void OnAfterItemRemoved(BaseItem objItem)
	{
		base.OnAfterItemRemoved(objItem);
		if (objItem is CustomizeItem)
		{
			bool_25 = false;
		}
		else if (SystemContainer && ContainerControl is Bar bar)
		{
			bar.method_123(objItem);
		}
	}

	protected internal override bool IsAnyOnHandle(int iHandle)
	{
		if (m_MoreItems != null && m_MoreItems.IsAnyOnHandle(iHandle))
		{
			return true;
		}
		return base.IsAnyOnHandle(iHandle);
	}

	public override BaseItem ItemAtLocation(int x, int y)
	{
		if (m_SubItems != null)
		{
			foreach (BaseItem subItem in m_SubItems)
			{
				if (subItem.IsContainer)
				{
					BaseItem baseItem2 = subItem.ItemAtLocation(x, y);
					if (baseItem2 != null)
					{
						return baseItem2;
					}
				}
				else if ((subItem.Visible || base.IsOnCustomizeMenu) && subItem.Displayed && subItem.DisplayRectangle.Contains(x, y))
				{
					return subItem;
				}
			}
		}
		return null;
	}

	public InsertPosition GetInsertPosition(Point pScreen, BaseItem DragItem)
	{
		return DesignTimeProviderContainer.GetInsertPosition(this, pScreen, DragItem);
	}

	public void DrawReversibleMarker(int iPos, bool Before)
	{
		DesignTimeProviderContainer.DrawReversibleMarker(this, iPos, Before);
	}

	public void InsertItemAt(BaseItem objItem, int iPos, bool Before)
	{
		DesignTimeProviderContainer.InsertItemAt(this, objItem, iPos, Before);
	}

	private int method_31(BaseItem baseItem_0)
	{
		int result = -1;
		int num = baseItem_0.SubItems.Count - 1;
		while (num >= 0 && baseItem_0.SubItems[num].SystemItem)
		{
			result = num;
			num--;
		}
		return result;
	}
}
