using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.Controls;

[ToolboxBitmap(typeof(ListViewEx), "Controls.ListViewEx.ico")]
[ToolboxItem(true)]
public class ListViewEx : ListView, INonClientControl
{
	private class Class195 : NativeWindow
	{
		private ListViewEx listViewEx_0;

		private bool bool_0;

		private Point point_0 = Point.Empty;

		public Class195(ListViewEx parent)
		{
			listViewEx_0 = parent;
			IntPtr intPtr = new IntPtr(Class51.SendMessage(((Control)parent).get_Handle(), 4127, IntPtr.Zero, IntPtr.Zero));
			if (intPtr != IntPtr.Zero)
			{
				((NativeWindow)this).AssignHandle(intPtr);
			}
		}

		protected override void WndProc(ref Message m)
		{
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected O, but got Unknown
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Invalid comparison between Unknown and I4
			if (((Message)(ref m)).get_Msg() == 15)
			{
				Class51.PAINTSTRUCT ps = default(Class51.PAINTSTRUCT);
				IntPtr intPtr = Class51.BeginPaint(((Message)(ref m)).get_HWnd(), ref ps);
				try
				{
					Graphics val = Graphics.FromHdc(intPtr);
					try
					{
						Class51.RECT r = default(Class51.RECT);
						Class51.GetWindowRect(((Message)(ref m)).get_HWnd(), ref r);
						Rectangle rectangle = new Rectangle(0, 0, r.Width, r.Height);
						using BufferedBitmap bufferedBitmap = new BufferedBitmap(intPtr, rectangle);
						listViewEx_0.method_0(bufferedBitmap.Graphics, rectangle);
						IList list = listViewEx_0.method_9();
						int num = 0;
						foreach (ColumnHeader item in list)
						{
							ColumnHeader val2 = item;
							Rectangle rectangle2 = new Rectangle(num, 0, val2.get_Width(), r.Height);
							ListViewItemStates val3 = (ListViewItemStates)512;
							if (bool_0 && rectangle2.Contains(point_0))
							{
								Rectangle rectangle3 = rectangle2;
								rectangle3.Inflate(-6, 0);
								if (rectangle3.Contains(point_0))
								{
									val3 = (ListViewItemStates)(val3 | 1);
								}
							}
							listViewEx_0.method_3(new DrawListViewColumnHeaderEventArgs(bufferedBitmap.Graphics, rectangle2, val2.get_DisplayIndex(), val2, val3, SystemColors.ControlText, Color.Empty, ((Control)listViewEx_0).get_Font()));
							num += val2.get_Width();
						}
						bufferedBitmap.Render(val);
						return;
					}
					finally
					{
						val.Dispose();
					}
				}
				finally
				{
					Class51.EndPaint(((Message)(ref m)).get_HWnd(), ref ps);
				}
			}
			if (((Message)(ref m)).get_Msg() == 513)
			{
				if ((int)((ListView)listViewEx_0).get_HeaderStyle() == 2)
				{
					bool_0 = true;
					point_0 = new Point(Class51.smethod_4(((Message)(ref m)).get_LParam()), Class51.smethod_5(((Message)(ref m)).get_LParam()));
					Class51.RedrawWindow(((Message)(ref m)).get_HWnd(), IntPtr.Zero, IntPtr.Zero, Class51.RedrawWindowFlags.RDW_INVALIDATE);
				}
			}
			else if (((Message)(ref m)).get_Msg() == 514)
			{
				bool_0 = false;
				point_0 = Point.Empty;
			}
			else if (((Message)(ref m)).get_Msg() == 512 && bool_0)
			{
				point_0 = new Point(Class51.smethod_4(((Message)(ref m)).get_LParam()), Class51.smethod_5(((Message)(ref m)).get_LParam()));
			}
			((NativeWindow)this).WndProc(ref m);
		}
	}

	private struct Struct14
	{
		public Struct15 struct15_0;

		public int int_0;

		public IntPtr intptr_0;

		public Class51.RECT rect_0;

		public IntPtr intptr_1;

		public int int_1;

		public IntPtr intptr_2;
	}

	private struct Struct15
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public int int_0;
	}

	private Class188 class188_0;

	private ElementStyle elementStyle_0;

	private Class195 class195_0;

	private Office2007ListViewColorTable office2007ListViewColorTable_0;

	private Office2007CheckBoxColorTable office2007CheckBoxColorTable_0;

	private Size size_0 = new Size(13, 13);

	private Color color_0 = Color.Empty;

	private Point point_0 = Point.Empty;

	private bool bool_0 = true;

	private BaseRenderer baseRenderer_0;

	private BaseRenderer baseRenderer_1;

	private eRenderMode eRenderMode_0 = eRenderMode.Global;

	private ColorScheme colorScheme_0;

	[Category("Appearance")]
	[Description("Indicates item foreground color when control or item is disabled.")]
	public Color DisabledForeColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool HideSelection
	{
		get
		{
			return ((ListView)this).get_HideSelection();
		}
		set
		{
			((ListView)this).set_HideSelection(false);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool OwnerDraw
	{
		get
		{
			return ((ListView)this).get_OwnerDraw();
		}
		set
		{
			((ListView)this).set_OwnerDraw(value);
		}
	}

	[DefaultValue(eRenderMode.Global)]
	[Browsable(false)]
	public eRenderMode RenderMode
	{
		get
		{
			return eRenderMode_0;
		}
		set
		{
			if (eRenderMode_0 != value)
			{
				eRenderMode_0 = value;
				office2007ListViewColorTable_0 = null;
				((Control)this).Invalidate(true);
			}
		}
	}

	[DefaultValue(null)]
	[Browsable(false)]
	public BaseRenderer Renderer
	{
		get
		{
			return baseRenderer_1;
		}
		set
		{
			baseRenderer_1 = value;
			office2007ListViewColorTable_0 = null;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public BorderStyle BorderStyle
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((ListView)this).get_BorderStyle();
		}
		set
		{
		}
	}

	[Browsable(true)]
	[Description("Specifies the control border style. Default value has Class property set so the system style for the control is used.")]
	[Category("Style")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ElementStyle Border => elementStyle_0;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((ListView)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() & ~(createParams.get_ExStyle() & 0x200));
			return createParams;
		}
	}

	ElementStyle INonClientControl.BorderStyle => method_13();

	IntPtr INonClientControl.Handle => ((Control)this).get_Handle();

	int INonClientControl.Width => ((Control)this).get_Width();

	int INonClientControl.Height => ((Control)this).get_Height();

	bool INonClientControl.IsHandleCreated => ((Control)this).get_IsHandleCreated();

	Color INonClientControl.BackColor => ((Control)this).get_BackColor();

	virtual bool INonClientControl.Enabled
	{
		get
		{
			return ((Control)this).get_Enabled();
		}
		set
		{
			((Control)this).set_Enabled(value);
		}
	}

	public ListViewEx()
	{
		elementStyle_0 = new ElementStyle();
		elementStyle_0.Class = ElementStyleClassKeys.ListViewBorderKey;
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		class188_0 = new Class188(this, eScrollBarSkin.Optimized);
		OwnerDraw = true;
		((Control)this).set_DoubleBuffered(true);
		BorderStyle = (BorderStyle)0;
	}

	protected override void Dispose(bool disposing)
	{
		if (class188_0 != null)
		{
			class188_0.method_0();
			class188_0 = null;
		}
		if (elementStyle_0 != null)
		{
			elementStyle_0.StyleChanged -= elementStyle_0_StyleChanged;
		}
		((ListView)this).Dispose(disposing);
	}

	private void method_0(Graphics graphics_0, Rectangle rectangle_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		Office2007ListViewColorTable office2007ListViewColorTable = method_1();
		Class50.smethod_25(graphics_0, rectangle_0, office2007ListViewColorTable.ColumnBackground);
		Pen val = new Pen(office2007ListViewColorTable.Border);
		try
		{
			graphics_0.DrawLine(val, rectangle_0.X, rectangle_0.Bottom - 1, rectangle_0.Right, rectangle_0.Bottom - 1);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		class195_0 = new Class195(this);
		((ListView)this).OnHandleCreated(e);
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		if (class195_0 != null)
		{
			((NativeWindow)class195_0).ReleaseHandle();
			class195_0 = null;
		}
		((ListView)this).OnHandleDestroyed(e);
	}

	public void ResetHeaderHandler()
	{
		if (((Control)this).get_IsHandleCreated())
		{
			if (class195_0 != null)
			{
				((NativeWindow)class195_0).ReleaseHandle();
				class195_0 = null;
			}
			class195_0 = new Class195(this);
		}
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		if (Environment.OSVersion.Version.Major < 6 && ((Control)this).get_Visible())
		{
			Class51.PostMessage(((Control)this).get_Handle().ToInt32(), 288, 0, 0);
		}
		((Control)this).OnVisibleChanged(e);
	}

	public void ResetCachedColorTableReference()
	{
		office2007ListViewColorTable_0 = null;
		office2007CheckBoxColorTable_0 = null;
	}

	private Office2007ListViewColorTable method_1()
	{
		if (office2007ListViewColorTable_0 == null && GetRenderer() is Office2007Renderer office2007Renderer)
		{
			office2007ListViewColorTable_0 = office2007Renderer.ColorTable.ListViewEx;
		}
		return office2007ListViewColorTable_0;
	}

	private Office2007CheckBoxColorTable method_2()
	{
		if (office2007CheckBoxColorTable_0 == null && GetRenderer() is Office2007Renderer office2007Renderer)
		{
			office2007CheckBoxColorTable_0 = office2007Renderer.ColorTable.CheckBoxItem;
		}
		return office2007CheckBoxColorTable_0;
	}

	private void method_3(DrawListViewColumnHeaderEventArgs drawListViewColumnHeaderEventArgs_0)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected I4, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Invalid comparison between Unknown and I4
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = drawListViewColumnHeaderEventArgs_0.get_Graphics();
		Rectangle bounds = drawListViewColumnHeaderEventArgs_0.get_Bounds();
		Office2007ListViewColorTable office2007ListViewColorTable = method_1();
		Color color = office2007ListViewColorTable.ColumnBackground.Start;
		Color color2 = office2007ListViewColorTable.ColumnBackground.End;
		if ((drawListViewColumnHeaderEventArgs_0.get_State() & 1) == 1 && !color2.IsEmpty)
		{
			Color color3 = color;
			color = color2;
			color2 = color3;
		}
		Class50.smethod_26(graphics, bounds, color, color2, office2007ListViewColorTable.ColumnBackground.GradientAngle);
		Pen val = new Pen(office2007ListViewColorTable.Border);
		try
		{
			graphics.DrawLine(val, bounds.X, bounds.Bottom - 1, bounds.Right, bounds.Bottom - 1);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		Pen val2 = new Pen(office2007ListViewColorTable.ColumnSeparator);
		try
		{
			graphics.DrawLine(val2, bounds.Right - 1, bounds.Y + 3, bounds.Right - 1, bounds.Bottom - 4);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		TextFormatFlags val3 = (TextFormatFlags)262180;
		HorizontalAlignment textAlign = drawListViewColumnHeaderEventArgs_0.get_Header().get_TextAlign();
		switch (textAlign - 1)
		{
		case 0:
			val3 = (TextFormatFlags)(val3 | 2);
			break;
		case 1:
			val3 = (TextFormatFlags)(val3 | 1);
			break;
		}
		if (drawListViewColumnHeaderEventArgs_0.get_Header().get_ImageList() != null && (drawListViewColumnHeaderEventArgs_0.get_Header().get_ImageIndex() >= 0 || (drawListViewColumnHeaderEventArgs_0.get_Header().get_ImageKey() != null && drawListViewColumnHeaderEventArgs_0.get_Header().get_ImageKey().Length > 0)))
		{
			Image val4 = null;
			val4 = ((drawListViewColumnHeaderEventArgs_0.get_Header().get_ImageIndex() < 0) ? drawListViewColumnHeaderEventArgs_0.get_Header().get_ImageList().get_Images()
				.get_Item(drawListViewColumnHeaderEventArgs_0.get_Header().get_ImageKey()) : drawListViewColumnHeaderEventArgs_0.get_Header().get_ImageList().get_Images()
				.get_Item(drawListViewColumnHeaderEventArgs_0.get_Header().get_ImageIndex()));
			if (val4 != null)
			{
				Rectangle rectangle = new Rectangle(bounds.X + 2, bounds.Y + (bounds.Height - val4.get_Height()) / 2, val4.get_Width(), val4.get_Height());
				if ((int)((Control)this).get_RightToLeft() == 1)
				{
					rectangle.X = bounds.Right - rectangle.Width - 2;
					bounds.Width -= rectangle.Width + 2;
				}
				else
				{
					bounds.Width -= rectangle.Width;
					bounds.X += rectangle.Width;
				}
				graphics.DrawImage(val4, rectangle);
			}
		}
		method_4(graphics, drawListViewColumnHeaderEventArgs_0.get_Font(), drawListViewColumnHeaderEventArgs_0.get_ForeColor(), val3, drawListViewColumnHeaderEventArgs_0.get_Header().get_Text(), bounds);
	}

	protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
	{
		((ListView)this).OnDrawColumnHeader(e);
	}

	private void method_4(Graphics graphics_0, Font font_0, Color color_1, TextFormatFlags textFormatFlags_0, string string_0, Rectangle rectangle_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		int width = TextRenderer.MeasureText(" ", font_0).Width;
		rectangle_0.Inflate(-(width / 2), 0);
		TextRenderer.DrawText((IDeviceContext)(object)graphics_0, string_0, font_0, rectangle_0, color_1, textFormatFlags_0);
	}

	private void method_5(Graphics graphics_0, Rectangle rectangle_0, ListViewItem listViewItem_0, ListViewItemStates listViewItemStates_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Invalid comparison between Unknown and I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Invalid comparison between Unknown and I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Invalid comparison between Unknown and I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Invalid comparison between Unknown and I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Invalid comparison between Unknown and I4
		if (!((Control)this).get_Enabled())
		{
			return;
		}
		if ((int)listViewItemStates_0 == 0 && listViewItem_0.get_Selected() && (int)((ListView)this).get_View() == 1 && ((ListView)this).get_FullRowSelect() && ((Control)this).get_Focused())
		{
			rectangle_0.X++;
		}
		if (!listViewItem_0.get_BackColor().IsEmpty)
		{
			SolidBrush val = new SolidBrush(listViewItem_0.get_BackColor());
			try
			{
				graphics_0.FillRectangle((Brush)(object)val, rectangle_0);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		bool flag;
		if (flag = method_6(listViewItemStates_0, (ListViewItemStates)1) || ((int)listViewItemStates_0 == 0 && listViewItem_0.get_Selected()))
		{
			Office2007ListViewColorTable office2007ListViewColorTable = method_1();
			rectangle_0.Height--;
			rectangle_0.Width--;
			Pen val2 = new Pen(office2007ListViewColorTable.SelectionBorder);
			try
			{
				graphics_0.DrawRectangle(val2, rectangle_0);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			rectangle_0.Height++;
			rectangle_0.Width++;
			Rectangle rectangle_ = new Rectangle(rectangle_0.X, rectangle_0.Y + 1, rectangle_0.Width, rectangle_0.Height - 2);
			Class50.smethod_25(graphics_0, rectangle_, office2007ListViewColorTable.SelectionBackground);
		}
		else if (method_6(listViewItemStates_0, (ListViewItemStates)64) && ((ListView)this).get_HotTracking())
		{
			Office2007Renderer office2007Renderer = GetRenderer() as Office2007Renderer;
			Class268.smethod_4(graphics_0, office2007Renderer.ColorTable.ButtonItemColors[0].MouseOver, rectangle_0, RoundRectangleShapeDescriptor.RectangleShape);
		}
		if (method_6(listViewItemStates_0, (ListViewItemStates)16) && ((!method_6(listViewItemStates_0, (ListViewItemStates)64) && (int)((ListView)this).get_View() != 0) || flag))
		{
			Rectangle rectangle_2 = listViewItem_0.get_Bounds();
			if (((int)((ListView)this).get_View() == 1 && !((ListView)this).get_FullRowSelect()) || (int)((ListView)this).get_View() == 3)
			{
				rectangle_2 = listViewItem_0.GetBounds((ItemBoundsPortion)2);
			}
			else if ((int)((ListView)this).get_View() == 1 && ((ListView)this).get_FullRowSelect())
			{
				rectangle_2 = rectangle_0;
			}
			else if ((int)((ListView)this).get_View() == 2)
			{
				rectangle_2 = rectangle_0;
			}
			if (flag)
			{
				rectangle_2.Y++;
				rectangle_2.Height -= 2;
			}
			method_11(graphics_0, rectangle_2, listViewItem_0);
		}
		else if (flag && (int)((ListView)this).get_View() == 1 && ((ListView)this).get_FullRowSelect() && ((Control)this).get_Focused())
		{
			Rectangle rectangle = rectangle_0;
			rectangle.Y++;
			rectangle.Height -= 2;
			Region clip = graphics_0.get_Clip();
			Rectangle clip2 = rectangle;
			clip2.Width--;
			graphics_0.SetClip(clip2);
			method_11(graphics_0, rectangle, listViewItem_0);
			graphics_0.set_Clip(clip);
		}
	}

	private bool method_6(ListViewItemStates listViewItemStates_0, ListViewItemStates listViewItemStates_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return (ListViewItemStates)(listViewItemStates_0 & listViewItemStates_1) == listViewItemStates_1;
	}

	protected override void OnDrawItem(DrawListViewItemEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (((int)e.get_State() == 0 && (int)((ListView)this).get_View() != 3 && (int)((ListView)this).get_View() != 4 && (int)((ListView)this).get_View() != 2 && (int)((ListView)this).get_View() != 0) || (int)((ListView)this).get_View() == 1)
		{
			((ListView)this).OnDrawItem(e);
			return;
		}
		Graphics graphics = e.get_Graphics();
		Rectangle bounds = e.get_Bounds();
		if ((int)((ListView)this).get_View() == 3)
		{
			bounds = e.get_Item().GetBounds((ItemBoundsPortion)2);
		}
		else if ((int)((ListView)this).get_View() == 2)
		{
			bounds = e.get_Item().GetBounds((ItemBoundsPortion)2);
		}
		method_5(graphics, bounds, e.get_Item(), e.get_State());
		method_8(graphics, e.get_Item(), null, e.get_Item().get_Font(), e.get_Item().get_ForeColor(), e.get_State());
		((ListView)this).OnDrawItem(e);
	}

	private bool method_7(ListViewItem listViewItem_0)
	{
		if (listViewItem_0.get_ImageList() != null && (listViewItem_0.get_ImageIndex() >= 0 || listViewItem_0.get_ImageKey().Length > 0))
		{
			return true;
		}
		return false;
	}

	private void method_8(Graphics graphics_0, ListViewItem listViewItem_0, ColumnHeader columnHeader_0, Font font_0, Color color_1, ListViewItemStates listViewItemStates_0)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Invalid comparison between Unknown and I4
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Invalid comparison between Unknown and I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Invalid comparison between Unknown and I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Invalid comparison between Unknown and I4
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Invalid comparison between Unknown and I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Invalid comparison between Unknown and I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Invalid comparison between Unknown and I4
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Invalid comparison between Unknown and I4
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Invalid comparison between Unknown and I4
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Invalid comparison between Unknown and I4
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Invalid comparison between Unknown and I4
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Invalid comparison between Unknown and I4
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Invalid comparison between Unknown and I4
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Invalid comparison between Unknown and I4
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Invalid comparison between Unknown and I4
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Invalid comparison between Unknown and I4
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Invalid comparison between Unknown and I4
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		bool flag;
		if ((flag = method_7(listViewItem_0)) && (columnHeader_0 == null || columnHeader_0.get_Width() > 4))
		{
			Rectangle bounds = listViewItem_0.GetBounds((ItemBoundsPortion)1);
			int num = listViewItem_0.get_ImageIndex();
			if (num < 0)
			{
				num = listViewItem_0.get_ImageList().get_Images().IndexOfKey(listViewItem_0.get_ImageKey());
			}
			if ((int)((ListView)this).get_View() != 1 && (int)((ListView)this).get_View() != 3 && ((ListView)this).get_StateImageList() != null)
			{
				bounds.X += ((ListView)this).get_StateImageList().get_ImageSize().Width + 3;
			}
			else if ((int)((ListView)this).get_View() == 2 && ((ListView)this).get_CheckBoxes() && ((ListView)this).get_Groups().get_Count() == 0)
			{
				bounds.X += ((ListView)this).get_SmallImageList().get_ImageSize().Width;
			}
			else if ((int)((ListView)this).get_View() == 0 && (listViewItem_0.get_ImageList().get_ImageSize().Width < bounds.Width || listViewItem_0.get_ImageList().get_ImageSize().Height < bounds.Height))
			{
				if (listViewItem_0.get_ImageList().get_ImageSize().Width < bounds.Width)
				{
					bounds.X += (bounds.Width - listViewItem_0.get_ImageList().get_ImageSize().Width) / 2;
				}
				if (listViewItem_0.get_ImageList().get_ImageSize().Height < bounds.Height)
				{
					bounds.Y += (bounds.Height - listViewItem_0.get_ImageList().get_ImageSize().Height) / 2;
				}
			}
			Region val = null;
			if (columnHeader_0 != null && columnHeader_0.get_Width() < bounds.Width)
			{
				Rectangle clip = bounds;
				clip.Width = columnHeader_0.get_Width();
				val = graphics_0.get_Clip();
				graphics_0.SetClip(clip);
			}
			if (bounds.Width > 2)
			{
				graphics_0.DrawImage(listViewItem_0.get_ImageList().get_Images().get_Item(num), bounds.Location);
			}
			if (val != null)
			{
				graphics_0.set_Clip(val);
			}
		}
		Rectangle bounds2 = listViewItem_0.GetBounds((ItemBoundsPortion)2);
		if (bounds2.Width > 2)
		{
			eTextFormat eTextFormat = eTextFormat.SingleLine;
			eTextFormat = (((int)((ListView)this).get_View() != 4 || listViewItem_0.get_SubItems().get_Count() <= 1) ? (eTextFormat | eTextFormat.VerticalCenter) : eTextFormat);
			if ((int)((ListView)this).get_View() == 0)
			{
				eTextFormat = eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.WordBreak;
			}
			else if ((int)((ListView)this).get_View() == 1 && columnHeader_0 != null)
			{
				eTextFormat |= eTextFormat.EndEllipsis;
				if ((int)columnHeader_0.get_TextAlign() == 2)
				{
					eTextFormat |= eTextFormat.HorizontalCenter;
				}
				else if ((int)columnHeader_0.get_TextAlign() == 1)
				{
					eTextFormat |= eTextFormat.Right;
				}
				bounds2.X += 2;
			}
			else if ((int)((ListView)this).get_View() == 3 || (int)((ListView)this).get_View() == 2)
			{
				bounds2.X += 2;
			}
			Class55.smethod_1(graphics_0, listViewItem_0.get_Text(), font_0, color_1, bounds2, eTextFormat);
			if ((int)((ListView)this).get_View() == 4 && listViewItem_0.get_SubItems().get_Count() > 1)
			{
				Size size = Class55.smethod_3(graphics_0, listViewItem_0.get_Text(), font_0);
				bounds2.Y += size.Height;
				bounds2.Height -= size.Height;
				Color foreColor = listViewItem_0.get_SubItems().get_Item(1).get_ForeColor();
				color_1 = ((foreColor.IsEmpty || !(foreColor != color_1)) ? SystemColors.ControlDarkDark : foreColor);
				Class55.smethod_1(graphics_0, listViewItem_0.get_SubItems().get_Item(1).get_Text(), font_0, color_1, bounds2, eTextFormat);
			}
		}
		if (((int)((ListView)this).get_View() == 1 || ((ListView)this).get_StateImageList() != null) && ((ListView)this).get_StateImageList() != null && listViewItem_0.get_StateImageIndex() >= 0 && listViewItem_0.get_StateImageIndex() < ((ListView)this).get_StateImageList().get_Images().get_Count())
		{
			Rectangle bounds3 = listViewItem_0.GetBounds((ItemBoundsPortion)1);
			if ((int)((ListView)this).get_View() != 1 && (int)((ListView)this).get_View() != 3)
			{
				if ((int)((ListView)this).get_View() == 0 && bounds3.Width > ((ListView)this).get_StateImageList().get_ImageSize().Width)
				{
					bounds3.X += (bounds3.Width - ((ListView)this).get_StateImageList().get_ImageSize().Width) / 2;
					bounds3.Y++;
				}
				else if ((int)((ListView)this).get_View() == 4 && bounds3.Height > ((ListView)this).get_StateImageList().get_ImageSize().Height)
				{
					bounds3.Y += (bounds3.Height - ((ListView)this).get_StateImageList().get_ImageSize().Height) / 2;
					bounds3.X++;
				}
			}
			else
			{
				bounds3.X -= 19;
			}
			((ListView)this).get_StateImageList().Draw(graphics_0, bounds3.Location, listViewItem_0.get_StateImageIndex());
		}
		if (((ListView)this).get_CheckBoxes() && ((int)((ListView)this).get_View() == 1 || (int)((ListView)this).get_View() == 3 || (int)((ListView)this).get_View() == 2 || (int)((ListView)this).get_View() == 0) && ((ListView)this).get_StateImageList() == null)
		{
			Rectangle bounds4 = listViewItem_0.GetBounds((ItemBoundsPortion)1);
			if ((int)((ListView)this).get_View() == 0)
			{
				bounds4.X += (bounds4.Width - size_0.Width) / 2 - 4;
			}
			else if ((int)((ListView)this).get_View() == 3)
			{
				bounds4.X -= 18;
			}
			else if ((int)((ListView)this).get_View() == 2 && flag && ((ListView)this).get_Groups().get_Count() > 0)
			{
				bounds4.X -= 20;
			}
			else if ((int)((ListView)this).get_View() == 2)
			{
				bounds4.X -= 3;
			}
			else
			{
				bounds4.X -= 21;
			}
			Class229 @class = Class274.smethod_16(null);
			Office2007CheckBoxColorTable office2007CheckBoxColorTable = method_2();
			Office2007CheckBoxStateColorTable office2007CheckBoxStateColorTable_ = office2007CheckBoxColorTable.Default;
			if ((listViewItemStates_0 & 2) != 0 || !((Control)this).get_Enabled())
			{
				office2007CheckBoxStateColorTable_ = office2007CheckBoxColorTable.Disabled;
			}
			@class.method_1(graphics_0, new Rectangle(bounds4.X + 4, bounds4.Y + (bounds4.Height - size_0.Height) / 2, size_0.Width, size_0.Height), office2007CheckBoxStateColorTable_, (CheckState)(listViewItem_0.get_Checked() ? 1 : 0));
		}
	}

	protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = e.get_Graphics();
		if (((ListView)this).get_FullRowSelect() && method_6(e.get_ItemState(), (ListViewItemStates)1) && e.get_Header() != null && (e.get_Header().get_DisplayIndex() == 0 || (e.get_Bounds().X <= 0 && e.get_Header().get_DisplayIndex() > 0 && ((ListView)this).get_Scrollable())))
		{
			Rectangle bounds = e.get_Item().get_Bounds();
			if ((method_7(e.get_Item()) || e.get_Header().get_DisplayIndex() != e.get_Header().get_Index()) && e.get_Header().get_DisplayIndex() == 0)
			{
				int num = Math.Min(val2: e.get_Item().GetBounds((ItemBoundsPortion)1).Right - bounds.X + 1, val1: e.get_Header().get_Width());
				bounds.Width -= num;
				bounds.X += num;
			}
			method_5(graphics, bounds, e.get_Item(), e.get_ItemState());
		}
		if (e.get_ColumnIndex() == 0)
		{
			if (!((ListView)this).get_FullRowSelect() || !method_6(e.get_ItemState(), (ListViewItemStates)1))
			{
				Rectangle bounds2 = e.get_Item().GetBounds((ItemBoundsPortion)2);
				method_5(graphics, bounds2, e.get_Item(), e.get_ItemState());
			}
			Color color_ = e.get_Item().get_ForeColor();
			if (!((Control)this).get_Enabled())
			{
				color_ = (color_0.IsEmpty ? SystemColors.ControlDark : color_0);
			}
			method_8(graphics, e.get_Item(), e.get_Header(), e.get_Item().get_Font(), color_, e.get_ItemState());
		}
		else
		{
			if (((ListView)this).get_FullRowSelect() && method_6(e.get_ItemState(), (ListViewItemStates)1) && e.get_Header().get_DisplayIndex() != e.get_Header().get_Index())
			{
				Rectangle bounds3 = e.get_Bounds();
				method_5(graphics, bounds3, e.get_Item(), e.get_ItemState());
			}
			if (e.get_Header().get_Width() > 0)
			{
				method_10(graphics, e.get_SubItem(), e.get_Bounds(), e.get_ItemState(), ((ListView)this).get_Columns().get_Item(e.get_ColumnIndex()), e.get_Item().get_BackColor());
			}
		}
		((ListView)this).OnDrawSubItem(e);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDisabledForeColor()
	{
		return !color_0.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDisabledForeColor()
	{
		DisabledForeColor = Color.Empty;
	}

	private IList method_9()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		IList list = (IList)((ListView)this).get_Columns();
		if (((ListView)this).get_AllowColumnReorder())
		{
			ArrayList arrayList = new ArrayList((ICollection)((ListView)this).get_Columns());
			foreach (ColumnHeader item in list)
			{
				ColumnHeader val = item;
				arrayList[val.get_DisplayIndex()] = val;
			}
			list = arrayList;
		}
		return list;
	}

	private void method_10(Graphics graphics_0, ListViewSubItem listViewSubItem_0, Rectangle rectangle_0, ListViewItemStates listViewItemStates_0, ColumnHeader columnHeader_0, Color color_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Invalid comparison between Unknown and I4
		if (!method_6(listViewItemStates_0, (ListViewItemStates)1) && ((Control)this).get_Enabled())
		{
			if (!listViewSubItem_0.get_BackColor().IsEmpty)
			{
				SolidBrush val = new SolidBrush(listViewSubItem_0.get_BackColor());
				try
				{
					graphics_0.FillRectangle((Brush)(object)val, rectangle_0);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			else if (!color_1.IsEmpty)
			{
				SolidBrush val2 = new SolidBrush(color_1);
				try
				{
					graphics_0.FillRectangle((Brush)(object)val2, rectangle_0);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
		}
		eTextFormat eTextFormat = eTextFormat.EndEllipsis | eTextFormat.SingleLine | eTextFormat.VerticalCenter;
		if (columnHeader_0 != null)
		{
			if ((int)columnHeader_0.get_TextAlign() == 2)
			{
				eTextFormat |= eTextFormat.HorizontalCenter;
			}
			else if ((int)columnHeader_0.get_TextAlign() == 1)
			{
				eTextFormat |= eTextFormat.Right;
			}
		}
		Color color = listViewSubItem_0.get_ForeColor();
		if (!((Control)this).get_Enabled())
		{
			color = (color_0.IsEmpty ? SystemColors.ControlDark : color_0);
		}
		Rectangle rectangle_ = Rectangle.Inflate(rectangle_0, -2, 0);
		Class55.smethod_1(graphics_0, listViewSubItem_0.get_Text(), listViewSubItem_0.get_Font(), color, rectangle_, eTextFormat);
	}

	private void method_11(Graphics graphics_0, Rectangle rectangle_0, ListViewItem listViewItem_0)
	{
		ControlPaint.DrawFocusRectangle(graphics_0, rectangle_0, listViewItem_0.get_ForeColor(), listViewItem_0.get_BackColor());
	}

	private Rectangle method_12(Rectangle rectangle_0, bool bool_1, ListViewItem listViewItem_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		Rectangle result = rectangle_0;
		if ((int)((ListView)this).get_View() == 1)
		{
			if (!((ListView)this).get_FullRowSelect() && listViewItem_0.get_SubItems().get_Count() > 0)
			{
				ListViewSubItem val = listViewItem_0.get_SubItems().get_Item(0);
				Size size = TextRenderer.MeasureText(val.get_Text(), val.get_Font());
				result = new Rectangle(rectangle_0.X, rectangle_0.Y, size.Width, size.Height);
				result.X += 4;
				result.Width++;
			}
			else
			{
				result.X += 4;
				result.Width -= 4;
			}
			if (bool_1)
			{
				result.X--;
			}
		}
		return result;
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		point_0 = new Point(e.get_X(), e.get_Y());
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		((Control)this).OnMouseUp(e);
		if ((int)((ListView)this).get_View() == 1 && ((ListView)this).get_FullRowSelect() && !((Control)this).get_IsDisposed() && !((ListView)this).get_CheckBoxes())
		{
			ListViewItem itemAt = ((ListView)this).GetItemAt(5, e.get_Y());
			ListViewItem itemAt2 = ((ListView)this).GetItemAt(5, point_0.Y);
			if (itemAt != null && itemAt == itemAt2)
			{
				itemAt.set_Selected(true);
				itemAt.set_Focused(true);
			}
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		if (bool_0)
		{
			((Control)this).Refresh();
			bool_0 = false;
		}
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (HideSelection && !((ListView)this).get_VirtualMode() && ((ListView)this).get_SelectedItems().get_Count() > 0)
		{
			foreach (ListViewItem selectedItem in ((ListView)this).get_SelectedItems())
			{
				ListViewItem val = selectedItem;
				Rectangle bounds = val.get_Bounds();
				if ((int)((ListView)this).get_View() == 1)
				{
					bounds.X = 0;
					bounds.Width = ((Control)this).get_Width();
				}
				else if ((int)((ListView)this).get_View() == 0)
				{
					bounds.Inflate(32, 32);
				}
				((Control)this).Invalidate(bounds);
			}
		}
		((Control)this).OnLostFocus(e);
	}

	protected override void WndProc(ref Message m)
	{
		if (class188_0 != null)
		{
			if (class188_0.WndProc(ref m))
			{
				((ListView)this).WndProc(ref m);
			}
		}
		else
		{
			((ListView)this).WndProc(ref m);
		}
	}

	public virtual BaseRenderer GetRenderer()
	{
		if (eRenderMode_0 == eRenderMode.Global && GlobalManager.Renderer != null)
		{
			return GlobalManager.Renderer;
		}
		if (eRenderMode_0 == eRenderMode.Custom && baseRenderer_1 != null)
		{
			return baseRenderer_1;
		}
		if (baseRenderer_0 == null)
		{
			baseRenderer_0 = new Office2007Renderer();
		}
		return baseRenderer_0;
	}

	private ElementStyle method_13()
	{
		elementStyle_0.method_4(GetColorScheme());
		return ElementStyleDisplay.smethod_5(elementStyle_0);
	}

	private void elementStyle_0_StyleChanged(object sender, EventArgs e)
	{
		if (Class109.smethod_11((Control)(object)this))
		{
			Class92.RECT lprcUpdate = new Class92.RECT(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			Class92.RedrawWindow(((Control)this).get_Handle(), ref lprcUpdate, IntPtr.Zero, 1025u);
		}
	}

	void INonClientControl.BaseWndProc(ref Message m)
	{
		((ListView)this).WndProc(ref m);
	}

	ItemPaintArgs INonClientControl.GetItemPaintArgs(Graphics g)
	{
		ItemPaintArgs itemPaintArgs = new ItemPaintArgs(this as IOwner, (Control)(object)this, g, GetColorScheme());
		itemPaintArgs.BaseRenderer_0 = GetRenderer();
		itemPaintArgs.DesignerSelection = false;
		itemPaintArgs.GlassEnabled = !((Component)this).DesignMode && Class51.Boolean_0;
		return itemPaintArgs;
	}

	void INonClientControl.PaintBackground(PaintEventArgs e)
	{
	}

	protected virtual ColorScheme GetColorScheme()
	{
		BaseRenderer renderer = GetRenderer();
		if (renderer is Office2007Renderer)
		{
			return ((Office2007Renderer)renderer).ColorTable.LegacyColors;
		}
		if (colorScheme_0 == null)
		{
			colorScheme_0 = new ColorScheme(eDotNetBarStyle.Office2007);
		}
		return colorScheme_0;
	}

	Point INonClientControl.PointToScreen(Point client)
	{
		return ((Control)this).PointToScreen(client);
	}

	void INonClientControl.AdjustClientRectangle(ref Rectangle r)
	{
	}

	void INonClientControl.AdjustBorderRectangle(ref Rectangle r)
	{
	}

	void INonClientControl.RenderNonClient(Graphics g)
	{
	}
}
