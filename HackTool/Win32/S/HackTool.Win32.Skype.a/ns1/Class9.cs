using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns1;

internal sealed class Class9
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[SpecialName]
	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("ns1.Class9", typeof(Class9).Assembly));
		}
		return resourceManager_0;
	}

	[SpecialName]
	internal static Bitmap smethod_1()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("fileopen", cultureInfo_0);
		return (Bitmap)@object;
	}

	[SpecialName]
	internal static Bitmap smethod_2()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("fuck", cultureInfo_0);
		return (Bitmap)@object;
	}

	[SpecialName]
	internal static Bitmap smethod_3()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("start", cultureInfo_0);
		return (Bitmap)@object;
	}
}
