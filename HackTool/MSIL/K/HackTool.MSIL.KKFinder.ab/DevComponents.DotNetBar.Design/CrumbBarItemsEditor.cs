using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.AdvTree;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.Design;

internal class CrumbBarItemsEditor : UserControl
{
	internal class Class198 : IServiceProvider, ISite
	{
		private IComponent icomponent_0;

		private bool bool_0;

		private IServiceProvider iserviceProvider_0;

		public IComponent Component => icomponent_0;

		public IContainer Container => null;

		public bool DesignMode => false;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Class198(IServiceProvider sp, IComponent comp)
		{
			iserviceProvider_0 = sp;
			icomponent_0 = comp;
		}

		public object GetService(Type t)
		{
			if (!bool_0 && iserviceProvider_0 != null)
			{
				try
				{
					bool_0 = true;
					return iserviceProvider_0.GetService(t);
				}
				finally
				{
					bool_0 = false;
				}
			}
			return null;
		}
	}

	private DevComponents.AdvTree.AdvTree advTree1;

	private Node node1;

	private ElementStyle elementStyle1;

	private ButtonX buttonAddItem;

	private ColumnHeader columnHeader1;

	private ColumnHeader columnHeader2;

	private ButtonX buttonRemoveItem;

	private PropertyGrid propertyGrid1;

	internal ButtonX buttonX1;

	private CrumbBar crumbBar_0;

	private Label label1;

	private CrumbBarDesigner crumbBarDesigner_0;

	private IContainer icontainer_0;

	public CrumbBarDesigner CrumbBarDesigner_0
	{
		get
		{
			return crumbBarDesigner_0;
		}
		set
		{
			crumbBarDesigner_0 = value;
			if (crumbBarDesigner_0 != null)
			{
				((Component)(object)propertyGrid1).Site = new Class198(((ComponentDesigner)crumbBarDesigner_0).get_Component().Site, (IComponent)propertyGrid1);
			}
		}
	}

	public CrumbBar CrumbBar_0
	{
		get
		{
			return crumbBar_0;
		}
		set
		{
			if (value != crumbBar_0)
			{
				CrumbBar crumbBar_ = crumbBar_0;
				crumbBar_0 = value;
				method_7(crumbBar_, value);
			}
		}
	}

	public CrumbBarItemsEditor()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		propertyGrid1 = new PropertyGrid();
		buttonX1 = new ButtonX();
		buttonRemoveItem = new ButtonX();
		buttonAddItem = new ButtonX();
		advTree1 = new DevComponents.AdvTree.AdvTree();
		columnHeader1 = new ColumnHeader();
		columnHeader2 = new ColumnHeader();
		node1 = new Node();
		elementStyle1 = new ElementStyle();
		label1 = new Label();
		((ISupportInitialize)advTree1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)propertyGrid1).set_Anchor((AnchorStyles)15);
		((Control)propertyGrid1).set_Location(new Point(300, 3));
		((Control)propertyGrid1).set_Name("propertyGrid1");
		((Control)propertyGrid1).set_Size(new Size(284, 331));
		((Control)propertyGrid1).set_TabIndex(4);
		propertyGrid1.add_PropertyValueChanged(new PropertyValueChangedEventHandler(propertyGrid1_PropertyValueChanged));
		((Control)buttonX1).set_AccessibleRole((AccessibleRole)43);
		((Control)buttonX1).set_Anchor((AnchorStyles)10);
		buttonX1.ColorTable = eButtonColor.OrangeWithBackground;
		((Control)buttonX1).set_Location(new Point(515, 341));
		((Control)buttonX1).set_Name("buttonX1");
		buttonX1.Shape = new RoundRectangleShapeDescriptor();
		((Control)buttonX1).set_Size(new Size(69, 24));
		((Control)buttonX1).set_TabIndex(5);
		((Control)buttonX1).set_Text("&Close");
		((Control)buttonX1).add_Click((EventHandler)buttonX1_Click);
		((Control)buttonRemoveItem).set_AccessibleRole((AccessibleRole)43);
		((Control)buttonRemoveItem).set_Anchor((AnchorStyles)6);
		buttonRemoveItem.ColorTable = eButtonColor.OrangeWithBackground;
		((Control)buttonRemoveItem).set_Enabled(false);
		buttonRemoveItem.FocusCuesEnabled = false;
		((Control)buttonRemoveItem).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)buttonRemoveItem).set_Location(new Point(32, 341));
		((Control)buttonRemoveItem).set_Name("buttonRemoveItem");
		buttonRemoveItem.Shape = new RoundRectangleShapeDescriptor();
		((Control)buttonRemoveItem).set_Size(new Size(24, 24));
		((Control)buttonRemoveItem).set_TabIndex(3);
		((Control)buttonRemoveItem).add_Click((EventHandler)buttonRemoveItem_Click);
		((Control)buttonAddItem).set_AccessibleRole((AccessibleRole)43);
		((Control)buttonAddItem).set_Anchor((AnchorStyles)6);
		buttonAddItem.ColorTable = eButtonColor.OrangeWithBackground;
		buttonAddItem.FocusCuesEnabled = false;
		((Control)buttonAddItem).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)buttonAddItem).set_Location(new Point(4, 341));
		((Control)buttonAddItem).set_Name("buttonAddItem");
		buttonAddItem.Shape = new RoundRectangleShapeDescriptor();
		((Control)buttonAddItem).set_Size(new Size(24, 24));
		((Control)buttonAddItem).set_TabIndex(1);
		((Control)buttonAddItem).add_Click((EventHandler)buttonAddItem_Click);
		((Control)advTree1).set_AccessibleRole((AccessibleRole)35);
		((Control)advTree1).set_AllowDrop(true);
		((Control)advTree1).set_Anchor((AnchorStyles)7);
		((Control)advTree1).set_BackColor(SystemColors.Window);
		advTree1.BackgroundStyle.Class = "TreeBorderKey";
		advTree1.Columns.Add(columnHeader1);
		advTree1.Columns.Add(columnHeader2);
		advTree1.ExpandButtonType = eExpandButtonType.Triangle;
		advTree1.ExpandWidth = 18;
		((Control)advTree1).set_Location(new Point(3, 3));
		((Control)advTree1).set_Name("advTree1");
		advTree1.Nodes.AddRange(new Node[1] { node1 });
		advTree1.NodeStyle = elementStyle1;
		advTree1.PathSeparator = ";";
		advTree1.SelectionBoxStyle = eSelectionStyle.FullRowSelect;
		((Control)advTree1).set_Size(new Size(291, 332));
		advTree1.Styles.Add(elementStyle1);
		advTree1.SuspendPaint = false;
		((Control)advTree1).set_TabIndex(0);
		((Control)advTree1).set_Text("advTree1");
		advTree1.AfterNodeDrop += advTree1_AfterNodeDrop;
		((Control)advTree1).add_MouseUp(new MouseEventHandler(advTree1_MouseUp));
		advTree1.AfterNodeSelect += advTree1_AfterNodeSelect;
		columnHeader1.Name = "columnHeader1";
		columnHeader1.Text = "Text";
		columnHeader1.Width.Relative = 70;
		columnHeader2.Name = "columnHeader2";
		columnHeader2.Text = "Name";
		columnHeader2.Width.Relative = 30;
		node1.Expanded = true;
		node1.Name = "node1";
		node1.Text = "node1";
		elementStyle1.Name = "elementStyle1";
		elementStyle1.TextColor = SystemColors.ControlText;
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(153, 352));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(141, 13));
		((Control)label1).set_TabIndex(6);
		((Control)label1).set_Text("Drag && drop items to re-order");
		((Control)label1).set_Anchor((AnchorStyles)6);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)buttonX1);
		((Control)this).get_Controls().Add((Control)(object)propertyGrid1);
		((Control)this).get_Controls().Add((Control)(object)buttonRemoveItem);
		((Control)this).get_Controls().Add((Control)(object)buttonAddItem);
		((Control)this).get_Controls().Add((Control)(object)advTree1);
		((Control)this).set_Name("CrumbBarItemsEditor");
		((Control)this).set_Size(new Size(587, 373));
		((UserControl)this).add_Load((EventHandler)CrumbBarItemsEditor_Load);
		((ISupportInitialize)advTree1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private object method_0(Type type_0)
	{
		if (crumbBarDesigner_0 != null)
		{
			return crumbBarDesigner_0.GetDesignService(type_0);
		}
		return null;
	}

	private CrumbBarItem method_1()
	{
		IDesignerHost designerHost = (IDesignerHost)method_0(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return null;
		}
		CrumbBarItem crumbBarItem = (CrumbBarItem)designerHost.CreateComponent(typeof(CrumbBarItem));
		crumbBarItem.Text = crumbBarItem.Name;
		return crumbBarItem;
	}

	private void method_2()
	{
		method_3(null);
	}

	private void method_3(CrumbBarItem crumbBarItem_0)
	{
		IDesignerHost designerHost = (IDesignerHost)method_0(typeof(IDesignerHost));
		DesignerTransaction designerTransaction = null;
		if (designerHost != null)
		{
			designerTransaction = designerHost.CreateTransaction("New CrumbBarItem");
		}
		bool flag = advTree1.Nodes.Count == 0;
		CrumbBarItem crumbBarItem = method_1();
		if (crumbBarItem == null)
		{
			return;
		}
		IComponentChangeService componentChangeService = method_0(typeof(IComponentChangeService)) as IComponentChangeService;
		if (componentChangeService != null)
		{
			if (crumbBarItem_0 == null)
			{
				componentChangeService.OnComponentChanging(crumbBar_0, TypeDescriptor.GetProperties(crumbBar_0)["Items"]);
			}
			else
			{
				componentChangeService.OnComponentChanging(crumbBarItem_0, TypeDescriptor.GetProperties(crumbBarItem_0)["SubItems"]);
			}
		}
		if (crumbBarItem_0 == null)
		{
			crumbBar_0.Items.Add(crumbBarItem);
		}
		else
		{
			crumbBarItem_0.SubItems.Add(crumbBarItem);
		}
		if (componentChangeService != null)
		{
			if (crumbBarItem_0 == null)
			{
				componentChangeService.OnComponentChanged(crumbBar_0, TypeDescriptor.GetProperties(crumbBar_0)["Items"], null, null);
			}
			else
			{
				componentChangeService.OnComponentChanged(crumbBarItem_0, TypeDescriptor.GetProperties(crumbBarItem_0)["SubItems"], null, null);
			}
		}
		designerTransaction?.Commit();
		if (crumbBarItem_0 == null)
		{
			advTree1.Nodes.Add(method_6(crumbBarItem));
		}
		else
		{
			advTree1.SelectedNode.Nodes.Add(method_6(crumbBarItem));
			advTree1.SelectedNode.Expand();
		}
		if (flag && advTree1.SelectedNode == null && advTree1.Nodes.Count > 0)
		{
			advTree1.SelectedNode = advTree1.Nodes[0];
		}
	}

	private void CrumbBarItemsEditor_Load(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		Bitmap val = new Bitmap(16, 16, (PixelFormat)2498570);
		Color color = Color.DarkGray;
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			color = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.CheckBoxItem.Default.Text;
		}
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			Brush val3 = (Brush)new SolidBrush(color);
			try
			{
				val2.FillRectangle(val3, 7, 2, 3, 13);
				val2.FillRectangle(val3, 2, 7, 13, 3);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		buttonAddItem.Image = (Image)(object)val;
		val = new Bitmap(16, 16, (PixelFormat)2498570);
		Graphics val4 = Graphics.FromImage((Image)(object)val);
		try
		{
			Brush val5 = (Brush)new SolidBrush(color);
			try
			{
				val4.FillRectangle(val5, 2, 7, 13, 3);
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val4)?.Dispose();
		}
		buttonRemoveItem.Image = (Image)(object)val;
		object obj = method_0(typeof(IUIService));
		IUIService val6 = (IUIService)((obj is IUIService) ? obj : null);
		if (val6 != null)
		{
			((object)propertyGrid1).GetType().GetProperty("ToolStripRenderer", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.SetValue(propertyGrid1, (object?)(ToolStripProfessionalRenderer)val6.get_Styles()["VsToolWindowRenderer"], null);
		}
	}

	private void advTree1_MouseUp(object sender, MouseEventArgs e)
	{
		Node nodeAt = advTree1.GetNodeAt(e.get_Y());
		if (nodeAt == null)
		{
			advTree1.SelectedNode = null;
		}
	}

	internal void method_4()
	{
		advTree1.Nodes.Clear();
		if (crumbBar_0 == null)
		{
			return;
		}
		advTree1.BeginUpdate();
		foreach (CrumbBarItem item in crumbBar_0.Items)
		{
			Node node = method_6(item);
			advTree1.Nodes.Add(node);
			method_5(node, item);
		}
		advTree1.EndUpdate();
	}

	private void method_5(Node node_0, CrumbBarItem crumbBarItem_0)
	{
		foreach (BaseItem subItem in crumbBarItem_0.SubItems)
		{
			if (subItem is CrumbBarItem)
			{
				CrumbBarItem crumbBarItem_ = (CrumbBarItem)subItem;
				Node node = method_6(crumbBarItem_);
				node_0.Nodes.Add(node);
				method_5(node, crumbBarItem_);
			}
		}
	}

	private Node method_6(CrumbBarItem crumbBarItem_0)
	{
		Node node = new Node();
		node.Expanded = true;
		node.Tag = crumbBarItem_0;
		node.Text = crumbBarItem_0.Text;
		Class271 @class = crumbBarItem_0.method_22();
		if (@class != null)
		{
			node.Image = @class.Image_0;
		}
		node.Cells.Add(new Cell(crumbBarItem_0.Name));
		return node;
	}

	private void method_7(CrumbBar crumbBar_1, CrumbBar crumbBar_2)
	{
		method_4();
	}

	private void buttonAddItem_Click(object sender, EventArgs e)
	{
		CrumbBarItem crumbBarItem_ = null;
		if (advTree1.SelectedNode != null)
		{
			crumbBarItem_ = advTree1.SelectedNode.Tag as CrumbBarItem;
		}
		method_3(crumbBarItem_);
	}

	private void buttonRemoveItem_Click(object sender, EventArgs e)
	{
		if (advTree1.SelectedNode != null && advTree1.SelectedNode.Tag is CrumbBarItem crumbBarItem_)
		{
			advTree1.SelectedNode.Remove();
			method_8(crumbBarItem_);
		}
	}

	private void method_8(CrumbBarItem crumbBarItem_0)
	{
		((IDesignerHost)method_0(typeof(IDesignerHost)))?.DestroyComponent(crumbBarItem_0);
	}

	private void advTree1_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
	{
		((Control)buttonRemoveItem).set_Enabled(e.Node != null);
		if (e.Node != null)
		{
			propertyGrid1.set_SelectedObject(e.Node.Tag);
		}
		else
		{
			propertyGrid1.set_SelectedObject((object)null);
		}
	}

	private void advTree1_AfterNodeDrop(object sender, TreeDragDropEventArgs e)
	{
		IDesignerHost designerHost = (IDesignerHost)method_0(typeof(IDesignerHost));
		DesignerTransaction designerTransaction = null;
		if (designerHost != null)
		{
			designerTransaction = designerHost.CreateTransaction("Move items");
		}
		IComponentChangeService componentChangeService = method_0(typeof(IComponentChangeService)) as IComponentChangeService;
		try
		{
			CrumbBarItem crumbBarItem = e.Node.Tag as CrumbBarItem;
			CrumbBarItem crumbBarItem2 = (CrumbBarItem)crumbBarItem.Parent;
			if (componentChangeService != null)
			{
				if (crumbBarItem2 == null)
				{
					componentChangeService.OnComponentChanging(crumbBar_0, TypeDescriptor.GetProperties(crumbBar_0)["Items"]);
				}
				else
				{
					componentChangeService.OnComponentChanging(crumbBarItem2, TypeDescriptor.GetProperties(crumbBarItem2)["SubItems"]);
				}
			}
			if (crumbBarItem2 == null)
			{
				crumbBar_0.Items.Remove(crumbBarItem);
			}
			else
			{
				crumbBarItem2.SubItems.Remove(crumbBarItem);
			}
			if (componentChangeService != null)
			{
				if (crumbBarItem2 == null)
				{
					componentChangeService.OnComponentChanged(crumbBar_0, TypeDescriptor.GetProperties(crumbBar_0)["Items"], null, null);
				}
				else
				{
					componentChangeService.OnComponentChanged(crumbBarItem2, TypeDescriptor.GetProperties(crumbBarItem2)["SubItems"], null, null);
				}
			}
			if (e.NewParentNode == null)
			{
				int index = advTree1.Nodes.IndexOf(e.Node);
				componentChangeService?.OnComponentChanging(crumbBar_0, TypeDescriptor.GetProperties(crumbBar_0)["Items"]);
				crumbBar_0.Items.Insert(index, crumbBarItem);
				componentChangeService?.OnComponentChanged(crumbBar_0, TypeDescriptor.GetProperties(crumbBar_0)["Items"], null, null);
			}
			else
			{
				crumbBarItem2 = e.NewParentNode.Tag as CrumbBarItem;
				int index2 = e.NewParentNode.Nodes.IndexOf(e.Node);
				componentChangeService?.OnComponentChanging(crumbBarItem2, TypeDescriptor.GetProperties(crumbBarItem2)["SubItems"]);
				crumbBarItem2.SubItems.Insert(index2, crumbBarItem);
				componentChangeService?.OnComponentChanged(crumbBarItem2, TypeDescriptor.GetProperties(crumbBarItem2)["SubItems"], null, null);
			}
		}
		catch
		{
			designerTransaction?.Cancel();
			throw;
		}
		finally
		{
			if (designerTransaction != null && !designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	private void propertyGrid1_PropertyValueChanged(object sender, PropertyValueChangedEventArgs e)
	{
		if (advTree1.SelectedNode == null)
		{
			return;
		}
		Node selectedNode = advTree1.SelectedNode;
		CrumbBarItem crumbBarItem = (CrumbBarItem)propertyGrid1.get_SelectedObject();
		if (e.get_ChangedItem().get_PropertyDescriptor().Name == "Text")
		{
			selectedNode.Text = crumbBarItem.Text;
			return;
		}
		if (!(e.get_ChangedItem().get_PropertyDescriptor().Name == "Image") && !(e.get_ChangedItem().get_PropertyDescriptor().Name == "ImageIndex"))
		{
			if (e.get_ChangedItem().get_PropertyDescriptor().Name == "Name")
			{
				selectedNode.Cells[1].Text = crumbBarItem.Name;
			}
			return;
		}
		Class271 @class = crumbBarItem.method_22();
		if (@class != null)
		{
			selectedNode.Image = @class.Image_0;
		}
	}

	private void buttonX1_Click(object sender, EventArgs e)
	{
		Form val = ((Control)this).FindForm();
		if (val != null)
		{
			val.Close();
		}
	}
}
