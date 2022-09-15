using System.Xml;

internal class Class2 : Class1
{
	public Class2()
	{
	}

	public Class2(Class0 class0_0)
		: base(class0_0)
	{
	}

	public Class2(Class0 class0_0, XmlNode xmlNode_0)
		: base(class0_0, xmlNode_0)
	{
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class14 evaluate(Class13 session, Class14 args)
	{
		Class14 result = null;
		Class1 @class = vmethod_5(0);
		if (@class != null)
		{
			do
			{
				Class14 class2 = @class.vmethod_7(session, args);
				if (class2 != null)
				{
					result = class2;
				}
			}
			while ((@class = @class.class1_0) != null);
		}
		return result;
	}
}
