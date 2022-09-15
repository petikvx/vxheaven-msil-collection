using System.Text.RegularExpressions;
using System.Xml;

internal class Class23 : Class15
{
	public Class23()
	{
	}

	public Class23(Class14 class14_0)
		: base(class14_0)
	{
	}

	public Class23(Class14 class14_0, XmlNode xmlNode_0)
		: base(class14_0, xmlNode_0)
	{
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class28 evaluate(Class27 session, Class28 args, ref Class14 runningNode)
	{
		string text = Class28.smethod_2(vmethod_2(session, "pattern"));
		Class28 result = null;
		if (text != null)
		{
			switch (string_0)
			{
			case "Substitute":
			{
				string input5 = Class28.smethod_2(method_2(session, args, ref runningNode, 1, 1)[0]);
				string text5 = Class28.smethod_2(vmethod_2(session, "replace"));
				if (text5 == null)
				{
					text5 = "";
				}
				result = Class28.smethod_3(Regex.Replace(input5, text, text5, session.regexOptions_0));
				break;
			}
			case "CaptureByGroups":
			{
				string input4 = Class28.smethod_2(method_2(session, args, ref runningNode, 1, 1)[0]);
				int num3 = Class51.smethod_9(Class28.smethod_2(vmethod_3(session, "maxMatches", Class28.smethod_3("-1"))), -1);
				if (num3 < 0)
				{
					num3 = int.MaxValue;
				}
				string text3 = Class28.smethod_2(vmethod_3(session, "groups", null));
				string[] array3 = null;
				if (text3 != null)
				{
					array3 = Class49.smethod_0(text3, ",");
				}
				Regex regex2 = new Regex(text, session.regexOptions_0);
				if (array3 == null)
				{
					array3 = regex2.GetGroupNames();
				}
				Match match3 = regex2.Match(input4);
				Class28 class5 = new Class28();
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
						Class28 class6 = new Class28();
						foreach (Capture capture2 in group2.Captures)
						{
							class6.method_13(Class28.smethod_3(capture2.Value));
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
						class5.method_11(text4, Class28.smethod_1());
					}
				}
				result = class5;
				break;
			}
			case "CaptureByMatch":
			{
				string input3 = Class28.smethod_2(method_2(session, args, ref runningNode, 1, 1)[0]);
				int num2 = Class51.smethod_9(Class28.smethod_2(vmethod_3(session, "maxMatches", Class28.smethod_3("-1"))), -1);
				if (num2 < 0)
				{
					num2 = int.MaxValue;
				}
				string text2 = Class28.smethod_2(vmethod_3(session, "groups", null));
				string[] array = null;
				if (text2 != null)
				{
					array = Class49.smethod_0(text2, ",");
				}
				Regex regex = new Regex(text, session.regexOptions_0);
				if (array == null)
				{
					array = regex.GetGroupNames();
				}
				Match match2 = regex.Match(input3);
				Class28 class2 = new Class28();
				while (class2.method_5() < num2 && match2.Success)
				{
					Class28 class3 = new Class28();
					string[] array2 = array;
					foreach (string groupname in array2)
					{
						Group group = match2.Groups[groupname];
						if (group.Captures.Count <= 0)
						{
							continue;
						}
						Class28 class4 = new Class28();
						class3.method_11(groupname, class4);
						foreach (Capture capture3 in group.Captures)
						{
							class4.method_13(Class28.smethod_3(capture3.Value));
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
				string input2 = Class28.smethod_2(method_2(session, args, ref runningNode, 1, 1)[0]);
				int num = Class51.smethod_9(Class28.smethod_2(vmethod_3(session, "maxMatches", Class28.smethod_3("-1"))), -1);
				if (num < 0)
				{
					num = int.MaxValue;
				}
				Class28 @class = new Class28();
				Match match = Regex.Match(input2, text, session.regexOptions_0);
				while (@class.method_5() < num && match.Success)
				{
					@class.method_13(Class28.smethod_3(Class51.smethod_7(Class28.smethod_3(match.Value))));
					match = match.NextMatch();
				}
				result = @class;
				break;
			}
			case "IsMatch":
			{
				string input = Class28.smethod_2(method_2(session, args, ref runningNode, 1, 1)[0]);
				result = Class28.smethod_3(Class51.smethod_4(Regex.IsMatch(input, text, session.regexOptions_0)));
				break;
			}
			default:
				return base.evaluate(session, args, ref runningNode);
			}
		}
		return result;
	}
}
