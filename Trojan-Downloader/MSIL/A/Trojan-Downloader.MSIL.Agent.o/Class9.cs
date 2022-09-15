using System.Text.RegularExpressions;
using System.Xml;

internal class Class9 : Class1
{
	public Class9()
	{
	}

	public Class9(Class0 class0_0)
		: base(class0_0)
	{
	}

	public Class9(Class0 class0_0, XmlNode xmlNode_0)
		: base(class0_0, xmlNode_0)
	{
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class14 evaluate(Class13 session, Class14 args)
	{
		string text = Class14.smethod_2(vmethod_1(session, "pattern"));
		Class14 result = null;
		if (text != null)
		{
			switch (string_0)
			{
			case "Substitute":
			{
				string input5 = Class14.smethod_2(method_1(session, args, 1, 1)[0]);
				string text5 = Class14.smethod_2(vmethod_1(session, "replace"));
				if (text5 == null)
				{
					text5 = "";
				}
				result = Class14.smethod_3(Regex.Replace(input5, text, text5, session.regexOptions_0));
				break;
			}
			case "CaptureByGroups":
			{
				string input4 = Class14.smethod_2(method_1(session, args, 1, 1)[0]);
				int num3 = GClass1.smethod_3(Class14.smethod_2(vmethod_2(session, "maxMatches", Class14.smethod_3("-1"))), -1);
				if (num3 < 0)
				{
					num3 = int.MaxValue;
				}
				string text3 = Class14.smethod_2(vmethod_2(session, "groups", null));
				string[] array3 = null;
				if (text3 != null)
				{
					array3 = Class39.smethod_0(text3, ",");
				}
				Regex regex2 = new Regex(text, session.regexOptions_0);
				if (array3 == null)
				{
					array3 = regex2.GetGroupNames();
				}
				Match match3 = regex2.Match(input4);
				Class14 class5 = new Class14();
				string[] array2;
				while (class5.method_5() < num3 && match3.Success)
				{
					array2 = array3;
					foreach (string groupname2 in array2)
					{
						Group group2 = match3.Groups[groupname2];
						if (group2.Captures.Count <= 0)
						{
							continue;
						}
						Class14 class6 = new Class14();
						foreach (Capture capture2 in group2.Captures)
						{
							class6.method_13(Class14.smethod_3(capture2.ToString()));
						}
						if (class5.method_36(groupname2))
						{
							class5.method_27(groupname2).method_13(class6);
						}
						else
						{
							class5.method_11(groupname2, class6);
						}
					}
					match3 = match3.NextMatch();
				}
				array2 = array3;
				foreach (string text4 in array2)
				{
					if (!class5.method_36(text4))
					{
						class5.method_11(text4, Class14.smethod_1());
					}
				}
				result = class5;
				break;
			}
			case "CaptureByMatch":
			{
				string input3 = Class14.smethod_2(method_1(session, args, 1, 1)[0]);
				int num2 = GClass1.smethod_3(Class14.smethod_2(vmethod_2(session, "maxMatches", Class14.smethod_3("-1"))), -1);
				if (num2 < 0)
				{
					num2 = int.MaxValue;
				}
				string text2 = Class14.smethod_2(vmethod_2(session, "groups", null));
				string[] array = null;
				if (text2 != null)
				{
					array = Class39.smethod_0(text2, ",");
				}
				Regex regex = new Regex(text, session.regexOptions_0);
				if (array == null)
				{
					array = regex.GetGroupNames();
				}
				Match match2 = regex.Match(input3);
				Class14 class2 = new Class14();
				while (class2.method_5() < num2 && match2.Success)
				{
					Class14 class3 = new Class14();
					string[] array2 = array;
					foreach (string groupname in array2)
					{
						Group group = match2.Groups[groupname];
						if (group.Captures.Count <= 0)
						{
							continue;
						}
						Class14 class4 = new Class14();
						class3.method_11(groupname, class4);
						foreach (Capture capture3 in group.Captures)
						{
							class4.method_13(Class14.smethod_3(capture3.ToString()));
						}
					}
					class2.method_13(class3);
					match2 = match2.NextMatch();
				}
				result = class2;
				break;
			}
			case "GetMatch":
			{
				string input2 = Class14.smethod_2(method_1(session, args, 1, 1)[0]);
				int num = GClass1.smethod_3(Class14.smethod_2(vmethod_2(session, "maxMatches", Class14.smethod_3("-1"))), -1);
				if (num < 0)
				{
					num = int.MaxValue;
				}
				Class14 @class = new Class14();
				Match match = Regex.Match(input2, text, session.regexOptions_0);
				while (@class.method_5() < num && match.Success)
				{
					@class.method_13(Class14.smethod_3(match.ToString()));
					match = match.NextMatch();
				}
				result = @class;
				break;
			}
			case "IsMatch":
			{
				string input = Class14.smethod_2(method_1(session, args, 1, 1)[0]);
				result = Class14.smethod_3(Regex.IsMatch(input, text, session.regexOptions_0).ToString());
				break;
			}
			default:
				return base.evaluate(session, args);
			}
		}
		return result;
	}
}
