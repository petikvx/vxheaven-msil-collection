using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.Editors;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
[DefaultEvent("Click")]
public class BubbleButton : Component, IBlock
{
	private string string_0 = "";

	private int int_0 = -1;

	private int int_1 = -1;

	private bool bool_0 = true;

	private Image image_0;

	private Image image_1;

	private Image image_2;

	private Image image_3;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private bool bool_1;

	private bool bool_2;

	private BubbleButtonCollection bubbleButtonCollection_0;

	private string string_1 = "";

	private bool bool_3 = true;

	private object object_0;

	private bool bool_4;

	private eShortcut eShortcut_0;

	private ClickEventHandler clickEventHandler_0;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private Cursor cursor_0;

	private Cursor cursor_1;

	[Description("Indicates shortcut key to expand/collapse splitter.")]
	[Browsable(true)]
	[DefaultValue(eShortcut.None)]
	[Category("Expand")]
	public eShortcut Shortcut
	{
		get
		{
			return eShortcut_0;
		}
		set
		{
			eShortcut_0 = value;
			if (eShortcut_0 != 0 && GetBubbleBar() != null)
			{
				GetBubbleBar().method_21();
			}
		}
	}

	[DefaultValue("")]
	[Description("Indicates tooltip for the button.")]
	[Localizable(true)]
	[Category("Appearance")]
	public string TooltipText
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

	[TypeConverter(typeof(ImageIndexConverter))]
	[DefaultValue(-1)]
	[Description("Indicates default image used on the button.")]
	[Browsable(true)]
	[Category("Images")]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	public int ImageIndex
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			image_0 = null;
			OnImageIndexChanged();
			OnAppearanceChanged();
		}
	}

	internal Image ImageCached => image_0;

	internal Image ImageLargeCached => image_1;

	[DefaultValue(null)]
	[Browsable(true)]
	[Description("The image that will be displayed on the face of the button.")]
	[Category("Images")]
	public Image Image
	{
		get
		{
			return image_2;
		}
		set
		{
			image_2 = value;
			OnImageChanged();
		}
	}

	[Browsable(true)]
	[DefaultValue(null)]
	[Category("Images")]
	[Description("Indicates enlarged image that will be displayed on the face of the button.")]
	public Image ImageLarge
	{
		get
		{
			return image_3;
		}
		set
		{
			image_3 = value;
			OnImageChanged();
		}
	}

	[Browsable(true)]
	[Category("Images")]
	[Description("Indicates image index of the enlarged image for the button.")]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[DefaultValue(-1)]
	[TypeConverter(typeof(ImageIndexConverter))]
	public int ImageIndexLarge
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			image_1 = null;
			OnImageIndexChanged();
			OnAppearanceChanged();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public ImageList ImageList => GetBubbleBar()?.Images;

	[Category("Behavior")]
	[DefaultValue(true)]
	[Description("Indicates whether button is enabled.")]
	[Browsable(true)]
	public bool Enabled
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (bool_0 != value)
			{
				bool_0 = value;
				OnAppearanceChanged();
			}
		}
	}

	[Browsable(false)]
	public Rectangle DisplayRectangle => rectangle_0;

	[Browsable(false)]
	public Rectangle MagnifiedDisplayRectangle => rectangle_1;

	[Browsable(false)]
	public bool MouseOver => bool_1;

	[Browsable(false)]
	public bool MouseDown => bool_2;

	[Category("Design")]
	[Description("Indicates the name used to identify button.")]
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

	[DefaultValue(true)]
	[Category("Behavior")]
	[Browsable(true)]
	[Description("Determines whether the button is visible or hidden.")]
	public virtual bool Visible
	{
		get
		{
			return bool_3;
		}
		set
		{
			if (bool_3 != value)
			{
				bool_3 = value;
				OnVisibleChanged();
			}
		}
	}

	[DefaultValue(null)]
	[Browsable(false)]
	[Category("Data")]
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

	[Browsable(true)]
	[Description("Indicates text that contains data about the cell.")]
	[Category("Data")]
	[DefaultValue("")]
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

	[Browsable(false)]
	public BubbleBarTab Parent
	{
		get
		{
			if (bubbleButtonCollection_0 != null)
			{
				return bubbleButtonCollection_0.BubbleBarTab_0;
			}
			return null;
		}
	}

	internal bool Focus
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool_4 = value;
		}
	}

	[DefaultValue(null)]
	[Description("Indciates mouse cursor that is displayed when mouse is over the button.")]
	[Category("Appearance")]
	public Cursor Cursor
	{
		get
		{
			return cursor_1;
		}
		set
		{
			cursor_1 = value;
		}
	}

	Rectangle IBlock.Bounds
	{
		get
		{
			return rectangle_0;
		}
		set
		{
			rectangle_0 = value;
		}
	}

	public event ClickEventHandler Click
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			clickEventHandler_0 = (ClickEventHandler)Delegate.Combine(clickEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			clickEventHandler_0 = (ClickEventHandler)Delegate.Remove(clickEventHandler_0, value);
		}
	}

	public event EventHandler MouseEnter
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

	public event EventHandler MouseLeave
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

	internal void SetDisplayRectangle(Rectangle r)
	{
		rectangle_0 = r;
	}

	internal void SetMagnifiedDisplayRectangle(Rectangle r)
	{
		rectangle_1 = r;
	}

	internal void SetMouseOver(bool value)
	{
		bool flag = bool_1 != value;
		bool_1 = value;
		UpdateCursor();
		if (flag)
		{
			if (value)
			{
				OnMouseEnter();
			}
			else
			{
				OnMouseLeave();
			}
		}
	}

	protected virtual void OnMouseEnter()
	{
		eventHandler_0?.Invoke(this, new EventArgs());
	}

	protected virtual void OnMouseLeave()
	{
		eventHandler_1?.Invoke(this, new EventArgs());
	}

	private void UpdateCursor()
	{
		BubbleBar bubbleBar = GetBubbleBar();
		if (bubbleBar == null || cursor_1 == (Cursor)null)
		{
			return;
		}
		if (bool_1)
		{
			if (cursor_0 == (Cursor)null)
			{
				cursor_0 = Cursor.get_Current();
			}
			((Control)bubbleBar).set_Cursor(cursor_1);
		}
		else if (cursor_0 != (Cursor)null)
		{
			((Control)bubbleBar).set_Cursor(cursor_0);
			cursor_0 = null;
		}
	}

	internal void SetMouseDown(bool value)
	{
		bool_2 = value;
	}

	internal void SetParentCollection(BubbleButtonCollection value)
	{
		bubbleButtonCollection_0 = value;
	}

	private void OnAppearanceChanged()
	{
		BubbleBar bubbleBar = GetBubbleBar();
		if (bubbleBar != null)
		{
			((Control)bubbleBar).Refresh();
		}
	}

	private void OnImageIndexChanged()
	{
		BubbleBar bubbleBar = GetBubbleBar();
		if (bubbleBar != null)
		{
			if (int_0 >= 0 && image_0 == null && bubbleBar.Images != null && int_0 < bubbleBar.Images.get_Images().get_Count())
			{
				image_0 = bubbleBar.Images.get_Images().get_Item(int_0);
			}
			if (int_1 >= 0 && image_1 == null && bubbleBar.ImagesLarge != null && int_1 < bubbleBar.ImagesLarge.get_Images().get_Count())
			{
				image_1 = bubbleBar.ImagesLarge.get_Images().get_Item(int_0);
			}
		}
	}

	private void OnImageChanged()
	{
		BubbleBar bubbleBar = GetBubbleBar();
		if (bubbleBar != null && Site != null && Site!.DesignMode)
		{
			((Control)bubbleBar).Refresh();
		}
	}

	public BubbleBar GetBubbleBar()
	{
		if (bubbleButtonCollection_0 != null && bubbleButtonCollection_0.BubbleBarTab_0 != null && bubbleButtonCollection_0.BubbleBarTab_0.Parent != null)
		{
			return bubbleButtonCollection_0.BubbleBarTab_0.Parent;
		}
		return null;
	}

	private void OnVisibleChanged()
	{
		GetBubbleBar()?.method_23(this);
	}

	public void InvokeClick(eEventSource source, MouseButtons mouseButton)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		OnClick(new ClickEventArgs(source, mouseButton));
	}

	protected virtual void OnClick(ClickEventArgs e)
	{
		if (clickEventHandler_0 != null)
		{
			clickEventHandler_0(this, e);
		}
		GetBubbleBar()?.method_0(this, e);
	}
}
