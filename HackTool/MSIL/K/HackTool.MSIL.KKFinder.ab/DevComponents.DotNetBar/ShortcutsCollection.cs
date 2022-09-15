using System.Collections;
using System.Text;
using System.Xml;

namespace DevComponents.DotNetBar;

public class ShortcutsCollection : CollectionBase
{
	private BaseItem baseItem_0;

	public eShortcut this[int index]
	{
		get
		{
			return (eShortcut)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	internal BaseItem BaseItem_0
	{
		get
		{
			return baseItem_0;
		}
		set
		{
			baseItem_0 = value;
			if (baseItem_0 != null)
			{
				baseItem_0.method_12();
			}
		}
	}

	public ShortcutsCollection(BaseItem parent)
	{
		baseItem_0 = parent;
	}

	public int Add(eShortcut key)
	{
		int num = 0;
		return base.List.Add(key);
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
		method_0();
	}

	public void Insert(int index, eShortcut value)
	{
		base.List.Insert(index, value);
		method_0();
	}

	public int IndexOf(eShortcut value)
	{
		return base.List.IndexOf(value);
	}

	public string ToString(string Delimiter)
	{
		if (base.List.Count == 0)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder(base.List.Count * (2 + Delimiter.Length));
		int num = base.List.Count - 1;
		for (int i = 0; i < num; i++)
		{
			stringBuilder.Append((int)base.List[i] + Delimiter);
		}
		stringBuilder.Append(((int)base.List[num]).ToString());
		return stringBuilder.ToString();
	}

	public void FromString(string Data, string Delimiter)
	{
		base.List.Clear();
		string[] array = Data.Split(Delimiter.ToCharArray());
		string[] array2 = array;
		foreach (string s in array2)
		{
			base.List.Add((eShortcut)XmlConvert.ToInt32(s));
		}
	}

	public bool Contains(eShortcut value)
	{
		return base.List.Contains(value);
	}

	public void Remove(eShortcut value)
	{
		base.List.Remove(value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		base.OnRemoveComplete(index, value);
		method_0();
	}

	protected override void OnClear()
	{
		base.OnClear();
		method_1();
	}

	public void CopyTo(eShortcut[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	private void method_0()
	{
		if (baseItem_0 != null)
		{
			baseItem_0.method_12();
		}
		IOwner owner = null;
		if (baseItem_0 != null)
		{
			owner = baseItem_0.GetOwner() as IOwner;
		}
		if (baseItem_0 != null && owner != null)
		{
			owner.RemoveShortcutsFromItem(baseItem_0);
			owner.AddShortcutsFromItem(baseItem_0);
		}
	}

	private void method_1()
	{
		IOwner owner = null;
		if (baseItem_0 != null)
		{
			owner = baseItem_0.GetOwner() as IOwner;
		}
		if (baseItem_0 != null)
		{
			owner?.RemoveShortcutsFromItem(baseItem_0);
		}
	}
}
