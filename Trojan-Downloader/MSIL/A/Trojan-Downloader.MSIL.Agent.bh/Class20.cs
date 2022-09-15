using System.Xml;

internal class Class20 : Class15
{
	public Class20()
	{
	}

	public Class20(Class14 class14_0)
		: base(class14_0)
	{
	}

	public Class20(Class14 class14_0, XmlNode xmlNode_0)
		: base(class14_0, xmlNode_0)
	{
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class28 evaluate(Class27 session, Class28 args, ref Class14 runningNode)
	{
		Class28 result = null;
		Class15[] array = vmethod_7(2, 3);
		if (array[0] != null)
		{
			Class28 @class = array[0].vmethod_8(session, args, ref runningNode);
			if (@class != null)
			{
				string text = (@class.method_41() ? "OnTrue" : "OnFalse");
				Class15 class2 = array[1];
				while (class2 != null && class2.string_0 != text)
				{
					class2 = class2.class15_0;
				}
				if (class2 != null)
				{
					result = class2.vmethod_8(session, args, ref runningNode);
				}
			}
		}
		return result;
	}
}
