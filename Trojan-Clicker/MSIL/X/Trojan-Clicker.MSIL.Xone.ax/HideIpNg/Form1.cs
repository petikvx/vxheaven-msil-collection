using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using HideIpNg.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace HideIpNg;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	public string stringa;

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
		Size clientSize = new Size(218, 0);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Enabled(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.001);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("HideIpNg Loader");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		short num = 0;
		checked
		{
			do
			{
				VBMath.Randomize();
				stringa += Conversions.ToString(Conversion.Int(VBMath.Rnd() * 9f) + 1f);
				num = (short)unchecked(num + 1);
			}
			while (num <= 22);
			short num2 = 0;
			byte[] bytes = Encoding.ASCII.GetBytes(stringa);
			BinaryReader binaryReader = new BinaryReader(File.Open(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath() + "\\_hideipng.exe", FileMode.Open));
			byte[] array = bytes;
			foreach (byte value in array)
			{
				binaryReader.BaseStream.Position = 672584 + num2;
				binaryReader.BaseStream.WriteByte(value);
				num2 = (short)(num2 + 1);
			}
			binaryReader.Close();
			Interaction.Shell(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath() + "\\_hideipng.exe", (AppWinStyle)2, false, -1);
			((Form)this).Close();
		}
	}
}
