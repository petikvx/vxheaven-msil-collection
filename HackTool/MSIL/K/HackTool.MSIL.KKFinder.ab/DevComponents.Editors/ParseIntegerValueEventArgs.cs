using System;

namespace DevComponents.Editors;

public class ParseIntegerValueEventArgs : EventArgs
{
	public readonly object ValueObject;

	public bool IsParsed;

	private int int_0;

	public int ParsedValue
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			IsParsed = true;
		}
	}

	public ParseIntegerValueEventArgs(object valueObject)
	{
		ValueObject = valueObject;
	}
}
