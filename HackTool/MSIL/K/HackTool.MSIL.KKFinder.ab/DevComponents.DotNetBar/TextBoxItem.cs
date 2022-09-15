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

[Designer(typeof(TextBoxItemDesigner))]
[ToolboxItem(false)]
[DesignTimeVisible(false)]
public class TextBoxItem : ImageItem, IPersonalizedMenuItem
{
	public delegate void TextChangedEventHandler(object sender);

	private TextChangedEventHandler textChangedEventHandler_0;

	private KeyEventHandler keyEventHandler_0;

	private KeyPressEventHandler keyPressEventHandler_0;

	private KeyEventHandler keyEventHandler_1;

	private EventHandler eventHandler_14;

	private EventHandler eventHandler_15;

	private TextBoxX textBoxX_0;

	private bool bool_22;

	private bool bool_23;

	private int int_4;

	private string string_7 = "";

	private eMenuVisibility eMenuVisibility_0;

	private bool bool_24;

	private static RoundRectangleShapeDescriptor roundRectangleShapeDescriptor_0 = new RoundRectangleShapeDescriptor(3);

	[DevCoBrowsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
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
					method_19();
				}
			}
		}
	}

	[Description("Indicates whether item caption is always shown.")]
	[DefaultValue(false)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	public bool AlwaysShowCaption
	{
		get
		{
			return bool_23;
		}
		set
		{
			bool_23 = value;
		}
	}

	[DefaultValue(64)]
	[Category("Layout")]
	[Browsable(true)]
	[Description("Indicates the Width of the Text Box part of the item.")]
	[DevCoBrowsable(true)]
	public int TextBoxWidth
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
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "TextBoxWidth");
				}
				OnExternalSizeChange();
				OnAppearanceChanged();
			}
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("The text contained in the text box that user can edit.")]
	[DefaultValue("")]
	[Category("Appearance")]
	public virtual string ControlText
	{
		get
		{
			return string_7;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			if (textBoxX_0 != null)
			{
				((Control)textBoxX_0).set_Text(value);
				((TextBoxBase)textBoxX_0).set_SelectionStart(0);
			}
			string_7 = value;
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

	[Category("Appearance")]
	[Description("Indicates the item Caption displayed next to the text input.")]
	[DefaultValue("")]
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

	[Browsable(false)]
	public TextBox TextBox => (TextBox)(object)textBoxX_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int SelectionStart
	{
		get
		{
			if (textBoxX_0 != null)
			{
				return ((TextBoxBase)textBoxX_0).get_SelectionStart();
			}
			return 0;
		}
		set
		{
			if (textBoxX_0 != null)
			{
				((TextBoxBase)textBoxX_0).set_SelectionStart(value);
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int SelectionLength
	{
		get
		{
			if (textBoxX_0 != null)
			{
				return ((TextBoxBase)textBoxX_0).get_SelectionLength();
			}
			return 0;
		}
		set
		{
			if (textBoxX_0 != null)
			{
				((TextBoxBase)textBoxX_0).set_SelectionLength(value);
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string SelectedText
	{
		get
		{
			if (textBoxX_0 != null)
			{
				return ((TextBoxBase)textBoxX_0).get_SelectedText();
			}
			return "";
		}
		set
		{
			if (textBoxX_0 != null)
			{
				((TextBoxBase)textBoxX_0).set_SelectedText(value);
			}
		}
	}

	[DefaultValue(32767)]
	[Description("Indciates maximum number of characters the user can type or paste into the text box control. ")]
	public int MaxLength
	{
		get
		{
			return ((TextBoxBase)textBoxX_0).get_MaxLength();
		}
		set
		{
			if (textBoxX_0 != null)
			{
				((TextBoxBase)textBoxX_0).set_MaxLength(value);
			}
		}
	}

	[Description("Indicates item's visibility when on pop-up menu.")]
	[DevCoBrowsable(true)]
	[DefaultValue(eMenuVisibility.VisibleAlways)]
	[Category("Appearance")]
	[Browsable(true)]
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
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "MenuVisibility");
				}
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(false)]
	public bool RecentlyUsed
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
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "RecentlyUsed");
				}
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool IsWindowed => true;

	[DefaultValue(true)]
	[Description("Indicates whether watermark text is displayed when control is empty.")]
	public virtual bool WatermarkEnabled
	{
		get
		{
			return textBoxX_0.WatermarkEnabled;
		}
		set
		{
			textBoxX_0.WatermarkEnabled = value;
		}
	}

	[Browsable(true)]
	[Localizable(true)]
	[Category("Appearance")]
	[Description("Indicates watermark text displayed inside of the control when Text is not set and control does not have input focus.")]
	[DefaultValue("")]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	public string WatermarkText
	{
		get
		{
			return textBoxX_0.WatermarkText;
		}
		set
		{
			textBoxX_0.WatermarkText = value;
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(null)]
	[Description("Indicates watermark font.")]
	public Font WatermarkFont
	{
		get
		{
			return textBoxX_0.WatermarkFont;
		}
		set
		{
			textBoxX_0.WatermarkFont = value;
		}
	}

	[Description("Indicates watermark text color.")]
	[Category("Appearance")]
	[Browsable(true)]
	public Color WatermarkColor
	{
		get
		{
			return textBoxX_0.WatermarkColor;
		}
		set
		{
			textBoxX_0.WatermarkColor = value;
		}
	}

	[Category("Behavior")]
	[Description("Indicates watermark hiding behaviour.")]
	[DefaultValue(eWatermarkBehavior.HideOnFocus)]
	public eWatermarkBehavior WatermarkBehavior
	{
		get
		{
			return textBoxX_0.WatermarkBehavior;
		}
		set
		{
			textBoxX_0.WatermarkBehavior = value;
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether FocusHighlightColor is used as background color to highlight text box when it has input focus.")]
	public bool FocusHighlightEnabled
	{
		get
		{
			return textBoxX_0.FocusHighlightEnabled;
		}
		set
		{
			textBoxX_0.FocusHighlightEnabled = value;
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[Description("Indicates color used as background color to highlight text box when it has input focus and focus highlight is enabled.")]
	public Color FocusHighlightColor
	{
		get
		{
			return textBoxX_0.FocusHighlightColor;
		}
		set
		{
			textBoxX_0.FocusHighlightColor = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[ParenthesizePropertyName(true)]
	[RefreshProperties(RefreshProperties.All)]
	public new ControlBindingsCollection DataBindings => ((Control)textBoxX_0).get_DataBindings();

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Describes the settings for the custom button that can execute an custom action of your choosing when clicked.")]
	[Category("Buttons")]
	public InputButtonSettings ButtonCustom => textBoxX_0.ButtonCustom;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Describes the settings for the custom button that can execute an custom action of your choosing when clicked.")]
	[Category("Buttons")]
	[Browsable(true)]
	public InputButtonSettings ButtonCustom2 => textBoxX_0.ButtonCustom2;

	public event TextChangedEventHandler InputTextChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			textChangedEventHandler_0 = (TextChangedEventHandler)Delegate.Combine(textChangedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			textChangedEventHandler_0 = (TextChangedEventHandler)Delegate.Remove(textChangedEventHandler_0, value);
		}
	}

	public event KeyEventHandler KeyDown
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			keyEventHandler_0 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)keyEventHandler_0, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			keyEventHandler_0 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)keyEventHandler_0, (Delegate?)(object)value);
		}
	}

	public event KeyPressEventHandler KeyPress
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			keyPressEventHandler_0 = (KeyPressEventHandler)Delegate.Combine((Delegate?)(object)keyPressEventHandler_0, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			keyPressEventHandler_0 = (KeyPressEventHandler)Delegate.Remove((Delegate?)(object)keyPressEventHandler_0, (Delegate?)(object)value);
		}
	}

	public event KeyEventHandler KeyUp
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			keyEventHandler_1 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)keyEventHandler_1, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			keyEventHandler_1 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)keyEventHandler_1, (Delegate?)(object)value);
		}
	}

	public event EventHandler ButtonCustomClick
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

	public event EventHandler ButtonCustom2Click
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

	public TextBoxItem()
		: this("", "")
	{
	}

	public TextBoxItem(string sName)
		: this(sName, "")
	{
	}

	public TextBoxItem(string sName, string ItemText)
		: base(sName, ItemText)
	{
		method_17();
		bool_22 = false;
		bool_23 = false;
		int_4 = 64;
		ImageSize = new Size(16, 16);
		m_SupportedOrientation = eSupportedOrientation.Horizontal;
	}

	private void method_17()
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		if (textBoxX_0 != null)
		{
			((Control)textBoxX_0).remove_MouseEnter((EventHandler)textBoxX_0_MouseEnter);
			((Control)textBoxX_0).remove_MouseLeave((EventHandler)textBoxX_0_MouseLeave);
			((Control)textBoxX_0).remove_MouseHover((EventHandler)textBoxX_0_MouseHover);
			((Control)textBoxX_0).remove_LostFocus((EventHandler)textBoxX_0_LostFocus);
			((Control)textBoxX_0).remove_GotFocus((EventHandler)textBoxX_0_GotFocus);
			((Control)textBoxX_0).remove_TextChanged((EventHandler)textBoxX_0_TextChanged);
			((Control)textBoxX_0).remove_KeyDown(new KeyEventHandler(textBoxX_0_KeyDown));
			((Control)textBoxX_0).remove_KeyPress(new KeyPressEventHandler(textBoxX_0_KeyPress));
			((Control)textBoxX_0).remove_KeyUp(new KeyEventHandler(textBoxX_0_KeyUp));
			textBoxX_0.ButtonCustomClick -= textBoxX_0_ButtonCustomClick;
			textBoxX_0.ButtonCustom2Click -= textBoxX_0_ButtonCustom2Click;
			((Component)(object)textBoxX_0).Dispose();
			textBoxX_0 = null;
		}
		textBoxX_0 = new TextBoxX(isTextBoxItem: true);
		textBoxX_0.BorderStyle = (BorderStyle)0;
		((Control)textBoxX_0).set_AutoSize(false);
		((Control)textBoxX_0).set_Visible(false);
		((Control)textBoxX_0).set_TabStop(false);
		((Control)textBoxX_0).add_MouseEnter((EventHandler)textBoxX_0_MouseEnter);
		((Control)textBoxX_0).add_MouseLeave((EventHandler)textBoxX_0_MouseLeave);
		((Control)textBoxX_0).add_MouseHover((EventHandler)textBoxX_0_MouseHover);
		((Control)textBoxX_0).add_LostFocus((EventHandler)textBoxX_0_LostFocus);
		((Control)textBoxX_0).add_GotFocus((EventHandler)textBoxX_0_GotFocus);
		((Control)textBoxX_0).add_TextChanged((EventHandler)textBoxX_0_TextChanged);
		((Control)textBoxX_0).add_KeyDown(new KeyEventHandler(textBoxX_0_KeyDown));
		((Control)textBoxX_0).add_KeyPress(new KeyPressEventHandler(textBoxX_0_KeyPress));
		((Control)textBoxX_0).add_KeyUp(new KeyEventHandler(textBoxX_0_KeyUp));
		textBoxX_0.ButtonCustomClick += textBoxX_0_ButtonCustomClick;
		textBoxX_0.ButtonCustom2Click += textBoxX_0_ButtonCustom2Click;
		((Control)textBoxX_0).set_Text(string_7);
		((TextBoxBase)textBoxX_0).set_SelectionStart(0);
		if (ContainerControl != null)
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				val.get_Controls().Add((Control)(object)textBoxX_0);
			}
		}
		if (Displayed)
		{
			((Control)textBoxX_0).set_Visible(true);
			Refresh();
		}
		method_21();
	}

	private void textBoxX_0_ButtonCustomClick(object sender, EventArgs e)
	{
		if (eventHandler_14 != null)
		{
			eventHandler_14(this, e);
		}
	}

	private void textBoxX_0_ButtonCustom2Click(object sender, EventArgs e)
	{
		if (eventHandler_15 != null)
		{
			eventHandler_15(this, e);
		}
	}

	public override BaseItem Copy()
	{
		TextBoxItem textBoxItem = new TextBoxItem(Name);
		CopyToItem(textBoxItem);
		return textBoxItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		TextBoxItem textBoxItem = copy as TextBoxItem;
		base.CopyToItem(textBoxItem);
		textBoxItem.ControlText = string_7;
		textBoxItem.TextBoxWidth = int_4;
	}

	public override void Dispose()
	{
		if (textBoxX_0 != null)
		{
			if (((Control)textBoxX_0).get_Parent() != null)
			{
				((Control)textBoxX_0).get_Parent().get_Controls().Remove((Control)(object)textBoxX_0);
			}
			((Component)(object)textBoxX_0).Dispose();
			textBoxX_0 = null;
		}
		base.Dispose();
	}

	protected internal override void Serialize(ItemSerializationContext context)
	{
		base.Serialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		itemXmlElement.SetAttribute("CText", string_7);
		itemXmlElement.SetAttribute("TextBoxWidth", XmlConvert.ToString(int_4));
		itemXmlElement.SetAttribute("AlwaysShowCaption", XmlConvert.ToString(bool_23));
		itemXmlElement.SetAttribute("MenuVisibility", XmlConvert.ToString((int)eMenuVisibility_0));
		itemXmlElement.SetAttribute("RecentlyUsed", XmlConvert.ToString(bool_24));
	}

	protected internal override void Deserialize(ItemSerializationContext context)
	{
		base.Deserialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		ControlText = itemXmlElement.GetAttribute("CText");
		int_4 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("TextBoxWidth"));
		bool_23 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("AlwaysShowCaption"));
		eMenuVisibility_0 = (eMenuVisibility)XmlConvert.ToInt32(itemXmlElement.GetAttribute("MenuVisibility"));
		bool_24 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("RecentlyUsed"));
	}

	public override void Paint(ItemPaintArgs pa)
	{
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected O, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Expected O, but got Unknown
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab5: Expected O, but got Unknown
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Expected O, but got Unknown
		if (SuspendLayout)
		{
			return;
		}
		Graphics graphics = pa.Graphics;
		Rectangle displayRectangle = DisplayRectangle;
		bool flag = method_1(pa.ContainerControl);
		Size size = method_20();
		bool flag2 = base.IsOnMenu && !(Parent is ItemContainer);
		if (Orientation == eOrientation.Horizontal)
		{
			if (flag2 && (Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style)))
			{
				size.Width += 7;
				displayRectangle.Width -= size.Width;
				if (!pa.RightToLeft)
				{
					displayRectangle.X += size.Width;
				}
				if (base.IsOnCustomizeMenu)
				{
					size.Width += size.Height + 8;
				}
				Rectangle rectangle = new Rectangle(m_Rect.Left, m_Rect.Top, size.Width, m_Rect.Height);
				if (pa.RightToLeft)
				{
					rectangle.X = m_Rect.Right - rectangle.Width;
				}
				if (MenuVisibility == eMenuVisibility.VisibleIfRecentlyUsed && !RecentlyUsed)
				{
					if (!pa.Colors.MenuUnusedSide2.IsEmpty)
					{
						LinearGradientBrush val = Class109.smethod_40(new Rectangle(m_Rect.Left, m_Rect.Top, size.Width, m_Rect.Height), pa.Colors.MenuUnusedSide, pa.Colors.MenuUnusedSide2, pa.Colors.MenuUnusedSideGradientAngle);
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
							Class50.smethod_42(graphics, rectangle.X, rectangle.Y, rectangle.X, rectangle.Bottom - 1, menu.SideBorder, 1);
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
							Class50.smethod_42(graphics, rectangle.X + 1, rectangle.Y, rectangle.X + 1, rectangle.Bottom - 1, menu.SideBorderLight, 1);
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
				if (Style != 0 && Style != eDotNetBarStyle.Office2003 && Style != eDotNetBarStyle.VS2005 && !Class109.smethod_69(Style))
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
			if (flag2 && (Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style)) && flag && (bool_22 || Focused))
			{
				Rectangle displayRectangle2 = DisplayRectangle;
				displayRectangle2.Inflate(-1, 0);
				if (Class109.smethod_69(Style) && !(pa.Owner is DotNetBarManager) && GlobalManager.Renderer is Office2007Renderer)
				{
					Office2007ButtonItemStateColorTable mouseOver = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.ButtonItemColors[0].MouseOver;
					Class268.smethod_4(graphics, mouseOver, displayRectangle2, roundRectangleShapeDescriptor_0);
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
			if (m_Text != "" && (bool_23 || flag2))
			{
				eTextFormat eTextFormat2 = method_22();
				Font font = GetFont();
				Rectangle rectangle_ = new Rectangle(displayRectangle.X + 8, displayRectangle.Y, displayRectangle.Width - 8, displayRectangle.Height);
				if (pa.RightToLeft)
				{
					eTextFormat2 |= eTextFormat.Right;
					rectangle_.Width -= 9;
				}
				Color color_ = pa.Colors.ItemText;
				if (Style == eDotNetBarStyle.Office2007 && GlobalManager.Renderer is Office2007Renderer)
				{
					color_ = (flag ? ((Office2007Renderer)GlobalManager.Renderer).ColorTable.ButtonItemColors[0].Default.Text : pa.Colors.ItemDisabledText);
				}
				if (Style == eDotNetBarStyle.Office2000)
				{
					Class55.smethod_1(graphics, m_Text, font, color_, rectangle_, eTextFormat2);
				}
				else
				{
					Class55.smethod_1(graphics, m_Text, font, color_, rectangle_, eTextFormat2);
				}
				Size size2 = Class55.smethod_4(graphics, m_Text, font, 0, eTextFormat2);
				if (!pa.RightToLeft)
				{
					displayRectangle.X += size2.Width + 8;
				}
				displayRectangle.Width -= size2.Width + 8;
			}
			if (DesignMode && !flag2)
			{
				Rectangle rectangle2 = displayRectangle;
				rectangle2.Inflate(-2, -2);
				graphics.FillRectangle(SystemBrushes.get_Window(), rectangle2);
				if (string_7 != "")
				{
					rectangle2.Inflate(-1, -1);
					Class55.smethod_1(graphics, string_7, GetFont(), flag ? pa.Colors.ItemText : pa.Colors.ItemDisabledText, rectangle2, method_22());
				}
			}
			if (textBoxX_0 != null)
			{
				displayRectangle.Inflate(-5, -3);
				((Control)textBoxX_0).set_Size(displayRectangle.Size);
				Point location = displayRectangle.Location;
				if (pa.RightToLeft)
				{
					location.Offset(0, (displayRectangle.Height - ((Control)textBoxX_0).get_Height()) / 2);
				}
				else
				{
					location.Offset((displayRectangle.Width - ((Control)textBoxX_0).get_Width()) / 2, (displayRectangle.Height - ((Control)textBoxX_0).get_Height()) / 2);
				}
				((Control)textBoxX_0).set_Location(location);
				if (Class109.smethod_69(Style))
				{
					Color color_2 = Color.Empty;
					ElementStyle elementStyle = method_18();
					if (!flag)
					{
						color_2 = SystemColors.ControlDark;
					}
					else if (elementStyle != null)
					{
						color_2 = elementStyle.BorderColor;
					}
					if (!color_2.IsEmpty)
					{
						displayRectangle = new Rectangle(((Control)textBoxX_0).get_Location(), ((Control)textBoxX_0).get_Size());
						displayRectangle.Inflate(1, 1);
						Class50.smethod_6(graphics, color_2, displayRectangle);
					}
				}
				else if (flag && (bool_22 || Focused))
				{
					if (Style == eDotNetBarStyle.Office2000)
					{
						displayRectangle = new Rectangle(((Control)textBoxX_0).get_Location(), ((Control)textBoxX_0).get_Size());
						displayRectangle.Inflate(2, 2);
						ControlPaint.DrawBorder3D(graphics, displayRectangle, (Border3DStyle)2, (Border3DSide)2063);
					}
					else if (Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005)
					{
						displayRectangle = new Rectangle(((Control)textBoxX_0).get_Location(), ((Control)textBoxX_0).get_Size());
						displayRectangle.Inflate(1, 1);
						Class92.smethod_4(graphics, SystemPens.get_Highlight(), displayRectangle);
					}
				}
			}
			else
			{
				displayRectangle.Inflate(-3, -3);
				graphics.FillRectangle(SystemBrushes.get_Window(), displayRectangle);
			}
			if (base.IsOnCustomizeMenu && Visible)
			{
				Rectangle rectangle_2 = new Rectangle(m_Rect.Left, m_Rect.Top, m_Rect.Height, m_Rect.Height);
				if (Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style))
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
			if (Style != 0 && Style != eDotNetBarStyle.Office2003 && Style != eDotNetBarStyle.VS2005 && !Class109.smethod_69(Style))
			{
				graphics.FillRectangle(SystemBrushes.get_Control(), DisplayRectangle);
			}
			else
			{
				graphics.FillRectangle((Brush)new SolidBrush(pa.Colors.BarBackground), DisplayRectangle);
			}
			if (bool_22 && !DesignMode)
			{
				if (Style == eDotNetBarStyle.Office2000)
				{
					ControlPaint.DrawBorder3D(graphics, displayRectangle, (Border3DStyle)4, (Border3DSide)2063);
				}
				else if (Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style))
				{
					displayRectangle.Inflate(-1, -1);
					if (!pa.Colors.ItemHotBackground2.IsEmpty)
					{
						LinearGradientBrush val4 = Class109.smethod_40(displayRectangle, pa.Colors.ItemHotBackground, pa.Colors.ItemHotBackground2, pa.Colors.ItemHotBackgroundGradientAngle);
						graphics.FillRectangle((Brush)(object)val4, displayRectangle);
						((Brush)val4).Dispose();
					}
					else
					{
						graphics.FillRectangle((Brush)new SolidBrush(pa.Colors.ItemHotBackground), displayRectangle);
					}
					Class92.smethod_4(graphics, new Pen(pa.Colors.ItemHotBorder), displayRectangle);
				}
			}
			displayRectangle = new Rectangle(m_Rect.Top, -m_Rect.Right, m_Rect.Height, m_Rect.Width);
			graphics.RotateTransform(90f);
			eTextFormat eTextFormat3 = method_22();
			eTextFormat3 |= eTextFormat.HorizontalCenter;
			if (bool_22 && flag)
			{
				Class55.smethod_2(graphics, text, GetFont(), pa.Colors.ItemHotText, displayRectangle, eTextFormat3);
			}
			else
			{
				Class55.smethod_2(graphics, text, GetFont(), flag ? pa.Colors.ItemText : pa.Colors.ItemDisabledText, displayRectangle, eTextFormat3);
			}
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

	private ElementStyle method_18()
	{
		ElementStyle result = null;
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			result = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.StyleClasses[ElementStyleClassKeys.TextBoxBorderKey] as ElementStyle;
		}
		return result;
	}

	private void method_19()
	{
		if (textBoxX_0 != null)
		{
			Rectangle displayRectangle = DisplayRectangle;
			displayRectangle.Inflate(-5, -3);
			((Control)textBoxX_0).set_Location(displayRectangle.Location);
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
						Size size = Class55.smethod_4(val2, m_Text, GetFont(), 0, method_22());
						if (size.Height > SubItemsImageSize.Height)
						{
							m_Rect.Height = size.Height + 4;
						}
						m_Rect.Width = int_4 + 4 + size.Width + 8;
					}
					finally
					{
						val2.Dispose();
					}
				}
			}
			if (textBoxX_0.ButtonCustom.Visible && textBoxX_0.ButtonCustom.Image != null)
			{
				m_Rect.Height = Math.Max(m_Rect.Height, textBoxX_0.ButtonCustom.Image.get_Height() + 6);
			}
			if (textBoxX_0.ButtonCustom2.Visible && textBoxX_0.ButtonCustom2.Image != null)
			{
				m_Rect.Height = Math.Max(m_Rect.Height, textBoxX_0.ButtonCustom2.Image.get_Height() + 6);
			}
			Size size2 = method_20();
			if (textBoxX_0 != null && m_Rect.Height < ((Control)textBoxX_0).get_Height())
			{
				((Control)textBoxX_0).set_Height(size2.Height + 2);
				if (m_Rect.Height < ((Control)textBoxX_0).get_Height())
				{
					m_Rect.Height = ((Control)textBoxX_0).get_Height() + 4;
				}
			}
			if (base.IsOnMenu && (Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style)))
			{
				m_Rect.Width += size2.Width + 7;
			}
			if (base.IsOnCustomizeMenu)
			{
				m_Rect.Width += size2.Height + 2;
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
					Size size3 = Class55.smethod_4(val4, text, GetFont(), 0, method_22());
					if (size3.Height > SubItemsImageSize.Height)
					{
						m_Rect.Width = size3.Height + 4;
					}
					m_Rect.Height = size3.Width + 8;
				}
				finally
				{
					val4.Dispose();
				}
			}
		}
		base.RecalcSize();
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

	protected internal override void OnContainerChanged(object objOldContainer)
	{
		base.OnContainerChanged(objOldContainer);
		if (textBoxX_0 == null)
		{
			return;
		}
		if (((Control)textBoxX_0).get_Parent() != null)
		{
			((Control)textBoxX_0).get_Parent().get_Controls().Remove((Control)(object)textBoxX_0);
		}
		if (objOldContainer is MenuPanel)
		{
			method_17();
		}
		Control val = null;
		if (ContainerControl != null)
		{
			object containerControl = ContainerControl;
			val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				val.get_Controls().Add((Control)(object)textBoxX_0);
			}
		}
	}

	protected internal override void OnAfterItemRemoved(BaseItem item)
	{
		base.OnAfterItemRemoved(item);
		ContainerControl = null;
	}

	protected internal override void OnVisibleChanged(bool newValue)
	{
		if (textBoxX_0 != null && !newValue)
		{
			((Control)textBoxX_0).set_Visible(newValue);
			method_21();
		}
		base.OnVisibleChanged(newValue);
	}

	protected override void OnDisplayedChanged()
	{
		if (textBoxX_0 != null)
		{
			((Control)textBoxX_0).set_Visible(Displayed);
			method_21();
		}
	}

	private void textBoxX_0_MouseEnter(object sender, EventArgs e)
	{
		if (!bool_22)
		{
			bool_22 = true;
			Refresh();
		}
	}

	private void textBoxX_0_MouseLeave(object sender, EventArgs e)
	{
		HideToolTip();
		if (bool_22)
		{
			bool_22 = false;
			Refresh();
		}
	}

	private void textBoxX_0_MouseHover(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!DesignMode && (int)Control.get_MouseButtons() == 0)
		{
			ShowToolTip();
		}
	}

	private void textBoxX_0_LostFocus(object sender, EventArgs e)
	{
		string_7 = ((Control)textBoxX_0).get_Text();
		ReleaseFocus();
		HideToolTip();
		Refresh();
	}

	protected internal override void OnLostFocus()
	{
		if (textBoxX_0 != null)
		{
			string_7 = ((Control)textBoxX_0).get_Text();
		}
		base.OnLostFocus();
	}

	protected internal override void OnGotFocus()
	{
		base.OnGotFocus();
		if (textBoxX_0 != null && !((Control)textBoxX_0).get_Focused() && !base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog && !DesignMode)
		{
			((Control)textBoxX_0).Focus();
		}
	}

	private void textBoxX_0_GotFocus(object sender, EventArgs e)
	{
		HideToolTip();
		Focus();
		if (!method_2() || DesignMode || eMenuVisibility_0 != eMenuVisibility.VisibleIfRecentlyUsed || bool_24 || !base.IsOnMenu)
		{
			return;
		}
		bool_24 = true;
		for (BaseItem parent = Parent; parent != null; parent = parent.Parent)
		{
			if (parent is IPersonalizedMenuItem personalizedMenuItem)
			{
				personalizedMenuItem.RecentlyUsed = true;
			}
		}
	}

	private void textBoxX_0_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		HideToolTip();
		if (keyEventHandler_0 != null)
		{
			keyEventHandler_0.Invoke((object)this, e);
		}
		if ((int)e.get_KeyCode() == 13 && Parent is PopupItem)
		{
			RaiseClick();
		}
		if ((int)e.get_KeyCode() == 27)
		{
			textBoxX_0.method_0();
		}
	}

	private void textBoxX_0_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (keyPressEventHandler_0 != null)
		{
			keyPressEventHandler_0.Invoke((object)this, e);
		}
	}

	private void textBoxX_0_KeyUp(object sender, KeyEventArgs e)
	{
		if (keyEventHandler_1 != null)
		{
			keyEventHandler_1.Invoke((object)this, e);
		}
	}

	private void textBoxX_0_TextChanged(object sender, EventArgs e)
	{
		string_7 = ((Control)textBoxX_0).get_Text();
		if (textChangedEventHandler_0 != null)
		{
			textChangedEventHandler_0(this);
		}
		if (GetOwner() is DotNetBarManager dotNetBarManager)
		{
			dotNetBarManager.InvokeTextBoxItemTextChanged(this);
		}
	}

	protected override void OnIsOnCustomizeDialogChanged()
	{
		base.OnIsOnCustomizeDialogChanged();
		method_21();
	}

	protected override void OnDesignModeChanged()
	{
		base.OnDesignModeChanged();
		method_21();
	}

	protected override void OnIsOnCustomizeMenuChanged()
	{
		base.OnIsOnCustomizeMenuChanged();
		method_21();
	}

	private void method_21()
	{
		if (!base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog && !DesignMode)
		{
			if (textBoxX_0 == null)
			{
				method_17();
			}
			else if (!((Control)textBoxX_0).get_Visible())
			{
				((Control)textBoxX_0).set_Visible(Displayed && Visible);
			}
		}
		else if (textBoxX_0 != null)
		{
			((Control)textBoxX_0).set_Visible(false);
		}
	}

	public override void InternalMouseEnter()
	{
		base.InternalMouseEnter();
		if (!bool_22)
		{
			bool_22 = true;
			Refresh();
		}
	}

	public override void InternalMouseLeave()
	{
		base.InternalMouseLeave();
		if (bool_22)
		{
			bool_22 = false;
			Refresh();
		}
	}

	public override void InternalKeyDown(KeyEventArgs objArg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		if ((int)objArg.get_KeyCode() == 27)
		{
			if (((Control)textBoxX_0).get_Focused())
			{
				((TextBoxBase)textBoxX_0).set_SelectionStart(0);
				((Control)textBoxX_0).set_Text(string_7);
			}
		}
		else if ((int)objArg.get_KeyCode() == 13 && !((Control)textBoxX_0).get_Focused())
		{
			((Control)textBoxX_0).Focus();
			objArg.set_Handled(true);
			return;
		}
		base.InternalKeyDown(objArg);
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

	private eTextFormat method_22()
	{
		return eTextFormat.EndEllipsis | eTextFormat.SingleLine | eTextFormat.VerticalCenter;
	}

	public override void ReleaseFocus()
	{
		if (textBoxX_0 != null && ((Control)textBoxX_0).get_Focused())
		{
			textBoxX_0.method_0();
		}
		base.ReleaseFocus();
	}

	protected override void OnEnabledChanged()
	{
		base.OnEnabledChanged();
		if (textBoxX_0 != null)
		{
			((Control)textBoxX_0).set_Enabled(Enabled);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeWatermarkColor()
	{
		return textBoxX_0.WatermarkColor != SystemColors.GrayText;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetWatermarkColor()
	{
		WatermarkColor = SystemColors.GrayText;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeFocusHighlightColor()
	{
		return textBoxX_0.ShouldSerializeFocusHighlightColor();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void ResetFocusHighlightColor()
	{
		textBoxX_0.ResetFocusHighlightColor();
	}
}
