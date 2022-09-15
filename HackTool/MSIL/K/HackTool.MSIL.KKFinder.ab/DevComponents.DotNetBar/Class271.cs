using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class271 : IDisposable
{
	private bool bool_0;

	private Image image_0;

	private Icon icon_0;

	private Size size_0 = Size.Empty;

	private ImageList imageList_0;

	private int int_0 = -1;

	public bool Boolean_0 => icon_0 != null;

	public int Int32_0
	{
		get
		{
			if (!size_0.IsEmpty)
			{
				return size_0.Width;
			}
			if (image_0 != null)
			{
				return image_0.get_Width();
			}
			if (icon_0 != null)
			{
				return icon_0.get_Width();
			}
			if (int_0 >= 0 && imageList_0 != null)
			{
				return imageList_0.get_ImageSize().Width;
			}
			return 0;
		}
	}

	public int Int32_1
	{
		get
		{
			if (!size_0.IsEmpty)
			{
				return size_0.Height;
			}
			if (image_0 != null)
			{
				return image_0.get_Height();
			}
			if (icon_0 != null)
			{
				return icon_0.get_Height();
			}
			if (int_0 >= 0 && imageList_0 != null)
			{
				return imageList_0.get_ImageSize().Height;
			}
			return 0;
		}
	}

	public Size Size_0
	{
		get
		{
			if (!size_0.IsEmpty)
			{
				return size_0;
			}
			if (image_0 != null)
			{
				return image_0.get_Size();
			}
			if (icon_0 != null)
			{
				return icon_0.get_Size();
			}
			if (int_0 >= 0 && imageList_0 != null)
			{
				return imageList_0.get_ImageSize();
			}
			return Size.Empty;
		}
	}

	public Image Image_0
	{
		get
		{
			if (int_0 >= 0 && imageList_0 != null)
			{
				return imageList_0.get_Images().get_Item(int_0);
			}
			return image_0;
		}
	}

	public Icon Icon_0 => icon_0;

	internal int Int32_2
	{
		get
		{
			if (image_0 != null)
			{
				return image_0.get_Height();
			}
			if (icon_0 != null)
			{
				return icon_0.get_Height();
			}
			if (int_0 >= 0 && imageList_0 != null)
			{
				return imageList_0.get_ImageSize().Height;
			}
			return 0;
		}
	}

	internal int Int32_3
	{
		get
		{
			if (image_0 != null)
			{
				return image_0.get_Width();
			}
			if (icon_0 != null)
			{
				return icon_0.get_Width();
			}
			if (int_0 >= 0 && imageList_0 != null)
			{
				return imageList_0.get_ImageSize().Width;
			}
			return 0;
		}
	}

	public Class271(int imageIndex, ImageList imageList)
	{
		int_0 = imageIndex;
		imageList_0 = imageList;
	}

	public Class271(Image image, bool dispose)
	{
		image_0 = image;
		bool_0 = dispose;
	}

	public Class271(Icon icon, bool dispose)
	{
		icon_0 = icon;
		bool_0 = dispose;
	}

	public Class271(Image image, bool dispose, Size overrideSize)
	{
		image_0 = image;
		bool_0 = dispose;
		size_0 = overrideSize;
	}

	public Class271(Icon icon, bool dispose, Size overrideSize)
	{
		icon_0 = icon;
		bool_0 = dispose;
		size_0 = overrideSize;
	}

	public void Dispose()
	{
		if (bool_0)
		{
			if (image_0 != null)
			{
				image_0.Dispose();
			}
			if (icon_0 != null)
			{
				icon_0.Dispose();
			}
		}
		image_0 = null;
		icon_0 = null;
	}

	public void method_0(Graphics graphics_0, Rectangle rectangle_0)
	{
		if (image_0 != null)
		{
			graphics_0.DrawImage(image_0, rectangle_0);
		}
		else if (icon_0 != null)
		{
			method_1(graphics_0, rectangle_0);
		}
		else if (int_0 >= 0 && imageList_0 != null && int_0 < imageList_0.get_Images().get_Count())
		{
			imageList_0.Draw(graphics_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height, int_0);
		}
	}

	private void method_1(Graphics graphics_0, Rectangle rectangle_0)
	{
		if (Environment.Version.Build <= 3705 && Environment.Version.Revision == 288 && Environment.Version.Major == 1 && Environment.Version.Minor == 0)
		{
			if (graphics_0.get_ClipBounds().IntersectsWith(rectangle_0) && rectangle_0.Width > 0 && rectangle_0.Height > 0 && icon_0.get_Handle() != IntPtr.Zero)
			{
				IntPtr hdc = graphics_0.GetHdc();
				try
				{
					Class92.DrawIconEx(hdc, rectangle_0.X, rectangle_0.Y, icon_0.get_Handle(), rectangle_0.Width, rectangle_0.Height, 0, IntPtr.Zero, 3);
				}
				finally
				{
					graphics_0.ReleaseHdc(hdc);
				}
			}
		}
		else if (rectangle_0.Width > 0 && rectangle_0.Height > 0 && icon_0.get_Handle() != IntPtr.Zero)
		{
			try
			{
				graphics_0.DrawIcon(icon_0, rectangle_0);
			}
			catch
			{
			}
		}
	}

	public void method_2(Graphics graphics_0, Rectangle rectangle_0, int int_1, int int_2, int int_3, int int_4, GraphicsUnit graphicsUnit_0, ImageAttributes imageAttributes_0)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (image_0 != null)
		{
			graphics_0.DrawImage(image_0, rectangle_0, int_1, int_2, int_3, int_4, graphicsUnit_0, imageAttributes_0);
		}
		else if (icon_0 != null)
		{
			Bitmap val = new Bitmap(Int32_0, Int32_1, (PixelFormat)2498570);
			val.MakeTransparent();
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.DrawIcon(icon_0, 0, 0);
			val2.Dispose();
			graphics_0.DrawImage((Image)(object)val, rectangle_0, int_1, int_2, int_3, int_4, graphicsUnit_0, imageAttributes_0);
			((Image)val).Dispose();
		}
		else if (int_0 >= 0 && imageList_0 != null && int_0 < imageList_0.get_Images().get_Count())
		{
			imageList_0.Draw(graphics_0, int_1, int_2, int_3, int_4, int_0);
		}
	}
}
