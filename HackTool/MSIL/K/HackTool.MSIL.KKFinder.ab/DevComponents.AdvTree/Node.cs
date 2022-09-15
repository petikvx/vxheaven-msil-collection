using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree.Design;
using DevComponents.AdvTree.Display;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Design;

namespace DevComponents.AdvTree;

[ToolboxItem(false)]
[Designer(typeof(NodeDesigner))]
[DesignTimeVisible(false)]
public class Node : Component, IComparable
{
	private MouseEventHandler mouseEventHandler_0;

	private MouseEventHandler mouseEventHandler_1;

	private MouseEventHandler mouseEventHandler_2;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private EventHandler eventHandler_3;

	private EventHandler eventHandler_4;

	private MarkupLinkClickEventHandler markupLinkClickEventHandler_0;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private Rectangle rectangle_2 = Rectangle.Empty;

	private Rectangle rectangle_3 = Rectangle.Empty;

	private Rectangle rectangle_4 = Rectangle.Empty;

	private NodeCollection nodeCollection_0;

	private CellCollection cellCollection_0 = new CellCollection();

	private ColumnHeaderCollection columnHeaderCollection_0;

	private object object_0;

	private object object_1;

	private string string_0 = "";

	private bool bool_0;

	private eNodeExpandVisibility eNodeExpandVisibility_0;

	private Rectangle rectangle_5 = Rectangle.Empty;

	private Node node_0;

	private ElementStyle elementStyle_0;

	private ElementStyle elementStyle_1;

	private ElementStyle elementStyle_2;

	private bool bool_1 = true;

	private int int_0;

	private eMapPosition eMapPosition_0;

	private int int_1;

	internal AdvTree advTree_0;

	private ElementStyle elementStyle_3;

	private Enum1 enum1_0;

	private NodeConnector nodeConnector_0;

	private eCellLayout eCellLayout_0;

	private bool bool_2 = true;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5 = true;

	private string string_1 = "";

	private ConnectorPointsCollection connectorPointsCollection_0;

	private bool bool_6;

	private eNodeRenderMode eNodeRenderMode_0;

	private TreeRenderer treeRenderer_0;

	private object object_2;

	private bool bool_7 = true;

	private int int_2 = -1;

	private bool bool_8 = true;

	private bool bool_9 = true;

	private bool bool_10;

	private bool bool_11;

	private string string_2 = "";

	private string string_3 = "";

	private string string_4 = "";

	private AccessibleRole accessibleRole_0 = (AccessibleRole)36;

	private bool bool_12 = true;

	[Browsable(false)]
	public bool HasChildNodes
	{
		get
		{
			if (nodeCollection_0 != null)
			{
				return nodeCollection_0.Count > 0;
			}
			return false;
		}
	}

	[Editor(typeof(NodeContextMenuTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[DefaultValue(null)]
	[Description("Indicates the context menu assigned to this node.")]
	public object ContextMenu
	{
		get
		{
			return object_2;
		}
		set
		{
			object_2 = value;
		}
	}

	[Browsable(false)]
	public bool HasHostedControls
	{
		get
		{
			foreach (Cell item in cellCollection_0)
			{
				if (item.HostedControl != null)
				{
					return true;
				}
			}
			return false;
		}
	}

	[Description("Indicates render mode used to render the node.")]
	[DefaultValue(null)]
	[Category("Style")]
	[Browsable(false)]
	internal TreeRenderer NodeRenderer
	{
		get
		{
			return treeRenderer_0;
		}
		set
		{
			treeRenderer_0 = value;
			OnDisplayChanged();
		}
	}

	[Category("Style")]
	[Description("Indicates render mode used to render the node.")]
	[Browsable(true)]
	[DefaultValue(eNodeRenderMode.Default)]
	internal eNodeRenderMode RenderMode
	{
		get
		{
			return eNodeRenderMode_0;
		}
		set
		{
			eNodeRenderMode_0 = value;
			OnDisplayChanged();
		}
	}

	[Description("Indicates whether node is expanded.")]
	[Category("Node State")]
	[Browsable(true)]
	[DevCoSerialize]
	[DefaultValue(false)]
	public bool Expanded
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (value)
			{
				Expand();
			}
			else
			{
				Collapse();
			}
		}
	}

	[Description("Indicates the name used to identify node.")]
	[Category("Design")]
	[DevCoSerialize]
	[Browsable(false)]
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

	[Browsable(true)]
	[DefaultValue(true)]
	[Category("Behavior")]
	[Description("Indicates whether node can be dragged and dropped.")]
	[DevCoSerialize]
	public bool DragDropEnabled
	{
		get
		{
			return bool_5;
		}
		set
		{
			bool_5 = value;
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(eNodeExpandVisibility.Auto)]
	[Description("Indicates whether the expand button is always visible regardless of whether node contains child nodes or not.")]
	[DevCoSerialize]
	public eNodeExpandVisibility ExpandVisibility
	{
		get
		{
			return eNodeExpandVisibility_0;
		}
		set
		{
			eNodeExpandVisibility_0 = value;
			SizeChanged = true;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool SizeChanged
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			OnSizeChanged();
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
				return NodeDisplay.smethod_0(Enum4.const_0, this, treeControl.NodeDisplay_0.Offset);
			}
			return Rectangle.Empty;
		}
	}

	internal Rectangle ContentBounds => rectangle_3;

	[Browsable(false)]
	internal Rectangle CellsBoundsRelative => rectangle_2;

	[Browsable(false)]
	public Rectangle CellsBounds
	{
		get
		{
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				return NodeDisplay.smethod_0(Enum4.const_4, this, treeControl.NodeDisplay_0.Offset);
			}
			return Rectangle.Empty;
		}
	}

	internal Rectangle ChildNodesBounds
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

	[Browsable(false)]
	internal Rectangle ExpandPartRectangleRelative => rectangle_5;

	[Browsable(false)]
	public Rectangle ExpandPartRectangle
	{
		get
		{
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				return NodeDisplay.smethod_0(Enum4.const_1, this, treeControl.NodeDisplay_0.Offset);
			}
			return Rectangle.Empty;
		}
	}

	[Browsable(false)]
	internal Rectangle CommandBounds
	{
		get
		{
			if (!rectangle_4.IsEmpty)
			{
				AdvTree treeControl = TreeControl;
				if (treeControl != null)
				{
					return NodeDisplay.smethod_0(Enum4.const_6, this, treeControl.NodeDisplay_0.Offset);
				}
			}
			return Rectangle.Empty;
		}
	}

	internal Rectangle CommandBoundsRelative
	{
		get
		{
			return rectangle_4;
		}
		set
		{
			rectangle_4 = value;
		}
	}

	[DevCoSerialize]
	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Indicates whether the tree node is in a checked state.")]
	[Category("Appearance")]
	public bool Checked
	{
		get
		{
			return cellCollection_0[0].Checked;
		}
		set
		{
			cellCollection_0[0].Checked = value;
		}
	}

	[Category("Check-box Properties")]
	[DefaultValue(eCellPartAlignment.NearCenter)]
	[Description("Indicates checkbox alignment in relation to the text displayed by cell.")]
	[Browsable(true)]
	[DevCoSerialize]
	public eCellPartAlignment CheckBoxAlignment
	{
		get
		{
			return cellCollection_0[0].CheckBoxAlignment;
		}
		set
		{
			cellCollection_0[0].CheckBoxAlignment = value;
		}
	}

	[Browsable(true)]
	[DevCoSerialize]
	[Category("Check-box Properties")]
	[Description("Indicates whether check box is visible inside the cell.")]
	[DefaultValue(false)]
	public bool CheckBoxVisible
	{
		get
		{
			return cellCollection_0[0].CheckBoxVisible;
		}
		set
		{
			cellCollection_0[0].CheckBoxVisible = value;
		}
	}

	[Category("Check-box Properties")]
	[DefaultValue(eCheckBoxStyle.CheckBox)]
	[Description("Indicates appearance style of the item. Default value is CheckBox. Item can also assume the style of radio-button.")]
	[Browsable(true)]
	public eCheckBoxStyle CheckBoxStyle
	{
		get
		{
			return cellCollection_0[0].CheckBoxStyle;
		}
		set
		{
			cellCollection_0[0].CheckBoxStyle = value;
		}
	}

	[Category("Check-box Properties")]
	[DefaultValue(false)]
	[Description("Indicates whether the CheckBox will allow three check states rather than two.")]
	[Browsable(true)]
	public bool CheckBoxThreeState
	{
		get
		{
			return cellCollection_0[0].CheckBoxThreeState;
		}
		set
		{
			cellCollection_0[0].CheckBoxThreeState = value;
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Check-box Properties")]
	[Description("Specifies the state of a control, such as a check box, that can be checked, unchecked, or set to an indeterminate state")]
	[Browsable(true)]
	public CheckState CheckState
	{
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return cellCollection_0[0].CheckState;
		}
		set
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			cellCollection_0[0].CheckState = value;
		}
	}

	[Category("Behavior")]
	[Description("Indicates whether first cell content is editable when cell editing is enabled on tree control.")]
	[DefaultValue(true)]
	public bool Editable
	{
		get
		{
			return cellCollection_0[0].Editable;
		}
		set
		{
			cellCollection_0[0].Editable = value;
		}
	}

	[Browsable(false)]
	public string FullPath
	{
		get
		{
			if (TreeControl == null)
			{
				return "";
			}
			return Class15.smethod_0(this, TreeControl.PathSeparator);
		}
	}

	[Browsable(false)]
	public int Index => Class15.smethod_13(this);

	[Browsable(false)]
	public bool IsEditing => bool_4;

	[Browsable(false)]
	public bool IsMouseDown
	{
		get
		{
			foreach (Cell cell in Cells)
			{
				if (cell.IsMouseDown)
				{
					return true;
				}
			}
			return false;
		}
	}

	[Browsable(false)]
	public bool IsMouseOver
	{
		get
		{
			foreach (Cell cell in Cells)
			{
				if (cell.IsMouseOver)
				{
					return true;
				}
			}
			return false;
		}
	}

	[Browsable(false)]
	public bool IsSelected
	{
		get
		{
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				if (treeControl.MultiSelect)
				{
					return treeControl.SelectedNodes.Contains(this);
				}
				if (treeControl.SelectedNode == this)
				{
					return true;
				}
			}
			return false;
		}
	}

	[Description("Indicates whether node can be selected by user by clicking it with the mouse or using keyboard.")]
	[Category("Behavior")]
	[DefaultValue(true)]
	public bool Selectable
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

	[Browsable(false)]
	public bool CanSelect => Enabled & Visible & Selectable;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Cell SelectedCell
	{
		get
		{
			if (IsSelected)
			{
				foreach (Cell item in cellCollection_0)
				{
					if (item.IsSelected)
					{
						return item;
					}
				}
			}
			return null;
		}
		set
		{
			AdvTree treeControl = TreeControl;
			if (!IsSelected && treeControl != null)
			{
				treeControl.SelectedNode = this;
			}
			foreach (Cell item in cellCollection_0)
			{
				if (item == value)
				{
					item.SetSelected(selected: true);
				}
				else
				{
					item.SetSelected(selected: false);
				}
			}
			treeControl?.method_7(this);
		}
	}

	[Browsable(false)]
	public bool IsVisible => Class15.smethod_11(this);

	[Browsable(false)]
	public bool IsDisplayed => Class15.smethod_12(this);

	[Browsable(false)]
	public Node LastNode => Class15.smethod_1(this);

	[Browsable(false)]
	public Node NextNode => Class15.smethod_7(this);

	[Browsable(false)]
	public Node NextVisibleNode => Class15.smethod_9(this);

	[Browsable(false)]
	public int Level
	{
		get
		{
			int num = 0;
			for (Node parent = Parent; parent != null; parent = parent.Parent)
			{
				num++;
			}
			return num;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	[Category("Nodes")]
	public NodeCollection Nodes
	{
		get
		{
			if (nodeCollection_0 == null)
			{
				nodeCollection_0 = new NodeCollection();
				nodeCollection_0.method_0(this);
			}
			return nodeCollection_0;
		}
	}

	[Browsable(false)]
	public bool AnyVisibleNodes => Class15.smethod_20(this);

	[Browsable(false)]
	public Node Parent => node_0;

	[Browsable(false)]
	public Node PrevNode => Class15.smethod_14(this);

	[Browsable(false)]
	public Node PrevVisibleNode => Class15.smethod_15(this);

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(null)]
	[Description("Indicates text that contains data about the tree node.")]
	[Category("Data")]
	public object Tag
	{
		get
		{
			return cellCollection_0[0].Tag;
		}
		set
		{
			cellCollection_0[0].Tag = value;
		}
	}

	[Category("Data")]
	[Browsable(true)]
	[DefaultValue("")]
	[DevCoSerialize]
	[Description("Indicates text that contains data about the tree node.")]
	public string TagString
	{
		get
		{
			return cellCollection_0[0].TagString;
		}
		set
		{
			cellCollection_0[0].TagString = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int BindingIndex
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	[Category("Data")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(null)]
	[Browsable(false)]
	[Description("Indicates text that contains data about the tree node.")]
	public object DataKey
	{
		get
		{
			return object_1;
		}
		set
		{
			object_1 = value;
		}
	}

	[DevCoSerialize]
	[Category("Data")]
	[DefaultValue("")]
	[Browsable(true)]
	[Description("Indicates text that contains data about the tree node.")]
	public string DataKeyString
	{
		get
		{
			if (object_1 == null)
			{
				return "";
			}
			return object_1.ToString();
		}
		set
		{
			object_1 = value;
		}
	}

	[DefaultValue("")]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Localizable(true)]
	[DevCoSerialize]
	[Description("Indicates text displayed in the tree node.")]
	[Browsable(true)]
	[Category("Appearance")]
	public string Text
	{
		get
		{
			return Cells[0].Text;
		}
		set
		{
			Cells[0].Text = value;
		}
	}

	[DefaultValue(null)]
	[Browsable(true)]
	[Description("Indicates control hosted inside of the cell.")]
	[Category("Behavior")]
	public Control HostedControl
	{
		get
		{
			return Cells[0].HostedControl;
		}
		set
		{
			Cells[0].HostedControl = value;
		}
	}

	[Browsable(false)]
	public AdvTree TreeControl => GetTreeControl();

	[DevCoSerialize]
	[Description("Indicates layout of the cells inside the node.")]
	[DefaultValue(eCellLayout.Default)]
	[Category("Cells")]
	[Browsable(true)]
	public eCellLayout CellLayout
	{
		get
		{
			return eCellLayout_0;
		}
		set
		{
			eCellLayout_0 = value;
			SizeChanged = true;
		}
	}

	[DevCoSerialize]
	[Browsable(true)]
	[Description("Indicates the layout of the cell parts like check box, image and text.")]
	[Category("Cells")]
	[DefaultValue(eCellPartLayout.Default)]
	public eCellPartLayout CellPartLayout
	{
		get
		{
			return cellCollection_0[0].Layout;
		}
		set
		{
			if (cellCollection_0[0].Layout != value)
			{
				cellCollection_0[0].Layout = value;
			}
		}
	}

	[Description("Collection of Cells assigned to this node.")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Cells")]
	public CellCollection Cells => cellCollection_0;

	[DefaultValue(true)]
	[Category("Columns")]
	[Description("Indicates whether column header for child nodes if defined is visible.")]
	public bool NodesColumnsHeaderVisible
	{
		get
		{
			return bool_8;
		}
		set
		{
			bool_8 = value;
			SizeChanged = true;
			OnDisplayChanged();
		}
	}

	[Browsable(false)]
	public bool HasColumns
	{
		get
		{
			if (columnHeaderCollection_0 != null && columnHeaderCollection_0.Count > 0)
			{
				return true;
			}
			return false;
		}
	}

	[Description("Defines the columns for the child nodes.")]
	[Category("Columns")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ColumnHeaderCollection NodesColumns
	{
		get
		{
			if (columnHeaderCollection_0 == null)
			{
				columnHeaderCollection_0 = new ColumnHeaderCollection();
				columnHeaderCollection_0.method_0(this);
			}
			return columnHeaderCollection_0;
		}
	}

	[Description("Indicates the style for the child nodes when node is expanded.")]
	[DefaultValue(null)]
	[Category("Style")]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	public ElementStyle StyleExpanded
	{
		get
		{
			return elementStyle_0;
		}
		set
		{
			if (elementStyle_0 != value)
			{
				if (elementStyle_0 != null)
				{
					elementStyle_0.StyleChanged -= ElementStyleChanged;
				}
				if (value != null)
				{
					value.StyleChanged += ElementStyleChanged;
				}
				elementStyle_0 = value;
				if (Expanded)
				{
					SizeChanged = true;
				}
			}
		}
	}

	[Browsable(false)]
	[DevCoSerialize]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue("")]
	public string StyleExpandedName
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
				TypeDescriptor.GetProperties(this)["StyleExpanded"]!.SetValue(this, null);
				return;
			}
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				TypeDescriptor.GetProperties(this)["StyleExpanded"]!.SetValue(this, treeControl.Styles[value]);
			}
		}
	}

	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[Description("Indicates the style for the nodes when node is selected.")]
	[DefaultValue(null)]
	[Category("Style")]
	public ElementStyle StyleSelected
	{
		get
		{
			return elementStyle_1;
		}
		set
		{
			if (elementStyle_1 != value)
			{
				if (elementStyle_1 != null)
				{
					elementStyle_1.StyleChanged -= ElementStyleChanged;
				}
				if (value != null)
				{
					value.StyleChanged += ElementStyleChanged;
				}
				elementStyle_1 = value;
				if (IsSelected)
				{
					SizeChanged = true;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DefaultValue("")]
	[DevCoSerialize]
	public string StyleSelectedName
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

	[DefaultValue(null)]
	[Description("Indicates the style for the nodes when node is selected.")]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Category("Style")]
	[Browsable(true)]
	public ElementStyle StyleMouseOver
	{
		get
		{
			return elementStyle_2;
		}
		set
		{
			if (elementStyle_2 != value)
			{
				if (elementStyle_2 != null)
				{
					elementStyle_2.StyleChanged -= ElementStyleChanged;
				}
				if (value != null)
				{
					value.StyleChanged += ElementStyleChanged;
				}
				elementStyle_2 = value;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoSerialize]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue("")]
	public string StyleMouseOverName
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

	[Browsable(true)]
	[Description("Indicates the node style.")]
	[Category("Style")]
	[DefaultValue(null)]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	public ElementStyle Style
	{
		get
		{
			return elementStyle_3;
		}
		set
		{
			if (elementStyle_3 != value)
			{
				if (elementStyle_3 != null)
				{
					elementStyle_3.StyleChanged -= ElementStyleChanged;
				}
				if (value != null)
				{
					value.StyleChanged += ElementStyleChanged;
				}
				elementStyle_3 = value;
				SizeChanged = true;
				Invalidate();
			}
		}
	}

	[Browsable(false)]
	[DevCoSerialize]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue("")]
	public string StyleName
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
				TypeDescriptor.GetProperties(this)["Style"]!.SetValue(this, null);
				return;
			}
			AdvTree treeControl = TreeControl;
			if (treeControl != null)
			{
				TypeDescriptor.GetProperties(this)["Style"]!.SetValue(this, treeControl.Styles[value]);
			}
		}
	}

	internal Enum1 MouseOverNodePart
	{
		get
		{
			return enum1_0;
		}
		set
		{
			enum1_0 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(0)]
	[Browsable(false)]
	internal int Offset
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			SizeChanged = true;
		}
	}

	[Category("Image Properties")]
	[DevCoSerialize]
	[Description("Gets or sets the image alignment in relation to the text displayed by cell.")]
	[Browsable(true)]
	[DefaultValue(eCellPartAlignment.NearCenter)]
	public eCellPartAlignment ImageAlignment
	{
		get
		{
			return cellCollection_0[0].ImageAlignment;
		}
		set
		{
			if (cellCollection_0[0].ImageAlignment != value)
			{
				cellCollection_0[0].ImageAlignment = value;
			}
		}
	}

	[Category("Behavior")]
	[DefaultValue(true)]
	[Description("Gets or sets whether node is enabled.")]
	[DevCoSerialize]
	[Browsable(true)]
	public bool Enabled
	{
		get
		{
			return bool_9;
		}
		set
		{
			bool_9 = value;
			foreach (Cell item in cellCollection_0)
			{
				item.Enabled = bool_9;
			}
		}
	}

	[Browsable(true)]
	[Category("Images")]
	[DevCoSerialize]
	[DefaultValue(null)]
	[Description("Indicates image displayed when the tree node is disabled.")]
	public Image ImageDisabled
	{
		get
		{
			return cellCollection_0[0].Images.ImageDisabled;
		}
		set
		{
			SizeChanged = true;
			cellCollection_0[0].Images.ImageDisabled = value;
		}
	}

	[Description("Indicates the image-list index value of the disabled image")]
	[DevCoSerialize]
	[DefaultValue(-1)]
	[Browsable(true)]
	[TypeConverter(typeof(ImageIndexConverter))]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[Category("Images")]
	public int ImageDisabledIndex
	{
		get
		{
			return Cells[0].Images.ImageDisabledIndex;
		}
		set
		{
			SizeChanged = true;
			Cells[0].Images.ImageDisabledIndex = value;
		}
	}

	[DevCoSerialize]
	[Category("Images")]
	[DefaultValue(null)]
	[Description("Indicates image displayed when the tree node is in the unselected state.")]
	[Browsable(true)]
	public Image Image
	{
		get
		{
			return cellCollection_0[0].Images.Image;
		}
		set
		{
			SizeChanged = true;
			cellCollection_0[0].Images.Image = value;
		}
	}

	[Browsable(true)]
	[Description("Indicates the image-list index value of the default image that is displayed by the tree nodes.")]
	[DefaultValue(-1)]
	[TypeConverter(typeof(ImageIndexConverter))]
	[DevCoSerialize]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[Category("Images")]
	public int ImageIndex
	{
		get
		{
			return Cells[0].Images.ImageIndex;
		}
		set
		{
			SizeChanged = true;
			Cells[0].Images.ImageIndex = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(null)]
	[Category("Images")]
	[Description("Indicates the image displayed when mouse is over the tree node.")]
	[DevCoSerialize]
	public Image ImageMouseOver
	{
		get
		{
			return Cells[0].Images.ImageMouseOver;
		}
		set
		{
			Cells[0].Images.ImageMouseOver = value;
			SizeChanged = true;
		}
	}

	[Browsable(true)]
	[Description("Indicates the image-list index value of the image that is displayed by the tree nodes when mouse is over the node.")]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[DefaultValue(-1)]
	[DevCoSerialize]
	[Category("Images")]
	[TypeConverter(typeof(ImageIndexConverter))]
	public int ImageMouseOverIndex
	{
		get
		{
			return Cells[0].Images.ImageMouseOverIndex;
		}
		set
		{
			SizeChanged = true;
			Cells[0].Images.ImageMouseOverIndex = value;
		}
	}

	[Description("Indicates the image displayed when node is expanded.")]
	[DefaultValue(null)]
	[DevCoSerialize]
	[Browsable(true)]
	[Category("Images")]
	public Image ImageExpanded
	{
		get
		{
			return Cells[0].Images.ImageExpanded;
		}
		set
		{
			Cells[0].Images.ImageExpanded = value;
			SizeChanged = true;
		}
	}

	[DevCoSerialize]
	[Category("Images")]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[DefaultValue(-1)]
	[TypeConverter(typeof(ImageIndexConverter))]
	[Description("Indicates the image-list index value of the image that is displayed by the tree nodes when node is expanded.")]
	[Browsable(true)]
	public int ImageExpandedIndex
	{
		get
		{
			return Cells[0].Images.ImageExpandedIndex;
		}
		set
		{
			SizeChanged = true;
			Cells[0].Images.ImageExpandedIndex = value;
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ImageList ImageList => TreeControl?.ImageList;

	[Category("Connectors")]
	[DefaultValue(null)]
	[Description("Indicates the nested nodes connector.")]
	[Editor(typeof(NodeConnectorTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	internal NodeConnector ParentConnector
	{
		get
		{
			return nodeConnector_0;
		}
		set
		{
			if (nodeConnector_0 != value)
			{
				if (nodeConnector_0 != null)
				{
					nodeConnector_0.AppearanceChanged -= ConnectorAppearanceChanged;
				}
				if (value != null)
				{
					value.AppearanceChanged += ConnectorAppearanceChanged;
				}
				nodeConnector_0 = value;
				OnDisplayChanged();
			}
		}
	}

	[Category("Behavior")]
	[Description("Indicated whether node is visible")]
	[Browsable(true)]
	[DefaultValue(true)]
	[DevCoSerialize]
	public bool Visible
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			OnVisibleChanged();
			SizeChanged = true;
		}
	}

	[DevCoSerialize]
	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates visibility of command button.")]
	[Category("Command Button")]
	internal bool CommandButton
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			OnDisplayChanged();
		}
	}

	internal bool SelectedConnectorMarker
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
		}
	}

	[Browsable(false)]
	public bool IsDragNode
	{
		get
		{
			return bool_10;
		}
		internal set
		{
			if (bool_10 == value)
			{
				return;
			}
			bool_10 = value;
			if (nodeCollection_0 == null)
			{
				return;
			}
			foreach (Node node in Nodes)
			{
				node.IsDragNode = value;
			}
		}
	}

	[DefaultValue(false)]
	[Category("Appearance")]
	[Description("Indicates whether style background that is applied to the node is drawn across the width of the tree control instead of only behind the node content.")]
	public bool FullRowBackground
	{
		get
		{
			return bool_11;
		}
		set
		{
			if (bool_11 != value)
			{
				bool_11 = value;
				SizeChanged = true;
				Invalidate();
			}
		}
	}

	internal int ColumnHeaderHeight
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	internal bool FireHoverEvent => eventHandler_2 != null;

	[Browsable(false)]
	public virtual AccessibleObject AccessibleObject => CreateAccessibilityInstance();

	[Category("Accessibility")]
	[Description("Gets or sets the default action description of the control for use by accessibility client applications.")]
	[DefaultValue("")]
	[Browsable(true)]
	public virtual string AccessibleDefaultActionDescription
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
		}
	}

	[Browsable(true)]
	[Description("Gets or sets the description of the control used by accessibility client applications.")]
	[Category("Accessibility")]
	[DefaultValue("")]
	public virtual string AccessibleDescription
	{
		get
		{
			return string_3;
		}
		set
		{
			if (string_3 != value)
			{
				string_3 = value;
				GenerateAccessibilityEvent((AccessibleEvents)32781);
			}
		}
	}

	[Browsable(true)]
	[Description("Gets or sets the name of the control used by accessibility client applications.")]
	[DefaultValue("")]
	[Category("Accessibility")]
	public virtual string AccessibleName
	{
		get
		{
			return string_4;
		}
		set
		{
			if (string_4 != value)
			{
				string_4 = value;
				GenerateAccessibilityEvent((AccessibleEvents)32780);
			}
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(true)]
	[Description("Gets or sets the accessible role of the item.")]
	[Category("Accessibility")]
	public virtual AccessibleRole AccessibleRole
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return accessibleRole_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			accessibleRole_0 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual bool IsAccessible
	{
		get
		{
			return bool_12;
		}
		set
		{
			bool_12 = value;
		}
	}

	public event MouseEventHandler NodeMouseDown
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_0 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_0, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_0 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_0, (Delegate?)(object)value);
		}
	}

	public event MouseEventHandler NodeMouseUp
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_1 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_1, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_1 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_1, (Delegate?)(object)value);
		}
	}

	public event MouseEventHandler NodeMouseMove
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_2, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_2, (Delegate?)(object)value);
		}
	}

	public event EventHandler NodeMouseEnter
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

	public event EventHandler NodeMouseLeave
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

	public event EventHandler NodeMouseHover
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_2 = (EventHandler)Delegate.Combine(eventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_2 = (EventHandler)Delegate.Remove(eventHandler_2, value);
		}
	}

	public event EventHandler NodeClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_3 = (EventHandler)Delegate.Combine(eventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_3 = (EventHandler)Delegate.Remove(eventHandler_3, value);
		}
	}

	public event EventHandler NodeDoubleClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_4 = (EventHandler)Delegate.Combine(eventHandler_4, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_4 = (EventHandler)Delegate.Remove(eventHandler_4, value);
		}
	}

	public event MarkupLinkClickEventHandler MarkupLinkClick
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

	public Node()
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		cellCollection_0.method_1(this);
		connectorPointsCollection_0 = new ConnectorPointsCollection();
		connectorPointsCollection_0.method_0(this);
		Cell cell = new Cell();
		Cells.Add(cell);
	}

	internal void SetBounds(Rectangle r)
	{
		rectangle_0 = r;
	}

	internal void SetContentBounds(Rectangle r)
	{
		rectangle_3 = r;
	}

	internal void SetCellsBounds(Rectangle r)
	{
		rectangle_2 = r;
	}

	internal void SetParent(Node parent)
	{
		if (parent == null)
		{
			RemoveHostedControls(enumChildren: true);
		}
		if (node_0 == parent)
		{
			return;
		}
		node_0 = parent;
		foreach (Cell item in cellCollection_0)
		{
			if (item.HostedControl != null)
			{
				item.AddHostedControlToTree();
			}
		}
	}

	internal void RemoveHostedControls(bool enumChildren)
	{
		foreach (Cell item in cellCollection_0)
		{
			if (item.HostedControl != null && item.HostedControl.get_Parent() is AdvTree)
			{
				item.RemoveHostedControlFromTree();
			}
		}
		if (!enumChildren || nodeCollection_0 == null)
		{
			return;
		}
		foreach (Node item2 in nodeCollection_0)
		{
			item2.RemoveHostedControls(enumChildren: true);
		}
	}

	internal void SetExpandPartRectangle(Rectangle r)
	{
		rectangle_5 = r;
	}

	public void SetChecked(bool value, eTreeAction actionSource)
	{
		SetChecked((CheckState)(value ? 1 : 0), actionSource);
	}

	public void SetChecked(CheckState value, eTreeAction actionSource)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		cellCollection_0[0].SetChecked(value, actionSource);
	}

	internal void SetEditing(bool b)
	{
		bool_4 = b;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetImageDisabled()
	{
		TypeDescriptor.GetProperties(this)["ImageDisabled"]!.SetValue(this, null);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetImage()
	{
		TypeDescriptor.GetProperties(this)["Image"]!.SetValue(this, null);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetImageMouseOver()
	{
		TypeDescriptor.GetProperties(this)["ImageMouseOver"]!.SetValue(this, null);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetImageExpanded()
	{
		TypeDescriptor.GetProperties(this)["ImageExpanded"]!.SetValue(this, null);
	}

	public void Invalidate()
	{
		TreeControl?.method_7(this);
	}

	public void BeginEdit()
	{
		BeginEdit(0);
	}

	public void BeginEdit(string initialText)
	{
		BeginEdit(0, initialText);
	}

	public void BeginEdit(int iColumnIndex)
	{
		BeginEdit(iColumnIndex, null);
	}

	public void BeginEdit(int iColumnIndex, string initialText)
	{
		AdvTree treeControl = TreeControl;
		if (treeControl != null)
		{
			Cell cell = Cells[iColumnIndex];
			if (!cell.IsEditable)
			{
				throw new InvalidOperationException("Cell is not editable, either Cell.Editable=false or ColumnHeader.Editable=false.");
			}
			treeControl.method_32(Cells[iColumnIndex], eTreeAction.Code, initialText);
		}
	}

	public virtual Node Copy()
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		Node node = new Node();
		node.CellLayout = CellLayout;
		node.Cells.Clear();
		foreach (Cell cell in Cells)
		{
			node.Cells.Add(cell.Copy());
		}
		node.Checked = Checked;
		node.CommandButton = CommandButton;
		node.ExpandVisibility = ExpandVisibility;
		node.Image = Image;
		node.ImageDisabled = ImageDisabled;
		node.ImageDisabledIndex = ImageDisabledIndex;
		node.ImageExpanded = ImageExpanded;
		node.ImageExpandedIndex = ImageExpandedIndex;
		node.ImageIndex = ImageIndex;
		node.ImageMouseOver = ImageMouseOver;
		node.ImageMouseOverIndex = ImageMouseOverIndex;
		node.Expanded = Expanded;
		node.DragDropEnabled = DragDropEnabled;
		node.CellLayout = CellLayout;
		node.CellPartLayout = CellPartLayout;
		node.CheckBoxAlignment = CheckBoxAlignment;
		node.CheckBoxStyle = CheckBoxStyle;
		node.CheckBoxThreeState = CheckBoxThreeState;
		node.CheckBoxVisible = CheckBoxVisible;
		node.CheckState = CheckState;
		node.ContextMenu = ContextMenu;
		node.DataKey = DataKey;
		node.DragDropEnabled = DragDropEnabled;
		node.Enabled = Enabled;
		node.FullRowBackground = FullRowBackground;
		node.ImageAlignment = ImageAlignment;
		node.Selectable = Selectable;
		foreach (ColumnHeader nodesColumn in NodesColumns)
		{
			node.NodesColumns.Add(nodesColumn.Copy());
		}
		node.ParentConnector = ParentConnector;
		node.Style = Style;
		node.StyleExpanded = StyleExpanded;
		node.StyleMouseOver = StyleMouseOver;
		node.StyleSelected = StyleSelected;
		node.Tag = Tag;
		node.DataKey = DataKey;
		node.Text = Text;
		node.Visible = Visible;
		node.Name = Name;
		return node;
	}

	public virtual Node DeepCopy()
	{
		Node node = Copy();
		foreach (Node node2 in Nodes)
		{
			node.Nodes.Add(node2.DeepCopy());
		}
		return node;
	}

	public void Collapse()
	{
		SetExpanded(e: false, eTreeAction.Code);
	}

	public void Collapse(eTreeAction action)
	{
		SetExpanded(e: false, action);
	}

	public void CollapseAll()
	{
		AdvTree treeControl = TreeControl;
		treeControl?.BeginUpdate();
		Collapse();
		foreach (Node node in Nodes)
		{
			node.CollapseAll();
		}
		treeControl?.EndUpdate();
	}

	public void EndEdit(bool cancelChanges)
	{
		if (!IsEditing)
		{
			return;
		}
		AdvTree treeControl = TreeControl;
		if (treeControl != null)
		{
			if (cancelChanges)
			{
				treeControl.method_35(eTreeAction.Code);
			}
			else
			{
				treeControl.method_33(eTreeAction.Code);
			}
		}
	}

	public void EnsureVisible()
	{
		Class15.smethod_18(this, AdvTreeSettings.SelectedScrollIntoViewHorizontal);
	}

	public void Expand()
	{
		SetExpanded(e: true, eTreeAction.Code);
	}

	public void Expand(eTreeAction action)
	{
		SetExpanded(e: true, action);
	}

	public void ExpandAll()
	{
		AdvTree treeControl = TreeControl;
		treeControl?.BeginUpdate();
		try
		{
			foreach (Node node in Nodes)
			{
				node.Expand();
				node.ExpandAll();
			}
		}
		finally
		{
			treeControl?.EndUpdate();
		}
	}

	public void Remove()
	{
		if (Parent != null)
		{
			Parent.Nodes.Remove(this);
		}
		else if (TreeControl != null && TreeControl.Nodes.Contains(this))
		{
			TreeControl.Nodes.Remove(this);
		}
	}

	public void Remove(eTreeAction source)
	{
		if (Parent != null)
		{
			Parent.Nodes.Remove(this, source);
		}
		else if (TreeControl != null && TreeControl.Nodes.Contains(this))
		{
			TreeControl.Nodes.Remove(this, source);
		}
	}

	public void Toggle()
	{
		if (Expanded)
		{
			Collapse();
		}
		else
		{
			Expand();
		}
	}

	public void Toggle(eTreeAction action)
	{
		if (Expanded)
		{
			Collapse(action);
		}
		else
		{
			Expand(action);
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int count = Cells.Count;
		for (int i = 0; i < count; i++)
		{
			stringBuilder.Append(Cells[i].Text);
			if (i + 1 < count)
			{
				stringBuilder.Append(", ");
			}
		}
		return stringBuilder.ToString();
	}

	internal void OnCellInserted(Cell cell)
	{
		SizeChanged = true;
		OnDisplayChanged();
	}

	internal void OnCellRemoved(Cell cell)
	{
		SizeChanged = true;
		OnDisplayChanged();
	}

	private void OnSizeChanged()
	{
		if (bool_1)
		{
			AdvTree treeControl = TreeControl;
			if (treeControl != null && !treeControl.IsUpdateSuspended)
			{
				treeControl.method_8();
				((Control)treeControl).Invalidate();
			}
		}
	}

	internal void OnImageChanged()
	{
		SizeChanged = true;
		OnDisplayChanged();
	}

	internal void OnChildNodesSizeChanged()
	{
		foreach (Node node in Nodes)
		{
			node.SizeChanged = true;
			node.OnChildNodesSizeChanged();
		}
	}

	private void OnColumnHeaderSizeChanged(object sender, EventArgs e)
	{
		if (Expanded)
		{
			SizeChanged = true;
		}
	}

	private void SetExpanded(bool e, eTreeAction action)
	{
		if (e == bool_0)
		{
			return;
		}
		INodeNotify iNodeNotify = GetINodeNotify();
		if (iNodeNotify != null)
		{
			AdvTreeNodeCancelEventArgs advTreeNodeCancelEventArgs = new AdvTreeNodeCancelEventArgs(action, this);
			if (e)
			{
				iNodeNotify.OnBeforeExpand(advTreeNodeCancelEventArgs);
			}
			else
			{
				iNodeNotify.OnBeforeCollapse(advTreeNodeCancelEventArgs);
			}
			if (advTreeNodeCancelEventArgs.Cancel)
			{
				return;
			}
		}
		if (Class15.int_0 == 0)
		{
			return;
		}
		bool_0 = e;
		iNodeNotify?.ExpandedChanged(this);
		if (iNodeNotify != null)
		{
			AdvTreeNodeEventArgs e2 = new AdvTreeNodeEventArgs(action, this);
			if (e)
			{
				iNodeNotify.OnAfterExpand(e2);
			}
			else
			{
				iNodeNotify.OnAfterCollapse(e2);
			}
		}
		foreach (Node node in Nodes)
		{
			node.OnParentExpandedChanged(bool_0);
		}
		SizeChanged = true;
		OnDisplayChanged();
	}

	internal void OnParentExpandedChanged(bool expanded)
	{
		foreach (Cell cell in Cells)
		{
			cell.OnParentExpandedChanged(expanded);
		}
		foreach (Node node in Nodes)
		{
			node.OnParentExpandedChanged(expanded);
		}
	}

	private AdvTree GetTreeControl()
	{
		Node node = this;
		while (node.Parent != null)
		{
			node = node.Parent;
		}
		return node.advTree_0;
	}

	private INodeNotify GetINodeNotify()
	{
		AdvTree treeControl = TreeControl;
		if (treeControl != null)
		{
			return treeControl;
		}
		return null;
	}

	private void ElementStyleChanged(object sender, EventArgs e)
	{
		SizeChanged = true;
		OnDisplayChanged();
	}

	internal void OnDisplayChanged()
	{
		AdvTree treeControl = TreeControl;
		if (treeControl != null && !treeControl.SuspendPaint)
		{
			if (SizeChanged)
			{
				TreeControl.RecalcLayout();
			}
			((Control)TreeControl).Invalidate(true);
		}
	}

	private void ConnectorAppearanceChanged(object sender, EventArgs e)
	{
		OnDisplayChanged();
	}

	internal void OnChildNodeInserted(Node node)
	{
		SizeChanged = true;
		if (node.Cells.Count > 1)
		{
			node.SizeChanged = true;
		}
	}

	internal void OnChildNodeRemoved(Node node)
	{
		SizeChanged = true;
		if (node.IsSelected && TreeControl != null)
		{
			TreeControl.SelectedNode = null;
		}
	}

	internal void OnVisibleChanged()
	{
		foreach (Cell cell in Cells)
		{
			cell.OnVisibleChanged();
		}
		foreach (Node node in Nodes)
		{
			node.OnVisibleChanged();
		}
	}

	public void CreateCells()
	{
		AdvTree treeControl = TreeControl;
		if (Parent == null && treeControl == null)
		{
			throw new NullReferenceException("Node must have a parent or be added to AdvTree.Nodes collection to use this method.");
		}
		Node parent = Parent;
		int num = 0;
		if (parent != null && parent.NodesColumns.Count > 0)
		{
			num = parent.NodesColumns.Count;
		}
		else if (treeControl != null && treeControl.Columns.Count > 0)
		{
			num = treeControl.Columns.Count;
		}
		if (num != 0)
		{
			for (int i = Cells.Count; i < num; i++)
			{
				Cells.Add(new Cell());
			}
		}
	}

	internal void OnNodesCleared()
	{
		SizeChanged = true;
	}

	protected internal virtual void InvokeNodeMouseDown(object sender, MouseEventArgs e)
	{
		if (mouseEventHandler_0 != null)
		{
			mouseEventHandler_0.Invoke((object)this, e);
		}
		foreach (Cell item in cellCollection_0)
		{
			item.InvokeNodeMouseDown(sender, e);
		}
	}

	protected internal virtual void InvokeNodeMouseUp(object sender, MouseEventArgs e)
	{
		if (mouseEventHandler_1 != null)
		{
			mouseEventHandler_1.Invoke((object)this, e);
		}
		foreach (Cell item in cellCollection_0)
		{
			item.InvokeNodeMouseUp(sender, e);
		}
	}

	protected internal virtual void InvokeNodeMouseMove(object sender, MouseEventArgs e)
	{
		if (mouseEventHandler_2 != null)
		{
			mouseEventHandler_2.Invoke((object)this, e);
		}
		foreach (Cell item in cellCollection_0)
		{
			item.InvokeNodeMouseMove(sender, e);
		}
	}

	protected internal virtual void InvokeNodeClick(object sender, EventArgs e)
	{
		if (eventHandler_3 != null)
		{
			eventHandler_3(this, e);
		}
		foreach (Cell item in cellCollection_0)
		{
			item.InvokeNodeClick(sender, e);
		}
	}

	protected internal virtual void InvokeNodeDoubleClick(object sender, EventArgs e)
	{
		if (eventHandler_4 != null)
		{
			eventHandler_4(this, e);
		}
	}

	protected internal virtual void InvokeNodeMouseEnter(object sender, EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, e);
		}
	}

	protected internal virtual void InvokeNodeMouseLeave(object sender, EventArgs e)
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, e);
		}
		foreach (Cell item in cellCollection_0)
		{
			item.InvokeNodeMouseLeave(sender, e);
		}
	}

	protected internal virtual void InvokeNodeMouseHover(object sender, EventArgs e)
	{
		if (eventHandler_2 != null)
		{
			eventHandler_2(this, e);
		}
	}

	protected internal virtual void InvokeMarkupLinkClick(Cell cell, MarkupLinkClickEventArgs args)
	{
		if (markupLinkClickEventHandler_0 != null)
		{
			markupLinkClickEventHandler_0(cell, args);
		}
		TreeControl?.method_64(cell, args);
	}

	protected virtual AccessibleObject CreateAccessibilityInstance()
	{
		return (AccessibleObject)(object)new NodeAccessibleObject(this);
	}

	internal void GenerateAccessibilityEvent(AccessibleEvents e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		AdvTree treeControl = TreeControl;
		if (treeControl != null && ((Control)treeControl).get_AccessibilityObject() is AdvTree.AdvTreeAccessibleObject advTreeAccessibleObject)
		{
			advTreeAccessibleObject.method_0(this, e);
		}
	}

	public int CompareTo(object obj)
	{
		if (obj is Node)
		{
			Node node = obj as Node;
			return Utilities.smethod_3(Text, node.Text);
		}
		return -1;
	}
}
