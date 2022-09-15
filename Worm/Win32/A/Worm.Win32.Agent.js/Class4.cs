using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[CompilerGenerated]
[HideModuleName]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
internal sealed class Class4
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[SpecialName]
	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("DeadPixel.Resources", typeof(Class4).Assembly));
		}
		return resourceManager_0;
	}

	[SpecialName]
	internal static CultureInfo smethod_1()
	{
		return cultureInfo_0;
	}

	[SpecialName]
	internal static void smethod_2(CultureInfo cultureInfo_1)
	{
		cultureInfo_0 = cultureInfo_1;
	}
}
