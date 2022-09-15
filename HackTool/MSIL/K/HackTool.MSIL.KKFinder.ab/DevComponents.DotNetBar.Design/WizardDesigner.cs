using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.Win32;

namespace DevComponents.DotNetBar.Design;

public class WizardDesigner : ControlDesigner
{
	private enum Enum21
	{
		const_0,
		const_1
	}

	private WizardPageNavigationControl wizardPageNavigationControl_0;

	private eWizardStyle eWizardStyle_0;

	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] array = null;
			array = new DesignerVerb[7]
			{
				new DesignerVerb("Create Inner Page", method_3),
				new DesignerVerb("Create Welcome Page", method_4),
				new DesignerVerb("Create Outer Page", method_5),
				new DesignerVerb("Delete Page", method_6),
				new DesignerVerb("Next Page", method_7),
				new DesignerVerb("Previous Page", method_8),
				new DesignerVerb("Goto Page/Change Order", method_2)
			};
			return new DesignerVerbCollection(array);
		}
	}

	public eWizardStyle WizardStyle
	{
		get
		{
			return eWizardStyle_0;
		}
		set
		{
			if (eWizardStyle_0 != value)
			{
				eWizardStyle_0 = value;
				((Wizard)(object)((ControlDesigner)this).get_Control()).ButtonStyle = eWizardStyle_0;
				if (((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost && !designerHost.Loading)
				{
					method_10(eWizardStyle_0);
				}
			}
		}
	}

	public override void Initialize(IComponent component)
	{
		((ControlDesigner)this).Initialize(component);
		if (component.Site!.DesignMode)
		{
			IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
			if (componentChangeService != null)
			{
				componentChangeService.ComponentRemoved += method_0;
			}
			if (component is Wizard wizard)
			{
				WizardPageNavigationControl wizardPageNavigationControl = new WizardPageNavigationControl();
				((Control)wizardPageNavigationControl).set_Location(new Point(4, ((Control)wizard.panelFooter).get_Height() - ((Control)wizardPageNavigationControl).get_Height() - 4));
				((Control)wizard.panelFooter).get_Controls().Add((Control)(object)wizardPageNavigationControl);
				((Control)wizardPageNavigationControl).set_BackColor(SystemColors.Control);
				wizardPageNavigationControl_0 = wizardPageNavigationControl;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		if (componentChangeService != null)
		{
			componentChangeService.ComponentRemoved -= method_0;
		}
		((ControlDesigner)this).Dispose(disposing);
	}

	private void method_0(object sender, ComponentEventArgs e)
	{
		if (e.Component is WizardPage)
		{
			WizardPage wizardPage = e.Component as WizardPage;
			Wizard wizard = ((ControlDesigner)this).get_Control() as Wizard;
			if (wizardPage != null && wizard.WizardPages.Contains(wizardPage))
			{
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				componentChangeService?.OnComponentChanging(wizard, TypeDescriptor.GetProperties(wizard)["WizardPages"]);
				wizard.WizardPages.Remove(wizardPage);
				componentChangeService?.OnComponentChanged(wizard, TypeDescriptor.GetProperties(wizard)["WizardPages"], null, null);
			}
		}
	}

	public override void DoDefaultAction()
	{
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ControlDesigner)this).InitializeNewComponent(defaultValues);
		method_1();
	}

	private void method_1()
	{
		if (((ControlDesigner)this).get_Control() is Wizard wizard)
		{
			TypeDescriptor.GetProperties(wizard)["HeaderImageVisible"]!.SetValue(wizard, true);
			TypeDescriptor.GetProperties(wizard)["Dock"]!.SetValue(wizard, (object)(DockStyle)5);
			method_9(wizard);
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		Wizard wizard_ = ((ControlDesigner)this).get_Control() as Wizard;
		IComponentChangeService icomponentChangeService_ = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		ISelectionService iselectionService_ = ((ComponentDesigner)this).GetService(typeof(ISelectionService)) as ISelectionService;
		smethod_0(wizard_, icomponentChangeService_, iselectionService_);
	}

	internal static void smethod_0(Wizard wizard_0, IComponentChangeService icomponentChangeService_0, ISelectionService iselectionService_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		if (wizard_0 == null)
		{
			return;
		}
		WizardPageOrderDialog wizardPageOrderDialog = new WizardPageOrderDialog();
		wizardPageOrderDialog.method_0(wizard_0);
		((Form)wizardPageOrderDialog).set_StartPosition((FormStartPosition)1);
		if ((int)((Form)wizardPageOrderDialog).ShowDialog() == 1)
		{
			string string_ = wizardPageOrderDialog.String_0;
			if (wizardPageOrderDialog.bool_0)
			{
				icomponentChangeService_0?.OnComponentChanging(wizard_0, TypeDescriptor.GetProperties(wizard_0)["WizardPages"]);
				string[] string_2 = wizardPageOrderDialog.String_1;
				wizard_0.WizardPages.bool_0 = true;
				try
				{
					WizardPageCollection wizardPageCollection = new WizardPageCollection();
					wizard_0.WizardPages.method_1(wizardPageCollection);
					wizard_0.WizardPages.Clear();
					string[] array = string_2;
					foreach (string name in array)
					{
						wizard_0.WizardPages.Add(wizardPageCollection[name]);
					}
				}
				finally
				{
					wizard_0.WizardPages.bool_0 = false;
				}
				icomponentChangeService_0?.OnComponentChanged(wizard_0, TypeDescriptor.GetProperties(wizard_0)["WizardPages"], null, null);
			}
			if (string_ != "")
			{
				wizard_0.SelectedPage = wizard_0.WizardPages[string_];
			}
			else if (wizardPageOrderDialog.bool_0)
			{
				wizard_0.SelectedPageIndex = 0;
			}
			if (iselectionService_0 != null && (string_ != "" || wizardPageOrderDialog.bool_0))
			{
				iselectionService_0.SetSelectedComponents(new WizardPage[1] { wizard_0.SelectedPage }, SelectionTypes.Replace);
			}
		}
		((Component)(object)wizardPageOrderDialog).Dispose();
	}

	private void method_3(object sender, EventArgs e)
	{
		IDesignerHost idesignerHost_ = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		IComponentChangeService icomponentChangeService_ = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		ISelectionService iselectionService_ = ((ComponentDesigner)this).GetService(typeof(ISelectionService)) as ISelectionService;
		smethod_10(((ControlDesigner)this).get_Control() as Wizard, bool_0: true, idesignerHost_, icomponentChangeService_, iselectionService_, eWizardStyle_0);
	}

	private void method_4(object sender, EventArgs e)
	{
		IDesignerHost idesignerHost_ = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		IComponentChangeService icomponentChangeService_ = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		ISelectionService iselectionService_ = ((ComponentDesigner)this).GetService(typeof(ISelectionService)) as ISelectionService;
		smethod_9(((ControlDesigner)this).get_Control() as Wizard, idesignerHost_, icomponentChangeService_, iselectionService_, WizardStyle);
	}

	private void method_5(object sender, EventArgs e)
	{
		IDesignerHost idesignerHost_ = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		IComponentChangeService icomponentChangeService_ = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		ISelectionService iselectionService_ = ((ComponentDesigner)this).GetService(typeof(ISelectionService)) as ISelectionService;
		smethod_10(((ControlDesigner)this).get_Control() as Wizard, bool_0: false, idesignerHost_, icomponentChangeService_, iselectionService_, eWizardStyle_0);
	}

	private void method_6(object sender, EventArgs e)
	{
		IDesignerHost idesignerHost_ = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		IComponentChangeService icomponentChangeService_ = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		if (((ControlDesigner)this).get_Control() is Wizard wizard)
		{
			smethod_1(wizard.SelectedPage, idesignerHost_, icomponentChangeService_);
		}
	}

	internal static void smethod_1(WizardPage wizardPage_0, IDesignerHost idesignerHost_0, IComponentChangeService icomponentChangeService_0)
	{
		if (wizardPage_0 == null || !(((Control)wizardPage_0).get_Parent() is Wizard))
		{
			return;
		}
		Wizard wizard = ((Control)wizardPage_0).get_Parent() as Wizard;
		DesignerTransaction designerTransaction = idesignerHost_0.CreateTransaction();
		try
		{
			icomponentChangeService_0?.OnComponentChanging(wizard, TypeDescriptor.GetProperties(wizard)["WizardPages"]);
			wizard.WizardPages.Remove(wizardPage_0);
			icomponentChangeService_0?.OnComponentChanged(wizard, TypeDescriptor.GetProperties(wizard)["WizardPages"], null, null);
			idesignerHost_0.DestroyComponent((IComponent)wizardPage_0);
		}
		catch
		{
			designerTransaction.Cancel();
		}
		finally
		{
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		smethod_2(((ControlDesigner)this).get_Control() as Wizard);
	}

	private void method_8(object sender, EventArgs e)
	{
		smethod_3(((ControlDesigner)this).get_Control() as Wizard);
	}

	internal static bool smethod_2(Wizard wizard_0)
	{
		if (wizard_0 == null)
		{
			return false;
		}
		WizardPage wizardPage = wizard_0.method_5();
		if (wizardPage != null)
		{
			wizard_0.SelectedPage = wizardPage;
			return true;
		}
		return false;
	}

	internal static bool smethod_3(Wizard wizard_0)
	{
		if (wizard_0 == null)
		{
			return false;
		}
		WizardPage wizardPage = wizard_0.method_4();
		if (wizardPage != null)
		{
			wizard_0.SelectedPage = wizardPage;
			return true;
		}
		return false;
	}

	private static Image smethod_4(Enum21 enum21_0)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		string text = "WizardWelcomeImage.png";
		if (enum21_0 == Enum21.const_1)
		{
			text = "WizardOffice2007Background.png";
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine;
			string text2 = "";
			try
			{
				if (registryKey != null)
				{
					registryKey = registryKey.OpenSubKey("Software\\DevComponents\\DotNetBar");
				}
				if (registryKey != null)
				{
					text2 = registryKey.GetValue("InstallationFolder", "")!.ToString();
				}
			}
			finally
			{
				registryKey?.Close();
			}
			if (text2 != "")
			{
				if (text2.Substring(text2.Length - 1, 1) != "\\")
				{
					text2 += "\\";
				}
				text2 = ((!File.Exists(text2 + text)) ? "" : (text2 + text));
			}
			if (text2 != "")
			{
				return (Image)new Bitmap(text2);
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	internal static void smethod_5(WizardPage wizardPage_0, IDesignerHost idesignerHost_0, IComponentChangeService icomponentChangeService_0)
	{
		DesignerTransaction designerTransaction = null;
		if (idesignerHost_0 != null)
		{
			designerTransaction = idesignerHost_0.CreateTransaction();
		}
		try
		{
			icomponentChangeService_0?.OnComponentChanging(wizardPage_0, null);
			((Control)wizardPage_0).set_BackColor(Color.Transparent);
			wizardPage_0.Style.Reset();
			icomponentChangeService_0?.OnComponentChanged(wizardPage_0, null, null, null);
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			if (designerTransaction != null && !designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	internal static void smethod_6(WizardPage wizardPage_0, IDesignerHost idesignerHost_0, IComponentChangeService icomponentChangeService_0)
	{
		icomponentChangeService_0?.OnComponentChanging(wizardPage_0, null);
		((Control)wizardPage_0).set_BackColor(Color.Transparent);
		wizardPage_0.Style.Reset();
		icomponentChangeService_0?.OnComponentChanged(wizardPage_0, null, null, null);
	}

	internal static void smethod_7(WizardPage wizardPage_0, IDesignerHost idesignerHost_0, IComponentChangeService icomponentChangeService_0)
	{
		icomponentChangeService_0?.OnComponentChanging(wizardPage_0, null);
		((Control)wizardPage_0).set_BackColor(SystemColors.Control);
		if (!wizardPage_0.InteriorPage)
		{
			TypeDescriptor.GetProperties(wizardPage_0.Style)["BackColor"]!.SetValue(wizardPage_0.Style, Color.White);
		}
		icomponentChangeService_0?.OnComponentChanged(wizardPage_0, null, null, null);
	}

	internal static void smethod_8(WizardPage wizardPage_0, IDesignerHost idesignerHost_0, IComponentChangeService icomponentChangeService_0)
	{
		DesignerTransaction designerTransaction = null;
		if (idesignerHost_0 != null)
		{
			designerTransaction = idesignerHost_0.CreateTransaction();
		}
		try
		{
			((Control)wizardPage_0).set_BackColor(Color.White);
			wizardPage_0.Style.BackColorBlend.Clear();
			TypeDescriptor.GetProperties(wizardPage_0)["InteriorPage"]!.SetValue(wizardPage_0, false);
			TypeDescriptor.GetProperties(wizardPage_0)["BackColor"]!.SetValue(wizardPage_0, Color.White);
			TypeDescriptor.GetProperties(wizardPage_0)["CanvasColor"]!.SetValue(wizardPage_0, Color.White);
			TypeDescriptor.GetProperties(wizardPage_0.Style)["BackColor"]!.SetValue(wizardPage_0.Style, Color.White);
			TypeDescriptor.GetProperties(wizardPage_0.Style)["BackColor2"]!.SetValue(wizardPage_0.Style, Color.Empty);
			TypeDescriptor.GetProperties(wizardPage_0.Style)["BackgroundImage"]!.SetValue(wizardPage_0.Style, smethod_4(Enum21.const_0));
			TypeDescriptor.GetProperties(wizardPage_0.Style)["BackgroundImagePosition"]!.SetValue(wizardPage_0.Style, eStyleBackgroundImage.TopLeft);
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			if (designerTransaction != null && !designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	internal static WizardPage smethod_9(Wizard wizard_0, IDesignerHost idesignerHost_0, IComponentChangeService icomponentChangeService_0, ISelectionService iselectionService_0, eWizardStyle eWizardStyle_1)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		DesignerTransaction designerTransaction = idesignerHost_0.CreateTransaction();
		WizardPage wizardPage = null;
		try
		{
			wizardPage = idesignerHost_0.CreateComponent(typeof(WizardPage)) as WizardPage;
			if (eWizardStyle_1 == eWizardStyle.Default)
			{
				smethod_8(wizardPage, null, null);
			}
			else
			{
				smethod_5(wizardPage, null, null);
			}
			((Control)wizardPage).set_Size(new Size(534, 289));
			IComponent component = idesignerHost_0.CreateComponent(typeof(Label));
			Label val = (Label)((component is Label) ? component : null);
			((Control)wizardPage).get_Controls().Add((Control)(object)val);
			((Control)val).set_Location(new Point(210, 18));
			((Control)val).set_Text("Welcome to the <Wizard Name> Wizard");
			((Control)val).set_BackColor(Color.Transparent);
			try
			{
				((Control)val).set_Font(new Font("Tahoma", 16f));
				TypeDescriptor.GetProperties(val)["AutoSize"]!.SetValue(val, false);
			}
			catch
			{
			}
			((Control)val).set_Size(new Size(310, 66));
			((Control)val).set_Anchor((AnchorStyles)13);
			IComponent component2 = idesignerHost_0.CreateComponent(typeof(Label));
			val = (Label)((component2 is Label) ? component2 : null);
			((Control)wizardPage).get_Controls().Add((Control)(object)val);
			((Control)val).set_Location(new Point(210, 100));
			((Control)val).set_Text("This wizard will guide you through the <Enter Process Name>.\r\n\r\n<Enter brief description of the process wizard is covering.>");
			((Control)val).set_BackColor(Color.Transparent);
			try
			{
				TypeDescriptor.GetProperties(val)["AutoSize"]!.SetValue(val, false);
			}
			catch
			{
			}
			((Control)val).set_Size(new Size(309, 157));
			((Control)val).set_Anchor((AnchorStyles)15);
			IComponent component3 = idesignerHost_0.CreateComponent(typeof(Label));
			val = (Label)((component3 is Label) ? component3 : null);
			((Control)wizardPage).get_Controls().Add((Control)(object)val);
			((Control)val).set_Location(new Point(210, 266));
			((Control)val).set_Text("To continue, click Next.");
			((Control)val).set_Size(new Size(120, 13));
			((Control)val).set_Anchor((AnchorStyles)6);
			((Control)val).set_BackColor(Color.Transparent);
			icomponentChangeService_0?.OnComponentChanging(wizard_0, TypeDescriptor.GetProperties(wizard_0)["WizardPages"]);
			wizard_0.WizardPages.Add(wizardPage);
			icomponentChangeService_0?.OnComponentChanged(wizard_0, TypeDescriptor.GetProperties(wizard_0)["WizardPages"], null, null);
			iselectionService_0?.SetSelectedComponents(new WizardPage[1] { wizardPage }, SelectionTypes.Replace);
			TypeDescriptor.GetProperties(wizard_0)["SelectedPageIndex"]!.SetValue(wizard_0, wizard_0.WizardPages.IndexOf(wizardPage));
			return wizardPage;
		}
		catch
		{
			designerTransaction.Cancel();
			return wizardPage;
		}
		finally
		{
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	internal static WizardPage smethod_10(Wizard wizard_0, bool bool_0, IDesignerHost idesignerHost_0, IComponentChangeService icomponentChangeService_0, ISelectionService iselectionService_0, eWizardStyle eWizardStyle_1)
	{
		DesignerTransaction designerTransaction = idesignerHost_0.CreateTransaction();
		WizardPage wizardPage = null;
		try
		{
			wizardPage = idesignerHost_0.CreateComponent(typeof(WizardPage)) as WizardPage;
			wizardPage.AntiAlias = false;
			wizardPage.InteriorPage = bool_0;
			if (bool_0)
			{
				wizardPage.PageTitle = "< Wizard step title >";
				wizardPage.PageDescription = "< Wizard step description >";
			}
			switch (eWizardStyle_1)
			{
			case eWizardStyle.Default:
				smethod_7(wizardPage, idesignerHost_0, icomponentChangeService_0);
				break;
			case eWizardStyle.Office2007:
				smethod_6(wizardPage, idesignerHost_0, icomponentChangeService_0);
				break;
			}
			icomponentChangeService_0?.OnComponentChanging(wizard_0, TypeDescriptor.GetProperties(wizard_0)["WizardPages"]);
			wizard_0.WizardPages.Add(wizardPage);
			icomponentChangeService_0?.OnComponentChanged(wizard_0, TypeDescriptor.GetProperties(wizard_0)["WizardPages"], null, null);
			iselectionService_0?.SetSelectedComponents(new WizardPage[1] { wizardPage }, SelectionTypes.Replace);
			TypeDescriptor.GetProperties(wizard_0)["SelectedPageIndex"]!.SetValue(wizard_0, wizard_0.WizardPages.IndexOf(wizardPage));
			return wizardPage;
		}
		catch
		{
			designerTransaction.Cancel();
			return wizardPage;
		}
		finally
		{
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected override void OnMouseDragBegin(int x, int y)
	{
		if (((ControlDesigner)this).get_Control() is Wizard wizard)
		{
			Point pt = ((Control)wizard.ButtonX_0).get_Parent().PointToClient(new Point(x, y));
			if (((Control)wizard.ButtonX_0).get_Enabled() && ((Control)wizard.ButtonX_0).get_Visible() && ((Control)wizard.ButtonX_0).get_Bounds().Contains(pt))
			{
				smethod_2(wizard);
				return;
			}
			if (((Control)wizard.ButtonX_1).get_Enabled() && ((Control)wizard.ButtonX_1).get_Visible() && ((Control)wizard.ButtonX_1).get_Bounds().Contains(pt))
			{
				smethod_3(wizard);
				return;
			}
			if (wizardPageNavigationControl_0 != null)
			{
				pt = ((Control)wizardPageNavigationControl_0).PointToClient(new Point(x, y));
				if (((Control)wizardPageNavigationControl_0.LinkNext).get_Bounds().Contains(pt))
				{
					smethod_2(wizard);
					return;
				}
				if (((Control)wizardPageNavigationControl_0.LinkBack).get_Bounds().Contains(pt))
				{
					smethod_3(wizard);
					return;
				}
			}
		}
		((ControlDesigner)this).OnMouseDragBegin(x, y);
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ControlDesigner)this).PreFilterProperties(properties);
		properties["WizardStyle"] = TypeDescriptor.CreateProperty(((object)this).GetType(), "WizardStyle", typeof(eWizardStyle), new BrowsableAttribute(browsable: true), new DesignOnlyAttribute(isDesignOnly: true), new DefaultValueAttribute(eWizardStyle.Default), new DescriptionAttribute("Indicates the visual appearance style of the Wizard"));
	}

	private void method_9(Wizard wizard_0)
	{
		wizard_0.FooterStyle.BackColor = SystemColors.Control;
		wizard_0.FooterStyle.BackColorGradientAngle = 90;
		wizard_0.FooterStyle.BorderBottomWidth = 1;
		wizard_0.FooterStyle.BorderColor = SystemColors.Control;
		wizard_0.FooterStyle.BorderLeftWidth = 1;
		wizard_0.FooterStyle.BorderRightWidth = 1;
		wizard_0.FooterStyle.BorderTop = eStyleBorderType.Etched;
		wizard_0.FooterStyle.BorderTopColor = SystemColors.Control;
		wizard_0.FooterStyle.BorderTopWidth = 1;
		wizard_0.FooterStyle.TextAlignment = eStyleTextAlignment.Center;
		wizard_0.FooterStyle.TextColorSchemePart = eColorSchemePart.PanelText;
	}

	private void method_10(eWizardStyle eWizardStyle_1)
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		IComponentChangeService icomponentChangeService_ = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		IDesignerHost designerHost = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
		DesignerTransaction designerTransaction = designerHost.CreateTransaction();
		try
		{
			Wizard wizard = ((ControlDesigner)this).get_Control() as Wizard;
			wizard.FooterStyle.Reset();
			switch (eWizardStyle_1)
			{
			case eWizardStyle.Office2007:
				wizard.FooterStyle.BackColor = Color.Transparent;
				((Control)wizard).set_BackColor(Color.FromArgb(205, 229, 253));
				((Control)wizard).set_ForeColor(ColorScheme.GetColor(997761));
				((Control)wizard).set_BackgroundImage(smethod_4(Enum21.const_1));
				wizard.HeaderStyle.Reset();
				wizard.HeaderStyle.BackColor = Color.Transparent;
				wizard.HeaderStyle.BackColor2 = Color.Empty;
				wizard.HeaderStyle.BackColorGradientAngle = 90;
				wizard.HeaderStyle.BorderBottomColor = ColorScheme.GetColor(7970230);
				wizard.HeaderStyle.BorderBottomWidth = 1;
				wizard.HeaderStyle.BorderBottom = eStyleBorderType.Solid;
				wizard.HeaderHeight = 90;
				wizard.HeaderDescriptionVisible = false;
				wizard.HeaderImageAlignment = eWizardTitleImageAlignment.Left;
				wizard.HeaderCaptionFont = new Font(((Control)wizard).get_Font().get_FontFamily(), 12f, (FontStyle)1);
				break;
			case eWizardStyle.Default:
				method_9(wizard);
				((Control)wizard).set_BackgroundImage((Image)null);
				((Control)wizard).set_BackColor(SystemColors.Control);
				((Control)wizard).set_ForeColor(SystemColors.ControlText);
				wizard.HeaderStyle.Reset();
				wizard.HeaderStyle.BackColor = Color.FromArgb(255, 255, 255);
				wizard.HeaderStyle.BackColorGradientAngle = 90;
				wizard.HeaderStyle.BorderBottom = eStyleBorderType.Etched;
				wizard.HeaderStyle.BorderBottomWidth = 1;
				wizard.HeaderStyle.BorderColor = SystemColors.Control;
				wizard.HeaderStyle.BorderLeftWidth = 1;
				wizard.HeaderStyle.BorderRightWidth = 1;
				wizard.HeaderStyle.BorderTopWidth = 1;
				wizard.HeaderStyle.TextAlignment = eStyleTextAlignment.Center;
				wizard.HeaderStyle.TextColorSchemePart = eColorSchemePart.PanelText;
				wizard.HeaderHeight = 60;
				wizard.HeaderDescriptionVisible = true;
				wizard.HeaderCaptionFont = new Font(((Control)wizard).get_Font(), (FontStyle)1);
				wizard.HeaderImageAlignment = eWizardTitleImageAlignment.Right;
				break;
			}
			for (int i = 0; i < wizard.WizardPages.Count; i++)
			{
				WizardPage wizardPage = wizard.WizardPages[i];
				if (!wizardPage.InteriorPage && i == 0)
				{
					switch (eWizardStyle_1)
					{
					case eWizardStyle.Default:
						smethod_8(wizardPage, null, icomponentChangeService_);
						break;
					case eWizardStyle.Office2007:
						smethod_5(wizardPage, null, icomponentChangeService_);
						break;
					}
				}
				else
				{
					switch (eWizardStyle_1)
					{
					case eWizardStyle.Default:
						smethod_7(wizardPage, null, icomponentChangeService_);
						break;
					case eWizardStyle.Office2007:
						smethod_6(wizardPage, null, icomponentChangeService_);
						break;
					}
				}
			}
		}
		catch
		{
			designerTransaction.Cancel();
		}
		finally
		{
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}
}
