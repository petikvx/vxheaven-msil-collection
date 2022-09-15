using System.Windows.Forms;

namespace GoolagScan;

public struct SSelectedDork
{
	private Dork _dork;

	private TreeNode _treenode;

	private int _nextpage;

	public Dork Dork
	{
		get
		{
			return _dork;
		}
		set
		{
			_dork = value;
		}
	}

	public TreeNode TreeNode
	{
		get
		{
			return _treenode;
		}
		set
		{
			_treenode = value;
		}
	}

	public int NextPage
	{
		get
		{
			return _nextpage;
		}
		set
		{
			_nextpage = value;
		}
	}

	public SSelectedDork(Dork dork, TreeNode treenode)
	{
		_dork = dork;
		_treenode = treenode;
		_nextpage = 0;
	}

	public SSelectedDork(Dork dork, TreeNode treenode, int nextpage)
	{
		_dork = dork;
		_treenode = treenode;
		_nextpage = nextpage;
	}
}
