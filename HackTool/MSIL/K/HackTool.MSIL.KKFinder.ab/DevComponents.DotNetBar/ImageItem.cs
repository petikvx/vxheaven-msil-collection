using System.ComponentModel;
using System.Drawing;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public abstract class ImageItem : BaseItem
{
	private Size size_0;

	private Size size_1;

	internal static Size size_2 = new Size(16, 16);

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public virtual Size ImageSize
	{
		get
		{
			return size_1;
		}
		set
		{
			size_1 = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual Size SubItemsImageSize
	{
		get
		{
			return size_0;
		}
		set
		{
			size_0 = value;
		}
	}

	public ImageItem()
		: this("", "")
	{
	}

	public ImageItem(string sName)
		: this(sName, "")
	{
	}

	public ImageItem(string sName, string ItemText)
		: base(sName, ItemText)
	{
		size_0 = size_2;
		size_1 = size_2;
	}

	protected internal override void OnItemAdded(BaseItem objItem)
	{
		base.OnItemAdded(objItem);
		if (objItem is ImageItem imageItem)
		{
			Size subItemsImageSize = size_0;
			if (imageItem.ImageSize.Width > size_0.Width)
			{
				subItemsImageSize.Width = imageItem.ImageSize.Width;
			}
			if (imageItem.ImageSize.Height > size_0.Height)
			{
				subItemsImageSize.Height = imageItem.ImageSize.Height;
			}
			SubItemsImageSize = subItemsImageSize;
		}
	}

	public virtual void OnSubItemImageSizeChanged(BaseItem objItem)
	{
		if (!(objItem is ImageItem imageItem))
		{
			return;
		}
		if (SubItems.Count == 1)
		{
			SubItemsImageSize = new Size(imageItem.ImageSize.Width, imageItem.ImageSize.Height);
			return;
		}
		Size subItemsImageSize = size_0;
		if (imageItem.ImageSize.Width > size_0.Width)
		{
			subItemsImageSize.Width = imageItem.ImageSize.Width;
		}
		if (imageItem.ImageSize.Height > size_0.Height)
		{
			subItemsImageSize.Height = imageItem.ImageSize.Height;
		}
		SubItemsImageSize = subItemsImageSize;
	}

	protected override void OnIsOnCustomizeDialogChanged()
	{
		if (base.IsOnCustomizeDialog && size_1.Width == size_2.Width && size_1.Height == size_2.Height)
		{
			size_1 = new Size(16, 16);
		}
		base.OnIsOnCustomizeDialogChanged();
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void OnImageChanged()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void RefreshImageSize()
	{
		SubItemsImageSize = size_2;
		size_1 = size_2;
		OnImageChanged();
		if (m_SubItems == null)
		{
			return;
		}
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem is ImageItem)
			{
				((ImageItem)subItem).RefreshImageSize();
			}
		}
	}

	protected internal override void OnAfterItemRemoved(BaseItem item)
	{
		base.OnAfterItemRemoved(item);
		if (item != null)
		{
			RefreshSubItemImageSize();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public virtual void RefreshSubItemImageSize()
	{
		SubItemsImageSize = Size.Empty;
		if (m_SubItems != null)
		{
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is ImageItem imageItem)
				{
					Size subItemsImageSize = size_0;
					if (imageItem.ImageSize.Width > size_0.Width)
					{
						subItemsImageSize.Width = imageItem.ImageSize.Width;
					}
					if (imageItem.ImageSize.Height > size_0.Height)
					{
						subItemsImageSize.Height = imageItem.ImageSize.Height;
					}
					SubItemsImageSize = subItemsImageSize;
				}
			}
		}
		if (SubItemsImageSize.IsEmpty)
		{
			SubItemsImageSize = size_2;
		}
	}
}
