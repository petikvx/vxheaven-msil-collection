using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar.Rendering;
using Microsoft.Win32;

namespace DevComponents.DotNetBar.Design;

public class RibbonControlDesigner : BarBaseControlDesigner
{
	private bool bool_12;

	public override DesignerVerbCollection Verbs
	{
		get
		{
			((ControlDesigner)this).get_Control();
			DesignerVerb[] array = null;
			array = new DesignerVerb[6]
			{
				new DesignerVerb("Create Ribbon Tab", CreateRibbonTab),
				new DesignerVerb("Create Button", CreateButton),
				new DesignerVerb("Create Text Box", CreateTextBox),
				new DesignerVerb("Create Combo Box", CreateComboBox),
				new DesignerVerb("Create Label", CreateLabel),
				new DesignerVerb("Create Rating Item", CreateRatingItem)
			};
			return new DesignerVerbCollection(array);
		}
	}

	public override ICollection AssociatedComponents
	{
		get
		{
			ArrayList arrayList = new ArrayList(base.BaseAssociatedComponents);
			if (((ControlDesigner)this).get_Control() is RibbonControl ribbonControl)
			{
				foreach (BaseItem quickToolbarItem in ribbonControl.QuickToolbarItems)
				{
					if (!quickToolbarItem.SystemItem)
					{
						arrayList.Add(quickToolbarItem);
					}
				}
				foreach (BaseItem item in ribbonControl.Items)
				{
					if (!item.SystemItem)
					{
						arrayList.Add(item);
					}
				}
				{
					foreach (RibbonTabItemGroup tabGroup in ribbonControl.TabGroups)
					{
						arrayList.Add(tabGroup);
					}
					return arrayList;
				}
			}
			return arrayList;
		}
	}

	[DefaultValue(eDotNetBarStyle.Office2003)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Specifies the visual style of the control.")]
	[Category("Appearance")]
	public eDotNetBarStyle Style
	{
		get
		{
			RibbonControl ribbonControl = ((ControlDesigner)this).get_Control() as RibbonControl;
			return ribbonControl.Style;
		}
		set
		{
			RibbonControl ribbonControl = ((ControlDesigner)this).get_Control() as RibbonControl;
			ribbonControl.Style = value;
			if (((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost && !designerHost.Loading)
			{
				RibbonPredefinedColorSchemes.SetRibbonControlStyle(ribbonControl, value);
			}
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates whether custom caption and quick access toolbar provided by the control is visible.")]
	[DefaultValue(false)]
	public bool CaptionVisible
	{
		get
		{
			RibbonControl ribbonControl = ((ControlDesigner)this).get_Control() as RibbonControl;
			return ribbonControl.CaptionVisible;
		}
		set
		{
			RibbonControl ribbonControl = ((ControlDesigner)this).get_Control() as RibbonControl;
			if (ribbonControl.CaptionVisible == value)
			{
				return;
			}
			ribbonControl.CaptionVisible = value;
			if (!ribbonControl.CaptionVisible || (ribbonControl.QuickToolbarItems.Count != 0 && (ribbonControl.QuickToolbarItems.Count != 1 || !(ribbonControl.QuickToolbarItems[0] is SystemCaptionItem)) && (ribbonControl.QuickToolbarItems.Count != 2 || !(ribbonControl.QuickToolbarItems[0] is QatCustomizeItem))))
			{
				return;
			}
			string string_ = "StartButtonImage.png";
			string string_2 = "NewDocument.png";
			string string_3 = "OpenDocument.png";
			string string_4 = "Save.png";
			string string_5 = "Share.png";
			string string_6 = "Print.png";
			string string_7 = "Close.png";
			string string_8 = "Exit.png";
			string string_9 = "Options.png";
			IDesignerHost designerHost = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			if (designerHost == null || designerHost.Loading || componentChangeService == null || !(designerHost.TransactionDescription != "Paste components"))
			{
				return;
			}
			DesignerTransaction designerTransaction = designerHost.CreateTransaction();
			try
			{
				if (GlobalManager.Renderer is Office2007Renderer)
				{
					_ = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.Menu;
				}
				m_CreatingItem = true;
				Office2007StartButton office2007StartButton = designerHost.CreateComponent(typeof(Office2007StartButton)) as Office2007StartButton;
				office2007StartButton.HotTrackingStyle = eHotTrackingStyle.Image;
				office2007StartButton.Image = (Image)(object)smethod_0(string_);
				office2007StartButton.ImagePaddingHorizontal = 2;
				office2007StartButton.ImagePaddingVertical = 2;
				office2007StartButton.ShowSubItems = false;
				office2007StartButton.CanCustomize = false;
				office2007StartButton.AutoExpandOnClick = true;
				office2007StartButton.Text = "&File";
				componentChangeService.OnComponentChanging(ribbonControl, TypeDescriptor.GetProperties(ribbonControl)["QuickToolbarItems"]);
				ribbonControl.QuickToolbarItems.Add(office2007StartButton, 0);
				componentChangeService.OnComponentChanged(ribbonControl, TypeDescriptor.GetProperties(ribbonControl)["QuickToolbarItems"], null, null);
				ButtonItem buttonItem = office2007StartButton;
				ButtonItem buttonItem2 = designerHost.CreateComponent(typeof(ButtonItem)) as ButtonItem;
				buttonItem2.Text = buttonItem2.Name;
				componentChangeService.OnComponentChanging(ribbonControl, TypeDescriptor.GetProperties(ribbonControl)["QuickToolbarItems"]);
				ribbonControl.QuickToolbarItems.Add(buttonItem2, 1);
				componentChangeService.OnComponentChanged(ribbonControl, TypeDescriptor.GetProperties(ribbonControl)["QuickToolbarItems"], null, null);
				ItemContainer itemContainer = designerHost.CreateComponent(typeof(ItemContainer)) as ItemContainer;
				itemContainer.BackgroundStyle.Class = ElementStyleClassKeys.RibbonFileMenuContainerKey;
				itemContainer.LayoutOrientation = eOrientation.Vertical;
				buttonItem.SubItems.Add(itemContainer);
				ItemContainer itemContainer2 = designerHost.CreateComponent(typeof(ItemContainer)) as ItemContainer;
				itemContainer2.BackgroundStyle.Class = ElementStyleClassKeys.RibbonFileMenuTwoColumnContainerKey;
				itemContainer2.ItemSpacing = 0;
				itemContainer.SubItems.Add(itemContainer2);
				ItemContainer itemContainer3 = designerHost.CreateComponent(typeof(ItemContainer)) as ItemContainer;
				itemContainer3.BackgroundStyle.Class = ElementStyleClassKeys.RibbonFileMenuColumnOneContainerKey;
				itemContainer3.LayoutOrientation = eOrientation.Vertical;
				itemContainer3.MinimumSize = new Size(120, 0);
				ButtonItem item = method_16(designerHost, "&New", (Image)(object)smethod_0(string_2));
				itemContainer3.SubItems.Add(item);
				item = method_16(designerHost, "&Open...", (Image)(object)smethod_0(string_3));
				itemContainer3.SubItems.Add(item);
				item = method_16(designerHost, "&Save...", (Image)(object)smethod_0(string_4));
				itemContainer3.SubItems.Add(item);
				item = method_16(designerHost, "S&hare...", (Image)(object)smethod_0(string_5));
				item.BeginGroup = true;
				itemContainer3.SubItems.Add(item);
				item = method_16(designerHost, "&Print...", (Image)(object)smethod_0(string_6));
				itemContainer3.SubItems.Add(item);
				item = method_16(designerHost, "&Close", (Image)(object)smethod_0(string_7));
				item.BeginGroup = true;
				itemContainer3.SubItems.Add(item);
				itemContainer2.SubItems.Add(itemContainer3);
				GalleryContainer galleryContainer = designerHost.CreateComponent(typeof(GalleryContainer)) as GalleryContainer;
				galleryContainer.BackgroundStyle.Class = ElementStyleClassKeys.RibbonFileMenuColumnTwoContainerKey;
				galleryContainer.LayoutOrientation = eOrientation.Vertical;
				galleryContainer.MinimumSize = new Size(180, 240);
				galleryContainer.MultiLine = false;
				galleryContainer.EnableGalleryPopup = false;
				galleryContainer.PopupUsesStandardScrollbars = false;
				LabelItem labelItem = designerHost.CreateComponent(typeof(LabelItem)) as LabelItem;
				labelItem.CanCustomize = false;
				labelItem.BackColor = Color.Empty;
				labelItem.BorderSide = eBorderSide.Bottom;
				labelItem.BorderType = eBorderType.Etched;
				labelItem.Font = null;
				labelItem.ForeColor = SystemColors.ControlText;
				labelItem.Name = "labelItem8";
				labelItem.PaddingBottom = 2;
				labelItem.PaddingTop = 2;
				labelItem.Stretch = true;
				labelItem.Text = "Recent Documents";
				galleryContainer.SubItems.Add(labelItem);
				galleryContainer.SubItems.Add(method_17(designerHost, "&1. Short News 5-7.rtf"));
				galleryContainer.SubItems.Add(method_17(designerHost, "&2. Prospect Email.rtf"));
				galleryContainer.SubItems.Add(method_17(designerHost, "&3. Customer Email.rtf"));
				galleryContainer.SubItems.Add(method_17(designerHost, "&4. example.rtf"));
				itemContainer2.SubItems.Add(galleryContainer);
				ItemContainer itemContainer4 = designerHost.CreateComponent(typeof(ItemContainer)) as ItemContainer;
				itemContainer4.BackgroundStyle.Class = ElementStyleClassKeys.RibbonFileMenuBottomContainerKey;
				itemContainer4.HorizontalItemAlignment = eHorizontalItemsAlignment.Right;
				item = method_16(designerHost, "Opt&ions", (Image)(object)smethod_0(string_9));
				item.ColorTable = eButtonColor.OrangeWithBackground;
				itemContainer4.SubItems.Add(item);
				item = method_16(designerHost, "E&xit", (Image)(object)smethod_0(string_8));
				item.ColorTable = eButtonColor.OrangeWithBackground;
				itemContainer4.SubItems.Add(item);
				itemContainer.SubItems.Add(itemContainer4);
			}
			catch
			{
				designerTransaction.Cancel();
			}
			finally
			{
				if (!designerTransaction.Canceled)
				{
					designerTransaction.Commit();
				}
				m_CreatingItem = false;
			}
		}
	}

	[DefaultValue(true)]
	[Description("Gets or sets whether control is expanded or not. When control is expanded both the tabs and the tab ribbons are visible.")]
	[Browsable(true)]
	[Category("Layout")]
	[DevCoBrowsable(true)]
	public bool Expanded
	{
		get
		{
			return (bool)((ComponentDesigner)this).get_ShadowProperties().get_Item("Expanded");
		}
		set
		{
			((ComponentDesigner)this).get_ShadowProperties().set_Item("Expanded", (object)value);
		}
	}

	[Category("Quick Access Toolbar")]
	[DefaultValue(true)]
	[Description("Indicates whether control can be customized. Caption must be visible for customization to be fully enabled.")]
	[Browsable(true)]
	public bool CanCustomize
	{
		get
		{
			RibbonControl ribbonControl = ((ControlDesigner)this).get_Control() as RibbonControl;
			return ribbonControl.CanCustomize;
		}
		set
		{
			RibbonControl ribbonControl = ((ControlDesigner)this).get_Control() as RibbonControl;
			ribbonControl.CanCustomize = value;
			if (!(((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost) || designerHost.Loading)
			{
				return;
			}
			if (value)
			{
				QatCustomizeItem qatCustomizeItem = method_18(ribbonControl);
				if (qatCustomizeItem != null)
				{
					return;
				}
				DesignerTransaction designerTransaction = designerHost.CreateTransaction("Creating the QAT");
				try
				{
					m_CreatingItem = true;
					qatCustomizeItem = designerHost.CreateComponent(typeof(QatCustomizeItem)) as QatCustomizeItem;
					IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
					componentChangeService?.OnComponentChanging(ribbonControl, TypeDescriptor.GetProperties(ribbonControl)["QuickToolbarItems"]);
					ribbonControl.QuickToolbarItems.Add(qatCustomizeItem);
					componentChangeService?.OnComponentChanged(ribbonControl, TypeDescriptor.GetProperties(ribbonControl)["QuickToolbarItems"], null, null);
					m_CreatingItem = false;
					RecalcLayout();
					return;
				}
				catch
				{
					designerTransaction.Cancel();
					return;
				}
				finally
				{
					if (!designerTransaction.Canceled)
					{
						designerTransaction.Commit();
					}
				}
			}
			QatCustomizeItem qatCustomizeItem2 = method_18(ribbonControl);
			if (qatCustomizeItem2 == null)
			{
				return;
			}
			DesignerTransaction designerTransaction2 = designerHost.CreateTransaction("Removing the QAT");
			try
			{
				IComponentChangeService componentChangeService2 = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				componentChangeService2?.OnComponentChanging(ribbonControl, TypeDescriptor.GetProperties(ribbonControl)["QuickToolbarItems"]);
				ribbonControl.QuickToolbarItems.Remove(qatCustomizeItem2);
				componentChangeService2?.OnComponentChanged(ribbonControl, TypeDescriptor.GetProperties(ribbonControl)["QuickToolbarItems"], null, null);
				designerHost.DestroyComponent(qatCustomizeItem2);
			}
			catch
			{
				designerTransaction2.Cancel();
			}
			finally
			{
				if (!designerTransaction2.Canceled)
				{
					designerTransaction2.Commit();
				}
			}
		}
	}

	public RibbonControlDesigner()
	{
		EnableItemDragDrop = true;
		AcceptExternalControls = false;
	}

	public override void Initialize(IComponent component)
	{
		base.Initialize(component);
		if (component.Site!.DesignMode)
		{
			if (component is RibbonControl ribbonControl)
			{
				ribbonControl.method_8();
				Expanded = ribbonControl.Expanded;
			}
			((ControlDesigner)this).EnableDragDrop(false);
		}
	}

	public override bool CanParent(Control control)
	{
		if (control is RibbonPanel && !((ControlDesigner)this).get_Control().get_Controls().Contains(control))
		{
			return true;
		}
		return false;
	}

	private BaseItem method_12()
	{
		RibbonControl ribbonControl = ((ControlDesigner)this).get_Control() as RibbonControl;
		if (bool_12)
		{
			return ribbonControl.RibbonStrip.CaptionContainerItem;
		}
		return ribbonControl.RibbonStrip.StripContainerItem;
	}

	protected override void CreateButton(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is RibbonControl)
		{
			CreateButton(method_12());
		}
	}

	protected override void CreateTextBox(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is RibbonControl)
		{
			CreateTextBox(method_12());
		}
	}

	protected override void CreateComboBox(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is RibbonControl)
		{
			CreateComboBox(method_12());
		}
	}

	protected override void CreateLabel(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is RibbonControl)
		{
			CreateLabel(method_12());
		}
	}

	protected override void CreateColorPicker(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is RibbonControl)
		{
			CreateColorPicker(method_12());
		}
	}

	protected override void CreateProgressBar(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is RibbonControl)
		{
			CreateProgressBar(method_12());
		}
	}

	protected override void CreateRatingItem(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is RibbonControl)
		{
			CreateRatingItem(method_12());
		}
	}

	protected override void ComponentChangeComponentAdded(object sender, ComponentEventArgs e)
	{
		if (m_AddingItem)
		{
			m_AddingItem = false;
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ControlDesigner)this).get_Control(), null);
			method_12().SubItems.Add(e.Component as BaseItem);
			componentChangeService?.OnComponentChanged(((ControlDesigner)this).get_Control(), null, null, null);
			m_InsertItemTransaction.Commit();
			m_InsertItemTransaction = null;
			RecalcLayout();
		}
	}

	protected override ArrayList GetAllAssociatedComponents()
	{
		ArrayList arrayList = new ArrayList(base.AssociatedComponents);
		if (((ControlDesigner)this).get_Control() is RibbonControl ribbonControl)
		{
			AddSubItems(ribbonControl.RibbonStrip.StripContainerItem, arrayList);
			AddSubItems(ribbonControl.RibbonStrip.CaptionContainerItem, arrayList);
		}
		return arrayList;
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ParentControlDesigner)this).InitializeNewComponent(defaultValues);
		method_13();
	}

	private void method_13()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		method_14();
		method_14();
		RibbonControl ribbonControl = ((ControlDesigner)this).get_Control() as RibbonControl;
		if (ribbonControl != null)
		{
			try
			{
				ribbonControl.KeyTipsFont = new Font("Tahoma", 7f);
			}
			catch
			{
			}
		}
		Style = eDotNetBarStyle.Office2007;
		CanCustomize = true;
		((Control)ribbonControl).set_Size(new Size(200, 154));
		((Control)ribbonControl).set_Dock((DockStyle)1);
		method_15();
		CaptionVisible = true;
	}

	protected override BaseItem GetItemContainer()
	{
		if (((ControlDesigner)this).get_Control() is RibbonControl ribbonControl)
		{
			return ribbonControl.RibbonStrip.method_17();
		}
		return null;
	}

	protected override Control GetItemContainerControl()
	{
		if (((ControlDesigner)this).get_Control() is RibbonControl ribbonControl)
		{
			return (Control)(object)ribbonControl.RibbonStrip;
		}
		return null;
	}

	protected override void DesignTimeSelectionChanged(ISelectionService ss)
	{
		base.DesignTimeSelectionChanged(ss);
		if (ss == null || ((ControlDesigner)this).get_Control() == null || ((ControlDesigner)this).get_Control().get_IsDisposed() || !(((ControlDesigner)this).get_Control() is RibbonControl ribbonControl))
		{
			return;
		}
		BaseItem stripContainerItem = ribbonControl.RibbonStrip.StripContainerItem;
		if (stripContainerItem != null && ss.PrimarySelection is RibbonTabItem)
		{
			RibbonTabItem ribbonTabItem = ss.PrimarySelection as RibbonTabItem;
			if (stripContainerItem.SubItems.Contains(ribbonTabItem))
			{
				TypeDescriptor.GetProperties(ribbonTabItem)["Checked"]!.SetValue(ribbonTabItem, true);
			}
		}
	}

	protected override void OtherComponentRemoving(object sender, ComponentEventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is RibbonControl ribbonControl)
		{
			BaseItem stripContainerItem = ribbonControl.RibbonStrip.StripContainerItem;
			if (e.Component is RibbonTabItem && stripContainerItem != null && stripContainerItem.SubItems != null && stripContainerItem.SubItems.Contains((RibbonTabItem)e.Component) && ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost)
			{
				designerHost.DestroyComponent((IComponent)((RibbonTabItem)e.Component).Panel);
			}
		}
		base.OtherComponentRemoving(sender, e);
	}

	protected override void ComponentRemoved(object sender, ComponentEventArgs e)
	{
		RibbonControl ribbonControl = ((ControlDesigner)this).get_Control() as RibbonControl;
		if (e.Component is BaseItem && ribbonControl != null)
		{
			BaseItem baseItem = e.Component as BaseItem;
			if (ribbonControl.Items.Contains(baseItem))
			{
				ribbonControl.Items.Remove(baseItem);
			}
			else if (ribbonControl.QuickToolbarItems.Contains(baseItem))
			{
				ribbonControl.QuickToolbarItems.Remove(baseItem);
			}
			DestroySubItems(baseItem);
		}
	}

	protected override bool OnMouseDown(ref Message m, MouseButtons button)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		bool_12 = false;
		Control itemContainerControl = GetItemContainerControl();
		if (!(itemContainerControl is RibbonStrip ribbonStrip))
		{
			return base.OnMouseDown(ref m, button);
		}
		Point pt = ((Control)ribbonStrip).PointToClient(Control.get_MousePosition());
		if (!((Control)ribbonStrip).get_ClientRectangle().Contains(pt))
		{
			return base.OnMouseDown(ref m, button);
		}
		if ((int)button == 2097152)
		{
			if (ribbonStrip.Rectangle_2.Contains(pt))
			{
				bool_12 = true;
			}
			return base.OnMouseDown(ref m, button);
		}
		bool flag = true;
		foreach (RibbonTabItemGroup tabGroup in ribbonStrip.TabGroups)
		{
			foreach (Rectangle item in tabGroup.arrayList_0)
			{
				if (item.Contains(pt))
				{
					ArrayList arrayList = new ArrayList(1);
					arrayList.Add(tabGroup);
					ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
					selectionService.SetSelectedComponents(arrayList, SelectionTypes.Click);
					MouseDownSelectionPerformed = true;
					flag = false;
					break;
				}
			}
		}
		if (flag)
		{
			return base.OnMouseDown(ref m, button);
		}
		return true;
	}

	protected virtual void CreateRibbonTab(object sender, EventArgs e)
	{
		method_14();
	}

	private void method_14()
	{
		bool_12 = false;
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Create Ribbon Tab");
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		RibbonControl ribbonControl = ((ControlDesigner)this).get_Control() as RibbonControl;
		try
		{
			m_CreatingItem = true;
			OnSubItemsChanging();
			RibbonTabItem ribbonTabItem = designerHost.CreateComponent(typeof(RibbonTabItem)) as RibbonTabItem;
			TypeDescriptor.GetProperties(ribbonTabItem)["Text"]!.SetValue(ribbonTabItem, ribbonTabItem.Name);
			RibbonPanel ribbonPanel = designerHost.CreateComponent(typeof(RibbonPanel)) as RibbonPanel;
			TypeDescriptor.GetProperties(ribbonPanel)["Dock"]!.SetValue(ribbonPanel, (object)(DockStyle)5);
			TypeDescriptor.GetProperties(ribbonPanel)["ColorSchemeStyle"]!.SetValue(ribbonPanel, ribbonControl.Style);
			ribbonControl.SetRibbonPanelStyle(ribbonPanel);
			componentChangeService.OnComponentChanging(((ControlDesigner)this).get_Control(), TypeDescriptor.GetProperties(typeof(Control))["Controls"]);
			((ControlDesigner)this).get_Control().get_Controls().Add((Control)(object)ribbonPanel);
			((Control)ribbonPanel).SendToBack();
			componentChangeService.OnComponentChanged(((ControlDesigner)this).get_Control(), TypeDescriptor.GetProperties(typeof(Control))["Controls"], null, null);
			TypeDescriptor.GetProperties(ribbonTabItem)["Panel"]!.SetValue(ribbonTabItem, ribbonPanel);
			GenericItemContainer stripContainerItem = ribbonControl.RibbonStrip.StripContainerItem;
			componentChangeService.OnComponentChanging(stripContainerItem, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
			stripContainerItem.SubItems.Add(ribbonTabItem);
			componentChangeService.OnComponentChanged(stripContainerItem, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
			if (stripContainerItem.SubItems.Count == 1)
			{
				TypeDescriptor.GetProperties(ribbonTabItem)["Checked"]!.SetValue(ribbonTabItem, true);
			}
			RecalcLayout();
			OnSubItemsChanged();
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
			m_CreatingItem = false;
		}
	}

	private void method_15()
	{
		if (!(((ControlDesigner)this).get_Control() is RibbonControl ribbonControl) || ribbonControl.SelectedRibbonTabItem == null || ribbonControl.SelectedRibbonTabItem.Panel == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Create Default Ribbon Bar");
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		try
		{
			RibbonBar ribbonBar = designerHost.CreateComponent(typeof(RibbonBar)) as RibbonBar;
			TypeDescriptor.GetProperties(ribbonBar)["Width"]!.SetValue(ribbonBar, 100);
			TypeDescriptor.GetProperties(ribbonBar)["Text"]!.SetValue(ribbonBar, ((Control)ribbonBar).get_Name());
			componentChangeService.OnComponentChanging(ribbonControl.SelectedRibbonTabItem.Panel, TypeDescriptor.GetProperties(typeof(Control))["Controls"]);
			((Control)ribbonControl.SelectedRibbonTabItem.Panel).get_Controls().Add((Control)(object)ribbonBar);
			((Control)ribbonBar).set_Dock((DockStyle)3);
			componentChangeService.OnComponentChanged(ribbonControl.SelectedRibbonTabItem.Panel, TypeDescriptor.GetProperties(typeof(Control))["Controls"], null, null);
			RecalcLayout();
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	private ButtonItem method_16(IDesignerHost idesignerHost_0, string string_1, Image image_0)
	{
		ButtonItem buttonItem = idesignerHost_0.CreateComponent(typeof(ButtonItem)) as ButtonItem;
		buttonItem.ButtonStyle = eButtonStyle.ImageAndText;
		buttonItem.Image = image_0;
		buttonItem.SubItemsExpandWidth = 24;
		buttonItem.Text = string_1;
		return buttonItem;
	}

	private ButtonItem method_17(IDesignerHost idesignerHost_0, string string_1)
	{
		ButtonItem buttonItem = idesignerHost_0.CreateComponent(typeof(ButtonItem)) as ButtonItem;
		buttonItem.Text = string_1;
		return buttonItem;
	}

	private static Bitmap smethod_0(string string_1)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		string text = smethod_1();
		if (text != "" && File.Exists(text + string_1))
		{
			return new Bitmap(text + string_1);
		}
		return null;
	}

	private static string smethod_1()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine;
			string text = "";
			try
			{
				if (registryKey != null)
				{
					registryKey = registryKey.OpenSubKey("Software\\DevComponents\\DotNetBar");
				}
				if (registryKey != null)
				{
					text = registryKey.GetValue("InstallationFolder", "")!.ToString();
				}
			}
			finally
			{
				registryKey?.Close();
			}
			if (text != "")
			{
				if (text.Substring(text.Length - 1, 1) != "\\")
				{
					text += "\\";
				}
				return text + "Images\\";
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	private QatCustomizeItem method_18(RibbonControl ribbonControl_0)
	{
		QatCustomizeItem result = null;
		foreach (BaseItem quickToolbarItem in ribbonControl_0.QuickToolbarItems)
		{
			if (quickToolbarItem is QatCustomizeItem)
			{
				return quickToolbarItem as QatCustomizeItem;
			}
		}
		return result;
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ParentControlDesigner)this).PreFilterProperties(properties);
		properties["Expanded"] = TypeDescriptor.CreateProperty(typeof(RibbonControlDesigner), (PropertyDescriptor)properties["Expanded"], new DefaultValueAttribute(value: true), new BrowsableAttribute(browsable: true), new CategoryAttribute("Layout"));
		properties["Style"] = TypeDescriptor.CreateProperty(typeof(RibbonControlDesigner), (PropertyDescriptor)properties["Style"], new DefaultValueAttribute(eDotNetBarStyle.Office2003), new BrowsableAttribute(browsable: true), new CategoryAttribute("Appearance"));
		properties["CaptionVisible"] = TypeDescriptor.CreateProperty(typeof(RibbonControlDesigner), (PropertyDescriptor)properties["CaptionVisible"], new DefaultValueAttribute(value: false), new BrowsableAttribute(browsable: true), new CategoryAttribute("Appearance"), new DescriptionAttribute("Indicates whether custom caption and quick access toolbar provided by the control is visible."));
		properties["CanCustomize"] = TypeDescriptor.CreateProperty(typeof(RibbonControlDesigner), (PropertyDescriptor)properties["CanCustomize"], new DefaultValueAttribute(value: true), new BrowsableAttribute(browsable: true), new CategoryAttribute("Quick Access Toolbar"), new DescriptionAttribute("Indicates whether control can be customized. Caption must be visible for customization to be fully enabled"));
	}
}
