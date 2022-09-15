using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.ScrollBar;

namespace DevComponents.DotNetBar;

[Designer(typeof(ItemPanelDesigner))]
[ToolboxItem(true)]
[ToolboxBitmap(typeof(ItemPanel), "Ribbon.ItemPanel.ico")]
[ComVisible(false)]
public class ItemPanel : ItemControl, IScrollableItemControl
{
	private ItemContainer itemContainer_0;

	private bool bool_25;

	private Point point_0 = Point.Empty;

	private int int_4;

	private VScrollBarAdv vscrollBarAdv_0;

	private HScrollBarAdv hscrollBarAdv_0;

	private Control control_0;

	private bool bool_26;

	private Size size_0 = Size.Empty;

	private Point point_1 = Point.Empty;

	private bool bool_27;

	private BaseItem baseItem_6;

	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Description("Specifies the visual style of the control.")]
	[DefaultValue(eDotNetBarStyle.Office2007)]
	[Browsable(true)]
	public eDotNetBarStyle Style
	{
		get
		{
			return itemContainer_0.Style;
		}
		set
		{
			base.ColorScheme.method_0(value);
			itemContainer_0.Style = value;
			((Control)this).Invalidate();
			RecalcLayout();
		}
	}

	[DefaultValue(1)]
	[Description("Indicates spacing in pixels between items.")]
	[Category("Layout")]
	[Browsable(true)]
	public int ItemSpacing
	{
		get
		{
			return itemContainer_0.ItemSpacing;
		}
		set
		{
			itemContainer_0.ItemSpacing = value;
		}
	}

	[Category("Layout")]
	[DevCoBrowsable(true)]
	[DefaultValue(eOrientation.Horizontal)]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public virtual eOrientation LayoutOrientation
	{
		get
		{
			return itemContainer_0.LayoutOrientation;
		}
		set
		{
			itemContainer_0.LayoutOrientation = value;
			if (((Component)(object)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[Browsable(true)]
	[Category("Layout")]
	[DevCoBrowsable(true)]
	[DefaultValue(true)]
	public bool ResizeItemsToFit
	{
		get
		{
			return itemContainer_0.ResizeItemsToFit;
		}
		set
		{
			itemContainer_0.ResizeItemsToFit = value;
		}
	}

	[Category("Layout")]
	[DefaultValue(false)]
	[Description("Indicates whether ButtonItem buttons when in vertical layout are fit into the available width so any text inside of them is wrapped if needed.")]
	public bool FitButtonsToContainerWidth
	{
		get
		{
			return itemContainer_0.Boolean_3;
		}
		set
		{
			itemContainer_0.Boolean_3 = value;
			if (((Component)(object)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(eHorizontalItemsAlignment.Left)]
	[Category("Layout")]
	[Description("Indicates item alignment when container is in horizontal layout.")]
	public eHorizontalItemsAlignment HorizontalItemAlignment
	{
		get
		{
			return itemContainer_0.HorizontalItemAlignment;
		}
		set
		{
			itemContainer_0.HorizontalItemAlignment = value;
		}
	}

	[Category("Layout")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether items in horizontal layout are wrapped into the new line when they cannot fit allotted container size.")]
	public bool MultiLine
	{
		get
		{
			return itemContainer_0.MultiLine;
		}
		set
		{
			itemContainer_0.MultiLine = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public SubItemsCollection Items => itemContainer_0.SubItems;

	private new bool Boolean_3 => ((Control)this).GetStyle((ControlStyles)512);

	[Browsable(false)]
	public VScrollBarAdv VScrollBar => vscrollBarAdv_0;

	[Browsable(false)]
	public HScrollBarAdv HScrollBar => hscrollBarAdv_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Size AutoScrollMargin
	{
		get
		{
			return ((ScrollableControl)this).get_AutoScrollMargin();
		}
		set
		{
			((ScrollableControl)this).set_AutoScrollMargin(value);
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	public bool AutoScroll
	{
		get
		{
			return bool_26;
		}
		set
		{
			if (bool_26 != value)
			{
				bool_26 = value;
				RecalcLayout();
				method_25();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Size AutoScrollMinSize
	{
		get
		{
			return size_0;
		}
		set
		{
			size_0 = value;
			method_25();
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Description("Indicates location of the auto-scroll position.")]
	public Point AutoScrollPosition
	{
		get
		{
			return point_1;
		}
		set
		{
			if (value.X > 0)
			{
				value.X = -value.X;
			}
			if (value.Y > 0)
			{
				value.Y = -value.Y;
			}
			if (!(point_1 != value))
			{
				return;
			}
			point_1 = value;
			if (bool_26)
			{
				if (vscrollBarAdv_0 != null && vscrollBarAdv_0.Value != -point_1.Y)
				{
					vscrollBarAdv_0.Value = -point_1.Y;
				}
				if (hscrollBarAdv_0 != null && hscrollBarAdv_0.Value != -point_1.X)
				{
					hscrollBarAdv_0.Value = -point_1.X;
				}
				((Control)this).Invalidate();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool SuspendPaint
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

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public BaseItem ItemTemplate
	{
		get
		{
			return baseItem_6;
		}
		set
		{
			baseItem_6 = value;
			method_29();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public List<BaseItem> SelectedItems
	{
		get
		{
			List<BaseItem> list = new List<BaseItem>();
			foreach (BaseItem item in Items)
			{
				if (item is ButtonItem buttonItem && buttonItem.Checked)
				{
					list.Add(buttonItem);
				}
				else if (item is CheckBoxItem checkBoxItem && checkBoxItem.Checked)
				{
					list.Add(checkBoxItem);
				}
			}
			return list;
		}
	}

	[Description("Gets or sets whether external ButtonItem object is accepted in drag and drop operation.")]
	[DefaultValue(false)]
	[Category("Behavior")]
	[Browsable(true)]
	public override bool AllowExternalDrop
	{
		get
		{
			return base.AllowExternalDrop;
		}
		set
		{
			base.AllowExternalDrop = value;
		}
	}

	[DefaultValue(false)]
	[Description("Specifies whether native .NET Drag and Drop is used by control to perform drag and drop operations.")]
	[Category("Behavior")]
	[Browsable(true)]
	public override bool UseNativeDragDrop
	{
		get
		{
			return base.UseNativeDragDrop;
		}
		set
		{
			base.UseNativeDragDrop = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Behavior")]
	[Description("Specifies whether automatic drag & drop support is enabled.")]
	public virtual bool EnableDragDrop
	{
		get
		{
			return bool_25;
		}
		set
		{
			bool_25 = value;
		}
	}

	public ItemPanel()
	{
		itemContainer_0 = new ItemContainer();
		itemContainer_0.GlobalItem = false;
		itemContainer_0.ContainerControl = this;
		itemContainer_0.Stretch = false;
		itemContainer_0.Displayed = true;
		itemContainer_0.Style = eDotNetBarStyle.Office2007;
		base.ColorScheme.EDotNetBarStyle_0 = eDotNetBarStyle.Office2007;
		itemContainer_0.method_6(this);
		itemContainer_0.method_23(bool_26: true);
		SetBaseItemContainer(itemContainer_0);
		itemContainer_0.Style = eDotNetBarStyle.Office2007;
		DragDropSupport = true;
		baseItem_6 = method_30();
	}

	public void InvalidateNonClient()
	{
		if (Class109.smethod_11((Control)(object)this))
		{
			Class51.RedrawWindow(((Control)this).get_Handle(), IntPtr.Zero, IntPtr.Zero, (Class51.RedrawWindowFlags)1025u);
		}
	}

	public ButtonItem GetChecked()
	{
		foreach (BaseItem item in Items)
		{
			if (item.Visible && item is ButtonItem && ((ButtonItem)item).Checked)
			{
				return item as ButtonItem;
			}
		}
		return null;
	}

	public void EnsureVisible(BaseItem item)
	{
		if (item.ContainerControl == this)
		{
			Rectangle displayRectangle = item.DisplayRectangle;
			if (!((Control)this).get_ClientRectangle().Contains(displayRectangle) && AutoScroll)
			{
				Point autoScrollPosition = Point.Empty;
				autoScrollPosition = ((displayRectangle.Y >= 0) ? new Point(AutoScrollPosition.X, displayRectangle.Bottom - (AutoScrollPosition.Y + ((Control)this).get_ClientRectangle().Height)) : new Point(AutoScrollPosition.X, Math.Abs(AutoScrollPosition.Y - displayRectangle.Y) - 2));
				InvalidateLayout();
				AutoScrollPosition = autoScrollPosition;
				RecalcLayout();
			}
		}
	}

	protected override Rectangle GetPaintClipRectangle()
	{
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		if (base.BackgroundStyle == null)
		{
			return clientRectangle;
		}
		clientRectangle.X += Class52.smethod_3(base.BackgroundStyle);
		clientRectangle.Width -= Class52.smethod_1(base.BackgroundStyle);
		clientRectangle.Y += Class52.smethod_7(base.BackgroundStyle);
		clientRectangle.Height -= Class52.smethod_2(base.BackgroundStyle);
		if (vscrollBarAdv_0 != null)
		{
			clientRectangle.Width -= ((Control)vscrollBarAdv_0).get_Width();
		}
		if (hscrollBarAdv_0 != null)
		{
			clientRectangle.Height -= ((Control)hscrollBarAdv_0).get_Height();
		}
		return clientRectangle;
	}

	protected override Rectangle GetItemContainerRectangle()
	{
		Rectangle itemContainerRectangle = base.GetItemContainerRectangle();
		if (AutoScroll && AutoScrollPosition.Y != 0)
		{
			itemContainerRectangle.Y += AutoScrollPosition.Y;
		}
		if (AutoScroll && AutoScrollPosition.X != 0)
		{
			itemContainerRectangle.X += AutoScrollPosition.X;
		}
		if (vscrollBarAdv_0 != null)
		{
			itemContainerRectangle.Width -= ((Control)vscrollBarAdv_0).get_Width();
		}
		if (hscrollBarAdv_0 != null)
		{
			itemContainerRectangle.Height -= ((Control)hscrollBarAdv_0).get_Height();
		}
		return itemContainerRectangle;
	}

	private void method_24()
	{
		if (!AutoScroll)
		{
			return;
		}
		if (itemContainer_0.NeedRecalcSize)
		{
			RecalcSize();
			return;
		}
		Rectangle itemContainerRectangle = base.GetItemContainerRectangle();
		if (AutoScrollPosition.Y != 0)
		{
			itemContainerRectangle.Y += AutoScrollPosition.Y;
		}
		if (AutoScrollPosition.X != 0)
		{
			itemContainerRectangle.X += AutoScrollPosition.X;
		}
		itemContainerRectangle.Height = itemContainer_0.HeightInternal;
		itemContainerRectangle.Width = itemContainer_0.WidthInternal;
		itemContainer_0.Bounds = itemContainerRectangle;
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (!((Control)this).get_Focused() && Boolean_3)
		{
			((Control)this).Select();
		}
		point_0.X = e.get_X();
		point_0.Y = e.get_Y();
		base.OnMouseDown(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		base.OnMouseMove(e);
		if (bool_25 && !base.DragInProgress && (int)e.get_Button() == 1048576 && (Math.Abs(e.get_X() - point_0.X) > SystemInformation.get_DragSize().Width || Math.Abs(e.get_Y() - point_0.Y) > SystemInformation.get_DragSize().Height))
		{
			BaseItem baseItem = HitTest(e.get_X(), e.get_Y());
			if (baseItem != null)
			{
				((IOwner)this).StartItemDrag(baseItem);
			}
		}
	}

	protected override bool ProcessDialogKey(Keys keyData)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_Focused())
		{
			KeyEventArgs val = new KeyEventArgs(keyData);
			itemContainer_0.InternalKeyDown(val);
			if (val.get_Handled())
			{
				return true;
			}
		}
		return ((ContainerControl)this).ProcessDialogKey(keyData);
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		if (vscrollBarAdv_0 != null && ((Control)vscrollBarAdv_0).get_Visible())
		{
			int num = vscrollBarAdv_0.Value + vscrollBarAdv_0.SmallChange * ((e.get_Delta() < 0) ? 1 : (-1));
			if (num < vscrollBarAdv_0.Minimum)
			{
				num = vscrollBarAdv_0.Minimum;
			}
			if (num > vscrollBarAdv_0.Maximum - vscrollBarAdv_0.LargeChange + 1)
			{
				num = vscrollBarAdv_0.Maximum - vscrollBarAdv_0.LargeChange + 1;
			}
			vscrollBarAdv_0.method_2(num, (ScrollEventType)(e.get_Delta() < 0));
		}
		((ScrollableControl)this).OnMouseWheel(e);
	}

	protected override void RecalcSize()
	{
		int_4++;
		try
		{
			itemContainer_0.MinimumSize = new Size(GetItemContainerRectangle().Width, 0);
			base.RecalcSize();
			if (((Control)this).get_AutoSize() || !AutoScroll)
			{
				return;
			}
			if (itemContainer_0.HeightInternal <= ((Control)this).get_ClientRectangle().Height && itemContainer_0.WidthInternal <= ((Control)this).get_ClientRectangle().Width)
			{
				if (!AutoScrollMinSize.IsEmpty)
				{
					AutoScrollMinSize = Size.Empty;
				}
				return;
			}
			Size empty = Size.Empty;
			if (itemContainer_0.HeightInternal > ((Control)this).get_ClientRectangle().Height)
			{
				empty.Height = itemContainer_0.HeightInternal;
			}
			if (itemContainer_0.WidthInternal > ((Control)this).get_ClientRectangle().Width)
			{
				empty.Width = itemContainer_0.WidthInternal;
			}
			if (base.BackgroundStyle != null)
			{
				empty.Width += Class52.smethod_1(base.BackgroundStyle);
				empty.Height += Class52.smethod_2(base.BackgroundStyle);
			}
			bool flag = vscrollBarAdv_0 == null;
			bool flag2 = hscrollBarAdv_0 == null;
			if (AutoScrollMinSize != empty)
			{
				((Control)this).Invalidate();
				AutoScrollMinSize = empty;
			}
			flag ^= vscrollBarAdv_0 == null;
			flag2 ^= hscrollBarAdv_0 == null;
			if (int_4 < 4 && (flag || flag2))
			{
				RecalcSize();
			}
		}
		finally
		{
			int_4--;
		}
	}

	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		method_25();
		method_26();
	}

	private void method_25()
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		if (!bool_26)
		{
			method_27();
			method_28();
			if (control_0 != null)
			{
				((Control)this).get_Controls().Remove(control_0);
				((Component)(object)control_0).Dispose();
				control_0 = null;
			}
			return;
		}
		Rectangle rectangle = Class52.smethod_12(base.BackgroundStyle, ((Control)this).get_ClientRectangle());
		Size size = size_0;
		if (size.Height > rectangle.Height)
		{
			if (vscrollBarAdv_0 == null)
			{
				vscrollBarAdv_0 = new VScrollBarAdv();
				((Control)vscrollBarAdv_0).set_Width(SystemInformation.get_VerticalScrollBarWidth());
				((Control)this).get_Controls().Add((Control)(object)vscrollBarAdv_0);
				((Control)vscrollBarAdv_0).BringToFront();
				vscrollBarAdv_0.Scroll += new ScrollEventHandler(vscrollBarAdv_0_Scroll);
			}
			if (vscrollBarAdv_0.Minimum != 0)
			{
				vscrollBarAdv_0.Minimum = 0;
			}
			if (vscrollBarAdv_0.LargeChange != rectangle.Height && rectangle.Height > 0)
			{
				vscrollBarAdv_0.LargeChange = rectangle.Height;
			}
			vscrollBarAdv_0.SmallChange = 22;
			if (vscrollBarAdv_0.Maximum != size_0.Height)
			{
				vscrollBarAdv_0.Maximum = size_0.Height;
			}
			if (vscrollBarAdv_0.Value != -point_1.Y)
			{
				vscrollBarAdv_0.Value = Math.Min(vscrollBarAdv_0.Maximum, Math.Abs(point_1.Y));
			}
		}
		else
		{
			method_28();
		}
		if (size.Width > rectangle.Width)
		{
			if (hscrollBarAdv_0 == null)
			{
				hscrollBarAdv_0 = new HScrollBarAdv();
				((Control)hscrollBarAdv_0).set_Height(SystemInformation.get_HorizontalScrollBarHeight());
				((Control)this).get_Controls().Add((Control)(object)hscrollBarAdv_0);
				((Control)hscrollBarAdv_0).BringToFront();
				hscrollBarAdv_0.Scroll += new ScrollEventHandler(hscrollBarAdv_0_Scroll);
			}
			if (hscrollBarAdv_0.Minimum != 0)
			{
				hscrollBarAdv_0.Minimum = 0;
			}
			if (hscrollBarAdv_0.LargeChange != rectangle.Width && rectangle.Width > 0)
			{
				hscrollBarAdv_0.LargeChange = rectangle.Width;
			}
			if (hscrollBarAdv_0.Maximum != size_0.Width)
			{
				hscrollBarAdv_0.Maximum = size_0.Width;
			}
			if (hscrollBarAdv_0.Value != -point_1.X)
			{
				hscrollBarAdv_0.Value = Math.Min(hscrollBarAdv_0.Maximum, Math.Abs(point_1.X));
			}
			hscrollBarAdv_0.SmallChange = 22;
		}
		else
		{
			method_27();
		}
		method_26();
	}

	private void vscrollBarAdv_0_Scroll(object sender, ScrollEventArgs e)
	{
		point_1.Y = -e.get_NewValue();
		method_24();
		((Control)this).Invalidate();
	}

	private void hscrollBarAdv_0_Scroll(object sender, ScrollEventArgs e)
	{
		point_1.X = -e.get_NewValue();
		method_24();
		((Control)this).Invalidate();
	}

	private void method_26()
	{
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		Rectangle rectangle = Class52.smethod_12(base.BackgroundStyle, ((Control)this).get_ClientRectangle());
		if (hscrollBarAdv_0 != null)
		{
			int num = rectangle.Width;
			if (vscrollBarAdv_0 != null)
			{
				num -= ((Control)vscrollBarAdv_0).get_Width();
			}
			((Control)hscrollBarAdv_0).set_Bounds(new Rectangle(rectangle.X, rectangle.Bottom - ((Control)hscrollBarAdv_0).get_Height() + 1, num, ((Control)hscrollBarAdv_0).get_Height()));
		}
		if (vscrollBarAdv_0 != null)
		{
			int num2 = rectangle.Height;
			if (hscrollBarAdv_0 != null)
			{
				num2 -= ((Control)hscrollBarAdv_0).get_Height();
			}
			((Control)vscrollBarAdv_0).set_Bounds(new Rectangle(rectangle.Right - ((Control)vscrollBarAdv_0).get_Width() + 1, rectangle.Y, ((Control)vscrollBarAdv_0).get_Width(), num2));
		}
		if (vscrollBarAdv_0 != null && hscrollBarAdv_0 != null)
		{
			if (control_0 == null)
			{
				control_0 = new Control();
				control_0.set_BackColor(((Control)this).get_BackColor());
				if (!base.BackgroundStyle.BackColor.IsEmpty && base.BackgroundStyle.BackColor != Color.Transparent)
				{
					control_0.set_BackColor(base.BackgroundStyle.BackColor);
				}
				((Control)this).get_Controls().Add(control_0);
			}
			control_0.set_Bounds(new Rectangle(((Control)hscrollBarAdv_0).get_Bounds().Right, ((Control)vscrollBarAdv_0).get_Bounds().Bottom, ((Control)vscrollBarAdv_0).get_Width(), ((Control)hscrollBarAdv_0).get_Height()));
			control_0.BringToFront();
		}
		else if (control_0 != null)
		{
			((Control)this).get_Controls().Remove(control_0);
			((Component)(object)control_0).Dispose();
			control_0 = null;
		}
	}

	private void method_27()
	{
		if (hscrollBarAdv_0 != null)
		{
			Rectangle bounds = ((Control)hscrollBarAdv_0).get_Bounds();
			((Control)this).get_Controls().Remove((Control)(object)hscrollBarAdv_0);
			((Component)(object)hscrollBarAdv_0).Dispose();
			hscrollBarAdv_0 = null;
			((Control)this).Invalidate(bounds);
		}
	}

	private void method_28()
	{
		if (vscrollBarAdv_0 != null)
		{
			Rectangle bounds = ((Control)vscrollBarAdv_0).get_Bounds();
			((Control)this).get_Controls().Remove((Control)(object)vscrollBarAdv_0);
			((Component)(object)vscrollBarAdv_0).Dispose();
			vscrollBarAdv_0 = null;
			((Control)this).Invalidate(bounds);
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (!Class92.smethod_0() && Class92.bool_0)
		{
			if (!bool_27)
			{
				base.OnPaint(e);
			}
		}
		else
		{
			e.get_Graphics().Clear(SystemColors.Control);
		}
	}

	private void method_29()
	{
	}

	private BaseItem method_30()
	{
		ButtonItem buttonItem = new ButtonItem();
		buttonItem.Shape = new RoundRectangleShapeDescriptor();
		buttonItem.OptionGroup = "items";
		buttonItem.GlobalItem = false;
		buttonItem.ColorTable = eButtonColor.Flat;
		return buttonItem;
	}

	public BaseItem AddItem(string text)
	{
		if (baseItem_6 == null)
		{
			throw new NullReferenceException("ItemTemplate property not set.");
		}
		BaseItem baseItem = baseItem_6.Copy();
		baseItem.Text = text;
		Items.Add(baseItem);
		return baseItem;
	}

	void IScrollableItemControl.KeyboardItemSelected(BaseItem item)
	{
		if (item != null)
		{
			EnsureVisible(item);
		}
	}
}
