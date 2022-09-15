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

public class TextBoxDropDownDesigner : ControlDesigner
{
	private DesignerActionListCollection designerActionListCollection_0;

	public override SelectionRules SelectionRules => (SelectionRules)(((ControlDesigner)this).get_SelectionRules() & -4);

	public string Text
	{
		get
		{
			return ((ControlDesigner)this).get_Control().get_Text();
		}
		set
		{
			((ControlDesigner)this).get_Control().set_Text(value);
			((TextBoxDropDown)(object)((ControlDesigner)this).get_Control()).Select(0, 0);
		}
	}

	public char PasswordChar
	{
		get
		{
			TextBoxDropDown textBoxDropDown = ((ControlDesigner)this).get_Control() as TextBoxDropDown;
			if (textBoxDropDown.UseSystemPasswordChar)
			{
				textBoxDropDown.UseSystemPasswordChar = false;
				char passwordChar = textBoxDropDown.PasswordChar;
				textBoxDropDown.UseSystemPasswordChar = true;
				return passwordChar;
			}
			return textBoxDropDown.PasswordChar;
		}
		set
		{
			TextBoxDropDown textBoxDropDown = ((ControlDesigner)this).get_Control() as TextBoxDropDown;
			textBoxDropDown.PasswordChar = value;
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
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			ArrayList arrayList = ((ControlDesigner)this).get_SnapLines() as ArrayList;
			int num = smethod_0(((ControlDesigner)this).get_Control(), (ContentAlignment)1);
			num += 2;
			arrayList.Add((object?)new SnapLine((SnapLineType)6, num, (SnapLinePriority)2));
			return arrayList;
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ControlDesigner)this).InitializeNewComponent(defaultValues);
		TextBoxDropDown textBoxDropDown = ((ControlDesigner)this).get_Control() as TextBoxDropDown;
		textBoxDropDown.BackgroundStyle.Class = ElementStyleClassKeys.TextBoxBorderKey;
		textBoxDropDown.ButtonDropDown.Visible = true;
		((Control)textBoxDropDown).set_Height(textBoxDropDown.PreferredHeight);
		((Control)textBoxDropDown).set_Text("");
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
				properties[array[i]] = TypeDescriptor.CreateProperty(typeof(TextBoxDropDownDesigner), propertyDescriptor, attributes);
			}
		}
		array = new string[1] { "Text" };
		attributes = new Attribute[0];
		for (int j = 0; j < array.Length; j++)
		{
			PropertyDescriptor propertyDescriptor2 = (PropertyDescriptor)properties[array[j]];
			if (propertyDescriptor2 != null)
			{
				properties[array[j]] = TypeDescriptor.CreateProperty(typeof(TextBoxDropDownDesigner), propertyDescriptor2, attributes);
			}
		}
	}

	public void ResetText()
	{
		((ControlDesigner)this).get_Control().set_Text("");
	}

	public bool ShouldSerializeText()
	{
		return TypeDescriptor.GetProperties(typeof(TextBoxDropDownDesigner))["Text"]!.ShouldSerializeValue(((ComponentDesigner)this).get_Component());
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
