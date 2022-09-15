using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.AdvTree.Design;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree;

[ToolboxItem(false)]
[Designer(typeof(ColumnHeaderDesigner))]
public class ColumnHeader : Component
{
	private string string_0 = "";

	private ColumnWidth columnWidth_0;

	private bool bool_0 = true;

	private eStyleTextAlignment eStyleTextAlignment_0;

	private string string_1 = "";

	private string string_2 = "";

	private string string_3 = "";

	private string string_4 = "";

	private bool bool_1 = true;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private bool bool_2 = true;

	private string string_5 = "";

	private EventHandler eventHandler_0;

	private Delegate0 delegate0_0;

	private MouseEventHandler mouseEventHandler_0;

	private MouseEventHandler mouseEventHandler_1;

	private bool bool_3 = true;

	private int int_0;

	private int int_1;

	private Image image_0;

	private eColumnImageAlignment eColumnImageAlignment_0;

	private string string_6 = "";

	private object object_0;

	private bool bool_4;

	private bool bool_5;

	internal bool bool_6;

	internal bool bool_7;

	private eCellEditorType eCellEditorType_0;

	private bool bool_8;

	[Category("Behavior")]
	[DefaultValue(true)]
	[Description("Indicates whether cells content in this column is editable when cell editing is enabled on tree control.")]
	public bool Editable
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}

	[Category("Behavior")]
	[DefaultValue(0)]
	[Description("Indicates maximum number of characters the user can type or paste when editing cells in this column.")]
	public int MaxInputLength
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

	[Browsable(false)]
	[Description("Indicates the name used to identify column header.")]
	[Category("Design")]
	public string Name
	{
		get
		{
			if (Site != null)
			{
				string_5 = Site!.Name;
			}
			return string_5;
		}
		set
		{
			if (Site != null)
			{
				Site!.Name = value;
			}
			if (value == null)
			{
				string_5 = "";
			}
			else
			{
				string_5 = value;
			}
		}
	}

	[Browsable(false)]
	public Rectangle Bounds => rectangle_0;

	[Description("Gets or sets the width of the column.")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Layout")]
	public ColumnWidth Width => columnWidth_0;

	[Category("Layout")]
	[DefaultValue(0)]
	[Description("Indicates minimum column width in pixels that is enforced when user is resizing the columns using mouse")]
	public int MinimumWidth
	{
		get
		{
			return int_1;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			int_1 = value;
		}
	}

	[Description("Indicates the style class assigned to the column.")]
	[Category("Style")]
	[Browsable(true)]
	[DefaultValue("")]
	public string StyleNormal
	{
		get
		{
			return string_1;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			string_1 = value;
			OnSizeChanged();
		}
	}

	[Browsable(true)]
	[DefaultValue("")]
	[Category("Style")]
	[Description("Indicates the style class assigned to the column when mouse is down.")]
	public string StyleMouseDown
	{
		get
		{
			return string_2;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			string_2 = value;
			OnSizeChanged();
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[DefaultValue("")]
	[Description("Indicates the style class assigned to the cell when mouse is over the column.")]
	public string StyleMouseOver
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
			OnSizeChanged();
		}
	}

	[DefaultValue("")]
	[Category("Data")]
	[Description("Indicates the name of the column in the ColumnHeaderCollection.")]
	[Browsable(true)]
	public string ColumnName
	{
		get
		{
			return string_4;
		}
		set
		{
			string_4 = value;
		}
	}

	[Description("Indicates column caption.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue("")]
	public string Text
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

	[Category("Behavior")]
	[Browsable(true)]
	[Description("Indicates whether column is visible.")]
	[DefaultValue(true)]
	public bool Visible
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
				OnSizeChanged();
			}
		}
	}

	[DefaultValue(null)]
	[Description("Indicates column image")]
	[Category("Images")]
	[Browsable(true)]
	[DevCoSerialize]
	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			OnImageChanged();
		}
	}

	[Description("Indicates image alignment.")]
	[DevCoSerialize]
	[DefaultValue(eColumnImageAlignment.Left)]
	[Category("Images")]
	public eColumnImageAlignment ImageAlignment
	{
		get
		{
			return eColumnImageAlignment_0;
		}
		set
		{
			eColumnImageAlignment_0 = value;
			OnSizeChanged();
		}
	}

	[Category("Data")]
	[Description("Indicates data-field or property name that is used as source of data for this column when data-binding is used.")]
	[DefaultValue("")]
	public string DataFieldName
	{
		get
		{
			return string_6;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			if (string_6 != value)
			{
				string_6 = value;
				OnDataFieldNameChanged();
			}
		}
	}

	[DefaultValue(null)]
	[Browsable(false)]
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

	internal bool SizeChanged
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	[Browsable(false)]
	public bool IsMouseDown
	{
		get
		{
			return bool_4;
		}
		internal set
		{
			if (bool_4 != value)
			{
				bool_4 = value;
				OnIsMouseDownChanged();
			}
		}
	}

	[Browsable(false)]
	public bool IsMouseOver
	{
		get
		{
			return bool_5;
		}
		internal set
		{
			bool_5 = value;
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

	public event EventHandler HeaderSizeChanged
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

	internal event Delegate0 SortCells
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate0_0 = (Delegate0)Delegate.Combine(delegate0_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate0_0 = (Delegate0)Delegate.Remove(delegate0_0, value);
		}
	}

	public event MouseEventHandler MouseDown
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

	public event MouseEventHandler MouseUp
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

	public ColumnHeader()
		: this("")
	{
	}

	public ColumnHeader(string text)
	{
		string_0 = text;
		columnWidth_0 = new ColumnWidth();
		columnWidth_0.Event_0 += WidthChanged;
	}

	public virtual ColumnHeader Copy()
	{
		ColumnHeader columnHeader = new ColumnHeader();
		columnHeader.ColumnName = ColumnName;
		columnHeader.StyleMouseDown = StyleMouseDown;
		columnHeader.StyleMouseOver = StyleMouseOver;
		columnHeader.StyleNormal = StyleNormal;
		columnHeader.Text = Text;
		columnHeader.Visible = Visible;
		columnHeader.Width.Absolute = Width.Absolute;
		columnHeader.Width.Relative = Width.Relative;
		return columnHeader;
	}

	internal void SetBounds(Rectangle bounds)
	{
		rectangle_0 = bounds;
	}

	private void OnImageChanged()
	{
		OnSizeChanged();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetImage()
	{
		TypeDescriptor.GetProperties(this)["Image"]!.SetValue(this, null);
	}

	protected virtual void OnDataFieldNameChanged()
	{
	}

	private void OnSizeChanged()
	{
		bool_2 = true;
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
	}

	private void WidthChanged(object sender, EventArgs e)
	{
		OnSizeChanged();
	}

	private void OnIsMouseDownChanged()
	{
	}

	internal virtual void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			IsMouseDown = true;
		}
		MouseEventHandler val = mouseEventHandler_0;
		if (val != null)
		{
			val.Invoke((object)this, e);
		}
	}

	internal virtual void OnMouseUp(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			IsMouseDown = false;
		}
		MouseEventHandler val = mouseEventHandler_1;
		if (val != null)
		{
			val.Invoke((object)this, e);
		}
	}

	public void Sort()
	{
		Sort(bool_8);
		bool_8 = !bool_8;
	}

	public void Sort(bool reverse)
	{
		if (delegate0_0 != null)
		{
			delegate0_0(this, new EventArgs0(reverse));
		}
	}
}
