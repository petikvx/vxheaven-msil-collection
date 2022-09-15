using System.Collections;
using System.Text;

internal class Class39
{
	public static string[] smethod_0(string string_0, string string_1)
	{
		if (string_0 == null)
		{
			return new string[0];
		}
		string[] array = string_0.Split(string_1.ToCharArray());
		int num = 0;
		int i;
		for (i = 0; i < array.Length; i++)
		{
			array[i] = array[i].Trim();
			if (array[i] == "")
			{
				array[i] = null;
				num++;
			}
		}
		string[] array2 = new string[array.Length - num];
		i = 0;
		int num2 = 0;
		for (; i < array.Length; i++)
		{
			if (array[i] != null)
			{
				array2[num2++] = array[i];
			}
		}
		return array2;
	}

	public static string smethod_1(IEnumerable ienumerable_0, string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (object item in ienumerable_0)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(string_0);
			}
			stringBuilder.Append(item.ToString());
		}
		return stringBuilder.ToString();
	}
}
