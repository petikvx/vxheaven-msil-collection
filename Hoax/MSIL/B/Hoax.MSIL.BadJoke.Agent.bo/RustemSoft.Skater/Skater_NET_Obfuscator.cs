using System;

namespace RustemSoft.Skater;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
public class Skater_NET_Obfuscator : Attribute
{
	public string Skater_NET_Obfuscator;

	public Skater_NET_Obfuscator()
	{
		Skater_NET_Obfuscator = "This executable has been obfuscated by using RustemSoft Skater .NET Obfuscator Demo version. Please visit RustemSoft.com for more information.";
	}
}
