using System.Text;
using System.Xml;

internal class Class17 : Class16
{
	public Class17()
	{
		int int_ = 0;
		Class15.smethod_0(this, ref int_);
	}

	public Class17(Class14 class14_0)
		: base(class14_0)
	{
		int int_ = 0;
		Class15.smethod_0(this, ref int_);
	}

	public Class17(Class14 class14_0, XmlNode xmlNode_0)
		: base(class14_0, xmlNode_0)
	{
		int int_ = 0;
		Class15.smethod_0(this, ref int_);
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class28 evaluate(Class27 session, Class28 args, ref Class14 runningNode)
	{
		Class28 @class = null;
		session.method_12(args);
		try
		{
			@class = base.evaluate(session, args, ref runningNode);
		}
		catch (Exception2 exception)
		{
			@class = exception.class28_0;
		}
		finally
		{
			session.method_13();
			session.method_18("::__LASTRETURN", @class);
		}
		return @class;
	}

	public override void vmethod_9(int int_1)
	{
	}

	public override void vmethod_10()
	{
	}

	public override void vmethod_11(Class28 class28_0)
	{
		throw new Exception2(class28_0);
	}

	public override void vmethod_1(Class27 class27_0, StringBuilder stringBuilder_0, int int_1)
	{
		Class19 @class = class27_0.method_1(int_1++);
		if (@class != null)
		{
			@class.vmethod_1(class27_0, stringBuilder_0, int_1);
		}
		else if (class25_0 != null)
		{
			class25_0.vmethod_1(class27_0, stringBuilder_0, int_1);
		}
	}
}
