using System;
using System.Drawing;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

public class BubbleContentManager : SerialContentLayoutManager
{
	private Size size_0 = Size.Empty;

	private float float_0;

	private float float_1;

	private float float_2;

	private float float_3;

	private int int_1 = -1;

	private int int_2 = -1;

	public Size BubbleSize
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

	public float Factor1
	{
		get
		{
			return float_0;
		}
		set
		{
			float_0 = value;
		}
	}

	public float Factor2
	{
		get
		{
			return float_1;
		}
		set
		{
			float_1 = value;
		}
	}

	public float Factor3
	{
		get
		{
			return float_2;
		}
		set
		{
			float_2 = value;
		}
	}

	public float Factor4
	{
		get
		{
			return float_3;
		}
		set
		{
			float_3 = value;
		}
	}

	public int MouseOverIndex
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
		}
	}

	public int MouseOverPosition
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	public BubbleContentManager()
	{
		ContentAlignment = eContentAlignment.Center;
	}

	public override Rectangle Layout(Rectangle containerBounds, IBlock[] contentBlocks, BlockLayoutManager blockLayout)
	{
		if (contentBlocks.Length == 0)
		{
			return Rectangle.Empty;
		}
		if (int_1 == -1)
		{
			return base.Layout(containerBounds, contentBlocks, blockLayout);
		}
		BubbleButton[] array = new BubbleButton[contentBlocks.Length];
		contentBlocks.CopyTo(array, 0);
		int int_ = 0;
		int int_2 = 0;
		if (ContentOrientation == eContentOrientation.Horizontal)
		{
			array[int_1].SetMagnifiedDisplayRectangle(new Rectangle(this.int_2, method_8(containerBounds, size_0.Height), size_0.Width, size_0.Height));
			int_ = this.int_2;
		}
		else
		{
			array[int_1].SetMagnifiedDisplayRectangle(new Rectangle(method_7(containerBounds, size_0.Width), this.int_2, size_0.Width, size_0.Height));
			int_2 = this.int_2;
		}
		int int_3 = size_0.Width - contentBlocks[0].Bounds.Width;
		int int_4 = size_0.Height - contentBlocks[0].Bounds.Height;
		int num = method_6(array, int_1);
		if (num >= 0)
		{
			method_3(containerBounds, array[num], int_3, int_4, float_1, ref int_, ref int_2);
		}
		num = method_6(array, num);
		if (num >= 0)
		{
			method_3(containerBounds, array[num], int_3, int_4, float_0, ref int_, ref int_2);
		}
		if (ContentOrientation == eContentOrientation.Horizontal)
		{
			while (num >= 0)
			{
				num = method_6(array, num);
				if (num >= 0)
				{
					int_ -= array[num].DisplayRectangle.Width + BlockSpacing;
					array[num].SetMagnifiedDisplayRectangle(new Rectangle(int_, array[num].DisplayRectangle.Y, array[num].DisplayRectangle.Width, array[num].DisplayRectangle.Height));
				}
			}
			int_ = this.int_2 + size_0.Width + BlockSpacing;
		}
		else
		{
			while (num >= 0)
			{
				num = method_6(array, num);
				if (num >= 0)
				{
					int_2 -= array[num].DisplayRectangle.Height + BlockSpacing;
					array[num].SetMagnifiedDisplayRectangle(new Rectangle(array[num].DisplayRectangle.X, int_2, array[num].DisplayRectangle.Width, array[num].DisplayRectangle.Height));
				}
			}
			int_2 = this.int_2 + size_0.Height + BlockSpacing;
		}
		num = method_5(array, int_1);
		if (num >= 0)
		{
			method_4(containerBounds, array[num], int_3, int_4, float_2, ref int_, ref int_2);
		}
		if (num == -1)
		{
			num = int_1;
		}
		num = method_5(array, num);
		if (num >= 0)
		{
			method_4(containerBounds, array[num], int_3, int_4, float_3, ref int_, ref int_2);
		}
		if (ContentOrientation == eContentOrientation.Horizontal)
		{
			while (num >= 0)
			{
				num = method_5(array, num);
				if (num >= 0)
				{
					array[num].SetMagnifiedDisplayRectangle(new Rectangle(int_, array[num].DisplayRectangle.Y, array[num].DisplayRectangle.Width, array[num].DisplayRectangle.Height));
					int_ += array[num].DisplayRectangle.Width + BlockSpacing;
				}
			}
		}
		else
		{
			while (num >= 0)
			{
				num = method_5(array, num);
				if (num >= 0)
				{
					array[num].SetMagnifiedDisplayRectangle(new Rectangle(array[num].DisplayRectangle.X, int_2, array[num].DisplayRectangle.Width, array[num].DisplayRectangle.Height));
					int_2 += array[num].DisplayRectangle.Height + BlockSpacing;
				}
			}
		}
		if (array.Length == 1)
		{
			return array[0].MagnifiedDisplayRectangle;
		}
		return Rectangle.Union(array[0].MagnifiedDisplayRectangle, array[^1].MagnifiedDisplayRectangle);
	}

	private void method_3(Rectangle rectangle_0, BubbleButton bubbleButton_0, int int_3, int int_4, float float_4, ref int int_5, ref int int_6)
	{
		int num = (int)((float)bubbleButton_0.DisplayRectangle.Width + (float)int_3 * float_4);
		int num2 = (int)((float)bubbleButton_0.DisplayRectangle.Height + (float)int_4 * float_4);
		if (ContentOrientation == eContentOrientation.Horizontal)
		{
			int_5 -= num + BlockSpacing;
			bubbleButton_0.SetMagnifiedDisplayRectangle(new Rectangle(int_5, method_8(rectangle_0, num2), num, num2));
		}
		else
		{
			int_6 -= num2 + BlockSpacing;
			bubbleButton_0.SetMagnifiedDisplayRectangle(new Rectangle(method_7(rectangle_0, num), int_6, num, num2));
		}
	}

	private void method_4(Rectangle rectangle_0, BubbleButton bubbleButton_0, int int_3, int int_4, float float_4, ref int int_5, ref int int_6)
	{
		int num = (int)((float)bubbleButton_0.DisplayRectangle.Width + (float)int_3 * float_4);
		int num2 = (int)((float)bubbleButton_0.DisplayRectangle.Height + (float)int_4 * float_4);
		if (ContentOrientation == eContentOrientation.Horizontal)
		{
			bubbleButton_0.SetMagnifiedDisplayRectangle(new Rectangle(int_5, method_8(rectangle_0, num2), num, num2));
			int_5 += num + BlockSpacing;
		}
		else
		{
			bubbleButton_0.SetMagnifiedDisplayRectangle(new Rectangle(method_7(rectangle_0, num), int_6, num, num2));
			int_6 += num2 + BlockSpacing;
		}
	}

	private int method_5(BubbleButton[] bubbleButton_0, int int_3)
	{
		int result = -1;
		for (int i = int_3 + 1; i < bubbleButton_0.Length; i++)
		{
			if (bubbleButton_0[i].Visible)
			{
				result = i;
				break;
			}
		}
		return result;
	}

	private int method_6(BubbleButton[] bubbleButton_0, int int_3)
	{
		int result = -1;
		int num = int_3 - 1;
		while (num >= 0)
		{
			if (!bubbleButton_0[num].Visible)
			{
				num--;
				continue;
			}
			result = num;
			break;
		}
		return result;
	}

	private int method_7(Rectangle rectangle_0, int int_3)
	{
		if (ContentOrientation == eContentOrientation.Vertical)
		{
			if (ContentVerticalAlignment == eContentVerticalAlignment.Top)
			{
				return rectangle_0.Left;
			}
			if (ContentVerticalAlignment == eContentVerticalAlignment.Middle)
			{
				return rectangle_0.Left + (rectangle_0.Width - int_3) / 2;
			}
			if (ContentVerticalAlignment == eContentVerticalAlignment.Bottom)
			{
				return rectangle_0.Right - int_3;
			}
			return -1;
		}
		throw new InvalidOperationException("Cannot use GetX method on eContentOrientation.Horizontal");
	}

	private int method_8(Rectangle rectangle_0, int int_3)
	{
		if (ContentOrientation == eContentOrientation.Horizontal)
		{
			if (ContentVerticalAlignment == eContentVerticalAlignment.Top)
			{
				return rectangle_0.Top;
			}
			if (ContentVerticalAlignment == eContentVerticalAlignment.Middle)
			{
				return rectangle_0.Top + (rectangle_0.Height - int_3) / 2;
			}
			if (ContentVerticalAlignment == eContentVerticalAlignment.Bottom)
			{
				return rectangle_0.Bottom - int_3;
			}
			return -1;
		}
		throw new InvalidOperationException("Cannot use GetX method on eContentOrientation.Vertical");
	}
}
