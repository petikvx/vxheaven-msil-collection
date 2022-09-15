using System.Xml;

internal class Class7 : Class1
{
	public Class7()
	{
	}

	public Class7(Class0 class0_0)
		: base(class0_0)
	{
	}

	public Class7(Class0 class0_0, XmlNode xmlNode_0)
		: base(class0_0, xmlNode_0)
	{
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class14 evaluate(Class13 session, Class14 args)
	{
		Class14 result = null;
		Class1[] array = vmethod_6(2, 3);
		if (array[0] != null)
		{
			Class14 @class = array[0].vmethod_7(session, args);
			if (@class != null)
			{
				string text = (@class.method_41() ? "OnTrue" : "OnFalse");
				Class1 class2 = array[1];
				while (class2 != null && class2.string_0 != text)
				{
					class2 = class2.class1_0;
				}
				if (class2 != null)
				{
					result = class2.vmethod_7(session, args);
				}
			}
		}
		return result;
	}
}
