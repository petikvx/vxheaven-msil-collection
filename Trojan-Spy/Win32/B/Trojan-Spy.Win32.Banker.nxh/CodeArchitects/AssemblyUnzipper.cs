using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;

namespace CodeArchitects;

public static class AssemblyUnzipper
{
	private class AssemblyInfo
	{
		public string Name;

		public int RealSize;

		public int CompressedSize;

		public int Offset;
	}

	private const int SIGNATURE = 306547197;

	private static string ExeFile = null;

	private static Dictionary<string, AssemblyInfo> AsmInfos = new Dictionary<string, AssemblyInfo>();

	public static void Initialize()
	{
		ExeFile = Assembly.GetCallingAssembly().Location;
		using (FileStream fileStream = new FileStream(ExeFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
		{
			BinaryReader binaryReader = new BinaryReader(fileStream);
			int num = (int)fileStream.Length - 8;
			fileStream.Position = num;
			int num2 = binaryReader.ReadInt32();
			if (binaryReader.ReadInt32() != 306547197)
			{
				return;
			}
			fileStream.Position = num2;
			while (fileStream.Position < num)
			{
				AssemblyInfo assemblyInfo = new AssemblyInfo();
				assemblyInfo.Name = binaryReader.ReadString();
				assemblyInfo.RealSize = binaryReader.ReadInt32();
				assemblyInfo.CompressedSize = binaryReader.ReadInt32();
				assemblyInfo.Offset = (int)fileStream.Position;
				AsmInfos.Add(assemblyInfo.Name, assemblyInfo);
				fileStream.Position = assemblyInfo.Offset + assemblyInfo.CompressedSize;
			}
		}
		AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
	}

	private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs e)
	{
		AssemblyInfo value = null;
		if (AsmInfos.TryGetValue(e.Name, out value))
		{
			return ExtractAssembly(value);
		}
		return null;
	}

	private static Assembly ExtractAssembly(AssemblyInfo info)
	{
		using FileStream fileStream = new FileStream(ExeFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		byte[] array = new byte[info.CompressedSize];
		fileStream.Position = info.Offset;
		fileStream.Read(array, 0, array.Length);
		byte[] rawAssembly = UncompressBytes(array, info.RealSize);
		return Assembly.Load(rawAssembly);
	}

	private static byte[] UncompressBytes(byte[] bytes, int realSize)
	{
		byte[] array = new byte[realSize];
		MemoryStream stream = new MemoryStream(bytes);
		using GZipStream gZipStream = new GZipStream(stream, CompressionMode.Decompress);
		for (int i = 0; i < array.Length; i += gZipStream.Read(array, i, array.Length - i))
		{
		}
		return array;
	}
}
