using System;
using System.Collections;
using System.Collections.Specialized;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using Absinthe;
using Absinthe.Core;
using Gdk;
using Glade;
using Gtk;

public class MainWin
{
	private delegate void ThreadedSub();

	private enum GuiActions : byte
	{
		StatusMessage = 1,
		ProgressIncrease,
		ProgressClear,
		ControlEnableSwitch,
		ControlVisibleSwitch
	}

	private enum FileAction : byte
	{
		SaveAs = 1,
		Open,
		Pulldata
	}

	private Hashtable InjectionFields = new Hashtable();

	private DataStore _SaveInfo;

	private LocalSettings _AppSettings = new LocalSettings();

	private ThreadNotify _GuiAction = null;

	private Queue _ActionQueue;

	private string[] _PluginEntries;

	[Widget]
	private Window Absinthe;

	private XML MainGladeXml;

	[Widget]
	private Button butScan;

	[Widget]
	private Statusbar myStatusBar;

	[Widget]
	private Dialog dlgError;

	[Widget]
	private Window AboutForm;

	[Widget]
	private Image AboutImage;

	[Widget]
	private Button butAboutOk;

	[Widget]
	private Label lblErrorMsg;

	[Widget]
	private Button okbutton1;

	[Widget]
	private Entry txtTargetURL;

	[Widget]
	private RadioButton optBlindInjection;

	[Widget]
	private RadioButton optErrorBasedInjection;

	[Widget]
	private Combo cboPluginList;

	[Widget]
	private RadioButton optConnectGet;

	[Widget]
	private RadioButton optConnectPost;

	[Widget]
	private CheckButton chkUseSSL;

	[Widget]
	private CheckButton chkTerminateQuery;

	[Widget]
	private Button butConfigProxy;

	[Widget]
	private CheckButton chkAppendExtraQuery;

	[Widget]
	private Label lblAppendExtraQuery;

	[Widget]
	private Entry txtAppendExtraQuery;

	[Widget]
	private Entry txtParamName;

	[Widget]
	private Entry txtParamValue;

	[Widget]
	private CheckButton chkInjectable;

	[Widget]
	private CheckButton chkTreatAsString;

	[Widget]
	private Button butAddParam;

	[Widget]
	private Button butAddHeader;

	[Widget]
	private Notebook tabParams;

	[Widget]
	private TreeView lstParams;

	[Widget]
	private Button butEditParam;

	[Widget]
	private Button butDeleteParam;

	[Widget]
	private TreeView lstCookies;

	[Widget]
	private Button butGetUsername;

	[Widget]
	private Button butLoadFieldInfo;

	[Widget]
	private Button butLoadTableInfo;

	[Widget]
	private TreeView lstSchema;

	[Widget]
	private Window ProxyConfig;

	[Widget]
	private CheckButton chkUseProxy;

	[Widget]
	private Entry txtProxyAddress;

	[Widget]
	private Entry txtProxyPort;

	[Widget]
	private Button butSaveProxySettings;

	[Widget]
	private Button butCancelProxySettings;

	[Widget]
	private TreeView lstProxyList;

	[Widget]
	private Button butAddProxy;

	[Widget]
	private Button butRemoveProxy;

	[Widget]
	private FileSelection FileSelectForm;

	[Widget]
	private Button butFileSelectCancel;

	[Widget]
	private Button butFileSelectOk;

	[Widget]
	private TreeView lstAvailFields;

	[Widget]
	private TreeView lstSelectedFields;

	[Widget]
	private Entry txtPullDataXml;

	public MainWin()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		Application.Init();
		MainGladeXml = new XML((Assembly)null, "gtkabsinthe.glade", "Absinthe", (string)null);
		MainGladeXml.Autoconnect((object)this);
		Absinthe = (Window)MainGladeXml.GetWidget("Absinthe");
		_SaveInfo = new DataStore(new OutputStatusDelegate(SafeOutput));
		InitUI();
		Application.Run();
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

	private void InitUI()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		((Widget)chkUseSSL).set_Sensitive(false);
		ListStore model = new ListStore(new Type[4]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(bool)
		});
		lstParams.set_Model((TreeModel)(object)model);
		lstParams.set_HeadersVisible(true);
		if (lstParams.get_Columns().Length == 0)
		{
			lstParams.AppendColumn("Name", (CellRenderer)new CellRendererText(), new object[2] { "text", 0 });
			lstParams.AppendColumn("Default", (CellRenderer)new CellRendererText(), new object[2] { "text", 1 });
			lstParams.AppendColumn("Injectable", (CellRenderer)new CellRendererToggle(), new object[2] { "active", 2 });
			lstParams.AppendColumn("String", (CellRenderer)new CellRendererToggle(), new object[2] { "active", 3 });
		}
		ListStore model2 = new ListStore(new Type[2]
		{
			typeof(string),
			typeof(string)
		});
		lstCookies.set_Model((TreeModel)(object)model2);
		lstCookies.set_HeadersVisible(true);
		if (lstCookies.get_Columns().Length == 0)
		{
			lstCookies.AppendColumn("Name", (CellRenderer)new CellRendererText(), new object[2] { "text", 0 });
			lstCookies.AppendColumn("Value", (CellRenderer)new CellRendererText(), new object[2] { "text", 1 });
		}
		_GuiAction = new ThreadNotify(new ReadyEvent(TakeGuiAction));
		_ActionQueue = new Queue();
		InitSchemaTreeView();
		if (lstAvailFields.get_Columns().Length == 0)
		{
			lstAvailFields.AppendColumn("Table", (CellRenderer)new CellRendererText(), new object[2] { "text", 0 });
			lstAvailFields.AppendColumn("Field", (CellRenderer)new CellRendererText(), new object[2] { "text", 1 });
		}
		ListStore model3 = new ListStore(new Type[3]
		{
			typeof(string),
			typeof(string),
			typeof(int)
		});
		lstSelectedFields.set_Model((TreeModel)(object)model3);
		if (lstSelectedFields.get_Columns().Length == 0)
		{
			lstSelectedFields.AppendColumn("Table", (CellRenderer)new CellRendererText(), new object[2] { "text", 0 });
			lstSelectedFields.AppendColumn("Field", (CellRenderer)new CellRendererText(), new object[2] { "text", 1 });
		}
		LoadPluginList();
		((Widget)chkTreatAsString).set_Sensitive(false);
	}

	private void LoadPluginList()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		ArrayList pluginList = _SaveInfo.get_PluginList();
		ArrayList arrayList = new ArrayList();
		foreach (PluginTemplate item in pluginList)
		{
			PluginTemplate val = item;
			if (!arrayList.Contains(val.get_PluginDisplayTargetName()))
			{
				arrayList.Add(val.get_PluginDisplayTargetName());
				continue;
			}
			string pluginDisplayTargetName = val.get_PluginDisplayTargetName();
			string text = "";
			int num = 0;
			while (arrayList.Contains(pluginDisplayTargetName + text))
			{
				num++;
				text = " {" + num + "}";
			}
			arrayList.Add(pluginDisplayTargetName + text);
		}
		_PluginEntries = (string[])arrayList.ToArray(typeof(string));
		cboPluginList.set_PopdownStrings(_PluginEntries);
	}

	private void InitSchemaTreeView()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		TreeStore val = new TreeStore(new Type[2]
		{
			typeof(string),
			typeof(string)
		});
		TreeIter val2 = val.AppendValues(new object[2] { "Database", "" });
		val.AppendValues(val2, new object[2] { "Username", "??? UNKNOWN ???" });
		val.AppendValues(val2, new object[2] { "Tables", "??? UNKNOWN ???" });
		lstSchema.set_Model((TreeModel)(object)val);
		lstSchema.set_HeadersVisible(true);
		if (lstSchema.get_Columns().Length == 0)
		{
			lstSchema.AppendColumn("Name", (CellRenderer)new CellRendererText(), new object[2] { "text", 0 });
			lstSchema.AppendColumn("Value", (CellRenderer)new CellRendererText(), new object[2] { "text", 1 });
		}
	}

	private void LoadFieldDataFromTableName(string TableName, TreeIter TableIter, bool Disconnected)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		TreeStore val = (TreeStore)lstSchema.get_Model();
		TreeIter fieldIter = default(TreeIter);
		val.IterNthChild(ref fieldIter, TableIter, 2);
		for (int i = 0; i < _SaveInfo.get_TableList().Length; i++)
		{
			if (((Table)(ref _SaveInfo.get_TableList()[i])).get_Name().Equals(TableName))
			{
				val.Remove(ref fieldIter);
				fieldIter = val.AppendValues(TableIter, new object[2] { "Fields", "??? UNKNOWN ???" });
				PopulateFieldView(i, fieldIter, Disconnected);
			}
		}
	}

	private void PopulateFieldView(int TableIndex, TreeIter FieldIter, bool Disconnected)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (((Table)(ref _SaveInfo.get_TableList()[TableIndex])).get_FieldCount() == 0)
		{
			if (Disconnected)
			{
				return;
			}
			_SaveInfo.get_TargetAttackVector().PopulateTableStructure(ref _SaveInfo.get_TableList()[TableIndex]);
		}
		Field[] fieldList = ((Table)(ref _SaveInfo.get_TableList()[TableIndex])).get_FieldList();
		((Table)(ref _SaveInfo.get_TableList()[TableIndex])).get_Name();
		TreeStore val = (TreeStore)lstSchema.get_Model();
		val.SetValue(FieldIter, 1, ((Table)(ref _SaveInfo.get_TableList()[TableIndex])).get_FieldCount().ToString());
		for (int i = 0; i < ((Table)(ref _SaveInfo.get_TableList()[TableIndex])).get_FieldCount(); i++)
		{
			string fieldName = ((Field)(ref fieldList[i])).get_FieldName();
			val.AppendValues(FieldIter, new object[2]
			{
				fieldName,
				((Field)(ref fieldList[i])).get_DataType().ToString()
			});
		}
		ReloadAvailableFields();
	}

	private void ReloadAvailableFields()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		ListStore val = new ListStore(new Type[3]
		{
			typeof(string),
			typeof(string),
			typeof(int)
		});
		ListStore val2 = (ListStore)lstSelectedFields.get_Model();
		Hashtable hashtable = new Hashtable();
		TreeIter val3 = default(TreeIter);
		if (val2.GetIterFirst(ref val3))
		{
			string key = (string)val2.GetValue(val3, 0) + "." + (string)val2.GetValue(val3, 1);
			hashtable.Add(key, 0);
			while (val2.IterNext(ref val3))
			{
				key = (string)val2.GetValue(val3, 0) + "." + (string)val2.GetValue(val3, 1);
				hashtable.Add(key, 0);
			}
		}
		for (int i = 0; i < _SaveInfo.get_TableList().Length; i++)
		{
			if (((Table)(ref _SaveInfo.get_TableList()[i])).get_FieldCount() <= 0)
			{
				continue;
			}
			Field[] fieldList = ((Table)(ref _SaveInfo.get_TableList()[i])).get_FieldList();
			for (int j = 0; j < ((Table)(ref _SaveInfo.get_TableList()[i])).get_FieldCount(); j++)
			{
				string fieldName = ((Field)(ref fieldList[j])).get_FieldName();
				if (!hashtable.ContainsKey(((Table)(ref _SaveInfo.get_TableList()[i])).get_Name() + "." + fieldName))
				{
					val.AppendValues(new object[3]
					{
						((Table)(ref _SaveInfo.get_TableList()[i])).get_Name(),
						fieldName,
						j
					});
				}
			}
		}
		lstAvailFields.set_Model((TreeModel)(object)val);
	}

	private void RetrieveTableInfoFromDatabase()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		try
		{
			SafeChangeSensitivity((Widget)(object)butLoadTableInfo, Sensitive: false);
			SafeStatusBarWrite("Gathering Table Information");
			if (_SaveInfo.get_TargetAttackVector() != null)
			{
				_SaveInfo.set_TableList(_SaveInfo.get_TargetAttackVector().GetTableList());
				ThreadNotify val = new ThreadNotify(new ReadyEvent(AdjustTableInfoGuiInThread));
				val.WakeupMain();
			}
			SafeStatusBarWrite("Finished Gathering Table Information");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
		finally
		{
			SafeChangeSensitivity((Widget)(object)butLoadTableInfo, Sensitive: true);
		}
	}

	private void AdjustTableInfoGuiInThread()
	{
		((Widget)butLoadFieldInfo).set_Visible(true);
		LoadTableInfoList();
	}

	private void LoadTableInfoList()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		if (_SaveInfo.get_TableList() != null)
		{
			TreeStore val = (TreeStore)lstSchema.get_Model();
			TreeIter val2 = default(TreeIter);
			val.GetIterFirst(ref val2);
			TreeIter val3 = default(TreeIter);
			val.IterChildren(ref val3, val2);
			val.IterNext(ref val3);
			val.SetValue(val3, 1, _SaveInfo.get_TableList().Length + " Tables");
			for (int i = 0; i < _SaveInfo.get_TableList().Length; i++)
			{
				TreeIter val4 = val.AppendValues(val3, new object[2]
				{
					((Table)(ref _SaveInfo.get_TableList()[i])).get_Name(),
					string.Empty
				});
				val.AppendValues(val4, new object[2]
				{
					"ID",
					((Table)(ref _SaveInfo.get_TableList()[i])).get_ObjectID().ToString()
				});
				val.AppendValues(val4, new object[2]
				{
					"Record Count",
					((Table)(ref _SaveInfo.get_TableList()[i])).get_RecordCount().ToString()
				});
				val.AppendValues(val4, new object[2] { "Fields", "??? UNKNOWN ???" });
			}
		}
	}

	private void RetrieveUsernameFromDatabase()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		try
		{
			SafeChangeSensitivity((Widget)(object)butGetUsername, Sensitive: false);
			SafeStatusBarWrite("Retrieving username");
			if (_SaveInfo.get_TargetAttackVector() != null)
			{
				SafeOutput("mrh");
				if (_SaveInfo.get_TargetAttackVector() == null)
				{
					SafeOutput("nooooo");
				}
				_SaveInfo.set_Username(_SaveInfo.get_TargetAttackVector().GetDatabaseUsername());
				SafeOutput("hrm");
				ThreadNotify val = new ThreadNotify(new ReadyEvent(AdjustDbLoginText));
				val.WakeupMain();
			}
			else
			{
				SafeOutput("The attack vector is null jerkface");
			}
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			SafeChangeSensitivity((Widget)(object)butGetUsername, Sensitive: true);
			SafeStatusBarWrite("Username retrieved");
		}
	}

	private void AdjustDbLoginText()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		TreeStore val = (TreeStore)lstSchema.get_Model();
		TreeIter val2 = default(TreeIter);
		val.GetIterFirst(ref val2);
		TreeIter val3 = default(TreeIter);
		val.IterChildren(ref val3, val2);
		val.SetValue(val3, 1, _SaveInfo.get_Username());
	}

	public void OnAbsintheDelete(object sender, EventArgs e)
	{
		Application.Quit();
	}

	public void ErrorOk_Click(object sender, EventArgs e)
	{
		((Widget)dlgError).Destroy();
	}

	private string ConnectMethod()
	{
		if (((ToggleButton)optConnectPost).get_Active())
		{
			return "Post";
		}
		if (((ToggleButton)optConnectGet).get_Active())
		{
			return "Get";
		}
		return "";
	}

	private void TakeGuiAction()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		lock (_ActionQueue)
		{
			while (_ActionQueue.Count > 0)
			{
				switch ((GuiActions)_ActionQueue.Dequeue())
				{
				case GuiActions.StatusMessage:
				{
					string text = _ActionQueue.Dequeue()!.ToString();
					myStatusBar.Push(myStatusBar.GetContextId("regular"), text);
					break;
				}
				case GuiActions.ControlEnableSwitch:
				{
					Widget val = (Widget)_ActionQueue.Dequeue();
					val.set_Sensitive((bool)_ActionQueue.Dequeue());
					break;
				}
				case GuiActions.ControlVisibleSwitch:
				{
					Widget val = (Widget)_ActionQueue.Dequeue();
					val.set_Visible((bool)_ActionQueue.Dequeue());
					break;
				}
				}
			}
		}
	}

	private void SafeStatusBarWrite(string Message)
	{
		lock (_ActionQueue)
		{
			_ActionQueue.Enqueue(GuiActions.StatusMessage);
			_ActionQueue.Enqueue(Message);
		}
		lock (this)
		{
			_GuiAction.WakeupMain();
		}
	}

	private void SafeChangeSensitivity(Widget GuiControl, bool Sensitive)
	{
		lock (_ActionQueue)
		{
			_ActionQueue.Enqueue(GuiActions.ControlEnableSwitch);
			_ActionQueue.Enqueue(GuiControl);
			_ActionQueue.Enqueue(Sensitive);
		}
		lock (this)
		{
			_GuiAction.WakeupMain();
		}
	}

	private void SafeChangeVisibility(Widget GuiControl, bool Visible)
	{
		lock (_ActionQueue)
		{
			_ActionQueue.Enqueue(GuiActions.ControlVisibleSwitch);
			_ActionQueue.Enqueue(GuiControl);
			_ActionQueue.Enqueue(Visible);
		}
		lock (this)
		{
			_GuiAction.WakeupMain();
		}
	}

	private void SafeOutput(string Message)
	{
	}

	private void InitializeAttackVectors()
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		string text = ((!((ToggleButton)chkUseSSL).get_Active()) ? "http://" : "https://");
		text += txtTargetURL.get_Text();
		string text2 = ConnectMethod();
		if (text2.Equals(""))
		{
			return;
		}
		string TargetName = string.Empty;
		string TargetField = string.Empty;
		StringDictionary stringDictionary = new StringDictionary();
		StringDictionary stringDictionary2 = new StringDictionary();
		stringDictionary = ExtractFormParameters(ref TargetName, ref TargetField);
		stringDictionary2 = ExtractCookies();
		if (TargetName.Equals(string.Empty))
		{
			SafeStatusBarWrite("No Injection Point Found");
			return;
		}
		SafeStatusBarWrite("Beginning Preliminary Scan");
		try
		{
			SafeChangeSensitivity((Widget)(object)butScan, Sensitive: false);
			OutputStatusDelegate val = new OutputStatusDelegate(SafeOutput);
			SafeOutput(((ToggleButton)chkTerminateQuery).get_Active().ToString());
			InjectionOptions val2 = new InjectionOptions();
			val2.set_Cookies(stringDictionary2);
			val2.set_TerminateQuery(((ToggleButton)chkTerminateQuery).get_Active());
			val2.set_Tolerance(_SaveInfo.get_FilterTolerance());
			val2.set_WebProxies(_AppSettings.ProxyQueue);
			val2.set_InjectAsString(_SaveInfo.get_InjectAsString());
			val2.set_Delimiter(_SaveInfo.get_FilterDelimiter());
			Console.WriteLine("Filter Delim: {0} && {1}", _SaveInfo.get_FilterDelimiter(), val2.get_Delimiter());
			AttackVectorFactory val3 = new AttackVectorFactory(text, TargetName, TargetField, stringDictionary, text2, val, val2);
			PluginTemplate val4 = (PluginTemplate)_SaveInfo.get_PluginList()[Array.IndexOf((Array)_PluginEntries, (object?)cboPluginList.get_Entry().get_Text())];
			if (((ToggleButton)optBlindInjection).get_Active())
			{
				_SaveInfo.set_TargetAttackVector((AttackVector)(object)val3.BuildBlindSqlAttackVector(_SaveInfo.get_FilterTolerance(), val4));
			}
			SafeStatusBarWrite("Finished initial scan");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
			SafeStatusBarWrite(ex.Message);
		}
		finally
		{
			SafeChangeSensitivity((Widget)(object)butScan, Sensitive: true);
		}
	}

	private StringDictionary ExtractFormParameters(ref string TargetName, ref string TargetField)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		ListStore val = (ListStore)lstParams.get_Model();
		StringDictionary stringDictionary = new StringDictionary();
		TreeIter val2 = default(TreeIter);
		if (val.GetIterFirst(ref val2))
		{
			string text = (string)val.GetValue(val2, 0);
			string text2 = (string)val.GetValue(val2, 1);
			bool flag2 = (bool)val.GetValue(val2, 2);
			bool injectAsString = (bool)val.GetValue(val2, 3);
			if (flag2)
			{
				flag = true;
				TargetName = text;
				TargetField = text2;
				_SaveInfo.set_InjectAsString(injectAsString);
			}
			else
			{
				stringDictionary[text] = text2;
			}
			while (val.IterNext(ref val2))
			{
				text = (string)val.GetValue(val2, 0);
				text2 = (string)val.GetValue(val2, 1);
				flag2 = (bool)val.GetValue(val2, 2);
				injectAsString = (bool)val.GetValue(val2, 3);
				if (!flag && flag2)
				{
					flag = true;
					TargetName = text;
					TargetField = text2;
					_SaveInfo.set_InjectAsString(injectAsString);
				}
				else
				{
					stringDictionary[text] = text2;
				}
			}
		}
		return stringDictionary;
	}

	private StringDictionary ExtractCookies()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		ListStore val = (ListStore)lstCookies.get_Model();
		StringDictionary stringDictionary = new StringDictionary();
		TreeIter val2 = default(TreeIter);
		if (val.GetIterFirst(ref val2))
		{
			string key = (string)val.GetValue(val2, 0);
			string text2 = (stringDictionary[key] = (string)val.GetValue(val2, 1));
			while (val.IterNext(ref val2))
			{
				key = (string)val.GetValue(val2, 0);
				text2 = (stringDictionary[key] = (string)val.GetValue(val2, 1));
			}
		}
		return stringDictionary;
	}

	public void OnUseProxy_Toggle(object sender, EventArgs e)
	{
		((Widget)txtProxyAddress).set_Sensitive(((ToggleButton)chkUseProxy).get_Active());
		((Widget)txtProxyPort).set_Sensitive(((ToggleButton)chkUseProxy).get_Active());
		((Widget)lstProxyList).set_Sensitive(((ToggleButton)chkUseProxy).get_Active());
		((Widget)butAddProxy).set_Sensitive(((ToggleButton)chkUseProxy).get_Active());
		((Widget)butRemoveProxy).set_Sensitive(((ToggleButton)chkUseProxy).get_Active());
	}

	private void ConnectProxyConfigObjects(ref XML gxml)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		ProxyConfig = (Window)gxml.GetWidget("ProxyConfig");
		chkUseProxy = (CheckButton)gxml.GetWidget("chkUseProxy");
		txtProxyAddress = (Entry)gxml.GetWidget("txtProxyAddress");
		txtProxyPort = (Entry)gxml.GetWidget("txtProxyPort");
		butSaveProxySettings = (Button)gxml.GetWidget("butSaveProxySettings");
		butCancelProxySettings = (Button)gxml.GetWidget("butCancelProxySettings");
		butAddProxy = (Button)gxml.GetWidget("butAddProxy");
		butRemoveProxy = (Button)gxml.GetWidget("butRemoveProxy");
		lstProxyList = (TreeView)gxml.GetWidget("lstProxyList");
		butAddProxy.add_Clicked((EventHandler)OnAddProxy_Click);
		butRemoveProxy.add_Clicked((EventHandler)OnRemoveProxy_Click);
		butSaveProxySettings.add_Clicked((EventHandler)OnSaveProxySettings_Click);
		butCancelProxySettings.add_Clicked((EventHandler)OnCancelProxySettings_Click);
		((Button)chkUseProxy).add_Clicked((EventHandler)OnUseProxy_Toggle);
		ListStore model = new ListStore(new Type[2]
		{
			typeof(string),
			typeof(string)
		});
		lstProxyList.set_Model((TreeModel)(object)model);
		lstProxyList.set_HeadersVisible(true);
		lstProxyList.AppendColumn("Address", (CellRenderer)new CellRendererText(), new object[2] { "text", 0 });
		lstProxyList.AppendColumn("Port", (CellRenderer)new CellRendererText(), new object[2] { "text", 1 });
	}

	private void ConnectFileSelectionObjects(ref XML gxml, FileAction fa)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		FileSelectForm = (FileSelection)gxml.GetWidget("FileSelectForm");
		butFileSelectCancel = (Button)gxml.GetWidget("butFileSelectCancel");
		butFileSelectOk = (Button)gxml.GetWidget("butFileSelectOk");
		butFileSelectCancel.add_Clicked((EventHandler)OnFileSelectCancel_Click);
		switch (fa)
		{
		case FileAction.SaveAs:
			butFileSelectOk.add_Clicked((EventHandler)OnFileSelectOk_Click_SaveAs);
			break;
		case FileAction.Open:
			butFileSelectOk.add_Clicked((EventHandler)OnFileSelectOk_Click_Open);
			break;
		case FileAction.Pulldata:
			butFileSelectOk.add_Clicked((EventHandler)OnFileSelectOk_Click_Pulldata);
			break;
		}
	}

	private void SetParametersInDataStore()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		ListStore val = (ListStore)lstParams.get_Model();
		FormParam val2 = default(FormParam);
		TreeIter val3 = default(TreeIter);
		if (val.GetIterFirst(ref val3))
		{
			val2.Name = (string)val.GetValue(val3, 0);
			val2.DefaultValue = (string)val.GetValue(val3, 1);
			val2.Injectable = (bool)val.GetValue(val3, 2);
			_SaveInfo.AddFormParameter(val2);
			while (val.IterNext(ref val3))
			{
				val2 = default(FormParam);
				val2.Name = (string)val.GetValue(val3, 0);
				val2.DefaultValue = (string)val.GetValue(val3, 1);
				val2.Injectable = (bool)val.GetValue(val3, 2);
				_SaveInfo.AddFormParameter(val2);
			}
		}
	}

	private void SetCookiesInDataStore()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		ListStore val = (ListStore)lstCookies.get_Model();
		StringDictionary stringDictionary = new StringDictionary();
		TreeIter val2 = default(TreeIter);
		if (val.GetIterFirst(ref val2))
		{
			string key = (string)val.GetValue(val2, 0);
			string text2 = (stringDictionary[key] = (string)val.GetValue(val2, 1));
			while (val.IterNext(ref val2))
			{
				key = (string)val.GetValue(val2, 0);
				text2 = (stringDictionary[key] = (string)val.GetValue(val2, 1));
			}
			_SaveInfo.set_Cookies(stringDictionary);
		}
	}

	private void LoadParamsFromStore()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		ListStore val = (ListStore)lstParams.get_Model();
		val.Clear();
		foreach (object item in _SaveInfo.get_ParameterTable())
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
			FormParam val2 = (FormParam)dictionaryEntry.Value;
			val.AppendValues(new object[3] { val2.Name, val2.DefaultValue, val2.Injectable });
		}
		lstParams.set_Model((TreeModel)(object)val);
	}

	private void LoadCookiesFromStore()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		ListStore val = (ListStore)lstCookies.get_Model();
		val.Clear();
		foreach (string key in _SaveInfo.get_Cookies().Keys)
		{
			val.AppendValues(new object[2]
			{
				key,
				_SaveInfo.get_Cookies()[key]
			});
		}
		lstParams.set_Model((TreeModel)(object)val);
	}

	private void PullDataFromTables()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		Hashtable hashtable = new Hashtable();
		ListStore val = (ListStore)lstSelectedFields.get_Model();
		TreeIter val2 = default(TreeIter);
		val.GetIterFirst(ref val2);
		if (val.IterIsValid(val2))
		{
			do
			{
				string key = val.GetValue(val2, 0).ToString();
				val.GetValue(val2, 1).ToString();
				long num = (int)val.GetValue(val2, 2) + 1L;
				ArrayList value;
				if (!hashtable.ContainsKey(key))
				{
					value = new ArrayList();
					hashtable.Add(key, value);
				}
				value = (ArrayList)hashtable[key];
				value.Add(num);
				hashtable[key] = value;
			}
			while (val.IterNext(ref val2));
		}
		int num2 = 0;
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = new ArrayList();
		foreach (string key2 in hashtable.Keys)
		{
			_ = (long[])((ArrayList)hashtable[key2]).ToArray(typeof(long));
			arrayList2.Add(_SaveInfo.GetTableFromName(key2));
			arrayList.Add((long[])((ArrayList)hashtable[key2]).ToArray(typeof(long)));
			num2++;
		}
		_SaveInfo.get_TargetAttackVector().PullDataFromTable((Table[])arrayList2.ToArray(typeof(Table)), (long[][])arrayList.ToArray(typeof(long[])), txtPullDataXml.get_Text());
	}

	public void OnQuit_Click(object sender, EventArgs e)
	{
		Application.Quit();
	}

	public void OnLoadFieldInfo_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		try
		{
			if (_SaveInfo.get_TargetAttackVector() == null || _SaveInfo.get_TableList() == null)
			{
				return;
			}
			TreePath val = default(TreePath);
			TreeViewColumn val2 = default(TreeViewColumn);
			lstSchema.GetCursor(ref val, ref val2);
			if (val.IsDescendant(new TreePath("0:1")))
			{
				while (val.get_Depth() > 3)
				{
					val.Up();
				}
				TreeStore val3 = (TreeStore)lstSchema.get_Model();
				TreeIter val4 = default(TreeIter);
				val3.GetIter(ref val4, val);
				string tableName = val3.GetValue(val4, 0).ToString();
				LoadFieldDataFromTableName(tableName, val4, Disconnected: false);
			}
		}
		catch (WebException ex)
		{
			MessageDialog val5 = new MessageDialog(Absinthe, (DialogFlags)0, (MessageType)3, (ButtonsType)2, ex.Status.ToString());
			((Dialog)val5).Run();
		}
	}

	public void OnGetUsername_Click(object sender, EventArgs e)
	{
		ThreadedSub threadedSub = RetrieveUsernameFromDatabase;
		threadedSub.BeginInvoke(null, new object());
	}

	public void OnLoadTableInfo_Click(object sender, EventArgs e)
	{
		ThreadedSub threadedSub = RetrieveTableInfoFromDatabase;
		threadedSub.BeginInvoke(null, new object());
	}

	public void OnInjectable_Click(object sender, EventArgs e)
	{
		((Widget)chkTreatAsString).set_Sensitive(((ToggleButton)chkInjectable).get_Active());
		((ToggleButton)chkTreatAsString).set_Active(false);
	}

	public void OnScan_Click(object sender, EventArgs e)
	{
		ThreadedSub threadedSub = InitializeAttackVectors;
		threadedSub.BeginInvoke(null, new object());
	}

	public void OnConfigProxy_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		XML gxml = new XML((Assembly)null, "gtkabsinthe.glade", "ProxyConfig", (string)null);
		new XML((Assembly)null, "gtkabsinthe.glade", "AboutForm", (string)null);
		ConnectProxyConfigObjects(ref gxml);
		((Widget)ProxyConfig).set_Visible(true);
		((ToggleButton)chkUseProxy).set_Active(_AppSettings.ProxyInUse);
		LoadProxyListView();
		((Widget)txtProxyAddress).set_Sensitive(_AppSettings.ProxyInUse);
		((Widget)txtProxyPort).set_Sensitive(_AppSettings.ProxyInUse);
		((Widget)lstProxyList).set_Sensitive(_AppSettings.ProxyInUse);
		((Widget)butAddProxy).set_Sensitive(_AppSettings.ProxyInUse);
		((Widget)butRemoveProxy).set_Sensitive(_AppSettings.ProxyInUse);
	}

	private void LoadProxyListView()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		Queue proxyQueue = _AppSettings.ProxyQueue;
		ListStore val = (ListStore)lstProxyList.get_Model();
		if (proxyQueue == null)
		{
			return;
		}
		foreach (WebProxy item in proxyQueue)
		{
			val.AppendValues(new object[2]
			{
				item.Address!.Host,
				item.Address!.Port
			});
		}
	}

	public void OnAddParam_Click(object sender, EventArgs e)
	{
		AddParamToListView();
	}

	public void OnAddHeader_Click(object sender, EventArgs e)
	{
		AddCookieToListView();
	}

	private void AddCookieToListView()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		ListStore val = (ListStore)lstCookies.get_Model();
		string text = txtParamName.get_Text();
		string text2 = txtParamValue.get_Text();
		val.AppendValues(new object[2] { text, text2 });
		lstCookies.set_Model((TreeModel)(object)val);
		txtParamName.set_Text(string.Empty);
		txtParamValue.set_Text(string.Empty);
		((ToggleButton)chkInjectable).set_Active(false);
		((ToggleButton)chkTreatAsString).set_Active(false);
	}

	private void AddParamToListView()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		ListStore val = (ListStore)lstParams.get_Model();
		string text = txtParamName.get_Text();
		string text2 = txtParamValue.get_Text();
		if (text.Trim().Length != 0 || text2.Trim().Length != 0)
		{
			val.AppendValues(new object[4]
			{
				text,
				text2,
				((ToggleButton)chkInjectable).get_Active(),
				((ToggleButton)chkTreatAsString).get_Active()
			});
			lstParams.set_Model((TreeModel)(object)val);
			txtParamName.set_Text(string.Empty);
			txtParamValue.set_Text(string.Empty);
			((ToggleButton)chkInjectable).set_Active(false);
			((ToggleButton)chkTreatAsString).set_Active(false);
		}
	}

	public void OnEditParam_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		TreeIter val = default(TreeIter);
		TreeModel model = lstParams.get_Model();
		ListStore val2 = (ListStore)lstParams.get_Model();
		TreeView val3 = lstParams;
		if (tabParams.get_CurrentPage() == 1)
		{
			val2 = (ListStore)lstCookies.get_Model();
			model = lstCookies.get_Model();
			val3 = lstCookies;
		}
		if (val3.get_Selection().GetSelected(ref model, ref val))
		{
			txtParamName.set_Text((string)model.GetValue(val, 0));
			txtParamValue.set_Text((string)model.GetValue(val, 1));
			if (tabParams.get_CurrentPage() == 0)
			{
				((ToggleButton)chkInjectable).set_Active((bool)model.GetValue(val, 2));
			}
			else
			{
				((ToggleButton)chkInjectable).set_Active(false);
			}
			val2.Remove(ref val);
		}
	}

	public void OnDeleteParam_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		TreeIter val = default(TreeIter);
		TreeModel model = lstParams.get_Model();
		ListStore val2 = (ListStore)lstParams.get_Model();
		TreeView val3 = lstParams;
		if (tabParams.get_CurrentPage() == 1)
		{
			val2 = (ListStore)lstCookies.get_Model();
			model = lstCookies.get_Model();
			val3 = lstCookies;
		}
		if (val3.get_Selection().GetSelected(ref model, ref val))
		{
			val2.Remove(ref val);
		}
	}

	public void OnSaveProxySettings_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		ListStore val = (ListStore)lstProxyList.get_Model();
		TreeIter val2 = default(TreeIter);
		if (val.GetIterFirst(ref val2))
		{
			string proxyAddress = (string)val.GetValue(val2, 0);
			int proxyPort = int.Parse((string)val.GetValue(val2, 1));
			_AppSettings.AddProxy(proxyAddress, proxyPort);
			while (val.IterNext(ref val2))
			{
				proxyAddress = (string)val.GetValue(val2, 0);
				proxyPort = int.Parse((string)val.GetValue(val2, 1));
				_AppSettings.AddProxy(proxyAddress, proxyPort);
			}
		}
		((Widget)ProxyConfig).Destroy();
	}

	public void OnAddProxy_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (Regex.IsMatch(txtProxyPort.get_Text(), "^\\d*$"))
		{
			ListStore val = (ListStore)lstProxyList.get_Model();
			val.AppendValues(new object[2]
			{
				txtProxyAddress.get_Text(),
				txtProxyPort.get_Text()
			});
			txtProxyAddress.set_Text(string.Empty);
			txtProxyPort.set_Text(string.Empty);
		}
		else
		{
			GenerateErrorDialog("The proxy port you have selected is invalid.");
		}
	}

	public void OnRemoveProxy_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		TreeIter val = default(TreeIter);
		TreeModel model = lstProxyList.get_Model();
		ListStore val2 = (ListStore)lstProxyList.get_Model();
		txtProxyAddress.set_Text(string.Empty);
		txtProxyPort.set_Text(string.Empty);
		lstProxyList.get_Selection().GetSelected(ref model, ref val);
		val2.Remove(ref val);
	}

	public void OnCancelProxySettings_Click(object sender, EventArgs e)
	{
		((Widget)ProxyConfig).Destroy();
	}

	public void OnSave_Click(object sender, EventArgs e)
	{
		if (_SaveInfo.get_OutputFile().Length == 0)
		{
			OnSaveAs_Click(sender, e);
			return;
		}
		_SaveInfo.set_TargetURL(txtTargetURL.get_Text());
		_SaveInfo.set_ConnectionMethod(ConnectMethod());
		SetParametersInDataStore();
		SetCookiesInDataStore();
		_SaveInfo.OutputToFile(cboPluginList.get_Entry().get_Text());
	}

	public void OnOpen_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		XML gxml = new XML((Assembly)null, "gtkabsinthe.glade", "FileSelectForm", (string)null);
		ConnectFileSelectionObjects(ref gxml, FileAction.Open);
		if (FileSelectForm != null)
		{
			((Widget)FileSelectForm).set_Visible(true);
		}
	}

	public void OnMenuOptions_Click(object sender, EventArgs e)
	{
		new gtkInjectionOptions(ref _SaveInfo);
	}

	public void OnAbout_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		XML val = new XML((Assembly)null, "gtkabsinthe.glade", "AboutForm", (string)null);
		if (val != null)
		{
			AboutForm = (Window)val.GetWidget("AboutForm");
			butAboutOk = (Button)val.GetWidget("butAboutOk");
			AboutImage = (Image)val.GetWidget("AboutImage");
			AboutImage.set_Pixbuf(new Pixbuf((Assembly)null, "log0.gif"));
			butAboutOk.add_Clicked((EventHandler)OnAboutOk_Click);
			if (AboutForm != null)
			{
				((Widget)AboutForm).set_Visible(true);
			}
		}
	}

	public void OnNew_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		((ListStore)lstParams.get_Model()).Clear();
		((ListStore)lstCookies.get_Model()).Clear();
		txtTargetURL.set_Text(string.Empty);
		((ToggleButton)optConnectPost).set_Active(true);
		InitUI();
		_SaveInfo = new DataStore(new OutputStatusDelegate(SafeOutput));
	}

	public void OnSaveAs_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		XML gxml = new XML((Assembly)null, "gtkabsinthe.glade", "FileSelectForm", (string)null);
		ConnectFileSelectionObjects(ref gxml, FileAction.SaveAs);
		if (FileSelectForm != null)
		{
			((Widget)FileSelectForm).set_Visible(true);
		}
	}

	public void OnAboutOk_Click(object sender, EventArgs e)
	{
		((Widget)AboutForm).Destroy();
	}

	public void OnFileSelectCancel_Click(object sender, EventArgs e)
	{
		((Widget)FileSelectForm).Destroy();
	}

	public void OnAddDlField_Click(object sender, EventArgs e)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (_SaveInfo.get_TargetAttackVector() == null || _SaveInfo.get_TableList() == null)
			{
				return;
			}
			TreePath val = default(TreePath);
			TreeViewColumn val2 = default(TreeViewColumn);
			lstAvailFields.GetCursor(ref val, ref val2);
			if (val != null && lstAvailFields != null)
			{
				TreeIter val3 = default(TreeIter);
				lstAvailFields.get_Model().GetIter(ref val3, val);
				if (lstAvailFields.get_Model() != null)
				{
					ListStore val4 = (ListStore)lstAvailFields.get_Model();
					string text = val4.GetValue(val3, 0).ToString();
					string text2 = val4.GetValue(val3, 1).ToString();
					int num = (int)val4.GetValue(val3, 2);
					val4.Remove(ref val3);
					ListStore val5 = (ListStore)lstSelectedFields.get_Model();
					val5.AppendValues(new object[3] { text, text2, num });
				}
			}
		}
		catch (NullReferenceException)
		{
		}
	}

	public void OnRemoveDlField_Click(object sender, EventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (_SaveInfo.get_TargetAttackVector() != null && _SaveInfo.get_TableList() != null)
			{
				TreePath val = default(TreePath);
				TreeViewColumn val2 = default(TreeViewColumn);
				lstSelectedFields.GetCursor(ref val, ref val2);
				TreeIter val3 = default(TreeIter);
				lstSelectedFields.get_Model().GetIter(ref val3, val);
				ListStore val4 = (ListStore)lstSelectedFields.get_Model();
				string text = val4.GetValue(val3, 0).ToString();
				string text2 = val4.GetValue(val3, 1).ToString();
				int num = (int)val4.GetValue(val3, 2);
				val4.Remove(ref val3);
				ListStore val5 = (ListStore)lstAvailFields.get_Model();
				val5.AppendValues(new object[3] { text, text2, num });
			}
		}
		catch (NullReferenceException)
		{
		}
	}

	public void OnBrowseDatapull_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		XML gxml = new XML((Assembly)null, "gtkabsinthe.glade", "FileSelectForm", (string)null);
		ConnectFileSelectionObjects(ref gxml, FileAction.Pulldata);
		if (FileSelectForm != null)
		{
			((Widget)FileSelectForm).set_Visible(true);
		}
	}

	public void OnFileSelectOk_Click_Open(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0032: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Invalid comparison between Unknown and I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Invalid comparison between Unknown and I4
		OutputStatusDelegate val = new OutputStatusDelegate(SafeOutput);
		try
		{
			_SaveInfo.LoadXmlFile(FileSelectForm.get_Filename(), val, _AppSettings.ProxyQueue);
		}
		catch (InvalidDataFileException val2)
		{
			InvalidDataFileException val3 = val2;
			MessageDialog val4 = new MessageDialog((Window)(object)FileSelectForm, (DialogFlags)2, (MessageType)3, (ButtonsType)2, val3.Message());
			((Dialog)val4).Run();
		}
		if (_SaveInfo.get_ConnectionMethod().ToUpper().Equals("POST"))
		{
			((ToggleButton)optConnectPost).set_Active(true);
		}
		else
		{
			((ToggleButton)optConnectGet).set_Active(true);
		}
		txtTargetURL.set_Text(_SaveInfo.get_TargetURL());
		LoadParamsFromStore();
		((ToggleButton)optBlindInjection).set_Active(false);
		((ToggleButton)optErrorBasedInjection).set_Active(false);
		((ToggleButton)chkTerminateQuery).set_Active(_SaveInfo.get_TerminateQuery());
		if (_SaveInfo.get_LoadedPluginName() != null)
		{
			LoadPluginSelection(_SaveInfo.get_LoadedPluginName());
		}
		if (_SaveInfo.get_TargetAttackVector() != null)
		{
			ExploitType exploitType = _SaveInfo.get_TargetAttackVector().get_ExploitType();
			if ((int)exploitType != 0)
			{
				if ((int)exploitType == 1)
				{
					((ToggleButton)optErrorBasedInjection).set_Active(true);
				}
			}
			else
			{
				((ToggleButton)optBlindInjection).set_Active(true);
			}
		}
		LoadSchemaData();
		((Widget)FileSelectForm).Destroy();
	}

	private void LoadPluginSelection(string PluginText)
	{
		cboPluginList.get_Entry().set_Text(PluginText);
	}

	private void LoadSchemaData()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		if (_SaveInfo.get_Username().Length > 0)
		{
			AdjustDbLoginText();
		}
		if (_SaveInfo.get_TableList() != null)
		{
			SafeOutput("one");
			LoadTableInfoList();
			SafeOutput("two");
			TreePath val = new TreePath("0:1");
			TreeStore val2 = (TreeStore)lstSchema.get_Model();
			SafeOutput("three");
			TreeIter val3 = default(TreeIter);
			val2.GetIter(ref val3, val);
			SafeOutput("TableIter: #" + val3.Stamp);
			SafeOutput("N Children: #" + val2.IterNChildren());
			TreeIter val5 = default(TreeIter);
			for (int i = 0; i < val2.IterNChildren(val3); i++)
			{
				TreePath val4 = new TreePath("0:1:" + i);
				val2.GetIter(ref val5, val4);
				string text = val2.GetValue(val5, 0).ToString();
				SafeOutput("Table Name: " + text);
				SafeOutput("NameIter: #" + val5.Stamp);
				LoadFieldDataFromTableName(text, val5, Disconnected: true);
			}
			((Widget)butLoadFieldInfo).set_Visible(true);
		}
	}

	public void OnFileSelectOk_Click_SaveAs(object sender, EventArgs e)
	{
		_SaveInfo.set_OutputFile(FileSelectForm.get_Filename());
		OnSave_Click(sender, e);
		((Widget)FileSelectForm).Destroy();
	}

	public void OnFileSelectOk_Click_Pulldata(object sender, EventArgs e)
	{
		txtPullDataXml.set_Text(FileSelectForm.get_Filename());
		((Widget)FileSelectForm).Destroy();
	}

	public void OnPullData_Click(object sender, EventArgs e)
	{
		if (txtPullDataXml.get_Text().Length > 0)
		{
			PullDataFromTables();
		}
		else
		{
			myStatusBar.Push(myStatusBar.GetContextId("regular"), "Please select a file!");
		}
	}

	private void OnAppendExtraQuery_Click(object sender, EventArgs e)
	{
		((ToggleButton)chkTerminateQuery).set_Active(false);
		if (((ToggleButton)chkAppendExtraQuery).get_Active())
		{
			((Widget)txtAppendExtraQuery).set_Visible(true);
			((Widget)lblAppendExtraQuery).set_Visible(true);
		}
		else
		{
			txtAppendExtraQuery.set_Text(string.Empty);
			((Widget)txtAppendExtraQuery).set_Visible(false);
			((Widget)lblAppendExtraQuery).set_Visible(false);
		}
	}

	private void OnTerminateQuery_Click(object sender, EventArgs e)
	{
		((ToggleButton)chkAppendExtraQuery).set_Active(false);
		((Widget)txtAppendExtraQuery).set_Visible(false);
		txtAppendExtraQuery.set_Text(string.Empty);
		((Widget)lblAppendExtraQuery).set_Visible(false);
	}
}
