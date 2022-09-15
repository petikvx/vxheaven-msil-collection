using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class FormCaptionRendererEventArgs : EventArgs
{
	public Graphics Graphics;

	public Rectangle Bounds = Rectangle.Empty;

	public Form Form;

	public FormCaptionRendererEventArgs(Graphics g, Rectangle bounds, Form form)
	{
		Graphics = g;
		Bounds = bounds;
		Form = form;
	}
}
