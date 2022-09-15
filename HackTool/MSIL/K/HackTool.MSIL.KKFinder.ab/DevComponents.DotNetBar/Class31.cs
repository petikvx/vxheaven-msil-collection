using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace DevComponents.DotNetBar;

internal static class Class31
{
	public unsafe static Bitmap smethod_0(Image image_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		if (image_0 == null)
		{
			return null;
		}
		Bitmap val = new Bitmap(image_0.get_Width(), image_0.get_Height(), (PixelFormat)2498570);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.DrawImage(image_0, 0, 0, image_0.get_Width(), image_0.get_Height());
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		Bitmap val3 = val;
		((Image)val3).RotateFlip((RotateFlipType)6);
		Bitmap val4 = new Bitmap(((Image)val3).get_Width(), ((Image)val3).get_Height(), (PixelFormat)2498570);
		BitmapData val5 = val3.LockBits(new Rectangle(0, 0, ((Image)val3).get_Width(), ((Image)val3).get_Height()), (ImageLockMode)1, (PixelFormat)2498570);
		BitmapData val6 = val4.LockBits(new Rectangle(0, 0, ((Image)val4).get_Width(), ((Image)val4).get_Height()), (ImageLockMode)1, (PixelFormat)2498570);
		byte* ptr = (byte*)(void*)val5.get_Scan0();
		byte* ptr2 = (byte*)(void*)val6.get_Scan0();
		int num = val5.get_Stride() - val5.get_Width() * 4;
		int height = val5.get_Height();
		int width = val5.get_Width();
		for (int i = 0; i < height; i++)
		{
			int num2 = Math.Max(195, (int)(265.0 * (((double)i + (double)val5.get_Height() * 0.4) / (double)(float)val5.get_Height())));
			for (int j = 0; j < width; j++)
			{
				*ptr2 = *ptr;
				ptr2[1] = ptr[1];
				ptr2[2] = ptr[2];
				ptr2[3] = (byte)Math.Max(0, ptr[3] - num2);
				ptr += 4;
				ptr2 += 4;
			}
			ptr += num;
			ptr2 += num;
		}
		val4.UnlockBits(val6);
		val3.UnlockBits(val5);
		return val4;
	}

	public unsafe static Bitmap smethod_1(Image image_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		if (image_0 == null)
		{
			return null;
		}
		Bitmap val = (Bitmap)(object)((image_0 is Bitmap) ? image_0 : null);
		if ((int)image_0.get_PixelFormat() != 2498570 || val == null)
		{
			Bitmap val2 = new Bitmap(image_0.get_Width(), image_0.get_Height(), (PixelFormat)2498570);
			Graphics val3 = Graphics.FromImage((Image)(object)val2);
			try
			{
				val3.DrawImage(image_0, 0, 0, image_0.get_Width(), image_0.get_Height());
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			val = val2;
		}
		Bitmap val4 = new Bitmap(((Image)val).get_Width(), ((Image)val).get_Height(), (PixelFormat)2498570);
		BitmapData val5 = val.LockBits(new Rectangle(0, 0, ((Image)val).get_Width(), ((Image)val).get_Height()), (ImageLockMode)1, (PixelFormat)2498570);
		BitmapData val6 = val4.LockBits(new Rectangle(0, 0, ((Image)val4).get_Width(), ((Image)val4).get_Height()), (ImageLockMode)1, (PixelFormat)2498570);
		byte* ptr = (byte*)(void*)val5.get_Scan0();
		byte* ptr2 = (byte*)(void*)val6.get_Scan0();
		int num = val5.get_Stride() - val5.get_Width() * 4;
		int height = val5.get_Height();
		int width = val5.get_Width();
		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
				byte b = (byte)((ptr[2] + 255) / 2);
				byte b2 = (byte)((ptr[1] + 255) / 2);
				byte b3 = (byte)((*ptr + 255) / 2);
				b3 = (*ptr2 = (b2 = (b = (byte)((double)(int)b3 * 0.299 + (double)(int)b2 * 0.587 + (double)(int)b * 0.114))));
				ptr2[1] = b2;
				ptr2[2] = b;
				ptr2[3] = ptr[3];
				ptr += 4;
				ptr2 += 4;
			}
			ptr += num;
			ptr2 += num;
		}
		val4.UnlockBits(val6);
		val.UnlockBits(val5);
		return val4;
	}
}
