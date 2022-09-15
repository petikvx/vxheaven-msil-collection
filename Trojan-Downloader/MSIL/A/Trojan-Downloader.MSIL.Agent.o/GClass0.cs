using System.Collections;
using System.Text.RegularExpressions;

public class GClass0
{
	public static RegexOptions regexOptions_0 = RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.ExplicitCapture | RegexOptions.Singleline;

	public static string smethod_0(string string_0, string string_1, string[] string_2)
	{
		string_1 = "|%" + string_1 + "%|";
		if (string_2 != null && string_2.Length > 0 && string_0 != null && string_0.IndexOf(string_1) != -1)
		{
			string newValue = "(" + ((string_2.Length > 1) ? ("(" + Class39.smethod_1(string_2, ")|(") + ")") : string_2[0]) + ")";
			return string_0.Replace(string_1, newValue);
		}
		return string_0;
	}

	public static string smethod_1(string string_0, string[] string_1, string[][] string_2)
	{
		for (int i = 0; i < string_1.Length; i++)
		{
			string_0 = smethod_0(string_0, string_1[i], string_2[i]);
		}
		return string_0;
	}

	public static string smethod_2(string string_0, string string_1)
	{
		return Regex.Replace(string_0, string_1, "", regexOptions_0);
	}

	public static string[] smethod_3(string string_0, string string_1)
	{
		return smethod_4(string_0, string_1, bool_0: false);
	}

	public static string[] smethod_4(string string_0, string string_1, bool bool_0)
	{
		MatchCollection matchCollection = Regex.Matches(string_0, string_1, regexOptions_0);
		ArrayList arrayList = new ArrayList();
		foreach (Match item in matchCollection)
		{
			arrayList.Add(item.ToString());
		}
		if (arrayList.Count > 0 && bool_0)
		{
			arrayList = smethod_7(arrayList);
		}
		return arrayList.ToArray(typeof(string)) as string[];
	}

	public static string[] smethod_5(string string_0, string string_1, string string_2)
	{
		return smethod_6(string_0, string_1, string_2, bool_0: false);
	}

	public static string[] smethod_6(string string_0, string string_1, string string_2, bool bool_0)
	{
		MatchCollection matchCollection = Regex.Matches(string_0, string_1, regexOptions_0);
		ArrayList arrayList = new ArrayList();
		foreach (Match item in matchCollection)
		{
			Group group = item.Groups[string_2];
			arrayList.Add(group.Value);
		}
		if (arrayList.Count > 0 && bool_0)
		{
			arrayList = smethod_7(arrayList);
		}
		return arrayList.ToArray(typeof(string)) as string[];
	}

	public static ArrayList smethod_7(ArrayList arrayList_0)
	{
		if (arrayList_0.Count > 0)
		{
			ArrayList arrayList = new ArrayList();
			arrayList_0.Sort();
			arrayList.Add(arrayList_0[0]);
			for (int i = 1; i < arrayList_0.Count; i++)
			{
				if (arrayList_0[i] as string!= arrayList_0[i - 1] as string)
				{
					arrayList.Add(arrayList_0[i]);
				}
			}
			return arrayList;
		}
		return arrayList_0;
	}
}
