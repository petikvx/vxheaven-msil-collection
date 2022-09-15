using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

internal sealed class Class109
{
	public const int int_0 = 100;

	private const string string_0 = ".Strings";

	private static string string_1;

	private static bool bool_0;

	private static bool bool_1;

	private static bool bool_2;

	private static ArrayList arrayList_0;

	public static bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public static bool Boolean_1 => bool_2;

	internal static Enum19 Enum19_0
	{
		get
		{
			Enum19 result = Enum19.const_0;
			if (Boolean_0 && Class92.int_74 >= 16)
			{
				if (bool_1)
				{
					result = Enum19.const_1;
				}
				else if (SystemColors.Control.ToArgb() == Color.FromArgb(236, 233, 216).ToArgb() && SystemColors.Highlight.ToArgb() == Color.FromArgb(49, 106, 197).ToArgb())
				{
					result = Enum19.const_1;
				}
				else if (SystemColors.Control.ToArgb() == Color.FromArgb(224, 223, 227).ToArgb() && SystemColors.Highlight.ToArgb() == Color.FromArgb(178, 180, 191).ToArgb())
				{
					result = Enum19.const_3;
				}
				else if (SystemColors.Control.ToArgb() == Color.FromArgb(236, 233, 216).ToArgb() && SystemColors.Highlight.ToArgb() == Color.FromArgb(147, 160, 112).ToArgb())
				{
					result = Enum19.const_2;
				}
			}
			return result;
		}
	}

	static Class109()
	{
		string_1 = "";
		bool_0 = false;
		bool_1 = false;
		bool_2 = true;
		arrayList_0 = new ArrayList(2);
		bool_0 = false;
		Class92.OSVERSIONINFO o = new Class92.OSVERSIONINFO
		{
			dwOSVersionInfoSize = Marshal.SizeOf(typeof(Class92.OSVERSIONINFO))
		};
		Class92.GetVersionEx(ref o);
		if (o.dwPlatformId == 2 && o.dwMajorVersion == 4)
		{
			bool_2 = false;
		}
		if ((o.dwMajorVersion == 5 && o.dwMinorVersion >= 1 && o.dwPlatformId == 2) || (o.dwMajorVersion > 5 && o.dwPlatformId == 2))
		{
			bool_0 = ((FeatureSupport)OSFeature.get_Feature()).IsPresent(OSFeature.Themes);
		}
		bool_1 = Environment.OSVersion.Version.Major >= 6;
		smethod_54();
	}

	public static Color smethod_0(Color color_0, int int_1)
	{
		ColorFunctions.HLSColor clr = ColorFunctions.RGBToHSL(color_0.R, color_0.G, color_0.B);
		clr.Lightness *= (double)(100 - int_1) / 100.0;
		return ColorFunctions.HLSToRGB(clr);
	}

	public static Color smethod_1(Color color_0, int int_1)
	{
		ColorFunctions.HLSColor clr = ColorFunctions.RGBToHSL(color_0.R, color_0.G, color_0.B);
		clr.Lightness *= 1.0 + (double)int_1 / 100.0;
		return ColorFunctions.HLSToRGB(clr);
	}

	public static bool smethod_2(Control control_0, bool bool_3)
	{
		MethodInfo method = ((object)control_0).GetType().GetMethod("RecalcLayout");
		if ((object)method != null)
		{
			method.Invoke(control_0, null);
			return true;
		}
		if (bool_3)
		{
			control_0.Invalidate(true);
			control_0.Update();
		}
		return false;
	}

	public static StringFormat smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringFormat val = new StringFormat();
		val.set_Alignment((StringAlignment)0);
		val.set_LineAlignment((StringAlignment)0);
		val.set_HotkeyPrefix((HotkeyPrefix)0);
		val.set_Trimming((StringTrimming)1);
		return val;
	}

	public static void smethod_4(Control control_0, bool bool_3)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (bool_3)
		{
			int num = -1;
			if (control_0.get_Parent() != null && (int)control_0.get_Dock() != 0)
			{
				num = control_0.get_Parent().get_Controls().IndexOf(control_0);
			}
			control_0.set_Visible(true);
			if (num != -1)
			{
				control_0.get_Parent().get_Controls().SetChildIndex(control_0, num);
			}
		}
		else
		{
			control_0.set_Visible(false);
		}
	}

	public static bool smethod_5(eShortcut eShortcut_0, Hashtable hashtable_0)
	{
		bool result = false;
		if (hashtable_0.Contains(eShortcut_0))
		{
			Class49 @class = (Class49)hashtable_0[eShortcut_0];
			BaseItem[] array = new BaseItem[@class.hashtable_0.Values.Count];
			@class.hashtable_0.Values.CopyTo(array, 0);
			Hashtable hashtable = new Hashtable(array.Length);
			BaseItem[] array2 = array;
			foreach (BaseItem baseItem in array2)
			{
				if (baseItem.Boolean_0 && (baseItem.Name == "" || !hashtable.Contains(baseItem.Name)) && (!baseItem.GlobalItem || baseItem.GlobalName == "" || !hashtable.Contains(baseItem.GlobalName)))
				{
					result = true;
					baseItem.RaiseClick();
					if (baseItem.Name != "")
					{
						hashtable.Add(baseItem.Name, "");
					}
					if (baseItem.GlobalItem && baseItem.GlobalName != "" && baseItem.GlobalName != baseItem.Name && !hashtable.Contains(baseItem.GlobalName))
					{
						hashtable.Add(baseItem.GlobalName, "");
					}
				}
			}
		}
		return result;
	}

	public static Bar smethod_6(Bar bar_0)
	{
		Bar bar_ = new Bar(((Control)bar_0).get_Text());
		return smethod_8(bar_0, bar_);
	}

	public static Bar smethod_7(Bar bar_0, IDesignerServices idesignerServices_0)
	{
		Bar bar_ = idesignerServices_0.CreateComponent(typeof(Bar)) as Bar;
		return smethod_8(bar_0, bar_);
	}

	private static Bar smethod_8(Bar bar_0, Bar bar_1)
	{
		((Control)bar_1).set_Text(((Control)bar_0).get_Text());
		bar_1.ItemsContainer.Int32_1 = bar_0.Int32_2;
		bar_1.ItemsContainer.Int32_2 = bar_0.ItemsContainer.Int32_2;
		bar_1.CanDockBottom = bar_0.CanDockBottom;
		bar_1.CanDockLeft = bar_0.CanDockLeft;
		bar_1.CanDockRight = bar_0.CanDockRight;
		bar_1.CanDockTop = bar_0.CanDockTop;
		bar_1.CanDockDocument = bar_0.CanDockDocument;
		bar_1.CanDockTab = bar_0.CanDockTab;
		bar_1.CanUndock = bar_0.CanUndock;
		bar_1.CanAutoHide = bar_0.CanAutoHide;
		bar_1.DockTabAlignment = bar_0.DockTabAlignment;
		bar_1.CanCustomize = bar_0.CanCustomize;
		bar_1.AutoHideAnimationTime = bar_0.AutoHideAnimationTime;
		bar_1.AlwaysDisplayDockTab = bar_0.AlwaysDisplayDockTab;
		bar_1.AutoCreateCaptionMenu = bar_0.AutoCreateCaptionMenu;
		bar_1.AutoSyncBarCaption = bar_0.AutoSyncBarCaption;
		bar_1.HideFloatingInactive = bar_0.HideFloatingInactive;
		if (!bar_0.CaptionBackColor.IsEmpty)
		{
			bar_1.CaptionBackColor = bar_0.CaptionBackColor;
		}
		if (!bar_0.CaptionForeColor.IsEmpty)
		{
			bar_1.CaptionForeColor = bar_0.CaptionForeColor;
		}
		if (!bar_0.ItemsContainer.m_BackgroundColor.IsEmpty)
		{
			bar_1.ItemsContainer.BackColor = bar_0.ItemsContainer.m_BackgroundColor;
		}
		if (bar_0.DockedBorderStyle != 0)
		{
			bar_1.DockedBorderStyle = bar_0.DockedBorderStyle;
		}
		bar_1.Style = bar_0.Style;
		if (bar_0.ColorScheme.SchemeChanged)
		{
			bar_1.ColorScheme = bar_0.ColorScheme;
		}
		bar_1.LayoutType = bar_0.LayoutType;
		bar_1.GrabHandleStyle = bar_0.GrabHandleStyle;
		bar_1.Stretch = bar_0.Stretch;
		bar_1.CanHide = bar_0.CanHide;
		bar_1.ThemeAware = bar_0.ThemeAware;
		bar_1.DockedBorderStyle = bar_0.DockedBorderStyle;
		return bar_1;
	}

	public static void smethod_9(Bar bar_0)
	{
		bar_0.method_117(bar_0.Style);
		if (!bar_0.AlwaysDisplayDockTab)
		{
			bar_0.AlwaysDisplayDockTab = true;
		}
		if (bar_0.DockTabAlignment != eTabStripAlignment.Top)
		{
			bar_0.DockTabAlignment = eTabStripAlignment.Top;
		}
		if (bar_0.GrabHandleStyle != 0)
		{
			bar_0.GrabHandleStyle = eGrabHandleStyle.None;
		}
	}

	public static void smethod_10(Bar bar_0)
	{
		bar_0.method_117(bar_0.Style);
		if (bar_0.AlwaysDisplayDockTab)
		{
			bar_0.AlwaysDisplayDockTab = false;
		}
		if (bar_0.DockTabAlignment != eTabStripAlignment.Bottom)
		{
			bar_0.DockTabAlignment = eTabStripAlignment.Bottom;
		}
		if (bar_0.GrabHandleStyle != eGrabHandleStyle.Caption)
		{
			bar_0.GrabHandleStyle = eGrabHandleStyle.Caption;
		}
	}

	public static bool smethod_11(Control control_0)
	{
		if (control_0 != null && !control_0.get_Disposing() && !control_0.get_IsDisposed())
		{
			return control_0.get_IsHandleCreated();
		}
		return false;
	}

	public static void smethod_12(ItemPaintArgs itemPaintArgs_0, Rectangle rectangle_0, eDotNetBarStyle eDotNetBarStyle_0, bool bool_3)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		Graphics graphics = itemPaintArgs_0.Graphics;
		if (eDotNetBarStyle_0 != eDotNetBarStyle.Office2000)
		{
			Color itemCheckedBackground;
			if (!bool_3)
			{
				itemCheckedBackground = itemPaintArgs_0.Colors.ItemCheckedBackground;
				SolidBrush val = new SolidBrush(itemCheckedBackground);
				graphics.FillRectangle((Brush)(object)val, rectangle_0);
				((Brush)val).Dispose();
			}
			itemCheckedBackground = itemPaintArgs_0.Colors.ItemCheckedBorder;
			Pen val2 = new Pen(itemCheckedBackground, 1f);
			Class92.smethod_4(graphics, val2, rectangle_0);
			val2.Dispose();
			Point[] array = new Point[3];
			array[0].X = rectangle_0.Left + (rectangle_0.Width - 5) / 2 - 1;
			array[0].Y = rectangle_0.Top + (rectangle_0.Height - 6) / 2 + 3;
			array[1].X = array[0].X + 2;
			array[1].Y = array[0].Y + 2;
			array[2].X = array[1].X + 4;
			array[2].Y = array[1].Y - 4;
			val2 = new Pen(itemPaintArgs_0.Colors.ItemCheckedText);
			graphics.DrawLines(val2, array);
			array[0].X++;
			array[1].X++;
			array[2].X++;
			graphics.DrawLines(val2, array);
			val2.Dispose();
		}
		else if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2000)
		{
			ControlPaint.DrawBorder3D(graphics, rectangle_0, (Border3DStyle)2, (Border3DSide)2063);
			if (!bool_3)
			{
				rectangle_0.Inflate(-1, -1);
				graphics.FillRectangle((Brush)(object)ColorFunctions.GetPushedBrush(), rectangle_0);
			}
			Point[] array2 = new Point[3];
			array2[0].X = rectangle_0.Left + (rectangle_0.Width - 6) / 2;
			array2[0].Y = rectangle_0.Top + (rectangle_0.Height - 6) / 2 + 3;
			array2[1].X = array2[0].X + 2;
			array2[1].Y = array2[0].Y + 2;
			array2[2].X = array2[1].X + 4;
			array2[2].Y = array2[1].Y - 4;
			graphics.DrawLines(SystemPens.get_ControlText(), array2);
			array2[0].X++;
			array2[1].X++;
			array2[2].X++;
			graphics.DrawLines(SystemPens.get_ControlText(), array2);
		}
	}

	public static void smethod_13(Image image_0, XmlElement xmlElement_0)
	{
		if (image_0 != null)
		{
			MemoryStream memoryStream = new MemoryStream(1024);
			image_0.Save((Stream)memoryStream, ImageFormat.get_Png());
			StringBuilder stringBuilder = new StringBuilder();
			StringWriter w = new StringWriter(stringBuilder);
			XmlTextWriter xmlTextWriter = new XmlTextWriter(w);
			xmlTextWriter.WriteBase64(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
			xmlElement_0.InnerText = stringBuilder.ToString();
		}
	}

	public static void smethod_14(Icon icon_0, XmlElement xmlElement_0)
	{
		if (icon_0 != null)
		{
			MemoryStream memoryStream = new MemoryStream(1024);
			icon_0.Save((Stream)memoryStream);
			StringBuilder stringBuilder = new StringBuilder();
			StringWriter w = new StringWriter(stringBuilder);
			XmlTextWriter xmlTextWriter = new XmlTextWriter(w);
			xmlElement_0.SetAttribute("encoding", "binhex");
			xmlTextWriter.WriteBinHex(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
			xmlElement_0.InnerText = stringBuilder.ToString();
		}
	}

	public static Form smethod_15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Form val = new Form();
		try
		{
			val.set_Size(new Size(0, 0));
		}
		catch
		{
			val = new Form();
		}
		((Control)val).set_BackColor(SystemColors.Highlight);
		val.set_MinimizeBox(false);
		val.set_MaximizeBox(false);
		val.set_FormBorderStyle((FormBorderStyle)0);
		if (Class92.Boolean_2)
		{
			val.set_Opacity(0.5);
		}
		else
		{
			((Control)val).set_BackColor(ControlPaint.LightLight(SystemColors.Highlight));
		}
		val.set_ShowInTaskbar(false);
		((Control)val).set_Text("");
		((Control)val).CreateControl();
		return val;
	}

	public static Image smethod_16(XmlElement xmlElement_0)
	{
		Image val = null;
		if (xmlElement_0 != null && !(xmlElement_0.InnerText == ""))
		{
			StringReader input = new StringReader(xmlElement_0.OuterXml);
			XmlTextReader xmlTextReader = new XmlTextReader(input);
			MemoryStream memoryStream = new MemoryStream(1024);
			xmlTextReader.Read();
			byte[] array = new byte[1024];
			int num = 0;
			do
			{
				num = xmlTextReader.ReadBase64(array, 0, 1024);
				if (num > 0)
				{
					memoryStream.Write(array, 0, num);
				}
			}
			while (num != 0);
			return Image.FromStream((Stream)memoryStream);
		}
		return null;
	}

	public static Icon smethod_17(XmlElement xmlElement_0)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		Icon val = null;
		if (xmlElement_0 != null && !(xmlElement_0.InnerText == ""))
		{
			bool flag = false;
			if (xmlElement_0.HasAttribute("encoding") && xmlElement_0.GetAttribute("encoding") == "binhex")
			{
				flag = true;
			}
			StringReader input = new StringReader(xmlElement_0.OuterXml);
			XmlTextReader xmlTextReader = new XmlTextReader(input);
			MemoryStream memoryStream = new MemoryStream(1024);
			xmlTextReader.Read();
			byte[] array = new byte[1024];
			int num = 0;
			if (flag)
			{
				do
				{
					num = xmlTextReader.ReadBinHex(array, 0, 1024);
					if (num > 0)
					{
						memoryStream.Write(array, 0, num);
					}
				}
				while (num != 0);
			}
			else
			{
				do
				{
					num = xmlTextReader.ReadBase64(array, 0, 1024);
					if (num > 0)
					{
						memoryStream.Write(array, 0, num);
					}
				}
				while (num != 0);
			}
			memoryStream.Position = 0L;
			return new Icon((Stream)memoryStream);
		}
		return null;
	}

	internal static BaseItem smethod_18(XmlElement xmlElement_0)
	{
		string attribute = xmlElement_0.GetAttribute("class");
		BaseItem baseItem = null;
		switch (attribute)
		{
		case "DevComponents.DotNetBar.ButtonItem":
			return new ButtonItem();
		case "DevComponents.DotNetBar.TextBoxItem":
			return new TextBoxItem();
		case "DevComponents.DotNetBar.ComboBoxItem":
			return new ComboBoxItem();
		case "DevComponents.DotNetBar.LabelItem":
			return new LabelItem();
		case "DevComponents.DotNetBar.CustomizeItem":
			return new CustomizeItem();
		case "DevComponents.DotNetBar.ControlContainerItem":
			return new ControlContainerItem();
		case "DevComponents.DotNetBar.DockContainerItem":
			return new DockContainerItem();
		case "DevComponents.DotNetBar.MdiWindowListItem":
			return new MdiWindowListItem();
		case "DevComponents.DotNetBar.SideBarContainerItem":
			return new SideBarContainerItem();
		case "DevComponents.DotNetBar.SideBarPanelItem":
			return new SideBarPanelItem();
		case "DevComponents.DotNetBar.ExplorerBarGroupItem":
			return new ExplorerBarGroupItem();
		case "DevComponents.DotNetBar.ExplorerBarContainerItem":
			return new ExplorerBarContainerItem();
		case "DevComponents.DotNetBar.ProgressBarItem":
			return new ProgressBarItem();
		case "DevComponents.DotNetBar.ColorPickerDropDown":
			return new ColorPickerDropDown();
		default:
			try
			{
				Assembly assembly = Assembly.Load(xmlElement_0.GetAttribute("assembly"));
				if ((object)assembly == null)
				{
					return null;
				}
				return assembly.CreateInstance(xmlElement_0.GetAttribute("class")) as BaseItem;
			}
			catch (Exception ex)
			{
				throw new ArgumentException("Could not create item from XML. Assembly=" + xmlElement_0.GetAttribute("assembly") + ", Class=" + xmlElement_0.GetAttribute("class") + ", Inner Exception: " + ex.Message + ", Source=" + ex.Source);
			}
		}
	}

	internal static BaseItem smethod_19(XmlElement xmlElement_0, IDesignerHost idesignerHost_0, string string_2)
	{
		string attribute = xmlElement_0.GetAttribute("class");
		BaseItem baseItem = null;
		switch (attribute)
		{
		case "DevComponents.DotNetBar.ButtonItem":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(ButtonItem), string_2) as ButtonItem;
			}
			return idesignerHost_0.CreateComponent(typeof(ButtonItem)) as ButtonItem;
		case "DevComponents.DotNetBar.TextBoxItem":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(TextBoxItem), string_2) as TextBoxItem;
			}
			return idesignerHost_0.CreateComponent(typeof(TextBoxItem)) as TextBoxItem;
		case "DevComponents.DotNetBar.ComboBoxItem":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(ComboBoxItem), string_2) as ComboBoxItem;
			}
			return idesignerHost_0.CreateComponent(typeof(ComboBoxItem)) as ComboBoxItem;
		case "DevComponents.DotNetBar.LabelItem":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(LabelItem), string_2) as LabelItem;
			}
			return idesignerHost_0.CreateComponent(typeof(LabelItem)) as LabelItem;
		case "DevComponents.DotNetBar.CustomizeItem":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(CustomizeItem), string_2) as CustomizeItem;
			}
			return idesignerHost_0.CreateComponent(typeof(CustomizeItem)) as CustomizeItem;
		case "DevComponents.DotNetBar.ControlContainerItem":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(ControlContainerItem), string_2) as ControlContainerItem;
			}
			return idesignerHost_0.CreateComponent(typeof(ControlContainerItem)) as ControlContainerItem;
		case "DevComponents.DotNetBar.DockContainerItem":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(DockContainerItem), string_2) as DockContainerItem;
			}
			return idesignerHost_0.CreateComponent(typeof(DockContainerItem)) as DockContainerItem;
		case "DevComponents.DotNetBar.MdiWindowListItem":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(MdiWindowListItem), string_2) as MdiWindowListItem;
			}
			return idesignerHost_0.CreateComponent(typeof(MdiWindowListItem)) as MdiWindowListItem;
		case "DevComponents.DotNetBar.SideBarContainerItem":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(SideBarContainerItem), string_2) as SideBarContainerItem;
			}
			return idesignerHost_0.CreateComponent(typeof(SideBarContainerItem)) as SideBarContainerItem;
		case "DevComponents.DotNetBar.SideBarPanelItem":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(SideBarPanelItem), string_2) as SideBarPanelItem;
			}
			return idesignerHost_0.CreateComponent(typeof(SideBarPanelItem)) as SideBarPanelItem;
		case "DevComponents.DotNetBar.ExplorerBarGroupItem":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(ExplorerBarGroupItem), string_2) as ExplorerBarGroupItem;
			}
			return idesignerHost_0.CreateComponent(typeof(ExplorerBarGroupItem)) as ExplorerBarGroupItem;
		case "DevComponents.DotNetBar.ExplorerBarContainerItem":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(ExplorerBarContainerItem), string_2) as ExplorerBarContainerItem;
			}
			return idesignerHost_0.CreateComponent(typeof(ExplorerBarContainerItem)) as ExplorerBarContainerItem;
		case "DevComponents.DotNetBar.ProgressBarItem":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(ProgressBarItem), string_2) as ProgressBarItem;
			}
			return idesignerHost_0.CreateComponent(typeof(ProgressBarItem)) as ProgressBarItem;
		case "DevComponents.DotNetBar.ColorPickerDropDown":
			if (string_2 != "")
			{
				return idesignerHost_0.CreateComponent(typeof(ColorPickerDropDown), string_2) as ColorPickerDropDown;
			}
			return idesignerHost_0.CreateComponent(typeof(ColorPickerDropDown)) as ColorPickerDropDown;
		default:
			try
			{
				Assembly assembly = Assembly.Load(xmlElement_0.GetAttribute("assembly"));
				if ((object)assembly == null)
				{
					return null;
				}
				BaseItem baseItem2 = assembly.CreateInstance(xmlElement_0.GetAttribute("class")) as BaseItem;
				return idesignerHost_0.CreateComponent(baseItem2.GetType()) as BaseItem;
			}
			catch (Exception ex)
			{
				throw new ArgumentException("Could not create item from XML. Assembly=" + xmlElement_0.GetAttribute("assembly") + ", Class=" + xmlElement_0.GetAttribute("class") + ", Inner Exception: " + ex.Message + ", Source=" + ex.Source);
			}
		}
	}

	internal static string smethod_20(XmlElement xmlElement_0)
	{
		string text = "";
		if (xmlElement_0.HasAttribute("assembly"))
		{
			text += xmlElement_0.GetAttribute("assembly");
		}
		if (xmlElement_0.HasAttribute("class"))
		{
			text += xmlElement_0.GetAttribute("class");
		}
		return text;
	}

	internal static void smethod_21(Graphics graphics_0, Enum13 enum13_0, Rectangle rectangle_0, bool bool_3, bool bool_4, bool bool_5)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		if (bool_3)
		{
			graphics_0.FillRectangle((Brush)new SolidBrush(ColorFunctions.PressedBackColor(graphics_0)), rectangle_0);
			Class92.smethod_4(graphics_0, SystemPens.get_Highlight(), rectangle_0);
		}
		else if (bool_4)
		{
			graphics_0.FillRectangle((Brush)new SolidBrush(ColorFunctions.HoverBackColor(graphics_0)), rectangle_0);
			Class92.smethod_4(graphics_0, SystemPens.get_Highlight(), rectangle_0);
		}
		Bitmap val = new Bitmap(rectangle_0.Width, rectangle_0.Height, graphics_0);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Rectangle rectangle = new Rectangle(0, 0, rectangle_0.Width, rectangle_0.Height);
		rectangle.Inflate(0, -1);
		Rectangle clip = rectangle;
		clip.Inflate(-1, -1);
		SolidBrush val3 = new SolidBrush(SystemColors.Control);
		try
		{
			val2.FillRectangle((Brush)(object)val3, 0, 0, rectangle_0.Width, rectangle_0.Height);
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
		val2.SetClip(clip);
		ControlPaint.DrawCaptionButton(val2, rectangle, (CaptionButton)enum13_0, (ButtonState)16384);
		val2.ResetClip();
		val2.Dispose();
		val.MakeTransparent(SystemColors.Control);
		if (bool_5)
		{
			float[][] array = new float[5][];
			float[] array2 = (array[0] = new float[5]);
			float[] array3 = (array[1] = new float[5]);
			float[] array4 = (array[2] = new float[5]);
			array[3] = new float[5] { 0.5f, 0.5f, 0.5f, 0.5f, 0f };
			float[] array5 = (array[4] = new float[5]);
			ColorMatrix colorMatrix = new ColorMatrix(array);
			ImageAttributes val4 = new ImageAttributes();
			val4.ClearColorKey();
			val4.SetColorMatrix(colorMatrix);
			graphics_0.DrawImage((Image)(object)val, rectangle_0, 0, 0, ((Image)val).get_Width(), ((Image)val).get_Height(), (GraphicsUnit)2, val4);
		}
		else
		{
			if (bool_3)
			{
				rectangle_0.Offset(1, 1);
			}
			graphics_0.DrawImageUnscaled((Image)(object)val, rectangle_0);
		}
	}

	internal static void smethod_22(BaseItem baseItem_0, string string_2)
	{
		if (baseItem_0.GlobalName.Length > 0)
		{
			PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(baseItem_0)[string_2];
			smethod_25(smethod_23(baseItem_0), baseItem_0.GetType(), baseItem_0.GlobalName, propertyDescriptor, propertyDescriptor.GetValue(baseItem_0));
		}
		else if (baseItem_0.Name.Length > 0)
		{
			PropertyDescriptor propertyDescriptor2 = TypeDescriptor.GetProperties(baseItem_0)[string_2];
			smethod_24(smethod_23(baseItem_0), baseItem_0.GetType(), baseItem_0.Name, propertyDescriptor2, propertyDescriptor2.GetValue(baseItem_0));
		}
	}

	private static object smethod_23(BaseItem baseItem_0)
	{
		object obj = baseItem_0.GetOwner();
		if (obj is RibbonBar && ((RibbonBar)obj).Boolean_4)
		{
			obj = ((RibbonBar)obj).RibbonBar_0;
		}
		return obj;
	}

	internal static void smethod_24(object object_0, Type type_0, string string_2, PropertyDescriptor propertyDescriptor_0, object object_1)
	{
		IOwner owner = object_0 as IOwner;
		DotNetBarManager dotNetBarManager = object_0 as DotNetBarManager;
		if (owner == null || string_2 == "" || propertyDescriptor_0 == null)
		{
			return;
		}
		ArrayList arrayList = null;
		if (dotNetBarManager != null)
		{
			if (!dotNetBarManager.IsDisposed)
			{
				arrayList = dotNetBarManager.GetItems(string_2, type_0, fullSearch: true);
			}
		}
		else
		{
			arrayList = owner.GetItems(string_2, type_0);
		}
		if (arrayList == null)
		{
			return;
		}
		foreach (BaseItem item in arrayList)
		{
			if (propertyDescriptor_0.GetValue(item) != object_1)
			{
				propertyDescriptor_0.SetValue(item, object_1);
			}
		}
	}

	internal static void smethod_25(object object_0, Type type_0, string string_2, PropertyDescriptor propertyDescriptor_0, object object_1)
	{
		IOwner owner = object_0 as IOwner;
		DotNetBarManager dotNetBarManager = object_0 as DotNetBarManager;
		if (owner == null || string_2 == "" || propertyDescriptor_0 == null)
		{
			return;
		}
		ArrayList arrayList = null;
		if (dotNetBarManager != null)
		{
			if (!dotNetBarManager.IsDisposed)
			{
				arrayList = dotNetBarManager.GetItems(string_2, type_0, fullSearch: true, useGlobalName: true);
			}
		}
		else
		{
			arrayList = owner.GetItems(string_2, type_0, useGlobalName: true);
		}
		if (arrayList == null)
		{
			return;
		}
		foreach (BaseItem item in arrayList)
		{
			if (propertyDescriptor_0.GetValue(item) != object_1)
			{
				propertyDescriptor_0.SetValue(item, object_1);
			}
		}
	}

	internal static ResourceManager smethod_26(bool bool_3)
	{
		string text = ".Strings";
		text = ((!(Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(DotNetBarResourcesAttribute)) is DotNetBarResourcesAttribute dotNetBarResourcesAttribute) || !(dotNetBarResourcesAttribute.NamespacePrefix != "")) ? ("DevComponents.DotNetBar" + text) : (dotNetBarResourcesAttribute.NamespacePrefix + text));
		return new ResourceManager(text, Assembly.GetExecutingAssembly());
	}

	internal static ResourceManager smethod_27()
	{
		string text = ".Strings";
		text = ((!(Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(DotNetBarResourcesAttribute)) is DotNetBarResourcesAttribute dotNetBarResourcesAttribute) || !(dotNetBarResourcesAttribute.NamespacePrefix != "")) ? ("DevComponents.DotNetBar" + text) : (dotNetBarResourcesAttribute.NamespacePrefix + text));
		if (string_1 == "")
		{
			CultureInfo cultureInfo = Thread.CurrentThread.CurrentUICulture;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			executingAssembly.GetManifestResourceNames();
			int num = 0;
			while (cultureInfo.LCID != 127 && num < 16)
			{
				if (executingAssembly.GetManifestResourceInfo(text + "_" + cultureInfo.Name.ToLower() + ".resources") == null)
				{
					if (executingAssembly.GetManifestResourceInfo(text + "_" + cultureInfo.TwoLetterISOLanguageName.ToLower() + ".resources") == null)
					{
						cultureInfo = cultureInfo.Parent;
						num++;
						continue;
					}
					string_1 = text + "_" + cultureInfo.TwoLetterISOLanguageName.ToLower();
					break;
				}
				string_1 = text + "_" + cultureInfo.Name.ToLower();
				break;
			}
			if (string_1 == "")
			{
				string_1 = text;
			}
		}
		return new ResourceManager(string_1, Assembly.GetExecutingAssembly());
	}

	internal static void smethod_28(Graphics graphics_0, eBorderType eBorderType_0, Rectangle rectangle_0, Color color_0)
	{
		smethod_29(graphics_0, eBorderType_0, rectangle_0, color_0, eBorderSide.All);
	}

	internal static void smethod_29(Graphics graphics_0, eBorderType eBorderType_0, Rectangle rectangle_0, Color color_0, eBorderSide eBorderSide_0)
	{
		smethod_30(graphics_0, eBorderType_0, rectangle_0, color_0, eBorderSide_0, (DashStyle)0);
	}

	internal static void smethod_30(Graphics graphics_0, eBorderType eBorderType_0, Rectangle rectangle_0, Color color_0, eBorderSide eBorderSide_0, DashStyle dashStyle_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		smethod_31(graphics_0, eBorderType_0, rectangle_0, color_0, eBorderSide_0, dashStyle_0, 1);
	}

	internal static void smethod_31(Graphics graphics_0, eBorderType eBorderType_0, Rectangle rectangle_0, Color color_0, eBorderSide eBorderSide_0, DashStyle dashStyle_0, int int_1)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		Border3DSide val = ((eBorderSide_0 != eBorderSide.All) ? ((Border3DSide)((((eBorderSide_0 | eBorderSide.Left) != 0) ? 1 : 0) | (((eBorderSide_0 | eBorderSide.Right) != 0) ? 4 : 0) | (((eBorderSide_0 | eBorderSide.Top) != 0) ? 2 : 0) | (((eBorderSide_0 | eBorderSide.Bottom) != 0) ? 8 : 0))) : ((Border3DSide)2063));
		switch (eBorderType_0)
		{
		case eBorderType.SingleLine:
		{
			SmoothingMode smoothingMode = graphics_0.get_SmoothingMode();
			graphics_0.set_SmoothingMode((SmoothingMode)3);
			Pen val3 = new Pen(color_0, (float)int_1);
			try
			{
				val3.set_DashStyle(dashStyle_0);
				int num = int_1 / 2;
				if ((eBorderSide_0 & eBorderSide.Left) != 0)
				{
					graphics_0.DrawLine(val3, rectangle_0.X + num, rectangle_0.Y, rectangle_0.X + num, rectangle_0.Bottom - 1);
				}
				if ((eBorderSide_0 & eBorderSide.Top) != 0)
				{
					graphics_0.DrawLine(val3, rectangle_0.X, rectangle_0.Y + num, rectangle_0.Right - 1, rectangle_0.Y + num);
				}
				if (num == 0)
				{
					num = 1;
				}
				if ((eBorderSide_0 & eBorderSide.Right) != 0)
				{
					graphics_0.DrawLine(val3, rectangle_0.Right - num, rectangle_0.Y, rectangle_0.Right - num, rectangle_0.Bottom - 1);
				}
				if ((eBorderSide_0 & eBorderSide.Bottom) != 0)
				{
					graphics_0.DrawLine(val3, rectangle_0.X, rectangle_0.Bottom - num, rectangle_0.Right - 1, rectangle_0.Bottom - num);
				}
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			graphics_0.set_SmoothingMode(smoothingMode);
			break;
		}
		case eBorderType.DoubleLine:
		{
			Pen val2 = new Pen(color_0, (float)int_1);
			try
			{
				val2.set_DashStyle(dashStyle_0);
				for (int i = 0; i < int_1 + 1; i += int_1)
				{
					if ((eBorderSide_0 & eBorderSide.Left) != 0)
					{
						graphics_0.DrawLine(val2, rectangle_0.X, rectangle_0.Y, rectangle_0.X, rectangle_0.Bottom - 1);
					}
					if ((eBorderSide_0 & eBorderSide.Top) != 0)
					{
						graphics_0.DrawLine(val2, rectangle_0.X, rectangle_0.Y, rectangle_0.Right - 1, rectangle_0.Y);
					}
					if ((eBorderSide_0 & eBorderSide.Right) != 0)
					{
						graphics_0.DrawLine(val2, rectangle_0.Right - 1, rectangle_0.Y, rectangle_0.Right - 1, rectangle_0.Bottom - 1);
					}
					if ((eBorderSide_0 & eBorderSide.Bottom) != 0)
					{
						graphics_0.DrawLine(val2, rectangle_0.X, rectangle_0.Bottom - 1, rectangle_0.Right - 1, rectangle_0.Bottom - 1);
					}
					rectangle_0.Inflate(-1, -1);
				}
				break;
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		case eBorderType.Sunken:
			ControlPaint.DrawBorder3D(graphics_0, rectangle_0, (Border3DStyle)2, val);
			break;
		case eBorderType.Raised:
			ControlPaint.DrawBorder3D(graphics_0, rectangle_0, (Border3DStyle)4, val);
			break;
		case eBorderType.Etched:
			ControlPaint.DrawBorder3D(graphics_0, rectangle_0, (Border3DStyle)6, val);
			break;
		case eBorderType.Bump:
			ControlPaint.DrawBorder3D(graphics_0, rectangle_0, (Border3DStyle)9, val);
			break;
		}
	}

	internal static void smethod_32(Graphics graphics_0, int int_1, int int_2, int int_3, int int_4, Border3DStyle border3DStyle_0, Border3DSide border3DSide_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		smethod_39(graphics_0, int_1, int_2, int_3, int_4, border3DStyle_0, border3DSide_0, SystemColors.Control, bool_3: true);
	}

	internal static void smethod_33(Graphics graphics_0, int int_1, int int_2, int int_3, int int_4, Border3DStyle border3DStyle_0, Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		smethod_39(graphics_0, int_1, int_2, int_3, int_4, border3DStyle_0, (Border3DSide)2063, color_0, bool_3: true);
	}

	internal static void smethod_34(Graphics graphics_0, int int_1, int int_2, int int_3, int int_4, Border3DStyle border3DStyle_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		smethod_39(graphics_0, int_1, int_2, int_3, int_4, border3DStyle_0, (Border3DSide)2063, SystemColors.Control, bool_3: true);
	}

	internal static void smethod_35(Graphics graphics_0, Rectangle rectangle_0, Border3DStyle border3DStyle_0, Border3DSide border3DSide_0, Color color_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		smethod_39(graphics_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height, border3DStyle_0, border3DSide_0, color_0, bool_3: true);
	}

	internal static void smethod_36(Graphics graphics_0, Rectangle rectangle_0, Border3DStyle border3DStyle_0, Border3DSide border3DSide_0, Color color_0, bool bool_3)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		smethod_39(graphics_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height, border3DStyle_0, border3DSide_0, color_0, bool_3);
	}

	internal static void smethod_37(Graphics graphics_0, Rectangle rectangle_0, Border3DStyle border3DStyle_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		smethod_39(graphics_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height, border3DStyle_0, (Border3DSide)2063, SystemColors.Control, bool_3: true);
	}

	internal static void smethod_38(Graphics graphics_0, int int_1, int int_2, int int_3, int int_4, Border3DStyle border3DStyle_0, Border3DSide border3DSide_0, Color color_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		smethod_39(graphics_0, int_1, int_2, int_3, int_4, border3DStyle_0, border3DSide_0, color_0, bool_3: true);
	}

	internal static void smethod_39(Graphics graphics_0, int int_1, int int_2, int int_3, int int_4, Border3DStyle border3DStyle_0, Border3DSide border3DSide_0, Color color_0, bool bool_3)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected I4, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		if (bool_3)
		{
			graphics_0.FillRectangle((Brush)new SolidBrush(color_0), int_1, int_2, int_3, int_4);
		}
		Color color = ControlPaint.Light(color_0);
		Color color2 = ControlPaint.Dark(color_0);
		Pen val = null;
		Pen val2 = null;
		Pen val3 = new Pen(color_0);
		int_4--;
		int_3--;
		switch (border3DStyle_0 - 2)
		{
		default:
			if ((int)border3DStyle_0 == 10)
			{
				val2 = new Pen(ControlPaint.DarkDark(color_0), 1f);
				val = new Pen(color2, 1f);
				if ((border3DSide_0 & 2) != 0)
				{
					graphics_0.DrawLine(val2, int_1, int_2, int_1 + int_3, int_2);
					graphics_0.DrawLine(val, int_1 + 1, int_2 + 1, int_1 + int_3 - 2, int_2 + 1);
				}
				if ((border3DSide_0 & 1) != 0)
				{
					graphics_0.DrawLine(val2, int_1, int_2, int_1, int_2 + int_4);
					graphics_0.DrawLine(val, int_1 + 1, int_2 + 1, int_1 + 1, int_2 + int_4 - 2);
				}
				val2.Dispose();
				val.Dispose();
				val2 = new Pen(color, 1f);
				val = new Pen(ControlPaint.LightLight(color_0), 1f);
				if ((border3DSide_0 & 4) != 0)
				{
					graphics_0.DrawLine(val2, int_1 + int_3, int_2, int_1 + int_3, int_2 + int_4);
					graphics_0.DrawLine(val, int_1 + int_3 - 1, int_2 + 1, int_1 + int_3 - 1, int_2 + int_4 - 1);
				}
				if ((border3DSide_0 & 8) != 0)
				{
					graphics_0.DrawLine(val2, int_1, int_2 + int_4, int_1 + int_3, int_2 + int_4);
					graphics_0.DrawLine(val, int_1 + 1, int_2 + int_4 - 1, int_1 + int_3 - 1, int_2 + int_4 - 1);
				}
			}
			break;
		case 0:
			val = new Pen(color, 1f);
			val2 = new Pen(color2, 1f);
			if ((border3DSide_0 & 2) != 0)
			{
				graphics_0.DrawLine(val2, int_1, int_2, int_1 + int_3, int_2);
			}
			if ((border3DSide_0 & 1) != 0)
			{
				graphics_0.DrawLine(val2, int_1, int_2, int_1, int_2 + int_4);
			}
			if ((border3DSide_0 & 4) != 0)
			{
				graphics_0.DrawLine(val, int_1 + int_3, int_2, int_1 + int_3, int_2 + int_4);
			}
			if ((border3DSide_0 & 8) != 0)
			{
				graphics_0.DrawLine(val, int_1, int_2 + int_4, int_1 + int_3, int_2 + int_4);
			}
			break;
		case 2:
			val = new Pen(color, 1f);
			val2 = new Pen(color2, 1f);
			if ((border3DSide_0 & 2) != 0)
			{
				graphics_0.DrawLine(val, int_1, int_2, int_1 + int_3, int_2);
			}
			if ((border3DSide_0 & 1) != 0)
			{
				graphics_0.DrawLine(val, int_1, int_2, int_1, int_2 + int_4);
			}
			if ((border3DSide_0 & 4) != 0)
			{
				graphics_0.DrawLine(val2, int_1 + int_3, int_2, int_1 + int_3, int_2 + int_4);
			}
			if ((border3DSide_0 & 8) != 0)
			{
				graphics_0.DrawLine(val2, int_1, int_2 + int_4, int_1 + int_3, int_2 + int_4);
			}
			break;
		case 3:
			if ((border3DSide_0 & 2) != 0 && (border3DSide_0 & 1) != 0 && (border3DSide_0 & 4) != 0 && (border3DSide_0 & 8) != 0)
			{
				val = new Pen(Color.White, 1f);
				graphics_0.DrawRectangle(val3, int_1, int_2, int_3, int_4);
				graphics_0.DrawLine(val, int_1 + 1, int_2 + 1, int_1 + int_3 - 1, int_2 + 1);
				graphics_0.DrawLine(val, int_1 + 1, int_2 + 1, int_1 + 1, int_2 + int_4 - 1);
				break;
			}
			val2 = new Pen(color, 1f);
			val = new Pen(ControlPaint.LightLight(color_0), 1f);
			if ((border3DSide_0 & 2) != 0)
			{
				graphics_0.DrawLine(val2, int_1, int_2, int_1 + int_3, int_2);
				graphics_0.DrawLine(val, int_1 + 1, int_2 + 1, int_1 + int_3 - 2, int_2 + 1);
			}
			if ((border3DSide_0 & 1) != 0)
			{
				graphics_0.DrawLine(val2, int_1, int_2, int_1, int_2 + int_4);
				graphics_0.DrawLine(val, int_1 + 1, int_2 + 1, int_1 + 1, int_2 + int_4 - 2);
			}
			val2.Dispose();
			val.Dispose();
			val2 = new Pen(ControlPaint.DarkDark(color_0), 1f);
			val = new Pen(color2, 1f);
			if ((border3DSide_0 & 4) != 0)
			{
				graphics_0.DrawLine(val2, int_1 + int_3, int_2, int_1 + int_3, int_2 + int_4);
				graphics_0.DrawLine(val, int_1 + int_3 - 1, int_2 + 1, int_1 + int_3 - 1, int_2 + int_4 - 1);
			}
			if ((border3DSide_0 & 8) != 0)
			{
				graphics_0.DrawLine(val2, int_1, int_2 + int_4, int_1 + int_3, int_2 + int_4);
				graphics_0.DrawLine(val, int_1 + 1, int_2 + int_4 - 1, int_1 + int_3 - 1, int_2 + int_4 - 1);
			}
			break;
		case 1:
			break;
		}
		if (val != null)
		{
			val.Dispose();
		}
		if (val2 != null)
		{
			val2.Dispose();
		}
		val3.Dispose();
	}

	internal static LinearGradientBrush smethod_40(Rectangle rectangle_0, Color color_0, Color color_1, float float_0)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		if (rectangle_0.Width <= 0)
		{
			rectangle_0.Width = 1;
		}
		if (rectangle_0.Height <= 0)
		{
			rectangle_0.Height = 1;
		}
		return new LinearGradientBrush(new Rectangle(rectangle_0.X, rectangle_0.Y - 1, rectangle_0.Width, rectangle_0.Height + 1), color_0, color_1, float_0);
	}

	internal static LinearGradientBrush smethod_41(RectangleF rectangleF_0, Color color_0, Color color_1, float float_0)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		if (rectangleF_0.Width <= 0f)
		{
			rectangleF_0.Width = 1f;
		}
		if (rectangleF_0.Height <= 0f)
		{
			rectangleF_0.Height = 1f;
		}
		return new LinearGradientBrush(new RectangleF(rectangleF_0.X, rectangleF_0.Y - 1f, rectangleF_0.Width, rectangleF_0.Height + 1f), color_0, color_1, float_0);
	}

	internal static LinearGradientBrush smethod_42(Rectangle rectangle_0, Color color_0, Color color_1, float float_0, bool bool_3)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		if (rectangle_0.Width <= 0)
		{
			rectangle_0.Width = 1;
		}
		if (rectangle_0.Height <= 0)
		{
			rectangle_0.Height = 1;
		}
		return new LinearGradientBrush(new Rectangle(rectangle_0.X, rectangle_0.Y - 1, rectangle_0.Width, rectangle_0.Height + 1), color_0, color_1, float_0, bool_3);
	}

	public static void smethod_43(Graphics graphics_0, Rectangle rectangle_0, Color color_0, Color color_1, int int_1)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		if (rectangle_0.Width > 0 && rectangle_0.Height > 0)
		{
			if (!color_0.IsEmpty && color_0 != Color.Transparent)
			{
				color_1 = ((!((double)color_0.GetBrightness() < 0.5)) ? ControlPaint.Dark(color_0) : ControlPaint.Light(color_0));
			}
			Pen val = new Pen(color_1, (float)int_1);
			try
			{
				val.set_DashStyle((DashStyle)1);
				rectangle_0.Width--;
				rectangle_0.Height--;
				graphics_0.DrawRectangle(val, rectangle_0);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	public static BaseItem smethod_44(BaseItem baseItem_0, string string_2)
	{
		return smethod_45(baseItem_0, string_2, bool_3: false);
	}

	public static BaseItem smethod_45(BaseItem baseItem_0, string string_2, bool bool_3)
	{
		if (baseItem_0 == null)
		{
			return null;
		}
		foreach (BaseItem subItem in baseItem_0.SubItems)
		{
			if ((!bool_3 || !(subItem.GlobalName == string_2)) && (bool_3 || !(subItem.Name == string_2)))
			{
				if (subItem.SubItems.Count > 0)
				{
					BaseItem baseItem2 = smethod_45(subItem, string_2, bool_3);
					if (baseItem2 != null)
					{
						return baseItem2;
					}
				}
				continue;
			}
			return subItem;
		}
		if (baseItem_0 is GalleryContainer)
		{
			return smethod_45(((GalleryContainer)baseItem_0).ButtonItem_0, string_2, bool_3);
		}
		return null;
	}

	public static void smethod_46(BaseItem baseItem_0, string string_2, ArrayList arrayList_1)
	{
		smethod_47(baseItem_0, string_2, arrayList_1, bool_3: false);
	}

	public static void smethod_47(BaseItem baseItem_0, string string_2, ArrayList arrayList_1, bool bool_3)
	{
		if (baseItem_0 == null)
		{
			return;
		}
		foreach (BaseItem subItem in baseItem_0.SubItems)
		{
			if ((bool_3 && subItem.GlobalName == string_2) || (!bool_3 && subItem.Name == string_2))
			{
				arrayList_1.Add(subItem);
			}
			else if (subItem is ControlContainerItem)
			{
				ControlContainerItem controlContainerItem = subItem as ControlContainerItem;
				if (controlContainerItem.Control is RibbonBar)
				{
					RibbonBar ribbonBar = controlContainerItem.Control as RibbonBar;
					ArrayList items = ribbonBar.GetItems(string_2);
					arrayList_1.AddRange(items);
				}
			}
			if (subItem.SubItems.Count > 0)
			{
				smethod_47(subItem, string_2, arrayList_1, bool_3);
			}
		}
		if (baseItem_0 is GalleryContainer)
		{
			smethod_47(((GalleryContainer)baseItem_0).ButtonItem_0, string_2, arrayList_1, bool_3);
		}
	}

	public static void smethod_48(BaseItem baseItem_0, string string_2, ArrayList arrayList_1, Type type_0)
	{
		smethod_49(baseItem_0, string_2, arrayList_1, type_0, bool_3: false);
	}

	public static void smethod_49(BaseItem baseItem_0, string string_2, ArrayList arrayList_1, Type type_0, bool bool_3)
	{
		if (baseItem_0 == null)
		{
			return;
		}
		foreach (BaseItem subItem in baseItem_0.SubItems)
		{
			if ((object)subItem.GetType() == type_0 && ((bool_3 && subItem.GlobalName == string_2) || (!bool_3 && subItem.Name == string_2)))
			{
				arrayList_1.Add(subItem);
			}
			else if (subItem is ControlContainerItem)
			{
				ControlContainerItem controlContainerItem = subItem as ControlContainerItem;
				if (controlContainerItem.Control is RibbonBar)
				{
					RibbonBar ribbonBar = controlContainerItem.Control as RibbonBar;
					ArrayList items = ribbonBar.GetItems(string_2, type_0, bool_3);
					arrayList_1.AddRange(items);
				}
			}
			if (subItem.SubItems.Count > 0)
			{
				smethod_49(subItem, string_2, arrayList_1, type_0, bool_3);
			}
		}
	}

	public static string smethod_50(Color color_0)
	{
		if (color_0.IsSystemColor)
		{
			return "." + color_0.Name;
		}
		return color_0.ToArgb().ToString();
	}

	public static Color smethod_51(string string_2)
	{
		if (string_2 == "")
		{
			return Color.Empty;
		}
		if (string_2[0] == '.')
		{
			return Color.FromName(string_2.Substring(1));
		}
		return Color.FromArgb(XmlConvert.ToInt32(string_2));
	}

	public static Class273 smethod_52(Point point_0)
	{
		if (arrayList_0.Count == 0)
		{
			smethod_54();
		}
		foreach (Class273 item in arrayList_0)
		{
			if (item.rectangle_0.Contains(point_0))
			{
				return item;
			}
		}
		Screen val = Screen.FromPoint(point_0);
		if (val != null)
		{
			return new Class273(val.get_Bounds(), val.get_WorkingArea());
		}
		return null;
	}

	public static Class273 smethod_53(Control control_0)
	{
		Rectangle rect;
		if (control_0.get_Parent() != null)
		{
			Point location = control_0.PointToScreen(control_0.get_Location());
			rect = new Rectangle(location, control_0.get_Size());
		}
		else
		{
			rect = new Rectangle(control_0.get_Location(), control_0.get_Size());
		}
		if (arrayList_0.Count == 0)
		{
			smethod_54();
		}
		foreach (Class273 item in arrayList_0)
		{
			if (item.rectangle_0.Contains(rect))
			{
				return item;
			}
		}
		Screen val = Screen.FromControl(control_0);
		if (val != null)
		{
			return new Class273(val.get_Bounds(), val.get_WorkingArea());
		}
		return null;
	}

	public static void smethod_54()
	{
		arrayList_0.Clear();
		Screen[] allScreens = Screen.get_AllScreens();
		foreach (Screen val in allScreens)
		{
			arrayList_0.Add(new Class273(val.get_Bounds(), val.get_WorkingArea()));
		}
	}

	public static void smethod_55(ExplorerBar explorerBar_0, eExplorerBarStockStyle eExplorerBarStockStyle_0)
	{
		switch (eExplorerBarStockStyle_0)
		{
		case eExplorerBarStockStyle.SystemColors:
			explorerBar_0.BackStyle.Reset();
			explorerBar_0.BackStyle.BackColorSchemePart = eColorSchemePart.ExplorerBarBackground;
			explorerBar_0.BackStyle.BackColor2SchemePart = eColorSchemePart.ExplorerBarBackground2;
			explorerBar_0.BackStyle.BackColorGradientAngle = explorerBar_0.ColorScheme.ExplorerBarBackgroundGradientAngle;
			return;
		case eExplorerBarStockStyle.Custom:
			return;
		}
		ePredefinedColorScheme predefinedColorScheme = ePredefinedColorScheme.Blue2003;
		switch (eExplorerBarStockStyle_0)
		{
		case eExplorerBarStockStyle.OliveGreen:
		case eExplorerBarStockStyle.OliveGreenSpecial:
			predefinedColorScheme = ePredefinedColorScheme.OliveGreen2003;
			break;
		case eExplorerBarStockStyle.Silver:
		case eExplorerBarStockStyle.SilverSpecial:
			predefinedColorScheme = ePredefinedColorScheme.Silver2003;
			break;
		}
		ColorScheme colorScheme = new ColorScheme(eDotNetBarStyle.Office2003);
		colorScheme.PredefinedColorScheme = predefinedColorScheme;
		explorerBar_0.BackStyle.Reset();
		explorerBar_0.BackStyle.BackColor = colorScheme.ExplorerBarBackground;
		explorerBar_0.BackStyle.BackColor2 = colorScheme.ExplorerBarBackground2;
		explorerBar_0.BackStyle.BackColorGradientAngle = colorScheme.ExplorerBarBackgroundGradientAngle;
	}

	public static void smethod_56(ExplorerBarGroupItem explorerBarGroupItem_0, eExplorerBarStockStyle eExplorerBarStockStyle_0)
	{
		if (eExplorerBarStockStyle_0 == eExplorerBarStockStyle.SystemColors)
		{
			eExplorerBarStockStyle eExplorerBarStockStyle2 = eExplorerBarStockStyle.Blue;
			eExplorerBarStockStyle eExplorerBarStockStyle3 = eExplorerBarStockStyle.BlueSpecial;
			if (SystemColors.Control.ToArgb() == Color.FromArgb(224, 223, 227).ToArgb() && SystemColors.Highlight.ToArgb() == Color.FromArgb(178, 180, 191).ToArgb())
			{
				eExplorerBarStockStyle2 = eExplorerBarStockStyle.Silver;
				eExplorerBarStockStyle3 = eExplorerBarStockStyle.SilverSpecial;
			}
			else if (SystemColors.Control.ToArgb() == Color.FromArgb(236, 233, 216).ToArgb() && SystemColors.Highlight.ToArgb() == Color.FromArgb(147, 160, 112).ToArgb())
			{
				eExplorerBarStockStyle2 = eExplorerBarStockStyle.OliveGreen;
				eExplorerBarStockStyle3 = eExplorerBarStockStyle.OliveGreenSpecial;
			}
			eExplorerBarStockStyle_0 = ((!explorerBarGroupItem_0.XPSpecialGroup) ? eExplorerBarStockStyle2 : eExplorerBarStockStyle3);
		}
		if (eExplorerBarStockStyle_0 != eExplorerBarStockStyle.Custom)
		{
			explorerBarGroupItem_0.TitleStyle.Reset();
			explorerBarGroupItem_0.TitleHotStyle.Reset();
			explorerBarGroupItem_0.BackStyle.Reset();
			explorerBarGroupItem_0.TitleStyle.CornerTypeTopLeft = eCornerType.Rounded;
			explorerBarGroupItem_0.TitleStyle.CornerTypeTopRight = eCornerType.Rounded;
			explorerBarGroupItem_0.TitleStyle.CornerDiameter = 3;
			explorerBarGroupItem_0.TitleHotStyle.CornerTypeTopLeft = eCornerType.Rounded;
			explorerBarGroupItem_0.TitleHotStyle.CornerTypeTopRight = eCornerType.Rounded;
			explorerBarGroupItem_0.TitleHotStyle.CornerDiameter = 3;
		}
		switch (eExplorerBarStockStyle_0)
		{
		case eExplorerBarStockStyle.Blue:
			explorerBarGroupItem_0.TitleStyle.BackColor = Color.White;
			explorerBarGroupItem_0.TitleStyle.BackColor2 = Color.FromArgb(199, 211, 247);
			explorerBarGroupItem_0.TitleStyle.TextColor = Color.FromArgb(33, 93, 198);
			explorerBarGroupItem_0.TitleHotStyle.TextColor = Color.FromArgb(66, 142, 255);
			explorerBarGroupItem_0.TitleHotStyle.BackColor = Color.White;
			explorerBarGroupItem_0.TitleHotStyle.BackColor2 = Color.FromArgb(199, 211, 247);
			explorerBarGroupItem_0.BackStyle.BackColor = Color.FromArgb(214, 223, 247);
			explorerBarGroupItem_0.BackStyle.BorderBottom = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderTop = eStyleBorderType.None;
			explorerBarGroupItem_0.BackStyle.BorderLeft = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderRight = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderBottomWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderTopWidth = 0;
			explorerBarGroupItem_0.BackStyle.BorderLeftWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderRightWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderColor = Color.White;
			explorerBarGroupItem_0.ExpandBackColor = Color.White;
			explorerBarGroupItem_0.ExpandBorderColor = Color.FromArgb(174, 182, 216);
			explorerBarGroupItem_0.ExpandForeColor = Color.FromArgb(0, 60, 165);
			explorerBarGroupItem_0.ExpandHotBackColor = Color.White;
			explorerBarGroupItem_0.ExpandHotBorderColor = Color.FromArgb(174, 182, 216);
			explorerBarGroupItem_0.ExpandHotForeColor = Color.FromArgb(66, 142, 255);
			break;
		case eExplorerBarStockStyle.BlueSpecial:
			explorerBarGroupItem_0.TitleStyle.BackColor = Color.FromArgb(0, 73, 181);
			explorerBarGroupItem_0.TitleStyle.BackColor2 = Color.FromArgb(41, 93, 206);
			explorerBarGroupItem_0.TitleStyle.TextColor = Color.White;
			explorerBarGroupItem_0.TitleHotStyle.TextColor = Color.FromArgb(66, 142, 255);
			explorerBarGroupItem_0.TitleHotStyle.BackColor = Color.FromArgb(0, 73, 181);
			explorerBarGroupItem_0.TitleHotStyle.BackColor2 = Color.FromArgb(41, 93, 206);
			explorerBarGroupItem_0.BackStyle.Reset();
			explorerBarGroupItem_0.BackStyle.BackColor = Color.FromArgb(239, 243, 255);
			explorerBarGroupItem_0.BackStyle.BorderBottom = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderTop = eStyleBorderType.None;
			explorerBarGroupItem_0.BackStyle.BorderLeft = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderRight = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderBottomWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderTopWidth = 0;
			explorerBarGroupItem_0.BackStyle.BorderLeftWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderRightWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderColor = Color.White;
			explorerBarGroupItem_0.ExpandBackColor = Color.FromArgb(48, 97, 196);
			explorerBarGroupItem_0.ExpandBorderColor = Color.FromArgb(123, 168, 229);
			explorerBarGroupItem_0.ExpandForeColor = Color.White;
			explorerBarGroupItem_0.ExpandHotBackColor = Color.FromArgb(48, 97, 196);
			explorerBarGroupItem_0.ExpandHotBorderColor = Color.FromArgb(123, 168, 229);
			explorerBarGroupItem_0.ExpandHotForeColor = Color.FromArgb(172, 205, 255);
			break;
		case eExplorerBarStockStyle.OliveGreen:
			explorerBarGroupItem_0.TitleStyle.BackColor = Color.FromArgb(255, 252, 236);
			explorerBarGroupItem_0.TitleStyle.BackColor2 = Color.FromArgb(224, 231, 184);
			explorerBarGroupItem_0.TitleStyle.TextColor = Color.FromArgb(86, 102, 45);
			explorerBarGroupItem_0.TitleHotStyle.TextColor = Color.FromArgb(114, 146, 29);
			explorerBarGroupItem_0.TitleHotStyle.BackColor = Color.FromArgb(255, 252, 236);
			explorerBarGroupItem_0.TitleHotStyle.BackColor2 = Color.FromArgb(224, 231, 184);
			explorerBarGroupItem_0.BackStyle.Reset();
			explorerBarGroupItem_0.BackStyle.BackColor = Color.FromArgb(246, 246, 236);
			explorerBarGroupItem_0.BackStyle.BorderBottom = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderTop = eStyleBorderType.None;
			explorerBarGroupItem_0.BackStyle.BorderLeft = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderRight = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderBottomWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderTopWidth = 0;
			explorerBarGroupItem_0.BackStyle.BorderLeftWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderRightWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderColor = Color.White;
			explorerBarGroupItem_0.ExpandBackColor = Color.FromArgb(254, 254, 253);
			explorerBarGroupItem_0.ExpandBorderColor = Color.FromArgb(194, 206, 185);
			explorerBarGroupItem_0.ExpandForeColor = Color.FromArgb(75, 103, 28);
			explorerBarGroupItem_0.ExpandHotBackColor = Color.FromArgb(254, 254, 253);
			explorerBarGroupItem_0.ExpandHotBorderColor = Color.FromArgb(194, 206, 185);
			explorerBarGroupItem_0.ExpandHotForeColor = Color.FromArgb(114, 146, 29);
			break;
		case eExplorerBarStockStyle.OliveGreenSpecial:
			explorerBarGroupItem_0.TitleStyle.BackColor = Color.FromArgb(119, 140, 64);
			explorerBarGroupItem_0.TitleStyle.BackColor2 = Color.FromArgb(150, 168, 103);
			explorerBarGroupItem_0.TitleStyle.TextColor = Color.White;
			explorerBarGroupItem_0.TitleHotStyle.TextColor = Color.FromArgb(224, 231, 184);
			explorerBarGroupItem_0.TitleHotStyle.BackColor = Color.FromArgb(119, 140, 64);
			explorerBarGroupItem_0.TitleHotStyle.BackColor2 = Color.FromArgb(150, 168, 103);
			explorerBarGroupItem_0.BackStyle.Reset();
			explorerBarGroupItem_0.BackStyle.BackColor = Color.FromArgb(246, 246, 236);
			explorerBarGroupItem_0.BackStyle.BorderBottom = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderTop = eStyleBorderType.None;
			explorerBarGroupItem_0.BackStyle.BorderLeft = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderRight = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderBottomWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderTopWidth = 0;
			explorerBarGroupItem_0.BackStyle.BorderLeftWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderRightWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderColor = Color.White;
			explorerBarGroupItem_0.ExpandBackColor = Color.FromArgb(129, 163, 79);
			explorerBarGroupItem_0.ExpandBorderColor = Color.FromArgb(191, 205, 156);
			explorerBarGroupItem_0.ExpandForeColor = Color.White;
			explorerBarGroupItem_0.ExpandHotBackColor = Color.FromArgb(130, 164, 80);
			explorerBarGroupItem_0.ExpandHotBorderColor = Color.FromArgb(182, 202, 139);
			explorerBarGroupItem_0.ExpandHotForeColor = Color.FromArgb(221, 237, 190);
			break;
		case eExplorerBarStockStyle.Silver:
			explorerBarGroupItem_0.TitleStyle.BackColor = Color.White;
			explorerBarGroupItem_0.TitleStyle.BackColor2 = Color.FromArgb(214, 215, 224);
			explorerBarGroupItem_0.TitleStyle.TextColor = Color.FromArgb(63, 61, 61);
			explorerBarGroupItem_0.TitleHotStyle.TextColor = Color.FromArgb(126, 124, 124);
			explorerBarGroupItem_0.TitleHotStyle.BackColor = Color.White;
			explorerBarGroupItem_0.TitleHotStyle.BackColor2 = Color.FromArgb(214, 215, 224);
			explorerBarGroupItem_0.BackStyle.Reset();
			explorerBarGroupItem_0.BackStyle.BackColor = Color.FromArgb(240, 241, 245);
			explorerBarGroupItem_0.BackStyle.BorderBottom = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderTop = eStyleBorderType.None;
			explorerBarGroupItem_0.BackStyle.BorderLeft = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderRight = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderBottomWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderTopWidth = 0;
			explorerBarGroupItem_0.BackStyle.BorderLeftWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderRightWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderColor = Color.White;
			explorerBarGroupItem_0.ExpandBackColor = Color.White;
			explorerBarGroupItem_0.ExpandBorderColor = Color.FromArgb(188, 189, 203);
			explorerBarGroupItem_0.ExpandForeColor = Color.FromArgb(49, 68, 115);
			explorerBarGroupItem_0.ExpandHotBackColor = Color.White;
			explorerBarGroupItem_0.ExpandHotBorderColor = Color.FromArgb(194, 195, 208);
			explorerBarGroupItem_0.ExpandHotForeColor = Color.FromArgb(126, 124, 124);
			break;
		case eExplorerBarStockStyle.SilverSpecial:
			explorerBarGroupItem_0.TitleStyle.BackColor = Color.FromArgb(119, 119, 146);
			explorerBarGroupItem_0.TitleStyle.BackColor2 = Color.FromArgb(180, 182, 199);
			explorerBarGroupItem_0.TitleStyle.TextColor = Color.White;
			explorerBarGroupItem_0.TitleHotStyle.BackColor = Color.FromArgb(119, 119, 146);
			explorerBarGroupItem_0.TitleHotStyle.BackColor2 = Color.FromArgb(180, 182, 199);
			explorerBarGroupItem_0.TitleHotStyle.TextColor = Color.FromArgb(230, 230, 230);
			explorerBarGroupItem_0.BackStyle.Reset();
			explorerBarGroupItem_0.BackStyle.BackColor = Color.FromArgb(240, 241, 245);
			explorerBarGroupItem_0.BackStyle.BorderBottom = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderTop = eStyleBorderType.None;
			explorerBarGroupItem_0.BackStyle.BorderLeft = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderRight = eStyleBorderType.Solid;
			explorerBarGroupItem_0.BackStyle.BorderBottomWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderTopWidth = 0;
			explorerBarGroupItem_0.BackStyle.BorderLeftWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderRightWidth = 1;
			explorerBarGroupItem_0.BackStyle.BorderColor = Color.White;
			explorerBarGroupItem_0.ExpandBackColor = Color.FromArgb(111, 117, 151);
			explorerBarGroupItem_0.ExpandBorderColor = Color.FromArgb(196, 203, 224);
			explorerBarGroupItem_0.ExpandForeColor = Color.White;
			explorerBarGroupItem_0.ExpandHotBackColor = Color.FromArgb(111, 117, 151);
			explorerBarGroupItem_0.ExpandHotBorderColor = Color.FromArgb(196, 203, 224);
			explorerBarGroupItem_0.ExpandHotForeColor = Color.White;
			break;
		}
	}

	public static void smethod_57(ButtonItem buttonItem_0, eExplorerBarStockStyle eExplorerBarStockStyle_0)
	{
		if (eExplorerBarStockStyle_0 == eExplorerBarStockStyle.SystemColors)
		{
			eExplorerBarStockStyle eExplorerBarStockStyle2 = eExplorerBarStockStyle.Blue;
			if (SystemColors.Control.ToArgb() == Color.FromArgb(224, 223, 227).ToArgb() && SystemColors.Highlight.ToArgb() == Color.FromArgb(178, 180, 191).ToArgb())
			{
				eExplorerBarStockStyle2 = eExplorerBarStockStyle.Silver;
			}
			else if (SystemColors.Control.ToArgb() == Color.FromArgb(236, 233, 216).ToArgb() && SystemColors.Highlight.ToArgb() == Color.FromArgb(147, 160, 112).ToArgb())
			{
				eExplorerBarStockStyle2 = eExplorerBarStockStyle.OliveGreen;
			}
			eExplorerBarStockStyle_0 = eExplorerBarStockStyle2;
		}
		switch (eExplorerBarStockStyle_0)
		{
		default:
			buttonItem_0.ForeColor = SystemColors.ControlText;
			buttonItem_0.HotForeColor = SystemColors.ControlDark;
			break;
		case eExplorerBarStockStyle.Blue:
		case eExplorerBarStockStyle.BlueSpecial:
			buttonItem_0.ForeColor = Color.FromArgb(33, 93, 198);
			buttonItem_0.HotForeColor = Color.FromArgb(66, 142, 255);
			break;
		case eExplorerBarStockStyle.OliveGreen:
		case eExplorerBarStockStyle.OliveGreenSpecial:
			buttonItem_0.ForeColor = Color.FromArgb(86, 102, 45);
			buttonItem_0.HotForeColor = Color.FromArgb(114, 146, 29);
			break;
		case eExplorerBarStockStyle.Silver:
		case eExplorerBarStockStyle.SilverSpecial:
			buttonItem_0.ForeColor = Color.FromArgb(63, 61, 61);
			buttonItem_0.HotForeColor = Color.FromArgb(126, 124, 124);
			break;
		}
	}

	public static MdiClient smethod_58(Form form_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		if (!form_0.get_IsMdiContainer())
		{
			return null;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)form_0).get_Controls())
		{
			Control val = item;
			if (val is MdiClient)
			{
				return (MdiClient)(object)((val is MdiClient) ? val : null);
			}
		}
		return null;
	}

	internal static Icon smethod_59(Icon icon_0)
	{
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			icon_0.Save((Stream)memoryStream);
			byte[] byte_ = memoryStream.ToArray();
			int num = byte_[4];
			for (int i = 0; i < num; i++)
			{
				int num2 = 6 + i * 16;
				int num3 = byte_[num2];
				int num4 = byte_[num2 + 1];
				int num5 = smethod_60(ref byte_, num2 + 12);
				int num6 = smethod_60(ref byte_, num5);
				int num7 = smethod_61(ref byte_, num5 + 12);
				int num8 = smethod_61(ref byte_, num5 + 14);
				if (num7 != 1)
				{
					continue;
				}
				int num9 = smethod_60(ref byte_, num5 + 20);
				int num10 = 0;
				int num11 = num8;
				if (num11 != 8)
				{
					if (num11 != 24)
					{
						if (num11 != 32)
						{
							continue;
						}
						num10 = 4;
						num9 = num3 * num4 * 4;
					}
					else
					{
						num10 = 3;
						num9 = num3 * num4 * 3;
					}
				}
				else
				{
					num10 = 4;
					num9 = 1024;
				}
				int num12 = num5 + num6;
				for (int j = num12; j < num12 + num9; j += num10)
				{
					byte b = (byte)((byte_[j] + 255) / 2);
					byte b2 = (byte)((byte_[j + 1] + 255) / 2);
					byte b3 = (byte)((byte_[j + 2] + 255) / 2);
					if (b != 127 || b2 != 127 || b3 != 127)
					{
						byte b4 = (byte_[j + 2] = (byte_[j + 1] = (byte_[j] = (byte)((double)(int)b3 * 0.299 + (double)(int)b2 * 0.587 + (double)(int)b * 0.114))));
					}
				}
			}
			return new Icon((Stream)new MemoryStream(byte_));
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static int smethod_60(ref byte[] byte_0, int int_1)
	{
		return byte_0[int_1] + (byte_0[int_1 + 1] << 8) + (byte_0[int_1 + 2] << 16) + (byte_0[int_1 + 3] << 24);
	}

	private static int smethod_61(ref byte[] byte_0, int int_1)
	{
		return byte_0[int_1] + (byte_0[int_1 + 1] << 8);
	}

	internal static void smethod_62(Graphics graphics_0, Rectangle rectangle_0, Image image_0, eStyleBackgroundImage eStyleBackgroundImage_0, int int_1)
	{
		smethod_63(graphics_0, rectangle_0, image_0, (eBackgroundImagePosition)eStyleBackgroundImage_0, int_1);
	}

	internal static void smethod_63(Graphics graphics_0, Rectangle rectangle_0, Image image_0, eBackgroundImagePosition eBackgroundImagePosition_0, int int_1)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		if (image_0 == null)
		{
			return;
		}
		Rectangle rectangle = rectangle_0;
		ImageAttributes val = null;
		if (int_1 != 255)
		{
			ColorMatrix val2 = new ColorMatrix();
			val2.set_Matrix33((float)(255 - int_1));
			val = new ImageAttributes();
			val.SetColorMatrix(val2, (ColorMatrixFlag)0, (ColorAdjustType)1);
		}
		switch (eBackgroundImagePosition_0)
		{
		case eBackgroundImagePosition.Stretch:
			if (val != null)
			{
				graphics_0.DrawImage(image_0, rectangle, 0, 0, image_0.get_Width(), image_0.get_Height(), (GraphicsUnit)2, val);
			}
			else
			{
				graphics_0.DrawImage(image_0, rectangle, 0, 0, image_0.get_Width(), image_0.get_Height(), (GraphicsUnit)2);
			}
			break;
		case eBackgroundImagePosition.Center:
		{
			Rectangle rectangle5 = new Rectangle(rectangle.X, rectangle.Y, image_0.get_Width(), image_0.get_Height());
			if (rectangle.Width > image_0.get_Width())
			{
				rectangle5.X += (rectangle.Width - image_0.get_Width()) / 2;
			}
			if (rectangle.Height > image_0.get_Height())
			{
				rectangle5.Y += (rectangle.Height - image_0.get_Height()) / 2;
			}
			if (val != null)
			{
				graphics_0.DrawImage(image_0, rectangle5, 0, 0, image_0.get_Width(), image_0.get_Height(), (GraphicsUnit)2, val);
			}
			else
			{
				graphics_0.DrawImage(image_0, rectangle5, 0, 0, image_0.get_Width(), image_0.get_Height(), (GraphicsUnit)2);
			}
			break;
		}
		case eBackgroundImagePosition.Tile:
			if (val != null)
			{
				if (rectangle.Width <= image_0.get_Width() && rectangle.Height <= image_0.get_Height())
				{
					graphics_0.DrawImage(image_0, new Rectangle(0, 0, image_0.get_Width(), image_0.get_Height()), 0, 0, image_0.get_Width(), image_0.get_Height(), (GraphicsUnit)2, val);
					break;
				}
				int i = rectangle.X;
				for (int j = rectangle.Y; j < rectangle.Bottom; j += image_0.get_Height())
				{
					for (; i < rectangle.Right; i += image_0.get_Width())
					{
						Rectangle rectangle4 = new Rectangle(i, j, image_0.get_Width(), image_0.get_Height());
						if (rectangle4.Right > rectangle.Right)
						{
							rectangle4.Width -= rectangle4.Right - rectangle.Right;
						}
						if (rectangle4.Bottom > rectangle.Bottom)
						{
							rectangle4.Height -= rectangle4.Bottom - rectangle.Bottom;
						}
						graphics_0.DrawImage(image_0, rectangle4, 0, 0, rectangle4.Width, rectangle4.Height, (GraphicsUnit)2, val);
					}
					i = rectangle.X;
				}
			}
			else
			{
				TextureBrush val3 = new TextureBrush(image_0);
				val3.set_WrapMode((WrapMode)0);
				graphics_0.FillRectangle((Brush)(object)val3, rectangle);
				((Brush)val3).Dispose();
			}
			break;
		case eBackgroundImagePosition.TopLeft:
		case eBackgroundImagePosition.TopRight:
		case eBackgroundImagePosition.BottomLeft:
		case eBackgroundImagePosition.BottomRight:
		{
			Rectangle rectangle3 = new Rectangle(rectangle.X, rectangle.Y, image_0.get_Width(), image_0.get_Height());
			switch (eBackgroundImagePosition_0)
			{
			case eBackgroundImagePosition.TopRight:
				rectangle3.X = rectangle.Right - image_0.get_Width();
				break;
			case eBackgroundImagePosition.BottomLeft:
				rectangle3.Y = rectangle.Bottom - image_0.get_Height();
				break;
			case eBackgroundImagePosition.BottomRight:
				rectangle3.Y = rectangle.Bottom - image_0.get_Height();
				rectangle3.X = rectangle.Right - image_0.get_Width();
				break;
			}
			if (val != null)
			{
				graphics_0.DrawImage(image_0, rectangle3, 0, 0, image_0.get_Width(), image_0.get_Height(), (GraphicsUnit)2, val);
			}
			else
			{
				graphics_0.DrawImage(image_0, rectangle3, 0, 0, image_0.get_Width(), image_0.get_Height(), (GraphicsUnit)2);
			}
			break;
		}
		case eBackgroundImagePosition.CenterLeft:
		case eBackgroundImagePosition.CenterRight:
		{
			Rectangle rectangle2 = new Rectangle(rectangle.X, rectangle.Y, image_0.get_Width(), image_0.get_Height());
			if (rectangle.Width > image_0.get_Width() && eBackgroundImagePosition_0 == eBackgroundImagePosition.CenterRight)
			{
				rectangle2.X += rectangle.Width - image_0.get_Width();
			}
			rectangle2.Y += (rectangle.Height - image_0.get_Height()) / 2;
			if (val != null)
			{
				graphics_0.DrawImage(image_0, rectangle2, 0, 0, image_0.get_Width(), image_0.get_Height(), (GraphicsUnit)2, val);
			}
			else
			{
				graphics_0.DrawImage(image_0, rectangle2, 0, 0, image_0.get_Width(), image_0.get_Height(), (GraphicsUnit)2);
			}
			break;
		}
		}
	}

	public static bool smethod_64(Keys keys_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		if ((int)keys_0 != 107 && (int)keys_0 != 262144 && (int)keys_0 != 93 && (int)keys_0 != 246 && (int)keys_0 != 8 && (int)keys_0 != 27 && (int)keys_0 != 13 && ((int)keys_0 < 112 || (int)keys_0 > 130) && (int)keys_0 != 9)
		{
			return false;
		}
		return true;
	}

	public static bool smethod_65(Form form_0)
	{
		if (form_0 == null)
		{
			return false;
		}
		if (Form.get_ActiveForm() == form_0)
		{
			if (form_0.get_IsMdiChild() && form_0.get_MdiParent() != null)
			{
				if (form_0.get_MdiParent().get_ActiveMdiChild() == form_0)
				{
					return true;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public static void smethod_66(Control control_0, bool bool_3, int int_1, Rectangle rectangle_0, Rectangle rectangle_1)
	{
		control_0.set_Bounds(rectangle_0);
		if (!control_0.get_Visible())
		{
			control_0.set_Visible(true);
		}
		bool flag = false;
		TimeSpan timeSpan = new TimeSpan(0, 0, 0, 0, int_1);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (rectangle_0.Left == rectangle_1.Left && rectangle_0.Top == rectangle_1.Top && rectangle_0.Right == rectangle_1.Right)
		{
			num = ((rectangle_1.Height > rectangle_0.Height) ? 1 : (-1));
		}
		else if (rectangle_0.Left == rectangle_1.Left && rectangle_0.Top == rectangle_1.Top && rectangle_0.Bottom == rectangle_1.Bottom)
		{
			num2 = ((rectangle_1.Width > rectangle_0.Width) ? 1 : (-1));
		}
		else if (rectangle_0.Right == rectangle_1.Right && rectangle_0.Top == rectangle_1.Top && rectangle_0.Bottom == rectangle_1.Bottom)
		{
			num4 = ((rectangle_1.Width <= rectangle_0.Width) ? 1 : (-1));
			num2 = ((rectangle_1.Width > rectangle_0.Width) ? 1 : (-1));
		}
		else if (rectangle_0.Right == rectangle_1.Right && rectangle_0.Left == rectangle_1.Left && rectangle_0.Bottom == rectangle_1.Bottom)
		{
			num3 = ((rectangle_1.Height <= rectangle_0.Height) ? 1 : (-1));
			num = ((rectangle_1.Height > rectangle_0.Height) ? 1 : (-1));
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			control_0.set_Bounds(rectangle_1);
		}
		else
		{
			int num5 = 1;
			int num6 = ((rectangle_0.Width != rectangle_1.Width) ? Math.Abs(rectangle_0.Width - rectangle_1.Width) : Math.Abs(rectangle_0.Height - rectangle_1.Height));
			int num7 = num6;
			DateTime now = DateTime.Now;
			Rectangle rectangle = rectangle_0;
			while (rectangle != rectangle_1)
			{
				DateTime now2 = DateTime.Now;
				rectangle.X += num4 * num5;
				rectangle.Y += num3 * num5;
				rectangle.Width += num2 * num5;
				rectangle.Height += num * num5;
				if (Math.Sign(rectangle_1.X - rectangle.X) != Math.Sign(num4))
				{
					rectangle.X = rectangle_1.X;
				}
				if (Math.Sign(rectangle_1.Y - rectangle.Y) != Math.Sign(num3))
				{
					rectangle.Y = rectangle_1.Y;
				}
				if (Math.Sign(rectangle_1.Width - rectangle.Width) != Math.Sign(num2))
				{
					rectangle.Width = rectangle_1.Width;
				}
				if (Math.Sign(rectangle_1.Height - rectangle.Height) != Math.Sign(num))
				{
					rectangle.Height = rectangle_1.Height;
				}
				control_0.set_Bounds(rectangle);
				if (control_0.get_Parent() != null)
				{
					control_0.get_Parent().Update();
				}
				else
				{
					control_0.Update();
				}
				num7 -= num5;
				do
				{
					TimeSpan timeSpan2 = DateTime.Now - now2;
					TimeSpan timeSpan3 = DateTime.Now - now;
					if ((timeSpan - timeSpan3).TotalMilliseconds > 0.0)
					{
						if ((timeSpan - timeSpan3).TotalMilliseconds == 0.0)
						{
							num5 = 1;
							continue;
						}
						try
						{
							num5 = num7 * (int)timeSpan2.TotalMilliseconds / (int)(timeSpan - timeSpan3).TotalMilliseconds;
						}
						catch
						{
						}
						continue;
					}
					num5 = num7;
					break;
				}
				while (num5 < 1);
			}
		}
		if (!bool_3)
		{
			control_0.set_Visible(false);
			control_0.set_Bounds(rectangle_0);
		}
	}

	internal static Bitmap smethod_67(string string_2)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		if (Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(DotNetBarResourcesAttribute)) is DotNetBarResourcesAttribute dotNetBarResourcesAttribute && dotNetBarResourcesAttribute.NamespacePrefix != "")
		{
			return new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(dotNetBarResourcesAttribute.NamespacePrefix + "." + string_2));
		}
		return new Bitmap(typeof(DotNetBarManager), string_2);
	}

	public static Graphics smethod_68(Control control_0)
	{
		if (control_0 is ItemControl)
		{
			return ((ItemControl)(object)control_0).CreateGraphics();
		}
		if (control_0 is Bar)
		{
			return ((Bar)(object)control_0).CreateGraphics();
		}
		if (control_0 is ExplorerBar)
		{
			return ((ExplorerBar)(object)control_0).CreateGraphics();
		}
		if (control_0 is BaseItemControl)
		{
			return ((BaseItemControl)(object)control_0).CreateGraphics();
		}
		if (control_0 is BarBaseControl)
		{
			return ((BarBaseControl)(object)control_0).CreateGraphics();
		}
		return control_0.CreateGraphics();
	}

	public static bool smethod_69(eDotNetBarStyle eDotNetBarStyle_0)
	{
		return eDotNetBarStyle_0 == eDotNetBarStyle.Office2007;
	}
}
