using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.Controls;

[ToolboxBitmap(typeof(DataGridViewX), "Controls.DataGridViewX.bmp")]
public class DataGridViewX : DataGridView
{
	private struct Struct13
	{
		public bool bool_0;

		public int int_0;
	}

	private int int_0 = -2;

	private int int_1 = -2;

	private int int_2 = -2;

	private int int_3 = -2;

	private bool bool_0 = true;

	private Office2007DataGridViewColorTable office2007DataGridViewColorTable_0;

	private Office2007ButtonItemStateColorTable office2007ButtonItemStateColorTable_0;

	private Struct13[] struct13_0 = new Struct13[1];

	private int int_4 = -2;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private bool bool_3 = true;

	[Browsable(true)]
	[Category("Behavior")]
	[Description("Indicates whether selected column header is highlighted.")]
	[DefaultValue(true)]
	public bool HighlightSelectedColumnHeaders
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			if (Class109.smethod_11((Control)(object)this))
			{
				((Control)this).Invalidate();
			}
		}
	}

	[Category("Behavior")]
	[Browsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether select all sign displayed in top-left corner of the grid is visible.")]
	public bool SelectAllSignVisible
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			if (Class109.smethod_11((Control)(object)this))
			{
				((Control)this).Invalidate();
			}
		}
	}

	[Description("Indicates whether enhanced selection for the cells is painted in Office 2007 style")]
	[Category("Appearance")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool PaintEnhancedSelection
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			if (Class109.smethod_11((Control)(object)this))
			{
				((Control)this).Invalidate();
			}
		}
	}

	public DataGridViewX()
	{
		method_6();
	}

	protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Invalid comparison between Unknown and I4
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Invalid comparison between Unknown and I4
		bool enabled = ((Control)this).get_Enabled();
		Office2007DataGridViewColorTable colorTable = GetColorTable();
		if (bool_0 && colorTable != null && !((HandledEventArgs)(object)e).Handled && (e.get_ColumnIndex() < 0 || e.get_RowIndex() < 0 || (bool_3 && (e.get_State() & 0x20) == 32)))
		{
			Rectangle cellBounds = e.get_CellBounds();
			Graphics graphics = e.get_Graphics();
			LinearGradientColorTable linearGradientColorTable = null;
			Color empty = Color.Empty;
			DataGridViewColumn val = null;
			int num = -1;
			if (e.get_ColumnIndex() >= 0)
			{
				val = ((DataGridView)this).get_Columns().get_Item(e.get_ColumnIndex());
				num = val.get_DisplayIndex();
			}
			if (e.get_ColumnIndex() == -1 && e.get_RowIndex() == -1)
			{
				if (int_0 == -1)
				{
					linearGradientColorTable = colorTable.SelectorMouseOverBackground;
					empty = colorTable.SelectorMouseOverBorder;
				}
				else
				{
					linearGradientColorTable = colorTable.SelectorBackground;
					empty = colorTable.SelectorBorder;
				}
				Class50.smethod_25(graphics, cellBounds, linearGradientColorTable);
				Class50.smethod_6(graphics, empty, cellBounds);
				empty = ((int_0 != -1) ? colorTable.SelectorBorderLight : colorTable.SelectorMouseOverBorderLight);
				Rectangle rectangle_ = cellBounds;
				rectangle_.Inflate(-1, -1);
				Pen val2 = new Pen(empty);
				try
				{
					graphics.DrawLine(val2, rectangle_.X, rectangle_.Bottom - 1, rectangle_.X, rectangle_.Y);
					graphics.DrawLine(val2, rectangle_.X, rectangle_.Y, rectangle_.Right - 1, rectangle_.Y);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				empty = ((int_0 != -1) ? colorTable.SelectorBorderDark : colorTable.SelectorMouseOverBorderDark);
				Pen val3 = new Pen(empty);
				try
				{
					graphics.DrawLine(val3, rectangle_.Right - 1, rectangle_.Y, rectangle_.Right - 1, rectangle_.Bottom - 1);
					graphics.DrawLine(val3, rectangle_.X, rectangle_.Bottom - 1, rectangle_.Right - 1, rectangle_.Bottom - 1);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
				if (bool_2)
				{
					GraphicsPath val4 = method_0(rectangle_);
					if (val4 != null)
					{
						Class50.smethod_29(graphics, val4, (int_0 == -1) ? colorTable.SelectorMouseOverSign : colorTable.SelectorSign);
						val4.Dispose();
					}
				}
			}
			else if (e.get_ColumnIndex() == -1)
			{
				linearGradientColorTable = colorTable.RowNormalBackground;
				empty = colorTable.RowNormalBorder;
				if (int_2 == e.get_RowIndex())
				{
					linearGradientColorTable = colorTable.RowPressedBackground;
					empty = colorTable.RowPressedBorder;
				}
				else if (int_4 == e.get_RowIndex() && enabled)
				{
					if (int_3 == e.get_RowIndex())
					{
						linearGradientColorTable = colorTable.RowSelectedMouseOverBackground;
						empty = colorTable.RowSelectedMouseOverBorder;
					}
					else
					{
						linearGradientColorTable = colorTable.RowSelectedBackground;
						empty = colorTable.RowSelectedBorder;
					}
				}
				else if (((DataGridViewBand)((DataGridView)this).get_Rows().get_Item(e.get_RowIndex())).get_Selected() && enabled)
				{
					if (int_3 == e.get_RowIndex())
					{
						linearGradientColorTable = colorTable.RowPressedBackground;
						empty = colorTable.RowPressedBorder;
					}
					else
					{
						linearGradientColorTable = colorTable.RowPressedBackground;
						empty = colorTable.RowPressedBorder;
					}
				}
				else if (int_3 == e.get_RowIndex())
				{
					linearGradientColorTable = colorTable.RowMouseOverBackground;
					empty = colorTable.RowMouseOverBorder;
				}
				Class50.smethod_25(graphics, cellBounds, linearGradientColorTable);
				Pen val5 = new Pen(empty);
				try
				{
					graphics.DrawLine(val5, cellBounds.Right - 1, cellBounds.Y, cellBounds.Right - 1, cellBounds.Bottom - 1);
					if (int_4 == e.get_RowIndex() + 1 && enabled)
					{
						Color color = colorTable.RowSelectedBorder;
						if (int_2 == e.get_RowIndex() + 1)
						{
							color = colorTable.RowPressedBorder;
						}
						else if (int_3 == e.get_RowIndex() + 1)
						{
							color = colorTable.RowSelectedMouseOverBorder;
						}
						Pen val6 = new Pen(color);
						try
						{
							graphics.DrawLine(val6, cellBounds.X, cellBounds.Bottom - 1, cellBounds.Right - 1, cellBounds.Bottom - 1);
						}
						finally
						{
							((IDisposable)val6)?.Dispose();
						}
					}
					else
					{
						graphics.DrawLine(val5, cellBounds.X, cellBounds.Bottom - 1, cellBounds.Right - 1, cellBounds.Bottom - 1);
					}
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
				e.PaintContent(cellBounds);
			}
			else if (e.get_RowIndex() == -1)
			{
				if (int_1 == e.get_ColumnIndex())
				{
					linearGradientColorTable = colorTable.ColumnHeaderPressedBackground;
					empty = colorTable.ColumnHeaderPressedBorder;
				}
				else if (int_0 == e.get_ColumnIndex())
				{
					if (bool_1 && num >= 0 && e.get_ColumnIndex() >= 0 && ((struct13_0.Length > num && struct13_0[num].bool_0) || ((DataGridViewBand)((DataGridView)this).get_Columns().get_Item(e.get_ColumnIndex())).get_Selected()))
					{
						linearGradientColorTable = colorTable.ColumnHeaderSelectedMouseOverBackground;
						empty = colorTable.ColumnHeaderSelectedMouseOverBorder;
					}
					else
					{
						linearGradientColorTable = colorTable.ColumnHeaderMouseOverBackground;
						empty = colorTable.ColumnHeaderMouseOverBorder;
					}
				}
				else if (!bool_1)
				{
					linearGradientColorTable = colorTable.ColumnHeaderNormalBackground;
					empty = colorTable.ColumnHeaderNormalBorder;
				}
				else if (num >= 0 && e.get_ColumnIndex() >= 0 && ((struct13_0.Length > num && struct13_0[num].bool_0) || ((DataGridViewBand)((DataGridView)this).get_Columns().get_Item(e.get_ColumnIndex())).get_Selected()) && enabled)
				{
					linearGradientColorTable = colorTable.ColumnHeaderSelectedBackground;
					empty = colorTable.ColumnHeaderSelectedBorder;
				}
				else if (((DataGridViewBand)((DataGridView)this).get_Columns().get_Item(e.get_ColumnIndex())).get_Selected() && enabled)
				{
					linearGradientColorTable = colorTable.ColumnHeaderPressedBackground;
					empty = colorTable.ColumnHeaderPressedBorder;
				}
				else
				{
					linearGradientColorTable = colorTable.ColumnHeaderNormalBackground;
					empty = colorTable.ColumnHeaderNormalBorder;
				}
				Class50.smethod_25(graphics, cellBounds, linearGradientColorTable);
				Pen val7 = new Pen(empty);
				try
				{
					graphics.DrawLine(val7, cellBounds.X, cellBounds.Bottom - 1, cellBounds.Right - 1, cellBounds.Bottom - 1);
					if (enabled && bool_1 && num >= 0 && struct13_0.Length > num + 1 && (struct13_0[num + 1].bool_0 || struct13_0[num + 1].int_0 == int_1))
					{
						Color color2 = colorTable.ColumnHeaderSelectedBorder;
						if (struct13_0[num + 1].int_0 == int_1)
						{
							color2 = colorTable.ColumnHeaderPressedBorder;
						}
						else if (int_0 == num + 1)
						{
							color2 = colorTable.ColumnHeaderSelectedMouseOverBorder;
						}
						Pen val8 = new Pen(color2);
						try
						{
							graphics.DrawLine(val8, cellBounds.Right - 1, cellBounds.Y, cellBounds.Right - 1, cellBounds.Bottom - 1);
						}
						finally
						{
							((IDisposable)val8)?.Dispose();
						}
					}
					else
					{
						graphics.DrawLine(val7, cellBounds.Right - 1, cellBounds.Y, cellBounds.Right - 1, cellBounds.Bottom - 1);
					}
				}
				finally
				{
					((IDisposable)val7)?.Dispose();
				}
				e.PaintContent(cellBounds);
			}
			else if ((e.get_State() & 0x20) == 32)
			{
				e.PaintBackground(cellBounds, false);
				if (enabled)
				{
					cellBounds.Height--;
					Class268.smethod_6(graphics, office2007ButtonItemStateColorTable_0, cellBounds, RoundRectangleShapeDescriptor.RectangleShape, bool_0: false, bool_1: false);
					cellBounds.Height++;
					if (((DataGridView)this).get_CurrentCellAddress().X == e.get_ColumnIndex() && ((DataGridView)this).get_CurrentCellAddress().Y == e.get_RowIndex() && (e.get_PaintParts() & 0x20) == 32 && ((Control)this).get_ShowFocusCues() && ((Control)this).get_Focused() && cellBounds.Width > 0 && cellBounds.Height > 0)
					{
						ControlPaint.DrawFocusRectangle(graphics, cellBounds, Color.Empty, office2007ButtonItemStateColorTable_0.TopBackground.End);
					}
				}
				e.PaintContent(cellBounds);
			}
			((HandledEventArgs)(object)e).Handled = true;
			((DataGridView)this).OnCellPainting(e);
		}
		else
		{
			((DataGridView)this).OnCellPainting(e);
		}
	}

	private GraphicsPath method_0(Rectangle rectangle_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		rectangle_0.Inflate(-3, -3);
		if (rectangle_0.Width > 2 && rectangle_0.Height > 2)
		{
			GraphicsPath val = new GraphicsPath();
			val.AddLine(rectangle_0.Right, rectangle_0.Y, rectangle_0.Right, rectangle_0.Bottom);
			val.AddLine(rectangle_0.Right, rectangle_0.Bottom, rectangle_0.Right - rectangle_0.Height, rectangle_0.Bottom);
			val.CloseAllFigures();
			return val;
		}
		return null;
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			Office2007DataGridViewColorTable dataGridView = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.DataGridView;
			method_1(dataGridView);
		}
		((DataGridView)this).OnHandleCreated(e);
	}

	private void method_1(Office2007DataGridViewColorTable office2007DataGridViewColorTable_1)
	{
		if (((DataGridView)this).get_GridColor() != office2007DataGridViewColorTable_1.GridColor)
		{
			((DataGridView)this).set_GridColor(office2007DataGridViewColorTable_1.GridColor);
		}
		if (bool_3)
		{
			((DataGridView)this).get_DefaultCellStyle().set_SelectionForeColor(((DataGridView)this).get_DefaultCellStyle().get_ForeColor());
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		Office2007ColorTable office2007ColorTable = null;
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			office2007ColorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
			office2007DataGridViewColorTable_0 = office2007ColorTable.DataGridView;
			office2007ButtonItemStateColorTable_0 = office2007ColorTable.ButtonItemColors[0].Checked;
		}
		if (((DataGridView)this).get_CurrentCell() != null)
		{
			int_4 = ((DataGridView)this).get_CurrentCell().get_RowIndex();
		}
		else
		{
			int_4 = -1;
		}
		((DataGridView)this).OnPaint(e);
		if (((Control)((DataGridView)this).get_VerticalScrollBar()).get_Visible() && ((Control)((DataGridView)this).get_HorizontalScrollBar()).get_Visible())
		{
			Rectangle rectangle_ = new Rectangle(((Control)((DataGridView)this).get_VerticalScrollBar()).get_Left(), ((Control)((DataGridView)this).get_VerticalScrollBar()).get_Bottom(), ((Control)((DataGridView)this).get_VerticalScrollBar()).get_Width(), ((Control)((DataGridView)this).get_HorizontalScrollBar()).get_Height());
			Color color_ = office2007ColorTable.AppScrollBar.Default.Background.End;
			if (color_.IsEmpty)
			{
				color_ = office2007ColorTable.AppScrollBar.Default.Background.Start;
			}
			Class50.smethod_23(e.get_Graphics(), rectangle_, color_);
		}
		office2007DataGridViewColorTable_0 = null;
		office2007ButtonItemStateColorTable_0 = null;
	}

	protected override void OnCurrentCellChanged(EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((DataGridView)this).get_SelectionMode() == 1)
		{
			method_2();
		}
		((DataGridView)this).OnCurrentCellChanged(e);
	}

	protected override void OnSelectionChanged(EventArgs e)
	{
		method_2();
		((DataGridView)this).OnSelectionChanged(e);
	}

	protected override void OnDataSourceChanged(EventArgs e)
	{
		((DataGridView)this).OnDataSourceChanged(e);
		method_2();
	}

	private void method_2()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		Struct13[] array = new Struct13[((BaseCollection)((DataGridView)this).get_Columns()).get_Count()];
		for (int i = 0; i < ((BaseCollection)((DataGridView)this).get_Columns()).get_Count(); i++)
		{
			array[((DataGridView)this).get_Columns().get_Item(i).get_DisplayIndex()].int_0 = i;
		}
		int num = ((BaseCollection)((DataGridView)this).get_Columns()).get_Count();
		if ((int)((DataGridView)this).get_SelectionMode() == 1)
		{
			if (((DataGridView)this).get_CurrentCell() != null)
			{
				int displayIndex = ((DataGridView)this).get_Columns().get_Item(((DataGridView)this).get_CurrentCell().get_ColumnIndex()).get_DisplayIndex();
				array[displayIndex].bool_0 = true;
				array[displayIndex].int_0 = ((DataGridView)this).get_CurrentCell().get_ColumnIndex();
			}
		}
		else
		{
			foreach (DataGridViewCell item in (BaseCollection)((DataGridView)this).get_SelectedCells())
			{
				DataGridViewCell val = item;
				if (val.get_ColumnIndex() == -1)
				{
					continue;
				}
				int displayIndex2 = ((DataGridView)this).get_Columns().get_Item(val.get_ColumnIndex()).get_DisplayIndex();
				if (!array[displayIndex2].bool_0)
				{
					num--;
					array[displayIndex2].bool_0 = true;
					array[displayIndex2].int_0 = val.get_ColumnIndex();
					if (num == 0)
					{
						break;
					}
				}
			}
		}
		for (int j = 0; j < array.Length; j++)
		{
			if (struct13_0.Length > j && array[j].bool_0 != struct13_0[j].bool_0)
			{
				((DataGridView)this).InvalidateColumn(struct13_0[j].int_0);
				if (struct13_0[j].int_0 > 0)
				{
					((DataGridView)this).InvalidateColumn(struct13_0[j].int_0 - 1);
				}
			}
		}
		if (int_4 > 0 && int_4 < ((DataGridView)this).get_Rows().get_Count())
		{
			((DataGridView)this).InvalidateRow(int_4 - 1);
		}
		if (((DataGridView)this).get_CurrentCell() != null && ((DataGridView)this).get_CurrentCell().get_RowIndex() > 0)
		{
			int_4 = ((DataGridView)this).get_CurrentCell().get_RowIndex();
			((DataGridView)this).InvalidateRow(int_4 - 1);
		}
		else
		{
			int_4 = -2;
		}
		struct13_0 = array;
	}

	protected virtual Office2007DataGridViewColorTable GetColorTable()
	{
		return office2007DataGridViewColorTable_0;
	}

	protected override void OnCellMouseDown(DataGridViewCellMouseEventArgs e)
	{
		if (e.get_RowIndex() == -1)
		{
			int_1 = e.get_ColumnIndex();
			if (e.get_ColumnIndex() >= 0)
			{
				method_3(((DataGridView)this).get_Columns().get_Item(e.get_ColumnIndex()).get_DisplayIndex());
			}
		}
		else
		{
			int_1 = -2;
		}
		if (e.get_ColumnIndex() == -1)
		{
			int_2 = e.get_RowIndex();
			if (int_2 > 0 && int_2 < ((DataGridView)this).get_Rows().get_Count())
			{
				((DataGridView)this).InvalidateRow(int_2 - 1);
			}
		}
		else
		{
			int_2 = -2;
		}
		((DataGridView)this).OnCellMouseDown(e);
	}

	private void method_3(int int_5)
	{
		int_5--;
		int num = 0;
		while (true)
		{
			if (num < ((BaseCollection)((DataGridView)this).get_Columns()).get_Count())
			{
				DataGridViewColumn val = ((DataGridView)this).get_Columns().get_Item(num);
				if (((DataGridViewBand)val).get_Displayed() && val.get_DisplayIndex() == int_5)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		((DataGridView)this).InvalidateColumn(num);
	}

	protected override void OnCellMouseUp(DataGridViewCellMouseEventArgs e)
	{
		if (int_2 > 0 && int_2 < ((DataGridView)this).get_Rows().get_Count())
		{
			((DataGridView)this).InvalidateRow(int_2 - 1);
		}
		if (int_2 >= 0)
		{
			((DataGridView)this).InvalidateRow(int_2);
		}
		int_2 = -2;
		int_1 = -2;
		((DataGridView)this).OnCellMouseUp(e);
	}

	protected override void OnCellMouseEnter(DataGridViewCellEventArgs e)
	{
		if (e.get_RowIndex() == -1)
		{
			int_0 = e.get_ColumnIndex();
		}
		else
		{
			int_0 = -2;
		}
		if (e.get_ColumnIndex() == -1)
		{
			if (int_3 != e.get_RowIndex())
			{
				int_3 = e.get_RowIndex();
				if (int_3 > 0)
				{
					((DataGridView)this).InvalidateRow(int_3 - 1);
				}
			}
		}
		else
		{
			int_3 = -2;
		}
		((DataGridView)this).OnCellMouseEnter(e);
	}

	protected override void OnCellMouseLeave(DataGridViewCellEventArgs e)
	{
		int_0 = -2;
		int_3 = -2;
		((DataGridView)this).OnCellMouseLeave(e);
	}

	protected override void OnScroll(ScrollEventArgs e)
	{
		((DataGridView)this).OnScroll(e);
		Class190 @class = method_4();
		if (@class != null && ((Control)@class).get_Visible())
		{
			@class.method_0();
		}
		Class191 class2 = method_5();
		if (class2 != null && ((Control)class2).get_Visible())
		{
			class2.method_0();
		}
	}

	private Class190 method_4()
	{
		return ((DataGridView)this).get_VerticalScrollBar() as Class190;
	}

	private Class191 method_5()
	{
		return ((DataGridView)this).get_HorizontalScrollBar() as Class191;
	}

	private void method_6()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		Type typeFromHandle = typeof(DataGridView);
		FieldInfo field = typeFromHandle.GetField("vertScrollBar", BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)field == null)
		{
			return;
		}
		object? value = field.GetValue(this);
		ScrollBar val = (ScrollBar)((value is ScrollBar) ? value : null);
		if (val == null)
		{
			return;
		}
		MethodInfo method = typeFromHandle.GetMethod("DataGridViewVScrolled", BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)method == null)
		{
			return;
		}
		Class190 @class = new Class190();
		@class.Boolean_1 = true;
		((ScrollBar)@class).set_Minimum(val.get_Minimum());
		((ScrollBar)@class).set_Maximum(val.get_Maximum());
		((ScrollBar)@class).set_SmallChange(val.get_SmallChange());
		((ScrollBar)@class).set_LargeChange(val.get_LargeChange());
		((Control)@class).set_Top(((Control)val).get_Top());
		((Control)@class).set_AccessibleName(((Control)val).get_AccessibleName());
		((Control)@class).set_Left(((Control)val).get_Left());
		((Control)@class).set_Visible(((Control)val).get_Visible());
		((ScrollBar)@class).add_Scroll((ScrollEventHandler)Delegate.CreateDelegate(typeof(ScrollEventHandler), this, method));
		field.SetValue(this, @class);
		((Component)(object)val).Dispose();
		((Control)this).get_Controls().Remove((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)@class);
		field = typeFromHandle.GetField("horizScrollBar", BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)field == null)
		{
			return;
		}
		object? value2 = field.GetValue(this);
		val = (ScrollBar)((value2 is ScrollBar) ? value2 : null);
		if (val != null)
		{
			method = typeFromHandle.GetMethod("DataGridViewHScrolled", BindingFlags.Instance | BindingFlags.NonPublic);
			if ((object)method != null)
			{
				Class191 class2 = new Class191();
				class2.Boolean_1 = true;
				((ScrollBar)class2).set_Minimum(val.get_Minimum());
				((ScrollBar)class2).set_Maximum(val.get_Maximum());
				((ScrollBar)class2).set_SmallChange(val.get_SmallChange());
				((ScrollBar)class2).set_LargeChange(val.get_LargeChange());
				((Control)class2).set_Top(((Control)val).get_Top());
				((Control)class2).set_AccessibleName(((Control)val).get_AccessibleName());
				((Control)class2).set_Left(((Control)val).get_Left());
				((Control)class2).set_Visible(((Control)val).get_Visible());
				((Control)class2).set_RightToLeft(((Control)val).get_RightToLeft());
				((ScrollBar)class2).add_Scroll((ScrollEventHandler)Delegate.CreateDelegate(typeof(ScrollEventHandler), this, method));
				field.SetValue(this, class2);
				((Component)(object)val).Dispose();
				((Control)this).get_Controls().Remove((Control)(object)val);
				((Control)this).get_Controls().Add((Control)(object)class2);
			}
		}
	}
}
