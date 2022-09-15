using System;
using System.IO;

namespace ns1;

public class GClass1
{
	public enum GEnum1
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10,
		const_11,
		const_12,
		const_13,
		const_14,
		const_15
	}

	public const uint uint_0 = 8u;

	protected uint uint_1;

	protected uint uint_2;

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

	public GClass1(BinaryReader binaryReader_0)
	{
		uint_1 = binaryReader_0.ReadUInt32();
		uint_2 = binaryReader_0.ReadUInt32();
	}

	public void method_0(BinaryWriter binaryWriter_0)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public static void smethod_0(BinaryWriter binaryWriter_0)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public static void smethod_1(uint uint_3, uint uint_4, BinaryWriter binaryWriter_0)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}
}
