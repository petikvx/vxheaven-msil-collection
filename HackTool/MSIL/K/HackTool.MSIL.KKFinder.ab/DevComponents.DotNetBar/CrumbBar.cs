using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[ComVisible(false)]
[Designer(typeof(CrumbBarDesigner))]
[ToolboxItem(true)]
[DefaultEvent("SelectedItemChanged")]
[ToolboxBitmap(typeof(CrumbBar), "CrumbBar.CrumbBar.ico")]
public class CrumbBar : ItemControl
{
	private CrumbBarItemsCollection crumbBarItemsCollection_0;

	private Class180 class180_0;

	private Office2007Renderer office2007Renderer_0;

	private CrumBarSelectionEventHandler crumBarSelectionEventHandler_0;

	private CrumBarSelectionEventHandler crumBarSelectionEventHandler_1;

	private CrumbBarItem crumbBarItem_0;

	private eCrumbBarStyle eCrumbBarStyle_0 = eCrumbBarStyle.Vista;

	private Size size_0 = Size.Empty;

	[Category("Appearance")]
	[Description("Indicates currently selected item")]
	[DefaultValue(null)]
	public CrumbBarItem SelectedItem
	{
		get
		{
			return crumbBarItem_0;
		}
		set
		{
			SetSelectedItem(value, eEventSource.Code);
		}
	}

	[Editor(typeof(CrumbBarItemCollectionEditor), typeof(UITypeEditor))]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public CrumbBarItemsCollection Items => crumbBarItemsCollection_0;

	[Description("Indicates visual style of the control.")]
	[Category("Appearance")]
	[DefaultValue(eCrumbBarStyle.Vista)]
	public eCrumbBarStyle Style
	{
		get
		{
			return eCrumbBarStyle_0;
		}
		set
		{
			if (value != eCrumbBarStyle_0)
			{
				eCrumbBarStyle oldValue = eCrumbBarStyle_0;
				eCrumbBarStyle_0 = value;
				OnStyleChanged(oldValue, value);
			}
		}
	}

	[Browsable(false)]
	public Office2007ColorTable VistaColorTable => office2007Renderer_0.ColorTable;

	protected override Size DefaultSize => new Size(200, 22);

	[Browsable(false)]
	[Localizable(true)]
	public Padding Padding
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Padding();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_Padding(value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DefaultValue(false)]
	public override bool AutoSize
	{
		get
		{
			return base.AutoSize;
		}
		set
		{
			if (((Control)this).get_AutoSize() != value)
			{
				base.AutoSize = value;
				method_30();
				method_31();
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override Image BackgroundImage
	{
		get
		{
			return ((Control)this).get_BackgroundImage();
		}
		set
		{
			((Control)this).set_BackgroundImage(value);
		}
	}

	[Browsable(false)]
	public override eBarImageSize ImageSize
	{
		get
		{
			return base.ImageSize;
		}
		set
		{
			base.ImageSize = value;
		}
	}

	[Browsable(false)]
	public override ImageList ImagesLarge
	{
		get
		{
			return base.ImagesLarge;
		}
		set
		{
			base.ImagesLarge = value;
		}
	}

	[Browsable(false)]
	public override ImageList ImagesMedium
	{
		get
		{
			return base.ImagesMedium;
		}
		set
		{
			base.ImagesMedium = value;
		}
	}

	[Browsable(false)]
	public override Font KeyTipsFont
	{
		get
		{
			return base.KeyTipsFont;
		}
		set
		{
			base.KeyTipsFont = value;
		}
	}

	[Browsable(false)]
	public override bool ShowShortcutKeysInToolTips
	{
		get
		{
			return base.ShowShortcutKeysInToolTips;
		}
		set
		{
			base.ShowShortcutKeysInToolTips = value;
		}
	}

	[Browsable(false)]
	public override bool ThemeAware
	{
		get
		{
			return base.ThemeAware;
		}
		set
		{
			base.ThemeAware = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
		}
	}

	[Description("Occurs before SelectedItem has changed and provides opportunity to cancel the change.")]
	public event CrumBarSelectionEventHandler SelectedItemChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			crumBarSelectionEventHandler_0 = (CrumBarSelectionEventHandler)Delegate.Combine(crumBarSelectionEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			crumBarSelectionEventHandler_0 = (CrumBarSelectionEventHandler)Delegate.Remove(crumBarSelectionEventHandler_0, value);
		}
	}

	public event CrumBarSelectionEventHandler SelectedItemChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			crumBarSelectionEventHandler_1 = (CrumBarSelectionEventHandler)Delegate.Combine(crumBarSelectionEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			crumBarSelectionEventHandler_1 = (CrumBarSelectionEventHandler)Delegate.Remove(crumBarSelectionEventHandler_1, value);
		}
	}

	public CrumbBar()
	{
		crumbBarItemsCollection_0 = new CrumbBarItemsCollection(this);
		class180_0 = new Class180();
		class180_0.GlobalItem = false;
		class180_0.ContainerControl = this;
		class180_0.Displayed = true;
		class180_0.Style = eDotNetBarStyle.Office2007;
		base.ColorScheme.EDotNetBarStyle_0 = eDotNetBarStyle.Office2007;
		class180_0.method_6(this);
		method_28();
		SetBaseItemContainer(class180_0);
	}

	public void SetSelectedItem(CrumbBarItem selection, eEventSource source)
	{
		bool flag;
		if (flag = selection != crumbBarItem_0)
		{
			CrumbBarSelectionEventArgs crumbBarSelectionEventArgs = new CrumbBarSelectionEventArgs(selection);
			OnSelectedItemChanging(crumbBarSelectionEventArgs);
			if (crumbBarSelectionEventArgs.Cancel)
			{
				return;
			}
			selection = crumbBarSelectionEventArgs.NewSelectedItem;
		}
		if (crumbBarItem_0 != null)
		{
			crumbBarItem_0.IsSelected = false;
		}
		ArrayList arrayList = new ArrayList();
		if (selection == null)
		{
			selection = method_27();
		}
		class180_0.Expanded = false;
		class180_0.method_17();
		if (selection != null)
		{
			for (CrumbBarItem crumbBarItem = selection; crumbBarItem != null; crumbBarItem = crumbBarItem.Parent as CrumbBarItem)
			{
				arrayList.Insert(0, method_26(crumbBarItem));
			}
			method_25(selection);
		}
		class180_0.method_18();
		if (selection != null)
		{
			class180_0.SubItems.AddRange((BaseItem[])arrayList.ToArray(typeof(BaseItem)));
		}
		class180_0.NeedRecalcSize = true;
		crumbBarItem_0 = selection;
		if (crumbBarItem_0 != null)
		{
			crumbBarItem_0.IsSelected = true;
		}
		RecalcLayout();
		if (flag)
		{
			CrumbBarSelectionEventArgs e = new CrumbBarSelectionEventArgs(selection);
			OnSelectedItemChanged(e);
		}
	}

	internal void method_24()
	{
		method_25(crumbBarItem_0);
	}

	private void method_25(CrumbBarItem crumbBarItem_1)
	{
		Class271 @class = crumbBarItem_1.method_22();
		if (@class != null)
		{
			class180_0.LabelItem_0.Visible = true;
			if (@class.Boolean_0)
			{
				class180_0.LabelItem_0.Icon = @class.Icon_0;
			}
			else
			{
				class180_0.LabelItem_0.Image = @class.Image_0;
			}
		}
		else
		{
			class180_0.LabelItem_0.Visible = false;
		}
	}

	private object method_26(CrumbBarItem crumbBarItem_1)
	{
		int num = 2;
		Class183 @class;
		while (true)
		{
			if (num < class180_0.SubItems.Count)
			{
				@class = class180_0.SubItems[num] as Class183;
				if (@class != null && @class.CrumbBarItem_0 == crumbBarItem_1)
				{
					break;
				}
				num++;
				continue;
			}
			return Class183.smethod_0(crumbBarItem_1);
		}
		return @class;
	}

	internal CrumbBarItem method_27()
	{
		foreach (CrumbBarItem item in Items)
		{
			if (item.Visible)
			{
				return item;
			}
		}
		return null;
	}

	public bool GetIsInSelectedPath(CrumbBarItem item)
	{
		int num = 2;
		while (true)
		{
			if (num < class180_0.SubItems.Count)
			{
				if (class180_0.SubItems[num] is Class183 @class && @class.CrumbBarItem_0 == item)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	protected virtual void OnStyleChanged(eCrumbBarStyle oldValue, eCrumbBarStyle newValue)
	{
		((Control)this).Invalidate();
	}

	public override BaseRenderer GetRenderer()
	{
		if (base.RenderMode == eRenderMode.Global && eCrumbBarStyle_0 == eCrumbBarStyle.Vista)
		{
			return office2007Renderer_0;
		}
		return base.GetRenderer();
	}

	private void method_28()
	{
		office2007Renderer_0 = new Office2007Renderer();
		Office2007ColorTable colorTable = office2007Renderer_0.ColorTable;
		colorTable.CrumbBarItemView = method_29();
		colorTable.Menu.Background = new LinearGradientColorTable(ColorScheme.GetColor("FFF0F0F0"));
		colorTable.Menu.Border = new LinearGradientColorTable(ColorScheme.GetColor("FF646464"));
		colorTable.Menu.Side = new LinearGradientColorTable(ColorScheme.GetColor("FFF1F1F1"));
		colorTable.Menu.SideBorder = new LinearGradientColorTable(ColorScheme.GetColor("FFE2E3E3"));
		colorTable.Menu.SideBorderLight = new LinearGradientColorTable(ColorScheme.GetColor("FFFFFFFF"));
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = colorTable.ButtonItemColors[0];
		office2007ButtonItemColorTable.Default.Text = Color.Black;
		office2007ButtonItemColorTable.MouseOver.Background = new LinearGradientColorTable(ColorScheme.GetColor("34C5EBFF"), ColorScheme.GetColor("7081D8FF"), 90);
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(ColorScheme.GetColor("FF96DBFA"));
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(ColorScheme.GetColor("A0FFFFFF"));
		office2007ButtonItemColorTable.MouseOver.Text = Color.Black;
		office2007ButtonItemColorTable.Pressed = office2007ButtonItemColorTable.MouseOver;
	}

	private CrumbBarItemViewColorTable method_29()
	{
		return smethod_0(new ColorFactory());
	}

	internal static CrumbBarItemViewColorTable smethod_0(ColorFactory colorFactory_0)
	{
		CrumbBarItemViewColorTable crumbBarItemViewColorTable = new CrumbBarItemViewColorTable();
		(crumbBarItemViewColorTable.Default = new CrumbBarItemViewStateColorTable()).Foreground = Color.Black;
		CrumbBarItemViewStateColorTable crumbBarItemViewStateColorTable = (crumbBarItemViewColorTable.MouseOver = new CrumbBarItemViewStateColorTable());
		crumbBarItemViewStateColorTable.Foreground = Color.Black;
		crumbBarItemViewStateColorTable.Background = new BackgroundColorBlendCollection();
		crumbBarItemViewStateColorTable.Background.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(ColorScheme.GetColor("EAF6FD")), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(ColorScheme.GetColor("D7EFFC")), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(ColorScheme.GetColor("BDE6FD")), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(ColorScheme.GetColor("A6D9F4")), 1f)
		});
		crumbBarItemViewStateColorTable.Border = colorFactory_0.GetColor(ColorScheme.GetColor("3C7FB1"));
		crumbBarItemViewStateColorTable.BorderLight = colorFactory_0.GetColor(ColorScheme.GetColor("E0FFFFFF"));
		crumbBarItemViewStateColorTable = (crumbBarItemViewColorTable.MouseOverInactive = new CrumbBarItemViewStateColorTable());
		crumbBarItemViewStateColorTable.Foreground = Color.Black;
		crumbBarItemViewStateColorTable.Background = new BackgroundColorBlendCollection();
		crumbBarItemViewStateColorTable.Background.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(ColorScheme.GetColor("FFF2F2F2")), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(ColorScheme.GetColor("FFEAEAEA")), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(ColorScheme.GetColor("FFDCDCDC")), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(ColorScheme.GetColor("FFCFCFCF")), 1f)
		});
		crumbBarItemViewStateColorTable.Border = colorFactory_0.GetColor(ColorScheme.GetColor("FF8E8F8F"));
		crumbBarItemViewStateColorTable.BorderLight = colorFactory_0.GetColor(ColorScheme.GetColor("E0FFFFFF"));
		crumbBarItemViewStateColorTable = (crumbBarItemViewColorTable.Pressed = new CrumbBarItemViewStateColorTable());
		crumbBarItemViewStateColorTable.Foreground = Color.Black;
		crumbBarItemViewStateColorTable.Background = new BackgroundColorBlendCollection();
		crumbBarItemViewStateColorTable.Background.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(ColorScheme.GetColor("FFC2E4F6")), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(ColorScheme.GetColor("FFC2E4F6")), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(ColorScheme.GetColor("FFA9D9F2")), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(ColorScheme.GetColor("FF90CBEB")), 1f)
		});
		crumbBarItemViewStateColorTable.Border = colorFactory_0.GetColor(ColorScheme.GetColor("FF6E8D9F"));
		crumbBarItemViewStateColorTable.BorderLight = colorFactory_0.GetColor(ColorScheme.GetColor("906E8D9F"));
		return crumbBarItemViewColorTable;
	}

	protected virtual void OnSelectedItemChanging(CrumbBarSelectionEventArgs e)
	{
		crumBarSelectionEventHandler_0?.Invoke(this, e);
	}

	protected virtual void OnSelectedItemChanged(CrumbBarSelectionEventArgs e)
	{
		crumBarSelectionEventHandler_1?.Invoke(this, e);
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		if (!size_0.IsEmpty)
		{
			return size_0;
		}
		if (!Class109.smethod_11((Control)(object)this))
		{
			return ((Control)this).GetPreferredSize(proposedSize);
		}
		if (Items.Count != 0 && Class109.smethod_11((Control)(object)this) && class180_0.SubItems.Count != 0)
		{
			int num = Class52.smethod_2(GetBackgroundStyle());
			num += ((class180_0.Int32_1 > 0) ? class180_0.Int32_1 : 20);
			size_0 = new Size(proposedSize.Width, num);
			return size_0;
		}
		return new Size(((Control)this).GetPreferredSize(proposedSize).Width, 22);
	}

	private void method_30()
	{
		size_0 = Size.Empty;
	}

	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_AutoSize())
		{
			Size preferredSize = ((Control)this).get_PreferredSize();
			if (preferredSize.Width > 0)
			{
				width = preferredSize.Width;
			}
			if (preferredSize.Height > 0)
			{
				height = preferredSize.Height;
			}
		}
		((Control)this).SetBoundsCore(x, y, width, height, specified);
	}

	private void method_31()
	{
		if (((Control)this).get_AutoSize())
		{
			Size preferredSize = ((Control)this).get_PreferredSize();
			if (preferredSize.Width > 0 && preferredSize.Height > 0)
			{
				((Control)this).set_Size(((Control)this).get_PreferredSize());
			}
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		if (((Control)this).get_AutoSize())
		{
			method_31();
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		if (Class92.smethod_0() || !Class92.bool_0)
		{
			e.get_Graphics().Clear(SystemColors.Control);
		}
	}
}
