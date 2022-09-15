using System.Xml;

internal class Class6 : Class1
{
	public Class6()
	{
	}

	public Class6(Class0 class0_0)
		: base(class0_0)
	{
	}

	public Class6(Class0 class0_0, XmlNode xmlNode_0)
		: base(class0_0, xmlNode_0)
	{
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class14 evaluate(Class13 session, Class14 args)
	{
		string text = null;
		if (string_0 == "GoSub")
		{
			text = Class14.smethod_2(vmethod_1(session, "__name"));
		}
		else
		{
			text = string_0;
			text = text.Substring(1, text.Length - 1);
		}
		string text2 = Class14.smethod_2(vmethod_2(session, "__program", null));
		if (text2 != null)
		{
			text = text2 + "." + text;
		}
		Class4 @class;
		if ((@class = session.method_3(text)) != null)
		{
			bool flag = GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "__copyLocals", Class14.smethod_3("false"))), bool_0: false);
			Class14 class2 = new Class14();
			if (flag)
			{
				session.method_8(class2);
			}
			method_11(session, args, class2, bool_0: true);
			return @class.vmethod_7(session, class2);
		}
		session.method_18("Unknown subroutine '{0}'", text);
		return null;
	}
}
