using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;

namespace ServiceManager;

public class frmOptimizeProgress : Form
{
	public static frmOptimizeServices objFrmOptimizeServices;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("lblTip")]
	private Label _lblTip;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("PanelEx1")]
	private PanelEx _PanelEx1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	private ServiceManager objServiceManager;

	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	internal virtual Panel Panel1
	{
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual Label lblTip
	{
		get
		{
			return _lblTip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTip = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual PanelEx PanelEx1
	{
		get
		{
			return _PanelEx1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PanelEx1 = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	public frmOptimizeProgress()
	{
		((Form)this).add_Load((EventHandler)frmOptimizeProgress_Load);
		objServiceManager = new ServiceManager();
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
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
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		components = new Container();
		Timer1 = new Timer(components);
		Panel1 = new Panel();
		lblTip = new Label();
		ProgressBar1 = new ProgressBar();
		PanelEx1 = new PanelEx();
		Label1 = new Label();
		((Control)Panel1).SuspendLayout();
		((Control)PanelEx1).SuspendLayout();
		((Control)this).SuspendLayout();
		Timer1.set_Enabled(true);
		((Control)Panel1).set_BackColor(SystemColors.Window);
		Panel1.set_BorderStyle((BorderStyle)1);
		((Control)Panel1).get_Controls().Add((Control)(object)lblTip);
		((Control)Panel1).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)Panel1).get_Controls().Add((Control)(object)PanelEx1);
		((Control)Panel1).set_Dock((DockStyle)5);
		Panel panel = Panel1;
		Point location = new Point(0, 0);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		Size size = new Size(445, 112);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(0);
		((Control)lblTip).set_BackColor(Color.Transparent);
		((Control)lblTip).set_ForeColor(SystemColors.ControlText);
		Label obj = lblTip;
		location = new Point(28, 68);
		((Control)obj).set_Location(location);
		((Control)lblTip).set_Name("lblTip");
		Label obj2 = lblTip;
		size = new Size(388, 26);
		((Control)obj2).set_Size(size);
		((Control)lblTip).set_TabIndex(10);
		lblTip.set_TextAlign((ContentAlignment)32);
		((Control)ProgressBar1).set_BackColor(SystemColors.Control);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(37, 42);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(371, 16);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(9);
		PanelEx1.set_AntiAlias(true);
		((Control)PanelEx1).get_Controls().Add((Control)(object)Label1);
		((Control)PanelEx1).set_Dock((DockStyle)1);
		PanelEx panelEx = PanelEx1;
		location = new Point(0, 0);
		((Control)panelEx).set_Location(location);
		((Control)PanelEx1).set_Name("PanelEx1");
		PanelEx panelEx2 = PanelEx1;
		size = new Size(443, 26);
		((Control)panelEx2).set_Size(size);
		PanelEx1.get_Style().set_Alignment((StringAlignment)1);
		PanelEx1.get_Style().get_BackColor1().set_ColorSchemePart((eColorSchemePart)47);
		PanelEx1.get_Style().get_BackColor2().set_ColorSchemePart((eColorSchemePart)48);
		PanelEx1.get_Style().set_Border((eBorderType)1);
		PanelEx1.get_Style().get_BorderColor().set_ColorSchemePart((eColorSchemePart)49);
		PanelEx1.get_Style().get_ForeColor().set_ColorSchemePart((eColorSchemePart)50);
		PanelEx1.get_Style().set_GradientAngle(90);
		((Control)PanelEx1).set_TabIndex(8);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Tahoma", 11f, (FontStyle)0, (GraphicsUnit)2, (byte)134));
		((Control)Label1).set_ForeColor(SystemColors.HighlightText);
		Label label = Label1;
		location = new Point(144, 6);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(155, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Optimizing Services in progress");
		size = new Size(5, 14);
		((Form)this).set_AutoScaleBaseSize(size);
		((Form)this).set_BackColor(SystemColors.Control);
		size = new Size(445, 112);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Font(new Font("Tahoma", 11f, (FontStyle)0, (GraphicsUnit)2, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmOptimizeProgress");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)Panel1).ResumeLayout(false);
		((Control)PanelEx1).ResumeLayout(false);
		((Control)PanelEx1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmOptimizeProgress_Load(object sender, EventArgs e)
	{
		Timer1.set_Enabled(true);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		((Component)(object)Timer1).Dispose();
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		checked
		{
			ProgressBar1.set_Maximum(objFrmOptimizeServices.livRecommend.get_Items().get_Count() + objFrmOptimizeServices.livCustom.get_Items().get_Count());
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = objFrmOptimizeServices.livRecommend.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					try
					{
						if (Operators.CompareString(val.get_Checked().ToString().ToLower(), val.get_SubItems().get_Item(4).get_Text()
							.ToLower(), false) != 0)
						{
							lblTip.set_Text(val.get_Text());
							Application.DoEvents();
							string[] array = val.get_Tag().ToString()!.Split(new char[1] { ',' });
							foreach (string serviceName in array)
							{
								try
								{
									objServiceManager.SetService(serviceName, val.get_SubItems().get_Item(1).get_Text());
								}
								catch (Exception projectError)
								{
									ProjectData.SetProjectError(projectError);
									ProjectData.ClearProjectError();
								}
								Thread.Sleep(500);
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					ProgressBar1.set_Value(ProgressBar1.get_Value() + 1);
					Application.DoEvents();
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = objFrmOptimizeServices.livCustom.get_Items().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					ListViewItem val2 = (ListViewItem)enumerator2.Current;
					try
					{
						if (Operators.CompareString(val2.get_Checked().ToString().ToLower(), val2.get_SubItems().get_Item(4).get_Text()
							.ToLower(), false) != 0)
						{
							lblTip.set_Text(val2.get_Text());
							Application.DoEvents();
							string[] array2 = val2.get_Tag().ToString()!.Split(new char[1] { ',' });
							foreach (string serviceName2 in array2)
							{
								try
								{
									objServiceManager.SetService(serviceName2, val2.get_SubItems().get_Item(1).get_Text());
								}
								catch (Exception projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									ProjectData.ClearProjectError();
								}
								Thread.Sleep(500);
							}
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					ProgressBar1.set_Value(ProgressBar1.get_Value() + 1);
					Application.DoEvents();
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			Thread.Sleep(5000);
			objFrmOptimizeServices.livRecommend.get_Items().Clear();
			objFrmOptimizeServices.livCustom.get_Items().Clear();
			objServiceManager.GetService(objFrmOptimizeServices.livRecommend, objFrmOptimizeServices.livCustom);
			((Form)this).Close();
		}
	}
}
