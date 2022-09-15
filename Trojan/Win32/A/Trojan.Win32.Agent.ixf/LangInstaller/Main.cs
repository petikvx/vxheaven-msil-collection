using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace LangInstaller;

[DesignerGenerated]
public class Main : Form
{
	private IContainer components;

	[AccessedThroughProperty("Title")]
	private Label _Title;

	[AccessedThroughProperty("LabelWait")]
	private Label _LabelWait;

	[AccessedThroughProperty("Progression")]
	private ProgressBar _Progression;

	[AccessedThroughProperty("BgWork")]
	private BackgroundWorker _BgWork;

	internal virtual Label Title
	{
		[DebuggerNonUserCode]
		get
		{
			return _Title;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Title = value;
		}
	}

	internal virtual Label LabelWait
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelWait;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelWait = value;
		}
	}

	internal virtual ProgressBar Progression
	{
		[DebuggerNonUserCode]
		get
		{
			return _Progression;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Progression = value;
		}
	}

	internal virtual BackgroundWorker BgWork
	{
		[DebuggerNonUserCode]
		get
		{
			return _BgWork;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_BgWork != null)
			{
				_BgWork.DoWork -= BgWork_DoWork;
				_BgWork.ProgressChanged -= BgWork_ProgressChanged;
			}
			_BgWork = value;
			if (_BgWork != null)
			{
				_BgWork.DoWork += BgWork_DoWork;
				_BgWork.ProgressChanged += BgWork_ProgressChanged;
			}
		}
	}

	[DebuggerNonUserCode]
	public Main()
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Title = new Label();
		LabelWait = new Label();
		Progression = new ProgressBar();
		BgWork = new BackgroundWorker();
		((Control)this).SuspendLayout();
		Title.set_AutoSize(true);
		Label title = Title;
		Point location = new Point(47, 9);
		((Control)title).set_Location(location);
		((Control)Title).set_Name("Title");
		Label title2 = Title;
		Size size = new Size(132, 13);
		((Control)title2).set_Size(size);
		((Control)Title).set_TabIndex(0);
		Title.set_Text("Language Files Installation");
		LabelWait.set_AutoSize(true);
		Label labelWait = LabelWait;
		location = new Point(75, 25);
		((Control)labelWait).set_Location(location);
		((Control)LabelWait).set_Name("LabelWait");
		Label labelWait2 = LabelWait;
		size = new Size(73, 13);
		((Control)labelWait2).set_Size(size);
		((Control)LabelWait).set_TabIndex(1);
		LabelWait.set_Text("Please Wait...");
		ProgressBar progression = Progression;
		location = new Point(12, 43);
		((Control)progression).set_Location(location);
		((Control)Progression).set_Name("Progression");
		ProgressBar progression2 = Progression;
		size = new Size(196, 22);
		((Control)progression2).set_Size(size);
		Progression.set_Style((ProgressBarStyle)1);
		((Control)Progression).set_TabIndex(2);
		BgWork.WorkerReportsProgress = true;
		BgWork.WorkerSupportsCancellation = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(220, 77);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Progression);
		((Control)this).get_Controls().Add((Control)(object)LabelWait);
		((Control)this).get_Controls().Add((Control)(object)Title);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Installation");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Environment.GetCommandLineArgs().Length > 1)
		{
			BgWork.RunWorkerAsync();
			return;
		}
		MessageBox.Show("The software can't be run without a correct *.osl file", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		Application.Exit();
	}

	private void BgWork_DoWork(object sender, DoWorkEventArgs e)
	{
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		FileInfo fileInfo = new FileInfo(Environment.GetCommandLineArgs()[1]);
		IniManager iniManager = new IniManager(fileInfo.FullName);
		string value = iniManager.GetValue("Installation", "File", "");
		string value2 = iniManager.GetValue("Installation", "Folder", "");
		((Form)this).set_Text(iniManager.GetValue("Installation", "Title", ""));
		checked
		{
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\OGUTeam\\OSM", writable: true);
				File.Copy(new FileInfo(value).FullName, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(registryKey.GetValue("Path"), (object)"\\languages\\"), (object)value)), overwrite: true);
				string[] directories = Directory.GetDirectories(new FileInfo(value).Directory!.FullName + "\\" + value2);
				int num = directories.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string[] files = Directory.GetFiles(new DirectoryInfo(directories[i]).FullName);
					if (!Directory.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(registryKey.GetValue("Path"), (object)"\\languages\\"), (object)new DirectoryInfo(directories[i]).get_Name()))))
					{
						Directory.CreateDirectory(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(registryKey.GetValue("Path"), (object)"\\languages\\"), (object)new DirectoryInfo(directories[i]).get_Name())));
					}
					int num2 = files.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						FileInfo fileInfo2 = new FileInfo(files[j]);
						if (!File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(registryKey.GetValue("Path"), (object)"\\languages\\"), (object)new DirectoryInfo(directories[i]).get_Name()), (object)"\\"), (object)fileInfo2.get_Name()))))
						{
							File.Copy(fileInfo2.FullName, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(registryKey.GetValue("Path"), (object)"\\languages\\"), (object)new DirectoryInfo(directories[i]).get_Name()), (object)"\\"), (object)fileInfo2.get_Name())), overwrite: true);
						}
					}
					BgWork.ReportProgress((int)Math.Round((double)(100 * i) / (double)(directories.Length - 1)));
				}
				MessageBox.Show("Installation completed", "Installation", (MessageBoxButtons)0, (MessageBoxIcon)64);
				Application.Exit();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show("Error :" + ex2.Message + "\r\nPlease reinstall OGame Skins Maker or try with an other *.osl file.", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				Application.Exit();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void BgWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		Progression.set_Value(e.ProgressPercentage);
	}
}
