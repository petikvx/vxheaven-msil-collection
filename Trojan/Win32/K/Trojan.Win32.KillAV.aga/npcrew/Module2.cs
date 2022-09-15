using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace npcrew;

[StandardModule]
internal sealed class Module2
{
	public static string encrypt(string pw, string source)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(pw));
		mD5CryptoServiceProvider.Clear();
		rijndaelManaged.Key = key;
		rijndaelManaged.GenerateIV();
		byte[] iV = rijndaelManaged.IV;
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(iV, 0, iV.Length);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		byte[] bytes = Encoding.UTF8.GetBytes(source);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		byte[] inArray = memoryStream.ToArray();
		string result = Convert.ToBase64String(inArray);
		cryptoStream.Close();
		rijndaelManaged.Clear();
		return result;
	}

	public static string decrypt(string pw, string source)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(pw));
		mD5CryptoServiceProvider.Clear();
		byte[] buffer = Convert.FromBase64String(source);
		MemoryStream memoryStream = new MemoryStream(buffer);
		byte[] array = new byte[16];
		memoryStream.Read(array, 0, 16);
		rijndaelManaged.IV = array;
		rijndaelManaged.Key = key;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
		byte[] array2 = new byte[checked((int)(memoryStream.Length - 16L) + 1)];
		int count = cryptoStream.Read(array2, 0, array2.Length);
		string @string = Encoding.UTF8.GetString(array2, 0, count);
		cryptoStream.Close();
		rijndaelManaged.Clear();
		return @string;
	}
}
