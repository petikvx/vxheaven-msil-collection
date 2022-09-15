using System;
using System.Collections;
using System.IO;
using System.Text;

namespace ns1;

public class GClass0 : IDisposable
{
	public const uint uint_0 = 16u;

	protected Stream stream_0;

	protected string string_0;

	protected byte[] byte_0;

	protected bool bool_0;

	protected ushort ushort_0;

	protected ushort ushort_1;

	protected uint uint_1;

	protected uint uint_2;

	protected uint uint_3;

	protected ushort ushort_2;

	protected ushort ushort_3;

	protected ushort ushort_4;

	protected byte byte_1;

	protected byte byte_2;

	protected uint uint_4;

	protected uint uint_5;

	protected uint uint_6;

	protected uint uint_7;

	protected uint uint_8;

	protected uint uint_9;

	protected uint uint_10;

	protected uint uint_11;

	protected uint uint_12;

	protected ushort ushort_5;

	protected ushort ushort_6;

	protected ushort ushort_7;

	protected ushort ushort_8;

	protected ushort ushort_9;

	protected ushort ushort_10;

	protected uint uint_13;

	protected uint uint_14;

	protected uint uint_15;

	protected uint uint_16;

	protected GEnum0 genum0_0;

	protected ushort ushort_11;

	protected uint uint_17;

	protected uint uint_18;

	protected uint uint_19;

	protected uint uint_20;

	protected uint uint_21;

	protected uint uint_22;

	protected ArrayList arrayList_0;

	protected ArrayList arrayList_1;

	public Stream Stream_0 => stream_0;

	public string String_0
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
		set
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public byte[] Byte_0
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
		set
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public bool Boolean_0
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
		set
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public ushort UInt16_0
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public ushort UInt16_1
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

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

	public ushort UInt16_2
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public ushort UInt16_3
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public ushort UInt16_4
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public byte Byte_1
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public byte Byte_2
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

	public uint UInt32_4
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

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

	public uint UInt32_8
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_9
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_10
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_11
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public ushort UInt16_5
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public ushort UInt16_6
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public ushort UInt16_7
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public ushort UInt16_8
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public ushort UInt16_9
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public ushort UInt16_10
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_12
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_13
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_14
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_15
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public GEnum0 GEnum0_0
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public ushort UInt16_11
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_16
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_17
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_18
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_19
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_20
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public uint UInt32_21
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public IEnumerable IEnumerable_0
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public IEnumerable IEnumerable_1 => arrayList_1;

	public GClass1 method_0(GClass1.GEnum1 genum1_0)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public GClass0(Stream stream_1, string string_1)
	{
		stream_0 = stream_1;
		string_0 = string_1;
		BinaryReader binaryReader_ = new BinaryReader(stream_0, Encoding.ASCII);
		method_4(binaryReader_);
		method_5(binaryReader_);
	}

	public void Dispose()
	{
		if (stream_0 != null)
		{
			stream_0.Close();
		}
	}

	public bool method_1(GClass1.GEnum1 genum1_0)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public uint method_2(uint uint_23)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public BinaryReader method_3(uint uint_23)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	protected void method_4(BinaryReader binaryReader_0)
	{
		if (binaryReader_0.BaseStream.Length < 64L)
		{
			throw new GException0();
		}
		binaryReader_0.BaseStream.Seek(60L, SeekOrigin.Begin);
		uint num = binaryReader_0.ReadUInt32();
		if (num <= 1024)
		{
			binaryReader_0.BaseStream.Seek(0L, SeekOrigin.Begin);
			byte_0 = binaryReader_0.ReadBytes((int)num);
			char[] array = binaryReader_0.ReadChars(4);
			if (array[0] == 'P' && array[1] == 'E' && array[2] == '\0' && array[3] == '\0')
			{
				ushort_0 = binaryReader_0.ReadUInt16();
				ushort_1 = binaryReader_0.ReadUInt16();
				uint_1 = binaryReader_0.ReadUInt32();
				uint_2 = binaryReader_0.ReadUInt32();
				uint_3 = binaryReader_0.ReadUInt32();
				ushort_2 = binaryReader_0.ReadUInt16();
				ushort_3 = binaryReader_0.ReadUInt16();
				if (ushort_0 != 332)
				{
					throw new GException0();
				}
				bool_0 = (ushort_3 & 0x2000) == 0;
				ushort_4 = binaryReader_0.ReadUInt16();
				byte_1 = binaryReader_0.ReadByte();
				byte_2 = binaryReader_0.ReadByte();
				uint_4 = binaryReader_0.ReadUInt32();
				uint_5 = binaryReader_0.ReadUInt32();
				uint_6 = binaryReader_0.ReadUInt32();
				uint_7 = binaryReader_0.ReadUInt32();
				uint_8 = binaryReader_0.ReadUInt32();
				uint_9 = binaryReader_0.ReadUInt32();
				uint_10 = binaryReader_0.ReadUInt32();
				uint_11 = binaryReader_0.ReadUInt32();
				uint_12 = binaryReader_0.ReadUInt32();
				ushort_5 = binaryReader_0.ReadUInt16();
				ushort_6 = binaryReader_0.ReadUInt16();
				ushort_7 = binaryReader_0.ReadUInt16();
				ushort_8 = binaryReader_0.ReadUInt16();
				ushort_9 = binaryReader_0.ReadUInt16();
				ushort_10 = binaryReader_0.ReadUInt16();
				uint_13 = binaryReader_0.ReadUInt32();
				uint_14 = binaryReader_0.ReadUInt32();
				uint_15 = binaryReader_0.ReadUInt32();
				uint_16 = binaryReader_0.ReadUInt32();
				ushort num2 = binaryReader_0.ReadUInt16();
				if (!Enum.IsDefined(typeof(GEnum0), (int)num2))
				{
					throw new GException0();
				}
				genum0_0 = (GEnum0)num2;
				ushort_11 = binaryReader_0.ReadUInt16();
				uint_17 = binaryReader_0.ReadUInt32();
				uint_18 = binaryReader_0.ReadUInt32();
				uint_19 = binaryReader_0.ReadUInt32();
				uint_20 = binaryReader_0.ReadUInt32();
				uint_21 = binaryReader_0.ReadUInt32();
				uint num3 = binaryReader_0.ReadUInt32();
				if (num3 != 16)
				{
					throw new GException0();
				}
				uint_22 = (uint)binaryReader_0.BaseStream.Position;
				return;
			}
			throw new GException0();
		}
		throw new GException0();
	}

	protected void method_5(BinaryReader binaryReader_0)
	{
		arrayList_0 = new ArrayList();
		for (int i = 0; i < 16L; i++)
		{
			arrayList_0.Add(new GClass1(binaryReader_0));
		}
		arrayList_1 = new ArrayList();
		for (int j = 0; j < ushort_1; j++)
		{
			arrayList_1.Add(new GClass2(binaryReader_0));
		}
	}
}
