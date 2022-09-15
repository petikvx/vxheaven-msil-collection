using System;

namespace ns3;

public class GClass7
{
	public class GClass8
	{
		public short[] short_0;

		public byte[] byte_0;

		public int int_0;

		public int int_1;

		private short[] short_1;

		private int[] int_2;

		private int int_3;

		private GClass7 gclass7_0;

		public GClass8(GClass7 gclass7_1, int int_4, int int_5, int int_6)
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}

		public void method_0()
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}

		public void method_1(int int_4)
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}

		public void method_2()
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}

		public void method_3(short[] short_2, byte[] byte_1)
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}

		public void method_4()
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}

		private void method_5(int[] int_4)
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}

		public void method_6()
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}

		public int method_7()
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}

		public void method_8(GClass8 gclass8_0)
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}

		public void method_9(GClass8 gclass8_0)
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	private static int int_0;

	private static int int_1;

	private static int int_2;

	private static int int_3;

	private static int int_4;

	private static int int_5;

	private static int int_6;

	private static int int_7;

	private static int[] int_8;

	private static byte[] byte_0;

	public GClass10 gclass10_0;

	private GClass8 gclass8_0;

	private GClass8 gclass8_1;

	private GClass8 gclass8_2;

	private short[] short_0;

	private byte[] byte_1;

	private int int_9;

	private int int_10;

	private static short[] short_1;

	private static byte[] byte_2;

	private static short[] short_2;

	private static byte[] byte_3;

	public static short smethod_0(int int_11)
	{
		return (short)((byte_0[int_11 & 0xF] << 12) | (byte_0[(int_11 >> 4) & 0xF] << 8) | (byte_0[(int_11 >> 8) & 0xF] << 4) | byte_0[int_11 >> 12]);
	}

	static GClass7()
	{
		int_0 = 16384;
		int_1 = 286;
		int_2 = 30;
		int_3 = 19;
		int_4 = 16;
		int_5 = 17;
		int_6 = 18;
		int_7 = 256;
		int_8 = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};
		byte_0 = new byte[16]
		{
			0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
			5, 13, 3, 11, 7, 15
		};
		short_1 = new short[int_1];
		byte_2 = new byte[int_1];
		int num = 0;
		while (num < 144)
		{
			short_1[num] = smethod_0(48 + num << 8);
			byte_2[num++] = 8;
		}
		while (num < 256)
		{
			short_1[num] = smethod_0(256 + num << 7);
			byte_2[num++] = 9;
		}
		while (num < 280)
		{
			short_1[num] = smethod_0(-256 + num << 9);
			byte_2[num++] = 7;
		}
		while (num < int_1)
		{
			short_1[num] = smethod_0(-88 + num << 8);
			byte_2[num++] = 8;
		}
		short_2 = new short[int_2];
		byte_3 = new byte[int_2];
		for (num = 0; num < int_2; num++)
		{
			short_2[num] = smethod_0(num << 11);
			byte_3[num] = 5;
		}
	}

	public GClass7(GClass10 gclass10_1)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public void method_0()
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	private int method_1(int int_11)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	private int method_2(int int_11)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public void method_3(int int_11)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public void method_4()
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public void method_5(byte[] byte_4, int int_11, int int_12, bool bool_0)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public void method_6(byte[] byte_4, int int_11, int int_12, bool bool_0)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public bool method_7()
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public bool method_8(int int_11)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public bool method_9(int int_11, int int_12)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}
}
