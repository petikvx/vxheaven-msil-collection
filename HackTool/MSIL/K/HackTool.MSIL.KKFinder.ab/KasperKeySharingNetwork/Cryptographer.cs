using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace KasperKeySharingNetwork;

public class Cryptographer : ICryptographer
{
	private SymmetricAlgorithm mSymmetricAlgorithm;

	private MemoryStream mMemoryStream;

	private byte[] plainBytes;

	private byte[] encryptedBytes;

	private byte[] key;

	private byte[] iv;

	public Cryptographer(SymmetricAlgorithm pSymmetricAlgorithm)
	{
		key = new byte[24]
		{
			4, 8, 200, 189, 175, 145, 11, 18, 94, 38,
			243, 218, 182, 5, 28, 32, 74, 21, 19, 168,
			194, 131, 23, 69
		};
		iv = new byte[8] { 200, 100, 58, 90, 134, 211, 9, 89 };
		mSymmetricAlgorithm = pSymmetricAlgorithm;
		mSymmetricAlgorithm.Key = key;
		mSymmetricAlgorithm.IV = iv;
	}

	protected override void Finalize()
	{
		mSymmetricAlgorithm = null;
		mMemoryStream = null;
		plainBytes = null;
		encryptedBytes = null;
		base.Finalize();
	}

	public string Encrypt(string data)
	{
		checked
		{
			try
			{
				plainBytes = Encoding.UTF8.GetBytes(data);
				mMemoryStream = new MemoryStream(data.Length * 2 - 1);
				CryptoStream cryptoStream = new CryptoStream(mMemoryStream, mSymmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(plainBytes, 0, plainBytes.Length);
				cryptoStream.FlushFinalBlock();
				encryptedBytes = new byte[(int)(mMemoryStream.Length - 1L) + 1];
				mMemoryStream.Position = 0L;
				mMemoryStream.Read(encryptedBytes, 0, (int)mMemoryStream.Length);
				cryptoStream.Close();
				return Convert.ToBase64String(encryptedBytes);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				throw;
			}
			finally
			{
				CryptoStream cryptoStream = null;
			}
		}
	}

	public string Decrypt(string data)
	{
		checked
		{
			try
			{
				encryptedBytes = Convert.FromBase64String(data);
				mMemoryStream = new MemoryStream(data.Length * 2 - 1);
				CryptoStream cryptoStream = new CryptoStream(mMemoryStream, mSymmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(encryptedBytes, 0, encryptedBytes.Length);
				cryptoStream.FlushFinalBlock();
				plainBytes = new byte[(int)(mMemoryStream.Length - 1L) + 1];
				mMemoryStream.Position = 0L;
				mMemoryStream.Read(plainBytes, 0, (int)mMemoryStream.Length);
				cryptoStream.Close();
				return Encoding.UTF8.GetString(plainBytes);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				throw;
			}
			finally
			{
				CryptoStream cryptoStream = null;
			}
		}
	}
}
