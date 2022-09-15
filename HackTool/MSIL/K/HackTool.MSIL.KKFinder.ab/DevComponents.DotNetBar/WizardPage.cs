using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[Designer(typeof(WizardPageDesigner))]
public class WizardPage : PanelControl
{
	private eWizardButtonState eWizardButtonState_0 = eWizardButtonState.Auto;

	private eWizardButtonState eWizardButtonState_1 = eWizardButtonState.Auto;

	private eWizardButtonState eWizardButtonState_2 = eWizardButtonState.Auto;

	private eWizardButtonState eWizardButtonState_3 = eWizardButtonState.Auto;

	private eWizardButtonState eWizardButtonState_4 = eWizardButtonState.Auto;

	private eWizardButtonState eWizardButtonState_5 = eWizardButtonState.Auto;

	private eWizardButtonState eWizardButtonState_6 = eWizardButtonState.Auto;

	private eWizardButtonState eWizardButtonState_7 = eWizardButtonState.Auto;

	private eWizardButtonState eWizardButtonState_8 = eWizardButtonState.Auto;

	private string string_1 = "";

	private string string_2 = "";

	private Image image_0;

	private string string_3 = "";

	private bool bool_9 = true;

	private WizardCancelPageChangeEventHandler wizardCancelPageChangeEventHandler_0;

	private WizardPageChangeEventHandler wizardPageChangeEventHandler_0;

	private WizardPageChangeEventHandler wizardPageChangeEventHandler_1;

	private CancelEventHandler cancelEventHandler_0;

	private CancelEventHandler cancelEventHandler_1;

	private CancelEventHandler cancelEventHandler_2;

	private CancelEventHandler cancelEventHandler_3;

	private CancelEventHandler cancelEventHandler_4;

	[Browsable(false)]
	public bool IsSelected
	{
		get
		{
			if (((Control)this).get_Parent() is Wizard wizard)
			{
				return wizard.SelectedPage == this;
			}
			return false;
		}
	}

	[Browsable(true)]
	[Description("Indicates whether back button is enabled when page is active.")]
	[Category("Page Options")]
	[DefaultValue(eWizardButtonState.Auto)]
	public eWizardButtonState BackButtonEnabled
	{
		get
		{
			return eWizardButtonState_0;
		}
		set
		{
			eWizardButtonState_0 = value;
			method_4();
		}
	}

	[Browsable(true)]
	[DefaultValue(eWizardButtonState.Auto)]
	[Description("Indicates whether back button is visible when page is active.")]
	[Category("Page Options")]
	public eWizardButtonState BackButtonVisible
	{
		get
		{
			return eWizardButtonState_1;
		}
		set
		{
			eWizardButtonState_1 = value;
			method_4();
		}
	}

	[Browsable(true)]
	[DefaultValue(eWizardButtonState.Auto)]
	[Category("Page Options")]
	[Description("Indicates whether next button is enabled when page is active.")]
	public eWizardButtonState NextButtonEnabled
	{
		get
		{
			return eWizardButtonState_2;
		}
		set
		{
			eWizardButtonState_2 = value;
			method_4();
		}
	}

	[Browsable(true)]
	[DefaultValue(eWizardButtonState.Auto)]
	[Category("Page Options")]
	[Description("Indicates whether next button is visible when page is active.")]
	public eWizardButtonState NextButtonVisible
	{
		get
		{
			return eWizardButtonState_3;
		}
		set
		{
			eWizardButtonState_3 = value;
			method_4();
		}
	}

	[Browsable(true)]
	[Category("Page Options")]
	[Description("Indicates whether finish button is enabled when page is active.")]
	[DefaultValue(eWizardButtonState.Auto)]
	public eWizardButtonState FinishButtonEnabled
	{
		get
		{
			return eWizardButtonState_4;
		}
		set
		{
			eWizardButtonState_4 = value;
			method_4();
		}
	}

	[Category("Page Options")]
	[DefaultValue(eWizardButtonState.Auto)]
	[Description("Indicates whether cancel button is enabled when page is active.")]
	[Browsable(true)]
	public eWizardButtonState CancelButtonEnabled
	{
		get
		{
			return eWizardButtonState_5;
		}
		set
		{
			eWizardButtonState_5 = value;
			method_4();
		}
	}

	[Browsable(true)]
	[Category("Page Options")]
	[DefaultValue(eWizardButtonState.Auto)]
	[Description("Indicates whether cancel button is visible when page is active.")]
	public eWizardButtonState CancelButtonVisible
	{
		get
		{
			return eWizardButtonState_6;
		}
		set
		{
			eWizardButtonState_6 = value;
			method_4();
		}
	}

	[Category("Page Options")]
	[DefaultValue(eWizardButtonState.Auto)]
	[Browsable(true)]
	[Description("Indicates whether help button is enabled when page is active.")]
	public eWizardButtonState HelpButtonEnabled
	{
		get
		{
			return eWizardButtonState_7;
		}
		set
		{
			eWizardButtonState_7 = value;
			method_4();
		}
	}

	[Description("Indicates whether help button is visible when page is active.")]
	[Category("Page Options")]
	[DefaultValue(eWizardButtonState.Auto)]
	[Browsable(true)]
	public eWizardButtonState HelpButtonVisible
	{
		get
		{
			return eWizardButtonState_8;
		}
		set
		{
			eWizardButtonState_8 = value;
			method_4();
		}
	}

	[Description("Indicates the page header image when page is an interior page.")]
	[DefaultValue(null)]
	[Category("Page Options")]
	[Browsable(true)]
	public Image PageHeaderImage
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			method_4();
		}
	}

	[Category("Page Options")]
	[Browsable(true)]
	[Localizable(true)]
	[DefaultValue("")]
	[Description("Indicates text that is displayed as title in wizard header.")]
	public string PageTitle
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
			method_4();
		}
	}

	[Category("Page Options")]
	[DefaultValue("")]
	[Description("Indicates text that is displayed as description in wizard header when page is active.")]
	[Localizable(true)]
	[Browsable(true)]
	public string PageDescription
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
			method_4();
		}
	}

	[Category("Page Options")]
	[Localizable(true)]
	[Browsable(true)]
	[DefaultValue("")]
	[Description("Indicates text that is displayed on form caption when page is active.")]
	public string FormCaption
	{
		get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
			method_4();
		}
	}

	[Description("Indicates whether page is inner page.")]
	[DefaultValue(true)]
	[Browsable(true)]
	[Category("Page Options")]
	public bool InteriorPage
	{
		get
		{
			return bool_9;
		}
		set
		{
			if (bool_9 != value)
			{
				bool_9 = value;
				method_5();
			}
		}
	}

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public override Color BackColor
	{
		get
		{
			return base.BackColor;
		}
		set
		{
			base.BackColor = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool Visible
	{
		get
		{
			return ((Control)this).get_Visible();
		}
		set
		{
			((Control)this).set_Visible(value);
		}
	}

	[Description("Occurs before page is displayed")]
	public event WizardCancelPageChangeEventHandler BeforePageDisplayed
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			wizardCancelPageChangeEventHandler_0 = (WizardCancelPageChangeEventHandler)Delegate.Combine(wizardCancelPageChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			wizardCancelPageChangeEventHandler_0 = (WizardCancelPageChangeEventHandler)Delegate.Remove(wizardCancelPageChangeEventHandler_0, value);
		}
	}

	[Description("Occurs before page is displayed")]
	public event WizardPageChangeEventHandler AfterPageDisplayed
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			wizardPageChangeEventHandler_0 = (WizardPageChangeEventHandler)Delegate.Combine(wizardPageChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			wizardPageChangeEventHandler_0 = (WizardPageChangeEventHandler)Delegate.Remove(wizardPageChangeEventHandler_0, value);
		}
	}

	public event WizardPageChangeEventHandler AfterPageHidden
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			wizardPageChangeEventHandler_1 = (WizardPageChangeEventHandler)Delegate.Combine(wizardPageChangeEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			wizardPageChangeEventHandler_1 = (WizardPageChangeEventHandler)Delegate.Remove(wizardPageChangeEventHandler_1, value);
		}
	}

	[Description("Occurs when Back button is clicked.")]
	public event CancelEventHandler BackButtonClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_0, value);
		}
	}

	[Description("Occurs when Next button is clicked.")]
	public event CancelEventHandler NextButtonClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_1 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_1 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_1, value);
		}
	}

	[Description("Occurs when Finish button is clicked.")]
	public event CancelEventHandler FinishButtonClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_2 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_2 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_2, value);
		}
	}

	[Description("Occurs when Cancel button is clicked.")]
	public event CancelEventHandler CancelButtonClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_3 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_3 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_3, value);
		}
	}

	[Description("Occurs when Help button is clicked.")]
	public event CancelEventHandler HelpButtonClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_4 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_4, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_4 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_4, value);
		}
	}

	public WizardPage()
	{
		((Control)this).set_BackColor(SystemColors.Control);
	}

	public bool ShouldSerializeBackColor()
	{
		return ((Control)this).get_BackColor() != SystemColors.Control;
	}

	private void method_4()
	{
		if (((Control)this).get_Parent() is Wizard && ((Wizard)(object)((Control)this).get_Parent()).SelectedPage == this)
		{
			((Wizard)(object)((Control)this).get_Parent()).method_9();
			((Wizard)(object)((Control)this).get_Parent()).method_10(bool_8: false);
		}
	}

	private void method_5()
	{
		if (((Control)this).get_Parent() is Wizard)
		{
			Wizard wizard = ((Control)this).get_Parent() as Wizard;
			wizard.method_13(this);
			if (wizard.SelectedPage == this)
			{
				wizard.method_9();
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		base.OnPaint(e);
		if (((Component)(object)this).DesignMode && InteriorPage)
		{
			Graphics graphics = e.get_Graphics();
			Rectangle displayRectangle = ((Control)this).get_DisplayRectangle();
			Pen val = new Pen(Color.FromArgb(100, SystemColors.ControlDarkDark), 1f);
			try
			{
				val.set_DashStyle((DashStyle)2);
				SmoothingMode smoothingMode = graphics.get_SmoothingMode();
				graphics.set_SmoothingMode((SmoothingMode)0);
				displayRectangle.Inflate(-12, 0);
				graphics.DrawLine(val, displayRectangle.X, displayRectangle.Y, displayRectangle.X, displayRectangle.Bottom);
				graphics.DrawLine(val, displayRectangle.Right, displayRectangle.Y, displayRectangle.Right, displayRectangle.Bottom);
				displayRectangle.Inflate(-22, 0);
				graphics.DrawLine(val, displayRectangle.X, displayRectangle.Y, displayRectangle.X, displayRectangle.Bottom);
				graphics.DrawLine(val, displayRectangle.Right, displayRectangle.Y, displayRectangle.Right, displayRectangle.Bottom);
				displayRectangle.Inflate(-22, 0);
				graphics.DrawLine(val, displayRectangle.X, displayRectangle.Y, displayRectangle.X, displayRectangle.Bottom);
				graphics.DrawLine(val, displayRectangle.Right, displayRectangle.Y, displayRectangle.Right, displayRectangle.Bottom);
				graphics.set_SmoothingMode(smoothingMode);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	protected virtual void OnBeforePageDisplayed(WizardCancelPageChangeEventArgs e)
	{
		if (wizardCancelPageChangeEventHandler_0 != null)
		{
			wizardCancelPageChangeEventHandler_0(this, e);
		}
	}

	internal void method_6(WizardCancelPageChangeEventArgs wizardCancelPageChangeEventArgs_0)
	{
		OnBeforePageDisplayed(wizardCancelPageChangeEventArgs_0);
	}

	protected virtual void OnAfterPageDisplayed(WizardPageChangeEventArgs e)
	{
		if (wizardPageChangeEventHandler_0 != null)
		{
			wizardPageChangeEventHandler_0(this, e);
		}
	}

	internal void method_7(WizardPageChangeEventArgs wizardPageChangeEventArgs_0)
	{
		OnAfterPageDisplayed(wizardPageChangeEventArgs_0);
	}

	protected virtual void OnAfterPageHidden(WizardPageChangeEventArgs e)
	{
		if (wizardPageChangeEventHandler_1 != null)
		{
			wizardPageChangeEventHandler_1(this, e);
		}
	}

	internal void method_8(WizardPageChangeEventArgs wizardPageChangeEventArgs_0)
	{
		OnAfterPageHidden(wizardPageChangeEventArgs_0);
	}

	protected virtual void OnBackButtonClick(CancelEventArgs e)
	{
		if (cancelEventHandler_0 != null)
		{
			cancelEventHandler_0(this, e);
		}
	}

	internal void method_9(CancelEventArgs cancelEventArgs_0)
	{
		OnBackButtonClick(cancelEventArgs_0);
	}

	protected virtual void OnNextButtonClick(CancelEventArgs e)
	{
		if (cancelEventHandler_1 != null)
		{
			cancelEventHandler_1(this, e);
		}
	}

	internal void method_10(CancelEventArgs cancelEventArgs_0)
	{
		OnNextButtonClick(cancelEventArgs_0);
	}

	protected virtual void OnFinishButtonClick(CancelEventArgs e)
	{
		if (cancelEventHandler_2 != null)
		{
			cancelEventHandler_2(this, e);
		}
	}

	internal void method_11(CancelEventArgs cancelEventArgs_0)
	{
		OnFinishButtonClick(cancelEventArgs_0);
	}

	protected virtual void OnCancelButtonClick(CancelEventArgs e)
	{
		if (cancelEventHandler_3 != null)
		{
			cancelEventHandler_3(this, e);
		}
	}

	internal void method_12(CancelEventArgs cancelEventArgs_0)
	{
		OnCancelButtonClick(cancelEventArgs_0);
	}

	protected virtual void OnHelpButtonClick(CancelEventArgs e)
	{
		if (cancelEventHandler_4 != null)
		{
			cancelEventHandler_4(this, e);
		}
	}

	internal void method_13(CancelEventArgs cancelEventArgs_0)
	{
		OnHelpButtonClick(cancelEventArgs_0);
	}
}
