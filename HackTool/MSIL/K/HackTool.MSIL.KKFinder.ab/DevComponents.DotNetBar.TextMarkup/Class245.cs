using System.Drawing;
using System.Xml;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar.TextMarkup;

internal abstract class Class245 : IBlock, IBlockExtended
{
	private Class244 class244_0;

	private Class245 class245_0;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private bool bool_0 = true;

	private bool bool_1;

	private Rectangle rectangle_1 = Rectangle.Empty;

	public virtual bool IsBlockElement => false;

	public virtual bool IsNewLineAfterElement => false;

	public virtual bool CanStartNewLine => true;

	public virtual Class244 Elements
	{
		get
		{
			if (class244_0 == null)
			{
				class244_0 = new Class244(this);
			}
			return class244_0;
		}
	}

	public virtual bool IsSizeValid
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

	public virtual Class245 Parent => class245_0;

	public Rectangle Bounds
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

	public bool Visible
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

	public Rectangle Rectangle_0
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

	public Class245()
	{
		class244_0 = new Class244(this);
	}

	internal void method_0()
	{
		if (!IsBlockElement || class244_0 == null)
		{
			return;
		}
		foreach (Class245 item in class244_0)
		{
			item.IsSizeValid = false;
		}
	}

	internal void method_1(Class245 class245_1)
	{
		class245_0 = class245_1;
	}

	public abstract void Measure(Size availableSize, Class263 d);

	public virtual void MeasureEnd(Size availableSize, Class263 d)
	{
	}

	public abstract void Render(Class263 d);

	public virtual void RenderEnd(Class263 d)
	{
	}

	protected abstract void ArrangeCore(Rectangle finalRect, Class263 d);

	public void method_2(Rectangle rectangle_2, Class263 class263_0)
	{
		ArrangeCore(rectangle_2, class263_0);
	}

	public virtual void ReadAttributes(XmlTextReader reader)
	{
	}
}
