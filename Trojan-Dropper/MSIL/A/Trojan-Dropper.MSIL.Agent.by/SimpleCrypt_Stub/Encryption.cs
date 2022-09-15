using System;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SimpleCrypt_Stub;

public sealed class Encryption
{
	private Encryption()
	{
	}

	public static string Encrypt(string message, string key)
	{
		if ((message == null || message.Length == 0) ? true : false)
		{
			throw new ArgumentNullException("message");
		}
		if ((key == null || key.Length == 0) ? true : false)
		{
			throw new ArgumentNullException("key");
		}
		string empty = string.Empty;
		empty = EnDeCrypt(message, key);
		return StringToHex(empty);
	}

	public static string Decrypt(string message, string key)
	{
		if ((message == null || message.Length == 0) ? true : false)
		{
			throw new ArgumentNullException("message");
		}
		if ((key == null || key.Length == 0) ? true : false)
		{
			throw new ArgumentNullException("key");
		}
		string empty = string.Empty;
		empty = HexToString(message);
		return EnDeCrypt(empty, key);
	}

	private static string EnDeCrypt(string message, string password)
	{
		int num = 0;
		int num2 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		string empty = string.Empty;
		int[] array = new int[257];
		int[] array2 = new int[257];
		int length = password.Length;
		int location = 0;
		while (location <= 255)
		{
			char c = password.Substring(location % length, 1).ToCharArray()[0];
			array2[location] = Strings.Asc(c);
			array[location] = location;
			Math.Max(Interlocked.Increment(ref location), checked(location - 1));
		}
		int num3 = 0;
		int location2 = 0;
		while (location2 <= 255)
		{
			num3 = checked(num3 + array[location2] + array2[location2]) % 256;
			int num4 = array[location2];
			array[location2] = array[num3];
			array[num3] = num4;
			Math.Max(Interlocked.Increment(ref location2), checked(location2 - 1));
		}
		location = 1;
		while (location <= message.Length)
		{
			int num5 = 0;
			num = checked(num + 1) % 256;
			num2 = checked(num2 + array[num]) % 256;
			num5 = array[num];
			array[num] = array[num2];
			array[num2] = num5;
			int num6 = array[checked(array[num] + array[num2]) % 256];
			checked
			{
				char c2 = message.Substring(location - 1, 1).ToCharArray()[0];
				num5 = Strings.Asc(c2);
				int num7 = num5 ^ num6;
				stringBuilder.Append(Strings.Chr(num7));
				Math.Max(Interlocked.Increment(ref location), location - 1);
			}
		}
		empty = stringBuilder.ToString();
		stringBuilder.Length = 0;
		return empty;
	}

	private static string StringToHex(string message)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string empty = string.Empty;
		long num = Strings.Len(message);
		long num2 = num;
		long num3 = 1L;
		checked
		{
			while (true)
			{
				long num4 = num3;
				long num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				stringBuilder.Append(Strings.Right("0" + Conversion.Hex(Strings.Asc(Strings.Mid(message, (int)num3, 1))), 2));
				num3++;
			}
			empty = stringBuilder.ToString();
			stringBuilder.Length = 0;
			return empty;
		}
	}

	private static string HexToString(string hex)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string empty = string.Empty;
		long num = Strings.Len(hex);
		long num2 = num;
		long num3 = 1L;
		checked
		{
			while (true)
			{
				long num4 = num3;
				long num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				stringBuilder.Append(Strings.Chr(Conversions.ToInteger("&h" + Strings.Mid(hex, (int)num3, 2))));
				num3 += 2L;
			}
			empty = stringBuilder.ToString();
			stringBuilder.Length = 0;
			return empty;
		}
	}
}
