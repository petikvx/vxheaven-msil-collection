using System.ComponentModel;
using System.Drawing.Design;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[TypeConverter(typeof(GalleryGroupConverter))]
[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class GalleryGroup : Component
{
	private string string_0 = "";

	private string string_1 = "";

	private GalleryContainer galleryContainer_0;

	private int int_0;

	private SubItemsCollection subItemsCollection_0;

	[Description("Indicates title of the group that will be displayed on the group label when on popup gallery.")]
	[Browsable(true)]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[DefaultValue("")]
	[Localizable(true)]
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
			string_0 = value;
		}
	}

	[Description("Indicates the name used to identify the group.")]
	[Category("Design")]
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

	[Browsable(false)]
	public GalleryContainer ParentGallery => galleryContainer_0;

	[Category("Layout")]
	[DefaultValue(0)]
	[Description("Indicates display order for the group when displayed on the popup.")]
	[Browsable(true)]
	public int DisplayOrder
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public SubItemsCollection Items => subItemsCollection_0;

	public GalleryGroup()
	{
		subItemsCollection_0 = new SubItemsCollection(null);
		subItemsCollection_0.Boolean_1 = true;
		subItemsCollection_0.Boolean_0 = false;
	}

	internal void SetParentGallery(GalleryContainer value)
	{
		galleryContainer_0 = value;
	}

	public override string ToString()
	{
		if (string_0.Length > 0)
		{
			return string_0;
		}
		return base.ToString();
	}
}
