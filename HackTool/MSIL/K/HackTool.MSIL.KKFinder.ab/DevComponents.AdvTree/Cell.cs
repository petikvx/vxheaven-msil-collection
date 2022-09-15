using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using DevComponents.AdvTree.Design;
using DevComponents.AdvTree.Display;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.AdvTree;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class Cell : Component
{
	private ElementStyle elementStyle_0;

	private ElementStyle elementStyle_1;

	private ElementStyle elementStyle_2;

	private ElementStyle elementStyle_3;

	private ElementStyle elementStyle_4;

	private bool bool_0 = true;

	private CellImages cellImages_0;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private Rectangle rectangle_2 = Rectangle.Empty;

	private Rectangle rectangle_3 = Rectangle.Empty;

	private Rectangle rectangle_4 = Rectangle.Empty;

	private object object_0;

	private string string_0 = "";

	private eCellPartAlignment eCellPartAlignment_0;

	private eCellPartAlignment eCellPartAlignment_1;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private Node node_0;

	private bool bool_6 = true;

	private eTreeAction eTreeAction_0 = eTreeAction.Code;

	private eCellPartLayout eCellPartLayout_0;

	private Cursor cursor_0;

	private bool bool_7;

	private string string_1 = "";

	private Control control_0;

	private Size size_0 = Size.Empty;

	private bool bool_8;

	private bool bool_9 = true;

	private bool bool_10;

	private CheckState checkState_0;

	private eCheckBoxStyle eCheckBoxStyle_0;

	private eCellEditorType eCellEditorType_0;

	private bool bool_11;

	private Class261 class261_0;

	[DefaultValue(true)]
	[Description("Indicates whether cell content is editable when cell editing is enabled on tree control.")]
	[Category("Behavior")]
	public bool Editable
	{
		get
		{
			return bool_9;
		}
		set
		{
			bool_9 = value;
		}
	}

	[Browsable(false)]
	public bool IsEditable
	{
		get
		{
			ColumnHeader columnHeader = Class15.smethod_45(TreeControl, this);
			if (columnHeader == null)
			{
				return bool_9;
			}
			if (bool_9)
			{
				return columnHeader.Editable;
			}
			return false;
		}
	}

	[DefaultValue(null)]
	[Description("Indicates control hosted inside of the cell.")]
	[Browsable(true)]
	[Category("Behavior")]
	public Control HostedControl
	{
		get
		{
			return control_0;
		}
		set
		{
			SetHostedControl(value);
		}
	}

	internal bool IgnoreHostedControlSizeChange
	{
		get
		{
			return bool_8;
		}
		set
		{
			bool_8 = value;
		}
	}

	internal Size HostedControlSize
	{
		get
		{
			return size_0;
		}
		set
		{
			size_0 = value;
		}
	}

	[Category("Design")]
	[Browsable(false)]
	[Description("Indicates the name used to identify cell.")]
	public string Name
	{
		get
		{
			if (Site != null)
			{
				string_1 = Site!.Name;
			}
			return string_1;
		}
		set
		{
			if (Site != null)
			{
				Site!.Name = value;
			}
			if (value == null)
			{
				string_1 = "";
			}
			else
			{
				string_1 = value;
			}
		}
	}

	[Browsable(false)]
	internal Rectangle BoundsRelative => rectangle_0;

	[Browsable(false)]
	public Rectangle Bounds
	{
		get
		{
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				return NodeDisplay.smethod_2(Enum5.const_3, this, treeControl.NodeDisplay_0.Offset);
			}
			return Rectangle.Empty;
		}
	}

	internal Rectangle TextContentBounds
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

	[Browsable(false)]
	public Rectangle TextBounds
	{
		get
		{
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				return NodeDisplay.smethod_2(Enum5.const_2, this, treeControl.NodeDisplay_0.Offset);
			}
			return Rectangle.Empty;
		}
	}

	[Browsable(false)]
	internal Rectangle ImageBoundsRelative => rectangle_3;

	[Browsable(false)]
	public Rectangle ImageBounds
	{
		get
		{
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				return NodeDisplay.smethod_2(Enum5.const_1, this, treeControl.NodeDisplay_0.Offset);
			}
			return Rectangle.Empty;
		}
	}

	[Browsable(false)]
	internal Rectangle CheckBoxBoundsRelative => rectangle_4;

	[Browsable(false)]
	public Rectangle CheckBoxBounds
	{
		get
		{
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				NodeDisplay.smethod_2(Enum5.const_0, this, treeControl.NodeDisplay_0.Offset);
			}
			return Rectangle.Empty;
		}
	}

	[Browsable(false)]
	public bool IsEditing => false;

	[Browsable(false)]
	public bool IsSelected => bool_5;

	[Browsable(false)]
	public bool IsVisible => bool_6;

	[Browsable(false)]
	public Node Parent => node_0;

	[Category("Data")]
	[Browsable(false)]
	[DefaultValue(null)]
	[Description("Indicates text that contains data about the cell.")]
	public object Tag
	{
		get
		{
			return object_0;
		}
		set
		{
			object_0 = value;
		}
	}

	[Description("Indicates text that contains data about the cell.")]
	[DevCoSerialize]
	[DefaultValue("")]
	[Browsable(true)]
	[Category("Data")]
	public string TagString
	{
		get
		{
			if (object_0 == null)
			{
				return "";
			}
			return object_0.ToString();
		}
		set
		{
			object_0 = value;
		}
	}

	[Description("Indicates text displayed in the cell.")]
	[Category("Appearance")]
	[Localizable(true)]
	[DevCoSerialize]
	[DefaultValue("")]
	[Browsable(true)]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	public string Text
	{
		get
		{
			return string_0;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			if (string_0 != value)
			{
				string_0 = value;
				OnTextChanged();
				OnSizeChanged();
			}
		}
	}

	[Browsable(false)]
	public AdvTree TreeControl
	{
		get
		{
			if (Parent != null)
			{
				return Parent.TreeControl;
			}
			return null;
		}
	}

	[DefaultValue(null)]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[Description("Indicates the style class assigned to the cell.")]
	[Category("Style")]
	public ElementStyle StyleNormal
	{
		get
		{
			return elementStyle_0;
		}
		set
		{
			elementStyle_0 = value;
		}
	}

	[DevCoSerialize]
	[Browsable(false)]
	[DefaultValue("")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string StyleNormalName
	{
		get
		{
			if (elementStyle_0 != null)
			{
				return elementStyle_0.Name;
			}
			return "";
		}
		set
		{
			if (value.Length == 0)
			{
				TypeDescriptor.GetProperties(this)["StyleNormal"]!.SetValue(this, null);
				return;
			}
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				TypeDescriptor.GetProperties(this)["StyleNormal"]!.SetValue(this, treeControl.Styles[value]);
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(null)]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Category("Style")]
	[Description("Indicates the style class assigned to the cell.")]
	public ElementStyle StyleSelected
	{
		get
		{
			return elementStyle_4;
		}
		set
		{
			elementStyle_4 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoSerialize]
	[Browsable(false)]
	[DefaultValue("")]
	public string StyleSelectedName
	{
		get
		{
			if (elementStyle_4 != null)
			{
				return elementStyle_4.Name;
			}
			return "";
		}
		set
		{
			if (value.Length == 0)
			{
				TypeDescriptor.GetProperties(this)["StyleSelected"]!.SetValue(this, null);
				return;
			}
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				TypeDescriptor.GetProperties(this)["StyleSelected"]!.SetValue(this, treeControl.Styles[value]);
			}
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[Description("Indicates the disabled style class assigned to the cell.")]
	[DefaultValue(null)]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	public ElementStyle StyleDisabled
	{
		get
		{
			return elementStyle_1;
		}
		set
		{
			elementStyle_1 = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoSerialize]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue("")]
	[Browsable(false)]
	public string StyleDisabledName
	{
		get
		{
			if (elementStyle_1 != null)
			{
				return elementStyle_1.Name;
			}
			return "";
		}
		set
		{
			if (value.Length == 0)
			{
				TypeDescriptor.GetProperties(this)["StyleDisabled"]!.SetValue(this, null);
				return;
			}
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				TypeDescriptor.GetProperties(this)["StyleDisabled"]!.SetValue(this, treeControl.Styles[value]);
			}
		}
	}

	[Category("Style")]
	[Description("Indicates the style class assigned to the cell when mouse is down.")]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[DefaultValue(null)]
	public ElementStyle StyleMouseDown
	{
		get
		{
			return elementStyle_2;
		}
		set
		{
			elementStyle_2 = value;
		}
	}

	[DevCoSerialize]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DefaultValue("")]
	[Browsable(false)]
	public string StyleMouseDownName
	{
		get
		{
			if (elementStyle_2 != null)
			{
				return elementStyle_2.Name;
			}
			return "";
		}
		set
		{
			if (value.Length == 0)
			{
				TypeDescriptor.GetProperties(this)["StyleMouseDown"]!.SetValue(this, null);
				return;
			}
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				TypeDescriptor.GetProperties(this)["StyleMouseDown"]!.SetValue(this, treeControl.Styles[value]);
			}
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[DefaultValue("")]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Description("Indicates the style class assigned to the cell when mouse is over the cell.")]
	public ElementStyle StyleMouseOver
	{
		get
		{
			return elementStyle_3;
		}
		set
		{
			elementStyle_3 = value;
		}
	}

	[Browsable(false)]
	[DevCoSerialize]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue("")]
	public string StyleMouseOverName
	{
		get
		{
			if (elementStyle_3 != null)
			{
				return elementStyle_3.Name;
			}
			return "";
		}
		set
		{
			if (value.Length == 0)
			{
				TypeDescriptor.GetProperties(this)["StyleMouseOver"]!.SetValue(this, null);
				return;
			}
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				TypeDescriptor.GetProperties(this)["StyleMouseOver"]!.SetValue(this, treeControl.Styles[value]);
			}
		}
	}

	[Description("Gets or sets whether cell is enabled or not.")]
	[DevCoSerialize]
	[Category("Behavior")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool Enabled
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			if (Parent != null)
			{
				Parent.OnDisplayChanged();
			}
		}
	}

	[Description("Gets the reference to images associated with this cell.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	[Category("Images")]
	public CellImages Images => cellImages_0;

	[DefaultValue(eCellPartAlignment.NearCenter)]
	[Category("Image Properties")]
	[DevCoSerialize]
	[Description("Gets or sets the image alignment in relation to the text displayed by cell.")]
	[Browsable(true)]
	public eCellPartAlignment ImageAlignment
	{
		get
		{
			return eCellPartAlignment_0;
		}
		set
		{
			if (eCellPartAlignment_0 != value)
			{
				eCellPartAlignment_0 = value;
				OnAppearanceChanged();
			}
		}
	}

	[Description("Indicates checkbox alignment in relation to the text displayed by cell.")]
	[DefaultValue(eCellPartAlignment.NearCenter)]
	[Browsable(true)]
	[Category("Check-box Properties")]
	public eCellPartAlignment CheckBoxAlignment
	{
		get
		{
			return eCellPartAlignment_1;
		}
		set
		{
			if (eCellPartAlignment_1 != value)
			{
				eCellPartAlignment_1 = value;
				OnAppearanceChanged();
			}
		}
	}

	[DefaultValue(false)]
	[DevCoSerialize]
	[Description("Indicates whether check box is visible inside the cell.")]
	[Category("Check-box Properties")]
	[Browsable(true)]
	public bool CheckBoxVisible
	{
		get
		{
			return bool_1;
		}
		set
		{
			if (bool_1 != value)
			{
				bool_1 = value;
				OnAppearanceChanged();
			}
		}
	}

	[Category("Check-box Properties")]
	[Description("Indicates whether the check box is in the checked state.")]
	[DevCoSerialize]
	[Browsable(true)]
	[DefaultValue(false)]
	public bool Checked
	{
		get
		{
			return bool_2;
		}
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if (bool_2 != value && (!bool_10 || !value || (int)checkState_0 == 0))
			{
				SetChecked((CheckState)(value ? 1 : 0), eTreeAction.Code);
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates whether the CheckBox will allow three check states rather than two.")]
	[DefaultValue(false)]
	[Category("Check-box Properties")]
	public bool CheckBoxThreeState
	{
		get
		{
			return bool_10;
		}
		set
		{
			bool_10 = value;
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Category("Check-box Properties")]
	[Description("Specifies the state of a control, such as a check box, that can be checked, unchecked, or set to an indeterminate state")]
	[Browsable(true)]
	public CheckState CheckState
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return checkState_0;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			if (value != checkState_0)
			{
				SetChecked(value, eTreeAction.Code);
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(eCheckBoxStyle.CheckBox)]
	[Description("Indicates appearance style of the item. Default value is CheckBox. Item can also assume the style of radio-button.")]
	[Category("Check-box Properties")]
	public eCheckBoxStyle CheckBoxStyle
	{
		get
		{
			return eCheckBoxStyle_0;
		}
		set
		{
			eCheckBoxStyle_0 = value;
			OnAppearanceChanged();
		}
	}

	[Browsable(false)]
	public bool IsMouseOver => bool_4;

	[Browsable(false)]
	public bool IsMouseDown => bool_3;

	[DevCoSerialize]
	[Browsable(true)]
	[Description("Indicates the layout of the cell parts like check box, image and text.")]
	[DefaultValue(eCellPartLayout.Default)]
	[Category("Cells")]
	public eCellPartLayout Layout
	{
		get
		{
			return eCellPartLayout_0;
		}
		set
		{
			if (eCellPartLayout_0 != value)
			{
				eCellPartLayout_0 = value;
				OnAppearanceChanged();
			}
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[Description("Specifies the mouse cursor displayed when mouse is over the cell.")]
	[DefaultValue(null)]
	public Cursor Cursor
	{
		get
		{
			return cursor_0;
		}
		set
		{
			if (cursor_0 != value)
			{
				cursor_0 = value;
			}
		}
	}

	internal bool WordWrap
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
		}
	}

	[Description("Indicates editor type used to edit the cell.")]
	[DefaultValue(eCellEditorType.Default)]
	[Category("Behavior")]
	public eCellEditorType EditorType
	{
		get
		{
			return eCellEditorType_0;
		}
		set
		{
			eCellEditorType_0 = value;
		}
	}

	internal Class261 TextMarkupBody => class261_0;

	protected virtual bool IsMarkupSupported => true;

	public Cell()
		: this("")
	{
	}

	public Cell(string text)
	{
		Text = text;
		cellImages_0 = new CellImages(this);
	}

	protected override void Dispose(bool disposing)
	{
		if (control_0 != null)
		{
			control_0.remove_SizeChanged((EventHandler)HostedControlSizedChanged);
		}
		control_0 = null;
		if (cellImages_0 != null)
		{
			cellImages_0.method_1();
		}
		base.Dispose(disposing);
	}

	internal void SetBounds(Rectangle bounds)
	{
		rectangle_0 = bounds;
	}

	internal void SetImageBounds(Rectangle bounds)
	{
		rectangle_3 = bounds;
	}

	internal void SetCheckBoxBounds(Rectangle bounds)
	{
		rectangle_4 = bounds;
	}

	internal void SetSelected(bool selected)
	{
		bool_5 = selected;
	}

	internal void SetVisible(bool visible)
	{
		if (bool_6 != visible)
		{
			bool_6 = visible;
			OnVisibleChanged();
		}
	}

	internal void SetParent(Node parent)
	{
		node_0 = parent;
	}

	protected virtual void OnTextChanged()
	{
		MarkupTextChanged();
	}

	internal void SetCellImages(CellImages ci)
	{
		cellImages_0 = ci;
		cellImages_0.Parent = this;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal bool ShouldSerializeImages()
	{
		return cellImages_0.Boolean_0;
	}

	public void SetChecked(bool value, eTreeAction actionSource)
	{
		SetChecked((CheckState)(value ? 1 : 0), actionSource);
	}

	public void SetChecked(CheckState value, eTreeAction actionSource)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		AdvTreeCellBeforeCheckEventArgs advTreeCellBeforeCheckEventArgs = new AdvTreeCellBeforeCheckEventArgs(actionSource, this, value);
		InvokeBeforeCheck(advTreeCellBeforeCheckEventArgs);
		if (advTreeCellBeforeCheckEventArgs.Cancel)
		{
			return;
		}
		checkState_0 = value;
		bool_2 = (int)value == 1;
		OnAppearanceChanged();
		if (CheckBoxStyle == eCheckBoxStyle.RadioButton && (int)value == 1 && Parent != null)
		{
			Node parent = Parent;
			AdvTree treeControl = parent.TreeControl;
			treeControl?.BeginUpdate();
			bool flag = true;
			foreach (Cell cell in parent.Cells)
			{
				if (cell != this && cell.CheckBoxStyle == eCheckBoxStyle.RadioButton)
				{
					cell.Checked = false;
					flag = false;
				}
			}
			if (flag)
			{
				if (parent.Parent != null)
				{
					foreach (Node node3 in parent.Parent.Nodes)
					{
						if (node3 != parent && node3.CheckBoxStyle == eCheckBoxStyle.RadioButton)
						{
							node3.Checked = false;
						}
					}
				}
				else if (treeControl != null && Class15.smethod_17(treeControl, parent))
				{
					foreach (Node node4 in treeControl.Nodes)
					{
						if (node4 != parent && node4.CheckBoxStyle == eCheckBoxStyle.RadioButton)
						{
							node4.Checked = false;
						}
					}
				}
			}
			treeControl?.EndUpdate();
		}
		InvokeAfterCheck(actionSource);
	}

	internal void SetMouseOver(bool over)
	{
		bool_4 = over;
	}

	internal void SetMouseDown(bool over)
	{
		bool_3 = over;
	}

	internal bool GetEnabled()
	{
		return bool_0;
	}

	internal eCellEditorType GetEffectiveEditorType()
	{
		if (eCellEditorType_0 != 0)
		{
			return eCellEditorType_0;
		}
		int num = -1;
		if (Parent != null)
		{
			num = Parent.Cells.IndexOf(this);
		}
		if (num == -1)
		{
			return eCellEditorType_0;
		}
		if (Parent != null && Parent.Parent != null && Parent.Parent.NodesColumns.Count > 0 && num < Parent.Parent.NodesColumns.Count)
		{
			return Parent.Parent.NodesColumns[num].EditorType;
		}
		AdvTree treeControl = TreeControl;
		if (treeControl != null && treeControl.Columns.Count > 0 && num < treeControl.Columns.Count)
		{
			return treeControl.Columns[num].EditorType;
		}
		return eCellEditorType_0;
	}

	public virtual Cell Copy()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		Cell cell = new Cell();
		cell.CheckBoxAlignment = CheckBoxAlignment;
		cell.CheckBoxVisible = CheckBoxVisible;
		cell.CheckBoxStyle = CheckBoxStyle;
		if (CheckBoxThreeState)
		{
			cell.CheckState = CheckState;
		}
		else
		{
			cell.Checked = Checked;
		}
		cell.Cursor = Cursor;
		cell.Enabled = Enabled;
		cell.ImageAlignment = ImageAlignment;
		cell.SetCellImages(Images.Copy());
		cell.Layout = Layout;
		cell.StyleDisabled = StyleDisabled;
		cell.StyleMouseDown = StyleMouseDown;
		cell.StyleMouseOver = StyleMouseOver;
		cell.StyleNormal = StyleNormal;
		cell.StyleSelected = StyleSelected;
		cell.Tag = Tag;
		cell.Text = Text;
		return cell;
	}

	private void OnAppearanceChanged()
	{
		if (Parent != null)
		{
			Parent.SizeChanged = true;
			Parent.OnDisplayChanged();
		}
	}

	private void OnSizeChanged()
	{
		if (Parent != null)
		{
			Parent.SizeChanged = true;
			Parent.OnDisplayChanged();
		}
	}

	internal void OnImageChanged()
	{
		if (node_0 != null)
		{
			node_0.OnImageChanged();
		}
	}

	protected virtual void InvokeAfterCheck(eTreeAction actionSource)
	{
		TreeControl?.method_57(new AdvTreeCellEventArgs(actionSource, this));
		eTreeAction_0 = eTreeAction.Code;
	}

	protected virtual void InvokeBeforeCheck(AdvTreeCellBeforeCheckEventArgs e)
	{
		TreeControl?.method_56(e);
	}

	internal void OnLayoutCell()
	{
		if (control_0 != null && !bool_11)
		{
			AddHostedControlToTree();
		}
	}

	internal void AddHostedControlToTree()
	{
		if (bool_11)
		{
			return;
		}
		AdvTree treeControl = TreeControl;
		if (treeControl == null)
		{
			return;
		}
		if (control_0.get_Parent() != treeControl)
		{
			if (control_0.get_Parent() != null)
			{
				control_0.get_Parent().get_Controls().Remove(control_0);
			}
			((Control)treeControl).get_Controls().Add(control_0);
			control_0.SendToBack();
		}
		treeControl.ArrayList_1.Add(this);
		bool_11 = true;
	}

	internal void RemoveHostedControlFromTree()
	{
		if (control_0.get_Parent() is AdvTree advTree)
		{
			((Control)advTree).get_Controls().Remove(control_0);
			advTree.ArrayList_1.Remove(this);
			bool_11 = false;
		}
	}

	private void SetHostedControl(Control value)
	{
		if (value == TreeControl)
		{
			return;
		}
		if (control_0 != null)
		{
			control_0.remove_SizeChanged((EventHandler)HostedControlSizedChanged);
			control_0.remove_Enter((EventHandler)HostedControlEnter);
			RemoveHostedControlFromTree();
		}
		control_0 = value;
		if (control_0 != null)
		{
			control_0.add_SizeChanged((EventHandler)HostedControlSizedChanged);
			control_0.add_Enter((EventHandler)HostedControlEnter);
			TypeDescriptor.GetProperties(control_0)["Dock"]!.SetValue(control_0, (object)(DockStyle)0);
			if (control_0.get_Parent() != null)
			{
				control_0.get_Parent().get_Controls().Remove(control_0);
			}
			if (!base.DesignMode)
			{
				control_0.set_Visible(false);
			}
			if (base.DesignMode || (Parent != null && Parent.Site != null && Parent.Site!.DesignMode))
			{
				bool visible = GetVisible();
				TypeDescriptor.GetProperties(control_0)["Visible"]!.SetValue(control_0, visible);
			}
			AddHostedControlToTree();
		}
		OnSizeChanged();
	}

	private void HostedControlEnter(object sender, EventArgs e)
	{
		AdvTree treeControl = TreeControl;
		if (treeControl != null)
		{
			treeControl.SelectedNode = Parent;
		}
	}

	private void HostedControlSizedChanged(object sender, EventArgs e)
	{
		if (!bool_8)
		{
			if (!size_0.IsEmpty && control_0 != null)
			{
				size_0 = control_0.get_Size();
			}
			OnSizeChanged();
		}
	}

	internal void OnVisibleChanged()
	{
		if (control_0 != null)
		{
			TypeDescriptor.GetProperties(control_0)["Visible"]!.SetValue(control_0, GetVisible());
		}
	}

	private bool GetVisible()
	{
		if (node_0 != null && !Class15.smethod_11(node_0))
		{
			return false;
		}
		return bool_6;
	}

	internal void OnParentExpandedChanged(bool expanded)
	{
		if (control_0 != null && control_0.get_Visible() != expanded)
		{
			bool visible = GetVisible();
			control_0.set_Visible(visible);
			if (base.DesignMode || (Parent != null && Parent.Site != null && Parent.Site!.DesignMode))
			{
				TypeDescriptor.GetProperties(control_0)["Visible"]!.SetValue(control_0, visible);
			}
		}
	}

	private void MarkupTextChanged()
	{
		if (!IsMarkupSupported)
		{
			return;
		}
		if (class261_0 != null)
		{
			class261_0.Event_0 -= TextMarkupLinkClick;
		}
		class261_0 = null;
		if (Class243.smethod_2(ref string_0))
		{
			class261_0 = Class243.smethod_0(string_0);
			if (class261_0 != null)
			{
				class261_0.Event_0 += TextMarkupLinkClick;
			}
		}
	}

	protected virtual void TextMarkupLinkClick(object sender, EventArgs e)
	{
		if (sender is Class262 @class && Parent != null)
		{
			Parent.InvokeMarkupLinkClick(this, new MarkupLinkClickEventArgs(@class.String_1, @class.String_0));
		}
	}

	protected internal virtual void InvokeNodeMouseMove(object sender, MouseEventArgs e)
	{
		if (class261_0 != null)
		{
			class261_0.method_5((Control)((sender is Control) ? sender : null), e);
		}
	}

	protected internal virtual void InvokeNodeMouseDown(object sender, MouseEventArgs e)
	{
		if (class261_0 != null)
		{
			class261_0.method_6((Control)((sender is Control) ? sender : null), e);
		}
	}

	protected internal virtual void InvokeNodeMouseUp(object sender, MouseEventArgs e)
	{
		if (class261_0 != null)
		{
			class261_0.method_7((Control)((sender is Control) ? sender : null), e);
		}
	}

	protected internal virtual void InvokeNodeMouseLeave(object sender, EventArgs e)
	{
		if (class261_0 != null)
		{
			class261_0.method_4((Control)((sender is Control) ? sender : null));
		}
	}

	protected internal virtual void InvokeNodeClick(object sender, EventArgs e)
	{
		if (class261_0 != null)
		{
			class261_0.method_8((Control)((sender is Control) ? sender : null));
		}
	}
}
