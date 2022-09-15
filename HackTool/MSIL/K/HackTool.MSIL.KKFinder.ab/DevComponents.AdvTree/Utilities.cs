using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using DevComponents.Editors.DateTimeAdv;

namespace DevComponents.AdvTree;

public class Utilities
{
	private static string String_0 => DateTimeInput.GetActiveCulture().NumberFormat.NumberDecimalSeparator;

	public static void InitializeTree(AdvTree tree)
	{
		smethod_0(tree, new Class25());
	}

	internal static void smethod_0(AdvTree advTree_0, Class25 class25_0)
	{
		advTree_0.NodesConnector = class25_0.method_0(typeof(NodeConnector)) as NodeConnector;
		advTree_0.NodesConnector.LineWidth = 1;
		advTree_0.NodesConnector.LineColor = SystemColors.ControlText;
		((Control)advTree_0).set_BackColor(SystemColors.Window);
		ElementStyle elementStyle = class25_0.method_0(typeof(ElementStyle)) as ElementStyle;
		elementStyle.TextColor = SystemColors.ControlText;
		advTree_0.Styles.Add(elementStyle);
		advTree_0.NodeStyle = elementStyle;
		advTree_0.BackgroundStyle.Class = ElementStyleClassKeys.TreeBorderKey;
		((Control)advTree_0).set_AccessibleRole((AccessibleRole)35);
	}

	internal static ElementStyle smethod_1(Class25 class25_0, string string_0, Color color_0, Color color_1, Color color_2, int int_0, Color color_3)
	{
		ElementStyle elementStyle = class25_0.method_0(typeof(ElementStyle)) as ElementStyle;
		elementStyle.Description = string_0;
		elementStyle.BackColor = color_1;
		elementStyle.BackColor2 = color_2;
		elementStyle.BackColorGradientAngle = int_0;
		elementStyle.CornerDiameter = 4;
		elementStyle.CornerType = eCornerType.Square;
		elementStyle.BorderLeft = eStyleBorderType.Solid;
		elementStyle.BorderLeftWidth = 1;
		elementStyle.BorderTop = eStyleBorderType.Solid;
		elementStyle.BorderTopWidth = 1;
		elementStyle.BorderBottom = eStyleBorderType.Solid;
		elementStyle.BorderBottomWidth = 1;
		elementStyle.BorderRight = eStyleBorderType.Solid;
		elementStyle.BorderRightWidth = 1;
		elementStyle.BorderColor = color_0;
		elementStyle.PaddingBottom = 1;
		elementStyle.PaddingLeft = 1;
		elementStyle.PaddingRight = 1;
		elementStyle.PaddingTop = 1;
		elementStyle.TextColor = color_3;
		return elementStyle;
	}

	public static Node FindNodeForControl(AdvTree tree, Control c)
	{
		if (tree != null && c != null && tree.Nodes.Count != 0)
		{
			for (Node node = tree.Nodes[0]; node != null; node = node.NextVisibleNode)
			{
				foreach (Cell cell in node.Cells)
				{
					if (cell.HostedControl == c)
					{
						return node;
					}
				}
			}
			return null;
		}
		return null;
	}

	internal static bool smethod_2(string string_0)
	{
		if (string_0.Length > 0 && char.IsDigit(string_0[0]))
		{
			return true;
		}
		return false;
	}

	internal static int smethod_3(string string_0, string string_1)
	{
		if (smethod_2(string_0) && smethod_2(string_1))
		{
			long num = smethod_4(string_0);
			long value = smethod_4(string_1);
			int num2 = num.CompareTo(value);
			if (num2 != 0)
			{
				return num2;
			}
		}
		return string.Compare(string_0, string_1, StringComparison.CurrentCulture);
	}

	internal static long smethod_4(string string_0)
	{
		long result = 0L;
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < string_0.Length && char.IsDigit(string_0[i]); i++)
		{
			num2 = i;
		}
		long.TryParse(string_0.Substring(num, num2 - num + 1), out result);
		return result;
	}

	internal static string smethod_5(string string_0)
	{
		string text = "";
		for (int i = 0; i < string_0.Length; i++)
		{
			if (!(string_0[i].ToString() == String_0) && (string_0[i] < '0' || string_0[i] > '9') && (i != 0 || string_0[i] != '-'))
			{
				if (text.Length > 0)
				{
					break;
				}
			}
			else
			{
				text += string_0[i];
			}
		}
		return text;
	}
}
