using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[ToolboxItem(true)]
[DefaultEvent("SelectedColorChanged")]
[Designer(typeof(ColorPickerButtonDesigner))]
[ToolboxBitmap(typeof(ColorPickerButton), "Controls.ColorPickerButton.ico")]
[ComVisible(false)]
public class ColorPickerButton : ButtonX
{
	private EventHandler eventHandler_6;

	private ColorPreviewEventHandler colorPreviewEventHandler_0;

	protected new virtual bool ExecuteCommandOnClick => false;

	[Category("Appearance")]
	[DevCoSerialize]
	[Browsable(true)]
	[Description("Indicates more colors menu item is visible which allows user to open Custom Colors dialog box.")]
	[DefaultValue(true)]
	public bool DisplayMoreColors
	{
		get
		{
			return method_12().DisplayMoreColors;
		}
		set
		{
			method_12().DisplayMoreColors = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Color SelectedColor
	{
		get
		{
			return method_12().SelectedColor;
		}
		set
		{
			method_12().SelectedColor = value;
		}
	}

	[DevCoSerialize]
	[Description("Indicates whether theme colors are displayed on drop-down.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(true)]
	public bool DisplayThemeColors
	{
		get
		{
			return method_12().DisplayThemeColors;
		}
		set
		{
			method_12().DisplayThemeColors = value;
		}
	}

	[DefaultValue(true)]
	[DevCoSerialize]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates whether standard colors are displayed on drop-down.")]
	public bool DisplayStandardColors
	{
		get
		{
			return method_12().DisplayStandardColors;
		}
		set
		{
			method_12().DisplayStandardColors = value;
		}
	}

	[Browsable(true)]
	[Category("Behaviour")]
	[Description("Indicates rectangle in Image coordinates where selected color will be painted. Property will have effect only if Image property is used to set the image.")]
	public Rectangle SelectedColorImageRectangle
	{
		get
		{
			return method_12().SelectedColorImageRectangle;
		}
		set
		{
			method_12().SelectedColorImageRectangle = value;
		}
	}

	[Description("Occurs when color is chosen from drop-down color picker or from Custom Colors dialog box.")]
	public event EventHandler SelectedColorChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_6 = (EventHandler)Delegate.Combine(eventHandler_6, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_6 = (EventHandler)Delegate.Remove(eventHandler_6, value);
		}
	}

	[Description("Occurs when mouse is moving over the colors presented by the color picker")]
	public event ColorPreviewEventHandler ColorPreview
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			colorPreviewEventHandler_0 = (ColorPreviewEventHandler)Delegate.Combine(colorPreviewEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			colorPreviewEventHandler_0 = (ColorPreviewEventHandler)Delegate.Remove(colorPreviewEventHandler_0, value);
		}
	}

	public ColorPickerButton()
	{
		ColorPickerDropDown colorPickerDropDown = method_12();
		colorPickerDropDown.SelectedColorChanged += method_14;
		colorPickerDropDown.ColorPreview += method_13;
	}

	public void DisplayMoreColorsDialog()
	{
		method_12().DisplayMoreColorsDialog();
	}

	protected override ButtonItem CreateButtonItem()
	{
		return new ColorPickerDropDown();
	}

	private ColorPickerDropDown method_12()
	{
		return base.BaseItem_0 as ColorPickerDropDown;
	}

	private void method_13(object sender, ColorPreviewEventArgs e)
	{
		OnColorPreview(e);
	}

	protected virtual void OnColorPreview(ColorPreviewEventArgs e)
	{
		if (colorPreviewEventHandler_0 != null)
		{
			colorPreviewEventHandler_0(this, e);
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		OnSelectedColorChanged(e);
		ExecuteCommand();
	}

	protected virtual void OnSelectedColorChanged(EventArgs e)
	{
		if (eventHandler_6 != null)
		{
			eventHandler_6(this, e);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeSubItems()
	{
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeSelectedColorImageRectangle()
	{
		return method_12().ShouldSerializeSelectedColorImageRectangle();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetSelectedColorImageRectangle()
	{
		method_12().ResetSelectedColorImageRectangle();
	}

	public void InvokeColorPreview(ColorPreviewEventArgs e)
	{
		method_12().InvokeColorPreview(e);
	}

	public void UpdateSelectedColorImage()
	{
		method_12().UpdateSelectedColorImage();
	}
}
