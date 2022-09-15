using System;
using System.Collections;

namespace DevComponents.Editors;

internal class Class276 : IEnumerable, IEnumerator
{
	private IList ilist_0;

	private int int_0 = -1;

	private int int_1 = 1;

	private int int_2 = -1;

	private int int_3 = -1;

	public object Current
	{
		get
		{
			if (int_0 < 0)
			{
				throw new InvalidOperationException("IEnumerator Pointer is invalid. Use MoveNext to advance enumerator.");
			}
			return ilist_0[int_0];
		}
	}

	internal int Int32_0
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	public Class276(VisualItemCollection parentCollection, bool rightToLeft)
	{
		ilist_0 = parentCollection;
		if (rightToLeft)
		{
			int_1 = -1;
			int_2 = parentCollection.Count - 1;
			int_3 = -1;
		}
		else
		{
			int_2 = 0;
			int_3 = parentCollection.Count;
		}
	}

	public IEnumerator GetEnumerator()
	{
		return this;
	}

	public bool MoveNext()
	{
		if (int_0 == int_3 && int_0 >= 0)
		{
			throw new InvalidOperationException("Enumerator cannot advance beyond the boundaries of array. Use Reset to reset enumerator");
		}
		if (int_0 == -1)
		{
			int_0 = int_2 - int_1;
		}
		int_0 += int_1;
		if (int_0 == int_3)
		{
			return false;
		}
		return true;
	}

	public void Reset()
	{
		int_0 = -1;
	}
}
