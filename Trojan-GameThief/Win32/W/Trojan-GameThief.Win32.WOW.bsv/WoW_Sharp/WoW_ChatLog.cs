using System.IO;
using System.Text;

namespace WoW_Sharp;

public class WoW_ChatLog
{
	private WoW woW_0;

	private string string_0;

	private long long_0;

	internal WoW_ChatLog(WoW woW_1)
	{
		woW_0 = woW_1;
		Reset();
	}

	public void Reset()
	{
		string_0 = woW_0.ChatlogPath;
		long_0 = 0L;
		if (string_0 != "" && File.Exists(string_0))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			long_0 = fileStream.Length;
			fileStream.Close();
		}
	}

	public WoW_ChatLogLine ReadLine()
	{
		if (!(string_0 == "") && File.Exists(string_0))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			try
			{
				if (long_0 > fileStream.Length)
				{
					Reset();
				}
				if (long_0 == fileStream.Length)
				{
					return null;
				}
				fileStream.Seek(long_0, SeekOrigin.Begin);
				StreamReader streamReader = new StreamReader(fileStream);
				WoW_ChatLogLine woW_ChatLogLine = new WoW_ChatLogLine(streamReader.ReadLine());
				long_0 += Encoding.UTF8.GetByteCount(woW_ChatLogLine.RawLine) + 2;
				return woW_ChatLogLine;
			}
			finally
			{
				fileStream.Close();
			}
		}
		return null;
	}
}
