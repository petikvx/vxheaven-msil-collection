#define TRACE
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using GoolagScanner.Debug;
using GoolagScanner.Properties;

namespace GoolagScanner;

public class GScanForm : Form
{
	private class ListViewItemComparer : IComparer
	{
		private int col;

		public ListViewItemComparer()
		{
			col = 0;
		}

		public ListViewItemComparer(int column)
		{
			col = column;
		}

		public int Compare(object x, object y)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			return string.Compare(((ListViewItem)x).get_SubItems().get_Item(col).get_Text(), ((ListViewItem)y).get_SubItems().get_Item(col).get_Text());
		}
	}

	private class ListViewItemComparerDesc : IComparer
	{
		private int col;

		public ListViewItemComparerDesc()
		{
			col = 0;
		}

		public ListViewItemComparerDesc(int column)
		{
			col = column;
		}

		public int Compare(object x, object y)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			return -string.Compare(((ListViewItem)x).get_SubItems().get_Item(col).get_Text(), ((ListViewItem)y).get_SubItems().get_Item(col).get_Text());
		}
	}

	private const int animSpeed = 300;

	private string RealTitleText = "";

	private ResourceManager rm;

	private Categories DorkCategories = new Categories();

	private ArrayList dorkList = new ArrayList();

	private List<SSelectedDork> dorksToScan;

	private SummaryStat summaryStat;

	private ScanningDialog scanningdialog;

	private SSelectedDork SelectedDork;

	private int dorksLoaded;

	private bool resultModified;

	private volatile bool inScanning;

	private readonly string mResScanning;

	private readonly string mResReady;

	private readonly string mResCancel;

	private string strFile = "";

	private static int lastSortedColumn = -1;

	private IContainer components;

	private MenuStrip menuStrip1;

	private ToolStripMenuItem fileToolStripMenuItem;

	private ToolStripMenuItem newToolStripMenuItem;

	private ToolStripMenuItem openToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator;

	private ToolStripMenuItem saveToolStripMenuItem;

	private ToolStripMenuItem saveAsToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem exitToolStripMenuItem;

	private ToolStripMenuItem editToolStripMenuItem;

	private ToolStripMenuItem cutToolStripMenuItem;

	private ToolStripMenuItem copyToolStripMenuItem;

	private ToolStripMenuItem pasteToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem selectAllToolStripMenuItem;

	private ToolStripMenuItem toolsToolStripMenuItem;

	private ToolStripMenuItem optionsToolStripMenuItem;

	private ToolStripMenuItem helpToolStripMenuItem;

	private ToolStripMenuItem aboutToolStripMenuItem;

	private StatusStrip statusStrip1;

	private ToolStrip toolStrip1;

	private ToolStripButton newToolStripButton;

	private ToolStripButton openToolStripButton;

	private ToolStripButton saveToolStripButton;

	private ToolStripButton printToolStripButton;

	private ToolStripSeparator toolStripSeparator6;

	private ToolStripButton cutToolStripButton;

	private ToolStripButton copyToolStripButton;

	private ToolStripButton helpToolStripButton;

	private ContextMenuStrip dorkMenuStrip;

	private ToolStripMenuItem scanToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator12;

	private ToolStripMenuItem propertiesToolStripMenuItem;

	private ContextMenuStrip resultsMenuStrip;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem copyToClpMenuItem;

	private ToolStripMenuItem openInBrowserToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator13;

	private ToolStripMenuItem clearResultsToolStripMenuItem;

	private ToolStripStatusLabel StatusLabel;

	private OpenFileDialog openDorkFile;

	private SaveFileDialog saveResultsFileDialog;

	private ToolStrip scanToolStrip;

	private ToolStripButton scanButton;

	private ToolStripSeparator toolStripSeparator9;

	private ToolStripLabel toolStripLabel1;

	private ToolStripTextBox scanHostTextBox;

	private ToolStripSeparator toolStripSeparator11;

	private SplitContainer splitContainer2;

	private GroupBox groupBox2;

	private RichTextBox richTextBox1;

	private SplitContainer splitContainer3;

	private GroupBox groupBox3;

	private TabControl tabControl1;

	private GroupBox groupBox1;

	private TreeView tvwDorks;

	private SplitContainer splitContainer1;

	private ImageList treeImageList;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem setMarkedMenuItem;

	private ToolStripMenuItem setUnmarkedMenuItem;

	private ToolStripSeparator toolStripSeparator7;

	private ToolStripMenuItem markallMenuItem3;

	private ToolStripMenuItem unmarkallMenuItem;

	private ListView resultListView;

	private ColumnHeader columnHeader1;

	private ColumnHeader columnHeader2;

	private ColumnHeader columnHeader3;

	private ImageList resultImageList;

	private ToolStripButton stopScanButton;

	private ToolStripSeparator toolStripSeparator8;

	private OpenFileDialog openDorkFileDialog;

	private BackgroundWorker backgroundScan;

	private ProgressBar progressBar1;

	private BackgroundWorker backgroundAnim;

	private ToolStripMenuItem showLeftStrip;

	private ToolStripSeparator toolStripSeparator10;

	private ToolStripMenuItem scanMoreFromHereStrip;

	private ToolStripMenuItem ShowErrorStrip;

	private ToolStripMenuItem ClearErrorsStrip;

	private ToolStripButton ClearButton;

	private PictureBox pictureMenuAnim;

	private ToolStripSeparator toolStripSeparator14;

	private ToolStripSeparator toolStripSeparator15;

	private ToolStripMenuItem FindMenuItem1;

	private ToolStripMenuItem ClearResultsMenuItem;

	private ToolStripMenuItem scanToolStripMenuItem1;

	private ToolStripMenuItem scanMarkedToolStripMenuItem;

	private ToolStripMenuItem stopScanToolStripMenuItem;

	private TabPage tabPage2;

	private TextBox ConsoleTextBox;

	private ToolStripMenuItem RescanMenuItem;

	private ToolStripSeparator toolStripSeparator16;

	private ToolStripMenuItem OpenInBrowser;

	private ToolStripSeparator toolStripSeparator17;

	private ToolStripMenuItem EditScanMenuItem;

	private void tvw_AfterSelect(object sender, TreeViewEventArgs e)
	{
		((TextBoxBase)richTextBox1).Clear();
		bool flag = e.get_Node().get_Tag() is Dork;
		SelectedDork.Dork = e.get_Node().get_Tag() as Dork;
		SelectedDork.TreeNode = e.get_Node();
		SelectedDork.NextPage = 0;
		if (flag)
		{
			formatDorkToRichText(SelectedDork.Dork);
		}
		((ToolStripItem)scanToolStripMenuItem).set_Enabled(flag && !inScanning);
		((ToolStripItem)EditScanMenuItem).set_Enabled(flag);
		((ToolStripItem)propertiesToolStripMenuItem).set_Enabled(flag);
		((ToolStripItem)OpenInBrowser).set_Enabled(flag);
	}

	private void tvw_FillTree()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		tvwDorks.get_Nodes().Clear();
		TreeNode val = new TreeNode(rm.GetString("RES_DORKS"));
		Category tag = new Category();
		val.set_Tag((object)tag);
		tvwDorks.get_Nodes().Add(val);
		for (int i = 0; i < DorkCategories.Count; i++)
		{
			AddCategoryToTree(val, i);
		}
		val.Expand();
		AddDorksToCatTree(userdork: false);
	}

	private void AddDorksToCatTree(bool userdork)
	{
		foreach (Dork dork in dorkList)
		{
			string category = dork.Category;
			for (int i = 0; i < DorkCategories.Count; i++)
			{
				Category categoryByIndex = DorkCategories.getCategoryByIndex(i);
				if (category == categoryByIndex.Text)
				{
					TreeNode val = categoryByIndex.Node.get_Nodes().Add(dork.Name);
					val.set_Tag((object)dork);
					if (userdork)
					{
						val.set_ForeColor(Color.Blue);
					}
					else
					{
						val.set_ForeColor(SystemColors.ControlText);
					}
					categoryByIndex.Count++;
					break;
				}
			}
		}
	}

	private void AddCategoryToTree(TreeNode RootNode, int i)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		Category categoryByIndex = DorkCategories.getCategoryByIndex(i);
		TreeNode val2 = (categoryByIndex.Node = new TreeNode(categoryByIndex.Text));
		val2.set_Tag((object)categoryByIndex);
		RootNode.get_Nodes().Add(val2);
	}

	private void AddCategoryToTreeEx(TreeNode RootNode, Category c)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		TreeNode val2 = (c.Node = new TreeNode(c.Text));
		val2.set_Tag((object)c);
		val2.set_ForeColor(Color.Blue);
		RootNode.get_Nodes().Add(val2);
	}

	private void SetTreeCategoriesCount()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		((Control)this).set_UseWaitCursor(true);
		TreeNode val = tvwDorks.get_Nodes().get_Item(0);
		foreach (TreeNode node in val.get_Nodes())
		{
			TreeNode val2 = node;
			if (val2.get_Tag() is Category && val2.get_Tag() is Category category)
			{
				StringBuilder stringBuilder = new StringBuilder(category.Text, category.Text.Length + 10);
				stringBuilder.Append("  (");
				stringBuilder.Append(category.Count);
				stringBuilder.Append(")");
				val2.set_Text(stringBuilder.ToString());
				((Control)this).Update();
			}
		}
		((Control)this).set_UseWaitCursor(false);
	}

	private void tvw_DoubleClick(object sender, EventArgs e)
	{
		TreeNode selectedNode = tvwDorks.get_SelectedNode();
		if (selectedNode.get_Tag() is Dork)
		{
			SelectedDork.Dork = (Dork)selectedNode.get_Tag();
			SelectedDork.TreeNode = selectedNode;
			scanButton_Click(sender, e);
		}
	}

	private void tvw_AfterCheck(object sender, TreeViewEventArgs e)
	{
		if (e.get_Node().get_Tag() is Category)
		{
			setTreeNodeRecursive(e.get_Node(), e.get_Node().get_Checked());
		}
	}

	private void setTreeNodeRecursive(TreeNode tn, bool checkedState)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		foreach (TreeNode node in tn.get_Nodes())
		{
			TreeNode val = node;
			val.set_Checked(checkedState);
			if (val.get_Tag() is Category)
			{
				setTreeNodeRecursive(val, checkedState);
				((Control)this).Update();
			}
		}
	}

	private void setSelectedNodeRecursing(bool checkedState)
	{
		TreeNode selectedNode = tvwDorks.get_SelectedNode();
		selectedNode.set_Checked(checkedState);
		setTreeNodeRecursive(selectedNode, checkedState);
	}

	private void setMarkedMenuItem_Click(object sender, EventArgs e)
	{
		setSelectedNodeRecursing(checkedState: true);
	}

	private void setUnmarkedMenuItem_Click(object sender, EventArgs e)
	{
		setSelectedNodeRecursing(checkedState: false);
	}

	private TreeNode GetSelectedCategory()
	{
		TreeNode val = tvwDorks.get_SelectedNode();
		if (val.get_Tag() is Dork)
		{
			val = tvwDorks.get_SelectedNode().get_Parent();
		}
		return val;
	}

	private void markallMenuItem_Click(object sender, EventArgs e)
	{
		TreeNode val = tvwDorks.get_SelectedNode();
		if (val.get_Tag() is Dork)
		{
			val = tvwDorks.get_SelectedNode().get_Parent();
		}
		val.set_Checked(true);
		setTreeNodeRecursive(val, checkedState: true);
	}

	private void unmarkallMenuItem_Click(object sender, EventArgs e)
	{
		TreeNode val = tvwDorks.get_SelectedNode();
		if (val.get_Tag() is Dork)
		{
			val = tvwDorks.get_SelectedNode().get_Parent();
		}
		val.set_Checked(false);
		setTreeNodeRecursive(val, checkedState: false);
	}

	private void tvw_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if ((e.get_Button() & 0x100000) == 1048576)
		{
			TreeNode selectedNode = tvwDorks.get_SelectedNode();
			if (selectedNode != null && selectedNode.get_Tag() is Dork dork)
			{
				IScanProvider myScanProvider = new ScanGoogleProvider();
				RequestBuilder requestBuilder = new RequestBuilder(myScanProvider);
				string request = requestBuilder.getRequest(dork.Query, "", 0);
				((Control)tvwDorks).DoDragDrop((object)request, (DragDropEffects)1);
			}
		}
	}

	private string GetRequestFromSelected()
	{
		TreeNode selectedNode = tvwDorks.get_SelectedNode();
		if (selectedNode != null && selectedNode.get_Tag() is Dork dork)
		{
			IScanProvider myScanProvider = new ScanGoogleProvider();
			RequestBuilder requestBuilder = new RequestBuilder(myScanProvider);
			return requestBuilder.getRequest(dork.Query, ((ToolStripItem)scanHostTextBox).get_Text().Trim(), 0);
		}
		return null;
	}

	private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		TreeNode selectedNode = tvwDorks.get_SelectedNode();
		if (selectedNode.get_Tag() != null)
		{
			DorkProperty dorkProperty = new DorkProperty();
			dorkProperty.setDork((Dork)selectedNode.get_Tag());
			((Control)dorkProperty).Show();
		}
	}

	private void FindMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		TreeNode val = tvwDorks.get_SelectedNode();
		if (val == null)
		{
			val = tvwDorks.get_Nodes().get_Item(0);
		}
		SearchDialog searchDialog = new SearchDialog(tvwDorks, val);
		((Form)searchDialog).ShowDialog();
	}

	private void OpenInBrowser_Click(object sender, EventArgs e)
	{
		string requestFromSelected = GetRequestFromSelected();
		if (requestFromSelected != null)
		{
			OSUtils.OpenInBrowser(requestFromSelected);
		}
	}

	private void singleScan()
	{
		dorksToScan = new List<SSelectedDork>();
		dorksToScan.Add(SelectedDork);
		InitializeScanning();
	}

	private void singleScan(SSelectedDork selectedDork)
	{
		dorksToScan = new List<SSelectedDork>();
		dorksToScan.Add(selectedDork);
		InitializeScanning();
	}

	private void InitializeScanning()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, "InitializeScanning()");
		if (inScanning)
		{
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceWarning, "..there is already a scan running.");
			return;
		}
		if (!Settings.Default.AllowFreeScan && string.IsNullOrEmpty(((ToolStripItem)scanHostTextBox).get_Text().Trim()))
		{
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceWarning, "..no host entered. AllowFreeScan not set.");
			MessageBox.Show(rm.GetString("RES_E_ENTERHOST"), rm.GetString("RES_E_SCANERROR"), (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		inScanning = true;
		summaryStat = new SummaryStat();
		summaryStat.captureStartTime();
		resultListView.set_Sorting((SortOrder)0);
		((ToolStripItem)StatusLabel).set_Text(mResScanning + "...");
		((Control)pictureMenuAnim).set_Enabled(true);
		updateScanButtons();
		progressBar1.set_Value(0);
		backgroundScan.RunWorkerAsync();
		backgroundAnim.RunWorkerAsync();
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, "Backgroundworker for scanning started.");
		((Control)this).Update();
		if (dorksToScan.Count > 1 && Settings.Default.ShowMassScanDialog)
		{
			scanningdialog = new ScanningDialog(dorksToScan.Count, StopScanning);
			((Control)scanningdialog).Show();
			scanningdialog.UpdateTitle(0);
		}
	}

	private void FinalizeScanning()
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, "FinalizeScanning()");
		backgroundAnim.CancelAsync();
		inScanning = false;
		summaryStat.captureEndTime();
		updateScanButtons();
		((ToolStripItem)StatusLabel).set_Text(mResReady);
		progressBar1.set_Value(0);
		((Control)pictureMenuAnim).set_Enabled(false);
		updateUIStates(isModified: true);
		if (scanningdialog != null)
		{
			((Component)(object)scanningdialog).Dispose();
		}
		ResetStatus();
		((Control)this).Update();
		if (Settings.Default.ShowSummary && dorksToScan.Count > 1)
		{
			SummaryReport summaryReport = new SummaryReport(((ToolStripItem)scanHostTextBox).get_Text().Trim(), summaryStat);
			((Form)summaryReport).ShowDialog();
		}
	}

	private DorkDone CreateDorkForScanning(SSelectedDork scanDork)
	{
		DorkDone dorkDone = new DorkDone(scanDork);
		dorkDone.ScanResult = 1;
		dorkDone.Host = ((ToolStripItem)scanHostTextBox).get_Text().Trim();
		dorkDone.Now();
		return dorkDone;
	}

	private ListViewItem ShowTemporaryDork(SSelectedDork scanDork)
	{
		ListViewItem val = resultListView.get_Items().Add(rm.GetString("RES_SCAN") + "...", 1);
		val.get_SubItems().Add(scanDork.Dork.Title);
		val.get_SubItems().Add("...");
		resultListView.EnsureVisible(val.get_Index());
		formatDorkToRichText(scanDork.Dork);
		((ToolStripItem)StatusLabel).set_Text(mResScanning + ": " + scanDork.Dork.Category + " ...");
		return val;
	}

	private void ShowScanningDialog(bool show)
	{
		if (scanningdialog != null)
		{
			((Control)scanningdialog).set_Visible(show);
			((Control)this).Update();
		}
	}

	private void CheckAndDisplayResults(ScanMonitor scanmonitor)
	{
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Invalid comparison between Unknown and I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Invalid comparison between Unknown and I4
		if (!scanmonitor.HasResults())
		{
			return;
		}
		Scanner finishedScanner = scanmonitor.GetFinishedScanner();
		DorkDone resultDork = finishedScanner.ResultDork;
		if (resultDork == null)
		{
			return;
		}
		if (resultDork.ScanResult == 5)
		{
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceInfo, "Scan was canceled.");
			resultDork.ViewItem.set_ImageIndex(5);
			resultDork.ViewItem.get_SubItems().get_Item(0).set_Text(rm.GetString("RES_CANCELSCAN"));
			resultDork.ViewItem.get_SubItems().get_Item(2).set_Text("");
		}
		else if (resultDork.ScanResult == 0)
		{
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceInfo, "Scan returned no results.");
			resultDork.ViewItem.set_ImageIndex(0);
			resultDork.ViewItem.get_SubItems().get_Item(0).set_Text(rm.GetString("RES_NORESULT"));
			resultDork.ViewItem.get_SubItems().get_Item(2).set_Text("");
			summaryStat.ScansNoResult++;
		}
		else if (resultDork.ScanResult == 3)
		{
			resultDork.ViewItem.set_ImageIndex(3);
			resultDork.ViewItem.get_SubItems().get_Item(0).set_Text(rm.GetString("RES_FAILED"));
			resultDork.ViewItem.get_SubItems().get_Item(2).set_Text("");
			summaryStat.ScansFailed++;
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceInfo, "Scan failed.");
		}
		else if (resultDork.ScanResult == 4)
		{
			resultDork.ViewItem.set_ImageIndex(4);
			resultDork.ViewItem.get_SubItems().get_Item(0).set_Text(rm.GetString("RES_BLOCKED"));
			resultDork.ViewItem.get_SubItems().get_Item(2).set_Text(resultDork.ResultURL);
			summaryStat.ScansFailed++;
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceInfo, "Scan was blocked.");
			if (Settings.Default.BlockDetectMode == 1)
			{
				int num = scanmonitor.StopAllActive();
				System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, num, "Scans canceled in queue");
				while (scanmonitor.HasPendingScans())
				{
					Thread.Sleep(200);
				}
			}
			if (Settings.Default.BlockDetectMode == 2)
			{
				return;
			}
			ShowScanningDialog(show: false);
			DialogResult val = MessageBox.Show("Start browser to unlock block? Cancel will stop scanning.", "Block detected!", (MessageBoxButtons)3, (MessageBoxIcon)16);
			if ((int)val == 6)
			{
				OSUtils.OpenInBrowser(resultDork.ResultURL);
				MessageBox.Show("Ready to resume?", "Resume scanning.", (MessageBoxButtons)0, (MessageBoxIcon)32);
			}
			else if ((int)val == 2)
			{
				int num2 = scanmonitor.StopAllActive();
				System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, num2, "Scans canceled in queue");
				while (scanmonitor.HasPendingScans())
				{
					Thread.Sleep(100);
				}
				StopScanning();
			}
			ShowScanningDialog(show: true);
		}
		else
		{
			if (resultDork.ScanResult != 2)
			{
				return;
			}
			resultListView.get_Items().Remove(resultDork.ViewItem);
			if (finishedScanner.Count <= 0)
			{
				return;
			}
			int num3 = 0;
			DorkDone dorkDone = finishedScanner.ResultDork;
			DorkDone dorkDone2 = null;
			if (dorkDone.NextPage != 0 && dorkDone.NextPage / 10 < Settings.Default.RequestPages)
			{
				dorkDone2 = new DorkDone();
				dorkDone2 = (DorkDone)dorkDone.Clone();
				dorkDone2.ScanResult = 1;
				Scanner scanner = new Scanner(new ScanGoogleProvider(), dorkDone2);
				while (!scanmonitor.IsThreadAvail())
				{
					Thread.Sleep(300);
				}
				scanmonitor.Add(scanner);
				Thread.Sleep(100);
			}
			do
			{
				ListViewItem val2 = resultListView.get_Items().Add(rm.GetString("RES_SUCCESS"), 2);
				val2.get_SubItems().Add(dorkDone.Title);
				val2.get_SubItems().Add(dorkDone.ResultURL);
				num3 = val2.get_Index();
				val2.set_Tag((object)dorkDone);
				summaryStat.ScansSuccess++;
				dorkDone = dorkDone.Next;
				resultListView.EnsureVisible(num3);
			}
			while (dorkDone != null);
		}
	}

	private void doThreadScan(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = (BackgroundWorker)sender;
		int num = 0;
		double num2 = 100.0 / (double)dorksToScan.Count;
		double num3 = 0.0;
		using ScanMonitor scanMonitor = new ScanMonitor(Settings.Default.MaxParallelScans);
		foreach (SSelectedDork item in dorksToScan)
		{
			num++;
			if (scanningdialog != null)
			{
				scanningdialog.UpdateTitle(num);
				((Control)this).Update();
			}
			DorkDone dorkDone = CreateDorkForScanning(item);
			ListViewItem val = ShowTemporaryDork(item);
			val.set_Tag((object)dorkDone);
			dorkDone.ViewItem = val;
			((Control)this).Update();
			Scanner scanner = new Scanner(new ScanGoogleProvider(), dorkDone);
			while (!scanMonitor.IsThreadAvail())
			{
				CheckAndDisplayResults(scanMonitor);
				Thread.Sleep(300);
			}
			scanMonitor.Add(scanner);
			Thread.Sleep(200);
			CheckAndDisplayResults(scanMonitor);
			if (scanningdialog != null)
			{
				num3 += num2 / (double)Settings.Default.RequestPages;
				scanningdialog.SetPercentage((int)Math.Round(num3));
				((Control)this).Update();
			}
			if (!backgroundWorker.CancellationPending)
			{
				int num4 = Settings.Default.StealthTime / 1000;
				if (num4 > 0)
				{
					if (num4 > 3)
					{
						((Control)progressBar1).set_ForeColor(Color.DarkGray);
					}
					for (int i = 0; i < num4; i++)
					{
						Thread.Sleep(1000);
						if (backgroundWorker.CancellationPending)
						{
							e.Cancel = true;
							break;
						}
					}
					if (num4 > 3)
					{
						((Control)progressBar1).set_ForeColor(Color.DarkBlue);
					}
				}
				if (scanningdialog != null)
				{
					num3 = num2 * (double)num;
					scanningdialog.SetPercentage((int)Math.Round(num3));
					((Control)this).Update();
				}
				if (e.Cancel)
				{
					break;
				}
				continue;
			}
			e.Cancel = true;
			break;
		}
		if (scanningdialog != null && (scanMonitor.HasResults() || scanMonitor.HasPendingScans()))
		{
			scanningdialog.UpdateTitleWaiting();
		}
		while (scanMonitor.HasResults() || (!e.Cancel && scanMonitor.HasPendingScans()))
		{
			CheckAndDisplayResults(scanMonitor);
			Thread.Sleep(200);
		}
	}

	private void FinalThreadScan(object sender, RunWorkerCompletedEventArgs e)
	{
		FinalizeScanning();
	}

	private void getTreeCheckedRecursive(TreeNode treenode)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		foreach (TreeNode node in treenode.get_Nodes())
		{
			TreeNode val = node;
			if (val.get_Tag() is Category)
			{
				getTreeCheckedRecursive(val);
			}
			else if (val.get_Checked())
			{
				dorksToScan.Add(new SSelectedDork(val.get_Tag() as Dork, val));
			}
		}
	}

	private void RandomizeOrder(List<SSelectedDork> listofdorks)
	{
		Random random = new Random();
		int count = listofdorks.Count;
		SSelectedDork[] array = new SSelectedDork[count];
		int num = 0;
		do
		{
			int index = random.Next(listofdorks.Count);
			if (array[num].Dork == null)
			{
				ref SSelectedDork reference = ref array[num];
				reference = listofdorks[index];
				listofdorks.RemoveAt(index);
				num++;
			}
		}
		while (listofdorks.Count > 0);
		for (int i = 0; i < count; i++)
		{
			listofdorks.Add(array[i]);
		}
	}

	public void StopScanning()
	{
		if (inScanning)
		{
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, "Requesting to stop scan...");
			((ToolStripItem)StatusLabel).set_Text(mResCancel);
			((Control)this).Update();
			backgroundScan.CancelAsync();
		}
		else
		{
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceError, "Error: StopScanning() without active scan.");
		}
	}

	private void scanMarkedButton_Click(object sender, EventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Invalid comparison between Unknown and I4
		dorksToScan = new List<SSelectedDork>();
		getTreeCheckedRecursive(tvwDorks.get_Nodes().get_Item(0));
		if (dorksToScan.Count > 1 && Settings.Default.RandomScanOrder)
		{
			RandomizeOrder(dorksToScan);
		}
		if (dorksToScan.Count == 0)
		{
			if (SelectedDork.Dork != null)
			{
				singleScan();
			}
			else
			{
				MessageBox.Show(rm.GetString("RES_E_SELECTDORK"));
			}
			return;
		}
		if (Settings.Default.WarnScan < dorksToScan.Count && Settings.Default.WarnScan != 0)
		{
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceWarning, Settings.Default.WarnScan, "Mass scan, count of dorks exceeds");
			string text = string.Format(rm.GetString("RES_W_LARGESCAN"), dorksToScan.Count.ToString());
			if ((int)MessageBox.Show(text, rm.GetString("RES_LARGSCAN"), (MessageBoxButtons)1, (MessageBoxIcon)48) != 1)
			{
				return;
			}
		}
		InitializeScanning();
	}

	private void stopScanButton_Click(object sender, EventArgs e)
	{
		StopScanning();
	}

	public GScanForm()
	{
		InitializeComponent();
		Control.set_CheckForIllegalCrossThreadCalls(false);
		TextAreaTraceListerner listener = new TextAreaTraceListerner(ConsoleTextBox);
		System.Diagnostics.Trace.Listeners.Add(listener);
		GoolagScanner.Debug.Trace.TraceGoolag.Level = (TraceLevel)Settings.Default.TraceLevel;
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceError, Assembly.GetExecutingAssembly().GetName().Version!.ToString(), "Welcome to GoolagScanner! Version");
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceError, "-= CULT OF THE DEAD COW 2008 =-");
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceError, Environment.OSVersion.VersionString, "OS");
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceError, Environment.Version, "CLR");
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		rm = new ResourceManager("GoolagScanner.Properties.Resources", executingAssembly);
		((ToolStripItem)pasteToolStripMenuItem).set_Visible(false);
		((ToolStripItem)printToolStripButton).set_Visible(false);
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, "Attempting to load dork-file.");
		if (!loadDorkFile(getDataPathFile(Settings.Default.DorkFile), dorkList, DorkCategories))
		{
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceError, "Failed to load dork-file. Exiting.");
			Application.Exit();
		}
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, "Sorting dorks.");
		dorkList.Sort(null);
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, "Building dork-tree.");
		tvw_FillTree();
		SetTreeCategoriesCount();
		mResCancel = rm.GetString("RES_CANCEL");
		mResScanning = rm.GetString("RES_SCANNING");
		mResReady = rm.GetString("RES_READY");
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceError, "Gathering proxy-settings.");
		HttpSimpleGet.Proxy = new Proxify().GetProxy();
		updateUIStates(isModified: false);
		if (Program.Splash_cDc != null)
		{
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, "Closing splash.");
			Thread.Sleep(2900);
			Program.Splash_Goolag = new Splash(285, 114, Resources.gscansplashd, 0.029, 0.034, 470);
			((Control)Program.Splash_Goolag).Show();
			Thread.Sleep(3000);
			((Form)Program.Splash_cDc).Close();
		}
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceInfo, "Initialisation completed.");
	}

	private void formLoad(object sender, EventArgs e)
	{
		RealTitleText = ((Control)this).get_Text();
		SetScannerTitle();
		((ToolStripItem)StatusLabel).set_Text(mResReady);
	}

	private void formShown(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Settings.Default.ShowAboutAtStart)
		{
			((Control)this).Update();
			Thread.Sleep(250);
			Application.DoEvents();
			About about = new About();
			((Form)about).ShowDialog();
		}
		if (Program.Splash_Goolag != null)
		{
			((Component)(object)Program.Splash_Goolag).Dispose();
		}
		((ToolStripControlHost)scanHostTextBox).Focus();
	}

	private void SetScannerTitle()
	{
		((Control)this).set_Text(RealTitleText + "  -  (" + dorksLoaded + " " + rm.GetString("RES_DORKS_LOADED") + ")");
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, "Exiting GoolagScanner.");
		Application.Exit();
	}

	private string getDataPathFile(string fileName)
	{
		string[] array = new string[8]
		{
			OSUtils.getApplicationPath(),
			"..",
			null,
			null,
			null,
			null,
			null,
			null
		};
		char directorySeparatorChar = Path.DirectorySeparatorChar;
		array[2] = directorySeparatorChar.ToString();
		array[3] = "..";
		char directorySeparatorChar2 = Path.DirectorySeparatorChar;
		array[4] = directorySeparatorChar2.ToString();
		array[5] = Settings.Default.DataPath;
		char directorySeparatorChar3 = Path.DirectorySeparatorChar;
		array[6] = directorySeparatorChar3.ToString();
		array[7] = fileName;
		return string.Concat(array);
	}

	private bool loadDorkFile(string DorkFile, ArrayList DorkList, Categories DorkCates)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		XmlDorkSet xmlDorkSet = new XmlDorkSet(DorkList, DorkCates);
		try
		{
			xmlDorkSet.Open(DorkFile);
		}
		catch (FileNotFoundException ex)
		{
			MessageBox.Show(rm.GetString("RES_E_OPENFILE") + Environment.NewLine + ex.Message, DorkFile, (MessageBoxButtons)0, (MessageBoxIcon)48);
			return false;
		}
		catch (XmlException ex2)
		{
			MessageBox.Show(rm.GetString("RES_E_XMLINCORRECT") + Environment.NewLine + ex2.Message, DorkFile, (MessageBoxButtons)0, (MessageBoxIcon)16);
			return false;
		}
		catch (Exception ex3)
		{
			MessageBox.Show(rm.GetString("RES_E_GENERIC") + Environment.NewLine + ex3.Message, DorkFile, (MessageBoxButtons)0, (MessageBoxIcon)16);
			return false;
		}
		dorksLoaded += xmlDorkSet.Count;
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceInfo, xmlDorkSet.Count, "Successful loaded dorks");
		return true;
	}

	private void formatDorkToRichText(Dork _dork)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		FontStyle style = richTextBox1.get_SelectionFont().get_Style();
		((TextBoxBase)richTextBox1).Clear();
		richTextBox1.set_SelectionFont(new Font(richTextBox1.get_SelectionFont(), (FontStyle)1));
		((TextBoxBase)richTextBox1).AppendText(_dork.Title + Environment.NewLine);
		richTextBox1.set_SelectionFont(new Font(richTextBox1.get_SelectionFont(), (FontStyle)2));
		((TextBoxBase)richTextBox1).AppendText(_dork.Query + Environment.NewLine + Environment.NewLine);
		richTextBox1.set_SelectionFont(new Font(richTextBox1.get_SelectionFont(), style));
		((TextBoxBase)richTextBox1).AppendText(_dork.Comment);
	}

	private void scanButton_Click(object sender, EventArgs e)
	{
		if (SelectedDork.Dork != null)
		{
			singleScan();
		}
	}

	private void updateScanButtons()
	{
		((ToolStripItem)scanButton).set_Enabled(!inScanning);
		((ToolStripItem)scanToolStripMenuItem).set_Enabled(!inScanning);
		((ToolStripItem)EditScanMenuItem).set_Enabled(!inScanning);
		((ToolStripItem)scanHostTextBox).set_Enabled(!inScanning);
	}

	private void newToolStripButton_Click(object sender, EventArgs e)
	{
		resultListView.get_Items().Clear();
		setTreeNodeRecursive(tvwDorks.get_Nodes().get_Item(0), checkedState: false);
		updateUIStates(isModified: true);
	}

	private void updateUIStates(bool isModified)
	{
		bool flag = resultListView.get_Items().get_Count() > 0;
		bool flag2 = resultListView.get_SelectedItems().get_Count() > 0;
		bool enabled = resultListView.get_SelectedItems().get_Count() == 1;
		resultModified = isModified;
		((ToolStripItem)saveToolStripButton).set_Enabled(resultModified && flag);
		((ToolStripItem)saveAsToolStripMenuItem).set_Enabled(flag);
		((ToolStripItem)saveToolStripMenuItem).set_Enabled(resultModified && flag);
		((ToolStripItem)cutToolStripButton).set_Enabled(flag2);
		((ToolStripItem)cutToolStripMenuItem).set_Enabled(flag2);
		ToolStripButton obj = copyToolStripButton;
		bool enabled2;
		((ToolStripItem)copyToolStripMenuItem).set_Enabled(enabled2 = flag2);
		((ToolStripItem)obj).set_Enabled(enabled2);
		((ToolStripItem)selectAllToolStripMenuItem).set_Enabled(flag);
		((ToolStripItem)clearResultsToolStripMenuItem).set_Enabled(flag);
		((ToolStripItem)ClearButton).set_Enabled(flag);
		((ToolStripItem)copyToClpMenuItem).set_Enabled(flag2);
		((ToolStripItem)openInBrowserToolStripMenuItem).set_Enabled(enabled);
		((ToolStripItem)scanMoreFromHereStrip).set_Enabled(enabled);
		((ToolStripItem)ClearErrorsStrip).set_Enabled(flag);
		((ToolStripItem)showLeftStrip).set_Enabled(enabled);
		((ToolStripItem)ShowErrorStrip).set_Enabled(enabled);
	}

	private void helpToolStripButton_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		About about = new About();
		((Form)about).ShowDialog();
	}

	private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		Options options = new Options();
		if ((int)((Form)options).ShowDialog() != 2)
		{
			HttpSimpleGet.Proxy = new Proxify().GetProxy();
		}
	}

	private void openToolStripButton_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)openDorkFileDialog).ShowDialog() != 1)
		{
			return;
		}
		string fileName = ((FileDialog)openDorkFileDialog).get_FileName();
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceInfo, fileName, "Opening dork file ");
		DorkCategories = new Categories();
		dorkList = new ArrayList();
		if (loadDorkFile(fileName, dorkList, DorkCategories))
		{
			foreach (Category dorkCategory in DorkCategories)
			{
				System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, dorkCategory.Text, "Got new category");
				AddCategoryToTreeEx(tvwDorks.get_Nodes().get_Item(0), dorkCategory);
			}
			AddDorksToCatTree(userdork: true);
			SetScannerTitle();
			SetTreeCategoriesCount();
			((Control)this).Update();
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, "Loading completed.");
		}
		else
		{
			System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceError, "Loading failed.");
		}
	}

	private void ClearButton_Click(object sender, EventArgs e)
	{
		resultListView.get_Items().Clear();
		updateUIStates(isModified: true);
	}

	private void HostScan_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			scanMarkedButton_Click(sender, (EventArgs)(object)e);
		}
	}

	private void EditScanMenuItem_Click(object sender, EventArgs e)
	{
		if (SelectedDork.Dork != null)
		{
			EditDorkScan editDorkScan = new EditDorkScan(SelectedDork, singleScan);
			((Control)editDorkScan).Show();
		}
	}

	private void saveToolStripButton_Click(object sender, EventArgs e)
	{
		SaveResultsAs();
	}

	private void saveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (resultModified)
		{
			if (string.IsNullOrEmpty(strFile))
			{
				SaveResultsAs();
			}
			else
			{
				SaveToFile();
			}
		}
	}

	private bool SaveResultsAs()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		if (strFile.Trim() != "" && strFile != null)
		{
			((FileDialog)saveResultsFileDialog).set_FileName(strFile);
		}
		if ((int)((CommonDialog)saveResultsFileDialog).ShowDialog() == 1)
		{
			strFile = ((FileDialog)saveResultsFileDialog).get_FileName();
			return SaveToFile();
		}
		return false;
	}

	private bool SaveToFile()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			StreamWriter streamWriter = new StreamWriter(strFile, append: false);
			foreach (ListViewItem item in resultListView.get_Items())
			{
				ListViewItem val = item;
				string text = val.get_SubItems().get_Item(2).get_Text();
				string text2 = val.get_SubItems().get_Item(1).get_Text();
				streamWriter.WriteLine(text2 + "\t\t\t" + text);
			}
			streamWriter.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			return false;
		}
		resultModified = false;
		return true;
	}

	private void resultColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (inScanning)
		{
			return;
		}
		if (e.get_Column() == lastSortedColumn)
		{
			if ((int)resultListView.get_Sorting() == 1)
			{
				resultListView.set_Sorting((SortOrder)2);
				resultListView.set_ListViewItemSorter((IComparer)new ListViewItemComparerDesc(e.get_Column()));
			}
			else
			{
				resultListView.set_Sorting((SortOrder)1);
				resultListView.set_ListViewItemSorter((IComparer)new ListViewItemComparer(e.get_Column()));
			}
		}
		else
		{
			resultListView.set_Sorting((SortOrder)1);
			lastSortedColumn = e.get_Column();
		}
	}

	private void resultList_DoubleClick(object sender, EventArgs e)
	{
		if (resultListView.get_SelectedItems().get_Count() != 1)
		{
			return;
		}
		DorkDone dorkDone = (DorkDone)resultListView.get_SelectedItems().get_Item(0).get_Tag();
		if (dorkDone.ScanResult != 2 && dorkDone.ScanResult != 4)
		{
			if (dorkDone.ScanResult == 3)
			{
				ShowErrorStrip_Click(sender, e);
			}
		}
		else
		{
			openInBrowserToolStripMenuItem_Click(sender, e);
		}
	}

	private void resultSelectionChanged(object sender, EventArgs e)
	{
		bool flag = resultListView.get_SelectedItems().get_Count() > 0;
		bool flag2 = resultListView.get_SelectedItems().get_Count() == 1;
		ToolStripButton obj = cutToolStripButton;
		bool enabled;
		((ToolStripItem)cutToolStripMenuItem).set_Enabled(enabled = flag);
		((ToolStripItem)obj).set_Enabled(enabled);
		ToolStripButton obj2 = copyToolStripButton;
		bool enabled2;
		((ToolStripItem)copyToolStripMenuItem).set_Enabled(enabled2 = flag);
		((ToolStripItem)obj2).set_Enabled(enabled2);
		((ToolStripItem)copyToClpMenuItem).set_Enabled(flag);
		((ToolStripItem)openInBrowserToolStripMenuItem).set_Enabled(flag2);
		((ToolStripItem)showLeftStrip).set_Enabled(flag2);
		if (flag2)
		{
			if (resultListView.get_SelectedItems().get_Item(0).get_Tag() is DorkDone dorkDone)
			{
				bool flag3 = dorkDone.ScanResult == 2;
				((ToolStripItem)ShowErrorStrip).set_Enabled(dorkDone.ScanResult == 3);
				((ToolStripItem)scanMoreFromHereStrip).set_Enabled(dorkDone.NextPage != 0 && flag3);
				((ToolStripItem)openInBrowserToolStripMenuItem).set_Enabled(flag3);
				formatDorkToRichText(dorkDone);
			}
		}
		else
		{
			((ToolStripItem)ShowErrorStrip).set_Enabled(false);
			((ToolStripItem)openInBrowserToolStripMenuItem).set_Enabled(false);
		}
	}

	private void openInBrowserToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (resultListView.get_SelectedItems().get_Count() > 0)
		{
			string text = resultListView.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(2)
				.get_Text();
			OSUtils.OpenInBrowser(text);
		}
	}

	private void showLeftStrip_Click(object sender, EventArgs e)
	{
		((Control)tvwDorks).Focus();
		DorkDone dorkDone = (DorkDone)resultListView.get_SelectedItems().get_Item(0).get_Tag();
		TreeNode lastNode = dorkDone.LastNode;
		lastNode.Expand();
		lastNode.EnsureVisible();
		tvwDorks.set_SelectedNode(lastNode);
	}

	private void scanMoreFromHereStrip_Click(object sender, EventArgs e)
	{
		DorkDone dorkDone = (DorkDone)resultListView.get_SelectedItems().get_Item(0).get_Tag();
		SelectedDork.Dork = dorkDone;
		SelectedDork.TreeNode = dorkDone.LastNode;
		SelectedDork.NextPage = dorkDone.NextPage;
		singleScan();
	}

	private void ShowErrorStrip_Click(object sender, EventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DorkDone dorkDone = (DorkDone)resultListView.get_SelectedItems().get_Item(0).get_Tag();
		MessageBox.Show(dorkDone.ErrorMessage, rm.GetString("RES_E_SCANERROR"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private void ClearErrorsStrip_Click(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		foreach (ListViewItem item in resultListView.get_Items())
		{
			ListViewItem val = item;
			DorkDone dorkDone = (DorkDone)val.get_Tag();
			if (dorkDone.ScanResult != 2)
			{
				resultListView.get_Items().Remove(val);
			}
		}
	}

	private void RescanMenuItem_Click(object sender, EventArgs e)
	{
		DorkDone dorkDone = (DorkDone)resultListView.get_SelectedItems().get_Item(0).get_Tag();
		SelectedDork.Dork = dorkDone;
		SelectedDork.TreeNode = dorkDone.LastNode;
		SelectedDork.NextPage = 0;
		singleScan();
	}

	private void ResetStatus()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		foreach (ListViewItem item in resultListView.get_Items())
		{
			ListViewItem val = item;
			if (val.get_ImageIndex() == 1)
			{
				val.set_ImageIndex(5);
				val.get_SubItems().get_Item(0).set_Text(rm.GetString("RES_CANCELSCAN"));
			}
		}
	}

	private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)resultListView).Focus();
		for (int i = 0; i < resultListView.get_Items().get_Count(); i++)
		{
			resultListView.get_Items().get_Item(i).set_Selected(true);
		}
	}

	private void copyToolStripButton_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		string text = "";
		foreach (ListViewItem selectedItem in resultListView.get_SelectedItems())
		{
			ListViewItem val = selectedItem;
			string text2 = val.get_SubItems().get_Item(1).get_Text();
			string text3 = val.get_SubItems().get_Item(2).get_Text();
			string text4 = text;
			text = text4 + text2 + "\t\t\t" + text3 + Environment.NewLine;
		}
		Clipboard.SetDataObject((object)text);
	}

	private void cutToolStripButton_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		string text = "";
		foreach (ListViewItem selectedItem in resultListView.get_SelectedItems())
		{
			ListViewItem val = selectedItem;
			string text2 = val.get_SubItems().get_Item(1).get_Text();
			string text3 = val.get_SubItems().get_Item(2).get_Text();
			string text4 = text;
			text = text4 + text2 + "\t\t\t" + text3 + Environment.NewLine;
			resultListView.get_Items().Remove(val);
		}
		Clipboard.SetDataObject((object)text);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_1615: Unknown result type (might be due to invalid IL or missing references)
		//IL_161f: Expected O, but got Unknown
		//IL_1985: Unknown result type (might be due to invalid IL or missing references)
		//IL_198f: Expected O, but got Unknown
		//IL_19d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19dd: Expected O, but got Unknown
		//IL_1c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1d: Expected O, but got Unknown
		//IL_1c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4b: Expected O, but got Unknown
		//IL_1c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c62: Expected O, but got Unknown
		//IL_1c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GScanForm));
		menuStrip1 = new MenuStrip();
		fileToolStripMenuItem = new ToolStripMenuItem();
		newToolStripMenuItem = new ToolStripMenuItem();
		openToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator = new ToolStripSeparator();
		saveToolStripMenuItem = new ToolStripMenuItem();
		saveAsToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator1 = new ToolStripSeparator();
		exitToolStripMenuItem = new ToolStripMenuItem();
		editToolStripMenuItem = new ToolStripMenuItem();
		cutToolStripMenuItem = new ToolStripMenuItem();
		copyToolStripMenuItem = new ToolStripMenuItem();
		pasteToolStripMenuItem = new ToolStripMenuItem();
		ClearResultsMenuItem = new ToolStripMenuItem();
		toolStripSeparator15 = new ToolStripSeparator();
		FindMenuItem1 = new ToolStripMenuItem();
		toolStripSeparator4 = new ToolStripSeparator();
		selectAllToolStripMenuItem = new ToolStripMenuItem();
		scanToolStripMenuItem1 = new ToolStripMenuItem();
		scanMarkedToolStripMenuItem = new ToolStripMenuItem();
		stopScanToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator17 = new ToolStripSeparator();
		EditScanMenuItem = new ToolStripMenuItem();
		toolsToolStripMenuItem = new ToolStripMenuItem();
		optionsToolStripMenuItem = new ToolStripMenuItem();
		helpToolStripMenuItem = new ToolStripMenuItem();
		aboutToolStripMenuItem = new ToolStripMenuItem();
		statusStrip1 = new StatusStrip();
		StatusLabel = new ToolStripStatusLabel();
		toolStrip1 = new ToolStrip();
		newToolStripButton = new ToolStripButton();
		openToolStripButton = new ToolStripButton();
		saveToolStripButton = new ToolStripButton();
		printToolStripButton = new ToolStripButton();
		toolStripSeparator6 = new ToolStripSeparator();
		cutToolStripButton = new ToolStripButton();
		copyToolStripButton = new ToolStripButton();
		ClearButton = new ToolStripButton();
		toolStripSeparator14 = new ToolStripSeparator();
		helpToolStripButton = new ToolStripButton();
		dorkMenuStrip = new ContextMenuStrip(components);
		scanToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator3 = new ToolStripSeparator();
		setMarkedMenuItem = new ToolStripMenuItem();
		setUnmarkedMenuItem = new ToolStripMenuItem();
		toolStripSeparator7 = new ToolStripSeparator();
		markallMenuItem3 = new ToolStripMenuItem();
		unmarkallMenuItem = new ToolStripMenuItem();
		toolStripSeparator16 = new ToolStripSeparator();
		OpenInBrowser = new ToolStripMenuItem();
		toolStripSeparator12 = new ToolStripSeparator();
		propertiesToolStripMenuItem = new ToolStripMenuItem();
		resultsMenuStrip = new ContextMenuStrip(components);
		RescanMenuItem = new ToolStripMenuItem();
		scanMoreFromHereStrip = new ToolStripMenuItem();
		toolStripSeparator5 = new ToolStripSeparator();
		copyToClpMenuItem = new ToolStripMenuItem();
		openInBrowserToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator13 = new ToolStripSeparator();
		showLeftStrip = new ToolStripMenuItem();
		toolStripSeparator10 = new ToolStripSeparator();
		ShowErrorStrip = new ToolStripMenuItem();
		ClearErrorsStrip = new ToolStripMenuItem();
		clearResultsToolStripMenuItem = new ToolStripMenuItem();
		openDorkFile = new OpenFileDialog();
		saveResultsFileDialog = new SaveFileDialog();
		scanToolStrip = new ToolStrip();
		toolStripLabel1 = new ToolStripLabel();
		scanHostTextBox = new ToolStripTextBox();
		toolStripSeparator11 = new ToolStripSeparator();
		scanButton = new ToolStripButton();
		toolStripSeparator9 = new ToolStripSeparator();
		stopScanButton = new ToolStripButton();
		toolStripSeparator8 = new ToolStripSeparator();
		splitContainer2 = new SplitContainer();
		groupBox2 = new GroupBox();
		richTextBox1 = new RichTextBox();
		splitContainer3 = new SplitContainer();
		groupBox3 = new GroupBox();
		resultListView = new ListView();
		columnHeader1 = new ColumnHeader();
		columnHeader2 = new ColumnHeader();
		columnHeader3 = new ColumnHeader();
		resultImageList = new ImageList(components);
		tabControl1 = new TabControl();
		tabPage2 = new TabPage();
		ConsoleTextBox = new TextBox();
		groupBox1 = new GroupBox();
		tvwDorks = new TreeView();
		treeImageList = new ImageList(components);
		splitContainer1 = new SplitContainer();
		openDorkFileDialog = new OpenFileDialog();
		backgroundScan = new BackgroundWorker();
		progressBar1 = new ProgressBar();
		backgroundAnim = new BackgroundWorker();
		pictureMenuAnim = new PictureBox();
		((Control)menuStrip1).SuspendLayout();
		((Control)statusStrip1).SuspendLayout();
		((Control)toolStrip1).SuspendLayout();
		((Control)dorkMenuStrip).SuspendLayout();
		((Control)resultsMenuStrip).SuspendLayout();
		((Control)scanToolStrip).SuspendLayout();
		((Control)splitContainer2.get_Panel1()).SuspendLayout();
		((Control)splitContainer2.get_Panel2()).SuspendLayout();
		((Control)splitContainer2).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)splitContainer3.get_Panel1()).SuspendLayout();
		((Control)splitContainer3.get_Panel2()).SuspendLayout();
		((Control)splitContainer3).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage2).SuspendLayout();
		((Control)groupBox1).SuspendLayout();
		((Control)splitContainer1.get_Panel1()).SuspendLayout();
		((Control)splitContainer1.get_Panel2()).SuspendLayout();
		((Control)splitContainer1).SuspendLayout();
		((ISupportInitialize)pictureMenuAnim).BeginInit();
		((Control)this).SuspendLayout();
		((ToolStrip)menuStrip1).set_BackColor(SystemColors.Control);
		componentResourceManager.ApplyResources(menuStrip1, "menuStrip1");
		((ToolStrip)menuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)fileToolStripMenuItem,
			(ToolStripItem)editToolStripMenuItem,
			(ToolStripItem)scanToolStripMenuItem1,
			(ToolStripItem)toolsToolStripMenuItem,
			(ToolStripItem)helpToolStripMenuItem
		});
		((ToolStrip)menuStrip1).set_LayoutStyle((ToolStripLayoutStyle)1);
		((Control)menuStrip1).set_Name("menuStrip1");
		menuStrip1.set_ShowItemToolTips(true);
		((ToolStripDropDownItem)fileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[7]
		{
			(ToolStripItem)newToolStripMenuItem,
			(ToolStripItem)openToolStripMenuItem,
			(ToolStripItem)toolStripSeparator,
			(ToolStripItem)saveToolStripMenuItem,
			(ToolStripItem)saveAsToolStripMenuItem,
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)exitToolStripMenuItem
		});
		((ToolStripItem)fileToolStripMenuItem).set_Name("fileToolStripMenuItem");
		componentResourceManager.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
		componentResourceManager.ApplyResources(newToolStripMenuItem, "newToolStripMenuItem");
		((ToolStripItem)newToolStripMenuItem).set_Name("newToolStripMenuItem");
		((ToolStripItem)newToolStripMenuItem).add_Click((EventHandler)newToolStripButton_Click);
		componentResourceManager.ApplyResources(openToolStripMenuItem, "openToolStripMenuItem");
		((ToolStripItem)openToolStripMenuItem).set_Name("openToolStripMenuItem");
		((ToolStripItem)openToolStripMenuItem).add_Click((EventHandler)openToolStripButton_Click);
		((ToolStripItem)toolStripSeparator).set_Name("toolStripSeparator");
		componentResourceManager.ApplyResources(toolStripSeparator, "toolStripSeparator");
		componentResourceManager.ApplyResources(saveToolStripMenuItem, "saveToolStripMenuItem");
		((ToolStripItem)saveToolStripMenuItem).set_Name("saveToolStripMenuItem");
		((ToolStripItem)saveToolStripMenuItem).add_Click((EventHandler)saveToolStripMenuItem_Click);
		((ToolStripItem)saveAsToolStripMenuItem).set_Name("saveAsToolStripMenuItem");
		componentResourceManager.ApplyResources(saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
		((ToolStripItem)saveAsToolStripMenuItem).add_Click((EventHandler)saveToolStripButton_Click);
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		componentResourceManager.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		componentResourceManager.ApplyResources(exitToolStripMenuItem, "exitToolStripMenuItem");
		((ToolStripItem)exitToolStripMenuItem).add_Click((EventHandler)exitToolStripMenuItem_Click);
		((ToolStripDropDownItem)editToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)cutToolStripMenuItem,
			(ToolStripItem)copyToolStripMenuItem,
			(ToolStripItem)pasteToolStripMenuItem,
			(ToolStripItem)ClearResultsMenuItem,
			(ToolStripItem)toolStripSeparator15,
			(ToolStripItem)FindMenuItem1,
			(ToolStripItem)toolStripSeparator4,
			(ToolStripItem)selectAllToolStripMenuItem
		});
		((ToolStripItem)editToolStripMenuItem).set_Name("editToolStripMenuItem");
		componentResourceManager.ApplyResources(editToolStripMenuItem, "editToolStripMenuItem");
		componentResourceManager.ApplyResources(cutToolStripMenuItem, "cutToolStripMenuItem");
		((ToolStripItem)cutToolStripMenuItem).set_Name("cutToolStripMenuItem");
		((ToolStripItem)cutToolStripMenuItem).add_Click((EventHandler)cutToolStripButton_Click);
		componentResourceManager.ApplyResources(copyToolStripMenuItem, "copyToolStripMenuItem");
		((ToolStripItem)copyToolStripMenuItem).set_Name("copyToolStripMenuItem");
		((ToolStripItem)copyToolStripMenuItem).add_Click((EventHandler)copyToolStripButton_Click);
		componentResourceManager.ApplyResources(pasteToolStripMenuItem, "pasteToolStripMenuItem");
		((ToolStripItem)pasteToolStripMenuItem).set_Name("pasteToolStripMenuItem");
		((ToolStripItem)ClearResultsMenuItem).set_Name("ClearResultsMenuItem");
		componentResourceManager.ApplyResources(ClearResultsMenuItem, "ClearResultsMenuItem");
		((ToolStripItem)ClearResultsMenuItem).add_Click((EventHandler)ClearButton_Click);
		((ToolStripItem)toolStripSeparator15).set_Name("toolStripSeparator15");
		componentResourceManager.ApplyResources(toolStripSeparator15, "toolStripSeparator15");
		((ToolStripItem)FindMenuItem1).set_Name("FindMenuItem1");
		componentResourceManager.ApplyResources(FindMenuItem1, "FindMenuItem1");
		((ToolStripItem)FindMenuItem1).add_Click((EventHandler)FindMenuItem1_Click);
		((ToolStripItem)toolStripSeparator4).set_Name("toolStripSeparator4");
		componentResourceManager.ApplyResources(toolStripSeparator4, "toolStripSeparator4");
		((ToolStripItem)selectAllToolStripMenuItem).set_Name("selectAllToolStripMenuItem");
		componentResourceManager.ApplyResources(selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
		((ToolStripItem)selectAllToolStripMenuItem).add_Click((EventHandler)selectAllToolStripMenuItem_Click);
		((ToolStripDropDownItem)scanToolStripMenuItem1).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)scanMarkedToolStripMenuItem,
			(ToolStripItem)stopScanToolStripMenuItem,
			(ToolStripItem)toolStripSeparator17,
			(ToolStripItem)EditScanMenuItem
		});
		((ToolStripItem)scanToolStripMenuItem1).set_Name("scanToolStripMenuItem1");
		componentResourceManager.ApplyResources(scanToolStripMenuItem1, "scanToolStripMenuItem1");
		((ToolStripItem)scanMarkedToolStripMenuItem).set_Name("scanMarkedToolStripMenuItem");
		componentResourceManager.ApplyResources(scanMarkedToolStripMenuItem, "scanMarkedToolStripMenuItem");
		((ToolStripItem)scanMarkedToolStripMenuItem).add_Click((EventHandler)scanMarkedButton_Click);
		((ToolStripItem)stopScanToolStripMenuItem).set_Name("stopScanToolStripMenuItem");
		componentResourceManager.ApplyResources(stopScanToolStripMenuItem, "stopScanToolStripMenuItem");
		((ToolStripItem)stopScanToolStripMenuItem).add_Click((EventHandler)stopScanButton_Click);
		((ToolStripItem)toolStripSeparator17).set_Name("toolStripSeparator17");
		componentResourceManager.ApplyResources(toolStripSeparator17, "toolStripSeparator17");
		((ToolStripItem)EditScanMenuItem).set_Name("EditScanMenuItem");
		componentResourceManager.ApplyResources(EditScanMenuItem, "EditScanMenuItem");
		((ToolStripItem)EditScanMenuItem).add_Click((EventHandler)EditScanMenuItem_Click);
		((ToolStripDropDownItem)toolsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)optionsToolStripMenuItem });
		((ToolStripItem)toolsToolStripMenuItem).set_Name("toolsToolStripMenuItem");
		componentResourceManager.ApplyResources(toolsToolStripMenuItem, "toolsToolStripMenuItem");
		((ToolStripItem)optionsToolStripMenuItem).set_Name("optionsToolStripMenuItem");
		componentResourceManager.ApplyResources(optionsToolStripMenuItem, "optionsToolStripMenuItem");
		((ToolStripItem)optionsToolStripMenuItem).add_Click((EventHandler)optionsToolStripMenuItem_Click);
		((ToolStripDropDownItem)helpToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)aboutToolStripMenuItem });
		((ToolStripItem)helpToolStripMenuItem).set_Name("helpToolStripMenuItem");
		componentResourceManager.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
		componentResourceManager.ApplyResources(aboutToolStripMenuItem, "aboutToolStripMenuItem");
		((ToolStripItem)aboutToolStripMenuItem).set_Name("aboutToolStripMenuItem");
		((ToolStripItem)aboutToolStripMenuItem).add_Click((EventHandler)helpToolStripButton_Click);
		((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)StatusLabel });
		componentResourceManager.ApplyResources(statusStrip1, "statusStrip1");
		((Control)statusStrip1).set_Name("statusStrip1");
		((ToolStripItem)StatusLabel).set_Name("StatusLabel");
		componentResourceManager.ApplyResources(StatusLabel, "StatusLabel");
		toolStrip1.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[10]
		{
			(ToolStripItem)newToolStripButton,
			(ToolStripItem)openToolStripButton,
			(ToolStripItem)saveToolStripButton,
			(ToolStripItem)printToolStripButton,
			(ToolStripItem)toolStripSeparator6,
			(ToolStripItem)cutToolStripButton,
			(ToolStripItem)copyToolStripButton,
			(ToolStripItem)ClearButton,
			(ToolStripItem)toolStripSeparator14,
			(ToolStripItem)helpToolStripButton
		});
		componentResourceManager.ApplyResources(toolStrip1, "toolStrip1");
		((Control)toolStrip1).set_Name("toolStrip1");
		((ToolStripItem)newToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		componentResourceManager.ApplyResources(newToolStripButton, "newToolStripButton");
		((ToolStripItem)newToolStripButton).set_Name("newToolStripButton");
		((ToolStripItem)newToolStripButton).add_Click((EventHandler)newToolStripButton_Click);
		((ToolStripItem)openToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		componentResourceManager.ApplyResources(openToolStripButton, "openToolStripButton");
		((ToolStripItem)openToolStripButton).set_Name("openToolStripButton");
		((ToolStripItem)openToolStripButton).add_Click((EventHandler)openToolStripButton_Click);
		((ToolStripItem)saveToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		componentResourceManager.ApplyResources(saveToolStripButton, "saveToolStripButton");
		((ToolStripItem)saveToolStripButton).set_Name("saveToolStripButton");
		((ToolStripItem)saveToolStripButton).add_Click((EventHandler)saveToolStripMenuItem_Click);
		((ToolStripItem)printToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		componentResourceManager.ApplyResources(printToolStripButton, "printToolStripButton");
		((ToolStripItem)printToolStripButton).set_Name("printToolStripButton");
		((ToolStripItem)toolStripSeparator6).set_Name("toolStripSeparator6");
		componentResourceManager.ApplyResources(toolStripSeparator6, "toolStripSeparator6");
		((ToolStripItem)cutToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		componentResourceManager.ApplyResources(cutToolStripButton, "cutToolStripButton");
		((ToolStripItem)cutToolStripButton).set_Name("cutToolStripButton");
		((ToolStripItem)cutToolStripButton).add_Click((EventHandler)cutToolStripButton_Click);
		((ToolStripItem)copyToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		componentResourceManager.ApplyResources(copyToolStripButton, "copyToolStripButton");
		((ToolStripItem)copyToolStripButton).set_Name("copyToolStripButton");
		((ToolStripItem)copyToolStripButton).add_Click((EventHandler)copyToolStripButton_Click);
		((ToolStripItem)ClearButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ClearButton).set_Image((Image)(object)Resources.eraser);
		componentResourceManager.ApplyResources(ClearButton, "ClearButton");
		((ToolStripItem)ClearButton).set_Name("ClearButton");
		((ToolStripItem)ClearButton).add_Click((EventHandler)ClearButton_Click);
		((ToolStripItem)toolStripSeparator14).set_Name("toolStripSeparator14");
		componentResourceManager.ApplyResources(toolStripSeparator14, "toolStripSeparator14");
		((ToolStripItem)helpToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		componentResourceManager.ApplyResources(helpToolStripButton, "helpToolStripButton");
		((ToolStripItem)helpToolStripButton).set_Name("helpToolStripButton");
		((ToolStripItem)helpToolStripButton).add_Click((EventHandler)helpToolStripButton_Click);
		((ToolStrip)dorkMenuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)scanToolStripMenuItem,
			(ToolStripItem)toolStripSeparator3,
			(ToolStripItem)setMarkedMenuItem,
			(ToolStripItem)setUnmarkedMenuItem,
			(ToolStripItem)toolStripSeparator7,
			(ToolStripItem)markallMenuItem3,
			(ToolStripItem)unmarkallMenuItem,
			(ToolStripItem)toolStripSeparator16,
			(ToolStripItem)OpenInBrowser,
			(ToolStripItem)toolStripSeparator12,
			(ToolStripItem)propertiesToolStripMenuItem
		});
		((Control)dorkMenuStrip).set_Name("dorkMenuStrip");
		componentResourceManager.ApplyResources(dorkMenuStrip, "dorkMenuStrip");
		((ToolStripItem)scanToolStripMenuItem).set_Name("scanToolStripMenuItem");
		componentResourceManager.ApplyResources(scanToolStripMenuItem, "scanToolStripMenuItem");
		((ToolStripItem)scanToolStripMenuItem).add_Click((EventHandler)scanButton_Click);
		((ToolStripItem)toolStripSeparator3).set_Name("toolStripSeparator3");
		componentResourceManager.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
		((ToolStripItem)setMarkedMenuItem).set_Image((Image)(object)Resources.greenball);
		componentResourceManager.ApplyResources(setMarkedMenuItem, "setMarkedMenuItem");
		((ToolStripItem)setMarkedMenuItem).set_Name("setMarkedMenuItem");
		((ToolStripItem)setMarkedMenuItem).add_Click((EventHandler)setMarkedMenuItem_Click);
		((ToolStripItem)setUnmarkedMenuItem).set_Image((Image)(object)Resources.greyball);
		componentResourceManager.ApplyResources(setUnmarkedMenuItem, "setUnmarkedMenuItem");
		((ToolStripItem)setUnmarkedMenuItem).set_Name("setUnmarkedMenuItem");
		((ToolStripItem)setUnmarkedMenuItem).add_Click((EventHandler)setUnmarkedMenuItem_Click);
		((ToolStripItem)toolStripSeparator7).set_Name("toolStripSeparator7");
		componentResourceManager.ApplyResources(toolStripSeparator7, "toolStripSeparator7");
		((ToolStripItem)markallMenuItem3).set_Name("markallMenuItem3");
		componentResourceManager.ApplyResources(markallMenuItem3, "markallMenuItem3");
		((ToolStripItem)markallMenuItem3).add_Click((EventHandler)markallMenuItem_Click);
		((ToolStripItem)unmarkallMenuItem).set_Name("unmarkallMenuItem");
		componentResourceManager.ApplyResources(unmarkallMenuItem, "unmarkallMenuItem");
		((ToolStripItem)unmarkallMenuItem).add_Click((EventHandler)unmarkallMenuItem_Click);
		((ToolStripItem)toolStripSeparator16).set_Name("toolStripSeparator16");
		componentResourceManager.ApplyResources(toolStripSeparator16, "toolStripSeparator16");
		((ToolStripItem)OpenInBrowser).set_Name("OpenInBrowser");
		componentResourceManager.ApplyResources(OpenInBrowser, "OpenInBrowser");
		((ToolStripItem)OpenInBrowser).add_Click((EventHandler)OpenInBrowser_Click);
		((ToolStripItem)toolStripSeparator12).set_Name("toolStripSeparator12");
		componentResourceManager.ApplyResources(toolStripSeparator12, "toolStripSeparator12");
		((ToolStripItem)propertiesToolStripMenuItem).set_Name("propertiesToolStripMenuItem");
		componentResourceManager.ApplyResources(propertiesToolStripMenuItem, "propertiesToolStripMenuItem");
		((ToolStripItem)propertiesToolStripMenuItem).add_Click((EventHandler)propertiesToolStripMenuItem_Click);
		((ToolStrip)resultsMenuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)RescanMenuItem,
			(ToolStripItem)scanMoreFromHereStrip,
			(ToolStripItem)toolStripSeparator5,
			(ToolStripItem)copyToClpMenuItem,
			(ToolStripItem)openInBrowserToolStripMenuItem,
			(ToolStripItem)toolStripSeparator13,
			(ToolStripItem)showLeftStrip,
			(ToolStripItem)toolStripSeparator10,
			(ToolStripItem)ShowErrorStrip,
			(ToolStripItem)ClearErrorsStrip,
			(ToolStripItem)clearResultsToolStripMenuItem
		});
		((Control)resultsMenuStrip).set_Name("resultsMenuStrip");
		componentResourceManager.ApplyResources(resultsMenuStrip, "resultsMenuStrip");
		((ToolStripItem)RescanMenuItem).set_Name("RescanMenuItem");
		componentResourceManager.ApplyResources(RescanMenuItem, "RescanMenuItem");
		((ToolStripItem)RescanMenuItem).add_Click((EventHandler)RescanMenuItem_Click);
		((ToolStripItem)scanMoreFromHereStrip).set_Name("scanMoreFromHereStrip");
		componentResourceManager.ApplyResources(scanMoreFromHereStrip, "scanMoreFromHereStrip");
		((ToolStripItem)scanMoreFromHereStrip).add_Click((EventHandler)scanMoreFromHereStrip_Click);
		((ToolStripItem)toolStripSeparator5).set_Name("toolStripSeparator5");
		componentResourceManager.ApplyResources(toolStripSeparator5, "toolStripSeparator5");
		((ToolStripItem)copyToClpMenuItem).set_Name("copyToClpMenuItem");
		componentResourceManager.ApplyResources(copyToClpMenuItem, "copyToClpMenuItem");
		((ToolStripItem)copyToClpMenuItem).add_Click((EventHandler)copyToolStripButton_Click);
		((ToolStripItem)openInBrowserToolStripMenuItem).set_Name("openInBrowserToolStripMenuItem");
		componentResourceManager.ApplyResources(openInBrowserToolStripMenuItem, "openInBrowserToolStripMenuItem");
		((ToolStripItem)openInBrowserToolStripMenuItem).add_Click((EventHandler)openInBrowserToolStripMenuItem_Click);
		((ToolStripItem)toolStripSeparator13).set_Name("toolStripSeparator13");
		componentResourceManager.ApplyResources(toolStripSeparator13, "toolStripSeparator13");
		((ToolStripItem)showLeftStrip).set_Name("showLeftStrip");
		componentResourceManager.ApplyResources(showLeftStrip, "showLeftStrip");
		((ToolStripItem)showLeftStrip).add_Click((EventHandler)showLeftStrip_Click);
		((ToolStripItem)toolStripSeparator10).set_Name("toolStripSeparator10");
		componentResourceManager.ApplyResources(toolStripSeparator10, "toolStripSeparator10");
		((ToolStripItem)ShowErrorStrip).set_Name("ShowErrorStrip");
		componentResourceManager.ApplyResources(ShowErrorStrip, "ShowErrorStrip");
		((ToolStripItem)ShowErrorStrip).add_Click((EventHandler)ShowErrorStrip_Click);
		((ToolStripItem)ClearErrorsStrip).set_Name("ClearErrorsStrip");
		componentResourceManager.ApplyResources(ClearErrorsStrip, "ClearErrorsStrip");
		((ToolStripItem)ClearErrorsStrip).add_Click((EventHandler)ClearErrorsStrip_Click);
		((ToolStripItem)clearResultsToolStripMenuItem).set_Name("clearResultsToolStripMenuItem");
		componentResourceManager.ApplyResources(clearResultsToolStripMenuItem, "clearResultsToolStripMenuItem");
		((ToolStripItem)clearResultsToolStripMenuItem).add_Click((EventHandler)ClearButton_Click);
		((FileDialog)openDorkFile).set_FileName("openFileDialog1");
		((FileDialog)saveResultsFileDialog).set_DefaultExt("txt");
		componentResourceManager.ApplyResources(saveResultsFileDialog, "saveResultsFileDialog");
		componentResourceManager.ApplyResources(scanToolStrip, "scanToolStrip");
		scanToolStrip.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[7]
		{
			(ToolStripItem)toolStripLabel1,
			(ToolStripItem)scanHostTextBox,
			(ToolStripItem)toolStripSeparator11,
			(ToolStripItem)scanButton,
			(ToolStripItem)toolStripSeparator9,
			(ToolStripItem)stopScanButton,
			(ToolStripItem)toolStripSeparator8
		});
		((Control)scanToolStrip).set_Name("scanToolStrip");
		((ToolStripItem)toolStripLabel1).set_Name("toolStripLabel1");
		componentResourceManager.ApplyResources(toolStripLabel1, "toolStripLabel1");
		((ToolStripItem)scanHostTextBox).set_BackColor(Color.FromArgb(255, 255, 192));
		scanHostTextBox.set_BorderStyle((BorderStyle)1);
		((ToolStripItem)scanHostTextBox).set_Name("scanHostTextBox");
		componentResourceManager.ApplyResources(scanHostTextBox, "scanHostTextBox");
		((ToolStripControlHost)scanHostTextBox).add_KeyDown(new KeyEventHandler(HostScan_KeyDown));
		((ToolStripItem)toolStripSeparator11).set_Name("toolStripSeparator11");
		componentResourceManager.ApplyResources(toolStripSeparator11, "toolStripSeparator11");
		((ToolStripItem)scanButton).set_BackColor(SystemColors.Control);
		componentResourceManager.ApplyResources(scanButton, "scanButton");
		((ToolStripItem)scanButton).set_ForeColor(SystemColors.ControlText);
		((ToolStripItem)scanButton).set_Name("scanButton");
		((ToolStripItem)scanButton).add_Click((EventHandler)scanMarkedButton_Click);
		((ToolStripItem)toolStripSeparator9).set_Name("toolStripSeparator9");
		componentResourceManager.ApplyResources(toolStripSeparator9, "toolStripSeparator9");
		((ToolStripItem)stopScanButton).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		componentResourceManager.ApplyResources(stopScanButton, "stopScanButton");
		((ToolStripItem)stopScanButton).set_Name("stopScanButton");
		((ToolStripItem)stopScanButton).add_Click((EventHandler)stopScanButton_Click);
		((ToolStripItem)toolStripSeparator8).set_Name("toolStripSeparator8");
		componentResourceManager.ApplyResources(toolStripSeparator8, "toolStripSeparator8");
		componentResourceManager.ApplyResources(splitContainer2, "splitContainer2");
		((Control)splitContainer2).set_Name("splitContainer2");
		((Control)splitContainer2.get_Panel1()).get_Controls().Add((Control)(object)groupBox2);
		((Control)splitContainer2.get_Panel2()).get_Controls().Add((Control)(object)splitContainer3);
		((Control)groupBox2).get_Controls().Add((Control)(object)richTextBox1);
		componentResourceManager.ApplyResources(groupBox2, "groupBox2");
		((Control)groupBox2).set_Name("groupBox2");
		groupBox2.set_TabStop(false);
		((Control)richTextBox1).set_BackColor(SystemColors.ControlLightLight);
		((Control)richTextBox1).set_Cursor(Cursors.get_Arrow());
		componentResourceManager.ApplyResources(richTextBox1, "richTextBox1");
		((Control)richTextBox1).set_Name("richTextBox1");
		((TextBoxBase)richTextBox1).set_ReadOnly(true);
		componentResourceManager.ApplyResources(splitContainer3, "splitContainer3");
		((Control)splitContainer3).set_Name("splitContainer3");
		((Control)splitContainer3.get_Panel1()).get_Controls().Add((Control)(object)groupBox3);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)tabControl1);
		((Control)groupBox3).get_Controls().Add((Control)(object)resultListView);
		componentResourceManager.ApplyResources(groupBox3, "groupBox3");
		((Control)groupBox3).set_Name("groupBox3");
		groupBox3.set_TabStop(false);
		resultListView.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { columnHeader1, columnHeader2, columnHeader3 });
		((Control)resultListView).set_ContextMenuStrip(resultsMenuStrip);
		componentResourceManager.ApplyResources(resultListView, "resultListView");
		resultListView.set_FullRowSelect(true);
		resultListView.set_HideSelection(false);
		((Control)resultListView).set_Name("resultListView");
		resultListView.set_SmallImageList(resultImageList);
		resultListView.set_UseCompatibleStateImageBehavior(false);
		resultListView.set_View((View)1);
		((Control)resultListView).add_DoubleClick((EventHandler)resultList_DoubleClick);
		resultListView.add_SelectedIndexChanged((EventHandler)resultSelectionChanged);
		resultListView.add_ColumnClick(new ColumnClickEventHandler(resultColumnClick));
		componentResourceManager.ApplyResources(columnHeader1, "columnHeader1");
		componentResourceManager.ApplyResources(columnHeader2, "columnHeader2");
		componentResourceManager.ApplyResources(columnHeader3, "columnHeader3");
		resultImageList.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("resultImageList.ImageStream"));
		resultImageList.set_TransparentColor(Color.Transparent);
		resultImageList.get_Images().SetKeyName(0, "ball-grey.png");
		resultImageList.get_Images().SetKeyName(1, "ball-orange.png");
		resultImageList.get_Images().SetKeyName(2, "ball-green.png");
		resultImageList.get_Images().SetKeyName(3, "ball-red.png");
		resultImageList.get_Images().SetKeyName(4, "ball-black.png");
		resultImageList.get_Images().SetKeyName(5, "ball-blue.png");
		componentResourceManager.ApplyResources(tabControl1, "tabControl1");
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage2);
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabPage2).get_Controls().Add((Control)(object)ConsoleTextBox);
		componentResourceManager.ApplyResources(tabPage2, "tabPage2");
		((Control)tabPage2).set_Name("tabPage2");
		tabPage2.set_UseVisualStyleBackColor(true);
		((Control)ConsoleTextBox).set_BackColor(SystemColors.ControlLightLight);
		componentResourceManager.ApplyResources(ConsoleTextBox, "ConsoleTextBox");
		((Control)ConsoleTextBox).set_Name("ConsoleTextBox");
		((TextBoxBase)ConsoleTextBox).set_ReadOnly(true);
		((Control)groupBox1).get_Controls().Add((Control)(object)tvwDorks);
		componentResourceManager.ApplyResources(groupBox1, "groupBox1");
		((Control)groupBox1).set_Name("groupBox1");
		groupBox1.set_TabStop(false);
		((Control)tvwDorks).set_BackColor(SystemColors.Window);
		tvwDorks.set_CheckBoxes(true);
		((Control)tvwDorks).set_ContextMenuStrip(dorkMenuStrip);
		componentResourceManager.ApplyResources(tvwDorks, "tvwDorks");
		tvwDorks.set_FullRowSelect(true);
		tvwDorks.set_HideSelection(false);
		tvwDorks.set_HotTracking(true);
		((Control)tvwDorks).set_Name("tvwDorks");
		tvwDorks.set_ShowNodeToolTips(true);
		tvwDorks.set_StateImageList(treeImageList);
		tvwDorks.add_AfterCheck(new TreeViewEventHandler(tvw_AfterCheck));
		((Control)tvwDorks).add_DoubleClick((EventHandler)tvw_DoubleClick);
		tvwDorks.add_AfterSelect(new TreeViewEventHandler(tvw_AfterSelect));
		((Control)tvwDorks).add_MouseMove(new MouseEventHandler(tvw_MouseMove));
		treeImageList.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("treeImageList.ImageStream"));
		treeImageList.set_TransparentColor(Color.Transparent);
		treeImageList.get_Images().SetKeyName(0, "greyball.bmp");
		treeImageList.get_Images().SetKeyName(1, "greenball.bmp");
		treeImageList.get_Images().SetKeyName(2, "redball.bmp");
		componentResourceManager.ApplyResources(splitContainer1, "splitContainer1");
		((Control)splitContainer1).set_Name("splitContainer1");
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)groupBox1);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)splitContainer2);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)scanToolStrip);
		componentResourceManager.ApplyResources(openDorkFileDialog, "openDorkFileDialog");
		backgroundScan.WorkerSupportsCancellation = true;
		backgroundScan.DoWork += doThreadScan;
		backgroundScan.RunWorkerCompleted += FinalThreadScan;
		componentResourceManager.ApplyResources(progressBar1, "progressBar1");
		progressBar1.set_MarqueeAnimationSpeed(0);
		((Control)progressBar1).set_Name("progressBar1");
		backgroundAnim.WorkerSupportsCancellation = true;
		backgroundAnim.DoWork += doThreadAnim;
		backgroundAnim.RunWorkerCompleted += FinalThreadAnim;
		componentResourceManager.ApplyResources(pictureMenuAnim, "pictureMenuAnim");
		((Control)pictureMenuAnim).set_BackColor(SystemColors.Control);
		pictureMenuAnim.set_Image((Image)(object)Resources.loading);
		((Control)pictureMenuAnim).set_Name("pictureMenuAnim");
		pictureMenuAnim.set_TabStop(false);
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)splitContainer1);
		((Control)this).get_Controls().Add((Control)(object)pictureMenuAnim);
		((Control)this).get_Controls().Add((Control)(object)toolStrip1);
		((Control)this).get_Controls().Add((Control)(object)statusStrip1);
		((Control)this).get_Controls().Add((Control)(object)menuStrip1);
		((Form)this).set_MainMenuStrip(menuStrip1);
		((Control)this).set_Name("GScanForm");
		((Form)this).add_Shown((EventHandler)formShown);
		((Form)this).add_Load((EventHandler)formLoad);
		((Control)menuStrip1).ResumeLayout(false);
		((Control)menuStrip1).PerformLayout();
		((Control)statusStrip1).ResumeLayout(false);
		((Control)statusStrip1).PerformLayout();
		((Control)toolStrip1).ResumeLayout(false);
		((Control)toolStrip1).PerformLayout();
		((Control)dorkMenuStrip).ResumeLayout(false);
		((Control)resultsMenuStrip).ResumeLayout(false);
		((Control)scanToolStrip).ResumeLayout(false);
		((Control)scanToolStrip).PerformLayout();
		((Control)splitContainer2.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer2.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer2).ResumeLayout(false);
		((Control)groupBox2).ResumeLayout(false);
		((Control)splitContainer3.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer3.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer3).ResumeLayout(false);
		((Control)groupBox3).ResumeLayout(false);
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage2).ResumeLayout(false);
		((Control)tabPage2).PerformLayout();
		((Control)groupBox1).ResumeLayout(false);
		((Control)splitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel2()).PerformLayout();
		((Control)splitContainer1).ResumeLayout(false);
		((ISupportInitialize)pictureMenuAnim).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void doThreadAnim(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = (BackgroundWorker)sender;
		while (!backgroundWorker.CancellationPending)
		{
			if (progressBar1.get_Value() == 100)
			{
				progressBar1.set_Value(0);
			}
			progressBar1.PerformStep();
			Thread.Sleep(300);
		}
		e.Cancel = true;
	}

	private void FinalThreadAnim(object sender, RunWorkerCompletedEventArgs e)
	{
		progressBar1.set_Value(0);
		((Control)progressBar1).Update();
	}
}
