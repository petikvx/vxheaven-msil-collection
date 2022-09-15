using System;

namespace DevComponents.Editors.DateTimeAdv;

public class ParseDateTimeValueEventArgs : EventArgs
{
	public readonly object ValueObject;

	public bool IsParsed;

	private DateTime dateTime_0 = DateTimeGroup.MinDateTime;

	public DateTime ParsedValue
	{
		get
		{
			return dateTime_0;
		}
		set
		{
			dateTime_0 = value;
			IsParsed = true;
		}
	}

	public ParseDateTimeValueEventArgs(object valueObject)
	{
		ValueObject = valueObject;
	}
}
