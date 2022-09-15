using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class MessageBoxDialog : Office2007Form
{
	private enum Enum20
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10
	}

	private ButtonX Button1;

	private ButtonX Button2;

	private ButtonX Button3;

	private PictureBox PictureBox1;

	private PanelEx TextPanel;

	private eDotNetBarStyle eDotNetBarStyle_0 = eDotNetBarStyle.Office2007;

	private bool bool_10 = true;

	private bool bool_11 = true;

	private bool bool_12 = true;

	private MessageBoxButtons messageBoxButtons_0;

	private IContainer icontainer_1;

	public MessageBoxDialog()
	{
		InitializeComponent();
		TextPanel.method_0();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_1 != null)
		{
			icontainer_1.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		Button1 = new ButtonX();
		Button2 = new ButtonX();
		Button3 = new ButtonX();
		PictureBox1 = new PictureBox();
		TextPanel = new PanelEx();
		((Control)this).SuspendLayout();
		((Control)Button1).set_AccessibleRole((AccessibleRole)43);
		Button1.ColorTable = eButtonColor.OrangeWithBackground;
		((Control)Button1).set_Location(new Point(26, 85));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(77, 24));
		((Control)Button1).set_TabIndex(0);
		((Control)Button1).set_Text("&OK");
		((Control)Button1).add_Click((EventHandler)Button1_Click);
		((Control)Button2).set_AccessibleRole((AccessibleRole)43);
		Button2.ColorTable = eButtonColor.OrangeWithBackground;
		((Control)Button2).set_Location(new Point(109, 85));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(77, 24));
		((Control)Button2).set_TabIndex(1);
		((Control)Button2).set_Text("&Cancel");
		((Control)Button2).add_Click((EventHandler)Button2_Click);
		((Control)Button3).set_AccessibleRole((AccessibleRole)43);
		Button3.ColorTable = eButtonColor.OrangeWithBackground;
		((Control)Button3).set_Location(new Point(192, 85));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(77, 24));
		((Control)Button3).set_TabIndex(2);
		((Control)Button3).set_Text("&Ignore");
		((Control)Button3).add_Click((EventHandler)Button3_Click);
		((Control)PictureBox1).set_BackColor(Color.Transparent);
		((Control)PictureBox1).set_Location(new Point(10, 10));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(32, 32));
		PictureBox1.set_TabIndex(3);
		PictureBox1.set_TabStop(false);
		TextPanel.AntiAlias = false;
		TextPanel.CanvasColor = SystemColors.Control;
		((Control)TextPanel).set_Location(new Point(53, 10));
		((Control)TextPanel).set_Name("TextPanel");
		((Control)TextPanel).set_Size(new Size(225, 53));
		TextPanel.Style.Border = eBorderType.SingleLine;
		TextPanel.Style.BorderWidth = 0;
		TextPanel.Style.ForeColor.ColorSchemePart = eColorSchemePart.ItemText;
		TextPanel.Style.GradientAngle = 90;
		TextPanel.Style.LineAlignment = (StringAlignment)0;
		((Control)TextPanel).set_TabIndex(4);
		((Panel)TextPanel).set_TabStop(false);
		TextPanel.Style.WordWrap = true;
		TextPanel.MarkupLinkClick += TextPanel_MarkupLinkClick;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(290, 121));
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).get_Controls().Add((Control)(object)TextPanel);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MessageBoxDialog");
		((Control)this).ResumeLayout(false);
	}

	private void TextPanel_MarkupLinkClick(object sender, MarkupLinkClickEventArgs e)
	{
		MessageBoxEx.smethod_0(sender, e);
	}

	public DialogResult method_29(IWin32Window iwin32Window_0, string string_1, string string_2, MessageBoxButtons messageBoxButtons_1, MessageBoxIcon messageBoxIcon_0, MessageBoxDefaultButton messageBoxDefaultButton_0, bool bool_13)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Invalid comparison between Unknown and I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Invalid comparison between Unknown and I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Invalid comparison between Unknown and I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Invalid comparison between Unknown and I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Invalid comparison between Unknown and I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Invalid comparison between Unknown and I4
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Invalid comparison between Unknown and I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		messageBoxButtons_0 = messageBoxButtons_1;
		((Control)this).set_Text(string_2);
		((Control)TextPanel).set_Text(string_1);
		if ((int)messageBoxIcon_0 != 0)
		{
			PictureBox1.set_Image(method_32(messageBoxIcon_0));
		}
		else
		{
			PictureBox1.set_Image((Image)null);
			((Control)PictureBox1).set_Visible(false);
		}
		if (eDotNetBarStyle_0 != eDotNetBarStyle.Office2007)
		{
			base.EnableCustomStyle = false;
		}
		if ((int)messageBoxButtons_1 != 1 && (int)messageBoxButtons_1 != 5 && (int)messageBoxButtons_1 != 4)
		{
			if ((int)messageBoxButtons_1 == 0)
			{
				((Control)Button2).set_Visible(false);
				((Control)Button3).set_Visible(false);
				bool_11 = false;
				bool_12 = false;
			}
		}
		else
		{
			((Control)Button3).set_Visible(false);
			bool_12 = false;
		}
		if ((int)messageBoxButtons_1 == 0)
		{
			((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
			((Form)this).set_CancelButton((IButtonControl)(object)Button1);
		}
		else if ((int)messageBoxButtons_1 != 1 && (int)messageBoxButtons_1 != 5 && (int)messageBoxButtons_1 != 4)
		{
			if ((int)messageBoxButtons_1 == 3)
			{
				((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
				((Form)this).set_CancelButton((IButtonControl)(object)Button3);
			}
		}
		else
		{
			((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
			((Form)this).set_CancelButton((IButtonControl)(object)Button2);
		}
		method_31(messageBoxButtons_1);
		if ((int)messageBoxDefaultButton_0 == 0 && bool_10)
		{
			((Control)Button1).Select();
			((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
		}
		else if ((int)messageBoxDefaultButton_0 == 256 && bool_11)
		{
			((Form)this).set_AcceptButton((IButtonControl)(object)Button2);
			((Control)Button2).Select();
		}
		else if ((int)messageBoxDefaultButton_0 == 512 && bool_12)
		{
			((Form)this).set_AcceptButton((IButtonControl)(object)Button3);
			((Control)Button3).Select();
		}
		if ((int)messageBoxButtons_1 == 2 || (int)messageBoxButtons_1 == 4)
		{
			base.CloseEnabled = false;
		}
		method_33();
		method_30();
		if ((int)messageBoxIcon_0 == 32)
		{
			SystemSounds.get_Question().Play();
		}
		else if ((int)messageBoxIcon_0 == 64)
		{
			SystemSounds.get_Asterisk().Play();
		}
		else
		{
			SystemSounds.get_Exclamation().Play();
		}
		if (((Form)this).get_TopMost() != bool_13)
		{
			((Form)this).set_TopMost(bool_13);
		}
		return ((Form)this).ShowDialog(iwin32Window_0);
	}

	private void method_30()
	{
		if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007 && GlobalManager.Renderer is Office2007Renderer)
		{
			if (Class51.Boolean_0)
			{
				TextPanel.Style.ForeColor.ColorSchemePart = eColorSchemePart.Custom;
				TextPanel.Style.ForeColor.Color = SystemColors.ControlText;
			}
			else
			{
				Office2007ColorTable colorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
				TextPanel.Style.ForeColor.ColorSchemePart = eColorSchemePart.Custom;
				TextPanel.Style.ForeColor.Color = colorTable.Form.TextColor;
			}
		}
	}

	private void method_31(MessageBoxButtons messageBoxButtons_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		if ((int)messageBoxButtons_1 == 2)
		{
			((Control)Button1).set_Text(smethod_0(Enum20.const_2));
			((Control)Button2).set_Text(smethod_0(Enum20.const_3));
			((Control)Button3).set_Text(smethod_0(Enum20.const_4));
		}
		else if ((int)messageBoxButtons_1 == 0)
		{
			((Control)Button1).set_Text(smethod_0(Enum20.const_0));
		}
		else if ((int)messageBoxButtons_1 == 1)
		{
			((Control)Button1).set_Text(smethod_0(Enum20.const_0));
			((Control)Button2).set_Text(smethod_0(Enum20.const_1));
		}
		else if ((int)messageBoxButtons_1 == 5)
		{
			((Control)Button1).set_Text(smethod_0(Enum20.const_3));
			((Control)Button2).set_Text(smethod_0(Enum20.const_1));
		}
		else if ((int)messageBoxButtons_1 == 4)
		{
			((Control)Button1).set_Text(smethod_0(Enum20.const_5));
			((Control)Button2).set_Text(smethod_0(Enum20.const_6));
		}
		else if ((int)messageBoxButtons_1 == 3)
		{
			((Control)Button1).set_Text(smethod_0(Enum20.const_5));
			((Control)Button2).set_Text(smethod_0(Enum20.const_6));
			((Control)Button3).set_Text(smethod_0(Enum20.const_1));
		}
	}

	private Image method_32(MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		Icon val = null;
		if ((int)messageBoxIcon_0 == 64)
		{
			val = SystemIcons.get_Asterisk();
		}
		else if ((int)messageBoxIcon_0 != 16 && (int)messageBoxIcon_0 != 16)
		{
			if ((int)messageBoxIcon_0 == 48)
			{
				val = SystemIcons.get_Exclamation();
			}
			else if ((int)messageBoxIcon_0 == 16)
			{
				val = SystemIcons.get_Hand();
			}
			else if ((int)messageBoxIcon_0 == 64)
			{
				val = SystemIcons.get_Information();
			}
			else if ((int)messageBoxIcon_0 == 32)
			{
				val = SystemIcons.get_Question();
			}
			else if ((int)messageBoxIcon_0 == 48)
			{
				val = SystemIcons.get_Warning();
			}
		}
		else
		{
			val = SystemIcons.get_Error();
		}
		Bitmap val2 = new Bitmap(val.get_Width(), val.get_Height());
		val2.MakeTransparent();
		Graphics val3 = Graphics.FromImage((Image)(object)val2);
		try
		{
			if (Environment.Version.Build <= 3705 && Environment.Version.Revision == 288 && Environment.Version.Major == 1 && Environment.Version.Minor == 0)
			{
				IntPtr hdc = val3.GetHdc();
				try
				{
					Class92.DrawIconEx(hdc, 0, 0, val.get_Handle(), val.get_Width(), val.get_Height(), 0, IntPtr.Zero, 3);
					return (Image)(object)val2;
				}
				finally
				{
					val3.ReleaseHdc(hdc);
				}
			}
			if (val.get_Handle() != IntPtr.Zero)
			{
				try
				{
					val3.DrawIcon(val, 0, 0);
					return (Image)(object)val2;
				}
				catch
				{
					return (Image)(object)val2;
				}
			}
			return (Image)(object)val2;
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
	}

	private void method_33()
	{
		Size size = Size.Empty;
		int num = 6;
		int num2 = 40;
		int num3 = 10;
		int num4 = 110;
		if (PictureBox1.get_Image() != null)
		{
			((Control)TextPanel).set_Left(((Control)PictureBox1).get_Bounds().Right + 16);
		}
		else
		{
			((Control)TextPanel).set_Left(((Control)PictureBox1).get_Left());
		}
		((Control)TextPanel).set_Size(TextPanel.GetAutoSize());
		Rectangle workingArea = Screen.get_PrimaryScreen().get_WorkingArea();
		if (((Control)TextPanel).get_Size().Width > workingArea.Width / 3)
		{
			((Control)TextPanel).set_Size(TextPanel.GetAutoSize(workingArea.Width / 3));
		}
		else if (((Control)TextPanel).get_Size().Width < num4)
		{
			((Control)TextPanel).set_Width(num4);
		}
		if (((Control)this).get_Text().Length > 0)
		{
			Font font = ((Control)this).get_Font();
			Graphics val = Class109.smethod_68((Control)(object)this);
			try
			{
				size = Class55.smethod_3(val, ((Control)this).get_Text(), font);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			size.Width += 2;
			size.Height += 2;
			if (size.Width > ((Control)TextPanel).get_Width())
			{
				((Control)TextPanel).set_Width(size.Width);
			}
		}
		int num5 = Math.Max(((Control)TextPanel).get_Bounds().Bottom, ((Control)PictureBox1).get_Bounds().Bottom);
		num5 += 16;
		((Control)Button1).set_Top(num5);
		((Control)Button2).set_Top(num5);
		((Control)Button3).set_Top(num5);
		int num6 = ((Control)Button1).get_Width() + (bool_11 ? (((Control)Button2).get_Width() + num) : 0) + (bool_12 ? (((Control)Button3).get_Width() + num) : 0);
		int num7 = num6 + num2 * 2;
		if (num6 < ((Control)TextPanel).get_Bounds().Right + num3)
		{
			num7 = ((Control)TextPanel).get_Bounds().Right + num3;
		}
		else
		{
			PanelEx textPanel = TextPanel;
			((Control)textPanel).set_Width(((Control)textPanel).get_Width() + (num7 - ((Control)TextPanel).get_Bounds().Right - num3));
		}
		int num8 = (num7 - num6) / 2;
		((Control)Button1).set_Left(num8);
		num8 += ((Control)Button1).get_Width() + num;
		if (bool_11)
		{
			((Control)Button2).set_Left(num8);
			num8 += ((Control)Button2).get_Width() + num;
		}
		if (bool_12)
		{
			((Control)Button3).set_Left(num8);
			num8 += ((Control)Button3).get_Width() + num;
		}
		size = new Size(((Control)TextPanel).get_Bounds().Right + num3 + SystemInformation.get_FixedFrameBorderSize().Width * 2, ((Control)Button1).get_Bounds().Bottom + num3 + SystemInformation.get_FixedFrameBorderSize().Height * 2 + SystemInformation.get_CaptionHeight());
		((Form)this).set_Size(size);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		DialogResult dialogResult = (DialogResult)1;
		if ((int)messageBoxButtons_0 != 0 && (int)messageBoxButtons_0 != 1)
		{
			if ((int)messageBoxButtons_0 != 4 && (int)messageBoxButtons_0 != 3)
			{
				if ((int)messageBoxButtons_0 == 2)
				{
					dialogResult = (DialogResult)3;
				}
				else if ((int)messageBoxButtons_0 == 5)
				{
					dialogResult = (DialogResult)4;
				}
			}
			else
			{
				dialogResult = (DialogResult)6;
			}
		}
		else
		{
			dialogResult = (DialogResult)1;
		}
		((Form)this).set_DialogResult(dialogResult);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		DialogResult dialogResult = (DialogResult)2;
		if ((int)messageBoxButtons_0 == 1)
		{
			dialogResult = (DialogResult)2;
		}
		else if ((int)messageBoxButtons_0 != 4 && (int)messageBoxButtons_0 != 3)
		{
			if ((int)messageBoxButtons_0 == 2)
			{
				dialogResult = (DialogResult)4;
			}
			else if ((int)messageBoxButtons_0 == 5)
			{
				dialogResult = (DialogResult)2;
			}
		}
		else
		{
			dialogResult = (DialogResult)7;
		}
		((Form)this).set_DialogResult(dialogResult);
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		DialogResult dialogResult = (DialogResult)2;
		if ((int)messageBoxButtons_0 == 2)
		{
			dialogResult = (DialogResult)5;
		}
		else if ((int)messageBoxButtons_0 == 3)
		{
			dialogResult = (DialogResult)2;
		}
		((Form)this).set_DialogResult(dialogResult);
	}

	[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern string MB_GetString(int i);

	private static string smethod_0(Enum20 enum20_0)
	{
		string text = "";
		if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToLower() != "en" && MessageBoxEx.UseSystemLocalizedString)
		{
			try
			{
				text = MB_GetString((int)enum20_0);
			}
			catch
			{
				text = "";
			}
		}
		if (text == "")
		{
			string text2 = "";
			switch (enum20_0)
			{
			case Enum20.const_2:
				text = "&Abort";
				text2 = LocalizationKeys.MessageBoxAbortButton;
				break;
			case Enum20.const_1:
				text = "&Cancel";
				text2 = LocalizationKeys.MessageBoxCancelButton;
				break;
			case Enum20.const_7:
				text = "C&lose";
				text2 = LocalizationKeys.MessageBoxCloseButton;
				break;
			case Enum20.const_10:
				text = "Co&ntinue";
				text2 = LocalizationKeys.MessageBoxContinueButton;
				break;
			case Enum20.const_8:
				text = "&Help";
				text2 = LocalizationKeys.MessageBoxHelpButton;
				break;
			case Enum20.const_4:
				text = "&Ignore";
				text2 = LocalizationKeys.MessageBoxIgnoreButton;
				break;
			case Enum20.const_6:
				text = "&No";
				text2 = LocalizationKeys.MessageBoxNoButton;
				break;
			case Enum20.const_0:
				text = "&OK";
				text2 = LocalizationKeys.MessageBoxOkButton;
				break;
			case Enum20.const_3:
				text = "&Retry";
				text2 = LocalizationKeys.MessageBoxRetryButton;
				break;
			case Enum20.const_9:
				text = "&Try Again";
				text2 = LocalizationKeys.MessageBoxTryAgainButton;
				break;
			case Enum20.const_5:
				text = "&Yes";
				text2 = LocalizationKeys.MessageBoxYesButton;
				break;
			}
			if (text2 != null)
			{
				text = Class264.smethod_0(text2, text);
			}
		}
		return text;
	}
}
