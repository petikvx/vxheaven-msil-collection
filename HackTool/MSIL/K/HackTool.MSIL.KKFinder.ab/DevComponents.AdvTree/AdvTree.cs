using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using DevComponents.AdvTree.Design;
using DevComponents.AdvTree.Display;
using DevComponents.AdvTree.Interop;
using DevComponents.AdvTree.Layout;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.ScrollBar;

namespace DevComponents.AdvTree;

[ToolboxBitmap(typeof(ToolboxIconResFinder), "AdvTree.ico")]
[ToolboxItem(true)]
[ComVisible(false)]
[Designer(typeof(AdvTreeDesigner))]
[DefaultEvent("Click")]
public class AdvTree : ScrollableControl, ISupportInitialize, INodeNotify
{
	public class AdvTreeAccessibleObject : ControlAccessibleObject
	{
		private AdvTree advTree_0;

		public override string Name
		{
			get
			{
				if (advTree_0 != null && !((Control)advTree_0).get_IsDisposed())
				{
					return ((Control)advTree_0).get_AccessibleName();
				}
				return "";
			}
			set
			{
				if (advTree_0 != null && !((Control)advTree_0).get_IsDisposed())
				{
					((Control)advTree_0).set_AccessibleName(value);
				}
			}
		}

		public override string Description
		{
			get
			{
				if (advTree_0 != null && !((Control)advTree_0).get_IsDisposed())
				{
					return ((Control)advTree_0).get_AccessibleDescription();
				}
				return "";
			}
		}

		public override AccessibleRole Role
		{
			get
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				if (advTree_0 == null || ((Control)advTree_0).get_IsDisposed())
				{
					return (AccessibleRole)0;
				}
				return ((Control)advTree_0).get_AccessibleRole();
			}
		}

		public override AccessibleObject Parent
		{
			get
			{
				if (advTree_0 != null && !((Control)advTree_0).get_IsDisposed())
				{
					return ((Control)advTree_0).get_Parent().get_AccessibilityObject();
				}
				return null;
			}
		}

		public override Rectangle Bounds
		{
			get
			{
				if (advTree_0 != null && !((Control)advTree_0).get_IsDisposed() && ((Control)advTree_0).get_Parent() != null)
				{
					return ((Control)advTree_0).get_Parent().RectangleToScreen(((Control)advTree_0).get_Bounds());
				}
				return Rectangle.Empty;
			}
		}

		public override AccessibleStates State
		{
			get
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_0029: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				AccessibleStates result = (AccessibleStates)256;
				if (advTree_0 == null || ((Control)advTree_0).get_IsDisposed())
				{
					return (AccessibleStates)0;
				}
				if (((Control)advTree_0).get_Focused())
				{
					result = (AccessibleStates)4;
				}
				return result;
			}
		}

		public AdvTreeAccessibleObject(AdvTree owner)
			: base((Control)(object)owner)
		{
			advTree_0 = owner;
		}

		internal void method_0(Node node_0, AccessibleEvents accessibleEvents_0)
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			int num = advTree_0.Nodes.IndexOf(node_0);
			if (num >= 0 && advTree_0 != null && !((Control)advTree_0).get_IsDisposed())
			{
				((Control)advTree_0).AccessibilityNotifyClients(accessibleEvents_0, num);
			}
		}

		public override int GetChildCount()
		{
			if (advTree_0 != null && !((Control)advTree_0).get_IsDisposed() && advTree_0.Nodes != null)
			{
				return advTree_0.Nodes.Count;
			}
			return 0;
		}

		public override AccessibleObject GetChild(int iIndex)
		{
			if (advTree_0 != null && !((Control)advTree_0).get_IsDisposed() && advTree_0.Nodes != null)
			{
				return advTree_0.Nodes[iIndex].AccessibleObject;
			}
			return null;
		}
	}

	private ElementStyleCollection elementStyleCollection_0 = new ElementStyleCollection();

	private ColumnHeaderCollection columnHeaderCollection_0 = new ColumnHeaderCollection();

	private NodeCollection nodeCollection_0 = new NodeCollection();

	private Container container_0;

	private ElementStyle elementStyle_0;

	private ElementStyle elementStyle_1;

	private ElementStyle elementStyle_2;

	private ElementStyle elementStyle_3;

	private ElementStyle elementStyle_4;

	private ElementStyle elementStyle_5;

	private ElementStyle elementStyle_6;

	private ElementStyle elementStyle_7;

	private ElementStyle elementStyle_8;

	private ElementStyle elementStyle_9;

	private ElementStyle elementStyle_10;

	private ElementStyle elementStyle_11;

	private Class17 class17_0;

	private NodeDisplay nodeDisplay_0;

	private HeadersCollection headersCollection_0;

	private string string_0;

	private int int_0;

	private bool bool_0;

	private bool bool_1;

	private Node node_0;

	private SelectedNodesCollection selectedNodesCollection_0;

	private Node node_1;

	private Cell cell_0;

	private int int_1;

	private ImageList imageList_0;

	private int int_2;

	private bool bool_2;

	private NodeConnector nodeConnector_0;

	private NodeConnector nodeConnector_1;

	private NodeConnector nodeConnector_2;

	private eCellLayout eCellLayout_0;

	private eCellPartLayout eCellPartLayout_0;

	private Cursor cursor_0;

	private Cursor cursor_1;

	private ColorScheme colorScheme_0;

	private bool bool_3;

	private bool bool_4;

	private int int_3;

	private Size size_0;

	private Size size_1;

	private Color color_0;

	private eColorSchemePart eColorSchemePart_0;

	private Color color_1;

	private eColorSchemePart eColorSchemePart_1;

	private Color color_2;

	private eColorSchemePart eColorSchemePart_2;

	private int int_4;

	private Color color_3;

	private eColorSchemePart eColorSchemePart_3;

	private Image image_0;

	private Image image_1;

	private eExpandButtonType eExpandButtonType_0;

	private Node node_2;

	private int int_5;

	private Color color_4;

	private eColorSchemePart eColorSchemePart_4;

	private Color color_5;

	private eColorSchemePart eColorSchemePart_5;

	private Color color_6;

	private eColorSchemePart eColorSchemePart_6;

	private int int_6;

	private Color color_7;

	private eColorSchemePart eColorSchemePart_7;

	private Color color_8;

	private eColorSchemePart eColorSchemePart_8;

	private Color color_9;

	private eColorSchemePart eColorSchemePart_9;

	private int int_7;

	private bool bool_5;

	private bool bool_6;

	private Cell cell_1;

	private Class22 class22_0;

	private bool bool_7;

	private Node node_3;

	private Point point_0;

	private eNodeLayout eNodeLayout_0;

	private int int_8;

	private int int_9;

	private eDiagramFlow eDiagramFlow_0;

	private eMapFlow eMapFlow_0;

	private ElementStyle elementStyle_12;

	private eNodeRenderMode eNodeRenderMode_0;

	private TreeRenderer treeRenderer_0;

	private ArrayList arrayList_0;

	private float float_0;

	private object object_0;

	private VScrollBarAdv vscrollBarAdv_0;

	private HScrollBarAdv hscrollBarAdv_0;

	private Control control_0;

	private Control0 control0_0;

	private ArrayList arrayList_1;

	private MouseEventHandler mouseEventHandler_0;

	private MouseEventHandler mouseEventHandler_1;

	private AdvTreeCellEventHandler advTreeCellEventHandler_0;

	private AdvTreeCellBeforeCheckEventHandler advTreeCellBeforeCheckEventHandler_0;

	private AdvTreeNodeEventHandler advTreeNodeEventHandler_0;

	private AdvTreeNodeCancelEventHandler advTreeNodeCancelEventHandler_0;

	private AdvTreeNodeEventHandler advTreeNodeEventHandler_1;

	private AdvTreeNodeCancelEventHandler advTreeNodeCancelEventHandler_1;

	private CommandButtonEventHandler commandButtonEventHandler_0;

	private CellEditEventHandler cellEditEventHandler_0;

	private CellEditEventHandler cellEditEventHandler_1;

	private CellEditEventHandler cellEditEventHandler_2;

	private CellEditEventHandler cellEditEventHandler_3;

	private AdvTreeNodeCancelEventHandler advTreeNodeCancelEventHandler_2;

	private AdvTreeNodeEventHandler advTreeNodeEventHandler_2;

	private AdvTreeNodeEventHandler advTreeNodeEventHandler_3;

	private TreeNodeCollectionEventHandler treeNodeCollectionEventHandler_0;

	private TreeNodeCollectionEventHandler treeNodeCollectionEventHandler_1;

	private TreeNodeCollectionEventHandler treeNodeCollectionEventHandler_2;

	private TreeNodeCollectionEventHandler treeNodeCollectionEventHandler_3;

	private EventHandler eventHandler_0;

	private AdvTreeNodeCancelEventHandler advTreeNodeCancelEventHandler_3;

	private TreeDragDropEventHandler treeDragDropEventHandler_0;

	private TreeDragFeedbackEventHander treeDragFeedbackEventHander_0;

	private TreeDragDropEventHandler treeDragDropEventHandler_1;

	private TreeNodeMouseEventHandler treeNodeMouseEventHandler_0;

	private TreeNodeMouseEventHandler treeNodeMouseEventHandler_1;

	private TreeNodeMouseEventHandler treeNodeMouseEventHandler_2;

	private TreeNodeMouseEventHandler treeNodeMouseEventHandler_3;

	private TreeNodeMouseEventHandler treeNodeMouseEventHandler_4;

	private TreeNodeMouseEventHandler treeNodeMouseEventHandler_5;

	private TreeNodeMouseEventHandler treeNodeMouseEventHandler_6;

	private TreeNodeMouseEventHandler treeNodeMouseEventHandler_7;

	private SerializeNodeEventHandler serializeNodeEventHandler_0;

	private SerializeNodeEventHandler serializeNodeEventHandler_1;

	private MarkupLinkClickEventHandler markupLinkClickEventHandler_0;

	private CustomCellEditorEventHandler customCellEditorEventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private TreeConvertEventHandler treeConvertEventHandler_0;

	private EventHandler eventHandler_3;

	private EventHandler eventHandler_4;

	private EventHandler eventHandler_5;

	private DataNodeEventHandler dataNodeEventHandler_0;

	private DataNodeEventHandler dataNodeEventHandler_1;

	private EventHandler eventHandler_6;

	private EventHandler eventHandler_7;

	private EventHandler eventHandler_8;

	private DataColumnEventHandler dataColumnEventHandler_0;

	private bool bool_8;

	private ContextMenuBar contextMenuBar_0;

	private bool bool_9;

	private bool bool_10;

	private ColumnHeader columnHeader_0;

	private int int_10;

	private bool bool_11;

	private bool bool_12;

	private Color color_10;

	private ElementStyle elementStyle_13;

	private ElementStyle elementStyle_14;

	private bool bool_13;

	private eMultiSelectRule eMultiSelectRule_0;

	private Image image_2;

	private Image image_3;

	private Image image_4;

	private bool bool_14;

	private bool bool_15;

	private eSelectionStyle eSelectionStyle_0;

	private bool bool_16;

	private int int_11;

	private bool bool_17;

	private bool bool_18;

	private Timer timer_0;

	private int int_12;

	private string string_1;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private ColumnHeaderCollection columnHeaderCollection_1;

	private bool bool_19;

	private ICellEditControl icellEditControl_0;

	private bool bool_20;

	private Size size_2;

	private Point point_1;

	private Timer timer_1;

	private Class2 class2_0;

	private int int_13;

	private List<BindingMemberInfo> list_0;

	private object object_1;

	private bool bool_21;

	private string string_2;

	private IFormatProvider iformatProvider_0;

	private bool bool_22;

	private Hashtable hashtable_0;

	private string string_3;

	private ElementStyle elementStyle_15;

	private CurrencyManager currencyManager_0;

	private bool bool_23;

	private bool bool_24;

	private static TypeConverter typeConverter_0;

	private BindingMemberInfo bindingMemberInfo_0;

	[Description("Indicates whether the selected tree node remains highlighted even when the tree control has lost the focus.")]
	[DefaultValue(false)]
	[Category("Selection")]
	public bool HideSelection
	{
		get
		{
			return bool_8;
		}
		set
		{
			bool_8 = value;
			if (SelectedNode != null && !((Control)this).get_Focused())
			{
				((Control)this).Invalidate();
			}
		}
	}

	internal ArrayList ArrayList_0
	{
		get
		{
			return arrayList_1;
		}
		set
		{
			arrayList_1 = value;
		}
	}

	[DefaultValue(null)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public ContextMenuBar ContextMenuBar
	{
		get
		{
			return contextMenuBar_0;
		}
		set
		{
			contextMenuBar_0 = value;
		}
	}

	[Category("Layout")]
	[DefaultValue(1f)]
	[Browsable(false)]
	[Description("Indicates zoom factor for the control.")]
	public float Zoom
	{
		get
		{
			return float_0;
		}
		set
		{
			if (!((double)value <= 0.1))
			{
				float_0 = value;
				RecalcLayout();
			}
		}
	}

	[Browsable(false)]
	public Size TreeSize => new Size(class17_0.Int32_0, class17_0.Int32_1);

	[Description("Indicates render mode used to render the node.")]
	[Browsable(false)]
	[DefaultValue(null)]
	[Category("Style")]
	internal TreeRenderer TreeRenderer_0
	{
		get
		{
			return treeRenderer_0;
		}
		set
		{
			treeRenderer_0 = value;
			method_13();
		}
	}

	[Category("Style")]
	[Browsable(true)]
	[Description("Indicates render mode used to render the node.")]
	[DefaultValue(eNodeRenderMode.Default)]
	internal eNodeRenderMode ENodeRenderMode_0
	{
		get
		{
			return eNodeRenderMode_0;
		}
		set
		{
			eNodeRenderMode_0 = value;
			method_13();
		}
	}

	[Category("Appearance")]
	[Description("Gets the style for the background of the control.")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ElementStyle BackgroundStyle => elementStyle_12;

	[Description("Indicates whether automatic drag and drop is enabled.")]
	[Browsable(true)]
	[DefaultValue(true)]
	[Category("Behavior")]
	public bool DragDropEnabled
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

	[Browsable(true)]
	[Description("Gets or sets whether anti-aliasing is used while painting the tree.")]
	[Category("Appearance")]
	[DefaultValue(true)]
	public bool AntiAlias
	{
		get
		{
			return bool_2;
		}
		set
		{
			if (bool_2 != value)
			{
				bool_2 = value;
				((Control)this).Refresh();
			}
		}
	}

	[Description("Indicates the delimiter string that the tree node path uses.")]
	[Browsable(false)]
	[DefaultValue("\\")]
	public string PathSeparator
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	[Category("Columns")]
	[DefaultValue(true)]
	[Description("Indicates whether user can resize the columns.")]
	public bool AllowUserToResizeColumns
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Columns")]
	[Description("Gets collection of column headers that appear in the tree.")]
	public ColumnHeaderCollection Columns => columnHeaderCollection_0;

	[DefaultValue(true)]
	[Description("Indicates whether column headers are visible if they are defined through Columns collection.")]
	[Category("Columns")]
	public bool ColumnsVisible
	{
		get
		{
			return bool_10;
		}
		set
		{
			if (bool_10 != value)
			{
				bool_10 = value;
				if (columnHeaderCollection_0.Count > 0)
				{
					RecalcLayout();
				}
			}
		}
	}

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ElementStyleCollection Styles => elementStyleCollection_0;

	[Description("Indicates default style for the node cell.")]
	[DefaultValue(null)]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[Category("Node Style")]
	public ElementStyle CellStyleDefault
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
					elementStyle_0.StyleChanged -= elementStyle_12_StyleChanged;
				}
				if (value != null)
				{
					value.StyleChanged += elementStyle_12_StyleChanged;
				}
				elementStyle_0 = value;
				method_22();
			}
		}
	}

	[Description("Indicates default style for the node cell when mouse is pressed.")]
	[Browsable(true)]
	[Category("Node Style")]
	[DefaultValue(null)]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	public ElementStyle CellStyleMouseDown
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
					elementStyle_1.StyleChanged -= elementStyle_12_StyleChanged;
				}
				if (value != null)
				{
					value.StyleChanged += elementStyle_12_StyleChanged;
				}
				elementStyle_1 = value;
				method_22();
			}
		}
	}

	[Description("Indicates default style for the node cell when mouse is over the cell.")]
	[Browsable(true)]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[DefaultValue(null)]
	[Category("Node Style")]
	public ElementStyle CellStyleMouseOver
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
					elementStyle_2.StyleChanged -= elementStyle_12_StyleChanged;
				}
				if (value != null)
				{
					value.StyleChanged += elementStyle_12_StyleChanged;
				}
				elementStyle_2 = value;
				method_22();
			}
		}
	}

	[Description("Indicates default style for the node cell when cell is selected.")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Category("Node Style")]
	public ElementStyle CellStyleSelected
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
					elementStyle_3.StyleChanged -= elementStyle_12_StyleChanged;
				}
				if (value != null)
				{
					value.StyleChanged += elementStyle_12_StyleChanged;
				}
				elementStyle_3 = value;
				method_22();
			}
		}
	}

	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Description("Indicates default style for the node cell when cell is disabled.")]
	[Category("Node Style")]
	[DefaultValue(null)]
	[Browsable(true)]
	public ElementStyle CellStyleDisabled
	{
		get
		{
			return elementStyle_4;
		}
		set
		{
			if (elementStyle_4 != value)
			{
				if (elementStyle_4 != null)
				{
					elementStyle_4.StyleChanged -= elementStyle_12_StyleChanged;
				}
				if (value != null)
				{
					value.StyleChanged += elementStyle_12_StyleChanged;
				}
				elementStyle_4 = value;
				method_22();
			}
		}
	}

	[Browsable(true)]
	[Category("Node Style")]
	[Description("Gets or sets default style for the node cell when node that cell belongs to is expanded.")]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[DefaultValue(null)]
	public ElementStyle NodeStyleExpanded
	{
		get
		{
			return elementStyle_5;
		}
		set
		{
			if (elementStyle_5 != value)
			{
				if (elementStyle_5 != null)
				{
					elementStyle_5.StyleChanged -= elementStyle_12_StyleChanged;
				}
				if (value != null)
				{
					value.StyleChanged += elementStyle_12_StyleChanged;
				}
				elementStyle_5 = value;
				method_22();
			}
		}
	}

	[Description("Gets or sets default style for the node.")]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[DefaultValue(null)]
	[Category("Node Style")]
	public ElementStyle NodeStyle
	{
		get
		{
			return elementStyle_6;
		}
		set
		{
			if (elementStyle_6 != value)
			{
				if (elementStyle_6 != null)
				{
					elementStyle_6.StyleChanged -= elementStyle_12_StyleChanged;
				}
				if (value != null)
				{
					value.StyleChanged += elementStyle_12_StyleChanged;
				}
				elementStyle_6 = value;
				method_22();
			}
		}
	}

	[Description("Gets or sets style of the node when node is selected.")]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[Category("Node Style")]
	[DefaultValue(null)]
	public ElementStyle NodeStyleSelected
	{
		get
		{
			return elementStyle_7;
		}
		set
		{
			if (elementStyle_7 != value)
			{
				if (elementStyle_7 != null)
				{
					elementStyle_7.StyleChanged -= elementStyle_12_StyleChanged;
				}
				if (value != null)
				{
					value.StyleChanged += elementStyle_12_StyleChanged;
				}
				elementStyle_7 = value;
				method_22();
			}
		}
	}

	[Description("Gets or sets style of the node when mouse is over node.")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Category("Node Style")]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	public ElementStyle NodeStyleMouseOver
	{
		get
		{
			return elementStyle_8;
		}
		set
		{
			if (elementStyle_8 != value)
			{
				if (elementStyle_8 != null)
				{
					elementStyle_8.StyleChanged -= elementStyle_12_StyleChanged;
				}
				if (value != null)
				{
					value.StyleChanged += elementStyle_12_StyleChanged;
				}
				elementStyle_8 = value;
				method_22();
			}
		}
	}

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets the collection of tree nodes that are assigned to the tree control.")]
	public NodeCollection Nodes => nodeCollection_0;

	[DefaultValue(3)]
	[Description("Indicates vertical spacing between nodes in pixels.")]
	public int NodeSpacing
	{
		get
		{
			return int_10;
		}
		set
		{
			int_10 = value;
			class17_0.NodeVerticalSpacing = value;
			InvalidateNodesSize();
			RecalcLayout();
		}
	}

	[Category("Columns")]
	[DefaultValue(false)]
	[Description("")]
	public bool GridRowLines
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
				((Control)this).Invalidate();
			}
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether grid lines are displayed when columns are defined.")]
	[Category("Columns")]
	public bool GridColumnLines
	{
		get
		{
			return bool_12;
		}
		set
		{
			if (bool_12 != value)
			{
				bool_12 = value;
				if (columnHeaderCollection_0.Count > 0 && bool_10)
				{
					((Control)this).Invalidate();
				}
			}
		}
	}

	[Category("Columns")]
	[Description("Indicates grid lines color.")]
	public Color GridLinesColor
	{
		get
		{
			return color_10;
		}
		set
		{
			color_10 = value;
			((Control)this).Invalidate();
		}
	}

	[DefaultValue(null)]
	[Description("Indicates the style class assigned to the child nodes columns.")]
	[Category("Column Header Style")]
	[Browsable(true)]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	public ElementStyle NodesColumnsBackgroundStyle
	{
		get
		{
			return elementStyle_13;
		}
		set
		{
			if (elementStyle_13 != null)
			{
				elementStyle_13.StyleChanged -= elementStyle_12_StyleChanged;
			}
			if (value != null)
			{
				value.StyleChanged += elementStyle_12_StyleChanged;
			}
			elementStyle_13 = value;
		}
	}

	[DefaultValue(null)]
	[Description("Indicates the style class assigned to the column.")]
	[Browsable(true)]
	[Category("Column Header Style")]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	public ElementStyle ColumnsBackgroundStyle
	{
		get
		{
			return elementStyle_14;
		}
		set
		{
			if (elementStyle_14 != null)
			{
				elementStyle_14.StyleChanged -= elementStyle_12_StyleChanged;
			}
			if (value != null)
			{
				value.StyleChanged += elementStyle_12_StyleChanged;
			}
			elementStyle_14 = value;
		}
	}

	[DefaultValue(null)]
	[Description("Indicates the style class assigned to the column.")]
	[Category("Column Header Style")]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	public ElementStyle ColumnStyleNormal
	{
		get
		{
			return elementStyle_9;
		}
		set
		{
			if (elementStyle_9 != null)
			{
				elementStyle_9.StyleChanged -= elementStyle_12_StyleChanged;
			}
			if (value != null)
			{
				value.StyleChanged += elementStyle_12_StyleChanged;
			}
			elementStyle_9 = value;
		}
	}

	[DefaultValue(null)]
	[Category("Column Header Style")]
	[Browsable(true)]
	[Description("Indicates the style class assigned to the column when mouse is down.")]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	public ElementStyle ColumnStyleMouseDown
	{
		get
		{
			return elementStyle_11;
		}
		set
		{
			if (elementStyle_11 != null)
			{
				elementStyle_11.StyleChanged -= elementStyle_12_StyleChanged;
			}
			if (value != null)
			{
				value.StyleChanged += elementStyle_12_StyleChanged;
			}
			elementStyle_11 = value;
		}
	}

	[Category("Column Header Style")]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[DefaultValue(null)]
	[Description("Indicates the style class assigned to the cell when mouse is over the column.")]
	public ElementStyle ColumnStyleMouseOver
	{
		get
		{
			return elementStyle_10;
		}
		set
		{
			if (elementStyle_10 != null)
			{
				elementStyle_10.StyleChanged -= elementStyle_12_StyleChanged;
			}
			if (value != null)
			{
				value.StyleChanged += elementStyle_12_StyleChanged;
			}
			elementStyle_10 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	[Description("Collection that holds definition of column headers associated with nodes.")]
	internal HeadersCollection HeadersCollection_0 => headersCollection_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Node SelectedNode
	{
		get
		{
			if (bool_13 && selectedNodesCollection_0.Count > 0)
			{
				return selectedNodesCollection_0[selectedNodesCollection_0.Count - 1];
			}
			return node_0;
		}
		set
		{
			if (node_0 != value)
			{
				SelectNode(value, eTreeAction.Code);
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public NodeCollection SelectedNodes => selectedNodesCollection_0;

	[DefaultValue(false)]
	[Category("Selection")]
	[Description("Indicates whether multi-node selection is enabled.")]
	public bool MultiSelect
	{
		get
		{
			return bool_13;
		}
		set
		{
			if (bool_13 != value)
			{
				if (bool_13)
				{
					selectedNodesCollection_0.Clear();
				}
				bool_13 = value;
			}
		}
	}

	[DefaultValue(eMultiSelectRule.SameParent)]
	[Description("Indicates rule that governs the multiple node selection.")]
	[Category("Selection")]
	public eMultiSelectRule MultiSelectRule
	{
		get
		{
			return eMultiSelectRule_0;
		}
		set
		{
			eMultiSelectRule_0 = value;
		}
	}

	internal Class17 Class17_0 => class17_0;

	internal NodeDisplay NodeDisplay_0 => nodeDisplay_0;

	[Browsable(false)]
	public bool IsUpdateSuspended => int_0 > 0;

	[Browsable(false)]
	public bool IsLayoutPending => bool_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool SuspendPaint
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	[DefaultValue(null)]
	[Description("Indicates the ImageList that contains the Image objects used by the tree nodes.")]
	[Category("Images")]
	[Browsable(true)]
	public ImageList ImageList
	{
		get
		{
			return imageList_0;
		}
		set
		{
			if (imageList_0 != null)
			{
				((Component)(object)imageList_0).Disposed -= imageList_0_Disposed;
			}
			imageList_0 = value;
			if (imageList_0 != null)
			{
				((Component)(object)imageList_0).Disposed += imageList_0_Disposed;
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates the image-list index value of the default image that is displayed by the tree nodes.")]
	[Category("Images")]
	[TypeConverter(typeof(ImageIndexConverter))]
	[DefaultValue(-1)]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	public int ImageIndex
	{
		get
		{
			return int_2;
		}
		set
		{
			if (int_2 != value)
			{
				int_2 = value;
			}
		}
	}

	[Category("CheckBox Images")]
	[DefaultValue(null)]
	[Description("Indicates custom image that is displayed instead default check box representation when check box in cell is checked")]
	public Image CheckBoxImageChecked
	{
		get
		{
			return image_2;
		}
		set
		{
			image_2 = value;
			method_9();
		}
	}

	[Description("Indicates custom image that is displayed instead default check box representation when check box in cell is unchecked")]
	[DefaultValue(null)]
	[Category("CheckBox Images")]
	public Image CheckBoxImageUnChecked
	{
		get
		{
			return image_3;
		}
		set
		{
			image_3 = value;
			method_9();
		}
	}

	[Category("CheckBox Images")]
	[Description("Indicates custom image that is displayed instead default check box representation when check box in cell is in indeterminate state")]
	[DefaultValue(null)]
	public Image CheckBoxImageIndeterminate
	{
		get
		{
			return image_4;
		}
		set
		{
			image_4 = value;
			method_9();
		}
	}

	[Category("Connectors")]
	[DefaultValue(null)]
	[Editor(typeof(NodeConnectorTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[Description("Indicates the nested nodes connector.")]
	public NodeConnector NodesConnector
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
					nodeConnector_0.AppearanceChanged -= method_15;
				}
				if (value != null)
				{
					value.AppearanceChanged += method_15;
				}
				nodeConnector_0 = value;
				method_13();
			}
		}
	}

	[Category("Connectors")]
	[DefaultValue(null)]
	[Editor(typeof(NodeConnectorTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[Description("Indicates the linked nodes connector.")]
	internal NodeConnector NodeConnector_0
	{
		get
		{
			return nodeConnector_2;
		}
		set
		{
			if (nodeConnector_2 != value)
			{
				if (nodeConnector_2 != null)
				{
					nodeConnector_2.AppearanceChanged -= method_15;
				}
				if (value != null)
				{
					value.AppearanceChanged += method_15;
				}
				nodeConnector_2 = value;
				method_13();
			}
		}
	}

	[DefaultValue(eCellLayout.Default)]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates layout of the cells inside the node.")]
	public eCellLayout CellLayout
	{
		get
		{
			return eCellLayout_0;
		}
		set
		{
			eCellLayout_0 = value;
			InvalidateNodesSize();
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates layout of the cells inside the node.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(eCellPartLayout.Default)]
	public eCellPartLayout CellPartLayout
	{
		get
		{
			return eCellPartLayout_0;
		}
		set
		{
			eCellPartLayout_0 = value;
			InvalidateNodesSize();
			((Control)this).Invalidate();
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates the color scheme style.")]
	[DefaultValue(eColorSchemeStyle.Office2007)]
	public eColorSchemeStyle ColorSchemeStyle
	{
		get
		{
			return smethod_1(colorScheme_0.EDotNetBarStyle_0);
		}
		set
		{
			colorScheme_0.EDotNetBarStyle_0 = smethod_0(value);
			if (((Component)this).DesignMode)
			{
				((Control)this).Refresh();
			}
		}
	}

	internal ColorScheme ColorScheme_0
	{
		get
		{
			if (ColorSchemeStyle == eColorSchemeStyle.Office2007 && GlobalManager.Renderer is Office2007Renderer)
			{
				return ((Office2007Renderer)GlobalManager.Renderer).ColorTable.LegacyColors;
			}
			return colorScheme_0;
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether the content of the control is centered within the bounds of control.")]
	[Category("Layout")]
	[Browsable(true)]
	internal bool Boolean_0
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			method_14();
		}
	}

	[Category("Selection")]
	[Description("Indicates whether selection is drawn for selected cell only instead of all cells inside of node")]
	[DefaultValue(false)]
	public bool SelectionPerCell
	{
		get
		{
			return bool_14;
		}
		set
		{
			if (bool_14 != value)
			{
				bool_14 = value;
				if (SelectedNode != null)
				{
					method_7(SelectedNode);
				}
			}
		}
	}

	[DefaultValue(true)]
	[Category("Selection")]
	[Description("Indicates whether selection appearance changes depending on whether control has input focus.")]
	public bool SelectionFocusAware
	{
		get
		{
			return bool_15;
		}
		set
		{
			if (bool_15 != value)
			{
				bool_15 = value;
				((Control)this).Invalidate();
			}
		}
	}

	[DefaultValue(eSelectionStyle.HighlightCells)]
	[Description("Indicates node selection box style.")]
	[Category("Selection")]
	public eSelectionStyle SelectionBoxStyle
	{
		get
		{
			return eSelectionStyle_0;
		}
		set
		{
			eSelectionStyle_0 = value;
		}
	}

	[DefaultValue(true)]
	[Browsable(true)]
	[Category("Selection")]
	[Description("Indicates whether selection box is drawn around selected node.")]
	public bool SelectionBox
	{
		get
		{
			return bool_4;
		}
		set
		{
			if (bool_4 != value)
			{
				bool_4 = value;
				method_41();
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(4)]
	[Category("Selection")]
	[Description("Indicates the size in pixels of the selection box drawn around selected node.")]
	internal int Int32_0
	{
		get
		{
			return int_3;
		}
		set
		{
			if (int_3 != value)
			{
				int_3 = value;
				method_41();
			}
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether node is selected when mouse is pressed anywhere within node vertical bounds.")]
	[Category("Selection")]
	public bool FullRowSelect
	{
		get
		{
			return bool_16;
		}
		set
		{
			bool_16 = value;
		}
	}

	[DefaultValue(24)]
	[Description("Indicates total node expand area width in pixels.")]
	[Category("Expand Button")]
	public int ExpandWidth
	{
		get
		{
			return int_11;
		}
		set
		{
			if (int_11 != value)
			{
				int_11 = value;
				class17_0.ExpandAreaWidth = value;
				InvalidateNodesSize();
				((Control)this).Invalidate();
			}
		}
	}

	[Category("Expand Button")]
	[Browsable(true)]
	[Description("Indicates size of the expand button that is used to expand/collapse node.")]
	public Size ExpandButtonSize
	{
		get
		{
			return size_1;
		}
		set
		{
			if (size_1 != value && !size_1.IsEmpty)
			{
				size_1 = value;
				method_11();
			}
		}
	}

	[Category("Expand Button")]
	[Description("Indicates expand button border color.")]
	[Browsable(true)]
	public Color ExpandBorderColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			method_11();
		}
	}

	[Browsable(true)]
	[Category("Expand Button")]
	[Description("Indicates expand button border color.")]
	[DefaultValue(eColorSchemePart.None)]
	public eColorSchemePart ExpandBorderColorSchemePart
	{
		get
		{
			return eColorSchemePart_0;
		}
		set
		{
			eColorSchemePart_0 = value;
			method_11();
		}
	}

	[Browsable(true)]
	[Description("Indicates expand button back color.")]
	[Category("Expand Button")]
	public Color ExpandBackColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			method_11();
		}
	}

	[Category("Expand Button")]
	[DefaultValue(eColorSchemePart.None)]
	[Browsable(true)]
	[Description("Indicates expand button back color.")]
	public eColorSchemePart ExpandBackColorSchemePart
	{
		get
		{
			return eColorSchemePart_1;
		}
		set
		{
			eColorSchemePart_1 = value;
			method_11();
		}
	}

	[Category("Expand Button")]
	[Description("Indicates expand button target gradient back color.")]
	[Browsable(true)]
	public Color ExpandBackColor2
	{
		get
		{
			return color_2;
		}
		set
		{
			color_2 = value;
			method_11();
		}
	}

	[Description("Indicates expand button target gradient back color.")]
	[Category("Expand Button")]
	[DefaultValue(eColorSchemePart.None)]
	[Browsable(true)]
	public eColorSchemePart ExpandBackColor2SchemePart
	{
		get
		{
			return eColorSchemePart_2;
		}
		set
		{
			eColorSchemePart_2 = value;
			method_11();
		}
	}

	[Description("Indicates expand button line color.")]
	[Browsable(true)]
	[Category("Expand Button")]
	public Color ExpandLineColor
	{
		get
		{
			return color_3;
		}
		set
		{
			color_3 = value;
			method_11();
		}
	}

	[DefaultValue(eColorSchemePart.None)]
	[Description("Indicates expand button line color.")]
	[Browsable(true)]
	[Category("Expand Button")]
	public eColorSchemePart ExpandLineColorSchemePart
	{
		get
		{
			return eColorSchemePart_3;
		}
		set
		{
			eColorSchemePart_3 = value;
			method_11();
		}
	}

	[Description("Indicates expand button background gradient angle.")]
	[Category("Expand Button")]
	[Browsable(true)]
	[DefaultValue(0)]
	public int ExpandBackColorGradientAngle
	{
		get
		{
			return int_4;
		}
		set
		{
			if (int_4 != value)
			{
				int_4 = value;
				method_11();
			}
		}
	}

	[Browsable(true)]
	[Category("Expand Button")]
	[Description("Indicates expand button image which is used to indicate that node will be expanded.")]
	[DefaultValue(null)]
	public Image ExpandImage
	{
		get
		{
			return image_0;
		}
		set
		{
			if (image_0 != value)
			{
				image_0 = value;
				if (eExpandButtonType_0 == eExpandButtonType.Image)
				{
					method_11();
				}
			}
		}
	}

	[Category("Expand Button")]
	[DefaultValue(null)]
	[Description("Indicates expand button image which is used to indicate that node will be collapsed.")]
	[Browsable(true)]
	public Image ExpandImageCollapse
	{
		get
		{
			return image_1;
		}
		set
		{
			if (image_1 != value)
			{
				image_1 = value;
				if (eExpandButtonType_0 == eExpandButtonType.Image)
				{
					method_11();
				}
			}
		}
	}

	[Description("Indicates type of the expand button used to expand/collapse nodes.")]
	[Category("Expand Button")]
	[DefaultValue(eExpandButtonType.Rectangle)]
	[Browsable(true)]
	public eExpandButtonType ExpandButtonType
	{
		get
		{
			return eExpandButtonType_0;
		}
		set
		{
			if (eExpandButtonType_0 != value)
			{
				eExpandButtonType_0 = value;
				method_11();
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(null)]
	[Description("Indicates display root node.")]
	[Category("Appearance")]
	public Node DisplayRootNode
	{
		get
		{
			return node_2;
		}
		set
		{
			if (node_2 != value)
			{
				node_2 = value;
				InvalidateNodesSize();
				RecalcLayout();
				((Control)this).Refresh();
			}
		}
	}

	[Description("Indicates width of the command button.")]
	[Category("Command Button")]
	[Browsable(true)]
	[DefaultValue(10)]
	internal int Int32_1
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
			method_42();
		}
	}

	[Category("Command Button")]
	[Browsable(true)]
	[Description("Indicates command button back color.")]
	internal Color Color_0
	{
		get
		{
			return color_4;
		}
		set
		{
			color_4 = value;
			method_42();
		}
	}

	[Browsable(true)]
	[Description("Indicates command button back color.")]
	[DefaultValue(eColorSchemePart.CustomizeBackground)]
	[Category("Command Button")]
	internal eColorSchemePart EColorSchemePart_0
	{
		get
		{
			return eColorSchemePart_4;
		}
		set
		{
			eColorSchemePart_4 = value;
			method_42();
		}
	}

	[Description("Indicates command button target gradient back color.")]
	[Browsable(true)]
	[Category("Command Button")]
	internal Color Color_1
	{
		get
		{
			return color_5;
		}
		set
		{
			color_5 = value;
			method_42();
		}
	}

	[Description("Indicates command button target gradient back color.")]
	[Browsable(true)]
	[DefaultValue(eColorSchemePart.CustomizeBackground2)]
	[Category("Command Button")]
	internal eColorSchemePart EColorSchemePart_1
	{
		get
		{
			return eColorSchemePart_5;
		}
		set
		{
			eColorSchemePart_5 = value;
			method_42();
		}
	}

	[Category("Command Button")]
	[Description("Indicates command button fore color.")]
	[Browsable(true)]
	internal Color Color_2
	{
		get
		{
			return color_6;
		}
		set
		{
			color_6 = value;
			method_42();
		}
	}

	[Browsable(true)]
	[Description("Indicates command button foreground color.")]
	[Category("Command Button")]
	[DefaultValue(eColorSchemePart.CustomizeText)]
	internal eColorSchemePart EColorSchemePart_2
	{
		get
		{
			return eColorSchemePart_6;
		}
		set
		{
			eColorSchemePart_6 = value;
			method_42();
		}
	}

	[Description("Indicates command button background gradient angle.")]
	[Browsable(true)]
	[Category("Expand Button")]
	[DefaultValue(0)]
	internal int Int32_2
	{
		get
		{
			return int_6;
		}
		set
		{
			if (int_6 != value)
			{
				int_6 = value;
				method_11();
			}
		}
	}

	[Browsable(true)]
	[Category("Command Button")]
	[Description("Indicates command button mouse over back color.")]
	internal Color Color_3
	{
		get
		{
			return color_7;
		}
		set
		{
			color_7 = value;
			method_42();
		}
	}

	[DefaultValue(eColorSchemePart.ItemHotBackground)]
	[Browsable(true)]
	[Description("Indicates command button mouse over back color.")]
	[Category("Command Button")]
	internal eColorSchemePart EColorSchemePart_3
	{
		get
		{
			return eColorSchemePart_7;
		}
		set
		{
			eColorSchemePart_7 = value;
			method_42();
		}
	}

	[Category("Command Button")]
	[Browsable(true)]
	[Description("Indicates command button mouse over target gradient back color.")]
	internal Color Color_4
	{
		get
		{
			return color_8;
		}
		set
		{
			color_8 = value;
			method_42();
		}
	}

	[Browsable(true)]
	[Description("Indicates command button mouse over target gradient back color.")]
	[DefaultValue(eColorSchemePart.ItemPressedBackground2)]
	[Category("Command Button")]
	internal eColorSchemePart EColorSchemePart_4
	{
		get
		{
			return eColorSchemePart_8;
		}
		set
		{
			eColorSchemePart_8 = value;
			method_42();
		}
	}

	[Description("Indicates command button mouse over fore color.")]
	[Category("Command Button")]
	[Browsable(true)]
	internal Color Color_5
	{
		get
		{
			return color_9;
		}
		set
		{
			color_9 = value;
			method_42();
		}
	}

	[Browsable(true)]
	[DefaultValue(eColorSchemePart.ItemHotText)]
	[Description("Indicates command button mouse over foreground color.")]
	[Category("Command Button")]
	internal eColorSchemePart EColorSchemePart_5
	{
		get
		{
			return eColorSchemePart_9;
		}
		set
		{
			eColorSchemePart_9 = value;
			method_42();
		}
	}

	[DefaultValue(0)]
	[Category("Expand Button")]
	[Description("Indicates command button mouse over background gradient angle.")]
	[Browsable(true)]
	internal int Int32_3
	{
		get
		{
			return int_7;
		}
		set
		{
			if (int_7 != value)
			{
				int_7 = value;
				method_11();
			}
		}
	}

	[Description("Indicates whether the label text of the node cells can be edited.")]
	[Category("Editing")]
	[Browsable(true)]
	[DefaultValue(false)]
	public bool CellEdit
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

	[Browsable(false)]
	public bool IsCellEditing => bool_6;

	[DefaultValue(true)]
	[Category("Behavior")]
	[Description("Indicates whether keyboard incremental search is enabled.")]
	public bool KeyboardSearchEnabled
	{
		get
		{
			return bool_18;
		}
		set
		{
			bool_18 = value;
		}
	}

	[Category("Behavior")]
	[DefaultValue(1000)]
	[Description("Indicates keyboard search buffer expiration timeout.")]
	public int SearchBufferExpireTimeout
	{
		get
		{
			return int_12;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			int_12 = value;
		}
	}

	[Description("Indicates whether node is highlighted when mouse enters the node.")]
	[DefaultValue(false)]
	[Category("Appearance")]
	public bool HotTracking
	{
		get
		{
			return bool_19;
		}
		set
		{
			bool_19 = value;
			((Control)this).Invalidate();
		}
	}

	private bool Boolean_1 => treeNodeMouseEventHandler_5 != null;

	[Browsable(false)]
	public Node MouseOverNode => node_1;

	[Category("Appearance")]
	[Description("Specifies the default mouse cursor displayed when mouse is over the cell.")]
	[Browsable(true)]
	[DefaultValue(null)]
	public Cursor DefaultCellCursor
	{
		get
		{
			return cursor_1;
		}
		set
		{
			if (cursor_1 != value)
			{
				cursor_1 = value;
			}
		}
	}

	internal ArrayList ArrayList_1 => arrayList_0;

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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool AutoScroll
	{
		get
		{
			return bool_20;
		}
		set
		{
			if (bool_20 != value)
			{
				bool_20 = value;
				method_48();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Size AutoScrollMinSize
	{
		get
		{
			return size_2;
		}
		set
		{
			size_2 = value;
			method_48();
		}
	}

	[Browsable(false)]
	[Description("Indicates location of the auto-scroll position.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
			if (bool_20)
			{
				if (vscrollBarAdv_0 != null && vscrollBarAdv_0.Value != -point_1.Y)
				{
					vscrollBarAdv_0.Value = -point_1.Y;
				}
				if (hscrollBarAdv_0 != null && hscrollBarAdv_0.Value != -point_1.X)
				{
					hscrollBarAdv_0.Value = -point_1.X;
				}
				method_47(bool_25: false);
				((Control)this).Invalidate();
				if (control0_0 != null)
				{
					((Control)control0_0).Invalidate();
				}
			}
		}
	}

	internal bool Boolean_2 => serializeNodeEventHandler_0 != null;

	internal bool Boolean_3 => serializeNodeEventHandler_1 != null;

	[Category("Appearance")]
	[Description("Indicates distance to indent each of the child tree node levels.")]
	[DefaultValue(16)]
	public int Indent
	{
		get
		{
			return int_13;
		}
		set
		{
			if (int_13 != value)
			{
				int_13 = value;
				if (class17_0 is Class18)
				{
					((Class18)class17_0).Int32_2 = value;
				}
				InvalidateNodesSize();
				RecalcLayout();
			}
		}
	}

	[Browsable(false)]
	public bool IsDragDropInProgress => node_3 != null;

	[Browsable(false)]
	public override Image BackgroundImage
	{
		get
		{
			return ((Control)this).get_BackgroundImage();
		}
		set
		{
			((Control)this).set_BackgroundImage(value);
		}
	}

	[Browsable(false)]
	public override ImageLayout BackgroundImageLayout
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_BackgroundImageLayout();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_BackgroundImageLayout(value);
		}
	}

	[DefaultValue("")]
	[Description("Indicates comma separated list of property or column names to display on popup tree control")]
	[Category("Data")]
	public string DisplayMembers
	{
		get
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			if (list_0 != null && list_0.Count != 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < list_0.Count; i++)
				{
					BindingMemberInfo val = list_0[i];
					stringBuilder.Append(((BindingMemberInfo)(ref val)).get_BindingMember());
					if (i + 1 < list_0.Count)
					{
						stringBuilder.Append(',');
					}
				}
				return stringBuilder.ToString();
			}
			return "";
		}
		set
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			List<BindingMemberInfo> list = list_0;
			List<BindingMemberInfo> list2 = null;
			if (!string.IsNullOrEmpty(value))
			{
				list2 = new List<BindingMemberInfo>();
				string[] array = value.Split(new char[1] { ',' });
				for (int i = 0; i < array.Length; i++)
				{
					list2.Add(new BindingMemberInfo(array[i].Trim()));
				}
			}
			try
			{
				method_82(object_1, list2, bool_25: false);
			}
			catch
			{
				list_0 = list;
			}
		}
	}

	[AttributeProvider(typeof(IListSource))]
	[Description("Indicates data source for the ComboTree.")]
	[Category("Data")]
	[RefreshProperties(RefreshProperties.Repaint)]
	[DefaultValue(null)]
	public object DataSource
	{
		get
		{
			return object_1;
		}
		set
		{
			if (value != null && !(value is IList) && !(value is IListSource))
			{
				throw new ArgumentException("Data type is not supported for complex data binding");
			}
			if (object_1 != value)
			{
				try
				{
					method_82(value, list_0, bool_25: false);
				}
				catch
				{
					DisplayMembers = "";
				}
				if (value == null)
				{
					DisplayMembers = "";
				}
			}
		}
	}

	[Description("Indicates whether formatting is applied to the DisplayMembers property of the control.")]
	[DefaultValue(false)]
	public bool FormattingEnabled
	{
		get
		{
			return bool_21;
		}
		set
		{
			if (value != bool_21)
			{
				bool_21 = value;
				RefreshItems();
				OnFormattingEnabledChanged(EventArgs.Empty);
			}
		}
	}

	[Editor("System.Windows.Forms.Design.FormatStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[MergableProperty(false)]
	[DefaultValue("")]
	[Description("Indicates format-specifier characters that indicate how a value is to be displayed.")]
	public string FormatString
	{
		get
		{
			return string_2;
		}
		set
		{
			if (value == null)
			{
				value = string.Empty;
			}
			if (!value.Equals(string_2))
			{
				string_2 = value;
				RefreshItems();
				OnFormatStringChanged(EventArgs.Empty);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DefaultValue(null)]
	[Browsable(false)]
	public IFormatProvider FormatInfo
	{
		get
		{
			return iformatProvider_0;
		}
		set
		{
			if (value != iformatProvider_0)
			{
				iformatProvider_0 = value;
				RefreshItems();
				OnFormatInfoChanged(EventArgs.Empty);
			}
		}
	}

	[DefaultValue("")]
	[Category("Data")]
	[Description("Indicates comma separated list of field or property names that are used for grouping when data-binding is used")]
	public string GroupingMembers
	{
		get
		{
			return string_3;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			string_3 = value;
			OnGroupingMembersChanged();
		}
	}

	[Category("Node Style")]
	[Description("Gets or sets default style for the node.")]
	[Browsable(true)]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[DefaultValue(null)]
	public ElementStyle GroupNodeStyle
	{
		get
		{
			return elementStyle_15;
		}
		set
		{
			if (elementStyle_15 != value)
			{
				elementStyle_15 = value;
				if (currencyManager_0 != null && Nodes != null)
				{
					RefreshItems();
				}
			}
		}
	}

	private bool Boolean_4 => true;

	protected CurrencyManager DataManager => currencyManager_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[Description("Gets or sets the index specifying the currently selected item.")]
	public int SelectedIndex
	{
		get
		{
			if (currencyManager_0 != null)
			{
				if (SelectedNode != null && SelectedNode.BindingIndex >= 0)
				{
					return SelectedNode.BindingIndex;
				}
				return -1;
			}
			if (SelectedNode == null)
			{
				return -1;
			}
			return GetNodeFlatIndex(SelectedNode);
		}
		set
		{
			method_93(value);
		}
	}

	[Description("property to use as the actual value for the items in the control. Applies to data-binding scenarios. SelectedValue property will return the value of selected node as indicated by this property.")]
	[Category("Data")]
	[DefaultValue("")]
	[Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public string ValueMember
	{
		get
		{
			return ((BindingMemberInfo)(ref bindingMemberInfo_0)).get_BindingMember();
		}
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			if (value == null)
			{
				value = "";
			}
			BindingMemberInfo val = default(BindingMemberInfo);
			((BindingMemberInfo)(ref val))._002Ector(value);
			if (!((object)(BindingMemberInfo)(ref val)).Equals((object?)bindingMemberInfo_0))
			{
				if (DisplayMembers.Length == 0)
				{
					List<BindingMemberInfo> list = new List<BindingMemberInfo>();
					list.Add(val);
					method_82(DataSource, list, bool_25: false);
				}
				if (currencyManager_0 != null && value != null && value.Length != 0 && !method_84(val))
				{
					throw new ArgumentException("Invalid value for ValueMember", "value");
				}
				bindingMemberInfo_0 = val;
				OnValueMemberChanged(EventArgs.Empty);
				OnSelectedValueChanged(EventArgs.Empty);
			}
		}
	}

	[Bindable(true)]
	[Category("Data")]
	[DefaultValue(null)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Description("Indicates value of the member property specified by the ValueMember property.")]
	public object SelectedValue
	{
		get
		{
			if (currencyManager_0 != null && SelectedIndex != -1)
			{
				object item = currencyManager_0.get_List()[SelectedIndex];
				return GetPropertyValue(item, ((BindingMemberInfo)(ref bindingMemberInfo_0)).get_BindingField());
			}
			return null;
		}
		set
		{
			if (currencyManager_0 != null)
			{
				string bindingField = ((BindingMemberInfo)(ref bindingMemberInfo_0)).get_BindingField();
				if (string.IsNullOrEmpty(bindingField))
				{
					throw new InvalidOperationException("ValueMember property must be set to be able to set SelectedValue");
				}
				PropertyDescriptor propertyDescriptor = ((BindingManagerBase)currencyManager_0).GetItemProperties().Find(bindingField, ignoreCase: true);
				MethodInfo method = ((object)currencyManager_0).GetType().GetMethod("Find", BindingFlags.Instance | BindingFlags.NonPublic);
				int selectedIndex = -1;
				if ((object)method != null)
				{
					selectedIndex = (int)method.Invoke(currencyManager_0, new object[3] { propertyDescriptor, value, true });
				}
				SelectedIndex = selectedIndex;
			}
		}
	}

	public event MouseEventHandler ColumnHeaderMouseDown
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

	public event MouseEventHandler ColumnHeaderMouseUp
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

	public event AdvTreeCellEventHandler AfterCheck
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			advTreeCellEventHandler_0 = (AdvTreeCellEventHandler)Delegate.Combine(advTreeCellEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			advTreeCellEventHandler_0 = (AdvTreeCellEventHandler)Delegate.Remove(advTreeCellEventHandler_0, value);
		}
	}

	public event AdvTreeCellBeforeCheckEventHandler BeforeCheck
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			advTreeCellBeforeCheckEventHandler_0 = (AdvTreeCellBeforeCheckEventHandler)Delegate.Combine(advTreeCellBeforeCheckEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			advTreeCellBeforeCheckEventHandler_0 = (AdvTreeCellBeforeCheckEventHandler)Delegate.Remove(advTreeCellBeforeCheckEventHandler_0, value);
		}
	}

	public event AdvTreeNodeEventHandler AfterCollapse
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			advTreeNodeEventHandler_0 = (AdvTreeNodeEventHandler)Delegate.Combine(advTreeNodeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			advTreeNodeEventHandler_0 = (AdvTreeNodeEventHandler)Delegate.Remove(advTreeNodeEventHandler_0, value);
		}
	}

	public event AdvTreeNodeCancelEventHandler BeforeCollapse
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			advTreeNodeCancelEventHandler_0 = (AdvTreeNodeCancelEventHandler)Delegate.Combine(advTreeNodeCancelEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			advTreeNodeCancelEventHandler_0 = (AdvTreeNodeCancelEventHandler)Delegate.Remove(advTreeNodeCancelEventHandler_0, value);
		}
	}

	public event AdvTreeNodeEventHandler AfterExpand
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			advTreeNodeEventHandler_1 = (AdvTreeNodeEventHandler)Delegate.Combine(advTreeNodeEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			advTreeNodeEventHandler_1 = (AdvTreeNodeEventHandler)Delegate.Remove(advTreeNodeEventHandler_1, value);
		}
	}

	public event AdvTreeNodeCancelEventHandler BeforeExpand
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			advTreeNodeCancelEventHandler_1 = (AdvTreeNodeCancelEventHandler)Delegate.Combine(advTreeNodeCancelEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			advTreeNodeCancelEventHandler_1 = (AdvTreeNodeCancelEventHandler)Delegate.Remove(advTreeNodeCancelEventHandler_1, value);
		}
	}

	public event CommandButtonEventHandler CommandButtonClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			commandButtonEventHandler_0 = (CommandButtonEventHandler)Delegate.Combine(commandButtonEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			commandButtonEventHandler_0 = (CommandButtonEventHandler)Delegate.Remove(commandButtonEventHandler_0, value);
		}
	}

	public event CellEditEventHandler BeforeCellEdit
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cellEditEventHandler_0 = (CellEditEventHandler)Delegate.Combine(cellEditEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cellEditEventHandler_0 = (CellEditEventHandler)Delegate.Remove(cellEditEventHandler_0, value);
		}
	}

	public event CellEditEventHandler CellEditEnding
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cellEditEventHandler_1 = (CellEditEventHandler)Delegate.Combine(cellEditEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cellEditEventHandler_1 = (CellEditEventHandler)Delegate.Remove(cellEditEventHandler_1, value);
		}
	}

	public event CellEditEventHandler AfterCellEdit
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cellEditEventHandler_2 = (CellEditEventHandler)Delegate.Combine(cellEditEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cellEditEventHandler_2 = (CellEditEventHandler)Delegate.Remove(cellEditEventHandler_2, value);
		}
	}

	public event CellEditEventHandler AfterCellEditComplete
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cellEditEventHandler_3 = (CellEditEventHandler)Delegate.Combine(cellEditEventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cellEditEventHandler_3 = (CellEditEventHandler)Delegate.Remove(cellEditEventHandler_3, value);
		}
	}

	public event AdvTreeNodeCancelEventHandler BeforeNodeSelect
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			advTreeNodeCancelEventHandler_2 = (AdvTreeNodeCancelEventHandler)Delegate.Combine(advTreeNodeCancelEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			advTreeNodeCancelEventHandler_2 = (AdvTreeNodeCancelEventHandler)Delegate.Remove(advTreeNodeCancelEventHandler_2, value);
		}
	}

	public event AdvTreeNodeEventHandler AfterNodeSelect
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			advTreeNodeEventHandler_2 = (AdvTreeNodeEventHandler)Delegate.Combine(advTreeNodeEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			advTreeNodeEventHandler_2 = (AdvTreeNodeEventHandler)Delegate.Remove(advTreeNodeEventHandler_2, value);
		}
	}

	public event AdvTreeNodeEventHandler AfterNodeDeselect
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			advTreeNodeEventHandler_3 = (AdvTreeNodeEventHandler)Delegate.Combine(advTreeNodeEventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			advTreeNodeEventHandler_3 = (AdvTreeNodeEventHandler)Delegate.Remove(advTreeNodeEventHandler_3, value);
		}
	}

	public event TreeNodeCollectionEventHandler BeforeNodeRemove
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeNodeCollectionEventHandler_0 = (TreeNodeCollectionEventHandler)Delegate.Combine(treeNodeCollectionEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeNodeCollectionEventHandler_0 = (TreeNodeCollectionEventHandler)Delegate.Remove(treeNodeCollectionEventHandler_0, value);
		}
	}

	public event TreeNodeCollectionEventHandler AfterNodeRemove
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeNodeCollectionEventHandler_1 = (TreeNodeCollectionEventHandler)Delegate.Combine(treeNodeCollectionEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeNodeCollectionEventHandler_1 = (TreeNodeCollectionEventHandler)Delegate.Remove(treeNodeCollectionEventHandler_1, value);
		}
	}

	public event TreeNodeCollectionEventHandler BeforeNodeInsert
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeNodeCollectionEventHandler_2 = (TreeNodeCollectionEventHandler)Delegate.Combine(treeNodeCollectionEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeNodeCollectionEventHandler_2 = (TreeNodeCollectionEventHandler)Delegate.Remove(treeNodeCollectionEventHandler_2, value);
		}
	}

	public event TreeNodeCollectionEventHandler AfterNodeInsert
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeNodeCollectionEventHandler_3 = (TreeNodeCollectionEventHandler)Delegate.Combine(treeNodeCollectionEventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeNodeCollectionEventHandler_3 = (TreeNodeCollectionEventHandler)Delegate.Remove(treeNodeCollectionEventHandler_3, value);
		}
	}

	public event EventHandler NodeDragStart
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

	public event AdvTreeNodeCancelEventHandler BeforeNodeDragStart
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			advTreeNodeCancelEventHandler_3 = (AdvTreeNodeCancelEventHandler)Delegate.Combine(advTreeNodeCancelEventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			advTreeNodeCancelEventHandler_3 = (AdvTreeNodeCancelEventHandler)Delegate.Remove(advTreeNodeCancelEventHandler_3, value);
		}
	}

	public event TreeDragDropEventHandler BeforeNodeDrop
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeDragDropEventHandler_0 = (TreeDragDropEventHandler)Delegate.Combine(treeDragDropEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeDragDropEventHandler_0 = (TreeDragDropEventHandler)Delegate.Remove(treeDragDropEventHandler_0, value);
		}
	}

	public event TreeDragFeedbackEventHander NodeDragFeedback
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeDragFeedbackEventHander_0 = (TreeDragFeedbackEventHander)Delegate.Combine(treeDragFeedbackEventHander_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeDragFeedbackEventHander_0 = (TreeDragFeedbackEventHander)Delegate.Remove(treeDragFeedbackEventHander_0, value);
		}
	}

	public event TreeDragDropEventHandler AfterNodeDrop
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeDragDropEventHandler_1 = (TreeDragDropEventHandler)Delegate.Combine(treeDragDropEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeDragDropEventHandler_1 = (TreeDragDropEventHandler)Delegate.Remove(treeDragDropEventHandler_1, value);
		}
	}

	public event TreeNodeMouseEventHandler NodeMouseDown
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeNodeMouseEventHandler_0 = (TreeNodeMouseEventHandler)Delegate.Combine(treeNodeMouseEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeNodeMouseEventHandler_0 = (TreeNodeMouseEventHandler)Delegate.Remove(treeNodeMouseEventHandler_0, value);
		}
	}

	public event TreeNodeMouseEventHandler NodeMouseUp
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeNodeMouseEventHandler_1 = (TreeNodeMouseEventHandler)Delegate.Combine(treeNodeMouseEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeNodeMouseEventHandler_1 = (TreeNodeMouseEventHandler)Delegate.Remove(treeNodeMouseEventHandler_1, value);
		}
	}

	public event TreeNodeMouseEventHandler NodeMouseMove
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeNodeMouseEventHandler_2 = (TreeNodeMouseEventHandler)Delegate.Combine(treeNodeMouseEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeNodeMouseEventHandler_2 = (TreeNodeMouseEventHandler)Delegate.Remove(treeNodeMouseEventHandler_2, value);
		}
	}

	public event TreeNodeMouseEventHandler NodeMouseEnter
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeNodeMouseEventHandler_3 = (TreeNodeMouseEventHandler)Delegate.Combine(treeNodeMouseEventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeNodeMouseEventHandler_3 = (TreeNodeMouseEventHandler)Delegate.Remove(treeNodeMouseEventHandler_3, value);
		}
	}

	public event TreeNodeMouseEventHandler NodeMouseLeave
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeNodeMouseEventHandler_4 = (TreeNodeMouseEventHandler)Delegate.Combine(treeNodeMouseEventHandler_4, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeNodeMouseEventHandler_4 = (TreeNodeMouseEventHandler)Delegate.Remove(treeNodeMouseEventHandler_4, value);
		}
	}

	public event TreeNodeMouseEventHandler NodeMouseHover
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeNodeMouseEventHandler_5 = (TreeNodeMouseEventHandler)Delegate.Combine(treeNodeMouseEventHandler_5, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeNodeMouseEventHandler_5 = (TreeNodeMouseEventHandler)Delegate.Remove(treeNodeMouseEventHandler_5, value);
		}
	}

	public event TreeNodeMouseEventHandler NodeClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeNodeMouseEventHandler_6 = (TreeNodeMouseEventHandler)Delegate.Combine(treeNodeMouseEventHandler_6, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeNodeMouseEventHandler_6 = (TreeNodeMouseEventHandler)Delegate.Remove(treeNodeMouseEventHandler_6, value);
		}
	}

	public event TreeNodeMouseEventHandler NodeDoubleClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeNodeMouseEventHandler_7 = (TreeNodeMouseEventHandler)Delegate.Combine(treeNodeMouseEventHandler_7, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeNodeMouseEventHandler_7 = (TreeNodeMouseEventHandler)Delegate.Remove(treeNodeMouseEventHandler_7, value);
		}
	}

	public event SerializeNodeEventHandler SerializeNode
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			serializeNodeEventHandler_0 = (SerializeNodeEventHandler)Delegate.Combine(serializeNodeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			serializeNodeEventHandler_0 = (SerializeNodeEventHandler)Delegate.Remove(serializeNodeEventHandler_0, value);
		}
	}

	public event SerializeNodeEventHandler DeserializeNode
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			serializeNodeEventHandler_1 = (SerializeNodeEventHandler)Delegate.Combine(serializeNodeEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			serializeNodeEventHandler_1 = (SerializeNodeEventHandler)Delegate.Remove(serializeNodeEventHandler_1, value);
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

	public event CustomCellEditorEventHandler ProvideCustomCellEditor
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			customCellEditorEventHandler_0 = (CustomCellEditorEventHandler)Delegate.Combine(customCellEditorEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			customCellEditorEventHandler_0 = (CustomCellEditorEventHandler)Delegate.Remove(customCellEditorEventHandler_0, value);
		}
	}

	[Description("Occurs when the DataSource changes.")]
	public event EventHandler DataSourceChanged
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

	[Description("Occurs when the DisplayMembers property changes")]
	public event EventHandler DisplayMembersChanged
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

	[Description("Occurs when the control is bound to a data value that need to be converted.")]
	public event TreeConvertEventHandler Format
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			treeConvertEventHandler_0 = (TreeConvertEventHandler)Delegate.Combine(treeConvertEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			treeConvertEventHandler_0 = (TreeConvertEventHandler)Delegate.Remove(treeConvertEventHandler_0, value);
		}
	}

	[Description("Occurs when FormattingEnabled property changes.")]
	public event EventHandler FormattingEnabledChanged
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

	[Description("Occurs when FormatString property changes.")]
	public event EventHandler FormatStringChanged
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

	[Description("Occurs when FormatInfo property has changed.")]
	public event EventHandler FormatInfoChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_5 = (EventHandler)Delegate.Combine(eventHandler_5, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_5 = (EventHandler)Delegate.Remove(eventHandler_5, value);
		}
	}

	[Description("Occurs when a Node for an data-bound object item has been created and provides you with opportunity to modify the node")]
	public event DataNodeEventHandler DataNodeCreated
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			dataNodeEventHandler_0 = (DataNodeEventHandler)Delegate.Combine(dataNodeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			dataNodeEventHandler_0 = (DataNodeEventHandler)Delegate.Remove(dataNodeEventHandler_0, value);
		}
	}

	[Description("Occurs when a group Node is created as result of GroupingMembers property setting and provides you with opportunity to modify the node")]
	public event DataNodeEventHandler GroupNodeCreated
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			dataNodeEventHandler_1 = (DataNodeEventHandler)Delegate.Combine(dataNodeEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			dataNodeEventHandler_1 = (DataNodeEventHandler)Delegate.Remove(dataNodeEventHandler_1, value);
		}
	}

	[Description("Occurs when value of ValueMember property has changed.")]
	public event EventHandler ValueMemberChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_6 = (EventHandler)Delegate.Combine(eventHandler_6, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_6 = (EventHandler)Delegate.Remove(eventHandler_6, value);
		}
	}

	[Description("Occurs when value of SelectedValue property has changed.")]
	public event EventHandler SelectedValueChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_7 = (EventHandler)Delegate.Combine(eventHandler_7, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_7 = (EventHandler)Delegate.Remove(eventHandler_7, value);
		}
	}

	[Description("Occurs when value of SelectedValue property has changed.")]
	public event EventHandler SelectedIndexChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_8 = (EventHandler)Delegate.Combine(eventHandler_8, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_8 = (EventHandler)Delegate.Remove(eventHandler_8, value);
		}
	}

	[Description("Occurs when ColumnHeader is automatically created by control as result of data binding and provides you with opportunity to modify it.")]
	public event DataColumnEventHandler DataColumnCreated
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			dataColumnEventHandler_0 = (DataColumnEventHandler)Delegate.Combine(dataColumnEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			dataColumnEventHandler_0 = (DataColumnEventHandler)Delegate.Remove(dataColumnEventHandler_0, value);
		}
	}

	public AdvTree()
	{
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		char pathSeparator = Path.PathSeparator;
		string_0 = pathSeparator.ToString();
		selectedNodesCollection_0 = new SelectedNodesCollection();
		int_2 = -1;
		bool_2 = true;
		bool_3 = true;
		bool_4 = true;
		int_3 = 4;
		size_0 = new Size(8, 8);
		size_1 = Size.Empty;
		color_0 = Color.Empty;
		eColorSchemePart_0 = eColorSchemePart.None;
		color_1 = Color.Empty;
		eColorSchemePart_1 = eColorSchemePart.None;
		color_2 = Color.Empty;
		eColorSchemePart_2 = eColorSchemePart.None;
		color_3 = Color.Empty;
		eColorSchemePart_3 = eColorSchemePart.None;
		eExpandButtonType_0 = eExpandButtonType.Rectangle;
		int_5 = 10;
		color_4 = Color.Empty;
		eColorSchemePart_4 = eColorSchemePart.CustomizeBackground;
		color_5 = Color.Empty;
		eColorSchemePart_5 = eColorSchemePart.CustomizeBackground2;
		color_6 = Color.Empty;
		eColorSchemePart_6 = eColorSchemePart.CustomizeText;
		int_6 = 90;
		color_7 = Color.Empty;
		eColorSchemePart_7 = eColorSchemePart.ItemHotBackground;
		color_8 = Color.Empty;
		eColorSchemePart_8 = eColorSchemePart.ItemHotBackground2;
		color_9 = Color.Empty;
		eColorSchemePart_9 = eColorSchemePart.ItemHotText;
		int_7 = 90;
		bool_7 = true;
		point_0 = Point.Empty;
		int_8 = 32;
		int_9 = 32;
		elementStyle_12 = new ElementStyle();
		arrayList_0 = new ArrayList();
		float_0 = 1f;
		bool_9 = true;
		bool_10 = true;
		int_10 = 3;
		bool_12 = true;
		color_10 = Color.Empty;
		bool_15 = true;
		eSelectionStyle_0 = eSelectionStyle.HighlightCells;
		bool_16 = true;
		int_11 = 24;
		bool_18 = true;
		int_12 = 1000;
		string_1 = "";
		size_2 = Size.Empty;
		point_1 = Point.Empty;
		int_13 = 16;
		string_2 = "";
		hashtable_0 = new Hashtable();
		string_3 = "";
		bindingMemberInfo_0 = default(BindingMemberInfo);
		((ScrollableControl)this)._002Ector();
		if (!ColorFunctions.bool_0)
		{
			Class92.smethod_5();
			Class92.smethod_6();
			ColorFunctions.LoadColors();
		}
		selectedNodesCollection_0.advTree_1 = this;
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)65536, true);
		((Control)this).SetStyle((ControlStyles)512, true);
		method_0();
		elementStyle_12.StyleChanged += elementStyle_12_StyleChanged;
		elementStyle_12.AdvTree_0 = this;
		columnHeaderCollection_0.AdvTree_0 = this;
		class17_0 = new Class18(this, ((Control)this).get_ClientRectangle());
		class17_0.NodeVerticalSpacing = int_10;
		class17_0.LeftRight = ((Control)this).RtlTranslateLeftRight((LeftRightAlignment)0);
		Class15.smethod_31();
		nodeDisplay_0 = new NodeTreeDisplay(this);
		headersCollection_0 = new HeadersCollection();
		nodeCollection_0.AdvTree_0 = this;
		elementStyleCollection_0.AdvTree_0 = this;
		colorScheme_0 = new ColorScheme(eColorSchemeStyle.Office2007);
		size_1 = method_12();
		((Control)this).set_AllowDrop(true);
		((Control)this).set_IsAccessible(true);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (container_0 != null)
			{
				container_0.Dispose();
			}
			Timer val = timer_0;
			timer_0 = null;
			if (val != null)
			{
				val.Stop();
				((Component)(object)val).Dispose();
			}
		}
		((Control)this).Dispose(disposing);
	}

	private void method_0()
	{
		container_0 = new Container();
	}

	protected override void OnLeave(EventArgs e)
	{
		if (bool_13)
		{
			foreach (Node item in selectedNodesCollection_0)
			{
				method_7(item);
			}
		}
		else if (SelectedNode != null)
		{
			method_7(SelectedNode);
		}
		((Control)this).OnLeave(e);
	}

	protected override void OnEnter(EventArgs e)
	{
		if (bool_13)
		{
			foreach (Node item in selectedNodesCollection_0)
			{
				method_7(item);
			}
		}
		else if (SelectedNode != null)
		{
			method_7(SelectedNode);
		}
		((Control)this).OnEnter(e);
	}

	public TreeRenderer GetRenderer()
	{
		if (eNodeRenderMode_0 == eNodeRenderMode.Default)
		{
			if (nodeDisplay_0 is NodeTreeDisplay)
			{
				return ((NodeTreeDisplay)nodeDisplay_0).SystemRenderer;
			}
			return null;
		}
		return treeRenderer_0;
	}

	public Graphics CreateGraphics()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		Graphics val = ((Control)this).CreateGraphics();
		if (bool_2)
		{
			val.set_SmoothingMode((SmoothingMode)4);
			if (!SystemInformation.get_IsFontSmoothingEnabled())
			{
				val.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
		}
		return val;
	}

	internal void method_1(bool bool_25)
	{
		if (bool_25)
		{
			if (control0_0 == null)
			{
				control0_0 = new Control0();
				control0_0.ColumnHeaderCollection_0 = Columns;
				((Control)this).get_Controls().Add((Control)(object)control0_0);
			}
		}
		else if (control0_0 != null)
		{
			control0_0.ColumnHeaderCollection_0 = null;
			((Control)this).get_Controls().Remove((Control)(object)control0_0);
			((Component)(object)control0_0).Dispose();
			control0_0 = null;
		}
		method_50();
	}

	internal bool method_2(int int_14, int int_15)
	{
		if (!columnHeaderCollection_0.Bounds.Contains(int_14, int_15))
		{
			return false;
		}
		ColumnHeader columnHeader = method_4(int_14, int_15, columnHeaderCollection_0);
		return columnHeader != null;
	}

	internal ColumnHeader method_3(int int_14, int int_15, ColumnHeaderCollection columnHeaderCollection_2)
	{
		Point pt = new Point(int_14, int_15);
		Point pos = Point.Empty;
		if (AutoScroll)
		{
			pos = method_18();
			if (columnHeaderCollection_2.ParentNode == null)
			{
				pos.Y = 0;
			}
		}
		Rectangle bounds = columnHeaderCollection_2.Bounds;
		bounds.Offset(pos);
		if (!bounds.Contains(pt))
		{
			return null;
		}
		foreach (ColumnHeader item in columnHeaderCollection_2)
		{
			Rectangle bounds2 = item.Bounds;
			bounds2.Offset(pos);
			if (bounds2.Contains(pt))
			{
				return item;
			}
		}
		return null;
	}

	private ColumnHeader method_4(int int_14, int int_15, ColumnHeaderCollection columnHeaderCollection_2)
	{
		Point pt = new Point(int_14, int_15);
		Point pos = Point.Empty;
		if (AutoScroll)
		{
			pos = method_18();
			if (columnHeaderCollection_2.ParentNode == null)
			{
				pos.Y = 0;
			}
		}
		Rectangle bounds = columnHeaderCollection_2.Bounds;
		bounds.Offset(pos);
		if (!bounds.Contains(pt))
		{
			return null;
		}
		foreach (ColumnHeader item in columnHeaderCollection_2)
		{
			Rectangle rectangle = new Rectangle(item.Bounds.Right - 4, item.Bounds.Y, 6, item.Bounds.Height);
			rectangle.Offset(pos);
			if (rectangle.Contains(pt))
			{
				return item;
			}
		}
		return null;
	}

	internal void method_5(int int_14, int int_15)
	{
		method_6(int_14, int_15, columnHeaderCollection_0);
	}

	private void method_6(int int_14, int int_15, ColumnHeaderCollection columnHeaderCollection_2)
	{
		ColumnHeader columnHeader = method_4(int_14, int_15, columnHeaderCollection_2);
		if (columnHeader != null)
		{
			((Control)this).set_Capture(true);
			columnHeader_0 = columnHeader;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeGridLinesColor()
	{
		return !color_10.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetGridLinesColor()
	{
		GridLinesColor = Color.Empty;
	}

	internal void method_7(Node node_4)
	{
		if (node_4 == null)
		{
			return;
		}
		Rectangle r = ((node_4 != node_3 || node_3.Parent != null) ? NodeDisplay.smethod_0(Enum4.const_5, node_4, nodeDisplay_0.Offset) : node_3.BoundsRelative);
		if (node_4.FullRowBackground)
		{
			r.Width = ((Control)this).get_Width();
		}
		if (bool_4)
		{
			r.Inflate(int_3, int_3);
			if (eSelectionStyle_0 == eSelectionStyle.FullRowSelect)
			{
				r.X = ((Control)this).get_ClientRectangle().X;
				r.Width = ((Control)this).get_ClientRectangle().Width;
			}
		}
		r = GetScreenRectangle(r);
		((Control)this).Invalidate(r);
	}

	public Node FindNodeByName(string name)
	{
		return Class15.smethod_32(this, name);
	}

	public Node FindNodeByDataKey(object key)
	{
		return Class15.smethod_35(this, key);
	}

	public Node FindNodeByBindingIndex(int bindingIndex)
	{
		return Class15.smethod_37(this, bindingIndex);
	}

	public Node FindNodeByText(string text)
	{
		return Class15.smethod_44(this, text, null, bool_0: true);
	}

	public Node FindNodeByText(string text, bool ignoreCase)
	{
		return Class15.smethod_44(this, text, null, ignoreCase);
	}

	public Node FindNodeByText(string text, Node startFromNode, bool ignoreCase)
	{
		return Class15.smethod_44(this, text, startFromNode, ignoreCase);
	}

	internal void method_8()
	{
		bool_0 = true;
	}

	private void method_9()
	{
		InvalidateNodesSize();
		method_8();
		((Control)this).Invalidate();
	}

	internal static eDotNetBarStyle smethod_0(eColorSchemeStyle eColorSchemeStyle_0)
	{
		return eColorSchemeStyle_0 switch
		{
			eColorSchemeStyle.Office2003 => eDotNetBarStyle.Office2003, 
			eColorSchemeStyle.VS2005 => eDotNetBarStyle.VS2005, 
			_ => eDotNetBarStyle.Office2007, 
		};
	}

	internal static eColorSchemeStyle smethod_1(eDotNetBarStyle eDotNetBarStyle_0)
	{
		return eDotNetBarStyle_0 switch
		{
			eDotNetBarStyle.Office2003 => eColorSchemeStyle.Office2003, 
			eDotNetBarStyle.VS2005 => eColorSchemeStyle.VS2005, 
			_ => eColorSchemeStyle.Office2007, 
		};
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeExpandButtonSize()
	{
		return size_1 != method_12();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetExpandButtonSize()
	{
		ExpandButtonSize = method_12();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeExpandBorderColor()
	{
		if (!color_0.IsEmpty)
		{
			return eColorSchemePart_0 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetExpandBorderColor()
	{
		ExpandBorderColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeExpandBackColor()
	{
		if (!color_1.IsEmpty)
		{
			return eColorSchemePart_1 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetExpandBackColor()
	{
		ExpandBackColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeExpandBackColor2()
	{
		if (!color_2.IsEmpty)
		{
			return eColorSchemePart_2 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetExpandBackColor2()
	{
		ExpandBackColor2 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeExpandLineColor()
	{
		if (!color_3.IsEmpty)
		{
			return eColorSchemePart_3 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetExpandLineColor()
	{
		ExpandLineColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal bool ShouldSerializeCommandBackColor()
	{
		if (!color_4.IsEmpty)
		{
			return eColorSchemePart_4 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal void ResetCommandBackColor()
	{
		Color_0 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal bool ShouldSerializeCommandBackColor2()
	{
		if (!color_5.IsEmpty)
		{
			return eColorSchemePart_5 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal void ResetCommandBackColor2()
	{
		Color_1 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal bool ShouldSerializeCommandForeColor()
	{
		if (!color_6.IsEmpty)
		{
			return eColorSchemePart_6 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal void ResetCommandForeColor()
	{
		Color_2 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal bool ShouldSerializeCommandMouseOverBackColor()
	{
		if (!color_7.IsEmpty)
		{
			return eColorSchemePart_7 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal void ResetCommandMouseOverBackColor()
	{
		Color_3 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal bool ShouldSerializeCommandMouseOverBackColor2()
	{
		if (!color_8.IsEmpty)
		{
			return eColorSchemePart_8 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal void ResetCommandMouseOverBackColor2()
	{
		Color_4 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal bool ShouldSerializeCommandMouseOverForeColor()
	{
		if (!color_9.IsEmpty)
		{
			return eColorSchemePart_9 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal void ResetCommandMouseOverForeColor()
	{
		Color_5 = Color.Empty;
	}

	public int GetNodeFlatIndex(Node node)
	{
		return Class15.smethod_42(this, node);
	}

	public Node GetNodeByFlatIndex(int index)
	{
		return Class15.smethod_43(this, index);
	}

	protected override AccessibleObject CreateAccessibilityInstance()
	{
		bool_17 = true;
		return (AccessibleObject)(object)new AdvTreeAccessibleObject(this);
	}

	internal Color method_10(Color color_11, eColorSchemePart eColorSchemePart_10)
	{
		if (eColorSchemePart_10 == eColorSchemePart.None)
		{
			return color_11;
		}
		ColorScheme colorScheme = ColorScheme_0;
		if (colorScheme == null)
		{
			return color_11;
		}
		return (Color)colorScheme.GetType().GetProperty(eColorSchemePart_10.ToString())!.GetValue(colorScheme, null);
	}

	private void method_11()
	{
		class17_0.Size_0 = size_1;
		InvalidateNodesSize();
		RecalcLayout();
		((Control)this).Refresh();
	}

	private Size method_12()
	{
		return size_0;
	}

	private void elementStyle_12_StyleChanged(object sender, EventArgs e)
	{
		InvalidateNodesSize();
		if (((Component)this).DesignMode)
		{
			RecalcLayout();
		}
		method_13();
	}

	private void method_13()
	{
		if (((Component)this).DesignMode)
		{
			((Control)this).Refresh();
		}
	}

	private void method_14()
	{
		class17_0.NodeHorizontalSpacing = int_8;
		class17_0.NodeVerticalSpacing = int_9;
		RecalcLayout();
		method_13();
	}

	private void method_15(object sender, EventArgs e)
	{
		method_13();
	}

	public void CollapseAll()
	{
		BeginUpdate();
		try
		{
			foreach (Node node in Nodes)
			{
				node.CollapseAll();
			}
		}
		finally
		{
			EndUpdate(performLayoutAndRefresh: true);
		}
	}

	public void ExpandAll()
	{
		BeginUpdate();
		try
		{
			foreach (Node node in Nodes)
			{
				node.ExpandAll();
			}
		}
		finally
		{
			EndUpdate(performLayoutAndRefresh: true);
		}
	}

	private void method_16(Graphics graphics_0)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		TreeRenderer treeRenderer = TreeRenderer_0;
		if (treeRenderer != null)
		{
			TreeRenderer_0.DrawTreeBackground(new TreeBackgroundRendererEventArgs(graphics_0, this));
			return;
		}
		if (!((Control)this).get_BackColor().IsEmpty)
		{
			SolidBrush val = new SolidBrush(((Control)this).get_BackColor());
			try
			{
				graphics_0.FillRectangle((Brush)(object)val, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		ElementStyleDisplayInfo elementStyleDisplayInfo = new ElementStyleDisplayInfo();
		elementStyleDisplayInfo.Bounds = ((Control)this).get_DisplayRectangle();
		elementStyleDisplayInfo.Graphics = graphics_0;
		ElementStyle elementStyle = (elementStyleDisplayInfo.Style = ElementStyleDisplay.smethod_5(elementStyle_12));
		ElementStyleDisplay.Paint(elementStyleDisplayInfo);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		if (!SuspendPaint)
		{
			if (bool_0)
			{
				RecalcLayout();
			}
			if (((Control)this).get_BackColor().A < byte.MaxValue)
			{
				((ScrollableControl)this).OnPaintBackground(e);
			}
			Graphics graphics = e.get_Graphics();
			method_16(graphics);
			Point point_ = Point.Empty;
			bool bool_ = false;
			if (AutoScroll)
			{
				point_ = method_18();
				bool_ = true;
			}
			SmoothingMode smoothingMode = graphics.get_SmoothingMode();
			TextRenderingHint textRenderingHint = graphics.get_TextRenderingHint();
			if (bool_2)
			{
				graphics.set_SmoothingMode((SmoothingMode)4);
				graphics.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
			Rectangle clip = method_17();
			if (vscrollBarAdv_0 != null)
			{
				clip.Width -= ((Control)vscrollBarAdv_0).get_Width();
			}
			if (hscrollBarAdv_0 != null)
			{
				clip.Height -= ((Control)hscrollBarAdv_0).get_Height();
			}
			graphics.SetClip(clip);
			method_19(graphics, e.get_ClipRectangle(), point_, bool_, float_0);
			if (bool_2)
			{
				graphics.set_SmoothingMode(smoothingMode);
				graphics.set_TextRenderingHint(textRenderingHint);
			}
		}
	}

	internal Rectangle method_17()
	{
		return Class52.smethod_12(BackgroundStyle, ((Control)this).get_ClientRectangle());
	}

	internal Point method_18()
	{
		Point autoScrollPosition = AutoScrollPosition;
		if (SelectionBoxStyle == eSelectionStyle.NodeMarker)
		{
			autoScrollPosition.Y += Int32_0;
			autoScrollPosition.X += Int32_0;
		}
		return autoScrollPosition;
	}

	private void method_19(Graphics graphics_0, Rectangle rectangle_0, Point point_2, bool bool_25, float float_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		if (Class15.smethod_31())
		{
			StringFormat val = new StringFormat(StringFormat.get_GenericDefault());
			val.set_Alignment((StringAlignment)1);
			val.set_FormatFlags((StringFormatFlags)(val.get_FormatFlags() & ~(val.get_FormatFlags() & 0x1000)));
			graphics_0.DrawString("Thank you very much for trying AdvTree. Unfortunately your trial period is over. To continue using AdvTree you should purchase license at http://www.devcomponents.com", new Font(((Control)this).get_Font().get_FontFamily(), 12f), SystemBrushes.get_Highlight(), (RectangleF)((Control)this).get_ClientRectangle(), val);
			val.Dispose();
			return;
		}
		if (float_1 != 1f)
		{
			Matrix transform = method_53(float_1);
			graphics_0.set_Transform(transform);
			rectangle_0 = GetLayoutRectangle(rectangle_0);
		}
		if (bool_25)
		{
			nodeDisplay_0.Offset = point_2;
		}
		nodeDisplay_0.Paint(graphics_0, rectangle_0);
		Font val2 = new Font(((Control)this).get_Font().get_FontFamily(), 7f);
		SolidBrush val3 = new SolidBrush(Color.FromArgb(220, SystemColors.Highlight));
		StringFormat val4 = new StringFormat(StringFormat.get_GenericDefault());
		val4.set_Alignment((StringAlignment)1);
		graphics_0.DrawString("", val2, (Brush)(object)val3, (float)(((Control)this).get_DisplayRectangle().X + ((Control)this).get_DisplayRectangle().Width / 2), (float)(((Control)this).get_DisplayRectangle().Bottom - 14), val4);
		((Brush)val3).Dispose();
		val4.Dispose();
		val2.Dispose();
	}

	public void PaintTo(Graphics g, bool background)
	{
		PaintTo(g, background, Rectangle.Empty);
	}

	public void PaintTo(Graphics g, bool background, Rectangle clipRectangle)
	{
		if (background)
		{
			method_16(g);
		}
		Point lockedOffset = nodeDisplay_0.GetLockedOffset();
		Point offset = nodeDisplay_0.Offset;
		Point empty = Point.Empty;
		class17_0.Graphics_0 = g;
		try
		{
			class17_0.PerformLayout();
		}
		finally
		{
			class17_0.Graphics_0 = null;
		}
		method_78();
		nodeDisplay_0.SetLockedOffset(empty);
		try
		{
			method_19(g, clipRectangle, Point.Empty, bool_25: true, 1f);
		}
		finally
		{
			class17_0.PerformLayout();
			nodeDisplay_0.SetLockedOffset(lockedOffset);
			if (lockedOffset.IsEmpty)
			{
				nodeDisplay_0.Offset = offset;
			}
		}
	}

	protected override void OnRightToLeftChanged(EventArgs e)
	{
		RecalcLayout();
		((ScrollableControl)this).OnRightToLeftChanged(e);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		if (!((Component)this).DesignMode)
		{
			RemindForm remindForm = new RemindForm();
			remindForm.method_0();
			((Component)(object)remindForm).Dispose();
		}
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_67();
		((Control)this).OnHandleDestroyed(e);
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		if (((Control)this).get_Size().Width != 0 && ((Control)this).get_Size().Height != 0)
		{
			if (columnHeaderCollection_0.Count > 0 && columnHeaderCollection_0.bool_0)
			{
				InvalidateNodesSize();
			}
			RecalcLayout();
		}
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		if (bool_18 && char.IsLetterOrDigit(e.get_KeyChar()))
		{
			Node selectedNode = SelectedNode;
			if (selectedNode == null || !selectedNode.CheckBoxVisible || !selectedNode.Enabled || e.get_KeyChar() != ' ' || selectedNode == null)
			{
				e.set_Handled(ProcessKeyboardCharacter(e.get_KeyChar()));
			}
		}
		((Control)this).OnKeyPress(e);
	}

	protected virtual bool ProcessKeyboardCharacter(char p)
	{
		string text = method_20(p.ToString());
		Node node = FindNodeByText(text, SelectedNode, ignoreCase: true);
		if (node == null && SelectedNode != null)
		{
			node = FindNodeByText(text, ignoreCase: true);
		}
		SelectNode(node, eTreeAction.Keyboard);
		return false;
	}

	private string method_20(string string_4)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		if (int_12 <= 0)
		{
			return string_4;
		}
		if (timer_0 == null)
		{
			timer_0 = new Timer();
			timer_0.set_Interval(int_12);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			timer_0.Start();
		}
		else
		{
			timer_0.Start();
		}
		string_1 += string_4;
		return string_1;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		string_1 = "";
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		Class1.smethod_0(this, e);
		((Control)this).OnKeyDown(e);
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Invalid comparison between Unknown and I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Invalid comparison between Unknown and I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Invalid comparison between Unknown and I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Invalid comparison between Unknown and I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Invalid comparison between Unknown and I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Invalid comparison between Unknown and I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Invalid comparison between Unknown and I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_6)
		{
			if (AutoScroll && AutoScrollMinSize.Height > ((Control)this).get_ClientRectangle().Height && vscrollBarAdv_0 != null)
			{
				if ((int)keyData == 131112)
				{
					AutoScrollPosition = new Point(AutoScrollPosition.X, Math.Max(AutoScrollPosition.Y - vscrollBarAdv_0.SmallChange, -(vscrollBarAdv_0.Maximum - vscrollBarAdv_0.LargeChange)));
					return true;
				}
				if ((int)keyData == 131110)
				{
					AutoScrollPosition = new Point(AutoScrollPosition.X, Math.Min(0, AutoScrollPosition.Y + vscrollBarAdv_0.SmallChange));
					return true;
				}
			}
			if ((int)keyData == 37 || (int)keyData == 39 || (int)keyData == 38 || (int)keyData == 65574 || (int)keyData == 40 || (int)keyData == 65576 || (int)keyData == 35 || (int)keyData == 36 || (int)keyData == 34 || (int)keyData == 33)
			{
				Class1.smethod_4(this, new KeyEventArgs(keyData));
				return true;
			}
		}
		return ((Control)this).ProcessCmdKey(ref msg, keyData);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		if (!((Control)this).get_Focused())
		{
			((Control)this).Focus();
		}
		Point layoutPosition = GetLayoutPosition(e);
		if (bool_6)
		{
			int_1 = 0;
			if (!method_33(eTreeAction.Mouse))
			{
				return;
			}
		}
		Class23 @class = (((int)e.get_Button() != 1048576 || !bool_16) ? Class15.smethod_22(this, layoutPosition.X, layoutPosition.Y) : Class15.smethod_24(this, layoutPosition.Y));
		if (columnHeader_2 != null && (int)e.get_Button() == 1048576 && AllowUserToResizeColumns)
		{
			if (@class.columnHeaderCollection_0 != null)
			{
				method_6(layoutPosition.X, layoutPosition.Y, @class.columnHeaderCollection_0);
			}
		}
		else if (@class.columnHeaderCollection_0 != null)
		{
			ColumnHeader columnHeader = method_3(layoutPosition.X, layoutPosition.Y, @class.columnHeaderCollection_0);
			if (columnHeader != null)
			{
				columnHeader_1 = columnHeader;
				columnHeader.OnMouseDown(e);
			}
		}
		Node node = @class.node_0;
		if (node != null)
		{
			method_27(node, e, nodeDisplay_0.Offset);
		}
		point_0 = layoutPosition;
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		if (columnHeader_1 != null)
		{
			columnHeader_1.OnMouseUp(e);
		}
		columnHeader_1 = null;
		if (columnHeader_0 != null)
		{
			columnHeader_0 = null;
			((Control)this).set_Capture(false);
		}
		else
		{
			method_21();
			method_28(e);
		}
	}

	protected override void OnClick(EventArgs e)
	{
		((Control)this).OnClick(e);
		method_29(e);
	}

	protected override void OnDoubleClick(EventArgs e)
	{
		((Control)this).OnDoubleClick(e);
		if (SelectedNode == null)
		{
			return;
		}
		Point mousePosition = ((Control)this).PointToClient(Control.get_MousePosition());
		mousePosition = GetLayoutPosition(mousePosition);
		if (!SelectedNode.Bounds.Contains(mousePosition))
		{
			return;
		}
		Cell cellAt = GetCellAt(mousePosition);
		bool flag = true;
		if (cellAt != null)
		{
			Rectangle rectangle = NodeDisplay.smethod_2(Enum5.const_0, cellAt, nodeDisplay_0.Offset);
			if (!rectangle.IsEmpty && rectangle.Contains(mousePosition))
			{
				flag = false;
			}
		}
		Node selectedNode = SelectedNode;
		if (flag && (selectedNode.HasChildNodes || selectedNode.ExpandVisibility == eNodeExpandVisibility.Visible))
		{
			selectedNode.Toggle(eTreeAction.Mouse);
		}
		InvokeNodeDoubleClick(new TreeNodeMouseEventArgs(selectedNode, (MouseButtons)1048576, 2, 0, mousePosition.X, mousePosition.Y));
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		if (node_1 != null)
		{
			method_26(null);
		}
	}

	protected override void OnMouseHover(EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnMouseHover(e);
		if (node_1 != null && (Boolean_1 || node_1.FireHoverEvent))
		{
			Point mousePosition = ((Control)this).PointToClient(Control.get_MousePosition());
			mousePosition = GetLayoutPosition(mousePosition);
			InvokeNodeMouseHover(new TreeNodeMouseEventArgs(node_1, Control.get_MouseButtons(), 0, 0, mousePosition.X, mousePosition.Y));
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		((Control)this).OnMouseMove(e);
		bool flag = false;
		Point layoutPosition = GetLayoutPosition(e);
		if (columnHeader_0 != null)
		{
			Point pos = Point.Empty;
			if (AutoScroll)
			{
				pos = method_18();
				if (columnHeaderCollection_1 == null)
				{
					pos.Y = 0;
				}
			}
			Rectangle bounds = columnHeader_0.Bounds;
			bounds.Offset(pos);
			bounds = GetScreenRectangle(bounds);
			int num = Math.Max(Math.Max(2, columnHeader_0.MinimumWidth), layoutPosition.X - bounds.X);
			if (num != columnHeader_0.Width.Absolute)
			{
				columnHeader_0.Width.Absolute = num;
				if (columnHeaderCollection_1 != null)
				{
					InvalidateNodeSize(columnHeaderCollection_1.ParentNode);
				}
				((Control)this).Update();
				if (control0_0 != null)
				{
					((Control)control0_0).Refresh();
				}
			}
			return;
		}
		if ((int)e.get_Button() == 1048576 && !bool_6 && bool_7 && node_1 != null && node_3 == null && node_1.DragDropEnabled && node_1.IsSelected && (Math.Abs(point_0.X - layoutPosition.X) > SystemInformation.get_DragSize().Width || Math.Abs(point_0.Y - layoutPosition.Y) > SystemInformation.get_DragSize().Height))
		{
			method_76();
		}
		Rectangle rectangle = Rectangle.Empty;
		if (node_1 != null)
		{
			rectangle = NodeDisplay.smethod_0(Enum4.const_5, node_1, nodeDisplay_0.Offset);
		}
		if (!rectangle.IsEmpty && rectangle.Contains(layoutPosition))
		{
			flag = method_40(node_1, e, nodeDisplay_0.Offset);
		}
		else
		{
			Node node = null;
			Class23 @class = null;
			@class = ((!bool_16) ? Class15.smethod_23(this, layoutPosition.X, layoutPosition.Y, bool_0: true) : Class15.smethod_25(this, layoutPosition.Y, bool_0: true));
			node = @class.node_0;
			if (node != node_1)
			{
				flag = method_26(node);
			}
			if (node == null && @class.columnHeaderCollection_0 != null && AllowUserToResizeColumns)
			{
				ColumnHeader columnHeader = method_4(layoutPosition.X, layoutPosition.Y, @class.columnHeaderCollection_0);
				if (columnHeader != null)
				{
					if (columnHeader_2 == null)
					{
						cursor_0 = ((Control)this).get_Cursor();
						((Control)this).set_Cursor(Cursors.get_VSplit());
					}
					columnHeader_2 = columnHeader;
					columnHeaderCollection_1 = @class.columnHeaderCollection_0;
				}
				else
				{
					method_21();
				}
			}
			else
			{
				method_21();
			}
			if (node_1 != null)
			{
				flag |= method_40(node_1, e, nodeDisplay_0.Offset);
			}
		}
		if (flag)
		{
			((Control)this).Update();
		}
	}

	private void method_21()
	{
		if (columnHeader_2 != null)
		{
			columnHeader_2 = null;
			if (cursor_0 != (Cursor)null)
			{
				((Control)this).set_Cursor(cursor_0);
			}
			else
			{
				((Control)this).set_Cursor((Cursor)null);
			}
			cursor_0 = null;
		}
		columnHeaderCollection_1 = null;
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		if (AutoScroll && vscrollBarAdv_0 != null)
		{
			if (e.get_Delta() < 0)
			{
				AutoScrollPosition = new Point(AutoScrollPosition.X, Math.Max(AutoScrollPosition.Y - vscrollBarAdv_0.SmallChange, -(vscrollBarAdv_0.Maximum - vscrollBarAdv_0.LargeChange)));
			}
			else
			{
				AutoScrollPosition = new Point(AutoScrollPosition.X, Math.Min(0, AutoScrollPosition.Y + vscrollBarAdv_0.SmallChange));
			}
		}
		((ScrollableControl)this).OnMouseWheel(e);
	}

	public void DeselectNode(Node node, eTreeAction action)
	{
		if (bool_13 && node != null)
		{
			if (node.IsSelected)
			{
				selectedNodesCollection_0.Remove(node, action);
			}
		}
		else
		{
			SelectNode(null, action);
		}
	}

	public void SelectNode(Node node, eTreeAction action)
	{
		if ((node != null && !node.Selectable && !((Component)this).DesignMode) || (!bool_13 && node == node_0))
		{
			return;
		}
		AdvTreeNodeCancelEventArgs advTreeNodeCancelEventArgs = new AdvTreeNodeCancelEventArgs(action, node);
		OnBeforeNodeSelect(advTreeNodeCancelEventArgs);
		if (advTreeNodeCancelEventArgs.Cancel)
		{
			return;
		}
		if (bool_13 && !((Component)this).DesignMode)
		{
			selectedNodesCollection_0.ETreeAction_0 = action;
			selectedNodesCollection_0.Clear();
			selectedNodesCollection_0.ETreeAction_0 = eTreeAction.Code;
			if (node != null)
			{
				selectedNodesCollection_0.bool_1 = true;
				try
				{
					if (selectedNodesCollection_0.Add(node, action) != -1)
					{
						node.EnsureVisible();
					}
				}
				finally
				{
					selectedNodesCollection_0.bool_1 = false;
				}
			}
			((Control)this).Invalidate();
		}
		else
		{
			if (bool_6 && !method_33(eTreeAction.Code))
			{
				return;
			}
			if (node_0 != null)
			{
				method_7(node_0);
				if (node_0.SelectedCell != null && node_0 != node)
				{
					node_0.SelectedCell.SetSelected(selected: false);
				}
				selectedNodesCollection_0.Remove(node_0);
				OnAfterNodeDeselect(new AdvTreeNodeEventArgs(action, node_0));
			}
			node_0 = node;
			if (node_0 != null)
			{
				selectedNodesCollection_0.Add(node_0);
				method_7(node_0);
				if (node_0.SelectedCell == null)
				{
					node_0.Cells[0].SetSelected(selected: true);
				}
				node_0.EnsureVisible();
			}
			if (NodeConnector_0 != null)
			{
				((Control)this).Invalidate();
			}
			AdvTreeNodeEventArgs args = new AdvTreeNodeEventArgs(action, node);
			OnAfterNodeSelect(args);
			if (currencyManager_0 != null)
			{
				if (node != null && node.BindingIndex > -1 && ((BindingManagerBase)currencyManager_0).get_Position() != node.BindingIndex)
				{
					((BindingManagerBase)currencyManager_0).set_Position(node.BindingIndex);
				}
				else if (node == null)
				{
					((BindingManagerBase)currencyManager_0).set_Position(-1);
				}
			}
			OnSelectedIndexChanged(EventArgs.Empty);
			if (!string.IsNullOrEmpty(ValueMember))
			{
				OnSelectedValueChanged(EventArgs.Empty);
			}
		}
	}

	private void method_22()
	{
		InvalidateNodesSize();
		if (((Component)this).DesignMode)
		{
			RecalcLayout();
			((Control)this).Refresh();
		}
	}

	private void method_23(Node node_4)
	{
		node_4.SizeChanged = true;
		foreach (Node node in node_4.Nodes)
		{
			method_23(node);
		}
	}

	public void InvalidateNodesSize()
	{
		foreach (Node item in nodeCollection_0)
		{
			method_23(item);
		}
	}

	public void InvalidateNodeSize(Node node)
	{
		method_23(node);
	}

	private void imageList_0_Disposed(object sender, EventArgs e)
	{
		if (sender == imageList_0)
		{
			ImageList = null;
		}
	}

	private void method_24()
	{
		Node node = SelectedNode;
		Node node2 = node;
		if (node == null)
		{
			return;
		}
		while (node != null)
		{
			node = node.Parent;
			if (node != null && !node.Expanded && node.Selectable)
			{
				node2 = node;
			}
		}
		if (node2 != null && node2.IsVisible)
		{
			SelectedNode = node2;
		}
		else if (!method_45(eTreeAction.Code))
		{
			SelectedNode = null;
		}
	}

	private bool method_25(Cell cell_2)
	{
		bool result = false;
		if (cell_2 == cell_0)
		{
			return result;
		}
		if (cell_0 != null && cell_0 != cell_2)
		{
			if (CellStyleMouseOver != null || cell_0.StyleMouseOver != null || eNodeRenderMode_0 != 0 || (cell_0.Parent != null && cell_0.Parent.RenderMode != 0))
			{
				result = true;
			}
			cell_0.SetMouseOver(over: false);
		}
		cell_0 = cell_2;
		if (cell_0 != null)
		{
			cell_0.SetMouseOver(over: true);
			if (CellStyleMouseOver != null || cell_0.StyleMouseOver != null || eNodeRenderMode_0 != 0 || (cell_0.Parent != null && cell_0.Parent.RenderMode != 0))
			{
				result = true;
			}
		}
		method_38();
		return result;
	}

	private bool method_26(Node node_4)
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (node_1 != null)
		{
			flag |= method_25(null);
			if (node_1.MouseOverNodePart == Enum1.const_2)
			{
				flag = true;
			}
			node_1.MouseOverNodePart = Enum1.const_0;
			if (NodeStyleMouseOver != null || CellStyleMouseOver != null || node_1.StyleMouseOver != null || NodeStyleMouseOver != null || eNodeRenderMode_0 != 0 || node_1.RenderMode != 0 || node_1.CommandButton || flag || bool_19)
			{
				method_7(node_1);
				flag = true;
			}
			if (node_1 != node_4 && node_1 != null)
			{
				Point point = ((Control)this).PointToClient(Control.get_MousePosition());
				InvokeNodeMouseLeave(new TreeNodeMouseEventArgs(node_1, Control.get_MouseButtons(), 0, 0, point.X, point.Y));
			}
		}
		node_1 = node_4;
		if (node_1 != null)
		{
			node_1.MouseOverNodePart = Enum1.const_1;
			if (node_1.StyleMouseOver != null || NodeStyleMouseOver != null || eNodeRenderMode_0 != 0 || node_1.RenderMode != 0 || node_1.CommandButton || bool_19)
			{
				method_7(node_1);
				flag = true;
			}
			Point point2 = ((Control)this).PointToClient(Control.get_MousePosition());
			InvokeNodeMouseEnter(new TreeNodeMouseEventArgs(node_1, Control.get_MouseButtons(), 0, 0, point2.X, point2.Y));
			if (Boolean_1 || node_1.FireHoverEvent)
			{
				Class16.smethod_0((Control)(object)this);
			}
		}
		return flag;
	}

	private void method_27(Node node_4, MouseEventArgs mouseEventArgs_0, Point point_2)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Invalid comparison between Unknown and I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Invalid comparison between Unknown and I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Invalid comparison between Unknown and I4
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Invalid comparison between Unknown and I4
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Invalid comparison between Unknown and I4
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Invalid comparison between Unknown and I4
		Point layoutPosition = GetLayoutPosition(mouseEventArgs_0);
		InvokeNodeMouseDown(new TreeNodeMouseEventArgs(node_4, mouseEventArgs_0.get_Button(), mouseEventArgs_0.get_Clicks(), mouseEventArgs_0.get_Delta(), layoutPosition.X, layoutPosition.Y));
		if ((int)mouseEventArgs_0.get_Button() == 1048576)
		{
			if (NodeDisplay.smethod_0(Enum4.const_2, node_4, point_2).Contains(layoutPosition) && mouseEventArgs_0.get_Clicks() == 1)
			{
				int_1 = 0;
				node_4.Toggle();
				return;
			}
			if (node_4.CommandButton)
			{
				int_1 = 0;
				if (NodeDisplay.smethod_0(Enum4.const_6, node_4, point_2).Contains(layoutPosition))
				{
					method_58(node_4, new CommandButtonEventArgs(eTreeAction.Mouse, node_4));
					return;
				}
			}
			Rectangle rectangle = NodeDisplay.smethod_0(Enum4.const_0, node_4, point_2);
			if ((rectangle.Contains(layoutPosition) || (bool_16 && layoutPosition.Y >= rectangle.Y && layoutPosition.Y <= rectangle.Bottom)) && node_4.TreeControl != null)
			{
				if (node_4.TreeControl.SelectedNode != node_4)
				{
					int_1 = 0;
				}
				if (node_4.Selectable)
				{
					if (bool_13 && selectedNodesCollection_0.Count > 0 && ((int)Control.get_ModifierKeys() == 65536 || (int)Control.get_ModifierKeys() == 131072))
					{
						int_1 = 0;
						if (eMultiSelectRule_0 == eMultiSelectRule.SameParent && selectedNodesCollection_0[0].Parent != node_4.Parent)
						{
							return;
						}
						if ((int)Control.get_ModifierKeys() == 65536 && selectedNodesCollection_0.Count > 0)
						{
							Node node = selectedNodesCollection_0[0];
							Node node2 = node_4;
							while (selectedNodesCollection_0.Count > 1)
							{
								selectedNodesCollection_0.Remove(selectedNodesCollection_0[selectedNodesCollection_0.Count - 1], eTreeAction.Mouse);
							}
							if (node2 == node)
							{
								return;
							}
							if (node2.Bounds.Y > node.Bounds.Y)
							{
								do
								{
									if (!node2.IsSelected && (eMultiSelectRule_0 == eMultiSelectRule.AnyNode || (eMultiSelectRule_0 == eMultiSelectRule.SameParent && selectedNodesCollection_0.Count > 0 && selectedNodesCollection_0[0].Parent == node2.Parent)))
									{
										selectedNodesCollection_0.Add(node2, eTreeAction.Mouse);
									}
									node2 = Class15.smethod_15(node2);
								}
								while (node != node2 && node2 != null);
								return;
							}
							do
							{
								if (!node2.IsSelected && (eMultiSelectRule_0 == eMultiSelectRule.AnyNode || (eMultiSelectRule_0 == eMultiSelectRule.SameParent && selectedNodesCollection_0.Count > 0 && selectedNodesCollection_0[0].Parent == node2.Parent)))
								{
									selectedNodesCollection_0.Add(node2, eTreeAction.Mouse);
								}
								node2 = Class15.smethod_9(node2);
							}
							while (node != node2 && node2 != null);
						}
						else if (node_4.IsSelected)
						{
							selectedNodesCollection_0.Remove(node_4, eTreeAction.Mouse);
						}
						else
						{
							selectedNodesCollection_0.Add(node_4, eTreeAction.Mouse);
						}
						return;
					}
					SelectNode(node_4, eTreeAction.Mouse);
					if (node_4.TreeControl == null || node_4.TreeControl.SelectedNode != node_4)
					{
						return;
					}
				}
				Cell cell = method_39(node_4, layoutPosition.X, layoutPosition.Y, point_2);
				if (cell == null)
				{
					return;
				}
				bool flag = false;
				if (cell.CheckBoxVisible && cell.GetEnabled())
				{
					Rectangle checkBoxBoundsRelative = cell.CheckBoxBoundsRelative;
					checkBoxBoundsRelative.Offset(NodeDisplay.smethod_0(Enum4.const_5, node_4, point_2).Location);
					if (checkBoxBoundsRelative.Contains(layoutPosition))
					{
						if (cell.CheckBoxThreeState)
						{
							if ((int)cell.CheckState == 1)
							{
								cell.SetChecked((CheckState)2, eTreeAction.Mouse);
							}
							else if ((int)cell.CheckState == 0)
							{
								cell.SetChecked((CheckState)1, eTreeAction.Mouse);
							}
							else if ((int)cell.CheckState == 2)
							{
								cell.SetChecked((CheckState)0, eTreeAction.Mouse);
							}
						}
						else
						{
							cell.SetChecked(!cell.Checked, eTreeAction.Mouse);
						}
						flag = true;
						int_1 = 0;
					}
				}
				if (node_4.SelectedCell != cell)
				{
					int_1 = 1;
				}
				else if (!flag)
				{
					int_1++;
				}
				node_4.SelectedCell = cell;
				cell.SetMouseDown(over: true);
			}
			else
			{
				int_1 = 0;
			}
		}
		else
		{
			if ((int)mouseEventArgs_0.get_Button() != 2097152 || node_4.TreeControl == null)
			{
				return;
			}
			if (!node_4.IsSelected)
			{
				SelectNode(node_4, eTreeAction.Mouse);
			}
			if ((!MultiSelect && node_4.TreeControl.SelectedNode != node_4) || node_4.ContextMenu == null)
			{
				return;
			}
			if (node_4.ContextMenu is ContextMenu)
			{
				object contextMenu = node_4.ContextMenu;
				ContextMenu val = (ContextMenu)((contextMenu is ContextMenu) ? contextMenu : null);
				val.Show((Control)(object)this, new Point(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()));
			}
			else if (node_4.ContextMenu.GetType().FullName == "System.Windows.Forms.ContextMenuStrip")
			{
				node_4.ContextMenu.GetType().InvokeMember("Show", BindingFlags.InvokeMethod, null, node_4.ContextMenu, new object[2]
				{
					this,
					new Point(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y())
				});
			}
			else if (node_4.ContextMenu.GetType().FullName == "DevComponents.DotNetBar.ButtonItem")
			{
				Point point = ((Control)this).PointToScreen(new Point(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()));
				node_4.ContextMenu.GetType().InvokeMember("Popup", BindingFlags.InvokeMethod, null, node_4.ContextMenu, new object[1] { point });
			}
			else
			{
				if (!node_4.ContextMenu.ToString()!.StartsWith(NodeContextMenuTypeEditor.DotNetBarPrefix) || object_0 == null)
				{
					return;
				}
				string text = node_4.ContextMenu.ToString()!.Substring(NodeContextMenuTypeEditor.DotNetBarPrefix.Length);
				object obj = object_0.GetType().InvokeMember("ContextMenus", BindingFlags.GetProperty, null, object_0, null);
				int num = (int)obj.GetType().InvokeMember("IndexOf", BindingFlags.InvokeMethod, null, obj, new string[1] { text });
				if (num >= 0)
				{
					IList list = obj as IList;
					object obj2 = list[num];
					try
					{
						obj2.GetType().InvokeMember("SetSourceControl", BindingFlags.InvokeMethod, null, obj2, new object[1] { this });
					}
					catch
					{
					}
					Point point2 = ((Control)this).PointToScreen(new Point(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()));
					obj2.GetType().InvokeMember("Popup", BindingFlags.InvokeMethod, null, obj2, new object[1] { point2 });
				}
			}
		}
	}

	private void method_28(MouseEventArgs mouseEventArgs_0)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		Point layoutPosition = GetLayoutPosition(mouseEventArgs_0);
		if (SelectedNode != null && SelectedNode.SelectedCell != null && SelectedNode.SelectedCell.IsMouseDown)
		{
			SelectedNode.SelectedCell.SetMouseDown(over: false);
			method_7(SelectedNode);
			flag = true;
		}
		if (flag)
		{
			((Control)this).Update();
		}
		if (treeNodeMouseEventHandler_1 != null)
		{
			Node nodeAt = GetNodeAt(layoutPosition);
			if (nodeAt != null)
			{
				InvokeNodeMouseUp(new TreeNodeMouseEventArgs(nodeAt, mouseEventArgs_0.get_Button(), mouseEventArgs_0.get_Clicks(), mouseEventArgs_0.get_Delta(), layoutPosition.X, layoutPosition.Y));
			}
		}
	}

	private void method_29(EventArgs eventArgs_0)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (SelectedNode == null)
		{
			return;
		}
		MouseEventArgs val = (MouseEventArgs)(object)((eventArgs_0 is MouseEventArgs) ? eventArgs_0 : null);
		if (val == null)
		{
			Point point = ((Control)this).PointToClient(Control.get_MousePosition());
			val = new MouseEventArgs((MouseButtons)1048576, 1, point.X, point.Y, 0);
		}
		Point layoutPosition = GetLayoutPosition(val);
		Class23 @class = (((int)val.get_Button() != 1048576 || !bool_16) ? Class15.smethod_22(this, layoutPosition.X, layoutPosition.Y) : Class15.smethod_24(this, layoutPosition.Y));
		if (@class.node_0 == SelectedNode)
		{
			InvokeNodeClick(new TreeNodeMouseEventArgs(SelectedNode, val.get_Button(), val.get_Clicks(), val.get_Delta(), val.get_X(), val.get_Y()));
			if (int_1 > 1)
			{
				method_30(eTreeAction.Mouse);
			}
		}
	}

	internal bool method_30(eTreeAction eTreeAction_0)
	{
		if (CellEdit && SelectedNode.SelectedCell != null && SelectedNode.SelectedCell.IsEditable)
		{
			method_31(SelectedNode.SelectedCell, eTreeAction_0);
			return true;
		}
		return false;
	}

	internal void method_31(Cell cell_2, eTreeAction eTreeAction_0)
	{
		method_32(cell_2, eTreeAction_0, null);
	}

	internal void method_32(Cell cell_2, eTreeAction eTreeAction_0, string string_4)
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		if (cell_2 == null || !cell_2.GetEnabled() || (bool_6 && !method_33(eTreeAction_0)))
		{
			return;
		}
		CellEditEventArgs cellEditEventArgs = new CellEditEventArgs(cell_2, eTreeAction_0, "");
		OnBeforeCellEdit(cellEditEventArgs);
		if (cellEditEventArgs.Cancel)
		{
			return;
		}
		ICellEditControl cellEditControl = method_36(cell_2);
		if (cellEditControl == null)
		{
			return;
		}
		Class22 @class = cellEditControl as Class22;
		Control val = (Control)((cellEditControl is Control) ? cellEditControl : null);
		Rectangle r = NodeDisplay.smethod_2(Enum5.const_2, cell_2, nodeDisplay_0.Offset);
		r = GetScreenRectangle(r);
		cellEditControl.CurrentValue = cell_2.Text;
		cellEditControl.EditWordWrap = cell_2.WordWrap;
		Font val2 = Class13.smethod_6(this, cell_2);
		if (float_0 != 1f && val2 != null)
		{
			val2 = new Font(val2.get_FontFamily(), val2.get_SizeInPoints() * float_0);
		}
		val.set_Font(val2);
		val.set_Location(r.Location);
		val.set_Size(r.Size);
		val.set_Visible(true);
		val.Focus();
		if (@class != null)
		{
			if (string_4 == null)
			{
				((TextBoxBase)@class).SelectAll();
			}
			else
			{
				((Control)@class).set_Text(string_4);
				((TextBoxBase)@class).Select(((Control)@class).get_Text().Length, 0);
			}
		}
		PrepareCellEditor(cell_2, cellEditControl);
		cell_2.Parent.SetEditing(b: true);
		cell_1 = cell_2;
		bool_6 = true;
		icellEditControl_0 = cellEditControl;
		cellEditControl.BeginEdit();
	}

	protected virtual void PrepareCellEditor(Cell cell, ICellEditControl editControl)
	{
	}

	protected virtual void OnProvideCustomCellEditor(CustomCellEditorEventArgs e)
	{
		customCellEditorEventHandler_0?.Invoke(this, e);
	}

	internal bool method_33(eTreeAction eTreeAction_0)
	{
		return method_34(eTreeAction_0, bool_25: false);
	}

	internal bool method_34(eTreeAction eTreeAction_0, bool bool_25)
	{
		if (cell_1 != null && icellEditControl_0 != null)
		{
			ICellEditControl cellEditControl = icellEditControl_0;
			Control val = (Control)((cellEditControl is Control) ? cellEditControl : null);
			string newText = cellEditControl.CurrentValue.ToString();
			CellEditEventArgs cellEditEventArgs = new CellEditEventArgs(cell_1, eTreeAction_0, newText);
			method_43(cellEditEventArgs);
			if (cellEditEventArgs.Cancel)
			{
				return false;
			}
			((Control)this).Focus();
			val.set_Visible(false);
			newText = cellEditEventArgs.NewText;
			method_44(cellEditEventArgs);
			newText = cellEditEventArgs.NewText;
			if (!cellEditEventArgs.Cancel && cell_1.Text != newText && !bool_25)
			{
				if (((Component)this).DesignMode && cell_1.Parent.Cells[0] == cell_1)
				{
					TypeDescriptor.GetProperties(cell_1.Parent)["Text"]!.SetValue(cell_1.Parent, newText);
				}
				else
				{
					TypeDescriptor.GetProperties(cell_1)["Text"]!.SetValue(cell_1, newText);
				}
				BeginUpdate();
				RecalcLayout();
				EndUpdate();
			}
			cell_1.Parent.SetEditing(b: false);
			cell_1 = null;
			bool_6 = false;
			OnAfterCellEditComplete(cellEditEventArgs);
			if (cellEditControl != class22_0)
			{
				((Control)this).get_Controls().Remove(val);
				cellEditControl.EditComplete += class22_0_EditComplete;
				cellEditControl.CancelEdit += class22_0_CancelEdit;
			}
			cellEditControl.EndEdit();
			return true;
		}
		bool_6 = false;
		return true;
	}

	protected virtual void OnAfterCellEditComplete(CellEditEventArgs e)
	{
		cellEditEventHandler_3?.Invoke(this, e);
	}

	internal void method_35(eTreeAction eTreeAction_0)
	{
		if (cell_1 != null)
		{
			((Control)class22_0).set_Text(cell_1.Text);
			method_34(eTreeAction_0, bool_25: true);
		}
	}

	private ICellEditControl method_36(Cell cell_2)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		eCellEditorType effectiveEditorType = cell_2.GetEffectiveEditorType();
		ICellEditControl cellEditControl = null;
		switch (effectiveEditorType)
		{
		case eCellEditorType.Default:
			cellEditControl = method_37();
			if (cellEditControl is TextBox)
			{
				ColumnHeader columnHeader = Class15.smethod_45(this, cell_2);
				if (columnHeader != null)
				{
					((TextBoxBase)(TextBox)cellEditControl).set_MaxLength(columnHeader.MaxInputLength);
				}
				else
				{
					((TextBoxBase)(TextBox)cellEditControl).set_MaxLength(0);
				}
			}
			break;
		case eCellEditorType.NumericInteger:
		{
			Class206 @class = new Class206();
			@class.ShowUpDown = true;
			cellEditControl = @class;
			break;
		}
		case eCellEditorType.NumericDouble:
		{
			Class205 class3 = new Class205();
			class3.ShowUpDown = true;
			cellEditControl = class3;
			break;
		}
		case eCellEditorType.NumericCurrency:
		{
			Class205 class2 = new Class205();
			class2.DisplayFormat = "C";
			class2.ShowUpDown = true;
			cellEditControl = class2;
			break;
		}
		case eCellEditorType.Custom:
		{
			CustomCellEditorEventArgs customCellEditorEventArgs = new CustomCellEditorEventArgs();
			OnProvideCustomCellEditor(customCellEditorEventArgs);
			if (customCellEditorEventArgs.EditControl == null)
			{
				throw new ArgumentNullException("CustomCellEditorEventArgs.EditControl must be set to the custom cell editor.");
			}
			cellEditControl = customCellEditorEventArgs.EditControl;
			break;
		}
		}
		if (cellEditControl == null)
		{
			throw new NotImplementedException("Editor type " + effectiveEditorType.ToString() + " not implemented.");
		}
		if (((Control)cellEditControl).get_Parent() != this)
		{
			((Control)this).get_Controls().Add((Control)cellEditControl);
			cellEditControl.EditComplete += class22_0_EditComplete;
			cellEditControl.CancelEdit += class22_0_CancelEdit;
		}
		return cellEditControl;
	}

	private Class22 method_37()
	{
		if (class22_0 == null)
		{
			class22_0 = new Class22();
			((Control)class22_0).set_AutoSize(false);
			((Control)this).get_Controls().Add((Control)(object)class22_0);
			class22_0.EditComplete += class22_0_EditComplete;
			class22_0.CancelEdit += class22_0_CancelEdit;
		}
		return class22_0;
	}

	private void class22_0_EditComplete(object sender, EventArgs e)
	{
		if (cell_1 != null)
		{
			method_33(eTreeAction.Keyboard);
		}
	}

	private void class22_0_CancelEdit(object sender, EventArgs e)
	{
		method_35(eTreeAction.Keyboard);
	}

	private void method_38()
	{
		if (cell_0 != null)
		{
			if (cell_0.Cursor != (Cursor)null && ((Control)this).get_Cursor() != cell_0.Cursor)
			{
				if (cursor_0 == (Cursor)null)
				{
					cursor_0 = ((Control)this).get_Cursor();
				}
				((Control)this).set_Cursor(cell_0.Cursor);
			}
			else if (cursor_1 != (Cursor)null && ((Control)this).get_Cursor() != cursor_1)
			{
				if (cursor_0 == (Cursor)null)
				{
					cursor_0 = ((Control)this).get_Cursor();
				}
				((Control)this).set_Cursor(cursor_1);
			}
		}
		else if (cursor_0 != (Cursor)null)
		{
			((Control)this).set_Cursor(cursor_0);
			cursor_0 = null;
		}
	}

	private Cell method_39(Node node_4, int int_14, int int_15, Point point_2)
	{
		Cell result = null;
		Rectangle rectangle = NodeDisplay.smethod_0(Enum4.const_5, node_4, point_2);
		foreach (Cell cell in node_4.Cells)
		{
			Rectangle boundsRelative = cell.BoundsRelative;
			boundsRelative.Offset(rectangle.Location);
			if (boundsRelative.Contains(int_14, int_15))
			{
				return cell;
			}
		}
		return result;
	}

	private bool method_40(Node node_4, MouseEventArgs mouseEventArgs_0, Point point_2)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Point layoutPosition = GetLayoutPosition(mouseEventArgs_0);
		InvokeNodeMouseMove(new TreeNodeMouseEventArgs(node_4, mouseEventArgs_0.get_Button(), mouseEventArgs_0.get_Clicks(), mouseEventArgs_0.get_Delta(), layoutPosition.X, layoutPosition.Y));
		Rectangle rectangle = NodeDisplay.smethod_0(Enum4.const_2, node_4, point_2);
		bool flag = false;
		if (rectangle.Contains(layoutPosition))
		{
			node_4.MouseOverNodePart = Enum1.const_2;
			if (cell_0 != null)
			{
				flag |= method_25(null);
			}
			flag = true;
		}
		else if (node_4.MouseOverNodePart == Enum1.const_2)
		{
			node_4.MouseOverNodePart = Enum1.const_1;
			flag = true;
		}
		if (NodeDisplay.smethod_0(Enum4.const_6, node_4, point_2).Contains(layoutPosition))
		{
			node_4.MouseOverNodePart = Enum1.const_4;
			if (cell_0 != null)
			{
				flag |= method_25(null);
			}
			flag = true;
		}
		else if (node_4.MouseOverNodePart != Enum1.const_2)
		{
			if (node_4.MouseOverNodePart != Enum1.const_1)
			{
				node_4.MouseOverNodePart = Enum1.const_1;
				flag = true;
			}
			Cell cell = method_39(node_4, layoutPosition.X, layoutPosition.Y, point_2);
			if (cell != null)
			{
				flag |= method_25(cell);
			}
		}
		if (flag)
		{
			method_7(node_4);
		}
		return flag;
	}

	private void method_41()
	{
		if (SelectedNode != null)
		{
			method_7(SelectedNode);
			((Control)this).Update();
		}
	}

	private void method_42()
	{
		class17_0.CommandAreaWidth = int_5;
		RecalcLayout();
	}

	private void method_43(CellEditEventArgs cellEditEventArgs_0)
	{
		if (cellEditEventHandler_1 != null)
		{
			cellEditEventHandler_1(this, cellEditEventArgs_0);
		}
	}

	private void method_44(CellEditEventArgs cellEditEventArgs_0)
	{
		if (cellEditEventHandler_2 != null)
		{
			cellEditEventHandler_2(this, cellEditEventArgs_0);
		}
	}

	protected internal virtual void InvokeBeforeNodeInsert(eTreeAction action, Node node, Node parentNode)
	{
		if (treeNodeCollectionEventHandler_2 != null)
		{
			TreeNodeCollectionEventArgs e = new TreeNodeCollectionEventArgs(action, node, parentNode);
			treeNodeCollectionEventHandler_2(this, e);
		}
	}

	protected internal virtual void InvokeAfterNodeInsert(eTreeAction action, Node node, Node parentNode)
	{
		if (treeNodeCollectionEventHandler_3 != null)
		{
			TreeNodeCollectionEventArgs e = new TreeNodeCollectionEventArgs(action, node, parentNode);
			treeNodeCollectionEventHandler_3(this, e);
		}
	}

	protected internal virtual void InvokeBeforeNodeRemove(eTreeAction action, Node node, Node parentNode)
	{
		if (treeNodeCollectionEventHandler_0 != null)
		{
			TreeNodeCollectionEventArgs e = new TreeNodeCollectionEventArgs(action, node, parentNode);
			treeNodeCollectionEventHandler_0(this, e);
		}
	}

	protected internal virtual void InvokeAfterNodeRemove(eTreeAction action, Node node, Node parentNode)
	{
		if (treeNodeCollectionEventHandler_1 != null)
		{
			TreeNodeCollectionEventArgs e = new TreeNodeCollectionEventArgs(action, node, parentNode);
			treeNodeCollectionEventHandler_1(this, e);
		}
	}

	protected internal virtual void NodeRemoved(eTreeAction action, Node node, Node parentNode, int indexOfRemovedNode)
	{
		InvokeAfterNodeRemove(action, node, parentNode);
		if (!((Control)this).get_IsDisposed())
		{
			RecalcLayout();
		}
		if (IsUpdateSuspended)
		{
			return;
		}
		bool flag = false;
		if (node.IsSelected)
		{
			flag = true;
		}
		else
		{
			Node node2 = SelectedNode;
			while (node2 != null)
			{
				if (node2 == null || node2 != node)
				{
					node2 = node2.Parent;
					continue;
				}
				flag = true;
				break;
			}
		}
		if (flag)
		{
			Node node3 = parentNode;
			bool flag2 = true;
			if (parentNode != null)
			{
				if (parentNode.Nodes.Count > 0)
				{
					if (indexOfRemovedNode >= parentNode.Nodes.Count)
					{
						indexOfRemovedNode = parentNode.Nodes.Count - 1;
					}
					node3 = parentNode.Nodes[indexOfRemovedNode];
					if (node3.CanSelect)
					{
						SelectNode(node3, action);
						flag2 = false;
						node3 = null;
					}
				}
				else if (node3.CanSelect)
				{
					SelectNode(node3, action);
					flag2 = false;
					node3 = null;
				}
				if (node3 != null)
				{
					while (node3 != null)
					{
						node3 = Class15.smethod_15(node3);
						if (node3 != null && node3.CanSelect)
						{
							SelectNode(node3, action);
							flag2 = false;
							break;
						}
					}
				}
			}
			if (flag2 && !method_45(action))
			{
				SelectNode(null, action);
			}
		}
		((Control)this).Invalidate();
	}

	private bool method_45(eTreeAction eTreeAction_0)
	{
		foreach (Node node in Nodes)
		{
			if (node.Selectable && node.Visible && node.Enabled)
			{
				SelectNode(node, eTreeAction_0);
				if (SelectedNode == node)
				{
					return true;
				}
			}
		}
		return false;
	}

	protected virtual void InvokeBeforeNodeDrop(TreeDragDropEventArgs e)
	{
		if (treeDragDropEventHandler_0 != null)
		{
			treeDragDropEventHandler_0(this, e);
		}
	}

	protected virtual void InvokeAfterNodeDrop(TreeDragDropEventArgs e)
	{
		if (treeDragDropEventHandler_1 != null)
		{
			treeDragDropEventHandler_1(this, e);
		}
	}

	protected virtual void InvokeNodeMouseDown(TreeNodeMouseEventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		if (e.Node != null)
		{
			e.Node.InvokeNodeMouseDown(this, new MouseEventArgs(e.Button, e.Clicks, e.X, e.Y, e.Delta));
		}
		if (treeNodeMouseEventHandler_0 != null)
		{
			treeNodeMouseEventHandler_0(this, e);
		}
	}

	protected virtual void InvokeNodeMouseUp(TreeNodeMouseEventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		if (e.Node != null)
		{
			e.Node.InvokeNodeMouseUp(this, new MouseEventArgs(e.Button, e.Clicks, e.X, e.Y, e.Delta));
		}
		if (treeNodeMouseEventHandler_1 != null)
		{
			treeNodeMouseEventHandler_1(this, e);
		}
	}

	protected virtual void InvokeNodeMouseMove(TreeNodeMouseEventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		if (e.Node != null)
		{
			e.Node.InvokeNodeMouseMove(this, new MouseEventArgs(e.Button, e.Clicks, e.X, e.Y, e.Delta));
		}
		if (treeNodeMouseEventHandler_2 != null)
		{
			treeNodeMouseEventHandler_2(this, e);
		}
	}

	protected virtual void InvokeNodeClick(TreeNodeMouseEventArgs e)
	{
		if (e.Node != null)
		{
			e.Node.InvokeNodeClick(this, e);
		}
		if (treeNodeMouseEventHandler_6 != null)
		{
			treeNodeMouseEventHandler_6(this, e);
		}
	}

	protected virtual void InvokeNodeDoubleClick(TreeNodeMouseEventArgs e)
	{
		if (e.Node != null)
		{
			e.Node.InvokeNodeDoubleClick(this, e);
		}
		if (treeNodeMouseEventHandler_7 != null)
		{
			treeNodeMouseEventHandler_7(this, e);
		}
	}

	protected virtual void InvokeNodeMouseEnter(TreeNodeMouseEventArgs e)
	{
		if (e.Node != null)
		{
			e.Node.InvokeNodeMouseEnter(this, e);
		}
		if (treeNodeMouseEventHandler_3 != null)
		{
			treeNodeMouseEventHandler_3(this, e);
		}
	}

	protected virtual void InvokeNodeMouseLeave(TreeNodeMouseEventArgs e)
	{
		if (e.Node != null)
		{
			e.Node.InvokeNodeMouseLeave(this, e);
		}
		if (treeNodeMouseEventHandler_4 != null)
		{
			treeNodeMouseEventHandler_4(this, e);
		}
	}

	protected virtual void InvokeNodeMouseHover(TreeNodeMouseEventArgs e)
	{
		if (e.Node != null)
		{
			e.Node.InvokeNodeMouseHover(this, e);
		}
		if (treeNodeMouseEventHandler_5 != null)
		{
			treeNodeMouseEventHandler_5(this, e);
		}
	}

	void INodeNotify.ExpandedChanged(Node node)
	{
		method_24();
		if (!IsUpdateSuspended)
		{
			RecalcLayout();
			((Control)this).Refresh();
		}
	}

	public void Save(XmlDocument document)
	{
		TreeSerializer.Save(this, document);
	}

	public void Save(string fileName)
	{
		TreeSerializer.Save(this, fileName);
	}

	public void Save(Stream outStream)
	{
		TreeSerializer.Save(this, outStream);
	}

	public void Save(TextWriter writer)
	{
		TreeSerializer.Save(this, writer);
	}

	public void Save(XmlWriter writer)
	{
		TreeSerializer.Save(this, writer);
	}

	public void Load(string fileName)
	{
		TreeSerializer.Load(this, fileName);
	}

	public void Load(Stream inStream)
	{
		TreeSerializer.Load(this, inStream);
	}

	public void Load(XmlReader reader)
	{
		TreeSerializer.Load(this, reader);
	}

	public void Load(TextReader reader)
	{
		TreeSerializer.Load(this, reader);
	}

	public void Load(XmlDocument document)
	{
		TreeSerializer.Load(this, document);
	}

	public override void Refresh()
	{
		if (!IsUpdateSuspended && !SuspendPaint)
		{
			((Control)this).Refresh();
		}
	}

	public void BeginUpdate()
	{
		int_0++;
	}

	public void EndUpdate()
	{
		EndUpdate(performLayoutAndRefresh: true);
	}

	public void EndUpdate(bool performLayoutAndRefresh)
	{
		if (int_0 > 0)
		{
			int_0--;
		}
		if (int_0 == 0 && performLayoutAndRefresh)
		{
			RecalcLayout();
			((Control)this).Invalidate(true);
		}
	}

	public Node GetNodeAt(Point p)
	{
		return GetNodeAt(p.X, p.Y);
	}

	public Node GetNodeAt(int x, int y)
	{
		return Class15.smethod_22(this, x, y).node_0;
	}

	public Node GetNodeAt(int y)
	{
		return Class15.smethod_24(this, y).node_0;
	}

	public Cell GetCellAt(Point p)
	{
		return GetCellAt(p.X, p.Y);
	}

	public Cell GetCellAt(int x, int y)
	{
		Node nodeAt = GetNodeAt(x, y);
		if (nodeAt != null)
		{
			return method_39(nodeAt, x, y, nodeDisplay_0.Offset);
		}
		return null;
	}

	public void RecalcLayout()
	{
		if (IsUpdateSuspended)
		{
			bool_0 = true;
		}
		else
		{
			method_46();
		}
	}

	protected override void OnFontChanged(EventArgs e)
	{
		InvalidateNodesSize();
		RecalcLayout();
		((Control)this).OnFontChanged(e);
	}

	internal void method_46()
	{
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_Bounds().IsEmpty)
		{
			return;
		}
		Rectangle rectangle_ = method_17();
		if (columnHeaderCollection_0.Count > 0 && columnHeaderCollection_0.bool_0 && vscrollBarAdv_0 != null)
		{
			rectangle_.Width -= ((Control)vscrollBarAdv_0).get_Width();
		}
		if (SelectionBoxStyle == eSelectionStyle.NodeMarker)
		{
			rectangle_.Inflate(-Int32_0, -Int32_0);
		}
		else if ((DisplayRootNode != null && !DisplayRootNode.Selectable) || (Nodes.Count > 0 && !Nodes[0].Selectable))
		{
			rectangle_.Height -= 2;
		}
		else
		{
			rectangle_.Inflate(-2, -2);
		}
		class17_0.Rectangle_0 = rectangle_;
		class17_0.LeftRight = ((Control)this).RtlTranslateLeftRight((LeftRightAlignment)0);
		class17_0.PerformLayout();
		bool_0 = false;
		Size size = GetScreenRectangle(new Rectangle(0, 0, class17_0.Int32_0, class17_0.Int32_1)).Size;
		if (size.Width <= ((Control)this).get_Bounds().Width && size.Height <= ((Control)this).get_Bounds().Height)
		{
			if (AutoScroll)
			{
				BeginUpdate();
				bool flag = false;
				if (columnHeaderCollection_0.Count > 0 && vscrollBarAdv_0 != null)
				{
					if (columnHeaderCollection_0.bool_0)
					{
						InvalidateNodesSize();
					}
					else
					{
						flag = true;
					}
				}
				AutoScroll = false;
				nodeDisplay_0.Offset = nodeDisplay_0.DefaultOffset;
				if (flag)
				{
					class17_0.UpdateTopLevelColumnsWidth();
				}
				EndUpdate(performLayoutAndRefresh: false);
			}
			else
			{
				nodeDisplay_0.Offset = nodeDisplay_0.DefaultOffset;
			}
		}
		else
		{
			Size autoScrollMinSize = size;
			if (SelectionBoxStyle == eSelectionStyle.NodeMarker)
			{
				autoScrollMinSize.Width += Int32_0 * 2;
				autoScrollMinSize.Height += Int32_0 * 2;
			}
			else
			{
				autoScrollMinSize.Width += 2;
				autoScrollMinSize.Height += 2;
			}
			Rectangle rectangle = method_17();
			if (size.Height > rectangle.Height)
			{
				autoScrollMinSize.Width += SystemInformation.get_VerticalScrollBarWidth();
			}
			autoScrollMinSize.Height += SystemInformation.get_HorizontalScrollBarHeight();
			if (!AutoScroll)
			{
				BeginUpdate();
				((Control)this).Invalidate();
				AutoScroll = true;
				AutoScrollMinSize = autoScrollMinSize;
				AutoScrollPosition = nodeDisplay_0.DefaultOffset;
				if (columnHeaderCollection_0.Count > 0 && columnHeaderCollection_0.bool_0 && hscrollBarAdv_0 != null)
				{
					InvalidateNodesSize();
				}
				EndUpdate(performLayoutAndRefresh: false);
			}
			else if (AutoScrollMinSize != size)
			{
				BeginUpdate();
				AutoScrollMinSize = autoScrollMinSize;
				if (size.Width <= ((Control)this).get_Bounds().Width && AutoScrollPosition.X != 0)
				{
					AutoScrollPosition = new Point(0, AutoScrollPosition.Y);
				}
				Point autoScrollPosition = AutoScrollPosition;
				if (Math.Abs(autoScrollPosition.Y) > autoScrollMinSize.Height)
				{
					autoScrollPosition.Y = -(autoScrollMinSize.Height - rectangle.Height);
				}
				else if (size.Height <= ((Control)this).get_Bounds().Height)
				{
					autoScrollPosition.Y = 0;
				}
				if (Math.Abs(autoScrollPosition.X) > autoScrollMinSize.Width)
				{
					autoScrollPosition.X = -(autoScrollMinSize.Width - rectangle.Width);
				}
				else if (size.Width <= ((Control)this).get_Bounds().Width)
				{
					autoScrollPosition.X = 0;
				}
				if (AutoScrollPosition != autoScrollPosition)
				{
					AutoScrollPosition = autoScrollPosition;
				}
				EndUpdate(performLayoutAndRefresh: false);
			}
		}
		method_47(bool_25: true);
		method_50();
		((Control)this).Invalidate(true);
	}

	private void method_47(bool bool_25)
	{
		if (arrayList_0.Count > 0)
		{
			((Control)this).SuspendLayout();
			if (AutoScroll)
			{
				nodeDisplay_0.Offset = method_18();
			}
			nodeDisplay_0.MoveHostedControls();
			((Control)this).ResumeLayout(bool_25);
		}
		if (bool_6 && class22_0 != null && cell_1 != null)
		{
			Class22 @class = method_37();
			Rectangle r = NodeDisplay.smethod_2(Enum5.const_2, cell_1, nodeDisplay_0.Offset);
			((Control)@class).set_Location(GetScreenRectangle(r).Location);
		}
	}

	private void method_48()
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		if (!bool_20)
		{
			method_51();
			method_52();
			if (control_0 != null)
			{
				((Control)this).get_Controls().Remove(control_0);
				((Component)(object)control_0).Dispose();
				control_0 = null;
			}
			return;
		}
		Node node = method_78();
		Rectangle rectangle = Class52.smethod_12(BackgroundStyle, ((Control)this).get_ClientRectangle());
		Size size = size_2;
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
			if (node != null && node.Bounds.Height > 0)
			{
				vscrollBarAdv_0.SmallChange = node.Bounds.Height;
			}
			else
			{
				vscrollBarAdv_0.SmallChange = 22;
			}
			if (vscrollBarAdv_0.Maximum != size_2.Height)
			{
				vscrollBarAdv_0.Maximum = size_2.Height;
			}
			if (vscrollBarAdv_0.Value != -point_1.Y)
			{
				vscrollBarAdv_0.Value = Math.Min(vscrollBarAdv_0.Maximum, Math.Abs(point_1.Y));
			}
		}
		else
		{
			method_52();
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
			if (hscrollBarAdv_0.Maximum != size_2.Width)
			{
				hscrollBarAdv_0.Maximum = size_2.Width;
			}
			if (hscrollBarAdv_0.Value != -point_1.X)
			{
				hscrollBarAdv_0.Value = Math.Min(hscrollBarAdv_0.Maximum, Math.Abs(point_1.X));
			}
			if (node != null && node.Bounds.Height > 0)
			{
				hscrollBarAdv_0.SmallChange = node.Bounds.Height;
			}
			else
			{
				hscrollBarAdv_0.SmallChange = 22;
			}
		}
		else
		{
			method_51();
		}
		method_49();
	}

	private void vscrollBarAdv_0_Scroll(object sender, ScrollEventArgs e)
	{
		point_1.Y = -e.get_NewValue();
		method_47(bool_25: false);
		((Control)this).Invalidate();
		if (control0_0 != null)
		{
			((Control)control0_0).Invalidate();
		}
	}

	private void hscrollBarAdv_0_Scroll(object sender, ScrollEventArgs e)
	{
		point_1.X = -e.get_NewValue();
		method_47(bool_25: false);
		((Control)this).Invalidate();
		if (control0_0 != null)
		{
			((Control)control0_0).Invalidate();
		}
	}

	private void method_49()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		Rectangle rectangle = Class52.smethod_12(BackgroundStyle, ((Control)this).get_ClientRectangle());
		if (hscrollBarAdv_0 != null)
		{
			int num = rectangle.Width;
			if (vscrollBarAdv_0 != null)
			{
				num -= ((Control)vscrollBarAdv_0).get_Width();
			}
			((Control)hscrollBarAdv_0).set_Bounds(new Rectangle(rectangle.X, rectangle.Height - ((Control)hscrollBarAdv_0).get_Height() + 1, num, ((Control)hscrollBarAdv_0).get_Height()));
		}
		if (vscrollBarAdv_0 != null)
		{
			int num2 = rectangle.Height;
			if (hscrollBarAdv_0 != null)
			{
				num2 -= ((Control)hscrollBarAdv_0).get_Height();
			}
			((Control)vscrollBarAdv_0).set_Bounds(new Rectangle(rectangle.Right - ((Control)vscrollBarAdv_0).get_Width(), rectangle.Y, ((Control)vscrollBarAdv_0).get_Width(), num2));
		}
		if (vscrollBarAdv_0 != null && hscrollBarAdv_0 != null)
		{
			if (control_0 == null)
			{
				control_0 = new Control();
				control_0.set_BackColor(((Control)this).get_BackColor());
				((Control)this).get_Controls().Add(control_0);
			}
			control_0.set_Bounds(new Rectangle(((Control)hscrollBarAdv_0).get_Bounds().Right, ((Control)vscrollBarAdv_0).get_Bounds().Bottom, ((Control)vscrollBarAdv_0).get_Width(), ((Control)hscrollBarAdv_0).get_Height()));
		}
		else if (control_0 != null)
		{
			((Control)this).get_Controls().Remove(control_0);
			((Component)(object)control_0).Dispose();
			control_0 = null;
		}
		method_50();
	}

	private void method_50()
	{
		Rectangle rectangle = Class52.smethod_12(BackgroundStyle, ((Control)this).get_ClientRectangle());
		if (control0_0 != null)
		{
			Rectangle screenRectangle = GetScreenRectangle(new Rectangle(rectangle.X, rectangle.Y, rectangle.Width - ((vscrollBarAdv_0 != null) ? ((Control)vscrollBarAdv_0).get_Width() : 0), control0_0.ColumnHeaderCollection_0.Bounds.Height));
			screenRectangle.X = rectangle.X;
			screenRectangle.Y = rectangle.Y;
			screenRectangle.Width = Math.Max(0, rectangle.Width - ((vscrollBarAdv_0 != null) ? ((Control)vscrollBarAdv_0).get_Width() : 0));
			screenRectangle.Height = Math.Max(0, screenRectangle.Height);
			((Control)control0_0).set_Bounds(screenRectangle);
		}
	}

	private void method_51()
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

	private void method_52()
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

	private Matrix method_53(float float_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Matrix val = new Matrix(float_1, 0f, 0f, float_1, 0f, 0f);
		if (Boolean_0)
		{
			float num = 0f;
			float num2 = 0f;
			if (AutoScroll)
			{
				if (((Control)this).get_Width() > Class17_0.Int32_0)
				{
					num = ((!((float)((Control)this).get_Width() < (float)Class17_0.Int32_0 * float_1)) ? (((float)((Control)this).get_Width() * (1f / float_1) - (float)((Control)this).get_Width()) / 2f) : ((float)(-(((Control)this).get_Width() - Class17_0.Int32_0) / 2)));
				}
				if (((Control)this).get_Height() > Class17_0.Int32_1)
				{
					num2 = ((!((float)((Control)this).get_Height() < (float)Class17_0.Int32_1 * float_1)) ? (((float)((Control)this).get_Height() * (1f / float_1) - (float)((Control)this).get_Height()) / 2f) : ((float)(-(((Control)this).get_Height() - Class17_0.Int32_1) / 2)));
				}
			}
			else
			{
				num = ((float)((Control)this).get_Width() * (1f / float_1) - (float)((Control)this).get_Width()) / 2f;
				num2 = ((float)((Control)this).get_Height() * (1f / float_1) - (float)((Control)this).get_Height()) / 2f;
			}
			val.Translate(num, num2);
		}
		return val;
	}

	public Matrix GetTranslationMatrix()
	{
		return method_53(float_0);
	}

	public virtual Rectangle GetLayoutRectangle(Rectangle r)
	{
		if (float_0 == 1f)
		{
			return r;
		}
		Point[] array = new Point[2]
		{
			new Point(r.X, r.Y),
			new Point(r.Right, r.Bottom)
		};
		Matrix translationMatrix = GetTranslationMatrix();
		try
		{
			translationMatrix.Invert();
			translationMatrix.TransformPoints(array);
		}
		finally
		{
			((IDisposable)translationMatrix)?.Dispose();
		}
		return new Rectangle(array[0].X, array[0].Y, array[1].X - array[0].X, array[1].Y - array[0].Y);
	}

	protected virtual Point GetLayoutPosition(MouseEventArgs e)
	{
		return GetLayoutPosition(e.get_X(), e.get_Y());
	}

	public virtual Point GetLayoutPosition(Point mousePosition)
	{
		return GetLayoutPosition(mousePosition.X, mousePosition.Y);
	}

	public virtual Point GetLayoutPosition(int x, int y)
	{
		if (float_0 == 1f)
		{
			return new Point(x, y);
		}
		Point[] array = new Point[1]
		{
			new Point(x, y)
		};
		Matrix translationMatrix = GetTranslationMatrix();
		try
		{
			translationMatrix.Invert();
			translationMatrix.TransformPoints(array);
		}
		finally
		{
			((IDisposable)translationMatrix)?.Dispose();
		}
		return array[0];
	}

	public virtual Rectangle GetScreenRectangle(Rectangle r)
	{
		if (float_0 == 1f)
		{
			return r;
		}
		Point[] array = new Point[2]
		{
			new Point(r.X, r.Y),
			new Point(r.Right, r.Bottom)
		};
		Matrix translationMatrix = GetTranslationMatrix();
		try
		{
			translationMatrix.TransformPoints(array);
		}
		finally
		{
			((IDisposable)translationMatrix)?.Dispose();
		}
		return new Rectangle(array[0].X, array[0].Y, array[1].X - array[0].X, array[1].Y - array[0].Y);
	}

	public virtual Size GetScreenSize(Size s)
	{
		return GetScreenRectangle(new Rectangle(Point.Empty, s)).Size;
	}

	internal void method_54(object sender, MouseEventArgs e)
	{
		OnColumnHeaderMouseUp(sender, e);
	}

	protected virtual void OnColumnHeaderMouseUp(object sender, MouseEventArgs e)
	{
		if (mouseEventHandler_1 != null)
		{
			mouseEventHandler_1.Invoke(sender, e);
		}
	}

	internal void method_55(object sender, MouseEventArgs e)
	{
		OnColumnHeaderMouseDown(sender, e);
	}

	protected virtual void OnColumnHeaderMouseDown(object sender, MouseEventArgs e)
	{
		if (mouseEventHandler_0 != null)
		{
			mouseEventHandler_0.Invoke(sender, e);
		}
	}

	internal void method_56(AdvTreeCellBeforeCheckEventArgs advTreeCellBeforeCheckEventArgs_0)
	{
		OnBeforeCheck(advTreeCellBeforeCheckEventArgs_0);
	}

	protected virtual void OnBeforeCheck(AdvTreeCellBeforeCheckEventArgs e)
	{
		if (advTreeCellBeforeCheckEventHandler_0 != null)
		{
			advTreeCellBeforeCheckEventHandler_0(this, e);
		}
	}

	internal void method_57(AdvTreeCellEventArgs advTreeCellEventArgs_0)
	{
		OnAfterCheck(advTreeCellEventArgs_0);
	}

	protected virtual void OnAfterCheck(AdvTreeCellEventArgs e)
	{
		if (advTreeCellEventHandler_0 != null)
		{
			advTreeCellEventHandler_0(this, e);
		}
	}

	internal void method_58(Node node_4, CommandButtonEventArgs commandButtonEventArgs_0)
	{
		if (commandButtonEventHandler_0 != null)
		{
			commandButtonEventHandler_0(node_4, commandButtonEventArgs_0);
		}
	}

	protected virtual void OnBeforeCellEdit(CellEditEventArgs e)
	{
		if (cellEditEventHandler_0 != null)
		{
			cellEditEventHandler_0(this, e);
		}
	}

	void INodeNotify.OnBeforeCollapse(AdvTreeNodeCancelEventArgs e)
	{
		if (advTreeNodeCancelEventHandler_0 != null)
		{
			advTreeNodeCancelEventHandler_0(this, e);
		}
	}

	void INodeNotify.OnAfterCollapse(AdvTreeNodeEventArgs e)
	{
		if (advTreeNodeEventHandler_0 != null)
		{
			advTreeNodeEventHandler_0(this, e);
		}
	}

	void INodeNotify.OnBeforeExpand(AdvTreeNodeCancelEventArgs e)
	{
		if (advTreeNodeCancelEventHandler_1 != null)
		{
			advTreeNodeCancelEventHandler_1(this, e);
		}
	}

	void INodeNotify.OnAfterExpand(AdvTreeNodeEventArgs e)
	{
		if (advTreeNodeEventHandler_1 != null)
		{
			advTreeNodeEventHandler_1(this, e);
		}
	}

	internal void method_59(AdvTreeNodeEventArgs advTreeNodeEventArgs_0)
	{
		OnAfterNodeDeselect(advTreeNodeEventArgs_0);
	}

	protected virtual void OnAfterNodeDeselect(AdvTreeNodeEventArgs args)
	{
		if (advTreeNodeEventHandler_3 != null)
		{
			advTreeNodeEventHandler_3(this, args);
		}
	}

	internal void method_60(AdvTreeNodeEventArgs advTreeNodeEventArgs_0)
	{
		OnAfterNodeSelect(advTreeNodeEventArgs_0);
	}

	protected virtual void OnAfterNodeSelect(AdvTreeNodeEventArgs args)
	{
		if (advTreeNodeEventHandler_2 != null)
		{
			advTreeNodeEventHandler_2(this, args);
		}
	}

	internal void method_61(AdvTreeNodeCancelEventArgs advTreeNodeCancelEventArgs_0)
	{
		OnBeforeNodeSelect(advTreeNodeCancelEventArgs_0);
	}

	protected virtual void OnBeforeNodeSelect(AdvTreeNodeCancelEventArgs args)
	{
		if (advTreeNodeCancelEventHandler_2 != null)
		{
			advTreeNodeCancelEventHandler_2(this, args);
		}
	}

	protected virtual void OnDeserializeNode(SerializeNodeEventArgs e)
	{
		if (serializeNodeEventHandler_1 != null)
		{
			serializeNodeEventHandler_1(this, e);
		}
	}

	protected virtual void OnSerializeNode(SerializeNodeEventArgs e)
	{
		if (serializeNodeEventHandler_0 != null)
		{
			serializeNodeEventHandler_0(this, e);
		}
	}

	internal void method_62(SerializeNodeEventArgs serializeNodeEventArgs_0)
	{
		OnSerializeNode(serializeNodeEventArgs_0);
	}

	internal void method_63(SerializeNodeEventArgs serializeNodeEventArgs_0)
	{
		OnDeserializeNode(serializeNodeEventArgs_0);
	}

	internal void method_64(object sender, MarkupLinkClickEventArgs e)
	{
		OnMarkupLinkClick(sender, e);
		int_1 = 0;
	}

	protected virtual void OnMarkupLinkClick(object sender, MarkupLinkClickEventArgs e)
	{
		if (markupLinkClickEventHandler_0 != null)
		{
			markupLinkClickEventHandler_0(sender, e);
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetCursorPos(int X, int Y);

	protected override void OnDragDrop(DragEventArgs drgevent)
	{
		((Control)this).OnDragDrop(drgevent);
		method_65(drgevent);
	}

	internal void method_65(DragEventArgs dragEventArgs_0)
	{
		method_72(bool_25: true);
	}

	protected override void OnDragLeave(EventArgs e)
	{
		((Control)this).OnDragLeave(e);
		method_66();
	}

	internal void method_66()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		method_72(bool_25: false);
		if (AutoScroll && timer_1 == null)
		{
			timer_1 = new Timer();
			timer_1.set_Interval(100);
			timer_1.add_Tick((EventHandler)timer_1_Tick);
			timer_1.Start();
		}
	}

	private void method_67()
	{
		Timer val = timer_1;
		if (val != null)
		{
			timer_1 = null;
			val.Stop();
			val.remove_Tick((EventHandler)timer_1_Tick);
			((Component)(object)val).Dispose();
		}
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		if ((int)Control.get_MouseButtons() == 1048576 && ((Control)this).get_IsHandleCreated() && AutoScroll)
		{
			Point point = ((Control)this).PointToClient(Control.get_MousePosition());
			if (point.Y < 0 && AutoScrollPosition.Y != 0 && vscrollBarAdv_0 != null)
			{
				AutoScrollPosition = new Point(AutoScrollPosition.X, Math.Min(0, AutoScrollPosition.Y + vscrollBarAdv_0.SmallChange));
			}
			else if (vscrollBarAdv_0 != null && point.Y > ((Control)this).get_ClientRectangle().Bottom && -(AutoScrollPosition.Y - vscrollBarAdv_0.SmallChange) < vscrollBarAdv_0.Maximum - vscrollBarAdv_0.LargeChange)
			{
				AutoScrollPosition = new Point(AutoScrollPosition.X, Math.Min(0, AutoScrollPosition.Y - vscrollBarAdv_0.SmallChange));
			}
		}
		else
		{
			method_67();
		}
	}

	protected override void OnDragEnter(DragEventArgs drgevent)
	{
		method_67();
		((Control)this).OnDragEnter(drgevent);
	}

	protected override void OnDragOver(DragEventArgs drgevent)
	{
		((Control)this).OnDragOver(drgevent);
		method_68(drgevent);
	}

	protected virtual void OnNodeDragFeedback(TreeDragFeedbackEventArgs e)
	{
		treeDragFeedbackEventHander_0?.Invoke(this, e);
	}

	internal void method_68(DragEventArgs dragEventArgs_0)
	{
		if (!bool_7)
		{
			return;
		}
		if (node_3 == null)
		{
			method_73(dragEventArgs_0);
		}
		if (node_3 == null)
		{
			dragEventArgs_0.set_Effect((DragDropEffects)0);
			return;
		}
		dragEventArgs_0.set_Effect((DragDropEffects)2);
		method_7(node_3);
		Point mousePosition = ((Control)this).PointToClient(new Point(dragEventArgs_0.get_X(), dragEventArgs_0.get_Y()));
		mousePosition = GetLayoutPosition(mousePosition);
		Class24 @class = Class15.smethod_26(this, mousePosition.X, mousePosition.Y);
		Class2 class2 = null;
		if (@class != null && @class.node_1 == null && ((Control)this).get_ClientRectangle().Contains(mousePosition.X, mousePosition.Y))
		{
			Node node = Class15.smethod_6(this);
			if (node != null && mousePosition.Y >= node.Bounds.Y)
			{
				@class.node_1 = node;
			}
		}
		if (@class != null && @class.node_1 != null && @class.node_1 != node_3.Tag && !Class15.smethod_30((Node)node_3.Tag, @class.node_1))
		{
			Rectangle rectangle = NodeDisplay.smethod_0(Enum4.const_5, @class.node_1, nodeDisplay_0.Offset);
			Rectangle rectangle2 = NodeDisplay.smethod_0(Enum4.const_0, @class.node_1, nodeDisplay_0.Offset);
			if ((double)mousePosition.X > (double)rectangle2.X + (double)rectangle2.Width * 0.7)
			{
				TreeDragFeedbackEventArgs treeDragFeedbackEventArgs = new TreeDragFeedbackEventArgs(@class.node_1, -1, (Node)node_3.Tag);
				OnNodeDragFeedback(treeDragFeedbackEventArgs);
				if (treeDragFeedbackEventArgs.AllowDrop)
				{
					class2 = new Class2(treeDragFeedbackEventArgs.ParentNode, treeDragFeedbackEventArgs.InsertPosition);
				}
				else
				{
					dragEventArgs_0.set_Effect((DragDropEffects)0);
				}
			}
			else
			{
				TreeDragFeedbackEventArgs treeDragFeedbackEventArgs2 = null;
				treeDragFeedbackEventArgs2 = ((mousePosition.Y < rectangle.Y + rectangle.Height / 3) ? new TreeDragFeedbackEventArgs(@class.node_1.Parent, @class.node_1.Index - 1, (Node)node_3.Tag) : ((mousePosition.X < rectangle2.X) ? new TreeDragFeedbackEventArgs(@class.node_1.Parent, @class.node_1.Index + 1, (Node)node_3.Tag) : ((!@class.node_1.Expanded || @class.node_1.Nodes.Count <= 0) ? new TreeDragFeedbackEventArgs(@class.node_1.Parent, @class.node_1.Index, (Node)node_3.Tag) : new TreeDragFeedbackEventArgs(@class.node_1, -1, (Node)node_3.Tag))));
				OnNodeDragFeedback(treeDragFeedbackEventArgs2);
				if (treeDragFeedbackEventArgs2.AllowDrop)
				{
					class2 = new Class2(treeDragFeedbackEventArgs2.ParentNode, treeDragFeedbackEventArgs2.InsertPosition);
				}
				else
				{
					dragEventArgs_0.set_Effect((DragDropEffects)0);
				}
			}
		}
		else
		{
			if (AutoScroll)
			{
				if (mousePosition.Y < 0)
				{
					if (vscrollBarAdv_0 != null && vscrollBarAdv_0.Value > 0)
					{
						vscrollBarAdv_0.Value -= vscrollBarAdv_0.SmallChange;
					}
				}
				else if (mousePosition.Y > ((Control)this).get_ClientRectangle().Bottom && vscrollBarAdv_0 != null && vscrollBarAdv_0.Value + vscrollBarAdv_0.SmallChange < vscrollBarAdv_0.Maximum)
				{
					vscrollBarAdv_0.Value += vscrollBarAdv_0.SmallChange;
				}
			}
			dragEventArgs_0.set_Effect((DragDropEffects)0);
		}
		bool flag = false;
		if (class2 != null)
		{
			if (class2_0 == null)
			{
				class2_0 = class2;
				method_69(class2_0);
				flag = true;
			}
			else if (class2_0.node_0 != class2.node_0 || class2_0.int_0 != class2.int_0)
			{
				method_69(class2_0);
				method_69(class2);
				class2_0 = class2;
				flag = true;
			}
		}
		else if (class2 != class2_0)
		{
			method_69(class2_0);
			class2_0 = null;
			flag = true;
		}
		node_3.SetBounds(new Rectangle(mousePosition.X, mousePosition.Y, node_3.BoundsRelative.Width, node_3.BoundsRelative.Height));
		node_3.Visible = true;
		method_7(node_3);
		if (flag)
		{
			if (((Component)this).DesignMode)
			{
				((Control)this).Refresh();
			}
			else
			{
				((Control)this).Update();
			}
		}
	}

	private void method_69(Class2 class2_1)
	{
		if (class2_1 != null)
		{
			Rectangle rectangle = method_71(class2_1);
			if (!rectangle.IsEmpty)
			{
				((Control)this).Invalidate(rectangle);
			}
		}
	}

	private Node method_70(Class2 class2_1)
	{
		Node result = null;
		NodeCollection nodeCollection = null;
		nodeCollection = ((class2_1.node_0 == null) ? Nodes : class2_1.node_0.Nodes);
		if (nodeCollection.Count > 0)
		{
			result = ((class2_1.int_0 <= 0) ? nodeCollection[0] : ((class2_1.int_0 < nodeCollection.Count) ? nodeCollection[class2_1.int_0] : nodeCollection[nodeCollection.Count - 1]));
		}
		return result;
	}

	internal Rectangle method_71(Class2 class2_1)
	{
		if (class2_1 == null)
		{
			return Rectangle.Empty;
		}
		Rectangle result = Rectangle.Empty;
		Node node = method_70(class2_1);
		if (node != null)
		{
			result = NodeDisplay.smethod_0(Enum4.const_0, node, nodeDisplay_0.Offset);
			result.Width = node.Bounds.Width;
			if (node.Expanded && class2_1.int_0 >= 0)
			{
				result.Y = NodeDisplay.smethod_0(Enum4.const_3, node, nodeDisplay_0.Offset).Bottom - result.Height;
			}
		}
		else if (class2_1.node_0 != null)
		{
			result = NodeDisplay.smethod_0(Enum4.const_0, class2_1.node_0, nodeDisplay_0.Offset);
			result.X += Indent;
			result.Width = class2_1.node_0.Bounds.Width;
		}
		if (class2_1.int_0 < 0 && node != null)
		{
			result.Y -= 4;
		}
		else
		{
			result.Y = result.Bottom - 2;
		}
		result.Height = 9;
		return result;
	}

	private void method_72(bool bool_25)
	{
		if (node_3 == null)
		{
			return;
		}
		BeginUpdate();
		try
		{
			if (nodeDisplay_0.LockOffset)
			{
				nodeDisplay_0.LockOffset = false;
			}
			Node node = node_3.Tag as Node;
			if (!node.Visible)
			{
				node.Visible = true;
			}
			if (bool_25 && class2_0 != null)
			{
				Node node2 = class2_0.node_0;
				TreeDragDropEventArgs treeDragDropEventArgs = new TreeDragDropEventArgs(eTreeAction.Mouse, node, node.Parent, node2);
				InvokeBeforeNodeDrop(treeDragDropEventArgs);
				if (!treeDragDropEventArgs.Cancel)
				{
					int index = node.Index;
					int num = class2_0.int_0 + 1;
					if (node.Parent == node2 && index < num)
					{
						num--;
					}
					node.Remove(eTreeAction.Mouse);
					if (num < 0)
					{
						num = 0;
					}
					else if (node2 != null && num > node2.Nodes.Count)
					{
						num = node2.Nodes.Count;
					}
					else if (node2 == null && num > Nodes.Count)
					{
						num = Nodes.Count;
					}
					if (node2 == null)
					{
						Nodes.Insert(num, node, eTreeAction.Mouse);
					}
					else
					{
						node2.Nodes.Insert(num, node, eTreeAction.Mouse);
						if (!node2.Expanded)
						{
							node2.Expanded = true;
						}
					}
					InvokeAfterNodeDrop(treeDragDropEventArgs);
				}
			}
			class2_0 = null;
		}
		finally
		{
			node_3 = null;
			if (!bool_0)
			{
				EndUpdate();
				RecalcLayout();
				((Control)this).Refresh();
			}
			else
			{
				EndUpdate();
			}
		}
	}

	protected virtual void OnNodeDragStart(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(sender, e);
	}

	private void method_73(DragEventArgs dragEventArgs_0)
	{
		if (dragEventArgs_0.get_Data() != null)
		{
			Node node = null;
			if (dragEventArgs_0.get_Data().GetDataPresent(typeof(Node)))
			{
				node = dragEventArgs_0.get_Data().GetData(typeof(Node)) as Node;
			}
			else if (dragEventArgs_0.get_Data().GetFormats().Length > 0)
			{
				node = dragEventArgs_0.get_Data().GetData(dragEventArgs_0.get_Data().GetFormats()[0]) as Node;
			}
			if (node != null)
			{
				method_74(node);
			}
		}
	}

	private void method_74(Node node_4)
	{
		AdvTreeNodeCancelEventArgs advTreeNodeCancelEventArgs = new AdvTreeNodeCancelEventArgs(eTreeAction.Mouse, node_4);
		OnBeforeNodeDragStart(advTreeNodeCancelEventArgs);
		if (!advTreeNodeCancelEventArgs.Cancel)
		{
			node_3 = node_4.Copy();
			node_3.Tag = node_4;
			node_3.IsDragNode = true;
			method_75(node_3, node_4);
			node_3.Visible = false;
			class17_0.PerformSingleNodeLayout(node_3);
			((Control)this).Refresh();
			OnNodeDragStart(node_4, new EventArgs());
		}
	}

	protected virtual void OnBeforeNodeDragStart(AdvTreeNodeCancelEventArgs e)
	{
		if (advTreeNodeCancelEventHandler_3 != null)
		{
			advTreeNodeCancelEventHandler_3(this, e);
		}
	}

	private void method_75(Node node_4, Node node_5)
	{
		int alpha = 128;
		ElementStyle elementStyle = null;
		if (node_5.Style != null)
		{
			elementStyle = node_5.Style.Copy();
		}
		else if (NodeStyle != null)
		{
			elementStyle = NodeStyle.Copy();
		}
		else
		{
			elementStyle = new ElementStyle();
			elementStyle.TextColorSchemePart = eColorSchemePart.ItemText;
		}
		ElementStyle.SetColorsAlpha(elementStyle, alpha);
		node_4.Style = elementStyle;
		elementStyle = ((CellStyleDefault == null) ? ElementStyle.GetDefaultCellStyle(node_4.Style) : CellStyleDefault.Copy());
		ElementStyle.SetColorsAlpha(elementStyle, alpha);
		foreach (Cell cell in node_4.Cells)
		{
			cell.StyleNormal = elementStyle;
		}
		for (int i = 0; i < node_4.Cells.Count; i++)
		{
			if (node_5.Cells[i].StyleNormal != null)
			{
				ElementStyle styleNormal = node_5.Cells[i].StyleNormal.Copy();
				ElementStyle.SetColorsAlpha(elementStyle, alpha);
				node_4.Cells[i].StyleNormal = styleNormal;
			}
			else
			{
				node_4.Cells[i].StyleNormal = elementStyle;
			}
		}
	}

	private bool method_76()
	{
		if (node_1 == null)
		{
			return false;
		}
		return method_77(node_1);
	}

	internal bool method_77(Node node_4)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (!IsDragDropInProgress && node_4.DragDropEnabled)
		{
			method_33(eTreeAction.Mouse);
			if (node_4.IsMouseDown)
			{
				method_28(new MouseEventArgs(Control.get_MouseButtons(), 0, 0, 0, 0));
			}
			if (node_4 == node_2)
			{
				return false;
			}
			Control.get_MousePosition();
			if (((Component)this).DesignMode)
			{
				method_74(node_4);
			}
			else
			{
				((Control)this).DoDragDrop((object)node_4, (DragDropEffects)(-2147483645));
			}
			return true;
		}
		return false;
	}

	internal Node method_78()
	{
		if (node_2 != null)
		{
			return node_2;
		}
		if (Nodes.Count > 0)
		{
			return Nodes[0];
		}
		return null;
	}

	internal Node method_79()
	{
		return node_3;
	}

	internal Class2 method_80()
	{
		return class2_0;
	}

	public void BeginInit()
	{
		BeginUpdate();
	}

	public void EndInit()
	{
		EndUpdate();
	}

	internal void method_81()
	{
		if (nodeDisplay_0 != null)
		{
			nodeDisplay_0.PaintedNodes.Clear();
		}
		if (arrayList_1 != null)
		{
			arrayList_1.Clear();
		}
		SelectedNode = null;
		RecalcLayout();
	}

	protected virtual void OnFormattingEnabledChanged(EventArgs e)
	{
		eventHandler_3?.Invoke(this, e);
	}

	protected virtual void OnFormatStringChanged(EventArgs e)
	{
		eventHandler_4?.Invoke(this, e);
	}

	protected virtual void OnFormatInfoChanged(EventArgs e)
	{
		eventHandler_5?.Invoke(this, e);
	}

	private void method_82(object object_2, List<BindingMemberInfo> list_1, bool bool_25)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		bool flag = object_1 != object_2;
		bool flag2 = list_0 != list_1;
		if (bool_22)
		{
			return;
		}
		try
		{
			if (bool_25 || flag || flag2)
			{
				bool_22 = true;
				IList list = ((DataManager != null) ? DataManager.get_List() : null);
				bool flag3 = DataManager == null;
				method_89();
				object_1 = object_2;
				list_0 = list_1;
				method_91();
				if (bool_24)
				{
					CurrencyManager val = null;
					if (object_2 != null && ((Control)this).get_BindingContext() != null && object_2 != Convert.DBNull)
					{
						string text = "";
						if (list_0 != null && list_0.Count > 0)
						{
							BindingMemberInfo val2 = list_1[0];
							text = ((BindingMemberInfo)(ref val2)).get_BindingPath();
						}
						val = (CurrencyManager)((Control)this).get_BindingContext().get_Item(object_2, text);
					}
					if (currencyManager_0 != val)
					{
						if (currencyManager_0 != null)
						{
							currencyManager_0.remove_ItemChanged(new ItemChangedEventHandler(currencyManager_0_ItemChanged));
							((BindingManagerBase)currencyManager_0).remove_PositionChanged((EventHandler)currencyManager_0_PositionChanged);
						}
						currencyManager_0 = val;
						if (currencyManager_0 != null)
						{
							currencyManager_0.add_ItemChanged(new ItemChangedEventHandler(currencyManager_0_ItemChanged));
							((BindingManagerBase)currencyManager_0).add_PositionChanged((EventHandler)currencyManager_0_PositionChanged);
						}
					}
					if (currencyManager_0 != null && (flag2 || flag) && !method_83(list_0))
					{
						throw new ArgumentException("Wrong DisplayMembers parameter", "newDisplayMember");
					}
					if (currencyManager_0 != null && (flag || flag2 || bool_25) && (flag2 || (bool_25 && (list != currencyManager_0.get_List() || flag3))))
					{
						currencyManager_0_ItemChanged(currencyManager_0, null);
					}
				}
				hashtable_0.Clear();
			}
			if (flag)
			{
				OnDataSourceChanged(EventArgs.Empty);
			}
			if (flag2)
			{
				OnDisplayMembersChanged(EventArgs.Empty);
			}
		}
		finally
		{
			bool_22 = false;
		}
	}

	private bool method_83(List<BindingMemberInfo> list_1)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (list_1 != null && list_1.Count != 0)
		{
			foreach (BindingMemberInfo item in list_1)
			{
				BindingMemberInfo current = item;
				if (((BindingMemberInfo)(ref current)).get_BindingMember() != null && !method_84(current))
				{
					return false;
				}
			}
			return true;
		}
		return true;
	}

	private bool method_84(BindingMemberInfo bindingMemberInfo_1)
	{
		if (currencyManager_0 != null)
		{
			PropertyDescriptorCollection itemProperties = ((BindingManagerBase)currencyManager_0).GetItemProperties();
			int count = itemProperties.Count;
			for (int i = 0; i < count; i++)
			{
				if (!typeof(IList).IsAssignableFrom(itemProperties[i].PropertyType) && itemProperties[i].Name.Equals(((BindingMemberInfo)(ref bindingMemberInfo_1)).get_BindingField()))
				{
					return true;
				}
			}
			for (int j = 0; j < count; j++)
			{
				if (!typeof(IList).IsAssignableFrom(itemProperties[j].PropertyType) && string.Compare(itemProperties[j].Name, ((BindingMemberInfo)(ref bindingMemberInfo_1)).get_BindingField(), ignoreCase: true, CultureInfo.CurrentCulture) == 0)
				{
					return true;
				}
			}
		}
		return false;
	}

	protected virtual void OnDataSourceChanged(EventArgs e)
	{
		eventHandler_1?.Invoke(this, e);
	}

	protected virtual void OnDisplayMembersChanged(EventArgs e)
	{
		eventHandler_2?.Invoke(this, e);
	}

	private TypeConverter method_85(string string_4)
	{
		if (hashtable_0.ContainsKey(string_4))
		{
			return (TypeConverter)hashtable_0[string_4];
		}
		if (DataManager != null)
		{
			PropertyDescriptorCollection itemProperties = ((BindingManagerBase)DataManager).GetItemProperties();
			if (itemProperties != null)
			{
				PropertyDescriptor propertyDescriptor = itemProperties.Find(string_4, ignoreCase: true);
				if (propertyDescriptor != null)
				{
					hashtable_0.Add(string_4, propertyDescriptor.Converter);
					return propertyDescriptor.Converter;
				}
			}
		}
		return null;
	}

	private void currencyManager_0_ItemChanged(object sender, ItemChangedEventArgs e)
	{
		if (currencyManager_0 == null)
		{
			return;
		}
		if (e != null && e.get_Index() != -1)
		{
			SetItemCore(e.get_Index(), currencyManager_0.get_List()[e.get_Index()]);
			return;
		}
		SetItemsCore(currencyManager_0.get_List());
		if (Boolean_4)
		{
			if (((BindingManagerBase)currencyManager_0).get_Position() == -1)
			{
				SelectedNode = null;
			}
			else
			{
				SelectedNode = FindNodeByBindingIndex(((BindingManagerBase)currencyManager_0).get_Position());
			}
		}
	}

	private void currencyManager_0_PositionChanged(object sender, EventArgs e)
	{
		if (currencyManager_0 != null && Boolean_4)
		{
			if (((BindingManagerBase)currencyManager_0).get_Position() == -1)
			{
				SelectedNode = null;
			}
			else
			{
				SelectedNode = FindNodeByBindingIndex(((BindingManagerBase)currencyManager_0).get_Position());
			}
		}
	}

	protected virtual void RefreshItems()
	{
		if (currencyManager_0 == null)
		{
			return;
		}
		SetItemsCore(currencyManager_0.get_List());
		if (Boolean_4)
		{
			if (((BindingManagerBase)currencyManager_0).get_Position() == -1)
			{
				SelectedNode = null;
			}
			else
			{
				SelectedNode = FindNodeByBindingIndex(((BindingManagerBase)currencyManager_0).get_Position());
			}
		}
	}

	protected virtual void SetItemsCore(IList items)
	{
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		BeginUpdate();
		Nodes.Clear();
		bool flag = !string.IsNullOrEmpty(string_3);
		List<string> list = new List<string>();
		if (string.IsNullOrEmpty(DisplayMembers))
		{
			if (Columns.Count > 0)
			{
				foreach (ColumnHeader column in Columns)
				{
					if (!string.IsNullOrEmpty(column.DataFieldName))
					{
						list.Add(column.DataFieldName);
					}
				}
			}
			if (list.Count == 0)
			{
				Columns.Clear();
				if (currencyManager_0 != null)
				{
					PropertyDescriptorCollection itemProperties = ((BindingManagerBase)currencyManager_0).GetItemProperties();
					foreach (PropertyDescriptor item in itemProperties)
					{
						list.Add(item.Name);
						ColumnHeader columnHeader2 = new ColumnHeader(Class91.smethod_1(item.Name));
						columnHeader2.DataFieldName = item.Name;
						columnHeader2.Width.Relative = Math.Max(15, 100 / itemProperties.Count);
						Columns.Add(columnHeader2);
						OnDataColumnCreated(new DataColumnEventArgs(columnHeader2));
					}
				}
			}
		}
		else
		{
			Columns.Clear();
			if (list_0 != null && list_0.Count > 0)
			{
				foreach (BindingMemberInfo item2 in list_0)
				{
					BindingMemberInfo current = item2;
					ColumnHeader columnHeader3 = new ColumnHeader(Class91.smethod_1(((BindingMemberInfo)(ref current)).get_BindingMember()));
					columnHeader3.Tag = current;
					columnHeader3.Width.Relative = Math.Max(15, 100 / list_0.Count);
					Columns.Add(columnHeader3);
					list.Add(((BindingMemberInfo)(ref current)).get_BindingMember());
					OnDataColumnCreated(new DataColumnEventArgs(columnHeader3));
				}
			}
		}
		if (string.IsNullOrEmpty(string_3))
		{
			for (int i = 0; i < items.Count; i++)
			{
				object object_ = items[i];
				method_87(Nodes, object_, i, list);
			}
		}
		else
		{
			string[] array = string_3.Split(new char[1] { ',' });
			for (int j = 0; j < array.Length; j++)
			{
				array[j] = array[j].Trim();
			}
			Dictionary<string, Node> dictionary = new Dictionary<string, Node>();
			for (int k = 0; k < items.Count; k++)
			{
				object obj = items[k];
				NodeCollection nodes = Nodes;
				for (int l = 0; l < array.Length; l++)
				{
					string itemText = GetItemText(obj, array[l]);
					Node value = null;
					if (!dictionary.TryGetValue(itemText.ToLower(), out value))
					{
						value = method_86(nodes, itemText);
						dictionary.Add(itemText.ToLower(), value);
					}
					nodes = value.Nodes;
				}
				method_87(nodes, obj, k, list);
			}
		}
		if (flag)
		{
			ExpandWidth = 14;
		}
		else
		{
			ExpandWidth = 0;
		}
		EndUpdate();
	}

	protected virtual void OnDataColumnCreated(DataColumnEventArgs args)
	{
		if (dataColumnEventHandler_0 != null)
		{
			dataColumnEventHandler_0(this, args);
		}
	}

	private Node method_86(NodeCollection nodeCollection_1, string string_4)
	{
		Node node = new Node();
		node.Text = string_4;
		node.Style = elementStyle_15;
		node.Expanded = true;
		node.Selectable = false;
		nodeCollection_1.Add(node);
		DataNodeEventArgs dataNodeEventArgs = new DataNodeEventArgs(node, null);
		OnGroupNodeCreated(dataNodeEventArgs);
		return node;
	}

	protected virtual void OnGroupNodeCreated(DataNodeEventArgs dataNodeEventArgs)
	{
		if (dataNodeEventHandler_1 != null)
		{
			dataNodeEventHandler_1(this, dataNodeEventArgs);
		}
	}

	private Node method_87(NodeCollection nodeCollection_1, object object_2, int int_14, List<string> list_1)
	{
		Node node = new Node();
		nodeCollection_1.Add(node);
		method_88(node, object_2, list_1, int_14);
		DataNodeEventArgs dataNodeEventArgs = new DataNodeEventArgs(node, object_2);
		OnDataNodeCreated(dataNodeEventArgs);
		return dataNodeEventArgs.Node;
	}

	private void method_88(Node node_4, object object_2, List<string> list_1, int int_14)
	{
		node_4.DataKey = object_2;
		node_4.BindingIndex = int_14;
		node_4.CreateCells();
		if (list_1.Count > 0)
		{
			for (int i = 0; i < list_1.Count; i++)
			{
				node_4.Cells[i].Text = GetItemText(object_2, list_1[i]);
			}
		}
		else if (object_2 != null)
		{
			node_4.Text = object_2.ToString();
		}
	}

	protected virtual void OnDataNodeCreated(DataNodeEventArgs dataNodeEventArgs)
	{
		if (dataNodeEventHandler_0 != null)
		{
			dataNodeEventHandler_0(this, dataNodeEventArgs);
		}
	}

	protected virtual void SetItemCore(int index, object value)
	{
		Node node = FindNodeByBindingIndex(index);
		if (node == null)
		{
			return;
		}
		List<string> list = new List<string>();
		foreach (ColumnHeader column in Columns)
		{
			if (!string.IsNullOrEmpty(column.DataFieldName))
			{
				list.Add(column.DataFieldName);
			}
		}
		method_88(node, value, list, index);
	}

	protected virtual void OnGroupingMembersChanged()
	{
		RefreshItems();
	}

	private void method_89()
	{
		if (object_1 is IComponent)
		{
			((IComponent)object_1).Disposed -= method_90;
		}
		if (object_1 is ISupportInitializeNotification supportInitializeNotification && bool_23)
		{
			supportInitializeNotification.Initialized -= method_92;
			bool_23 = false;
		}
	}

	private void method_90(object sender, EventArgs e)
	{
		method_82(null, null, bool_25: true);
	}

	private void method_91()
	{
		if (object_1 is IComponent)
		{
			((IComponent)object_1).Disposed += method_90;
		}
		if (object_1 is ISupportInitializeNotification supportInitializeNotification && !supportInitializeNotification.IsInitialized)
		{
			supportInitializeNotification.Initialized += method_92;
			bool_23 = true;
			bool_24 = false;
		}
		else
		{
			bool_24 = true;
		}
	}

	private void method_92(object sender, EventArgs e)
	{
		method_82(object_1, list_0, bool_25: true);
	}

	protected virtual void OnFormat(TreeConvertEventArgs e)
	{
		treeConvertEventHandler_0?.Invoke(this, e);
	}

	public string GetItemText(object item, string fieldName)
	{
		object propertyValue = GetPropertyValue(item, fieldName);
		if (!bool_21)
		{
			if (item == null)
			{
				return string.Empty;
			}
			if (propertyValue == null)
			{
				return "";
			}
			return Convert.ToString(propertyValue, CultureInfo.CurrentCulture);
		}
		TreeConvertEventArgs treeConvertEventArgs = new TreeConvertEventArgs(propertyValue, typeof(string), item, fieldName);
		OnFormat(treeConvertEventArgs);
		if (((ConvertEventArgs)treeConvertEventArgs).get_Value() != item && ((ConvertEventArgs)treeConvertEventArgs).get_Value() is string)
		{
			return (string)((ConvertEventArgs)treeConvertEventArgs).get_Value();
		}
		if (typeConverter_0 == null)
		{
			typeConverter_0 = TypeDescriptor.GetConverter(typeof(string));
		}
		try
		{
			return (string)Class93.smethod_0(propertyValue, typeof(string), method_85(fieldName), typeConverter_0, string_2, iformatProvider_0, null, DBNull.Value);
		}
		catch (Exception ex)
		{
			if (!(ex is SecurityException) && !smethod_2(ex))
			{
				return (propertyValue != null) ? Convert.ToString(item, CultureInfo.CurrentCulture) : "";
			}
			throw;
		}
	}

	private static bool smethod_2(Exception exception_0)
	{
		if (!(exception_0 is NullReferenceException) && !(exception_0 is StackOverflowException) && !(exception_0 is OutOfMemoryException) && !(exception_0 is ThreadAbortException) && !(exception_0 is ExecutionEngineException) && !(exception_0 is IndexOutOfRangeException))
		{
			return exception_0 is AccessViolationException;
		}
		return true;
	}

	protected object GetPropertyValue(object item, string fieldName)
	{
		if (item != null && fieldName.Length > 0)
		{
			try
			{
				PropertyDescriptor propertyDescriptor = ((currencyManager_0 == null) ? TypeDescriptor.GetProperties(item).Find(fieldName, ignoreCase: true) : ((BindingManagerBase)currencyManager_0).GetItemProperties().Find(fieldName, ignoreCase: true));
				if (propertyDescriptor == null)
				{
					return item;
				}
				item = propertyDescriptor.GetValue(item);
				return item;
			}
			catch
			{
				return item;
			}
		}
		return item;
	}

	private void method_93(int int_14)
	{
		if (int_14 == -1)
		{
			SelectedNode = null;
			return;
		}
		Node node = null;
		node = (SelectedNode = ((currencyManager_0 == null) ? GetNodeByFlatIndex(int_14) : FindNodeByBindingIndex(int_14)));
	}

	protected virtual void OnSelectedIndexChanged(EventArgs e)
	{
		eventHandler_8?.Invoke(this, e);
	}

	protected virtual void OnValueMemberChanged(EventArgs e)
	{
		eventHandler_6?.Invoke(this, e);
	}

	protected virtual void OnSelectedValueChanged(EventArgs e)
	{
		eventHandler_7?.Invoke(this, e);
	}
}
