using System;
using System.Diagnostics;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;

namespace KasperKeySharingNetwork;

public class Factory
{
	[DebuggerNonUserCode]
	public Factory()
	{
	}

	public static ICryptographer GetCryptographer(string CryptographerType)
	{
		SymmetricAlgorithm pSymmetricAlgorithm = null;
		try
		{
			switch (CryptographerType.ToLower())
			{
			case "des":
				pSymmetricAlgorithm = new DESCryptoServiceProvider();
				break;
			case "tripledes":
				pSymmetricAlgorithm = new TripleDESCryptoServiceProvider();
				break;
			case "rijndeal":
				pSymmetricAlgorithm = new RijndaelManaged();
				break;
			}
			return new Cryptographer(pSymmetricAlgorithm);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			throw;
		}
	}
}
