using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KasperKeySharingNetwork.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KasperKeySharingNetwork;

[DesignerGenerated]
public class KeysAndListPrep : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("MonthCalendar1")]
	private MonthCalendar _MonthCalendar1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	[AccessedThroughProperty("rtb_Instruction")]
	private RichTextBox _rtb_Instruction;

	[AccessedThroughProperty("RichTextBox2")]
	private RichTextBox _RichTextBox2;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	private string TheOnlinePath;

	private string TheText;

	private ArrayList TheListPath;

	private ArrayList TheKeyName;

	private ArrayList TheDate;

	private ArrayList theNewName;

	private ArrayList theFiles;

	internal virtual MonthCalendar MonthCalendar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _MonthCalendar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MonthCalendar1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual OpenFileDialog OpenFileDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OpenFileDialog1 = value;
		}
	}

	internal virtual RichTextBox rtb_Instruction
	{
		[DebuggerNonUserCode]
		get
		{
			return _rtb_Instruction;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rtb_Instruction = value;
		}
	}

	internal virtual RichTextBox RichTextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RichTextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RichTextBox2 = value;
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	public KeysAndListPrep()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		TheListPath = new ArrayList();
		TheKeyName = new ArrayList();
		TheDate = new ArrayList();
		theNewName = new ArrayList();
		theFiles = new ArrayList();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
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
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(KeysAndListPrep));
		MonthCalendar1 = new MonthCalendar();
		Label2 = new Label();
		Label3 = new Label();
		TextBox2 = new TextBox();
		Label1 = new Label();
		TextBox1 = new TextBox();
		Button1 = new Button();
		OpenFileDialog1 = new OpenFileDialog();
		rtb_Instruction = new RichTextBox();
		RichTextBox2 = new RichTextBox();
		Button2 = new Button();
		((Control)this).SuspendLayout();
		MonthCalendar monthCalendar = MonthCalendar1;
		Point location = new Point(454, 31);
		((Control)monthCalendar).set_Location(location);
		((Control)MonthCalendar1).set_Name("MonthCalendar1");
		((Control)MonthCalendar1).set_TabIndex(12);
		Label2.set_AutoSize(true);
		Label label = Label2;
		location = new Point(497, 9);
		((Control)label).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label2 = Label2;
		Size size = new Size(89, 13);
		((Control)label2).set_Size(size);
		((Control)Label2).set_TabIndex(11);
		Label2.set_Text("The update date:");
		Label3.set_AutoSize(true);
		Label label3 = Label3;
		location = new Point(47, 168);
		((Control)label3).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label4 = Label3;
		size = new Size(116, 13);
		((Control)label4).set_Size(size);
		((Control)Label3).set_TabIndex(10);
		Label3.set_Text("The new file extension:");
		TextBox textBox = TextBox2;
		location = new Point(167, 165);
		((Control)textBox).set_Location(location);
		((TextBoxBase)TextBox2).set_MaxLength(4);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox2 = TextBox2;
		size = new Size(48, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox2).set_TabIndex(7);
		TextBox2.set_Text(".ffp");
		Label1.set_AutoSize(true);
		Label label5 = Label1;
		location = new Point(19, 140);
		((Control)label5).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label6 = Label1;
		size = new Size(142, 13);
		((Control)label6).set_Size(size);
		((Control)Label1).set_TabIndex(9);
		Label1.set_Text("The un-common online path:");
		TextBox textBox3 = TextBox1;
		location = new Point(167, 137);
		((Control)textBox3).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox4 = TextBox1;
		size = new Size(275, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox1).set_TabIndex(8);
		TextBox1.set_Text("2008/Dec_15/");
		Button button = Button1;
		location = new Point(262, 163);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(6);
		((ButtonBase)Button1).set_Text("Show Me");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		RichTextBox obj = rtb_Instruction;
		location = new Point(12, 9);
		((Control)obj).set_Location(location);
		((Control)rtb_Instruction).set_Name("rtb_Instruction");
		((TextBoxBase)rtb_Instruction).set_ReadOnly(true);
		RichTextBox obj2 = rtb_Instruction;
		size = new Size(430, 122);
		((Control)obj2).set_Size(size);
		((Control)rtb_Instruction).set_TabIndex(18);
		rtb_Instruction.set_Text(componentResourceManager.GetString("rtb_Instruction.Text"));
		RichTextBox richTextBox = RichTextBox2;
		location = new Point(12, 191);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox2).set_Name("RichTextBox2");
		RichTextBox richTextBox2 = RichTextBox2;
		size = new Size(618, 118);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox2).set_TabIndex(19);
		RichTextBox2.set_Text("");
		Button button3 = Button2;
		location = new Point(262, 315);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(6);
		((ButtonBase)Button2).set_Text("Process");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(642, 343);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox2);
		((Control)this).get_Controls().Add((Control)(object)rtb_Instruction);
		((Control)this).get_Controls().Add((Control)(object)MonthCalendar1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("KeysAndListPrep");
		((Form)this).set_Text("Keys & List Preparation.");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Invalid comparison between Unknown and I4
		try
		{
			OpenFileDialog1.set_CheckFileExists(true);
			((FileDialog)OpenFileDialog1).set_CheckPathExists(true);
			((FileDialog)OpenFileDialog1).set_DefaultExt("key");
			((FileDialog)OpenFileDialog1).set_Filter("Kaspersky Key File(*.Key)|*.Key");
			OpenFileDialog1.set_Multiselect(true);
			((FileDialog)OpenFileDialog1).set_Title("Select the Kaspersky Keys you wish to Prepare for Listing.");
			((FileDialog)OpenFileDialog1).set_FileName("");
			if ((int)((CommonDialog)OpenFileDialog1).ShowDialog() != 2)
			{
				TheText = "";
				if (TheListPath != null)
				{
					TheListPath.Clear();
				}
				if (TheKeyName != null)
				{
					TheKeyName.Clear();
				}
				if (TheDate != null)
				{
					TheDate.Clear();
				}
				if (theNewName != null)
				{
					theNewName.Clear();
				}
				if (theFiles != null)
				{
					theFiles.Clear();
				}
				TheOnlinePath = "";
				TheOnlinePath = TextBox1.get_Text();
				int num = 1;
				string[] fileNames = ((FileDialog)OpenFileDialog1).get_FileNames();
				MonthCalendar1.SetSelectionRange(MonthCalendar1.get_SelectionRange().get_Start(), MonthCalendar1.get_SelectionRange().get_Start());
				TheDate.Add(Strings.Format((object)MonthCalendar1.get_SelectionRange().get_Start(), "MMM dd, yy"));
				string[] array = fileNames;
				checked
				{
					foreach (string text in array)
					{
						theFiles.Add(text);
						TheListPath.Add(text.Substring(0, text.LastIndexOf("\\")) + "\\");
						TheKeyName.Add(text.Replace(Conversions.ToString(TheListPath[TheListPath.Count - 1]), ""));
						theNewName.Add(Strings.Format((object)num, "000000") + TextBox2.get_Text());
						TheText = Conversions.ToString(Operators.AddObject((object)TheText, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)TheOnlinePath, theNewName[theNewName.Count - 1]), (object)"\t"), TheDate[TheDate.Count - 1]), (object)"\t"), TheKeyName[TheKeyName.Count - 1]), (object)"\r\n")));
						num++;
					}
					RichTextBox2.set_Text(TheText);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (theFiles.Count == 0)
				{
					return;
				}
				int num = theFiles.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					try
					{
						FileInfo fileInfo = new FileInfo(Conversions.ToString(theFiles[num2]));
						fileInfo.MoveTo(Conversions.ToString(Operators.ConcatenateObject(TheListPath[num2], theNewName[num2])));
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					num2++;
				}
				string path = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(TheListPath[0], (object)"The List "), (object)Strings.Format((object)DateTime.Now, "MMM dd, yy HHmm")), (object)".txt"));
				StreamWriter streamWriter = new StreamWriter(path);
				streamWriter.Write(TheText);
				streamWriter.Flush();
				streamWriter.Close();
				streamWriter.Dispose();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}
}
