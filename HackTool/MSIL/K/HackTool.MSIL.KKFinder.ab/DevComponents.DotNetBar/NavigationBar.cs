using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[ToolboxItem(true)]
[ComVisible(false)]
[Designer(typeof(NavigationBarDesigner))]
public class NavigationBar : BarBaseControl, ISupportInitialize
{
	private const int int_1 = 6;

	private NavigationBarContainer navigationBarContainer_0;

	private bool bool_16;

	private Cursor cursor_3;

	private bool bool_17;

	private bool bool_18;

	private static RoundRectangleShapeDescriptor roundRectangleShapeDescriptor_0 = new RoundRectangleShapeDescriptor();

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public SubItemsCollection Items => navigationBarContainer_0.SubItems;

	[DevCoBrowsable(true)]
	[DefaultValue(true)]
	[Browsable(true)]
	[Category("Behavior")]
	[Description("Indicates Configure Buttons button is visible.")]
	public bool ConfigureItemVisible
	{
		get
		{
			return navigationBarContainer_0.ConfigureItemVisible;
		}
		set
		{
			navigationBarContainer_0.ConfigureItemVisible = value;
			RecalcLayout();
		}
	}

	[Description("Indicates whether Show More Buttons and Show Fewer Buttons menu items are visible on Configure buttons menu.")]
	[Browsable(true)]
	[Category("Behavior")]
	[DefaultValue(true)]
	[DevCoBrowsable(true)]
	public bool ConfigureShowHideVisible
	{
		get
		{
			return navigationBarContainer_0.ConfigureShowHideVisible;
		}
		set
		{
			navigationBarContainer_0.ConfigureShowHideVisible = value;
			RecalcLayout();
		}
	}

	[Category("Behavior")]
	[DefaultValue(true)]
	[Browsable(true)]
	[Description("Gets or sets whether Navigation Pane Options menu item is visible on Configure buttons menu.")]
	[DevCoBrowsable(true)]
	public bool ConfigureNavOptionsVisible
	{
		get
		{
			return navigationBarContainer_0.ConfigureNavOptionsVisible;
		}
		set
		{
			navigationBarContainer_0.ConfigureNavOptionsVisible = value;
			RecalcLayout();
		}
	}

	[DefaultValue(true)]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Description("Indicates whether Navigation Pane Add/Remove Buttons menu item is visible on Configure buttons menu.")]
	[Browsable(true)]
	public bool ConfigureAddRemoveVisible
	{
		get
		{
			return navigationBarContainer_0.ConfigureAddRemoveVisible;
		}
		set
		{
			navigationBarContainer_0.ConfigureAddRemoveVisible = value;
			RecalcLayout();
		}
	}

	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Browsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether summary line is visible.")]
	public bool SummaryLineVisible
	{
		get
		{
			return navigationBarContainer_0.SummaryLineVisible;
		}
		set
		{
			navigationBarContainer_0.SummaryLineVisible = value;
			RecalcLayout();
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(4)]
	[Description("Indicates the padding in pixels at the top portion of the item.")]
	[Category("Layout")]
	[Browsable(true)]
	public int ItemPaddingTop
	{
		get
		{
			return navigationBarContainer_0.ItemPaddingTop;
		}
		set
		{
			navigationBarContainer_0.ItemPaddingTop = value;
			if (((Component)(object)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[Description("Indicates the padding in pixels at the bottom of the item.")]
	[DefaultValue(4)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Layout")]
	public int ItemPaddingBottom
	{
		get
		{
			return navigationBarContainer_0.ItemPaddingBottom;
		}
		set
		{
			navigationBarContainer_0.ItemPaddingBottom = value;
			if (((Component)(object)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[Browsable(false)]
	public NavigationBarContainer ItemsContainer => navigationBarContainer_0;

	[Browsable(false)]
	public ButtonItem CheckedButton
	{
		get
		{
			foreach (BaseItem subItem in navigationBarContainer_0.SubItems)
			{
				if (subItem is ButtonItem && ((ButtonItem)subItem).Checked)
				{
					return subItem as ButtonItem;
				}
			}
			return null;
		}
	}

	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates whether images are automatically resized to size specified in ImageSizeSummaryLine when button is on the bottom summary line of navigation bar.")]
	[DefaultValue(true)]
	public bool AutoSizeButtonImage
	{
		get
		{
			return navigationBarContainer_0.AutoSizeButtonImage;
		}
		set
		{
			navigationBarContainer_0.AutoSizeButtonImage = value;
		}
	}

	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Indicates size of the image that will be use to resize images to when button button is on the bottom summary line of navigation bar and AutoSizeButtonImage=true.")]
	public Size ImageSizeSummaryLine
	{
		get
		{
			return navigationBarContainer_0.ImageSizeSummaryLine;
		}
		set
		{
			navigationBarContainer_0.ImageSizeSummaryLine = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string LayoutDefinition
	{
		get
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlElement xmlElement = xmlDocument.CreateElement("navbarlayout");
			xmlDocument.AppendChild(xmlElement);
			SaveLayout(xmlElement);
			return xmlDocument.OuterXml;
		}
		set
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(value);
			LoadLayout(xmlDocument.FirstChild as XmlElement);
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(eDotNetBarStyle.Office2003)]
	[DevCoBrowsable(true)]
	[Description("Specifies the visual style of the control.")]
	public eDotNetBarStyle Style
	{
		get
		{
			return navigationBarContainer_0.Style;
		}
		set
		{
			base.ColorScheme.EDotNetBarStyle_0 = value;
			navigationBarContainer_0.Style = value;
			method_12();
			RecalcLayout();
		}
	}

	internal IShapeDescriptor IShapeDescriptor_0 => roundRectangleShapeDescriptor_0;

	internal bool Boolean_0 => bool_17;

	[Category("Layout")]
	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether splitter on top of the navigation bar is visible.")]
	[Browsable(true)]
	public bool SplitterVisible
	{
		get
		{
			return bool_16;
		}
		set
		{
			bool_16 = value;
			if (((Component)(object)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	public NavigationBar()
	{
		navigationBarContainer_0 = new NavigationBarContainer();
		navigationBarContainer_0.GlobalItem = false;
		navigationBarContainer_0.ContainerControl = this;
		navigationBarContainer_0.Stretch = false;
		navigationBarContainer_0.Displayed = true;
		navigationBarContainer_0.Style = eDotNetBarStyle.Office2003;
		navigationBarContainer_0.method_6(this);
		SetBaseItemContainer(navigationBarContainer_0);
		SetDesignTimeDefaults();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		if (((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0)
		{
			RecalcSize();
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		RecalcSize();
	}

	protected override void RecalcSize()
	{
		if (bool_18 || !Class109.smethod_11((Control)(object)this))
		{
			return;
		}
		base.RecalcSize();
		if (!navigationBarContainer_0.IsRecalculatingSize)
		{
			Rectangle itemContainerRectangle = GetItemContainerRectangle();
			if (navigationBarContainer_0.HeightInternal > 0)
			{
				((Control)this).set_Height(navigationBarContainer_0.HeightInternal + itemContainerRectangle.Top + (((Control)this).get_ClientRectangle().Bottom - itemContainerRectangle.Bottom));
			}
		}
	}

	public override void SetDesignTimeDefaults()
	{
		base.SetDesignTimeDefaults();
		method_12();
		base.BackgroundStyle.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
		base.BackgroundStyle.Border = eBorderType.SingleLine;
	}

	private void method_12()
	{
		base.ColorScheme.ItemHotBorder = Color.Empty;
		base.ColorScheme.ItemBackground = base.ColorScheme.BarBackground;
		base.ColorScheme.ItemBackground2 = base.ColorScheme.BarBackground2;
		base.ColorScheme.ItemHotBorder = Color.Empty;
		base.ColorScheme.ItemPressedBorder = Color.Empty;
		base.ColorScheme.ItemCheckedBorder = Color.Empty;
		base.ColorScheme.ItemExpandedBackground = base.ColorScheme.ItemHotBackground;
		base.ColorScheme.ItemExpandedBackground2 = base.ColorScheme.ItemHotBackground2;
		base.ColorScheme.ItemExpandedShadow = Color.Empty;
		base.ColorScheme.ItemExpandedBorder = Color.Empty;
		base.ColorScheme.ResetChangedFlag();
		base.BackgroundStyle.method_1(base.ColorScheme);
	}

	protected override void OnSystemColorsChanged(EventArgs e)
	{
		((Control)this).OnSystemColorsChanged(e);
		Application.DoEvents();
		base.ColorScheme.Refresh();
		method_12();
	}

	public void ShowMoreButtons()
	{
		navigationBarContainer_0.ShowMoreButtons();
	}

	public void ShowFewerButtons()
	{
		navigationBarContainer_0.ShowFewerButtons();
	}

	protected override Rectangle GetItemContainerRectangle()
	{
		Rectangle itemContainerRectangle = base.GetItemContainerRectangle();
		if (bool_16)
		{
			itemContainerRectangle.Y += 6;
			itemContainerRectangle.Height -= 6;
		}
		return itemContainerRectangle;
	}

	protected override void PaintControlBackground(ItemPaintArgs pa)
	{
		base.PaintControlBackground(pa);
		PaintSplitter(pa);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeImageSizeSummaryLine()
	{
		if (navigationBarContainer_0.ImageSizeSummaryLine.Width == 16)
		{
			return navigationBarContainer_0.ImageSizeSummaryLine.Height != 16;
		}
		return true;
	}

	void ISupportInitialize.BeginInit()
	{
		bool_18 = true;
	}

	void ISupportInitialize.EndInit()
	{
		bool_18 = false;
		RecalcLayout();
	}

	public void SaveLayout(string fileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlElement xmlElement = xmlDocument.CreateElement("navbarlayout");
		xmlDocument.AppendChild(xmlElement);
		SaveLayout(xmlElement);
		xmlDocument.Save(fileName);
	}

	public void SaveLayout(XmlElement xmlParent)
	{
		if (Items.Count == 0)
		{
			return;
		}
		XmlElement xmlElement = xmlParent.OwnerDocument.CreateElement("navigationbar");
		xmlParent.AppendChild(xmlElement);
		xmlElement.SetAttribute("height", ((Control)this).get_Height().ToString());
		foreach (BaseItem item in Items)
		{
			if (item is ButtonItem && item.Name != "")
			{
				XmlElement xmlElement2 = xmlParent.OwnerDocument.CreateElement("item");
				xmlElement.AppendChild(xmlElement2);
				xmlElement2.SetAttribute("index", Items.IndexOf(item).ToString());
				xmlElement2.SetAttribute("name", item.Name);
				xmlElement2.SetAttribute("visible", XmlConvert.ToString(item.Visible));
				xmlElement2.SetAttribute("checked", XmlConvert.ToString(((ButtonItem)item).Checked));
			}
		}
	}

	public void LoadLayout(string fileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(fileName);
		LoadLayout(xmlDocument.FirstChild as XmlElement);
	}

	public void LoadLayout(XmlElement xmlParent)
	{
		if (Items.Count == 0)
		{
			return;
		}
		if (xmlParent.FirstChild is XmlElement xmlElement && !(xmlElement.Name != "navigationbar"))
		{
			try
			{
				((ISupportInitialize)this).BeginInit();
				((Control)this).set_Height(XmlConvert.ToInt32(xmlElement.GetAttribute("height")));
				foreach (XmlElement childNode in xmlElement.ChildNodes)
				{
					if (Items.Contains(childNode.GetAttribute("name")))
					{
						BaseItem baseItem = Items[childNode.GetAttribute("name")];
						if (baseItem is ButtonItem)
						{
							ButtonItem buttonItem = baseItem as ButtonItem;
							buttonItem.Checked = XmlConvert.ToBoolean(childNode.GetAttribute("checked"));
							buttonItem.Visible = XmlConvert.ToBoolean(childNode.GetAttribute("visible"));
							int num = XmlConvert.ToInt32(childNode.GetAttribute("index"));
							if (Items.IndexOf(baseItem) != num)
							{
								Items.RemoveAt(Items.IndexOf(baseItem));
								Items.Insert(num, baseItem);
							}
						}
					}
				}
				return;
			}
			finally
			{
				((ISupportInitialize)this).EndInit();
			}
		}
		throw new InvalidOperationException("xmlParent parameter in LoadLayout does not contain expected XML child note with name navigationbar. Invalid XML layout file.");
	}

	protected override bool ProcessMnemonic(char charCode)
	{
		string text = "&" + charCode;
		text = text.ToLower();
		foreach (BaseItem item in Items)
		{
			string text2 = item.Text.ToLower();
			if (text2.IndexOf(text) >= 0 && item is ButtonItem)
			{
				((ButtonItem)item).Checked = true;
				return true;
			}
		}
		return false;
	}

	protected virtual void PaintSplitter(ItemPaintArgs pa)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		if (!bool_16)
		{
			return;
		}
		Rectangle splitterRectangle = GetSplitterRectangle();
		LinearGradientBrush val = Class109.smethod_40(splitterRectangle, pa.Colors.PanelBackground, pa.Colors.PanelBackground2, 90f);
		try
		{
			pa.Graphics.FillRectangle((Brush)(object)val, splitterRectangle);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		SolidBrush val2 = new SolidBrush(Color.White);
		try
		{
			int num = splitterRectangle.X + (splitterRectangle.Width - 34) / 2;
			int num2 = splitterRectangle.Y + 2;
			for (int i = 0; i < 9; i++)
			{
				pa.Graphics.FillRectangle((Brush)(object)val2, num, num2, 2, 2);
				num += 4;
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		SolidBrush val3 = new SolidBrush(Color.FromArgb(128, ControlPaint.Dark(pa.Colors.PanelBackground)));
		try
		{
			int num3 = splitterRectangle.X + (splitterRectangle.Width - 34) / 2 - 1;
			int num4 = splitterRectangle.Y + 1;
			for (int j = 0; j < 9; j++)
			{
				pa.Graphics.FillRectangle((Brush)(object)val3, num3, num4, 2, 2);
				num3 += 4;
			}
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
		Class50.smethod_32(pa.Graphics, splitterRectangle.X, splitterRectangle.Bottom - 1, splitterRectangle.Right, splitterRectangle.Bottom - 1, pa.Colors.PanelBorder, 1);
	}

	protected virtual Rectangle GetSplitterRectangle()
	{
		Rectangle result = new Rectangle(((Control)this).get_ClientRectangle().X, ((Control)this).get_ClientRectangle().Y, ((Control)this).get_Width(), 6);
		if (base.BackgroundStyle.Border == eBorderType.SingleLine)
		{
			if ((base.BackgroundStyle.BorderSide & eBorderSide.Top) == eBorderSide.Top)
			{
				result.Y++;
			}
			if ((base.BackgroundStyle.BorderSide & eBorderSide.Right) == eBorderSide.Right)
			{
				result.Width--;
			}
			if ((base.BackgroundStyle.BorderSide & eBorderSide.Left) == eBorderSide.Left)
			{
				result.X++;
				result.Width--;
			}
		}
		else if (base.BackgroundStyle.Border != 0)
		{
			if ((base.BackgroundStyle.BorderSide & eBorderSide.Top) == eBorderSide.Top)
			{
				result.Y += 2;
			}
			if ((base.BackgroundStyle.BorderSide & eBorderSide.Right) == eBorderSide.Right)
			{
				result.Width -= 2;
			}
			if ((base.BackgroundStyle.BorderSide & eBorderSide.Left) == eBorderSide.Left)
			{
				result.X += 2;
				result.Width -= 2;
			}
		}
		return result;
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		method_13(e);
		if (!bool_17)
		{
			base.OnMouseMove(e);
		}
	}

	internal void method_13(MouseEventArgs mouseEventArgs_0)
	{
		if (bool_16 && !bool_17)
		{
			if (method_16(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
			{
				if (cursor_3 == (Cursor)null || GetDesignMode())
				{
					if (cursor_3 == (Cursor)null)
					{
						if (GetDesignMode())
						{
							cursor_3 = Cursor.get_Current();
						}
						else
						{
							cursor_3 = ((Control)this).get_Cursor();
						}
					}
					if (GetDesignMode())
					{
						Cursor.set_Current(Cursors.get_SizeNS());
					}
					else
					{
						((Control)this).set_Cursor(Cursors.get_SizeNS());
					}
				}
			}
			else if (cursor_3 != (Cursor)null)
			{
				if (GetDesignMode())
				{
					Cursor.set_Current(cursor_3);
				}
				else
				{
					((Control)this).set_Cursor(cursor_3);
				}
				cursor_3 = null;
			}
		}
		if (bool_17)
		{
			bool bool_ = false;
			BaseItem baseItem = navigationBarContainer_0.method_25();
			if (baseItem == null)
			{
				bool_ = false;
			}
			else if (mouseEventArgs_0.get_Y() >= baseItem.DisplayRectangle.Bottom - 6)
			{
				bool_ = true;
			}
			int num = navigationBarContainer_0.method_22(bool_);
			if (baseItem != null && mouseEventArgs_0.get_Y() >= baseItem.DisplayRectangle.Bottom - 6 && GetItemContainerRectangle().Height > num + 6)
			{
				navigationBarContainer_0.ShowFewerButtons();
			}
			else if (mouseEventArgs_0.get_Y() < 0 && Math.Abs(mouseEventArgs_0.get_Y()) >= num + 6)
			{
				navigationBarContainer_0.ShowMoreButtons();
			}
			else
			{
				RecalcLayout();
			}
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		method_14();
		base.OnMouseLeave(e);
	}

	internal void method_14()
	{
		if (cursor_3 != (Cursor)null)
		{
			if (GetDesignMode())
			{
				Cursor.set_Current(cursor_3);
			}
			else
			{
				((Control)this).set_Cursor(cursor_3);
			}
			cursor_3 = null;
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		method_15(e);
		if (!bool_17)
		{
			base.OnMouseDown(e);
		}
	}

	internal void method_15(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Control)this).get_Dock() == 2 && method_16(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
		{
			((Control)this).set_Capture(true);
			bool_17 = true;
		}
	}

	internal bool method_16(int int_2, int int_3)
	{
		if (bool_16 && GetSplitterRectangle().Contains(int_2, int_3))
		{
			return true;
		}
		return false;
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		method_17(e);
		base.OnMouseUp(e);
	}

	internal void method_17(MouseEventArgs mouseEventArgs_0)
	{
		if (bool_17)
		{
			bool_17 = false;
			((Control)this).set_Capture(false);
			if (cursor_3 != (Cursor)null)
			{
				((Control)this).set_Cursor(cursor_3);
				cursor_3 = null;
			}
		}
	}
}
