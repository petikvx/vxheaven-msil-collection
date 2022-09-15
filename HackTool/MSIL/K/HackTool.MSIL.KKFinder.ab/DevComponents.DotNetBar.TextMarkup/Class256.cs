using System.Drawing;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class256 : Class245
{
	private SerialContentLayoutManager serialContentLayoutManager_0;

	private Class278 class278_0;

	public override bool IsBlockElement => true;

	public override void Measure(Size availableSize, Class263 d)
	{
		ArrangeInternal(new Rectangle(Point.Empty, availableSize), d);
	}

	protected virtual SerialContentLayoutManager GetLayoutManager(bool mutliLine)
	{
		if (serialContentLayoutManager_0 == null)
		{
			serialContentLayoutManager_0 = new SerialContentLayoutManager();
			serialContentLayoutManager_0.MultiLine = mutliLine;
			serialContentLayoutManager_0.ContentVerticalAlignment = eContentVerticalAlignment.Top;
			serialContentLayoutManager_0.BlockLineAlignment = eContentVerticalAlignment.Top;
			serialContentLayoutManager_0.BlockSpacing = 0;
		}
		serialContentLayoutManager_0.EvenHeight = true;
		return serialContentLayoutManager_0;
	}

	private Class278 method_3()
	{
		if (class278_0 == null)
		{
			class278_0 = new Class278();
		}
		return class278_0;
	}

	public override void Render(Class263 d)
	{
		Point containerOffset = GetContainerOffset();
		d.point_0.Offset(containerOffset.X, containerOffset.Y);
		try
		{
			foreach (Class245 element in Elements)
			{
				element.Render(d);
			}
		}
		finally
		{
			d.point_0.Offset(-containerOffset.X, -containerOffset.Y);
		}
	}

	protected virtual Point GetContainerOffset()
	{
		return base.Bounds.Location;
	}

	protected override void ArrangeCore(Rectangle finalRect, Class263 d)
	{
		base.Bounds = finalRect;
		ArrangeInternal(finalRect, d);
	}

	protected virtual void ArrangeInternal(Rectangle bounds, Class263 d)
	{
		SerialContentLayoutManager layoutManager = GetLayoutManager(d.bool_4);
		layoutManager.RightToLeft = d.bool_0;
		Class278 @class = method_3();
		@class.Class263_0 = d;
		Class245[] array = new Class245[Elements.Count];
		Elements.method_6(array);
		base.Bounds = new Rectangle(size: layoutManager.Layout(new Rectangle(Point.Empty, bounds.Size), array, @class).Size, location: bounds.Location);
	}
}
