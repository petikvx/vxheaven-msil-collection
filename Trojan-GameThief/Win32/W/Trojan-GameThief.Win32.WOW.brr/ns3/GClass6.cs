using System;
using ns2;

namespace ns3;

public class GClass6
{
	private static int int_0;

	private short[] short_0;

	public static GClass6 gclass6_0;

	public static GClass6 gclass6_1;

	static GClass6()
	{
		int_0 = 15;
		try
		{
			byte[] array = new byte[288];
			int num = 0;
			while (num < 144)
			{
				array[num++] = 8;
			}
			while (num < 256)
			{
				array[num++] = 9;
			}
			while (num < 280)
			{
				array[num++] = 7;
			}
			while (num < 288)
			{
				array[num++] = 8;
			}
			gclass6_0 = new GClass6(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			gclass6_1 = new GClass6(array);
		}
		catch (Exception)
		{
			throw new ApplicationException("InflaterHuffmanTree: static tree length illegal");
		}
	}

	public GClass6(byte[] byte_0)
	{
		method_0(byte_0);
	}

	private void method_0(byte[] byte_0)
	{
		int[] array = new int[int_0 + 1];
		int[] array2 = new int[int_0 + 1];
		foreach (int num in byte_0)
		{
			if (num > 0)
			{
				int[] array3;
				int[] array4 = (array3 = array);
				nint num2 = num;
				array4[num] = array3[num2] + 1;
			}
		}
		int num3 = 0;
		int num4 = 512;
		for (int j = 1; j <= int_0; j++)
		{
			array2[j] = num3;
			num3 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num5 = array2[j] & 0x1FF80;
				int num6 = num3 & 0x1FF80;
				num4 += num6 - num5 >> 16 - j;
			}
		}
		short_0 = new short[num4];
		int num7 = 512;
		for (int num8 = int_0; num8 >= 10; num8--)
		{
			int num9 = num3 & 0x1FF80;
			num3 -= array[num8] << 16 - num8;
			int num10 = num3 & 0x1FF80;
			for (int k = num10; k < num9; k += 128)
			{
				short_0[GClass7.smethod_0(k)] = (short)((-num7 << 4) | num8);
				num7 += 1 << num8 - 9;
			}
		}
		for (int l = 0; l < byte_0.Length; l++)
		{
			int num11 = byte_0[l];
			if (num11 == 0)
			{
				continue;
			}
			num3 = array2[num11];
			int num12 = GClass7.smethod_0(num3);
			if (num11 <= 9)
			{
				do
				{
					short_0[num12] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < 512);
			}
			else
			{
				int num13 = short_0[num12 & 0x1FF];
				int num14 = 1 << (num13 & 0xF);
				num13 = -(num13 >> 4);
				do
				{
					short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < num14);
			}
			array2[num11] = num3 + (1 << 16 - num11);
		}
	}

	public int method_1(GClass4 gclass4_0)
	{
		int num;
		int num2;
		if ((num = gclass4_0.method_0(9)) >= 0)
		{
			if ((num2 = short_0[num]) >= 0)
			{
				gclass4_0.method_1(num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = gclass4_0.method_0(int_)) >= 0)
			{
				num2 = short_0[num3 | (num >> 9)];
				gclass4_0.method_1(num2 & 0xF);
				return num2 >> 4;
			}
			int int32_ = gclass4_0.Int32_0;
			num = gclass4_0.method_0(int32_);
			num2 = short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int32_)
			{
				gclass4_0.method_1(num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int32_2 = gclass4_0.Int32_0;
		num = gclass4_0.method_0(int32_2);
		num2 = short_0[num];
		if (num2 < 0 || (num2 & 0xF) > int32_2)
		{
			return -1;
		}
		gclass4_0.method_1(num2 & 0xF);
		return num2 >> 4;
	}
}
