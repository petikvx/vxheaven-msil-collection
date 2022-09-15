using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using WakeUp.My;

namespace WakeUp;

[DesignerGenerated]
public class Form_WakeUP : Form
{
	private IContainer components;

	public int WM_SYSCOMMAND;

	public int SC_MONITORPOWER;

	private const long ES_DISPLAY_REQUIRED = 2L;

	private const long ES_CONTINUOUS = -2147483648L;

	private const long ES_SYSTEM_REQUIRED = 1L;

	public Form_WakeUP()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		WM_SYSCOMMAND = 274;
		SC_MONITORPOWER = 61808;
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
		Size clientSize = new Size(353, 257);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form_WakeUP");
		((Form)this).set_Text("WakeUpApplication");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32.dll")]
	private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void SetThreadExecutionState(int esFlags);

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			if (((ConsoleApplicationBase)MyProject.Application).get_CommandLineArgs().Count != 0)
			{
				foreach (string commandLineArg in ((ConsoleApplicationBase)MyProject.Application).get_CommandLineArgs())
				{
					if ((Operators.CompareString(commandLineArg.ToUpper(), "ON", false) == 0) | (Operators.CompareString(commandLineArg.ToUpper(), "EIN", false) == 0) | (Operators.CompareString(commandLineArg.ToUpper(), "AN", false) == 0))
					{
						SetThreadExecutionState(-2147483645);
						SendMessage(((Control)this).get_Handle().ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, -1);
					}
					else if ((Operators.CompareString(commandLineArg.ToUpper(), "OFF", false) == 0) | (Operators.CompareString(commandLineArg.ToUpper(), "AUS", false) == 0))
					{
						SetThreadExecutionState(int.MinValue);
						SendMessage(((Control)this).get_Handle().ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, 2);
					}
				}
			}
			else
			{
				SetThreadExecutionState(-2147483645);
				SendMessage(((Control)this).get_Handle().ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, -1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
	}
}
