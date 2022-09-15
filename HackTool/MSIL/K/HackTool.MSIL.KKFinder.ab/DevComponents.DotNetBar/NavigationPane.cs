using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[Designer(typeof(NavigationPaneDesigner))]
[ToolboxItem(true)]
public class NavigationPane : UserControl
{
	private Class204 panelTitle;

	private NavigationBar navigationBar1;

	private Container container_0;

	private int int_0;

	private bool bool_0;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private Image image_0;

	private Image image_1;

	private Image image_2;

	private Image image_3;

	private Image image_4;

	private Image image_5;

	private Image image_6;

	private Image image_7;

	private int int_1;

	private int int_2;

	private PanelEx panelEx_0;

	private int int_3 = 100;

	private bool bool_3;

	private PanelEx panelEx_1;

	private bool bool_4;

	private EventHandler eventHandler_0;

	private PanelChangingEventHandler panelChangingEventHandler_0;

	private DotNetBarManager.LocalizeStringEventHandler localizeStringEventHandler_0;

	private PanelPopupEventHandler panelPopupEventHandler_0;

	private EventHandler eventHandler_1;

	private ExpandChangeEventHandler expandChangeEventHandler_0;

	private ExpandChangeEventHandler expandChangeEventHandler_1;

	private bool bool_5;

	[Browsable(false)]
	public int ExpandedSize => int_1;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public SubItemsCollection Items => navigationBar1.Items;

	[Category("Layout")]
	[DefaultValue(32)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public int NavigationBarHeight
	{
		get
		{
			if (!((Component)this).DesignMode && navigationBar1 != null && navigationBar1.Items.Count > 0)
			{
				return ((Control)navigationBar1).get_Height();
			}
			return int_0;
		}
		set
		{
			int_0 = value;
			((Control)navigationBar1).set_Height(int_0);
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	public NavigationBar NavigationBar => navigationBar1;

	[Browsable(true)]
	[Description("Indicates size of the image that will be use to resize images to when button button is on the bottom summary line of navigation bar and AutoSizeButtonImage=true.")]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	public Size ImageSizeSummaryLine
	{
		get
		{
			return navigationBar1.ImageSizeSummaryLine;
		}
		set
		{
			navigationBar1.ImageSizeSummaryLine = value;
		}
	}

	[Category("Behavior")]
	[Description("Indicates Configure Buttons button is visible.")]
	[DefaultValue(true)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public bool ConfigureItemVisible
	{
		get
		{
			return navigationBar1.ConfigureItemVisible;
		}
		set
		{
			navigationBar1.ConfigureItemVisible = value;
		}
	}

	[Category("Behavior")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether Show More Buttons and Show Fewer Buttons menu items are visible on Configure buttons menu.")]
	public bool ConfigureShowHideVisible
	{
		get
		{
			return navigationBar1.ConfigureShowHideVisible;
		}
		set
		{
			navigationBar1.ConfigureShowHideVisible = value;
		}
	}

	[Description("Gets or sets whether Navigation Pane Options menu item is visible on Configure buttons menu.")]
	[Category("Behavior")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(true)]
	public bool ConfigureNavOptionsVisible
	{
		get
		{
			return navigationBar1.ConfigureNavOptionsVisible;
		}
		set
		{
			navigationBar1.ConfigureNavOptionsVisible = value;
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether Navigation Pane Add/Remove Buttons menu item is visible on Configure buttons menu.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Behavior")]
	public bool ConfigureAddRemoveVisible
	{
		get
		{
			return navigationBar1.ConfigureAddRemoveVisible;
		}
		set
		{
			navigationBar1.ConfigureAddRemoveVisible = value;
		}
	}

	public ButtonItem CheckedButton => navigationBar1.CheckedButton;

	public NavigationPanePanel SelectedPanel => GetPanel(CheckedButton);

	[DefaultValue(null)]
	[Description("ImageList for images used on Items.")]
	[Browsable(true)]
	[Category("Data")]
	public ImageList Images
	{
		get
		{
			return navigationBar1.Images;
		}
		set
		{
			navigationBar1.Images = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("PanelEx control that is used to display title.")]
	[Category("Appearance")]
	public PanelEx TitlePanel => panelTitle;

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(4)]
	[Description("Indicates the padding in pixels at the top portion of the item.")]
	[Category("Layout")]
	public int ItemPaddingTop
	{
		get
		{
			return navigationBar1.ItemPaddingTop;
		}
		set
		{
			navigationBar1.ItemPaddingTop = value;
			if (((Component)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Indicates the padding in pixels at the bottom of the item.")]
	[DefaultValue(4)]
	[Browsable(true)]
	[Category("Layout")]
	public int ItemPaddingBottom
	{
		get
		{
			return navigationBar1.ItemPaddingBottom;
		}
		set
		{
			navigationBar1.ItemPaddingBottom = value;
			if (((Component)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[Description("Indicates whether images are automatically resized to size specified in ImageSizeSummaryLine when button is on the bottom summary line of navigation bar.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(true)]
	[Category("Appearance")]
	public bool AutoSizeButtonImage
	{
		get
		{
			return navigationBar1.AutoSizeButtonImage;
		}
		set
		{
			navigationBar1.AutoSizeButtonImage = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public string LayoutDefinition
	{
		get
		{
			return navigationBar1.LayoutDefinition;
		}
		set
		{
			navigationBar1.LayoutDefinition = value;
		}
	}

	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[DefaultValue(false)]
	[Category("Appearance")]
	[Browsable(true)]
	public bool AntiAlias
	{
		get
		{
			return navigationBar1.AntiAlias;
		}
		set
		{
			navigationBar1.AntiAlias = value;
			if (panelTitle != null)
			{
				panelTitle.AntiAlias = value;
			}
			if (panelEx_0 != null)
			{
				panelEx_0.AntiAlias = value;
			}
			if (panelEx_1 != null)
			{
				panelEx_1.AntiAlias = value;
			}
		}
	}

	[Description("Indicates animation time in milliseconds when control is expanded or collapsed.")]
	[Category("Expand")]
	[DefaultValue(100)]
	[Browsable(true)]
	public int AnimationTime
	{
		get
		{
			return int_3;
		}
		set
		{
			if (int_3 >= 0)
			{
				int_3 = value;
			}
		}
	}

	[Description("Indicates whether navigation pane can be collapsed.")]
	[DefaultValue(false)]
	[Browsable(true)]
	[Category("Title")]
	public bool CanCollapse
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			method_13();
			panelTitle.Boolean_3 = bool_0;
		}
	}

	[Category("Title")]
	[DefaultValue(eTitleButtonAlignment.Right)]
	[Description("Indicates the alignment of expand button inside title bar.")]
	[Browsable(true)]
	public eTitleButtonAlignment TitleButtonAlignment
	{
		get
		{
			return panelTitle.ETitleButtonAlignment_0;
		}
		set
		{
			panelTitle.ETitleButtonAlignment_0 = value;
			method_17();
		}
	}

	[Browsable(true)]
	[Description("Indicates whether navigation pane can be collapsed.")]
	[Category("Title")]
	[DefaultValue(true)]
	public bool Expanded
	{
		get
		{
			return bool_1;
		}
		set
		{
			if (bool_4)
			{
				bool_2 = value;
			}
			else if (bool_1 != value)
			{
				method_3(value, eEventSource.Code);
			}
		}
	}

	[Browsable(false)]
	public PanelEx CollapsedInnerPanel => panelEx_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool PopupSelectedPaneVisible
	{
		get
		{
			return bool_3;
		}
		set
		{
			if (bool_3 != value)
			{
				if (value)
				{
					method_9();
				}
				else
				{
					method_10();
				}
			}
		}
	}

	[Description("Specifies the visual style of the control.")]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(eDotNetBarStyle.Office2003)]
	public eDotNetBarStyle Style
	{
		get
		{
			return navigationBar1.Style;
		}
		set
		{
			navigationBar1.Style = value;
			ColorSchemeStyleChanged();
		}
	}

	[Description("Occurs when Item is clicked.")]
	[Category("Navigation Pane Events")]
	public event EventHandler ItemClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	[Category("Navigation Pane Events")]
	[Description("Occurs when Item is clicked.")]
	public event PanelChangingEventHandler PanelChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			panelChangingEventHandler_0 = (PanelChangingEventHandler)Delegate.Combine(panelChangingEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			panelChangingEventHandler_0 = (PanelChangingEventHandler)Delegate.Remove(panelChangingEventHandler_0, value);
		}
	}

	public event DotNetBarManager.LocalizeStringEventHandler LocalizeString
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			localizeStringEventHandler_0 = (DotNetBarManager.LocalizeStringEventHandler)Delegate.Combine(localizeStringEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			localizeStringEventHandler_0 = (DotNetBarManager.LocalizeStringEventHandler)Delegate.Remove(localizeStringEventHandler_0, value);
		}
	}

	public event PanelPopupEventHandler BeforePanelPopup
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			panelPopupEventHandler_0 = (PanelPopupEventHandler)Delegate.Combine(panelPopupEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			panelPopupEventHandler_0 = (PanelPopupEventHandler)Delegate.Remove(panelPopupEventHandler_0, value);
		}
	}

	public event EventHandler AfterPanelPopup
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_1 = (EventHandler)Delegate.Combine(eventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_1 = (EventHandler)Delegate.Remove(eventHandler_1, value);
		}
	}

	public event ExpandChangeEventHandler ExpandedChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			expandChangeEventHandler_0 = (ExpandChangeEventHandler)Delegate.Combine(expandChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			expandChangeEventHandler_0 = (ExpandChangeEventHandler)Delegate.Remove(expandChangeEventHandler_0, value);
		}
	}

	public event ExpandChangeEventHandler ExpandedChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			expandChangeEventHandler_1 = (ExpandChangeEventHandler)Delegate.Combine(expandChangeEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			expandChangeEventHandler_1 = (ExpandChangeEventHandler)Delegate.Remove(expandChangeEventHandler_1, value);
		}
	}

	public NavigationPane()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		navigationBar1.ItemAdded += navigationBar1_ItemAdded;
		navigationBar1.ItemRemoved += navigationBar1_ItemRemoved;
		navigationBar1.Event_2 += method_7;
		navigationBar1.LocalizeString += navigationBar1_LocalizeString;
		navigationBar1.SplitterVisible = true;
		int_0 = ((Control)navigationBar1).get_Height();
		panelTitle.Event_0 += method_6;
		panelTitle.ButtonItem_0.ImagePaddingHorizontal = 2;
		panelTitle.ButtonItem_0.ImagePaddingVertical = 2;
	}

	private void navigationBar1_LocalizeString(object sender, LocalizeEventArgs e)
	{
		if (localizeStringEventHandler_0 != null)
		{
			localizeStringEventHandler_0(this, e);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (image_0 != null)
			{
				image_0.Dispose();
			}
			if (image_1 != null)
			{
				image_1.Dispose();
			}
			if (container_0 != null)
			{
				container_0.Dispose();
			}
		}
		((ContainerControl)this).Dispose(disposing);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		SolidBrush val = new SolidBrush(NavigationBar.GetColorScheme().BarBackground);
		try
		{
			e.get_Graphics().FillRectangle((Brush)(object)val, ((Control)this).get_ClientRectangle());
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		Pen val2 = new Pen(NavigationBar.GetColorScheme().PanelBorder, 1f);
		try
		{
			e.get_Graphics().DrawRectangle(val2, new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	internal void method_0()
	{
		navigationBar1.method_0(((Component)this).DesignMode);
	}

	public virtual void RecalcLayout()
	{
		navigationBar1.RecalcLayout();
	}

	private void navigationBar1_ItemAdded(object sender, EventArgs e)
	{
		if (sender is ButtonItem buttonItem && !buttonItem.IsOnCustomizeMenu)
		{
			buttonItem.CheckedChanged += method_1;
			buttonItem.TextChanged += method_2;
			if (buttonItem.Checked)
			{
				buttonItem.method_41(bool_49: false);
				buttonItem.Checked = true;
			}
		}
	}

	private void navigationBar1_ItemRemoved(object sender, ItemRemovedEventArgs e)
	{
		if (sender is ButtonItem buttonItem)
		{
			try
			{
				buttonItem.CheckedChanged -= method_1;
			}
			catch
			{
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		if (!(sender is ButtonItem buttonItem) || buttonItem.IsOnCustomizeMenu)
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			if (!(val is NavigationPanePanel))
			{
				continue;
			}
			NavigationPanePanel navigationPanePanel = val as NavigationPanePanel;
			if (navigationPanePanel.ParentItem != buttonItem)
			{
				continue;
			}
			if (buttonItem.Checked)
			{
				if (bool_1)
				{
					if (!((Component)this).DesignMode)
					{
						((Control)navigationPanePanel).set_Visible(true);
					}
					((Control)navigationPanePanel).BringToFront();
				}
				((Control)panelTitle).set_Text(buttonItem.Text);
				if (panelEx_0 != null)
				{
					((Control)panelEx_0).set_Text(((Control)panelTitle).get_Text());
				}
			}
			else if (bool_1)
			{
				if (!((Component)this).DesignMode)
				{
					((Control)navigationPanePanel).set_Visible(false);
				}
				else
				{
					((Control)navigationPanePanel).SendToBack();
				}
			}
			break;
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		if (sender is ButtonItem buttonItem && buttonItem.Checked)
		{
			((Control)panelTitle).set_Text(buttonItem.Text);
			if (panelEx_0 != null)
			{
				((Control)panelEx_0).set_Text(buttonItem.Text);
			}
		}
	}

	protected override void OnControlAdded(ControlEventArgs e)
	{
		((Control)this).OnControlAdded(e);
		if (((Component)this).DesignMode || !(e.get_Control() is NavigationPanePanel navigationPanePanel))
		{
			return;
		}
		if (navigationPanePanel.ParentItem != null && bool_1)
		{
			if (Items.Contains(navigationPanePanel.ParentItem) && navigationPanePanel.ParentItem is ButtonItem)
			{
				((Control)navigationPanePanel).set_Visible(((ButtonItem)navigationPanePanel.ParentItem).Checked);
				if (((Control)navigationPanePanel).get_Visible())
				{
					((Control)navigationPanePanel).BringToFront();
				}
			}
			else
			{
				((Control)navigationPanePanel).set_Visible(false);
			}
		}
		else
		{
			((Control)navigationPanePanel).set_Visible(false);
		}
	}

	protected override void OnSystemColorsChanged(EventArgs e)
	{
		((Control)this).OnSystemColorsChanged(e);
		Application.DoEvents();
		if (bool_0)
		{
			method_18();
			method_17();
		}
	}

	public NavigationPanePanel GetPanel(ButtonItem item)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		if (item == null)
		{
			return null;
		}
		foreach (Control item2 in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item2;
			if (val is NavigationPanePanel navigationPanePanel && navigationPanePanel.ParentItem == item)
			{
				return navigationPanePanel;
			}
		}
		return null;
	}

	private void navigationBar1_Resize(object sender, EventArgs e)
	{
		if (((Component)this).DesignMode)
		{
			int_0 = ((Control)navigationBar1).get_Height();
		}
	}

	protected override void OnLayout(LayoutEventArgs e)
	{
		((ContainerControl)this).OnLayout(e);
		method_11();
	}

	public void SuspendLayout()
	{
		bool_4 = true;
		((Control)this).SuspendLayout();
	}

	public void ResumeLayout(bool performLayout)
	{
		bool_4 = false;
		((Control)navigationBar1).set_Height(int_0);
		((Control)navigationBar1).SendToBack();
		((Control)this).ResumeLayout(true);
		Expanded = bool_2;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeImageSizeSummaryLine()
	{
		return navigationBar1.ShouldSerializeImageSizeSummaryLine();
	}

	public void ShowMoreButtons()
	{
		navigationBar1.ShowMoreButtons();
	}

	public void ShowFewerButtons()
	{
		navigationBar1.ShowFewerButtons();
	}

	public void SaveLayout(string fileName)
	{
		navigationBar1.SaveLayout(fileName);
	}

	public void SaveLayout(XmlElement xmlParent)
	{
		navigationBar1.SaveLayout(xmlParent);
	}

	private void method_3(bool bool_6, eEventSource eEventSource_0)
	{
		if (expandChangeEventHandler_0 != null)
		{
			ExpandedChangeEventArgs expandedChangeEventArgs = new ExpandedChangeEventArgs(eEventSource_0, bool_6);
			expandChangeEventHandler_0(this, expandedChangeEventArgs);
			if (expandedChangeEventArgs.Cancel)
			{
				return;
			}
		}
		bool_1 = bool_6;
		method_4();
		if (expandChangeEventHandler_1 != null)
		{
			ExpandedChangeEventArgs e = new ExpandedChangeEventArgs(eEventSource_0, bool_6);
			expandChangeEventHandler_1(this, e);
		}
	}

	private void method_4()
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Invalid comparison between Unknown and I4
		if (bool_1)
		{
			foreach (BaseItem item in navigationBar1.Items)
			{
				item.bool_14 = true;
			}
			panelTitle.Boolean_2 = true;
			PopupSelectedPaneVisible = false;
			method_12();
			if (AnimationTime != 0 && !((Component)this).DesignMode)
			{
				Rectangle rectangle_ = new Rectangle(((Control)this).get_Location(), new Size(int_1, ((Control)this).get_Height()));
				if ((int)((Control)this).get_Dock() == 4)
				{
					rectangle_.Offset(-int_1, 0);
				}
				Class109.smethod_66((Control)(object)this, bool_3: true, int_3, ((Control)this).get_Bounds(), rectangle_);
			}
			else
			{
				TypeDescriptor.GetProperties(this)["Width"]!.SetValue(this, int_1);
			}
		}
		else
		{
			panelTitle.Boolean_2 = false;
			int_1 = ((Control)this).get_Width();
			if (AnimationTime != 0 && !((Component)this).DesignMode)
			{
				Rectangle rectangle_2 = new Rectangle(((Control)this).get_Location(), new Size(method_5(), ((Control)this).get_Height()));
				if ((int)((Control)this).get_Dock() == 4)
				{
					rectangle_2.Offset(((Control)this).get_Width() - rectangle_2.Width, 0);
				}
				Class109.smethod_66((Control)(object)this, bool_3: true, int_3, ((Control)this).get_Bounds(), rectangle_2);
			}
			else
			{
				TypeDescriptor.GetProperties(this)["Width"]!.SetValue(this, method_5());
			}
			method_8();
			foreach (BaseItem item2 in navigationBar1.Items)
			{
				item2.bool_14 = false;
			}
			((Control)navigationBar1).Invalidate();
		}
		method_17();
	}

	private int method_5()
	{
		int num = Math.Max(((Control)panelTitle).get_Font().get_Height() + 10, 34);
		if (int_2 > 0)
		{
			return int_2;
		}
		if (!(navigationBar1.ItemsContainer.method_25() is ButtonItem buttonItem))
		{
			return num;
		}
		if (buttonItem.ImageSize.IsEmpty)
		{
			return num;
		}
		Class271 @class = buttonItem.method_23(Enum15.const_0);
		if (@class != null)
		{
			return Math.Max(num, @class.Int32_3 + 10);
		}
		return num;
	}

	private void method_6(object sender, EventArgs e)
	{
		method_3(!Expanded, eEventSource.Mouse);
	}

	private void method_7(object sender, EventArgs1 e)
	{
		if (!PopupSelectedPaneVisible)
		{
			return;
		}
		string text = Class92.smethod_8(e.intptr_0);
		text = text.ToLower();
		if (text.IndexOf("combolbox") >= 0)
		{
			return;
		}
		for (Control val = Control.FromChildHandle(e.intptr_0); val != null; val = val.get_Parent())
		{
			if (val == panelEx_1)
			{
				return;
			}
		}
		PopupSelectedPaneVisible = false;
	}

	private void method_8()
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		panelEx_0 = new PanelEx();
		panelEx_0.ColorSchemeStyle = navigationBar1.Style;
		panelEx_0.ColorScheme = navigationBar1.GetColorScheme();
		panelEx_0.ApplyButtonStyle();
		panelEx_0.Style.VerticalText = true;
		panelEx_0.Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
		panelEx_0.Style.BackColor1.ColorSchemePart = eColorSchemePart.PanelBackground;
		panelEx_0.Style.ResetBackColor2();
		panelEx_0.StyleMouseOver.VerticalText = true;
		panelEx_0.StyleMouseDown.VerticalText = true;
		((Control)panelEx_0).set_Font(((Control)panelTitle).get_Font());
		panelEx_0.AntiAlias = AntiAlias;
		method_11();
		if (CheckedButton != null)
		{
			((Control)panelEx_0).set_Text(CheckedButton.Text);
		}
		else
		{
			((Control)panelEx_0).set_Text("Navigation Pane");
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			if (val is NavigationPanePanel)
			{
				val.set_Visible(false);
			}
		}
		((Control)this).get_Controls().Add((Control)(object)panelEx_0);
		((Control)panelEx_0).add_Click((EventHandler)panelEx_0_Click);
	}

	private void panelEx_0_Click(object sender, EventArgs e)
	{
		PopupSelectedPaneVisible = !PopupSelectedPaneVisible;
	}

	private void method_9()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Invalid comparison between Unknown and I4
		if (bool_3)
		{
			return;
		}
		Control val = null;
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val2 = item;
			if (val2 is NavigationPanePanel && ((NavigationPanePanel)(object)val2).ParentItem == CheckedButton)
			{
				val = val2;
				break;
			}
		}
		if (val == null)
		{
			return;
		}
		int height = ((Control)navigationBar1).get_Top() - ((Control)panelTitle).get_Bottom();
		Rectangle rectangle = new Rectangle(((Control)this).get_Width(), ((Control)panelTitle).get_Bottom(), int_1, height);
		Rectangle rectangle_ = new Rectangle(((Control)this).get_Width(), ((Control)panelTitle).get_Bottom(), 16, height);
		if (panelPopupEventHandler_0 != null)
		{
			PanelPopupEventArgs panelPopupEventArgs = new PanelPopupEventArgs(rectangle);
			panelPopupEventHandler_0(this, panelPopupEventArgs);
			if (panelPopupEventArgs.Cancel)
			{
				return;
			}
			rectangle = panelPopupEventArgs.PopupBounds;
		}
		Control val3 = (Control)(object)((Control)this).FindForm();
		if (val3 == null)
		{
			val3 = ((Control)this).get_TopLevelControl();
		}
		if (val3 == null)
		{
			val3 = ((Control)this).get_Parent();
		}
		panelEx_1 = new PanelEx();
		((Control)panelEx_1).set_Visible(false);
		panelEx_1.ApplyLabelStyle();
		panelEx_1.AntiAlias = AntiAlias;
		val3.get_Controls().Add((Control)(object)panelEx_1);
		((Control)panelEx_1).BringToFront();
		((Control)this).get_Controls().Remove(val);
		if (val is NavigationPanePanel)
		{
			NavigationPanePanel navigationPanePanel = (NavigationPanePanel)(object)val;
			((ScrollableControl)navigationPanePanel).get_DockPadding().set_Bottom(1);
			if (navigationPanePanel.Style.Border == eBorderType.None)
			{
				panelEx_1.Style.BorderSide = eBorderSide.All;
				panelEx_1.Style.Border = eBorderType.SingleLine;
				panelEx_1.Style.BorderWidth = 1;
				panelEx_1.Style.BorderColor.Color = panelTitle.Style.BorderColor.Color;
				((ScrollableControl)panelEx_1).get_DockPadding().set_All(1);
			}
		}
		((Control)panelEx_1).get_Controls().Add(val);
		val.set_Visible(true);
		if ((int)((Control)this).get_Dock() == 4)
		{
			rectangle.Offset(-(((Control)this).get_Width() + rectangle.Width), 0);
			rectangle_.Offset(-(((Control)this).get_Width() + rectangle_.Width), 0);
		}
		Point point = ((Control)this).PointToScreen(rectangle.Location);
		rectangle.Location = val3.PointToClient(point);
		point = ((Control)this).PointToScreen(rectangle_.Location);
		rectangle_.Location = val3.PointToClient(point);
		if (AnimationTime == 0)
		{
			((Control)panelEx_1).set_Bounds(rectangle);
			((Control)panelEx_1).set_Visible(true);
		}
		else
		{
			Class109.smethod_66((Control)(object)panelEx_1, bool_3: true, AnimationTime, rectangle_, rectangle);
		}
		((Control)panelEx_1).Focus();
		((Control)panelEx_1).add_Leave((EventHandler)panelEx_1_Leave);
		bool_3 = true;
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, new EventArgs());
		}
	}

	private void panelEx_1_Leave(object sender, EventArgs e)
	{
		if (PopupSelectedPaneVisible)
		{
			PopupSelectedPaneVisible = false;
		}
	}

	private void method_10()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		if (!bool_3 || bool_5)
		{
			return;
		}
		bool_5 = true;
		try
		{
			if (AnimationTime == 0)
			{
				((Control)panelEx_1).Hide();
			}
			else
			{
				Rectangle rectangle_ = new Rectangle(((Control)this).get_Width(), ((Control)this).get_Top(), 16, ((Control)this).get_Height());
				if ((int)((Control)this).get_Dock() == 4)
				{
					rectangle_.Offset(-(((Control)this).get_Width() + rectangle_.Width), 0);
				}
				Point point = ((Control)this).PointToScreen(rectangle_.Location);
				rectangle_.Location = ((Control)panelEx_1).get_Parent().PointToClient(point);
				Class109.smethod_66((Control)(object)panelEx_1, bool_3: false, AnimationTime, ((Control)panelEx_1).get_Bounds(), rectangle_);
			}
			Control val = null;
			foreach (Control item in (ArrangedElementCollection)((Control)panelEx_1).get_Controls())
			{
				Control val2 = item;
				if (val2 is NavigationPanePanel)
				{
					val2.set_Visible(false);
					((Control)panelEx_1).get_Controls().Remove(val2);
					val = val2;
					break;
				}
			}
			if (val is NavigationPanePanel)
			{
				((ScrollableControl)(NavigationPanePanel)(object)val).get_DockPadding().set_Bottom(0);
			}
			((Control)this).get_Controls().Add(val);
			((Control)panelEx_1).remove_Leave((EventHandler)panelEx_1_Leave);
			((Component)(object)panelEx_1).Dispose();
			panelEx_1 = null;
			bool_3 = false;
		}
		finally
		{
			bool_5 = false;
		}
	}

	private void method_11()
	{
		if (panelEx_0 != null)
		{
			((Control)panelEx_0).set_Bounds(new Rectangle(new Point(((Control)this).get_ClientRectangle().X + 3, ((Control)panelTitle).get_Bottom() + 3), new Size(((Control)this).get_ClientRectangle().Width - 6, ((Control)navigationBar1).get_Top() - ((Control)panelTitle).get_Bottom() - 6)));
		}
	}

	private void method_12()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		if (panelEx_0 != null)
		{
			((Control)this).get_Controls().Remove((Control)(object)panelEx_0);
			((Component)(object)panelEx_0).Dispose();
			panelEx_0 = null;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			if (val is NavigationPanePanel && ((NavigationPanePanel)(object)val).ParentItem == CheckedButton)
			{
				val.set_Visible(true);
				if (((Component)this).DesignMode)
				{
					TypeDescriptor.GetProperties(val)["Visible"]!.SetValue(val, true);
				}
				val.BringToFront();
				break;
			}
		}
	}

	private void method_13()
	{
		if (bool_0)
		{
			method_18();
		}
		method_17();
	}

	private Image method_14(bool bool_6)
	{
		if (bool_6)
		{
			if (image_6 != null)
			{
				return image_6;
			}
			return image_2;
		}
		if (image_4 != null)
		{
			return image_4;
		}
		return image_0;
	}

	private Image method_15(bool bool_6)
	{
		if (bool_6)
		{
			if (image_7 != null)
			{
				return image_7;
			}
			return image_3;
		}
		if (image_5 != null)
		{
			return image_5;
		}
		return image_1;
	}

	internal void method_16()
	{
		ColorSchemeStyleChanged();
	}

	private void method_17()
	{
		Class264 @class = new Class264(navigationBar1);
		if (bool_1)
		{
			if (panelTitle.ETitleButtonAlignment_0 != eTitleButtonAlignment.Right && image_4 == null)
			{
				panelTitle.ButtonItem_0.Image = method_15(bool_6: false);
				panelTitle.ButtonItem_0.HoverImage = method_15(bool_6: true);
			}
			else
			{
				panelTitle.ButtonItem_0.Image = method_14(bool_6: false);
				panelTitle.ButtonItem_0.HoverImage = method_14(bool_6: true);
			}
			panelTitle.ButtonItem_0.Tooltip = @class.method_0(LocalizationKeys.NavPaneCollapseButtonTooltip);
		}
		else
		{
			if (panelTitle.ETitleButtonAlignment_0 != eTitleButtonAlignment.Right && image_5 == null)
			{
				panelTitle.ButtonItem_0.Image = method_14(bool_6: false);
				panelTitle.ButtonItem_0.HoverImage = method_14(bool_6: true);
			}
			else
			{
				panelTitle.ButtonItem_0.Image = method_15(bool_6: false);
				panelTitle.ButtonItem_0.HoverImage = method_15(bool_6: true);
			}
			panelTitle.ButtonItem_0.Tooltip = @class.method_0(LocalizationKeys.NavPaneExpandButtonTooltip);
		}
		panelTitle.method_9();
	}

	private void method_18()
	{
		if (image_0 != null)
		{
			image_0.Dispose();
		}
		if (image_1 != null)
		{
			image_1.Dispose();
		}
		if (image_2 != null)
		{
			image_2.Dispose();
		}
		if (image_3 != null)
		{
			image_3.Dispose();
		}
		image_0 = Class34.smethod_1(bool_0: true, panelTitle.ColorScheme.PanelText, bool_1: false);
		image_2 = Class34.smethod_1(bool_0: true, panelTitle.ColorScheme.ItemHotText, bool_1: false);
		image_1 = Class34.smethod_1(bool_0: false, panelTitle.ColorScheme.PanelText, bool_1: false);
		image_3 = Class34.smethod_1(bool_0: false, panelTitle.ColorScheme.ItemHotText, bool_1: false);
	}

	public void LoadLayout(string fileName)
	{
		navigationBar1.LoadLayout(fileName);
	}

	public void LoadLayout(XmlElement xmlParent)
	{
		navigationBar1.LoadLayout(xmlParent);
	}

	public void ColorSchemeStyleChanged()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		ColorScheme colorScheme = null;
		eDotNetBarStyle style = navigationBar1.Style;
		if (style == eDotNetBarStyle.Office2007 || (navigationBar1.ColorScheme != null && navigationBar1.ColorScheme.PredefinedColorScheme == ePredefinedColorScheme.SystemColors))
		{
			colorScheme = navigationBar1.GetColorScheme();
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			if (val is PanelEx)
			{
				PanelEx component = val as PanelEx;
				TypeDescriptor.GetProperties(component)["ColorSchemeStyle"]!.SetValue(component, style);
				if (colorScheme != null)
				{
					((PanelEx)(object)val).ColorScheme = colorScheme;
				}
			}
		}
		if (style == eDotNetBarStyle.Office2007)
		{
			panelTitle.Style.Border = eBorderType.RaisedInner;
		}
		else
		{
			panelTitle.Style.Border = eBorderType.SingleLine;
		}
		method_18();
		method_17();
	}

	private void navigationBar1_ItemClick(object sender, EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(sender, e);
		}
	}

	private void navigationBar1_OptionGroupChanging(object sender, OptionGroupChangingEventArgs e)
	{
		NavigationPanePanel oldpanel = null;
		NavigationPanePanel navigationPanePanel = null;
		if (e.OldChecked != null)
		{
			oldpanel = GetPanel(e.OldChecked);
		}
		if (e.NewChecked != null)
		{
			navigationPanePanel = GetPanel(e.NewChecked);
		}
		if (navigationPanePanel != null)
		{
			PanelChangingEventArgs panelChangingEventArgs = new PanelChangingEventArgs(oldpanel, navigationPanePanel);
			InvokePanelChanging(panelChangingEventArgs);
			e.Cancel = panelChangingEventArgs.Cancel;
		}
	}

	protected virtual void InvokePanelChanging(PanelChangingEventArgs e)
	{
		if (panelChangingEventHandler_0 != null)
		{
			panelChangingEventHandler_0(this, e);
		}
	}

	private void InitializeComponent()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		panelTitle = new Class204();
		navigationBar1 = new NavigationBar();
		((ISupportInitialize)navigationBar1).BeginInit();
		((Control)panelTitle).set_Dock((DockStyle)1);
		((Control)panelTitle).set_Font(new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)panelTitle).set_Name("panelTitle");
		((Control)panelTitle).set_Size(new Size(150, 24));
		panelTitle.Style.Alignment = (StringAlignment)0;
		panelTitle.Style.BackColor1.ColorSchemePart = eColorSchemePart.PanelBackground;
		panelTitle.Style.BackColor2.ColorSchemePart = eColorSchemePart.PanelBackground2;
		panelTitle.Style.Border = eBorderType.SingleLine;
		panelTitle.Style.BorderSide = eBorderSide.Bottom;
		panelTitle.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
		panelTitle.Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
		panelTitle.Style.GradientAngle = 90;
		panelTitle.Style.MarginLeft = 4;
		panelTitle.StyleMouseDown.Alignment = (StringAlignment)0;
		panelTitle.StyleMouseOver.Alignment = (StringAlignment)0;
		((Control)panelTitle).set_TabIndex(0);
		panelTitle.Boolean_3 = false;
		((Control)panelTitle).set_Text("Title");
		navigationBar1.BackgroundStyle.BackColor1.Color = SystemColors.Control;
		navigationBar1.BackgroundStyle.Border = eBorderType.SingleLine;
		navigationBar1.BackgroundStyle.BorderSide = eBorderSide.Top;
		navigationBar1.BackgroundStyle.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
		((Control)navigationBar1).set_Dock((DockStyle)2);
		((Control)navigationBar1).set_Location(new Point(0, 128));
		((Control)navigationBar1).set_Name("navigationBar1");
		((Control)navigationBar1).set_Size(new Size(150, 32));
		((Control)navigationBar1).set_TabIndex(1);
		((Control)navigationBar1).set_Text("navBar");
		((Control)navigationBar1).add_Resize((EventHandler)navigationBar1_Resize);
		navigationBar1.ItemClick += navigationBar1_ItemClick;
		navigationBar1.OptionGroupChanging += navigationBar1_OptionGroupChanging;
		((Control)navigationBar1).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[2]
		{
			navigationBar1,
			(Control)panelTitle
		});
		((Control)this).set_Name("NavigationPane");
		((Control)this).set_Size(new Size(150, 192));
		((ScrollableControl)this).get_DockPadding().set_All(1);
		((ISupportInitialize)navigationBar1).EndInit();
	}
}
