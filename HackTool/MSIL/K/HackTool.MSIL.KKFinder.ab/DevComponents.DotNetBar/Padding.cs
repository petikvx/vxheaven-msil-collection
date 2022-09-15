using System.ComponentModel;

namespace DevComponents.DotNetBar;

public class Padding
{
	public int Left;

	public int Right;

	public int Top;

	public int Bottom;

	[Browsable(false)]
	public int Horizontal => Left + Right;

	[Browsable(false)]
	public int Vertical => Top + Bottom;

	public bool IsEmpty
	{
		get
		{
			if (Left == 0 && Right == 0 && Top == 0)
			{
				return Bottom == 0;
			}
			return false;
		}
	}

	public Padding(int left, int right, int top, int bottom)
	{
		Left = left;
		Right = right;
		Top = top;
		Bottom = bottom;
	}
}
