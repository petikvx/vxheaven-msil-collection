using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree;

[TypeConverter(typeof(ExpandableObjectConverter))]
[ToolboxItem(false)]
public class CellImages
{
	private Image image_0;

	private Image image_1;

	private int int_0 = -1;

	private Image image_2;

	private int int_1 = -1;

	private Image image_3;

	private int int_2 = -1;

	private Image image_4;

	private int int_3 = -1;

	private Cell cell_0;

	private Size size_0 = Size.Empty;

	internal Image Image_0
	{
		get
		{
			return image_1;
		}
		set
		{
			image_1 = value;
		}
	}

	[Browsable(true)]
	[DevCoSerialize]
	[DefaultValue(null)]
	[Description("Indicates default cell image")]
	[Category("Images")]
	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			method_0();
		}
	}

	[DevCoSerialize]
	[Browsable(true)]
	[Category("Images")]
	[Description("Indicates cell image when mouse is over the cell")]
	[DefaultValue(null)]
	public Image ImageMouseOver
	{
		get
		{
			return image_2;
		}
		set
		{
			image_2 = value;
			method_0();
		}
	}

	[Browsable(true)]
	[Description("Indicates disabled cell image")]
	[Category("Images")]
	[DefaultValue(null)]
	public Image ImageDisabled
	{
		get
		{
			return image_3;
		}
		set
		{
			image_3 = value;
			method_0();
		}
	}

	[DevCoSerialize]
	[DefaultValue(null)]
	[Description("Indicates cell image when node associtaed with this cell is expanded")]
	[Browsable(true)]
	[Category("Images")]
	public Image ImageExpanded
	{
		get
		{
			return image_4;
		}
		set
		{
			image_4 = value;
			method_0();
		}
	}

	[DefaultValue(-1)]
	[Description("Indicates default cell image")]
	[Category("ImageList Images")]
	[Browsable(true)]
	[DevCoSerialize]
	public int ImageIndex
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			method_0();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public ImageList ImageList
	{
		get
		{
			if (Parent != null)
			{
				AdvTree treeControl = Parent.TreeControl;
				if (treeControl != null)
				{
					return treeControl.ImageList;
				}
			}
			return null;
		}
	}

	[DevCoSerialize]
	[Description("Indicates cell image when mouse is over the cell")]
	[Category("ImageList Images")]
	[DefaultValue(-1)]
	[Browsable(true)]
	public int ImageMouseOverIndex
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			method_0();
		}
	}

	[DefaultValue(-1)]
	[Description("Indicates disabled cell image")]
	[Browsable(true)]
	[Category("ImageList Images")]
	public int ImageDisabledIndex
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
			method_0();
		}
	}

	[DefaultValue(-1)]
	[Description("Indicates expanded cell image")]
	[Browsable(true)]
	[DevCoSerialize]
	[Category("ImageList Images")]
	public int ImageExpandedIndex
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
			method_0();
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Cell Parent
	{
		get
		{
			return cell_0;
		}
		set
		{
			cell_0 = value;
		}
	}

	internal bool Boolean_0
	{
		get
		{
			if (image_0 == null && image_3 == null && int_2 == -1 && image_4 == null && int_3 == -1 && int_0 == -1 && image_2 == null && int_1 == -1)
			{
				return false;
			}
			return true;
		}
	}

	internal Size Size_0 => size_0;

	public CellImages(Cell parentCell)
	{
		cell_0 = parentCell;
	}

	public void ResetImage()
	{
		TypeDescriptor.GetProperties(this)["Image"]!.SetValue(this, null);
	}

	public void ResetImageMouseOver()
	{
		TypeDescriptor.GetProperties(this)["ImageMouseOver"]!.SetValue(this, null);
	}

	public void ResetImageDisabled()
	{
		ImageDisabled = null;
	}

	public void ResetImageExpanded()
	{
		TypeDescriptor.GetProperties(this)["ImageExpanded"]!.SetValue(this, null);
	}

	public virtual CellImages Copy()
	{
		CellImages cellImages = new CellImages(null);
		cellImages.Image = Image;
		cellImages.ImageExpanded = ImageExpanded;
		cellImages.ImageExpandedIndex = ImageExpandedIndex;
		cellImages.ImageIndex = ImageIndex;
		cellImages.ImageMouseOver = ImageMouseOver;
		cellImages.ImageMouseOverIndex = ImageMouseOverIndex;
		return cellImages;
	}

	private void method_0()
	{
		method_2();
		if (Parent != null)
		{
			Parent.OnImageChanged();
		}
		method_1();
	}

	internal void method_1()
	{
		if (image_1 != null)
		{
			image_1.Dispose();
			image_1 = null;
		}
	}

	internal void method_2()
	{
		size_0 = Size.Empty;
		method_3(image_0, ref size_0);
		method_3(image_3, ref size_0);
		method_3(image_4, ref size_0);
		method_3(image_2, ref size_0);
		method_3(method_4(int_0), ref size_0);
		method_3(method_4(int_2), ref size_0);
		method_3(method_4(int_3), ref size_0);
		method_3(method_4(int_1), ref size_0);
	}

	private void method_3(Image image_5, ref Size size_1)
	{
		if (image_5 != null)
		{
			if (image_5.get_Width() > size_1.Width)
			{
				size_1.Width = image_5.get_Width();
			}
			if (image_5.get_Height() > size_1.Height)
			{
				size_1.Height = image_5.get_Height();
			}
		}
	}

	internal Image method_4(int int_4)
	{
		if (int_4 >= 0 && Parent != null && Parent.TreeControl != null && Parent.TreeControl.ImageList != null)
		{
			return Parent.TreeControl.ImageList.get_Images().get_Item(int_4);
		}
		return null;
	}
}
