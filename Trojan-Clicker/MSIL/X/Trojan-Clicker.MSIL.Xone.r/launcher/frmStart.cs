using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace launcher;

[DesignerGenerated]
public class frmStart : Form
{
	private IContainer components;

	[DebuggerNonUserCode]
	public frmStart()
	{
		((Form)this).add_Load((EventHandler)frmStart_Load);
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
		Size clientSize = new Size(284, 139);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("frmStart");
		((Control)this).ResumeLayout(false);
	}

	private void frmStart_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		checked
		{
			try
			{
				StreamReader streamReader = new StreamReader("ppi_install.dat");
				string text = streamReader.ReadToEnd();
				streamReader.Close();
				string[] array = text.Split(new char[1] { '\r' });
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						if (Operators.CompareString(Strings.Trim(array[i]), "", false) != 0)
						{
							Process process = new Process();
							process.StartInfo.ErrorDialog = true;
							process.StartInfo.FileName = clean(array[i]);
							process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
							process.Start();
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					if (File.Exists("ppi_install.dat"))
					{
						File.Delete("ppi_install.dat");
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				ProjectData.EndApp();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}
	}

	public string clean(string str)
	{
		string text = str;
		text = text.Replace("\r", "");
		text = text.Replace("\n", "");
		text = text.Replace("\r\n", "");
		return Strings.Trim(text);
	}
}
