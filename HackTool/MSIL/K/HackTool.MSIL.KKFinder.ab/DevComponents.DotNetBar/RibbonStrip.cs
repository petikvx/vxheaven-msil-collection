using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[ComVisible(false)]
public class RibbonStrip : ItemControl
{
	private RibbonStripContainerItem ribbonStripContainerItem_0;

	private RibbonTabItemGroupCollection ribbonTabItemGroupCollection_0;

	private int int_4 = 14;

	private bool bool_25;

	private Font font_1;

	private Font font_2;

	private int int_5;

	private bool bool_26;

	private bool bool_27 = true;

	private int int_6 = 46;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private Rectangle rectangle_2 = Rectangle.Empty;

	private Rectangle[] rectangle_3;

	private Font font_3;

	private bool bool_28 = true;

	private ElementStyle elementStyle_1 = new ElementStyle();

	private bool bool_29 = true;

	private string string_2 = "";

	private bool bool_30;

	private MarkupLinkClickEventHandler markupLinkClickEventHandler_0;

	private Class261 class261_0;

	internal Rectangle rectangle_4 = Rectangle.Empty;

	private bool bool_31;

	private IKeyTipsControl ikeyTipsControl_0;

	private bool bool_32;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool CanSupportGlass
	{
		get
		{
			return bool_30;
		}
		set
		{
			bool_30 = value;
		}
	}

	internal override bool Boolean_6
	{
		get
		{
			if (!bool_30)
			{
				return false;
			}
			return base.Boolean_6;
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Description("Indicates text displayed on Ribbon Title instead of the Form.Text property.")]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DefaultValue("")]
	public string TitleText
	{
		get
		{
			return string_2;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			string_2 = value;
			class261_0 = null;
			if (Class243.smethod_2(ref string_2))
			{
				class261_0 = Class243.smethod_0(string_2);
				if (class261_0 != null)
				{
					class261_0.Event_0 += method_24;
				}
				rectangle_4 = Rectangle.Empty;
				((Control)this).Invalidate();
			}
		}
	}

	internal Class261 Class261_0 => class261_0;

	[Browsable(true)]
	[Description("Indicates whether KeyTips functionality is enabled.")]
	[Category("Behavior")]
	[DefaultValue(true)]
	public bool KeyTipsEnabled
	{
		get
		{
			return bool_29;
		}
		set
		{
			bool_29 = value;
		}
	}

	[Description("Indicates whether control can be customized. Caption must be visible for customization to be fully enabled.")]
	[Browsable(true)]
	[Category("Customization")]
	[DefaultValue(true)]
	public bool CanCustomize
	{
		get
		{
			return bool_28;
		}
		set
		{
			bool_28 = value;
		}
	}

	[DefaultValue(0)]
	[Browsable(true)]
	[Description("Indicates explicit height of the caption provided by control")]
	[Category("Appearance")]
	public int CaptionHeight
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
			ribbonStripContainerItem_0.NeedRecalcSize = true;
		}
	}

	internal new bool Boolean_3
	{
		get
		{
			foreach (BaseItem item in Items)
			{
				if (item.Visible)
				{
					return true;
				}
			}
			return false;
		}
	}

	internal Rectangle[] Rectangle_0
	{
		get
		{
			return rectangle_3;
		}
		set
		{
			rectangle_3 = value;
		}
	}

	internal Rectangle Rectangle_1
	{
		get
		{
			return rectangle_0;
		}
		set
		{
			rectangle_0 = value;
		}
	}

	internal Rectangle Rectangle_2
	{
		get
		{
			return rectangle_1;
		}
		set
		{
			rectangle_1 = value;
		}
	}

	internal Rectangle Rectangle_3
	{
		get
		{
			return rectangle_2;
		}
		set
		{
			rectangle_2 = value;
		}
	}

	internal SystemCaptionItem SystemCaptionItem_0 => ribbonStripContainerItem_0.SystemCaptionItem;

	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Indicates whether custom caption line provided by the control is visible.")]
	[Category("Appearance")]
	public bool CaptionVisible
	{
		get
		{
			return bool_26;
		}
		set
		{
			bool_26 = value;
			method_25();
		}
	}

	[Description("")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Category("Appearance")]
	public Font CaptionFont
	{
		get
		{
			return font_3;
		}
		set
		{
			font_3 = value;
			ribbonStripContainerItem_0.NeedRecalcSize = true;
			((Control)this).Invalidate();
		}
	}

	[Category("Layout")]
	[DefaultValue(46)]
	[Description("Indicates indent of the ribbon strip.")]
	[Browsable(true)]
	public int RibbonStripIndent
	{
		get
		{
			return int_6;
		}
		set
		{
			int_6 = value;
			RecalcLayout();
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(14)]
	[Category("Tab Groups")]
	[Description("Indicates height in pixels of tab group line that is displayed above the RibbonTabItem objects that have group assigned.")]
	public int TabGroupHeight
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
			ribbonStripContainerItem_0.NeedRecalcSize = true;
			if (((Component)(object)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[DefaultValue(false)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Tab Groups")]
	[Description("Indicates height in pixels of tab group line that is displayed above the RibbonTabItem objects that have group assigned.")]
	public bool TabGroupsVisible
	{
		get
		{
			return bool_25;
		}
		set
		{
			bool_25 = value;
			ribbonStripContainerItem_0.NeedRecalcSize = true;
			if (((Component)(object)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Tab Groups")]
	[Editor(typeof(RibbonTabItemGroupCollectionEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public RibbonTabItemGroupCollection TabGroups => ribbonTabItemGroupCollection_0;

	[Browsable(true)]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[DefaultValue(eDotNetBarStyle.Office2003)]
	[Description("Specifies the visual style of the control.")]
	public eDotNetBarStyle Style
	{
		get
		{
			return ribbonStripContainerItem_0.Style;
		}
		set
		{
			base.ColorScheme.EDotNetBarStyle_0 = value;
			ribbonStripContainerItem_0.Style = value;
			((Control)this).Invalidate();
			RecalcLayout();
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public SubItemsCollection Items => ribbonStripContainerItem_0.RibbonStripContainer.SubItems;

	[Browsable(false)]
	public RibbonTabItem SelectedRibbonTabItem
	{
		get
		{
			foreach (BaseItem item in Items)
			{
				if (item is RibbonTabItem && ((RibbonTabItem)item).Checked)
				{
					return (RibbonTabItem)item;
				}
			}
			return null;
		}
	}

	internal bool Boolean_4
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Invalid comparison between Unknown and I4
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				return (int)val.get_WindowState() == 2;
			}
			return false;
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(null)]
	[Category("Tab Groups")]
	public Font DefaultGroupFont
	{
		get
		{
			return font_1;
		}
		set
		{
			font_1 = value;
			if (((Component)(object)this).DesignMode)
			{
				((Control)this).Refresh();
			}
		}
	}

	internal bool Boolean_5
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
	public bool IsInKeyTipsMode => bool_31 | ShowKeyTips;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public SubItemsCollection QuickToolbarItems => ribbonStripContainerItem_0.CaptionContainer.SubItems;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public GenericItemContainer CaptionContainerItem => ribbonStripContainerItem_0.CaptionContainer;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public GenericItemContainer StripContainerItem => ribbonStripContainerItem_0.RibbonStripContainer;

	[Description("Occurs when text markup link from TitleText markup is clicked.")]
	public event MarkupLinkClickEventHandler TitleTextMarkupLinkClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Combine(markupLinkClickEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Remove(markupLinkClickEventHandler_0, value);
		}
	}

	public RibbonStrip()
	{
		((Control)this).SetStyle((ControlStyles)4096, true);
		ribbonStripContainerItem_0 = new RibbonStripContainerItem(this);
		ribbonStripContainerItem_0.GlobalItem = false;
		ribbonStripContainerItem_0.ContainerControl = this;
		ribbonStripContainerItem_0.Displayed = true;
		ribbonStripContainerItem_0.method_6(this);
		ribbonStripContainerItem_0.Style = eDotNetBarStyle.Office2003;
		SetBaseItemContainer(ribbonStripContainerItem_0);
		base.ColorScheme.EDotNetBarStyle_0 = eDotNetBarStyle.Office2003;
		((Control)this).set_AutoSize(true);
		ribbonTabItemGroupCollection_0 = new RibbonTabItemGroupCollection();
		ribbonTabItemGroupCollection_0.RibbonStrip_0 = this;
		ribbonStripContainerItem_0.SystemCaptionItem.Click += method_45;
	}

	private void method_24(object sender, EventArgs e)
	{
		if (sender is Class262 @class && markupLinkClickEventHandler_0 != null)
		{
			markupLinkClickEventHandler_0(this, new MarkupLinkClickEventArgs(@class.String_1, @class.String_0));
		}
	}

	private void method_25()
	{
		ribbonStripContainerItem_0.NeedRecalcSize = true;
		RecalcLayout();
	}

	internal override ItemPaintArgs vmethod_5(Graphics graphics_0)
	{
		ItemPaintArgs itemPaintArgs = base.vmethod_5(graphics_0);
		if (((Control)this).get_Parent() is RibbonControl ribbonControl)
		{
			itemPaintArgs.ControlExpanded = ribbonControl.Expanded || ribbonControl.IsPopupMode;
		}
		return itemPaintArgs;
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 132)
		{
			int x = Class51.smethod_4(((Message)(ref m)).get_LParam());
			int y = Class51.smethod_5(((Message)(ref m)).get_LParam());
			Point pt = ((Control)this).PointToClient(new Point(x, y));
			if (Boolean_6 && CaptionVisible)
			{
				Rectangle rectangle = new Rectangle(((Control)this).get_Width() - SystemInformation.get_CaptionButtonSize().Width * 3, 0, SystemInformation.get_CaptionButtonSize().Width * 3, SystemInformation.get_CaptionButtonSize().Height);
				if (rectangle.Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(-1));
					return;
				}
				if (new Rectangle(0, 0, ((Control)this).get_Width(), 4).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(-1));
					return;
				}
			}
			else if (CaptionVisible && !Boolean_4 && new Rectangle(0, 0, ((Control)this).get_Width(), 4).Contains(pt))
			{
				((Message)(ref m)).set_Result(new IntPtr(-1));
				return;
			}
		}
		base.WndProc(ref m);
	}

	protected override void ClearBackground(ItemPaintArgs pa)
	{
		if (Boolean_6)
		{
			if (((Control)this).FindForm() is Office2007RibbonForm office2007RibbonForm)
			{
				pa.Graphics.Clear(Color.Transparent);
				pa.Graphics.SetClip(new Rectangle(0, 0, ((Control)this).get_Width(), office2007RibbonForm.Int32_1 - 1), (CombineMode)4);
			}
			base.ClearBackground(pa);
			pa.Graphics.ResetClip();
		}
		else
		{
			base.ClearBackground(pa);
		}
	}

	protected override void PaintControlBackground(ItemPaintArgs pa)
	{
		bool flag = false;
		if (Boolean_6 && ((Control)this).FindForm() is Office2007RibbonForm office2007RibbonForm)
		{
			pa.Graphics.SetClip(new Rectangle(0, 0, ((Control)this).get_Width(), office2007RibbonForm.Int32_1 - 1), (CombineMode)4);
			flag = true;
		}
		base.PaintControlBackground(pa);
		if (flag)
		{
			pa.Graphics.ResetClip();
		}
		rectangle_1 = Rectangle.Empty;
		rectangle_0 = Rectangle.Empty;
		rectangle_2 = Rectangle.Empty;
		BaseRenderer renderer = GetRenderer();
		if (renderer != null && ((Control)this).get_Parent() is RibbonControl)
		{
			renderer.DrawRibbonControlBackground(new RibbonControlRendererEventArgs(pa.Graphics, ((Control)this).get_Parent() as RibbonControl, pa.GlassEnabled));
			if (bool_26)
			{
				renderer.DrawQuickAccessToolbarBackground(new RibbonControlRendererEventArgs(pa.Graphics, ((Control)this).get_Parent() as RibbonControl, pa.GlassEnabled));
			}
		}
		if (bool_25)
		{
			method_26(pa);
		}
		if (renderer != null && bool_26)
		{
			RibbonControlRendererEventArgs ribbonControlRendererEventArgs = new RibbonControlRendererEventArgs(pa.Graphics, ((Control)this).get_Parent() as RibbonControl, pa.GlassEnabled);
			ribbonControlRendererEventArgs.itemPaintArgs_0 = pa;
			renderer.DrawRibbonFormCaptionText(ribbonControlRendererEventArgs);
		}
		if (Class92.smethod_0())
		{
			pa.Graphics.Clear(Color.White);
			Class55.smethod_1(pa.Graphics, "Trial Version Expired", ((Control)this).get_Font(), Color.FromArgb(128, Color.Black), ((Control)this).get_ClientRectangle(), eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter);
		}
		else
		{
			Class55.smethod_1(pa.Graphics, "", ((Control)this).get_Font(), Color.FromArgb(128, Color.Black), ((Control)this).get_ClientRectangle(), eTextFormat.Right);
		}
	}

	private void method_26(ItemPaintArgs itemPaintArgs_0)
	{
		if (ribbonTabItemGroupCollection_0.Count == 0)
		{
			return;
		}
		RibbonTabItemGroup ribbonTabItemGroup = null;
		Rectangle rectangle_ = Rectangle.Empty;
		Rectangle rectangle_2 = Rectangle.Empty;
		int num = 0;
		if (bool_26)
		{
			num += 3;
		}
		foreach (RibbonTabItemGroup tabGroup in TabGroups)
		{
			tabGroup.arrayList_0.Clear();
		}
		foreach (BaseItem item in Items)
		{
			if (Class92.smethod_0())
			{
				return;
			}
			if (item is RibbonTabItem)
			{
				RibbonTabItem ribbonTabItem = item as RibbonTabItem;
				if (ribbonTabItem.Group != ribbonTabItemGroup)
				{
					if (ribbonTabItem.Visible)
					{
						if (ribbonTabItemGroup != null)
						{
							method_27(itemPaintArgs_0, ribbonTabItemGroup, rectangle_, rectangle_2);
						}
						ribbonTabItemGroup = ribbonTabItem.Group;
						if (ribbonTabItemGroup != null)
						{
							ribbonTabItemGroup.arrayList_0.Clear();
							rectangle_ = new Rectangle(ribbonTabItem.DisplayRectangle.X, num, ribbonTabItem.DisplayRectangle.Width, ribbonTabItem.DisplayRectangle.Y - 4);
							rectangle_2 = new Rectangle(ribbonTabItem.DisplayRectangle.X, num, ribbonTabItem.DisplayRectangle.Width, ribbonTabItem.DisplayRectangle.Bottom - int_4);
						}
					}
				}
				else if (ribbonTabItemGroup != null)
				{
					if (ribbonTabItem.Visible)
					{
						rectangle_.Width += ribbonTabItem.DisplayRectangle.Right - rectangle_.Right;
						rectangle_2.Width += ribbonTabItem.DisplayRectangle.Right - rectangle_2.Right;
					}
				}
				else
				{
					rectangle_ = Rectangle.Empty;
					rectangle_2 = Rectangle.Empty;
				}
			}
			else if (ribbonTabItemGroup != null)
			{
				method_27(itemPaintArgs_0, ribbonTabItemGroup, rectangle_, rectangle_2);
			}
		}
		if (ribbonTabItemGroup != null)
		{
			method_27(itemPaintArgs_0, ribbonTabItemGroup, rectangle_, rectangle_2);
		}
	}

	private void method_27(ItemPaintArgs itemPaintArgs_0, RibbonTabItemGroup ribbonTabItemGroup_0, Rectangle rectangle_5, Rectangle rectangle_6)
	{
		if ((!bool_26 || rectangle_1.IsEmpty || !rectangle_5.IntersectsWith(rectangle_1)) && !rectangle_2.IntersectsWith(rectangle_6))
		{
			ribbonTabItemGroup_0.arrayList_0.Add(rectangle_5);
			if (Class109.smethod_69(Style))
			{
				RibbonTabGroupRendererEventArgs e = new RibbonTabGroupRendererEventArgs(itemPaintArgs_0.Graphics, ribbonTabItemGroup_0, rectangle_5, rectangle_6, method_28(), itemPaintArgs_0);
				BaseRenderer renderer = GetRenderer();
				renderer.DrawRibbonTabGroup(e);
			}
			else
			{
				ElementStyleDisplayInfo e2 = new ElementStyleDisplayInfo(ribbonTabItemGroup_0.Style, itemPaintArgs_0.Graphics, rectangle_5);
				ElementStyleDisplay.Paint(e2);
				ElementStyleDisplay.PaintText(e2, ribbonTabItemGroup_0.GroupTitle, method_28());
			}
		}
	}

	private Font method_28()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		if (font_1 == null)
		{
			try
			{
				if (font_2 == null)
				{
					font_2 = new Font(((Control)this).get_Font().get_Name(), ((Control)this).get_Font().get_SizeInPoints() - 1f);
				}
			}
			catch
			{
				return ((Control)this).get_Font();
			}
			return font_2;
		}
		return font_1;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDefaultGroupFont()
	{
		TypeDescriptor.GetProperties(this)["DefaultGroupFont"]!.SetValue(this, null);
	}

	protected override void OnFontChanged(EventArgs e)
	{
		base.OnFontChanged(e);
		font_1 = null;
	}

	protected override ElementStyle GetBackgroundStyle()
	{
		if (base.BackgroundStyle.Custom)
		{
			return base.GetBackgroundStyle();
		}
		return elementStyle_1;
	}

	internal void method_29()
	{
		elementStyle_1.method_4(GetColorScheme());
		RibbonPredefinedColorSchemes.smethod_1(elementStyle_1, (RibbonControl)(object)((Control)this).get_Parent());
	}

	internal ElementStyle method_30()
	{
		return GetBackgroundStyle();
	}

	internal Rectangle method_31()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		Rectangle itemContainerRectangle = base.GetItemContainerRectangle();
		if (bool_25)
		{
			itemContainerRectangle.Y += int_4 + 1;
		}
		if (bool_26)
		{
			itemContainerRectangle.Y += method_34();
		}
		if (bool_26 && int_6 > 0)
		{
			if ((int)((Control)this).get_RightToLeft() == 0)
			{
				itemContainerRectangle.X += int_6;
			}
			itemContainerRectangle.Width -= int_6;
		}
		return itemContainerRectangle;
	}

	internal Rectangle method_32()
	{
		Rectangle itemContainerRectangle = base.GetItemContainerRectangle();
		if (Boolean_6)
		{
			itemContainerRectangle.Y += 3;
		}
		return new Rectangle(itemContainerRectangle.X, itemContainerRectangle.Y, itemContainerRectangle.Width, method_34());
	}

	private int method_33()
	{
		if (int_5 == 0)
		{
			int num = 16;
			if (Boolean_6)
			{
				num += 2;
			}
			return num;
		}
		return int_5;
	}

	internal int method_34()
	{
		return method_33() + ((!bool_25) ? int_4 : 0);
	}

	internal int method_35()
	{
		return method_33() + int_4;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		method_29();
		base.OnPaint(e);
	}

	protected override void RecalcSize()
	{
		method_29();
		base.RecalcSize();
	}

	public override int GetAutoSizeHeight()
	{
		int num = base.GetAutoSizeHeight();
		if (Style == eDotNetBarStyle.Office2007)
		{
			BaseRenderer renderer = GetRenderer();
			if (renderer is Office2007Renderer)
			{
				num += ((Office2007Renderer)renderer).ColorTable.RibbonControl.CornerSize;
			}
		}
		return num;
	}

	protected override bool vmethod_0(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		Rectangle displayRectangle = ((Control)this).get_DisplayRectangle();
		displayRectangle.Location = ((Control)this).PointToScreen(displayRectangle.Location);
		RibbonControl ribbonControl = ((Control)this).get_Parent() as RibbonControl;
		if (((Control)this).get_Parent() is RibbonControl)
		{
			displayRectangle = ((Control)this).get_Parent().get_DisplayRectangle();
			displayRectangle.Location = ((Control)this).get_Parent().PointToScreen(displayRectangle.Location);
			if (ribbonControl.SelectedRibbonTabItem != null && ribbonControl.SelectedRibbonTabItem.Panel != null && ((IKeyTipsControl)ribbonControl.SelectedRibbonTabItem.Panel).ShowKeyTips)
			{
				return false;
			}
		}
		Point mousePosition = Control.get_MousePosition();
		bool flag = true;
		if (ribbonControl != null)
		{
			flag = ribbonControl.Expanded;
		}
		bool flag2 = true;
		Form val = ((Control)this).FindForm();
		if (val != null && !Class109.smethod_65(val))
		{
			flag2 = false;
		}
		if (flag2 && displayRectangle.Contains(mousePosition) && !ShowKeyTips && flag && Items.Count > 0)
		{
			IntPtr intPtr = Class92.WindowFromPoint(new Class92.POINT(mousePosition));
			Control val2 = Control.FromChildHandle(intPtr);
			if (val2 == null)
			{
				val2 = Control.FromHandle(intPtr);
			}
			if (val2 is RibbonBar || val2 is RibbonStrip || val2 is RibbonControl || val2 is RibbonPanel)
			{
				RibbonTabItem selectedRibbonTabItem = SelectedRibbonTabItem;
				int num = 0;
				int num2 = Items.Count - 1;
				int num3 = 1;
				if (intptr_3.ToInt64() > 0L)
				{
					num3 = -1;
					num2 = 0;
				}
				if (selectedRibbonTabItem != null)
				{
					num = Items.IndexOf(selectedRibbonTabItem) + num3;
					if (num == Items.Count)
					{
						num = 0;
					}
					else if (num < 0)
					{
						num = Items.Count - 1;
					}
				}
				int num4 = num - num3;
				do
				{
					num4 += num3;
					if (num4 < 0 || num4 > Items.Count - 1)
					{
						break;
					}
					if (Items[num4] is RibbonTabItem && Items[num4].Visible)
					{
						((RibbonTabItem)Items[num4]).Checked = true;
						return true;
					}
				}
				while (num4 != num2);
			}
		}
		return false;
	}

	private ArrayList method_36()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		ArrayList arrayList = new ArrayList();
		if (!(((Control)this).get_Parent() is RibbonControl))
		{
			return arrayList;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Parent().get_Controls())
		{
			Control control_ = item;
			method_37(control_, arrayList);
		}
		RibbonControl ribbonControl = ((Control)this).get_Parent() as RibbonControl;
		if (!ribbonControl.Expanded && SelectedRibbonTabItem != null && SelectedRibbonTabItem.Panel != null && ((Control)SelectedRibbonTabItem.Panel).get_Parent() != ribbonControl)
		{
			method_37((Control)(object)SelectedRibbonTabItem.Panel, arrayList);
		}
		return arrayList;
	}

	private void method_37(Control control_0, ArrayList arrayList_1)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		if (control_0 is RibbonBar)
		{
			arrayList_1.Add(control_0);
		}
		foreach (Control item in (ArrangedElementCollection)control_0.get_Controls())
		{
			Control control_ = item;
			method_37(control_, arrayList_1);
		}
	}

	public override ArrayList GetItems(string ItemName)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_46(method_17(), ItemName, arrayList);
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl != null && ribbonControl.QatPositionedBelowRibbon)
		{
			Class109.smethod_46(ribbonControl.Control7_0.method_17(), ItemName, arrayList);
		}
		ArrayList arrayList2 = method_36();
		foreach (RibbonBar item in arrayList2)
		{
			Class109.smethod_46(item.method_17(), ItemName, arrayList);
		}
		if (ribbonControl != null && ribbonControl.GlobalContextMenuBar != null)
		{
			Class109.smethod_46(ribbonControl.GlobalContextMenuBar.ItemsContainer, ItemName, arrayList);
		}
		return arrayList;
	}

	public override ArrayList GetItems(string ItemName, Type itemType)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_48(method_17(), ItemName, arrayList, itemType);
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl != null && ribbonControl.QatPositionedBelowRibbon)
		{
			Class109.smethod_48(ribbonControl.Control7_0.method_17(), ItemName, arrayList, itemType);
		}
		ArrayList arrayList2 = method_36();
		foreach (RibbonBar item in arrayList2)
		{
			Class109.smethod_48(item.method_17(), ItemName, arrayList, itemType);
		}
		if (ribbonControl != null && ribbonControl.GlobalContextMenuBar != null)
		{
			Class109.smethod_48(ribbonControl.GlobalContextMenuBar.ItemsContainer, ItemName, arrayList, itemType);
		}
		return arrayList;
	}

	public override ArrayList GetItems(string ItemName, Type itemType, bool useGlobalName)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_49(method_17(), ItemName, arrayList, itemType, useGlobalName);
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl != null && ribbonControl.QatPositionedBelowRibbon)
		{
			Class109.smethod_49(ribbonControl.Control7_0.method_17(), ItemName, arrayList, itemType, useGlobalName);
		}
		ArrayList arrayList2 = method_36();
		foreach (RibbonBar item in arrayList2)
		{
			Class109.smethod_49(item.method_17(), ItemName, arrayList, itemType, useGlobalName);
		}
		if (ribbonControl != null && ribbonControl.GlobalContextMenuBar != null)
		{
			Class109.smethod_49(ribbonControl.GlobalContextMenuBar.ItemsContainer, ItemName, arrayList, itemType, useGlobalName);
		}
		return arrayList;
	}

	public override BaseItem GetItem(string ItemName)
	{
		BaseItem baseItem = Class109.smethod_44(method_17(), ItemName);
		if (baseItem != null)
		{
			return baseItem;
		}
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl != null && ribbonControl.QatPositionedBelowRibbon)
		{
			baseItem = Class109.smethod_44(ribbonControl.Control7_0.method_17(), ItemName);
			if (baseItem != null)
			{
				return baseItem;
			}
		}
		ArrayList arrayList = method_36();
		foreach (RibbonBar item in arrayList)
		{
			baseItem = Class109.smethod_44(item.method_17(), ItemName);
			if (baseItem != null)
			{
				return baseItem;
			}
		}
		if (ribbonControl != null && ribbonControl.GlobalContextMenuBar != null)
		{
			return Class109.smethod_44(ribbonControl.GlobalContextMenuBar.ItemsContainer, ItemName);
		}
		return null;
	}

	internal void method_38(RibbonBar ribbonBar_0)
	{
		if (!bool_31)
		{
			bool_31 = true;
		}
		if (ikeyTipsControl_0 != ((Control)ribbonBar_0).get_Parent() && ((Control)ribbonBar_0).get_Parent() is RibbonPanel)
		{
			if (ikeyTipsControl_0 != null)
			{
				ikeyTipsControl_0.ShowKeyTips = false;
			}
			ikeyTipsControl_0 = ((Control)ribbonBar_0).get_Parent() as IKeyTipsControl;
			if (ikeyTipsControl_0 != null)
			{
				ikeyTipsControl_0.ShowKeyTips = true;
			}
		}
	}

	protected override void OnShowKeyTipsChanged()
	{
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl != null && ribbonControl.QatPositionedBelowRibbon)
		{
			ribbonControl.Control7_0.ShowKeyTips = ShowKeyTips;
		}
		base.OnShowKeyTipsChanged();
		if (ShowKeyTips && !bool_31)
		{
			method_40();
		}
	}

	protected override bool vmethod_1(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected I4, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Invalid comparison between Unknown and I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Invalid comparison between Unknown and I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Invalid comparison between Unknown and I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Invalid comparison between Unknown and I4
		if (intptr_3.ToInt32() == 27)
		{
			GetRibbonControl()?.method_17();
		}
		if (bool_31)
		{
			if (base.Boolean_0)
			{
				base.vmethod_1(intptr_2, intptr_3, intptr_4);
				if (!base.Boolean_0)
				{
					method_41();
				}
			}
			Keys val = (Keys)Class92.MapVirtualKey((uint)(int)intptr_3, 2u);
			if ((int)val == 0)
			{
				val = (Keys)intptr_3.ToInt32();
			}
			if ((int)val == 27)
			{
				bool flag = false;
				if (!ShowKeyTips && ikeyTipsControl_0 != null && ikeyTipsControl_0 is RibbonPanel)
				{
					flag = true;
				}
				method_41();
				if (flag)
				{
					method_40();
				}
				return base.vmethod_1(intptr_2, intptr_3, intptr_4);
			}
			char c = method_39((int)val);
			if (c == '\0')
			{
				method_41();
				return true;
			}
			if ((int)val != 32 && (int)val != 40 && (int)val != 39 && (int)val != 9)
			{
				if (((Control)this).ProcessMnemonic(c))
				{
					return true;
				}
				return true;
			}
			method_41();
			return false;
		}
		if (intptr_3.ToInt32() == 112 && (int)Control.get_ModifierKeys() == 131072)
		{
			Form form_ = ((Control)this).FindForm();
			if (Class109.smethod_65(form_))
			{
				RibbonControl ribbonControl = GetRibbonControl();
				if (ribbonControl.AutoExpand)
				{
					ribbonControl.Expanded = !ribbonControl.Expanded;
				}
			}
		}
		return base.vmethod_1(intptr_2, intptr_3, intptr_4);
	}

	private char method_39(int int_7)
	{
		char[] array = new char[1];
		byte[] array2 = new byte[1];
		try
		{
			array2[0] = Convert.ToByte(int_7);
			Encoding.Default.GetDecoder().GetChars(array2, 0, 1, array, 0);
		}
		catch (Exception)
		{
			return '\0';
		}
		return array[0];
	}

	protected override bool vmethod_3(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		if (intptr_3.ToInt32() == 18 || intptr_3.ToInt32() == 121)
		{
			bool flag = true;
			if (bool_31)
			{
				if (intptr_3.ToInt32() == 18 || intptr_3.ToInt32() == 121)
				{
					flag = false;
				}
				method_41();
			}
			else
			{
				Form val = ((Control)this).FindForm();
				if (val == Form.get_ActiveForm())
				{
					flag = false;
					method_40();
				}
			}
			if (!flag)
			{
				return true;
			}
		}
		return base.vmethod_3(intptr_2, intptr_3, intptr_4);
	}

	private void method_40()
	{
		if (bool_29)
		{
			bool_31 = true;
			ShowKeyTips = true;
			SetupActiveWindowTimer();
		}
	}

	private void method_41()
	{
		if (bool_31)
		{
			ReleaseActiveWindowTimer();
			if (!ShowKeyTips && ikeyTipsControl_0 != null)
			{
				ikeyTipsControl_0.ShowKeyTips = false;
				ikeyTipsControl_0 = null;
			}
			ShowKeyTips = false;
		}
		bool_31 = false;
	}

	public void ExitKeyTipsMode()
	{
		method_41();
	}

	internal void method_42(BaseItem baseItem_6)
	{
		if (ShowKeyTips || (ikeyTipsControl_0 != null && ikeyTipsControl_0.ShowKeyTips))
		{
			ShowKeyTips = false;
			method_41();
		}
	}

	protected override bool OnSysMouseDown(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
	{
		if (ShowKeyTips || (ikeyTipsControl_0 != null && ikeyTipsControl_0.ShowKeyTips))
		{
			ShowKeyTips = false;
			method_41();
		}
		GetRibbonControl()?.method_18(hWnd, wParam, lParam);
		return base.OnSysMouseDown(hWnd, wParam, lParam);
	}

	protected override bool ProcessMnemonic(char charCode)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		if (ikeyTipsControl_0 != null)
		{
			if (ikeyTipsControl_0.ProcessMnemonicEx(charCode))
			{
				method_41();
				return true;
			}
			return false;
		}
		if (!bool_31 && (Control.get_ModifierKeys() & 0x40000) != 262144)
		{
			return false;
		}
		return base.ProcessMnemonic(charCode);
	}

	public override bool ProcessMnemonicEx(char charCode)
	{
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		BaseItem baseItem = null;
		if (bool_26)
		{
			baseItem = GetItemForMnemonic(ribbonStripContainerItem_0.CaptionContainer, charCode, deepScan: false, stackKeys: true);
			if (baseItem != null && ProcessItemMnemonicKey(baseItem))
			{
				method_41();
				return true;
			}
		}
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl != null && ribbonControl.QatPositionedBelowRibbon && ribbonControl.Control7_0.ProcessMnemonicEx(charCode))
		{
			method_41();
			return true;
		}
		if (baseItem == null)
		{
			baseItem = GetItemForMnemonic(method_17(), charCode, deepScan: true, stackKeys: true);
		}
		if (baseItem is RibbonTabItem && baseItem.Visible)
		{
			if (!bool_31)
			{
				method_40();
			}
			ShowKeyTips = false;
			if (baseItem != SelectedRibbonTabItem)
			{
				baseItem.RaiseClick();
			}
			else if (SelectedRibbonTabItem != null && ribbonControl != null && !ribbonControl.Expanded && !ribbonControl.IsPopupMode)
			{
				ribbonControl.method_21(SelectedRibbonTabItem);
			}
			if (SelectedRibbonTabItem != null && bool_29)
			{
				if (ikeyTipsControl_0 != null)
				{
					ikeyTipsControl_0.ShowKeyTips = false;
				}
				ikeyTipsControl_0 = SelectedRibbonTabItem.Panel;
				if (ikeyTipsControl_0 != null)
				{
					ikeyTipsControl_0.ShowKeyTips = true;
				}
			}
			return true;
		}
		if (baseItem != null && ProcessItemMnemonicKey(baseItem))
		{
			ShowKeyTips = false;
			return true;
		}
		if (bool_31 && SelectedRibbonTabItem != null && SelectedRibbonTabItem.Panel != null)
		{
			Control panel = (Control)(object)SelectedRibbonTabItem.Panel;
			foreach (Control item in (ArrangedElementCollection)panel.get_Controls())
			{
				Control val = item;
				if (val is RibbonBar && val.get_Visible() && Control.IsMnemonic(charCode, val.get_Text()))
				{
					ShowKeyTips = false;
					((RibbonBar)(object)val).ShowKeyTips = true;
					if (ikeyTipsControl_0 != null)
					{
						ikeyTipsControl_0.ShowKeyTips = false;
					}
					ikeyTipsControl_0 = (IKeyTipsControl)val;
					return true;
				}
			}
		}
		return false;
	}

	protected override void OnActiveWindowChanged()
	{
		method_41();
		base.OnActiveWindowChanged();
	}

	protected override void OnPopupItemRightClick(BaseItem item)
	{
		GetRibbonControl()?.vmethod_0(item, bool_18: false);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		if (class261_0 != null)
		{
			class261_0.method_4((Control)(object)this);
		}
		base.OnMouseLeave(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Invalid comparison between Unknown and I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Invalid comparison between Unknown and I4
		bool_32 = false;
		if (bool_26)
		{
			bool_32 = HitTestCaption(new Point(e.get_X(), e.get_Y()));
			if ((int)e.get_Button() == 2097152 && bool_32)
			{
				Form val = ((Control)this).FindForm();
				if (val != null)
				{
					Point mousePosition = Control.get_MousePosition();
					byte[] bytes = BitConverter.GetBytes(mousePosition.X);
					byte[] bytes2 = BitConverter.GetBytes(mousePosition.Y);
					byte[] value = new byte[4]
					{
						bytes[0],
						bytes[1],
						bytes2[0],
						bytes2[1]
					};
					int lParam = BitConverter.ToInt32(value, 0);
					((Control)this).set_Capture(false);
					Class92.SendMessage(((Control)val).get_Handle(), 274, Class92.TrackPopupMenu(Class92.GetSystemMenu(((Control)val).get_Handle(), bRevert: false), 256u, Control.get_MousePosition().X, Control.get_MousePosition().Y, 0, ((Control)val).get_Handle(), IntPtr.Zero), lParam);
					return;
				}
			}
			if (class261_0 != null)
			{
				class261_0.method_6((Control)(object)this, e);
			}
			e = method_44(e);
		}
		if ((int)e.get_Button() == 2097152 && Rectangle_2.Contains(e.get_X(), e.get_Y()))
		{
			GetRibbonControl()?.method_32(this, e.get_X(), e.get_Y());
		}
		else if ((int)e.get_Button() == 1048576 && bool_26 && bool_25 && !ribbonStripContainerItem_0.RibbonStripContainer.DisplayRectangle.Contains(e.get_X(), e.get_Y()))
		{
			foreach (RibbonTabItemGroup tabGroup in TabGroups)
			{
				if (!tabGroup.Visible)
				{
					continue;
				}
				foreach (Rectangle item in tabGroup.arrayList_0)
				{
					if (item.Contains(e.get_X(), e.get_Y()))
					{
						if (!tabGroup.IsTabFromGroupSelected)
						{
							tabGroup.SelectFirstTab();
							return;
						}
						break;
					}
				}
			}
		}
		base.OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (bool_26)
		{
			if (class261_0 != null)
			{
				class261_0.method_7((Control)(object)this, e);
			}
			e = method_44(e);
		}
		bool_32 = false;
		base.OnMouseUp(e);
	}

	internal BaseItem method_43()
	{
		if (!CaptionVisible)
		{
			return null;
		}
		BaseItem captionContainerItem = CaptionContainerItem;
		if (captionContainerItem.SubItems.Count > 0 && captionContainerItem.SubItems[0] is Office2007StartButton)
		{
			return captionContainerItem.SubItems[0];
		}
		if (captionContainerItem.SubItems.Count > 0 && captionContainerItem.SubItems[0] is ButtonItem && ((ButtonItem)captionContainerItem.SubItems[0]).HotTrackingStyle == eHotTrackingStyle.Image)
		{
			return captionContainerItem.SubItems[0];
		}
		return null;
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (bool_26)
		{
			if ((int)e.get_Button() == 1048576 && bool_32 && HitTestCaption(new Point(e.get_X(), e.get_Y())))
			{
				Form val = ((Control)this).FindForm();
				if (val != null && (int)val.get_WindowState() == 0)
				{
					if (method_43() is PopupItem popupItem && popupItem.Expanded)
					{
						popupItem.Expanded = false;
					}
					Point mousePosition = Control.get_MousePosition();
					byte[] bytes = BitConverter.GetBytes(mousePosition.X);
					byte[] bytes2 = BitConverter.GetBytes(mousePosition.Y);
					byte[] value = new byte[4]
					{
						bytes[0],
						bytes[1],
						bytes2[0],
						bytes2[1]
					};
					int lParam = BitConverter.ToInt32(value, 0);
					((Control)this).set_Capture(false);
					Class92.SendMessage(((Control)val).get_Handle(), 274, 61458, lParam);
					bool_32 = false;
					return;
				}
			}
			if (class261_0 != null)
			{
				class261_0.method_5((Control)(object)this, e);
			}
			e = method_44(e);
		}
		base.OnMouseMove(e);
	}

	protected override void InternalOnClick(MouseButtons mb, Point mousePos)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (bool_26)
		{
			MouseEventArgs mouseEventArgs_ = new MouseEventArgs(mb, 0, mousePos.X, mousePos.Y, 0);
			mouseEventArgs_ = method_44(mouseEventArgs_);
			mousePos = new Point(mouseEventArgs_.get_X(), mouseEventArgs_.get_Y());
		}
		base.InternalOnClick(mb, mousePos);
	}

	private MouseEventArgs method_44(MouseEventArgs mouseEventArgs_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (mouseEventArgs_0.get_Y() <= 6)
		{
			Form val = ((Control)this).FindForm();
			if (val != null && (int)val.get_WindowState() == 2 && val is Office2007RibbonForm)
			{
				if (mouseEventArgs_0.get_X() > 4)
				{
					mouseEventArgs_0 = ((mouseEventArgs_0.get_X() < ((Control)this).get_Width() - 6) ? new MouseEventArgs(mouseEventArgs_0.get_Button(), mouseEventArgs_0.get_Clicks(), mouseEventArgs_0.get_X(), CaptionContainerItem.TopInternal + 5, mouseEventArgs_0.get_Delta()) : new MouseEventArgs(mouseEventArgs_0.get_Button(), mouseEventArgs_0.get_Clicks(), SystemCaptionItem_0.DisplayRectangle.Right - 4, SystemCaptionItem_0.DisplayRectangle.Top + 4, mouseEventArgs_0.get_Delta()));
				}
				else
				{
					BaseItem baseItem = method_43();
					if (baseItem != null)
					{
						mouseEventArgs_0 = new MouseEventArgs(mouseEventArgs_0.get_Button(), mouseEventArgs_0.get_Clicks(), baseItem.LeftInternal + 1, baseItem.TopInternal + 1, mouseEventArgs_0.get_Delta());
					}
				}
			}
		}
		return mouseEventArgs_0;
	}

	protected override void OnClick(EventArgs e)
	{
		if (bool_26 && class261_0 != null)
		{
			class261_0.method_8((Control)(object)this);
		}
		base.OnClick(e);
	}

	protected override void OnDoubleClick(EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if (bool_26)
		{
			Point p = ((Control)this).PointToClient(Control.get_MousePosition());
			if (HitTestCaption(p))
			{
				Form val = ((Control)this).FindForm();
				if (val != null && val.get_MaximizeBox() && ((int)val.get_FormBorderStyle() == 4 || (int)val.get_FormBorderStyle() == 6))
				{
					if ((int)val.get_WindowState() == 0)
					{
						Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61488, 0);
					}
					else if ((int)val.get_WindowState() == 2)
					{
						Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61728, 0);
					}
				}
			}
		}
		base.OnDoubleClick(e);
	}

	protected bool HitTestCaption(Point p)
	{
		if (rectangle_0.Contains(p) && rectangle_3 != null)
		{
			Rectangle[] array = rectangle_3;
			foreach (Rectangle rectangle in array)
			{
				if (rectangle.Contains(p))
				{
					return true;
				}
			}
		}
		return false;
	}

	private void method_45(object sender, EventArgs e)
	{
		SystemCaptionItem systemCaptionItem = sender as SystemCaptionItem;
		Form val = ((Control)this).FindForm();
		if (val != null)
		{
			if (systemCaptionItem.Enum13_0 == Enum13.const_1)
			{
				Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61472, 0);
			}
			else if (systemCaptionItem.Enum13_0 == Enum13.const_5)
			{
				Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61488, 0);
			}
			else if (systemCaptionItem.Enum13_0 == Enum13.const_2)
			{
				Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61728, 0);
			}
			else if (systemCaptionItem.Enum13_0 == Enum13.const_3)
			{
				Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61536, 0);
			}
			else if (systemCaptionItem.Enum13_0 == Enum13.const_4)
			{
				Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61824, 0);
			}
		}
	}

	protected override void OnResize(EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		base.OnResize(e);
		if (!bool_26)
		{
			return;
		}
		Form val = ((Control)this).FindForm();
		if (val != null)
		{
			if ((int)val.get_WindowState() != 2 && (int)val.get_WindowState() != 1)
			{
				ribbonStripContainerItem_0.SystemCaptionItem.RestoreEnabled = false;
			}
			else
			{
				ribbonStripContainerItem_0.SystemCaptionItem.RestoreEnabled = true;
			}
		}
	}

	protected override void vmethod_6(Graphics graphics_0)
	{
		if (ShowKeyTips)
		{
			KeyTipsRendererEventArgs keyTipsRendererEventArgs_ = new KeyTipsRendererEventArgs(graphics_0, Rectangle.Empty, "", GetKeyTipFont(), null);
			BaseRenderer renderer = GetRenderer();
			vmethod_7(ribbonStripContainerItem_0.RibbonStripContainer, renderer, keyTipsRendererEventArgs_);
			if (bool_26)
			{
				vmethod_7(ribbonStripContainerItem_0.CaptionContainer, renderer, keyTipsRendererEventArgs_);
			}
		}
	}

	protected override Rectangle GetKeyTipRectangle(Graphics g, BaseItem item, Font font, string keyTip)
	{
		Rectangle keyTipRectangle = base.GetKeyTipRectangle(g, item, font, keyTip);
		if (QuickToolbarItems.Contains(item))
		{
			keyTipRectangle.Y += 4;
		}
		return keyTipRectangle;
	}

	internal void method_46(bool bool_33)
	{
		if (ribbonStripContainerItem_0.RibbonStripContainer == null)
		{
			return;
		}
		bool flag = false;
		try
		{
			if (Items.Contains("dotnetbarsysiconitem"))
			{
				Items.Remove("dotnetbarsysiconitem");
				flag = true;
			}
			if (Items.Contains("dotnetbarsysmenuitem"))
			{
				Items.Remove("dotnetbarsysmenuitem");
				flag = true;
			}
			if (bool_33 && flag)
			{
				RecalcLayout();
			}
		}
		catch (Exception)
		{
		}
	}

	internal void method_47(Form form_0, bool bool_33)
	{
		method_46(bool_33);
		if (form_0 != null)
		{
			MDISystemItem mDISystemItem = new MDISystemItem("dotnetbarsysmenuitem");
			if (!form_0.get_ControlBox())
			{
				mDISystemItem.CloseEnabled = false;
			}
			if (!form_0.get_MinimizeBox())
			{
				mDISystemItem.MinimizeEnabled = false;
			}
			if (!form_0.get_MaximizeBox())
			{
				mDISystemItem.RestoreEnabled = false;
			}
			mDISystemItem.ItemAlignment = eItemAlignment.Far;
			mDISystemItem.Click += method_48;
			Items.Add(mDISystemItem);
			if (bool_33)
			{
				RecalcLayout();
			}
		}
	}

	private void method_48(object sender, EventArgs e)
	{
		MDISystemItem mDISystemItem = sender as MDISystemItem;
		Form val = ((Control)this).FindForm();
		if (val != null)
		{
			val = val.get_ActiveMdiChild();
		}
		if (val == null)
		{
			method_46(bool_33: true);
		}
		else if (mDISystemItem.Enum13_0 == Enum13.const_1)
		{
			Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61472, 0);
		}
		else if (mDISystemItem.Enum13_0 == Enum13.const_2)
		{
			Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61728, 0);
		}
		else if (mDISystemItem.Enum13_0 == Enum13.const_3)
		{
			Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61536, 0);
		}
		else if (mDISystemItem.Enum13_0 == Enum13.const_6)
		{
			Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61504, 0);
		}
	}

	internal void method_49(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseDown(mouseEventArgs_0);
	}

	internal void method_50(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseMove(mouseEventArgs_0);
	}

	internal void method_51(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
	}
}
