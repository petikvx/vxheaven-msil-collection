using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
[TypeConverter(typeof(RibbonTabItemGroupConverter))]
public class RibbonTabItemGroup : Component
{
	private ElementStyle elementStyle_0;

	private string string_0 = "";

	private RibbonStrip ribbonStrip_0;

	internal ArrayList arrayList_0 = new ArrayList();

	private eRibbonTabGroupColor eRibbonTabGroupColor_0;

	private string string_1 = "";

	private string string_2 = "";

	[Description("Indicates predefined color of the group when Office 12 style is used.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(eRibbonTabGroupColor.Default)]
	public eRibbonTabGroupColor Color
	{
		get
		{
			return eRibbonTabGroupColor_0;
		}
		set
		{
			if (eRibbonTabGroupColor_0 != value)
			{
				eRibbonTabGroupColor_0 = value;
				if (ParentRibbonStrip != null)
				{
					((Control)ParentRibbonStrip).Invalidate();
				}
			}
		}
	}

	[Browsable(true)]
	[DefaultValue("")]
	[Description("Indicates custom color table name for the button when Office 2007 style is used.")]
	[DevCoBrowsable(false)]
	[Category("Appearance")]
	public string CustomColorName
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
			if (ParentRibbonStrip != null)
			{
				((Control)ParentRibbonStrip).Invalidate();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	[Description("Gets the style for tab group.")]
	[Category("Background")]
	public ElementStyle Style => elementStyle_0;

	[DevCoBrowsable(true)]
	[Localizable(true)]
	[Browsable(true)]
	[DefaultValue("")]
	public string GroupTitle
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			if (base.DesignMode && ribbonStrip_0 != null)
			{
				ribbonStrip_0.RecalcLayout();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	internal RibbonStrip ParentRibbonStrip
	{
		get
		{
			return ribbonStrip_0;
		}
		set
		{
			ribbonStrip_0 = value;
			if (ribbonStrip_0 != null)
			{
				elementStyle_0.method_4(ribbonStrip_0.ColorScheme);
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool Visible
	{
		get
		{
			if (ribbonStrip_0 == null)
			{
				return true;
			}
			bool result = false;
			foreach (BaseItem item in ribbonStrip_0.Items)
			{
				if (item is RibbonTabItem)
				{
					RibbonTabItem ribbonTabItem = item as RibbonTabItem;
					if (ribbonTabItem.Group == this && ribbonTabItem.Visible)
					{
						return true;
					}
				}
			}
			return result;
		}
		set
		{
			if (ribbonStrip_0 == null)
			{
				return;
			}
			foreach (BaseItem item in ribbonStrip_0.Items)
			{
				if (item is RibbonTabItem)
				{
					RibbonTabItem ribbonTabItem = item as RibbonTabItem;
					if (ribbonTabItem.Group == this)
					{
						ribbonTabItem.Visible = value;
					}
				}
			}
			ribbonStrip_0.RecalcLayout();
		}
	}

	[Browsable(false)]
	public bool IsTabFromGroupSelected
	{
		get
		{
			if (ribbonStrip_0 == null)
			{
				return false;
			}
			foreach (BaseItem item in ribbonStrip_0.Items)
			{
				if (item is RibbonTabItem)
				{
					RibbonTabItem ribbonTabItem = item as RibbonTabItem;
					if (ribbonTabItem.Group == this && ribbonTabItem.Checked)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	[Browsable(false)]
	[Category("Design")]
	[Description("Indicates the name used to identify the group.")]
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
	public Rectangle[] TitleBounds => (Rectangle[])arrayList_0.ToArray(typeof(Rectangle));

	public RibbonTabItemGroup()
	{
		elementStyle_0 = new ElementStyle();
		elementStyle_0.StyleChanged += StyleChanged;
	}

	private void StyleChanged(object sender, EventArgs e)
	{
		if (ribbonStrip_0 != null)
		{
			((Control)ribbonStrip_0).Refresh();
		}
	}

	public override string ToString()
	{
		if (string_0.Length > 0)
		{
			return string_0;
		}
		return base.ToString();
	}

	public void SelectFirstTab()
	{
		if (ribbonStrip_0 == null)
		{
			return;
		}
		foreach (BaseItem item in ribbonStrip_0.Items)
		{
			if (item is RibbonTabItem)
			{
				RibbonTabItem ribbonTabItem = item as RibbonTabItem;
				if (ribbonTabItem.Group == this && ribbonTabItem.Visible)
				{
					ribbonTabItem.Checked = true;
					break;
				}
			}
		}
	}
}
