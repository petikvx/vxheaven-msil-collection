using System;

namespace DevComponents.Editors;

public class ParseDoubleValueEventArgs : EventArgs
{
	public readonly object ValueObject;

	public bool IsParsed;

	private double double_0;

	public double ParsedValue
	{
		get
		{
			return double_0;
		}
		set
		{
			double_0 = value;
			IsParsed = true;
		}
	}

	public ParseDoubleValueEventArgs(object valueObject)
	{
		ValueObject = valueObject;
	}
}
