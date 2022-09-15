using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class268 : Class266, Interface3
{
	private int int_0 = 2;

	private Office2007ColorTable office2007ColorTable_0;

	private static RoundRectangleShapeDescriptor roundRectangleShapeDescriptor_0 = new RoundRectangleShapeDescriptor(2);

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

	private bool method_0(ButtonItem buttonItem_0, ItemPaintArgs itemPaintArgs_0)
	{
		if (buttonItem_0.ColorTable != eButtonColor.Flat && !(itemPaintArgs_0.Owner is DotNetBarManager))
		{
			return false;
		}
		return true;
	}

	public override void PaintButtonMouseOver(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle r)
	{
		if (method_0(button, pa))
		{
			base.PaintButtonMouseOver(button, pa, image, r);
		}
	}

	public override void PaintButtonCheck(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle r)
	{
		if (method_0(button, pa))
		{
			base.PaintButtonCheck(button, pa, image, r);
		}
		else if (IsOnMenu(button, pa))
		{
			base.PaintButtonCheck(button, pa, image, r);
		}
		else
		{
			PaintState(button, pa, image, r, button.IsMouseDown);
		}
	}

	protected virtual void PaintState(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle r, bool isMouseDown)
	{
		if (r.IsEmpty)
		{
			return;
		}
		bool isOnMenu = pa.IsOnMenu;
		_ = Office2007ColorTable_0;
		Graphics graphics = pa.Graphics;
		IShapeDescriptor shapeDescriptor = smethod_7(button);
		if (pa.ContainerControl is ButtonX)
		{
			shapeDescriptor = ((ButtonX)(object)pa.ContainerControl).method_11();
		}
		else if (pa.ContainerControl is NavigationBar)
		{
			shapeDescriptor = ((NavigationBar)(object)pa.ContainerControl).IShapeDescriptor_0;
		}
		Enum16 buttonCont = method_2(pa, button);
		Office2007ButtonItemColorTable colorTable = GetColorTable(button, buttonCont);
		Region clip = graphics.get_Clip();
		graphics.SetClip(r, (CombineMode)1);
		Office2007ButtonItemStateColorTable office2007ButtonItemStateColorTable_ = colorTable.Default;
		if (IsOnMenu(button, pa))
		{
			Rectangle sideRect = new Rectangle(button.DisplayRectangle.Left, button.DisplayRectangle.Top, button.Rectangle_0.Right, button.DisplayRectangle.Height);
			if (pa.RightToLeft)
			{
				sideRect = new Rectangle(button.DisplayRectangle.Right - button.Rectangle_0.Width, button.DisplayRectangle.Top, button.Rectangle_0.Width, button.DisplayRectangle.Height);
			}
			PaintMenuItemSide(button, pa, sideRect);
		}
		if (!Class265.smethod_1(button, pa))
		{
			if (!isOnMenu)
			{
				smethod_5(graphics, colorTable.Disabled, r, shapeDescriptor, pa.bool_1);
			}
			graphics.set_Clip(clip);
			return;
		}
		bool flag = false;
		bool flag2 = false;
		if (!button.DesignMode)
		{
			if (button.IsMouseOver && button.HotTrackingStyle != eHotTrackingStyle.Image && button.HotTrackingStyle != eHotTrackingStyle.None)
			{
				office2007ButtonItemStateColorTable_ = colorTable.MouseOver;
				flag = true;
			}
			if (isMouseDown && button.HotTrackingStyle != eHotTrackingStyle.Image && button.HotTrackingStyle != eHotTrackingStyle.None)
			{
				if (colorTable.Pressed != null)
				{
					office2007ButtonItemStateColorTable_ = colorTable.Pressed;
				}
			}
			else if (button.Checked && !button.IsMouseOver && !IsOnMenu(button, pa))
			{
				office2007ButtonItemStateColorTable_ = colorTable.Checked;
			}
			else if (button.Expanded && button.HotTrackingStyle != eHotTrackingStyle.Image && (flag || !pa.IsOnMenu))
			{
				office2007ButtonItemStateColorTable_ = colorTable.Expanded;
				flag2 = true;
			}
		}
		else if (button.Checked && !IsOnMenu(button, pa))
		{
			office2007ButtonItemStateColorTable_ = colorTable.Checked;
		}
		else if (button.Expanded && button.HotTrackingStyle != eHotTrackingStyle.Image)
		{
			office2007ButtonItemStateColorTable_ = colorTable.Expanded;
			flag2 = true;
		}
		smethod_6(graphics, office2007ButtonItemStateColorTable_, r, shapeDescriptor, pa.bool_1, !pa.IsOnNavigationBar);
		Rectangle totalSubItemsRect = GetTotalSubItemsRect(button);
		if ((flag || flag2) && !button.AutoExpandOnClick && !totalSubItemsRect.IsEmpty && !IsOnMenu(button, pa))
		{
			Brush val = method_1();
			try
			{
				Rectangle displayRectangle = button.DisplayRectangle;
				displayRectangle.Inflate(-1, -1);
				totalSubItemsRect.Offset(button.DisplayRectangle.Location);
				if (!button.IsMouseOverExpand && !flag2)
				{
					totalSubItemsRect.Inflate(-1, -1);
					graphics.SetClip(totalSubItemsRect, (CombineMode)1);
					GraphicsPath shape = shapeDescriptor.GetShape(displayRectangle);
					if (shape != null)
					{
						graphics.FillPath(val, shape);
						shape.Dispose();
					}
				}
				else if (!flag || button.IsMouseOverExpand)
				{
					graphics.SetClip(totalSubItemsRect, (CombineMode)4);
					GraphicsPath shape2 = shapeDescriptor.GetShape(displayRectangle);
					if (shape2 != null)
					{
						graphics.FillPath(val, shape2);
						shape2.Dispose();
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		graphics.set_Clip(clip);
	}

	public static void smethod_4(Graphics graphics_0, Office2007ButtonItemStateColorTable office2007ButtonItemStateColorTable_0, Rectangle rectangle_0, IShapeDescriptor ishapeDescriptor_0)
	{
		smethod_5(graphics_0, office2007ButtonItemStateColorTable_0, rectangle_0, ishapeDescriptor_0, bool_0: false);
	}

	public static void smethod_5(Graphics graphics_0, Office2007ButtonItemStateColorTable office2007ButtonItemStateColorTable_0, Rectangle rectangle_0, IShapeDescriptor ishapeDescriptor_0, bool bool_0)
	{
		smethod_6(graphics_0, office2007ButtonItemStateColorTable_0, rectangle_0, ishapeDescriptor_0, bool_0, bool_1: true);
	}

	public static void smethod_6(Graphics graphics_0, Office2007ButtonItemStateColorTable office2007ButtonItemStateColorTable_0, Rectangle rectangle_0, IShapeDescriptor ishapeDescriptor_0, bool bool_0, bool bool_1)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		float num = 0.35f;
		float num2 = 0.65f;
		if (!ishapeDescriptor_0.CanDrawShape(rectangle_0) || office2007ButtonItemStateColorTable_0 == null)
		{
			return;
		}
		Rectangle rectangle = rectangle_0;
		Rectangle rectangle2 = new Rectangle(rectangle.X, rectangle.Y, rectangle.Width, (int)((float)rectangle.Height * num));
		if (!office2007ButtonItemStateColorTable_0.OuterBorder.IsEmpty && bool_1)
		{
			rectangle.Width--;
		}
		GraphicsPath shape = ishapeDescriptor_0.GetShape(rectangle);
		if (office2007ButtonItemStateColorTable_0.Background != null)
		{
			if (shape != null)
			{
				LinearGradientBrush val = new LinearGradientBrush(rectangle, office2007ButtonItemStateColorTable_0.Background.Start, office2007ButtonItemStateColorTable_0.Background.End, (float)office2007ButtonItemStateColorTable_0.Background.GradientAngle);
				try
				{
					graphics_0.FillPath((Brush)(object)val, shape);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
				shape.Dispose();
			}
		}
		else
		{
			if (shape != null)
			{
				LinearGradientBrush val2 = new LinearGradientBrush(rectangle, office2007ButtonItemStateColorTable_0.TopBackground.Start, office2007ButtonItemStateColorTable_0.BottomBackground.End, (float)office2007ButtonItemStateColorTable_0.TopBackground.GradientAngle);
				try
				{
					ColorBlend val3 = new ColorBlend(4);
					val3.set_Colors(new Color[4]
					{
						office2007ButtonItemStateColorTable_0.TopBackground.Start,
						office2007ButtonItemStateColorTable_0.TopBackground.End,
						office2007ButtonItemStateColorTable_0.BottomBackground.Start,
						office2007ButtonItemStateColorTable_0.BottomBackground.End
					});
					val3.set_Positions(new float[4] { 0f, num, num, 1f });
					val2.set_InterpolationColors(val3);
					graphics_0.FillPath((Brush)(object)val2, shape);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				shape.Dispose();
			}
			if (!office2007ButtonItemStateColorTable_0.TopBackgroundHighlight.IsEmpty)
			{
				Rectangle rectangle3 = new Rectangle(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
				GraphicsPath val4 = new GraphicsPath();
				val4.AddEllipse(rectangle3);
				PathGradientBrush val5 = new PathGradientBrush(val4);
				val5.set_CenterColor(office2007ButtonItemStateColorTable_0.TopBackgroundHighlight.Start);
				val5.set_SurroundColors(new Color[1] { office2007ButtonItemStateColorTable_0.TopBackgroundHighlight.End });
				val5.set_CenterPoint(new PointF(rectangle3.X + rectangle3.Width / 2, rectangle.Bottom));
				Blend val6 = new Blend();
				val6.set_Factors(new float[3] { 0f, 0.5f, 1f });
				val6.set_Positions(new float[3] { 0f, 0.4f, 1f });
				val5.set_Blend(val6);
				graphics_0.FillRectangle((Brush)(object)val5, rectangle2);
				((Brush)val5).Dispose();
				val4.Dispose();
			}
			int num3 = (int)((float)rectangle.Height * num2);
			rectangle2 = new Rectangle(rectangle.X, rectangle.Y + rectangle2.Height, rectangle.Width, rectangle.Height - rectangle2.Height);
			if (!office2007ButtonItemStateColorTable_0.BottomBackgroundHighlight.IsEmpty)
			{
				Rectangle rectangle4 = new Rectangle(rectangle.X, rectangle.Y + num3 - 2, rectangle.Width, rectangle.Height + 4);
				GraphicsPath val7 = new GraphicsPath();
				val7.AddEllipse(rectangle4);
				PathGradientBrush val8 = new PathGradientBrush(val7);
				val8.set_CenterColor(office2007ButtonItemStateColorTable_0.BottomBackgroundHighlight.Start);
				val8.set_SurroundColors(new Color[1] { office2007ButtonItemStateColorTable_0.BottomBackgroundHighlight.End });
				val8.set_CenterPoint(new PointF(rectangle4.X + rectangle4.Width / 2, rectangle.Bottom));
				Blend val9 = new Blend();
				val9.set_Factors(new float[3] { 0f, 0.5f, 0.6f });
				val9.set_Positions(new float[3] { 0f, 0.4f, 1f });
				val8.set_Blend(val9);
				graphics_0.FillRectangle((Brush)(object)val8, rectangle2);
				((Brush)val8).Dispose();
				val7.Dispose();
			}
		}
		if (!bool_1)
		{
			return;
		}
		SmoothingMode smoothingMode = graphics_0.get_SmoothingMode();
		graphics_0.set_SmoothingMode((SmoothingMode)4);
		if (!office2007ButtonItemStateColorTable_0.OuterBorder.IsEmpty)
		{
			Rectangle bounds = rectangle_0;
			bounds.Width--;
			bounds.Height--;
			GraphicsPath shape2 = ishapeDescriptor_0.GetShape(bounds);
			if (shape2 != null)
			{
				Class50.smethod_35(graphics_0, shape2, rectangle_0, office2007ButtonItemStateColorTable_0.OuterBorder, 1);
				shape2.Dispose();
			}
			if (bool_0)
			{
				Color color_ = Color.FromArgb(128, office2007ButtonItemStateColorTable_0.OuterBorder.Start);
				rectangle_0.Inflate(-1, -1);
				Class50.smethod_6(graphics_0, color_, rectangle_0);
				rectangle_0.Inflate(-1, -1);
				Class50.smethod_6(graphics_0, color_, rectangle_0);
			}
		}
		if (!bool_0 && !office2007ButtonItemStateColorTable_0.InnerBorder.IsEmpty)
		{
			Rectangle rectangle5 = rectangle_0;
			rectangle5.Inflate(-1, -1);
			rectangle5.Width--;
			rectangle5.Height--;
			GraphicsPath innerShape = ishapeDescriptor_0.GetInnerShape(rectangle5, 1);
			try
			{
				Class50.smethod_35(graphics_0, innerShape, rectangle5, office2007ButtonItemStateColorTable_0.InnerBorder, 1);
			}
			finally
			{
				((IDisposable)innerShape)?.Dispose();
			}
		}
		graphics_0.set_SmoothingMode(smoothingMode);
	}

	public override void PaintButtonBackground(ButtonItem button, ItemPaintArgs pa, Class271 image)
	{
		if (method_0(button, pa))
		{
			base.PaintButtonBackground(button, pa, image);
			return;
		}
		if (button is Office2007StartButton && office2007ColorTable_0.RibbonControl.StartButtonDefault != null)
		{
			Image val = office2007ColorTable_0.RibbonControl.StartButtonDefault;
			if (!button.IsMouseDown && !button.Expanded)
			{
				if (button.IsMouseOver)
				{
					val = office2007ColorTable_0.RibbonControl.StartButtonMouseOver;
				}
			}
			else
			{
				val = office2007ColorTable_0.RibbonControl.StartButtonPressed;
			}
			if (val != null)
			{
				if (Office2007ColorTable.CloneImagesOnAccess)
				{
					object obj = val.Clone();
					val = (Image)((obj is Image) ? obj : null);
				}
				pa.Graphics.DrawImageUnscaled(val, new Point(button.LeftInternal + (button.WidthInternal - val.get_Width()) / 2, button.TopInternal + (button.HeightInternal - val.get_Height()) / 2));
				if (Office2007ColorTable.CloneImagesOnAccess)
				{
					val.Dispose();
				}
			}
		}
		PaintState(button, pa, image, button.DisplayRectangle, button.IsMouseDown);
	}

	private Brush method_1()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return (Brush)new SolidBrush(Color.FromArgb(76, Color.White));
	}

	private static IShapeDescriptor smethod_7(ButtonItem buttonItem_0)
	{
		if (buttonItem_0.Shape != null)
		{
			return buttonItem_0.Shape;
		}
		return roundRectangleShapeDescriptor_0;
	}

	public override void PaintExpandButton(ButtonItem button, ItemPaintArgs pa)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0990: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected O, but got Unknown
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Expected O, but got Unknown
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c50: Expected O, but got Unknown
		if (method_0(button, pa))
		{
			base.PaintExpandButton(button, pa);
			return;
		}
		Graphics graphics = pa.Graphics;
		bool flag = IsOnMenu(button, pa);
		Rectangle displayRectangle = button.DisplayRectangle;
		bool isMouseOver = button.IsMouseOver;
		bool flag2 = Class265.smethod_1(button, pa);
		Color color = Color.Empty;
		Enum16 @enum = method_2(pa, button);
		Office2007ButtonItemColorTable colorTable = GetColorTable(button, @enum);
		if (@enum == Enum16.const_3)
		{
			color = GetTextColor(button, pa);
		}
		if (color.IsEmpty)
		{
			color = GetTextColor(button, pa, colorTable);
		}
		SolidBrush val = new SolidBrush(color);
		try
		{
			if ((button.SubItems.Count <= 0 && button.PopupType != ePopupType.Container) || !button.ShowSubItems)
			{
				return;
			}
			if (flag)
			{
				Point[] array = new Point[3];
				if (pa.RightToLeft)
				{
					array[0].X = displayRectangle.Left + 8;
					array[0].Y = displayRectangle.Top + (displayRectangle.Height - 8) / 2;
					array[1].X = array[0].X;
					array[1].Y = array[0].Y + 8;
					array[2].X = array[0].X - 4;
					array[2].Y = array[0].Y + 4;
				}
				else
				{
					array[0].X = displayRectangle.Left + displayRectangle.Width - 12;
					array[0].Y = displayRectangle.Top + (displayRectangle.Height - 8) / 2;
					array[1].X = array[0].X;
					array[1].Y = array[0].Y + 8;
					array[2].X = array[0].X + 4;
					array[2].Y = array[0].Y + 4;
				}
				SmoothingMode smoothingMode = graphics.get_SmoothingMode();
				graphics.set_SmoothingMode((SmoothingMode)3);
				graphics.FillPolygon((Brush)(object)val, array);
				graphics.set_SmoothingMode(smoothingMode);
			}
			else if (!button.Rectangle_1.IsEmpty)
			{
				Point[] array2 = new Point[3];
				Rectangle rectangle_ = button.Rectangle_1;
				if (pa.IsOnRibbonBar && button.ImagePosition == eImagePosition.Top && !button.SplitButton && button.Text.Length > 0)
				{
					rectangle_.Y -= 3;
				}
				if (button.PopupSide == ePopupSide.Default)
				{
					if (pa.IsOnMenu)
					{
						if (pa.RightToLeft)
						{
							array2[0].X = displayRectangle.Left + rectangle_.Left + rectangle_.Width / 2 + 3;
							array2[0].Y = displayRectangle.Top + rectangle_.Top + rectangle_.Height / 2 - 3;
							array2[1].X = array2[0].X;
							array2[1].Y = array2[0].Y + 6;
							array2[2].X = array2[0].X - 3;
							array2[2].Y = array2[0].Y + 3;
						}
						else
						{
							array2[0].X = displayRectangle.Left + rectangle_.Left + rectangle_.Width / 2;
							array2[0].Y = displayRectangle.Top + rectangle_.Top + rectangle_.Height / 2 - 3;
							array2[1].X = array2[0].X;
							array2[1].Y = array2[0].Y + 6;
							array2[2].X = array2[0].X + 3;
							array2[2].Y = array2[0].Y + 3;
						}
					}
					else if (button.Orientation == eOrientation.Horizontal)
					{
						array2[0].X = displayRectangle.Left + rectangle_.Left + (rectangle_.Width - 5) / 2;
						array2[0].Y = displayRectangle.Top + rectangle_.Top + (rectangle_.Height - 3) / 2 + 1;
						array2[1].X = array2[0].X + 5;
						array2[1].Y = array2[0].Y;
						array2[2].X = array2[0].X + 2;
						array2[2].Y = array2[0].Y + 3;
					}
					else
					{
						array2[0].X = displayRectangle.Left + rectangle_.Left + (rectangle_.Width - 3) / 2 + 1;
						array2[0].Y = displayRectangle.Top + rectangle_.Top + (rectangle_.Height - 5) / 2;
						array2[1].X = array2[0].X;
						array2[1].Y = array2[0].Y + 6;
						array2[2].X = array2[0].X - 3;
						array2[2].Y = array2[0].Y + 3;
					}
				}
				else
				{
					switch (button.PopupSide)
					{
					case ePopupSide.Left:
						array2[0].X = displayRectangle.Left + rectangle_.Left + rectangle_.Width / 2 + 3;
						array2[0].Y = displayRectangle.Top + rectangle_.Top + rectangle_.Height / 2 - 3;
						array2[1].X = array2[0].X;
						array2[1].Y = array2[0].Y + 6;
						array2[2].X = array2[0].X - 3;
						array2[2].Y = array2[0].Y + 3;
						break;
					case ePopupSide.Right:
						array2[0].X = displayRectangle.Left + rectangle_.Left + rectangle_.Width / 2;
						array2[0].Y = displayRectangle.Top + rectangle_.Top + rectangle_.Height / 2 - 3;
						array2[1].X = array2[0].X;
						array2[1].Y = array2[0].Y + 6;
						array2[2].X = array2[0].X + 3;
						array2[2].Y = array2[0].Y + 3;
						break;
					case ePopupSide.Top:
						array2[0].X = displayRectangle.Left + rectangle_.Left + (rectangle_.Width - 5) / 2;
						array2[0].Y = displayRectangle.Top + rectangle_.Top + (rectangle_.Height - 3) / 2 + 4;
						array2[1].X = array2[0].X + 6;
						array2[1].Y = array2[0].Y;
						array2[2].X = array2[0].X + 3;
						array2[2].Y = array2[0].Y - 4;
						break;
					case ePopupSide.Bottom:
						array2[0].X = displayRectangle.Left + rectangle_.Left + (rectangle_.Width - 5) / 2 + 1;
						array2[0].Y = displayRectangle.Top + rectangle_.Top + (rectangle_.Height - 3) / 2 + 1;
						array2[1].X = array2[0].X + 5;
						array2[1].Y = array2[0].Y;
						array2[2].X = array2[0].X + 2;
						array2[2].Y = array2[0].Y + 3;
						break;
					}
				}
				if (button.SplitButton && !button.Rectangle_2.IsEmpty && button.ImagePosition == eImagePosition.Top)
				{
					array2[0].Y -= 3;
					array2[1].Y -= 3;
					array2[2].Y -= 3;
				}
				if (flag2)
				{
					SmoothingMode smoothingMode2 = graphics.get_SmoothingMode();
					graphics.set_SmoothingMode((SmoothingMode)3);
					graphics.FillPolygon((Brush)(object)val, array2);
					graphics.set_SmoothingMode(smoothingMode2);
				}
				else
				{
					SmoothingMode smoothingMode3 = graphics.get_SmoothingMode();
					graphics.set_SmoothingMode((SmoothingMode)3);
					SolidBrush val2 = new SolidBrush(pa.Colors.ItemDisabledText);
					try
					{
						graphics.FillPolygon((Brush)(object)val2, array2);
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
					graphics.set_SmoothingMode(smoothingMode3);
				}
			}
			Rectangle totalSubItemsRect = GetTotalSubItemsRect(button);
			if (!flag2 || totalSubItemsRect.IsEmpty || (!isMouseOver && (!button.Expanded || pa.IsOnMenu)) || button.AutoExpandOnClick)
			{
				return;
			}
			totalSubItemsRect.Offset(displayRectangle.Location);
			Point[] array3 = new Point[4];
			if (pa.ContainerControl is RibbonBar && (button.ImagePosition == eImagePosition.Top || button.ImagePosition == eImagePosition.Bottom))
			{
				ref Point reference = ref array3[0];
				reference = new Point(totalSubItemsRect.X + 1, totalSubItemsRect.Y);
				ref Point reference2 = ref array3[1];
				reference2 = new Point(totalSubItemsRect.Right - 2, totalSubItemsRect.Y);
				ref Point reference3 = ref array3[2];
				reference3 = new Point(totalSubItemsRect.X + 1, totalSubItemsRect.Y + 1);
				ref Point reference4 = ref array3[3];
				reference4 = new Point(totalSubItemsRect.Right - 2, totalSubItemsRect.Y + 1);
				if (button.SplitButton)
				{
					array3[0].Y++;
					array3[1].Y++;
					array3[2].Y++;
					array3[3].Y++;
				}
			}
			else
			{
				totalSubItemsRect.Y++;
				totalSubItemsRect.Height -= 3;
				if (pa.RightToLeft)
				{
					totalSubItemsRect.X = totalSubItemsRect.Right - 1;
				}
				ref Point reference5 = ref array3[0];
				reference5 = new Point(totalSubItemsRect.X, totalSubItemsRect.Y);
				ref Point reference6 = ref array3[1];
				reference6 = new Point(totalSubItemsRect.X, totalSubItemsRect.Bottom);
				ref Point reference7 = ref array3[2];
				reference7 = new Point(totalSubItemsRect.X + 1, totalSubItemsRect.Y);
				ref Point reference8 = ref array3[3];
				reference8 = new Point(totalSubItemsRect.X + 1, totalSubItemsRect.Bottom);
			}
			Pen val3 = new Pen(colorTable.MouseOver.SplitBorder.Start);
			try
			{
				graphics.DrawLine(val3, array3[0], array3[1]);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			Pen val4 = new Pen(colorTable.MouseOver.SplitBorderLight.Start);
			try
			{
				graphics.DrawLine(val4, array3[2], array3[3]);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected override void PaintMenuItemSide(ButtonItem button, ItemPaintArgs pa, Rectangle sideRect)
	{
		if (method_0(button, pa))
		{
			base.PaintMenuItemSide(button, pa, sideRect);
			return;
		}
		Graphics graphics = pa.Graphics;
		Office2007MenuColorTable menu = office2007ColorTable_0.Menu;
		Region val = graphics.get_Clip().Clone();
		graphics.SetClip(sideRect);
		sideRect.Inflate(0, 1);
		if (button.MenuVisibility == eMenuVisibility.VisibleIfRecentlyUsed && !button.RecentlyUsed)
		{
			Class50.smethod_25(graphics, sideRect, menu.SideUnused);
		}
		else
		{
			Class50.smethod_25(graphics, sideRect, menu.Side);
		}
		if (pa.RightToLeft)
		{
			Point point_ = new Point(sideRect.X, sideRect.Y);
			Class50.smethod_41(graphics, point_, new Point(point_.X, point_.Y + sideRect.Height), menu.SideBorder, 1);
			point_.X++;
			Class50.smethod_41(graphics, point_, new Point(point_.X, point_.Y + sideRect.Height), menu.SideBorderLight, 1);
		}
		else
		{
			Point point_2 = new Point(sideRect.Right - 2, sideRect.Y);
			Class50.smethod_41(graphics, point_2, new Point(point_2.X, point_2.Y + sideRect.Height), menu.SideBorder, 1);
			point_2.X++;
			Class50.smethod_41(graphics, point_2, new Point(point_2.X, point_2.Y + sideRect.Height), menu.SideBorderLight, 1);
		}
		if (val != null)
		{
			graphics.set_Clip(val);
		}
		else
		{
			graphics.ResetClip();
		}
	}

	protected override void PaintButtonCheckBackground(ButtonItem button, ItemPaintArgs pa, Rectangle r)
	{
		if (method_0(button, pa))
		{
			base.PaintButtonCheckBackground(button, pa, r);
			return;
		}
		Graphics graphics = pa.Graphics;
		bool flag = IsOnMenu(button, pa);
		int int32_ = int_0;
		if (pa.ContainerControl is ButtonX)
		{
			int32_ = ((ButtonX)(object)pa.ContainerControl).Int32_0;
		}
		if (!button.IsMouseOver || flag)
		{
			Rectangle rectangle_ = r;
			rectangle_.Inflate(-1, -1);
			Class50.smethod_26(graphics, rectangle_, pa.Colors.ItemCheckedBackground, pa.Colors.ItemCheckedBackground2, pa.Colors.ItemCheckedBackgroundGradientAngle);
			Class50.smethod_9(graphics, pa.Colors.ItemCheckedBorder, r, int32_);
		}
	}

	protected virtual Office2007ButtonItemColorTable GetColorTable(ButtonItem button, Enum16 buttonCont)
	{
		Office2007ColorTable office2007ColorTable = Office2007ColorTable_0;
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = null;
		if (buttonCont == Enum16.const_1 && office2007ColorTable.RibbonButtonItemColors.Count > 0)
		{
			if (button.CustomColorName != "")
			{
				office2007ButtonItemColorTable = office2007ColorTable.RibbonButtonItemColors[button.CustomColorName];
			}
			if (office2007ButtonItemColorTable == null)
			{
				office2007ButtonItemColorTable = office2007ColorTable.RibbonButtonItemColors[button.vmethod_1()];
			}
			if (office2007ButtonItemColorTable != null)
			{
				return office2007ButtonItemColorTable;
			}
		}
		else if ((buttonCont == Enum16.const_4 || buttonCont == Enum16.const_5) && office2007ColorTable.MenuButtonItemColors.Count > 0)
		{
			if (button.CustomColorName != "")
			{
				office2007ButtonItemColorTable = office2007ColorTable.MenuButtonItemColors[button.CustomColorName];
			}
			if (office2007ButtonItemColorTable == null)
			{
				office2007ButtonItemColorTable = office2007ColorTable.MenuButtonItemColors[button.vmethod_1()];
			}
			if (office2007ButtonItemColorTable != null)
			{
				return office2007ButtonItemColorTable;
			}
		}
		if (button.CustomColorName != "")
		{
			office2007ButtonItemColorTable = office2007ColorTable.ButtonItemColors[button.CustomColorName];
		}
		if (office2007ButtonItemColorTable == null)
		{
			office2007ButtonItemColorTable = office2007ColorTable.ButtonItemColors[button.vmethod_1()];
		}
		if (office2007ButtonItemColorTable == null)
		{
			return office2007ColorTable.ButtonItemColors[0];
		}
		return office2007ButtonItemColorTable;
	}

	private Enum16 method_2(ItemPaintArgs itemPaintArgs_0, ButtonItem buttonItem_0)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		Enum16 result = Enum16.const_0;
		if (itemPaintArgs_0.ContainerControl is RibbonBar)
		{
			result = Enum16.const_1;
		}
		else if (itemPaintArgs_0.ContainerControl is RibbonStrip)
		{
			result = Enum16.const_3;
		}
		else if (itemPaintArgs_0.ContainerControl is Bar)
		{
			Bar bar = itemPaintArgs_0.ContainerControl as Bar;
			if (bar.MenuBar)
			{
				result = Enum16.const_4;
			}
			else if (bar.LayoutType == eLayoutType.Toolbar)
			{
				result = ((bar.BarType == eBarType.StatusBar || bar.GrabHandleStyle == eGrabHandleStyle.ResizeHandle || (int)((Control)bar).get_Dock() == 2 || bar.DockSide == eDockSide.Bottom) ? Enum16.const_5 : Enum16.const_6);
			}
		}
		else if (itemPaintArgs_0.IsOnMenu || itemPaintArgs_0.IsOnPopupBar)
		{
			result = Enum16.const_2;
		}
		return result;
	}

	protected virtual Color GetTextColor(ButtonItem button, ItemPaintArgs pa, Office2007ButtonItemColorTable buttonColorTable)
	{
		Color result = Color.Empty;
		if (button.IsMouseOver)
		{
			if (!button.HotForeColor.IsEmpty)
			{
				result = button.HotForeColor;
			}
		}
		else if (!button.ForeColor.IsEmpty)
		{
			result = button.ForeColor;
		}
		if (result.IsEmpty && buttonColorTable != null)
		{
			if (button.method_1(pa.ContainerControl))
			{
				result = (button.IsMouseDown ? buttonColorTable.Pressed.Text : (button.IsMouseOver ? buttonColorTable.MouseOver.Text : (button.Expanded ? buttonColorTable.Expanded.Text : ((!button.Checked) ? buttonColorTable.Default.Text : buttonColorTable.Checked.Text))));
			}
			else if (buttonColorTable.Disabled != null)
			{
				result = buttonColorTable.Disabled.Text;
			}
		}
		if (result.IsEmpty)
		{
			return base.GetTextColor(button, pa);
		}
		return result;
	}

	protected override Color GetTextColor(ButtonItem button, ItemPaintArgs pa)
	{
		bool flag;
		if ((flag = Class265.smethod_1(button, pa)) && !button.ForeColor.IsEmpty)
		{
			return button.ForeColor;
		}
		Enum16 @enum = method_2(pa, button);
		if (flag && !method_0(button, pa))
		{
			Color empty = Color.Empty;
			if (@enum == Enum16.const_3 && !button.IsMouseOver && !button.IsMouseDown && !button.Expanded)
			{
				Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = Class269.smethod_9(office2007ColorTable_0);
				return office2007RibbonTabItemColorTable.Default.Text;
			}
			Office2007ButtonItemColorTable colorTable = GetColorTable(button, @enum);
			return GetTextColor(button, pa, colorTable);
		}
		if (flag && @enum == Enum16.const_4 && !button.IsMouseDown && !button.IsMouseOver && !button.Expanded && !button.Checked)
		{
			Office2007ButtonItemColorTable colorTable2 = GetColorTable(button, @enum);
			return colorTable2.Default.Text;
		}
		return base.GetTextColor(button, pa);
	}
}
