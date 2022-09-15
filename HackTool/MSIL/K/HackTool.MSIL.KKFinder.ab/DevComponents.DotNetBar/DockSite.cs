using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
[Designer(typeof(DockSiteDesigner))]
public class DockSite : Control
{
	private eOrientation eOrientation_0;

	private bool bool_0;

	private bool bool_1;

	private DotNetBarManager dotNetBarManager_0;

	private bool bool_2;

	private bool bool_3;

	private Class78 class78_0;

	private eBackgroundImagePosition eBackgroundImagePosition_0;

	private byte byte_0 = byte.MaxValue;

	private Color color_0 = Color.Empty;

	private int int_0 = 90;

	private bool bool_4;

	private DocumentDockUIManager documentDockUIManager_0;

	private bool bool_5;

	internal bool bool_6;

	private int int_1;

	private bool bool_7 = true;

	private DocumentDockContainer documentDockContainer_0;

	[DefaultValue(true)]
	[Description("Indicates whether painting is disabled on dock site while layout of bars is performed.")]
	public bool OptimizeLayoutRedraw
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
		}
	}

	[DefaultValue(null)]
	[Browsable(false)]
	public DocumentDockContainer DocumentDockContainer
	{
		get
		{
			return documentDockContainer_0;
		}
		set
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Invalid comparison between Unknown and I4
			documentDockContainer_0 = value;
			documentDockUIManager_0 = GetDocumentUIManager();
			documentDockUIManager_0.RootDocumentDockContainer = documentDockContainer_0;
			if ((int)((Control)this).get_Dock() != 5 && value != null)
			{
				documentDockContainer_0.RecordDocumentSize = true;
			}
		}
	}

	[DefaultValue(eBackgroundImagePosition.Stretch)]
	[Description("Specifies background image position when container is larger than image.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	public eBackgroundImagePosition BackgroundImagePosition
	{
		get
		{
			return eBackgroundImagePosition_0;
		}
		set
		{
			if (eBackgroundImagePosition_0 != value)
			{
				eBackgroundImagePosition_0 = value;
				((Control)this).Refresh();
			}
		}
	}

	[Description("Specifies the transparency of background image.")]
	[Category("Appearance")]
	[DefaultValue(byte.MaxValue)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public byte BackgroundImageAlpha
	{
		get
		{
			return byte_0;
		}
		set
		{
			if (byte_0 != value)
			{
				byte_0 = value;
				((Control)this).Refresh();
			}
		}
	}

	[Description("Indicates the target gradient background color.")]
	[Browsable(true)]
	[Category("Style")]
	public Color BackColor2
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			if (((Component)this).DesignMode)
			{
				((Control)this).Refresh();
			}
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[Description("Indicates gradient fill angle.")]
	[DefaultValue(90)]
	public int BackColorGradientAngle
	{
		get
		{
			return int_0;
		}
		set
		{
			if (value != int_0)
			{
				int_0 = value;
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	private Class78 Class78_0
	{
		get
		{
			if (class78_0 == null)
			{
				class78_0 = new Class78((Control)(object)this);
			}
			return class78_0;
		}
	}

	public override DockStyle Dock
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Dock();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Invalid comparison between Unknown and I4
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Invalid comparison between Unknown and I4
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Invalid comparison between Unknown and I4
			((Control)this).set_Dock(value);
			if ((int)value != 1 && (int)value != 2 && (int)value != 5)
			{
				if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() == 0)
				{
					((Control)this).set_Width(0);
				}
				eOrientation_0 = eOrientation.Vertical;
			}
			else
			{
				if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() == 0)
				{
					((Control)this).set_Height(0);
				}
				eOrientation_0 = eOrientation.Horizontal;
			}
		}
	}

	internal bool Boolean_0
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
			{
				Control val = item;
				if (val is Bar)
				{
					if (((Bar)(object)val).Boolean_8)
					{
						return true;
					}
				}
				else if (val.get_Visible())
				{
					return true;
				}
			}
			return false;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool NeedsLayout
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	private bool Boolean_1
	{
		get
		{
			if ((dotNetBarManager_0 == null || !dotNetBarManager_0.SuspendLayout) && !bool_5 && !bool_6)
			{
				return false;
			}
			return true;
		}
	}

	internal eOrientation EOrientation_0 => eOrientation_0;

	internal bool Boolean_2
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)((Control)this).get_Dock() != 5)
			{
				return documentDockContainer_0 != null;
			}
			return true;
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	public DotNetBarManager Owner => dotNetBarManager_0;

	internal bool Boolean_3
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
			{
				Control val = item;
				if (val is Bar bar && bar.LockDockPosition)
				{
					return true;
				}
			}
			return false;
		}
	}

	public DockSite(DockStyle DockSide)
		: this()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Dock(DockSide);
	}

	public DockSite()
	{
		((Control)this).set_TabStop(false);
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).set_IsAccessible(true);
		((Control)this).set_AccessibleRole((AccessibleRole)9);
	}

	protected override void Dispose(bool disposing)
	{
		dotNetBarManager_0 = null;
		bool_4 = true;
		((Control)this).Dispose(disposing);
	}

	public DocumentDockUIManager GetDocumentUIManager()
	{
		if (documentDockUIManager_0 == null)
		{
			documentDockUIManager_0 = new DocumentDockUIManager(this);
			documentDockUIManager_0.RootDocumentDockContainer = documentDockContainer_0;
		}
		return documentDockUIManager_0;
	}

	public void SaveLayout(XmlElement xmlBars)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		if (!Boolean_2 && documentDockContainer_0 == null)
		{
			foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
			{
				Control val = item;
				if (val is Bar bar && bar.Name != "" && bar.SaveLayoutChanges)
				{
					XmlElement xmlElement = xmlBars.OwnerDocument.CreateElement("bar");
					xmlBars.AppendChild(xmlElement);
					bar.method_85(xmlElement);
				}
			}
			return;
		}
		GetDocumentUIManager().method_26(xmlBars);
	}

	public void LoadLayout(XmlElement xmlBars)
	{
		bool_5 = true;
		try
		{
			if (!Boolean_2 && documentDockContainer_0 == null)
			{
				foreach (XmlElement childNode in xmlBars.ChildNodes)
				{
					Bar bar = null;
					if (dotNetBarManager_0.Bars.Contains(dotNetBarManager_0.Bars[childNode.GetAttribute("name")]))
					{
						bar = dotNetBarManager_0.Bars[childNode.GetAttribute("name")];
					}
					else
					{
						bar = new Bar();
						dotNetBarManager_0.Bars.Add(bar);
					}
					bar.method_86(childNode);
				}
				return;
			}
			GetDocumentUIManager().method_29((XmlElement)xmlBars.FirstChild);
		}
		finally
		{
			bool_5 = false;
			RecalcLayout();
		}
	}

	public void SuspendLayout()
	{
		bool_5 = true;
		((Control)this).SuspendLayout();
	}

	public void ResumeLayout()
	{
		ResumeLayout(performLayout: true);
	}

	public void ResumeLayout(bool performLayout)
	{
		bool_5 = false;
		((Control)this).ResumeLayout(performLayout);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackgroundImageAlpha()
	{
		return byte_0 != byte.MaxValue;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeBackColor2()
	{
		return !color_0.IsEmpty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackColor2()
	{
		color_0 = Color.Empty;
	}

	internal bool method_0()
	{
		return ((Component)this).DesignMode;
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		((Control)this).OnVisibleChanged(e);
		if (((Control)this).get_Visible())
		{
			AccessibleObject accessibilityObject = ((Control)this).get_AccessibilityObject();
			ControlAccessibleObject val = (ControlAccessibleObject)(object)((accessibilityObject is ControlAccessibleObject) ? accessibilityObject : null);
			if (val != null)
			{
				val.NotifyClients((AccessibleEvents)32770);
			}
		}
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
		if (Boolean_1)
		{
			return;
		}
		if (!color_0.IsEmpty && !((Control)this).get_BackColor().IsEmpty && ((Control)this).get_Width() > 0 && ((Control)this).get_Height() > 0)
		{
			Class50.smethod_26(pevent.get_Graphics(), ((Control)this).get_ClientRectangle(), ((Control)this).get_BackColor(), BackColor2, int_0);
			return;
		}
		if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() > 0 && ((Control)this).get_Controls().get_Item(0) is Bar && ((Bar)(object)((Control)this).get_Controls().get_Item(0)).Boolean_4)
		{
			Class78 @class = Class78_0;
			@class.method_0(pevent.get_Graphics(), Class139.class139_0, Class164.class164_0, ((Control)this).get_ClientRectangle());
			return;
		}
		ColorScheme colorScheme = GetColorScheme();
		if (colorScheme != null && ((Control)this).get_BackColor() != Color.Transparent)
		{
			Class50.smethod_26(pevent.get_Graphics(), ((Control)this).get_ClientRectangle(), colorScheme.DockSiteBackColor, colorScheme.DockSiteBackColor2, colorScheme.DockSiteBackColorGradientAngle);
		}
		else
		{
			((Control)this).OnPaintBackground(pevent);
		}
	}

	private ColorScheme GetColorScheme()
	{
		if (dotNetBarManager_0 != null && dotNetBarManager_0.UseGlobalColorScheme)
		{
			if (dotNetBarManager_0.Style == eDotNetBarStyle.Office2007 && GlobalManager.Renderer is Office2007Renderer)
			{
				return ((Office2007Renderer)GlobalManager.Renderer).ColorTable.LegacyColors;
			}
			return dotNetBarManager_0.ColorScheme;
		}
		if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() > 0 && ((Control)this).get_Controls().get_Item(0) is Bar && (((Bar)(object)((Control)this).get_Controls().get_Item(0)).Style == eDotNetBarStyle.Office2003 || ((Bar)(object)((Control)this).get_Controls().get_Item(0)).Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(((Bar)(object)((Control)this).get_Controls().get_Item(0)).Style)))
		{
			Bar bar = ((Control)this).get_Controls().get_Item(0) as Bar;
			return bar.GetColorScheme();
		}
		return null;
	}

	protected override void OnPaint(PaintEventArgs pevent)
	{
		if (!Boolean_1)
		{
			if (((Control)this).get_BackgroundImage() != null)
			{
				Class109.smethod_63(pevent.get_Graphics(), ((Control)this).get_ClientRectangle(), ((Control)this).get_BackgroundImage(), eBackgroundImagePosition_0, byte_0);
			}
			else
			{
				((Control)this).OnPaint(pevent);
			}
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		RecalcLayout();
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		if (class78_0 != null)
		{
			class78_0.Dispose();
			class78_0 = null;
		}
		((Control)this).OnHandleDestroyed(e);
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 794)
		{
			class78_0 = null;
		}
		((Control)this).WndProc(ref m);
	}

	protected override void OnControlRemoved(ControlEventArgs e)
	{
		((Control)this).OnControlRemoved(e);
		if (((Component)this).DesignMode)
		{
			RecalcLayout();
		}
	}

	protected override void OnControlAdded(ControlEventArgs e)
	{
		((Control)this).OnControlAdded(e);
		if (!(e.get_Control() is IDockInfo))
		{
			((Control)this).get_Controls().Remove(e.get_Control());
			throw new ArgumentException("Only Bar objects can be added to DockSite through DotNetBar designer.");
		}
		method_22();
	}

	internal void method_1(Control control_0)
	{
		if (!(control_0 is IDockInfo dockInfo))
		{
			throw new ArgumentException("Only Bar objects can be added to DockSite through DotNetBar designer.");
		}
		if (!((Control)this).get_Visible() && (Owner == null || (Owner != null && !Owner.IsLoadingDefinition)))
		{
			Class109.smethod_4((Control)(object)this, bool_3: true);
		}
		dockInfo.DockOrientation = eOrientation_0;
		Control val = null;
		IDockInfo dockInfo2 = null;
		bool flag = false;
		for (int i = 0; i < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count(); i++)
		{
			val = ((Control)this).get_Controls().get_Item(i);
			if (val is IDockInfo dockInfo3 && ((dockInfo.DockLine <= dockInfo3.DockLine && dockInfo.DockOffset < dockInfo3.DockOffset) || dockInfo.DockLine < dockInfo3.DockLine))
			{
				((Control)this).get_Controls().Add(control_0);
				((Control)this).get_Controls().SetChildIndex(control_0, i);
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			((Control)this).get_Controls().Add(control_0);
		}
		if (control_0 is Bar && ((Bar)(object)control_0).LayoutType == eLayoutType.DockContainer)
		{
			Bar bar = control_0 as Bar;
			if (eOrientation_0 == eOrientation.Horizontal && bar.ItemsContainer.Int32_1 > 0)
			{
				((Bar)(object)control_0).method_56();
			}
			else if (eOrientation_0 == eOrientation.Vertical && bar.ItemsContainer.Int32_2 > 0)
			{
				((Bar)(object)control_0).method_55();
			}
		}
		method_6();
		method_8();
	}

	internal void method_2(Control control_0, int int_2)
	{
		if (!(control_0 is IDockInfo dockInfo))
		{
			throw new ArgumentException("Only Bar objects can be added to DockSite through DotNetBar designer.");
		}
		if (!((Control)this).get_Visible())
		{
			Class109.smethod_4((Control)(object)this, bool_3: true);
		}
		dockInfo.DockOrientation = eOrientation_0;
		((Control)this).get_Controls().Add(control_0);
		((Control)this).get_Controls().SetChildIndex(control_0, int_2);
		if (control_0 is Bar && ((Bar)(object)control_0).LayoutType == eLayoutType.DockContainer)
		{
			Bar bar = control_0 as Bar;
			if (eOrientation_0 == eOrientation.Horizontal && bar.ItemsContainer.Int32_1 > 0)
			{
				((Bar)(object)control_0).method_56();
			}
			else if (eOrientation_0 == eOrientation.Vertical && bar.ItemsContainer.Int32_2 > 0)
			{
				((Bar)(object)control_0).method_55();
			}
		}
		method_6();
		method_8();
	}

	internal void method_3(Control control_0, int int_2)
	{
		if (((Control)this).Contains(control_0))
		{
			if (((Control)this).get_Controls().GetChildIndex(control_0) != int_2)
			{
				((Control)this).get_Controls().SetChildIndex(control_0, int_2);
			}
			method_8();
		}
	}

	internal void method_4(Control control_0, int int_2, bool bool_8)
	{
		if (!((Control)this).Contains(control_0))
		{
			return;
		}
		if (((Control)this).get_Controls().GetChildIndex(control_0) != int_2)
		{
			((Control)this).get_Controls().SetChildIndex(control_0, int_2);
		}
		if (bool_8)
		{
			int_2 = ((Control)this).get_Controls().IndexOf(control_0);
			if (int_2 >= 0)
			{
				if (int_2 > 0)
				{
					((IDockInfo)control_0).SetDockLine(((IDockInfo)((Control)this).get_Controls().get_Item(int_2 - 1)).DockLine + 1);
				}
				else
				{
					((IDockInfo)control_0).SetDockLine(-1);
				}
				for (int i = int_2 + 1; i < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count(); i++)
				{
					((IDockInfo)((Control)this).get_Controls().get_Item(i)).SetDockLine(((IDockInfo)((Control)this).get_Controls().get_Item(i)).DockLine + 2);
				}
			}
		}
		method_8();
	}

	internal void method_5(Control control_0)
	{
		if (!(control_0 is IDockInfo dockInfo))
		{
			throw new ArgumentException("Only Bar objects can be added to DockSite through DotNetBar designer.");
		}
		if (!((Control)this).get_Controls().Contains(control_0))
		{
			throw new ArgumentException("Control is not part of this collection.");
		}
		Control val = null;
		IDockInfo dockInfo2 = null;
		int num = 0;
		while (true)
		{
			if (num < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count())
			{
				val = ((Control)this).get_Controls().get_Item(num);
				if (val != control_0 && val is IDockInfo dockInfo3)
				{
					if (dockInfo.DockLine == dockInfo3.DockLine && dockInfo.DockOffset <= dockInfo3.DockOffset)
					{
						if (num > 0 && num > ((Control)this).get_Controls().GetChildIndex(control_0))
						{
							num--;
						}
						((Control)this).get_Controls().SetChildIndex(control_0, num);
						return;
					}
					if (dockInfo.DockLine < dockInfo3.DockLine)
					{
						break;
					}
				}
				num++;
				continue;
			}
			((Control)this).get_Controls().SetChildIndex(control_0, ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count());
			return;
		}
		if (num > 0)
		{
			num--;
		}
		((Control)this).get_Controls().SetChildIndex(control_0, num);
	}

	public void RecalcLayout()
	{
		method_8();
	}

	private void method_6()
	{
		if (Boolean_1)
		{
			bool_3 = true;
			return;
		}
		int num = -1;
		int num2 = -2;
		for (int i = 0; i < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count(); i++)
		{
			if (((Control)this).get_Controls().get_Item(i) is Bar bar)
			{
				if (bar.DockLine != num2)
				{
					num++;
					num2 = bar.DockLine;
					bar.SetDockLine(num);
				}
				else
				{
					bar.SetDockLine(num);
				}
			}
		}
		bool_3 = false;
	}

	private Rectangle method_7()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		if ((int)((Control)this).get_Dock() != 5 && documentDockContainer_0 != null)
		{
			int splitterSize = documentDockContainer_0.SplitterSize;
			if ((int)((Control)this).get_Dock() == 3)
			{
				clientRectangle.Width -= splitterSize;
			}
			else if ((int)((Control)this).get_Dock() == 4)
			{
				clientRectangle.Width -= splitterSize;
				clientRectangle.X += splitterSize;
			}
			else if ((int)((Control)this).get_Dock() == 2)
			{
				clientRectangle.Height -= splitterSize;
				clientRectangle.Y += splitterSize;
			}
			else if ((int)((Control)this).get_Dock() == 1)
			{
				clientRectangle.Height -= splitterSize;
			}
			return clientRectangle;
		}
		return clientRectangle;
	}

	private void method_8()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_0ea2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea8: Invalid comparison between Unknown and I4
		//IL_0ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Invalid comparison between Unknown and I4
		//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee7: Invalid comparison between Unknown and I4
		//IL_0f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Invalid comparison between Unknown and I4
		//IL_1018: Unknown result type (might be due to invalid IL or missing references)
		//IL_101e: Invalid comparison between Unknown and I4
		//IL_103e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1044: Invalid comparison between Unknown and I4
		//IL_105c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1062: Invalid comparison between Unknown and I4
		//IL_1065: Unknown result type (might be due to invalid IL or missing references)
		//IL_106b: Invalid comparison between Unknown and I4
		if (bool_4 || ((Control)this).get_IsDisposed())
		{
			return;
		}
		if (Boolean_1)
		{
			bool_2 = true;
			return;
		}
		if (bool_3)
		{
			method_6();
		}
		if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() == 0 && ((((int)((Control)this).get_Dock() == 3 || (int)((Control)this).get_Dock() == 4) && ((Control)this).get_Width() == 0) || (((int)((Control)this).get_Dock() == 1 || (int)((Control)this).get_Dock() == 2) && ((Control)this).get_Height() == 0)))
		{
			return;
		}
		Form val = ((Control)this).FindForm();
		if (val != null && (((Control)val).get_Width() == 0 || ((Control)val).get_Height() == 0))
		{
			return;
		}
		if (val != null && ((ContainerControl)val).get_ParentForm() != null)
		{
			val = ((ContainerControl)val).get_ParentForm();
		}
		if ((val != null && (((Control)val).get_Width() == 0 || ((Control)val).get_Height() == 0)) || (val != null && (int)val.get_WindowState() == 1))
		{
			return;
		}
		bool_2 = false;
		if (bool_0)
		{
			return;
		}
		bool_0 = true;
		int num = -1;
		if ((int)((Control)this).get_Dock() != 5 && documentDockContainer_0 == null)
		{
			IDockInfo dockInfo = null;
			Bar bar = null;
			Control val2 = null;
			bool flag = false;
			Rectangle bounds = ((Control)this).get_Bounds();
			if (((Control)this).get_Parent() != null && ((Control)this).get_Parent().get_Visible() && bool_7)
			{
				if (((Control)this).get_Parent() != null)
				{
					num = ((Control)this).get_Parent().get_Controls().IndexOf((Control)(object)this);
				}
				Class92.SendMessage(((Control)this).get_Handle(), 11, 0, 0);
			}
			int num2 = 0;
			int num3 = 0;
			int[] array = new int[256];
			int[] array2 = new int[256];
			int[] array3 = new int[256];
			int[] array4 = new int[256];
			int[] array5 = new int[256];
			ArrayList arrayList = null;
			for (int i = 0; i < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count(); i++)
			{
				bar = ((Control)this).get_Controls().get_Item(i) as Bar;
				if ((bar != null && !bar.Visible) || bar == null || bar.LayoutType != eLayoutType.DockContainer || !bar.Stretch || bar.DockLine < 0)
				{
					continue;
				}
				array[bar.DockLine]++;
				array2[bar.DockLine]++;
				if (eOrientation_0 == eOrientation.Horizontal)
				{
					if (bar.Int32_1 == 0)
					{
						array5[bar.DockLine]++;
					}
					else
					{
						array4[bar.DockLine] += bar.Int32_1;
					}
				}
				else if (bar.Int32_0 == 0)
				{
					array5[bar.DockLine]++;
				}
				else
				{
					array4[bar.DockLine] += bar.Int32_0;
				}
			}
			if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() > 0 && ((Control)this).get_Controls().get_Item(0) is Bar && ((Bar)(object)((Control)this).get_Controls().get_Item(0)).LayoutType == eLayoutType.Toolbar && (((Bar)(object)((Control)this).get_Controls().get_Item(0)).Style == eDotNetBarStyle.Office2003 || ((Bar)(object)((Control)this).get_Controls().get_Item(0)).Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(((Bar)(object)((Control)this).get_Controls().get_Item(0)).Style)))
			{
				num2 = 2;
				num3 = 1;
			}
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			bool flag2 = false;
			int num7 = 0;
			int num8 = 0;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			do
			{
				num4 = 0;
				num5 = 0;
				num6 = 0;
				num7 = 0;
				num8 = 0;
				flag3 = false;
				arrayList = new ArrayList(((ArrangedElementCollection)((Control)this).get_Controls()).get_Count());
				if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() > 0)
				{
					dockInfo = ((Control)this).get_Controls().get_Item(0) as IDockInfo;
					num8 = dockInfo.DockLine;
				}
				bool flag6 = false;
				for (int j = 0; j < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count(); j++)
				{
					val2 = ((Control)this).get_Controls().get_Item(j);
					dockInfo = val2 as IDockInfo;
					bar = val2 as Bar;
					flag2 = false;
					if (dockInfo != null && val2.get_Visible())
					{
						flag4 = false;
						if (eOrientation_0 == eOrientation.Horizontal)
						{
							if (flag5)
							{
								num6 += num4 + num3;
								num5 = 0;
								num4 = 0;
								flag5 = false;
							}
							Size size_ = Size.Empty;
							Size size = ((bar.LayoutType != 0) ? new Size(1, 1) : bar.method_134(dockInfo.MinimumDockSize(eOrientation_0)));
							if (!bar.Stretch && (j <= 0 || ((num5 + val2.get_Width() <= ((Control)this).get_Width() || size.Width + num5 <= ((Control)this).get_Width()) && dockInfo.DockLine <= num8)))
							{
								size_ = new Size(((Control)this).get_Width() - num5, 1);
							}
							else if (bar.Stretch && bar.LayoutType == eLayoutType.DockContainer && bar.DockLine >= 0 && array[bar.DockLine] > 0)
							{
								if (array[bar.DockLine] == 1)
								{
									bar.Int32_1 = 0;
								}
								size_ = ((bar.Int32_1 != 0 && (array2[bar.DockLine] != 1 || array4[bar.DockLine] == ((Control)this).get_Width())) ? new Size(bar.Int32_1, 1) : ((array2[bar.DockLine] != 1) ? new Size((((Control)this).get_Width() - array4[bar.DockLine]) / ((array5[bar.DockLine] == 0) ? 1 : array5[bar.DockLine]), 1) : new Size(((Control)this).get_Width() - num5, 1)));
								if (num8 != dockInfo.DockLine && array2[bar.DockLine] == array[bar.DockLine] && num5 > 0)
								{
									num8 = dockInfo.DockLine;
									num7++;
									num6 += num4 + num3;
									num5 = 0;
									num4 = 0;
									if (array[bar.DockLine] == 1 || size_.IsEmpty)
									{
										size_ = new Size(((Control)this).get_Width(), 1);
									}
								}
								array2[bar.DockLine]--;
								flag2 = true;
								arrayList.Add(bar);
							}
							else
							{
								size_ = new Size(((Control)this).get_Width(), 1);
							}
							bar.method_27(size_);
							if (j > 0 && dockInfo.DockLine > num8 && num5 > 0)
							{
								if (flag2)
								{
									array[bar.DockLine] = 0;
									array2[bar.DockLine] = 0;
									flag3 = true;
									break;
								}
								flag = ((dockInfo.DockLine <= num8) ? true : false);
								num8 = dockInfo.DockLine;
								num7++;
								num6 += num4 + num3;
								num5 = 0;
								num4 = 0;
								if (flag)
								{
									dockInfo.DockOffset = 0;
								}
								if (dockInfo.DockOffset > 0)
								{
									num5 = ((dockInfo.DockOffset + val2.get_Width() <= ((Control)this).get_Width()) ? dockInfo.DockOffset : (((Control)this).get_Width() - val2.get_Width()));
									if (num5 < 0)
									{
										num5 = 0;
									}
								}
							}
							else
							{
								if (num8 != dockInfo.DockLine)
								{
									num8 = dockInfo.DockLine;
									if (flag6)
									{
										num7++;
									}
								}
								if (flag)
								{
									dockInfo.DockOffset = 0;
								}
								if (!dockInfo.Stretch)
								{
									if (dockInfo.DockOffset > num5 && dockInfo.DockOffset + val2.get_Width() <= ((Control)this).get_Width())
									{
										num5 = dockInfo.DockOffset;
									}
									else if (dockInfo.DockOffset > num5 && ((Control)this).get_Width() - val2.get_Width() > num5)
									{
										num5 = ((Control)this).get_Width() - val2.get_Width();
									}
								}
							}
							if (num5 + val2.get_Width() > ((Control)this).get_Width())
							{
								if (bar != null)
								{
									bar.method_27(new Size(((Control)this).get_Width() - num5, ((Control)bar).get_Height()));
								}
								else
								{
									val2.set_Width(((Control)this).get_Width() - num5);
								}
								dockInfo.DockOffset = 0;
							}
							val2.set_Location(new Point(num5, num6));
							num5 += val2.get_Width() + num2;
							if (flag || dockInfo.DockLine != num7)
							{
								dockInfo.DockOffset = val2.get_Left();
							}
							if (val2.get_Height() > num4)
							{
								num4 = val2.get_Height();
							}
							if (bar != null && bar.ItemsContainer.HeightInternal > array3[num7])
							{
								array3[num7] = bar.ItemsContainer.HeightInternal;
							}
							if (dockInfo.Stretch)
							{
								if (bar.LayoutType == eLayoutType.DockContainer && bar.DockLine >= 0 && array2[bar.DockLine] > 0)
								{
									dockInfo.SetDockLine(num7);
								}
								else
								{
									dockInfo.SetDockLine(num7);
									num8 = dockInfo.DockLine;
									num7++;
									flag4 = true;
									num6 += num4 + num3;
									num5 = 0;
									num4 = 0;
								}
							}
							else
							{
								dockInfo.SetDockLine(num7);
							}
						}
						else
						{
							if (flag5)
							{
								num5 += num4 + num3;
								num6 = 0;
								num4 = 0;
								flag5 = false;
							}
							Size size_2 = Size.Empty;
							Size size = new Size(1, 1);
							if (!bar.Stretch && (j <= 0 || ((num6 + val2.get_Height() <= ((Control)this).get_Height() || size.Height + num6 <= ((Control)this).get_Height()) && dockInfo.DockLine <= num8)))
							{
								size_2 = new Size(1, ((Control)this).get_Height() - num6);
							}
							else if (bar.Stretch && bar.LayoutType == eLayoutType.DockContainer && bar.DockLine >= 0 && array[bar.DockLine] > 0)
							{
								if (array[bar.DockLine] == 1)
								{
									bar.Int32_0 = 0;
								}
								size_2 = ((bar.Int32_0 != 0 && (array2[bar.DockLine] != 1 || array4[bar.DockLine] == ((Control)this).get_Height())) ? new Size(1, bar.Int32_0) : ((array2[bar.DockLine] != 1) ? new Size(1, (((Control)this).get_Height() - array4[bar.DockLine]) / ((array5[bar.DockLine] == 0) ? 1 : array5[bar.DockLine])) : new Size(1, ((Control)this).get_Height() - num6)));
								if (num8 != dockInfo.DockLine && array2[bar.DockLine] == array[bar.DockLine] && num6 > 0)
								{
									num8 = dockInfo.DockLine;
									num7++;
									num5 += num4 + num3;
									num6 = 0;
									num4 = 0;
									size_2 = new Size(1, ((Control)this).get_Height());
								}
								array2[bar.DockLine]--;
								flag2 = true;
								arrayList.Add(bar);
							}
							else
							{
								size_2 = new Size(1, ((Control)this).get_Height());
							}
							bar.method_27(size_2);
							if (j > 0 && dockInfo.DockLine > num8 && num6 > 0)
							{
								if (flag2)
								{
									array[bar.DockLine] = 0;
									array2[bar.DockLine] = 0;
									flag3 = true;
									break;
								}
								flag = ((dockInfo.DockLine <= num8) ? true : false);
								num8 = dockInfo.DockLine;
								num7++;
								num5 += num4 + num3;
								num6 = 0;
								num4 = 0;
								if (flag)
								{
									dockInfo.DockOffset = 0;
								}
								if (dockInfo.DockOffset > 0)
								{
									num6 = ((dockInfo.DockOffset + val2.get_Height() <= ((Control)this).get_Height()) ? dockInfo.DockOffset : (((Control)this).get_Height() - val2.get_Height()));
									if (num6 < 0)
									{
										num6 = 0;
									}
								}
							}
							else
							{
								if (num8 != dockInfo.DockLine)
								{
									num8 = dockInfo.DockLine;
								}
								if (flag)
								{
									dockInfo.DockOffset = 0;
								}
								if (!dockInfo.Stretch)
								{
									if (dockInfo.DockOffset > num6 && dockInfo.DockOffset + val2.get_Height() <= ((Control)this).get_Height())
									{
										num6 = dockInfo.DockOffset;
									}
									else if (dockInfo.DockOffset > num6 && ((Control)this).get_Height() - val2.get_Height() > num6)
									{
										num6 = ((Control)this).get_Height() - val2.get_Height();
									}
								}
							}
							if (num6 + val2.get_Height() > ((Control)this).get_Height())
							{
								if (bar != null)
								{
									bar.method_27(new Size(((Control)bar).get_Width(), ((Control)this).get_Height() - num6));
								}
								else
								{
									val2.set_Height(((Control)this).get_Height() - num6);
								}
								dockInfo.DockOffset = 0;
							}
							val2.set_Location(new Point(num5, num6));
							num6 += val2.get_Height() + num2;
							if (flag || dockInfo.DockLine != num7)
							{
								dockInfo.DockOffset = val2.get_Top();
							}
							if (val2.get_Width() > num4)
							{
								num4 = val2.get_Width();
							}
							if (bar != null && bar.ItemsContainer.WidthInternal > array3[num7])
							{
								array3[num7] = bar.ItemsContainer.WidthInternal;
							}
							if (dockInfo.Stretch)
							{
								if (bar.LayoutType == eLayoutType.DockContainer && bar.DockLine >= 0 && array2[bar.DockLine] > 0)
								{
									dockInfo.SetDockLine(num7);
								}
								else
								{
									dockInfo.SetDockLine(num7);
									num8 = dockInfo.DockLine;
									num7++;
									num5 += num4 + num3;
									num6 = 0;
									num4 = 0;
								}
							}
							else
							{
								dockInfo.SetDockLine(num7);
							}
						}
						flag6 = false;
						continue;
					}
					if (bar != null && dockInfo.DockLine > num8)
					{
						num8 = dockInfo.DockLine;
						if (!flag4)
						{
							num7++;
							flag5 = true;
						}
					}
					flag6 = true;
				}
			}
			while (flag3);
			foreach (Bar item in arrayList)
			{
				if (eOrientation_0 == eOrientation.Horizontal)
				{
					if (item.ItemsContainer.HeightInternal != array3[item.DockLine])
					{
						item.ItemsContainer.Int32_1 = array3[item.DockLine];
						Size size_3 = new Size(((Control)item).get_Width(), 1);
						item.method_27(size_3);
					}
				}
				else if (item.ItemsContainer.WidthInternal != array3[item.DockLine])
				{
					item.ItemsContainer.Int32_2 = array3[item.DockLine];
					Size size_4 = new Size(1, ((Control)item).get_Height());
					item.method_27(size_4);
				}
			}
			if (eOrientation_0 == eOrientation.Horizontal)
			{
				if (((Control)this).get_Height() != num6 + num4)
				{
					((Control)this).set_Height(num6 + num4);
					if (((Control)this).get_Parent() != null)
					{
						((Control)this).get_Parent().PerformLayout((Control)(object)this, "Height");
					}
					((Control)this).Invalidate();
				}
			}
			else if (((Control)this).get_Width() != num5 + num4)
			{
				((Control)this).set_Width(num5 + num4);
				if (((Control)this).get_Parent() != null)
				{
					((Control)this).get_Parent().PerformLayout((Control)(object)this, "Width");
				}
				((Control)this).Invalidate();
			}
			if (!bool_1)
			{
				if (((int)((Control)this).get_Dock() == 4 && ((Control)this).get_Location().X < 0) || ((int)((Control)this).get_Dock() == 3 && ((Control)this).get_Parent() != null && ((Control)this).get_Right() > ((Control)this).get_Parent().get_Width()) || ((int)((Control)this).get_Dock() == 1 && ((Control)this).get_Parent() != null && ((Control)this).get_Bottom() > ((Control)this).get_Parent().get_Height()) || ((int)((Control)this).get_Dock() == 2 && ((Control)this).get_Location().Y < 0))
				{
					bool_1 = true;
					bool_0 = false;
					method_10();
					if (bool_1)
					{
						bool_1 = false;
					}
				}
			}
			else
			{
				bool_1 = false;
			}
			if (((Control)this).get_Parent() != null && ((Control)this).get_Parent().get_Visible() && bool_7)
			{
				Class92.SendMessage(((Control)this).get_Handle(), 11, 1, 0);
				if (num != -1)
				{
					((Control)this).get_Parent().get_Controls().SetChildIndex((Control)(object)this, num);
				}
				((Control)this).get_Parent().Invalidate(bounds, true);
				((Control)this).get_Parent().Invalidate(((Control)this).get_Bounds(), true);
				((Control)this).get_Parent().Update();
			}
			bool_0 = false;
			return;
		}
		Rectangle bounds2 = ((Control)this).get_Bounds();
		if (((Control)this).get_Parent() != null && ((Control)this).get_Parent().get_Visible() && bool_7)
		{
			if (((Control)this).get_Parent() != null)
			{
				num = ((Control)this).get_Parent().get_Controls().IndexOf((Control)(object)this);
			}
			Class92.SendMessage(((Control)this).get_Handle(), 11, 0, 0);
		}
		if (documentDockContainer_0 != null)
		{
			if ((int)((Control)this).get_Dock() != 5)
			{
				documentDockContainer_0.RecordDocumentSize = true;
			}
			documentDockContainer_0.Layout(method_7());
			if ((int)((Control)this).get_Dock() != 5 && documentDockContainer_0.DisplayBounds.IsEmpty)
			{
				if ((int)((Control)this).get_Dock() != 3 && (int)((Control)this).get_Dock() != 4)
				{
					((Control)this).set_Height(0);
				}
				else
				{
					((Control)this).set_Width(0);
				}
			}
		}
		bool_0 = false;
		if (((Control)this).get_Parent() != null && ((Control)this).get_Parent().get_Visible() && bool_7)
		{
			Class92.SendMessage(((Control)this).get_Handle(), 11, 1, 0);
			((Control)this).get_Parent().Invalidate(((((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0) || bounds2.Width <= 0 || bounds2.Height <= 0) ? ((Control)this).get_Bounds() : bounds2, true);
			((Control)this).get_Parent().Update();
		}
		if (num != -1)
		{
			((Control)this).get_Parent().get_Controls().SetChildIndex((Control)(object)this, num);
		}
	}

	protected override void OnParentChanged(EventArgs e)
	{
		((Control)this).OnParentChanged(e);
		Control val = (Control)(object)((Control)this).FindForm();
		if (val != null)
		{
			val.add_Resize((EventHandler)method_9);
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		Control parent = ((Control)this).get_Parent();
		if ((parent == null || (parent.get_Width() != 0 && parent.get_Height() != 0)) && (parent == null || !(parent is Form) || (int)((Form)parent).get_WindowState() != 1))
		{
			method_10();
		}
	}

	private void method_10()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		if ((int)((Control)this).get_Dock() == 5 || (int)((Control)this).get_Dock() == 0 || documentDockContainer_0 == null || ((Control)this).get_Width() == 0 || ((Control)this).get_Height() == 0 || (((Control)this).get_Parent() != null && (((Control)this).get_Parent().get_Width() == 0 || ((Control)this).get_Parent().get_Height() == 0)))
		{
			return;
		}
		bool flag;
		int num = ((flag = (int)((Control)this).get_Dock() == 4 || (int)((Control)this).get_Dock() == 3) ? method_11() : method_12());
		int num2 = 32;
		if (dotNetBarManager_0 != null)
		{
			num2 = (flag ? dotNetBarManager_0.MinimumClientSize.Width : dotNetBarManager_0.MinimumClientSize.Height);
		}
		if (num > num2)
		{
			if (int_1 <= 0)
			{
				return;
			}
			int num3 = int_1 - (flag ? ((Control)this).get_Width() : ((Control)this).get_Height());
			if (num - num3 < num2)
			{
				num3 -= num2 - (num - num3);
			}
			if (num3 > 0)
			{
				if (flag)
				{
					((Control)this).set_Width(((Control)this).get_Width() + num3);
				}
				else
				{
					((Control)this).set_Height(((Control)this).get_Height() + num3);
				}
			}
			if ((flag && ((Control)this).get_Width() >= int_1) || (!flag && ((Control)this).get_Height() >= int_1))
			{
				int_1 = 0;
			}
			return;
		}
		GetDocumentUIManager().RootDocumentDockContainer.method_6();
		DocumentDockUIManager documentUIManager = GetDocumentUIManager();
		Size size = documentUIManager.method_20(documentUIManager.RootDocumentDockContainer);
		int num4 = (flag ? size.Width : size.Height);
		int num5 = num2 - num;
		if ((flag && ((Control)this).get_Width() - num5 < num4) || (!flag && ((Control)this).get_Height() - num5 < num4))
		{
			num5 = (flag ? ((Control)this).get_Width() : ((Control)this).get_Height()) - num4;
		}
		if (num5 > 0)
		{
			if (int_1 == 0)
			{
				int_1 = (flag ? ((Control)this).get_Width() : ((Control)this).get_Height());
			}
			if (flag)
			{
				((Control)this).set_Width(((Control)this).get_Width() - num5);
			}
			else
			{
				((Control)this).set_Height(((Control)this).get_Height() - num5);
			}
		}
	}

	protected override void OnResize(EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		((Control)this).OnResize(e);
		if (!bool_0)
		{
			Control parent = ((Control)this).get_Parent();
			if ((parent == null || (parent.get_Width() != 0 && parent.get_Height() != 0)) && (parent == null || !(parent is Form) || (int)((Form)parent).get_WindowState() != 1) && parent != null && ((dotNetBarManager_0 != null && dotNetBarManager_0.ParentForm != null && (int)dotNetBarManager_0.ParentForm.get_WindowState() != 1) || dotNetBarManager_0 == null || dotNetBarManager_0.ParentForm == null))
			{
				((Control)this).Invalidate(((Control)this).get_Region(), false);
				method_8();
			}
		}
	}

	internal int method_11()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		if (((Control)this).get_Parent() == null)
		{
			return 0;
		}
		Control parent = ((Control)this).get_Parent();
		int num = parent.get_ClientSize().Width;
		foreach (Control item in (ArrangedElementCollection)parent.get_Controls())
		{
			Control val = item;
			if (val.get_Visible() && ((int)val.get_Dock() == 3 || (int)val.get_Dock() == 4))
			{
				num -= val.get_Width();
			}
		}
		return num;
	}

	internal int method_12()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		if (((Control)this).get_Parent() == null)
		{
			return 0;
		}
		Control parent = ((Control)this).get_Parent();
		int num = parent.get_ClientSize().Height;
		foreach (Control item in (ArrangedElementCollection)parent.get_Controls())
		{
			Control val = item;
			if (val.get_Visible() && ((int)val.get_Dock() == 1 || (int)val.get_Dock() == 2))
			{
				num -= val.get_Height();
			}
		}
		return num;
	}

	private int method_13(int int_2, int int_3, bool bool_8)
	{
		int num = 0;
		int num2 = 0;
		if (bool_8)
		{
			for (num2 = int_2; num2 < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count(); num2++)
			{
				if (((Control)this).get_Controls().get_Item(num2).get_Visible())
				{
					IDockInfo dockInfo = ((Control)this).get_Controls().get_Item(num2) as IDockInfo;
					if (dockInfo.DockLine != int_3)
					{
						break;
					}
					num += ((Control)this).get_Controls().get_Item(num2).get_Width();
				}
			}
		}
		else
		{
			for (num2 = int_2; num2 >= 0; num2--)
			{
				if (((Control)this).get_Controls().get_Item(num2).get_Visible())
				{
					IDockInfo dockInfo = ((Control)this).get_Controls().get_Item(num2) as IDockInfo;
					if (dockInfo.DockLine != int_3)
					{
						break;
					}
					num += ((Control)this).get_Controls().get_Item(num2).get_Width();
				}
			}
		}
		return num;
	}

	private int method_14(int int_2, int int_3, bool bool_8)
	{
		int num = 0;
		int num2 = 0;
		if (bool_8)
		{
			for (num2 = int_2; num2 < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count(); num2++)
			{
				if (((Control)this).get_Controls().get_Item(num2).get_Visible())
				{
					IDockInfo dockInfo = ((Control)this).get_Controls().get_Item(num2) as IDockInfo;
					if (dockInfo.DockLine != int_3)
					{
						break;
					}
					num += ((Control)this).get_Controls().get_Item(num2).get_Height();
				}
			}
		}
		else
		{
			for (num2 = int_2; num2 >= 0; num2--)
			{
				if (((Control)this).get_Controls().get_Item(num2).get_Visible())
				{
					IDockInfo dockInfo = ((Control)this).get_Controls().get_Item(num2) as IDockInfo;
					if (dockInfo.DockLine != int_3)
					{
						break;
					}
					num += ((Control)this).get_Controls().get_Item(num2).get_Height();
				}
			}
		}
		return num;
	}

	public DockSiteInfo GetDockSiteInfo(IDockInfo pDock, int x, int y)
	{
		if (eOrientation_0 == eOrientation.Horizontal)
		{
			return method_15(pDock, x, y);
		}
		return method_16(pDock, x, y);
	}

	private DockSiteInfo method_15(IDockInfo idockInfo_0, int int_2, int int_3)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Invalid comparison between Unknown and I4
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Invalid comparison between Unknown and I4
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Invalid comparison between Unknown and I4
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Invalid comparison between Unknown and I4
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b84: Unknown result type (might be due to invalid IL or missing references)
		DockSiteInfo result = default(DockSiteInfo);
		Rectangle rectangle = new Rectangle(((Control)this).PointToScreen(new Point(0, 0)), ((Control)this).get_Size());
		Point pt = ((Control)this).PointToClient(new Point(int_2, int_3));
		Control val = (Control)((idockInfo_0 is Control) ? idockInfo_0 : null);
		Size size = idockInfo_0.PreferredDockSize(eOrientation_0);
		idockInfo_0.MinimumDockSize(eOrientation_0);
		if (((Control)this).get_Height() == 0)
		{
			rectangle.Height = 10;
			if ((int)((Control)this).get_Dock() == 2)
			{
				rectangle.Y -= 10;
			}
		}
		else if (((Control)this).get_Width() == 0)
		{
			rectangle.Width = ((Control)this).get_TopLevelControl().get_Width();
			if ((int)((Control)this).get_Dock() == 4)
			{
				rectangle.X -= 10;
			}
		}
		rectangle.Inflate(8, 8);
		if (rectangle.Contains(int_2, int_3) && idockInfo_0 != null)
		{
			bool flag = idockInfo_0.DockedSite == this;
			int[] array = new int[255];
			int num = 0;
			int num2 = -10;
			bool flag2 = false;
			foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
			{
				Control val2 = item;
				if (val2.get_Visible())
				{
					IDockInfo dockInfo = val2 as IDockInfo;
					array[dockInfo.DockLine]++;
					num = dockInfo.DockLine;
				}
			}
			int num3 = -1;
			int num4 = 0;
			while (true)
			{
				if (num4 < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count())
				{
					Control val3 = ((Control)this).get_Controls().get_Item(num4);
					if (!val3.get_Visible())
					{
						goto IL_032e;
					}
					IDockInfo dockInfo2 = val3 as IDockInfo;
					if (dockInfo2.LockDockPosition && val is Bar && !((Bar)(object)val3).CanUndock)
					{
						if ((int)((Control)this).get_Dock() == 1)
						{
							num3 = dockInfo2.DockLine;
						}
						else if (num3 == -1)
						{
							num3 = dockInfo2.DockLine;
						}
					}
					if (pt.Y <= val3.get_Top() + 4 || ((pt.Y >= val3.get_Top() + size.Height - 4 || size.Height > val3.get_Height()) && (pt.Y >= val3.get_Bottom() - 4 || size.Height <= val3.get_Height())))
					{
						if (val3 != val || pt.Y > val3.get_Top() + 4 || pt.Y <= val3.get_Top() || array[dockInfo2.DockLine] <= 1)
						{
							if ((int)((Control)this).get_Dock() == 1 && val3 == val && pt.Y >= val3.get_Bottom() - 4 && pt.Y < val3.get_Bottom() - 1 && array[dockInfo2.DockLine] == 1 && idockInfo_0.DockLine != num)
							{
								break;
							}
							goto IL_032e;
						}
						int insertPosition = num4;
						int num5 = num4 - 1;
						while (num5 >= 0 && ((IDockInfo)((Control)this).get_Controls().get_Item(num5)).DockLine == idockInfo_0.DockLine)
						{
							insertPosition = num5;
							num5--;
						}
						result.DockLine = idockInfo_0.DockLine;
						result.DockOffset = idockInfo_0.DockOffset;
						result.InsertPosition = insertPosition;
						result.objDockSite = this;
						result.DockSide = ((Control)this).get_Dock();
						result.NewLine = true;
						return result;
					}
					if (dockInfo2.Stretch && val3 != val)
					{
						if (val3 is Bar && val is Bar && ((Bar)(object)val3).LayoutType == eLayoutType.DockContainer && ((Bar)(object)val).LayoutType == eLayoutType.DockContainer && ((Bar)(object)val3).CanTearOffTabs)
						{
							if (!val3.get_Bounds().Contains(pt))
							{
								goto IL_032e;
							}
							num2 = dockInfo2.DockLine;
							if (((Bar)(object)val3).method_92(int_2, int_3))
							{
								result.DockLine = dockInfo2.DockLine;
								result.DockOffset = dockInfo2.DockOffset;
								result.InsertPosition = num4;
								result.objDockSite = this;
								result.DockSide = ((Control)this).get_Dock();
								result.TabDockContainer = val3 as Bar;
								return result;
							}
						}
						else
						{
							num2 = dockInfo2.DockLine - 1;
						}
					}
					else
					{
						if (val3 != val && val is Bar && ((Bar)(object)val).Stretch)
						{
							int insertPosition2 = num4;
							int num6 = num4 - 1;
							while (num6 >= 0 && ((IDockInfo)((Control)this).get_Controls().get_Item(num6)).DockLine == idockInfo_0.DockLine)
							{
								insertPosition2 = num6;
								num6--;
							}
							result.DockLine = idockInfo_0.DockLine;
							result.DockOffset = idockInfo_0.DockOffset;
							result.InsertPosition = insertPosition2;
							result.objDockSite = this;
							result.DockSide = ((Control)this).get_Dock();
							result.NewLine = true;
							return result;
						}
						num2 = dockInfo2.DockLine;
					}
				}
				if (num2 == -10)
				{
					if (pt.Y <= -5 && (!flag || idockInfo_0.DockLine != 0 || array[0] != 1))
					{
						num2 = -1;
					}
					else if (!flag)
					{
						num2 = ((pt.Y <= ((Control)this).get_Height()) ? num : (num + 1));
					}
					else if (pt.Y > ((Control)this).get_Height() + 4 && (!flag || idockInfo_0.DockLine != num || array[num] != 1))
					{
						num2 = num + 1;
					}
					if (num2 == -10)
					{
						result.DockLine = idockInfo_0.DockLine;
						result.DockOffset = idockInfo_0.DockOffset;
						result.InsertPosition = ((Control)this).get_Controls().GetChildIndex(val);
						result.objDockSite = this;
						result.DockSide = ((Control)this).get_Dock();
						return result;
					}
				}
				if (num3 != -1)
				{
					if ((int)((Control)this).get_Dock() == 1 && num2 <= num3)
					{
						num2 = num3 + 1;
					}
					else if ((int)((Control)this).get_Dock() == 2 && num2 >= num3)
					{
						num2 = num3 - 1;
					}
				}
				int num7 = ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count();
				for (int i = 0; i < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count(); i++)
				{
					Control val4 = ((Control)this).get_Controls().get_Item(i);
					if (val4.get_Visible())
					{
						IDockInfo dockInfo3 = val4 as IDockInfo;
						if (dockInfo3.DockLine >= num2)
						{
							num7 = i;
							break;
						}
					}
				}
				for (int j = num7; j < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count(); j++)
				{
					Control val5 = ((Control)this).get_Controls().get_Item(j);
					if (!val5.get_Visible())
					{
						continue;
					}
					IDockInfo dockInfo4 = val5 as IDockInfo;
					if (dockInfo4.DockLine <= num2)
					{
						if (!val5.get_Bounds().Contains(pt))
						{
							if (pt.X < val5.get_Left() || (pt.Y < val5.get_Top() && num3 < 0))
							{
								result.InsertPosition = j;
								if (flag && j > 0 && ((Control)this).get_Controls().GetChildIndex(val) < j)
								{
									result.InsertPosition = j - 1;
								}
								if (idockInfo_0.Stretch)
								{
									result.DockOffset = idockInfo_0.DockOffset;
								}
								else
								{
									result.DockOffset = pt.X;
								}
								result.DockLine = num2;
								result.DockSide = ((Control)this).get_Dock();
								result.objDockSite = this;
								flag2 = true;
								break;
							}
							continue;
						}
						if (val5 != val)
						{
							if (pt.X >= val5.get_Left() && pt.X <= val5.get_Left() + 10)
							{
								result.InsertPosition = j;
								if (flag && j > 0 && ((Control)this).get_Controls().GetChildIndex(val) < j)
								{
									result.InsertPosition = j - 1;
								}
								result.DockOffset = 0;
								result.DockLine = num2;
								result.DockSide = ((Control)this).get_Dock();
								result.objDockSite = this;
							}
							else
							{
								int num8 = method_13(j, num2, bool_8: false);
								if (num8 + size.Width < ((Control)this).get_Width() && pt.X >= num8)
								{
									result.DockOffset = pt.X;
								}
								else
								{
									result.DockOffset = val5.get_Right();
								}
								result.InsertPosition = j + 1;
								if (idockInfo_0.Stretch)
								{
									result.DockOffset = idockInfo_0.DockOffset;
								}
								if (flag && j > 0 && ((Control)this).get_Controls().GetChildIndex(val) < j)
								{
									result.InsertPosition = j;
								}
								result.DockLine = num2;
								result.DockSide = ((Control)this).get_Dock();
								result.objDockSite = this;
							}
						}
						else
						{
							result.InsertPosition = j;
							result.DockLine = num2;
							result.DockSide = ((Control)this).get_Dock();
							result.objDockSite = this;
							int num9 = method_13(j + 1, idockInfo_0.DockLine, bool_8: true);
							if (num9 + size.Width + pt.X >= ((Control)this).get_Width())
							{
								result.DockOffset = ((Control)this).get_Width() - num9 - size.Width;
							}
							else
							{
								result.DockOffset = pt.X;
							}
							if (result.DockOffset < 0)
							{
								result.DockOffset = 0;
							}
						}
						flag2 = true;
						break;
					}
					result.InsertPosition = j;
					if (flag && j > 0 && ((Control)this).get_Controls().GetChildIndex(val) < j)
					{
						result.InsertPosition = j - 1;
					}
					if (pt.X + size.Width > ((Control)this).get_Width())
					{
						result.DockOffset = ((Control)this).get_Width() - size.Width;
					}
					else
					{
						result.DockOffset = pt.X;
					}
					result.DockLine = num2;
					result.DockSide = ((Control)this).get_Dock();
					result.objDockSite = this;
					flag2 = true;
					break;
				}
				if (!flag2)
				{
					if (num2 >= 0)
					{
						if (flag)
						{
							result.InsertPosition = ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() - 1;
						}
						else
						{
							result.InsertPosition = ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count();
						}
					}
					else
					{
						result.InsertPosition = 0;
					}
					if (pt.X + size.Width > ((Control)this).get_Width())
					{
						result.DockOffset = ((Control)this).get_Width() - size.Width;
					}
					else
					{
						result.DockOffset = pt.X;
					}
					if (num2 >= 0)
					{
						result.DockLine = num2;
					}
					else
					{
						result.DockLine = -1;
					}
					result.DockSide = ((Control)this).get_Dock();
					result.objDockSite = this;
				}
				if (result.DockOffset < 10)
				{
					result.DockOffset = 0;
				}
				if (eOrientation_0 == eOrientation.Horizontal)
				{
					if (size.Width > ((Control)this).get_Width())
					{
						result.DockedWidth = ((Control)this).get_Width();
					}
					else
					{
						result.DockedWidth = size.Width;
					}
					result.DockedHeight = size.Height;
				}
				else
				{
					if (size.Height > ((Control)this).get_Height())
					{
						result.DockedHeight = ((Control)this).get_Height();
					}
					else
					{
						result.DockedHeight = size.Height;
					}
					result.DockedWidth = size.Width;
				}
				return result;
				IL_032e:
				num4++;
			}
			int insertPosition3 = num4;
			for (int k = num4 + 1; k < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() && ((((IDockInfo)((Control)this).get_Controls().get_Item(k)).DockLine == idockInfo_0.DockLine + 1 && (((IDockInfo)((Control)this).get_Controls().get_Item(k)).DockOffset <= idockInfo_0.DockOffset || idockInfo_0.Stretch)) || ((IDockInfo)((Control)this).get_Controls().get_Item(k)).DockLine == idockInfo_0.DockLine); k++)
			{
				insertPosition3 = k;
			}
			result.DockLine = idockInfo_0.DockLine + 1;
			result.DockOffset = idockInfo_0.DockOffset;
			result.InsertPosition = insertPosition3;
			result.objDockSite = this;
			result.DockSide = ((Control)this).get_Dock();
			return result;
		}
		return result;
	}

	private DockSiteInfo method_16(IDockInfo idockInfo_0, int int_2, int int_3)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Invalid comparison between Unknown and I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Invalid comparison between Unknown and I4
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Invalid comparison between Unknown and I4
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		DockSiteInfo result = default(DockSiteInfo);
		Rectangle rectangle = new Rectangle(((Control)this).PointToScreen(new Point(0, 0)), ((Control)this).get_Size());
		Point pt = ((Control)this).PointToClient(new Point(int_2, int_3));
		Control val = (Control)((idockInfo_0 is Control) ? idockInfo_0 : null);
		Size size = idockInfo_0.PreferredDockSize(eOrientation_0);
		if (((Control)this).get_Height() == 0)
		{
			rectangle.Height = 10;
			if ((int)((Control)this).get_Dock() == 2)
			{
				rectangle.Y -= 10;
			}
		}
		else if (((Control)this).get_Width() == 0)
		{
			rectangle.Width = 10;
			if ((int)((Control)this).get_Dock() == 4)
			{
				rectangle.X -= 10;
			}
		}
		rectangle.Inflate(8, 8);
		if (rectangle.Contains(int_2, int_3) && idockInfo_0 != null)
		{
			bool flag = idockInfo_0.DockedSite == this;
			int[] array = new int[255];
			int num = 0;
			int num2 = -10;
			bool flag2 = false;
			foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
			{
				Control val2 = item;
				if (val2.get_Visible())
				{
					IDockInfo dockInfo = val2 as IDockInfo;
					array[dockInfo.DockLine]++;
					num = dockInfo.DockLine;
				}
			}
			int num3 = -1;
			int num4 = 0;
			while (true)
			{
				if (num4 < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count())
				{
					Control val3 = ((Control)this).get_Controls().get_Item(num4);
					if (!val3.get_Visible())
					{
						goto IL_02d5;
					}
					IDockInfo dockInfo2 = val3 as IDockInfo;
					if (pt.X <= val3.get_Left() + 4 || ((pt.X >= val3.get_Left() + size.Width - 4 || size.Width > val3.get_Width()) && (pt.X >= val3.get_Right() - 4 || size.Width <= val3.get_Width())))
					{
						if (val3 != val || pt.X > val3.get_Left() + 4 || pt.X <= val3.get_Left() || array[dockInfo2.DockLine] <= 1)
						{
							if ((int)((Control)this).get_Dock() == 3 && val3 == val && pt.X >= val3.get_Right() - 4 && pt.X < val3.get_Right() && array[dockInfo2.DockLine] == 1 && idockInfo_0.DockLine != num)
							{
								break;
							}
							goto IL_02d5;
						}
						int insertPosition = num4;
						int num5 = num4 - 1;
						while (num5 >= 0 && ((IDockInfo)((Control)this).get_Controls().get_Item(num5)).DockLine == idockInfo_0.DockLine)
						{
							insertPosition = num5;
							num5--;
						}
						result.DockLine = idockInfo_0.DockLine;
						result.DockOffset = idockInfo_0.DockOffset;
						result.InsertPosition = insertPosition;
						result.objDockSite = this;
						result.DockSide = ((Control)this).get_Dock();
						result.NewLine = true;
						return result;
					}
					if (dockInfo2.Stretch && val3 != val)
					{
						if (val3 is Bar && val is Bar && ((Bar)(object)val3).LayoutType == eLayoutType.DockContainer && ((Bar)(object)val).LayoutType == eLayoutType.DockContainer && ((Bar)(object)val3).CanTearOffTabs)
						{
							if (!val3.get_Bounds().Contains(pt))
							{
								goto IL_02d5;
							}
							num2 = dockInfo2.DockLine;
							if (((Bar)(object)val3).method_92(int_2, int_3))
							{
								result.DockLine = dockInfo2.DockLine;
								result.DockOffset = dockInfo2.DockOffset;
								result.InsertPosition = num4;
								result.objDockSite = this;
								result.DockSide = ((Control)this).get_Dock();
								result.TabDockContainer = val3 as Bar;
								return result;
							}
						}
						else
						{
							num2 = dockInfo2.DockLine - 1;
						}
					}
					else
					{
						num2 = dockInfo2.DockLine;
					}
				}
				if (num2 == -10)
				{
					if (pt.X <= -5 && (!flag || idockInfo_0.DockLine != 0 || array[0] != 1))
					{
						num2 = -1;
					}
					else if (!flag)
					{
						num2 = ((pt.X <= ((Control)this).get_Width()) ? num : (num + 1));
					}
					else if (pt.X > ((Control)this).get_Width() + 4 && (!flag || idockInfo_0.DockLine != num || array[num] != 1))
					{
						num2 = num + 1;
					}
					if (num2 == -10)
					{
						result.DockLine = idockInfo_0.DockLine;
						result.DockOffset = idockInfo_0.DockOffset;
						result.InsertPosition = ((Control)this).get_Controls().GetChildIndex(val);
						result.objDockSite = this;
						result.DockSide = ((Control)this).get_Dock();
						return result;
					}
				}
				if (num3 != -1)
				{
					if ((int)((Control)this).get_Dock() == 1 && num2 <= num3)
					{
						num2 = num3 + 1;
					}
					else if ((int)((Control)this).get_Dock() == 2 && num2 >= num3)
					{
						num2 = num3 - 1;
					}
				}
				int num6 = ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count();
				for (int i = 0; i < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count(); i++)
				{
					Control val4 = ((Control)this).get_Controls().get_Item(i);
					if (val4.get_Visible())
					{
						IDockInfo dockInfo3 = val4 as IDockInfo;
						if (dockInfo3.DockLine >= num2)
						{
							num6 = i;
							break;
						}
					}
				}
				for (int j = num6; j < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count(); j++)
				{
					Control val5 = ((Control)this).get_Controls().get_Item(j);
					if (!val5.get_Visible())
					{
						continue;
					}
					IDockInfo dockInfo4 = val5 as IDockInfo;
					if (dockInfo4.DockLine <= num2)
					{
						if (!val5.get_Bounds().Contains(pt))
						{
							if (pt.Y < val5.get_Top() || (pt.X < val5.get_Left() && num3 < 0))
							{
								result.InsertPosition = j;
								if (flag && j > 0 && ((Control)this).get_Controls().GetChildIndex(val) < j)
								{
									result.InsertPosition = j - 1;
								}
								if (idockInfo_0.Stretch)
								{
									result.DockOffset = idockInfo_0.DockOffset;
								}
								else
								{
									result.DockOffset = pt.Y;
								}
								result.DockLine = num2;
								result.DockSide = ((Control)this).get_Dock();
								result.objDockSite = this;
								flag2 = true;
								break;
							}
							continue;
						}
						if (val5 != val)
						{
							if (pt.Y >= val5.get_Top() && pt.Y <= val5.get_Top() + 10)
							{
								result.InsertPosition = j;
								if (flag && j > 0 && ((Control)this).get_Controls().GetChildIndex(val) < j)
								{
									result.InsertPosition = j - 1;
								}
								result.DockOffset = 0;
								result.DockLine = num2;
								result.DockSide = ((Control)this).get_Dock();
								result.objDockSite = this;
							}
							else
							{
								int num7 = method_14(j, num2, bool_8: false);
								if (num7 + size.Height < ((Control)this).get_Height() && pt.Y >= num7)
								{
									result.DockOffset = pt.Y;
								}
								else
								{
									result.DockOffset = val5.get_Bottom();
								}
								result.InsertPosition = j + 1;
								if (idockInfo_0.Stretch)
								{
									result.DockOffset = idockInfo_0.DockOffset;
								}
								if (flag && j > 0 && ((Control)this).get_Controls().GetChildIndex(val) < j)
								{
									result.InsertPosition = j;
								}
								result.DockLine = num2;
								result.DockSide = ((Control)this).get_Dock();
								result.objDockSite = this;
							}
						}
						else
						{
							result.InsertPosition = j;
							result.DockLine = num2;
							result.DockSide = ((Control)this).get_Dock();
							result.objDockSite = this;
							int num8 = method_14(j + 1, idockInfo_0.DockLine, bool_8: true);
							if (num8 + size.Height + pt.Y >= ((Control)this).get_Height())
							{
								result.DockOffset = ((Control)this).get_Height() - num8 - size.Height;
							}
							else
							{
								result.DockOffset = pt.Y;
							}
							if (result.DockOffset < 0)
							{
								result.DockOffset = 0;
							}
						}
						flag2 = true;
						break;
					}
					result.InsertPosition = j;
					if (flag && j > 0 && ((Control)this).get_Controls().GetChildIndex(val) < j)
					{
						result.InsertPosition = j - 1;
					}
					if (pt.Y + size.Height > ((Control)this).get_Height())
					{
						result.DockOffset = ((Control)this).get_Height() - size.Height;
					}
					else
					{
						result.DockOffset = pt.Y;
					}
					result.DockLine = num2;
					result.DockSide = ((Control)this).get_Dock();
					result.objDockSite = this;
					flag2 = true;
					break;
				}
				if (!flag2)
				{
					if (num2 >= 0)
					{
						if (flag)
						{
							result.InsertPosition = ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() - 1;
						}
						else
						{
							result.InsertPosition = ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count();
						}
					}
					else
					{
						result.InsertPosition = 0;
					}
					if (pt.Y + size.Height > ((Control)this).get_Height())
					{
						result.DockOffset = ((Control)this).get_Height() - size.Height;
					}
					else
					{
						result.DockOffset = pt.Y;
					}
					if (num2 >= 0)
					{
						result.DockLine = num2;
					}
					else
					{
						result.DockLine = -1;
					}
					result.DockSide = ((Control)this).get_Dock();
					result.objDockSite = this;
				}
				if (result.DockOffset < 10)
				{
					result.DockOffset = 0;
				}
				if (eOrientation_0 == eOrientation.Horizontal)
				{
					if (size.Width > ((Control)this).get_Width())
					{
						result.DockedWidth = ((Control)this).get_Width();
					}
					else
					{
						result.DockedWidth = size.Width;
					}
					result.DockedHeight = size.Height;
				}
				else
				{
					if (size.Height > ((Control)this).get_Height())
					{
						result.DockedHeight = ((Control)this).get_Height();
					}
					else
					{
						result.DockedHeight = size.Height;
					}
					result.DockedWidth = size.Width;
				}
				return result;
				IL_02d5:
				num4++;
			}
			int insertPosition2 = num4;
			for (int k = num4 + 1; k < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() && ((((IDockInfo)((Control)this).get_Controls().get_Item(k)).DockLine == idockInfo_0.DockLine + 1 && (((IDockInfo)((Control)this).get_Controls().get_Item(k)).DockOffset <= idockInfo_0.DockOffset || idockInfo_0.Stretch)) || ((IDockInfo)((Control)this).get_Controls().get_Item(k)).DockLine == idockInfo_0.DockLine); k++)
			{
				insertPosition2 = k;
			}
			result.DockLine = idockInfo_0.DockLine + 1;
			result.DockOffset = idockInfo_0.DockOffset;
			result.InsertPosition = insertPosition2;
			result.objDockSite = this;
			result.DockSide = ((Control)this).get_Dock();
			return result;
		}
		return result;
	}

	internal Rectangle method_17(Bar bar_0, ref DockSiteInfo dockSiteInfo_0)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected I4, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected I4, but got Unknown
		if (dockSiteInfo_0.objDockSite == null)
		{
			return Rectangle.Empty;
		}
		if ((int)((Control)dockSiteInfo_0.objDockSite).get_Dock() != 5 && documentDockContainer_0 == null)
		{
			Rectangle result = Rectangle.Empty;
			if (dockSiteInfo_0.InsertPosition < 0 && dockSiteInfo_0.NewLine)
			{
				dockSiteInfo_0.DockLine = -1;
			}
			else if (dockSiteInfo_0.InsertPosition >= ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() && dockSiteInfo_0.NewLine)
			{
				dockSiteInfo_0.DockLine = 999;
			}
			if (dockSiteInfo_0.TabDockContainer != null)
			{
				result = ((Control)dockSiteInfo_0.TabDockContainer).get_Bounds();
				result.Location = ((Control)this).PointToScreen(result.Location);
			}
			else if (dockSiteInfo_0.DockLine != 999 && dockSiteInfo_0.DockLine != -1)
			{
				Bar bar = null;
				if (dockSiteInfo_0.InsertPosition >= 0 && dockSiteInfo_0.InsertPosition < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count())
				{
					bar = ((Control)this).get_Controls().get_Item(dockSiteInfo_0.InsertPosition) as Bar;
					if (!dockSiteInfo_0.NewLine)
					{
						if (bar.DockLine > dockSiteInfo_0.DockLine)
						{
							int num = dockSiteInfo_0.InsertPosition - 1;
							while (num >= 0)
							{
								if (((Control)this).get_Controls().get_Item(num) is Bar bar2 && bar2.LayoutType == eLayoutType.DockContainer && bar2.DockLine == dockSiteInfo_0.DockLine)
								{
									bar = bar2;
									break;
								}
							}
						}
						else if (bar.DockLine < dockSiteInfo_0.DockLine)
						{
							int num2 = dockSiteInfo_0.InsertPosition + 1;
							while (num2 < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count())
							{
								if (((Control)this).get_Controls().get_Item(num2) is Bar bar3 && bar3.LayoutType == eLayoutType.DockContainer && bar3.DockLine == dockSiteInfo_0.DockLine)
								{
									bar = bar3;
									break;
								}
							}
						}
					}
				}
				else if (dockSiteInfo_0.InsertPosition < 0)
				{
					bar = ((Control)this).get_Controls().get_Item(0) as Bar;
				}
				else if (dockSiteInfo_0.InsertPosition >= ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count())
				{
					bar = ((Control)this).get_Controls().get_Item(((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() - 1) as Bar;
				}
				for (int i = dockSiteInfo_0.InsertPosition + 1; i < ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count(); i++)
				{
					if (bar_0 != null && bar.LayoutType == eLayoutType.DockContainer && bar.Visible)
					{
						break;
					}
					bar = ((Control)this).get_Controls().get_Item(i) as Bar;
				}
				if (bar == null)
				{
					return result;
				}
				DockStyle dock = ((Control)this).get_Dock();
				switch (dock - 1)
				{
				default:
					result.Width = bar_0.method_135(eOrientation.Vertical);
					if (!dockSiteInfo_0.NewLine && bar != bar_0)
					{
						if (bar.DockOffset < dockSiteInfo_0.DockOffset)
						{
							result.Width = ((Control)bar).get_Width();
							result.Height = ((Control)bar).get_Height() / 2;
							Point point8 = (result.Location = ((Control)this).PointToScreen(new Point(((Control)bar).get_Left(), ((Control)bar).get_Top() + result.Height)));
						}
						else
						{
							result.Width = ((Control)bar).get_Width();
							result.Height = ((Control)bar).get_Height() / 2;
							Point point10 = (result.Location = ((Control)this).PointToScreen(new Point(((Control)bar).get_Left(), ((Control)bar).get_Top())));
						}
					}
					else
					{
						result.Height = ((Control)bar).get_Height();
						Point point12 = (result.Location = ((Control)this).PointToScreen(new Point(((Control)bar).get_Left(), ((Control)bar).get_Top())));
					}
					break;
				case 0:
				case 1:
					result.Height = bar_0.method_135(eOrientation.Horizontal);
					if (!dockSiteInfo_0.NewLine && bar != bar_0)
					{
						if (bar.DockOffset > dockSiteInfo_0.DockOffset)
						{
							result.Height = ((Control)bar).get_Height();
							result.Width = ((Control)bar).get_Width() / 2;
							Point point2 = (result.Location = ((Control)this).PointToScreen(new Point(((Control)bar).get_Left(), ((Control)bar).get_Top())));
						}
						else
						{
							result.Height = ((Control)bar).get_Height();
							result.Width = ((Control)bar).get_Width() / 2;
							Point point4 = (result.Location = ((Control)this).PointToScreen(new Point(((Control)bar).get_Left() + result.Width, ((Control)bar).get_Top())));
						}
					}
					else
					{
						result.Width = ((Control)bar).get_Width();
						if (result.Width == 0)
						{
							result.Width = ((Control)this).get_Width();
						}
						Point point6 = (result.Location = ((Control)this).PointToScreen(new Point(((Control)bar).get_Left(), ((Control)bar).get_Top())));
					}
					break;
				}
			}
			else
			{
				int num3 = -1;
				int num4 = -1;
				if (dockSiteInfo_0.FullSizeDock)
				{
					num3 = method_20();
				}
				else if (dockSiteInfo_0.PartialSizeDock)
				{
					num4 = method_19();
				}
				DockStyle dock = ((Control)this).get_Dock();
				switch (dock - 1)
				{
				case 0:
				{
					result.Width = ((Control)this).get_ClientRectangle().Width;
					result.Height = bar_0.method_135(eOrientation.Horizontal);
					if (num3 >= 0)
					{
						result.Width += method_18(dotNetBarManager_0.LeftDockSite, bool_8: true).Width;
						result.Width += method_18(dotNetBarManager_0.RightDockSite, bool_8: true).Width;
						dockSiteInfo_0.DockSiteZOrderIndex = num3;
					}
					else if (num4 >= 0)
					{
						result.Width -= method_18(dotNetBarManager_0.LeftDockSite, bool_8: false).Width;
						result.Width -= method_18(dotNetBarManager_0.RightDockSite, bool_8: false).Width;
						dockSiteInfo_0.DockSiteZOrderIndex = num4;
					}
					Point empty3 = Point.Empty;
					if (dockSiteInfo_0.DockLine == -1)
					{
						empty3 = ((Control)this).PointToScreen(((Control)this).get_ClientRectangle().Location);
					}
					else
					{
						empty3 = ((Control)this).PointToScreen(new Point(((Control)this).get_ClientRectangle().X, ((Control)this).get_ClientRectangle().Bottom));
						empty3.Y++;
					}
					if (num3 >= 0)
					{
						empty3.X -= method_18(dotNetBarManager_0.LeftDockSite, bool_8: true).Width;
					}
					else if (num4 >= 0)
					{
						empty3.X += method_18(dotNetBarManager_0.LeftDockSite, bool_8: false).Width;
					}
					result.Location = empty3;
					break;
				}
				case 1:
				{
					result.Width = ((Control)this).get_ClientRectangle().Width;
					result.Height = bar_0.method_135(eOrientation.Horizontal);
					if (num3 >= 0)
					{
						result.Width += method_18(dotNetBarManager_0.LeftDockSite, bool_8: true).Width;
						result.Width += method_18(dotNetBarManager_0.RightDockSite, bool_8: true).Width;
						dockSiteInfo_0.DockSiteZOrderIndex = num3;
					}
					else if (num4 >= 0)
					{
						result.Width -= method_18(dotNetBarManager_0.LeftDockSite, bool_8: false).Width;
						result.Width -= method_18(dotNetBarManager_0.RightDockSite, bool_8: false).Width;
						dockSiteInfo_0.DockSiteZOrderIndex = num4;
					}
					Point empty2 = Point.Empty;
					if (dockSiteInfo_0.DockLine == -1)
					{
						empty2 = ((Control)this).PointToScreen(new Point(((Control)this).get_ClientRectangle().X, ((Control)this).get_ClientRectangle().Y - result.Height));
					}
					else
					{
						empty2 = ((Control)this).PointToScreen(new Point(((Control)this).get_ClientRectangle().X, ((Control)this).get_ClientRectangle().Bottom - result.Height));
						empty2.Y++;
					}
					if (num3 >= 0)
					{
						empty2.X -= method_18(dotNetBarManager_0.LeftDockSite, bool_8: true).Width;
					}
					else if (num4 >= 0)
					{
						empty2.X += method_18(dotNetBarManager_0.LeftDockSite, bool_8: false).Width;
					}
					result.Location = empty2;
					break;
				}
				default:
				{
					result.Height = ((Control)this).get_ClientRectangle().Height;
					if (num3 >= 0)
					{
						result.Height += method_18(dotNetBarManager_0.TopDockSite, bool_8: true).Height;
						result.Height += method_18(dotNetBarManager_0.BottomDockSite, bool_8: true).Height;
						dockSiteInfo_0.DockSiteZOrderIndex = num3;
					}
					else if (num4 >= 0)
					{
						result.Height -= method_18(dotNetBarManager_0.TopDockSite, bool_8: false).Height;
						result.Height -= method_18(dotNetBarManager_0.BottomDockSite, bool_8: false).Height;
						dockSiteInfo_0.DockSiteZOrderIndex = num4;
					}
					result.Width = bar_0.method_135(eOrientation.Vertical);
					Point empty4 = Point.Empty;
					if (dockSiteInfo_0.DockLine == -1)
					{
						empty4 = ((Control)this).PointToScreen(new Point(((Control)this).get_ClientRectangle().X, ((Control)this).get_ClientRectangle().Y));
					}
					else
					{
						empty4 = ((Control)this).PointToScreen(new Point(((Control)this).get_ClientRectangle().Right, ((Control)this).get_ClientRectangle().Y));
						empty4.X++;
					}
					if (num3 >= 0)
					{
						empty4.Y -= method_18(dotNetBarManager_0.TopDockSite, bool_8: true).Height;
					}
					else if (num4 >= 0)
					{
						empty4.Y += method_18(dotNetBarManager_0.TopDockSite, bool_8: false).Height;
					}
					result.Location = empty4;
					break;
				}
				case 3:
				{
					result.Height = ((Control)this).get_ClientRectangle().Height;
					if (num3 >= 0)
					{
						result.Height += method_18(dotNetBarManager_0.TopDockSite, bool_8: true).Height;
						result.Height += method_18(dotNetBarManager_0.BottomDockSite, bool_8: true).Height;
						dockSiteInfo_0.DockSiteZOrderIndex = num3;
					}
					else if (num4 >= 0)
					{
						result.Height -= method_18(dotNetBarManager_0.TopDockSite, bool_8: false).Height;
						result.Height -= method_18(dotNetBarManager_0.BottomDockSite, bool_8: false).Height;
						dockSiteInfo_0.DockSiteZOrderIndex = num4;
					}
					result.Width = bar_0.method_135(eOrientation.Vertical);
					Point empty = Point.Empty;
					if (dockSiteInfo_0.DockLine == -1)
					{
						empty = ((Control)this).PointToScreen(new Point(((Control)this).get_ClientRectangle().X - result.Width, ((Control)this).get_ClientRectangle().Y));
					}
					else
					{
						empty = ((Control)this).PointToScreen(new Point(((Control)this).get_ClientRectangle().Right - result.Width, ((Control)this).get_ClientRectangle().Y));
						empty.X--;
					}
					if (num3 >= 0)
					{
						empty.Y -= method_18(dotNetBarManager_0.TopDockSite, bool_8: true).Height;
					}
					else if (num4 >= 0)
					{
						empty.Y += method_18(dotNetBarManager_0.TopDockSite, bool_8: false).Height;
					}
					result.Location = empty;
					break;
				}
				}
			}
			return result;
		}
		DocumentDockUIManager documentUIManager = GetDocumentUIManager();
		return documentUIManager.method_0(bar_0, ref dockSiteInfo_0);
	}

	internal Size method_18(DockSite dockSite_0, bool bool_8)
	{
		if (dockSite_0 != null && ((Control)dockSite_0).get_Parent() != null)
		{
			Size result = Size.Empty;
			if (bool_8)
			{
				if (((Control)dockSite_0).get_Parent().get_Controls().IndexOf((Control)(object)dockSite_0) > ((Control)this).get_Parent().get_Controls().IndexOf((Control)(object)this))
				{
					result = ((Control)dockSite_0).get_Size();
				}
			}
			else if (((Control)this).get_Parent().get_Controls().IndexOf((Control)(object)this) > ((Control)dockSite_0).get_Parent().get_Controls().IndexOf((Control)(object)dockSite_0))
			{
				result = ((Control)dockSite_0).get_Size();
			}
			return result;
		}
		return Size.Empty;
	}

	internal int method_19()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		if (((Control)this).get_Parent() == null)
		{
			return -1;
		}
		int num = 1;
		if ((int)((Control)this).get_Dock() != 3 && (int)((Control)this).get_Dock() != 4)
		{
			if (dotNetBarManager_0 == null || dotNetBarManager_0.LeftDockSite == null || dotNetBarManager_0.RightDockSite == null || ((Control)dotNetBarManager_0.LeftDockSite).get_Parent() == null || ((Control)dotNetBarManager_0.RightDockSite).get_Parent() == null)
			{
				return -1;
			}
			num = Math.Min(((Control)dotNetBarManager_0.LeftDockSite).get_Parent().get_Controls().IndexOf((Control)(object)dotNetBarManager_0.LeftDockSite), ((Control)dotNetBarManager_0.RightDockSite).get_Parent().get_Controls().IndexOf((Control)(object)dotNetBarManager_0.RightDockSite));
		}
		else
		{
			if (dotNetBarManager_0 == null || dotNetBarManager_0.TopDockSite == null || dotNetBarManager_0.BottomDockSite == null || ((Control)dotNetBarManager_0.TopDockSite).get_Parent() == null || ((Control)dotNetBarManager_0.BottomDockSite).get_Parent() == null)
			{
				return -1;
			}
			num = Math.Min(((Control)dotNetBarManager_0.TopDockSite).get_Parent().get_Controls().IndexOf((Control)(object)dotNetBarManager_0.TopDockSite), ((Control)dotNetBarManager_0.BottomDockSite).get_Parent().get_Controls().IndexOf((Control)(object)dotNetBarManager_0.BottomDockSite));
		}
		if (((Control)this).get_Parent().get_Controls().IndexOf((Control)(object)this) < num)
		{
			return -1;
		}
		return num;
	}

	internal int method_20()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		if (((Control)this).get_Parent() == null)
		{
			return -1;
		}
		int num = -1;
		if ((int)((Control)this).get_Dock() != 3 && (int)((Control)this).get_Dock() != 4)
		{
			if (dotNetBarManager_0 == null || dotNetBarManager_0.LeftDockSite == null || dotNetBarManager_0.RightDockSite == null || ((Control)dotNetBarManager_0.LeftDockSite).get_Parent() == null || ((Control)dotNetBarManager_0.RightDockSite).get_Parent() == null)
			{
				return -1;
			}
			num = Math.Max(((Control)dotNetBarManager_0.LeftDockSite).get_Parent().get_Controls().IndexOf((Control)(object)dotNetBarManager_0.LeftDockSite), ((Control)dotNetBarManager_0.RightDockSite).get_Parent().get_Controls().IndexOf((Control)(object)dotNetBarManager_0.RightDockSite));
		}
		else
		{
			if (dotNetBarManager_0 == null || dotNetBarManager_0.TopDockSite == null || dotNetBarManager_0.BottomDockSite == null || ((Control)dotNetBarManager_0.TopDockSite).get_Parent() == null || ((Control)dotNetBarManager_0.BottomDockSite).get_Parent() == null)
			{
				return -1;
			}
			num = Math.Max(((Control)dotNetBarManager_0.TopDockSite).get_Parent().get_Controls().IndexOf((Control)(object)dotNetBarManager_0.TopDockSite), ((Control)dotNetBarManager_0.BottomDockSite).get_Parent().get_Controls().IndexOf((Control)(object)dotNetBarManager_0.BottomDockSite));
		}
		if (((Control)this).get_Parent().get_Controls().IndexOf((Control)(object)this) > num)
		{
			return -1;
		}
		return num;
	}

	internal void method_21(Control control_0)
	{
		if (((Control)this).Contains(control_0))
		{
			((Control)this).get_Controls().Remove(control_0);
			method_8();
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		if (documentDockContainer_0 != null)
		{
			documentDockUIManager_0.OnMouseMove(e);
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		if (documentDockContainer_0 != null)
		{
			documentDockUIManager_0.OnMouseLeave();
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		if ((int)e.get_Button() == 2097152 && documentDockContainer_0 == null)
		{
			((IOwnerBarSupport)dotNetBarManager_0)?.BarContextMenu((Control)(object)this, e);
		}
		if (documentDockContainer_0 != null)
		{
			documentDockUIManager_0.OnMouseDown(e);
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		if (documentDockContainer_0 != null)
		{
			documentDockUIManager_0.OnMouseUp(e);
		}
	}

	private void method_22()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		if (dotNetBarManager_0 == null)
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			if (val is Bar)
			{
				Bar bar = val as Bar;
				if (!dotNetBarManager_0.Bars.Contains(bar))
				{
					dotNetBarManager_0.Bars.Add(bar);
				}
			}
		}
	}

	protected override void OnDockChanged(EventArgs e)
	{
		((Control)this).OnDockChanged(e);
		if (Boolean_2)
		{
			method_22();
		}
	}

	internal void method_23(DotNetBarManager dotNetBarManager_1)
	{
		dotNetBarManager_0 = dotNetBarManager_1;
		method_22();
	}
}
