using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using GoolagScan.Properties;

namespace GoolagScan;

internal class About : Form
{
	private const string URI_Google_TOS = "http://www.google.com/accounts/TOS";

	private const string URI_agplv3 = "http://www.fsf.org/agplv3-pr";

	private IContainer components;

	private TableLayoutPanel tableLayoutPanel;

	private Label labelVersion;

	private TextBox textBoxDescription;

	private Button okButton;

	private Button showGTOSButton;

	private Button showHESSLAButton;

	private PictureBox pictureBox1;

	private Panel panel2;

	private CheckBox showAtStartCB;

	public string AssemblyTitle
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), inherit: false);
			if (customAttributes.Length > 0)
			{
				AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)customAttributes[0];
				if (assemblyTitleAttribute.Title != "")
				{
					return assemblyTitleAttribute.Title;
				}
			}
			return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
		}
	}

	public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version!.ToString();

	public string AssemblyDescription
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), inherit: false);
			if (customAttributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
		}
	}

	public string AssemblyProduct
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), inherit: false);
			if (customAttributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyProductAttribute)customAttributes[0]).Product;
		}
	}

	public string AssemblyCopyright
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), inherit: false);
			if (customAttributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
		}
	}

	public string AssemblyCompany
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), inherit: false);
			if (customAttributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCompanyAttribute)customAttributes[0]).Company;
		}
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(About));
		tableLayoutPanel = new TableLayoutPanel();
		showHESSLAButton = new Button();
		labelVersion = new Label();
		textBoxDescription = new TextBox();
		showGTOSButton = new Button();
		pictureBox1 = new PictureBox();
		panel2 = new Panel();
		okButton = new Button();
		showAtStartCB = new CheckBox();
		((Control)tableLayoutPanel).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)tableLayoutPanel).set_BackColor(SystemColors.ControlLightLight);
		((Control)tableLayoutPanel).set_BackgroundImageLayout((ImageLayout)0);
		tableLayoutPanel.set_ColumnCount(1);
		tableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel.get_Controls().Add((Control)(object)showHESSLAButton, 0, 3);
		tableLayoutPanel.get_Controls().Add((Control)(object)labelVersion, 0, 1);
		tableLayoutPanel.get_Controls().Add((Control)(object)textBoxDescription, 0, 2);
		tableLayoutPanel.get_Controls().Add((Control)(object)showGTOSButton, 0, 4);
		tableLayoutPanel.get_Controls().Add((Control)(object)pictureBox1, 0, 0);
		tableLayoutPanel.get_Controls().Add((Control)(object)panel2, 0, 5);
		((Control)tableLayoutPanel).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel).set_Location(new Point(2, 2));
		((Control)tableLayoutPanel).set_Margin(new Padding(1));
		((Control)tableLayoutPanel).set_Name("tableLayoutPanel");
		tableLayoutPanel.set_RowCount(6);
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 28.43201f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 11f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 42.11434f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 9.693332f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 9.693332f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10.06699f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)tableLayoutPanel).set_Size(new Size(321, 315));
		((Control)tableLayoutPanel).set_TabIndex(15);
		((Control)showHESSLAButton).set_BackColor(SystemColors.ButtonFace);
		((Control)showHESSLAButton).set_Dock((DockStyle)5);
		((Control)showHESSLAButton).set_Location(new Point(3, 228));
		((Control)showHESSLAButton).set_Name("showHESSLAButton");
		((Control)showHESSLAButton).set_Size(new Size(315, 23));
		((Control)showHESSLAButton).set_TabIndex(5);
		((Control)showHESSLAButton).set_Text("GNU Affero General Public License");
		((ButtonBase)showHESSLAButton).set_UseVisualStyleBackColor(false);
		((Control)showHESSLAButton).add_Click((EventHandler)showLicenseButton_Click);
		((Control)labelVersion).set_Dock((DockStyle)5);
		((Control)labelVersion).set_Location(new Point(6, 86));
		((Control)labelVersion).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelVersion).set_MaximumSize(new Size(0, 17));
		((Control)labelVersion).set_Name("labelVersion");
		((Control)labelVersion).set_Size(new Size(312, 11));
		((Control)labelVersion).set_TabIndex(0);
		((Control)labelVersion).set_Text("Version");
		labelVersion.set_TextAlign((ContentAlignment)1024);
		((Control)textBoxDescription).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)textBoxDescription).set_Dock((DockStyle)5);
		((Control)textBoxDescription).set_Location(new Point(6, 100));
		((Control)textBoxDescription).set_Margin(new Padding(6, 3, 3, 3));
		((TextBoxBase)textBoxDescription).set_Multiline(true);
		((Control)textBoxDescription).set_Name("textBoxDescription");
		((TextBoxBase)textBoxDescription).set_ReadOnly(true);
		textBoxDescription.set_ScrollBars((ScrollBars)3);
		((Control)textBoxDescription).set_Size(new Size(312, 122));
		((Control)textBoxDescription).set_TabIndex(23);
		((Control)textBoxDescription).set_TabStop(false);
		((Control)textBoxDescription).set_Text(componentResourceManager.GetString("textBoxDescription.Text"));
		((Control)showGTOSButton).set_BackColor(SystemColors.ButtonFace);
		((Control)showGTOSButton).set_Dock((DockStyle)5);
		((Control)showGTOSButton).set_Location(new Point(3, 257));
		((Control)showGTOSButton).set_Name("showGTOSButton");
		((Control)showGTOSButton).set_Size(new Size(315, 23));
		((Control)showGTOSButton).set_TabIndex(3);
		((Control)showGTOSButton).set_Text("Google's Terms of Service");
		((ButtonBase)showGTOSButton).set_UseVisualStyleBackColor(false);
		((Control)showGTOSButton).add_Click((EventHandler)showGTOSButton_Click);
		((Control)pictureBox1).set_Anchor((AnchorStyles)1);
		((Control)pictureBox1).set_BackColor(SystemColors.Window);
		pictureBox1.set_Image((Image)(object)Resources.gscan_sm);
		((Control)pictureBox1).set_Location(new Point(37, 3));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(246, 80));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(27);
		pictureBox1.set_TabStop(false);
		((Control)panel2).get_Controls().Add((Control)(object)okButton);
		((Control)panel2).get_Controls().Add((Control)(object)showAtStartCB);
		((Control)panel2).set_Dock((DockStyle)5);
		((Control)panel2).set_Location(new Point(3, 286));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(315, 26));
		((Control)panel2).set_TabIndex(1);
		((Control)okButton).set_Anchor((AnchorStyles)10);
		((Control)okButton).set_BackColor(SystemColors.ButtonFace);
		okButton.set_DialogResult((DialogResult)2);
		((Control)okButton).set_Location(new Point(240, 4));
		((Control)okButton).set_Name("okButton");
		((Control)okButton).set_Size(new Size(75, 22));
		((Control)okButton).set_TabIndex(1);
		((Control)okButton).set_Text("&OK");
		((ButtonBase)okButton).set_UseVisualStyleBackColor(false);
		((Control)okButton).add_Click((EventHandler)OnOKClick);
		((Control)showAtStartCB).set_AutoSize(true);
		((Control)showAtStartCB).set_Location(new Point(6, 8));
		((Control)showAtStartCB).set_Name("showAtStartCB");
		((Control)showAtStartCB).set_Size(new Size(98, 17));
		((Control)showAtStartCB).set_TabIndex(4);
		((Control)showAtStartCB).set_Text("show at startup");
		((ButtonBase)showAtStartCB).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ControlLightLight);
		((Form)this).set_ClientSize(new Size(325, 319));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("About");
		((Control)this).set_Padding(new Padding(2));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("About");
		((Control)tableLayoutPanel).ResumeLayout(false);
		((Control)tableLayoutPanel).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public About()
	{
		InitializeComponent();
		((Control)this).set_Text($"About {AssemblyTitle}");
		((Control)labelVersion).set_Text($"Version {AssemblyVersion}");
		showAtStartCB.set_Checked(Settings.Default.ShowAboutAtStart);
		((Control)okButton).Focus();
		((Control)this).Update();
	}

	private void showLicenseButton_Click(object sender, EventArgs e)
	{
		OSUtils.OpenInBrowser("http://www.fsf.org/agplv3-pr");
	}

	private void showGTOSButton_Click(object sender, EventArgs e)
	{
		OSUtils.OpenInBrowser("http://www.google.com/accounts/TOS");
	}

	private void OnOKClick(object sender, EventArgs e)
	{
		if (showAtStartCB.get_Checked() != Settings.Default.ShowAboutAtStart)
		{
			Settings.Default.ShowAboutAtStart = showAtStartCB.get_Checked();
			((SettingsBase)Settings.Default).Save();
		}
		((Component)this).Dispose();
	}
}
