using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.AdvTree.Design;
using DevComponents.AdvTree.Display;
using DevComponents.DotNetBar.Design;
using DevComponents.Editors;

namespace DevComponents.DotNetBar.Controls;

[DefaultEvent("TextChanged")]
[DefaultBindingProperty("Text")]
[Designer(typeof(ComboTreeDesigner))]
[ToolboxBitmap(typeof(ComboTree), "Controls.ComboTree.ico")]
[ToolboxItem(true)]
[DefaultProperty("Text")]
public class ComboTree : PopupItemControl, ICommandSource, IInputButtonControl
{
	private DevComponents.AdvTree.AdvTree advTree_0;

	private ButtonItem buttonItem_0;

	private static string string_0 = "sysPopupItemContainer";

	private static string string_1 = "sysPopupControlContainer";

	private Color color_0 = ColorScheme.GetColor(16777096);

	private bool bool_5;

	private CancelEventHandler cancelEventHandler_0;

	private CancelEventHandler cancelEventHandler_1;

	private EventHandler eventHandler_5;

	private EventHandler eventHandler_6;

	private EventHandler eventHandler_7;

	private AdvTreeNodeCancelEventHandler advTreeNodeCancelEventHandler_0;

	private AdvTreeNodeEventHandler advTreeNodeEventHandler_0;

	private EventHandler eventHandler_8;

	private EventHandler eventHandler_9;

	private TreeConvertEventHandler treeConvertEventHandler_0;

	private EventHandler eventHandler_10;

	private EventHandler eventHandler_11;

	private EventHandler eventHandler_12;

	private DataNodeEventHandler dataNodeEventHandler_0;

	private DataNodeEventHandler dataNodeEventHandler_1;

	private EventHandler eventHandler_13;

	private EventHandler eventHandler_14;

	private EventHandler eventHandler_15;

	private DataColumnEventHandler dataColumnEventHandler_0;

	private bool bool_6 = true;

	private List<BindingMemberInfo> list_0;

	private object object_0;

	private bool bool_7;

	private string string_2 = "";

	private IFormatProvider iformatProvider_0;

	private bool bool_8;

	private Hashtable hashtable_1 = new Hashtable();

	private string string_3 = "";

	private ElementStyle elementStyle_0;

	private CurrencyManager currencyManager_0;

	private bool bool_9;

	private bool bool_10;

	private static TypeConverter typeConverter_0;

	private BindingMemberInfo bindingMemberInfo_0 = default(BindingMemberInfo);

	private Font font_0;

	private Color color_1 = SystemColors.GrayText;

	private bool bool_11 = true;

	private string string_4 = "";

	private eTextAlignment eTextAlignment_0;

	private ElementStyle elementStyle_1 = new ElementStyle();

	private InputButtonSettings inputButtonSettings_0;

	private InputButtonSettings inputButtonSettings_1;

	private InputButtonSettings inputButtonSettings_2;

	private InputButtonSettings inputButtonSettings_3;

	private VisualGroup visualGroup_0;

	private bool bool_12;

	private bool bool_13 = true;

	private Timer timer_1;

	private int int_0 = 1000;

	private string string_5 = "";

	private bool bool_14;

	private Control control_0;

	private bool bool_15;

	private DateTime dateTime_0 = DateTime.MinValue;

	private Control control_1;

	private int int_1;

	private int int_2;

	private ICommand icommand_0;

	private object object_1;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Node SelectedNode
	{
		get
		{
			return advTree_0.SelectedNode;
		}
		set
		{
			advTree_0.SelectedNode = value;
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether selection change on popup tree closes the popup.")]
	[Category("Behavior")]
	public bool SelectionClosesPopup
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

	[DefaultValue("")]
	[Category("Data")]
	[Description("Indicates comma separated list of property or column names to display on popup tree control")]
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
				method_12(object_0, list2, bool_16: false);
			}
			catch
			{
				list_0 = list;
			}
		}
	}

	[Description("Indicates data source for the ComboTree.")]
	[RefreshProperties(RefreshProperties.Repaint)]
	[DefaultValue(null)]
	[Category("Data")]
	[AttributeProvider(typeof(IListSource))]
	public object DataSource
	{
		get
		{
			return object_0;
		}
		set
		{
			if (value != null && !(value is IList) && !(value is IListSource))
			{
				throw new ArgumentException("Data type is not supported for complex data binding");
			}
			if (object_0 != value)
			{
				try
				{
					method_12(value, list_0, bool_16: false);
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
			return bool_7;
		}
		set
		{
			if (value != bool_7)
			{
				bool_7 = value;
				RefreshItems();
				OnFormattingEnabledChanged(EventArgs.Empty);
			}
		}
	}

	[Editor("System.Windows.Forms.Design.FormatStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[Description("Indicates format-specifier characters that indicate how a value is to be displayed.")]
	[DefaultValue("")]
	[MergableProperty(false)]
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

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DefaultValue(null)]
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

	[Category("Data")]
	[Description("Indicates comma separated list of field or property names that are used for grouping when data-binding is used")]
	[DefaultValue("")]
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

	[DefaultValue(null)]
	[Category("Node Style")]
	[Description("Gets or sets default style for the node.")]
	[Editor(typeof(ElementStyleTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	public ElementStyle GroupNodeStyle
	{
		get
		{
			return elementStyle_0;
		}
		set
		{
			if (elementStyle_0 != value)
			{
				elementStyle_0 = value;
				if (currencyManager_0 != null && advTree_0.Nodes != null)
				{
					RefreshItems();
				}
			}
		}
	}

	private bool Boolean_1 => true;

	protected CurrencyManager DataManager => currencyManager_0;

	[Description("Gets or sets the index specifying the currently selected item.")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int SelectedIndex
	{
		get
		{
			if (currencyManager_0 != null)
			{
				if (advTree_0.SelectedNode != null && advTree_0.SelectedNode.BindingIndex >= 0)
				{
					return advTree_0.SelectedNode.BindingIndex;
				}
				return -1;
			}
			if (advTree_0.SelectedNode == null)
			{
				return -1;
			}
			return advTree_0.GetNodeFlatIndex(advTree_0.SelectedNode);
		}
		set
		{
			method_23(value);
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
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			if (value == null)
			{
				value = "";
			}
			BindingMemberInfo val = default(BindingMemberInfo);
			((BindingMemberInfo)(ref val))._002Ector(value);
			if (!((object)(BindingMemberInfo)(ref val)).Equals((object?)bindingMemberInfo_0))
			{
				if (DisplayMembers.Length == 0 && Columns.Count == 0)
				{
					List<BindingMemberInfo> list = new List<BindingMemberInfo>();
					list.Add(val);
					method_12(DataSource, list, bool_16: false);
				}
				if (currencyManager_0 != null && value != null && value.Length != 0 && !method_14(val))
				{
					throw new ArgumentException("Invalid value for ValueMember", "value");
				}
				bindingMemberInfo_0 = val;
				OnValueMemberChanged(EventArgs.Empty);
				OnSelectedValueChanged(EventArgs.Empty);
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DefaultValue(null)]
	[Description("Indicates value of the member property specified by the ValueMember property.")]
	[Bindable(true)]
	[Category("Data")]
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

	[Description("Indicates watermark font.")]
	[DefaultValue(null)]
	[Category("Appearance")]
	[Browsable(true)]
	public virtual Font WatermarkFont
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
			((Control)this).Invalidate();
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates watermark text color.")]
	public virtual Color WatermarkColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates whether watermark text is displayed if set for the input items.")]
	[DefaultValue(true)]
	public virtual bool WatermarkEnabled
	{
		get
		{
			return bool_11;
		}
		set
		{
			bool_11 = value;
			((Control)this).Invalidate();
		}
	}

	[Category("Watermark")]
	[DefaultValue("")]
	[Description("Indicates watermark text displayed on the input control when control is empty.")]
	public string WatermarkText
	{
		get
		{
			return string_4;
		}
		set
		{
			if (value != null)
			{
				string_4 = value;
				((Control)this).Invalidate();
			}
		}
	}

	[DefaultValue(eTextAlignment.Left)]
	[Category("Watermark")]
	[Description("Indicates watermark text alignment.")]
	[Browsable(true)]
	public eTextAlignment WatermarkAlignment
	{
		get
		{
			return eTextAlignment_0;
		}
		set
		{
			if (eTextAlignment_0 != value)
			{
				eTextAlignment_0 = value;
				((Control)this).Invalidate();
			}
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[Description("Indicates whether FocusHighlightColor is used as background color to highlight text box when it has input focus.")]
	[DefaultValue(false)]
	public bool FocusHighlightEnabled
	{
		get
		{
			return bool_5;
		}
		set
		{
			if (bool_5 != value)
			{
				bool_5 = value;
				if (((Control)this).get_Focused())
				{
					((Control)this).Invalidate(true);
				}
			}
		}
	}

	[Category("Appearance")]
	[Description("Indicates color used as background color to highlight text box when it has input focus and focus highlight is enabled.")]
	[Browsable(true)]
	public Color FocusHighlightColor
	{
		get
		{
			return color_0;
		}
		set
		{
			if (color_0 != value)
			{
				color_0 = value;
				if (((Control)this).get_Focused())
				{
					((Control)this).Invalidate(true);
				}
			}
		}
	}

	[Category("Style")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets or sets control background style.")]
	public ElementStyle BackgroundStyle => elementStyle_1;

	[Category("Buttons")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Describes the settings for the button that shows drop-down when clicked.")]
	public InputButtonSettings ButtonDropDown => inputButtonSettings_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Buttons")]
	[Description("Describes the settings for the button that clears the content of the control when clicked.")]
	public InputButtonSettings ButtonClear => inputButtonSettings_1;

	[Category("Buttons")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Describes the settings for the custom button that can execute an custom action of your choosing when clicked.")]
	public InputButtonSettings ButtonCustom => inputButtonSettings_2;

	[Category("Buttons")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Describes the settings for the custom button that can execute an custom action of your choosing when clicked.")]
	public InputButtonSettings ButtonCustom2 => inputButtonSettings_3;

	protected virtual bool IsWatermarkRendered
	{
		get
		{
			if (!((Control)this).get_Focused())
			{
				return SelectedNode == null;
			}
			return false;
		}
	}

	[Category("Behavior")]
	[DefaultValue(true)]
	[Description("Indicates whether keyboard incremental search is enabled.")]
	public bool KeyboardSearchEnabled
	{
		get
		{
			return bool_13;
		}
		set
		{
			bool_13 = value;
		}
	}

	[DefaultValue(1000)]
	[Description("Indicates keyboard search buffer expiration timeout.")]
	[Category("Behavior")]
	public int SearchBufferExpireTimeout
	{
		get
		{
			return int_0;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			int_0 = value;
		}
	}

	[Description("Indicates reference of the control that will be displayed on popup that is shown when drop-down button is clicked.")]
	[DefaultValue(null)]
	internal Control Control_0
	{
		get
		{
			return control_1;
		}
		set
		{
			control_1 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public SubItemsCollection DropDownItems => buttonItem_0.SubItems;

	private bool Boolean_2
	{
		get
		{
			if ((inputButtonSettings_2 != null && inputButtonSettings_2.Visible) || (inputButtonSettings_3 != null && inputButtonSettings_3.Visible) || (inputButtonSettings_0 != null && inputButtonSettings_0.Visible))
			{
				return true;
			}
			if (inputButtonSettings_1 != null)
			{
				return inputButtonSettings_1.Visible;
			}
			return false;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public DevComponents.AdvTree.AdvTree AdvTree => advTree_0;

	[Category("Behavior")]
	[DefaultValue(0)]
	[Description("Indicates height in pixels of the drop-down portion of the ComboTreeBox control.")]
	public int DropDownHeight
	{
		get
		{
			return int_1;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("DropDownHeight Value must be equal or greater than zero.");
			}
			int_1 = value;
			method_48();
		}
	}

	[Category("Behavior")]
	[Description("Indicates width in pixels of the drop-down portion of the ComboTreeBox control.")]
	[DefaultValue(0)]
	public int DropDownWidth
	{
		get
		{
			return int_2;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("DropDownWidth Value must be equal or greater than zero.");
			}
			int_2 = value;
			method_48();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool IsPopupOpen
	{
		get
		{
			return buttonItem_0.Expanded;
		}
		set
		{
			if (value != buttonItem_0.Expanded)
			{
				if (value)
				{
					ShowDropDown();
				}
				else
				{
					CloseDropDown();
				}
			}
		}
	}

	[Description("Gets the collection of tree nodes that are assigned to the tree control.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	public NodeCollection Nodes => advTree_0.Nodes;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets collection of column headers that appear in the popup tree.")]
	[Category("Columns")]
	public ColumnHeaderCollection Columns => advTree_0.Columns;

	[Description("Indicates whether column headers are visible if they are defined through Columns collection.")]
	[DefaultValue(true)]
	[Category("Columns")]
	public bool ColumnsVisible
	{
		get
		{
			return advTree_0.ColumnsVisible;
		}
		set
		{
			advTree_0.ColumnsVisible = value;
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether grid lines are displayed when columns are defined.")]
	[Category("Columns")]
	public bool GridColumnLines
	{
		get
		{
			return advTree_0.GridColumnLines;
		}
		set
		{
			advTree_0.GridColumnLines = value;
		}
	}

	[Category("Columns")]
	[Description("Indicates grid lines color.")]
	public Color GridLinesColor
	{
		get
		{
			return advTree_0.GridLinesColor;
		}
		set
		{
			advTree_0.GridLinesColor = value;
		}
	}

	[Category("Columns")]
	[DefaultValue(false)]
	[Description("")]
	public bool GridRowLines
	{
		get
		{
			return advTree_0.GridRowLines;
		}
		set
		{
			advTree_0.GridRowLines = value;
		}
	}

	[Category("Appearance")]
	[DefaultValue(true)]
	[Description("Indicates whether node is highlighted when mouse enters the node.")]
	public bool HotTracking
	{
		get
		{
			return advTree_0.HotTracking;
		}
		set
		{
			advTree_0.HotTracking = value;
		}
	}

	[Description("Indicates node selection box style of popup tree control.")]
	[DefaultValue(eSelectionStyle.HighlightCells)]
	[Category("Selection")]
	public eSelectionStyle SelectionBoxStyle
	{
		get
		{
			return advTree_0.SelectionBoxStyle;
		}
		set
		{
			advTree_0.SelectionBoxStyle = value;
		}
	}

	[Description("Indicates the ImageList that contains the Image objects used by the tree nodes.")]
	[Category("Images")]
	[DefaultValue(null)]
	[Browsable(true)]
	public ImageList ImageList
	{
		get
		{
			return advTree_0.ImageList;
		}
		set
		{
			advTree_0.ImageList = value;
		}
	}

	[Category("Images")]
	[Browsable(true)]
	[Description("Indicates the image-list index value of the default image that is displayed by the tree nodes.")]
	[DefaultValue(-1)]
	[TypeConverter(typeof(ImageIndexConverter))]
	[Editor(typeof(DevComponents.AdvTree.ImageIndexEditor), typeof(UITypeEditor))]
	public int ImageIndex
	{
		get
		{
			return advTree_0.ImageIndex;
		}
		set
		{
			advTree_0.ImageIndex = value;
		}
	}

	[Description("Indicates the command assigned to the item.")]
	[DefaultValue(null)]
	[Category("Commands")]
	public Command Command
	{
		get
		{
			return (Command)((ICommandSource)this).Command;
		}
		set
		{
			((ICommandSource)this).Command = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	ICommand ICommandSource.Command
	{
		get
		{
			return icommand_0;
		}
		set
		{
			bool flag = false;
			if (icommand_0 != value)
			{
				flag = true;
			}
			if (icommand_0 != null)
			{
				CommandManager.UnRegisterCommandSource(this, icommand_0);
			}
			icommand_0 = value;
			if (value != null)
			{
				CommandManager.RegisterCommand(this, value);
			}
			if (flag)
			{
				OnCommandChanged();
			}
		}
	}

	[Description("Indicates user defined data value that can be passed to the command when it is executed.")]
	[Browsable(true)]
	[DefaultValue(null)]
	[Category("Commands")]
	[TypeConverter(typeof(StringConverter))]
	[Localizable(true)]
	public object CommandParameter
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

	public event CancelEventHandler ButtonClearClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_0, value);
		}
	}

	public event CancelEventHandler ButtonDropDownClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_1 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_1 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_1, value);
		}
	}

	public event EventHandler ButtonCustomClick
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

	public event EventHandler ButtonCustom2Click
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

	[Description("Occurs when the text alignment in text box has changed.")]
	public event EventHandler TextAlignChanged
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

	public event AdvTreeNodeCancelEventHandler SelectionChanging
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

	public event AdvTreeNodeEventHandler SelectionChanged
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

	[Description("Occurs when the DataSource changes.")]
	public event EventHandler DataSourceChanged
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

	[Description("Occurs when the DisplayMembers property changes")]
	public event EventHandler DisplayMembersChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_9 = (EventHandler)Delegate.Combine(eventHandler_9, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_9 = (EventHandler)Delegate.Remove(eventHandler_9, value);
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
			eventHandler_10 = (EventHandler)Delegate.Combine(eventHandler_10, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_10 = (EventHandler)Delegate.Remove(eventHandler_10, value);
		}
	}

	[Description("Occurs when FormatString property changes.")]
	public event EventHandler FormatStringChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_11 = (EventHandler)Delegate.Combine(eventHandler_11, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_11 = (EventHandler)Delegate.Remove(eventHandler_11, value);
		}
	}

	[Description("Occurs when FormatInfo property has changed.")]
	public event EventHandler FormatInfoChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_12 = (EventHandler)Delegate.Combine(eventHandler_12, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_12 = (EventHandler)Delegate.Remove(eventHandler_12, value);
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
			eventHandler_13 = (EventHandler)Delegate.Combine(eventHandler_13, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_13 = (EventHandler)Delegate.Remove(eventHandler_13, value);
		}
	}

	[Description("Occurs when value of SelectedValue property has changed.")]
	public event EventHandler SelectedValueChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_14 = (EventHandler)Delegate.Combine(eventHandler_14, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_14 = (EventHandler)Delegate.Remove(eventHandler_14, value);
		}
	}

	[Description("Occurs when value of SelectedValue property has changed.")]
	public event EventHandler SelectedIndexChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_15 = (EventHandler)Delegate.Combine(eventHandler_15, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_15 = (EventHandler)Delegate.Remove(eventHandler_15, value);
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

	public ComboTree()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)512, true);
		method_11();
		((Control)this).set_BackColor(SystemColors.Window);
	}

	private void method_11()
	{
		elementStyle_1.method_4(base.ColorScheme);
		elementStyle_1.StyleChanged += elementStyle_1_StyleChanged;
		inputButtonSettings_2 = new InputButtonSettings(this);
		inputButtonSettings_3 = new InputButtonSettings(this);
		inputButtonSettings_1 = new InputButtonSettings(this);
		inputButtonSettings_0 = new InputButtonSettings(this);
		method_28();
		advTree_0 = new DevComponents.AdvTree.AdvTree();
		advTree_0.BackgroundStyle.Reset();
		advTree_0.BackgroundStyle.BackColor = SystemColors.Window;
		advTree_0.BackgroundStyle.Border = eStyleBorderType.None;
		advTree_0.ExpandButtonType = eExpandButtonType.Triangle;
		advTree_0.DragDropEnabled = false;
		advTree_0.HotTracking = true;
		advTree_0.Indent = 6;
		advTree_0.SelectionFocusAware = false;
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Name = "nodeElementStyle";
		elementStyle.TextColor = SystemColors.ControlText;
		advTree_0.NodeStyle = elementStyle;
		advTree_0.PathSeparator = ";";
		advTree_0.Styles.Add(elementStyle);
		advTree_0.AfterNodeSelect += advTree_0_AfterNodeSelect;
		advTree_0.BeforeNodeSelect += advTree_0_BeforeNodeSelect;
		Control_0 = (Control)(object)advTree_0;
	}

	private void advTree_0_BeforeNodeSelect(object sender, AdvTreeNodeCancelEventArgs e)
	{
		if (advTreeNodeCancelEventHandler_0 != null)
		{
			advTreeNodeCancelEventHandler_0(this, e);
		}
	}

	private void advTree_0_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
	{
		if (advTreeNodeEventHandler_0 != null)
		{
			advTreeNodeEventHandler_0(this, e);
		}
		if (currencyManager_0 != null)
		{
			Node selectedNode = advTree_0.SelectedNode;
			if (selectedNode != null && selectedNode.BindingIndex > -1 && ((BindingManagerBase)currencyManager_0).get_Position() != selectedNode.BindingIndex)
			{
				((BindingManagerBase)currencyManager_0).set_Position(selectedNode.BindingIndex);
			}
			else if (selectedNode == null)
			{
				((BindingManagerBase)currencyManager_0).set_Position(-1);
			}
		}
		if (SelectionClosesPopup && IsPopupOpen && e.Action == eTreeAction.Mouse)
		{
			IsPopupOpen = false;
		}
		if (e.Node != null)
		{
			((Control)this).set_Text(e.Node.ToString());
		}
		((Control)this).Invalidate();
		OnSelectedIndexChanged(EventArgs.Empty);
		if (!string.IsNullOrEmpty(ValueMember))
		{
			OnSelectedValueChanged(EventArgs.Empty);
		}
	}

	protected virtual void OnFormattingEnabledChanged(EventArgs e)
	{
		eventHandler_10?.Invoke(this, e);
	}

	protected virtual void OnFormatStringChanged(EventArgs e)
	{
		eventHandler_11?.Invoke(this, e);
	}

	protected virtual void OnFormatInfoChanged(EventArgs e)
	{
		eventHandler_12?.Invoke(this, e);
	}

	private void method_12(object object_2, List<BindingMemberInfo> list_1, bool bool_16)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		bool flag = object_0 != object_2;
		bool flag2 = list_0 != list_1;
		if (bool_8)
		{
			return;
		}
		try
		{
			if (bool_16 || flag || flag2)
			{
				bool_8 = true;
				IList list = ((DataManager != null) ? DataManager.get_List() : null);
				bool flag3 = DataManager == null;
				method_19();
				object_0 = object_2;
				list_0 = list_1;
				method_21();
				if (bool_10)
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
					if (currencyManager_0 != null && (flag2 || flag) && !method_13(list_0))
					{
						throw new ArgumentException("Wrong DisplayMembers parameter", "newDisplayMember");
					}
					if (currencyManager_0 != null && (flag || flag2 || bool_16) && (flag2 || (bool_16 && (list != currencyManager_0.get_List() || flag3))))
					{
						currencyManager_0_ItemChanged(currencyManager_0, null);
					}
				}
				hashtable_1.Clear();
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
			bool_8 = false;
		}
	}

	private bool method_13(List<BindingMemberInfo> list_1)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (list_1 != null && list_1.Count != 0)
		{
			foreach (BindingMemberInfo item in list_1)
			{
				BindingMemberInfo current = item;
				if (((BindingMemberInfo)(ref current)).get_BindingMember() != null && !method_14(current))
				{
					return false;
				}
			}
			return true;
		}
		return true;
	}

	private bool method_14(BindingMemberInfo bindingMemberInfo_1)
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
		eventHandler_8?.Invoke(this, e);
	}

	protected virtual void OnDisplayMembersChanged(EventArgs e)
	{
		eventHandler_9?.Invoke(this, e);
	}

	private TypeConverter method_15(string string_6)
	{
		if (hashtable_1.ContainsKey(string_6))
		{
			return (TypeConverter)hashtable_1[string_6];
		}
		if (DataManager != null)
		{
			PropertyDescriptorCollection itemProperties = ((BindingManagerBase)DataManager).GetItemProperties();
			if (itemProperties != null)
			{
				PropertyDescriptor propertyDescriptor = itemProperties.Find(string_6, ignoreCase: true);
				if (propertyDescriptor != null)
				{
					hashtable_1.Add(string_6, propertyDescriptor.Converter);
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
		if (Boolean_1)
		{
			if (((BindingManagerBase)currencyManager_0).get_Position() == -1)
			{
				SelectedNode = null;
			}
			else
			{
				SelectedNode = advTree_0.FindNodeByBindingIndex(((BindingManagerBase)currencyManager_0).get_Position());
			}
		}
	}

	private void currencyManager_0_PositionChanged(object sender, EventArgs e)
	{
		if (currencyManager_0 != null && Boolean_1)
		{
			if (((BindingManagerBase)currencyManager_0).get_Position() == -1)
			{
				SelectedNode = null;
			}
			else
			{
				SelectedNode = advTree_0.FindNodeByBindingIndex(((BindingManagerBase)currencyManager_0).get_Position());
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
		if (Boolean_1)
		{
			if (((BindingManagerBase)currencyManager_0).get_Position() == -1)
			{
				SelectedNode = null;
			}
			else
			{
				SelectedNode = advTree_0.FindNodeByBindingIndex(((BindingManagerBase)currencyManager_0).get_Position());
			}
		}
	}

	protected virtual void SetItemsCore(IList items)
	{
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)(object)this).DesignMode)
		{
			return;
		}
		advTree_0.BeginUpdate();
		advTree_0.Nodes.Clear();
		bool flag = !string.IsNullOrEmpty(string_3);
		List<string> list = new List<string>();
		if (string.IsNullOrEmpty(DisplayMembers))
		{
			if (advTree_0.Columns.Count > 0)
			{
				foreach (ColumnHeader column in advTree_0.Columns)
				{
					if (!string.IsNullOrEmpty(column.DataFieldName))
					{
						list.Add(column.DataFieldName);
					}
				}
			}
			if (list.Count == 0)
			{
				advTree_0.Columns.Clear();
				if (currencyManager_0 != null)
				{
					PropertyDescriptorCollection itemProperties = ((BindingManagerBase)currencyManager_0).GetItemProperties();
					foreach (PropertyDescriptor item in itemProperties)
					{
						list.Add(item.Name);
						ColumnHeader columnHeader2 = new ColumnHeader(Class91.smethod_1(item.Name));
						columnHeader2.DataFieldName = item.Name;
						columnHeader2.Width.Relative = Math.Max(10, 100 / itemProperties.Count);
						advTree_0.Columns.Add(columnHeader2);
						OnDataColumnCreated(new DataColumnEventArgs(columnHeader2));
					}
				}
			}
		}
		else
		{
			advTree_0.Columns.Clear();
			if (list_0 != null && list_0.Count > 0)
			{
				foreach (BindingMemberInfo item2 in list_0)
				{
					BindingMemberInfo current = item2;
					ColumnHeader columnHeader3 = new ColumnHeader(Class91.smethod_1(((BindingMemberInfo)(ref current)).get_BindingMember()));
					columnHeader3.Tag = current;
					columnHeader3.Width.Relative = Math.Max(10, 100 / list_0.Count);
					advTree_0.Columns.Add(columnHeader3);
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
				method_17(advTree_0.Nodes, object_, i, list);
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
				NodeCollection nodes = advTree_0.Nodes;
				for (int l = 0; l < array.Length; l++)
				{
					string itemText = GetItemText(obj, array[l]);
					Node value = null;
					if (!dictionary.TryGetValue(itemText.ToLower(), out value))
					{
						value = method_16(nodes, itemText);
						dictionary.Add(itemText.ToLower(), value);
					}
					nodes = value.Nodes;
				}
				method_17(nodes, obj, k, list);
			}
		}
		if (flag)
		{
			advTree_0.ExpandWidth = 14;
		}
		else
		{
			advTree_0.ExpandWidth = 0;
		}
		advTree_0.EndUpdate();
	}

	protected virtual void OnDataColumnCreated(DataColumnEventArgs args)
	{
		if (dataColumnEventHandler_0 != null)
		{
			dataColumnEventHandler_0(this, args);
		}
	}

	private Node method_16(NodeCollection nodeCollection_0, string string_6)
	{
		Node node = new Node();
		node.Text = string_6;
		node.Style = elementStyle_0;
		node.Expanded = true;
		node.Selectable = false;
		nodeCollection_0.Add(node);
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

	private Node method_17(NodeCollection nodeCollection_0, object object_2, int int_3, List<string> list_1)
	{
		Node node = new Node();
		nodeCollection_0.Add(node);
		method_18(node, object_2, list_1, int_3);
		DataNodeEventArgs dataNodeEventArgs = new DataNodeEventArgs(node, object_2);
		OnDataNodeCreated(dataNodeEventArgs);
		return dataNodeEventArgs.Node;
	}

	private void method_18(Node node_0, object object_2, List<string> list_1, int int_3)
	{
		node_0.DataKey = object_2;
		node_0.BindingIndex = int_3;
		node_0.CreateCells();
		if (list_1.Count > 0)
		{
			for (int i = 0; i < list_1.Count; i++)
			{
				node_0.Cells[i].Text = GetItemText(object_2, list_1[i]);
			}
		}
		else if (object_2 != null)
		{
			node_0.Text = object_2.ToString();
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
		Node node = advTree_0.FindNodeByBindingIndex(index);
		if (node == null)
		{
			return;
		}
		List<string> list = new List<string>();
		foreach (ColumnHeader column in advTree_0.Columns)
		{
			if (!string.IsNullOrEmpty(column.DataFieldName))
			{
				list.Add(column.DataFieldName);
			}
		}
		method_18(node, value, list, index);
	}

	protected virtual void OnGroupingMembersChanged()
	{
		RefreshItems();
	}

	private void method_19()
	{
		if (object_0 is IComponent)
		{
			((IComponent)object_0).Disposed -= method_20;
		}
		if (object_0 is ISupportInitializeNotification supportInitializeNotification && bool_9)
		{
			supportInitializeNotification.Initialized -= method_22;
			bool_9 = false;
		}
	}

	private void method_20(object sender, EventArgs e)
	{
		method_12(null, null, bool_16: true);
	}

	private void method_21()
	{
		if (object_0 is IComponent)
		{
			((IComponent)object_0).Disposed += method_20;
		}
		if (object_0 is ISupportInitializeNotification supportInitializeNotification && !supportInitializeNotification.IsInitialized)
		{
			supportInitializeNotification.Initialized += method_22;
			bool_9 = true;
			bool_10 = false;
		}
		else
		{
			bool_10 = true;
		}
	}

	private void method_22(object sender, EventArgs e)
	{
		method_12(object_0, list_0, bool_16: true);
	}

	protected virtual void OnFormat(TreeConvertEventArgs e)
	{
		treeConvertEventHandler_0?.Invoke(this, e);
	}

	public string GetItemText(object item, string fieldName)
	{
		object propertyValue = GetPropertyValue(item, fieldName);
		if (!bool_7)
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
			return (string)Class93.smethod_0(propertyValue, typeof(string), method_15(fieldName), typeConverter_0, string_2, iformatProvider_0, null, DBNull.Value);
		}
		catch (Exception ex)
		{
			if (!(ex is SecurityException) && !smethod_0(ex))
			{
				return (propertyValue != null) ? Convert.ToString(item, CultureInfo.CurrentCulture) : "";
			}
			throw;
		}
	}

	private static bool smethod_0(Exception exception_0)
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

	private void method_23(int int_3)
	{
		if (int_3 == -1)
		{
			advTree_0.SelectedNode = null;
			return;
		}
		Node node = null;
		node = ((currencyManager_0 == null) ? advTree_0.GetNodeByFlatIndex(int_3) : advTree_0.FindNodeByBindingIndex(int_3));
		advTree_0.SelectedNode = node;
	}

	protected virtual void OnSelectedIndexChanged(EventArgs e)
	{
		eventHandler_15?.Invoke(this, e);
	}

	protected virtual void OnValueMemberChanged(EventArgs e)
	{
		eventHandler_13?.Invoke(this, e);
	}

	protected virtual void OnSelectedValueChanged(EventArgs e)
	{
		eventHandler_14?.Invoke(this, e);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeWatermarkColor()
	{
		return color_1 != SystemColors.GrayText;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetWatermarkColor()
	{
		WatermarkColor = SystemColors.GrayText;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFocusHighlightColor()
	{
		return !color_0.Equals((object?)ColorScheme.GetColor(16777096));
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetFocusHighlightColor()
	{
		FocusHighlightColor = ColorScheme.GetColor(16777096);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackgroundStyle()
	{
		elementStyle_1.StyleChanged -= elementStyle_1_StyleChanged;
		elementStyle_1 = new ElementStyle();
		elementStyle_1.StyleChanged += elementStyle_1_StyleChanged;
		((Control)this).Invalidate();
	}

	private void elementStyle_1_StyleChanged(object sender, EventArgs e)
	{
		OnVisualPropertyChanged();
	}

	protected virtual void OnVisualPropertyChanged()
	{
		visualGroup_0.InvalidateArrange();
		((Control)this).Invalidate();
	}

	protected override void Dispose(bool disposing)
	{
		if (elementStyle_1 != null)
		{
			elementStyle_1.StyleChanged -= elementStyle_1_StyleChanged;
		}
		Timer val = timer_1;
		timer_1 = null;
		if (val != null)
		{
			val.Stop();
			((Component)(object)val).Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	void IInputButtonControl.InputButtonSettingsChanged(InputButtonSettings button)
	{
		OnInputButtonSettingsChanged(button);
	}

	protected virtual void OnInputButtonSettingsChanged(InputButtonSettings inputButtonSettings)
	{
		method_24();
	}

	private void method_24()
	{
		RecreateButtons();
		visualGroup_0.InvalidateArrange();
		((Control)this).Invalidate();
	}

	protected virtual void RecreateButtons()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		VisualItem[] items = method_27();
		VisualGroup visualGroup = visualGroup_0;
		VisualItem[] array = new VisualItem[visualGroup.Items.Count];
		visualGroup.Items.method_0(array);
		VisualItem[] array2 = array;
		foreach (VisualItem visualItem in array2)
		{
			if (visualItem.Enum31_0 == Enum31.const_1)
			{
				visualGroup.Items.Remove(visualItem);
				if (visualItem == inputButtonSettings_2.ItemReference)
				{
					visualItem.MouseUp -= new MouseEventHandler(method_25);
				}
				else if (visualItem == inputButtonSettings_3.ItemReference)
				{
					visualItem.MouseUp -= new MouseEventHandler(method_26);
				}
			}
		}
		visualGroup.Items.AddRange(items);
	}

	private void method_25(object sender, MouseEventArgs e)
	{
		if (inputButtonSettings_2.ItemReference.RenderBounds.Contains(e.get_X(), e.get_Y()))
		{
			OnButtonCustomClick((EventArgs)(object)e);
		}
	}

	protected virtual void OnButtonCustomClick(EventArgs e)
	{
		if (eventHandler_5 != null)
		{
			eventHandler_5(this, e);
		}
	}

	private void method_26(object sender, MouseEventArgs e)
	{
		if (inputButtonSettings_3.ItemReference.RenderBounds.Contains(e.get_X(), e.get_Y()))
		{
			OnButtonCustom2Click((EventArgs)(object)e);
		}
	}

	protected virtual void OnButtonCustom2Click(EventArgs e)
	{
		if (eventHandler_6 != null)
		{
			eventHandler_6(this, e);
		}
	}

	private VisualItem[] method_27()
	{
		SortedList sortedList = CreateSortedButtonList();
		VisualItem[] array = new VisualItem[sortedList.Count];
		sortedList.Values.CopyTo(array, 0);
		return array;
	}

	protected virtual SortedList CreateSortedButtonList()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		SortedList sortedList = new SortedList(4);
		if (inputButtonSettings_2.Visible)
		{
			VisualItem visualItem = CreateButton(inputButtonSettings_2);
			if (inputButtonSettings_2.ItemReference != null)
			{
				inputButtonSettings_2.ItemReference.MouseUp -= new MouseEventHandler(method_25);
			}
			inputButtonSettings_2.ItemReference = visualItem;
			visualItem.MouseUp += new MouseEventHandler(method_25);
			visualItem.Enabled = inputButtonSettings_2.Enabled;
			sortedList.Add(inputButtonSettings_2, visualItem);
		}
		if (inputButtonSettings_3.Visible)
		{
			VisualItem visualItem2 = CreateButton(inputButtonSettings_3);
			if (inputButtonSettings_2.ItemReference != null)
			{
				inputButtonSettings_2.ItemReference.MouseUp -= new MouseEventHandler(method_26);
			}
			inputButtonSettings_3.ItemReference = visualItem2;
			visualItem2.MouseUp += new MouseEventHandler(method_26);
			visualItem2.Enabled = inputButtonSettings_3.Enabled;
			sortedList.Add(inputButtonSettings_3, visualItem2);
		}
		if (inputButtonSettings_1.Visible)
		{
			VisualItem visualItem3 = CreateButton(inputButtonSettings_1);
			if (inputButtonSettings_1.ItemReference != null)
			{
				inputButtonSettings_1.ItemReference.Click -= method_47;
			}
			inputButtonSettings_1.ItemReference = visualItem3;
			visualItem3.MouseUp += new MouseEventHandler(method_47);
			sortedList.Add(inputButtonSettings_1, visualItem3);
		}
		if (inputButtonSettings_0.Visible)
		{
			VisualItem visualItem4 = CreateButton(inputButtonSettings_0);
			if (inputButtonSettings_0.ItemReference != null)
			{
				inputButtonSettings_0.ItemReference.MouseDown -= new MouseEventHandler(method_44);
			}
			inputButtonSettings_0.ItemReference = visualItem4;
			visualItem4.MouseDown += new MouseEventHandler(method_44);
			sortedList.Add(inputButtonSettings_0, visualItem4);
		}
		return sortedList;
	}

	protected virtual VisualItem CreateButton(InputButtonSettings buttonSettings)
	{
		VisualItem visualItem = null;
		if (buttonSettings == inputButtonSettings_0)
		{
			visualItem = new VisualDropDownButton();
			ApplyButtonSettings(buttonSettings, visualItem as VisualButton);
		}
		else
		{
			visualItem = new VisualCustomButton();
			ApplyButtonSettings(buttonSettings, visualItem as VisualButton);
		}
		VisualButton visualButton = visualItem as VisualButton;
		visualButton.ClickAutoRepeat = false;
		if (buttonSettings == inputButtonSettings_1 && buttonSettings.Image == null)
		{
			visualButton.Image = (Image)(object)Class109.smethod_67("SystemImages.DateReset.png");
		}
		return visualItem;
	}

	protected virtual void ApplyButtonSettings(InputButtonSettings buttonSettings, VisualButton button)
	{
		button.Text = buttonSettings.Text;
		button.Image = buttonSettings.Image;
		button.Enum31_0 = Enum31.const_1;
		button.Enabled = buttonSettings.Enabled;
	}

	private void method_28()
	{
		VisualGroup visualGroup = new VisualGroup();
		visualGroup.HorizontalItemSpacing = 1;
		visualGroup.ArrangeInvalid += method_30;
		visualGroup.RenderInvalid += method_29;
		visualGroup_0 = visualGroup;
	}

	private void method_29(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}

	private void method_30(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}

	private PaintInfo method_31(Graphics graphics_0)
	{
		PaintInfo paintInfo = new PaintInfo();
		paintInfo.Graphics = graphics_0;
		paintInfo.DefaultFont = ((Control)this).get_Font();
		paintInfo.ForeColor = ((Control)this).get_ForeColor();
		paintInfo.RenderOffset = default(Point);
		Size size = ((Control)this).get_Size();
		ElementStyle elementStyle = method_32();
		size.Height -= Class52.smethod_8(elementStyle, eSpacePart.Border) + Class52.smethod_10(elementStyle, eSpacePart.Border) + 2;
		size.Width -= Class52.smethod_4(elementStyle, eSpacePart.Border) + Class52.smethod_6(elementStyle, eSpacePart.Border) + 2;
		paintInfo.AvailableSize = size;
		paintInfo.ParentEnabled = ((Control)this).get_Enabled();
		paintInfo.MouseOver = bool_12 || ((Control)this).get_Focused();
		return paintInfo;
	}

	private ElementStyle method_32()
	{
		elementStyle_1.method_4(GetColorScheme());
		return ElementStyleDisplay.smethod_5(elementStyle_1);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnPaint(e);
		Graphics graphics = e.get_Graphics();
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		bool enabled = ((Control)this).get_Enabled();
		if (!Class92.smethod_0() && Class92.bool_0)
		{
			if (!((Control)this).get_Enabled())
			{
				e.get_Graphics().FillRectangle(SystemBrushes.get_Control(), clientRectangle);
			}
			else
			{
				SolidBrush val = new SolidBrush(((Control)this).get_BackColor());
				try
				{
					e.get_Graphics().FillRectangle((Brush)(object)val, clientRectangle);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			ElementStyle elementStyle = method_32();
			if (elementStyle.Custom)
			{
				SmoothingMode smoothingMode = graphics.get_SmoothingMode();
				if (base.AntiAlias)
				{
					graphics.set_SmoothingMode((SmoothingMode)4);
				}
				ElementStyleDisplayInfo e2 = new ElementStyleDisplayInfo(elementStyle, graphics, clientRectangle);
				if (!enabled)
				{
					ElementStyleDisplay.PaintBorder(e2);
				}
				else
				{
					ElementStyleDisplay.Paint(e2);
				}
				if (base.AntiAlias)
				{
					graphics.set_SmoothingMode(smoothingMode);
				}
			}
			Rectangle rectangle_ = method_35(graphics);
			Rectangle rectangle = method_34(elementStyle, clientRectangle);
			if (!rectangle_.IsEmpty)
			{
				Rectangle[] array = Class50.smethod_47(rectangle, rectangle_);
				if (array.Length >= 1)
				{
					rectangle = array[0];
				}
				rectangle.Width--;
			}
			if (WatermarkEnabled && WatermarkText.Length > 0 && IsWatermarkRendered)
			{
				Rectangle rectangle_2 = rectangle;
				rectangle_2.Inflate(-1, -1);
				method_33(graphics, rectangle_2);
			}
			PaintSelection(graphics, rectangle);
		}
		else
		{
			e.get_Graphics().Clear(SystemColors.Control);
		}
	}

	private void method_33(Graphics graphics_0, Rectangle rectangle_0)
	{
		if (WatermarkText.Length != 0)
		{
			Font val = ((Control)this).get_Font();
			if (WatermarkFont != null)
			{
				val = WatermarkFont;
			}
			eTextFormat eTextFormat = eTextFormat.Default;
			if (eTextAlignment_0 == eTextAlignment.Center)
			{
				eTextFormat |= eTextFormat.HorizontalCenter;
			}
			else if (eTextAlignment_0 == eTextAlignment.Right)
			{
				eTextFormat |= eTextFormat.Right;
			}
			Class55.smethod_1(graphics_0, WatermarkText, val, WatermarkColor, rectangle_0, eTextFormat);
		}
	}

	private Rectangle method_34(ElementStyle elementStyle_2, Rectangle rectangle_0)
	{
		return new Rectangle(Class52.smethod_4(elementStyle_2, eSpacePart.Border) + 1, Class52.smethod_8(elementStyle_2, eSpacePart.Border) + 1, rectangle_0.Width - (Class52.smethod_6(elementStyle_2, eSpacePart.Border) + Class52.smethod_4(elementStyle_2, eSpacePart.Border) + 2), rectangle_0.Height - (Class52.smethod_8(elementStyle_2, eSpacePart.Border) + Class52.smethod_10(elementStyle_2, eSpacePart.Border) + 2));
	}

	protected virtual void PaintSelection(Graphics g, Rectangle bounds)
	{
		if (bounds.Width < 2 || bounds.Height < 2)
		{
			return;
		}
		if (((Control)this).get_Focused() && !IsPopupOpen)
		{
			SelectionRendererEventArgs selectionRendererEventArgs = new SelectionRendererEventArgs();
			selectionRendererEventArgs.Bounds = bounds;
			selectionRendererEventArgs.Graphics = g;
			selectionRendererEventArgs.SelectionBoxStyle = eSelectionStyle.HighlightCells;
			selectionRendererEventArgs.TreeActive = true;
			((NodeTreeDisplay)advTree_0.NodeDisplay_0).GetTreeRenderer().DrawSelection(selectionRendererEventArgs);
		}
		Node selectedNode = advTree_0.SelectedNode;
		if (selectedNode == null)
		{
			return;
		}
		if (selectedNode.BoundsRelative.IsEmpty || advTree_0.IsLayoutPending || selectedNode.BoundsRelative.Width <= 0)
		{
			method_45();
			if (advTree_0.IsLayoutPending)
			{
				advTree_0.RecalcLayout();
			}
		}
		Region clip = g.get_Clip();
		g.SetClip(bounds);
		Rectangle bounds2 = bounds;
		if (NodeDisplay.smethod_3(selectedNode))
		{
			bounds2.X -= advTree_0.ExpandWidth;
		}
		else
		{
			bounds2.X -= selectedNode.Bounds.X - selectedNode.BoundsRelative.X - 2;
		}
		if (bounds2.Height > selectedNode.BoundsRelative.Height)
		{
			bounds2.Y += (bounds2.Height - selectedNode.BoundsRelative.Height) / 2;
		}
		else
		{
			bounds2.Y++;
		}
		((NodeTreeDisplay)advTree_0.NodeDisplay_0).ExternalPaintNode(selectedNode, g, bounds2);
		g.set_Clip(clip);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackColor()
	{
		return ((Control)this).get_BackColor() != SystemColors.Window;
	}

	private Rectangle method_35(Graphics graphics_0)
	{
		PaintInfo paintInfo_ = method_31(graphics_0);
		if (!visualGroup_0.IsLayoutValid)
		{
			method_43(paintInfo_);
		}
		ElementStyle elementStyle_ = method_32();
		visualGroup_0.RenderBounds = method_36(elementStyle_);
		visualGroup_0.vmethod_14(paintInfo_);
		return visualGroup_0.RenderBounds;
	}

	private Rectangle method_36(ElementStyle elementStyle_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Control)this).get_RightToLeft() == 1)
		{
			return new Rectangle(Class52.smethod_4(elementStyle_2, eSpacePart.Border) + 1, Class52.smethod_8(elementStyle_2, eSpacePart.Border) + 1, visualGroup_0.Size.Width, visualGroup_0.Size.Height);
		}
		return new Rectangle(((Control)this).get_Width() - (Class52.smethod_6(elementStyle_2, eSpacePart.Border) + 1) - visualGroup_0.Size.Width, Class52.smethod_8(elementStyle_2, eSpacePart.Border) + 1, visualGroup_0.Size.Width, visualGroup_0.Size.Height);
	}

	protected override void OnResize(EventArgs e)
	{
		visualGroup_0.InvalidateArrange();
		method_42();
		((Control)this).Invalidate();
		((Control)this).OnResize(e);
	}

	protected override void OnEnter(EventArgs e)
	{
		((Control)this).Invalidate();
		((Control)this).OnEnter(e);
	}

	protected override void OnLeave(EventArgs e)
	{
		if (IsPopupOpen)
		{
			IsPopupOpen = false;
		}
		((Control)this).Invalidate();
		((Control)this).OnLeave(e);
	}

	protected override bool vmethod_2(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected I4, but got Unknown
		if (((Control)this).get_Focused())
		{
			Keys val = (Keys)Class92.MapVirtualKey((uint)(int)intptr_3, 2u);
			if ((int)val == 0)
			{
				val = (Keys)intptr_3.ToInt32();
			}
			if ((int)val == 115)
			{
				IsPopupOpen = !IsPopupOpen;
				return true;
			}
			if ((int)val == 40 && (Control.get_ModifierKeys() & 0x40000) != 0 && !IsPopupOpen)
			{
				IsPopupOpen = !IsPopupOpen;
				return true;
			}
			if (IsPopupOpen && (int)val == 9)
			{
				IsPopupOpen = false;
			}
			else if (IsPopupOpen)
			{
				if ((int)val == 38)
				{
					method_40(eTreeAction.Keyboard);
					return true;
				}
				if ((int)val == 40)
				{
					method_39(eTreeAction.Keyboard);
					return true;
				}
				try
				{
					byte[] array = new byte[256];
					if (Class92.GetKeyboardState(array))
					{
						byte[] array2 = new byte[2];
						if (Class92.ToAscii((uint)(int)val, 0u, array, array2, 0u) != 0)
						{
							char[] array3 = new char[2];
							Encoding.Default.GetDecoder().GetChars(array2, 0, 2, array3, 0);
							if (method_37(array3[0]))
							{
								return true;
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
		return base.vmethod_2(intptr_2, intptr_3, intptr_4);
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		if (bool_13)
		{
			e.set_Handled(method_37(e.get_KeyChar()));
		}
		((Control)this).OnKeyPress(e);
	}

	private bool method_37(char char_0)
	{
		if (!char.IsLetterOrDigit(char_0))
		{
			return false;
		}
		string text = method_38(char_0.ToString());
		Node node = advTree_0.FindNodeByText(text, advTree_0.SelectedNode, ignoreCase: true);
		if (node == null && advTree_0.SelectedNode != null)
		{
			node = advTree_0.FindNodeByText(text, ignoreCase: true);
		}
		if (node != null && node.BindingIndex == -1)
		{
			while (node != null && node.BindingIndex == -1)
			{
				node = advTree_0.FindNodeByText(text, node, ignoreCase: true);
			}
		}
		method_41(node, eTreeAction.Keyboard);
		return false;
	}

	private string method_38(string string_6)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		if (int_0 <= 0)
		{
			return string_6;
		}
		if (timer_1 == null)
		{
			timer_1 = new Timer();
			timer_1.set_Interval(int_0);
			timer_1.add_Tick((EventHandler)timer_1_Tick);
			timer_1.Start();
		}
		else
		{
			timer_1.Start();
		}
		string_5 += string_6;
		return string_5;
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		timer_1.Stop();
		string_5 = "";
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((keyData & 0x28) == 40 && (Control.get_ModifierKeys() & 0x40000) != 0 && !IsPopupOpen)
		{
			IsPopupOpen = !IsPopupOpen;
			return true;
		}
		if ((int)keyData == 38)
		{
			method_40(eTreeAction.Keyboard);
			return true;
		}
		if ((int)keyData == 40)
		{
			method_39(eTreeAction.Keyboard);
			return true;
		}
		return ((Control)this).ProcessCmdKey(ref msg, keyData);
	}

	private void method_39(eTreeAction eTreeAction_0)
	{
		Node node = null;
		node = ((SelectedNode != null) ? Class15.smethod_9(SelectedNode) : Class15.smethod_4(advTree_0));
		if (node == null)
		{
			return;
		}
		if (currencyManager_0 != null)
		{
			while (node != null && node.DataKey == null)
			{
				node = Class15.smethod_9(node);
			}
			if (node != null)
			{
				method_41(node, eTreeAction_0);
			}
		}
		else
		{
			method_41(node, eTreeAction_0);
		}
	}

	private void method_40(eTreeAction eTreeAction_0)
	{
		Node node = null;
		node = ((SelectedNode != null) ? Class15.smethod_15(SelectedNode) : Class15.smethod_5(advTree_0));
		if (node == null)
		{
			return;
		}
		if (currencyManager_0 != null)
		{
			while (node != null && node.DataKey == null)
			{
				node = Class15.smethod_9(node);
			}
			if (node != null)
			{
				method_41(node, eTreeAction_0);
			}
		}
		else
		{
			method_41(node, eTreeAction_0);
		}
	}

	private void method_41(Node node_0, eTreeAction eTreeAction_0)
	{
		advTree_0.SelectNode(node_0, eTreeAction_0);
	}

	protected override void OnRightToLeftChanged(EventArgs e)
	{
		visualGroup_0.InvalidateArrange();
		method_42();
		((Control)this).Invalidate();
		((Control)this).OnRightToLeftChanged(e);
	}

	protected override void OnFontChanged(EventArgs e)
	{
		visualGroup_0.InvalidateArrange();
		method_42();
		((Control)this).Invalidate();
		base.OnFontChanged(e);
	}

	private void method_42()
	{
		Graphics val = Class109.smethod_68((Control)(object)this);
		try
		{
			method_43(method_31(val));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void method_43(PaintInfo paintInfo_0)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		if (bool_14)
		{
			return;
		}
		bool_14 = true;
		try
		{
			if (!visualGroup_0.IsLayoutValid)
			{
				visualGroup_0.PerformLayout(paintInfo_0);
			}
			ElementStyle elementStyle_ = method_32();
			Rectangle rectangle = Class52.smethod_12(elementStyle_, ((Control)this).get_ClientRectangle());
			if (Boolean_2)
			{
				Rectangle rectangle2 = method_36(elementStyle_);
				if ((int)((Control)this).get_RightToLeft() == 1)
				{
					rectangle.X += rectangle2.Right;
					rectangle.Width -= rectangle2.Right;
				}
				else
				{
					rectangle.Width -= rectangle.Right - rectangle2.X;
				}
			}
		}
		finally
		{
			bool_14 = false;
		}
	}

	private void method_44(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576 && (!(dateTime_0 != DateTime.MinValue) || DateTime.Now.Subtract(dateTime_0).TotalMilliseconds >= 250.0))
		{
			ShowDropDown();
		}
		else
		{
			dateTime_0 = DateTime.MinValue;
		}
	}

	private void method_45()
	{
		if (int_2 == 0)
		{
			((Control)advTree_0).set_Width(((Control)this).get_Width() - 4);
		}
		if (int_1 == 0)
		{
			advTree_0.RecalcLayout();
			Class273 @class = Class109.smethod_53((Control)(object)this);
			if (@class != null && advTree_0.Class17_0.Int32_1 > @class.rectangle_1.Height / 2)
			{
				((Control)advTree_0).set_Height(@class.rectangle_1.Height / 2);
			}
			else if (advTree_0.Nodes.Count > 0)
			{
				((Control)advTree_0).set_Height(advTree_0.Class17_0.Int32_1 + 6);
			}
			else
			{
				((Control)advTree_0).set_Height(((Control)this).get_Height());
			}
		}
		else
		{
			((Control)advTree_0).set_Height(int_1);
		}
	}

	public void ShowDropDown()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		if ((control_1 == null && buttonItem_0.SubItems.Count == 0) || bool_15 || buttonItem_0.Expanded)
		{
			return;
		}
		bool_15 = true;
		try
		{
			method_45();
			ControlContainerItem controlContainerItem = null;
			ItemContainer itemContainer = null;
			if (control_1 != null)
			{
				itemContainer = new ItemContainer();
				itemContainer.Name = string_0;
				controlContainerItem = new ControlContainerItem(string_1);
				itemContainer.SubItems.Add(controlContainerItem);
				buttonItem_0.SubItems.Insert(0, itemContainer);
			}
			CancelEventArgs cancelEventArgs = new CancelEventArgs();
			OnButtonDropDownClick(cancelEventArgs);
			if (cancelEventArgs.Cancel || buttonItem_0.SubItems.Count == 0)
			{
				if (itemContainer != null)
				{
					buttonItem_0.SubItems.Remove(itemContainer);
				}
				return;
			}
			control_0 = control_1.get_Parent();
			controlContainerItem.Control = control_1;
			buttonItem_0.method_4(((Control)this).get_ClientRectangle());
			if ((int)((Control)this).get_RightToLeft() == 0)
			{
				Point point = new Point(((Control)this).get_Width() - buttonItem_0.PopupSize.Width, ((Control)this).get_Height());
				Class273 @class = Class109.smethod_53((Control)(object)this);
				Point point2 = ((Control)this).PointToScreen(point);
				if (@class != null && @class.rectangle_1.X > point2.X)
				{
					point.X = 0;
				}
				buttonItem_0.PopupLocation = point;
			}
			if (!IsPopupOpen && SelectedNode != null)
			{
				SelectedNode.EnsureVisible();
			}
			buttonItem_0.Expanded = !buttonItem_0.Expanded;
		}
		finally
		{
			bool_15 = false;
		}
		((Control)this).Invalidate();
	}

	public void CloseDropDown()
	{
		if (buttonItem_0.Expanded)
		{
			buttonItem_0.Expanded = false;
		}
	}

	private void method_46(object sender, EventArgs e)
	{
		dateTime_0 = DateTime.Now;
		if (buttonItem_0.SubItems[string_0] is ItemContainer itemContainer)
		{
			if (itemContainer.SubItems[string_1] is ControlContainerItem controlContainerItem)
			{
				controlContainerItem.Control = null;
				itemContainer.SubItems.Remove(controlContainerItem);
				if (control_1 != null)
				{
					control_1.set_Parent(control_0);
					control_0 = null;
				}
			}
			buttonItem_0.SubItems.Remove(itemContainer);
		}
		((Control)this).Invalidate();
	}

	private void method_47(object sender, EventArgs e)
	{
		CancelEventArgs cancelEventArgs = new CancelEventArgs();
		OnButtonClearClick(cancelEventArgs);
		if (!cancelEventArgs.Cancel)
		{
			SelectedNode = null;
		}
	}

	protected virtual void OnButtonClearClick(CancelEventArgs e)
	{
		if (cancelEventHandler_0 != null)
		{
			cancelEventHandler_0(this, e);
		}
	}

	protected virtual void OnButtonDropDownClick(CancelEventArgs e)
	{
		if (cancelEventHandler_1 != null)
		{
			cancelEventHandler_1(this, e);
		}
	}

	protected override PopupItem CreatePopupItem()
	{
		ButtonItem buttonItem = new ButtonItem("sysPopupProvider");
		buttonItem.PopupFinalized += method_46;
		buttonItem_0 = buttonItem;
		return buttonItem;
	}

	protected override void RecalcSize()
	{
	}

	public override void PerformClick()
	{
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (Boolean_2)
		{
			visualGroup_0.vmethod_2(e);
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		if (Boolean_2)
		{
			visualGroup_0.vmethod_1();
		}
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).Focus();
		if (Boolean_2)
		{
			visualGroup_0.vmethod_4(e);
		}
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		clientRectangle.Inflate(1, 1);
		if (Boolean_2 && !visualGroup_0.RenderBounds.Contains(e.get_X(), e.get_Y()) && clientRectangle.Contains(e.get_X(), e.get_Y()) && !IsPopupOpen)
		{
			if (dateTime_0 != DateTime.MinValue && DateTime.Now.Subtract(dateTime_0).TotalMilliseconds < 150.0)
			{
				dateTime_0 = DateTime.MinValue;
			}
			else
			{
				IsPopupOpen = true;
			}
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (Boolean_2)
		{
			visualGroup_0.vmethod_5(e);
		}
		((Control)this).OnMouseUp(e);
	}

	private void method_48()
	{
		if (int_2 > 0)
		{
			((Control)advTree_0).set_Width(int_2);
		}
		if (int_1 > 0)
		{
			((Control)advTree_0).set_Height(int_1);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeGridLinesColor()
	{
		return advTree_0.ShouldSerializeGridLinesColor();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetGridLinesColor()
	{
		advTree_0.ResetGridLinesColor();
	}

	protected virtual void ExecuteCommand()
	{
		if (icommand_0 != null)
		{
			CommandManager.smethod_0(this);
		}
	}

	protected virtual void OnCommandChanged()
	{
	}
}
