using System.Xml;

internal class Class5 : Class1
{
	public Class5()
	{
	}

	public Class5(Class0 class0_0)
		: base(class0_0)
	{
	}

	public Class5(Class0 class0_0, XmlNode xmlNode_0)
		: base(class0_0, xmlNode_0)
	{
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class14 evaluate(Class13 session, Class14 args)
	{
		string text = Class14.smethod_2(vmethod_2(session, "src", null));
		string text2 = null;
		if (text != null)
		{
			text2 = session.class21_0.method_8(text);
		}
		if (text2 == null)
		{
			text2 = Class14.smethod_2(method_1(session, args, 1, 1)[0]);
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(text2);
		Class14 result = null;
		foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
		{
			if (!GClass1.smethod_2(childNode))
			{
				Class1 @class = Class12.smethod_0(class1_2, childNode) as Class1;
				Class14 class2 = @class.vmethod_7(session, args);
				if (class2 != null)
				{
					result = class2;
				}
			}
		}
		return result;
	}
}
