using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Proxy_Switcher.Properties;

namespace Proxy_Switcher;

internal class AboutForm : Form
{
	private IContainer components;

	private TableLayoutPanel tableLayoutPanel;

	private Label labelProductName;

	private Label labelVersion;

	private Label labelCopyright;

	private Label labelCompanyName;

	private TextBox textBoxDescription;

	private Button okButton;

	private Panel panel1;

	private PictureBox pictureBox1;

	private PictureBox logoPictureBox;

	private Label label1;

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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected O, but got Unknown
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutForm));
		tableLayoutPanel = new TableLayoutPanel();
		labelProductName = new Label();
		labelVersion = new Label();
		labelCopyright = new Label();
		labelCompanyName = new Label();
		textBoxDescription = new TextBox();
		okButton = new Button();
		panel1 = new Panel();
		pictureBox1 = new PictureBox();
		logoPictureBox = new PictureBox();
		label1 = new Label();
		((Control)tableLayoutPanel).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)logoPictureBox).BeginInit();
		((Control)this).SuspendLayout();
		tableLayoutPanel.set_ColumnCount(2);
		tableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 49.06166f));
		tableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50.93834f));
		tableLayoutPanel.get_Controls().Add((Control)(object)labelProductName, 1, 0);
		tableLayoutPanel.get_Controls().Add((Control)(object)labelVersion, 1, 1);
		tableLayoutPanel.get_Controls().Add((Control)(object)labelCopyright, 1, 2);
		tableLayoutPanel.get_Controls().Add((Control)(object)labelCompanyName, 1, 3);
		tableLayoutPanel.get_Controls().Add((Control)(object)textBoxDescription, 1, 4);
		tableLayoutPanel.get_Controls().Add((Control)(object)okButton, 1, 5);
		tableLayoutPanel.get_Controls().Add((Control)(object)panel1, 0, 0);
		((Control)tableLayoutPanel).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel).set_Location(new Point(9, 9));
		((Control)tableLayoutPanel).set_Name("tableLayoutPanel");
		tableLayoutPanel.set_RowCount(6);
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 11.66667f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 11.66667f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 16.66667f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 32.41379f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 20f));
		((Control)tableLayoutPanel).set_Size(new Size(438, 174));
		((Control)tableLayoutPanel).set_TabIndex(0);
		((Control)labelProductName).set_Dock((DockStyle)5);
		((Control)labelProductName).set_Location(new Point(220, 0));
		((Control)labelProductName).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelProductName).set_MaximumSize(new Size(0, 17));
		((Control)labelProductName).set_Name("labelProductName");
		((Control)labelProductName).set_Size(new Size(215, 16));
		((Control)labelProductName).set_TabIndex(19);
		((Control)labelProductName).set_Text("Product Name");
		labelProductName.set_TextAlign((ContentAlignment)16);
		((Control)labelVersion).set_Dock((DockStyle)5);
		((Control)labelVersion).set_Location(new Point(220, 16));
		((Control)labelVersion).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelVersion).set_MaximumSize(new Size(0, 17));
		((Control)labelVersion).set_Name("labelVersion");
		((Control)labelVersion).set_Size(new Size(215, 17));
		((Control)labelVersion).set_TabIndex(0);
		((Control)labelVersion).set_Text("Version");
		labelVersion.set_TextAlign((ContentAlignment)16);
		((Control)labelCopyright).set_Dock((DockStyle)5);
		((Control)labelCopyright).set_Location(new Point(220, 35));
		((Control)labelCopyright).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelCopyright).set_MaximumSize(new Size(0, 17));
		((Control)labelCopyright).set_Name("labelCopyright");
		((Control)labelCopyright).set_Size(new Size(215, 17));
		((Control)labelCopyright).set_TabIndex(21);
		((Control)labelCopyright).set_Text("Copyright");
		labelCopyright.set_TextAlign((ContentAlignment)16);
		((Control)labelCompanyName).set_Dock((DockStyle)5);
		((Control)labelCompanyName).set_Location(new Point(220, 54));
		((Control)labelCompanyName).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelCompanyName).set_MaximumSize(new Size(0, 17));
		((Control)labelCompanyName).set_Name("labelCompanyName");
		((Control)labelCompanyName).set_Size(new Size(215, 17));
		((Control)labelCompanyName).set_TabIndex(22);
		((Control)labelCompanyName).set_Text("Company Name");
		labelCompanyName.set_TextAlign((ContentAlignment)16);
		((Control)textBoxDescription).set_BackColor(Color.White);
		((Control)textBoxDescription).set_Dock((DockStyle)5);
		((Control)textBoxDescription).set_Location(new Point(220, 85));
		((Control)textBoxDescription).set_Margin(new Padding(6, 3, 3, 3));
		((TextBoxBase)textBoxDescription).set_Multiline(true);
		((Control)textBoxDescription).set_Name("textBoxDescription");
		((TextBoxBase)textBoxDescription).set_ReadOnly(true);
		textBoxDescription.set_ScrollBars((ScrollBars)3);
		((Control)textBoxDescription).set_Size(new Size(215, 49));
		((Control)textBoxDescription).set_TabIndex(23);
		((Control)textBoxDescription).set_TabStop(false);
		((Control)textBoxDescription).set_Text("Description");
		((Control)okButton).set_Anchor((AnchorStyles)10);
		okButton.set_DialogResult((DialogResult)2);
		((Control)okButton).set_Location(new Point(360, 148));
		((Control)okButton).set_Name("okButton");
		((Control)okButton).set_Size(new Size(75, 23));
		((Control)okButton).set_TabIndex(24);
		((Control)okButton).set_Text("&OK");
		((Control)panel1).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel1).get_Controls().Add((Control)(object)logoPictureBox);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).set_Dock((DockStyle)5);
		((Control)panel1).set_Location(new Point(3, 3));
		((Control)panel1).set_Name("panel1");
		tableLayoutPanel.SetRowSpan((Control)(object)panel1, 6);
		((Control)panel1).set_Size(new Size(208, 168));
		((Control)panel1).set_TabIndex(25);
		((Control)pictureBox1).set_Cursor(Cursors.get_Hand());
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(3, 119));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(70, 36));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox1.set_TabIndex(14);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)logoPictureBox).set_Dock((DockStyle)1);
		logoPictureBox.set_Image((Image)(object)Resources.logo);
		((Control)logoPictureBox).set_Location(new Point(0, 0));
		((Control)logoPictureBox).set_Name("logoPictureBox");
		((Control)logoPictureBox).set_Size(new Size(208, 67));
		logoPictureBox.set_TabIndex(13);
		logoPictureBox.set_TabStop(false);
		((Control)label1).set_ForeColor(Color.FromArgb(0, 0, 192));
		((Control)label1).set_Location(new Point(0, 82));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(171, 34));
		((Control)label1).set_TabIndex(15);
		((Control)label1).set_Text("If you find this application useful, please consider a donation.");
		((Form)this).set_AcceptButton((IButtonControl)(object)okButton);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(456, 192));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AboutForm");
		((Control)this).set_Padding(new Padding(9));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("AboutBox1");
		((Control)tableLayoutPanel).ResumeLayout(false);
		((Control)tableLayoutPanel).PerformLayout();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)logoPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public AboutForm()
	{
		InitializeComponent();
		((Control)this).set_Text($"About {AssemblyTitle}");
		((Control)labelProductName).set_Text(AssemblyProduct);
		((Control)labelVersion).set_Text($"Version {AssemblyVersion}");
		((Control)labelCopyright).set_Text(AssemblyCopyright);
		((Control)labelCompanyName).set_Text(AssemblyCompany);
		((Control)textBoxDescription).set_Text(AssemblyDescription);
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		Process.Start("IExplore.exe", "http://www.onyxbox.co.uk/software/ProxySwitcher/index.htm");
	}
}
