using System;
using System.ComponentModel;
using System.Globalization;

namespace DevComponents.WinForms.Drawing;

[TypeConverter(typeof(CornerRadiusConverter))]
public struct CornerRadius : IEquatable<CornerRadius>
{
	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	public int TopLeft
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

	public int TopRight
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

	public int BottomRight
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
		}
	}

	public int BottomLeft
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

	internal bool Boolean_0
	{
		get
		{
			if (int_0 == 0 && int_1 == 0 && int_3 == 0)
			{
				return int_2 == 0;
			}
			return false;
		}
	}

	public CornerRadius(int uniformRadius)
	{
		int_0 = (int_1 = (int_2 = (int_3 = uniformRadius)));
	}

	public CornerRadius(int topLeft, int topRight, int bottomRight, int bottomLeft)
	{
		int_0 = topLeft;
		int_1 = topRight;
		int_3 = bottomRight;
		int_2 = bottomLeft;
	}

	public override bool Equals(object obj)
	{
		if (obj is CornerRadius cornerRadius)
		{
			return this == cornerRadius;
		}
		return false;
	}

	public bool Equals(CornerRadius cornerRadius)
	{
		return this == cornerRadius;
	}

	public override int GetHashCode()
	{
		return int_0.GetHashCode() ^ int_1.GetHashCode() ^ int_2.GetHashCode() ^ int_3.GetHashCode();
	}

	public override string ToString()
	{
		return CornerRadiusConverter.ToString(this, CultureInfo.InvariantCulture);
	}

	public static bool operator ==(CornerRadius cr1, CornerRadius cr2)
	{
		if (cr1.int_0 == cr2.int_0 && cr1.int_1 == cr2.int_1 && cr1.int_3 == cr2.int_3)
		{
			return cr1.int_2 == cr2.int_2;
		}
		return false;
	}

	public static bool operator !=(CornerRadius cr1, CornerRadius cr2)
	{
		return !(cr1 == cr2);
	}

	internal bool method_0(bool bool_0)
	{
		if (!bool_0 && ((double)int_0 < 0.0 || (double)int_1 < 0.0 || (double)int_2 < 0.0 || (double)int_3 < 0.0))
		{
			return false;
		}
		return true;
	}
}
