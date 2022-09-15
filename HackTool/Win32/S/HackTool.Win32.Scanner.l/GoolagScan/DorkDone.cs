using System;
using System.Windows.Forms;

namespace GoolagScan;

internal class DorkDone : Dork, ICloneable
{
	private DateTime _LastScanTime;

	private int _NextPage;

	private int _ScanResult;

	private TreeNode _LastNode;

	private string _ErrorMessage;

	private string _HostScan;

	private DorkDone _Next;

	private string _ResultURL;

	private ListViewItem _ViewItem;

	private int _Requested;

	public DateTime LastScanned
	{
		get
		{
			return _LastScanTime;
		}
		set
		{
			_LastScanTime = value;
		}
	}

	public int NextPage
	{
		get
		{
			return _NextPage;
		}
		set
		{
			_NextPage = value;
		}
	}

	public int ScanResult
	{
		get
		{
			return _ScanResult;
		}
		set
		{
			_ScanResult = value;
		}
	}

	public TreeNode LastNode
	{
		get
		{
			return _LastNode;
		}
		set
		{
			_LastNode = value;
		}
	}

	public string ErrorMessage
	{
		get
		{
			return _ErrorMessage;
		}
		set
		{
			_ErrorMessage = value;
		}
	}

	public string Host
	{
		get
		{
			return _HostScan;
		}
		set
		{
			_HostScan = value;
		}
	}

	public DorkDone Next
	{
		get
		{
			return _Next;
		}
		set
		{
			_Next = value;
		}
	}

	public string ResultURL
	{
		get
		{
			return _ResultURL;
		}
		set
		{
			_ResultURL = value;
		}
	}

	public ListViewItem ViewItem
	{
		get
		{
			return _ViewItem;
		}
		set
		{
			_ViewItem = value;
		}
	}

	public int Requested
	{
		get
		{
			return _Requested;
		}
		set
		{
			_Requested = value;
		}
	}

	public DorkDone()
	{
	}

	public DorkDone(Dork dork)
	{
		base.Category = dork.Category;
		base.Comment = dork.Comment;
		base.Name = dork.Name;
		base.Query = dork.Query;
		base.Title = dork.Title;
	}

	public DorkDone(SSelectedDork dork)
	{
		base.Category = dork.Dork.Category;
		base.Comment = dork.Dork.Comment;
		base.Name = dork.Dork.Name;
		base.Query = dork.Dork.Query;
		base.Title = dork.Dork.Title;
		_LastNode = dork.TreeNode;
		_NextPage = dork.NextPage;
	}

	public void Now()
	{
		_LastScanTime = DateTime.Now;
	}

	public object Clone()
	{
		return MemberwiseClone();
	}
}
