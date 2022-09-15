using System;

namespace DevComponents.DotNetBar;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
public class DevCoBrowsable : Attribute
{
	public static readonly DevCoBrowsable Yes = new DevCoBrowsable(browsable: true);

	public static readonly DevCoBrowsable No = new DevCoBrowsable(browsable: false);

	public bool Browsable;

	public DevCoBrowsable(bool browsable)
	{
		Browsable = browsable;
	}
}
