using System;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Microsoft.Win32;
using Proxy_Switcher.Properties;

namespace Proxy_Switcher;

public class MainForm : Form
{
	private enum UserMode
	{
		NotSet,
		Home,
		Office,
		Auto
	}

	private string currentDomainCoputerName = string.Empty;

	private UserMode _mode;

	private IContainer components;

	private NotifyIcon trayIcon;

	private ContextMenuStrip contextMenu;

	private ToolStripMenuItem homeToolStripMenuItem;

	private ToolStripMenuItem workToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem exitToolStripMenuItem;

	private Button buttonHome;

	private Button buttonOffice;

	private ToolStripMenuItem toolStripMenuItem1;

	private ToolStripMenuItem autoToolStripMenuItem;

	private Button cmdAuto;

	private Label label1;

	private Panel panel1;

	private Label lblStatus;

	private Button cmdRefresh;

	private string OfficeDomainComputerName
	{
		get
		{
			return (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\OnyxBox\\ProxySwitcher", "OfficeDomainComputerName", "");
		}
		set
		{
			if (value.Trim().Length > 0)
			{
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\OnyxBox\\ProxySwitcher", "OfficeDomainComputerName", value, RegistryValueKind.String);
			}
		}
	}

	private bool ProxyEnabled
	{
		get
		{
			return 1 == (int)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", "ProxyEnable", 0);
		}
		set
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", "ProxyEnable", value, RegistryValueKind.DWord);
			try
			{
				string text = "";
				string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles\\";
				DirectoryInfo directoryInfo = new DirectoryInfo(path);
				DirectoryInfo[] directories = directoryInfo.GetDirectories("*.default");
				int num = 0;
				if (0 < directories.Length)
				{
					DirectoryInfo directoryInfo2 = directories[num];
					text = text + directoryInfo2.FullName + "\\user.js";
				}
				string[] array;
				try
				{
					using (StreamReader streamReader = File.OpenText(text))
					{
						array = streamReader.ReadToEnd().Split(new char[1] { '\r' });
						streamReader.Close();
					}
					File.Delete(text);
				}
				catch
				{
					array = new string[1] { "" };
				}
				string text2 = "user_pref(\"network.proxy.type\", " + (value ? "1" : "0") + ");";
				bool flag = false;
				try
				{
					StreamWriter streamWriter = File.CreateText(text);
					string[] array2 = array;
					foreach (string text3 in array2)
					{
						string text4;
						if (text3.Contains("network.proxy.type"))
						{
							text4 = text2;
							flag = true;
						}
						else
						{
							text4 = text3;
						}
						if (text4.Length > 0)
						{
							streamWriter.Write(text4 + "\r");
						}
					}
					if (!flag)
					{
						streamWriter.Write(text2 + "\r");
					}
					streamWriter.Close();
				}
				catch
				{
				}
			}
			catch
			{
			}
			WinInetNotification.NotifyProxyChange();
		}
	}

	private UserMode Mode
	{
		get
		{
			return _mode;
		}
		set
		{
			switch (value)
			{
			default:
				ProxyEnabled = true;
				break;
			case UserMode.Home:
				ProxyEnabled = false;
				break;
			case UserMode.Office:
				ProxyEnabled = true;
				break;
			case UserMode.Auto:
				currentDomainCoputerName = GetDomainComputerName().Trim();
				ProxyEnabled = currentDomainCoputerName.Length > 0;
				break;
			}
			_mode = value;
			SetUserInterfaceStatus();
		}
	}

	public MainForm()
	{
		InitializeComponent();
		Control.set_CheckForIllegalCrossThreadCalls(false);
	}

	private string GetDomainComputerName()
	{
		try
		{
			Domain computerDomain = Domain.GetComputerDomain();
			try
			{
				return ((ActiveDirectoryPartition)computerDomain).get_Name();
			}
			finally
			{
				((IDisposable)computerDomain)?.Dispose();
			}
		}
		catch
		{
			return string.Empty;
		}
	}

	private void SetUserInterfaceStatus()
	{
		homeToolStripMenuItem.set_Checked(Mode.Equals(UserMode.Home));
		workToolStripMenuItem.set_Checked(Mode.Equals(UserMode.Office));
		autoToolStripMenuItem.set_Checked(Mode.Equals(UserMode.Auto));
		((Control)buttonHome).set_Enabled(Mode.Equals(UserMode.Auto) || Mode.Equals(UserMode.Office));
		((Control)buttonOffice).set_Enabled(Mode.Equals(UserMode.Auto) || Mode.Equals(UserMode.Home));
		((Control)cmdAuto).set_Enabled(Mode.Equals(UserMode.Office) || Mode.Equals(UserMode.Home));
		if (Mode.Equals(UserMode.Auto))
		{
			((Control)lblStatus).set_Text("Status: " + (ProxyEnabled ? "Auto (Office)" : "Auto (Home)"));
			trayIcon.set_Text("Proxy Switcher " + (ProxyEnabled ? "(Auto - Office)" : "(Auto - Home)"));
		}
		else
		{
			((Control)lblStatus).set_Text("Status: " + (ProxyEnabled ? "Office" : "Home"));
			trayIcon.set_Text("Proxy Switcher " + (ProxyEnabled ? "(Office)" : "(Home)"));
		}
	}

	public void PopUp()
	{
		if (!((Control)this).get_Visible())
		{
			int bottom = Screen.get_PrimaryScreen().get_WorkingArea().Bottom;
			int right = Screen.get_PrimaryScreen().get_WorkingArea().Right;
			((Form)this).set_WindowState((FormWindowState)0);
			((Control)this).set_Top(bottom);
			((Control)this).set_Left(right - ((Control)this).get_Width());
			((Form)this).set_TopMost(false);
			((Control)this).set_Visible(true);
			int num = bottom;
			while (((Control)this).get_Top() > bottom - ((Control)this).get_Height())
			{
				((Control)this).set_Top(num);
				num -= 8;
			}
			((Control)this).set_Top(bottom - ((Control)this).get_Height());
		}
	}

	private void RestoreUserMode()
	{
		string text = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\OnyxBox\\ProxySwitcher", "StartupMode", "");
		string text2;
		if ((text2 = text) != null && text2 == "Auto")
		{
			Mode = UserMode.Auto;
		}
		else
		{
			RestoreUserModeFromProxyEnabled();
		}
	}

	private void RestoreUserModeFromProxyEnabled()
	{
		if (ProxyEnabled)
		{
			Mode = UserMode.Office;
		}
		else
		{
			Mode = UserMode.Home;
		}
	}

	private void SaveUserMode()
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\OnyxBox\\ProxySwitcher", "StartupMode", Mode switch
		{
			UserMode.Home => "Home", 
			UserMode.Office => "Office", 
			UserMode.Auto => "Auto", 
			_ => "", 
		}, RegistryValueKind.String);
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void homeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Mode = UserMode.Home;
	}

	private void workToolStripMenuItem_Click(object sender, EventArgs e)
	{
		OfficeDomainComputerName = GetDomainComputerName();
		Mode = UserMode.Office;
	}

	private void autoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Mode = UserMode.Auto;
	}

	private void trayIcon_MouseMove(object sender, MouseEventArgs e)
	{
		SetUserInterfaceStatus();
	}

	private void buttonHome_Click(object sender, EventArgs e)
	{
		Mode = UserMode.Home;
	}

	private void cmdAuto_Click(object sender, EventArgs e)
	{
		Mode = UserMode.Auto;
	}

	private void buttonOffice_Click(object sender, EventArgs e)
	{
		Mode = UserMode.Office;
	}

	private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (((Control)this).get_Visible())
		{
			PopDown();
		}
		else
		{
			PopUp();
		}
	}

	private void PopDown()
	{
		if (((Control)this).get_Visible())
		{
			int bottom = Screen.get_PrimaryScreen().get_WorkingArea().Bottom;
			int right = Screen.get_PrimaryScreen().get_WorkingArea().Right;
			((Form)this).set_WindowState((FormWindowState)0);
			((Control)this).set_Left(right - ((Control)this).get_Width());
			((Form)this).set_TopMost(false);
			((Control)this).set_Visible(true);
			int num = ((Control)this).get_Top();
			while (((Control)this).get_Top() < bottom)
			{
				((Control)this).set_Top(num);
				num += 8;
			}
			((Control)this).set_Visible(false);
		}
	}

	private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		((CancelEventArgs)(object)e).Cancel = (int)e.get_CloseReason() == 3;
		((Control)this).set_Visible(false);
		if (!((CancelEventArgs)(object)e).Cancel)
		{
			SaveUserMode();
		}
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		NetworkChange.NetworkAddressChanged += NetworkChange_NetworkAddressChanged;
		currentDomainCoputerName = GetDomainComputerName();
		RestoreUserMode();
	}

	public void NetworkChange_NetworkAddressChanged(object sender, EventArgs e)
	{
		currentDomainCoputerName = GetDomainComputerName();
		RefreshStatus();
	}

	private void MainForm_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	private void toolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		AboutForm aboutForm = new AboutForm();
		((Form)aboutForm).ShowDialog();
	}

	private void cmdRefresh_Click(object sender, EventArgs e)
	{
		RefreshStatus();
	}

	private void RefreshStatus()
	{
		if (Mode.Equals(UserMode.Auto))
		{
			Mode = Mode;
		}
		else
		{
			RestoreUserModeFromProxyEnabled();
		}
		SetUserInterfaceStatus();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected O, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected O, but got Unknown
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Expected O, but got Unknown
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		trayIcon = new NotifyIcon(components);
		contextMenu = new ContextMenuStrip(components);
		homeToolStripMenuItem = new ToolStripMenuItem();
		workToolStripMenuItem = new ToolStripMenuItem();
		autoToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator1 = new ToolStripSeparator();
		toolStripMenuItem1 = new ToolStripMenuItem();
		exitToolStripMenuItem = new ToolStripMenuItem();
		buttonHome = new Button();
		buttonOffice = new Button();
		cmdAuto = new Button();
		label1 = new Label();
		panel1 = new Panel();
		cmdRefresh = new Button();
		lblStatus = new Label();
		((Control)contextMenu).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		trayIcon.set_ContextMenuStrip(contextMenu);
		trayIcon.set_Icon((Icon)componentResourceManager.GetObject("trayIcon.Icon"));
		trayIcon.set_Text("Proxy Switcher");
		trayIcon.set_Visible(true);
		trayIcon.add_MouseMove(new MouseEventHandler(trayIcon_MouseMove));
		trayIcon.add_MouseDoubleClick(new MouseEventHandler(trayIcon_MouseDoubleClick));
		((ToolStrip)contextMenu).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)homeToolStripMenuItem,
			(ToolStripItem)workToolStripMenuItem,
			(ToolStripItem)autoToolStripMenuItem,
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)toolStripMenuItem1,
			(ToolStripItem)exitToolStripMenuItem
		});
		((Control)contextMenu).set_Name("contextMenu");
		((Control)contextMenu).set_Size(new Size(117, 120));
		((ToolStripItem)homeToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("homeToolStripMenuItem.Image"));
		((ToolStripItem)homeToolStripMenuItem).set_Name("homeToolStripMenuItem");
		((ToolStripItem)homeToolStripMenuItem).set_Size(new Size(116, 22));
		((ToolStripItem)homeToolStripMenuItem).set_Text("&Home");
		((ToolStripItem)homeToolStripMenuItem).add_Click((EventHandler)homeToolStripMenuItem_Click);
		((ToolStripItem)workToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("workToolStripMenuItem.Image"));
		((ToolStripItem)workToolStripMenuItem).set_Name("workToolStripMenuItem");
		((ToolStripItem)workToolStripMenuItem).set_Size(new Size(116, 22));
		((ToolStripItem)workToolStripMenuItem).set_Text("&Office");
		((ToolStripItem)workToolStripMenuItem).add_Click((EventHandler)workToolStripMenuItem_Click);
		autoToolStripMenuItem.set_CheckOnClick(true);
		((ToolStripItem)autoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("autoToolStripMenuItem.Image"));
		((ToolStripItem)autoToolStripMenuItem).set_Name("autoToolStripMenuItem");
		((ToolStripItem)autoToolStripMenuItem).set_Size(new Size(116, 22));
		((ToolStripItem)autoToolStripMenuItem).set_Text("&Auto");
		((ToolStripItem)autoToolStripMenuItem).add_Click((EventHandler)autoToolStripMenuItem_Click);
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		((ToolStripItem)toolStripSeparator1).set_Size(new Size(113, 6));
		((ToolStripItem)toolStripMenuItem1).set_Image((Image)(object)Resources.OnyxBoxPlain);
		((ToolStripItem)toolStripMenuItem1).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)toolStripMenuItem1).set_Name("toolStripMenuItem1");
		((ToolStripItem)toolStripMenuItem1).set_Size(new Size(116, 22));
		((ToolStripItem)toolStripMenuItem1).set_Text("About...");
		((ToolStripItem)toolStripMenuItem1).add_Click((EventHandler)toolStripMenuItem1_Click);
		((ToolStripItem)exitToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("exitToolStripMenuItem.Image"));
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		((ToolStripItem)exitToolStripMenuItem).set_Size(new Size(116, 22));
		((ToolStripItem)exitToolStripMenuItem).set_Text("E&xit");
		((ToolStripItem)exitToolStripMenuItem).add_Click((EventHandler)exitToolStripMenuItem_Click);
		((ButtonBase)buttonHome).set_Image((Image)componentResourceManager.GetObject("buttonHome.Image"));
		((ButtonBase)buttonHome).set_ImageAlign((ContentAlignment)16);
		((Control)buttonHome).set_Location(new Point(16, 87));
		((Control)buttonHome).set_Name("buttonHome");
		((Control)buttonHome).set_Size(new Size(113, 29));
		((Control)buttonHome).set_TabIndex(1);
		((Control)buttonHome).set_Text("&Home");
		((ButtonBase)buttonHome).set_UseVisualStyleBackColor(true);
		((Control)buttonHome).add_Click((EventHandler)buttonHome_Click);
		((ButtonBase)buttonOffice).set_Image((Image)componentResourceManager.GetObject("buttonOffice.Image"));
		((ButtonBase)buttonOffice).set_ImageAlign((ContentAlignment)16);
		((Control)buttonOffice).set_Location(new Point(16, 122));
		((Control)buttonOffice).set_Name("buttonOffice");
		((Control)buttonOffice).set_Size(new Size(113, 29));
		((Control)buttonOffice).set_TabIndex(2);
		((Control)buttonOffice).set_Text("&Office");
		((ButtonBase)buttonOffice).set_UseVisualStyleBackColor(true);
		((Control)buttonOffice).add_Click((EventHandler)buttonOffice_Click);
		((ButtonBase)cmdAuto).set_Image((Image)componentResourceManager.GetObject("cmdAuto.Image"));
		((ButtonBase)cmdAuto).set_ImageAlign((ContentAlignment)16);
		((Control)cmdAuto).set_Location(new Point(16, 157));
		((Control)cmdAuto).set_Name("cmdAuto");
		((Control)cmdAuto).set_Size(new Size(113, 29));
		((Control)cmdAuto).set_TabIndex(3);
		((Control)cmdAuto).set_Text("&Auto");
		((ButtonBase)cmdAuto).set_UseVisualStyleBackColor(true);
		((Control)cmdAuto).add_Click((EventHandler)cmdAuto_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(13, 60));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(248, 13));
		((Control)label1).set_TabIndex(5);
		((Control)label1).set_Text("Click on one of the following to change your status:");
		((Control)panel1).set_BackColor(Color.Gray);
		((Control)panel1).get_Controls().Add((Control)(object)cmdRefresh);
		((Control)panel1).get_Controls().Add((Control)(object)lblStatus);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(301, 45));
		((Control)panel1).set_TabIndex(6);
		((ButtonBase)cmdRefresh).set_Image((Image)componentResourceManager.GetObject("cmdRefresh.Image"));
		((ButtonBase)cmdRefresh).set_ImageAlign((ContentAlignment)16);
		((Control)cmdRefresh).set_Location(new Point(273, 9));
		((Control)cmdRefresh).set_Name("cmdRefresh");
		((Control)cmdRefresh).set_Size(new Size(25, 26));
		((Control)cmdRefresh).set_TabIndex(7);
		((ButtonBase)cmdRefresh).set_UseVisualStyleBackColor(true);
		((Control)cmdRefresh).add_Click((EventHandler)cmdRefresh_Click);
		((Control)lblStatus).set_AutoSize(true);
		((Control)lblStatus).set_Font(new Font("Arial", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblStatus).set_ForeColor(Color.White);
		((Control)lblStatus).set_Location(new Point(12, 9));
		((Control)lblStatus).set_Name("lblStatus");
		((Control)lblStatus).set_Size(new Size(158, 27));
		((Control)lblStatus).set_TabIndex(5);
		((Control)lblStatus).set_Text("Status: Office");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_AutoSize(true);
		((Form)this).set_ClientSize(new Size(301, 207));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)buttonOffice);
		((Control)this).get_Controls().Add((Control)(object)cmdAuto);
		((Control)this).get_Controls().Add((Control)(object)buttonHome);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MainForm");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Control)this).set_Text("Proxy Switcher");
		((Form)this).set_TopMost(true);
		((Form)this).add_Shown((EventHandler)MainForm_Shown);
		((Form)this).add_FormClosing(new FormClosingEventHandler(MainForm_FormClosing));
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Control)contextMenu).ResumeLayout(false);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
