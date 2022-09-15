using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class173
{
	public struct tagHH_FTS_QUERY
	{
		private long long_0;

		private long long_1;

		private string string_0;

		private long long_2;

		private long long_3;

		private long long_4;

		private long long_5;

		private string string_1;
	}

	private const int int_0 = 0;

	private const int int_1 = 1;

	private const int int_2 = 2;

	private const int int_3 = 3;

	private const int int_4 = 15;

	public const int int_5 = 16;

	private Control control_0;

	private string string_0 = "";

	private IntPtr intptr_0 = IntPtr.Zero;

	public Control Control_0
	{
		get
		{
			return control_0;
		}
		set
		{
			control_0 = value;
		}
	}

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public Class173()
	{
	}

	public Class173(Control parent, string helpfile)
	{
		control_0 = parent;
		string_0 = helpfile;
	}

	[DllImport("hhctrl.ocx", CharSet = CharSet.Ansi, SetLastError = true)]
	private static extern IntPtr HtmlHelpA(IntPtr hwnd, string lpHelpFile, int wCommand, int dwData);

	[DllImport("hhctrl.ocx", CharSet = CharSet.Auto, EntryPoint = "HtmlHelp", SetLastError = true)]
	private static extern IntPtr HtmlHelp_1(IntPtr hwnd, string lpHelpFile, int wCommand, ref tagHH_FTS_QUERY dwData);

	[DllImport("user32")]
	private static extern bool PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	[DllImport("user32")]
	private static extern bool IsWindow(IntPtr hWnd);

	public void method_0()
	{
		if (!File.Exists(string_0))
		{
			throw new InvalidOperationException("Help file could not be found.");
		}
		intptr_0 = HtmlHelpA(control_0.get_Handle(), string_0, 1, 0);
	}

	public void method_1()
	{
		if (!File.Exists(string_0))
		{
			throw new InvalidOperationException("Help file could not be found.");
		}
		intptr_0 = HtmlHelpA(control_0.get_Handle(), string_0, 2, 0);
	}

	public void method_2()
	{
		if (!File.Exists(string_0))
		{
			throw new InvalidOperationException("Help file could not be found.");
		}
		intptr_0 = HtmlHelpA(control_0.get_Handle(), string_0, 3, 0);
	}

	public void method_3()
	{
		if (intptr_0 != IntPtr.Zero && IsWindow(intptr_0))
		{
			PostMessage(intptr_0, 16, 0, 0);
		}
		intptr_0 = IntPtr.Zero;
	}
}
