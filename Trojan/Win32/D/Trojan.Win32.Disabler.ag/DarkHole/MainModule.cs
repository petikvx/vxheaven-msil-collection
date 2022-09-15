using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace DarkHole;

[StandardModule]
internal sealed class MainModule
{
	public static ADarkHole DarkHole;

	[DllImport("gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int CreateEllipticRgn(int X1, int Y1, int X2, int Y2);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetWindowRgn(int hWnd, int hRgn, bool bRedraw);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int RegisterServiceProcess(int dwProcessID, int dwType);

	public static void ProgressiveDarkHole()
	{
		checked
		{
			while (DarkHole.Elipse.Top > 0)
			{
				ADarkHole darkHole = DarkHole;
				darkHole.Elipse.Top = darkHole.Elipse.Top - 1;
				darkHole = DarkHole;
				darkHole.Elipse.Left = darkHole.Elipse.Left - 1;
				darkHole = DarkHole;
				darkHole.Elipse.Height = darkHole.Elipse.Height + 1;
				darkHole = DarkHole;
				darkHole.Elipse.Width = darkHole.Elipse.Width + 1;
				DarkHole.DoDarkHole();
				Thread.Sleep(300);
			}
			SetWindowRgn(((Control)DarkHole.frmHole).get_Handle().ToInt32(), 0, bRedraw: true);
		}
	}
}
