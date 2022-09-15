using System;
using System.IO;
using System.Reflection;
using Xenocode.Client.Attributes;
using ns1;
using ns2;

namespace ns4;

public class GClass12
{
	public const string string_0 = ".datacxc";

	[STAThread]
	[Marker(12)]
	[EntryPoint]
	public static void Main()
	{
		smethod_3(null);
	}

	[STAThread]
	[Marker(13)]
	[EntryPoint]
	public static void smethod_0(string[] string_1)
	{
		smethod_3(string_1);
	}

	[Marker(14)]
	[STAThread]
	[EntryPoint]
	public static int smethod_1()
	{
		return smethod_3(null);
	}

	[EntryPoint]
	[STAThread]
	[Marker(15)]
	public static int smethod_2(string[] string_1)
	{
		return smethod_3(string_1);
	}

	protected static int smethod_3(string[] string_1)
	{
		GClass0 gClass = new GClass0(new FileStream(Assembly.GetCallingAssembly().Location, FileMode.Open, FileAccess.Read, FileShare.Read), Assembly.GetCallingAssembly().Location);
		GClass2 gClass2 = null;
		foreach (GClass2 item in gClass.IEnumerable_1)
		{
			if (item.String_0 == ".datacxc")
			{
				gClass2 = item;
			}
		}
		if (gClass2 == null)
		{
			return 0;
		}
		gClass.Stream_0.Seek(gClass2.UInt32_4, SeekOrigin.Begin);
		BinaryReader binaryReader = new BinaryReader(gClass.Stream_0);
		uint count = binaryReader.ReadUInt32();
		GStream0 input = new GStream0(gClass.Stream_0);
		BinaryReader binaryReader2 = new BinaryReader(input);
		Assembly assembly = Assembly.Load(binaryReader2.ReadBytes((int)count));
		object obj = null;
		obj = ((string_1 == null) ? assembly.EntryPoint!.Invoke((object)null, (object[])null) : assembly.EntryPoint!.Invoke((object)null, new object[1] { string_1 }));
		if (!(obj is int))
		{
			return 0;
		}
		return (int)obj;
	}

	public GClass12()
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}
}
