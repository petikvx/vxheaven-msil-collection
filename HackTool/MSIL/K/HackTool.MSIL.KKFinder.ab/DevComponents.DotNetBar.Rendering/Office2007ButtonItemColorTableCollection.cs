using System.Collections;

namespace DevComponents.DotNetBar.Rendering;

public class Office2007ButtonItemColorTableCollection : CollectionBase
{
	private Hashtable hashtable_0 = new Hashtable();

	public Office2007ButtonItemColorTable this[int index]
	{
		get
		{
			return (Office2007ButtonItemColorTable)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public Office2007ButtonItemColorTable this[string name] => hashtable_0[name] as Office2007ButtonItemColorTable;

	public int Add(Office2007ButtonItemColorTable colorTable)
	{
		return base.List.Add(colorTable);
	}

	public void Insert(int index, Office2007ButtonItemColorTable value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(Office2007ButtonItemColorTable value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(Office2007ButtonItemColorTable value)
	{
		return base.List.Contains(value);
	}

	public bool Contains(string name)
	{
		return hashtable_0.ContainsKey(name);
	}

	public void Remove(Office2007ButtonItemColorTable value)
	{
		base.List.Remove(value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		base.OnRemoveComplete(index, value);
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = value as Office2007ButtonItemColorTable;
		hashtable_0.Remove(office2007ButtonItemColorTable.Name);
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = value as Office2007ButtonItemColorTable;
		hashtable_0.Add(office2007ButtonItemColorTable.Name, office2007ButtonItemColorTable);
	}

	public void CopyTo(Office2007ButtonItemColorTable[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_0(Office2007ButtonItemColorTable[] office2007ButtonItemColorTable_0)
	{
		base.List.CopyTo(office2007ButtonItemColorTable_0, 0);
	}

	protected override void OnClear()
	{
		hashtable_0.Clear();
		base.OnClear();
	}
}
