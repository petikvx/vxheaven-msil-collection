using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GoolagScanner;

public class SearchDialog : Form
{
	private static string _searchTerm = "";

	private static TreeNode _startNode = null;

	private static bool _inName = true;

	private static bool _inComment = true;

	private static bool _inQuery = true;

	private TreeNode lastStartNode;

	private TreeNode rootnode;

	private TreeView treeview;

	private IContainer components;

	private TextBox Term;

	private Label label1;

	private Label label2;

	private CheckBox NameCheckBox;

	private CheckBox QueryCheckBox;

	private CheckBox CommentCheckBox;

	private Button FindButton;

	private Button Cancel;

	public SearchDialog(TreeView TreeToSearch, TreeNode StartHere)
	{
		InitializeComponent();
		NameCheckBox.set_Checked(_inName);
		CommentCheckBox.set_Checked(_inComment);
		QueryCheckBox.set_Checked(_inQuery);
		((Control)Term).set_Text(_searchTerm);
		_startNode = StartHere;
		rootnode = TreeToSearch.get_Nodes().get_Item(0);
		lastStartNode = null;
		treeview = TreeToSearch;
	}

	private void FindButton_Click(object sender, EventArgs e)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		_searchTerm = ((Control)Term).get_Text();
		_inName = NameCheckBox.get_Checked();
		_inQuery = QueryCheckBox.get_Checked();
		_inComment = CommentCheckBox.get_Checked();
		TreeNode val = searchNodeEx(_startNode, ((Control)Term).get_Text().ToLower(), _inName, _inQuery, _inComment);
		if (val != null)
		{
			val.get_Tag();
			val.EnsureVisible();
			treeview.set_SelectedNode(val);
			_startNode = val;
			lastStartNode = val;
		}
		else
		{
			MessageBox.Show("No Dork could be found.", "Find Dork", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void CancelButton_Click(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private TreeNode searchNodeEx(TreeNode startNode, string searchTerm, bool inName, bool inQuery, bool inComment)
	{
		TreeNode val = startNode;
		if (val == lastStartNode)
		{
			val = GetNextDorkNode(startNode);
		}
		if (val == rootnode)
		{
			val = rootnode.get_Nodes().get_Item(0);
		}
		lastStartNode = val;
		do
		{
			Dork dork = val.get_Tag() as Dork;
			if (val.get_Tag() is Category || dork == null)
			{
				val = val.get_Nodes().get_Item(0);
				dork = val.get_Tag() as Dork;
			}
			if (!inName || !dork.Name.ToLower().Contains(searchTerm))
			{
				if (!inQuery || !dork.Query.ToLower().Contains(searchTerm))
				{
					if (!inComment || !dork.Comment.ToLower().Contains(searchTerm))
					{
						val = GetNextDorkNode(val);
						continue;
					}
					return val;
				}
				return val;
			}
			return val;
		}
		while (val != lastStartNode);
		return null;
	}

	private TreeNode GetNextDorkNode(TreeNode currentNode)
	{
		currentNode = ((currentNode.get_NextNode() != null) ? currentNode.get_NextNode() : ((currentNode.get_Parent() != null) ? GetNextDorkNode(currentNode.get_Parent()) : rootnode.get_Nodes().get_Item(0)));
		return currentNode;
	}

	private void TermKeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			FindButton_Click(sender, (EventArgs)(object)e);
		}
		else if ((int)e.get_KeyCode() == 27)
		{
			((Component)this).Dispose();
		}
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		Term = new TextBox();
		label1 = new Label();
		label2 = new Label();
		NameCheckBox = new CheckBox();
		QueryCheckBox = new CheckBox();
		CommentCheckBox = new CheckBox();
		FindButton = new Button();
		Cancel = new Button();
		((Control)this).SuspendLayout();
		((Control)Term).set_Location(new Point(73, 12));
		((Control)Term).set_Name("Term");
		((Control)Term).set_Size(new Size(200, 20));
		((Control)Term).set_TabIndex(0);
		((Control)Term).add_KeyDown(new KeyEventHandler(TermKeyDown));
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(8, 15));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(59, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Search for:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(8, 39));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(55, 13));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Search in:");
		((Control)NameCheckBox).set_AutoSize(true);
		((Control)NameCheckBox).set_Location(new Point(73, 38));
		((Control)NameCheckBox).set_Name("NameCheckBox");
		((Control)NameCheckBox).set_Size(new Size(80, 17));
		((Control)NameCheckBox).set_TabIndex(3);
		((Control)NameCheckBox).set_Text("Dork Name");
		((ButtonBase)NameCheckBox).set_UseVisualStyleBackColor(true);
		((Control)QueryCheckBox).set_AutoSize(true);
		((Control)QueryCheckBox).set_Location(new Point(73, 61));
		((Control)QueryCheckBox).set_Name("QueryCheckBox");
		((Control)QueryCheckBox).set_Size(new Size(54, 17));
		((Control)QueryCheckBox).set_TabIndex(4);
		((Control)QueryCheckBox).set_Text("Query");
		((ButtonBase)QueryCheckBox).set_UseVisualStyleBackColor(true);
		((Control)CommentCheckBox).set_AutoSize(true);
		((Control)CommentCheckBox).set_Location(new Point(73, 84));
		((Control)CommentCheckBox).set_Name("CommentCheckBox");
		((Control)CommentCheckBox).set_Size(new Size(70, 17));
		((Control)CommentCheckBox).set_TabIndex(5);
		((Control)CommentCheckBox).set_Text("Comment");
		((ButtonBase)CommentCheckBox).set_UseVisualStyleBackColor(true);
		((Control)FindButton).set_Location(new Point(288, 12));
		((Control)FindButton).set_Name("FindButton");
		((Control)FindButton).set_Size(new Size(74, 23));
		((Control)FindButton).set_TabIndex(1);
		((Control)FindButton).set_Text("Find");
		((ButtonBase)FindButton).set_UseVisualStyleBackColor(true);
		((Control)FindButton).add_Click((EventHandler)FindButton_Click);
		((Control)Cancel).set_Location(new Point(288, 43));
		((Control)Cancel).set_Name("Cancel");
		((Control)Cancel).set_Size(new Size(74, 23));
		((Control)Cancel).set_TabIndex(2);
		((Control)Cancel).set_Text("Cancel");
		((ButtonBase)Cancel).set_UseVisualStyleBackColor(true);
		((Control)Cancel).add_Click((EventHandler)CancelButton_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(373, 107));
		((Control)this).get_Controls().Add((Control)(object)Cancel);
		((Control)this).get_Controls().Add((Control)(object)FindButton);
		((Control)this).get_Controls().Add((Control)(object)CommentCheckBox);
		((Control)this).get_Controls().Add((Control)(object)QueryCheckBox);
		((Control)this).get_Controls().Add((Control)(object)NameCheckBox);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)Term);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("SearchDialog");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("Find Dork");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
