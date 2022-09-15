using System.Windows.Forms;

namespace GoolagScanner;

public class Category
{
	private string _Text;

	private TreeNode _Node;

	private int _Count;

	public string Text
	{
		get
		{
			return _Text;
		}
		set
		{
			_Text = value;
		}
	}

	public TreeNode Node
	{
		get
		{
			return _Node;
		}
		set
		{
			_Node = value;
		}
	}

	public int Count
	{
		get
		{
			return _Count;
		}
		set
		{
			_Count = value;
		}
	}

	public Category()
	{
		_Text = "";
		_Count = 0;
	}
}
