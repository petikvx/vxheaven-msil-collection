using System;
using System.Collections;
using System.Drawing;
using DevComponents.AdvTree.Display;

namespace DevComponents.DotNetBar.Rendering;

public class Office2007ColorTable : IDisposable, IElementStyleClassProvider
{
	private Office2007ButtonItemColorTableCollection office2007ButtonItemColorTableCollection_0 = new Office2007ButtonItemColorTableCollection();

	private Office2007ButtonItemColorTableCollection office2007ButtonItemColorTableCollection_1 = new Office2007ButtonItemColorTableCollection();

	private Office2007ButtonItemColorTableCollection office2007ButtonItemColorTableCollection_2 = new Office2007ButtonItemColorTableCollection();

	private Office2007RibbonTabItemColorTableCollection office2007RibbonTabItemColorTableCollection_0 = new Office2007RibbonTabItemColorTableCollection();

	private Office2007RibbonTabGroupColorTableCollection office2007RibbonTabGroupColorTableCollection_0 = new Office2007RibbonTabGroupColorTableCollection();

	private eOffice2007ColorScheme eOffice2007ColorScheme_0;

	private Hashtable hashtable_0 = new Hashtable();

	private ColorFactory colorFactory_0 = new ColorFactory();

	public Office2007RibbonBarColorTable RibbonBar = new Office2007RibbonBarColorTable();

	public Office2007ItemGroupColorTable ItemGroup = new Office2007ItemGroupColorTable();

	public Office2007BarColorTable Bar = new Office2007BarColorTable();

	public Office2007RibbonColorTable RibbonControl = new Office2007RibbonColorTable();

	public Office2007ColorItemColorTable ColorItem = new Office2007ColorItemColorTable();

	public Office2007MenuColorTable Menu = new Office2007MenuColorTable();

	public Office2007ComboBoxColorTable ComboBox = new Office2007ComboBoxColorTable();

	public Office2007DialogLauncherColorTable DialogLauncher = new Office2007DialogLauncherColorTable();

	public ColorScheme LegacyColors = new ColorScheme(eDotNetBarStyle.Office2007);

	public Office2007SystemButtonColorTable SystemButton = new Office2007SystemButtonColorTable();

	public Office2007FormColorTable Form = new Office2007FormColorTable();

	public Office2007QuickAccessToolbarColorTable QuickAccessToolbar = new Office2007QuickAccessToolbarColorTable();

	public Office2007TabColorTable TabControl = new Office2007TabColorTable();

	public Office2007KeyTipsColorTable KeyTips = new Office2007KeyTipsColorTable();

	public Office2007CheckBoxColorTable CheckBoxItem = new Office2007CheckBoxColorTable();

	public Office2007ScrollBarColorTable ScrollBar = new Office2007ScrollBarColorTable();

	public Office2007ScrollBarColorTable AppScrollBar = new Office2007ScrollBarColorTable();

	public Office2007ProgressBarColorTable ProgressBarItem = new Office2007ProgressBarColorTable();

	public Office2007ProgressBarColorTable ProgressBarItemPaused = new Office2007ProgressBarColorTable();

	public Office2007ProgressBarColorTable ProgressBarItemError = new Office2007ProgressBarColorTable();

	public Office2007GalleryColorTable Gallery = new Office2007GalleryColorTable();

	public Office2007NavigationPaneColorTable NavigationPane = new Office2007NavigationPaneColorTable();

	public Office2007SliderColorTable Slider = new Office2007SliderColorTable();

	public Office2007SuperTooltipColorTable SuperTooltip = new Office2007SuperTooltipColorTable();

	public Office2007ListViewColorTable ListViewEx = new Office2007ListViewColorTable();

	public Office2007DataGridViewColorTable DataGridView = new Office2007DataGridViewColorTable();

	public Office2007SideBarColorTable SideBar = new Office2007SideBarColorTable();

	public TreeColorTable AdvTree;

	public CrumbBarItemViewColorTable CrumbBarItemView;

	private static bool bool_0;

	public Office2007ButtonItemColorTableCollection ButtonItemColors => office2007ButtonItemColorTableCollection_0;

	public Office2007ButtonItemColorTableCollection RibbonButtonItemColors => office2007ButtonItemColorTableCollection_1;

	public Office2007ButtonItemColorTableCollection MenuButtonItemColors => office2007ButtonItemColorTableCollection_2;

	public Office2007RibbonTabItemColorTableCollection RibbonTabItemColors => office2007RibbonTabItemColorTableCollection_0;

	public Office2007RibbonTabGroupColorTableCollection RibbonTabGroupColors => office2007RibbonTabGroupColorTableCollection_0;

	public eOffice2007ColorScheme InitialColorScheme => eOffice2007ColorScheme_0;

	public Hashtable StyleClasses => hashtable_0;

	public static bool CloneImagesOnAccess
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

	public Office2007ColorTable()
	{
		method_0(colorFactory_0);
	}

	public Office2007ColorTable(ColorFactory colorFactory)
	{
		colorFactory_0 = colorFactory;
		method_0(colorFactory_0);
	}

	public Office2007ColorTable(eOffice2007ColorScheme scheme)
	{
		switch (scheme)
		{
		case eOffice2007ColorScheme.Black:
			Class224.smethod_41(this, colorFactory_0);
			break;
		case eOffice2007ColorScheme.Silver:
			Class225.smethod_19(this, colorFactory_0);
			break;
		case eOffice2007ColorScheme.VistaGlass:
			Office2007VistaBlackColorTableFactory.InitializeVistaBlackColorTable(this, colorFactory_0);
			break;
		default:
			method_0(colorFactory_0);
			break;
		}
		eOffice2007ColorScheme_0 = scheme;
	}

	public Office2007ColorTable(eOffice2007ColorScheme scheme, ColorFactory colorFactory)
	{
		colorFactory_0 = colorFactory;
		switch (scheme)
		{
		case eOffice2007ColorScheme.Black:
			Class224.smethod_41(this, colorFactory_0);
			break;
		case eOffice2007ColorScheme.Silver:
			Class225.smethod_19(this, colorFactory_0);
			break;
		case eOffice2007ColorScheme.VistaGlass:
			Office2007VistaBlackColorTableFactory.InitializeVistaBlackColorTable(this, colorFactory_0);
			break;
		default:
			method_0(colorFactory_0);
			break;
		}
		eOffice2007ColorScheme_0 = scheme;
	}

	public Office2007ColorTable(eOffice2007ColorScheme scheme, Color baseSchemeColor)
	{
		colorFactory_0 = new ColorBlendFactory(baseSchemeColor);
		switch (scheme)
		{
		case eOffice2007ColorScheme.Black:
			Class224.smethod_41(this, colorFactory_0);
			break;
		case eOffice2007ColorScheme.Silver:
			Class225.smethod_19(this, colorFactory_0);
			break;
		case eOffice2007ColorScheme.VistaGlass:
			Office2007VistaBlackColorTableFactory.InitializeVistaBlackColorTable(this, colorFactory_0);
			break;
		default:
			method_0(colorFactory_0);
			break;
		}
		eOffice2007ColorScheme_0 = scheme;
	}

	private void method_0(ColorFactory colorFactory_1)
	{
		RibbonControl.StartButtonDefault = (Image)(object)Class109.smethod_67("SystemImages.BlankStartButtonNormal.png");
		RibbonControl.StartButtonMouseOver = (Image)(object)Class109.smethod_67("SystemImages.BlankStartButtonHot.png");
		RibbonControl.StartButtonPressed = (Image)(object)Class109.smethod_67("SystemImages.BlankStartButtonPressed.png");
		RibbonControl.OuterBorder = new LinearGradientColorTable(colorFactory_1.GetColor(9286371), colorFactory_1.GetColor(8954306));
		RibbonControl.InnerBorder = new LinearGradientColorTable(colorFactory_1.GetColor(15200248), colorFactory_1.GetColor(12646911));
		RibbonControl.TabsBackground = new LinearGradientColorTable(colorFactory_1.GetColor(12573695), Color.Empty);
		RibbonControl.TabDividerBorder = colorFactory_1.GetColor(11455216);
		RibbonControl.TabDividerBorderLight = colorFactory_1.GetColor(13951989);
		RibbonControl.CornerSize = 3;
		RibbonControl.PanelTopBackgroundHeight = 15;
		RibbonControl.PanelTopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(14411508), colorFactory_1.GetColor(13622767));
		RibbonControl.PanelBottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(13228525), colorFactory_1.GetColor(15201023));
		ItemGroup.OuterBorder = new LinearGradientColorTable(colorFactory_1.GetColor(10073824), colorFactory_1.GetColor(7574717));
		ItemGroup.InnerBorder = new LinearGradientColorTable(colorFactory_1.GetColor(14017521), colorFactory_1.GetColor(14937595));
		ItemGroup.TopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(13163502), colorFactory_1.GetColor(13229558));
		ItemGroup.BottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(12374249), colorFactory_1.GetColor(13689335));
		ItemGroup.ItemGroupDividerDark = Color.FromArgb(196, colorFactory_1.GetColor(12110044));
		ItemGroup.ItemGroupDividerLight = Color.FromArgb(128, colorFactory_1.GetColor(16777215));
		RibbonBar.Default = Class224.smethod_9(colorFactory_1);
		RibbonBar.MouseOver = Class224.smethod_10(colorFactory_1);
		RibbonBar.Expanded = Class224.smethod_11(colorFactory_1);
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = Class224.smethod_2(colorFactory_1);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Orange);
		office2007ButtonItemColorTableCollection_0.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = Class224.smethod_3(colorFactory_1);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.OrangeWithBackground);
		office2007ButtonItemColorTableCollection_0.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = Class224.smethod_4(colorFactory_1);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Blue);
		office2007ButtonItemColorTableCollection_0.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = Class224.smethod_5(colorFactory_1);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.BlueWithBackground);
		office2007ButtonItemColorTableCollection_0.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = Class224.smethod_6(colorFactory_1);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Magenta);
		office2007ButtonItemColorTableCollection_0.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = Class224.smethod_7(colorFactory_1);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.MagentaWithBackground);
		office2007ButtonItemColorTableCollection_0.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = Class224.smethod_8(colorFactory_1);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Office2007WithBackground);
		office2007ButtonItemColorTableCollection_0.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTableCollection_0.Add(ButtonItemStaticColorTables.CreateBlueOrbColorTable(colorFactory_1));
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = Class224.smethod_12(colorFactory_1);
		office2007RibbonTabItemColorTable.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Default);
		office2007RibbonTabItemColorTableCollection_0.Add(office2007RibbonTabItemColorTable);
		office2007RibbonTabItemColorTable = Class224.smethod_13(colorFactory_1);
		office2007RibbonTabItemColorTable.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Magenta);
		office2007RibbonTabItemColorTableCollection_0.Add(office2007RibbonTabItemColorTable);
		office2007RibbonTabItemColorTable = Class224.smethod_14(colorFactory_1);
		office2007RibbonTabItemColorTable.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Green);
		office2007RibbonTabItemColorTableCollection_0.Add(office2007RibbonTabItemColorTable);
		office2007RibbonTabItemColorTable = Class224.smethod_15(colorFactory_1);
		office2007RibbonTabItemColorTable.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Orange);
		office2007RibbonTabItemColorTableCollection_0.Add(office2007RibbonTabItemColorTable);
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = Class224.smethod_16(colorFactory_1);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Default);
		office2007RibbonTabGroupColorTableCollection_0.Add(office2007RibbonTabGroupColorTable);
		office2007RibbonTabGroupColorTable = Class224.smethod_17(colorFactory_1);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Magenta);
		office2007RibbonTabGroupColorTableCollection_0.Add(office2007RibbonTabGroupColorTable);
		office2007RibbonTabGroupColorTable = Class224.smethod_18(colorFactory_1);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Green);
		office2007RibbonTabGroupColorTableCollection_0.Add(office2007RibbonTabGroupColorTable);
		office2007RibbonTabGroupColorTable = Class224.smethod_19(colorFactory_1);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Orange);
		office2007RibbonTabGroupColorTableCollection_0.Add(office2007RibbonTabGroupColorTable);
		Bar.ToolbarTopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(14149369), colorFactory_1.GetColor(13098232));
		Bar.ToolbarBottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(11784437), colorFactory_1.GetColor(14149111));
		Bar.ToolbarBottomBorder = colorFactory_1.GetColor(12244215);
		Bar.PopupToolbarBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16448250), Color.Empty);
		Bar.PopupToolbarBorder = colorFactory_1.GetColor(8816262);
		Bar.StatusBarTopBorder = colorFactory_1.GetColor(5668272);
		Bar.StatusBarTopBorderLight = colorFactory_1.GetColor(Color.FromArgb(148, Color.White));
		Bar.StatusBarAltBackground.Clear();
		Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(colorFactory_1.GetColor(12967160), 0f));
		Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(colorFactory_1.GetColor(11127543), 0.4f));
		Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(colorFactory_1.GetColor(9484010), 0.4f));
		Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(colorFactory_1.GetColor(7640514), 1f));
		Menu.Background = new LinearGradientColorTable(colorFactory_1.GetColor(16448250), Color.Empty);
		Menu.Border = new LinearGradientColorTable(colorFactory_1.GetColor(8816262), Color.Empty);
		Menu.Side = new LinearGradientColorTable(colorFactory_1.GetColor(15331054), Color.Empty);
		Menu.SideBorder = new LinearGradientColorTable(colorFactory_1.GetColor(12961221), Color.Empty);
		Menu.SideBorderLight = new LinearGradientColorTable(colorFactory_1.GetColor(16119285), Color.Empty);
		Menu.SideUnused = new LinearGradientColorTable(colorFactory_1.GetColor(15066597), Color.Empty);
		Menu.FileBackgroundBlend.Clear();
		Menu.FileBackgroundBlend.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(Color.FromArgb(215, 229, 247), 0f),
			new BackgroundColorBlend(Color.FromArgb(218, 231, 247), 4f),
			new BackgroundColorBlend(Color.FromArgb(207, 223, 243), 4f),
			new BackgroundColorBlend(Color.FromArgb(189, 211, 239), 1f)
		});
		Menu.FileContainerBorder = Color.White;
		Menu.FileContainerBorderLight = Color.FromArgb(155, 175, 202);
		Menu.FileColumnOneBackground = colorFactory_1.GetColor(16448250);
		Menu.FileColumnOneBorder = colorFactory_1.GetColor(12961221);
		Menu.FileColumnTwoBackground = colorFactory_1.GetColor(15330030);
		Menu.FileBottomContainerBackgroundBlend.Clear();
		Menu.FileBottomContainerBackgroundBlend.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(Color.FromArgb(189, 211, 239), 0f),
			new BackgroundColorBlend(Color.FromArgb(190, 212, 240), 0.4f),
			new BackgroundColorBlend(Color.FromArgb(176, 201, 234), 0.4f),
			new BackgroundColorBlend(Color.FromArgb(207, 224, 245), 1f)
		});
		ComboBox.Default.Background = colorFactory_1.GetColor(15397627);
		ComboBox.Default.Border = colorFactory_1.GetColor(11256286);
		ComboBox.Default.ExpandBackground = new LinearGradientColorTable();
		ComboBox.Default.ExpandBorderInner = new LinearGradientColorTable();
		ComboBox.Default.ExpandBorderOuter = new LinearGradientColorTable();
		ComboBox.Default.ExpandText = colorFactory_1.GetColor(1393291);
		ComboBox.DefaultStandalone.Background = colorFactory_1.GetColor(16777215);
		ComboBox.DefaultStandalone.Border = colorFactory_1.GetColor(11782113);
		ComboBox.DefaultStandalone.ExpandBackground = new LinearGradientColorTable(colorFactory_1.GetColor(15003902), colorFactory_1.GetColor(13623283), 90);
		ComboBox.DefaultStandalone.ExpandBorderInner = new LinearGradientColorTable();
		ComboBox.DefaultStandalone.ExpandBorderOuter = new LinearGradientColorTable(colorFactory_1.GetColor(11519199), Color.Empty, 90);
		ComboBox.DefaultStandalone.ExpandText = colorFactory_1.GetColor(1393291);
		ComboBox.MouseOver.Background = colorFactory_1.GetColor(16777215);
		ComboBox.MouseOver.Border = colorFactory_1.GetColor(11782113);
		ComboBox.MouseOver.ExpandBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16776418), colorFactory_1.GetColor(16770981), 90);
		ComboBox.MouseOver.ExpandBorderInner = new LinearGradientColorTable(colorFactory_1.GetColor(16777211), colorFactory_1.GetColor(16776435), 90);
		ComboBox.MouseOver.ExpandBorderOuter = new LinearGradientColorTable(colorFactory_1.GetColor(14405273), Color.Empty, 90);
		ComboBox.MouseOver.ExpandText = colorFactory_1.GetColor(1393291);
		ComboBox.DroppedDown.Background = colorFactory_1.GetColor(16777215);
		ComboBox.DroppedDown.Border = colorFactory_1.GetColor(11782113);
		ComboBox.DroppedDown.ExpandBackground = new LinearGradientColorTable(colorFactory_1.GetColor(15392959), colorFactory_1.GetColor(16766038), 90);
		ComboBox.DroppedDown.ExpandBorderInner = new LinearGradientColorTable(colorFactory_1.GetColor(15854549), colorFactory_1.GetColor(16770708), 90);
		ComboBox.DroppedDown.ExpandBorderOuter = new LinearGradientColorTable(colorFactory_1.GetColor(10129251), Color.Empty, 90);
		ComboBox.DroppedDown.ExpandText = colorFactory_1.GetColor(1393291);
		DialogLauncher.Default.DialogLauncher = colorFactory_1.GetColor(6721199);
		DialogLauncher.Default.DialogLauncherShade = colorFactory_1.GetColor(16777215);
		DialogLauncher.MouseOver.DialogLauncher = colorFactory_1.GetColor(6721199);
		DialogLauncher.MouseOver.DialogLauncherShade = Color.FromArgb(192, colorFactory_1.GetColor(16777215));
		DialogLauncher.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16776415), colorFactory_1.GetColor(16773031));
		DialogLauncher.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16767349), colorFactory_1.GetColor(16769944));
		DialogLauncher.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_1.GetColor(16777211), colorFactory_1.GetColor(16776178));
		DialogLauncher.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_1.GetColor(14405273), Color.Empty);
		DialogLauncher.Pressed.DialogLauncher = colorFactory_1.GetColor(6721199);
		DialogLauncher.Pressed.DialogLauncherShade = Color.FromArgb(192, colorFactory_1.GetColor(16777215));
		DialogLauncher.Pressed.TopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(15261373), colorFactory_1.GetColor(15386253));
		DialogLauncher.Pressed.BottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16754488), colorFactory_1.GetColor(16763982));
		DialogLauncher.Pressed.InnerBorder = new LinearGradientColorTable(colorFactory_1.GetColor(15788756), colorFactory_1.GetColor(16769937));
		DialogLauncher.Pressed.OuterBorder = new LinearGradientColorTable(colorFactory_1.GetColor(10129251), colorFactory_1.GetColor(11576434));
		SystemButton.Default = new Office2007SystemButtonStateColorTable();
		SystemButton.Default.Foreground = new LinearGradientColorTable(colorFactory_1.GetColor(7966119), colorFactory_1.GetColor(9152460));
		SystemButton.Default.LightShade = colorFactory_1.GetColor(16316922);
		SystemButton.Default.DarkShade = colorFactory_1.GetColor(6645093);
		SystemButton.MouseOver = new Office2007SystemButtonStateColorTable();
		SystemButton.MouseOver.Foreground = new LinearGradientColorTable(colorFactory_1.GetColor(7966119), colorFactory_1.GetColor(9152460));
		SystemButton.MouseOver.LightShade = colorFactory_1.GetColor(16316922);
		SystemButton.MouseOver.DarkShade = colorFactory_1.GetColor(6645093);
		SystemButton.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16120062), colorFactory_1.GetColor(15397631));
		SystemButton.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(13821182), colorFactory_1.GetColor(13755131));
		SystemButton.MouseOver.TopHighlight = new LinearGradientColorTable(colorFactory_1.GetColor(16514303), Color.Transparent);
		SystemButton.MouseOver.BottomHighlight = new LinearGradientColorTable(colorFactory_1.GetColor(16514303), Color.Transparent);
		SystemButton.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_1.GetColor(12702958), colorFactory_1.GetColor(11191529));
		SystemButton.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_1.GetColor(16711423), colorFactory_1.GetColor(15135998));
		SystemButton.Pressed = new Office2007SystemButtonStateColorTable();
		SystemButton.Pressed.Foreground = new LinearGradientColorTable(colorFactory_1.GetColor(7966119), colorFactory_1.GetColor(9152460));
		SystemButton.Pressed.LightShade = colorFactory_1.GetColor(16316922);
		SystemButton.Pressed.DarkShade = colorFactory_1.GetColor(6645093);
		SystemButton.Pressed.TopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(12244472), colorFactory_1.GetColor(10404589));
		SystemButton.Pressed.TopHighlight = new LinearGradientColorTable(colorFactory_1.GetColor(12111593), Color.Transparent);
		SystemButton.Pressed.BottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(8696553), colorFactory_1.GetColor(11523831));
		SystemButton.Pressed.BottomHighlight = new LinearGradientColorTable(colorFactory_1.GetColor(13036285), Color.Transparent);
		SystemButton.Pressed.OuterBorder = new LinearGradientColorTable(colorFactory_1.GetColor(10600421), colorFactory_1.GetColor(11717351));
		SystemButton.Pressed.InnerBorder = new LinearGradientColorTable(colorFactory_1.GetColor(13887231), colorFactory_1.GetColor(14477819));
		Form.Active.BorderColors = new Color[4]
		{
			colorFactory_1.GetColor(3889794),
			colorFactory_1.GetColor(11650785),
			colorFactory_1.GetColor(12769783),
			colorFactory_1.GetColor(11586543)
		};
		Form.Inactive.BorderColors = new Color[4]
		{
			colorFactory_1.GetColor(12633806),
			colorFactory_1.GetColor(13424354),
			colorFactory_1.GetColor(13950700),
			colorFactory_1.GetColor(13424872)
		};
		Form.Active.CaptionTopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(15002614), colorFactory_1.GetColor(14346749));
		Form.Active.CaptionBottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(13295351), colorFactory_1.GetColor(15003645));
		Form.Active.CaptionBottomBorder = new Color[2]
		{
			colorFactory_1.GetColor(14480638),
			colorFactory_1.GetColor(11587575)
		};
		Form.Active.CaptionText = colorFactory_1.GetColor(4090538);
		Form.Active.CaptionTextExtra = colorFactory_1.GetColor(6910073);
		Form.Inactive.CaptionTopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(14936044), colorFactory_1.GetColor(14607853));
		Form.Inactive.CaptionBottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(14213612), colorFactory_1.GetColor(14936303));
		Form.Inactive.CaptionText = colorFactory_1.GetColor(10526880);
		Form.Inactive.CaptionTextExtra = colorFactory_1.GetColor(10526880);
		Form.BackColor = colorFactory_1.GetColor(12769783);
		Form.TextColor = colorFactory_1.GetColor(1393291);
		QuickAccessToolbar.Active.TopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(14608372), colorFactory_1.GetColor(15134457));
		QuickAccessToolbar.Active.BottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(14411767), colorFactory_1.GetColor(13228526));
		QuickAccessToolbar.Active.OutterBorderColor = colorFactory_1.GetColor(16185852);
		QuickAccessToolbar.Active.MiddleBorderColor = colorFactory_1.GetColor(10138581);
		QuickAccessToolbar.Active.InnerBorderColor = Color.Empty;
		QuickAccessToolbar.Inactive.TopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(15133939), colorFactory_1.GetColor(13555942));
		QuickAccessToolbar.Inactive.BottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(13555942), colorFactory_1.GetColor(13161443));
		QuickAccessToolbar.Inactive.OutterBorderColor = colorFactory_1.GetColor(16185852);
		QuickAccessToolbar.Inactive.MiddleBorderColor = colorFactory_1.GetColor(10138581);
		QuickAccessToolbar.Inactive.InnerBorderColor = Color.Empty;
		QuickAccessToolbar.Standalone.TopBackground = new LinearGradientColorTable();
		QuickAccessToolbar.Standalone.BottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(11718125), colorFactory_1.GetColor(11191786));
		QuickAccessToolbar.Standalone.OutterBorderColor = colorFactory_1.GetColor(8298957);
		QuickAccessToolbar.Standalone.MiddleBorderColor = Color.Empty;
		QuickAccessToolbar.Standalone.InnerBorderColor = colorFactory_1.GetColor(14477559);
		QuickAccessToolbar.QatCustomizeMenuLabelBackground = colorFactory_1.GetColor(14542830);
		QuickAccessToolbar.QatCustomizeMenuLabelText = colorFactory_1.GetColor(5486);
		QuickAccessToolbar.Active.GlassBorder = new LinearGradientColorTable(colorFactory_1.GetColor(Color.FromArgb(132, Color.Black)), Color.FromArgb(80, Color.Black));
		QuickAccessToolbar.Inactive.GlassBorder = new LinearGradientColorTable(colorFactory_1.GetColor(Color.FromArgb(132, Color.Black)), Color.FromArgb(80, Color.Black));
		TabControl.Default = new Office2007TabItemStateColorTable();
		TabControl.Default.TopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(14149369), colorFactory_1.GetColor(13098232));
		TabControl.Default.BottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(11784437), colorFactory_1.GetColor(14149111));
		TabControl.Default.InnerBorder = colorFactory_1.GetColor(15988733);
		TabControl.Default.OuterBorder = colorFactory_1.GetColor(9610695);
		TabControl.Default.Text = colorFactory_1.GetColor(1395347);
		TabControl.MouseOver = new Office2007TabItemStateColorTable();
		TabControl.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16776683), colorFactory_1.GetColor(16772264));
		TabControl.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16767577), colorFactory_1.GetColor(16770701));
		TabControl.MouseOver.InnerBorder = colorFactory_1.GetColor(16777211);
		TabControl.MouseOver.OuterBorder = colorFactory_1.GetColor(11967859);
		TabControl.MouseOver.Text = colorFactory_1.GetColor(1395347);
		TabControl.Selected = new Office2007TabItemStateColorTable();
		TabControl.Selected.TopBackground = new LinearGradientColorTable(colorFactory_1.GetColor(Color.White), colorFactory_1.GetColor(16645630));
		TabControl.Selected.BottomBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16645630), colorFactory_1.GetColor(16645630));
		TabControl.Selected.InnerBorder = colorFactory_1.GetColor(Color.White);
		TabControl.Selected.OuterBorder = colorFactory_1.GetColor(9610695);
		TabControl.Selected.Text = colorFactory_1.GetColor(1395347);
		TabControl.TabBackground = new LinearGradientColorTable(colorFactory_1.GetColor(14938111), colorFactory_1.GetColor(11588351));
		TabControl.TabPanelBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16645630), colorFactory_1.GetColor(10337507));
		TabControl.TabPanelBorder = colorFactory_1.GetColor(9610695);
		Office2007CheckBoxColorTable checkBoxItem = CheckBoxItem;
		checkBoxItem.Default.CheckBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16053492), Color.Empty);
		checkBoxItem.Default.CheckBorder = colorFactory_1.GetColor(11256286);
		checkBoxItem.Default.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, colorFactory_1.GetColor(10661049)), Color.FromArgb(164, colorFactory_1.GetColor(16185078)));
		checkBoxItem.Default.CheckInnerBorder = colorFactory_1.GetColor(10661049);
		checkBoxItem.Default.CheckSign = new LinearGradientColorTable(colorFactory_1.GetColor(4877206), Color.Empty);
		checkBoxItem.Default.Text = colorFactory_1.GetColor(1393291);
		checkBoxItem.MouseOver.CheckBackground = new LinearGradientColorTable(colorFactory_1.GetColor(14609146), Color.Empty);
		checkBoxItem.MouseOver.CheckBorder = colorFactory_1.GetColor(5601187);
		checkBoxItem.MouseOver.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, colorFactory_1.GetColor(16438650)), Color.FromArgb(128, colorFactory_1.GetColor(16709863)));
		checkBoxItem.MouseOver.CheckInnerBorder = colorFactory_1.GetColor(16438650);
		checkBoxItem.MouseOver.CheckSign = new LinearGradientColorTable(colorFactory_1.GetColor(4877206), Color.Empty);
		checkBoxItem.MouseOver.Text = colorFactory_1.GetColor(1393291);
		checkBoxItem.Pressed.CheckBackground = new LinearGradientColorTable(colorFactory_1.GetColor(12703989), Color.Empty);
		checkBoxItem.Pressed.CheckBorder = colorFactory_1.GetColor(5601187);
		checkBoxItem.Pressed.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, colorFactory_1.GetColor(15894822)), Color.FromArgb(164, colorFactory_1.GetColor(16774357)));
		checkBoxItem.Pressed.CheckInnerBorder = colorFactory_1.GetColor(15894822);
		checkBoxItem.Pressed.CheckSign = new LinearGradientColorTable(colorFactory_1.GetColor(4877206), Color.Empty);
		checkBoxItem.Pressed.Text = colorFactory_1.GetColor(1393291);
		checkBoxItem.Disabled.CheckBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16777215), Color.Empty);
		checkBoxItem.Disabled.CheckBorder = colorFactory_1.GetColor(11448757);
		checkBoxItem.Disabled.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, colorFactory_1.GetColor(14738149)), Color.FromArgb(164, colorFactory_1.GetColor(16514043)));
		checkBoxItem.Disabled.CheckInnerBorder = colorFactory_1.GetColor(14738149);
		checkBoxItem.Disabled.CheckSign = new LinearGradientColorTable(colorFactory_1.GetColor(9276813), Color.Empty);
		checkBoxItem.Disabled.Text = colorFactory_1.GetColor(9276813);
		Class224.smethod_37(this, colorFactory_1);
		Class224.smethod_38(this, colorFactory_1);
		Office2007ProgressBarColorTable progressBarItem = ProgressBarItem;
		progressBarItem.BackgroundColors = new GradientColorTable(13028309, 14738669);
		progressBarItem.OuterBorder = colorFactory_1.GetColor(14607084);
		progressBarItem.InnerBorder = colorFactory_1.GetColor(7640770);
		progressBarItem.Chunk = new GradientColorTable(6918698, 15200980, 0);
		progressBarItem.ChunkOverlay = new GradientColorTable();
		progressBarItem.ChunkOverlay.LinearGradientAngle = 90;
		progressBarItem.ChunkOverlay.Colors.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(Color.FromArgb(192, colorFactory_1.GetColor(15663063)), 0f),
			new BackgroundColorBlend(Color.FromArgb(128, colorFactory_1.GetColor(9286228)), 0.5f),
			new BackgroundColorBlend(Color.FromArgb(64, colorFactory_1.GetColor(6918699)), 0.5f),
			new BackgroundColorBlend(Color.Transparent, 1f)
		});
		progressBarItem.ChunkShadow = new GradientColorTable(11712968, 14015205, 0);
		progressBarItem = ProgressBarItemPaused;
		progressBarItem.BackgroundColors = new GradientColorTable(13028309, 14738669);
		progressBarItem.OuterBorder = colorFactory_1.GetColor(14607084);
		progressBarItem.InnerBorder = colorFactory_1.GetColor(7640770);
		progressBarItem.Chunk = new GradientColorTable(11446016, 16776653, 0);
		progressBarItem.ChunkOverlay = new GradientColorTable();
		progressBarItem.ChunkOverlay.LinearGradientAngle = 90;
		progressBarItem.ChunkOverlay.Colors.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(Color.FromArgb(192, colorFactory_1.GetColor(16776099)), 0f),
			new BackgroundColorBlend(Color.FromArgb(128, colorFactory_1.GetColor(13814272)), 0.5f),
			new BackgroundColorBlend(Color.FromArgb(64, colorFactory_1.GetColor(16708608)), 0.5f),
			new BackgroundColorBlend(Color.Transparent, 1f)
		});
		progressBarItem.ChunkShadow = new GradientColorTable(11712968, 14015205, 0);
		progressBarItem = ProgressBarItemError;
		progressBarItem.BackgroundColors = new GradientColorTable(13028309, 14738669);
		progressBarItem.OuterBorder = colorFactory_1.GetColor(14607084);
		progressBarItem.InnerBorder = colorFactory_1.GetColor(7640770);
		progressBarItem.Chunk = new GradientColorTable(13762560, 16764365, 0);
		progressBarItem.ChunkOverlay = new GradientColorTable();
		progressBarItem.ChunkOverlay.LinearGradientAngle = 90;
		progressBarItem.ChunkOverlay.Colors.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(Color.FromArgb(192, colorFactory_1.GetColor(16748431)), 0f),
			new BackgroundColorBlend(Color.FromArgb(128, colorFactory_1.GetColor(13762560)), 0.5f),
			new BackgroundColorBlend(Color.FromArgb(64, colorFactory_1.GetColor(16646144)), 0.5f),
			new BackgroundColorBlend(Color.Transparent, 1f)
		});
		progressBarItem.ChunkShadow = new GradientColorTable(11712968, 14015205, 0);
		Office2007GalleryColorTable gallery = Gallery;
		gallery.GroupLabelBackground = colorFactory_1.GetColor(14542830);
		gallery.GroupLabelText = colorFactory_1.GetColor(5486);
		gallery.GroupLabelBorder = colorFactory_1.GetColor(12961221);
		LegacyColors.BarBackground = colorFactory_1.GetColor(14938111);
		LegacyColors.BarBackground2 = colorFactory_1.GetColor(11128574);
		LegacyColors.BarStripeColor = colorFactory_1.GetColor(7314905);
		LegacyColors.BarCaptionBackground = colorFactory_1.GetColor(6656975);
		LegacyColors.BarCaptionBackground2 = colorFactory_1.GetColor(3630240);
		LegacyColors.BarCaptionInactiveBackground = colorFactory_1.GetColor(14938111);
		LegacyColors.BarCaptionInactiveBackground2 = colorFactory_1.GetColor(11522815);
		LegacyColors.BarCaptionInactiveText = colorFactory_1.GetColor(538482);
		LegacyColors.BarCaptionText = colorFactory_1.GetColor(16777215);
		LegacyColors.BarFloatingBorder = colorFactory_1.GetColor(3630240);
		LegacyColors.BarPopupBackground = colorFactory_1.GetColor(16185078);
		LegacyColors.BarPopupBorder = colorFactory_1.GetColor(6656975);
		LegacyColors.ItemBackground = Color.Empty;
		LegacyColors.ItemBackground2 = Color.Empty;
		LegacyColors.ItemCheckedBackground = colorFactory_1.GetColor(16569720);
		LegacyColors.ItemCheckedBackground2 = colorFactory_1.GetColor(16500815);
		LegacyColors.ItemCheckedBorder = colorFactory_1.GetColor(12276995);
		LegacyColors.ItemCheckedText = colorFactory_1.GetColor(0);
		LegacyColors.ItemDisabledBackground = Color.Empty;
		LegacyColors.ItemDisabledText = colorFactory_1.GetColor(9276813);
		LegacyColors.ItemExpandedShadow = Color.Empty;
		LegacyColors.ItemExpandedBackground = colorFactory_1.GetColor(14938110);
		LegacyColors.ItemExpandedBackground2 = colorFactory_1.GetColor(10076144);
		LegacyColors.ItemExpandedText = colorFactory_1.GetColor(0);
		LegacyColors.ItemHotBackground = colorFactory_1.GetColor(16774604);
		LegacyColors.ItemHotBackground2 = colorFactory_1.GetColor(16767861);
		LegacyColors.ItemHotBorder = colorFactory_1.GetColor(16760169);
		LegacyColors.ItemHotText = colorFactory_1.GetColor(0);
		LegacyColors.ItemPressedBackground = colorFactory_1.GetColor(16553789);
		LegacyColors.ItemPressedBackground2 = colorFactory_1.GetColor(16758878);
		LegacyColors.ItemPressedBorder = colorFactory_1.GetColor(16485436);
		LegacyColors.ItemPressedText = colorFactory_1.GetColor(0);
		LegacyColors.ItemSeparator = Color.FromArgb(80, colorFactory_1.GetColor(10143487));
		LegacyColors.ItemSeparatorShade = Color.FromArgb(250, colorFactory_1.GetColor(16777215));
		LegacyColors.ItemText = colorFactory_1.GetColor(0);
		LegacyColors.MenuBackground = colorFactory_1.GetColor(16185078);
		LegacyColors.MenuBackground2 = Color.Empty;
		LegacyColors.MenuBarBackground = colorFactory_1.GetColor(12573695);
		LegacyColors.MenuBorder = colorFactory_1.GetColor(6656975);
		LegacyColors.ItemExpandedBorder = LegacyColors.MenuBorder;
		LegacyColors.MenuSide = colorFactory_1.GetColor(15331054);
		LegacyColors.MenuSide2 = Color.Empty;
		LegacyColors.MenuUnusedBackground = LegacyColors.MenuBackground;
		LegacyColors.MenuUnusedSide = colorFactory_1.GetColor(14342874);
		LegacyColors.MenuUnusedSide2 = Color.Empty;
		LegacyColors.ItemDesignTimeBorder = Color.Black;
		LegacyColors.BarDockedBorder = colorFactory_1.GetColor(7314905);
		LegacyColors.DockSiteBackColor = colorFactory_1.GetColor(12573695);
		LegacyColors.DockSiteBackColor2 = Color.Empty;
		LegacyColors.CustomizeBackground = colorFactory_1.GetColor(14149887);
		LegacyColors.CustomizeBackground2 = colorFactory_1.GetColor(7314905);
		LegacyColors.CustomizeText = colorFactory_1.GetColor(0);
		LegacyColors.PanelBackground = colorFactory_1.GetColor(14938111);
		LegacyColors.PanelBackground2 = colorFactory_1.GetColor(11522815);
		LegacyColors.PanelText = colorFactory_1.GetColor(538482);
		LegacyColors.PanelBorder = colorFactory_1.GetColor(6656975);
		LegacyColors.ExplorerBarBackground = colorFactory_1.GetColor(12896468);
		LegacyColors.ExplorerBarBackground2 = colorFactory_1.GetColor(11645896);
		NavigationPane.ButtonBackground = new GradientColorTable();
		NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(14938111), 0f));
		NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(12901887), 0.4f));
		NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(11391487), 0.4f));
		NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(12639231), 1f));
		SuperTooltip.BackgroundColors = new LinearGradientColorTable(colorFactory_1.GetColor(16777215), colorFactory_1.GetColor(13228527));
		SuperTooltip.TextColor = colorFactory_1.GetColor(5000268);
		Office2007SliderColorTable slider = Slider;
		slider.Default.LabelColor = colorFactory_1.GetColor(663677);
		slider.Default.PartBackground = new GradientColorTable();
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16777215), 0f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(15857404), 0.15f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(11454958), 0.5f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(6985936), 0.5f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16777215), 0.85f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16777215), 1f));
		slider.Default.PartBorderColor = colorFactory_1.GetColor(3102605);
		slider.Default.PartBorderLightColor = Color.FromArgb(96, colorFactory_1.GetColor(16777215));
		slider.Default.PartForeColor = colorFactory_1.GetColor(5661557);
		slider.Default.PartForeLightColor = Color.FromArgb(168, colorFactory_1.GetColor(15200505));
		slider.Default.TrackLineColor = colorFactory_1.GetColor(7640770);
		slider.Default.TrackLineLightColor = colorFactory_1.GetColor(14607084);
		slider.MouseOver.LabelColor = colorFactory_1.GetColor(598113);
		slider.MouseOver.PartBackground = new GradientColorTable();
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16777215), 0f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16776693), 0.2f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16768899), 0.5f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(14526221), 0.5f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16774350), 0.85f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16774350), 1f));
		slider.MouseOver.PartBorderColor = colorFactory_1.GetColor(3102605);
		slider.MouseOver.PartBorderLightColor = Color.FromArgb(96, colorFactory_1.GetColor(16777215));
		slider.MouseOver.PartForeColor = colorFactory_1.GetColor(6775370);
		slider.MouseOver.PartForeLightColor = Color.FromArgb(168, colorFactory_1.GetColor(15200505));
		slider.MouseOver.TrackLineColor = colorFactory_1.GetColor(7640770);
		slider.MouseOver.TrackLineLightColor = colorFactory_1.GetColor(14607084);
		slider.Pressed.LabelColor = colorFactory_1.GetColor(598113);
		slider.Pressed.PartBackground = new GradientColorTable();
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(14382360), 0f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16224303), 0.2f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16368011), 0.5f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(15561728), 0.5f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16761224), 0.85f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(15913653), 1f));
		slider.Pressed.PartBorderColor = colorFactory_1.GetColor(3102605);
		slider.Pressed.PartBorderLightColor = Color.FromArgb(96, colorFactory_1.GetColor(16777215));
		slider.Pressed.PartForeColor = colorFactory_1.GetColor(6771006);
		slider.Pressed.PartForeLightColor = Color.FromArgb(168, colorFactory_1.GetColor(15200505));
		slider.Pressed.TrackLineColor = colorFactory_1.GetColor(7640770);
		slider.Pressed.TrackLineLightColor = colorFactory_1.GetColor(14607084);
		ColorBlendFactory colorBlendFactory = new ColorBlendFactory(ColorScheme.GetColor(13619151));
		slider.Disabled.LabelColor = colorFactory_1.GetColor(9276813);
		slider.Disabled.PartBackground = new GradientColorTable();
		foreach (BackgroundColorBlend color in slider.Default.PartBackground.Colors)
		{
			slider.Disabled.PartBackground.Colors.Add(new BackgroundColorBlend(colorBlendFactory.GetColor(color.Color), color.Position));
		}
		slider.Disabled.PartBorderColor = colorBlendFactory.GetColor(slider.Default.PartBorderColor);
		slider.Disabled.PartBorderLightColor = colorBlendFactory.GetColor(slider.Default.PartBorderLightColor);
		slider.Disabled.PartForeColor = colorBlendFactory.GetColor(slider.Default.PartForeColor);
		slider.Disabled.PartForeLightColor = colorBlendFactory.GetColor(slider.Default.PartForeLightColor);
		slider.Disabled.TrackLineColor = colorBlendFactory.GetColor(slider.Default.TrackLineColor);
		slider.Disabled.TrackLineLightColor = colorBlendFactory.GetColor(slider.Default.TrackLineLightColor);
		ListViewEx.Border = colorFactory_1.GetColor(6656975);
		ListViewEx.ColumnBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16777215), colorFactory_1.GetColor(12901887));
		ListViewEx.ColumnSeparator = colorFactory_1.GetColor(10143487);
		ListViewEx.SelectionBackground = new LinearGradientColorTable(colorFactory_1.GetColor(10997232), Color.Empty);
		ListViewEx.SelectionBorder = colorFactory_1.GetColor(14938111);
		DataGridView.ColumnHeaderNormalBorder = colorFactory_1.GetColor(10401486);
		DataGridView.ColumnHeaderNormalBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16383229), colorFactory_1.GetColor(13884393), 90);
		DataGridView.ColumnHeaderSelectedBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16374175), colorFactory_1.GetColor(15843679), 90);
		DataGridView.ColumnHeaderSelectedBorder = colorFactory_1.GetColor(15897910);
		DataGridView.ColumnHeaderSelectedMouseOverBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16766349), colorFactory_1.GetColor(15897146), 90);
		DataGridView.ColumnHeaderSelectedMouseOverBorder = colorFactory_1.GetColor(15897910);
		DataGridView.ColumnHeaderMouseOverBackground = new LinearGradientColorTable(colorFactory_1.GetColor(14672612), colorFactory_1.GetColor(12371410), 90);
		DataGridView.ColumnHeaderMouseOverBorder = colorFactory_1.GetColor(8888247);
		DataGridView.ColumnHeaderPressedBackground = new LinearGradientColorTable(colorFactory_1.GetColor(12371410), colorFactory_1.GetColor(14672612), 90);
		DataGridView.ColumnHeaderPressedBorder = colorFactory_1.GetColor(16777215);
		DataGridView.RowNormalBackground = new LinearGradientColorTable(colorFactory_1.GetColor(15002871));
		DataGridView.RowNormalBorder = colorFactory_1.GetColor(10401486);
		DataGridView.RowSelectedBackground = new LinearGradientColorTable(colorFactory_1.GetColor(16766349));
		DataGridView.RowSelectedBorder = colorFactory_1.GetColor(15897910);
		DataGridView.RowSelectedMouseOverBackground = new LinearGradientColorTable(colorFactory_1.GetColor(15843420));
		DataGridView.RowSelectedMouseOverBorder = colorFactory_1.GetColor(15897910);
		DataGridView.RowMouseOverBackground = new LinearGradientColorTable(colorFactory_1.GetColor(15843420));
		DataGridView.RowMouseOverBorder = colorFactory_1.GetColor(15897910);
		DataGridView.RowPressedBackground = new LinearGradientColorTable(colorFactory_1.GetColor(12305617));
		DataGridView.RowPressedBorder = colorFactory_1.GetColor(16777215);
		DataGridView.GridColor = colorFactory_1.GetColor(13686757);
		DataGridView.SelectorBackground = new LinearGradientColorTable(colorFactory_1.GetColor(11125993));
		DataGridView.SelectorBorder = colorFactory_1.GetColor(10401486);
		DataGridView.SelectorBorderDark = colorFactory_1.GetColor(11587575);
		DataGridView.SelectorBorderLight = colorFactory_1.GetColor(14017778);
		DataGridView.SelectorSign = new LinearGradientColorTable(colorFactory_1.GetColor(16382715), colorFactory_1.GetColor(14146274));
		DataGridView.SelectorMouseOverBackground = new LinearGradientColorTable(colorFactory_1.GetColor(9150645));
		DataGridView.SelectorMouseOverBorder = colorFactory_1.GetColor(10401486);
		DataGridView.SelectorMouseOverBorderDark = colorFactory_1.GetColor(11587575);
		DataGridView.SelectorMouseOverBorderLight = colorFactory_1.GetColor(14017778);
		DataGridView.SelectorMouseOverSign = new LinearGradientColorTable(colorFactory_1.GetColor(16382715), colorFactory_1.GetColor(14146274));
		SideBar.Background = new LinearGradientColorTable(colorFactory_1.GetColor(Color.White));
		SideBar.Border = colorFactory_1.GetColor(6656975);
		SideBar.SideBarPanelItemText = colorFactory_1.GetColor(1393291);
		SideBar.SideBarPanelItemDefault = new GradientColorTable();
		SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(14938111), 0f));
		SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(12901887), 0.4f));
		SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(11391487), 0.4f));
		SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(12639231), 1f));
		SideBar.SideBarPanelItemExpanded = new GradientColorTable();
		SideBar.SideBarPanelItemExpanded.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16505781), 0f));
		SideBar.SideBarPanelItemExpanded.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16697208), 0.4f));
		SideBar.SideBarPanelItemExpanded.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16692310), 0.4f));
		SideBar.SideBarPanelItemExpanded.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16640927), 1f));
		SideBar.SideBarPanelItemMouseOver = new GradientColorTable();
		SideBar.SideBarPanelItemMouseOver.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16776409), 0f));
		SideBar.SideBarPanelItemMouseOver.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16770957), 0.4f));
		SideBar.SideBarPanelItemMouseOver.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16766792), 0.4f));
		SideBar.SideBarPanelItemMouseOver.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16770963), 1f));
		SideBar.SideBarPanelItemPressed = new GradientColorTable();
		SideBar.SideBarPanelItemPressed.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16300137), 0f));
		SideBar.SideBarPanelItemPressed.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16622433), 0.4f));
		SideBar.SideBarPanelItemPressed.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16484924), 0.4f));
		SideBar.SideBarPanelItemPressed.Colors.Add(new BackgroundColorBlend(colorFactory_1.GetColor(16694112), 1f));
		AdvTree = new TreeColorTable();
		Class5.smethod_0(AdvTree, colorFactory_1);
		CrumbBarItemView = new CrumbBarItemViewColorTable();
		CrumbBarItemViewStateColorTable crumbBarItemViewStateColorTable = new CrumbBarItemViewStateColorTable();
		CrumbBarItemView.Default = crumbBarItemViewStateColorTable;
		crumbBarItemViewStateColorTable.Foreground = colorFactory_1.GetColor(1393291);
		crumbBarItemViewStateColorTable = new CrumbBarItemViewStateColorTable();
		CrumbBarItemView.MouseOver = crumbBarItemViewStateColorTable;
		crumbBarItemViewStateColorTable.Foreground = colorFactory_1.GetColor(1393291);
		crumbBarItemViewStateColorTable.Background = new BackgroundColorBlendCollection();
		crumbBarItemViewStateColorTable.Background.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_1.GetColor("FFFCD9"), 0f),
			new BackgroundColorBlend(colorFactory_1.GetColor("FFE78D"), 0.4f),
			new BackgroundColorBlend(colorFactory_1.GetColor("FFD748"), 0.4f),
			new BackgroundColorBlend(colorFactory_1.GetColor("FFE793"), 1f)
		});
		crumbBarItemViewStateColorTable.Border = colorFactory_1.GetColor("FFB8A98E");
		crumbBarItemViewStateColorTable.BorderLight = colorFactory_1.GetColor("90FFFFFF");
		crumbBarItemViewStateColorTable = new CrumbBarItemViewStateColorTable();
		CrumbBarItemView.MouseOverInactive = crumbBarItemViewStateColorTable;
		crumbBarItemViewStateColorTable.Foreground = colorFactory_1.GetColor(1393291);
		crumbBarItemViewStateColorTable.Background = new BackgroundColorBlendCollection();
		crumbBarItemViewStateColorTable.Background.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_1.GetColor("FFFFFDEC"), 0f),
			new BackgroundColorBlend(colorFactory_1.GetColor("FFFFF4CA"), 0.4f),
			new BackgroundColorBlend(colorFactory_1.GetColor("FFFFEBA6"), 0.4f),
			new BackgroundColorBlend(colorFactory_1.GetColor("FFFFF2C5"), 1f)
		});
		crumbBarItemViewStateColorTable.Border = colorFactory_1.GetColor("FF8E8F8F");
		crumbBarItemViewStateColorTable.BorderLight = colorFactory_1.GetColor("90FFFFFF");
		crumbBarItemViewStateColorTable = new CrumbBarItemViewStateColorTable();
		CrumbBarItemView.Pressed = crumbBarItemViewStateColorTable;
		crumbBarItemViewStateColorTable.Foreground = colorFactory_1.GetColor(1393291);
		crumbBarItemViewStateColorTable.Background = new BackgroundColorBlendCollection();
		crumbBarItemViewStateColorTable.Background.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(colorFactory_1.GetColor("FFC59B61"), 0f),
			new BackgroundColorBlend(colorFactory_1.GetColor("FFEEB469"), 0.1f),
			new BackgroundColorBlend(colorFactory_1.GetColor("FFFCA060"), 0.6f),
			new BackgroundColorBlend(colorFactory_1.GetColor("FFFB8E3D"), 0.6f),
			new BackgroundColorBlend(colorFactory_1.GetColor("FFFEBB60"), 1f)
		});
		crumbBarItemViewStateColorTable.Border = colorFactory_1.GetColor("FF8B7654");
		crumbBarItemViewStateColorTable.BorderLight = colorFactory_1.GetColor("408B7654");
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.RibbonGalleryContainerKey;
		elementStyle.BorderColor = colorFactory_1.GetColor(12177645);
		elementStyle.Border = eStyleBorderType.Solid;
		elementStyle.BorderWidth = 1;
		elementStyle.CornerDiameter = 2;
		elementStyle.CornerType = eCornerType.Rounded;
		elementStyle.BackColor = colorFactory_1.GetColor(13952760);
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_43(this);
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_44(this);
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_45(this);
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_46(this);
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_47(this);
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_48(colorFactory_1.GetColor(11782113));
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_53(colorFactory_1.GetColor(11782113));
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_54(colorFactory_1, eOffice2007ColorScheme.Blue);
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_55(ListViewEx);
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_56(Bar);
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_49(colorFactory_1.GetColor(11782113));
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_50(colorFactory_1.GetColor(16383229), colorFactory_1.GetColor(13884393), colorFactory_1.GetColor(10401486));
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_51(colorFactory_1.GetColor(16383229), colorFactory_1.GetColor(13884393), colorFactory_1.GetColor(10401486));
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_52(colorFactory_1.GetColor(0));
		hashtable_0.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_57(colorFactory_1.GetColor(Color.White), colorFactory_1.GetColor("FF567DB0"), colorFactory_1.GetColor("FF2F578D"));
		hashtable_0.Add(elementStyle.Class, elementStyle);
	}

	public ElementStyle GetClass(string className)
	{
		if (hashtable_0.ContainsKey(className))
		{
			return (ElementStyle)hashtable_0[className];
		}
		return null;
	}

	public void Dispose()
	{
		if (RibbonControl.StartButtonDefault != null)
		{
			RibbonControl.StartButtonDefault.Dispose();
			RibbonControl.StartButtonDefault = null;
		}
		if (RibbonControl.StartButtonMouseOver != null)
		{
			RibbonControl.StartButtonMouseOver.Dispose();
			RibbonControl.StartButtonMouseOver = null;
		}
		if (RibbonControl.StartButtonPressed != null)
		{
			RibbonControl.StartButtonPressed.Dispose();
			RibbonControl.StartButtonPressed = null;
		}
	}
}
