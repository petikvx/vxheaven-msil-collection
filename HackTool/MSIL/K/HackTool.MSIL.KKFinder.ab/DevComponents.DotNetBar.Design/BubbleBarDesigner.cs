using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class BubbleBarDesigner : ControlDesigner
{
	private bool bool_0;

	private Point point_0 = Point.Empty;

	private bool bool_1;

	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] value = new DesignerVerb[2]
			{
				new DesignerVerb("Create Tab", method_5),
				new DesignerVerb("Create Button", method_4)
			};
			return new DesignerVerbCollection(value);
		}
	}

	public override ICollection AssociatedComponents
	{
		get
		{
			ArrayList arrayList = new ArrayList(((ControlDesigner)this).get_AssociatedComponents());
			if (((ControlDesigner)this).get_Control() is BubbleBar bubbleBar)
			{
				{
					foreach (BubbleBarTab tab in bubbleBar.Tabs)
					{
						arrayList.Add(tab);
						method_8(tab, arrayList);
					}
					return arrayList;
				}
			}
			return arrayList;
		}
	}

	public override void Initialize(IComponent component)
	{
		((ControlDesigner)this).Initialize(component);
		if (component.Site!.DesignMode)
		{
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null)
			{
				selectionService.SelectionChanged += method_1;
			}
			IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
			if (componentChangeService != null)
			{
				componentChangeService.ComponentRemoving += method_3;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null)
		{
			selectionService.SelectionChanged -= method_1;
		}
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		if (componentChangeService != null)
		{
			componentChangeService.ComponentRemoving -= method_3;
		}
		((ControlDesigner)this).Dispose(disposing);
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ControlDesigner)this).InitializeNewComponent(defaultValues);
		method_0();
	}

	private void method_0()
	{
		if (((ComponentDesigner)this).get_Component() is BubbleBar bubbleBar)
		{
			bubbleBar.ButtonBackAreaStyle.method_4(new ColorScheme(eDotNetBarStyle.Office2003));
			bubbleBar.ButtonBackAreaStyle.BackColor = Color.FromArgb(66, Color.DimGray);
			bubbleBar.ButtonBackAreaStyle.BorderColor = Color.FromArgb(180, Color.WhiteSmoke);
			bubbleBar.ButtonBackAreaStyle.BorderTop = eStyleBorderType.Solid;
			bubbleBar.ButtonBackAreaStyle.BorderTopWidth = 1;
			bubbleBar.ButtonBackAreaStyle.BorderBottom = eStyleBorderType.Solid;
			bubbleBar.ButtonBackAreaStyle.BorderBottomWidth = 1;
			bubbleBar.ButtonBackAreaStyle.BorderLeft = eStyleBorderType.Solid;
			bubbleBar.ButtonBackAreaStyle.BorderLeftWidth = 1;
			bubbleBar.ButtonBackAreaStyle.BorderRight = eStyleBorderType.Solid;
			bubbleBar.ButtonBackAreaStyle.BorderRightWidth = 1;
			bubbleBar.ButtonBackAreaStyle.PaddingBottom = 3;
			bubbleBar.ButtonBackAreaStyle.PaddingTop = 3;
			bubbleBar.ButtonBackAreaStyle.PaddingLeft = 3;
			bubbleBar.ButtonBackAreaStyle.PaddingRight = 3;
			bubbleBar.SelectedTabColors.BorderColor = Color.Black;
			bubbleBar.MouseOverTabColors.BorderColor = SystemColors.Highlight;
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService == null)
		{
			return;
		}
		bool flag = method_2();
		if (selectionService.PrimarySelection is BubbleBarTab)
		{
			if (((BubbleBarTab)selectionService.PrimarySelection).Parent == ((ControlDesigner)this).get_Control())
			{
				((BubbleBarTab)selectionService.PrimarySelection).Focus = true;
				flag = true;
			}
		}
		else if (selectionService.PrimarySelection is BubbleButton && ((BubbleButton)selectionService.PrimarySelection).Parent.Parent == ((ControlDesigner)this).get_Control())
		{
			((BubbleButton)selectionService.PrimarySelection).Focus = true;
			flag = true;
		}
		if (flag)
		{
			((ControlDesigner)this).get_Control().Refresh();
		}
	}

	private bool method_2()
	{
		bool result = false;
		BubbleBar bubbleBar = ((ControlDesigner)this).get_Control() as BubbleBar;
		foreach (BubbleBarTab tab in bubbleBar.Tabs)
		{
			if (tab.Focus)
			{
				tab.Focus = false;
				result = true;
			}
			foreach (BubbleButton button in tab.Buttons)
			{
				if (button.Focus)
				{
					button.Focus = false;
					result = true;
				}
			}
		}
		return result;
	}

	private void method_3(object sender, ComponentEventArgs e)
	{
		if (e.Component == ((ComponentDesigner)this).get_Component())
		{
			ThisComponentRemoving(sender, e);
		}
		else if (e.Component is BubbleBarTab)
		{
			BubbleBarTab bubbleBarTab = e.Component as BubbleBarTab;
			if (bubbleBarTab.Parent == ((ControlDesigner)this).get_Control())
			{
				IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
				BubbleButton[] array = new BubbleButton[bubbleBarTab.Buttons.Count];
				bubbleBarTab.Buttons.CopyTo(array, 0);
				BubbleButton[] array2 = array;
				foreach (BubbleButton component in array2)
				{
					designerHost.DestroyComponent(component);
				}
				BubbleBar bubbleBar = ((ComponentDesigner)this).get_Component() as BubbleBar;
				bubbleBar.Tabs.Remove(bubbleBarTab);
				bubbleBar.RecalcLayout();
				((Control)bubbleBar).Refresh();
			}
		}
		else if (e.Component is BubbleButton)
		{
			BubbleButton bubbleButton = e.Component as BubbleButton;
			if (bubbleButton.GetBubbleBar() == ((ControlDesigner)this).get_Control())
			{
				bubbleButton.Parent.Buttons.Remove(bubbleButton);
				BubbleBar bubbleBar2 = ((ComponentDesigner)this).get_Component() as BubbleBar;
				bubbleBar2.RecalcLayout();
				((Control)bubbleBar2).Refresh();
			}
		}
	}

	protected virtual void ThisComponentRemoving(object sender, ComponentEventArgs e)
	{
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		if (componentChangeService != null)
		{
			componentChangeService.ComponentRemoving -= method_3;
		}
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null)
		{
			selectionService.SelectionChanged -= method_1;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		BubbleBar bubbleBar = ((ComponentDesigner)this).get_Component() as BubbleBar;
		if (designerHost == null)
		{
			return;
		}
		foreach (BubbleBarTab tab in bubbleBar.Tabs)
		{
			foreach (BubbleButton button in tab.Buttons)
			{
				designerHost.DestroyComponent(button);
			}
			designerHost.DestroyComponent(tab);
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		if (!(((ControlDesigner)this).get_Control() is BubbleBar bubbleBar))
		{
			return;
		}
		if (bubbleBar.SelectedTab == null)
		{
			BubbleBarTab selectedTab = method_6();
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(bubbleBar).Find("SelectedTab", ignoreCase: true));
			bubbleBar.SelectedTab = selectedTab;
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(bubbleBar).Find("SelectedTab", ignoreCase: true), null, null);
		}
		if (bubbleBar.SelectedTab == null)
		{
			return;
		}
		BubbleButton bubbleButton = method_7(bubbleBar.SelectedTab);
		if (bubbleButton != null)
		{
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null)
			{
				ArrayList arrayList = new ArrayList();
				arrayList.Add(bubbleButton);
				selectionService.SetSelectedComponents(arrayList);
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		if (!(((ControlDesigner)this).get_Control() is BubbleBar bubbleBar))
		{
			return;
		}
		BubbleBarTab bubbleBarTab = method_6();
		if (bubbleBarTab != null)
		{
			if (bubbleBar.SelectedTab != bubbleBarTab)
			{
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(bubbleBar).Find("SelectedTab", ignoreCase: true));
				bubbleBar.SelectedTab = bubbleBarTab;
				componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(bubbleBar).Find("SelectedTab", ignoreCase: true), null, null);
			}
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null)
			{
				ArrayList arrayList = new ArrayList();
				arrayList.Add(bubbleBarTab);
				selectionService.SetSelectedComponents(arrayList);
			}
		}
	}

	private BubbleBarTab method_6()
	{
		if (!(((ControlDesigner)this).get_Control() is BubbleBar bubbleBar))
		{
			return null;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return null;
		}
		IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(bubbleBar).Find("Tabs", ignoreCase: true));
		if (!(designerHost.CreateComponent(typeof(BubbleBarTab)) is BubbleBarTab bubbleBarTab))
		{
			return null;
		}
		bubbleBarTab.Text = bubbleBarTab.Name;
		eTabItemColor predefinedColor = eTabItemColor.Blue;
		if (bubbleBar.Tabs.Count > 0)
		{
			int num = bubbleBar.Tabs.Count + 1;
			Type typeFromHandle = typeof(eTabItemColor);
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public);
			int num2 = fields.Length;
			while (num > num2)
			{
				num -= num2;
			}
			if (num == 0)
			{
				num++;
			}
			predefinedColor = (eTabItemColor)Enum.Parse(typeof(eTabItemColor), fields[num].Name);
		}
		bubbleBarTab.PredefinedColor = predefinedColor;
		bubbleBar.Tabs.Add(bubbleBarTab);
		componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(bubbleBar).Find("Tabs", ignoreCase: true), null, null);
		return bubbleBarTab;
	}

	private BubbleButton method_7(BubbleBarTab bubbleBarTab_0)
	{
		if (!(((ControlDesigner)this).get_Control() is BubbleBar))
		{
			return null;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return null;
		}
		IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(bubbleBarTab_0).Find("Buttons", ignoreCase: true));
		if (!(designerHost.CreateComponent(typeof(BubbleButton)) is BubbleButton bubbleButton))
		{
			return null;
		}
		bubbleButton.Image = (Image)(object)Class109.smethod_67("SystemImages.Note24.png");
		bubbleButton.ImageLarge = (Image)(object)Class109.smethod_67("SystemImages.Note64.png");
		bubbleBarTab_0.Buttons.Add(bubbleButton);
		componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(bubbleBarTab_0).Find("Buttons", ignoreCase: true), null, null);
		return bubbleButton;
	}

	private void method_8(BubbleBarTab bubbleBarTab_0, ArrayList arrayList_0)
	{
		foreach (BubbleButton button in bubbleBarTab_0.Buttons)
		{
			arrayList_0.Add(button);
		}
	}

	protected override void OnSetCursor()
	{
		BubbleBar bubbleBar = ((ControlDesigner)this).get_Control() as BubbleBar;
		Point p = ((Control)bubbleBar).PointToClient(Control.get_MousePosition());
		BubbleButton buttonAt = bubbleBar.GetButtonAt(p);
		if (buttonAt != null)
		{
			Cursor.set_Current(Cursors.get_Default());
			return;
		}
		BubbleBarTab tabAt = bubbleBar.GetTabAt(p);
		if (tabAt != null)
		{
			Cursor.set_Current(Cursors.get_Default());
		}
		else
		{
			((ControlDesigner)this).OnSetCursor();
		}
	}

	protected override void WndProc(ref Message m)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		switch (((Message)(ref m)).get_Msg())
		{
		case 512:
			if (OnMouseMove(ref m))
			{
				return;
			}
			break;
		case 515:
			if (method_9(m))
			{
				return;
			}
			break;
		case 513:
		case 516:
			if (OnMouseDown(ref m))
			{
				return;
			}
			break;
		case 514:
		case 517:
			if (method_10(ref m))
			{
				return;
			}
			break;
		}
		((ControlDesigner)this).WndProc(ref m);
	}

	private bool method_9(Message message_0)
	{
		bool result = false;
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null && selectionService.PrimarySelection is BubbleButton && ((BubbleButton)selectionService.PrimarySelection).GetBubbleBar() == ((ControlDesigner)this).get_Control())
		{
			IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
			if (designerHost != null)
			{
				IDesigner designer = designerHost.GetDesigner(selectionService.PrimarySelection as IComponent);
				if (designer != null)
				{
					designer.DoDefaultAction();
					result = true;
				}
			}
		}
		return result;
	}

	protected virtual bool OnMouseDown(ref Message m)
	{
		if (!(((ControlDesigner)this).get_Control() is BubbleBar bubbleBar))
		{
			return false;
		}
		Point p = (point_0 = ((Control)bubbleBar).PointToClient(Control.get_MousePosition()));
		BubbleButton buttonAt = bubbleBar.GetButtonAt(p);
		if (buttonAt != null)
		{
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null)
			{
				ArrayList arrayList = new ArrayList(1);
				arrayList.Add(buttonAt);
				selectionService.SetSelectedComponents(arrayList, SelectionTypes.Click);
				bool_0 = true;
				if (((Message)(ref m)).get_Msg() == 516)
				{
					((ControlDesigner)this).OnContextMenu(Control.get_MousePosition().X, Control.get_MousePosition().Y);
				}
				return true;
			}
		}
		BubbleBarTab tabAt = bubbleBar.GetTabAt(p);
		if (tabAt != null)
		{
			ISelectionService selectionService2 = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService2 != null && selectionService2.PrimarySelection != tabAt)
			{
				ArrayList arrayList2 = new ArrayList(1);
				arrayList2.Add(tabAt);
				selectionService2.SetSelectedComponents(arrayList2, SelectionTypes.Click);
				if (bubbleBar.SelectedTab != tabAt)
				{
					IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
					componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(bubbleBar).Find("SelectedTab", ignoreCase: true));
					bubbleBar.SelectedTab = tabAt;
					componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(bubbleBar).Find("SelectedTab", ignoreCase: true), null, null);
				}
				bool_0 = true;
				if (((Message)(ref m)).get_Msg() != 516)
				{
					return true;
				}
			}
			if (((Message)(ref m)).get_Msg() == 516)
			{
				((ControlDesigner)this).OnContextMenu(Control.get_MousePosition().X, Control.get_MousePosition().Y);
				return true;
			}
		}
		return false;
	}

	protected virtual bool OnMouseMove(ref Message m)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		BubbleBar bubbleBar = ((ControlDesigner)this).get_Control() as BubbleBar;
		Point point = ((Control)bubbleBar).PointToClient(Control.get_MousePosition());
		if ((int)Control.get_MouseButtons() == 1048576)
		{
			if (bubbleBar.Boolean_0)
			{
				bubbleBar.method_46(point);
				return true;
			}
			if ((!point_0.IsEmpty && Math.Abs(point_0.X - point.X) >= 2) || Math.Abs(point_0.Y - point.Y) >= 2)
			{
				BubbleBarTab tabAt = bubbleBar.GetTabAt(point);
				if (tabAt != null)
				{
					bubbleBar.method_44(tabAt);
					Control val = Control.FromHandle(((Message)(ref m)).get_HWnd());
					if (val != null)
					{
						bool_1 = true;
						val.set_Capture(true);
					}
					return true;
				}
				BubbleButton buttonAt = bubbleBar.GetButtonAt(point);
				if (buttonAt != null)
				{
					bubbleBar.method_45(buttonAt);
					Control val2 = Control.FromHandle(((Message)(ref m)).get_HWnd());
					if (val2 != null)
					{
						bool_1 = true;
						val2.set_Capture(true);
					}
					return true;
				}
				point_0 = Point.Empty;
			}
		}
		BubbleBarTab tabAt2 = bubbleBar.GetTabAt(point);
		if (tabAt2 != null)
		{
			bubbleBar.method_43(tabAt2);
		}
		else
		{
			bubbleBar.method_43(null);
		}
		return false;
	}

	private bool method_10(ref Message message_0)
	{
		if (bool_1)
		{
			Control val = Control.FromHandle(((Message)(ref message_0)).get_HWnd());
			if (val != null)
			{
				val.set_Capture(false);
			}
			bool_1 = false;
		}
		if (((ControlDesigner)this).get_Control() is BubbleBar bubbleBar && bubbleBar.Boolean_0)
		{
			Point point_ = ((Control)bubbleBar).PointToClient(Control.get_MousePosition());
			bubbleBar.method_47(point_);
			BubbleBarTab selectedTab = bubbleBar.SelectedTab;
			if (selectedTab != null)
			{
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(selectedTab).Find("Buttons", ignoreCase: true));
				componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(selectedTab).Find("Buttons", ignoreCase: true), null, null);
			}
		}
		if (bool_0)
		{
			bool_0 = false;
			return true;
		}
		return false;
	}
}
