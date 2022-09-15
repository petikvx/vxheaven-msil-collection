using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ComVisible(false)]
[ToolboxItem(false)]
public class AutoHidePanel : Control
{
	private class Class174
	{
		private AutoHidePanel autoHidePanel_0;

		private ColorScheme colorScheme_0;

		private int int_0 = 1;

		private bool bool_0;

		public bool Boolean_0
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

		public Class174(AutoHidePanel autoHidePanel, ColorScheme colorScheme)
		{
			autoHidePanel_0 = autoHidePanel;
			colorScheme_0 = colorScheme;
		}

		public void method_0(Graphics graphics_0, ArrayList arrayList_0)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Invalid comparison between Unknown and I4
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Invalid comparison between Unknown and I4
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Invalid comparison between Unknown and I4
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Invalid comparison between Unknown and I4
			//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Invalid comparison between Unknown and I4
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Invalid comparison between Unknown and I4
			ArrayList arrayList = new ArrayList();
			Point point = new Point(0, 0);
			if ((int)((Control)autoHidePanel_0).get_Dock() != 3 && (int)((Control)autoHidePanel_0).get_Dock() != 4)
			{
				point.X = 2;
			}
			else
			{
				point.Y = 2;
				point.X = 1;
			}
			foreach (Class176 item in arrayList_0)
			{
				for (int i = 0; i < item.arrayList_0.Count; i++)
				{
					bool flag = true;
					if (bool_0 && item.int_0 != i && !item.bar_0.AutoHideTabTextAlwaysVisible)
					{
						flag = false;
					}
					Class175 class2 = item.arrayList_0[i] as Class175;
					if ((int)((Control)autoHidePanel_0).get_Dock() != 3 && (int)((Control)autoHidePanel_0).get_Dock() != 4)
					{
						class2.rectangle_0 = new Rectangle(point.X, point.Y, class2.size_1.Width + 2 + ((flag || class2.size_1.Width == 0) ? class2.size_0.Width : 4), ((Control)autoHidePanel_0).get_Height());
						point.X += class2.rectangle_0.Width + int_0;
					}
					else
					{
						class2.rectangle_0 = new Rectangle(point.X, point.Y, ((Control)autoHidePanel_0).get_Width() - 2, class2.size_1.Width + 2 + ((flag || class2.size_1.Width == 0) ? class2.size_0.Width : 4));
						point.Y += class2.rectangle_0.Height + int_0;
					}
					if (item.int_0 == i)
					{
						arrayList.Add(class2);
					}
					else
					{
						PaintTab(graphics_0, class2, selected: false);
					}
				}
				if ((int)((Control)autoHidePanel_0).get_Dock() != 3 && (int)((Control)autoHidePanel_0).get_Dock() != 4)
				{
					point.X += 2;
				}
				else
				{
					point.Y += 2;
				}
			}
			foreach (Class175 item2 in arrayList)
			{
				PaintTab(graphics_0, item2, selected: true);
			}
		}

		protected virtual void PaintTab(Graphics g, Class175 tab, bool selected)
		{
			GraphicsPath path = method_2(tab);
			TabColors colors = method_1(tab, selected);
			DrawTabItemBackground(tab, path, colors, g);
			DrawTabText(tab, colors, g, selected);
		}

		private TabColors method_1(Class175 class175_0, bool bool_1)
		{
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Invalid comparison between Unknown and I4
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Invalid comparison between Unknown and I4
			TabColors tabColors = new TabColors();
			if (class175_0.dockContainerItem_0 != null && class175_0.dockContainerItem_0.Style == eDotNetBarStyle.Office2007)
			{
				tabColors.BackColor = colorScheme_0.BarBackground;
				tabColors.BackColor2 = colorScheme_0.BarBackground2;
				tabColors.BackColorGradientAngle = colorScheme_0.BarBackgroundGradientAngle;
				tabColors.TextColor = colorScheme_0.ItemText;
				tabColors.BorderColor = colorScheme_0.BarDockedBorder;
				if (autoHidePanel_0 != null && ((int)((Control)autoHidePanel_0).get_Dock() == 3 || (int)((Control)autoHidePanel_0).get_Dock() == 4))
				{
					tabColors.BackColorGradientAngle -= 90;
				}
			}
			else
			{
				tabColors.BackColor = colorScheme_0.DockSiteBackColor;
				tabColors.BackColor2 = colorScheme_0.DockSiteBackColor;
				tabColors.TextColor = SystemColors.ControlText;
				tabColors.BorderColor = SystemColors.ControlDarkDark;
			}
			return tabColors;
		}

		protected virtual void DrawTabItemBackground(Class175 tab, GraphicsPath path, TabColors colors, Graphics g)
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected O, but got Unknown
			RectangleF bounds = path.GetBounds();
			Rectangle r = new Rectangle((int)bounds.X, (int)bounds.Y, (int)bounds.Width, (int)bounds.Height);
			if (colors.BackColor2.IsEmpty)
			{
				if (!colors.BackColor.IsEmpty)
				{
					SolidBrush val = new SolidBrush(colors.BackColor);
					try
					{
						g.FillPath((Brush)(object)val, path);
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
			}
			else
			{
				SolidBrush val2 = new SolidBrush(Color.White);
				try
				{
					g.FillPath((Brush)(object)val2, path);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				LinearGradientBrush val3 = CreateTabGradientBrush(r, colors.BackColor, colors.BackColor2, colors.BackColorGradientAngle);
				try
				{
					g.FillPath((Brush)(object)val3, path);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			if (!colors.BorderColor.IsEmpty)
			{
				Pen val4 = new Pen(colors.BorderColor, 1f);
				try
				{
					g.DrawPath(val4, path);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
		}

		protected virtual void DrawTabText(Class175 tab, TabColors colors, Graphics g, bool selected)
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Invalid comparison between Unknown and I4
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Invalid comparison between Unknown and I4
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Invalid comparison between Unknown and I4
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Invalid comparison between Unknown and I4
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Invalid comparison between Unknown and I4
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Invalid comparison between Unknown and I4
			int num = 12;
			eTextFormat eTextFormat_ = eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.SingleLine | eTextFormat.VerticalCenter;
			Rectangle rectangle_ = tab.rectangle_0;
			Class271 class271_ = tab.Class271_0;
			if (class271_ != null && class271_.Int32_0 + 4 <= rectangle_.Width)
			{
				if ((int)((Control)autoHidePanel_0).get_Dock() != 1 && (int)((Control)autoHidePanel_0).get_Dock() != 2)
				{
					class271_.method_0(g, new Rectangle(rectangle_.X + (rectangle_.Width - class271_.Int32_0) / 2, rectangle_.Y + 3, class271_.Int32_0, class271_.Int32_1));
					int num2 = class271_.Int32_1 + 2;
					rectangle_.Y += num2;
					rectangle_.Height -= num2;
				}
				else
				{
					class271_.method_0(g, new Rectangle(rectangle_.X + 3, rectangle_.Y + (rectangle_.Height - class271_.Int32_1) / 2, class271_.Int32_0, class271_.Int32_1));
					int num3 = class271_.Int32_0 + 2;
					rectangle_.X += num3;
					rectangle_.Width -= num3;
				}
			}
			bool flag = false;
			if (tab.dockContainerItem_0 != null && tab.dockContainerItem_0.ContainerControl is Bar)
			{
				flag = ((Bar)tab.dockContainerItem_0.ContainerControl).AutoHideTabTextAlwaysVisible;
			}
			if (!bool_0 || flag || selected || class271_ == null)
			{
				Font font = ((Control)autoHidePanel_0).get_Font();
				rectangle_.Inflate(-1, -1);
				if ((int)((Control)autoHidePanel_0).get_Dock() == 3 || (int)((Control)autoHidePanel_0).get_Dock() == 4)
				{
					rectangle_.Y += 2;
					g.RotateTransform(90f);
					rectangle_ = new Rectangle(rectangle_.Top, -rectangle_.Right, rectangle_.Height, rectangle_.Width);
				}
				if (rectangle_.Width > num)
				{
					Class55.smethod_2(g, tab.String_0, font, colors.TextColor, rectangle_, eTextFormat_);
				}
				if ((int)((Control)autoHidePanel_0).get_Dock() == 3 || (int)((Control)autoHidePanel_0).get_Dock() == 4)
				{
					g.ResetTransform();
				}
			}
		}

		protected virtual LinearGradientBrush CreateTabGradientBrush(Rectangle r, Color color1, Color color2, int gradientAngle)
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			if (r.Width <= 0)
			{
				r.Width = 1;
			}
			if (r.Height <= 0)
			{
				r.Height = 1;
			}
			return new LinearGradientBrush(new Rectangle(r.X, r.Y - 1, r.Width, r.Height + 1), color1, color2, (float)gradientAngle);
		}

		protected GraphicsPath method_2(Class175 class175_0)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Invalid comparison between Unknown and I4
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Invalid comparison between Unknown and I4
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Invalid comparison between Unknown and I4
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected O, but got Unknown
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Invalid comparison between Unknown and I4
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Expected O, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Invalid comparison between Unknown and I4
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected O, but got Unknown
			Rectangle rectangle = class175_0.rectangle_0;
			if ((int)((Control)autoHidePanel_0).get_Dock() == 3)
			{
				rectangle = new Rectangle(rectangle.X - (rectangle.Height - rectangle.Width), rectangle.Y, rectangle.Height, rectangle.Width);
			}
			else if ((int)((Control)autoHidePanel_0).get_Dock() == 4)
			{
				rectangle = new Rectangle(rectangle.X, rectangle.Y, rectangle.Height, rectangle.Width);
			}
			rectangle.Offset(0, 1);
			GraphicsPath val = new GraphicsPath();
			val.AddLine(rectangle.X, rectangle.Bottom, rectangle.X, rectangle.Y + 2);
			val.AddLine(rectangle.X + 2, rectangle.Y, rectangle.Right - 2, rectangle.Y);
			val.AddLine(rectangle.Right, rectangle.Y + 2, rectangle.Right, rectangle.Bottom);
			val.AddLine(rectangle.Right, rectangle.Bottom, rectangle.X, rectangle.Bottom);
			val.CloseAllFigures();
			if ((int)((Control)autoHidePanel_0).get_Dock() == 1)
			{
				Matrix val2 = new Matrix();
				val2.RotateAt(180f, new PointF(rectangle.X + rectangle.Width / 2, rectangle.Y + rectangle.Height / 2));
				val.Transform(val2);
			}
			else if ((int)((Control)autoHidePanel_0).get_Dock() == 4)
			{
				Matrix val3 = new Matrix();
				val3.RotateAt(-90f, new PointF(rectangle.X, rectangle.Bottom));
				val3.Translate((float)rectangle.Height, (float)(rectangle.Width - rectangle.Height), (MatrixOrder)1);
				val.Transform(val3);
			}
			else if ((int)((Control)autoHidePanel_0).get_Dock() == 3)
			{
				Matrix val4 = new Matrix();
				val4.RotateAt(90f, new PointF(rectangle.Right, rectangle.Bottom));
				val4.Translate((float)(-rectangle.Height), (float)(rectangle.Width - (rectangle.Height - 1)), (MatrixOrder)1);
				val.Transform(val4);
			}
			return val;
		}

		private GraphicsPath method_3(Rectangle rectangle_0)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			GraphicsPath val = new GraphicsPath();
			val.AddLine(rectangle_0.X - int_0, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Y + 5);
			val.AddCurve(new Point[3]
			{
				new Point(rectangle_0.X, rectangle_0.Y + 5),
				new Point(rectangle_0.X + 2, rectangle_0.Y + 2),
				new Point(rectangle_0.X + 5, rectangle_0.Y)
			}, 0.9f);
			return val;
		}

		private GraphicsPath method_4(Rectangle rectangle_0)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			GraphicsPath val = new GraphicsPath();
			val.AddCurve(new Point[3]
			{
				new Point(rectangle_0.Right - 5, rectangle_0.Y),
				new Point(rectangle_0.Right - 2, rectangle_0.Y + 2),
				new Point(rectangle_0.Right, rectangle_0.Y + 5)
			}, 0.9f);
			val.AddLine(rectangle_0.Right, rectangle_0.Y + 5, rectangle_0.Right + int_0, rectangle_0.Bottom);
			return val;
		}
	}

	private class Class175 : IDisposable
	{
		public Rectangle rectangle_0 = new Rectangle(0, 0, 0, 0);

		public DockContainerItem dockContainerItem_0;

		public Size size_0 = Size.Empty;

		public Size size_1 = Size.Empty;

		private string string_0 = "";

		private Class176 class176_0;

		public string String_0
		{
			get
			{
				if (dockContainerItem_0 == null)
				{
					return string_0;
				}
				return dockContainerItem_0.Text;
			}
		}

		public Class271 Class271_0
		{
			get
			{
				if (dockContainerItem_0 == null)
				{
					return null;
				}
				if (dockContainerItem_0.Image != null)
				{
					return new Class271(dockContainerItem_0.Image, dispose: false);
				}
				if (dockContainerItem_0.ImageIndex >= 0 && dockContainerItem_0.ImageList != null)
				{
					return new Class271(dockContainerItem_0.ImageList.get_Images().get_Item(dockContainerItem_0.ImageIndex), dispose: false);
				}
				if (dockContainerItem_0.Icon != null)
				{
					return new Class271(dockContainerItem_0.Icon, dispose: false);
				}
				return null;
			}
		}

		public Class175(Class176 parent, DockContainerItem item)
		{
			dockContainerItem_0 = item;
			class176_0 = parent;
			item.TextChanged += method_0;
			Class271 class271_ = Class271_0;
			if (class271_ != null)
			{
				size_1 = class271_.Size_0;
			}
		}

		public Class175(Class176 parent, string text)
		{
			string_0 = text;
			class176_0 = parent;
		}

		private void method_0(object sender, EventArgs e)
		{
			object containerControl = ((BaseItem)sender).ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				Graphics val2 = Class109.smethod_68(val);
				try
				{
					size_0 = Class55.smethod_7(val2, ((BaseItem)sender).Text, ((Control)class176_0.AutoHidePanel_0).get_Font(), Size.Empty, eTextFormat.Default);
					size_0.Width += 4;
				}
				finally
				{
					val2.Dispose();
				}
				Class271 class271_ = Class271_0;
				if (class271_ != null)
				{
					size_1 = class271_.Size_0;
				}
				else
				{
					size_1 = Size.Empty;
				}
			}
			class176_0.method_1();
		}

		public void Dispose()
		{
			if (dockContainerItem_0 != null)
			{
				dockContainerItem_0.TextChanged -= method_0;
			}
		}
	}

	private class Class176 : IDisposable
	{
		public ArrayList arrayList_0 = new ArrayList(10);

		public int int_0 = -1;

		public Bar bar_0;

		private AutoHidePanel autoHidePanel_0;

		public static int int_1 = 4;

		public static int int_2 = 4;

		public static int int_3 = 3;

		private Size size_0 = Size.Empty;

		private int int_4;

		public AutoHidePanel AutoHidePanel_0 => autoHidePanel_0;

		public Size Size_0 => size_0;

		public int Int32_0 => int_4;

		public Class176(AutoHidePanel parent, Bar bar)
		{
			autoHidePanel_0 = parent;
			bar_0 = bar;
			method_0();
		}

		public void method_0()
		{
			foreach (Class175 item in arrayList_0)
			{
				item.Dispose();
			}
			arrayList_0.Clear();
			Graphics val = Class109.smethod_68((Control)(object)bar_0);
			try
			{
				if (bar_0.LayoutType == eLayoutType.DockContainer)
				{
					foreach (BaseItem item2 in bar_0.Items)
					{
						if (item2 is DockContainerItem dockContainerItem && dockContainerItem.Visible)
						{
							Class175 class2 = new Class175(this, dockContainerItem);
							arrayList_0.Add(class2);
							class2.size_0 = Class55.smethod_7(val, dockContainerItem.Text, ((Control)autoHidePanel_0).get_Font(), Size.Empty, eTextFormat.Default);
							class2.size_0.Width += 4;
						}
					}
				}
				if (arrayList_0.Count == 0)
				{
					Class175 class3 = new Class175(this, ((Control)bar_0).get_Text());
					arrayList_0.Add(class3);
					class3.size_0 = Class55.smethod_7(val, ((Control)bar_0).get_Text(), ((Control)autoHidePanel_0).get_Font(), Size.Empty, eTextFormat.Default);
					class3.size_0.Width += 4;
				}
			}
			finally
			{
				val.Dispose();
			}
			size_0 = method_2();
			if (bar_0.SelectedDockTab >= 0)
			{
				int_0 = bar_0.SelectedDockTab;
			}
			else
			{
				int_0 = 0;
			}
		}

		public void method_1()
		{
			size_0 = method_2();
			((Control)autoHidePanel_0).Refresh();
		}

		public void Dispose()
		{
			foreach (Class175 item in arrayList_0)
			{
				item.Dispose();
			}
			arrayList_0.Clear();
			bar_0 = null;
			autoHidePanel_0 = null;
		}

		private Size method_2()
		{
			Size result = Size.Empty;
			Size empty = Size.Empty;
			bool flag = true;
			foreach (Class175 item in arrayList_0)
			{
				if (!item.size_1.IsEmpty)
				{
					if (flag)
					{
						result.Width += item.size_1.Width + int_1 * 2;
						result.Height = item.size_1.Height + int_3 * 2;
					}
					else
					{
						result.Height += item.size_1.Height + int_1 * 2;
						result.Width = item.size_1.Width + int_3 * 2;
					}
				}
				if (flag)
				{
					if (item.size_0.Width > empty.Width)
					{
						empty.Width = item.size_0.Width;
					}
					if (item.size_0.Height > empty.Height)
					{
						empty.Height = item.size_0.Height;
					}
				}
				else
				{
					if (item.size_0.Width > empty.Height)
					{
						empty.Height = item.size_0.Width;
					}
					if (item.size_0.Height > empty.Width)
					{
						empty.Width = item.size_0.Height;
					}
				}
			}
			if (flag)
			{
				int_4 = empty.Width;
				empty.Width += int_1;
				empty.Height += int_2 * 2;
				result = new Size(result.Width + empty.Width, (result.Height > empty.Height) ? result.Height : empty.Height);
			}
			else
			{
				int_4 = empty.Height;
				empty.Height += int_1;
				empty.Width += int_2 * 2;
				result = new Size((result.Width > empty.Height) ? result.Width : empty.Height, result.Height + empty.Width);
			}
			return result;
		}
	}

	private ArrayList arrayList_0 = new ArrayList(10);

	private Timer timer_0;

	private eDotNetBarStyle eDotNetBarStyle_0;

	private bool bool_0 = true;

	private bool bool_1 = true;

	private int int_0 = 800;

	private ColorScheme colorScheme_0;

	private DotNetBarManager dotNetBarManager_0;

	private bool bool_2;

	[Browsable(true)]
	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[DefaultValue(false)]
	[Category("Appearance")]
	public bool AntiAlias
	{
		get
		{
			return bool_2;
		}
		set
		{
			if (bool_2 != value)
			{
				bool_2 = value;
				((Control)this).Invalidate();
			}
		}
	}

	private bool Boolean_0
	{
		get
		{
			if (eDotNetBarStyle_0 != eDotNetBarStyle.Office2003 && eDotNetBarStyle_0 != eDotNetBarStyle.VS2005 && !Class109.smethod_69(eDotNetBarStyle_0))
			{
				return false;
			}
			return true;
		}
	}

	[DefaultValue(800)]
	[Category("Behavior")]
	[Description("Indicates timeout in milliseconds for auto hide/show action.")]
	public int AutoHideShowTimeout
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	internal DockContainerItem DockContainerItem_0
	{
		get
		{
			Class176 class176_ = Class176_0;
			if (class176_ == null)
			{
				foreach (Class176 item in arrayList_0)
				{
					for (int i = 0; i < item.arrayList_0.Count; i++)
					{
						Class175 class2 = item.arrayList_0[i] as Class175;
						if (item.int_0 == i)
						{
							return class2.dockContainerItem_0;
						}
					}
				}
				return null;
			}
			try
			{
				Class175 class3 = class176_.arrayList_0[class176_.int_0] as Class175;
				return class3.dockContainerItem_0;
			}
			catch
			{
				return null;
			}
		}
		set
		{
			foreach (Class176 item in arrayList_0)
			{
				foreach (Class175 item2 in item.arrayList_0)
				{
					if (item2.dockContainerItem_0 != value)
					{
						continue;
					}
					Class176 class176_ = Class176_0;
					if (class176_ != null)
					{
						if (class176_ != item)
						{
							if (class176_.bar_0.Boolean_7)
							{
								return;
							}
							method_9(class176_.bar_0);
						}
						else
						{
							if (item.arrayList_0[item.int_0] == item2 && item.bar_0.Visible)
							{
								return;
							}
							((Class175)class176_.arrayList_0[class176_.int_0]).dockContainerItem_0.Displayed = false;
						}
					}
					item.int_0 = item.arrayList_0.IndexOf(item2);
					((Control)this).Refresh();
					return;
				}
			}
		}
	}

	[Description("Indicates whether bars on auto-hide panel are displayed when mouse hovers over the tab.")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool EnableHoverExpand
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

	[Description("Indicates whether bars that have focus are collapsed automatically or not.")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool EnableFocusCollapse
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	private Class176 Class176_0
	{
		get
		{
			foreach (Class176 item in arrayList_0)
			{
				if (item.int_0 >= 0 && item.bar_0.Visible)
				{
					return item;
				}
			}
			return null;
		}
	}

	public eDotNetBarStyle Style
	{
		get
		{
			return eDotNetBarStyle_0;
		}
		set
		{
			eDotNetBarStyle_0 = value;
			((Control)this).Refresh();
		}
	}

	[DefaultValue(null)]
	[Browsable(false)]
	public ColorScheme ColorScheme
	{
		get
		{
			return colorScheme_0;
		}
		set
		{
			colorScheme_0 = value;
		}
	}

	public AutoHidePanel()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		_003F val = this;
		object obj = SystemInformation.get_MenuFont().Clone();
		((Control)val).set_Font((Font)((obj is Font) ? obj : null));
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			method_4();
			foreach (Class176 item in arrayList_0)
			{
				item.Dispose();
			}
			arrayList_0.Clear();
		}
		((Control)this).Dispose(disposing);
	}

	internal void method_0(DotNetBarManager dotNetBarManager_1)
	{
		dotNetBarManager_0 = dotNetBarManager_1;
	}

	protected override void OnPaint(PaintEventArgs p)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Invalid comparison between Unknown and I4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Invalid comparison between Unknown and I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Invalid comparison between Unknown and I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Invalid comparison between Unknown and I4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Invalid comparison between Unknown and I4
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Invalid comparison between Unknown and I4
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Invalid comparison between Unknown and I4
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Invalid comparison between Unknown and I4
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Invalid comparison between Unknown and I4
		//IL_0a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Invalid comparison between Unknown and I4
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Invalid comparison between Unknown and I4
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b84: Invalid comparison between Unknown and I4
		//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be6: Invalid comparison between Unknown and I4
		//IL_0e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1a: Invalid comparison between Unknown and I4
		//IL_0fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe3: Invalid comparison between Unknown and I4
		//IL_104f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1055: Invalid comparison between Unknown and I4
		//IL_10e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1126: Unknown result type (might be due to invalid IL or missing references)
		eTextFormat eTextFormat_ = eTextFormat.SingleLine | eTextFormat.VerticalCenter;
		Graphics graphics = p.get_Graphics();
		ColorScheme colorScheme = null;
		TextRenderingHint textRenderingHint = graphics.get_TextRenderingHint();
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		if (bool_2)
		{
			graphics.set_TextRenderingHint(BarUtilities.AntiAliasTextRenderingHint);
			graphics.set_SmoothingMode((SmoothingMode)4);
		}
		if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007 && colorScheme_0 == null && GlobalManager.Renderer is Office2007Renderer)
		{
			colorScheme = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.LegacyColors;
		}
		else if (dotNetBarManager_0 != null && dotNetBarManager_0.UseGlobalColorScheme)
		{
			colorScheme = dotNetBarManager_0.ColorScheme;
		}
		else if (colorScheme_0 != null)
		{
			colorScheme = colorScheme_0;
		}
		else if (Boolean_0)
		{
			colorScheme = new ColorScheme(eDotNetBarStyle_0);
		}
		if (Boolean_0)
		{
			Class50.smethod_26(graphics, ((Control)this).get_ClientRectangle(), colorScheme.BarBackground, colorScheme.BarBackground2, colorScheme.BarBackgroundGradientAngle);
		}
		else
		{
			SolidBrush val = new SolidBrush(ControlPaint.Light(((Control)this).get_BackColor()));
			try
			{
				graphics.FillRectangle((Brush)(object)val, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		bool flag = Class109.smethod_69(eDotNetBarStyle_0);
		if (eDotNetBarStyle_0 != eDotNetBarStyle.VS2005 && !flag)
		{
			int num = ((Control)this).get_Width() - 2;
			int num2 = ((Control)this).get_Height() - 2;
			Color empty = Color.Empty;
			SolidBrush val2 = null;
			Pen val3 = null;
			if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2003)
			{
				empty = colorScheme.ItemText;
				val3 = new Pen(colorScheme.ItemHotBorder, 1f);
			}
			else if (eDotNetBarStyle_0 != eDotNetBarStyle.VS2005 && !Class109.smethod_69(eDotNetBarStyle_0))
			{
				empty = graphics.GetNearestColor(ControlPaint.DarkDark(((Control)this).get_BackColor()));
				val2 = new SolidBrush(((Control)this).get_BackColor());
				val3 = new Pen(graphics.GetNearestColor(ControlPaint.Dark(((Control)this).get_BackColor())), 1f);
			}
			else
			{
				empty = colorScheme.ItemText;
				val3 = new Pen(colorScheme.MenuBorder, 1f);
			}
			if ((int)((Control)this).get_Dock() != 1 && (int)((Control)this).get_Dock() != 2 && (int)((Control)this).get_Dock() != 0)
			{
				if ((int)((Control)this).get_Dock() == 3 || (int)((Control)this).get_Dock() == 4)
				{
					int num3 = 2;
					foreach (Class176 item in arrayList_0)
					{
						for (int i = 0; i < item.arrayList_0.Count; i++)
						{
							Class175 class2 = item.arrayList_0[i] as Class175;
							Class271 class271_ = class2.Class271_0;
							class2.rectangle_0.X = 0;
							class2.rectangle_0.Y = num3;
							class2.rectangle_0.Width = num;
							num3 += Class176.int_1;
							if (item.int_0 != i && !item.bar_0.AutoHideTabTextAlwaysVisible)
							{
								if (class271_ != null)
								{
									if ((int)((Control)this).get_Dock() == 3)
									{
										if (val2 != null)
										{
											graphics.FillRectangle((Brush)(object)val2, class2.rectangle_0.X, class2.rectangle_0.Y, num, class271_.Int32_1 + Class176.int_1 * 2);
										}
										class271_.method_0(graphics, new Rectangle((num - class271_.Int32_0 - 2) / 2, num3, class271_.Int32_0, class271_.Int32_1));
									}
									else
									{
										if (val2 != null)
										{
											graphics.FillRectangle((Brush)(object)val2, 2, class2.rectangle_0.Y, num, class271_.Int32_1 + Class176.int_1 * 2);
										}
										class271_.method_0(graphics, new Rectangle((num - class271_.Int32_0 + 2) / 2, num3, class271_.Int32_0, class271_.Int32_1));
									}
									num3 += class271_.Int32_1 + Class176.int_1;
								}
								else
								{
									graphics.RotateTransform(90f);
									Class55.smethod_2(graphics, class2.String_0, ((Control)this).get_Font(), empty, new Rectangle(num3, -num, class2.size_0.Width, num), eTextFormat_);
									graphics.ResetTransform();
									num3 += class2.size_0.Width + Class176.int_1;
								}
								class2.rectangle_0.Height = num3 - class2.rectangle_0.Y;
								if ((int)((Control)this).get_Dock() == 3)
								{
									class2.rectangle_0.X--;
								}
								else
								{
									class2.rectangle_0.X++;
								}
								graphics.DrawRectangle(val3, class2.rectangle_0);
							}
							else
							{
								if (class271_ != null)
								{
									if ((int)((Control)this).get_Dock() == 3)
									{
										if ((eDotNetBarStyle_0 == eDotNetBarStyle.Office2003 || eDotNetBarStyle_0 == eDotNetBarStyle.VS2005) && !colorScheme.ItemPressedBackground2.IsEmpty)
										{
											LinearGradientBrush val4 = Class109.smethod_40(new Rectangle(class2.rectangle_0.X, class2.rectangle_0.Y, num, class271_.Int32_1 + item.Int32_0 + Class176.int_1 * 3), colorScheme.ItemPressedBackground, colorScheme.ItemPressedBackground2, colorScheme.ItemPressedBackgroundGradientAngle);
											try
											{
												graphics.FillRectangle((Brush)(object)val4, class2.rectangle_0.X, class2.rectangle_0.Y, num, class271_.Int32_1 + item.Int32_0 + Class176.int_1 * 3);
											}
											finally
											{
												((IDisposable)val4)?.Dispose();
											}
										}
										else if (val2 != null)
										{
											graphics.FillRectangle((Brush)(object)val2, class2.rectangle_0.X, class2.rectangle_0.Y, num, class271_.Int32_1 + item.Int32_0 + Class176.int_1 * 3);
										}
										class271_.method_0(graphics, new Rectangle((num - class271_.Int32_0 - 2) / 2, num3, class271_.Int32_0, class271_.Int32_1));
									}
									else
									{
										if ((eDotNetBarStyle_0 == eDotNetBarStyle.Office2003 || eDotNetBarStyle_0 == eDotNetBarStyle.VS2005) && !colorScheme.ItemPressedBackground2.IsEmpty)
										{
											LinearGradientBrush val5 = Class109.smethod_40(new Rectangle(2, class2.rectangle_0.Y, num, class271_.Int32_1 + item.Int32_0 + Class176.int_1 * 3), colorScheme.ItemPressedBackground, colorScheme.ItemPressedBackground2, colorScheme.ItemPressedBackgroundGradientAngle);
											try
											{
												graphics.FillRectangle((Brush)(object)val5, 2, class2.rectangle_0.Y, num, class271_.Int32_1 + item.Int32_0 + Class176.int_1 * 3);
											}
											finally
											{
												((IDisposable)val5)?.Dispose();
											}
										}
										else if (val2 != null)
										{
											graphics.FillRectangle((Brush)(object)val2, 2, class2.rectangle_0.Y, num, class271_.Int32_1 + item.Int32_0 + Class176.int_1 * 3);
										}
										class271_.method_0(graphics, new Rectangle((num - class271_.Int32_0 + 2) / 2, num3, class271_.Int32_0, class271_.Int32_1));
									}
									num3 += class271_.Int32_1 + Class176.int_1;
								}
								else if ((int)((Control)this).get_Dock() == 3)
								{
									if ((eDotNetBarStyle_0 == eDotNetBarStyle.Office2003 || eDotNetBarStyle_0 == eDotNetBarStyle.VS2005) && !colorScheme.ItemPressedBackground2.IsEmpty)
									{
										LinearGradientBrush val6 = Class109.smethod_40(new Rectangle(class2.rectangle_0.X, class2.rectangle_0.Y, num, class2.size_0.Width + Class176.int_1 * 2), colorScheme.ItemPressedBackground, colorScheme.ItemPressedBackground2, colorScheme.ItemPressedBackgroundGradientAngle);
										try
										{
											graphics.FillRectangle((Brush)(object)val6, class2.rectangle_0.X, class2.rectangle_0.Y, num, class2.size_0.Width + Class176.int_1 * 2);
										}
										finally
										{
											((IDisposable)val6)?.Dispose();
										}
									}
									else if (val2 != null)
									{
										graphics.FillRectangle((Brush)(object)val2, class2.rectangle_0.X, class2.rectangle_0.Y, num, class2.size_0.Width + Class176.int_1 * 2);
									}
								}
								else if ((eDotNetBarStyle_0 == eDotNetBarStyle.Office2003 || eDotNetBarStyle_0 == eDotNetBarStyle.VS2005) && !colorScheme.ItemPressedBackground2.IsEmpty)
								{
									LinearGradientBrush val7 = Class109.smethod_40(new Rectangle(2, class2.rectangle_0.Y, num, class2.size_0.Width + Class176.int_1 * 2), colorScheme.ItemPressedBackground, colorScheme.ItemPressedBackground2, colorScheme.ItemPressedBackgroundGradientAngle);
									try
									{
										graphics.FillRectangle((Brush)(object)val7, 2, class2.rectangle_0.Y, num, class2.size_0.Width + Class176.int_1 * 2);
									}
									finally
									{
										((IDisposable)val7)?.Dispose();
									}
								}
								else if (val2 != null)
								{
									graphics.FillRectangle((Brush)(object)val2, 2, class2.rectangle_0.Y, num, class2.size_0.Width + Class176.int_1 * 2);
								}
								graphics.RotateTransform(90f);
								Class55.smethod_2(graphics, class2.String_0, ((Control)this).get_Font(), empty, new Rectangle(num3, -num, (class271_ == null) ? class2.size_0.Width : item.Int32_0, num), eTextFormat_);
								graphics.ResetTransform();
								num3 += ((class271_ == null) ? class2.size_0.Width : item.Int32_0) + Class176.int_1;
								if ((int)((Control)this).get_Dock() == 3)
								{
									class2.rectangle_0.Offset(-1, 0);
								}
								else
								{
									class2.rectangle_0.Offset(1, 0);
								}
								class2.rectangle_0.Height = num3 - class2.rectangle_0.Y;
								graphics.DrawRectangle(val3, class2.rectangle_0);
							}
							if (num3 > ((Control)this).get_Height())
							{
								break;
							}
						}
						num3 += 4;
						if (num3 > ((Control)this).get_Height())
						{
							break;
						}
					}
				}
			}
			else
			{
				int num4 = 2;
				foreach (Class176 item2 in arrayList_0)
				{
					for (int j = 0; j < item2.arrayList_0.Count; j++)
					{
						Class175 class4 = item2.arrayList_0[j] as Class175;
						Class271 class271_2 = class4.Class271_0;
						class4.rectangle_0.X = num4;
						class4.rectangle_0.Y = 0;
						class4.rectangle_0.Height = num2;
						num4 += Class176.int_1;
						if (item2.int_0 != j && !item2.bar_0.AutoHideTabTextAlwaysVisible)
						{
							if (class271_2 != null)
							{
								if ((int)((Control)this).get_Dock() == 1)
								{
									if (val2 != null)
									{
										graphics.FillRectangle((Brush)(object)val2, class4.rectangle_0.X, 0, class271_2.Int32_0 + Class176.int_1 * 2, num2);
									}
									class271_2.method_0(graphics, new Rectangle(num4, (num2 - class271_2.Int32_1) / 2, class271_2.Int32_0, class271_2.Int32_1));
								}
								else
								{
									if (val2 != null)
									{
										graphics.FillRectangle((Brush)(object)val2, class4.rectangle_0.X, 2, class271_2.Int32_0 + Class176.int_1 * 2, num2);
									}
									class271_2.method_0(graphics, new Rectangle(num4, (num2 - class271_2.Int32_1) / 2 + 2, class271_2.Int32_0, class271_2.Int32_1));
								}
								num4 += class271_2.Int32_0 + Class176.int_1;
							}
							else
							{
								Class55.smethod_2(graphics, class4.String_0, ((Control)this).get_Font(), empty, new Rectangle(num4, ((int)((Control)this).get_Dock() != 1) ? 2 : 0, class4.size_0.Width, num2), eTextFormat_);
								num4 += class4.size_0.Width + Class176.int_1;
							}
							class4.rectangle_0.Width = num4 - class4.rectangle_0.X;
							if ((int)((Control)this).get_Dock() == 1)
							{
								class4.rectangle_0.Y--;
							}
							else
							{
								class4.rectangle_0.Y++;
								class4.rectangle_0.Height += 2;
							}
							graphics.DrawRectangle(val3, class4.rectangle_0);
						}
						else
						{
							if (class271_2 != null)
							{
								if ((int)((Control)this).get_Dock() == 1)
								{
									if ((eDotNetBarStyle_0 == eDotNetBarStyle.Office2003 || eDotNetBarStyle_0 == eDotNetBarStyle.VS2005) && !colorScheme.ItemPressedBackground2.IsEmpty)
									{
										LinearGradientBrush val8 = Class109.smethod_40(new Rectangle(class4.rectangle_0.X, 0, class271_2.Int32_0 + item2.Int32_0 + Class176.int_1 * 3, num2), colorScheme.ItemPressedBackground, colorScheme.ItemPressedBackground2, colorScheme.ItemPressedBackgroundGradientAngle);
										try
										{
											graphics.FillRectangle((Brush)(object)val8, class4.rectangle_0.X, 0, class271_2.Int32_0 + item2.Int32_0 + Class176.int_1 * 3, num2);
										}
										finally
										{
											((IDisposable)val8)?.Dispose();
										}
									}
									else if (val2 != null)
									{
										graphics.FillRectangle((Brush)(object)val2, class4.rectangle_0.X, 0, class271_2.Int32_0 + item2.Int32_0 + Class176.int_1 * 3, num2);
									}
									class271_2.method_0(graphics, new Rectangle(num4, (num2 - class271_2.Int32_1) / 2, class271_2.Int32_0, class271_2.Int32_1));
								}
								else
								{
									if ((eDotNetBarStyle_0 == eDotNetBarStyle.Office2003 || eDotNetBarStyle_0 == eDotNetBarStyle.VS2005) && !colorScheme.ItemPressedBackground2.IsEmpty)
									{
										LinearGradientBrush val9 = Class109.smethod_40(new Rectangle(class4.rectangle_0.X, 2, class271_2.Int32_0 + item2.Int32_0 + Class176.int_1 * 3, num2), colorScheme.ItemPressedBackground, colorScheme.ItemPressedBackground2, colorScheme.ItemPressedBackgroundGradientAngle);
										try
										{
											graphics.FillRectangle((Brush)(object)val9, class4.rectangle_0.X, 2, class271_2.Int32_0 + item2.Int32_0 + Class176.int_1 * 3, num2);
										}
										finally
										{
											((IDisposable)val9)?.Dispose();
										}
									}
									else if (val2 != null)
									{
										graphics.FillRectangle((Brush)(object)val2, class4.rectangle_0.X, 2, class271_2.Int32_0 + item2.Int32_0 + Class176.int_1 * 3, num2);
									}
									class271_2.method_0(graphics, new Rectangle(num4, (num2 - class271_2.Int32_1) / 2 + 2, class271_2.Int32_0, class271_2.Int32_1));
								}
								num4 += class271_2.Int32_0 + Class176.int_1;
							}
							else if ((int)((Control)this).get_Dock() == 1)
							{
								if ((eDotNetBarStyle_0 == eDotNetBarStyle.Office2003 || eDotNetBarStyle_0 == eDotNetBarStyle.VS2005) && !colorScheme.ItemPressedBackground2.IsEmpty)
								{
									LinearGradientBrush val10 = Class109.smethod_40(new Rectangle(class4.rectangle_0.X, 0, class4.size_0.Width + Class176.int_1 * 2, num2), colorScheme.ItemPressedBackground, colorScheme.ItemPressedBackground2, colorScheme.ItemPressedBackgroundGradientAngle);
									try
									{
										graphics.FillRectangle((Brush)(object)val10, class4.rectangle_0.X, 0, class4.size_0.Width + Class176.int_1 * 2, num2);
									}
									finally
									{
										((IDisposable)val10)?.Dispose();
									}
								}
								else if (val2 != null)
								{
									graphics.FillRectangle((Brush)(object)val2, class4.rectangle_0.X, 0, class4.size_0.Width + Class176.int_1 * 2, num2);
								}
							}
							else if ((eDotNetBarStyle_0 == eDotNetBarStyle.Office2003 || eDotNetBarStyle_0 == eDotNetBarStyle.VS2005) && !colorScheme.ItemPressedBackground2.IsEmpty)
							{
								LinearGradientBrush val11 = Class109.smethod_40(new Rectangle(class4.rectangle_0.X, 2, class4.size_0.Width + Class176.int_1 * 2, num2), colorScheme.ItemPressedBackground, colorScheme.ItemPressedBackground2, colorScheme.ItemPressedBackgroundGradientAngle);
								try
								{
									graphics.FillRectangle((Brush)(object)val11, class4.rectangle_0.X, 2, class4.size_0.Width + Class176.int_1 * 2, num2);
								}
								finally
								{
									((IDisposable)val11)?.Dispose();
								}
							}
							else if (val2 != null)
							{
								graphics.FillRectangle((Brush)(object)val2, class4.rectangle_0.X, 2, class4.size_0.Width + Class176.int_1 * 2, num2);
							}
							Class55.smethod_2(graphics, class4.String_0, ((Control)this).get_Font(), empty, new Rectangle(num4, ((int)((Control)this).get_Dock() != 1) ? 2 : 0, (class271_2 == null) ? class4.size_0.Width : item2.Int32_0, num2), eTextFormat_);
							num4 += ((class271_2 == null) ? class4.size_0.Width : item2.Int32_0) + Class176.int_1;
							class4.rectangle_0.Width = num4 - class4.rectangle_0.X;
							if ((int)((Control)this).get_Dock() == 1)
							{
								class4.rectangle_0.Offset(0, -1);
							}
							else
							{
								class4.rectangle_0.Offset(0, 1);
								class4.rectangle_0.Height += 2;
							}
							graphics.DrawRectangle(val3, class4.rectangle_0);
						}
						if (num4 > ((Control)this).get_Width())
						{
							break;
						}
					}
					num4 += 4;
					if (num4 > ((Control)this).get_Width())
					{
						break;
					}
				}
			}
			val3.Dispose();
			if (bool_2)
			{
				graphics.set_TextRenderingHint(textRenderingHint);
				graphics.set_SmoothingMode(smoothingMode);
			}
		}
		else
		{
			Class174 class5 = new Class174(this, colorScheme);
			class5.Boolean_0 = flag;
			class5.method_0(graphics, arrayList_0);
			if (bool_2)
			{
				graphics.set_TextRenderingHint(textRenderingHint);
				graphics.set_SmoothingMode(smoothingMode);
			}
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		method_1();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		if (timer_0 != null)
		{
			timer_0.set_Interval(int_0);
		}
	}

	private void method_1()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (timer_0 != null)
		{
			timer_0.Start();
			return;
		}
		timer_0 = new Timer();
		timer_0.set_Interval(int_0);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_0.Start();
	}

	internal void method_2()
	{
		if (timer_0 != null)
		{
			timer_0.Stop();
		}
	}

	internal void method_3()
	{
		if (timer_0 != null)
		{
			timer_0.Start();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		Point pt = ((Control)this).PointToClient(Control.get_MousePosition());
		if (((Control)this).get_ClientRectangle().Contains(pt))
		{
			IntPtr activeWindow = Class92.GetActiveWindow();
			Form val = ((Control)this).FindForm();
			if (val != null && ((Control)val).get_Handle() != activeWindow)
			{
				Control val2 = (Control)(object)val;
				bool flag = true;
				while (val2.get_Parent() != null)
				{
					val2 = val2.get_Parent();
					if (val2.get_Handle() == activeWindow)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					return;
				}
			}
			if (bool_0)
			{
				SelectPanel(pt.X, pt.Y);
			}
			return;
		}
		Class176 class176_ = Class176_0;
		if (class176_ != null && !class176_.bar_0.Boolean_7 && class176_.bar_0.Visible && (bool_1 || !method_5(class176_.bar_0)))
		{
			pt = ((Control)class176_.bar_0).PointToClient(Control.get_MousePosition());
			if (!((Control)class176_.bar_0).get_ClientRectangle().Contains(pt))
			{
				method_9(class176_.bar_0);
				method_4();
			}
		}
	}

	private void method_4()
	{
		if (timer_0 != null)
		{
			timer_0.Stop();
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
	}

	private bool method_5(Bar bar_0)
	{
		if (bar_0 == null)
		{
			return false;
		}
		Form val = ((Control)this).FindForm();
		if (val == null)
		{
			return false;
		}
		Control val2 = ((ContainerControl)val).get_ActiveControl();
		if (val2 == null)
		{
			return false;
		}
		while (true)
		{
			if (val2 != null)
			{
				if (bar_0 == val2)
				{
					break;
				}
				val2 = val2.get_Parent();
				continue;
			}
			return false;
		}
		return true;
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		if ((int)e.get_Button() == 1048576)
		{
			SelectPanel(e.get_X(), e.get_Y());
		}
	}

	public void SelectPanel(int x, int y)
	{
		foreach (Class176 item in arrayList_0)
		{
			foreach (Class175 item2 in item.arrayList_0)
			{
				if (!item2.rectangle_0.Contains(x, y))
				{
					continue;
				}
				Class176 class176_ = Class176_0;
				if (class176_ != null)
				{
					if (class176_ != item)
					{
						if (class176_.bar_0.Boolean_7)
						{
							return;
						}
						method_9(class176_.bar_0);
					}
					else if (item.int_0 < item.arrayList_0.Count)
					{
						if (item.arrayList_0[item.int_0] == item2 && item.bar_0.Visible)
						{
							return;
						}
						((Class175)class176_.arrayList_0[class176_.int_0]).dockContainerItem_0.Displayed = false;
					}
				}
				if (item.bar_0.VisibleItemCount == 0)
				{
					throw new InvalidOperationException("Bar.Items collection must contain at least one visible DockContainerItem object so auto-hide functionality can function properly.");
				}
				item.int_0 = item.arrayList_0.IndexOf(item2);
				if (!((Control)item.bar_0).get_IsDisposed())
				{
					item.bar_0.SelectedDockTab = item.bar_0.Items.IndexOf(item2.dockContainerItem_0);
					method_10(item.bar_0);
					((Control)this).Refresh();
				}
				return;
			}
		}
	}

	public DockContainerItem HitTest(int x, int y)
	{
		foreach (Class176 item in arrayList_0)
		{
			foreach (Class175 item2 in item.arrayList_0)
			{
				if (item2.rectangle_0.Contains(x, y))
				{
					return item2.dockContainerItem_0;
				}
			}
		}
		return null;
	}

	protected override void OnFontChanged(EventArgs e)
	{
		((Control)this).OnFontChanged(e);
		method_6();
	}

	protected override void OnSystemColorsChanged(EventArgs e)
	{
		((Control)this).OnSystemColorsChanged(e);
		Application.DoEvents();
		_003F val = this;
		object obj = SystemInformation.get_MenuFont().Clone();
		((Control)val).set_Font((Font)((obj is Font) ? obj : null));
	}

	private void method_6()
	{
		foreach (Class176 item in arrayList_0)
		{
			item.method_0();
		}
		((Control)this).Invalidate();
	}

	internal void method_7(Bar bar_0)
	{
		Class176 @class = null;
		foreach (Class176 item in arrayList_0)
		{
			if (item.bar_0 == bar_0)
			{
				@class = item;
				break;
			}
		}
		Class176 class176_ = Class176_0;
		if (class176_ == @class)
		{
			return;
		}
		if (class176_ != null)
		{
			if (class176_.bar_0.Boolean_7)
			{
				return;
			}
			method_9(class176_.bar_0);
		}
		@class.bar_0.SelectedDockTab = @class.int_0;
		method_10(@class.bar_0);
		((Control)this).Refresh();
		method_1();
	}

	internal void method_8(Bar bar_0)
	{
		Class176 class176_ = Class176_0;
		if (class176_.bar_0 == bar_0 && class176_.bar_0.Visible)
		{
			method_9(class176_.bar_0);
			method_4();
		}
	}

	private void method_9(Bar bar_0)
	{
		bar_0.method_105();
	}

	private void method_10(Bar bar_0)
	{
		if (((Control)bar_0).get_Enabled())
		{
			bar_0.method_104();
		}
	}

	public void SetBarPosition(Bar bar, int iIndex)
	{
		if (iIndex >= arrayList_0.Count)
		{
			return;
		}
		int num = 0;
		while (true)
		{
			if (num < arrayList_0.Count)
			{
				if (((Class176)arrayList_0[num]).bar_0 == bar)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		if (num != iIndex)
		{
			Class176 value = (Class176)arrayList_0[num];
			arrayList_0.RemoveAt(num);
			arrayList_0.Insert(iIndex, value);
			((Control)this).Refresh();
		}
	}

	public void AddBar(Bar bar)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		if (bar.Style == eDotNetBarStyle.Office2003)
		{
			eDotNetBarStyle_0 = eDotNetBarStyle.Office2003;
		}
		else if (bar.Style == eDotNetBarStyle.VS2005)
		{
			eDotNetBarStyle_0 = eDotNetBarStyle.VS2005;
		}
		else if (bar.Style == eDotNetBarStyle.Office2007)
		{
			eDotNetBarStyle_0 = eDotNetBarStyle.Office2007;
		}
		else
		{
			eDotNetBarStyle_0 = eDotNetBarStyle.OfficeXP;
		}
		Class176 @class = new Class176(this, bar);
		arrayList_0.Add(@class);
		if ((int)((Control)this).get_Dock() != 4 && (int)((Control)this).get_Dock() != 3)
		{
			if (@class.Size_0.Height > ((Control)this).get_Height())
			{
				((Control)this).set_Height(@class.Size_0.Height);
			}
		}
		else if (@class.Size_0.Height > ((Control)this).get_Width())
		{
			((Control)this).set_Width(@class.Size_0.Height);
		}
		if (!((Control)this).get_Visible())
		{
			Class109.smethod_4((Control)(object)this, bool_3: true);
		}
		else
		{
			((Control)this).Refresh();
		}
		((Control)this).get_Parent().PerformLayout();
		((Control)this).get_Parent().Update();
	}

	public void RemoveBar(Bar bar)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		foreach (Class176 item in arrayList_0)
		{
			if (item.bar_0 != bar)
			{
				continue;
			}
			arrayList_0.Remove(item);
			item.Dispose();
			if (arrayList_0.Count == 0)
			{
				((Control)this).set_Visible(false);
				if ((int)((Control)this).get_Dock() != 4 && (int)((Control)this).get_Dock() != 3)
				{
					((Control)this).set_Height(0);
				}
				else
				{
					((Control)this).set_Width(0);
				}
			}
			else
			{
				((Control)this).Refresh();
			}
			break;
		}
		if (arrayList_0.Count == 0)
		{
			method_4();
		}
	}

	public void RefreshBar(Bar bar)
	{
		foreach (Class176 item in arrayList_0)
		{
			if (item.bar_0 == bar)
			{
				item.method_0();
				break;
			}
		}
		((Control)this).Refresh();
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		((Control)this).OnHandleDestroyed(e);
		method_4();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Class176 class176_ = Class176_0;
		if (class176_ != null && class176_.bar_0.Visible)
		{
			class176_.bar_0.method_103();
		}
	}
}
