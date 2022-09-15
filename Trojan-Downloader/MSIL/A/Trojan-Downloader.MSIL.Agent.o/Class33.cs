using System;

internal class Class33
{
	public string string_0;

	public DateTime dateTime_0;

	public string string_1;

	public Enum1 enum1_0;

	public int int_0;

	public TimeSpan timeSpan_0;

	public TimeSpan timeSpan_1;

	public string string_2 = null;

	public Class33()
	{
	}

	public Class33(string string_3, DateTime dateTime_1, string string_4, Enum1 enum1_1, int int_1, TimeSpan timeSpan_2, TimeSpan timeSpan_3, string string_5)
	{
		string_0 = string_3;
		dateTime_0 = dateTime_1;
		string_1 = string_4;
		int_0 = int_1;
		timeSpan_0 = timeSpan_2;
		timeSpan_1 = timeSpan_3;
		string_2 = string_5;
	}

	public Class33(string string_3, string string_4)
	{
		string_0 = string_3;
		string[] array = string_4.Split(new char[1] { '-' });
		string text = ((array.Length >= 1) ? array[0] : "");
		string text2 = ((array.Length >= 2) ? array[1] : "");
		string text3 = ((array.Length >= 3) ? array[2] : "");
		string text4 = ((array.Length >= 4) ? array[3] : "");
		string text5 = ((array.Length >= 5) ? array[4] : "");
		string text6 = ((array.Length >= 6) ? array[5] : "");
		string text7 = ((array.Length >= 7) ? array[6] : null);
		dateTime_0 = GClass1.smethod_7(text, DateTime.MinValue);
		enum1_0 = (Enum1)GClass1.smethod_3(text3, 0);
		string_1 = text2;
		int_0 = GClass1.smethod_3(text4, -1);
		timeSpan_0 = TimeSpan.FromMilliseconds(GClass1.smethod_3(text5, 0));
		timeSpan_1 = TimeSpan.FromMilliseconds(GClass1.smethod_3(text6, 0));
		string_2 = text7;
	}

	string object.ToString()
	{
		return string.Format("{0};{1};{2};{3};{4};{5}{6}", GClass1.smethod_8(dateTime_0), string_1, (int)enum1_0, int_0, (int)timeSpan_0.TotalMilliseconds, (int)timeSpan_1.TotalMilliseconds, (string_2 == null) ? "" : (";" + string_2));
	}
}
