using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.ColorPickerItem;

namespace DevComponents.DotNetBar;

[DefaultEvent("SelectedColorChanged")]
public class ColorPickerDropDown : ButtonItem
{
	private EventHandler eventHandler_20;

	private ColorPreviewEventHandler colorPreviewEventHandler_0;

	private CancelObjectValueEventHandler cancelObjectValueEventHandler_0;

	private bool bool_49;

	private bool bool_50 = true;

	private bool bool_51 = true;

	private bool bool_52 = true;

	private bool bool_53;

	private string string_11 = "Theme Colors";

	private string string_12 = "Standard Colors";

	private string string_13 = "&More Colors...";

	private Color color_2 = Color.Empty;

	private Rectangle rectangle_3 = Rectangle.Empty;

	private bool bool_54;

	private IWin32Window iwin32Window_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	public Color SelectedColor
	{
		get
		{
			return color_2;
		}
		set
		{
			method_49(value, bool_55: false);
		}
	}

	[Category("Appearance")]
	[DefaultValue(true)]
	[DevCoSerialize]
	[Description("Indicates whether theme colors are displayed on drop-down.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public bool DisplayThemeColors
	{
		get
		{
			return bool_50;
		}
		set
		{
			bool_50 = value;
		}
	}

	[DefaultValue(true)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Appearance")]
	[DevCoSerialize]
	[Description("Indicates whether standard colors are displayed on drop-down.")]
	public bool DisplayStandardColors
	{
		get
		{
			return bool_51;
		}
		set
		{
			bool_51 = value;
		}
	}

	[Description("Indicates more colors menu item is visible which allows user to open Custom Colors dialog box.")]
	[DefaultValue(true)]
	[DevCoSerialize]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Browsable(true)]
	public bool DisplayMoreColors
	{
		get
		{
			return bool_52;
		}
		set
		{
			bool_52 = value;
		}
	}

	[Browsable(true)]
	[Description("Indicates rectangle in Image coordinates where selected color will be painted. Property will have effect only if Image property is used to set the image.")]
	[Category("Behaviour")]
	public Rectangle SelectedColorImageRectangle
	{
		get
		{
			return rectangle_3;
		}
		set
		{
			rectangle_3 = value;
			UpdateSelectedColorImage();
		}
	}

	[Browsable(false)]
	public bool ColorsInitialized => bool_49;

	[Browsable(false)]
	[DefaultValue(null)]
	public IWin32Window OwnerWindow
	{
		get
		{
			return iwin32Window_0;
		}
		set
		{
			iwin32Window_0 = value;
		}
	}

	protected override bool ShouldAutoExpandOnClick
	{
		get
		{
			if (!base.ShouldAutoExpandOnClick)
			{
				return color_2.IsEmpty;
			}
			return true;
		}
	}

	[Description("Occurs when color is chosen from drop-down color picker or from Custom Colors dialog box.")]
	public event EventHandler SelectedColorChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_20 = (EventHandler)Delegate.Combine(eventHandler_20, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_20 = (EventHandler)Delegate.Remove(eventHandler_20, value);
		}
	}

	[Description("Occurs when mouse is moving over the colors presented by the color picker")]
	public event ColorPreviewEventHandler ColorPreview
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			colorPreviewEventHandler_0 = (ColorPreviewEventHandler)Delegate.Combine(colorPreviewEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			colorPreviewEventHandler_0 = (ColorPreviewEventHandler)Delegate.Remove(colorPreviewEventHandler_0, value);
		}
	}

	public event CancelObjectValueEventHandler BeforeColorDialog
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelObjectValueEventHandler_0 = (CancelObjectValueEventHandler)Delegate.Combine(cancelObjectValueEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelObjectValueEventHandler_0 = (CancelObjectValueEventHandler)Delegate.Remove(cancelObjectValueEventHandler_0, value);
		}
	}

	public ColorPickerDropDown()
		: this("", "")
	{
	}

	public ColorPickerDropDown(string sItemName)
		: this(sItemName, "")
	{
	}

	public ColorPickerDropDown(string sItemName, string ItemText)
		: base(sItemName, ItemText)
	{
		SubItems.Add(new ButtonItem("tempColorPickerItem"));
	}

	public override BaseItem Copy()
	{
		ColorPickerDropDown colorPickerDropDown = new ColorPickerDropDown();
		CopyToItem(colorPickerDropDown);
		return colorPickerDropDown;
	}

	protected override void CopyToItem(BaseItem c)
	{
		ColorPickerDropDown colorPickerDropDown = c as ColorPickerDropDown;
		colorPickerDropDown.DisplayMoreColors = DisplayMoreColors;
		colorPickerDropDown.DisplayStandardColors = DisplayStandardColors;
		colorPickerDropDown.DisplayThemeColors = DisplayThemeColors;
		colorPickerDropDown.eventHandler_20 = eventHandler_20;
		base.CopyToItem((BaseItem)colorPickerDropDown);
	}

	protected virtual void OnColorPreview(ColorPreviewEventArgs e)
	{
		if (colorPreviewEventHandler_0 != null)
		{
			colorPreviewEventHandler_0(this, e);
		}
	}

	public void InvokeColorPreview(ColorPreviewEventArgs e)
	{
		OnColorPreview(e);
	}

	protected override bool ShouldSerializeSubItems()
	{
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeSelectedColorImageRectangle()
	{
		return !rectangle_3.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetSelectedColorImageRectangle()
	{
		SelectedColorImageRectangle = Rectangle.Empty;
	}

	protected override void OnPopupOpen(PopupOpenEventArgs e)
	{
		if (!bool_49)
		{
			method_43();
		}
		base.OnPopupOpen(e);
	}

	private void method_43()
	{
		SubItems.Clear();
		method_54();
		if (bool_50)
		{
			LabelItem labelItem = new LabelItem();
			labelItem.CanCustomize = false;
			labelItem.Text = string_11;
			labelItem.BackColor = ColorScheme.GetColor("DDE7EE");
			labelItem.ForeColor = ColorScheme.GetColor("00156E");
			labelItem.PaddingBottom = 1;
			labelItem.PaddingLeft = 0;
			labelItem.PaddingRight = 0;
			labelItem.PaddingTop = 1;
			labelItem.BorderSide = eBorderSide.Bottom;
			labelItem.SingleLineColor = ColorScheme.GetColor("C5C5C5");
			labelItem.BorderType = eBorderType.SingleLine;
			SubItems.Add(labelItem);
			ArrayList themeColors = GetThemeColors();
			method_46(themeColors);
		}
		if (bool_51)
		{
			LabelItem labelItem2 = new LabelItem();
			labelItem2.CanCustomize = false;
			labelItem2.Text = string_12;
			labelItem2.BackColor = ColorScheme.GetColor("DDE7EE");
			labelItem2.ForeColor = ColorScheme.GetColor("00156E");
			labelItem2.PaddingBottom = 1;
			labelItem2.PaddingLeft = 0;
			labelItem2.PaddingRight = 0;
			labelItem2.PaddingTop = 1;
			labelItem2.BorderSide = eBorderSide.Bottom;
			labelItem2.SingleLineColor = ColorScheme.GetColor("C5C5C5");
			labelItem2.BorderType = eBorderType.SingleLine;
			SubItems.Add(labelItem2);
			ArrayList standardColors = GetStandardColors();
			method_46(standardColors);
		}
		if (bool_52)
		{
			ButtonItem buttonItem = new ButtonItem("sys_CPMoreColors", string_13);
			buttonItem.CanCustomize = false;
			buttonItem.Image = (Image)(object)Class109.smethod_67("SystemImages.ColorPickerCustomColors.png");
			buttonItem.Click += method_44;
			buttonItem.BeginGroup = true;
			SubItems.Add(buttonItem);
		}
		bool_49 = true;
	}

	private void method_44(object sender, EventArgs e)
	{
		DisplayMoreColorsDialog();
	}

	public void DisplayMoreColorsDialog()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		CustomColorDialog customColorDialog = new CustomColorDialog();
		customColorDialog.method_29(Style);
		((Form)customColorDialog).set_StartPosition((FormStartPosition)1);
		if (!SelectedColor.IsEmpty)
		{
			customColorDialog.Color_0 = SelectedColor;
		}
		method_45(customColorDialog);
		CancelObjectValueEventArgs cancelObjectValueEventArgs = new CancelObjectValueEventArgs(customColorDialog);
		OnBeforeColorDialog(cancelObjectValueEventArgs);
		if (cancelObjectValueEventArgs.Cancel)
		{
			((Component)(object)customColorDialog).Dispose();
			return;
		}
		if (iwin32Window_0 != null)
		{
			((Form)customColorDialog).ShowDialog(iwin32Window_0);
		}
		else
		{
			((Form)customColorDialog).ShowDialog();
		}
		if ((int)((Form)customColorDialog).get_DialogResult() == 1 && !customColorDialog.Color_1.IsEmpty)
		{
			method_48(customColorDialog.Color_1);
		}
		((Component)(object)customColorDialog).Dispose();
	}

	protected virtual void OnBeforeColorDialog(CancelObjectValueEventArgs e)
	{
		cancelObjectValueEventHandler_0?.Invoke(this, e);
	}

	private void method_45(CustomColorDialog customColorDialog_0)
	{
		if (GetOwner() != null)
		{
			bool_53 = true;
		}
		using Class264 @class = new Class264(GetOwner() as IOwnerLocalize);
		string text = @class.method_1(LocalizationKeys.ColorPickerDialogOKButton);
		if (text != "")
		{
			((Control)customColorDialog_0.buttonOK).set_Text(text);
		}
		text = @class.method_1(LocalizationKeys.ColorPickerDialogCancelButton);
		if (text != "")
		{
			((Control)customColorDialog_0.buttonCancel).set_Text(text);
		}
		text = @class.method_1(LocalizationKeys.ColorPickerDialogNewColorLabel);
		if (text != "")
		{
			((Control)customColorDialog_0.labelNewColor).set_Text(text);
		}
		text = @class.method_1(LocalizationKeys.ColorPickerDialogCurrentColorLabel);
		if (text != "")
		{
			((Control)customColorDialog_0.labelCurrentColor).set_Text(text);
		}
		text = @class.method_1(LocalizationKeys.ColorPickerDialogStandardColorsLabel);
		if (text != "")
		{
			((Control)customColorDialog_0.labelStandardColors).set_Text(text);
		}
		text = @class.method_1(LocalizationKeys.ColorPickerDialogCustomColorsLabel);
		if (text != "")
		{
			((Control)customColorDialog_0.labelCustomColors).set_Text(text);
		}
		text = @class.method_1(LocalizationKeys.ColorPickerDialogGreenLabel);
		if (text != "")
		{
			((Control)customColorDialog_0.labelGreen).set_Text(text);
		}
		text = @class.method_1(LocalizationKeys.ColorPickerDialogBlueLabel);
		if (text != "")
		{
			((Control)customColorDialog_0.labelBlue).set_Text(text);
		}
		text = @class.method_1(LocalizationKeys.ColorPickerDialogRedLabel);
		if (text != "")
		{
			((Control)customColorDialog_0.labelRed).set_Text(text);
		}
		text = @class.method_1(LocalizationKeys.ColorPickerTabStandard);
		if (text != "")
		{
			customColorDialog_0.tabItemStandard.Text = text;
		}
		text = @class.method_1(LocalizationKeys.ColorPickerTabCustom);
		if (text != "")
		{
			customColorDialog_0.tabItemCustom.Text = text;
		}
		text = @class.method_1(LocalizationKeys.ColorPickerCaption);
		if (text != "")
		{
			((Control)customColorDialog_0).set_Text(text);
		}
		text = @class.method_1(LocalizationKeys.ColorPickerDialogColorModelLabel);
		if (text != "")
		{
			((Control)customColorDialog_0.labelColorModel).set_Text(text);
		}
		text = @class.method_1(LocalizationKeys.ColorPickerDialogRgbLabel);
		if (text != "")
		{
			customColorDialog_0.comboColorModel.get_Items().set_Item(0, (object)text);
		}
	}

	private void method_46(ArrayList arrayList_0)
	{
		int itemSpacing = 3;
		for (int i = 0; i < arrayList_0.Count; i++)
		{
			ItemContainer itemContainer = new ItemContainer();
			itemContainer.Orientation = eOrientation.Horizontal;
			itemContainer.ItemSpacing = itemSpacing;
			if (i == 0)
			{
				itemContainer.BackgroundStyle.MarginBottom = 5;
				itemContainer.BackgroundStyle.MarginTop = 3;
			}
			if (i == arrayList_0.Count - 1)
			{
				itemContainer.BackgroundStyle.MarginBottom = 3;
			}
			ColorItem[] array = (ColorItem[])arrayList_0[i];
			ColorItem[] array2 = array;
			foreach (ColorItem colorItem in array2)
			{
				itemContainer.SubItems.Add(colorItem);
				colorItem.Click += method_47;
				colorItem.AutoCollapseOnClick = false;
			}
			SubItems.Add(itemContainer);
		}
	}

	private void method_47(object sender, EventArgs e)
	{
		if (sender is ColorItem colorItem)
		{
			method_48(colorItem.Color);
			BaseItem.CollapseAll(this);
		}
	}

	private void method_48(Color color_3)
	{
		method_49(color_3, bool_55: true);
	}

	private void method_49(Color color_3, bool bool_55)
	{
		color_2 = color_3;
		OnSelectedColorChanged(new EventArgs());
		if (bool_55)
		{
			RaiseClick();
		}
		UpdateSelectedColorImage();
	}

	public void UpdateSelectedColorImage()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		if (rectangle_3.IsEmpty || rectangle_3.Width <= 0 || rectangle_3.Height <= 0 || base.Image == null || DesignMode)
		{
			return;
		}
		Bitmap val = new Bitmap(base.Image.get_Width(), base.Image.get_Height(), (PixelFormat)2498570);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			Rectangle rectangle = rectangle_3;
			val2.DrawImage(base.Image, 0, 0);
			Color color = SelectedColor;
			bool flag = false;
			if (color.IsEmpty || color == Color.Transparent)
			{
				color = Color.White;
				flag = true;
			}
			SolidBrush val3 = new SolidBrush(color);
			try
			{
				val2.FillRectangle((Brush)(object)val3, rectangle);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			if (flag && rectangle.Height > 5)
			{
				Pen val4 = new Pen(Color.Black);
				try
				{
					val2.set_SmoothingMode((SmoothingMode)2);
					val2.DrawLine(val4, rectangle.X, rectangle.Y, rectangle.Right, rectangle.Bottom);
					val2.DrawLine(val4, rectangle.Right, rectangle.Y, rectangle.X, rectangle.Bottom);
					val2.set_SmoothingMode((SmoothingMode)0);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		if (bool_54)
		{
			Image image = base.Image;
			base.Image = (Image)(object)val;
			image.Dispose();
		}
		else
		{
			base.Image = (Image)(object)val;
		}
		bool_54 = true;
	}

	protected virtual ArrayList GetThemeColors()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(new ColorItem[10]
		{
			method_50("FFFFFF"),
			method_50("000000"),
			method_50("FAF3E8"),
			method_50("1F497D"),
			method_50("5C83B4"),
			method_50("C0504D"),
			method_50("9DBB61"),
			method_50("8066A0"),
			method_50("4BACC6"),
			method_50("F59D56")
		});
		arrayList.Add(new ColorItem[10]
		{
			method_51("D8D8D8"),
			method_51("7F7F7F"),
			method_51("BBB6AE"),
			method_51("C7D1DE"),
			method_51("D6E0EC"),
			method_51("EFD3D2"),
			method_51("E6EED7"),
			method_51("DFD8E7"),
			method_51("D2EAF0"),
			method_51("FCE6D4")
		});
		arrayList.Add(new ColorItem[10]
		{
			method_52("BFBFBF"),
			method_52("727272"),
			method_52("A29D96"),
			method_52("8FA4BE"),
			method_52("ADC1D9"),
			method_52("DFA7A6"),
			method_52("CEDDB0"),
			method_52("BFB2CF"),
			method_52("A5D5E2"),
			method_52("FACEAA")
		});
		arrayList.Add(new ColorItem[10]
		{
			method_52("A5A5A5"),
			method_52("595959"),
			method_52("7D7974"),
			method_52("57769D"),
			method_52("84A2C6"),
			method_52("CF7B79"),
			method_52("B5CC88"),
			method_52("9F8CB7"),
			method_52("78C0D4"),
			method_52("F7B580")
		});
		arrayList.Add(new ColorItem[10]
		{
			method_52("8C8C8C"),
			method_52("3F3F3F"),
			method_52("575551"),
			method_52("17365D"),
			method_52("456287"),
			method_52("903C39"),
			method_52("758C48"),
			method_52("604C78"),
			method_52("388194"),
			method_52("B77540")
		});
		arrayList.Add(new ColorItem[10]
		{
			method_53("7F7F7F"),
			method_53("262626"),
			method_53("3E3C3A"),
			method_53("0F243E"),
			method_53("2E415A"),
			method_53("602826"),
			method_53("4E5D30"),
			method_53("403350"),
			method_53("255663"),
			method_53("7A4E2B")
		});
		return arrayList;
	}

	protected virtual ArrayList GetStandardColors()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(new ColorItem[10]
		{
			method_50("BA1419"),
			method_50("ED1C24"),
			method_50("FFC20E"),
			method_50("FFF200"),
			method_50("9DDA4E"),
			method_50("22B14C"),
			method_50("00B7EF"),
			method_50("0072BC"),
			method_50("2F3699"),
			method_50("6F3198")
		});
		return arrayList;
	}

	private ColorItem method_50(string string_14)
	{
		return new ColorItem("", "", ColorScheme.GetColor(string_14));
	}

	private ColorItem method_51(string string_14)
	{
		ColorItem colorItem = new ColorItem("", "", ColorScheme.GetColor(string_14));
		colorItem.Border = eColorItemBorder.Left | eColorItemBorder.Right | eColorItemBorder.Top;
		return colorItem;
	}

	private ColorItem method_52(string string_14)
	{
		ColorItem colorItem = new ColorItem("", "", ColorScheme.GetColor(string_14));
		colorItem.Border = eColorItemBorder.Left | eColorItemBorder.Right;
		return colorItem;
	}

	private ColorItem method_53(string string_14)
	{
		ColorItem colorItem = new ColorItem("", "", ColorScheme.GetColor(string_14));
		colorItem.Border = eColorItemBorder.Left | eColorItemBorder.Right | eColorItemBorder.Bottom;
		return colorItem;
	}

	private void method_54()
	{
		if (bool_53)
		{
			return;
		}
		if (GetOwner() != null)
		{
			bool_53 = true;
		}
		using Class264 @class = new Class264(GetOwner() as IOwnerLocalize);
		string text = @class.method_1(LocalizationKeys.ColorPickerThemeColorsLabel);
		if (text != "")
		{
			string_11 = text;
		}
		text = @class.method_1(LocalizationKeys.ColorPickerStandardColorsLabel);
		if (text != "")
		{
			string_12 = text;
		}
		text = @class.method_1(LocalizationKeys.ColorPickerMoreColorsMenuItem);
		if (text != "")
		{
			string_13 = text;
		}
	}

	protected virtual void OnSelectedColorChanged(EventArgs e)
	{
		if (eventHandler_20 != null)
		{
			eventHandler_20(this, e);
		}
		if (GetOwner() is DotNetBarManager dotNetBarManager)
		{
			dotNetBarManager.InvokeColorPickerSelectedColorChanged(this);
		}
	}

	protected override void OnCommandChanged()
	{
	}
}
