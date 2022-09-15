using System.Collections;

internal class Class10 : GInterface0
{
	protected IDictionary idictionary_0 = new Hashtable(new CaseInsensitiveHashCodeProvider(), new CaseInsensitiveComparer());

	private GInterface1 ginterface1_0;

	public Class10(GInterface1 ginterface1_1)
	{
		ginterface1_0 = ginterface1_1;
	}

	bool GInterface0.imethod_0(string string_0)
	{
		string_0 = ginterface1_0.imethod_0(string_0).ToString();
		return idictionary_0.Contains(string_0);
	}

	byte[] GInterface0.imethod_1(string string_0)
	{
		string_0 = ginterface1_0.imethod_0(string_0).ToString();
		if (idictionary_0.Contains(string_0))
		{
			return idictionary_0[string_0] as byte[];
		}
		return null;
	}

	public void imethod_2(string string_0, byte[] byte_0)
	{
		string_0 = ginterface1_0.imethod_0(string_0).ToString();
		idictionary_0[string_0] = byte_0;
	}

	public void imethod_3()
	{
		idictionary_0.Clear();
	}
}
