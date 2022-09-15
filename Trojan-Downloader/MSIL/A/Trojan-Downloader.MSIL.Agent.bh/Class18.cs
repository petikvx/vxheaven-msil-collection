using System.Text;
using System.Xml;

internal class Class18 : Class15
{
	protected Class14 class14_0;

	public Class18()
	{
	}

	public Class18(Class14 class14_1)
		: base(class14_1)
	{
	}

	public Class18(Class14 class14_1, XmlNode xmlNode_0)
		: base(class14_1, xmlNode_0)
	{
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class28 evaluate(Class27 session, Class28 args, ref Class14 runningNode)
	{
		try
		{
			string text = Class28.smethod_2(vmethod_3(session, "src", null));
			string text2 = null;
			if (text != null)
			{
				text2 = session.class8_0.method_11(text);
			}
			if (text2 == null)
			{
				text2 = Class28.smethod_2(method_2(session, args, ref runningNode, 1, 1)[0]);
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(text2);
			Class28 result = null;
			int int_ = 1;
			foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
			{
				if (!Class51.smethod_1(childNode))
				{
					Class15 @class = Class26.smethod_0(class15_2, childNode) as Class15;
					Class15.smethod_0(@class, ref int_);
					runningNode = (class14_0 = @class);
					Class28 class2 = @class.vmethod_8(session, args, ref runningNode);
					if (class2 != null)
					{
						result = class2;
					}
				}
			}
			return result;
		}
		finally
		{
			runningNode = this;
		}
	}

	public override void vmethod_1(Class27 class27_0, StringBuilder stringBuilder_0, int int_1)
	{
		stringBuilder_0.AppendFormat("Node <{0}>, [Dynamic Code] + {2}\r\n", class14_0.string_0, class14_0.int_0);
		base.vmethod_1(class27_0, stringBuilder_0, int_1);
	}
}
