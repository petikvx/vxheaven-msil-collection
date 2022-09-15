using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.WinForms.Drawing;

public class ColorBlendCollection : CollectionBase
{
	public ColorStop this[int index]
	{
		get
		{
			return (ColorStop)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public int Add(ColorStop item)
	{
		return base.List.Add(item);
	}

	public void AddRange(ColorStop[] items)
	{
		foreach (ColorStop item in items)
		{
			Add(item);
		}
	}

	public void Insert(int index, ColorStop value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(ColorStop value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(ColorStop value)
	{
		return base.List.Contains(value);
	}

	public void Remove(ColorStop value)
	{
		base.List.Remove(value);
	}

	public void CopyTo(ColorStop[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_0(ColorStop[] colorStop_0)
	{
		base.List.CopyTo(colorStop_0, 0);
	}

	public ColorBlend GetColorBlend()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ColorBlend val = new ColorBlend();
		Color[] array = new Color[base.Count];
		float[] array2 = new float[base.Count];
		for (int i = 0; i < base.Count; i++)
		{
			ColorStop colorStop = this[i];
			ref Color reference = ref array[i];
			reference = colorStop.Color;
			array2[i] = colorStop.Position;
		}
		val.set_Colors(array);
		val.set_Positions(array2);
		return val;
	}

	public void CopyFrom(ColorBlendCollection col)
	{
		foreach (ColorStop item in col)
		{
			Add(item);
		}
	}

	internal Enum32 method_1()
	{
		if (Count <= 1)
		{
			return Enum32.const_0;
		}
		Enum32 @enum = Enum32.const_0;
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ColorStop colorStop = (ColorStop)enumerator.Current;
				if (colorStop.Position == 0f || colorStop.Position == 1f)
				{
					continue;
				}
				if (colorStop.Position <= 1f)
				{
					switch (@enum)
					{
					case Enum32.const_0:
						@enum = Enum32.const_1;
						break;
					case Enum32.const_2:
						@enum = Enum32.const_0;
						goto end_IL_0066;
					}
				}
				else
				{
					switch (@enum)
					{
					case Enum32.const_0:
						@enum = Enum32.const_2;
						break;
					case Enum32.const_1:
						@enum = Enum32.const_0;
						goto end_IL_0066;
					}
				}
				continue;
				end_IL_0066:
				break;
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
		if (Count == 2 && this[0].Position == 0f && this[1].Position == 1f)
		{
			return Enum32.const_1;
		}
		switch (@enum)
		{
		case Enum32.const_0:
			return @enum;
		case Enum32.const_1:
			if (this[0].Position != 0f && this[Count - 1].Position != 1f)
			{
				return Enum32.const_0;
			}
			break;
		}
		if (@enum == Enum32.const_2 && Count / 2 * 2 != Count)
		{
			return Enum32.const_0;
		}
		return @enum;
	}

	public static void InitializeCollection(ColorBlendCollection collection, Color backColor1, Color backColor2)
	{
		collection.Clear();
		collection.Add(new ColorStop(backColor1, 0f));
		collection.Add(new ColorStop(backColor2, 1f));
	}
}
