using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class117 : Class116, Interface3
{
	private Office2007ColorTable office2007ColorTable_0;

	public Office2007ColorTable Office2007ColorTable_0
	{
		get
		{
			return office2007ColorTable_0;
		}
		set
		{
			office2007ColorTable_0 = value;
		}
	}

	public override void PaintTabGroup(RibbonTabGroupRendererEventArgs e)
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		Graphics graphics = e.Graphics;
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = method_1(e.RibbonTabItemGroup);
		if (office2007RibbonTabGroupColorTable == null)
		{
			return;
		}
		if (e.ItemPaintArgs.GlassEnabled)
		{
			if (e.ItemPaintArgs.bool_0)
			{
				return;
			}
			method_0(graphics, office2007RibbonTabGroupColorTable, e.Bounds, e.GroupBounds, bool_0: true);
			Rectangle bounds = e.Bounds;
			bounds.Height -= 2;
			IntPtr hdc = graphics.GetHdc();
			Font groupFont = e.GroupFont;
			string groupTitle = e.RibbonTabItemGroup.GroupTitle;
			Enum10 dwTextFlags = (Enum10)32805;
			try
			{
				IntPtr intPtr = Class51.CreateCompatibleDC(hdc);
				try
				{
					Class51.BITMAPINFO bITMAPINFO = new Class51.BITMAPINFO();
					bITMAPINFO.biWidth = bounds.Width;
					bITMAPINFO.biHeight = -bounds.Height;
					bITMAPINFO.biPlanes = 1;
					bITMAPINFO.biBitCount = 32;
					bITMAPINFO.biSize = Marshal.SizeOf((object)bITMAPINFO);
					IntPtr hObject = Class51.CreateDIBSection(hdc, bITMAPINFO, 0u, 0, IntPtr.Zero, 0u);
					Class51.SelectObject(intPtr, hObject);
					IntPtr hObject2 = groupFont.ToHfont();
					Class51.SelectObject(intPtr, hObject2);
					Class58.RECT pRect = new Class58.RECT(new Rectangle(0, 0, bounds.Width, bounds.Height));
					VisualStyleRenderer val = new VisualStyleRenderer(Caption.get_Active());
					Class58.DTTOPTS options = default(Class58.DTTOPTS);
					options.iGlowSize = 10;
					options.crText = new Class58.COLORREF(SystemColors.ControlText);
					options.dwFlags = 10241;
					options.dwSize = Marshal.SizeOf((object)options);
					Graphics val2 = Graphics.FromHdc(intPtr);
					try
					{
						method_0(val2, office2007RibbonTabGroupColorTable, new Rectangle(0, 0, bounds.Width, bounds.Height + 2), new Rectangle(0, 0, bounds.Width, bounds.Height + 2), bool_0: true);
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
					Class58.DrawThemeTextEx(val.get_Handle(), intPtr, 0, 0, groupTitle, -1, (int)dwTextFlags, ref pRect, ref options);
					Class51.BitBlt(hdc, bounds.Left, bounds.Top, bounds.Width, bounds.Height, intPtr, 0, 0, 13369376u);
					Class51.DeleteObject(hObject2);
					Class51.DeleteObject(hObject);
					return;
				}
				finally
				{
					Class51.DeleteDC(intPtr);
				}
			}
			finally
			{
				graphics.ReleaseHdc(hdc);
			}
		}
		method_0(graphics, office2007RibbonTabGroupColorTable, e.Bounds, e.GroupBounds, bool_0: false);
		ElementStyle style = e.RibbonTabItemGroup.Style;
		Color textColor = style.TextColor;
		Color textShadowColor = style.TextShadowColor;
		Point textShadowOffset = style.TextShadowOffset;
		style.Boolean_7 = true;
		style.TextColor = office2007RibbonTabGroupColorTable.Text;
		style.TextShadowColor = Color.Empty;
		style.TextShadowOffset = Point.Empty;
		ElementStyleDisplayInfo e2 = new ElementStyleDisplayInfo(style, e.Graphics, e.Bounds);
		ElementStyleDisplay.PaintText(e2, e.RibbonTabItemGroup.GroupTitle, e.GroupFont, useDefaultFont: false, e.RibbonTabItemGroup.Style.ETextFormat_0 | eTextFormat.VerticalCenter);
		style.TextColor = textColor;
		style.TextShadowColor = textShadowColor;
		style.TextShadowOffset = textShadowOffset;
		style.Boolean_7 = false;
	}

	private void method_0(Graphics graphics_0, Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable_0, Rectangle rectangle_0, Rectangle rectangle_1, bool bool_0)
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		if (office2007RibbonTabGroupColorTable_0 != null)
		{
			Rectangle rectangle = rectangle_0;
			rectangle.Height -= 2;
			Rectangle rectangle2 = rectangle;
			rectangle2.Width--;
			Class50.smethod_27(graphics_0, rectangle2, office2007RibbonTabGroupColorTable_0.Background.Start, office2007RibbonTabGroupColorTable_0.Background.End, 90, new float[3] { 0f, 0.1f, 0.9f }, new float[3]
			{
				0f,
				bool_0 ? 0.4f : 0.7f,
				1f
			});
			if (!office2007RibbonTabGroupColorTable_0.BackgroundHighlight.IsEmpty && rectangle.Width > 0 && rectangle.Height > 0)
			{
				Rectangle rectangle3 = new Rectangle(rectangle.X - rectangle.Width * 3, rectangle.Y, rectangle.Width * 7, (int)((float)rectangle.Height * 4.5f));
				GraphicsPath val = new GraphicsPath();
				val.AddEllipse(rectangle3);
				PathGradientBrush val2 = new PathGradientBrush(val);
				val2.set_CenterColor(office2007RibbonTabGroupColorTable_0.BackgroundHighlight.Start);
				val2.set_SurroundColors(new Color[1] { office2007RibbonTabGroupColorTable_0.BackgroundHighlight.End });
				val2.set_CenterPoint(new PointF(rectangle3.X + rectangle3.Width / 2, rectangle.Bottom));
				Blend val3 = new Blend();
				val3.set_Factors(new float[3] { 0f, 0.05f, 1f });
				val3.set_Positions(new float[3] { 0f, 0.8f, 1f });
				val2.set_Blend(val3);
				val.Dispose();
				graphics_0.FillRectangle((Brush)(object)val2, rectangle2);
				((Brush)val2).Dispose();
				val.Dispose();
			}
			Pen val4 = new Pen(Color.FromArgb(64, ControlPaint.Dark(office2007RibbonTabGroupColorTable_0.BackgroundHighlight.Start)));
			try
			{
				graphics_0.DrawLine(val4, rectangle.X, rectangle.Bottom, rectangle.Right - 1, rectangle.Bottom);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
			rectangle = rectangle_0;
			SmoothingMode smoothingMode = graphics_0.get_SmoothingMode();
			graphics_0.set_SmoothingMode((SmoothingMode)0);
			Rectangle rectangle4 = rectangle_1;
			Class50.smethod_25(graphics_0, new Rectangle(rectangle4.X, rectangle.Y, 1, rectangle.Height), office2007RibbonTabGroupColorTable_0.Border);
			Class50.smethod_25(graphics_0, new Rectangle(rectangle4.Right - 1, rectangle.Y, 1, rectangle.Height), office2007RibbonTabGroupColorTable_0.Border);
			Class50.smethod_26(graphics_0, new Rectangle(rectangle4.X, rectangle.Bottom - 1, 1, rectangle4.Height - rectangle.Height), office2007RibbonTabGroupColorTable_0.Border.End, Color.Transparent, 90);
			Class50.smethod_26(graphics_0, new Rectangle(rectangle4.Right - 1, rectangle.Bottom - 1, 1, rectangle4.Height - rectangle.Height), office2007RibbonTabGroupColorTable_0.Border.End, Color.Transparent, 90);
			graphics_0.set_SmoothingMode(smoothingMode);
		}
	}

	private Office2007RibbonTabGroupColorTable method_1(RibbonTabItemGroup ribbonTabItemGroup_0)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = null;
		if (ribbonTabItemGroup_0.CustomColorName != "")
		{
			office2007RibbonTabGroupColorTable = office2007ColorTable_0.RibbonTabGroupColors[ribbonTabItemGroup_0.CustomColorName];
		}
		if (office2007RibbonTabGroupColorTable == null)
		{
			office2007RibbonTabGroupColorTable = office2007ColorTable_0.RibbonTabGroupColors[Enum.GetName(typeof(eRibbonTabGroupColor), ribbonTabItemGroup_0.Color)];
		}
		if (office2007RibbonTabGroupColorTable == null && office2007ColorTable_0.RibbonTabGroupColors.Count > 0)
		{
			office2007RibbonTabGroupColorTable = office2007ColorTable_0.RibbonTabGroupColors[0];
		}
		return office2007RibbonTabGroupColorTable;
	}
}
