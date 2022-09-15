using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.Controls;

[ToolboxItem(false)]
public class ControlWithBackgroundStyle : Control
{
	private ElementStyle elementStyle_0;

	private bool bool_0 = true;

	[DefaultValue(true)]
	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[Category("Appearance")]
	public bool AntiAlias
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (bool_0 != value)
			{
				bool_0 = value;
				((Control)this).Invalidate();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Indicates control background style.")]
	[Category("Style")]
	public ElementStyle BackgroundStyle => elementStyle_0;

	public ControlWithBackgroundStyle()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)4096, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		elementStyle_0 = new ElementStyle();
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackgroundStyle()
	{
		elementStyle_0.StyleChanged -= elementStyle_0_StyleChanged;
		elementStyle_0 = new ElementStyle();
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		((Control)this).Invalidate();
	}

	private void elementStyle_0_StyleChanged(object sender, EventArgs e)
	{
		OnVisualPropertyChanged();
	}

	protected virtual void OnVisualPropertyChanged()
	{
		((Control)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (((Control)this).get_BackColor().IsEmpty || ((Control)this).get_BackColor() == Color.Transparent)
		{
			((Control)this).OnPaintBackground(e);
		}
		PaintBackground(e);
		PaintContent(e);
		((Control)this).OnPaint(e);
	}

	protected virtual void PaintContent(PaintEventArgs e)
	{
	}

	protected virtual Rectangle GetContentRectangle()
	{
		ElementStyle backgroundStyle = GetBackgroundStyle();
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		clientRectangle.X += Class52.smethod_3(backgroundStyle);
		clientRectangle.Y += Class52.smethod_7(backgroundStyle);
		clientRectangle.Width -= Class52.smethod_1(backgroundStyle);
		clientRectangle.Height -= Class52.smethod_2(backgroundStyle);
		return clientRectangle;
	}

	protected virtual ElementStyle GetBackgroundStyle()
	{
		return elementStyle_0;
	}

	protected virtual void PaintBackground(PaintEventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = e.get_Graphics();
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		ElementStyle backgroundStyle = GetBackgroundStyle();
		if (!((Control)this).get_BackColor().IsEmpty)
		{
			Class50.smethod_23(graphics, clientRectangle, ((Control)this).get_BackColor());
		}
		if (backgroundStyle.Custom)
		{
			SmoothingMode smoothingMode = graphics.get_SmoothingMode();
			if (AntiAlias)
			{
				graphics.set_SmoothingMode((SmoothingMode)2);
			}
			ElementStyleDisplayInfo e2 = new ElementStyleDisplayInfo(backgroundStyle, e.get_Graphics(), clientRectangle);
			ElementStyleDisplay.Paint(e2);
			if (AntiAlias)
			{
				graphics.set_SmoothingMode(smoothingMode);
			}
		}
	}
}
