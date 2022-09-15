using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.Editors;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[DefaultEvent("Click")]
[Designer(typeof(ComboBoxItemDesigner))]
[ToolboxItem(false)]
public class ComboBoxItem : ImageItem, IPersonalizedMenuItem
{
	private ComboBoxEx comboBoxEx_0;

	private int int_4 = 64;

	private bool bool_22;

	private string string_7 = "";

	private bool bool_23;

	private bool bool_24;

	private eMenuVisibility eMenuVisibility_0;

	private bool bool_25;

	internal bool bool_26;

	private bool bool_27;

	private EventHandler eventHandler_14;

	private EventHandler eventHandler_15;

	[Browsable(true)]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Description("Gets or sets the accessible role of the item.")]
	[Category("Accessibility")]
	public override AccessibleRole AccessibleRole
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return base.AccessibleRole;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			base.AccessibleRole = value;
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[DefaultValue(false)]
	[Description("Indicates whether combo box generates the audible alert when Enter key is pressed.")]
	public bool PreventEnterBeep
	{
		get
		{
			return bool_27;
		}
		set
		{
			bool_27 = value;
			if (comboBoxEx_0 != null)
			{
				comboBoxEx_0.PreventEnterBeep = value;
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override Rectangle Bounds
	{
		get
		{
			return base.Bounds;
		}
		set
		{
			if (base.Bounds != value)
			{
				bool flag = base.Bounds.Top != value.Top;
				bool flag2 = base.Bounds.Left != value.Left;
				base.Bounds = value;
				if (flag || flag2)
				{
					method_18();
				}
			}
		}
	}

	[Description("Indicates width of the of the drop-down portion of a combo box.")]
	[Browsable(true)]
	[Category("Layout")]
	public int DropDownWidth
	{
		get
		{
			return ((ComboBox)comboBoxEx_0).get_DropDownWidth();
		}
		set
		{
			((ComboBox)comboBoxEx_0).set_DropDownWidth(value);
		}
	}

	[DefaultValue(0)]
	[Browsable(true)]
	[Category("Layout")]
	[Description("Indicates height of the of the drop-down portion of a combo box.")]
	public int DropDownHeight
	{
		get
		{
			return ((ComboBox)comboBoxEx_0).get_DropDownHeight();
		}
		set
		{
			((ComboBox)comboBoxEx_0).set_DropDownHeight(value);
		}
	}

	[DefaultValue(64)]
	[Browsable(true)]
	[Category("Layout")]
	[DevCoBrowsable(true)]
	[Description("Indicates the Width of the combo box part of the item.")]
	public int ComboWidth
	{
		get
		{
			return int_4;
		}
		set
		{
			if (int_4 != value)
			{
				int_4 = value;
				if (Name != "" && GlobalItem)
				{
					Class109.smethod_24(GetOwner(), GetType(), m_Name, TypeDescriptor.GetProperties(this)["ComboWidth"], int_4);
				}
				NeedRecalcSize = true;
				Refresh();
			}
			OnAppearanceChanged();
		}
	}

	[Browsable(false)]
	public ComboBoxEx ComboBoxEx => comboBoxEx_0;

	[Description("Indicates whether item caption is always shown.")]
	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Category("Behavior")]
	[Browsable(true)]
	public bool AlwaysShowCaption
	{
		get
		{
			return bool_23;
		}
		set
		{
			if (bool_23 != value)
			{
				bool_23 = value;
			}
			NeedRecalcSize = true;
		}
	}

	[Editor(typeof(ComboItemsEditor), typeof(UITypeEditor))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Data")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public ObjectCollection Items => comboBoxEx_0.Items;

	[Description("Gets or sets a value specifying the style of the combo box.")]
	[DevCoBrowsable(true)]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(true)]
	[Category("Appearance")]
	public ComboBoxStyle DropDownStyle
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return ((ComboBox)comboBoxEx_0).get_DropDownStyle();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			((ComboBox)comboBoxEx_0).set_DropDownStyle(value);
		}
	}

	[DefaultValue(0)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public int SelectionStart
	{
		get
		{
			return ((ComboBox)comboBoxEx_0).get_SelectionStart();
		}
		set
		{
			((ComboBox)comboBoxEx_0).set_SelectionStart(value);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(0)]
	public int SelectionLength
	{
		get
		{
			return ((ComboBox)comboBoxEx_0).get_SelectionLength();
		}
		set
		{
			((ComboBox)comboBoxEx_0).set_SelectionLength(value);
		}
	}

	[DefaultValue("")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string SelectedText
	{
		get
		{
			return ((ComboBox)comboBoxEx_0).get_SelectedText();
		}
		set
		{
			((ComboBox)comboBoxEx_0).set_SelectedText(value);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(null)]
	public object SelectedItem
	{
		get
		{
			return ((ComboBox)comboBoxEx_0).get_SelectedItem();
		}
		set
		{
			((ComboBox)comboBoxEx_0).set_SelectedItem(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(-1)]
	[Browsable(false)]
	public int SelectedIndex
	{
		get
		{
			return ((ListControl)comboBoxEx_0).get_SelectedIndex();
		}
		set
		{
			((ListControl)comboBoxEx_0).set_SelectedIndex(value);
		}
	}

	[Description("Automatically loads all the fonts available into the combo box.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[DefaultValue(false)]
	public bool FontCombo
	{
		get
		{
			return bool_24;
		}
		set
		{
			if (bool_24 != value)
			{
				bool_24 = value;
				if (bool_24)
				{
					comboBoxEx_0.LoadFonts();
					((ComboBox)comboBoxEx_0).set_DropDownStyle((ComboBoxStyle)2);
					((ComboBox)comboBoxEx_0).set_DrawMode((DrawMode)2);
				}
			}
		}
	}

	[Description("Indicates the height of an item in the combo box.")]
	[DefaultValue(15)]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Browsable(true)]
	public int ItemHeight
	{
		get
		{
			return ((ComboBox)comboBoxEx_0).get_ItemHeight();
		}
		set
		{
			((ComboBox)comboBoxEx_0).set_ItemHeight(value);
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Description("Indicates item's visiblity when on pop-up menu.")]
	[DefaultValue(eMenuVisibility.VisibleAlways)]
	public eMenuVisibility MenuVisibility
	{
		get
		{
			return eMenuVisibility_0;
		}
		set
		{
			if (eMenuVisibility_0 != value)
			{
				eMenuVisibility_0 = value;
				if (m_Name != "" && GlobalItem)
				{
					Class109.smethod_24(GetOwner(), GetType(), m_Name, TypeDescriptor.GetProperties(this)["MenuVisibility"], eMenuVisibility_0);
				}
			}
		}
	}

	[DefaultValue(false)]
	[Browsable(false)]
	public bool RecentlyUsed
	{
		get
		{
			return bool_25;
		}
		set
		{
			if (bool_25 != value)
			{
				bool_25 = value;
				if (m_Name != "" && GlobalItem)
				{
					Class109.smethod_24(GetOwner(), GetType(), m_Name, TypeDescriptor.GetProperties(this)["RecentlyUsed"], bool_25);
				}
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue("")]
	[Category("Appearance")]
	[Description("The text contained in the underlining Control portion of the item.")]
	public virtual string ControlText
	{
		get
		{
			return string_7;
		}
		set
		{
			string_7 = value;
			((Control)comboBoxEx_0).set_Text(string_7);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
			base.Text = value;
		}
	}

	[DefaultValue("")]
	[Description("Indicates the item Caption displayed next to the combo box.")]
	[Category("Appearance")]
	[Localizable(true)]
	public string Caption
	{
		get
		{
			return base.Text;
		}
		set
		{
			base.Text = value;
		}
	}

	[DefaultValue("")]
	[Browsable(true)]
	[Description("Indicates string that specifies the property of the data source whose contents you want to display.")]
	[DevCoBrowsable(true)]
	[Category("Data")]
	public virtual string DisplayMember
	{
		get
		{
			if (comboBoxEx_0 != null)
			{
				return ((ListControl)comboBoxEx_0).get_DisplayMember();
			}
			return "";
		}
		set
		{
			if (comboBoxEx_0 != null)
			{
				((ListControl)comboBoxEx_0).set_DisplayMember(value);
			}
		}
	}

	[Category("Appearance")]
	[Description("Specifies whether combo box is drawn using themes when running on OS that supports themes like Windows XP.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public override bool ThemeAware
	{
		get
		{
			return comboBoxEx_0.ThemeAware;
		}
		set
		{
			comboBoxEx_0.ThemeAware = value;
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool IsWindowed => true;

	[Category("Appearance")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Description("Indicates watermark font.")]
	public Font WatermarkFont
	{
		get
		{
			return comboBoxEx_0.WatermarkFont;
		}
		set
		{
			comboBoxEx_0.WatermarkFont = value;
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates watermark text color.")]
	public Color WatermarkColor
	{
		get
		{
			return comboBoxEx_0.WatermarkColor;
		}
		set
		{
			comboBoxEx_0.WatermarkColor = value;
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether watermark text is displayed when control is empty.")]
	public virtual bool WatermarkEnabled
	{
		get
		{
			return comboBoxEx_0.WatermarkEnabled;
		}
		set
		{
			comboBoxEx_0.WatermarkEnabled = value;
		}
	}

	[Localizable(true)]
	[DefaultValue("")]
	[Description("Indicates watermark text displayed inside of the control when Text is not set and control does not have input focus.")]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[Category("Appearance")]
	public string WatermarkText
	{
		get
		{
			return comboBoxEx_0.WatermarkText;
		}
		set
		{
			comboBoxEx_0.WatermarkText = value;
		}
	}

	[Category("Behavior")]
	[DefaultValue(eWatermarkBehavior.HideOnFocus)]
	[Description("Indicates watermark hiding behaviour.")]
	public eWatermarkBehavior WatermarkBehavior
	{
		get
		{
			return comboBoxEx_0.WatermarkBehavior;
		}
		set
		{
			comboBoxEx_0.WatermarkBehavior = value;
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[ParenthesizePropertyName(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public new ControlBindingsCollection DataBindings => ((Control)comboBoxEx_0).get_DataBindings();

	[Description("Indicates the appearance of the control.")]
	[DefaultValue(false)]
	[Browsable(true)]
	[Category("Appearance")]
	public bool IsStandalone
	{
		get
		{
			return comboBoxEx_0.IsStandalone;
		}
		set
		{
			comboBoxEx_0.IsStandalone = value;
		}
	}

	public event EventHandler ComboBoxTextChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_14 = (EventHandler)Delegate.Combine(eventHandler_14, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_14 = (EventHandler)Delegate.Remove(eventHandler_14, value);
		}
	}

	public event EventHandler SelectedIndexChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_15 = (EventHandler)Delegate.Combine(eventHandler_15, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_15 = (EventHandler)Delegate.Remove(eventHandler_15, value);
		}
	}

	public ComboBoxItem()
		: this("", "")
	{
	}

	public ComboBoxItem(string sName)
		: this(sName, "")
	{
	}

	public ComboBoxItem(string sName, string ItemText)
		: base(sName, ItemText)
	{
		method_17();
		int_4 = 64;
		m_SupportedOrientation = eSupportedOrientation.Horizontal;
		IsAccessible = true;
		AccessibleRole = (AccessibleRole)46;
	}

	private void method_17()
	{
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		if (comboBoxEx_0 != null)
		{
			((Component)(object)comboBoxEx_0).Dispose();
			comboBoxEx_0 = null;
		}
		comboBoxEx_0 = new ComboBoxEx();
		comboBoxEx_0.IsStandalone = false;
		((Control)comboBoxEx_0).set_TabStop(false);
		((Control)comboBoxEx_0).set_TabIndex(9999);
		comboBoxEx_0.Style = Style;
		((ComboBox)comboBoxEx_0).set_DrawMode((DrawMode)1);
		((ComboBox)comboBoxEx_0).set_IntegralHeight(false);
		comboBoxEx_0.ThemeAware = false;
		((Control)comboBoxEx_0).set_Visible(false);
		((Control)comboBoxEx_0).set_Text(string_7);
		((ComboBox)comboBoxEx_0).set_SelectionStart(0);
		((ComboBox)comboBoxEx_0).set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBoxEx_0).add_LostFocus((EventHandler)comboBoxEx_0_LostFocus);
		((Control)comboBoxEx_0).add_GotFocus((EventHandler)comboBoxEx_0_GotFocus);
		((Control)comboBoxEx_0).add_MouseHover((EventHandler)comboBoxEx_0_MouseHover);
		((Control)comboBoxEx_0).add_MouseEnter((EventHandler)comboBoxEx_0_MouseEnter);
		((Control)comboBoxEx_0).add_MouseLeave((EventHandler)comboBoxEx_0_MouseLeave);
		((Control)comboBoxEx_0).add_VisibleChanged((EventHandler)comboBoxEx_0_VisibleChanged);
		comboBoxEx_0.DropDownChange += comboBoxEx_0_DropDownChange;
		((Control)comboBoxEx_0).add_TextChanged((EventHandler)comboBoxEx_0_TextChanged);
		((Control)comboBoxEx_0).add_KeyDown(new KeyEventHandler(comboBoxEx_0_KeyDown));
		((ComboBox)comboBoxEx_0).add_SelectedIndexChanged((EventHandler)comboBoxEx_0_SelectedIndexChanged);
		comboBoxEx_0.PreventEnterBeep = bool_27;
		comboBoxEx_0.baseItem_0 = this;
		if (bool_24)
		{
			comboBoxEx_0.LoadFonts();
		}
		if (ContainerControl != null)
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				val.get_Controls().Add((Control)(object)comboBoxEx_0);
				((Control)comboBoxEx_0).Refresh();
			}
		}
		if (Displayed)
		{
			((Control)comboBoxEx_0).set_Visible(true);
		}
	}

	public override BaseItem Copy()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		ComboBoxItem comboBoxItem = new ComboBoxItem(Name);
		CopyToItem(comboBoxItem);
		comboBoxItem.DropDownStyle = DropDownStyle;
		comboBoxItem.AlwaysShowCaption = AlwaysShowCaption;
		comboBoxItem.FontCombo = FontCombo;
		comboBoxItem.ItemHeight = ItemHeight;
		return comboBoxItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		((ComboBoxItem)copy).bool_26 = true;
		try
		{
			ComboBoxItem comboBoxItem = copy as ComboBoxItem;
			base.CopyToItem(comboBoxItem);
			comboBoxItem.ControlText = string_7;
			comboBoxItem.ComboWidth = int_4;
			comboBoxItem.FontCombo = bool_24;
			comboBoxItem.PreventEnterBeep = bool_27;
			if (comboBoxEx_0 != null)
			{
				comboBoxItem.DisplayMember = ((ListControl)comboBoxEx_0).get_DisplayMember();
			}
			ComboBoxEx comboBoxEx = comboBoxItem.ComboBoxEx;
			if (!bool_24)
			{
				foreach (object item in comboBoxEx_0.Items)
				{
					comboBoxEx.Items.Add(item);
				}
			}
			((ListControl)comboBoxEx).set_SelectedIndex(((ListControl)comboBoxEx_0).get_SelectedIndex());
		}
		finally
		{
			((ComboBoxItem)copy).bool_26 = false;
		}
	}

	public override void Dispose()
	{
		base.Dispose();
		if (comboBoxEx_0 != null)
		{
			if (((Control)comboBoxEx_0).get_Parent() != null)
			{
				((Control)comboBoxEx_0).get_Parent().get_Controls().Remove((Control)(object)comboBoxEx_0);
			}
			((Component)(object)comboBoxEx_0).Dispose();
			comboBoxEx_0 = null;
		}
	}

	protected override AccessibleObject CreateAccessibilityInstance()
	{
		return ((Control)comboBoxEx_0).get_AccessibilityObject();
	}

	protected internal override void Serialize(ItemSerializationContext context)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected I4, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected I4, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected I4, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected I4, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected I4, but got Unknown
		base.Serialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		itemXmlElement.SetAttribute("ComboWidth", XmlConvert.ToString(int_4));
		itemXmlElement.SetAttribute("FontCombo", XmlConvert.ToString(bool_24));
		itemXmlElement.SetAttribute("MenuVisibility", XmlConvert.ToString((int)eMenuVisibility_0));
		itemXmlElement.SetAttribute("RecentlyUsed", XmlConvert.ToString(bool_25));
		itemXmlElement.SetAttribute("DropDownStyle", XmlConvert.ToString((int)((ComboBox)comboBoxEx_0).get_DropDownStyle()));
		itemXmlElement.SetAttribute("CText", string_7);
		itemXmlElement.SetAttribute("ThemeAware", XmlConvert.ToString(comboBoxEx_0.ThemeAware));
		itemXmlElement.SetAttribute("AlwaysShowCaption", XmlConvert.ToString(bool_23));
		itemXmlElement.SetAttribute("ItemHeight", XmlConvert.ToString(((ComboBox)comboBoxEx_0).get_ItemHeight()));
		if (((ListControl)comboBoxEx_0).get_DisplayMember() != "")
		{
			itemXmlElement.SetAttribute("DisplayMembers", ((ListControl)comboBoxEx_0).get_DisplayMember());
		}
		if (bool_27)
		{
			itemXmlElement.SetAttribute("nobeep", XmlConvert.ToString(bool_27));
		}
		if (bool_24 || comboBoxEx_0.Items.get_Count() <= 0)
		{
			return;
		}
		XmlElement xmlElement = itemXmlElement.OwnerDocument.CreateElement("cbitems");
		itemXmlElement.AppendChild(xmlElement);
		foreach (object item in comboBoxEx_0.Items)
		{
			if (item is ComboItem comboItem)
			{
				XmlElement xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("ci");
				if (!comboItem.BackColor.IsEmpty)
				{
					xmlElement2.SetAttribute("bc", Class109.smethod_50(comboItem.BackColor));
				}
				if (comboItem.FontName != "")
				{
					xmlElement2.SetAttribute("fn", comboItem.FontName);
				}
				if (comboItem.FontSize != 8f)
				{
					xmlElement2.SetAttribute("fs", XmlConvert.ToString(comboItem.FontSize));
				}
				xmlElement2.SetAttribute("fy", XmlConvert.ToString((int)comboItem.FontStyle));
				if (!comboItem.ForeColor.IsEmpty)
				{
					xmlElement2.SetAttribute("fc", Class109.smethod_50(comboItem.ForeColor));
				}
				Class109.smethod_13(comboItem.Image, xmlElement2);
				if (comboItem.ImageIndex >= 0)
				{
					xmlElement2.SetAttribute("img", XmlConvert.ToString(comboItem.ImageIndex));
				}
				if ((int)comboItem.ImagePosition != 0)
				{
					xmlElement2.SetAttribute("ip", XmlConvert.ToString((int)comboItem.ImagePosition));
				}
				xmlElement2.SetAttribute("text", comboItem.Text);
				xmlElement2.SetAttribute("ta", XmlConvert.ToString((int)comboItem.TextAlignment));
				xmlElement2.SetAttribute("tla", XmlConvert.ToString((int)comboItem.TextLineAlignment));
				if (((ComboBox)comboBoxEx_0).get_SelectedItem() == item)
				{
					xmlElement2.SetAttribute("selected", "1");
				}
				xmlElement.AppendChild(xmlElement2);
			}
			else
			{
				XmlElement xmlElement3 = itemXmlElement.OwnerDocument.CreateElement("co");
				xmlElement3.InnerText = item.ToString();
				xmlElement.AppendChild(xmlElement3);
				if (((ComboBox)comboBoxEx_0).get_SelectedItem() == item)
				{
					xmlElement3.SetAttribute("selected", "1");
				}
			}
		}
	}

	protected internal override void Deserialize(ItemSerializationContext context)
	{
		base.Deserialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		int_4 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("ComboWidth"));
		bool_24 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("FontCombo"));
		eMenuVisibility_0 = (eMenuVisibility)XmlConvert.ToInt32(itemXmlElement.GetAttribute("MenuVisibility"));
		bool_25 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("RecentlyUsed"));
		if (itemXmlElement.HasAttribute("DropDownStyle"))
		{
			((ComboBox)comboBoxEx_0).set_DropDownStyle((ComboBoxStyle)XmlConvert.ToInt32(itemXmlElement.GetAttribute("DropDownStyle")));
		}
		if (itemXmlElement.HasAttribute("CText"))
		{
			ControlText = itemXmlElement.GetAttribute("CText");
		}
		if (itemXmlElement.HasAttribute("ThemeAware"))
		{
			comboBoxEx_0.ThemeAware = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("ThemeAware"));
		}
		else
		{
			comboBoxEx_0.ThemeAware = true;
		}
		if (itemXmlElement.HasAttribute("AlwaysShowCaption"))
		{
			bool_23 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("AlwaysShowCaption"));
		}
		if (itemXmlElement.HasAttribute("nobeep"))
		{
			PreventEnterBeep = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("nobeep"));
		}
		XmlNodeList elementsByTagName = itemXmlElement.GetElementsByTagName("cbitems");
		if (!bool_24 && elementsByTagName.Count > 0)
		{
			foreach (XmlElement childNode in elementsByTagName[0]!.ChildNodes)
			{
				if (childNode.Name == "ci")
				{
					ComboItem comboItem = new ComboItem();
					if (childNode.HasAttribute("bc"))
					{
						comboItem.BackColor = Class109.smethod_51(childNode.GetAttribute("bk"));
					}
					if (childNode.HasAttribute("fn"))
					{
						comboItem.FontName = childNode.GetAttribute("fn");
					}
					if (childNode.HasAttribute("fs"))
					{
						comboItem.FontSize = XmlConvert.ToSingle(childNode.GetAttribute("fs"));
					}
					if (childNode.HasAttribute("fy"))
					{
						comboItem.FontStyle = (FontStyle)XmlConvert.ToInt32(childNode.GetAttribute("fy"));
					}
					if (childNode.HasAttribute("fc"))
					{
						comboItem.ForeColor = Class109.smethod_51(childNode.GetAttribute("fc"));
					}
					comboItem.Image = Class109.smethod_16(childNode);
					if (childNode.HasAttribute("img"))
					{
						comboItem.ImageIndex = XmlConvert.ToInt32(childNode.GetAttribute("img"));
					}
					if (childNode.HasAttribute("ip"))
					{
						comboItem.ImagePosition = (HorizontalAlignment)XmlConvert.ToInt32(childNode.GetAttribute("ip"));
					}
					if (childNode.HasAttribute("ItemHeight"))
					{
						((ComboBox)comboBoxEx_0).set_ItemHeight(XmlConvert.ToInt32(childNode.GetAttribute("ItemHeight")));
					}
					comboItem.Text = childNode.GetAttribute("text");
					comboItem.TextAlignment = (StringAlignment)XmlConvert.ToInt32(childNode.GetAttribute("ta"));
					comboItem.TextLineAlignment = (StringAlignment)XmlConvert.ToInt32(childNode.GetAttribute("tla"));
					comboBoxEx_0.Items.Add((object)comboItem);
					if (childNode.HasAttribute("selected") && childNode.GetAttribute("selected") == "1")
					{
						((ComboBox)comboBoxEx_0).set_SelectedItem((object)comboItem);
					}
				}
				else if (childNode.Name == "co")
				{
					comboBoxEx_0.Items.Add((object)childNode.InnerText);
					if (childNode.HasAttribute("selected") && childNode.GetAttribute("selected") == "1")
					{
						((ComboBox)comboBoxEx_0).set_SelectedItem(comboBoxEx_0.Items.get_Item(comboBoxEx_0.Items.get_Count() - 1));
					}
				}
			}
		}
		if (bool_24)
		{
			comboBoxEx_0.LoadFonts();
		}
		if (comboBoxEx_0 != null)
		{
			((Control)comboBoxEx_0).set_Enabled(Enabled);
		}
		if (itemXmlElement.HasAttribute("DisplayMembers") && comboBoxEx_0 != null)
		{
			((ListControl)comboBoxEx_0).set_DisplayMember(itemXmlElement.GetAttribute("DisplayMembers"));
		}
	}

	public override void Paint(ItemPaintArgs pa)
	{
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected O, but got Unknown
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Invalid comparison between Unknown and I4
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected O, but got Unknown
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected O, but got Unknown
		if (SuspendLayout)
		{
			return;
		}
		Graphics graphics = pa.Graphics;
		Rectangle displayRectangle = DisplayRectangle;
		Size size = method_20();
		bool flag = base.IsOnMenu && !(Parent is ItemContainer);
		bool flag2;
		Color color_ = ((flag2 = method_1(pa.ContainerControl)) ? SystemColors.ControlText : SystemColors.ControlDark);
		if (Style == eDotNetBarStyle.Office2007 && pa.BaseRenderer_0 is Office2007Renderer && ((Office2007Renderer)pa.BaseRenderer_0).ColorTable.ButtonItemColors.Count > 0)
		{
			color_ = (flag2 ? ((Office2007Renderer)pa.BaseRenderer_0).ColorTable.ButtonItemColors[0].Default.Text : pa.Colors.ItemDisabledText);
		}
		if (Orientation == eOrientation.Horizontal)
		{
			if (flag && (Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style)))
			{
				size.Width += 7;
				displayRectangle.Width -= size.Width;
				displayRectangle.X += size.Width;
				if (base.IsOnCustomizeMenu)
				{
					size.Width += size.Height + 8;
				}
				Rectangle rectangle = new Rectangle(m_Rect.Left, m_Rect.Top, size.Width, m_Rect.Height);
				if (MenuVisibility == eMenuVisibility.VisibleIfRecentlyUsed && !RecentlyUsed)
				{
					if (!pa.Colors.MenuUnusedSide2.IsEmpty)
					{
						LinearGradientBrush val = Class109.smethod_40(rectangle, pa.Colors.MenuUnusedSide, pa.Colors.MenuUnusedSide2, pa.Colors.MenuUnusedSideGradientAngle);
						graphics.FillRectangle((Brush)(object)val, rectangle);
						((Brush)val).Dispose();
					}
					else
					{
						graphics.FillRectangle((Brush)new SolidBrush(pa.Colors.MenuUnusedSide), rectangle);
					}
				}
				else if (!pa.Colors.MenuSide2.IsEmpty)
				{
					LinearGradientBrush val2 = Class109.smethod_40(rectangle, pa.Colors.MenuSide, pa.Colors.MenuSide2, pa.Colors.MenuSideGradientAngle);
					graphics.FillRectangle((Brush)(object)val2, rectangle);
					((Brush)val2).Dispose();
				}
				else
				{
					graphics.FillRectangle((Brush)new SolidBrush(pa.Colors.MenuSide), rectangle);
				}
				if (Class109.smethod_69(Style) && GlobalManager.Renderer is Office2007Renderer)
				{
					Office2007MenuColorTable menu = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.Menu;
					if (menu != null && !menu.SideBorder.IsEmpty)
					{
						if (pa.RightToLeft)
						{
							Class50.smethod_42(graphics, rectangle.X + 1, rectangle.Y, rectangle.X + 1, rectangle.Bottom - 1, menu.SideBorder, 1);
						}
						else
						{
							Class50.smethod_42(graphics, rectangle.Right - 2, rectangle.Y, rectangle.Right - 2, rectangle.Bottom - 1, menu.SideBorder, 1);
						}
					}
					if (menu != null && !menu.SideBorderLight.IsEmpty)
					{
						if (pa.RightToLeft)
						{
							Class50.smethod_42(graphics, rectangle.X, rectangle.Y, rectangle.X, rectangle.Bottom - 1, menu.SideBorder, 1);
						}
						else
						{
							Class50.smethod_42(graphics, rectangle.Right - 1, rectangle.Y, rectangle.Right - 1, rectangle.Bottom - 1, menu.SideBorderLight, 1);
						}
					}
				}
			}
			if (base.IsOnCustomizeMenu)
			{
				if (Style != 0 && Style != eDotNetBarStyle.Office2003 && m_Style != eDotNetBarStyle.VS2005 && !Class109.smethod_69(m_Style))
				{
					displayRectangle.X += size.Height + 4;
					displayRectangle.Width -= size.Height + 4;
				}
				else
				{
					displayRectangle.X += size.Height + 8;
					displayRectangle.Width -= size.Height + 8;
				}
			}
			if (flag && (Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || m_Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(m_Style)) && bool_22)
			{
				Rectangle displayRectangle2 = DisplayRectangle;
				displayRectangle2.Inflate(-1, 0);
				if (Class109.smethod_69(Style) && !(pa.Owner is DotNetBarManager) && GlobalManager.Renderer is Office2007Renderer)
				{
					Office2007ButtonItemStateColorTable mouseOver = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.ButtonItemColors[0].MouseOver;
					Class268.smethod_4(graphics, mouseOver, displayRectangle2, RoundRectangleShapeDescriptor.RoundCorner3);
				}
				else
				{
					if (!pa.Colors.ItemHotBackground2.IsEmpty)
					{
						LinearGradientBrush val3 = Class109.smethod_40(displayRectangle2, pa.Colors.ItemHotBackground, pa.Colors.ItemHotBackground2, pa.Colors.ItemHotBackgroundGradientAngle);
						graphics.FillRectangle((Brush)(object)val3, displayRectangle2);
						((Brush)val3).Dispose();
					}
					else
					{
						graphics.FillRectangle((Brush)new SolidBrush(pa.Colors.ItemHotBackground), displayRectangle2);
					}
					Class92.smethod_4(graphics, new Pen(pa.Colors.ItemHotBorder), displayRectangle2);
				}
			}
			if (m_Text != "" && (bool_23 || flag))
			{
				eTextFormat eTextFormat_ = method_21();
				Font font = GetFont();
				Rectangle rectangle_ = new Rectangle(displayRectangle.X + 8, displayRectangle.Y, displayRectangle.Width, displayRectangle.Height);
				if (Style == eDotNetBarStyle.Office2000)
				{
					Class55.smethod_1(graphics, m_Text, font, color_, rectangle_, eTextFormat_);
				}
				else
				{
					Class55.smethod_1(graphics, m_Text, font, color_, rectangle_, eTextFormat_);
				}
				Size size2 = Class55.smethod_4(graphics, m_Text, font, 0, eTextFormat_);
				displayRectangle.X += size2.Width + 8;
				displayRectangle.Width -= size2.Width + 8;
			}
			if (comboBoxEx_0 != null && !base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog && !DesignMode)
			{
				int selectionLength = ((ComboBox)comboBoxEx_0).get_SelectionLength();
				displayRectangle.Inflate(-2, -2);
				if (((Control)comboBoxEx_0).get_Width() != displayRectangle.Width)
				{
					((Control)comboBoxEx_0).set_Width(displayRectangle.Width);
				}
				Point location = displayRectangle.Location;
				location.Offset((displayRectangle.Width - ((Control)comboBoxEx_0).get_Width()) / 2, (displayRectangle.Height - ((Control)comboBoxEx_0).get_Height()) / 2);
				Control containerControl = pa.ContainerControl;
				ScrollableControl val4 = (ScrollableControl)(object)((containerControl is ScrollableControl) ? containerControl : null);
				if (val4 != null && val4.get_AutoScroll())
				{
					location.Offset(val4.get_AutoScrollPosition().X, val4.get_AutoScrollPosition().Y);
				}
				if (((Control)comboBoxEx_0).get_Location() != location)
				{
					((Control)comboBoxEx_0).set_Location(location);
				}
				if (selectionLength > 0 && selectionLength < 1000 && ((ComboBox)comboBoxEx_0).get_SelectionLength() != selectionLength && ((Control)comboBoxEx_0).get_Text().Length > selectionLength && (int)((ComboBox)comboBoxEx_0).get_DropDownStyle() == 1)
				{
					((ComboBox)comboBoxEx_0).set_SelectionLength(selectionLength);
				}
			}
			else
			{
				displayRectangle.Inflate(-3, -2);
				graphics.FillRectangle(SystemBrushes.get_Window(), displayRectangle);
				Class92.smethod_4(graphics, SystemPens.get_ControlDark(), displayRectangle);
				displayRectangle.X = displayRectangle.Right - (SystemInformation.get_HorizontalScrollBarThumbWidth() - 2);
				displayRectangle.Width = SystemInformation.get_HorizontalScrollBarThumbWidth() - 2;
				ControlPaint.DrawComboButton(graphics, displayRectangle, (ButtonState)16384);
			}
			if (base.IsOnCustomizeMenu && Visible)
			{
				Rectangle rectangle_2 = new Rectangle(m_Rect.Left, m_Rect.Top, m_Rect.Height, m_Rect.Height);
				if (Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || m_Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(m_Style))
				{
					rectangle_2.Inflate(-1, -1);
				}
				Class109.smethod_12(pa, rectangle_2, Style, bool_22);
			}
		}
		else
		{
			string text = Text;
			text = ((!(text == "")) ? (text + " »") : "...");
			if (Style != 0 && Style != eDotNetBarStyle.Office2003 && m_Style != eDotNetBarStyle.VS2005 && !Class109.smethod_69(m_Style))
			{
				graphics.FillRectangle(SystemBrushes.get_Control(), DisplayRectangle);
			}
			else
			{
				graphics.FillRectangle((Brush)new SolidBrush(ColorFunctions.ToolMenuFocusBackColor(graphics)), DisplayRectangle);
			}
			if (bool_22 && !DesignMode)
			{
				if (Style == eDotNetBarStyle.Office2000)
				{
					ControlPaint.DrawBorder3D(graphics, displayRectangle, (Border3DStyle)4, (Border3DSide)2063);
				}
				else if (Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || m_Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(m_Style))
				{
					displayRectangle.Inflate(-1, -1);
					graphics.FillRectangle((Brush)new SolidBrush(ColorFunctions.HoverBackColor(graphics)), displayRectangle);
					Class92.smethod_4(graphics, SystemPens.get_Highlight(), displayRectangle);
				}
			}
			displayRectangle = new Rectangle(m_Rect.Top, -m_Rect.Right, m_Rect.Height, m_Rect.Width);
			graphics.RotateTransform(90f);
			eTextFormat eTextFormat2 = method_21();
			eTextFormat2 |= eTextFormat.HorizontalCenter;
			Class55.smethod_2(graphics, text, GetFont(), color_, displayRectangle, eTextFormat2);
			graphics.ResetTransform();
		}
		if (Focused && DesignMode)
		{
			displayRectangle = DisplayRectangle;
			displayRectangle.Inflate(-1, -1);
			Class32.smethod_0(graphics, displayRectangle, pa.Colors.ItemDesignTimeBorder);
		}
		DrawInsertMarker(graphics);
	}

	private void method_18()
	{
		if (comboBoxEx_0 != null)
		{
			Rectangle displayRectangle = DisplayRectangle;
			displayRectangle.Inflate(-2, -2);
			((Control)comboBoxEx_0).set_Location(displayRectangle.Location);
		}
	}

	public override void RecalcSize()
	{
		if (SuspendLayout)
		{
			return;
		}
		bool isOnMenu = base.IsOnMenu;
		if (Orientation == eOrientation.Horizontal)
		{
			if (Parent != null && Parent is ImageItem)
			{
				m_Rect.Height = ((ImageItem)Parent).SubItemsImageSize.Height + 4;
			}
			else
			{
				m_Rect.Height = SubItemsImageSize.Height + 4;
			}
			if (Style != 0 && Style != eDotNetBarStyle.Office2003 && m_Style != eDotNetBarStyle.VS2005 && !Class109.smethod_69(m_Style))
			{
				if (comboBoxEx_0 != null && m_Rect.Height < ((Control)comboBoxEx_0).get_Height() + 2)
				{
					m_Rect.Height = ((Control)comboBoxEx_0).get_Height() + 2;
				}
			}
			else if (comboBoxEx_0 != null && m_Rect.Height < ((Control)comboBoxEx_0).get_Height() + 2)
			{
				m_Rect.Height = ((Control)comboBoxEx_0).get_Height() + 2;
			}
			m_Rect.Width = int_4 + 4;
			if (m_Text != "" && (bool_23 || isOnMenu))
			{
				object containerControl = ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val != null && BaseItem.IsHandleValid(val))
				{
					Graphics val2 = Class109.smethod_68(val);
					try
					{
						Size empty = Size.Empty;
						empty = ((m_Orientation != eOrientation.Vertical || isOnMenu) ? Class55.smethod_4(val2, m_Text, GetFont(), 0, method_21()) : Class55.smethod_7(val2, m_Text, GetFont(), Size.Empty, method_21()));
						if (empty.Height > SubItemsImageSize.Height && empty.Height > m_Rect.Height)
						{
							m_Rect.Height = empty.Height + 4;
						}
						m_Rect.Width = int_4 + 4 + empty.Width + 8;
					}
					finally
					{
						val2.Dispose();
					}
				}
			}
			Size size = method_20();
			if (base.IsOnMenu && (Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || m_Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(m_Style)))
			{
				m_Rect.Width += size.Width + 7;
			}
			if (base.IsOnCustomizeMenu)
			{
				m_Rect.Width += size.Height + 2;
			}
		}
		else
		{
			m_Rect.Width = SubItemsImageSize.Width + 4;
			string text = Text;
			text = ((!(text == "")) ? (text + " »") : "...");
			object containerControl2 = ContainerControl;
			Control val3 = (Control)((containerControl2 is Control) ? containerControl2 : null);
			if (val3 != null && BaseItem.IsHandleValid(val3))
			{
				Graphics val4 = Class109.smethod_68(val3);
				try
				{
					SizeF sizeF = Class55.smethod_4(val4, text, GetFont(), 0, method_21());
					if (sizeF.Height > (float)SubItemsImageSize.Height)
					{
						m_Rect.Width = (int)sizeF.Height + 4;
					}
					m_Rect.Height = (int)sizeF.Width + 8;
				}
				finally
				{
					val4.Dispose();
				}
			}
		}
		base.RecalcSize();
	}

	protected internal override void OnContainerChanged(object objOldContainer)
	{
		base.OnContainerChanged(objOldContainer);
		if (comboBoxEx_0 == null)
		{
			return;
		}
		if (((Control)comboBoxEx_0).get_Parent() != null)
		{
			if (((Control)comboBoxEx_0).get_Visible())
			{
				((Control)comboBoxEx_0).set_Visible(false);
			}
			Control parent = ((Control)comboBoxEx_0).get_Parent();
			parent.get_Controls().Remove((Control)(object)comboBoxEx_0);
		}
		Control val = null;
		if (ContainerControl != null)
		{
			object containerControl = ContainerControl;
			val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				val.get_Controls().Add((Control)(object)comboBoxEx_0);
				OnDisplayedChanged();
				((Control)comboBoxEx_0).Refresh();
			}
		}
	}

	protected internal override void OnAfterItemRemoved(BaseItem item)
	{
		base.OnBeforeItemRemoved(item);
		ContainerControl = null;
	}

	protected internal override void OnVisibleChanged(bool newValue)
	{
		if (comboBoxEx_0 != null && !newValue)
		{
			((Control)comboBoxEx_0).set_Visible(newValue);
		}
		base.OnVisibleChanged(newValue);
	}

	protected override void OnDisplayedChanged()
	{
		if (comboBoxEx_0 != null && !base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog && !DesignMode)
		{
			((Control)comboBoxEx_0).set_Visible(Displayed);
		}
	}

	protected internal override void OnGotFocus()
	{
		base.OnGotFocus();
		if (comboBoxEx_0 != null && !((Control)comboBoxEx_0).get_Focused() && !base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog && !DesignMode)
		{
			((Control)comboBoxEx_0).Focus();
		}
	}

	private void comboBoxEx_0_LostFocus(object sender, EventArgs e)
	{
		HideToolTip();
		string_7 = ((Control)comboBoxEx_0).get_Text();
		ReleaseFocus();
		if (bool_22)
		{
			bool_22 = false;
			Refresh();
		}
	}

	private void comboBoxEx_0_MouseHover(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!DesignMode && (int)Control.get_MouseButtons() == 0)
		{
			ShowToolTip();
		}
	}

	private void comboBoxEx_0_MouseEnter(object sender, EventArgs e)
	{
		if (!bool_22)
		{
			bool_22 = true;
			Refresh();
		}
	}

	private void comboBoxEx_0_MouseLeave(object sender, EventArgs e)
	{
		HideToolTip();
		if (!((Control)comboBoxEx_0).get_Focused() && bool_22)
		{
			bool_22 = false;
			Refresh();
		}
	}

	private void comboBoxEx_0_VisibleChanged(object sender, EventArgs e)
	{
		HideToolTip();
	}

	private void comboBoxEx_0_GotFocus(object sender, EventArgs e)
	{
		HideToolTip();
		Focus();
		if (!method_2() || DesignMode || eMenuVisibility_0 != eMenuVisibility.VisibleIfRecentlyUsed || bool_25 || !base.IsOnMenu)
		{
			return;
		}
		bool_25 = true;
		for (BaseItem parent = Parent; parent != null; parent = parent.Parent)
		{
			if (parent is IPersonalizedMenuItem personalizedMenuItem)
			{
				personalizedMenuItem.RecentlyUsed = true;
			}
		}
	}

	private void comboBoxEx_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_26)
		{
			RaiseClick();
			if (eventHandler_15 != null)
			{
				eventHandler_15(this, e);
			}
			ExecuteCommand();
		}
	}

	private void comboBoxEx_0_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		HideToolTip();
		if ((int)e.get_KeyCode() == 13 && Parent is PopupItem)
		{
			((PopupItem)Parent).ClosePopup();
		}
	}

	private void comboBoxEx_0_DropDownChange(object object_2, bool bool_28)
	{
		Expanded = bool_28;
		if (!bool_28)
		{
			ReleaseFocus();
		}
	}

	protected override void OnIsOnCustomizeDialogChanged()
	{
		base.OnIsOnCustomizeDialogChanged();
		method_19();
	}

	protected override void OnDesignModeChanged()
	{
		base.OnDesignModeChanged();
		method_19();
	}

	protected override void OnIsOnCustomizeMenuChanged()
	{
		base.OnIsOnCustomizeMenuChanged();
		method_19();
	}

	private void method_19()
	{
		if (!base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog && !DesignMode)
		{
			((Control)comboBoxEx_0).set_Visible(Displayed);
		}
		else
		{
			((Control)comboBoxEx_0).set_Visible(false);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDropDownWidth()
	{
		return ((Control)comboBoxEx_0).get_Width() != ((ComboBox)comboBoxEx_0).get_DropDownWidth();
	}

	public override void ReleaseFocus()
	{
		if (comboBoxEx_0 != null && ((Control)comboBoxEx_0).get_Focused())
		{
			comboBoxEx_0.ReleaseFocus();
		}
		base.ReleaseFocus();
	}

	private Size method_20()
	{
		if (m_Parent != null)
		{
			if (m_Parent is ImageItem imageItem)
			{
				return imageItem.SubItemsImageSize;
			}
			return ImageSize;
		}
		return ImageSize;
	}

	private eTextFormat method_21()
	{
		return eTextFormat.EndEllipsis | eTextFormat.SingleLine | eTextFormat.VerticalCenter;
	}

	protected virtual Font GetFont()
	{
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null)
		{
			return val.get_Font();
		}
		return SystemInformation.get_MenuFont();
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseEnter()
	{
		base.InternalMouseEnter();
		if (!bool_22)
		{
			bool_22 = true;
			Refresh();
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseLeave()
	{
		base.InternalMouseLeave();
		if (bool_22)
		{
			bool_22 = false;
			Refresh();
		}
	}

	protected internal override bool IsAnyOnHandle(int iHandle)
	{
		bool result;
		if (!(result = base.IsAnyOnHandle(iHandle)) && comboBoxEx_0 != null && ((ComboBox)comboBoxEx_0).get_DroppedDown() && comboBoxEx_0.DropDownHandle != IntPtr.Zero && comboBoxEx_0.DropDownHandle.ToInt32() == iHandle)
		{
			result = true;
		}
		return result;
	}

	protected override void OnStyleChanged()
	{
		base.OnStyleChanged();
		comboBoxEx_0.Style = Style;
	}

	protected override void OnEnabledChanged()
	{
		base.OnEnabledChanged();
		if (comboBoxEx_0 != null)
		{
			((Control)comboBoxEx_0).set_Enabled(Enabled);
		}
	}

	private void comboBoxEx_0_TextChanged(object sender, EventArgs e)
	{
		string_7 = ((Control)comboBoxEx_0).get_Text();
		OnComboBoxTextChanged(e);
	}

	protected virtual void OnComboBoxTextChanged(EventArgs e)
	{
		if (eventHandler_14 != null)
		{
			eventHandler_14(this, e);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeWatermarkColor()
	{
		return comboBoxEx_0.WatermarkColor != SystemColors.GrayText;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetWatermarkColor()
	{
		WatermarkColor = SystemColors.GrayText;
	}
}
