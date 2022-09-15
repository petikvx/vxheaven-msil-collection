using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

[DefaultMember("Item")]
internal class Class40 : ICollection
{
	protected ArrayList arrayList_0 = new ArrayList();

	protected ArrayList arrayList_1 = new ArrayList();

	protected object[] object_0;

	protected double[] double_0;

	protected IDictionary idictionary_0 = new Hashtable();

	bool ICollection.IsSynchronized => false;

	int ICollection.Count => arrayList_0.Count;

	object ICollection.SyncRoot => null;

	[SpecialName]
	public object[] method_0()
	{
		method_7();
		return object_0;
	}

	[SpecialName]
	public double[] method_1()
	{
		method_7();
		return double_0;
	}

	public double method_2(object object_1)
	{
		if (idictionary_0.Contains(object_1))
		{
			return (double)arrayList_1[(int)idictionary_0[object_1]];
		}
		return 0.0;
	}

	public void method_3(object object_1, double double_1)
	{
		if (idictionary_0.Contains(object_1))
		{
			method_6();
			arrayList_1[(int)idictionary_0[object_1]] = double_1;
		}
	}

	public void method_4(object object_1, double double_1)
	{
		method_6();
		if (idictionary_0.Contains(object_1))
		{
			arrayList_1[(int)idictionary_0[object_1]] = (double)arrayList_1[(int)idictionary_0[object_1]] + double_1;
			return;
		}
		idictionary_0[object_1] = arrayList_0.Count;
		arrayList_0.Add(object_1);
		arrayList_1.Add(double_1);
	}

	[SpecialName]
	public object method_5(double double_1)
	{
		method_7();
		int num = 0;
		while (true)
		{
			if (num < object_0.Length)
			{
				if (!(double_1 > double_0[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return object_0[num];
	}

	protected void method_6()
	{
		if (object_0 != null)
		{
			object_0 = null;
			double_0 = null;
		}
	}

	protected void method_7()
	{
		if (object_0 != null)
		{
			return;
		}
		object_0 = arrayList_0.ToArray(typeof(object)) as object[];
		double_0 = arrayList_1.ToArray(typeof(double)) as double[];
		if (object_0.Length > 0)
		{
			Array.Sort((Array)double_0, (Array?)object_0);
			Array.Reverse((Array)object_0);
			Array.Reverse((Array)double_0);
			double num = double_0[0];
			for (int i = 1; i < double_0.Length; i++)
			{
				num = (double_0[i] = num + double_0[i]);
			}
			for (int j = 0; j < double_0.Length; j++)
			{
				double[] array;
				double[] array2 = (array = double_0);
				int num2 = j;
				nint num3 = num2;
				array2[num2] = array[num3] / num;
			}
			double_0[double_0.Length - 1] = 1.0;
		}
	}

	public void method_8()
	{
		arrayList_0.Clear();
		arrayList_1.Clear();
		object_0 = null;
		double_0 = null;
		idictionary_0.Clear();
	}

	public static Class40 smethod_0(string string_0, string string_1)
	{
		Class40 @class = null;
		try
		{
			@class = new Class40();
			string[] array = Class49.smethod_0(string_0, string_1);
			string[] array2 = array;
			foreach (string string_2 in array2)
			{
				string[] array3 = Class49.smethod_0(string_2, "[]");
				@class.method_4(array3[0], (array3.Length > 1) ? Class51.smethod_10(array3[1], 1.0) : 1.0);
			}
			return @class;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return @class;
		}
	}

	public string method_9(string string_0)
	{
		method_7();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < object_0.Length; i++)
		{
			stringBuilder.AppendFormat("{0}{1}[{2}]", (stringBuilder.Length == 0) ? "" : string_0, Class51.smethod_8(object_0[i]), Class51.smethod_2(double_0[i]));
		}
		return stringBuilder.ToString();
	}

	public object method_10()
	{
		return method_5(Class51.random_0.NextDouble());
	}

	void ICollection.CopyTo(Array array, int index)
	{
		arrayList_0.CopyTo(array, index);
	}

	public IEnumerator GetEnumerator()
	{
		method_7();
		return object_0.GetEnumerator();
	}
}
