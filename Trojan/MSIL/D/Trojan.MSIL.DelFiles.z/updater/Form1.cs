using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using updater.My;

namespace updater;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("dlfilename")]
	private Label _dlfilename;

	[AccessedThroughProperty("progress")]
	private Label _progress;

	[AccessedThroughProperty("speed")]
	private Label _speed;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private Version localversion;

	private Version webversion;

	internal virtual ProgressBar ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual Label dlfilename
	{
		[DebuggerNonUserCode]
		get
		{
			return _dlfilename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dlfilename = value;
		}
	}

	internal virtual Label progress
	{
		[DebuggerNonUserCode]
		get
		{
			return _progress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_progress = value;
		}
	}

	internal virtual Label speed
	{
		[DebuggerNonUserCode]
		get
		{
			return _speed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_speed = value;
		}
	}

	internal virtual WebBrowser WebBrowser1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser1 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		components = new Container();
		ProgressBar1 = new ProgressBar();
		dlfilename = new Label();
		progress = new Label();
		speed = new Label();
		WebBrowser1 = new WebBrowser();
		Button1 = new Button();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		ProgressBar progressBar = ProgressBar1;
		Point location = new Point(15, 58);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		Size size = new Size(271, 13);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(0);
		dlfilename.set_AutoSize(true);
		Label obj = dlfilename;
		location = new Point(12, 41);
		((Control)obj).set_Location(location);
		((Control)dlfilename).set_Name("dlfilename");
		Label obj2 = dlfilename;
		size = new Size(145, 14);
		((Control)obj2).set_Size(size);
		((Control)dlfilename).set_TabIndex(1);
		dlfilename.set_Text("Bitte drücken sie auf Update!");
		progress.set_AutoSize(true);
		Label obj3 = progress;
		location = new Point(12, 74);
		((Control)obj3).set_Location(location);
		((Control)progress).set_Name("progress");
		Label obj4 = progress;
		size = new Size(39, 14);
		((Control)obj4).set_Size(size);
		((Control)progress).set_TabIndex(2);
		progress.set_Text("Label1");
		((Control)progress).set_Visible(false);
		speed.set_AutoSize(true);
		Label obj5 = speed;
		location = new Point(247, 74);
		((Control)obj5).set_Location(location);
		((Control)speed).set_Name("speed");
		Label obj6 = speed;
		size = new Size(39, 14);
		((Control)obj6).set_Size(size);
		((Control)speed).set_TabIndex(3);
		speed.set_Text("Label2");
		((Control)speed).set_Visible(false);
		WebBrowser webBrowser = WebBrowser1;
		location = new Point(247, 1);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		size = new Size(20, 22);
		((Control)webBrowser2).set_MinimumSize(size);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser webBrowser3 = WebBrowser1;
		size = new Size(39, 22);
		((Control)webBrowser3).set_Size(size);
		((Control)WebBrowser1).set_TabIndex(4);
		((Control)WebBrowser1).set_Visible(false);
		Button button = Button1;
		location = new Point(12, 12);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(69, 26);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(5);
		((ButtonBase)Button1).set_Text("Update");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 14f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.LightSkyBlue);
		size = new Size(291, 97);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).get_Controls().Add((Control)(object)speed);
		((Control)this).get_Controls().Add((Control)(object)progress);
		((Control)this).get_Controls().Add((Control)(object)dlfilename);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Updater");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Invalid comparison between Unknown and I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		dlfilename.set_Text("Überprüfe Dateiversion...");
		Application.DoEvents();
		getlocalversion();
		if (localversion == new Version(0, 0, 0, 0))
		{
			Interaction.MsgBox((object)"Lokale Versionsnummer konnte nicht ermittelt werden!", (MsgBoxStyle)16, (object)"Updater");
			dlfilename.set_Text("Bitte drücken Sie auf Update!");
		}
		else if (!(Download.getversion("http://stefanspas.st.funpic.de/version.html") == new Version(0, 0, 0, 0)))
		{
			webversion = Download.getversion("http://stefanspas.st.funpic.de/version.html");
			if ((localversion.Major == webversion.Major) & (localversion.Minor == webversion.Minor))
			{
				Interaction.MsgBox((object)"Sie haben die neuste Version!", (MsgBoxStyle)64, (object)"Updater");
				dlfilename.set_Text("Bitte drücken Sie auf Update!");
			}
			else if ((int)Interaction.MsgBox((object)"Eine neuere Version ist erhältlich!\r\nHerunterladen?", (MsgBoxStyle)68, (object)"Updater") == 6)
			{
				updatefile();
			}
		}
		else
		{
			Interaction.MsgBox((object)"Web Versionsnummer konnte nicht ermittelt werden!", (MsgBoxStyle)16, (object)"Updater");
			dlfilename.set_Text("Bitte drücken Sie auf Update!");
		}
	}

	public void updatefile()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (!Directory.Exists(Application.get_StartupPath() + "\\Updates"))
		{
			Directory.CreateDirectory(Application.get_StartupPath() + "\\Updates");
		}
		if (Download.downloadfile("http://stefanspas.st.funpic.de/BigSREmuTool.exe", Application.get_StartupPath() + "\\Updates\\update.upd"))
		{
			copyfile();
			return;
		}
		Interaction.MsgBox((object)"Update konnte nicht heruntergeladen werden!", (MsgBoxStyle)16, (object)"Updater");
		dlfilename.set_Text("Bitte drücken Sie auf Update!");
		((Control)speed).Hide();
		((Control)progress).Hide();
	}

	public void copyfile()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process[] processesByName = Process.GetProcessesByName("BigSREmuTool");
			if (processesByName.Length > 0)
			{
				MsgBoxResult val = Interaction.MsgBox((object)"Um fortzufahren müssen alle Instanzen von \"BigSREmuTool\" beendet werden. Wollen Sie dies jetzt tun?", (MsgBoxStyle)52, (object)null);
				if ((int)val != 6)
				{
					if (File.Exists(Application.get_StartupPath() + "\\Updates\\update.upd"))
					{
						File.Delete(Application.get_StartupPath() + "\\Updates\\update.upd");
					}
					Interaction.MsgBox((object)"Vorgang abgebrochen. Dateien wurden gelöscht.", (MsgBoxStyle)48, (object)null);
					return;
				}
				Process[] array = processesByName;
				foreach (Process process in array)
				{
					if (!process.HasExited)
					{
						process.Kill();
					}
				}
			}
			dlfilename.set_Text("Kopiere die neuen Dateien...");
			if (File.Exists(Application.get_StartupPath() + "\\Updates\\update.upd"))
			{
				try
				{
					FileSystem.DeleteFile(Application.get_StartupPath() + "\\BigSREmuTool.exe", (UIOption)2, (RecycleOption)2, (UICancelOption)2);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					dlfilename.set_Text("Bitte drücken Sie auf Update!");
					ProjectData.ClearProjectError();
					return;
				}
				File.Copy(Application.get_StartupPath() + "\\Updates\\update.upd", Application.get_StartupPath() + "\\BigSREmuTool.exe");
				Directory.Delete(Application.get_StartupPath() + "\\Updates");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			Interaction.MsgBox((object)"Unerwarteter Fehler!", (MsgBoxStyle)16, (object)null);
			Application.Exit();
			ProjectData.ClearProjectError();
		}
		((Computer)MyProject.Computer).get_Audio().PlaySystemSound(SystemSounds.get_Asterisk());
		dlfilename.set_Text("Update erfolgreich!");
	}

	public void getlocalversion()
	{
		try
		{
			localversion = new Version(FileVersionInfo.GetVersionInfo(Application.get_StartupPath() + "\\BigSREmuTool.exe").ProductVersion);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			localversion = new Version(0, 0, 0, 0);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Download.downTemp = Download.down / 1000.0;
		Download.down = 0.0;
		((Control)speed).Show();
		speed.set_Text(Strings.Format((object)Download.downTemp, "#,###,###,###0.00") + " Kb/sec");
	}
}
