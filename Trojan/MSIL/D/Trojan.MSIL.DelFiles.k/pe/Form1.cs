using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace pe;

public class Form1 : Form
{
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private IContainer components;

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
				_Timer1.remove_Tick((EventHandler)Timer1_Tick);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick((EventHandler)Timer1_Tick);
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		Timer1 = new Timer(components);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(300);
		Size autoScaleBaseSize = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(autoScaleBaseSize);
		autoScaleBaseSize = new Size(472, 384);
		((Form)this).set_ClientSize(autoScaleBaseSize);
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	public object Pause(long Value)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num4 = default(int);
		DateTime t = default(DateTime);
		Exception ex = default(Exception);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0009;
				case 57:
					{
						int num2 = num + 1;
						num = 0;
						switch (num2)
						{
						case 0:
							break;
						case 1:
							goto IL_0009;
						case 3:
							goto IL_001e;
						case 2:
							goto IL_002e;
						case 4:
							goto end_IL_0001;
						default:
							goto IL_009c;
						}
						goto default;
					}
					IL_0009:
					num4 = 1;
					t = DateAndTime.get_Now().AddMilliseconds(Value);
					goto IL_002e;
					IL_002e:
					num4 = 2;
					Application.DoEvents();
					goto IL_001e;
					IL_001e:
					num4 = 3;
					if (DateTime.Compare(DateAndTime.get_Now(), t) > 0)
					{
						break;
					}
					goto IL_002e;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when ((obj is Exception && num3 != 0 && num == 0) ? true : false)
			{
				Exception obj2 = (Exception)obj;
				ProjectData.SetProjectError(obj2);
				ex = obj2;
				if (num != 0)
				{
					goto IL_009c;
				}
				num = num4;
				switch (num3)
				{
				case 1:
					try0001_dispatch = 57;
					break;
				default:
					throw;
				}
				continue;
			}
			break;
			IL_009c:
			throw ex;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		SendKeys.Send("^(v)");
		Pause(100L);
		SendKeys.Send("{enter}");
		Application.Exit();
	}
}
