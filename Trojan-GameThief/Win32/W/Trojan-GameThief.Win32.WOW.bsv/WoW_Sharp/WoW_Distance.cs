using System;

namespace WoW_Sharp;

public class WoW_Distance : IComparable
{
	private float float_0;

	private WoW_Object woW_Object_0;

	public float Distance => float_0;

	public WoW_Object Obj => woW_Object_0;

	internal WoW_Distance(float float_1, WoW_Object woW_Object_1)
	{
		float_0 = float_1;
		woW_Object_0 = woW_Object_1;
	}

	public int CompareTo(object target)
	{
		return float_0.CompareTo((object?)((WoW_Distance)target).Distance);
	}
}
