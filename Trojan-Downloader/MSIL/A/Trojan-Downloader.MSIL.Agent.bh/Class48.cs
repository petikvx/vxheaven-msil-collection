using System;
using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

[Serializable]
[DefaultMember("Item")]
internal class Class48 : StringDictionary, ISerializable
{
	public Class48(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		ArrayList arrayList = serializationInfo_0.GetValue("keys", typeof(ArrayList)) as ArrayList;
		ArrayList arrayList2 = serializationInfo_0.GetValue("values", typeof(ArrayList)) as ArrayList;
		for (int i = 0; i < arrayList.Count; i++)
		{
			vmethod_1(arrayList[i] as string, arrayList2[i] as string);
		}
	}

	public Class48()
	{
	}

	public Class48(string string_0)
	{
		vmethod_0(string_0);
	}

	public virtual void vmethod_0(string string_0)
	{
		if (string_0 != null)
		{
			string[] array = Class49.smethod_0(string_0, ";");
			string[] array2 = array;
			foreach (string string_ in array2)
			{
				string[] array3 = Class49.smethod_0(string_, "=");
				base.Add(array3[0], (array3.Length > 1) ? array3[1] : null);
			}
		}
	}

	public virtual void vmethod_1(object object_0, string string_0)
	{
		base.Add(object_0.ToString(), string_0);
	}

	public virtual bool vmethod_2(object object_0)
	{
		return base.ContainsKey(object_0.ToString());
	}

	[SpecialName]
	public virtual string vmethod_3(object object_0)
	{
		return base[object_0.ToString()];
	}

	[SpecialName]
	public virtual void vmethod_4(object object_0, string string_0)
	{
		base[object_0.ToString()] = string_0;
	}

	public virtual void vmethod_5(string string_0, bool bool_0)
	{
		if (string_0 == null)
		{
			return;
		}
		string[] array = Class49.smethod_0(string_0, ";");
		string[] array2 = array;
		foreach (string string_ in array2)
		{
			string[] array3 = Class49.smethod_0(string_, "=");
			if (vmethod_2(array3[0]))
			{
				if (bool_0)
				{
					vmethod_4(array3[0], (array3.Length > 1) ? array3[1] : null);
				}
			}
			else
			{
				base.Add(array3[0], (array3.Length > 1) ? array3[1] : null);
			}
		}
	}

	public virtual void vmethod_6(string string_0)
	{
		vmethod_5(string_0, bool_0: true);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)enumerator.Current;
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(";");
				}
				stringBuilder.AppendFormat("{0}={1}", dictionaryEntry.Key, dictionaryEntry.Value);
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		return stringBuilder.ToString();
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = new ArrayList();
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)enumerator.Current;
				arrayList.Add(dictionaryEntry.Key);
				arrayList2.Add(dictionaryEntry.Value);
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		info.AddValue("keys", arrayList);
		info.AddValue("values", arrayList2);
	}
}
