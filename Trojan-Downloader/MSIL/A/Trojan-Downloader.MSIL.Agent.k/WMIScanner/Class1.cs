using System;
using System.Threading;

namespace WMIScanner;

internal class Class1
{
	[STAThread]
	private static void Main(string[] args)
	{
		ScnClass @object = new ScnClass();
		Thread thread = new Thread(@object.Task);
		thread.Start();
	}
}
