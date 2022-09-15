using System;
using System.ComponentModel;
using System.Drawing;

namespace DevComponents.DotNetBar;

[TypeConverter(typeof(DocumentDockContainerConverter))]
[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class DocumentDockContainer : DocumentBaseContainer
{
	private struct Struct17
	{
		public int int_0;

		public int int_1;
	}

	private eOrientation eOrientation_0;

	private DocumentBaseContainerCollection documentBaseContainerCollection_0 = new DocumentBaseContainerCollection();

	private int int_0 = 3;

	private Size size_0 = Size.Empty;

	private bool bool_0;

	public override bool Visible
	{
		get
		{
			foreach (DocumentBaseContainer item in documentBaseContainerCollection_0)
			{
				if (item.Visible)
				{
					return true;
				}
			}
			return false;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public eOrientation Orientation
	{
		get
		{
			return eOrientation_0;
		}
		set
		{
			if (eOrientation_0 != value)
			{
				eOrientation_0 = value;
				method_7();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public DocumentBaseContainerCollection Documents => documentBaseContainerCollection_0;

	protected internal override Size MinimumSize => size_0;

	[Description("Indicates the splitter size between the documents docking inside the container.")]
	[Category("Layout")]
	[Browsable(true)]
	[DefaultValue(3)]
	public virtual int SplitterSize
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

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool RecordDocumentSize
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

	public DocumentDockContainer(DocumentBaseContainer[] documents, eOrientation orientation)
	{
		eOrientation_0 = orientation;
		documentBaseContainerCollection_0.DocumentBaseContainer_0 = this;
		documentBaseContainerCollection_0.DocumentAdded += documentBaseContainerCollection_0_DocumentAdded;
		documentBaseContainerCollection_0.DocumentRemoved += documentBaseContainerCollection_0_DocumentRemoved;
		if (documents != null)
		{
			foreach (DocumentBaseContainer tab in documents)
			{
				documentBaseContainerCollection_0.Add(tab);
			}
		}
	}

	public DocumentDockContainer()
		: this(null, eOrientation.Horizontal)
	{
	}

	public override void Layout(Rectangle bounds)
	{
		if (method_5(bounds))
		{
			method_0(bounds);
		}
		else
		{
			method_0(Rectangle.Empty);
		}
	}

	private Struct17 method_3(Rectangle rectangle_2)
	{
		Struct17 result = default(Struct17);
		if (documentBaseContainerCollection_0.Count == 0)
		{
			return result;
		}
		int num = ((eOrientation_0 == eOrientation.Horizontal) ? rectangle_2.Width : rectangle_2.Height);
		int num2 = 0;
		int[] array = new int[documentBaseContainerCollection_0.Count];
		bool flag = false;
		int num3 = documentBaseContainerCollection_0.Count;
		do
		{
			num2 = (num - (num3 - 1) * int_0) / num3;
			flag = false;
			for (int i = 0; i < documentBaseContainerCollection_0.Count; i++)
			{
				if (array[i] == 0)
				{
					DocumentBaseContainer documentBaseContainer = documentBaseContainerCollection_0[i];
					if (eOrientation_0 == eOrientation.Horizontal && documentBaseContainer.LayoutBounds.Width == 0 && documentBaseContainer.MinimumSize.Width > num2)
					{
						array[i] = documentBaseContainer.MinimumSize.Width;
						flag = true;
						num -= array[i];
						num3--;
						break;
					}
					if (eOrientation_0 == eOrientation.Vertical && documentBaseContainer.LayoutBounds.Height == 0 && documentBaseContainer.MinimumSize.Height > num2)
					{
						array[i] = documentBaseContainer.MinimumSize.Height;
						flag = true;
						num -= array[i];
						num3--;
						break;
					}
				}
			}
		}
		while (flag && num3 > 0);
		int num4 = 0;
		int num5 = 0;
		for (int j = 0; j < documentBaseContainerCollection_0.Count; j++)
		{
			DocumentBaseContainer documentBaseContainer2 = documentBaseContainerCollection_0[j];
			if (eOrientation_0 == eOrientation.Horizontal && documentBaseContainer2.LayoutBounds.Width == 0)
			{
				documentBaseContainer2.method_1(new Rectangle(0, 0, (array[j] > 0) ? array[j] : num2, rectangle_2.Height));
			}
			else if (eOrientation_0 == eOrientation.Vertical && documentBaseContainer2.LayoutBounds.Height == 0)
			{
				documentBaseContainer2.method_1(new Rectangle(0, 0, rectangle_2.Width, (array[j] > 0) ? array[j] : num2));
			}
			if (documentBaseContainer2.Visible)
			{
				num4 += ((eOrientation_0 == eOrientation.Horizontal) ? documentBaseContainer2.LayoutBounds.Width : documentBaseContainer2.LayoutBounds.Height) + int_0;
				num5++;
			}
		}
		if (num5 > 0)
		{
			num4 -= int_0;
		}
		result.int_0 = num4;
		result.int_1 = num5;
		return result;
	}

	private bool method_4(float float_0, Rectangle rectangle_2)
	{
		bool flag = false;
		foreach (DocumentBaseContainer item in documentBaseContainerCollection_0)
		{
			if (!item.Visible)
			{
				continue;
			}
			Rectangle rectangle;
			if (eOrientation_0 == eOrientation.Horizontal)
			{
				rectangle = new Rectangle(rectangle_2.X, rectangle_2.Y, (int)((float)item.LayoutBounds.Width * float_0), rectangle_2.Height);
				if (rectangle.Width < item.MinimumSize.Width)
				{
					flag = true;
					break;
				}
			}
			else
			{
				rectangle = new Rectangle(rectangle_2.X, rectangle_2.Y, rectangle_2.Width, (int)((float)item.LayoutBounds.Height * float_0));
				if (rectangle.Height < item.MinimumSize.Height)
				{
					flag = true;
					break;
				}
			}
		}
		if (flag)
		{
			foreach (DocumentBaseContainer item2 in documentBaseContainerCollection_0)
			{
				item2.method_1(Rectangle.Empty);
			}
			return flag;
		}
		return flag;
	}

	private bool method_5(Rectangle rectangle_2)
	{
		if (documentBaseContainerCollection_0.Count == 0)
		{
			return false;
		}
		int num = ((eOrientation_0 == eOrientation.Horizontal) ? rectangle_2.Width : rectangle_2.Height);
		Struct17 @struct = method_3(rectangle_2);
		if (@struct.int_1 == 0)
		{
			return false;
		}
		int num2 = @struct.int_0;
		int int_ = @struct.int_1;
		float num3 = (float)num / (float)num2;
		if (method_4(num3, rectangle_2))
		{
			@struct = method_3(rectangle_2);
		}
		Rectangle rectangle = rectangle_2;
		int num4 = 0;
		bool flag = true;
		if (!bool_0 && Math.Abs(num2 - num) / documentBaseContainerCollection_0.Count != Math.Abs(num2 - num) / documentBaseContainerCollection_0.Count * documentBaseContainerCollection_0.Count)
		{
			flag = false;
		}
		bool flag2 = num2 != num;
		for (int i = 0; i < documentBaseContainerCollection_0.Count; i++)
		{
			DocumentBaseContainer documentBaseContainer = documentBaseContainerCollection_0[i];
			if (documentBaseContainer.Visible)
			{
				num4++;
				Rectangle rectangle2 = (flag2 ? ((eOrientation_0 != 0) ? new Rectangle(rectangle.X, rectangle.Y, rectangle.Width, (int)((float)documentBaseContainer.LayoutBounds.Height * num3)) : new Rectangle(rectangle.X, rectangle.Y, (int)((float)documentBaseContainer.LayoutBounds.Width * num3), rectangle.Height)) : ((eOrientation_0 != 0) ? new Rectangle(rectangle.X, rectangle.Y, rectangle.Width, documentBaseContainer.LayoutBounds.Height) : new Rectangle(rectangle.X, rectangle.Y, documentBaseContainer.LayoutBounds.Width, rectangle.Height)));
				if (num4 == int_)
				{
					rectangle2 = rectangle;
				}
				documentBaseContainer.Layout(rectangle2);
				if (flag)
				{
					documentBaseContainer.method_1(rectangle2);
				}
				if (eOrientation_0 == eOrientation.Horizontal)
				{
					rectangle.Width -= rectangle2.Width + int_0;
					rectangle.X += rectangle2.Width + int_0;
				}
				else
				{
					rectangle.Height -= rectangle2.Height + int_0;
					rectangle.Y += rectangle2.Height + int_0;
				}
			}
		}
		return true;
	}

	protected internal override bool OnSetWidth(DocumentBaseContainer doc, int width)
	{
		bool result = false;
		if (eOrientation_0 == eOrientation.Horizontal && (width >= doc.MinimumSize.Width || doc.MinimumSize.Width <= 0))
		{
			DocumentBaseContainer documentBaseContainer = null;
			DocumentBaseContainer documentBaseContainer2 = null;
			int num = documentBaseContainerCollection_0.IndexOf(doc);
			for (int i = 0; i < documentBaseContainerCollection_0.Count; i++)
			{
				DocumentBaseContainer documentBaseContainer3 = documentBaseContainerCollection_0[i];
				if (documentBaseContainer3.DisplayBounds.Width > 0)
				{
					documentBaseContainer3.method_1(documentBaseContainer3.DisplayBounds);
				}
				if (i > num && documentBaseContainer3.Visible && documentBaseContainer == null)
				{
					documentBaseContainer = documentBaseContainer3;
				}
				else if (i < num && documentBaseContainer3.Visible)
				{
					documentBaseContainer2 = documentBaseContainer3;
				}
			}
			int num2 = doc.LayoutBounds.Width - width;
			if (documentBaseContainer != null && documentBaseContainer.LayoutBounds.Width > 0 && documentBaseContainer.LayoutBounds.Width + num2 > 0 && (documentBaseContainer.LayoutBounds.Width + num2 >= documentBaseContainer.MinimumSize.Width || documentBaseContainer.MinimumSize.Width == 0))
			{
				documentBaseContainer.method_1(new Rectangle(documentBaseContainer.LayoutBounds.X, documentBaseContainer.LayoutBounds.Y, documentBaseContainer.LayoutBounds.Width + num2, documentBaseContainer.LayoutBounds.Height));
				result = true;
			}
			else if (documentBaseContainer == null && documentBaseContainer2 != null && documentBaseContainer2.LayoutBounds.Width > 0 && documentBaseContainer2.LayoutBounds.Width + num2 > 0 && (documentBaseContainer2.LayoutBounds.Width + num2 >= documentBaseContainer2.MinimumSize.Width || documentBaseContainer2.MinimumSize.Width == 0))
			{
				doc.method_1(new Rectangle(doc.LayoutBounds.X, doc.LayoutBounds.Y, width, doc.LayoutBounds.Height));
				documentBaseContainer2.method_1(new Rectangle(documentBaseContainer2.LayoutBounds.X, documentBaseContainer2.LayoutBounds.Y, 0, documentBaseContainer2.LayoutBounds.Height));
				result = true;
			}
			return result;
		}
		return result;
	}

	protected internal override bool OnSetHeight(DocumentBaseContainer doc, int height)
	{
		bool result = false;
		if (eOrientation_0 == eOrientation.Vertical && (height >= doc.MinimumSize.Height || doc.MinimumSize.Height <= 0))
		{
			DocumentBaseContainer documentBaseContainer = null;
			DocumentBaseContainer documentBaseContainer2 = null;
			int num = documentBaseContainerCollection_0.IndexOf(doc);
			for (int i = 0; i < documentBaseContainerCollection_0.Count; i++)
			{
				DocumentBaseContainer documentBaseContainer3 = documentBaseContainerCollection_0[i];
				if (documentBaseContainer3.DisplayBounds.Height > 0)
				{
					documentBaseContainer3.method_1(documentBaseContainer3.DisplayBounds);
				}
				if (i > num && documentBaseContainer3.Visible && documentBaseContainer == null)
				{
					documentBaseContainer = documentBaseContainer3;
				}
				else if (i < num && documentBaseContainer3.Visible)
				{
					documentBaseContainer2 = documentBaseContainer3;
				}
			}
			if (documentBaseContainer == null)
			{
				documentBaseContainer = documentBaseContainer2;
			}
			int num2 = doc.LayoutBounds.Height - height;
			if (documentBaseContainer != null && documentBaseContainer.LayoutBounds.Height > 0 && documentBaseContainer.LayoutBounds.Height + num2 > 0 && (documentBaseContainer.LayoutBounds.Height + num2 >= documentBaseContainer.MinimumSize.Height || documentBaseContainer.MinimumSize.Height == 0))
			{
				documentBaseContainer.method_1(new Rectangle(documentBaseContainer.LayoutBounds.X, documentBaseContainer.LayoutBounds.Y, documentBaseContainer.LayoutBounds.Width, documentBaseContainer.LayoutBounds.Height + num2));
				result = true;
			}
			else if (documentBaseContainer == null && documentBaseContainer2 != null && documentBaseContainer2.LayoutBounds.Height > 0 && documentBaseContainer2.LayoutBounds.Height + num2 > 0 && (documentBaseContainer2.LayoutBounds.Height + num2 >= documentBaseContainer2.MinimumSize.Height || documentBaseContainer2.MinimumSize.Height == 0))
			{
				doc.method_1(new Rectangle(doc.LayoutBounds.X, doc.LayoutBounds.Y, doc.LayoutBounds.Width, height));
				documentBaseContainer2.method_1(new Rectangle(documentBaseContainer2.LayoutBounds.X, documentBaseContainer2.LayoutBounds.Y, documentBaseContainer2.LayoutBounds.Width, 0));
				result = true;
			}
			return result;
		}
		return result;
	}

	public DocumentBarContainer GetBarDocumentContainer(Bar bar)
	{
		foreach (DocumentBaseContainer item in documentBaseContainerCollection_0)
		{
			if (!(item is DocumentBarContainer) || ((DocumentBarContainer)item).Bar != bar)
			{
				if (item is DocumentDockContainer)
				{
					DocumentBarContainer barDocumentContainer = ((DocumentDockContainer)item).GetBarDocumentContainer(bar);
					if (barDocumentContainer != null)
					{
						return barDocumentContainer;
					}
				}
				continue;
			}
			return (DocumentBarContainer)item;
		}
		return null;
	}

	private void documentBaseContainerCollection_0_DocumentAdded(object sender, EventArgs e)
	{
		DocumentBaseContainer documentBaseContainer = sender as DocumentBaseContainer;
		Size minimumSize = documentBaseContainer.MinimumSize;
		if (eOrientation_0 == eOrientation.Horizontal)
		{
			size_0.Width += minimumSize.Width + int_0;
			if (minimumSize.Height > size_0.Height)
			{
				size_0.Height = minimumSize.Height;
			}
		}
		else
		{
			size_0.Height += minimumSize.Height + int_0;
			if (minimumSize.Width > size_0.Width)
			{
				size_0.Width = minimumSize.Width;
			}
		}
	}

	internal void documentBaseContainerCollection_0_DocumentRemoved(object sender, EventArgs e)
	{
		method_6();
	}

	internal void method_6()
	{
		size_0 = Size.Empty;
		foreach (DocumentBaseContainer item in documentBaseContainerCollection_0)
		{
			Size minimumSize = item.MinimumSize;
			if (eOrientation_0 == eOrientation.Horizontal)
			{
				size_0.Width += minimumSize.Width + int_0;
				if (minimumSize.Height > size_0.Height)
				{
					size_0.Height = minimumSize.Height;
				}
			}
			else
			{
				size_0.Height += minimumSize.Height + int_0;
				if (minimumSize.Width > size_0.Width)
				{
					size_0.Width = minimumSize.Width;
				}
			}
		}
	}

	private void method_7()
	{
		method_8();
	}

	private void method_8()
	{
		foreach (DocumentBaseContainer item in documentBaseContainerCollection_0)
		{
			item.method_1(Rectangle.Empty);
		}
	}
}
