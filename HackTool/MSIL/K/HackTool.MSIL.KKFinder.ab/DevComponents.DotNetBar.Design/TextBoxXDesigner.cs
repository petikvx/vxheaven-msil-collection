using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Design.Behavior;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.Design;

public class TextBoxXDesigner : ControlDesigner
{
	private DesignerActionListCollection designerActionListCollection_0;

	public string Text
	{
		get
		{
			return ((ControlDesigner)this).get_Control().get_Text();
		}
		set
		{
			((ControlDesigner)this).get_Control().set_Text(value);
			((TextBoxBase)(TextBoxX)(object)((ControlDesigner)this).get_Control()).Select(0, 0);
		}
	}

	public char PasswordChar
	{
		get
		{
			Control control = ((ControlDesigner)this).get_Control();
			TextBox val = (TextBox)(object)((control is TextBox) ? control : null);
			if (val.get_UseSystemPasswordChar())
			{
				val.set_UseSystemPasswordChar(false);
				char passwordChar = val.get_PasswordChar();
				val.set_UseSystemPasswordChar(true);
				return passwordChar;
			}
			return val.get_PasswordChar();
		}
		set
		{
			Control control = ((ControlDesigner)this).get_Control();
			TextBox val = (TextBox)(object)((control is TextBox) ? control : null);
			val.set_PasswordChar(value);
		}
	}

	public override SelectionRules SelectionRules
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			SelectionRules selectionRules = ((ControlDesigner)this).get_SelectionRules();
			object component = ((ComponentDesigner)this).get_Component();
			selectionRules = (SelectionRules)(selectionRules | 0xF);
			PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(component)["Multiline"];
			if (propertyDescriptor != null)
			{
				object value = propertyDescriptor.GetValue(component);
				if (value is bool && !(bool)value)
				{
					PropertyDescriptor propertyDescriptor2 = TypeDescriptor.GetProperties(component)["AutoSize"];
					if (propertyDescriptor2 != null)
					{
						object value2 = propertyDescriptor2.GetValue(component);
						if (value2 is bool && (bool)value2)
						{
							selectionRules = (SelectionRules)(selectionRules & -4);
						}
					}
				}
			}
			return selectionRules;
		}
	}

	public override DesignerActionListCollection ActionLists
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			if (designerActionListCollection_0 == null)
			{
				designerActionListCollection_0 = new DesignerActionListCollection();
				object obj = ((object)this).GetType().Assembly.CreateInstance("System.Windows.Forms.Design.TextBoxActionList", ignoreCase: false, BindingFlags.NonPublic, null, new object[1] { this }, null, null);
				if (obj != null)
				{
					designerActionListCollection_0.Add((DesignerActionList)((obj is DesignerActionList) ? obj : null));
				}
			}
			return designerActionListCollection_0;
		}
	}

	public override IList SnapLines
	{
		get
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Invalid comparison between Unknown and I4
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Invalid comparison between Unknown and I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			ArrayList arrayList = ((ControlDesigner)this).get_SnapLines() as ArrayList;
			int num = smethod_0(((ControlDesigner)this).get_Control(), (ContentAlignment)1);
			BorderStyle val = (BorderStyle)2;
			PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(((ComponentDesigner)this).get_Component())["BorderStyle"];
			if (propertyDescriptor != null)
			{
				val = (BorderStyle)propertyDescriptor.GetValue(((ComponentDesigner)this).get_Component());
			}
			if ((int)val != 1 && (int)val != 0)
			{
				if ((int)val == 2)
				{
					num += 3;
				}
			}
			else
			{
				num += 2;
			}
			arrayList.Add((object?)new SnapLine((SnapLineType)6, num, (SnapLinePriority)2));
			return arrayList;
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ControlDesigner)this).InitializeNewComponent(defaultValues);
		method_0();
	}

	private void method_0()
	{
		PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(((ComponentDesigner)this).get_Component())["Text"];
		if (propertyDescriptor != null && (object)propertyDescriptor.PropertyType == typeof(string) && !propertyDescriptor.IsReadOnly && propertyDescriptor.IsBrowsable)
		{
			propertyDescriptor.SetValue(((ComponentDesigner)this).get_Component(), "");
		}
		TextBoxX textBoxX = ((ControlDesigner)this).get_Control() as TextBoxX;
		textBoxX.Border.Class = ElementStyleClassKeys.TextBoxBorderKey;
		textBoxX.method_5();
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ControlDesigner)this).PreFilterProperties(properties);
		string[] array = new string[1] { "PasswordChar" };
		Attribute[] attributes = new Attribute[0];
		for (int i = 0; i < array.Length; i++)
		{
			PropertyDescriptor propertyDescriptor = (PropertyDescriptor)properties[array[i]];
			if (propertyDescriptor != null)
			{
				properties[array[i]] = TypeDescriptor.CreateProperty(typeof(TextBoxXDesigner), propertyDescriptor, attributes);
			}
		}
		array = new string[1] { "Text" };
		attributes = new Attribute[0];
		for (int j = 0; j < array.Length; j++)
		{
			PropertyDescriptor propertyDescriptor2 = (PropertyDescriptor)properties[array[j]];
			if (propertyDescriptor2 != null)
			{
				properties[array[j]] = TypeDescriptor.CreateProperty(typeof(TextBoxXDesigner), propertyDescriptor2, attributes);
			}
		}
	}

	public void ResetText()
	{
		((ControlDesigner)this).get_Control().set_Text("");
	}

	public bool ShouldSerializeText()
	{
		return TypeDescriptor.GetProperties(typeof(TextBoxX))["Text"]!.ShouldSerializeValue(((ComponentDesigner)this).get_Component());
	}

	private static int smethod_0(Control control_0, ContentAlignment contentAlignment_0)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		Rectangle clientRectangle = control_0.get_ClientRectangle();
		int num = 0;
		int num2 = 0;
		Graphics val = control_0.CreateGraphics();
		try
		{
			IntPtr hdc = val.GetHdc();
			IntPtr hObject = control_0.get_Font().ToHfont();
			try
			{
				IntPtr hObject2 = Class51.SelectObject(hdc, hObject);
				Class51.TEXTMETRIC tEXTMETRIC = new Class51.TEXTMETRIC();
				Class51.GetTextMetrics(new HandleRef(control_0, hdc), tEXTMETRIC);
				num = tEXTMETRIC.tmAscent + 1;
				num2 = tEXTMETRIC.tmHeight;
				Class51.SelectObject(hdc, hObject2);
			}
			finally
			{
				Class51.DeleteObject(hObject);
				val.ReleaseHdc(hdc);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		if ((contentAlignment_0 & 7) != 0)
		{
			return clientRectangle.Top + num;
		}
		if ((contentAlignment_0 & 0x70) != 0)
		{
			return clientRectangle.Top + clientRectangle.Height / 2 - num2 / 2 + num;
		}
		return clientRectangle.Bottom - num2 + num;
	}
}
