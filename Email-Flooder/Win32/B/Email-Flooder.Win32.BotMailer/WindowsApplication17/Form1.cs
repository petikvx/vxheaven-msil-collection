using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace WindowsApplication17;

public class Form1 : Form
{
	internal class MXRecord
	{
		public int preference;

		public string exchange;

		public MXRecord()
		{
			preference = -1;
			exchange = null;
		}

		public override string ToString()
		{
			return StringType.FromDouble(DoubleType.FromString("Preference : ") + (double)preference + DoubleType.FromString(" Exchange : ") + DoubleType.FromString(exchange));
		}
	}

	[AccessedThroughProperty("MenuItem11")]
	private MenuItem _MenuItem11;

	[AccessedThroughProperty("MenuItem12")]
	private MenuItem _MenuItem12;

	[AccessedThroughProperty("MenuItem15")]
	private MenuItem _MenuItem15;

	[AccessedThroughProperty("Httpproxies")]
	private MenuItem _Httpproxies;

	[AccessedThroughProperty("Status")]
	private Label _Status;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Button15")]
	private Button _Button15;

	[AccessedThroughProperty("Button14")]
	private Button _Button14;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Button16")]
	private Button _Button16;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("Button17")]
	private Button _Button17;

	[AccessedThroughProperty("Button13")]
	private Button _Button13;

	[AccessedThroughProperty("Button18")]
	private Button _Button18;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("log")]
	private LinkLabel _log;

	[AccessedThroughProperty("Button19")]
	private Button _Button19;

	[AccessedThroughProperty("Button12")]
	private Button _Button12;

	[AccessedThroughProperty("Listlog")]
	private ListBox _Listlog;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("MenuItem10")]
	private MenuItem _MenuItem10;

	[AccessedThroughProperty("HTML")]
	private CheckBox _HTML;

	[AccessedThroughProperty("MenuItem8")]
	private MenuItem _MenuItem8;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("TrackBar2")]
	private TrackBar _TrackBar2;

	[AccessedThroughProperty("Button11")]
	private Button _Button11;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Threads")]
	private Label _Threads;

	[AccessedThroughProperty("TrackBar1")]
	private TrackBar _TrackBar1;

	[AccessedThroughProperty("Proxylist2")]
	private ListBox _Proxylist2;

	[AccessedThroughProperty("textbox1111")]
	private TextBox _textbox1111;

	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("leechbox")]
	private TextBox _leechbox;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("RandomProxy")]
	private MenuItem _RandomProxy;

	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[AccessedThroughProperty("Stopchecking")]
	private CheckBox _Stopchecking;

	[AccessedThroughProperty("CheckAll")]
	private Button _CheckAll;

	[AccessedThroughProperty("loopback")]
	private MenuItem _loopback;

	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[AccessedThroughProperty("Button20")]
	private Button _Button20;

	[AccessedThroughProperty("MenuItem9")]
	private MenuItem _MenuItem9;

	[AccessedThroughProperty("Addaccnt")]
	private Button _Addaccnt;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("MenuItem24")]
	private MenuItem _MenuItem24;

	[AccessedThroughProperty("MenuItem23")]
	private MenuItem _MenuItem23;

	[AccessedThroughProperty("Save")]
	private Button _Save;

	[AccessedThroughProperty("ProxySMTP")]
	private TextBox _ProxySMTP;

	[AccessedThroughProperty("Delete")]
	private Button _Delete;

	[AccessedThroughProperty("CheckProxy")]
	private Button _CheckProxy;

	[AccessedThroughProperty("Proxylist")]
	private ListBox _Proxylist;

	[AccessedThroughProperty("Proxy")]
	private TextBox _Proxy;

	[AccessedThroughProperty("ProxyGroup")]
	private GroupBox _ProxyGroup;

	[AccessedThroughProperty("Popfirst")]
	private MenuItem _Popfirst;

	[AccessedThroughProperty("accnt")]
	private MenuItem _accnt;

	[AccessedThroughProperty("MenuItem5")]
	private MenuItem _MenuItem5;

	[AccessedThroughProperty("Send")]
	private MenuItem _Send;

	[AccessedThroughProperty("Uselistbox")]
	private MenuItem _Uselistbox;

	[AccessedThroughProperty("Subject")]
	private TextBox _Subject;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("MailingList")]
	private Panel _MailingList;

	[AccessedThroughProperty("OpenProxy")]
	private Button _OpenProxy;

	[AccessedThroughProperty("RealEmail")]
	private TextBox _RealEmail;

	[AccessedThroughProperty("SaveAccount")]
	private Button _SaveAccount;

	[AccessedThroughProperty("SaveFileDialog1")]
	private SaveFileDialog _SaveFileDialog1;

	[AccessedThroughProperty("clear")]
	private Button _clear;

	[AccessedThroughProperty("OpenSmtp")]
	private Button _OpenSmtp;

	[AccessedThroughProperty("password")]
	private TextBox _password;

	[AccessedThroughProperty("HideSMTP")]
	private Button _HideSMTP;

	[AccessedThroughProperty("SmtpAuth")]
	private Panel _SmtpAuth;

	[AccessedThroughProperty("smtp")]
	private TextBox _smtp;

	[AccessedThroughProperty("pop3")]
	private TextBox _pop3;

	[AccessedThroughProperty("username")]
	private TextBox _username;

	[AccessedThroughProperty("Accountlist")]
	private ListBox _Accountlist;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Message")]
	private Panel _Message;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Fromname")]
	private TextBox _Fromname;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Body")]
	private RichTextBox _Body;

	[AccessedThroughProperty("ToName")]
	private TextBox _ToName;

	[AccessedThroughProperty("ReplyTo")]
	private TextBox _ReplyTo;

	[AccessedThroughProperty("From")]
	private TextBox _From;

	[AccessedThroughProperty("Recipient")]
	private TextBox _Recipient;

	[AccessedThroughProperty("MenuItem22")]
	private MenuItem _MenuItem22;

	[AccessedThroughProperty("MenuItem21")]
	private MenuItem _MenuItem21;

	[AccessedThroughProperty("MenuItem18")]
	private MenuItem _MenuItem18;

	[AccessedThroughProperty("HideProxy")]
	private Button _HideProxy;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	[AccessedThroughProperty("CloseAbout")]
	private Button _CloseAbout;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("MenuItem20")]
	private MenuItem _MenuItem20;

	[AccessedThroughProperty("MenuItem19")]
	private MenuItem _MenuItem19;

	[AccessedThroughProperty("MenuItem17")]
	private MenuItem _MenuItem17;

	[AccessedThroughProperty("MenuItem16")]
	private MenuItem _MenuItem16;

	[AccessedThroughProperty("MenuItem14")]
	private MenuItem _MenuItem14;

	[AccessedThroughProperty("MenuItem13")]
	private MenuItem _MenuItem13;

	[AccessedThroughProperty("MenuItem7")]
	private MenuItem _MenuItem7;

	[AccessedThroughProperty("MenuItem6")]
	private MenuItem _MenuItem6;

	[AccessedThroughProperty("MenuItem4")]
	private MenuItem _MenuItem4;

	[AccessedThroughProperty("MenuItem3")]
	private MenuItem _MenuItem3;

	[AccessedThroughProperty("MenuItem2")]
	private MenuItem _MenuItem2;

	[AccessedThroughProperty("List")]
	private MenuItem _List;

	[AccessedThroughProperty("MenuItem1")]
	private MenuItem _MenuItem1;

	[AccessedThroughProperty("MainMenu1")]
	private MainMenu _MainMenu1;

	[AccessedThroughProperty("ListBox2")]
	private ListBox _ListBox2;

	private string Sylonious;

	private IContainer components;

	private string Useautoheaders;

	private string[] Domain2;

	private string Domain3;

	private string domainfake;

	private string ip;

	private int i;

	private byte[] data;

	private int position;

	private int id;

	private int length;

	private static int PORT = 53;

	private Encoding ASCII;

	private string Mailserver1;

	private string Mailserver;

	private string Mailserver2;

	private string Error1;

	private string Error2;

	private int P;

	private int MessagesSent;

	private string JJ33;

	public int qou;

	public int ppou;

	private string UsePop;

	private string Useaccount;

	private string Htmlcheck;

	private Socket sock;

	private string RandomProxies;

	private string UseBuiltinSMTP;

	private string Pretendbemx;

	internal virtual TextBox pop3
	{
		get
		{
			return _pop3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_pop3 == null)
			{
			}
			_pop3 = value;
			if (_pop3 != null)
			{
			}
		}
	}

	internal virtual Button Addaccnt
	{
		get
		{
			return _Addaccnt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Addaccnt != null)
			{
				((Control)_Addaccnt).remove_Click((EventHandler)Addaccnt_Click);
			}
			_Addaccnt = value;
			if (_Addaccnt != null)
			{
				((Control)_Addaccnt).add_Click((EventHandler)Addaccnt_Click);
			}
		}
	}

	internal virtual MenuItem MenuItem13
	{
		get
		{
			return _MenuItem13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem13 != null)
			{
				_MenuItem13.remove_Click((EventHandler)MenuItem13_Click);
			}
			_MenuItem13 = value;
			if (_MenuItem13 != null)
			{
				_MenuItem13.add_Click((EventHandler)MenuItem13_Click);
			}
		}
	}

	internal virtual Button Button15
	{
		get
		{
			return _Button15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button15 == null)
			{
			}
			_Button15 = value;
			if (_Button15 != null)
			{
			}
		}
	}

	internal virtual TextBox smtp
	{
		get
		{
			return _smtp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_smtp == null)
			{
			}
			_smtp = value;
			if (_smtp != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem9
	{
		get
		{
			return _MenuItem9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem9 != null)
			{
				_MenuItem9.remove_Click((EventHandler)MenuItem9_Click);
			}
			_MenuItem9 = value;
			if (_MenuItem9 != null)
			{
				_MenuItem9.add_Click((EventHandler)MenuItem9_Click);
			}
		}
	}

	internal virtual MenuItem MenuItem14
	{
		get
		{
			return _MenuItem14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem14 != null)
			{
				_MenuItem14.remove_Click((EventHandler)MenuItem14_Click);
			}
			_MenuItem14 = value;
			if (_MenuItem14 != null)
			{
				_MenuItem14.add_Click((EventHandler)MenuItem14_Click);
			}
		}
	}

	internal virtual Button Button5
	{
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button5 != null)
			{
				((Control)_Button5).remove_Click((EventHandler)Button5_Click_2);
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				((Control)_Button5).add_Click((EventHandler)Button5_Click_2);
			}
		}
	}

	internal virtual Panel SmtpAuth
	{
		get
		{
			return _SmtpAuth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_SmtpAuth == null)
			{
			}
			_SmtpAuth = value;
			if (_SmtpAuth != null)
			{
			}
		}
	}

	internal virtual Button Button7
	{
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button7 != null)
			{
				((Control)_Button7).remove_Click((EventHandler)Button7_Click);
			}
			_Button7 = value;
			if (_Button7 != null)
			{
				((Control)_Button7).add_Click((EventHandler)Button7_Click);
			}
		}
	}

	internal virtual MenuItem MenuItem16
	{
		get
		{
			return _MenuItem16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem16 != null)
			{
				_MenuItem16.remove_Click((EventHandler)MenuItem16_Click);
			}
			_MenuItem16 = value;
			if (_MenuItem16 != null)
			{
				_MenuItem16.add_Click((EventHandler)MenuItem16_Click);
			}
		}
	}

	internal virtual Label Label17
	{
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label17 == null)
			{
			}
			_Label17 = value;
			if (_Label17 != null)
			{
			}
		}
	}

	internal virtual Button HideSMTP
	{
		get
		{
			return _HideSMTP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_HideSMTP != null)
			{
				((Control)_HideSMTP).remove_Click((EventHandler)HideSMTP_Click);
			}
			_HideSMTP = value;
			if (_HideSMTP != null)
			{
				((Control)_HideSMTP).add_Click((EventHandler)HideSMTP_Click);
			}
		}
	}

	internal virtual MenuItem loopback
	{
		get
		{
			return _loopback;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_loopback != null)
			{
				_loopback.remove_Click((EventHandler)loopback_Click);
			}
			_loopback = value;
			if (_loopback != null)
			{
				_loopback.add_Click((EventHandler)loopback_Click);
			}
		}
	}

	internal virtual MenuItem MenuItem17
	{
		get
		{
			return _MenuItem17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem17 != null)
			{
				_MenuItem17.remove_Click((EventHandler)MenuItem17_Click);
			}
			_MenuItem17 = value;
			if (_MenuItem17 != null)
			{
				_MenuItem17.add_Click((EventHandler)MenuItem17_Click);
			}
		}
	}

	internal virtual MenuItem Httpproxies
	{
		get
		{
			return _Httpproxies;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Httpproxies != null)
			{
				_Httpproxies.remove_Click((EventHandler)Httpproxies_Click);
			}
			_Httpproxies = value;
			if (_Httpproxies != null)
			{
				_Httpproxies.add_Click((EventHandler)Httpproxies_Click);
			}
		}
	}

	internal virtual TextBox password
	{
		get
		{
			return _password;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_password == null)
			{
			}
			_password = value;
			if (_password != null)
			{
			}
		}
	}

	internal virtual Button CheckAll
	{
		get
		{
			return _CheckAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_CheckAll != null)
			{
				((Control)_CheckAll).remove_Click((EventHandler)CheckAll_Click);
			}
			_CheckAll = value;
			if (_CheckAll != null)
			{
				((Control)_CheckAll).add_Click((EventHandler)CheckAll_Click);
			}
		}
	}

	internal virtual MenuItem MenuItem19
	{
		get
		{
			return _MenuItem19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem19 != null)
			{
				_MenuItem19.remove_Click((EventHandler)MenuItem19_Click);
			}
			_MenuItem19 = value;
			if (_MenuItem19 != null)
			{
				_MenuItem19.add_Click((EventHandler)MenuItem19_Click);
			}
		}
	}

	internal virtual MenuItem MenuItem15
	{
		get
		{
			return _MenuItem15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem15 == null)
			{
			}
			_MenuItem15 = value;
			if (_MenuItem15 != null)
			{
			}
		}
	}

	internal virtual Button OpenSmtp
	{
		get
		{
			return _OpenSmtp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_OpenSmtp != null)
			{
				((Control)_OpenSmtp).remove_Click((EventHandler)OpenSmtp_Click);
			}
			_OpenSmtp = value;
			if (_OpenSmtp != null)
			{
				((Control)_OpenSmtp).add_Click((EventHandler)OpenSmtp_Click);
			}
		}
	}

	internal virtual MenuItem MenuItem20
	{
		get
		{
			return _MenuItem20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem20 != null)
			{
				_MenuItem20.remove_Click((EventHandler)MenuItem20_Click);
			}
			_MenuItem20 = value;
			if (_MenuItem20 != null)
			{
				_MenuItem20.add_Click((EventHandler)MenuItem20_Click);
			}
		}
	}

	internal virtual CheckBox Stopchecking
	{
		get
		{
			return _Stopchecking;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Stopchecking == null)
			{
			}
			_Stopchecking = value;
			if (_Stopchecking != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem12
	{
		get
		{
			return _MenuItem12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem12 == null)
			{
			}
			_MenuItem12 = value;
			if (_MenuItem12 != null)
			{
			}
		}
	}

	internal virtual Button clear
	{
		get
		{
			return _clear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_clear != null)
			{
				((Control)_clear).remove_Click((EventHandler)Button2_Click);
			}
			_clear = value;
			if (_clear != null)
			{
				((Control)_clear).add_Click((EventHandler)Button2_Click);
			}
		}
	}

	internal virtual Panel Panel1
	{
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Panel1 == null)
			{
			}
			_Panel1 = value;
			if (_Panel1 != null)
			{
			}
		}
	}

	internal virtual Button Button8
	{
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button8 != null)
			{
				((Control)_Button8).remove_Click((EventHandler)Button8_Click);
			}
			_Button8 = value;
			if (_Button8 != null)
			{
				((Control)_Button8).add_Click((EventHandler)Button8_Click);
			}
		}
	}

	internal virtual MenuItem MenuItem11
	{
		get
		{
			return _MenuItem11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem11 == null)
			{
			}
			_MenuItem11 = value;
			if (_MenuItem11 != null)
			{
			}
		}
	}

	internal virtual SaveFileDialog SaveFileDialog1
	{
		get
		{
			return _SaveFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_SaveFileDialog1 == null)
			{
			}
			_SaveFileDialog1 = value;
			if (_SaveFileDialog1 != null)
			{
			}
		}
	}

	internal virtual Button CloseAbout
	{
		get
		{
			return _CloseAbout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_CloseAbout != null)
			{
				((Control)_CloseAbout).remove_Click((EventHandler)CloseAbout_Click);
			}
			_CloseAbout = value;
			if (_CloseAbout != null)
			{
				((Control)_CloseAbout).add_Click((EventHandler)CloseAbout_Click);
			}
		}
	}

	internal virtual Button Button9
	{
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button9 != null)
			{
				((Control)_Button9).remove_Click((EventHandler)Button9_Click);
			}
			_Button9 = value;
			if (_Button9 != null)
			{
				((Control)_Button9).add_Click((EventHandler)Button9_Click);
			}
		}
	}

	internal virtual ListBox ListBox2
	{
		get
		{
			return _ListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ListBox2 == null)
			{
			}
			_ListBox2 = value;
			if (_ListBox2 != null)
			{
			}
		}
	}

	internal virtual Button SaveAccount
	{
		get
		{
			return _SaveAccount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_SaveAccount != null)
			{
				((Control)_SaveAccount).remove_Click((EventHandler)SaveAccount_Click);
			}
			_SaveAccount = value;
			if (_SaveAccount != null)
			{
				((Control)_SaveAccount).add_Click((EventHandler)SaveAccount_Click);
			}
		}
	}

	internal virtual OpenFileDialog OpenFileDialog1
	{
		get
		{
			return _OpenFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_OpenFileDialog1 == null)
			{
			}
			_OpenFileDialog1 = value;
			if (_OpenFileDialog1 != null)
			{
			}
		}
	}

	internal virtual MenuItem RandomProxy
	{
		get
		{
			return _RandomProxy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_RandomProxy != null)
			{
				_RandomProxy.remove_Click((EventHandler)RandomProxy_Click);
			}
			_RandomProxy = value;
			if (_RandomProxy != null)
			{
				_RandomProxy.add_Click((EventHandler)RandomProxy_Click);
			}
		}
	}

	internal virtual Button Button16
	{
		get
		{
			return _Button16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button16 != null)
			{
				((Control)_Button16).remove_Click((EventHandler)Button16_Click);
			}
			_Button16 = value;
			if (_Button16 != null)
			{
				((Control)_Button16).add_Click((EventHandler)Button16_Click);
			}
		}
	}

	internal virtual TextBox RealEmail
	{
		get
		{
			return _RealEmail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_RealEmail == null)
			{
			}
			_RealEmail = value;
			if (_RealEmail != null)
			{
			}
		}
	}

	internal virtual Panel Panel2
	{
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Panel2 == null)
			{
			}
			_Panel2 = value;
			if (_Panel2 != null)
			{
			}
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_LinkLabel1 == null)
			{
			}
			_LinkLabel1 = value;
			if (_LinkLabel1 != null)
			{
			}
		}
	}

	internal virtual Button Button17
	{
		get
		{
			return _Button17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button17 == null)
			{
			}
			_Button17 = value;
			if (_Button17 != null)
			{
			}
		}
	}

	internal virtual Button OpenProxy
	{
		get
		{
			return _OpenProxy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_OpenProxy != null)
			{
				((Control)_OpenProxy).remove_Click((EventHandler)OpenProxy_Click);
			}
			_OpenProxy = value;
			if (_OpenProxy != null)
			{
				((Control)_OpenProxy).add_Click((EventHandler)OpenProxy_Click);
			}
		}
	}

	internal virtual Button HideProxy
	{
		get
		{
			return _HideProxy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_HideProxy != null)
			{
				((Control)_HideProxy).remove_Click((EventHandler)HideProxy_Click);
			}
			_HideProxy = value;
			if (_HideProxy != null)
			{
				((Control)_HideProxy).add_Click((EventHandler)HideProxy_Click);
			}
		}
	}

	internal virtual Label Label21
	{
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label21 == null)
			{
			}
			_Label21 = value;
			if (_Label21 != null)
			{
			}
		}
	}

	internal virtual Button Button18
	{
		get
		{
			return _Button18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button18 == null)
			{
			}
			_Button18 = value;
			if (_Button18 != null)
			{
			}
		}
	}

	internal virtual Panel MailingList
	{
		get
		{
			return _MailingList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MailingList == null)
			{
			}
			_MailingList = value;
			if (_MailingList != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem18
	{
		get
		{
			return _MenuItem18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem18 != null)
			{
				_MenuItem18.remove_Click((EventHandler)MenuItem18_Click);
			}
			_MenuItem18 = value;
			if (_MenuItem18 != null)
			{
				_MenuItem18.add_Click((EventHandler)MenuItem18_Click);
			}
		}
	}

	internal virtual Button Button10
	{
		get
		{
			return _Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button10 != null)
			{
				((Control)_Button10).remove_Click((EventHandler)Button10_Click);
			}
			_Button10 = value;
			if (_Button10 != null)
			{
				((Control)_Button10).add_Click((EventHandler)Button10_Click);
			}
		}
	}

	internal virtual Button Button19
	{
		get
		{
			return _Button19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button19 == null)
			{
			}
			_Button19 = value;
			if (_Button19 != null)
			{
			}
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click((EventHandler)Button1_Click_1);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click((EventHandler)Button1_Click_1);
			}
		}
	}

	internal virtual MenuItem MenuItem21
	{
		get
		{
			return _MenuItem21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem21 != null)
			{
				_MenuItem21.remove_Click((EventHandler)MenuItem21_Click);
			}
			_MenuItem21 = value;
			if (_MenuItem21 != null)
			{
				_MenuItem21.add_Click((EventHandler)MenuItem21_Click);
			}
		}
	}

	internal virtual TextBox textbox1111
	{
		get
		{
			return _textbox1111;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_textbox1111 == null)
			{
			}
			_textbox1111 = value;
			if (_textbox1111 != null)
			{
			}
		}
	}

	internal virtual TextBox leechbox
	{
		get
		{
			return _leechbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_leechbox == null)
			{
			}
			_leechbox = value;
			if (_leechbox != null)
			{
			}
		}
	}

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ListBox1 == null)
			{
			}
			_ListBox1 = value;
			if (_ListBox1 != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem22
	{
		get
		{
			return _MenuItem22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem22 != null)
			{
				_MenuItem22.remove_Click((EventHandler)MenuItem22_Click);
			}
			_MenuItem22 = value;
			if (_MenuItem22 != null)
			{
				_MenuItem22.add_Click((EventHandler)MenuItem22_Click);
			}
		}
	}

	internal virtual ListBox Proxylist2
	{
		get
		{
			return _Proxylist2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Proxylist2 != null)
			{
				_Proxylist2.remove_SelectedIndexChanged((EventHandler)Proxylist2_SelectedIndexChanged);
			}
			_Proxylist2 = value;
			if (_Proxylist2 != null)
			{
				_Proxylist2.add_SelectedIndexChanged((EventHandler)Proxylist2_SelectedIndexChanged);
			}
		}
	}

	internal virtual Button Button20
	{
		get
		{
			return _Button20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button20 != null)
			{
				((Control)_Button20).remove_Click((EventHandler)Button20_Click);
			}
			_Button20 = value;
			if (_Button20 != null)
			{
				((Control)_Button20).add_Click((EventHandler)Button20_Click);
			}
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
				((Control)_Button2).remove_Click((EventHandler)Button2_Click_1);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click((EventHandler)Button2_Click_1);
			}
		}
	}

	internal virtual TextBox Recipient
	{
		get
		{
			return _Recipient;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Recipient == null)
			{
			}
			_Recipient = value;
			if (_Recipient != null)
			{
			}
		}
	}

	internal virtual TrackBar TrackBar1
	{
		get
		{
			return _TrackBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_TrackBar1 == null)
			{
			}
			_TrackBar1 = value;
			if (_TrackBar1 != null)
			{
			}
		}
	}

	internal virtual TextBox ProxySMTP
	{
		get
		{
			return _ProxySMTP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ProxySMTP == null)
			{
			}
			_ProxySMTP = value;
			if (_ProxySMTP != null)
			{
			}
		}
	}

	internal virtual Button Button3
	{
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button3 != null)
			{
				((Control)_Button3).remove_Click((EventHandler)Button3_Click);
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).add_Click((EventHandler)Button3_Click);
			}
		}
	}

	internal virtual TextBox From
	{
		get
		{
			return _From;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_From == null)
			{
			}
			_From = value;
			if (_From != null)
			{
			}
		}
	}

	internal virtual Label Threads
	{
		get
		{
			return _Threads;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Threads == null)
			{
			}
			_Threads = value;
			if (_Threads != null)
			{
			}
		}
	}

	internal virtual LinkLabel log
	{
		get
		{
			return _log;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			if (_log != null)
			{
				_log.remove_LinkClicked(new LinkLabelLinkClickedEventHandler(log_LinkClicked));
			}
			_log = value;
			if (_log != null)
			{
				_log.add_LinkClicked(new LinkLabelLinkClickedEventHandler(log_LinkClicked));
			}
		}
	}

	internal virtual Button Button4
	{
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button4 != null)
			{
				((Control)_Button4).remove_Click((EventHandler)Button4_Click);
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				((Control)_Button4).add_Click((EventHandler)Button4_Click);
			}
		}
	}

	internal virtual TextBox ReplyTo
	{
		get
		{
			return _ReplyTo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ReplyTo == null)
			{
			}
			_ReplyTo = value;
			if (_ReplyTo != null)
			{
			}
		}
	}

	internal virtual Label Label11
	{
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label11 == null)
			{
			}
			_Label11 = value;
			if (_Label11 != null)
			{
			}
		}
	}

	internal virtual TextBox Subject
	{
		get
		{
			return _Subject;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Subject == null)
			{
			}
			_Subject = value;
			if (_Subject != null)
			{
			}
		}
	}

	internal virtual TextBox ToName
	{
		get
		{
			return _ToName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ToName == null)
			{
			}
			_ToName = value;
			if (_ToName != null)
			{
			}
		}
	}

	internal virtual Button Button11
	{
		get
		{
			return _Button11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button11 != null)
			{
				((Control)_Button11).remove_Click((EventHandler)Button11_Click);
			}
			_Button11 = value;
			if (_Button11 != null)
			{
				((Control)_Button11).add_Click((EventHandler)Button11_Click);
			}
		}
	}

	internal virtual MenuItem Uselistbox
	{
		get
		{
			return _Uselistbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Uselistbox != null)
			{
				_Uselistbox.remove_Click((EventHandler)Uselistbox_Click);
			}
			_Uselistbox = value;
			if (_Uselistbox != null)
			{
				_Uselistbox.add_Click((EventHandler)Uselistbox_Click);
			}
		}
	}

	internal virtual RichTextBox Body
	{
		get
		{
			return _Body;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Body == null)
			{
			}
			_Body = value;
			if (_Body != null)
			{
			}
		}
	}

	internal virtual TrackBar TrackBar2
	{
		get
		{
			return _TrackBar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_TrackBar2 == null)
			{
			}
			_TrackBar2 = value;
			if (_TrackBar2 != null)
			{
			}
		}
	}

	internal virtual MenuItem Send
	{
		get
		{
			return _Send;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Send != null)
			{
				_Send.remove_Click((EventHandler)Send_Click);
			}
			_Send = value;
			if (_Send != null)
			{
				_Send.add_Click((EventHandler)Send_Click);
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
			if (_Label1 == null)
			{
			}
			_Label1 = value;
			if (_Label1 != null)
			{
			}
		}
	}

	internal virtual Label Label12
	{
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label12 == null)
			{
			}
			_Label12 = value;
			if (_Label12 != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem5
	{
		get
		{
			return _MenuItem5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem5 == null)
			{
			}
			_MenuItem5 = value;
			if (_MenuItem5 != null)
			{
			}
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
			if (_Label2 == null)
			{
			}
			_Label2 = value;
			if (_Label2 != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem8
	{
		get
		{
			return _MenuItem8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem8 != null)
			{
				_MenuItem8.remove_Click((EventHandler)MenuItem8_Click_1);
			}
			_MenuItem8 = value;
			if (_MenuItem8 != null)
			{
				_MenuItem8.add_Click((EventHandler)MenuItem8_Click_1);
			}
		}
	}

	internal virtual MenuItem accnt
	{
		get
		{
			return _accnt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_accnt != null)
			{
				_accnt.remove_Click((EventHandler)accnt_Click_1);
			}
			_accnt = value;
			if (_accnt != null)
			{
				_accnt.add_Click((EventHandler)accnt_Click_1);
			}
		}
	}

	internal virtual TextBox Fromname
	{
		get
		{
			return _Fromname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Fromname == null)
			{
			}
			_Fromname = value;
			if (_Fromname != null)
			{
			}
		}
	}

	internal virtual CheckBox HTML
	{
		get
		{
			return _HTML;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_HTML == null)
			{
			}
			_HTML = value;
			if (_HTML != null)
			{
			}
		}
	}

	internal virtual MenuItem Popfirst
	{
		get
		{
			return _Popfirst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Popfirst != null)
			{
				_Popfirst.remove_Click((EventHandler)Popfirst_Click_1);
			}
			_Popfirst = value;
			if (_Popfirst != null)
			{
				_Popfirst.add_Click((EventHandler)Popfirst_Click_1);
			}
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label3 == null)
			{
			}
			_Label3 = value;
			if (_Label3 != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem10
	{
		get
		{
			return _MenuItem10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem10 != null)
			{
				_MenuItem10.remove_Click((EventHandler)MenuItem10_Click);
			}
			_MenuItem10 = value;
			if (_MenuItem10 != null)
			{
				_MenuItem10.add_Click((EventHandler)MenuItem10_Click);
			}
		}
	}

	internal virtual GroupBox ProxyGroup
	{
		get
		{
			return _ProxyGroup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ProxyGroup == null)
			{
			}
			_ProxyGroup = value;
			if (_ProxyGroup != null)
			{
			}
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label4 == null)
			{
			}
			_Label4 = value;
			if (_Label4 != null)
			{
			}
		}
	}

	internal virtual Panel Panel3
	{
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Panel3 == null)
			{
			}
			_Panel3 = value;
			if (_Panel3 != null)
			{
			}
		}
	}

	internal virtual TextBox Proxy
	{
		get
		{
			return _Proxy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Proxy == null)
			{
			}
			_Proxy = value;
			if (_Proxy != null)
			{
			}
		}
	}

	internal virtual Label Label5
	{
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label5 == null)
			{
			}
			_Label5 = value;
			if (_Label5 != null)
			{
			}
		}
	}

	internal virtual MainMenu MainMenu1
	{
		get
		{
			return _MainMenu1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MainMenu1 == null)
			{
			}
			_MainMenu1 = value;
			if (_MainMenu1 != null)
			{
			}
		}
	}

	internal virtual ListBox Listlog
	{
		get
		{
			return _Listlog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Listlog == null)
			{
			}
			_Listlog = value;
			if (_Listlog != null)
			{
			}
		}
	}

	internal virtual ListBox Proxylist
	{
		get
		{
			return _Proxylist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Proxylist != null)
			{
				_Proxylist.remove_SelectedIndexChanged((EventHandler)Proxylist_SelectedIndexChanged);
			}
			_Proxylist = value;
			if (_Proxylist != null)
			{
				_Proxylist.add_SelectedIndexChanged((EventHandler)Proxylist_SelectedIndexChanged);
			}
		}
	}

	internal virtual Label Label10
	{
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label10 == null)
			{
			}
			_Label10 = value;
			if (_Label10 != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem1
	{
		get
		{
			return _MenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem1 != null)
			{
				_MenuItem1.remove_Click((EventHandler)MenuItem1_Click);
			}
			_MenuItem1 = value;
			if (_MenuItem1 != null)
			{
				_MenuItem1.add_Click((EventHandler)MenuItem1_Click);
			}
		}
	}

	internal virtual Button Button12
	{
		get
		{
			return _Button12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button12 != null)
			{
				((Control)_Button12).remove_Click((EventHandler)Button12_Click);
			}
			_Button12 = value;
			if (_Button12 != null)
			{
				((Control)_Button12).add_Click((EventHandler)Button12_Click);
			}
		}
	}

	internal virtual Button CheckProxy
	{
		get
		{
			return _CheckProxy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_CheckProxy != null)
			{
				((Control)_CheckProxy).remove_Click((EventHandler)CheckProxy_Click);
			}
			_CheckProxy = value;
			if (_CheckProxy != null)
			{
				((Control)_CheckProxy).add_Click((EventHandler)CheckProxy_Click);
			}
		}
	}

	internal virtual Label Label9
	{
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label9 == null)
			{
			}
			_Label9 = value;
			if (_Label9 != null)
			{
			}
		}
	}

	internal virtual MenuItem List
	{
		get
		{
			return _List;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_List == null)
			{
			}
			_List = value;
			if (_List != null)
			{
			}
		}
	}

	internal virtual Label Label13
	{
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label13 == null)
			{
			}
			_Label13 = value;
			if (_Label13 != null)
			{
			}
		}
	}

	internal virtual Button Delete
	{
		get
		{
			return _Delete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Delete != null)
			{
				((Control)_Delete).remove_Click((EventHandler)Delete_Click);
			}
			_Delete = value;
			if (_Delete != null)
			{
				((Control)_Delete).add_Click((EventHandler)Delete_Click);
			}
		}
	}

	internal virtual Label Label8
	{
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label8 == null)
			{
			}
			_Label8 = value;
			if (_Label8 != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem2
	{
		get
		{
			return _MenuItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem2 == null)
			{
			}
			_MenuItem2 = value;
			if (_MenuItem2 != null)
			{
			}
		}
	}

	internal virtual Label Label14
	{
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label14 == null)
			{
			}
			_Label14 = value;
			if (_Label14 != null)
			{
			}
		}
	}

	internal virtual Label Label7
	{
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label7 == null)
			{
			}
			_Label7 = value;
			if (_Label7 != null)
			{
			}
		}
	}

	internal virtual Button Save
	{
		get
		{
			return _Save;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Save != null)
			{
				((Control)_Save).remove_Click((EventHandler)Save_Click);
			}
			_Save = value;
			if (_Save != null)
			{
				((Control)_Save).add_Click((EventHandler)Save_Click);
			}
		}
	}

	internal virtual MenuItem MenuItem3
	{
		get
		{
			return _MenuItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem3 == null)
			{
			}
			_MenuItem3 = value;
			if (_MenuItem3 != null)
			{
			}
		}
	}

	internal virtual Button Button13
	{
		get
		{
			return _Button13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button13 != null)
			{
				((Control)_Button13).remove_Click((EventHandler)Button13_Click);
			}
			_Button13 = value;
			if (_Button13 != null)
			{
				((Control)_Button13).add_Click((EventHandler)Button13_Click);
			}
		}
	}

	internal virtual Label Label6
	{
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label6 == null)
			{
			}
			_Label6 = value;
			if (_Label6 != null)
			{
			}
		}
	}

	internal virtual MenuItem MenuItem23
	{
		get
		{
			return _MenuItem23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem23 != null)
			{
				_MenuItem23.remove_Click((EventHandler)MenuItem23_Click);
			}
			_MenuItem23 = value;
			if (_MenuItem23 != null)
			{
				_MenuItem23.add_Click((EventHandler)MenuItem23_Click);
			}
		}
	}

	internal virtual MenuItem MenuItem4
	{
		get
		{
			return _MenuItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem4 == null)
			{
			}
			_MenuItem4 = value;
			if (_MenuItem4 != null)
			{
			}
		}
	}

	internal virtual Panel Panel4
	{
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Panel4 == null)
			{
			}
			_Panel4 = value;
			if (_Panel4 != null)
			{
			}
		}
	}

	internal virtual ListBox Accountlist
	{
		get
		{
			return _Accountlist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Accountlist != null)
			{
				_Accountlist.remove_SelectedIndexChanged((EventHandler)Accountlist_SelectedIndexChanged);
			}
			_Accountlist = value;
			if (_Accountlist != null)
			{
				_Accountlist.add_SelectedIndexChanged((EventHandler)Accountlist_SelectedIndexChanged);
			}
		}
	}

	internal virtual MenuItem MenuItem24
	{
		get
		{
			return _MenuItem24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem24 != null)
			{
				_MenuItem24.remove_Click((EventHandler)MenuItem24_Click);
			}
			_MenuItem24 = value;
			if (_MenuItem24 != null)
			{
				_MenuItem24.add_Click((EventHandler)MenuItem24_Click);
			}
		}
	}

	internal virtual MenuItem MenuItem6
	{
		get
		{
			return _MenuItem6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem6 != null)
			{
				_MenuItem6.remove_Click((EventHandler)MenuItem6_Click);
			}
			_MenuItem6 = value;
			if (_MenuItem6 != null)
			{
				_MenuItem6.add_Click((EventHandler)MenuItem6_Click);
			}
		}
	}

	internal virtual Label Label15
	{
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label15 == null)
			{
			}
			_Label15 = value;
			if (_Label15 != null)
			{
			}
		}
	}

	internal virtual Panel Message
	{
		get
		{
			return _Message;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Message == null)
			{
			}
			_Message = value;
			if (_Message != null)
			{
			}
		}
	}

	internal virtual TextBox username
	{
		get
		{
			return _username;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_username == null)
			{
			}
			_username = value;
			if (_username != null)
			{
			}
		}
	}

	internal virtual Button Button6
	{
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button6 != null)
			{
				((Control)_Button6).remove_Click((EventHandler)Button6_Click);
			}
			_Button6 = value;
			if (_Button6 != null)
			{
				((Control)_Button6).add_Click((EventHandler)Button6_Click);
			}
		}
	}

	internal virtual MenuItem MenuItem7
	{
		get
		{
			return _MenuItem7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MenuItem7 == null)
			{
			}
			_MenuItem7 = value;
			if (_MenuItem7 != null)
			{
			}
		}
	}

	internal virtual Label Status
	{
		get
		{
			return _Status;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Status == null)
			{
			}
			_Status = value;
			if (_Status != null)
			{
			}
		}
	}

	internal virtual Button Button14
	{
		get
		{
			return _Button14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Button14 != null)
			{
				((Control)_Button14).remove_Click((EventHandler)Button14_Click);
			}
			_Button14 = value;
			if (_Button14 != null)
			{
				((Control)_Button14).add_Click((EventHandler)Button14_Click);
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new Form1());
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_Closed((EventHandler)Form1_closed);
		ASCII = Encoding.ASCII;
		P = 0;
		qou = 0;
		ppou = 0;
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
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected O, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected O, but got Unknown
		//IL_0bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be7: Expected O, but got Unknown
		//IL_1f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8f: Expected O, but got Unknown
		//IL_2078: Unknown result type (might be due to invalid IL or missing references)
		//IL_2082: Expected O, but got Unknown
		//IL_3582: Unknown result type (might be due to invalid IL or missing references)
		//IL_358c: Expected O, but got Unknown
		//IL_3626: Unknown result type (might be due to invalid IL or missing references)
		//IL_3630: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager(typeof(Form1));
		MainMenu1 = new MainMenu();
		MenuItem1 = new MenuItem();
		Send = new MenuItem();
		MenuItem6 = new MenuItem();
		MenuItem11 = new MenuItem();
		MenuItem7 = new MenuItem();
		MenuItem19 = new MenuItem();
		MenuItem20 = new MenuItem();
		MenuItem23 = new MenuItem();
		MenuItem18 = new MenuItem();
		MenuItem21 = new MenuItem();
		MenuItem22 = new MenuItem();
		MenuItem24 = new MenuItem();
		List = new MenuItem();
		MenuItem9 = new MenuItem();
		Uselistbox = new MenuItem();
		MenuItem2 = new MenuItem();
		loopback = new MenuItem();
		RandomProxy = new MenuItem();
		MenuItem12 = new MenuItem();
		Httpproxies = new MenuItem();
		MenuItem3 = new MenuItem();
		MenuItem13 = new MenuItem();
		MenuItem14 = new MenuItem();
		MenuItem17 = new MenuItem();
		MenuItem5 = new MenuItem();
		accnt = new MenuItem();
		Popfirst = new MenuItem();
		MenuItem15 = new MenuItem();
		MenuItem8 = new MenuItem();
		MenuItem10 = new MenuItem();
		MenuItem4 = new MenuItem();
		MenuItem16 = new MenuItem();
		Panel1 = new Panel();
		Button10 = new Button();
		Label21 = new Label();
		textbox1111 = new TextBox();
		LinkLabel1 = new LinkLabel();
		CloseAbout = new Button();
		OpenFileDialog1 = new OpenFileDialog();
		Panel2 = new Panel();
		Button13 = new Button();
		Panel4 = new Panel();
		Button19 = new Button();
		Button18 = new Button();
		Button17 = new Button();
		Button16 = new Button();
		ListBox2 = new ListBox();
		Button15 = new Button();
		Button14 = new Button();
		Label15 = new Label();
		leechbox = new TextBox();
		Button8 = new Button();
		CheckAll = new Button();
		Save = new Button();
		Delete = new Button();
		HideProxy = new Button();
		OpenProxy = new Button();
		ProxyGroup = new GroupBox();
		Button20 = new Button();
		ProxySMTP = new TextBox();
		Label12 = new Label();
		Label11 = new Label();
		Threads = new Label();
		TrackBar1 = new TrackBar();
		Proxylist2 = new ListBox();
		Button7 = new Button();
		Proxy = new TextBox();
		Proxylist = new ListBox();
		CheckProxy = new Button();
		Button11 = new Button();
		Message = new Panel();
		Label17 = new Label();
		Button5 = new Button();
		HTML = new CheckBox();
		Button6 = new Button();
		Subject = new TextBox();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Fromname = new TextBox();
		Label2 = new Label();
		Label1 = new Label();
		Body = new RichTextBox();
		ToName = new TextBox();
		ReplyTo = new TextBox();
		From = new TextBox();
		Recipient = new TextBox();
		TrackBar2 = new TrackBar();
		SmtpAuth = new Panel();
		Button9 = new Button();
		Addaccnt = new Button();
		SaveAccount = new Button();
		clear = new Button();
		OpenSmtp = new Button();
		HideSMTP = new Button();
		Label10 = new Label();
		Label9 = new Label();
		Label8 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		RealEmail = new TextBox();
		Accountlist = new ListBox();
		password = new TextBox();
		username = new TextBox();
		pop3 = new TextBox();
		smtp = new TextBox();
		SaveFileDialog1 = new SaveFileDialog();
		MailingList = new Panel();
		Stopchecking = new CheckBox();
		Button4 = new Button();
		Button3 = new Button();
		Button2 = new Button();
		ListBox1 = new ListBox();
		Button1 = new Button();
		Panel3 = new Panel();
		Button12 = new Button();
		Listlog = new ListBox();
		log = new LinkLabel();
		Label13 = new Label();
		Label14 = new Label();
		Status = new Label();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((Control)ProxyGroup).SuspendLayout();
		((ISupportInitialize)TrackBar1).BeginInit();
		((Control)Message).SuspendLayout();
		((ISupportInitialize)TrackBar2).BeginInit();
		((Control)SmtpAuth).SuspendLayout();
		((Control)MailingList).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Menu)MainMenu1).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[6] { MenuItem1, List, MenuItem2, MenuItem3, MenuItem5, MenuItem4 });
		MenuItem1.set_DefaultItem(true);
		MenuItem1.set_Index(0);
		((Menu)MenuItem1).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[8] { Send, MenuItem6, MenuItem11, MenuItem7, MenuItem18, MenuItem21, MenuItem22, MenuItem24 });
		MenuItem1.set_Text("Main");
		Send.set_Index(0);
		Send.set_Text("Start");
		MenuItem6.set_Index(1);
		MenuItem6.set_Text("Stop");
		MenuItem11.set_Index(2);
		MenuItem11.set_Text("-");
		MenuItem7.set_Index(3);
		((Menu)MenuItem7).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[3] { MenuItem19, MenuItem20, MenuItem23 });
		MenuItem7.set_Text("Mode");
		MenuItem7.set_Visible(false);
		MenuItem19.set_Index(0);
		MenuItem19.set_Text("Legit Mailing List");
		MenuItem20.set_Index(1);
		MenuItem20.set_Text("Bulk Mailing List");
		MenuItem23.set_Index(2);
		MenuItem23.set_Text("Anonymous Mass Mailing");
		MenuItem18.set_Index(4);
		MenuItem18.set_Text("Mail Message");
		MenuItem21.set_Index(5);
		MenuItem21.set_Text("Proxy List");
		MenuItem22.set_Index(6);
		MenuItem22.set_Text("SMTP Auth");
		MenuItem24.set_Index(7);
		MenuItem24.set_Text("List");
		MenuItem24.set_Visible(false);
		List.set_Index(1);
		((Menu)List).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[2] { MenuItem9, Uselistbox });
		List.set_Text("List");
		MenuItem9.set_Index(0);
		MenuItem9.set_Text("Validate List");
		MenuItem9.set_Visible(false);
		Uselistbox.set_Index(1);
		Uselistbox.set_Text("Use List");
		MenuItem2.set_Index(2);
		((Menu)MenuItem2).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[4] { loopback, RandomProxy, MenuItem12, Httpproxies });
		MenuItem2.set_Text("Proxies");
		loopback.set_Index(0);
		loopback.set_Text("LoopBack");
		loopback.set_Visible(false);
		RandomProxy.set_Index(1);
		RandomProxy.set_Text("Use Random Proxy");
		MenuItem12.set_Index(2);
		MenuItem12.set_Text("-");
		MenuItem12.set_Visible(false);
		Httpproxies.set_Index(3);
		Httpproxies.set_Text("Use Http Proxies");
		Httpproxies.set_Visible(false);
		MenuItem3.set_Index(3);
		((Menu)MenuItem3).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[1] { MenuItem13 });
		MenuItem3.set_Text("Options");
		MenuItem13.set_Index(0);
		((Menu)MenuItem13).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[2] { MenuItem14, MenuItem17 });
		MenuItem13.set_Text("Auto Headers");
		MenuItem14.set_Index(0);
		MenuItem14.set_Text("Use Auto Fake Headers");
		MenuItem17.set_Index(1);
		MenuItem17.set_Text("Don't use any fake headers");
		MenuItem5.set_Index(4);
		MenuItem5.set_MdiList(true);
		((Menu)MenuItem5).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[5] { accnt, Popfirst, MenuItem15, MenuItem8, MenuItem10 });
		MenuItem5.set_Text("SMTP");
		accnt.set_Index(0);
		accnt.set_Text("Use Account List");
		Popfirst.set_Index(1);
		Popfirst.set_Text("Pop First");
		MenuItem15.set_Index(2);
		MenuItem15.set_Text("-");
		MenuItem8.set_Index(3);
		MenuItem8.set_Text("Use Builtin-SMTP");
		MenuItem10.set_Index(4);
		MenuItem10.set_Text("Pretend to be Mx");
		MenuItem4.set_Index(5);
		((Menu)MenuItem4).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[1] { MenuItem16 });
		MenuItem4.set_Text("About");
		MenuItem16.set_Index(0);
		MenuItem16.set_Text("Version");
		((Control)Panel1).set_BackgroundImage((Image)(Bitmap)resourceManager.GetObject("Panel1.BackgroundImage"));
		Panel1.set_BorderStyle((BorderStyle)1);
		((Control)Panel1).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			(Control)Button10,
			(Control)Label21,
			(Control)textbox1111,
			(Control)LinkLabel1,
			(Control)CloseAbout
		});
		Panel panel = Panel1;
		Point location = new Point(136, 8);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		Size size = new Size(264, 176);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(0);
		((Control)Panel1).set_Visible(false);
		((ButtonBase)Button10).set_FlatStyle((FlatStyle)0);
		Button button = Button10;
		location = new Point(176, 120);
		((Control)button).set_Location(location);
		((Control)Button10).set_Name("Button10");
		Button button2 = Button10;
		size = new Size(64, 24);
		((Control)button2).set_Size(size);
		((Control)Button10).set_TabIndex(4);
		((Control)Button10).set_Text("ok");
		((Control)Label21).set_BackColor(SystemColors.ControlLightLight);
		Label21.set_BorderStyle((BorderStyle)1);
		Label label = Label21;
		location = new Point(152, 48);
		((Control)label).set_Location(location);
		((Control)Label21).set_Name("Label21");
		Label label2 = Label21;
		size = new Size(96, 40);
		((Control)label2).set_Size(size);
		((Control)Label21).set_TabIndex(3);
		((Control)Label21).set_Text("Enter Registeration Code");
		((TextBoxBase)textbox1111).set_BorderStyle((BorderStyle)1);
		TextBox obj = textbox1111;
		location = new Point(152, 96);
		((Control)obj).set_Location(location);
		((Control)textbox1111).set_Name("textbox1111");
		((Control)textbox1111).set_TabIndex(2);
		textbox1111.set_Text("");
		((Control)LinkLabel1).set_BackColor(Color.White);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(104, 24);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(144, 16);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(1);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("http://Botmailer.Beware.us");
		((Control)CloseAbout).set_BackColor(Color.White);
		((ButtonBase)CloseAbout).set_FlatStyle((FlatStyle)1);
		((Control)CloseAbout).set_ForeColor(SystemColors.ControlText);
		Button closeAbout = CloseAbout;
		location = new Point(8, 64);
		((Control)closeAbout).set_Location(location);
		((Control)CloseAbout).set_Name("CloseAbout");
		Button closeAbout2 = CloseAbout;
		size = new Size(80, 24);
		((Control)closeAbout2).set_Size(size);
		((Control)CloseAbout).set_TabIndex(0);
		((Control)CloseAbout).set_Text("Hide");
		((Control)Panel2).set_BackColor(Color.Transparent);
		Panel2.set_BorderStyle((BorderStyle)1);
		((Control)Panel2).get_Controls().AddRange((Control[])(object)new Control[9]
		{
			(Control)Button13,
			(Control)Panel4,
			(Control)Button8,
			(Control)CheckAll,
			(Control)Save,
			(Control)Delete,
			(Control)HideProxy,
			(Control)OpenProxy,
			(Control)ProxyGroup
		});
		Panel panel3 = Panel2;
		location = new Point(72, 32);
		((Control)panel3).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel4 = Panel2;
		size = new Size(416, 256);
		((Control)panel4).set_Size(size);
		((Control)Panel2).set_TabIndex(1);
		((Control)Panel2).set_Visible(false);
		((Control)Button13).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button13).set_FlatStyle((FlatStyle)1);
		Button button3 = Button13;
		location = new Point(333, 7);
		((Control)button3).set_Location(location);
		((Control)Button13).set_Name("Button13");
		Button button4 = Button13;
		size = new Size(69, 24);
		((Control)button4).set_Size(size);
		((Control)Button13).set_TabIndex(18);
		((Control)Button13).set_Text("Leech");
		((Control)Button13).set_Visible(false);
		Panel4.set_BorderStyle((BorderStyle)1);
		((Control)Panel4).get_Controls().AddRange((Control[])(object)new Control[9]
		{
			(Control)Button19,
			(Control)Button18,
			(Control)Button17,
			(Control)Button16,
			(Control)ListBox2,
			(Control)Button15,
			(Control)Button14,
			(Control)Label15,
			(Control)leechbox
		});
		Panel panel5 = Panel4;
		location = new Point(313, 5);
		((Control)panel5).set_Location(location);
		((Control)Panel4).set_Name("Panel4");
		Panel panel6 = Panel4;
		size = new Size(98, 43);
		((Control)panel6).set_Size(size);
		((Control)Panel4).set_TabIndex(19);
		((Control)Panel4).set_Visible(false);
		((Control)Button19).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button19).set_FlatStyle((FlatStyle)1);
		Button button5 = Button19;
		location = new Point(247, 157);
		((Control)button5).set_Location(location);
		((Control)Button19).set_Name("Button19");
		Button button6 = Button19;
		size = new Size(68, 22);
		((Control)button6).set_Size(size);
		((Control)Button19).set_TabIndex(10);
		((Control)Button19).set_Text("Save");
		((Control)Button18).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button18).set_FlatStyle((FlatStyle)1);
		Button button7 = Button18;
		location = new Point(246, 125);
		((Control)button7).set_Location(location);
		((Control)Button18).set_Name("Button18");
		Button button8 = Button18;
		size = new Size(68, 22);
		((Control)button8).set_Size(size);
		((Control)Button18).set_TabIndex(9);
		((Control)Button18).set_Text("Open");
		((Control)Button17).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button17).set_FlatStyle((FlatStyle)1);
		Button button9 = Button17;
		location = new Point(245, 66);
		((Control)button9).set_Location(location);
		((Control)Button17).set_Name("Button17");
		Button button10 = Button17;
		size = new Size(68, 22);
		((Control)button10).set_Size(size);
		((Control)Button17).set_TabIndex(8);
		((Control)Button17).set_Text("Leech All");
		((Control)Button16).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button16).set_FlatStyle((FlatStyle)1);
		Button button11 = Button16;
		location = new Point(244, 11);
		((Control)button11).set_Location(location);
		((Control)Button16).set_Name("Button16");
		Button button12 = Button16;
		size = new Size(72, 20);
		((Control)button12).set_Size(size);
		((Control)Button16).set_TabIndex(7);
		((Control)Button16).set_Text("Leech");
		ListBox listBox = ListBox2;
		location = new Point(9, 42);
		((Control)listBox).set_Location(location);
		((Control)ListBox2).set_Name("ListBox2");
		ListBox listBox2 = ListBox2;
		size = new Size(216, 134);
		((Control)listBox2).set_Size(size);
		((Control)ListBox2).set_TabIndex(6);
		((Control)Button15).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button15).set_FlatStyle((FlatStyle)1);
		Button button13 = Button15;
		location = new Point(245, 37);
		((Control)button13).set_Location(location);
		((Control)Button15).set_Name("Button15");
		Button button14 = Button15;
		size = new Size(70, 20);
		((Control)button14).set_Size(size);
		((Control)Button15).set_TabIndex(5);
		((Control)Button15).set_Text("Add");
		((Control)Button14).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button14).set_FlatStyle((FlatStyle)1);
		Button button15 = Button14;
		location = new Point(246, 97);
		((Control)button15).set_Location(location);
		((Control)Button14).set_Name("Button14");
		Button button16 = Button14;
		size = new Size(68, 19);
		((Control)button16).set_Size(size);
		((Control)Button14).set_TabIndex(4);
		((Control)Button14).set_Text("hide");
		Label label3 = Label15;
		location = new Point(5, 9);
		((Control)label3).set_Location(location);
		((Control)Label15).set_Name("Label15");
		Label label4 = Label15;
		size = new Size(34, 19);
		((Control)label4).set_Size(size);
		((Control)Label15).set_TabIndex(2);
		((Control)Label15).set_Text("From:");
		((TextBoxBase)leechbox).set_BorderStyle((BorderStyle)1);
		TextBox obj2 = leechbox;
		location = new Point(52, 8);
		((Control)obj2).set_Location(location);
		((Control)leechbox).set_Name("leechbox");
		TextBox obj3 = leechbox;
		size = new Size(178, 20);
		((Control)obj3).set_Size(size);
		((Control)leechbox).set_TabIndex(0);
		leechbox.set_Text("");
		((Control)Button8).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button8).set_FlatStyle((FlatStyle)1);
		Button button17 = Button8;
		location = new Point(333, 38);
		((Control)button17).set_Location(location);
		((Control)Button8).set_Name("Button8");
		Button button18 = Button8;
		size = new Size(69, 24);
		((Control)button18).set_Size(size);
		((Control)Button8).set_TabIndex(17);
		((Control)Button8).set_Text("Clear");
		((Control)CheckAll).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)CheckAll).set_FlatStyle((FlatStyle)1);
		Button checkAll = CheckAll;
		location = new Point(333, 73);
		((Control)checkAll).set_Location(location);
		((Control)CheckAll).set_Name("CheckAll");
		Button checkAll2 = CheckAll;
		size = new Size(69, 24);
		((Control)checkAll2).set_Size(size);
		((Control)CheckAll).set_TabIndex(16);
		((Control)CheckAll).set_Text("Check All");
		((Control)Save).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Save).set_FlatStyle((FlatStyle)1);
		Button save = Save;
		location = new Point(333, 107);
		((Control)save).set_Location(location);
		((Control)Save).set_Name("Save");
		Button save2 = Save;
		size = new Size(68, 25);
		((Control)save2).set_Size(size);
		((Control)Save).set_TabIndex(15);
		((Control)Save).set_Text("Save");
		((Control)Delete).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Delete).set_FlatStyle((FlatStyle)1);
		Button delete = Delete;
		location = new Point(333, 141);
		((Control)delete).set_Location(location);
		((Control)Delete).set_Name("Delete");
		Button delete2 = Delete;
		size = new Size(70, 24);
		((Control)delete2).set_Size(size);
		((Control)Delete).set_TabIndex(14);
		((Control)Delete).set_Text("Delete");
		((Control)HideProxy).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)HideProxy).set_FlatStyle((FlatStyle)1);
		Button hideProxy = HideProxy;
		location = new Point(334, 210);
		((Control)hideProxy).set_Location(location);
		((Control)HideProxy).set_Name("HideProxy");
		Button hideProxy2 = HideProxy;
		size = new Size(69, 27);
		((Control)hideProxy2).set_Size(size);
		((Control)HideProxy).set_TabIndex(1);
		((Control)HideProxy).set_Text("Hide");
		((Control)OpenProxy).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)OpenProxy).set_FlatStyle((FlatStyle)1);
		Button openProxy = OpenProxy;
		location = new Point(333, 174);
		((Control)openProxy).set_Location(location);
		((Control)OpenProxy).set_Name("OpenProxy");
		Button openProxy2 = OpenProxy;
		size = new Size(70, 24);
		((Control)openProxy2).set_Size(size);
		((Control)OpenProxy).set_TabIndex(13);
		((Control)OpenProxy).set_Text("Open");
		((Control)ProxyGroup).get_Controls().AddRange((Control[])(object)new Control[12]
		{
			(Control)Button20,
			(Control)ProxySMTP,
			(Control)Label12,
			(Control)Label11,
			(Control)Threads,
			(Control)TrackBar1,
			(Control)Proxylist2,
			(Control)Button7,
			(Control)Proxy,
			(Control)Proxylist,
			(Control)CheckProxy,
			(Control)Button11
		});
		((Control)ProxyGroup).set_ForeColor(SystemColors.ControlText);
		GroupBox proxyGroup = ProxyGroup;
		location = new Point(14, 16);
		((Control)proxyGroup).set_Location(location);
		((Control)ProxyGroup).set_Name("ProxyGroup");
		GroupBox proxyGroup2 = ProxyGroup;
		size = new Size(311, 229);
		((Control)proxyGroup2).set_Size(size);
		((Control)ProxyGroup).set_TabIndex(2);
		ProxyGroup.set_TabStop(false);
		ProxyGroup.set_Text("Proxy List");
		((Control)Button20).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button20).set_FlatStyle((FlatStyle)1);
		Button button19 = Button20;
		location = new Point(142, 15);
		((Control)button19).set_Location(location);
		((Control)Button20).set_Name("Button20");
		Button button20 = Button20;
		size = new Size(161, 22);
		((Control)button20).set_Size(size);
		((Control)Button20).set_TabIndex(17);
		((Control)Button20).set_Text("Find/Check Proxy SMTP/Add");
		((Control)Button20).set_Visible(false);
		TextBox proxySMTP = ProxySMTP;
		location = new Point(6, 18);
		((Control)proxySMTP).set_Location(location);
		((Control)ProxySMTP).set_Name("ProxySMTP");
		TextBox proxySMTP2 = ProxySMTP;
		size = new Size(121, 20);
		((Control)proxySMTP2).set_Size(size);
		((Control)ProxySMTP).set_TabIndex(16);
		ProxySMTP.set_Text("");
		((Control)ProxySMTP).set_Visible(false);
		Label label5 = Label12;
		location = new Point(17, 70);
		((Control)label5).set_Location(location);
		((Control)Label12).set_Name("Label12");
		Label label6 = Label12;
		size = new Size(118, 16);
		((Control)label6).set_Size(size);
		((Control)Label12).set_TabIndex(15);
		((Control)Label12).set_Text("Checked Proxies");
		Label label7 = Label11;
		location = new Point(158, 71);
		((Control)label7).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label8 = Label11;
		size = new Size(115, 16);
		((Control)label8).set_Size(size);
		((Control)Label11).set_TabIndex(14);
		((Control)Label11).set_Text("Unchecked Proxies");
		Label threads = Threads;
		location = new Point(154, 201);
		((Control)threads).set_Location(location);
		((Control)Threads).set_Name("Threads");
		Label threads2 = Threads;
		size = new Size(113, 17);
		((Control)threads2).set_Size(size);
		((Control)Threads).set_TabIndex(7);
		((Control)Threads).set_Text("# of Bots 1 - 30");
		((Control)TrackBar1).set_BackColor(Color.LightSteelBlue);
		TrackBar trackBar = TrackBar1;
		location = new Point(144, 179);
		((Control)trackBar).set_Location(location);
		TrackBar1.set_Maximum(30);
		TrackBar1.set_Minimum(1);
		((Control)TrackBar1).set_Name("TrackBar1");
		TrackBar trackBar2 = TrackBar1;
		size = new Size(136, 45);
		((Control)trackBar2).set_Size(size);
		((Control)TrackBar1).set_TabIndex(6);
		TrackBar1.set_Value(1);
		Proxylist2.set_BorderStyle((BorderStyle)1);
		ListBox proxylist = Proxylist2;
		location = new Point(6, 90);
		((Control)proxylist).set_Location(location);
		((Control)Proxylist2).set_Name("Proxylist2");
		ListBox proxylist2 = Proxylist2;
		size = new Size(124, 80);
		((Control)proxylist2).set_Size(size);
		((Control)Proxylist2).set_TabIndex(5);
		((Control)Button7).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button7).set_FlatStyle((FlatStyle)1);
		Button button21 = Button7;
		location = new Point(245, 42);
		((Control)button21).set_Location(location);
		((Control)Button7).set_Name("Button7");
		Button button22 = Button7;
		size = new Size(53, 22);
		((Control)button22).set_Size(size);
		((Control)Button7).set_TabIndex(4);
		((Control)Button7).set_Text("Add");
		TextBox proxy = Proxy;
		location = new Point(7, 43);
		((Control)proxy).set_Location(location);
		((Control)Proxy).set_Name("Proxy");
		TextBox proxy2 = Proxy;
		size = new Size(122, 20);
		((Control)proxy2).set_Size(size);
		((Control)Proxy).set_TabIndex(1);
		Proxy.set_Text("");
		Proxylist.set_BorderStyle((BorderStyle)1);
		ListBox proxylist3 = Proxylist;
		location = new Point(149, 89);
		((Control)proxylist3).set_Location(location);
		((Control)Proxylist).set_Name("Proxylist");
		ListBox proxylist4 = Proxylist;
		size = new Size(120, 80);
		((Control)proxylist4).set_Size(size);
		((Control)Proxylist).set_TabIndex(0);
		((Control)CheckProxy).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)CheckProxy).set_FlatStyle((FlatStyle)1);
		Button checkProxy = CheckProxy;
		location = new Point(148, 42);
		((Control)checkProxy).set_Location(location);
		((Control)CheckProxy).set_Name("CheckProxy");
		Button checkProxy2 = CheckProxy;
		size = new Size(80, 22);
		((Control)checkProxy2).set_Size(size);
		((Control)CheckProxy).set_TabIndex(3);
		((Control)CheckProxy).set_Text("Check Proxy");
		((Control)Button11).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button11).set_FlatStyle((FlatStyle)1);
		Button button23 = Button11;
		location = new Point(17, 175);
		((Control)button23).set_Location(location);
		((Control)Button11).set_Name("Button11");
		Button button24 = Button11;
		size = new Size(94, 35);
		((Control)button24).set_Size(size);
		((Control)Button11).set_TabIndex(15);
		((Control)Button11).set_Text("Open Checked Proxies");
		((Control)Message).set_BackColor(Color.Transparent);
		Message.set_BorderStyle((BorderStyle)1);
		((Control)Message).get_Controls().AddRange((Control[])(object)new Control[17]
		{
			(Control)Label17,
			(Control)Button5,
			(Control)HTML,
			(Control)Button6,
			(Control)Subject,
			(Control)Label5,
			(Control)Label4,
			(Control)Label3,
			(Control)Fromname,
			(Control)Label2,
			(Control)Label1,
			(Control)Body,
			(Control)ToName,
			(Control)ReplyTo,
			(Control)From,
			(Control)Recipient,
			(Control)TrackBar2
		});
		Panel message = Message;
		location = new Point(48, 8);
		((Control)message).set_Location(location);
		((Control)Message).set_Name("Message");
		Panel message2 = Message;
		size = new Size(480, 272);
		((Control)message2).set_Size(size);
		((Control)Message).set_TabIndex(2);
		Label label9 = Label17;
		location = new Point(376, 112);
		((Control)label9).set_Location(location);
		((Control)Label17).set_Name("Label17");
		((Control)Label17).set_RightToLeft((RightToLeft)0);
		Label label10 = Label17;
		size = new Size(88, 16);
		((Control)label10).set_Size(size);
		((Control)Label17).set_TabIndex(17);
		((Control)Label17).set_Text("Mailing Speed");
		((Control)Button5).set_BackColor(Color.Yellow);
		((Control)Button5).set_BackgroundImage((Image)(Bitmap)resourceManager.GetObject("Button5.BackgroundImage"));
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)1);
		Button button25 = Button5;
		location = new Point(360, 40);
		((Control)button25).set_Location(location);
		((Control)Button5).set_Name("Button5");
		Button button26 = Button5;
		size = new Size(104, 24);
		((Control)button26).set_Size(size);
		((Control)Button5).set_TabIndex(16);
		((Control)Button5).set_Text("Stop");
		CheckBox hTML = HTML;
		location = new Point(312, 104);
		((Control)hTML).set_Location(location);
		((Control)HTML).set_Name("HTML");
		CheckBox hTML2 = HTML;
		size = new Size(56, 16);
		((Control)hTML2).set_Size(size);
		((Control)HTML).set_TabIndex(15);
		((Control)HTML).set_Text("HTML");
		((Control)Button6).set_BackColor(Color.Yellow);
		((Control)Button6).set_BackgroundImage((Image)(Bitmap)resourceManager.GetObject("Button6.BackgroundImage"));
		((ButtonBase)Button6).set_FlatStyle((FlatStyle)1);
		Button button27 = Button6;
		location = new Point(360, 8);
		((Control)button27).set_Location(location);
		((Control)Button6).set_Name("Button6");
		Button button28 = Button6;
		size = new Size(104, 24);
		((Control)button28).set_Size(size);
		((Control)Button6).set_TabIndex(13);
		((Control)Button6).set_Text("Send");
		TextBox subject = Subject;
		location = new Point(32, 104);
		((Control)subject).set_Location(location);
		((Control)Subject).set_Name("Subject");
		TextBox subject2 = Subject;
		size = new Size(272, 20);
		((Control)subject2).set_Size(size);
		((Control)Subject).set_TabIndex(11);
		Subject.set_Text("");
		Label label11 = Label5;
		location = new Point(184, 72);
		((Control)label11).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label12 = Label5;
		size = new Size(40, 16);
		((Control)label12).set_Size(size);
		((Control)Label5).set_TabIndex(10);
		((Control)Label5).set_Text("Name");
		Label label13 = Label4;
		location = new Point(184, 40);
		((Control)label13).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label14 = Label4;
		size = new Size(40, 16);
		((Control)label14).set_Size(size);
		((Control)Label4).set_TabIndex(9);
		((Control)Label4).set_Text("Name:");
		Label label15 = Label3;
		location = new Point(104, 8);
		((Control)label15).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label16 = Label3;
		size = new Size(56, 16);
		((Control)label16).set_Size(size);
		((Control)Label3).set_TabIndex(8);
		((Control)Label3).set_Text("Reply-To:");
		((TextBoxBase)Fromname).set_BorderStyle((BorderStyle)1);
		TextBox fromname = Fromname;
		location = new Point(232, 72);
		((Control)fromname).set_Location(location);
		((Control)Fromname).set_Name("Fromname");
		TextBox fromname2 = Fromname;
		size = new Size(104, 20);
		((Control)fromname2).set_Size(size);
		((Control)Fromname).set_TabIndex(7);
		Fromname.set_Text("");
		Label label17 = Label2;
		location = new Point(16, 72);
		((Control)label17).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label18 = Label2;
		size = new Size(32, 16);
		((Control)label18).set_Size(size);
		((Control)Label2).set_TabIndex(6);
		((Control)Label2).set_Text("From:");
		Label label19 = Label1;
		location = new Point(24, 40);
		((Control)label19).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label20 = Label1;
		size = new Size(24, 16);
		((Control)label20).set_Size(size);
		((Control)Label1).set_TabIndex(5);
		((Control)Label1).set_Text("To:");
		((TextBoxBase)Body).set_BorderStyle((BorderStyle)1);
		RichTextBox body = Body;
		location = new Point(32, 128);
		((Control)body).set_Location(location);
		((Control)Body).set_Name("Body");
		RichTextBox body2 = Body;
		size = new Size(424, 120);
		((Control)body2).set_Size(size);
		((Control)Body).set_TabIndex(4);
		Body.set_Text("");
		((TextBoxBase)ToName).set_BorderStyle((BorderStyle)1);
		TextBox toName = ToName;
		location = new Point(232, 40);
		((Control)toName).set_Location(location);
		((Control)ToName).set_Name("ToName");
		TextBox toName2 = ToName;
		size = new Size(104, 20);
		((Control)toName2).set_Size(size);
		((Control)ToName).set_TabIndex(3);
		ToName.set_Text("");
		((TextBoxBase)ReplyTo).set_BorderStyle((BorderStyle)1);
		TextBox replyTo = ReplyTo;
		location = new Point(168, 8);
		((Control)replyTo).set_Location(location);
		((Control)ReplyTo).set_Name("ReplyTo");
		TextBox replyTo2 = ReplyTo;
		size = new Size(112, 20);
		((Control)replyTo2).set_Size(size);
		((Control)ReplyTo).set_TabIndex(2);
		ReplyTo.set_Text("");
		((TextBoxBase)From).set_BorderStyle((BorderStyle)1);
		TextBox from = From;
		location = new Point(56, 72);
		((Control)from).set_Location(location);
		((Control)From).set_Name("From");
		TextBox from2 = From;
		size = new Size(120, 20);
		((Control)from2).set_Size(size);
		((Control)From).set_TabIndex(1);
		From.set_Text("");
		((TextBoxBase)Recipient).set_BorderStyle((BorderStyle)1);
		TextBox recipient = Recipient;
		location = new Point(56, 40);
		((Control)recipient).set_Location(location);
		((Control)Recipient).set_Name("Recipient");
		TextBox recipient2 = Recipient;
		size = new Size(120, 20);
		((Control)recipient2).set_Size(size);
		((Control)Recipient).set_TabIndex(0);
		Recipient.set_Text("");
		((Control)TrackBar2).set_BackColor(Color.LightSteelBlue);
		TrackBar trackBar3 = TrackBar2;
		location = new Point(368, 80);
		((Control)trackBar3).set_Location(location);
		TrackBar2.set_Maximum(3);
		TrackBar2.set_Minimum(1);
		((Control)TrackBar2).set_Name("TrackBar2");
		TrackBar trackBar4 = TrackBar2;
		size = new Size(104, 45);
		((Control)trackBar4).set_Size(size);
		((Control)TrackBar2).set_TabIndex(14);
		TrackBar2.set_Value(1);
		((Control)SmtpAuth).set_BackColor(Color.Transparent);
		SmtpAuth.set_BorderStyle((BorderStyle)1);
		((Control)SmtpAuth).get_Controls().AddRange((Control[])(object)new Control[17]
		{
			(Control)Button9,
			(Control)Addaccnt,
			(Control)SaveAccount,
			(Control)clear,
			(Control)OpenSmtp,
			(Control)HideSMTP,
			(Control)Label10,
			(Control)Label9,
			(Control)Label8,
			(Control)Label7,
			(Control)Label6,
			(Control)RealEmail,
			(Control)Accountlist,
			(Control)password,
			(Control)username,
			(Control)pop3,
			(Control)smtp
		});
		Panel smtpAuth = SmtpAuth;
		location = new Point(112, 16);
		((Control)smtpAuth).set_Location(location);
		((Control)SmtpAuth).set_Name("SmtpAuth");
		Panel smtpAuth2 = SmtpAuth;
		size = new Size(312, 248);
		((Control)smtpAuth2).set_Size(size);
		((Control)SmtpAuth).set_TabIndex(13);
		((Control)SmtpAuth).set_Visible(false);
		((Control)Button9).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button9).set_FlatStyle((FlatStyle)1);
		Button button29 = Button9;
		location = new Point(80, 104);
		((Control)button29).set_Location(location);
		((Control)Button9).set_Name("Button9");
		Button button30 = Button9;
		size = new Size(48, 24);
		((Control)button30).set_Size(size);
		((Control)Button9).set_TabIndex(16);
		((Control)Button9).set_Text("Clear");
		((Control)Addaccnt).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Addaccnt).set_FlatStyle((FlatStyle)1);
		Button addaccnt = Addaccnt;
		location = new Point(264, 216);
		((Control)addaccnt).set_Location(location);
		((Control)Addaccnt).set_Name("Addaccnt");
		Button addaccnt2 = Addaccnt;
		size = new Size(40, 24);
		((Control)addaccnt2).set_Size(size);
		((Control)Addaccnt).set_TabIndex(15);
		((Control)Addaccnt).set_Text("Add");
		((Control)SaveAccount).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)SaveAccount).set_FlatStyle((FlatStyle)1);
		Button saveAccount = SaveAccount;
		location = new Point(144, 216);
		((Control)saveAccount).set_Location(location);
		((Control)SaveAccount).set_Name("SaveAccount");
		Button saveAccount2 = SaveAccount;
		size = new Size(48, 24);
		((Control)saveAccount2).set_Size(size);
		((Control)SaveAccount).set_TabIndex(14);
		((Control)SaveAccount).set_Text("Save");
		((Control)clear).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)clear).set_FlatStyle((FlatStyle)1);
		Button obj4 = clear;
		location = new Point(208, 216);
		((Control)obj4).set_Location(location);
		((Control)clear).set_Name("clear");
		Button obj5 = clear;
		size = new Size(48, 24);
		((Control)obj5).set_Size(size);
		((Control)clear).set_TabIndex(13);
		((Control)clear).set_Text("Delete");
		((Control)OpenSmtp).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)OpenSmtp).set_FlatStyle((FlatStyle)1);
		Button openSmtp = OpenSmtp;
		location = new Point(80, 216);
		((Control)openSmtp).set_Location(location);
		((Control)OpenSmtp).set_Name("OpenSmtp");
		Button openSmtp2 = OpenSmtp;
		size = new Size(48, 24);
		((Control)openSmtp2).set_Size(size);
		((Control)OpenSmtp).set_TabIndex(12);
		((Control)OpenSmtp).set_Text("Open");
		((Control)HideSMTP).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)HideSMTP).set_FlatStyle((FlatStyle)1);
		Button hideSMTP = HideSMTP;
		location = new Point(16, 216);
		((Control)hideSMTP).set_Location(location);
		((Control)HideSMTP).set_Name("HideSMTP");
		Button hideSMTP2 = HideSMTP;
		size = new Size(48, 24);
		((Control)hideSMTP2).set_Size(size);
		((Control)HideSMTP).set_TabIndex(11);
		((Control)HideSMTP).set_Text("Hide");
		Label label21 = Label10;
		location = new Point(176, 40);
		((Control)label21).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label22 = Label10;
		size = new Size(72, 16);
		((Control)label22).set_Size(size);
		((Control)Label10).set_TabIndex(10);
		((Control)Label10).set_Text("Password");
		Label label23 = Label9;
		location = new Point(32, 40);
		((Control)label23).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label24 = Label9;
		size = new Size(72, 16);
		((Control)label24).set_Size(size);
		((Control)Label9).set_TabIndex(9);
		((Control)Label9).set_Text("Username");
		Label label25 = Label8;
		location = new Point(176, 0);
		((Control)label25).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label26 = Label8;
		size = new Size(88, 16);
		((Control)label26).set_Size(size);
		((Control)Label8).set_TabIndex(8);
		((Control)Label8).set_Text("Pop3");
		Label label27 = Label7;
		location = new Point(32, 0);
		((Control)label27).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label28 = Label7;
		size = new Size(100, 16);
		((Control)label28).set_Size(size);
		((Control)Label7).set_TabIndex(7);
		((Control)Label7).set_Text("Smtp");
		Label label29 = Label6;
		location = new Point(16, 88);
		((Control)label29).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label30 = Label6;
		size = new Size(136, 23);
		((Control)label30).set_Size(size);
		((Control)Label6).set_TabIndex(6);
		((Control)Label6).set_Text("Account E-mail Address:");
		((Control)Label6).set_Visible(false);
		((TextBoxBase)RealEmail).set_BorderStyle((BorderStyle)1);
		TextBox realEmail = RealEmail;
		location = new Point(160, 88);
		((Control)realEmail).set_Location(location);
		((Control)RealEmail).set_Name("RealEmail");
		TextBox realEmail2 = RealEmail;
		size = new Size(104, 20);
		((Control)realEmail2).set_Size(size);
		((Control)RealEmail).set_TabIndex(5);
		RealEmail.set_Text("");
		((Control)RealEmail).set_Visible(false);
		Accountlist.set_BorderStyle((BorderStyle)1);
		ListBox accountlist = Accountlist;
		location = new Point(40, 136);
		((Control)accountlist).set_Location(location);
		((Control)Accountlist).set_Name("Accountlist");
		ListBox accountlist2 = Accountlist;
		size = new Size(240, 67);
		((Control)accountlist2).set_Size(size);
		((Control)Accountlist).set_TabIndex(4);
		((TextBoxBase)password).set_BorderStyle((BorderStyle)1);
		TextBox obj6 = password;
		location = new Point(176, 56);
		((Control)obj6).set_Location(location);
		((Control)password).set_Name("password");
		password.set_PasswordChar('*');
		TextBox obj7 = password;
		size = new Size(120, 20);
		((Control)obj7).set_Size(size);
		((Control)password).set_TabIndex(3);
		password.set_Text("");
		((TextBoxBase)username).set_BorderStyle((BorderStyle)1);
		TextBox obj8 = username;
		location = new Point(32, 56);
		((Control)obj8).set_Location(location);
		((Control)username).set_Name("username");
		TextBox obj9 = username;
		size = new Size(112, 20);
		((Control)obj9).set_Size(size);
		((Control)username).set_TabIndex(2);
		username.set_Text("");
		((TextBoxBase)pop3).set_BorderStyle((BorderStyle)1);
		TextBox obj10 = pop3;
		location = new Point(176, 16);
		((Control)obj10).set_Location(location);
		((Control)pop3).set_Name("pop3");
		TextBox obj11 = pop3;
		size = new Size(120, 20);
		((Control)obj11).set_Size(size);
		((Control)pop3).set_TabIndex(1);
		pop3.set_Text("");
		((TextBoxBase)smtp).set_BorderStyle((BorderStyle)1);
		TextBox obj12 = smtp;
		location = new Point(32, 16);
		((Control)obj12).set_Location(location);
		((Control)smtp).set_Name("smtp");
		TextBox obj13 = smtp;
		size = new Size(112, 20);
		((Control)obj13).set_Size(size);
		((Control)smtp).set_TabIndex(0);
		smtp.set_Text("");
		((FileDialog)SaveFileDialog1).set_FileName("doc1");
		((Control)MailingList).set_BackColor(Color.Transparent);
		MailingList.set_BorderStyle((BorderStyle)1);
		((Control)MailingList).get_Controls().AddRange((Control[])(object)new Control[6]
		{
			(Control)Stopchecking,
			(Control)Button4,
			(Control)Button3,
			(Control)Button2,
			(Control)ListBox1,
			(Control)Button1
		});
		Panel mailingList = MailingList;
		location = new Point(96, 32);
		((Control)mailingList).set_Location(location);
		((Control)MailingList).set_Name("MailingList");
		Panel mailingList2 = MailingList;
		size = new Size(392, 200);
		((Control)mailingList2).set_Size(size);
		((Control)MailingList).set_TabIndex(15);
		((Control)MailingList).set_Visible(false);
		CheckBox stopchecking = Stopchecking;
		location = new Point(8, 112);
		((Control)stopchecking).set_Location(location);
		((Control)Stopchecking).set_Name("Stopchecking");
		CheckBox stopchecking2 = Stopchecking;
		size = new Size(16, 16);
		((Control)stopchecking2).set_Size(size);
		((Control)Stopchecking).set_TabIndex(5);
		((Control)Stopchecking).set_Text("CheckBox1");
		((Control)Stopchecking).set_Visible(false);
		((Control)Button4).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)1);
		Button button31 = Button4;
		location = new Point(104, 168);
		((Control)button31).set_Location(location);
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_TabIndex(4);
		((Control)Button4).set_Text("Save");
		((Control)Button3).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)1);
		Button button32 = Button3;
		location = new Point(8, 168);
		((Control)button32).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button33 = Button3;
		size = new Size(80, 24);
		((Control)button33).set_Size(size);
		((Control)Button3).set_TabIndex(3);
		((Control)Button3).set_Text("Clear");
		((Control)Button2).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)1);
		Button button34 = Button2;
		location = new Point(200, 168);
		((Control)button34).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button35 = Button2;
		size = new Size(80, 24);
		((Control)button35).set_Size(size);
		((Control)Button2).set_TabIndex(2);
		((Control)Button2).set_Text("Open");
		ListBox listBox3 = ListBox1;
		location = new Point(48, 16);
		((Control)listBox3).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox4 = ListBox1;
		size = new Size(328, 134);
		((Control)listBox4).set_Size(size);
		((Control)ListBox1).set_TabIndex(1);
		((Control)Button1).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)1);
		Button button36 = Button1;
		location = new Point(304, 168);
		((Control)button36).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button37 = Button1;
		size = new Size(80, 24);
		((Control)button37).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((Control)Button1).set_Text("Hide");
		((Control)Panel3).set_BackColor(Color.Transparent);
		Panel3.set_BorderStyle((BorderStyle)1);
		((Control)Panel3).get_Controls().AddRange((Control[])(object)new Control[2]
		{
			(Control)Button12,
			(Control)Listlog
		});
		Panel panel7 = Panel3;
		location = new Point(16, 48);
		((Control)panel7).set_Location(location);
		((Control)Panel3).set_Name("Panel3");
		Panel panel8 = Panel3;
		size = new Size(552, 200);
		((Control)panel8).set_Size(size);
		((Control)Panel3).set_TabIndex(18);
		((Control)Panel3).set_Visible(false);
		((Control)Button12).set_BackColor(Color.CornflowerBlue);
		((ButtonBase)Button12).set_FlatStyle((FlatStyle)1);
		Button button38 = Button12;
		location = new Point(232, 160);
		((Control)button38).set_Location(location);
		((Control)Button12).set_Name("Button12");
		Button button39 = Button12;
		size = new Size(104, 24);
		((Control)button39).set_Size(size);
		((Control)Button12).set_TabIndex(18);
		((Control)Button12).set_Text("Hide");
		Listlog.set_HorizontalScrollbar(true);
		ListBox listlog = Listlog;
		location = new Point(16, 8);
		((Control)listlog).set_Location(location);
		((Control)Listlog).set_Name("Listlog");
		Listlog.set_ScrollAlwaysVisible(true);
		ListBox listlog2 = Listlog;
		size = new Size(528, 134);
		((Control)listlog2).set_Size(size);
		((Control)Listlog).set_TabIndex(17);
		((Control)log).set_BackColor(Color.White);
		((Label)log).set_BorderStyle((BorderStyle)1);
		log.set_LinkColor(Color.RoyalBlue);
		LinkLabel obj14 = log;
		location = new Point(16, 288);
		((Control)obj14).set_Location(location);
		((Control)log).set_Name("log");
		LinkLabel obj15 = log;
		size = new Size(88, 16);
		((Control)obj15).set_Size(size);
		((Control)log).set_TabIndex(19);
		((Label)log).set_TabStop(true);
		log.set_Text("Log");
		((Control)Label13).set_BackColor(Color.White);
		Label13.set_BorderStyle((BorderStyle)1);
		((Control)Label13).set_ForeColor(Color.DodgerBlue);
		Label label31 = Label13;
		location = new Point(360, 288);
		((Control)label31).set_Location(location);
		((Control)Label13).set_Name("Label13");
		Label label32 = Label13;
		size = new Size(88, 16);
		((Control)label32).set_Size(size);
		((Control)Label13).set_TabIndex(20);
		((Control)Label13).set_Text("Messages Sent:");
		((Control)Label14).set_BackColor(Color.White);
		Label14.set_BorderStyle((BorderStyle)1);
		Label label33 = Label14;
		location = new Point(456, 288);
		((Control)label33).set_Location(location);
		((Control)Label14).set_Name("Label14");
		Label label34 = Label14;
		size = new Size(48, 16);
		((Control)label34).set_Size(size);
		((Control)Label14).set_TabIndex(21);
		((Control)Label14).set_Text("0");
		((Control)Status).set_BackColor(Color.Transparent);
		((Control)Status).set_ForeColor(Color.Black);
		Label status = Status;
		location = new Point(152, 288);
		((Control)status).set_Location(location);
		((Control)Status).set_Name("Status");
		Label status2 = Status;
		size = new Size(112, 16);
		((Control)status2).set_Size(size);
		((Control)Status).set_TabIndex(22);
		size = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(size);
		((Control)this).set_BackgroundImage((Image)(Bitmap)resourceManager.GetObject("$this.BackgroundImage"));
		size = new Size(584, 305);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[10]
		{
			(Control)SmtpAuth,
			(Control)MailingList,
			(Control)Panel2,
			(Control)Panel1,
			(Control)Status,
			(Control)log,
			(Control)Label13,
			(Control)Label14,
			(Control)Panel3,
			(Control)Message
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)resourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_Menu(MainMenu1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Botmailer 1.0");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel4).ResumeLayout(false);
		((Control)ProxyGroup).ResumeLayout(false);
		((ISupportInitialize)TrackBar1).EndInit();
		((Control)Message).ResumeLayout(false);
		((ISupportInitialize)TrackBar2).EndInit();
		((Control)SmtpAuth).ResumeLayout(false);
		((Control)MailingList).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void MenuItem1_Click(object sender, EventArgs e)
	{
	}

	private void MenuItem13_Click(object sender, EventArgs e)
	{
		if (!MenuItem13.get_Checked())
		{
			MenuItem13.set_Checked(true);
		}
		else
		{
			MenuItem13.set_Checked(false);
		}
	}

	private void MenuItem14_Click(object sender, EventArgs e)
	{
		if (!MenuItem14.get_Checked())
		{
			MenuItem14.set_Checked(true);
			MenuItem17.set_Checked(false);
			Useautoheaders = "yes";
		}
		else
		{
			MenuItem14.set_Checked(false);
			Useautoheaders = "no";
		}
	}

	private void MenuItem17_Click(object sender, EventArgs e)
	{
		if (!MenuItem17.get_Checked())
		{
			MenuItem17.set_Checked(true);
			MenuItem14.set_Checked(false);
			Useautoheaders = "no";
		}
		else
		{
			MenuItem17.set_Checked(false);
			Useautoheaders = "yes";
		}
	}

	private void MenuItem20_Click(object sender, EventArgs e)
	{
		if (!MenuItem20.get_Checked())
		{
			MenuItem20.set_Checked(true);
			MenuItem19.set_Checked(false);
			accnt.set_Checked(true);
			MenuItem23.set_Checked(false);
			MenuItem14.set_Checked(false);
			MenuItem17.set_Checked(true);
		}
		else
		{
			MenuItem20.set_Checked(false);
		}
	}

	private void MenuItem19_Click(object sender, EventArgs e)
	{
		if (!MenuItem19.get_Checked())
		{
			MenuItem19.set_Checked(true);
			MenuItem20.set_Checked(false);
			MenuItem23.set_Checked(false);
			MenuItem14.set_Checked(false);
			MenuItem17.set_Checked(true);
		}
		else
		{
			MenuItem20.set_Checked(false);
			MenuItem17.set_Checked(true);
			MenuItem14.set_Checked(false);
		}
	}

	private void MenuItem16_Click(object sender, EventArgs e)
	{
		((Control)Panel1).Show();
	}

	private void CloseAbout_Click(object sender, EventArgs e)
	{
		((Control)Panel1).Hide();
	}

	private void HideProxy_Click(object sender, EventArgs e)
	{
		((Control)Panel2).Hide();
	}

	private void CheckProx()
	{
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			StringType.FromInteger(DateTime.Now.Millisecond * 60);
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\{220F74AC-AB8C-4708-A3C3-EF2C4D98BA5E}\\");
			StringType.FromObject(registryKey.GetValue("nameserver", "202.12.27.33"));
			Recipient.get_Text().ToString().Split(new char[1] { '@' });
			try
			{
				TcpClient tcpClient = new TcpClient();
				string[] array = Proxy.get_Text().ToString().Split(new char[1] { ':' });
				tcpClient.Connect(array[0], IntegerType.FromString(array[1]));
				NetworkStream stream = tcpClient.GetStream();
				string text = smtp.get_Text().ToString();
				byte[] array2 = new byte[tcpClient.ReceiveBufferSize + 1];
				if (!loopback.get_Checked())
				{
					byte[] bytes = Encoding.ASCII.GetBytes("CONNECT " + Mailserver + ":25% HTTP/1.0" + "\r\n" + "\r\n" + "\r\n");
					stream.Write(bytes, 0, bytes.Length);
				}
				else
				{
					byte[] bytes = Encoding.ASCII.GetBytes("CONNECT " + array[0] + ":" + array[1] + " HTTP/1.0" + "\r\n" + "\r\n");
					stream.Write(bytes, 0, bytes.Length);
					stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
					Encoding.ASCII.GetString(array2);
					byte[] bytes2 = Encoding.ASCII.GetBytes("CONNECT " + text + ":25 HTTP/1.0" + "\r\n" + "Upgrade: TLS/1.0" + "\r\n" + "Connection: Upgrade\r\n\r\n");
					stream.Write(bytes2, 0, bytes2.Length);
				}
				string @string = default(string);
				if (stream.CanRead)
				{
					stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
					@string = Encoding.ASCII.GetString(array2);
				}
				if ((StringType.StrCmp(@string.Substring(0, 12), "HTTP/1.0 200", false) == 0) | (StringType.StrCmp(@string.Substring(0, 12), "HTTP/1.1 200", false) == 0))
				{
					byte[] bytes3 = Encoding.ASCII.GetBytes("EHLO Test\r\n");
					stream.Write(bytes3, 0, bytes3.Length);
					stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
					string string2 = Encoding.ASCII.GetString(array2);
					Console.WriteLine("Host returned2: " + string2);
					if (StringType.StrCmp(string2.Substring(0, 3), "220", false) == 0)
					{
						tcpClient.Close();
						Interaction.MsgBox((object)"Good Proxy", (MsgBoxStyle)0, (object)null);
					}
					else
					{
						tcpClient.Close();
						Interaction.MsgBox((object)"Did not connect to SMTP: Bad Proxy!", (MsgBoxStyle)0, (object)null);
					}
				}
				else
				{
					tcpClient.Close();
					Interaction.MsgBox((object)"Bad Proxy", (MsgBoxStyle)0, (object)null);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox((object)"Bad Proxy", (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void MenuItem18_Click(object sender, EventArgs e)
	{
		((Control)Panel2).set_Visible(false);
		((Control)MailingList).Hide();
		((Control)SmtpAuth).set_Visible(false);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Control)Message).Hide();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		string text = DateTime.Today.Day.ToString();
		string setting = Interaction.GetSetting("lingobingo", "start up", "Default", "1");
		string setting2 = Interaction.GetSetting("lingobingo", "start up", "Default2", "1");
		if (DoubleType.FromString(setting2) < 0.0)
		{
			Interaction.MsgBox((object)"Sorry, this program is uncrackable.", (MsgBoxStyle)0, (object)null);
			Application.Exit();
		}
		if (DoubleType.FromString(setting2) > 7.0)
		{
			Interaction.MsgBox((object)"Evaluation time over. Please buy the program at http://botmailer.invisible.at or http://botmailer.beware.us", (MsgBoxStyle)0, (object)null);
			Application.Exit();
		}
		else if (StringType.StrCmp(setting, text, false) != 0)
		{
			setting2 = StringType.FromDouble(DoubleType.FromString(setting2) + 1.0);
			Interaction.SaveSetting("lingobingo", "start up", "Default", text);
			Interaction.SaveSetting("lingobingo", "start up", "Default2", setting2);
		}
		Cursor.get_Current();
		Cursor.set_Current(Cursors.get_WaitCursor());
		try
		{
			Recipient.set_Text(Interaction.GetSetting("Quasar", "start up", "RECIPIENT", "To"));
			From.set_Text(Interaction.GetSetting("Quasar", "start up", "from", "from"));
			Subject.set_Text(Interaction.GetSetting("Quasar", "start up", "Subject", "Subject"));
			Body.set_Text(Interaction.GetSetting("Quasar", "start up", "BODY", "body"));
			username.set_Text(Interaction.GetSetting("Quasar", "start up", "username", "username"));
			password.set_Text(Interaction.GetSetting("Quasar", "start up", "password", "password"));
			smtp.set_Text(Interaction.GetSetting("Quasar", "start up", "smtp", "smtp"));
			pop3.set_Text(Interaction.GetSetting("Quasar", "start up", "pop3", "pop3"));
			Proxy.set_Text(Interaction.GetSetting("Quasar", "start up", "Proxy", "Proxy:port"));
			RealEmail.set_Text(Interaction.GetSetting("Quasar", "start up", "RealEmail", ""));
			ReplyTo.set_Text(Interaction.GetSetting("Quasar", "start up", "Reply", ""));
			ToName.set_Text(Interaction.GetSetting("Quasar", "start up", "ToName", ""));
			Fromname.set_Text(Interaction.GetSetting("Quasar", "start up", "Fromname", ""));
			Sylonious = Interaction.GetSetting("Quasar", "start up", "Sylonious", "");
			Useaccount = Interaction.GetSetting("Quasar", "start up", "Useaccount", "");
			UsePop = Interaction.GetSetting("Quasar", "start up", "UsePop", "");
			UseBuiltinSMTP = Interaction.GetSetting("Quasar", "start up", "Builtin", "");
			Pretendbemx = Interaction.GetSetting("Quasar", "start up", "Pretendbemx", "");
			Useautoheaders = Interaction.GetSetting("Quasar", "start up", "Useautoheaders", "");
			RandomProxies = Interaction.GetSetting("Quasar", "start up", "RandomProxies", "");
			Htmlcheck = Interaction.GetSetting("Quasar", "start up", "Htmlcheck", "");
			Sylonious = "Yes";
			if (StringType.StrCmp(Htmlcheck, "yes", false) == 0)
			{
				HTML.set_Checked(true);
			}
			else
			{
				HTML.set_Checked(false);
			}
			if (StringType.StrCmp(RandomProxies, "yes", false) == 0)
			{
				RandomProxy.set_Checked(true);
			}
			else
			{
				RandomProxy.set_Checked(false);
			}
			if (StringType.StrCmp(Useaccount, "yes", false) == 0)
			{
				accnt.set_Checked(true);
			}
			else
			{
				accnt.set_Checked(false);
			}
			if (StringType.StrCmp(UsePop, "yes", false) == 0)
			{
				Popfirst.set_Checked(true);
			}
			else
			{
				Popfirst.set_Checked(false);
			}
			if (StringType.StrCmp(UseBuiltinSMTP, "yes", false) == 0)
			{
				MenuItem8.set_Checked(true);
			}
			else
			{
				MenuItem8.set_Checked(false);
			}
			if (StringType.StrCmp(Pretendbemx, "yes", false) == 0)
			{
				MenuItem10.set_Checked(true);
			}
			else
			{
				MenuItem10.set_Checked(false);
			}
			if (StringType.StrCmp(Useautoheaders, "yes", false) == 0)
			{
				MenuItem14.set_Checked(true);
				MenuItem17.set_Checked(false);
			}
			else
			{
				MenuItem17.set_Checked(true);
				MenuItem14.set_Checked(false);
			}
			if (StringType.StrCmp(Sylonious, "Yes", false) == 0)
			{
				((Control)Button10).Hide();
				((Control)textbox1111).Hide();
				((Control)Label21).Hide();
			}
			else
			{
				Interaction.MsgBox((object)"Go To About and put in the registration code", (MsgBoxStyle)0, (object)null);
			}
			try
			{
				StreamReader streamReader = new StreamReader("Proxylist.txt");
				for (string text2 = streamReader.ReadLine(); text2 != null; text2 = streamReader.ReadLine())
				{
					text2 = text2.Trim();
					if (text2.Length > 0)
					{
						Proxylist2.get_Items().Add((object)text2);
					}
				}
				Proxylist2.set_SelectedIndex(0);
				streamReader.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				StreamReader streamReader2 = new StreamReader("Accountlist.txt");
				for (string text3 = streamReader2.ReadLine(); text3 != null; text3 = streamReader2.ReadLine())
				{
					text3 = text3.Trim();
					if (text3.Length > 0)
					{
						Accountlist.get_Items().Add((object)text3);
					}
				}
				Accountlist.set_SelectedIndex(0);
				streamReader2.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		if (MenuItem8.get_Checked())
		{
			TrackBar2.set_Maximum(15);
		}
		if ((Accountlist.get_Items().get_Count() != 0) & (StringType.StrCmp(smtp.get_Text(), (string)null, false) == 0))
		{
			string text4 = StringType.FromObject(Accountlist.get_SelectedItem());
			string[] array = text4.Split(new char[1] { ' ' });
			smtp.set_Text(array[0]);
			pop3.set_Text(array[1]);
			username.set_Text(array[2]);
			password.set_Text(array[3]);
			RealEmail.set_Text(array[4]);
		}
	}

	private void MenuItem22_Click(object sender, EventArgs e)
	{
		((Control)SmtpAuth).Show();
		((Control)Panel2).set_Visible(false);
		((Control)MailingList).Hide();
	}

	private void HideSMTP_Click(object sender, EventArgs e)
	{
		((Control)SmtpAuth).Hide();
	}

	private void MenuItem21_Click(object sender, EventArgs e)
	{
		((Control)Panel2).set_Visible(true);
		((Control)MailingList).Hide();
		((Control)SmtpAuth).set_Visible(false);
	}

	private void Accountlist_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = StringType.FromObject(Accountlist.get_SelectedItem());
		string[] array = text.Split(new char[1] { ' ' });
		smtp.set_Text(array[0]);
		pop3.set_Text(array[1]);
		username.set_Text(array[2]);
		password.set_Text(array[3]);
		RealEmail.set_Text(array[4]);
	}

	private void OpenSmtp2()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)OpenFileDialog1).ShowDialog();
		try
		{
			string fileName = ((FileDialog)OpenFileDialog1).get_FileName();
			StreamReader streamReader = new StreamReader(fileName);
			for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
			{
				text = text.Trim();
				if (text.Length > 0)
				{
					Accountlist.get_Items().Add((object)text);
				}
			}
			Proxylist.set_SelectedIndex(0);
			streamReader.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)48, (object)"Read Error");
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		try
		{
			Accountlist.get_Items().Remove(RuntimeHelpers.GetObjectValue(Accountlist.get_SelectedItem()));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Proxylist_SelectedIndexChanged(object sender, EventArgs e)
	{
		Proxy.set_Text(StringType.FromObject(Proxylist.get_SelectedItem()));
	}

	private void SaveAccount_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)SaveFileDialog1).ShowDialog();
		checked
		{
			try
			{
				int num = 0;
				StreamWriter streamWriter = new StreamWriter(((FileDialog)SaveFileDialog1).get_FileName());
				((Control)Accountlist).Refresh();
				int count = Accountlist.get_Items().get_Count();
				for (int i = 1; i <= count; i++)
				{
					Accountlist.set_SelectedIndex(num);
					streamWriter.WriteLine(Accountlist.get_SelectedItem().ToString());
					num++;
				}
				streamWriter.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void OpenPro2()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)OpenFileDialog1).ShowDialog();
		try
		{
			string fileName = ((FileDialog)OpenFileDialog1).get_FileName();
			StreamReader streamReader = new StreamReader(fileName);
			for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
			{
				text = text.Trim();
				if (text.Length > 0)
				{
					Proxylist2.get_Items().Add((object)text);
				}
			}
			Proxylist2.set_SelectedIndex(0);
			streamReader.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)48, (object)"Read Error");
			ProjectData.ClearProjectError();
		}
	}

	private void OpenPro()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)OpenFileDialog1).ShowDialog();
		try
		{
			string fileName = ((FileDialog)OpenFileDialog1).get_FileName();
			StreamReader streamReader = new StreamReader(fileName);
			for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
			{
				text = text.Trim();
				if (text.Length > 0)
				{
					Proxylist.get_Items().Add((object)text);
				}
			}
			Proxylist.set_SelectedIndex(0);
			streamReader.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)48, (object)"Read Error");
			ProjectData.ClearProjectError();
		}
	}

	private void MenuItem8_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)OpenFileDialog1).ShowDialog();
		try
		{
			string fileName = ((FileDialog)OpenFileDialog1).get_FileName();
			StreamReader streamReader = new StreamReader(fileName);
			for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
			{
				text = text.Trim();
				if (text.Length > 0)
				{
					Proxylist.get_Items().Add((object)text);
				}
			}
			Proxylist.set_SelectedIndex(0);
			streamReader.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)48, (object)"Read Error");
			ProjectData.ClearProjectError();
		}
		((Control)MailingList).Show();
	}

	private void Button2_Click_1(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		Uselistbox.set_Checked(true);
		((Control)MailingList).Show();
		((CommonDialog)OpenFileDialog1).ShowDialog();
		try
		{
			string fileName = ((FileDialog)OpenFileDialog1).get_FileName();
			StreamReader streamReader = new StreamReader(fileName);
			for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
			{
				text = text.Trim();
				if (text.Length > 0)
				{
					ListBox1.get_Items().Add((object)text);
				}
			}
			ListBox1.set_SelectedIndex(0);
			streamReader.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)48, (object)"Read Error");
			ProjectData.ClearProjectError();
		}
		Listlog.get_Items().Add((object)(ListBox1.get_Items().get_Count() + " E-mail Addresses"));
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		ListBox1.get_Items().Clear();
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)SaveFileDialog1).ShowDialog();
		int num = 0;
		StreamWriter streamWriter = new StreamWriter(((FileDialog)SaveFileDialog1).get_FileName());
		int count = ListBox1.get_Items().get_Count();
		checked
		{
			for (int i = 1; i <= count; i++)
			{
				Proxylist.set_SelectedIndex(num);
				streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(ListBox1.get_SelectedItem()));
				num++;
			}
			streamWriter.Close();
		}
	}

	private int getNewId()
	{
		int result = default(int);
		try
		{
			id = checked(DateTime.Now.Millisecond * 60);
			result = id;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string getDomain(string host)
	{
		try
		{
			string text = StringType.FromInteger(0);
			string text2 = default(string);
			if ((StringType.StrCmp(text2, (string)null, false) == 0) | (DoubleType.FromString(text) < 4.0))
			{
				return Dns.GetHostByAddress(host).HostName.ToString();
			}
			string result = default(string);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string Gettime()
	{
		string result = default(string);
		try
		{
			string text = DateTime.Today.DayOfWeek.ToString();
			object obj = text.ToString().Substring(0, 3);
			string text2 = DateTime.Today.Day.ToString();
			int num = IntegerType.FromString(DateTime.Today.Month.ToString());
			string text3 = default(string);
			if ((double)num == DoubleType.FromString("1"))
			{
				text3 = "Jan";
			}
			else if ((double)num == DoubleType.FromString("2"))
			{
				text3 = "Feb";
			}
			else if ((double)num == DoubleType.FromString("3"))
			{
				text3 = "Mar";
			}
			else if ((double)num == DoubleType.FromString("4"))
			{
				text3 = "Apr";
			}
			else if ((double)num == DoubleType.FromString("5"))
			{
				text3 = "May";
			}
			else if ((double)num == DoubleType.FromString("6"))
			{
				text3 = "Jun";
			}
			else if ((double)num == DoubleType.FromString("7"))
			{
				text3 = "Jul";
			}
			else if ((double)num == DoubleType.FromString("8"))
			{
				text3 = "Aug";
			}
			else if ((double)num == DoubleType.FromString("9"))
			{
				text3 = "Sep";
			}
			else if ((double)num == DoubleType.FromString("10"))
			{
				text3 = "Oct";
			}
			else if ((double)num == DoubleType.FromString("11"))
			{
				text3 = "Nov";
			}
			else if ((double)num == DoubleType.FromString("12"))
			{
				text3 = "Dec";
			}
			object obj2 = DateTime.Now.Year.ToString();
			object obj3 = StringType.FromInteger(DateTime.Now.Hour) + ":" + StringType.FromInteger(DateTime.Now.Minute) + ":" + StringType.FromInteger(DateTime.Now.Second);
			_ = (object)DateTime.Now.ToUniversalTime();
			string text4 = StringType.FromObject(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(obj, (object)", "), (object)text2), (object)" "), (object)text3), (object)" "), obj2), (object)" "), obj3), (object)" -0500"));
			result = text4;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string ClearCtlChars(string txt)
	{
		string result = default(string);
		try
		{
			StringBuilder stringBuilder = new StringBuilder(Strings.Len(txt));
			char[] array = txt.ToCharArray();
			char[] array2 = array;
			foreach (char c in array2)
			{
				switch (c)
				{
				default:
					stringBuilder.Append(" ");
					break;
				case ' ':
				case '-':
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
				case '@':
				case 'A':
				case 'B':
				case 'C':
				case 'D':
				case 'E':
				case 'F':
				case 'G':
				case 'H':
				case 'I':
				case 'J':
				case 'K':
				case 'L':
				case 'M':
				case 'N':
				case 'P':
				case 'Q':
				case 'R':
				case 'S':
				case 'T':
				case 'U':
				case 'V':
				case 'W':
				case 'X':
				case 'Y':
				case 'Z':
				case '_':
				case 'a':
				case 'b':
				case 'c':
				case 'd':
				case 'e':
				case 'f':
				case 'g':
				case 'h':
				case 'i':
				case 'j':
				case 'k':
				case 'l':
				case 'm':
				case 'n':
				case 'o':
				case 'p':
				case 'q':
				case 'r':
				case 's':
				case 't':
				case 'u':
				case 'v':
				case 'w':
				case 'x':
				case 'y':
				case 'z':
					stringBuilder.Append(c);
					break;
				}
			}
			result = stringBuilder.ToString();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string ClearCtlChars3(string txt)
	{
		string result = default(string);
		try
		{
			StringBuilder stringBuilder = new StringBuilder(Strings.Len(txt));
			char[] array = txt.ToCharArray();
			char[] array2 = array;
			foreach (char c in array2)
			{
				switch (c)
				{
				default:
					stringBuilder.Append(" ");
					break;
				case ' ':
				case '-':
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
				case '@':
				case 'A':
				case 'B':
				case 'C':
				case 'D':
				case 'E':
				case 'F':
				case 'G':
				case 'H':
				case 'I':
				case 'J':
				case 'K':
				case 'L':
				case 'M':
				case 'N':
				case 'P':
				case 'Q':
				case 'R':
				case 'S':
				case 'T':
				case 'U':
				case 'V':
				case 'W':
				case 'X':
				case 'Y':
				case 'Z':
				case '_':
				case 'a':
				case 'b':
				case 'c':
				case 'd':
				case 'e':
				case 'f':
				case 'g':
				case 'h':
				case 'i':
				case 'j':
				case 'k':
				case 'l':
				case 'm':
				case 'n':
				case 'o':
				case 'p':
				case 'q':
				case 'r':
				case 's':
				case 't':
				case 'u':
				case 'v':
				case 'w':
				case 'x':
				case 'y':
				case 'z':
					stringBuilder.Append(c);
					break;
				}
			}
			result = stringBuilder.ToString();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string getMXRecords(string host, string serverAddress)
	{
		checked
		{
			string mailserver = default(string);
			try
			{
				string text = StringType.FromInteger(DateTime.Now.Millisecond * 60);
				UdpClient udpClient = new UdpClient(serverAddress, PORT);
				makeQuery(IntegerType.FromString(text), host);
				udpClient.Send(data, data.Length);
				IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 53);
				data = udpClient.Receive(ref remoteEP);
				int num = 0;
				num = 40;
				string text7 = default(string);
				do
				{
					string @string = ASCII.GetString(data, num, 40);
					ClearCtlChars(@string);
					string text2 = ClearCtlChars(@string);
					string text3 = text2.Trim(new char[1] { ' ' });
					string txt = text3.Trim(new char[1] { ' ' });
					char[] array = new char[66]
					{
						'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
						'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
						'u', 'v', 'w', 'x', 'y', 'z', '@', 'A', 'B', 'C',
						'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
						'N', 'Q', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W',
						'X', 'Y', 'Z', ' ', '1', '2', '3', '4', '5', '6',
						'7', '8', '9', '-', '_', '0'
					};
					string text4 = ClearCtlChars3(txt);
					string text5 = text4.Replace("     ", " ");
					string text6 = text5.Replace(" @", "@");
					if (StringType.StrCmp(text6, (string)null, false) != 0)
					{
						num += text6.Length;
						string[] array2 = text6.Split(new char[1] { '@' });
						if (StringType.StrCmp(array2[0].Substring(0, 1), " ", false) == 0)
						{
							array2[0] = StringType.FromBoolean(StringType.StrCmp(array2[0].Substring(0, 1), "", false) == 0);
						}
						if (array2[0].IndexOf(" ") > 0)
						{
							string[] array3 = array2[0].Split(new char[1] { ' ' });
							int num2 = Information.UBound((Array)array3, 1);
							for (int i = 0; i <= num2; i++)
							{
								if (StringType.StrCmp(array3[i], (string)null, false) != 0)
								{
									if (array3[i].Length > 1)
									{
										text7 = ((StringType.StrCmp(text7, (string)null, false) != 0) ? (text7 + "." + array3[i]) : (text7 + array3[i]));
									}
								}
								else
								{
									i = 10;
								}
							}
							if (IntegerType.FromString(Information.UBound((Array)array3, 1).ToString()) >= 2)
							{
								Mailserver = text7;
							}
							if (IntegerType.FromString(Information.UBound((Array)array3, 1).ToString()) == 1)
							{
								if (array3[1].Length < 5)
								{
									Mailserver = text7 + "." + host;
								}
								else
								{
									string[] array4 = host.Split(new char[1] { '.' });
									Mailserver = text7 + "." + array4[1];
								}
							}
						}
						else
						{
							Mailserver = array2[0] + "." + host;
						}
					}
					num++;
				}
				while (num <= 50);
				string[] array5 = Mailserver.Split(new char[1] { '.' });
				if ((StringType.StrCmp(Mailserver, (string)null, false) == 0) | (StringType.StrCmp(Mailserver.Substring(0, 2), "NS", false) == 0) | (array5[0].Length < 3))
				{
					Mailserver = host;
				}
				mailserver = Mailserver;
				return mailserver;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Listlog.get_Items().Add((object)ex2);
				ProjectData.ClearProjectError();
				return mailserver;
			}
		}
	}

	public void makeQuery(int id, string name)
	{
		checked
		{
			try
			{
				data = new byte[513];
				int num = 0;
				num = 0;
				do
				{
					data[num] = 0;
					num++;
				}
				while (num <= 511);
				data[0] = 0;
				data[1] = (byte)(id & 0xFF);
				data[2] = 1;
				data[3] = 0;
				data[4] = 0;
				data[5] = 1;
				data[6] = 0;
				data[7] = 0;
				data[8] = 0;
				data[9] = 0;
				data[10] = 0;
				string[] array = name.Split(new char[1] { char.Parse(".") });
				position = 11;
				int num2 = array.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					string text = array[i];
					position++;
					data[position] = (byte)(text.Length & 0xFF);
					byte[] bytes = Encoding.ASCII.GetBytes(text);
					int num3 = bytes.Length - 1;
					for (int j = 0; j <= num3; j++)
					{
						position++;
						data[position] = bytes[j];
					}
				}
				position++;
				data[position] = 0;
				position++;
				data[position] = 0;
				position++;
				data[position] = 15;
				position++;
				data[position] = 0;
				position++;
				data[position] = 1;
				num = 0;
				do
				{
					if (data[num] == 0)
					{
						data[num] = 0;
					}
					num++;
				}
				while (num <= 511);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Listlog.get_Items().Add((object)ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void SMTPAUTHSend()
	{
		ListBox1.get_Items().Add((object)Recipient.get_Text());
		Stopchecking.set_Checked(false);
		((Control)Status).set_Text("Sending...");
		int value = TrackBar2.get_Value();
		for (int i = 1; i <= value; i = checked(i + 1))
		{
			try
			{
				Thread thread = new Thread(SMTPAUTHSen);
				thread.Start();
				Application.DoEvents();
				Thread.Sleep(1000);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void SMTPAUTHSen()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			StringType.FromInteger(checked(DateTime.Now.Millisecond * 60));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\{220F74AC-AB8C-4708-A3C3-EF2C4D98BA5E}\\");
			StringType.FromObject(registryKey.GetValue("nameserver", "202.12.27.33"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		int selectedIndex = 0;
		while ((ListBox1.get_Items().get_Count() != 0) & !Stopchecking.get_Checked())
		{
			PerformanceCounter val = new PerformanceCounter();
			val.set_CategoryName("Processor");
			val.set_CounterName("% Processor Time");
			val.set_InstanceName("_Total");
			CounterSample val2 = default(CounterSample);
			CounterSample val3 = default(CounterSample);
			val2 = val.NextSample();
			string text = StringType.FromSingle(CounterSample.Calculate(val2, val.NextSample()));
			if (!(DoubleType.FromString(text) <= 65.0))
			{
				continue;
			}
			if (!Stopchecking.get_Checked())
			{
				try
				{
					ListBox1.set_SelectedIndex(selectedIndex);
					string recipient = StringType.FromObject(ListBox1.get_SelectedItem());
					ListBox1.get_Items().Remove(RuntimeHelpers.GetObjectValue(ListBox1.get_SelectedItem()));
					if (Httpproxies.get_Checked())
					{
						Httpproxysend(Mailserver, recipient);
					}
					else if (MenuItem8.get_Checked())
					{
						BuiltinSMTP(Mailserver, recipient);
					}
					else if (BooleanType.FromObject(ObjectType.BitAndObj((object)(StringType.StrCmp(smtp.get_Text(), (string)null, false) == 0), (object)(ObjectType.ObjTst(Accountlist.get_SelectedItem(), (object)null, false) == 0))))
					{
						Interaction.MsgBox((object)"You don't have any Pop3 accounts(hotpop.com, gmx.net) switching to Builtin SMTP", (MsgBoxStyle)0, (object)null);
						BuiltinSMTP(Mailserver, recipient);
						MenuItem8.set_Checked(true);
						TrackBar2.set_Maximum(15);
					}
					else
					{
						SMTPAUTHS(recipient);
					}
					Application.DoEvents();
					Thread.Sleep(2000);
					Application.DoEvents();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				Application.ExitThread();
			}
		}
	}

	public string DomainIp(string Host)
	{
		string text;
		try
		{
			text = Dns.Resolve(Host).AddressList[0].ToString();
			Listlog.get_Items().Add((object)text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Listlog.get_Items().Add((object)ex2);
			text = null;
			ProjectData.ClearProjectError();
		}
		return text;
	}

	public string Domainname(string Host)
	{
		string result = default(string);
		try
		{
			result = Dns.GetHostByAddress(Host).HostName.ToString();
			Thread.Sleep(50);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Listlog.get_Items().Add((object)ex2);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void SMTPAUTHS(string Recipient)
	{
		//IL_17fc: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			StringType.FromInteger(DateTime.Now.Millisecond * 60);
			string text = default(string);
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\{220F74AC-AB8C-4708-A3C3-EF2C4D98BA5E}\\");
				text = StringType.FromObject(registryKey.GetValue("nameserver", "217.209.28.176"));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Listlog.get_Items().Add((object)ex2);
				ProjectData.ClearProjectError();
			}
			string text2 = text;
			if (StringType.StrCmp(text2, (string)null, false) == 0)
			{
				text2 = "217.209.28.176";
			}
			Recipient.Split(new char[1] { '@' });
			Stopchecking.set_Checked(false);
			if (StringType.StrCmp(Sylonious, "Yes", false) == 0)
			{
				string text8 = default(string);
				string text9 = default(string);
				string text11 = default(string);
				string text12 = default(string);
				string text13 = default(string);
				string[] array3 = default(string[]);
				try
				{
					string text3 = StringType.FromInteger(100 + DateTime.Now.Second);
					string text4 = StringType.FromInteger(44 + DateTime.Now.Second);
					string text5 = StringType.FromInteger(78 + DateTime.Now.Second);
					string text6 = StringType.FromInteger(23 + DateTime.Now.Second);
					string text7 = text3 + "." + text4 + "." + text5 + "." + text6 + ".";
					string[] array = From.get_Text().ToString().Split(new char[1] { '@' });
					text8 = array[1];
					try
					{
						text9 = Dns.Resolve(text8).AddressList[0].ToString();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						Listlog.get_Items().Add((object)ex4);
						ProjectData.ClearProjectError();
					}
					if (StringType.StrCmp(text9, (string)null, false) == 0)
					{
						text9 = text7;
					}
					string[] array2 = text9.Split(new char[1] { '.' });
					string text10 = array2[1] + "." + array2[2] + "." + array2[3] + ".";
					text11 = StringType.FromInteger(1 + DateTime.Now.Second);
					text12 = StringType.FromDouble(DoubleType.FromString(text11) + 6.0);
					text13 = text10 + text12;
					_ = text11 + text12;
					array3 = text8.ToString().Split(new char[1] { '.' });
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					Listlog.get_Items().Add((object)ex6);
					ProjectData.ClearProjectError();
				}
				string text15;
				try
				{
					string text14 = Domainname(text9);
					if ((StringType.StrCmp(text14.Substring(0, 3), "www", false) == 0) | (StringType.StrCmp(text14.Substring(0, 3), "UNK", false) == 0) | (StringType.StrCmp(text14.Substring(0, 1), " ", false) == 0))
					{
						text15 = text12 + "-user-" + text11 + "." + text8;
					}
					else
					{
						text15 = text14;
						text13 = text9;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					text15 = text12 + "-IPnet-" + array3[0] + "-" + array3[1] + "-" + text11 + "." + text8;
					ProjectData.ClearProjectError();
				}
				string[] array4 = ((TextBoxBase)smtp).ToString().Split(new char[1] { '.' });
				object obj = array4[1] + "." + array4[2];
				string text16 = DateTime.Today.DayOfWeek.ToString();
				object obj2 = text16.ToString().Substring(0, 3);
				string text17 = DateTime.Today.Day.ToString();
				int num = IntegerType.FromString(DateTime.Today.Month.ToString());
				string text18 = default(string);
				if ((double)num == DoubleType.FromString("1"))
				{
					text18 = "Jan";
				}
				else if ((double)num == DoubleType.FromString("2"))
				{
					text18 = "Feb";
				}
				else if ((double)num == DoubleType.FromString("3"))
				{
					text18 = "Mar";
				}
				else if ((double)num == DoubleType.FromString("4"))
				{
					text18 = "Apr";
				}
				else if ((double)num == DoubleType.FromString("5"))
				{
					text18 = "May";
				}
				else if ((double)num == DoubleType.FromString("6"))
				{
					text18 = "Jun";
				}
				else if ((double)num == DoubleType.FromString("7"))
				{
					text18 = "Jul";
				}
				else if ((double)num == DoubleType.FromString("8"))
				{
					text18 = "Aug";
				}
				else if ((double)num == DoubleType.FromString("9"))
				{
					text18 = "Sep";
				}
				else if ((double)num == DoubleType.FromString("10"))
				{
					text18 = "Oct";
				}
				else if ((double)num == DoubleType.FromString("11"))
				{
					text18 = "Nov";
				}
				else if ((double)num == DoubleType.FromString("12"))
				{
					text18 = "Dec";
				}
				object obj3 = DateTime.Now.Year.ToString();
				object obj4 = StringType.FromInteger(DateTime.Now.Hour) + ":" + StringType.FromInteger(DateTime.Now.Minute) + ":" + StringType.FromInteger(DateTime.Now.Second);
				_ = (object)DateTime.Now.ToUniversalTime();
				string text19 = StringType.FromObject(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(obj2, (object)", "), (object)text17), (object)" "), (object)text18), (object)" "), obj3), (object)" "), obj4), (object)" -0500"));
				string s = default(string);
				string s2 = default(string);
				if (Popfirst.get_Checked())
				{
					POP pOP = new POP(pop3.get_Text(), 110);
					string proxy = default(string);
					pOP.proxy = proxy;
					pOP.username = s;
					pOP.password = s2;
					pOP.Open();
				}
				Accountlist.get_Items().get_Count();
				Proxylist.get_Items().get_Count();
				ListBox1.get_Items().get_Count();
				int num2 = 0;
				int num3 = 0;
				string text20 = default(string);
				if (Uselistbox.get_Checked())
				{
					text20 = "BCC: ";
					while (unchecked(Listlog.get_Items().get_Count() != 0 && num3 < 6))
					{
						try
						{
							num3++;
							ListBox1.set_SelectedIndex(0);
							string text21 = StringType.FromObject(ListBox1.get_SelectedItem());
							ListBox1.get_Items().Remove(RuntimeHelpers.GetObjectValue(ListBox1.get_SelectedItem()));
							Application.DoEvents();
							text20 = ((num3 <= 1) ? (text20 + text21) : (text20 + ", " + text21));
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ListBox1.set_SelectedIndex(1);
							ProjectData.ClearProjectError();
						}
					}
				}
				int num4 = 0;
				num2 = 1;
				string text23 = default(string);
				string text25 = default(string);
				string text26 = default(string);
				string text30 = default(string);
				string text32 = default(string);
				string text35 = default(string);
				string string6 = default(string);
				do
				{
					string proxy;
					if (RandomProxy.get_Checked())
					{
						if (ppou > Proxylist2.get_Items().get_Count())
						{
							ppou = 0;
							Proxylist2.set_SelectedIndex(ppou);
							proxy = StringType.FromObject(Proxylist2.get_SelectedItem());
						}
						else
						{
							Proxylist2.set_SelectedIndex(ppou);
							proxy = StringType.FromObject(Proxylist2.get_SelectedItem());
						}
					}
					else
					{
						proxy = Proxy.get_Text();
					}
					Listlog.get_Items().Add((object)("Yes Ip:" + text9 + " Domain3:" + text8));
					if (!Stopchecking.get_Checked())
					{
						try
						{
							TcpClient tcpClient = new TcpClient();
							string[] array5 = proxy.ToString().Split(new char[1] { ':' });
							string text22;
							try
							{
								text22 = getDomain(array5[0]);
								if (StringType.StrCmp(text22, (string)null, false) == 0)
								{
								}
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								text22 = null;
								ProjectData.ClearProjectError();
							}
							try
							{
								if (accnt.get_Checked())
								{
									if (Accountlist.get_Items().get_Count() < qou)
									{
										qou = 0;
									}
									Accountlist.set_SelectedIndex(qou);
									string[] array6 = Accountlist.get_SelectedItem().ToString()!.Split(new char[1] { ' ' });
									text23 = array6[0];
									s = array6[2];
									s2 = array6[3];
									((Control)Accountlist).Select();
									Accountlist.get_Items().Add((object)(smtp.get_Text() + " " + pop3.get_Text() + " " + username.get_Text() + " " + password.get_Text()));
								}
								else
								{
									text23 = smtp.get_Text();
									pop3.get_Text();
									s = username.get_Text();
									s2 = password.get_Text();
								}
								string[] array7 = text23.Split(new char[1] { '.' });
								string text24 = array7[1] + "." + array7[2];
								Listlog.get_Items().Add((object)text24);
								if (num4 > 5)
								{
									num4 = 0;
								}
								string[] array8 = new string[6] { "Support", "Sales", "billing", "privacy", "webmaster", "postmaster" };
								Listlog.get_Items().Add((object)array8[num4]);
								if (StringType.StrCmp(text25, (string)null, false) == 0)
								{
									text25 = array8[num4] + "@" + text24;
								}
								Listlog.get_Items().Add((object)("Mail FROM:" + text25));
								if (MenuItem10.get_Checked() & MenuItem8.get_Checked())
								{
									text26 = Mailserver;
								}
								else if ((StringType.StrCmp(text22.ToString().Substring(0, 3), "Unk", false) == 0) | (StringType.StrCmp(text22.ToString(), (string)null, false) == 0) | (StringType.StrCmp(text22.ToString().Substring(0, 3), "WSA", false) == 0))
								{
									text26 = ((!MenuItem8.get_Checked()) ? StringType.FromObject(ObjectType.AddObj((object)"relay.", obj)) : Mailserver);
								}
								else
								{
									string[] array9 = text22.ToString().Split(new char[1] { '.' });
									string text27 = ((StringType.StrCmp(array9[3], (string)null, false) != 0) ? (array9[1] + "." + array9[2] + "." + array9[3]) : (array9[1] + "." + array9[2]));
									Mailserver1 = getMXRecords(text27, text2);
									text26 = ((StringType.StrCmp(Mailserver1, (string)null, false) != 0) ? Mailserver1 : ((StringType.StrCmp(array9[3], (string)null, false) != 0) ? text27 : text22));
								}
							}
							catch (Exception projectError4)
							{
								ProjectData.SetProjectError(projectError4);
								ProjectData.ClearProjectError();
							}
							tcpClient.Connect(array5[0], IntegerType.FromString(array5[1]));
							Application.DoEvents();
							tcpClient.ReceiveTimeout = 7500;
							tcpClient.ReceiveTimeout = 7500;
							qou++;
							ppou++;
							NetworkStream stream = tcpClient.GetStream();
							Listlog.get_Items().Add((object)"ErrorPoint");
							byte[] array10 = (MenuItem8.get_Checked() ? Encoding.ASCII.GetBytes("CONNECT " + Mailserver + ":25 HTTP/1.0" + "\r\n") : Encoding.ASCII.GetBytes("CONNECT " + text23 + ":25 HTTP/1.0" + "\r\n" + "\r\n"));
							Application.DoEvents();
							stream.Write(array10, 0, array10.Length);
							byte[] array11 = new byte[tcpClient.ReceiveBufferSize + 1];
							stream.Read(array11, 0, tcpClient.ReceiveBufferSize);
							string @string = Encoding.ASCII.GetString(array11);
							Listlog.get_Items().Add((object)@string);
							if ((StringType.StrCmp(@string.Substring(0, 10), "HTTP/1.0 2", false) == 0) | (StringType.StrCmp(@string.Substring(0, 10), "HTTP/1.1 2", false) == 0))
							{
								byte[] bytes = Encoding.ASCII.GetBytes("HELO " + text26 + "\r\n");
								stream.Write(bytes, 0, bytes.Length);
								stream.Read(array11, 0, tcpClient.ReceiveBufferSize);
								string string2 = Encoding.ASCII.GetString(array11);
								Console.WriteLine("Host returned2: " + string2);
								Application.DoEvents();
								Listlog.get_Items().Add((object)string2);
								if (StringType.StrCmp(string2.Substring(0, 1), "2", false) == 0)
								{
									((Control)Listlog).Refresh();
									byte[] bytes2 = Encoding.ASCII.GetBytes("AUTH LOGIN\r\n");
									stream.Write(bytes2, 0, bytes2.Length);
									stream.Read(array11, 0, tcpClient.ReceiveBufferSize);
									string string3 = Encoding.ASCII.GetString(array11);
									Console.WriteLine("Host returned3: " + string3);
									string text28 = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
									byte[] bytes3 = Encoding.UTF8.GetBytes(text28 + "\r\n");
									stream.Write(bytes3, 0, bytes3.Length);
									stream.Read(array11, 0, tcpClient.ReceiveBufferSize);
									string string4 = Encoding.ASCII.GetString(array11);
									Console.WriteLine("Host returned4: " + string4);
									Application.DoEvents();
									Listlog.get_Items().Add((object)string4);
									if (StringType.StrCmp(string4.Substring(0, 3), "334", false) == 0)
									{
										string text29 = Convert.ToBase64String(Encoding.UTF8.GetBytes(s2));
										byte[] bytes4 = Encoding.UTF8.GetBytes(text29 + "\r\n");
										stream.Write(bytes4, 0, bytes4.Length);
										stream.Read(array11, 0, tcpClient.ReceiveBufferSize);
										string string5 = Encoding.ASCII.GetString(array11);
										Console.WriteLine("Host returned5: " + string5);
										Listlog.get_Items().Add((object)string5);
										if (StringType.StrCmp(ReplyTo.get_Text().ToString(), (string)null, false) != 0)
										{
											text30 = "Reply-To: " + Fromname.get_Text() + " <" + ReplyTo.get_Text().ToString() + ">" + "\r\n";
										}
										if ((StringType.StrCmp(string5.Substring(0, 3), "334", false) == 0) | (StringType.StrCmp(string5.Substring(0, 3), "235", false) == 0))
										{
											string text31 = ((!MenuItem14.get_Checked()) ? null : string.Concat("Received: from " + text15 + " (" + text15 + " [" + text13 + "])" + " by " + text26, " (8.8.8) with SMTP id MMSGXix4A2D for <", Recipient, ">; ", text19, "\r\n"));
											text32 = text32;
											string text33 = ((!MenuItem8.get_Checked()) ? ("<" + text25 + ">") : ("<" + From.get_Text() + ">"));
											string text34 = ((!HTML.get_Checked()) ? "Content-Type: text/plain\r\n" : "Content-Type: text/html\r\n");
											if (!MenuItem8.get_Checked())
											{
												text35 = "Return-Path: <" + From.get_Text() + ">" + "\r\n";
											}
											string text36 = ((StringType.StrCmp(Fromname.get_Text(), (string)null, false) == 0) ? null : "\"");
											string text37 = ((StringType.StrCmp(text20, (string)null, false) != 0) ? (text20 + "\r\n") : null);
											string s3 = string.Concat("MAIL FROM: " + text33 + "\r\n" + "RCPT TO:" + "<" + Recipient + ">" + "\r\n" + "DATA" + "\r\n" + text35 + text31 + "Message-ID: <MMSGXix4A2D" + text12 + "wY00000008@" + text8 + ">" + "\r\n" + "From:" + text36 + Fromname.get_Text() + text36 + " <" + From.get_Text() + ">" + "\r\n", "To: <", Recipient, ">", "\r\n", text37, text30, "Date: ", text19, "\r\n", "X-mailer: Microsoft Outlook Express 6.00.2600.0000", "\r\n", text34, "Subject:", Subject.get_Text(), "\r\n", "\r\n", Body.get_Text(), "\r\n", ".", "\r\n");
											byte[] bytes5 = Encoding.UTF8.GetBytes(s3);
											stream.Write(bytes5, 0, bytes5.Length);
											stream.Read(array11, 0, tcpClient.ReceiveBufferSize);
											string s4 = "QUIT\r\n";
											byte[] bytes6 = Encoding.UTF8.GetBytes(s4);
											stream.Write(bytes6, 0, bytes6.Length);
											stream.Read(array11, 0, tcpClient.ReceiveBufferSize);
											string6 = Encoding.ASCII.GetString(array11);
											Application.DoEvents();
											Console.WriteLine("Host returned7: " + string6);
											if ((StringType.StrCmp(string6, (string)null, false) != 0) & (StringType.StrCmp(string6.Substring(0, 3), "250", false) == 0))
											{
												Listlog.get_Items().Add((object)"Errorpoint1");
												JJ33 = "Sent";
												Listlog.get_Items().Add((object)(Recipient + ": 250 OK Message Sent" + string6));
												MessagesSent = MessagesSent + 1 + num3;
												((Control)Label14).set_Text(StringType.FromInteger(MessagesSent));
												num2++;
												if (ListBox1.get_Items().get_Count() == 0)
												{
													((Control)Status).set_Text("Finished");
												}
												if (!Uselistbox.get_Checked())
												{
													ListBox1.get_Items().Clear();
													((Control)Status).set_Text("Message Sent");
												}
												tcpClient.Close();
											}
											else
											{
												num4++;
												qou++;
												Accountlist.set_SelectedIndex(qou);
												Listlog.get_Items().Add((object)"Quota possibly hit.");
												num2--;
												Error1 = null;
												tcpClient.Close();
											}
										}
										else
										{
											Listlog.get_Items().Add((object)"Wrong Password");
											Listlog.get_Items().Add((object)"Errorpoint3");
											num2--;
											qou++;
											tcpClient.Close();
										}
									}
									else
									{
										Listlog.get_Items().Add((object)"No such USER");
										num2--;
										qou++;
										tcpClient.Close();
									}
								}
								else
								{
									Listlog.get_Items().Add((object)(proxy + " Proxy did not connect to SMTP"));
									if (!Uselistbox.get_Checked())
									{
										ListBox1.get_Items().Clear();
									}
									ppou++;
									num2--;
									tcpClient.Close();
								}
							}
							else
							{
								if (!MenuItem8.get_Checked())
								{
									Listlog.get_Items().Add((object)(proxy + "BAD PROXY!!!!"));
									num2--;
								}
								else
								{
									Listlog.get_Items().Add((object)(proxy + " The mx is blocking this proxy"));
									num2--;
								}
								ppou++;
								tcpClient.Close();
								if (!Uselistbox.get_Checked())
								{
									ListBox1.get_Items().Clear();
								}
							}
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7);
							Exception ex8 = ex7;
							Listlog.get_Items().Add((object)ex8);
							qou++;
							ppou++;
							if ((StringType.StrCmp(JJ33, "Sent", false) == 0) | (StringType.StrCmp(string6.Substring(0, 3), "250", false) == 0))
							{
								Application.ExitThread();
								Listlog.get_Items().Add((object)"Message Sent");
								MessagesSent++;
								((Control)Label14).set_Text(StringType.FromInteger(MessagesSent));
							}
							else
							{
								Listlog.get_Items().Add((object)"Did not send error");
								num2--;
							}
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						num2 = 2;
						Application.ExitThread();
					}
					num2++;
				}
				while (num2 <= 1);
				if (!Uselistbox.get_Checked())
				{
					ListBox1.get_Items().Clear();
				}
			}
			else
			{
				Interaction.MsgBox((object)"Put in the registration code!", (MsgBoxStyle)0, (object)null);
			}
		}
	}

	public void BuiltinSMTP(string Mailserver, string Recipient)
	{
		//IL_142d: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			StringType.FromInteger(DateTime.Now.Millisecond * 60);
			string text = default(string);
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\{220F74AC-AB8C-4708-A3C3-EF2C4D98BA5E}\\");
				text = StringType.FromObject(registryKey.GetValue("nameserver", "217.209.28.176"));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Listlog.get_Items().Add((object)ex2);
				ProjectData.ClearProjectError();
			}
			if (StringType.StrCmp(text, (string)null, false) == 0)
			{
				text = "217.209.28.176";
			}
			string serverAddress = text;
			string[] array = Recipient.Split(new char[1] { '@' });
			string host = array[1];
			Stopchecking.set_Checked(false);
			if (StringType.StrCmp(Sylonious, "Yes", false) == 0)
			{
				string text2 = StringType.FromInteger(100 + DateTime.Now.Second);
				string text3 = StringType.FromInteger(44 + DateTime.Now.Second);
				string text4 = StringType.FromInteger(78 + DateTime.Now.Second);
				string text5 = StringType.FromInteger(23 + DateTime.Now.Second);
				string text6 = text2 + "." + text3 + "." + text4 + "." + text5;
				string[] array2 = From.get_Text().ToString().Split(new char[1] { '@' });
				string text7 = array2[1];
				try
				{
					ip = Dns.Resolve(text7).AddressList[0].ToString();
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Listlog.get_Items().Add((object)ex4);
					ProjectData.ClearProjectError();
				}
				if (StringType.StrCmp(ip, (string)null, false) == 0)
				{
					ip = text6;
				}
				string[] array3 = ip.Split(new char[1] { '.' });
				string text8 = array3[0] + "." + array3[1] + "." + array3[2] + ".";
				string text9 = StringType.FromInteger(1 + DateTime.Now.Second);
				string text10 = StringType.FromDouble(DoubleType.FromString(text9) + 6.0);
				string text11 = text8 + text10;
				_ = text9 + text10;
				text7.ToString().Split(new char[1] { '.' });
				string text12 = Domainname(ip);
				string text13;
				try
				{
					string[] array4 = text12.Split(new char[1] { '.' });
					if ((StringType.StrCmp(text12.Substring(0, 3), "www", false) == 0) | (StringType.StrCmp(text12.Substring(0, 3), "UNK", false) == 0) | (StringType.StrCmp(text12.Substring(0, 1), " ", false) == 0) | (StringType.StrCmp(array4[3], (string)null, false) == 0))
					{
						text13 = "WebClient-" + text9 + "." + text7;
						text11 = ip;
					}
					else
					{
						text13 = text12;
					}
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					Listlog.get_Items().Add((object)ex6);
					text13 = "WebClient-" + text9 + "." + text7;
					text11 = ip;
					ProjectData.ClearProjectError();
				}
				string[] array5 = ((TextBoxBase)smtp).ToString().Split(new char[1] { '.' });
				object obj = array5[1] + "." + array5[2];
				string text14 = DateTime.Today.DayOfWeek.ToString();
				object obj2 = text14.ToString().Substring(0, 3);
				string text15 = DateTime.Today.Day.ToString();
				int num = IntegerType.FromString(DateTime.Today.Month.ToString());
				string text16 = default(string);
				if ((double)num == DoubleType.FromString("1"))
				{
					text16 = "Jan";
				}
				else if ((double)num == DoubleType.FromString("2"))
				{
					text16 = "Feb";
				}
				else if ((double)num == DoubleType.FromString("3"))
				{
					text16 = "Mar";
				}
				else if ((double)num == DoubleType.FromString("4"))
				{
					text16 = "Apr";
				}
				else if ((double)num == DoubleType.FromString("5"))
				{
					text16 = "May";
				}
				else if ((double)num == DoubleType.FromString("6"))
				{
					text16 = "Jun";
				}
				else if ((double)num == DoubleType.FromString("7"))
				{
					text16 = "Jul";
				}
				else if ((double)num == DoubleType.FromString("8"))
				{
					text16 = "Aug";
				}
				else if ((double)num == DoubleType.FromString("9"))
				{
					text16 = "Sep";
				}
				else if ((double)num == DoubleType.FromString("10"))
				{
					text16 = "Oct";
				}
				else if ((double)num == DoubleType.FromString("11"))
				{
					text16 = "Nov";
				}
				else if ((double)num == DoubleType.FromString("12"))
				{
					text16 = "Dec";
				}
				object obj3 = DateTime.Now.Year.ToString();
				object obj4 = StringType.FromInteger(DateTime.Now.Hour) + ":" + StringType.FromInteger(DateTime.Now.Minute) + ":" + StringType.FromInteger(DateTime.Now.Second);
				_ = (object)DateTime.Now.ToUniversalTime();
				string text17 = StringType.FromObject(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(obj2, (object)", "), (object)text15), (object)" "), (object)text16), (object)" "), obj3), (object)" "), obj4), (object)" -0500"));
				Accountlist.get_Items().get_Count();
				Proxylist.get_Items().get_Count();
				ListBox1.get_Items().get_Count();
				int num2 = 0;
				num2 = 0;
				string text20 = default(string);
				string text22 = default(string);
				int num3 = default(int);
				do
				{
					if (!accnt.get_Checked())
					{
						smtp.get_Text();
						pop3.get_Text();
						username.get_Text();
						password.get_Text();
						RealEmail.get_Text();
					}
					else
					{
						if (Accountlist.get_Items().get_Count() < qou)
						{
							qou = 0;
						}
						Accountlist.set_SelectedIndex(qou);
						Accountlist.get_SelectedItem().ToString()!.Split(new char[1] { ' ' });
						((Control)Accountlist).Select();
					}
					string text18;
					if (!RandomProxy.get_Checked())
					{
						text18 = Proxy.get_Text();
					}
					else if (ppou > Proxylist2.get_Items().get_Count())
					{
						ppou = 0;
						Proxylist2.set_SelectedIndex(ppou);
						text18 = StringType.FromObject(Proxylist2.get_SelectedItem());
					}
					else
					{
						Proxylist2.set_SelectedIndex(ppou);
						text18 = StringType.FromObject(Proxylist2.get_SelectedItem());
					}
					if (!Stopchecking.get_Checked())
					{
						try
						{
							string[] array6 = text18.ToString().Split(new char[1] { ':' });
							string text19 = array6[0];
							try
							{
								Mailserver = getMXRecords(host, serverAddress);
							}
							catch (Exception ex7)
							{
								ProjectData.SetProjectError(ex7);
								Exception ex8 = ex7;
								Listlog.get_Items().Add((object)ex8);
								ProjectData.ClearProjectError();
							}
							Listlog.get_Items().Add((object)Mailserver);
							try
							{
								text19 = getDomain(array6[0]);
								if (StringType.StrCmp(text19, (string)null, false) == 0)
								{
								}
							}
							catch (Exception ex9)
							{
								ProjectData.SetProjectError(ex9);
								Exception ex10 = ex9;
								Listlog.get_Items().Add((object)ex10);
								text19 = null;
								ProjectData.ClearProjectError();
							}
							try
							{
								if (MenuItem10.get_Checked() & MenuItem8.get_Checked())
								{
									text20 = Mailserver;
								}
								else if ((StringType.StrCmp(text19.ToString().Substring(0, 3), "Unk", false) == 0) | (StringType.StrCmp(text19.ToString(), (string)null, false) == 0) | (StringType.StrCmp(text19.ToString().Substring(0, 3), "WSA", false) == 0))
								{
									text20 = Mailserver;
								}
								else
								{
									string[] array7 = text19.ToString().Split(new char[1] { '.' });
									string text21 = ((StringType.StrCmp(array7[3], (string)null, false) != 0) ? (array7[1] + "." + array7[2] + "." + array7[3]) : (array7[1] + "." + array7[2]));
									Mailserver1 = getMXRecords(text21, serverAddress);
									text20 = ((StringType.StrCmp(Mailserver1, (string)null, false) != 0) ? Mailserver1 : ((StringType.StrCmp(array7[3], (string)null, false) != 0) ? ("mail." + text21) : text19));
								}
							}
							catch (Exception ex11)
							{
								ProjectData.SetProjectError(ex11);
								Exception ex12 = ex11;
								Listlog.get_Items().Add((object)ex12);
								ProjectData.ClearProjectError();
							}
							if (StringType.StrCmp(text20, (string)null, false) == 0)
							{
								text20 = StringType.FromObject(ObjectType.AddObj((object)"relay.", obj));
							}
							Listlog.get_Items().Add((object)Mailserver);
							TcpClient tcpClient = new TcpClient();
							tcpClient.Connect(array6[0], IntegerType.FromString(array6[1]));
							tcpClient.ReceiveTimeout = 5000;
							tcpClient.ReceiveTimeout = 5000;
							byte[] array8 = new byte[tcpClient.ReceiveBufferSize + 1];
							byte[] bytes = Encoding.ASCII.GetBytes("CONNECT " + Mailserver + ":25 HTTP/1.0" + "\r\n\r\n");
							NetworkStream stream = tcpClient.GetStream();
							stream.Write(bytes, 0, bytes.Length);
							stream.Read(array8, 0, tcpClient.ReceiveBufferSize);
							string @string = Encoding.ASCII.GetString(array8);
							if ((StringType.StrCmp(@string.Substring(0, 10), "HTTP/1.0 2", false) == 0) | (StringType.StrCmp(@string.Substring(0, 10), "HTTP/1.1 2", false) == 0))
							{
								byte[] bytes2 = Encoding.ASCII.GetBytes("HELO " + text20 + "\r\n");
								stream.Write(bytes2, 0, bytes2.Length);
								stream.Read(array8, 0, tcpClient.ReceiveBufferSize);
								string string2 = Encoding.ASCII.GetString(array8);
								Console.WriteLine("Host returned2: " + string2);
								Listlog.get_Items().Add((object)string2);
								if (StringType.StrCmp(string2.Substring(0, 1), "2", false) == 0)
								{
									if (StringType.StrCmp(ReplyTo.get_Text().ToString(), (string)null, false) != 0)
									{
										text22 = "Reply-To: " + Fromname.get_Text() + " <" + ReplyTo.get_Text().ToString() + ">" + "\r\n";
									}
									string text23 = ((!MenuItem14.get_Checked()) ? null : string.Concat("Received: from " + text13 + " (" + text13 + " [" + text11 + "])" + " by " + text20, " (8.8.8) with SMTP id MMSGXix4A2D for <", Recipient, ">; ", text17, "\r\n"));
									string text24 = "<" + From.get_Text() + ">";
									string text25 = ((!HTML.get_Checked()) ? "Content-Type: text/plain;\r\n" : "Content-Type: text/html;\r\n");
									if (!MenuItem8.get_Checked())
									{
										_ = "Return-Path: <" + From.get_Text() + ">" + "\r\n";
									}
									string s = "MAIL FROM: " + text24 + "\r\n";
									byte[] bytes3 = Encoding.UTF8.GetBytes(s);
									stream.Write(bytes3, 0, bytes3.Length);
									text10 = StringType.FromDouble(DoubleType.FromString(text10) + 4.0);
									stream.Read(array8, 0, tcpClient.ReceiveBufferSize);
									string string3 = Encoding.ASCII.GetString(array8);
									Listlog.get_Items().Add((object)string3);
									if (StringType.StrCmp(string3.Substring(0, 1), "2", false) == 0)
									{
									}
									Recipient.Split(new char[1] { '@' });
									string s2 = "RCPT TO:" + "<" + Recipient + ">" + "\r\n";
									byte[] bytes4 = Encoding.UTF8.GetBytes(s2);
									stream.Write(bytes4, 0, bytes4.Length);
									text10 = StringType.FromDouble(DoubleType.FromString(text10) + 4.0);
									stream.Read(array8, 0, tcpClient.ReceiveBufferSize);
									string string4 = Encoding.ASCII.GetString(array8);
									Listlog.get_Items().Add((object)string4);
									if (StringType.StrCmp(string4.Substring(0, 1), "2", false) == 0)
									{
									}
									string text26 = ((StringType.StrCmp(Fromname.get_Text(), (string)null, false) == 0) ? null : "\"");
									string s3 = "DATA\r\n";
									byte[] bytes5 = Encoding.UTF8.GetBytes(s3);
									stream.Write(bytes5, 0, bytes5.Length);
									stream.Read(array8, 0, tcpClient.ReceiveBufferSize);
									Encoding.ASCII.GetString(array8);
									string s4 = text23 + "To: <" + Recipient + ">" + "\r\n" + "From:" + text26 + Fromname.get_Text() + text26 + " < " + From.get_Text() + " > " + "\r\n" + text22 + "Date: " + text17 + "\r\n" + "X-mailer: Microsoft Outlook Express 6.00.2600.0000" + "\r\n" + text25 + "Message-ID: <MM" + text10 + "w08@" + text7 + ">" + "\r\n" + "Subject:" + Subject.get_Text() + "\r\n" + "\r\n" + Body.get_Text() + "\r\n" + "." + "\r\n";
									byte[] bytes6 = Encoding.UTF8.GetBytes(s4);
									stream.Write(bytes6, 0, bytes6.Length);
									stream.Read(array8, 0, tcpClient.ReceiveBufferSize);
									Encoding.ASCII.GetString(array8);
									string s5 = "QUIT\r\n";
									byte[] bytes7 = Encoding.UTF8.GetBytes(s5);
									stream.Write(bytes7, 0, bytes7.Length);
									stream.Read(array8, 0, tcpClient.ReceiveBufferSize);
									string string5 = Encoding.ASCII.GetString(array8);
									if (StringType.StrCmp(string5.Substring(0, 3), "250", false) == 0)
									{
										Listlog.get_Items().Add((object)(Mailserver + " " + text18 + ": " + Recipient + ": 250 OK Message Sent" + string5));
										MessagesSent++;
										((Control)Label14).set_Text(StringType.FromInteger(MessagesSent));
										if (!Uselistbox.get_Checked())
										{
											((Control)Status).set_Text("Message Sent");
											ListBox1.get_Items().Clear();
										}
										Error1 = null;
										JJ33 = "Sent";
										num2++;
									}
									else
									{
										Listlog.get_Items().Add((object)string5);
										if (num3 <= 1)
										{
											num3++;
										}
										qou++;
										Accountlist.set_SelectedIndex(qou);
										if (DoubleType.FromString(Error1) < 4.0)
										{
											num2--;
											Error1 = StringType.FromDouble(DoubleType.FromString(Error1) + 1.0);
										}
									}
								}
								else
								{
									Listlog.get_Items().Add((object)"Proxy did not connect to SMTP");
									if (!Uselistbox.get_Checked())
									{
										ListBox1.get_Items().Clear();
									}
									ppou++;
									if (DoubleType.FromString(Error1) < 4.0)
									{
										num2--;
										Error1 = StringType.FromDouble(DoubleType.FromString(Error1) + 1.0);
									}
								}
							}
							else
							{
								if (!MenuItem8.get_Checked())
								{
									Listlog.get_Items().Add((object)"BAD PROXY!!!!");
									num2--;
								}
								else
								{
									Listlog.get_Items().Add((object)"The mx is blocking this proxy");
									if (DoubleType.FromString(Error1) < 4.0)
									{
										num2--;
										Error1 = StringType.FromDouble(DoubleType.FromString(Error1) + 1.0);
									}
								}
								ppou++;
								if (!Uselistbox.get_Checked())
								{
									ListBox1.get_Items().Clear();
								}
							}
						}
						catch (Exception ex13)
						{
							ProjectData.SetProjectError(ex13);
							Exception ex14 = ex13;
							Listlog.get_Items().Add((object)ex14);
							if (num3 <= 1)
							{
								num3++;
							}
							qou++;
							ppou++;
							if (StringType.StrCmp(JJ33, "Sent", false) == 0)
							{
								MessagesSent++;
								((Control)Label14).set_Text(StringType.FromInteger(MessagesSent));
							}
							else if (DoubleType.FromString(Error1) < 4.0)
							{
								num2--;
								Error1 = StringType.FromDouble(DoubleType.FromString(Error1) + 1.0);
							}
							else
							{
								Application.ExitThread();
							}
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						num2 = 1;
						Listlog.get_Items().Add((object)" Stopped");
						Application.ExitThread();
					}
					num2++;
				}
				while (num2 <= 1);
				if (!Uselistbox.get_Checked())
				{
					ListBox1.get_Items().Clear();
				}
			}
			else
			{
				Interaction.MsgBox((object)"Put in the registration code", (MsgBoxStyle)0, (object)null);
			}
			Application.ExitThread();
		}
	}

	public void CheckHttpproxy()
	{
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		string text = Proxy.get_Text();
		Stopchecking.set_Checked(false);
		if (StringType.StrCmp(Sylonious, "Yes", false) == 0)
		{
			smtp.get_Text();
			if (!Stopchecking.get_Checked())
			{
				try
				{
					string[] array = text.ToString().Split(new char[1] { ':' });
					TcpClient tcpClient = new TcpClient();
					tcpClient.Connect(array[0], IntegerType.FromString(array[1]));
					tcpClient.ReceiveTimeout = 1000;
					tcpClient.ReceiveTimeout = 1000;
					byte[] array2 = new byte[checked(tcpClient.ReceiveBufferSize + 1)];
					NetworkStream stream = tcpClient.GetStream();
					Listlog.get_Items().Add((object)"ok");
					Listlog.get_Items().Add((object)"ok");
					Listlog.get_Items().Add((object)"SENDBYTES:255");
					byte[] bytes = Encoding.ASCII.GetBytes("CONNECT mail.atekcomputers.com:25 HTTP/1.0\r\n\r\n");
					stream.Write(bytes, 0, bytes.Length);
					Listlog.get_Items().Add((object)"Before read");
					stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
					string @string = Encoding.ASCII.GetString(array2);
					Listlog.get_Items().Add((object)@string);
					if (StringType.StrCmp(@string.Substring(0, 10), "HTTP/1.0 2", false) == 0)
					{
						bytes = Encoding.ASCII.GetBytes("HELO Test \r\n");
						stream.Write(bytes, 0, bytes.Length);
						stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
						@string = Encoding.ASCII.GetString(array2);
						bytes = Encoding.ASCII.GetBytes("VRFY People\r\n");
						stream.Write(bytes, 0, bytes.Length);
						stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
						@string = Encoding.ASCII.GetString(array2);
						Listlog.get_Items().Add((object)@string);
					}
					else
					{
						Interaction.MsgBox((object)"BAD HTTP Proxy!", (MsgBoxStyle)0, (object)null);
					}
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return;
				}
			}
			Listlog.get_Items().Add((object)" Stopped");
			Application.ExitThread();
		}
		else
		{
			Interaction.MsgBox((object)"Put in the registration code", (MsgBoxStyle)0, (object)null);
		}
	}

	public void Httpproxysend(string Mailserver, string Recipient)
	{
		//IL_138c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			StringType.FromInteger(DateTime.Now.Millisecond * 60);
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\{220F74AC-AB8C-4708-A3C3-EF2C4D98BA5E}\\");
			string text = StringType.FromObject(registryKey.GetValue("nameserver", "202.12.27.33"));
			string serverAddress = text;
			string[] array = Recipient.Split(new char[1] { '@' });
			string host = array[1];
			Stopchecking.set_Checked(false);
			if (StringType.StrCmp(Sylonious, "Yes", false) == 0)
			{
				string text2 = StringType.FromInteger(100 + DateTime.Now.Second);
				string text3 = StringType.FromInteger(44 + DateTime.Now.Second);
				string text4 = StringType.FromInteger(78 + DateTime.Now.Second);
				string text5 = StringType.FromInteger(23 + DateTime.Now.Second);
				string text6 = text2 + "." + text3 + "." + text4 + "." + text5;
				string[] array2 = From.get_Text().ToString().Split(new char[1] { '@' });
				string text7 = array2[1];
				try
				{
					ip = DomainIp(text7);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				if (StringType.StrCmp(ip, (string)null, false) == 0)
				{
					ip = text6;
				}
				string[] array3 = ip.Split(new char[1] { '.' });
				string text8 = array3[0] + "." + array3[1] + "." + array3[2] + ".";
				string text9 = StringType.FromInteger(1 + DateTime.Now.Second);
				string text10 = StringType.FromDouble(DoubleType.FromString(text9) + 6.0);
				string text11 = text8 + text10;
				_ = text9 + text10;
				text7.ToString().Split(new char[1] { '.' });
				string text13;
				try
				{
					Listlog.get_Items().Add((object)ip);
					string text12 = Domainname(ip);
					Listlog.get_Items().Add((object)text12);
					string[] array4 = text12.Split(new char[1] { '.' });
					if ((StringType.StrCmp(text12.Substring(0, 3), "www", false) == 0) | (StringType.StrCmp(text12.Substring(0, 3), "UNK", false) == 0) | (StringType.StrCmp(text12.Substring(0, 1), " ", false) == 0) | (StringType.StrCmp(array4[3], (string)null, false) == 0))
					{
						text13 = "WebClient-" + text9 + "." + text7;
						text11 = ip;
					}
					else
					{
						text13 = text12;
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					text13 = "Addr-" + text10 + "-IPNET-" + text9 + "." + text7;
					text11 = ip;
					ProjectData.ClearProjectError();
				}
				string[] array5 = ((TextBoxBase)smtp).ToString().Split(new char[1] { '.' });
				object obj = array5[1] + "." + array5[2];
				string text14 = DateTime.Today.DayOfWeek.ToString();
				object obj2 = text14.ToString().Substring(0, 3);
				string text15 = DateTime.Today.Day.ToString();
				int num = IntegerType.FromString(DateTime.Today.Month.ToString());
				string text16 = default(string);
				if ((double)num == DoubleType.FromString("1"))
				{
					text16 = "Jan";
				}
				else if ((double)num == DoubleType.FromString("2"))
				{
					text16 = "Feb";
				}
				else if ((double)num == DoubleType.FromString("3"))
				{
					text16 = "Mar";
				}
				else if ((double)num == DoubleType.FromString("4"))
				{
					text16 = "Apr";
				}
				else if ((double)num == DoubleType.FromString("5"))
				{
					text16 = "May";
				}
				else if ((double)num == DoubleType.FromString("6"))
				{
					text16 = "Jun";
				}
				else if ((double)num == DoubleType.FromString("7"))
				{
					text16 = "Jul";
				}
				else if ((double)num == DoubleType.FromString("8"))
				{
					text16 = "Aug";
				}
				else if ((double)num == DoubleType.FromString("9"))
				{
					text16 = "Sep";
				}
				else if ((double)num == DoubleType.FromString("10"))
				{
					text16 = "Oct";
				}
				else if ((double)num == DoubleType.FromString("11"))
				{
					text16 = "Nov";
				}
				else if ((double)num == DoubleType.FromString("12"))
				{
					text16 = "Dec";
				}
				object obj3 = DateTime.Now.Year.ToString();
				object obj4 = StringType.FromInteger(DateTime.Now.Hour) + ":" + StringType.FromInteger(DateTime.Now.Minute) + ":" + StringType.FromInteger(DateTime.Now.Second);
				_ = (object)DateTime.Now.ToUniversalTime();
				string text17 = StringType.FromObject(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(ObjectType.AddObj(obj2, (object)", "), (object)text15), (object)" "), (object)text16), (object)" "), obj3), (object)" "), obj4), (object)" -0500"));
				Accountlist.get_Items().get_Count();
				Proxylist.get_Items().get_Count();
				ListBox1.get_Items().get_Count();
				int num2 = 0;
				num2 = 0;
				string text20 = default(string);
				string text22 = default(string);
				int num3 = default(int);
				do
				{
					if (!accnt.get_Checked())
					{
						smtp.get_Text();
						pop3.get_Text();
						username.get_Text();
						password.get_Text();
						RealEmail.get_Text();
					}
					else
					{
						if (Accountlist.get_Items().get_Count() < qou)
						{
							qou = 0;
						}
						Accountlist.set_SelectedIndex(qou);
						Accountlist.get_SelectedItem().ToString()!.Split(new char[1] { ' ' });
						((Control)Accountlist).Select();
					}
					string text18;
					if (!RandomProxy.get_Checked())
					{
						text18 = Proxy.get_Text();
					}
					else if (ppou > Proxylist2.get_Items().get_Count())
					{
						ppou = 0;
						Proxylist2.set_SelectedIndex(ppou);
						text18 = StringType.FromObject(Proxylist2.get_SelectedItem());
					}
					else
					{
						Proxylist2.set_SelectedIndex(ppou);
						text18 = StringType.FromObject(Proxylist2.get_SelectedItem());
					}
					if (!Stopchecking.get_Checked())
					{
						try
						{
							string[] array6 = text18.ToString().Split(new char[1] { ':' });
							string text19 = array6[0];
							Mailserver = getMXRecords(host, serverAddress);
							Listlog.get_Items().Add((object)Mailserver);
							try
							{
								text19 = getDomain(array6[0]);
								if (StringType.StrCmp(text19, (string)null, false) == 0)
								{
								}
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								text19 = null;
								ProjectData.ClearProjectError();
							}
							try
							{
								if (MenuItem10.get_Checked() & MenuItem8.get_Checked())
								{
									text20 = Mailserver;
								}
								else if ((StringType.StrCmp(text19.ToString().Substring(0, 3), "Unk", false) == 0) | (StringType.StrCmp(text19.ToString(), (string)null, false) == 0) | (StringType.StrCmp(text19.ToString().Substring(0, 3), "WSA", false) == 0))
								{
									text20 = Mailserver;
								}
								else
								{
									string[] array7 = text19.ToString().Split(new char[1] { '.' });
									string text21 = ((StringType.StrCmp(array7[3], (string)null, false) != 0) ? (array7[1] + "." + array7[2] + "." + array7[3]) : (array7[1] + "." + array7[2]));
									Mailserver1 = getMXRecords(text21, serverAddress);
									text20 = ((StringType.StrCmp(Mailserver1, (string)null, false) != 0) ? Mailserver1 : ((StringType.StrCmp(array7[3], (string)null, false) != 0) ? ("mail." + text21) : text19));
								}
							}
							catch (Exception projectError4)
							{
								ProjectData.SetProjectError(projectError4);
								ProjectData.ClearProjectError();
							}
							if (StringType.StrCmp(text20, (string)null, false) == 0)
							{
								text20 = StringType.FromObject(ObjectType.AddObj((object)"relay.", obj));
							}
							TcpClient tcpClient = new TcpClient();
							tcpClient.Connect(array6[0], IntegerType.FromString(array6[1]));
							tcpClient.ReceiveTimeout = 500;
							tcpClient.ReceiveTimeout = 500;
							byte[] array8 = new byte[tcpClient.ReceiveBufferSize + 1];
							NetworkStream stream = tcpClient.GetStream();
							if (StringType.StrCmp(ReplyTo.get_Text().ToString(), (string)null, false) != 0)
							{
								text22 = "Reply-To: " + Fromname.get_Text() + " <" + ReplyTo.get_Text().ToString() + ">" + "\r\n";
							}
							string text23 = ((!MenuItem14.get_Checked()) ? null : string.Concat("Received: from " + text13 + " (" + text13 + " [" + text11 + "])" + " by " + text20, " (8.8.8) with SMTP id MMSGXix4A2D for <", Recipient, ">; ", text17, "\r\n"));
							string text24 = "<" + From.get_Text() + ">";
							string text25 = ((!HTML.get_Checked()) ? "Content-Type: text/plain;\r\n" : "Content-Type: text/html;\r\n");
							if (!MenuItem8.get_Checked())
							{
								_ = "Return-Path: <" + From.get_Text() + ">" + "\r\n";
							}
							text10 = StringType.FromDouble(DoubleType.FromString(text10) + 4.0);
							Listlog.get_Items().Add((object)"ErrorPoint");
							Recipient.Split(new char[1] { '@' });
							text10 = StringType.FromDouble(DoubleType.FromString(text10) + 4.0);
							string text26 = ((StringType.StrCmp(Fromname.get_Text(), (string)null, false) == 0) ? null : "\"");
							Listlog.get_Items().Add((object)"ErrorPoint1");
							tcpClient.Connect(array6[0], IntegerType.FromString(array6[1]));
							tcpClient.ReceiveTimeout = 500;
							tcpClient.ReceiveTimeout = 500;
							Listlog.get_Items().Add((object)"ok");
							byte[] bytes = Encoding.ASCII.GetBytes(string.Concat("HELO " + text20 + "\r\n" + "MAIL FROM: " + text24 + "\r\n" + "RCPT TO:" + "<" + Recipient + ">" + "\r\n" + "DATA" + "\r\n" + text23, "To: <", Recipient, ">", "\r\n", "From:", text26, Fromname.get_Text(), text26, " < ", From.get_Text(), " > ", "\r\n", text22, "Date: ", text17, "\r\n", "X-mailer: Microsoft Outlook Express 6.00.2600.0000", "\r\n", text25, "Message-ID: <MM", text10, "w08@", text7, ">", "\r\n", "Subject:", Subject.get_Text(), "\r\n", "\r\n", Body.get_Text(), "\r\n", ".", "\r\n", "QUIT", "\r\n"));
							Listlog.get_Items().Add((object)("SENDBYTES:" + bytes.Length));
							byte[] bytes2 = Encoding.ASCII.GetBytes(string.Concat("GET http://" + Mailserver + ":25/" + " HTTP/1.0" + "\r\n" + "MAIL FROM: " + text24 + "\r\n" + "RCPT TO:" + "<" + Recipient + ">" + "\r\n" + "DATA" + "\r\n" + text23, "To: <", Recipient, ">", "\r\n", "From:", text26, Fromname.get_Text(), text26, " < ", From.get_Text(), " > ", "\r\n", text22, "Date: ", text17, "\r\n", "X-mailer: Microsoft Outlook Express 6.00.2600.0000", "\r\n", text25, "Message-ID: <MM", text10, "w08@", text7, ">", "\r\n", "Subject:", Subject.get_Text(), "\r\n", "\r\n", Body.get_Text(), "\r\n", ".", "\r\n", "QUIT", "\r\n"));
							stream.Write(bytes2, 0, bytes2.Length);
							Listlog.get_Items().Add((object)"Before read");
							stream.Read(array8, 0, tcpClient.ReceiveBufferSize);
							string @string = Encoding.ASCII.GetString(array8);
							Listlog.get_Items().Add((object)@string);
							if (StringType.StrCmp(@string, (string)null, false) != 0)
							{
								if ((((unchecked((int)(((StringType.StrCmp(@string.Substring(0, 10), "HTTP/1.0 2", false) == 0) ? 1u : 0u) << 31)) >> 31) & ~@string.IndexOf("ERROR")) | @string.IndexOf("250")) != 0)
								{
									Listlog.get_Items().Add((object)(Mailserver + " " + text18 + ": " + Recipient + ": 250 OK Message Sent" + @string));
									MessagesSent++;
									((Control)Label14).set_Text(StringType.FromInteger(MessagesSent));
									if (!Uselistbox.get_Checked())
									{
										((Control)Status).set_Text("Message Sent");
										ListBox1.get_Items().Clear();
									}
									Error1 = null;
									JJ33 = "Sent";
									num2++;
								}
								else
								{
									if (num3 <= 4)
									{
										num3++;
									}
									qou++;
									ppou++;
									Accountlist.set_SelectedIndex(qou);
									if (DoubleType.FromString(Error1) < 4.0)
									{
										num2--;
										Error1 = StringType.FromDouble(DoubleType.FromString(Error1) + 1.0);
									}
								}
							}
							else
							{
								if (!MenuItem8.get_Checked())
								{
									Listlog.get_Items().Add((object)"BAD PROXY!!!!");
									num2--;
								}
								ppou++;
								if (!Uselistbox.get_Checked())
								{
									ListBox1.get_Items().Clear();
								}
							}
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							if (num3 <= 1)
							{
								num3++;
							}
							qou++;
							ppou++;
							if (StringType.StrCmp(JJ33, "Sent", false) == 0)
							{
								MessagesSent++;
								((Control)Label14).set_Text(StringType.FromInteger(MessagesSent));
							}
							else if (DoubleType.FromString(Error1) < 4.0)
							{
								num2--;
								Error1 = StringType.FromDouble(DoubleType.FromString(Error1) + 1.0);
							}
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						num2 = 1;
						Listlog.get_Items().Add((object)" Stopped");
						Application.ExitThread();
					}
					num2++;
				}
				while (num2 <= 1);
				if (!Uselistbox.get_Checked())
				{
					ListBox1.get_Items().Clear();
				}
			}
			else
			{
				Interaction.MsgBox((object)"Put in the registration code", (MsgBoxStyle)0, (object)null);
			}
		}
	}

	private void accnt_Click(object sender, EventArgs e)
	{
		if (!accnt.get_Checked())
		{
			accnt.set_Checked(true);
		}
		else
		{
			accnt.set_Checked(false);
		}
	}

	private void Popfirst_Click(object sender, EventArgs e)
	{
		if (!Popfirst.get_Checked())
		{
			Popfirst.set_Checked(true);
		}
		else
		{
			Popfirst.set_Checked(false);
		}
	}

	private void Send_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(SMTPAUTHSend);
		thread.Start();
	}

	private void Uselistbox_Click(object sender, EventArgs e)
	{
		if (!Uselistbox.get_Checked())
		{
			Uselistbox.set_Checked(true);
		}
		else
		{
			Uselistbox.set_Checked(false);
		}
	}

	private void Save_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)SaveFileDialog1).ShowDialog();
		checked
		{
			try
			{
				int num = 0;
				StreamWriter streamWriter = new StreamWriter(((FileDialog)SaveFileDialog1).get_FileName());
				int count = Proxylist2.get_Items().get_Count();
				for (int i = 1; i <= count; i++)
				{
					Proxylist2.set_SelectedIndex(num);
					streamWriter.WriteLine(Proxylist2.get_SelectedItem().ToString());
					num++;
				}
				streamWriter.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void MenuItem23_Click(object sender, EventArgs e)
	{
		if (!MenuItem23.get_Checked())
		{
			MenuItem23.set_Checked(true);
			accnt.set_Checked(true);
			RandomProxy.set_Checked(true);
			MenuItem19.set_Checked(false);
			MenuItem14.set_Checked(true);
			MenuItem17.set_Checked(false);
		}
		else
		{
			MenuItem20.set_Checked(false);
		}
	}

	private void Popfirst_Click_1(object sender, EventArgs e)
	{
		if (!Popfirst.get_Checked())
		{
			Popfirst.set_Checked(true);
			UsePop = "yes";
		}
		else
		{
			Popfirst.set_Checked(false);
			UsePop = "no";
		}
	}

	private void accnt_Click_1(object sender, EventArgs e)
	{
		if (!accnt.get_Checked())
		{
			accnt.set_Checked(true);
			MenuItem8.set_Checked(false);
			Useaccount = "yes";
		}
		else
		{
			accnt.set_Checked(false);
			Useaccount = "no";
		}
	}

	private void MenuItem24_Click(object sender, EventArgs e)
	{
		((Control)MailingList).Show();
		((Control)SmtpAuth).set_Visible(false);
		((Control)Panel2).set_Visible(false);
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
		((Control)MailingList).Hide();
	}

	private void MenuItem6_Click(object sender, EventArgs e)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		((Control)Status).set_Text("Stopped");
		new Thread(SMTPAUTHSend);
		new Thread(SMTPAUTHSen);
		new Thread(Checkthem);
		new Thread(Checkth);
		Stopchecking.set_Checked(true);
		Interaction.MsgBox((object)"Sending Canceled", (MsgBoxStyle)0, (object)null);
		if (ListBox1.get_Items().get_Count() == 1)
		{
			ListBox1.get_Items().Clear();
		}
	}

	private void Form1_closed(object sender, EventArgs e)
	{
		new Thread(SMTPAUTHSend);
		try
		{
			Interaction.SaveSetting("Quasar", "start up", "RECIPIENT", Recipient.get_Text().ToString());
			Interaction.SaveSetting("Quasar", "start up", "from", From.get_Text().ToString());
			Interaction.SaveSetting("Quasar", "start up", "Subject", Subject.get_Text().ToString());
			Interaction.SaveSetting("Quasar", "start up", "BODY", Body.get_Text().ToString());
			Interaction.SaveSetting("Quasar", "start up", "username", username.get_Text().ToString());
			Interaction.SaveSetting("Quasar", "start up", "password", password.get_Text().ToString());
			Interaction.SaveSetting("Quasar", "start up", "smtp", smtp.get_Text().ToString());
			Interaction.SaveSetting("Quasar", "start up", "pop3", pop3.get_Text().ToString());
			Interaction.SaveSetting("Quasar", "start up", "Proxy", Proxy.get_Text().ToString());
			Interaction.SaveSetting("Quasar", "start up", "RealEmail", RealEmail.get_Text().ToString());
			Interaction.SaveSetting("Quasar", "start up", "Accountlist", Accountlist.get_Items().get_Count().ToString());
			Interaction.SaveSetting("Quasar", "start up", "Reply", ReplyTo.get_Text().ToString());
			Interaction.SaveSetting("Quasar", "start up", "ToName", ToName.get_Text().ToString());
			Interaction.SaveSetting("Quasar", "start up", "Fromname", Fromname.get_Text().ToString());
			Interaction.SaveSetting("Quasar", "start up", "Sylonious", Sylonious.ToString());
			Interaction.SaveSetting("Quasar", "start up", "Useaccount", Useaccount);
			Interaction.SaveSetting("Quasar", "start up", "UsePop", UsePop);
			Interaction.SaveSetting("Quasar", "start up", "Builtin", UseBuiltinSMTP);
			Interaction.SaveSetting("Quasar", "start up", "Pretendbemx", Pretendbemx);
			Interaction.SaveSetting("Quasar", "start up", "Useautoheaders", Useautoheaders);
			Interaction.SaveSetting("Quasar", "start up", "RandomProxies", RandomProxies);
			if (HTML.get_Checked())
			{
				Htmlcheck = "yes";
			}
			else
			{
				Htmlcheck = "no";
			}
			Interaction.SaveSetting("Quasar", "start up", "Htmlcheck", Htmlcheck);
			Stopchecking.set_Checked(true);
			new Thread(Checkthem);
			ListBox1.get_Items().Clear();
			Application.Exit();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Application.Exit();
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		Cursor.set_Current(Cursors.get_WaitCursor());
		Thread thread = new Thread(SMTPAUTHSend);
		thread.Start();
		Cursor.set_Current(Cursors.get_Default());
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(mxprocess);
		thread.Start();
	}

	public void mxprocess()
	{
		ListBox1.get_Items().Add((object)Recipient.get_Text());
		int count = ListBox1.get_Items().get_Count();
		int num = count;
		checked
		{
			for (int i = 1; i <= num; i++)
			{
				ListBox1.set_SelectedIndex(i - 1);
				string[] array = ListBox1.get_SelectedItem().ToString()!.Split(new char[1] { '@' });
				string host = array[1];
				StringType.FromInteger(DateTime.Now.Millisecond * 60);
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\{220F74AC-AB8C-4708-A3C3-EF2C4D98BA5E}\\");
				string text = StringType.FromObject(registryKey.GetValue("nameserver", "202.12.27.33"));
				string serverAddress = text;
				IntegerType.FromString("53");
				Mailserver1 = null;
				while (StringType.StrCmp(Mailserver1, (string)null, false) == 0)
				{
					Mailserver1 = getMXRecords(host, serverAddress);
				}
				TcpClient tcpClient = new TcpClient();
				string[] array2 = Proxy.get_Text().Split(new char[1] { ':' });
				tcpClient.Connect(array2[0], IntegerType.FromString(array2[1]));
				NetworkStream stream = tcpClient.GetStream();
				byte[] bytes = Encoding.ASCII.GetBytes("EHLO Test\r\n");
				byte[] array3 = new byte[tcpClient.ReceiveBufferSize + 1];
				stream.Write(bytes, 0, bytes.Length);
				stream.Read(array3, 0, tcpClient.ReceiveBufferSize);
				string @string = Encoding.ASCII.GetString(array3);
				Console.WriteLine("Host returned2: " + @string);
				((Control)Listlog).Refresh();
				string s = "MAIL FROM:" + From.get_Text() + "\r\n";
				byte[] bytes2 = Encoding.UTF8.GetBytes(s);
				stream.Write(bytes2, 0, bytes2.Length);
				stream.Read(array3, 0, tcpClient.ReceiveBufferSize);
				Encoding.ASCII.GetString(array3);
				string s2 = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj((object)"RCPT TO:", ListBox1.get_SelectedItem()), (object)"\r\n"));
				byte[] bytes3 = Encoding.UTF8.GetBytes(s2);
				stream.Write(bytes3, 0, bytes3.Length);
				stream.Read(array3, 0, tcpClient.ReceiveBufferSize);
				string string2 = Encoding.ASCII.GetString(array3);
				if (StringType.StrCmp(string2.Substring(0, 3), "250", false) == 0)
				{
					Listlog.get_Items().Add((object)"Address Ok");
					continue;
				}
				ListBox1.get_Items().Remove(RuntimeHelpers.GetObjectValue(Listlog.get_SelectedItem()));
				Listlog.get_Items().Add((object)"Address Bad!!!");
			}
		}
	}

	private void Addaccnt_Click(object sender, EventArgs e)
	{
		Accountlist.get_Items().Add((object)(smtp.get_Text() + " " + pop3.get_Text() + " " + username.get_Text() + " " + password.get_Text() + " " + RealEmail.get_Text()));
	}

	private void MenuItem9_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(mxprocess);
		thread.Start();
	}

	private void Delete_Click(object sender, EventArgs e)
	{
		Proxylist2.get_Items().Remove(RuntimeHelpers.GetObjectValue(Proxylist2.get_SelectedItem()));
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		Proxylist2.get_Items().Add((object)Proxy.get_Text());
	}

	private void loopback_Click(object sender, EventArgs e)
	{
		if (!loopback.get_Checked())
		{
			loopback.set_Checked(true);
		}
		else
		{
			loopback.set_Checked(false);
		}
	}

	private void Checkthem()
	{
		try
		{
			int value = TrackBar1.get_Value();
			for (int i = 1; i <= value; i = checked(i + 1))
			{
				Thread thread = new Thread(Checkth);
				thread.Start();
				Application.DoEvents();
				Thread.Sleep(2000);
				Application.DoEvents();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void CheckHttpproxies(string Proxy)
	{
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		Stopchecking.set_Checked(false);
		checked
		{
			if (StringType.StrCmp(Sylonious, "Yes", false) == 0)
			{
				int num = 0;
				int num2 = 1;
				do
				{
					smtp.get_Text();
					if (Stopchecking.get_Checked())
					{
						Application.ExitThread();
					}
					else
					{
						try
						{
							string[] array = Proxy.ToString().Split(new char[1] { ':' });
							TcpClient tcpClient = new TcpClient();
							tcpClient.Connect(array[0], IntegerType.FromString(array[1]));
							tcpClient.ReceiveTimeout = 5000;
							tcpClient.ReceiveTimeout = 5000;
							byte[] array2 = new byte[tcpClient.ReceiveBufferSize + 1];
							NetworkStream stream = tcpClient.GetStream();
							string text = smtp.get_Text();
							if (StringType.StrCmp(text, (string)null, false) == 0)
							{
								text = "Mx3.hotmail.com";
							}
							byte[] bytes = Encoding.ASCII.GetBytes("CONNECT " + Mailserver + ":25" + " HTTP/1.0" + "\r\n\r\n");
							stream.Write(bytes, 0, bytes.Length);
							stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
							string @string = Encoding.ASCII.GetString(array2);
							if (((unchecked((int)(((StringType.StrCmp(@string.Substring(0, 10), "HTTP/1.0 2", false) == 0) ? 1u : 0u) << 31)) >> 31) & ~@string.IndexOf("ERROR")) != 0)
							{
								byte[] bytes2 = Encoding.ASCII.GetBytes("HELO Test\r\n");
								stream.Write(bytes2, 0, bytes2.Length);
								stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
								string string2 = Encoding.ASCII.GetString(array2);
								if (string2.IndexOf("220") != 0)
								{
									Proxylist2.get_Items().Add((object)Proxy);
								}
							}
							else if (num <= 1)
							{
								num2--;
								num++;
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							if (num > 1)
							{
								Application.ExitThread();
							}
							else
							{
								num2--;
								num++;
							}
							ProjectData.ClearProjectError();
						}
					}
					num2++;
				}
				while (num2 <= 1);
			}
			else
			{
				Interaction.MsgBox((object)"Put in the registration code", (MsgBoxStyle)0, (object)null);
			}
			Application.ExitThread();
		}
	}

	private void Checkth()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		Stopchecking.set_Checked(false);
		string text = null;
		while ((Proxylist.get_Items().get_Count() != 0) & (StringType.StrCmp(text, (string)null, false) == 0))
		{
			PerformanceCounter val = new PerformanceCounter();
			val.set_CategoryName("Processor");
			val.set_CounterName("% Processor Time");
			val.set_InstanceName("_Total");
			if (!(DoubleType.FromString(val.NextValue().ToString()) <= 75.0))
			{
				continue;
			}
			Thread.Sleep(2000);
			Application.DoEvents();
			try
			{
				if (!Stopchecking.get_Checked())
				{
					Proxylist.set_SelectedIndex(0);
					Application.DoEvents();
					string proxy = StringType.FromObject(Proxylist.get_SelectedItem());
					Application.DoEvents();
					Proxylist.get_Items().Remove(RuntimeHelpers.GetObjectValue(Proxylist.get_SelectedItem()));
					Application.DoEvents();
					if (Httpproxies.get_Checked())
					{
						CheckHttpproxies(proxy);
					}
					else
					{
						Checkthe(proxy);
					}
					Application.DoEvents();
					Thread.Sleep(2000);
					Application.DoEvents();
				}
				else
				{
					Application.ExitThread();
					text = "stop";
					Application.DoEvents();
					Listlog.get_Items().Add((object)" Stopped Checking");
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Proxylist.set_SelectedIndex(1);
				Application.ExitThread();
				ProjectData.ClearProjectError();
			}
		}
		int count = Proxylist2.get_Items().get_Count();
		for (int i = 0; i <= count; i = checked(i + 1))
		{
			Proxylist2.set_SelectedIndex(i);
			string text2 = StringType.FromObject(Proxylist2.get_SelectedItem());
			int count2 = Proxylist2.get_Items().get_Count();
			for (int j = 0; j <= count2; j = checked(j + 1))
			{
				Proxylist2.set_SelectedIndex(j);
				Application.DoEvents();
				string text3 = StringType.FromObject(Proxylist2.get_SelectedItem());
				if (StringType.StrCmp(text3, text2, false) == 0 && i != j)
				{
					Proxylist2.get_Items().Remove(RuntimeHelpers.GetObjectValue(Proxylist2.get_SelectedItem()));
					Application.DoEvents();
				}
			}
		}
	}

	private void OnConnect(IAsyncResult ar)
	{
		try
		{
			sock.EndConnect(ar);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string Checkthe(string Proxy)
	{
		Stopchecking.set_Checked(false);
		int num = 1;
		checked
		{
			string @string = default(string);
			int num2 = default(int);
			do
			{
				if (Stopchecking.get_Checked())
				{
					Application.ExitThread();
				}
				else
				{
					try
					{
						TcpClient tcpClient = new TcpClient();
						string[] array = Proxy.Split(new char[1] { ':' });
						tcpClient.SendTimeout = 800;
						tcpClient.ReceiveTimeout = 800;
						string text = "OK";
						IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(array[0]), IntegerType.FromString(array[1]));
						Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
						try
						{
							socket.Connect(remoteEP);
							if (((unchecked((int)((socket.Connected ? 1u : 0u) << 31)) >> 31) | socket.Available) != 0)
							{
								socket.Close();
							}
							else
							{
								text = "bad";
								Application.ExitThread();
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							text = "bad";
							Application.ExitThread();
							ProjectData.ClearProjectError();
						}
						if (StringType.StrCmp(text, "bad", false) == 0)
						{
							Application.ExitThread();
						}
						else
						{
							tcpClient.Connect(array[0], IntegerType.FromString(array[1]));
							tcpClient.SendTimeout = 3000;
							tcpClient.ReceiveTimeout = 3000;
							NetworkStream stream = tcpClient.GetStream();
							string text2 = smtp.get_Text().ToString();
							byte[] array2 = new byte[tcpClient.ReceiveBufferSize + 1];
							if (StringType.StrCmp(text2, (string)null, false) == 0)
							{
								text2 = "MX3.HOTMAIL.COM";
							}
							if (!loopback.get_Checked())
							{
								byte[] bytes = Encoding.ASCII.GetBytes("CONNECT " + text2 + ":25 HTTP/1.0" + "\r\n" + "\r\n");
								stream.Write(bytes, 0, bytes.Length);
							}
							else
							{
								byte[] bytes = Encoding.ASCII.GetBytes("CONNECT " + array[0] + ":" + array[1] + " HTTP/1.0" + "\r\n" + "\r\n");
								stream.Write(bytes, 0, bytes.Length);
								stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
								Encoding.ASCII.GetString(array2);
								byte[] bytes2 = Encoding.ASCII.GetBytes("CONNECT " + text2 + ":25 HTTP/1.0" + "\r\n" + "\r\n");
								stream.Write(bytes2, 0, bytes2.Length);
							}
							if (stream.CanRead)
							{
								stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
								@string = Encoding.ASCII.GetString(array2);
							}
							if ((StringType.StrCmp(@string.Substring(0, 12), "HTTP/1.0 200", false) == 0) | (StringType.StrCmp(@string.Substring(0, 12), "HTTP/1.1 200", false) == 0))
							{
								byte[] bytes3 = Encoding.ASCII.GetBytes("EHLO Test\r\n");
								stream.Write(bytes3, 0, bytes3.Length);
								stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
								string string2 = Encoding.ASCII.GetString(array2);
								Console.WriteLine("Host returned2: " + string2);
								if (StringType.StrCmp(string2.Substring(0, 3), "220", false) == 0)
								{
									tcpClient.Close();
									Proxylist2.get_Items().Add((object)Proxy);
									Application.DoEvents();
								}
								else if (num2 > 1)
								{
									num2 = 0;
									Application.ExitThread();
								}
								else
								{
									num2++;
									num--;
								}
							}
							else if (num2 > 3)
							{
								num2 = 0;
								Application.ExitThread();
							}
							else
							{
								num--;
								num2++;
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						if (num2 > 1)
						{
							num2 = 0;
							Application.ExitThread();
						}
						else
						{
							num2++;
							num--;
						}
						ProjectData.ClearProjectError();
					}
				}
				num++;
			}
			while (num <= 1);
			Application.ExitThread();
			string result = default(string);
			return result;
		}
	}

	private void CheckAll_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(Checkthem);
		thread.Start();
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		Proxylist.get_Items().Clear();
		Proxylist2.get_Items().Clear();
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		Accountlist.get_Items().Clear();
	}

	private void RandomProxy_Click(object sender, EventArgs e)
	{
		if (!RandomProxy.get_Checked())
		{
			RandomProxy.set_Checked(true);
			RandomProxies = "yes";
		}
		else
		{
			RandomProxy.set_Checked(false);
			RandomProxies = "no";
		}
	}

	private void CheckProxy_Click(object sender, EventArgs e)
	{
		Thread thread = ((!Httpproxies.get_Checked()) ? new Thread(CheckProx) : new Thread(CheckHttpproxy));
		thread.Start();
	}

	private void Button10_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (StringType.StrCmp(textbox1111.get_Text(), "jav3241fdpt35v91ac", false) == 0)
		{
			Interaction.MsgBox((object)"OK", (MsgBoxStyle)0, (object)null);
			Sylonious = "Yes";
			((Control)Button10).Hide();
			((Control)textbox1111).Hide();
			((Control)Label21).Hide();
		}
		else
		{
			Interaction.MsgBox((object)"Wrong Registeration Code", (MsgBoxStyle)0, (object)null);
		}
	}

	private void OpenProxy_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(OpenPro);
		thread.Start();
	}

	private void Proxylist2_SelectedIndexChanged(object sender, EventArgs e)
	{
		Proxy.set_Text(StringType.FromObject(Proxylist2.get_SelectedItem()));
	}

	private void Button11_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(OpenPro2);
		thread.Start();
	}

	private void MenuItem8_Click_1(object sender, EventArgs e)
	{
		if (!MenuItem8.get_Checked())
		{
			MenuItem8.set_Checked(true);
			accnt.set_Checked(false);
			UseBuiltinSMTP = "yes";
			TrackBar2.set_Maximum(15);
		}
		else
		{
			MenuItem8.set_Checked(false);
			UseBuiltinSMTP = "no";
			TrackBar2.set_Maximum(3);
		}
	}

	private void MenuItem10_Click(object sender, EventArgs e)
	{
		if (!MenuItem10.get_Checked())
		{
			MenuItem10.set_Checked(true);
			Pretendbemx = "yes";
		}
		else
		{
			MenuItem10.set_Checked(false);
			Pretendbemx = "no";
		}
	}

	private void Button12_Click(object sender, EventArgs e)
	{
		((Control)Panel3).Hide();
	}

	private void log_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)Panel3).Show();
	}

	private void Button13_Click(object sender, EventArgs e)
	{
		((Control)Panel4).set_Visible(true);
	}

	private void Button14_Click(object sender, EventArgs e)
	{
		((Control)Panel4).set_Visible(false);
	}

	private void Button5_Click_2(object sender, EventArgs e)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		((Control)Status).set_Text("Stopped");
		new Thread(SMTPAUTHSend);
		new Thread(SMTPAUTHSen);
		new Thread(Checkthem);
		new Thread(Checkth);
		Stopchecking.set_Checked(true);
		Interaction.MsgBox((object)"Sending Canceled", (MsgBoxStyle)0, (object)null);
		if (ListBox1.get_Items().get_Count() == 1)
		{
			ListBox1.get_Items().Clear();
		}
	}

	private void OpenSmtp_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(OpenSmtp2);
		thread.Start();
	}

	private void Httpproxies_Click(object sender, EventArgs e)
	{
		if (Httpproxies.get_Checked())
		{
			Httpproxies.set_Checked(false);
			return;
		}
		Httpproxies.set_Checked(true);
		MenuItem8.set_Checked(true);
		TrackBar2.set_Maximum(4);
	}

	private void Leech()
	{
		WebClient webClient = new WebClient();
		string @string = Encoding.ASCII.GetString(webClient.DownloadData(leechbox.get_Text()));
		Listlog.get_Items().Add((object)ParseHTMLLinks(@string, leechbox.get_Text()));
	}

	private object ProcessURL(string sInput, string sURL)
	{
		sURL += "/";
		sInput = sInput.Replace("<", "'");
		sInput = sInput.Replace(">", "'");
		sInput = sInput.Replace("controlchars.chars", "");
		sInput = sInput.Replace("'", "");
		if (sInput.IndexOf("http://") < 0)
		{
			if (!sInput.StartsWith("/") & !sURL.EndsWith("/"))
			{
				return sURL + "/" + sInput;
			}
			if (sInput.StartsWith("/") & sURL.EndsWith("/"))
			{
				return sURL.Substring(0, checked(sURL.Length - 1)) + sInput;
			}
			return sURL + sInput;
		}
		return sInput;
	}

	public ArrayList ParseHTMLLinks(string sHTMLContent, string sURL)
	{
		ArrayList arrayList = new ArrayList();
		Regex regex = new Regex("a.*href\\s*=\\s*(?:\"(?<1>[^\"]*)\"|(?<1>\\S+))", RegexOptions.IgnoreCase | RegexOptions.Compiled);
		Match match = regex.Match(sHTMLContent);
		while (match.Success)
		{
			string value = StringType.FromObject(ProcessURL(match.Groups[1].ToString(), sURL));
			arrayList.Add(value);
			match = match.NextMatch();
		}
		return arrayList;
	}

	private void Button16_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(Leech);
		thread.Start();
	}

	private void CheckSMTP()
	{
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		num = 1;
		checked
		{
			do
			{
				try
				{
					TcpClient tcpClient = new TcpClient();
					string[] array = Proxy.get_Text().Split(new char[1] { ':' });
					tcpClient.Connect(array[0], IntegerType.FromString(array[1]));
					NetworkStream stream = tcpClient.GetStream();
					tcpClient.ReceiveTimeout = 1000;
					tcpClient.ReceiveTimeout = 1000;
					string text = ProxySMTP.get_Text();
					Listlog.get_Items().Add((object)text);
					byte[] bytes = Encoding.ASCII.GetBytes("CONNECT " + text + ":25 HTTP/1.0" + "\r\n" + "\r\n");
					stream.Write(bytes, 0, bytes.Length);
					byte[] array2 = new byte[tcpClient.ReceiveBufferSize + 1];
					Application.DoEvents();
					stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
					string @string = Encoding.ASCII.GetString(array2);
					if (StringType.StrCmp(@string.Substring(0, 4), "HTTP", false) == 0)
					{
						byte[] bytes2 = Encoding.ASCII.GetBytes("HELO Test\r\n");
						stream.Write(bytes2, 0, bytes2.Length);
						Application.DoEvents();
						stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
						string string2 = Encoding.ASCII.GetString(array2);
						if (StringType.StrCmp(string2.Substring(0, 1), "2", false) == 0)
						{
							Console.WriteLine("Host returned2: " + string2);
							string text2 = "<" + From.get_Text() + ">";
							string s = "MAIL FROM: " + text2 + "\r\n";
							byte[] bytes3 = Encoding.UTF8.GetBytes(s);
							stream.Write(bytes3, 0, bytes3.Length);
							Application.DoEvents();
							stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
							string string3 = Encoding.ASCII.GetString(array2);
							Listlog.get_Items().Add((object)string3);
							if (StringType.StrCmp(string3.Substring(0, 1), "2", false) == 0)
							{
								Thread.Sleep(1000);
								Application.DoEvents();
								string s2 = "RCPT TO:" + "<" + Recipient.get_Text() + ">" + "\r\n";
								byte[] bytes4 = Encoding.UTF8.GetBytes(s2);
								stream.Write(bytes4, 0, bytes4.Length);
								Application.DoEvents();
								stream.Read(array2, 0, tcpClient.ReceiveBufferSize);
								string string4 = Encoding.ASCII.GetString(array2);
								if (StringType.StrCmp(string4.Substring(0, 1), "2", false) == 0)
								{
									try
									{
										FileSystem.FileOpen(1, "SMTP.INI", (OpenMode)8, (OpenAccess)(-1), (OpenShare)(-1), -1);
										FileSystem.WriteLine(1, new object[2]
										{
											array[0].ToString(),
											ProxySMTP.get_Text()
										});
										FileSystem.FileClose(new int[0]);
									}
									catch (Exception projectError)
									{
										ProjectData.SetProjectError(projectError);
										ProjectData.ClearProjectError();
									}
									Interaction.MsgBox((object)"SMTP relays mail for the proxy", (MsgBoxStyle)0, (object)null);
								}
								else
								{
									Interaction.MsgBox((object)"SMTP does not relay mail for the proxy", (MsgBoxStyle)0, (object)null);
								}
							}
							else
							{
								Interaction.MsgBox((object)"SMTP does not relay mailf for the E-mail address", (MsgBoxStyle)0, (object)null);
							}
						}
						else
						{
							Interaction.MsgBox((object)"Did not connect to SMTP", (MsgBoxStyle)0, (object)null);
						}
					}
					else
					{
						Interaction.MsgBox((object)"Did not connect to proxy", (MsgBoxStyle)0, (object)null);
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					Interaction.MsgBox((object)"Error", (MsgBoxStyle)0, (object)null);
					ProjectData.ClearProjectError();
				}
				num++;
			}
			while (num <= 1);
		}
	}

	private void Button20_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(CheckSMTP);
		thread.Start();
	}
}
