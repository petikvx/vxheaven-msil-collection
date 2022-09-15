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

	private Hotkey hk = new Hotkey();

	private IntPtr mem_Zoom = (IntPtr)5683420;

	private IntPtr Nome = (IntPtr)5689652;

	private IntPtr Efeito = (IntPtr)5689534;

	private IntPtr PtrTextoJanela = (IntPtr)5684324;

	private IntPtr PtrNonDC1 = (IntPtr)5390393;

	private IntPtr PtrNonDC2 = (IntPtr)4871814;

	private byte[] PreLigarNonDC = new byte[20]
	{
		129, 5, 25, 254, 86, 0, 106, 4, 0, 0,
		161, 25, 254, 86, 0, 233, 62, 22, 248, 255
	};

	private byte[] LigarNonDC = new byte[5] { 233, 174, 233, 7, 0 };

	private byte[] DesligarNonDC = new byte[5] { 232, 98, 91, 4, 0 };

	private Process[] ReadProcess = Process.GetProcessesByName("Conquer");

	private IntPtr m_hProcess;

	private int x;

	private byte[] buffer = new byte[4];

	private IContainer components;

	private CheckBox checkBoxLigar;

	private Timer timer1;

	private ListBox chars;

	private Button refreshButton;

	private CheckBox selecionartodos;

	private Label lblZoom;

	private TrackBar trackBar1;

	private Button btnResetZoom;

	private ListBox tabelaAtualizada;

	private Label lblZoomNum;

	private LinkLabel lnkBlog;

	private CheckBox chkBoxHotKey;

	public COSpeed()
	{
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		teste();
		hk.KeyCode = (Keys)115;
		hk.Windows = false;
		hk.Pressed += HotKeyPressed;
		if (!hk.GetCanRegister((Control)(object)this))
		{
			MessageBox.Show("Can\u00b4t Register Hotkey!");
		}
		else
		{
			hk.Register((Control)(object)this);
		}
	}

	private void HotKeyPressed(object sender, HandledEventArgs e)
	{
		if (chkBoxHotKey.get_Checked())
		{
			checkBoxLigar.set_Checked(!checkBoxLigar.get_Checked());
			AtivaDesativa();
		}
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
		if (ReadProcess.Length <= 0)
		{
			return;
		}
		tabelaAtualizada.get_Items().Clear();
		for (int i = 0; i < ReadProcess.Length; i++)
		{
			m_hProcess = OpenProcess(56u, 1, (uint)ReadProcess[i].Id);
			tabelaAtualizada.get_Items().Add((object)LerNome_m_hProcess());
		}
		bool flag = true;
		if (tabelaAtualizada.get_Items().get_Count() != chars.get_Items().get_Count())
		{
			flag = false;
		}
		else
		{
			for (int j = 0; j < tabelaAtualizada.get_Items().get_Count(); j++)
			{
				if (tabelaAtualizada.get_Items().get_Item(j).ToString() != chars.get_Items().get_Item(j).ToString() && tabelaAtualizada.get_Items().get_Item(j).ToString() != "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0")
				{
					tabelaAtualizada.get_Items().get_Item(j).ToString();
					chars.get_Items().get_Item(j).ToString();
					flag = false;
				}
			}
		}
		if (!flag)
		{
			refreshButton.PerformClick();
		}
		x = (x + 1) % chars.get_Items().get_Count();
		if ((chars.GetSelected(x) || selecionartodos.get_Checked()) && tabelaAtualizada.get_Items().get_Item(x).ToString() != "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0" && chars.get_Items().get_Item(x).ToString() != "")
		{
			m_hProcess = OpenProcess(56u, 1, (uint)ReadProcess[x].Id);
			buffer[0] = 128;
			WriteProcessMemory(m_hProcess, Efeito, buffer, 4u, out var _);
		}
	}

	private void AtivaDesativa()
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
		((Control)checkBoxLigar).set_Text("COSpeed (OFF)");
		for (int i = 0; i < ReadProcess.Length; i++)
		{
			m_hProcess = OpenProcess(56u, 1, (uint)ReadProcess[i].Id);
			WriteProcessMemory(buffer: new byte[4] { 0, 0, 0, 0 }, hProcess: m_hProcess, lpBaseAddress: Efeito, size: 4u, lpNumberOfBytesWrite: out var _);
		}
	}

	private void checkBoxLigar_CheckedChanged(object sender, EventArgs e)
	{
		AtivaDesativa();
	}

	private void refreshButton_Click(object sender, EventArgs e)
	{
		ReadProcess = Process.GetProcessesByName("Conquer");
		chars.get_Items().Clear();
		for (int i = 0; i < ReadProcess.Length; i++)
		{
			m_hProcess = OpenProcess(56u, 1, (uint)ReadProcess[i].Id);
			chars.get_Items().Add((object)LerNome_m_hProcess());
		}
	}

	private string LerNome_m_hProcess()
	{
		int bytesReaded;
		byte[] array = ReadProcessMemoryLite(Nome, 15u, out bytesReaded);
		string text = Convert.ToChar(array[0]).ToString();
		text += Convert.ToChar(array[1]);
		text += Convert.ToChar(array[2]);
		text += Convert.ToChar(array[3]);
		text += Convert.ToChar(array[4]);
		text += Convert.ToChar(array[5]);
		text += Convert.ToChar(array[6]);
		text += Convert.ToChar(array[7]);
		text += Convert.ToChar(array[8]);
		text += Convert.ToChar(array[9]);
		text += Convert.ToChar(array[10]);
		text += Convert.ToChar(array[11]);
		text += Convert.ToChar(array[12]);
		text += Convert.ToChar(array[13]);
		return text + Convert.ToChar(array[14]);
	}

	private void trackBar1_Scroll(object sender, EventArgs e)
	{
		if (((ListControl)chars).get_SelectedIndex() >= 0)
		{
			m_hProcess = OpenProcess(56u, 1, (uint)ReadProcess[((ListControl)chars).get_SelectedIndex()].Id);
			buffer[0] = Convert.ToByte(trackBar1.get_Value() % 256);
			if (trackBar1.get_Value() >= 256)
			{
				buffer[1] = Convert.ToByte(trackBar1.get_Value() / 256);
			}
			else
			{
				buffer[1] = 0;
			}
			WriteProcessMemory(m_hProcess, mem_Zoom, buffer, 4u, out var _);
		}
		((Control)lblZoomNum).set_Text(trackBar1.get_Value().ToString());
	}

	private void btnResetZoom_Click(object sender, EventArgs e)
	{
		trackBar1.set_Value(256);
		trackBar1_Scroll(new object(), new EventArgs());
	}

	private void lnkBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://fujiy.blogspot.com/");
	}

	public void teste()
	{
	}

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
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected O, but got Unknown
		components = new Container();
		checkBoxLigar = new CheckBox();
		timer1 = new Timer(components);
		chars = new ListBox();
		refreshButton = new Button();
		selecionartodos = new CheckBox();
		lblZoom = new Label();
		trackBar1 = new TrackBar();
		btnResetZoom = new Button();
		tabelaAtualizada = new ListBox();
		lblZoomNum = new Label();
		lnkBlog = new LinkLabel();
		chkBoxHotKey = new CheckBox();
		((ISupportInitialize)trackBar1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)checkBoxLigar).set_AutoSize(true);
		((Control)checkBoxLigar).set_Location(new Point(1, 4));
		((Control)checkBoxLigar).set_Name("checkBoxLigar");
		((Control)checkBoxLigar).set_Size(new Size(101, 17));
		((Control)checkBoxLigar).set_TabIndex(0);
		((Control)checkBoxLigar).set_Text("COSpeed (OFF)");
		((ButtonBase)checkBoxLigar).set_UseVisualStyleBackColor(true);
		checkBoxLigar.add_CheckedChanged((EventHandler)checkBoxLigar_CheckedChanged);
		timer1.set_Interval(200);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ListControl)chars).set_FormattingEnabled(true);
		((Control)chars).set_Location(new Point(1, 41));
		((Control)chars).set_Name("chars");
		chars.set_SelectionMode((SelectionMode)3);
		((Control)chars).set_Size(new Size(127, 95));
		((Control)chars).set_TabIndex(2);
		((Control)refreshButton).set_Location(new Point(57, 138));
		((Control)refreshButton).set_Name("refreshButton");
		((Control)refreshButton).set_Size(new Size(75, 23));
		((Control)refreshButton).set_TabIndex(3);
		((Control)refreshButton).set_Text("Refresh");
		((ButtonBase)refreshButton).set_UseVisualStyleBackColor(true);
		((Control)refreshButton).add_Click((EventHandler)refreshButton_Click);
		((Control)selecionartodos).set_AutoSize(true);
		selecionartodos.set_Checked(true);
		selecionartodos.set_CheckState((CheckState)1);
		((Control)selecionartodos).set_Location(new Point(1, 142));
		((Control)selecionartodos).set_Name("selecionartodos");
		((Control)selecionartodos).set_Size(new Size(37, 17));
		((Control)selecionartodos).set_TabIndex(4);
		((Control)selecionartodos).set_Text("All");
		((ButtonBase)selecionartodos).set_UseVisualStyleBackColor(true);
		((Control)lblZoom).set_AutoSize(true);
		((Control)lblZoom).set_Location(new Point(1, 172));
		((Control)lblZoom).set_Name("lblZoom");
		((Control)lblZoom).set_Size(new Size(37, 13));
		((Control)lblZoom).set_TabIndex(6);
		((Control)lblZoom).set_Text("Zoom:");
		((Control)trackBar1).set_AutoSize(false);
		((Control)trackBar1).set_Location(new Point(53, 175));
		trackBar1.set_Maximum(256);
		trackBar1.set_Minimum(100);
		((Control)trackBar1).set_Name("trackBar1");
		((Control)trackBar1).set_RightToLeft((RightToLeft)1);
		((Control)trackBar1).set_Size(new Size(81, 13));
		trackBar1.set_SmallChange(5);
		((Control)trackBar1).set_TabIndex(7);
		trackBar1.set_TickStyle((TickStyle)0);
		trackBar1.set_Value(256);
		trackBar1.add_Scroll((EventHandler)trackBar1_Scroll);
		((Control)btnResetZoom).set_Location(new Point(1, 191));
		((Control)btnResetZoom).set_Name("btnResetZoom");
		((Control)btnResetZoom).set_Size(new Size(75, 23));
		((Control)btnResetZoom).set_TabIndex(8);
		((Control)btnResetZoom).set_Text("Reset Zoom");
		((ButtonBase)btnResetZoom).set_UseVisualStyleBackColor(true);
		((Control)btnResetZoom).add_Click((EventHandler)btnResetZoom_Click);
		((ListControl)tabelaAtualizada).set_FormattingEnabled(true);
		((Control)tabelaAtualizada).set_Location(new Point(89, 27));
		((Control)tabelaAtualizada).set_Name("tabelaAtualizada");
		((Control)tabelaAtualizada).set_Size(new Size(45, 30));
		((Control)tabelaAtualizada).set_TabIndex(9);
		((Control)tabelaAtualizada).set_Visible(false);
		((Control)lblZoomNum).set_AutoSize(true);
		((Control)lblZoomNum).set_Font(new Font("Microsoft Sans Serif", 6f));
		((Control)lblZoomNum).set_Location(new Point(82, 168));
		((Control)lblZoomNum).set_Name("lblZoomNum");
		((Control)lblZoomNum).set_Size(new Size(17, 9));
		((Control)lblZoomNum).set_TabIndex(10);
		((Control)lblZoomNum).set_Text("256");
		((Control)lnkBlog).set_AutoSize(true);
		((Control)lnkBlog).set_Location(new Point(1, 223));
		((Control)lnkBlog).set_Name("lnkBlog");
		((Control)lnkBlog).set_Size(new Size(122, 13));
		((Control)lnkBlog).set_TabIndex(11);
		((Label)lnkBlog).set_TabStop(true);
		((Control)lnkBlog).set_Text("http://fujiy.blogspot.com");
		lnkBlog.add_LinkClicked(new LinkLabelLinkClickedEventHandler(lnkBlog_LinkClicked));
		((Control)chkBoxHotKey).set_AutoSize(true);
		chkBoxHotKey.set_Checked(true);
		chkBoxHotKey.set_CheckState((CheckState)1);
		((Control)chkBoxHotKey).set_Location(new Point(1, 21));
		((Control)chkBoxHotKey).set_Name("chkBoxHotKey");
		((Control)chkBoxHotKey).set_Size(new Size(79, 17));
		((Control)chkBoxHotKey).set_TabIndex(12);
		((Control)chkBoxHotKey).set_Text("HotKey(F4)");
		((ButtonBase)chkBoxHotKey).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(134, 243));
		((Control)this).get_Controls().Add((Control)(object)chkBoxHotKey);
		((Control)this).get_Controls().Add((Control)(object)lnkBlog);
		((Control)this).get_Controls().Add((Control)(object)lblZoomNum);
		((Control)this).get_Controls().Add((Control)(object)tabelaAtualizada);
		((Control)this).get_Controls().Add((Control)(object)btnResetZoom);
		((Control)this).get_Controls().Add((Control)(object)trackBar1);
		((Control)this).get_Controls().Add((Control)(object)lblZoom);
		((Control)this).get_Controls().Add((Control)(object)selecionartodos);
		((Control)this).get_Controls().Add((Control)(object)refreshButton);
		((Control)this).get_Controls().Add((Control)(object)chars);
		((Control)this).get_Controls().Add((Control)(object)checkBoxLigar);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Control)this).set_Name("COSpeed");
		((Control)this).set_Text("COSpeed 2.05");
		((Form)this).add_Load((EventHandler)refreshButton_Click);
		((ISupportInitialize)trackBar1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
