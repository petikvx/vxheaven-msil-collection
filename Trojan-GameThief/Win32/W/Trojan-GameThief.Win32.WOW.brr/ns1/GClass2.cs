using System;
using System.IO;

namespace ns1;

public class GClass2
{
	public const uint uint_0 = 40u;

	protected string string_0;

	protected uint uint_1;

	protected uint uint_2;

	protected uint uint_3;

	protected uint uint_4;

	protected uint uint_5;

	protected uint uint_6;

	protected ushort ushort_0;

	protected ushort ushort_1;

	protected uint uint_7;

	public string String_0 => string_0;

	public uint UInt32_0
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_1
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_2
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_3
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_4 => uint_4;

	public uint UInt32_5
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_6
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_7
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public GClass2(BinaryReader binaryReader_0)
	{
		char[] array = binaryReader_0.ReadChars(8);
		int num = 0;
		for (int i = 0; i < 8 && array[i] != 0; i++)
		{
			num++;
		}
		string_0 = new string(array, 0, num);
		uint_1 = binaryReader_0.ReadUInt32();
		uint_2 = binaryReader_0.ReadUInt32();
		uint_3 = binaryReader_0.ReadUInt32();
		uint_4 = binaryReader_0.ReadUInt32();
		uint_5 = binaryReader_0.ReadUInt32();
		uint_6 = binaryReader_0.ReadUInt32();
		ushort_0 = binaryReader_0.ReadUInt16();
		ushort_1 = binaryReader_0.ReadUInt16();
		uint_7 = binaryReader_0.ReadUInt32();
	}
}
