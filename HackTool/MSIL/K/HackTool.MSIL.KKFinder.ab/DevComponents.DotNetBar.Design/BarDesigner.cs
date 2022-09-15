using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class BarDesigner : BarBaseControlDesigner
{
	private int int_1 = -1;

	private bool bool_12;

	private Form form_0;

	private DockSiteInfo dockSiteInfo_0;

	private bool bool_13;

	private Timer timer_2;

	private Bar bar_0;

	private int int_2 = -1;

	public override DesignerVerbCollection Verbs
	{
		get
		{
			((ControlDesigner)this).get_Control();
			DesignerVerb[] array = null;
			array = ((!IsDockableWindow) ? new DesignerVerb[14]
			{
				new DesignerVerb("Add Button", CreateButton),
				new DesignerVerb("Add Text Box", CreateTextBox),
				new DesignerVerb("Add Combo Box", CreateComboBox),
				new DesignerVerb("Add Label", CreateLabel),
				new DesignerVerb("Add Color Picker", CreateColorPicker),
				new DesignerVerb("Add Container", CreateContainer),
				new DesignerVerb("Add Progress bar", CreateProgressBar),
				new DesignerVerb("Add Color Picker", CreateColorPicker),
				new DesignerVerb("Add Check Box", CreateCheckBox),
				new DesignerVerb("Add Slider", CreateSliderItem),
				new DesignerVerb("Add Customize Item", CreateCustomizeItem),
				new DesignerVerb("Add MDI Window List Item", CreateMdiWindowList),
				new DesignerVerb("Add Rating Item", CreateRatingItem),
				new DesignerVerb("Add Control Container", CreateControlContainer)
			} : new DesignerVerb[1]
			{
				new DesignerVerb("Create Dock Tab", CreateDocument)
			});
			return new DesignerVerbCollection(array);
		}
	}

	[DefaultValue(eDotNetBarStyle.OfficeXP)]
	[Description("Specifies the visual style of the Bar.")]
	[Category("Appearance")]
	[Browsable(true)]
	public eDotNetBarStyle Style
	{
		get
		{
			Bar bar = ((ControlDesigner)this).get_Control() as Bar;
			return bar.Style;
		}
		set
		{
			Bar bar = ((ControlDesigner)this).get_Control() as Bar;
			bool flag = bar.Style != value;
			bar.Style = value;
			if (flag && bar.Owner is DotNetBarManager && ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost && !designerHost.Loading)
			{
				DotNetBarManager component = bar.Owner as DotNetBarManager;
				TypeDescriptor.GetProperties(component)["Style"]!.SetValue(component, value);
			}
		}
	}

	[DefaultValue(true)]
	[Category("Behavior")]
	[Description("Gets or sets whether items on the Bar can be customized.")]
	[Browsable(true)]
	public bool CanCustomize
	{
		get
		{
			return (bool)((ComponentDesigner)this).get_ShadowProperties().get_Item("CanCustomize");
		}
		set
		{
			((ComponentDesigner)this).get_ShadowProperties().set_Item("CanCustomize", (object)value);
		}
	}

	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Indicates whether Bar is in auto-hide state. Applies to non-document dockable bars only.")]
	public bool AutoHide
	{
		get
		{
			return (bool)((ComponentDesigner)this).get_ShadowProperties().get_Item("AutoHide");
		}
		set
		{
			((ComponentDesigner)this).get_ShadowProperties().set_Item("AutoHide", (object)value);
		}
	}

	public override SelectionRules SelectionRules
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			if (IsDockableWindow || ((ControlDesigner)this).get_Control().get_Parent() is DockSite)
			{
				return (SelectionRules)int.MinValue;
			}
			return ((ControlDesigner)this).get_SelectionRules();
		}
	}

	protected override bool IsDockableWindow
	{
		get
		{
			if (((ControlDesigner)this).get_Control() is Bar bar && bar.LayoutType == eLayoutType.DockContainer)
			{
				return true;
			}
			return false;
		}
	}

	private bool Boolean_0
	{
		get
		{
			if (((ControlDesigner)this).get_Control() is Bar bar && bar.LayoutType == eLayoutType.Toolbar && ((Control)bar).get_Parent() is DockSite)
			{
				return true;
			}
			return false;
		}
	}

	private bool Boolean_1
	{
		get
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Invalid comparison between Unknown and I4
			if (((ControlDesigner)this).get_Control() is Bar bar && bar.LayoutType == eLayoutType.DockContainer)
			{
				if (((Control)bar).get_Parent() is DockSite && (int)((Control)bar).get_Parent().get_Dock() == 5)
				{
					return true;
				}
				return false;
			}
			return false;
		}
	}

	protected override eDotNetBarStyle InternalStyle
	{
		get
		{
			if (((ControlDesigner)this).get_Control() is Bar bar)
			{
				return bar.Style;
			}
			return base.InternalStyle;
		}
	}

	public BarDesigner()
	{
		dockSiteInfo_0 = default(DockSiteInfo);
		EnableItemDragDrop = true;
	}

	public override void Initialize(IComponent component)
	{
		base.Initialize(component);
		if (component is Bar bar)
		{
			bar.SetDesignMode(b: true);
		}
		if (((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost)
		{
			designerHost.LoadComplete += method_12;
		}
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ParentControlDesigner)this).PreFilterProperties(properties);
		properties["AutoHide"] = TypeDescriptor.CreateProperty(((object)this).GetType(), "AutoHide", typeof(bool), new BrowsableAttribute(browsable: true), new DefaultValueAttribute(value: false), new CategoryAttribute("Auto-Hide"), new DescriptionAttribute("Indicates whether Bar is in auto-hide state. Applies to non-document dockable bars only."));
		properties["CanCustomize"] = TypeDescriptor.CreateProperty(((object)this).GetType(), "CanCustomize", typeof(bool), new BrowsableAttribute(browsable: true), new DefaultValueAttribute(value: true), new CategoryAttribute("Behavior"), new DescriptionAttribute("Gets or sets whether items on the Bar can be customized."));
		properties["Style"] = TypeDescriptor.CreateProperty(((object)this).GetType(), "Style", typeof(eDotNetBarStyle), new BrowsableAttribute(browsable: true), new DefaultValueAttribute(value: true), new CategoryAttribute("Appearance"), new DescriptionAttribute("Gets or sets the control style."));
	}

	private void method_12(object sender, EventArgs e)
	{
		if (IsDockableWindow)
		{
			Bar bar = ((ControlDesigner)this).get_Control() as Bar;
			DockContainerItem selectedDockContainerItem = bar.SelectedDockContainerItem;
			if (selectedDockContainerItem != null && selectedDockContainerItem.Control != null && ((Control)bar).get_Controls().IndexOf(selectedDockContainerItem.Control) > 0)
			{
				((Control)bar).get_Controls().SetChildIndex(selectedDockContainerItem.Control, 0);
			}
		}
		if (((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost)
		{
			designerHost.LoadComplete -= method_12;
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ParentControlDesigner)this).InitializeNewComponent(defaultValues);
		method_13();
	}

	private void method_13()
	{
		if (((ComponentDesigner)this).get_Component() is Bar bar)
		{
			bar.Style = eDotNetBarStyle.Office2003;
		}
	}

	protected override BaseItem GetItemContainer()
	{
		if (((ControlDesigner)this).get_Control() is Bar bar)
		{
			return bar.ItemsContainer;
		}
		return null;
	}

	protected override void RecalcLayout()
	{
		if (GetItemContainerControl() is Bar bar)
		{
			bar.RecalcLayout();
		}
	}

	protected override void OnSubItemsChanging()
	{
		base.OnSubItemsChanging();
		if (((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) is IComponentChangeService componentChangeService)
		{
			Bar component = GetItemContainerControl() as Bar;
			componentChangeService.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(component).Find("Items", ignoreCase: true));
		}
	}

	protected override void OnSubItemsChanged()
	{
		base.OnSubItemsChanged();
		if (((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) is IComponentChangeService componentChangeService)
		{
			Bar component = GetItemContainerControl() as Bar;
			componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(component).Find("Items", ignoreCase: true), null, null);
		}
	}

	public override bool CanParent(Control control)
	{
		if (!control.Contains(((ControlDesigner)this).get_Control()) && !(control is Bar))
		{
			if (IsDockableWindow && !(control is PanelDockContainer))
			{
				return false;
			}
			return base.CanParent(control);
		}
		return false;
	}

	private void method_14(int int_3)
	{
		if (!(((ControlDesigner)this).get_Control() is Bar bar))
		{
			return;
		}
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		componentChangeService?.OnComponentChanging(bar, TypeDescriptor.GetProperties(typeof(Bar))["SelectedDockTab"]);
		bar.SelectedDockTab = int_3;
		componentChangeService?.OnComponentChanged(bar, TypeDescriptor.GetProperties(typeof(Bar))["SelectedDockTab"], null, null);
		if (bar.SelectedDockTab >= 0)
		{
			SelectComponent(bar.Items[bar.SelectedDockTab], SelectionTypes.Click);
			if (bar.Items[bar.SelectedDockTab] is DockContainerItem dockContainerItem && dockContainerItem.Control != null)
			{
				componentChangeService?.OnComponentChanging(bar, TypeDescriptor.GetProperties(typeof(Bar))["Controls"]);
				dockContainerItem.Control.BringToFront();
				componentChangeService?.OnComponentChanged(bar, TypeDescriptor.GetProperties(typeof(Bar))["Controls"], null, null);
			}
		}
	}

	protected override void OtherComponentRemoving(object sender, ComponentEventArgs e)
	{
		Bar bar = ((ControlDesigner)this).get_Control() as Bar;
		if (e.Component is Control)
		{
			IComponent? component = e.Component;
			BaseItem controlItem = GetControlItem((Control)((component is Control) ? component : null));
			if (controlItem != null && controlItem.Parent != null && controlItem.Parent.SubItems.Contains(controlItem))
			{
				if (controlItem is DockContainerItem)
				{
					((DockContainerItem)controlItem).Control = null;
				}
				else if (controlItem is ControlContainerItem)
				{
					((ControlContainerItem)controlItem).Control = null;
				}
				if (controlItem.Parent != null)
				{
					controlItem.Parent.SubItems.Remove(controlItem);
				}
				DestroySubItems(controlItem);
				RecalcLayout();
				if (bar != null && bar.Items.Count > 0)
				{
					method_14(0);
				}
			}
		}
		else if (!m_InternalRemoving && bar != null && e.Component is DockContainerItem && bar.Items.Contains((BaseItem)e.Component) && bar.VisibleItemCount == 1)
		{
			throw new InvalidOperationException("Cannot delete last DockContainerItem object. Select and Delete Bar object instead");
		}
		base.OtherComponentRemoving(sender, e);
	}

	protected override bool OnMouseDown(ref Message m, MouseButtons mb)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		Bar bar = ((ControlDesigner)this).get_Control() as Bar;
		if (IsDockableWindow && bar != null)
		{
			Point mousePosition = Control.get_MousePosition();
			int num = method_19(mousePosition.X, mousePosition.Y);
			if (num >= 0 && ((Message)(ref m)).get_Msg() == 516)
			{
				ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
				if (selectionService != null && selectionService.PrimarySelection != bar.Items[num])
				{
					ArrayList arrayList = new ArrayList(1);
					arrayList.Add(bar.Items[num]);
					selectionService.SetSelectedComponents(arrayList, SelectionTypes.Click);
					method_14(num);
					((ControlDesigner)this).OnContextMenu(Control.get_MousePosition().X, Control.get_MousePosition().Y);
					return true;
				}
			}
			return base.OnMouseDown(ref m, mb);
		}
		return base.OnMouseDown(ref m, mb);
	}

	protected override void OnMouseDragBegin(int x, int y)
	{
		Bar bar = ((ControlDesigner)this).get_Control() as Bar;
		bool_13 = false;
		if (bar != null && IsDockableWindow)
		{
			int_1 = method_19(x, y);
			if (int_1 != -1)
			{
				if (bar.SelectedDockTab != int_1)
				{
					method_14(int_1);
				}
				bool_13 = true;
			}
			else if (method_20(x, y))
			{
				method_21(x, y);
			}
			else if (method_15(bar))
			{
				Point pt = ((Control)bar).PointToClient(new Point(x, y));
				if (bar.GrabHandleRect.Contains(pt))
				{
					bool_13 = true;
				}
			}
		}
		else if (bar != null && Boolean_0 && bar.GrabHandleStyle != 0)
		{
			Point pt2 = ((Control)bar).PointToClient(new Point(x, y));
			if (bar.GrabHandleRect.Contains(pt2))
			{
				bool_13 = true;
			}
		}
		base.OnMouseDragBegin(x, y);
		if (int_1 != -1)
		{
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null && selectionService.PrimarySelection != bar.Items[int_1])
			{
				ArrayList arrayList = new ArrayList(1);
				arrayList.Add(bar.Items[int_1]);
				selectionService.SetSelectedComponents(arrayList, SelectionTypes.Click);
			}
		}
		if (bool_13)
		{
			((Control)bar).set_Capture(true);
			if (Boolean_1)
			{
				Class51.RECT r = new Class51.RECT(0, 0, 0, 0);
				Class51.GetWindowRect(((Control)bar).get_Parent().get_Handle(), ref r);
				Rectangle clip = Rectangle.FromLTRB(r.Left, r.Top, r.Right, r.Bottom);
				Cursor.set_Clip(clip);
			}
		}
	}

	private bool method_15(Bar bar_1)
	{
		if (bar_1.GrabHandleStyle != eGrabHandleStyle.Caption)
		{
			return bar_1.GrabHandleStyle == eGrabHandleStyle.CaptionTaskPane;
		}
		return true;
	}

	protected override void OnMouseDragMove(int x, int y)
	{
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		if ((!IsDockableWindow && !Boolean_0) || !bool_13)
		{
			base.OnMouseDragMove(x, y);
			return;
		}
		Point point = new Point(x, y);
		if (!(((ControlDesigner)this).get_Control() is Bar bar))
		{
			return;
		}
		if (Boolean_0)
		{
			IOwnerBarSupport ownerBarSupport = bar.Owner as IOwnerBarSupport;
			dockSiteInfo_0 = ownerBarSupport.GetDockInfo(bar, point.X, point.Y);
			if (dockSiteInfo_0.objDockSite != null)
			{
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				Control val = null;
				bool flag = false;
				if (dockSiteInfo_0.objDockSite != ((Control)bar).get_Parent())
				{
					val = ((Control)bar).get_Parent();
					componentChangeService.OnComponentChanging(((Control)bar).get_Parent(), null);
					componentChangeService.OnComponentChanging(bar, TypeDescriptor.GetProperties(bar)["DockSide"]);
				}
				componentChangeService.OnComponentChanging(dockSiteInfo_0.objDockSite, null);
				if (dockSiteInfo_0.DockOffset != bar.DockOffset)
				{
					flag = true;
					componentChangeService.OnComponentChanging(bar, TypeDescriptor.GetProperties(bar)["DockOffset"]);
					componentChangeService.OnComponentChanging(bar, TypeDescriptor.GetProperties(bar)["Location"]);
				}
				bar.method_42(dockSiteInfo_0, point);
				if (val != null)
				{
					componentChangeService.OnComponentChanged(bar, TypeDescriptor.GetProperties(bar)["DockSide"], null, null);
					componentChangeService.OnComponentChanged(val, null, null, null);
				}
				componentChangeService.OnComponentChanged(dockSiteInfo_0.objDockSite, null, null, null);
				if (flag)
				{
					componentChangeService.OnComponentChanged(bar, TypeDescriptor.GetProperties(bar)["DockOffset"], null, null);
					componentChangeService.OnComponentChanged(bar, TypeDescriptor.GetProperties(bar)["Location"], null, null);
				}
			}
			((Control)bar).Refresh();
			return;
		}
		Point pt = Point.Empty;
		if (bar.DockTabControl != null)
		{
			pt = ((Control)bar.DockTabControl).PointToClient(point);
		}
		if (bar.DockTabControl != null && ((Control)bar.DockTabControl).get_ClientRectangle().Contains(pt))
		{
			if (bool_12)
			{
				method_18(bar);
				bool_12 = false;
				dockSiteInfo_0 = default(DockSiteInfo);
			}
			MouseEventArgs mouseEventArgs_ = new MouseEventArgs((MouseButtons)1048576, 0, pt.X, pt.Y, 0);
			bar.DockTabControl.method_34(mouseEventArgs_);
			return;
		}
		bool_12 = true;
		IOwnerBarSupport ownerBarSupport2 = bar.Owner as IOwnerBarSupport;
		dockSiteInfo_0 = ownerBarSupport2.GetDockInfo(bar, point.X, point.Y);
		if (dockSiteInfo_0.objDockSite == null)
		{
			if (form_0 != null)
			{
				((Control)form_0).Hide();
			}
			return;
		}
		Rectangle rectangle = dockSiteInfo_0.objDockSite.method_17(bar, ref dockSiteInfo_0);
		if (!rectangle.IsEmpty)
		{
			if (form_0 == null)
			{
				form_0 = Class109.smethod_15();
			}
			Class92.SetWindowPos(((Control)form_0).get_Handle(), 0, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, 80);
		}
		else if (form_0 != null)
		{
			((Control)form_0).Hide();
		}
	}

	protected override void OnMouseDragEnd(bool cancel)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Invalid comparison between Unknown and I4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Invalid comparison between Unknown and I4
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Invalid comparison between Unknown and I4
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Invalid comparison between Unknown and I4
		if (!IsDockableWindow)
		{
			base.OnMouseDragEnd(cancel);
			return;
		}
		((ControlDesigner)this).get_Control().set_Capture(false);
		Cursor.set_Clip(Rectangle.Empty);
		Bar bar = ((ControlDesigner)this).get_Control() as Bar;
		if (!cancel && bar != null && bool_13)
		{
			bool_13 = false;
			if (!(((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost))
			{
				method_18(bar);
				bool_12 = false;
				int_1 = -1;
				base.OnMouseDragEnd(cancel);
				return;
			}
			if (bool_12)
			{
				method_18(bar);
				Bar mouseOverBar = dockSiteInfo_0.MouseOverBar;
				if ((dockSiteInfo_0.MouseOverDockSide != 0 && dockSiteInfo_0.MouseOverDockSide != eDockSide.Document && (mouseOverBar != bar || (int_1 != -1 && bar.VisibleItemCount > 1))) || ((int)dockSiteInfo_0.DockSide != 0 && dockSiteInfo_0.MouseOverDockSide != eDockSide.Document))
				{
					DesignerTransaction designerTransaction = designerHost.CreateTransaction("DotNetBar Docking");
					IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
					try
					{
						Bar bar2 = null;
						DockSite objDockSite = dockSiteInfo_0.objDockSite;
						DockSite dockSite = ((Control)bar).get_Parent() as DockSite;
						bar2 = ((int_1 == -1 || bar.VisibleItemCount <= 1) ? bar : Class109.smethod_7(bar, this));
						componentChangeService.OnComponentChanging(bar, TypeDescriptor.GetProperties(typeof(Bar))["SelectedDockTab"]);
						if (int_1 != -1 && bar.VisibleItemCount > 1)
						{
							DockContainerItem item = bar.Items[bar.SelectedDockTab] as DockContainerItem;
							componentChangeService.OnComponentChanging(bar, TypeDescriptor.GetProperties(typeof(Bar))["Controls"]);
							componentChangeService.OnComponentChanging(bar, TypeDescriptor.GetProperties(typeof(Bar))["Items"]);
							bar.Items.Remove(item);
							componentChangeService.OnComponentChanged(bar, TypeDescriptor.GetProperties(typeof(Bar))["Items"], null, null);
							componentChangeService.OnComponentChanged(bar, TypeDescriptor.GetProperties(typeof(Bar))["Controls"], null, null);
							componentChangeService.OnComponentChanging(bar2, TypeDescriptor.GetProperties(typeof(Bar))["Controls"]);
							componentChangeService.OnComponentChanging(bar2, TypeDescriptor.GetProperties(typeof(Bar))["Items"]);
							bar2.Items.Add(item);
							componentChangeService.OnComponentChanged(bar2, TypeDescriptor.GetProperties(typeof(Bar))["Items"], null, null);
							componentChangeService.OnComponentChanged(bar2, TypeDescriptor.GetProperties(typeof(Bar))["Controls"], null, null);
						}
						componentChangeService.OnComponentChanging(objDockSite, TypeDescriptor.GetProperties(typeof(DockSite))["Controls"]);
						componentChangeService.OnComponentChanging(bar2, null);
						if (mouseOverBar != null)
						{
							componentChangeService.OnComponentChanging(mouseOverBar, null);
						}
						componentChangeService.OnComponentChanging(objDockSite, TypeDescriptor.GetProperties(typeof(DockSite))["DocumentDockContainer"]);
						if (objDockSite != dockSite && dockSite != null)
						{
							componentChangeService.OnComponentChanging(dockSite, TypeDescriptor.GetProperties(typeof(DockSite))["Controls"]);
							componentChangeService.OnComponentChanging(dockSite, TypeDescriptor.GetProperties(typeof(DockSite))["DocumentDockContainer"]);
						}
						dockSiteInfo_0.MouseOverBar = mouseOverBar;
						bar2.method_40(dockSiteInfo_0);
						if (((Control)objDockSite).get_Width() == 0 && ((int)((Control)objDockSite).get_Dock() == 3 || (int)((Control)objDockSite).get_Dock() == 4))
						{
							((Control)objDockSite).set_Width(bar2.method_135(eOrientation.Vertical));
						}
						else if (((Control)objDockSite).get_Height() == 0 && ((int)((Control)objDockSite).get_Dock() == 1 || (int)((Control)objDockSite).get_Dock() == 2))
						{
							((Control)objDockSite).set_Height(bar2.method_135(eOrientation.Horizontal));
						}
						if (objDockSite != dockSite && dockSite != null)
						{
							componentChangeService.OnComponentChanged(dockSite, TypeDescriptor.GetProperties(typeof(DockSite))["DocumentDockContainer"], null, null);
							componentChangeService.OnComponentChanged(dockSite, TypeDescriptor.GetProperties(typeof(DockSite))["Controls"], null, null);
						}
						componentChangeService.OnComponentChanged(objDockSite, TypeDescriptor.GetProperties(typeof(DockSite))["DocumentDockContainer"], null, null);
						if (mouseOverBar != null)
						{
							componentChangeService.OnComponentChanged(mouseOverBar, null, null, null);
						}
						componentChangeService.OnComponentChanged(bar2, null, null, null);
						componentChangeService.OnComponentChanged(objDockSite, TypeDescriptor.GetProperties(typeof(DockSite))["Controls"], null, null);
						Form val = ((Control)bar2).FindForm();
						if (val != null)
						{
							((Control)val).Refresh();
						}
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
				else if (dockSiteInfo_0.MouseOverDockSide == eDockSide.Document && bar != mouseOverBar && designerHost.GetDesigner((IComponent)mouseOverBar) is BarDesigner barDesigner)
				{
					barDesigner.method_16(bar, int_1);
				}
				dockSiteInfo_0 = default(DockSiteInfo);
			}
			else if (int_1 != -1 && int_1 != bar.SelectedDockTab)
			{
				IComponentChangeService componentChangeService2 = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
				if (componentChangeService2 != null)
				{
					componentChangeService2.OnComponentChanged(bar, TypeDescriptor.GetProperties(typeof(Bar))["Items"], null, null);
					componentChangeService2.OnComponentChanged(bar, TypeDescriptor.GetProperties(typeof(Bar))["SelectedDockTab"], null, null);
					componentChangeService2.OnComponentChanged(bar, TypeDescriptor.GetProperties(typeof(Bar))["Controls"], null, null);
				}
			}
			bool_12 = false;
			int_1 = -1;
			base.OnMouseDragEnd(cancel);
		}
		else
		{
			base.OnMouseDragEnd(cancel);
		}
	}

	internal void method_16(Bar bar_1, int int_3)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		if (timer_2 == null)
		{
			bar_0 = bar_1;
			int_2 = int_3;
			timer_2 = new Timer();
			timer_2.add_Tick((EventHandler)timer_2_Tick);
			timer_2.set_Interval(200);
			timer_2.set_Enabled(true);
			timer_2.Start();
		}
	}

	private void timer_2_Tick(object sender, EventArgs e)
	{
		timer_2.Stop();
		timer_2.set_Enabled(false);
		((Component)(object)timer_2).Dispose();
		timer_2 = null;
		method_17(bar_0, int_2, ((ControlDesigner)this).get_Control() as Bar);
		bar_0 = null;
		int_2 = -1;
	}

	private void method_17(Bar bar_1, int int_3, Bar bar_2)
	{
		IDesignerHost designerHost = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("DotNetBar Docking");
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		try
		{
			DockContainerItem[] array = null;
			if (int_3 != -1)
			{
				array = new DockContainerItem[1] { bar_1.Items[bar_1.SelectedDockTab] as DockContainerItem };
			}
			else
			{
				array = new DockContainerItem[bar_1.Items.Count];
				bar_1.Items.CopyTo(array, 0);
			}
			componentChangeService.OnComponentChanging(bar_1, TypeDescriptor.GetProperties(typeof(Bar))["Controls"]);
			componentChangeService.OnComponentChanging(bar_1, TypeDescriptor.GetProperties(typeof(Bar))["Items"]);
			bar_1.Items.RemoveRange(array);
			componentChangeService.OnComponentChanged(bar_1, TypeDescriptor.GetProperties(typeof(Bar))["Items"], null, null);
			componentChangeService.OnComponentChanged(bar_1, TypeDescriptor.GetProperties(typeof(Bar))["Controls"], null, null);
			componentChangeService.OnComponentChanging(bar_2, TypeDescriptor.GetProperties(typeof(Bar))["Controls"]);
			componentChangeService.OnComponentChanging(bar_2, TypeDescriptor.GetProperties(typeof(Bar))["Items"]);
			bar_2.Items.AddRange(array);
			componentChangeService.OnComponentChanged(bar_2, TypeDescriptor.GetProperties(typeof(Bar))["Items"], null, null);
			componentChangeService.OnComponentChanged(bar_2, TypeDescriptor.GetProperties(typeof(Bar))["Controls"], null, null);
			if (bar_1.Items.Count == 0)
			{
				DockSite dockSite = ((Control)bar_1).get_Parent() as DockSite;
				componentChangeService.OnComponentChanging(dockSite, TypeDescriptor.GetProperties(typeof(DockSite))["DocumentDockContainer"]);
				componentChangeService.OnComponentChanging(bar_1, null);
				dockSite.GetDocumentUIManager().method_7(bar_1, bool_2: false);
				componentChangeService.OnComponentChanged(bar_1, null, null, null);
				componentChangeService.OnComponentChanged(dockSite, TypeDescriptor.GetProperties(typeof(DockSite))["DocumentDockContainer"], null, null);
				designerHost.DestroyComponent((IComponent)bar_1);
			}
			if (bar_2 != null && bar_2.SelectedDockTab >= 0 && bar_2.Items[bar_2.SelectedDockTab] is DockContainerItem dockContainerItem && dockContainerItem.Control != null)
			{
				componentChangeService.OnComponentChanged(bar_2, TypeDescriptor.GetProperties(typeof(Bar))["Controls"], null, null);
				dockContainerItem.Control.BringToFront();
				componentChangeService.OnComponentChanged(bar_2, TypeDescriptor.GetProperties(typeof(Bar))["Controls"], null, null);
			}
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

	private void method_18(Bar bar_1)
	{
		if (bar_1.Owner is IOwnerBarSupport ownerBarSupport)
		{
			ownerBarSupport.DockComplete();
		}
		if (form_0 != null)
		{
			((Control)form_0).Hide();
			((Component)(object)form_0).Dispose();
			form_0 = null;
		}
	}

	protected override IOwner GetIOwner()
	{
		Bar bar = ((ControlDesigner)this).get_Control() as Bar;
		if (bar.Owner is IOwner)
		{
			return bar.Owner as IOwner;
		}
		return base.GetIOwner();
	}

	protected override IOwnerMenuSupport GetIOwnerMenuSupport()
	{
		Bar bar = ((ControlDesigner)this).get_Control() as Bar;
		if (bar.Owner is IOwnerMenuSupport)
		{
			return bar.Owner as IOwnerMenuSupport;
		}
		return base.GetIOwnerMenuSupport();
	}

	private int method_19(int int_3, int int_4)
	{
		if (!(((ControlDesigner)this).get_Control() is Bar bar))
		{
			return -1;
		}
		if (IsDockableWindow && bar.DockTabControl != null)
		{
			Point pt = ((Control)bar.DockTabControl).PointToClient(new Point(int_3, int_4));
			if (bar.DockTabControl.Class26_0.bool_5 && bar.DockTabControl.Class26_0.rectangle_0.Contains(pt))
			{
				return -1;
			}
			TabItem tabItem = bar.DockTabControl.HitTest(pt.X, pt.Y);
			if (tabItem != null)
			{
				return bar.Items.IndexOf(tabItem.AttachedItem);
			}
		}
		return -1;
	}

	private bool method_20(int int_3, int int_4)
	{
		if (!(((ControlDesigner)this).get_Control() is Bar bar))
		{
			return false;
		}
		if (IsDockableWindow && bar.DockTabControl != null)
		{
			Point pt = ((Control)bar.DockTabControl).PointToClient(new Point(int_3, int_4));
			if (bar.DockTabControl.Class26_0.bool_5 && bar.DockTabControl.Class26_0.rectangle_0.Contains(pt))
			{
				return true;
			}
		}
		return false;
	}

	private void method_21(int int_3, int int_4)
	{
		if (!(((ControlDesigner)this).get_Control() is Bar bar) || !IsDockableWindow || bar.DockTabControl == null)
		{
			return;
		}
		Point pt = ((Control)bar.DockTabControl).PointToClient(new Point(int_3, int_4));
		if (bar.DockTabControl.Class26_0.bool_5 && bar.DockTabControl.Class26_0.rectangle_0.Contains(pt))
		{
			if (bar.DockTabControl.Class26_0.Boolean_1 && bar.DockTabControl.Class26_0.Rectangle_0.Contains(pt))
			{
				bar.DockTabControl.method_48();
			}
			else if (bar.DockTabControl.Class26_0.Boolean_2 && bar.DockTabControl.Class26_0.Rectangle_1.Contains(pt))
			{
				bar.DockTabControl.method_46();
			}
		}
	}

	protected override void ThisComponentRemoving(object sender, ComponentEventArgs e)
	{
		if (!m_InternalRemoving)
		{
			m_InternalRemoving = true;
			try
			{
				if (IsDockableWindow && ((ControlDesigner)this).get_Control() is Bar bar && ((Control)bar).get_Parent() is DockSite && ((DockSite)(object)((Control)bar).get_Parent()).DocumentDockContainer != null)
				{
					IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
					componentChangeService?.OnComponentChanging((DockSite)(object)((Control)bar).get_Parent(), TypeDescriptor.GetProperties(typeof(DockSite)).Find("DocumentDockContainer", ignoreCase: true));
					((DockSite)(object)((Control)bar).get_Parent()).GetDocumentUIManager().method_7(bar, bool_2: false);
					componentChangeService?.OnComponentChanged((DockSite)(object)((Control)bar).get_Parent(), TypeDescriptor.GetProperties(typeof(DockSite)).Find("DocumentDockContainer", ignoreCase: true), null, null);
				}
			}
			finally
			{
				m_InternalRemoving = false;
			}
		}
		base.ThisComponentRemoving(sender, e);
	}
}
