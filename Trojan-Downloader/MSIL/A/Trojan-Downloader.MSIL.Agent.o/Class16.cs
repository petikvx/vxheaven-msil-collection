using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
internal class Class16
{
	protected Hashtable hashtable_0 = new Hashtable();

	protected ArrayList arrayList_0 = new ArrayList();

	protected Hashtable hashtable_1 = new Hashtable();

	protected int int_0 = 0;

	[SpecialName]
	public object method_0(int int_1)
	{
		return method_2(int_1.ToString());
	}

	[SpecialName]
	public void method_1(int int_1, object object_0)
	{
		method_3(int_1.ToString(), object_0);
	}

	[SpecialName]
	public object method_2(string string_0)
	{
		return hashtable_0[string_0];
	}

	[SpecialName]
	public void method_3(string string_0, object object_0)
	{
		lock (this)
		{
			if (hashtable_0.ContainsKey(string_0))
			{
				hashtable_0[string_0] = object_0;
				if (hashtable_1[string_0] is string key)
				{
					hashtable_0[key] = object_0;
				}
			}
			else
			{
				method_6(string_0, object_0);
			}
		}
	}

	public string method_4(int int_1)
	{
		if (int_1 < int_0)
		{
			return arrayList_0[int_1] as string;
		}
		return null;
	}

	public void method_5(object object_0)
	{
		lock (this)
		{
			string key = int_0++.ToString();
			arrayList_0.Add(null);
			hashtable_0.Add(key, object_0);
		}
	}

	public void method_6(string string_0, object object_0)
	{
		lock (this)
		{
			string text = int_0++.ToString();
			arrayList_0.Add(string_0);
			hashtable_0.Add(text, object_0);
			hashtable_0.Add(string_0, object_0);
			hashtable_1.Add(text, string_0);
			hashtable_1.Add(string_0, text);
		}
	}

	public object method_7(int int_1)
	{
		return method_8(int_1.ToString());
	}

	public object method_8(string string_0)
	{
		if (hashtable_0.ContainsKey(string_0))
		{
			int_0--;
			object result = hashtable_0[string_0];
			hashtable_0.Remove(string_0);
			string text = hashtable_1[string_0] as string;
			if (text != null)
			{
				hashtable_0.Remove(text);
				hashtable_1.Remove(string_0);
				hashtable_1.Remove(text);
			}
			if (int_0 > 0)
			{
				string text2 = int_0.ToString();
				if (string_0 != text2 && text != text2)
				{
					int num = GClass1.smethod_3(string_0, -1);
					if (num == -1)
					{
						num = GClass1.smethod_3(text, -1);
					}
					string text3 = arrayList_0[int_0] as string;
					arrayList_0[num] = text3;
					hashtable_1[num.ToString()] = text3;
					if (text3 != null)
					{
						hashtable_1[text3] = num.ToString();
					}
				}
			}
			arrayList_0.RemoveAt(int_0);
			return result;
		}
		return null;
	}

	[SpecialName]
	public int method_9()
	{
		return int_0;
	}

	public bool method_10(string string_0)
	{
		return hashtable_0.ContainsKey(string_0);
	}

	public void method_11()
	{
		hashtable_0.Clear();
		arrayList_0.Clear();
		hashtable_1.Clear();
		int_0 = 0;
	}
}
