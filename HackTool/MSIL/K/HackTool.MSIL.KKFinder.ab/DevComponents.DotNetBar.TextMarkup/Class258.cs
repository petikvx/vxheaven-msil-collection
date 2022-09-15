using System.Drawing;
using System.Xml;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class258 : Class256
{
	private Enum29 enum29_0;

	private Enum28 enum28_0;

	private int int_0;

	private Padding padding_0 = new Padding(0, 0, 0, 0);

	public Enum29 Enum29_0
	{
		get
		{
			return enum29_0;
		}
		set
		{
			enum29_0 = value;
		}
	}

	protected override SerialContentLayoutManager GetLayoutManager(bool multiLine)
	{
		SerialContentLayoutManager layoutManager = base.GetLayoutManager(multiLine);
		if (enum29_0 == Enum29.const_0)
		{
			layoutManager.ContentAlignment = eContentAlignment.Left;
		}
		else if (enum29_0 == Enum29.const_1)
		{
			layoutManager.ContentAlignment = eContentAlignment.Right;
		}
		else if (enum29_0 == Enum29.const_2)
		{
			layoutManager.ContentAlignment = eContentAlignment.Center;
		}
		if (enum28_0 != 0)
		{
			layoutManager.EvenHeight = false;
			layoutManager.BlockLineAlignment = ((enum28_0 == Enum28.const_2) ? eContentVerticalAlignment.Bottom : eContentVerticalAlignment.Middle);
		}
		return layoutManager;
	}

	protected override Point GetContainerOffset()
	{
		if (padding_0.Left == 0 && padding_0.Top == 0)
		{
			return base.GetContainerOffset();
		}
		Point containerOffset = base.GetContainerOffset();
		containerOffset.X += padding_0.Left;
		containerOffset.Y += padding_0.Top;
		return containerOffset;
	}

	protected override void ArrangeInternal(Rectangle bounds, Class263 d)
	{
		Rectangle bounds2 = bounds;
		if (int_0 > 0)
		{
			bounds2.Width = int_0;
		}
		if (padding_0.IsEmpty)
		{
			base.ArrangeInternal(bounds2, d);
			if (int_0 > 0)
			{
				base.Bounds = new Rectangle(base.Bounds.X, base.Bounds.Y, int_0, base.Bounds.Height + padding_0.Bottom);
			}
			return;
		}
		bounds2.X += padding_0.Left;
		bounds2.Y += padding_0.Top;
		base.ArrangeInternal(bounds2, d);
		bounds2 = new Rectangle(bounds.X, bounds.Y, base.Bounds.Width + padding_0.Horizontal, base.Bounds.Height + padding_0.Vertical);
		if (int_0 > 0)
		{
			bounds2.Width = int_0;
		}
		base.Bounds = bounds2;
	}

	public override void ReadAttributes(XmlTextReader reader)
	{
		for (int i = 0; i < reader.AttributeCount; i++)
		{
			reader.MoveToAttribute(i);
			if (reader.Name.ToLower() == "align")
			{
				switch (reader.Value.ToLower())
				{
				case "left":
					enum29_0 = Enum29.const_0;
					break;
				case "right":
					enum29_0 = Enum29.const_1;
					break;
				case "center":
					enum29_0 = Enum29.const_2;
					break;
				}
			}
			else if (reader.Name.ToLower() == "valign")
			{
				switch (reader.Value.ToLower())
				{
				case "top":
					enum28_0 = Enum28.const_0;
					break;
				case "middle":
					enum28_0 = Enum28.const_1;
					break;
				case "bottom":
					enum28_0 = Enum28.const_2;
					break;
				}
			}
			else if (reader.Name.ToLower() == "width")
			{
				try
				{
					int_0 = int.Parse(reader.Value);
				}
				catch
				{
					int_0 = 0;
				}
			}
			else
			{
				if (!(reader.Name.ToLower() == "padding"))
				{
					continue;
				}
				try
				{
					string[] array = reader.Value.Split(new char[1] { ',' });
					if (array.Length > 0)
					{
						padding_0.Left = int.Parse(array[0]);
					}
					if (array.Length > 1)
					{
						padding_0.Right = int.Parse(array[1]);
					}
					if (array.Length > 2)
					{
						padding_0.Top = int.Parse(array[2]);
					}
					if (array.Length > 3)
					{
						padding_0.Bottom = int.Parse(array[3]);
					}
				}
				catch
				{
					padding_0 = new Padding(0, 0, 0, 0);
				}
			}
		}
	}
}
