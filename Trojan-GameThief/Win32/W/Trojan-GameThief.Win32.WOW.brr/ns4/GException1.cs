using System;

namespace ns4;

public class GException1 : Exception
{
	public string string_0;

	public GException1()
		: base("Compression error")
	{
		string_0 = null;
	}

	public GException1(string string_1)
		: this()
	{
		string_0 = string_1;
	}
}
