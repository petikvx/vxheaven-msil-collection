using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
internal class Class34 : ICollection
{
	protected ArrayList arrayList_0 = new ArrayList();

	protected ArrayList arrayList_1 = new ArrayList();

	protected object[] object_0;

	protected double[] double_0;

	bool ICollection.IsSynchronized => false;

	int ICollection.Count => arrayList_0.Count;

	object ICollection.SyncRoot => null;

	[SpecialName]
	public object[] method_0()
	{
		method_6();
		return object_0;
	}

	[SpecialName]
	public double[] method_1()
	{
		method_6();
		return double_0;
	}

	public void method_2(object object_1, double double_1)
	{
		method_5();
		arrayList_0.Add(object_1);
		arrayList_1.Add(double_1);
	}

	[SpecialName]
	public object method_3(int int_0)
	{
		method_6();
		return object_0[int_0];
	}

	[SpecialName]
	public object method_4(double double_1)
	{
		method_6();
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

	protected void method_5()
	{
		if (object_0 != null)
		{
			object_0 = null;
			double_0 = null;
		}
	}

	protected void method_6()
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

	public void method_7()
	{
		arrayList_0.Clear();
		arrayList_1.Clear();
		object_0 = null;
		double_0 = null;
	}

	string object.ToString()
	{
		return base.ToString();
	}

	void ICollection.CopyTo(Array array, int index)
	{
		arrayList_0.CopyTo(array, index);
	}

	public IEnumerator GetEnumerator()
	{
		method_6();
		return object_0.GetEnumerator();
	}
}
