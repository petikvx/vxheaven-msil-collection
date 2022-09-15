using System;
using System.Text;
using System.Web;
using System.Xml;

internal class Class24 : Class15
{
	public Class24()
	{
	}

	public Class24(Class14 class14_0)
		: base(class14_0)
	{
	}

	public Class24(Class14 class14_0, XmlNode xmlNode_0)
		: base(class14_0, xmlNode_0)
	{
	}

	protected string method_15(Class28 class28_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < class28_0.method_5(); i++)
		{
			if (i != 0)
			{
				stringBuilder.Append("&");
			}
			stringBuilder.AppendFormat("{0}={1}", HttpUtility.UrlEncode(class28_0.method_44(i), Class12.encoding_0), HttpUtility.UrlEncode(Class51.smethod_7(class28_0.method_25(i))));
		}
		return stringBuilder.ToString();
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class28 evaluate(Class27 session, Class28 args, ref Class14 runningNode)
	{
		string text = Class28.smethod_2(vmethod_2(session, "url"));
		if (text == null)
		{
			return null;
		}
		string text2 = vmethod_5("browser", ":BROWSER");
		bool bool_ = Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "compress", Class28.smethod_3("false"))), bool_0: false);
		bool flag = Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "changePage", Class28.smethod_3("true"))), bool_0: true);
		bool bool_2 = Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "autoRedirect", Class28.smethod_3("true"))), bool_0: true);
		bool bool_3 = Class51.smethod_11(Class28.smethod_2(vmethod_3(session, "getPayload", Class28.smethod_3("true"))), bool_0: true);
		string string_ = Class28.smethod_2(vmethod_3(session, "contentType", null));
		string string_2 = Class28.smethod_2(vmethod_3(session, "referrer", null));
		string string_3 = Class28.smethod_2(vmethod_3(session, "userAgent", null));
		Class28 @class = vmethod_3(session, "responseInfo", null);
		@class?.method_28("BROWSER", Class28.smethod_3(text2));
		Class28 class2 = vmethod_3(session, "headers", null);
		string[] string_4 = null;
		if (class2 != null)
		{
			string_4 = class2.method_35(typeof(string)) as string[];
		}
		Class8 class3 = session.method_21(text2);
		Class28 result = null;
		string text3 = null;
		string text4 = null;
		string text5 = null;
		Class31 class6;
		Class32 class7;
		switch (string_0)
		{
		case "HttpPost":
			text4 = "POST";
			text5 = Class28.smethod_2(vmethod_3(session, "body", null));
			if (text5 == null)
			{
				Class28 class5 = vmethod_3(session, "argMap", null);
				if (class5 == null)
				{
					class5 = new Class28();
					method_14(session, args, ref runningNode, class5, bool_0: false);
				}
				text5 = method_15(class5);
			}
			goto IL_0229;
		case "HttpGet":
			text4 = "GET";
			text3 = Class28.smethod_2(vmethod_3(session, "query", null));
			if (text3 == null)
			{
				Class28 class4 = vmethod_3(session, "argMap", null);
				if (class4 == null)
				{
					class4 = new Class28();
					method_14(session, args, ref runningNode, class4, bool_0: false);
				}
				text3 = method_15(class4);
			}
			goto IL_0229;
		default:
			{
				return null;
			}
			IL_0229:
			class6 = null;
			class7 = null;
			try
			{
				class6 = class3.method_3(text4, text, text3, text5, string_4, string_, string_2, string_3, bool_2, bool_, null);
				class7 = class3.method_5(class6, flag);
				if (flag)
				{
					result = session.method_24(text2, bool_3);
				}
				if (@class != null)
				{
					return session.method_25(@class, class7, bool_3);
				}
				return result;
			}
			catch
			{
				if (flag)
				{
					session.method_18(text2 + "(SUCCESS)", new Class28(false));
					session.method_18(text2 + "(REQUEST_TIMESTAMP)", Class28.smethod_3(Class51.smethod_6(DateTime.Now)));
				}
				if (@class != null)
				{
					@class.method_28("SUCCESS", new Class28(false));
					@class.method_28("REQUEST_TIMESTAMP", new Class28(DateTime.Now));
				}
				return null;
			}
		}
	}
}
