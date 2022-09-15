using System.ComponentModel;
using System.Drawing;
using System.Xml;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

public class ColorItem : BaseItem
{
	private Color color_0 = Color.Black;

	private Size size_0 = new Size(13, 13);

	private bool bool_22;

	private eColorItemBorder eColorItemBorder_0 = eColorItemBorder.All;

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates the color represented by this item.")]
	[DevCoSerialize]
	[DevCoBrowsable(true)]
	public Color Color
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[DevCoSerialize]
	[Description("Indicates the size of the item when displayed.")]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	public Size DesiredSize
	{
		get
		{
			return size_0;
		}
		set
		{
			if (value.Width > 0 && value.Height > 0)
			{
				size_0 = value;
				NeedRecalcSize = true;
				OnAppearanceChanged();
			}
		}
	}

	[DefaultValue(eColorItemBorder.All)]
	[DevCoSerialize]
	[DevCoBrowsable(true)]
	[Description("Indicate border drawn around the item")]
	[Browsable(true)]
	public eColorItemBorder Border
	{
		get
		{
			return eColorItemBorder_0;
		}
		set
		{
			eColorItemBorder_0 = value;
			OnAppearanceChanged();
		}
	}

	public bool IsMouseOver => bool_22;

	public ColorItem()
		: this("", "")
	{
	}

	public ColorItem(string sName)
		: this(sName, "")
	{
	}

	public ColorItem(string sName, string ItemText)
		: base(sName, ItemText)
	{
		IsAccessible = false;
		CanCustomize = false;
	}

	public ColorItem(string sName, string ItemText, Color color)
		: base(sName, ItemText)
	{
		IsAccessible = false;
		CanCustomize = false;
		color_0 = color;
	}

	public override BaseItem Copy()
	{
		ColorItem colorItem = new ColorItem(m_Name);
		CopyToItem(colorItem);
		return colorItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		ColorItem colorItem = copy as ColorItem;
		base.CopyToItem(colorItem);
		colorItem.DesiredSize = DesiredSize;
		colorItem.Color = Color;
		colorItem.Border = Border;
	}

	public override void Paint(ItemPaintArgs p)
	{
		BaseRenderer baseRenderer_ = p.BaseRenderer_0;
		if (baseRenderer_ != null)
		{
			ColorItemRendererEventArgs e = new ColorItemRendererEventArgs(p.Graphics, this);
			baseRenderer_.DrawColorItem(e);
			return;
		}
		Class220 @class = Class274.smethod_9(this);
		if (@class != null)
		{
			ColorItemRendererEventArgs e2 = new ColorItemRendererEventArgs(p.Graphics, this);
			@class.PaintColorItem(e2);
		}
	}

	public override void RecalcSize()
	{
		m_Rect.Size = size_0;
		base.RecalcSize();
	}

	private bool ShouldSerializeColor()
	{
		return color_0 != Color.Black;
	}

	private bool ShouldSerializeDesiredSize()
	{
		if (size_0.Width == 13)
		{
			return size_0.Height != 13;
		}
		return true;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseEnter()
	{
		base.InternalMouseEnter();
		method_17(bool_23: true);
		BaseItem parent = Parent;
		while (parent != null && !(parent is ColorPickerDropDown))
		{
			parent = parent.Parent;
		}
		if (parent != null && parent is ColorPickerDropDown)
		{
			((ColorPickerDropDown)parent).InvokeColorPreview(new ColorPreviewEventArgs(Color, this));
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseLeave()
	{
		base.InternalMouseLeave();
		method_17(bool_23: false);
	}

	private void method_17(bool bool_23)
	{
		if (bool_23 != bool_22)
		{
			bool_22 = bool_23;
			Refresh();
		}
	}

	protected internal override void Serialize(ItemSerializationContext context)
	{
		base.Serialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		ElementSerializer.Serialize(this, itemXmlElement);
	}

	protected internal override void Deserialize(ItemSerializationContext context)
	{
		base.Deserialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		ElementSerializer.Deserialize(this, itemXmlElement);
	}
}
