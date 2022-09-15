using System.Text;
using System.Xml;

internal class Class19 : Class15
{
	protected Class14 class14_0;

	protected string string_4;

	public Class19()
	{
	}

	public Class19(Class14 class14_1)
		: base(class14_1)
	{
	}

	public Class19(Class14 class14_1, XmlNode xmlNode_0)
		: base(class14_1, xmlNode_0)
	{
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class28 evaluate(Class27 session, Class28 args, ref Class14 runningNode)
	{
		string_4 = null;
		if (string_0 == "GoSub")
		{
			string_4 = Class28.smethod_2(vmethod_2(session, "__name"));
		}
		else
		{
			string_4 = string_0;
			string_4 = string_4.Substring(1, string_4.Length - 1);
		}
		string text = Class28.smethod_2(vmethod_3(session, "__program", null));
		if (text != null)
		{
			string_4 = text + "." + string_4;
		}
		Class17 @class;
		if ((@class = session.method_5(string_4)) != null)
		{
			bool flag = Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "__copyLocals", Class28.smethod_3("false"))), bool_0: false);
			Class28 class2 = new Class28();
			if (flag)
			{
				session.method_11(class2);
			}
			method_14(session, args, ref runningNode, class2, bool_0: true);
			try
			{
				session.stack_0.Push(this);
				return @class.vmethod_8(session, class2, ref class14_0);
			}
			finally
			{
				session.stack_0.Pop();
			}
		}
		session.method_22(method_0(session), "Unknown subroutine '{0}'", string_4);
		return null;
	}

	public override void vmethod_1(Class27 class27_0, StringBuilder stringBuilder_0, int int_1)
	{
		if (class14_0 != null)
		{
			stringBuilder_0.AppendFormat("Node <{0}>,\t Sub {1}+{2}\r\n", class14_0.string_0, string_4, class14_0.int_0);
		}
		else
		{
			stringBuilder_0.AppendFormat("GoSub <{0}>\r\n", string_4);
		}
		base.vmethod_1(class27_0, stringBuilder_0, int_1);
	}
}
