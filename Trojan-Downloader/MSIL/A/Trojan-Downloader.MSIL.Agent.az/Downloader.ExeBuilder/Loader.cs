using System;
using System.Windows.Forms;
using Downloader.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Downloader.ExeBuilder;

public class Loader
{
	private const string DATA_START = "[EOF]";

	private const string SPLIT_STRING = "[@#@]";

	private string mydir;

	public string[] Settings;

	public Loader()
	{
		mydir = Application.get_ExecutablePath();
		Settings = new string[1001];
	}

	public void LoadSettings()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string[] array = default(string[]);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 113:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
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
							goto IL_0022;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0022:
					num = 3;
					array = Strings.Split(text, "[EOF]", -1, (CompareMethod)0);
					break;
					IL_0009:
					num = 2;
					text = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(mydir);
					goto IL_0022;
					end_IL_0001_2:
					break;
				}
				num = 4;
				Settings = Strings.Split(array[1], "[@#@]", -1, (CompareMethod)0);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 113;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
