using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;

namespace DevComponents.DotNetBar.Design;

public class TextBoxItemDesigner : SimpleBaseItemDesigner
{
	[Description("Indicates watermark text displayed inside of the control when Text is not set and control does not have input focus.")]
	[Localizable(true)]
	[DefaultValue("")]
	[Browsable(true)]
	[Category("Appearance")]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	public string WatermarkText
	{
		get
		{
			return (string)((ComponentDesigner)this).get_ShadowProperties().get_Item("WatermarkText");
		}
		set
		{
			((ComponentDesigner)this).get_ShadowProperties().set_Item("WatermarkText", (object)value);
		}
	}

	[Description("Indicates watermark hiding behaviour.")]
	[Category("Behavior")]
	[DefaultValue(eWatermarkBehavior.HideOnFocus)]
	public eWatermarkBehavior WatermarkBehavior
	{
		get
		{
			return (eWatermarkBehavior)((ComponentDesigner)this).get_ShadowProperties().get_Item("WatermarkBehavior");
		}
		set
		{
			((ComponentDesigner)this).get_ShadowProperties().set_Item("WatermarkBehavior", (object)value);
		}
	}

	[Description("Indicates watermark text color.")]
	[Category("Appearance")]
	[Browsable(true)]
	public Color WatermarkColor
	{
		get
		{
			return (Color)((ComponentDesigner)this).get_ShadowProperties().get_Item("WatermarkColor");
		}
		set
		{
			((ComponentDesigner)this).get_ShadowProperties().set_Item("WatermarkColor", (object)value);
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether watermark text is displayed when control is empty.")]
	public bool WatermarkEnabled
	{
		get
		{
			return (bool)((ComponentDesigner)this).get_ShadowProperties().get_Item("WatermarkEnabled");
		}
		set
		{
			((ComponentDesigner)this).get_ShadowProperties().set_Item("WatermarkEnabled", (object)value);
		}
	}

	[Description("Indicates watermark font.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(null)]
	public Font WatermarkFont
	{
		get
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			return (Font)((ComponentDesigner)this).get_ShadowProperties().get_Item("WatermarkFont");
		}
		set
		{
			((ComponentDesigner)this).get_ShadowProperties().set_Item("WatermarkFont", (object)value);
		}
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		base.PreFilterProperties(properties);
		properties["WatermarkText"] = TypeDescriptor.CreateProperty(typeof(TextBoxItemDesigner), (PropertyDescriptor)properties["WatermarkText"], (Attribute[])null);
		properties["WatermarkBehavior"] = TypeDescriptor.CreateProperty(typeof(TextBoxItemDesigner), (PropertyDescriptor)properties["WatermarkBehavior"], (Attribute[])null);
		properties["WatermarkColor"] = TypeDescriptor.CreateProperty(typeof(TextBoxItemDesigner), (PropertyDescriptor)properties["WatermarkColor"], (Attribute[])null);
		properties["WatermarkEnabled"] = TypeDescriptor.CreateProperty(typeof(TextBoxItemDesigner), (PropertyDescriptor)properties["WatermarkEnabled"], (Attribute[])null);
		properties["WatermarkFont"] = TypeDescriptor.CreateProperty(typeof(TextBoxItemDesigner), (PropertyDescriptor)properties["WatermarkFont"], (Attribute[])null);
	}
}
