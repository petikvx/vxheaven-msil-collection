using System;

namespace ns2;

public class GClass5
{
	private static int int_0 = 32768;

	private static int int_1 = int_0 - 1;

	private byte[] byte_0 = new byte[int_0];

	private int int_2 = 0;

	private int int_3 = 0;

	public void method_0(int int_4)
	{
		if (int_3++ == int_0)
		{
			throw new InvalidOperationException("Window full");
		}
		byte_0[int_2++] = (byte)int_4;
		int_2 &= int_1;
	}

	private void method_1(int int_4, int int_5, int int_6)
	{
		while (int_5-- > 0)
		{
			byte_0[int_2++] = byte_0[int_4++];
			int_2 &= int_1;
			int_4 &= int_1;
		}
	}

	public void method_2(int int_4, int int_5)
	{
		if ((int_3 += int_4) > int_0)
		{
			throw new InvalidOperationException("Window full");
		}
		int num = (int_2 - int_5) & int_1;
		int num2 = int_0 - int_4;
		if (num <= num2 && int_2 < num2)
		{
			if (int_4 > int_5)
			{
				while (int_4-- > 0)
				{
					byte_0[int_2++] = byte_0[num++];
				}
			}
			else
			{
				Array.Copy(byte_0, num, byte_0, int_2, int_4);
				int_2 += int_4;
			}
		}
		else
		{
			method_1(num, int_4, int_5);
		}
	}

	public int method_3(GClass4 gclass4_0, int int_4)
	{
		int_4 = Math.Min(Math.Min(int_4, int_0 - int_3), gclass4_0.Int32_1);
		int num = int_0 - int_2;
		int num2;
		if (int_4 <= num)
		{
			num2 = gclass4_0.method_4(byte_0, int_2, int_4);
		}
		else
		{
			num2 = gclass4_0.method_4(byte_0, int_2, num);
			if (num2 == num)
			{
				num2 += gclass4_0.method_4(byte_0, 0, int_4 - num);
			}
		}
		int_2 = (int_2 + num2) & int_1;
		int_3 += num2;
		return num2;
	}

	public void method_4(byte[] byte_1, int int_4, int int_5)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public int method_5()
	{
		return int_0 - int_3;
	}

	public int method_6()
	{
		return int_3;
	}

	public int method_7(byte[] byte_1, int int_4, int int_5)
	{
		int num = int_2;
		if (int_5 <= int_3)
		{
			num = (int_2 - int_3 + int_5) & int_1;
		}
		else
		{
			int_5 = int_3;
		}
		int num2 = int_5;
		int num3 = int_5 - num;
		if (num3 > 0)
		{
			Array.Copy(byte_0, int_0 - num3, byte_1, int_4, num3);
			int_4 += num3;
			int_5 = num;
		}
		Array.Copy(byte_0, num - int_5, byte_1, int_4, int_5);
		int_3 -= num2;
		if (int_3 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	public void method_8()
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}
}
