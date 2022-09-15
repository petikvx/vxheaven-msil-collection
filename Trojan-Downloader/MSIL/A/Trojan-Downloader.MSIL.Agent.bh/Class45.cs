using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class Class45
{
	public static byte[] smethod_0(string string_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	public static string smethod_1(byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public static byte[] smethod_2(byte[] byte_0)
	{
		SHA512Managed sHA512Managed = new SHA512Managed();
		return sHA512Managed.ComputeHash(byte_0);
	}

	public static byte[] smethod_3(string string_0)
	{
		return smethod_2(smethod_0(string_0));
	}

	public static byte[] smethod_4(byte[] byte_0)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		return mD.ComputeHash(byte_0);
	}

	public static byte[] smethod_5(string string_0)
	{
		return smethod_4(smethod_0(string_0));
	}

	public static string smethod_6(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	public static byte[] smethod_7(string string_0)
	{
		return Convert.FromBase64String(string_0);
	}

	public static byte[][] smethod_8()
	{
		char[] chars = "IT Worx Inc".ToCharArray();
		byte[] sourceArray = smethod_4(Encoding.Default.GetBytes(chars));
		byte[][] array = new byte[2][]
		{
			new byte[8],
			null
		};
		Array.Copy(sourceArray, 0, array[0], 0, 8);
		array[1] = new byte[8];
		Array.Copy(sourceArray, 8, array[1], 0, 8);
		return array;
	}

	public static byte[] smethod_9(byte[] byte_0, byte[] byte_1, string string_0)
	{
		DES dES = new DESCryptoServiceProvider();
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, dES.CreateEncryptor(byte_0, byte_1), CryptoStreamMode.Write);
		byte[] array = smethod_0(string_0);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static string smethod_10(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		DES dES = new DESCryptoServiceProvider();
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(byte_2, 0, byte_2.Length);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, dES.CreateDecryptor(byte_0, byte_1), CryptoStreamMode.Read);
		byte[] array = new byte[128];
		int num = 0;
		ArrayList arrayList = new ArrayList();
		do
		{
			num = cryptoStream.Read(array, 0, 128);
			if (num > 0)
			{
				byte[] array2 = new byte[num];
				Array.Copy(array, 0, array2, 0, num);
				arrayList.AddRange(array2);
			}
		}
		while (num > 0);
		cryptoStream.Close();
		memoryStream.Close();
		return smethod_1(arrayList.ToArray(typeof(byte)) as byte[]);
	}

	public static byte[] smethod_11(string string_0)
	{
		byte[][] array = smethod_8();
		return smethod_9(array[0], array[1], string_0);
	}

	public static string smethod_12(byte[] byte_0)
	{
		byte[][] array = smethod_8();
		return smethod_10(array[0], array[1], byte_0);
	}

	public static string smethod_13(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder(int_0);
		Random random = new Random();
		char c = '\0';
		bool flag = false;
		for (int i = 0; i < int_0; i++)
		{
			do
			{
				c = (char)random.Next(33, 127);
				if (c >= '0' && c <= '9')
				{
					flag = true;
				}
			}
			while ((i == int_0 - 1 && !flag) || ((c < '0' || c > '9') && (c < 'a' || c > 'z') && (c < 'A' || c > 'Z')));
			stringBuilder.Append(c);
		}
		return stringBuilder.ToString();
	}
}
