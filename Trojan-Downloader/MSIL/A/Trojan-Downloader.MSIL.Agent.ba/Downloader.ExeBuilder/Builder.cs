using System;
using System.Windows.Forms;
using Downloader.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Downloader.ExeBuilder;

public class Builder
{
	private const string DATA_START = "[EOF]";

	private const string DATA_ARRAY = "[@#@]";

	private byte[] SERVER_RESOURCE;

	private SaveFileDialog FSD;

	public byte[] Exe;

	public string[] Settings;

	public Builder()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		FSD = new SaveFileDialog();
		Settings = new string[1001];
	}

	public string BuildServer()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		try
		{
			((FileDialog)FSD).set_Title("Server Builder");
			((FileDialog)FSD).set_Filter("Exe File [*.exe] | *.exe");
			if (((0u - (((int)((CommonDialog)FSD).ShowDialog() == 1) ? 1u : 0u)) | 6u) != 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(((FileDialog)FSD).get_FileName()))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(((FileDialog)FSD).get_FileName());
				}
				SERVER_RESOURCE = Exe;
				FileSystem.FileOpen(1, ((FileDialog)FSD).get_FileName(), (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.FilePut(1, (Array)SERVER_RESOURCE, -1L, false, false);
				FileSystem.FilePut(1, "[EOF]", -1L, false);
				string[] settings = Settings;
				foreach (string text in settings)
				{
					if (Operators.CompareString(text, "", false) != 0)
					{
						FileSystem.FilePut(1, text + "[@#@]", -1L, false);
					}
				}
				FileSystem.FileClose(new int[1] { 1 });
				return "OK";
			}
			return "die";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string result = ex2.Message.ToString();
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
