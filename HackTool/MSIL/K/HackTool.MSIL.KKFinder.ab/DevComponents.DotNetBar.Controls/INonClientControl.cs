using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.Controls;

public interface INonClientControl
{
	ElementStyle BorderStyle { get; }

	IntPtr Handle { get; }

	int Width { get; }

	int Height { get; }

	bool IsHandleCreated { get; }

	Color BackColor { get; }

	bool Enabled { get; set; }

	void BaseWndProc(ref Message m);

	ItemPaintArgs GetItemPaintArgs(Graphics g);

	void PaintBackground(PaintEventArgs e);

	Point PointToScreen(Point client);

	void AdjustClientRectangle(ref Rectangle r);

	void AdjustBorderRectangle(ref Rectangle r);

	void RenderNonClient(Graphics g);
}
