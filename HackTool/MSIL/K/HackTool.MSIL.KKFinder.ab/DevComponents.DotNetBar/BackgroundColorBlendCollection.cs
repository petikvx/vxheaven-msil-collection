using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar;

public class BackgroundColorBlendCollection : CollectionBase
{
	private ElementStyle elementStyle_0;

	internal ElementStyle ElementStyle_0
	{
		get
		{
			return elementStyle_0;
		}
		set
		{
			elementStyle_0 = value;
		}
	}

	public BackgroundColorBlend this[int index]
	{
		get
		{
			return (BackgroundColorBlend)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public int Add(BackgroundColorBlend item)
	{
		return base.List.Add(item);
	}

	public void AddRange(BackgroundColorBlend[] items)
	{
		foreach (BackgroundColorBlend item in items)
		{
			Add(item);
		}
	}

	public void Insert(int index, BackgroundColorBlend value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(BackgroundColorBlend value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(BackgroundColorBlend value)
	{
		return base.List.Contains(value);
	}

	public void Remove(BackgroundColorBlend value)
	{
		base.List.Remove(value);
	}

	public void CopyTo(BackgroundColorBlend[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_0(BackgroundColorBlend[] backgroundColorBlend_0)
	{
		base.List.CopyTo(backgroundColorBlend_0, 0);
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
			BackgroundColorBlend backgroundColorBlend = this[i];
			ref Color reference = ref array[i];
			reference = backgroundColorBlend.Color;
			array2[i] = backgroundColorBlend.Position;
		}
		val.set_Colors(array);
		val.set_Positions(array2);
		return val;
	}

	public void CopyFrom(BackgroundColorBlendCollection col)
	{
		foreach (BackgroundColorBlend item in col)
		{
			Add(item);
		}
	}

	internal Enum11 method_1()
	{
		if (Count <= 1)
		{
			return Enum11.const_0;
		}
		Enum11 @enum = Enum11.const_0;
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				BackgroundColorBlend backgroundColorBlend = (BackgroundColorBlend)enumerator.Current;
				if (backgroundColorBlend.Position == 0f || backgroundColorBlend.Position == 1f)
				{
					continue;
				}
				if (backgroundColorBlend.Position <= 1f)
				{
					switch (@enum)
					{
					case Enum11.const_0:
						@enum = Enum11.const_1;
						break;
					case Enum11.const_2:
						@enum = Enum11.const_0;
						goto end_IL_0066;
					}
				}
				else
				{
					switch (@enum)
					{
					case Enum11.const_0:
						@enum = Enum11.const_2;
						break;
					case Enum11.const_1:
						@enum = Enum11.const_0;
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
			return Enum11.const_1;
		}
		switch (@enum)
		{
		case Enum11.const_0:
			return @enum;
		case Enum11.const_1:
			if (this[0].Position != 0f && this[Count - 1].Position != 1f)
			{
				return Enum11.const_0;
			}
			break;
		}
		if (@enum == Enum11.const_2 && Count / 2 * 2 != Count)
		{
			return Enum11.const_0;
		}
		return @enum;
	}

	public static void InitializeCollection(BackgroundColorBlendCollection collection, int backColor1, int backColor2)
	{
		InitializeCollection(collection, ColorScheme.GetColor(backColor1), ColorScheme.GetColor(backColor2));
	}

	public static void InitializeCollection(BackgroundColorBlendCollection collection, Color backColor1, Color backColor2)
	{
		collection.Clear();
		collection.Add(new BackgroundColorBlend(backColor1, 0f));
		collection.Add(new BackgroundColorBlend(backColor2, 1f));
	}
}
