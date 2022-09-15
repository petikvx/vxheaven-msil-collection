using System.Text;

namespace DevComponents.DotNetBar;

internal static class Class91
{
	internal static string smethod_0(string string_0)
	{
		if (string_0.Length > 1)
		{
			return string_0.Substring(0, 1).ToUpper() + string_0.Substring(1);
		}
		return string_0;
	}

	internal static string smethod_1(string string_0)
	{
		string_0 = string_0.Replace('_', ' ');
		if (string_0.Contains(" "))
		{
			string[] array = string_0.Split(new char[1] { ' ' });
			StringBuilder stringBuilder = new StringBuilder(string_0.Length);
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(smethod_0(array[i]));
				if (i < array.Length - 1)
				{
					stringBuilder.Append(' ');
				}
			}
			return stringBuilder.ToString();
		}
		if (string_0.Length > 2)
		{
			bool flag = false;
			int num = -1;
			StringBuilder stringBuilder2 = new StringBuilder(string_0.Length + 10);
			for (int j = 0; j < string_0.Length; j++)
			{
				if (smethod_2(string_0[j]))
				{
					if (flag && j - num > 1)
					{
						stringBuilder2.Append(' ');
						stringBuilder2.Append(string_0[j]);
						num = j;
					}
					else if (!flag)
					{
						num = j;
						flag = true;
						if (j > 0)
						{
							stringBuilder2.Append(' ');
						}
						stringBuilder2.Append(string_0[j]);
					}
					else
					{
						num = j;
						stringBuilder2.Append(string_0[j].ToString().ToLower());
						flag = true;
					}
				}
				else if (flag)
				{
					stringBuilder2.Append(string_0[j]);
				}
				else
				{
					stringBuilder2.Append(string_0[j].ToString().ToUpper());
					flag = true;
					num = j;
				}
			}
			return stringBuilder2.ToString();
		}
		return string_0;
	}

	internal static bool smethod_2(char char_0)
	{
		return smethod_3(char_0.ToString());
	}

	internal static bool smethod_3(string string_0)
	{
		return string_0.ToUpper() == string_0;
	}
}
