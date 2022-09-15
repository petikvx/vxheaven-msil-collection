using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.Editors;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
[ComVisible(false)]
[Designer(typeof(TabItemDesigner))]
public class TabItem : Component, ISimpleTab, IBlock
{
	private int int_0 = -1;

	private Image image_0;

	private Icon icon_0;

	private string string_0 = "";

	private TabStrip tabStrip_0;

	private bool bool_0 = true;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private BaseItem baseItem_0;

	private Control control_0;

	private object object_0;

	private Color color_0 = Color.Empty;

	private Color color_1 = Color.Empty;

	private int int_1 = 90;

	private Color color_2 = Color.Empty;

	private Color color_3 = Color.Empty;

	private Color color_4 = Color.Empty;

	private Color color_5 = Color.Empty;

	private string string_1 = "";

	private eTabItemColor eTabItemColor_0;

	private object object_1;

	private string string_2 = "";

	private Rectangle rectangle_1 = Rectangle.Empty;

	private bool bool_1;

	private bool bool_2 = true;

	private MouseEventHandler mouseEventHandler_0;

	private MouseEventHandler mouseEventHandler_1;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private MouseEventHandler mouseEventHandler_2;

	private EventHandler eventHandler_3;

	[Browsable(true)]
	[DefaultValue(-1)]
	[TypeConverter(typeof(ImageIndexConverter))]
	[Description("Indicates the tab image index")]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	public int ImageIndex
	{
		get
		{
			return int_0;
		}
		set
		{
			if (int_0 != value)
			{
				int_0 = value;
				if (tabStrip_0 != null)
				{
					tabStrip_0.Boolean_12 = true;
					tabStrip_0.ResetTabHeight();
				}
				Refresh();
				OnImageChanged();
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ImageList ImageList
	{
		get
		{
			if (tabStrip_0 != null)
			{
				return tabStrip_0.ImageList;
			}
			return null;
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(null)]
	[Category("Appearance")]
	[Description("Indicates the tab image.")]
	public Image Image
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
				if (tabStrip_0 != null)
				{
					tabStrip_0.Boolean_12 = true;
					tabStrip_0.ResetTabHeight();
				}
				Refresh();
				OnImageChanged();
			}
		}
	}

	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Description("Indicates the tab icon. Icon has same functionality as Image except that it support Alpha blending.")]
	[Browsable(true)]
	[DefaultValue(null)]
	public Icon Icon
	{
		get
		{
			return icon_0;
		}
		set
		{
			if (icon_0 != value)
			{
				icon_0 = value;
				if (tabStrip_0 != null)
				{
					tabStrip_0.Boolean_12 = true;
					tabStrip_0.ResetTabHeight();
				}
				Refresh();
				OnImageChanged();
			}
		}
	}

	[Localizable(true)]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Indicates the text displayed on the tab.")]
	public string Text
	{
		get
		{
			return string_0;
		}
		set
		{
			if (!(string_0 == value))
			{
				string_0 = value;
				if (tabStrip_0 != null)
				{
					tabStrip_0.Boolean_12 = true;
				}
				Refresh();
				OnTextChanged();
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates whether the tab is visible.")]
	[Category("Behavior")]
	[DevCoBrowsable(true)]
	[DefaultValue(true)]
	public bool Visible
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
				if (tabStrip_0 != null)
				{
					tabStrip_0.method_43(this);
				}
				Refresh();
			}
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	public Rectangle DisplayRectangle => rectangle_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	public Rectangle CloseButtonBounds
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

	internal Rectangle _DisplayRectangle
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

	internal BaseItem AttachedItem
	{
		get
		{
			return baseItem_0;
		}
		set
		{
			baseItem_0 = value;
		}
	}

	[Browsable(false)]
	internal bool CloseButtonMouseOver
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

	[Browsable(true)]
	[DefaultValue(null)]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Description("Indicates the control that is attached to this tab.")]
	public Control AttachedControl
	{
		get
		{
			return control_0;
		}
		set
		{
			control_0 = value;
			if (control_0 != null && tabStrip_0 != null && !tabStrip_0.MdiTabbedDocuments)
			{
				if (tabStrip_0.SelectedTab == this)
				{
					control_0.set_Visible(true);
				}
				else
				{
					control_0.set_Visible(false);
				}
			}
		}
	}

	public TabStrip Parent => tabStrip_0;

	[DefaultValue(null)]
	[Browsable(false)]
	[DevCoBrowsable(true)]
	public object ItemData
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

	internal Size IconSize => new Size(16, 16);

	[Browsable(true)]
	[Category("Style")]
	[Description("Indicates the inactive tab background color.")]
	public Color BackColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			Refresh();
		}
	}

	[Description("Indicates the inactive tab target gradient background color.")]
	[Category("Style")]
	[Browsable(true)]
	public Color BackColor2
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			Refresh();
		}
	}

	[Description("Indicates the gradient angle.")]
	[Category("Style")]
	[DefaultValue(90)]
	[Browsable(true)]
	public int BackColorGradientAngle
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			Refresh();
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[Description("Indicates the inactive tab light border color.")]
	public Color LightBorderColor
	{
		get
		{
			return color_2;
		}
		set
		{
			color_2 = value;
			Refresh();
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[Description("Indicates the inactive tab dark border color.")]
	public Color DarkBorderColor
	{
		get
		{
			return color_3;
		}
		set
		{
			color_3 = value;
			Refresh();
		}
	}

	[Description("Indicates the inactive tab border color.")]
	[Browsable(true)]
	[Category("Style")]
	public Color BorderColor
	{
		get
		{
			return color_4;
		}
		set
		{
			color_4 = value;
			Refresh();
		}
	}

	[Description("Indicates the inactive tab text color.")]
	[Browsable(true)]
	[Category("Style")]
	public Color TextColor
	{
		get
		{
			return color_5;
		}
		set
		{
			color_5 = value;
			Refresh();
		}
	}

	[Description("Indicates the name used to identify item.")]
	[Category("Design")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
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

	[Category("Style")]
	[Browsable(true)]
	[DefaultValue(eTabItemColor.Default)]
	[Description("Applies predefined color to tab.")]
	public eTabItemColor PredefinedColor
	{
		get
		{
			return eTabItemColor_0;
		}
		set
		{
			eTabItemColor_0 = value;
			TabColorScheme.ApplyPredefinedColor(this, eTabItemColor_0);
			if (base.DesignMode)
			{
				if (tabStrip_0 != null && ((Control)tabStrip_0).get_Parent() is TabControl)
				{
					((Control)tabStrip_0).get_Parent().Invalidate(true);
					((TabControl)(object)((Control)tabStrip_0).get_Parent()).ApplyDefaultPanelStyle(AttachedControl as TabControlPanel);
					((Control)tabStrip_0).get_Parent().Update();
				}
				else
				{
					Refresh();
				}
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(null)]
	public object Tag
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

	[DefaultValue("")]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Localizable(true)]
	[Description("Indicates the text that is displayed when mouse hovers over the tab.")]
	[Browsable(true)]
	public string Tooltip
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

	[Browsable(false)]
	public bool IsSelected
	{
		get
		{
			if (tabStrip_0 != null)
			{
				return tabStrip_0.SelectedTab == this;
			}
			return false;
		}
	}

	[Browsable(false)]
	public eTabStripAlignment TabAlignment => tabStrip_0.TabAlignment;

	[Browsable(false)]
	public bool IsMouseOver
	{
		get
		{
			if (tabStrip_0 != null)
			{
				return tabStrip_0.TabItem_1 == this;
			}
			return false;
		}
	}

	[Description("Indicates whether Close button on the tab is visible when TabStrip.CloseButtonOnTabsVisible property is set to true.")]
	[Category("Appearance")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool CloseButtonVisible
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
				TabStrip tabStrip = tabStrip_0;
				if (tabStrip != null && tabStrip.CloseButtonOnTabsVisible)
				{
					tabStrip.RecalcSize();
					((Control)tabStrip).Invalidate();
				}
			}
		}
	}

	Rectangle IBlock.Bounds
	{
		get
		{
			return _DisplayRectangle;
		}
		set
		{
			_DisplayRectangle = value;
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

	public event EventHandler MouseHover
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

	public event EventHandler MouseEnter
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

	public event EventHandler MouseLeave
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

	public event MouseEventHandler MouseMove
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

	public event EventHandler Click
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

	public TabItem(IContainer container)
	{
		container.Add(this);
	}

	public TabItem()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoBrowsable(false)]
	public void ResetImageIndex()
	{
		ImageIndex = -1;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	public void ResetImage()
	{
		Image = null;
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetIcon()
	{
		Icon = null;
	}

	private void Refresh()
	{
		if (tabStrip_0 != null)
		{
			((Control)tabStrip_0).Refresh();
		}
	}

	internal void SetParent(TabStrip tabstrip)
	{
		tabStrip_0 = tabstrip;
	}

	internal Image GetImage()
	{
		if (image_0 != null)
		{
			return image_0;
		}
		if (int_0 >= 0 && tabStrip_0 != null && tabStrip_0.ImageList != null && int_0 < tabStrip_0.ImageList.get_Images().get_Count())
		{
			return tabStrip_0.ImageList.get_Images().get_Item(int_0);
		}
		return null;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeBackColor()
	{
		return !color_0.IsEmpty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackColor()
	{
		BackColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeBackColor2()
	{
		return !color_1.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void ResetBackColor2()
	{
		BackColor2 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeLightBorderColor()
	{
		return !color_2.IsEmpty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetLightBorderColor()
	{
		LightBorderColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeDarkBorderColor()
	{
		return !color_3.IsEmpty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDarkBorderColor()
	{
		DarkBorderColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeBorderColor()
	{
		return !color_4.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void ResetBorderColor()
	{
		BorderColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeTextColor()
	{
		return !color_5.IsEmpty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTextColor()
	{
		TextColor = Color.Empty;
	}

	public override string ToString()
	{
		return string_0;
	}

	public Font GetTabFont()
	{
		if (tabStrip_0 != null)
		{
			return ((Control)tabStrip_0).get_Font();
		}
		return SystemInformation.get_MenuFont();
	}

	private void OnImageChanged()
	{
		if (base.DesignMode && tabStrip_0 != null)
		{
			if (((Control)tabStrip_0).get_Parent() is TabControl)
			{
				((TabControl)(object)((Control)tabStrip_0).get_Parent()).SyncTabStripSize();
				((TabControl)(object)((Control)tabStrip_0).get_Parent()).RecalcLayout();
			}
			else
			{
				tabStrip_0.RecalcSize();
				((Control)tabStrip_0).Refresh();
			}
		}
	}

	private void OnTextChanged()
	{
		OnImageChanged();
	}

	internal void InvokeMouseDown(MouseEventArgs e)
	{
		if (mouseEventHandler_0 != null)
		{
			mouseEventHandler_0.Invoke((object)this, e);
		}
	}

	internal void InvokeMouseUp(MouseEventArgs e)
	{
		if (mouseEventHandler_1 != null)
		{
			mouseEventHandler_1.Invoke((object)this, e);
		}
	}

	public void PerformClick()
	{
		InvokeClick(new EventArgs());
	}

	internal void InvokeClick(EventArgs e)
	{
		if (eventHandler_3 != null)
		{
			eventHandler_3(this, e);
		}
	}

	internal void InvokeMouseEnter(EventArgs e)
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, e);
		}
	}

	internal void InvokeMouseLeave(EventArgs e)
	{
		if (eventHandler_2 != null)
		{
			eventHandler_2(this, e);
		}
	}

	internal void InvokeMouseHover(EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, e);
		}
	}

	internal void InvokeMouseMove(MouseEventArgs e)
	{
		if (mouseEventHandler_2 != null)
		{
			mouseEventHandler_2.Invoke((object)this, e);
		}
	}
}
