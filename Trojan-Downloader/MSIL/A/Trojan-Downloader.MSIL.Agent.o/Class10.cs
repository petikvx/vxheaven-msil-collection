using System;
using System.Text;
using System.Web;
using System.Xml;

internal class Class10 : Class1
{
	public Class10()
	{
	}

	public Class10(Class0 class0_0)
		: base(class0_0)
	{
	}

	public Class10(Class0 class0_0, XmlNode xmlNode_0)
		: base(class0_0, xmlNode_0)
	{
	}

	protected string method_12(Class14 class14_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < class14_0.method_5(); i++)
		{
			if (i != 0)
			{
				stringBuilder.Append("&");
			}
			stringBuilder.AppendFormat("{0}={1}", HttpUtility.UrlEncode(class14_0.method_44(i)), HttpUtility.UrlEncode(class14_0.method_25(i).System_002EObject_002EToString()));
		}
		return stringBuilder.ToString();
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class14 evaluate(Class13 session, Class14 args)
	{
		string text = Class14.smethod_2(vmethod_1(session, "url"));
		if (text == null)
		{
			return null;
		}
		string text2 = vmethod_4("browser", ":BROWSER");
		bool bool_ = GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "compress", Class14.smethod_3("false"))), bool_0: false);
		bool flag = GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "changePage", Class14.smethod_3("true"))), bool_0: true);
		bool bool_2 = GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "autoRedirect", Class14.smethod_3("true"))), bool_0: true);
		bool bool_3 = GClass1.smethod_5(Class14.smethod_2(vmethod_2(session, "getPayload", Class14.smethod_3("true"))), bool_0: true);
		string string_ = Class14.smethod_2(vmethod_2(session, "contentType", null));
		string string_2 = Class14.smethod_2(vmethod_2(session, "referrer", null));
		string string_3 = Class14.smethod_2(vmethod_2(session, "userAgent", null));
		Class14 @class = vmethod_2(session, "responseInfo", null);
		@class?.method_28("BROWSER", Class14.smethod_3(text2));
		Class14 class2 = Class14.smethod_3(vmethod_4("headers", null));
		string[] array = null;
		if (class2 != null)
		{
			array = new string[class2.method_5()];
			for (int i = 0; i < class2.method_5(); i++)
			{
				array[i] = Class14.smethod_2(class2.method_25(i));
			}
		}
		Class21 class3 = session.method_17(text2);
		Class14 result = null;
		string text3 = null;
		string text4 = null;
		string text5 = null;
		Class26 class6;
		Class27 class7;
		switch (string_0)
		{
		case "HttpPost":
			text4 = "POST";
			text5 = Class14.smethod_2(vmethod_2(session, "body", null));
			if (text5 == null)
			{
				Class14 class5 = vmethod_2(session, "argMap", null);
				if (class5 == null)
				{
					class5 = new Class14();
					method_11(session, args, class5, bool_0: false);
				}
				text5 = method_12(class5);
			}
			goto IL_0247;
		case "HttpGet":
			text4 = "GET";
			text3 = Class14.smethod_2(vmethod_2(session, "query", null));
			if (text3 == null)
			{
				Class14 class4 = vmethod_2(session, "argMap", null);
				if (class4 == null)
				{
					class4 = new Class14();
					method_11(session, args, class4, bool_0: false);
				}
				text3 = method_12(class4);
			}
			goto IL_0247;
		default:
			{
				return null;
			}
			IL_0247:
			class6 = null;
			class7 = null;
			try
			{
				class6 = class3.method_1(text4, text, text3, text5, array, string_, string_2, string_3, bool_2, bool_, null);
				class7 = class3.method_3(class6, flag);
				if (flag)
				{
					result = session.method_20(text2, bool_3);
				}
				if (@class != null)
				{
					return session.method_21(@class, class7, bool_3);
				}
				return result;
			}
			catch
			{
				if (flag)
				{
					session.method_14(text2 + "(SUCCESS)", new Class14(false));
					session.method_14(text2 + "(REQUEST_TIMESTAMP)", Class14.smethod_3(DateTime.Now.ToString()));
				}
				if (@class != null)
				{
					@class.method_28("SUCCESS", new Class14(false));
					@class.method_28("REQUEST_TIMESTAMP", new Class14(DateTime.Now));
				}
				throw;
			}
		}
	}
}
