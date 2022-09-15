using System;

internal class Class39
{
	public DateTime dateTime_0;

	public string string_0;

	public Enum3 enum3_0;

	public int int_0;

	public TimeSpan timeSpan_0;

	public TimeSpan timeSpan_1;

	public string string_1 = null;

	public Class39()
	{
	}

	public Class39(DateTime dateTime_1, string string_2, Enum3 enum3_1, int int_1, TimeSpan timeSpan_2, TimeSpan timeSpan_3, string string_3)
	{
		dateTime_0 = dateTime_1;
		string_0 = string_2;
		int_0 = int_1;
		timeSpan_0 = timeSpan_2;
		timeSpan_1 = timeSpan_3;
		string_1 = string_3;
		enum3_0 = enum3_1;
	}

	public Class39(string string_2)
	{
		string[] array = string_2.Split(new char[1] { ';' });
		string text = ((array.Length >= 1) ? array[0] : "");
		string text2 = ((array.Length >= 2) ? array[1] : "");
		string text3 = ((array.Length >= 3) ? array[2] : "");
		string text4 = ((array.Length >= 4) ? array[3] : "");
		string text5 = ((array.Length >= 5) ? array[4] : "");
		string text6 = ((array.Length >= 6) ? array[5] : "");
		string text7 = ((array.Length >= 7) ? array[6] : null);
		dateTime_0 = Class51.smethod_13(text, DateTime.MinValue);
		enum3_0 = (Enum3)Class51.smethod_9(text3, 0);
		string_0 = text2;
		int_0 = Class51.smethod_9(text4, -1);
		timeSpan_0 = TimeSpan.FromMilliseconds(Class51.smethod_9(text5, 0));
		timeSpan_1 = TimeSpan.FromMilliseconds(Class51.smethod_9(text6, 0));
		string_1 = text7;
	}

	string object.ToString()
	{
		return string.Format("{0};{1};{2};{3};{4};{5}{6}", Class51.smethod_6(dateTime_0), string_0, Class51.smethod_3((int)enum3_0), Class51.smethod_3(int_0), Class51.smethod_3((int)timeSpan_0.TotalMilliseconds), Class51.smethod_3((int)timeSpan_1.TotalMilliseconds), (string_1 == null) ? "" : (";" + string_1));
	}
}
