using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar;

internal class Class169 : Class168, Interface3
{
	private class Class170 : IComparer
	{
		int IComparer.Compare(object x, object y)
		{
			if (x is Rectangle && y is Rectangle)
			{
				return ((Rectangle)x).Width - ((Rectangle)y).Width;
			}
			return new CaseInsensitiveComparer().Compare(x, y);
		}
	}

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

	public override void PaintBackground(RibbonControlRendererEventArgs e)
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		Graphics graphics = e.Graphics;
		RibbonControl ribbonControl = e.RibbonControl;
		Office2007RibbonColorTable ribbonControl2 = office2007ColorTable_0.RibbonControl;
		Office2007RibbonTabItemStateColorTable office2007RibbonTabItemStateColorTable = null;
		PaintCaptionBackground(e, ((Control)ribbonControl).get_DisplayRectangle());
		if (ribbonControl.Expanded && ribbonControl.RibbonStrip.Boolean_3)
		{
			int cornerSize = ribbonControl2.CornerSize;
			Rectangle empty = Rectangle.Empty;
			if (ribbonControl.SelectedRibbonTabItem != null && ribbonControl.Expanded)
			{
				empty = ribbonControl.SelectedRibbonTabItem.DisplayRectangle;
				office2007RibbonTabItemStateColorTable = Class269.smethod_10(Class269.smethod_8(Office2007ColorTable_0, ribbonControl.SelectedRibbonTabItem), ribbonControl.SelectedRibbonTabItem, ribbonControl.Expanded);
			}
			else
			{
				empty = Rectangle.Empty;
			}
			Rectangle rectangle_ = new Rectangle(((Control)ribbonControl).get_ClientRectangle().X, ((Control)ribbonControl).get_ClientRectangle().Bottom - cornerSize, ((Control)ribbonControl).get_ClientRectangle().Width - 1, cornerSize);
			if (!empty.IsEmpty)
			{
				rectangle_ = new Rectangle(((Control)ribbonControl).get_ClientRectangle().X, empty.Bottom, ((Control)ribbonControl).get_ClientRectangle().Width - 1, ((Control)ribbonControl).get_ClientRectangle().Bottom - empty.Bottom);
			}
			GraphicsPath val = method_0(rectangle_, cornerSize);
			try
			{
				SolidBrush val2 = new SolidBrush(office2007ColorTable_0.RibbonBar.Default.TopBackground.Start);
				try
				{
					graphics.FillPath((Brush)(object)val2, val);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			GraphicsPath val3 = method_0(rectangle_, cornerSize);
			try
			{
				Region val4 = null;
				if (graphics.get_Clip() != null)
				{
					val4 = graphics.get_Clip().Clone();
				}
				if (!empty.IsEmpty)
				{
					if (office2007RibbonTabItemStateColorTable != null)
					{
						Pen val5 = new Pen(office2007RibbonTabItemStateColorTable.Background.End, 1f);
						try
						{
							graphics.DrawLine(val5, empty.X + 1, empty.Bottom, empty.Right - 1, empty.Bottom);
						}
						finally
						{
							((IDisposable)val5)?.Dispose();
						}
					}
					graphics.SetClip(new Rectangle(empty.X + 1, empty.Bottom, empty.Width - 1, 1), (CombineMode)4);
				}
				Pen val6 = new Pen(ribbonControl2.OuterBorder.Start, 1f);
				try
				{
					graphics.DrawPath(val6, val3);
				}
				finally
				{
					((IDisposable)val6)?.Dispose();
				}
				if (!empty.IsEmpty)
				{
					if (val4 != null)
					{
						graphics.set_Clip(val4);
					}
					else
					{
						graphics.ResetClip();
					}
				}
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			rectangle_.Y++;
			GraphicsPath val7 = method_0(rectangle_, cornerSize);
			try
			{
				Pen val8 = new Pen(ribbonControl2.InnerBorder.Start, 1f);
				try
				{
					graphics.DrawPath(val8, val7);
					return;
				}
				finally
				{
					((IDisposable)val8)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val7)?.Dispose();
			}
		}
		int num = ((Control)ribbonControl).get_ClientRectangle().Bottom - 2;
		if (!ribbonControl2.TabDividerBorder.IsEmpty)
		{
			Pen val9 = new Pen(ribbonControl2.TabDividerBorder, 1f);
			try
			{
				graphics.DrawLine(val9, 0, num, ((Control)ribbonControl).get_ClientRectangle().Right, num);
			}
			finally
			{
				((IDisposable)val9)?.Dispose();
			}
			num++;
		}
		if (!ribbonControl2.TabDividerBorderLight.IsEmpty)
		{
			Pen val10 = new Pen(ribbonControl2.TabDividerBorderLight, 1f);
			try
			{
				graphics.DrawLine(val10, 0, num, ((Control)ribbonControl).get_ClientRectangle().Right, num);
			}
			finally
			{
				((IDisposable)val10)?.Dispose();
			}
		}
	}

	public override void PaintCaptionBackground(RibbonControlRendererEventArgs e, Rectangle displayRect)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = e.Graphics;
		RibbonControl ribbonControl = e.RibbonControl;
		Office2007RibbonColorTable ribbonControl2 = office2007ColorTable_0.RibbonControl;
		int num = method_1(ribbonControl.Items);
		if (num > 2)
		{
			num -= 3;
			if (!e.GlassEnabled)
			{
				if (!ribbonControl2.TabDividerBorder.IsEmpty)
				{
					Pen val = new Pen(ribbonControl2.TabDividerBorder, 1f);
					try
					{
						graphics.DrawLine(val, 0, num, displayRect.Right + 12, num);
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
					num++;
				}
				if (!ribbonControl2.TabDividerBorderLight.IsEmpty)
				{
					Pen val2 = new Pen(ribbonControl2.TabDividerBorderLight, 1f);
					try
					{
						graphics.DrawLine(val2, 0, num, displayRect.Right + 12, num);
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
				}
			}
			else
			{
				Pen val3 = new Pen(office2007ColorTable_0.Form.Active.BorderColors[0], 1f);
				try
				{
					graphics.DrawLine(val3, 0, num, displayRect.Right + 12, num);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
		}
		if (!ribbonControl.RibbonStrip.CaptionVisible)
		{
			return;
		}
		Office2007FormStateColorTable office2007FormStateColorTable = office2007ColorTable_0.Form.Active;
		Form val4 = ((Control)ribbonControl).FindForm();
		if (!ribbonControl.Boolean_0 && val4 != null && ((val4 != Form.get_ActiveForm() && val4.get_MdiParent() == null) || (val4.get_MdiParent() != null && val4.get_MdiParent().get_ActiveMdiChild() != val4)))
		{
			office2007FormStateColorTable = office2007ColorTable_0.Form.Inactive;
		}
		Rectangle rectangle = new Rectangle(displayRect.X, displayRect.Y, displayRect.Width, num - 1);
		if (rectangle.Height <= 0)
		{
			rectangle.Height = ribbonControl.RibbonStrip.method_34();
		}
		if (!e.GlassEnabled)
		{
			Rectangle rectangle2 = rectangle;
			if (val4 is Office2007RibbonForm)
			{
				rectangle2.Width = ((Control)(Office2007RibbonForm)(object)val4).get_Width();
			}
			SmoothingMode smoothingMode = graphics.get_SmoothingMode();
			graphics.set_SmoothingMode((SmoothingMode)0);
			LinearGradientBrush val5 = new LinearGradientBrush(rectangle2, office2007FormStateColorTable.CaptionTopBackground.Start, office2007FormStateColorTable.CaptionBottomBackground.End, (float)office2007FormStateColorTable.CaptionTopBackground.GradientAngle);
			try
			{
				ColorBlend val6 = new ColorBlend(4);
				val6.set_Colors(new Color[4]
				{
					office2007FormStateColorTable.CaptionTopBackground.Start,
					office2007FormStateColorTable.CaptionTopBackground.End,
					office2007FormStateColorTable.CaptionBottomBackground.Start,
					office2007FormStateColorTable.CaptionBottomBackground.End
				});
				val6.set_Positions(new float[4] { 0f, 0.4f, 0.4f, 1f });
				val5.set_InterpolationColors(val6);
				graphics.FillRectangle((Brush)(object)val5, rectangle2);
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
			graphics.set_SmoothingMode(smoothingMode);
		}
		ribbonControl.RibbonStrip.Rectangle_1 = rectangle;
	}

	private GraphicsPath method_0(Rectangle rectangle_0, int int_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		if (rectangle_0.Height > int_0)
		{
			val.AddLine(rectangle_0.X, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Y + int_0);
		}
		ElementStyleDisplay.smethod_9(val, rectangle_0, int_0, Enum14.const_0);
		val.AddLine(rectangle_0.X + int_0, rectangle_0.Y, rectangle_0.Right - int_0, rectangle_0.Y);
		ElementStyleDisplay.smethod_9(val, rectangle_0, int_0, Enum14.const_1);
		if (rectangle_0.Height > int_0)
		{
			val.AddLine(rectangle_0.Right, rectangle_0.Y + int_0, rectangle_0.Right, rectangle_0.Bottom);
		}
		return val;
	}

	private int method_1(SubItemsCollection subItemsCollection_0)
	{
		foreach (BaseItem item in subItemsCollection_0)
		{
			if (item is RibbonTabItem && item.Visible)
			{
				return item.Bounds.Top;
			}
		}
		return -1;
	}

	public override void PaintCaptionText(RibbonControlRendererEventArgs e)
	{
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Invalid comparison between Unknown and I4
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Invalid comparison between Unknown and I4
		RibbonStrip ribbonStrip = e.RibbonControl.RibbonStrip;
		if (!ribbonStrip.CaptionVisible || ribbonStrip.Rectangle_1.IsEmpty)
		{
			return;
		}
		Graphics graphics = e.Graphics;
		bool flag = false;
		bool flag2 = true;
		Office2007FormStateColorTable office2007FormStateColorTable = office2007ColorTable_0.Form.Active;
		Form val = ((Control)ribbonStrip).FindForm();
		if (val != null && ((val != Form.get_ActiveForm() && val.get_MdiParent() == null) || (val.get_MdiParent() != null && val.get_MdiParent().get_ActiveMdiChild() != val)))
		{
			office2007FormStateColorTable = office2007ColorTable_0.Form.Inactive;
			flag2 = false;
		}
		string titleText = e.RibbonControl.TitleText;
		string string_ = titleText;
		bool flag3;
		if (flag3 = e.RibbonControl.RibbonStrip.Class261_0 != null)
		{
			string_ = e.RibbonControl.RibbonStrip.Class261_0.string_0;
		}
		if (val != null)
		{
			if (titleText == "")
			{
				titleText = ((Control)val).get_Text();
				string_ = titleText;
			}
			flag = (int)val.get_WindowState() == 2;
		}
		Rectangle rectangle_ = ribbonStrip.Rectangle_1;
		if (!ribbonStrip.Rectangle_2.IsEmpty)
		{
			method_3(ref rectangle_, ribbonStrip.Rectangle_2);
		}
		else
		{
			BaseItem baseItem = e.RibbonControl.method_47();
			if (baseItem != null && baseItem.Visible && baseItem.Displayed)
			{
				method_3(ref rectangle_, baseItem.Bounds);
			}
			else
			{
				method_3(ref rectangle_, new Rectangle(0, 0, 22, 22));
			}
		}
		if (!ribbonStrip.Rectangle_3.IsEmpty)
		{
			method_3(ref rectangle_, ribbonStrip.Rectangle_3);
		}
		ArrayList arrayList = new ArrayList(5);
		ArrayList arrayList2 = new ArrayList(5);
		if (ribbonStrip.TabGroupsVisible)
		{
			foreach (RibbonTabItemGroup tabGroup in ribbonStrip.TabGroups)
			{
				foreach (Rectangle item in tabGroup.arrayList_0)
				{
					if (arrayList.Count > 0)
					{
						arrayList2.Clear();
						Rectangle[] array = new Rectangle[arrayList.Count];
						arrayList.CopyTo(array);
						for (int i = 0; i < array.Length; i++)
						{
							if (array[i].IntersectsWith(item))
							{
								arrayList2.Add(i);
								Rectangle[] c = Class50.smethod_47(array[i], item);
								arrayList.AddRange(c);
							}
						}
						foreach (int item2 in arrayList2)
						{
							arrayList.RemoveAt(item2);
						}
					}
					else if (item.IntersectsWith(rectangle_))
					{
						Rectangle[] array2 = Class50.smethod_47(rectangle_, item);
						if (array2.Length > 0)
						{
							arrayList.AddRange(array2);
							break;
						}
					}
				}
			}
		}
		Font val2 = SystemInformation.get_MenuFont();
		if (ribbonStrip.CaptionFont != null)
		{
			val2 = ribbonStrip.CaptionFont;
		}
		Size empty = Size.Empty;
		empty = ((!flag3) ? Class55.smethod_3(graphics, string_, val2) : e.RibbonControl.RibbonStrip.Class261_0.Bounds.Size);
		if (arrayList.Count > 0)
		{
			ribbonStrip.Rectangle_0 = (Rectangle[])arrayList.ToArray(typeof(Rectangle));
			if ((int)((Control)e.RibbonControl).get_RightToLeft() == 0)
			{
				arrayList.Reverse();
			}
			rectangle_ = Rectangle.Empty;
			foreach (Rectangle item3 in arrayList)
			{
				if (item3.Width < empty.Width)
				{
					if (item3.Width > rectangle_.Width)
					{
						rectangle_ = item3;
					}
					continue;
				}
				rectangle_ = item3;
				break;
			}
		}
		else
		{
			ribbonStrip.Rectangle_0 = new Rectangle[1] { rectangle_ };
		}
		if (rectangle_.Width <= 6 || rectangle_.Height <= 6)
		{
			return;
		}
		if (e.GlassEnabled && e.itemPaintArgs_0 != null && e.itemPaintArgs_0.Class77_0 != null && !e.RibbonControl.Boolean_0)
		{
			if (!e.itemPaintArgs_0.bool_0 || flag)
			{
				method_2(graphics, string_, val2, rectangle_, flag);
			}
			return;
		}
		if (!flag3)
		{
			Class55.smethod_1(graphics, string_, val2, office2007FormStateColorTable.CaptionText, rectangle_, eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.NoPrefix | eTextFormat.VerticalCenter);
			return;
		}
		Class263 @class = new Class263(graphics, val2, office2007FormStateColorTable.CaptionText, (int)((Control)e.RibbonControl).get_RightToLeft() == 1, rectangle_, hotKeyPrefixVisible: false);
		@class.bool_4 = false;
		@class.bool_5 = !flag2;
		Class261 class261_ = e.RibbonControl.RibbonStrip.Class261_0;
		if (e.RibbonControl.RibbonStrip.rectangle_4 != rectangle_)
		{
			class261_.Measure(rectangle_.Size, @class);
			class261_.method_2(rectangle_, @class);
			e.RibbonControl.RibbonStrip.rectangle_4 = rectangle_;
			Rectangle bounds = class261_.Bounds;
			if (bounds.Width < rectangle_.Width)
			{
				bounds.Offset((rectangle_.Width - bounds.Width) / 2, 0);
			}
			if (bounds.Height < rectangle_.Height)
			{
				bounds.Offset(0, (rectangle_.Height - bounds.Height) / 2);
			}
			class261_.Bounds = bounds;
		}
		Region clip = graphics.get_Clip();
		graphics.SetClip(rectangle_, (CombineMode)1);
		class261_.Render(@class);
		graphics.set_Clip(clip);
	}

	public static void smethod_0(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, Enum10 enum10_0)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		IntPtr hdc = graphics_0.GetHdc();
		try
		{
			IntPtr intPtr = Class51.CreateCompatibleDC(hdc);
			try
			{
				Class51.BITMAPINFO bITMAPINFO = new Class51.BITMAPINFO();
				bITMAPINFO.biWidth = rectangle_0.Width;
				bITMAPINFO.biHeight = -rectangle_0.Height;
				bITMAPINFO.biPlanes = 1;
				bITMAPINFO.biBitCount = 32;
				bITMAPINFO.biSize = Marshal.SizeOf((object)bITMAPINFO);
				IntPtr hObject = Class51.CreateDIBSection(hdc, bITMAPINFO, 0u, 0, IntPtr.Zero, 0u);
				Class51.SelectObject(intPtr, hObject);
				IntPtr hObject2 = font_0.ToHfont();
				Class51.SelectObject(intPtr, hObject2);
				Class58.RECT pRect = new Class58.RECT(new Rectangle(0, 0, rectangle_0.Width, rectangle_0.Height));
				VisualStyleRenderer val = new VisualStyleRenderer(Caption.get_Active());
				Class58.DTTOPTS options = default(Class58.DTTOPTS);
				options.iGlowSize = 16;
				options.crText = new Class58.COLORREF(SystemColors.ControlText);
				options.dwFlags = 10241;
				options.dwSize = Marshal.SizeOf((object)options);
				Class58.DrawThemeTextEx(val.get_Handle(), intPtr, 0, 0, string_0, -1, (int)enum10_0, ref pRect, ref options);
				Class51.BitBlt(hdc, rectangle_0.Left, rectangle_0.Top, rectangle_0.Width, rectangle_0.Height, intPtr, 0, 0, 13369376u);
				Class51.DeleteObject(hObject2);
				Class51.DeleteObject(hObject);
			}
			finally
			{
				Class51.DeleteDC(intPtr);
			}
		}
		finally
		{
			graphics_0.ReleaseHdc(hdc);
		}
	}

	private void method_2(Graphics graphics_0, string string_0, Font font_0, Rectangle rectangle_0, bool bool_0)
	{
		if (bool_0)
		{
			rectangle_0.Offset(0, 3);
			Class55.smethod_1(graphics_0, string_0, font_0, Color.White, rectangle_0, eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.NoPrefix | eTextFormat.VerticalCenter);
		}
		else
		{
			smethod_0(graphics_0, string_0, font_0, rectangle_0, (Enum10)32805);
		}
	}

	private void method_3(ref Rectangle rectangle_0, Rectangle rectangle_1)
	{
		if (rectangle_1.X + rectangle_1.Width / 2 < rectangle_0.X + rectangle_0.Width / 2)
		{
			int num = rectangle_1.Right - rectangle_0.X;
			rectangle_0.X = rectangle_1.Right;
			rectangle_0.Width -= num;
		}
		else
		{
			rectangle_0.Width -= rectangle_0.Right - rectangle_1.X;
		}
	}

	public override void PaintQuickAccessToolbarBackground(RibbonControlRendererEventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected O, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected O, but got Unknown
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		RibbonStrip ribbonStrip = e.RibbonControl.RibbonStrip;
		RibbonControl ribbonControl = e.RibbonControl;
		if (!ribbonStrip.CaptionVisible)
		{
			return;
		}
		Graphics graphics = e.Graphics;
		bool flag = (int)((Control)ribbonStrip).get_RightToLeft() == 1;
		bool flag2 = true;
		Office2007QuickAccessToolbarStateColorTable office2007QuickAccessToolbarStateColorTable = office2007ColorTable_0.QuickAccessToolbar.Active;
		Form val = ((Control)ribbonStrip).FindForm();
		bool flag3 = false;
		if (val != null)
		{
			flag3 = (int)val.get_WindowState() == 2;
		}
		if (val != null && !e.RibbonControl.Boolean_0 && ((val != Form.get_ActiveForm() && val.get_MdiParent() == null) || (val.get_MdiParent() != null && val.get_MdiParent().get_ActiveMdiChild() != val)))
		{
			office2007QuickAccessToolbarStateColorTable = office2007ColorTable_0.QuickAccessToolbar.Inactive;
		}
		int num = 0;
		int num2 = 0;
		Size size = Size.Empty;
		for (int num3 = ribbonStrip.QuickToolbarItems.Count - 1; num3 >= 0; num3--)
		{
			BaseItem baseItem = ribbonStrip.QuickToolbarItems[num3];
			if (baseItem.Visible && baseItem.Displayed)
			{
				if (baseItem is QatCustomizeItem)
				{
					size = baseItem.DisplayRectangle.Size;
				}
				if (baseItem.ItemAlignment == eItemAlignment.Near && baseItem.Visible && num3 > 0)
				{
					num = ((!flag) ? baseItem.DisplayRectangle.Right : baseItem.DisplayRectangle.X);
					break;
				}
				if (baseItem.ItemAlignment == eItemAlignment.Far && baseItem.Visible)
				{
					num2 = ((!flag) ? baseItem.DisplayRectangle.X : baseItem.DisplayRectangle.Right);
				}
			}
		}
		if (num == 0)
		{
			flag2 = false;
		}
		if (ribbonStrip.CaptionContainerItem is Class181 && ((Class181)ribbonStrip.CaptionContainerItem).DisplayMoreItem_0 != null)
		{
			num = ((!flag) ? ((Class181)ribbonStrip.CaptionContainerItem).DisplayMoreItem_0.DisplayRectangle.Right : ((Class181)ribbonStrip.CaptionContainerItem).DisplayMoreItem_0.DisplayRectangle.X);
			size = ((Class181)ribbonStrip.CaptionContainerItem).DisplayMoreItem_0.DisplayRectangle.Size;
		}
		Rectangle rectangle_ = ribbonStrip.Rectangle_1;
		if (num2 > 0)
		{
			if (flag)
			{
				ribbonStrip.Rectangle_3 = new Rectangle(rectangle_.X, rectangle_.Y, num2, rectangle_.Height);
			}
			else
			{
				ribbonStrip.Rectangle_3 = new Rectangle(num2, rectangle_.Y, rectangle_.Right - num2, rectangle_.Height);
			}
		}
		if (num == 0 || rectangle_.Height <= 0 || rectangle_.Width <= 0)
		{
			return;
		}
		if (!ribbonControl.QatPositionedBelowRibbon)
		{
			BaseItem baseItem2 = ribbonControl.method_47();
			if (baseItem2 != null)
			{
				int num4 = ribbonStrip.QuickToolbarItems.IndexOf(baseItem2);
				if (ribbonStrip.QuickToolbarItems.Count - 1 > num4)
				{
					BaseItem baseItem3 = ribbonStrip.QuickToolbarItems[num4 + 1];
					if (flag)
					{
						rectangle_.Width -= rectangle_.Right - baseItem3.DisplayRectangle.Right;
					}
					else
					{
						rectangle_.Width -= baseItem3.DisplayRectangle.X - rectangle_.X;
						rectangle_.X = baseItem3.DisplayRectangle.X;
					}
				}
			}
			rectangle_.Height = ((Class181)ribbonControl.RibbonStrip.CaptionContainerItem).Int32_4 + 6;
		}
		int num5 = rectangle_.Right - num;
		if (flag)
		{
			rectangle_.Width = num5;
			if (flag)
			{
				rectangle_.X += num;
			}
		}
		else
		{
			rectangle_.Width -= num5;
		}
		if (e.GlassEnabled)
		{
			rectangle_.Inflate(0, -3);
			rectangle_.Offset(0, 2);
		}
		else
		{
			rectangle_.Inflate(0, -2);
			if (flag3)
			{
				rectangle_.Y++;
				rectangle_.Height--;
			}
		}
		GraphicsPath val2 = method_4(rectangle_, flag);
		if (val2 == null)
		{
			return;
		}
		Rectangle rectangle2 = (ribbonStrip.Rectangle_2 = Rectangle.Ceiling(val2.GetBounds()));
		rectangle_.Width -= size.Width + size.Height / 2;
		if (flag)
		{
			rectangle_.X += size.Width + size.Height / 2 + 3;
		}
		val2.Dispose();
		val2 = method_4(rectangle_, flag);
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		if (ribbonControl.QatPositionedBelowRibbon || !flag2 || rectangle_.Width <= 6)
		{
			return;
		}
		bool flag4 = false;
		if (e.GlassEnabled)
		{
			graphics.set_SmoothingMode((SmoothingMode)2);
			if (e.GlassEnabled && flag3)
			{
				Class50.smethod_28(graphics, val2, Color.FromArgb(72, Color.LightGray), Color.Empty);
			}
			Class50.smethod_39(graphics, val2, office2007QuickAccessToolbarStateColorTable.GlassBorder, 1);
			graphics.set_SmoothingMode(smoothingMode);
			if (e.GlassEnabled)
			{
				flag4 = true;
			}
		}
		else if (!office2007QuickAccessToolbarStateColorTable.OutterBorderColor.IsEmpty)
		{
			graphics.set_SmoothingMode((SmoothingMode)2);
			rectangle_.X++;
			rectangle_.Y--;
			rectangle_.Height += 2;
			GraphicsPath val3 = method_4(rectangle_, flag);
			try
			{
				Pen val4 = new Pen(office2007QuickAccessToolbarStateColorTable.OutterBorderColor);
				try
				{
					graphics.DrawPath(val4, val3);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			rectangle_.X--;
			rectangle_.Y++;
			rectangle_.Height -= 2;
			graphics.set_SmoothingMode(smoothingMode);
			if (e.GlassEnabled)
			{
				flag4 = true;
			}
		}
		Region clip = graphics.get_Clip();
		graphics.SetClip(val2, (CombineMode)1);
		Rectangle rectangle_2 = new Rectangle(rectangle2.X, rectangle2.Y, rectangle2.Width, (int)((double)rectangle_.Height * 0.2));
		Rectangle rectangle_3 = new Rectangle(rectangle2.X, rectangle_2.Bottom, rectangle2.Width, rectangle2.Height - rectangle_2.Height);
		graphics.set_SmoothingMode((SmoothingMode)0);
		if (!e.GlassEnabled)
		{
			Class50.smethod_25(graphics, rectangle_2, office2007QuickAccessToolbarStateColorTable.TopBackground);
			Class50.smethod_25(graphics, rectangle_3, office2007QuickAccessToolbarStateColorTable.BottomBackground);
		}
		else
		{
			Class50.smethod_23(graphics, rectangle2, Color.FromArgb(64, Color.White));
		}
		graphics.set_SmoothingMode(smoothingMode);
		rectangle2.Height -= 2;
		rectangle2.Width += 2;
		rectangle2.Y++;
		rectangle2.X++;
		graphics.SetClip(rectangle2);
		graphics.set_Clip(clip);
		if (!office2007QuickAccessToolbarStateColorTable.MiddleBorderColor.IsEmpty && (!e.GlassEnabled || !flag4))
		{
			graphics.set_SmoothingMode((SmoothingMode)2);
			val2 = method_4(rectangle_, flag);
			Pen val5 = new Pen(office2007QuickAccessToolbarStateColorTable.MiddleBorderColor);
			try
			{
				graphics.DrawPath(val5, val2);
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
			val2.Dispose();
			graphics.set_SmoothingMode(smoothingMode);
		}
	}

	private GraphicsPath method_4(Rectangle rectangle_0, bool bool_0)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		rectangle_0.Offset(-1, 0);
		rectangle_0.Height--;
		rectangle_0.Width--;
		if (rectangle_0.Width >= 2 && rectangle_0.Height >= 2)
		{
			GraphicsPath val = new GraphicsPath();
			int num = 11;
			if (bool_0)
			{
				val.AddCurve(new Point[3]
				{
					new Point(rectangle_0.Right + num, rectangle_0.Y),
					new Point(rectangle_0.Right + 2, rectangle_0.Y + 10),
					new Point(rectangle_0.Right, rectangle_0.Bottom)
				}, 0.6f);
				val.AddLine(rectangle_0.Right, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Bottom);
				val.AddArc(rectangle_0.X - (num + 1), rectangle_0.Y, 20, rectangle_0.Height, 90f, 180f);
				val.AddLine(rectangle_0.X, rectangle_0.Y, rectangle_0.Right + num, rectangle_0.Y);
			}
			else
			{
				val.AddCurve(new Point[3]
				{
					new Point(rectangle_0.X - num, rectangle_0.Y),
					new Point(rectangle_0.X - 2, rectangle_0.Y + 10),
					new Point(rectangle_0.X, rectangle_0.Bottom)
				}, 0.6f);
				val.AddLine(rectangle_0.X, rectangle_0.Bottom, rectangle_0.Right, rectangle_0.Bottom);
				val.AddArc(rectangle_0.Right - (num + 1), rectangle_0.Y, 20, rectangle_0.Height, 90f, -180f);
				val.AddLine(rectangle_0.Right, rectangle_0.Y, rectangle_0.X - num, rectangle_0.Y);
			}
			val.CloseAllFigures();
			return val;
		}
		return null;
	}
}
