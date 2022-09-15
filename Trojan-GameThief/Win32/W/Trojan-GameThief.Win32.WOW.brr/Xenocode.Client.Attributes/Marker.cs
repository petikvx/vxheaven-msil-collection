using System;

namespace Xenocode.Client.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface, Inherited = false, AllowMultiple = true)]
public class Marker : Attribute
{
	protected int _iId;

	public Marker(int int_0)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}
}
