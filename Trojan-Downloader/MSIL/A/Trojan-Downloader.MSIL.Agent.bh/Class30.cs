using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
internal class Class30
{
	protected IDictionary idictionary_0 = new Hashtable();

	protected ArrayList arrayList_0 = new ArrayList();

	protected IDictionary idictionary_1 = new Hashtable();

	protected int int_0 = 0;

	[SpecialName]
	public object method_0(int int_1)
	{
		return method_2(Class51.smethod_3(int_1));
	}

	[SpecialName]
	public void method_1(int int_1, object object_0)
	{
		method_3(Class51.smethod_3(int_1), object_0);
	}

	[SpecialName]
	public object method_2(string string_0)
	{
		return idictionary_0[string_0];
	}

	[SpecialName]
	public void method_3(string string_0, object object_0)
	{
		lock (this)
		{
			if (idictionary_0.Contains(string_0))
			{
				idictionary_0[string_0] = object_0;
				if (idictionary_1[string_0] is string key)
				{
					idictionary_0[key] = object_0;
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
			string key = Class51.smethod_3(int_0++);
			arrayList_0.Add(null);
			idictionary_0.Add(key, object_0);
		}
	}

	public void method_6(string string_0, object object_0)
	{
		lock (this)
		{
			string text = Class51.smethod_3(int_0++);
			arrayList_0.Add(string_0);
			idictionary_0.Add(text, object_0);
			idictionary_0.Add(string_0, object_0);
			idictionary_1.Add(text, string_0);
			idictionary_1.Add(string_0, text);
		}
	}

	public object method_7(int int_1)
	{
		return method_8(Class51.smethod_3(int_1));
	}

	public object method_8(string string_0)
	{
		if (idictionary_0.Contains(string_0))
		{
			int_0--;
			object result = idictionary_0[string_0];
			idictionary_0.Remove(string_0);
			string text = idictionary_1[string_0] as string;
			if (text != null)
			{
				idictionary_0.Remove(text);
				idictionary_1.Remove(string_0);
				idictionary_1.Remove(text);
			}
			if (int_0 > 0)
			{
				string text2 = Class51.smethod_3(int_0);
				if (string_0 != text2 && text != text2)
				{
					int num = Class51.smethod_9(string_0, -1);
					if (num == -1)
					{
						num = Class51.smethod_9(text, -1);
					}
					string text3 = arrayList_0[int_0] as string;
					arrayList_0[num] = text3;
					idictionary_1[Class51.smethod_3(num)] = text3;
					if (text3 != null)
					{
						idictionary_1[text3] = Class51.smethod_3(num);
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
		return idictionary_0.Contains(string_0);
	}

	public void method_11()
	{
		idictionary_0.Clear();
		arrayList_0.Clear();
		idictionary_1.Clear();
		int_0 = 0;
	}
}
