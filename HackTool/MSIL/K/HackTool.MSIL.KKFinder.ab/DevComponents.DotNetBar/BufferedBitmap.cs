using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace DevComponents.DotNetBar;

public class BufferedBitmap : IDisposable
{
	private Rectangle rectangle_0 = Rectangle.Empty;

	private IntPtr intptr_0 = IntPtr.Zero;

	private Graphics graphics_0;

	private IntPtr intptr_1 = IntPtr.Zero;

	public Graphics Graphics => graphics_0;

	public Rectangle TargetRect
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

	public BufferedBitmap(Graphics source, Rectangle rect)
	{
		IntPtr hdc = source.GetHdc();
		try
		{
			method_0(hdc, rect);
		}
		finally
		{
			source.ReleaseHdc(hdc);
		}
	}

	public BufferedBitmap(IntPtr hdcSource, Rectangle rect)
	{
		method_0(hdcSource, rect);
	}

	private void method_0(IntPtr intptr_2, Rectangle rectangle_1)
	{
		rectangle_0 = rectangle_1;
		intptr_0 = Class51.CreateCompatibleDC(intptr_2);
		Class51.BITMAPINFO bITMAPINFO = new Class51.BITMAPINFO();
		bITMAPINFO.biWidth = rectangle_1.Width;
		bITMAPINFO.biHeight = rectangle_1.Height;
		bITMAPINFO.biPlanes = 1;
		bITMAPINFO.biBitCount = 32;
		bITMAPINFO.biSize = Marshal.SizeOf((object)bITMAPINFO);
		intptr_1 = Class51.CreateDIBSection(intptr_2, bITMAPINFO, 0u, 0, IntPtr.Zero, 0u);
		Class51.SelectObject(intptr_0, intptr_1);
		graphics_0 = Graphics.FromHdc(intptr_0);
	}

	public void Render(Graphics targetGraphics)
	{
		Render(targetGraphics, new Rectangle[0]);
	}

	public void Render(Graphics targetGraphics, Rectangle exclude)
	{
		Render(targetGraphics, new Rectangle[1] { exclude });
	}

	public void Render(Graphics targetGraphics, Rectangle[] excludeArr)
	{
		IntPtr hdc = targetGraphics.GetHdc();
		try
		{
			if (excludeArr != null && excludeArr.Length > 0)
			{
				for (int i = 0; i < excludeArr.Length; i++)
				{
					Rectangle rectangle = excludeArr[i];
					if (!rectangle.IsEmpty)
					{
						Class51.ExcludeClipRect(hdc, rectangle.X, rectangle.Y, rectangle.Right, rectangle.Bottom);
					}
				}
			}
			Class51.BitBlt(hdc, rectangle_0.Left, rectangle_0.Top, rectangle_0.Width, rectangle_0.Height, intptr_0, 0, 0, 13369376u);
		}
		finally
		{
			targetGraphics.ReleaseHdc(hdc);
		}
	}

	public void Dispose()
	{
		if (graphics_0 != null)
		{
			graphics_0.Dispose();
			graphics_0 = null;
		}
		if (intptr_1 != IntPtr.Zero)
		{
			Class51.DeleteObject(intptr_1);
			intptr_1 = IntPtr.Zero;
		}
		if (intptr_0 != IntPtr.Zero)
		{
			Class51.DeleteDC(intptr_0);
			intptr_0 = IntPtr.Zero;
		}
	}
}
