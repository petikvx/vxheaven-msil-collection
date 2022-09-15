using System.Drawing;

namespace DevComponents.DotNetBar;

public interface IDesignTimeProvider
{
	InsertPosition GetInsertPosition(Point pScreen, BaseItem DragItem);

	void DrawReversibleMarker(int iPos, bool Before);

	void InsertItemAt(BaseItem objItem, int iPos, bool Before);
}
