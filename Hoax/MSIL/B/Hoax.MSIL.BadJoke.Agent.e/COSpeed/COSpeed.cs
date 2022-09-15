using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace COSpeed;

public class COSpeed : Form
{
	public const uint PROCESS_VM_READ = 16u;

	public const uint PROCESS_VM_WRITE = 32u;

	public const uint PROCESS_VM_OPERATION = 8u;

	public const uint PROCESS_QUERY_INFORMATION = 1024u;

	public const uint PROCESS_ALL_ACCESS = 56u;

	private IContainer components;

	private CheckBox checkBoxLigar;

	private Timer timer1;

	private Label label1;

	private ListBox chars;

	private Button refreshButton;

	private Process[] ReadProcess = Process.GetProcessesByName("Conquer");

	private IntPtr m_hProcess;

	private int x;

	private byte[] buffer = new byte[4];

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		components = new Container();
		checkBoxLigar = new CheckBox();
		timer1 = new Timer(components);
		label1 = new Label();
		chars = new ListBox();
		refreshButton = new Button();
		((Control)this).SuspendLayout();
		((Control)checkBoxLigar).set_AutoSize(true);
		((Control)checkBoxLigar).set_Location(new Point(2, 3));
		((Control)checkBoxLigar).set_Name("checkBoxLigar");
		((Control)checkBoxLigar).set_Size(new Size(101, 17));
		((Control)checkBoxLigar).set_TabIndex(0);
		((Control)checkBoxLigar).set_Text("COSpeed (OFF)");
		((ButtonBase)checkBoxLigar).set_UseVisualStyleBackColor(true);
		checkBoxLigar.add_CheckedChanged((EventHandler)checkBoxLigar_CheckedChanged);
		timer1.set_Interval(200);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(83, 158));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(43, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("By Fujiy");
		((ListControl)chars).set_FormattingEnabled(true);
		((Control)chars).set_Location(new Point(2, 26));
		((Control)chars).set_Name("chars");
		chars.set_SelectionMode((SelectionMode)3);
		((Control)chars).set_Size(new Size(127, 121));
		((Control)chars).set_TabIndex(2);
		((Control)refreshButton).set_Location(new Point(2, 153));
		((Control)refreshButton).set_Name("refreshButton");
		((Control)refreshButton).set_Size(new Size(75, 23));
		((Control)refreshButton).set_TabIndex(3);
		((Control)refreshButton).set_Text("Refresh");
		((ButtonBase)refreshButton).set_UseVisualStyleBackColor(true);
		((Control)refreshButton).add_Click((EventHandler)refreshButton_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(131, 177));
		((Control)this).get_Controls().Add((Control)(object)refreshButton);
		((Control)this).get_Controls().Add((Control)(object)chars);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)checkBoxLigar);
		((Control)this).set_Name("COSpeed");
		((Control)this).set_Text("COSpeed");
		((Form)this).add_Load((EventHandler)refreshButton_Click);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public COSpeed()
	{
		InitializeComponent();
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[DllImport("kernel32.dll")]
	public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWrite);

	[DllImport("kernel32.dll")]
	public static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesRead);

	public byte[] ReadProcessMemoryLite(IntPtr MemoryAddress, uint bytesToRead, out int bytesReaded)
	{
		byte[] result = new byte[bytesToRead];
		ReadProcessMemory(m_hProcess, MemoryAddress, result, bytesToRead, out var lpNumberOfBytesRead);
		bytesReaded = lpNumberOfBytesRead.ToInt32();
		return result;
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		ReadProcess = Process.GetProcessesByName("Conquer");
		if (ReadProcess.Length > 0)
		{
			x %= ReadProcess.Length;
			m_hProcess = OpenProcess(56u, 1, (uint)ReadProcess[x].Id);
			if (chars.GetSelected(x))
			{
				buffer[0] = 128;
			}
			else
			{
				buffer[0] = 0;
			}
			WriteProcessMemory(m_hProcess, (IntPtr)5316710, buffer, 4u, out var _);
			x++;
		}
	}

	private void checkBoxLigar_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBoxLigar.get_Checked())
		{
			timer1.set_Enabled(true);
			((Control)checkBoxLigar).set_Text("COSpeed (ON)");
			buffer[0] = 128;
			return;
		}
		timer1.set_Enabled(false);
		ReadProcess = Process.GetProcessesByName("Conquer");
		for (int i = 0; i < ReadProcess.Length; i++)
		{
			m_hProcess = OpenProcess(56u, 1, (uint)ReadProcess[i].Id);
			byte[] array = new byte[4];
			((Control)checkBoxLigar).set_Text("COSpeed (OFF)");
			array[0] = 0;
			WriteProcessMemory(m_hProcess, (IntPtr)5316710, array, 4u, out var _);
		}
	}

	private void refreshButton_Click(object sender, EventArgs e)
	{
		ReadProcess = Process.GetProcessesByName("Conquer");
		chars.get_Items().Clear();
		for (int i = 0; i < ReadProcess.Length; i++)
		{
			m_hProcess = OpenProcess(56u, 1, (uint)ReadProcess[i].Id);
			int[] array = new int[15];
			string[] array2 = new string[15];
			string[] array3 = new string[15];
			int bytesReaded;
			byte[] array4 = ReadProcessMemoryLite((IntPtr)5326708, 15u, out bytesReaded);
			array[0] = array4[0];
			array[1] = array4[1];
			array[2] = array4[2];
			array[3] = array4[3];
			array[4] = array4[4];
			array[5] = array4[5];
			array[6] = array4[6];
			array[7] = array4[7];
			array[8] = array4[8];
			array[9] = array4[9];
			array[10] = array4[10];
			array[11] = array4[11];
			array[12] = array4[12];
			array[13] = array4[13];
			array[14] = array4[14];
			array2[0] = Convert.ToString(array[0]);
			array2[1] = Convert.ToString(array[1]);
			array2[2] = Convert.ToString(array[2]);
			array2[3] = Convert.ToString(array[3]);
			array2[4] = Convert.ToString(array[4]);
			array2[5] = Convert.ToString(array[5]);
			array2[6] = Convert.ToString(array[6]);
			array2[7] = Convert.ToString(array[7]);
			array2[8] = Convert.ToString(array[8]);
			array2[9] = Convert.ToString(array[9]);
			array2[10] = Convert.ToString(array[10]);
			array2[11] = Convert.ToString(array[11]);
			array2[12] = Convert.ToString(array[12]);
			array2[13] = Convert.ToString(array[13]);
			array2[14] = Convert.ToString(array[14]);
			for (int j = 0; j < 15; j++)
			{
				switch (array2[j])
				{
				case "95":
					array3[j] = "_";
					break;
				case "48":
					array3[j] = "0";
					break;
				case "49":
					array3[j] = "1";
					break;
				case "50":
					array3[j] = "2";
					break;
				case "51":
					array3[j] = "3";
					break;
				case "52":
					array3[j] = "4";
					break;
				case "53":
					array3[j] = "5";
					break;
				case "54":
					array3[j] = "6";
					break;
				case "55":
					array3[j] = "7";
					break;
				case "56":
					array3[j] = "8";
					break;
				case "57":
					array3[j] = "9";
					break;
				case "65":
					array3[j] = "A";
					break;
				case "66":
					array3[j] = "B";
					break;
				case "67":
					array3[j] = "C";
					break;
				case "68":
					array3[j] = "D";
					break;
				case "69":
					array3[j] = "E";
					break;
				case "70":
					array3[j] = "F";
					break;
				case "71":
					array3[j] = "G";
					break;
				case "72":
					array3[j] = "H";
					break;
				case "73":
					array3[j] = "I";
					break;
				case "74":
					array3[j] = "J";
					break;
				case "75":
					array3[j] = "K";
					break;
				case "76":
					array3[j] = "L";
					break;
				case "77":
					array3[j] = "M";
					break;
				case "78":
					array3[j] = "N";
					break;
				case "79":
					array3[j] = "O";
					break;
				case "80":
					array3[j] = "P";
					break;
				case "81":
					array3[j] = "Q";
					break;
				case "82":
					array3[j] = "R";
					break;
				case "83":
					array3[j] = "S";
					break;
				case "84":
					array3[j] = "T";
					break;
				case "85":
					array3[j] = "U";
					break;
				case "86":
					array3[j] = "V";
					break;
				case "87":
					array3[j] = "W";
					break;
				case "88":
					array3[j] = "X";
					break;
				case "89":
					array3[j] = "Y";
					break;
				case "90":
					array3[j] = "Z";
					break;
				case "97":
					array3[j] = "a";
					break;
				case "98":
					array3[j] = "b";
					break;
				case "99":
					array3[j] = "c";
					break;
				case "100":
					array3[j] = "d";
					break;
				case "101":
					array3[j] = "e";
					break;
				case "102":
					array3[j] = "f";
					break;
				case "103":
					array3[j] = "g";
					break;
				case "104":
					array3[j] = "h";
					break;
				case "105":
					array3[j] = "i";
					break;
				case "106":
					array3[j] = "j";
					break;
				case "107":
					array3[j] = "k";
					break;
				case "108":
					array3[j] = "l";
					break;
				case "109":
					array3[j] = "m";
					break;
				case "110":
					array3[j] = "n";
					break;
				case "111":
					array3[j] = "o";
					break;
				case "112":
					array3[j] = "p";
					break;
				case "113":
					array3[j] = "q";
					break;
				case "114":
					array3[j] = "r";
					break;
				case "115":
					array3[j] = "s";
					break;
				case "116":
					array3[j] = "t";
					break;
				case "117":
					array3[j] = "u";
					break;
				case "118":
					array3[j] = "v";
					break;
				case "119":
					array3[j] = "w";
					break;
				case "120":
					array3[j] = "x";
					break;
				case "121":
					array3[j] = "y";
					break;
				case "122":
					array3[j] = "z";
					break;
				default:
					array3[j] = "";
					break;
				}
			}
			chars.get_Items().Add((object)(array3[0] + array3[1] + array3[2] + array3[3] + array3[4] + array3[5] + array3[6] + array3[7] + array3[8] + array3[9] + array3[10] + array3[11] + array3[12] + array3[13] + array3[14]));
		}
	}
}
