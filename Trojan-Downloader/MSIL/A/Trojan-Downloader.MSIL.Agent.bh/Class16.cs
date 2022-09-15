using System.Xml;

internal class Class16 : Class15
{
	public Class16()
	{
	}

	public Class16(Class14 class14_0)
		: base(class14_0)
	{
	}

	public Class16(Class14 class14_0, XmlNode xmlNode_0)
		: base(class14_0, xmlNode_0)
	{
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class28 evaluate(Class27 session, Class28 args, ref Class14 runningNode)
	{
		try
		{
			Class28 result = null;
			Class15 @class = vmethod_6(0);
			if (@class != null)
			{
				do
				{
					runningNode = @class;
					Class28 class2 = @class.vmethod_8(session, args, ref runningNode);
					if (class2 != null)
					{
						result = class2;
					}
				}
				while ((@class = @class.class15_0) != null);
			}
			return result;
		}
		finally
		{
			if (string_0 == "Sub")
			{
				runningNode = session.method_0();
			}
			else
			{
				runningNode = this;
			}
		}
	}
}
