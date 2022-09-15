using System;

namespace Xenocode.Client.Attributes;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public class EntryPoint : Attribute
{
	public EntryPoint()
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}
}
