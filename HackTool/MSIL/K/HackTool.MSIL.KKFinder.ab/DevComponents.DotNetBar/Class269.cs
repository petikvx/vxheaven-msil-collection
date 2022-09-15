using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class269 : Class268
{
	protected override Rectangle GetTextRectangle(ButtonItem button, ItemPaintArgs pa, eTextFormat stringFormat, Class271 image)
	{
		Rectangle textRectangle = base.GetTextRectangle(button, pa, stringFormat, image);
		if (image == null)
		{
			textRectangle.Inflate(-3, 0);
		}
		return textRectangle;
	}

	public override eTextFormat GetStringFormat(ButtonItem button, ItemPaintArgs pa, Class271 image)
	{
		eTextFormat stringFormat = base.GetStringFormat(button, pa, image);
		return stringFormat & ~(stringFormat & eTextFormat.EndEllipsis);
	}

	protected override void PaintState(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle r, bool isMouseDown)
	{
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		if (r.IsEmpty || !Class265.smethod_1(button, pa) || r.Width == 0 || r.Height == 0)
		{
			return;
		}
		if (button is RibbonTabItem ribbonTabItem && !IsOnMenu(button, pa))
		{
			Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = method_4(ribbonTabItem);
			if (office2007RibbonTabItemColorTable == null)
			{
				return;
			}
			bool controlExpanded = pa.ControlExpanded;
			Office2007RibbonTabItemStateColorTable office2007RibbonTabItemStateColorTable = smethod_10(office2007RibbonTabItemColorTable, ribbonTabItem, controlExpanded);
			if (office2007RibbonTabItemStateColorTable == null)
			{
				return;
			}
			Graphics graphics = pa.Graphics;
			int cornerSize = office2007RibbonTabItemColorTable.CornerSize;
			Region clip = graphics.get_Clip();
			Rectangle rectangle = r;
			rectangle.Inflate(1, 1);
			graphics.SetClip(rectangle, (CombineMode)0);
			if (office2007RibbonTabItemStateColorTable != null)
			{
				GraphicsPath val = method_3(r, cornerSize, bool_0: true);
				try
				{
					Class50.smethod_29(graphics, val, office2007RibbonTabItemStateColorTable.Background);
					Class50.smethod_39(graphics, val, office2007RibbonTabItemStateColorTable.OuterBorder, 1);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
				if (ribbonTabItem.Checked && controlExpanded)
				{
					SmoothingMode smoothingMode = graphics.get_SmoothingMode();
					graphics.set_SmoothingMode((SmoothingMode)0);
					if ((double)base.Office2007ColorTable_0.RibbonControl.TabsBackground.Start.GetBrightness() > 0.5)
					{
						GraphicsPath val2 = new GraphicsPath();
						try
						{
							val2.AddRectangle(new Rectangle(r.Right - 1, r.Y + cornerSize + 1, 1, r.Height - cornerSize - 3));
							Class50.smethod_30(graphics, val2, Color.FromArgb(96, office2007RibbonTabItemStateColorTable.OuterBorder.Start), Color.FromArgb(32, office2007RibbonTabItemStateColorTable.OuterBorder.End), 90);
						}
						finally
						{
							((IDisposable)val2)?.Dispose();
						}
						GraphicsPath val3 = new GraphicsPath();
						try
						{
							val3.AddRectangle(new Rectangle(r.X + 1, r.Y + cornerSize + 1, 1, r.Height - cornerSize - 3));
							Class50.smethod_30(graphics, val3, Color.FromArgb(32, office2007RibbonTabItemStateColorTable.OuterBorder.Start), Color.FromArgb(8, office2007RibbonTabItemStateColorTable.OuterBorder.End), 90);
						}
						finally
						{
							((IDisposable)val3)?.Dispose();
						}
					}
					graphics.set_SmoothingMode(smoothingMode);
				}
				Rectangle rectangle_ = r;
				rectangle_.Inflate(-1, 0);
				rectangle_.Height--;
				rectangle_.Y++;
				GraphicsPath val4 = method_3(rectangle_, cornerSize, bool_0: true);
				try
				{
					Class50.smethod_39(graphics, val4, office2007RibbonTabItemStateColorTable.InnerBorder, 1);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
				if (ribbonTabItem.Checked && controlExpanded)
				{
					SolidBrush val5 = new SolidBrush(office2007RibbonTabItemStateColorTable.InnerBorder.Start);
					try
					{
						SmoothingMode smoothingMode2 = graphics.get_SmoothingMode();
						graphics.set_SmoothingMode((SmoothingMode)3);
						graphics.FillRectangle((Brush)(object)val5, new Rectangle(rectangle_.X + cornerSize, rectangle_.Y + 1, rectangle_.Width - cornerSize * 2, 2));
						graphics.set_SmoothingMode(smoothingMode2);
					}
					finally
					{
						((IDisposable)val5)?.Dispose();
					}
				}
				float num = 0.6f;
				float num2 = 0.4f;
				Rectangle rectangle2 = r;
				Rectangle rectangle3 = new Rectangle(rectangle2.X, rectangle2.Y + (int)((float)rectangle2.Height * num), rectangle2.Width, (int)((float)rectangle2.Height * num2));
				if (!office2007RibbonTabItemStateColorTable.BackgroundHighlight.IsEmpty)
				{
					Rectangle rectangle4 = new Rectangle(rectangle3.X, rectangle3.Y, rectangle2.Width, rectangle2.Height);
					GraphicsPath val6 = new GraphicsPath();
					val6.AddEllipse(rectangle4);
					PathGradientBrush val7 = new PathGradientBrush(val6);
					val7.set_CenterColor(office2007RibbonTabItemStateColorTable.BackgroundHighlight.Start);
					val7.set_SurroundColors(new Color[1] { office2007RibbonTabItemStateColorTable.BackgroundHighlight.End });
					val7.set_CenterPoint(new PointF(rectangle4.X + rectangle4.Width / 2, rectangle2.Bottom + 2));
					Blend val8 = new Blend();
					val8.set_Factors(new float[3] { 0f, 0.8f, 1f });
					val8.set_Positions(new float[3] { 0f, 0.55f, 1f });
					val7.set_Blend(val8);
					graphics.FillRectangle((Brush)(object)val7, rectangle3);
					((Brush)val7).Dispose();
					val6.Dispose();
				}
			}
			if (ribbonTabItem.Boolean_8 && !ribbonTabItem.Checked && !ribbonTabItem.IsMouseOver && office2007RibbonTabItemColorTable != null && office2007RibbonTabItemColorTable.Selected != null)
			{
				Color start = base.Office2007ColorTable_0.RibbonControl.OuterBorder.Start;
				if (!start.IsEmpty)
				{
					Class50.smethod_44(graphics, new Point(r.Right - 1, r.Y), new Point(r.Right - 1, r.Bottom - 1), Color.Transparent, start, 90, 1, new float[3] { 0f, 0.8f, 1f }, new float[3] { 0f, 0.5f, 1f });
				}
			}
			graphics.set_Clip(clip);
		}
		else
		{
			base.PaintState(button, pa, image, r, isMouseDown);
		}
	}

	private GraphicsPath method_3(Rectangle rectangle_0, int int_1, bool bool_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		int num = 2;
		if (bool_0)
		{
			val.AddLine(rectangle_0.X, rectangle_0.Bottom, rectangle_0.X + num, rectangle_0.Bottom - num);
		}
		else
		{
			val.AddLine(rectangle_0.X, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Y + int_1);
		}
		rectangle_0.Inflate(-num, 0);
		ElementStyleDisplay.smethod_9(val, rectangle_0, int_1, Enum14.const_0);
		ElementStyleDisplay.smethod_9(val, rectangle_0, int_1, Enum14.const_1);
		if (bool_0)
		{
			val.AddLine(rectangle_0.Right, rectangle_0.Bottom - num, rectangle_0.Right + num, rectangle_0.Bottom);
		}
		else
		{
			val.AddLine(rectangle_0.Right, rectangle_0.Y + int_1, rectangle_0.Right, rectangle_0.Bottom);
		}
		return val;
	}

	protected override Color GetTextColor(ButtonItem button, ItemPaintArgs pa)
	{
		if (Class265.smethod_1(button, pa) && button is RibbonTabItem)
		{
			RibbonTabItem ribbonTabItem_ = button as RibbonTabItem;
			Color result = Color.Empty;
			Office2007RibbonTabItemStateColorTable office2007RibbonTabItemStateColorTable = smethod_10(method_4(ribbonTabItem_), ribbonTabItem_, pa.ControlExpanded);
			if (office2007RibbonTabItemStateColorTable != null)
			{
				result = office2007RibbonTabItemStateColorTable.Text;
			}
			if (result.IsEmpty)
			{
				return base.GetTextColor(button, pa);
			}
			return result;
		}
		return base.GetTextColor(button, pa);
	}

	private Office2007RibbonTabItemColorTable method_4(RibbonTabItem ribbonTabItem_0)
	{
		return smethod_8(base.Office2007ColorTable_0, ribbonTabItem_0);
	}

	internal static Office2007RibbonTabItemColorTable smethod_8(Office2007ColorTable office2007ColorTable_1, RibbonTabItem ribbonTabItem_0)
	{
		if (office2007ColorTable_1 == null)
		{
			return null;
		}
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = office2007ColorTable_1.RibbonTabItemColors[ribbonTabItem_0.vmethod_1()];
		if (office2007RibbonTabItemColorTable == null && office2007ColorTable_1.RibbonTabItemColors.Count > 0)
		{
			office2007RibbonTabItemColorTable = office2007ColorTable_1.RibbonTabItemColors[0];
		}
		return office2007RibbonTabItemColorTable;
	}

	internal static Office2007RibbonTabItemColorTable smethod_9(Office2007ColorTable office2007ColorTable_1)
	{
		if (office2007ColorTable_1 == null)
		{
			return null;
		}
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = office2007ColorTable_1.RibbonTabItemColors["Default"];
		if (office2007RibbonTabItemColorTable == null && office2007ColorTable_1.RibbonTabItemColors.Count > 0)
		{
			office2007RibbonTabItemColorTable = office2007ColorTable_1.RibbonTabItemColors[0];
		}
		return office2007RibbonTabItemColorTable;
	}

	internal static Office2007RibbonTabItemStateColorTable smethod_10(Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable_0, RibbonTabItem ribbonTabItem_0, bool bool_0)
	{
		if (office2007RibbonTabItemColorTable_0 == null)
		{
			return null;
		}
		Office2007RibbonTabItemStateColorTable result = null;
		if (ribbonTabItem_0.Checked && ribbonTabItem_0.IsMouseOver && bool_0)
		{
			result = office2007RibbonTabItemColorTable_0.SelectedMouseOver;
		}
		else if (ribbonTabItem_0.Checked && bool_0)
		{
			result = office2007RibbonTabItemColorTable_0.Selected;
		}
		else if (ribbonTabItem_0.IsMouseOver)
		{
			result = office2007RibbonTabItemColorTable_0.MouseOver;
		}
		else if (ribbonTabItem_0.method_2())
		{
			result = office2007RibbonTabItemColorTable_0.Default;
		}
		return result;
	}
}
