using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace DevComponents.UI.ContentManager;

public class SerialContentLayoutManager : IContentLayout
{
	private class Class279
	{
		public ArrayList arrayList_0 = new ArrayList();

		public Size size_0 = Size.Empty;

		public int int_0;

		public int int_1;
	}

	private struct Struct21
	{
		public int int_0;

		public int int_1;

		public float float_0;

		public float float_1;

		public bool bool_0;
	}

	private LayoutManagerPositionEventHandler layoutManagerPositionEventHandler_0;

	private LayoutManagerLayoutEventHandler layoutManagerLayoutEventHandler_0;

	private int int_0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private eContentOrientation eContentOrientation_0;

	private eContentAlignment eContentAlignment_0;

	private eContentVerticalAlignment eContentVerticalAlignment_0 = eContentVerticalAlignment.Middle;

	private eContentVerticalAlignment eContentVerticalAlignment_1 = eContentVerticalAlignment.Middle;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	private bool bool_7;

	public virtual int BlockSpacing
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

	public virtual bool FitContainerOversize
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public virtual bool FitContainer
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public virtual bool VerticalFitContainerWidth
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	public virtual bool HorizontalFitContainerHeight
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}

	public virtual eContentOrientation ContentOrientation
	{
		get
		{
			return eContentOrientation_0;
		}
		set
		{
			eContentOrientation_0 = value;
		}
	}

	public virtual eContentVerticalAlignment ContentVerticalAlignment
	{
		get
		{
			return eContentVerticalAlignment_0;
		}
		set
		{
			eContentVerticalAlignment_0 = value;
		}
	}

	public virtual eContentVerticalAlignment BlockLineAlignment
	{
		get
		{
			return eContentVerticalAlignment_1;
		}
		set
		{
			eContentVerticalAlignment_1 = value;
		}
	}

	public virtual eContentAlignment ContentAlignment
	{
		get
		{
			return eContentAlignment_0;
		}
		set
		{
			eContentAlignment_0 = value;
		}
	}

	public virtual bool EvenHeight
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool_4 = value;
		}
	}

	public virtual bool OversizeDistribute
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
		}
	}

	public bool MultiLine
	{
		get
		{
			return bool_5;
		}
		set
		{
			bool_5 = value;
		}
	}

	public bool RightToLeft
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
		}
	}

	public event LayoutManagerPositionEventHandler NextPosition
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			layoutManagerPositionEventHandler_0 = (LayoutManagerPositionEventHandler)Delegate.Combine(layoutManagerPositionEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			layoutManagerPositionEventHandler_0 = (LayoutManagerPositionEventHandler)Delegate.Remove(layoutManagerPositionEventHandler_0, value);
		}
	}

	public event LayoutManagerLayoutEventHandler BeforeNewBlockLayout
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			layoutManagerLayoutEventHandler_0 = (LayoutManagerLayoutEventHandler)Delegate.Combine(layoutManagerLayoutEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			layoutManagerLayoutEventHandler_0 = (LayoutManagerLayoutEventHandler)Delegate.Remove(layoutManagerLayoutEventHandler_0, value);
		}
	}

	public virtual Rectangle Layout(Rectangle containerBounds, IBlock[] contentBlocks, BlockLayoutManager blockLayout)
	{
		Rectangle rectangle = Rectangle.Empty;
		Point point = containerBounds.Location;
		ArrayList arrayList = new ArrayList();
		arrayList.Add(new Class279());
		Class279 @class = arrayList[0] as Class279;
		bool flag = false;
		bool flag2 = true;
		int num = 0;
		foreach (IBlock block in contentBlocks)
		{
			if (!block.Visible)
			{
				block.Bounds = Rectangle.Empty;
				continue;
			}
			if (layoutManagerLayoutEventHandler_0 != null)
			{
				LayoutManagerLayoutEventArgs layoutManagerLayoutEventArgs = new LayoutManagerLayoutEventArgs(block, point, num);
				layoutManagerLayoutEventHandler_0(this, layoutManagerLayoutEventArgs);
				point = layoutManagerLayoutEventArgs.CurrentPosition;
				if (layoutManagerLayoutEventArgs.CancelLayout)
				{
					continue;
				}
			}
			num++;
			Size size = containerBounds.Size;
			bool flag3 = false;
			bool flag4 = false;
			if (block is IBlockExtended)
			{
				IBlockExtended blockExtended = block as IBlockExtended;
				flag3 = blockExtended.IsBlockElement;
				flag4 = blockExtended.IsNewLineAfterElement;
				flag2 = blockExtended.CanStartNewLine;
			}
			else
			{
				flag2 = true;
			}
			if (!flag3)
			{
				if (eContentOrientation_0 == eContentOrientation.Horizontal)
				{
					size.Width = containerBounds.Right - point.X;
				}
				else
				{
					size.Height = containerBounds.Bottom - point.Y;
				}
			}
			blockLayout.Layout(block, size);
			if (bool_5 && @class.arrayList_0.Count > 0)
			{
				if ((eContentOrientation_0 != 0 || point.X + block.Bounds.Width <= containerBounds.Right || !flag2) && !flag3 && !flag)
				{
					if ((eContentOrientation_0 == eContentOrientation.Vertical && point.Y + block.Bounds.Height > containerBounds.Bottom && flag2) || flag3 || flag)
					{
						point.Y = containerBounds.Y;
						point.X += @class.size_0.Width + int_0;
						@class = new Class279();
						@class.int_0 = arrayList.Count;
						arrayList.Add(@class);
					}
				}
				else
				{
					point.X = containerBounds.X;
					point.Y += @class.size_0.Height + int_0;
					@class = new Class279();
					@class.int_0 = arrayList.Count;
					arrayList.Add(@class);
				}
			}
			if (eContentOrientation_0 == eContentOrientation.Horizontal)
			{
				if (block.Bounds.Height > @class.size_0.Height)
				{
					@class.size_0.Height = block.Bounds.Height;
				}
				@class.size_0.Width = point.X + block.Bounds.Width - containerBounds.X;
			}
			else if (eContentOrientation_0 == eContentOrientation.Vertical)
			{
				if (block.Bounds.Width > @class.size_0.Width)
				{
					@class.size_0.Width = block.Bounds.Width;
				}
				@class.size_0.Height = point.Y + block.Bounds.Height - containerBounds.Y;
			}
			@class.arrayList_0.Add(block);
			if (block.Visible)
			{
				@class.int_1++;
			}
			block.Bounds = new Rectangle(point, block.Bounds.Size);
			rectangle = ((!rectangle.IsEmpty) ? Rectangle.Union(rectangle, block.Bounds) : block.Bounds);
			flag = flag3 || flag4;
			point = method_1(block, point);
		}
		rectangle = method_0(containerBounds, rectangle, arrayList);
		if (bool_6)
		{
			rectangle = method_2(containerBounds, rectangle, contentBlocks);
		}
		return rectangle;
	}

	private Rectangle method_0(Rectangle rectangle_0, Rectangle rectangle_1, ArrayList arrayList_0)
	{
		Rectangle rectangle = Rectangle.Empty;
		if (!rectangle_0.IsEmpty && !rectangle_1.IsEmpty && ((Class279)arrayList_0[0]).arrayList_0.Count != 0)
		{
			if (eContentAlignment_0 == eContentAlignment.Left && eContentVerticalAlignment_0 == eContentVerticalAlignment.Top && !bool_1 && !bool_0 && !bool_4 && eContentVerticalAlignment_1 == eContentVerticalAlignment.Top)
			{
				return rectangle_1;
			}
			Point[] array = new Point[arrayList_0.Count];
			Struct21[] array2 = new Struct21[arrayList_0.Count];
			foreach (Class279 item in arrayList_0)
			{
				if (eContentOrientation_0 == eContentOrientation.Horizontal)
				{
					if ((bool_1 && rectangle_0.Width > item.size_0.Width) || (bool_0 && item.size_0.Width > rectangle_0.Width))
					{
						if (bool_7 && (double)rectangle_0.Width < (double)item.size_0.Width * 0.75)
						{
							array2[item.int_0].int_0 = (int)Math.Floor((float)(rectangle_0.Width - item.int_1 * int_0) / (float)item.int_1);
							array2[item.int_0].bool_0 = true;
						}
						else
						{
							array2[item.int_0].int_0 = (rectangle_0.Width - item.int_1 * int_0 - item.size_0.Width) / item.int_1;
						}
						array2[item.int_0].float_0 = (float)(rectangle_0.Width - item.int_1 * int_0) / (float)item.size_0.Width;
						rectangle_1.Width = rectangle_0.Width;
					}
					if (bool_3 && rectangle_0.Height > rectangle_1.Height)
					{
						array2[item.int_0].int_1 = (rectangle_0.Height - item.size_0.Height) / arrayList_0.Count;
					}
				}
				else
				{
					if ((bool_1 && rectangle_0.Height > item.size_0.Height) || (bool_0 && item.size_0.Height > rectangle_0.Height))
					{
						if (bool_7 && (double)rectangle_0.Width < (double)item.size_0.Width * 0.75)
						{
							array2[item.int_0].int_1 = (int)Math.Floor((float)(rectangle_0.Height - item.int_1 * int_0) / (float)item.int_1);
							array2[item.int_0].bool_0 = true;
						}
						else
						{
							array2[item.int_0].int_1 = (rectangle_0.Height - item.int_1 * int_0 - item.size_0.Height) / item.int_1;
						}
						array2[item.int_0].float_1 = (float)(rectangle_0.Height - item.int_1 * int_0) / (float)item.size_0.Height;
						rectangle_1.Height = rectangle_0.Height;
					}
					if (bool_2 && rectangle_0.Width > rectangle_1.Width)
					{
						array2[item.int_0].int_0 = (rectangle_0.Width - item.size_0.Width) / arrayList_0.Count;
					}
				}
				if (eContentOrientation_0 == eContentOrientation.Horizontal && !bool_1 && ((rectangle_0.Width > rectangle_1.Width && bool_0) || !bool_0))
				{
					switch (eContentAlignment_0)
					{
					case eContentAlignment.Right:
						array[item.int_0].X = rectangle_0.Width - item.size_0.Width;
						break;
					case eContentAlignment.Center:
						array[item.int_0].X = (rectangle_0.Width - item.size_0.Width) / 2;
						break;
					}
				}
				if (eContentOrientation_0 == eContentOrientation.Vertical && !bool_1 && ((rectangle_0.Height > rectangle_1.Height && bool_0) || !bool_0))
				{
					switch (eContentVerticalAlignment_0)
					{
					case eContentVerticalAlignment.Bottom:
						array[item.int_0].Y = rectangle_0.Height - item.size_0.Height;
						break;
					case eContentVerticalAlignment.Middle:
						array[item.int_0].Y = (rectangle_0.Height - item.size_0.Height) / 2;
						break;
					}
				}
			}
			if (bool_2 && rectangle_0.Width > rectangle_1.Width && eContentOrientation_0 == eContentOrientation.Vertical)
			{
				rectangle_1.Width = rectangle_0.Width;
			}
			else if (bool_3 && rectangle_0.Height > rectangle_1.Height && eContentOrientation_0 == eContentOrientation.Horizontal)
			{
				rectangle_1.Height = rectangle_0.Height;
			}
			if (eContentOrientation_0 == eContentOrientation.Horizontal)
			{
				foreach (Class279 item2 in arrayList_0)
				{
					foreach (IBlock item3 in item2.arrayList_0)
					{
						if (item3.Visible)
						{
							Rectangle bounds = item3.Bounds;
							if (bool_4 && item2.size_0.Height > 0)
							{
								bounds.Height = item2.size_0.Height;
							}
							bounds.Offset(array[item2.int_0]);
							if (eContentVerticalAlignment_0 == eContentVerticalAlignment.Middle)
							{
								if (eContentVerticalAlignment_1 == eContentVerticalAlignment.Middle)
								{
									bounds.Offset(0, (rectangle_0.Height - rectangle_1.Height + (item2.size_0.Height - bounds.Height)) / 2);
								}
								else
								{
									bounds.Offset(0, (rectangle_0.Height - rectangle_1.Height) / 2);
								}
								if (eContentVerticalAlignment_1 == eContentVerticalAlignment.Bottom)
								{
									bounds.Offset(0, item2.size_0.Height - bounds.Height);
								}
							}
							else if (eContentVerticalAlignment_0 == eContentVerticalAlignment.Bottom)
							{
								bounds.Offset(0, rectangle_0.Height - rectangle_1.Height);
							}
							if (eContentVerticalAlignment_0 != eContentVerticalAlignment.Middle)
							{
								if (eContentVerticalAlignment_1 == eContentVerticalAlignment.Middle)
								{
									bounds.Offset(0, (item2.size_0.Height - bounds.Height) / 2);
								}
								else if (eContentVerticalAlignment_1 == eContentVerticalAlignment.Bottom)
								{
									bounds.Offset(0, item2.size_0.Height - bounds.Height);
								}
							}
							if (array2[item2.int_0].int_0 != 0)
							{
								if (bool_7)
								{
									int num = (array2[item2.int_0].bool_0 ? array2[item2.int_0].int_0 : ((int)Math.Floor((float)bounds.Width * array2[item2.int_0].float_0)));
									array[item2.int_0].X += num - bounds.Width;
									bounds.Width = num;
								}
								else
								{
									bounds.Width += array2[item2.int_0].int_0;
									array[item2.int_0].X += array2[item2.int_0].int_0;
								}
							}
							bounds.Height += array2[item2.int_0].int_1;
							item3.Bounds = bounds;
							rectangle = ((!rectangle.IsEmpty) ? Rectangle.Union(rectangle, item3.Bounds) : item3.Bounds);
						}
					}
					if (!bool_7 && array2[item2.int_0].int_0 != 0 && rectangle_0.Width - (item2.size_0.Width + array2[item2.int_0].int_0 * item2.arrayList_0.Count) != 0)
					{
						Rectangle bounds2 = ((IBlock)item2.arrayList_0[item2.arrayList_0.Count - 1]).Bounds;
						bounds2.Width += rectangle_0.Width - (item2.size_0.Width + array2[item2.int_0].int_0 * item2.arrayList_0.Count);
						((IBlock)item2.arrayList_0[item2.arrayList_0.Count - 1]).Bounds = bounds2;
					}
				}
				return rectangle;
			}
			{
				foreach (Class279 item4 in arrayList_0)
				{
					foreach (IBlock item5 in item4.arrayList_0)
					{
						if (!item5.Visible)
						{
							continue;
						}
						Rectangle bounds3 = item5.Bounds;
						if (bool_4 && item4.size_0.Width > 0)
						{
							bounds3.Width = item4.size_0.Width;
						}
						bounds3.Offset(array[item4.int_0]);
						if (eContentAlignment_0 == eContentAlignment.Center)
						{
							bounds3.Offset((rectangle_0.Width - rectangle_1.Width + (item4.size_0.Width - bounds3.Width)) / 2, 0);
						}
						else if (eContentAlignment_0 == eContentAlignment.Right)
						{
							bounds3.Offset(rectangle_0.Width - rectangle_1.Width + item4.size_0.Width - bounds3.Width, 0);
						}
						bounds3.Width += array2[item4.int_0].int_0;
						if (array2[item4.int_0].int_1 != 0)
						{
							if (bool_7)
							{
								int num2 = (array2[item4.int_0].bool_0 ? array2[item4.int_0].int_1 : ((int)Math.Floor((float)bounds3.Height * array2[item4.int_0].float_1)));
								array[item4.int_0].Y += num2 - bounds3.Height;
								bounds3.Height = num2;
							}
							else
							{
								bounds3.Height += array2[item4.int_0].int_1;
								array[item4.int_0].Y += array2[item4.int_0].int_1;
							}
						}
						item5.Bounds = bounds3;
						rectangle = ((!rectangle.IsEmpty) ? Rectangle.Union(rectangle, item5.Bounds) : item5.Bounds);
					}
					if (!bool_7 && array2[item4.int_0].int_1 != 0 && rectangle_0.Height - (item4.size_0.Height + array2[item4.int_0].int_1 * item4.arrayList_0.Count) != 0)
					{
						Rectangle bounds4 = ((IBlock)item4.arrayList_0[item4.arrayList_0.Count - 1]).Bounds;
						bounds4.Height += rectangle_0.Height - (item4.size_0.Height + array2[item4.int_0].int_1 * item4.arrayList_0.Count);
						((IBlock)item4.arrayList_0[item4.arrayList_0.Count - 1]).Bounds = bounds4;
					}
				}
				return rectangle;
			}
		}
		return rectangle;
	}

	private Point method_1(IBlock iblock_0, Point point_0)
	{
		if (layoutManagerPositionEventHandler_0 != null)
		{
			LayoutManagerPositionEventArgs layoutManagerPositionEventArgs = new LayoutManagerPositionEventArgs();
			layoutManagerPositionEventArgs.Block = iblock_0;
			layoutManagerPositionEventArgs.CurrentPosition = point_0;
			layoutManagerPositionEventHandler_0(this, layoutManagerPositionEventArgs);
			if (layoutManagerPositionEventArgs.Cancel)
			{
				return layoutManagerPositionEventArgs.NextPosition;
			}
		}
		if (eContentOrientation_0 == eContentOrientation.Horizontal)
		{
			point_0.X += iblock_0.Bounds.Width + int_0;
		}
		else
		{
			point_0.Y += iblock_0.Bounds.Height + int_0;
		}
		return point_0;
	}

	private Rectangle method_2(Rectangle rectangle_0, Rectangle rectangle_1, IBlock[] iblock_0)
	{
		_ = rectangle_1.X;
		_ = rectangle_0.X;
		if (rectangle_1.Width < rectangle_0.Width)
		{
			rectangle_1.X = rectangle_0.Right - (rectangle_1.X - rectangle_0.X + rectangle_1.Width);
		}
		else if (rectangle_1.Width > rectangle_0.Width)
		{
			rectangle_0.Width = rectangle_1.Width;
		}
		foreach (IBlock block in iblock_0)
		{
			if (block.Visible)
			{
				Rectangle bounds = block.Bounds;
				block.Bounds = new Rectangle(rectangle_0.Right - (bounds.X - rectangle_0.X + bounds.Width), bounds.Y, bounds.Width, bounds.Height);
			}
		}
		return rectangle_1;
	}
}
