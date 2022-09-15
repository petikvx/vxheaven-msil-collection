using System;

namespace ns2;

public class GClass4
{
	private byte[] byte_0;

	private int int_0 = 0;

	private int int_1 = 0;

	private uint uint_0 = 0u;

	private int int_2 = 0;

	public int Int32_0 => int_2;

	public int Int32_1 => int_1 - int_0 + (int_2 >> 3);

	public bool Boolean_0 => int_0 == int_1;

	public int method_0(int int_3)
	{
		if (int_2 < int_3)
		{
			if (int_0 == int_1)
			{
				return -1;
			}
			uint_0 |= (uint)(((byte_0[int_0++] & 0xFF) | ((byte_0[int_0++] & 0xFF) << 8)) << int_2);
			int_2 += 16;
		}
		return (int)(uint_0 & ((1 << int_3) - 1));
	}

	public void method_1(int int_3)
	{
		uint_0 >>= int_3;
		int_2 -= int_3;
	}

	public int method_2(int int_3)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public void method_3()
	{
		uint_0 >>= int_2 & 7;
		int_2 &= -8;
	}

	public int method_4(byte[] byte_1, int int_3, int int_4)
	{
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException("length", "negative");
		}
		if (((uint)int_2 & 7u) != 0)
		{
			throw new InvalidOperationException("Bit buffer is not byte aligned!");
		}
		int num = 0;
		while (int_2 > 0 && int_4 > 0)
		{
			byte_1[int_3++] = (byte)uint_0;
			uint_0 >>= 8;
			int_2 -= 8;
			int_4--;
			num++;
		}
		if (int_4 != 0)
		{
			int num2 = int_1 - int_0;
			if (int_4 > num2)
			{
				int_4 = num2;
			}
			Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
			int_0 += int_4;
			if (((uint)(int_0 - int_1) & (true ? 1u : 0u)) != 0)
			{
				uint_0 = byte_0[int_0++] & 0xFFu;
				int_2 = 8;
			}
			return num + int_4;
		}
		return num;
	}

	public void method_5()
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public void method_6(byte[] byte_1, int int_3, int int_4)
	{
		if (int_0 < int_1)
		{
			throw new InvalidOperationException("Old input was not completely processed");
		}
		int num = int_3 + int_4;
		if (0 <= int_3 && int_3 <= num && num <= byte_1.Length)
		{
			if (((uint)int_4 & (true ? 1u : 0u)) != 0)
			{
				uint_0 |= (uint)((byte_1[int_3++] & 0xFF) << int_2);
				int_2 += 8;
			}
			byte_0 = byte_1;
			int_0 = int_3;
			int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}
}
