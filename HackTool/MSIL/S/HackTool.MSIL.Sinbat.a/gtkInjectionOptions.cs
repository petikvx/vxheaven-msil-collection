using System;
using System.Reflection;
using System.Text.RegularExpressions;
using Absinthe.Core;
using Glade;
using Gtk;

public class gtkInjectionOptions
{
	private XML LocalGladeXml;

	[Widget]
	private Window WindowObject;

	[Widget]
	private Entry txtTolerance;

	[Widget]
	private Entry txtFilterDelimiter;

	[Widget]
	private Entry txtThrottle;

	[Widget]
	private HScale sldThrottleSlider;

	[Widget]
	private Dialog dlgError;

	[Widget]
	private Label lblErrorMsg;

	[Widget]
	private Button okbutton1;

	private DataStore _Storage;

	public gtkInjectionOptions(ref DataStore Storage)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LocalGladeXml = new XML((Assembly)null, "gtkabsinthe.glade", "InjectionOptions", (string)null);
		LocalGladeXml.Autoconnect((object)this);
		WindowObject = (Window)LocalGladeXml.GetWidget("InjectionOptions");
		_Storage = Storage;
		InitUI();
	}

	private void InitUI()
	{
		txtTolerance.set_Text((_Storage.get_FilterTolerance() * 100f).ToString());
		if (_Storage.get_FilterDelimiter().Equals(Environment.NewLine))
		{
			txtFilterDelimiter.set_Text(string.Empty);
		}
		else
		{
			txtFilterDelimiter.set_Text(_Storage.get_FilterDelimiter());
		}
		txtThrottle.set_Text(_Storage.get_ThrottleValue().ToString());
		((Range)sldThrottleSlider).set_Value((double)_Storage.get_ThrottleValue());
	}

	public void butCancel_Click(object sender, EventArgs e)
	{
		((Widget)WindowObject).Destroy();
	}

	public void butOK_Click(object sender, EventArgs e)
	{
		if (!Regex.IsMatch(txtTolerance.get_Text(), "^[+]?\\d+(\\.\\d+)?$"))
		{
			GenerateErrorDialog("You have entered an invalid tolerance.");
			return;
		}
		_Storage.set_FilterTolerance(float.Parse(txtTolerance.get_Text()) / 100f);
		_Storage.set_FilterDelimiter(txtFilterDelimiter.get_Text());
		int num = Convert.ToInt32(((Range)sldThrottleSlider).get_Value());
		num = ((num != 0) ? (num * -100) : int.Parse(txtThrottle.get_Text()));
		_Storage.set_ThrottleValue(num);
		((Widget)WindowObject).Destroy();
	}

	private void GenerateErrorDialog(string ErrorMessage)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		XML val = new XML((Assembly)null, "gtkabsinthe.glade", "dlgError", (string)null);
		dlgError = (Dialog)val.GetWidget("dlgError");
		lblErrorMsg = (Label)val.GetWidget("lblErrorMsg");
		lblErrorMsg.set_Text(ErrorMessage);
		okbutton1 = (Button)val.GetWidget("okbutton1");
		okbutton1.add_Clicked((EventHandler)ErrorOk_Click);
	}

	public void ErrorOk_Click(object sender, EventArgs e)
	{
		((Widget)dlgError).Destroy();
	}

	public void OntxtThrottle_Change(object sender, EventArgs e)
	{
		((Range)sldThrottleSlider).set_Value(1.0);
	}

	public void OnThrottleSlider_Change(object sender, EventArgs e)
	{
		double value = ((Range)sldThrottleSlider).get_Value();
		txtThrottle.set_Text("0");
		((Range)sldThrottleSlider).set_Value(value);
	}
}
