using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class AboutBox1 : Form
{
	private IContainer icontainer_0 = null;

	private GroupBox groupBox1;

	private Label label1;

	private Label label4;

	private Label label3;

	private Label label2;

	private Label label5;

	private Label label6;

	public AboutBox1()
	{
		InitializeComponent();
	}

	[SpecialName]
	public string method_0()
	{
		object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), inherit: false);
		if (customAttributes.Length > 0)
		{
			AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)customAttributes[0];
			if (assemblyTitleAttribute.Title != "")
			{
				return assemblyTitleAttribute.Title;
			}
		}
		return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
	}

	[SpecialName]
	public string method_1()
	{
		return Assembly.GetExecutingAssembly().GetName().Version!.ToString();
	}

	[SpecialName]
	public string method_2()
	{
		object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), inherit: false);
		if (customAttributes.Length == 0)
		{
			return "";
		}
		return ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
	}

	[SpecialName]
	public string method_3()
	{
		object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), inherit: false);
		if (customAttributes.Length == 0)
		{
			return "";
		}
		return ((AssemblyProductAttribute)customAttributes[0]).Product;
	}

	[SpecialName]
	public string method_4()
	{
		object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), inherit: false);
		if (customAttributes.Length == 0)
		{
			return "";
		}
		return ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
	}

	[SpecialName]
	public string method_5()
	{
		object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), inherit: false);
		if (customAttributes.Length == 0)
		{
			return "";
		}
		return ((AssemblyCompanyAttribute)customAttributes[0]).Company;
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		groupBox1 = new GroupBox();
		label6 = new Label();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox1).get_Controls().Add((Control)(object)label6);
		((Control)groupBox1).get_Controls().Add((Control)(object)label5);
		((Control)groupBox1).get_Controls().Add((Control)(object)label4);
		((Control)groupBox1).get_Controls().Add((Control)(object)label3);
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).set_Location(new Point(12, 12));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(148, 119));
		((Control)groupBox1).set_TabIndex(0);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Features");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(63, 103));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(79, 13));
		((Control)label6).set_TabIndex(0);
		((Control)label6).set_Text("D3N@live.com");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(6, 55));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(133, 13));
		((Control)label5).set_TabIndex(4);
		((Control)label5).set_Text("Anti-VirtualBox - Not tested");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(6, 29));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(105, 13));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("Anti-System Analyzer");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(6, 42));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(120, 13));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Anti-Joebox - Not tested");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(6, 16));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(83, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Anti-Etherdetect");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(6, 68));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(76, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Anti-Wireshark");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(170, 142));
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AboutBox1");
		((Control)this).set_Padding(new Padding(9));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("About");
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
