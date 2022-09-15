using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.TextMarkup;
using DevComponents.Editors;

namespace DevComponents.DotNetBar.Controls;

[ToolboxItem(true)]
[Designer(typeof(ComboBoxExDesigner))]
[ToolboxBitmap(typeof(ComboBoxEx), "Controls.ComboBoxEx.ico")]
public class ComboBoxEx : ComboBox, ICommandSource
{
	private class Class193
	{
		public Color color_0 = SystemColors.Window;

		public Color color_1 = SystemColors.Window;

		public LinearGradientColorTable linearGradientColorTable_0;

		public Color color_2 = SystemColors.ControlText;

		public LinearGradientColorTable linearGradientColorTable_1;

		public LinearGradientColorTable linearGradientColorTable_2;
	}

	private class Class194 : NativeWindow
	{
		private struct Struct12
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;
		}

		private const int int_0 = 675;

		private const int int_1 = 512;

		private const int int_2 = 2;

		private EventHandler eventHandler_0;

		private PaintEventHandler paintEventHandler_0;

		private bool bool_0;

		public event EventHandler Event_0
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
			}
		}

		public event PaintEventHandler Event_1
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0017: Expected O, but got Unknown
				paintEventHandler_0 = (PaintEventHandler)Delegate.Combine((Delegate?)(object)paintEventHandler_0, (Delegate?)(object)value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0017: Expected O, but got Unknown
				paintEventHandler_0 = (PaintEventHandler)Delegate.Remove((Delegate?)(object)paintEventHandler_0, (Delegate?)(object)value);
			}
		}

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool TrackMouseEvent(ref Struct12 lpEventTrack);

		protected override void WndProc(ref Message m)
		{
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected O, but got Unknown
			if (((Message)(ref m)).get_Msg() == 512 && !bool_0)
			{
				bool_0 = true;
				Struct12 lpEventTrack = default(Struct12);
				lpEventTrack.int_1 = 2;
				lpEventTrack.int_0 = Marshal.SizeOf((object)lpEventTrack);
				lpEventTrack.int_2 = ((NativeWindow)this).get_Handle().ToInt32();
				lpEventTrack.int_3 = 0;
				bool_0 = TrackMouseEvent(ref lpEventTrack);
			}
			else if (((Message)(ref m)).get_Msg() == 675)
			{
				if (eventHandler_0 != null)
				{
					eventHandler_0(this, new EventArgs());
				}
				bool_0 = false;
			}
			else if (((Message)(ref m)).get_Msg() == 15)
			{
				((NativeWindow)this).WndProc(ref m);
				if (paintEventHandler_0 != null)
				{
					Graphics val = Graphics.FromHwnd(((Message)(ref m)).get_HWnd());
					try
					{
						paintEventHandler_0.Invoke((object)this, new PaintEventArgs(val, Rectangle.Empty));
						return;
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
				return;
			}
			((NativeWindow)this).WndProc(ref m);
		}
	}

	public delegate void OnDropDownChangeEventHandler(object sender, bool Expanded);

	private const uint uint_0 = 5u;

	private OnDropDownChangeEventHandler onDropDownChangeEventHandler_0;

	private eDotNetBarStyle eDotNetBarStyle_0 = eDotNetBarStyle.Office2007;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private ImageList imageList_0;

	private int int_0;

	private IntPtr intptr_0;

	private IntPtr intptr_1 = IntPtr.Zero;

	private Class194 class194_0;

	private bool bool_6;

	private string string_0 = "";

	private bool bool_7;

	private Font font_0;

	private Color color_0 = SystemColors.GrayText;

	private bool bool_8 = true;

	private Timer timer_0;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private bool bool_9;

	private static Color color_1 = Color.FromArgb(255, 255, 136);

	private Color color_2 = color_1;

	private bool bool_10 = true;

	private bool bool_11 = true;

	private eWatermarkBehavior eWatermarkBehavior_0;

	private Class261 class261_0;

	private bool bool_12;

	internal BaseItem baseItem_0;

	private Timer timer_1;

	private int int_1 = -1;

	private Color color_3 = Color.Empty;

	private Color color_4 = Color.Empty;

	private ICommand icommand_0;

	private object object_0;

	[DefaultValue(true)]
	[Description("Indicates whether control displays focus cues when focused.")]
	[Category("Behavior")]
	public virtual bool FocusCuesEnabled
	{
		get
		{
			return bool_10;
		}
		set
		{
			bool_10 = value;
			if (((Control)this).get_Focused())
			{
				((Control)this).Invalidate();
			}
		}
	}

	[Category("Appearance")]
	[Description("Indicates the appearance of the control.")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool IsStandalone
	{
		get
		{
			return bool_8;
		}
		set
		{
			bool_8 = value;
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether watermark text is displayed when control is empty.")]
	public virtual bool WatermarkEnabled
	{
		get
		{
			return bool_11;
		}
		set
		{
			bool_11 = value;
			((Control)this).Invalidate();
		}
	}

	[DefaultValue("")]
	[Localizable(true)]
	[Description("Indicates watermark text displayed inside of the control when Text is not set and control does not have input focus.")]
	[Category("Appearance")]
	[Browsable(true)]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	public string WatermarkText
	{
		get
		{
			return string_0;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			string_0 = value;
			method_0();
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates watermark hiding behaviour.")]
	[DefaultValue(eWatermarkBehavior.HideOnFocus)]
	[Category("Behavior")]
	public eWatermarkBehavior WatermarkBehavior
	{
		get
		{
			return eWatermarkBehavior_0;
		}
		set
		{
			eWatermarkBehavior_0 = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates watermark font.")]
	[Category("Appearance")]
	[DefaultValue(null)]
	[Browsable(true)]
	public Font WatermarkFont
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
			((Control)this).Invalidate(true);
		}
	}

	[Description("Indicates watermark text color.")]
	[Category("Appearance")]
	[Browsable(true)]
	public Color WatermarkColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			((Control)this).Invalidate(true);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override Color BackColor
	{
		get
		{
			return ((ComboBox)this).get_BackColor();
		}
		set
		{
			((ComboBox)this).set_BackColor(value);
		}
	}

	[Browsable(false)]
	[DefaultValue(false)]
	public bool UseCustomBackColor
	{
		get
		{
			return bool_12;
		}
		set
		{
			bool_12 = value;
		}
	}

	[Category("Behavior")]
	[Browsable(false)]
	[Description("Makes Combo box appear the same as built-in Combo box.")]
	[DefaultValue(false)]
	public bool DefaultStyle
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (bool_0 != value)
			{
				bool_0 = value;
				((Control)this).Invalidate(true);
			}
		}
	}

	[Description("When running on WindowsXP draws control using the Windows XP Themes if theme manager is enabled.")]
	[Browsable(false)]
	[Category("Behavior")]
	[DefaultValue(false)]
	public bool ThemeAware
	{
		get
		{
			return bool_4;
		}
		set
		{
			if (bool_4 != value)
			{
				bool_4 = value;
				if (!bool_4)
				{
					bool_0 = false;
				}
				else if (bool_4 && Class109.Boolean_0)
				{
					bool_0 = true;
					((ComboBox)this).set_FlatStyle((FlatStyle)2);
				}
			}
		}
	}

	[Browsable(true)]
	[Category("Behavior")]
	[Description("Disables internal drawing support for the List-box portion of Combo-box.")]
	[DefaultValue(false)]
	public bool DisableInternalDrawing
	{
		get
		{
			return bool_5;
		}
		set
		{
			if (bool_5 != value)
			{
				bool_5 = value;
			}
		}
	}

	[Description("Indicates whether combo box generates the audible alert when Enter key is pressed.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Behavior")]
	[DefaultValue(false)]
	public bool PreventEnterBeep
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
		}
	}

	[DefaultValue(null)]
	[Browsable(true)]
	[Category("Behavior")]
	[Description("The ImageList control used by Combo box to draw images.")]
	public ImageList Images
	{
		get
		{
			return imageList_0;
		}
		set
		{
			imageList_0 = value;
		}
	}

	[DefaultValue(eDotNetBarStyle.Office2007)]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("Determines the display of the item when shown.")]
	public eDotNetBarStyle Style
	{
		get
		{
			return eDotNetBarStyle_0;
		}
		set
		{
			eDotNetBarStyle_0 = value;
			method_20();
			((Control)this).Invalidate(true);
		}
	}

	private bool Boolean_0
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

	private bool Boolean_1
	{
		get
		{
			return bool_3;
		}
		set
		{
			if (bool_3 != value)
			{
				method_4();
				bool_3 = value;
				((Control)this).Invalidate();
				if (onDropDownChangeEventHandler_0 != null)
				{
					onDropDownChangeEventHandler_0(this, bool_3);
				}
			}
		}
	}

	[Browsable(false)]
	public bool IsToolbarStyle => !bool_8;

	[Description("Indicates text color for the text in combo-box when control Enabled property is set to false. Setting this property is effective only for DropDownList ComboBox style.")]
	[Category("Appearance")]
	public Color DisabledForeColor
	{
		get
		{
			return color_3;
		}
		set
		{
			color_3 = value;
			if (!((Control)this).get_Enabled())
			{
				((Control)this).Invalidate();
			}
		}
	}

	[Description("Indicates control background color when control is disabled")]
	[Category("Appearance")]
	public Color DisabledBackColor
	{
		get
		{
			return color_4;
		}
		set
		{
			if (color_4 != value)
			{
				color_4 = value;
				if (!((Control)this).get_Enabled())
				{
					((Control)this).Invalidate();
				}
			}
		}
	}

	[Browsable(false)]
	public IntPtr DropDownHandle => intptr_1;

	internal bool Boolean_2
	{
		get
		{
			return bool_1;
		}
		set
		{
			if (bool_1 != value)
			{
				bool_1 = value;
				((Control)this).Invalidate(true);
			}
		}
	}

	[Editor(typeof(ComboItemsEditor), typeof(UITypeEditor))]
	[Localizable(true)]
	public ObjectCollection Items => ((ComboBox)this).get_Items();

	[DefaultValue(false)]
	[Description("Indicates whether FocusHighlightColor is used as background color to highlight text box when it has input focus.")]
	[Category("Appearance")]
	[Browsable(true)]
	public virtual bool FocusHighlightEnabled
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
				if (((Control)this).get_Focused())
				{
					((Control)this).Invalidate();
				}
			}
		}
	}

	[Description("Indicates color used as background color to highlight text box when it has input focus and focus highlight is enabled.")]
	[Browsable(true)]
	[Category("Appearance")]
	public virtual Color FocusHighlightColor
	{
		get
		{
			return color_2;
		}
		set
		{
			if (color_2 != value)
			{
				color_2 = value;
				if (((Control)this).get_Focused())
				{
					((Control)this).Invalidate();
				}
			}
		}
	}

	[DefaultValue(null)]
	[Category("Commands")]
	[Description("Indicates the command assigned to the item.")]
	public Command Command
	{
		get
		{
			return (Command)((ICommandSource)this).Command;
		}
		set
		{
			((ICommandSource)this).Command = value;
		}
	}

	ICommand ICommandSource.Command
	{
		get
		{
			return icommand_0;
		}
		set
		{
			bool flag = false;
			if (icommand_0 != value)
			{
				flag = true;
			}
			if (icommand_0 != null)
			{
				CommandManager.UnRegisterCommandSource(this, icommand_0);
			}
			icommand_0 = value;
			if (value != null)
			{
				CommandManager.RegisterCommand(this, value);
			}
			if (flag)
			{
				OnCommandChanged();
			}
		}
	}

	[Localizable(true)]
	[DefaultValue(null)]
	[Category("Commands")]
	[Description("Indicates user defined data value that can be passed to the command when it is executed.")]
	[TypeConverter(typeof(StringConverter))]
	[Browsable(true)]
	public object CommandParameter
	{
		get
		{
			return object_0;
		}
		set
		{
			object_0 = value;
		}
	}

	public event OnDropDownChangeEventHandler DropDownChange
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			onDropDownChangeEventHandler_0 = (OnDropDownChangeEventHandler)Delegate.Combine(onDropDownChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			onDropDownChangeEventHandler_0 = (OnDropDownChangeEventHandler)Delegate.Remove(onDropDownChangeEventHandler_0, value);
		}
	}

	public ComboBoxEx()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		if (!ColorFunctions.bool_0)
		{
			Class92.smethod_5();
			Class92.smethod_6();
			ColorFunctions.LoadColors();
		}
		timer_0 = new Timer();
		timer_0.set_Interval(10);
		timer_0.set_Enabled(false);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((ComboBox)this).set_FlatStyle((FlatStyle)0);
	}

	[DllImport("user32")]
	private static extern bool ValidateRect(IntPtr hWnd, ref Class92.RECT pRect);

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

	private void method_0()
	{
		class261_0 = null;
		if (Class243.smethod_2(ref string_0))
		{
			class261_0 = Class243.smethod_0(string_0);
			method_1();
		}
	}

	private void method_1()
	{
		if (class261_0 != null)
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				Class263 @class = method_2(val);
				class261_0.Measure(method_13().Size, @class);
				Size size = class261_0.Bounds.Size;
				class261_0.method_2(new Rectangle(method_13().Location, size), @class);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	private Class263 method_2(Graphics graphics_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		return new Class263(graphics_0, (font_0 == null) ? ((Control)this).get_Font() : font_0, color_0, (int)((Control)this).get_RightToLeft() == 1);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeWatermarkColor()
	{
		return color_0 != SystemColors.GrayText;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetWatermarkColor()
	{
		WatermarkColor = SystemColors.GrayText;
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((ComboBox)this).OnHandleCreated(e);
		method_20();
		method_22();
		method_5(((Control)this).get_Handle());
	}

	protected override void OnResize(EventArgs e)
	{
		method_1();
		((Control)this).Invalidate();
		((ComboBox)this).OnResize(e);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		bool flag = false;
		if (((Control)this).get_IsHandleCreated() && ((Control)this).get_Visible())
		{
			Class51.RECT r = default(Class51.RECT);
			Class51.GetWindowRect(((Control)this).get_Handle(), ref r);
			if (r.ToRectangle().Contains(Control.get_MousePosition()))
			{
				flag = true;
			}
			Point pt = ((Control)this).PointToClient(Control.get_MousePosition());
			if (rectangle_0.Contains(pt))
			{
				Boolean_0 = true;
			}
			else
			{
				Boolean_0 = false;
			}
		}
		if (!flag)
		{
			method_21(bool_13: false);
			bool_1 = false;
			method_20();
			((Control)this).Invalidate();
			if (baseItem_0 != null)
			{
				baseItem_0.HideToolTip();
			}
		}
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((ComboBox)this).OnGotFocus(e);
		if (!bool_1)
		{
			bool_1 = true;
		}
		method_20();
		((Control)this).Invalidate(true);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		method_21(bool_13: true);
		intptr_0 = IntPtr.Zero;
		((ComboBox)this).OnLostFocus(e);
	}

	private void method_3()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (timer_1 == null)
		{
			timer_1 = new Timer();
			timer_1.add_Tick((EventHandler)timer_1_Tick);
			timer_1.set_Interval(200);
		}
		timer_1.Start();
	}

	private void method_4()
	{
		Timer val = timer_1;
		timer_1 = null;
		if (val != null)
		{
			val.Stop();
			((Component)(object)val).Dispose();
		}
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		Boolean_1 = Class51.SendMessage(((Control)this).get_Handle(), 343, IntPtr.Zero, IntPtr.Zero) != 0;
	}

	protected override void OnDropDownClosed(EventArgs e)
	{
		Boolean_1 = false;
		((ComboBox)this).OnDropDownClosed(e);
	}

	protected override void OnDropDown(EventArgs e)
	{
		((ComboBox)this).OnDropDown(e);
		if (onDropDownChangeEventHandler_0 != null)
		{
			onDropDownChangeEventHandler_0(this, Expanded: true);
		}
		Boolean_1 = true;
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int SetWindowTheme(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] string pszSubAppName, [MarshalAs(UnmanagedType.LPWStr)] string pszSubIdList);

	private void method_5(IntPtr intptr_2)
	{
		bool flag = false;
		if (Environment.Version.Major > 5)
		{
			flag = true;
		}
		else if (Environment.Version.Major == 5 && Environment.Version.Minor >= 1)
		{
			flag = true;
		}
		if (flag)
		{
			SetWindowTheme(intptr_2, " ", " ");
		}
	}

	private Class193 method_6()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		Class193 @class = new Class193();
		bool flag;
		if ((flag = bool_2 || ((Control)this).get_Focused() || (Boolean_1 && (int)((ComboBox)this).get_DropDownStyle() != 0)) && !((Control)this).get_Enabled())
		{
			flag = false;
		}
		if (Style == eDotNetBarStyle.Office2007 && GlobalManager.Renderer is Office2007Renderer)
		{
			Office2007ComboBoxColorTable comboBox = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.ComboBox;
			Office2007ComboBoxStateColorTable office2007ComboBoxStateColorTable = ((!IsToolbarStyle || bool_1) ? comboBox.DefaultStandalone : comboBox.Default);
			if (flag)
			{
				if (((ComboBox)this).get_DroppedDown())
				{
					office2007ComboBoxStateColorTable = comboBox.DroppedDown;
				}
				else if (flag)
				{
					office2007ComboBoxStateColorTable = comboBox.MouseOver;
				}
			}
			@class.color_0 = office2007ComboBoxStateColorTable.Background;
			@class.color_1 = office2007ComboBoxStateColorTable.Border;
			@class.linearGradientColorTable_0 = office2007ComboBoxStateColorTable.ExpandBackground;
			@class.color_2 = office2007ComboBoxStateColorTable.ExpandText;
			@class.linearGradientColorTable_1 = office2007ComboBoxStateColorTable.ExpandBorderOuter;
			@class.linearGradientColorTable_2 = office2007ComboBoxStateColorTable.ExpandBorderInner;
		}
		else
		{
			ColorScheme colorScheme = new ColorScheme(Style);
			if (flag)
			{
				if (Boolean_1)
				{
					@class.linearGradientColorTable_0 = new LinearGradientColorTable(colorScheme.ItemPressedBackground, colorScheme.ItemPressedBackground2, colorScheme.ItemPressedBackgroundGradientAngle);
					@class.color_1 = colorScheme.ItemPressedBorder;
					@class.color_2 = colorScheme.ItemPressedText;
				}
				else
				{
					if (bool_2)
					{
						@class.linearGradientColorTable_0 = new LinearGradientColorTable(colorScheme.ItemHotBackground, colorScheme.ItemHotBackground2, colorScheme.ItemHotBackgroundGradientAngle);
					}
					else
					{
						@class.linearGradientColorTable_0 = new LinearGradientColorTable(colorScheme.BarBackground, colorScheme.BarBackground2, colorScheme.BarBackgroundGradientAngle);
					}
					@class.color_1 = colorScheme.ItemHotBorder;
					@class.color_2 = colorScheme.ItemHotText;
				}
			}
			else
			{
				@class.linearGradientColorTable_0 = new LinearGradientColorTable(colorScheme.BarBackground, colorScheme.BarBackground2, colorScheme.BarBackgroundGradientAngle);
				if (bool_1 || !IsToolbarStyle)
				{
					@class.color_1 = colorScheme.ItemHotBorder;
				}
			}
		}
		if (bool_9 && ((Control)this).get_Enabled() && ((Control)this).get_Focused())
		{
			@class.color_0 = color_2;
		}
		else if (!((Control)this).get_Enabled())
		{
			@class.color_0 = (color_4.IsEmpty ? SystemColors.Control : color_4);
			@class.color_2 = (color_3.IsEmpty ? SystemColors.ControlDark : color_3);
		}
		return @class;
	}

	protected override void WndProc(ref Message m)
	{
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Invalid comparison between Unknown and I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		Class51.RECT r = default(Class51.RECT);
		if (((Message)(ref m)).get_Msg() == 308)
		{
			intptr_1 = ((Message)(ref m)).get_LParam();
			if (int_0 > 0)
			{
				Class51.GetWindowRect(((Message)(ref m)).get_LParam(), ref r);
				Class92.SetWindowPos(((Message)(ref m)).get_LParam(), 0, r.Left, r.Top, r.Right - r.Left, int_0, 18);
			}
		}
		else
		{
			if (((Message)(ref m)).get_Msg() == 343)
			{
				((ComboBox)this).WndProc(ref m);
				if (((Message)(ref m)).get_Result() == IntPtr.Zero && Boolean_1)
				{
					Boolean_1 = false;
				}
				return;
			}
			if (((Message)(ref m)).get_Msg() == 7)
			{
				if (((Message)(ref m)).get_WParam() != ((Control)this).get_Handle())
				{
					intptr_0 = ((Message)(ref m)).get_WParam();
				}
			}
			else if (((Message)(ref m)).get_Msg() == 323)
			{
				if (Items.get_Count() > 0 && Items.get_Item(Items.get_Count() - 1) is ComboItem comboItem)
				{
					comboItem.comboBoxEx_0 = this;
				}
			}
			else if (((Message)(ref m)).get_Msg() == 330)
			{
				int num = ((Message)(ref m)).get_WParam().ToInt32();
				if (num >= 0 && num < Items.get_Count() && Items.get_Item(num) is ComboItem comboItem2)
				{
					comboItem2.comboBoxEx_0 = this;
				}
			}
			else if (((Message)(ref m)).get_Msg() == 1031)
			{
				if ((int)((ComboBox)this).get_DropDownStyle() == 1 && !bool_7)
				{
					((ComboBox)this).set_SelectionLength(0);
				}
				((Control)this).Invalidate(true);
				return;
			}
		}
		if (bool_0)
		{
			((ComboBox)this).WndProc(ref m);
		}
		else if ((((Message)(ref m)).get_Msg() == 15 || ((Message)(ref m)).get_Msg() == 792) && (int)((ComboBox)this).get_DrawMode() != 0)
		{
			Class51.GetWindowRect(((Message)(ref m)).get_HWnd(), ref r);
			Size size_ = new Size(r.Width, r.Height);
			Class51.PAINTSTRUCT ps = default(Class51.PAINTSTRUCT);
			IntPtr intPtr = Class51.BeginPaint(((Message)(ref m)).get_HWnd(), ref ps);
			try
			{
				Graphics val = Graphics.FromHdc(intPtr);
				try
				{
					method_7(val, size_);
				}
				finally
				{
					val.Dispose();
				}
			}
			finally
			{
				Class51.EndPaint(((Message)(ref m)).get_HWnd(), ref ps);
			}
			if (((Control)this).get_Parent() is ItemControl)
			{
				((ItemControl)(object)((Control)this).get_Parent()).method_22();
			}
		}
		else
		{
			((ComboBox)this).WndProc(ref m);
		}
	}

	private void method_7(Graphics graphics_0, Size size_0)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Invalid comparison between Unknown and I4
		Class193 class193_ = method_6();
		Rectangle rectangle_ = new Rectangle(Point.Empty, size_0);
		BufferedBitmap bufferedBitmap = new BufferedBitmap(graphics_0, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
		try
		{
			Graphics graphics = bufferedBitmap.Graphics;
			method_10(graphics, rectangle_, class193_);
			method_9(graphics, rectangle_, class193_);
			Rectangle rectangle = method_8(graphics, rectangle_, class193_);
			int num = ((((ListControl)this).get_SelectedIndex() == -1) ? (-1) : int_1);
			if (int_1 == -1 && ((ListControl)this).get_SelectedIndex() >= 0)
			{
				num = ((ListControl)this).get_SelectedIndex();
			}
			if ((int)((ComboBox)this).get_DropDownStyle() == 2 && num >= 0 && Items.get_Count() > 0 && num < Items.get_Count())
			{
				DrawItemState val = (DrawItemState)4096;
				if (((Control)this).get_Focused())
				{
					val = (DrawItemState)(val | 0x11);
				}
				if (!((Control)this).get_Enabled())
				{
					val = (DrawItemState)4100;
				}
				rectangle.Inflate(-1, -1);
				((ComboBox)this).OnDrawItem(new DrawItemEventArgs(graphics, ((Control)this).get_Font(), rectangle, num, val, ((Control)this).get_ForeColor(), ((Control)this).get_BackColor()));
			}
			if (method_11() && (int)((ComboBox)this).get_DropDownStyle() == 2)
			{
				method_12(graphics);
			}
			bufferedBitmap.Render(graphics_0);
		}
		finally
		{
			bufferedBitmap.Dispose();
		}
	}

	private Rectangle method_8(Graphics graphics_0, Rectangle rectangle_1, Class193 class193_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		Rectangle result = rectangle_1;
		result.Inflate(-2, -2);
		if ((int)((ComboBox)this).get_DropDownStyle() == 0)
		{
			return result;
		}
		int horizontalScrollBarThumbWidth = SystemInformation.get_HorizontalScrollBarThumbWidth();
		Rectangle rectangle = new Rectangle(rectangle_1.Width - horizontalScrollBarThumbWidth, rectangle_1.Y, horizontalScrollBarThumbWidth, rectangle_1.Height);
		if ((int)((Control)this).get_RightToLeft() == 1)
		{
			rectangle = new Rectangle(rectangle_1.X + 1, rectangle_1.Y + 1, horizontalScrollBarThumbWidth, rectangle_1.Height - 2);
		}
		if (!IsToolbarStyle)
		{
			rectangle.Y += 2;
			rectangle.Height -= 4;
			rectangle.Width -= 2;
			if ((int)((Control)this).get_RightToLeft() == 1)
			{
				rectangle.X += 2;
			}
		}
		else if (Style != eDotNetBarStyle.Office2007)
		{
			rectangle.Inflate(-1, -1);
		}
		if ((int)((Control)this).get_RightToLeft() == 1)
		{
			int num = rectangle.Right - result.X + 2;
			result.Width -= num;
			result.X += num;
		}
		else
		{
			int num2 = result.Right - rectangle.X + 2;
			result.Width -= num2;
		}
		if (!IsToolbarStyle && Style == eDotNetBarStyle.Office2007)
		{
			Class268.smethod_4(graphics_0, GetOffice2007StateColorTable(), rectangle, RoundRectangleShapeDescriptor.RectangleShape);
		}
		else
		{
			if (class193_0.linearGradientColorTable_0 != null)
			{
				Class50.smethod_25(graphics_0, rectangle, class193_0.linearGradientColorTable_0);
			}
			if (class193_0.linearGradientColorTable_1 != null)
			{
				Class50.smethod_33(graphics_0, rectangle, class193_0.linearGradientColorTable_1, 1);
			}
			Rectangle rectangle2 = rectangle;
			rectangle2.Inflate(-1, -1);
			if (class193_0.linearGradientColorTable_2 != null)
			{
				Class50.smethod_33(graphics_0, rectangle2, class193_0.linearGradientColorTable_2, 1);
			}
		}
		SolidBrush val = new SolidBrush(class193_0.color_2);
		try
		{
			method_14(rectangle, graphics_0, (Brush)(object)val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		rectangle_0 = rectangle;
		return result;
	}

	protected Office2007ButtonItemStateColorTable GetOffice2007StateColorTable()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		bool flag = bool_2 || (Boolean_1 && (int)((ComboBox)this).get_DropDownStyle() != 0);
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			Office2007ColorTable colorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
			Office2007ButtonItemColorTable office2007ButtonItemColorTable = colorTable.ButtonItemColors[Enum.GetName(typeof(eButtonColor), eButtonColor.OrangeWithBackground)];
			if (!((Control)this).get_Enabled())
			{
				return office2007ButtonItemColorTable.Disabled;
			}
			if (Boolean_1)
			{
				return office2007ButtonItemColorTable.Checked;
			}
			if (flag)
			{
				return office2007ButtonItemColorTable.MouseOver;
			}
			return office2007ButtonItemColorTable.Default;
		}
		return null;
	}

	private void method_9(Graphics graphics_0, Rectangle rectangle_1, Class193 class193_0)
	{
		Class50.smethod_6(graphics_0, class193_0.color_1, rectangle_1);
	}

	private void method_10(Graphics graphics_0, Rectangle rectangle_1, Class193 class193_0)
	{
		Class50.smethod_23(graphics_0, rectangle_1, class193_0.color_0);
	}

	private bool method_11()
	{
		if (bool_11 && ((Control)this).get_Enabled() && (!((Control)this).get_Focused() || eWatermarkBehavior_0 == eWatermarkBehavior.HideNonEmpty) && ((Control)this).get_Text() == "" && ((ListControl)this).get_SelectedIndex() == -1)
		{
			return true;
		}
		return false;
	}

	private void method_12(Graphics graphics_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		if (class261_0 != null)
		{
			Class263 d = method_2(graphics_0);
			class261_0.Render(d);
			return;
		}
		eTextFormat eTextFormat = eTextFormat.VerticalCenter;
		if ((int)((Control)this).get_RightToLeft() == 1)
		{
			eTextFormat |= eTextFormat.RightToLeft;
		}
		eTextFormat |= eTextFormat.EndEllipsis;
		eTextFormat |= eTextFormat.WordBreak;
		Class55.smethod_1(graphics_0, string_0, (font_0 == null) ? ((Control)this).get_Font() : font_0, color_0, method_13(), eTextFormat);
	}

	private Rectangle method_13()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		if ((int)((ComboBox)this).get_DropDownStyle() != 2 && class194_0 != null)
		{
			Class51.RECT r = default(Class51.RECT);
			Class51.GetWindowRect(((NativeWindow)class194_0).get_Handle(), ref r);
			return new Rectangle(0, 0, r.Width, r.Height);
		}
		Rectangle result = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		result.Inflate(-2, -1);
		int horizontalScrollBarThumbWidth = SystemInformation.get_HorizontalScrollBarThumbWidth();
		result.Width -= horizontalScrollBarThumbWidth;
		if ((int)((Control)this).get_RightToLeft() == 1)
		{
			result.X += horizontalScrollBarThumbWidth;
		}
		return result;
	}

	private void method_14(Rectangle rectangle_1, Graphics graphics_0, Brush brush_0)
	{
		Point[] array = new Point[3];
		array[0].X = rectangle_1.Left + (rectangle_1.Width - 4) / 2;
		array[0].Y = rectangle_1.Top + (rectangle_1.Height - 3) / 2 + 1;
		array[1].X = array[0].X + 5;
		array[1].Y = array[0].Y;
		array[2].X = array[0].X + 2;
		array[2].Y = array[0].Y + 3;
		graphics_0.FillPolygon(brush_0, array);
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		((Control)this).OnVisibleChanged(e);
		bool_1 = false;
		if ((int)((ComboBox)this).get_DropDownStyle() == 1 && Items.get_Count() > 0 && Items.get_Item(0) is ComboItem && ((ListControl)this).get_DisplayMember() != "")
		{
			string displayMember = ((ListControl)this).get_DisplayMember();
			((ListControl)this).set_DisplayMember("");
			((ListControl)this).set_DisplayMember(displayMember);
		}
		if (((Control)this).get_IsHandleCreated() && !((Control)this).get_IsDisposed())
		{
			method_20();
		}
	}

	protected override void OnSelectedIndexChanged(EventArgs e)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		int_1 = ((ListControl)this).get_SelectedIndex();
		if (!Boolean_1)
		{
			if (Boolean_1)
			{
				Boolean_1 = false;
			}
			if (!bool_1)
			{
				((Control)this).Invalidate(true);
			}
		}
		if (((ListControl)this).get_SelectedIndex() == -1 && eWatermarkBehavior_0 == eWatermarkBehavior.HideNonEmpty && string_0.Length > 0 && ((Control)this).get_Text() == "")
		{
			((Control)this).Invalidate(true);
		}
		else if ((int)((ComboBox)this).get_DropDownStyle() == 2)
		{
			((Control)this).Invalidate();
		}
		((ComboBox)this).OnSelectedIndexChanged(e);
		ExecuteCommand();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		if (((ListControl)this).get_SelectedIndex() == -1 && eWatermarkBehavior_0 == eWatermarkBehavior.HideNonEmpty && string_0.Length > 0 && ((Control)this).get_Text() == "")
		{
			((Control)this).Invalidate(true);
		}
		((ComboBox)this).OnTextChanged(e);
	}

	protected override void Dispose(bool disposing)
	{
		if (timer_0 != null)
		{
			timer_0.set_Enabled(false);
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
		bool_5 = true;
		if (class194_0 != null)
		{
			((NativeWindow)class194_0).ReleaseHandle();
			class194_0 = null;
		}
		((ComboBox)this).Dispose(disposing);
	}

	protected override void OnFontChanged(EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		((ComboBox)this).OnFontChanged(e);
		if (!((Control)this).get_Disposing() && !((Control)this).get_IsDisposed() && !bool_5 && (int)((ComboBox)this).get_DrawMode() == 1 && ((Control)this).get_IsHandleCreated() && ((Control)this).get_Parent() != null && !((Control)this).get_Parent().get_IsDisposed())
		{
			((ComboBox)this).set_ItemHeight(((Control)this).get_FontHeight() + 1);
		}
	}

	internal int method_15()
	{
		return ((Control)this).get_FontHeight();
	}

	protected override void OnMeasureItem(MeasureItemEventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		((ComboBox)this).OnMeasureItem(e);
		if (bool_5)
		{
			return;
		}
		if ((int)((ComboBox)this).get_DrawMode() == 1)
		{
			e.set_ItemHeight(((ComboBox)this).get_ItemHeight() - 2);
			return;
		}
		object obj = Items.get_Item(e.get_Index());
		if (!(obj is ComboItem))
		{
			return;
		}
		if (((ComboItem)obj).bool_0)
		{
			method_19(e);
			return;
		}
		Size comboItemSize = GetComboItemSize(obj as ComboItem);
		e.set_ItemHeight(comboItemSize.Height);
		e.set_ItemWidth(comboItemSize.Width);
		if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007)
		{
			e.set_ItemHeight(e.get_ItemHeight() + 6);
			e.set_ItemWidth(e.get_ItemWidth() + 6);
		}
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{
		((ComboBox)this).OnDrawItem(e);
		method_16(e);
	}

	private void method_16(DrawItemEventArgs drawItemEventArgs_0)
	{
		if (!bool_5 && drawItemEventArgs_0.get_Index() >= 0)
		{
			object obj = Items.get_Item(drawItemEventArgs_0.get_Index());
			if (obj is ComboItem)
			{
				DrawComboItem(drawItemEventArgs_0);
			}
			else
			{
				DrawObjectItem(drawItemEventArgs_0);
			}
		}
	}

	protected virtual Size GetComboItemSize(ComboItem item)
	{
		Size empty = Size.Empty;
		if (Class109.smethod_11((Control)(object)this))
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				return GetComboItemSize(item, val);
			}
			finally
			{
				val.Dispose();
			}
		}
		return empty;
	}

	protected virtual void DrawObjectItem(DrawItemEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Invalid comparison between Unknown and I4
		Graphics graphics = e.get_Graphics();
		string itemText = ((ListControl)this).GetItemText(Items.get_Item(e.get_Index()));
		Color empty = Color.Empty;
		Office2007ButtonItemStateColorTable office2007ButtonItemStateColorTable = null;
		if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007)
		{
			Office2007ButtonItemColorTable office2007ButtonItemColorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.ButtonItemColors[0];
			office2007ButtonItemStateColorTable = (((e.get_State() & 1) != 0 || (e.get_State() & 0x40) != 0) ? office2007ButtonItemColorTable.MouseOver : (((e.get_State() & 4) != 0 || !((Control)this).get_Enabled()) ? office2007ButtonItemColorTable.Disabled : office2007ButtonItemColorTable.Default));
			empty = (((e.get_State() & 4) != 0 || !((Control)this).get_Enabled()) ? (color_3.IsEmpty ? SystemColors.ControlDark : color_3) : ((Control)this).get_ForeColor());
			if ((e.get_State() & 0x40) == 0 && (e.get_State() & 1) == 0)
			{
				e.DrawBackground();
			}
			else
			{
				Rectangle bounds = e.get_Bounds();
				bounds.Width--;
				bounds.Height--;
				Class268.smethod_4(graphics, office2007ButtonItemStateColorTable, bounds, RoundRectangleShapeDescriptor.RoundCorner2);
			}
		}
		else
		{
			e.DrawBackground();
			if ((e.get_State() & 0x40) == 0 && (e.get_State() & 1) == 0)
			{
				empty = (((e.get_State() & 4) != 0 || (e.get_State() & 2) != 0) ? (color_3.IsEmpty ? SystemColors.ControlDark : color_3) : SystemColors.ControlText);
			}
			else
			{
				graphics.FillRectangle(SystemBrushes.get_Highlight(), e.get_Bounds());
				empty = SystemColors.HighlightText;
			}
		}
		if ((e.get_State() & 0x10) != 0)
		{
			method_17(e);
		}
		Rectangle bounds2 = e.get_Bounds();
		if ((e.get_State() & 0x1000) != 4096)
		{
			if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007)
			{
				bounds2.Inflate(-3, 0);
			}
			else
			{
				bounds2.Inflate(-2, 0);
			}
		}
		Class55.smethod_1(graphics, itemText, ((Control)this).get_Font(), empty, bounds2, eTextFormat.NoClipping | eTextFormat.NoPrefix);
	}

	private void method_17(DrawItemEventArgs drawItemEventArgs_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		if (bool_10 && (drawItemEventArgs_0.get_State() & 0x10) == 16 && (drawItemEventArgs_0.get_State() & 0x200) != 512)
		{
			Rectangle bounds = drawItemEventArgs_0.get_Bounds();
			ControlPaint.DrawFocusRectangle(drawItemEventArgs_0.get_Graphics(), bounds, drawItemEventArgs_0.get_ForeColor(), drawItemEventArgs_0.get_BackColor());
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool ShouldSerializeDisabledForeColor()
	{
		return !color_3.IsEmpty;
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public void ResetDisabledForeColor()
	{
		DisabledForeColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDisabledBackColor()
	{
		return !color_4.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDisabledBackColor()
	{
		DisabledBackColor = Color.Empty;
	}

	protected virtual void DrawComboItem(DrawItemEventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Invalid comparison between Unknown and I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Invalid comparison between Unknown and I4
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Invalid comparison between Unknown and I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Invalid comparison between Unknown and I4
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Invalid comparison between Unknown and I4
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Invalid comparison between Unknown and I4
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Invalid comparison between Unknown and I4
		ComboItem comboItem = Items.get_Item(e.get_Index()) as ComboItem;
		if (comboItem.bool_0)
		{
			method_18(e);
			return;
		}
		Graphics graphics = e.get_Graphics();
		Image val = null;
		Color color = comboItem.ForeColor;
		if (color.IsEmpty || (e.get_State() & 1) != 0 || (e.get_State() & 0x40) != 0)
		{
			color = ((Control)this).get_ForeColor();
		}
		if (comboItem.ImageIndex >= 0 && imageList_0 != null && imageList_0.get_Images().get_Count() > comboItem.ImageIndex)
		{
			val = imageList_0.get_Images().get_Item(comboItem.ImageIndex);
		}
		else if (comboItem.Image != null)
		{
			val = comboItem.Image;
		}
		Office2007ButtonItemStateColorTable office2007ButtonItemStateColorTable_ = null;
		if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007)
		{
			Office2007ButtonItemColorTable office2007ButtonItemColorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.ButtonItemColors[0];
			office2007ButtonItemStateColorTable_ = (((e.get_State() & 1) != 0 || (e.get_State() & 0x40) != 0) ? office2007ButtonItemColorTable.MouseOver : (((e.get_State() & 4) != 0 || !((Control)this).get_Enabled()) ? office2007ButtonItemColorTable.Disabled : office2007ButtonItemColorTable.Default));
			if (!((Control)this).get_Enabled())
			{
				color = (color_3.IsEmpty ? SystemColors.ControlDark : color_3);
			}
		}
		int dropDownWidth = ((ComboBox)this).get_DropDownWidth();
		if ((int)comboItem.ImagePosition != 2 && val != null)
		{
			dropDownWidth -= val.get_Width();
			if (dropDownWidth <= 0)
			{
				dropDownWidth = ((ComboBox)this).get_DropDownWidth();
			}
		}
		if ((e.get_State() & 1) == 0 && (e.get_State() & 0x40) == 0)
		{
			Color backColor = comboItem.BackColor;
			if (comboItem.BackColor.IsEmpty)
			{
				backColor = e.get_BackColor();
			}
			graphics.FillRectangle((Brush)new SolidBrush(backColor), e.get_Bounds());
		}
		else
		{
			if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007)
			{
				Class268.smethod_4(graphics, office2007ButtonItemStateColorTable_, e.get_Bounds(), RoundRectangleShapeDescriptor.RoundCorner2);
			}
			else
			{
				e.DrawBackground();
			}
			method_17(e);
		}
		Rectangle bounds = e.get_Bounds();
		Rectangle bounds2 = e.get_Bounds();
		if ((e.get_State() & 0x1000) != 4096)
		{
			if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007)
			{
				bounds2.Inflate(-3, 0);
			}
			else
			{
				bounds2.Inflate(-2, 0);
			}
		}
		if (val != null)
		{
			bounds.Width = val.get_Width();
			bounds.Height = val.get_Height();
			if ((int)comboItem.ImagePosition == 0)
			{
				if (e.get_Bounds().Height > val.get_Height())
				{
					bounds.Y += (e.get_Bounds().Height - val.get_Height()) / 2;
				}
				bounds2.Width -= bounds.Width;
				bounds2.X += bounds.Width;
			}
			else if ((int)comboItem.ImagePosition == 1)
			{
				if (e.get_Bounds().Height > val.get_Height())
				{
					bounds.Y += (e.get_Bounds().Height - val.get_Height()) / 2;
				}
				bounds.X = e.get_Bounds().Right - val.get_Width();
				bounds2.Width -= bounds.Width;
			}
			else
			{
				bounds.X += (e.get_Bounds().Width - val.get_Width()) / 2;
				bounds2.Y = bounds.Bottom;
			}
			graphics.DrawImage(val, bounds);
		}
		if (!(comboItem.Text != ""))
		{
			return;
		}
		Font val2 = e.get_Font();
		bool flag = false;
		try
		{
			if (comboItem.FontName != "")
			{
				val2 = new Font(comboItem.FontName, comboItem.FontSize, comboItem.FontStyle);
				flag = true;
			}
			else if (comboItem.FontStyle != val2.get_Style())
			{
				val2 = new Font(val2, val2.get_Style());
				flag = true;
			}
		}
		catch
		{
			val2 = e.get_Font();
			if (val2 == null)
			{
				object obj = SystemInformation.get_MenuFont().Clone();
				val2 = (Font)((obj is Font) ? obj : null);
				flag = true;
			}
		}
		eTextFormat eTextFormat = eTextFormat.NoClipping | eTextFormat.NoPrefix;
		if ((int)comboItem.TextFormat.get_Alignment() == 1)
		{
			eTextFormat = eTextFormat.HorizontalCenter;
		}
		else if ((int)comboItem.TextFormat.get_Alignment() == 2)
		{
			eTextFormat = eTextFormat.Right;
		}
		if ((int)comboItem.TextLineAlignment == 1)
		{
			eTextFormat |= eTextFormat.VerticalCenter;
		}
		else if ((int)comboItem.TextLineAlignment == 2)
		{
			eTextFormat |= eTextFormat.Bottom;
		}
		Class55.smethod_1(graphics, comboItem.Text, val2, color, bounds2, eTextFormat);
		if (flag)
		{
			val2.Dispose();
		}
	}

	protected virtual Size GetComboItemSize(ComboItem item, Graphics g)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Invalid comparison between Unknown and I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Invalid comparison between Unknown and I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Invalid comparison between Unknown and I4
		if ((int)((ComboBox)this).get_DrawMode() == 1)
		{
			return new Size(((ComboBox)this).get_DropDownWidth(), ((ComboBox)this).get_ItemHeight());
		}
		Size empty = Size.Empty;
		Size empty2 = Size.Empty;
		Image val = null;
		if (item.ImageIndex >= 0)
		{
			val = imageList_0.get_Images().get_Item(item.ImageIndex);
		}
		else if (item.Image != null)
		{
			val = item.Image;
		}
		int dropDownWidth = ((ComboBox)this).get_DropDownWidth();
		if ((int)item.ImagePosition != 2 && val != null)
		{
			dropDownWidth -= val.get_Width();
			if (dropDownWidth <= 0)
			{
				dropDownWidth = ((ComboBox)this).get_DropDownWidth();
			}
		}
		Font val2 = ((Control)this).get_Font();
		if (item.FontName != "")
		{
			try
			{
				val2 = new Font(item.FontName, item.FontSize, item.FontStyle);
			}
			catch
			{
				val2 = ((Control)this).get_Font();
			}
		}
		eTextFormat eTextFormat = eTextFormat.Default;
		if ((int)item.TextFormat.get_Alignment() == 1)
		{
			eTextFormat = eTextFormat.HorizontalCenter;
		}
		else if ((int)item.TextFormat.get_Alignment() == 2)
		{
			eTextFormat = eTextFormat.Right;
		}
		if ((int)item.TextLineAlignment == 1)
		{
			eTextFormat |= eTextFormat.VerticalCenter;
		}
		else if ((int)item.TextLineAlignment == 2)
		{
			eTextFormat |= eTextFormat.Bottom;
		}
		empty2 = Class55.smethod_4(g, item.Text, val2, ((ComboBox)this).get_DropDownWidth(), eTextFormat);
		empty2.Width += 2;
		empty.Width = empty2.Width;
		empty.Height = empty2.Height;
		if (empty.Width < ((ComboBox)this).get_DropDownWidth())
		{
			empty.Width = ((ComboBox)this).get_DropDownWidth();
		}
		if ((int)item.ImagePosition == 2 && val != null)
		{
			empty.Height += val.get_Height();
		}
		else if (val != null && val.get_Height() > empty.Height)
		{
			empty.Height = val.get_Height();
		}
		return empty;
	}

	public void LoadFonts()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		Items.Clear();
		InstalledFontCollection val = new InstalledFontCollection();
		FontFamily[] families = ((FontCollection)val).get_Families();
		FontFamily[] array = families;
		foreach (FontFamily val2 in array)
		{
			ComboItem comboItem = new ComboItem();
			comboItem.bool_0 = true;
			comboItem.FontName = val2.GetName(0);
			comboItem.FontSize = ((Control)this).get_Font().get_Size();
			comboItem.Text = val2.GetName(0);
			Items.Add((object)comboItem);
		}
		((ComboBox)this).set_DropDownWidth(((Control)this).get_Width() * 2);
	}

	private void method_18(DrawItemEventArgs drawItemEventArgs_0)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Invalid comparison between Unknown and I4
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Invalid comparison between Unknown and I4
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		FontStyle[] array = (FontStyle[])(object)new FontStyle[4]
		{
			default(FontStyle),
			(FontStyle)1,
			(FontStyle)2,
			(FontStyle)3
		};
		if (eDotNetBarStyle_0 != eDotNetBarStyle.Office2007)
		{
			drawItemEventArgs_0.DrawBackground();
		}
		string text = Items.get_Item(drawItemEventArgs_0.get_Index()).ToString();
		FontFamily val = new FontFamily(text);
		int num = ((ComboBox)this).get_DropDownWidth() / 2 - 4;
		if (num <= 0)
		{
			num = ((Control)this).get_Width();
		}
		FontStyle[] array2 = array;
		int num2 = 0;
		FontStyle val2;
		while (true)
		{
			if (num2 < array2.Length)
			{
				val2 = array2[num2];
				if (val.IsStyleAvailable(val2))
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		eTextFormat eTextFormat_ = eTextFormat.NoPrefix;
		Color color = (((drawItemEventArgs_0.get_State() & 1) != 0) ? SystemColors.HighlightText : SystemColors.ControlText);
		Office2007ButtonItemStateColorTable office2007ButtonItemStateColorTable = null;
		if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007)
		{
			Office2007ButtonItemColorTable office2007ButtonItemColorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.ButtonItemColors[0];
			office2007ButtonItemStateColorTable = (((drawItemEventArgs_0.get_State() & 1) != 0 || (drawItemEventArgs_0.get_State() & 0x40) != 0) ? office2007ButtonItemColorTable.MouseOver : (((drawItemEventArgs_0.get_State() & 4) != 0 || !((Control)this).get_Enabled()) ? office2007ButtonItemColorTable.Disabled : office2007ButtonItemColorTable.Default));
			color = (((Control)this).get_Enabled() ? SystemColors.ControlText : (color_3.IsEmpty ? SystemColors.ControlDark : color_3));
			if ((drawItemEventArgs_0.get_State() & 1) == 0 && (drawItemEventArgs_0.get_State() & 0x40) == 0)
			{
				drawItemEventArgs_0.DrawBackground();
			}
			else
			{
				Class268.smethod_4(drawItemEventArgs_0.get_Graphics(), office2007ButtonItemStateColorTable, drawItemEventArgs_0.get_Bounds(), RoundRectangleShapeDescriptor.RoundCorner2);
			}
		}
		if ((drawItemEventArgs_0.get_State() & 0x1000) == 4096)
		{
			Rectangle bounds = drawItemEventArgs_0.get_Bounds();
			bounds.Y++;
			bounds.Height--;
			Class55.smethod_1(drawItemEventArgs_0.get_Graphics(), text, ((Control)this).get_Font(), color, bounds, eTextFormat_);
		}
		else
		{
			Size size = Class55.smethod_3(drawItemEventArgs_0.get_Graphics(), text, ((Control)this).get_Font());
			int num3 = (drawItemEventArgs_0.get_Bounds().Height - size.Height) / 2;
			Rectangle rectangle = new Rectangle(drawItemEventArgs_0.get_Bounds().X, drawItemEventArgs_0.get_Bounds().Y + num3, ((drawItemEventArgs_0.get_State() & 4) == 4) ? drawItemEventArgs_0.get_Bounds().Width : Math.Max(drawItemEventArgs_0.get_Bounds().Width - 100, 32), drawItemEventArgs_0.get_Bounds().Height - num3);
			Class55.smethod_1(drawItemEventArgs_0.get_Graphics(), text, ((Control)this).get_Font(), color, rectangle, eTextFormat_);
			Rectangle rectangle2 = new Rectangle(drawItemEventArgs_0.get_Bounds().X + num + 4, drawItemEventArgs_0.get_Bounds().Y, drawItemEventArgs_0.get_Bounds().Width + 100, drawItemEventArgs_0.get_Bounds().Height);
			Font val3 = new Font(val, (float)drawItemEventArgs_0.get_Bounds().Height - 8f, val2);
			Class55.smethod_1(drawItemEventArgs_0.get_Graphics(), text, val3, color, rectangle2, eTextFormat_);
		}
	}

	private void method_19(MeasureItemEventArgs measureItemEventArgs_0)
	{
		measureItemEventArgs_0.set_ItemHeight(18);
	}

	public void ReleaseFocus()
	{
		if (!((Control)this).get_Focused() || !(intptr_0 != IntPtr.Zero))
		{
			return;
		}
		Control val = Control.FromChildHandle(new IntPtr(intptr_0.ToInt32()));
		if (val != this)
		{
			if (val != null)
			{
				val.Focus();
			}
			else
			{
				Class92.SetFocus(intptr_0.ToInt32());
			}
			((Control)this).OnLostFocus(new EventArgs());
		}
		intptr_0 = IntPtr.Zero;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 13 && bool_6)
		{
			((Control)this).OnKeyPress(new KeyPressEventArgs('\r'));
			return true;
		}
		return ((Control)this).ProcessCmdKey(ref msg, keyData);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		if (!IsStandalone)
		{
			if ((int)e.get_KeyCode() == 13)
			{
				ReleaseFocus();
			}
			else if ((int)e.get_KeyCode() == 27)
			{
				ReleaseFocus();
			}
		}
		((ComboBox)this).OnKeyDown(e);
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		method_20();
		((Control)this).OnEnabledChanged(e);
	}

	private void method_20()
	{
		if (!bool_12)
		{
			Color color = method_6().color_0;
			if (((Control)this).get_BackColor() != color)
			{
				((Control)this).set_BackColor(color);
			}
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		if (!bool_1)
		{
			bool_1 = true;
			method_20();
			((Control)this).Invalidate(true);
		}
		method_21(bool_13: true);
		((ComboBox)this).OnMouseEnter(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		method_21(bool_13: true);
		((ComboBox)this).OnMouseLeave(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		if (!bool_1)
		{
			bool_1 = true;
			((Control)this).Invalidate();
			method_21(bool_13: true);
		}
	}

	private void method_21(bool bool_13)
	{
		if (timer_0 != null)
		{
			timer_0.set_Enabled(bool_13);
		}
	}

	private void method_22()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		if ((int)((ComboBox)this).get_DropDownStyle() != 2 && (int)((ComboBox)this).get_AutoCompleteMode() == 0)
		{
			if (class194_0 == null)
			{
				IntPtr window = GetWindow(((Control)this).get_Handle(), 5u);
				if (window != IntPtr.Zero)
				{
					class194_0 = new Class194();
					class194_0.Event_0 += method_24;
					class194_0.Event_1 += new PaintEventHandler(method_23);
					((NativeWindow)class194_0).AssignHandle(window);
				}
			}
		}
		else if (class194_0 != null)
		{
			((NativeWindow)class194_0).ReleaseHandle();
			class194_0 = null;
		}
	}

	protected override void OnDropDownStyleChanged(EventArgs e)
	{
		method_22();
		((ComboBox)this).OnDropDownStyleChanged(e);
	}

	private void method_23(object sender, PaintEventArgs e)
	{
		if (method_11())
		{
			method_12(e.get_Graphics());
		}
	}

	private void method_24(object sender, EventArgs e)
	{
		if (bool_1)
		{
			method_21(bool_13: true);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFocusHighlightColor()
	{
		return !color_2.Equals((object?)color_1);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetFocusHighlightColor()
	{
		FocusHighlightColor = color_1;
	}

	protected virtual void ExecuteCommand()
	{
		if (icommand_0 != null)
		{
			CommandManager.smethod_0(this);
		}
	}

	protected virtual void OnCommandChanged()
	{
	}
}
