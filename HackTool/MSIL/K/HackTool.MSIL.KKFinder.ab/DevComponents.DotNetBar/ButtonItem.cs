using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.Editors;

namespace DevComponents.DotNetBar;

[Designer(typeof(BaseItemDesigner))]
[DesignTimeVisible(false)]
[ToolboxItem(false)]
[DefaultEvent("Click")]
public class ButtonItem : PopupItem, IPersonalizedMenuItem
{
	public class ButtonItemAccessibleObject : ItemAccessibleObject
	{
		private ButtonItemPartAccessibleObject buttonItemPartAccessibleObject_0;

		private ButtonItemPartAccessibleObject buttonItemPartAccessibleObject_1;

		internal ButtonItem ButtonItem_0 => base.BaseItem_0 as ButtonItem;

		private ButtonItemPartAccessibleObject ButtonItemPartAccessibleObject_0
		{
			get
			{
				if (buttonItemPartAccessibleObject_0 == null)
				{
					buttonItemPartAccessibleObject_0 = new ButtonItemPartAccessibleObject(ButtonItem_0, pushButtonPart: true);
				}
				return buttonItemPartAccessibleObject_0;
			}
		}

		private ButtonItemPartAccessibleObject ButtonItemPartAccessibleObject_1
		{
			get
			{
				if (buttonItemPartAccessibleObject_1 == null)
				{
					buttonItemPartAccessibleObject_1 = new ButtonItemPartAccessibleObject(ButtonItem_0, pushButtonPart: false);
				}
				return buttonItemPartAccessibleObject_1;
			}
		}

		public override AccessibleRole Role
		{
			get
			{
				//IL_000c: Unknown result type (might be due to invalid IL or missing references)
				if (Boolean_0)
				{
					return (AccessibleRole)20;
				}
				return base.Role;
			}
		}

		private bool Boolean_0
		{
			get
			{
				ButtonItem buttonItem_ = ButtonItem_0;
				if (buttonItem_.VisibleSubItems > 0 && !buttonItem_.AutoExpandOnClick && !buttonItem_.IsOnMenu && !buttonItem_.IsOnMenuBar)
				{
					return true;
				}
				return false;
			}
		}

		public override AccessibleStates State
		{
			get
			{
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008a: Unknown result type (might be due to invalid IL or missing references)
				if (Boolean_0)
				{
					if (base.BaseItem_0 != null && base.BaseItem_0.IsAccessible)
					{
						AccessibleStates val = (AccessibleStates)0;
						if (base.BaseItem_0.Displayed && base.BaseItem_0.Visible)
						{
							if (!base.BaseItem_0.method_2())
							{
								return (AccessibleStates)1;
							}
						}
						else
						{
							val = (AccessibleStates)(val | 0x8000);
						}
						return (AccessibleStates)256;
					}
					return (AccessibleStates)1;
				}
				AccessibleStates val2 = base.State;
				if (ButtonItem_0.method_2() && (ButtonItem_0.Checked || ButtonItem_0.IsMouseDown))
				{
					val2 = (AccessibleStates)(val2 | 8);
				}
				return val2;
			}
		}

		public override string DefaultAction
		{
			get
			{
				if (Boolean_0)
				{
					return "";
				}
				return base.DefaultAction;
			}
		}

		public override string KeyboardShortcut => "";

		public ButtonItemAccessibleObject(BaseItem owner)
			: base(owner)
		{
		}

		public override int GetChildCount()
		{
			if (Boolean_0)
			{
				return 2;
			}
			return base.GetChildCount();
		}

		public override AccessibleObject GetChild(int iIndex)
		{
			if (Boolean_0)
			{
				switch (iIndex)
				{
				case 0:
					return (AccessibleObject)(object)ButtonItemPartAccessibleObject_0;
				case 1:
					return (AccessibleObject)(object)ButtonItemPartAccessibleObject_1;
				}
			}
			return base.GetChild(iIndex);
		}

		public override void DoDefaultAction()
		{
			if (!Boolean_0)
			{
				base.DoDefaultAction();
			}
		}

		public override AccessibleObject GetSelected()
		{
			if (Boolean_0)
			{
				if (ButtonItem_0.IsMouseOverExpand)
				{
					return (AccessibleObject)(object)ButtonItemPartAccessibleObject_1;
				}
				if (ButtonItem_0.IsMouseOver)
				{
					return (AccessibleObject)(object)ButtonItemPartAccessibleObject_0;
				}
				return null;
			}
			return base.GetSelected();
		}

		public override AccessibleObject HitTest(int x, int y)
		{
			if (Boolean_0)
			{
				if (((AccessibleObject)ButtonItemPartAccessibleObject_0).get_Bounds().Contains(x, y))
				{
					return (AccessibleObject)(object)ButtonItemPartAccessibleObject_0;
				}
				if (((AccessibleObject)ButtonItemPartAccessibleObject_1).get_Bounds().Contains(x, y))
				{
					return (AccessibleObject)(object)ButtonItemPartAccessibleObject_1;
				}
				return null;
			}
			return base.HitTest(x, y);
		}
	}

	public class ButtonItemPartAccessibleObject : AccessibleObject
	{
		private ButtonItem buttonItem_0;

		private bool bool_0 = true;

		public override string Name
		{
			get
			{
				if (!bool_0)
				{
					return "Open";
				}
				if (buttonItem_0 == null)
				{
					return "";
				}
				if (buttonItem_0.AccessibleName != "")
				{
					return buttonItem_0.AccessibleName;
				}
				if (buttonItem_0.Text != null)
				{
					return buttonItem_0.Text.Replace("&", "");
				}
				return buttonItem_0.Tooltip;
			}
			set
			{
				buttonItem_0.AccessibleName = value;
			}
		}

		public override string Description
		{
			get
			{
				if (buttonItem_0 == null)
				{
					return "";
				}
				if (buttonItem_0.AccessibleDescription != "")
				{
					return buttonItem_0.AccessibleDescription;
				}
				return ((AccessibleObject)this).get_Name() + " button";
			}
		}

		public override AccessibleRole Role
		{
			get
			{
				if (!bool_0)
				{
					return (AccessibleRole)56;
				}
				return (AccessibleRole)62;
			}
		}

		public override AccessibleStates State
		{
			get
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00be: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				if (buttonItem_0 == null)
				{
					return (AccessibleStates)1;
				}
				AccessibleStates val = (AccessibleStates)0;
				if (!buttonItem_0.IsAccessible)
				{
					return (AccessibleStates)1;
				}
				if (buttonItem_0.Displayed && buttonItem_0.Visible)
				{
					if (!buttonItem_0.method_2())
					{
						return (AccessibleStates)1;
					}
					if (bool_0)
					{
						if (buttonItem_0.IsMouseOver && !buttonItem_0.IsMouseOverExpand)
						{
							return (AccessibleStates)(val | 0x84);
						}
						return (AccessibleStates)(val | 0x100000);
					}
					if (buttonItem_0.Expanded || buttonItem_0.IsMouseOverExpand)
					{
						val = (AccessibleStates)(val | 0x84);
					}
					if (buttonItem_0.Expanded)
					{
						return (AccessibleStates)(val | 0x200);
					}
					return (AccessibleStates)(val | 0x400);
				}
				return (AccessibleStates)(val | 0x8000);
			}
		}

		public override AccessibleObject Parent => buttonItem_0.AccessibleObject;

		public override Rectangle Bounds
		{
			get
			{
				object containerControl = buttonItem_0.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				Rectangle empty = Rectangle.Empty;
				if (bool_0)
				{
					Rectangle rectangle_ = buttonItem_0.Rectangle_1;
					rectangle_.Offset(buttonItem_0.Bounds.Location);
					empty = buttonItem_0.Bounds;
					if (rectangle_.X == empty.X && rectangle_.Y == empty.Y)
					{
						empty.X += rectangle_.Width;
						empty.Width -= rectangle_.Width;
					}
					else if (rectangle_.X == empty.X && rectangle_.Bottom == empty.Bottom && rectangle_.Y > empty.Y)
					{
						empty.Y += rectangle_.Height;
						empty.Height -= rectangle_.Height;
					}
					else
					{
						empty.Width -= rectangle_.Width;
					}
				}
				else
				{
					empty = buttonItem_0.Rectangle_1;
					empty.Offset(buttonItem_0.Bounds.Location);
				}
				empty.Location = val.PointToScreen(empty.Location);
				return empty;
			}
		}

		public override string DefaultAction
		{
			get
			{
				if (buttonItem_0.AccessibleDefaultActionDescription != "")
				{
					return buttonItem_0.AccessibleDefaultActionDescription;
				}
				if (bool_0)
				{
					return "Press";
				}
				return "Open";
			}
		}

		public override string KeyboardShortcut => buttonItem_0.ShortcutString;

		public ButtonItemPartAccessibleObject(ButtonItem owner, bool pushButtonPart)
		{
			buttonItem_0 = owner;
			bool_0 = pushButtonPart;
		}

		public override int GetChildCount()
		{
			if (bool_0)
			{
				return 0;
			}
			return buttonItem_0.SubItems.Count;
		}

		public override AccessibleObject GetChild(int iIndex)
		{
			if (buttonItem_0 != null && !bool_0)
			{
				return buttonItem_0.SubItems[iIndex].AccessibleObject;
			}
			return null;
		}

		public override void DoDefaultAction()
		{
			if (buttonItem_0 != null)
			{
				if (bool_0)
				{
					buttonItem_0.bool_21 = false;
				}
				else
				{
					buttonItem_0.bool_21 = true;
				}
				object containerControl = buttonItem_0.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val is MenuPanel && !(val is IAccessibilitySupport))
				{
					object containerControl2 = ((MenuPanel)(object)val).ParentItem.ContainerControl;
					val = (Control)((containerControl2 is Control) ? containerControl2 : null);
				}
				if (val is IAccessibilitySupport accessibilitySupport)
				{
					accessibilitySupport.DoDefaultActionItem = buttonItem_0;
					Class92.PostMessage(val.get_Handle().ToInt32(), 1131, 0, 0);
				}
				((AccessibleObject)this).DoDefaultAction();
			}
		}

		public override AccessibleObject GetSelected()
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Invalid comparison between Unknown and I4
			if (buttonItem_0 != null && !bool_0)
			{
				foreach (BaseItem subItem in buttonItem_0.SubItems)
				{
					if ((subItem.AccessibleObject.get_State() & 0x80) == 128)
					{
						return subItem.AccessibleObject;
					}
				}
				return ((AccessibleObject)this).GetSelected();
			}
			return ((AccessibleObject)this).GetSelected();
		}

		public override AccessibleObject HitTest(int x, int y)
		{
			if (buttonItem_0 == null)
			{
				return ((AccessibleObject)this).HitTest(x, y);
			}
			Point point = new Point(x, y);
			foreach (BaseItem subItem in buttonItem_0.SubItems)
			{
				object containerControl = subItem.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val != null)
				{
					Point pt = val.PointToClient(point);
					if (subItem.DisplayRectangle.Contains(pt))
					{
						return subItem.AccessibleObject;
					}
				}
			}
			return ((AccessibleObject)this).HitTest(x, y);
		}

		public override AccessibleObject Navigate(AccessibleNavigation navdir)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Invalid comparison between Unknown and I4
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Invalid comparison between Unknown and I4
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Invalid comparison between Unknown and I4
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Invalid comparison between Unknown and I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Invalid comparison between Unknown and I4
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Invalid comparison between Unknown and I4
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Invalid comparison between Unknown and I4
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Invalid comparison between Unknown and I4
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			if (buttonItem_0 != null && !bool_0)
			{
				BaseItem baseItem = null;
				if ((int)navdir != 2 && (int)navdir != 4 && (int)navdir != 5)
				{
					if ((int)navdir == 7)
					{
						baseItem = method_0(buttonItem_0.SubItems, 0);
					}
					else if ((int)navdir == 8)
					{
						baseItem = method_1(buttonItem_0.SubItems, buttonItem_0.SubItems.Count - 1);
					}
					else if ((int)navdir == 1 || (int)navdir == 3 || (int)navdir == 6)
					{
						BaseItem parent = buttonItem_0.Parent;
						baseItem = method_1(buttonItem_0.SubItems, parent.SubItems.IndexOf(buttonItem_0) - 1);
					}
				}
				else if (buttonItem_0.Parent != null)
				{
					BaseItem parent2 = buttonItem_0.Parent;
					baseItem = method_0(parent2.SubItems, parent2.SubItems.IndexOf(buttonItem_0) + 1);
				}
				if (baseItem != null)
				{
					return baseItem.AccessibleObject;
				}
				return ((AccessibleObject)this).Navigate(navdir);
			}
			return ((AccessibleObject)this).Navigate(navdir);
		}

		private BaseItem method_0(SubItemsCollection subItemsCollection_0, int int_0)
		{
			int count = subItemsCollection_0.Count;
			int num = int_0;
			while (true)
			{
				if (num < count)
				{
					if (subItemsCollection_0[num].Visible)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return subItemsCollection_0[num];
		}

		private BaseItem method_1(SubItemsCollection subItemsCollection_0, int int_0)
		{
			int num = int_0;
			while (true)
			{
				if (num >= 0)
				{
					if (subItemsCollection_0[num].Visible)
					{
						break;
					}
					num--;
					continue;
				}
				return null;
			}
			return subItemsCollection_0[num];
		}
	}

	private const int int_5 = 3;

	private EventHandler eventHandler_19;

	private OptionGroupChangingEventHandler optionGroupChangingEventHandler_0;

	private Image image_0;

	private Image image_1;

	private int int_6;

	private Image image_2;

	private int int_7;

	private Image image_3;

	private bool bool_25;

	private int int_8;

	private Icon icon_0;

	private Image image_4;

	private int int_9;

	private eButtonStyle eButtonStyle_0;

	private eImagePosition eImagePosition_0;

	private Font font_1;

	private string string_7;

	private bool bool_26;

	private bool bool_27;

	private bool bool_28;

	private bool bool_29;

	private Rectangle rectangle_0;

	private Rectangle rectangle_1;

	private Rectangle rectangle_2;

	private int int_10;

	private int int_11;

	private Color color_0 = Color.Empty;

	private Color color_1 = Color.Empty;

	private bool bool_30;

	private bool bool_31;

	private bool bool_32;

	private bool bool_33;

	private bool bool_34;

	private eMenuVisibility eMenuVisibility_0;

	private bool bool_35;

	private eHotTrackingStyle eHotTrackingStyle_0;

	private Image image_5;

	private ItemPaintArgs itemPaintArgs_0;

	private int int_12 = 12;

	private string string_8 = "";

	private Size size_4 = Size.Empty;

	internal bool bool_36;

	private Icon icon_1;

	private bool bool_37;

	private eButtonColor eButtonColor_0 = eButtonColor.Orange;

	private string string_9 = "Orange";

	private int int_13 = 8;

	private int int_14 = 6;

	private string string_10 = "";

	private Size size_5 = Size.Empty;

	private bool bool_38;

	private bool bool_39;

	private int int_15 = 65;

	private int int_16 = 12;

	private bool bool_40;

	private int int_17;

	private int int_18;

	private bool bool_41 = true;

	private bool bool_42 = true;

	private bool bool_43;

	private bool bool_44;

	internal bool bool_45;

	private eButtonImageListSelection eButtonImageListSelection_0 = eButtonImageListSelection.NotSet;

	private Bitmap bitmap_0;

	private int int_19 = 1;

	private int int_20;

	private bool bool_46;

	private ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

	internal bool bool_47 = true;

	private ShapeDescriptor shapeDescriptor_0;

	private bool bool_48 = true;

	[Description("The alignment of the image in relation to text displayed by this item.")]
	[DefaultValue(eImagePosition.Left)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Browsable(true)]
	public virtual eImagePosition ImagePosition
	{
		get
		{
			return eImagePosition_0;
		}
		set
		{
			if (eImagePosition_0 != value)
			{
				eImagePosition_0 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "ImagePosition");
				}
				NeedRecalcSize = true;
				if (Parent != null)
				{
					Parent.NeedRecalcSize = true;
				}
				OnAppearanceChanged();
			}
		}
	}

	[Description("Indicates custom color table name for the button when Office 2007 style is used.")]
	[DevCoBrowsable(false)]
	[Browsable(true)]
	[DefaultValue("")]
	[Category("Appearance")]
	public virtual string CustomColorName
	{
		get
		{
			return string_10;
		}
		set
		{
			string_10 = value;
			Refresh();
		}
	}

	[DevCoBrowsable(false)]
	[Category("Appearance")]
	[Description("Indicates predefined color of button when Office 2007 style is used.")]
	[DefaultValue(eButtonColor.Orange)]
	[Browsable(true)]
	public virtual eButtonColor ColorTable
	{
		get
		{
			return eButtonColor_0;
		}
		set
		{
			if (eButtonColor_0 != value)
			{
				eButtonColor_0 = value;
				string_9 = Enum.GetName(typeof(eButtonColor), eButtonColor_0);
				Refresh();
			}
		}
	}

	[DefaultValue(eButtonStyle.Default)]
	[Description("Determines the style of the button.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	public virtual eButtonStyle ButtonStyle
	{
		get
		{
			return eButtonStyle_0;
		}
		set
		{
			if (eButtonStyle_0 != value)
			{
				eButtonStyle_0 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "ButtonStyle");
				}
				NeedRecalcSize = true;
				if (Displayed && m_Parent != null)
				{
					RecalcSize();
					m_Parent.SubItemSizeChanged(this);
				}
				OnAppearanceChanged();
			}
		}
	}

	[Category("Behavior")]
	[Description("Indicates whether the item will auto-expand (display pop-up menu or toolbar) when clicked.")]
	[Browsable(true)]
	[DefaultValue(false)]
	[DevCoBrowsable(true)]
	public virtual bool AutoExpandOnClick
	{
		get
		{
			return bool_37;
		}
		set
		{
			bool_37 = value;
		}
	}

	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(null)]
	[Description("Specifies the Button icon. Icons support multiple image sizes and alpha blending.")]
	public virtual Icon Icon
	{
		get
		{
			return icon_1;
		}
		set
		{
			NeedRecalcSize = true;
			icon_1 = value;
			OnImageChanged();
			OnAppearanceChanged();
			Refresh();
		}
	}

	[Description("The image that will be displayed on the face of the item.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(null)]
	[Category("Appearance")]
	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			NeedRecalcSize = true;
			image_0 = value;
			OnImageChanged();
			OnAppearanceChanged();
			Refresh();
		}
	}

	[DefaultValue(null)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Description("Specifies the small Button image used by Ribbon control when small image variant is needed")]
	public virtual Image ImageSmall
	{
		get
		{
			return image_1;
		}
		set
		{
			image_1 = value;
			if (!size_4.IsEmpty || Boolean_5)
			{
				NeedRecalcSize = true;
				OnAppearanceChanged();
				OnImageChanged();
				Refresh();
			}
		}
	}

	private bool Boolean_5 => bool_44;

	[Category("Image")]
	[Description("Indicates image size that is used by the button when multiple ImageList controls are used as source for button image.")]
	[DefaultValue(eButtonImageListSelection.NotSet)]
	public virtual eButtonImageListSelection ImageListSizeSelection
	{
		get
		{
			return eButtonImageListSelection_0;
		}
		set
		{
			eButtonImageListSelection_0 = value;
			NeedRecalcSize = true;
			OnImageChanged();
			OnAppearanceChanged();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool UseSmallImage
	{
		get
		{
			return bool_44;
		}
		set
		{
			if (bool_44 != value)
			{
				bool_44 = value;
				if (image_1 != null)
				{
					NeedRecalcSize = true;
					OnImageChanged();
					OnAppearanceChanged();
				}
			}
		}
	}

	[DefaultValue(-1)]
	[TypeConverter(typeof(ImageIndexConverter))]
	[Description("The image list image index of the image that will be displayed on the face of the item.")]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	public int ImageIndex
	{
		get
		{
			return int_6;
		}
		set
		{
			image_5 = null;
			if (int_6 != value)
			{
				int_6 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "ImageIndex");
				}
				if (m_Parent != null)
				{
					OnImageChanged();
					NeedRecalcSize = true;
					Refresh();
				}
				OnAppearanceChanged();
			}
		}
	}

	[DefaultValue(null)]
	[Category("Appearance")]
	[Description("The image that will be displayed when mouse hovers over the item.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public virtual Image HoverImage
	{
		get
		{
			return image_2;
		}
		set
		{
			image_2 = value;
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[DefaultValue(-1)]
	[DevCoBrowsable(true)]
	[TypeConverter(typeof(ImageIndexConverter))]
	[Description("The image list image index of the image that will be displayed when mouse hovers over the item.")]
	public virtual int HoverImageIndex
	{
		get
		{
			return int_7;
		}
		set
		{
			if (int_7 != value)
			{
				int_7 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "HoverImageIndex");
				}
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(null)]
	[Description("The image that will be displayed when item is pressed.")]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	public virtual Image PressedImage
	{
		get
		{
			return image_4;
		}
		set
		{
			image_4 = value;
			OnAppearanceChanged();
		}
	}

	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[TypeConverter(typeof(ImageIndexConverter))]
	[Category("Appearance")]
	[DefaultValue(-1)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("The image list image index of the image that will be displayed when item is pressed.")]
	public virtual int PressedImageIndex
	{
		get
		{
			return int_9;
		}
		set
		{
			if (int_9 != value)
			{
				int_9 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "PressedImageIndex");
				}
				OnAppearanceChanged();
				Refresh();
			}
		}
	}

	[Description("The image that will be displayed when item is disabled.")]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[DefaultValue(null)]
	[Browsable(true)]
	public Image DisabledImage
	{
		get
		{
			if (!bool_25)
			{
				return null;
			}
			return image_3;
		}
		set
		{
			image_3 = value;
			if (value == null)
			{
				bool_25 = false;
			}
			else
			{
				bool_25 = true;
			}
			OnAppearanceChanged();
		}
	}

	[Description("The image list image index of the image that will be displayed when item is disabled.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(-1)]
	[DevCoBrowsable(true)]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[TypeConverter(typeof(ImageIndexConverter))]
	public int DisabledImageIndex
	{
		get
		{
			return int_8;
		}
		set
		{
			if (int_8 != value)
			{
				if (image_3 != null)
				{
					image_3.Dispose();
				}
				image_3 = null;
				int_8 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "DisabledImageIndex");
				}
				Refresh();
			}
		}
	}

	internal bool Boolean_6
	{
		get
		{
			return bool_39;
		}
		set
		{
			bool_39 = value;
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(false)]
	public Size ImageFixedSize
	{
		get
		{
			return size_4;
		}
		set
		{
			size_4 = value;
			OnImageChanged();
			if (m_Parent != null && m_Parent is ImageItem)
			{
				((ImageItem)m_Parent).RefreshImageSize();
			}
		}
	}

	[Category("Layout")]
	[DevCoBrowsable(false)]
	[Browsable(true)]
	[Description("Indicates fixed size of the button.")]
	public virtual Size FixedSize
	{
		get
		{
			return size_5;
		}
		set
		{
			if (value.Width < 0)
			{
				value.Width = 0;
			}
			if (value.Height < 0)
			{
				value.Height = 0;
			}
			size_5 = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
		}
	}

	private Size Size_0
	{
		get
		{
			Size result = new Size(16, 16);
			IBarImageSize barImageSize = null;
			if (itemPaintArgs_0 != null)
			{
				barImageSize = itemPaintArgs_0.ContainerControl as IBarImageSize;
			}
			if (barImageSize == null)
			{
				barImageSize = ContainerControl as IBarImageSize;
			}
			try
			{
				eBarImageSize eBarImageSize2 = method_24(barImageSize);
				if (barImageSize != null)
				{
					switch (eBarImageSize2)
					{
					case eBarImageSize.Medium:
						result = new Size(24, 24);
						return result;
					case eBarImageSize.Large:
						result = new Size(32, 32);
						return result;
					case eBarImageSize.Default:
						break;
					default:
						return result;
					}
				}
				if (m_Parent is SideBarPanelItem)
				{
					if (((SideBarPanelItem)m_Parent).ItemImageSize != 0)
					{
						switch (((SideBarPanelItem)m_Parent).ItemImageSize)
						{
						case eBarImageSize.Medium:
							result = new Size(24, 24);
							return result;
						case eBarImageSize.Large:
							result = new Size(32, 32);
							return result;
						default:
							return result;
						}
					}
					return result;
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}
	}

	private bool Boolean_7
	{
		get
		{
			if (!DesignMode && eHotTrackingStyle_0 != eHotTrackingStyle.None && bool_47 && !Class55.bool_1)
			{
				object containerControl = ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val != null)
				{
					if (val is ItemControl)
					{
						return ((ItemControl)(object)val).Boolean_2;
					}
					if (val is Bar)
					{
						return ((Bar)(object)val).Boolean_15;
					}
					if (val is ButtonX)
					{
						return ((ButtonX)(object)val).Boolean_1;
					}
				}
				return false;
			}
			return false;
		}
	}

	[Browsable(false)]
	public bool IsPulsing => bool_40;

	[DefaultValue(true)]
	[Browsable(true)]
	[Description("Indicates whether pulse effect started with Pulse method stops automatically when mouse moves over the button.")]
	[Category("Behavior")]
	public virtual bool StopPulseOnMouseOver
	{
		get
		{
			return bool_41;
		}
		set
		{
			bool_41 = value;
		}
	}

	[Browsable(true)]
	[Description("Indicates pulse speed. The value must be greater than 0 and less than 128.")]
	[DefaultValue(12)]
	[Category("Behavior")]
	public virtual int PulseSpeed
	{
		get
		{
			return int_16;
		}
		set
		{
			if (value <= 0 || value >= 128)
			{
				throw new ArgumentOutOfRangeException("PulseSpeed value must be greater than 0 and less than 128");
			}
			int_16 = value;
		}
	}

	protected virtual bool ShouldAutoExpandOnClick => bool_37;

	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether Checked property is automatically inverted when button is clicked.")]
	[Category("Behavior")]
	public virtual bool AutoCheckOnClick
	{
		get
		{
			return bool_43;
		}
		set
		{
			bool_43 = value;
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether item is checked or not.")]
	[Bindable(true)]
	[Browsable(true)]
	[Category("Appearance")]
	public virtual bool Checked
	{
		get
		{
			return bool_29;
		}
		set
		{
			if (bool_29 == value)
			{
				return;
			}
			if (value && string_8.Length > 0 && Parent != null)
			{
				ButtonItem buttonItem = null;
				foreach (BaseItem subItem in Parent.SubItems)
				{
					if (subItem != this)
					{
						buttonItem = subItem as ButtonItem;
						if (buttonItem != null && buttonItem.OptionGroup == string_8 && buttonItem.Checked)
						{
							break;
						}
					}
				}
				OptionGroupChangingEventArgs optionGroupChangingEventArgs = new OptionGroupChangingEventArgs(buttonItem, this);
				InvokeOptionGroupChanging(optionGroupChangingEventArgs);
				if (optionGroupChangingEventArgs.Cancel)
				{
					return;
				}
			}
			bool_29 = value;
			if (ShouldSyncProperties)
			{
				Class109.smethod_22(this, "Checked");
			}
			OnCheckedChanged();
			if (Displayed)
			{
				Refresh();
			}
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[Description("Gets or set the alternative Shortcut Text.  This text appears next to the Text instead of any shortcuts")]
	[DevCoBrowsable(true)]
	[Category("Design")]
	[DefaultValue("")]
	public virtual string AlternateShortCutText
	{
		get
		{
			return string_7;
		}
		set
		{
			string_7 = value;
			OnAppearanceChanged();
		}
	}

	internal string String_1
	{
		get
		{
			if (AlternateShortCutText != "")
			{
				return AlternateShortCutText;
			}
			return base.ShortcutString;
		}
	}

	internal new Rectangle Rectangle_0
	{
		get
		{
			return rectangle_0;
		}
		set
		{
			rectangle_0 = value;
		}
	}

	internal Rectangle Rectangle_1
	{
		get
		{
			return rectangle_2;
		}
		set
		{
			rectangle_2 = value;
		}
	}

	internal Rectangle Rectangle_2
	{
		get
		{
			return rectangle_1;
		}
		set
		{
			rectangle_1 = value;
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Gets or set the Group item belongs to. The groups allows a user to choose from mutually exclusive options within the group.")]
	[DefaultValue("")]
	[Category("Behavior")]
	public virtual string OptionGroup
	{
		get
		{
			return string_8;
		}
		set
		{
			if (!(string_8 != value))
			{
				return;
			}
			string_8 = value;
			if (string_8 != "" && bool_29 && Parent != null)
			{
				foreach (BaseItem subItem in Parent.SubItems)
				{
					if (subItem != this && subItem is ButtonItem buttonItem && buttonItem.OptionGroup == string_8 && buttonItem.Checked)
					{
						Checked = false;
					}
				}
			}
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[Description("The foreground color used to display text.")]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	public virtual Color ForeColor
	{
		get
		{
			return color_0;
		}
		set
		{
			if (color_0 != value)
			{
				color_0 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "ForeColor");
				}
				if (Displayed)
				{
					Refresh();
				}
				OnAppearanceChanged();
			}
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("The foreground color used to display text when mouse is over the item.")]
	public virtual Color HotForeColor
	{
		get
		{
			return color_1;
		}
		set
		{
			if (color_1 != value)
			{
				color_1 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "HotForeColor");
				}
				if (Displayed && bool_26)
				{
					Refresh();
				}
				OnAppearanceChanged();
			}
		}
	}

	[Description("Specifies that text font is underlined when mouse is over the item.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[DefaultValue(false)]
	public virtual bool HotFontUnderline
	{
		get
		{
			return bool_30;
		}
		set
		{
			if (bool_30 != value)
			{
				bool_30 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "HotFontUnderline");
				}
				if (Displayed && bool_26)
				{
					Refresh();
				}
				OnAppearanceChanged();
			}
		}
	}

	[DefaultValue(false)]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Description("Specifies that text font is bold when mouse is over the item.")]
	[Browsable(true)]
	public virtual bool HotFontBold
	{
		get
		{
			return bool_31;
		}
		set
		{
			if (bool_31 != value)
			{
				bool_31 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "HotFontBold");
				}
				if (Displayed && bool_26)
				{
					Refresh();
				}
				OnAppearanceChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(false)]
	[Description("Specifies whether the font used to draw the item text is bold.")]
	public virtual bool FontBold
	{
		get
		{
			return bool_32;
		}
		set
		{
			if (bool_32 != value)
			{
				bool_32 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "FontBold");
				}
				if (Displayed)
				{
					Refresh();
				}
				OnAppearanceChanged();
			}
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Specifies whether the font used to draw the item text is italic.")]
	[Category("Appearance")]
	[DefaultValue(false)]
	public virtual bool FontItalic
	{
		get
		{
			return bool_33;
		}
		set
		{
			if (bool_33 != value)
			{
				bool_33 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "FontItalic");
				}
				if (Displayed)
				{
					Refresh();
				}
				OnAppearanceChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("Specifies whether the font used to draw the item text is underlined.")]
	public virtual bool FontUnderline
	{
		get
		{
			return bool_34;
		}
		set
		{
			if (bool_34 != value)
			{
				bool_34 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "FontUnderline");
				}
				if (Displayed)
				{
					Refresh();
				}
				OnAppearanceChanged();
			}
		}
	}

	[Category("Behavior")]
	[DefaultValue(12)]
	[Description("Indicates the width of the expand part of the button item.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public virtual int SubItemsExpandWidth
	{
		get
		{
			return int_12;
		}
		set
		{
			int_12 = value;
			NeedRecalcSize = true;
			if (DesignMode)
			{
				Refresh();
			}
			OnAppearanceChanged();
		}
	}

	[Description("Collection of sub items.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(false)]
	[Editor(typeof(ButtonItemEditor), typeof(UITypeEditor))]
	[Category("Data")]
	[Browsable(true)]
	public override SubItemsCollection SubItems => base.SubItems;

	[Description("Indicates whether button appears as split button.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(false)]
	public virtual bool SplitButton
	{
		get
		{
			return bool_38;
		}
		set
		{
			bool_38 = value;
			OnAppearanceChanged();
		}
	}

	[Description("The text contained in the item.")]
	[DefaultValue("")]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Localizable(true)]
	[Browsable(true)]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
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

	internal int Int32_1
	{
		get
		{
			return int_10;
		}
		set
		{
			int_10 = value;
		}
	}

	internal int Int32_2
	{
		get
		{
			return int_11;
		}
		set
		{
			int_11 = value;
		}
	}

	[Description("Indicates amount of padding added horizontally to the button images when not on menus")]
	[Category("Layout")]
	[Browsable(true)]
	[DefaultValue(10)]
	public virtual int ImagePaddingHorizontal
	{
		get
		{
			return int_13;
		}
		set
		{
			int_13 = value;
			OnAppearanceChanged();
		}
	}

	[Description("Indicates amount of padding added vertically to the button images when not on menus")]
	[Browsable(true)]
	[DefaultValue(6)]
	[Category("Layout")]
	public virtual int ImagePaddingVertical
	{
		get
		{
			return int_14;
		}
		set
		{
			int_14 = value;
			OnAppearanceChanged();
		}
	}

	[Editor(typeof(ShapeTypeEditor), typeof(UITypeEditor))]
	[DefaultValue(null)]
	[MergableProperty(false)]
	[TypeConverter(typeof(ShapeStringConverter))]
	public virtual ShapeDescriptor Shape
	{
		get
		{
			return shapeDescriptor_0;
		}
		set
		{
			if (shapeDescriptor_0 != value)
			{
				shapeDescriptor_0 = value;
				OnAppearanceChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Indicates item's visiblity when on pop-up menu.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(eMenuVisibility.VisibleAlways)]
	public virtual eMenuVisibility MenuVisibility
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool RecentlyUsed
	{
		get
		{
			return bool_35;
		}
		set
		{
			if (bool_35 != value)
			{
				bool_35 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "RecentlyUsed");
				}
				OnAppearanceChanged();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool IsMouseOver => bool_26;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool IsMouseOverExpand => bool_27;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool IsMouseDown => bool_28;

	[Description("Indicates the way item is painting the picture when mouse is over it. Setting the value to Color will render the image in gray-scale when mouse is not over the item.")]
	[DefaultValue(eHotTrackingStyle.Default)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	public virtual eHotTrackingStyle HotTrackingStyle
	{
		get
		{
			return eHotTrackingStyle_0;
		}
		set
		{
			if (eHotTrackingStyle_0 != value)
			{
				eHotTrackingStyle_0 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "HotTrackingStyle");
				}
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ImageList ImageList
	{
		get
		{
			if (GetOwner() is IOwner owner)
			{
				return owner.Images;
			}
			return null;
		}
	}

	[Browsable(true)]
	[Category("Ribbon")]
	[Localizable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether the button text is automatically wrapped over multiple lines when button is used on RibbonBar control.")]
	public virtual bool RibbonWordWrap
	{
		get
		{
			return bool_42;
		}
		set
		{
			if (bool_42 != value)
			{
				bool_42 = value;
				OnAppearanceChanged();
			}
		}
	}

	protected override bool IsMarkupSupported => bool_48;

	[Category("Appearance")]
	[DefaultValue(true)]
	[Description("Indicates whether text-markup support is enabled for items Text property.")]
	public bool EnableMarkup
	{
		get
		{
			return bool_48;
		}
		set
		{
			if (bool_48 != value)
			{
				bool_48 = value;
				NeedRecalcSize = true;
				OnTextChanged();
			}
		}
	}

	public event EventHandler CheckedChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_19 = (EventHandler)Delegate.Combine(eventHandler_19, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_19 = (EventHandler)Delegate.Remove(eventHandler_19, value);
		}
	}

	public event OptionGroupChangingEventHandler OptionGroupChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			optionGroupChangingEventHandler_0 = (OptionGroupChangingEventHandler)Delegate.Combine(optionGroupChangingEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			optionGroupChangingEventHandler_0 = (OptionGroupChangingEventHandler)Delegate.Remove(optionGroupChangingEventHandler_0, value);
		}
	}

	public ButtonItem()
		: this("", "")
	{
	}

	public ButtonItem(string sItemName)
		: this(sItemName, "")
	{
	}

	public ButtonItem(string sItemName, string ItemText)
		: base(sItemName, ItemText)
	{
		m_IsContainer = false;
		image_0 = null;
		int_6 = -1;
		image_2 = null;
		int_7 = -1;
		image_3 = null;
		int_8 = -1;
		image_4 = null;
		int_9 = -1;
		bool_26 = false;
		bool_28 = false;
		eButtonStyle_0 = eButtonStyle.Default;
		eImagePosition_0 = eImagePosition.Left;
		font_1 = null;
		rectangle_0 = Rectangle.Empty;
		rectangle_1 = Rectangle.Empty;
		rectangle_2 = Rectangle.Empty;
		int_10 = 0;
		int_11 = 0;
		string_7 = "";
	}

	public override BaseItem Copy()
	{
		ButtonItem buttonItem = new ButtonItem(m_Name);
		CopyToItem(buttonItem);
		return buttonItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		ButtonItem buttonItem = copy as ButtonItem;
		base.CopyToItem((BaseItem)buttonItem);
		if (image_0 != null)
		{
			buttonItem.Image = (Image)image_0.Clone();
		}
		if (image_1 != null)
		{
			buttonItem.ImageSmall = (Image)image_1.Clone();
		}
		if (image_2 != null)
		{
			buttonItem.HoverImage = (Image)image_2.Clone();
		}
		if (image_4 != null)
		{
			buttonItem.PressedImage = (Image)image_4.Clone();
		}
		if (image_3 != null && bool_25)
		{
			buttonItem.DisabledImage = (Image)image_3.Clone();
		}
		if (icon_1 != null)
		{
			object obj = icon_1.Clone();
			buttonItem.Icon = (Icon)((obj is Icon) ? obj : null);
		}
		buttonItem.ButtonStyle = eButtonStyle_0;
		buttonItem.ImagePosition = eImagePosition_0;
		buttonItem.OptionGroup = string_8;
		buttonItem.Checked = bool_29;
		buttonItem.PopupType = PopupType;
		buttonItem.AlternateShortCutText = AlternateShortCutText;
		if (int_6 >= 0)
		{
			buttonItem.method_18(int_6);
		}
		if (int_9 >= 0)
		{
			buttonItem.PressedImageIndex = int_9;
		}
		if (int_7 >= 0)
		{
			buttonItem.HoverImageIndex = int_7;
		}
		if (int_8 >= 0)
		{
			buttonItem.DisabledImageIndex = int_8;
		}
		if (!color_0.IsEmpty)
		{
			buttonItem.ForeColor = color_0;
		}
		buttonItem.HotFontBold = bool_31;
		buttonItem.HotFontUnderline = bool_30;
		if (!color_1.IsEmpty)
		{
			buttonItem.HotForeColor = color_1;
		}
		buttonItem.HotTrackingStyle = eHotTrackingStyle_0;
		buttonItem.MenuVisibility = eMenuVisibility_0;
		buttonItem.AutoExpandOnClick = AutoExpandOnClick;
		buttonItem.AlternateShortCutText = AlternateShortCutText;
		buttonItem.SubItemsExpandWidth = SubItemsExpandWidth;
		buttonItem.eventHandler_19 = eventHandler_19;
		buttonItem.optionGroupChangingEventHandler_0 = optionGroupChangingEventHandler_0;
		if (!ImageFixedSize.IsEmpty)
		{
			buttonItem.ImageFixedSize = ImageFixedSize;
		}
		buttonItem.ImagePaddingHorizontal = int_13;
		buttonItem.ImagePaddingVertical = int_14;
		buttonItem.FixedSize = FixedSize;
		buttonItem.RibbonWordWrap = RibbonWordWrap;
		buttonItem.AutoCheckOnClick = AutoCheckOnClick;
		if (Shape != null)
		{
			buttonItem.Shape = Shape;
		}
		buttonItem.ColorTable = ColorTable;
		buttonItem.CustomColorName = CustomColorName;
	}

	public override void Dispose()
	{
		method_31();
		StopPulse();
		base.Dispose();
	}

	protected override AccessibleObject CreateAccessibilityInstance()
	{
		return (AccessibleObject)(object)new ButtonItemAccessibleObject(this);
	}

	protected internal override void Serialize(ItemSerializationContext context)
	{
		base.Serialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		itemXmlElement.SetAttribute("ImagePosition", XmlConvert.ToString((int)eImagePosition_0));
		itemXmlElement.SetAttribute("ButtonStyle", XmlConvert.ToString((int)eButtonStyle_0));
		itemXmlElement.SetAttribute("Checked", XmlConvert.ToString(bool_29));
		itemXmlElement.SetAttribute("VerticalPadding", XmlConvert.ToString(int_10));
		itemXmlElement.SetAttribute("HorizontalPadding", XmlConvert.ToString(int_11));
		itemXmlElement.SetAttribute("MenuVisibility", XmlConvert.ToString((int)eMenuVisibility_0));
		itemXmlElement.SetAttribute("RecentlyUsed", XmlConvert.ToString(bool_35));
		if (string_7 != "")
		{
			itemXmlElement.SetAttribute("AlternateShortcutText", string_7);
		}
		if (!color_0.IsEmpty)
		{
			itemXmlElement.SetAttribute("forecolor", Class109.smethod_50(color_0));
		}
		if (eHotTrackingStyle_0 != 0)
		{
			itemXmlElement.SetAttribute("hottrack", XmlConvert.ToString((int)eHotTrackingStyle_0));
		}
		if (bool_31)
		{
			itemXmlElement.SetAttribute("hotfb", XmlConvert.ToString(bool_31));
		}
		if (bool_30)
		{
			itemXmlElement.SetAttribute("hotfu", XmlConvert.ToString(bool_30));
		}
		if (!color_1.IsEmpty)
		{
			itemXmlElement.SetAttribute("hotclr", Class109.smethod_50(color_1));
		}
		if (string_8 != "")
		{
			itemXmlElement.SetAttribute("optiongroup", string_8);
		}
		if (bool_32)
		{
			itemXmlElement.SetAttribute("fontbold", XmlConvert.ToString(bool_32));
		}
		if (bool_33)
		{
			itemXmlElement.SetAttribute("fontitalic", XmlConvert.ToString(bool_33));
		}
		if (bool_34)
		{
			itemXmlElement.SetAttribute("fontunderline", XmlConvert.ToString(bool_34));
		}
		if (bool_37)
		{
			itemXmlElement.SetAttribute("autoexpandclick", XmlConvert.ToString(bool_37));
		}
		if (string_10 != "")
		{
			itemXmlElement.SetAttribute("CustomColorName", string_10);
		}
		if (eButtonColor_0 != eButtonColor.Orange)
		{
			itemXmlElement.SetAttribute("ColorTable", Enum.GetName(eButtonColor_0.GetType(), eButtonColor_0));
		}
		XmlElement xmlElement = null;
		XmlElement xmlElement2 = null;
		if (image_0 != null || int_6 >= 0 || image_2 != null || int_7 >= 0 || image_3 != null || int_8 >= 0 || image_4 != null || int_9 >= 0 || icon_1 != null || image_1 != null)
		{
			xmlElement = itemXmlElement.OwnerDocument.CreateElement("images");
			itemXmlElement.AppendChild(xmlElement);
			if (int_6 >= 0)
			{
				xmlElement.SetAttribute("imageindex", XmlConvert.ToString(int_6));
			}
			if (int_7 >= 0)
			{
				xmlElement.SetAttribute("hoverimageindex", XmlConvert.ToString(int_7));
			}
			if (int_8 >= 0)
			{
				xmlElement.SetAttribute("disabledimageindex", XmlConvert.ToString(int_8));
			}
			if (int_9 >= 0)
			{
				xmlElement.SetAttribute("pressedimageindex", XmlConvert.ToString(int_9));
			}
			if (image_0 != null)
			{
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("image");
				xmlElement2.SetAttribute("type", "default");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_13(image_0, xmlElement2);
			}
			if (image_1 != null)
			{
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("imagesmall");
				xmlElement2.SetAttribute("type", "small");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_13(image_1, xmlElement2);
			}
			if (image_2 != null)
			{
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("image");
				xmlElement2.SetAttribute("type", "hover");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_13(image_2, xmlElement2);
			}
			if (image_3 != null && bool_25)
			{
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("image");
				xmlElement2.SetAttribute("type", "disabled");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_13(image_3, xmlElement2);
			}
			if (image_4 != null)
			{
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("image");
				xmlElement2.SetAttribute("type", "pressed");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_13(image_4, xmlElement2);
			}
			if (icon_1 != null)
			{
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("image");
				xmlElement2.SetAttribute("type", "icon");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_14(icon_1, xmlElement2);
			}
		}
	}

	protected internal override void Deserialize(ItemSerializationContext context)
	{
		base.Deserialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		eImagePosition_0 = (eImagePosition)XmlConvert.ToInt32(itemXmlElement.GetAttribute("ImagePosition"));
		eButtonStyle_0 = (eButtonStyle)XmlConvert.ToInt32(itemXmlElement.GetAttribute("ButtonStyle"));
		bool_29 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("Checked"));
		int_10 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("VerticalPadding"));
		int_11 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("HorizontalPadding"));
		eMenuVisibility_0 = (eMenuVisibility)XmlConvert.ToInt32(itemXmlElement.GetAttribute("MenuVisibility"));
		bool_35 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("RecentlyUsed"));
		if (itemXmlElement.HasAttribute("forecolor"))
		{
			color_0 = Class109.smethod_51(itemXmlElement.GetAttribute("forecolor"));
		}
		else
		{
			color_0 = Color.Empty;
		}
		if (itemXmlElement.HasAttribute("hottrack"))
		{
			eHotTrackingStyle_0 = (eHotTrackingStyle)XmlConvert.ToInt32(itemXmlElement.GetAttribute("hottrack"));
		}
		else
		{
			eHotTrackingStyle_0 = eHotTrackingStyle.Default;
		}
		if (itemXmlElement.HasAttribute("hotclr"))
		{
			color_1 = Class109.smethod_51(itemXmlElement.GetAttribute("hotclr"));
		}
		else
		{
			color_1 = Color.Empty;
		}
		if (itemXmlElement.HasAttribute("hotfb"))
		{
			bool_31 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("hotfb"));
		}
		else
		{
			bool_31 = false;
		}
		if (itemXmlElement.HasAttribute("hotfu"))
		{
			bool_30 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("hotfu"));
		}
		else
		{
			bool_30 = false;
		}
		if (itemXmlElement.HasAttribute("optiongroup"))
		{
			string_8 = itemXmlElement.GetAttribute("optiongroup");
		}
		else
		{
			string_8 = "";
		}
		if (itemXmlElement.HasAttribute("fontbold"))
		{
			bool_32 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("fontbold"));
		}
		else
		{
			bool_32 = false;
		}
		if (itemXmlElement.HasAttribute("fontitalic"))
		{
			bool_33 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("fontitalic"));
		}
		else
		{
			bool_33 = false;
		}
		if (itemXmlElement.HasAttribute("fontunderline"))
		{
			bool_34 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("fontunderline"));
		}
		else
		{
			bool_34 = false;
		}
		if (itemXmlElement.HasAttribute("AlternateShortcutText"))
		{
			string_7 = itemXmlElement.GetAttribute("AlternateShortcutText");
		}
		else
		{
			string_7 = "";
		}
		if (itemXmlElement.HasAttribute("autoexpandclick"))
		{
			bool_37 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("autoexpandclick"));
		}
		else
		{
			bool_37 = false;
		}
		if (itemXmlElement.HasAttribute("CustomColorName"))
		{
			string_10 = itemXmlElement.GetAttribute("CustomColorName");
		}
		else
		{
			string_10 = "";
		}
		if (itemXmlElement.HasAttribute("ColorTable"))
		{
			eButtonColor_0 = (eButtonColor)Enum.Parse(eButtonColor_0.GetType(), itemXmlElement.GetAttribute("ColorTable"));
		}
		else
		{
			eButtonColor_0 = eButtonColor.Orange;
		}
		int_6 = -1;
		int_7 = -1;
		int_8 = -1;
		int_9 = -1;
		icon_1 = null;
		image_0 = null;
		image_1 = null;
		image_2 = null;
		image_3 = null;
		bool_25 = false;
		image_4 = null;
		foreach (XmlElement childNode in itemXmlElement.ChildNodes)
		{
			if (!(childNode.Name == "images"))
			{
				continue;
			}
			if (childNode.HasAttribute("imageindex"))
			{
				int_6 = XmlConvert.ToInt32(childNode.GetAttribute("imageindex"));
			}
			if (childNode.HasAttribute("hoverimageindex"))
			{
				int_7 = XmlConvert.ToInt32(childNode.GetAttribute("hoverimageindex"));
			}
			if (childNode.HasAttribute("disabledimageindex"))
			{
				int_8 = XmlConvert.ToInt32(childNode.GetAttribute("disabledimageindex"));
			}
			if (childNode.HasAttribute("pressedimageindex"))
			{
				int_9 = XmlConvert.ToInt32(childNode.GetAttribute("pressedimageindex"));
			}
			foreach (XmlElement childNode2 in childNode.ChildNodes)
			{
				switch (childNode2.GetAttribute("type"))
				{
				case "small":
					image_1 = Class109.smethod_16(childNode2);
					break;
				case "pressed":
					image_4 = Class109.smethod_16(childNode2);
					int_9 = -1;
					break;
				case "disabled":
					image_3 = Class109.smethod_16(childNode2);
					int_8 = -1;
					bool_25 = true;
					break;
				case "hover":
					image_2 = Class109.smethod_16(childNode2);
					int_7 = -1;
					break;
				case "icon":
					icon_1 = Class109.smethod_17(childNode2);
					int_6 = -1;
					break;
				case "default":
					image_0 = Class109.smethod_16(childNode2);
					int_6 = -1;
					break;
				}
			}
			break;
		}
		OnImageChanged();
	}

	internal virtual string vmethod_1()
	{
		return string_9;
	}

	internal void method_18(int int_21)
	{
		int_6 = int_21;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void OnImageChanged()
	{
		base.OnImageChanged();
		if (image_3 != null && !bool_25)
		{
			image_3.Dispose();
			image_3 = null;
		}
		if (icon_0 != null)
		{
			icon_0.Dispose();
			icon_0 = null;
		}
		Class271 @class = method_23(Enum15.const_0);
		if (@class != null)
		{
			if (image_0 != null)
			{
				IBarImageSize barImageSize = null;
				if (itemPaintArgs_0 != null)
				{
					barImageSize = itemPaintArgs_0.ContainerControl as IBarImageSize;
				}
				if (barImageSize == null)
				{
					barImageSize = ContainerControl as IBarImageSize;
				}
				eBarImageSize eBarImageSize2 = method_24(barImageSize);
				if (barImageSize != null && eBarImageSize2 != 0)
				{
					if (eBarImageSize2 == eBarImageSize.Medium)
					{
						ImageSize = new Size(32, 32);
					}
					else
					{
						ImageSize = new Size(48, 48);
					}
				}
				else
				{
					ImageSize = new Size(@class.Int32_0, @class.Int32_1);
				}
			}
			else
			{
				ImageSize = new Size(@class.Int32_0, @class.Int32_1);
			}
			@class.Dispose();
		}
		else
		{
			ImageSize = ImageItem.size_2;
		}
		if (m_Parent != null && m_Parent is ImageItem imageItem)
		{
			imageItem.RefreshSubItemImageSize();
		}
	}

	protected internal override void OnContainerChanged(object objOldContainer)
	{
		if (DesignMode || ((int_6 >= 0 || icon_1 != null) && ImageSize.Width == ImageItem.size_2.Width && ImageSize.Height == ImageItem.size_2.Height))
		{
			OnImageChanged();
		}
		base.OnContainerChanged(objOldContainer);
	}

	public override void Paint(ItemPaintArgs p)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		if (SuspendLayout)
		{
			return;
		}
		bool flag = bool_26;
		readerWriterLock_0.AcquireReaderLock(-1);
		try
		{
			if (bitmap_0 != null)
			{
				bool_26 = false;
			}
			try
			{
				itemPaintArgs_0 = p;
				if (m_Style == eDotNetBarStyle.Office2000 && !base.Boolean_2)
				{
					method_21(p);
				}
				else
				{
					RenderButton(p);
					if (bitmap_0 != null && !bool_39)
					{
						Graphics graphics = p.Graphics;
						Rectangle displayRectangle = DisplayRectangle;
						ColorMatrix val = new ColorMatrix();
						val.set_Item(3, 3, (float)int_20 / 255f);
						ImageAttributes val2 = new ImageAttributes();
						val2.SetColorMatrix(val);
						graphics.DrawImage((Image)(object)bitmap_0, displayRectangle, 0, 0, displayRectangle.Width, displayRectangle.Height, (GraphicsUnit)2, val2);
						return;
					}
				}
			}
			finally
			{
				itemPaintArgs_0 = null;
				bool_26 = flag;
			}
		}
		finally
		{
			readerWriterLock_0.ReleaseReaderLock();
		}
		DrawInsertMarker(p.Graphics);
	}

	protected virtual void RenderButton(ItemPaintArgs p)
	{
		BaseRenderer baseRenderer_ = p.BaseRenderer_0;
		if (baseRenderer_ != null)
		{
			p.ButtonItemRendererEventArgs.Graphics = p.Graphics;
			p.ButtonItemRendererEventArgs.ButtonItem = this;
			p.ButtonItemRendererEventArgs.itemPaintArgs_0 = p;
			baseRenderer_.DrawButtonItem(p.ButtonItemRendererEventArgs);
			return;
		}
		Class265 @class = Class274.smethod_0(this);
		if (@class != null)
		{
			@class.PaintButton(this, p);
		}
		else if (m_Style == eDotNetBarStyle.Office2000)
		{
			method_21(p);
		}
		else
		{
			method_19(p);
		}
	}

	private void method_19(ItemPaintArgs itemPaintArgs_1)
	{
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected O, but got Unknown
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected O, but got Unknown
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected O, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected O, but got Unknown
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6f: Expected O, but got Unknown
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb8: Expected O, but got Unknown
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected O, but got Unknown
		//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3c: Expected O, but got Unknown
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de4: Expected O, but got Unknown
		//IL_0e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e14: Expected O, but got Unknown
		//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef7: Expected O, but got Unknown
		//IL_0f20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f27: Expected O, but got Unknown
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fef: Expected O, but got Unknown
		//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff6: Expected O, but got Unknown
		//IL_11a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Expected O, but got Unknown
		//IL_13d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13da: Expected O, but got Unknown
		//IL_148a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1491: Expected O, but got Unknown
		//IL_1491: Unknown result type (might be due to invalid IL or missing references)
		//IL_1498: Expected O, but got Unknown
		//IL_1547: Unknown result type (might be due to invalid IL or missing references)
		//IL_154e: Expected O, but got Unknown
		//IL_1717: Unknown result type (might be due to invalid IL or missing references)
		//IL_171e: Expected O, but got Unknown
		//IL_17a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ae: Expected O, but got Unknown
		//IL_17cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d2: Expected O, but got Unknown
		//IL_1a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8c: Expected O, but got Unknown
		//IL_1ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad0: Expected O, but got Unknown
		//IL_1b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b41: Expected O, but got Unknown
		//IL_1b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7b: Expected O, but got Unknown
		//IL_2002: Unknown result type (might be due to invalid IL or missing references)
		//IL_2009: Expected O, but got Unknown
		//IL_208a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2091: Expected O, but got Unknown
		//IL_20e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f0: Expected O, but got Unknown
		//IL_2647: Unknown result type (might be due to invalid IL or missing references)
		//IL_264e: Expected O, but got Unknown
		//IL_2672: Unknown result type (might be due to invalid IL or missing references)
		//IL_2679: Expected O, but got Unknown
		bool isOnMenu = itemPaintArgs_1.IsOnMenu;
		bool isOnMenuBar = itemPaintArgs_1.IsOnMenuBar;
		bool boolean_ = base.Boolean_2;
		if (!isOnMenu && !isOnMenuBar && boolean_)
		{
			ThemedButtonItemPainter.PaintButton(this, itemPaintArgs_1);
			return;
		}
		bool flag = bool_26;
		if (isOnMenu && Expanded && itemPaintArgs_1.ContainerControl != null && itemPaintArgs_1.ContainerControl.get_Parent() != null && !itemPaintArgs_1.ContainerControl.get_Parent().get_Bounds().Contains(Control.get_MousePosition()))
		{
			flag = true;
		}
		Graphics graphics = itemPaintArgs_1.Graphics;
		Rectangle rectangle = Rectangle.Empty;
		Rectangle rectangle2 = new Rectangle(m_Rect.X, m_Rect.Y, m_Rect.Width, m_Rect.Height);
		Color empty = Color.Empty;
		empty = ((flag && !color_1.IsEmpty) ? color_1 : ((!color_0.IsEmpty) ? color_0 : ((flag && !m_Expanded && eHotTrackingStyle_0 != eHotTrackingStyle.Image) ? itemPaintArgs_1.Colors.ItemHotText : (m_Expanded ? itemPaintArgs_1.Colors.ItemExpandedText : ((!boolean_ || !isOnMenuBar || !(itemPaintArgs_1.Colors.ItemText == SystemColors.ControlText)) ? itemPaintArgs_1.Colors.ItemText : SystemColors.MenuText)))));
		Font val = null;
		eTextFormat eTextFormat2 = itemPaintArgs_1.ButtonStringFormat;
		Class271 @class = method_22();
		Size empty2 = Size.Empty;
		val = ((font_1 == null) ? method_40(itemPaintArgs_1) : font_1);
		if (@class != null)
		{
			empty2 = ImageSize;
			rectangle = ((isOnMenu || (eImagePosition_0 != eImagePosition.Top && eImagePosition_0 != eImagePosition.Bottom)) ? new Rectangle(rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height) : new Rectangle(rectangle_0.X, rectangle_0.Y, rectangle2.Width, rectangle_0.Height));
			rectangle.Offset(rectangle2.Left, rectangle2.Top);
			rectangle.Offset((rectangle.Width - empty2.Width) / 2, (rectangle.Height - empty2.Height) / 2);
			rectangle.Width = empty2.Width;
			rectangle.Height = empty2.Height;
		}
		if (isOnMenu)
		{
			if (MenuVisibility == eMenuVisibility.VisibleIfRecentlyUsed && !RecentlyUsed)
			{
				if (!itemPaintArgs_1.Colors.MenuUnusedSide2.IsEmpty)
				{
					LinearGradientBrush val2 = Class109.smethod_40(new Rectangle(m_Rect.Left, m_Rect.Top, rectangle_0.Right, m_Rect.Height), itemPaintArgs_1.Colors.MenuUnusedSide, itemPaintArgs_1.Colors.MenuUnusedSide2, itemPaintArgs_1.Colors.MenuUnusedSideGradientAngle);
					graphics.FillRectangle((Brush)(object)val2, m_Rect.Left, m_Rect.Top, rectangle_0.Right, m_Rect.Height);
					((Brush)val2).Dispose();
				}
				else
				{
					SolidBrush val3 = new SolidBrush(itemPaintArgs_1.Colors.MenuUnusedSide);
					try
					{
						graphics.FillRectangle((Brush)(object)val3, m_Rect.Left, m_Rect.Top, rectangle_0.Right, m_Rect.Height);
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
				}
			}
			else if (!itemPaintArgs_1.Colors.MenuSide2.IsEmpty)
			{
				LinearGradientBrush val4 = Class109.smethod_40(new Rectangle(m_Rect.Left, m_Rect.Top, rectangle_0.Right, m_Rect.Height), itemPaintArgs_1.Colors.MenuSide, itemPaintArgs_1.Colors.MenuSide2, itemPaintArgs_1.Colors.MenuSideGradientAngle);
				graphics.FillRectangle((Brush)(object)val4, m_Rect.Left, m_Rect.Top, rectangle_0.Right, m_Rect.Height);
				((Brush)val4).Dispose();
			}
			else
			{
				SolidBrush val5 = new SolidBrush(itemPaintArgs_1.Colors.MenuSide);
				try
				{
					graphics.FillRectangle((Brush)(object)val5, m_Rect.Left, m_Rect.Top, rectangle_0.Right, m_Rect.Height);
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
			}
		}
		else if (!itemPaintArgs_1.Colors.ItemBackground.IsEmpty)
		{
			if (itemPaintArgs_1.Colors.ItemBackground2.IsEmpty)
			{
				SolidBrush val6 = new SolidBrush(itemPaintArgs_1.Colors.ItemBackground);
				try
				{
					graphics.FillRectangle((Brush)(object)val6, m_Rect);
				}
				finally
				{
					((IDisposable)val6)?.Dispose();
				}
			}
			else
			{
				LinearGradientBrush val7 = Class109.smethod_40(DisplayRectangle, itemPaintArgs_1.Colors.ItemBackground, itemPaintArgs_1.Colors.ItemBackground2, itemPaintArgs_1.Colors.ItemBackgroundGradientAngle);
				try
				{
					graphics.FillRectangle((Brush)(object)val7, DisplayRectangle);
				}
				finally
				{
					((IDisposable)val7)?.Dispose();
				}
			}
		}
		else if (!method_1(itemPaintArgs_1.ContainerControl) && !itemPaintArgs_1.Colors.ItemDisabledBackground.IsEmpty)
		{
			SolidBrush val8 = new SolidBrush(itemPaintArgs_1.Colors.ItemDisabledBackground);
			try
			{
				graphics.FillRectangle((Brush)(object)val8, m_Rect);
			}
			finally
			{
				((IDisposable)val8)?.Dispose();
			}
		}
		if (!method_1(itemPaintArgs_1.ContainerControl) && !DesignMode)
		{
			if (isOnMenu && flag && eHotTrackingStyle_0 == eHotTrackingStyle.Default)
			{
				Rectangle rectangle3 = new Rectangle(rectangle2.Left + 1, rectangle2.Top, rectangle2.Width - 2, rectangle2.Height);
				Pen val9 = new Pen(itemPaintArgs_1.Colors.ItemHotBorder, 1f);
				try
				{
					Class92.smethod_4(graphics, val9, rectangle3);
				}
				finally
				{
					((IDisposable)val9)?.Dispose();
				}
			}
			if (bool_29 && !base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog)
			{
				Rectangle rectangle4;
				if (isOnMenu)
				{
					rectangle4 = new Rectangle(m_Rect.X + 1, m_Rect.Y, rectangle_0.Width - 2, m_Rect.Height);
				}
				else if (eHotTrackingStyle_0 == eHotTrackingStyle.Image)
				{
					rectangle4 = rectangle;
					rectangle4.Inflate(2, 2);
				}
				else
				{
					rectangle4 = new Rectangle(m_Rect.X, m_Rect.Y, m_Rect.Width, m_Rect.Height);
				}
				if (isOnMenu)
				{
					rectangle4.Inflate(-1, -1);
				}
				if (isOnMenu || !Expanded)
				{
					Color itemDisabledText = itemPaintArgs_1.Colors.ItemDisabledText;
					Pen val10 = new Pen(itemDisabledText, 1f);
					Class92.smethod_4(graphics, val10, rectangle4);
					val10.Dispose();
				}
				if ((@class == null || eButtonStyle_0 == eButtonStyle.TextOnlyAlways) && isOnMenu)
				{
					Pen val11 = new Pen(itemPaintArgs_1.Colors.ItemDisabledText);
					Point[] array = new Point[3];
					array[0].X = rectangle4.Left + (rectangle4.Width - 5) / 2 - 1;
					array[0].Y = rectangle4.Top + (rectangle4.Height - 6) / 2 + 3;
					array[1].X = array[0].X + 2;
					array[1].Y = array[0].Y + 2;
					array[2].X = array[1].X + 4;
					array[2].Y = array[1].Y - 4;
					graphics.DrawLines(val11, array);
					array[0].X++;
					array[1].X++;
					array[2].X++;
					graphics.DrawLines(val11, array);
					val11.Dispose();
				}
			}
			empty = itemPaintArgs_1.Colors.ItemDisabledText;
			if (@class != null && eButtonStyle_0 != eButtonStyle.TextOnlyAlways)
			{
				@class.method_0(graphics, rectangle);
			}
		}
		else
		{
			if (m_Expanded && !isOnMenu)
			{
				if (itemPaintArgs_1.Colors.ItemExpandedBackground2.IsEmpty)
				{
					Rectangle rectangle5 = new Rectangle(rectangle2.Left, rectangle2.Top, rectangle2.Width, rectangle2.Height);
					if (itemPaintArgs_1.Colors.ItemExpandedShadow.IsEmpty)
					{
						rectangle5.Width -= 2;
					}
					SolidBrush val12 = new SolidBrush(itemPaintArgs_1.Colors.ItemExpandedBackground);
					try
					{
						graphics.FillRectangle((Brush)(object)val12, rectangle5);
					}
					finally
					{
						((IDisposable)val12)?.Dispose();
					}
				}
				else
				{
					LinearGradientBrush val13 = Class109.smethod_40(new Rectangle(rectangle2.Left, rectangle2.Top, rectangle2.Width - 2, rectangle2.Height), itemPaintArgs_1.Colors.ItemExpandedBackground, itemPaintArgs_1.Colors.ItemExpandedBackground2, itemPaintArgs_1.Colors.ItemExpandedBackgroundGradientAngle);
					Rectangle rectangle6 = new Rectangle(rectangle2.Left, rectangle2.Top, rectangle2.Width, rectangle2.Height);
					if (itemPaintArgs_1.Colors.ItemExpandedShadow.IsEmpty)
					{
						rectangle6.Width -= 2;
					}
					graphics.FillRectangle((Brush)(object)val13, rectangle6);
					((Brush)val13).Dispose();
				}
				Point[] array2 = ((m_Orientation != 0 || PopupSide != 0) ? new Point[5] : new Point[4]);
				array2[0].X = rectangle2.Left;
				array2[0].Y = rectangle2.Top + rectangle2.Height - 1;
				array2[1].X = rectangle2.Left;
				array2[1].Y = rectangle2.Top;
				if (m_Orientation == eOrientation.Horizontal)
				{
					array2[2].X = rectangle2.Left + rectangle2.Width - 3;
				}
				else
				{
					array2[2].X = rectangle2.Left + rectangle2.Width - 1;
				}
				array2[2].Y = rectangle2.Top;
				if (m_Orientation == eOrientation.Horizontal)
				{
					array2[3].X = rectangle2.Left + rectangle2.Width - 3;
				}
				else
				{
					array2[3].X = rectangle2.Left + rectangle2.Width - 1;
				}
				array2[3].Y = rectangle2.Top + rectangle2.Height - 1;
				if (m_Orientation == eOrientation.Vertical || PopupSide != 0)
				{
					array2[4].X = rectangle2.Left;
					array2[4].Y = rectangle2.Top + rectangle2.Height - 1;
				}
				if (!itemPaintArgs_1.Colors.ItemExpandedBorder.IsEmpty)
				{
					Pen val14 = new Pen(itemPaintArgs_1.Colors.ItemExpandedBorder, 1f);
					try
					{
						graphics.DrawLines(val14, array2);
					}
					finally
					{
						((IDisposable)val14)?.Dispose();
					}
				}
				if (!itemPaintArgs_1.Colors.ItemExpandedShadow.IsEmpty && m_Orientation == eOrientation.Horizontal)
				{
					SolidBrush val15 = new SolidBrush(itemPaintArgs_1.Colors.ItemExpandedShadow);
					try
					{
						graphics.FillRectangle((Brush)(object)val15, rectangle2.Left + rectangle2.Width - 2, rectangle2.Top + 2, 2, rectangle2.Height - 2);
					}
					finally
					{
						((IDisposable)val15)?.Dispose();
					}
				}
			}
			if ((flag && eHotTrackingStyle_0 != eHotTrackingStyle.None) || (m_Expanded && !isOnMenu))
			{
				if (!m_Expanded || isOnMenu)
				{
					Rectangle rectangle7 = rectangle2;
					if (isOnMenu)
					{
						rectangle7 = new Rectangle(rectangle2.Left + 1, rectangle2.Top, rectangle2.Width - 2, rectangle2.Height);
					}
					if (DesignMode && Focused)
					{
						rectangle7 = m_Rect;
						rectangle7.Inflate(-1, -1);
						Class32.smethod_0(graphics, rectangle7, itemPaintArgs_1.Colors.ItemDesignTimeBorder);
					}
					else if (bool_28)
					{
						if (eHotTrackingStyle_0 == eHotTrackingStyle.Image)
						{
							rectangle7 = rectangle;
							rectangle7.Inflate(2, 2);
						}
						if (itemPaintArgs_1.Colors.ItemPressedBackground2.IsEmpty)
						{
							SolidBrush val16 = new SolidBrush(itemPaintArgs_1.Colors.ItemPressedBackground);
							try
							{
								graphics.FillRectangle((Brush)(object)val16, rectangle7);
							}
							finally
							{
								((IDisposable)val16)?.Dispose();
							}
						}
						else
						{
							LinearGradientBrush val17 = Class109.smethod_40(rectangle7, itemPaintArgs_1.Colors.ItemPressedBackground, itemPaintArgs_1.Colors.ItemPressedBackground2, itemPaintArgs_1.Colors.ItemPressedBackgroundGradientAngle);
							graphics.FillRectangle((Brush)(object)val17, rectangle7);
							((Brush)val17).Dispose();
						}
						Pen val18 = new Pen(itemPaintArgs_1.Colors.ItemPressedBorder, 1f);
						try
						{
							Class92.smethod_4(graphics, val18, rectangle7);
						}
						finally
						{
							((IDisposable)val18)?.Dispose();
						}
					}
					else if (eHotTrackingStyle_0 == eHotTrackingStyle.Image && !rectangle.IsEmpty)
					{
						Rectangle rectangle8 = rectangle;
						rectangle8.Inflate(2, 2);
						if (!itemPaintArgs_1.Colors.ItemHotBackground2.IsEmpty)
						{
							LinearGradientBrush val19 = Class109.smethod_40(rectangle8, itemPaintArgs_1.Colors.ItemHotBackground, itemPaintArgs_1.Colors.ItemHotBackground2, itemPaintArgs_1.Colors.ItemHotBackgroundGradientAngle);
							graphics.FillRectangle((Brush)(object)val19, rectangle8);
							((Brush)val19).Dispose();
						}
						else
						{
							SolidBrush val20 = new SolidBrush(itemPaintArgs_1.Colors.ItemHotBackground);
							try
							{
								graphics.FillRectangle((Brush)(object)val20, rectangle8);
							}
							finally
							{
								((IDisposable)val20)?.Dispose();
							}
						}
						Pen val21 = new Pen(itemPaintArgs_1.Colors.ItemHotBorder, 1f);
						try
						{
							Class92.smethod_4(graphics, val21, rectangle8);
						}
						finally
						{
							((IDisposable)val21)?.Dispose();
						}
					}
					else
					{
						if (!itemPaintArgs_1.Colors.ItemCheckedBackground2.IsEmpty && bool_29)
						{
							LinearGradientBrush val22 = Class109.smethod_40(rectangle7, itemPaintArgs_1.Colors.ItemCheckedBackground2, itemPaintArgs_1.Colors.ItemCheckedBackground, itemPaintArgs_1.Colors.ItemCheckedBackgroundGradientAngle);
							graphics.FillRectangle((Brush)(object)val22, rectangle7);
							((Brush)val22).Dispose();
						}
						else if (!itemPaintArgs_1.Colors.ItemHotBackground2.IsEmpty)
						{
							LinearGradientBrush val23 = Class109.smethod_40(rectangle7, itemPaintArgs_1.Colors.ItemHotBackground, itemPaintArgs_1.Colors.ItemHotBackground2, itemPaintArgs_1.Colors.ItemHotBackgroundGradientAngle);
							graphics.FillRectangle((Brush)(object)val23, rectangle7);
							((Brush)val23).Dispose();
						}
						else
						{
							SolidBrush val24 = new SolidBrush(itemPaintArgs_1.Colors.ItemHotBackground);
							try
							{
								graphics.FillRectangle((Brush)(object)val24, rectangle7);
							}
							finally
							{
								((IDisposable)val24)?.Dispose();
							}
						}
						Pen val25 = new Pen(itemPaintArgs_1.Colors.ItemHotBorder, 1f);
						try
						{
							Class92.smethod_4(graphics, val25, rectangle7);
						}
						finally
						{
							((IDisposable)val25)?.Dispose();
						}
					}
				}
				if (@class != null && eButtonStyle_0 != eButtonStyle.TextOnlyAlways)
				{
					if (!bool_28 && (!bool_29 || base.IsOnCustomizeMenu || base.IsOnCustomizeDialog))
					{
						if (Class92.int_74 >= 16 && m_Style != eDotNetBarStyle.Office2003)
						{
							float[][] array3 = new float[5][];
							float[] array4 = (array3[0] = new float[5]);
							array4 = (array3[1] = new float[5]);
							array4 = (array3[2] = new float[5]);
							array3[3] = new float[5] { 0.5f, 0.5f, 0.5f, 0.5f, 0f };
							array4 = (array3[4] = new float[5]);
							ColorMatrix colorMatrix = new ColorMatrix(array3);
							ImageAttributes val26 = new ImageAttributes();
							val26.ClearColorKey();
							val26.SetColorMatrix(colorMatrix);
							rectangle.Offset(1, 1);
							@class.method_2(graphics, rectangle, 0, 0, @class.Int32_0, @class.Int32_1, (GraphicsUnit)2, val26);
							rectangle.Offset(-2, -2);
							@class.method_0(graphics, rectangle);
						}
						else
						{
							if (m_Style == eDotNetBarStyle.OfficeXP)
							{
								rectangle.Offset(-1, -1);
							}
							@class.method_0(graphics, rectangle);
						}
					}
					else
					{
						@class.method_0(graphics, rectangle);
					}
				}
				if (isOnMenu && base.IsOnCustomizeMenu && m_Visible && !base.SystemItem)
				{
					Rectangle rectangle9 = new Rectangle(m_Rect.Left, m_Rect.Top, m_Rect.Height, m_Rect.Height);
					rectangle9.Inflate(-1, -1);
					Color color = itemPaintArgs_1.Colors.ItemCheckedBackground;
					if (flag && !itemPaintArgs_1.Colors.ItemHotBackground2.IsEmpty)
					{
						LinearGradientBrush val27 = Class109.smethod_40(rectangle9, itemPaintArgs_1.Colors.ItemHotBackground, itemPaintArgs_1.Colors.ItemHotBackground2, itemPaintArgs_1.Colors.ItemHotBackgroundGradientAngle);
						graphics.FillRectangle((Brush)(object)val27, rectangle9);
						((Brush)val27).Dispose();
					}
					else
					{
						if (flag)
						{
							color = itemPaintArgs_1.Colors.ItemHotBackground;
						}
						if (!itemPaintArgs_1.Colors.ItemCheckedBackground2.IsEmpty && !flag)
						{
							LinearGradientBrush val28 = Class109.smethod_40(rectangle9, itemPaintArgs_1.Colors.ItemCheckedBackground, itemPaintArgs_1.Colors.ItemCheckedBackground2, itemPaintArgs_1.Colors.ItemCheckedBackgroundGradientAngle);
							graphics.FillRectangle((Brush)(object)val28, rectangle9);
							((Brush)val28).Dispose();
						}
						else
						{
							SolidBrush val29 = new SolidBrush(color);
							graphics.FillRectangle((Brush)(object)val29, rectangle9);
							((Brush)val29).Dispose();
						}
					}
				}
			}
			else
			{
				if (@class != null && eButtonStyle_0 != eButtonStyle.TextOnlyAlways)
				{
					if (bool_29 && !base.IsOnCustomizeMenu)
					{
						if (((bool_29 && isOnMenu) || !Expanded) && !base.IsOnCustomizeDialog)
						{
							Rectangle rectangle10;
							if (isOnMenu)
							{
								rectangle10 = new Rectangle(m_Rect.X + 1, m_Rect.Y, rectangle_0.Width - 2, m_Rect.Height);
							}
							else if (eHotTrackingStyle_0 == eHotTrackingStyle.Image)
							{
								rectangle10 = rectangle;
								rectangle10.Inflate(2, 2);
							}
							else
							{
								rectangle10 = m_Rect;
							}
							if (isOnMenu)
							{
								rectangle10.Inflate(-1, -1);
							}
							Color color2;
							if (flag && eHotTrackingStyle_0 != eHotTrackingStyle.None)
							{
								if (bool_29 && !itemPaintArgs_1.Colors.ItemCheckedBackground2.IsEmpty)
								{
									LinearGradientBrush val30 = Class109.smethod_40(rectangle10, itemPaintArgs_1.Colors.ItemCheckedBackground2, itemPaintArgs_1.Colors.ItemCheckedBackground, itemPaintArgs_1.Colors.ItemCheckedBackgroundGradientAngle);
									graphics.FillRectangle((Brush)(object)val30, rectangle10);
									((Brush)val30).Dispose();
									color2 = Color.Empty;
								}
								else if (!itemPaintArgs_1.Colors.ItemHotBackground2.IsEmpty)
								{
									LinearGradientBrush val31 = Class109.smethod_40(rectangle10, itemPaintArgs_1.Colors.ItemHotBackground, itemPaintArgs_1.Colors.ItemHotBackground2, itemPaintArgs_1.Colors.ItemHotBackgroundGradientAngle);
									graphics.FillRectangle((Brush)(object)val31, rectangle10);
									((Brush)val31).Dispose();
									color2 = Color.Empty;
								}
								else
								{
									color2 = ControlPaint.Dark(itemPaintArgs_1.Colors.ItemHotBackground);
								}
							}
							else if (!itemPaintArgs_1.Colors.ItemCheckedBackground2.IsEmpty)
							{
								LinearGradientBrush val32 = Class109.smethod_40(rectangle10, itemPaintArgs_1.Colors.ItemCheckedBackground, itemPaintArgs_1.Colors.ItemCheckedBackground2, itemPaintArgs_1.Colors.ItemCheckedBackgroundGradientAngle);
								graphics.FillRectangle((Brush)(object)val32, rectangle10);
								((Brush)val32).Dispose();
								color2 = Color.Empty;
							}
							else
							{
								color2 = itemPaintArgs_1.Colors.ItemCheckedBackground;
							}
							if (!color2.IsEmpty)
							{
								SolidBrush val33 = new SolidBrush(color2);
								graphics.FillRectangle((Brush)(object)val33, rectangle10);
								((Brush)val33).Dispose();
							}
						}
						@class.method_0(graphics, rectangle);
					}
					else if (eHotTrackingStyle_0 != eHotTrackingStyle.Color)
					{
						@class.method_0(graphics, rectangle);
					}
					else
					{
						ColorMatrix colorMatrix2 = new ColorMatrix(new float[5][]
						{
							new float[5] { 0.2125f, 0.2125f, 0.2125f, 0f, 0f },
							new float[5] { 0.5f, 0.5f, 0.5f, 0f, 0f },
							new float[5] { 0.0361f, 0.0361f, 0.0361f, 0f, 0f },
							new float[5] { 0f, 0f, 0f, 1f, 0f },
							new float[5] { 0.2f, 0.2f, 0.2f, 0f, 1f }
						});
						ImageAttributes val34 = new ImageAttributes();
						val34.SetColorMatrix(colorMatrix2);
						@class.method_2(graphics, rectangle, 0, 0, @class.Int32_0, @class.Int32_1, (GraphicsUnit)2, val34);
					}
				}
				if (isOnMenu && base.IsOnCustomizeMenu && m_Visible && !base.SystemItem)
				{
					Rectangle rectangle11 = new Rectangle(m_Rect.Left, m_Rect.Top, m_Rect.Height, m_Rect.Height);
					rectangle11.Inflate(-1, -1);
					if (itemPaintArgs_1.Colors.ItemCheckedBackground2.IsEmpty)
					{
						Color itemCheckedBackground = itemPaintArgs_1.Colors.ItemCheckedBackground;
						SolidBrush val35 = new SolidBrush(itemCheckedBackground);
						graphics.FillRectangle((Brush)(object)val35, rectangle11);
						((Brush)val35).Dispose();
					}
					else
					{
						LinearGradientBrush val36 = Class109.smethod_40(rectangle11, itemPaintArgs_1.Colors.ItemCheckedBackground, itemPaintArgs_1.Colors.ItemCheckedBackground2, itemPaintArgs_1.Colors.ItemCheckedBackgroundGradientAngle);
						graphics.FillRectangle((Brush)(object)val36, rectangle11);
						((Brush)val36).Dispose();
					}
				}
				else if (bool_29 && !isOnMenu && @class == null)
				{
					Rectangle rect = m_Rect;
					Color color3;
					if (flag && eHotTrackingStyle_0 != eHotTrackingStyle.None)
					{
						if (!itemPaintArgs_1.Colors.ItemCheckedBackground2.IsEmpty)
						{
							LinearGradientBrush val37 = Class109.smethod_40(rect, itemPaintArgs_1.Colors.ItemCheckedBackground2, itemPaintArgs_1.Colors.ItemCheckedBackground, itemPaintArgs_1.Colors.ItemCheckedBackgroundGradientAngle);
							graphics.FillRectangle((Brush)(object)val37, rect);
							((Brush)val37).Dispose();
							color3 = Color.Empty;
						}
						else if (!itemPaintArgs_1.Colors.ItemHotBackground2.IsEmpty)
						{
							LinearGradientBrush val38 = Class109.smethod_40(rect, itemPaintArgs_1.Colors.ItemHotBackground, itemPaintArgs_1.Colors.ItemHotBackground2, itemPaintArgs_1.Colors.ItemHotBackgroundGradientAngle);
							graphics.FillRectangle((Brush)(object)val38, rect);
							((Brush)val38).Dispose();
							color3 = Color.Empty;
						}
						else
						{
							color3 = itemPaintArgs_1.Colors.ItemHotBackground;
						}
					}
					else if (!itemPaintArgs_1.Colors.ItemCheckedBackground2.IsEmpty)
					{
						LinearGradientBrush val39 = Class109.smethod_40(rect, itemPaintArgs_1.Colors.ItemCheckedBackground, itemPaintArgs_1.Colors.ItemCheckedBackground2, itemPaintArgs_1.Colors.ItemCheckedBackgroundGradientAngle);
						graphics.FillRectangle((Brush)(object)val39, rect);
						((Brush)val39).Dispose();
						color3 = Color.Empty;
					}
					else
					{
						color3 = itemPaintArgs_1.Colors.ItemCheckedBackground;
					}
					if (!color3.IsEmpty)
					{
						SolidBrush val40 = new SolidBrush(color3);
						graphics.FillRectangle((Brush)(object)val40, rect);
						((Brush)val40).Dispose();
					}
				}
			}
			if (isOnMenu && base.IsOnCustomizeMenu && m_Visible && !base.SystemItem)
			{
				Rectangle rectangle12 = new Rectangle(m_Rect.Left, m_Rect.Top, m_Rect.Height, m_Rect.Height);
				rectangle12.Inflate(-1, -1);
				Color itemCheckedBorder = itemPaintArgs_1.Colors.ItemCheckedBorder;
				Pen val41 = new Pen(itemCheckedBorder, 1f);
				Class92.smethod_4(graphics, val41, rectangle12);
				val41.Dispose();
				val41 = new Pen(itemPaintArgs_1.Colors.ItemCheckedText);
				Point[] array5 = new Point[3];
				array5[0].X = rectangle12.Left + (rectangle12.Width - 5) / 2 - 1;
				array5[0].Y = rectangle12.Top + (rectangle12.Height - 6) / 2 + 3;
				array5[1].X = array5[0].X + 2;
				array5[1].Y = array5[0].Y + 2;
				array5[2].X = array5[1].X + 4;
				array5[2].Y = array5[1].Y - 4;
				graphics.DrawLines(val41, array5);
				array5[0].X++;
				array5[1].X++;
				array5[2].X++;
				graphics.DrawLines(val41, array5);
				val41.Dispose();
			}
			if (bool_29 && !base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog)
			{
				Rectangle rectangle13;
				if (isOnMenu)
				{
					rectangle13 = new Rectangle(m_Rect.X + 1, m_Rect.Y, rectangle_0.Width - 2, m_Rect.Height);
				}
				else if (eHotTrackingStyle_0 == eHotTrackingStyle.Image)
				{
					rectangle13 = rectangle;
					rectangle13.Inflate(2, 2);
				}
				else
				{
					rectangle13 = new Rectangle(m_Rect.X, m_Rect.Y, m_Rect.Width, m_Rect.Height);
				}
				if (isOnMenu)
				{
					rectangle13.Inflate(-1, -1);
				}
				if (isOnMenu || !Expanded)
				{
					if (@class == null || eButtonStyle_0 == eButtonStyle.TextOnlyAlways)
					{
						if (flag)
						{
							if (bool_29 && !itemPaintArgs_1.Colors.ItemCheckedBackground2.IsEmpty)
							{
								LinearGradientBrush val42 = Class109.smethod_40(rectangle13, itemPaintArgs_1.Colors.ItemCheckedBackground2, itemPaintArgs_1.Colors.ItemCheckedBackground, itemPaintArgs_1.Colors.ItemCheckedBackgroundGradientAngle);
								graphics.FillRectangle((Brush)(object)val42, rectangle13);
								((Brush)val42).Dispose();
							}
							else if (!itemPaintArgs_1.Colors.ItemHotBackground2.IsEmpty)
							{
								LinearGradientBrush val43 = Class109.smethod_40(rectangle13, itemPaintArgs_1.Colors.ItemHotBackground, itemPaintArgs_1.Colors.ItemHotBackground2, itemPaintArgs_1.Colors.ItemHotBackgroundGradientAngle);
								graphics.FillRectangle((Brush)(object)val43, rectangle13);
								((Brush)val43).Dispose();
							}
							else
							{
								SolidBrush val44 = new SolidBrush(itemPaintArgs_1.Colors.ItemHotBackground);
								try
								{
									graphics.FillRectangle((Brush)(object)val44, rectangle13);
								}
								finally
								{
									((IDisposable)val44)?.Dispose();
								}
							}
						}
						else if (itemPaintArgs_1.Colors.ItemCheckedBackground2.IsEmpty)
						{
							SolidBrush val45 = new SolidBrush(itemPaintArgs_1.Colors.ItemCheckedBackground);
							try
							{
								graphics.FillRectangle((Brush)(object)val45, rectangle13);
							}
							finally
							{
								((IDisposable)val45)?.Dispose();
							}
						}
						else
						{
							LinearGradientBrush val46 = Class109.smethod_40(rectangle13, itemPaintArgs_1.Colors.ItemCheckedBackground, itemPaintArgs_1.Colors.ItemCheckedBackground2, itemPaintArgs_1.Colors.ItemCheckedBackgroundGradientAngle);
							graphics.FillRectangle((Brush)(object)val46, rectangle13);
							((Brush)val46).Dispose();
						}
					}
					Color itemCheckedBorder2 = itemPaintArgs_1.Colors.ItemCheckedBorder;
					Pen val47 = new Pen(itemCheckedBorder2, 1f);
					Class92.smethod_4(graphics, val47, rectangle13);
					val47.Dispose();
				}
				if ((@class == null || eButtonStyle_0 == eButtonStyle.TextOnlyAlways) && isOnMenu)
				{
					Pen val48 = new Pen(itemPaintArgs_1.Colors.ItemCheckedText);
					Point[] array6 = new Point[3];
					array6[0].X = rectangle13.Left + (rectangle13.Width - 5) / 2 - 1;
					array6[0].Y = rectangle13.Top + (rectangle13.Height - 6) / 2 + 3;
					array6[1].X = array6[0].X + 2;
					array6[1].Y = array6[0].Y + 2;
					array6[2].X = array6[1].X + 4;
					array6[2].Y = array6[1].Y - 4;
					graphics.DrawLines(val48, array6);
					array6[0].X++;
					array6[1].X++;
					array6[2].X++;
					graphics.DrawLines(val48, array6);
					val48.Dispose();
				}
			}
		}
		if (isOnMenu || eButtonStyle_0 != 0 || @class == null || (!isOnMenu && (eImagePosition_0 == eImagePosition.Top || eImagePosition_0 == eImagePosition.Bottom)))
		{
			if (isOnMenu)
			{
				rectangle = new Rectangle(rectangle_1.X, rectangle_1.Y, rectangle2.Width - rectangle_0.Right - 26, rectangle_1.Height);
			}
			else
			{
				rectangle = rectangle_1;
				if (eImagePosition_0 != eImagePosition.Top && eImagePosition_0 != eImagePosition.Bottom)
				{
					if (isOnMenuBar && @class == null)
					{
						eTextFormat2 |= eTextFormat.HorizontalCenter;
					}
				}
				else
				{
					if (m_Orientation == eOrientation.Vertical)
					{
						rectangle = new Rectangle(rectangle_1.X, rectangle_1.Y, rectangle_1.Width, rectangle_1.Height);
					}
					else
					{
						rectangle = new Rectangle(rectangle_1.X, rectangle_1.Y, rectangle2.Width, rectangle_1.Height);
						if ((SubItems.Count > 0 || PopupType == ePopupType.Container) && ShowSubItems)
						{
							rectangle.Width -= 10;
						}
					}
					eTextFormat2 |= eTextFormat.HorizontalCenter;
				}
				if (bool_28 && eHotTrackingStyle_0 != eHotTrackingStyle.Image)
				{
					empty = ((!color_0.IsEmpty) ? ControlPaint.Light(color_0) : itemPaintArgs_1.Colors.ItemPressedText);
				}
			}
			rectangle.Offset(rectangle2.Left, rectangle2.Top);
			if (m_Orientation == eOrientation.Vertical && !isOnMenu)
			{
				graphics.RotateTransform(90f);
				Class55.smethod_2(graphics, m_Text, val, empty, new Rectangle(rectangle.Top, -rectangle.Right, rectangle.Height, rectangle.Width), eTextFormat2);
				graphics.ResetTransform();
			}
			else
			{
				if (rectangle.Right > m_Rect.Right)
				{
					rectangle.Width = m_Rect.Right - rectangle.Left;
				}
				Class55.smethod_1(graphics, m_Text, val, empty, rectangle, eTextFormat2);
				if (!DesignMode && Focused && !isOnMenu && !isOnMenuBar)
				{
					Rectangle rectangle14 = rectangle;
					ControlPaint.DrawFocusRectangle(graphics, rectangle14);
				}
			}
		}
		if (String_1 != "" && isOnMenu && !base.IsOnCustomizeDialog)
		{
			eTextFormat2 |= eTextFormat.HidePrefix | eTextFormat.Right;
			Class55.smethod_1(graphics, String_1, val, empty, rectangle, eTextFormat2);
		}
		if ((SubItems.Count > 0 || PopupType == ePopupType.Container) && ShowSubItems)
		{
			if (isOnMenu)
			{
				Point[] array7 = new Point[3];
				array7[0].X = rectangle2.Left + rectangle2.Width - 12;
				array7[0].Y = rectangle2.Top + (rectangle2.Height - 8) / 2;
				array7[1].X = array7[0].X;
				array7[1].Y = array7[0].Y + 8;
				array7[2].X = array7[0].X + 4;
				array7[2].Y = array7[0].Y + 4;
				SolidBrush val49 = new SolidBrush(empty);
				try
				{
					graphics.FillPolygon((Brush)(object)val49, array7);
				}
				finally
				{
					((IDisposable)val49)?.Dispose();
				}
			}
			else if (!rectangle_2.IsEmpty)
			{
				if (method_1(itemPaintArgs_1.ContainerControl) && (flag || bool_29) && !m_Expanded && eHotTrackingStyle_0 != eHotTrackingStyle.None && eHotTrackingStyle_0 != eHotTrackingStyle.Image)
				{
					if (m_Orientation == eOrientation.Horizontal)
					{
						Pen val50 = new Pen(itemPaintArgs_1.Colors.ItemHotBorder);
						try
						{
							graphics.DrawLine(val50, rectangle2.Left + rectangle_2.Left, rectangle2.Top, rectangle2.Left + rectangle_2.Left, rectangle2.Bottom - 1);
						}
						finally
						{
							((IDisposable)val50)?.Dispose();
						}
					}
					else
					{
						Pen val51 = new Pen(itemPaintArgs_1.Colors.ItemHotBorder);
						try
						{
							graphics.DrawLine(val51, rectangle2.Left, rectangle2.Top + rectangle_2.Top, rectangle2.Right - 2, rectangle2.Top + rectangle_2.Top);
						}
						finally
						{
							((IDisposable)val51)?.Dispose();
						}
					}
				}
				Point[] array8 = new Point[3];
				if (PopupSide == ePopupSide.Default)
				{
					if (m_Orientation == eOrientation.Horizontal)
					{
						array8[0].X = rectangle2.Left + rectangle_2.Left + (rectangle_2.Width - 5) / 2;
						array8[0].Y = rectangle2.Top + (rectangle_2.Height - 3) / 2 + 1;
						array8[1].X = array8[0].X + 5;
						array8[1].Y = array8[0].Y;
						array8[2].X = array8[0].X + 2;
						array8[2].Y = array8[0].Y + 3;
					}
					else
					{
						array8[0].X = rectangle2.Left + (rectangle_2.Width - 3) / 2 + 1;
						array8[0].Y = rectangle2.Top + rectangle_2.Top + (rectangle_2.Height - 5) / 2;
						array8[1].X = array8[0].X;
						array8[1].Y = array8[0].Y + 6;
						array8[2].X = array8[0].X - 3;
						array8[2].Y = array8[0].Y + 3;
					}
				}
				else
				{
					switch (PopupSide)
					{
					case ePopupSide.Left:
						array8[0].X = rectangle2.Left + rectangle_2.Left + rectangle_2.Width / 2;
						array8[0].Y = rectangle2.Top + rectangle_2.Height / 2 - 3;
						array8[1].X = array8[0].X;
						array8[1].Y = array8[0].Y + 6;
						array8[2].X = array8[0].X + 3;
						array8[2].Y = array8[0].Y + 3;
						break;
					case ePopupSide.Right:
						array8[0].X = rectangle2.Left + rectangle_2.Left + rectangle_2.Width / 2 + 3;
						array8[0].Y = rectangle2.Top + rectangle_2.Height / 2 - 3;
						array8[1].X = array8[0].X;
						array8[1].Y = array8[0].Y + 6;
						array8[2].X = array8[0].X - 3;
						array8[2].Y = array8[0].Y + 3;
						break;
					case ePopupSide.Top:
						array8[0].X = rectangle2.Left + rectangle_2.Left + (rectangle_2.Width - 5) / 2;
						array8[0].Y = rectangle2.Top + (rectangle_2.Height - 3) / 2 + 4;
						array8[1].X = array8[0].X + 6;
						array8[1].Y = array8[0].Y;
						array8[2].X = array8[0].X + 3;
						array8[2].Y = array8[0].Y - 4;
						break;
					case ePopupSide.Bottom:
						array8[0].X = rectangle2.Left + rectangle_2.Left + (rectangle_2.Width - 5) / 2 + 1;
						array8[0].Y = rectangle2.Top + (rectangle_2.Height - 3) / 2 + 1;
						array8[1].X = array8[0].X + 5;
						array8[1].Y = array8[0].Y;
						array8[2].X = array8[0].X + 2;
						array8[2].Y = array8[0].Y + 3;
						break;
					}
				}
				if (method_1(itemPaintArgs_1.ContainerControl))
				{
					SolidBrush val52 = new SolidBrush(itemPaintArgs_1.Colors.ItemText);
					try
					{
						graphics.FillPolygon((Brush)(object)val52, array8);
					}
					finally
					{
						((IDisposable)val52)?.Dispose();
					}
				}
				else
				{
					SolidBrush val53 = new SolidBrush(itemPaintArgs_1.Colors.ItemDisabledText);
					try
					{
						graphics.FillPolygon((Brush)(object)val53, array8);
					}
					finally
					{
						((IDisposable)val53)?.Dispose();
					}
				}
			}
		}
		if (Focused && DesignMode)
		{
			Rectangle rectangle15 = rectangle2;
			rectangle15.Inflate(-1, -1);
			Class32.smethod_0(graphics, rectangle15, itemPaintArgs_1.Colors.ItemDesignTimeBorder);
		}
		@class?.Dispose();
	}

	private void method_20(ItemPaintArgs itemPaintArgs_1)
	{
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		Graphics graphics = itemPaintArgs_1.Graphics;
		Class79 class79_ = itemPaintArgs_1.Class79_0;
		Class140 class140_ = Class140.class140_0;
		Class162 @class = Class162.class162_0;
		eTextFormat eTextFormat2 = itemPaintArgs_1.ButtonStringFormat;
		Color controlText = SystemColors.ControlText;
		Rectangle rectangle = Rectangle.Empty;
		Rectangle rect = m_Rect;
		Font val = null;
		Class271 class2 = method_22();
		val = ((font_1 == null) ? method_40(itemPaintArgs_1) : font_1);
		bool flag;
		if (flag = (SubItems.Count > 0 || PopupType == ePopupType.Container) && ShowSubItems && !rectangle_2.IsEmpty)
		{
			class140_ = Class140.class140_2;
		}
		if (class2 != null)
		{
			rectangle = ((eImagePosition_0 == eImagePosition.Top || eImagePosition_0 == eImagePosition.Bottom) ? new Rectangle(rectangle_0.X, rectangle_0.Y, rect.Width, rectangle_0.Height) : new Rectangle(rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height));
			rectangle.Offset(rect.Left, rect.Top);
			rectangle.Offset((rectangle.Width - ImageSize.Width) / 2, (rectangle.Height - ImageSize.Height) / 2);
			rectangle.Width = ImageSize.Width;
			rectangle.Height = ImageSize.Height;
		}
		if (!method_1(itemPaintArgs_1.ContainerControl))
		{
			@class = Class162.class162_3;
			controlText = itemPaintArgs_1.Colors.ItemDisabledText;
		}
		else if (bool_28)
		{
			@class = Class162.class162_2;
			controlText = itemPaintArgs_1.Colors.ItemPressedText;
		}
		else if (bool_26 && bool_29)
		{
			@class = Class162.class162_5;
			controlText = itemPaintArgs_1.Colors.ItemHotText;
		}
		else if (!bool_26 && !m_Expanded)
		{
			if (bool_29)
			{
				@class = Class162.class162_4;
				controlText = itemPaintArgs_1.Colors.ItemCheckedText;
			}
			else
			{
				controlText = itemPaintArgs_1.Colors.ItemText;
			}
		}
		else
		{
			@class = Class162.class162_1;
			controlText = itemPaintArgs_1.Colors.ItemHotText;
		}
		Rectangle rectangle2 = m_Rect;
		if (eHotTrackingStyle_0 == eHotTrackingStyle.Image && class2 != null)
		{
			rectangle2 = rectangle;
			rectangle2.Inflate(3, 3);
		}
		else if (flag)
		{
			rectangle2.Width -= rectangle_2.Width;
		}
		if (eHotTrackingStyle_0 != eHotTrackingStyle.None)
		{
			class79_.method_0(graphics, class140_, @class, rectangle2);
		}
		if (class2 != null && eButtonStyle_0 != eButtonStyle.TextOnlyAlways)
		{
			if (@class == Class162.class162_0 && eHotTrackingStyle_0 == eHotTrackingStyle.Color)
			{
				ColorMatrix colorMatrix = new ColorMatrix(new float[5][]
				{
					new float[5] { 0.2125f, 0.2125f, 0.2125f, 0f, 0f },
					new float[5] { 0.5f, 0.5f, 0.5f, 0f, 0f },
					new float[5] { 0.0361f, 0.0361f, 0.0361f, 0f, 0f },
					new float[5] { 0f, 0f, 0f, 1f, 0f },
					new float[5] { 0.2f, 0.2f, 0.2f, 0f, 1f }
				});
				ImageAttributes val2 = new ImageAttributes();
				val2.SetColorMatrix(colorMatrix);
				class2.method_2(graphics, rectangle, 0, 0, class2.Int32_0, class2.Int32_1, (GraphicsUnit)2, val2);
			}
			else if (@class == Class162.class162_0 && !class2.Boolean_0)
			{
				ImageAttributes val3 = new ImageAttributes();
				val3.SetGamma(0.7f, (ColorAdjustType)1);
				class2.method_2(graphics, rectangle, 0, 0, class2.Int32_0, class2.Int32_1, (GraphicsUnit)2, val3);
			}
			else
			{
				class2.method_0(graphics, rectangle);
			}
		}
		if (eButtonStyle_0 == eButtonStyle.ImageAndText || eButtonStyle_0 == eButtonStyle.TextOnlyAlways || class2 == null)
		{
			Rectangle rectangle3 = rectangle_1;
			if (eImagePosition_0 == eImagePosition.Top || eImagePosition_0 == eImagePosition.Bottom)
			{
				if (m_Orientation == eOrientation.Vertical)
				{
					rectangle3 = new Rectangle(rectangle_1.X, rectangle_1.Y, rectangle_1.Width, rectangle_1.Height);
				}
				else
				{
					rectangle3 = new Rectangle(rectangle_1.X, rectangle_1.Y, rect.Width, rectangle_1.Height);
					if ((SubItems.Count > 0 || PopupType == ePopupType.Container) && ShowSubItems)
					{
						rectangle3.Width -= 10;
					}
				}
				eTextFormat2 |= eTextFormat.HorizontalCenter;
			}
			rectangle3.Offset(rect.Left, rect.Top);
			if (m_Orientation == eOrientation.Vertical)
			{
				graphics.RotateTransform(90f);
				Class55.smethod_2(graphics, m_Text, val, controlText, new Rectangle(rectangle3.Top, -rectangle3.Right, rectangle3.Height, rectangle3.Width), eTextFormat2);
				graphics.ResetTransform();
			}
			else
			{
				if (rectangle3.Right > m_Rect.Right)
				{
					rectangle3.Width = m_Rect.Right - rectangle3.Left;
				}
				Class55.smethod_1(graphics, m_Text, val, controlText, rectangle3, eTextFormat2);
				if (!DesignMode && Focused && !itemPaintArgs_1.IsOnMenu && !itemPaintArgs_1.IsOnMenuBar)
				{
					Rectangle rectangle4 = rectangle3;
					ControlPaint.DrawFocusRectangle(graphics, rectangle4);
				}
			}
		}
		if (flag)
		{
			class140_ = Class140.class140_3;
			@class = (method_1(itemPaintArgs_1.ContainerControl) ? Class162.class162_0 : Class162.class162_3);
			if (eHotTrackingStyle_0 != eHotTrackingStyle.None && eHotTrackingStyle_0 != eHotTrackingStyle.Image && method_1(itemPaintArgs_1.ContainerControl))
			{
				if (!m_Expanded && !bool_28)
				{
					if (bool_26 && bool_29)
					{
						@class = Class162.class162_5;
					}
					else if (bool_29)
					{
						@class = Class162.class162_4;
					}
					else if (bool_26)
					{
						@class = Class162.class162_1;
					}
				}
				else
				{
					@class = Class162.class162_2;
				}
			}
			if (m_Orientation == eOrientation.Horizontal)
			{
				Rectangle rectangle5 = rectangle_2;
				rectangle5.Offset(rect.X, rect.Y);
				class79_.method_0(graphics, class140_, @class, rectangle5);
			}
			else
			{
				Rectangle rectangle6 = rectangle_2;
				rectangle6.Offset(rect.X, rect.Y);
				class79_.method_0(graphics, class140_, @class, rectangle6);
			}
		}
		if (Focused && DesignMode)
		{
			Rectangle rectangle7 = rect;
			rectangle7.Inflate(-1, -1);
			Class32.smethod_0(graphics, rectangle7, itemPaintArgs_1.Colors.ItemDesignTimeBorder);
		}
		class2?.Dispose();
	}

	private void method_21(ItemPaintArgs itemPaintArgs_1)
	{
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd7: Expected O, but got Unknown
		//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb5: Expected O, but got Unknown
		Graphics graphics = itemPaintArgs_1.Graphics;
		Rectangle rectangle = Rectangle.Empty;
		Rectangle rect = m_Rect;
		Rectangle empty = Rectangle.Empty;
		Color color = SystemColors.ControlText;
		Color color2 = SystemColors.Control;
		if (m_Parent is GenericItemContainer && !((GenericItemContainer)m_Parent).BackColor.IsEmpty)
		{
			color2 = ((GenericItemContainer)m_Parent).BackColor;
		}
		else if (m_Parent is SideBarPanelItem && !((SideBarPanelItem)m_Parent).BackgroundStyle.BackColor1.IsEmpty)
		{
			color2 = ((SideBarPanelItem)m_Parent).BackgroundStyle.BackColor1.GetCompositeColor();
		}
		if (bool_26 && !color_1.IsEmpty)
		{
			color = color_1;
		}
		else if (!color_0.IsEmpty)
		{
			color = color_0;
		}
		Font val = null;
		bool isOnMenu = itemPaintArgs_1.IsOnMenu;
		bool flag = itemPaintArgs_1.ContainerControl is ButtonX;
		eTextFormat eTextFormat2 = itemPaintArgs_1.ButtonStringFormat;
		Class271 @class = method_22();
		val = ((font_1 == null) ? method_40(itemPaintArgs_1) : font_1);
		if (@class != null)
		{
			rectangle = ((isOnMenu || (eImagePosition_0 != eImagePosition.Top && eImagePosition_0 != eImagePosition.Bottom)) ? rectangle_0 : new Rectangle(rectangle_0.X, rectangle_0.Y + 1, rect.Width, rectangle_0.Height));
			rectangle.Offset(rect.Left, rect.Top);
			rectangle.Offset((rectangle.Width - ImageSize.Width) / 2, (rectangle.Height - ImageSize.Height) / 2);
			rectangle.Width = ImageSize.Width;
			rectangle.Height = ImageSize.Height;
		}
		if (isOnMenu && !DesignMode && MenuVisibility == eMenuVisibility.VisibleIfRecentlyUsed && !RecentlyUsed)
		{
			graphics.FillRectangle((Brush)new SolidBrush(ColorFunctions.RecentlyUsedOfficeBackColor()), m_Rect);
		}
		else if (flag)
		{
			ButtonState val2 = (ButtonState)0;
			if (bool_28)
			{
				val2 = (ButtonState)512;
			}
			else if (bool_29 || m_Expanded)
			{
				val2 = (ButtonState)1024;
			}
			ControlPaint.DrawButton(graphics, rect, val2);
		}
		if (!method_1(itemPaintArgs_1.ContainerControl) && !DesignMode)
		{
			color = SystemColors.ControlDark;
			if (@class != null && eButtonStyle_0 != eButtonStyle.TextOnlyAlways)
			{
				@class.method_0(graphics, rectangle);
			}
		}
		else
		{
			if (m_Expanded && !isOnMenu)
			{
				graphics.FillRectangle(SystemBrushes.get_Control(), rect);
				Class109.smethod_35(graphics, rect, (Border3DStyle)2, (Border3DSide)2063, color2);
			}
			if ((!bool_26 || eHotTrackingStyle_0 == eHotTrackingStyle.None) && !m_Expanded && (!bool_29 || base.IsOnCustomizeMenu || base.IsOnCustomizeDialog))
			{
				if (@class != null && eButtonStyle_0 != eButtonStyle.TextOnlyAlways)
				{
					if (eHotTrackingStyle_0 != eHotTrackingStyle.Color)
					{
						@class.method_0(graphics, rectangle);
					}
					else if (eHotTrackingStyle_0 == eHotTrackingStyle.Color)
					{
						ColorMatrix colorMatrix = new ColorMatrix(new float[5][]
						{
							new float[5] { 0.2125f, 0.2125f, 0.2125f, 0f, 0f },
							new float[5] { 0.5f, 0.5f, 0.5f, 0f, 0f },
							new float[5] { 0.0361f, 0.0361f, 0.0361f, 0f, 0f },
							new float[5] { 0f, 0f, 0f, 1f, 0f },
							new float[5] { 0.2f, 0.2f, 0.2f, 0f, 1f }
						});
						ImageAttributes val3 = new ImageAttributes();
						val3.SetColorMatrix(colorMatrix);
						@class.method_2(graphics, rectangle, 0, 0, @class.Int32_0, @class.Int32_1, (GraphicsUnit)2, val3);
					}
				}
			}
			else
			{
				if (!isOnMenu && !base.IsOnCustomizeDialog)
				{
					if (!bool_28 && (!bool_29 || base.IsOnCustomizeMenu || base.IsOnCustomizeDialog) && (!Expanded || (ShowSubItems && !IsOnMenuBar)))
					{
						if (!DesignMode)
						{
							if (rectangle_2.IsEmpty)
							{
								if (!flag)
								{
									Class109.smethod_35(graphics, rect, (Border3DStyle)4, (Border3DSide)2063, color2);
								}
							}
							else
							{
								Rectangle rectangle2 = ((m_Orientation != 0) ? new Rectangle(rect.X, rect.Y, rect.Width, rect.Height - rectangle_2.Height) : new Rectangle(rect.X, rect.Y, rect.Width - rectangle_2.Width, rect.Height));
								Class109.smethod_35(graphics, rectangle2, (Border3DStyle)4, (Border3DSide)2063, color2);
							}
						}
					}
					else if (rectangle_2.IsEmpty)
					{
						if (!flag)
						{
							Class109.smethod_35(graphics, rect, (Border3DStyle)2, (Border3DSide)2063, color2);
							if (bool_29 && !bool_26 && !base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog)
							{
								Rectangle rectangle3 = rect;
								rectangle3.Inflate(-1, -1);
								graphics.FillRectangle(ColorFunctions.GetPushedBrush(this), rectangle3);
							}
						}
					}
					else if (!flag)
					{
						Rectangle rectangle4 = ((m_Orientation != 0) ? new Rectangle(rect.X, rect.Y, rect.Width, rect.Height - rectangle_2.Height) : new Rectangle(rect.X, rect.Y, rect.Width - rectangle_2.Width, rect.Height));
						Class109.smethod_35(graphics, rectangle4, (Border3DStyle)2, (Border3DSide)2063, color2);
						if (!bool_26)
						{
							rectangle4.Inflate(-1, -1);
							graphics.FillRectangle(ColorFunctions.GetPushedBrush(this), rectangle4);
						}
					}
				}
				else if (((bool_26 && eHotTrackingStyle_0 != eHotTrackingStyle.None) || m_Expanded) && (!bool_26 || !DesignMode || base.IsOnCustomizeDialog))
				{
					graphics.FillRectangle(SystemBrushes.get_Highlight(), rect);
				}
				if (@class != null && eButtonStyle_0 != eButtonStyle.TextOnlyAlways)
				{
					empty = new Rectangle(rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rect.Height);
					empty.Offset(rect.Left, rect.Top);
					if (isOnMenu)
					{
						if (bool_29 && !base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog)
						{
							Class109.smethod_35(graphics, empty, (Border3DStyle)2, (Border3DSide)2063, color2);
							if (!bool_26)
							{
								empty.Inflate(-1, -1);
								graphics.FillRectangle(ColorFunctions.GetPushedBrush(this), empty);
							}
						}
						else
						{
							Class109.smethod_35(graphics, empty, (Border3DStyle)4, (Border3DSide)2063, color2);
						}
					}
					else if (bool_28)
					{
						rectangle.Offset(1, 1);
					}
					@class.method_0(graphics, rectangle);
				}
				else if ((@class == null || eButtonStyle_0 == eButtonStyle.TextOnlyAlways) && bool_29 && !base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog && isOnMenu)
				{
					empty = new Rectangle(rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rect.Height);
					empty.Offset(rect.Left, rect.Top);
					method_28(graphics, empty);
				}
			}
			if (isOnMenu && base.IsOnCustomizeMenu && m_Visible && !base.SystemItem)
			{
				Rectangle rectangle_ = new Rectangle(m_Rect.Left, m_Rect.Top, m_Rect.Height, m_Rect.Height);
				method_28(graphics, rectangle_);
			}
		}
		if (isOnMenu || eButtonStyle_0 != 0 || @class == null || (!isOnMenu && (eImagePosition_0 == eImagePosition.Top || eImagePosition_0 == eImagePosition.Bottom)))
		{
			if (isOnMenu)
			{
				rectangle = new Rectangle(rectangle_1.X, rectangle_1.Y, rect.Width - rectangle_0.Right - 24, rectangle_1.Height);
			}
			else
			{
				rectangle = rectangle_1;
				if (eImagePosition_0 == eImagePosition.Top || eImagePosition_0 == eImagePosition.Bottom)
				{
					if (m_Orientation == eOrientation.Horizontal)
					{
						rectangle = new Rectangle(rectangle_1.X, rectangle_1.Y, rect.Width, rectangle_1.Height);
					}
					if ((SubItems.Count > 0 || PopupType == ePopupType.Container) && m_Orientation == eOrientation.Horizontal && ShowSubItems)
					{
						rectangle.Width -= 12;
					}
					eTextFormat2 |= eTextFormat.HorizontalCenter;
				}
			}
			if (((bool_26 && eHotTrackingStyle_0 != eHotTrackingStyle.None) || m_Expanded) && isOnMenu && !DesignMode)
			{
				color = SystemColors.HighlightText;
			}
			rectangle.Offset(rect.Left, rect.Top);
			if (!isOnMenu && (bool_28 || (Expanded && IsOnMenuBar)))
			{
				rectangle.Offset(1, 1);
			}
			if (flag)
			{
				eTextFormat2 |= eTextFormat.HorizontalCenter;
				rectangle.Height--;
			}
			if (!method_1(itemPaintArgs_1.ContainerControl) && !DesignMode)
			{
				if (m_Orientation == eOrientation.Vertical && !isOnMenu)
				{
					graphics.RotateTransform(90f);
					ControlPaint.DrawStringDisabled(graphics, m_Text, val, SystemColors.Control, (RectangleF)new Rectangle(rectangle.Top, -rectangle.Right, rectangle.Height, rectangle.Width), Class55.smethod_11(eTextFormat2));
					graphics.ResetTransform();
				}
				else
				{
					ControlPaint.DrawStringDisabled(graphics, m_Text, val, SystemColors.Control, (RectangleF)rectangle, Class55.smethod_11(eTextFormat2));
				}
			}
			else if (m_Orientation == eOrientation.Vertical && !isOnMenu)
			{
				graphics.RotateTransform(90f);
				Class55.smethod_2(graphics, m_Text, val, color, new Rectangle(rectangle.Top, -rectangle.Right, rectangle.Height, rectangle.Width), eTextFormat2);
				graphics.ResetTransform();
			}
			else
			{
				Class55.smethod_1(graphics, m_Text, val, color, rectangle, eTextFormat2);
				if (!DesignMode && Focused && !isOnMenu && !itemPaintArgs_1.IsOnMenuBar)
				{
					Rectangle rectangle5 = rectangle;
					ControlPaint.DrawFocusRectangle(graphics, rectangle5);
				}
			}
		}
		if (String_1 != "" && isOnMenu)
		{
			eTextFormat2 |= eTextFormat.HidePrefix | eTextFormat.Right;
			if (!method_1(itemPaintArgs_1.ContainerControl) && !DesignMode)
			{
				ControlPaint.DrawStringDisabled(graphics, String_1, val, SystemColors.Control, (RectangleF)rectangle, Class55.smethod_11(eTextFormat2));
			}
			else
			{
				Class55.smethod_1(graphics, String_1, val, color, rectangle, eTextFormat2);
			}
		}
		if ((SubItems.Count > 0 || PopupType == ePopupType.Container) && ShowSubItems)
		{
			if (isOnMenu)
			{
				Point[] array = new Point[3];
				array[0].X = rect.Left + rect.Width - 12;
				array[0].Y = rect.Top + (rect.Height - 8) / 2;
				array[1].X = array[0].X;
				array[1].Y = array[0].Y + 8;
				array[2].X = array[0].X + 4;
				array[2].Y = array[0].Y + 4;
				SolidBrush val4 = new SolidBrush(color);
				try
				{
					graphics.FillPolygon((Brush)(object)val4, array);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
			else if (!rectangle_2.IsEmpty)
			{
				if (bool_26 && !m_Expanded && eHotTrackingStyle_0 != eHotTrackingStyle.None)
				{
					Rectangle rectangle6 = new Rectangle(rectangle_2.X, rectangle_2.Y, rectangle_2.Width, rectangle_2.Height);
					rectangle6.Offset(rect.X, rect.Y);
					Class109.smethod_35(graphics, rectangle6, (Border3DStyle)4, (Border3DSide)2063, color2);
				}
				else if (m_Expanded)
				{
					Rectangle rectangle7 = new Rectangle(rectangle_2.X, rectangle_2.Y, rectangle_2.Width, rectangle_2.Height);
					rectangle7.Offset(rect.X, rect.Y);
					Class109.smethod_35(graphics, rectangle7, (Border3DStyle)2, (Border3DSide)2063, color2);
				}
				Point[] array2 = new Point[3];
				if (m_Orientation == eOrientation.Horizontal)
				{
					array2[0].X = rect.Left + rectangle_2.Left + (rectangle_2.Width - 5) / 2;
					array2[0].Y = rect.Top + (rectangle_2.Height - 3) / 2 + 1;
					array2[1].X = array2[0].X + 5;
					array2[1].Y = array2[0].Y;
					array2[2].X = array2[0].X + 2;
					array2[2].Y = array2[0].Y + 3;
				}
				else
				{
					array2[0].X = rect.Left + (rectangle_2.Width - 3) / 2 + 1;
					array2[0].Y = rect.Top + rectangle_2.Top + (rectangle_2.Height - 5) / 2;
					array2[1].X = array2[0].X;
					array2[1].Y = array2[0].Y + 6;
					array2[2].X = array2[0].X - 3;
					array2[2].Y = array2[0].Y + 3;
				}
				graphics.FillPolygon(SystemBrushes.get_ControlText(), array2);
			}
		}
		if (Focused && DesignMode)
		{
			Rectangle rectangle8 = rect;
			rectangle8.Inflate(-1, -1);
			graphics.DrawRectangle(new Pen(SystemColors.ControlText, 2f), rectangle8);
		}
		@class?.Dispose();
	}

	internal Class271 method_22()
	{
		if (!method_2() && !base.IsOnCustomizeDialog)
		{
			return method_23(Enum15.const_1);
		}
		if (!bool_28 && !Checked && (!Expanded || eHotTrackingStyle_0 != eHotTrackingStyle.Image))
		{
			if (bool_26)
			{
				return method_23(Enum15.const_2);
			}
			return method_23(Enum15.const_0);
		}
		return method_23(Enum15.const_3);
	}

	internal Class271 method_23(Enum15 enum15_0)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		Image val = null;
		if (enum15_0 == Enum15.const_1 && (image_3 != null || int_8 >= 0 || icon_0 != null || image_0 != null || int_6 >= 0 || icon_1 != null))
		{
			if (image_3 != null)
			{
				return new Class271(image_3, dispose: false, size_4);
			}
			if (icon_0 != null)
			{
				return new Class271(icon_0, dispose: false, size_4);
			}
			if (int_8 >= 0)
			{
				val = method_25(int_8);
				if (val != null)
				{
					return new Class271(val, dispose: false, size_4);
				}
				return null;
			}
			method_37();
			if (image_3 != null)
			{
				return new Class271(image_3, dispose: false, size_4);
			}
			if (icon_0 != null)
			{
				return new Class271(icon_0, dispose: false, size_4);
			}
			return null;
		}
		if (icon_1 != null)
		{
			Size size = Size_0;
			Icon val2 = null;
			try
			{
				val2 = new Icon(icon_1, size);
			}
			catch
			{
				val2 = null;
			}
			if (val2 == null)
			{
				return new Class271(icon_1, dispose: false, size_4);
			}
			return new Class271(val2, dispose: true, size_4);
		}
		if (enum15_0 == Enum15.const_2 && (image_2 != null || int_7 >= 0))
		{
			if (image_2 != null)
			{
				return new Class271(image_2, dispose: false, size_4);
			}
			if (int_7 >= 0)
			{
				val = method_25(int_7);
				if (val != null)
				{
					return new Class271(val, dispose: false, size_4);
				}
				return null;
			}
		}
		if (enum15_0 == Enum15.const_3 && (image_4 != null || int_9 >= 0))
		{
			if (image_4 != null)
			{
				return new Class271(image_4, dispose: false, size_4);
			}
			if (int_9 >= 0)
			{
				val = method_25(int_9);
				if (val != null)
				{
					return new Class271(val, dispose: false, size_4);
				}
				return null;
			}
		}
		if (image_1 != null && (Boolean_5 || (size_4.Width == image_1.get_Width() && size_4.Height == image_1.get_Height())))
		{
			return new Class271(image_1, dispose: false);
		}
		if (image_0 != null)
		{
			return new Class271(image_0, dispose: false, size_4);
		}
		if (int_6 >= 0)
		{
			val = method_25(int_6);
			if (val != null)
			{
				return new Class271(val, dispose: false, size_4);
			}
		}
		return null;
	}

	private eBarImageSize method_24(IBarImageSize ibarImageSize_0)
	{
		eBarImageSize result = eBarImageSize.Default;
		if (ibarImageSize_0 != null)
		{
			result = ibarImageSize_0.ImageSize;
		}
		if (eButtonImageListSelection_0 != eButtonImageListSelection.NotSet)
		{
			result = (eBarImageSize)eButtonImageListSelection_0;
		}
		return result;
	}

	private Image method_25(int int_21)
	{
		if (int_21 >= 0)
		{
			IOwner owner = null;
			IBarImageSize barImageSize = null;
			if (itemPaintArgs_0 != null)
			{
				owner = itemPaintArgs_0.Owner;
				barImageSize = itemPaintArgs_0.ContainerControl as IBarImageSize;
			}
			if (owner == null)
			{
				owner = GetOwner() as IOwner;
			}
			if (barImageSize == null)
			{
				barImageSize = ContainerControl as IBarImageSize;
			}
			if (owner != null)
			{
				try
				{
					eBarImageSize eBarImageSize2 = method_24(barImageSize);
					if (eBarImageSize2 != 0)
					{
						if (eBarImageSize2 == eBarImageSize.Medium && owner.ImagesMedium != null && !Boolean_5)
						{
							return owner.ImagesMedium.get_Images().get_Item(int_21);
						}
						if (eBarImageSize2 == eBarImageSize.Large && owner.ImagesLarge != null && !Boolean_5)
						{
							return owner.ImagesLarge.get_Images().get_Item(int_21);
						}
						if (owner.Images != null)
						{
							if (int_21 == int_6)
							{
								if (image_5 == null)
								{
									image_5 = owner.Images.get_Images().get_Item(int_21);
								}
								return image_5;
							}
							return owner.Images.get_Images().get_Item(int_21);
						}
					}
					else if (m_Parent is SideBarPanelItem && ((SideBarPanelItem)m_Parent).ItemImageSize != 0)
					{
						eBarImageSize itemImageSize = ((SideBarPanelItem)m_Parent).ItemImageSize;
						if (itemImageSize == eBarImageSize.Medium && owner.ImagesMedium != null)
						{
							return owner.ImagesMedium.get_Images().get_Item(int_21);
						}
						if (itemImageSize == eBarImageSize.Large && owner.ImagesLarge != null)
						{
							return owner.ImagesLarge.get_Images().get_Item(int_21);
						}
						if (owner.Images != null)
						{
							return owner.Images.get_Images().get_Item(int_21);
						}
					}
					else if (owner.Images != null)
					{
						if (int_21 == int_6)
						{
							if (image_5 == null)
							{
								image_5 = owner.Images.get_Images().get_Item(int_21);
							}
							return image_5;
						}
						return owner.Images.get_Images().get_Item(int_21);
					}
				}
				catch (Exception)
				{
					return null;
				}
			}
		}
		return null;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeImageFixedSize()
	{
		return !size_4.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFixedSize()
	{
		return !size_5.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetFixedSize()
	{
		TypeDescriptor.GetProperties(this)["FixedSize"]!.SetValue(this, Size.Empty);
	}

	public override void RecalcSize()
	{
		if (!SuspendLayout)
		{
			if (m_Style == eDotNetBarStyle.Office2000 && !base.Boolean_2)
			{
				method_27();
			}
			else
			{
				method_26();
			}
			base.RecalcSize();
		}
	}

	private void method_26()
	{
		Class88.smethod_3(this);
	}

	private void method_27()
	{
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (!BaseItem.IsHandleValid(val))
		{
			return;
		}
		Graphics val2 = Graphics.FromHwnd(val.get_Handle());
		val2.set_PageUnit((GraphicsUnit)2);
		rectangle_1 = Rectangle.Empty;
		rectangle_0 = Rectangle.Empty;
		m_Rect = Rectangle.Empty;
		rectangle_2 = Rectangle.Empty;
		bool flag = false;
		if (method_23(Enum15.const_0) != null)
		{
			flag = true;
		}
		Size size = ((m_Parent == null) ? ImageSize : ((!(m_Parent is ImageItem imageItem)) ? ImageSize : ((!flag || base.IsOnMenu) ? new Size(imageItem.SubItemsImageSize.Width, imageItem.SubItemsImageSize.Height) : ((Orientation != 0) ? new Size(imageItem.SubItemsImageSize.Width, ImageSize.Height) : new Size(ImageSize.Width, imageItem.SubItemsImageSize.Height)))));
		Font val3 = null;
		val3 = ((font_1 == null) ? method_40(null) : font_1);
		eTextFormat eTextFormat_ = method_38();
		Size size2 = ((m_Orientation != eOrientation.Vertical || base.IsOnMenu) ? Class55.smethod_4(val2, m_Text, val3, 0, eTextFormat_) : Class55.smethod_7(val2, m_Text, val3, Size.Empty, eTextFormat_));
		if (base.IsOnMenu)
		{
			size.Width += 4;
			if (size2.Height > size.Height)
			{
				m_Rect.Height = size2.Height + 4;
			}
			else
			{
				m_Rect.Height = size.Height + 4;
			}
			m_Rect.Height += int_10;
			if (base.IsOnCustomizeMenu)
			{
				rectangle_0 = new Rectangle(m_Rect.Height, 0, m_Rect.Height, m_Rect.Height);
			}
			else
			{
				rectangle_0 = new Rectangle(0, 0, size.Width, m_Rect.Height);
			}
			m_Rect.Width = size2.Width;
			if (String_1 != "")
			{
				Size size3 = Class55.smethod_4(val2, String_1, val3, 0, eTextFormat_);
				m_Rect.Width += size3.Width + 14;
			}
			rectangle_1 = new Rectangle(rectangle_0.Right + 2, (m_Rect.Height - size2.Height) / 2, m_Rect.Width, size2.Height);
			m_Rect.Width += rectangle_0.Right + 2 + 24;
			m_Rect.Width += int_11;
		}
		else
		{
			if (m_Orientation == eOrientation.Horizontal && (eImagePosition_0 == eImagePosition.Left || eImagePosition_0 == eImagePosition.Right))
			{
				size.Width += 10;
				if (size2.Height > size.Height)
				{
					m_Rect.Height = size2.Height + 6;
				}
				else
				{
					m_Rect.Height = size.Height + 6;
				}
				m_Rect.Height += int_10;
				rectangle_0 = Rectangle.Empty;
				if (eButtonStyle_0 != eButtonStyle.TextOnlyAlways && flag)
				{
					rectangle_0 = new Rectangle(0, (m_Rect.Height - size.Height) / 2, size.Width, size.Height);
				}
				rectangle_1 = Rectangle.Empty;
				if (eButtonStyle_0 != 0 || !flag)
				{
					if (rectangle_0.Right > 0)
					{
						m_Rect.Width = size2.Width + 1;
						rectangle_1 = new Rectangle(rectangle_0.Right - 2, 2, m_Rect.Width, m_Rect.Height - 4);
					}
					else
					{
						m_Rect.Width = size2.Width + 6;
						rectangle_1 = new Rectangle(3, 2, m_Rect.Width, m_Rect.Height - 4);
					}
				}
				m_Rect.Width += rectangle_0.Right;
				m_Rect.Width += int_11;
			}
			else if (m_Orientation == eOrientation.Horizontal)
			{
				if (size2.Width > size.Width)
				{
					m_Rect.Width = size2.Width + 6;
				}
				else
				{
					m_Rect.Width = size.Width + 6;
				}
				m_Rect.Height = size.Height + size2.Height + 10;
				m_Rect.Width += int_11;
				m_Rect.Height += int_10;
				if (eImagePosition_0 == eImagePosition.Top)
				{
					rectangle_0 = new Rectangle(0, int_10 / 2, m_Rect.Width, size.Height + 2);
					rectangle_1 = new Rectangle((m_Rect.Width - size2.Width) / 2, rectangle_0.Bottom + 2, size2.Width, size2.Height + 5);
				}
				else
				{
					rectangle_1 = new Rectangle((m_Rect.Width - size2.Width) / 2, int_10 / 2, size2.Width, size2.Height + 2);
					rectangle_0 = new Rectangle(0, rectangle_1.Bottom + 2, m_Rect.Width, size.Height + 5);
				}
			}
			else
			{
				if (size2.Height > size.Height && eButtonStyle_0 != 0)
				{
					m_Rect.Width = size2.Height + 6;
				}
				else
				{
					m_Rect.Width = size.Width + 6;
				}
				m_Rect.Width += int_11;
				if (eButtonStyle_0 == eButtonStyle.Default && flag)
				{
					m_Rect.Height = size.Height + 6;
				}
				else if (flag)
				{
					m_Rect.Height = size.Height + size2.Width + 12;
				}
				else
				{
					m_Rect.Height = size2.Width + 6;
				}
				if (eImagePosition_0 != eImagePosition.Top && eImagePosition_0 != 0)
				{
					rectangle_1 = new Rectangle((m_Rect.Width - size2.Height) / 2, 0, size2.Height, size2.Width + 5);
					if (flag)
					{
						rectangle_0 = new Rectangle(0, rectangle_1.Bottom + 2, m_Rect.Width, size.Height + 5);
					}
				}
				else
				{
					if (flag)
					{
						rectangle_0 = new Rectangle(0, 0, m_Rect.Width, size.Height + 5);
					}
					rectangle_1 = new Rectangle((m_Rect.Width - size2.Height) / 2, rectangle_0.Bottom + 2, size2.Height, size2.Width + 5);
				}
				m_Rect.Height += int_10;
			}
			if ((SubItems.Count > 0 || PopupType == ePopupType.Container) && ShowSubItems && (!IsOnMenuBar || method_22() != null))
			{
				if (m_Orientation == eOrientation.Horizontal)
				{
					rectangle_2 = new Rectangle(m_Rect.Right, 0, 12, m_Rect.Height);
					m_Rect.Width += rectangle_2.Width;
				}
				else
				{
					rectangle_2 = new Rectangle(0, m_Rect.Bottom, m_Rect.Width, 12);
					m_Rect.Height += rectangle_2.Height;
				}
			}
		}
		val2.Dispose();
		val = null;
	}

	private void method_28(Graphics graphics_0, Rectangle rectangle_3)
	{
		ControlPaint.DrawBorder3D(graphics_0, rectangle_3, (Border3DStyle)2, (Border3DSide)2063);
		if (!bool_26)
		{
			rectangle_3.Inflate(-1, -1);
			graphics_0.FillRectangle((Brush)(object)ColorFunctions.GetPushedBrush(), rectangle_3);
		}
		Point[] array = new Point[3];
		array[0].X = rectangle_3.Left + (rectangle_3.Width - 6) / 2;
		array[0].Y = rectangle_3.Top + (rectangle_3.Height - 6) / 2 + 3;
		array[1].X = array[0].X + 2;
		array[1].Y = array[0].Y + 2;
		array[2].X = array[1].X + 4;
		array[2].Y = array[1].Y - 4;
		graphics_0.DrawLines(SystemPens.get_ControlText(), array);
		array[0].X++;
		array[1].X++;
		array[2].X++;
		graphics_0.DrawLines(SystemPens.get_ControlText(), array);
	}

	protected internal override void OnItemAdded(BaseItem item)
	{
		base.OnItemAdded(item);
		OnAppearanceChanged();
	}

	protected override void OnExternalSizeChange()
	{
		base.OnExternalSizeChange();
		Class88.smethod_0(this);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override void ContainerLostFocus(bool appLostFocus)
	{
		base.ContainerLostFocus(appLostFocus);
		if (m_Expanded)
		{
			Expanded = false;
			if (m_Parent != null)
			{
				m_Parent.AutoExpand = false;
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalKeyDown(KeyEventArgs objArg)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		base.InternalKeyDown(objArg);
		if (Expanded || objArg.get_Handled())
		{
			return;
		}
		if ((int)objArg.get_KeyCode() != 13 && (int)objArg.get_KeyCode() != 13 && ((int)objArg.get_KeyCode() != 39 || !base.IsOnMenu))
		{
			if ((int)objArg.get_KeyCode() == 27 && SubItems.Count > 0 && Expanded)
			{
				Expanded = false;
				if (m_Parent != null)
				{
					m_Parent.AutoExpand = false;
				}
				objArg.set_Handled(true);
				return;
			}
		}
		else if (SubItems.Count > 0 && method_2())
		{
			if (Expanded)
			{
				if (m_Parent != null)
				{
					m_Parent.AutoExpand = false;
				}
				Expanded = false;
			}
			else
			{
				if (m_Parent != null)
				{
					m_Parent.AutoExpand = true;
				}
				Expanded = true;
			}
			objArg.set_Handled(true);
			return;
		}
		base.InternalKeyDown(objArg);
	}

	private void method_29(bool bool_49)
	{
		if (bool_49 == bool_26)
		{
			return;
		}
		if (bool_40)
		{
			method_31();
			if (bool_41)
			{
				StopPulse();
			}
		}
		if (Boolean_7 && method_2() && Displayed && Visible && WidthInternal > 0 && HeightInternal > 0)
		{
			int int_ = (bool_49 ? 1 : (-1));
			int int_2 = (bool_49 ? 10 : 255);
			bool_26 = bool_49;
			method_30(int_, int_2);
		}
		else
		{
			bool_26 = bool_49;
		}
	}

	private void method_30(int int_21, int int_22)
	{
		bool flag = false;
		readerWriterLock_0.AcquireReaderLock(-1);
		try
		{
			flag = bitmap_0 == null;
		}
		finally
		{
			readerWriterLock_0.ReleaseReaderLock();
		}
		if (flag)
		{
			bool flag2 = bool_26;
			bool_26 = true;
			try
			{
				bool isReaderLockHeld = readerWriterLock_0.IsReaderLockHeld;
				LockCookie lockCookie = default(LockCookie);
				if (isReaderLockHeld)
				{
					lockCookie = readerWriterLock_0.UpgradeToWriterLock(-1);
				}
				else
				{
					readerWriterLock_0.AcquireWriterLock(-1);
				}
				try
				{
					bitmap_0 = method_34();
				}
				finally
				{
					if (isReaderLockHeld)
					{
						readerWriterLock_0.DowngradeFromWriterLock(ref lockCookie);
					}
					else
					{
						readerWriterLock_0.ReleaseWriterLock();
					}
				}
			}
			finally
			{
				bool_26 = flag2;
			}
		}
		int_19 = int_21;
		int_20 = int_22;
		Class27.smethod_0(this, method_33);
		bool_46 = true;
	}

	private void method_31()
	{
		if (bool_46)
		{
			bool_46 = false;
			Class27.smethod_2(this, method_33);
			bool flag = false;
			readerWriterLock_0.AcquireReaderLock(-1);
			try
			{
				flag = bitmap_0 != null;
			}
			finally
			{
				readerWriterLock_0.ReleaseReaderLock();
			}
			if (flag)
			{
				method_32();
			}
			if (int_20 > 230)
			{
				int_20 = 255;
			}
			else if (int_20 < 0)
			{
				int_20 = 0;
			}
		}
	}

	private void method_32()
	{
		bool isReaderLockHeld = readerWriterLock_0.IsReaderLockHeld;
		LockCookie lockCookie = default(LockCookie);
		if (isReaderLockHeld)
		{
			lockCookie = readerWriterLock_0.UpgradeToWriterLock(-1);
		}
		else
		{
			readerWriterLock_0.AcquireWriterLock(-1);
		}
		try
		{
			((Image)bitmap_0).Dispose();
			bitmap_0 = null;
		}
		finally
		{
			if (isReaderLockHeld)
			{
				readerWriterLock_0.DowngradeFromWriterLock(ref lockCookie);
			}
			else
			{
				readerWriterLock_0.ReleaseWriterLock();
			}
		}
	}

	private void method_33(object sender, EventArgs e)
	{
		int_20 += int_19 * (bool_40 ? int_16 : int_15);
		if ((int_19 < 0 && int_20 <= 0) || (int_19 > 0 && int_20 >= 255))
		{
			if (bool_40)
			{
				int_19 *= -1;
				if (int_20 >= 255)
				{
					int_20 = 255;
				}
				else
				{
					int_20 = 0;
				}
				int_18++;
				if (int_17 > 0 && int_18 > int_17)
				{
					method_31();
					StopPulse();
				}
			}
			else
			{
				method_31();
			}
		}
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null && Class109.smethod_11(val))
		{
			try
			{
				val.Invalidate(DisplayRectangle);
			}
			catch (ObjectDisposedException)
			{
			}
			catch (Win32Exception)
			{
			}
		}
	}

	private Bitmap method_34()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		Bitmap val = new Bitmap(WidthInternal, HeightInternal, (PixelFormat)925707);
		val.MakeTransparent();
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			object containerControl = ContainerControl;
			Control val3 = (Control)((containerControl is Control) ? containerControl : null);
			bool flag = false;
			ItemPaintArgs itemPaintArgs = null;
			if (val3 is ItemControl)
			{
				flag = ((ItemControl)(object)val3).AntiAlias;
				itemPaintArgs = ((ItemControl)(object)val3).vmethod_5(val2);
			}
			else if (val3 is Bar)
			{
				flag = ((Bar)(object)val3).AntiAlias;
				itemPaintArgs = ((Bar)(object)val3).method_5(val2);
			}
			else if (val3 is ButtonX)
			{
				flag = ((ButtonX)(object)val3).AntiAlias;
				itemPaintArgs = ((ButtonX)(object)val3).vmethod_0(val2);
			}
			Matrix val4 = new Matrix();
			val4.Translate((float)(-DisplayRectangle.X), (float)(-DisplayRectangle.Y), (MatrixOrder)1);
			val2.set_Transform(val4);
			if (flag)
			{
				val2.set_SmoothingMode((SmoothingMode)4);
				val2.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
			if (itemPaintArgs == null)
			{
				((Image)val).Dispose();
				return null;
			}
			Paint(itemPaintArgs);
			return val;
		}
		finally
		{
			val2.Dispose();
		}
	}

	public void Pulse()
	{
		Pulse(0);
	}

	public void Pulse(int pulseBeatCount)
	{
		if (DesignMode || eHotTrackingStyle_0 == eHotTrackingStyle.None)
		{
			return;
		}
		int_17 = pulseBeatCount;
		int_18 = 0;
		if (!bool_40)
		{
			bool_40 = true;
			if (!bool_26)
			{
				method_30(1, 0);
			}
		}
	}

	public void StopPulse()
	{
		if (bool_40)
		{
			bool_40 = false;
			if (!bool_26)
			{
				method_31();
			}
		}
	}

	protected override void OnEnabledChanged()
	{
		if (!method_2())
		{
			method_29(bool_49: false);
			method_36(bool_49: false);
		}
		base.OnEnabledChanged();
	}

	public override void InternalMouseMove(MouseEventArgs objArg)
	{
		base.InternalMouseMove(objArg);
		if (!DisplayRectangle.Contains(objArg.get_X(), objArg.get_Y()))
		{
			return;
		}
		bool flag = false;
		Rectangle rectangle = method_42();
		if (!rectangle.IsEmpty && method_2())
		{
			rectangle.Offset(DisplayRectangle.Location);
			if (rectangle.Contains(objArg.get_X(), objArg.get_Y()))
			{
				if (!bool_27)
				{
					bool_27 = true;
					flag = true;
				}
			}
			else if (bool_27)
			{
				bool_27 = false;
				flag = true;
			}
		}
		if (!bool_26)
		{
			method_29(bool_49: true);
			if (method_2() || base.IsOnMenu)
			{
				flag = true;
			}
		}
		if (flag)
		{
			Refresh();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override void InternalMouseLeave()
	{
		base.InternalMouseLeave();
		bool_27 = false;
		method_29(bool_49: false);
		bool_28 = false;
		if (method_2() || base.IsOnMenu)
		{
			Refresh();
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseHover()
	{
		base.InternalMouseHover();
		if ((SubItems.Count > 0 || (PopupType == ePopupType.Container && !base.IsOnCustomizeMenu)) && base.IsOnMenu && ShowSubItems && !Expanded && method_2())
		{
			Expanded = true;
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		base.InternalMouseDown(objArg);
		ButtonMouseDown(objArg);
	}

	protected virtual void ButtonMouseDown(MouseEventArgs objArg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)objArg.get_Button() != 1048576 || !method_2())
		{
			return;
		}
		bool_28 = true;
		if ((IsOnMenuBar || ShouldAutoExpandOnClick) && !DesignMode)
		{
			if (objArg.get_Clicks() == 2)
			{
				return;
			}
			if ((!ShowSubItems && !ShouldAutoExpandOnClick) || (SubItems.Count <= 0 && PopupType != ePopupType.Container))
			{
				Refresh();
			}
			else if (Expanded)
			{
				Expanded = false;
				if (m_Parent != null)
				{
					m_Parent.AutoExpand = false;
				}
			}
			else
			{
				if (IsOnMenuBar && m_Parent != null)
				{
					m_Parent.AutoExpand = true;
				}
				Expanded = true;
			}
		}
		else if ((IsOnMenuBar || ShouldAutoExpandOnClick) && DesignMode)
		{
			Expanded = !Expanded;
		}
		else if (!base.IsOnMenu)
		{
			if ((SubItems.Count > 0 || (PopupType == ePopupType.Container && !base.IsOnCustomizeMenu)) && ShowSubItems)
			{
				if (!m_Expanded)
				{
					Rectangle rectangle = method_42();
					rectangle.Width += 2;
					rectangle.Height += 2;
					rectangle.Offset(m_Rect.X, m_Rect.Y);
					if (rectangle.Contains(objArg.get_X(), objArg.get_Y()))
					{
						if (m_Style == eDotNetBarStyle.Office2000)
						{
							bool_28 = false;
						}
						Expanded = true;
					}
				}
				else
				{
					Expanded = false;
				}
			}
			Refresh();
		}
		else if ((SubItems.Count > 0 || (PopupType == ePopupType.Container && !base.IsOnCustomizeMenu)) && ShowSubItems)
		{
			if (!base.IsOnMenu || !Expanded)
			{
				Expanded = !m_Expanded;
			}
		}
		else
		{
			Refresh();
		}
	}

	internal override void vmethod_0()
	{
		if (base.VisibleSubItems > 0 && (base.IsOnMenu || IsOnMenuBar || bool_21 || ShouldAutoExpandOnClick))
		{
			if (Expanded)
			{
				Expanded = false;
				if (Parent != null && IsOnMenuBar)
				{
					Parent.AutoExpand = false;
				}
			}
			else
			{
				if (IsOnMenuBar && Parent != null)
				{
					Parent.AutoExpand = true;
				}
				Expanded = true;
			}
			Refresh();
			bool_21 = false;
		}
		else
		{
			RaiseClick(eEventSource.Keyboard);
		}
	}

	internal bool method_35()
	{
		return ShouldAutoExpandOnClick;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		bool flag = true;
		Rectangle rectangle = method_42();
		rectangle.Width += 2;
		rectangle.Height += 2;
		rectangle.Offset(m_Rect.X, m_Rect.Y);
		if ((int)objArg.get_Button() == 1048576)
		{
			if (method_2() && !DesignMode && eMenuVisibility_0 == eMenuVisibility.VisibleIfRecentlyUsed && !bool_35 && base.IsOnMenu)
			{
				bool_35 = true;
				for (BaseItem parent = Parent; parent != null; parent = parent.Parent)
				{
					if (parent is IPersonalizedMenuItem personalizedMenuItem)
					{
						personalizedMenuItem.RecentlyUsed = true;
					}
				}
			}
			if (!base.IsOnMenu && (SubItems.Count > 0 || PopupType == ePopupType.Container) && ShowSubItems && m_HotSubItem == null && !DesignMode && !IsOnMenuBar && !ShouldAutoExpandOnClick)
			{
				object containerControl = ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val == null)
				{
					return;
				}
				val = null;
				if (!rectangle.Contains(objArg.get_X(), objArg.get_Y()))
				{
					bool flag2 = true;
					if (PopupType == ePopupType.ToolBar || PopupType == ePopupType.Menu)
					{
						bool expanded = Expanded;
						base.InternalMouseUp(objArg);
						if (!expanded && Expanded)
						{
							flag2 = false;
						}
						flag = false;
					}
					if (flag2)
					{
						BaseItem.CollapseAll(this);
					}
				}
			}
		}
		if ((!base.IsOnMenu || Parent is ItemContainer) && (SubItems.Count > 0 || (PopupType == ePopupType.Container && !base.IsOnCustomizeMenu)) && ShowSubItems && rectangle.Contains(objArg.get_X(), objArg.get_Y()))
		{
			flag = false;
		}
		if (flag)
		{
			base.InternalMouseUp(objArg);
		}
		if (bool_28)
		{
			bool_28 = false;
			if (!base.IsOnMenu || !(Parent is ButtonItem))
			{
				Refresh();
			}
		}
	}

	internal void method_36(bool bool_49)
	{
		bool_28 = bool_49;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override void InternalDoubleClick(MouseButtons mb, Point mpos)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		base.InternalDoubleClick(mb, mpos);
		if (Expanded && IsOnMenuBar && m_Parent != null && !DesignMode && PopupType == ePopupType.Menu && (PersonalizedMenus == ePersonalizedMenus.Both || PersonalizedMenus == ePersonalizedMenus.DisplayOnClick) && base.PopupControl is MenuPanel)
		{
			((MenuPanel)(object)base.PopupControl).method_25();
		}
	}

	private void method_37()
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Invalid comparison between Unknown and I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between Unknown and I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		if (image_0 == null && int_6 < 0 && icon_1 == null)
		{
			return;
		}
		if (image_3 != null)
		{
			image_3.Dispose();
		}
		image_3 = null;
		if (icon_0 != null)
		{
			icon_0.Dispose();
		}
		icon_0 = null;
		Class271 @class = method_23(Enum15.const_0);
		if (@class == null)
		{
			return;
		}
		if (GetOwner() is IOwner && ((IOwner)GetOwner()).DisabledImagesGrayScale)
		{
			if (@class.Boolean_0)
			{
				icon_0 = Class109.smethod_59(@class.Icon_0);
			}
			else
			{
				ref Image reference = ref image_3;
				Image obj = @class.Image_0;
				reference = (Image)(object)Class31.smethod_1((obj is Bitmap) ? obj : null);
			}
		}
		if (icon_0 == null && image_3 == null)
		{
			PixelFormat val = (PixelFormat)2498570;
			if (!@class.Boolean_0 && @class.Image_0 != null)
			{
				val = @class.Image_0.get_PixelFormat();
			}
			if ((int)val == 196865 || (int)val == 197634 || (int)val == 198659)
			{
				val = (PixelFormat)2498570;
			}
			Bitmap val2 = new Bitmap(@class.Int32_0, @class.Int32_1, val);
			image_3 = (Image)new Bitmap(@class.Int32_0, @class.Int32_1, val);
			Graphics val3 = Graphics.FromImage((Image)(object)val2);
			SolidBrush val4 = new SolidBrush(Color.White);
			try
			{
				val3.FillRectangle((Brush)(object)val4, 0, 0, @class.Int32_0, @class.Int32_1);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
			@class.method_0(val3, new Rectangle(0, 0, @class.Int32_0, @class.Int32_1));
			val3.Dispose();
			val3 = Graphics.FromImage(image_3);
			val2.MakeTransparent(Color.White);
			if ((m_Style == eDotNetBarStyle.OfficeXP || m_Style == eDotNetBarStyle.Office2003 || m_Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(m_Style)) && Class92.int_74 >= 8)
			{
				float[][] array = new float[5][];
				float[] array2 = (array[0] = new float[5]);
				float[] array3 = (array[1] = new float[5]);
				float[] array4 = (array[2] = new float[5]);
				array[3] = new float[5] { 0.5f, 0.5f, 0.5f, 0.5f, 0f };
				float[] array5 = (array[4] = new float[5]);
				ColorMatrix colorMatrix = new ColorMatrix(array);
				ImageAttributes val5 = new ImageAttributes();
				val5.ClearColorKey();
				val5.SetColorMatrix(colorMatrix);
				val3.DrawImage((Image)(object)val2, new Rectangle(0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height()), 0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height(), (GraphicsUnit)2, val5);
			}
			else
			{
				ControlPaint.DrawImageDisabled(val3, (Image)(object)val2, 0, 0, ColorFunctions.MenuBackColor(val3));
			}
			val3.Dispose();
			val3 = null;
			((Image)val2).Dispose();
			val2 = null;
			@class.Dispose();
		}
	}

	private eTextFormat method_38()
	{
		eTextFormat eTextFormat2 = eTextFormat.Default;
		eTextFormat2 = (bool_36 ? (eTextFormat2 | eTextFormat.WordBreak) : (eTextFormat2 | eTextFormat.SingleLine));
		return eTextFormat2 | eTextFormat.VerticalCenter;
	}

	private Enum10 method_39()
	{
		return (Enum10)1310724;
	}

	internal Font method_40(ItemPaintArgs itemPaintArgs_1)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		Font val = null;
		if (itemPaintArgs_1 != null)
		{
			val = itemPaintArgs_1.Font;
		}
		if (val == null)
		{
			Control val2 = null;
			if (itemPaintArgs_1 != null)
			{
				val2 = itemPaintArgs_1.ContainerControl;
			}
			if (val2 == null)
			{
				object containerControl = ContainerControl;
				val2 = (Control)((containerControl is Control) ? containerControl : null);
			}
			val = ((val2 == null || val2.get_Font() == null) ? SystemInformation.get_MenuFont() : val2.get_Font());
		}
		bool flag = false;
		if (bool_26)
		{
			try
			{
				if (bool_30)
				{
					val = new Font(val, (FontStyle)(val.get_Style() | 4));
					flag = true;
				}
				if (bool_31)
				{
					val = new Font(val, (FontStyle)(val.get_Style() | 1));
					flag = true;
				}
			}
			catch
			{
				object obj = val.Clone();
				val = (Font)((obj is Font) ? obj : null);
			}
		}
		if (!flag && (bool_32 || bool_33 || bool_34))
		{
			FontStyle val3 = val.get_Style();
			if (bool_32)
			{
				val3 = (FontStyle)(val3 | 1);
			}
			if (bool_33)
			{
				val3 = (FontStyle)(val3 | 2);
			}
			if (bool_34)
			{
				val3 = (FontStyle)(val3 | 4);
			}
			Font val4 = null;
			try
			{
				val4 = new Font(val, val3);
			}
			catch
			{
			}
			if (val4 != null)
			{
				val = val4;
			}
		}
		return val;
	}

	protected virtual void OnCheckedChanged()
	{
		if (string_8 != "" && bool_29 && Parent != null)
		{
			foreach (BaseItem subItem in Parent.SubItems)
			{
				if (subItem != this && subItem is ButtonItem buttonItem && buttonItem.OptionGroup == string_8 && buttonItem.Checked)
				{
					buttonItem.Checked = false;
				}
			}
		}
		InvokeCheckedChanged();
	}

	protected internal override void OnVisibleChanged(bool bVisible)
	{
		base.OnVisibleChanged(bVisible);
		if (!bVisible)
		{
			method_31();
		}
		if (!bVisible && Checked && string_8 != "")
		{
			Checked = false;
			if (Parent == null)
			{
				return;
			}
			{
				foreach (BaseItem subItem in Parent.SubItems)
				{
					if (subItem != this && subItem.method_2() && subItem.Visible && subItem is ButtonItem buttonItem && buttonItem.OptionGroup == string_8)
					{
						buttonItem.Checked = true;
						break;
					}
				}
				return;
			}
		}
		if (!bVisible || !(string_8 != "") || base.VisibleSubItems > 1)
		{
			return;
		}
		bool flag = true;
		if (Parent != null)
		{
			foreach (BaseItem subItem2 in Parent.SubItems)
			{
				if (subItem2 != this && subItem2.method_2() && subItem2.Visible && subItem2 is ButtonItem buttonItem2 && buttonItem2.OptionGroup == string_8 && buttonItem2.Checked)
				{
					flag = false;
					break;
				}
			}
		}
		if (flag)
		{
			Checked = true;
		}
	}

	internal void method_41(bool bool_49)
	{
		bool_29 = bool_49;
	}

	protected virtual void InvokeCheckedChanged()
	{
		if (eventHandler_19 != null)
		{
			eventHandler_19(this, new EventArgs());
		}
		GetIOwnerItemEvents()?.InvokeCheckedChanged(this, new EventArgs());
	}

	protected virtual void InvokeOptionGroupChanging(OptionGroupChangingEventArgs e)
	{
		if (optionGroupChangingEventHandler_0 != null)
		{
			optionGroupChangingEventHandler_0(this, e);
		}
		if (!e.Cancel)
		{
			GetIOwnerItemEvents()?.InvokeOptionGroupChanging(this, e);
		}
	}

	protected override void OnClick()
	{
		if (bool_43 && string_8 == "")
		{
			Checked = !Checked;
		}
		base.OnClick();
		if (string_8 != "" && !bool_29)
		{
			Checked = true;
		}
		ExecuteCommand();
	}

	protected override void OnCommandChanged()
	{
		if (!DesignMode && base.Command == null)
		{
			Enabled = false;
		}
		base.OnCommandChanged();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeForeColor()
	{
		if (color_0.IsEmpty)
		{
			return false;
		}
		return true;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeHotForeColor()
	{
		if (color_1.IsEmpty)
		{
			return false;
		}
		return true;
	}

	internal Rectangle method_42()
	{
		Rectangle rectangle = Rectangle_1;
		if (SplitButton && (ButtonStyle == eButtonStyle.ImageAndText || ImagePosition == eImagePosition.Top || ImagePosition == eImagePosition.Bottom) && (Image != null || ImageIndex >= 0) && Text.Length > 0)
		{
			Rectangle rectangle2 = Rectangle_2;
			rectangle2.Inflate(0, -2);
			if (ImagePosition == eImagePosition.Left)
			{
				if (Orientation == eOrientation.Horizontal)
				{
					rectangle2.X -= 3;
				}
				else
				{
					rectangle2.Y -= 6;
				}
			}
			if (rectangle.IsEmpty)
			{
				rectangle = rectangle2;
				if (eImagePosition_0 == eImagePosition.Top)
				{
					rectangle.X = 0;
					rectangle.Width = m_Rect.Width;
					rectangle.Height = DisplayRectangle.Bottom - rectangle.Y;
				}
				else if (eImagePosition_0 == eImagePosition.Bottom)
				{
					rectangle.X = 0;
					rectangle.Width = m_Rect.Width;
				}
			}
			else
			{
				rectangle = Rectangle.Union(rectangle, rectangle2);
			}
			return rectangle;
		}
		return rectangle;
	}

	protected override void OnDisplayedChanged()
	{
		bool_28 = false;
		bool_26 = false;
	}
}
