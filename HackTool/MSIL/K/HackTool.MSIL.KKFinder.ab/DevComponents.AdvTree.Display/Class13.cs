using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.AdvTree.Display;

internal class Class13
{
	private static Class229 class229_0;

	public static Office2007CheckBoxColorTable office2007CheckBoxColorTable_0;

	public static Class229 Class229_0
	{
		get
		{
			return class229_0;
		}
		set
		{
			class229_0 = value;
		}
	}

	public static void smethod_0(NodeCellRendererEventArgs nodeCellRendererEventArgs_0)
	{
		if (nodeCellRendererEventArgs_0.Cell.CheckBoxVisible)
		{
			smethod_1(nodeCellRendererEventArgs_0);
		}
		if (!nodeCellRendererEventArgs_0.Cell.Images.Size_0.IsEmpty)
		{
			smethod_3(nodeCellRendererEventArgs_0);
		}
		smethod_4(nodeCellRendererEventArgs_0);
	}

	public static void smethod_1(NodeCellRendererEventArgs nodeCellRendererEventArgs_0)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		if (!nodeCellRendererEventArgs_0.Cell.CheckBoxVisible)
		{
			return;
		}
		Cell cell = nodeCellRendererEventArgs_0.Cell;
		Rectangle checkBoxBoundsRelative = cell.CheckBoxBoundsRelative;
		checkBoxBoundsRelative.Offset(nodeCellRendererEventArgs_0.point_0);
		if (nodeCellRendererEventArgs_0.image_0 != null)
		{
			Image val = nodeCellRendererEventArgs_0.image_0;
			if ((int)cell.CheckState == 0)
			{
				val = nodeCellRendererEventArgs_0.image_1;
			}
			else if ((int)cell.CheckState == 2)
			{
				val = nodeCellRendererEventArgs_0.image_2;
			}
			if (val != null)
			{
				nodeCellRendererEventArgs_0.Graphics.DrawImage(val, checkBoxBoundsRelative);
			}
		}
		else if (class229_0 != null)
		{
			Office2007CheckBoxStateColorTable office2007CheckBoxStateColorTable_ = smethod_2(nodeCellRendererEventArgs_0);
			if (cell.CheckBoxStyle == eCheckBoxStyle.CheckBox)
			{
				class229_0.method_1(nodeCellRendererEventArgs_0.Graphics, checkBoxBoundsRelative, office2007CheckBoxStateColorTable_, cell.CheckState);
			}
			else
			{
				class229_0.method_0(nodeCellRendererEventArgs_0.Graphics, checkBoxBoundsRelative, office2007CheckBoxStateColorTable_, cell.Checked);
			}
		}
		else
		{
			ButtonState val2 = (ButtonState)0;
			if (nodeCellRendererEventArgs_0.Cell.Checked)
			{
				val2 = (ButtonState)1024;
			}
			ControlPaint.DrawCheckBox(nodeCellRendererEventArgs_0.Graphics, checkBoxBoundsRelative, val2);
		}
	}

	private static Office2007CheckBoxStateColorTable smethod_2(NodeCellRendererEventArgs nodeCellRendererEventArgs_0)
	{
		Cell cell = nodeCellRendererEventArgs_0.Cell;
		if (office2007CheckBoxColorTable_0 != null && nodeCellRendererEventArgs_0.colorScheme_0.EDotNetBarStyle_0 == eDotNetBarStyle.Office2007)
		{
			Office2007CheckBoxColorTable office2007CheckBoxColorTable = office2007CheckBoxColorTable_0;
			if (!cell.GetEnabled())
			{
				return office2007CheckBoxColorTable.Disabled;
			}
			return office2007CheckBoxColorTable.Default;
		}
		ColorScheme colorScheme_ = nodeCellRendererEventArgs_0.colorScheme_0;
		Office2007CheckBoxStateColorTable office2007CheckBoxStateColorTable = new Office2007CheckBoxStateColorTable();
		if (!cell.GetEnabled())
		{
			office2007CheckBoxStateColorTable.CheckBackground = new LinearGradientColorTable(colorScheme_.MenuBackground, Color.Empty);
			office2007CheckBoxStateColorTable.CheckBorder = colorScheme_.ItemDisabledText;
			office2007CheckBoxStateColorTable.CheckInnerBorder = colorScheme_.ItemDisabledText;
			office2007CheckBoxStateColorTable.CheckInnerBackground = new LinearGradientColorTable();
			office2007CheckBoxStateColorTable.CheckSign = new LinearGradientColorTable(colorScheme_.ItemDisabledText, Color.Empty);
			office2007CheckBoxStateColorTable.Text = colorScheme_.ItemDisabledText;
		}
		else
		{
			office2007CheckBoxStateColorTable.CheckBackground = new LinearGradientColorTable(colorScheme_.MenuBackground, Color.Empty);
			office2007CheckBoxStateColorTable.CheckBorder = colorScheme_.PanelBorder;
			office2007CheckBoxStateColorTable.CheckInnerBorder = ColorBlendFactory.smethod_1(colorScheme_.PanelBorder, Color.White);
			office2007CheckBoxStateColorTable.CheckInnerBackground = new LinearGradientColorTable(colorScheme_.MenuBackground, Color.Empty);
			office2007CheckBoxStateColorTable.CheckSign = new LinearGradientColorTable(colorScheme_.ItemText, Color.Empty);
			office2007CheckBoxStateColorTable.Text = colorScheme_.ItemText;
		}
		return office2007CheckBoxStateColorTable;
	}

	public static void smethod_3(NodeCellRendererEventArgs nodeCellRendererEventArgs_0)
	{
		if (!nodeCellRendererEventArgs_0.Cell.Images.Size_0.IsEmpty)
		{
			Rectangle imageBoundsRelative = nodeCellRendererEventArgs_0.Cell.ImageBoundsRelative;
			imageBoundsRelative.Offset(nodeCellRendererEventArgs_0.point_0);
			Image val = smethod_5(nodeCellRendererEventArgs_0.Cell);
			if (val != null)
			{
				nodeCellRendererEventArgs_0.Graphics.DrawImage(val, imageBoundsRelative.X + (imageBoundsRelative.Width - val.get_Width()) / 2, imageBoundsRelative.Y + (imageBoundsRelative.Height - val.get_Height()) / 2, val.get_Width(), val.get_Height());
			}
		}
	}

	public static void smethod_4(NodeCellRendererEventArgs nodeCellRendererEventArgs_0)
	{
		Cell cell = nodeCellRendererEventArgs_0.Cell;
		if ((cell.HostedControl == null && (cell.Text == "" || nodeCellRendererEventArgs_0.Style.TextColor.IsEmpty)) || cell.TextContentBounds.IsEmpty)
		{
			return;
		}
		Rectangle textContentBounds = nodeCellRendererEventArgs_0.Cell.TextContentBounds;
		textContentBounds.Offset(nodeCellRendererEventArgs_0.point_0);
		if (cell.HostedControl != null)
		{
			if (!cell.HostedControl.get_Visible())
			{
				cell.HostedControl.set_Visible(true);
			}
			return;
		}
		Font font = nodeCellRendererEventArgs_0.Style.Font;
		if (textContentBounds.Width > 1 && textContentBounds.Height > 1)
		{
			if (cell.TextMarkupBody == null)
			{
				Class55.smethod_1(nodeCellRendererEventArgs_0.Graphics, cell.Text, font, nodeCellRendererEventArgs_0.Style.TextColor, textContentBounds, nodeCellRendererEventArgs_0.Style.ETextFormat_0);
				return;
			}
			Class263 @class = new Class263(nodeCellRendererEventArgs_0.Graphics, font, nodeCellRendererEventArgs_0.Style.TextColor, rightToLeft: false);
			@class.bool_3 = (nodeCellRendererEventArgs_0.Style.ETextFormat_0 & eTextFormat.HidePrefix) != eTextFormat.HidePrefix;
			Rectangle bounds = Rectangle.Empty;
			bounds = nodeCellRendererEventArgs_0.Style.TextLineAlignment switch
			{
				eStyleTextAlignment.Center => new Rectangle(textContentBounds.X, textContentBounds.Y + (textContentBounds.Height - cell.TextMarkupBody.Bounds.Height) / 2, cell.TextMarkupBody.Bounds.Width, cell.TextMarkupBody.Bounds.Height), 
				eStyleTextAlignment.Near => new Rectangle(textContentBounds.X, textContentBounds.Y, cell.TextMarkupBody.Bounds.Width, cell.TextMarkupBody.Bounds.Height), 
				_ => new Rectangle(textContentBounds.X, textContentBounds.Y + (textContentBounds.Height - cell.TextMarkupBody.Bounds.Height), cell.TextMarkupBody.Bounds.Width, cell.TextMarkupBody.Bounds.Height), 
			};
			cell.TextMarkupBody.Bounds = bounds;
			cell.TextMarkupBody.Render(@class);
		}
	}

	private static Image smethod_5(Cell cell_0)
	{
		Image val = cell_0.Images.Image;
		bool enabled;
		if (!(enabled = cell_0.GetEnabled()) && (cell_0.Images.ImageDisabled != null || cell_0.Images.ImageDisabledIndex >= 0 || cell_0.Images.Image_0 != null))
		{
			if (cell_0.Images.Image_0 != null)
			{
				return cell_0.Images.Image_0;
			}
			if (cell_0.Images.ImageDisabled != null)
			{
				return cell_0.Images.ImageDisabled;
			}
			if (cell_0.Images.ImageDisabledIndex >= 0)
			{
				return cell_0.Images.method_4(cell_0.Images.ImageDisabledIndex);
			}
		}
		if (val == null && cell_0.Images.ImageIndex >= 0)
		{
			val = cell_0.Images.method_4(cell_0.Images.ImageIndex);
		}
		if (!enabled && val is Bitmap)
		{
			cell_0.Images.method_1();
			cell_0.Images.Image_0 = (Image)(object)Class31.smethod_1((val is Bitmap) ? val : null);
			if (cell_0.Images.Image_0 != null)
			{
				return cell_0.Images.Image_0;
			}
			return val;
		}
		if (cell_0.IsMouseOver && (cell_0.Images.ImageMouseOver != null || cell_0.Images.ImageMouseOverIndex >= 0))
		{
			val = ((cell_0.Images.ImageMouseOver == null) ? cell_0.Images.method_4(cell_0.Images.ImageMouseOverIndex) : cell_0.Images.ImageMouseOver);
		}
		else if (cell_0.Parent.Expanded && (cell_0.Images.ImageExpanded != null || cell_0.Images.ImageExpandedIndex >= 0))
		{
			val = ((cell_0.Images.ImageExpanded == null) ? cell_0.Images.method_4(cell_0.Images.ImageExpandedIndex) : cell_0.Images.ImageExpanded);
		}
		return val;
	}

	public static Font smethod_6(AdvTree advTree_0, Cell cell_0)
	{
		Font font = ((Control)advTree_0).get_Font();
		ElementStyle elementStyle = null;
		if (cell_0.StyleNormal == null)
		{
			elementStyle = ((advTree_0.NodeStyle == null) ? new ElementStyle() : advTree_0.NodeStyle);
			elementStyle = ((advTree_0.CellStyleDefault == null) ? ElementStyle.GetDefaultCellStyle(elementStyle) : advTree_0.CellStyleDefault);
		}
		else
		{
			elementStyle = cell_0.StyleNormal;
		}
		if (elementStyle != null && elementStyle.Font != null)
		{
			font = elementStyle.Font;
		}
		return font;
	}
}
