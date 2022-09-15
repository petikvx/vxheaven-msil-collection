using System;
using ns0;
using ns2;

namespace ns3;

public class GClass3
{
	private const int int_0 = 0;

	private const int int_1 = 1;

	private const int int_2 = 2;

	private const int int_3 = 3;

	private const int int_4 = 4;

	private const int int_5 = 5;

	private const int int_6 = 6;

	private const int int_7 = 7;

	private const int int_8 = 8;

	private const int int_9 = 9;

	private const int int_10 = 10;

	private const int int_11 = 11;

	private const int int_12 = 12;

	private static int[] int_13 = new int[29]
	{
		3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
		15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
		67, 83, 99, 115, 131, 163, 195, 227, 258
	};

	private static int[] int_14 = new int[29]
	{
		0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
		1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
		4, 4, 4, 4, 5, 5, 5, 5, 0
	};

	private static int[] int_15 = new int[30]
	{
		1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
		33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
		1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
	};

	private static int[] int_16 = new int[30]
	{
		0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
		4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
		9, 9, 10, 10, 11, 11, 12, 12, 13, 13
	};

	private int int_17;

	private int int_18;

	private int int_19;

	private int int_20;

	private int int_21;

	private int int_22;

	private bool bool_0;

	private int int_23;

	private int int_24;

	private bool bool_1;

	private GClass4 gclass4_0;

	private GClass5 gclass5_0;

	private Class0 class0_0;

	private GClass6 gclass6_0;

	private GClass6 gclass6_1;

	private GClass11 gclass11_0;

	public bool Boolean_0 => gclass4_0.Boolean_0;

	public bool Boolean_1 => int_17 == 1 && int_19 == 0;

	public bool Boolean_2 => int_17 == 12 && gclass5_0.method_6() == 0;

	public int Int32_0
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public int Int32_1
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public int Int32_2
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public int Int32_3
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public GClass3()
		: this(bool_2: false)
	{
	}

	public GClass3(bool bool_2)
	{
		bool_1 = bool_2;
		gclass11_0 = new GClass11();
		gclass4_0 = new GClass4();
		gclass5_0 = new GClass5();
		int_17 = (bool_2 ? 2 : 0);
	}

	public void method_0()
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	private bool method_1()
	{
		int num = gclass4_0.method_0(16);
		if (num >= 0)
		{
			gclass4_0.method_1(16);
			num = ((num << 8) | (num >> 8)) & 0xFFFF;
			if (num % 31 == 0)
			{
				if ((num & 0xF00) != GClass13.int_4 << 8)
				{
					throw new ApplicationException("Compression Method unknown");
				}
				if (((uint)num & 0x20u) != 0)
				{
					int_17 = 1;
					int_19 = 32;
				}
				else
				{
					int_17 = 2;
				}
				return true;
			}
			throw new ApplicationException("Header checksum illegal");
		}
		return false;
	}

	private bool method_2()
	{
		while (true)
		{
			if (int_19 > 0)
			{
				int num = gclass4_0.method_0(8);
				if (num < 0)
				{
					break;
				}
				gclass4_0.method_1(8);
				int_18 = (int_18 << 8) | num;
				int_19 -= 8;
				continue;
			}
			return false;
		}
		return false;
	}

	private bool method_3()
	{
		int num = gclass5_0.method_5();
		while (num >= 258)
		{
			switch (int_17)
			{
			case 7:
			{
				int num2;
				while (((num2 = gclass6_0.method_1(gclass4_0)) & -256) == 0)
				{
					gclass5_0.method_0(num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					try
					{
						int_20 = int_13[num2 - 257];
						int_19 = int_14[num2 - 257];
					}
					catch (Exception)
					{
						throw new ApplicationException("Illegal rep length code");
					}
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				gclass6_1 = null;
				gclass6_0 = null;
				int_17 = 2;
				return true;
			}
			case 8:
				if (int_19 > 0)
				{
					int_17 = 8;
					int num4 = gclass4_0.method_0(int_19);
					if (num4 < 0)
					{
						return false;
					}
					gclass4_0.method_1(int_19);
					int_20 += num4;
				}
				int_17 = 9;
				goto case 9;
			case 9:
			{
				int num2 = gclass6_1.method_1(gclass4_0);
				if (num2 >= 0)
				{
					try
					{
						int_21 = int_15[num2];
						int_19 = int_16[num2];
					}
					catch (Exception)
					{
						throw new ApplicationException("Illegal rep dist code");
					}
					goto case 10;
				}
				return false;
			}
			case 10:
				if (int_19 > 0)
				{
					int_17 = 10;
					int num3 = gclass4_0.method_0(int_19);
					if (num3 < 0)
					{
						return false;
					}
					gclass4_0.method_1(int_19);
					int_21 += num3;
				}
				break;
			default:
				throw new ApplicationException("Inflater unknown mode");
			}
			gclass5_0.method_2(int_20, int_21);
			num -= int_20;
			int_17 = 7;
		}
		return true;
	}

	private bool method_4()
	{
		while (true)
		{
			if (int_19 > 0)
			{
				int num = gclass4_0.method_0(8);
				if (num < 0)
				{
					break;
				}
				gclass4_0.method_1(8);
				int_18 = (int_18 << 8) | num;
				int_19 -= 8;
				continue;
			}
			if ((int)gclass11_0.imethod_0() == int_18)
			{
				int_17 = 12;
				return false;
			}
			throw new ApplicationException("Adler chksum doesn't match: " + (int)gclass11_0.imethod_0() + " vs. " + int_18);
		}
		return false;
	}

	private bool method_5()
	{
		switch (int_17)
		{
		default:
			throw new ApplicationException("Inflater.Decode unknown mode");
		case 0:
			return method_1();
		case 1:
			return method_2();
		case 2:
		{
			if (bool_0)
			{
				if (!bool_1)
				{
					gclass4_0.method_3();
					int_19 = 32;
					int_17 = 11;
					return true;
				}
				int_17 = 12;
				return false;
			}
			int num = gclass4_0.method_0(3);
			if (num >= 0)
			{
				gclass4_0.method_1(3);
				if (((uint)num & (true ? 1u : 0u)) != 0)
				{
					bool_0 = true;
				}
				switch (num >> 1)
				{
				default:
					throw new ApplicationException("Unknown block type " + num);
				case 0:
					gclass4_0.method_3();
					int_17 = 3;
					break;
				case 1:
					gclass6_0 = GClass6.gclass6_0;
					gclass6_1 = GClass6.gclass6_1;
					int_17 = 7;
					break;
				case 2:
					class0_0 = new Class0();
					int_17 = 6;
					break;
				}
				return true;
			}
			return false;
		}
		case 3:
			if ((int_22 = gclass4_0.method_0(16)) < 0)
			{
				return false;
			}
			gclass4_0.method_1(16);
			int_17 = 4;
			goto case 4;
		case 4:
		{
			int num3 = gclass4_0.method_0(16);
			if (num3 >= 0)
			{
				gclass4_0.method_1(16);
				if (num3 != (int_22 ^ 0xFFFF))
				{
					throw new ApplicationException("broken uncompressed block");
				}
				int_17 = 5;
				goto case 5;
			}
			return false;
		}
		case 5:
		{
			int num2 = gclass5_0.method_3(gclass4_0, int_22);
			int_22 -= num2;
			if (int_22 != 0)
			{
				return !gclass4_0.Boolean_0;
			}
			int_17 = 2;
			return true;
		}
		case 6:
			if (!class0_0.method_0(gclass4_0))
			{
				return false;
			}
			gclass6_0 = class0_0.method_1();
			gclass6_1 = class0_0.method_2();
			int_17 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return method_3();
		case 11:
			return method_4();
		case 12:
			return false;
		}
	}

	public void method_6(byte[] byte_0)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public void method_7(byte[] byte_0, int int_25, int int_26)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public void method_8(byte[] byte_0)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public void method_9(byte[] byte_0, int int_25, int int_26)
	{
		gclass4_0.method_6(byte_0, int_25, int_26);
		int_24 += int_26;
	}

	public int method_10(byte[] byte_0)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public int method_11(byte[] byte_0, int int_25, int int_26)
	{
		if (int_26 < 0)
		{
			throw new ArgumentOutOfRangeException("len < 0");
		}
		if (int_26 != 0)
		{
			int num = 0;
			do
			{
				if (int_17 != 11)
				{
					int num2 = gclass5_0.method_7(byte_0, int_25, int_26);
					gclass11_0.imethod_4(byte_0, int_25, num2);
					int_25 += num2;
					num += num2;
					int_23 += num2;
					int_26 -= num2;
					if (int_26 == 0)
					{
						return num;
					}
				}
			}
			while (method_5() || (gclass5_0.method_6() > 0 && int_17 != 11));
			return num;
		}
		if (!Boolean_2)
		{
			method_5();
		}
		return 0;
	}
}
