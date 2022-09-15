using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.Design;

public class MaskedTextBoxAdvDesigner : ControlDesigner
{
	private DesignerActionListCollection designerActionListCollection_0;

	private DesignerVerbCollection designerVerbCollection_0;

	public override SelectionRules SelectionRules => (SelectionRules)(((ControlDesigner)this).get_SelectionRules() & -4);

	public char PasswordChar
	{
		get
		{
			MaskedTextBoxAdv maskedTextBoxAdv = ((ControlDesigner)this).get_Control() as MaskedTextBoxAdv;
			if (maskedTextBoxAdv.UseSystemPasswordChar)
			{
				maskedTextBoxAdv.UseSystemPasswordChar = false;
				char passwordChar = maskedTextBoxAdv.PasswordChar;
				maskedTextBoxAdv.UseSystemPasswordChar = true;
				return passwordChar;
			}
			return maskedTextBoxAdv.PasswordChar;
		}
		set
		{
			MaskedTextBoxAdv maskedTextBoxAdv = ((ControlDesigner)this).get_Control() as MaskedTextBoxAdv;
			maskedTextBoxAdv.PasswordChar = value;
		}
	}

	public string Text
	{
		get
		{
			MaskedTextBoxAdv maskedTextBoxAdv = ((ControlDesigner)this).get_Control() as MaskedTextBoxAdv;
			if (string.IsNullOrEmpty(maskedTextBoxAdv.Mask))
			{
				return ((Control)maskedTextBoxAdv).get_Text();
			}
			return maskedTextBoxAdv.MaskedTextProvider.ToString(includePrompt: false, includeLiterals: false);
		}
		set
		{
			MaskedTextBoxAdv maskedTextBoxAdv = ((ControlDesigner)this).get_Control() as MaskedTextBoxAdv;
			if (string.IsNullOrEmpty(maskedTextBoxAdv.Mask))
			{
				((Control)maskedTextBoxAdv).set_Text(value);
				return;
			}
			bool resetOnSpace = maskedTextBoxAdv.ResetOnSpace;
			bool resetOnPrompt = maskedTextBoxAdv.ResetOnPrompt;
			bool skipLiterals = maskedTextBoxAdv.SkipLiterals;
			maskedTextBoxAdv.ResetOnSpace = true;
			maskedTextBoxAdv.ResetOnPrompt = true;
			maskedTextBoxAdv.SkipLiterals = true;
			((Control)maskedTextBoxAdv).set_Text(value);
			maskedTextBoxAdv.ResetOnSpace = resetOnSpace;
			maskedTextBoxAdv.ResetOnPrompt = resetOnPrompt;
			maskedTextBoxAdv.SkipLiterals = skipLiterals;
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
				designerActionListCollection_0.Add((DesignerActionList)(object)new MaskedTextBoxAdvDesignerActionList(this));
			}
			return designerActionListCollection_0;
		}
	}

	public override DesignerVerbCollection Verbs
	{
		get
		{
			if (designerVerbCollection_0 == null)
			{
				designerVerbCollection_0 = new DesignerVerbCollection();
				designerVerbCollection_0.Add(new DesignerVerb("Set Mask...", method_0));
			}
			return designerVerbCollection_0;
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ControlDesigner)this).InitializeNewComponent(defaultValues);
		MaskedTextBoxAdv maskedTextBoxAdv = ((ControlDesigner)this).get_Control() as MaskedTextBoxAdv;
		maskedTextBoxAdv.BackgroundStyle.Class = ElementStyleClassKeys.TextBoxBorderKey;
		maskedTextBoxAdv.ButtonClear.Visible = true;
		((Control)maskedTextBoxAdv).set_Height(maskedTextBoxAdv.PreferredHeight);
		((Control)maskedTextBoxAdv).set_Text("");
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ControlDesigner)this).PreFilterProperties(properties);
		string[] array = new string[2] { "Text", "PasswordChar" };
		Attribute[] attributes = new Attribute[0];
		for (int i = 0; i < array.Length; i++)
		{
			PropertyDescriptor propertyDescriptor = (PropertyDescriptor)properties[array[i]];
			if (propertyDescriptor != null)
			{
				properties[array[i]] = TypeDescriptor.CreateProperty(typeof(MaskedTextBoxAdvDesigner), propertyDescriptor, attributes);
			}
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		new MaskedTextBoxAdvDesignerActionList(this).SetMask();
	}
}
