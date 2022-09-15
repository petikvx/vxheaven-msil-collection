using System.ComponentModel;
using System.Drawing;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[TypeConverter(typeof(ExpandableObjectConverter))]
public class RatingImages
{
	private RatingItem ratingItem_0;

	private Image image_0;

	private Image image_1;

	private Image image_2;

	private Image image_3;

	private Image image_4;

	private Size size_0 = Size.Empty;

	[Description("Gets or sets the image used for unrated rating part.")]
	[DefaultValue(null)]
	public Image Unrated
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
				method_0();
			}
		}
	}

	[Description("Gets or sets the image used for unrated rating part when mouse is over the control.")]
	[DefaultValue(null)]
	public Image UnratedMouseOver
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
				method_0();
			}
		}
	}

	[DefaultValue(null)]
	[Description("Gets or sets the image used for rated part of the control.")]
	public Image Rated
	{
		get
		{
			return image_2;
		}
		set
		{
			if (image_2 != value)
			{
				image_2 = value;
				method_0();
			}
		}
	}

	[DefaultValue(null)]
	[Description("Gets or sets the image used for Average Rated part of the control.")]
	public Image AverageRated
	{
		get
		{
			return image_3;
		}
		set
		{
			if (image_3 != value)
			{
				image_3 = value;
				method_0();
			}
		}
	}

	[DefaultValue(null)]
	[Description("Gets or sets the image used for rated part of the control when mouse is over the control.")]
	public Image RatedMouseOver
	{
		get
		{
			return image_4;
		}
		set
		{
			if (image_4 != value)
			{
				image_4 = value;
				method_0();
			}
		}
	}

	internal Size Size_0 => size_0;

	internal RatingImages(RatingItem parentItem)
	{
		ratingItem_0 = parentItem;
	}

	private void method_0()
	{
		size_0 = default(Size);
		if (image_0 != null)
		{
			size_0 = Class50.smethod_48(size_0, image_0.get_Size());
		}
		if (image_1 != null)
		{
			size_0 = Class50.smethod_48(size_0, image_1.get_Size());
		}
		if (image_2 != null)
		{
			size_0 = Class50.smethod_48(size_0, image_2.get_Size());
		}
		if (image_4 != null)
		{
			size_0 = Class50.smethod_48(size_0, image_4.get_Size());
		}
		if (image_3 != null)
		{
			size_0 = Class50.smethod_48(size_0, image_3.get_Size());
		}
		if (ratingItem_0 != null)
		{
			ratingItem_0.NeedRecalcSize = true;
			ratingItem_0.OnAppearanceChanged();
		}
	}
}
