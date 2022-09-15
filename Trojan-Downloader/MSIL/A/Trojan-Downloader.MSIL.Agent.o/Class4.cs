using System.Xml;

internal class Class4 : Class2
{
	public Class4()
	{
	}

	public Class4(Class0 class0_0)
		: base(class0_0)
	{
	}

	public Class4(Class0 class0_0, XmlNode xmlNode_0)
		: base(class0_0, xmlNode_0)
	{
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class14 evaluate(Class13 session, Class14 args)
	{
		Class14 @class = null;
		session.method_9(args);
		try
		{
			@class = base.evaluate(session, args);
		}
		catch (Exception2 exception)
		{
			@class = exception.class14_0;
		}
		finally
		{
			session.method_10();
			session.method_14("::__LASTRETURN", @class);
		}
		return @class;
	}

	public override void vmethod_8(int int_0)
	{
	}

	public override void vmethod_9()
	{
	}

	public override void vmethod_10(Class14 class14_0)
	{
		throw new Exception2(class14_0);
	}
}
