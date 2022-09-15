using System.ComponentModel;
using System.Drawing;

namespace DevComponents.DotNetBar;

public abstract class DocumentBaseContainer
{
	private Rectangle rectangle_0 = Rectangle.Empty;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private DocumentBaseContainer documentBaseContainer_0;

	[Browsable(false)]
	public virtual Rectangle DisplayBounds => rectangle_1;

	[Browsable(false)]
	public virtual Rectangle LayoutBounds => rectangle_0;

	public virtual DocumentBaseContainer Parent => documentBaseContainer_0;

	public abstract bool Visible { get; }

	protected internal abstract Size MinimumSize { get; }

	public DocumentBaseContainer()
	{
	}

	public abstract void Layout(Rectangle bounds);

	internal void method_0(Rectangle rectangle_2)
	{
		rectangle_1 = rectangle_2;
	}

	internal void method_1(Rectangle rectangle_2)
	{
		rectangle_0 = rectangle_2;
	}

	public void ResetLayoutBounds()
	{
		rectangle_0 = Rectangle.Empty;
	}

	public void ResetDisplayBounds()
	{
		rectangle_1 = Rectangle.Empty;
	}

	internal void method_2(DocumentBaseContainer documentBaseContainer_1)
	{
		documentBaseContainer_0 = documentBaseContainer_1;
	}

	public virtual void SetWidth(int width)
	{
		if (documentBaseContainer_0 != null)
		{
			documentBaseContainer_0.OnSetWidth(this, width);
		}
		if (width >= MinimumSize.Width || MinimumSize.Width == 0)
		{
			ResetDisplayBounds();
			rectangle_0.Width = width;
		}
	}

	public virtual void SetHeight(int height)
	{
		if (documentBaseContainer_0 != null)
		{
			documentBaseContainer_0.OnSetHeight(this, height);
		}
		if (height >= MinimumSize.Height || MinimumSize.Height == 0)
		{
			ResetDisplayBounds();
			rectangle_0.Height = height;
		}
	}

	protected internal virtual bool OnSetWidth(DocumentBaseContainer doc, int width)
	{
		return false;
	}

	protected internal virtual bool OnSetHeight(DocumentBaseContainer doc, int height)
	{
		return false;
	}
}
