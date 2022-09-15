using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ServiceManager;

public class frmOptimizeServices : Form
{
	private frmOptimizeProgress objFrmOptimzeProgress;

	private ServiceManager objServiceManager;

	private IContainer components;

	[AccessedThroughProperty("ILServices")]
	private ImageList _ILServices;

	[AccessedThroughProperty("PanelEx1")]
	private PanelEx _PanelEx1;

	[AccessedThroughProperty("livCustom")]
	private ListView _livCustom;

	[AccessedThroughProperty("CHCustomDec")]
	private ColumnHeader _CHCustomDec;

	[AccessedThroughProperty("CHCustomStartup")]
	private ColumnHeader _CHCustomStartup;

	[AccessedThroughProperty("CHCustomStaus")]
	private ColumnHeader _CHCustomStaus;

	[AccessedThroughProperty("CHCustomName")]
	private ColumnHeader _CHCustomName;

	[AccessedThroughProperty("livRecommend")]
	private ListView _livRecommend;

	[AccessedThroughProperty("CHDescription")]
	private ColumnHeader _CHDescription;

	[AccessedThroughProperty("CHStartup")]
	private ColumnHeader _CHStartup;

	[AccessedThroughProperty("CHStaus")]
	private ColumnHeader _CHStaus;

	[AccessedThroughProperty("CHName")]
	private ColumnHeader _CHName;

	[AccessedThroughProperty("btnRecover")]
	private Button _btnRecover;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("BtnSaveService")]
	private Button _BtnSaveService;

	[AccessedThroughProperty("CHCustomChecked")]
	private ColumnHeader _CHCustomChecked;

	[AccessedThroughProperty("CHRecChecked")]
	private ColumnHeader _CHRecChecked;

	[AccessedThroughProperty("CHDefaultStartupMode")]
	private ColumnHeader _CHDefaultStartupMode;

	[AccessedThroughProperty("CHCustomDefaultStartupMode")]
	private ColumnHeader _CHCustomDefaultStartupMode;

	internal virtual ImageList ILServices
	{
		get
		{
			return _ILServices;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ILServices = value;
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

	internal virtual ListView livCustom
	{
		get
		{
			return _livCustom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ItemCheckEventHandler val = new ItemCheckEventHandler(livCustom_ItemCheck);
			if (_livCustom != null)
			{
				_livCustom.remove_ItemCheck(val);
			}
			_livCustom = value;
			if (_livCustom != null)
			{
				_livCustom.add_ItemCheck(val);
			}
		}
	}

	internal virtual ColumnHeader CHCustomDec
	{
		get
		{
			return _CHCustomDec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHCustomDec = value;
		}
	}

	internal virtual ColumnHeader CHCustomStartup
	{
		get
		{
			return _CHCustomStartup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHCustomStartup = value;
		}
	}

	internal virtual ColumnHeader CHCustomStaus
	{
		get
		{
			return _CHCustomStaus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHCustomStaus = value;
		}
	}

	internal virtual ColumnHeader CHCustomName
	{
		get
		{
			return _CHCustomName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHCustomName = value;
		}
	}

	internal virtual ListView livRecommend
	{
		get
		{
			return _livRecommend;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ItemCheckEventHandler val = new ItemCheckEventHandler(livRecommend_ItemCheck);
			if (_livRecommend != null)
			{
				_livRecommend.remove_ItemCheck(val);
			}
			_livRecommend = value;
			if (_livRecommend != null)
			{
				_livRecommend.add_ItemCheck(val);
			}
		}
	}

	internal virtual ColumnHeader CHDescription
	{
		get
		{
			return _CHDescription;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHDescription = value;
		}
	}

	internal virtual ColumnHeader CHStartup
	{
		get
		{
			return _CHStartup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHStartup = value;
		}
	}

	internal virtual ColumnHeader CHStaus
	{
		get
		{
			return _CHStaus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHStaus = value;
		}
	}

	internal virtual ColumnHeader CHName
	{
		get
		{
			return _CHName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHName = value;
		}
	}

	internal virtual Button btnRecover
	{
		get
		{
			return _btnRecover;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnRecover_Click;
			if (_btnRecover != null)
			{
				((Control)_btnRecover).remove_Click(eventHandler);
			}
			_btnRecover = value;
			if (_btnRecover != null)
			{
				((Control)_btnRecover).add_Click(eventHandler);
			}
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

	internal virtual Button BtnSaveService
	{
		get
		{
			return _BtnSaveService;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = BtnSaveService_Click;
			if (_BtnSaveService != null)
			{
				((Control)_BtnSaveService).remove_Click(eventHandler);
			}
			_BtnSaveService = value;
			if (_BtnSaveService != null)
			{
				((Control)_BtnSaveService).add_Click(eventHandler);
			}
		}
	}

	internal virtual ColumnHeader CHCustomChecked
	{
		get
		{
			return _CHCustomChecked;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHCustomChecked = value;
		}
	}

	internal virtual ColumnHeader CHRecChecked
	{
		get
		{
			return _CHRecChecked;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHRecChecked = value;
		}
	}

	internal virtual ColumnHeader CHDefaultStartupMode
	{
		get
		{
			return _CHDefaultStartupMode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHDefaultStartupMode = value;
		}
	}

	internal virtual ColumnHeader CHCustomDefaultStartupMode
	{
		get
		{
			return _CHCustomDefaultStartupMode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHCustomDefaultStartupMode = value;
		}
	}

	public frmOptimizeServices()
	{
		((Form)this).add_Load((EventHandler)frmOptimizeServices_Load);
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmOptimizeServices));
		ILServices = new ImageList(components);
		PanelEx1 = new PanelEx();
		Label1 = new Label();
		livCustom = new ListView();
		CHCustomDec = new ColumnHeader();
		CHCustomStartup = new ColumnHeader();
		CHCustomStaus = new ColumnHeader();
		CHCustomName = new ColumnHeader();
		CHCustomChecked = new ColumnHeader();
		livRecommend = new ListView();
		CHDescription = new ColumnHeader();
		CHStartup = new ColumnHeader();
		CHStaus = new ColumnHeader();
		CHName = new ColumnHeader();
		CHRecChecked = new ColumnHeader();
		btnRecover = new Button();
		BtnSaveService = new Button();
		CHDefaultStartupMode = new ColumnHeader();
		CHCustomDefaultStartupMode = new ColumnHeader();
		((Control)PanelEx1).SuspendLayout();
		((Control)this).SuspendLayout();
		ILServices.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ILServices.ImageStream"));
		ILServices.set_TransparentColor(Color.Black);
		ILServices.get_Images().SetKeyName(0, "");
		PanelEx1.set_AntiAlias(true);
		((Control)PanelEx1).get_Controls().Add((Control)(object)Label1);
		((Control)PanelEx1).set_Dock((DockStyle)1);
		PanelEx panelEx = PanelEx1;
		Point location = new Point(0, 0);
		((Control)panelEx).set_Location(location);
		((Control)PanelEx1).set_Name("PanelEx1");
		PanelEx panelEx2 = PanelEx1;
		Size size = new Size(710, 38);
		((Control)panelEx2).set_Size(size);
		PanelEx1.get_Style().set_Alignment((StringAlignment)1);
		PanelEx1.get_Style().get_BackColor1().set_ColorSchemePart((eColorSchemePart)47);
		PanelEx1.get_Style().get_BackColor2().set_ColorSchemePart((eColorSchemePart)48);
		PanelEx1.get_Style().set_Border((eBorderType)1);
		PanelEx1.get_Style().get_BorderColor().set_ColorSchemePart((eColorSchemePart)49);
		PanelEx1.get_Style().get_ForeColor().set_ColorSchemePart((eColorSchemePart)50);
		PanelEx1.get_Style().set_GradientAngle(90);
		((Control)PanelEx1).set_TabIndex(0);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_ForeColor(SystemColors.HighlightText);
		Label1.set_Image((Image)componentResourceManager.GetObject("Label1.Image"));
		Label1.set_ImageAlign((ContentAlignment)16);
		Label label = Label1;
		location = new Point(21, 4);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(621, 28);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(44);
		Label1.set_Text("Easily tunes up the system services that start with Windows to improve system performance and security.");
		Label1.set_TextAlign((ContentAlignment)64);
		livCustom.set_CheckBoxes(true);
		livCustom.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[6] { CHCustomDec, CHCustomStartup, CHCustomStaus, CHCustomName, CHCustomChecked, CHCustomDefaultStartupMode });
		livCustom.set_FullRowSelect(true);
		livCustom.set_GridLines(true);
		livCustom.set_HeaderStyle((ColumnHeaderStyle)1);
		ListView obj = livCustom;
		location = new Point(8, 150);
		((Control)obj).set_Location(location);
		((Control)livCustom).set_Name("livCustom");
		ListView obj2 = livCustom;
		size = new Size(691, 280);
		((Control)obj2).set_Size(size);
		((Control)livCustom).set_TabIndex(46);
		livCustom.set_UseCompatibleStateImageBehavior(false);
		livCustom.set_View((View)1);
		CHCustomDec.set_Text("Disable/Enable the System Services base on your Desire");
		CHCustomDec.set_Width(426);
		CHCustomStartup.set_Text("Startup Type");
		CHCustomStartup.set_Width(80);
		CHCustomStaus.set_Text("Status");
		CHCustomStaus.set_Width(56);
		CHCustomName.set_Text("Service Name");
		CHCustomName.set_Width(110);
		CHCustomChecked.set_Width(0);
		livRecommend.set_CheckBoxes(true);
		livRecommend.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[6] { CHDescription, CHStartup, CHStaus, CHName, CHRecChecked, CHDefaultStartupMode });
		((Control)livRecommend).set_Font(new Font("Tahoma", 11f, (FontStyle)0, (GraphicsUnit)2, (byte)0));
		livRecommend.set_FullRowSelect(true);
		livRecommend.set_GridLines(true);
		livRecommend.set_HeaderStyle((ColumnHeaderStyle)1);
		ListView obj3 = livRecommend;
		location = new Point(8, 48);
		((Control)obj3).set_Location(location);
		((Control)livRecommend).set_Name("livRecommend");
		ListView obj4 = livRecommend;
		size = new Size(691, 95);
		((Control)obj4).set_Size(size);
		((Control)livRecommend).set_TabIndex(45);
		livRecommend.set_UseCompatibleStateImageBehavior(false);
		livRecommend.set_View((View)1);
		CHDescription.set_Text("The System Service that recommended to Disable");
		CHDescription.set_Width(423);
		CHStartup.set_Text("Startup Type");
		CHStartup.set_Width(80);
		CHStaus.set_Text("Status");
		CHStaus.set_Width(57);
		CHName.set_Text("Service Name");
		CHName.set_Width(111);
		CHRecChecked.set_Width(0);
		((ButtonBase)btnRecover).set_BackColor(SystemColors.Control);
		((Control)btnRecover).set_Cursor(Cursors.get_Hand());
		((ButtonBase)btnRecover).set_FlatStyle((FlatStyle)3);
		((Control)btnRecover).set_ForeColor(SystemColors.ControlText);
		Button obj5 = btnRecover;
		location = new Point(520, 440);
		((Control)obj5).set_Location(location);
		((Control)btnRecover).set_Name("btnRecover");
		Button obj6 = btnRecover;
		size = new Size(86, 23);
		((Control)obj6).set_Size(size);
		((Control)btnRecover).set_TabIndex(43);
		((ButtonBase)btnRecover).set_Text("Restore");
		((ButtonBase)btnRecover).set_UseVisualStyleBackColor(false);
		((ButtonBase)BtnSaveService).set_BackColor(SystemColors.Control);
		((Control)BtnSaveService).set_Cursor(Cursors.get_Hand());
		((ButtonBase)BtnSaveService).set_FlatStyle((FlatStyle)3);
		((Control)BtnSaveService).set_ForeColor(SystemColors.ControlText);
		Button btnSaveService = BtnSaveService;
		location = new Point(611, 440);
		((Control)btnSaveService).set_Location(location);
		((Control)BtnSaveService).set_Name("BtnSaveService");
		Button btnSaveService2 = BtnSaveService;
		size = new Size(86, 23);
		((Control)btnSaveService2).set_Size(size);
		((Control)BtnSaveService).set_TabIndex(42);
		((ButtonBase)BtnSaveService).set_Text("Apply");
		((ButtonBase)BtnSaveService).set_UseVisualStyleBackColor(false);
		CHDefaultStartupMode.set_Text("");
		CHDefaultStartupMode.set_Width(0);
		CHCustomDefaultStartupMode.set_Text("");
		CHCustomDefaultStartupMode.set_Width(0);
		size = new Size(5, 14);
		((Form)this).set_AutoScaleBaseSize(size);
		((Form)this).set_BackColor(SystemColors.Window);
		size = new Size(710, 472);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)livCustom);
		((Control)this).get_Controls().Add((Control)(object)livRecommend);
		((Control)this).get_Controls().Add((Control)(object)btnRecover);
		((Control)this).get_Controls().Add((Control)(object)BtnSaveService);
		((Control)this).get_Controls().Add((Control)(object)PanelEx1);
		((Control)this).set_Font(new Font("Tahoma", 11f, (FontStyle)0, (GraphicsUnit)2, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmOptimizeServices");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Optimize Services");
		((Control)PanelEx1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void frmOptimizeServices_Load(object sender, EventArgs e)
	{
		frmOptimizeProgress.objFrmOptimizeServices = this;
		objServiceManager.GetService(livRecommend, livCustom);
	}

	private void livRecommend_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (!livRecommend.get_Items().get_Item(e.get_Index()).get_Checked())
		{
			livRecommend.get_Items().get_Item(e.get_Index()).get_SubItems()
				.get_Item(1)
				.set_Text("Disabled");
		}
		else
		{
			livRecommend.get_Items().get_Item(e.get_Index()).get_SubItems()
				.get_Item(1)
				.set_Text(livRecommend.get_Items().get_Item(e.get_Index()).get_SubItems()
					.get_Item(5)
					.get_Text());
		}
	}

	private void livCustom_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (!livCustom.get_Items().get_Item(e.get_Index()).get_Checked())
		{
			livCustom.get_Items().get_Item(e.get_Index()).get_SubItems()
				.get_Item(1)
				.set_Text("Disabled");
		}
		else
		{
			livCustom.get_Items().get_Item(e.get_Index()).get_SubItems()
				.get_Item(1)
				.set_Text(livCustom.get_Items().get_Item(e.get_Index()).get_SubItems()
					.get_Item(5)
					.get_Text());
		}
	}

	private void BtnSaveService_Click(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		objFrmOptimzeProgress = new frmOptimizeProgress();
		((Form)objFrmOptimzeProgress).ShowDialog();
	}

	private void btnRecover_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if ((int)MessageBox.Show("Are you sure to restore to default?", "Confirm", (MessageBoxButtons)4, (MessageBoxIcon)32) != 6)
		{
			return;
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = livRecommend.get_Items().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ListViewItem val = (ListViewItem)enumerator.Current;
				val.set_Checked(false);
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
			enumerator2 = livCustom.get_Items().GetEnumerator();
			while (enumerator2.MoveNext())
			{
				ListViewItem val2 = (ListViewItem)enumerator2.Current;
				val2.set_Checked(false);
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				(enumerator2 as IDisposable).Dispose();
			}
		}
		BtnSaveService_Click(null, null);
	}
}
